﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PatchGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            patchWorker.WorkerReportsProgress = true;
            patchWorker.WorkerSupportsCancellation = true;
        }

        private void inputFolderTb_TextChanged(object sender, EventArgs e)
        {
            inputError.Visible = false;
            if (!Directory.Exists(inputFolderTb.Text))
            {
                inputError.Visible = true;
            }
        }

        private void outputFolderTb_TextChanged(object sender, EventArgs e)
        {
            outputError.Visible = false;
            if (!Directory.Exists(outputFolderTb.Text))
            {
                outputError.Visible = true;
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            // Show error if invalid path
            if (!Directory.Exists(inputFolderTb.Text))
            {
                inputError.Visible = true;
                return;
            }
            if (!Directory.Exists(outputFolderTb.Text))
            {
                outputError.Visible = true;
                return;
            }
            // Trimming string so we can safely compare and append later
            string inputPath = inputFolderTb.Text.TrimEnd('\\');
            string outputPath = outputFolderTb.Text.TrimEnd('\\');
            // Show error if input is same as output
            if (inputPath == outputPath)
            {
                MessageBox.Show("Os diretórios de entrada e saída não podem ser iguais", "Lineage2Shield Patch Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (patchWorker.IsBusy != true)
            {
                showLoading();
                outputLabel.Text = "Processo de patch iniciado";
                patchWorker.RunWorkerAsync();
            }
        }

        private void clearDirectory(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lineage2Shield Patch Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showLoading()
        {
            cancelBtn.Enabled = true;
            generateBtn.Text = "Gerando...";
            generateBtn.Enabled = false;
            inputFolderTb.Enabled = false;
            outputFolderTb.Enabled = false;
        }

        private void resetLoading()
        {
            cancelBtn.Enabled = false;
            generateBtn.Text = "Patch pronto";
            generateBtn.Enabled = true;
            inputFolderTb.Enabled = true;
            outputFolderTb.Enabled = true;
        }

        private IEnumerable<string> GetFiles(string path)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Generating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lineage2Shield Patch Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }

        private string GetFileMD5Hash(string path)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        private void CompressFileLZMA(string source, string destination)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(destination));
            SevenZip.Compression.LZMA.Encoder coder = new SevenZip.Compression.LZMA.Encoder();
            FileStream input = new FileStream(source, FileMode.Open);
            FileStream output = new FileStream(destination, FileMode.Create);

            // Write the encoder properties
            coder.WriteCoderProperties(output);

            // Write the decompressed file size.
            output.Write(BitConverter.GetBytes(input.Length), 0, 8);

            // Encode the file.
            coder.Code(input, output, input.Length, -1, null);
            output.Flush();
            output.Close();
        }

        private void patchWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            string inputPath = inputFolderTb.Text.TrimEnd('\\');
            string outputPath = outputFolderTb.Text.TrimEnd('\\');
            // Clear old files if any inside output
            clearDirectory(outputPath);
            var patchFileWriter = new StreamWriter(outputPath + @"\patch.ini");
            try
            {
                var fileList = this.GetFiles(inputPath);
                foreach (string fileName in fileList)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    var hash = GetFileMD5Hash(fileName);
                    var relativePath = fileName.Replace(inputPath, "");
                    var remotePath = relativePath.Replace(@"\", "/") + ".7z";
                    patchFileWriter.Write(hash + "|" + relativePath + "|" + remotePath + ";");
                    Invoke((MethodInvoker)delegate
                    {
                        outputLabel.Text = "Processando " + relativePath.TrimStart('\\');
                    });
                    CompressFileLZMA(fileName, fileName.Replace(inputPath, outputPath) + ".7z");
                }
                patchFileWriter.Close();
            }
            catch (Exception ex)
            {
                patchFileWriter.Close();
                throw ex;
            }
        }

        private void patchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            resetLoading();
            if (e.Cancelled == true)
            {
                MessageBox.Show("Patch cancelado", "Lineage2Shield Patch Generator");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Lineage2Shield Patch Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Seu novo patch está pronto", "Lineage2Shield Patch Generator");
            }
            outputLabel.Text = "Clique em Gerar para iniciar";
        }

        private void patchWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Maybe show the file name getting processed
            // Refer https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker?redirectedfrom=MSDN&view=netframework-2.0
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (patchWorker.WorkerSupportsCancellation == true)
            {
                patchWorker.CancelAsync();
                resetLoading();
            }
        }

        private void headingLabel_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}