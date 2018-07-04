using OpenTK.NT.Native;
using System;

using DWORD = System.UInt32;

namespace OpenTK.Platform.Windows
{
    public struct BroadcastDeviceInterface
    {
        public DWORD Size;
        public DeviceBroadcastType DeviceType;
        public DWORD Reserved;
        public Guid ClassGuid;
        public char Name;
    }
}
