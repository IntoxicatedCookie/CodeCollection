using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Configuration;
using static CoreLoader.Properties.Settings;

namespace CoreLoader
{
    public partial class Panel : Form
    {
        public class DAPIValues
        {
            [JsonPropertyName("resptime")]
            public string RespTime { get; set; }
        }

        public void DAPIRequest(string url = "https://sociocon.com/dapi/")
        {
            try
            {
                Thread.Sleep(5000);
                var values = string.Empty;

                using (var web = new WebClient())
                {
                    Log($"Downloading JSON values from {url}...", "info");
                    values = web.DownloadString(url);
                }

                if (!string.IsNullOrEmpty(values) && values != "[]")
                {
                    Log("Deserializing downloaded JSON values...", "info");
                    DAPIValues dapi = JsonSerializer.Deserialize<DAPIValues>(values);
                    if (!string.IsNullOrEmpty(dapi.RespTime))
                    {
                        lbl_resptime.Text = dapi.RespTime + " ms";
                        lbl_resptime.Visible = true;
                        Log($"Server response time was {lbl_resptime.Text}", "info");
                    }
                }
                else
                {
                    Log("No JSON values found to derserialize", "warn");
                }
            }
            catch (Exception err)
            {
                Log($"An error occurred while getting JSON values from {url}: {err}", "error");
                lbl_resptime.Text = "Unknown";
                MessageBox.Show($"An error occurred while getting data from the server on {url}.\nPlease check your internet connection / the debug log.", $"{err.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public  void Log(string msg, string type, string file = "cl.log")
        {
            try
            {
                using StreamWriter w = File.AppendText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + $@"\{file}");
                var timestamp = DateTime.Now.ToString("G");

                switch (type)
                {
                    case "info":
                        w.WriteLine($"{timestamp}: [INFO]: " + msg);
                        rtxt_log.AppendText("[INFO]: " + msg + Environment.NewLine);
                        rtxt_log.ScrollToCaret();
                        break;
                    case "warn":
                        w.WriteLine($"{timestamp}: [WARN]: " + msg);
                        rtxt_log.AppendText("[WARN]:" + msg + Environment.NewLine);
                        rtxt_log.ScrollToCaret();
                        break;
                    case "error":
                        w.WriteLine($"{timestamp}: [ERROR]: " + msg);
                        rtxt_log.AppendText("[ERROR]: " + msg + Environment.NewLine);
                        rtxt_log.ScrollToCaret();
                        break;
                    case "debug":
                        w.WriteLine($"{timestamp}: [DEBUG]: " + msg);
                        rtxt_log.AppendText("[DEBUG]:" + msg + Environment.NewLine);
                        rtxt_log.ScrollToCaret();
                        break;
                    default:
                        throw new Exception("An invalid action type was defined");
                }
            } catch (Exception err)
            {
                MessageBox.Show($"Failed to log actions to debug log, please report this issue: {err}", $"{err.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        public void LogCleanup(bool force = false, string file = "cl.log")
        {
            try
            {
                if (File.GetLastWriteTime(file).Day <= DateTime.Today.AddDays(-1).Day || force)
                {
                    rtxt_log.Clear();
                    File.Delete(file);
                }
            } catch (Exception err)
            {
                Log($"Could not clean up {file}: {err}", "error");
                MessageBox.Show($"An error occurred while cleaning up old log files. Check the debug log.", $"{err.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InitializeSettings()
        {
            if (Default.serverComms)
            {
                strpmenu_conntest.Enabled = true;
            } else
            {
                strpmenu_conntest.Enabled = false;
            }
        }

        public Panel()
        {
            try
            {
                InitializeComponent();
                LogCleanup();
                Log("Startup procedure initialized", "info");
                Log("Running CoreLoader v1.0.0-dev, Build MAIN_100.2.0", "info");
                Log("This is a development release! You might experience issues.", "warn");
                Log("Initializing configuration and settings...", "info");
                InitializeSettings();
                Log("Initializing the application...", "info");
            } catch (Exception err)
            {
                Log($"Could not initialize the component on startup: {err}", "error");
                MessageBox.Show($"An error occurred while initializing the application. Check the debug log.", $"{err.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateSettingKey(string key, object value)
        {
            try
            {
                Log($"Saving the {key} setting with a value of {value}.", "info");
                Default[key] = value;
                Default.Save();
            }
            catch (Exception err)
            {
                Log($"An error occurred while updating the {key} setting: {err}", "error");
                MessageBox.Show($"An error occurred while updating settings. Check the debug log.", $"{err.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool isRunning(string name)
        {
            try
            {
                Log($"Gathering all running instances of {name}...", "info");

                var process = Process.GetProcessesByName(name);

                if (process.Length > 0)
                {
                    Log("Found " + process.Length + " matching instances.", "info");
                    return true;
                }
                else
                {
                    Log("No matching instances found.", "info");
                    return false;
                }
            }
            catch (Exception err)
            {
                Log($"An error occurred while getting running instances of {name}: {err}", "error");
                MessageBox.Show("An error occurred while checking the running instances. Check the debug log.", $"{err.GetType()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void killRunning(string name)
        {
            Log($"Gathering all running instances of {name}...", "info");
            foreach (Process proc in Process.GetProcesses())
            {
                if (proc.ProcessName == name)
                {
                    Log("Matching instance found, attempting to kill it...", "info");
                    proc.Kill();
                }
            }
        }

        public void statusCheck()
        {
            Log("Performing a statuscheck...", "info");

            if (isRunning(Default.dbName))
            {
                lbl_dbstate.Text = "Online";
                lbl_dbstate.ForeColor = Color.FromArgb(0, 192, 0);
                btn_dbrun.Text = "Stop";
                Log("Database detected as online.", "info");
            }
            else
            {
                lbl_dbstate.Text = "Offline";
                lbl_dbstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_dbrun.Text = "Start";
                Log("Database detected as offline.", "info");
            }

            if (isRunning(Default.mailName))
            {
                lbl_mailstate.Text = "Online";
                lbl_mailstate.ForeColor = Color.FromArgb(0, 192, 0);
                btn_mailrun.Text = "Stop";
                Log("Mailserver detected as online.", "info");
            }
            else
            {
                lbl_mailstate.Text = "Offline";
                lbl_mailstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_mailrun.Text = "Start";
                Log("Mailserver detected as offline.", "info");
            }


            if (isRunning("php-cgi") == true)
            {
                lbl_gatewaysstate.Text = "Online";
                lbl_gatewaysstate.ForeColor = Color.FromArgb(0, 192, 0);
                btn_gatewaysrun.Text = "Stop";
                Log("Gateway detected as online.", "info");
            }
            else
            {
                lbl_gatewaysstate.Text = "Offline";
                lbl_gatewaysstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_gatewaysrun.Text = "Start";
                Log("Gateway detected as offline.", "info");
            }

            if (isRunning(Default.webName))
            {
                lbl_webstate.Text = "Online";
                lbl_webstate.ForeColor = Color.FromArgb(0, 192, 0);
                btn_webrun.Text = "Stop";
                Log("Webserver detected as online.", "info");
            }
            else
            {
                lbl_webstate.Text = "Offline";
                lbl_webstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_webrun.Text = "Start";
                Log("Webserver detected as offline.", "info");
            }

            string file = Path.GetFileName(Default.maintSource);
            string dest = Default.maintDest;

            string destPath = Path.Combine(dest, file);

            if (File.Exists(destPath))
            {
                box_maint.Checked = true;
                strpmenu_conntest.Enabled = false;
                Log("Maintenance mode is active.", "info");
            }
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            statusCheck();
        }

        private void btn_dbrun_Click(object sender, EventArgs e)
        {
            if (!isRunning(Default.dbName)) 
            {
                if (Default.dbProc != null && File.Exists(Default.dbProc))
                {
                    Process db = new Process();
                    db.StartInfo.FileName = Default.dbProc;
                    db.StartInfo.CreateNoWindow = Default.dbWindow;
                    db.Start();


                    lbl_dbstate.Text = "Online";
                    lbl_dbstate.ForeColor = Color.FromArgb(0, 192, 0);
                    btn_dbrun.Text = "Stop";
                }
            }
            else if (isRunning(Default.dbName))
            {
                killRunning(Default.dbName);
                lbl_dbstate.Text = "Offline";
                lbl_dbstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_dbrun.Text = "Start";
            }
        }

        private void btn_mailrun_Click(object sender, EventArgs e)
        {
            if (!isRunning(Default.mailName))
            {
                if (Default.mailProc != null && File.Exists(Default.mailProc))
                {
                    Process mail = new Process();
                    mail.StartInfo.FileName = Default.mailProc;
                    mail.StartInfo.CreateNoWindow = Default.mailWindow;
                    mail.Start();


                    lbl_mailstate.Text = "Online";
                    lbl_mailstate.ForeColor = Color.FromArgb(0, 192, 0);
                    btn_mailrun.Text = "Stop";
                }
            }
            else if (isRunning(Default.mailName))
            {
                killRunning(Default.mailName);
                lbl_mailstate.Text = "Offline";
                lbl_mailstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_mailrun.Text = "Start";
            }
        }

        private void btn_gatewaysrun_Click(object sender, EventArgs e)
        {
            if (!isRunning("php-cgi"))
            {
                Process gate7 = new Process();
                gate7.StartInfo.FileName = @"C:\Sociocon\core\nginx\fastcgi\gate_7.bat";
                gate7.StartInfo.CreateNoWindow = true;
                gate7.Start();

                Process gate8 = new Process();
                gate8.StartInfo.FileName = @"C:\Sociocon\core\nginx\fastcgi\gate_8.bat";
                gate8.StartInfo.CreateNoWindow = true;
                gate8.Start();

                lbl_gatewaysstate.Text = "Online";
                lbl_gatewaysstate.ForeColor = Color.FromArgb(0, 192, 0);
                btn_gatewaysrun.Text = "Stop";
            }
            else if (isRunning("php-cgi"))
            {
                killRunning("php-cgi");
                lbl_gatewaysstate.Text = "Offline";
                lbl_gatewaysstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_gatewaysrun.Text = "Start";
            }
        }

        private void btn_webrun_Click(object sender, EventArgs e)
        {
            if (!isRunning(Default.webName))
            {
                if (Properties.Settings.Default.webProc != null && File.Exists(Properties.Settings.Default.webProc))
                {
                    Process web = new Process();
                    web.StartInfo.FileName = Properties.Settings.Default.webProc;
                    web.StartInfo.CreateNoWindow = Properties.Settings.Default.webWindow;
                    web.Start();


                    lbl_webstate.Text = "Online";
                    lbl_webstate.ForeColor = Color.FromArgb(0, 192, 0);
                    btn_webrun.Text = "Stop";
                }
            }
            else if (isRunning(Properties.Settings.Default.webName))
            {
                killRunning(Properties.Settings.Default.webName);
                lbl_webstate.Text = "Offline";
                lbl_webstate.ForeColor = Color.FromArgb(255, 0, 0);
                btn_webrun.Text = "Start";
            }
        }
        private void box_maint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This action affects many servers.\nDo you wish to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (box_maint.Checked)
                {
                    if (result == DialogResult.Yes)
                    {
                        string file = Path.GetFileName(Default.maintSource);
                        string source = Default.maintSource;
                        string dest = Default.maintDest;

                        string destPath = Path.Combine(dest, file);
                        File.Move(source, destPath);
                        strpmenu_conntest.Enabled = false;

                        updateSettingKey("maintEdit", false);
                    } 
                    else
                    {
                        box_maint.Checked = false;
                    }
                }
                else if (!box_maint.Checked)
                {
                    if (result == DialogResult.Yes)
                    {
                        string file = Path.GetFileName(Default.maintSource);
                        string dest = Default.maintDest;
                        string source = Default.maintSource;

                        string destPath = Path.Combine(dest, file);
                        File.Move(destPath, source);
                        strpmenu_conntest.Enabled = Default.serverComms;

                        updateSettingKey("maintEdit", true);
                    }
                    else
                    {
                        box_maint.Checked = true;
                    }
                }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            SettingsView form = new SettingsView();
            form.Show();
        }

        private void btn_master_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This action affects many servers.\nDo you wish to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                btn_dbrun_Click(null, null);
                btn_mailrun_Click(null, null);
                btn_gatewaysrun_Click(null, null);
                btn_webrun_Click(null, null);
            }
        }

        private void btn_dbdir_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Default.dbProc);
            Process.Start("explorer.exe", dir);
        }

        private void btn_maildir_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Properties.Settings.Default.mailProc);
            Process.Start("explorer.exe", dir);
        }

        private void btn_webdir_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Properties.Settings.Default.webProc);
            Process.Start("explorer.exe", dir);
        }

        private void strpmenu_app_refresh_Click(object sender, EventArgs e)
        {
            statusCheck();
        }

        private void strpmenu_app_preferences_Click(object sender, EventArgs e)
        {
            SettingsView form = new SettingsView();
            form.Show();
        }

        private void strpmenu_app_quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void strpmenu_conn_test_Click(object sender, EventArgs e)
        {
            Log("Testing connection, please stand by...", "info");
            DAPIRequest();
        }

        private void link_clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtxt_log.Clear();
        }
    }
}
