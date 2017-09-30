// See License.txt file for copyright details

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct CVTime
    {
        public Int64 timeValue;
        public Int32 timeScale;
        public Int32 flags;
    }

    internal class CV
    {
        private const string LibPath = "/System/Library/Frameworks/CoreVideo.framework/Versions/Current/CoreVideo";

        internal enum TimeFlags : Int32
        {
            TimeIsIndefinite = 1 << 0
        }

        [DllImport(LibPath, EntryPoint = "CVDisplayLinkCreateWithCGDisplay")]
        public extern static IntPtr DisplayLinkCreateWithCGDisplay(IntPtr currentDisplay, out IntPtr displayLink);

        [DllImport(LibPath, EntryPoint = "CVDisplayLinkGetNominalOutputVideoRefreshPeriod")]
        public extern static CVTime DisplayLinkGetNominalOutputVideoRefreshPeriod(IntPtr displayLink);

        [DllImport(LibPath, EntryPoint = "CVDisplayLinkRelease")]
        public extern static void DisplayLinkRelease(IntPtr displayLink);
    }
}
