//
// WinRawJoystick.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006 Stefanos Apostolopoulos
// Copyright (c) 2007 Erik Ylvisaker
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using OpenTK.Core;
using OpenTK.Platform.Common;

#if !MINIMAL
using System.Drawing;

#endif

/* TODO: Update the description of TimeBeginPeriod and other native methods. Update Timer. */

#pragma warning disable 3019    // CLS-compliance checking
#pragma warning disable 0649    // struct members not explicitly initialized
#pragma warning disable 0169    // field / method is never used.
#pragma warning disable 0414    // field assigned but never used.

namespace OpenTK.Platform.Windows
{
    using HWND = IntPtr;
    using HINSTANCE = IntPtr;
    using HMENU = IntPtr;
    using HICON = IntPtr;
    using HBRUSH = IntPtr;
    using HCURSOR = IntPtr;
    using HKEY = IntPtr;
    using PHKEY = IntPtr;
    using HDROP = IntPtr;
    using LRESULT = IntPtr;
    using LPVOID = IntPtr;
    using LPCTSTR = String;
    using WPARAM = IntPtr;
    using LPARAM = IntPtr;
    using HANDLE = IntPtr;
    using HRAWINPUT = IntPtr;
    using BYTE = Byte;
    using SHORT = Int16;
    using USHORT = UInt16;
    using LONG = Int32;
    using ULONG = UInt32;
    using WORD = Int16;
    using DWORD = Int32;
    using BOOL = Boolean;
    using INT = Int32;
    using UINT = UInt32;
    using LONG_PTR = IntPtr;
    using ATOM = Int32;
    using COLORREF = Int32;
    using RECT = Win32Rectangle;
    using WNDPROC = IntPtr;
    using LPDEVMODE = DeviceMode;
    using HDEVNOTIFY = IntPtr;
    using HRESULT = IntPtr;
    using HMONITOR = IntPtr;
    using DWORD_PTR = IntPtr;
    using UINT_PTR = UIntPtr;
    using TIMERPROC = Functions.TimerProc;
    using REGSAM = UInt32;

    /// \internal
    /// <summary>
    /// For internal use by OpenTK only!
    /// Exposes useful native WINAPI methods and structures.
    /// </summary>
    internal static class API
    {
        internal static readonly short PixelFormatDescriptorSize;
        internal static readonly short PixelFormatDescriptorVersion;
        internal static readonly int RawInputSize;
        internal static readonly int RawInputDeviceSize;
        internal static readonly int RawInputHeaderSize;
        internal static readonly int RawInputDeviceListSize;
        internal static readonly int RawInputDeviceInfoSize;
        internal static readonly int RawMouseSize;

        internal static readonly int WindowInfoSize;

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
    }

