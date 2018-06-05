using System.Drawing;
using System.Runtime.InteropServices;

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
    public struct RECT
    {
        /// <summary>
        /// Specifies the x-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        internal int left;

        /// <summary>
        /// Specifies the y-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        internal int top;

        /// <summary>
        /// Specifies the x-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        internal int right;

        /// <summary>
        /// Specifies the y-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        internal int bottom;

        internal int Width => right - left;
        internal int Height => bottom - top;

        public override string ToString()
        {
            return $"({left},{top})-({right},{bottom})";
        }

        internal Rectangle ToRectangle()
        {
            return Rectangle.FromLTRB(left, top, right, bottom);
        }

        internal static RECT From(Rectangle value)
        {
            var rect = new RECT();
            rect.left = value.Left;
            rect.right = value.Right;
            rect.top = value.Top;
            rect.bottom = value.Bottom;
            return rect;
        }

        internal static RECT From(Size value)
        {
            var rect = new RECT();
            rect.left = 0;
            rect.right = value.Width;
            rect.top = 0;
            rect.bottom = value.Height;
            return rect;
        }
    }
}
