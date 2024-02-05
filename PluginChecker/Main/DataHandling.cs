using Newtonsoft.Json.Linq;
using static PluginChecker.Main.Debugging;

namespace PluginChecker.Main
{
    /// <summary>
    /// Class which contains all functions related to handling data.
    /// </summary>
    internal class DataHandling
    {
        /// <summary>
        /// Fetches the specified data from the PluginChecker API.
        /// </summary>
        /// <param name="category">The type of data that needs fetching.</param>
        /// <param name="read">Reads the data after fetching it.</param>
        internal static void FetchData(string category, bool read = true)
        {
            try
            {
                Log($"[INFO]: Fetching data of \"{category}\" category from API...");
                string? fetchedData = Networking.CreateWebRequest($"https://pluginchecker.vercel.app/api/fetchdata?category={category}&version=v2");

                if (!string.IsNullOrEmpty(fetchedData))
                {
                    Log("[INFO]: Storing fetched data...");
                    using (StreamWriter writer = new(Globals.CacheDirectory + $@"\{category}.cache", false))
                    {
                        writer.Write(fetchedData);
                    }

                    if (read)
                    {
                        Log("[INFO]: Reading fetched data...");
                        ReadData(category);
                    }
                }
                else
                {
                    throw new Exception("Could not store data as the fetched data is invalid");
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not fetch and store required data of \"{category}\" category: {err}");
                DialogResult message = MessageBox.Show($"Could not fetch and store required data of \"{category}\" category.\n\nPlease check your internet connection and try again.", $"{err.GetType()}", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (message == DialogResult.Retry)
                {
                    Log("[INFO]: Retrying to fetch data and store it...");
                    FetchData(category);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Reads the specified data from the locally stored cache.
        /// </summary>
        /// <param name="category">The type of data that needs reading.</param>
        internal static void ReadData(string category)
        {
            try
            {
                if (File.Exists(Globals.CacheDirectory + $@"\{category}.cache"))
                {
                    string storedData = File.ReadAllText(Globals.CacheDirectory + $@"\{category}.cache");

                    Log($"[INFO]: Extracting stored data of \"{category}\" category...");
                    JObject parsedData = JObject.Parse(storedData);

                    switch (category)
                    {
                        case "main":
                            JArray? appData = (JArray?)parsedData["app"];
                            Globals.StoredAppData = appData;

                            break;
                        case "versions":
                            JArray? versionData = (JArray?)parsedData["dependencies"];
                            Globals.StoredDependencyData = versionData;

                            break;
                        case "plugins":
                            JArray? pluginData = (JArray?)parsedData["plugins"];
                            Globals.StoredPluginData = pluginData;

                            break;
                    }
                }
                else
                {
                    Log("[WARN]: Required stored data is not present, fetching it...");
                    FetchData(category);
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not read stored data of \"{category}\" category: {err}");
                ShowError($"Could not read stored data of \"{category}\" category.", err, true);
            }
        }
    }
}
