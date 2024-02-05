using System.Text.RegularExpressions;
using static PluginChecker.Main.Debugging;
using static PluginChecker.Main.Globals;

namespace PluginChecker
{
    public partial class BrowsePlugins : Form
    {
        public BrowsePlugins()
        {
            Log("[INFO]: Initializing components of BrowsePlugins window...");
            InitializeComponent();
            Log("[INFO]: Components initialized successfully");
            Log("[INFO]: Populating grid...");
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            try
            {
                if (StoredPluginData != null)
                {

                    foreach (var plugin in StoredPluginData)
                    {
                       DataDisplay.Rows.Add(plugin["name"], plugin["author"], plugin["url"], plugin["lspdfrAPI"], plugin["lastUpdated"]);
                    }
                }
                else
                {
                    throw new Exception("No valid plugin data was supplied to populate grid with.");
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not populate grid with valid plugin data: {err}");
                ShowError("Could not populate grid with valid plugin data.", err, true);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SearchBox.Text))
                {
                    Log("[INFO]: Executing search query...");
                    Log("[INFO]: Clearing rows and reading stored plugin data...");
                    DataDisplay.Rows.Clear();

                    if (StoredPluginData != null)
                    {
                        Log("[INFO]: Populating grid with search results...");

                        foreach (var plugin in StoredPluginData)
                        {
                            string query = Regex.Replace(plugin["name"].ToString().ToLower(), @"\s+", "");
                            string input = Regex.Replace(SearchBox.Text.ToLower(), @"\s+", "");

                            if (query.Contains(input))
                            {
                                DataDisplay.Rows.Add(plugin["name"], plugin["author"], plugin["url"], plugin["lspdfrAPI"], plugin["lastUpdated"]);
                            }
                        }

                        Log("[INFO]: Calculating amount of search results...");
                        int totalRes = DataDisplay.Rows.Count;

                        if (totalRes == 0)
                        {
                            ResultsText.Text = "No results match your criteria.";
                            ResultsText.ForeColor = Color.Red;
                            ResultsText.Visible = true;

                            Log("[INFO]: No search results for entered criteria");
                        }
                        else
                        {
                            ResultsText.Text = $"Found {totalRes} result(s).";
                            ResultsText.ForeColor = Color.LimeGreen;
                            ResultsText.Visible = true;

                            Log($"[INFO]: {totalRes} search result(s) for entered criteria");
                        }
                    }
                    else
                    {
                        throw new Exception("No valid plugin data was supplied to populate grid with.");
                    }
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not execute search query: {err}");
                ShowError("Could not execute search query.", err);
            }
        }

        private void ClearLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Log("[INFO]: Clearing search query and populating grid...");
                SearchBox.Text = string.Empty;
                ResultsText.Visible = false;

                DataDisplay.Rows.Clear();
                PopulateGrid();
            } 
            catch (Exception err)
            {
                Log($"[ERROR]: Could not clear search query: {err}");
                ShowError("Could not clear search query.", err);
            }
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
    }
}