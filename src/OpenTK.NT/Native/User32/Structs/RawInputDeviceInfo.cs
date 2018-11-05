using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from any device.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct RawInputDeviceInfo
    {
        /// <summary>
        /// Size, in bytes, of the <see cref="RawInputDeviceInfo"/> structure.
        /// </summary>
        [FieldOffset(0)]
        public uint Size;

        /// <summary>
        /// Type of raw input data.
        /// </summary>
        [FieldOffset(4)]
        public RawInputDeviceType Type;

        /// <summary>
        /// If <see cref="Type"/> is <see cref="RawInputDeviceType.Mouse"/>, this is the
        /// <see cref="RawInputDeviceInfoMouse"/> structure that defines the mouse.
        /// </summary>
        [FieldOffset(8)]
        public RawInputDeviceInfoMouse Mouse;

        /// <summary>
        /// If <see cref="Type"/> is <see cref="RawInputDeviceType.Keyboard"/>, this is the
        /// <see cref="RawInputDeviceInfoKeyboard"/> structure that defines the keyboard.
        /// </summary>
        [FieldOffset(8)]
        public RawInputDeviceInfoKeyboard Keyboard;

        /// <summary>
        /// If <see cref="Type"/> is <see cref="RawInputDeviceType.Hid"/>, this is the
        /// <see cref="RawInputDeviceInfoHid"/> structure that defines the HID.
        /// </summary>
        [FieldOffset(8)]
        public RawInputDeviceInfoHid Hid;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputDeviceInfo>();
    }
}
