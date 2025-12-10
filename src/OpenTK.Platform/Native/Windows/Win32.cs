using OpenTK.Graphics.Vulkan;
using OpenTK.Graphics.Wgl;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using static OpenTK.Platform.Native.Windows.Win32;

namespace OpenTK.Platform.Native.Windows
{
    // FIXME: Maybe start using this...
    internal readonly struct BOOL : IEquatable<BOOL>
    {
        public readonly int Value;

        public BOOL(bool value)
        {
            Value = value ? 1 : 0;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is BOOL @bool && Equals(@bool);
        }

        public readonly bool Equals(BOOL other)
        {
            return ((bool)this) == ((bool)other);
        }

        public readonly override int GetHashCode()
        {
            return HashCode.Combine((bool)this);
        }

        public readonly override string? ToString()
        {
            return this ? bool.TrueString : bool.FalseString;
        }

        public static bool operator ==(BOOL left, BOOL right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BOOL left, BOOL right)
        {
            return !(left == right);
        }

        public static bool operator true(BOOL a)
        {
            return a.Value != 0;
        }

        public static bool operator false(BOOL a)
        {
            return a.Value == 0;
        }

        public static implicit operator bool(BOOL @bool) => @bool;
        public static implicit operator BOOL(bool @bool) => new BOOL(@bool);
    }

#pragma warning disable CS0649 // Field 'field' is never assigned to, and will always have its default value 'value'
    internal static unsafe class Win32
    {
        internal const int USER_DEFAULT_SCREEN_DPI = 96;

        internal const int LoWordMask = 0x0000_FFFF;
        internal const int HiWordMask = unchecked((int)0xFFFF_0000);

        internal static ushort LOWORD(nint w) => LOWORD((int)w);
        internal static ushort LOWORD(int w) => (ushort)(w & 0xFFFF);

        internal static ushort HIWORD(nint w) => HIWORD((int)w);
        internal static ushort HIWORD(int w) => (ushort)((w >> 16) & 0xFFFF);

        internal static int GET_X_LPARAM(IntPtr lParam) => (short)(lParam.ToInt64() & LoWordMask);
        internal static int GET_Y_LPARAM(IntPtr lParam) => (short)((lParam.ToInt64() >> 16) & LoWordMask);

        // FIXME: Potentially change HTCLIENT into an enum later.

        /// <summary>
        /// In client area.
        /// </summary>
        internal const int HTCLIENT = 1;

        internal const int CW_USEDEFAULT = -1;

        internal const int ERROR_SUCCESS = 0;
        internal const int ERROR_FILE_NOT_FOUND = 0x2;
        internal const int ERROR_INVALID_PARAMETER = 87;
        /// <summary>
        /// The data area passed to a system call is too small.
        /// </summary>
        internal const int ERROR_INSUFFICIENT_BUFFER = 0x7A;

        internal const int ERROR_MORE_DATA = 0xEA;

        internal const int CCHDEVICENAME = 32;
        internal const int CCHFORMNAME = 32;

        internal const int EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001;

        internal const int KL_NAMELENGTH = 9;

        internal const int ICON_SMALL = 0;
        internal const int ICON_BIG = 1;

        internal const int S_OK = 0x0;
        internal const int S_FALSE = 0x1;

        internal const int E_INVALIDARG = unchecked((int)0x80070057);
        internal const int E_ACCESSDENIED = unchecked((int)0x80070005);
        internal const int E_OUTOFMEMORY = unchecked((int)0x8007000E);
        internal const int E_FAIL = unchecked((int)0x80004005);

        internal const IntPtr TD_WARNING_ICON         = unchecked((ushort)-1);
        internal const IntPtr TD_ERROR_ICON           = unchecked((ushort)-2);
        internal const IntPtr TD_INFORMATION_ICON     = unchecked((ushort)-3);
        internal const IntPtr TD_SHIELD_ICON          = unchecked((ushort)-4);

        internal const IntPtr INVALID_HANDLE_VALUE = -1;

        internal const int LOCALE_NAME_MAX_LENGTH = 85;

        internal const int SEVERITY_SUCCESS = 0;
        internal const int SEVERITY_ERROR = 1;

        internal const int FACILITY_WIN32 = 7;

        internal const int ERROR_READ_FAULT = 30;
        internal const int ERROR_INVALID_ACCESS = 12;
        internal const int ERROR_BUSY = 170;

        internal static int MAKE_HRESULT(int sev, int fac, int code) => sev << 31 | fac << 16 | code;

        // Usefull extension methods for dealing with span string buffers.
        internal static Span<char> SliceAtFirstNull(this Span<char> span)
        {
            int index = span.IndexOf("\0");
            return index == -1 ? span : span.Slice(0, index);
        }

        internal static ReadOnlySpan<char> SliceAtFirstNull(this ReadOnlySpan<char> span)
        {
            int index = span.IndexOf("\0");
            return index == -1 ? span : span.Slice(0, index);
        }

        internal static int /* HRESULT */ HRESULT_FROM_WIN32(uint error) => (unchecked(error <= 0 ? (int)error : (int)(((uint)error & 0x0000FFFF) | 0x80070000)));

        [DllImport("kernel32.dll", SetLastError = false)]
        internal static extern uint GetLastError();

