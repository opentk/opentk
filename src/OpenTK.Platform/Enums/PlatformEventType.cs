namespace OpenTK.Platform
{
    /// <summary>
    /// Enumeration of all OpenTK window events.
    /// </summary>
    public enum PlatformEventType
    {
        // FIXME: Give all of these numbers!

        /// <summary>
        /// A no operation event, for testing purposes.
        /// </summary>
        NoOperation = 0,

        Close,

        Focus,
        WindowMove,
        WindowResize,
        WindowFramebufferResize,

        WindowModeChange,

        WindowScaleChange,

        MouseEnter,

        /// <summary>
        /// Signifies the event is of type <see cref="MouseMoveEventArgs"/>.
        /// </summary>
        MouseMove,

        RawMouseMove,

        // FIXME: Maybe merge up and down events and add a property to the event?
        MouseDown,
        MouseUp,

        Scroll,

        // FIXME: Maybe merge up and down events and add a property to the event?
        KeyDown,
        KeyUp,

        TextInput,
        TextEditing,

        InputLanguageChanged,

        FileDrop,

        /// <summary>
        /// Is raised when the contents of the clipboard is changed.
        /// </summary>
        ClipboardUpdate,

        ThemeChange,

        DisplayConnectionChanged,

        PowerStateChange,
    }
}
