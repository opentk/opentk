using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Specifies which type of raw input data to get in a
    /// <see cref="User32.RawInput.GetRawInputData(System.IntPtr, GetRawInputDataCommand, out RawInput, ref UINT, UINT)"/>
    /// function call.
    /// </summary>
    public enum GetRawInputDataCommand : UINT
    {
        /// <summary>
        /// Get the raw data from the <see cref="RawInput"/> structure.
        /// </summary>
        Input = 0x10000003,

        /// <summary>
        /// Get the header information from the <see cref="RawInput"/> structure.
        /// </summary>
        Header = 0x10000005
    }
}
