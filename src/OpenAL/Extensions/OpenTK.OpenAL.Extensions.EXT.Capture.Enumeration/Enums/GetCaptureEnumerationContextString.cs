namespace OpenToolkit.OpenAL.Extensions.EXT.Capture.Enumeration
{
    /// <summary>
    /// Defines available parameters for <see cref="ICaptureContextState.GetContextProperty(Device*,GetCaptureEnumerationContextString, int, void*)" />.
    /// </summary>
    public enum GetCaptureEnumerationContextString
    {
        /// <summary>
        /// Gets the name of the default capture device
        /// </summary>
        DefaultCaptureDeviceSpecifier = 0x311,

        /// <summary>
        /// Gets the first available capture device specifier.
        /// </summary>
        CaptureDeviceSpecifier = 0x310,
    }
}
