using System.IO;
using System.Reflection;

namespace Bind
{
    /// <summary>
    /// Class for handling embedded license text.
    /// </summary>
    internal class LicenseResource
    {
        private static string _license;

        /// <summary>
        /// Gets and returns the license text from the embedded resource.
        /// </summary>
        public static string LicenseText
        {
            get
            {
                if (_license != null)
                {
                    return _license;
                }

                var streamReader = new StreamReader(Assembly.GetAssembly(typeof(Program)).GetManifestResourceStream("Specifications/License.txt"));
                _license = streamReader.ReadToEnd();
                streamReader.Dispose();
                return _license;
            }
        }
    }
}
