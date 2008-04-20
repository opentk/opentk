#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;

using OpenTK.Input;
using System.Diagnostics;

#endregion

namespace OpenTK.Input
{
    /// <summary>
    /// Represents a keyboard device and provides methods to query its status. 
    /// </summary>
    public sealed class KeyboardDevice : IInputDevice
    {
        //private IKeyboard keyboard;
        private bool[] keys = new bool[(int)Key.MaxKeys];
        private string description;
        private int numKeys, numFKeys, numLeds;
        private IntPtr devID;
        private bool repeat;

        #region --- Constructors ---

        internal KeyboardDevice() { }

        #endregion

        #region --- IKeyboard members ---

        /// <summary>
        /// Gets a value indicating the status of the specified Key.
        /// </summary>
        /// <param name="key">The Key to check.</param>
        /// <returns>True if the Key is pressed, false otherwise.</returns>
        public bool this[Key key]
        {
            get { return keys[(int)key]; }
            internal set
            {
                if (keys[(int)key] != value || KeyRepeat)
                {
                    keys[(int)key] = value;

                    if (value && KeyDown != null)
                        KeyDown(this, key);
                    else if (!value && KeyUp != null)
                        KeyUp(this, key);
                }
            }
        }

        /// <summary>
        /// Gets an integer representing the number of keys on this KeyboardDevice.
        /// </summary>
        public int NumberOfKeys
        {
            get { return numKeys; }
            internal set { numKeys = value; }
        }

        /// <summary>
        /// Gets an integer representing the number of function keys (F-keys) on this KeyboardDevice.
        /// </summary>
        public int NumberOfFunctionKeys
        {
            get { return numFKeys; }
            internal set { numFKeys = value; }
        }

        /// <summary>
        /// Gets a value indicating the number of led indicators on this KeyboardDevice.
        /// </summary>
        public int NumberOfLeds
        {
            get { return numLeds; }
            internal set { numLeds = value; }
        }

        /// <summary>
        /// Gets an IntPtr representing a device dependent ID.
        /// </summary>
        public IntPtr DeviceID
        {
            get { return devID; }
            internal set { devID = value; }
        }

        #region public bool KeyRepeat

        /// <summary>
        /// Gets or sets a System.Boolean indicating key repeat status.
        /// </summary>
        /// <remarks>
        /// If KeyRepeat is true, multiple KeyDown events will be generated while a key is being held.
        /// Otherwise only one KeyDown event will be reported.
        /// <para>
        /// The rate of the generated KeyDown events is controlled by the Operating System. Usually,
        /// one KeyDown event will be reported, followed by a small (250-1000ms) pause and several
        /// more KeyDown events (6-30 events per second).
        /// </para>
        /// <para>
        /// Set to true to handle text input (where keyboard repeat is desirable), but set to false
        /// for game input.
        /// </para>
        /// </remarks>
        public bool KeyRepeat
        {
            get { return repeat; }
            set { repeat = value; }
        }

        #endregion

        #region public event KeyDownEvent KeyDown;

        /// <summary>
        /// Occurs when a key is pressed.
        /// </summary>
        public event KeyDownEvent KeyDown;

        #endregion

        #region public event KeyUpEvent KeyUp;

        /// <summary>
        /// Occurs when a key is released.
        /// </summary>
        public event KeyUpEvent KeyUp;

        #endregion

        #endregion

        #region --- IInputDevice Members ---

        public string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        public InputDeviceType DeviceType
        {
            get { return InputDeviceType.Keyboard; }
        }

        #endregion

        #region --- Public Methods ---

        /// <summary>Returns the hash code for this KeyboardDevice.</summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return (int)(numKeys ^ numFKeys ^ numLeds ^ devID.GetHashCode() ^ description.GetHashCode());
        }

        /// <summary>
        /// Returns a System.String representing this KeyboardDevice.
        /// </summary>
        /// <returns>A System.String representing this KeyboardDevice.</returns>
        public override string ToString()
        {
            //return base.ToString();
            return String.Format("ID: {0} ({1}). Keys: {2}, Function keys: {3}, Leds: {4}",
                DeviceID, Description, NumberOfKeys, NumberOfFunctionKeys, NumberOfLeds);
        }

        #endregion

        #region --- Internal Methods ---

        #region internal void ClearKeys()

        internal void ClearKeys()
        {
            for (int i = 0; i < (int)Key.MaxKeys; i++)
                if (this[(Key)i])       // Make sure KeyUp events are *not* raised for keys that are up, even if key repeat is on.
                    this[(Key)i] = false;
        }

        #endregion

        #endregion
    }

    public delegate void KeyDownEvent(KeyboardDevice sender, Key key);
    public delegate void KeyUpEvent(KeyboardDevice sender, Key key);

    #region public enum Key : int

    /// <summary>
    /// The available keyboard keys.
    /// </summary>
    public enum Key : int
    {
        // Modifiers
        ShiftLeft = 0,
        ShiftRight,
        ControlLeft,
        ControlRight,
        AltLeft,
        AltRight,
        WinLeft,
        WinRight,
        Menu,

        // Function keys (hopefully enough for most keyboards - mine has 26)
        // <keysymdef.h> on X11 reports up to 35 function keys.
        F1, F2, F3, F4,
        F5, F6, F7, F8,
        F9, F10, F11, F12,
        F13, F14, F15, F16,
        F17, F18, F19, F20,
        F21, F22, F23, F24,
        F25, F26, F27, F28,
        F29, F30, F31, F32,
        F33, F34, F35,

        // Direction arrows
        Up,
        Down,
        Left,
        Right,

        Enter,
        Escape,
        Space,
        Tab,
        BackSpace,
        Insert,
        Delete,
        PageUp,
        PageDown,
        Home,
        End,
        CapsLock,
        ScrollLock,
        PrintScreen,
        Pause,
        NumLock,

        // Special keys
        Clear,          // Keypad5 with NumLock off.
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
        VolumeDown,
        TrackPrevious,
        TrackNext,*/

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
        Tilde,
        Minus,
        //Equal,
        Plus,
        BracketLeft,
        BracketRight,
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