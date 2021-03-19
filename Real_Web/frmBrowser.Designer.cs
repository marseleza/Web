namespace Real_Web
{
    partial class frmBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.img_Spinner = new Bunifu.Framework.UI.BunifuImageButton();
            this.img_Refresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Settings = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Download = new Bunifu.Framework.UI.BunifuImageButton();
            this.tb_Search = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_Refresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Forward = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Home = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Spinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.Controls.Add(this.btn_Settings);
            this.bunifuCards1.Controls.Add(this.btn_Download);
            this.bunifuCards1.Controls.Add(this.tb_Search);
            this.bunifuCards1.Controls.Add(this.btn_Refresh);
            this.bunifuCards1.Controls.Add(this.btn_Forward);
            this.bunifuCards1.Controls.Add(this.btn_Home);
            this.bunifuCards1.Controls.Add(this.btn_Back);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-8, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(905, 64);
            this.bunifuCards1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-5, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(893, 504);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigating);
            // 
            // img_Spinner
            // 
            this.img_Spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.img_Spinner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.img_Spinner.Image = global::Real_Web.Properties.Resources.XOsX;
            this.img_Spinner.ImageActive = null;
            this.img_Spinner.Location = new System.Drawing.Point(81, 416);
            this.img_Spinner.Name = "img_Spinner";
            this.img_Spinner.Size = new System.Drawing.Size(88, 67);
            this.img_Spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Spinner.TabIndex = 3;
            this.img_Spinner.TabStop = false;
            this.toolTip1.SetToolTip(this.img_Spinner, "Back");
            this.img_Spinner.Visible = false;
            this.img_Spinner.Zoom = 10;
            // 
            // img_Refresh
            // 
            this.img_Refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.img_Refresh.Image = global::Real_Web.Properties.Resources.refresh_64px;
            this.img_Refresh.ImageActive = null;
            this.img_Refresh.Location = new System.Drawing.Point(30, 429);
            this.img_Refresh.Name = "img_Refresh";
            this.img_Refresh.Size = new System.Drawing.Size(45, 40);
            this.img_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Refresh.TabIndex = 2;
            this.img_Refresh.TabStop = false;
            this.toolTip1.SetToolTip(this.img_Refresh, "Back");
            this.img_Refresh.Visible = false;
            this.img_Refresh.Zoom = 10;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Settings.Image = global::Real_Web.Properties.Resources.settings_64px;
            this.btn_Settings.ImageActive = null;
            this.btn_Settings.Location = new System.Drawing.Point(835, 12);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(45, 40);
            this.btn_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Settings, "Settings");
            this.btn_Settings.Zoom = 10;
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Download.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Download.Image = global::Real_Web.Properties.Resources.download_64px;
            this.btn_Download.ImageActive = null;
            this.btn_Download.Location = new System.Drawing.Point(773, 12);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(45, 40);
            this.btn_Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Download.TabIndex = 5;
            this.btn_Download.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Download, "Download");
            this.btn_Download.Zoom = 10;
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.BackColor = System.Drawing.Color.Silver;
            this.tb_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_Search.BackgroundImage")));
            this.tb_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tb_Search.Icon = ((System.Drawing.Image)(resources.GetObject("tb_Search.Icon")));
            this.tb_Search.Location = new System.Drawing.Point(278, 12);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(488, 40);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.text = "Enter URL";
            this.tb_Search.KeyUp += new System.EventHandler(this.tb_Search_KeyUp);
            this.tb_Search.Click += new System.EventHandler(this.tb_Search_KeyUp);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Refresh.Image = global::Real_Web.Properties.Resources.refresh_64px;
            this.btn_Refresh.ImageActive = null;
            this.btn_Refresh.Location = new System.Drawing.Point(226, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(45, 40);
            this.btn_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Refresh, "Refresh");
            this.btn_Refresh.Zoom = 10;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Forward.Image = global::Real_Web.Properties.Resources.forward_64px;
            this.btn_Forward.ImageActive = null;
            this.btn_Forward.Location = new System.Drawing.Point(82, 12);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(45, 40);
            this.btn_Forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Forward.TabIndex = 3;
            this.btn_Forward.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Forward, "Forward");
            this.btn_Forward.Zoom = 10;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Home.Image = global::Real_Web.Properties.Resources.home_64px;
            this.btn_Home.ImageActive = null;
            this.btn_Home.Location = new System.Drawing.Point(153, 12);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(45, 40);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Home.TabIndex = 2;
            this.btn_Home.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Home, "Home");
            this.btn_Home.Zoom = 10;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.Image = global::Real_Web.Properties.Resources.back_32px;
            this.btn_Back.ImageActive = null;
            this.btn_Back.Location = new System.Drawing.Point(20, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(45, 40);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Back.TabIndex = 1;
            this.btn_Back.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Back, "Back");
            this.btn_Back.Zoom = 10;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(890, 560);
            this.Controls.Add(this.img_Spinner);
            this.Controls.Add(this.img_Refresh);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bunifuCards1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Spinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Back;
        private Bunifu.Framework.UI.BunifuImageButton btn_Refresh;
        private Bunifu.Framework.UI.BunifuImageButton btn_Forward;
        private Bunifu.Framework.UI.BunifuImageButton btn_Home;
        private Bunifu.Framework.UI.BunifuTextbox tb_Search;
        private Bunifu.Framework.UI.BunifuImageButton btn_Settings;
        private Bunifu.Framework.UI.BunifuImageButton btn_Download;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton img_Refresh;
        private Bunifu.Framework.UI.BunifuImageButton img_Spinner;
    }
}