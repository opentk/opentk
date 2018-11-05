namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies which color matching method, or intent, is used by default.
    /// </summary>
    public enum PrinterIcmIntent : uint
    {
        /// <summary>
        /// Optimize for color saturation.<para/>
        /// This value is the most appropriate choice for business graphs when dithering is not desired.
        /// </summary>
        Saturate = 1,

        /// <summary>
        /// Optimize for color contrast.<para/>
        /// This value is the most appropriate choice for scanned or photographic images when dithering is desired.
        /// </summary>
        Contrast = 2,

        /// <summary>
        /// Optimize to match the exact color requested.<para/>
        /// This value is most appropriate for use with business logos
        /// or other images when an exact color match is desired.
        /// </summary>
        Colorimetric = 3,

        /// <summary>
        /// Optimize to match the exact color requested without white point mapping.<para/>
        /// This value is most appropriate for use with proofing.
        /// </summary>
        AbsoluteColorimetric = 4,

        /// <summary>
        /// This is the starting value for user-defined values.
        /// </summary>
        User = 256,
    }
}
