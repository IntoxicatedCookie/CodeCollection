using static PluginChecker.Main.Debugging;

namespace PluginChecker.Main
{
    /// <summary>
    /// Class which contains all functions related to handling files and directories.
    /// </summary>
    internal class FileHandling
    {
        /// <summary>
        /// Checks mandatory directories, creates them if non existent.
        /// </summary>
        internal static void CheckDirectories()
        {
            try
            {
                Directory.CreateDirectory(Globals.AppdataDirectory);
                Directory.CreateDirectory(Globals.CacheDirectory);
            }
            catch (Exception err)
            {
                ShowError($"Could not check mandatory directories: {err}", err, true);
            }
        }
    }
}
