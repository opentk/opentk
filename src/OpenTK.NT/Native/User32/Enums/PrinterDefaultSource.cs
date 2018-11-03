namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// For a printer, specifies the paper source.
    /// </summary>
    public enum PrinterDefaultSource : short
    {
        /// <summary>
        /// Select the upper paper bin.
        /// This value is also used for the paper source for printers that only have one paper bin.
        /// </summary>
        Upper = 1,

        /// <summary>
        /// Same as <see cref="Upper"/>.
        /// </summary>
        OnlyOne = 1,

        /// <summary>
        /// Select the lower bin.
        /// </summary>
        Lower = 2,

        /// <summary>
        /// Select the middle paper bin.
        /// </summary>
        Middle = 3,

        /// <summary>
        /// Manually select the paper bin.
        /// </summary>
        Manual = 4,

        /// <summary>
        /// Select the auto envelope bin.
        /// </summary>
        Envelope = 5,

        /// <summary>
        /// Select the manual envelope bin.
        /// </summary>
        EnvelopeManual = 6,

        /// <summary>
        /// Auto-select the bin.
        /// </summary>
        Auto = 7,

        /// <summary>
        /// Select the bin with the tractor paper.
        /// </summary>
        Tractor = 8,

        /// <summary>
        /// Select the bin with the smaller paper format.
        /// </summary>
        SmallFormat = 9,

        /// <summary>
        /// Select the bin with the larger paper format.
        /// </summary>
        LargeFormat = 10,

        /// <summary>
        /// Select the bin with large capacity.
        /// </summary>
        LargeCapacity = 11,

        /// <summary>
        /// Select the cassette bin.
        /// </summary>
        Cassette = 14,

        /// <summary>
        /// Select the bin with the required form.
        /// </summary>
        FormSource = 15,

        /// <summary>
        /// Starting value for user-defined printer sources.
        /// </summary>
        User = 256,
    }
}
