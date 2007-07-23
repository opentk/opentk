using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    static public class Key
    {
        static private bool[] keys = new bool[(int)Keys.MaxKeys];

        #region Modifiers

        static public bool LeftShift
        {
            get { return keys[(int)Keys.LeftShift]; }
            internal set { keys[(int)Keys.LeftShift] = value; }
        }

        static public bool RightShift
        {
            get { return keys[(int)Keys.RightShift]; }
            internal set { keys[(int)Keys.RightShift] = value; }
        }

        static public bool LeftControl
        {
            get { return keys[(int)Keys.LeftControl]; }
            internal set { keys[(int)Keys.LeftControl] = value; }
        }

        static public bool RightControl
        {
            get { return keys[(int)Keys.RightControl]; }
            internal set { keys[(int)Keys.RightControl] = value; }
        }

        static public bool LeftAlt
        {
            get { return keys[(int)Keys.LeftAlt]; }
            internal set { keys[(int)Keys.LeftAlt] = value; }
        }

        static public bool RightAlt
        {
            get { return keys[(int)Keys.RightAlt]; }
            internal set { keys[(int)Keys.RightAlt] = value; }
        }

        #endregion

        #region Function Keys

        static public bool F1
        {
            get { return keys[(int)Keys.F1]; }
            internal set { keys[(int)Keys.F1] = value; }
        }

        static public bool F2
        {
            get { return keys[(int)Keys.F2]; }
            internal set { keys[(int)Keys.F2] = value; }
        }

        static public bool F3
        {
            get { return keys[(int)Keys.F3]; }
            internal set { keys[(int)Keys.F3] = value; }
        }

        static public bool F4
        {
            get { return keys[(int)Keys.F4]; }
            internal set { keys[(int)Keys.F4] = value; }
        }

        static public bool F5
        {
            get { return keys[(int)Keys.F5]; }
            internal set { keys[(int)Keys.F5] = value; }
        }

        static public bool F6
        {
            get { return keys[(int)Keys.F6]; }
            internal set { keys[(int)Keys.F6] = value; }
        }

        static public bool F7
        {
            get { return keys[(int)Keys.F7]; }
            internal set { keys[(int)Keys.F7] = value; }
        }

        static public bool F8
        {
            get { return keys[(int)Keys.F8]; }
            internal set { keys[(int)Keys.F8] = value; }
        }

        static public bool F9
        {
            get { return keys[(int)Keys.F9]; }
            internal set { keys[(int)Keys.F9] = value; }
        }

        static public bool F10
        {
            get { return keys[(int)Keys.F10]; }
            internal set { keys[(int)Keys.F10] = value; }
        }

        static public bool F11
        {
            get { return keys[(int)Keys.F11]; }
            internal set { keys[(int)Keys.F11] = value; }
        }

        static public bool F12
        {
            get { return keys[(int)Keys.F12]; }
            internal set { keys[(int)Keys.F12] = value; }
        }

        static public bool F13
        {
            get { return keys[(int)Keys.F13]; }
            internal set { keys[(int)Keys.F13] = value; }
        }

        static public bool F14
        {
            get { return keys[(int)Keys.F14]; }
            internal set { keys[(int)Keys.F14] = value; }
        }

        static public bool F15
        {
            get { return keys[(int)Keys.F15]; }
            internal set { keys[(int)Keys.F15] = value; }
        }

        static public bool F16
        {
            get { return keys[(int)Keys.F16]; }
            internal set { keys[(int)Keys.F16] = value; }
        }

        #endregion

        static public bool Enter
        {
            get { return keys[(int)Keys.Enter]; }
            internal set { keys[(int)Keys.Enter] = value; }
        }

        static public bool Escape
        {
            get { return keys[(int)Keys.Escape]; }
            internal set { keys[(int)Keys.Escape] = value; } 
        }
    }

    enum Keys : int
    {
        // Modifiers
        LeftShift = 0,
        RightShift,
        LeftControl,
        RightControl,
        LeftAlt,
        RightAlt,

        // Function keys (hopefully enough for most keyboards - mine has 26)
        F1, F2, F3, F4,
        F5, F6, F7, F8,
        F9, F10, F11, F12,
        F13, F14, F15, F16,
        F17, F18, F19, F20,
        F21, F22, F23, F24,
        F25, F26, F27, F28,
        F29, F30, F31, F32,

        // Direction arrows
        Up,
        Down,
        Left,
        Right,

        // Special keys
        Enter,
        Escape,
        Space,
        Tab,
        Backspace,
        Insert,
        Delete,
        PageUp,
        PageDown,
        Home,
        End,
        CapsLock,

        // Keypad keys
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
        KeypadDivide,
        KeypadMultiply,
        KeypadSubtract,
        KeypadAdd,
        KeypadDecimal,
        KeypadEqual,
        KeypadEnter,

        // Letters
        A, B, C, D, E, F, G,
        H, I, J, K, L, M, N,
        O, P, Q, R, S, T, U,
        V, W, X, Y, Z,

        // Numbers
        Number0,
        Number1,
        Number2,
        Number3,
        Number4,
        Number5,
        Number6,
        Number7,
        Number8,
        Number9,

        // Symbols
        Minus,
        Equal,
        LeftBracket,
        RightBracket,
        Semicolon,
        QuotationMark,
        Comma,
        FullStop,
        Slash,
        BackSlash,

        MaxKeys
    }
}
