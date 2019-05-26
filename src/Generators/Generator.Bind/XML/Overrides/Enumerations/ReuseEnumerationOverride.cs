//
// ReuseEnumerationOverride.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using JetBrains.Annotations;

namespace Bind.XML.Overrides.Enumerations
{
    /// <summary>
    /// Represents an override inclusion of the members of another enumeration.
    /// </summary>
    public class ReuseEnumerationOverride
    {
        /// <summary>
        /// Gets the name of the enumeration to reuse the tokens of.
        /// </summary>
        [NotNull]
        public string Enumeration { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReuseEnumerationOverride"/> class.
        /// </summary>
        /// <param name="enumeration">The name of the enumeration to reuse.</param>
        public ReuseEnumerationOverride([NotNull] string enumeration)
        {
            Enumeration = enumeration ?? throw new ArgumentNullException(nameof(enumeration));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Enumeration;
        }
    }
}
