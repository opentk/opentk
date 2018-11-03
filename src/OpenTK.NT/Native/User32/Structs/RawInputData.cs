using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// A union containing raw input data from a device.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct RawInputData
    {
        /// <summary>
        /// If the data comes from a mouse, this is the raw input data.
        /// </summary>
        [FieldOffset(0)]
        public RawMouse Mouse;

        /// <summary>
        /// If the data comes from a keyboard, this is the raw input data.
        /// </summary>
        [FieldOffset(0)]
        public RawKeyboard Keyboard;

        /// <summary>
        /// If the data comes from a HID, this is the raw input data.
        /// </summary>
        [FieldOffset(0)]
        public RawHid Hid;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputData>();
    }
}
