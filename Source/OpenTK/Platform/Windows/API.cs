#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
#if !MINIMAL
using System.Drawing;
#endif
using System.Runtime.InteropServices;
using System.Text;
using System.Security;

#endregion

/* TODO: Update the description of TimeBeginPeriod and other native methods. Update Timer. */

#pragma warning disable 3019    // CLS-compliance checking
#pragma warning disable 0649    // struct members not explicitly initialized
#pragma warning disable 0169    // field / method is never used.
#pragma warning disable 0414    // field assigned but never used.

namespace OpenTK.Platform.Windows
{
    #region Type aliases

    using HWND = System.IntPtr;
    using HINSTANCE = System.IntPtr;
    using HMENU = System.IntPtr;
    using HICON = System.IntPtr;
    using HBRUSH = System.IntPtr;
    using HCURSOR = System.IntPtr;
    using HKEY = System.IntPtr;
    using PHKEY = System.IntPtr;

    using LRESULT = System.IntPtr;
    using LPVOID = System.IntPtr;
    using LPCTSTR = System.String;

    using WPARAM = System.IntPtr;
    using LPARAM = System.IntPtr;
    using HANDLE = System.IntPtr;
    using HRAWINPUT = System.IntPtr;

    using BYTE = System.Byte;
    using SHORT = System.Int16;
    using USHORT = System.UInt16;
    using LONG = System.Int32;
    using ULONG = System.UInt32;
    using WORD = System.Int16;
    using DWORD = System.Int32;
    using BOOL = System.Boolean;
    using INT = System.Int32;
    using UINT = System.UInt32;
    using LONG_PTR = System.IntPtr;
    using ATOM = System.Int32;

    using COLORREF = System.Int32;
    using RECT = OpenTK.Platform.Windows.Win32Rectangle;
    using WNDPROC = System.IntPtr;
    using LPDEVMODE = DeviceMode;
    using HDEVNOTIFY = System.IntPtr;

    using HRESULT = System.IntPtr;
    using HMONITOR = System.IntPtr;

    using DWORD_PTR = System.IntPtr;
    using UINT_PTR = System.UIntPtr;

    using TIMERPROC = Functions.TimerProc;

    using REGSAM = System.UInt32;

    #endregion

    /// \internal
    /// <summary>
    /// For internal use by OpenTK only!
    /// Exposes useful native WINAPI methods and structures.
    /// </summary>
    internal static class API
    {
        // Prevent BeforeFieldInit optimization, and initialize 'size' fields.
        static API()
        {
            RawInputHeaderSize = Marshal.SizeOf(typeof(RawInputHeader));
            RawInputSize = Marshal.SizeOf(typeof(RawInput));
            RawMouseSize = Marshal.SizeOf(typeof(RawMouse));
            RawInputDeviceSize = Marshal.SizeOf(typeof(RawInputDevice));
            RawInputDeviceListSize = Marshal.SizeOf(typeof(RawInputDeviceList));
            RawInputDeviceInfoSize = Marshal.SizeOf(typeof(RawInputDeviceInfo));
            PixelFormatDescriptorVersion = 1;
            PixelFormatDescriptorSize = (short)Marshal.SizeOf(typeof(PixelFormatDescriptor));
            WindowInfoSize = Marshal.SizeOf(typeof(WindowInfo));
        }

        internal static readonly short PixelFormatDescriptorSize;
        internal static readonly short PixelFormatDescriptorVersion;
        internal static readonly int RawInputSize;
        internal static readonly int RawInputDeviceSize;
        internal static readonly int RawInputHeaderSize;
        internal static readonly int RawInputDeviceListSize;
        internal static readonly int RawInputDeviceInfoSize;
        internal static readonly int RawMouseSize;
        internal static readonly int WindowInfoSize;
    }

    internal static class Functions
    {
        #region Window functions

        #region SetWindowPos

        // WINUSERAPI BOOL WINAPI SetWindowPos(__in HWND hWnd, __in_opt HWND hWndInsertAfter,
        //                                     __in int X, __in int Y, __in int cx, __in int cy, __in UINT uFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetWindowPos(
            IntPtr handle,
            IntPtr insertAfter,
            int x, int y, int cx, int cy,
            SetWindowPosFlags flags
        );

        #endregion

        #region AdjustWindowRect

        /// <summary>
        /// Calculates the required size of the window rectangle, based on the desired client-rectangle size. The window rectangle can then be passed to the CreateWindow function to create a window whose client area is the desired size.
        /// </summary>
        /// <param name="lpRect">[in, out] Pointer to a RECT structure that contains the coordinates of the top-left and bottom-right corners of the desired client area. When the function returns, the structure contains the coordinates of the top-left and bottom-right corners of the window to accommodate the desired client area.</param>
        /// <param name="dwStyle">[in] Specifies the window style of the window whose required size is to be calculated. Note that you cannot specify the WS_OVERLAPPED style.</param>
        /// <param name="bMenu">[in] Specifies whether the window has a menu.</param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero. To get extended error information, call GetLastError.
        /// </returns>
        /// <remarks>
        /// A client rectangle is the smallest rectangle that completely encloses a client area. A window rectangle is the smallest rectangle that completely encloses the window, which includes the client area and the nonclient area. 
        /// The AdjustWindowRect function does not add extra space when a menu bar wraps to two or more rows. 
        /// The AdjustWindowRect function does not take the WS_VSCROLL or WS_HSCROLL styles into account. To account for the scroll bars, call the GetSystemMetrics function with SM_CXVSCROLL or SM_CYHSCROLL.
        /// Found Winuser.h, user32.dll
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal static extern BOOL AdjustWindowRect([In, Out] ref Win32Rectangle lpRect, WindowStyle dwStyle, BOOL bMenu);

        [DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx", CallingConvention = CallingConvention.StdCall, SetLastError = true), SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AdjustWindowRectEx(
            ref Win32Rectangle lpRect,
            WindowStyle dwStyle,
            [MarshalAs(UnmanagedType.Bool)] bool bMenu,
            ExtendedWindowStyle dwExStyle);

        #endregion

        #region CreateWindowEx

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

        #region DestroyWindow

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DestroyWindow(IntPtr windowHandle);

        #endregion

        #region RegisterClass

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern ushort RegisterClass(ref WindowClass window_class);

        #endregion

        #region RegisterClassEx

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern ushort RegisterClassEx(ref ExtendedWindowClass window_class);

        #endregion

        #region UnregisterClass

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern short UnregisterClass([MarshalAs(UnmanagedType.LPTStr)] LPCTSTR className, IntPtr instance);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern short UnregisterClass(IntPtr className, IntPtr instance);

        #endregion

        #region GetClassInfoEx

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern BOOL GetClassInfoEx(HINSTANCE hinst,
            [MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpszClass, ref ExtendedWindowClass lpwcx);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern BOOL GetClassInfoEx(HINSTANCE hinst, UIntPtr lpszClass, ref ExtendedWindowClass lpwcx);

        #endregion

        #region CallWindowProc

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern LRESULT CallWindowProc(WNDPROC lpPrevWndFunc, HWND hWnd, WindowMessage Msg,
            WPARAM wParam, LPARAM lParam);

        #endregion

        #region SetWindowLong

        // SetWindowLongPtr does not exist on x86 platforms (it's a macro that resolves to SetWindowLong).
        // We need to detect if we are on x86 or x64 at runtime and call the correct function
        // (SetWindowLongPtr on x64 or SetWindowLong on x86). Fun!
        internal static IntPtr SetWindowLong(IntPtr handle, GetWindowLongOffsets item, IntPtr newValue)
        {
            // SetWindowPos defines its error condition as an IntPtr.Zero retval and a non-0 GetLastError.
            // We need to SetLastError(0) to ensure we are not detecting on older error condition (from another function).

            IntPtr retval = IntPtr.Zero;
            SetLastError(0);

            if (IntPtr.Size == 4)
                retval = new IntPtr(SetWindowLongInternal(handle, item, newValue.ToInt32()));
            else
                retval = SetWindowLongPtrInternal(handle, item, newValue);

            if (retval == IntPtr.Zero)
            {
                int error = Marshal.GetLastWin32Error();
                if (error != 0)
                    throw new PlatformException(String.Format("Failed to modify window border. Error: {0}", error));
            }

            return retval;
        }

        internal static IntPtr SetWindowLong(IntPtr handle, WindowProcedure newValue)
        {
            return SetWindowLong(handle, GetWindowLongOffsets.WNDPROC, Marshal.GetFunctionPointerForDelegate(newValue));
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
        static extern LONG SetWindowLongInternal(HWND hWnd, GetWindowLongOffsets nIndex, LONG dwNewLong);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
        static extern LONG_PTR SetWindowLongPtrInternal(HWND hWnd, GetWindowLongOffsets nIndex, LONG_PTR dwNewLong);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
        static extern LONG SetWindowLongInternal(HWND hWnd, GetWindowLongOffsets nIndex,
            [MarshalAs(UnmanagedType.FunctionPtr)]WindowProcedure dwNewLong);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
        static extern LONG_PTR SetWindowLongPtrInternal(HWND hWnd, GetWindowLongOffsets nIndex,
            [MarshalAs(UnmanagedType.FunctionPtr)]WindowProcedure dwNewLong);

        #endregion

        #region GetWindowLong

        internal static UIntPtr GetWindowLong(IntPtr handle, GetWindowLongOffsets index)
        {
            if (IntPtr.Size == 4)
                return (UIntPtr)GetWindowLongInternal(handle, index);

            return GetWindowLongPtrInternal(handle, index);
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint="GetWindowLong")]
        static extern ULONG GetWindowLongInternal(HWND hWnd, GetWindowLongOffsets nIndex);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowLongPtr")]
        static extern UIntPtr GetWindowLongPtrInternal(HWND hWnd, GetWindowLongOffsets nIndex);

        #endregion

        #endregion

        #region Message handling

        #region PeekMessage

        /// <summary>
        /// Low-level WINAPI function that checks the next message in the queue.
        /// </summary>
        /// <param name="msg">The pending message (if any) is stored here.</param>
        /// <param name="hWnd">Not used</param>
        /// <param name="messageFilterMin">Not used</param>
        /// <param name="messageFilterMax">Not used</param>
        /// <param name="flags">Not used</param>
        /// <returns>True if there is a message pending.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll"), CLSCompliant(false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PeekMessage(ref MSG msg, IntPtr hWnd, int messageFilterMin, int messageFilterMax, PeekMessageFlags flags);

        #endregion

        #region GetMessage

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
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll"), CLSCompliant(false)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        internal static extern INT GetMessage(ref MSG msg,
            IntPtr windowHandle, int messageFilterMin, int messageFilterMax);

        #endregion

        #region GetMessageTime

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

        #endregion

        #region SendMessage

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern LRESULT SendMessage(HWND hWnd, WindowMessage Msg, WPARAM wParam, LPARAM lParam);

        #endregion

        #region PostMessage

        [CLSCompliant(false)]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL PostMessage(
            HWND hWnd,
            WindowMessage Msg,
            WPARAM wParam,
            LPARAM lParam
        );

        #endregion

        #region PostQuitMessage

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        internal static extern void PostQuitMessage(int exitCode);

        #endregion

        #region DispatchMessage

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll"), CLSCompliant(false)]
        internal static extern LRESULT DispatchMessage(ref MSG msg);

        #endregion

        #region TranslateMessage

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll"), CLSCompliant(false)]
        internal static extern BOOL TranslateMessage(ref MSG lpMsg);

        #endregion

        #region GetQueueStatus

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
        /// <para>
        /// The QS_ALLPOSTMESSAGE and QS_POSTMESSAGE flags differ in when they are cleared.
        /// QS_POSTMESSAGE is cleared when you call GetMessage or PeekMessage, whether or not you are filtering messages.
        /// QS_ALLPOSTMESSAGE is cleared when you call GetMessage or PeekMessage without filtering messages
        /// (wMsgFilterMin and wMsgFilterMax are 0). This can be useful when you call PeekMessage multiple times
        /// to get messages in different ranges.
        /// </para>
        /// </remarks>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        internal static extern DWORD GetQueueStatus([MarshalAs(UnmanagedType.U4)] QueueStatusFlags flags);

        #endregion

        #region DefWindowProc

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public extern static IntPtr DefWindowProc(HWND hWnd, WindowMessage msg, IntPtr wParam, IntPtr lParam);

        #endregion

        #endregion

        #region Timing

        #region TimeBeginPeriod

        /// <summary>
        /// Sets the timing resolution of the GetTime (?) method.
        /// </summary>
        /// <param name="period">Timing resolution in msec (?)</param>
        /// <returns>(?)</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll")]
        internal static extern IntPtr TimeBeginPeriod(int period);

        #endregion

        #region QueryPerformanceFrequency

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PerformanceFrequency"></param>
        /// <returns></returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool QueryPerformanceFrequency(ref long PerformanceFrequency);

        #endregion

        #region QueryPerformanceCounter

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PerformanceCount"></param>
        /// <returns></returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool QueryPerformanceCounter(ref long PerformanceCount);

        #endregion

        #endregion

        #region Rendering

        #region GetDC

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr GetDC(IntPtr hwnd);

        #endregion

        #region GetWindowDC

        [DllImport("user32.dll")]
        internal static extern IntPtr GetWindowDC(IntPtr hwnd);

        #endregion

        #region ReleaseDC

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="DC"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ReleaseDC(IntPtr hwnd, IntPtr DC);

        #endregion

        #region ChoosePixelFormat

        [DllImport("gdi32.dll")]
        internal static extern int ChoosePixelFormat(IntPtr dc, ref PixelFormatDescriptor pfd);

        #endregion

        [DllImport("gdi32.dll")]
        internal static extern int DescribePixelFormat(IntPtr deviceContext, int pixel, int pfdSize, ref PixelFormatDescriptor pixelFormat);

