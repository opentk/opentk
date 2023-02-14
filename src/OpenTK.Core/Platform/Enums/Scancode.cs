using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
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

        /// <summary> Delete </summary>
        Backspace,
        Tab,
        Spacebar,
        // FIXME: What is "dash and underscore"
        /// <summary> Dash and Underscore. </summary>
        Dash,
        Equals,
        LeftBrace,
        RightBrace,
        /// <summary> Pipe and Slash, NonUS. </summary>
        Pipe,
        SemiColon,
        LeftApostrophe,
        GraveAccent,
        Comma,
        Period,
        QuestionMark,
        CapsLock,
        F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,

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
        KeypadForwardSlash,
        KeypadPeriod,
        KeypadStar,
        KeypadDash,
        KeypadPlus,

        NonUSSlashBar,
        Application,
        KeypadEquals,
        KeypadComma,

        International1,
        International2,
        International3,
        International4,
        International5,
        International6,

        LANG1,
        LANG2,
        LANG3,
        LANG4,
        LANG5,

        LeftControl,
        LeftShift,
        LeftAlt,
        LeftGUI,

        RightControl,
        RightShift,
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
