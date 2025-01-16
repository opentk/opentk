namespace OpenTK.Platform
{
    public enum Scancode
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1136 // Enum values should be on separate lines
#pragma warning disable SA1514 // Element documentation header should be preceded by blank line

        Unknown = 0,

        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z,

        D1, D2, D3, D4, D5, D6, D7, D8, D9, D0,

        Return,
        Escape,

        /// <summary> Delete. </summary>
        Backspace,
        Tab,
        Spacebar,
        // FIXME: What is "dash and underscore"
        /// <summary> Dash and Underscore. </summary>
        Dash,
        Equals,
        LeftBrace,
        RightBrace,
        // FIXME: On macos this is \ and £ it seems like...
        /// <summary> Pipe and Slash, NonUS. </summary>
        Pipe,
        SemiColon,
        // FIXME: Change name to something more understandable
        LeftApostrophe,
        GraveAccent,
        Comma,
        Period,
        // FIXME: Should this be ForwardSlash?
        QuestionMark,
        CapsLock,
        F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,
        F13, F14, F15, F16, F17, F18, F19, F20, F21, F22, F23, F24,
        // FIXME: SDL goes up to F24, should we also?

        PrintScreen,
        ScrollLock,
        Pause,
        Insert,
        Home,
        PageUp,
        Delete,
        End,
        PageDown,
        RightArrow,
        LeftArrow,
        DownArrow,
        UpArrow,
        NumLock,
        KeypadEnter,
        Keypad1, Keypad2, Keypad3, Keypad4, Keypad5, Keypad6, Keypad7, Keypad8, Keypad9, Keypad0,
        // FIXME: Rename this to KeypadDivide?
        KeypadForwardSlash,
        // FIXME: Should this be called decimal instead?
        KeypadPeriod,
        // FIXME: Rename these to be the operation instead of the symbol?
        KeypadStar,
        KeypadDash,
        KeypadPlus,
        KeypadEquals,
        KeypadComma,

        NonUSSlashBar,
        Application,

        International1,
        International2,
        International3,
        International4,
        International5,
        International6,
        // FIXME: SDL goes up to International9, should we also?

        LANG1,
        LANG2,
        LANG3,
        LANG4,
        LANG5,
        // FIXME: SDL goes up to LANG9, should we also?

        LeftControl,
        LeftShift,
        // LeftOption on macos
        LeftAlt,
        LeftGUI,

        RightControl,
        RightShift,
        // RightOption on macos
        RightAlt,
        RightGUI,

        SystemPowerDown,
        SystemSleep,
        SystemWakeUp,

        ScanNextTrack, ScanPreviousTrack,
        Stop, PlayPause, Mute,
        VolumeIncrement, VolumeDecrement,

#pragma warning restore SA1514 // Element documentation header should be preceded by blank line
#pragma warning restore SA1136 // Enum values should be on separate lines
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
