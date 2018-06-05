using System;
using System.Runtime.InteropServices;
using System.Security;

using HANDLE = System.IntPtr;
using HCURSOR = System.IntPtr;
using HDEVNOTIFY = System.IntPtr;
using HICON = System.IntPtr;
using HINSTANCE = System.IntPtr;
using HMONITOR = System.IntPtr;
using HRAWINPUT = System.IntPtr;
using HWND = System.IntPtr;
using LONG_PTR = System.IntPtr;
using LPARAM = System.IntPtr;
using LPTSTR = System.Text.StringBuilder;
using LPVOID = System.IntPtr;
using LRESULT = System.IntPtr;
using UINT_PTR = System.IntPtr;
using WNDPROC = System.IntPtr;
using WPARAM = System.IntPtr;
using TIMERPROC = OpenTK.NT.Native.TimerProc;

namespace OpenTK.NT.Native
{
    public static class User32
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetWindowPos(
            IntPtr handle,
            IntPtr insertAfter,
            int x, int y, int cx, int cy,
            SetWindowPosFlags flags
        );

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
        internal static extern bool AdjustWindowRect([In] [Out] ref RECT lpRect, WindowStyle dwStyle,
            bool bMenu);

        [DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx", CallingConvention = CallingConvention.StdCall,
            SetLastError = true)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AdjustWindowRectEx(
            ref RECT lpRect,
            WindowStyle dwStyle,
            [MarshalAs(UnmanagedType.Bool)] bool bMenu,
            ExtendedWindowStyle dwExStyle);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateWindowEx(
            ExtendedWindowStyle ExStyle,
            [MarshalAs(UnmanagedType.LPTStr)] string className,
            [MarshalAs(UnmanagedType.LPTStr)] string windowName,
            WindowStyle Style,
            int X, int Y,
            int Width, int Height,
            IntPtr HandleToParentWindow,
            IntPtr Menu,
            IntPtr Instance,
            IntPtr Param);

