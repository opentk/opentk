using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.macOS
{
    internal static unsafe class CG
    {
        private const string Lib = "/System/Library/Frameworks/ApplicationServices.framework/Versions/Current/ApplicationServices";

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGError CGGetActiveDisplayList(uint maxDisplays, uint* /* CGDirectDisplayID* */ activeDisplays, out uint displayCount);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* boolean_t */ CGDisplayIsAsleep(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint CGDisplayUnitNumber(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* boolean_t */ CGDisplayIsMain(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CGDisplayModeRef */ CGDisplayCopyDisplayMode(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGDisplayModeRelease(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFArrayRef */ CGDisplayCopyAllDisplayModes(uint /* CGDirectDisplayID */ display, IntPtr /* CFDictionaryRef */ options);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayModeGetWidth(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayModeGetHeight(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern double CGDisplayModeGetRefreshRate(IntPtr /* CGDisplayModeRef */ mode);

        // Deprecated, but we don't have any better options...
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CFStringRef */ CGDisplayModeCopyPixelEncoding(IntPtr /* CGDisplayModeRef */ mode);

        // FIXME: Make return enum
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern DisplayModeIOFlags CGDisplayModeGetIOFlags(IntPtr /* CGDisplayModeRef */ mode);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGRect CGDisplayBounds(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayPixelsHigh(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern nint /* size_t */ CGDisplayPixelsWide(uint /* CGDirectDisplayID */ display);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGError CGWarpMouseCursorPosition(CGPoint newCursorPosition);

    }
}

