using System;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace OpenTK.Platform.MacOS.Carbon
{
    // Quartz Display services used here are available in MacOS X 10.3 and later.

    enum CGDisplayErr
    {

    }

    public static class CG
    {
        const string appServices = "/System/Library/Frameworks/ApplicationServices.framework/Versions/Current/ApplicationServices";

        // CGPoint -> HIPoint
        // CGSize -> HISize
        // CGRect -> HIRect

        [DllImport(appServices,EntryPoint="CGGetActiveDisplayList")]
        internal unsafe static extern CGDisplayErr GetActiveDisplayList(int maxDisplays, IntPtr* activeDspys, out int dspyCnt);

        [DllImport(appServices,EntryPoint="CGMainDisplayID")]
        internal static extern IntPtr MainDisplayID();

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

    }
}