        /*
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int CreateWindowEx(
            [In]ExtendedWindowStyle ExStyle,
            [In]IntPtr ClassName,
            [In]IntPtr WindowName,
            [In]WindowStyle Style,
            [In]int X, [In]int Y,
            [In]int Width, [In]int Height,
            [In]IntPtr HandleToParentWindow,
            [In]IntPtr Menu,
            [In]IntPtr Instance,
            [In]IntPtr Param);
        */
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateWindowEx(
            ExtendedWindowStyle ExStyle,
            IntPtr ClassAtom,
            IntPtr WindowName,
            WindowStyle Style,
            int X, int Y,
            int Width, int Height,
            IntPtr HandleToParentWindow,
            IntPtr Menu,
            IntPtr Instance,
            IntPtr Param);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DestroyWindow(IntPtr windowHandle);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern ushort RegisterClass(ref WindowClass window_class);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern ushort RegisterClassEx(ref ExtendedWindowClass window_class);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern short UnregisterClass([MarshalAs(UnmanagedType.LPTStr)] string className,
            IntPtr instance);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern short UnregisterClass(IntPtr className, IntPtr instance);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern bool GetClassInfoEx(HINSTANCE hinst,
            [MarshalAs(UnmanagedType.LPTStr)] string lpszClass, ref ExtendedWindowClass lpwcx);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern bool GetClassInfoEx(HINSTANCE hinst, UIntPtr lpszClass, ref ExtendedWindowClass lpwcx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern LRESULT CallWindowProc(WNDPROC lpPrevWndFunc, HWND hWnd, WindowMessage Msg,
            WPARAM wParam, LPARAM lParam);

        // SetWindowLongPtr does not exist on x86 platforms (it's a macro that resolves to SetWindowLong).
        // We need to detect if we are on x86 or x64 at runtime and call the correct function
        // (SetWindowLongPtr on x64 or SetWindowLong on x86). Fun!
        internal static IntPtr SetWindowLong(IntPtr handle, GetWindowLongOffsets item, IntPtr newValue)
        {
            // SetWindowPos defines its error condition as an IntPtr.Zero retval and a non-0 GetLastError.
            // We need to SetLastError(0) to ensure we are not detecting on older error condition (from another function).

            var retval = IntPtr.Zero;
            SetLastError(0);

            if (IntPtr.Size == 4)
            {
                retval = new IntPtr(SetWindowLongInternal(handle, item, newValue.ToInt32()));
            }
            else
            {
                retval = SetWindowLongPtrInternal(handle, item, newValue);
            }

            if (retval == IntPtr.Zero)
            {
                var error = Marshal.GetLastWin32Error();
                if (error != 0)
                {
                    throw new PlatformException($"Failed to modify window border. Error: {error}");
                }
            }

            return retval;
        }

        internal static IntPtr SetWindowLong(IntPtr handle, WindowProcedure newValue)
        {
            return SetWindowLong(handle, GetWindowLongOffsets.WNDPROC, Marshal.GetFunctionPointerForDelegate(newValue));
        }

        internal static UIntPtr GetWindowLong(IntPtr handle, GetWindowLongOffsets index)
        {
            if (IntPtr.Size == 4)
            {
                return (UIntPtr)GetWindowLongInternal(handle, index);
            }

            return GetWindowLongPtrInternal(handle, index);
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLongInternal(HWND hWnd, GetWindowLongOffsets nIndex, int dwNewLong);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
        private static extern LONG_PTR SetWindowLongPtrInternal(HWND hWnd, GetWindowLongOffsets nIndex, LONG_PTR dwNewLong);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLongInternal(HWND hWnd, GetWindowLongOffsets nIndex,
            [MarshalAs(UnmanagedType.FunctionPtr)] WindowProcedure dwNewLong);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
        private static extern LONG_PTR SetWindowLongPtrInternal(HWND hWnd, GetWindowLongOffsets nIndex,
            [MarshalAs(UnmanagedType.FunctionPtr)] WindowProcedure dwNewLong);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLongInternal(HWND hWnd, GetWindowLongOffsets nIndex);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowLongPtr")]
        private static extern UIntPtr GetWindowLongPtrInternal(HWND hWnd, GetWindowLongOffsets nIndex);

        /// <summary>
        /// Low-level WINAPI function that checks the next message in the queue.
        /// </summary>
        /// <param name="msg">The pending message (if any) is stored here.</param>
        /// <param name="hWnd">Not used</param>
        /// <param name="messageFilterMin">Not used</param>
        /// <param name="messageFilterMax">Not used</param>
        /// <param name="flags">Not used</param>
        /// <returns>True if there is a message pending.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PeekMessage(ref MSG msg, IntPtr hWnd, int messageFilterMin, int messageFilterMax,
            PeekMessageFlags flags);

        /// <summary>
        /// Low-level WINAPI function that retrieves the next message in the queue.
        /// </summary>
        /// <param name="msg">The pending message (if any) is stored here.</param>
        /// <param name="windowHandle">Not used</param>
        /// <param name="messageFilterMin">Not used</param>
        /// <param name="messageFilterMax">Not used</param>
        /// <returns>
        /// Nonzero indicates that the function retrieves a message other than WM_QUIT.
        /// Zero indicates that the function retrieves the WM_QUIT message, or that lpMsg is an invalid pointer.
        /// 1 indicates that an error occurred  for example, the function fails if hWnd is an invalid window handle.
        /// To get extended error information, call GetLastError.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        internal static extern int GetMessage(ref MSG msg,
            IntPtr windowHandle, int messageFilterMin, int messageFilterMax);

        /// <summary>
        /// Retrieves the message time for the last message retrieved by the
        /// GetMessage function. The time is a long integer that specifies the
        /// elapsed time, in milliseconds, from the time the system was started
        /// to the time the message was created (that is, placed in the thread's
        /// message queue).
        /// </summary>
        /// <returns>The return value specifies the message time.</returns>
        [DllImport("User32.dll")]
        internal static extern int GetMessageTime();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern LRESULT SendMessage(HWND hWnd, WindowMessage Msg, WPARAM wParam, LPARAM lParam);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PostMessage(
            HWND hWnd,
            WindowMessage Msg,
            WPARAM wParam,
            LPARAM lParam
        );

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        internal static extern void PostQuitMessage(int exitCode);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        internal static extern LRESULT DispatchMessage(ref MSG msg);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        internal static extern bool TranslateMessage(ref MSG lpMsg);

