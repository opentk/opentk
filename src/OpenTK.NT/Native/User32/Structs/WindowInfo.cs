using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains window information.
    /// </summary>
    public struct WindowInfo
    {
        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public uint Size;

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
        public uint WindowStatus;

        /// <summary>
        /// The width of the window border, in pixels.
        /// </summary>
        public uint WindowBordersX;

        /// <summary>
        /// The height of the window border, in pixels.
        /// </summary>
        public uint WindowBordersY;

        /// <summary>
        /// The window class atom (see RegisterClass).
        /// </summary>
        public ushort WindowType;

        /// <summary>
        /// The Microsoft Windows version of the application that created the window.
        /// </summary>
        public ushort CreatorVersion;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<WindowInfo>();
    }
}