        // LRESULT WNDPROC(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
        internal delegate IntPtr WNDPROC(IntPtr hWnd, WM uMsg, UIntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr DefWindowProc(IntPtr hWnd, WM uMsg, UIntPtr wParam, IntPtr lParam);

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
        internal static extern IntPtr /* HMODULE */ GetModuleHandle(string? lpModuleName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPTStr)] string lpLibFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HMODULE */ LoadLibraryEx([MarshalAs(UnmanagedType.LPTStr)] string lpLibFileName, IntPtr /* HANDLE */ hFile, LoadLibraryFlags dwFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HMODULE */ LoadLibraryEx([In, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpLibFileName, IntPtr /* HANDLE */ hFile, LoadLibraryFlags dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool FreeLibrary(IntPtr /* HMODULE */ hLibModule);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern short RegisterClassEx(in WNDCLASSEX wndClass);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool UnregisterClass(string lpClassName, IntPtr /* HINSTANCE */ hInstance);

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
            public WM message;
            public UIntPtr wParam;
            public IntPtr lParam;
            public int time;
            public POINT pt;
            public int lPrivate;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool PeekMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, PM wRemoveMsg);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool TranslateMessage(in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr DispatchMessage(in MSG lpMsg);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* LRESULT */ SendMessage(IntPtr /* HWND */ hWnd, WM Msg, UIntPtr /* WPARAM */ wParam, IntPtr /* LPARAM */ lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool PostMessage(IntPtr /* HWND */ hWnd, WM Msg, UIntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern uint RegisterWindowMessage([MarshalAs(UnmanagedType.LPTStr)] string /* LPCSTR */ lpString);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ChangeWindowMessageFilterEx(IntPtr /* HWND */ hwnd, uint message, MSGFLT action, IntPtr /* PCHANGEFILTERSTRUCT */ pChangeFilterStruct);

        [DllImport("user32.dll")]
        internal static extern int GetMessageTime();

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

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(
            IntPtr /* HWND */ hWnd,
            int X,
            int Y,
            int nWidth,
            int nHeight,
            bool bRepaint);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern bool RedrawWindow(
            IntPtr /* HWND */ hWnd,
            IntPtr /* const RECT* */ lprcUpdate,
            IntPtr /* HRGN */ hrgnUpdate,
            RDW flags);

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

        [DllImport("user32.dll")]
        internal static extern int ShowCursor(bool bShow);

        [DllImport("user32.dll")]
        internal static extern IntPtr /* HWND */ SetCapture(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool ReleaseCapture();

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool BringWindowToTop(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll")]
        internal static extern IntPtr /* HWND */ GetForegroundWindow();

        [DllImport("user32.dll")]
        internal static extern bool SetForegroundWindow(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll")]
        internal static extern IntPtr /* HWND */ GetFocus();

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HWND */ SetFocus(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll")]
        internal static extern bool FlashWindow(IntPtr /* HWND */ hWnd, bool bInvert);

        [DllImport("user32.dll")]
        internal static extern bool FlashWindowEx(in FLASHWINFO pfwi);

        public struct FLASHWINFO {
            public uint cbSize;
            public IntPtr /* HWND */ hwnd;
            public FLASHW dwFlags;
            public uint uCount;
            public uint dwTimeout;
        }
    
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool AdjustWindowRect(ref RECT lpRect, WindowStyles dwStyle, bool bMenu);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool AdjustWindowRectEx(ref RECT lpRect, WindowStyles dwStyle, bool bMenu, WindowStylesEx dwExStyle);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool AdjustWindowRectExForDpi(ref RECT lpRect, WindowStyles dwStyle, bool bMenu, WindowStylesEx dwExStyle, uint dpi);

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

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern bool IsIconic(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern bool IsZoomed(IntPtr /* HWND */ hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern UIntPtr GetClassLongPtr(IntPtr /* HWND */ hWnd, GCLP nIndex);

        internal static IntPtr GetWindowLongPtr(IntPtr hWnd, GetGWLPIndex nIndex)
        {
            if (Environment.Is64BitProcess)
            {
                return GetWindowLongPtr(hWnd, nIndex);
            }
            else
            {
                return GetWindowLong(hWnd, nIndex);
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            static extern int GetWindowLong(IntPtr hWnd, GetGWLPIndex nIndex);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            static extern IntPtr GetWindowLongPtr(IntPtr hWnd, GetGWLPIndex nIndex);
        }

        internal static IntPtr SetWindowLongPtr(IntPtr hWnd, SetGWLPIndex nIndex, IntPtr dwNewLong)
        {
            if (Environment.Is64BitProcess)
            {
                return SetWindowLongPtr(hWnd, nIndex, dwNewLong);
            }
            else
            {
                return SetWindowLong(hWnd, nIndex, (int)dwNewLong);
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            static extern int SetWindowLong(IntPtr hWnd, SetGWLPIndex nIndex, int dwNewLong);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            static extern IntPtr SetWindowLongPtr(IntPtr hWnd, SetGWLPIndex nIndex, IntPtr dwNewLong);
        }

        

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr BeginPaint(IntPtr hWnd, out PAINTSTRUCT lpPaint);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool EndPaint(IntPtr hWnd, in PAINTSTRUCT lpPaint);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int FillRect(IntPtr hDC, in RECT lprc, IntPtr hbr);

        [DllImport("shell32.dll")]
        internal static extern void DragAcceptFiles(IntPtr /* HWND */ hWnd, bool fAccept);

        [DllImport("shell32.dll")]
        internal static extern bool DragQueryPoint(IntPtr /* HDROP */ hDrop, out POINT ppt);

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        internal static extern uint DragQueryFile(IntPtr /* HDROP */ hDrop, uint iFile, [Out]StringBuilder? lpszFile, uint cch);

        [DllImport("shell32.dll")]
        internal static extern void DragFinish(IntPtr /* HDROP */ hDrop);

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

        // FIXME: The heck is going on with pszIconPath?
        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HICON */ ExtractAssociatedIcon(IntPtr /* HINSTANCE */ hInst, string pszIconPath, ref ushort piIcon);

        // FIXME: Use LoadImage instead.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /*HCURSOR*/ LoadCursor(IntPtr /*HINSTANCE*/ hInstance, string lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /*HCURSOR*/ LoadCursor(IntPtr /*HINSTANCE*/ hInstance, IDC lpCursorName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HICON */ LoadIcon(IntPtr /* HINSTANCE */ hInstance, string lpIconName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HICON */ LoadIcon(IntPtr /* HINSTANCE */ hInstance, IDI lpIconName);

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
            IDI name,
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

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int LookupIconIdFromDirectoryEx(byte* presbits, bool fIcon, int cxDesired, int cyDesired, LR Flags);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HICON */ CreateIconFromResource(byte* presbits, uint dwResSize, bool fIcon, uint dwVer);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HICON */ CreateIconFromResourceEx(byte* presbits, uint dwResSize, bool fIcon, uint dwVer, int cxDesired, int cyDesired, LR Flags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HRSRC */ FindResource(IntPtr /* HMODULE */ hModule, string lpName, string lpType);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HRSRC */ FindResource(IntPtr /* HMODULE */ hModule, string lpName, IntPtr lpType);

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

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr /* HDC */ CreateDC([MarshalAs(UnmanagedType.LPTStr)] string? pwszDriver, [MarshalAs(UnmanagedType.LPTStr)] string pwszDevice, [MarshalAs(UnmanagedType.LPTStr)] string? pszPort, IntPtr pdm);

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
            public CSType bV5CSType;
            public CIEXYZTRIPLE bV5Endpoints;
            public uint bV5GammaRed;
            public uint bV5GammaGreen;
            public uint bV5GammaBlue;
            public GamutMappingIntent bV5Intent;
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
        internal static extern bool EnumDisplayDevices(string? lpDevice, uint iDevNum, [In, Out] ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

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

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern uint GetDpiForWindow(IntPtr /* HWND */ hwnd);

        [DllImport("shcore.dll", SetLastError = false)]
        internal static extern int /* HRESULT */ GetDpiForMonitor(
            IntPtr /* HMONITOR */ hmonitor,
            MonitorDpiType dpiType,
            out uint dpiX,
            out uint dpiY);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern bool SetProcessDPIAware();

        [DllImport("shcore.dll", SetLastError = false)]
        internal static extern int /* HRESULT */ SetProcessDpiAwareness(ProcessDPIAwareness value);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool SetProcessDpiAwarenessContext(IntPtr /* DpiAwarenessContext */ value);

        [DllImport("user32.dll")]
        internal static extern IntPtr /* HMONITOR */ MonitorFromWindow(IntPtr /* HWND */ hwnd, MonitorDefaultTo dwFlags);

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

        [DllImport("imm32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern long ImmGetCompositionString(
                  IntPtr /* HIMC */ context /* unnamedParam1 */,
                  GCS @string /* unnamedParam2 */,
                  [Out] StringBuilder? lpBuf,
                  uint dwBufLen);

        
        internal static unsafe long ImmGetCompositionString(
                  IntPtr /* HIMC */ context /* unnamedParam1 */,
                  GCS @string /* unnamedParam2 */,
                  Span<byte> lpBuf,
                  uint dwBufLen)
        {
            fixed (byte* buf = lpBuf)
            {
                return ImmGetCompositionString(context, @string, buf, dwBufLen);
            }

            [DllImport("imm32.dll", CharSet = CharSet.Auto, SetLastError = false)]
            static extern long ImmGetCompositionString(
                  IntPtr /* HIMC */ context /* unnamedParam1 */,
                  GCS @string /* unnamedParam2 */,
                  byte* lpBuf,
                  uint dwBufLen);
        }

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern IntPtr /* HKL */ GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern bool GetKeyboardLayoutName([Out] StringBuilder pwszKLID);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern uint MapVirtualKey(uint uCode, MAPVK uMapType);

        [DllImport("user32.dll")]
        internal static extern short GetKeyState(VK nVirtKey);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool GetKeyboardState(byte* lpKeyState);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int /* LSTATUS */ RegOpenKeyEx(
            UIntPtr /* HKEY */ hKey,
            string lpSubKey,
            RegOption ulOptions,
            AccessMask /* REGSAM */ samDesired,
            out UIntPtr /* PHKEY */ phkResult);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern int /* LSTATUS */ RegGetValue(
            UIntPtr /* HKEY */ hkey,
            string? lpSubKey,
            string? lpValue,
            RRF dwFlags,
            out RegValueType pdwType,
            byte* pvData,
            ref uint pcbData);

        internal static int /* LSTATUS */ RegGetValue<T>(
            UIntPtr /* HKEY */ hkey,
            string? lpSubKey,
            string? lpValue,
            RRF dwFlags,
            out RegValueType pdwType,
            Span<T> pvData,
            ref uint pcbData) where T : unmanaged
        {
            fixed (T* data = &MemoryMarshal.GetReference(pvData))
            {
                return RegGetValue(hkey, lpSubKey, lpValue, dwFlags, out pdwType, (byte*)data, ref pcbData);
            }
        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static unsafe extern uint /* LWSTDAPI */ SHLoadIndirectString(char* pszSource, char* pszOutBuf, uint cchOutBuf, void** ppvReserved);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static unsafe extern uint /* LSTATUS */ RegLoadMUIString(IntPtr /* HKEY */ hKey, char* pszValue, char* pszOutBuf, uint cbOutBuf, out uint pcbData, uint flags, char* pszDirectory);

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

        internal struct TRACKMOUSEEVENT
        {
            public uint cbSize;
            public TME dwFlags;
            public IntPtr /* HWND */ hwndTrack;
            public uint dwHoverTime;
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool OpenClipboard(IntPtr /* HWND */ hWndNewOwner);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool CloseClipboard();

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool EmptyClipboard();

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HANDLE */ SetClipboardData(CF uFormat, IntPtr /* HANDLE */ hMem);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HANDLE */ GetClipboardData(CF uFormat);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern CF EnumClipboardFormats(CF format);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool IsClipboardFormatAvailable(CF fromat);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern CF RegisterClipboardFormat(string lpszFormat);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetClipboardFormatName(CF format, [Out] StringBuilder lpszFormatName, int cchMaxCount);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr /* HGLOBAL */ GlobalAlloc(GMEM uFlags, ulong dwBytes);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr /* HGLOBAL */ GlobalFree(IntPtr /* HGLOBAL */ hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr /* LPVOID */ GlobalLock(IntPtr /* HGLOBAL */ hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool GlobalUnlock(IntPtr /* HGLOBAL */ hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern ulong GlobalSize(IntPtr /* HGLOBAL */ hMem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SystemParametersInfo(SPI uiAction, uint uiParam, void* pvParam, SPIF fWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SystemParametersInfo(SPI uiAction, uint uiParam, out uint pvParam, SPIF fWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SystemParametersInfo(SPI uiAction, uint uiParam, ref HIGHCONTRAST pvParam, SPIF fWinIni);

        internal struct HIGHCONTRAST
        {
            public uint cbSize;
            public HCF dwFlags;
            public IntPtr /* LPSTR/LPWSTR */ lpszDefaultScheme;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SHGetFileInfo(string pszPath, FileAttribute dwFileAttributes, [In, Out] SHFILEINFO psfi, uint cbFileInfo, SHGFI uFlags);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct SHFILEINFO
        {
            public IntPtr /* HICON */ hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260 /* MAX_PATH */)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }

        [DllImport("gdi32.dll")]
        internal static extern int /* NTSTATUS */ D3DKMTWaitForVerticalBlankEvent(in D3DKMT_WAITFORVERTICALBLANKEVENT unnamedParam1);
        internal struct D3DKMT_WAITFORVERTICALBLANKEVENT
        {
            public uint /* D3DKMT_HANDLE */ hAdapter;
            public uint /* D3DKMT_HANDLE */ hDevice;
            public uint /* D3DDDI_VIDEO_PRESENT_SOURCE_ID */ VidPnSourceId;
        }

        [DllImport("gdi32.dll")]
        internal static extern int /* NTSTATUS */ D3DKMTOpenAdapterFromHdc(D3DKMT_OPENADAPTERFROMHDC* unnamedParam1);

        internal struct D3DKMT_OPENADAPTERFROMHDC
        {
            public IntPtr /* HDC */ hDc;
            public uint /* D3DKMT_HANDLE */ hAdapter;
            public LUID AdapterLuid;
            public uint /* D3DDDI_VIDEO_PRESENT_SOURCE_ID */ VidPnSourceId;
        }

        internal struct LUID
        {
            public uint LowPart;
            public int HighPart;
        }

        [DllImport("dwmapi.dll")]
        internal static extern int /* HRESULT */ DwmFlush();

        [DllImport("dwmapi.dll")]
        internal static extern int /* HRESULT */ DwmIsCompositionEnabled(out bool pfEnabled);

        [DllImport("dwmapi.dll")]
        internal static extern int /* HRESULT */ DwmGetWindowAttribute(
            IntPtr /* HWND */ hwnd,
            DWMWindowAttribute dwAttribute,
            out IntPtr pvAttribute,
            uint cbAttribute);

        [DllImport("dwmapi.dll")]
        internal static extern int /* HRESULT */ DwmGetWindowAttribute(
            IntPtr /* HWND */ hwnd,
            DWMWindowAttribute dwAttribute,
            out RECT pvAttribute,
            uint cbAttribute);

        [DllImport("dwmapi.dll")]
        internal static unsafe extern int /* HRESULT */ DwmSetWindowAttribute(
            IntPtr /* HWND */ hwnd,
            DWMWindowAttribute dwAttribute,
            ref uint pvAttribute,
            uint cbAttribute);

        [DllImport("dwmapi.dll")]
        internal static unsafe extern int /* HRESULT */ DwmSetWindowAttribute(
            IntPtr /* HWND */ hwnd,
            DWMWindowAttribute dwAttribute,
            void* pvAttribute,
            uint cbAttribute);

        [DllImport("kernel32.dll")]
        internal static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool GetSystemPowerStatus(out SystemPowerStatus lpSystemPowerStatus);

        internal struct SystemPowerStatus
        {
            public ACLineStatus ACLineStatus;
            public BatteryFlags BatteryFlag;
            public byte BatteryLifePercent;
            public SystemStatusFlags SystemStatusFlag;
            public int BatteryLifeTime;
            public int BatteryFullLifeTime;
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool GetClipCursor(out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool ClipCursor(ref RECT lpRect);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetUserDefaultLocaleName([Out] StringBuilder lpLocaleName, int cchLocaleName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int LCIDToLocaleName(
              int /* LCID */ Locale,
              [Out] StringBuilder lpName,
              int cchName,
              int dwFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetLocaleInfoEx(
              StringBuilder lpLocaleName,
              LCType LCType,
              [Out] StringBuilder? lpLCData,
              int cchData);

        internal struct DEV_BROADCAST_DEVICEINTERFACE
        {
            public uint dbcc_size;
            public DBTDevType dbcc_devicetype;
            public uint dbcc_reserved;
            public Guid dbcc_classguid;
            public fixed char dbcc_name[1];
        }

        public static readonly Guid GUID_DEVINTERFACE_HID = new Guid(0x4D1E55B2, 0xF16F, 0x11CF, 0x88, 0xCB, 0x00, 0x11, 0x11, 0x00, 0x00, 0x30);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr /* HDEVNOTIFY */ RegisterDeviceNotification(
              IntPtr /* HANDLE */ hRecipient,
              DEV_BROADCAST_DEVICEINTERFACE NotificationFilter,
              DEVICE_NOTIFY Flags);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool UnregisterDeviceNotification(IntPtr /* HDEVNOTIFY */ Handle);

        internal struct MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool GetPhysicallyInstalledSystemMemory(out ulong TotalMemoryInKilobytes);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HPOWERNOTIFY */ RegisterSuspendResumeNotification(IntPtr /* HANDLE */ hRecipient, DEVICE_NOTIFY Flags);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool UnregisterSuspendResumeNotification(IntPtr /* HPOWERNOTIFY */ Handle);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool AddClipboardFormatListener(IntPtr /* HWND */ hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool RemoveClipboardFormatListener(IntPtr /* HWND */ hwnd);

        internal struct WINDOWPLACEMENT
        {
            public uint length;
            public WPF flags;
            public ShowWindowCommands showCmd;
            public POINT ptMinPosition;
            public POINT ptMaxPosition;
            public RECT rcNormalPosition;
            public RECT rcDevice;
        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool SetWindowPlacement(IntPtr /* HWND */ hWnd, in WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool GetWindowPlacement(IntPtr /* HWND */ hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern bool LockWindowUpdate(IntPtr /* HWND */ hWndLock);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HDWP */ BeginDeferWindowPos(int nNumWindows);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr /* HDWP */ DeferWindowPos(
            IntPtr /* HDWP */ hWinPosInfo,
            IntPtr /* HWND */ hWnd,
            IntPtr /* HWND */ hWndInsertAfter,
            int x,
            int y,
            int cx,
            int cy,
            SetWindowPosFlags uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool EndDeferWindowPos(IntPtr /* HDWP */ hWinPosInfo);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern DispChange ChangeDisplaySettingsExW(
            [MarshalAs(UnmanagedType.LPWStr)] string? lpszDeviceName,
            ref DEVMODE lpDevMode,
            IntPtr /* HWND */ hwnd,
            CDS dwflags,
            IntPtr lParam);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern DispChange ChangeDisplaySettingsExW(
            [MarshalAs(UnmanagedType.LPWStr)] string? lpszDeviceName,
            IntPtr lpDevMode,
            IntPtr /* HWND */ hwnd,
            CDS dwflags,
            IntPtr lParam);

        [DllImport("comdlg32.dll")]
        internal static extern uint CommDlgExtendedError();

        [DllImport("comdlg32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetOpenFileNameW(ref OPENFILENAMEW unnamedParam1);

        [DllImport("comdlg32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetSaveFileNameW(ref OPENFILENAMEW unnamedParam1);

        internal struct OPENFILENAMEW
        {
            public uint lStructSize;
            public IntPtr /* HWND */ hwndOwner;
            public IntPtr /* HINSTANCE */ hInstance;
            public char* lpstrFilter;
            public char* lpstrCustomFilter;
            public uint nMaxCustFilter;
            public uint nFilterIndex;
            public char* lpstrFile;
            public uint nMaxFile;
            public char* lpstrFileTitle;
            public uint nMaxFileTitle;
            public char* lpstrInitialDir;
            public char* lpstrTitle;
            public OFN Flags;
            public ushort nFileOffset;
            public ushort nFileExtension;
            public char* lpstrDefExt;
            public IntPtr /* LPARAM */ lCustData;
            public IntPtr /* LPOFNHOOKPROC */ lpfnHook;
            public char* lpTemplateName;
            public void* pvReserved;
            public uint dwReserved;
            public uint FlagsEx;
        }

        [DllImport("comctl32.dll")]
        internal static extern int /* HRESULT */ TaskDialogIndirect(in TASKDIALOGCONFIG pTaskConfig, ref int pnButton, ref int pnRadioButton, ref int pfVerificationFlagChecked);

        // We need to pack this struct to get the correct layout.
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TASKDIALOGCONFIG
        {
            public uint cbSize;
            public IntPtr /* HWND */ hwndParent;
            public IntPtr /* HINSTANCE */ hInstance;
            public TASKDIALOG_FLAGS dwFlags;
            public TASKDIALOG_COMMON_BUTTON_FLAGS dwCommonButtons;
            public char* pszWindowTitle;
            //union {
            public IntPtr /* HICON */ hMainIcon;
            //PCWSTR pszMainIcon;
            //} DUMMYUNIONNAME;
            public char* pszMainInstruction;
            public char* pszContent;
            public uint cButtons;
            public TASKDIALOG_BUTTON* pButtons;
            public TaskDialogButtonID nDefaultButton;
            public uint cRadioButtons;
            public TASKDIALOG_BUTTON* pRadioButtons;
            public int nDefaultRadioButton;
            public char* pszVerificationText;
            public char* pszExpandedInformation;
            public char* pszExpandedControlText;
            public char* pszCollapsedControlText;
            //union {
            public IntPtr /* HICON */ hFooterIcon;
            //PCWSTR pszFooterIcon;
            //} DUMMYUNIONNAME2;
            public char* pszFooter;
            public delegate* unmanaged[Cdecl]<IntPtr, TDN, UIntPtr, IntPtr, IntPtr, int> pfCallback;
            public nuint lpCallbackData;
            public uint cxWidth;
        }

        internal struct TASKDIALOG_BUTTON
        {
            public int nButtonID;
            public char* pszButtonText;
        }

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        internal delegate int /* HRESULT */ PFTASKDIALOGCALLBACK(IntPtr /* HWND */ hwnd, TDN msg, UIntPtr wParam, IntPtr lParam, IntPtr lpRefData);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool RegisterRawInputDevices(in RAWINPUTDEVICE pRawInputDevices, uint uiNumDevices, uint cbSize);

        internal struct RAWINPUTDEVICE
        {
            public HIDUsagePage usUsagePage;
            public ushort usUsage;
            public RIDEV dwFlags;
            public IntPtr /* HWND */ hwndTarget;
        }

        [DllImport("user32.dll")]
        internal static extern IntPtr /* LRESULT */ DefRawInputProc(IntPtr /* PRAWINPUT* */ paRawInput, int nInput, uint cbSizeHeader);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern uint GetRawInputData(
           IntPtr /* HRAWINPUT */ hRawInput,
           RID uiCommand,
           [Out] byte[]? pData,
           ref uint pcbSize,
           uint cbSizeHeader);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern uint GetRawInputData(
            IntPtr /* HRAWINPUT */ hRawInput,
            RID uiCommand,
            ref RAWINPUTHEADER pData,
            ref uint pcbSize,
            uint cbSizeHeader);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern uint GetRawInputData(
            IntPtr /* HRAWINPUT */ hRawInput,
            RID uiCommand,
            ref RAWINPUT pData,
            ref uint pcbSize,
            uint cbSizeHeader);

        internal struct RAWINPUTHEADER
        {
            public RIM dwType;
            public uint dwSize;
            public IntPtr /* HANDLE */ hDevice;
            public UIntPtr /* WPARAM */ wParam;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct RAWMOUSE
        {
            [FieldOffset(0)]
            public RawMouseFlags usFlags;
            [FieldOffset(4)]
            public uint ulButtons;
            [FieldOffset(4)]
            public ushort usButtonFlags;
            [FieldOffset(6)]
            public ushort usButtonData;
            [FieldOffset(8)]
            public uint ulRawButtons;
            [FieldOffset(12)]
            public int lLastX;
            [FieldOffset(16)]
            public int lLastY;
            [FieldOffset(20)]
            public uint ulExtraInformation;
        }

        internal struct RAWKEYBOARD
        {
            public ushort MakeCode;
            public ushort Flags;
            public ushort Reserved;
            public ushort VKey;
            public uint Message;
            public uint ExtraInformation;
        }

        internal struct RAWHID
        {
            public uint dwSizeHid;
            public uint dwCount;
            public fixed byte bRawData[1];
        }

        internal unsafe struct RAWINPUT
        {
            public RAWINPUTHEADER header;
            public DUMMYUNIONNAME data;

            [StructLayout(LayoutKind.Explicit)]
            public struct DUMMYUNIONNAME
            {
                [FieldOffset(0)]
                public RAWMOUSE mouse;
                [FieldOffset(0)]
                public RAWKEYBOARD keyboard;
                [FieldOffset(0)]
                public RAWHID hid;
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern IntPtr /* HANDLE */ CreateActCtxW(ref ACTCTXW actctx);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct ACTCTXW
        {
            public uint cbSize;
            public ACTCTXFlag dwFlags;
            public char* /* LPCWSTR */ lpSource;
            public ushort wProcessorArchitecture;
            public ushort /* LANGID */ wLangId;
            public char* /* LPCWSTR */ lpAssemblyDirectory;
            public char* /* LPCWSTR */ lpResourceName;
            public char* /* LPCWSTR */ lpApplicationName;
            public IntPtr /* HMODULE */ hModule;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool ActivateActCtx(IntPtr /* HANDLE */ hActCtx, out uint lpCookie);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool DeactivateActCtx(uint dwFlags, uint lpCookie);

        internal struct DWM_BLURBEHIND
        {
            public DWMBB dwFlags;
            public int fEnable;
            public IntPtr /* HRGN */ hRgnBlur;
            public int fTransitionOnMaximized;
        }

        [DllImport("dwmapi.dll")]
        internal static extern int /* HRESULT */ DwmEnableBlurBehindWindow(IntPtr /* HWND */ hWnd, in DWM_BLURBEHIND pBlurBehind);

        [DllImport("dwmapi.dll")]
        internal static extern int /* HRESULT */ DwmGetColorizationColor(out uint pcrColorization, [MarshalAs(UnmanagedType.Bool)] out bool pfOpaqueBlend);

        [DllImport("gdi32.dll")]
        internal static extern IntPtr /* HRGN */ CreateRectRgn(int x1, int y1, int x2, int y2);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetLayeredWindowAttributes(IntPtr /* HWND */ hwnd, uint /* COLORREF */ crKey, byte bAlpha, LWA dwFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetLayeredWindowAttributes(IntPtr /* HWND */ hwnd, out uint /* COLORREF* */ pcrKey, out byte /* BYTE* */ pbAlpha, out LWA /* DWORD* */ pdwFlags);

        [DllImport("user32.dll")]
        internal static extern int GetDisplayConfigBufferSizes(QDC flags, out uint numPathArrayElements, out uint numModeInfoArrayElements);

        internal struct DISPLAYCONFIG_RATIONAL
        {
            public uint Numerator;
            public uint Denominator;

            public override string ToString()
            {
                return $"{Numerator} / {Denominator}";
            }
        }

        internal struct DISPLAYCONFIG_2DREGION
        {
            public uint cx;
            public uint cy;
        }

        [StructLayout(LayoutKind.Explicit, Pack = 8)]
        internal struct DISPLAYCONFIG_PATH_SOURCE_INFO
        {
            [FieldOffset(0)] public LUID adapterId;
            [FieldOffset(8)] public uint id;
            //union {
                [FieldOffset(12)] public uint modeInfoIdx;
                [FieldOffset(12)] public ushort cloneGroupId;
                [FieldOffset(14)] public ushort sourceModeInfoIdx;
            //}
            [FieldOffset(16)] public DISPLAYCONFIG_SOURCE statusFlags;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct DISPLAYCONFIG_PATH_TARGET_INFO
        {
            [FieldOffset(0)] public LUID adapterId;
            [FieldOffset(8)] public uint id;
            //union {
                [FieldOffset(12)] public uint modeInfoIdx;
                [FieldOffset(12)] public ushort desktopModeInfoIdx;
                [FieldOffset(14)] public ushort targetModeInfoIdx;
            //}
            [FieldOffset(16)] public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
            [FieldOffset(20)] public DISPLAYCONFIG_ROTATION rotation;
            [FieldOffset(24)] public DISPLAYCONFIG_SCALING scaling;
            [FieldOffset(28)] public DISPLAYCONFIG_RATIONAL refreshRate;
            [FieldOffset(36)] public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
            [FieldOffset(40)] public uint /* BOOL */ targetAvailable;
            [FieldOffset(44)] public DISPLAYCONFIG_TARGET statusFlags;
        }

        internal struct DISPLAYCONFIG_PATH_INFO
        {
            public DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;
            public DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;
            public DISPLAYCONFIG_PATH flags;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
        {
            [FieldOffset( 0)] public ulong pixelRate;
            [FieldOffset( 8)] public DISPLAYCONFIG_RATIONAL hSyncFreq;
            [FieldOffset(16)] public DISPLAYCONFIG_RATIONAL vSyncFreq;
            [FieldOffset(24)] public DISPLAYCONFIG_2DREGION activeSize;
            [FieldOffset(32)] public DISPLAYCONFIG_2DREGION totalSize;
            //union {
                [FieldOffset(40)] public AdditionalSignalInfo_struct AdditionalSignalInfo;
                [FieldOffset(40)] public uint videoStandard;
            //}
            [FieldOffset(44)] public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

            internal struct AdditionalSignalInfo_struct
            {
                uint _bitfield;

                internal ushort videoStandard
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (ushort)((this._bitfield >> 0) & 0x0000FFFF);
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        this._bitfield = (uint)((this._bitfield & unchecked((uint)~0x0000FFFF)) | ((uint)(value & 0x0000FFFF) << 0));
                    }
                }

                internal byte vSyncFreqDivider
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (byte)((this._bitfield >> 16) & 0x0000003F);
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        global::System.Diagnostics.Debug.Assert(value is <= (byte)63L);
                        this._bitfield = (uint)((this._bitfield & unchecked((uint)~0x003F0000)) | ((uint)(value & 0x0000003F) << 16));
                    }
                }

                internal ushort reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (ushort)((this._bitfield >> 22) & 0x000003FF);
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        global::System.Diagnostics.Debug.Assert(value is <= (ushort)1023L);
                        this._bitfield = (uint)((this._bitfield & unchecked((uint)~0xFFC00000)) | ((uint)(value & 0x000003FF) << 22));
                    }
                }
            }
        }

        internal struct DISPLAYCONFIG_TARGET_MODE
        {
            public DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
        }

        internal struct DISPLAYCONFIG_SOURCE_MODE
        {
            public uint width;
            public uint height;
            public DISPLAYCONFIG_PIXELFORMAT pixelFormat;
            public POINTL position;
        }

        internal struct RECTL
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        internal struct DISPLAYCONFIG_DESKTOP_IMAGE_INFO
        {
            public POINTL PathSourceSize;
            public RECTL DesktopImageRegion;
            public RECTL DesktopImageClip;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct DISPLAYCONFIG_MODE_INFO
        {
            [FieldOffset(0)] public DISPLAYCONFIG_MODE_INFO_TYPE infoType;
            [FieldOffset(4)] public uint id;
            [FieldOffset(8)] public LUID adapterId;
            //union {
                [FieldOffset(16)] public DISPLAYCONFIG_TARGET_MODE targetMode;
                [FieldOffset(16)] public DISPLAYCONFIG_SOURCE_MODE sourceMode;
                [FieldOffset(16)] public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
            //}
        }

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern int QueryDisplayConfig(
            QDC flags,
            ref uint numPathArrayElements,
            ref DISPLAYCONFIG_PATH_INFO pathArray,
            ref uint numModeInfoArrayElements,
            ref DISPLAYCONFIG_MODE_INFO modeInfoArray,
            ref DISPLAYCONFIG_TOPOLOGY_ID currentTopologyId);

        internal struct DISPLAYCONFIG_DEVICE_INFO_HEADER
        {
            public DISPLAYCONFIG_DEVICE_INFO_TYPE type;
            public uint size;
            public LUID adapterId;
            public uint id;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS
        {
            [FieldOffset(0)]
            internal _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            internal uint value;

            internal partial struct _Anonymous_e__Struct
            {
                internal uint _bitfield;

                /// <summary>Gets or sets bit 0 in the <see cref="_bitfield" /> field.</summary>
                internal bool friendlyNameFromEdid
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000001) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000001 : (this._bitfield & unchecked((uint)~0x00000001)));
                }

                /// <summary>Gets or sets bit 1 in the <see cref="_bitfield" /> field.</summary>
                internal bool friendlyNameForced
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000002) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000002 : (this._bitfield & unchecked((uint)~0x00000002)));
                }

                /// <summary>Gets or sets bit 2 in the <see cref="_bitfield" /> field.</summary>
                internal bool edidIdsValid
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000004) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000004 : (this._bitfield & unchecked((uint)~0x00000004)));
                }

                /// <summary>Gets or sets bits 3-31 in the <see cref="_bitfield" /> field. Allowed values are [0..536870911].</summary>
                internal uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (uint)((this._bitfield >> 3) & 0x1FFFFFFF);
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        global::System.Diagnostics.Debug.Assert(value is <= (uint)536870911L);
                        this._bitfield = (uint)((this._bitfield & unchecked((uint)~0xFFFFFFF8)) | ((uint)(value & 0x1FFFFFFF) << 3));
                    }
                }
            }
        }

        internal struct DISPLAYCONFIG_TARGET_DEVICE_NAME
        {
            public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
            public DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS flags;
            public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
            public ushort edidManufactureId;
            public ushort edidProductCodeId;
            public uint connectorInstance;
            public fixed char monitorFriendlyDeviceName[64];
            public fixed char monitorDevicePath[128];
        }

        internal struct DISPLAYCONFIG_SOURCE_DEVICE_NAME
        {
            public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
            public fixed char viewGdiDeviceName[32];
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO
        {
            [FieldOffset(0)] public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
            //union {
                [FieldOffset(20)] public DummyUnion_struct union;
                [FieldOffset(20)] public uint value;
            //}

            [FieldOffset(24)] public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;
            [FieldOffset(28)] public uint bitsPerColorChannel;

            internal struct DummyUnion_struct {
                uint _bitfield;

                /// <summary>
                /// A type of advanced color is supported
                /// </summary>
                internal bool advancedColorSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000001) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000001 : (this._bitfield & unchecked((uint)~0x00000001)));
                }

                /// <summary>
                /// A type of advanced color is enabled
                /// </summary>
                internal bool advancedColorEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000002) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000002 : (this._bitfield & unchecked((uint)~0x00000002)));
                }

                /// <summary>
                /// Wide color gamut is enabled
                /// </summary>
                internal bool wideColorEnforced
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000004) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000004 : (this._bitfield & unchecked((uint)~0x00000004)));
                }

                /// <summary>
                /// Advanced color is force disabled due to system/OS policy
                /// </summary>
                internal bool advancedColorForceDisabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000004) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000004 : (this._bitfield & unchecked((uint)~0x00000004)));
                }

                internal uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (byte)((this._bitfield >> 4) & 0x0FFFFFFF);
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        global::System.Diagnostics.Debug.Assert(value is <= (uint)268435456L);
                        this._bitfield = (uint)((this._bitfield & unchecked((uint)~0xFFFFFFF0)) | ((uint)(value & 0x0FFFFFFF) << 4));
                    }
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2
        {
            [FieldOffset(0)] public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
            //union
            //{
                [FieldOffset(20)] public DummyUnion_struct union;
                [FieldOffset(20)] public uint value;
            //}

            [FieldOffset(24)] public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;
            [FieldOffset(28)] public uint bitsPerColorChannel;

            /// <summary>
            /// The active color mode for this monitor
            /// </summary>
            [FieldOffset(32)] public DISPLAYCONFIG_ADVANCED_COLOR_MODE activeColorMode;

            internal struct DummyUnion_struct
            {
                uint _bitfield;

                /// <summary>
                /// A type of advanced color is supported
                /// </summary>
                internal bool advancedColorSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000001) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000001 : (this._bitfield & unchecked((uint)~0x00000001)));
                }

                /// <summary>
                /// A type of advanced color is active (see currentColorMode for the specific advanced color mode)
                /// </summary>
                internal bool advancedColorActive
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000002) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000002 : (this._bitfield & unchecked((uint)~0x00000002)));
                }

                /// <summary>
                /// Wide color gamut is enabled
                /// </summary>
                internal bool reserved1
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000004) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000004 : (this._bitfield & unchecked((uint)~0x00000004)));
                }

                /// <summary>
                /// System/OS policy is limiting advanced color options (see currentColorMode for the current mode)
                /// </summary>
                internal bool advancedColorLimitedByPolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000008) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000008 : (this._bitfield & unchecked((uint)~0x00000008)));
                }

                /// <summary>
                /// HDR is supported
                /// </summary>
                internal bool highDynamicRangeSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000010) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000010 : (this._bitfield & unchecked((uint)~0x00000010)));
                }

                /// <summary>
                /// HDR is enabled by the user (but may not be active)
                /// </summary>
                internal bool highDynamicRangeUserEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000020) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000020 : (this._bitfield & unchecked((uint)~0x00000020)));
                }

                /// <summary>
                /// Wide color gamut is supported
                /// </summary>
                internal bool wideColorSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000040) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000040 : (this._bitfield & unchecked((uint)~0x00000040)));
                }

