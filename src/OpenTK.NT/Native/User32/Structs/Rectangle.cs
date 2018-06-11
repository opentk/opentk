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
    public struct Rectangle
    {
        /// <summary>
        /// Specifies the x-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        internal LONG left;

        /// <summary>
        /// Specifies the y-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        internal LONG top;

        /// <summary>
        /// Specifies the x-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        internal LONG right;

        /// <summary>
        /// Specifies the y-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        internal LONG bottom;

        internal LONG Width => right - left;
        internal LONG Height => bottom - top;

        public override string ToString() => $"({left},{top})-({right},{bottom})";

        internal System.Drawing.Rectangle ToRectangle() => System.Drawing.Rectangle.FromLTRB(left, top, right, bottom);

        internal static Rectangle From(System.Drawing.Rectangle value)
            => new Rectangle
            {
                left = value.Left,
                right = value.Right,
                top = value.Top,
                bottom = value.Bottom
            };

        internal static Rectangle From(System.Drawing.Size value)
            => new Rectangle
            {
                left = 0,
                right = value.Width,
                top = 0,
                bottom = value.Height
            };
    }
}
