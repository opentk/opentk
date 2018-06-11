using System.Runtime.InteropServices;

using DWORD = System.Int32;

namespace OpenTK.NT.Native
{
    public struct MonitorInfo
    {
        public DWORD cbSize;
        public Rectangle rcMonitor;
        public Rectangle rcWork;
        public DWORD dwFlags;

        public static readonly int SizeInBytes = Marshal.SizeOf<MonitorInfo>();
    }
}
