namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies duplex (double-sided) printing for duplex-capable printers.
    /// </summary>
    public enum PrinterDuplex : short
    {
        /// <summary>
        /// Print single-sided.
        /// </summary>
        SimpleX = 1,

        /// <summary>
        /// Print double-sided, using long edge binding.
        /// </summary>
        Vertical = 2,

        /// <summary>
        /// Print double-sided, using short edge binding.
        /// </summary>
        Horizontal = 3,
    }
}
