using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains the header information that is part of the raw input data.
    /// </summary>
    public struct RawInputHeader
    {
        /// <summary>
        /// Type of raw input.
        /// </summary>
        public RawInputDeviceType Type;

        /// <summary>
        /// The size, in bytes, of the entire input packet of data. This includes <see cref="RawInput"/> plus
        /// possible extra input reports in the <see cref="RawHid"/> variable length array.
        /// </summary>
        public uint Size;

        /// <summary>
        /// Handle to the device generating the raw input data.
        /// </summary>
        public IntPtr Device;

        /// <summary>
        /// Value passed in the wParam parameter of the <see cref="WindowMessage.Input"/> message.
        /// </summary>
        public IntPtr Param;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputHeader>();
    }
}
