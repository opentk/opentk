using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    public enum Key
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        Unknown = 0,

        // FIXME: Fix the numerical values of these enums??

        Backspace,
        Tab,
        Return,
        Escape,

        Space = ' ',

        D0 = '0',
        D1 = '1',
        D2 = '2',
        D3 = '3',
        D4 = '4',
        D5 = '5',
        D6 = '6',
        D7 = '7',
        D8 = '8',
        D9 = '9',

        A = 'A',
        B = 'B',
        C = 'C',
        D = 'D',
        E = 'E',
        F = 'F',
        G = 'G',
        H = 'H',
        I = 'I',
        J = 'J',
        K = 'K',
        L = 'L',
        M = 'M',
        N = 'N',
        O = 'O',
        P = 'P',
        Q = 'Q',
        R = 'R',
        S = 'S',
        T = 'T',
        U = 'U',
        V = 'V',
        W = 'W',
        X = 'X',
        Y = 'Y',
        Z = 'Z',

        LeftShift,
        RightShift,
        LeftControl,
        RightControl,
        // FIXME: AltGr?
        LeftAlt,
        RightAlt,
        LeftGUI,
        RightGUI,

        CapsLock,

        NumLock,
        Keypad0,
        Keypad1,
        Keypad2,
        Keypad3,
        Keypad4,
        Keypad5,
        Keypad6,
        Keypad7,
        Keypad8,
        Keypad9,
        KeypadDecimal,
        KeypadDivide,
        KeypadMultiply,
        KeypadSubtract,
        KeypadAdd,
        KeypadSeparator,
        KeypadEnter,
        KeypadEqual,

        PrintScreen,
        ScrollLock,
        PauseBreak,

        Insert,
        Delete,
        Home,
        End,
        PageUp,
        PageDown,

        LeftArrow,
        RightArrow,
        UpArrow,
        DownArrow,

        Application,

        // FIXME: Is this windows only?
        Help,

        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,
        F13,
        F14,
        F15,
        F16,
        F17,
        F18,
        F19,
        F20,
        F21,
        F22,
        F23,
        F24,
        F25,

        Å = 221,
        Ä = 222,

        Sleep,

        Plus,
        Comma,
        Minus,
        Period,

        // FIXME: Better names for these.
        OEM1,
        OEM2,
        OEM3,
        OEM4,
        OEM5,
        OEM6,
        OEM7,
        OEM8,
        // FIXME: What do we do here?
        // OEM3 = 192,
        // Tilde = 192,
        // Ö = 192,

        OEM102,

        PlayPause,
        NextTrack,
        PreviousTrack,
        Stop,
        Mute,
        VolumeUp,
        VolumeDown,


#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
