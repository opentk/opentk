using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

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

        internal ExecutionState OriginalExecutionState;

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            OriginalExecutionState = Win32.SetThreadExecutionState(0);

            // Set the inital theme so we can detect changes later.
            LastTheme = GetCurrentTheme();
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            Win32.SetThreadExecutionState(OriginalExecutionState | ExecutionState.Continuous);
        }

        /// <inheritdoc/>
        public void AllowScreenSaver(bool allow, string? disableReason)
        {
            Win32.SetThreadExecutionState(ExecutionState.Continuous | (allow ? 0 : ExecutionState.DisplayRequired));
        }

        /// <inheritdoc/>
        public bool IsScreenSaverAllowed()
        {
            ExecutionState state = Win32.SetThreadExecutionState(0);
            return state.HasFlag(ExecutionState.DisplayRequired) == false;
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

                // Redraw the window frame to make the change appear.
                // We assume this is only needed on windows 10.
                // Triggering the redraw involves changing either the
                // size of the window, if it is normal. Otherwise
                // we need to restore the window and maximize it again.
                // This sends unecessary events to the user which is
                // not desirable, but is currently the only solution
                // to the problem.
                // - Noggin_bops 2024-06-05
                if (OperatingSystem.IsWindowsVersionAtLeast(10, 0, 22000) == false)
                {
                    TriggerRedrawFrame(hwnd);
                }
            }

            static void TriggerRedrawFrame(HWND hwnd)
            {
                // Original code comes from: https://stackoverflow.com/a/78269906
                // Had to modify the non-maximized case as it was shrinking
                // the window size with every call to this function.
                // - Noggin_bops 2024-06-05
                if (Win32.IsWindowVisible(hwnd.HWnd) && Win32.IsIconic(hwnd.HWnd) == false)
                {
                    Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT rect);

                    if (Win32.IsZoomed(hwnd.HWnd))
                    {
                        Win32.WINDOWPLACEMENT placement = default;
                        unsafe { placement.length = (uint)sizeof(Win32.WINDOWPLACEMENT); }
                        Win32.GetWindowPlacement(hwnd.HWnd, ref placement);

                        Win32.RECT oldrect = placement.rcNormalPosition;

                        placement.rcNormalPosition = rect;
                        placement.rcNormalPosition.right -= 1;
                        Win32.SetWindowPlacement(hwnd.HWnd, placement);

                        // Restore and then re-maximize the window. Don't update in-between.
                        Win32.LockWindowUpdate(hwnd.HWnd);
                        Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.ShowNormal);
                        Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.ShowMaximized);
                        Win32.LockWindowUpdate(0);

                        placement.rcNormalPosition = oldrect;
                        Win32.SetWindowPlacement(hwnd.HWnd, placement);
                    }
                    else
                    {
                        Win32.SetWindowPos(hwnd.HWnd, 0, 0, 0, rect.Width - 1, rect.Height, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoRedraw | SetWindowPosFlags.NoSendChangingEvent);
                        Win32.SetWindowPos(hwnd.HWnd, 0, 0, 0, rect.Width, rect.Height, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoSendChangingEvent);
                    }
                }
            }
        }

        /// <summary>
        /// Works on Windows 11 only.
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
        /// Works on Windows 11 only.
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

        /// <summary>
        /// Window corner preference options.
        /// </summary>
        public enum CornerPreference
        {
            /// <summary>
            /// Let windows decide if the window corners are rounded.
            /// </summary>
            Default = DWMWindowCornerPreference.Default,

            /// <summary>
            /// Do not round the corners of the window.
            /// </summary>
            DoNotRound = DWMWindowCornerPreference.DoNotRound,

            /// <summary>
            /// Round the corners of the window.
            /// </summary>
            Round = DWMWindowCornerPreference.Round,

            /// <summary>
            /// Round the corners of the window, with a smaller radius.
            /// </summary>
            RoundSmall = DWMWindowCornerPreference.RoundSmall,
        }

        /// <summary>
        /// Works on Windows 11 only.
        /// Sets if the window should have rounded corners or not.
        /// </summary>
        public void SetWindowCornerPreference(WindowHandle handle, CornerPreference preference)
        {
            HWND hwnd = handle.As<HWND>(this);

            uint preferenceUint = (uint)(DWMWindowCornerPreference)preference;

            int result = Win32.DwmSetWindowAttribute(hwnd.HWnd, DWMWindowAttribute.WindowCornerPreference, ref preferenceUint, sizeof(int));
            if (result != 0)
            {
                Logger?.LogWarning($"Failed to set caption color. DwmSetWindowAttribute(DWMWA_WINDOW_CORNER_PREFERENCE) failed with HRESULT: 0x{result:X}");
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
