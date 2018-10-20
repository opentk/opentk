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
    ///
    /// These are, broadly speaking, a collection of function signatures, their overloads, and enums used by them.
    ///
    /// A profile is like a version which also includes a choice about if it supports deprecated functionality or not.
    /// This choice is typically referred to as core/compatibility profiles for a given version.
    /// </summary>
    public class ApiProfile : IApiProfile
    {
        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public VersionRange Versions { get; }

        /// <summary>
        /// Gets the available native signatures in the profile. These define the native P/Invoke signatures. Together
        /// with <see cref="Overloads"/>, they form the complete API surface.
        /// </summary>
        [NotNull]
        public IReadOnlyList<FunctionSignature> NativeSignatures { get; }

        /// <summary>
        /// Gets the available overloads in the profile. These define language-specific signatures that may not have a
        /// native equivalent, and are supplemental to the native signatures. Together with
        /// <see cref="NativeSignatures"/>, they form the complete API surface.
        /// </summary>
        [NotNull]
        public IReadOnlyList<FunctionSignature> Overloads { get; }

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
        /// <param name="nativeSignatures">The native signatures in the profile.</param>
        /// <param name="enumerations">The enumerations in the profile.</param>
        /// <param name="overloads">The overloads, if any.</param>
        public ApiProfile
        (
            [NotNull] string name,
            [NotNull] VersionRange versions,
            [NotNull] IReadOnlyList<FunctionSignature> nativeSignatures,
            [NotNull] IReadOnlyList<EnumerationSignature> enumerations,
            [CanBeNull] IReadOnlyList<FunctionSignature> overloads = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Versions = versions ?? throw new ArgumentNullException(nameof(versions));
            NativeSignatures = nativeSignatures ?? throw new ArgumentNullException(nameof(nativeSignatures));
            Enumerations = enumerations ?? throw new ArgumentNullException(nameof(enumerations));
            Overloads = overloads ?? new List<FunctionSignature>();
        }

        /// <summary>
        /// Looks up the first function that has the given native entrypoint.
        /// </summary>
        /// <param name="entrypoint">The entry point.</param>
        /// <returns>The function.</returns>
        [CanBeNull]
        public FunctionSignature FindFunctionWithEntrypoint([NotNull] string entrypoint)
        {
            var nativeSignature = NativeSignatures.FirstOrDefault(f => f.NativeEntrypoint == entrypoint);
            if (nativeSignature is null)
            {
                return Overloads.FirstOrDefault(f => f.NativeEntrypoint == entrypoint);
            }

            return nativeSignature;
        }

        /// <summary>
        /// Looks up the enumeration that contains the given token name.
        /// </summary>
        /// <param name="tokenName">The name of the token.</param>
        /// <returns>The enumeration that contains the token.</returns>
        [CanBeNull]
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

            if (!candidates.Any())
            {
                return null;
            }

            return candidates.First();
        }

        /// <summary>
        /// Gets the available categories in the profile.
        /// </summary>
        /// <returns>The categories.</returns>
        [NotNull, ItemNotNull]
        public IEnumerable<string> GetCategories()
        {
            var nativeCategories = NativeSignatures.SelectMany(f => f.Categories);
            var overloadCategories = Overloads.SelectMany(f => f.Categories);

            return nativeCategories.Concat(overloadCategories).Distinct();
        }

        /// <summary>
        /// Gets the available extensions in the profile.
        /// </summary>
        /// <returns>The extensions.</returns>
        [NotNull, ItemNotNull]
        public IEnumerable<string> GetExtensions()
        {
            var nativeExtensions = NativeSignatures.Select(f => f.Extension);
            var overloadExtensions = Overloads.Select(f => f.Extension);

            return nativeExtensions.Concat(overloadExtensions).Distinct();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} - {this.GetFriendlyName()}, v{Versions}";
        }
    }
}
