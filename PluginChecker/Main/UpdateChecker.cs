using System.Globalization;
using static PluginChecker.Main.Debugging;
using static PluginChecker.Main.Globals;

namespace PluginChecker.Main
{
    /// <summary>
    /// Class which contains all functions related to the update checker.
    /// </summary>
    internal class UpdateChecker
    {
        /// <summary>  
        /// Checks for updates related to the application and all stored data about GTA V.
        /// </summary>
        /// <param name="prompted">Prompts the update checker to check for updates.</param>
        internal static void CheckForUpdates(bool prompted = false)
        {
            try
            {
                DataHandling.FetchData("main");

                VersionLastChecked = DateTime.Now;
                DataLastUpdated = DateTime.ParseExact(StoredAppData[0]["dataLastUpdated"].ToString(), "yyyyMMddHHmm", CultureInfo.InvariantCulture);
                LatestVersion = StoredAppData[0]["latestVersion"].ToString();

                if (File.Exists(CacheDirectory + $@"\versions.cache") && File.Exists(CacheDirectory + $@"\plugins.cache"))
                {
                    DateTime wtimeVersionsCache = DateTime.ParseExact(File.GetLastWriteTime(CacheDirectory + $@"\versions.cache").ToString("yyyyMMddHHmm"), "yyyyMMddHHmm", CultureInfo.InvariantCulture);
                    DateTime wtimePluginsCache = DateTime.ParseExact(File.GetLastWriteTime(CacheDirectory + $@"\plugins.cache").ToString("yyyyMMddHHmm"), "yyyyMMddHHmm", CultureInfo.InvariantCulture);

                    int versionsComp = DateTime.Compare(wtimeVersionsCache, (DateTime)DataLastUpdated);
                    int pluginsComp = DateTime.Compare(wtimePluginsCache, (DateTime)DataLastUpdated);

                    if (versionsComp < 0 || pluginsComp < 0 || wtimeVersionsCache.Day <= DateTime.Now.AddDays(-5).Day || wtimePluginsCache.Day <= DateTime.Now.AddDays(-5).Day)
                    {
                        if (versionsComp < 0 || wtimeVersionsCache.Day <= DateTime.Now.AddDays(-5).Day)
                        {
                            Log("[WARN]: New data available, clearing versions cache and fetching the latest data...");
                            File.Delete(CacheDirectory + $@"\versions.cache");

                            DataHandling.FetchData("versions", prompted);
                        }

                        if (pluginsComp < 0 || wtimePluginsCache.Day <= DateTime.Now.AddDays(-5).Day)
                        {
                            Log("[WARN]: New data available, clearing plugins cache and fetching the latest data...");
                            File.Delete(CacheDirectory + $@"\plugins.cache");

                            DataHandling.FetchData("plugins", prompted);
                        }

                        MessageBox.Show("Downloaded the most recent data.", "New data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                File.Delete(CacheDirectory + $@"\main.cache");
                Log($"[INFO]: Data last updated: {DataLastUpdated:g}");

                if (LatestVersion == CurrentVersion)
                {
                    Log($"[INFO]: Application is using the latest version, {LatestVersion}");
                }
                else
                {
                    Log($"[WARN]: Application update required, using version {CurrentVersion} while the latest version is {LatestVersion}");
                    DialogResult message = MessageBox.Show($"There is an application update required.\nYou\'re using version {CurrentVersion}, the latest version is {LatestVersion}.\n\nDo you want to update now in order to use the application?", "Application update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (message == DialogResult.Yes)
                    {
                        Log("[INFO]: Opening download page which contains new update...");

                        // UPDATE UPON FULL RELEASE
                        Networking.OpenInBrowser("https://github.com/IntoxicatedCookie/PluginChecker/releases/");
                    }

                    Environment.Exit(0);
                }
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not check for updates: {err}");
                DialogResult message = MessageBox.Show("Could not check for updates.\nPlease check your internet connection and try again.", $"{err.GetType()}", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (message == DialogResult.Retry)
                {
                    Log("[INFO]: Retrying to check for updates...");
                    CheckForUpdates();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