        /// <summary>
        /// Indicates the type of messages found in the calling thread's message queue.
        /// </summary>
        /// <param name="flags"></param>
        /// <returns>
        /// The high-order word of the return value indicates the types of messages currently in the queue.
        /// The low-order word indicates the types of messages that have been added to the queue and that are still
        /// in the queue since the last call to the GetQueueStatus, GetMessage, or PeekMessage function.
        /// </returns>
        /// <remarks>
        /// The presence of a QS_ flag in the return value does not guarantee that
        /// a subsequent call to the GetMessage or PeekMessage function will return a message.
        /// GetMessage and PeekMessage perform some internal filtering that may cause the message
        /// to be processed internally. For this reason, the return value from GetQueueStatus
        /// should be considered only a hint as to whether GetMessage or PeekMessage should be called.
        ///  <para>
        /// The QS_ALLPOSTMESSAGE and QS_POSTMESSAGE flags differ in when they are cleared.
        /// QS_POSTMESSAGE is cleared when you call GetMessage or PeekMessage, whether or not you are filtering messages.
        /// QS_ALLPOSTMESSAGE is cleared when you call GetMessage or PeekMessage without filtering messages
        /// (wMsgFilterMin and wMsgFilterMax are 0). This can be useful when you call PeekMessage multiple times
        /// to get messages in different ranges.
        ///  </para>
        /// </remarks>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        internal static extern int GetQueueStatus([MarshalAs(UnmanagedType.U4)] QueueStatusFlags flags);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr DefWindowProc(HWND hWnd, WindowMessage msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Sets the timing resolution of the GetTime (?) method.
        /// </summary>
        /// <param name="period">Timing resolution in msec (?)</param>
        /// <returns>(?)</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll")]
        internal static extern IntPtr TimeBeginPeriod(int period);



        /// <summary>
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr GetDC(IntPtr hwnd);

        /// <summary>
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="DC"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ReleaseDC(IntPtr hwnd, IntPtr DC);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short GetAsyncKeyState(VirtualKeys vKey);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short GetKeyState(VirtualKeys vKey);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint MapVirtualKey(uint uCode, MapVirtualKeyType uMapType);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint MapVirtualKey(VirtualKeys vkey, MapVirtualKeyType uMapType);

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
        internal static extern bool ShowWindow(HWND hWnd, ShowWindowCommand nCmdShow);

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
        internal static extern bool SetWindowText(HWND hWnd, [MarshalAs(UnmanagedType.LPTStr)] string lpString);

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
        internal static extern int GetWindowText(HWND hWnd, [MarshalAs(UnmanagedType.LPTStr)] [In] [Out]
            LPTSTR lpString, int nMaxCount);

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
        //internal static extern BOOL ScreenToClient(HWND hWnd, ref POINT point);
        internal static extern bool ScreenToClient(HWND hWnd, ref POINT point);

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
        internal static extern bool ClientToScreen(HWND hWnd, ref POINT point);

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
        internal static extern bool GetClientRect(HWND windowHandle, out RECT clientRectangle);

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
        internal static extern bool GetWindowRect(HWND windowHandle, out RECT windowRectangle);

        [DllImport("user32.dll")]
        [SuppressUnmanagedCodeSecurity]
        internal static extern bool GetWindowInfo(HWND hwnd, ref WindowInfo wi);

