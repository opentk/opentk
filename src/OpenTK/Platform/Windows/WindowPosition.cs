using OpenTK.NT.Native;
using System.Runtime.InteropServices;

using HWND = System.IntPtr;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// The WindowPosition structure contains information about the size and position of a window.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowPosition
    {
        /// <summary>
        /// Handle to the window.
        /// </summary>
        internal HWND hwnd;

        /// <summary>
        /// Specifies the position of the window in Z order (front-to-back position).
        /// This member can be a handle to the window behind which this window is placed,
        /// or can be one of the special values listed with the SetWindowPos function.
        /// </summary>
        internal HWND hwndInsertAfter;

        /// <summary>
        /// Specifies the position of the left edge of the window.
        /// </summary>
        internal int x;

        /// <summary>
        /// Specifies the position of the top edge of the window.
        /// </summary>
        internal int y;

        /// <summary>
        /// Specifies the window width, in pixels.
        /// </summary>
        internal int cx;

        /// <summary>
        /// Specifies the window height, in pixels.
        /// </summary>
        internal int cy;

        /// <summary>
        /// Specifies the window position.
        /// </summary>
        internal SetWindowPosFlags flags;
    }
}
