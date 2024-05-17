using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    /// <summary>
    /// Win32 implementation of <see cref="IShellComponent"/>.
    /// </summary>
    public class ShellComponent : IShellComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32ShellComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Shell;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Shell)
            {
                throw new Exception("ShellComponent can only initialize the Shell component.");
            }

            // Set the inital theme so we can detect changes later.
            LastTheme = GetCurrentTheme();
        }

        /// <inheritdoc/>
        public void AllowScreenSaver(bool allow)
        {
            Win32.SetThreadExecutionState(ExecutionState.Continuous | (allow ? 0 : ExecutionState.DisplayRequired));
        }

        /// <inheritdoc/>
        public BatteryStatus GetBatteryInfo(out BatteryInfo info)
        {
            bool success = Win32.GetSystemPowerStatus(out Win32.SystemPowerStatus systemPowerStatus);

            if (success == false)
            {
                // FIXME: Should we return BatteryStatus.Unknown?
                // return null;
                throw new Win32Exception();
            }

            if (systemPowerStatus.BatteryFlag.HasFlag(BatteryFlags.NoSystemBattery))
            {
                info = default;
                return BatteryStatus.NoSystemBattery;
            }

            // FIXME: Maybe express some of the uncertainty the windows api exposes
            // e.g. ACLineStatus can be unkown.
            info.OnAC = systemPowerStatus.ACLineStatus == ACLineStatus.Online;
            info.Charging = systemPowerStatus.BatteryFlag.HasFlag(BatteryFlags.Charging);
            info.PowerSaver = systemPowerStatus.SystemStatusFlag.HasFlag(SystemStatusFlags.BatterySaver);
            info.BatteryPercent = systemPowerStatus.BatteryLifePercent;
            info.BatteryTime = systemPowerStatus.BatteryLifeTime != -1 ? systemPowerStatus.BatteryLifeTime : null;
            return BatteryStatus.HasSystemBattery;
        }

        private static ThemeInfo GetCurrentTheme()
        {
            ThemeInfo info;

            {
                Win32.HIGHCONTRAST highcontrast = default;
                highcontrast.cbSize = (uint)Marshal.SizeOf<Win32.HIGHCONTRAST>();

                bool success = Win32.SystemParametersInfo(SPI.GetHighContrast, highcontrast.cbSize, ref highcontrast, SPIF.None);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                info.HighContrast = highcontrast.dwFlags.HasFlag(HCF.HighContrastOn);
            }

            if (ShouldAppsUseDarkMode())
            {
                info.Theme = AppTheme.Dark;
            }
            else
            {
                info.Theme = AppTheme.Light;
            }

            return info;

            // FIXME: This is an undocumented windows API
            // This might break as the ordinal might change with time which isn't great...
            // The alternative is some winrt weirdness going on in this article:
            // https://learn.microsoft.com/en-us/windows/apps/desktop/modernize/apply-windows-themes
            // There is a registry key, but that seems not that nice, though maybe as a fallback...
            // - Noggin_bops 2023-01-18
            [DllImport("uxtheme.dll", EntryPoint = "#132")]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool ShouldAppsUseDarkMode();
        }

        private static ThemeInfo LastTheme;

        internal static void CheckPreferredThemeChange()
        {
            ThemeInfo theme = GetCurrentTheme();

            if (theme != LastTheme)
            {
                EventQueue.Raise(null, PlatformEventType.ThemeChange, new ThemeChangeEventArgs(theme));

                LastTheme = theme;
            }
        }

        /// <inheritdoc/>
        public ThemeInfo GetPreferredTheme()
        {
            return GetCurrentTheme();
        }

        // FIXME: Move this to the window component itself?
        // FIXME: DWMWA_BORDER_COLOR? DWMWA_WINDOW_CORNER_PREFERENCE?
        // FIXME: It seems like the window titlebar doesn't get changed
        // immediately, you need to minimize and restore the window for this to work...
        /// <summary>
        /// Sets the <c>DWMWA_USE_IMMERSIVE_DARK_MODE</c> flag on the window causing the titlebar be rendered in dark mode colors.
        /// </summary>
        /// <param name="handle">Handle to a window.</param>
        /// <param name="useImmersiveDarkMode">Whether to use immersive dark mode or not.</param>
        public void SetImmersiveDarkMode(WindowHandle handle, bool useImmersiveDarkMode)
        {
            HWND hwnd = handle.As<HWND>(this);

            unsafe
            {
                // This is documented to only work on windows 11 but works fine on at least windows 10.0.19045 Build 19045
                // - Noggin_bops 2023-01-17
                int value = useImmersiveDarkMode ? 1 : 0;
                int result = Win32.DwmSetWindowAttribute(hwnd.HWnd, DWMWindowAttribute.UseImmersiveDarkMode, &value, sizeof(int));
                if (result != 0)
                {
                    Logger?.LogWarning($"Could not set immersive dark mode. DwmSetWindowAttribute(DWMWA_USE_IMMERSIVE_DARK_MODE) failed with HRESULT: 0x{result:X}");
                }
            }
        }

        /// <summary>
        /// Sets the color of the windows caption bar text.
        /// </summary>
        public void SetCaptionTextColor(WindowHandle handle, Color3<Rgb> color)
        {
            HWND hwnd = handle.As<HWND>(this);

            uint colorref = ((uint)(color.Z * 255)) << 16 | ((uint)(color.Y * 255)) << 8 | ((uint)(color.X * 255));

            int result = Win32.DwmSetWindowAttribute(hwnd.HWnd, DWMWindowAttribute.TextColor, ref colorref, sizeof(uint));
            if (result != 0)
            {
                Logger?.LogWarning($"Failed to set caption text color. DwmSetWindowAttribute(DWMWA_TEXT_COLOR) failed with HRESULT: 0x{result:X}");
            }
        }

        /// <summary>
        /// Sets the color of the windows caption bar.
        /// </summary>
        public void SetCaptionColor(WindowHandle handle, Color3<Rgb> color)
        {
            HWND hwnd = handle.As<HWND>(this);

            uint colorref = ((uint)(color.Z * 255)) << 16 | ((uint)(color.Y * 255)) << 8 | ((uint)(color.X * 255));

            int result = Win32.DwmSetWindowAttribute(hwnd.HWnd, DWMWindowAttribute.CaptionColor, ref colorref, sizeof(uint));
            if (result != 0)
            {
                Logger?.LogWarning($"Failed to set caption color. DwmSetWindowAttribute(DWMWA_CAPTION_COLOR) failed with HRESULT: 0x{result:X}");
            }
        }

        /// <inheritdoc/>
        public unsafe SystemMemoryInfo GetSystemMemoryInformation()
        {
            Win32.MEMORYSTATUSEX status = default;
            status.dwLength = (uint)sizeof(Win32.MEMORYSTATUSEX);

            bool success = Win32.GlobalMemoryStatusEx(ref status);
            if (success)
            {
                SystemMemoryInfo info;
                info.TotalPhysicalMemory = (long)status.ullTotalPhys;
                info.AvailablePhysicalMemory = (long)status.ullAvailPhys;

                success = Win32.GetPhysicallyInstalledSystemMemory(out ulong systemMemory);
                if (success)
                {
                    info.TotalPhysicalMemory = (long)systemMemory * 1024;
                }

                return info;
            }
            else
            {
                throw new Win32Exception();
            }
        }

        // FIXME: Add API for telling windows to not shut down because of unsaved work.
    }
}
