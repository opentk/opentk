namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Enumeration of all OpenTK window events.
    /// </summary>
    public enum PlatformEventType
    {
        /// <summary>
        /// A no operation event, for testing purposes.
        /// </summary>
        NoOperation = 0,

        Close,

        MouseEnter,
        MouseMove,
        MouseDown,
        MouseUp,

        KeyDown,
        KeyUp,
        TextInput,
    }
}
