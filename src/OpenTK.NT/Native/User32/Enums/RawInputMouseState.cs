using System;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum RawInputMouseState : ushort
    {
        LEFT_BUTTON_DOWN = 0x0001, // Left Button changed to down.
        LEFT_BUTTON_UP = 0x0002, // Left Button changed to up.
        RIGHT_BUTTON_DOWN = 0x0004, // Right Button changed to down.
        RIGHT_BUTTON_UP = 0x0008, // Right Button changed to up.
        MIDDLE_BUTTON_DOWN = 0x0010, // Middle Button changed to down.
        MIDDLE_BUTTON_UP = 0x0020, // Middle Button changed to up.

        BUTTON_1_DOWN = LEFT_BUTTON_DOWN,
        BUTTON_1_UP = LEFT_BUTTON_UP,
        BUTTON_2_DOWN = RIGHT_BUTTON_DOWN,
        BUTTON_2_UP = RIGHT_BUTTON_UP,
        BUTTON_3_DOWN = MIDDLE_BUTTON_DOWN,
        BUTTON_3_UP = MIDDLE_BUTTON_UP,

        BUTTON_4_DOWN = 0x0040,
        BUTTON_4_UP = 0x0080,
        BUTTON_5_DOWN = 0x0100,
        BUTTON_5_UP = 0x0200,

        WHEEL = 0x0400,
        HWHEEL = 0x0800
    }
}
