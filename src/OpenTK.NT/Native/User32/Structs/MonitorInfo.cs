using System.Runtime.InteropServices;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public struct MonitorInfo
    {
        public DWORD cbSize;
        public Rect rcMonitor;
        public Rect rcWork;
        public DWORD dwFlags;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<MonitorInfo>();
    }
}
