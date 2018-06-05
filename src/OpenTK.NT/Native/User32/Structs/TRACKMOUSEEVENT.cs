using System.Runtime.InteropServices;

using HWND = System.IntPtr;

namespace OpenTK.NT.Native
{
    public struct TrackMouseEventStructure
    {
        public int Size;
        public TrackMouseEventFlags Flags;
        public HWND TrackWindowHandle;
        public int HoverTime;

        public static readonly int SizeInBytes = Marshal.SizeOf(typeof(TrackMouseEventStructure));
    }
}
