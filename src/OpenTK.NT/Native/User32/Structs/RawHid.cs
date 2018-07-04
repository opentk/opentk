using System;

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
    public struct RawHid
    {
        /// <summary>
        /// Size, in bytes, of each HID input in bRawData.
        /// </summary>
        public DWORD SizeHid;

        /// <summary>
        /// Number of HID inputs in bRawData.
        /// </summary>
        public DWORD Count;

        /// <summary>
        /// Raw input data as an array of bytes.
        /// </summary>
        public byte RawData;

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index > SizeHid * Count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                unsafe
                {
                    fixed (byte* data = &RawData)
                    {
                        return *(data + index);
                    }
                }
            }
        }
    }
}
