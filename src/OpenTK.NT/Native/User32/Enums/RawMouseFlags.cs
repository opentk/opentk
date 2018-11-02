using System;
using USHORT = System.UInt16;

namespace OpenToolkit.NT.Native.User32.Enums
{
    /// <summary>
    /// Mouse indicator flags (found in winuser.h).
    /// </summary>
    [Flags]
    public enum RawMouseFlags : USHORT
    {
        /// <summary>
        /// LastX/Y indicate relative motion.
        /// </summary>
        MouseMoveRelative = 0x00,

        /// <summary>
        /// LastX/Y indicate absolute motion.
        /// </summary>
        MouseMoveAbsolute = 0x01,

        /// <summary>
        /// The coordinates are mapped to the virtual desktop.
        /// </summary>
        MouseVirtualDesktop = 0x02,

        /// <summary>
        /// Requery for mouse attributes.
        /// </summary>
        MouseAttributesChanged = 0x04
    }
}
