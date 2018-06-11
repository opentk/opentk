using System;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum DisplayDeviceStateFlags : DWORD
    {
        NONE = 0x00000000,
        ATTACHED_TO_DESKTOP = 0x00000001,
        MULTI_DRIVER = 0x00000002,
        PRIMARY_DEVICE = 0x00000004,

        /// <summary>
        /// Represents a pseudo device used to mirror application drawing for remoting or other purposes.<br/>
        /// An invisible pseudo monitor is associated with this device. For example, NetMeeting uses it.<br/>
        /// Note that GetSystemMetrics (SM_MONITORS) only accounts for visible display monitors.
        /// </summary>
        MIRRORING_DRIVER = 0x00000008,

        /// <summary>
        /// The device is VGA compatible.
        /// </summary>
        VGA_COMPATIBLE = 0x00000010,

        /// <summary>
        /// The device is removable; it cannot be the primary display.
        /// </summary>
        REMOVABLE = 0x00000020,

        /// <summary>
        /// The device has more display modes than its output devices support.
        /// </summary>
        MODESPRUNED = 0x08000000,

        REMOTE = 0x04000000,
        DISCONNECT = 0x02000000,


        /// <summary>
        /// DISPLAY_DEVICE_ACTIVE specifies whether a monitor is presented as being "on" by the respective GDI view.<br/>
        /// Windows Vista: EnumDisplayDevices will only enumerate monitors that can be presented as being "on."
        /// </summary>
        ACTIVE = 0x00000001,

        ATTACHED = 0x00000002
    }
}
