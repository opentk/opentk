namespace OpenTK.Platform
{
    /// <summary>
    /// An enumeration of OpenTK window modes.
    /// </summary>
    public enum WindowMode
    {
        /// <summary>
        /// Hidden mode hides the window completely from sight.
        /// </summary>
        Hidden,

        /// <summary>
        /// The window is displayed on the task bar but its contents are hidden.
        /// </summary>
        Minimized,

        /// <summary>
        /// The window is visible.
        /// </summary>
        Normal,

        /// <summary>
        /// The window covers the entire desktop area, except system trays.
        /// </summary>
        Maximized,

        /// <summary>
        /// Window covers the entire screen, as a window.
        /// </summary>
        WindowedFullscreen,

        /// <summary>
        /// The window takes exclusive ownership of the display.
        /// </summary>
        ExclusiveFullscreen
    }
}
