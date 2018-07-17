using System;
using System.Collections.Generic;
using Bind.Extensions;
using Bind.Versioning;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML.Signatures
{
    /// <summary>
    /// Represents an available API profile of a specific version.
    /// </summary>
    public class ApiProfile : IApiProfile
    {
        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public VersionRange Versions { get; }

        /// <summary>
        /// Gets the available functions in the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<FunctionSignature> Functions { get; }

        /// <summary>
        /// Gets the available enumerations in the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<EnumerationSignature> Enumerations { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfile"/> class.
        /// </summary>
        /// <param name="name">The profile name.</param>
        /// <param name="versions">The versions the profile encompasses.</param>
        /// <param name="functions">The functions in the profile.</param>
        /// <param name="enumerations">The enumerations in the profile.</param>
        public ApiProfile
        (
            [NotNull] string name,
            [NotNull] VersionRange versions,
            [NotNull] IReadOnlyList<FunctionSignature> functions,
            [NotNull] IReadOnlyList<EnumerationSignature> enumerations
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Versions = versions ?? throw new ArgumentNullException(nameof(versions));
            Functions = functions ?? throw new ArgumentNullException(nameof(functions));
            Enumerations = enumerations ?? throw new ArgumentNullException(nameof(enumerations));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} - {this.GetFriendlyName()}, v{Versions}";
        }
    }
}
