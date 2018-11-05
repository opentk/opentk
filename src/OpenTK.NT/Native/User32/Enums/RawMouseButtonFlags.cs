using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies the transition state of the mouse buttons.
    /// </summary>
    [Flags]
    public enum RawMouseButtonFlags : ushort
    {
        /// <summary>
        /// Left Button changed to down.
        /// </summary>
        LeftButtonDown = 0x0001,

        /// <summary>
        /// Left Button changed to up.
        /// </summary>
        LeftButtonUp = 0x0002,

        /// <summary>
        /// Right Button changed to down.
        /// </summary>
        RightButtonDown = 0x0004,

        /// <summary>
        /// Right Button changed to up.
        /// </summary>
        RightButtonUp = 0x0008,

        /// <summary>
        /// Middle Button changed to down.
        /// </summary>
        MiddleButtonDown = 0x0010,

        /// <summary>
        /// Middle Button changed to up.
        /// </summary>
        MiddleButtonUp = 0x0020,

        /// <summary>
        /// Same as <see cref="LeftButtonDown"/>.
        /// </summary>
        Button1Down = LeftButtonDown,

        /// <summary>
        /// Same as <see cref="LeftButtonUp"/>.
        /// </summary>
        Button1Up = LeftButtonUp,

        /// <summary>
        /// Same as <see cref="RightButtonDown"/>.
        /// </summary>
        Button2Down = RightButtonDown,

        /// <summary>
        /// Same as <see cref="RightButtonUp"/>.
        /// </summary>
        Button2Up = RightButtonUp,

        /// <summary>
        /// Same as <see cref="MiddleButtonDown"/>.
        /// </summary>
        Button3Down = MiddleButtonDown,

        /// <summary>
        /// Same as <see cref="MiddleButtonUp"/>.
        /// </summary>
        Button3Up = MiddleButtonUp,

        /// <summary>
        /// XBUTTON1 changed to down.
        /// </summary>
        Button4Down = 0x0040,

        /// <summary>
        /// XBUTTON1 changed to up.
        /// </summary>
        Button4Up = 0x0080,

        /// <summary>
        /// XBUTTON2 changed to down.
        /// </summary>
        Button5Down = 0x0100,

        /// <summary>
        /// XBUTTON2 changed to up.
        /// </summary>
        Button5Up = 0x0200,

        /// <summary>
        /// Raw input comes from a mouse wheel. The wheel delta is stored in <see cref="RawMouse.ButtonData"/>.
        /// </summary>
        Wheel = 0x0400,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        HWheel = 0x0800
    }
}
