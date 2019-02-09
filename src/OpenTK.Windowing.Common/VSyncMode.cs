namespace OpenToolkit.Windowing
{
    /// <summary>
    /// Enumerates available VSync modes.
    /// </summary>
    public enum VSyncMode
    {
        /// <summary>
        /// Vsync disabled.
        /// </summary>
        Off = 0,

        /// <summary>
        /// VSync enabled.
        /// </summary>
        On,

        /// <summary>
        /// VSync enabled, unless framerate falls below one half of target framerate.
        /// If no target framerate is specified, this behaves exactly like <see cref="VSyncMode.On" />.
        /// </summary>
        Adaptive
    }
}