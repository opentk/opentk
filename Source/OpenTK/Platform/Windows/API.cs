#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Runtime.InteropServices;
using System.Text;

#endregion

/* TODO: Update the description of TimeBeginPeriod and other native methods. Update Timer. */

namespace OpenTK.Platform.Windows
{
    #region Type aliases

    using HWND = System.IntPtr;
    using HINSTANCE = System.IntPtr;
    using HMENU = System.IntPtr;

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
    using DWORD = System.Int32;
    using BOOL = System.Boolean;
    using INT = System.Int32;
    using UINT = System.UInt32;


    #endregion

    /// <summary>
    /// For internal use by OpenTK only!
    /// Exposes useful native WINAPI methods and structures.
    /// </summary>
    internal static class API
    {
        // Prevent BeforeFieldInit optimization, and initialize 'size' fields.
        static API()
        {
            RawInputHeaderSize = (uint)Marshal.SizeOf(typeof(RawInputHeader));
            RawInputSize = (uint)Marshal.SizeOf(typeof(RawInput));
            RawInputDeviceSize = (uint)Marshal.SizeOf(typeof(RawInputDevice));
        }

        #region Constants

        internal struct Constants
        {
            // Mouse indicator flags (found in winuser.h)
            internal const int MOUSE_MOVE_RELATIVE = 0;
            internal const int MOUSE_MOVE_ABSOLUTE = 1;
            internal const int MOUSE_VIRTUAL_DESKTOP = 0x02;  // the coordinates are mapped to the virtual desktop
            internal const int MOUSE_ATTRIBUTES_CHANGED = 0x04;  // requery for mouse attributes

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
            internal const int DM_BITSPERPEL = 0x00040000;
            internal const int DM_PELSWIDTH = 0x00080000;
            internal const int DM_PELSHEIGHT = 0x00100000;
            internal const int DM_DISPLAYFLAGS = 0x00200000;
            internal const int DM_DISPLAYFREQUENCY = 0x00400000;

            // ChangeDisplaySettings types (found in winuser.h)
            internal const int CDS_UPDATEREGISTRY = 0x00000001;
            internal const int CDS_TEST = 0x00000002;
            internal const int CDS_FULLSCREEN = 0x00000004;

            // ChangeDisplaySettings results (found in winuser.h)
            internal const int DISP_CHANGE_SUCCESSFUL = 0;
            internal const int DISP_CHANGE_RESTART = 1;
            internal const int DISP_CHANGE_FAILED = -1;

            // (found in winuser.h)
            internal const int ENUM_REGISTRY_SETTINGS = -2;
            internal const int ENUM_CURRENT_SETTINGS = -1;

            public const int VK_ESCAPE = 0x1B;
        }

        #endregion

        #region --- Functions ---

        #region Message handling

        #region PeekMessage

        [StructLayout(LayoutKind.Sequential)]
        internal struct Message
        {
            internal IntPtr hWnd;
            internal int msg;
            internal IntPtr wParam;
            internal IntPtr lParam;
            internal int time;
            internal System.Drawing.Point p;
            //System.Drawing.
        }

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
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PeekMessage(
            out Message msg,
            IntPtr hWnd,
            int messageFilterMin,
            int messageFilterMax,
            int flags
        );

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
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PeekMessage(
            out System.Windows.Forms.Message msg,
            IntPtr hWnd,
            int messageFilterMin,
            int messageFilterMax,
            int flags
        );

        #endregion

        #region GetMessage

        /// <summary>
        /// Low-level WINAPI function that retriives the next message in the queue.
        /// </summary>
        /// <param name="msg">The pending message (if any) is stored here.</param>
        /// <param name="hWnd">Not used</param>
        /// <param name="messageFilterMin">Not used</param>
        /// <param name="messageFilterMax">Not used</param>
        /// <param name="flags">Not used</param>
        /// <returns>
        /// Nonzero indicates that the function retrieves a message other than WM_QUIT.
        /// Zero indicates that the function retrieves the WM_QUIT message, or that lpMsg is an invalid pointer.
        /// –1 indicates that an error occurred — for example, the function fails if hWnd is an invalid window handle.
        /// To get extended error information, call GetLastError.
        /// </returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL GetMessage(
            out System.Windows.Forms.Message msg,
            IntPtr windowHandle,
            int messageFilterMin,
            int messageFilterMax
        );

        #endregion