                /// <summary>
                /// Wide color gamut is enabled by the user (but may not be active)
                /// </summary>
                internal bool wideColorUserEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (this._bitfield & 0x00000080) != 0;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => this._bitfield = (uint)(value ? this._bitfield | 0x00000080 : (this._bitfield & unchecked((uint)~0x00000080)));
                }

                internal uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get => (byte)((this._bitfield >> 8) & 0x00FFFFFF);
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        global::System.Diagnostics.Debug.Assert(value is <= (uint)16777216L);
                        this._bitfield = (uint)((this._bitfield & unchecked((uint)~0xFFFFFF00)) | ((uint)(value & 0x00FFFFFF) << 8));
                    }
                }
            }
        }

        internal struct DISPLAYCONFIG_SDR_WHITE_LEVEL
        {
            public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

            // SDRWhiteLevel represents a multiplier for standard SDR white
            // peak value i.e. 80 nits represented as fixed point.
            // To get value in nits use the following conversion
            // SDRWhiteLevel in nits = (SDRWhiteLevel / 1000 ) * 80
            public uint SDRWhiteLevel;
        }

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_DEVICE_INFO_HEADER requestPacket);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_TARGET_DEVICE_NAME requestPacket);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO requestPacket);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2 requestPacket);

        [DllImport("user32.dll", SetLastError = false)]
        internal static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_SDR_WHITE_LEVEL requestPacket);
    }
#pragma warning restore CS0649 // Field 'field' is never assigned to, and will always have its default value 'value'
}
