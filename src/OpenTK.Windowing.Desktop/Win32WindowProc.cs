using System;
using System.Runtime.InteropServices;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// Windows-specific Win32 message-handling.
    /// </summary>
    internal unsafe class Win32WindowProc : IDisposable
    {
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        // Invokes the 32- or 64-bit version depending on pointer size.
        public static IntPtr SetWindowPointer(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (Environment.Is64BitProcess)
            {
                return SetWindowLongPtr(hWnd, nIndex, dwNewLong);
            }
            else
            {
                return new IntPtr(SetWindowLong(hWnd, nIndex, dwNewLong.ToInt32()));
            }
        }

        private enum WindowLongFlags : int
        {
            GWL_EXSTYLE = -20,
            GWLP_HINSTANCE = -6,
            GWLP_HWNDPARENT = -8,
            GWL_ID = -12,
            GWL_STYLE = -16,
            GWL_USERDATA = -21,
            GWL_WNDPROC = -4,
            DWLP_USER = 0x8,
            DWLP_MSGRESULT = 0x0,
            DWLP_DLGPROC = 0x4,
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr CallWindowProc(IntPtr wndProc, IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private delegate IntPtr WndProcPointer(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        // Indicates the beginning of modal size/move activity.
        private const int WM_ENTERSIZEMOVE = 0x0231;

        // Indicates the completion of modal size/move activity.
        private const int WM_EXITSIZEMOVE = 0x0232;

        // On older versions of Windows, this is sent when a user initiates
        // sizing but then does not actually resize the window. In that case,
        // WM_EXITSIZEMOVE is not sent. This can be sent in other scenarios
        // so it is also necessary to track whether WM_ENTERSIZEMOVE has been
        // received, in order to use this as a proxy for WM_EXITSIZEMOVE.
        private const int WM_CAPTURECHANGED = 0x0215;

        // Native win32 window handle
        private readonly IntPtr _hWnd;

        // Original message-handler
        private readonly IntPtr _defaultWndProc;

        // Local message-handler
        private readonly WndProcPointer _openTKWndProcDelegate;

        // When true, WM_ENTERSIZEMOVE has been received, and this will reset
        // to false when WM_ENTERSIZEMOVE or WM_CAPTURECHANGED is received.
        private bool _inModalSizeMoveState = false;

        /// <summary>
        /// Invoked when Windows indicates modal move/size activity has started (the user
        /// is dragging or resizing the window).
        /// </summary>
        public event Action OnModalSizeMoveBegin;

        /// <summary>
        /// Invoked when Windows indicates modal move/size activity has ended.
        /// </summary>
        public event Action OnModalSizeMoveEnd;

        public Win32WindowProc(Window* window)
        {
            _hWnd = GLFW.GetWin32Window(window);
            _openTKWndProcDelegate = WndProc;
            var openTKWndProc = Marshal.GetFunctionPointerForDelegate(_openTKWndProcDelegate);
            _defaultWndProc = SetWindowPointer(_hWnd, (int)WindowLongFlags.GWL_WNDPROC, openTKWndProc);
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam)
        {
            switch (msg)
            {
                case WM_ENTERSIZEMOVE:
                    _inModalSizeMoveState = true;
                    OnModalSizeMoveBegin?.Invoke();
                    break;

                case WM_EXITSIZEMOVE:
                case WM_CAPTURECHANGED:
                    if (_inModalSizeMoveState)
                    {
                        _inModalSizeMoveState = false;
                        OnModalSizeMoveEnd?.Invoke();
                    }
                    break;

                default:
                    break;
            }

            return CallWindowProc(_defaultWndProc, _hWnd, msg, wParam, lParam);
        }

        private bool _isDisposed = false;

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (_defaultWndProc != IntPtr.Zero)
            {
                SetWindowPointer(_hWnd, (int)WindowLongFlags.GWL_WNDPROC, _defaultWndProc);
            }

            GC.SuppressFinalize(this);
            _isDisposed = true;
        }
    }
}
