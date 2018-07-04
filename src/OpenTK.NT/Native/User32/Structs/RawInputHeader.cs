using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HANDLE = System.IntPtr;
using WPARAM = System.IntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains the header information that is part of the raw input data.
    /// </summary>
    /// <remarks>
    /// To get more information on the device, use hDevice in a call to GetRawInputDeviceInfo.
    /// </remarks>
    public struct RawInputHeader
    {
        /// <summary>
        /// Type of raw input.
        /// </summary>
        public RawInputDeviceType Type;

        /// <summary>
        /// Size, in bytes, of the entire input packet of data. This includes the RawInput struct plus possible extra input
        /// reports in the RAWHID variable length array.
        /// </summary>
        public DWORD Size;

        /// <summary>
        /// Handle to the device generating the raw input data.
        /// </summary>
        public HANDLE Device;

        /// <summary>
        /// Value passed in the wParam parameter of the WM_INPUT message.
        /// </summary>
        public WPARAM Param;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputHeader>();
    }
}
