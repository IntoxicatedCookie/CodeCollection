namespace CoreLoader
{
    partial class SettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.dia_procfile = new System.Windows.Forms.OpenFileDialog();
            this.dia_webpagefile = new System.Windows.Forms.OpenFileDialog();
            this.dia_webpagefolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ctrl_tabs = new System.Windows.Forms.TabControl();
            this.tab_general = new System.Windows.Forms.TabPage();
            this.box_startup = new System.Windows.Forms.CheckBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_categinfo = new System.Windows.Forms.Label();
            this.box_comms = new System.Windows.Forms.CheckBox();
            this.lbl_categconn = new System.Windows.Forms.Label();
            this.lbl_categmaint = new System.Windows.Forms.Label();
            this.lbl_categapp = new System.Windows.Forms.Label();
            this.grp_maint = new System.Windows.Forms.GroupBox();
            this.btn_sourcebrowse = new System.Windows.Forms.Button();
            this.lbl_maintsaveresp = new System.Windows.Forms.Label();
            this.btn_maintsave = new System.Windows.Forms.Button();
            this.lbl_maintsource = new System.Windows.Forms.Label();
            this.inp_maintsource = new System.Windows.Forms.TextBox();
            this.lbl_maintdest = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.inp_maintdest = new System.Windows.Forms.TextBox();
            this.tab_servers = new System.Windows.Forms.TabPage();
            this.grp_gateways = new System.Windows.Forms.GroupBox();
            this.lbl_soon = new System.Windows.Forms.Label();
            this.grp_web = new System.Windows.Forms.GroupBox();
            this.lbl_websaveresp = new System.Windows.Forms.Label();
            this.btn_websave = new System.Windows.Forms.Button();
            this.box_webwindow = new System.Windows.Forms.CheckBox();
            this.lbl_webname = new System.Windows.Forms.Label();
            this.inp_webname = new System.Windows.Forms.TextBox();
            this.lbl_webexe = new System.Windows.Forms.Label();
            this.btn_webbrowse = new System.Windows.Forms.Button();
            this.inp_webexe = new System.Windows.Forms.TextBox();
            this.grp_mail = new System.Windows.Forms.GroupBox();
            this.lbl_mailsaveresp = new System.Windows.Forms.Label();
            this.btn_mailsave = new System.Windows.Forms.Button();
            this.box_mailwindow = new System.Windows.Forms.CheckBox();
            this.lbl_mailname = new System.Windows.Forms.Label();
            this.inp_mailname = new System.Windows.Forms.TextBox();
            this.lbl_mailexe = new System.Windows.Forms.Label();
            this.btn_mailbrowse = new System.Windows.Forms.Button();
            this.inp_mailexe = new System.Windows.Forms.TextBox();
            this.grp_db = new System.Windows.Forms.GroupBox();
            this.lbl_dbsaveresp = new System.Windows.Forms.Label();
            this.btn_dbsave = new System.Windows.Forms.Button();
            this.box_dbwindow = new System.Windows.Forms.CheckBox();
            this.lbl_dbname = new System.Windows.Forms.Label();
            this.inp_dbname = new System.Windows.Forms.TextBox();
            this.lbl_dbexe = new System.Windows.Forms.Label();
            this.btn_dbbrowse = new System.Windows.Forms.Button();
            this.inp_dbexe = new System.Windows.Forms.TextBox();
            this.ctrl_tabs.SuspendLayout();
            this.tab_general.SuspendLayout();
            this.grp_maint.SuspendLayout();
            this.tab_servers.SuspendLayout();
            this.grp_gateways.SuspendLayout();
            this.grp_web.SuspendLayout();
            this.grp_mail.SuspendLayout();
            this.grp_db.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl_tabs
            // 
            this.ctrl_tabs.Controls.Add(this.tab_general);
            this.ctrl_tabs.Controls.Add(this.tab_servers);
            this.ctrl_tabs.Location = new System.Drawing.Point(12, 13);
            this.ctrl_tabs.Name = "ctrl_tabs";
            this.ctrl_tabs.SelectedIndex = 0;
            this.ctrl_tabs.Size = new System.Drawing.Size(696, 419);
            this.ctrl_tabs.TabIndex = 11;
            // 
            // tab_general
            // 
            this.tab_general.Controls.Add(this.box_startup);
            this.tab_general.Controls.Add(this.lbl_version);
            this.tab_general.Controls.Add(this.lbl_categinfo);
            this.tab_general.Controls.Add(this.box_comms);
            this.tab_general.Controls.Add(this.lbl_categconn);
            this.tab_general.Controls.Add(this.lbl_categmaint);
            this.tab_general.Controls.Add(this.lbl_categapp);
            this.tab_general.Controls.Add(this.grp_maint);
            this.tab_general.Location = new System.Drawing.Point(4, 24);
            this.tab_general.Name = "tab_general";
            this.tab_general.Padding = new System.Windows.Forms.Padding(3);
            this.tab_general.Size = new System.Drawing.Size(688, 391);
            this.tab_general.TabIndex = 0;
            this.tab_general.Text = "General";
            this.tab_general.UseVisualStyleBackColor = true;
            // 
            // box_startup
            // 
            this.box_startup.AutoSize = true;
            this.box_startup.Location = new System.Drawing.Point(28, 57);
            this.box_startup.Name = "box_startup";
            this.box_startup.Size = new System.Drawing.Size(209, 19);
            this.box_startup.TabIndex = 23;
            this.box_startup.Text = "Start application on system startup";
            this.box_startup.UseVisualStyleBackColor = true;
            this.box_startup.CheckedChanged += new System.EventHandler(this.box_startup_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_version.Location = new System.Drawing.Point(529, 46);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(120, 30);
            this.lbl_version.TabIndex = 22;
            this.lbl_version.Text = "Development Release\r\nBuild MAIN_100.2.0\r\n";
            // 
            // lbl_categinfo
            // 
            this.lbl_categinfo.AutoSize = true;
            this.lbl_categinfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categinfo.Location = new System.Drawing.Point(529, 21);
            this.lbl_categinfo.Name = "lbl_categinfo";
            this.lbl_categinfo.Size = new System.Drawing.Size(38, 18);
            this.lbl_categinfo.TabIndex = 21;
            this.lbl_categinfo.Text = "Info";
            // 
            // box_comms
            // 
            this.box_comms.AutoSize = true;
            this.box_comms.Location = new System.Drawing.Point(28, 154);
            this.box_comms.Name = "box_comms";
            this.box_comms.Size = new System.Drawing.Size(183, 19);
            this.box_comms.TabIndex = 20;
            this.box_comms.Text = "Enable server communication";
            this.box_comms.UseVisualStyleBackColor = true;
            this.box_comms.CheckedChanged += new System.EventHandler(this.box_comms_Click);
            // 
            // lbl_categconn
            // 
            this.lbl_categconn.AutoSize = true;
            this.lbl_categconn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categconn.Location = new System.Drawing.Point(22, 117);
            this.lbl_categconn.Name = "lbl_categconn";
            this.lbl_categconn.Size = new System.Drawing.Size(100, 18);
            this.lbl_categconn.TabIndex = 19;
            this.lbl_categconn.Text = "Connection";
            // 
            // lbl_categmaint
            // 
            this.lbl_categmaint.AutoSize = true;
            this.lbl_categmaint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categmaint.Location = new System.Drawing.Point(22, 206);
            this.lbl_categmaint.Name = "lbl_categmaint";
            this.lbl_categmaint.Size = new System.Drawing.Size(111, 18);
            this.lbl_categmaint.TabIndex = 17;
            this.lbl_categmaint.Text = "Maintenance";
            // 
            // lbl_categapp
            // 
            this.lbl_categapp.AutoSize = true;
            this.lbl_categapp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categapp.Location = new System.Drawing.Point(22, 21);
            this.lbl_categapp.Name = "lbl_categapp";
            this.lbl_categapp.Size = new System.Drawing.Size(98, 18);
            this.lbl_categapp.TabIndex = 16;
            this.lbl_categapp.Text = "Application";
            // 
            // grp_maint
            // 
            this.grp_maint.Controls.Add(this.btn_sourcebrowse);
            this.grp_maint.Controls.Add(this.lbl_maintsaveresp);
            this.grp_maint.Controls.Add(this.btn_maintsave);
            this.grp_maint.Controls.Add(this.lbl_maintsource);
            this.grp_maint.Controls.Add(this.inp_maintsource);
            this.grp_maint.Controls.Add(this.lbl_maintdest);
            this.grp_maint.Controls.Add(this.button12);
            this.grp_maint.Controls.Add(this.inp_maintdest);
            this.grp_maint.Location = new System.Drawing.Point(22, 242);
            this.grp_maint.Name = "grp_maint";
            this.grp_maint.Size = new System.Drawing.Size(438, 143);
            this.grp_maint.TabIndex = 14;
            this.grp_maint.TabStop = false;
            // 
            // btn_sourcebrowse
            // 
            this.btn_sourcebrowse.Location = new System.Drawing.Point(237, 46);
            this.btn_sourcebrowse.Name = "btn_sourcebrowse";
            this.btn_sourcebrowse.Size = new System.Drawing.Size(76, 23);
            this.btn_sourcebrowse.TabIndex = 14;
            this.btn_sourcebrowse.Text = "Browse";
            this.btn_sourcebrowse.UseVisualStyleBackColor = true;
            // 
            // lbl_maintsaveresp
            // 
            this.lbl_maintsaveresp.AutoSize = true;
            this.lbl_maintsaveresp.Location = new System.Drawing.Point(374, 51);
            this.lbl_maintsaveresp.Name = "lbl_maintsaveresp";
            this.lbl_maintsaveresp.Size = new System.Drawing.Size(56, 15);
            this.lbl_maintsaveresp.TabIndex = 13;
            this.lbl_maintsaveresp.Text = "SaveResp";
            this.lbl_maintsaveresp.Visible = false;
            // 
            // btn_maintsave
            // 
            this.btn_maintsave.Location = new System.Drawing.Point(354, 25);
            this.btn_maintsave.Name = "btn_maintsave";
            this.btn_maintsave.Size = new System.Drawing.Size(76, 23);
            this.btn_maintsave.TabIndex = 9;
            this.btn_maintsave.Text = "Save";
            this.btn_maintsave.UseVisualStyleBackColor = true;
            // 
            // lbl_maintsource
            // 
            this.lbl_maintsource.AutoSize = true;
            this.lbl_maintsource.Location = new System.Drawing.Point(6, 29);
            this.lbl_maintsource.Name = "lbl_maintsource";
            this.lbl_maintsource.Size = new System.Drawing.Size(43, 15);
            this.lbl_maintsource.TabIndex = 4;
            this.lbl_maintsource.Text = "Source";
            // 
            // inp_maintsource
            // 
            this.inp_maintsource.Location = new System.Drawing.Point(6, 47);
            this.inp_maintsource.Name = "inp_maintsource";
            this.inp_maintsource.Size = new System.Drawing.Size(214, 23);
            this.inp_maintsource.TabIndex = 3;
            // 
            // lbl_maintdest
            // 
            this.lbl_maintdest.AutoSize = true;
            this.lbl_maintdest.Location = new System.Drawing.Point(6, 93);
            this.lbl_maintdest.Name = "lbl_maintdest";
            this.lbl_maintdest.Size = new System.Drawing.Size(67, 15);
            this.lbl_maintdest.TabIndex = 2;
            this.lbl_maintdest.Text = "Destination";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(237, 110);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(76, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "Browse";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // inp_maintdest
            // 
            this.inp_maintdest.Location = new System.Drawing.Point(6, 111);
            this.inp_maintdest.Name = "inp_maintdest";
            this.inp_maintdest.Size = new System.Drawing.Size(214, 23);
            this.inp_maintdest.TabIndex = 0;
            // 
            // tab_servers
            // 
            this.tab_servers.Controls.Add(this.grp_gateways);
            this.tab_servers.Controls.Add(this.grp_web);
            this.tab_servers.Controls.Add(this.grp_mail);
            this.tab_servers.Controls.Add(this.grp_db);
            this.tab_servers.Location = new System.Drawing.Point(4, 24);
            this.tab_servers.Name = "tab_servers";
            this.tab_servers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_servers.Size = new System.Drawing.Size(688, 391);
            this.tab_servers.TabIndex = 1;
            this.tab_servers.Text = "Servers";
            this.tab_servers.UseVisualStyleBackColor = true;
            // 
            // grp_gateways
            // 
            this.grp_gateways.Controls.Add(this.lbl_soon);
            this.grp_gateways.Location = new System.Drawing.Point(18, 207);
            this.grp_gateways.Name = "grp_gateways";
            this.grp_gateways.Size = new System.Drawing.Size(319, 176);
            this.grp_gateways.TabIndex = 14;
            this.grp_gateways.TabStop = false;
            this.grp_gateways.Text = "Gateways";
            // 
            // lbl_soon
            // 
            this.lbl_soon.AutoSize = true;
            this.lbl_soon.ForeColor = System.Drawing.Color.Red;
            this.lbl_soon.Location = new System.Drawing.Point(121, 79);
            this.lbl_soon.Name = "lbl_soon";
            this.lbl_soon.Size = new System.Drawing.Size(79, 15);
            this.lbl_soon.TabIndex = 0;
            this.lbl_soon.Text = "Coming soon";
            // 
            // grp_web
            // 
            this.grp_web.Controls.Add(this.lbl_websaveresp);
            this.grp_web.Controls.Add(this.btn_websave);
            this.grp_web.Controls.Add(this.box_webwindow);
            this.grp_web.Controls.Add(this.lbl_webname);
            this.grp_web.Controls.Add(this.inp_webname);
            this.grp_web.Controls.Add(this.lbl_webexe);
            this.grp_web.Controls.Add(this.btn_webbrowse);
            this.grp_web.Controls.Add(this.inp_webexe);
            this.grp_web.Location = new System.Drawing.Point(353, 207);
            this.grp_web.Name = "grp_web";
            this.grp_web.Size = new System.Drawing.Size(319, 176);
            this.grp_web.TabIndex = 12;
            this.grp_web.TabStop = false;
            this.grp_web.Text = "Webserver";
            // 
            // lbl_websaveresp
            // 
            this.lbl_websaveresp.AutoSize = true;
            this.lbl_websaveresp.Location = new System.Drawing.Point(257, 47);
            this.lbl_websaveresp.Name = "lbl_websaveresp";
            this.lbl_websaveresp.Size = new System.Drawing.Size(56, 15);
            this.lbl_websaveresp.TabIndex = 13;
            this.lbl_websaveresp.Text = "SaveResp";
            this.lbl_websaveresp.Visible = false;
            // 
            // btn_websave
            // 
            this.btn_websave.Location = new System.Drawing.Point(237, 21);
            this.btn_websave.Name = "btn_websave";
            this.btn_websave.Size = new System.Drawing.Size(76, 23);
            this.btn_websave.TabIndex = 9;
            this.btn_websave.Text = "Save";
            this.btn_websave.UseVisualStyleBackColor = true;
            this.btn_websave.Click += new System.EventHandler(this.btn_websave_Click);
            // 
            // box_webwindow
            // 
            this.box_webwindow.AutoSize = true;
            this.box_webwindow.Location = new System.Drawing.Point(6, 151);
            this.box_webwindow.Name = "box_webwindow";
            this.box_webwindow.Size = new System.Drawing.Size(169, 19);
            this.box_webwindow.TabIndex = 8;
            this.box_webwindow.Text = "Don\'t create a new window";
            this.box_webwindow.UseVisualStyleBackColor = true;
            // 
            // lbl_webname
            // 
            this.lbl_webname.AutoSize = true;
            this.lbl_webname.Location = new System.Drawing.Point(6, 29);
            this.lbl_webname.Name = "lbl_webname";
            this.lbl_webname.Size = new System.Drawing.Size(39, 15);
            this.lbl_webname.TabIndex = 4;
            this.lbl_webname.Text = "Name";
            // 
            // inp_webname
            // 
            this.inp_webname.Location = new System.Drawing.Point(6, 47);
            this.inp_webname.Name = "inp_webname";
            this.inp_webname.Size = new System.Drawing.Size(140, 23);
            this.inp_webname.TabIndex = 3;
            // 
            // lbl_webexe
            // 
            this.lbl_webexe.AutoSize = true;
            this.lbl_webexe.Location = new System.Drawing.Point(6, 93);
            this.lbl_webexe.Name = "lbl_webexe";
            this.lbl_webexe.Size = new System.Drawing.Size(47, 15);
            this.lbl_webexe.TabIndex = 2;
            this.lbl_webexe.Text = "Process";
            // 
            // btn_webbrowse
            // 
            this.btn_webbrowse.Location = new System.Drawing.Point(237, 110);
            this.btn_webbrowse.Name = "btn_webbrowse";
            this.btn_webbrowse.Size = new System.Drawing.Size(76, 23);
            this.btn_webbrowse.TabIndex = 1;
            this.btn_webbrowse.Text = "Browse";
            this.btn_webbrowse.UseVisualStyleBackColor = true;
            this.btn_webbrowse.Click += new System.EventHandler(this.btn_webbrowse_Click);
            // 
            // inp_webexe
            // 
            this.inp_webexe.Location = new System.Drawing.Point(6, 111);
            this.inp_webexe.Name = "inp_webexe";
            this.inp_webexe.Size = new System.Drawing.Size(214, 23);
            this.inp_webexe.TabIndex = 0;
            // 
            // grp_mail
            // 
            this.grp_mail.Controls.Add(this.lbl_mailsaveresp);
            this.grp_mail.Controls.Add(this.btn_mailsave);
            this.grp_mail.Controls.Add(this.box_mailwindow);
            this.grp_mail.Controls.Add(this.lbl_mailname);
            this.grp_mail.Controls.Add(this.inp_mailname);
            this.grp_mail.Controls.Add(this.lbl_mailexe);
            this.grp_mail.Controls.Add(this.btn_mailbrowse);
            this.grp_mail.Controls.Add(this.inp_mailexe);
            this.grp_mail.Location = new System.Drawing.Point(353, 15);
            this.grp_mail.Name = "grp_mail";
            this.grp_mail.Size = new System.Drawing.Size(319, 177);
            this.grp_mail.TabIndex = 9;
            this.grp_mail.TabStop = false;
            this.grp_mail.Text = "Mailserver";
            // 
            // lbl_mailsaveresp
            // 
            this.lbl_mailsaveresp.AutoSize = true;
            this.lbl_mailsaveresp.Location = new System.Drawing.Point(257, 49);
            this.lbl_mailsaveresp.Name = "lbl_mailsaveresp";
            this.lbl_mailsaveresp.Size = new System.Drawing.Size(56, 15);
            this.lbl_mailsaveresp.TabIndex = 12;
            this.lbl_mailsaveresp.Text = "SaveResp";
            this.lbl_mailsaveresp.Visible = false;
            // 
            // btn_mailsave
            // 
            this.btn_mailsave.Location = new System.Drawing.Point(237, 20);
            this.btn_mailsave.Name = "btn_mailsave";
            this.btn_mailsave.Size = new System.Drawing.Size(76, 23);
            this.btn_mailsave.TabIndex = 10;
            this.btn_mailsave.Text = "Save";
            this.btn_mailsave.UseVisualStyleBackColor = true;
            this.btn_mailsave.Click += new System.EventHandler(this.btn_mailsave_Click);
            // 
            // box_mailwindow
            // 
            this.box_mailwindow.AutoSize = true;
            this.box_mailwindow.Location = new System.Drawing.Point(6, 149);
            this.box_mailwindow.Name = "box_mailwindow";
            this.box_mailwindow.Size = new System.Drawing.Size(169, 19);
            this.box_mailwindow.TabIndex = 9;
            this.box_mailwindow.Text = "Don\'t create a new window";
            this.box_mailwindow.UseVisualStyleBackColor = true;
            // 
            // lbl_mailname
            // 
            this.lbl_mailname.AutoSize = true;
            this.lbl_mailname.Location = new System.Drawing.Point(6, 29);
            this.lbl_mailname.Name = "lbl_mailname";
            this.lbl_mailname.Size = new System.Drawing.Size(39, 15);
            this.lbl_mailname.TabIndex = 4;
            this.lbl_mailname.Text = "Name";
            // 
            // inp_mailname
            // 
            this.inp_mailname.Location = new System.Drawing.Point(6, 47);
            this.inp_mailname.Name = "inp_mailname";
            this.inp_mailname.Size = new System.Drawing.Size(140, 23);
            this.inp_mailname.TabIndex = 3;
            // 
            // lbl_mailexe
            // 
            this.lbl_mailexe.AutoSize = true;
            this.lbl_mailexe.Location = new System.Drawing.Point(6, 93);
            this.lbl_mailexe.Name = "lbl_mailexe";
            this.lbl_mailexe.Size = new System.Drawing.Size(47, 15);
            this.lbl_mailexe.TabIndex = 2;
            this.lbl_mailexe.Text = "Process";
            // 
            // btn_mailbrowse
            // 
            this.btn_mailbrowse.Location = new System.Drawing.Point(237, 110);
            this.btn_mailbrowse.Name = "btn_mailbrowse";
            this.btn_mailbrowse.Size = new System.Drawing.Size(76, 23);
            this.btn_mailbrowse.TabIndex = 1;
            this.btn_mailbrowse.Text = "Browse";
            this.btn_mailbrowse.UseVisualStyleBackColor = true;
            this.btn_mailbrowse.Click += new System.EventHandler(this.btn_mailbrowse_Click);
            // 
            // inp_mailexe
            // 
            this.inp_mailexe.Location = new System.Drawing.Point(6, 111);
            this.inp_mailexe.Name = "inp_mailexe";
            this.inp_mailexe.Size = new System.Drawing.Size(214, 23);
            this.inp_mailexe.TabIndex = 0;
            // 
            // grp_db
            // 
            this.grp_db.Controls.Add(this.lbl_dbsaveresp);
            this.grp_db.Controls.Add(this.btn_dbsave);
            this.grp_db.Controls.Add(this.box_dbwindow);
            this.grp_db.Controls.Add(this.lbl_dbname);
            this.grp_db.Controls.Add(this.inp_dbname);
            this.grp_db.Controls.Add(this.lbl_dbexe);
            this.grp_db.Controls.Add(this.btn_dbbrowse);
            this.grp_db.Controls.Add(this.inp_dbexe);
            this.grp_db.Location = new System.Drawing.Point(18, 14);
            this.grp_db.Name = "grp_db";
            this.grp_db.Size = new System.Drawing.Size(319, 178);
            this.grp_db.TabIndex = 3;
            this.grp_db.TabStop = false;
            this.grp_db.Text = "Database";
            // 
            // lbl_dbsaveresp
            // 
            this.lbl_dbsaveresp.AutoSize = true;
            this.lbl_dbsaveresp.Location = new System.Drawing.Point(257, 50);
            this.lbl_dbsaveresp.Name = "lbl_dbsaveresp";
            this.lbl_dbsaveresp.Size = new System.Drawing.Size(56, 15);
            this.lbl_dbsaveresp.TabIndex = 11;
            this.lbl_dbsaveresp.Text = "SaveResp";
            this.lbl_dbsaveresp.Visible = false;
            // 
            // btn_dbsave
            // 
            this.btn_dbsave.Location = new System.Drawing.Point(237, 21);
            this.btn_dbsave.Name = "btn_dbsave";
            this.btn_dbsave.Size = new System.Drawing.Size(76, 23);
            this.btn_dbsave.TabIndex = 10;
            this.btn_dbsave.Text = "Save";
            this.btn_dbsave.UseVisualStyleBackColor = true;
            this.btn_dbsave.Click += new System.EventHandler(this.btn_dbsave_Click);
            // 
            // box_dbwindow
            // 
            this.box_dbwindow.AutoSize = true;
            this.box_dbwindow.Location = new System.Drawing.Point(6, 150);
            this.box_dbwindow.Name = "box_dbwindow";
            this.box_dbwindow.Size = new System.Drawing.Size(169, 19);
            this.box_dbwindow.TabIndex = 8;
            this.box_dbwindow.Text = "Don\'t create a new window";
            this.box_dbwindow.UseVisualStyleBackColor = true;
            // 
            // lbl_dbname
            // 
            this.lbl_dbname.AutoSize = true;
            this.lbl_dbname.Location = new System.Drawing.Point(6, 29);
            this.lbl_dbname.Name = "lbl_dbname";
            this.lbl_dbname.Size = new System.Drawing.Size(39, 15);
            this.lbl_dbname.TabIndex = 4;
            this.lbl_dbname.Text = "Name";
            // 
            // inp_dbname
            // 
            this.inp_dbname.Location = new System.Drawing.Point(6, 47);
            this.inp_dbname.Name = "inp_dbname";
            this.inp_dbname.Size = new System.Drawing.Size(140, 23);
            this.inp_dbname.TabIndex = 3;
            // 
            // lbl_dbexe
            // 
            this.lbl_dbexe.AutoSize = true;
            this.lbl_dbexe.Location = new System.Drawing.Point(6, 93);
            this.lbl_dbexe.Name = "lbl_dbexe";
            this.lbl_dbexe.Size = new System.Drawing.Size(47, 15);
            this.lbl_dbexe.TabIndex = 2;
            this.lbl_dbexe.Text = "Process";
            // 
            // btn_dbbrowse
            // 
            this.btn_dbbrowse.Location = new System.Drawing.Point(237, 110);
            this.btn_dbbrowse.Name = "btn_dbbrowse";
            this.btn_dbbrowse.Size = new System.Drawing.Size(76, 23);
            this.btn_dbbrowse.TabIndex = 1;
            this.btn_dbbrowse.Text = "Browse";
            this.btn_dbbrowse.UseVisualStyleBackColor = true;
            this.btn_dbbrowse.Click += new System.EventHandler(this.btn_dbbrowse_Click);
            // 
            // inp_dbexe
            // 
            this.inp_dbexe.Location = new System.Drawing.Point(6, 111);
            this.inp_dbexe.Name = "inp_dbexe";
            this.inp_dbexe.Size = new System.Drawing.Size(214, 23);
            this.inp_dbexe.TabIndex = 0;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 444);
            this.Controls.Add(this.ctrl_tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsView";
            this.Text = "CoreLoader v1.0.0-dev - Preferences";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ctrl_tabs.ResumeLayout(false);
            this.tab_general.ResumeLayout(false);
            this.tab_general.PerformLayout();
            this.grp_maint.ResumeLayout(false);
            this.grp_maint.PerformLayout();
            this.tab_servers.ResumeLayout(false);
            this.grp_gateways.ResumeLayout(false);
            this.grp_gateways.PerformLayout();
            this.grp_web.ResumeLayout(false);
            this.grp_web.PerformLayout();
            this.grp_mail.ResumeLayout(false);
            this.grp_mail.PerformLayout();
            this.grp_db.ResumeLayout(false);
            this.grp_db.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dia_procfile;
        private System.Windows.Forms.OpenFileDialog dia_webpagefile;
        private System.Windows.Forms.FolderBrowserDialog dia_webpagefolder;
        private System.Windows.Forms.TabControl ctrl_tabs;
        private System.Windows.Forms.TabPage tab_general;
        private System.Windows.Forms.Label lbl_categapp;
        private System.Windows.Forms.Button btn_sourcebrowse;
        private System.Windows.Forms.Label lbl_maintsaveresp;
        private System.Windows.Forms.Button btn_maintsave;
        private System.Windows.Forms.Label lbl_maintsource;
        private System.Windows.Forms.TextBox inp_maintsource;
        private System.Windows.Forms.Label lbl_maintdest;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox inp_maintdest;
        private System.Windows.Forms.TabPage tab_servers;
        private System.Windows.Forms.GroupBox grp_web;
        private System.Windows.Forms.Label lbl_websaveresp;
        private System.Windows.Forms.Button btn_websave;
        private System.Windows.Forms.CheckBox box_webwindow;
        private System.Windows.Forms.Label lbl_webname;
        private System.Windows.Forms.TextBox inp_webname;
        private System.Windows.Forms.Label lbl_webexe;
        private System.Windows.Forms.Button btn_webbrowse;
        private System.Windows.Forms.TextBox inp_webexe;
        private System.Windows.Forms.GroupBox grp_mail;
        private System.Windows.Forms.Label lbl_mailsaveresp;
        private System.Windows.Forms.Button btn_mailsave;
        private System.Windows.Forms.CheckBox box_mailwindow;
        private System.Windows.Forms.Label lbl_mailname;
        private System.Windows.Forms.TextBox inp_mailname;
        private System.Windows.Forms.Label lbl_mailexe;
        private System.Windows.Forms.Button btn_mailbrowse;
        private System.Windows.Forms.TextBox inp_mailexe;
        private System.Windows.Forms.GroupBox grp_db;
        private System.Windows.Forms.Label lbl_dbsaveresp;
        private System.Windows.Forms.Button btn_dbsave;
        private System.Windows.Forms.CheckBox box_dbwindow;
        private System.Windows.Forms.Label lbl_dbname;
        private System.Windows.Forms.TextBox inp_dbname;
        private System.Windows.Forms.Label lbl_dbexe;
        private System.Windows.Forms.Button btn_dbbrowse;
        private System.Windows.Forms.TextBox inp_dbexe;
        private System.Windows.Forms.Label lbl_categinfo;
        private System.Windows.Forms.CheckBox box_comms;
        private System.Windows.Forms.Label lbl_categconn;
        private System.Windows.Forms.Label lbl_categmaint;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.GroupBox grp_maint;
        private System.Windows.Forms.GroupBox grp_gateways;
        private System.Windows.Forms.Label lbl_soon;
        private System.Windows.Forms.CheckBox box_startup;
    }
}