using System;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum DisplayDeviceStateFlags : DWORD
    {
        None = 0x00000000,
        AttachedToDesktop = 0x00000001,
        MultiDriver = 0x00000002,
        PrimaryDevice = 0x00000004,

        /// <summary>
        /// Represents a pseudo device used to mirror application drawing for remoting or other purposes.<br/>
        /// An invisible pseudo monitor is associated with this device. For example, NetMeeting uses it.<br/>
        /// Note that GetSystemMetrics (SM_MONITORS) only accounts for visible display monitors.
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

        Remote = 0x04000000,
        Disconnect = 0x02000000,

        /// <summary>
        /// DISPLAY_DEVICE_ACTIVE specifies whether a monitor is presented as being "on" by the respective GDI view.<br/>
        /// Windows Vista: EnumDisplayDevices will only enumerate monitors that can be presented as being "on."
        /// </summary>
        Active = 0x00000001,

        Attached = 0x00000002
    }
}
