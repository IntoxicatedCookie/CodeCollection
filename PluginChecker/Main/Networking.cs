using System.Diagnostics;
using static PluginChecker.Main.Debugging;

namespace PluginChecker.Main
{
    /// <summary>
    /// Class which contains all functions relating to networking.
    /// </summary>
    internal class Networking
    {
        /// <summary>
        /// Creates a web request to the specified host.
        /// </summary>
        /// <param name="url">The URL to which the request will be sent.</param>
        internal static string? CreateWebRequest(string url)
        {
            HttpClient client = new();
            HttpRequestMessage request = new(HttpMethod.Get, url);
            HttpResponseMessage response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                using StreamReader reader = new(response.Content.ReadAsStream());
                string siteData = reader.ReadToEnd();

                Log("[INFO]: Downloaded and read data successfully");
                return siteData;
            }
            else
            {
                Log($"[WARN]: Response was unsuccessful (statuscode {(int)response.StatusCode}), further data was not read");
                return null;
            }
        }

        /// <summary>
        /// Opens the specied URL in the user's preferred browser.
        /// </summary>
        /// <param name="url">The URL that needs to be opened.</param>
        internal static void OpenInBrowser(string url)
        {
            try
            {
                ProcessStartInfo process = new()
                {
                    UseShellExecute = true,
                    FileName = url
                };

                Process.Start(process);
            }
            catch (Exception err)
            {
                Log($"[ERROR]: Could not open URL in browser: {err}");
                ShowError("Could not open URL in browser.", err);
            }
        }
    }
}
