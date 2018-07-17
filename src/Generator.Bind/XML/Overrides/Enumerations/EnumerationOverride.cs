using System;
using System.Collections.Generic;
using Bind.XML.Signatures.Enumerations;
using JetBrains.Annotations;

namespace Bind.XML.Overrides.Enumerations
{
    /// <summary>
    /// Represents an enumeration definition in an API.
    /// </summary>
    public class EnumerationOverride
    {
        /// <summary>
        /// Gets the name of the enumeration.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the set of tokens contained in the enumeration.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<TokenSignature> DirectTokens { get; }

        /// <summary>
        /// Gets the set of token references contained in the enumeration. These are resolved in the baking step.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<UseTokenOverride> UseTokens { get; }

        /// <summary>
        /// Gets the set of enumeration reuse references contained in the enumeration. These are resolved in the baking
        /// step.
        /// </summary>
        [NotNull, ItemNotNull]
        public IReadOnlyList<ReuseEnumerationOverride> ReuseEnumerations { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationOverride"/> class.
        /// </summary>
        /// <param name="name">The name of the enumeration.</param>
        /// <param name="directTokens">The tokens contained in the enumeration.</param>
        /// <param name="useTokens">The set of token references contained in the enumeration.</param>
        /// <param name="reuseEnumerations">The set of enumeration reuse references contained in the enumeration.</param>
        public EnumerationOverride
        (
            [NotNull] string name,
            [NotNull, ItemNotNull] List<TokenSignature> directTokens,
            [NotNull, ItemNotNull] IReadOnlyList<UseTokenOverride> useTokens,
            [NotNull, ItemNotNull] IReadOnlyList<ReuseEnumerationOverride> reuseEnumerations)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));

            DirectTokens = directTokens ?? throw new ArgumentNullException(nameof(directTokens));
            UseTokens = useTokens ?? throw new ArgumentNullException(nameof(useTokens));
            ReuseEnumerations = reuseEnumerations ?? throw new ArgumentNullException(nameof(reuseEnumerations));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"enum {Name} {{ ... }}";
        }
    }
}
