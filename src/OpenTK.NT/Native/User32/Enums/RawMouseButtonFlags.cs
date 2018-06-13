using System;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum RawMouseButtonFlags : uint
    {
        LeftButtonDown = 0x0001, // Left Button changed to down.
        LeftButtonUp = 0x0002, // Left Button changed to up.
        RightButtonDown = 0x0004, // Right Button changed to down.
        RightButtonUp = 0x0008, // Right Button changed to up.
        MiddleButtonDown = 0x0010, // Middle Button changed to down.
        MiddleButtonUp = 0x0020, // Middle Button changed to up.

        Button1Down = LeftButtonDown,
        Button1Up = LeftButtonUp,
        Button2Down = RightButtonDown,
        Button2Up = RightButtonUp,
        Button3Down = MiddleButtonDown,
        Button3Up = MiddleButtonUp,

        Button4Down = 0x0040,
        Button4Up = 0x0080,
        Button5Down = 0x0100,
        Button5Up = 0x0200,

        /// <summary>
        /// Raw input comes from a mouse wheel. The wheel delta is stored in <see cref="RawMouse.usButtonData"/>.
        /// </summary>
        Wheel = 0x0400,
        HWheel = 0x0800
    }
}
