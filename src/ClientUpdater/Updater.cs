using L2Updater.Common;
using L2Updater.Common.Services;

using SevenZip.Sdk.Compression.Lzma;

using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ClientUpdater;

public partial class Updater : Form
{
    public string Patch = "Patch.ini";
    public string currentDirectory = Directory.GetCurrentDirectory();
    public string mainFile = Path.Combine(Directory.GetCurrentDirectory(), "system", "l2.exe");
    public string updatesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "temp");
    public HttpClient httpClient;
    public Stopwatch sw = new();
    public bool isBulkDownload = false;
    public string lastDownloadedFilePath;
    public string lastDownloadedRemoteUrl;
    public Queue<string> fileProcessQueue;
    public int totalFilesToBeProcessed = 0;
    public int totalFilesProcessed = 0;
    private CancellationTokenSource _tokenSource = new();
    bool isBusy = false;
    public bool IsBusy { get => isBusy; set => isBusy = value; }

    private Stream strResponse;
    private Stream fileStream;
    private HttpWebRequest webRequest;
    private HttpWebResponse webResponse;

    public Updater()
    {
        InitializeComponent();
        updaterWorker.WorkerReportsProgress = true;
        updaterWorker.WorkerSupportsCancellation = true;
    }

    #region Check For Instance

    [DllImport("user32.dll")]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    private static extern bool IsIconic(IntPtr hWnd);

    private const int SW_HIDE = 0;
    private const int SW_SHOWNORMAL = 1;
    private const int SW_SHOWMINIMIZED = 2;
    private const int SW_SHOWMAXIMIZED = 3;
    private const int SW_SHOWNOACTIVATE = 4;
    private const int SW_RESTORE = 9;
    private const int SW_SHOWDEFAULT = 10;

    private static bool IsAlreadyRunning()
    {
        // get all processes by Current Process name
        Process[] processes =
            Process.GetProcessesByName(
                Process.GetCurrentProcess().ProcessName);

        // if there is more than one process...
        if (processes.Length > 1)
        {
            // if other process id is OUR process ID...
            // then the other process is at index 1
            // otherwise other process is at index 0
            int n = (processes[0].Id == Process.GetCurrentProcess().Id) ? 1 : 0;

            // get the window handle
            IntPtr hWnd = processes[n].MainWindowHandle;

            // if iconic, we need to restore the window
            if (IsIconic(hWnd)) ShowWindowAsync(hWnd, SW_RESTORE);

            // Bring it to the foreground
            SetForegroundWindow(hWnd);
            return true;
        }
        return false;
    }

    public void CloseAll()
    {
        try
        {
            _tokenSource.Cancel();
            if (updaterWorker.IsBusy)
            {
                updaterWorker.CancelAsync();
            }
            updaterWorker.Dispose();
            sw.Reset();
            if (strResponse != null)
            {
                strResponse.Close();
            }
            if (fileStream != null)
            {
                fileStream.Close();
            }
            ResetUIElements();
        }
        catch { }
    }

    private void Updater_Load(object sender, EventArgs e)
    {
        if (IsAlreadyRunning())
        {
            MessageBox.Show(AppMessages.UpdaterAlreadyOpen, AppMessages.UpdaterAppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }

    private void Updater_FormClosing(object sender, FormClosingEventArgs e)
    {
        CloseAll();
        if (Directory.Exists(updatesDirectory))
        {
            Directory.Delete(updatesDirectory, true);
        }
    }

    private void Updater_Shown(object sender, EventArgs e)
    {
        CloseButton.Refresh();
        DisableFullCheckButton();
        DisableStartGameButton();
        DisableStopButton();
        if (!File.Exists(mainFile))
        {
            DoFullCheck();
        }
        else
        {
            DoVersionCheck();
        }
    }

    private void updaterWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        var worker = sender as BackgroundWorker;
        TotalProgBar.Width = 0;
        while (fileProcessQueue.Count > 0)
        {
            CurrentProgBar.Width = 0;
            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                break;
            }
            var fileData = fileProcessQueue.Dequeue();
            totalFilesProcessed++;
            var percentage = (int)Math.Round((double)(100 * totalFilesProcessed) / totalFilesToBeProcessed);
            updaterWorker.ReportProgress(percentage);
            var fileDataArray = fileData.Split('|');
            if (fileDataArray.Length < 3)
            {
                continue;
            }
            Invoke((MethodInvoker)delegate
            {
                SpeedLable.Text = "";
                percentLable.Text = "";
                StatusLable.Text = string.Format(AppMessages.CheckingFiles, totalFilesProcessed, totalFilesToBeProcessed);
            });
            var localPathToCheck = currentDirectory + fileDataArray[1];
            var pathToDownload = updatesDirectory + fileDataArray[1] + ".7z";
            if (!File.Exists(currentDirectory + fileDataArray[1]) || GetFileMD5Hash(currentDirectory + fileDataArray[1]) != fileDataArray[0])
            {
                Invoke((MethodInvoker)delegate
                {
                    StatusLable.Text = "Baixando " + FileNameFromPath(localPathToCheck);
                });
                Directory.CreateDirectory(Path.GetDirectoryName(pathToDownload)!);
                try
                {
                    // Create a request to the file we are downloading
                    webRequest = (HttpWebRequest)WebRequest.Create(AppConstants.PatchHost + fileDataArray[2]);
                    // Set the starting point of the request
                    webRequest.AddRange(0);
                    // Set default authentication for retrieving the file
                    webRequest.Credentials = CredentialCache.DefaultCredentials;
                    // Retrieve the response from the server
                    webResponse = (HttpWebResponse)webRequest.GetResponse();
                    // Ask the server for the file size and store it
                    long fileSize = webResponse.ContentLength;
                    // Start the stopwatch which we will be using to calculate the download speed
                    sw.Start();
                    // Open the URL for download
                    strResponse = webResponse.GetResponseStream();
                    // Create a new file stream where we will be saving the data (local drive)
                    // Read from response and write to file
                    fileStream = new FileStream(pathToDownload, FileMode.Create, FileAccess.Write, FileShare.None);
                    // It will store the current number of bytes we retrieved from the server
                    int bytesSize = 0;
                    // A buffer for storing and writing the data retrieved from the server
                    byte[] downBuffer = new byte[2048];

                    // Loop through the buffer until the buffer is empty
                    while ((bytesSize = strResponse.Read(downBuffer, 0, downBuffer.Length)) != 0)
                    {
                        fileStream.Write(downBuffer, 0, bytesSize);
                        // Invoke a method to update form's label and progress bar
                        Invoke((MethodInvoker)delegate
                        {
                            // Calculate the download progress in percentages
                            var PercentProgress = Convert.ToInt32((fileStream.Length * 100) / fileSize);
                            // Make progress on the progress bar
                            CurrentProgBar.Width = Convert.ToInt32(Math.Round(PercentProgress / 100.0 * 446.0));
                            // Display the current progress on the form
                            percentLable.Text = PercentProgress + "%";
                            SpeedLable.Text = (Convert.ToDouble(fileStream.Length) / 1024 / sw.Elapsed.TotalSeconds).ToString("0.00") + " kb/s";
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Reset();
                    strResponse.Close();
                    fileStream.Close();
                    var decompressedFile = pathToDownload.Remove(pathToDownload.LastIndexOf(".7z"));
                    DecompressFileLZMA(pathToDownload, decompressedFile);
                    File.Delete(pathToDownload);
                    if (!File.Exists(currentDirectory + fileDataArray[1]))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(currentDirectory + fileDataArray[1]));
                    }
                    else
                    {
                        File.Delete(currentDirectory + fileDataArray[1]);
                    }
                    File.Move(decompressedFile, currentDirectory + fileDataArray[1]);
                }
            }
        }
    }

    // This event handler updates the progress.
    private void updaterWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        TotalProgBar.Width = Convert.ToInt32(Math.Round(e.ProgressPercentage / 100.0 * 446.0));
    }

    private void updaterWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        ResetUIElements();
        DisableStopButton();
        EnableFullCheckButton();
        EnableStartGameButton();
        if (e.Cancelled == true)
        {
            StatusLable.Text = "Verificação de arquivos encerrado manualmente";
        }
        else if (e.Error != null)
        {
            StatusLable.Text = e.Error.Message;
            MessageBox.Show(e.Error.Message, "Updater Lineage2Shield", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            StatusLable.Text = "Todos os arquivos estão atualizados, bom jogo!";
        }
        clearDirectory(updatesDirectory);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private int mouseStartX, mouseStartY;
    private int formStartX, formStartY;
    private bool FormDragging = false;

    private void Updater_MouseDown(object sender, MouseEventArgs e)
    {
        mouseStartX = MousePosition.X;
        mouseStartY = MousePosition.Y;
        formStartX = Location.X;
        formStartY = Location.Y;
        FormDragging = true;
    }

    private void Updater_MouseMove(object sender, MouseEventArgs e)
    {
        if (FormDragging)
        {
            Location = new Point(
            formStartX + MousePosition.X - mouseStartX,
            formStartY + MousePosition.Y - mouseStartY
            );
        }
    }

    private void Updater_MouseUp(object sender, MouseEventArgs e)
    {
        FormDragging = false;
    }

    private void LinkHomeClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost);
    }

    private void LinkRegisterClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost + "/index.php?icp=panel&show=register");
    }

    private void LinkForumClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost + "/forum");
    }

    private void LinkPasswordResetClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost + "/request-password-reset");
    }

    private void LinkPasswordRecoveryClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost + "/index.php?icp=panel&show=recovery");
    }

    private void LinkLoginClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost + "/login");
    }

    private void LinkDownloadClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost + "/download");
    }

    private void LabelNewsClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(AppConstants.WebHost + "/news");
    }

    #endregion Check For Instance

    private void ResetUIElements()
    {
        StatusLable.Text = "";
        DisableStopButton();
        EnableFullCheckButton();
        SpeedLable.Text = "";
        percentLable.Text = "";
        TotalLable.Text = "";
        TotalProgBar.Width = 446;
        CurrentProgBar.Width = 446;
    }

    private string GetFileMD5Hash(string path)
    {
        using var md5 = MD5.Create();
        using var stream = File.OpenRead(path);
        return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
    }

    private void clearDirectory(string path)
    {
        try
        {
            var di = new DirectoryInfo(path);
            foreach (var file in di.GetFiles())
                file.Delete();
            foreach (var dir in di.GetDirectories())
                dir.Delete(true);
            
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show(ex.Message, AppMessages.UpdaterAppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DecompressFileLZMA(string source, string destination)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(destination)!);
        var coder = new Decoder();
        var input = new FileStream(source, FileMode.Open);
        var output = new FileStream(destination, FileMode.Create);

        // Read the decoder properties
        byte[] properties = new byte[5];
        input.Read(properties, 0, 5);

        // Read in the decompress file size.
        byte[] fileLengthBytes = new byte[8];
        input.Read(fileLengthBytes, 0, 8);
        long fileLength = BitConverter.ToInt64(fileLengthBytes, 0);

        coder.SetDecoderProperties(properties);
        coder.Code(input, output, input.Length, fileLength, null);
        output.Flush();
        output.Close();
        input.Flush();
        input.Close();
    }

    private void EnableStopButton()
    {
        StopButton.Enabled = true;
        StopButton.Cursor = Cursors.Hand;
    }

    private void DisableStopButton()
    {
        StopButton.Enabled = false;
        StopButton.Cursor = Cursors.No;
    }

    private void EnableFullCheckButton()
    {
        FullCheckButton.Enabled = true;
        FullCheckButton.Cursor = Cursors.Hand;
    }

    private void DisableFullCheckButton()
    {
        FullCheckButton.Enabled = false;
        FullCheckButton.Cursor = Cursors.No;
    }

    private void EnableStartGameButton()
    {
        startGameBtn.Enabled = true;
        startGameBtn.Cursor = Cursors.Hand;
    }

    private void DisableStartGameButton()
    {
        startGameBtn.Enabled = false;
        startGameBtn.Cursor = Cursors.No;
    }

    private void DoFullCheck()
    {
        if (Directory.Exists(updatesDirectory))
            clearDirectory(updatesDirectory);
        else        
            Directory.CreateDirectory(updatesDirectory);
        
        StatusLable.Text = "Iniciando Full Check...";
        totalFilesProcessed = 0;
        totalFilesToBeProcessed = 0;
        DisableFullCheckButton();
        DisableStartGameButton();
        EnableStopButton();
        Task.Run(() => DownloadFile("full.ini", Path.Combine(updatesDirectory, "full.ini"), OnDownloadProgressChanged, OnIniDownloadCompleted));
    }

    private void DoVersionCheck()
    {
        if (Directory.Exists(updatesDirectory))
            clearDirectory(updatesDirectory);
        else
            Directory.CreateDirectory(updatesDirectory);
        StatusLable.Text = "Checando a versão do patch...";
        EnableStopButton();
        Task.Run(() => DownloadFile("patch.ini", Path.Combine(updatesDirectory, "patch.ini"), OnDownloadProgressChanged, OnIniDownloadCompleted));
    }

    private async Task DownloadFile(string urlAddress, string location, Action<long?, long, double?> downloadProgressCallback, AsyncCompletedEventHandler downloadCompleteCallback)
    {
        lastDownloadedFilePath = location;
        lastDownloadedRemoteUrl = urlAddress;
        // The variable that will be holding the url address (making sure it starts with http://)
        var url = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase)
            ? new Uri(urlAddress)
            : new Uri(new Uri(AppConstants.PatchHost), urlAddress);
        using (var httpClient = new HttpClientDownloadWithProgress(url, location))
        {
            httpClient.ProgressChanged += (total, downloaded, percent)
                => downloadProgressCallback(total, downloaded, percent);            

            // Start the stopwatch which we will be using to calculate the download speed
            sw.Start();

            try
            {
                IsBusy = true;
                // Start downloading the file
                await httpClient.StartDownload(_tokenSource.Token);
            }
            catch (Exception ex)
            {
                StatusLable.Text = ex.Message;
            }
        }
        IsBusy = false;
    }

    // The event that will fire whenever the progress of the WebClient is changed
    private void OnDownloadProgressChanged(long? total, long downloaded, double? percentage)
    {
        // Calculate download speed and output it to labelSpeed.
        SpeedLable.Text = string.Format("{0} kb/s", (downloaded / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

        // Update the progressbar percentage only when the value is not the same.
        CurrentProgBar.Width = Convert.ToInt32(Math.Round(percentage!.Value / 100.0 * 446.0));

        // Show the percentage on our label.
        percentLable.Text = percentage.ToString() + "%";

        // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
        /**labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
            (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
            (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));**/
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        CloseAll();
        if (Directory.Exists(updatesDirectory))
        {
            try
            {
                Directory.Delete(updatesDirectory, true);
            }
            catch { }
        }
        Environment.Exit(0);
    }

    private void FullCheckButton_Click(object sender, EventArgs e)
    {
        if (!IsBusy)
        {
            DoFullCheck();
        }
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        _tokenSource.Cancel();
        if (updaterWorker.IsBusy)
            updaterWorker.CancelAsync();
        updaterWorker.Dispose();
        sw.Reset();
        strResponse.Close();
        fileStream.Close();
        DisableStopButton();
        EnableFullCheckButton();
        EnableStartGameButton();
    }

    private void startGameBtn_Click(object sender, EventArgs e)
    {
        if (File.Exists(mainFile))
        {
            Process.Start(mainFile, "jimmy");
            Environment.Exit(0);
        }
        else
        {
            MessageBox.Show(AppMessages.GameExeNotFound, AppMessages.UpdaterAppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OnIniDownloadCompleted(object sender, AsyncCompletedEventArgs e)
    {
        // Reset the stopwatch.
        sw.Reset();
        DisableStopButton();
        EnableFullCheckButton();
        DisableStartGameButton();
        SpeedLable.Text = "";
        percentLable.Text = "";
        if (e.Cancelled == true)
        {
            EnableStartGameButton();
            StatusLable.Text = AppMessages.PatchingProcessCanceled;
        }
        else if (e.Error != null)
        {
            EnableStartGameButton();
            StatusLable.Text = e.Error.Message;
            MessageBox.Show(e.Error.Message, AppMessages.UpdaterAppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            var iniFile = new StreamReader(lastDownloadedFilePath);
            var iniFileData = iniFile.ReadToEnd();
            iniFile.Close();
            fileProcessQueue = new Queue<string>(iniFileData.Split(';'));
            BulkFileProcess();
        }
    }

    private void OnVersionDownloadCompleted(object sender, AsyncCompletedEventArgs e)
    {
        sw.Reset();
        DisableStopButton();
        DisableStartGameButton();
        SpeedLable.Text = "";
        percentLable.Text = "";
        if (e.Cancelled == true)
        {
            EnableStartGameButton();
            StatusLable.Text = AppMessages.VersionCheckedStoppedManually;
        }
        else if (e.Error != null)
        {
            EnableStartGameButton();
            StatusLable.Text = e.Error.Message;
            MessageBox.Show(e.Error.Message, AppMessages.UpdaterAppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            Task.Run(() => DownloadFile("patch.ini", Path.Combine(updatesDirectory, "patch.ini"), OnDownloadProgressChanged, OnIniDownloadCompleted));
        }
    }

    private void BulkFileProcess()
    {
        totalFilesToBeProcessed = fileProcessQueue.Count;
        StatusLable.Text = string.Format(AppMessages.TotalFilesProcessed, totalFilesProcessed);
        DisableFullCheckButton();
        DisableStartGameButton();
        EnableStopButton();
        if (!updaterWorker.IsBusy)
            updaterWorker.RunWorkerAsync();
    }

    private void CurrentProgBar_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private string FileNameFromPath(string path)
    {
        var pathArray = path.Split('\\');
        return pathArray[pathArray.Length - 1];
    }

    private void MoveDirectory(string source, string target)
    {
        var stack = new Stack<Folders>();
        stack.Push(new Folders(source, target));
        while (stack.Count > 0)
        {
            var folders = stack.Pop();
            Directory.CreateDirectory(folders.Target);
            foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
            {
                var targetFile = Path.Combine(folders.Target, Path.GetFileName(file));
                if (File.Exists(targetFile))
                    File.Delete(targetFile);
                File.Move(file, targetFile);
            }
            foreach (var folder in Directory.GetDirectories(folders.Source))
                stack.Push(new Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
        }
        Directory.Delete(source, true);
    }
}