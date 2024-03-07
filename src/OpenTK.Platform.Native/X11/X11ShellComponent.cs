using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.X11.XScreenSaver;

namespace OpenTK.Platform.Native.X11
{
    public class X11ShellComponent : IShellComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11ShellComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Shell;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal static unsafe byte* AsPtr(ReadOnlySpan<byte> span) => (byte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));

        internal IntPtr PortalDesktop;

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }

            unsafe {
                GError* error = null;
                PortalDesktop = LibGio.g_dbus_proxy_new_for_bus_sync(
                                                GBusType.G_BUS_TYPE_SESSION,
                                                GDBusProxyFlags.G_DBUS_PROXY_FLAGS_NONE,
                                                IntPtr.Zero,
                                                AsPtr("org.freedesktop.portal.Desktop"u8),
                                                AsPtr("/org/freedesktop/portal/desktop"u8),
                                                AsPtr("org.freedesktop.portal.Settings"u8),
                                                IntPtr.Zero,
                                                &error);
                if (error != null)
                {
                    Logger?.LogWarning($"Could not open settings portal: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                    LibGio.g_clear_error(&error);
                }

                // FIXME: We can'r receive signals like this as we don't have a running
                // main loop. This is an issue as we'd ideally like to avoid running a libgio
                // main-loop as that is just a lot of effort for very little gain.
                // - Noggin_bops 2024-02-25
                ulong signal = LibGio.g_signal_connect(PortalDesktop, AsPtr("g-signal"u8), &settings_portal_changed_cb, IntPtr.Zero);
            }
        }

        [UnmanagedCallersOnly]
        private static unsafe void settings_portal_changed_cb (IntPtr /* GDBusProxy* */ proxy,
                                    byte* /* const char* */ sender_name,
                                    byte* /* const char* */ signal_name,
                                    IntPtr /* GVariant* */ parameters,
                                    IntPtr userData)
        {
            Console.WriteLine("change!");
        }


        /// <inheritdoc/>
        public void AllowScreenSaver(bool allow)
        {
            if (X11.Extensions.Contains("MIT-SCREEN-SAVER"))
            {
                if (XScreenSaverQueryExtension(X11.Display, out _, out _) == false)
                {
                    Logger?.LogWarning("XScreenSaverQueryExtension failed, cannot enable/disable screen saver.");
                    return;
                }

                if (XScreenSaverQueryVersion(X11.Display, out int major, out int minor) != 1)
                {
                    Logger?.LogWarning("XScreenSaverQueryVersion failed, cannot enable/disable screen saver.");
                    return;
                }

                if (major > 1 || (major == 1 && minor >= 1))
                {
                    XScreenSaverSuspend(X11.Display, !allow);
                }
                else
                {
                    Logger?.LogWarning($"XScreenSaver 1.1 is required to enable/disable screen saver. Using version: {major}.{minor}");
                }
            }
            else
            {
                Logger?.LogWarning("Cannot enable/disable screen saver because XScreenSaver () can't be found.");
            }
        }

        /// <inheritdoc/>
        public BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            bool setAC = false;
            bool onAC = false;
            foreach (string dir in Directory.EnumerateDirectories("/sys/class/power_supply/"))
            {
                string? type = ReadPowerFile(dir, "type");
                if (type == "Mains\n")
                {
                    string? online = ReadPowerFile(dir, "online");
                    onAC = (online == "1\n");
                    setAC = true;
                    break;
                }
            }

            bool setBattery = false;
            bool charging = false;
            bool powerSaver = false;
            float? batteryPercent = null;
            float? batteryTime = null;
            foreach (string dir in Directory.EnumerateDirectories("/sys/class/power_supply/"))
            {
                string? type = ReadPowerFile(dir, "type");
                if (type != null && type == "Battery\n")
                {
                    // This is a battery.

                    // We don't care about device batteries.
                    string? scope = ReadPowerFile(dir, "scope");
                    if (scope != null && scope == "Device\n")
                        continue;

                    setBattery = true;

                    string? status = ReadPowerFile(dir, "status");
                    switch (status)
                    {
                        case "Charging\n":
                            charging = true;
                            break;
                        case "Discharging\n":
                            break;
                        case "Not charging\n":
                            break;
                        case "Full\n":
                            break;
                        default: 
                            // We couldn't read the status or the status is not one that we recognize.
                            break;
                    }

                    string? capacityStr = ReadPowerFile(dir, "capacity");
                    if (int.TryParse(capacityStr, out int capacity))
                    {
                        // FIXME: Maybe clamp to 0% - 100%?
                        batteryPercent = capacity;
                    }

                    string? energyNowStr = ReadPowerFile(dir, "energy_now");
                    string? energyFullStr = ReadPowerFile(dir, "energy_full");
                    if (energyNowStr != null && energyFullStr != null &&
                        int.TryParse(energyNowStr, out int energyNow) &&
                        int.TryParse(energyFullStr, out int energyFull))
                    {
                        batteryPercent = (energyNow / (float)energyFull) * 100;
                    }

                    string? chargeNowStr = ReadPowerFile(dir, "charge_now");
                    string? chargeFullStr = ReadPowerFile(dir, "charge_full");
                    if (chargeNowStr != null && chargeFullStr != null &&
                        int.TryParse(chargeNowStr, out int chargeNow) &&
                        int.TryParse(chargeFullStr, out int chargeFull))
                    {
                        batteryPercent = (chargeNow / (float)chargeFull) * 100;
                    }

                    string? timeToEmptyNowStr = ReadPowerFile(dir, "time_to_empty_now");
                    if (timeToEmptyNowStr != null && 
                        int.TryParse(timeToEmptyNowStr, out int timeToEmptyNow))
                    {
                        batteryTime = timeToEmptyNow;
                    }

                    // FIXME: In the case of multiple batteries, pick the highest time to empty
                    // And highest battery percentage?

                    // FIXME: For now we don't report power saver info on linux.
                    //  We can get this information from "org.freedesktop.portal.PowerProfileMonitor"
                    // using dbus.
                    powerSaver = false;

                    // FIXME: Consider the case of multiple batteries.
                    setBattery = true;
                }
            }

            if (setBattery == false)
            {
                batteryInfo = default;
                return BatteryStatus.NoSystemBattery;
            }
            else
            {
                batteryInfo.OnAC = onAC;
                batteryInfo.Charging = charging;
                batteryInfo.PowerSaver = powerSaver;
                batteryInfo.BatteryPercent = batteryPercent;
                batteryInfo.BatteryTime = batteryTime;
                return BatteryStatus.HasSystemBattery;
            }

            static string? ReadPowerFile(string name, string key)
            {
                string path = Path.Combine("/sys/class/power_supply/",  name, key);
                // Relying on exceptions here is *really* slow, so we
                // just check if the file exists before we try to read it.
                // The try-catch is to prevent a crash if the file
                // gets removed between Exists and ReadAllText.
                // - Noggin_bops 2024-02-25
                if (File.Exists(path))
                {
                    try 
                    {
                        return File.ReadAllText(path);
                    }
                    // FIXME: Are there some exceptions we should let through?
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        internal bool TryReadColorScheme(out int scheme)
        {
            scheme = -1;

            // Using libgio-2.0 to read the settings through dbus.
            // This seems to be taking around 1.2ms on my machine
            // which isn't great. We would like to listen to
            // dbus messages about a setting change and keep
            // a copy of the theme ourselves to make the function
            // properly fast.
            // - Noggin_bops 2024-02-25

            unsafe {
                GError* error = null;
                // FIXME: Better name for this gvariant
                IntPtr var = LibGio.g_variant_new(AsPtr("(ss)"u8), AsPtr("org.freedesktop.appearance"u8), AsPtr("color-scheme"u8));
                IntPtr ret = LibGio.g_dbus_proxy_call_sync(PortalDesktop, AsPtr("Read"u8), var, GDBusCallFlags.G_DBUS_CALL_FLAGS_NONE, int.MaxValue, IntPtr.Zero, &error);

                if (error != null)
                {
                    if (error->domain == LibGio.g_dbus_error_quark())
                    {
                        if (error->code == (int)GDBusError.G_DBUS_ERROR_SERVICE_UNKNOWN)
                        {
                            Logger?.LogWarning($"Portal not found: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                            LibGio.g_clear_error(&error);
                            return false;
                        }
                        else if (error->code == (int)GDBusError.G_DBUS_ERROR_UNKNOWN_METHOD)
                        {
                            Logger?.LogWarning($"Portal doesn't provide settings: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                            LibGio.g_clear_error(&error);
                            return false;
                        }
                    }

                    Logger?.LogError($"Couldn't read the color-scheme setting: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                    LibGio.g_clear_error(&error);
                    return false;
                }

                LibGio.g_variant_get(ret, AsPtr("(v)"u8), out IntPtr child);
                LibGio.g_variant_get(child, AsPtr("v"u8), out IntPtr value);

                scheme = (int)LibGio.g_variant_get_uint32(value);

                LibGio.g_clear_error(&error);
                return true;
            }
        }

        /// <inheritdoc />
        // FIXME: Maybe add a platform specific API for getting a theme name.
        public ThemeInfo GetPreferredTheme()
        {
            // Seems like we might be able to use xsettings to get some kind of data about preferred theme.
            // https://wiki.archlinux.org/title/Dark_mode_switching
            // https://specifications.freedesktop.org/xsettings-spec/xsettings-latest.html

            ThemeInfo info = default;
            if (TryReadColorScheme(out int scheme))
            {
                switch (scheme)
                {
                    case 1: // Prefer dark
                        info.Theme = AppTheme.Dark;
                        break;
                    case 2: // Prefer light
                        info.Theme = AppTheme.Light;
                        break;
                    case 0: // No preference
                    default: // Unknown values should be treated as no preference
                        info.Theme = AppTheme.NoPreference;
                        break;
                }
            }

            // FIXME: Read something like org.gnome.desktop.interface.a11y high-contrast if available.
            info.HighContrast = false;

            return info;
        }

        /// <inheritdoc />
        public unsafe SystemMemoryInfo GetSystemMemoryInformation()
        {
            int result = Sysinfo.sysinfo(out Sysinfo.sysinfo_struct sysInfo);
            if (result < 0)
            {
                int error = Marshal.GetLastPInvokeError();
                string? errorStr = Marshal.PtrToStringUTF8((IntPtr)Sysinfo.strerror(error));

                Logger?.LogError($"sysinfo() failed: '{errorStr}' (0x{error:X})");
                return default;
            }

            SystemMemoryInfo info;

            info.TotalPhysicalMemory = (long)sysInfo.totalram;
            info.AvailablePhysicalMemory = (long)sysInfo.freeram;

            return info;
        }
    }
}
