using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HANDLE = System.IntPtr;
using WPARAM = System.IntPtr;

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
        public DWORD Size;

        /// <summary>
        /// Handle to the device generating the raw input data.
        /// </summary>
        public HANDLE Device;

        /// <summary>
        /// Value passed in the wParam parameter of the <see cref="WindowMessage.Input"/> message.
        /// </summary>
        public WPARAM Param;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputHeader>();
    }
}
