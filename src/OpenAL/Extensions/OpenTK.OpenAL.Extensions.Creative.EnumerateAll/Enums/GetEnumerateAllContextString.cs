namespace OpenToolkit.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Defines available parameters for <see cref="ALContext.GetString(System.IntPtr,GetEnumerateAllContextString)" />.
    /// </summary>
    public enum GetEnumerateAllContextString
    {
        /// <summary>
        /// Gets the specifier for the default device.
        /// </summary>
        DefaultAllDevicesSpecifier = 0x1012,

        /// <summary>
        /// Gets the specifier of the first available device.
        /// </summary>
        AllDevicesSpecifier = 0x1013
    }
}
