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

    internal struct CVTimeStamp
    {
        public uint version;
        public int videoTimeScale;
        public long videoTime;
        public ulong hostTime;
        public double rateScalar;
        public int videoRefreshPeriod;
        public CVSMPTETime smpteTime;
        public ulong flags;
        public ulong reserved;
    }

    internal struct CVSMPTETime
    {
        public short  subframes;
        public short  subframeDivisor;
        public uint  counter;
        public uint  type;
        public uint  flags;
        public short  hours;
        public short  minutes;
        public short  seconds;
        public short  frames;
    }


    internal static unsafe class CV
    {
        private const string Lib = "/System/Library/Frameworks/CoreVideo.framework/CoreVideo";

        internal static readonly IntPtr CoreVideo = LoadLibrary("/System/Library/Frameworks/CoreVideo.framework/CoreVideo"u8);

        internal static readonly int ZeroTime = (int)GetSymbol(CoreVideo, "kCVZeroTime"u8);
        internal static readonly int CVIndefiniteTime = (int)GetSymbol(CoreVideo, "kCVIndefiniteTime"u8);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVReturn CVDisplayLinkCreateWithCGDisplay(uint /* CGDirectDisplayID */ displayID, out CVDisplayLinkRef link);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVReturn CVDisplayLinkCreateWithActiveCGDisplays(out CVDisplayLinkRef displayLinkOut);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int CVDisplayLinkOutputCallback(CVDisplayLinkRef displayLink, ref readonly CVTimeStamp inNow, ref readonly CVTimeStamp inOutputTime, ulong flagsIn, out ulong flagsOut, IntPtr displayLinkContext);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVReturn CVDisplayLinkSetOutputCallback(CVDisplayLinkRef displayLink, CVDisplayLinkOutputCallback callback, IntPtr userInfo);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVReturn CVDisplayLinkGetCurrentTime(CVDisplayLinkRef displayLink, ref CVTimeStamp outTime);

        // FIXME: Boolean?
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool /* Boolean */ CVDisplayLinkIsRunning(CVDisplayLinkRef displayLink);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVReturn CVDisplayLinkStart(CVDisplayLinkRef displayLink);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVReturn CVDisplayLinkStop(CVDisplayLinkRef displayLink);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CVDisplayLinkRelease(CVDisplayLinkRef displayLink);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CVTime CVDisplayLinkGetNominalOutputVideoRefreshPeriod(CVDisplayLinkRef displayLink);
    }
}

