using System.Runtime.InteropServices;

using LONG = System.Int32;
using ULONG = System.UInt32;
using USHORT = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains information about the state of the mouse.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct RAWMOUSE
    {
        /// <summary>
        /// Mouse state. This member can be any reasonable combination of the following.
        /// MOUSE_ATTRIBUTES_CHANGED
        /// Mouse attributes changed; application needs to query the mouse attributes.
        /// MOUSE_MOVE_RELATIVE
        /// Mouse movement data is relative to the last mouse position.
        /// MOUSE_MOVE_ABSOLUTE
        /// Mouse movement data is based on absolute position.
        /// MOUSE_VIRTUAL_DESKTOP
        /// Mouse coordinates are mapped to the virtual desktop (for a multiple monitor system).
        /// </summary>
        [FieldOffset(0)] public RawMouseFlags usFlags; // USHORT in winuser.h, but only INT works -- USHORT returns 0.

        [FieldOffset(4)] public RawInputMouseState usButtonFlags;

        /// <summary>
        /// If usButtonFlags is RI_MOUSE_WHEEL, this member is a signed value that specifies the wheel delta.
        /// </summary>
        [FieldOffset(6)] public USHORT usButtonData;

        /// <summary>
        /// Raw state of the mouse buttons.
        /// </summary>
        [FieldOffset(8)] public ULONG ulRawButtons;

        /// <summary>
        /// Motion in the X direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
        /// </summary>
        [FieldOffset(12)] public LONG lLastX;

        /// <summary>
        /// Motion in the Y direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
        /// </summary>
        [FieldOffset(16)] public LONG lLastY;

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        [FieldOffset(20)] public ULONG ulExtraInformation;
    }
}
