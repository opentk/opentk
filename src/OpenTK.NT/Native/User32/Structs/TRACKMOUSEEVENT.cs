using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HWND = System.IntPtr;

namespace OpenTK.NT.Native
{
    public struct TRACKMOUSEEVENT
    {
        public DWORD cbSize;
        public TRACKMOUSEEVENT_FLAGS dwFlags;
        public HWND TrackWindowHandle;
        public DWORD dwHoverTime;

        public static readonly int SizeInBytes = Marshal.SizeOf<TRACKMOUSEEVENT>();
    }
}
