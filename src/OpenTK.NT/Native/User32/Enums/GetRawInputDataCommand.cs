namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies which type of raw input data to get in a <see cref="User32.RawInput.GetRawInputData(System.IntPtr,
    /// GetRawInputDataCommand, System.IntPtr, ref uint, uint)"/> function call.
    /// </summary>
    public enum GetRawInputDataCommand : uint
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
