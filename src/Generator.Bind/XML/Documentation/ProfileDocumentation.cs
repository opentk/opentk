using System;
using System.Collections.Generic;
using System.Linq;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML.Documentation
{
    /// <summary>
    /// Represents a set of documentation entries for a profile.
    /// </summary>
    public class ProfileDocumentation
    {
        /// <summary>
        /// Gets a dictionary of the functions that have been documented in the profile, mapped by their names, with the
        /// function prefix removed (such as gl, egl, glx, or wgl).
        /// </summary>
        private IReadOnlyDictionary<string, FunctionDocumentation> _documentedFunctions;

        /// <summary>
        /// Gets the function documentations in the profile.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<FunctionDocumentation> Functions { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileDocumentation"/> class.
        /// </summary>
        /// <param name="functions">The functions.</param>
        public ProfileDocumentation([NotNull] IReadOnlyList<FunctionDocumentation> functions)
        {
            Functions = functions ?? throw new ArgumentNullException(nameof(functions));

            _documentedFunctions = functions.ToDictionary(f => new string(f.Name.SkipWhile(char.IsLower).ToArray()));
        }

        /// <summary>
        /// Attempts to retrieve documentation for a given function.
        /// </summary>
        /// <param name="function">The function.</param>
        /// <param name="documentation">The documentation, if any.</param>
        /// <returns>true if the function has documentation; otherwise, false.</returns>
        [ContractAnnotation("true, documentation : notnull <=; false, documentation : null <=")]
        public bool TryGetDocumentation
        (
            [NotNull] FunctionSignature function,
            [CanBeNull] out FunctionDocumentation documentation
        )
        {
            return _documentedFunctions.TryGetValue(function.NativeEntrypoint, out documentation);
        }

        /// <summary>
        /// Gets the documentation for a given function.
        /// </summary>
        /// <param name="function">The function.</param>
        /// <returns>The documentation.</returns>
        [NotNull]
        public FunctionDocumentation GetDocumentation([NotNull] FunctionSignature function)
        {
            return _documentedFunctions[function.NativeEntrypoint];
        }

        /// <summary>
        /// Determines whether or not a given function is documented.
        /// </summary>
        /// <param name="function">The function.</param>
        /// <returns>true if the function has documentation; otherwise, false.</returns>
        public bool HasDocumentation([NotNull] FunctionSignature function)
        {
            return _documentedFunctions.ContainsKey(function.NativeEntrypoint);
        }
    }
}
