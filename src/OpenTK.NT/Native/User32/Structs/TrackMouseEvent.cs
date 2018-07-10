using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HWND = System.IntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Used by the <see cref="User32.Mouse.TrackMouseEvent(ref TrackMouseEvent)"/> function to track
    /// when the mouse pointer leaves a window or hovers over a window for a specified amount of time.
    /// </summary>
    public struct TrackMouseEvent
    {
        /// <summary>
        /// The size of the <see cref="TrackMouseEvent"/> structure, in bytes.<para/>
        /// Set this to <see cref="SizeInBytes"/>.
        /// </summary>
        public DWORD Size;

        /// <summary>
        /// The services requested.
        /// </summary>
        public TrackMouseEvents Flags;

        /// <summary>
        /// A handle to the window to track.
        /// </summary>
        public HWND TrackWindowHandle;

        /// <summary>
        /// The hover time-out (if <see cref="TrackMouseEvents.Hover"/> was specified in <see cref="Flags"/>),
        /// in milliseconds. Can be 0xFFFFFFFF ('HOVER_DEFAULT'), which means to use the system default hover time-out.
        /// </summary>
        public DWORD HoverTime;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<TrackMouseEvent>();
    }
}
