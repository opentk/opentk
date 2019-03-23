/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
  * See license.txt for license info
 */

using System;
using System.IO;
using System.Reflection;

namespace Generator.Bind
{
    /// <summary>
    /// Class for handling embedded resources.
    /// </summary>
    internal class EmbeddedResources
    {
        private static readonly Lazy<string> _licenseText = new Lazy<string>
        (
            () =>
            {
                TryGetSpecification("License.txt", out var result);
                return result;
            }
        );

        /// <summary>
        /// Gets the license text from the embedded resource.
        /// </summary>
        public static string LicenseText => _licenseText.Value;

        /// <summary>
        /// Gets the specification with the given filename.
        /// </summary>
        /// <param name="filename">The file name.</param>
        /// <param name="contents">The contents of the specification.</param>
        /// <returns>Whether the operation was successful or not.</returns>
        public static bool TryGetSpecification(string filename, out string contents)
        {
            try
            {
                using (var streamReader = new StreamReader
                (
                    Assembly.GetAssembly(typeof(Program))
                        .GetManifestResourceStream("Generator.Bind.Specifications." + filename)
                ))
                {
                    contents = streamReader.ReadToEnd();
                    return true;
                }
            }
            catch (IOException)
            {
                contents = null;
                return false;
            }
        }
    }
}
