using System;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace OpenTK.Platform.MacOS.Carbon
{
    using CGDirectDisplayID = System.IntPtr;

    // Quartz Display services used here are available in MacOS X 10.3 and later.

    enum CGDisplayErr
    {

    }

    enum CGError
    {
        Success = 0,
        Failure = 1000,
        IllegalArgument = 1001,
        InvalidConnection = 1002,
        InvalidContext = 1003,
        CannotComplete = 1004,
        NotImplemented = 1006,
        RangeCheck = 1007,
        TypeCheck = 1008,
        InvalidOperation = 1010,
        NoneAvailable = 1011,
    }

    internal static class CG
    {
        const string appServices = "/System/Library/Frameworks/ApplicationServices.framework/Versions/Current/ApplicationServices";

        // CGPoint -> HIPoint
        // CGSize -> HISize
        // CGRect -> HIRect

        [DllImport(appServices,EntryPoint="CGGetActiveDisplayList")]
        internal unsafe static extern CGDisplayErr GetActiveDisplayList(int maxDisplays, IntPtr* activeDspys, out int dspyCnt);

        [DllImport(appServices,EntryPoint="CGMainDisplayID")]
        internal static extern IntPtr MainDisplayID();

		[DllImport(appServices, EntryPoint = "CGDisplayBounds")]
		internal unsafe static extern HIRect DisplayBounds(IntPtr display);

        [DllImport(appServices,EntryPoint="CGDisplayPixelsWide")]
        internal static extern int DisplayPixelsWide(IntPtr display);

        [DllImport(appServices,EntryPoint="CGDisplayPixelsHigh")]
        internal static extern int DisplayPixelsHigh(IntPtr display);

        [DllImport(appServices,EntryPoint="CGDisplayCurrentMode")]
        internal static extern IntPtr DisplayCurrentMode(IntPtr display);

        [DllImport(appServices,EntryPoint="CGDisplayCapture")]
        internal static extern CGDisplayErr DisplayCapture(IntPtr display);

        [DllImport(appServices,EntryPoint="CGDisplayRelease")]
        internal static extern CGDisplayErr DisplayRelease(IntPtr display);

        [DllImport(appServices, EntryPoint = "CGDisplayAvailableModes")]
        internal static extern IntPtr DisplayAvailableModes(IntPtr display);

        [DllImport(appServices, EntryPoint = "CGDisplaySwitchToMode")]
        internal static extern IntPtr DisplaySwitchToMode(IntPtr display, IntPtr displayMode);

        [DllImport(appServices, EntryPoint = "CGWarpMouseCursorPosition")]
        internal static extern CGError WarpMouseCursorPosition(HIPoint newCursorPosition);

        [DllImport(appServices, EntryPoint = "CGCursorIsVisible")]
        internal static extern bool CursorIsVisible();

        [DllImport(appServices, EntryPoint = "CGDisplayShowCursor")]
        internal static extern CGError DisplayShowCursor(CGDirectDisplayID display);

        [DllImport(appServices, EntryPoint = "CGDisplayHideCursor")]
        internal static extern CGError DisplayHideCursor(CGDirectDisplayID display);

         [DllImport(appServices, EntryPoint = "CGAssociateMouseAndMouseCursorPosition")]
        internal static extern CGError AssociateMouseAndMouseCursorPosition(bool connected);

        [DllImport(appServices, EntryPoint="CGSetLocalEventsSuppressionInterval")]
        internal static extern CGError SetLocalEventsSuppressionInterval(double seconds);
    }
}
