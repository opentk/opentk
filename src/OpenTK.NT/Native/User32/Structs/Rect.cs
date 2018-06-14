using System.Drawing;
using System.Runtime.InteropServices;

using LONG = System.Int32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the coordinates of the upper-left and lower-right corners of a rectangle.
    /// </summary>
    /// <remarks>
    /// By convention, the right and bottom edges of the rectangle are normally considered exclusive. In other words, the
    /// pixel whose coordinates are (right, bottom) lies immediately outside of the the rectangle. For example, when RECT
    /// is passed to the FillRect function, the rectangle is filled up to, but not including, the right column and bottom
    /// row of pixels. This structure is identical to the RECTL structure.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
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

        public LONG Width => Right - Left;
        public LONG Height => Bottom - Top;

        public override string ToString() => $"({Left},{Top})-({Right},{Bottom})";

        public Rectangle ToRectangle() => Rectangle.FromLTRB(Left, Top, Right, Bottom);

        public static Rect From(Rectangle value)
            => new Rect
            {
                Left = value.Left,
                Right = value.Right,
                Top = value.Top,
                Bottom = value.Bottom
            };

        public static Rect From(Size value)
            => new Rect
            {
                Left = 0,
                Right = value.Width,
                Top = 0,
                Bottom = value.Height
            };
    }
}
