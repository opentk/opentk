namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Lists all virtual keys.
    /// </summary>
    public enum VirtualKey : uint
    {
        /// <summary>
        /// Left mouse button.
        /// </summary>
        LButton = 0x01,

        /// <summary>
        /// Right mouse button.
        /// </summary>
        RButton = 0x02,

        /// <summary>
        /// Control-break processing.
        /// </summary>
        Cancel = 0x03,

        /// <summary>
        /// Middle mouse button (three-button mouse).<para/>
        /// Not contiguous with L and R Button.
        /// </summary>
        MButton = 0x04,

        /// <summary>
        /// X1 mouse button.
        /// Not contiguous with L and R Button.
        /// </summary>
        XButton1 = 0x05,

        /// <summary>
        /// X2 mouse button.
        /// Not contiguous with L and R Button.
        /// </summary>
        XButton2 = 0x06,

        /*
         * 0x07: Undefined
         */

        /// <summary>
        /// BACKSPACE key.
        /// </summary>
        Back = 0x08,

        /// <summary>
        /// TAB key.
        /// </summary>
        Tab = 0x09,

        /*
         * 0x0A - 0x0B: Reserved
         */

        /// <summary>
        /// CLEAR key.
        /// </summary>
        Clear = 0x0C,

        /// <summary>
        /// ENTER key.
        /// </summary>
        Return = 0x0D,

        /*
         * 0x0E - 0x0F: Undefined
         */

        /// <summary>
        /// SHIFT key.
        /// </summary>
        Shift = 0x10,

        /// <summary>
        /// CTRL key.
        /// </summary>
        Control = 0x11,

        /// <summary>
        /// ALT key.
        /// </summary>
        Menu = 0x12,

        /// <summary>
        /// PAUSE key.
        /// </summary>
        Pause = 0x13,

        /// <summary>
        /// CAPS LOCK key
        /// </summary>
        Capital = 0x14,

        /// <summary>
        /// IME Kana mode.
        /// </summary>
        Kana = 0x15,

        /// <summary>
        /// IME Hanguel mode (maintained for compatibility; use <see cref="Hangul"/>).
        /// </summary>
        Hangeul = 0x15,

        /// <summary>
        /// IME Hangul mode.
        /// </summary>
        Hangul = 0x15,

        /*
         * 0x16: Undefined
         */

        /// <summary>
        /// IME Junja mode
        /// </summary>
        Junja = 0x17,

        /// <summary>
        /// IME final mode.
        /// </summary>
        Final = 0x18,

        /// <summary>
        /// IME Hanja mode.
        /// </summary>
        Hanja = 0x19,

        /// <summary>
        /// IME Kanji mode.
        /// </summary>
        Kanji = 0x19,

        /*
         * 0x1A: Undefined
         */

        /// <summary>
        /// ESC key
        /// </summary>
        Escape = 0x1B,

        /// <summary>
        /// IME convert.
        /// </summary>
        Convert = 0x1C,

        /// <summary>
        /// IME nonconvert.
        /// </summary>
        NonConvert = 0x1D,

        /// <summary>
        /// IME accept.
        /// </summary>
        Accept = 0x1E,

        /// <summary>
        /// IME mode change request.
        /// </summary>
        ModeChange = 0x1F,

        /// <summary>
        /// SPACEBAR.
        /// </summary>
        Space = 0x20,

        /// <summary>
        /// PAGE UP key.
        /// </summary>
        Prior = 0x21,

        /// <summary>
        /// PAGE DOWN key.
        /// </summary>
        Next = 0x22,

        /// <summary>
        /// END key.
        /// </summary>
        End = 0x23,

        /// <summary>
        /// HOME key.
        /// </summary>
        Home = 0x24,

        /// <summary>
        /// LEFT ARROW key.
        /// </summary>
        Left = 0x25,

        /// <summary>
        /// UP ARROW key.
        /// </summary>
        Up = 0x26,

        /// <summary>
        /// RIGHT ARROW key.
        /// </summary>
        Right = 0x27,

        /// <summary>
        /// DOWN ARROW key.
        /// </summary>
        Down = 0x28,

        /// <summary>
        /// SELECT key.
        /// </summary>
        Select = 0x29,

        /// <summary>
        /// PRINT key.
        /// </summary>
        Print = 0x2A,

        /// <summary>
        /// EXECUTE key.
        /// </summary>
        Execute = 0x2B,

        /// <summary>
        /// PRINT SCREEN key.
        /// </summary>
        Snapshot = 0x2C,

        /// <summary>
        /// INS key.
        /// </summary>
        Insert = 0x2D,

        /// <summary>
        /// DEL key.
        /// </summary>
        Delete = 0x2E,

        /// <summary>
        /// HELP key.
        /// </summary>
        Help = 0x2F,

        /*
         * 0 - 9 are the same as ASCII '0' - '9' (0x30 - 0x39)
         * 0x40: Unassigned
         * A - Z are the same as ASCII 'A' - 'Z' (0x41 - 0x5A)
         */

        /// <summary>
        /// Left Windows key (Natural keyboard).
        /// </summary>
        LWin = 0x5B,

        /// <summary>
        /// Right Windows key (Natural keyboard).
        /// </summary>
        RWin = 0x5C,

        /// <summary>
        /// Applications key (Natural keyboard).
        /// </summary>
        Apps = 0x5D,

        /*
         * 0x5E: Reserved
         */

        /// <summary>
        /// Computer Sleep key.
        /// </summary>
        Sleep = 0x5F,

        /// <summary>
        /// Numeric keypad 0 key.
        /// </summary>
        Numpad0 = 0x60,

        /// <summary>
        /// Numeric keypad 1 key
        /// </summary>
        Numpad1 = 0x61,

        /// <summary>
        /// Numeric keypad 2 key
        /// </summary>
        Numpad2 = 0x62,

        /// <summary>
        /// Numeric keypad 3 key
        /// </summary>
        Numpad3 = 0x63,

        /// <summary>
        /// Numeric keypad 4 key
        /// </summary>
        Numpad4 = 0x64,

        /// <summary>
        /// Numeric keypad 5 key
        /// </summary>
        Numpad5 = 0x65,

        /// <summary>
        /// Numeric keypad 6 key
        /// </summary>
        Numpad6 = 0x66,

        /// <summary>
        /// Numeric keypad 7 key
        /// </summary>
        Numpad7 = 0x67,

        /// <summary>
        /// Numeric keypad 8 key
        /// </summary>
        Numpad8 = 0x68,

        /// <summary>
        /// Numeric keypad 9 key
        /// </summary>
        Numpad9 = 0x69,

        /// <summary>
        /// Multiply key.
        /// </summary>
        Multiply = 0x6A,

        /// <summary>
        /// Add key.
        /// </summary>
        Add = 0x6B,

        /// <summary>
        /// Separator key.
        /// </summary>
        Separator = 0x6C,

        /// <summary>
        /// Subtract key.
        /// </summary>
        Subtract = 0x6D,

        /// <summary>
        /// Decimal key.
        /// </summary>
        Decimal = 0x6E,

        /// <summary>
        /// Divide key.
        /// </summary>
        Divide = 0x6F,

        /// <summary>
        /// F1 key.
        /// </summary>
        F1 = 0x70,

        /// <summary>
        /// F2 key.
        /// </summary>
        F2 = 0x71,

        /// <summary>
        /// F3 key.
        /// </summary>
        F3 = 0x72,

        /// <summary>
        /// F4 key.
        /// </summary>
        F4 = 0x73,

        /// <summary>
        /// F5 key.
        /// </summary>
        F5 = 0x74,

        /// <summary>
        /// F6 key.
        /// </summary>
        F6 = 0x75,

        /// <summary>
        /// F7 key.
        /// </summary>
        F7 = 0x76,

        /// <summary>
        /// F8 key.
        /// </summary>
        F8 = 0x77,

        /// <summary>
        /// F9 key.
        /// </summary>
        F9 = 0x78,

        /// <summary>
        /// F10 key.
        /// </summary>
        F10 = 0x79,

        /// <summary>
        /// F11 key.
        /// </summary>
        F11 = 0x7A,

        /// <summary>
        /// F12 key.
        /// </summary>
        F12 = 0x7B,

        /// <summary>
        /// F13 key.
        /// </summary>
        F13 = 0x7C,

        /// <summary>
        /// F14 key.
        /// </summary>
        F14 = 0x7D,

        /// <summary>
        /// F15 key.
        /// </summary>
        F15 = 0x7E,

        /// <summary>
        /// F16 key.
        /// </summary>
        F16 = 0x7F,

        /// <summary>
        /// F17 key.
        /// </summary>
        F17 = 0x80,

        /// <summary>
        /// F18 key.
        /// </summary>
        F18 = 0x81,

        /// <summary>
        /// F19 key.
        /// </summary>
        F19 = 0x82,

        /// <summary>
        /// F20 key.
        /// </summary>
        F20 = 0x83,

        /// <summary>
        /// F21 key.
        /// </summary>
        F21 = 0x84,

        /// <summary>
        /// F22 key.
        /// </summary>
        F22 = 0x85,

        /// <summary>
        /// F23 key.
        /// </summary>
        F23 = 0x86,

        /// <summary>
        /// F24 key.
        /// </summary>
        F24 = 0x87,

        /*
         * 0x88 - 0x8F: Unassigned
         */

        /// <summary>
        /// NUM LOCK key.
        /// </summary>
        NumLock = 0x90,

        /// <summary>
        /// SCROLL LOCK key.
        /// </summary>
        Scroll = 0x91,

        /*
         * 0x92 - 0x96: OEM specific
         */

        /*
         * 0x97 - 0x9F: Unassigned
         */

        /*
         * L* & R* - left and right Alt, Ctrl and Shift virtual keys.
         * Used only as parameters to GetAsyncKeyState() and GetKeyState().
         * No other API or message will distinguish left and right keys in this way.
         */

        /// <summary>
        /// Left SHIFT key.
        /// </summary>
        LShift = 0xA0,

        /// <summary>
        /// Right SHIFT key.
        /// </summary>
        RShift = 0xA1,

        /// <summary>
        /// Left CONTROL key.
        /// </summary>
        LControl = 0xA2,

        /// <summary>
        /// Right CONTROL key.
        /// </summary>
        RControl = 0xA3,

        /// <summary>
        /// Left MENU key.
        /// </summary>
        LMenu = 0xA4,

        /// <summary>
        /// Right MENU key.
        /// </summary>
        RMenu = 0xA5,

        /// <summary>
        /// Browser Back key.
        /// </summary>
        BrowserBack = 0xA6,

        /// <summary>
        /// Browser Forward key
        /// </summary>
        BrowserForward = 0xA7,

        /// <summary>
        /// Browser Refresh key.
        /// </summary>
        BrowserRefresh = 0xA8,

        /// <summary>
        /// Browser Stop key.
        /// </summary>
        BrowserStop = 0xA9,

        /// <summary>
        /// Browser Search key.
        /// </summary>
        BrowserSearch = 0xAA,

        /// <summary>
        /// Browser Favorites key.
        /// </summary>
        BrowserFavorites = 0xAB,

        /// <summary>
        /// Browser Start and Home key.
        /// </summary>
        BrowserHome = 0xAC,

        /// <summary>
        /// Volume Mute key.
        /// </summary>
        VolumeMute = 0xAD,

        /// <summary>
        /// Volume Down key.
        /// </summary>
        VolumeDown = 0xAE,

        /// <summary>
        /// Volume Up key.
        /// </summary>
        VolumeUp = 0xAF,

        /// <summary>
        /// Next Track key.
        /// </summary>
        MediaNextTrack = 0xB0,

        /// <summary>
        /// Previous Track key.
        /// </summary>
        MediaPreviousTrack = 0xB1,

        /// <summary>
        /// Stop Media key.
        /// </summary>
        MediaStop = 0xB2,

        /// <summary>
        /// Play/Pause Media key.
        /// </summary>
        MediaPlayPause = 0xB3,

        /// <summary>
        /// Start Mail key.
        /// </summary>
        LaunchMail = 0xB4,

        /// <summary>
        /// Select Media key.
        /// </summary>
        LaunchMediaSelect = 0xB5,

        /// <summary>
        /// Start Application 1 key.
        /// </summary>
        LaunchApp1 = 0xB6,

        /// <summary>
        /// Start Application 2 key.
        /// </summary>
        LaunchApp2 = 0xB7,

        /*
         * 0xB8 - 0xB9 : reserved
         */

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ';:' key.
        /// </summary>
        Oem1 = 0xBA,

        /// <summary>
        /// For any country/region, the '+' key.
        /// </summary>
        OemPlus = 0xBB,

        /// <summary>
        /// For any country/region, the ',' key.
        /// </summary>
        OemComma = 0xBC,

        /// <summary>
        /// For any country/region, the '-' key.
        /// </summary>
        OemMinus = 0xBD,

        /// <summary>
        /// For any country/region, the '.' key.
        /// </summary>
        OemPeriod = 0xBE,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '/?' key.
        /// </summary>
        Oem2 = 0xBF,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '`~' key.
        /// </summary>
        Oem3 = 0xC0,

        /*
         * 0xC1 - 0xD7: Reserved
         */

        /*
         * 0xD8 - 0xDA: Unassigned
         */

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '[{' key
        /// </summary>
        Oem4 = 0xDB,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the '\|' key
        /// </summary>
        Oem5 = 0xDC,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the ']}' key
        /// </summary>
        Oem6 = 0xDD,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// For the US standard keyboard, the 'single-quote/double-quote' key
        /// </summary>
        Oem7 = 0xDE,

        /// <summary>
        /// Used for miscellaneous characters; it can vary by keyboard.
        /// </summary>
        Oem8 = 0xDF,

        /*
         * 0xE0: Reserved
         */

        /*
         * Various extended or enhanced keyboards
         */

        /// <summary>
        /// OEM specific.
        /// 'AX' key on Japanese AX keyboard.
        /// </summary>
        OemAX = 0xE1,

        /// <summary>
        /// Either the angle bracket key or the backslash key on the RT 102-key keyboard.
        /// </summary>
        Oem102 = 0xE2,

        /// <summary>
        /// OEM specific.
        /// Help key on ICO.
        /// </summary>
        IcoHelp = 0xE3,

        /// <summary>
        /// OEM specific.
        /// 00 key on ICO.
        /// </summary>
        Ico00 = 0xE4,

        /// <summary>
        /// IME PROCESS key.
        /// </summary>
        ProcessKey = 0xE5,

        /// <summary>
        /// OEM specific.
        /// Clear key on ICO.
        /// </summary>
        IcoClear = 0xE6,

        /// <summary>
        /// Used to pass Unicode characters as if they were keystrokes. The <see cref="Packet"/> key is
        /// the low word of a 32-bit Virtual Key value used for non-keyboard input methods.
        /// </summary>
        Packet = 0xE7,

        /*
         * 0xE8: Unassigned
         */

        /*
         * Nokia/Ericsson definitions
         */

        /// <summary>
        /// OEM specific Reset key.
        /// </summary>
        OemReset = 0xE9,

        /// <summary>
        /// OEM specific Jump key.
        /// </summary>
        OemJump = 0xEA,

        /// <summary>
        /// OEM specific PA1 key.
        /// </summary>
        OemPA1 = 0xEB,

        /// <summary>
        /// OEM specific PA2 key.
        /// </summary>
        OemPA2 = 0xEC,

        /// <summary>
        /// OEM specific PA3 key.
        /// </summary>
        OemPA3 = 0xED,

        /// <summary>
        /// OEM specific WSCtrl key.
        /// </summary>
        OemWSCtrl = 0xEE,

        /// <summary>
        /// OEM specific CUseL key.
        /// </summary>
        OemCUseL = 0xEF,

        /// <summary>
        /// OEM specific attn key.
        /// </summary>
        OemAttn = 0xF0,

        /// <summary>
        /// OEM specific Finish key.
        /// </summary>
        OemFinish = 0xF1,

        /// <summary>
        /// OEM specific Copy key.
        /// </summary>
        OemCopy = 0xF2,

        /// <summary>
        /// OEM specific Auto key.
        /// </summary>
        OemAuto = 0xF3,

        /// <summary>
        /// OEM specific Enlw key.
        /// </summary>
        OemEnlw = 0xF4,

        /// <summary>
        /// OEM specific Backtab key.
        /// </summary>
        OemBacktab = 0xF5,

        /// <summary>
        /// Attn key.
        /// </summary>
        Attn = 0xF6,

        /// <summary>
        /// CrSel key.
        /// </summary>
        CrSel = 0xF7,

        /// <summary>
        /// ExSel key.
        /// </summary>
        ExSel = 0xF8,

        /// <summary>
        /// Erase EOF key.
        /// </summary>
        ErEof = 0xF9,

        /// <summary>
        /// Play key.
        /// </summary>
        Play = 0xFA,

        /// <summary>
        /// Zoom key.
        /// </summary>
        Zoom = 0xFB,

        /// <summary>
        /// Reserved.
        /// </summary>
        NoName = 0xFC,

        /// <summary>
        /// PA1 key.
        /// </summary>
        PA1 = 0xFD,

        /// <summary>
        /// Clear key.
        /// </summary>
        OemClear = 0xFE,

        /// <summary>
        /// The highest possible value for virtual keys.
        /// </summary>
        Last = 0xFF,
    }
}
