using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="DisplayDevice"/> to represent the device state.
    /// </summary>
    [Flags]
    public enum DisplayDeviceStateFlags : uint
    {
        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        AttachedToDesktop = 0x00000001,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        MultiDriver = 0x00000002,

        /// <summary>
        /// The primary desktop is on the device. For a system with a single display card, this is always set. For a
        /// system with multiple display cards, only one device can have this set.
        /// </summary>
        PrimaryDevice = 0x00000004,

        /// <summary>
        /// Represents a pseudo device used to mirror application drawing for remoting or other purposes.<para/>
        /// An invisible pseudo monitor is associated with this device.
        /// </summary>
        MirroringDriver = 0x00000008,

        /// <summary>
        /// The device is VGA compatible.
        /// </summary>
        VgaCompatible = 0x00000010,

        /// <summary>
        /// The device is removable; it cannot be the primary display.
        /// </summary>
        Removable = 0x00000020,

        /// <summary>
        /// The device has more display modes than its output devices support.
        /// </summary>
        ModesPruned = 0x08000000,
    }
}
