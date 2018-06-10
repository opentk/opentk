using System.Runtime.InteropServices;

using ATOM = System.UInt16;
using DWORD = System.UInt32;
using UINT = System.UInt32;
using WORD = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains window information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct WINDOWINFO
    {
        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public DWORD cbSize;

        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the window.
        /// </summary>
        public RECT rcWindow;

        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the client area.
        /// </summary>
        public RECT rcClient;

        /// <summary>
        /// The window styles. For a table of window styles, see CreateWindowEx.
        /// </summary>
        public WINDOWSTYLE dwStyle;

        /// <summary>
        /// The extended window styles. For a table of extended window styles, see CreateWindowEx.
        /// </summary>
        public WINDOWSTYLE_EX dwExStyle;

        /// <summary>
        /// The window status. If this member is WS_ACTIVECAPTION, the window is active. Otherwise, this member is zero.
        /// </summary>
        public DWORD dwWindowStatus;

        /// <summary>
        /// The width of the window border, in pixels.
        /// </summary>
        public UINT WindowBordersX;

        /// <summary>
        /// The height of the window border, in pixels.
        /// </summary>
        public UINT WindowBordersY;

        /// <summary>
        /// The window class atom (see RegisterClass).
        /// </summary>
        public ATOM WindowType;

        /// <summary>
        /// The Microsoft Windows version of the application that created the window.
        /// </summary>
        public WORD CreatorVersion;
    }

}
