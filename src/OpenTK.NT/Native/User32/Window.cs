using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;

using HINSTANCE = System.IntPtr;
using HMENU = System.IntPtr;
using HWND = System.IntPtr;
using LONG_PTR = System.IntPtr;
using LPARAM = System.IntPtr;
using LPTSTR = System.Text.StringBuilder;
using LPVOID = System.IntPtr;
using LRESULT = System.IntPtr;
using WNDPROC = System.IntPtr;
using WPARAM = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Window
        {
            /// <summary>
            /// Calculates the required size of the window rectangle, based on the desired client-rectangle size. The window
            /// rectangle can then be passed to the CreateWindow function to create a window whose client area is the desired size.
            /// </summary>
            /// <param name="lpRect">
            /// [in, out] Pointer to a RECT structure that contains the coordinates of the top-left and
            /// bottom-right corners of the desired client area. When the function returns, the structure contains the coordinates
            /// of the top-left and bottom-right corners of the window to accommodate the desired client area.
            /// </param>
            /// <param name="dwStyle">
            /// [in] Specifies the window style of the window whose required size is to be calculated. Note that
            /// you cannot specify the WS_OVERLAPPED style.
            /// </param>
            /// <param name="bMenu">[in] Specifies whether the window has a menu.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero. To get extended error information, call GetLastError.
            /// </returns>
            /// <remarks>
            /// A client rectangle is the smallest rectangle that completely encloses a client area. A window rectangle is the
            /// smallest rectangle that completely encloses the window, which includes the client area and the nonclient area.
            /// The AdjustWindowRect function does not add extra space when a menu bar wraps to two or more rows.
            /// The AdjustWindowRect function does not take the WS_VSCROLL or WS_HSCROLL styles into account. To account for the
            /// scroll bars, call the GetSystemMetrics function with SM_CXVSCROLL or SM_CYHSCROLL.
            /// Found Winuser.h, user32.dll
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            public static extern bool AdjustWindowRect(
                [In] [Out] ref Rect lpRect,
                [In] WindowStyles dwStyle,
                [In] bool bMenu
            );

            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AdjustWindowRectEx(
                [In] [Out] ref Rect lpRect,
                [In] WindowStyles dwStyle,
                [In] [MarshalAs(UnmanagedType.Bool)] bool bMenu,
                [In] WindowStylesEx dwExStyle
            );

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern HWND CreateWindowEx(
                [In] WindowStylesEx dwExStyle,
                [In] [Optional] [MarshalAs(UnmanagedType.LPTStr)] string lpClassName,
                [In] [Optional] [MarshalAs(UnmanagedType.LPTStr)] string lpWindowName,
                [In] WindowStyles dwStyle,
                [In] int x,
                [In] int y,
                [In] int nWidth,
                [In] int nHeight,
                [In] [Optional] HWND hWndParent,
                [In] [Optional] HMENU hMenu,
                [In] [Optional] HINSTANCE hInstance,
                [In] [Optional] LPVOID lpParam
            );

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern HWND CreateWindowEx(
                [In] WindowStylesEx dwExStyle,
                [In] [Optional] IntPtr lpClassAtom,
                [In] [Optional] string lpWindowName,
                [In] WindowStyles dwStyle,
                [In] int x,
                [In] int y,
                [In] int nWidth,
                [In] int nHeight,
                [In] [Optional] HWND hWndParent,
                [In] [Optional] HMENU hMenu,
                [In] [Optional] HINSTANCE hInstance,
                [In] [Optional] LPVOID lpParam
            );

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DestroyWindow([In] HWND hWnd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern LRESULT CallWindowProc(
                [In] WNDPROC lpPrevWndFunc,
                [In] HWND hWnd,
                [In] WindowMessage Msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            /// <summary>
            /// Sets the current process as dots per inch (dpi) aware.
            /// Note: SetProcessDPIAware is subject to a possible race condition
            /// if a DLL caches dpi settings during initialization.
            /// For this reason, it is recommended that dpi-aware be set through
            /// the application (.exe) manifest rather than by calling SetProcessDPIAware.
            /// </summary>
            /// <returns>
            /// If the function succeeds, the return value is true.
            /// Otherwise, the return value is false.
            /// </returns>
            /// <remarks>
            /// DLLs should accept the dpi setting of the host process
            /// rather than call SetProcessDPIAware themselves.
            /// To be set properly, dpiAware should be specified as part
            /// of the application (.exe) manifest.
            /// </remarks>
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetProcessDPIAware();

            // SetWindowLongPtr does not exist on x86 platforms (it's a macro that resolves to SetWindowLong).
            // We need to detect if we are on x86 or x64 at runtime and call the correct function
            public static IntPtr SetWindowLong(HWND hWnd, int nIndex, LONG_PTR dwNewLong)
            {
                Kernel32.SetLastError(0); // not sure we have to do this

                IntPtr result;
                if (IntPtr.Size == 4)
                    result = new IntPtr(SetWindowLongInternal(hWnd, nIndex, dwNewLong.ToInt32()));
                else
                    result = SetWindowLongPtrInternal(hWnd, nIndex, dwNewLong);

                int error;
                if (result == IntPtr.Zero && (error = Marshal.GetLastWin32Error()) != 0)
                    new Win32Exception(error, "Failed to modify window border.");

                return result;
            }

            public static IntPtr SetWindowLong(HWND hWnd, GetWindowLongIndex nIndex, LONG_PTR dwNewLong)
                => SetWindowLong(hWnd, (int)nIndex, dwNewLong);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
            private static extern int SetWindowLongInternal(
                [In] HWND hWnd,
                [In] int nIndex,
                [In] int dwNewLong
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
            private static extern int SetWindowLongInternal(
                [In] HWND hWnd,
                [In] int nIndex,
                [In] [MarshalAs(UnmanagedType.FunctionPtr)] WindowProc dwNewLong
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
            private static extern LONG_PTR SetWindowLongPtrInternal(
                [In] HWND hWnd,
                [In] int nIndex,
                [In] LONG_PTR dwNewLong
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
            private static extern LONG_PTR SetWindowLongPtrInternal(
                [In] HWND hWnd,
                [In] int nIndex,
                [In] [MarshalAs(UnmanagedType.FunctionPtr)] WindowProc dwNewLong
            );

            public static IntPtr SetWindowLong(HWND hWnd, WindowProc newValue)
                => SetWindowLong(hWnd, GetWindowLongIndex.WindowProcedure, Marshal.GetFunctionPointerForDelegate(newValue));

            public static IntPtr GetWindowLong(HWND hWnd, GetWindowLongIndex nIndex)
                => GetWindowLong(hWnd, (int)nIndex);

            public static IntPtr GetWindowLong(HWND hWnd, int nIndex)
            {
                if (IntPtr.Size == 4)
                    return new IntPtr(GetWindowLongInternal(hWnd, nIndex));

                return GetWindowLongPtrInternal(hWnd, nIndex);
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowLong")]
            private static extern int GetWindowLongInternal([In] HWND hWnd, [In] int nIndex);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowLongPtr")]
            private static extern IntPtr GetWindowLongPtrInternal([In] HWND hWnd, [In] int nIndex);

            [DllImport("User32.dll", CharSet = CharSet.Auto)]
            public static extern LRESULT DefWindowProc(
                [In] HWND hWnd,
                [In] WindowMessage Msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            /// <summary>
            /// The ShowWindow function sets the specified window's show state.
            /// </summary>
            /// <param name="hWnd">[in] Handle to the window.</param>
            /// <param name="nCmdShow">
            /// [in] Specifies how the window is to be shown. This parameter is ignored the first time an
            /// application calls ShowWindow, if the program that launched the application provides a STARTUPINFO structure.
            /// Otherwise, the first time ShowWindow is called, the value should be the value obtained by the WinMain function in
            /// its nCmdShow parameter. In subsequent calls, this parameter can be one of the ShowWindowEnum values.
            /// </param>
            /// <returns>If the window was previously visible, the return value is true. Otherwise false.</returns>
            /// <remarks>
            ///  <para>To perform certain special effects when showing or hiding a window, use AnimateWindow.</para>
            ///  <para>
            /// The first time an application calls ShowWindow, it should use the WinMain function's nCmdShow parameter as
            /// its nCmdShow parameter. Subsequent calls to ShowWindow must use one of the values in the given list, instead of
            /// the one specified by the WinMain function's nCmdShow parameter.
            ///  </para>
            ///  <para>
            /// As noted in the discussion of the nCmdShow parameter, the nCmdShow value is ignored in the first call to
            /// ShowWindow if the program that launched the application specifies startup information in the structure. In this
            /// case, ShowWindow uses the information specified in the STARTUPINFO structure to show the window. On subsequent
            /// calls, the application must call ShowWindow with nCmdShow set to SW_SHOWDEFAULT to use the startup information
            /// provided by the program that launched the application. This behavior is designed for the following situations:
            ///  </para>
            ///  <list type="">
            ///  <item>Applications create their main window by calling CreateWindow with the WS_VISIBLE flag set.</item>
            ///  <item>
            /// Applications create their main window by calling CreateWindow with the WS_VISIBLE flag cleared, and later
            /// call ShowWindow with the SW_SHOW flag set to make it visible.
            ///  </item>
            ///  </list>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ShowWindow([In] HWND hWnd, [In] ShowWindowCommand nCmdShow);

            /// <summary>
            /// The GetWindowText function copies the text of the specified window's title bar (if it has one) into a buffer. If
            /// the specified window is a control, the text of the control is copied. However, GetWindowText cannot retrieve the
            /// text of a control in another application.
            /// </summary>
            /// <param name="hWnd">[in] Handle to the window or control containing the text.</param>
            /// <param name="lpString">
            /// [out] Pointer to the buffer that will receive the text. If the string is as long or longer than
            /// the buffer, the string is truncated and terminated with a NULL character.
            /// </param>
            /// <param name="nMaxCount">
            /// [in] Specifies the maximum number of characters to copy to the buffer, including the NULL
            /// character. If the text exceeds this limit, it is truncated.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is the length, in characters, of the copied string, not including the
            /// terminating NULL character. If the window has no title bar or text, if the title bar is empty, or if the window or
            /// control handle is invalid, the return value is zero. To get extended error information, call GetLastError.
            ///  <para>This function cannot retrieve the text of an edit control in another application.</para>
            /// </returns>
            /// <remarks>
            ///  <para>
            /// If the target window is owned by the current process, GetWindowText causes a WM_GETTEXT message to be sent to
            /// the specified window or control. If the target window is owned by another process and has a caption,
            /// GetWindowText retrieves the window caption text. If the window does not have a caption, the return value is a
            /// null string. This behavior is by design. It allows applications to call GetWindowText without becoming
            /// unresponsive if the process that owns the target window is not responding. However, if the target window is not
            /// responding and it belongs to the calling application, GetWindowText will cause the calling application to
            /// become unresponsive.
            ///  </para>
            ///  <para>
            /// To retrieve the text of a control in another process, send a WM_GETTEXT message directly instead of calling
            /// GetWindowText.
            ///  </para>
            ///  <para>
            /// Windows 95/98/Me: GetWindowTextW is supported by the Microsoft Layer for Unicode (MSLU). To use this, you
            /// must add certain files to your application, as outlined in Microsoft Layer for Unicode on Windows 95/98/Me
            ///  </para>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern int GetWindowText(
                [In] HWND hWnd,
                [In] [Out] [MarshalAs(UnmanagedType.LPTStr)] LPTSTR lpString,
                [In] int nMaxCount
            );

            /// <summary>
            /// The SetWindowText function changes the text of the specified window's title bar (if it has one). If the specified
            /// window is a control, the text of the control is changed. However, SetWindowText cannot change the text of a control
            /// in another application.
            /// </summary>
            /// <param name="hWnd">[in] Handle to the window or control whose text is to be changed.</param>
            /// <param name="lpString">[in] Pointer to a null-terminated string to be used as the new title or control text.</param>
            /// <returns>
            ///  <para>If the function succeeds, the return value is nonzero.</para>
            ///  <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
            /// </returns>
            /// <remarks>
            ///  <para>
            /// If the target window is owned by the current process, SetWindowText causes a WM_SETTEXT message to be sent to
            /// the specified window or control. If the control is a list box control created with the WS_CAPTION style,
            /// however, SetWindowText sets the text for the control, not for the list box entries.
            ///  </para>
            ///  <para>
            /// To set the text of a control in another process, send the WM_SETTEXT message directly instead of calling
            /// SetWindowText.
            ///  </para>
            ///  <para>
            /// The SetWindowText function does not expand tab characters (ASCII code 0x09). Tab characters are displayed as
            /// vertical bar (|) characters.
            ///  </para>
            ///  <para>
            /// Windows 95/98/Me: SetWindowTextW is supported by the Microsoft Layer for Unicode (MSLU). To use this, you
            /// must add certain files to your application, as outlined in Microsoft Layer for Unicode on Windows 95/98/Me
            /// Systems .
            ///  </para>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetWindowText(
                [In] HWND hWnd,
                [In] [Optional] [MarshalAs(UnmanagedType.LPTStr)] string lpString
            );

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetWindowPos(
                [In] HWND hWnd,
                [In] [Optional] HWND hWndInsertAfter,
                [In] int x,
                [In] int y,
                [In] int cx,
                [In] int cy,
                [In] SetWindowPosFlags flags
            );

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetForegroundWindow([In] HWND hWnd);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool BringWindowToTop([In] HWND hWnd);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern HWND SetParent(
                [In] HWND hWndChild,
                [In] [Optional] HWND newParent
            );

            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowInfo([In] HWND hwnd, [In] [Out] ref WindowInfo wi);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool IsWindowVisible([In] HWND hWNd);

            /// <summary>
            /// The GetWindowRect function retrieves the dimensions of the bounding rectangle of the specified window. The
            /// dimensions are given in screen coordinates that are relative to the upper-left corner of the screen.
            /// </summary>
            /// <param name="windowHandle">Handle to the window whose client coordinates are to be retrieved.</param>
            /// <param name="windowRectangle">
            /// Pointer to a structure that receives the screen coordinates of the upper-left and
            /// lower-right corners of the window.
            /// </param>
            /// <returns>
            ///  <para>If the function succeeds, the return value is nonzero.</para>
            ///  <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
            /// </returns>
            /// <remarks>
            /// In conformance with conventions for the RECT structure, the bottom-right coordinates of the returned rectangle
            /// are exclusive. In other words, the pixel at (right, bottom) lies immediately outside the rectangle.
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowRect([In] HWND windowHandle, [Out] out Rect windowRectangle);

            /// <summary>
            /// The GetClientRect function retrieves the coordinates of a window's client area. The client coordinates specify the
            /// upper-left and lower-right corners of the client area. Because client coordinates are relative to the upper-left
            /// corner of a window's client area, the coordinates of the upper-left corner are (0,0).
            /// </summary>
            /// <param name="windowHandle">Handle to the window whose client coordinates are to be retrieved.</param>
            /// <param name="clientRectangle">
            /// Pointer to a RECT structure that receives the client coordinates. The left and top
            /// members are zero. The right and bottom members contain the width and height of the window.
            /// </param>
            /// <returns>
            ///  <para>If the function succeeds, the return value is nonzero.</para>
            ///  <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
            /// </returns>
            /// <remarks>
            /// In conformance with conventions for the RECT structure, the bottom-right coordinates of the returned rectangle
            /// are exclusive. In other words, the pixel at (right, bottom) lies immediately outside the rectangle.
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetClientRect([In] HWND windowHandle, [Out] out Rect clientRectangle);

            /// <summary>
            /// Converts the screen coordinates of a specified point on the screen to client-area coordinates.
            /// </summary>
            /// <param name="hWnd">Handle to the window whose client area will be used for the conversion.</param>
            /// <param name="point">Pointer to a POINT structure that specifies the screen coordinates to be converted.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.
            /// Windows NT/2000/XP: To get extended error information, call GetLastError.
            /// </returns>
            /// <remarks>
            ///  <para>
            /// The function uses the window identified by the hWnd parameter and the screen coordinates given in the POINT
            /// structure to compute client coordinates. It then replaces the screen coordinates with the client coordinates.
            /// The new coordinates are relative to the upper-left corner of the specified window's client area.
            ///  </para>
            ///  <para>The ScreenToClient function assumes the specified point is in screen coordinates. </para>
            ///  <para>All coordinates are in device units.</para>
            ///  <para>
            /// Do not use ScreenToClient when in a mirroring situation, that is, when changing from left-to-right layout to
            /// right-to-left layout. Instead, use MapWindowPoints. For more information, see "Window Layout and Mirroring" in
            /// Window Features.
            ///  </para>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ScreenToClient([In] HWND hWnd, ref Point lpPoint);

            /// <summary>
            /// Converts the client-area coordinates of a specified point to screen coordinates.
            /// </summary>
            /// <param name="hWnd">Handle to the window whose client area will be used for the conversion.</param>
            /// <param name="point">
            /// Pointer to a POINT structure that contains the client coordinates to be converted. The new screen
            /// coordinates are copied into this structure if the function succeeds.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.
            /// Windows NT/2000/XP: To get extended error information, call GetLastError.
            /// </returns>
            /// <remarks>
            ///  <para>
            /// The ClientToScreen function replaces the client-area coordinates in the POINT structure with the screen
            /// coordinates. The screen coordinates are relative to the upper-left corner of the screen. Note, a
            /// screen-coordinate point that is above the window's client area has a negative y-coordinate. Similarly, a screen
            /// coordinate to the left of a client area has a negative x-coordinate.
            ///  </para>
            ///  <para>All coordinates are device coordinates.</para>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ClientToScreen([In] HWND hWnd, [In] [Out] ref Point point);
        }
    }
}
