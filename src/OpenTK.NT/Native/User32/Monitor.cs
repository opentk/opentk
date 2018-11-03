using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with monitors.
        /// </summary>
        public static class Monitor
        {
            /// <summary>
            /// Retrieves information about a display monitor.
            /// </summary>
            /// <param name="monitor">A handle to the display monitor of interest.</param>
            /// <param name="monitorInfo">
            /// A pointer to a <see cref="MonitorInfo"/> or MONITORINFOEX structure
            /// that receives information about the specified display monitor.<para/>
            /// You must set the Size member of the structure to the respective structure's size in bytes
            /// before calling the <see cref="GetMonitorInfo(IntPtr, out MonitorInfo)"/> function. Doing so
            /// lets the function determine the type of structure you are passing to it.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.<para/>
            /// If the function fails, the return value is zero.
            /// </returns>
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetMonitorInfo([In] IntPtr monitor, [Out] out MonitorInfo monitorInfo);

            /// <summary>
            /// Retrieves a handle to the display monitor that contains a specified point.
            /// </summary>
            /// <param name="pt">
            /// A <see cref="Point"/> structure that specifies the point of interest in virtual-screen coordinates.
            /// </param>
            /// <param name="defaultTo">
            /// Determines the function's return value if the point is not contained within any display monitor.
            /// </param>
            /// <returns>
            /// If the point is contained by a display monitor,
            /// the return value is an <see cref="IntPtr"/> handle to that display monitor.<para/>
            /// If the point is not contained by a display monitor,
            /// the return value depends on the value of <paramref name="defaultTo"/>.
            /// </returns>
            [DllImport(Library)]
            public static extern IntPtr MonitorFromPoint([In] Point pt, [In] MonitorFromDefaultValue defaultTo);

            /// <summary>
            /// Retrieves a handle to the display monitor that has the largest area of intersection
            /// with the bounding rectangle of a specified window.
            /// </summary>
            /// <param name="window">A handle to the window of interest.</param>
            /// <param name="defaultTo">
            /// Determines the function's return value if the window does not intersect any display monitor.
            /// </param>
            /// <returns>
            /// If the window intersects one or more display monitor rectangles, the return value is an
            /// <see cref="IntPtr"/> handle to the display monitor that
            /// has the largest area of intersection with the window.<para/>
            /// If the window does not intersect a display monitor,
            /// the return value depends on the value of <paramref name="defaultTo"/>.
            /// </returns>
            [DllImport(Library)]
            public static extern IntPtr MonitorFromWindow([In] IntPtr window, [In] MonitorFromDefaultValue defaultTo);
        }
    }
}
