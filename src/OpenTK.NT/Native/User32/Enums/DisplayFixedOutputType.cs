namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// For fixed-resolution displays, specifies how the device can present a lower-resolution
    /// mode on a higher-resolution display.
    /// </summary>
    public enum DisplayFixedOutputType : uint
    {
        /// <summary>
        /// The display device presents a lower-resolution mode image by stretching it to fill the larger screen space.
        /// </summary>
        Stretch = 1,

        /// <summary>
        /// The display device presents a lower resolution mode image by centering it in the larger screen space.
        /// </summary>
        Center = 2,
    }
}
