namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies a set of pre-defined values for special behavior in <see cref="User32.Window.SetWindowPos(
    /// System.IntPtr, SetWindowPosHwndEnum, int, int, int, int, SetWindowPosFlags)"/>.
    /// </summary>
    public enum SetWindowPosHwndEnum
    {
        /// <summary>
        /// Places the window above all non-topmost windows (that is, behind all topmost windows).
        /// This flag has no effect if the window is already a non-topmost window.
        /// </summary>
        NoTopmost = -2,

        /// <summary>
        /// Places the window above all non-topmost windows.
        /// The window maintains its topmost position even when it is deactivated.
        /// </summary>
        Topmost = -1,

        /// <summary>
        /// Places the window at the top of the Z order.
        /// </summary>
        Top = 0,

        /// <summary>
        /// Places the window at the bottom of the Z order. If the hWnd parameter identifies a topmost window,
        /// the window loses its topmost status and is placed at the bottom of all other windows.
        /// </summary>
        Bottom = 1,
    }
}
