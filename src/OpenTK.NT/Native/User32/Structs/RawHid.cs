using System;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// The RawHID structure describes the format of the raw input from a Human Interface Device (HID).
    /// </summary>
    /// <remarks>
    /// Each <see cref="WindowMessage.Input"/> can indicate several inputs, but all of the inputs come from the same
    /// HID. The size of the <see cref="RawData"/> array is <see cref="SizeHid"/> * <see cref="Count"/>.
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

        /// <summary>
        /// Access the raw input data at a given index.
        /// </summary>
        /// <param name="index">The index at which to access the raw input data.</param>
        /// <returns>A byte of raw input data at the given index.</returns>
        public unsafe byte this[int index]
        {
            get
            {
                if (index < 0 || index > SizeHid * Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                fixed (byte* data = &RawData)
                {
                    return *(data + index);
                }
            }
        }
    }
}
