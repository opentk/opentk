using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    public struct MonitorInfo
    {
        public int Size;
        public RECT Monitor;
        public RECT Work;
        public int Flags;

        public static readonly int SizeInBytes = Marshal.SizeOf(default(MonitorInfo));
    }
}
