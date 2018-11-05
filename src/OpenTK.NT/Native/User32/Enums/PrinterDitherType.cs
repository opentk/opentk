namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// For printers, specifies types of dithering.
    /// </summary>
    public enum PrinterDitherType : uint
    {
        /// <summary>
        /// No dithering.
        /// </summary>
        None = 1,

        /// <summary>
        /// Dithering with a coarse brush.
        /// </summary>
        Coarse = 2,

        /// <summary>
        /// Dithering with a fine brush.
        /// </summary>
        Fine = 3,

        /// <summary>
        /// Line art dithering, a special dithering method that produces well defined borders between black, white,
        /// and gray scaling. It is not suitable for images that include continuous graduations in intensity and hue,
        /// such as scanned photographs.
        /// </summary>
        LineArt = 4,

        /// <summary>
        /// Error diffusion dithering.<para/>
        /// Only supported on Windows 95, 98, and Millennium Edition.
        /// </summary>
        ErrorDiffusion = 5,

        /// <summary>
        /// Reserved. Do not use.
        /// </summary>
        Reserved6 = 6,

        /// <summary>
        /// Reserved. Do not use.
        /// </summary>
        Reserved7 = 7,

        /// <summary>
        /// Reserved. Do not use.
        /// </summary>
        Reserved8 = 8,

        /// <summary>
        /// Reserved. Do not use.
        /// </summary>
        Reserved9 = 9,

        /// <summary>
        /// Device does gray scaling.
        /// </summary>
        Grayscale = 10,

        /// <summary>
        /// This is the starting value for user-defined values.
        /// </summary>
        User = 256,
    }
}
