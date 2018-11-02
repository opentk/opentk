namespace OpenToolkit.NT.Native.User32.Enums
{
    /// <summary>
    /// Specifies how TrueType fonts should be printed.
    /// </summary>
    public enum PrinterTrueTypeOption : short
    {
        /// <summary>
        /// Device will print TrueType fonts as graphics.
        /// </summary>
        Bitmap = 1,

        /// <summary>
        /// Device will download TrueType fonts.
        /// </summary>
        Download = 2,

        /// <summary>
        /// Device will substitute device fonts for TrueType fonts.
        /// </summary>
        SubstituteDevice = 3,

        /// <summary>
        /// Downloads TrueType fonts as outline soft fonts.
        /// </summary>
        DownloadOutline = 4,
    }
}
