// See License.txt file for copyright details

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct CVTime
    {
        public long timeValue;
        public int timeScale;
        public int flags;
    }

    internal class CV
    {
        private const string LibPath = "/System/Library/Frameworks/CoreVideo.framework/Versions/Current/CoreVideo";

        [DllImport(LibPath, EntryPoint = "CVDisplayLinkCreateWithCGDisplay")]
        public static extern IntPtr DisplayLinkCreateWithCGDisplay(IntPtr currentDisplay, out IntPtr displayLink);

        [DllImport(LibPath, EntryPoint = "CVDisplayLinkGetNominalOutputVideoRefreshPeriod")]
        public static extern CVTime DisplayLinkGetNominalOutputVideoRefreshPeriod(IntPtr displayLink);

        [DllImport(LibPath, EntryPoint = "CVDisplayLinkRelease")]
        public static extern void DisplayLinkRelease(IntPtr displayLink);

        internal enum TimeFlags
        {
            TimeIsIndefinite = 1 << 0
        }
    }
}