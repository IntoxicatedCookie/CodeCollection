
namespace CoreLoader
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.lbl_db = new System.Windows.Forms.Label();
            this.lbl_dbstate = new System.Windows.Forms.Label();
            this.btn_dbrun = new System.Windows.Forms.Button();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_mailstate = new System.Windows.Forms.Label();
            this.btn_mailrun = new System.Windows.Forms.Button();
            this.lbl_gateways = new System.Windows.Forms.Label();
            this.lbl_gatewaysstate = new System.Windows.Forms.Label();
            this.btn_gatewaysrun = new System.Windows.Forms.Button();
            this.lbl_web = new System.Windows.Forms.Label();
            this.lbl_webstate = new System.Windows.Forms.Label();
            this.btn_webrun = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_cnotice = new System.Windows.Forms.Label();
            this.btn_dbdir = new System.Windows.Forms.Button();
            this.btn_maildir = new System.Windows.Forms.Button();
            this.btn_gatewaysdir = new System.Windows.Forms.Button();
            this.btn_webdir = new System.Windows.Forms.Button();
            this.btn_master = new System.Windows.Forms.Button();
            this.box_maint = new System.Windows.Forms.CheckBox();
            this.lbl_resptime = new System.Windows.Forms.Label();
            this.strp_menu = new System.Windows.Forms.MenuStrip();
            this.strpmenu_app = new System.Windows.Forms.ToolStripMenuItem();
            this.strpmenu_app_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.strpmenu_app_preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.strpmenu_app_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.strpmenu_conn = new System.Windows.Forms.ToolStripMenuItem();
            this.strpmenu_conntest = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_panel = new System.Windows.Forms.GroupBox();
            this.rtxt_log = new System.Windows.Forms.RichTextBox();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.link_clear = new System.Windows.Forms.LinkLabel();
            this.strp_menu.SuspendLayout();
            this.grp_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_db.Location = new System.Drawing.Point(6, 19);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(104, 23);
            this.lbl_db.TabIndex = 6;
            this.lbl_db.Text = "Database";
            // 
            // lbl_dbstate
            // 
            this.lbl_dbstate.AutoSize = true;
            this.lbl_dbstate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dbstate.ForeColor = System.Drawing.Color.Black;
            this.lbl_dbstate.Location = new System.Drawing.Point(173, 24);
            this.lbl_dbstate.Name = "lbl_dbstate";
            this.lbl_dbstate.Size = new System.Drawing.Size(40, 16);
            this.lbl_dbstate.TabIndex = 4;
            this.lbl_dbstate.Text = "State";
            this.lbl_dbstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dbrun
            // 
            this.btn_dbrun.Location = new System.Drawing.Point(375, 21);
            this.btn_dbrun.Name = "btn_dbrun";
            this.btn_dbrun.Size = new System.Drawing.Size(75, 23);
            this.btn_dbrun.TabIndex = 0;
            this.btn_dbrun.Text = "ToggleState";
            this.btn_dbrun.UseVisualStyleBackColor = true;
            this.btn_dbrun.Click += new System.EventHandler(this.btn_dbrun_Click);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mail.Location = new System.Drawing.Point(6, 77);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(113, 23);
            this.lbl_mail.TabIndex = 8;
            this.lbl_mail.Text = "Mailserver";
            // 
            // lbl_mailstate
            // 
            this.lbl_mailstate.AutoSize = true;
            this.lbl_mailstate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mailstate.ForeColor = System.Drawing.Color.Black;
            this.lbl_mailstate.Location = new System.Drawing.Point(173, 82);
            this.lbl_mailstate.Name = "lbl_mailstate";
            this.lbl_mailstate.Size = new System.Drawing.Size(40, 16);
            this.lbl_mailstate.TabIndex = 9;
            this.lbl_mailstate.Text = "State";
            this.lbl_mailstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mailrun
            // 
            this.btn_mailrun.Location = new System.Drawing.Point(375, 79);
            this.btn_mailrun.Name = "btn_mailrun";
            this.btn_mailrun.Size = new System.Drawing.Size(75, 23);
            this.btn_mailrun.TabIndex = 2;
            this.btn_mailrun.Text = "ToggleState";
            this.btn_mailrun.UseVisualStyleBackColor = true;
            this.btn_mailrun.Click += new System.EventHandler(this.btn_mailrun_Click);
            // 
            // lbl_gateways
            // 
            this.lbl_gateways.AutoSize = true;
            this.lbl_gateways.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_gateways.Location = new System.Drawing.Point(6, 138);
            this.lbl_gateways.Name = "lbl_gateways";
            this.lbl_gateways.Size = new System.Drawing.Size(107, 23);
            this.lbl_gateways.TabIndex = 10;
            this.lbl_gateways.Text = "Gateways";
            // 
            // lbl_gatewaysstate
            // 
            this.lbl_gatewaysstate.AutoSize = true;
            this.lbl_gatewaysstate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gatewaysstate.ForeColor = System.Drawing.Color.Black;
            this.lbl_gatewaysstate.Location = new System.Drawing.Point(173, 143);
            this.lbl_gatewaysstate.Name = "lbl_gatewaysstate";
            this.lbl_gatewaysstate.Size = new System.Drawing.Size(40, 16);
            this.lbl_gatewaysstate.TabIndex = 12;
            this.lbl_gatewaysstate.Text = "State";
            this.lbl_gatewaysstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_gatewaysrun
            // 
            this.btn_gatewaysrun.Location = new System.Drawing.Point(375, 140);
            this.btn_gatewaysrun.Name = "btn_gatewaysrun";
            this.btn_gatewaysrun.Size = new System.Drawing.Size(75, 23);
            this.btn_gatewaysrun.TabIndex = 11;
            this.btn_gatewaysrun.Text = "ToggleState";
            this.btn_gatewaysrun.UseVisualStyleBackColor = true;
            this.btn_gatewaysrun.Click += new System.EventHandler(this.btn_gatewaysrun_Click);
            // 
            // lbl_web
            // 
            this.lbl_web.AutoSize = true;
            this.lbl_web.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_web.Location = new System.Drawing.Point(6, 198);
            this.lbl_web.Name = "lbl_web";
            this.lbl_web.Size = new System.Drawing.Size(109, 22);
            this.lbl_web.TabIndex = 3;
            this.lbl_web.Text = "Webserver";
            // 
            // lbl_webstate
            // 
            this.lbl_webstate.AutoSize = true;
            this.lbl_webstate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_webstate.ForeColor = System.Drawing.Color.Black;
            this.lbl_webstate.Location = new System.Drawing.Point(173, 203);
            this.lbl_webstate.Name = "lbl_webstate";
            this.lbl_webstate.Size = new System.Drawing.Size(40, 16);
            this.lbl_webstate.TabIndex = 7;
            this.lbl_webstate.Text = "State";
            this.lbl_webstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_webrun
            // 
            this.btn_webrun.Location = new System.Drawing.Point(375, 200);
            this.btn_webrun.Name = "btn_webrun";
            this.btn_webrun.Size = new System.Drawing.Size(75, 23);
            this.btn_webrun.TabIndex = 1;
            this.btn_webrun.Text = "ToggleState";
            this.btn_webrun.UseVisualStyleBackColor = true;
            this.btn_webrun.Click += new System.EventHandler(this.btn_webrun_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_version.Location = new System.Drawing.Point(12, 371);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(120, 30);
            this.lbl_version.TabIndex = 14;
            this.lbl_version.Text = "Development Release\r\nBuild MAIN_100.2.0\r\n";
            // 
            // lbl_cnotice
            // 
            this.lbl_cnotice.AutoSize = true;
            this.lbl_cnotice.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_cnotice.Location = new System.Drawing.Point(364, 385);
            this.lbl_cnotice.Name = "lbl_cnotice";
            this.lbl_cnotice.Size = new System.Drawing.Size(113, 15);
            this.lbl_cnotice.TabIndex = 15;
            this.lbl_cnotice.Text = "© 2021 by Sociosoft";
            // 
            // btn_dbdir
            // 
            this.btn_dbdir.Location = new System.Drawing.Point(277, 21);
            this.btn_dbdir.Name = "btn_dbdir";
            this.btn_dbdir.Size = new System.Drawing.Size(75, 23);
            this.btn_dbdir.TabIndex = 16;
            this.btn_dbdir.Text = "Directory";
            this.btn_dbdir.UseVisualStyleBackColor = true;
            this.btn_dbdir.Click += new System.EventHandler(this.btn_dbdir_Click);
            // 
            // btn_maildir
            // 
            this.btn_maildir.Location = new System.Drawing.Point(277, 79);
            this.btn_maildir.Name = "btn_maildir";
            this.btn_maildir.Size = new System.Drawing.Size(75, 23);
            this.btn_maildir.TabIndex = 17;
            this.btn_maildir.Text = "Directory";
            this.btn_maildir.UseVisualStyleBackColor = true;
            this.btn_maildir.Click += new System.EventHandler(this.btn_maildir_Click);
            // 
            // btn_gatewaysdir
            // 
            this.btn_gatewaysdir.Location = new System.Drawing.Point(277, 140);
            this.btn_gatewaysdir.Name = "btn_gatewaysdir";
            this.btn_gatewaysdir.Size = new System.Drawing.Size(75, 23);
            this.btn_gatewaysdir.TabIndex = 18;
            this.btn_gatewaysdir.Text = "Directory";
            this.btn_gatewaysdir.UseVisualStyleBackColor = true;
            // 
            // btn_webdir
            // 
            this.btn_webdir.Location = new System.Drawing.Point(277, 200);
            this.btn_webdir.Name = "btn_webdir";
            this.btn_webdir.Size = new System.Drawing.Size(75, 23);
            this.btn_webdir.TabIndex = 19;
            this.btn_webdir.Text = "Directory";
            this.btn_webdir.UseVisualStyleBackColor = true;
            this.btn_webdir.Click += new System.EventHandler(this.btn_webdir_Click);
            // 
            // btn_master
            // 
            this.btn_master.Location = new System.Drawing.Point(348, 291);
            this.btn_master.Name = "btn_master";
            this.btn_master.Size = new System.Drawing.Size(129, 23);
            this.btn_master.TabIndex = 20;
            this.btn_master.Text = "Toggle All Servers";
            this.btn_master.UseVisualStyleBackColor = true;
            this.btn_master.Click += new System.EventHandler(this.btn_master_Click);
            // 
            // box_maint
            // 
            this.box_maint.AutoSize = true;
            this.box_maint.Location = new System.Drawing.Point(348, 320);
            this.box_maint.Name = "box_maint";
            this.box_maint.Size = new System.Drawing.Size(129, 19);
            this.box_maint.TabIndex = 21;
            this.box_maint.Text = "Maintenance Mode";
            this.box_maint.UseVisualStyleBackColor = true;
            this.box_maint.Click += new System.EventHandler(this.box_maint_Click);
            // 
            // lbl_resptime
            // 
            this.lbl_resptime.AutoSize = true;
            this.lbl_resptime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_resptime.ForeColor = System.Drawing.Color.Red;
            this.lbl_resptime.Location = new System.Drawing.Point(417, 369);
            this.lbl_resptime.Name = "lbl_resptime";
            this.lbl_resptime.Size = new System.Drawing.Size(60, 16);
            this.lbl_resptime.TabIndex = 26;
            this.lbl_resptime.Text = "Unknown";
            this.lbl_resptime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_resptime.Visible = false;
            // 
            // strp_menu
            // 
            this.strp_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpmenu_app,
            this.strpmenu_conn});
            this.strp_menu.Location = new System.Drawing.Point(0, 0);
            this.strp_menu.Name = "strp_menu";
            this.strp_menu.Size = new System.Drawing.Size(489, 24);
            this.strp_menu.TabIndex = 27;
            this.strp_menu.Text = "strp_menu";
            // 
            // strpmenu_app
            // 
            this.strpmenu_app.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpmenu_app_refresh,
            this.strpmenu_app_preferences,
            this.strpmenu_app_quit});
            this.strpmenu_app.Name = "strpmenu_app";
            this.strpmenu_app.Size = new System.Drawing.Size(80, 20);
            this.strpmenu_app.Text = "Application";
            // 
            // strpmenu_app_refresh
            // 
            this.strpmenu_app_refresh.Name = "strpmenu_app_refresh";
            this.strpmenu_app_refresh.Size = new System.Drawing.Size(135, 22);
            this.strpmenu_app_refresh.Text = "Refresh";
            this.strpmenu_app_refresh.Click += new System.EventHandler(this.strpmenu_app_refresh_Click);
            // 
            // strpmenu_app_preferences
            // 
            this.strpmenu_app_preferences.Name = "strpmenu_app_preferences";
            this.strpmenu_app_preferences.Size = new System.Drawing.Size(135, 22);
            this.strpmenu_app_preferences.Text = "Preferences";
            this.strpmenu_app_preferences.Click += new System.EventHandler(this.strpmenu_app_preferences_Click);
            // 
            // strpmenu_app_quit
            // 
            this.strpmenu_app_quit.Name = "strpmenu_app_quit";
            this.strpmenu_app_quit.Size = new System.Drawing.Size(135, 22);
            this.strpmenu_app_quit.Text = "Quit";
            this.strpmenu_app_quit.Click += new System.EventHandler(this.strpmenu_app_quit_Click);
            // 
            // strpmenu_conn
            // 
            this.strpmenu_conn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpmenu_conntest});
            this.strpmenu_conn.Name = "strpmenu_conn";
            this.strpmenu_conn.Size = new System.Drawing.Size(81, 20);
            this.strpmenu_conn.Text = "Connection";
            // 
            // strpmenu_conntest
            // 
            this.strpmenu_conntest.Name = "strpmenu_conntest";
            this.strpmenu_conntest.Size = new System.Drawing.Size(159, 22);
            this.strpmenu_conntest.Text = "Test Connection";
            this.strpmenu_conntest.Click += new System.EventHandler(this.strpmenu_conn_test_Click);
            // 
            // grp_panel
            // 
            this.grp_panel.Controls.Add(this.btn_webdir);
            this.grp_panel.Controls.Add(this.btn_gatewaysdir);
            this.grp_panel.Controls.Add(this.btn_maildir);
            this.grp_panel.Controls.Add(this.btn_dbdir);
            this.grp_panel.Controls.Add(this.lbl_gatewaysstate);
            this.grp_panel.Controls.Add(this.btn_gatewaysrun);
            this.grp_panel.Controls.Add(this.lbl_gateways);
            this.grp_panel.Controls.Add(this.lbl_mailstate);
            this.grp_panel.Controls.Add(this.lbl_mail);
            this.grp_panel.Controls.Add(this.lbl_webstate);
            this.grp_panel.Controls.Add(this.lbl_db);
            this.grp_panel.Controls.Add(this.lbl_dbstate);
            this.grp_panel.Controls.Add(this.lbl_web);
            this.grp_panel.Controls.Add(this.btn_mailrun);
            this.grp_panel.Controls.Add(this.btn_webrun);
            this.grp_panel.Controls.Add(this.btn_dbrun);
            this.grp_panel.Location = new System.Drawing.Point(12, 27);
            this.grp_panel.Name = "grp_panel";
            this.grp_panel.Size = new System.Drawing.Size(465, 237);
            this.grp_panel.TabIndex = 28;
            this.grp_panel.TabStop = false;
            // 
            // rtxt_log
            // 
            this.rtxt_log.Location = new System.Drawing.Point(12, 281);
            this.rtxt_log.Name = "rtxt_log";
            this.rtxt_log.Size = new System.Drawing.Size(287, 74);
            this.rtxt_log.TabIndex = 29;
            this.rtxt_log.Text = "";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // link_clear
            // 
            this.link_clear.AutoSize = true;
            this.link_clear.Location = new System.Drawing.Point(265, 358);
            this.link_clear.Name = "link_clear";
            this.link_clear.Size = new System.Drawing.Size(34, 15);
            this.link_clear.TabIndex = 30;
            this.link_clear.TabStop = true;
            this.link_clear.Text = "Clear";
            this.link_clear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_clear_LinkClicked);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 410);
            this.Controls.Add(this.link_clear);
            this.Controls.Add(this.rtxt_log);
            this.Controls.Add(this.grp_panel);
            this.Controls.Add(this.box_maint);
            this.Controls.Add(this.lbl_resptime);
            this.Controls.Add(this.btn_master);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_cnotice);
            this.Controls.Add(this.strp_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel";
            this.Text = "CoreLoader v1.0.0-dev";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.strp_menu.ResumeLayout(false);
            this.strp_menu.PerformLayout();
            this.grp_panel.ResumeLayout(false);
            this.grp_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dbrun;
        private System.Windows.Forms.Button btn_webrun;
        private System.Windows.Forms.Button btn_mailrun;
        private System.Windows.Forms.Label lbl_web;
        private System.Windows.Forms.Label lbl_dbstate;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.Label lbl_webstate;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_mailstate;
        private System.Windows.Forms.Label lbl_gateways;
        private System.Windows.Forms.Button btn_gatewaysrun;
        private System.Windows.Forms.Label lbl_gatewaysstate;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_cnotice;
        private System.Windows.Forms.Button btn_dbdir;
        private System.Windows.Forms.Button btn_maildir;
        private System.Windows.Forms.Button btn_gatewaysdir;
        private System.Windows.Forms.Button btn_webdir;
        private System.Windows.Forms.Button btn_master;
        private System.Windows.Forms.CheckBox box_maint;
        private System.Windows.Forms.Label lbl_resptime;
        private System.Windows.Forms.MenuStrip strp_menu;
        private System.Windows.Forms.ToolStripMenuItem strpmenu_app;
        private System.Windows.Forms.ToolStripMenuItem strpmenu_app_refresh;
        private System.Windows.Forms.ToolStripMenuItem strpmenu_app_preferences;
        private System.Windows.Forms.ToolStripMenuItem strpmenu_app_quit;
        private System.Windows.Forms.GroupBox grp_panel;
        private System.Windows.Forms.RichTextBox rtxt_log;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strpmenu_conn;
        private System.Windows.Forms.ToolStripMenuItem strpmenu_conntest;
        private System.Windows.Forms.LinkLabel link_clear;
    }
}

