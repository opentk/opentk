using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Mouse indicator flags (found in winuser.h).
    /// </summary>
    [Flags]
    public enum RawMouseFlags : ushort
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
