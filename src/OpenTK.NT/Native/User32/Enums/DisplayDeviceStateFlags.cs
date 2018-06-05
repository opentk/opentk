using System;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum DisplayDeviceStateFlags
    {
        None = 0x00000000,
        AttachedToDesktop = 0x00000001,
        MultiDriver = 0x00000002,
        PrimaryDevice = 0x00000004,
        MirroringDriver = 0x00000008,
        VgaCompatible = 0x00000010,
        Removable = 0x00000020,
        ModesPruned = 0x08000000,
        Remote = 0x04000000,
        Disconnect = 0x02000000,

        // Child device state
        Active = 0x00000001,
        Attached = 0x00000002
    }
}
