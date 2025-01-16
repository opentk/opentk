namespace OpenTK.Platform.Native.SDL
{
    internal enum SDL_Scancode : int
    {
        SDL_SCANCODE_UNKNOWN = 0,

        /*
         *  \name Usage page 0x07
         *
         *  These values are from usage page 0x07 (USB keyboard page).
         */
        /* @{ */

        SDL_SCANCODE_A = 4,
        SDL_SCANCODE_B = 5,
        SDL_SCANCODE_C = 6,
        SDL_SCANCODE_D = 7,
        SDL_SCANCODE_E = 8,
        SDL_SCANCODE_F = 9,
        SDL_SCANCODE_G = 10,
        SDL_SCANCODE_H = 11,
        SDL_SCANCODE_I = 12,
        SDL_SCANCODE_J = 13,
        SDL_SCANCODE_K = 14,
        SDL_SCANCODE_L = 15,
        SDL_SCANCODE_M = 16,
        SDL_SCANCODE_N = 17,
        SDL_SCANCODE_O = 18,
        SDL_SCANCODE_P = 19,
        SDL_SCANCODE_Q = 20,
        SDL_SCANCODE_R = 21,
        SDL_SCANCODE_S = 22,
        SDL_SCANCODE_T = 23,
        SDL_SCANCODE_U = 24,
        SDL_SCANCODE_V = 25,
        SDL_SCANCODE_W = 26,
        SDL_SCANCODE_X = 27,
        SDL_SCANCODE_Y = 28,
        SDL_SCANCODE_Z = 29,

        SDL_SCANCODE_1 = 30,
        SDL_SCANCODE_2 = 31,
        SDL_SCANCODE_3 = 32,
        SDL_SCANCODE_4 = 33,
        SDL_SCANCODE_5 = 34,
        SDL_SCANCODE_6 = 35,
        SDL_SCANCODE_7 = 36,
        SDL_SCANCODE_8 = 37,
        SDL_SCANCODE_9 = 38,
        SDL_SCANCODE_0 = 39,

        SDL_SCANCODE_RETURN = 40,
        SDL_SCANCODE_ESCAPE = 41,
        SDL_SCANCODE_BACKSPACE = 42,
        SDL_SCANCODE_TAB = 43,
        SDL_SCANCODE_SPACE = 44,

        SDL_SCANCODE_MINUS = 45,
        SDL_SCANCODE_EQUALS = 46,
        SDL_SCANCODE_LEFTBRACKET = 47,
        SDL_SCANCODE_RIGHTBRACKET = 48,
        SDL_SCANCODE_BACKSLASH = 49, /* Located at the lower left of the return
                                  *   key on ISO keyboards and at the right end
                                  *   of the QWERTY row on ANSI keyboards.
                                  *   Produces REVERSE SOLIDUS (backslash) and
                                  *   VERTICAL LINE in a US layout, REVERSE
                                  *   SOLIDUS and VERTICAL LINE in a UK Mac
                                  *   layout, NUMBER SIGN and TILDE in a UK
                                  *   Windows layout, DOLLAR SIGN and POUND SIGN
                                  *   in a Swiss German layout, NUMBER SIGN and
                                  *   APOSTROPHE in a German layout, GRAVE
                                  *   ACCENT and POUND SIGN in a French Mac
                                  *   layout, and ASTERISK and MICRO SIGN in a
                                  *   French Windows layout.
                                  */
        SDL_SCANCODE_NONUSHASH = 50, /* ISO USB keyboards actually use this code
                                  *   instead of 49 for the same key, but all
                                  *   OSes I've seen treat the two codes
                                  *   identically. So, as an implementor, unless
                                  *   your keyboard generates both of those
                                  *   codes and your OS treats them differently,
                                  *   you should generate SDL_SCANCODE_BACKSLASH
                                  *   instead of this code. As a user, you
                                  *   should not rely on this code because SDL
                                  *   will never generate it with most (all?)
                                  *   keyboards.
                                  */
        SDL_SCANCODE_SEMICOLON = 51,
        SDL_SCANCODE_APOSTROPHE = 52,
        SDL_SCANCODE_GRAVE = 53, /* Located in the top left corner (on both ANSI
                              *   and ISO keyboards). Produces GRAVE ACCENT and
                              *   TILDE in a US Windows layout and in US and UK
                              *   Mac layouts on ANSI keyboards, GRAVE ACCENT
                              *   and NOT SIGN in a UK Windows layout, SECTION
                              *   SIGN and PLUS-MINUS SIGN in US and UK Mac
                              *   layouts on ISO keyboards, SECTION SIGN and
                              *   DEGREE SIGN in a Swiss German layout (Mac:
                              *   only on ISO keyboards), CIRCUMFLEX ACCENT and
                              *   DEGREE SIGN in a German layout (Mac: only on
                              *   ISO keyboards), SUPERSCRIPT TWO and TILDE in a
                              *   French Windows layout, COMMERCIAL AT and
                              *   NUMBER SIGN in a French Mac layout on ISO
                              *   keyboards, and LESS-THAN SIGN and GREATER-THAN
                              *   SIGN in a Swiss German, German, or French Mac
                              *   layout on ANSI keyboards.
                              */
        SDL_SCANCODE_COMMA = 54,
        SDL_SCANCODE_PERIOD = 55,
        SDL_SCANCODE_SLASH = 56,

        SDL_SCANCODE_CAPSLOCK = 57,

        SDL_SCANCODE_F1 = 58,
        SDL_SCANCODE_F2 = 59,
        SDL_SCANCODE_F3 = 60,
        SDL_SCANCODE_F4 = 61,
        SDL_SCANCODE_F5 = 62,
        SDL_SCANCODE_F6 = 63,
        SDL_SCANCODE_F7 = 64,
        SDL_SCANCODE_F8 = 65,
        SDL_SCANCODE_F9 = 66,
        SDL_SCANCODE_F10 = 67,
        SDL_SCANCODE_F11 = 68,
        SDL_SCANCODE_F12 = 69,

        SDL_SCANCODE_PRINTSCREEN = 70,
        SDL_SCANCODE_SCROLLLOCK = 71,
        SDL_SCANCODE_PAUSE = 72,
        SDL_SCANCODE_INSERT = 73, /* insert on PC, help on some Mac keyboards (but
                                   does send code 73, not 117) */
        SDL_SCANCODE_HOME = 74,
        SDL_SCANCODE_PAGEUP = 75,
        SDL_SCANCODE_DELETE = 76,
        SDL_SCANCODE_END = 77,
        SDL_SCANCODE_PAGEDOWN = 78,
        SDL_SCANCODE_RIGHT = 79,
        SDL_SCANCODE_LEFT = 80,
        SDL_SCANCODE_DOWN = 81,
        SDL_SCANCODE_UP = 82,

        SDL_SCANCODE_NUMLOCKCLEAR = 83, /* num lock on PC, clear on Mac keyboards
                                     */
        SDL_SCANCODE_KP_DIVIDE = 84,
        SDL_SCANCODE_KP_MULTIPLY = 85,
        SDL_SCANCODE_KP_MINUS = 86,
        SDL_SCANCODE_KP_PLUS = 87,
        SDL_SCANCODE_KP_ENTER = 88,
        SDL_SCANCODE_KP_1 = 89,
        SDL_SCANCODE_KP_2 = 90,
        SDL_SCANCODE_KP_3 = 91,
        SDL_SCANCODE_KP_4 = 92,
        SDL_SCANCODE_KP_5 = 93,
        SDL_SCANCODE_KP_6 = 94,
        SDL_SCANCODE_KP_7 = 95,
        SDL_SCANCODE_KP_8 = 96,
        SDL_SCANCODE_KP_9 = 97,
        SDL_SCANCODE_KP_0 = 98,
        SDL_SCANCODE_KP_PERIOD = 99,

        SDL_SCANCODE_NONUSBACKSLASH = 100, /* This is the additional key that ISO
                                        *   keyboards have over ANSI ones,
                                        *   located between left shift and Y.
                                        *   Produces GRAVE ACCENT and TILDE in a
                                        *   US or UK Mac layout, REVERSE SOLIDUS
                                        *   (backslash) and VERTICAL LINE in a
                                        *   US or UK Windows layout, and
                                        *   LESS-THAN SIGN and GREATER-THAN SIGN
                                        *   in a Swiss German, German, or French
                                        *   layout. */
        SDL_SCANCODE_APPLICATION = 101, /* windows contextual menu, compose */
        SDL_SCANCODE_POWER = 102, /* The USB document says this is a status flag,
                               *   not a physical key - but some Mac keyboards
                               *   do have a power key. */
        SDL_SCANCODE_KP_EQUALS = 103,
        SDL_SCANCODE_F13 = 104,
        SDL_SCANCODE_F14 = 105,
        SDL_SCANCODE_F15 = 106,
        SDL_SCANCODE_F16 = 107,
        SDL_SCANCODE_F17 = 108,
        SDL_SCANCODE_F18 = 109,
        SDL_SCANCODE_F19 = 110,
        SDL_SCANCODE_F20 = 111,
        SDL_SCANCODE_F21 = 112,
        SDL_SCANCODE_F22 = 113,
        SDL_SCANCODE_F23 = 114,
        SDL_SCANCODE_F24 = 115,
        SDL_SCANCODE_EXECUTE = 116,
        SDL_SCANCODE_HELP = 117,    /* AL Integrated Help Center */
        SDL_SCANCODE_MENU = 118,    /* Menu (show menu) */
        SDL_SCANCODE_SELECT = 119,
        SDL_SCANCODE_STOP = 120,    /* AC Stop */
        SDL_SCANCODE_AGAIN = 121,   /* AC Redo/Repeat */
        SDL_SCANCODE_UNDO = 122,    /* AC Undo */
        SDL_SCANCODE_CUT = 123,     /* AC Cut */
        SDL_SCANCODE_COPY = 124,    /* AC Copy */
        SDL_SCANCODE_PASTE = 125,   /* AC Paste */
        SDL_SCANCODE_FIND = 126,    /* AC Find */
        SDL_SCANCODE_MUTE = 127,
        SDL_SCANCODE_VOLUMEUP = 128,
        SDL_SCANCODE_VOLUMEDOWN = 129,
        /* not sure whether there's a reason to enable these */
        /*     SDL_SCANCODE_LOCKINGCAPSLOCK = 130,  */
        /*     SDL_SCANCODE_LOCKINGNUMLOCK = 131, */
        /*     SDL_SCANCODE_LOCKINGSCROLLLOCK = 132, */
        SDL_SCANCODE_KP_COMMA = 133,
        SDL_SCANCODE_KP_EQUALSAS400 = 134,

        SDL_SCANCODE_INTERNATIONAL1 = 135, /* used on Asian keyboards, see
                                            footnotes in USB doc */
        SDL_SCANCODE_INTERNATIONAL2 = 136,
        SDL_SCANCODE_INTERNATIONAL3 = 137, /* Yen */
        SDL_SCANCODE_INTERNATIONAL4 = 138,
        SDL_SCANCODE_INTERNATIONAL5 = 139,
        SDL_SCANCODE_INTERNATIONAL6 = 140,
        SDL_SCANCODE_INTERNATIONAL7 = 141,
        SDL_SCANCODE_INTERNATIONAL8 = 142,
        SDL_SCANCODE_INTERNATIONAL9 = 143,
        SDL_SCANCODE_LANG1 = 144, /* Hangul/English toggle */
        SDL_SCANCODE_LANG2 = 145, /* Hanja conversion */
        SDL_SCANCODE_LANG3 = 146, /* Katakana */
        SDL_SCANCODE_LANG4 = 147, /* Hiragana */
        SDL_SCANCODE_LANG5 = 148, /* Zenkaku/Hankaku */
        SDL_SCANCODE_LANG6 = 149, /* reserved */
        SDL_SCANCODE_LANG7 = 150, /* reserved */
        SDL_SCANCODE_LANG8 = 151, /* reserved */
        SDL_SCANCODE_LANG9 = 152, /* reserved */

        SDL_SCANCODE_ALTERASE = 153,    /* Erase-Eaze */
        SDL_SCANCODE_SYSREQ = 154,
        SDL_SCANCODE_CANCEL = 155,      /* AC Cancel */
        SDL_SCANCODE_CLEAR = 156,
        SDL_SCANCODE_PRIOR = 157,
        SDL_SCANCODE_RETURN2 = 158,
        SDL_SCANCODE_SEPARATOR = 159,
        SDL_SCANCODE_OUT = 160,
        SDL_SCANCODE_OPER = 161,
        SDL_SCANCODE_CLEARAGAIN = 162,
        SDL_SCANCODE_CRSEL = 163,
        SDL_SCANCODE_EXSEL = 164,

        SDL_SCANCODE_KP_00 = 176,
        SDL_SCANCODE_KP_000 = 177,
        SDL_SCANCODE_THOUSANDSSEPARATOR = 178,
        SDL_SCANCODE_DECIMALSEPARATOR = 179,
        SDL_SCANCODE_CURRENCYUNIT = 180,
        SDL_SCANCODE_CURRENCYSUBUNIT = 181,
        SDL_SCANCODE_KP_LEFTPAREN = 182,
        SDL_SCANCODE_KP_RIGHTPAREN = 183,
        SDL_SCANCODE_KP_LEFTBRACE = 184,
        SDL_SCANCODE_KP_RIGHTBRACE = 185,
        SDL_SCANCODE_KP_TAB = 186,
        SDL_SCANCODE_KP_BACKSPACE = 187,
        SDL_SCANCODE_KP_A = 188,
        SDL_SCANCODE_KP_B = 189,
        SDL_SCANCODE_KP_C = 190,
        SDL_SCANCODE_KP_D = 191,
        SDL_SCANCODE_KP_E = 192,
        SDL_SCANCODE_KP_F = 193,
        SDL_SCANCODE_KP_XOR = 194,
        SDL_SCANCODE_KP_POWER = 195,
        SDL_SCANCODE_KP_PERCENT = 196,
        SDL_SCANCODE_KP_LESS = 197,
        SDL_SCANCODE_KP_GREATER = 198,
        SDL_SCANCODE_KP_AMPERSAND = 199,
        SDL_SCANCODE_KP_DBLAMPERSAND = 200,
        SDL_SCANCODE_KP_VERTICALBAR = 201,
        SDL_SCANCODE_KP_DBLVERTICALBAR = 202,
        SDL_SCANCODE_KP_COLON = 203,
        SDL_SCANCODE_KP_HASH = 204,
        SDL_SCANCODE_KP_SPACE = 205,
        SDL_SCANCODE_KP_AT = 206,
        SDL_SCANCODE_KP_EXCLAM = 207,
        SDL_SCANCODE_KP_MEMSTORE = 208,
        SDL_SCANCODE_KP_MEMRECALL = 209,
        SDL_SCANCODE_KP_MEMCLEAR = 210,
        SDL_SCANCODE_KP_MEMADD = 211,
        SDL_SCANCODE_KP_MEMSUBTRACT = 212,
        SDL_SCANCODE_KP_MEMMULTIPLY = 213,
        SDL_SCANCODE_KP_MEMDIVIDE = 214,
        SDL_SCANCODE_KP_PLUSMINUS = 215,
        SDL_SCANCODE_KP_CLEAR = 216,
        SDL_SCANCODE_KP_CLEARENTRY = 217,
        SDL_SCANCODE_KP_BINARY = 218,
        SDL_SCANCODE_KP_OCTAL = 219,
        SDL_SCANCODE_KP_DECIMAL = 220,
        SDL_SCANCODE_KP_HEXADECIMAL = 221,

        SDL_SCANCODE_LCTRL = 224,
        SDL_SCANCODE_LSHIFT = 225,
        SDL_SCANCODE_LALT = 226, /* alt, option */
        SDL_SCANCODE_LGUI = 227, /* windows, command (apple), meta */
        SDL_SCANCODE_RCTRL = 228,
        SDL_SCANCODE_RSHIFT = 229,
        SDL_SCANCODE_RALT = 230, /* alt gr, option */
        SDL_SCANCODE_RGUI = 231, /* windows, command (apple), meta */

        SDL_SCANCODE_MODE = 257,    /* I'm not sure if this is really not covered
                                     *   by any of the above, but since there's a
                                     *   special KMOD_MODE for it I'm adding it here
                                     */

        /* @} *//* Usage page 0x07 */

        /*
         *  \name Usage page 0x0C
         *
         *  These values are mapped from usage page 0x0C (USB consumer page).
         *  See https://usb.org/sites/default/files/hut1_2.pdf
         *
         *  There are way more keys in the spec than we can represent in the
         *  current scancode range, so pick the ones that commonly come up in
         *  real world usage.
         */
        /* @{ */

        SDL_SCANCODE_AUDIONEXT = 258,
        SDL_SCANCODE_AUDIOPREV = 259,
        SDL_SCANCODE_AUDIOSTOP = 260,
        SDL_SCANCODE_AUDIOPLAY = 261,
        SDL_SCANCODE_AUDIOMUTE = 262,
        SDL_SCANCODE_MEDIASELECT = 263,
        SDL_SCANCODE_WWW = 264,             /* AL Internet Browser */
        SDL_SCANCODE_MAIL = 265,
        SDL_SCANCODE_CALCULATOR = 266,      /* AL Calculator */
        SDL_SCANCODE_COMPUTER = 267,
        SDL_SCANCODE_AC_SEARCH = 268,       /* AC Search */
        SDL_SCANCODE_AC_HOME = 269,         /* AC Home */
        SDL_SCANCODE_AC_BACK = 270,         /* AC Back */
        SDL_SCANCODE_AC_FORWARD = 271,      /* AC Forward */
        SDL_SCANCODE_AC_STOP = 272,         /* AC Stop */
        SDL_SCANCODE_AC_REFRESH = 273,      /* AC Refresh */
        SDL_SCANCODE_AC_BOOKMARKS = 274,    /* AC Bookmarks */

        /* @} *//* Usage page 0x0C */

        /*
         *  \name Walther keys
         *
         *  These are values that Christian Walther added (for mac keyboard?).
         */
        /* @{ */

        SDL_SCANCODE_BRIGHTNESSDOWN = 275,
        SDL_SCANCODE_BRIGHTNESSUP = 276,
        SDL_SCANCODE_DISPLAYSWITCH = 277, /* display mirroring/dual display
                                           switch, video mode switch */
        SDL_SCANCODE_KBDILLUMTOGGLE = 278,
        SDL_SCANCODE_KBDILLUMDOWN = 279,
        SDL_SCANCODE_KBDILLUMUP = 280,
        SDL_SCANCODE_EJECT = 281,
        SDL_SCANCODE_SLEEP = 282,           /* SC System Sleep */

        SDL_SCANCODE_APP1 = 283,
        SDL_SCANCODE_APP2 = 284,

        /* @} *//* Walther keys */

        /*
         *  \name Usage page 0x0C (additional media keys)
         *
         *  These values are mapped from usage page 0x0C (USB consumer page).
         */
        /* @{ */

        SDL_SCANCODE_AUDIOREWIND = 285,
        SDL_SCANCODE_AUDIOFASTFORWARD = 286,

        /* @} *//* Usage page 0x0C (additional media keys) */

        /*
         *  \name Mobile keys
         *
         *  These are values that are often used on mobile phones.
         */
        /* @{ */

        SDL_SCANCODE_SOFTLEFT = 287, /* Usually situated below the display on phones and
                                      used as a multi-function feature key for selecting
                                      a software defined function shown on the bottom left
                                      of the display. */
        SDL_SCANCODE_SOFTRIGHT = 288, /* Usually situated below the display on phones and
                                       used as a multi-function feature key for selecting
                                       a software defined function shown on the bottom right
                                       of the display. */
        SDL_SCANCODE_CALL = 289, /* Used for accepting phone calls. */
        SDL_SCANCODE_ENDCALL = 290, /* Used for rejecting phone calls. */

        /* @} *//* Mobile keys */

        /* Add any other keys here. */

        SDL_NUM_SCANCODES = 512 /* not a key, just marks the number of scancodes
                                 for array bounds */
    }

    internal enum SDL_Keycode : int
    {
        SDLK_UNKNOWN = 0,

        SDLK_RETURN = '\r',
        SDLK_ESCAPE = '\x1B',
        SDLK_BACKSPACE = '\b',
        SDLK_TAB = '\t',
        SDLK_SPACE = ' ',
        SDLK_EXCLAIM = '!',
        SDLK_QUOTEDBL = '"',
        SDLK_HASH = '#',
        SDLK_PERCENT = '%',
        SDLK_DOLLAR = '$',
        SDLK_AMPERSAND = '&',
        SDLK_QUOTE = '\'',
        SDLK_LEFTPAREN = '(',
        SDLK_RIGHTPAREN = ')',
        SDLK_ASTERISK = '*',
        SDLK_PLUS = '+',
        SDLK_COMMA = ',',
        SDLK_MINUS = '-',
        SDLK_PERIOD = '.',
        SDLK_SLASH = '/',
        SDLK_0 = '0',
        SDLK_1 = '1',
        SDLK_2 = '2',
        SDLK_3 = '3',
        SDLK_4 = '4',
        SDLK_5 = '5',
        SDLK_6 = '6',
        SDLK_7 = '7',
        SDLK_8 = '8',
        SDLK_9 = '9',
        SDLK_COLON = ':',
        SDLK_SEMICOLON = ';',
        SDLK_LESS = '<',
        SDLK_EQUALS = '=',
        SDLK_GREATER = '>',
        SDLK_QUESTION = '?',
        SDLK_AT = '@',

        /*
           Skip uppercase letters
         */

        SDLK_LEFTBRACKET = '[',
        SDLK_BACKSLASH = '\\',
        SDLK_RIGHTBRACKET = ']',
        SDLK_CARET = '^',
        SDLK_UNDERSCORE = '_',
        SDLK_BACKQUOTE = '`',
        SDLK_a = 'a',
        SDLK_b = 'b',
        SDLK_c = 'c',
        SDLK_d = 'd',
        SDLK_e = 'e',
        SDLK_f = 'f',
        SDLK_g = 'g',
        SDLK_h = 'h',
        SDLK_i = 'i',
        SDLK_j = 'j',
        SDLK_k = 'k',
        SDLK_l = 'l',
        SDLK_m = 'm',
        SDLK_n = 'n',
        SDLK_o = 'o',
        SDLK_p = 'p',
        SDLK_q = 'q',
        SDLK_r = 'r',
        SDLK_s = 's',
        SDLK_t = 't',
        SDLK_u = 'u',
        SDLK_v = 'v',
        SDLK_w = 'w',
        SDLK_x = 'x',
        SDLK_y = 'y',
        SDLK_z = 'z',

        SDLK_CAPSLOCK = SDL_Scancode.SDL_SCANCODE_CAPSLOCK | (1 << 30),

        SDLK_F1 = SDL_Scancode.SDL_SCANCODE_F1 | (1 << 30),
        SDLK_F2 = SDL_Scancode.SDL_SCANCODE_F2 | (1 << 30),
        SDLK_F3 = SDL_Scancode.SDL_SCANCODE_F3 | (1 << 30),
        SDLK_F4 = SDL_Scancode.SDL_SCANCODE_F4 | (1 << 30),
        SDLK_F5 = SDL_Scancode.SDL_SCANCODE_F5 | (1 << 30),
        SDLK_F6 = SDL_Scancode.SDL_SCANCODE_F6 | (1 << 30),
        SDLK_F7 = SDL_Scancode.SDL_SCANCODE_F7 | (1 << 30),
        SDLK_F8 = SDL_Scancode.SDL_SCANCODE_F8 | (1 << 30),
        SDLK_F9 = SDL_Scancode.SDL_SCANCODE_F9 | (1 << 30),
        SDLK_F10 = SDL_Scancode.SDL_SCANCODE_F10 | (1 << 30),
        SDLK_F11 = SDL_Scancode.SDL_SCANCODE_F11 | (1 << 30),
        SDLK_F12 = SDL_Scancode.SDL_SCANCODE_F12 | (1 << 30),

        SDLK_PRINTSCREEN = SDL_Scancode.SDL_SCANCODE_PRINTSCREEN | (1 << 30),
        SDLK_SCROLLLOCK = SDL_Scancode.SDL_SCANCODE_SCROLLLOCK | (1 << 30),
        SDLK_PAUSE = SDL_Scancode.SDL_SCANCODE_PAUSE | (1 << 30),
        SDLK_INSERT = SDL_Scancode.SDL_SCANCODE_INSERT | (1 << 30),
        SDLK_HOME = SDL_Scancode.SDL_SCANCODE_HOME | (1 << 30),
        SDLK_PAGEUP = SDL_Scancode.SDL_SCANCODE_PAGEUP | (1 << 30),
        SDLK_DELETE = '\x7F',
        SDLK_END = SDL_Scancode.SDL_SCANCODE_END | (1 << 30),
        SDLK_PAGEDOWN = SDL_Scancode.SDL_SCANCODE_PAGEDOWN | (1 << 30),
        SDLK_RIGHT = SDL_Scancode.SDL_SCANCODE_RIGHT | (1 << 30),
        SDLK_LEFT = SDL_Scancode.SDL_SCANCODE_LEFT | (1 << 30),
        SDLK_DOWN = SDL_Scancode.SDL_SCANCODE_DOWN | (1 << 30),
        SDLK_UP = SDL_Scancode.SDL_SCANCODE_UP | (1 << 30),

        SDLK_NUMLOCKCLEAR = SDL_Scancode.SDL_SCANCODE_NUMLOCKCLEAR | (1 << 30),
        SDLK_KP_DIVIDE = SDL_Scancode.SDL_SCANCODE_KP_DIVIDE | (1 << 30),
        SDLK_KP_MULTIPLY = SDL_Scancode.SDL_SCANCODE_KP_MULTIPLY | (1 << 30),
        SDLK_KP_MINUS = SDL_Scancode.SDL_SCANCODE_KP_MINUS | (1 << 30),
        SDLK_KP_PLUS = SDL_Scancode.SDL_SCANCODE_KP_PLUS | (1 << 30),
        SDLK_KP_ENTER = SDL_Scancode.SDL_SCANCODE_KP_ENTER | (1 << 30),
        SDLK_KP_1 = SDL_Scancode.SDL_SCANCODE_KP_1 | (1 << 30),
        SDLK_KP_2 = SDL_Scancode.SDL_SCANCODE_KP_2 | (1 << 30),
        SDLK_KP_3 = SDL_Scancode.SDL_SCANCODE_KP_3 | (1 << 30),
        SDLK_KP_4 = SDL_Scancode.SDL_SCANCODE_KP_4 | (1 << 30),
        SDLK_KP_5 = SDL_Scancode.SDL_SCANCODE_KP_5 | (1 << 30),
        SDLK_KP_6 = SDL_Scancode.SDL_SCANCODE_KP_6 | (1 << 30),
        SDLK_KP_7 = SDL_Scancode.SDL_SCANCODE_KP_7 | (1 << 30),
        SDLK_KP_8 = SDL_Scancode.SDL_SCANCODE_KP_8 | (1 << 30),
        SDLK_KP_9 = SDL_Scancode.SDL_SCANCODE_KP_9 | (1 << 30),
        SDLK_KP_0 = SDL_Scancode.SDL_SCANCODE_KP_0 | (1 << 30),
        SDLK_KP_PERIOD = SDL_Scancode.SDL_SCANCODE_KP_PERIOD | (1 << 30),

        SDLK_APPLICATION = SDL_Scancode.SDL_SCANCODE_APPLICATION | (1 << 30),
        SDLK_POWER = SDL_Scancode.SDL_SCANCODE_POWER | (1 << 30),
        SDLK_KP_EQUALS = SDL_Scancode.SDL_SCANCODE_KP_EQUALS | (1 << 30),
        SDLK_F13 = SDL_Scancode.SDL_SCANCODE_F13 | (1 << 30),
        SDLK_F14 = SDL_Scancode.SDL_SCANCODE_F14 | (1 << 30),
        SDLK_F15 = SDL_Scancode.SDL_SCANCODE_F15 | (1 << 30),
        SDLK_F16 = SDL_Scancode.SDL_SCANCODE_F16 | (1 << 30),
        SDLK_F17 = SDL_Scancode.SDL_SCANCODE_F17 | (1 << 30),
        SDLK_F18 = SDL_Scancode.SDL_SCANCODE_F18 | (1 << 30),
        SDLK_F19 = SDL_Scancode.SDL_SCANCODE_F19 | (1 << 30),
        SDLK_F20 = SDL_Scancode.SDL_SCANCODE_F20 | (1 << 30),
        SDLK_F21 = SDL_Scancode.SDL_SCANCODE_F21 | (1 << 30),
        SDLK_F22 = SDL_Scancode.SDL_SCANCODE_F22 | (1 << 30),
        SDLK_F23 = SDL_Scancode.SDL_SCANCODE_F23 | (1 << 30),
        SDLK_F24 = SDL_Scancode.SDL_SCANCODE_F24 | (1 << 30),
        SDLK_EXECUTE = SDL_Scancode.SDL_SCANCODE_EXECUTE | (1 << 30),
        SDLK_HELP = SDL_Scancode.SDL_SCANCODE_HELP | (1 << 30),
        SDLK_MENU = SDL_Scancode.SDL_SCANCODE_MENU | (1 << 30),
        SDLK_SELECT = SDL_Scancode.SDL_SCANCODE_SELECT | (1 << 30),
        SDLK_STOP = SDL_Scancode.SDL_SCANCODE_STOP | (1 << 30),
        SDLK_AGAIN = SDL_Scancode.SDL_SCANCODE_AGAIN | (1 << 30),
        SDLK_UNDO = SDL_Scancode.SDL_SCANCODE_UNDO | (1 << 30),
        SDLK_CUT = SDL_Scancode.SDL_SCANCODE_CUT | (1 << 30),
        SDLK_COPY = SDL_Scancode.SDL_SCANCODE_COPY | (1 << 30),
        SDLK_PASTE = SDL_Scancode.SDL_SCANCODE_PASTE | (1 << 30),
        SDLK_FIND = SDL_Scancode.SDL_SCANCODE_FIND | (1 << 30),
        SDLK_MUTE = SDL_Scancode.SDL_SCANCODE_MUTE | (1 << 30),
        SDLK_VOLUMEUP = SDL_Scancode.SDL_SCANCODE_VOLUMEUP | (1 << 30),
        SDLK_VOLUMEDOWN = SDL_Scancode.SDL_SCANCODE_VOLUMEDOWN | (1 << 30),
        SDLK_KP_COMMA = SDL_Scancode.SDL_SCANCODE_KP_COMMA | (1 << 30),
        SDLK_KP_EQUALSAS400 = SDL_Scancode.SDL_SCANCODE_KP_EQUALSAS400 | (1 << 30),

        SDLK_ALTERASE = SDL_Scancode.SDL_SCANCODE_ALTERASE | (1 << 30),
        SDLK_SYSREQ = SDL_Scancode.SDL_SCANCODE_SYSREQ | (1 << 30),
        SDLK_CANCEL = SDL_Scancode.SDL_SCANCODE_CANCEL | (1 << 30),
        SDLK_CLEAR = SDL_Scancode.SDL_SCANCODE_CLEAR | (1 << 30),
        SDLK_PRIOR = SDL_Scancode.SDL_SCANCODE_PRIOR | (1 << 30),
        SDLK_RETURN2 = SDL_Scancode.SDL_SCANCODE_RETURN2 | (1 << 30),
        SDLK_SEPARATOR = SDL_Scancode.SDL_SCANCODE_SEPARATOR | (1 << 30),
        SDLK_OUT = SDL_Scancode.SDL_SCANCODE_OUT | (1 << 30),
        SDLK_OPER = SDL_Scancode.SDL_SCANCODE_OPER | (1 << 30),
        SDLK_CLEARAGAIN = SDL_Scancode.SDL_SCANCODE_CLEARAGAIN | (1 << 30),
        SDLK_CRSEL = SDL_Scancode.SDL_SCANCODE_CRSEL | (1 << 30),
        SDLK_EXSEL = SDL_Scancode.SDL_SCANCODE_EXSEL | (1 << 30),

        SDLK_KP_00 = SDL_Scancode.SDL_SCANCODE_KP_00 | (1 << 30),
        SDLK_KP_000 = SDL_Scancode.SDL_SCANCODE_KP_000 | (1 << 30),
        SDLK_THOUSANDSSEPARATOR = SDL_Scancode.SDL_SCANCODE_THOUSANDSSEPARATOR | (1 << 30),
        SDLK_DECIMALSEPARATOR = SDL_Scancode.SDL_SCANCODE_DECIMALSEPARATOR | (1 << 30),
        SDLK_CURRENCYUNIT = SDL_Scancode.SDL_SCANCODE_CURRENCYUNIT | (1 << 30),
        SDLK_CURRENCYSUBUNIT = SDL_Scancode.SDL_SCANCODE_CURRENCYSUBUNIT | (1 << 30),
        SDLK_KP_LEFTPAREN = SDL_Scancode.SDL_SCANCODE_KP_LEFTPAREN | (1 << 30),
        SDLK_KP_RIGHTPAREN = SDL_Scancode.SDL_SCANCODE_KP_RIGHTPAREN | (1 << 30),
        SDLK_KP_LEFTBRACE = SDL_Scancode.SDL_SCANCODE_KP_LEFTBRACE | (1 << 30),
        SDLK_KP_RIGHTBRACE = SDL_Scancode.SDL_SCANCODE_KP_RIGHTBRACE | (1 << 30),
        SDLK_KP_TAB = SDL_Scancode.SDL_SCANCODE_KP_TAB | (1 << 30),
        SDLK_KP_BACKSPACE = SDL_Scancode.SDL_SCANCODE_KP_BACKSPACE | (1 << 30),
        SDLK_KP_A = SDL_Scancode.SDL_SCANCODE_KP_A | (1 << 30),
        SDLK_KP_B = SDL_Scancode.SDL_SCANCODE_KP_B | (1 << 30),
        SDLK_KP_C = SDL_Scancode.SDL_SCANCODE_KP_C | (1 << 30),
        SDLK_KP_D = SDL_Scancode.SDL_SCANCODE_KP_D | (1 << 30),
        SDLK_KP_E = SDL_Scancode.SDL_SCANCODE_KP_E | (1 << 30),
        SDLK_KP_F = SDL_Scancode.SDL_SCANCODE_KP_F | (1 << 30),
        SDLK_KP_XOR = SDL_Scancode.SDL_SCANCODE_KP_XOR | (1 << 30),
        SDLK_KP_POWER = SDL_Scancode.SDL_SCANCODE_KP_POWER | (1 << 30),
        SDLK_KP_PERCENT = SDL_Scancode.SDL_SCANCODE_KP_PERCENT | (1 << 30),
        SDLK_KP_LESS = SDL_Scancode.SDL_SCANCODE_KP_LESS | (1 << 30),
        SDLK_KP_GREATER = SDL_Scancode.SDL_SCANCODE_KP_GREATER | (1 << 30),
        SDLK_KP_AMPERSAND = SDL_Scancode.SDL_SCANCODE_KP_AMPERSAND | (1 << 30),
        SDLK_KP_DBLAMPERSAND = SDL_Scancode.SDL_SCANCODE_KP_DBLAMPERSAND | (1 << 30),
        SDLK_KP_VERTICALBAR = SDL_Scancode.SDL_SCANCODE_KP_VERTICALBAR | (1 << 30),
        SDLK_KP_DBLVERTICALBAR = SDL_Scancode.SDL_SCANCODE_KP_DBLVERTICALBAR | (1 << 30),
        SDLK_KP_COLON = SDL_Scancode.SDL_SCANCODE_KP_COLON | (1 << 30),
        SDLK_KP_HASH = SDL_Scancode.SDL_SCANCODE_KP_HASH | (1 << 30),
        SDLK_KP_SPACE = SDL_Scancode.SDL_SCANCODE_KP_SPACE | (1 << 30),
        SDLK_KP_AT = SDL_Scancode.SDL_SCANCODE_KP_AT | (1 << 30),
        SDLK_KP_EXCLAM = SDL_Scancode.SDL_SCANCODE_KP_EXCLAM | (1 << 30),
        SDLK_KP_MEMSTORE = SDL_Scancode.SDL_SCANCODE_KP_MEMSTORE | (1 << 30),
        SDLK_KP_MEMRECALL = SDL_Scancode.SDL_SCANCODE_KP_MEMRECALL | (1 << 30),
        SDLK_KP_MEMCLEAR = SDL_Scancode.SDL_SCANCODE_KP_MEMCLEAR | (1 << 30),
        SDLK_KP_MEMADD = SDL_Scancode.SDL_SCANCODE_KP_MEMADD | (1 << 30),
        SDLK_KP_MEMSUBTRACT = SDL_Scancode.SDL_SCANCODE_KP_MEMSUBTRACT | (1 << 30),
        SDLK_KP_MEMMULTIPLY = SDL_Scancode.SDL_SCANCODE_KP_MEMMULTIPLY | (1 << 30),
        SDLK_KP_MEMDIVIDE = SDL_Scancode.SDL_SCANCODE_KP_MEMDIVIDE | (1 << 30),
        SDLK_KP_PLUSMINUS = SDL_Scancode.SDL_SCANCODE_KP_PLUSMINUS | (1 << 30),
        SDLK_KP_CLEAR = SDL_Scancode.SDL_SCANCODE_KP_CLEAR | (1 << 30),
        SDLK_KP_CLEARENTRY = SDL_Scancode.SDL_SCANCODE_KP_CLEARENTRY | (1 << 30),
        SDLK_KP_BINARY = SDL_Scancode.SDL_SCANCODE_KP_BINARY | (1 << 30),
        SDLK_KP_OCTAL = SDL_Scancode.SDL_SCANCODE_KP_OCTAL | (1 << 30),
        SDLK_KP_DECIMAL = SDL_Scancode.SDL_SCANCODE_KP_DECIMAL | (1 << 30),
        SDLK_KP_HEXADECIMAL = SDL_Scancode.SDL_SCANCODE_KP_HEXADECIMAL | (1 << 30),

        SDLK_LCTRL = SDL_Scancode.SDL_SCANCODE_LCTRL | (1 << 30),
        SDLK_LSHIFT = SDL_Scancode.SDL_SCANCODE_LSHIFT | (1 << 30),
        SDLK_LALT = SDL_Scancode.SDL_SCANCODE_LALT | (1 << 30),
        SDLK_LGUI = SDL_Scancode.SDL_SCANCODE_LGUI | (1 << 30),
        SDLK_RCTRL = SDL_Scancode.SDL_SCANCODE_RCTRL | (1 << 30),
        SDLK_RSHIFT = SDL_Scancode.SDL_SCANCODE_RSHIFT | (1 << 30),
        SDLK_RALT = SDL_Scancode.SDL_SCANCODE_RALT | (1 << 30),
        SDLK_RGUI = SDL_Scancode.SDL_SCANCODE_RGUI | (1 << 30),

        SDLK_MODE = SDL_Scancode.SDL_SCANCODE_MODE | (1 << 30),

        SDLK_AUDIONEXT = SDL_Scancode.SDL_SCANCODE_AUDIONEXT | (1 << 30),
        SDLK_AUDIOPREV = SDL_Scancode.SDL_SCANCODE_AUDIOPREV | (1 << 30),
        SDLK_AUDIOSTOP = SDL_Scancode.SDL_SCANCODE_AUDIOSTOP | (1 << 30),
        SDLK_AUDIOPLAY = SDL_Scancode.SDL_SCANCODE_AUDIOPLAY | (1 << 30),
        SDLK_AUDIOMUTE = SDL_Scancode.SDL_SCANCODE_AUDIOMUTE | (1 << 30),
        SDLK_MEDIASELECT = SDL_Scancode.SDL_SCANCODE_MEDIASELECT | (1 << 30),
        SDLK_WWW = SDL_Scancode.SDL_SCANCODE_WWW | (1 << 30),
        SDLK_MAIL = SDL_Scancode.SDL_SCANCODE_MAIL | (1 << 30),
        SDLK_CALCULATOR = SDL_Scancode.SDL_SCANCODE_CALCULATOR | (1 << 30),
        SDLK_COMPUTER = SDL_Scancode.SDL_SCANCODE_COMPUTER | (1 << 30),
        SDLK_AC_SEARCH = SDL_Scancode.SDL_SCANCODE_AC_SEARCH | (1 << 30),
        SDLK_AC_HOME = SDL_Scancode.SDL_SCANCODE_AC_HOME | (1 << 30),
        SDLK_AC_BACK = SDL_Scancode.SDL_SCANCODE_AC_BACK | (1 << 30),
        SDLK_AC_FORWARD = SDL_Scancode.SDL_SCANCODE_AC_FORWARD | (1 << 30),
        SDLK_AC_STOP = SDL_Scancode.SDL_SCANCODE_AC_STOP | (1 << 30),
        SDLK_AC_REFRESH = SDL_Scancode.SDL_SCANCODE_AC_REFRESH | (1 << 30),
        SDLK_AC_BOOKMARKS = SDL_Scancode.SDL_SCANCODE_AC_BOOKMARKS | (1 << 30),

        SDLK_BRIGHTNESSDOWN = SDL_Scancode.SDL_SCANCODE_BRIGHTNESSDOWN | (1 << 30),
        SDLK_BRIGHTNESSUP = SDL_Scancode.SDL_SCANCODE_BRIGHTNESSUP | (1 << 30),
        SDLK_DISPLAYSWITCH = SDL_Scancode.SDL_SCANCODE_DISPLAYSWITCH | (1 << 30),
        SDLK_KBDILLUMTOGGLE = SDL_Scancode.SDL_SCANCODE_KBDILLUMTOGGLE | (1 << 30),
        SDLK_KBDILLUMDOWN = SDL_Scancode.SDL_SCANCODE_KBDILLUMDOWN | (1 << 30),
        SDLK_KBDILLUMUP = SDL_Scancode.SDL_SCANCODE_KBDILLUMUP | (1 << 30),
        SDLK_EJECT = SDL_Scancode.SDL_SCANCODE_EJECT | (1 << 30),
        SDLK_SLEEP = SDL_Scancode.SDL_SCANCODE_SLEEP | (1 << 30),
        SDLK_APP1 = SDL_Scancode.SDL_SCANCODE_APP1 | (1 << 30),
        SDLK_APP2 = SDL_Scancode.SDL_SCANCODE_APP2 | (1 << 30),

        SDLK_AUDIOREWIND = SDL_Scancode.SDL_SCANCODE_AUDIOREWIND | (1 << 30),
        SDLK_AUDIOFASTFORWARD = SDL_Scancode.SDL_SCANCODE_AUDIOFASTFORWARD | (1 << 30),

        SDLK_SOFTLEFT = SDL_Scancode.SDL_SCANCODE_SOFTLEFT | (1 << 30),
        SDLK_SOFTRIGHT = SDL_Scancode.SDL_SCANCODE_SOFTRIGHT | (1 << 30),
        SDLK_CALL = SDL_Scancode.SDL_SCANCODE_CALL | (1 << 30),
        SDLK_ENDCALL = SDL_Scancode.SDL_SCANCODE_ENDCALL | (1 << 30),
    }
}
