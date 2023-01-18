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

        Focus,
        WindowMove,
        WindowResize,

        WindowModeChange,

        WindowDpiChange,

        MouseEnter,

        /// <summary>
        /// Signifies the event is of type <see cref="MouseMoveEventArgs"/>.
        /// </summary>
        MouseMove,

        // FIXME: Maybe merge up and down events and add a property to the event?
        MouseDown,
        MouseUp,

        Scroll,

        // FIXME: Maybe merge up and down events and add a property to the event?
        KeyDown,
        KeyUp,

        TextInput,
        TextEditing,

        FileDrop,

        ThemeChange,

        DisplayConnectionChanged,

        PowerStateChange,
    }
}
