namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies the type of media being printed on.
    /// </summary>
    public enum PrinterMediaType : uint
    {
        /// <summary>
        /// Plain paper.
        /// </summary>
        Standard = 1,

        /// <summary>
        /// Transparent film.
        /// </summary>
        Transparency = 2,

        /// <summary>
        /// Glossy paper.
        /// </summary>
        Glossy = 3,

        /// <summary>
        /// This is the starting value for user-defined values.
        /// </summary>
        User = 256,
    }
}