        #region SetPixelFormat

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="format"></param>
        /// <param name="pfd"></param>
        /// <returns></returns>
        [DllImport("gdi32.dll", SetLastError=true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetPixelFormat(IntPtr dc, int format, ref PixelFormatDescriptor pfd);

        #endregion

        #region SwapBuffers

        [SuppressUnmanagedCodeSecurity]
        [DllImport("gdi32.dll", SetLastError=true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SwapBuffers(IntPtr dc);

        #endregion

        #region GetProcAddress

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetProcAddress(IntPtr handle, string funcname);

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetProcAddress(IntPtr handle, IntPtr funcname);


        #endregion

        #endregion

        #region DLL handling

        #region SetLastError

        [DllImport("kernel32.dll")]
        internal static extern void SetLastError(DWORD dwErrCode);

        #endregion

        #region GetModuleHandle

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPTStr)]string module_name);

        #endregion

        #region LoadLibrary

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dllName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr LoadLibrary(string dllName);

        #endregion

        #region FreeLibrary

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool FreeLibrary(IntPtr handle);

        #endregion

        #endregion

        #region GetAsyncKeyState

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern SHORT GetAsyncKeyState(VirtualKeys vKey);

        #endregion

        #region GetKeyState

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern SHORT GetKeyState(VirtualKeys vKey);

        #endregion

        #region MapVirtualKey

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT MapVirtualKey(UINT uCode, MapVirtualKeyType uMapType);

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT MapVirtualKey(VirtualKeys vkey, MapVirtualKeyType uMapType);

        #endregion

        #region ShowWindow

        /// <summary>
        /// The ShowWindow function sets the specified window's show state.
        /// </summary>
        /// <param name="hWnd">[in] Handle to the window.</param>
        /// <param name="nCmdShow">[in] Specifies how the window is to be shown. This parameter is ignored the first time an application calls ShowWindow, if the program that launched the application provides a STARTUPINFO structure. Otherwise, the first time ShowWindow is called, the value should be the value obtained by the WinMain function in its nCmdShow parameter. In subsequent calls, this parameter can be one of the ShowWindowEnum values.</param>
        /// <returns>If the window was previously visible, the return value is true. Otherwise false.</returns>
        /// <remarks>
        /// <para>To perform certain special effects when showing or hiding a window, use AnimateWindow.</para>
        /// <para>The first time an application calls ShowWindow, it should use the WinMain function's nCmdShow parameter as its nCmdShow parameter. Subsequent calls to ShowWindow must use one of the values in the given list, instead of the one specified by the WinMain function's nCmdShow parameter.</para>
        /// <para>As noted in the discussion of the nCmdShow parameter, the nCmdShow value is ignored in the first call to ShowWindow if the program that launched the application specifies startup information in the structure. In this case, ShowWindow uses the information specified in the STARTUPINFO structure to show the window. On subsequent calls, the application must call ShowWindow with nCmdShow set to SW_SHOWDEFAULT to use the startup information provided by the program that launched the application. This behavior is designed for the following situations:</para>
        /// <list type="">
        /// <item>Applications create their main window by calling CreateWindow with the WS_VISIBLE flag set.</item>
        /// <item>Applications create their main window by calling CreateWindow with the WS_VISIBLE flag cleared, and later call ShowWindow with the SW_SHOW flag set to make it visible.</item>
        /// </list>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal static extern BOOL ShowWindow(HWND hWnd, ShowWindowCommand nCmdShow);

        #endregion

        #region SetWindowText

        /// <summary>
        /// The SetWindowText function changes the text of the specified window's title bar (if it has one). If the specified window is a control, the text of the control is changed. However, SetWindowText cannot change the text of a control in another application.
        /// </summary>
        /// <param name="hWnd">[in] Handle to the window or control whose text is to be changed.</param>
        /// <param name="lpString">[in] Pointer to a null-terminated string to be used as the new title or control text.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
        /// </returns>
        /// <remarks>
        /// <para>If the target window is owned by the current process, SetWindowText causes a WM_SETTEXT message to be sent to the specified window or control. If the control is a list box control created with the WS_CAPTION style, however, SetWindowText sets the text for the control, not for the list box entries. </para>
        /// <para>To set the text of a control in another process, send the WM_SETTEXT message directly instead of calling SetWindowText. </para>
        /// <para>The SetWindowText function does not expand tab characters (ASCII code 0x09). Tab characters are displayed as vertical bar (|) characters. </para>
        /// <para>Windows 95/98/Me: SetWindowTextW is supported by the Microsoft Layer for Unicode (MSLU). To use this, you must add certain files to your application, as outlined in Microsoft Layer for Unicode on Windows 95/98/Me Systems .</para>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern BOOL SetWindowText(HWND hWnd, [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        #endregion

        #region GetWindowText

        /// <summary>
        /// The GetWindowText function copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is a control, the text of the control is copied. However, GetWindowText cannot retrieve the text of a control in another application.
        /// </summary>
        /// <param name="hWnd">[in] Handle to the window or control containing the text.</param>
        /// <param name="lpString">[out] Pointer to the buffer that will receive the text. If the string is as long or longer than the buffer, the string is truncated and terminated with a NULL character.</param>
        /// <param name="nMaxCount">[in] Specifies the maximum number of characters to copy to the buffer, including the NULL character. If the text exceeds this limit, it is truncated.</param>
        /// <returns>
        /// If the function succeeds, the return value is the length, in characters, of the copied string, not including the terminating NULL character. If the window has no title bar or text, if the title bar is empty, or if the window or control handle is invalid, the return value is zero. To get extended error information, call GetLastError.
        /// <para>This function cannot retrieve the text of an edit control in another application.</para>
        /// </returns>
        /// <remarks>
        /// <para>If the target window is owned by the current process, GetWindowText causes a WM_GETTEXT message to be sent to the specified window or control. If the target window is owned by another process and has a caption, GetWindowText retrieves the window caption text. If the window does not have a caption, the return value is a null string. This behavior is by design. It allows applications to call GetWindowText without becoming unresponsive if the process that owns the target window is not responding. However, if the target window is not responding and it belongs to the calling application, GetWindowText will cause the calling application to become unresponsive.</para>
        /// <para>To retrieve the text of a control in another process, send a WM_GETTEXT message directly instead of calling GetWindowText.</para>
        /// <para>Windows 95/98/Me: GetWindowTextW is supported by the Microsoft Layer for Unicode (MSLU). To use this, you must add certain files to your application, as outlined in Microsoft Layer for Unicode on Windows 95/98/Me</para>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern int GetWindowText(HWND hWnd, [MarshalAs(UnmanagedType.LPTStr), In, Out] StringBuilder lpString, int nMaxCount);

        #endregion

        #region ScreenToClient

        /// <summary>
        /// Converts the screen coordinates of a specified point on the screen to client-area coordinates.
        /// </summary>
        /// <param name="hWnd">Handle to the window whose client area will be used for the conversion.</param>
        /// <param name="point">Pointer to a POINT structure that specifies the screen coordinates to be converted.</param>
        /// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. Windows NT/2000/XP: To get extended error information, call GetLastError.</returns>
        /// <remarks>
        /// <para>The function uses the window identified by the hWnd parameter and the screen coordinates given in the POINT structure to compute client coordinates. It then replaces the screen coordinates with the client coordinates. The new coordinates are relative to the upper-left corner of the specified window's client area. </para>
        /// <para>The ScreenToClient function assumes the specified point is in screen coordinates. </para>
        /// <para>All coordinates are in device units.</para>
        /// <para>Do not use ScreenToClient when in a mirroring situation, that is, when changing from left-to-right layout to right-to-left layout. Instead, use MapWindowPoints. For more information, see "Window Layout and Mirroring" in Window Features.</para>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        //internal static extern BOOL ScreenToClient(HWND hWnd, ref POINT point);
        internal static extern BOOL ScreenToClient(HWND hWnd, ref Point point);

        #endregion

        #region ClientToScreen

        /// <summary>
        /// Converts the client-area coordinates of a specified point to screen coordinates.
        /// </summary>
        /// <param name="hWnd">Handle to the window whose client area will be used for the conversion.</param>
        /// <param name="point">Pointer to a POINT structure that contains the client coordinates to be converted. The new screen coordinates are copied into this structure if the function succeeds.</param>
        /// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. Windows NT/2000/XP: To get extended error information, call GetLastError.</returns>
        /// <remarks>
        /// <para>The ClientToScreen function replaces the client-area coordinates in the POINT structure with the screen coordinates. The screen coordinates are relative to the upper-left corner of the screen. Note, a screen-coordinate point that is above the window's client area has a negative y-coordinate. Similarly, a screen coordinate to the left of a client area has a negative x-coordinate.</para>
        /// <para>All coordinates are device coordinates.</para>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal static extern BOOL ClientToScreen(HWND hWnd, ref Point point);

        #endregion

        #region GetClientRect

        /// <summary>
        /// The GetClientRect function retrieves the coordinates of a window's client area. The client coordinates specify the upper-left and lower-right corners of the client area. Because client coordinates are relative to the upper-left corner of a window's client area, the coordinates of the upper-left corner are (0,0).
        /// </summary>
        /// <param name="windowHandle">Handle to the window whose client coordinates are to be retrieved.</param>
        /// <param name="clientRectangle">Pointer to a RECT structure that receives the client coordinates. The left and top members are zero. The right and bottom members contain the width and height of the window.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
        /// </returns>
        /// <remarks>In conformance with conventions for the RECT structure, the bottom-right coordinates of the returned rectangle are exclusive. In other words, the pixel at (right, bottom) lies immediately outside the rectangle.</remarks>
        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal extern static BOOL GetClientRect(HWND windowHandle, out Win32Rectangle clientRectangle);

        #endregion

        #region GetWindowRect

        /// <summary>
        /// The GetWindowRect function retrieves the dimensions of the bounding rectangle of the specified window. The dimensions are given in screen coordinates that are relative to the upper-left corner of the screen.
        /// </summary>
        /// <param name="windowHandle">Handle to the window whose client coordinates are to be retrieved.</param>
        /// <param name="windowRectangle"> Pointer to a structure that receives the screen coordinates of the upper-left and lower-right corners of the window.</param>
        /// <returns>
        /// <para>If the function succeeds, the return value is nonzero.</para>
        /// <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
        /// </returns>
        /// <remarks>In conformance with conventions for the RECT structure, the bottom-right coordinates of the returned rectangle are exclusive. In other words, the pixel at (right, bottom) lies immediately outside the rectangle.</remarks>
        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal extern static BOOL GetWindowRect(HWND windowHandle, out Win32Rectangle windowRectangle);

        #endregion

        #region GetWindowInfo

        [DllImport("user32.dll"), SuppressUnmanagedCodeSecurity]
        internal static extern BOOL GetWindowInfo(HWND hwnd, ref WindowInfo wi);

        #endregion

        #region DwmGetWindowAttribute

        [DllImport("dwmapi.dll")]
        unsafe public static extern HRESULT DwmGetWindowAttribute(HWND hwnd, DwmWindowAttribute dwAttribute, void* pvAttribute, DWORD cbAttribute);

        #endregion

        #region GetFocus

        [DllImport("user32.dll")]
        public static extern HWND GetFocus();

        #endregion

        #region IsWindowVisible

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr intPtr);

        #endregion

        #region LoadIcon

        [DllImport("user32.dll")]
        public static extern HICON LoadIcon(HINSTANCE hInstance, LPCTSTR lpIconName);

        #endregion

        #region LoadCursor

        [DllImport("user32.dll")]
        public static extern HCURSOR LoadCursor(HINSTANCE hInstance, LPCTSTR lpCursorName);

        [DllImport("user32.dll")]
        public static extern HCURSOR LoadCursor(HINSTANCE hInstance, IntPtr lpCursorName);

        public static HCURSOR LoadCursor(CursorName lpCursorName)
        {
            return LoadCursor(IntPtr.Zero, new IntPtr((int)lpCursorName));
        }

        #endregion

        #region CreateIconIndirect

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
        /// 
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
        [DllImport("user32.dll", SetLastError=true)]
        public static extern HICON CreateIconIndirect(ref IconInfo iconInfo);

        #endregion

        #region GetIconInfo

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
        /// 
        /// If the function fails, the return value is zero. To get extended 
        /// error information, call Marshal.GetLastWin32Error.
        /// </returns>
        /// <remarks>
        /// GetIconInfo creates bitmaps for the hbmMask and hbmColor members 
        /// of IconInfo. The calling application must manage these bitmaps and
        /// delete them when they are no longer necessary.
        /// </remarks>
        [DllImport("user32.dll", SetLastError=true)]
        public static extern BOOL GetIconInfo(HICON hIcon, out IconInfo pIconInfo);

        #endregion

        #region DestroyIcon

        /// <summary>
        /// Destroys an icon and frees any memory the icon occupied.
        /// </summary>
        /// <param name="hIcon">
        /// A handle to the icon to be destroyed. The icon must not be in use.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// 
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
        /// 
        /// LoadIcon
        /// LoadImage (if you use the LR_SHARED flag)
        /// CopyImage (if you use the LR_COPYRETURNORG flag and the hImage parameter is a shared icon)
        /// CreateIconFromResource
        /// CreateIconFromResourceEx (if you use the LR_SHARED flag)
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern BOOL DestroyIcon(HICON hIcon);

        #endregion


