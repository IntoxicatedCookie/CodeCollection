using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using static PluginChecker.Main.Debugging;

namespace PluginChecker
{
    internal partial class IncompatibilityAnalysis : Form
    {
        private string? LatestGTAVVer { get; set; }
        private string? LatestRPHVer { get; set; }
        private string? LatestLSPDFRVer { get; set; }
        private string? GTAVState { get; set; }
        private string? RPHState { get; set; }
        private string? LSPDFRState { get; set; }
        private bool PluginsDetected = false;

        internal IncompatibilityAnalysis()
        {
            Log("[INFO]: Initializing components of IncompatibilityAnalysis window...");
            InitializeComponent();
            Log("[INFO]: Components initialized successfully");
            Log("[INFO]: Getting dependency versions...");
            GetDependencyVersions(Main.Globals.StoredDependencyData);
        }

        internal void GetDependencyVersions(JArray data)
        {
            try
            {
                Log("[INFO]: Determining latest versions of dependencies...");
                LatestGTAVVer = data[0]["gtavVersion"].ToString();
                LatestRPHVer = data[0]["rphVersion"].ToString();
                LatestLSPDFRVer = data[0]["lspdfrVersion"].ToString();

                Log("[INFO]: Showing the latest versions...");
                GTAVLatest.Text = $"Latest version: {LatestGTAVVer}";
                RPHLatest.Text = $"Latest version: {LatestRPHVer}";
                LSPDFRLatest.Text = $"Latest version: {LatestLSPDFRVer}";
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not get latest versions of dependencies: {err}");
                ShowError("Could not get latest versions of dependencies.", err, true);
            }
        }

