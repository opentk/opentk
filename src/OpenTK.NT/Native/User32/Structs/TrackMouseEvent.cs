using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used by the <see cref="User32.Mouse.TrackMouseEvent(ref TrackMouseEvent)"/> function to track
    /// when the mouse pointer leaves a window or hovers over a window for a specified amount of time.
    /// </summary>
    public struct TrackMouseEvent
    {
        /// <summary>
        /// Set <see cref="HoverTime"/> to this value to use the system default hover time-out.
        /// </summary>
        public const uint DefaultHoverTime = 0xFFFFFFFF;

        /// <summary>
        /// The size of the <see cref="TrackMouseEvent"/> structure, in bytes.<para/>
        /// Set this to <see cref="SizeInBytes"/>.
        /// </summary>
        public uint Size;

        /// <summary>
        /// The services requested.
        /// </summary>
        public TrackMouseEvents Flags;

        /// <summary>
        /// A handle to the window to track.
        /// </summary>
        public IntPtr TrackWindowHandle;

        /// <summary>
        /// The hover time-out (if <see cref="TrackMouseEvents.Hover"/> was specified in <see cref="Flags"/>), in
        /// milliseconds. Can be <see cref="DefaultHoverTime"/>, which means to use the system default hover time-out.
        /// </summary>
        public uint HoverTime;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<TrackMouseEvent>();
    }
}
