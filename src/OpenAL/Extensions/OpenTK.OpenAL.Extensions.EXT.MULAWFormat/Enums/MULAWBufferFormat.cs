namespace OpenToolkit.OpenAL.Extensions.EXT.MULAWFormat
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum MULAWBufferFormat
    {
        /// <summary>
        /// 1 Channel, µ-law encoded data.
        /// </summary>
        Mono = 0x10014,

        /// <summary>
        /// 2 Channels, µ-law encoded data.
        /// </summary>
        Stereo = 0x10015,
    }
}
