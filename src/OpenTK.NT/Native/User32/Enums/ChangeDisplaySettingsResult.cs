using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="User32.DeviceContext.ChangeDisplaySettings(ref DeviceMode, DisplaySettingsChanges)"/>
    /// and <see cref="User32.DeviceContext.ChangeDisplaySettingsEx(string, IntPtr, IntPtr, DisplaySettingsChanges,
    /// IntPtr)"/> to indicate the result of the function call.
    /// </summary>
    public enum ChangeDisplaySettingsResult : int
    {
        /// <summary>
        /// The settings change was successful.
        /// </summary>
        Successful = 0,

        /// <summary>
        /// The computer must be restarted for the graphics mode to work.
        /// </summary>
        Restart = 1,

        /// <summary>
        /// The display driver failed the specified graphics mode.
        /// </summary>
        Failed = -1,

        /// <summary>
        /// The graphics mode is not supported.
        /// </summary>
        BadMode = -2,

        /// <summary>
        /// Unable to write settings to the registry.
        /// </summary>
        NotUpdated = -3,

        /// <summary>
        /// An invalid set of flags was passed in.
        /// </summary>
        BadFlags = -4,

        /// <summary>
        /// An invalid parameter was passed in. This can include an invalid flag or combination of flags.
        /// </summary>
        BadParam = -5,

        /// <summary>
        /// The settings change was unsuccessful because the system is DualView capable.
        /// Only supported on XP and higher.
        /// </summary>
        BadDualView = -6,
    }
}
