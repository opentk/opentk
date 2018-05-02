namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Defines available parameters for <see cref="Alc.GetString(System.IntPtr,OpenTK.OpenAL.Native.AlcGetString)" />.
    /// </summary>
    public enum AlcGetString
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

        // duplicates from AlcGetStringList:

        /// <summary>
        /// Will only return the first Device, not a list. Use AlcGetStringList.CaptureDeviceSpecifier.
        /// ALC_EXT_CAPTURE_EXT
        /// </summary>
        CaptureDeviceSpecifier = 0x310,

        /// <summary>
        /// Will only return the first Device, not a list. Use AlcGetStringList.DeviceSpecifier
        /// </summary>
        DeviceSpecifier = 0x1005,

        /// <summary>
        /// Will only return the first Device, not a list. Use AlcGetStringList.AllDevicesSpecifier
        /// </summary>
        AllDevicesSpecifier = 0x1013
    }
}