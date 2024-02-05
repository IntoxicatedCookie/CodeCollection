namespace PluginChecker.Views
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.AnalysisTitle = new System.Windows.Forms.Label();
            this.AnalysisDesc = new System.Windows.Forms.Label();
            this.TagNew = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.PictureBox();
            this.BrowseTitle = new System.Windows.Forms.Label();
            this.BrowseDesc = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.PictureBox();
            this.GreetingTitle = new System.Windows.Forms.Label();
            this.BtnInfo = new System.Windows.Forms.PictureBox();
            this.BtnUpdates = new System.Windows.Forms.PictureBox();
            this.BtnRepIssue = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRepIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // AnalysisTitle
            // 
            this.AnalysisTitle.AutoSize = true;
            this.AnalysisTitle.BackColor = System.Drawing.Color.Transparent;
            this.AnalysisTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnalysisTitle.ForeColor = System.Drawing.Color.White;
            this.AnalysisTitle.Location = new System.Drawing.Point(43, 139);
            this.AnalysisTitle.Name = "AnalysisTitle";
            this.AnalysisTitle.Size = new System.Drawing.Size(294, 25);
            this.AnalysisTitle.TabIndex = 10;
            this.AnalysisTitle.Text = "Version Incompatibility Analysis\r\n";
            // 
            // AnalysisDesc
            // 
            this.AnalysisDesc.AutoSize = true;
            this.AnalysisDesc.BackColor = System.Drawing.Color.Transparent;
            this.AnalysisDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnalysisDesc.ForeColor = System.Drawing.Color.White;
            this.AnalysisDesc.Location = new System.Drawing.Point(12, 182);
            this.AnalysisDesc.Name = "AnalysisDesc";
            this.AnalysisDesc.Size = new System.Drawing.Size(353, 60);
            this.AnalysisDesc.TabIndex = 12;
            this.AnalysisDesc.Text = "Analyse GTA V, RagePluginHook, LSPDFR and Plugin\r\nversions to look for version in" +
    "compatibilities \r\nand risks.";
            this.AnalysisDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TagNew
            // 
            this.TagNew.AutoSize = true;
            this.TagNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.TagNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TagNew.ForeColor = System.Drawing.Color.White;
            this.TagNew.Location = new System.Drawing.Point(165, 109);
            this.TagNew.Name = "TagNew";
            this.TagNew.Size = new System.Drawing.Size(49, 20);
            this.TagNew.TabIndex = 11;
            this.TagNew.Text = "NEW!";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Image = global::PluginChecker.Properties.Resources.btn_start;
            this.BtnStart.Location = new System.Drawing.Point(148, 269);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(81, 31);
            this.BtnStart.TabIndex = 13;
            this.BtnStart.TabStop = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BrowseTitle
            // 
            this.BrowseTitle.AutoSize = true;
            this.BrowseTitle.BackColor = System.Drawing.Color.Transparent;
            this.BrowseTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BrowseTitle.ForeColor = System.Drawing.Color.White;
            this.BrowseTitle.Location = new System.Drawing.Point(538, 139);
            this.BrowseTitle.Name = "BrowseTitle";
            this.BrowseTitle.Size = new System.Drawing.Size(148, 25);
            this.BrowseTitle.TabIndex = 14;
            this.BrowseTitle.Text = "Browse Plugins";
            // 
            // BrowseDesc
            // 
            this.BrowseDesc.AutoSize = true;
            this.BrowseDesc.BackColor = System.Drawing.Color.Transparent;
            this.BrowseDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowseDesc.ForeColor = System.Drawing.Color.White;
            this.BrowseDesc.Location = new System.Drawing.Point(429, 182);
            this.BrowseDesc.Name = "BrowseDesc";
            this.BrowseDesc.Size = new System.Drawing.Size(364, 60);
            this.BrowseDesc.TabIndex = 15;
            this.BrowseDesc.Text = "Browse all Plugins which are likely to be incompatible\r\nwith the latest versions " +
    "of GTA V, RagePluginHook\r\nand LSPDFR. ";
            this.BrowseDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowse.Image = global::PluginChecker.Properties.Resources.btn_browse;
            this.BtnBrowse.Location = new System.Drawing.Point(567, 269);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(79, 31);
            this.BtnBrowse.TabIndex = 16;
            this.BtnBrowse.TabStop = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // GreetingTitle
            // 
            this.GreetingTitle.AutoSize = true;
            this.GreetingTitle.BackColor = System.Drawing.Color.Transparent;
            this.GreetingTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GreetingTitle.ForeColor = System.Drawing.Color.White;
            this.GreetingTitle.Location = new System.Drawing.Point(184, 32);
            this.GreetingTitle.Name = "GreetingTitle";
            this.GreetingTitle.Size = new System.Drawing.Size(446, 37);
            this.GreetingTitle.TabIndex = 17;
            this.GreetingTitle.Text = "Hi there! How can I be of service?";
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfo.BackgroundImage = global::PluginChecker.Properties.Resources.btn_info;
            this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfo.Location = new System.Drawing.Point(12, 345);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(68, 31);
            this.BtnInfo.TabIndex = 18;
            this.BtnInfo.TabStop = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnUpdates
            // 
            this.BtnUpdates.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdates.BackgroundImage = global::PluginChecker.Properties.Resources.btn_updates;
            this.BtnUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdates.Location = new System.Drawing.Point(106, 345);
            this.BtnUpdates.Name = "BtnUpdates";
            this.BtnUpdates.Size = new System.Drawing.Size(172, 31);
            this.BtnUpdates.TabIndex = 19;
            this.BtnUpdates.TabStop = false;
            this.BtnUpdates.Click += new System.EventHandler(this.BtnUpdates_Click);
            // 
            // BtnRepIssue
            // 
            this.BtnRepIssue.BackColor = System.Drawing.Color.Transparent;
            this.BtnRepIssue.BackgroundImage = global::PluginChecker.Properties.Resources.btn_repissue;
            this.BtnRepIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRepIssue.Location = new System.Drawing.Point(312, 345);
            this.BtnRepIssue.Name = "BtnRepIssue";
            this.BtnRepIssue.Size = new System.Drawing.Size(151, 31);
            this.BtnRepIssue.TabIndex = 20;
            this.BtnRepIssue.TabStop = false;
            this.BtnRepIssue.Click += new System.EventHandler(this.BtnRepIssue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "CLOSED BETA\r\nWork In Progress";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.BackgroundImage = global::PluginChecker.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(804, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRepIssue);
            this.Controls.Add(this.BtnUpdates);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.GreetingTitle);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.BrowseDesc);
            this.Controls.Add(this.BrowseTitle);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.AnalysisDesc);
            this.Controls.Add(this.TagNew);
            this.Controls.Add(this.AnalysisTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 430);
            this.MinimumSize = new System.Drawing.Size(820, 430);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Checker";
            ((System.ComponentModel.ISupportInitialize)(this.BtnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRepIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label AnalysisTitle;
        private Label AnalysisDesc;
        private Label TagNew;
        private PictureBox BtnStart;
        private Label BrowseTitle;
        private Label BrowseDesc;
        private PictureBox BtnBrowse;
        private Label GreetingTitle;
        private PictureBox BtnInfo;
        private PictureBox BtnUpdates;
        private PictureBox BtnRepIssue;
        private Label label2;
    }
}