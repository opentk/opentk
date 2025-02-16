using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    // FIXME: Figure out the size of this struct??
    // Or some way for us to not have to pass this struct around without a pointer...
    internal struct CVDisplayLinkRef
    {
        // Is this correct??
        public IntPtr Handle;
    }

#pragma warning disable CS0649
    internal struct CVTime
    {
        public long timeValue;
        public int timeScale;
        public int flags;
    }
#pragma warning restore CS0649


    internal static unsafe class CV
    {
        private const string Lib = "/System/Library/Frameworks/CoreVideo.framework/CoreVideo";

        internal static readonly IntPtr CoreVideo = LoadLibrary("/System/Library/Frameworks/CoreVideo.framework/CoreVideo"u8);

        internal static readonly int ZeroTime = (int)GetSymbol(CoreVideo, "kCVZeroTime"u8);
        internal static readonly int CVIndefiniteTime = (int)GetSymbol(CoreVideo, "kCVIndefiniteTime"u8);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* CVReturn */ CVDisplayLinkCreateWithCGDisplay(uint /* CGDirectDisplayID */ displayID, out CVDisplayLinkRef link);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* CVReturn */ CVDisplayLinkCreateWithActiveCGDisplays(out CVDisplayLinkRef displayLinkOut);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int CVDisplayLinkOutputCallback(CVDisplayLinkRef displayLink, IntPtr inNow, IntPtr inOutputTime, ulong flagsIn, out ulong flagsOut, IntPtr displayLinkContext);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* CVReturn */ CVDisplayLinkSetOutputCallback(CVDisplayLinkRef displayLink, CVDisplayLinkOutputCallback callback, IntPtr userInfo);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* CVReturn */ CVDisplayLinkStart(CVDisplayLinkRef displayLink);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* CVReturn */ CVDisplayLinkStop(CVDisplayLinkRef displayLink);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CVDisplayLinkRelease(CVDisplayLinkRef displayLink);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVTime CVDisplayLinkGetNominalOutputVideoRefreshPeriod(CVDisplayLinkRef displayLink);

    }
}

