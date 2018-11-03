namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies the type of pixel data.
    /// </summary>
    public enum PixelFormatDescriptorPixelTypes : byte
    {
        /// <summary>
        /// RGBA pixels. Each pixel has four components in this order: red, green, blue, and alpha.
        /// </summary>
        Rgba = 0,

        /// <summary>
        /// Color-index pixels. Each pixel uses a color-index value.
        /// </summary>
        Indexed = 1
    }
}
