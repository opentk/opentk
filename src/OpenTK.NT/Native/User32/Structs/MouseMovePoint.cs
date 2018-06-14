using System;
using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using ULONG_PTR = System.IntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains information about the mouse's location in screen coordinates.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseMovePoint
    {
        /// <summary>
        /// The x-coordinate of the mouse.
        /// </summary>
        public int X;

        /// <summary>
        /// The y-coordinate of the mouse.
        /// </summary>
        public int Y;

        /// <summary>
        /// The time stamp of the mouse coordinate.
        /// </summary>
        public DWORD Time;

        /// <summary>
        /// Additional information associated with this coordinate.
        /// </summary>
        public ULONG_PTR ExtraInfo;

        /// <summary>
        /// Returns the size of a MouseMovePoint in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<MouseMovePoint>();
    }
}
