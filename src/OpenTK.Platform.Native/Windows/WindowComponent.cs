using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace OpenTK.Platform.Native.Windows
{
    public partial class WindowComponent : IWindowComponent
    {
        /// <summary>
        /// Class name used to create windows.
        /// </summary>
        public const string CLASS_NAME = "OpenTK Window";

        /// <summary>
        /// The applications HInstance.
        /// </summary>
        public static readonly IntPtr HInstance;

        /// <summary>
        /// The helper window used to load wgl extensions.
        /// </summary>
        public static IntPtr HelperHWnd { get; private set; }

        // A handle to a windowproc delegate so it doesn't get GC collected.
        private Win32.WNDPROC? WindowProc;

        internal static readonly Dictionary<IntPtr, HWND> HWndDict = new Dictionary<IntPtr, HWND>();

        static WindowComponent()
        {
            // Get the hInstance of the current exe
            HInstance = Win32.GetModuleHandle(null);
        }

        /// <inheritdoc/>
        public string Name => "Win32Window";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Window;

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new Exception("WindowComponent can only initialize the Window component.");
            }

            // Set the WindowProc delegate so that we capture "this".
            // FIXME: Does this cause GC issues where "this" is circularly referenced?
            WindowProc = Win32WindowProc;

            // Here we register the window class that we will use for all created windows.
            Win32.WNDCLASSEX wndClass = Win32.WNDCLASSEX.Create();
            wndClass.lpfnWndProc = WindowProc;
            wndClass.hInstance = HInstance;
            wndClass.lpszClassName = CLASS_NAME;
            wndClass.style = ClassStyles.OwnDC;

            short wndClassAtom = Win32.RegisterClassEx(in wndClass);

            if (wndClassAtom == 0)
            {
                throw new Win32Exception("RegisterClassEx failed!");
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
                throw new Win32Exception("Failed to create helper window");
            }

            // Eat all messages so that the WM_CREATE messages get processed etc.
            while (Win32.PeekMessage(out Win32.MSG lpMsg, HelperHWnd, 0, 0, PM.REMOVE) != 0)
            {
                Win32.TranslateMessage(in lpMsg);
                Win32.DispatchMessage(in lpMsg);
            }

            // FIXME: Should we set SetThreadExecutionState?
            // Long cutscenes could make the screensaver to kick in and we probably don't want that.
            // Should this be a user setting? Tools should allow the screensaver while games shouldn't.
            // Doesn't really fit into any of the current components.
        }

        /// <inheritdoc/>
        public bool CanSetIcon => true;

        /// <inheritdoc/>
        public bool CanGetDisplay => true;

        /// <inheritdoc/>
        public bool CanSetCursor => true;

        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowStyle> SupportedStyles => _SupportedStyles;

        /// <inheritdoc/>
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

        private IntPtr Win32WindowProc(IntPtr hWnd, WM uMsg, UIntPtr wParam, IntPtr lParam)
        {
            //Console.WriteLine("WinProc " + message + " " + hWnd);
            switch (uMsg)
            {
                case WM.KEYDOWN:
                    {
                        HWND h = HWndDict[hWnd];

                        ulong vk = wParam.ToUInt64();
                        long l = lParam.ToInt64();
                        bool wasDown = (l & (1 << 30)) != 0;
                        bool extended = (l & (1 << 24)) != 0;

                        EventQueue.Raise(h, PlatformEventType.KeyDown, new KeyDownEventArgs(vk, wasDown, extended));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.KEYUP:
                    {
                        HWND h = HWndDict[hWnd];

                        ulong vk = wParam.ToUInt64();
                        long l = lParam.ToInt64();
                        bool extended = (l & (1 << 24)) != 0;

                        EventQueue.Raise(h, PlatformEventType.KeyUp, new KeyUpEventArgs(vk, extended));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.CHAR:
                    {
                        HWND h = HWndDict[hWnd];
                        if (Win32.IsWindowUnicode(hWnd))
                        {
                            // UTF-16
                            string str;

                            ulong chars = wParam.ToUInt64();
                            char hi = (char)(chars >> 16);
                            char lo = (char)(chars & 0xFFFF);
                            if (char.IsSurrogatePair(hi, lo))
                            {
                                Span<char> text = stackalloc char[2];
                                text[0] = hi;
                                text[1] = lo;
                                str = new string(text);
                            }
                            else
                            {
                                str = new string(lo, 1);
                            }

                            //Console.WriteLine($"wParam: 0x{wParam.ToUInt64():X16}, lo: {(ushort)lo:X4}, hi: 0x{(ushort)hi:X4}");

                            if (char.IsSurrogate(lo))
                            {
                                ;
                            }

                            EventQueue.Raise(h, PlatformEventType.TextInput, new TextInputEventArgs(str));
                        }
                        else
                        {
                            // ANSI
                            EventQueue.Raise(h, PlatformEventType.TextInput, new TextInputEventArgs(new string((char)(wParam.ToUInt64()), 1)));
                        }

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.SETFOCUS:
                    {
                        HWND h = HWndDict[hWnd];
                        EventQueue.Raise(h, PlatformEventType.Focus, new FocusEventArgs(true));
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.KILLFOCUS:
                    {
                        // This message can be sent after WM_CLOSE which means that the specificed window might not exist any more.
                        if (HWndDict.TryGetValue(hWnd, out HWND? h))
                        {
                            EventQueue.Raise(h, PlatformEventType.Focus, new FocusEventArgs(false));
                        }

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.SETCURSOR:
                    {
                        int ht = ((int)lParam) & Win32.LoWordMask;
                        if (ht == Win32.HTCLIENT)
                        {
                            HWND h = HWndDict[hWnd];
                            // FIXME: Figure out what to do if h.HCursor is null
                            Win32.SetCursor(h.HCursor?.Cursor ?? IntPtr.Zero);
                            return new IntPtr(1);
                        }
                        else
                        {
                            return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                        }
                    }
                case WM.MOUSEMOVE:
                    {
                        int x = Win32.GET_X_LPARAM(lParam);
                        int y = Win32.GET_Y_LPARAM(lParam);

                        HWND h = HWndDict[hWnd];

                        if (h.TrackingMouse == false)
                        {
                            Win32.TRACKMOUSEEVENT tme = default;
                            tme.cbSize = (uint)Marshal.SizeOf<Win32.TRACKMOUSEEVENT>();
                            tme.dwFlags = TME.Leave;
                            tme.hwndTrack = hWnd;
                            Win32.TrackMouseEvent(ref tme);

                            h.TrackingMouse = true;

                            EventQueue.Raise(h, PlatformEventType.MouseEnter, new MouseEnterEventArgs(true));
                        }

                        EventQueue.Raise(h, PlatformEventType.MouseMove, new MouseMoveEventArgs(x, y));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.MOUSELEAVE:
                    {
                        HWND h = HWndDict[hWnd];
                        h.TrackingMouse = false;

                        EventQueue.Raise(h, PlatformEventType.MouseEnter, new MouseEnterEventArgs(false));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.LBUTTONDOWN:
                case WM.MBUTTONDOWN:
                case WM.RBUTTONDOWN:
                case WM.XBUTTONDOWN:
                    {
                        MouseButton? button;
                        switch (uMsg)
                        {
                            case WM.LBUTTONDOWN:
                                button = MouseButton.Button1;
                                break;
                            case WM.MBUTTONDOWN:
                                button = MouseButton.Button3;
                                break;
                            case WM.RBUTTONDOWN:
                                button = MouseButton.Button2;
                                break;
                            case WM.XBUTTONDOWN:
                                {
                                    const int XBUTTON1 = 0x0001;
                                    const int XBUTTON2 = 0x0002;
                                    int hiWord = ((int)wParam.ToUInt32() & Win32.HiWordMask) >> 16;

                                    if (hiWord == XBUTTON1)
                                    {
                                        button = MouseButton.Button4;
                                    }
                                    else if (hiWord == XBUTTON2)
                                    {
                                        button = MouseButton.Button5;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Unknown xbutton: {(uint)hiWord}");
                                        button = null;
                                    }

                                    break;
                                }
                            default:
                                throw new InvalidEnumArgumentException(nameof(uMsg), (int)uMsg, typeof(WM));
                        }

                        if (button != null)
                        {
                            HWND h = HWndDict[hWnd];
                            EventQueue.Raise(h, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(button.Value));
                        }

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.LBUTTONUP:
                case WM.MBUTTONUP:
                case WM.RBUTTONUP:
                case WM.XBUTTONUP:
                    {
                        MouseButton? button;
                        switch (uMsg)
                        {
                            case WM.LBUTTONUP:
                                button = MouseButton.Button1;
                                break;
                            case WM.MBUTTONUP:
                                button = MouseButton.Button3;
                                break;
                            case WM.RBUTTONUP:
                                button = MouseButton.Button2;
                                break;
                            case WM.XBUTTONUP:
                                {
                                    const int XBUTTON1 = 0x0001;
                                    const int XBUTTON2 = 0x0002;
                                    int hiWord = ((int)wParam.ToUInt32() & Win32.HiWordMask) >> 16;

                                    if (hiWord == XBUTTON1)
                                    {
                                        button = MouseButton.Button4;
                                    }
                                    else if (hiWord == XBUTTON2)
                                    {
                                        button = MouseButton.Button5;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Unknown xbutton: {(uint)hiWord}");
                                        button = null;
                                    }

                                    break;
                                }
                            default:
                                throw new InvalidEnumArgumentException(nameof(uMsg), (int)uMsg, typeof(WM));
                        }

                        if (button != null)
                        {
                            HWND h = HWndDict[hWnd];
                            EventQueue.Raise(h, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(button.Value));
                        }

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.MOUSEWHEEL:
                    {
                        float delta = ((int)(wParam.ToUInt32() & Win32.HiWordMask) >> 16) / 120f;
                        
                        bool success = Win32.SystemParametersInfo(SPI.GetWheelScrollLines, 0, out uint lines, SPIF.None);
                        if (success == false)
                        {
                            throw new Win32Exception();
                        }

                        HWND h = HWndDict[hWnd];

                        EventQueue.Raise(h, PlatformEventType.Scroll, new ScrollEventArgs(new Vector2(0, delta), new Vector2(0, delta * lines)));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.MOUSEHWHEEL:
                    {
                        float delta = ((int)(wParam.ToUInt32() & Win32.HiWordMask) >> 16) / 120f;

                        bool success = Win32.SystemParametersInfo(SPI.GetWheelScrollChars, 0, out uint chars, SPIF.None);
                        if (success == false)
                        {
                            throw new Win32Exception();
                        }

                        HWND h = HWndDict[hWnd];

                        EventQueue.Raise(h, PlatformEventType.Scroll, new ScrollEventArgs(new Vector2(delta, 0), new Vector2(delta * chars, 0)));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.SIZE:
                    {
                        SIZE size = (SIZE)wParam.ToUInt32();

                        HWND h = HWndDict[hWnd];

                        WindowState prevWindowState = h.WindowState;

                        // FIXME: Decide if we should merge WindowResize with WindowModeChange! if not, what is the order??
                        switch (size)
                        {
                            case SIZE.Maximized:
                                h.WindowState = WindowState.Maximized;

                                EventQueue.Raise(h, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(h, WindowMode.Maximized));
                                break;
                            case SIZE.Minimized:
                                h.WindowState = WindowState.Minimized;

                                EventQueue.Raise(h, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(h, WindowMode.Minimized));
                                break;
                            case SIZE.Restored:
                                if (h.WindowState != WindowState.Restored)
                                {
                                    h.WindowState = WindowState.Restored;

                                    EventQueue.Raise(h, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(h, WindowMode.Normal));
                                }
                                break;
                            case SIZE.MaxShow:
                            case SIZE.MaxHide:
                            default:
                                // Igonre these for now!
                                break;
                        }

                        int x = Win32.GET_X_LPARAM(lParam);
                        int y = Win32.GET_Y_LPARAM(lParam);

                        EventQueue.Raise(h, PlatformEventType.WindowResize, new WindowResizeEventArgs(h, new Vector2i(x, y)));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.MOVE:
                    {
                        int x = Win32.GET_X_LPARAM(lParam);
                        int y = Win32.GET_Y_LPARAM(lParam);

                        HWND h = HWndDict[hWnd];

                        Win32.GetWindowRect(hWnd, out Win32.RECT rect);
                        
                        EventQueue.Raise(h, PlatformEventType.WindowMove, new WindowMoveEventArgs(h, new Vector2i(rect.left, rect.top), new Vector2i(x, y)));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.GETMINMAXINFO:
                    {
                        if (HWndDict.TryGetValue(hWnd, out HWND? h) == false)
                        {
                            // We don't have the window in our dictionary, we can't do anything.
                            // This message will be sent during the call to CreateWindowEx, and
                            // at that time we don't have the hwnd pointer nor the HWND object setup.
                            return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                        }

                        Win32.RECT insets = default;
                        // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
                        // and ToInt32 is going to throw in that case
                        WindowStyles style = (WindowStyles)Win32.GetWindowLongPtr(h.HWnd, GetGWLPIndex.Style).ToInt64();
                        WindowStylesEx exStyle = (WindowStylesEx)Win32.GetWindowLongPtr(h.HWnd, GetGWLPIndex.ExStyle).ToInt64();

                        // FIXME: Maybe we should be calling AdjustWindowRectExForDpi if it is available?
                        Win32.AdjustWindowRectEx(ref insets, style, false, exStyle);

                        unsafe
                        {
                            ref Win32.MINMAXINFO minMaxInfo = ref Unsafe.AsRef<Win32.MINMAXINFO>((void*)lParam);

                            if (h.MinWidth is int minWidth)
                            {
                                minMaxInfo.ptMinTrackSize.X = minWidth + insets.Width;
                            }

                            if (h.MinHeight is int minHeight)
                            {
                                minMaxInfo.ptMinTrackSize.Y = minHeight + insets.Height;
                            }

                            if (h.MaxWidth is int maxWidth)
                            {
                                minMaxInfo.ptMaxTrackSize.X = maxWidth + insets.Width;
                            }

                            if (h.MaxHeight is int maxHeight)
                            {
                                minMaxInfo.ptMaxTrackSize.Y = maxHeight + insets.Height;
                            }
                        }

                        return IntPtr.Zero;
                    }
                case WM.CLOSE:
                    {
                        HWND h = HWndDict[hWnd];
                        EventQueue.Raise(h, PlatformEventType.Close, new CloseEventArgs(h));

                        // By not calling Destroy we allow the user to decide
                        // themselves if they want to destroy the window or not.
                        // Destroy(h);

                        // This could hang the window if the user code is stuck.

                        return IntPtr.Zero;
                    }
                case WM.DESTROY:
                    {
                        if (HWndDict.Count == 0)
                        {
                            Win32.PostQuitMessage(0);
                            quit = true;
                        }
                        return IntPtr.Zero;
                    }
                case WM.DEVICECHANGE:
                    {
                        Console.WriteLine($"{uMsg} {(DBT)wParam}");
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.DISPLAYCHANGE:
                    {
                        Console.WriteLine($"{uMsg} Bit depth: {wParam.ToUInt64()}, ResX: {(lParam.ToInt64() & Win32.HiWordMask) >> 16}, ResY: {lParam.ToInt64() & Win32.LoWordMask}");

                        // FIXME: Some other way of notifying the DisplayComponent that things have changed.
                        DisplayComponent.UpdateMonitors();
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.DPICHANGED:
                    {
                        Console.WriteLine($"DPI Changed! dpiY: {(wParam.ToUInt32() & Win32.HiWordMask) >> 16}, dpiX: {wParam.ToUInt32() & Win32.LoWordMask}");

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.DROPFILES:
                    {
                        IntPtr /* HDROP */ hdrop = (IntPtr)wParam.ToUInt64();

                        uint count = Win32.DragQueryFile(hdrop, 0xFFFFFFFF, null, 0);
                        Console.WriteLine($"Drop! {count}");

                        List<string> paths = new List<string>();

                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < count; i++)
                        {
                            uint size = Win32.DragQueryFile(hdrop, (uint)i, null, 0);

                            //  size does not include null terminator.
                            sb.EnsureCapacity((int)size + 1);

                            uint success = Win32.DragQueryFile(hdrop, (uint)i, sb, (uint)sb.Capacity);
                            if (success == 0)
                            {
                                // FIXME: Is is an issue? Can this happen?
                                throw new Exception();
                            }

                            paths.Add(sb.ToString());
                        }

                        bool inWindow = Win32.DragQueryPoint(hdrop, out Win32.POINT point);

                        Win32.DragFinish(hdrop);

                        HWND h = HWndDict[hWnd];

                        EventQueue.Raise(h, PlatformEventType.FileDrop, new FileDropEventArgs(paths, new Vector2i(point.X, point.Y), inWindow));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                default:
                    {
                        //Console.WriteLine(uMsg);
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
                throw new Win32Exception("CreateWindowEx failed!");
            }

            // We accept drag and drop operations.
            Win32.DragAcceptFiles(hWnd, true);

            // FIXME: Set HWND.WindowState!
            HWND hwnd = new HWND(hWnd, hints);

            HWndDict.Add(hwnd.HWnd, hwnd);

            return hwnd;
        }

        /// <inheritdoc/>
        public void Destroy(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            HWndDict.Remove(hwnd.HWnd);

            bool success = Win32.DestroyWindow(hwnd.HWnd);

            // FIXME: Do we add back the hglrc to HGLRCDict?
            if (success == false)
            {
                throw new Win32Exception("DestroyWindow failed!");
            }
        }

        /// <inheritdoc/>
        public string GetTitle(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            int textLength = Win32.GetWindowTextLength(hwnd.HWnd);

            int error = Marshal.GetLastWin32Error();
            if (textLength == 0 && error != 0)
            {
                throw new Win32Exception(error, "GetWindowTextLength: Could not get length of window text");
            }

            StringBuilder title = new StringBuilder(textLength + 1);

            Win32.GetWindowText(hwnd.HWnd, title, title.Capacity);

            return title.ToString();
        }

        /// <inheritdoc/>
        public void SetTitle(WindowHandle handle, string title)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.SetWindowText(hwnd.HWnd, title);

            if (success == false)
            {
                throw new Win32Exception("Could not set window title");
            }
        }

        /// <inheritdoc/>
        public unsafe IconHandle GetIcon(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            IntPtr hicon;

            // https://github.com/MicrosoftDocs/win32/blob/docs/desktop-src/winmsg/wm-geticon.md
            // First we try to get the icon through the WM_GETICON message
            // if that doesn't work we try GetClassLongPtr, and if that doesn't work
            // we use LoadIcon.

            hicon = Win32.SendMessage(hwnd.HWnd, WM.GETICON, new UIntPtr(1), new IntPtr(96));
            if (hicon != IntPtr.Zero)
            {
                HIcon icon = new HIcon
                {
                    // We do not manage this icon, at least not through this handle.
                    // So pretending this is a system icon will avoid deleting this icon.
                    Mode = HIcon.IconMode.SystemIcon,
                    Icon = hicon
                };

                return icon;
            }

            hicon = (IntPtr)Win32.GetClassLongPtr(hwnd.HWnd, GCLP.HIcon).ToPointer();
            if (hicon != IntPtr.Zero)
            {
                HIcon icon = new HIcon
                {
                    // We do not manage this icon, at least not through this handle.
                    // So pretending this is a system icon will avoid deleting this icon.
                    Mode = HIcon.IconMode.SystemIcon,
                    Icon = hicon
                };

                return icon;
            }

            hicon = Win32.LoadIcon(IntPtr.Zero, IDI.Application);
            {
                HIcon icon = new HIcon
                {
                    // This is a system icon.
                    Mode = HIcon.IconMode.SystemIcon,
                    Icon = hicon
                };

                return icon;
            }
        }

        /// <inheritdoc/>
        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            HWND hwnd = handle.As<HWND>(this);
            HIcon hicon = icon.As<HIcon>(this);

            hwnd.HIcon = hicon;

            // Send messages to set the icon.
            // DefWinProc returns the last sent lParam so we don't need to handle WM.SETICON as it already does what we want.
            Win32.SendMessage(hwnd.HWnd, WM.SETICON, new UIntPtr(Win32.ICON_SMALL), hicon.Icon);
            Win32.SendMessage(hwnd.HWnd, WM.SETICON, new UIntPtr(Win32.ICON_BIG), hicon.Icon);
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT lpRect);

            if (success == false)
            {
                throw new Win32Exception("GetWindowRect failed");
            }

            x = lpRect.left;
            y = lpRect.top;
        }

        /// <inheritdoc/>
        public void SetPosition(WindowHandle handle, int x, int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            bool success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, x, y, 0, 0, SetWindowPosFlags.NoSize | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("Could not set window position");
            }
        }

        /// <inheritdoc/>
        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT lpRect);

            if (success == false)
            {
                throw new Win32Exception("GetWindowRect failed");
            }

            width = lpRect.right - lpRect.left;
            height = lpRect.bottom - lpRect.top;
        }

        /// <inheritdoc/>
        public void SetSize(WindowHandle handle, int width, int height)
        {
            HWND hwnd = handle.As<HWND>(this);

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            bool success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, 0, 0, width, height, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("Could not set window size");
            }
        }

        /// <inheritdoc/>
        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            Win32.POINT point = new Win32.POINT(0, 0);

            bool success = Win32.ClientToScreen(hwnd.HWnd, ref point);

            if (success == false)
            {
                throw new Win32Exception("ClientToScreen failed");
            }

            x = point.X;
            y = point.Y;
        }

        /// <inheritdoc/>
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
                throw new Win32Exception("AdjustWindowRect failed");
            }

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, rect.left, rect.top, 0, 0, SetWindowPosFlags.NoSize | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("Could not set window position");
            }
        }

        /// <inheritdoc/>
        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success = Win32.GetClientRect(hwnd.HWnd, out Win32.RECT lpRect);

            if (success == false)
            {
                throw new Win32Exception("GetClientRect failed");
            }

            width = lpRect.right;
            height = lpRect.bottom;
        }

        /// <inheritdoc/>
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
                throw new Win32Exception("AdjustWindowRect failed");
            }

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            // FIXME: Constant for this SetWindowPosFlags combo?
            success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, 0, 0, rect.Width, rect.Height, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("SetWindowPos failed");
            }
        }

        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            width = hwnd.MaxWidth;
            height = hwnd.MaxHeight;
        }

        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            hwnd.MaxWidth = width;
            hwnd.MaxHeight = height;

            // Call MoveWindow to trigger a recalculation of the window size.
            // MoveWindow causes WM_WINDOWPOSCHANGING to be sent which causes
            // WM_GETMINMAXINFO to be sent.
            Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT rect);
            Win32.MoveWindow(hwnd.HWnd, rect.left, rect.top, rect.Width, rect.Height, true);
        }

        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            width = hwnd.MinWidth;
            height = hwnd.MinHeight;
        }

        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            hwnd.MinWidth = width;
            hwnd.MinHeight = height;

            // Call MoveWindow to trigger a recalculation of the window size.
            // MoveWindow causes WM_WINDOWPOSCHANGING to be sent which causes
            // WM_GETMINMAXINFO to be sent.
            Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT rect);
            Win32.MoveWindow(hwnd.HWnd, rect.left, rect.top, rect.Width, rect.Height, true);
        }

        /// <inheritdoc/>
        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            IntPtr hmonitor = Win32.MonitorFromWindow(hwnd.HWnd, MonitorDefaultTo.Nearest);

            HMonitor? monitor = DisplayComponent.FindMonitor(hmonitor);
            if (monitor == null)
            {
                throw new PalException(this, $"Couldn't get monitor from window. (hwnd: {hwnd.HWnd}, hmonitor: {hmonitor})");
            }

            return monitor;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            HWND hwnd = handle.As<HWND>(this);

            const nint HWND_TOPMOST = -1;
            const nint HWND_NOTOPMOST = -2;

            nint topmost = floating ? HWND_TOPMOST : HWND_NOTOPMOST;

            bool success = Win32.SetWindowPos(hwnd.HWnd, topmost, 0, 0, 0, 0, SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoSize | SetWindowPosFlags.NoMove);
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStylesEx windowStyleEx = (WindowStylesEx)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.ExStyle).ToInt64();

            Console.WriteLine($"StyleEx: {windowStyleEx}");

            return (windowStyleEx & WindowStylesEx.WS_EX_TOPMOST) == WindowStylesEx.WS_EX_TOPMOST;
        }

        /// <inheritdoc/>
        public void SetCursor(WindowHandle handle, CursorHandle cursor)
        {
            HWND hwnd = handle.As<HWND>(this);
            HCursor? hcursor = cursor?.As<HCursor>(this);

            hwnd.HCursor = hcursor;

            // A hCursor = null means a hidden cursor, as we want.
            Win32.SetCursor(hcursor?.Cursor ?? IntPtr.Zero);
        }

        /// <inheritdoc/>
        public void FocusWindow(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            // If SetFocus returns NULL and last error is Success we don't throw an exception.
            // https://stackoverflow.com/questions/24073695/winapi-can-setfocus-return-null-without-an-error-because-thats-what-im-see
            IntPtr prev = Win32.SetFocus(hwnd.HWnd);
            if (prev == IntPtr.Zero)
            {
                int lastError = Marshal.GetLastWin32Error();
                if (lastError != 0)
                {
                    throw new Win32Exception(lastError);
                }
            }
        }

        /// <inheritdoc/>
        public void RequestAttention(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            // FIXME: Figure out what settings we want here,
            // or if the user should be able to set them?
            Win32.FLASHWINFO flashInfo;
            flashInfo.cbSize = (uint)Marshal.SizeOf<Win32.FLASHWINFO>();
            flashInfo.hwnd = hwnd.HWnd;
            flashInfo.dwFlags = FLASHW.All | FLASHW.TimerNoFG;
            flashInfo.uCount = 0;
            flashInfo.dwTimeout = 0;

            Win32.FlashWindowEx(in flashInfo);
        }

        /// <inheritdoc/>
        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            HWND hwnd = handle.As<HWND>(this);

            Win32.POINT point;
            point.X = x;
            point.Y = y;
            bool success = Win32.ScreenToClient(hwnd.HWnd, ref point);
            if (success == false)
            {
                throw new Win32Exception("ScreenToClient failed.");
            }

            clientX = point.X;
            clientY = point.Y;
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            HWND hwnd = handle.As<HWND>(this);

            Win32.POINT point;
            point.X = clientX;
            point.Y = clientY;
            bool success = Win32.ClientToScreen(hwnd.HWnd, ref point);
            if (success == false)
            {
                throw new Win32Exception("ClientToScreen failed.");
            }

            x = point.X;
            y = point.Y;
        }

        public void SwapBuffers(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            IntPtr hDC = Win32.GetDC(hwnd.HWnd);

            bool success = Win32.SwapBuffers(hDC);

            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
        public IEventQueue<PlatformEventType, WindowEventArgs> GetEventQueue(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);
            return null;
        }
    }
}
