namespace ClientUpdater
{
    partial class Updater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            StatusLable = new Label();
            percentLable = new Label();
            updaterWorker = new System.ComponentModel.BackgroundWorker();
            StopButton = new Button();
            FullCheckButton = new Button();
            CloseButton = new PictureBox();
            CurrentProgBar = new PictureBox();
            SpeedLable = new Label();
            TotalProgBar = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            linkLabel8 = new LinkLabel();
            TotalLable = new Label();
            startGameBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentProgBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalProgBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // StatusLable
            // 
            StatusLable.AutoSize = true;
            StatusLable.BackColor = Color.Transparent;
            StatusLable.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLable.ForeColor = SystemColors.ButtonHighlight;
            StatusLable.Location = new Point(135, 392);
            StatusLable.Margin = new Padding(4, 0, 4, 0);
            StatusLable.Name = "StatusLable";
            StatusLable.Size = new Size(0, 19);
            StatusLable.TabIndex = 3;
            StatusLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // percentLable
            // 
            percentLable.AutoSize = true;
            percentLable.BackColor = Color.Transparent;
            percentLable.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            percentLable.ForeColor = Color.Gold;
            percentLable.Location = new Point(665, 421);
            percentLable.Margin = new Padding(4, 0, 4, 0);
            percentLable.Name = "percentLable";
            percentLable.Size = new Size(0, 18);
            percentLable.TabIndex = 5;
            percentLable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updaterWorker
            // 
            updaterWorker.WorkerSupportsCancellation = true;
            updaterWorker.DoWork += updaterWorker_DoWork;
            updaterWorker.ProgressChanged += updaterWorker_ProgressChanged;
            updaterWorker.RunWorkerCompleted += updaterWorker_RunWorkerCompleted;
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.Transparent;
            StopButton.Cursor = Cursors.No;
            StopButton.Enabled = false;
            StopButton.Location = new Point(648, 577);
            StopButton.Margin = new Padding(0);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(61, 38);
            StopButton.TabIndex = 6;
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Visible = false;
            StopButton.Click += StopButton_Click;
            // 
            // FullCheckButton
            // 
            FullCheckButton.BackColor = Color.Transparent;
            FullCheckButton.BackgroundImage = (Image)resources.GetObject("FullCheckButton.BackgroundImage");
            FullCheckButton.BackgroundImageLayout = ImageLayout.None;
            FullCheckButton.Cursor = Cursors.No;
            FullCheckButton.Enabled = false;
            FullCheckButton.FlatAppearance.BorderSize = 0;
            FullCheckButton.FlatStyle = FlatStyle.Flat;
            FullCheckButton.ForeColor = Color.Transparent;
            FullCheckButton.Location = new Point(708, 0);
            FullCheckButton.Margin = new Padding(0);
            FullCheckButton.Name = "FullCheckButton";
            FullCheckButton.Size = new Size(239, 63);
            FullCheckButton.TabIndex = 7;
            FullCheckButton.UseMnemonic = false;
            FullCheckButton.UseVisualStyleBackColor = false;
            FullCheckButton.Click += FullCheckButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.BackgroundImageLayout = ImageLayout.Center;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.ErrorImage = (Image)resources.GetObject("CloseButton.ErrorImage");
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.InitialImage = (Image)resources.GetObject("CloseButton.InitialImage");
            CloseButton.Location = new Point(22, 22);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(18, 18);
            CloseButton.SizeMode = PictureBoxSizeMode.AutoSize;
            CloseButton.TabIndex = 8;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // CurrentProgBar
            // 
            CurrentProgBar.BackColor = Color.Transparent;
            CurrentProgBar.BackgroundImageLayout = ImageLayout.None;
            CurrentProgBar.Image = (Image)resources.GetObject("CurrentProgBar.Image");
            CurrentProgBar.Location = new Point(135, 425);
            CurrentProgBar.Margin = new Padding(0);
            CurrentProgBar.MaximumSize = new Size(520, 18);
            CurrentProgBar.Name = "CurrentProgBar";
            CurrentProgBar.Size = new Size(520, 18);
            CurrentProgBar.TabIndex = 9;
            CurrentProgBar.TabStop = false;
            CurrentProgBar.Click += CurrentProgBar_Click;
            // 
            // SpeedLable
            // 
            SpeedLable.AutoSize = true;
            SpeedLable.BackColor = Color.Transparent;
            SpeedLable.ForeColor = SystemColors.ControlLightLight;
            SpeedLable.Location = new Point(583, 398);
            SpeedLable.Margin = new Padding(4, 0, 4, 0);
            SpeedLable.Name = "SpeedLable";
            SpeedLable.Size = new Size(0, 15);
            SpeedLable.TabIndex = 10;
            SpeedLable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TotalProgBar
            // 
            TotalProgBar.BackColor = Color.Transparent;
            TotalProgBar.BackgroundImageLayout = ImageLayout.None;
            TotalProgBar.Image = (Image)resources.GetObject("TotalProgBar.Image");
            TotalProgBar.Location = new Point(135, 463);
            TotalProgBar.Margin = new Padding(0);
            TotalProgBar.MaximumSize = new Size(520, 18);
            TotalProgBar.Name = "TotalProgBar";
            TotalProgBar.Size = new Size(520, 18);
            TotalProgBar.TabIndex = 11;
            TotalProgBar.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(841, 120);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(142, 22);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 19);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += LinkHomeClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(230, 22);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(67, 19);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Cadastro";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel2.VisitedLinkColor = Color.White;
            linkLabel2.LinkClicked += LinkRegisterClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Cursor = Cursors.Hand;
            linkLabel3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(509, 22);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(49, 19);
            linkLabel3.TabIndex = 17;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Forum";
            linkLabel3.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel3.VisitedLinkColor = Color.White;
            linkLabel3.LinkClicked += LinkForumClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel6.AutoSize = true;
            linkLabel6.BackColor = Color.Transparent;
            linkLabel6.Cursor = Cursors.Hand;
            linkLabel6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel6.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel6.LinkColor = Color.White;
            linkLabel6.Location = new Point(593, 22);
            linkLabel6.Margin = new Padding(4, 0, 4, 0);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(49, 19);
            linkLabel6.TabIndex = 20;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Painel";
            linkLabel6.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel6.VisitedLinkColor = Color.White;
            linkLabel6.LinkClicked += LinkLoginClicked;
            // 
            // linkLabel8
            // 
            linkLabel8.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel8.AutoSize = true;
            linkLabel8.BackColor = Color.Transparent;
            linkLabel8.Cursor = Cursors.Hand;
            linkLabel8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel8.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel8.LinkColor = Color.White;
            linkLabel8.Location = new Point(341, 22);
            linkLabel8.Margin = new Padding(4, 0, 4, 0);
            linkLabel8.Name = "linkLabel8";
            linkLabel8.Size = new Size(117, 19);
            linkLabel8.TabIndex = 22;
            linkLabel8.TabStop = true;
            linkLabel8.Text = "Recuperar Conta";
            linkLabel8.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel8.VisitedLinkColor = Color.White;
            linkLabel8.LinkClicked += LabelNewsClicked;
            // 
            // TotalLable
            // 
            TotalLable.AutoSize = true;
            TotalLable.BackColor = Color.Transparent;
            TotalLable.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLable.ForeColor = SystemColors.Control;
            TotalLable.Location = new Point(644, 494);
            TotalLable.Margin = new Padding(4, 0, 4, 0);
            TotalLable.Name = "TotalLable";
            TotalLable.Size = new Size(0, 18);
            TotalLable.TabIndex = 23;
            TotalLable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // startGameBtn
            // 
            startGameBtn.BackColor = Color.Transparent;
            startGameBtn.BackgroundImage = (Image)resources.GetObject("startGameBtn.BackgroundImage");
            startGameBtn.BackgroundImageLayout = ImageLayout.None;
            startGameBtn.CausesValidation = false;
            startGameBtn.Cursor = Cursors.No;
            startGameBtn.Enabled = false;
            startGameBtn.FlatAppearance.BorderSize = 0;
            startGameBtn.FlatStyle = FlatStyle.Flat;
            startGameBtn.Image = (Image)resources.GetObject("startGameBtn.Image");
            startGameBtn.Location = new Point(708, 375);
            startGameBtn.Margin = new Padding(0);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(239, 136);
            startGameBtn.TabIndex = 24;
            startGameBtn.UseVisualStyleBackColor = false;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // Updater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(946, 508);
            Controls.Add(startGameBtn);
            Controls.Add(TotalLable);
            Controls.Add(percentLable);
            Controls.Add(linkLabel8);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(TotalProgBar);
            Controls.Add(SpeedLable);
            Controls.Add(CurrentProgBar);
            Controls.Add(StatusLable);
            Controls.Add(FullCheckButton);
            Controls.Add(CloseButton);
            Controls.Add(StopButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Updater";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Updater Lineage2Shield";
            FormClosing += Updater_FormClosing;
            Load += Updater_Load;
            Shown += Updater_Shown;
            MouseDown += Updater_MouseDown;
            MouseMove += Updater_MouseMove;
            MouseUp += Updater_MouseUp;
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrentProgBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalProgBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.Label percentLable;
        private System.ComponentModel.BackgroundWorker updaterWorker;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FullCheckButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label SpeedLable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.Button startGameBtn;
        public System.Windows.Forms.PictureBox CurrentProgBar;
        public System.Windows.Forms.PictureBox TotalProgBar;
    }
}

