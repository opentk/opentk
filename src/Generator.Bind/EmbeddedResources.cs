 /* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
  * See license.txt for license info
 */

using System;
using System.IO;
using System.Reflection;

namespace Bind
{
    /// <summary>
    /// Class for handling embedded resources.
    /// </summary>
    internal class EmbeddedResources
    {
        private static readonly Lazy<string> _licenseText = new Lazy<string>(() =>
        {
            using (var streamReader = new StreamReader(Assembly.GetAssembly(typeof(Program))
                   .GetManifestResourceStream("Bind.Specifications.License.txt")))
            {
                return streamReader.ReadToEnd();
            }
        });

        /// <summary>
        /// Gets the license text from the embedded resource.
        /// </summary>
        public static string LicenseText => _licenseText.Value;
    }
}
