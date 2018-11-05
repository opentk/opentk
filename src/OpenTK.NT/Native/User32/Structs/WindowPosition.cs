using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about the size and position of a window.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowPosition
    {
        /// <summary>
        /// Handle to the window.
        /// </summary>
        public IntPtr HWnd;

        /// <summary>
        /// Specifies the position of the window in Z order (front-to-back position).
        /// This member can be a handle to the window behind which this window is placed,
        /// or can be one of the special values listed with the SetWindowPos function.
        /// </summary>
        public IntPtr HWndInsertAfter;

        /// <summary>
        /// Specifies the position of the left edge of the window.
        /// </summary>
        public int X;

        /// <summary>
        /// Specifies the position of the top edge of the window.
        /// </summary>
        public int Y;

        /// <summary>
        /// Specifies the window width, in pixels.
        /// </summary>
        public int Width;

        /// <summary>
        /// Specifies the window height, in pixels.
        /// </summary>
        public int Height;

        /// <summary>
        /// Specifies the window position.
        /// </summary>
        public SetWindowPosFlags Flags;
    }
}
