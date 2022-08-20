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
            this.StatusLable = new System.Windows.Forms.Label();
            this.percentLable = new System.Windows.Forms.Label();
            this.updaterWorker = new System.ComponentModel.BackgroundWorker();
            this.StopButton = new System.Windows.Forms.Button();
            this.FullCheckButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.CurrentProgBar = new System.Windows.Forms.PictureBox();
            this.SpeedLable = new System.Windows.Forms.Label();
            this.TotalProgBar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.TotalLable = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.BackColor = System.Drawing.Color.Transparent;
            this.StatusLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusLable.Location = new System.Drawing.Point(116, 340);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(0, 19);
            this.StatusLable.TabIndex = 3;
            this.StatusLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // percentLable
            // 
            this.percentLable.AutoSize = true;
            this.percentLable.BackColor = System.Drawing.Color.Transparent;
            this.percentLable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLable.ForeColor = System.Drawing.Color.Gold;
            this.percentLable.Location = new System.Drawing.Point(570, 365);
            this.percentLable.Name = "percentLable";
            this.percentLable.Size = new System.Drawing.Size(0, 18);
            this.percentLable.TabIndex = 5;
            this.percentLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updaterWorker
            // 
            this.updaterWorker.WorkerSupportsCancellation = true;
            this.updaterWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updaterWorker_DoWork);
            this.updaterWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.updaterWorker_ProgressChanged);
            this.updaterWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updaterWorker_RunWorkerCompleted);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.No;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(555, 500);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(52, 33);
            this.StopButton.TabIndex = 6;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // FullCheckButton
            // 
            this.FullCheckButton.BackColor = System.Drawing.Color.Transparent;
            this.FullCheckButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullCheckButton.BackgroundImage")));
            this.FullCheckButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FullCheckButton.Cursor = System.Windows.Forms.Cursors.No;
            this.FullCheckButton.Enabled = false;
            this.FullCheckButton.FlatAppearance.BorderSize = 0;
            this.FullCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullCheckButton.ForeColor = System.Drawing.Color.Transparent;
            this.FullCheckButton.Location = new System.Drawing.Point(607, 0);
            this.FullCheckButton.Margin = new System.Windows.Forms.Padding(0);
            this.FullCheckButton.Name = "FullCheckButton";
            this.FullCheckButton.Size = new System.Drawing.Size(205, 55);
            this.FullCheckButton.TabIndex = 7;
            this.FullCheckButton.UseMnemonic = false;
            this.FullCheckButton.UseVisualStyleBackColor = false;
            this.FullCheckButton.Click += new System.EventHandler(this.FullCheckButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.ErrorImage")));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.InitialImage")));
            this.CloseButton.Location = new System.Drawing.Point(19, 19);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseButton.TabIndex = 8;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CurrentProgBar
            // 
            this.CurrentProgBar.BackColor = System.Drawing.Color.Transparent;
            this.CurrentProgBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentProgBar.Image = ((System.Drawing.Image)(resources.GetObject("CurrentProgBar.Image")));
            this.CurrentProgBar.Location = new System.Drawing.Point(116, 368);
            this.CurrentProgBar.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentProgBar.MaximumSize = new System.Drawing.Size(446, 16);
            this.CurrentProgBar.Name = "CurrentProgBar";
            this.CurrentProgBar.Size = new System.Drawing.Size(446, 16);
            this.CurrentProgBar.TabIndex = 9;
            this.CurrentProgBar.TabStop = false;
            this.CurrentProgBar.Click += new System.EventHandler(this.CurrentProgBar_Click);
            // 
            // SpeedLable
            // 
            this.SpeedLable.AutoSize = true;
            this.SpeedLable.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeedLable.Location = new System.Drawing.Point(500, 345);
            this.SpeedLable.Name = "SpeedLable";
            this.SpeedLable.Size = new System.Drawing.Size(0, 13);
            this.SpeedLable.TabIndex = 10;
            this.SpeedLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalProgBar
            // 
            this.TotalProgBar.BackColor = System.Drawing.Color.Transparent;
            this.TotalProgBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TotalProgBar.Image = ((System.Drawing.Image)(resources.GetObject("TotalProgBar.Image")));
            this.TotalProgBar.Location = new System.Drawing.Point(116, 401);
            this.TotalProgBar.Margin = new System.Windows.Forms.Padding(0);
            this.TotalProgBar.MaximumSize = new System.Drawing.Size(446, 16);
            this.TotalProgBar.Name = "TotalProgBar";
            this.TotalProgBar.Size = new System.Drawing.Size(446, 16);
            this.TotalProgBar.TabIndex = 11;
            this.TotalProgBar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(721, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(122, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 19);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(197, 19);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 19);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cadastro";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(436, 19);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(49, 19);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Forum";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.White;
            this.linkLabel6.Location = new System.Drawing.Point(508, 19);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(49, 19);
            this.linkLabel6.TabIndex = 20;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Painel";
            this.linkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel8.LinkColor = System.Drawing.Color.White;
            this.linkLabel8.Location = new System.Drawing.Point(292, 19);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(117, 19);
            this.linkLabel8.TabIndex = 22;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Recuperar Conta";
            this.linkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // TotalLable
            // 
            this.TotalLable.AutoSize = true;
            this.TotalLable.BackColor = System.Drawing.Color.Transparent;
            this.TotalLable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLable.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalLable.Location = new System.Drawing.Point(552, 428);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.Size = new System.Drawing.Size(0, 18);
            this.TotalLable.TabIndex = 23;
            this.TotalLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.startGameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startGameBtn.BackgroundImage")));
            this.startGameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startGameBtn.CausesValidation = false;
            this.startGameBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.startGameBtn.Enabled = false;
            this.startGameBtn.FlatAppearance.BorderSize = 0;
            this.startGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameBtn.Image = ((System.Drawing.Image)(resources.GetObject("startGameBtn.Image")));
            this.startGameBtn.Location = new System.Drawing.Point(607, 325);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(0);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(205, 118);
            this.startGameBtn.TabIndex = 24;
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(811, 440);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.TotalLable);
            this.Controls.Add(this.percentLable);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TotalProgBar);
            this.Controls.Add(this.SpeedLable);
            this.Controls.Add(this.CurrentProgBar);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.FullCheckButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater Lineage2Shield";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.Load += new System.EventHandler(this.Updater_Load);
            this.Shown += new System.EventHandler(this.Updater_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

