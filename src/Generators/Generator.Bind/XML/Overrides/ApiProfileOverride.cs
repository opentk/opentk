//
// ApiProfileOverride.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using Bind.Extensions;
using Bind.Versioning;
using Bind.XML.Overrides.Enumerations;
using Bind.XML.Overrides.Functions;
using JetBrains.Annotations;

namespace Bind.XML.Overrides
{
    /// <summary>
    /// Represents a set of overridden APIs in a given profile.
    /// </summary>
    public class ApiProfileOverride : IApiProfile
    {
        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public VersionRange Versions { get; }

        /// <summary>
        /// Gets the enumerations that were added to the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<EnumerationOverride> AddedEnumerations { get; }

        /// <summary>
        /// Gets the functions that were replaced in the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<FunctionOverride> ReplacedFunctions { get; }

        /// <summary>
        /// Gets the function overloads that were added to the profile.
        /// </summary>
        [Obsolete("Overloads can no longer be defined in the overrides file, please use helper classes instead.", true)]
        public IReadOnlyList<FunctionOverride> FunctionOverloads { get; }

        /// <summary>
        /// Gets the functions that were removed from the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<RemoveOverride> RemovedFunctions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfileOverride"/> class.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <param name="versions">The versions the profile encompasses.</param>
        /// <param name="addedEnumerations">The added enumerations.</param>
        /// <param name="replacedFunctions">The replaced functions.</param>
        /// <param name="functionOverloads">The function overloads.</param>
        /// <param name="removedFunctions">The removed functions.</param>
        [Obsolete("Use the constructor without overloads instead.")]
        public ApiProfileOverride(
            [NotNull] string name,
            [NotNull] VersionRange versions,
            [NotNull] IReadOnlyList<EnumerationOverride> addedEnumerations,
            [NotNull] IReadOnlyList<FunctionOverride> replacedFunctions,
            [NotNull] IReadOnlyList<FunctionOverride> functionOverloads,
            [NotNull] IReadOnlyList<RemoveOverride> removedFunctions)
        : this(name, versions, addedEnumerations, replacedFunctions, removedFunctions)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfileOverride"/> class.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <param name="versions">The versions the profile encompasses.</param>
        /// <param name="addedEnumerations">The added enumerations.</param>
        /// <param name="replacedFunctions">The replaced functions.</param>
        /// <param name="removedFunctions">The removed functions.</param>
        public ApiProfileOverride(
            [NotNull] string name,
            [NotNull] VersionRange versions,
            [NotNull] IReadOnlyList<EnumerationOverride> addedEnumerations,
            [NotNull] IReadOnlyList<FunctionOverride> replacedFunctions,
            [NotNull] IReadOnlyList<RemoveOverride> removedFunctions)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Versions = versions ?? throw new ArgumentNullException(nameof(versions));
            AddedEnumerations = addedEnumerations ?? throw new ArgumentNullException(nameof(addedEnumerations));
            ReplacedFunctions = replacedFunctions ?? throw new ArgumentNullException(nameof(replacedFunctions));
            RemovedFunctions = removedFunctions ?? throw new ArgumentNullException(nameof(removedFunctions));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} - {this.GetFriendlyName()}, v{Versions}";
        }
    }
}