        #region PostMessage

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern BOOL PostMessage(
            HWND hWnd,
            UINT Msg,
            WPARAM wParam,
            LPARAM lParam
        );

        #endregion

        #region PostQuitMessage

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        internal static extern void PostQuitMessage(int exitCode);

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

        #region ReleaseDC

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="hDC"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ReleaseDC(IntPtr hwnd, IntPtr DC);

        #endregion

        #region ChoosePixelFormat

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="pfd"></param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        internal static extern int ChoosePixelFormat(IntPtr dc, [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor pfd);

        #endregion

        #region SetPixelFormat

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="format"></param>
        /// <param name="pfd"></param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetPixelFormat(
            IntPtr dc,
            int format,
            [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor pfd
        );


        #endregion

        #region SwapBuffers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SwapBuffers(IntPtr dc);

        #endregion

        #region GetProcAddress

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="funcname"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetProcAddress(IntPtr handle, string funcname);

        #endregion

        #endregion

        #region DLL handling

        #region GetModuleHandle

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPTStr)]string module_name);

        #endregion

        #region LoadLibrary

        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcname"></param>
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

        #region Window Creation

        #region SetWindowPos

        // WINUSERAPI BOOL WINAPI SetWindowPos(__in HWND hWnd, __in_opt HWND hWndInsertAfter,
        //                                     __in int X, __in int Y, __in int cx, __in int cy, __in UINT uFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetWindowPos(
            IntPtr handle,
            WindowPlacementOptions placement,
            int x, int y, int cx, int cy,
            SetWindowPosFlags flags
        );

        #endregion

        #region CreateWindowEx

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateWindowEx(
            [In]ExtendedWindowStyle ExStyle,
            [In]string className,
            [In]string windowName,
            [In]WindowStyle Style,
            [In]int X, int Y,
            [In]int Width, int Height,
            [In]IntPtr HandleToParentWindow,
            [In]IntPtr Menu,
            [In]IntPtr Instance,
            [In]IntPtr Param);
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
            IntPtr ClassName,
            IntPtr WindowName,
            WindowStyle Style,
            int X, int Y,
            int Width, int Height,
            IntPtr HandleToParentWindow,
            IntPtr Menu,
            IntPtr Instance,
            IntPtr Param);

        internal enum WindowStyle : int
        {
            Overlapped = 0x00000000,
            Popup = unchecked((int)0x80000000),
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

        [Flags]
        internal enum ExtendedWindowStyle : int
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

        #region DestroyWindow

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DestroyWindow(IntPtr windowHandle);

        #endregion

        #region RegisterClass

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short RegisterClass(WindowClass window_class);

        #endregion

        #region UnregisterClass

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short UnregisterClass(string className, IntPtr instance);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short UnregisterClass(IntPtr className, IntPtr instance);

        #endregion

        #endregion

        #region Display settings

        #region int ChangeDisplaySettings(ref Gdi.DEVMODE devMode, int flags)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device_mode"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int ChangeDisplaySettings(DeviceMode device_mode, int flags);
        #endregion int ChangeDisplaySettings(ref Gdi.DEVMODE devMode, int flags)

        #region EnumDisplaySettings

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string device_name,
            int graphics_mode, IntPtr device_mode);

        #endregion

        #endregion

        #region GetASsyncKeyState

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern SHORT GetAsyncKeyState(int vKey);

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
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern LRESULT DefRawInputProc(
            RawInput[] RawInput,
            INT Input,
            UINT SizeHeader
        );

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
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern BOOL RegisterRawInputDevices(
            RawInputDevice[] RawInputDevices,
            UINT NumDevices,
            UINT Size
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
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern UINT GetRawInputBuffer(
            [Out] RawInput[] Data,
            [In, Out] ref UINT Size,
            [In] UINT SizeHeader
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
        [DllImport("user32.dll", SetLastError = true)]
        public static extern UINT GetRegisteredRawInputDevices(
            [Out] RawInput[] RawInputDevices,
            [In, Out] ref UINT NumDevices,
            UINT cbSize
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
        [DllImport("user32.dll", SetLastError = true)]
        public static extern UINT GetRawInputDeviceList(
            [Out] RawInputDeviceList[] RawInputDeviceList,
            [In, Out] ref UINT NumDevices,
            UINT Size
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
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern UINT GetRawInputDeviceInfo(
            HANDLE Device,
            UINT Command,
            [In, Out] LPVOID Data,
            [In, Out] ref UINT Size
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
        public static extern UINT GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            [Out] LPVOID Data,
            [In, Out] ref UINT Size,
            UINT SizeHeader
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
        public static extern UINT GetRawInputData(
            HRAWINPUT RawInput,
            GetRawInputDataEnum Command,
            [MarshalAs(UnmanagedType.LPStruct)] [Out] RawInput Data,
            [In, Out] ref UINT Size,
            UINT SizeHeader
        );

        #endregion

        #endregion

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

        #region PixelFormatDescriptor
        /// <summary>
        /// Describes a pixel format. It is used when interfacing with the WINAPI to create a new Context.
        /// Found in WinGDI.h
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal class PixelFormatDescriptor
        {
            short Size = 40;   // No need for the user to set the size, since it is predefined.
            internal short Version = 1;
            internal PixelFormatDescriptorFlags Flags =
                //PixelFormatDescriptorFlags.DOUBLEBUFFER |
                PixelFormatDescriptorFlags.DRAW_TO_WINDOW |
                PixelFormatDescriptorFlags.SUPPORT_OPENGL;
            internal byte PixelType = Constants.PFD_TYPE_RGBA;
            internal byte ColorBits = 0;
            internal byte RedBits = 0;
            internal byte RedShift = 0;
            internal byte GreenBits = 0;
            internal byte GreenShift = 0;
            internal byte BlueBits = 0;
            internal byte BlueShift = 0;
            internal byte AlphaBits = 8;
            internal byte AlphaShift = 0;
            internal byte AccumBits = 0;
            internal byte AccumRedBits = 0;
            internal byte AccumGreenBits = 0;
            internal byte AccumBlueBits = 0;
            internal byte AccumAlphaBits = 0;
            internal byte DepthBits = 0;
            internal byte StencilBits = 0;
            internal byte AuxBuffers = 0;
            internal byte LayerType = unchecked((byte)Constants.PFD_MAIN_PLANE);
            byte Reserved = 0;
            internal int LayerMask = 0;
            internal int VisibleMask = 0;
            internal int DamageMask = 0;
        }
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
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
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

            internal short Orientation;
            internal short PaperSize;
            internal short PaperLength;
            internal short PaperWidth;
            internal short Scale;
            internal short Copies;
            internal short DefaultSource;
            internal short PrintQuality;

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

        #region Window Handling

        #region WindowClass
        [StructLayout(LayoutKind.Sequential)]
        internal class WindowClass
        {
            internal WindowClassStyle style = WindowClassStyle.VRedraw | WindowClassStyle.HRedraw | WindowClassStyle.OwnDC;
            [MarshalAs(UnmanagedType.FunctionPtr)]
            internal WindowProcedureEventHandler WindowProcedure;
            internal int ClassExtraBytes;
            internal int WindowExtraBytes;
            //[MarshalAs(UnmanagedType.
            internal IntPtr Instance;
            internal IntPtr Icon;
            internal IntPtr Cursor;
            internal IntPtr BackgroundBrush;
            //[MarshalAs(UnmanagedType.LPStr)]
            internal IntPtr MenuName;
            //[MarshalAs(UnmanagedType.LPStr)]
            internal IntPtr ClassName;
            //internal string ClassName;
        }
        #endregion

        #region public struct MinMaxInfo

        /// <summary>
        /// Struct pointed to by WM_GETMINMAXINFO lParam
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            System.Drawing.Point ptReserved;
            System.Drawing.Point ptMaxSize;
            System.Drawing.Point ptMaxPosition;
            System.Drawing.Point ptMinTrackSize;
            System.Drawing.Point ptMaxTrackSize;
        }

        #endregion

        #region public struct WindowPosition

        /// <summary>
        /// The WindowPosition structure contains information about the size and position of a window.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct WindowPosition
        {
            /// <summary>
            /// Handle to the window.
            /// </summary>
            public HWND hwnd;
            /// <summary>
            /// Specifies the position of the window in Z order (front-to-back position).
            /// This member can be a handle to the window behind which this window is placed,
            /// or can be one of the special values listed with the SetWindowPos function.
            /// </summary>
            public HWND hwndInsertAfter;
            /// <summary>
            /// Specifies the position of the left edge of the window.
            /// </summary>
            public int x;
            /// <summary>
            /// Specifies the position of the top edge of the window.
            /// </summary>
            public int y;
            /// <summary>
            /// Specifies the window width, in pixels.
            /// </summary>
            public int cx;
            /// <summary>
            /// Specifies the window height, in pixels.
            /// </summary>
            public int cy;
            /// <summary>
            /// Specifies the window position.
            /// </summary>
            [MarshalAs(UnmanagedType.U4)]
            public SetWindowPosFlags flags;
        }

        #region public enum SetWindowPosFlags

        [Flags]
        public enum SetWindowPosFlags : int
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

        public static readonly uint RawInputDeviceSize;

        /// <summary>
        /// Defines information for the raw input devices.
        /// </summary>
        /// <remarks>
        /// If RIDEV_NOLEGACY is set for a mouse or a keyboard, the system does not generate any legacy message for that device for the application. For example, if the mouse TLC is set with RIDEV_NOLEGACY, WM_LBUTTONDOWN and related legacy mouse messages are not generated. Likewise, if the keyboard TLC is set with RIDEV_NOLEGACY, WM_KEYDOWN and related legacy keyboard messages are not generated.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        public struct RawInputDevice
        {
            /// <summary>
            /// Top level collection Usage page for the raw input device.
            /// </summary>
            public USHORT UsagePage;
            /// <summary>
            /// Top level collection Usage for the raw input device.
            /// </summary>
            public USHORT Usage;
            /// <summary>
            /// Mode flag that specifies how to interpret the information provided by UsagePage and Usage.
            /// It can be zero (the default) or one of the following values.
            /// By default, the operating system sends raw input from devices with the specified top level collection (TLC)
            /// to the registered application as long as it has the window focus. 
            /// </summary>
            public RawInputDeviceFlags Flags;
            /// <summary>
            /// Handle to the target window. If NULL it follows the keyboard focus.
            /// </summary>
            public HWND Target;

            public override string ToString()
            {
                return String.Format("{0}/{1}, flags: {2}, window: {3}", UsagePage, Usage, Flags, Target);
            }
        }

        #endregion

        #region RawInputDeviceList

        /// <summary>
        /// Contains information about a raw input device.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public class RawInputDeviceList
        {
            /// <summary>
            /// Handle to the raw input device.
            /// </summary>
            public HANDLE Device;
            /// <summary>
            /// Type of device.
            /// </summary>
            public RawInputDeviceType Type;
        }

        #endregion

        #region RawInput

        public static uint RawInputSize;

        /// <summary>
        /// Contains the raw input from a device.
        /// </summary>
        /// <remarks>
        /// <para>The handle to this structure is passed in the lParam parameter of WM_INPUT.</para>
        /// <para>To get detailed information -- such as the header and the content of the raw input -- call GetRawInputData.</para>
        /// <para>To get device specific information, call GetRawInputDeviceInfo with the hDevice from RAWINPUTHEADER.</para>
        /// <para>Raw input is available only when the application calls RegisterRawInputDevices with valid device specifications.</para>
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        public class RawInput
        {
            public RawInputHeader Header;
            public RawInputData Data;

            [StructLayout(LayoutKind.Explicit)]
            public struct RawInputData
            {
                [FieldOffset(0)]
                public RawMouse Mouse;
                [FieldOffset(0)]
                public RawKeyboard Keyboard;
                [FieldOffset(0)]
                public RawHID HID; 
            }
        }

        #endregion

        #region RawInputHeader

        public static readonly uint RawInputHeaderSize;

        /// <summary>
        /// Contains the header information that is part of the raw input data.
        /// </summary>
        /// <remarks>
        /// To get more information on the device, use hDevice in a call to GetRawInputDeviceInfo.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        public struct RawInputHeader
        {
            /// <summary>
            /// Type of raw input.
            /// </summary>
            public RawInputDeviceType Type;
            /// <summary>
            /// Size, in bytes, of the entire input packet of data. This includesRAWINPUT plus possible extra input reports in the RAWHID variable length array.
            /// </summary>
            public DWORD Size;
            /// <summary>
            /// Handle to the device generating the raw input data.
            /// </summary>
            public HANDLE Device;
            /// <summary>
            /// Value passed in the wParam parameter of the WM_INPUT message.
            /// </summary>
            public WPARAM Param;
        }

        #endregion

        #region RawKeyboard

        /// <summary>
        /// Contains information about the state of the keyboard.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RawKeyboard
        {
            /// <summary>
            /// Scan code from the key depression. The scan code for keyboard overrun is KEYBOARD_OVERRUN_MAKE_CODE.
            /// </summary>
            public USHORT MakeCode;
            /// <summary>
            /// Flags for scan code information. It can be one or more of the following.
            /// RI_KEY_MAKE
            /// RI_KEY_BREAK
            /// RI_KEY_E0
            /// RI_KEY_E1
            /// RI_KEY_TERMSRV_SET_LED
            /// RI_KEY_TERMSRV_SHADOW
            /// </summary>
            public RawInputKeyboardDataFlags Flags;
            /// <summary>
            /// Reserved; must be zero.
            /// </summary>
            USHORT Reserved;
            /// <summary>
            /// Microsoft Windows message compatible virtual-key code. For more information, see Virtual-Key Codes.
            /// </summary>
            public USHORT VKey;
            /// <summary>
            /// Corresponding window message, for example WM_KEYDOWN, WM_SYSKEYDOWN, and so forth.
            /// </summary>
            public UINT Message;
            /// <summary>
            /// Device-specific additional information for the event.
            /// </summary>
            public ULONG ExtraInformation;
        }

        #endregion

        #region RawMouse

        /// <summary>
        /// Contains information about the state of the mouse.
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct RawMouse
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
            [FieldOffset(0)]
            public USHORT Flags;
            /// <summary>
            /// Reserved.
            /// </summary>
            [FieldOffset(2)]
            ULONG Buttons;
            /// <summary>
            /// Transition state of the mouse buttons.
            /// </summary>
            [FieldOffset(2)]
            public RawInputMouseState ButtonFlags;
            /// <summary>
            /// If usButtonFlags is RI_MOUSE_WHEEL, this member is a signed value that specifies the wheel delta.
            /// </summary>
            [FieldOffset(4)]
            public USHORT ButtonData;
            /// <summary>
            /// Raw state of the mouse buttons.
            /// </summary>
            [FieldOffset(6)]
            public ULONG RawButtons;
            /// <summary>
            /// Motion in the X direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
            /// </summary>
            [FieldOffset(10)]
            public LONG LastX;
            /// <summary>
            /// Motion in the Y direction. This is signed relative motion or absolute motion, depending on the value of usFlags.
            /// </summary>
            [FieldOffset(14)]
            public LONG LastY;
            /// <summary>
            /// Device-specific additional information for the event.
            /// </summary>
            [FieldOffset(18)]
            public ULONG ExtraInformation;
        }

        #endregion

        #region RawHID

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
        public struct RawHID
        {
            /// <summary>
            /// Size, in bytes, of each HID input in bRawData.
            /// </summary>
            public DWORD SizeHid;
            /// <summary>
            /// Number of HID inputs in bRawData.
            /// </summary>
            public DWORD Count;
            /// <summary>
            /// Raw input data as an array of bytes.
            /// </summary>
            public BYTE RawData;
        }

        #endregion

        #region RawInputDeviceInfo

        /// <summary>
        /// Defines the raw input data coming from any device.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public class RawInputDeviceInfo
        {
            /// <summary>
            /// Size, in bytes, of the RawInputDeviceInfo structure.
            /// </summary>
            DWORD Size = Marshal.SizeOf(typeof(RawInputDeviceInfo)); 
            /// <summary>
            /// Type of raw input data.
            public RawInputDeviceType Type;
            [StructLayout(LayoutKind.Explicit)]
            public struct Device
            { 
                [FieldOffset(0)]RawInputMouseDeviceInfo Mouse;
                [FieldOffset(0)]RawInputKeyboardDeviceInfo Keyboard;
                [FieldOffset(0)]RawInputHIDDeviceInfo HID; 
            };
        }

        #endregion

        #region RawInputHIDDeviceInfo

        /// <summary>
        /// Defines the raw input data coming from the specified Human Interface Device (HID).
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RawInputHIDDeviceInfo
        {
            /// <summary>
            /// Vendor ID for the HID.
            /// </summary>
            public DWORD VendorId;
            /// <summary>
            /// Product ID for the HID.
            /// </summary>
            public DWORD ProductId;
            /// <summary>
            /// Version number for the HID.
            /// </summary>
            public DWORD VersionNumber;
            /// <summary>
            /// Top-level collection Usage Page for the device.
            /// </summary>
            public USHORT UsagePage;
            /// <summary>
            /// Top-level collection Usage for the device.
            /// </summary>
            public USHORT Usage;
        }

        #endregion

        #region RawInputKeyboardDeviceInfo

        /// <summary>
        /// Defines the raw input data coming from the specified keyboard.
        /// </summary>
        /// <remarks>
        /// For the keyboard, the Usage Page is 1 and the Usage is 6.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        public struct RawInputKeyboardDeviceInfo
        {
            /// <summary>
            /// Type of the keyboard.
            /// </summary>
            public DWORD Type;
            /// <summary>
            /// Subtype of the keyboard.
            /// </summary>
            public DWORD SubType;
            /// <summary>
            /// Scan code mode.
            /// </summary>
            public DWORD KeyboardMode;
            /// <summary>
            /// Number of function keys on the keyboard.
            /// </summary>
            public DWORD NumberOfFunctionKeys;
            /// <summary>
            /// Number of LED indicators on the keyboard.
            /// </summary>
            public DWORD NumberOfIndicators;
            /// <summary>
            /// Total number of keys on the keyboard.
            /// </summary>
            public DWORD NumberOfKeysTotal;
        }

        #endregion

        #region RawInputMouseDeviceInfo

        /// <summary>
        /// Defines the raw input data coming from the specified mouse.
        /// </summary>
        /// <remarks>
        /// For the keyboard, the Usage Page is 1 and the Usage is 2.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        public struct RawInputMouseDeviceInfo
        {
            /// <summary>
            /// ID for the mouse device.
            /// </summary>
            public DWORD Id;
            /// <summary>
            /// Number of buttons for the mouse.
            /// </summary>
            public DWORD NumberOfButtons;
            /// <summary>
            /// Number of data points per second. This information may not be applicable for every mouse device.
            /// </summary>
            public DWORD SampleRate;
            /// <summary>
            /// TRUE if the mouse has a wheel for horizontal scrolling; otherwise, FALSE.
            /// </summary>
            /// <remarks>
            /// This member is only supported under Microsoft Windows Vista and later versions.
            /// </remarks>
            public BOOL HasHorizontalWheel;
        }

        #endregion

        #endregion

        #endregion

        #region --- Enums ---
        
        #region PixelFormatDescriptorFlags enum
        [Flags]
        internal enum PixelFormatDescriptorFlags : int
        {
            // PixelFormatDescriptor flags
            DOUBLEBUFFER,
            STEREO,
            DRAW_TO_WINDOW,
            DRAW_TO_BITMAP,
            SUPPORT_GDI,
            SUPPORT_OPENGL,
            GENERIC_FORMAT,
            NEED_PALETTE,
            NEED_SYSTEM_PALETTE,
            SWAP_EXCHANGE,
            SWAP_COPY,
            SWAP_LAYER_BUFFERS,
            GENERIC_ACCELERATED,
            SUPPORT_DIRECTDRAW,

            // PixelFormatDescriptor flags for use in ChoosePixelFormat only
            DEPTH_DONTCARE = unchecked((int)0x20000000),
            DOUBLEBUFFER_DONTCARE = unchecked((int)0x40000000),
            STEREO_DONTCARE = unchecked((int)0x80000000)
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

        #region WindowClassStyle enum
        [Flags]
        internal enum WindowClassStyle
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
        public enum RawInputDeviceFlags : int
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

        public enum GetRawInputDataEnum
        {
            INPUT             = 0x10000003,
            HEADER            = 0x10000005
        }

        #endregion

        #region RawInputDeviceInfoEnum

        public enum RawInputDeviceInfoEnum
        {
            PREPARSEDDATA    = 0x20000005,
            DEVICENAME       = 0x20000007,  // the return valus is the character length, not the byte size
            DEVICEINFO       = 0x2000000b
        }

        #endregion

        #region RawInputMouseState

        public enum RawInputMouseState : ushort
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

            WHEEL            = 0x0400
        }

        #endregion

        #region RawInputKeyboardDataFlags

        public enum RawInputKeyboardDataFlags : ushort
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

        public enum RawInputDeviceType : int
        {
            MOUSE    = 0,
            KEYBOARD = 1,
            HID      = 2
        }

        #endregion

        #endregion

        #region --- Callbacks ---

        [UnmanagedFunctionPointerAttribute(CallingConvention.Winapi)]
        internal delegate void WindowProcedureEventHandler(object sender, WindowProcedureEventArgs e);

        internal class WindowProcedureEventArgs : EventArgs
        {
            private Message msg;
            internal Message Message
            {
                get { return msg; }
                set { msg = value; }
            }
        }

        #endregion
    }
}
