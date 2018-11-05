namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies how Image Color Management (ICM) is handled.
    /// </summary>
    public enum PrinterIcmMethod : uint
    {
        /// <summary>
        /// Specifies that ICM is disabled.
        /// </summary>
        None = 1,

        /// <summary>
        /// Specifies that ICM is handled by the system on which the page description language (PDL) data is generated.
        /// </summary>
        System = 2,

        /// <summary>
        /// Specifies that ICM is handled by the printer driver.
        /// </summary>
        Driver = 3,

        /// <summary>
        /// Specifies that ICM is handled by the destination device.
        /// </summary>
        Device = 4,

        /// <summary>
        /// This is the starting value for user-defined values.
        /// </summary>
        User = 256,
    }
}
