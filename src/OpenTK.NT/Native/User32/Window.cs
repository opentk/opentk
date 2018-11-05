using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenToolkit.NT.Native
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
            /// <param name="rect">
            /// A pointer to a <see cref="Rect"/> structure that contains the coordinates of the top-left and
            /// bottom-right corners of the desired client area. When the function returns, the structure contains
            /// the coordinates of the top-left and bottom-right corners of the window to accommodate the desired
            /// client area.
            /// </param>
            /// <param name="style">
            /// The window style of the window whose required size is to be calculated.
            /// Note that you cannot specify the <see cref="WindowStyles.Overlapped"/> style.
            /// </param>
            /// <param name="hasMenu">Indicates whether the window has a menu.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AdjustWindowRect
            (
                [In] [Out] ref Rect rect,
                [In] WindowStyles style,
                [In] bool hasMenu
            );

            /// <summary>
            /// Calculates the required size of the window rectangle, based on the desired client-rectangle size.
            /// The window rectangle can then be passed to the
            /// <see cref="CreateWindowEx(ExtendedWindowStyles, string, string, WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/>
            /// function to create a window whose client area is the desired size.
            /// </summary>
            /// <param name="rect">
            /// A pointer to a <see cref="Rect"/> structure that contains the coordinates of the top-left and
            /// bottom-right corners of the desired client area. When the function returns, the structure contains
            /// the coordinates of the top-left and bottom-right corners of the window to accommodate the
            /// desired client area.
            /// </param>
            /// <param name="style">
            /// The window style of the window whose required size is to be calculated.
            /// Note that you cannot specify the <see cref="WindowStyles.Overlapped"/> style.
            /// </param>
            /// <param name="hasMenu">Indicates whether the window has a menu.</param>
            /// <param name="extendedStyle">
            /// The extended window style of the window whose required size is to be calculated.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AdjustWindowRectEx
            (
                [In] [Out] ref Rect rect,
                [In] WindowStyles style,
                [In] bool hasMenu,
                [In] ExtendedWindowStyles extendedStyle
            );

            /// <summary>
            /// A constant that can be used in all CreateWindowEx overloads to specify special behavior.<para/>
            /// For more information, see any CreateWindowEx overload.
            /// </summary>
            public const int UseDefault = unchecked((int)0x80000000);

            /// <summary>
            /// Creates an overlapped, pop-up, or child window with an extended window style; otherwise,
            /// this function is identical to the CreateWindow function.
            /// </summary>
            /// <param name="extendedStyle">The extended window style of the window being created.</param>
            /// <param name="className">A string specifying the window class name.</param>
            /// <param name="windowName">
            /// The window name. If the window style specifies a title bar,
            /// the window title pointed to by <paramref name="windowName"/> is displayed in the title bar.
            /// </param>
            /// <param name="style">The style of the window being created.</param>
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
            /// If an overlapped window is created with the <see cref="WindowStyles.Visible"/> style bit set and
            /// the x parameter is set to <see cref="int.MinValue"/>, then the y parameter determines how the window
            /// is shown. If the y parameter is <see cref="int.MinValue"/>, then the window manager calls
            /// <see cref="ShowWindow(IntPtr, ShowWindowCommand)"/> with the <see cref="ShowWindowCommand.Show"/>
            /// flag after the window has been created. If the y parameter is some other value, then the window manager
            /// calls <see cref="ShowWindow(IntPtr, ShowWindowCommand)"/> with that value as the nCmdShow parameter.
            /// </param>
            /// <param name="width">
            /// The width, in device units, of the window. For overlapped windows, nWidth is the window's width, in
            /// screen coordinates, or <see cref="UseDefault"/>.<para/>
            /// If nWidth is <see cref="UseDefault"/>, the system selects a default width and height for the window;
            /// the default width extends from the initial x-coordinates to the right edge of the screen; the default
            /// height extends from the initial y-coordinate to the top of the icon area.<para/>
            /// <see cref="UseDefault"/> is valid only for overlapped windows; if <see cref="UseDefault"/> is
            /// specified for a pop-up or child window, the <paramref name="width"/> and <paramref name="height"/>
            /// parameter are set to zero.
            /// </param>
            /// <param name="height">
            /// The height, in device units, of the window. For overlapped windows, <paramref name="height"/> is the
            /// window's height, in screen coordinates.<para/>
            /// If the <paramref name="width"/> parameter is set to <see cref="UseDefault"/>,
            /// the system ignores <paramref name="height"/>.
            /// </param>
            /// <param name="parentWindow">
            /// A handle to the parent or owner window of the window being created. To create a child window or an
            /// owned window, supply a valid window handle. This parameter is optional for pop-up windows.<para/>
            /// </param>
            /// <param name="menu">
            /// A handle to a menu, or specifies a child-window identifier, depending on the window style.<para/>
            /// For an overlapped or pop-up window, <paramref name="menu"/> identifies the menu to be used with the
            /// window; it can be <see cref="IntPtr.Zero"/> if the class menu is to be used.<para/>
            /// For a child window, <paramref name="menu"/> specifies the child-window identifier, an integer value
            /// used by a dialog box control to notify its parent about events. The application determines the
            /// child-window identifier; it must be unique for all child windows with the same parent window.
            /// </param>
            /// <param name="moduleInstance">
            /// A handle to the instance of the module to be associated with the window.
            /// </param>
            /// <param name="createParam">
            /// Pointer to a value to be passed to the window through the <see cref="CreateStruct"/> structure
            /// (<see cref="CreateStruct.CreateParams"/> member) pointed to by the lParam param of the
            /// <see cref="WindowMessage.Create"/> message.<para/>
            /// This message is sent to the created window by this function before it returns.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the new window.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern IntPtr CreateWindowEx
            (
                [In] ExtendedWindowStyles extendedStyle,
                [In] [Optional] string className,
                [In] [Optional] string windowName,
                [In] WindowStyles style,
                [In] int x,
                [In] int y,
                [In] int width,
                [In] int height,
                [In] [Optional] IntPtr parentWindow,
                [In] [Optional] IntPtr menu,
                [In] [Optional] IntPtr moduleInstance,
                [In] [Optional] IntPtr createParam
            );

            /// <summary>
            /// Creates an overlapped, pop-up, or child window with an extended window style; otherwise,
            /// this function is identical to the CreateWindow function.
            /// </summary>
            /// <param name="extendedStyle">The extended window style of the window being created.</param>
            /// <param name="className">A pointer to a string specifying the window class name.</param>
            /// <param name="windowName">
            /// The window name. If the window style specifies a title bar,
            /// the window title pointed to by <paramref name="windowName"/> is displayed in the title bar.
            /// </param>
            /// <param name="style">The style of the window being created.</param>
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
            /// If an overlapped window is created with the <see cref="WindowStyles.Visible"/> style bit set and
            /// the x parameter is set to <see cref="int.MinValue"/>, then the y parameter determines how the window
            /// is shown. If the y parameter is <see cref="int.MinValue"/>, then the window manager calls
            /// <see cref="ShowWindow(IntPtr, ShowWindowCommand)"/> with the <see cref="ShowWindowCommand.Show"/>
            /// flag after the window has been created. If the y parameter is some other value, then the window manager
            /// calls <see cref="ShowWindow(IntPtr, ShowWindowCommand)"/> with that value as the nCmdShow parameter.
            /// </param>
            /// <param name="width">
            /// The width, in device units, of the window. For overlapped windows, nWidth is the window's width, in
            /// screen coordinates, or <see cref="UseDefault"/>.<para/>
            /// If nWidth is <see cref="UseDefault"/>, the system selects a default width and height for the window;
            /// the default width extends from the initial x-coordinates to the right edge of the screen; the default
            /// height extends from the initial y-coordinate to the top of the icon area.<para/>
            /// <see cref="UseDefault"/> is valid only for overlapped windows; if <see cref="UseDefault"/> is
            /// specified for a pop-up or child window, the <paramref name="width"/> and <paramref name="height"/>
            /// parameter are set to zero.
            /// </param>
            /// <param name="height">
            /// The height, in device units, of the window. For overlapped windows, <paramref name="height"/> is the
            /// window's height, in screen coordinates.<para/>
            /// If the <paramref name="width"/> parameter is set to <see cref="UseDefault"/>,
            /// the system ignores <paramref name="height"/>.
            /// </param>
            /// <param name="parentWindow">
            /// A handle to the parent or owner window of the window being created. To create a child window or an
            /// owned window, supply a valid window handle. This parameter is optional for pop-up windows.<para/>
            /// </param>
            /// <param name="menu">
            /// A handle to a menu, or specifies a child-window identifier, depending on the window style.<para/>
            /// For an overlapped or pop-up window, <paramref name="menu"/> identifies the menu to be used with the
            /// window; it can be <see cref="IntPtr.Zero"/> if the class menu is to be used.<para/>
            /// For a child window, <paramref name="menu"/> specifies the child-window identifier, an integer value
            /// used by a dialog box control to notify its parent about events. The application determines the
            /// child-window identifier; it must be unique for all child windows with the same parent window.
            /// </param>
            /// <param name="moduleInstance">
            /// A handle to the instance of the module to be associated with the window.
            /// </param>
            /// <param name="createParam">
            /// Pointer to a value to be passed to the window through the <see cref="CreateStruct"/> structure
            /// (<see cref="CreateStruct.CreateParams"/> member) pointed to by the lParam param of the
            /// <see cref="WindowMessage.Create"/> message.<para/>
            /// This message is sent to the created window by this function before it returns.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the new window.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern IntPtr CreateWindowEx
            (
                [In] ExtendedWindowStyles extendedStyle,
                [In] [Optional] IntPtr className,
                [In] [Optional] string windowName,
                [In] WindowStyles style,
                [In] int x,
                [In] int y,
                [In] int width,
                [In] int height,
                [In] [Optional] IntPtr parentWindow,
                [In] [Optional] IntPtr menu,
                [In] [Optional] IntPtr moduleInstance,
                [In] [Optional] IntPtr createParam
            );

            /// <summary>
            /// Creates an overlapped, pop-up, or child window with an extended window style; otherwise,
            /// this function is identical to the CreateWindow function.
            /// </summary>
            /// <param name="extendedStyle">The extended window style of the window being created.</param>
            /// <param name="classAtom">
            /// A class atom created by a previous call to RegisterClass or
            /// <see cref="WindowClass.RegisterClassEx(ref ExtendedWindowClass)"/>.
            /// </param>
            /// <param name="windowName">
            /// The window name. If the window style specifies a title bar,
            /// the window title pointed to by <paramref name="windowName"/> is displayed in the title bar.
            /// </param>
            /// <param name="style">The style of the window being created.</param>
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
            /// If an overlapped window is created with the <see cref="WindowStyles.Visible"/> style bit set and
            /// the x parameter is set to <see cref="int.MinValue"/>, then the y parameter determines how the window
            /// is shown. If the y parameter is <see cref="int.MinValue"/>, then the window manager calls
            /// <see cref="ShowWindow(IntPtr, ShowWindowCommand)"/> with the <see cref="ShowWindowCommand.Show"/>
            /// flag after the window has been created. If the y parameter is some other value, then the window manager
            /// calls <see cref="ShowWindow(IntPtr, ShowWindowCommand)"/> with that value as the nCmdShow parameter.
            /// </param>
            /// <param name="width">
            /// The width, in device units, of the window. For overlapped windows, nWidth is the window's width, in
            /// screen coordinates, or <see cref="UseDefault"/>.<para/>
            /// If nWidth is <see cref="UseDefault"/>, the system selects a default width and height for the window;
            /// the default width extends from the initial x-coordinates to the right edge of the screen; the default
            /// height extends from the initial y-coordinate to the top of the icon area.<para/>
            /// <see cref="UseDefault"/> is valid only for overlapped windows; if <see cref="UseDefault"/> is
            /// specified for a pop-up or child window, the <paramref name="width"/> and <paramref name="height"/>
            /// parameter are set to zero.
            /// </param>
            /// <param name="height">
            /// The height, in device units, of the window. For overlapped windows, <paramref name="height"/> is the
            /// window's height, in screen coordinates.<para/>
            /// If the <paramref name="width"/> parameter is set to <see cref="UseDefault"/>,
            /// the system ignores <paramref name="height"/>.
            /// </param>
            /// <param name="parentWindow">
            /// A handle to the parent or owner window of the window being created. To create a child window or an
            /// owned window, supply a valid window handle. This parameter is optional for pop-up windows.<para/>
            /// </param>
            /// <param name="menu">
            /// A handle to a menu, or specifies a child-window identifier, depending on the window style.<para/>
            /// For an overlapped or pop-up window, <paramref name="menu"/> identifies the menu to be used with the
            /// window; it can be <see cref="IntPtr.Zero"/> if the class menu is to be used.<para/>
            /// For a child window, <paramref name="menu"/> specifies the child-window identifier, an integer value
            /// used by a dialog box control to notify its parent about events. The application determines the
            /// child-window identifier; it must be unique for all child windows with the same parent window.
            /// </param>
            /// <param name="moduleInstance">
            /// A handle to the instance of the module to be associated with the window.
            /// </param>
            /// <param name="createParam">
            /// Pointer to a value to be passed to the window through the <see cref="CreateStruct"/> structure
            /// (<see cref="CreateStruct.CreateParams"/> member) pointed to by the lParam param of the
            /// <see cref="WindowMessage.Create"/> message.<para/>
            /// This message is sent to the created window by this function before it returns.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the new window.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static IntPtr CreateWindowEx
            (
                [In] ExtendedWindowStyles extendedStyle,
                [In] [Optional] ushort classAtom,
                [In] [Optional] string windowName,
                [In] WindowStyles style,
                [In] int x,
                [In] int y,
                [In] int width,
                [In] int height,
                [In] [Optional] IntPtr parentWindow,
                [In] [Optional] IntPtr menu,
                [In] [Optional] IntPtr moduleInstance,
                [In] [Optional] IntPtr createParam
            )
            {
                return CreateWindowEx
                (
                    extendedStyle,
                    new IntPtr(classAtom),
                    windowName,
                    style,
                    x,
                    y,
                    width,
                    height,
                    parentWindow,
                    menu,
                    moduleInstance,
                    createParam
                );
            }

            /// <summary>
            /// Destroys the specified window. The function sends <see cref="WindowMessage.Destroy"/>
            /// and <see cref="WindowMessage.NCDestroy"/> messages to the window to deactivate it and remove the
            /// keyboard focus from it. The function also destroys the window's menu, flushes the thread message queue,
            /// destroys timers, removes clipboard ownership, and breaks the clipboard viewer chain
            /// (if the window is at the top of the viewer chain).<para/>
            /// If the specified window is a parent or owner window, <see cref="DestroyWindow(IntPtr)"/> automatically
            /// destroys the associated child or owned windows when it destroys the parent or owner window. The
            /// function first destroys child or owned windows, and then it destroys the parent or owner window.
            /// </summary>
            /// <param name="window">A handle to the window to be destroyed.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DestroyWindow([In] IntPtr window);

            /// <summary>
            /// Passes message information to the specified window procedure.
            /// </summary>
            /// <param name="previousWindowFunc">
            /// The previous window procedure. If this value is obtained by calling the
            /// <see cref="GetWindowLong(IntPtr, GetWindowLongIndex)"/> function with the index parameter set to
            /// <see cref="GetWindowLongIndex.WindowProcedure"/> or DWL_DLGPROC, it is actually either the address of
            /// a window or dialog box procedure, or a special internal value meaningful only to
            /// <see cref="CallWindowProc(IntPtr, IntPtr, WindowMessage, IntPtr, IntPtr)"/>.
            /// </param>
            /// <param name="window">A handle to the window procedure to receive the message.</param>
            /// <param name="msg">The message.</param>
            /// <param name="wparam">
            /// Additional message-specific information.
            /// The contents of this parameter depend on the value of the <paramref name="msg"/> parameter.
            /// </param>
            /// <param name="lparam">
            /// Additional message-specific information.
            /// The contents of this parameter depend on the value of the <paramref name="msg"/> parameter.
            /// </param>
            /// <returns>
            /// The return value specifies the result of the message processing and depends on the message sent.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            public static extern IntPtr CallWindowProc
            (
                [In] IntPtr previousWindowFunc,
                [In] IntPtr window,
                [In] WindowMessage msg,
                [In] IntPtr wparam,
                [In] IntPtr lparam
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
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetProcessDPIAware();

            /// <summary>
            /// Changes the window procedure of the specified window.
            /// </summary>
            /// <param name="window">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="newProc">The replacement window procedure.</param>
            /// <returns>
            /// If the function succeeds, the return value is the previous value
            /// of the specified 32-bit integer.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static IntPtr SetWindowLong(IntPtr window, WindowProc newProc)
            {
                return SetWindowLong
                (
                    window,
                    GetWindowLongIndex.WindowProcedure,
                    Marshal.GetFunctionPointerForDelegate(newProc)
                );
            }

            /// <summary>
            /// Changes an attribute of the specified window.
            /// The function also sets a value at the specified offset in the extra window memory.
            /// </summary>
            /// <param name="window">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="index">
            /// One of the pre-defined values specifying the offset to the value to be set.
            /// </param>
            /// <param name="newLong">The replacement value.</param>
            /// <returns>
            /// If the function succeeds, the return value is the previous value of the
            /// specified 32-bit integer.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            public static IntPtr SetWindowLong(IntPtr window, GetWindowLongIndex index, IntPtr newLong)
            {
                return SetWindowLong(window, (int)index, newLong);
            }

            /// <summary>
            /// Changes an attribute of the specified window. The function also sets a value at the specified offset
            /// in the extra window memory.
            /// </summary>
            /// <param name="window">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="index">
            /// The zero-based offset to the value to be set. Valid values are in the range zero through the number
            /// of bytes of extra window memory, minus the size of an <see cref="IntPtr"/>.
            /// </param>
            /// <param name="newLong">The replacement value.</param>
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
            /// <exception cref="Win32Exception">An error occurs in the native function call.</exception>
            public static IntPtr SetWindowLong(IntPtr window, int index, IntPtr newLong)
            {
                Kernel32.SetLastError(0);

                IntPtr result;
                if (IntPtr.Size == 8)
                {
                    result = SetWindowLongPtr(window, index, newLong);
                }
                else
                {
                    result = new IntPtr(SetWindowLong(window, index, newLong.ToInt32()));
                }

                int error;
                if (result == IntPtr.Zero && (error = Marshal.GetLastWin32Error()) != 0)
                {
                    throw new Win32Exception(error, "Failed to modify window border.");
                }

                return result;
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            private static extern int SetWindowLong
            (
                [In] IntPtr window,
                [In] int index,
                [In] int newLong
            );

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            private static extern IntPtr SetWindowLongPtr
            (
                [In] IntPtr window,
                [In] int index,
                [In] IntPtr newLong
            );

            /// <summary>
            /// Retrieves information about the specified window. The function also retrieves the value at a
            /// specified offset into the extra window memory.
            /// </summary>
            /// <param name="window">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="index">
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
            public static IntPtr GetWindowLong(IntPtr window, GetWindowLongIndex index)
            {
                return GetWindowLong(window, (int)index);
            }

            /// <summary>
            /// Retrieves information about the specified window. The function also retrieves the value at a specified
            /// offset into the extra window memory.
            /// </summary>
            /// <param name="window">
            /// A handle to the window and, indirectly, the class to which the window belongs.
            /// </param>
            /// <param name="index">
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
            public static IntPtr GetWindowLong(IntPtr window, int index)
            {
                if (IntPtr.Size == 8)
                {
                    return GetWindowLongPtr(window, index);
                }
                else
                {
                    return new IntPtr(GetWindowLongPrivate(window, index));
                }
            }

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            private static extern int GetWindowLongPrivate([In] IntPtr window, [In] int index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            private static extern IntPtr GetWindowLongPtr([In] IntPtr window, [In] int index);

            /// <summary>
            /// Calls the default window procedure to provide default processing for any window messages that an
            /// application does not process. This function ensures that every message is processed.
            /// </summary>
            /// <param name="window">A handle to the window procedure that received the message.</param>
            /// <param name="msg">The message.</param>
            /// <param name="wparam">
            /// Additional message information. The content of this parameter depends on the value of the
            /// <paramref name="msg"/> parameter.
            /// </param>
            /// <param name="lparam">
            /// Additional message information. The content of this parameter depends on the value of the
            /// <paramref name="msg"/> parameter.
            /// </param>
            /// <returns>The return value is the result of the message processing and depends on the message.</returns>
            [DllImport(Library, CharSet = CharSet.Unicode)]
            public static extern IntPtr DefWindowProc
            (
                [In] IntPtr window,
                [In] WindowMessage msg,
                [In] IntPtr wparam,
                [In] IntPtr lparam
            );

            /// <summary>
            /// Sets the specified window's show state.
            /// </summary>
            /// <param name="window">A handle to the window.</param>
            /// <param name="showCommand">Controls how the window is to be shown.</param>
            /// <returns>If the window was previously visible, the return value is true. Otherwise false.</returns>
            [DllImport(Library, SetLastError = true)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ShowWindow([In] IntPtr window, [In] ShowWindowCommand showCommand);

            /// <summary>
            /// Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified
            /// window is a control, the text of the control is copied. However,
            /// <see cref="GetWindowText(IntPtr, StringBuilder, int)"/> cannot retrieve the text of a control in another
            /// application.
            /// </summary>
            /// <param name="window">A handle to the window or control containing the text.</param>
            /// <param name="windowText">
            /// The buffer that will receive the text. If the string is as long or longer than the buffer,
            /// the string is truncated and terminated with a null character.
            /// </param>
            /// <param name="maxCharCount">
            /// The maximum number of characters to copy to the buffer, including the null character.
            /// If the text exceeds this limit, it is truncated.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is the length, in characters, of the copied string, not
            /// including the terminating null character. If the window has no title bar or text, if the title bar
            /// is empty, or if the window or control handle is invalid, the return value is zero. To get extended
            /// error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern int GetWindowText
            (
                [In] IntPtr window,
                [In] [Out] StringBuilder windowText,
                [In] int maxCharCount
            );

            /// <summary>
            /// Changes the text of the specified window's title bar (if it has one). If the specified window is a
            /// control, the text of the control is changed. However, <see cref="SetWindowText(IntPtr, string)"/>
            /// cannot change the text of a control in another application.
            /// </summary>
            /// <param name="window">A handle to the window or control whose text is to be changed.</param>
            /// <param name="newText">The new title or control text.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.<para/>
            /// If the function fails, the return value is zero.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetWindowText
            (
                [In] IntPtr window,
                [In] [Optional] string newText
            );

            /// <summary>
            /// Changes the size, position, and Z order of a child, pop-up, or top-level window. These windows are
            /// ordered according to their appearance on the screen. The topmost window receives the highest rank
            /// and is the first window in the Z order.
            /// </summary>
            /// <param name="window">A handle to the window.</param>
            /// <param name="windowInsertAfter">
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
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetWindowPos
            (
                [In] IntPtr window,
                [In] [Optional] IntPtr windowInsertAfter,
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
            /// <param name="window">One of the pre-defined values for window Z order positioning.</param>
            /// <param name="windowInsertAfter">
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
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetWindowPos
            (
                [In] IntPtr window,
                [In] [Optional] SetWindowPosHwndEnum windowInsertAfter,
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
            /// <param name="window">
            /// A handle to the window that should be activated and brought to the foreground.
            /// </param>
            /// <returns>
            /// If the window was brought to the foreground, the return value is true.<para/>
            /// If the window was not brought to the foreground, the return value is false.
            /// </returns>
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetForegroundWindow([In] IntPtr window);

            /// <summary>
            /// Brings the specified window to the top of the Z order. If the window is a top-level window, it is
            /// activated. If the window is a child window, the top-level parent window associated with the child
            /// window is activated.
            /// </summary>
            /// <param name="window">A handle to the window to bring to the top of the Z order.</param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool BringWindowToTop([In] IntPtr window);

            /// <summary>
            /// Changes the parent window of the specified child window.
            /// </summary>
            /// <param name="childWindow">A handle to the child window.</param>
            /// <param name="newParent">
            /// A handle to the new parent window. If this parameter is
            /// <see cref="IntPtr.Zero"/>, the desktop window becomes the new parent window.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle to the previous parent window.<para/>
            /// If the function fails, the return value is null.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern IntPtr SetParent
            (
                [In] IntPtr childWindow,
                [In] [Optional] IntPtr newParent
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
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowInfo([In] IntPtr hwnd, [In] [Out] ref WindowInfo wi);

            /// <summary>
            /// Determines the visibility state of the specified window.
            /// </summary>
            /// <param name="window">A handle to the window to be tested.</param>
            /// <returns>
            /// If the specified window, its parent window, its parent's parent window, and so forth, have the
            /// <see cref="WindowStyles.Visible"/> style, the return value is true. Otherwise,
            /// the return value is false.<para/>
            /// Because the return value specifies whether the window has the <see cref="WindowStyles.Visible"/>
            /// style, it may be true even if the window is totally obscured by other windows.
            /// </returns>
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool IsWindowVisible([In] IntPtr window);

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
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowRect([In] IntPtr windowHandle, [Out] out Rect windowRectangle);

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
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetClientRect([In] IntPtr windowHandle, [Out] out Rect clientRectangle);

            /// <summary>
            /// Converts the screen coordinates of a specified point on the screen to client-area coordinates.
            /// </summary>
            /// <param name="window">Handle to the window whose client area will be used for the conversion.</param>
            /// <param name="point">
            /// Pointer to a <see cref="Point"/> structure that specifies the screen coordinates to be converted.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ScreenToClient([In] IntPtr window, ref Point point);

            /// <summary>
            /// Converts the client-area coordinates of a specified point to screen coordinates.
            /// </summary>
            /// <param name="window">Handle to the window whose client area will be used for the conversion.</param>
            /// <param name="point">
            /// Pointer to a <see cref="Point"/> structure that contains the client coordinates to be converted.
            /// The new screen coordinates are copied into this structure if the function succeeds.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// </returns>
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ClientToScreen([In] IntPtr window, [In] [Out] ref Point point);
        }
    }
}
