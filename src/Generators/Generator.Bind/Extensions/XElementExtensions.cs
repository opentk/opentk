//
// XElementExtensions.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.IO;
using System.Linq;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Bind.Extensions
{
    /// <summary>
    /// Extensions for the <see cref="XElement"/> class.
    /// </summary>
    public static class XElementExtensions
    {
        /// <summary>
        /// Gets a required attribute from an element.
        /// </summary>
        /// <param name="element">The element to get the attribute from.</param>
        /// <param name="attributeName">The name of the attribute.</param>
        /// <param name="ignoreNamespace">Whether or not the namespace should be ignored.</param>
        /// <exception cref="InvalidDataException">Thrown if the attribute is not present.</exception>
        /// <returns>The attribute.</returns>
        [NotNull]
        public static XAttribute GetRequiredAttribute
        (
            [NotNull] this XElement element,
            [NotNull] string attributeName,
            bool ignoreNamespace = true
        )
        {
            var attribute = ignoreNamespace
                ? element.Attributes().FirstOrDefault(a => a.Name.LocalName == attributeName)
                : element.Attribute(attributeName);

            if (attribute is null)
            {
                throw new InvalidDataException($"Required attribute \"{attributeName}\" not found.");
            }

            return attribute;
        }
    }
}
