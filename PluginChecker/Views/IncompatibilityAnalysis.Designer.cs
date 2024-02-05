namespace PluginChecker
{
    partial class IncompatibilityAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncompatibilityAnalysis));
            this.DataDisplay = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.apiVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogSelector = new System.Windows.Forms.OpenFileDialog();
            this.LSPDFRLatest = new System.Windows.Forms.Label();
            this.LSPDFRInstalled = new System.Windows.Forms.Label();
            this.LSPDFRTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LSPDFRContainer = new System.Windows.Forms.Panel();
            this.RPHContainer = new System.Windows.Forms.Panel();
            this.RPHLatest = new System.Windows.Forms.Label();
            this.RPHTitle = new System.Windows.Forms.Label();
            this.RPHInstalled = new System.Windows.Forms.Label();
            this.GTAVContainer = new System.Windows.Forms.Panel();
            this.GTAVLatest = new System.Windows.Forms.Label();
            this.GTAVTitle = new System.Windows.Forms.Label();
            this.GTAVInstalled = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClosedBetaNotice = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.TitleContainer = new System.Windows.Forms.Panel();
            this.IconLogHelp = new System.Windows.Forms.PictureBox();
            this.CheckboxShowAll = new System.Windows.Forms.CheckBox();
            this.SummaryIcon = new System.Windows.Forms.PictureBox();
            this.BrowseBtn = new System.Windows.Forms.PictureBox();
            this.MainDesc = new System.Windows.Forms.Label();
            this.MainTitle = new System.Windows.Forms.Label();
            this.BannerImage = new System.Windows.Forms.PictureBox();
            this.CriticalRow = new System.Windows.Forms.Panel();
            this.PluginsRow = new System.Windows.Forms.Panel();
            this.CopyResultsLink = new System.Windows.Forms.Label();
            this.PluginsStatus = new System.Windows.Forms.Label();
            this.PluginsDesc = new System.Windows.Forms.Label();
            this.PluginsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).BeginInit();
            this.LSPDFRContainer.SuspendLayout();
            this.RPHContainer.SuspendLayout();
            this.GTAVContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.TitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).BeginInit();
            this.CriticalRow.SuspendLayout();
            this.PluginsRow.SuspendLayout();
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
            this.DataDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataDisplay.Location = new System.Drawing.Point(0, 178);
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
            this.DataDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataDisplay.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataDisplay.RowTemplate.Height = 25;
            this.DataDisplay.Size = new System.Drawing.Size(1075, 166);
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
            // LSPDFRLatest
            // 
            this.LSPDFRLatest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LSPDFRLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.LSPDFRLatest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LSPDFRLatest.ForeColor = System.Drawing.Color.White;
            this.LSPDFRLatest.Location = new System.Drawing.Point(6, 58);
            this.LSPDFRLatest.Name = "LSPDFRLatest";
            this.LSPDFRLatest.Size = new System.Drawing.Size(294, 20);
            this.LSPDFRLatest.TabIndex = 24;
            this.LSPDFRLatest.Text = "Latest version: Unknown";
            this.LSPDFRLatest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSPDFRInstalled
            // 
            this.LSPDFRInstalled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LSPDFRInstalled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.LSPDFRInstalled.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LSPDFRInstalled.ForeColor = System.Drawing.Color.White;
            this.LSPDFRInstalled.Location = new System.Drawing.Point(3, 38);
            this.LSPDFRInstalled.Name = "LSPDFRInstalled";
            this.LSPDFRInstalled.Size = new System.Drawing.Size(294, 20);
            this.LSPDFRInstalled.TabIndex = 22;
            this.LSPDFRInstalled.Text = "Installed version: Unknown\r\n";
            this.LSPDFRInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSPDFRTitle
            // 
            this.LSPDFRTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LSPDFRTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.LSPDFRTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LSPDFRTitle.ForeColor = System.Drawing.Color.White;
            this.LSPDFRTitle.Location = new System.Drawing.Point(119, 2);
            this.LSPDFRTitle.Name = "LSPDFRTitle";
            this.LSPDFRTitle.Size = new System.Drawing.Size(68, 20);
            this.LSPDFRTitle.TabIndex = 21;
            this.LSPDFRTitle.Text = "LSPDFR";
            this.LSPDFRTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(673, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 28;
            // 
            // LSPDFRContainer
            // 
            this.LSPDFRContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LSPDFRContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.LSPDFRContainer.Controls.Add(this.LSPDFRLatest);
            this.LSPDFRContainer.Controls.Add(this.LSPDFRTitle);
            this.LSPDFRContainer.Controls.Add(this.LSPDFRInstalled);
            this.LSPDFRContainer.Location = new System.Drawing.Point(693, 15);
            this.LSPDFRContainer.Name = "LSPDFRContainer";
            this.LSPDFRContainer.Size = new System.Drawing.Size(303, 81);
            this.LSPDFRContainer.TabIndex = 30;
            // 
            // RPHContainer
            // 
            this.RPHContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RPHContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.RPHContainer.Controls.Add(this.RPHLatest);
            this.RPHContainer.Controls.Add(this.RPHTitle);
            this.RPHContainer.Controls.Add(this.RPHInstalled);
            this.RPHContainer.Location = new System.Drawing.Point(390, 15);
            this.RPHContainer.Name = "RPHContainer";
            this.RPHContainer.Size = new System.Drawing.Size(303, 81);
            this.RPHContainer.TabIndex = 31;
            // 
            // RPHLatest
            // 
            this.RPHLatest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RPHLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.RPHLatest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RPHLatest.ForeColor = System.Drawing.Color.White;
            this.RPHLatest.Location = new System.Drawing.Point(3, 58);
            this.RPHLatest.Name = "RPHLatest";
            this.RPHLatest.Size = new System.Drawing.Size(294, 20);
            this.RPHLatest.TabIndex = 24;
            this.RPHLatest.Text = "Latest version: Unknown";
            this.RPHLatest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RPHTitle
            // 
            this.RPHTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RPHTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RPHTitle.ForeColor = System.Drawing.Color.White;
            this.RPHTitle.Location = new System.Drawing.Point(84, 2);
            this.RPHTitle.Name = "RPHTitle";
            this.RPHTitle.Size = new System.Drawing.Size(130, 20);
            this.RPHTitle.TabIndex = 21;
            this.RPHTitle.Text = "RagePluginHook";
            this.RPHTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RPHInstalled
            // 
            this.RPHInstalled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RPHInstalled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.RPHInstalled.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RPHInstalled.ForeColor = System.Drawing.Color.White;
            this.RPHInstalled.Location = new System.Drawing.Point(5, 38);
            this.RPHInstalled.Name = "RPHInstalled";
            this.RPHInstalled.Size = new System.Drawing.Size(294, 20);
            this.RPHInstalled.TabIndex = 22;
            this.RPHInstalled.Text = "Installed version: Unknown\r\n";
            this.RPHInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GTAVContainer
            // 
            this.GTAVContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GTAVContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.GTAVContainer.Controls.Add(this.GTAVLatest);
            this.GTAVContainer.Controls.Add(this.GTAVTitle);
            this.GTAVContainer.Controls.Add(this.GTAVInstalled);
            this.GTAVContainer.Location = new System.Drawing.Point(86, 15);
            this.GTAVContainer.Name = "GTAVContainer";
            this.GTAVContainer.Size = new System.Drawing.Size(303, 81);
            this.GTAVContainer.TabIndex = 32;
            // 
            // GTAVLatest
            // 
            this.GTAVLatest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GTAVLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.GTAVLatest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GTAVLatest.ForeColor = System.Drawing.Color.White;
            this.GTAVLatest.Location = new System.Drawing.Point(3, 58);
            this.GTAVLatest.Name = "GTAVLatest";
            this.GTAVLatest.Size = new System.Drawing.Size(294, 20);
            this.GTAVLatest.TabIndex = 24;
            this.GTAVLatest.Text = "Latest version: Unknown";
            this.GTAVLatest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GTAVTitle
            // 
            this.GTAVTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GTAVTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.GTAVTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GTAVTitle.ForeColor = System.Drawing.Color.White;
            this.GTAVTitle.Location = new System.Drawing.Point(80, 2);
            this.GTAVTitle.Name = "GTAVTitle";
            this.GTAVTitle.Size = new System.Drawing.Size(130, 20);
            this.GTAVTitle.TabIndex = 21;
            this.GTAVTitle.Text = "GTA V";
            this.GTAVTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GTAVInstalled
            // 
            this.GTAVInstalled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GTAVInstalled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.GTAVInstalled.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GTAVInstalled.ForeColor = System.Drawing.Color.White;
            this.GTAVInstalled.Location = new System.Drawing.Point(3, 38);
            this.GTAVInstalled.Name = "GTAVInstalled";
            this.GTAVInstalled.Size = new System.Drawing.Size(294, 20);
            this.GTAVInstalled.TabIndex = 22;
            this.GTAVInstalled.Text = "Installed version: Unknown\r\n";
            this.GTAVInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CriticalRow, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PluginsRow, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.05611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.94389F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1081, 653);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClosedBetaNotice);
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Controls.Add(this.TitleContainer);
            this.panel2.Controls.Add(this.BannerImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 179);
            this.panel2.TabIndex = 0;
            // 
            // ClosedBetaNotice
            // 
            this.ClosedBetaNotice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClosedBetaNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.ClosedBetaNotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ClosedBetaNotice.ForeColor = System.Drawing.Color.White;
            this.ClosedBetaNotice.Location = new System.Drawing.Point(-3, 0);
            this.ClosedBetaNotice.Name = "ClosedBetaNotice";
            this.ClosedBetaNotice.Size = new System.Drawing.Size(134, 41);
            this.ClosedBetaNotice.TabIndex = 34;
            this.ClosedBetaNotice.Text = "CLOSED BETA\r\nWork In Progress";
            this.ClosedBetaNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Image = global::PluginChecker.Properties.Resources.btn_home;
            this.HomeBtn.Location = new System.Drawing.Point(3, 147);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(76, 32);
            this.HomeBtn.TabIndex = 12;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // TitleContainer
            // 
            this.TitleContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.TitleContainer.Controls.Add(this.IconLogHelp);
            this.TitleContainer.Controls.Add(this.CheckboxShowAll);
            this.TitleContainer.Controls.Add(this.SummaryIcon);
            this.TitleContainer.Controls.Add(this.BrowseBtn);
            this.TitleContainer.Controls.Add(this.MainDesc);
            this.TitleContainer.Controls.Add(this.MainTitle);
            this.TitleContainer.Location = new System.Drawing.Point(175, 0);
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.Size = new System.Drawing.Size(634, 179);
            this.TitleContainer.TabIndex = 33;
            // 
            // IconLogHelp
            // 
            this.IconLogHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconLogHelp.Image = global::PluginChecker.Properties.Resources.icon_help;
            this.IconLogHelp.Location = new System.Drawing.Point(509, 62);
            this.IconLogHelp.Name = "IconLogHelp";
            this.IconLogHelp.Size = new System.Drawing.Size(23, 21);
            this.IconLogHelp.TabIndex = 35;
            this.IconLogHelp.TabStop = false;
            this.IconLogHelp.Click += new System.EventHandler(this.IconLogHelp_Click);
            // 
            // CheckboxShowAll
            // 
            this.CheckboxShowAll.AutoSize = true;
            this.CheckboxShowAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckboxShowAll.ForeColor = System.Drawing.Color.White;
            this.CheckboxShowAll.Location = new System.Drawing.Point(236, 147);
            this.CheckboxShowAll.Name = "CheckboxShowAll";
            this.CheckboxShowAll.Size = new System.Drawing.Size(315, 24);
            this.CheckboxShowAll.TabIndex = 4;
            this.CheckboxShowAll.Text = "Show all detected plugins (EXPERIMENTAL)";
            this.CheckboxShowAll.UseVisualStyleBackColor = true;
            this.CheckboxShowAll.CheckedChanged += new System.EventHandler(this.CheckboxShowAll_CheckedChanged);
            // 
            // SummaryIcon
            // 
            this.SummaryIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.SummaryIcon.Location = new System.Drawing.Point(12, 16);
            this.SummaryIcon.Name = "SummaryIcon";
            this.SummaryIcon.Size = new System.Drawing.Size(86, 86);
            this.SummaryIcon.TabIndex = 34;
            this.SummaryIcon.TabStop = false;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseBtn.Image = global::PluginChecker.Properties.Resources.btn_browse;
            this.BrowseBtn.Location = new System.Drawing.Point(299, 105);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(148, 31);
            this.BrowseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BrowseBtn.TabIndex = 15;
            this.BrowseBtn.TabStop = false;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // MainDesc
            // 
            this.MainDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.MainDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainDesc.ForeColor = System.Drawing.Color.White;
            this.MainDesc.Location = new System.Drawing.Point(119, 41);
            this.MainDesc.Name = "MainDesc";
            this.MainDesc.Size = new System.Drawing.Size(512, 61);
            this.MainDesc.TabIndex = 16;
            this.MainDesc.Text = "Please make sure you select a valid log.";
            this.MainDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTitle
            // 
            this.MainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainTitle.Location = new System.Drawing.Point(119, 14);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(512, 27);
            this.MainTitle.TabIndex = 14;
            this.MainTitle.Text = "Get started by selecting your RagePluginHook log\r\n";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BannerImage
            // 
            this.BannerImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BannerImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.BannerImage.Image = global::PluginChecker.Properties.Resources.banner;
            this.BannerImage.Location = new System.Drawing.Point(-13, 0);
            this.BannerImage.Name = "BannerImage";
            this.BannerImage.Size = new System.Drawing.Size(1091, 179);
            this.BannerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BannerImage.TabIndex = 3;
            this.BannerImage.TabStop = false;
            // 
            // CriticalRow
            // 
            this.CriticalRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.tableLayoutPanel1.SetColumnSpan(this.CriticalRow, 2);
            this.CriticalRow.Controls.Add(this.GTAVContainer);
            this.CriticalRow.Controls.Add(this.RPHContainer);
            this.CriticalRow.Controls.Add(this.LSPDFRContainer);
            this.CriticalRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.CriticalRow.Location = new System.Drawing.Point(3, 188);
            this.CriticalRow.Name = "CriticalRow";
            this.CriticalRow.Size = new System.Drawing.Size(1075, 112);
            this.CriticalRow.TabIndex = 35;
            // 
            // PluginsRow
            // 
            this.PluginsRow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PluginsRow.Controls.Add(this.CopyResultsLink);
            this.PluginsRow.Controls.Add(this.PluginsStatus);
            this.PluginsRow.Controls.Add(this.PluginsDesc);
            this.PluginsRow.Controls.Add(this.PluginsTitle);
            this.PluginsRow.Controls.Add(this.DataDisplay);
            this.PluginsRow.Location = new System.Drawing.Point(3, 306);
            this.PluginsRow.Name = "PluginsRow";
            this.PluginsRow.Size = new System.Drawing.Size(1075, 344);
            this.PluginsRow.TabIndex = 36;
            // 
            // CopyResultsLink
            // 
            this.CopyResultsLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyResultsLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CopyResultsLink.ForeColor = System.Drawing.Color.White;
            this.CopyResultsLink.Location = new System.Drawing.Point(888, 146);
            this.CopyResultsLink.Name = "CopyResultsLink";
            this.CopyResultsLink.Size = new System.Drawing.Size(184, 20);
            this.CopyResultsLink.TabIndex = 4;
            this.CopyResultsLink.Text = "Copy results to clipboard";
            this.CopyResultsLink.Visible = false;
            this.CopyResultsLink.Click += new System.EventHandler(this.CopyResultsLink_Click);
            // 
            // PluginsStatus
            // 
            this.PluginsStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PluginsStatus.ForeColor = System.Drawing.Color.White;
            this.PluginsStatus.Location = new System.Drawing.Point(12, 146);
            this.PluginsStatus.Name = "PluginsStatus";
            this.PluginsStatus.Size = new System.Drawing.Size(435, 20);
            this.PluginsStatus.TabIndex = 3;
            this.PluginsStatus.Text = "Status: Please select your RagePluginHook log to get started.";
            // 
            // PluginsDesc
            // 
            this.PluginsDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PluginsDesc.ForeColor = System.Drawing.Color.White;
            this.PluginsDesc.Location = new System.Drawing.Point(12, 52);
            this.PluginsDesc.Name = "PluginsDesc";
            this.PluginsDesc.Size = new System.Drawing.Size(531, 80);
            this.PluginsDesc.TabIndex = 2;
            this.PluginsDesc.Text = resources.GetString("PluginsDesc.Text");
            // 
            // PluginsTitle
            // 
            this.PluginsTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PluginsTitle.ForeColor = System.Drawing.Color.White;
            this.PluginsTitle.Location = new System.Drawing.Point(9, 10);
            this.PluginsTitle.Name = "PluginsTitle";
            this.PluginsTitle.Size = new System.Drawing.Size(167, 25);
            this.PluginsTitle.TabIndex = 1;
            this.PluginsTitle.Text = "Outdated plugins";
            // 
            // IncompatibilityAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1081, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1097, 692);
            this.MinimumSize = new System.Drawing.Size(1097, 692);
            this.Name = "IncompatibilityAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Checker";
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).EndInit();
            this.LSPDFRContainer.ResumeLayout(false);
            this.RPHContainer.ResumeLayout(false);
            this.GTAVContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.TitleContainer.ResumeLayout(false);
            this.TitleContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).EndInit();
            this.CriticalRow.ResumeLayout(false);
            this.PluginsRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataDisplay;
        private OpenFileDialog LogSelector;
        private Label LSPDFRTitle;
        private Label LSPDFRInstalled;
        private Label LSPDFRLatest;
        private Panel panel1;
        private Panel LSPDFRContainer;
        private Panel RPHContainer;
        private Label RPHLatest;
        private Label RPHTitle;
        private Label RPHInstalled;
        private Panel GTAVContainer;
        private Label GTAVLatest;
        private Label GTAVTitle;
        private Label GTAVInstalled;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel CriticalRow;
        private Panel PluginsRow;
        private Label PluginsStatus;
        private Label PluginsDesc;
        private Label PluginsTitle;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewLinkColumn url;
        private DataGridViewTextBoxColumn apiVersion;
        private DataGridViewTextBoxColumn date;
        private Panel panel2;
        private PictureBox HomeBtn;
        private Panel TitleContainer;
        private PictureBox IconLogHelp;
        private CheckBox CheckboxShowAll;
        private PictureBox SummaryIcon;
        private PictureBox BrowseBtn;
        private Label MainDesc;
        private Label MainTitle;
        private PictureBox BannerImage;
        private Label CopyResultsLink;
        private Label ClosedBetaNotice;
    }
}