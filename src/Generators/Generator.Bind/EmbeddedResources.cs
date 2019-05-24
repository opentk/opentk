//
// EmbeddedResources.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

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
                .GetManifestResourceStream("Bind.Specifications.License.txt") ?? throw new NullReferenceException()))
            {
                return streamReader.ReadToEnd();
            }
        });

        /// <summary>
        /// Gets the license text from the embedded resource.
        /// </summary>
        /// <param name="fileName">The file that the license header is being added to.</param>
        /// <returns>The license text from the embedded resource.</returns>
        public static string LicenseText(string fileName) => _licenseText.Value.Replace("$FILENAME$", fileName)
            .Replace("$YEAR$", DateTime.Now.Year.ToString());
    }
}
