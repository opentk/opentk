using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface for interacting with operating system features.
    /// </summary>
    public interface IShellComponent : IPalComponent
    {
        // FIXME: Add a way to check if the screensaver is active or not.

        /// <summary>
        /// Sets whether or not a screensaver is allowed to draw on top of the window.
        /// For games with long cutscenes it would be appropriate to set this to <c>false</c>,
        /// while tools that act like normal applications should set this to <c>true</c>.
        /// By default this setting is untouched.
        /// </summary>
        /// <param name="allow">Whether to allow screensavers to appear while the application is running.</param>
        void AllowScreenSaver(bool allow);

        /// <summary>
        /// Gets the battery status of the computer.
        /// </summary>
        /// <param name="batteryInfo">The battery status of the computer,
        /// this is only filled with values when <see cref="BatteryStatus.HasSystemBattery"/> is returned.</param>
        /// <returns>Whether the computer has a battery or not, or if this function failed.</returns>
        BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo);

        /// <summary>
        /// Gets the user preference for application theme.
        /// </summary>
        /// <returns>The user set preferred theme.</returns>
        // FIXME: Should we report a theme name?
        // or another function for that?
        ThemeInfo GetPreferredTheme();

        /// <summary>
        /// Gets information about the memory of the device and the current status.
        /// </summary>
        /// <returns>The memory info.</returns>
        SystemMemoryInfo GetSystemMemoryInformation();
    }
}