        [DllImport("user32.dll")]
        public static extern HWND GetFocus();

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr intPtr);

        [DllImport("user32.dll")]
        public static extern HICON LoadIcon(HINSTANCE hInstance, string lpIconName);

        [DllImport("user32.dll")]
        public static extern HCURSOR LoadCursor(HINSTANCE hInstance, string lpCursorName);

        public static HCURSOR LoadCursor(CursorName lpCursorName)
            => LoadCursor(IntPtr.Zero, new IntPtr((int)lpCursorName));

        [DllImport("user32.dll")]
        public static extern HCURSOR LoadCursor(HINSTANCE hInstance, IntPtr lpCursorName);

        /// <summary>
        /// Creates an icon or cursor from an IconInfo structure.
        /// </summary>
        /// <param name="iconInfo">
        /// A pointer to an IconInfo structure the function uses to create the
        /// icon or cursor.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the icon
        /// or cursor that is created.
        /// If the function fails, the return value is null. To get extended
        /// error information, call Marshal.GetLastWin32Error.
        /// </returns>
        /// <remarks>
        /// The system copies the bitmaps in the IconInfo structure before
        /// creating the icon or cursor. Because the system may temporarily
        /// select the bitmaps in a device context, the hbmMask and hbmColor
        /// members of the IconInfo structure should not already be selected
        /// into a device context. The application must continue to manage the
        /// original bitmaps and delete them when they are no longer necessary.
        /// When you are finished using the icon, destroy it using the
        /// DestroyIcon function.
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern HICON CreateIconIndirect(ref IconInfo iconInfo);

        /// <summary>
        /// Retrieves information about the specified icon or cursor.
        /// </summary>
        /// <param name="hIcon">A handle to the icon or cursor.</param>
        /// <param name="pIconInfo">
        /// A pointer to an IconInfo structure. The function fills in the
        /// structure's members.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero and the
        /// function fills in the members of the specified IconInfo structure.
        /// If the function fails, the return value is zero. To get extended
        /// error information, call Marshal.GetLastWin32Error.
        /// </returns>
        /// <remarks>
        /// GetIconInfo creates bitmaps for the hbmMask and hbmColor members
        /// of IconInfo. The calling application must manage these bitmaps and
        /// delete them when they are no longer necessary.
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetIconInfo(HICON hIcon, out IconInfo pIconInfo);

        /// <summary>
        /// Destroys an icon and frees any memory the icon occupied.
        /// </summary>
        /// <param name="hIcon">
        /// A handle to the icon to be destroyed. The icon must not be in use.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero. To get extended
        /// error information, call Marshal.GetLastWin32Error.
        /// </returns>
        /// <remarks>
        /// It is only necessary to call DestroyIcon for icons and cursors
        /// created with the following functions: CreateIconFromResourceEx
        /// (if called without the LR_SHARED flag), CreateIconIndirect, and
        /// CopyIcon. Do not use this function to destroy a shared icon. A
        /// shared icon is valid as long as the module from which it was loaded
        /// remains in memory. The following functions obtain a shared icon.
        /// LoadIcon
        /// LoadImage (if you use the LR_SHARED flag)
        /// CopyImage (if you use the LR_COPYRETURNORG flag and the hImage parameter is a shared icon)
        /// CreateIconFromResource
        /// CreateIconFromResourceEx (if you use the LR_SHARED flag)
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyIcon(HICON hIcon);


        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetForegroundWindow(HWND hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool BringWindowToTop(HWND hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetParent(HWND child, HWND newParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern HDEVNOTIFY RegisterDeviceNotification(HANDLE hRecipient,
            LPVOID NotificationFilter, DeviceNotification Flags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterDeviceNotification(HDEVNOTIFY Handle);

        /// <summary>
        /// The ChangeDisplaySettings function changes the settings of the default display device to the specified graphics
        /// mode.
        /// </summary>
        /// <param name="device_mode">
        /// [in] Pointer to a DEVMODE structure that describes the new graphics mode. If lpDevMode is
        /// NULL, all the values currently in the registry will be used for the display setting. Passing NULL for the lpDevMode
        /// parameter and 0 for the dwFlags parameter is the easiest way to return to the default mode after a dynamic mode
        /// change.
        /// </param>
        /// <param name="flags">[in] Indicates how the graphics mode should be changed.</param>
        /// <returns></returns>
        /// <remarks>
        /// To change the settings of a specified display device, use the ChangeDisplaySettingsEx function.
        ///  <para>
        /// To ensure that the DEVMODE structure passed to ChangeDisplaySettings is valid and contains only values
        /// supported by the display driver, use the DEVMODE returned by the EnumDisplaySettings function.
        ///  </para>
        ///  <para>
        /// When the display mode is changed dynamically, the WM_DISPLAYCHANGE message is sent to all running
        /// applications.
        ///  </para>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int ChangeDisplaySettings(DEVMODE device_mode, ChangeDisplaySettingsEnum flags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int ChangeDisplaySettingsEx([MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName,
            DEVMODE lpDevMode, HWND hwnd, ChangeDisplaySettingsEnum dwflags, LPVOID lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices([MarshalAs(UnmanagedType.LPTStr)] string lpDevice,
            int iDevNum, [In] [Out] WindowsDisplayDevice lpDisplayDevice, int dwFlags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string device_name,
            int graphics_mode, [In] [Out] DEVMODE device_mode);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string device_name,
            DisplayModeSettingsEnum graphics_mode, [In] [Out] DEVMODE device_mode);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName,
            DisplayModeSettingsEnum iModeNum,
            [In] [Out] DEVMODE lpDevMode, int dwFlags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPTStr)] string lpszDeviceName,
            int iModeNum,
            [In] [Out] DEVMODE lpDevMode, int dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MonitorInfo lpmi);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern HMONITOR MonitorFromPoint(POINT pt, MonitorFrom dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern HMONITOR MonitorFromWindow(HWND hwnd, MonitorFrom dwFlags);

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
        internal static extern bool SetProcessDPIAware();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool TrackMouseEvent(ref TrackMouseEventStructure lpEventTrack);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr SetCapture(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr SetFocus(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern int ShowCursor(bool show);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool ClipCursor(ref RECT rcClip);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool ClipCursor(IntPtr rcClip);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        /// <summary>
        /// Retrieves a history of up to 64 previous coordinates of the mouse or pen.
        /// </summary>
        /// <param name="cbSize">The size, in bytes, of the MouseMovePoint structure.</param>
        /// <param name="pointsIn">
        /// A pointer to a MOUSEMOVEPOINT structure containing valid mouse
        /// coordinates (in screen coordinates). It may also contain a time
        /// stamp.
        /// </param>
        /// <param name="pointsBufferOut">
        /// A pointer to a buffer that will receive the points. It should be at
        /// least cbSize * nBufPoints in size.
        /// </param>
        /// <param name="nBufPoints">The number of points to be retrieved.</param>
        /// <param name="resolution">
        /// The resolution desired. This parameter can GMMP_USE_DISPLAY_POINTS
        /// or GMMP_USE_HIGH_RESOLUTION_POINTS.
        /// </param>
        /// <returns></returns>
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern unsafe int GetMouseMovePointsEx(
            uint cbSize, MouseMovePoint* pointsIn,
            MouseMovePoint* pointsBufferOut, int nBufPoints, uint resolution);

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
        public static extern HCURSOR SetCursor(HCURSOR hCursor);

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
        internal static extern bool GetCursorPos(ref POINT point);

        /// <summary>
        /// calls the default raw input procedure to provide default processing for
        /// any raw input messages that an application does not process.
        /// This function ensures that every message is processed.
        /// DefRawInputProc is called with the same parameters received by the window procedure.
        /// </summary>
        /// <param name="RawInput">Pointer to an array of RawInput structures.</param>
        /// <param name="Input">Number of RawInput structures pointed to by paRawInput.</param>
        /// <param name="SizeHeader">Size, in bytes, of the RawInputHeader structure.</param>
        /// <returns>If successful, the function returns S_OK. Otherwise it returns an error value.</returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern LRESULT DefRawInputProc(RawInput[] RawInput, int Input, uint SizeHeader);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern LRESULT DefRawInputProc(ref RawInput RawInput, int Input, uint SizeHeader);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern LRESULT DefRawInputProc(IntPtr RawInput, int Input, uint SizeHeader);

        /// <summary>
        /// Registers the devices that supply the raw input data.
        /// </summary>
        /// <param name="RawInputDevices">
        /// Pointer to an array of RawInputDevice structures that represent the devices that supply the raw input.
        /// </param>
        /// <param name="NumDevices">
        /// Number of RawInputDevice structures pointed to by RawInputDevices.
        /// </param>
        /// <param name="Size">
        /// Size, in bytes, of a RAWINPUTDEVICE structure.
        /// </param>
        /// <returns>
        /// TRUE if the function succeeds; otherwise, FALSE. If the function fails, call GetLastError for more information.
        /// </returns>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool RegisterRawInputDevices(
            RawInputDevice[] RawInputDevices,
            uint NumDevices,
            uint Size
        );

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool RegisterRawInputDevices(
            RawInputDevice[] RawInputDevices,
            int NumDevices,
            int Size
        );

        /// <summary>
        /// Does a buffered read of the raw input data.
        /// </summary>
        /// <param name="Data">
        /// Pointer to a buffer of RawInput structures that contain the raw input data.
        /// If NULL, the minimum required buffer, in bytes, is returned in Size.
        /// </param>
        /// <param name="Size">Pointer to a variable that specifies the size, in bytes, of a RawInput structure.</param>
        /// <param name="SizeHeader">Size, in bytes, of RawInputHeader.</param>
        /// <returns>
        /// If Data is NULL and the function is successful, the return value is zero.
        /// If Data is not NULL and the function is successful, the return value is the number
        /// of RawInput structures written to Data.
        /// If an error occurs, the return value is (UINT)-1. Call GetLastError for the error code.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint GetRawInputBuffer(
            [Out] RawInput[] Data,
            [In] [Out] ref uint Size,
            [In] uint SizeHeader
        );

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputBuffer(
            [Out] RawInput[] Data,
            [In] [Out] ref int Size,
            [In] int SizeHeader
        );

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputBuffer(
            [Out] IntPtr Data,
            [In] [Out] ref int Size,
            [In] int SizeHeader
        );

        /// <summary>
        /// Gets the information about the raw input devices for the current application.
        /// </summary>
        /// <param name="RawInputDevices">
        /// Pointer to an array of RawInputDevice structures for the application.
        /// </param>
        /// <param name="NumDevices">
        /// Number of RawInputDevice structures in RawInputDevices.
        /// </param>
        /// <param name="cbSize">
        /// Size, in bytes, of a RawInputDevice structure.
        /// </param>
        /// <returns>
        ///  <para>
        /// If successful, the function returns a non-negative number that is
        /// the number of RawInputDevice structures written to the buffer.
        ///  </para>
        ///  <para>
        /// If the pRawInputDevices buffer is too small or NULL, the function sets
        /// the last error as ERROR_INSUFFICIENT_BUFFER, returns -1,
        /// and sets NumDevices to the required number of devices.
        ///  </para>
        ///  <para>
        /// If the function fails for any other reason, it returns -1. For more details, call GetLastError.
        ///  </para>
        /// </returns>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint GetRegisteredRawInputDevices(
            [Out] RawInput[] RawInputDevices,
            [In] [Out] ref uint NumDevices,
            uint cbSize
        );

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRegisteredRawInputDevices(
            [Out] RawInput[] RawInputDevices,
            [In] [Out] ref int NumDevices,
            int cbSize
        );

        /// <summary>
        /// Enumerates the raw input devices attached to the system.
        /// </summary>
        /// <param name="RawInputDeviceList">
        /// ointer to buffer that holds an array of RawInputDeviceList structures
        /// for the devices attached to the system.
        /// If NULL, the number of devices are returned in NumDevices.
        /// </param>
        /// <param name="NumDevices">
        /// Pointer to a variable. If RawInputDeviceList is NULL, it specifies the number
        /// of devices attached to the system. Otherwise, it contains the size, in bytes,
        /// of the preallocated buffer pointed to by pRawInputDeviceList.
        /// However, if NumDevices is smaller than needed to contain RawInputDeviceList structures,
        /// the required buffer size is returned here.
        /// </param>
        /// <param name="Size">
        /// Size of a RawInputDeviceList structure.
        /// </param>
        /// <returns>
        /// If the function is successful, the return value is the number of devices stored in the buffer
        /// pointed to by RawInputDeviceList.
        /// If RawInputDeviceList is NULL, the return value is zero.
        /// If NumDevices is smaller than needed to contain all the RawInputDeviceList structures,
        /// the return value is (UINT) -1 and the required buffer is returned in NumDevices.
        /// Calling GetLastError returns ERROR_INSUFFICIENT_BUFFER.
        /// On any other error, the function returns (UINT) -1 and GetLastError returns the error indication.
        /// </returns>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint GetRawInputDeviceList(
            [In] [Out] RawInputDeviceList[] RawInputDeviceList,
            [In] [Out] ref uint NumDevices,
            uint Size
        );

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputDeviceList(
            [In] [Out] RawInputDeviceList[] RawInputDeviceList,
            [In] [Out] ref int NumDevices,
            int Size
        );

        /// <summary>
        /// Enumerates the raw input devices attached to the system.
        /// </summary>
        /// <param name="RawInputDeviceList">
        /// ointer to buffer that holds an array of RawInputDeviceList structures
        /// for the devices attached to the system.
        /// If NULL, the number of devices are returned in NumDevices.
        /// </param>
        /// <param name="NumDevices">
        /// Pointer to a variable. If RawInputDeviceList is NULL, it specifies the number
        /// of devices attached to the system. Otherwise, it contains the size, in bytes,
        /// of the preallocated buffer pointed to by pRawInputDeviceList.
        /// However, if NumDevices is smaller than needed to contain RawInputDeviceList structures,
        /// the required buffer size is returned here.
        /// </param>
        /// <param name="Size">
        /// Size of a RawInputDeviceList structure.
        /// </param>
        /// <returns>
        /// If the function is successful, the return value is the number of devices stored in the buffer
        /// pointed to by RawInputDeviceList.
        /// If RawInputDeviceList is NULL, the return value is zero.
        /// If NumDevices is smaller than needed to contain all the RawInputDeviceList structures,
        /// the return value is (UINT) -1 and the required buffer is returned in NumDevices.
        /// Calling GetLastError returns ERROR_INSUFFICIENT_BUFFER.
        /// On any other error, the function returns (UINT) -1 and GetLastError returns the error indication.
        /// </returns>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint GetRawInputDeviceList(
            [In] [Out] IntPtr RawInputDeviceList,
            [In] [Out] ref uint NumDevices,
            uint Size
        );

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputDeviceList(
            [In] [Out] IntPtr RawInputDeviceList,
            [In] [Out] ref int NumDevices,
            int Size
        );

        /// <summary>
        /// Gets information about the raw input device.
        /// </summary>
        /// <param name="Device">
        /// Handle to the raw input device. This comes from the lParam of the WM_INPUT message,
        /// from RawInputHeader.Device, or from GetRawInputDeviceList.
        /// It can also be NULL if an application inserts input data, for example, by using SendInput.
        /// </param>
        /// <param name="Command">
        /// Specifies what data will be returned in pData. It can be one of the following values.
        /// RawInputDeviceInfoEnum.PREPARSEDDATA
        /// Data points to the previously parsed data.
        /// RawInputDeviceInfoEnum.DEVICENAME
        /// Data points to a string that contains the device name.
        /// For this Command only, the value in Size is the character count (not the byte count).
        /// RawInputDeviceInfoEnum.DEVICEINFO
        /// Data points to an RawInputDeviceInfo structure.
        /// </param>
        /// <param name="Data">
        /// ointer to a buffer that contains the information specified by Command.
        /// If Command is RawInputDeviceInfoEnum.DEVICEINFO, set RawInputDeviceInfo.Size to sizeof(RawInputDeviceInfo)
        /// before calling GetRawInputDeviceInfo. (This is done automatically in OpenTK)
        /// </param>
        /// <param name="Size">
        /// Pointer to a variable that contains the size, in bytes, of the data in Data.
        /// </param>
        /// <returns>
        ///  <para>If successful, this function returns a non-negative number indicating the number of bytes copied to Data.</para>
        ///  <para>
        /// If Data is not large enough for the data, the function returns -1. If Data is NULL, the function returns a
        /// value of zero. In both of these cases, Size is set to the minimum size required for the Data buffer.
        ///  </para>
        ///  <para>Call GetLastError to identify any other errors.</para>
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In] [Out] LPVOID Data,
            [In] [Out] ref int Size
        );

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In] [Out] byte[] Data,
            [In] [Out] ref int Size
        );

        /// <summary>
        /// Gets information about the raw input device.
        /// </summary>
        /// <param name="Device">
        /// Handle to the raw input device. This comes from the lParam of the WM_INPUT message,
        /// from RawInputHeader.Device, or from GetRawInputDeviceList.
        /// It can also be NULL if an application inserts input data, for example, by using SendInput.
        /// </param>
        /// <param name="Command">
        /// Specifies what data will be returned in pData. It can be one of the following values.
        /// RawInputDeviceInfoEnum.PREPARSEDDATA
        /// Data points to the previously parsed data.
        /// RawInputDeviceInfoEnum.DEVICENAME
        /// Data points to a string that contains the device name.
        /// For this Command only, the value in Size is the character count (not the byte count).
        /// RawInputDeviceInfoEnum.DEVICEINFO
        /// Data points to an RawInputDeviceInfo structure.
        /// </param>
        /// <param name="Data">
        /// ointer to a buffer that contains the information specified by Command.
        /// If Command is RawInputDeviceInfoEnum.DEVICEINFO, set RawInputDeviceInfo.Size to sizeof(RawInputDeviceInfo)
        /// before calling GetRawInputDeviceInfo. (This is done automatically in OpenTK)
        /// </param>
        /// <param name="Size">
        /// Pointer to a variable that contains the size, in bytes, of the data in Data.
        /// </param>
        /// <returns>
        ///  <para>If successful, this function returns a non-negative number indicating the number of bytes copied to Data.</para>
        ///  <para>
        /// If Data is not large enough for the data, the function returns -1. If Data is NULL, the function returns a
        /// value of zero. In both of these cases, Size is set to the minimum size required for the Data buffer.
        ///  </para>
        ///  <para>Call GetLastError to identify any other errors.</para>
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern uint GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In] [Out] RawInputDeviceInfo Data,
            [In] [Out] ref uint Size
        );

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In] [Out] RawInputDeviceInfo Data,
            [In] [Out] ref int Size
        );

        internal static int GetRawInputData(IntPtr raw, out RawInputHeader header)
        {
            var size = RawInputHeader.SizeInBytes;
            unsafe
            {
                fixed (RawInputHeader* pheader = &header)
                {
                    if (GetRawInputData(raw, GetRawInputDataEnum.HEADER,
                            (IntPtr)pheader, ref size, API.RawInputHeaderSize) != RawInputHeader.SizeInBytes)
                    {
                        System.Diagnostics.Debug.Print("[Error] Failed to retrieve raw input header. Error: {0}",
                            Marshal.GetLastWin32Error());
                    }
                }
            }

            return size;
        }

        internal static int GetRawInputData(IntPtr raw, out RawInput data)
        {
            var size = RawInput.SizeInBytes;
            unsafe
            {
                fixed (RawInput* pdata = &data)
                {
                    GetRawInputData(raw, GetRawInputDataEnum.INPUT,
                        (IntPtr)pdata, ref size, API.RawInputHeaderSize);
                }
            }

            return size;
        }

        internal static int GetRawInputData(IntPtr raw, byte[] data)
        {
            var size = data.Length;
            unsafe
            {
                fixed (byte* pdata = data)
                {
                    GetRawInputData(raw, GetRawInputDataEnum.INPUT,
                        (IntPtr)pdata, ref size, API.RawInputHeaderSize);
                }
            }

            return size;
        }

        /// <summary>
        /// Gets the raw input from the specified device.
        /// </summary>
        /// <param name="RawInput">Handle to the RawInput structure. This comes from the lParam in WM_INPUT.</param>
        /// <param name="Command">
        /// Command flag. This parameter can be one of the following values.
        /// RawInputDateEnum.INPUT
        /// Get the raw data from the RawInput structure.
        /// RawInputDateEnum.HEADER
        /// Get the header information from the RawInput structure.
        /// </param>
        /// <param name="Data">
        /// Pointer to the data that comes from the RawInput structure. This depends on the value of uiCommand.
        /// If Data is NULL, the required size of the buffer is returned in Size.
        /// </param>
        /// <param name="Size">Pointer to a variable that specifies the size, in bytes, of the data in Data.</param>
        /// <param name="SizeHeader">Size, in bytes, of RawInputHeader.</param>
        /// <returns>
        ///  <para>
        /// If Data is NULL and the function is successful, the return value is 0. If Data is not NULL and the function
        /// is successful, the return value is the number of bytes copied into Data.
        ///  </para>
        ///  <para>If there is an error, the return value is (UINT)-1.</para>
        /// </returns>
        /// <remarks>
        /// GetRawInputData gets the raw input one RawInput structure at a time. In contrast, GetRawInputBuffer gets an array
        /// of RawInput structures.
        /// </remarks>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            [Out] LPVOID Data,
            [In] [Out] ref int Size,
            int SizeHeader
        );

        /// <summary>
        /// Gets the raw input from the specified device.
        /// </summary>
        /// <param name="RawInput">Handle to the RawInput structure. This comes from the lParam in WM_INPUT.</param>
        /// <param name="Command">
        /// Command flag. This parameter can be one of the following values.
        /// RawInputDateEnum.INPUT
        /// Get the raw data from the RawInput structure.
        /// RawInputDateEnum.HEADER
        /// Get the header information from the RawInput structure.
        /// </param>
        /// <param name="Data">
        /// Pointer to the data that comes from the RawInput structure. This depends on the value of uiCommand.
        /// If Data is NULL, the required size of the buffer is returned in Size.
        /// </param>
        /// <param name="Size">Pointer to a variable that specifies the size, in bytes, of the data in Data.</param>
        /// <param name="SizeHeader">Size, in bytes, of RawInputHeader.</param>
        /// <returns>
        ///  <para>
        /// If Data is NULL and the function is successful, the return value is 0. If Data is not NULL and the function
        /// is successful, the return value is the number of bytes copied into Data.
        ///  </para>
        ///  <para>If there is an error, the return value is (UINT)-1.</para>
        /// </returns>
        /// <remarks>
        /// GetRawInputData gets the raw input one RawInput structure at a time. In contrast, GetRawInputBuffer gets an array
        /// of RawInput structures.
        /// </remarks>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            /*[MarshalAs(UnmanagedType.LPStruct)]*/ [Out] out RawInput Data,
            [In] [Out] ref int Size,
            int SizeHeader
        );

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern unsafe int GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            RawInput* Data,
            [In] [Out] ref int Size,
            int SizeHeader
        );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern UINT_PTR SetTimer(HWND hWnd, UINT_PTR nIDEvent, uint uElapse, TIMERPROC lpTimerFunc);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool KillTimer(HWND hWnd, UINT_PTR uIDEvent);
    }
}
