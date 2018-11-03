using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="User32.DeviceContext.ChangeDisplaySettings(ref DeviceMode, DisplaySettingsChanges)"/>
    /// and <see cref="User32.DeviceContext.ChangeDisplaySettingsEx(string, IntPtr, IntPtr, DisplaySettingsChanges,
    /// IntPtr)"/> to indicate how the graphics mode should be changed.
    /// </summary>
    [Flags]
    public enum DisplaySettingsChanges : uint
    {
        /// <summary>
        /// The graphics mode for the current screen will be changed dynamically.
        /// </summary>
        Dynamic = 0,

        /// <summary>
        /// The graphics mode for the current screen will be changed dynamically and the graphics mode will be
        /// updated in the registry. The mode information is stored in the USER profile.
        /// </summary>
        UpdateRegistry = 0x00000001,

        /// <summary>
        /// The system tests if the requested graphics mode could be set.
        /// </summary>
        Test = 0x00000002,

        /// <summary>
        /// The mode is temporary in nature.<para/>
        /// If you change to and from another desktop, this mode will not be reset.
        /// </summary>
        Fullscreen = 0x00000004,

        /// <summary>
        /// The settings will be saved in the global settings area so that they will affect all users on the machine.
        /// Otherwise, only the settings for the user are modified.
        /// This flag is only valid when specified with the <see cref="UpdateRegistry"/> flag.
        /// </summary>
        Global = 0x00000008,

        /// <summary>
        /// This device will become the primary device.
        /// </summary>
        SetPrimary = 0x00000010,

        /// <summary>
        /// Not supported by <see cref="User32.DeviceContext.ChangeDisplaySettings"/>.<para/>
        /// Only supported on Vista and higher.
        /// </summary>
        VideoParameters = 0x00000020,

        /// <summary>
        /// Not supported by <see cref="User32.DeviceContext.ChangeDisplaySettings"/>.<para/>
        /// Only supported on Vista and higher.
        /// </summary>
        EnableUnsafeModes = 0x00000100,

        /// <summary>
        /// Not supported by <see cref="User32.DeviceContext.ChangeDisplaySettings"/>.<para/>
        /// Only supported on Vista and higher.
        /// </summary>
        DisableUnsafeModes = 0x00000200,

        /// <summary>
        /// The settings should be changed, even if the requested settings are the same as the current settings.
        /// </summary>
        Reset = 0x40000000,

        /// <summary>
        /// The settings will be saved in the registry, but will not take effect.
        /// This flag is only valid when specified with the <see cref="UpdateRegistry"/> flag.
        /// </summary>
        NoReset = 0x10000000
    }
}
