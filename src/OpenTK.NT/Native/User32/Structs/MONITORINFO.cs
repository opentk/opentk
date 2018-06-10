using System.Runtime.InteropServices;

using DWORD = System.Int32;

namespace OpenTK.NT.Native
{
    public struct MONITORINFO
    {
        public DWORD cbSize;
        public RECT rcMonitor;
        public RECT rcWork;
        public DWORD dwFlags;

        public static readonly int SizeInBytes = Marshal.SizeOf<MONITORINFO>();
    }
}
