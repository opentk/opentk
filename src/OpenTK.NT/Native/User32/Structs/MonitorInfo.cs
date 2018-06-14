using System.Runtime.InteropServices;

using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public struct MonitorInfo
    {
        public DWORD Size;
        public Rect Monitor;
        public Rect Work;
        public DWORD Flags;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<MonitorInfo>();
    }
}
