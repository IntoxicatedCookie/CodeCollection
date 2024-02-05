using System.Globalization;
using static PluginChecker.Main.Debugging;

namespace PluginChecker.Main
{
    /// <summary>
    /// Class which contains all general functions related to the application.
    /// </summary>
    internal partial class General
    {
        /// <summary>
        /// Executes a clean startup which triggers upon opening the application.
        /// </summary>
        internal static void CleanStartup()
        {

            FileHandling.CheckDirectories();
            LogCleanup();
            Log("[INFO]: Application has been started");
            Log("[INFO]: Mandatory directories have been checked, created them if not present");
            Log("[INFO]: Cleaned up old log file if present");
            Log($"[INFO]: Operating system: {Environment.OSVersion}");
            Log($"[INFO]: System language: {CultureInfo.CurrentCulture.NativeName} ({CultureInfo.CurrentCulture.Name})");
            Log($"[INFO]: System timezone: {TimeZoneInfo.Local}");
            Log("[INFO]: Checking for updates...");
            UpdateChecker.CheckForUpdates();
            Log("[INFO]: Reading stored data...");
            DataHandling.ReadData("versions");
            Log("[INFO]: Stored data was successfully read");
            Log("[INFO]: Reading stored data...");
            DataHandling.ReadData("plugins");
            Log("[INFO]: Stored data was successfully read");
            Log("[INFO]: Application successfully initialized");
            Log("[INFO]:");
            Log("[INFO]: ***************************************************");
            Log("[INFO]: *** Created and maintained by IntoxicatedCookie ***");
            Log("[INFO]: ***     All rights reserved, © 2022 - 2023      ***");
            Log("[INFO]: ***     Thanks for using this application!      ***");
            Log("[INFO]: ***************************************************");
            Log("[INFO]:");
        }
    }
}
