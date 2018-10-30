namespace OpenTK.OpenAL.Extensions.EXT.DoubleFormat
{
    /// <summary>
    /// Defines valid format specifiers for sound samples. This covers the additions from the multi-channel buffers
    /// extension.
    /// </summary>
    public enum DoubleBufferFormat
    {
        /// <summary>
        /// 1 Channel, double-precision floating-point data.
        /// </summary>
        Mono = 0x10012,

        /// <summary>
        /// 2 Channels, double-precision floating-point data.
        /// </summary>
        Stereo = 0x10013,
    }
}
