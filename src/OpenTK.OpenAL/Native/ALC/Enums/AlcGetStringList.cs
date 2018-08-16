namespace OpenTK.OpenAL.Native
{
    /// <summary>
    /// Defines available parameters for <see cref="Alc.GetString(System.IntPtr,OpenTK.OpenAL.Native.AlcGetStringList)" />.
    /// </summary>
    public enum AlcGetStringList
    {
        /// <summary>
        /// The name of the specified capture device, or a list of all available capture devices if no capture device is
        /// specified. ALC_EXT_CAPTURE_EXT
        /// </summary>
        CaptureDeviceSpecifier = 0x310,

        /// <summary>
        /// The specifier strings for all available devices. ALC_ENUMERATION_EXT
        /// </summary>
        DeviceSpecifier = 0x1005,

        /// <summary>
        /// The specifier strings for all available devices. ALC_ENUMERATE_ALL_EXT
        /// </summary>
        AllDevicesSpecifier = 0x1013
    }
}
