using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using static CoreLoader.Properties.Settings;
using Microsoft.Win32;


namespace CoreLoader
{
    public partial class SettingsView : Form
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        public void getSettings()
        {
            try
            {
                inp_dbname.Text = Default.dbName;
                inp_dbexe.Text = Default.dbProc;
                box_dbwindow.Checked = Default.dbWindow;

                inp_mailname.Text = Default.mailName;
                inp_mailexe.Text = Default.mailProc;;
                box_mailwindow.Checked = Default.mailWindow;

                inp_webname.Text = Default.webName;
                inp_webexe.Text = Default.webProc;
                box_webwindow.Checked = Default.webWindow;

                inp_maintsource.Text = Default.maintSource;
                inp_maintdest.Text = Default.maintDest;

                box_comms.Checked = Default.serverComms;

                if (Default.maintEdit != true)
                {
                    grp_maint.Text = "Cannot edit while maintenance mode is active.";
                    grp_maint.Enabled = false;
                }

                if (regkey.GetValue("CoreLoader") == null)
                {
                    box_startup.Checked = false;
                }
                else
                {
                    box_startup.Checked = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while getting settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public void updateSettingKey(string key, object value)
        {
            try
            {
                Default[key] = value;
                Default.Save();
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("An error occurred while updating settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string selectProcFile()
        {
            dia_procfile.Filter = "Executable (*.exe)|*.exe|Batch File (*.bat)|*.bat";
            dia_procfile.FilterIndex = 1;
            DialogResult result = dia_procfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = dia_procfile.FileName;

                try
                {
                    return file;
                }
                catch (IOException)
                {
                    return "Exception occurred.";
                }
            }
            return "No file selected.";
        }

        public string selectWebpageFile()
        {
            dia_webpagefile.Filter = "HTML (*.html)|*.html";
            DialogResult result = dia_webpagefile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = dia_webpagefile.FileName;

                try
                {
                    return file;
                }
                catch (IOException)
                {
                    return "Exception occurred.";
                }
            }
            return "No file selected.";
        }

        public string selectWebpageFolder()
        {
            DialogResult result = dia_webpagefolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = dia_webpagefolder.SelectedPath;

                try
                {
                    return file;
                }
                catch (IOException)
                {
                    return "Exception occurred.";
                }
            }
            return "No folder selected.";
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
           getSettings();
        }

        private void btn_dbsave_Click(object sender, EventArgs e)
        {
            lbl_dbsaveresp.Visible = true;
            lbl_dbsaveresp.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_dbsaveresp.Text = "Saved!";

            if (!String.IsNullOrEmpty(inp_dbname.Text))
            {
                updateSettingKey("dbName", inp_dbname.Text);
            } else
            {
                lbl_dbsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                lbl_dbsaveresp.Text = "Error";
                inp_dbname.Text = "Field cannot be empty.";
            }

            try
            {
                if (File.Exists(inp_dbexe.Text))
                {
                    switch (Path.GetExtension(inp_dbexe.Text))
                    {
                        case ".exe":
                            updateSettingKey("dbProc", inp_dbexe.Text);
                            break;
                        case ".bat":
                            updateSettingKey("dbProc", inp_dbexe.Text);
                            break;
                        default:
                            lbl_dbsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                            lbl_dbsaveresp.Text = "Error";
                            inp_dbexe.Text = "Unsupported file type.";
                            break;
                    }
                }
                else if (String.IsNullOrEmpty(inp_dbname.Text))
                {
                    lbl_dbsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_dbsaveresp.Text = "Error";
                    inp_dbname.Text = "Field cannot be empty.";
                }
                else
                {
                    lbl_dbsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_dbsaveresp.Text = "Error";
                    inp_dbexe.Text = "File could not be found.";
                }
            } catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (box_dbwindow.Checked != Default.dbWindow)
            {
                updateSettingKey("dbWindow", box_dbwindow.Checked);
            }       
        }

        private void btn_mailsave_Click(object sender, EventArgs e)
        {
            lbl_mailsaveresp.Visible = true;
            lbl_mailsaveresp.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_mailsaveresp.Text = "Saved!";

            if (!String.IsNullOrEmpty(inp_mailname.Text))
            {
                updateSettingKey("mailName", inp_mailname.Text);
            }
            else
            {
                lbl_mailsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                lbl_mailsaveresp.Text = "Error";
                inp_mailname.Text = "Field cannot be empty.";
            }

            try
            {
                if (File.Exists(inp_mailexe.Text))
                {
                    switch (Path.GetExtension(inp_mailexe.Text))
                    {
                        case ".exe":
                            updateSettingKey("mailProc", inp_mailexe.Text);
                            break;
                        case ".bat":
                            updateSettingKey("mailProc", inp_mailexe.Text);
                            break;
                        default:
                            lbl_mailsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                            lbl_mailsaveresp.Text = "Error";
                            inp_mailexe.Text = "Unsupported file type.";
                            break;
                    }
                }
                else if (String.IsNullOrEmpty(inp_mailexe.Text))
                {
                    lbl_mailsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_mailsaveresp.Text = "Error";
                    inp_mailexe.Text = "Field cannot be empty.";
                }
                else
                {
                    lbl_mailsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_mailsaveresp.Text = "Error";
                    inp_mailexe.Text = "File could not be found.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (box_mailwindow.Checked != Default.mailWindow)
            {
                updateSettingKey("mailWindow", box_mailwindow.Checked);
            }
        }

        private void btn_websave_Click(object sender, EventArgs e)
        {
            lbl_websaveresp.Visible = true;
            lbl_websaveresp.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_websaveresp.Text = "Saved!";

            if (!String.IsNullOrEmpty(inp_webname.Text))
            {
                updateSettingKey("webName", inp_webname.Text);
            }
            else
            {
                lbl_websaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                lbl_websaveresp.Text = "Error";
                inp_webname.Text = "Field cannot be empty.";
            }

            try
            {
                if (File.Exists(inp_webexe.Text))
                {
                    switch (Path.GetExtension(inp_webexe.Text))
                    {
                        case ".exe":
                            updateSettingKey("webProc", inp_webexe.Text);
                            break;
                        case ".bat":
                            updateSettingKey("webProc", inp_webexe.Text);
                            break;
                        default:
                            lbl_websaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                            lbl_websaveresp.Text = "Error";
                            inp_webexe.Text = "Unsupported file type.";
                            break;
                    }
                }
                else if (String.IsNullOrEmpty(inp_webexe.Text))
                {
                    lbl_websaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_websaveresp.Text = "Error";
                    inp_webexe.Text = "Field cannot be empty.";
                } else
                {
                    lbl_websaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                    lbl_websaveresp.Text = "Error";
                    inp_webexe.Text = "File could not be found.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (box_webwindow.Checked != Default.webWindow)
            {
                updateSettingKey("webWindow", box_webwindow.Checked);
            }
        }

        private void btn_maintsave_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.maintEdit == true)
            {
                lbl_maintsaveresp.Visible = true;
                lbl_maintsaveresp.ForeColor = Color.FromArgb(0, 192, 0);
                lbl_maintsaveresp.Text = "Saved!";

                try
                {
                    if (File.Exists(inp_maintsource.Text))
                    {
                        switch (Path.GetExtension(inp_maintsource.Text))
                        {
                            case ".html":
                                updateSettingKey("maintSource", inp_maintsource.Text);
                                break;
                            default:
                                lbl_maintsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                                lbl_maintsaveresp.Text = "Error";
                                inp_maintsource.Text = "Unsupported file type.";
                                break;
                        }
                    }
                    else if (String.IsNullOrEmpty(inp_maintsource.Text))
                    {
                        lbl_maintsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                        lbl_maintsaveresp.Text = "Error";
                        inp_maintsource.Text = "Field cannot be empty.";
                    }
                    else
                    {
                        lbl_maintsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                        lbl_maintsaveresp.Text = "Error";
                        inp_maintsource.Text = "File could not be found.";
                    }



                    if (Directory.Exists(inp_maintdest.Text) && inp_maintdest.Text != Path.GetDirectoryName(inp_maintsource.Text))
                    {
                        updateSettingKey("maintDest", inp_maintdest.Text);
                    }
                    else if (String.IsNullOrEmpty(inp_maintdest.Text))
                    {
                        lbl_maintsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                        lbl_maintsaveresp.Text = "Error";
                        inp_maintdest.Text = "Field cannot be empty.";
                    }
                    else if (inp_maintdest.Text == Path.GetDirectoryName(inp_maintsource.Text))
                    {
                        lbl_maintsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                        lbl_maintsaveresp.Text = "Error";
                        inp_maintsource.Text = "Cannot be the same directory as destination.";
                        inp_maintdest.Text = "Cannot be the same directory as source.";
                    }
                    else
                    {
                        lbl_maintsaveresp.ForeColor = Color.FromArgb(255, 0, 0);
                        lbl_maintsaveresp.Text = "Error";
                        inp_maintdest.Text = "Directory could not be found.";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while saving the directories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                grp_maint.Text = "Cannot edit while maintenance mode is active.";
                grp_maint.Enabled = false;
                inp_maintsource.Text = Default.maintSource;
                inp_maintdest.Text = Default.maintDest;
            }
        }

        private void btn_dbbrowse_Click(object sender, EventArgs e)
        {
           inp_dbexe.Text = selectProcFile();
        }

        private void btn_mailbrowse_Click(object sender, EventArgs e)
        {
            inp_mailexe.Text = selectProcFile();
        }

        private void btn_webbrowse_Click(object sender, EventArgs e)
        {
            inp_webexe.Text = selectProcFile();
        }

        private void btn_sourcebrowse_Click(object sender, EventArgs e)
        {
            inp_maintsource.Text = selectWebpageFile();
        }

        private void btn_destbrowse_Click(object sender, EventArgs e)
        {
            inp_maintdest.Text = selectWebpageFolder();
        }

        private void box_comms_Click(object sender, EventArgs e)
        {
            if (box_comms.Checked)
            {
                updateSettingKey("serverComms", true);
            }
            else if (!box_comms.Checked)
            {
                updateSettingKey("serverComms", false);
            }
        }

        private void box_startup_Click(object sender, EventArgs e)
        {
            if (box_startup.Checked)
            {
                regkey.SetValue("CoreLoader", Application.ExecutablePath);
            }
            else if (!box_startup.Checked)
            {
                regkey.DeleteValue("CoreLoader", false);
            }
        }
    }
}
