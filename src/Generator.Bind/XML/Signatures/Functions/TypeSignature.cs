using System;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Functions
{
    /// <summary>
    /// Represents a type signature in an API.
    /// </summary>
    public class TypeSignature
    {
        /// <summary>
        /// Gets the name of the type.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the type.</param>
        public TypeSignature([NotNull] string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Name;
        }
    }
}
