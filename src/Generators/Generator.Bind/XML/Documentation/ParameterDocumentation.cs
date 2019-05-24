//
// ParameterDocumentation.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using Humanizer;
using JetBrains.Annotations;

namespace Bind.XML.Documentation
{
    /// <summary>
    /// Represents documentation of a parameter.
    /// </summary>
    public class ParameterDocumentation
    {
        /// <summary>
        /// Gets the name of the parameter.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the parameter's description.
        /// </summary>
        [NotNull]
        public string Description { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDocumentation"/> class.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The parameter's description.</param>
        public ParameterDocumentation([NotNull] string name, [NotNull] string description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} - {Description.Truncate(64)}";
        }
    }
}
