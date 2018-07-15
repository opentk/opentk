using System;
using System.Collections.Generic;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML.Overrides
{
    /// <summary>
    /// Represents a set of overridden APIs in a given profile.
    /// </summary>
    public class ApiProfileOverride
    {
        /// <summary>
        /// Gets the name of the profile.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the version of the profile.
        /// </summary>
        [NotNull]
        public Version Version { get; }

        /// <summary>
        /// Gets the functions that were added to the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<FunctionSignature> AddedFunctions { get; }

        /// <summary>
        /// Gets the enumerations that were added to the profile.
        /// </summary>
        [NotNull]
        public IReadOnlyList<EnumerationSignature> AddedEnumerations { get; }

        /// <summary>
        /// Gets the functions that were replaced in the profile.
        /// </summary>
        public IReadOnlyList<FunctionSignature> ReplacedFunctions { get; }

        /// <summary>
        /// Gets the enumerations that were replaced in the profile.
        /// </summary>
        public IReadOnlyList<EnumerationSignature> ReplacedEnumerations { get; }
    }
}
