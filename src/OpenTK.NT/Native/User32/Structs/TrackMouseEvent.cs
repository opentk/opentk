using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HWND = System.IntPtr;

namespace OpenTK.NT.Native
{
    public struct TrackMouseEvent
    {
        public DWORD Size;
        public TrackMouseEventFlags Flags;
        public HWND TrackWindowHandle;
        public DWORD HoverTime;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<TrackMouseEvent>();
    }
}
