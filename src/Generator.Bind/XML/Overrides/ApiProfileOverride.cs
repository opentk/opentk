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
        [NotNull]
        public IReadOnlyList<FunctionOverride> FunctionOverloads { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfileOverride"/> class.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <param name="versions">The versions the profile encompasses.</param>
        /// <param name="addedEnumerations">The added enumerations.</param>
        /// <param name="replacedFunctions">The replaced functions.</param>
        /// <param name="functionOverloads">The function overloads.</param>
        public ApiProfileOverride
        (
            [NotNull] string name,
            [NotNull] VersionRange versions,
            [NotNull] IReadOnlyList<EnumerationOverride> addedEnumerations,
            [NotNull] IReadOnlyList<FunctionOverride> replacedFunctions,
            [NotNull] IReadOnlyList<FunctionOverride> functionOverloads
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Versions = versions ?? throw new ArgumentNullException(nameof(versions));
            AddedEnumerations = addedEnumerations ?? throw new ArgumentNullException(nameof(addedEnumerations));
            ReplacedFunctions = replacedFunctions ?? throw new ArgumentNullException(nameof(replacedFunctions));
            FunctionOverloads = functionOverloads ?? throw new ArgumentNullException(nameof(functionOverloads));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} - {this.GetFriendlyName()}, v{Versions}";
        }
    }
}
