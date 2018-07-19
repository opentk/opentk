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
        /// Gets the level of indirection (i.e, the number of pointer levels) of the type.
        /// </summary>
        public int IndirectionLevel { get; }

        /// <summary>
        /// Gets the number of array dimensions of the type.
        /// </summary>
        public int ArrayDimensions { get; }

        /// <summary>
        /// Gets a value indicating whether the type is a pointer.
        /// </summary>
        public bool IsPointer => IndirectionLevel > 0;

        /// <summary>
        /// Gets a value indicating whether the type is an array.
        /// </summary>
        public bool IsArray => ArrayDimensions > 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the type.</param>
        /// <param name="indirectionLevel">The level of indirection the type has.</param>
        /// <param name="arrayDimensions">The number of array dimensions the type has.</param>
        public TypeSignature([NotNull] string name, int indirectionLevel, int arrayDimensions)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ArrayDimensions = arrayDimensions;
            IndirectionLevel = indirectionLevel;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Name;
        }
    }
}
