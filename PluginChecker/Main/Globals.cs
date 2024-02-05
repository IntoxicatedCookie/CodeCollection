using Newtonsoft.Json.Linq;

namespace PluginChecker.Main
{
    /// <summary>
    /// Class which contains all global variables.
    /// </summary>
    internal class Globals
    {
        /// <summary>
        /// JArray which contains all stored data about the application.
        /// </summary>
        internal static JArray? StoredAppData { get; set; }

        /// <summary>
        /// JArray which contains all stored data about the main GTA V dependencies.
        /// </summary>
        internal static JArray? StoredDependencyData { get; set; }

        /// <summary>
        /// JArray which contains all stored data about GTA V plugins.
        /// </summary>
        internal static JArray? StoredPluginData { get; set; }

        /// <summary>
        /// DateTime which contains the timestamp when the received data was last updated.
        /// </summary>
        internal static DateTime? DataLastUpdated { get; set; }

        /// <summary>
        /// DateTime which contains the timestamp when the update checker last ran.
        /// </summary>
        internal static DateTime? VersionLastChecked { get; set; }

        /// <summary>
        /// String which contains the latest version of the application.
        /// </summary>
        internal static string? LatestVersion { get; set; }


        /// <summary>
        /// Readonly string which contains the current version of the application.
        /// </summary>
        internal static readonly string CurrentVersion = "v0.1.2b";

        /// <summary>
        /// Readonly string which contains the path to the AppData directory of the application.
        /// </summary>
        internal static readonly string AppdataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PluginChecker");

        /// <summary>
        /// Readonly string which contains the path to the cache directory of the application.
        /// </summary>
        internal static readonly string CacheDirectory = AppdataDirectory + $@"\cache\";

        /// <summary>
        /// Readonly string which contains the path to the debug log of the application.
        /// </summary>
        internal static readonly string DebugLog = AppdataDirectory + $@"\PluginChecker.log";
    }
}
