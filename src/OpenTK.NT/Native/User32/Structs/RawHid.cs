using System;
using System.Runtime.InteropServices;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// The RawHID structure describes the format of the raw input
    /// from a Human Interface Device (HID).
    /// </summary>
    /// <remarks>
    /// Each WM_INPUT can indicate several inputs, but all of the inputs
    /// come from the same HID. The size of the bRawData array is
    /// dwSizeHid * dwCount.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawHid
    {
        /// <summary>
        /// Size, in bytes, of each HID input in bRawData.
        /// </summary>
        public DWORD dwSizeHid;

        /// <summary>
        /// Number of HID inputs in bRawData.
        /// </summary>
        public DWORD dwCount;

        /// <summary>
        /// Raw input data as an array of bytes.
        /// </summary>
        public byte bRawData;

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index > dwSizeHid * dwCount)
                    throw new ArgumentOutOfRangeException(nameof(index));

                unsafe
                {
                    fixed (byte* data = &bRawData)
                    {
                        return *(data + index);
                    }
                }
            }
        }
    }
}
