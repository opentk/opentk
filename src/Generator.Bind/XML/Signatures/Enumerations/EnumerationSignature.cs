using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Enumerations
{
    /// <summary>
    /// Represents an enumeration definition in an API.
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
        public IReadOnlyList<TokenSignature> Tokens { get; }

        /// <summary>
        /// Gets the version the enumeration was introduced in.
        /// </summary>
        [NotNull]
        public Version IntroducedIn { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the enumeration.</param>
        /// <param name="tokens">The tokens contained in the enumeration.</param>
        /// <param name="introducedIn">The version the enumeration was introduced in.</param>
        public EnumerationSignature
        (
            [NotNull] string name,
            [NotNull] IReadOnlyList<TokenSignature> tokens,
            [NotNull] Version introducedIn
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tokens = tokens ?? throw new ArgumentNullException(nameof(tokens));
            IntroducedIn = introducedIn ?? throw new ArgumentNullException(nameof(introducedIn));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"enum {Name} {{ ... }}";
        }
    }
}
