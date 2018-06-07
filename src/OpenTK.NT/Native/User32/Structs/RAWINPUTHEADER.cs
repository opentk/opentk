using OpenTK.Core;
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
    [StructLayout(LayoutKind.Sequential)]
    public struct RAWINPUTHEADER
    {
        /// <summary>
        /// Type of raw input.
        /// </summary>
        internal RawInputDeviceType dwType;

        /// <summary>
        /// Size, in bytes, of the entire input packet of data. This includes the RawInput struct plus possible extra input
        /// reports in the RAWHID variable length array.
        /// </summary>
        internal DWORD dwSize;

        /// <summary>
        /// Handle to the device generating the raw input data.
        /// </summary>
        internal HANDLE hDevice;

        /// <summary>
        /// Value passed in the wParam parameter of the WM_INPUT message.
        /// </summary>
        internal WPARAM wParam;

        public static readonly uint SizeInBytes =
            (uint)BlittableValueType<RAWINPUTHEADER>.Stride;
    }
}
