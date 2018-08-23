namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Defines available parameters for <see cref="ALContext.GetString(System.IntPtr,GetContextString)" />.
    /// </summary>
    public enum GetContextString
    {
        /// <summary>
        /// The specifier string for the default device.
        /// </summary>
        DefaultDeviceSpecifier = 0x1004,

        /// <summary>
        /// A list of available context extensions separated by spaces.
        /// </summary>
        Extensions = 0x1006,

        /// <summary>
        /// The name of the default capture device
        /// </summary>
        CaptureDefaultDeviceSpecifier = 0x311, // ALC_EXT_CAPTURE extension.

        /// <summary>
        /// a list of the default devices.
        /// </summary>
        DefaultAllDevicesSpecifier = 0x1012,

        // duplicates from GetContextStringList:

        /// <summary>
        /// Will only return the first Device, not a list. Use GetContextStringList.CaptureDeviceSpecifier.
        /// ALC_EXT_CAPTURE_EXT
        /// </summary>
        CaptureDeviceSpecifier = 0x310,

        /// <summary>
        /// Will only return the first Device, not a list. Use GetContextStringList.DeviceSpecifier
        /// </summary>
        DeviceSpecifier = 0x1005,

        /// <summary>
        /// Will only return the first Device, not a list. Use GetContextStringList.AllDevicesSpecifier
        /// </summary>
        AllDevicesSpecifier = 0x1013
    }
}
