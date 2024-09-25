using System;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.IOPM;
using static OpenTK.Platform.Native.macOS.IOPS;
using static OpenTK.Platform.Native.macOS.Mach;
using static OpenTK.Platform.Native.macOS.MacOSWindowComponent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSShellComponent : IShellComponent
    {
        internal static readonly ObjCClass NSWorkspaceClass = objc_getClass("NSWorkspace"u8);
        internal static readonly ObjCClass NSProcessInfo = objc_getClass("NSProcessInfo"u8);

        internal static readonly SEL selProcessInfo = sel_registerName("processInfo"u8);
        internal static readonly SEL selIsLowPowerModeEnabled = sel_registerName("isLowPowerModeEnabled"u8);

        internal static readonly SEL selEffectiveAppearance = sel_registerName("effectiveAppearance"u8);
        internal static readonly SEL selName = sel_registerName("name"u8);

        internal static readonly SEL selSharedWorkspace = sel_registerName("sharedWorkspace"u8);
        internal static readonly SEL selAccessibilityDisplayShouldIncreaseContrast = sel_registerName("accessibilityDisplayShouldIncreaseContrast"u8);

        internal static readonly IntPtr NSAppearanceNameAqua = GetStringConstant(AppKitLibrary, "NSAppearanceNameAqua"u8);
        internal static readonly IntPtr NSAppearanceNameDarkAqua = GetStringConstant(AppKitLibrary, "NSAppearanceNameDarkAqua"u8);
        internal static readonly IntPtr NSAppearanceNameVibrantLight = GetStringConstant(AppKitLibrary, "NSAppearanceNameVibrantLight"u8);
        internal static readonly IntPtr NSAppearanceNameVibrantDark = GetStringConstant(AppKitLibrary, "NSAppearanceNameVibrantDark"u8);

        internal static readonly IntPtr NSAppearanceNameAccessibilityHighContrastDarkAqua = GetStringConstant(AppKitLibrary, "NSAppearanceNameAccessibilityHighContrastDarkAqua"u8);
        internal static readonly IntPtr NSAppearanceNameAccessibilityHighContrastVibrantLight = GetStringConstant(AppKitLibrary, "NSAppearanceNameAccessibilityHighContrastVibrantLight"u8);
        internal static readonly IntPtr NSAppearanceNameAccessibilityHighContrastVibrantDark = GetStringConstant(AppKitLibrary, "NSAppearanceNameAccessibilityHighContrastVibrantDark"u8);

        /// <inheritdocs/>
        public string Name => nameof(MacOSShellComponent);

        /// <inheritdocs/>
        public PalComponents Provides => PalComponents.Shell;

        /// <inheritdocs/>
        public ILogger? Logger { get; set; }

        private int ScreenSaverAssertion = 0;

        /// <inheritdocs/>
        public void Initialize(ToolkitOptions options)
        {
            // Set the initial theme so we can detect changes later
            LastTheme = GetCurrentTheme();
        }

        /// <inheritdocs/>
        public void AllowScreenSaver(bool allow)
        {
            if (allow == false)
            {
                // Only create an assertion if we don't have one already.
                if (ScreenSaverAssertion == 0)
                {
                    // FIXME: Make the reason changable!
                    IntPtr reason = ToNSString("Preventing screen saver."u8);
                    int result = IOPMAssertionCreateWithName(kIOPMAssertionTypeNoDisplaySleep, IOPMAssertionLevel.On, reason, out ScreenSaverAssertion);
                    if (result != 0)
                    {
                        // FIXME: Better error message?
                        throw new Exception($"Failed to create assertion: {result}");
                    }
                }
            }
            else
            {
                if (ScreenSaverAssertion != 0)
                {
                    IOPMAssertionRelease(ScreenSaverAssertion);
                    ScreenSaverAssertion = 0;
                }
            }
        }

        /// <inheritdocs/>
        public unsafe BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            BatteryStatus status;
            batteryInfo = default;

            IntPtr processInfo = objc_msgSend_IntPtr((IntPtr)NSProcessInfo, selProcessInfo);
            // FIXME: BOOL
            batteryInfo.PowerSaver = objc_msgSend_bool(processInfo, selIsLowPowerModeEnabled);

            IntPtr blob = IOPSCopyPowerSourcesInfo();
            IntPtr sources = IOPSCopyPowerSourcesList(blob);

            nint count = CFArrayGetCount(sources);
            if (count == 0)
            {
                CFRelease(sources);
                CFRelease(blob);
                batteryInfo = default;
                return BatteryStatus.NoSystemBattery;
            }
            else
            {
                // FIXME: What if count is != 0 but all of the batteries are not present?
                status = BatteryStatus.HasSystemBattery;
            }

            for (int i = 0; i < count; i++)
            {
                IntPtr ps = CFArrayGetValueAtIndex(sources, i);
                IntPtr desc = IOPSGetPowerSourceDescription(blob, ps);

                IntPtr isPresent = CFDictionaryGetValue(desc, kIOPSIsPresentKey);
                if (isPresent != IntPtr.Zero)
                {
                    if (CFBooleanGetValue(isPresent) == false)
                    {
                        // This battery is not of interest to us.
                        continue;
                    }
                }

                bool usingBattery = false;
                bool charging = false;

                IntPtr sourceState = CFDictionaryGetValue(desc, kIOPSPowerSourceStateKey);
                if (sourceState != IntPtr.Zero)
                {
                    if (CFEqual(sourceState, kIOPSACPowerValue))
                    {
                        batteryInfo.OnAC = true;
                    }
                    else if (CFEqual(sourceState, kIOPSBatteryPowerValue))
                    {
                        usingBattery = true;
                    }
                }

                IntPtr isCharging = CFDictionaryGetValue(desc, kIOPSIsChargingKey);
                if (isCharging != IntPtr.Zero)
                {
                    batteryInfo.Charging |= CFBooleanGetValue(isCharging);
                    charging = CFBooleanGetValue(isCharging);
                }

                int currentCapacity = -1;
                int maxCapacity = -1;

                IntPtr currentCap = CFDictionaryGetValue(desc, kIOPSCurrentCapacityKey);
                if (currentCap != IntPtr.Zero)
                {
                    CFNumberGetValue(currentCap, kCFNumberIntType, &currentCapacity);
                }

                IntPtr maxCap = CFDictionaryGetValue(desc, kIOPSMaxCapacityKey);
                if (maxCap != IntPtr.Zero)
                {
                    CFNumberGetValue(maxCap, kCFNumberIntType, &maxCapacity);
                }

                if (currentCapacity != -1 && maxCapacity != -1)
                {
                    float percent = 100 * (currentCapacity / (float)maxCapacity);
                    if (percent > (batteryInfo.BatteryPercent ?? -1))
                        batteryInfo.BatteryPercent = percent;
                }

                // kIOPSTimeToEmptyKey is only valid when kIOPSPowerSourceStateKey == kIOPSPowerSourceStateKey
                // and kIOPSIsChargingKey == false.
                if (usingBattery && charging == false)
                {
                    int timeToEmpty = -1;
                    IntPtr timeToEmptyNumber = CFDictionaryGetValue(desc, kIOPSTimeToEmptyKey);
                    if (timeToEmptyNumber != IntPtr.Zero)
                    {
                        CFNumberGetValue(timeToEmptyNumber, kCFNumberIntType, &timeToEmpty);
                    }

                    // Handles both if the key wasn't present, but also if the time is unknown.
                    if (timeToEmpty != -1)
                    {
                        batteryInfo.BatteryTime = timeToEmpty * 60;
                    }
                }
            }

            CFRelease(sources);
            CFRelease(blob);

            return status;
        }

        private static ThemeInfo GetCurrentTheme()
        {
            ThemeInfo info;
            IntPtr appearance = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSApplicationClass, selSharedApplication), selEffectiveAppearance);

            IntPtr name = objc_msgSend_IntPtr(appearance, selName);

            if (name == NSAppearanceNameAqua)
            {
                info.Theme = AppTheme.Light;
            }
            else if (name == NSAppearanceNameDarkAqua)
            {
                info.Theme = AppTheme.Dark;
            }
            else
            {
                // FIXME: What do we do with the vibrant themes??
                info.Theme = AppTheme.NoPreference;
            }

            IntPtr workspace = objc_msgSend_IntPtr((IntPtr)NSWorkspaceClass, selSharedWorkspace);
            // FIXME: BOOL?
            bool highContrast = objc_msgSend_bool(workspace, selAccessibilityDisplayShouldIncreaseContrast);
            info.HighContrast = highContrast;

            return info;
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

        /// <inheritdocs/>
        public ThemeInfo GetPreferredTheme()
        {
            return GetCurrentTheme();
        }

        /// <inheritdocs/>
        public unsafe SystemMemoryInfo GetSystemMemoryInformation()
        {
            // Seems like host_statistics64 doesn't like to have a count >15 on my test machine
            // running macOS 12.3.1.
            // Not sure why this is, but it'll have to be fine for now.
            // - Noggin_bops 2024-02-08
            uint count = HOST_VM_INFO_COUNT;
            int result = host_statistics(mach_host_self(), HOST_VM_INFO, out vm_statistics stats, ref count);
            if (result != KERN_SUCCESS)
            {
                Logger?.LogWarning($"Failed to get memory statistics: {result}");
                return default;
            }

            result = host_page_size(mach_host_self(), out nuint page_size);
            if (result != KERN_SUCCESS)
            {
                Logger?.LogWarning($"Failed to get page size: {result}");
                return default;
            }

            // These don't add up to the total amount of pages.
            // It seems like there is something weird going on with host_statistics
            // where it doesn't count some pages.
            // See: https://stackoverflow.com/questions/14789672/why-does-host-statistics64-return-inconsistent-results
            // - Noggin_bops 2024-02-08
            uint total_pages = stats.wire_count + stats.active_count + stats.inactive_count + stats.free_count + stats.purgable_count;
            uint free_pages = stats.free_count;

            SystemMemoryInfo info;
            info.TotalPhysicalMemory = total_pages * (long)page_size;
            info.AvailablePhysicalMemory = free_pages * (long)page_size;

            return info;
        }
    
        /// <summary>
        /// Calls <see href="https://developer.apple.com/documentation/foundation/1395275-nslog">NSLog</see> to log a message to the Apple System Log facility.
        /// This can be useful when running your application as a bundle as stdout and stderr can't be used.
        /// This function is static so that it can be used before <see cref="Toolkit"/> has been initialized.
        /// </summary>
        /// <param name="message">The message to print to the system log.</param>
        // FIXME: Have a static and a non-static way of accessing this function?
        public static void NSLog(string message)
        {
            // FIXME: Maybe add a way to add extra asl info such as log level etc.

            // Escape all % so we don't accidentally expect additional arguments.
            IntPtr msg = ToNSString(message.Replace("%", "%%"));
            ObjC.NSLog(msg);
        }
    }
}