        private void AnalyseLogFile()
        {
            try
            {
                Log("[INFO]: Resetting results of analysis...");
                ResetResults();

                Log("[INFO]: Showing file dialog to select log file...");
                LogSelector.Filter = "Log|*.log";
                DialogResult result = LogSelector.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (string line in File.ReadAllLines(LogSelector.FileName))
                    {
                        if (Regex.IsMatch(line, @"\[.*\] Product version: "))
                        {
                            Log("[INFO]: Checking if GTA V is up to date...");
                            CheckGTAVVersion(line);
                        }
                        else if (Regex.IsMatch(line, @"\[.*\] Version: RAGE Plugin Hook v"))
                        {
                            Log("[INFO]: Checking if RagePluginHook is up to date...");
                            CheckRPHVersion(line);
                        }
                        else if (Regex.IsMatch(line, @"\[.*\] LSPD First Response: \[INFO\] Running LSPD First Response "))
                        {
                            Log("[INFO]: Checking if LSPDFR is up to date...");
                            CheckLSPDFRVersion(line);
                        }
                        else if (Regex.IsMatch(line, @"\[.*\] LSPD First Response: .*, Version=.*, Culture=neutral, PublicKeyToken=null"))
                        {
                            Log("[INFO]: Checking if plugin is up to date...");
                            CheckPlugin(line);
                        }
                        else if (Regex.IsMatch(line, @"\[.*\] LSPD First Response: Creating plugin: .*"))
                        {
                            Log("[INFO]: Finishing analysis, all required data was obtained...");
                            break;
                        }
                    }

                    if (GTAVInstalled.ForeColor == Color.Red || RPHInstalled.ForeColor == Color.Red || LSPDFRInstalled.ForeColor == Color.Red && DataDisplay.Rows.Count < 0)
                    {
                        Log("[INFO]: Creating summary of type \"criticalupdates\"...");
                        CreateSummary("criticalupdates");
                    }
                    else if (!PluginsDetected || GTAVInstalled.ForeColor == Color.White || RPHInstalled.ForeColor == Color.White || LSPDFRInstalled.ForeColor == Color.White)
                    {
                        Log("[INFO]: Creating summary of type \"undetected\"...");
                        CreateSummary("undetected");
                    }
                    else if (DataDisplay.Rows.Count > 0)
                    {
                        Log("[INFO]: Creating summary of type \"pluginupdates\"...");
                        CreateSummary("pluginupdates");
                    }
                    else
                    {
                        Log("[INFO]: Creating summary of type \"noupdates\"...");
                        CreateSummary("noupdates");
                    }
                }
                else
                {
                    Log("[WARN]: Invalid log file selected");
                    MessageBox.Show("Please select a valid RagePluginHook log.", "Invalid log", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not analyse log file: {err}");
                ShowError("Could not analyse log file.", err, true);
            }
        }

        private void ResetResults()
        {
            try
            {
                PluginsDetected = false;
                SummaryIcon.Image = null;

                GTAVState = null;
                RPHState = null;
                LSPDFRState = null;
                CopyResultsLink.Visible = false;

                MainTitle.Text = "Get started by selecting your RagePluginHook log";
                MainTitle.ForeColor = Color.White;
                MainDesc.Text = "Please make sure you select a valid log.";
                IconLogHelp.Visible = true;

                GTAVInstalled.Text = "Installed version: Unknown";
                GTAVInstalled.ForeColor = Color.White;

                RPHInstalled.Text = "Installed version: Unknown";
                RPHInstalled.ForeColor = Color.White;

                LSPDFRInstalled.Text = "Installed version: Unknown";
                LSPDFRInstalled.ForeColor = Color.White;

                PluginsStatus.Text = "Status: Please select your RagePluginHook log to get started.";
                PluginsStatus.ForeColor = Color.White;
                DataDisplay.Rows.Clear();
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not reset results of analysis: {err}");
                ShowError("Could not reset results of analysis.", err, true);
            }
        }

        private void CheckGTAVVersion(string line)
        {
            try
            {
                Log("[INFO]: Determining the installed version of GTA V...");
                string installedVer = Regex.Replace(line, @"\[.*\] Product version: ", "");

                Log($"[INFO]: Installed version of GTA V is {installedVer}, latest version is {LatestGTAVVer}");
                GTAVInstalled.Text = $"Installed version: {installedVer}";

                if (installedVer == LatestGTAVVer)
                {
                    GTAVState = $"GTA V: Up to date, {installedVer}";
                    GTAVInstalled.ForeColor = Color.LightGreen;
                }
                else
                {
                    GTAVState = $"GTA V: Outdated, please update to {LatestGTAVVer}";
                    GTAVInstalled.ForeColor = Color.Red;
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not check GTA V versions: {err}");
                ShowError("Could not check GTA V versions.", err);
            }
        }

        private void CheckRPHVersion(string line)
        {
            try
            {
                Log("[INFO]: Determining the installed version of RagePluginHook...");
                string installedVer = Regex.Replace(line, @"\[.*\] Version: RAGE Plugin Hook ", "").Replace(" for Grand Theft Auto V", "");

                Log($"[INFO]: Installed version of RagePluginhook is {installedVer}, latest version is {LatestRPHVer}");
                RPHInstalled.Text = $"Installed version: {installedVer}";

                if (installedVer == LatestRPHVer)
                {
                    RPHState = $"RagePluginHook: Up to date, {installedVer}";
                    RPHInstalled.ForeColor = Color.LightGreen;
                } else
                {
                    RPHState = $"RagePluginHook: Outdated, please update to {LatestRPHVer}";
                    RPHInstalled.ForeColor = Color.Red;
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not check RagePluginHook versions: {err}");
                ShowError("Could not check RagePluginHook versions.", err);
            }
        }

        private void CheckLSPDFRVersion(string line)
        {
            try
            {
                Log("[INFO]: Determining the installed version of LSPDFR...");
                string installedVer = Regex.Replace(line, @"\[.*\]\s+", "").Replace("Running LSPD First Response ", "");

                Log($"[INFO]: Installed version of LSPDFR is {installedVer}, latest version is {LatestLSPDFRVer}");
                LSPDFRInstalled.Text = $"Installed version: {installedVer}";

                if (installedVer == LatestLSPDFRVer)
                {
                    LSPDFRState = $"LSPDFR: Up to date, {installedVer}";
                    LSPDFRInstalled.ForeColor = Color.LightGreen;
                }
                else
                {
                    LSPDFRState = $"LSPDFR: Outdated, please update to {LatestLSPDFRVer}";
                    LSPDFRInstalled.ForeColor = Color.Red;
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not check LSPDFR versions: {err}");
                ShowError("Could not check LSPDFR versions.", err);
            }
        }

        private void CheckPlugin(string line)
        {
            try
            {
                Log("[INFO]: Determining plugin name...");
                string fileName = Regex.Replace(line, @"\[.*\] LSPD First Response: ", "");
                string cleanFileName = Regex.Replace(fileName, @",.*", "").Replace(" ", "").ToLower();
                PluginsDetected = true;

                if (!CheckboxShowAll.Checked)
                {

                    foreach (var plugin in Main.Globals.StoredPluginData)
                    {
                        if (plugin["fileName"].ToString() == cleanFileName)
                        {
                            Log($"[INFO]: Adding outdated plugin to grid...");
                            DataDisplay.Rows.Add(plugin["name"], plugin["author"], plugin["url"], plugin["lspdfrAPI"], plugin["lastUpdated"]);
                        }
                    }
                }
                else
                {
                    Log($"[INFO]: Adding detected plugin to grid...");
                    DataDisplay.Rows.Add(cleanFileName);
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not check plugin: {err}");
                ShowError("Could not check plugin.", err);
            }
        }

        private void CreateSummary(string type)
        {
            try
            {
                if (!CheckboxShowAll.Checked)
                {
                    IconLogHelp.Visible = false;
                    CopyResultsLink.Visible = true;
                    BrowseBtn.Image = Properties.Resources.btn_selectotherlog;

                    switch (type)
                    {
                        case "criticalupdates":
                            Log("[INFO]: Showing that critical updates are required...");
                            MainTitle.Text = "Critical updates are required";
                            MainTitle.ForeColor = Color.Red;
                            MainDesc.Text = "Your GTA V, RagePluginHook and/or LSPDFR installation requires an update.";

                            SummaryIcon.Image = Properties.Resources.summary_coreupdates;
                            PluginsStatus.Text = $"Status: Critical updates have priority.";
                            PluginsStatus.ForeColor = Color.Red;
                            break;
                        case "pluginupdates":
                            Log("[INFO]: Showing that plugin updates are required...");
                            MainTitle.ForeColor = Color.Orange;
                            MainTitle.Text = "Plugin updates are required";
                            MainDesc.Text = "Some of your installed plugins are outdated and require removal.";

                            SummaryIcon.Image = Properties.Resources.summary_pluginupdates;
                            PluginsStatus.Text = $"Status: Detected {DataDisplay.Rows.Count} outdated plugin(s).";
                            PluginsStatus.ForeColor = Color.Orange;
                            break;
                        case "noupdates":
                            Log("[INFO]: Showing that no updates are required...");
                            MainTitle.ForeColor = Color.LightGreen;
                            MainTitle.Text = "Great, no updates are required";
                            MainDesc.Text = "No version incompatibilities found that could affect your game.";

                            SummaryIcon.Image = Properties.Resources.summary_noupdates;
                            PluginsStatus.Text = "Status: No outdated plugins were detected.";
                            PluginsStatus.ForeColor = Color.LightGreen;
                            break;
                        case "undetected":
                            Log("[INFO]: Showing that not all data is present...");

                            MainTitle.ForeColor = Color.Silver;
                            MainTitle.Text = "Undetected data";
                            MainDesc.Text = "Not all data is present in the log, detected data is being shown.";

                            SummaryIcon.Image = Properties.Resources.summary_undetected;
                            PluginsStatus.Text = "Status: No plugins were detected.";
                            PluginsStatus.ForeColor = Color.Silver;
                            break;
                    }

                    DialogResult result = MessageBox.Show("Finished analysis succesfully.\nCopy results to clipboard?", "Analysis finished", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        CopyResults();
                    }
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not create summary: {err}");
                ShowError("Could not create summary.", err);
            }
        }

        private void CopyResults()
        {
            try
            {
                List<string> outdatedPlugins = new();

                if (DataDisplay.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DataDisplay.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex == 0)
                            {
                                outdatedPlugins.Add(cell.Value.ToString());
                            }
                        }
                    }
                } 
                else
                {
                    outdatedPlugins.Add("No outdated plugins detected.");
                }

                string results = $"Dependencies:\n{GTAVState}\n{RPHState}\n{LSPDFRState}\n\nOutdated plugins:\n{string.Join("\n", outdatedPlugins)}";
                Clipboard.SetText(results);

                MessageBox.Show("Results successfully copied to clipboard.", "Results copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not copy results to clipboard: {err}");
                ShowError("Could not copy results to clipboard.", err);
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            AnalyseLogFile();
        }

        private void DataDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    Log("[INFO]: Opening plugin URL...");
                    string? url = DataDisplay.Rows[e.RowIndex].Cells[2].Value.ToString();

                    Main.Networking.OpenInBrowser(url);
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not open URL from grid: {err}");
                ShowError("Could not open URL from grid.", err);
            }
        }

        private void IconLogHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Log("[INFO]: Checking if LogHelp window is already opened...");

                if (!Application.OpenForms.OfType<LogHelp>().Any())
                {
                    Log("[INFO]: Opening new LogHelp window...");
                    Form LogHelp = new LogHelp();

                    LogHelp.Show();
                }
                else
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is LogHelp)
                        {
                            Log("[INFO]: Bringing exising LogHelp window to front...");
                            form.BringToFront();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not open LogHelp window: {err}");
                ShowError("Could not open new window.", err);
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Log("[INFO]: Closing current window and opening Home window...");
                Hide();
                Form HomeForm = new Views.Home();
                HomeForm.Closed += (s, args) => Close();
                HomeForm.Show();
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not open Home window: {err}");
                ShowError("Could not open new window.", err);
            }
        }

        private void CheckboxShowAll_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not reached its final state yet and you might experience issues with it.", "Experimental feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyResultsLink_Click(object sender, EventArgs e)
        {
            CopyResults();
        }
    }
}