using System;
using System.Collections.Generic;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML.Overrides.Functions
{
    /// <summary>
    /// Represents a function with overridden properties.
    /// </summary>
    public class FunctionOverride
    {
        /// <summary>
        /// Gets the name of the function that the override affects.
        /// </summary>
        [NotNull]
        public string BaseName { get; }

        /// <summary>
        /// Gets the extension that the function that the override affects is in.
        /// </summary>
        [CanBeNull]
        public string BaseExtensions { get; }

        /// <summary>
        /// Gets the new version that introduced the function.
        /// </summary>
        [CanBeNull]
        public Version NewVersion { get; }

        /// <summary>
        /// Gets the reason the function was made obsolete.
        /// </summary>
        [CanBeNull]
        public string ObsoletionReason { get; }

        /// <summary>
        /// Gets the new return type of the function.
        /// </summary>
        [CanBeNull]
        public TypeSignature NewReturnType { get; }

        /// <summary>
        /// Gets the overridden parameters in the function.
        /// </summary>
        [NotNull]
        public IReadOnlyList<ParameterOverride> ParameterOverrides { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionOverride"/> class.
        /// </summary>
        /// <param name="baseName">The name of the base function.</param>
        /// <param name="baseExtensions">The extensions of the base function.</param>
        /// <param name="newVersion">The new version that the function was introduced in.</param>
        /// <param name="obsoletionReason">The reason the function has been made obsolete.</param>
        /// <param name="newReturnType">The new return type.</param>
        /// <param name="parameterOverrides">The parameter overrides.</param>
        public FunctionOverride
        (
            [NotNull] string baseName,
            [CanBeNull] string baseExtensions,
            [CanBeNull] Version newVersion,
            [CanBeNull] string obsoletionReason,
            [CanBeNull] TypeSignature newReturnType,
            [NotNull] IReadOnlyList<ParameterOverride> parameterOverrides
        )
        {
            BaseName = baseName ?? throw new ArgumentNullException(nameof(baseName));
            BaseExtensions = baseExtensions;
            NewVersion = newVersion;
            ObsoletionReason = obsoletionReason;
            NewReturnType = newReturnType;
            ParameterOverrides = parameterOverrides ?? throw new ArgumentNullException(nameof(parameterOverrides));
        }
    }
}
