using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Flags used in <see cref="User32.DeviceContext.EnumDisplaySettingsEx(string, DisplayModeSetting, out DeviceMode,
    /// EnumDisplayModes)"/> to specify which graphics modes to return.
    /// </summary>
    [Flags]
    public enum EnumDisplayModes
    {
        /// <summary>
        /// If set, the function will return all graphics modes reported by the adapter driver, regardless of
        /// monitor capabilities. Otherwise, it will only return modes that are compatible with current monitors.
        /// </summary>
        RawMode = 0x00000002,

        /// <summary>
        /// If set, the function will return graphics modes in all orientations. Otherwise, it will only return
        /// modes that have the same orientation as the one currently set for the requested display.
        /// </summary>
        RotatedMode = 0x00000004,
    }
}
