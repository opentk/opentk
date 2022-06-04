using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    public class WindowComponent : IWindowComponent
    {
        public const string CLASS_NAME = "OpenTK Window";

        public static readonly IntPtr HInstance;

        public static IntPtr HelperHWnd { get; private set; }

        internal static readonly Dictionary<IntPtr, HWND> HWndDict = new Dictionary<IntPtr, HWND>();

        static WindowComponent()
        {
            // Get the hInstance of the current exe
            HInstance = Win32.GetModuleHandle(null);
        }

        public string Name => "Win32Window";

        public PalComponents Provides => PalComponents.Window;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new Exception("WindowComponent can only initialize the Window component.");
            }

            // Here we register the window class that we will use for all created windows.
            Win32.WNDCLASSEX wndClass = Win32.WNDCLASSEX.Create();
            wndClass.lpfnWndProc = Win32WindowProc;
            wndClass.hInstance = HInstance;
            wndClass.lpszClassName = CLASS_NAME;
            wndClass.style = ClassStyles.OwnDC;

            short wndClassAtom = Win32.RegisterClassEx(in wndClass);

            if (wndClassAtom == 0)
            {
                throw new Win32Exception("RegisterClassEx failed!", Marshal.GetLastWin32Error());
            }

            HelperHWnd = Win32.CreateWindowEx(
                0,
                WindowComponent.CLASS_NAME,
                "OpenTK Helper Window",
                WindowStyles.WS_CLIPSIBLINGS | WindowStyles.WS_CLIPCHILDREN,
                Win32.CW_USEDEFAULT,
                Win32.CW_USEDEFAULT,
                Win32.CW_USEDEFAULT,
                Win32.CW_USEDEFAULT,
                IntPtr.Zero,
                IntPtr.Zero,
                HInstance,
                IntPtr.Zero);

            if (HelperHWnd == IntPtr.Zero)
            {
                throw new Win32Exception("Failed to create helper window", Marshal.GetLastWin32Error());
            }

            // Eat all messages so that the WM_CREATE messages get processed etc.
            while (Win32.PeekMessage(out Win32.MSG lpMsg, HelperHWnd, 0, 0, PM.REMOVE) != 0)
            {
                Win32.TranslateMessage(in lpMsg);
                Win32.DispatchMessage(in lpMsg);
            }
        }

        public bool CanSetIcon => throw new NotImplementedException();

        public bool CanGetDisplay => throw new NotImplementedException();

        public bool CanSetCursor => throw new NotImplementedException();

        public IReadOnlyList<WindowEventType> SupportedEvents => throw new NotImplementedException();

        public IReadOnlyList<WindowStyle> SupportedStyles => _SupportedStyles;

        public IReadOnlyList<WindowMode> SupportedModes => _SupportedModes;

        // FIXME: HACK!!!!!!
        private static bool quit = false;

        public void Loop(WindowHandle handle, Func<bool> callback)
        {
            HWND hwnd = handle.As<HWND>(this);

            while (true)
            {
                while (Win32.PeekMessage(out Win32.MSG lpMsg, IntPtr.Zero, 0, 0, PM.REMOVE) != 0)
                {
                    Win32.TranslateMessage(in lpMsg);
                    Win32.DispatchMessage(in lpMsg);
                }

                if (quit == true)
                {
                    break;
                }

                if (callback() == false)
                {
                    break;
                }
            }
        }

        public void SwapBuffers(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            IntPtr hDC = Win32.GetDC(hwnd.HWnd);

            bool success = Win32.SwapBuffers(hDC);

            if (success == false)
            {
                throw new Win32Exception("SwapBuffers failed", Marshal.GetLastWin32Error());
            }
        }

        private static IntPtr Win32WindowProc(IntPtr hWnd, uint uMsg, UIntPtr wParam, IntPtr lParam)
        {
            WM message = (WM)uMsg;
            Console.WriteLine("WinProc " + message + " " + hWnd);
            switch (message)
            {
                case WM.KEYDOWN:
                    {
                        // FIXME: Ability to "eat" key down presses?
                        HWND h = HWndDict[hWnd];

                        ulong vk = wParam.ToUInt64();
                        long l = lParam.ToInt64();
                        bool wasDown = (l & (1 << 30)) != 0;
                        bool extended = (l & (1 << 24)) != 0;

                        h.EventQueue.Send(h, WindowEventType.KeyDown, new KeyDownEventArgs(vk, wasDown, extended));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.PAINT:
                    {
                        Win32.BeginPaint(hWnd, out Win32.PAINTSTRUCT lpPaint);

                        int success = Win32.FillRect(lpPaint.hdc, lpPaint.rcPaint, new IntPtr(18));

                        if (success == 0)
                        {
                            throw new Win32Exception("FillRect failed.", Marshal.GetLastWin32Error());
                        }

                        Win32.EndPaint(hWnd, in lpPaint);
                        return IntPtr.Zero;
                    }
                case WM.CLOSE:
                    {
                        // FIXME: HACK! This is not the greatest way to get the WindowComponent...
                        HWND h = HWndDict[hWnd];
                        h.WindowComponent.Destroy(h);
                        return IntPtr.Zero;
                    }
                case WM.DESTROY:
                    {
                        Win32.PostQuitMessage(0);
                        quit = true;
                        return IntPtr.Zero;
                    }
                default:
                    {
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
            }
        }

        public WindowHandle Create(GraphicsApiHints hints)
        {
            IntPtr hWnd = Win32.CreateWindowEx(
                0,
                CLASS_NAME,
                "OpenTK Window",
                WindowStyles.WS_OVERLAPPEDWINDOW,
                Win32.CW_USEDEFAULT,
                Win32.CW_USEDEFAULT,
                Win32.CW_USEDEFAULT,
                Win32.CW_USEDEFAULT,
                IntPtr.Zero,
                IntPtr.Zero,
                HInstance,
                IntPtr.Zero);

            if (hWnd == IntPtr.Zero)
            {
                throw new Win32Exception("CreateWindowEx failed!", Marshal.GetLastWin32Error());
            }

            HWND hwnd = new HWND(hWnd, this);

            HWndDict.Add(hwnd.HWnd, hwnd);

            return hwnd;
        }

        public void Destroy(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            HWndDict.Remove(hwnd.HWnd);

            bool success = Win32.DestroyWindow(hwnd.HWnd);

            // FIXME: Do we add back the hglrc to HGLRCDict?
            if (success == false)
            {
                throw new Win32Exception("DestroyWindow failed!", Marshal.GetLastWin32Error());
            }
        }

        public string GetTitle(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            int textLength = Win32.GetWindowTextLength(hwnd.HWnd);

            int error = Marshal.GetLastWin32Error();
            if (textLength == 0 && error != 0)
            {
                throw new Win32Exception("GetWindowTextLength: Could not get length of window text", error);
            }

            StringBuilder title = new StringBuilder(textLength + 1);

            Win32.GetWindowText(hwnd.HWnd, title, title.Capacity);

            return title.ToString();
        }

        public void SetTitle(WindowHandle handle, string title)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.SetWindowText(hwnd.HWnd, title);

            if (success == false)
            {
                throw new Win32Exception("Could not set window title", Marshal.GetLastWin32Error());
            }
        }

        public IconHandle GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT lpRect);

            if (success == false)
            {
                throw new Win32Exception("GetWindowRect failed", Marshal.GetLastWin32Error());
            }

            x = lpRect.left;
            y = lpRect.top;
        }

        public void SetPosition(WindowHandle handle, int x, int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            bool success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, x, y, 0, 0, SetWindowPosFlags.NoSize | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("Could not set window position", Marshal.GetLastWin32Error());
            }
        }

        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT lpRect);

            if (success == false)
            {
                throw new Win32Exception("GetWindowRect failed", Marshal.GetLastWin32Error());
            }

            width = lpRect.right - lpRect.left;
            height = lpRect.bottom - lpRect.top;
        }

        public void SetSize(WindowHandle handle, int width, int height)
        {
            HWND hwnd = handle.As<HWND>(this);

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            bool success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, 0, 0, width, height, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("Could not set window size", Marshal.GetLastWin32Error());
            }
        }

        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            Win32.POINT point = new Win32.POINT(0, 0);

            bool success = Win32.ClientToScreen(hwnd.HWnd, ref point);

            if (success == false)
            {
                throw new Win32Exception("ClientToScreen failed", Marshal.GetLastWin32Error());
            }

            x = point.X;
            y = point.Y;
        }

        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            Win32.RECT rect = new Win32.RECT(x, y, 0, 0);
            WindowStyles currentStyle = (WindowStyles)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style).ToInt64();
            // This doesn't consider potential scroll bars, so if that is ever a thing we would need to add code for that here!
            // FIXME: Menu
            bool success = Win32.AdjustWindowRect(ref rect, currentStyle, false);

            if (success == false)
            {
                throw new Win32Exception("AdjustWindowRect failed", Marshal.GetLastWin32Error());
            }

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, rect.left, rect.top, 0, 0, SetWindowPosFlags.NoSize | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("Could not set window position", Marshal.GetLastWin32Error());
            }
        }

        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.GetClientRect(hwnd.HWnd, out Win32.RECT lpRect);

            if (success == false)
            {
                throw new Win32Exception("GetClientRect failed", Marshal.GetLastWin32Error());
            }

            width = lpRect.right;
            height = lpRect.bottom;
        }

        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            HWND hwnd = handle.As<HWND>(this);

            Win32.RECT rect = new Win32.RECT(0, 0, width, height);

            WindowStyles currentStyle = (WindowStyles)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style).ToInt64();
            // This doesn't consider potential scroll bars, so if that is ever a thing we would need to add code for that here!
            // FIXME: Menu
            bool success = Win32.AdjustWindowRect(ref rect, currentStyle, false);

            if (success == false)
            {
                throw new Win32Exception("AdjustWindowRect failed", Marshal.GetLastWin32Error());
            }

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, 0, 0, rect.Width, rect.Height, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("SetWindowPos failed", Marshal.GetLastWin32Error());
            }
        }

        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public WindowMode GetMode(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStyles style = (WindowStyles)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style).ToInt64();

            if (style.HasFlag(WindowStyles.WS_VISIBLE) == false)
            {
                return WindowMode.Hidden;
            }
            else
            {
                if (style.HasFlag(WindowStyles.WS_MINIMIZE))
                {
                    return WindowMode.Minimized;
                }
                else if (style.HasFlag(WindowStyles.WS_MAXIMIZE))
                {
                    return WindowMode.Maximized;
                }
                else
                {
                    // FIXME: Figure out how to return the remaining window modes!
                    return WindowMode.Normal;
                }
            }
        }

        private static readonly WindowMode[] _SupportedModes = new[]
        {
            WindowMode.Hidden,
            WindowMode.Minimized,
            WindowMode.Normal,
            WindowMode.Maximized
        };

        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            HWND hwnd = handle.As<HWND>(this);

            // FIXME: Handle ShowWindowCommands.ShowMinimized?
            switch (mode)
            {
                case WindowMode.Hidden:
                    Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.Hide);
                    break;
                case WindowMode.Minimized:
                    Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.Minimize);
                    break;
                case WindowMode.Normal:
                    // FIXME: Use ShowWindowCommands.Show?
                    Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.Normal);
                    break;
                case WindowMode.Maximized:
                    Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.Maximize);
                    break;
                case WindowMode.WindowedFullscreen:
                    throw new NotImplementedException("Windowed fullscreen is not implemented yet");
                case WindowMode.ExclusiveFullscreen:
                    throw new NotImplementedException("Exclusive fullscreen is not implemented yet");
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, mode.GetType());
            }
        }

        public WindowStyle GetBorderStyle(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStyles style = (WindowStyles)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style).ToInt64();

            // FIXME: Better way of checking these!!
            if (style.HasFlag(WindowStyles.WS_OVERLAPPEDWINDOW & ~WindowStyles.WS_THICKFRAME) &&
                style.HasFlag(WindowStyles.WS_THICKFRAME) == false)
            {
                return WindowStyle.FixedBorder;
            }
            else if (style.HasFlag(WindowStyles.WS_OVERLAPPEDWINDOW & ~(WindowStyles.WS_CAPTION | WindowStyles.WS_BORDER | WindowStyles.WS_THICKFRAME)) &&
                     style.HasFlag(WindowStyles.WS_CAPTION) == false &&
                     style.HasFlag(WindowStyles.WS_BORDER) == false &&
                     style.HasFlag(WindowStyles.WS_THICKFRAME) == false)
            {
                return WindowStyle.Borderless;
            }
            else if (style.HasFlag(WindowStyles.WS_OVERLAPPEDWINDOW))
            {
                return WindowStyle.ResizableBorder;
            }
            else
            {
                throw new NotImplementedException($"Unknown window style combination! (or toolbox?) (Style: {style})");
            }
        }

        private static readonly WindowStyle[] _SupportedStyles = new[]
        {
            WindowStyle.Borderless,
            WindowStyle.FixedBorder,
            WindowStyle.ResizableBorder,
        };

        public unsafe void SetBorderStyle(WindowHandle handle, WindowStyle style)
        {
            HWND hwnd = handle.As<HWND>(this);

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStyles windowStyle = (WindowStyles)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style).ToInt64();

            // FIXME: If we are going from borderless to the other styles we need to set these flags again
            // This feels like it needs quite a lot of precision and is fragile, maybe there is another way?
            // Having every window style have a specific flag combination?
            switch (style)
            {
                case WindowStyle.Borderless:
                    // FIXME: Get rid of the wait cursor.
                    windowStyle &= ~WindowStyles.WS_CAPTION;
                    windowStyle &= ~WindowStyles.WS_BORDER;
                    windowStyle &= ~WindowStyles.WS_THICKFRAME;
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((uint)windowStyle));
                    break;
                case WindowStyle.FixedBorder:
                    windowStyle |= WindowStyles.WS_OVERLAPPEDWINDOW;
                    windowStyle &= ~WindowStyles.WS_THICKFRAME;
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((uint)windowStyle));
                    break;
                case WindowStyle.ResizableBorder:
                    windowStyle |= WindowStyles.WS_OVERLAPPEDWINDOW;
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((uint)windowStyle));
                    break;
                case WindowStyle.ToolBox:
                    throw new NotImplementedException();
                default:
                    break;
            }

            Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, 0, 0, 0, 0, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoSize | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.FrameChanged);
        }

        public void SetCursor(WindowHandle handle, CursorHandle cursor)
        {
            throw new NotImplementedException();
        }

        public IEventQueue<WindowEventType, WindowEventArgs> GetEventQueue(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);
            return hwnd.EventQueue;
        }
    }
}
