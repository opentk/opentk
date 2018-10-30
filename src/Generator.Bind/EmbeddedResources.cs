//
//  EmbeddedResources.cs
//
//  Copyright (C) 2018 OpenTK
//
//  This software may be modified and distributed under the terms
//  of the MIT license. See the LICENSE file for details.
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
