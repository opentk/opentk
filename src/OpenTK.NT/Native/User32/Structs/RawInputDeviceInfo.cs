using System.Runtime.InteropServices;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from any device.
    /// </summary>
    public struct RawInputDeviceInfo
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
            [FieldOffset(0)] public RawInputDeviceInfoMouse Mouse;
            [FieldOffset(0)] public RawInputDeviceInfoKeyboard Keyboard;
            [FieldOffset(0)] public RawInputDeviceInfoHid Hid;
        }

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputDeviceInfo>();
    }
}
