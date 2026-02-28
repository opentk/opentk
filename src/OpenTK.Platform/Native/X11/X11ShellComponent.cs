using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core;
using OpenTK.Core.Native;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.X11.LibX11;
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

        internal GCHandle ComponentGCHandle;

        internal bool HasMITScreenSaver = false;
        internal Version MITScreenSaverVersion;
        internal bool HasScreenSaverSuspend = false;
        internal bool IsSuspendingScreenSaver = false;

        internal IntPtr PortalDesktop;

        internal ulong PortalDesktopGSignal;

        // FIXME: Move this to X11WindowComponent. - Noggin_bops 2024-12-13
        internal static IntPtr GlibMainLoop;
        
        internal IntPtr GVariant_org_freedesktop_appearance_color_scheme;

        internal IntPtr GVariant_org_gnome_desktop_a11y_interface_high_contrast;

        internal IntPtr GPowerProfileMoniforInstance;

        internal IntPtr UPower;
        internal IntPtr UPowerDisplayDevice;

        internal static IntPtr GSettingsPtr;
        internal static ulong GSettingsDoubleClickSignal;
        internal bool GSettingsHasDoubleClickProperty = false;
        

        // FIXME: Make this non-static by sending this object through a GCHandle
        // to the dbus callback.
        internal static ThemeInfo CurrentTheme;

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            ComponentGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);

            if (X11.Extensions.Contains("MIT-SCREEN-SAVER"))
            {
                if (XScreenSaverQueryExtension(X11.Display, out int a, out int b))
                {
                    if (XScreenSaverQueryVersion(X11.Display, out int major, out int minor) == 1)
                    {
                        HasMITScreenSaver = true;
                        MITScreenSaverVersion = new Version(major, minor);
                        if (major > 1 || (major == 1 && minor >= 1))
                        {
                            HasScreenSaverSuspend = true;
                        }
                        else
                        {
                            Logger?.LogWarning($"XScreenSaver 1.1 is required to enable/disable screen saver. Using version: {major}.{minor}");
                        }
                    }
                    else
                    {
                        Logger?.LogWarning($"XScreenSaverQueryVersion failed, cannot enable/disable screen saver.");
                    }
                }
                else
                {
                    Logger?.LogWarning("XScreenSaverQueryExtension failed, cannot enable/disable screen saver.");
                }
            }
            else
            {
                Logger?.LogWarning("Cannot enable/disable screen saver because XScreenSaver() can't be found.");
            }

            GlibMainLoop = LibGio.g_main_loop_new(IntPtr.Zero, 0);

            GPowerProfileMoniforInstance = LibGio.g_power_profile_monitor_dup_default();

            // We take a ref to this GVariant so that it's not a "floating reference" anymore.
            // This means we can reuse this GVariant in calls to g_dbus_proxy_call_sync.
            // - Noggin_bops 2024-07-22
            GVariant_org_freedesktop_appearance_color_scheme = LibGio.g_variant_ref_sink(LibGio.g_variant_new(Utils.AsPtr("(ss)"u8), Utils.AsPtr("org.freedesktop.appearance"u8), Utils.AsPtr("color-scheme"u8)));

            GVariant_org_gnome_desktop_a11y_interface_high_contrast = LibGio.g_variant_ref_sink(LibGio.g_variant_new(Utils.AsPtr("(ss)"u8), Utils.AsPtr("org.gnome.desktop.a11y.interface"u8), Utils.AsPtr("high-contrast"u8)));
            
            GError* error = null;
            PortalDesktop = LibGio.g_dbus_proxy_new_for_bus_sync(
                                            GBusType.G_BUS_TYPE_SESSION,
                                            GDBusProxyFlags.G_DBUS_PROXY_FLAGS_NONE,
                                            IntPtr.Zero,
                                            Utils.AsPtr("org.freedesktop.portal.Desktop"u8),
                                            Utils.AsPtr("/org/freedesktop/portal/desktop"u8),
                                            Utils.AsPtr("org.freedesktop.portal.Settings"u8),
                                            IntPtr.Zero,
                                            &error);
            if (error != null)
            {
                Logger?.LogWarning($"Could not open settings portal: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                LibGio.g_clear_error(&error);
            }

            PortalDesktopGSignal = LibGio.g_signal_connect(PortalDesktop, Utils.AsPtr("g-signal"u8), &settings_portal_changed_cb, IntPtr.Zero);

            if (TryReadColorScheme(out int scheme))
            {
                switch (scheme)
                {
                    case 1: // Prefer dark
                        CurrentTheme.Theme = AppTheme.Dark;
                        break;
                    case 2: // Prefer light
                        CurrentTheme.Theme = AppTheme.Light;
                        break;
                    case 0: // No preference
                    default: // Unknown values should be treated as no preference
                        CurrentTheme.Theme = AppTheme.NoPreference;
                        break;
                }
            }
            else
            {
                CurrentTheme.Theme = AppTheme.NoPreference;
            }

            if (TryReadHighContrast(out bool highContrast))
            {
                CurrentTheme.HighContrast = highContrast;
            }
            else
            {
                CurrentTheme.HighContrast = false;
            }

            unsafe
            {
                GSettingsPtr = LibGio.g_settings_new(Utils.AsPtr("org.gnome.desktop.peripherals.mouse"u8));
                if (GSettingsPtr != 0)
                {
                    LibGio.g_object_get(GSettingsPtr, Utils.AsPtr("settings-schema"u8), out IntPtr schema, null);
                    var keysPtr = LibGio.g_settings_schema_list_keys(schema);
                    uint kcount;
                    for (kcount = 0; keysPtr[kcount] != null; kcount++) { }
                    string[] keys = MarshalTk.StringArrayPtrToStringArrayUTF8((nint)keysPtr, kcount);
                    GSettingsHasDoubleClickProperty = keys.Contains("double-click");
                    if (GSettingsHasDoubleClickProperty)
                    {
                        GSettingsDoubleClickSignal = LibGio.g_signal_connect(GSettingsPtr, Utils.AsPtr("changed::double-click"u8), &gsettings_double_click_time_changed_cb, (nint)ComponentGCHandle);
                        Logger?.LogDebug($"Double click signal: {GSettingsDoubleClickSignal}");
                    }
                    else
                    {
                        Logger?.LogWarning($"gsettings schema 'org.gnome.desktop.peripherals.mouse' doesn't contain the key 'double-click', will use the default double-click interval of {400}ms.");
                    }
                    LibGio.g_strfreev(keysPtr);
                }
                else
                {
                    Logger?.LogWarning($"Could not open gsettings schema 'org.gnome.desktop.peripherals.mouse', will not be able to get user configured double-click interval.");
                }
            }
        
            UPower = LibGio.g_dbus_proxy_new_for_bus_sync(
                GBusType.G_BUS_TYPE_SYSTEM,
                GDBusProxyFlags.G_DBUS_PROXY_FLAGS_NONE,
                IntPtr.Zero,
                Utils.AsPtr("org.freedesktop.UPower"u8),
                Utils.AsPtr("/org/freedesktop/UPower"u8),
                Utils.AsPtr("org.freedesktop.UPower"u8),
                IntPtr.Zero,
                &error);
            if (error != null)
            {
                Logger?.LogWarning($"Could not open UPower: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                LibGio.g_clear_error(&error);
            }

            UPowerDisplayDevice = LibGio.g_dbus_proxy_new_for_bus_sync(
                GBusType.G_BUS_TYPE_SYSTEM,
                GDBusProxyFlags.G_DBUS_PROXY_FLAGS_NONE,
                IntPtr.Zero,
                Utils.AsPtr("org.freedesktop.UPower"u8),
                Utils.AsPtr("/org/freedesktop/UPower/devices/DisplayDevice"u8),
                Utils.AsPtr("org.freedesktop.UPower.Device"u8),
                IntPtr.Zero,
                &error);
            if (error != null)
            {
                Logger?.LogWarning($"Could not open UPower display device: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                LibGio.g_clear_error(&error);
            }
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            LibGio.g_object_unref(UPowerDisplayDevice);
            LibGio.g_object_unref(UPower);

            LibGio.g_signal_handler_disconnect(PortalDesktop, PortalDesktopGSignal);

            LibGio.g_object_unref(PortalDesktop);

            LibGio.g_variant_unref(GVariant_org_gnome_desktop_a11y_interface_high_contrast);
            LibGio.g_variant_unref(GVariant_org_freedesktop_appearance_color_scheme);

            LibGio.g_object_unref(GPowerProfileMoniforInstance);

            if (GSettingsPtr != 0)
            {
                if (GSettingsDoubleClickSignal != 0)
                {
                    LibGio.g_signal_handler_disconnect(GSettingsPtr, GSettingsDoubleClickSignal);
                }
                LibGio.g_object_unref(GSettingsPtr);
            }

            LibGio.g_main_loop_quit(GlibMainLoop);
            LibGio.g_main_loop_unref(GlibMainLoop);

            ComponentGCHandle.Free();
        }

        private unsafe struct SettingsChangedParameters {
            public byte* Namespace;
            public byte* Key;
            public IntPtr Value;
        }

        [UnmanagedCallersOnly]
        private static unsafe void settings_portal_changed_cb(IntPtr /* GDBusProxy* */ proxy,
                                    byte* /* const char* */ sender_name,
                                    byte* /* const char* */ signal_name,
                                    IntPtr /* GVariant* */ parameters,
                                    IntPtr userData)
        {
            Debug.Assert(Utils.ToSpan(signal_name).SequenceEqual("SettingChanged"u8));

            SettingsChangedParameters args;
            LibGio.g_variant_get(parameters, Utils.AsPtr("(ssv)"u8), 
                out Unsafe.AsRef<IntPtr>(&args.Namespace),
                out Unsafe.AsRef<IntPtr>(&args.Key),
                out Unsafe.AsRef<IntPtr>(&args.Value));

            ReadOnlySpan<byte> @namespace = Utils.ToSpan(args.Namespace);
            ReadOnlySpan<byte> key = Utils.ToSpan(args.Key);
            if (@namespace.SequenceEqual("org.freedesktop.appearance"u8) &&
                key.SequenceEqual("color-scheme"u8))
            {
                uint scheme = LibGio.g_variant_get_uint32(args.Value);

                AppTheme newTheme;
                switch (scheme)
                {
                    case 1: // Prefer dark
                        newTheme = AppTheme.Dark;
                        break;
                    case 2: // Prefer light
                        newTheme = AppTheme.Light;
                        break;
                    case 0: // No preference
                    default: // Unknown values should be treated as no preference
                        newTheme = AppTheme.NoPreference;
                        break;
                }

                if (newTheme != CurrentTheme.Theme)
                {
                    CurrentTheme.Theme = newTheme;
                    EventQueue.Raise(null, PlatformEventType.ThemeChange, new ThemeChangeEventArgs(CurrentTheme));
                }
            }
            else if (@namespace.SequenceEqual("org.gnome.desktop.a11y.interface"u8) &&
                key.SequenceEqual("high-contrast"u8))
            {
                bool highContrast = LibGio.g_variant_get_boolean(args.Value) != 0;
                if (CurrentTheme.HighContrast != highContrast)
                {
                    CurrentTheme.HighContrast = highContrast;
                    EventQueue.Raise(null, PlatformEventType.ThemeChange, new ThemeChangeEventArgs(CurrentTheme));
                }
            }

            LibGio.g_variant_unref(args.Value);
        }

        [UnmanagedCallersOnly]
        private static unsafe void gsettings_double_click_time_changed_cb(IntPtr /* GSettings* */ self, byte* key, IntPtr userData)
        {
            GCHandle componentHandle = (GCHandle)userData;
            X11ShellComponent? x11shell = (X11ShellComponent?)componentHandle.Target;
            if (x11shell != null)
            {
                ulong newInterval = (ulong)LibGio.g_settings_get_int(self, Utils.AsPtr("double-click"u8));
                x11shell.Logger?.LogDebug($"Double click interval changed: {newInterval}");

                // FIXME: Move the updating of this to X11WindowComponent?
                foreach (var window in X11WindowComponent.XWindowDict.Values)
                {
                    window.ClickCounter.DoubleClickInfo.Interval = newInterval;
                }
            }
        }

        private static unsafe bool GetDbusBoolProperty(IntPtr dbusproxy, ReadOnlySpan<byte> name)
        {
            IntPtr var = LibGio.g_dbus_proxy_get_cached_property(dbusproxy, Utils.AsPtr(name));
            bool val = LibGio.g_variant_get_boolean(var) != 0;
            LibGio.g_variant_unref(var);
            return val;
        }

        private static unsafe uint GetDbusUIntProperty(IntPtr dbusproxy, ReadOnlySpan<byte> name)
        {
            IntPtr var = LibGio.g_dbus_proxy_get_cached_property(dbusproxy, Utils.AsPtr(name));
            uint val = LibGio.g_variant_get_uint32(var);
            LibGio.g_variant_unref(var);
            return val;
        }

        private static unsafe long GetDbusLongProperty(IntPtr dbusproxy, ReadOnlySpan<byte> name)
        {
            IntPtr var = LibGio.g_dbus_proxy_get_cached_property(dbusproxy, Utils.AsPtr(name));
            long val = LibGio.g_variant_get_int64(var);
            LibGio.g_variant_unref(var);
            return val;
        }

        private static unsafe double GetDbusDoubleProperty(IntPtr dbusproxy, ReadOnlySpan<byte> name)
        {
            IntPtr var = LibGio.g_dbus_proxy_get_cached_property(dbusproxy, Utils.AsPtr(name));
            double val = LibGio.g_variant_get_double(var);
            LibGio.g_variant_unref(var);
            return val;
        }

        /// <inheritdoc/>
        public void AllowScreenSaver(bool allow, string? disableReason)
        {
            if (HasScreenSaverSuspend)
            {
                // FIXME: This doesn't seem to work 100%...
                // With XScreenSaver this doesn't work and the screen saver will start anyway.
                // SDL deals with this in two ways:
                // 1. By calling XResetScreenSaver regularly.
                // 2. By sending a d-bus message to simulate user activity regularly.
                // We should probably experiment with these solutions.
                // But it could also be some kind of configuration issue
                // - Noggin_bops 2026-02-15

                XScreenSaverSuspend(X11.Display, !allow);
                XResetScreenSaver(X11.Display);

                IsSuspendingScreenSaver = !allow;
            }
        }

        /// <inheritdoc/>
        public bool IsScreenSaverAllowed()
        {
            return !IsSuspendingScreenSaver;
        }

        /// <inheritdoc/>
        public BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            if (UPowerDisplayDevice != IntPtr.Zero)
            {
                bool onBattery = GetDbusBoolProperty(UPower, "OnBattery"u8);
                bool isPresent = GetDbusBoolProperty(UPowerDisplayDevice, "IsPresent"u8);
                uint state = GetDbusUIntProperty(UPowerDisplayDevice, "State"u8);
                double percent = GetDbusDoubleProperty(UPowerDisplayDevice, "Percentage"u8);

                long timeToEmpty = GetDbusLongProperty(UPowerDisplayDevice, "TimeToEmpty"u8);
                //long timeToFull = GetDbusLongProperty(UPowerDisplayDevice, "TimeToFull"u8);

                bool powerSaver = LibGio.g_power_profile_monitor_get_power_saver_enabled(GPowerProfileMoniforInstance) != 0;

                batteryInfo.OnAC = !onBattery;
                batteryInfo.Charging = state == 1; // See: https://upower.freedesktop.org/docs/Device.html
                batteryInfo.PowerSaver = powerSaver;
                batteryInfo.BatteryPercent = (float)percent;
                batteryInfo.BatteryTime = timeToEmpty == 0 ? null : timeToEmpty;

                return isPresent ? BatteryStatus.HasSystemBattery : BatteryStatus.NoSystemBattery;
            }
            else
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

                        // FIXME: Consider the case of multiple batteries.
                        setBattery = true;
                    }
                }

                // FIXME: We can listen to GPowerProfileMonitor::notify::power-saver-enabled signal to get an event
                // when this setting changes.
                // - Noggin_bops 2024-07-22
                bool powerSaver = LibGio.g_power_profile_monitor_get_power_saver_enabled(GPowerProfileMoniforInstance) != 0;

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
        }

        internal bool TryReadColorScheme(out int scheme)
        {
            scheme = -1;
            unsafe {
                GError* error = null;
                IntPtr ret = LibGio.g_dbus_proxy_call_sync(PortalDesktop, Utils.AsPtr("Read"u8), GVariant_org_freedesktop_appearance_color_scheme, GDBusCallFlags.G_DBUS_CALL_FLAGS_NONE, int.MaxValue, IntPtr.Zero, &error);
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

                LibGio.g_variant_get(ret, Utils.AsPtr("(v)"u8), out IntPtr child);
                LibGio.g_variant_get(child, Utils.AsPtr("v"u8), out IntPtr value);

                scheme = (int)LibGio.g_variant_get_uint32(value);

                LibGio.g_variant_unref(value);
                LibGio.g_variant_unref(child);
                LibGio.g_variant_unref(ret);

                LibGio.g_clear_error(&error);
                return true;
            }
        }

        internal bool TryReadHighContrast(out bool highContrast)
        {
            highContrast = false;
            unsafe {
                GError* error = null;
                IntPtr ret = LibGio.g_dbus_proxy_call_sync(PortalDesktop, Utils.AsPtr("Read"u8), GVariant_org_gnome_desktop_a11y_interface_high_contrast, GDBusCallFlags.G_DBUS_CALL_FLAGS_NONE, int.MaxValue, IntPtr.Zero, &error);
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

                    Logger?.LogError($"Couldn't read the high-contrast setting: {Marshal.PtrToStringUTF8((IntPtr)error->message)}");
                    LibGio.g_clear_error(&error);
                    return false;
                }

                LibGio.g_variant_get(ret, Utils.AsPtr("(v)"u8), out IntPtr child);
                LibGio.g_variant_get(child, Utils.AsPtr("v"u8), out IntPtr value);

                highContrast = LibGio.g_variant_get_boolean(value) != 0;

                LibGio.g_variant_unref(value);
                LibGio.g_variant_unref(child);
                LibGio.g_variant_unref(ret);

                LibGio.g_clear_error(&error);
                return true;
            }
        }

        /// <inheritdoc />
        public ThemeInfo GetPreferredTheme()
        {
            return CurrentTheme;
        }
        
        // FIXME: Platform specific API for getting a theme name (e.g. gtk-theme).
        // FIXME: Platform specific API for getting accent color?

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

        /// <summary>
        /// Gets parameters used to detect double-clicks. This is informed by the user settings on the operating system.
        /// </summary>
        /// <returns>The double-click parameters.</returns>
        public unsafe DoubleClickInfo GetDoubleClickInfo()
        {
            DoubleClickInfo info;
            if (GSettingsPtr != 0 && GSettingsHasDoubleClickProperty)
            {
                info.Interval = (ulong)LibGio.g_settings_get_int(GSettingsPtr, Utils.AsPtr("double-click"u8));
                info.Distance = (5, 5);
            }
            else
            {
                // By default gnome uses a 400ms interval for double-clicks.
                // - Noggin_bops 2026-02-13
                info.Interval = 400;
                info.Distance = (5, 5);
            }
            return info;
        }
    }
}
