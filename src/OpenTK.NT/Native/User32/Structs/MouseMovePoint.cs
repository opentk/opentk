using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about the mouse's location in screen coordinates.
    /// </summary>
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
        public uint Time;

        /// <summary>
        /// Additional information associated with this coordinate.
        /// </summary>
        public IntPtr ExtraInfo;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<MouseMovePoint>();
    }
}
