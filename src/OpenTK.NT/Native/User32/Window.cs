using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;

using BOOL = System.Boolean;
using HINSTANCE = System.IntPtr;
using HMENU = System.IntPtr;
using HWND = System.IntPtr;
using LONG = System.Int32;
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
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with windows.
        /// </summary>
        public static class Window
        {
            /// <summary>
            /// Calculates the required size of the window rectangle, based on the desired client-rectangle size.
            /// The window rectangle can then be passed to the CreateWindow function to create a window whose
            /// client area is the desired size.
            /// </summary>
            /// <param name="lpRect">
            /// A pointer to a <see cref="Rect"/> structure that contains the coordinates of the top-left and
            /// bottom-right corners of the desired client area. When the function returns, the structure contains 
            /// the coordinates of the top-left and bottom-right corners of the window to accommodate the desired
            /// client area.
            /// </param>
            /// <param name="dwStyle">
            /// The window style of the window whose required size is to be calculated.
            /// Note that you cannot specify the <see cref="WindowStyleFlags.Overlapped"/> style.
            /// </param>
            /// <param name="bMenu">Indicates whether the window has a menu.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL AdjustWindowRect
            (
                [In] [Out] ref Rect lpRect,
                [In] WindowStyleFlags dwStyle,
                [In] BOOL bMenu
            );

            /// <summary>
            /// Calculates the required size of the window rectangle, based on the desired client-rectangle size.
            /// The window rectangle can then be passed to the 
            /// <see cref="CreateWindowEx(ExtendedWindowStyleFlags, string, string, WindowStyleFlags, LONG, LONG, LONG,
            /// LONG, HINSTANCE, HINSTANCE, HINSTANCE, HINSTANCE)"/>
            /// function to create a window whose client area is the desired size.
            /// </summary>
            /// <param name="lpRect">
            /// A pointer to a <see cref="Rect"/> structure that contains the coordinates of the top-left and
            /// bottom-right corners of the desired client area. When the function returns, the structure contains
            /// the coordinates of the top-left and bottom-right corners of the window to accommodate the
            /// desired client area.
            /// </param>
            /// <param name="dwStyle">
            /// The window style of the window whose required size is to be calculated.
            /// Note that you cannot specify the <see cref="WindowStyleFlags.Overlapped"/> style.
            /// </param>
            /// <param name="bMenu">Indicates whether the window has a menu.</param>
            /// <param name="dwExStyle"
            /// >The extended window style of the window whose required size is to be calculated.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL AdjustWindowRectEx
            (
                [In] [Out] ref Rect lpRect,
                [In] WindowStyleFlags dwStyle,
                [In] BOOL bMenu,
                [In] ExtendedWindowStyleFlags dwExStyle
            );

            /// <summary>
            /// Creates an overlapped, pop-up, or child window with an extended window style; otherwise,
            /// this function is identical to the CreateWindow function.
            /// </summary>
            /// <param name="dwExStyle">The extended window style of the window being created.</param>
            /// <param name="lpClassName">A string specifying the window class name.</param>
            /// <param name="lpWindowName">
            /// The window name. If the window style specifies a title bar,
            /// the window title pointed to by <paramref name="lpWindowName"/> is displayed in the title bar.
            /// </param>
            /// <param name="dwStyle">The style of the window being created.</param>
            /// <param name="x">
            /// The initial horizontal position of the window. For an overlapped or pop-up window, the x parameter is
            /// the initial x-coordinate of the window's upper-left corner, in screen coordinates. For a child window,
            /// x is the x-coordinate of the upper-left corner of the window relative to the upper-left corner
            /// of the parent window's client area.<para/>
            /// If x is set to <see cref="int.MinValue"/>, the system selects the default position for the window's
            /// upper-left corner and ignores the y parameter. <see cref="int.MinValue"/> is valid only for overlapped
            /// windows; if it is specified for a pop-up or child window, the x and y parameters are set to zero.
            /// </param>
            /// <param name="y">
            /// The initial vertical position of the window. For an overlapped or pop-up window, the y parameter is
            /// the initial y-coordinate of the window's upper-left corner, in screen coordinates. For a child window,
            /// y is the initial y-coordinate of the upper-left corner of the child window relative to the upper-left
            /// corner of the parent window's client area. For a list box y is the initial y-coordinate of the
            /// upper-left corner of the list box's client area relative to the upper-left corner of the parent
            /// window's client area.<para/>
            /// If an overlapped window is created with the <see cref="WindowStyleFlags.Visible"/> style bit set and
            /// the x parameter is set to <see cref="int.MinValue"/>, then the y parameter determines how the window
            /// is shown. If the y parameter is <see cref="int.MinValue"/>, then the window manager calls
            /// <see cref="ShowWindow(HINSTANCE, ShowWindowCommand)"/> with the <see cref="ShowWindowCommand.Show"/>
            /// flag after the window has been created. If the y parameter is some other value, then the window manager
            /// calls <see cref="ShowWindow(HINSTANCE, ShowWindowCommand)"/> with that value as the nCmdShow parameter.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the new window.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern HWND CreateWindowEx
            (
                [In] ExtendedWindowStyleFlags dwExStyle,
                [In] [Optional] string lpClassName,
                [In] [Optional] string lpWindowName,
                [In] WindowStyleFlags dwStyle,
                [In] int x,
                [In] int y,
                [In] int nWidth,
                [In] int nHeight,
                [In] [Optional] HWND hWndParent,
                [In] [Optional] HMENU hMenu,
                [In] [Optional] HINSTANCE hInstance,
                [In] [Optional] LPVOID lpParam
            );

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern HWND CreateWindowEx
            (
                [In] ExtendedWindowStyleFlags dwExStyle,
                [In] [Optional] IntPtr lpClassName,
                [In] [Optional] string lpWindowName,
                [In] WindowStyleFlags dwStyle,
                [In] int x,
                [In] int y,
                [In] int nWidth,
                [In] int nHeight,
                [In] [Optional] HWND hWndParent,
                [In] [Optional] HMENU hMenu,
                [In] [Optional] HINSTANCE hInstance,
                [In] [Optional] LPVOID lpParam
            );

            public static HWND CreateWindowEx
            (
                [In] ExtendedWindowStyleFlags dwExStyle,
                [In] [Optional] ushort lpClassAtom,
                [In] [Optional] string lpWindowName,
                [In] WindowStyleFlags dwStyle,
                [In] int x,
                [In] int y,
                [In] int nWidth,
                [In] int nHeight,
                [In] [Optional] HWND hWndParent,
                [In] [Optional] HMENU hMenu,
                [In] [Optional] HINSTANCE hInstance,
                [In] [Optional] LPVOID lpParam
            )
            {
                return CreateWindowEx
                (
                    dwExStyle,
                    new IntPtr(lpClassAtom),
                    lpWindowName,
                    dwStyle,
                    x,
                    y,
                    nWidth,
                    nHeight,
                    hWndParent,
                    hMenu,
                    hInstance,
                    lpParam
                );
            }

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL DestroyWindow([In] HWND hWnd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern LRESULT CallWindowProc
            (
                [In] WNDPROC lpPrevWndFunc,
                [In] HWND hWnd,
                [In] WindowMessage Msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            /// <summary>
            /// Sets the current process as dots per inch (dpi) aware. Note: <see cref="SetProcessDPIAware"/> is
            /// subject to a possible race condition if a DLL caches dpi settings during initialization.
            /// For this reason, it is recommended that dpi-aware be set through the application (.exe) manifest
            /// rather than by calling <see cref="SetProcessDPIAware"/>.
            /// </summary>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// Otherwise, the return value is false.
            /// </returns>
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL SetProcessDPIAware();

            /// <summary>
            /// Changes the window procedure of the specified window.
            /// </summary>
            /// <param name="hWnd">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="newProc">The replacement window procedure.</param>
            /// <returns>
            /// If the function succeeds, the return value is the previous value
            /// of the specified 32-bit integer.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static LONG_PTR SetWindowLong(HWND hWnd, WindowProc newProc)
            {
                return SetWindowLong
                (
                    hWnd,
                    GetWindowLongIndex.WindowProcedure,
                    Marshal.GetFunctionPointerForDelegate(newProc)
                );
            }

            /// <summary>
            /// Changes an attribute of the specified window.
            /// The function also sets a value at the specified offset in the extra window memory. 
            /// </summary>
            /// <param name="hWnd">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="nIndex">
            /// One of the pre-defined values specifying the offset to the value to be set.
            /// </param>
            /// <param name="dwNewLong">The replacement value.</param>
            /// <returns>
            /// If the function succeeds, the return value is the previous value of the 
            /// specified 32-bit integer.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static LONG_PTR SetWindowLong(HWND hWnd, GetWindowLongIndex nIndex, LONG_PTR dwNewLong)
            {
                return SetWindowLong(hWnd, (int)nIndex, dwNewLong);
            }

            /// <summary>
            /// Changes an attribute of the specified window. The function also sets a value at the specified offset
            /// in the extra window memory. 
            /// </summary>
            /// <param name="hWnd">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="nIndex">
            /// The zero-based offset to the value to be set. Valid values are in the range zero through the number
            /// of bytes of extra window memory, minus the size of an <see cref="IntPtr"/>.
            /// </param>
            /// <param name="dwNewLong">The replacement value.</param>
            /// <returns>
            /// If the function succeeds, the return value is the previous value of the
            /// specified 32-bit integer.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            /// <remarks>
            /// This method is a wrapper around both the SetWindowLong (32-bit) and the SetWindowLongPtr (64-bit)
            /// version of these functions.<para/>
            /// This method will always call the "correct" function for this machine,
            /// and return the value wrapped in an <see cref="IntPtr"/>.
            /// This method will throw a <see cref="Win32Exception"/> if the Windows API function returns a value 
            /// that indicates failure.
            /// </remarks>
            /// <exception cref="Win32Exception"/>
            public static LONG_PTR SetWindowLong(HWND hWnd, int nIndex, LONG_PTR dwNewLong)
            {
                Kernel32.SetLastError(0);

                IntPtr result;
                if (IntPtr.Size == 8)
                {
                    result = SetWindowLongPtr(hWnd, nIndex, dwNewLong);
                }
                else
                {
                    result = new IntPtr(SetWindowLong(hWnd, nIndex, dwNewLong.ToInt32()));
                }

                int error;
                if (result == IntPtr.Zero && (error = Marshal.GetLastWin32Error()) != 0)
                {
                    throw new Win32Exception(error, "Failed to modify window border.");
                }

                return result;
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            private static extern int SetWindowLong
            (
                [In] HWND hWnd,
                [In] int nIndex,
                [In] LONG dwNewLong
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            private static extern LONG_PTR SetWindowLongPtr
            (
                [In] HWND hWnd,
                [In] int nIndex,
                [In] LONG_PTR dwNewLong
            );

            /// <summary>
            /// Retrieves information about the specified window. The function also retrieves the value at a
            /// specified offset into the extra window memory.
            /// </summary>
            /// <param name="hWnd">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="nIndex">
            /// One of the pre-defined values specifying the offset to the value to be retrieved.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is the requested value.<para/>
            /// If the function fails, the return value is zero. To get extended error information, call
            /// <see cref="Marshal.GetLastWin32Error"/>.<para/>
            /// If SetWindowLong or SetWindowLongPtr has not been called previously,
            /// GetWindowLongPtr returns zero for values in the extra window or class memory.
            /// </returns>
            /// <remarks>
            /// This method is a wrapper around both the GetWindowLong (32-bit) and the GetWindowLongPtr
            /// (64-bit) version of these functions.<para/>
            /// This method will always call the "correct" function for this machine, 
            /// and return the value wrapped in an <see cref="IntPtr"/>.
            /// </remarks>
            public static LONG_PTR GetWindowLong(HWND hWnd, GetWindowLongIndex nIndex)
            {
                return GetWindowLong(hWnd, (int)nIndex);
            }

            /// <summary>
            /// Retrieves information about the specified window. The function also retrieves the value at a specified
            /// offset into the extra window memory.
            /// </summary>
            /// <param name="hWnd">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="nIndex">
            /// The zero-based offset to the value to be retrieved. Valid values are in the range zero through the
            /// number of bytes of extra window memory, minus the size of a <see cref="IntPtr"/>.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is the requested value.<para/>
            /// If the function fails, the return value is zero. To get extended error information,
            /// call <see cref="Marshal.GetLastWin32Error"/>.<para/>
            /// If SetWindowLong or SetWindowLongPtr has not been called previously, GetWindowLongPtr returns zero for
            /// values in the extra window or class memory.
            /// </returns>
            /// <remarks>
            /// This method is a wrapper around both the GetWindowLong (32-bit) and the GetWindowLongPtr (64-bit)
            /// version of these functions.<para/>
            /// This method will always call the "correct" function for this machine,
            /// and return the value wrapped in an <see cref="IntPtr"/>.
            /// </remarks>
            public static LONG_PTR GetWindowLong(HWND hWnd, int nIndex)
            {
                if (IntPtr.Size == 8)
                {
                    return GetWindowLongPtr(hWnd, nIndex);
                }
                else
                {
                    return new IntPtr(GetWindowLongPrivate(hWnd, nIndex));
                }
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            private static extern LONG GetWindowLongPrivate([In] HWND hWnd, [In] int nIndex);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            private static extern LONG_PTR GetWindowLongPtr([In] HWND hWnd, [In] int nIndex);

            /// <summary>
            /// Calls the default window procedure to provide default processing for any window messages that an
            /// application does not process. This function ensures that every message is processed.
            /// </summary>
            /// <param name="hWnd">A handle to the window procedure that received the message.</param>
            /// <param name="Msg">The message.</param>
            /// <param name="wParam">
            /// Additional message information. The content of this parameter depends on the value of the
            /// <paramref name="Msg"/> parameter.
            /// </param>
            /// <param name="lParam">
            /// Additional message information. The content of this parameter depends on the value of the
            /// <paramref name="Msg"/> parameter.
            /// </param>
            /// <returns>The return value is the result of the message processing and depends on the message.</returns>
            [DllImport("User32.dll", CharSet = CharSet.Unicode)]
            public static extern LRESULT DefWindowProc
            (
                [In] HWND hWnd,
                [In] WindowMessage Msg,
                [In] WPARAM wParam,
                [In] LPARAM lParam
            );

            /// <summary>
            /// Sets the specified window's show state.
            /// </summary>
            /// <param name="hWnd">A handle to the window.</param>
            /// <param name="nCmdShow">Controls how the window is to be shown.</param>
            /// <returns>If the window was previously visible, the return value is true. Otherwise false.</returns>
            [DllImport("user32.dll", SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL ShowWindow([In] HWND hWnd, [In] ShowWindowCommand nCmdShow);

            /// <summary>
            /// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified
            /// window is a control, the text of the control is copied. However, 
            /// <see cref="GetWindowText(HINSTANCE, LPTSTR, LONG)"/> cannot retrieve the text of a control in another
            /// application.
            /// </summary>
            /// <param name="hWnd">A handle to the window or control containing the text.</param>
            /// <param name="lpString">
            /// The buffer that will receive the text. If the string is as long or longer than the buffer,
            /// the string is truncated and terminated with a null character.
            /// </param>
            /// <param name="nMaxCount">
            /// The maximum number of characters to copy to the buffer, including the null character.
            /// If the text exceeds this limit, it is truncated.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is the length, in characters, of the copied string, not
            /// including the terminating null character. If the window has no title bar or text, if the title bar
            /// is empty, or if the window or control handle is invalid, the return value is zero. To get extended
            /// error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern int GetWindowText
            (
                [In] HWND hWnd,
                [In] [Out] LPTSTR lpString,
                [In] int nMaxCount
            );

            /// <summary>
            /// Changes the text of the specified window's title bar (if it has one). If the specified window is a
            /// control, the text of the control is changed. However, <see cref="SetWindowText(HINSTANCE, string)"/>
            /// cannot change the text of a control in another application.
            /// </summary>
            /// <param name="hWnd">A handle to the window or control whose text is to be changed.</param>
            /// <param name="lpString">The new title or control text.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL SetWindowText
            (
                [In] HWND hWnd,
                [In] [Optional] string lpString
            );

            /// <summary>
            /// Changes the size, position, and Z order of a child, pop-up, or top-level window. These windows are
            /// ordered according to their appearance on the screen. The topmost window receives the highest rank
            /// and is the first window in the Z order.
            /// </summary>
            /// <param name="hWnd">A handle to the window.</param>
            /// <param name="hWndInsertAfter">
            /// A handle to the window to precede the positioned window in the Z order.
            /// This parameter must be a window handle.
            /// </param>
            /// <param name="x">The new position of the left side of the window, in client coordinates.</param>
            /// <param name="y">The new position of the top of the window, in client coordinates.</param>
            /// <param name="cx">The new width of the window, in pixels.</param>
            /// <param name="cy">The new height of the window, in pixels.</param>
            /// <param name="flags">The window sizing and positioning flags.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL SetWindowPos
            (
                [In] HWND hWnd,
                [In] [Optional] HWND hWndInsertAfter,
                [In] int x,
                [In] int y,
                [In] int cx,
                [In] int cy,
                [In] SetWindowPosFlags flags
            );

            /// <summary>
            /// Changes the size, position, and Z order of a child, pop-up, or top-level window.
            /// These windows are ordered according to their appearance on the screen. The topmost window receives
            /// the highest rank and is the first window in the Z order.
            /// </summary>
            /// <param name="hWnd">One of the pre-defined values for window Z order positioning.</param>
            /// <param name="hWndInsertAfter">
            /// A handle to the window to precede the positioned window in the Z order.
            /// This parameter must be a window handle.
            /// </param>
            /// <param name="x">The new position of the left side of the window, in client coordinates.</param>
            /// <param name="y">The new position of the top of the window, in client coordinates.</param>
            /// <param name="cx">The new width of the window, in pixels.</param>
            /// <param name="cy">The new height of the window, in pixels.</param>
            /// <param name="flags">The window sizing and positioning flags.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL SetWindowPos
            (
                [In] HWND hWnd,
                [In] [Optional] SetWindowPosHwndEnum hWndInsertAfter,
                [In] int x,
                [In] int y,
                [In] int cx,
                [In] int cy,
                [In] SetWindowPosFlags flags
            );

            /// <summary>
            /// Brings the thread that created the specified window into the foreground and activates the window.
            /// Keyboard input is directed to the window, and various visual cues are changed for the user.
            /// The system assigns a slightly higher priority to the thread that created the foreground window
            /// than it does to other threads.
            /// </summary>
            /// <param name="hWnd">
            /// A handle to the window that should be activated and brought to the foreground.
            /// </param>
            /// <returns>
            /// If the window was brought to the foreground, the return value is true.<para/>
            /// If the window was not brought to the foreground, the return value is false.
            /// </returns>
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL SetForegroundWindow([In] HWND hWnd);

            /// <summary>
            /// Brings the specified window to the top of the Z order. If the window is a top-level window, it is
            /// activated. If the window is a child window, the top-level parent window associated with the child
            /// window is activated.
            /// </summary>
            /// <param name="hWnd">A handle to the window to bring to the top of the Z order.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL BringWindowToTop([In] HWND hWnd);

            /// <summary>
            /// Changes the parent window of the specified child window.
            /// </summary>
            /// <param name="hWndChild">A handle to the child window.</param>
            /// <param name="newParent">
            /// A handle to the new parent window. If this parameter is
            /// <see cref="IntPtr.Zero"/>, the desktop window becomes the new parent window.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the previous parent window.<para/>
            /// If the function fails, the return value is null.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport("user32.dll", SetLastError = true)]
            public static extern HWND SetParent
            (
                [In] HWND hWndChild,
                [In] [Optional] HWND newParent
            );

            /// <summary>
            /// Retrieves information about the specified window.
            /// </summary>
            /// <param name="hwnd">A handle to the window whose information is to be retrieved.</param>
            /// <param name="wi">
            /// A pointer to a <see cref="WindowInfo"/> structure to receive the information.
            /// Note that you must set the <see cref="WindowInfo.Size"/> member to
            /// <see cref="WindowInfo.SizeInBytes"/> before calling this function.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL GetWindowInfo([In] HWND hwnd, [In] [Out] ref WindowInfo wi);

            /// <summary>
            /// Determines the visibility state of the specified window.
            /// </summary>
            /// <param name="hWNd">A handle to the window to be tested.</param>
            /// <returns>
            /// If the specified window, its parent window, its parent's parent window, and so forth, have the
            /// <see cref="WindowStyleFlags.Visible"/> style, the return value is true. Otherwise,
            /// the return value is false.<para/>
            /// Because the return value specifies whether the window has the <see cref="WindowStyleFlags.Visible"/>
            /// style, it may be true even if the window is totally obscured by other windows.
            /// </returns>
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL IsWindowVisible([In] HWND hWNd);

            /// <summary>
            /// Retrieves the dimensions of the bounding rectangle of the specified window. The dimensions are given
            /// in screen coordinates that are relative to the upper-left corner of the screen.
            /// </summary>
            /// <param name="windowHandle">Handle to the window whose client coordinates are to be retrieved.</param>
            /// <param name="windowRectangle">
            /// Pointer to a structure that receives the screen coordinates of the upper-left and
            /// lower-right corners of the window.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL GetWindowRect([In] HWND windowHandle, [Out] out Rect windowRectangle);

            /// <summary>
            /// Retrieves the coordinates of a window's client area. The client coordinates specify the upper-left
            /// and lower-right corners of the client area. Because client coordinates are relative to the upper-left
            /// corner of a window's client area, the coordinates of the upper-left corner are (0,0).
            /// </summary>
            /// <param name="windowHandle">Handle to the window whose client coordinates are to be retrieved.</param>
            /// <param name="clientRectangle">
            /// Pointer to a <see cref="Rect"/> structure that receives the client coordinates.
            /// The <see cref="Rect.Left"/> and <see cref="Rect.Top"/> members are zero. The <see cref="Rect.Right"/>
            /// and <see cref="Rect.Bottom"/> members contain the width and height of the window.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL GetClientRect([In] HWND windowHandle, [Out] out Rect clientRectangle);

            /// <summary>
            /// Converts the screen coordinates of a specified point on the screen to client-area coordinates.
            /// </summary>
            /// <param name="hWnd">Handle to the window whose client area will be used for the conversion.</param>
            /// <param name="lpPoint">
            /// Pointer to a <see cref="Point"/> structure that specifies the screen coordinates to be converted.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL ScreenToClient([In] HWND hWnd, ref Point lpPoint);

            /// <summary>
            /// Converts the client-area coordinates of a specified point to screen coordinates.
            /// </summary>
            /// <param name="hWnd">Handle to the window whose client area will be used for the conversion.</param>
            /// <param name="lpPoint">
            /// Pointer to a <see cref="Point"/> structure that contains the client coordinates to be converted.
            /// The new screen coordinates are copied into this structure if the function succeeds.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern BOOL ClientToScreen([In] HWND hWnd, [In] [Out] ref Point lpPoint);
        }
    }
}
