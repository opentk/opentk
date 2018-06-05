using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from any device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class RawInputDeviceInfo
    {
        internal DeviceStruct Device;

        /// <summary>
        /// Size, in bytes, of the RawInputDeviceInfo structure.
        /// </summary>
        internal int Size = Marshal.SizeOf(typeof(RawInputDeviceInfo));

        /// <summary>
        /// Type of raw input data.
        /// </summary>
        internal RawInputDeviceType Type;

        [StructLayout(LayoutKind.Explicit)]
        internal struct DeviceStruct
        {
            [FieldOffset(0)] internal RawInputMouseDeviceInfo Mouse;
            [FieldOffset(0)] internal RawInputKeyboardDeviceInfo Keyboard;
            [FieldOffset(0)] internal RawInputHIDDeviceInfo HID;
        }
    }
}
