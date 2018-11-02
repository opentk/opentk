using System;

namespace OpenToolkit.OpenAL.Attributes
{
    /// <summary>
    /// Specifies the native size of one sample of a given buffer format.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class FormatSizeAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the native size of the buffer format. Defaults to one byte.
        /// </summary>
        public int Size
        {
            get => _size;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The size must be a nonzero positive value.");
                }

                _size = value;
            }
        }

        private int _size = 1;
    }
}
