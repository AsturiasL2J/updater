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
            labelStatus = new Label();
            labelPercent = new Label();
            updaterWorker = new System.ComponentModel.BackgroundWorker();
            StopButton = new Button();
            FullCheckButton = new Button();
            CloseButton = new PictureBox();
            CurrentProgBar = new PictureBox();
            labelSpeed = new Label();
            TotalProgBar = new PictureBox();
            linkHome = new LinkLabel();
            linkRegister = new LinkLabel();
            linkForum = new LinkLabel();
            linkAccountPanel = new LinkLabel();
            linkAccountRecovery = new LinkLabel();
            labelTotal = new Label();
            startGameBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentProgBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalProgBar).BeginInit();
            SuspendLayout();
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.ForeColor = SystemColors.ButtonHighlight;
            labelStatus.Location = new Point(151, 368);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 19);
            labelStatus.TabIndex = 3;
            labelStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPercent
            // 
            labelPercent.AutoSize = true;
            labelPercent.BackColor = Color.Transparent;
            labelPercent.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPercent.ForeColor = Color.Gold;
            labelPercent.Location = new Point(677, 421);
            labelPercent.Margin = new Padding(4, 0, 4, 0);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(0, 18);
            labelPercent.TabIndex = 5;
            labelPercent.TextAlign = ContentAlignment.MiddleRight;
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
            StopButton.Location = new Point(764, 396);
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
            FullCheckButton.Location = new Point(710, 3);
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
            CurrentProgBar.Location = new Point(135, 402);
            CurrentProgBar.Margin = new Padding(0);
            CurrentProgBar.MaximumSize = new Size(520, 18);
            CurrentProgBar.Name = "CurrentProgBar";
            CurrentProgBar.Size = new Size(520, 18);
            CurrentProgBar.TabIndex = 9;
            CurrentProgBar.TabStop = false;
            CurrentProgBar.Click += CurrentProgBar_Click;
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.BackColor = Color.Transparent;
            labelSpeed.ForeColor = SystemColors.ControlLightLight;
            labelSpeed.Location = new Point(677, 396);
            labelSpeed.Margin = new Padding(4, 0, 4, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(0, 15);
            labelSpeed.TabIndex = 10;
            labelSpeed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TotalProgBar
            // 
            TotalProgBar.BackColor = Color.Transparent;
            TotalProgBar.BackgroundImageLayout = ImageLayout.None;
            TotalProgBar.Image = (Image)resources.GetObject("TotalProgBar.Image");
            TotalProgBar.Location = new Point(135, 438);
            TotalProgBar.Margin = new Padding(0);
            TotalProgBar.MaximumSize = new Size(520, 18);
            TotalProgBar.Name = "TotalProgBar";
            TotalProgBar.Size = new Size(520, 18);
            TotalProgBar.TabIndex = 11;
            TotalProgBar.TabStop = false;
            // 
            // linkHome
            // 
            linkHome.ActiveLinkColor = Color.WhiteSmoke;
            linkHome.AutoSize = true;
            linkHome.BackColor = Color.Transparent;
            linkHome.Cursor = Cursors.Hand;
            linkHome.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            linkHome.LinkColor = Color.White;
            linkHome.Location = new Point(142, 22);
            linkHome.Margin = new Padding(4, 0, 4, 0);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(47, 19);
            linkHome.TabIndex = 15;
            linkHome.TabStop = true;
            linkHome.Text = "Home";
            linkHome.TextAlign = ContentAlignment.MiddleCenter;
            linkHome.VisitedLinkColor = Color.White;
            linkHome.LinkClicked += LinkHomeClicked;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.WhiteSmoke;
            linkRegister.AutoSize = true;
            linkRegister.BackColor = Color.Transparent;
            linkRegister.Cursor = Cursors.Hand;
            linkRegister.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegister.LinkBehavior = LinkBehavior.HoverUnderline;
            linkRegister.LinkColor = Color.White;
            linkRegister.Location = new Point(230, 22);
            linkRegister.Margin = new Padding(4, 0, 4, 0);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(67, 19);
            linkRegister.TabIndex = 16;
            linkRegister.TabStop = true;
            linkRegister.Text = "Cadastro";
            linkRegister.TextAlign = ContentAlignment.MiddleCenter;
            linkRegister.VisitedLinkColor = Color.White;
            linkRegister.LinkClicked += LinkRegisterClicked;
            // 
            // linkForum
            // 
            linkForum.ActiveLinkColor = Color.WhiteSmoke;
            linkForum.AutoSize = true;
            linkForum.BackColor = Color.Transparent;
            linkForum.Cursor = Cursors.Hand;
            linkForum.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkForum.LinkBehavior = LinkBehavior.HoverUnderline;
            linkForum.LinkColor = Color.White;
            linkForum.Location = new Point(509, 22);
            linkForum.Margin = new Padding(4, 0, 4, 0);
            linkForum.Name = "linkForum";
            linkForum.Size = new Size(49, 19);
            linkForum.TabIndex = 17;
            linkForum.TabStop = true;
            linkForum.Text = "Forum";
            linkForum.TextAlign = ContentAlignment.MiddleCenter;
            linkForum.VisitedLinkColor = Color.White;
            linkForum.LinkClicked += LinkForumClicked;
            // 
            // linkAccountPanel
            // 
            linkAccountPanel.ActiveLinkColor = Color.WhiteSmoke;
            linkAccountPanel.AutoSize = true;
            linkAccountPanel.BackColor = Color.Transparent;
            linkAccountPanel.Cursor = Cursors.Hand;
            linkAccountPanel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkAccountPanel.LinkBehavior = LinkBehavior.HoverUnderline;
            linkAccountPanel.LinkColor = Color.White;
            linkAccountPanel.Location = new Point(593, 22);
            linkAccountPanel.Margin = new Padding(4, 0, 4, 0);
            linkAccountPanel.Name = "linkAccountPanel";
            linkAccountPanel.Size = new Size(49, 19);
            linkAccountPanel.TabIndex = 20;
            linkAccountPanel.TabStop = true;
            linkAccountPanel.Text = "Painel";
            linkAccountPanel.TextAlign = ContentAlignment.MiddleCenter;
            linkAccountPanel.VisitedLinkColor = Color.White;
            linkAccountPanel.LinkClicked += LinkLoginClicked;
            // 
            // linkAccountRecovery
            // 
            linkAccountRecovery.ActiveLinkColor = Color.WhiteSmoke;
            linkAccountRecovery.AutoSize = true;
            linkAccountRecovery.BackColor = Color.Transparent;
            linkAccountRecovery.Cursor = Cursors.Hand;
            linkAccountRecovery.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkAccountRecovery.LinkBehavior = LinkBehavior.HoverUnderline;
            linkAccountRecovery.LinkColor = Color.White;
            linkAccountRecovery.Location = new Point(341, 22);
            linkAccountRecovery.Margin = new Padding(4, 0, 4, 0);
            linkAccountRecovery.Name = "linkAccountRecovery";
            linkAccountRecovery.Size = new Size(117, 19);
            linkAccountRecovery.TabIndex = 22;
            linkAccountRecovery.TabStop = true;
            linkAccountRecovery.Text = "Recuperar Conta";
            linkAccountRecovery.TextAlign = ContentAlignment.MiddleCenter;
            linkAccountRecovery.VisitedLinkColor = Color.White;
            linkAccountRecovery.LinkClicked += LabelNewsClicked;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.Transparent;
            labelTotal.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.ForeColor = SystemColors.Control;
            labelTotal.Location = new Point(669, 438);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(0, 18);
            labelTotal.TabIndex = 23;
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
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
            startGameBtn.Location = new Point(710, 361);
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
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(946, 480);
            Controls.Add(startGameBtn);
            Controls.Add(labelTotal);
            Controls.Add(labelPercent);
            Controls.Add(linkAccountRecovery);
            Controls.Add(linkAccountPanel);
            Controls.Add(linkForum);
            Controls.Add(linkRegister);
            Controls.Add(linkHome);
            Controls.Add(TotalProgBar);
            Controls.Add(labelSpeed);
            Controls.Add(CurrentProgBar);
            Controls.Add(labelStatus);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPercent;
        private System.ComponentModel.BackgroundWorker updaterWorker;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FullCheckButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.LinkLabel linkHome;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.LinkLabel linkForum;
        private System.Windows.Forms.LinkLabel linkAccountPanel;
        private System.Windows.Forms.LinkLabel linkAccountRecovery;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button startGameBtn;
        public System.Windows.Forms.PictureBox CurrentProgBar;
        public System.Windows.Forms.PictureBox TotalProgBar;
    }
}

