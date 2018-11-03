namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// The type of resizing requested by a <see cref="WindowMessage.Size"/>.
    /// </summary>
    public enum WindowMessageSizeType
    {
        /// <summary>
        /// The window has been resized, but neither the <see cref="Minimized"/>
        /// nor <see cref="Maximized"/> value applies.
        /// </summary>
        Restored = 0,

        /// <summary>
        /// The window has been minimized.
        /// </summary>
        Minimized = 1,

        /// <summary>
        /// The window has been maximized.
        /// </summary>
        Maximized = 2,

        /// <summary>
        /// Message is sent to all pop-up windows when some other window has been restored to its former size.
        /// </summary>
        MaxShow = 3,

        /// <summary>
        /// Message is sent to all pop-up windows when some other window is maximized.
        /// </summary>
        MaxHide = 4,
    }
}
