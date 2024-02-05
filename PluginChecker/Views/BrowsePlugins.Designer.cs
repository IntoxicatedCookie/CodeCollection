namespace PluginChecker
{
    partial class BrowsePlugins
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowsePlugins));
            this.DataDisplay = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.apiVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BannerImage = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsText = new System.Windows.Forms.Label();
            this.ClearLink = new System.Windows.Forms.LinkLabel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClosedBetaNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // DataDisplay
            // 
            this.DataDisplay.AllowUserToAddRows = false;
            this.DataDisplay.AllowUserToDeleteRows = false;
            this.DataDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.DataDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.author,
            this.url,
            this.apiVersion,
            this.date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataDisplay.Location = new System.Drawing.Point(0, 183);
            this.DataDisplay.Name = "DataDisplay";
            this.DataDisplay.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataDisplay.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataDisplay.RowTemplate.Height = 25;
            this.DataDisplay.Size = new System.Drawing.Size(804, 233);
            this.DataDisplay.TabIndex = 0;
            this.DataDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDisplay_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Plugin";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "The name of the plugin.";
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.ToolTipText = "The author of the plugin.";
            // 
            // url
            // 
            this.url.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.url.HeaderText = "URL";
            this.url.LinkColor = System.Drawing.SystemColors.ControlText;
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.ToolTipText = "Link to the download page of the plugin.";
            this.url.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            // 
            // apiVersion
            // 
            this.apiVersion.HeaderText = "LSPDFR API";
            this.apiVersion.Name = "apiVersion";
            this.apiVersion.ReadOnly = true;
            this.apiVersion.ToolTipText = "Minium version of the LSPDFR API that the plugin supports.";
            // 
            // date
            // 
            this.date.HeaderText = "Last Updated";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.ToolTipText = "Date when the plugin was last updated.";
            // 
            // BannerImage
            // 
            this.BannerImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.BannerImage.Image = global::PluginChecker.Properties.Resources.banner;
            this.BannerImage.Location = new System.Drawing.Point(0, -5);
            this.BannerImage.Name = "BannerImage";
            this.BannerImage.Size = new System.Drawing.Size(804, 195);
            this.BannerImage.TabIndex = 3;
            this.BannerImage.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(158, 80);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Search for a plugin...";
            this.SearchBox.Size = new System.Drawing.Size(426, 23);
            this.SearchBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // ResultsText
            // 
            this.ResultsText.AutoSize = true;
            this.ResultsText.BackColor = System.Drawing.Color.Transparent;
            this.ResultsText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultsText.ForeColor = System.Drawing.SystemColors.Control;
            this.ResultsText.Location = new System.Drawing.Point(158, 106);
            this.ResultsText.Name = "ResultsText";
            this.ResultsText.Size = new System.Drawing.Size(60, 20);
            this.ResultsText.TabIndex = 9;
            this.ResultsText.Text = "Results";
            this.ResultsText.Visible = false;
            // 
            // ClearLink
            // 
            this.ClearLink.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.ClearLink.AutoSize = true;
            this.ClearLink.BackColor = System.Drawing.Color.Transparent;
            this.ClearLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearLink.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearLink.LinkColor = System.Drawing.SystemColors.Control;
            this.ClearLink.Location = new System.Drawing.Point(454, 106);
            this.ClearLink.Name = "ClearLink";
            this.ClearLink.Size = new System.Drawing.Size(130, 20);
            this.ClearLink.TabIndex = 11;
            this.ClearLink.TabStop = true;
            this.ClearLink.Text = "Clear search query";
            this.ClearLink.VisitedLinkColor = System.Drawing.SystemColors.Control;
            this.ClearLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearLink_LinkClicked);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.Image = global::PluginChecker.Properties.Resources.btn_home;
            this.BtnHome.Location = new System.Drawing.Point(12, 145);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(76, 32);
            this.BtnHome.TabIndex = 12;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.CausesValidation = false;
            this.SearchButton.Location = new System.Drawing.Point(610, 80);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClosedBetaNotice
            // 
            this.ClosedBetaNotice.AutoSize = true;
            this.ClosedBetaNotice.BackColor = System.Drawing.Color.Transparent;
            this.ClosedBetaNotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ClosedBetaNotice.ForeColor = System.Drawing.SystemColors.Control;
            this.ClosedBetaNotice.Location = new System.Drawing.Point(0, 9);
            this.ClosedBetaNotice.Name = "ClosedBetaNotice";
            this.ClosedBetaNotice.Size = new System.Drawing.Size(94, 30);
            this.ClosedBetaNotice.TabIndex = 13;
            this.ClosedBetaNotice.Text = "CLOSED BETA\r\nWork In Progress\r\n";
            // 
            // BrowsePlugins
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(804, 416);
            this.Controls.Add(this.ClosedBetaNotice);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.ClearLink);
            this.Controls.Add(this.ResultsText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DataDisplay);
            this.Controls.Add(this.BannerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 457);
            this.MinimumSize = new System.Drawing.Size(820, 455);
            this.Name = "BrowsePlugins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Checker";
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataDisplay;
        private PictureBox BannerImage;
        private TextBox SearchBox;
        private Label label1;
        private Label ResultsText;
        private LinkLabel ClearLink;
        private PictureBox BtnHome;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewLinkColumn url;
        private DataGridViewTextBoxColumn apiVersion;
        private DataGridViewTextBoxColumn date;
        private Button SearchButton;
        private Label ClosedBetaNotice;
    }
}