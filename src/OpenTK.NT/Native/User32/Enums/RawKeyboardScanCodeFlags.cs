namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Flags for scan code information.
    /// </summary>
    public enum RawKeyboardScanCodeFlags : ushort
    {
        /// <summary>
        /// The key is down.
        /// </summary>
        Make = 0x0,

        /// <summary>
        /// The key is up.
        /// </summary>
        Break = 0x1,

        /// <summary>
        /// The scan code has the E0 prefix.
        /// </summary>
        E0 = 0x2,

        /// <summary>
        /// The scan code has the E1 prefix.
        /// </summary>
        E1 = 0x4,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        TermsrvSetLed = 0x8,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        TermsrvShadow = 0x10
    }
}
