/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Runtime.InteropServices;
using System.Text;
//using System.Windows.Forms;

/* TODO: Update the description of TimeBeginPeriod and other native methods. Update Timer. */

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// For internal use by OpenTK only!
    /// Exposes useful native WINAPI methods and structures.
    /// </summary>
    public static class Api
    {
        #region Constants

        public struct Constants
        {
            // Keyboard events (found in WinUSER.h)
            public const int WM_KEYDOWN = 0x0100;
            public const int WM_KEYUP = 0x101;
            public const int WM_SYSKEYDOWN = 0x0104;
            public const int WM_SYSKEYUP = 0x0105;
            public const int WM_COMMAND = 0x0111;
            public const int WM_SYSCOMMAND = 0x0112;

            // Pixel types (found in WinGDI.h)
            public const byte PFD_TYPE_RGBA         = 0;
            public const byte PFD_TYPE_COLORINDEX   = 1;

            // Layer types (found in WinGDI.h)
            public const sbyte PFD_MAIN_PLANE       = 0;
            public const sbyte PFD_OVERLAY_PLANE    = 1;
            public const sbyte PFD_UNDERLAY_PLANE   = -1;
        }

        #endregion

        #region WINAPI methods

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
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool PeekMessage(out System.Windows.Forms.Message msg, IntPtr hWnd, uint messageFilterMin,
            uint messageFilterMax, uint flags);

        #endregion

        #region GetMessage

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetMessage(out System.Windows.Forms.Message msg, IntPtr hWnd, uint messageFilterMin,
            uint messageFilterMax);

        #endregion

        #region TimeBeginPeriod

        /// <summary>
        /// Sets the timing resolution of the GetTime (?) method.
        /// </summary>
        /// <param name="period">Timing resolution in msec (?)</param>
        /// <returns>(?)</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll")]
        public static extern IntPtr TimeBeginPeriod(uint period);

        #endregion

        #region QueryPerformanceFrequency

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PerformanceFrequency"></param>
        /// <returns></returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll")]
        public static extern bool QueryPerformanceFrequency(ref long PerformanceFrequency);

        #endregion

        #region QueryPerformanceCounter

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PerformanceCount"></param>
        /// <returns></returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll")]
        public static extern bool QueryPerformanceCounter(ref long PerformanceCount);

        #endregion

        #region GetDC

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int GetDC(int hwnd);

        #endregion

        #region ReleaseDC

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="hDC"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(int hwnd, int hDC);

        #endregion

        #region ChoosePixelFormat

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="pfd"></param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        public static extern int ChoosePixelFormat(int dc, [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor pfd);

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
        public static extern bool SetPixelFormat(int dc, int format, [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor pfd);


        #endregion

        #region SetWindowPos

        // WINUSERAPI BOOL WINAPI SetWindowPos(__in HWND hWnd, __in_opt HWND hWndInsertAfter,
        //                                     __in int X, __in int Y, __in int cx, __in int cy, __in UINT uFlags);

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(int handle, WindowPlacementOptions placement, int x, int y, int cx, int cy, SetWindowPosFlags flags);

        #endregion

        #region SwapBuffers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        [DllImport("gdi32.dll")]
        public static extern void SwapBuffers(int dc);

        #endregion

        #region GetProcAddress

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="funcname"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern int GetProcAddress(int handle, String funcname);

        #endregion

        #region LoadLibrary

        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcname"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int LoadLibrary(string funcname);

        #endregion

        #region FreeLibrary

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern int FreeLibrary(int handle);

        #endregion

        #region CreateWindowEx

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int CreateWindowEx(
            [In]ExtendedWindowStyle ExStyle,
            StringBuilder ClassName,
            [In]string WindowName,
            [In]WindowStyle Style,
            [In]int X, int Y,
            [In]int Width, int Height,
            [In]IntPtr HandleToParentWindow,
            [In]IntPtr Menu,
            [In]IntPtr Instance,
            [In]IntPtr Param);
        /*
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int CreateWindowEx(
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
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int CreateWindowEx(
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

        public enum WindowStyle : uint
        {
            Overlapped      = 0x00000000,
            Popup           = 0x80000000,
            Child           = 0x40000000,
            Minimize        = 0x20000000,
            Visible         = 0x10000000,
            Disabled        = 0x08000000,
            ClipSiblings    = 0x04000000,
            ClipChildren    = 0x02000000,
            Maximize        = 0x01000000,
            Caption         = 0x00C00000,    // Border | DialogFrame
            Border          = 0x00800000,
            DialogFrame     = 0x00400000,
            VScroll         = 0x00200000,
            HScreen         = 0x00100000,
            SystemMenu      = 0x00080000,
            ThickFrame      = 0x00040000,
            Group           = 0x00020000,
            TabStop         = 0x00010000,

            MinimizeBox     = 0x00020000,
            MaximizeBox     = 0x00010000,

            Tiled           = Overlapped,
            Iconic          = Minimize,
            SizeBox         = ThickFrame,
            TiledWindow     = OverlappedWindow,

            // Common window styles:
            OverlappedWindow = Overlapped | Caption | SystemMenu | ThickFrame | MinimizeBox | MaximizeBox,
            PopupWindow     = Popup | Border | SystemMenu,
            ChildWindow     = Child
        }

        public enum ExtendedWindowStyle : uint
        {
            DialogModalFrame    = 0x00000001,
            NoParentNotify   = 0x00000004,
            Topmost          = 0x00000008,
            AcceptFiles      = 0x00000010,
            Transparent      = 0x00000020,

            // #if(WINVER >= 0x0400)
            MdiChild         = 0x00000040,
            ToolWindow       = 0x00000080,
            WindowEdge       = 0x00000100,
            ClientEdge       = 0x00000200,
            ContextHelp      = 0x00000400,
            // #endif
            
            // #if(WINVER >= 0x0400)
            Right            = 0x00001000,
            Left             = 0x00000000,
            RightToLeftReading  = 0x00002000,
            LeftToRightReading  = 0x00000000,
            LeftScrollbar    = 0x00004000,
            RightScrollbar   = 0x00000000,

            ControlParent    = 0x00010000,
            StaticEdge       = 0x00020000,
            ApplicationWindow   = 0x00040000,

            OverlappedWindow = WindowEdge | ClientEdge,
            PaletteWindow    = WindowEdge | ToolWindow | Topmost,
            // #endif

            // #if(_WIN32_WINNT >= 0x0500)
            Layered          = 0x00080000,
            // #endif

            // #if(WINVER >= 0x0500)
            NoInheritLayout  = 0x00100000, // Disable inheritence of mirroring by children
            RightToLeftLayout = 0x00400000, // Right to left mirroring
            // #endif /* WINVER >= 0x0500 */

            // #if(_WIN32_WINNT >= 0x0501)
            Composited       = 0x02000000,
            // #endif /* _WIN32_WINNT >= 0x0501 */

            // #if(_WIN32_WINNT >= 0x0500)
            NoActivate       = 0x08000000
            // #endif /* _WIN32_WINNT >= 0x0500 */
        }

        #endregion

        #region GetModuleHandle

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPTStr)]string module_name);

        #endregion

        #region RegisterClass

        [DllImport("user32.dll", SetLastError = true)]
        public static extern short RegisterClass(WindowClass window_class);

        #endregion

        
        // *********** Never use GetLastError! ************

        //#region GetLastError

        //[DllImport("kernel32.dll")]
        //public static extern int GetLastError();

        //#endregion

        //#region SetLastError

        //[DllImport("kernel32.dll")]
        //public static extern void SetLastError(int error_code);

        //#endregion

        //#region FormatMessage

        //#endregion

        // ************************************************

        #endregion

        #region WINAPI structs

        #region PixelFormatDescriptor

        /// <summary>
        /// Describes a pixel format. It is used when interfacing with the WINAPI to create a new Context.
        /// Found in WinGDI.h
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public class PixelFormatDescriptor
        {
            short Size = 40;   // No need for the user to set the size, since it is predefined.
            public short Version    = 1;
            public PixelFormatDescriptorFlags Flags = 
                //PixelFormatDescriptorFlags.DOUBLEBUFFER |
                PixelFormatDescriptorFlags.DRAW_TO_WINDOW |
                PixelFormatDescriptorFlags.SUPPORT_OPENGL;
            public byte PixelType   = Constants.PFD_TYPE_RGBA;
            public byte ColorBits   = 0;
            public byte RedBits     = 0;
            public byte RedShift    = 0;
            public byte GreenBits   = 0;
            public byte GreenShift  = 0;
            public byte BlueBits    = 0;
            public byte BlueShift   = 0;
            public byte AlphaBits   = 8;
            public byte AlphaShift  = 0;
            public byte AccumBits   = 0;
            public byte AccumRedBits    = 0;
            public byte AccumGreenBits  = 0;
            public byte AccumBlueBits   = 0;
            public byte AccumAlphaBits  = 0;
            public byte DepthBits   = 0;
            public byte StencilBits = 0;
            public byte AuxBuffers  = 0;
            public sbyte LayerType  = Constants.PFD_MAIN_PLANE;
            byte Reserved = 0;
            public uint LayerMask  = 0;
            public uint VisibleMask = 0;
            public uint DamageMask = 0;
        }

        [Flags]
        public enum PixelFormatDescriptorFlags : uint
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
            DEPTH_DONTCARE        = 0x20000000,
            DOUBLEBUFFER_DONTCARE = 0x40000000,
            STEREO_DONTCARE       = 0x80000000
        }

        #endregion

        #region SetWindowPosFlags

        [Flags]
        public enum SetWindowPosFlags
        {
            // SetWindowPos Flags
            NOSIZE,
            NOMOVE,
            NOZORDER,
            NOREDRAW,
            NOACTIVATE,
            FRAMECHANGED,       // The frame changed: send WM_NCCALCSIZE
            SHOWWINDOW,
            HIDEWINDOW,
            NOCOPYBITS,
            NOOWNERZORDER,      // Don't do owner Z ordering
            NOSENDCHANGING,     // Don't send WM_WINDOWPOSCHANGING

            DRAWFRAME      = FRAMECHANGED,
            NOREPOSITION   = NOOWNERZORDER

            //#if WINVER >= 0x0400
            //public const int SWP_DEFERERASE     = 0x2000;
            //public const int SWP_ASYNCWINDOWPOS = 0x4000;
            //#endif
        }

        #endregion

        #region WindowPlacementOptions

        public enum WindowPlacementOptions
        {
             TOP       = 0,
             BOTTOM    = 1,
             TOPMOST   = -1,
             NOTOPMOST = -2
        }
        
        #endregion

        #region WindowClass

        [StructLayout(LayoutKind.Sequential)]
        public class WindowClass
        {
            public WindowClassStyle style = WindowClassStyle.VRedraw | WindowClassStyle.HRedraw | WindowClassStyle.OwnDC;
            [MarshalAs(UnmanagedType.FunctionPtr)]
            public WindowProcedureEventHandler WindowProcedure;
            public int ClassExtraBytes;
            public int WindowExtraBytes;
            //[MarshalAs(UnmanagedType.
            public IntPtr Instance;
            public IntPtr Icon;
            public IntPtr Cursor;
            public IntPtr BackgroundBrush;
            //[MarshalAs(UnmanagedType.LPStr)]
            public IntPtr MenuName;
            //[MarshalAs(UnmanagedType.LPStr)]
            public IntPtr ClassName;
        }

        #endregion

        #region Class styles

        public enum WindowClassStyle
        {
            VRedraw         = 0x0001,
            HRedraw         = 0x0002,
            DoubleClicks    = 0x0008,
            OwnDC           = 0x0020,
            ClassDC         = 0x0040,
            ParentDC        = 0x0080,
            NoClose         = 0x0200,
            SaveBits        = 0x0800,
            ByteAlignClient = 0x1000,
            ByteAlignWindow = 0x2000,
            GlobalClass     = 0x4000,

            Ime             = 0x00010000,
            
            // #if(_WIN32_WINNT >= 0x0501)
            DropShadow      = 0x00020000
            // #endif /* _WIN32_WINNT >= 0x0501 */
        }

        #endregion

        #endregion
        
        [UnmanagedFunctionPointerAttribute(CallingConvention.Winapi)]
        public delegate void WindowProcedureEventHandler(object sender, WindowProcedureEventArgs e);

        public class WindowProcedureEventArgs : EventArgs
        {
            public System.Windows.Forms.Message Msg;
        }
    }    
}
