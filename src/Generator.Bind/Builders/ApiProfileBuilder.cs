using System.Collections.Generic;
using Bind.Versioning;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Builders
{
    /// <summary>
    /// Acts as a builder for new instances of <see cref="ApiProfile"/>s, based on existing instances.
    /// </summary>
    public class ApiProfileBuilder
    {
        [NotNull]
        private string _newName;

        [NotNull]
        private VersionRange _newVersions;

        [NotNull]
        private IReadOnlyList<FunctionSignature> _newNativeSignatures;

        [NotNull]
        private IReadOnlyList<FunctionSignature> _newOverloads;

        [NotNull]
        private IReadOnlyList<EnumerationSignature> _newEnumerations;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfileBuilder"/> class.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public ApiProfileBuilder([NotNull] ApiProfile profile)
        {
            _newName = profile.Name;
            _newVersions = profile.Versions;
            _newNativeSignatures = profile.NativeSignatures;
            _newOverloads = profile.Overloads;
            _newEnumerations = profile.Enumerations;
        }

        /// <summary>
        /// Sets a new name for the profile.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ApiProfileBuilder WithName([NotNull] string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new version range for the profile.
        /// </summary>
        /// <param name="newVersions">The new version range.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ApiProfileBuilder WithVersions([NotNull] VersionRange newVersions)
        {
            _newVersions = newVersions;
            return this;
        }

        /// <summary>
        /// Sets new native signatures for the profile.
        /// </summary>
        /// <param name="newNativeSignatures">The new native signatures.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ApiProfileBuilder WithNativeSignatures([NotNull] IReadOnlyList<FunctionSignature> newNativeSignatures)
        {
            _newNativeSignatures = newNativeSignatures;
            return this;
        }

        /// <summary>
        /// Sets new overloads for the profile.
        /// </summary>
        /// <param name="newOverloads">The new overloads.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ApiProfileBuilder WithOverloads([NotNull] IReadOnlyList<FunctionSignature> newOverloads)
        {
            _newOverloads = newOverloads;
            return this;
        }

        /// <summary>
        /// Sets new enumerations for the profile.
        /// </summary>
        /// <param name="newEnumerations">The new enumerations.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ApiProfileBuilder WithEnumerations([NotNull] IReadOnlyList<EnumerationSignature> newEnumerations)
        {
            _newEnumerations = newEnumerations;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
        public ApiProfile Build()
        {
            return new ApiProfile
            (
                _newName,
                _newVersions,
                _newNativeSignatures,
                _newEnumerations,
                _newOverloads
            );
        }
    }
}
