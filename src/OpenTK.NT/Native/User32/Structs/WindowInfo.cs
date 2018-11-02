using System.Runtime.InteropServices;
using OpenToolkit.NT.Native.User32.Enums;
using ATOM = System.UInt16;
using DWORD = System.UInt32;
using UINT = System.UInt32;
using WORD = System.UInt16;

namespace OpenToolkit.NT.Native.User32.Structs
{
    /// <summary>
    /// Contains window information.
    /// </summary>
    public struct WindowInfo
    {
        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public DWORD Size;

        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the window.
        /// </summary>
        public Rect Window;

        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the client area.
        /// </summary>
        public Rect Client;

        /// <summary>
        /// The window styles. For a table of window styles, see CreateWindowEx.
        /// </summary>
        public WindowStyles Style;

        /// <summary>
        /// The extended window styles. For a table of extended window styles, see CreateWindowEx.
        /// </summary>
        public ExtendedWindowStyles ExtendedStyle;

        /// <summary>
        /// The window status. If this member is WS_ACTIVECAPTION, the window is active.
        /// Otherwise, this member is zero.
        /// </summary>
        public DWORD WindowStatus;

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

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<WindowInfo>();
    }
}
