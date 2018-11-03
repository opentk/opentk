using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about a class of devices.
    /// </summary>
    public struct BroadcastDeviceInterface
    {
        /// <summary>
        /// The size of this structure, in bytes. This is the size of the members plus the actual length of the
        /// <see cref="Name"/> string (the null character is accounted for by the declaration of <see cref="Name"/>
        /// as a one-character array).
        /// </summary>
        public uint Size;

        /// <summary>
        /// Official documentation states "Set to <see cref="DeviceBroadcastType.DeviceInterface"/>".<para/>
        /// Only set to something else if you know what you're doing.
        /// </summary>
        public DeviceBroadcastType DeviceType;

        /// <summary>
        /// Reserved; do not use.
        /// </summary>
        public uint Reserved;

        /// <summary>
        /// The GUID for the interface device class.
        /// </summary>
        public Guid ClassGuid;

        /// <summary>
        /// Gets a string that specifies the name of the device.
        /// </summary>
        public unsafe string Name
        {
            get
            {
                fixed (char* namePtr = &_name)
                {
                    return Marshal.PtrToStringUni((IntPtr)namePtr);
                }
            }
        }

        /// <summary>
        /// The first character of the <see cref="Name"/>.
        /// </summary>
        private char _name;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<BroadcastDeviceInterface>();
    }
}
