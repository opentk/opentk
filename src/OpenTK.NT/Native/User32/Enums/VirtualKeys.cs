namespace OpenTK.NT.Native
{
    public enum VirtualKeys : short
    {
        /*
         * Virtual Key, Standard Set
         */
        LButton = 0x01,
        RButton = 0x02,
        Cancel = 0x03,
        MButton = 0x04, /* NOT contiguous with L & RBUTTON */

        XButton1 = 0x05, /* NOT contiguous with L & RBUTTON */
        XButton2 = 0x06, /* NOT contiguous with L & RBUTTON */

        /*
         * 0x07 : unassigned
         */

        Back = 0x08,
        Tab = 0x09,

        /*
         * 0x0A - 0x0B : reserved
         */

        Clear = 0x0C,
        Return = 0x0D,

        Shift = 0x10,
        Control = 0x11,
        Menu = 0x12,
        Pause = 0x13,
        Capital = 0x14,

        Kana = 0x15,
        Hangeul = 0x15, /* old name - should be here for compatibility */
        Hangul = 0x15,
        Junja = 0x17,
        Final = 0x18,
        Hanja = 0x19,
        Kanji = 0x19,

        Escape = 0x1B,

        Convert = 0x1C,
        NonConvert = 0x1D,
        Accept = 0x1E,
        ModeChange = 0x1F,

        Space = 0x20,
        Prior = 0x21,
        Next = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        Snapshot = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,

        /*
         * 0 - 9 are the same as ASCII '0' - '9' (0x30 - 0x39)
         * 0x40 : unassigned
         * A - Z are the same as ASCII 'A' - 'Z' (0x41 - 0x5A)
         */

        LWin = 0x5B,
        RWin = 0x5C,
        Apps = 0x5D,

        /*
         * 0x5E : reserved
         */

        Sleep = 0x5F,

        Numpad0 = 0x60,
        Numpad1 = 0x61,
        Numpad2 = 0x62,
        Numpad3 = 0x63,
        Numpad4 = 0x64,
        Numpad5 = 0x65,
        Numpad6 = 0x66,
        Numpad7 = 0x67,
        Numpad8 = 0x68,
        Numpad9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Subtract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,

        /*
         * 0x88 - 0x8F : unassigned
         */

        NumLock = 0x90,
        Scroll = 0x91,

        /*
         * NEC PC-9800 kbd definitions
         */
        OemNecEqual = 0x92, // '=' key on numpad

        /*
         * Fujitsu/OASYS kbd definitions
         */
        OemFJJisho = 0x92, // 'Dictionary' key
        OemFJMasshou = 0x93, // 'Unregister word' key
        OemFJTouroku = 0x94, // 'Register word' key
        OemFJLoya = 0x95, // 'Left OYAYUBI' key
        OemFJRoya = 0x96, // 'Right OYAYUBI' key

        /*
         * 0x97 - 0x9F : unassigned
         */

        /*
         * L* & R* - left and right Alt, Ctrl and Shift virtual keys.
         * Used only as parameters to GetAsyncKeyState() and GetKeyState().
         * No other API or message will distinguish left and right keys in this way.
         */
        LShift = 0xA0,
        RShift = 0xA1,
        LControl = 0xA2,
        RControl = 0xA3,
        LMenu = 0xA4,
        RMenu = 0xA5,

        BrowserBack = 0xA6,
        BrowserForward = 0xA7,
        BrowserRefresh = 0xA8,
        BrowserStop = 0xA9,
        BrowserSearch = 0xAA,
        BrowserFavorites = 0xAB,
        BrowserHome = 0xAC,

        VolumeMute = 0xAD,
        VolumeDown = 0xAE,
        VolumeUp = 0xAF,
        MediaNextTrack = 0xB0,
        MediaPreviousTrack = 0xB1,
        MediaStop = 0xB2,
        MediaPlayPause = 0xB3,
        LaunchMail = 0xB4,
        LaunchMediaSelect = 0xB5,
        LaunchApp1 = 0xB6,
        LaunchApp2 = 0xB7,

        /*
         * 0xB8 - 0xB9 : reserved
         */

        Oem1 = 0xBA, // ';:' for US
        OemPlus = 0xBB, // '+' any country
        OemComma = 0xBC, // ',' any country
        OemMinus = 0xBD, // '-' any country
        OemPeriod = 0xBE, // '.' any country
        Oem2 = 0xBF, // '/?' for US
        Oem3 = 0xC0, // '`~' for US

        /*
         * 0xC1 - 0xD7 : reserved
         */

        /*
         * 0xD8 - 0xDA : unassigned
         */

        Oem4 = 0xDB, //  '[{' for US
        Oem5 = 0xDC, //  '\|' for US
        Oem6 = 0xDD, //  ']}' for US
        Oem7 = 0xDE, //  ''"' for US
        Oem8 = 0xDF,

        /*
         * 0xE0 : reserved
         */

        /*
         * Various extended or enhanced keyboards
         */
        OemAX = 0xE1, //  'AX' key on Japanese AX kbd
        Oem102 = 0xE2, //  "<>" or "\|" on RT 102-key kbd.
        IcoHelp = 0xE3, //  Help key on ICO
        Ico00 = 0xE4, //  00 key on ICO

        ProcessKey = 0xE5,

        IcoClear = 0xE6,

        Packet = 0xE7,

        /*
         * 0xE8 : unassigned
         */

        /*
         * Nokia/Ericsson definitions
         */
        OemReset = 0xE9,
        OemJump = 0xEA,
        OemPA1 = 0xEB,
        OemPA2 = 0xEC,
        OemPA3 = 0xED,
        OemWSCtrl = 0xEE,
        OemCUseL = 0xEF,
        OemAttn = 0xF0,
        OemFinish = 0xF1,
        OemCopy = 0xF2,
        OemAuto = 0xF3,
        OemEnlw = 0xF4,
        OemBacktab = 0xF5,

        Attn = 0xF6,
        CrSel = 0xF7,
        ExSel = 0xF8,
        ErEof = 0xF9,
        Play = 0xFA,
        Zoom = 0xFB,
        NoName = 0xFC,
        PA1 = 0xFD,
        OemClear = 0xFE,

        Last
    }
}
