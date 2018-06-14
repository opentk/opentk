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
        public DeviceStruct Device;

        /// <summary>
        /// Size, in bytes, of the RawInputDeviceInfo structure.
        /// </summary>
        public DWORD Size;

        /// <summary>
        /// Type of raw input data.
        /// </summary>
        public RawInputDeviceType Type;

        [StructLayout(LayoutKind.Explicit)]
        public struct DeviceStruct
        {
            [FieldOffset(0)] public RawDeviceInfoMouse Mouse;
            [FieldOffset(0)] public RawDeviceInfoKeyboard Keyboard;
            [FieldOffset(0)] public RawDeviceInfoHid Hid;
        }

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawDeviceInfo>();
    }
}
