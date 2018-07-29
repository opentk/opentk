using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Looks up the function that has the given native entrypoint.
        /// </summary>
        /// <param name="entrypoint">The entry point.</param>
        /// <returns>The function.</returns>
        [NotNull]
        public FunctionSignature FindFunctionWithEntrypoint([NotNull] string entrypoint)
        {
            return Functions.First(f => f.NativeEntrypoint == entrypoint);
        }

        /// <summary>
        /// Looks up the enumeration that contains the given token name.
        /// </summary>
        /// <param name="tokenName">The name of the token.</param>
        /// <returns>The enumeration that contains the token.</returns>
        public EnumerationSignature FindContainingEnumeration(string tokenName)
        {
            var candidates = Enumerations
                .Where(e => e.Tokens.Any(t => t.Name == tokenName))
                .OrderBy(e => e.Name)
                .ToList();

            // Try to get the most specialized candidate
            var specializedEnums = candidates.Where
            (
                c => !c.Name.Contains("Version")
            )
            .OrderByDescending(c => c.Name.Length)
            .ToList(); // long enum names tend to be more specialized...

            if (specializedEnums.Any())
            {
                return specializedEnums.First();
            }

            return candidates.First();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} - {this.GetFriendlyName()}, v{Versions}";
        }
    }
}
