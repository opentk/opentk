using System;
using System.Runtime.InteropServices;
using System.Security;

using HCURSOR = System.IntPtr;
using HINSTANCE = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Cursor
        {
            public static HCURSOR LoadCursor(CursorName lpCursorName)
                => LoadCursor(IntPtr.Zero, new IntPtr((int)lpCursorName));

            [DllImport("user32.dll", SetLastError = true)]
            public static extern HCURSOR LoadCursor(
                [In] [Optional] HINSTANCE hInstance,
                [In] [MarshalAs(UnmanagedType.LPTStr)] string lpCursorName
            );

            [DllImport("user32.dll", SetLastError = true)]
            public static extern HCURSOR LoadCursor(
                [In] [Optional] HINSTANCE hInstance,
                [In] IntPtr lpCursorName
            );

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ClipCursor([In] [Optional] ref Rect lpRect);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ClipCursor([In] [Optional] IntPtr rcClip);

            [DllImport("user32.dll")]
            public static extern int ShowCursor([In] bool show);

            /// <summary>
            /// Retrieves the cursor's position, in screen coordinates.
            /// </summary>
            /// <param name="point">Pointer to a POINT structure that receives the screen coordinates of the cursor.</param>
            /// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
            /// <remarks>
            ///  <para>
            /// The cursor position is always specified in screen coordinates and is not affected by the mapping mode of the
            /// window that contains the cursor.
            ///  </para>
            ///  <para>The calling process must have WINSTA_READATTRIBUTES access to the window station.</para>
            ///  <para>
            /// The input desktop must be the current desktop when you call GetCursorPos. Call OpenInputDesktop to determine
            /// whether the current desktop is the input desktop. If it is not, call SetThreadDesktop with the HDESK returned
            /// by OpenInputDesktop to switch to that desktop.
            ///  </para>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetCursorPos([Out] out Point lpPoint);

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
            /// A handle to the cursor. The cursor must have been created by the
            /// CreateCursor function or loaded by the LoadCursor or LoadImage
            /// function. If this parameter is IntPtr.Zero, the cursor is removed
            /// from the screen.
            /// </param>
            /// <returns>
            /// The return value is the handle to the previous cursor, if there was one.
            /// If there was no previous cursor, the return value is null.
            /// </returns>
            /// <remarks>
            /// The cursor is set only if the new cursor is different from the
            /// previous cursor; otherwise, the function returns immediately.
            /// The cursor is a shared resource. A window should set the cursor
            /// shape only when the cursor is in its client area or when the window
            /// is capturing mouse input. In systems without a mouse, the window
            /// should restore the previous cursor before the cursor leaves the
            /// client area or before it relinquishes control to another window.
            /// If your application must set the cursor while it is in a window,
            /// make sure the class cursor for the specified window's class is set
            /// to NULL. If the class cursor is not NULL, the system restores the
            /// class cursor each time the mouse is moved.
            /// The cursor is not shown on the screen if the internal cursor
            /// display count is less than zero. This occurs if the application
            /// uses the ShowCursor function to hide the cursor more times than to
            /// show the cursor.
            /// </remarks>
            [DllImport("user32.dll")]
            public static extern HCURSOR SetCursor([In] [Optional] HCURSOR hCursor);
        }
    }
}
