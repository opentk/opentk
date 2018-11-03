using System.Drawing;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines the coordinates of the upper-left and lower-right corners of a rectangle.
    /// </summary>
    /// <remarks>
    /// By convention, the right and bottom edges of the rectangle are normally considered exclusive. In other words,
    /// the pixel whose coordinates are (right, bottom) lies immediately outside of the the rectangle. For example,
    /// when <see cref="Rect"/> is passed to the FillRect function, the rectangle is filled up to, but not including,
    /// the right column and bottom row of pixels.
    /// </remarks>
    public struct Rect
    {
        /// <summary>
        /// Specifies the x-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public int Left;

        /// <summary>
        /// Specifies the y-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public int Top;

        /// <summary>
        /// Specifies the x-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public int Right;

        /// <summary>
        /// Specifies the y-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public int Bottom;

        /// <summary>
        /// Gets the width of the rectangle.
        /// </summary>
        public int Width => Right - Left;

        /// <summary>
        /// Gets the height of the rectangle.
        /// </summary>
        public int Height => Bottom - Top;

        /// <inheritdoc/>
        public override string ToString() => $"{{X={Left},Y={Top},Width={Width},Height={Height}}}";

        /// <summary>
        /// Implicitly converts a <see cref="Rect"/> structure into a <see cref="Rectangle"/> structure.
        /// </summary>
        /// <param name="value">A <see cref="Rectangle"/> with the same values as the given <see cref="Rect"/>.</param>
        public static implicit operator Rectangle(Rect value)
        {
            return Rectangle.FromLTRB(value.Left, value.Top, value.Right, value.Bottom);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Rectangle"/> structure into a <see cref="Rect"/> structure.
        /// </summary>
        /// <param name="value">A <see cref="Rect"/> with the same values as the given <see cref="Rectangle"/>.</param>
        public static implicit operator Rect(Rectangle value)
        {
            return new Rect
            {
                Left = value.Left,
                Right = value.Right,
                Top = value.Top,
                Bottom = value.Bottom
            };
        }

        /// <summary>
        /// Creates a <see cref="Rect"/> structure with the specified Size at location (0,0).
        /// </summary>
        /// <param name="value">The size from which to construct the new <see cref="Rect"/> structure.</param>
        /// <returns>A <see cref="Rect"/> structure with the given size.</returns>
        public static Rect FromSize(Size value)
        {
            return new Rect
            {
                Left = 0,
                Right = value.Width,
                Top = 0,
                Bottom = value.Height
            };
        }
    }
}
