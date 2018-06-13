using System.Runtime.InteropServices;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from any device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawDeviceInfo
    {
        public DeviceStruct device;

        /// <summary>
        /// Size, in bytes, of the RawInputDeviceInfo structure.
        /// </summary>
        public DWORD cbSize;

        /// <summary>
        /// Type of raw input data.
        /// </summary>
        public RawInputDeviceType dwType;

        [StructLayout(LayoutKind.Explicit)]
        public struct DeviceStruct
        {
            [FieldOffset(0)] public RawDeviceInfoMouse mouse;
            [FieldOffset(0)] public RawDeviceInfoKeyboard keyboard;
            [FieldOffset(0)] public RawDeviceInfoHid hid;
        }

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawDeviceInfo>();
    }
}
