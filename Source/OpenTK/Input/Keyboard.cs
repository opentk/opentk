#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;

#endregion

namespace OpenTK.Input
{
    public class Keyboard : IKeyboard
    {
        private IKeyboard keyboard;

        #region --- Constructors ---

        public Keyboard()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                keyboard = new OpenTK.Platform.Windows.WinRawKeyboard();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }
        }

        #endregion

        #region --- IKeyboard members ---

        public bool this[Keys k]
        {
            get { return keyboard[k]; }
            //set { keyboard[k] = value; }
        }

        #endregion

        #region --- IInputDevice Members ---

        public string Description
        {
            get { return keyboard.Description; }
        }

        public InputDeviceType DeviceType
        {
            get { return keyboard.DeviceType; }
        }

        #endregion
    }

    #region public enum Keys : int

    /// <summary>
    /// The available keyboard keys.
    /// </summary>
    public enum Keys : int
    {
        // Modifiers
        LeftShift = 0,
        RightShift,
        LeftControl,
        RightControl,
        LeftAlt,
        RightAlt,
        LeftApp,
        RightApp,
        Menu,

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
        PrintScreen,
        Pause,
        NumLock,

        // Special keys
        Sleep,
        /*LogOff,
        Help,
        Undo,
        Redo,
        New,
        Open,
        Close,
        Reply,
        Forward,
        Send,
        Spell,
        Save,
        Calculator,
        
        // Folders and applications
        Documents,
        Pictures,
        Music,
        MediaPlayer,
        Mail,
        Browser,
        Messenger,
        
        // Multimedia keys
        Mute,
        PlayPause,
        Stop,
        VolumeUp,
        VOlumeDown,
        PreviousTrack,
        NextTrack,*/

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
        //KeypadEnter,

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
        Tilde,
        Minus,
        //Equal,
        Plus,
        LeftBracket,
        RightBracket,
        Semicolon,
        Quote,
        Comma,
        Period,
        Slash,
        BackSlash,

        MaxKeys
    }

    #endregion
}