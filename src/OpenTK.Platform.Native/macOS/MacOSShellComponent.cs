using System;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.IOPM;
using static OpenTK.Platform.Native.macOS.MacOSWindowComponent;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSShellComponent : IShellComponent
    {
        internal static readonly ObjCClass NSWorkspaceClass = objc_getClass("NSWorkspace"u8);

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

        public BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            //throw new NotImplementedException();
            batteryInfo = default;
            return BatteryStatus.Unknown;
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

