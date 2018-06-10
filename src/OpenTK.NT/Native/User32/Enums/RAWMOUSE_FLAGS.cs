using System;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Mouse indicator flags (found in winuser.h).
    /// </summary>
    [Flags]
    public enum RAWMOUSE_FLAGS : ushort
    {
        /// <summary>
        /// LastX/Y indicate relative motion.
        /// </summary>
        MOUSE_MOVE_RELATIVE = 0x00,

        /// <summary>
        /// LastX/Y indicate absolute motion.
        /// </summary>
        MOUSE_MOVE_ABSOLUTE = 0x01,

        /// <summary>
        /// The coordinates are mapped to the virtual desktop.
        /// </summary>
        MOUSE_VIRTUAL_DESKTOP = 0x02,

        /// <summary>
        /// Requery for mouse attributes.
        /// </summary>
        MOUSE_ATTRIBUTES_CHANGED = 0x04
    }
}
