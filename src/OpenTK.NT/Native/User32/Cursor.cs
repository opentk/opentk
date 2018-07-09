using System;
using System.Runtime.InteropServices;
using System.Security;

using HCURSOR = System.IntPtr;
using HINSTANCE = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API, specifically those imported from user32.dll that deal with the cursor.
        /// </summary>
        public static class Cursor
        {
            /// <summary>
            /// Loads the specified cursor resource from a set of pre-defined cursors (see <see cref="CursorName"/>).
            /// </summary>
            /// <param name="cursorName">An identifier for one of the pre-defined cursors.</param>
            /// <returns>
            /// If the function succeeds, the return value is the handle to the newly loaded cursor.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static HCURSOR LoadCursor(CursorName cursorName)
                => LoadCursor(IntPtr.Zero, (int)cursorName);

            /// <summary>
            /// Loads the specified cursor resource from the executable (.EXE) file associated with an application instance.
            /// </summary>
            /// <param name="hInstance">A handle to an instance of the module whose executable file contains the cursor to be loaded.</param>
            /// <param name="lpCursorName">The name of the cursor resource to be loaded.</param>
            /// <returns>
            /// If the function succeeds, the return value is the handle to the newly loaded cursor.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern HCURSOR LoadCursor
            (
                [In] HINSTANCE hInstance,
                [In] string lpCursorName
            );

            /// <summary>
            /// Loads the specified cursor resource from a set of pre-defined cursors (see <see cref="CursorName"/>).
            /// </summary>
            /// <param name="hInstance">Usually a handle to an instance, but null in this overload.</param>
            /// <param name="lpCursorName">An integer consisting of the resource identifier in the low-order word and zero in the high-order word.</param>
            /// <returns>
            /// If the function succeeds, the return value is the handle to the newly loaded cursor.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            private static extern HCURSOR LoadCursor
            (
                [In] [Optional] HINSTANCE hInstance,
                [In] int lpCursorName
            );

            /// <summary>
            /// Confines the cursor to a rectangular area on the screen. If a subsequent cursor position (set by the <see cref="SetCursorPos(int, int)"/> function or the mouse) lies outside the rectangle, the system automatically adjusts the position to keep the cursor inside the rectangular area.
            /// </summary>
            /// <param name="lpRect">A pointer to the structure that contains the screen coordinates of the upper-left and lower-right corners of the confining rectangle. If this parameter is null, the cursor is free to move anywhere on the screen.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.
            /// If the function fails, the return value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ClipCursor([In] [Optional] ref Rect lpRect);

            /// <summary>
            /// Confines the cursor to a rectangular area on the screen. If a subsequent cursor position (set by the <see cref="SetCursorPos(int, int)"/> function or the mouse) lies outside the rectangle, the system automatically adjusts the position to keep the cursor inside the rectangular area.
            /// </summary>
            /// <param name="lpRect">A pointer to the structure that contains the screen coordinates of the upper-left and lower-right corners of the confining rectangle. If this parameter is null, the cursor is free to move anywhere on the screen.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.
            /// If the function fails, the return value is false. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ClipCursor([In] [Optional] IntPtr lpRect);

            /// <summary>
            /// Displays or hides the cursor.
            /// </summary>
            /// <param name="bShow">If true, the display count is incremented by one. If false, the display count is decremented by one.</param>
            /// <returns>The return value specifies the new display counter.</returns>
            [DllImport("user32.dll")]
            public static extern int ShowCursor([In] bool bShow);

            /// <summary>
            /// Retrieves the cursor's position, in screen coordinates.
            /// </summary>
            /// <param name="lpPoint">A pointer to a <see cref="Point"/> structure that receives the screen coordinates of the cursor.</param>
            /// <returns>
            /// Returns true if successful or false otherwise.<para/>
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetCursorPos([Out] out Point lpPoint);

            /// <summary>
            /// Moves the cursor to the specified screen coordinates. If the new coordinates are not within the screen rectangle set by the most recent <see cref="ClipCursor(ref Rect)"/> function call, the system automatically adjusts the coordinates so that the cursor stays within the rectangle.
            /// </summary>
            /// <param name="X">The new x-coordinate of the cursor, in screen coordinates.</param>
            /// <param name="Y">The new y-coordinate of the cursor, in screen coordinates.</param>
            /// <returns>
            /// Returns true if successful or false otherwise.<para/>
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetCursorPos([In] int X, [In] int Y);

            /// <summary>
            /// Retrieves a handle to the current cursor.
            /// </summary>
            /// <returns>
            /// The return value is the handle to the current cursor. If there is
            /// no cursor, the return value is null.
            /// </returns>
            [DllImport("user32.dll")]
            public static extern HCURSOR GetCursor();

            /// <summary>
            /// Sets the cursor shape.
            /// </summary>
            /// <param name="hCursor">
            /// A handle to the cursor. The cursor must have been created by the CreateCursor function or loaded by the <see cref="LoadCursor(HCURSOR, string)"/> or LoadImage function. If this parameter is null, the cursor is removed from the screen.
            /// </param>
            /// <returns>
            /// The return value is the handle to the previous cursor, if there was one.
            /// If there was no previous cursor, the return value is null.
            /// </returns>
            [DllImport("user32.dll")]
            public static extern HCURSOR SetCursor([In] [Optional] HCURSOR hCursor);
        }
    }
}
