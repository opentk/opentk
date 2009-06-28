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
        private bool[] keys = new bool[Enum.GetValues(typeof(Key)).Length];
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
            for (int i = 0; i < keys.Length; i++)
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
        /// <summary>A key outside the known keys.</summary>
        Unknown = 0,

        // Modifiers
        /// <summary>The left shift key.</summary>
        ShiftLeft,
        /// <summary>The left shift key (equivalent to ShiftLeft).</summary>
        LShift = ShiftLeft,
        /// <summary>The right shift key.</summary>
        ShiftRight,
        /// <summary>The right shift key (equivalent to ShiftRight).</summary>
        RShift = ShiftRight,
        /// <summary>The left control key.</summary>
        ControlLeft,
        /// <summary>The left control key (equivalent to ControlLeft).</summary>
        LControl = ControlLeft,
        /// <summary>The right control key.</summary>
        ControlRight,
        /// <summary>The right control key (equivalent to ControlRight).</summary>
        RControl = ControlRight,
        /// <summary>The left alt key.</summary>
        AltLeft,
        /// <summary>The left alt key (equivalent to AltLeft.</summary>
        LAlt = AltLeft,
        /// <summary>The right alt key.</summary>
        AltRight,
        /// <summary>The right alt key (equivalent to AltRight).</summary>
        RAlt = AltRight,
        /// <summary>The left win key.</summary>
        WinLeft,
        /// <summary>The left win key (equivalent to WinLeft).</summary>
        LWin = WinLeft,
        /// <summary>The right win key.</summary>
        WinRight,
        /// <summary>The right win key (equivalent to WinRight).</summary>
        RWin = WinRight,
        /// <summary>The menu key.</summary>
        Menu,

        // Function keys (hopefully enough for most keyboards - mine has 26)
        // <keysymdef.h> on X11 reports up to 35 function keys.
        /// <summary>The F1 key.</summary>
        F1,
        /// <summary>The F2 key.</summary>
        F2,
        /// <summary>The F3 key.</summary>
        F3,
        /// <summary>The F4 key.</summary>
        F4,
        /// <summary>The F5 key.</summary>
        F5,
        /// <summary>The F6 key.</summary>
        F6,
        /// <summary>The F7 key.</summary>
        F7,
        /// <summary>The F8 key.</summary>
        F8,
        /// <summary>The F9 key.</summary>
        F9,
        /// <summary>The F10 key.</summary>
        F10,
        /// <summary>The F11 key.</summary>
        F11,
        /// <summary>The F12 key.</summary>
        F12,
        /// <summary>The F13 key.</summary>
        F13,
        /// <summary>The F14 key.</summary>
        F14,
        /// <summary>The F15 key.</summary>
        F15,
        /// <summary>The F16 key.</summary>
        F16,
        /// <summary>The F17 key.</summary>
        F17,
        /// <summary>The F18 key.</summary>
        F18,
        /// <summary>The F19 key.</summary>
        F19,
        /// <summary>The F20 key.</summary>
        F20,
        /// <summary>The F21 key.</summary>
        F21,
        /// <summary>The F22 key.</summary>
        F22,
        /// <summary>The F23 key.</summary>
        F23,
        /// <summary>The F24 key.</summary>
        F24,
        /// <summary>The F25 key.</summary>
        F25,
        /// <summary>The F26 key.</summary>
        F26,
        /// <summary>The F27 key.</summary>
        F27,
        /// <summary>The F28 key.</summary>
        F28,
        /// <summary>The F29 key.</summary>
        F29,
        /// <summary>The F30 key.</summary>
        F30,
        /// <summary>The F31 key.</summary>
        F31,
        /// <summary>The F32 key.</summary>
        F32,
        /// <summary>The F33 key.</summary>
        F33,
        /// <summary>The F34 key.</summary>
        F34,
        /// <summary>The F35 key.</summary>
        F35,

        // Direction arrows
        /// <summary>The up arrow key.</summary>
        Up,
        /// <summary>The down arrow key.</summary>
        Down,
        /// <summary>The left arrow key.</summary>
        Left,
        /// <summary>The right arrow key.</summary>
        Right,

        /// <summary>The enter key.</summary>
        Enter,
        /// <summary>The escape key.</summary>
        Escape,
        /// <summary>The space key.</summary>
        Space,
        /// <summary>The tab key.</summary>
        Tab,
        /// <summary>The backspace key.</summary>
        BackSpace,
        /// <summary>The backspace key (equivalent to BackSpace).</summary>
        Back = BackSpace,
        /// <summary>The insert key.</summary>
        Insert,
        /// <summary>The delete key.</summary>
        Delete,
        /// <summary>The page up key.</summary>
        PageUp,
        /// <summary>The page down key.</summary>
        PageDown,
        /// <summary>The home key.</summary>
        Home,
        /// <summary>The end key.</summary>
        End,
        /// <summary>The caps lock key.</summary>
        CapsLock,
        /// <summary>The scroll lock key.</summary>
        ScrollLock,
        /// <summary>The print screen key.</summary>
        PrintScreen,
        /// <summary>The pause key.</summary>
        Pause,
        /// <summary>The num lock key.</summary>
        NumLock,

        // Special keys
        /// <summary>The clear key (Keypad5 with NumLock disabled, on typical keyboards).</summary>
        Clear,
        /// <summary>The sleep key.</summary>
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
        /// <summary>The keypad 0 key.</summary>
        Keypad0,
        /// <summary>The keypad 1 key.</summary>
        Keypad1,
        /// <summary>The keypad 2 key.</summary>
        Keypad2,
        /// <summary>The keypad 3 key.</summary>
        Keypad3,
        /// <summary>The keypad 4 key.</summary>
        Keypad4,
        /// <summary>The keypad 5 key.</summary>
        Keypad5,
        /// <summary>The keypad 6 key.</summary>
        Keypad6,
        /// <summary>The keypad 7 key.</summary>
        Keypad7,
        /// <summary>The keypad 8 key.</summary>
        Keypad8,
        /// <summary>The keypad 9 key.</summary>
        Keypad9,
        /// <summary>The keypad divide key.</summary>
        KeypadDivide,
        /// <summary>The keypad multiply key.</summary>
        KeypadMultiply,
        /// <summary>The keypad subtract key.</summary>
        KeypadSubtract,
        /// <summary>The keypad minus key (equivalent to KeypadSubtract).</summary>
        KeypadMinus = KeypadSubtract,
        /// <summary>The keypad add key.</summary>
        KeypadAdd,
        /// <summary>The keypad plus key (equivalent to KeypadAdd).</summary>
        KeypadPlus = KeypadAdd,
        /// <summary>The keypad decimal key.</summary>
        KeypadDecimal,
        /// <summary>The keypad enter key.</summary>
        KeypadEnter,

        // Letters
        /// <summary>The A key.</summary>
        A,
        /// <summary>The B key.</summary>
        B,
        /// <summary>The C key.</summary>
        C,
        /// <summary>The D key.</summary>
        D,
        /// <summary>The E key.</summary>
        E,
        /// <summary>The F key.</summary>
        F,
        /// <summary>The G key.</summary>
        G,
        /// <summary>The H key.</summary>
        H,
        /// <summary>The I key.</summary>
        I,
        /// <summary>The J key.</summary>
        J,
        /// <summary>The K key.</summary>
        K,
        /// <summary>The L key.</summary>
        L,
        /// <summary>The M key.</summary>
        M,
        /// <summary>The N key.</summary>
        N,
        /// <summary>The O key.</summary>
        O,
        /// <summary>The P key.</summary>
        P,
        /// <summary>The Q key.</summary>
        Q,
        /// <summary>The R key.</summary>
        R,
        /// <summary>The S key.</summary>
        S,
        /// <summary>The T key.</summary>
        T,
        /// <summary>The U key.</summary>
        U,
        /// <summary>The V key.</summary>
        V,
        /// <summary>The W key.</summary>
        W,
        /// <summary>The X key.</summary>
        X,
        /// <summary>The Y key.</summary>
        Y,
        /// <summary>The Z key.</summary>
        Z,

        // Numbers
        /// <summary>The number 0 key.</summary>
        Number0,
        /// <summary>The number 1 key.</summary>
        Number1,
        /// <summary>The number 2 key.</summary>
        Number2,
        /// <summary>The number 3 key.</summary>
        Number3,
        /// <summary>The number 4 key.</summary>
        Number4,
        /// <summary>The number 5 key.</summary>
        Number5,
        /// <summary>The number 6 key.</summary>
        Number6,
        /// <summary>The number 7 key.</summary>
        Number7,
        /// <summary>The number 8 key.</summary>
        Number8,
        /// <summary>The number 9 key.</summary>
        Number9,

        // Symbols
        /// <summary>The tilde key.</summary>
        Tilde,
        /// <summary>The minus key.</summary>
        Minus,
        //Equal,
        /// <summary>The plus key.</summary>
        Plus,
        /// <summary>The left bracket key.</summary>
        BracketLeft,
        /// <summary>The left bracket key (equivalent to BracketLeft).</summary>
        LBracket = BracketLeft,
        /// <summary>The right bracket key.</summary>
        BracketRight,
        /// <summary>The right bracket key (equivalent to BracketRight).</summary>
        RBracket = BracketRight,
        /// <summary>The semicolon key.</summary>
        Semicolon,
        /// <summary>The quote key.</summary>
        Quote,
        /// <summary>The comma key.</summary>
        Comma,
        /// <summary>The period key.</summary>
        Period,
        /// <summary>The slash key.</summary>
        Slash,
        /// <summary>The backslash key.</summary>
        BackSlash,
    }

    #endregion
}