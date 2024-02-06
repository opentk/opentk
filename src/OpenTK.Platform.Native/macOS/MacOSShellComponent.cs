using System;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.IOPM;
using static OpenTK.Platform.Native.macOS.IOPS;
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

        public string Name => nameof(MacOSShellComponent);

        public PalComponents Provides => PalComponents.Shell;

        public ILogger? Logger { get; set; }

        private int ScreenSaverAssertion = 0;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Shell)
            {
                throw new Exception("MacOSShellComponent can only initialize the Shell component.");
            }
        }

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
                    // FIXME: kCFNumberIntType
                    CFNumberGetValue(currentCap, 9, &currentCapacity);
                }

                IntPtr maxCap = CFDictionaryGetValue(desc, kIOPSMaxCapacityKey);
                if (maxCap != IntPtr.Zero)
                {
                    // FIXME: kCFNumberIntType
                    CFNumberGetValue(maxCap, 9, &maxCapacity);
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
                        // FIXME: kCFNumberIntType
                        CFNumberGetValue(timeToEmptyNumber, 9, &timeToEmpty);
                    }

                    // Both if the key wasn't present, but also if the time is unknown.
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

        public ThemeInfo GetPreferredTheme()
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

        public SystemMemoryInfo GetSystemMemoryInformation()
        {
            return default;
            throw new NotImplementedException();
        }
    }
}

