namespace PluginChecker.Main
{
    /// <summary>
    /// Class which contains all functions related to debugging.
    /// </summary>
    internal class Debugging 
    {
        /// <summary>
        /// Shows an error message to the user.
        /// </summary>
        /// <param name="message">The displayed error message.</param>
        /// <param name="error">The thrown exception.</param>
        /// <param name="exit">Kills the running instance of the application.</param>
        internal static void ShowError(string message, Exception error, bool exit = false)
        {
            MessageBox.Show(message, error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (exit)
            {
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Saves information about the application to the debug log.
        /// </summary>
        /// <param name="message">The information to be saved.</param>
        internal static void Log(string message)
        {
            try
            {
                using StreamWriter writer = new(Globals.DebugLog, true);
                string timestamp = DateTime.Now.ToString("G");

                writer.WriteLine($"{timestamp}: {message}");
            }
            catch (Exception err)
            {
                ShowError($"Could not register actions in the debug log, please report this issue: {err}", err, true);
            }
        }

        /// <summary>
        /// Cleans up previous debug log if present
        /// </summary>
        internal static void LogCleanup()
        {
            try
            {
                File.Delete(Globals.DebugLog);
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not clean up old debug log: {err}");
                ShowError($"Could not clean up old debug log.", err);
            }
        }
    }
}
