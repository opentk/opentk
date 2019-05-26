//
// Extension.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Xml.Linq;

namespace OpenTK.Convert
{
    /// <summary>
    /// Contains extension methods for the bindings converter.
    /// </summary>
    internal static class Extension
    {
        /// <summary>
        /// Returns the value for the given attribute or an empty string.
        /// </summary>
        /// <param name="a">The attribute whose value should be returned, if any.</param>
        /// <returns>The value or an empty string.</returns>
        public static string ValueOrDefault(this XAttribute a)
        {
            return a != null ? a.Value : string.Empty;
        }
    }
}
