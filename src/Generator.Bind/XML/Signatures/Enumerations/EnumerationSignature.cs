using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Enumerations
{
    /// <summary>
    /// Represents an enumeration definition in an API.
    ///
    /// This is a collection of values that functions can take. These are enums in C#.
    /// </summary>
    public class EnumerationSignature
    {
        /// <summary>
        /// Gets the name of the enumeration.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets a value indicating whether this enumeration is a set of bit flags.
        /// </summary>
        public bool IsFlagEnum => Name.EndsWith("Mask", StringComparison.Ordinal);

        /// <summary>
        /// Gets the set of tokens contained in the enumeration.
        /// </summary>
        [NotNull]
        public IReadOnlyList<TokenSignature> Tokens { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the enumeration.</param>
        /// <param name="tokens">The tokens contained in the enumeration.</param>
        public EnumerationSignature
        (
            [NotNull] string name,
            [CanBeNull] IReadOnlyList<TokenSignature> tokens = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tokens = tokens ?? new List<TokenSignature>();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"enum {Name} {{ ... }}";
        }
    }
}
