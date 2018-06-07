using System.Runtime.InteropServices;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from any device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class RID_DEVICE_INFO
    {
        internal DeviceStruct device;

        /// <summary>
        /// Size, in bytes, of the RawInputDeviceInfo structure.
        /// </summary>
        internal DWORD cbSize = (uint)Marshal.SizeOf(typeof(RID_DEVICE_INFO));

        /// <summary>
        /// Type of raw input data.
        /// </summary>
        internal RawInputDeviceType dwType;

        [StructLayout(LayoutKind.Explicit)]
        internal struct DeviceStruct
        {
            [FieldOffset(0)] internal RID_DEVICE_INFO_MOUSE mouse;
            [FieldOffset(0)] internal RID_DEVICE_INFO_KEYBOARD keyboard;
            [FieldOffset(0)] internal RID_DEVICE_INFO_HID hid;
        }
    }
}
