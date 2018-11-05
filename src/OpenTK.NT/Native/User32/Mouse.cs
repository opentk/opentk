using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with the mouse.
        /// </summary>
        public static class Mouse
        {
            /// <summary>
            /// Retrieves a handle to the window (if any) that has captured the mouse. Only one window at a time can
            /// capture the mouse; this window receives mouse input whether or not the cursor is within its borders.
            /// </summary>
            /// <returns>
            /// The return value is a handle to the capture window associated with the current thread.<para/>
            /// If no window in the thread has captured the mouse, the return value is <see cref="IntPtr.Zero"/>.
            /// </returns>
            [DllImport(Library)]
            public static extern IntPtr GetCapture();

            /// <summary>
            /// Sets the mouse capture to the specified window belonging to the current thread.
            /// <see cref="SetCapture(IntPtr)"/> captures mouse input either when the mouse is over the capturing window,
            /// or when the mouse button was pressed while the mouse was over the capturing window and the button is
            /// still down. Only one window at a time can capture the mouse.<para/>
            /// If the mouse cursor is over a window created by another thread,
            /// the system will direct mouse input to the specified window only if a mouse button is down.
            /// </summary>
            /// <param name="window">
            /// A handle to the window in the current thread that is to capture the mouse.
            /// </param>
            /// <returns>
            /// The return value is a handle to the window that had previously captured the mouse.
            /// If there is no such window, the return value is <see cref="IntPtr.Zero"/>.
            /// </returns>
            [DllImport(Library)]
            public static extern IntPtr SetCapture(IntPtr window);

            /// <summary>
            /// Releases the mouse capture from a window in the current thread and restores normal mouse input
            /// processing. A window that has captured the mouse receives all mouse input, regardless of the position
            /// of the cursor, except when a mouse button is clicked while the cursor
            /// hot spot is in the window of another thread.
            /// </summary>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ReleaseCapture();

            /// <summary>
            /// Posts messages when the mouse pointer leaves a window or hovers
            /// over a window for a specified amount of time.
            /// </summary>
            /// <param name="trackMouseEvent">
            /// A pointer to a <see cref="Native.TrackMouseEvent"/> structure that contains tracking information.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool TrackMouseEvent([In] [Out] ref TrackMouseEvent trackMouseEvent);

            /// <summary>
            /// Retrieves a history of up to 64 previous coordinates of the mouse or pen.
            /// </summary>
            /// <param name="size">The size, in bytes, of the <see cref="MouseMovePoint"/> structure.</param>
            /// <param name="movePointIn">
            /// A pointer to a <see cref="MouseMovePoint"/> structure containing valid mouse coordinates
            /// (in screen coordinates). It may also contain a time stamp.
            /// </param>
            /// <param name="movePointOutBuffer">
            /// A pointer to a buffer that will receive the points.
            /// It should be at least <paramref name="size"/> * <paramref name="pointAmount"/> in size.
            /// </param>
            /// <param name="pointAmount">The number of points to be retrieved.</param>
            /// <param name="resolution">The resolution desired.</param>
            /// <returns>
            /// If the function succeeds, the return value is the number of points in the buffer.<para/>
            /// Otherwise, the function returns –1.
            /// For extended error information, your application can call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32", SetLastError = true)]
            public static extern int GetMouseMovePointsEx
            (
                [In] uint size,
                [In] ref MouseMovePoint movePointIn,
                [Out] out MouseMovePoint[] movePointOutBuffer,
                [In] int pointAmount,
                [In] GetMouseMovePointsResolution resolution
            );

            /// <summary>
            /// Retrieves a history of up to 64 previous coordinates of the mouse or pen.
            /// </summary>
            /// <param name="size">The size, in bytes, of the <see cref="MouseMovePoint"/> structure.</param>
            /// <param name="movePointIn">
            /// A pointer to a <see cref="MouseMovePoint"/> structure containing valid mouse coordinates
            /// (in screen coordinates). It may also contain a time stamp.
            /// </param>
            /// <param name="movePointOutBuffer">
            /// A pointer to a buffer that will receive the points.
            /// It should be at least <paramref name="size"/> * <paramref name="pointAmount"/> in size.
            /// </param>
            /// <param name="pointAmount">The number of points to be retrieved.</param>
            /// <param name="resolution">The resolution desired.</param>
            /// <returns>
            /// If the function succeeds, the return value is the number of points in the buffer.<para/>
            /// Otherwise, the function returns –1.
            /// For extended error information, your application can call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32", SetLastError = true)]
            public static unsafe extern int GetMouseMovePointsEx
            (
                [In] uint size,
                [In] ref MouseMovePoint movePointIn,
                [Out] MouseMovePoint* movePointOutBuffer,
                [In] int pointAmount,
                [In] GetMouseMovePointsResolution resolution
            );
        }
    }
}
