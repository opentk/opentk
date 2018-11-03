using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about a display monitor.
    /// </summary>
    public struct MonitorInfo
    {
        /// <summary>
        /// The size of the structure, in bytes. Set this member to <see cref="SizeInBytes"/> before calling the
        /// <see cref="User32.Monitor.GetMonitorInfo(System.IntPtr, out MonitorInfo)"/> function.
        /// </summary>
        public uint Size;

        /// <summary>
        /// A <see cref="Rect"/> structure that specifies the display monitor rectangle, expressed in virtual-screen
        /// coordinates. Note that if the monitor is not the primary display monitor, some of the rectangle's
        /// coordinates may be negative values.
        /// </summary>
        public Rect Monitor;

        /// <summary>
        /// A <see cref="Rect"/> structure that specifies the work area rectangle of the display monitor,
        /// expressed in virtual-screen coordinates. Note that if the monitor is not the primary display monitor,
        /// some of the rectangle's coordinates may be negative values.
        /// </summary>
        public Rect Work;

        /// <summary>
        /// A set of flags that represent attributes of the display monitor.<para/>
        /// The (currently only) defined flag is "Primary" with a value of 1, so a value of 1 means the display is
        /// primary while a value of 0 means that it is not.
        /// </summary>
        public uint Flags;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<MonitorInfo>();
    }
}