        [DllImport("user32.dll", SetLastError = true)]
        public static extern BOOL SetForegroundWindow(HWND hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern BOOL BringWindowToTop(HWND hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern BOOL SetParent(HWND child, HWND newParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern HDEVNOTIFY RegisterDeviceNotification(HANDLE hRecipient,
            LPVOID NotificationFilter, DeviceNotification Flags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern BOOL UnregisterDeviceNotification(HDEVNOTIFY Handle);

        #endregion

        #region Display settings

        #region ChangeDisplaySettings

        /// <summary>
        /// The ChangeDisplaySettings function changes the settings of the default display device to the specified graphics mode.
        /// </summary>
        /// <param name="device_mode">[in] Pointer to a DEVMODE structure that describes the new graphics mode. If lpDevMode is NULL, all the values currently in the registry will be used for the display setting. Passing NULL for the lpDevMode parameter and 0 for the dwFlags parameter is the easiest way to return to the default mode after a dynamic mode change.</param>
        /// <param name="flags">[in] Indicates how the graphics mode should be changed.</param>
        /// <returns></returns>
        /// <remarks>To change the settings of a specified display device, use the ChangeDisplaySettingsEx function.
        /// <para>To ensure that the DEVMODE structure passed to ChangeDisplaySettings is valid and contains only values supported by the display driver, use the DEVMODE returned by the EnumDisplaySettings function.</para>
        /// <para>When the display mode is changed dynamically, the WM_DISPLAYCHANGE message is sent to all running applications.</para>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int ChangeDisplaySettings(DeviceMode device_mode, ChangeDisplaySettingsEnum flags);

        #endregion int ChangeDisplaySettings

        #region ChangeDisplaySettingsEx

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern LONG ChangeDisplaySettingsEx([MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpszDeviceName,
            LPDEVMODE lpDevMode, HWND hwnd, ChangeDisplaySettingsEnum dwflags, LPVOID lParam);

        #endregion

        #region EnumDisplayDevices

        [DllImport("user32.dll", SetLastError = true, CharSet=CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL EnumDisplayDevices([MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpDevice,
            DWORD iDevNum, [In, Out] WindowsDisplayDevice lpDisplayDevice, DWORD dwFlags);

        #endregion

        #region EnumDisplaySettings

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string device_name,
            int graphics_mode, [In, Out] DeviceMode device_mode);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string device_name,
             DisplayModeSettingsEnum graphics_mode, [In, Out] DeviceMode device_mode);

        #endregion

        #region EnumDisplaySettingsEx

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern BOOL EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpszDeviceName, DisplayModeSettingsEnum iModeNum,
            [In, Out] DeviceMode lpDevMode, DWORD dwFlags);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern BOOL EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpszDeviceName, DWORD iModeNum,
            [In, Out] DeviceMode lpDevMode, DWORD dwFlags);

        #endregion

        #region GetMonitorInfo

        [DllImport("user32.dll", SetLastError = true)]
        public static extern BOOL GetMonitorInfo(IntPtr hMonitor, ref MonitorInfo lpmi);

        #endregion

        #region MonitorFromPoint

        [DllImport("user32.dll", SetLastError = true)]
        public static extern HMONITOR MonitorFromPoint(POINT pt, MonitorFrom dwFlags);

        #endregion

        #region MonitorFromWindow

        [DllImport("user32.dll", SetLastError = true)]
        public static extern HMONITOR MonitorFromWindow(HWND hwnd, MonitorFrom dwFlags);

        #endregion

        #region SetProcessDPIAware

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
        internal static extern BOOL SetProcessDPIAware();

        #endregion

        #region GetDeviceCaps

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetDeviceCaps(IntPtr hDC, DeviceCaps nIndex);

        #endregion

        #endregion

        #region Input functions

        [DllImport("user32.dll", SetLastError=true)]
        public static extern BOOL TrackMouseEvent(ref TrackMouseEventStructure lpEventTrack);

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
        unsafe internal static extern int GetMouseMovePointsEx(
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
        /// 
        /// If there was no previous cursor, the return value is null.
        /// </returns>
        /// <remarks>
        /// The cursor is set only if the new cursor is different from the 
        /// previous cursor; otherwise, the function returns immediately.
        /// 
        /// The cursor is a shared resource. A window should set the cursor 
        /// shape only when the cursor is in its client area or when the window 
        /// is capturing mouse input. In systems without a mouse, the window 
        /// should restore the previous cursor before the cursor leaves the 
        /// client area or before it relinquishes control to another window.
        /// 
        /// If your application must set the cursor while it is in a window, 
        /// make sure the class cursor for the specified window's class is set 
        /// to NULL. If the class cursor is not NULL, the system restores the 
        /// class cursor each time the mouse is moved.
        /// 
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

        #region Async input

        #region GetCursorPos

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <param name="point">Pointer to a POINT structure that receives the screen coordinates of the cursor.</param>
        /// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
        /// <remarks>
        /// <para>The cursor position is always specified in screen coordinates and is not affected by the mapping mode of the window that contains the cursor.</para>
        /// <para>The calling process must have WINSTA_READATTRIBUTES access to the window station.</para>
        /// <para>The input desktop must be the current desktop when you call GetCursorPos. Call OpenInputDesktop to determine whether the current desktop is the input desktop. If it is not, call SetThreadDesktop with the HDESK returned by OpenInputDesktop to switch to that desktop.</para>
        /// </remarks>
        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal static extern BOOL GetCursorPos(ref POINT point);

        #endregion

        #endregion

        #region Raw Input

        #region DefRawInputProc

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
        [CLSCompliant(false)]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern LRESULT DefRawInputProc(RawInput[] RawInput, INT Input, UINT SizeHeader);

        [CLSCompliant(false)]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        unsafe internal static extern LRESULT DefRawInputProc(ref RawInput RawInput, INT Input, UINT SizeHeader);

        [CLSCompliant(false)]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        unsafe internal static extern LRESULT DefRawInputProc(IntPtr RawInput, INT Input, UINT SizeHeader);

        #endregion

        #region RegisterRawInputDevices

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
        [CLSCompliant(false)]
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL RegisterRawInputDevices(
            RawInputDevice[] RawInputDevices,
            UINT NumDevices,
            UINT Size
        );

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL RegisterRawInputDevices(
            RawInputDevice[] RawInputDevices,
            INT NumDevices,
            INT Size
        );

        #endregion

        #region GetRawInputBuffer

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
        [CLSCompliant(false)]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT GetRawInputBuffer(
            [Out] RawInput[] Data,
            [In, Out] ref UINT Size,
            [In] UINT SizeHeader
        );

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputBuffer(
            [Out] RawInput[] Data,
            [In, Out] ref INT Size,
            [In] INT SizeHeader
        );

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputBuffer(
            [Out] IntPtr Data,
            [In, Out] ref INT Size,
            [In] INT SizeHeader
        );

        #endregion

        #region GetRegisteredRawInputDevices

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
        /// <para>
        /// If successful, the function returns a non-negative number that is
        /// the number of RawInputDevice structures written to the buffer. 
        /// </para>
        /// <para>
        /// If the pRawInputDevices buffer is too small or NULL, the function sets
        /// the last error as ERROR_INSUFFICIENT_BUFFER, returns -1,
        /// and sets NumDevices to the required number of devices.
        /// </para>
        /// <para>
        /// If the function fails for any other reason, it returns -1. For more details, call GetLastError.
        /// </para>
        /// </returns>
        [CLSCompliant(false)]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT GetRegisteredRawInputDevices(
            [Out] RawInput[] RawInputDevices,
            [In, Out] ref UINT NumDevices,
            UINT cbSize
        );

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRegisteredRawInputDevices(
            [Out] RawInput[] RawInputDevices,
            [In, Out] ref INT NumDevices,
            INT cbSize
        );

        #endregion

        #region GetRawInputDeviceList

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
        [CLSCompliant(false)]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT GetRawInputDeviceList(
            [In, Out] RawInputDeviceList[] RawInputDeviceList,
            [In, Out] ref UINT NumDevices,
            UINT Size
        );

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputDeviceList(
            [In, Out] RawInputDeviceList[] RawInputDeviceList,
            [In, Out] ref INT NumDevices,
            INT Size
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
        [CLSCompliant(false)]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT GetRawInputDeviceList(
            [In, Out] IntPtr RawInputDeviceList,
            [In, Out] ref UINT NumDevices,
            UINT Size
        );

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputDeviceList(
            [In, Out] IntPtr RawInputDeviceList,
            [In, Out] ref INT NumDevices,
            INT Size
        );

        #endregion

        #region GetRawInputDeviceInfo

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
        /// <para>If successful, this function returns a non-negative number indicating the number of bytes copied to Data.</para>
        /// <para>If Data is not large enough for the data, the function returns -1. If Data is NULL, the function returns a value of zero. In both of these cases, Size is set to the minimum size required for the Data buffer.</para>
        /// <para>Call GetLastError to identify any other errors.</para>
        /// </returns>
        [CLSCompliant(false)]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In, Out] LPVOID Data,
            [In, Out] ref UINT Size
        );

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In, Out] LPVOID Data,
            [In, Out] ref INT Size
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
        /// <para>If successful, this function returns a non-negative number indicating the number of bytes copied to Data.</para>
        /// <para>If Data is not large enough for the data, the function returns -1. If Data is NULL, the function returns a value of zero. In both of these cases, Size is set to the minimum size required for the Data buffer.</para>
        /// <para>Call GetLastError to identify any other errors.</para>
        /// </returns>
        [CLSCompliant(false)]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern UINT GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In, Out] RawInputDeviceInfo Data,
            [In, Out] ref UINT Size
        );

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputDeviceInfo(
            HANDLE Device,
            [MarshalAs(UnmanagedType.U4)] RawInputDeviceInfoEnum Command,
            [In, Out] RawInputDeviceInfo Data,
            [In, Out] ref INT Size
        );


        #endregion

        #region GetRawInputData

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
        /// <param name="Data">Pointer to the data that comes from the RawInput structure. This depends on the value of uiCommand. If Data is NULL, the required size of the buffer is returned in Size.</param>
        /// <param name="Size">Pointer to a variable that specifies the size, in bytes, of the data in Data.</param>
        /// <param name="SizeHeader">Size, in bytes, of RawInputHeader.</param>
        /// <returns>
        /// <para>If Data is NULL and the function is successful, the return value is 0. If Data is not NULL and the function is successful, the return value is the number of bytes copied into Data.</para>
        /// <para>If there is an error, the return value is (UINT)-1.</para>
        /// </returns>
        /// <remarks>
        /// GetRawInputData gets the raw input one RawInput structure at a time. In contrast, GetRawInputBuffer gets an array of RawInput structures.
        /// </remarks>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            [Out] LPVOID Data,
            [In, Out] ref INT Size,
            INT SizeHeader
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
        /// <param name="Data">Pointer to the data that comes from the RawInput structure. This depends on the value of uiCommand. If Data is NULL, the required size of the buffer is returned in Size.</param>
        /// <param name="Size">Pointer to a variable that specifies the size, in bytes, of the data in Data.</param>
        /// <param name="SizeHeader">Size, in bytes, of RawInputHeader.</param>
        /// <returns>
        /// <para>If Data is NULL and the function is successful, the return value is 0. If Data is not NULL and the function is successful, the return value is the number of bytes copied into Data.</para>
        /// <para>If there is an error, the return value is (UINT)-1.</para>
        /// </returns>
        /// <remarks>
        /// GetRawInputData gets the raw input one RawInput structure at a time. In contrast, GetRawInputBuffer gets an array of RawInput structures.
        /// </remarks>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern INT GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            /*[MarshalAs(UnmanagedType.LPStruct)]*/ [Out] out RawInput Data,
            [In, Out] ref INT Size,
            INT SizeHeader
        );

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        unsafe internal static extern INT GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            RawInput* Data,
            [In, Out] ref INT Size,
            INT SizeHeader
        );

        #endregion

        #region IntPtr NextRawInputStructure(IntPtr data)

        /* From winuser.h
        #ifdef _WIN64
        #define RAWINPUT_ALIGN(x)   (((x) + sizeof(QWORD) - 1) & ~(sizeof(QWORD) - 1))
        #else   // _WIN64
        #define RAWINPUT_ALIGN(x)   (((x) + sizeof(DWORD) - 1) & ~(sizeof(DWORD) - 1))
        #endif  // _WIN64

        #define NEXTRAWINPUTBLOCK(ptr) ((PRAWINPUT)RAWINPUT_ALIGN((ULONG_PTR)((PBYTE)(ptr) + (ptr)->header.dwSize)))
        */

        internal static IntPtr NextRawInputStructure(IntPtr data)
        {
            unsafe
            {
                return RawInputAlign((IntPtr)(((byte*)data) + API.RawInputHeaderSize));
            }
        }

        private static IntPtr RawInputAlign(IntPtr data)
        {
            unsafe
            {
                return (IntPtr)(((byte*)data) + ((IntPtr.Size - 1) & ~(IntPtr.Size - 1)));
            }
        }


        #endregion

        #endregion

        #endregion

        #region GDI functions

        #region GetStockObject

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr GetStockObject(int index);

        #endregion

        #endregion

        #region Timer Functions

        [DllImport("user32.dll", SetLastError=true)]
        public static extern UINT_PTR SetTimer(HWND hWnd, UINT_PTR nIDEvent, UINT uElapse, TIMERPROC lpTimerFunc);

        [DllImport("user32.dll", SetLastError=true)]
        public static extern BOOL KillTimer(HWND hWnd, UINT_PTR uIDEvent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void TimerProc(HWND hwnd, WindowMessage uMsg, UINT_PTR idEvent, DWORD dwTime);

        #endregion

        #region Shell Functions

        [DllImport("shell32.dll")]
        public static extern DWORD_PTR SHGetFileInfo(LPCTSTR pszPath, DWORD dwFileAttributes, ref SHFILEINFO psfi, UINT cbFileInfo, ShGetFileIconFlags uFlags);

        #endregion

        #region Registry Functions

        [DllImport("Advapi32.dll")]
        internal static extern int RegOpenKeyEx(
            HKEY hKey,
            [MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpSubKey,
            DWORD ulOptions,
            REGSAM samDesired,
            out PHKEY phkResult);

        [DllImport("Advapi32.dll")]
        internal static extern int RegGetValue(
            HKEY hkey,
            [MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpSubKey,
            [MarshalAs(UnmanagedType.LPTStr)] LPCTSTR lpValue,
            DWORD dwFlags,
            out DWORD pdwType,
            StringBuilder pvData,
            ref DWORD pcbData);

        #endregion
    }

    #region --- Constants ---

        static class Constants
        {
            // Found in winuser.h
            internal const int KEYBOARD_OVERRUN_MAKE_CODE = 0xFF;

            // WM_ACTIVATE state values (found in winuser.h)
            internal const int WA_INACTIVE    = 0;
            internal const int WA_ACTIVE      = 1;
            internal const int WA_CLICKACTIVE = 2;

            // Window Messages (found in winuser.h)
            internal const int WM_NULL = 0x0000;
            internal const int WM_CREATE = 0x0001;
            internal const int WM_DESTROY = 0x0002;
            internal const int WM_MOVE = 0x0003;
            internal const int WM_SIZE = 0x0005;
            internal const int WM_ACTIVATE = 0x0006;
            internal const int WM_SETFOCUS = 0x0007;
            internal const int WM_KILLFOCUS = 0x0008;
            internal const int WM_ENABLE = 0x000A;
            internal const int WM_SETREDRAW = 0x000B;
            internal const int WM_SETTEXT = 0x000C;
            internal const int WM_GETTEXT = 0x000D;
            internal const int WM_GETTEXTLENGTH = 0x000E;
            internal const int WM_PAINT = 0x000F;
            internal const int WM_CLOSE = 0x0010;
            // _WIN32_WCE
            internal const int WM_QUERYENDSESSION = 0x0011;
            internal const int WM_QUERYOPEN = 0x0013;
            internal const int WM_ENDSESSION = 0x0016;
            internal const int WM_QUIT = 0x0012;
            internal const int WM_ERASEBKGND = 0x0014;
            internal const int WM_SYSCOLORCHANGE = 0x0015;
            internal const int WM_SHOWWINDOW = 0x0018;
            internal const int WM_WININICHANGE = 0x001A;
            // WINVER >= 0x400
            internal const int WM_SETTINGCHANGE = WM_WININICHANGE;

            internal const int WM_DEVMODECHANGE = 0x001B;
            internal const int WM_ACTIVATEAPP = 0x001C;
            internal const int WM_FONTCHANGE = 0x001D;
            internal const int WM_TIMECHANGE = 0x001E;
            internal const int WM_CANCELMODE = 0x001F;
            internal const int WM_SETCURSOR = 0x0020;
            internal const int WM_MOUSEACTIVATE = 0x0021;
            internal const int WM_CHILDACTIVATE = 0x0022;
            internal const int WM_QUEUESYNC = 0x0023;

            internal const int WM_GETMINMAXINFO = 0x0024;

            internal const int WM_WINDOWPOSCHANGING = 0x0046;
            internal const int WM_WINDOWPOSCHANGED = 0x0047;

            // Keyboard events (found in winuser.h)
            internal const int WM_INPUT = 0x00FF;       // Raw input. XP and higher only.
            internal const int WM_KEYDOWN = 0x0100;
            internal const int WM_KEYUP = 0x101;
            internal const int WM_SYSKEYDOWN = 0x0104;
            internal const int WM_SYSKEYUP = 0x0105;
            internal const int WM_COMMAND = 0x0111;
            internal const int WM_SYSCOMMAND = 0x0112;
            internal const int WM_ENTERIDLE = 0x121;

            // Pixel types (found in wingdi.h)
            internal const byte PFD_TYPE_RGBA = 0;
            internal const byte PFD_TYPE_COLORINDEX = 1;

            // Layer types (found in wingdi.h)
            internal const byte PFD_MAIN_PLANE = 0;
            internal const byte PFD_OVERLAY_PLANE = 1;
            internal const byte PFD_UNDERLAY_PLANE = unchecked((byte)-1);

            // Device mode types (found in wingdi.h)
            internal const int DM_LOGPIXELS = 0x00020000;
            internal const int DM_BITSPERPEL = 0x00040000;
            internal const int DM_PELSWIDTH = 0x00080000;
            internal const int DM_PELSHEIGHT = 0x00100000;
            internal const int DM_DISPLAYFLAGS = 0x00200000;
            internal const int DM_DISPLAYFREQUENCY = 0x00400000;

            // ChangeDisplaySettings results (found in winuser.h)
            internal const int DISP_CHANGE_SUCCESSFUL = 0;
            internal const int DISP_CHANGE_RESTART = 1;
            internal const int DISP_CHANGE_FAILED = -1;

            // (found in winuser.h)
            internal const int ENUM_REGISTRY_SETTINGS = -2;
            internal const int ENUM_CURRENT_SETTINGS = -1;

            internal static readonly IntPtr MESSAGE_ONLY = new IntPtr(-3);

            internal static readonly IntPtr HKEY_LOCAL_MACHINE = new IntPtr(unchecked((int)0x80000002));

            // System Error Codes
            // http://msdn.microsoft.com/en-us/library/windows/desktop/ms681381(v=vs.85).aspx

            /// <summary>
            /// The point passed to GetMouseMovePoints is not in the buffer.
            /// </summary>
            internal const int ERROR_POINT_NOT_FOUND = 1171;

            /// <summary>
            /// Retrieves the points using the display resolution.
            /// </summary>
            internal const int GMMP_USE_DISPLAY_POINTS = 1;

            /// <summary>
            /// Retrieves high resolution points. Points can range from zero to 
            /// 65,535 (0xFFFF) in both x and y coordinates. This is the resolution 
            /// provided by absolute coordinate pointing devices such as drawing 
            /// tablets.
            /// </summary>
            internal const int GMMP_USE_HIGH_RESOLUTION_POINTS = 2;
        }

        #endregion

    #region --- Structures ---

    #region CreateStruct

    internal struct CreateStruct
    {
        /// <summary>
        /// Contains additional data which may be used to create the window.
        /// </summary>
        /// <remarks>
        ///  If the window is being created as a result of a call to the CreateWindow
        ///  or CreateWindowEx function, this member contains the value of the lpParam 
        ///  parameter specified in the function call.
        ///  <para>
        /// If the window being created is a multiple-document interface (MDI) client window,
        /// this member contains a pointer to a CLIENTCREATESTRUCT structure. If the window
        /// being created is a MDI child window, this member contains a pointer to an 
        /// MDICREATESTRUCT structure.
        ///  </para>
        /// <para>
        /// Windows NT/2000/XP: If the window is being created from a dialog template,
        /// this member is the address of a SHORT value that specifies the size, in bytes,
        /// of the window creation data. The value is immediately followed by the creation data.
        /// </para>
        /// <para>
        /// Windows NT/2000/XP: You should access the data represented by the lpCreateParams member
        /// using a pointer that has been declared using the UNALIGNED type, because the pointer
        /// may not be DWORD aligned.
        /// </para>
        /// </remarks>
        internal LPVOID lpCreateParams;
        /// <summary>
        /// Handle to the module that owns the new window.
        /// </summary>
        internal HINSTANCE hInstance;
        /// <summary>
        /// Handle to the menu to be used by the new window.
        /// </summary>
        internal HMENU hMenu;
        /// <summary>
        /// Handle to the parent window, if the window is a child window.
        /// If the window is owned, this member identifies the owner window.
        /// If the window is not a child or owned window, this member is NULL.
        /// </summary>
        internal HWND hwndParent;
        /// <summary>
        /// Specifies the height of the new window, in pixels.
        /// </summary>
        internal int cy;
        /// <summary>
        /// Specifies the width of the new window, in pixels.
        /// </summary>
        internal int cx;
        /// <summary>
        /// Specifies the y-coordinate of the upper left corner of the new window.
        /// If the new window is a child window, coordinates are relative to the parent window.
        /// Otherwise, the coordinates are relative to the screen origin.
        /// </summary>
        internal int y;
        /// <summary>
        /// Specifies the x-coordinate of the upper left corner of the new window.
        /// If the new window is a child window, coordinates are relative to the parent window.
        /// Otherwise, the coordinates are relative to the screen origin.
        /// </summary>
        internal int x;
        /// <summary>
        /// Specifies the style for the new window.
        /// </summary>
        internal LONG style;
        /// <summary>
        /// Pointer to a null-terminated string that specifies the name of the new window.
        /// </summary>
        [MarshalAs(UnmanagedType.LPTStr)]
        internal LPCTSTR lpszName;
        /// <summary>
        /// Either a pointer to a null-terminated string or an atom that specifies the class name
        /// of the new window.
        /// <remarks>
        /// Note  Because the lpszClass member can contain a pointer to a local (and thus inaccessable) atom,
        /// do not obtain the class name by using this member. Use the GetClassName function instead.
        /// </remarks>
        /// </summary>
        [MarshalAs(UnmanagedType.LPTStr)]
        internal LPCTSTR lpszClass;
        /// <summary>
        /// Specifies the extended window style for the new window.
        /// </summary>
        internal DWORD dwExStyle;
    }

    #endregion

    #region StyleStruct

    struct StyleStruct
    {
        public WindowStyle Old;
        public WindowStyle New;
    }

    #endregion

    #region ExtendedStyleStruct

    struct ExtendedStyleStruct
    {
        public ExtendedWindowStyle Old;
        public ExtendedWindowStyle New;
    }

    #endregion

    #region PixelFormatDescriptor

    /// \internal
    /// <summary>
    /// Describes a pixel format. It is used when interfacing with the WINAPI to create a new Context.
    /// Found in WinGDI.h
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct PixelFormatDescriptor
    {
        internal short Size;
        internal short Version;
        internal PixelFormatDescriptorFlags Flags;
        internal PixelType PixelType;
        internal byte ColorBits;
        internal byte RedBits;
        internal byte RedShift;
        internal byte GreenBits;
        internal byte GreenShift;
        internal byte BlueBits;
        internal byte BlueShift;
        internal byte AlphaBits;
        internal byte AlphaShift;
        internal byte AccumBits;
        internal byte AccumRedBits;
        internal byte AccumGreenBits;
        internal byte AccumBlueBits;
        internal byte AccumAlphaBits;
        internal byte DepthBits;
        internal byte StencilBits;
        internal byte AuxBuffers;
        internal byte LayerType;
        private byte Reserved;
        internal int LayerMask;
        internal int VisibleMask;
        internal int DamageMask;
    }
    
    #endregion
    
    #region internal class LayerPlaneDescriptor

    /// \internal
    /// <summary>
    /// Describes the pixel format of a drawing surface.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct LayerPlaneDescriptor
    {
        internal static readonly WORD Size = (WORD)Marshal.SizeOf(typeof(LayerPlaneDescriptor)); 
        internal WORD  Version; 
        internal DWORD Flags; 
        internal BYTE  PixelType; 
        internal BYTE  ColorBits; 
        internal BYTE  RedBits; 
        internal BYTE  RedShift; 
        internal BYTE  GreenBits; 
        internal BYTE  GreenShift; 
        internal BYTE  BlueBits; 
        internal BYTE  BlueShift; 
        internal BYTE  AlphaBits; 
        internal BYTE  AlphaShift; 
        internal BYTE  AccumBits; 
        internal BYTE  AccumRedBits; 
        internal BYTE  AccumGreenBits; 
        internal BYTE  AccumBlueBits; 
        internal BYTE  AccumAlphaBits; 
        internal BYTE  DepthBits; 
        internal BYTE  StencilBits; 
        internal BYTE  AuxBuffers; 
        internal BYTE  LayerPlane; 
        BYTE  Reserved; 
        internal COLORREF crTransparent; 
    }

    #endregion

    #region GlyphMetricsFloat

    /// \internal
    /// <summary>
    /// The <b>GlyphMetricsFloat</b> structure contains information about the placement and orientation of a glyph in a
    /// character cell.
    /// </summary>
    /// <remarks>The values of <b>GlyphMetricsFloat</b> are specified as notional units.</remarks>
    /// <seealso cref="PointFloat" />
    [StructLayout(LayoutKind.Sequential)]
    internal struct GlyphMetricsFloat
    {
        /// <summary>
        /// Specifies the width of the smallest rectangle (the glyph's black box) that completely encloses the glyph.
        /// </summary>
        internal float BlackBoxX;
        /// <summary>
        /// Specifies the height of the smallest rectangle (the glyph's black box) that completely encloses the glyph.
        /// </summary>
        internal float BlackBoxY;
        /// <summary>
        /// Specifies the x and y coordinates of the upper-left corner of the smallest rectangle that completely encloses the glyph.
        /// </summary>
        internal PointFloat GlyphOrigin;
        /// <summary>
        /// Specifies the horizontal distance from the origin of the current character cell to the origin of the next character cell.
        /// </summary>
        internal float CellIncX;
        /// <summary>
        /// Specifies the vertical distance from the origin of the current character cell to the origin of the next character cell.
        /// </summary>
        internal float CellIncY;
    }

    #endregion

    #region PointFloat

    /// \internal
    /// <summary>
    /// The <b>PointFloat</b> structure contains the x and y coordinates of a point.
    /// </summary>
    /// <seealso cref="GlyphMetricsFloat" />
    [StructLayout(LayoutKind.Sequential)]
    internal struct PointFloat
    {
        /// <summary>
        /// Specifies the horizontal (x) coordinate of a point.
        /// </summary>
        internal float X;
        /// <summary>
        /// Specifies the vertical (y) coordinate of a point.
        /// </summary>
        internal float Y;
    };

    #endregion

    #region DeviceMode
    /*
    typedef struct _devicemode { 
      BCHAR  dmDeviceName[CCHDEVICENAME]; 
      WORD   dmSpecVersion; 
      WORD   dmDriverVersion; 
      WORD   dmSize; 
      WORD   dmDriverExtra; 
      DWORD  dmFields; 
      union {
        struct {
          short dmOrientation;
          short dmPaperSize;
          short dmPaperLength;
          short dmPaperWidth;
          short dmScale; 
          short dmCopies; 
          short dmDefaultSource; 
          short dmPrintQuality; 
        };
        POINTL dmPosition;
        DWORD  dmDisplayOrientation;
        DWORD  dmDisplayFixedOutput;
      };

      short  dmColor; 
      short  dmDuplex; 
      short  dmYResolution; 
      short  dmTTOption; 
      short  dmCollate; 
      BYTE  dmFormName[CCHFORMNAME]; 
      WORD  dmLogPixels; 
      DWORD  dmBitsPerPel; 
      DWORD  dmPelsWidth; 
      DWORD  dmPelsHeight; 
      union {
        DWORD  dmDisplayFlags; 
        DWORD  dmNup;
      }
      DWORD  dmDisplayFrequency; 
    #if(WINVER >= 0x0400) 
      DWORD  dmICMMethod;
      DWORD  dmICMIntent;
      DWORD  dmMediaType;
      DWORD  dmDitherType;
      DWORD  dmReserved1;
      DWORD  dmReserved2;
    #if (WINVER >= 0x0500) || (_WIN32_WINNT >= 0x0400)
      DWORD  dmPanningWidth;
      DWORD  dmPanningHeight;
    #endif
    #endif 
    } DEVMODE; 
    */
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal class DeviceMode
    {
        internal DeviceMode()
        {
            Size = (short)Marshal.SizeOf(this);
        }

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        internal string DeviceName;
        internal short SpecVersion;
        internal short DriverVersion;
        private short Size;
        internal short DriverExtra;
        internal int Fields;

        //internal short Orientation;
        //internal short PaperSize;
        //internal short PaperLength;
        //internal short PaperWidth;
        //internal short Scale;
        //internal short Copies;
        //internal short DefaultSource;
        //internal short PrintQuality;

        internal POINT Position;
        internal DWORD DisplayOrientation;
        internal DWORD DisplayFixedOutput;

        internal short Color;
        internal short Duplex;
        internal short YResolution;
        internal short TTOption;
        internal short Collate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        internal string FormName;
        internal short LogPixels;
        internal int BitsPerPel;
        internal int PelsWidth;
        internal int PelsHeight;
        internal int DisplayFlags;
        internal int DisplayFrequency;
        internal int ICMMethod;
        internal int ICMIntent;
        internal int MediaType;
        internal int DitherType;
        internal int Reserved1;
        internal int Reserved2;
        internal int PanningWidth;
        internal int PanningHeight;
    }

    #endregion DeviceMode class

    #region DisplayDevice

    /// \internal
    /// <summary>
    /// The DISPLAY_DEVICE structure receives information about the display device specified by the iDevNum parameter of the EnumDisplayDevices function.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal class WindowsDisplayDevice
    {
        internal WindowsDisplayDevice()
        {
            size = (short)Marshal.SizeOf(this);
        }
        readonly DWORD size;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        internal string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        internal string DeviceString;
        internal DisplayDeviceStateFlags StateFlags;    // DWORD
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        internal string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        internal string DeviceKey;
    }

    #endregion

    #region Window Handling

    #region WindowClass
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowClass
    {
        internal ClassStyle Style;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        internal WindowProcedure WindowProcedure;
        internal int ClassExtraBytes;
        internal int WindowExtraBytes;
        //[MarshalAs(UnmanagedType.
        internal IntPtr Instance;
        internal IntPtr Icon;
        internal IntPtr Cursor;
        internal IntPtr BackgroundBrush;
        //[MarshalAs(UnmanagedType.LPStr)]
        internal IntPtr MenuName;
        [MarshalAs(UnmanagedType.LPTStr)]
        internal string ClassName;
        //internal string ClassName;

        internal static int SizeInBytes = Marshal.SizeOf(default(WindowClass));
    }
    #endregion

    #region ExtendedWindowClass

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    struct ExtendedWindowClass
    {
        public UINT Size;
        public ClassStyle Style;
        //public WNDPROC WndProc;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public WindowProcedure WndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public HINSTANCE Instance;
        public HICON Icon;
        public HCURSOR Cursor;
        public HBRUSH Background;
        public IntPtr MenuName;
        public IntPtr ClassName;
        public HICON IconSm;

        public static uint SizeInBytes = (uint)Marshal.SizeOf(default(ExtendedWindowClass));
    }

    #endregion

    #region internal struct MinMaxInfo

    /// \internal
    /// <summary>
    /// Struct pointed to by WM_GETMINMAXINFO lParam
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct MINMAXINFO
    {
        Point Reserved;
        public Size MaxSize;
        public Point MaxPosition;
        public Size MinTrackSize;
        public Size MaxTrackSize;
    }

    #endregion

    #region internal struct WindowPosition

    /// \internal
    /// <summary>
    /// The WindowPosition structure contains information about the size and position of a window.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowPosition
    {
        /// <summary>
        /// Handle to the window.
        /// </summary>
        internal HWND hwnd;
        /// <summary>
        /// Specifies the position of the window in Z order (front-to-back position).
        /// This member can be a handle to the window behind which this window is placed,
        /// or can be one of the special values listed with the SetWindowPos function.
        /// </summary>
        internal HWND hwndInsertAfter;
        /// <summary>
        /// Specifies the position of the left edge of the window.
        /// </summary>
        internal int x;
        /// <summary>
        /// Specifies the position of the top edge of the window.
        /// </summary>
        internal int y;
        /// <summary>
        /// Specifies the window width, in pixels.
        /// </summary>
        internal int cx;
        /// <summary>
        /// Specifies the window height, in pixels.
        /// </summary>
        internal int cy;
        /// <summary>
        /// Specifies the window position.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        internal SetWindowPosFlags flags;
    }

    #region internal enum SetWindowPosFlags

    [Flags]
    internal enum SetWindowPosFlags : int
    {
        /// <summary>
        /// Retains the current size (ignores the cx and cy parameters).
        /// </summary>
        NOSIZE          = 0x0001,
        /// <summary>
        /// Retains the current position (ignores the x and y parameters).
        /// </summary>
        NOMOVE          = 0x0002,
        /// <summary>
        /// Retains the current Z order (ignores the hwndInsertAfter parameter).
        /// </summary>
        NOZORDER        = 0x0004,
        /// <summary>
        /// Does not redraw changes. If this flag is set, no repainting of any kind occurs.
        /// This applies to the client area, the nonclient area (including the title bar and scroll bars),
        /// and any part of the parent window uncovered as a result of the window being moved.
        /// When this flag is set, the application must explicitly invalidate or redraw any parts
        /// of the window and parent window that need redrawing.
        /// </summary>
        NOREDRAW        = 0x0008,
        /// <summary>
        /// Does not activate the window. If this flag is not set,
        /// the window is activated and moved to the top of either the topmost or non-topmost group
        /// (depending on the setting of the hwndInsertAfter member).
        /// </summary>
        NOACTIVATE      = 0x0010,
        /// <summary>
        /// Sends a WM_NCCALCSIZE message to the window, even if the window's size is not being changed.
        /// If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.
        /// </summary>
        FRAMECHANGED    = 0x0020, /* The frame changed: send WM_NCCALCSIZE */
        /// <summary>
        /// Displays the window.
        /// </summary>
        SHOWWINDOW      = 0x0040,
        /// <summary>
        /// Hides the window.
        /// </summary>
        HIDEWINDOW      = 0x0080,
        /// <summary>
        /// Discards the entire contents of the client area. If this flag is not specified,
        /// the valid contents of the client area are saved and copied back into the client area 
        /// after the window is sized or repositioned.
        /// </summary>
        NOCOPYBITS      = 0x0100,
        /// <summary>
        /// Does not change the owner window's position in the Z order.
        /// </summary>
        NOOWNERZORDER   = 0x0200, /* Don't do owner Z ordering */
        /// <summary>
        /// Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
        /// </summary>
        NOSENDCHANGING  = 0x0400, /* Don't send WM_WINDOWPOSCHANGING */

        /// <summary>
        /// Draws a frame (defined in the window's class description) around the window.
        /// </summary>
        DRAWFRAME       = FRAMECHANGED,
        /// <summary>
        /// Same as the NOOWNERZORDER flag.
        /// </summary>
        NOREPOSITION    = NOOWNERZORDER,

        DEFERERASE      = 0x2000,
        ASYNCWINDOWPOS  = 0x4000
    }

    #endregion

    #endregion

    #endregion

    #region Raw Input structures

    #region RawInputDevice

    /// \internal
    /// <summary>
    /// Defines information for the raw input devices.
    /// </summary>
    /// <remarks>
    /// If RIDEV_NOLEGACY is set for a mouse or a keyboard, the system does not generate any legacy message for that device for the application. For example, if the mouse TLC is set with RIDEV_NOLEGACY, WM_LBUTTONDOWN and related legacy mouse messages are not generated. Likewise, if the keyboard TLC is set with RIDEV_NOLEGACY, WM_KEYDOWN and related legacy keyboard messages are not generated.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputDevice
    {
        /// <summary>
        /// Top level collection Usage page for the raw input device.
        /// </summary>
        //internal USHORT UsagePage;
        internal SHORT UsagePage;
        /// <summary>
        /// Top level collection Usage for the raw input device.
        /// </summary>
        //internal USHORT Usage;
        internal SHORT Usage;
        /// <summary>
        /// Mode flag that specifies how to interpret the information provided by UsagePage and Usage.
        /// It can be zero (the default) or one of the following values.
        /// By default, the operating system sends raw input from devices with the specified top level collection (TLC)
        /// to the registered application as long as it has the window focus. 
        /// </summary>
        internal RawInputDeviceFlags Flags;
        /// <summary>
        /// Handle to the target window. If NULL it follows the keyboard focus.
        /// </summary>
        internal HWND Target;

        public override string ToString()
        {
            return String.Format("{0}/{1}, flags: {2}, window: {3}", UsagePage, Usage, Flags, Target);
        }
    }

    #endregion

    #region RawInputDeviceList

    /// \internal
    /// <summary>
    /// Contains information about a raw input device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputDeviceList
    {
        /// <summary>
        /// Handle to the raw input device.
        /// </summary>
        internal HANDLE Device;
        /// <summary>
        /// Type of device.
        /// </summary>
        internal RawInputDeviceType Type;

        public override string ToString()
        {
            return String.Format("{0}, Handle: {1}", Type, Device);
        }
    }

    #endregion

    #region RawInput

    /// \internal
    /// <summary>
    /// Contains the raw input from a device.
    /// </summary>
    /// <remarks>
    /// <para>The handle to this structure is passed in the lParam parameter of WM_INPUT.</para>
    /// <para>To get detailed information -- such as the header and the content of the raw input -- call GetRawInputData.</para>
    /// <para>To get device specific information, call GetRawInputDeviceInfo with the hDevice from RAWINPUTHEADER.</para>
    /// <para>Raw input is available only when the application calls RegisterRawInputDevices with valid device specifications.</para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct RawInput
    {
        public RawInputHeader Header;
        public RawInputData Data;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct RawInputData
    {
        [FieldOffset(0)]
        internal RawMouse Mouse;
        [FieldOffset(0)]
        internal RawKeyboard Keyboard;
        [FieldOffset(0)]
        internal RawHID HID;
    }

    #endregion

    #region RawInputHeader

    /// \internal
    /// <summary>
    /// Contains the header information that is part of the raw input data.
    /// </summary>
    /// <remarks>
    /// To get more information on the device, use hDevice in a call to GetRawInputDeviceInfo.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputHeader
    {
        /// <summary>
        /// Type of raw input.
        /// </summary>
        internal RawInputDeviceType Type;
        /// <summary>
        /// Size, in bytes, of the entire input packet of data. This includes the RawInput struct plus possible extra input reports in the RAWHID variable length array.
        /// </summary>
        internal DWORD Size;
        /// <summary>
        /// Handle to the device generating the raw input data.
        /// </summary>
        internal HANDLE Device;
        /// <summary>
        /// Value passed in the wParam parameter of the WM_INPUT message.
        /// </summary>
        internal WPARAM Param;
    }

    #endregion

    #region RawKeyboard

    /// \internal
    /// <summary>
    /// Contains information about the state of the keyboard.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawKeyboard
    {
        /// <summary>
        /// Scan code from the key depression. The scan code for keyboard overrun is KEYBOARD_OVERRUN_MAKE_CODE.
        /// </summary>
        //internal USHORT MakeCode;
        internal SHORT MakeCode;
        /// <summary>
        /// Flags for scan code information. It can be one or more of the following.
        /// RI_KEY_MAKE
        /// RI_KEY_BREAK
        /// RI_KEY_E0
        /// RI_KEY_E1
        /// RI_KEY_TERMSRV_SET_LED
        /// RI_KEY_TERMSRV_SHADOW
        /// </summary>
        internal RawInputKeyboardDataFlags Flags;
        /// <summary>
        /// Reserved; must be zero.
        /// </summary>
        USHORT Reserved;
        /// <summary>
        /// Microsoft Windows message compatible virtual-key code. For more information, see Virtual-Key Codes.
        /// </summary>
        //internal USHORT VKey;
        internal VirtualKeys VKey;
        /// <summary>
        /// Corresponding window message, for example WM_KEYDOWN, WM_SYSKEYDOWN, and so forth.
        /// </summary>
        //internal UINT Message;
        internal INT Message;
        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        //internal ULONG ExtraInformation;
        internal LONG ExtraInformation;
    }

    #endregion

    #region RawMouse

    /// \internal
    /// <summary>
    /// Contains information about the state of the mouse.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal struct RawMouse
    {
        /// <summary>
        /// Mouse state. This member can be any reasonable combination of the following. 
        /// MOUSE_ATTRIBUTES_CHANGED
        /// Mouse attributes changed; application needs to query the mouse attributes.
        /// MOUSE_MOVE_RELATIVE
        /// Mouse movement data is relative to the last mouse position.
        /// MOUSE_MOVE_ABSOLUTE
        /// Mouse movement data is based on absolute position.
        /// MOUSE_VIRTUAL_DESKTOP
        /// Mouse coordinates are mapped to the virtual desktop (for a multiple monitor system).
        /// </summary>
        [FieldOffset(0)] public RawMouseFlags Flags;  // USHORT in winuser.h, but only INT works -- USHORT returns 0.

        [FieldOffset(4)] public RawInputMouseState ButtonFlags;

        /// <summary>
        /// If usButtonFlags is RI_MOUSE_WHEEL, this member is a signed value that specifies the wheel delta.
        /// </summary>
        [FieldOffset(6)] public USHORT ButtonData;

        /// <summary>
        /// Raw state of the mouse buttons.
        /// </summary>
        [FieldOffset(8)] public ULONG RawButtons;

        /// <summary>
        /// Motion in the X direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
        /// </summary>
        [FieldOffset(12)] public LONG LastX;
        
        /// <summary>
        /// Motion in the Y direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
        /// </summary>
        [FieldOffset(16)] public LONG LastY;
        
        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        [FieldOffset(20)] public ULONG ExtraInformation;
    }

    #endregion

    #region RawMouse (second try)
#if false
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawMouse
    {
        byte b00, b01, b02, b03, b04, b05, b06, b07,
             b08, b09, b10, b11, b12, b13, b14, b15,
             b16, b17, b18, b19, b20, b21, b22, b23;

        unsafe private byte* this[int i] { get { fixed (byte* ptr = &b00) { return ptr + i; } } }

        /// <summary>
        /// Mouse state. This member can be any reasonable combination of the following. 
        /// MOUSE_ATTRIBUTES_CHANGED
        /// Mouse attributes changed; application needs to query the mouse attributes.
        /// MOUSE_MOVE_RELATIVE
        /// Mouse movement data is relative to the last mouse position.
        /// MOUSE_MOVE_ABSOLUTE
        /// Mouse movement data is based on absolute position.
        /// MOUSE_VIRTUAL_DESKTOP
        /// Mouse coordinates are mapped to the virtual desktop (for a multiple monitor system).
        /// </summary>
        internal RawMouseFlags Flags { get { unsafe { return *(RawMouseFlags*)this[0]; } } } 

        /// <summary>
        /// Transition state of the mouse buttons.
        /// </summary>
        internal RawInputMouseState ButtonFlags { get { unsafe { return *(RawInputMouseState*)this[4]; } } }

        /// <summary>
        /// If usButtonFlags is RI_MOUSE_WHEEL, this member is a signed value that specifies the wheel delta.
        /// </summary>
        internal USHORT ButtonData { get { unsafe { return *(USHORT*)this[6]; } } }

        /// <summary>
        /// Raw state of the mouse buttons.
        /// </summary>
        internal ULONG RawButtons { get { unsafe { return *(ULONG*)this[8]; } } }

        /// <summary>
        /// Motion in the X direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
        /// </summary>
        internal LONG LastX { get { unsafe { return *(LONG*)this[12]; } } }

        /// <summary>
        /// Motion in the Y direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
        /// </summary>
        internal LONG LastY { get { unsafe { return *(LONG*)this[16]; } } }

        /// <summary>
        /// Device-specific additional information for the event.
        /// </summary>
        internal ULONG ExtraInformation { get { unsafe { return *(ULONG*)this[20]; } } }
    }
#endif
    #endregion

    #region RawHID

    /// \internal
    /// <summary>
    /// The RawHID structure describes the format of the raw input
    /// from a Human Interface Device (HID).
    /// </summary>
    /// <remarks>
    /// Each WM_INPUT can indicate several inputs, but all of the inputs
    /// come from the same HID. The size of the bRawData array is
    /// dwSizeHid * dwCount.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawHID
    {
        /// <summary>
        /// Size, in bytes, of each HID input in bRawData.
        /// </summary>
        internal DWORD SizeHid;
        /// <summary>
        /// Number of HID inputs in bRawData.
        /// </summary>
        internal DWORD Count;
        // The RawData field must be marshalled manually.
        ///// <summary>
        ///// Raw input data as an array of bytes.
        ///// </summary>
        //internal IntPtr RawData;
    }

    #endregion

    #region RawInputDeviceInfo

    /// \internal
    /// <summary>
    /// Defines the raw input data coming from any device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal class RawInputDeviceInfo
    {
        /// <summary>
        /// Size, in bytes, of the RawInputDeviceInfo structure.
        /// </summary>
        DWORD Size = Marshal.SizeOf(typeof(RawInputDeviceInfo)); 
        /// <summary>
        /// Type of raw input data.
        /// </summary>
        internal RawInputDeviceType Type;
        internal DeviceStruct Device;
        [StructLayout(LayoutKind.Explicit)]
        internal struct DeviceStruct
        {
            [FieldOffset(0)]
            internal RawInputMouseDeviceInfo Mouse;
            [FieldOffset(0)]
            internal RawInputKeyboardDeviceInfo Keyboard;
            [FieldOffset(0)]
            internal RawInputHIDDeviceInfo HID; 
        };
    }

    #endregion

    #region RawInputHIDDeviceInfo

    /// \internal
    /// <summary>
    /// Defines the raw input data coming from the specified Human Interface Device (HID).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputHIDDeviceInfo
    {
        /// <summary>
        /// Vendor ID for the HID.
        /// </summary>
        internal DWORD VendorId;
        /// <summary>
        /// Product ID for the HID.
        /// </summary>
        internal DWORD ProductId;
        /// <summary>
        /// Version number for the HID.
        /// </summary>
        internal DWORD VersionNumber;
        /// <summary>
        /// Top-level collection Usage Page for the device.
        /// </summary>
        //internal USHORT UsagePage;
        internal SHORT UsagePage;
        /// <summary>
        /// Top-level collection Usage for the device.
        /// </summary>
        //internal USHORT Usage;
        internal SHORT Usage;
    }

    #endregion

    #region RawInputKeyboardDeviceInfo

    /// \internal
    /// <summary>
    /// Defines the raw input data coming from the specified keyboard.
    /// </summary>
    /// <remarks>
    /// For the keyboard, the Usage Page is 1 and the Usage is 6.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputKeyboardDeviceInfo
    {
        /// <summary>
        /// Type of the keyboard.
        /// </summary>
        internal DWORD Type;
        /// <summary>
        /// Subtype of the keyboard.
        /// </summary>
        internal DWORD SubType;
        /// <summary>
        /// Scan code mode.
        /// </summary>
        internal DWORD KeyboardMode;
        /// <summary>
        /// Number of function keys on the keyboard.
        /// </summary>
        internal DWORD NumberOfFunctionKeys;
        /// <summary>
        /// Number of LED indicators on the keyboard.
        /// </summary>
        internal DWORD NumberOfIndicators;
        /// <summary>
        /// Total number of keys on the keyboard.
        /// </summary>
        internal DWORD NumberOfKeysTotal;
    }

    #endregion

    #region RawInputMouseDeviceInfo

    /// \internal
    /// <summary>
    /// Defines the raw input data coming from the specified mouse.
    /// </summary>
    /// <remarks>
    /// For the keyboard, the Usage Page is 1 and the Usage is 2.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawInputMouseDeviceInfo
    {
        /// <summary>
        /// ID for the mouse device.
        /// </summary>
        internal DWORD Id;
        /// <summary>
        /// Number of buttons for the mouse.
        /// </summary>
        internal DWORD NumberOfButtons;
        /// <summary>
        /// Number of data points per second. This information may not be applicable for every mouse device.
        /// </summary>
        internal DWORD SampleRate;
        /// <summary>
        /// TRUE if the mouse has a wheel for horizontal scrolling; otherwise, FALSE.
        /// </summary>
        /// <remarks>
        /// This member is only supported under Microsoft Windows Vista and later versions.
        /// </remarks>
        internal BOOL HasHorizontalWheel;
    }

    #endregion

    #endregion

    #region GetWindowLongOffsets

    #endregion

    #region Rectangle

    /// \internal
    /// <summary>
    /// Defines the coordinates of the upper-left and lower-right corners of a rectangle.
    /// </summary>
    /// <remarks>
    /// By convention, the right and bottom edges of the rectangle are normally considered exclusive. In other words, the pixel whose coordinates are (right, bottom) lies immediately outside of the the rectangle. For example, when RECT is passed to the FillRect function, the rectangle is filled up to, but not including, the right column and bottom row of pixels. This structure is identical to the RECTL structure.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    internal struct Win32Rectangle
    {
        /// <summary>
        /// Specifies the x-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        internal LONG left;
        /// <summary>
        /// Specifies the y-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        internal LONG top;
        /// <summary>
        /// Specifies the x-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        internal LONG right;
        /// <summary>
        /// Specifies the y-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        internal LONG bottom;

        internal int Width { get { return right - left; } }
        internal int Height { get { return bottom - top; } }

        public override string ToString()
        {
            return String.Format("({0},{1})-({2},{3})", left, top, right, bottom);
        }

        internal Rectangle ToRectangle()
        {
            return Rectangle.FromLTRB(left, top, right, bottom);
        }

        internal static Win32Rectangle From(Rectangle value)
        {
            Win32Rectangle rect = new Win32Rectangle();
            rect.left = value.Left;
            rect.right = value.Right;
            rect.top = value.Top;
            rect.bottom = value.Bottom;
            return rect;
        }

        internal static Win32Rectangle From(Size value)
        {
            Win32Rectangle rect = new Win32Rectangle();
            rect.left = 0;
            rect.right = value.Width;
            rect.top = 0;
            rect.bottom = value.Height;
            return rect;
        }
    }

    #endregion

    #region WindowInfo

    /// \internal
    /// <summary>
    /// Contains window information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    struct WindowInfo
    {
        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public DWORD Size;
        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the window. 
        /// </summary>
        public RECT Window;
        /// <summary>
        /// Pointer to a RECT structure that specifies the coordinates of the client area. 
        /// </summary>
        public RECT Client;
        /// <summary>
        /// The window styles. For a table of window styles, see CreateWindowEx. 
        /// </summary>
        public WindowStyle Style;
        /// <summary>
        /// The extended window styles. For a table of extended window styles, see CreateWindowEx.
        /// </summary>
        public ExtendedWindowStyle ExStyle;
        /// <summary>
        /// The window status. If this member is WS_ACTIVECAPTION, the window is active. Otherwise, this member is zero.
        /// </summary>
        public DWORD WindowStatus;
        /// <summary>
        /// The width of the window border, in pixels. 
        /// </summary>
        public UINT WindowBordersX;
        /// <summary>
        /// The height of the window border, in pixels.
        /// </summary>
        public UINT WindowBordersY;
        /// <summary>
        /// The window class atom (see RegisterClass). 
        /// </summary>
        public ATOM WindowType;
        /// <summary>
        /// The Microsoft Windows version of the application that created the window. 
        /// </summary>
        public WORD CreatorVersion;
    }

    #endregion

    #region MonitorInfo

    struct MonitorInfo
    {
        public DWORD Size;
        public RECT Monitor;
        public RECT Work;
        public DWORD Flags;

        public static readonly int SizeInBytes = Marshal.SizeOf(default(MonitorInfo));
    }

    #endregion

    #region NcCalculateSize

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    internal struct NcCalculateSize
    {
        public Win32Rectangle NewBounds;
        public Win32Rectangle OldBounds;
        public Win32Rectangle OldClientRectangle;
        unsafe public WindowPosition* Position;
    }

    #endregion

    #region ShFileInfo

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    struct SHFILEINFO
    {
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    };

    #endregion

    #region TrackMouseEventStructure

    struct TrackMouseEventStructure
    {
        public DWORD Size;
        public TrackMouseEventFlags Flags;
        public HWND TrackWindowHandle;
        public DWORD HoverTime;

        public static readonly int SizeInBytes = Marshal.SizeOf(typeof(TrackMouseEventStructure));
    }

    #endregion

    #region BroadcastHeader

    struct BroadcastHeader
    {
        public DWORD Size;
        public DeviceBroadcastType DeviceType;
        DWORD dbch_reserved;
    }

    #endregion

    #region BroadcastDeviceInterface

    struct BroadcastDeviceInterface
    {
        public DWORD Size;
        public DeviceBroadcastType DeviceType;
        DWORD dbcc_reserved;
        public Guid ClassGuid;
        public char dbcc_name;
    }

    #endregion

    #region Registry

#if ANDROID || IPHONE || MINIMAL

    internal class RegistryKey
    {
        IntPtr hkey;

        internal RegistryKey(IntPtr hkey)
        {
            this.hkey = hkey;
        }

        internal string GetValue(string subkey)
        {
            int type;
            int data_size = 255;
            StringBuilder data = new StringBuilder(data_size);
            Functions.RegGetValue(hkey, subkey, "", 0xffff, out type, data, ref data_size);
            return data.ToString();
        }

        internal RegistryKey OpenSubKey(string subkey)
        {
            IntPtr result;
            Functions.RegOpenKeyEx(hkey, subkey, 0, 1, out result);
            return new RegistryKey(result);
        }
    }

    internal static class Registry
    {
        internal static readonly RegistryKey LocalMachine =
            new RegistryKey(Constants.HKEY_LOCAL_MACHINE);
    }

#endif

    #endregion

    #region MouseMovePoint

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
        public int Time;
        /// <summary>
        /// Additional information associated with this coordinate.
        /// </summary>
        public IntPtr ExtraInfo;

        /// <summary>
        /// Returns the size of a MouseMovePoint in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(default(MouseMovePoint));
    }

    #endregion

    #region IconInfo

    /// \internal
    /// <summary>
    /// Contains information about an icon or a cursor.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    struct IconInfo
    {
        /// <summary>
        /// Specifies whether this structure defines an icon or a cursor. A 
        /// value of TRUE specifies an icon; FALSE specifies a cursor
        /// </summary>
        public bool fIcon;

        /// <summary>
        /// The x-coordinate of a cursor's hot spot. If this structure defines 
        /// an icon, the hot spot is always in the center of the icon, and 
        /// this member is ignored.
        /// </summary>
        public Int32 xHotspot;

        /// <summary>
        /// The y-coordinate of a cursor's hot spot. If this structure defines 
        /// an icon, the hot spot is always in the center of the icon, and 
        /// this member is ignored.
        /// </summary>
        public Int32 yHotspot;

        /// <summary>
        /// The icon bitmask bitmap. If this structure defines a black and 
        /// white icon, this bitmask is formatted so that the upper half is 
        /// the icon AND bitmask and the lower half is the icon XOR bitmask. 
        /// Under this condition, the height should be an even multiple of 
        /// two. If this structure defines a color icon, this mask only 
        /// defines the AND bitmask of the icon.
        /// </summary>
        public IntPtr hbmMask;

        /// <summary>
        /// A handle to the icon color bitmap. This member can be optional if
        /// this structure defines a black and white icon. The AND bitmask of
        /// hbmMask is applied with the SRCAND flag to the destination; 
        /// subsequently, the color bitmap is applied (using XOR) to the 
        /// destination by using the SRCINVERT flag.
        /// </summary>
        public IntPtr hbmColor;
    }

    #endregion

    #endregion

    #region --- Enums ---

    #region GetWindowLongOffset

    /// <summary>
    /// Window field offsets for GetWindowLong() and GetWindowLongPtr().
    /// </summary>
    enum GWL
    {
        WNDPROC = (-4),
        HINSTANCE = (-6),
        HWNDPARENT = (-8),
        STYLE = (-16),
        EXSTYLE = (-20),
        USERDATA = (-21),
        ID = (-12),
    }

    #endregion

    #region SizeMessage

    internal enum SizeMessage
    {
        MAXHIDE = 4,
        MAXIMIZED = 2,
        MAXSHOW = 3,
        MINIMIZED = 1,
        RESTORED = 0
    }

    #endregion

    #region NcCalcSizeOptions

    internal enum NcCalcSizeOptions
    {
        ALIGNTOP = 0x10,
        ALIGNRIGHT = 0x80,
        ALIGNLEFT = 0x20,
        ALIGNBOTTOM = 0x40,
        HREDRAW = 0x100,
        VREDRAW = 0x200,
        REDRAW = (HREDRAW | VREDRAW),
        VALIDRECTS = 0x400
    }

    #endregion

    #region DeviceCaps

    enum DeviceCaps
    {
        LogPixelsX = 88,
        LogPixelsY = 90
    }

    #endregion

    #region internal enum DisplayModeSettingsEnum

    internal enum DisplayModeSettingsEnum
    {
        CurrentSettings = -1,
        RegistrySettings = -2
    }

    #endregion

    #region internal enum DisplayDeviceStateFlags

    [Flags]
    internal enum DisplayDeviceStateFlags
    {
        None              = 0x00000000,
        AttachedToDesktop = 0x00000001,
        MultiDriver       = 0x00000002,
        PrimaryDevice     = 0x00000004,
        MirroringDriver   = 0x00000008,
        VgaCompatible     = 0x00000010,
        Removable         = 0x00000020,
        ModesPruned       = 0x08000000,
        Remote            = 0x04000000,
        Disconnect        = 0x02000000,

        // Child device state
        Active            = 0x00000001,
        Attached          = 0x00000002,
    }

    #endregion

    #region internal enum ChangeDisplaySettingsEnum

    [Flags]
    internal enum ChangeDisplaySettingsEnum
    {
        // ChangeDisplaySettings types (found in winuser.h)
        UpdateRegistry = 0x00000001,
        Test = 0x00000002,
        Fullscreen = 0x00000004,
    }

    #endregion

    #region internal enum WindowStyle : uint

    [Flags]
    internal enum WindowStyle : uint
    {
        Overlapped = 0x00000000,
        Popup = 0x80000000,
        Child = 0x40000000,
        Minimize = 0x20000000,
        Visible = 0x10000000,
        Disabled = 0x08000000,
        ClipSiblings = 0x04000000,
        ClipChildren = 0x02000000,
        Maximize = 0x01000000,
        Caption = 0x00C00000,    // Border | DialogFrame
        Border = 0x00800000,
        DialogFrame = 0x00400000,
        VScroll = 0x00200000,
        HScreen = 0x00100000,
        SystemMenu = 0x00080000,
        ThickFrame = 0x00040000,
        Group = 0x00020000,
        TabStop = 0x00010000,

        MinimizeBox = 0x00020000,
        MaximizeBox = 0x00010000,

        Tiled = Overlapped,
        Iconic = Minimize,
        SizeBox = ThickFrame,
        TiledWindow = OverlappedWindow,

        // Common window styles:
        OverlappedWindow = Overlapped | Caption | SystemMenu | ThickFrame | MinimizeBox | MaximizeBox,
        PopupWindow = Popup | Border | SystemMenu,
        ChildWindow = Child
    }

    #endregion

    #region internal enum ExtendedWindowStyle : uint

    [Flags]
    internal enum ExtendedWindowStyle : uint
    {
        DialogModalFrame = 0x00000001,
        NoParentNotify = 0x00000004,
        Topmost = 0x00000008,
        AcceptFiles = 0x00000010,
        Transparent = 0x00000020,

        // #if(WINVER >= 0x0400)
        MdiChild = 0x00000040,
        ToolWindow = 0x00000080,
        WindowEdge = 0x00000100,
        ClientEdge = 0x00000200,
        ContextHelp = 0x00000400,
        // #endif

        // #if(WINVER >= 0x0400)
        Right = 0x00001000,
        Left = 0x00000000,
        RightToLeftReading = 0x00002000,
        LeftToRightReading = 0x00000000,
        LeftScrollbar = 0x00004000,
        RightScrollbar = 0x00000000,

        ControlParent = 0x00010000,
        StaticEdge = 0x00020000,
        ApplicationWindow = 0x00040000,

        OverlappedWindow = WindowEdge | ClientEdge,
        PaletteWindow = WindowEdge | ToolWindow | Topmost,
        // #endif

        // #if(_WIN32_WINNT >= 0x0500)
        Layered = 0x00080000,
        // #endif

        // #if(WINVER >= 0x0500)
        NoInheritLayout = 0x00100000, // Disable inheritence of mirroring by children
        RightToLeftLayout = 0x00400000, // Right to left mirroring
        // #endif /* WINVER >= 0x0500 */

        // #if(_WIN32_WINNT >= 0x0501)
        Composited = 0x02000000,
        // #endif /* _WIN32_WINNT >= 0x0501 */

        // #if(_WIN32_WINNT >= 0x0500)
        NoActivate = 0x08000000
        // #endif /* _WIN32_WINNT >= 0x0500 */
    }

    #endregion

    #region GetWindowLongOffsets enum

    internal enum GetWindowLongOffsets : int
    {
        WNDPROC       = (-4),
        HINSTANCE     = (-6),
        HWNDPARENT    = (-8),
        STYLE         = (-16),
        EXSTYLE       = (-20),
        USERDATA      = (-21),
        ID            = (-12),
    }

    #endregion

    #region PixelFormatDescriptorFlags enum
    [Flags]
    internal enum PixelFormatDescriptorFlags : int
    {
        // PixelFormatDescriptor flags
        DOUBLEBUFFER = 0x01,
        STEREO = 0x02,
        DRAW_TO_WINDOW = 0x04,
        DRAW_TO_BITMAP = 0x08,
        SUPPORT_GDI = 0x10,
        SUPPORT_OPENGL = 0x20,
        GENERIC_FORMAT = 0x40,
        NEED_PALETTE = 0x80,
        NEED_SYSTEM_PALETTE = 0x100,
        SWAP_EXCHANGE = 0x200,
        SWAP_COPY = 0x400,
        SWAP_LAYER_BUFFERS = 0x800,
        GENERIC_ACCELERATED = 0x1000,
        SUPPORT_DIRECTDRAW = 0x2000,
        SUPPORT_COMPOSITION = 0x8000,

        // PixelFormatDescriptor flags for use in ChoosePixelFormat only
        DEPTH_DONTCARE = unchecked((int)0x20000000),
        DOUBLEBUFFER_DONTCARE = unchecked((int)0x40000000),
        STEREO_DONTCARE = unchecked((int)0x80000000)
    }
    #endregion

    #region PixelType

    internal enum PixelType : byte
    {
        RGBA = 0,
        INDEXED = 1
    }

    #endregion

    #region WindowPlacementOptions enum

    internal enum WindowPlacementOptions
    {
        TOP = 0,
        BOTTOM = 1,
        TOPMOST = -1,
        NOTOPMOST = -2
    }

    #endregion

    #region ClassStyle enum
    [Flags]
    internal enum ClassStyle
    {
        //None            = 0x0000,
        VRedraw = 0x0001,
        HRedraw = 0x0002,
        DoubleClicks = 0x0008,
        OwnDC = 0x0020,
        ClassDC = 0x0040,
        ParentDC = 0x0080,
        NoClose = 0x0200,
        SaveBits = 0x0800,
        ByteAlignClient = 0x1000,
        ByteAlignWindow = 0x2000,
        GlobalClass = 0x4000,

        Ime = 0x00010000,

        // #if(_WIN32_WINNT >= 0x0501)
        DropShadow = 0x00020000
        // #endif /* _WIN32_WINNT >= 0x0501 */
    }
    #endregion

    #region RawInputDeviceFlags enum

    [Flags]
    internal enum RawInputDeviceFlags : int
    {
        /// <summary>
        /// If set, this removes the top level collection from the inclusion list.
        /// This tells the operating system to stop reading from a device which matches the top level collection.
        /// </summary>
        REMOVE          = 0x00000001,
        /// <summary>
        /// If set, this specifies the top level collections to exclude when reading a complete usage page.
        /// This flag only affects a TLC whose usage page is already specified with RawInputDeviceEnum.PAGEONLY. 
        /// </summary>
        EXCLUDE         = 0x00000010,
        /// <summary>
        /// If set, this specifies all devices whose top level collection is from the specified UsagePage.
        /// Note that usUsage must be zero. To exclude a particular top level collection, use EXCLUDE.
        /// </summary>
        PAGEONLY        = 0x00000020,
        /// <summary>
        /// If set, this prevents any devices specified by UsagePage or Usage from generating legacy messages.
        /// This is only for the mouse and keyboard. See RawInputDevice Remarks.
        /// </summary>
        NOLEGACY        = 0x00000030,
        /// <summary>
        /// If set, this enables the caller to receive the input even when the caller is not in the foreground.
        /// Note that Target must be specified in RawInputDevice.
        /// </summary>
        INPUTSINK       = 0x00000100,
        /// <summary>
        /// If set, the mouse button click does not activate the other window.
        /// </summary>
        CAPTUREMOUSE    = 0x00000200, // effective when mouse nolegacy is specified, otherwise it would be an error
        /// <summary>
        /// If set, the application-defined keyboard device hotkeys are not handled.
        /// However, the system hotkeys; for example, ALT+TAB and CTRL+ALT+DEL, are still handled.
        /// By default, all keyboard hotkeys are handled.
        /// NOHOTKEYS can be specified even if NOLEGACY is not specified and Target is NULL in RawInputDevice.
        /// </summary>
        NOHOTKEYS       = 0x00000200, // effective for keyboard.
        /// <summary>
        /// Microsoft Windows XP Service Pack 1 (SP1): If set, the application command keys are handled. APPKEYS can be specified only if NOLEGACY is specified for a keyboard device.
        /// </summary>
        APPKEYS         = 0x00000400, // effective for keyboard.
        /// <summary>
        /// If set, this enables the caller to receive input in the background only if the foreground application
        /// does not process it. In other words, if the foreground application is not registered for raw input,
        /// then the background application that is registered will receive the input.
        /// </summary>
        EXINPUTSINK     = 0x00001000,
        DEVNOTIFY       = 0x00002000,
        //EXMODEMASK      = 0x000000F0
    }

    #endregion

    #region GetRawInputDataEnum

    internal enum GetRawInputDataEnum
    {
        INPUT             = 0x10000003,
        HEADER            = 0x10000005
    }

    #endregion

    #region RawInputDeviceInfoEnum

    internal enum RawInputDeviceInfoEnum
    {
        PREPARSEDDATA    = 0x20000005,
        DEVICENAME       = 0x20000007,  // the return valus is the character length, not the byte size
        DEVICEINFO       = 0x2000000b
    }

    #endregion

    #region RawInputMouseState

    [Flags]
    internal enum RawInputMouseState : ushort
    {
        LEFT_BUTTON_DOWN = 0x0001,  // Left Button changed to down.
        LEFT_BUTTON_UP   = 0x0002,  // Left Button changed to up.
        RIGHT_BUTTON_DOWN   = 0x0004,  // Right Button changed to down.
        RIGHT_BUTTON_UP  = 0x0008,  // Right Button changed to up.
        MIDDLE_BUTTON_DOWN  = 0x0010,  // Middle Button changed to down.
        MIDDLE_BUTTON_UP = 0x0020,  // Middle Button changed to up.

        BUTTON_1_DOWN    = LEFT_BUTTON_DOWN,
        BUTTON_1_UP      = LEFT_BUTTON_UP,
        BUTTON_2_DOWN    = RIGHT_BUTTON_DOWN,
        BUTTON_2_UP      = RIGHT_BUTTON_UP,
        BUTTON_3_DOWN    = MIDDLE_BUTTON_DOWN,
        BUTTON_3_UP      = MIDDLE_BUTTON_UP,

        BUTTON_4_DOWN    = 0x0040,
        BUTTON_4_UP      = 0x0080,
        BUTTON_5_DOWN    = 0x0100,
        BUTTON_5_UP      = 0x0200,

        WHEEL            = 0x0400,
        HWHEEL            = 0x0800,
    }

    #endregion

    #region RawInputKeyboardDataFlags

    internal enum RawInputKeyboardDataFlags : short //: ushort
    {
        MAKE            = 0,
        BREAK           = 1,
        E0              = 2,
        E1              = 4,
        TERMSRV_SET_LED = 8,
        TERMSRV_SHADOW  = 0x10
    }

    #endregion

    #region RawInputDeviceType

    internal enum RawInputDeviceType : int
    {
        MOUSE    = 0,
        KEYBOARD = 1,
        HID      = 2
    }

    #endregion

    #region RawMouseFlags

    /// <summary>
    /// Mouse indicator flags (found in winuser.h).
    /// </summary>
    [Flags]
    internal enum RawMouseFlags : ushort
    {
        /// <summary>
        /// LastX/Y indicate relative motion.
        /// </summary>
        MOUSE_MOVE_RELATIVE = 0x00,
        /// <summary>
        /// LastX/Y indicate absolute motion.
        /// </summary>
        MOUSE_MOVE_ABSOLUTE = 0x01,
        /// <summary>
        /// The coordinates are mapped to the virtual desktop.
        /// </summary>
        MOUSE_VIRTUAL_DESKTOP = 0x02,
        /// <summary>
        /// Requery for mouse attributes.
        /// </summary>
        MOUSE_ATTRIBUTES_CHANGED = 0x04,
    }

    #endregion

    #region VirtualKeys

    internal enum VirtualKeys : short
    {
        /*
         * Virtual Key, Standard Set
         */
        LBUTTON      = 0x01,
        RBUTTON      = 0x02,
        CANCEL       = 0x03,
        MBUTTON      = 0x04,   /* NOT contiguous with L & RBUTTON */

        XBUTTON1     = 0x05,   /* NOT contiguous with L & RBUTTON */
        XBUTTON2     = 0x06,   /* NOT contiguous with L & RBUTTON */

        /*
         * 0x07 : unassigned
         */

        BACK         = 0x08,
        TAB          = 0x09,

        /*
         * 0x0A - 0x0B : reserved
         */

        CLEAR        = 0x0C,
        RETURN       = 0x0D,

        SHIFT        = 0x10,
        CONTROL      = 0x11,
        MENU         = 0x12,
        PAUSE        = 0x13,
        CAPITAL      = 0x14,

        KANA         = 0x15,
        HANGEUL      = 0x15,  /* old name - should be here for compatibility */
        HANGUL       = 0x15,
        JUNJA        = 0x17,
        FINAL        = 0x18,
        HANJA        = 0x19,
        KANJI        = 0x19,

        ESCAPE       = 0x1B,

        CONVERT      = 0x1C,
        NONCONVERT   = 0x1D,
        ACCEPT       = 0x1E,
        MODECHANGE   = 0x1F,
        
        SPACE        = 0x20,
        PRIOR        = 0x21,
        NEXT         = 0x22,
        END          = 0x23,
        HOME         = 0x24,
        LEFT         = 0x25,
        UP           = 0x26,
        RIGHT        = 0x27,
        DOWN         = 0x28,
        SELECT       = 0x29,
        PRINT        = 0x2A,
        EXECUTE      = 0x2B,
        SNAPSHOT     = 0x2C,
        INSERT       = 0x2D,
        DELETE       = 0x2E,
        HELP         = 0x2F,
        
        /*
         * 0 - 9 are the same as ASCII '0' - '9' (0x30 - 0x39)
         * 0x40 : unassigned
         * A - Z are the same as ASCII 'A' - 'Z' (0x41 - 0x5A)
         */

        LWIN         = 0x5B,
        RWIN         = 0x5C,
        APPS         = 0x5D,
        
        /*
         * 0x5E : reserved
         */

        SLEEP        = 0x5F,

        NUMPAD0      = 0x60,
        NUMPAD1      = 0x61,
        NUMPAD2      = 0x62,
        NUMPAD3      = 0x63,
        NUMPAD4      = 0x64,
        NUMPAD5      = 0x65,
        NUMPAD6      = 0x66,
        NUMPAD7      = 0x67,
        NUMPAD8      = 0x68,
        NUMPAD9      = 0x69,
        MULTIPLY     = 0x6A,
        ADD          = 0x6B,
        SEPARATOR    = 0x6C,
        SUBTRACT     = 0x6D,
        DECIMAL      = 0x6E,
        DIVIDE       = 0x6F,
        F1           = 0x70,
        F2           = 0x71,
        F3           = 0x72,
        F4           = 0x73,
        F5           = 0x74,
        F6           = 0x75,
        F7           = 0x76,
        F8           = 0x77,
        F9           = 0x78,
        F10          = 0x79,
        F11          = 0x7A,
        F12          = 0x7B,
        F13          = 0x7C,
        F14          = 0x7D,
        F15          = 0x7E,
        F16          = 0x7F,
        F17          = 0x80,
        F18          = 0x81,
        F19          = 0x82,
        F20          = 0x83,
        F21          = 0x84,
        F22          = 0x85,
        F23          = 0x86,
        F24          = 0x87,
        
        /*
         * 0x88 - 0x8F : unassigned
         */

        NUMLOCK      = 0x90,
        SCROLL       = 0x91,

        /*
         * NEC PC-9800 kbd definitions
         */
        OEM_NEC_EQUAL= 0x92,  // '=' key on numpad

        /*
         * Fujitsu/OASYS kbd definitions
         */
        OEM_FJ_JISHO = 0x92,  // 'Dictionary' key
        OEM_FJ_MASSHOU = 0x93,  // 'Unregister word' key
        OEM_FJ_TOUROKU = 0x94,  // 'Register word' key
        OEM_FJ_LOYA  = 0x95,  // 'Left OYAYUBI' key
        OEM_FJ_ROYA  = 0x96,  // 'Right OYAYUBI' key

        /*
         * 0x97 - 0x9F : unassigned
         */

        /*
         * L* & R* - left and right Alt, Ctrl and Shift virtual keys.
         * Used only as parameters to GetAsyncKeyState() and GetKeyState().
         * No other API or message will distinguish left and right keys in this way.
         */
        LSHIFT       = 0xA0,
        RSHIFT       = 0xA1,
        LCONTROL     = 0xA2,
        RCONTROL     = 0xA3,
        LMENU        = 0xA4,
        RMENU        = 0xA5,
        
        BROWSER_BACK      = 0xA6,
        BROWSER_FORWARD   = 0xA7,
        BROWSER_REFRESH   = 0xA8,
        BROWSER_STOP      = 0xA9,
        BROWSER_SEARCH    = 0xAA,
        BROWSER_FAVORITES = 0xAB,
        BROWSER_HOME      = 0xAC,
        
        VOLUME_MUTE       = 0xAD,
        VOLUME_DOWN       = 0xAE,
        VOLUME_UP         = 0xAF,
        MEDIA_NEXT_TRACK  = 0xB0,
        MEDIA_PREV_TRACK  = 0xB1,
        MEDIA_STOP        = 0xB2,
        MEDIA_PLAY_PAUSE  = 0xB3,
        LAUNCH_MAIL       = 0xB4,
        LAUNCH_MEDIA_SELECT = 0xB5,
        LAUNCH_APP1       = 0xB6,
        LAUNCH_APP2       = 0xB7,
    
        /*
         * 0xB8 - 0xB9 : reserved
         */

        OEM_1        = 0xBA,   // ';:' for US
        OEM_PLUS     = 0xBB,   // '+' any country
        OEM_COMMA    = 0xBC,   // ',' any country
        OEM_MINUS    = 0xBD,   // '-' any country
        OEM_PERIOD   = 0xBE,   // '.' any country
        OEM_2        = 0xBF,   // '/?' for US
        OEM_3        = 0xC0,   // '`~' for US

        /*
         * 0xC1 - 0xD7 : reserved
         */

        /*
         * 0xD8 - 0xDA : unassigned
         */

        OEM_4        = 0xDB,  //  '[{' for US
        OEM_5        = 0xDC,  //  '\|' for US
        OEM_6        = 0xDD,  //  ']}' for US
        OEM_7        = 0xDE,  //  ''"' for US
        OEM_8        = 0xDF,

        /*
         * 0xE0 : reserved
         */

        /*
         * Various extended or enhanced keyboards
         */
        OEM_AX       = 0xE1,  //  'AX' key on Japanese AX kbd
        OEM_102      = 0xE2,  //  "<>" or "\|" on RT 102-key kbd.
        ICO_HELP     = 0xE3,  //  Help key on ICO
        ICO_00       = 0xE4,  //  00 key on ICO

        PROCESSKEY   = 0xE5,

        ICO_CLEAR    = 0xE6,


        PACKET       = 0xE7,

        /*
         * 0xE8 : unassigned
         */

        /*
         * Nokia/Ericsson definitions
         */
        OEM_RESET    = 0xE9,
        OEM_JUMP     = 0xEA,
        OEM_PA1      = 0xEB,
        OEM_PA2      = 0xEC,
        OEM_PA3      = 0xED,
        OEM_WSCTRL   = 0xEE,
        OEM_CUSEL    = 0xEF,
        OEM_ATTN     = 0xF0,
        OEM_FINISH   = 0xF1,
        OEM_COPY     = 0xF2,
        OEM_AUTO     = 0xF3,
        OEM_ENLW     = 0xF4,
        OEM_BACKTAB  = 0xF5,

        ATTN         = 0xF6,
        CRSEL        = 0xF7,
        EXSEL        = 0xF8,
        EREOF        = 0xF9,
        PLAY         = 0xFA,
        ZOOM         = 0xFB,
        NONAME       = 0xFC,
        PA1          = 0xFD,
        OEM_CLEAR    = 0xFE,

        Last
    }

    #endregion

    #region MouseKeys

    /// <summary>
    /// Enumerates available mouse keys (suitable for use in WM_MOUSEMOVE messages).
    /// </summary>
    enum MouseKeys
    {
        // Summary:
        //     No mouse button was pressed.
        None = 0,
        //
        // Summary:
        //     The left mouse button was pressed.
        Left = 0x0001,
        //
        // Summary:
        //     The right mouse button was pressed.
        Right = 0x0002,
        //
        // Summary:
        //     The middle mouse button was pressed.
        Middle = 0x0010,
        //
        // Summary:
        //     The first XButton was pressed.
        XButton1 = 0x0020,
        //
        // Summary:
        //     The second XButton was pressed.
        XButton2 = 0x0040,
    }

    #endregion

    #region QueueStatusFlags

    /// \internal
    /// <summary>
    /// Queue status flags for GetQueueStatus() and MsgWaitForMultipleObjects()
    /// </summary>
    [Flags]
    internal enum QueueStatusFlags
    {
        /// <summary>
        /// A WM_KEYUP, WM_KEYDOWN, WM_SYSKEYUP, or WM_SYSKEYDOWN message is in the queue.
        /// </summary>
        KEY            = 0x0001,
        /// <summary>
        /// A WM_MOUSEMOVE message is in the queue.
        /// </summary>
        MOUSEMOVE      = 0x0002,
        /// <summary>
        /// A mouse-button message (WM_LBUTTONUP, WM_RBUTTONDOWN, and so on).
        /// </summary>
        MOUSEBUTTON    = 0x0004,
        /// <summary>
        /// A posted message (other than those listed here) is in the queue.
        /// </summary>
        POSTMESSAGE    = 0x0008,
        /// <summary>
        /// A WM_TIMER message is in the queue.
        /// </summary>
        TIMER          = 0x0010,
        /// <summary>
        /// A WM_PAINT message is in the queue.
        /// </summary>
        PAINT          = 0x0020,
        /// <summary>
        /// A message sent by another thread or application is in the queue.
        /// </summary>
        SENDMESSAGE    = 0x0040,
        /// <summary>
        /// A WM_HOTKEY message is in the queue.
        /// </summary>
        HOTKEY         = 0x0080,
        /// <summary>
        /// A posted message (other than those listed here) is in the queue.
        /// </summary>
        ALLPOSTMESSAGE = 0x0100,
        /// <summary>
        /// A raw input message is in the queue. For more information, see Raw Input.
        /// Windows XP and higher only.
        /// </summary>
        RAWINPUT       = 0x0400,
        /// <summary>
        /// A WM_MOUSEMOVE message or mouse-button message (WM_LBUTTONUP, WM_RBUTTONDOWN, and so on).
        /// </summary>
        MOUSE          = MOUSEMOVE | MOUSEBUTTON,
        /// <summary>
        /// An input message is in the queue. This is composed of KEY, MOUSE and RAWINPUT.
        /// Windows XP and higher only.
        /// </summary>
        INPUT          = MOUSE | KEY | RAWINPUT,
        /// <summary>
        /// An input message is in the queue. This is composed of QS_KEY and QS_MOUSE.
        /// Windows 2000 and earlier.
        /// </summary>
        INPUT_LEGACY   = MOUSE | KEY,
        /// <summary>
        /// An input, WM_TIMER, WM_PAINT, WM_HOTKEY, or posted message is in the queue.
        /// </summary>
        ALLEVENTS      = INPUT | POSTMESSAGE | TIMER | PAINT | HOTKEY,
        /// <summary>
        /// Any message is in the queue.
        /// </summary>
        ALLINPUT       = INPUT | POSTMESSAGE | TIMER | PAINT | HOTKEY | SENDMESSAGE
    }

    #endregion

    #region WindowMessage

    internal enum WindowMessage : int
    {
        NULL = 0x0000,
        CREATE = 0x0001,
        DESTROY = 0x0002,
        MOVE = 0x0003,
        SIZE = 0x0005,
        ACTIVATE = 0x0006,
        SETFOCUS = 0x0007,
        KILLFOCUS = 0x0008,
        //              internal const uint SETVISIBLE           = 0x0009;
        ENABLE = 0x000A,
        SETREDRAW = 0x000B,
        SETTEXT = 0x000C,
        GETTEXT = 0x000D,
        GETTEXTLENGTH = 0x000E,
        PAINT = 0x000F,
        CLOSE = 0x0010,
        QUERYENDSESSION = 0x0011,
        QUIT = 0x0012,
        QUERYOPEN = 0x0013,
        ERASEBKGND = 0x0014,
        SYSCOLORCHANGE = 0x0015,
        ENDSESSION = 0x0016,
        //              internal const uint SYSTEMERROR          = 0x0017;
        SHOWWINDOW = 0x0018,
        CTLCOLOR = 0x0019,
        WININICHANGE = 0x001A,
        SETTINGCHANGE = 0x001A,
        DEVMODECHANGE = 0x001B,
        ACTIVATEAPP = 0x001C,
        FONTCHANGE = 0x001D,
        TIMECHANGE = 0x001E,
        CANCELMODE = 0x001F,
        SETCURSOR = 0x0020,
        MOUSEACTIVATE = 0x0021,
        CHILDACTIVATE = 0x0022,
        QUEUESYNC = 0x0023,
        GETMINMAXINFO = 0x0024,
        PAINTICON = 0x0026,
        ICONERASEBKGND = 0x0027,
        NEXTDLGCTL = 0x0028,
        //              internal const uint ALTTABACTIVE         = 0x0029;
        SPOOLERSTATUS = 0x002A,
        DRAWITEM = 0x002B,
        MEASUREITEM = 0x002C,
        DELETEITEM = 0x002D,
        VKEYTOITEM = 0x002E,
        CHARTOITEM = 0x002F,
        SETFONT = 0x0030,
        GETFONT = 0x0031,
        SETHOTKEY = 0x0032,
        GETHOTKEY = 0x0033,
        //              internal const uint FILESYSCHANGE        = 0x0034;
        //              internal const uint ISACTIVEICON         = 0x0035;
        //              internal const uint QUERYPARKICON        = 0x0036;
        QUERYDRAGICON = 0x0037,
        COMPAREITEM = 0x0039,
        //              internal const uint TESTING              = 0x003a;
        //              internal const uint OTHERWINDOWCREATED = 0x003c;
        GETOBJECT = 0x003D,
        //                      internal const uint ACTIVATESHELLWINDOW        = 0x003e;
        COMPACTING = 0x0041,
        COMMNOTIFY = 0x0044,
        WINDOWPOSCHANGING = 0x0046,
        WINDOWPOSCHANGED = 0x0047,
        POWER = 0x0048,
        COPYDATA = 0x004A,
        CANCELJOURNAL = 0x004B,
        NOTIFY = 0x004E,
        INPUTLANGCHANGEREQUEST = 0x0050,
        INPUTLANGCHANGE = 0x0051,
        TCARD = 0x0052,
        HELP = 0x0053,
        USERCHANGED = 0x0054,
        NOTIFYFORMAT = 0x0055,
        CONTEXTMENU = 0x007B,
        STYLECHANGING = 0x007C,
        STYLECHANGED = 0x007D,
        DISPLAYCHANGE = 0x007E,
        GETICON = 0x007F,

        // Non-Client messages
        SETICON = 0x0080,
        NCCREATE = 0x0081,
        NCDESTROY = 0x0082,
        NCCALCSIZE = 0x0083,
        NCHITTEST = 0x0084,
        NCPAINT = 0x0085,
        NCACTIVATE = 0x0086,
        GETDLGCODE = 0x0087,
        SYNCPAINT = 0x0088,
        //              internal const uint SYNCTASK       = 0x0089;
        NCMOUSEMOVE = 0x00A0,
        NCLBUTTONDOWN = 0x00A1,
        NCLBUTTONUP = 0x00A2,
        NCLBUTTONDBLCLK = 0x00A3,
        NCRBUTTONDOWN = 0x00A4,
        NCRBUTTONUP = 0x00A5,
        NCRBUTTONDBLCLK = 0x00A6,
        NCMBUTTONDOWN = 0x00A7,
        NCMBUTTONUP = 0x00A8,
        NCMBUTTONDBLCLK = 0x00A9,
        /// <summary>
        /// Windows 2000 and higher only.
        /// </summary>
        NCXBUTTONDOWN    = 0x00ab,
        /// <summary>
        /// Windows 2000 and higher only.
        /// </summary>
        NCXBUTTONUP      = 0x00ac,
        /// <summary>
        /// Windows 2000 and higher only.
        /// </summary>
        NCXBUTTONDBLCLK  = 0x00ad,

        INPUT = 0x00FF,
        
        KEYDOWN = 0x0100,
        KEYFIRST = 0x0100,
        KEYUP = 0x0101,
        CHAR = 0x0102,
        DEADCHAR = 0x0103,
        SYSKEYDOWN = 0x0104,
        SYSKEYUP = 0x0105,
        SYSCHAR = 0x0106,
        SYSDEADCHAR = 0x0107,
        KEYLAST = 0x0108,
        IME_STARTCOMPOSITION = 0x010D,
        IME_ENDCOMPOSITION = 0x010E,
        IME_COMPOSITION = 0x010F,
        IME_KEYLAST = 0x010F,
        INITDIALOG = 0x0110,
        COMMAND = 0x0111,
        SYSCOMMAND = 0x0112,
        TIMER = 0x0113,
        HSCROLL = 0x0114,
        VSCROLL = 0x0115,
        INITMENU = 0x0116,
        INITMENUPOPUP = 0x0117,
        //              internal const uint SYSTIMER       = 0x0118;
        MENUSELECT = 0x011F,
        MENUCHAR = 0x0120,
        ENTERIDLE = 0x0121,
        MENURBUTTONUP = 0x0122,
        MENUDRAG = 0x0123,
        MENUGETOBJECT = 0x0124,
        UNINITMENUPOPUP = 0x0125,
        MENUCOMMAND = 0x0126,

        CHANGEUISTATE = 0x0127,
        UPDATEUISTATE = 0x0128,
        QUERYUISTATE = 0x0129,

        //              internal const uint LBTRACKPOINT     = 0x0131;
        CTLCOLORMSGBOX = 0x0132,
        CTLCOLOREDIT = 0x0133,
        CTLCOLORLISTBOX = 0x0134,
        CTLCOLORBTN = 0x0135,
        CTLCOLORDLG = 0x0136,
        CTLCOLORSCROLLBAR = 0x0137,
        CTLCOLORSTATIC = 0x0138,
        MOUSEMOVE = 0x0200,
        MOUSEFIRST = 0x0200,
        LBUTTONDOWN = 0x0201,
        LBUTTONUP = 0x0202,
        LBUTTONDBLCLK = 0x0203,
        RBUTTONDOWN = 0x0204,
        RBUTTONUP = 0x0205,
        RBUTTONDBLCLK = 0x0206,
        MBUTTONDOWN = 0x0207,
        MBUTTONUP = 0x0208,
        MBUTTONDBLCLK = 0x0209,
        MOUSEWHEEL = 0x020A,
        /// <summary>
        /// Windows 2000 and higher only.
        /// </summary>
        XBUTTONDOWN        = 0x020B,
        /// <summary>
        /// Windows 2000 and higher only.
        /// </summary>
        XBUTTONUP        = 0x020C,
        /// <summary>
        /// Windows 2000 and higher only.
        /// </summary>
        XBUTTONDBLCLK    = 0x020D,
        /// <summary>
        /// Windows Vista and higher only.
        /// </summary>
        MOUSEHWHEEL = 0x020E,
        PARENTNOTIFY = 0x0210,
        ENTERMENULOOP = 0x0211,
        EXITMENULOOP = 0x0212,
        NEXTMENU = 0x0213,
        SIZING = 0x0214,
        CAPTURECHANGED = 0x0215,
        MOVING = 0x0216,
        //              internal const uint POWERBROADCAST   = 0x0218;
        DEVICECHANGE = 0x0219,
        MDICREATE = 0x0220,
        MDIDESTROY = 0x0221,
        MDIACTIVATE = 0x0222,
        MDIRESTORE = 0x0223,
        MDINEXT = 0x0224,
        MDIMAXIMIZE = 0x0225,
        MDITILE = 0x0226,
        MDICASCADE = 0x0227,
        MDIICONARRANGE = 0x0228,
        MDIGETACTIVE = 0x0229,
        /* D&D messages */
        //              internal const uint DROPOBJECT     = 0x022A;
        //              internal const uint QUERYDROPOBJECT  = 0x022B;
        //              internal const uint BEGINDRAG      = 0x022C;
        //              internal const uint DRAGLOOP       = 0x022D;
        //              internal const uint DRAGSELECT     = 0x022E;
        //              internal const uint DRAGMOVE       = 0x022F;
        MDISETMENU = 0x0230,
        ENTERSIZEMOVE = 0x0231,
        EXITSIZEMOVE = 0x0232,
        DROPFILES = 0x0233,
        MDIREFRESHMENU = 0x0234,
        IME_SETCONTEXT = 0x0281,
        IME_NOTIFY = 0x0282,
        IME_CONTROL = 0x0283,
        IME_COMPOSITIONFULL = 0x0284,
        IME_SELECT = 0x0285,
        IME_CHAR = 0x0286,
        IME_REQUEST = 0x0288,
        IME_KEYDOWN = 0x0290,
        IME_KEYUP = 0x0291,
        NCMOUSEHOVER = 0x02A0,
        MOUSEHOVER = 0x02A1,
        NCMOUSELEAVE = 0x02A2,
        MOUSELEAVE = 0x02A3,
        CUT = 0x0300,
        COPY = 0x0301,
        PASTE = 0x0302,
        CLEAR = 0x0303,
        UNDO = 0x0304,
        RENDERFORMAT = 0x0305,
        RENDERALLFORMATS = 0x0306,
        DESTROYCLIPBOARD = 0x0307,
        DRAWCLIPBOARD = 0x0308,
        PAINTCLIPBOARD = 0x0309,
        VSCROLLCLIPBOARD = 0x030A,
        SIZECLIPBOARD = 0x030B,
        ASKCBFORMATNAME = 0x030C,
        CHANGECBCHAIN = 0x030D,
        HSCROLLCLIPBOARD = 0x030E,
        QUERYNEWPALETTE = 0x030F,
        PALETTEISCHANGING = 0x0310,
        PALETTECHANGED = 0x0311,
        HOTKEY = 0x0312,
        PRINT = 0x0317,
        PRINTCLIENT = 0x0318,
        HANDHELDFIRST = 0x0358,
        HANDHELDLAST = 0x035F,
        AFXFIRST = 0x0360,
        AFXLAST = 0x037F,
        PENWINFIRST = 0x0380,
        PENWINLAST = 0x038F,
        APP = 0x8000,
        USER = 0x0400,

        // Our "private" ones
        MOUSE_ENTER = 0x0401,
        ASYNC_MESSAGE = 0x0403,
        REFLECT = USER + 0x1c00,
        CLOSE_INTERNAL = USER + 0x1c01,

        // NotifyIcon (Systray) Balloon messages 
        BALLOONSHOW = USER + 0x0002,
        BALLOONHIDE = USER + 0x0003,
        BALLOONTIMEOUT = USER + 0x0004,
        BALLOONUSERCLICK = USER + 0x0005
    }        

    #endregion

    #region PeekMessageFlags

    [Flags]
    enum PeekMessageFlags : uint
    {
        NoRemove = 0,
        Remove = 1,
        NoYield = 2
    }

    #endregion

    #region ShowWindowCommand

    /// <summary>
    /// ShowWindow() Commands
    /// </summary>
    internal enum ShowWindowCommand
    {
        /// <summary>
        /// Hides the window and activates another window.
        /// </summary>
        HIDE            = 0,
        /// <summary>
        /// Activates and displays a window. If the window is minimized or maximized, the system restores it to its original size and position. An application should specify this flag when displaying the window for the first time.
        /// </summary>
        SHOWNORMAL      = 1,
        NORMAL          = 1,
        /// <summary>
        /// Activates the window and displays it as a minimized window.
        /// </summary>
        SHOWMINIMIZED   = 2,
        /// <summary>
        /// Activates the window and displays it as a maximized window.
        /// </summary>
        SHOWMAXIMIZED   = 3,
        MAXIMIZE        = 3,
        /// <summary>
        /// Displays the window as a minimized window. This value is similar to SW_SHOWMINIMIZED, except the window is not activated.
        /// </summary>
        SHOWNOACTIVATE  = 4,
        /// <summary>
        /// Activates the window and displays it in its current size and position.
        /// </summary>
        SHOW            = 5,
        /// <summary>
        /// Minimizes the specified window and activates the next top-level window in the Z order.
        /// </summary>
        MINIMIZE        = 6,
        /// <summary>
        /// Displays the window as a minimized window. This value is similar to SW_SHOWMINIMIZED, except the window is not activated.
        /// </summary>
        SHOWMINNOACTIVE = 7,
        /// <summary>
        /// Displays the window in its current size and position. This value is similar to SW_SHOW, except the window is not activated.
        /// </summary>
        SHOWNA          = 8,
        /// <summary>
        /// Activates and displays the window. If the window is minimized or maximized, the system restores it to its original size and position. An application should specify this flag when restoring a minimized window.
        /// </summary>
        RESTORE         = 9,
        /// <summary>
        /// Sets the show state based on the SW_ value specified in the STARTUPINFO structure passed to the CreateProcess function by the program that started the application.
        /// </summary>
        SHOWDEFAULT     = 10,
        /// <summary>
        /// Windows 2000/XP: Minimizes a window, even if the thread that owns the window is not responding. This flag should only be used when minimizing windows from a different thread.
        /// </summary>
        FORCEMINIMIZE   = 11,
        //MAX             = 11,

        // Old ShowWindow() Commands
        //HIDE_WINDOW        = 0,
        //SHOW_OPENWINDOW    = 1,
        //SHOW_ICONWINDOW    = 2,
        //SHOW_FULLSCREEN    = 3,
        //SHOW_OPENNOACTIVATE= 4,
    }

    #endregion

    #region ShowWindowMessageIdentifiers

    /// <summary>
    /// Identifiers for the WM_SHOWWINDOW message
    /// </summary>
    internal enum ShowWindowMessageIdentifiers
    {
        PARENTCLOSING = 1,
        OTHERZOOM = 2,
        PARENTOPENING = 3,
        OTHERUNZOOM = 4,
    }

    #endregion

    #region GDI charset

    /// <summary>
    /// Enumerates the available character sets.
    /// </summary>
    internal enum GdiCharset
    {
        Ansi = 0,
        Default = 1,
        Symbol = 2,
        ShiftJIS = 128,
        Hangeul = 129,
        Hangul = 129,
        GB2312 = 134,
        ChineseBig5 = 136,
        OEM = 255,
        //#if(WINVER >= 0x0400)
        Johab = 130,
        Hebrew = 177,
        Arabic = 178,
        Greek = 161,
        Turkish = 162,
        Vietnamese = 163,
        Thai = 222,
        EastEurope = 238,
        Russian = 204,
        Mac = 77,
        Baltic = 186,
    }

    #endregion

    #region MapVirtualKeyType

    internal enum MapVirtualKeyType
    {
        /// <summary>uCode is a virtual-key code and is translated into a scan code. If it is a virtual-key code that does not distinguish between left- and right-hand keys, the left-hand scan code is returned. If there is no translation, the function returns 0.</summary>
        VirtualKeyToScanCode = 0,
        /// <summary>uCode is a scan code and is translated into a virtual-key code that does not distinguish between left- and right-hand keys. If there is no translation, the function returns 0.</summary>
        ScanCodeToVirtualKey = 1,
        /// <summary>uCode is a virtual-key code and is translated into an unshifted character value in the low-order word of the return value. Dead keys (diacritics) are indicated by setting the top bit of the return value. If there is no translation, the function returns 0.</summary>
        VirtualKeyToCharacter = 2,
        /// <summary>Windows NT/2000/XP: uCode is a scan code and is translated into a virtual-key code that distinguishes between left- and right-hand keys. If there is no translation, the function returns 0.</summary>
        ScanCodeToVirtualKeyExtended = 3,
        VirtualKeyToScanCodeExtended = 4,
    }

    #endregion

    #region DwmWindowAttribute

    enum DwmWindowAttribute
    {
        NCRENDERING_ENABLED = 1,
        NCRENDERING_POLICY,
        TRANSITIONS_FORCEDISABLED,
        ALLOW_NCPAINT,
        CAPTION_BUTTON_BOUNDS,
        NONCLIENT_RTL_LAYOUT,
        FORCE_ICONIC_REPRESENTATION,
        FLIP3D_POLICY,
        EXTENDED_FRAME_BOUNDS,
        HAS_ICONIC_BITMAP,
        DISALLOW_PEEK,
        EXCLUDED_FROM_PEEK,
        LAST
    }

    #endregion

    #region ShGetFileIcon

    [Flags]
    enum ShGetFileIconFlags : int
    {
        /// <summary>get icon</summary>
        Icon = 0x000000100,
        /// <summary>get display name</summary>
        DisplayName = 0x000000200,
        /// <summary>get type name</summary>
        TypeName = 0x000000400,
        /// <summary>get attributes</summary>
        Attributes = 0x000000800,
        /// <summary>get icon location</summary>
        IconLocation = 0x000001000,
        /// <summary>return exe type</summary>
        ExeType = 0x000002000,
        /// <summary>get system icon index</summary>
        SysIconIndex = 0x000004000,
        /// <summary>put a link overlay on icon</summary>
        LinkOverlay = 0x000008000,
        /// <summary>show icon in selected state</summary>
        Selected = 0x000010000,
        /// <summary>get only specified attributes</summary>
        Attr_Specified = 0x000020000,
        /// <summary>get large icon</summary>
        LargeIcon = 0x000000000,
        /// <summary>get small icon</summary>
        SmallIcon = 0x000000001,
        /// <summary>get open icon</summary>
        OpenIcon = 0x000000002,
        /// <summary>get shell size icon</summary>
        ShellIconSize = 0x000000004,
        /// <summary>pszPath is a pidl</summary>
        PIDL = 0x000000008,
        /// <summary>use passed dwFileAttribute</summary>
        UseFileAttributes = 0x000000010,
        /// <summary>apply the appropriate overlays</summary>
        AddOverlays = 0x000000020,
        /// <summary>Get the index of the overlay in the upper 8 bits of the iIcon</summary>
        OverlayIndex = 0x000000040,
    }

    #endregion

    #region MonitorFrom

    enum MonitorFrom
    {
        Null = 0,
        Primary = 1,
        Nearest = 2,
    }

    #endregion

    #region CursorName

    enum CursorName : int
    {
        Arrow = 32512
    }

    #endregion

    #region TrackMouseEventFlags

    [Flags]
    enum TrackMouseEventFlags : uint
    {
        HOVER = 0x00000001,
        LEAVE = 0x00000002,
        NONCLIENT = 0x00000010,
        QUERY = 0x40000000,
        CANCEL = 0x80000000,
    }

    #endregion

    #region MouseActivate

    enum MouseActivate
    {
        ACTIVATE = 1,
        ACTIVATEANDEAT = 2,
        NOACTIVATE = 3,
        NOACTIVATEANDEAT = 4,
    }

    #endregion

    #region DeviceNotification

    enum DeviceNotification
    {
        WINDOW_HANDLE = 0x00000000,
        SERVICE_HANDLE = 0x00000001,
        ALL_INTERFACE_CLASSES = 0x00000004,
    }

    #endregion

    #region DeviceBroadcastType

    enum DeviceBroadcastType
    {
        OEM = 0,
        VOLUME = 2,
        PORT = 3,
        INTERFACE = 5,
        HANDLE = 6,
    }

    #endregion

    #endregion

    #region --- Callbacks ---

    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate IntPtr WindowProcedure(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam);

    #region Message

    [StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    internal struct MSG
    {
        internal IntPtr HWnd;
        internal WindowMessage Message;
        internal IntPtr WParam;
        internal IntPtr LParam;
        internal uint Time;
        internal POINT Point;
        //internal object RefObject;

        public override string ToString()
        {
            return String.Format("msg=0x{0:x} ({1}) hwnd=0x{2:x} wparam=0x{3:x} lparam=0x{4:x} pt=0x{5:x}", (int)Message, Message.ToString(), HWnd.ToInt32(), WParam.ToInt32(), LParam.ToInt32(), Point);
        }
    }

    #endregion

    #region Point

    [StructLayout(LayoutKind.Sequential)]
    internal struct POINT
    {
        internal int X;
        internal int Y;

        internal POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        internal Point ToPoint()
        {
            return new Point(X, Y);
        }

        public override string ToString()
        {
            return "Point {" + X.ToString() + ", " + Y.ToString() + ")";
        }
    }

    #endregion

    #endregion
}

#pragma warning restore 3019
#pragma warning restore 0649
#pragma warning restore 0169
#pragma warning restore 0414
