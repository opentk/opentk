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
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        // Invokes the 32- or 64-bit version depending on pointer size.
        public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (IntPtr.Size == 8)
            {
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            }

            return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
        }

        /*
        Included for completeness. Currently these are unnecessary since SetWindowLongPtr
        will return the current value, and we aren't currently getting any value that
        isn't being replaced (specifically the WndProc).

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        // Invokes the 32- or 64-bit version depending on pointer size.
        private static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 8)
            {
                return GetWindowLongPtr64(hWnd, nIndex);
            }

            return GetWindowLongPtr32(hWnd, nIndex);
        }
        */

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
        private IntPtr _hWnd = IntPtr.Zero;

        // Original message-handler
        private IntPtr _DefaultWndProc = IntPtr.Zero;

        // When true, WM_ENTERSIZEMOVE has been received, and this will reset
        // to false when WM_ENTERSIZEMOVE or WM_CAPTURECHANGED is received.
        private bool _isModalSizeMoveState = false;

        /// <summary>
        /// Indicates the window is in a modal size/move state and update events
        /// are temporarily suspended.
        /// </summary>
        public bool IsModalSizeMoveState { get => _isModalSizeMoveState; }

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
            var openTKWndProc = Marshal.GetFunctionPointerForDelegate((WndProcPointer)WndProc);
            _DefaultWndProc = SetWindowLongPtr(_hWnd, (int)WindowLongFlags.GWL_WNDPROC, openTKWndProc);
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam)
        {
            switch (msg)
            {
                case WM_ENTERSIZEMOVE:
                    _isModalSizeMoveState = true;
                    OnModalSizeMoveBegin?.Invoke();
                    break;

                case WM_EXITSIZEMOVE:
                case WM_CAPTURECHANGED:
                    if (_isModalSizeMoveState)
                    {
                        _isModalSizeMoveState = false;
                        OnModalSizeMoveEnd?.Invoke();
                    }
                    break;

                default:
                    break;
            }

            return CallWindowProc(_DefaultWndProc, _hWnd, msg, wParam, lParam);
        }

        private bool _isDisposed = false;

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (!_DefaultWndProc.Equals(IntPtr.Zero))
            {
                SetWindowLongPtr(_hWnd, (int)WindowLongFlags.GWL_WNDPROC, _DefaultWndProc);
                _DefaultWndProc = IntPtr.Zero;
            }

            GC.SuppressFinalize(this);
            _isDisposed = true;
        }
    }
}