    internal static class Functions
    {
        [DllImport("dwmapi.dll")]
        public static extern unsafe HRESULT DwmGetWindowAttribute(HWND hwnd, DwmWindowAttribute dwAttribute,
            void* pvAttribute, int cbAttribute);

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
                return RawInputAlign((IntPtr)((byte*)data + API.RawInputHeaderSize));
            }
        }

        private static IntPtr RawInputAlign(IntPtr data)
        {
            unsafe
            {
                return (IntPtr)((byte*)data + ((IntPtr.Size - 1) & ~(IntPtr.Size - 1)));
            }
        }

        [DllImport("Advapi32.dll")]
        internal static extern int RegOpenKeyEx(
            HKEY hKey,
            [MarshalAs(UnmanagedType.LPTStr)] string lpSubKey,
            int ulOptions,
            uint samDesired,
            out PHKEY phkResult);

        [DllImport("Advapi32.dll")]
        internal static extern int RegGetValue(
            HKEY hkey,
            [MarshalAs(UnmanagedType.LPTStr)] string lpSubKey,
            [MarshalAs(UnmanagedType.LPTStr)] string lpValue,
            int dwFlags,
            out int pdwType,
            StringBuilder pvData,
            ref int pcbData);
    }

    internal static class Constants
    {
        // Found in winuser.h
        internal const int KEYBOARD_OVERRUN_MAKE_CODE = 0xFF;

        // WM_ACTIVATE state values (found in winuser.h)
        internal const int WA_INACTIVE = 0;
        internal const int WA_ACTIVE = 1;
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
        internal const int WM_INPUT = 0x00FF; // Raw input. XP and higher only.
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

        public enum MouseActivate
        {
            ACTIVATE = 1,
            ACTIVATEANDEAT = 2,
            NOACTIVATE = 3,
            NOACTIVATEANDEAT = 4
        }

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

        internal static readonly IntPtr MESSAGE_ONLY = new IntPtr(-3);

        internal static readonly IntPtr HKEY_LOCAL_MACHINE = new IntPtr(unchecked((int)0x80000002));
    }

    internal struct CreateStruct
    {
        /// <summary>
        /// Contains additional data which may be used to create the window.
        /// </summary>
        /// <remarks>
        /// If the window is being created as a result of a call to the CreateWindow
        /// or CreateWindowEx function, this member contains the value of the lpParam
        /// parameter specified in the function call.
        ///  <para>
        /// If the window being created is a multiple-document interface (MDI) client window,
        /// this member contains a pointer to a CLIENTCREATESTRUCT structure. If the window
        /// being created is a MDI child window, this member contains a pointer to an
        /// MDICREATESTRUCT structure.
        ///  </para>
        ///  <para>
        /// Windows NT/2000/XP: If the window is being created from a dialog template,
        /// this member is the address of a SHORT value that specifies the size, in bytes,
        /// of the window creation data. The value is immediately followed by the creation data.
        ///  </para>
        ///  <para>
        /// Windows NT/2000/XP: You should access the data represented by the lpCreateParams member
        /// using a pointer that has been declared using the UNALIGNED type, because the pointer
        /// may not be DWORD aligned.
        ///  </para>
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
        internal int style;

        /// <summary>
        /// Pointer to a null-terminated string that specifies the name of the new window.
        /// </summary>
        [MarshalAs(UnmanagedType.LPTStr)] internal string lpszName;

        /// <summary>
        /// Either a pointer to a null-terminated string or an atom that specifies the class name
        /// of the new window.
        ///  <remarks>
        /// Note  Because the lpszClass member can contain a pointer to a local (and thus inaccessable) atom,
        /// do not obtain the class name by using this member. Use the GetClassName function instead.
        ///  </remarks>
        /// </summary>
        [MarshalAs(UnmanagedType.LPTStr)] internal string lpszClass;

        /// <summary>
        /// Specifies the extended window style for the new window.
        /// </summary>
        internal int dwExStyle;
    }

    internal struct StyleStruct
    {
        public WindowStyle Old;
        public WindowStyle New;
    }

    internal struct ExtendedStyleStruct
    {
        public ExtendedWindowStyle Old;
        public ExtendedWindowStyle New;
    }

    /// \internal
    


    /// \internal
    /// <summary>
    /// Describes the pixel format of a drawing surface.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct LayerPlaneDescriptor
    {
        internal static readonly short Size = (short)Marshal.SizeOf(typeof(LayerPlaneDescriptor));
        internal short Version;
        internal int Flags;
        internal byte PixelType;
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
        internal byte LayerPlane;
        private readonly byte Reserved;
        internal int crTransparent;
    }

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
        /// Specifies the x and y coordinates of the upper-left corner of the smallest rectangle that completely encloses the
        /// glyph.
        /// </summary>
        internal PointFloat GlyphOrigin;

        /// <summary>
        /// Specifies the horizontal distance from the origin of the current character cell to the origin of the next character
        /// cell.
        /// </summary>
        internal float CellIncX;

        /// <summary>
        /// Specifies the vertical distance from the origin of the current character cell to the origin of the next character
        /// cell.
        /// </summary>
        internal float CellIncY;
    }

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
    }

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
    

    /// \internal
    

    

    

    /// \internal
    /// <summary>
    /// Struct pointed to by WM_GETMINMAXINFO lParam
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct MINMAXINFO
    {
        private readonly Point Reserved;
        public Size MaxSize;
        public Point MaxPosition;
        public Size MinTrackSize;
        public Size MaxTrackSize;
    }

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
        [MarshalAs(UnmanagedType.U4)] internal SetWindowPosFlags flags;
    }

    

    /// \internal
    

    /// \internal
    

    /// \internal
    

    

    /// \internal
    

    /// \internal
    

    /// \internal
    
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

    /// \internal
    

    /// \internal
    

    /// \internal
    

    /// \internal
    

    /// \internal
    

    

    /// \internal
    

    

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct NcCalculateSize
    {
        public Win32Rectangle NewBounds;
        public Win32Rectangle OldBounds;
        public Win32Rectangle OldClientRectangle;
        public unsafe WindowPosition* Position;
    }

    

    internal struct BroadcastHeader
    {
        public int Size;
        public DeviceBroadcastType DeviceType;
        private int dbch_reserved;
    }

    internal struct BroadcastDeviceInterface
    {
        public int Size;
        public DeviceBroadcastType DeviceType;
        private int dbcc_reserved;
        public Guid ClassGuid;
        public char dbcc_name;
    }

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

    

    /// \internal
    

    /// <summary>
    /// Window field offsets for GetWindowLong() and GetWindowLongPtr().
    /// </summary>
    internal enum GWL
    {
        WNDPROC = -4,
        HINSTANCE = -6,
        HWNDPARENT = -8,
        STYLE = -16,
        EXSTYLE = -20,
        USERDATA = -21,
        ID = -12
    }

    internal enum SizeMessage
    {
        MAXHIDE = 4,
        MAXIMIZED = 2,
        MAXSHOW = 3,
        MINIMIZED = 1,
        RESTORED = 0
    }

    internal enum NcCalcSizeOptions
    {
        ALIGNTOP = 0x10,
        ALIGNRIGHT = 0x80,
        ALIGNLEFT = 0x20,
        ALIGNBOTTOM = 0x40,
        HREDRAW = 0x100,
        VREDRAW = 0x200,
        REDRAW = HREDRAW | VREDRAW,
        VALIDRECTS = 0x400
    }

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    /// <summary>
    /// Enumerates available mouse keys (suitable for use in WM_MOUSEMOVE messages).
    /// </summary>
    internal enum MouseKeys
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
        XButton2 = 0x0040
    }

    /// \internal
    

    

    

    

    /// <summary>
    /// Identifiers for the WM_SHOWWINDOW message
    /// </summary>
    internal enum ShowWindowMessageIdentifiers
    {
        PARENTCLOSING = 1,
        OTHERZOOM = 2,
        PARENTOPENING = 3,
        OTHERUNZOOM = 4
    }

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
        Baltic = 186
    }

    

    

    internal enum DwmWindowAttribute
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
}

#pragma warning restore 3019
#pragma warning restore 0649
#pragma warning restore 0169
#pragma warning restore 0414
