using System;

namespace OpenToolkit.NT.Native
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
        public uint SizeHid;

        /// <summary>
        /// Number of HID inputs in bRawData.
        /// </summary>
        public uint Count;

        /// <summary>
        /// The first byte of the raw input data.
        /// </summary>
        public byte RawData;

        /// <summary>
        /// Gets the raw input data as an array of bytes.
        /// </summary>
        /// <returns>An array of raw input data.</returns>
        public unsafe byte[] GetRawData()
        {
            byte[] result = new byte[SizeHid * Count];

            fixed (byte* dataPtr = &RawData)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = *(dataPtr + i);
                }
            }

            return result;
        }

        /// <summary>
        /// Access the raw input data at a given index.
        /// </summary>
        /// <param name="index">The index at which to access the raw input data.</param>
        /// <returns>A byte of raw input data at the given index.</returns>
        public unsafe byte GetRawDataAt(int index)
        {
            if (index < 0 || index > SizeHid * Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            fixed (byte* dataPtr = &RawData)
            {
                return *(dataPtr + index);
            }
        }
    }
}
