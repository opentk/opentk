using System;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    internal enum IOPMAssertionLevel : int
    {
        Off = 0,
        On = 255,
    }

    internal static class IOPM
    {
        public const string Lib = "/System/Library/Frameworks/IOKit.framework/IOKit";

        internal static readonly IntPtr IOKit = LoadLibrary("/System/Library/Frameworks/IOKit.framework/IOKit"u8);

        internal static readonly IntPtr kIOPMAssertionTimeoutKey = ToNSString("TimeoutSeconds"u8);
        internal static readonly IntPtr kIOPMAssertionTimeoutActionKey = ToNSString("TimeoutAction"u8);
        internal static readonly IntPtr kIOPMAssertionTimeoutActionLog = ToNSString("TimeoutActionLog"u8);
        internal static readonly IntPtr kIOPMAssertionTimeoutActionTurnOff = ToNSString("TimeoutActionTurnOff"u8);
        internal static readonly IntPtr kIOPMAssertionTimeoutActionRelease = ToNSString("TimeoutActionRelease"u8);
        internal static readonly IntPtr kIOPMAssertionRetainCountKey = ToNSString("RetainCount"u8);
        internal static readonly IntPtr kIOPMAssertionNameKey = ToNSString("AssertName"u8);
        internal static readonly IntPtr kIOPMAssertionDetailsKey = ToNSString("Details"u8);
        internal static readonly IntPtr kIOPMAssertionHumanReadableReasonKey = ToNSString("HumanReadableReason"u8);
        internal static readonly IntPtr kIOPMAssertionLocalizationBundlePathKey = ToNSString("BundlePath"u8);
        internal static readonly IntPtr kIOPMAssertionFrameworkIDKey = ToNSString("FrameworkBundleID"u8);
        internal static readonly IntPtr kIOPMAssertionPlugInIDKey = ToNSString("PlugInBundleID"u8);
        internal static readonly IntPtr kIOPMAssertionTypeKey = ToNSString("AssertType"u8);
        internal static readonly IntPtr kIOPMAssertionLevelKey = ToNSString("AssertLevel"u8);

        internal static readonly IntPtr kIOPMAssertPreventUserIdleSystemSleep = ToNSString("PreventUserIdleSystemSleep"u8);
        internal static readonly IntPtr kIOPMAssertPreventUserIdleDisplaySleep = ToNSString("PreventUserIdleDisplaySleep"u8);
        internal static readonly IntPtr kIOPMAssertionTypePreventUserIdleSystemSleep = kIOPMAssertPreventUserIdleSystemSleep;
        internal static readonly IntPtr kIOPMAssertionTypePreventUserIdleDisplaySleep = kIOPMAssertPreventUserIdleDisplaySleep;
        internal static readonly IntPtr kIOPMAssertionTypePreventSystemSleep = ToNSString("PreventSystemSleep"u8);
        internal static readonly IntPtr kIOPMAssertionTypeNoIdleSleep = ToNSString("NoIdleSleepAssertion"u8);
        internal static readonly IntPtr kIOPMAssertionTypeNoDisplaySleep = ToNSString("NoDisplaySleepAssertion"u8);


        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* IOReturn */ IOPMAssertionCreateWithName(IntPtr /* CFStringRef */ assertionType, IOPMAssertionLevel assertionLevel, IntPtr assertionName, out int /* IOPMAssertionID */ assertionID);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* IOReturn */ IOPMAssertionRelease(int /* IOPMAssertionID */ assertionID);
    }
}

