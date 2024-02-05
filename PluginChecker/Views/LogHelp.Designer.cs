namespace PluginChecker
{
    partial class LogHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogHelp));
            this.ValidLogTitle = new System.Windows.Forms.Label();
            this.ValidLogDesc = new System.Windows.Forms.Label();
            this.ValidLogDesc2 = new System.Windows.Forms.Label();
            this.LogLocationTitle = new System.Windows.Forms.Label();
            this.LogLocationDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValidLogTitle
            // 
            this.ValidLogTitle.AutoSize = true;
            this.ValidLogTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValidLogTitle.ForeColor = System.Drawing.Color.White;
            this.ValidLogTitle.Location = new System.Drawing.Point(12, 18);
            this.ValidLogTitle.Name = "ValidLogTitle";
            this.ValidLogTitle.Size = new System.Drawing.Size(333, 25);
            this.ValidLogTitle.TabIndex = 0;
            this.ValidLogTitle.Text = "What\'s a valid RagePluginHook log?";
            // 
            // ValidLogDesc
            // 
            this.ValidLogDesc.AutoSize = true;
            this.ValidLogDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValidLogDesc.ForeColor = System.Drawing.Color.White;
            this.ValidLogDesc.Location = new System.Drawing.Point(12, 53);
            this.ValidLogDesc.Name = "ValidLogDesc";
            this.ValidLogDesc.Size = new System.Drawing.Size(474, 40);
            this.ValidLogDesc.TabIndex = 1;
            this.ValidLogDesc.Text = "A valid RagePluginHook log is a file which is called \"RagePluginHook\"\r\nand which " +
    "has the .log file extension.";
            // 
            // ValidLogDesc2
            // 
            this.ValidLogDesc2.AutoSize = true;
            this.ValidLogDesc2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ValidLogDesc2.ForeColor = System.Drawing.Color.White;
            this.ValidLogDesc2.Location = new System.Drawing.Point(12, 104);
            this.ValidLogDesc2.Name = "ValidLogDesc2";
            this.ValidLogDesc2.Size = new System.Drawing.Size(453, 40);
            this.ValidLogDesc2.TabIndex = 2;
            this.ValidLogDesc2.Text = "The file must be identical to \"RagePluginHook.log\" in order for \r\nPlugin Checker " +
    "to pick it up.";
            // 
            // LogLocationTitle
            // 
            this.LogLocationTitle.AutoSize = true;
            this.LogLocationTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogLocationTitle.ForeColor = System.Drawing.Color.White;
            this.LogLocationTitle.Location = new System.Drawing.Point(12, 189);
            this.LogLocationTitle.Name = "LogLocationTitle";
            this.LogLocationTitle.Size = new System.Drawing.Size(389, 25);
            this.LogLocationTitle.TabIndex = 3;
            this.LogLocationTitle.Text = "Where can I find my RagePluginHook log?";
            // 
            // LogLocationDesc
            // 
            this.LogLocationDesc.AutoSize = true;
            this.LogLocationDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogLocationDesc.ForeColor = System.Drawing.Color.White;
            this.LogLocationDesc.Location = new System.Drawing.Point(12, 223);
            this.LogLocationDesc.Name = "LogLocationDesc";
            this.LogLocationDesc.Size = new System.Drawing.Size(280, 40);
            this.LogLocationDesc.TabIndex = 4;
            this.LogLocationDesc.Text = "You can find it in your main GTA V folder.\r\nIt is not from inside the \"logs\" fold" +
    "er.";
            // 
            // LogHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(110)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(512, 291);
            this.Controls.Add(this.LogLocationDesc);
            this.Controls.Add(this.LogLocationTitle);
            this.Controls.Add(this.ValidLogDesc2);
            this.Controls.Add(this.ValidLogDesc);
            this.Controls.Add(this.ValidLogTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 330);
            this.Name = "LogHelp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ValidLogTitle;
        private Label ValidLogDesc;
        private Label ValidLogDesc2;
        private Label LogLocationTitle;
        private Label LogLocationDesc;
    }
}