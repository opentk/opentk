namespace OpenTK.Platform
{
    // FIXME: Change name.

    /// <summary>
    /// The window border style.
    /// </summary>
    public enum WindowBorderStyle
    {
        /// <summary>
        /// Borderless window.
        /// </summary>
        Borderless,

        /// <summary>
        /// Non-resizeable window border.
        /// </summary>
        FixedBorder,

        /// <summary>
        /// Resizeable window border.
        /// </summary>
        ResizableBorder,

        /// <summary>
        /// A tool window.
        /// A tool window is a window does not appear in the taskbar and does not appear in the window swticher (ALT+TAB).
        /// </summary>
        ToolBox,
    }
}
