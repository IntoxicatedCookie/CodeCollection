using static PluginChecker.Main.Debugging;

namespace PluginChecker.Views
{
    internal partial class Home : Form
    {
        internal Home(bool startup = false)
        {
            if (startup)
            {
                Main.General.CleanStartup();
            }

            Log("[INFO]: Initializing components of Home window...");
            InitializeComponent();
            Log("[INFO]: Components initialized successfully");
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Log("[INFO]: Closing current window and opening IncompabilityAnalysis window...");
                Hide();

                Form IAForm = new IncompatibilityAnalysis();
                IAForm.Closed += (s, args) => Close();
                IAForm.Show();
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not open IncompabilityAnalysis window: {err}");
                ShowError("Could not open new window.", err);
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                Log("[INFO]: Closing current window and opening BrowsePlugins window...");
                Hide();

                Form BPForm = new BrowsePlugins();
                BPForm.Closed += (s, args) => Close();
                BPForm.Show();
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not open BrowsePlugins window: {err}");
                ShowError("Could not open new window.", err);
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Log("[INFO]: Showing application info...");
                MessageBox.Show($"Current version: {Main.Globals.CurrentVersion}\nData last updated: {Main.Globals.DataLastUpdated:g}\nLast checked: {Main.Globals.VersionLastChecked:g}\n\n© 2022 - 2023 by IntoxicatedCookie. All rights reserved.", "Application info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not get application info: {err}");
                ShowError("Could not get application info.", err);
            }
        }

        private void BtnUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                Log("[INFO]: Prompted to check for updates...");
                Main.UpdateChecker.CheckForUpdates(true);

                MessageBox.Show("You\'re all set, no application updates available right now.", "No updates available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not check for updates on prompt: {err}");
                ShowError("Could not check for updates on prompt.", err);
            }
        }

        private void BtnRepIssue_Click(object sender, EventArgs e)
        {
            Main.Networking.OpenInBrowser("https://discord.com/invite/ulss");
        }
    }
}