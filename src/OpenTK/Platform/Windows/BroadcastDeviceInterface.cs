using OpenTK.NT.Native;
using System;

namespace OpenTK.Platform.Windows
{
    internal struct BroadcastDeviceInterface
    {
        public int Size;
        public DeviceBroadcastType DeviceType;
        private int dbcc_reserved;
        public Guid ClassGuid;
        public char dbcc_name;
    }
}
