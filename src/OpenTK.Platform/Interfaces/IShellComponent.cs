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
    /// <seealso cref="Toolkit.Shell"/>
    public interface IShellComponent : IPalComponent
    {
        /// <summary>
        /// Sets whether or not a screensaver is allowed to draw on top of the window.
        /// For games with long cutscenes it would be appropriate to set this to <see langword="false"/>,
        /// while tools that act like normal applications should set this to <see langword="true"/>.
        /// By default this setting is untouched.
        /// </summary>
        /// <param name="allow">Whether to allow screensavers to appear while the application is running.</param>
        /// <param name="disableReason">
        /// A reason for why the screen saver is disabled.
        /// This string should both contain the reason why the screen saver is disabed as well as the name of the
        /// application so the user knows which application is preventing the screen saver from running.
        /// If <see langword="null"/> is sent the following default message will be sent:
        /// <code>$"{ApplicationName} is is preventing screen saver."</code>
        /// </param>
        /// <seealso cref="IsScreenSaverAllowed"/>
        void AllowScreenSaver(bool allow, string? disableReason);

        /// <summary>
        /// Gets if the screen saver is allowed to run or not.
        /// </summary>
        /// <returns>If the screen saver is allowed to run.</returns>
        /// <seealso cref="AllowScreenSaver(bool, string?)"/>
        bool IsScreenSaverAllowed();

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
        /// <seealso cref="ThemeChangeEventArgs"/>
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
