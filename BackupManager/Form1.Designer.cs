
namespace BackupManager
{
    partial class MainForm
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
            this.inp_filebackup = new System.Windows.Forms.TextBox();
            this.lbl_filebackup = new System.Windows.Forms.Label();
            this.btn_filebrowse = new System.Windows.Forms.Button();
            this.dia_backupfile = new System.Windows.Forms.OpenFileDialog();
            this.btn_upload = new System.Windows.Forms.Button();
            this.lbl_uploadresp = new System.Windows.Forms.Label();
            this.inp_folderid = new System.Windows.Forms.TextBox();
            this.lbl_folderid = new System.Windows.Forms.Label();
            this.lbl_cnotice = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inp_filebackup
            // 
            this.inp_filebackup.BackColor = System.Drawing.SystemColors.Window;
            this.inp_filebackup.Location = new System.Drawing.Point(19, 41);
            this.inp_filebackup.Name = "inp_filebackup";
            this.inp_filebackup.Size = new System.Drawing.Size(197, 23);
            this.inp_filebackup.TabIndex = 0;
            // 
            // lbl_filebackup
            // 
            this.lbl_filebackup.AutoSize = true;
            this.lbl_filebackup.Location = new System.Drawing.Point(19, 23);
            this.lbl_filebackup.Name = "lbl_filebackup";
            this.lbl_filebackup.Size = new System.Drawing.Size(81, 15);
            this.lbl_filebackup.TabIndex = 0;
            this.lbl_filebackup.Text = "File to backup";
            // 
            // btn_filebrowse
            // 
            this.btn_filebrowse.Location = new System.Drawing.Point(249, 41);
            this.btn_filebrowse.Name = "btn_filebrowse";
            this.btn_filebrowse.Size = new System.Drawing.Size(75, 23);
            this.btn_filebrowse.TabIndex = 1;
            this.btn_filebrowse.Text = "Browse";
            this.btn_filebrowse.UseVisualStyleBackColor = true;
            this.btn_filebrowse.Click += new System.EventHandler(this.btn_backupbrowse_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(19, 139);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(105, 23);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "Upload to cloud";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // lbl_uploadresp
            // 
            this.lbl_uploadresp.AutoSize = true;
            this.lbl_uploadresp.Location = new System.Drawing.Point(146, 143);
            this.lbl_uploadresp.Name = "lbl_uploadresp";
            this.lbl_uploadresp.Size = new System.Drawing.Size(70, 15);
            this.lbl_uploadresp.TabIndex = 3;
            this.lbl_uploadresp.Text = "UploadResp";
            this.lbl_uploadresp.Visible = false;
            // 
            // inp_folderid
            // 
            this.inp_folderid.Location = new System.Drawing.Point(19, 101);
            this.inp_folderid.Name = "inp_folderid";
            this.inp_folderid.Size = new System.Drawing.Size(105, 23);
            this.inp_folderid.TabIndex = 4;
            // 
            // lbl_folderid
            // 
            this.lbl_folderid.AutoSize = true;
            this.lbl_folderid.Location = new System.Drawing.Point(19, 83);
            this.lbl_folderid.Name = "lbl_folderid";
            this.lbl_folderid.Size = new System.Drawing.Size(54, 15);
            this.lbl_folderid.TabIndex = 5;
            this.lbl_folderid.Text = "Folder ID";
            // 
            // lbl_cnotice
            // 
            this.lbl_cnotice.AutoSize = true;
            this.lbl_cnotice.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_cnotice.Location = new System.Drawing.Point(206, 202);
            this.lbl_cnotice.Name = "lbl_cnotice";
            this.lbl_cnotice.Size = new System.Drawing.Size(113, 15);
            this.lbl_cnotice.TabIndex = 6;
            this.lbl_cnotice.Text = "© 2021 by Sociocon";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_version.Location = new System.Drawing.Point(19, 187);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(120, 30);
            this.lbl_version.TabIndex = 7;
            this.lbl_version.Text = "Development Release\r\nDEV_11010";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 226);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_cnotice);
            this.Controls.Add(this.lbl_folderid);
            this.Controls.Add(this.inp_folderid);
            this.Controls.Add(this.lbl_uploadresp);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_filebrowse);
            this.Controls.Add(this.lbl_filebackup);
            this.Controls.Add(this.inp_filebackup);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inp_filebackup;
        private System.Windows.Forms.Label lbl_filebackup;
        private System.Windows.Forms.Button btn_filebrowse;
        private System.Windows.Forms.OpenFileDialog dia_backupfile;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label lbl_uploadresp;
        private System.Windows.Forms.TextBox inp_folderid;
        private System.Windows.Forms.Label lbl_folderid;
        private System.Windows.Forms.Label lbl_cnotice;
        private System.Windows.Forms.Label lbl_version;
    }
}

