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
using System.ComponentModel;
using System.Diagnostics;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSShellComponent : IShellComponent
    {
        internal static readonly ObjCClass NSWorkspaceClass = objc_getClass("NSWorkspace"u8);
        internal static readonly ObjCClass NSProcessInfoClass = objc_getClass("NSProcessInfo"u8);
        internal static readonly ObjCClass NSViewClass = objc_getClass("NSView"u8);
        internal static readonly ObjCClass NSGraphicsContextClass = objc_getClass("NSGraphicsContext"u8);
        internal static readonly ObjCClass NSBezierPathClass = objc_getClass("NSBezierPath"u8);
        internal static readonly ObjCClass NSColor = objc_getClass("NSColor"u8);
        internal static readonly ObjCClass CADisplayLinkClass = objc_getClass("CADisplayLink"u8);
        internal static readonly ObjCClass NSRunLoopClass = objc_getClass("NSRunLoop"u8);

        internal static readonly SEL selProcessInfo = sel_registerName("processInfo"u8);
        internal static readonly SEL selIsLowPowerModeEnabled = sel_registerName("isLowPowerModeEnabled"u8);

        internal static readonly SEL selEffectiveAppearance = sel_registerName("effectiveAppearance"u8);
        internal static readonly SEL selName = sel_registerName("name"u8);

        internal static readonly SEL selSharedWorkspace = sel_registerName("sharedWorkspace"u8);
        internal static readonly SEL selAccessibilityDisplayShouldIncreaseContrast = sel_registerName("accessibilityDisplayShouldIncreaseContrast"u8);

        internal static readonly SEL selDrawRect = sel_registerName("drawRect:"u8);
        internal static readonly SEL selCurrentContext = sel_registerName("currentContext"u8);
        internal static readonly SEL selWhiteColor = sel_registerName("whiteColor"u8);
        internal static readonly SEL selBlackColor = sel_registerName("blackColor"u8);
        internal static readonly SEL selRedColor = sel_registerName("redColor"u8);
        internal static readonly SEL selSystemBlueColor = sel_registerName("systemBlueColor"u8);
        internal static readonly SEL selSystemGrayColor = sel_registerName("systemGrayColor"u8);
        internal static readonly SEL selSystemFillColor = sel_registerName("systemFillColor"u8);
        internal static readonly SEL selControlAccentColor = sel_registerName("controlAccentColor"u8);
        internal static readonly SEL selSet= sel_registerName("set"u8);
        internal static readonly SEL selFill = sel_registerName("fill"u8);
        internal static readonly SEL selBezierPathWithRoundedRect_XRadius_YRadius = sel_registerName("bezierPathWithRoundedRect:xRadius:yRadius:"u8);
        internal static readonly SEL selSetNeedsDisplay = sel_registerName("setNeedsDisplay:"u8);
        internal static readonly SEL selDrawInRect = sel_registerName("drawInRect:"u8);
        internal static readonly SEL selColorWithAlphaComponent = sel_registerName("colorWithAlphaComponent:"u8);
        internal static readonly SEL selDisplayLinkWithTarget_Selector = sel_registerName("displayLinkWithTarget:selector:"u8);
        internal static readonly SEL selUpdateAnimation = sel_registerName("updateAnimation:"u8);
        internal static readonly SEL selAddToRunLoop_ForMode = sel_registerName("addToRunLoop:forMode:"u8);
        internal static readonly SEL selCurrentRunLoop = sel_registerName("currentRunLoop"u8);

        internal static readonly IntPtr NSAppearanceNameAqua = GetStringConstant(AppKitLibrary, "NSAppearanceNameAqua"u8);
        internal static readonly IntPtr NSAppearanceNameDarkAqua = GetStringConstant(AppKitLibrary, "NSAppearanceNameDarkAqua"u8);
        internal static readonly IntPtr NSAppearanceNameVibrantLight = GetStringConstant(AppKitLibrary, "NSAppearanceNameVibrantLight"u8);
        internal static readonly IntPtr NSAppearanceNameVibrantDark = GetStringConstant(AppKitLibrary, "NSAppearanceNameVibrantDark"u8);

        internal static readonly IntPtr NSAppearanceNameAccessibilityHighContrastDarkAqua = GetStringConstant(AppKitLibrary, "NSAppearanceNameAccessibilityHighContrastDarkAqua"u8);
        internal static readonly IntPtr NSAppearanceNameAccessibilityHighContrastVibrantLight = GetStringConstant(AppKitLibrary, "NSAppearanceNameAccessibilityHighContrastVibrantLight"u8);
        internal static readonly IntPtr NSAppearanceNameAccessibilityHighContrastVibrantDark = GetStringConstant(AppKitLibrary, "NSAppearanceNameAccessibilityHighContrastVibrantDark"u8);

        internal static ObjCClass NSOpenTKProgressViewClass;

        internal static ReadOnlySpan<byte> OtkCompoenntFieldName => "otkPALWindowComponent"u8;

        internal static ReadOnlySpan<byte> ProgressFieldName => "progress"u8;

        internal static ReadOnlySpan<byte> ProgressModeFieldName => "progressMode"u8;

        internal static ReadOnlySpan<byte> ProgressAnimationTimeFieldName => "animationTime"u8;

        private static MacOSShellComponent GetComponentFromProgressView(IntPtr progressView)
        {
            object_getInstanceVariable(progressView, OtkCompoenntFieldName, out IntPtr shellCompPtr);
            return (MacOSShellComponent)((GCHandle)shellCompPtr).Target!;
        }

        /// <inheritdocs/>
        public string Name => nameof(MacOSShellComponent);

        /// <inheritdocs/>
        public PalComponents Provides => PalComponents.Shell;

        /// <inheritdocs/>
        public ILogger? Logger { get; set; }

        private int ScreenSaverAssertion = 0;

        private IntPtr DefaultScreenSaverReason;

        private GCHandle ComponentHandle;

        private IntPtr ProgressView;
        private CVDisplayLinkRef DisplayLink;

        /// <inheritdocs/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            string? appName = options.ApplicationName;
            if (string.IsNullOrEmpty(appName))
                appName = null;
            DefaultScreenSaverReason = ToNSString($"'{appName ?? "OpenTK app"}' is preventing screen saver.");

            // Set the initial theme so we can detect changes later
            LastTheme = GetCurrentTheme();

            // FIXME: Maybe we should move to NSProgressIndicator?
            // That way we could get the "native" styling...
            NSOpenTKProgressViewClass = objc_allocateClassPair(NSViewClass, "NsOpenTKProgressView"u8, 0);

            // Define a Ivar where we can pass a GCHandle so we can retreive it in callbacks.
            class_addIvar(NSOpenTKProgressViewClass, OtkCompoenntFieldName, (nuint)nuint.Size, (nuint)int.Log2(nuint.Size), "^v"u8);
            class_addIvar(NSOpenTKProgressViewClass, ProgressFieldName, (nuint)NFloat.Size, (nuint)int.Log2(NFloat.Size), sizeof(NFloat) == 4 ? "f"u8 : "d"u8);
            class_addIvar(NSOpenTKProgressViewClass, ProgressModeFieldName, (nuint)sizeof(int), (nuint)int.Log2(sizeof(int)), "i"u8);
            class_addIvar(NSOpenTKProgressViewClass, ProgressAnimationTimeFieldName, (nuint)sizeof(int), (nuint)int.Log2(sizeof(int)), "q"u8);

            class_addMethod(NSOpenTKProgressViewClass, selUpdateAnimation, (IntPtr)NSOtkProgressView_UpdateAnimationInst, "v@:@"u8);
            class_addMethod(NSOpenTKProgressViewClass, selDrawRect, (IntPtr)NSOtkProgressView_DrawRectInst, "v@:{CGRect={CGPoint=dd}{CGSize=dd}}"u8);

            objc_registerClassPair(NSOpenTKProgressViewClass);

            ProgressView = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSOpenTKProgressViewClass, Alloc), Init);

            // FIXME: Store the Ivars somewhere so we can use it later?
            ComponentHandle = GCHandle.Alloc(this, GCHandleType.Normal);
            object_setInstanceVariable(ProgressView, OtkCompoenntFieldName, (IntPtr)ComponentHandle);

            IntPtr dockTile = objc_msgSend_IntPtr(nsApplication, selDockTile);
            objc_msgSend(dockTile, selSetContentView, ProgressView);
            objc_msgSend(dockTile, selDisplay);
        }

        internal void UpdateDockTile() {
            // FIXME: BOOL
            objc_msgSend(ProgressView, selSetNeedsDisplay, true);
            IntPtr dockTile = objc_msgSend_IntPtr(nsApplication, selDockTile);
            objc_msgSend(dockTile, selSetContentView, ProgressView);
            objc_msgSend(dockTile, selDisplay);
        }

        // FIXME: Remove as we no longer need it.
        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, void> NSOtkProgressView_UpdateAnimationInst = &NSOtkProgressView_UpdateAnimation;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static unsafe void NSOtkProgressView_UpdateAnimation(IntPtr view, SEL selector, IntPtr displayLink)
        {
            GetComponentFromProgressView(view).Logger?.LogInfo("UpdateAnimation!");
        }

        // Custom event used to notify the main thread that the dock icon needs to be updated.
        internal class DockIconUpdateEventArgs : EventArgs
        {
        }

        static readonly DockIconUpdateEventArgs DockIconUpdateEvent = new DockIconUpdateEventArgs();

        private static unsafe int DisplayLinkRefresh(CVDisplayLinkRef displayLink, IntPtr inNow, IntPtr inOutputTime, ulong flagsIn, out ulong flagsOut, IntPtr displayLinkContext)
        {
            Unsafe.SkipInit(out flagsOut);

            MacOSShellComponent comp = (MacOSShellComponent)((GCHandle)displayLinkContext).Target!;

            // This is not running on the main thread so we need to make the main thread update the drawing.
            // To do this we send a user event to the main thread and handle that case in a special case.
            // We also use a single instance of the event to avoid unecessary allocations.
            // - Noggin_bops 2025-02-15
            Toolkit.Window.PostUserEvent(DockIconUpdateEvent);

            return 0;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, CGRect, void> NSOtkProgressView_DrawRectInst = &NSOtkProgressView_DrawRect;
        [UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvCdecl) })]
        private static unsafe void NSOtkProgressView_DrawRect(IntPtr view, SEL selector, CGRect dirtyRect)
        {
            NFloat completion = *getIvarPointer<NFloat>(view, ProgressFieldName);
            ProgressMode mode = (ProgressMode)(*getIvarPointer<int>(view, ProgressModeFieldName));

            CGRect bounds = objc_msgSend_CGRect(view, selBounds);

            IntPtr icon = objc_msgSend_IntPtr(nsApplication, selApplicationIconImage);
            if (icon != IntPtr.Zero) {
                objc_msgSend(icon, selDrawInRect, bounds);
            }

            if (mode == ProgressMode.NoProgress)
                return;

            static void DrawRoundedRect(CGRect rect) {
                IntPtr bezier = objc_msgSend_IntPtr((IntPtr)NSBezierPathClass, selBezierPathWithRoundedRect_XRadius_YRadius, rect, rect.size.y / 2, rect.size.y / 2);
                objc_msgSend(bezier, selFill);
            }

            IntPtr progressColor;
            switch (mode) 
            {
                case ProgressMode.NoProgress:
                case ProgressMode.Indeterminate:
                case ProgressMode.Normal:
                    progressColor = objc_msgSend_IntPtr((IntPtr)NSColor, selControlAccentColor);
                    break;
                case ProgressMode.Error:
                    progressColor = objc_msgSend_IntPtr((IntPtr)NSColor, selRedColor);
                    break;
                case ProgressMode.Paused:
                    progressColor = objc_msgSend_IntPtr((IntPtr)NSColor, selSystemGrayColor);
                    break;
                default: 
                    throw new InvalidEnumArgumentException("mode", (int)mode, mode.GetType());
            }

            CGRect rect = new CGRect(0, 20, dirtyRect.size.x, 10);
            IntPtr white = objc_msgSend_IntPtr((IntPtr)NSColor, selWhiteColor);
            objc_msgSend(objc_msgSend_IntPtr(white, selColorWithAlphaComponent, 0.7f), selSet);
            DrawRoundedRect(rect);

            CGRect rectInnerBg = rect.InsetBy(0.5f, 0.5f);
            IntPtr black = objc_msgSend_IntPtr((IntPtr)NSColor, selBlackColor);
            objc_msgSend(objc_msgSend_IntPtr(black, selColorWithAlphaComponent, 0.7f), selSet);
            DrawRoundedRect(rectInnerBg);

            if (mode == ProgressMode.Indeterminate)
            {
                long startTime = *getIvarPointer<long>(view, ProgressAnimationTimeFieldName);
                long currTime = Stopwatch.GetTimestamp();

                const float ANIMATION_TIME = 1.8f;

                float time = ((currTime - startTime) / (float)Stopwatch.Frequency) % ANIMATION_TIME;

                completion = 1.0f;
                float alpha = MathF.Sin(time * MathF.PI) * 0.5f + 0.5f;
                progressColor = objc_msgSend_IntPtr(progressColor, selColorWithAlphaComponent, alpha);
            }

            CGRect rectProgress = rect.InsetBy(1.0f, 1.0f);
            rectProgress.size.x = rectProgress.size.x * completion;
            objc_msgSend(progressColor, selSet);
            DrawRoundedRect(rectProgress);
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            objc_msgSend(DefaultScreenSaverReason, Release);
        }

        /// <inheritdocs/>
        public void AllowScreenSaver(bool allow, string? disableReason)
        {
            if (allow == false)
            {
                // Only create an assertion if we don't have one already.
                if (ScreenSaverAssertion == 0)
                {
                    IntPtr reason = disableReason == null ? DefaultScreenSaverReason : ToNSString(disableReason);
                    int result = IOPMAssertionCreateWithName(kIOPMAssertionTypeNoDisplaySleep, IOPMAssertionLevel.On, reason, out ScreenSaverAssertion);
                    if (result != 0)
                    {
                        // FIXME: Better error message?
                        throw new PalException(this, $"Failed to create screen saver assertion: {result}");
                    }

                    if (disableReason != null)
                    {
                        objc_msgSend(reason, Release);
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
        public bool IsScreenSaverAllowed()
        {
            return ScreenSaverAssertion == 0;
        }

        /// <inheritdocs/>
        public unsafe BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            BatteryStatus status;
            batteryInfo = default;

            IntPtr processInfo = objc_msgSend_IntPtr((IntPtr)NSProcessInfoClass, selProcessInfo);
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
    
        public enum ProgressMode {
            NoProgress,
            Indeterminate,
            Normal,
            Error,
            Paused,
        }

        public unsafe void SetProgressStatus(WindowHandle handle, ProgressMode mode, float completion) {
            NSWindowHandle nswindow = handle.As<NSWindowHandle>(this);

            // Deal with multiple windows having different progress statuses.
            // WE could take a book from the windows documentation about the priority
            // of progress states.
            // - Noggin_bops 2025-02-20

            *getIvarPointer<NFloat>(ProgressView, ProgressFieldName) = completion;
            *getIvarPointer<int>(ProgressView, ProgressModeFieldName) = (int)mode;

            if (mode == ProgressMode.Indeterminate)
            {
                if (DisplayLink.Handle == 0)
                {
                    // FIXME: Do not recreate if we only have one, alt. dispose of the old link...
                    CV.CVDisplayLinkCreateWithActiveCGDisplays(out DisplayLink);

                    CV.CVDisplayLinkSetOutputCallback(DisplayLink, DisplayLinkRefresh, (IntPtr)ComponentHandle);

                    CV.CVDisplayLinkStart(DisplayLink);

                    *getIvarPointer<long>(ProgressView, ProgressAnimationTimeFieldName) = Stopwatch.GetTimestamp();

                }
            }
            else
            {
                if (DisplayLink.Handle != 0)
                {
                    CV.CVDisplayLinkStop(DisplayLink);
                    // FIXME: How do we properly dispose of the displat link?
                    DisplayLink = default;
                }
            }

            UpdateDockTile();
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

