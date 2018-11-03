namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// For printers, specifies the printer resolution.<para/>
    /// Either specify one of these pre-defined values or specify a positive device-dependent resolution in DPI.
    /// </summary>
    public enum PrinterPrintQuality : short
    {
        /// <summary>
        /// Draft-resolution printouts.
        /// </summary>
        Draft = -1,

        /// <summary>
        /// Low-resolution printouts.
        /// </summary>
        Low = -2,

        /// <summary>
        /// Medium-resolution printouts.
        /// </summary>
        Medium = -3,

        /// <summary>
        /// High-resolution printouts.
        /// </summary>
        High = -4,
    }
}
