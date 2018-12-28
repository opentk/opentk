using MoreLinq.Extensions;

namespace Generator.Common.Functions
{
    /// <summary>
    /// Represents a C# type signature.
    /// </summary>
    public class Type
    {
        /// <summary>
        /// Gets or sets a value indicating whether this type is a pointer.
        /// </summary>
        public bool IsPointer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this type is an array.
        /// </summary>
        public bool IsArray { get; set; }

        /// <summary>
        /// Gets or sets the amount of indirection levels (asterisks as represented in C#).
        /// </summary>
        public int IndirectionLevels { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of the array (i.e. the amount of [] as represented in C#).
        /// </summary>
        public int ArrayDimensions { get; set; }

        /// <summary>
        /// Gets or sets the name of this type.
        /// </summary>
        public string Name { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return Name +
                   (IsPointer ? new string('*', IndirectionLevels) : string.Empty) +
                   (IsArray ? "[]".Repeat(ArrayDimensions) : string.Empty);
        }
    }
}
