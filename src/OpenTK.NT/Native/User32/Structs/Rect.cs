using System.Drawing;

using LONG = System.Int32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the coordinates of the upper-left and lower-right corners of a rectangle.
    /// </summary>
    /// <remarks>
    /// By convention, the right and bottom edges of the rectangle are normally considered exclusive. In other words,
    /// the pixel whose coordinates are (right, bottom) lies immediately outside of the the rectangle. For example,
    /// when RECT is passed to the FillRect function, the rectangle is filled up to, but not including, the right
    /// column and bottom row of pixels.
    /// </remarks>
    public struct Rect
    {
        /// <summary>
        /// Specifies the x-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public LONG Left;

        /// <summary>
        /// Specifies the y-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public LONG Top;

        /// <summary>
        /// Specifies the x-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public LONG Right;

        /// <summary>
        /// Specifies the y-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public LONG Bottom;

        /// <summary>
        /// Gets the width of the rectangle.
        /// </summary>
        public LONG Width => Right - Left;

        /// <summary>
        /// Gets the height of the rectangle.
        /// </summary>
        public LONG Height => Bottom - Top;

        /// <inheritdoc/>
        public override string ToString() => $"({Left}, {Top})-({Right}, {Bottom})";

        public static implicit operator Rectangle(Rect rect)
        {
            return Rectangle.FromLTRB(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

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

        public static implicit operator Rect(Size value)
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
