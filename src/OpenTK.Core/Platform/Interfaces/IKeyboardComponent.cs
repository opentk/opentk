namespace OpenTK.Core.Platform
{
    /// <summary>
    /// PAL driver for global keyboard information.
    /// </summary>
    public interface IKeyboardComponent : IPalComponent
    {
        /// <summary>
        /// True if the driver supports keyboard layout functions.
        /// </summary>
        bool SupportsLayouts { get; }

        /// <summary>
        /// True if the driver supports input method editor functions.
        /// </summary>
        bool SupportsIme { get; }

        /// <summary>
        /// Get the active keyboard layout.
        /// </summary>
        /// <param name="handle">(optional) Handle to a window to query the layout for. Ignored on systems where keyboard layout is global.</param>
        /// <returns>A string which describes the active keyboard layout.</returns>
        /// <exception cref="PalNotImplementedException">Driver cannot query active keyboard layout.</exception>
        string GetActiveKeyboardLayout(WindowHandle handle = null);

        /// <summary>
        /// See list of possible keyboard layouts for this system.
        /// </summary>
        /// <returns>Array containing possible keyboard layouts.</returns>
        string[] GetAvailableKeyboardLayouts();

        /// <summary>
        /// Invoke input method editor.
        /// </summary>
        /// <param name="window">The window corresponding to this IME window.</param>
        void BeginIme(WindowHandle window);

        /// <summary>
        /// Set the rectangle to which the IME interface will appear relative to.
        /// </summary>
        /// <param name="window">The window corresponding to this IME window.</param>
        /// <param name="x">X coordinate of the rectangle in desktop coordinates.</param>
        /// <param name="y">Y coordinate of the rectangle in desktop coordinates.</param>
        /// <param name="width">Width of the rectangle in desktop units.</param>
        /// <param name="height">Height of the rectangle in desktop units.</param>
        void SetImeRectangle(WindowHandle window, int x, int y, int width, int height);

        /// <summary>
        /// Finish input method editor.
        /// </summary>
        /// <param name="window">The window corresponding to this IME window.</param>
        void EndIme(WindowHandle window);
    }
}
