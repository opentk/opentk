using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
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
