namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="User32.DeviceContext.EnumDisplaySettings(string, DisplayModeSetting, out DeviceMode)"/> and
    /// <see cref="User32.DeviceContext.EnumDisplaySettingsEx(string, DisplayModeSetting, out DeviceMode,
    /// EnumDisplayModes)"/> to specify which information should be retrieved.
    /// </summary>
    public enum DisplayModeSetting : uint
    {
        /// <summary>
        /// Retrieve the current settings for the display device.
        /// </summary>
        CurrentSettings = unchecked((uint)(-1)),

        /// <summary>
        /// Retrieve the settings for the display device that are currently stored in the registry.
        /// </summary>
        RegistrySettings = unchecked((uint)(-2))
    }
}
