using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{

    /// <summary>
    /// Contains window information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowInfo
    {
        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public int Size;

        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the window.
        /// </summary>
        public RECT Window;

        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the client area.
        /// </summary>
        public RECT Client;

        /// <summary>
        /// The window styles. For a table of window styles, see CreateWindowEx.
        /// </summary>
        public WindowStyle Style;

        /// <summary>
        /// The extended window styles. For a table of extended window styles, see CreateWindowEx.
        /// </summary>
        public ExtendedWindowStyle ExStyle;

        /// <summary>
        /// The window status. If this member is WS_ACTIVECAPTION, the window is active. Otherwise, this member is zero.
        /// </summary>
        public int WindowStatus;

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
        public int WindowType;

        /// <summary>
        /// The Microsoft Windows version of the application that created the window.
        /// </summary>
        public short CreatorVersion;
    }

}
