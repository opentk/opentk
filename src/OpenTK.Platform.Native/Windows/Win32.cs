using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace OpenTK.Platform.Native.Windows
{
    internal static unsafe class Win32
    {
        internal const int LoWordMask = 0x0000_FFFF;
        internal const int HiWordMask = unchecked((int)0xFFFF_0000);

        internal static int GET_X_LPARAM(IntPtr lParam) => ((short)lParam & LoWordMask);
        internal static int GET_Y_LPARAM(IntPtr lParam) => (((int)lParam >> 16) & LoWordMask);

        // FIXME: Potentially change HTCLIENT into an enum later.

        /// <summary>
        /// In client area.
        /// </summary>
        internal const int HTCLIENT = 1;

        internal const int CW_USEDEFAULT = -1;

        internal const int ERROR_FILE_NOT_FOUND = 0x2;
        internal const int ERROR_INVALID_PARAMETER = 87;

        internal const int CCHDEVICENAME = 32;
        internal const int CCHFORMNAME = 32;

        internal const int EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001;

        internal const int KL_NAMELENGTH = 9;

        internal const int ICON_SMALL = 0;
        internal const int ICON_BIG = 1;

        // LRESULT WNDPROC(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
        internal delegate IntPtr WNDPROC(IntPtr hWnd, WM uMsg, UIntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr DefWindowProc(IntPtr hWnd, WM Msg, UIntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct WNDCLASSEX
        {
            public uint cbSize;
            public ClassStyles style;
            [MarshalAs(UnmanagedType.FunctionPtr)]
            public WNDPROC lpfnWndProc;
            public int cbClsExtra;
            public int cbWndExtra;
            public IntPtr hInstance; // HINSTANCE
            public IntPtr hIcon; // HICON?
            public IntPtr hCursor; // HCURSOR?
            public IntPtr hbrBackground; // HBRUSH?
            public string? lpszMenuName;
            public string lpszClassName;
            public IntPtr hIconSm; // HICON

            /// <summary>
            /// Creates a <see cref="WNDCLASSEX"/> with cbSize already filled in.
            /// </summary>
            /// <returns>A new <see cref="WNDCLASSEX"/>.</returns>
            public static WNDCLASSEX Create()
            {
                WNDCLASSEX wndClass = default;
                unchecked
                {
                    wndClass.cbSize = (uint)Marshal.SizeOf<WNDCLASSEX>();
                }
                return wndClass;
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr GetModuleHandle(string? lpModuleName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPTStr)] string lpLibFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern short RegisterClassEx(in WNDCLASSEX wndClass);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr CreateWindowEx(
            WindowStylesEx dwExStyle,
            string? lpClassName,
            string? lpWindowName,
            WindowStyles dwStyle,
            int X,
            int Y,
            int nWidth,
            int nHeight,
            IntPtr hWndParent, // HWND?
            IntPtr hMenu, // HMENU?
            IntPtr hInstance, // HINSTANCE?
            IntPtr lpParam // LPVOID?
            );

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool IsWindowUnicode(IntPtr /* HWND */ hWnd);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MSG
        {
            public IntPtr hwnd;
            public uint message;
            public UIntPtr wParam;
            public IntPtr lParam;
            public int time;
            public POINT pt;
            public int lPrivate;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int PeekMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, PM wRemoveMsg);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool TranslateMessage(in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr DispatchMessage(in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* LRESULT */ SendMessage(IntPtr /* HWND */ hWnd, WM Msg, UIntPtr /* WPARAM */ wParam, IntPtr /* LPARAM */ lParam);

        [DllImport("user32.dll")]
        internal static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetWindowText(IntPtr hWnd, string? lpString);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetWindowPos(
            IntPtr hWnd,
            IntPtr hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            SetWindowPosFlags uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool AdjustWindowRect(ref RECT lpRect, WindowStyles dwStyle, bool bMenu);

        /// <summary>
        /// Sets the specified window's show state.
        /// </summary>
        /// <param name="hWnd">A handle to the window.</param>
        /// <param name="nCmdShow">
        /// Controls how the window is to be shown.
        /// This parameter is ignored the first time an application calls ShowWindow,
        /// if the program that launched the application provides a STARTUPINFO structure.
        /// Otherwise, the first time ShowWindow is called,
        /// the value should be the value obtained by the WinMain function in its nCmdShow parameter.
        /// In subsequent calls, this parameter can be one of the following values.
        /// </param>
        /// <returns>
        /// If the window was previously visible, the return value is nonzero
        /// If the window was previously hidden, the return value is zero.
        /// </returns>
        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr GetWindowLongPtr(IntPtr hWnd, GetGWLPIndex nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr SetWindowLongPtr(IntPtr hWnd, SetGWLPIndex nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr BeginPaint(IntPtr hWnd, out PAINTSTRUCT lpPaint);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool EndPaint(IntPtr hWnd, in PAINTSTRUCT lpPaint);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int FillRect(IntPtr hDC, in RECT lprc, IntPtr hbr);

        internal struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            public int Width => right - left;

            public int Height => bottom - top;

            public RECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }
        }

        internal struct PAINTSTRUCT
        {
            public IntPtr hdc; // HDC
            [MarshalAs(UnmanagedType.Bool)]
            public bool fErase;
            public RECT rcPaint;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fRestore;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fIncUpdate;
            public fixed byte rgbReserved[32];
        }

        internal struct PIXELFORMATDESCRIPTOR
        {
            public ushort nSize;
            public ushort nVersion;
            public PFD dwFlags;
            public PFDType iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public PFDPlane iLayerType;
            public byte bReserved;
            public uint dwLayerMask;
            public uint dwVisibleMask;
            public uint dwDamageMask;

            public static PIXELFORMATDESCRIPTOR Create()
            {
                PIXELFORMATDESCRIPTOR desc = default;
                unchecked
                {
                    desc.nSize = (ushort)Marshal.SizeOf<PIXELFORMATDESCRIPTOR>();
                }
                return desc;
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr GetDC(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HDC */ GetWindowDC(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int ReleaseDC(IntPtr /* HWND */ hWnd, IntPtr /* HDC */ hDC);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern int ChoosePixelFormat(
            IntPtr hDC, // HDC
            in PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern int DescribePixelFormat(
            IntPtr hDC, // HDC
            int iPixelFormat,
            uint nBytes,
            ref PIXELFORMATDESCRIPTOR ppfd
            );

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern bool SetPixelFormat(IntPtr hdc, int format, in PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern bool SwapBuffers(IntPtr hDC);

        // FIXME: Use LoadImage instead.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /*HCURSOR*/ LoadCursor(IntPtr /*HINSTANCE*/ hInstance, IDC lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /*HCURSOR*/ LoadImage(
            IntPtr /*HINSTANCE*/ hInstance,
            OCR name,
            ImageType type,
            int cx,
            int cy,
            LR fuLoad);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /*HCURSOR*/ LoadImage(
            IntPtr /*HINSTANCE*/ hInstance,
            OIC name,
            ImageType type,
            int cx,
            int cy,
            LR fuLoad);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /*HCURSOR*/ LoadImage(
            IntPtr /*HINSTANCE*/ hInstance,
            string name,
            ImageType type,
            int cx,
            int cy,
            LR fuLoad);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /*HCURSOR*/ SetCursor(IntPtr /*HCURSOR*/ hCursor);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool DestroyCursor(IntPtr /*HCURSOR*/ hCursor);

        internal struct ICONINFO
        {
            [MarshalAs(UnmanagedType.Bool)]
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr /*HBITMAP*/ hbmMask;
            public IntPtr /*HBITMAP*/ hbmColor;
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HICON or HCURSOR */ CreateIconIndirect(in ICONINFO piconinfo);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr /* HDC */ CreateCompatibleDC(IntPtr /* HDC */ hdc);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern bool DeleteDC(IntPtr /* HDC */ hdc);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr /* HBITMAP */ CreateCompatibleBitmap(IntPtr /* HDC */ hdc, int cx, int cy);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr /* HGDIOBJ */ SelectObject(IntPtr /* HDC */ hdc, IntPtr /* HGDIOBJ */ h);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern uint /* COLORREF */ GetPixel(IntPtr /* HDC */ hdc, int x, int y);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern int /* COLORREF */ SetPixel(IntPtr /* HDC */ hdc, int x, int y, uint /* COLORREF */ color);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern int /* COLORREF */ SetPixelV(IntPtr /* HDC */ hdc, int x, int y, uint /* COLORREF */ color);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool /* COLORREF */ DestroyIcon(IntPtr /* HICON or HCURSOR */ hIcon);

        internal struct BITMAP
        {
            public int bmType;
            public int bmWidth;
            public int bmHeight;
            public int bmWidthBytes;
            public ushort bmPlanes;
            public ushort bmBitsPixel;
            public IntPtr bmBits;
        }

        [DllImport("gdi32.dll", SetLastError = false)]
        internal static extern int GetObject(IntPtr /* HANDLE */ h, int c, IntPtr /* BITMAP */ pv);

        internal static int GetObject(IntPtr /* HANDLE */ h, int c, out BITMAP pv)
        {
            IntPtr rawptr = Marshal.AllocHGlobal(c + 4);
            IntPtr aligned = new IntPtr(4 * (((long)rawptr + 3) / 4));

            int res = GetObject(h, c, aligned);

            pv = Marshal.PtrToStructure<BITMAP>(aligned);

            Marshal.FreeHGlobal(rawptr);

            return res;
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern bool GetIconInfo(IntPtr /* HICON */ hIcon, [NotNullWhen(true)] out ICONINFO piconinfo);

        [DllImport("gdi32.dll", SetLastError = false)]
        internal static extern bool DeleteObject(IntPtr /* HGDIOBJ */ ho);

        internal struct BITMAPINFOHEADER
        {
            public uint biSize;
            public int biWidth;
            public int biHeight;
            public ushort biPlanes;
            public ushort biBitCount;
            public BI biCompression;
            public uint biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public uint biClrUsed;
            public uint biClrImportant;
        }

        internal struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        }

        /*internal struct BITMAPINFO
        {
            public BITMAPINFOHEADER bmiHeader;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
            public RGBQUAD[] bmiColors;
        }*/

        internal struct BITMAPINFO
        {
            public BITMAPINFOHEADER bmiHeader;
            public RGBQUAD bmiColors;
            public RGBQUAD bmiColors2;
        }

        [DllImport("gdi32.dll", SetLastError = false)]
        internal static extern int GetDIBits(
            IntPtr /* HDC */ hdc,
            IntPtr /* HBITMAP */ hbm,
            uint start,
            uint cLines,
            void* lpvBits,
            ref BITMAPINFO lpbmi,
            DIB usage);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HICON */ CopyIcon(IntPtr /* HICON */ hIcon);

        internal struct CURSORINFO
        {
            public uint cbSize;
            public uint flags;
            public IntPtr /*HCURSOR*/ hCursor;
            public POINT ptScreenPos;
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool GetCursorInfo(ref CURSORINFO pci);

        internal struct CIEXYZ
        {
            public uint /* FXPT2DOT30 */ ciexyzX;
            public uint /* FXPT2DOT30 */ ciexyzY;
            public uint /* FXPT2DOT30 */ ciexyzZ;
        }

        internal struct CIEXYZTRIPLE
        {
            public CIEXYZ ciexyzRed;
            public CIEXYZ ciexyzGreen;
            public CIEXYZ ciexyzBlue;
        }

        internal struct BITMAPV5HEADER
        {
            public uint bV5Size;
            public int bV5Width;
            public int bV5Height;
            public ushort bV5Planes;
            public ushort bV5BitCount;
            public BI bV5Compression;
            public uint bV5SizeImage;
            public int bV5XPelsPerMeter;
            public int bV5YPelsPerMeter;
            public uint bV5ClrUsed;
            public uint bV5ClrImportant;
            public uint bV5RedMask;
            public uint bV5GreenMask;
            public uint bV5BlueMask;
            public uint bV5AlphaMask;
            public uint bV5CSType;
            public CIEXYZTRIPLE bV5Endpoints;
            public uint bV5GammaRed;
            public uint bV5GammaGreen;
            public uint bV5GammaBlue;
            public uint bV5Intent;
            public uint bV5ProfileData;
            public uint bV5ProfileSize;
            public uint bV5Reserved;
        }

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr /* HBITMAP */ CreateDIBSection(
            IntPtr /* HDC */ hdc,
            in BITMAPINFO pbmi,
            DIB usage,
            out IntPtr ppvBits,
            IntPtr /* HANDLE */ hSection,
            uint offset);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr /* HBITMAP */ CreateDIBSection(
            IntPtr /* HDC */ hdc,
            in BITMAPV5HEADER pbmi,
            DIB usage,
            out IntPtr ppvBits,
            IntPtr /* HANDLE */ hSection,
            uint offset);

        [DllImport("gdi32.dll", SetLastError = true)]
        internal static extern IntPtr /* HBITMAP */ CreateBitmap(
            int nWidth,
            int nHeight,
            uint nPlanes,
            uint nBitCount,
            IntPtr lpBits);

        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HCURSOR */ LoadCursorFromFile(string /* LPCSTR */ lpFileName);

        [DllImport("user32", SetLastError = false)]
        internal static extern int GetSystemMetrics(SystemMetric nIndex);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern bool EnumDisplayMonitors(IntPtr /* HDC */ hdc, in RECT /* LPRECT */ lprcClip, EnumMonitorsDelegate lpfnEnum, IntPtr dwData);

        internal delegate bool EnumMonitorsDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern bool GetMonitorInfo(IntPtr /* HMONITOR */ hMonitor, [In, Out] ref MONITORINFO lpmi);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern bool GetMonitorInfo(IntPtr /* HMONITOR */ hMonitor, [In, Out] ref MONITORINFOEX lpmi);

        internal struct MONITORINFO
        {
            public uint cbSize;
            public RECT rcMonitor;
            public RECT rcWork;
            public uint dwFlags;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct MONITORINFOEX
        {
            public uint cbSize;
            public RECT rcMonitor;
            public RECT rcWork;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
            public string szDevice;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern bool EnumDisplaySettings(string lpszDeviceName, uint iModeNum, [In, Out] ref DEVMODE lpDevMode);

        internal struct POINTL
        {
            public int X;
            public int Y;

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
            public string dmDeviceName;
            public ushort dmSpecVersion;
            public ushort dmDriverVersion;
            public ushort dmSize;
            public ushort dmDriverExtra;
            public DM dmFields;
            public POINTL dmPosition;
            public uint dmDisplayOrientation;
            public DMDFO dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
            public string dmFormName;
            public ushort dmLogPixels;
            public uint dmBitsPerPel;
            public uint dmPelsWidth;
            public uint dmPelsHeight;
            public uint dmDisplayFlags;
            public uint dmDisplayFrequency;
            public uint dmICMMethod;
            public uint dmICMIntent;
            public uint dmMediaType;
            public uint dmDitherType;
            public uint dmReserved1;
            public uint dmReserved2;
            public uint dmPanningWidth;
            public uint dmPanningHeight;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, [In, Out] ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct DISPLAY_DEVICE
        {
            public uint cb;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DeviceName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceString;
            public DisplayDeviceStateFlags StateFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceKey;
        }

        [DllImport("imm32.dll", SetLastError = false)]
        internal static extern IntPtr /* HIMC */ ImmGetContext(IntPtr /* HWND */ hwnd);

        [DllImport("imm32.dll", SetLastError = false)]
        internal static extern bool ImmReleaseContext(IntPtr /* HWND */ hwnd, IntPtr /* HIMC */ himc);

        [DllImport("imm32.dll", SetLastError = false)]
        internal static extern bool ImmSetCompositionWindow(IntPtr /* HIMC */ hmic, in COMPOSITIONFORM lpCompForm);

        internal struct COMPOSITIONFORM
        {
            public CFS dwStyle;
            public POINT ptCurrentPos;
            public RECT rcArea;
        }

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern IntPtr /* HKL */ GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern bool GetKeyboardLayoutName([Out] StringBuilder pwszKLID);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int /* LSTATUS */ RegOpenKeyEx(
            IntPtr /* HKEY */ hKey,
            string lpSubKey,
            RegOption ulOptions,
            AccessMask /* REGSAM */ samDesired,
            out IntPtr /* PHKEY */ phkResult);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern int /* LSTATUS */ RegGetValue(
            IntPtr /* HKEY */ hkey,
            string? lpSubKey,
            string? lpValue,
            RRF dwFlags,
            out RegValueType pdwType,
            byte* pvData,
            ref uint pcbData);

        internal static int /* LSTATUS */ RegGetValue(
            IntPtr /* HKEY */ hkey,
            string? lpSubKey,
            string? lpValue,
            RRF dwFlags,
            out RegValueType pdwType,
            Span<byte> pvData,
            ref uint pcbData)
        {
            fixed (byte* data = &MemoryMarshal.GetReference(pvData))
            {
                return RegGetValue(hkey, lpSubKey, lpValue, dwFlags, out pdwType, data, ref pcbData);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int GetKeyboardLayoutList(int nBuff, IntPtr* lpList);

        internal static int GetKeyboardLayoutList(int nBuff, Span<IntPtr> lpList)
        {
            fixed (IntPtr* list = &MemoryMarshal.GetReference(lpList))
            {
                return GetKeyboardLayoutList(nBuff, list);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HKL */ ActivateKeyboardLayout(IntPtr /* HKL */ hkl, uint Flags);
    }
}
