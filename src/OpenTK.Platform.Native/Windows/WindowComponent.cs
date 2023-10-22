﻿using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using OpenTK.Core;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;
using OpenTK.Core.Platform.Interfaces;

namespace OpenTK.Platform.Native.Windows
{
    /// <summary>
    /// Win32 implementation of <see cref="IWindowComponent"/>.
    /// </summary>
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

        // This is the window we are currently capturing the cursor in.
        internal static HWND? CursorCapturingWindow;

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
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new PalException(this, "WindowComponent can only initialize the Window component.");
            }

            // Set the WindowProc delegate so that we capture "this".
            // FIXME: Does this cause GC issues where "this" is circularly referenced?
            WindowProc = Win32WindowProc;

            // FIXME: Maybe try extract the small icon too?
            // Get the exe path and extract the icon if possible, this will be the window default icon.
            IntPtr icon = IntPtr.Zero;
            string? processPath = Environment.ProcessPath;
            if (string.IsNullOrEmpty(processPath) == false)
            {
                ushort index = 0;
                icon = Win32.ExtractAssociatedIcon(HInstance, processPath, ref index);
                if (icon == IntPtr.Zero)
                {
                    Logger?.LogWarning($"Could not extract exe icon from '{processPath}': {new Win32Exception().Message}");
                }
            }
            else
            {
                Logger?.LogWarning("Could not get process path, will not extract window icon.");
            }

            // Here we register the window class that we will use for all created windows.
            Win32.WNDCLASSEX wndClass = Win32.WNDCLASSEX.Create();
            wndClass.style = ClassStyles.OwnDC;
            wndClass.lpfnWndProc = WindowProc;
            wndClass.hInstance = HInstance;
            wndClass.hIcon = icon;
            wndClass.lpszClassName = CLASS_NAME;

            short wndClassAtom = Win32.RegisterClassEx(in wndClass);

            if (wndClassAtom == 0)
            {
                throw new Win32Exception("RegisterClassEx failed!");
            }

            HelperHWnd = Win32.CreateWindowEx(
                0,
                WindowComponent.CLASS_NAME,
                "OpenTK Helper Window",
                WindowStyles.ClipSiblings | WindowStyles.ClipChildren,
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
            while (Win32.PeekMessage(out Win32.MSG lpMsg, HelperHWnd, 0, 0, PM.Remove))
            {
                Win32.TranslateMessage(in lpMsg);
                Win32.DispatchMessage(in lpMsg);
            }

            Win32.DEV_BROADCAST_DEVICEINTERFACE dbh = default;
            dbh.dbcc_size = (uint)Marshal.SizeOf<Win32.DEV_BROADCAST_DEVICEINTERFACE>();
            dbh.dbcc_devicetype = DBTDevType.DeviceInterface;
            dbh.dbcc_classguid = Win32.GUID_DEVINTERFACE_HID;

            // We assume we are going to need these notification handles for the lifetime of the application, so we do not close them.
            // - 2023-06-28 Noggin_bops
            IntPtr devNotifHandle = Win32.RegisterDeviceNotification(HelperHWnd, dbh, DEVICE_NOTIFY.DEVICE_NOTIFY_WINDOW_HANDLE);
            IntPtr resumeSuspendNotifHandle = Win32.RegisterSuspendResumeNotification(HelperHWnd, DEVICE_NOTIFY.DEVICE_NOTIFY_WINDOW_HANDLE);

            // Register for WM_CLIPBOARDUPDATE
            bool success = Win32.AddClipboardFormatListener(HelperHWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
        public bool CanSetIcon => true;

        /// <inheritdoc/>
        public bool CanGetDisplay => true;

        /// <inheritdoc/>
        public bool CanSetCursor => true;

        /// <inheritdoc/>
        public bool CanCaptureCursor => true;

        /// <inheritdoc/>
        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowBorderStyle> SupportedStyles => _SupportedStyles;

        /// <inheritdoc/>
        public IReadOnlyList<WindowMode> SupportedModes => _SupportedModes;

        private IntPtr Win32WindowProc(IntPtr hWnd, WM uMsg, UIntPtr wParam, IntPtr lParam)
        {
            // Filter out helper window messages early.
            if (hWnd == HelperHWnd)
            {
                switch (uMsg)
                {
                    case WM.POWERBROADCAST:
                    {
                        // We are only interested in the messages sent to the helper window that we registered to get notifications.
                        // - 2023-03-29 NogginBops
                        PBT power = (PBT)wParam;

                        if (power == PBT.APMSuspend)
                        {
                            EventQueue.Raise(null, PlatformEventType.PowerStateChange, new PowerStateChangeEventArgs(true));
                        }
                        else if (power == PBT.APMResumeAutomatic)
                        {
                            EventQueue.Raise(null, PlatformEventType.PowerStateChange, new PowerStateChangeEventArgs(false));
                        }

                        return (IntPtr)1;
                    }
                    default:
                    {
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                }
            }

            //Console.WriteLine("WinProc " + message + " " + hWnd);
            switch (uMsg)
            {
                case WM.KEYDOWN:
                case WM.SYSKEYDOWN:
                    {
                        HWND h = HWndDict[hWnd];

                        bool sysKey = uMsg == WM.SYSKEYUP;

                        // FIXME: Is there ever a virtual key that doesn't fit in an int?
                        VK vk = (VK)wParam.ToUInt64();
                        long l = lParam.ToInt64();
                        int scancode = (int)(l & 0x0000FF0000) >> 16;
                        bool wasDown = (l & (1 << 30)) != 0;
                        bool extended = (l & (1 << 24)) != 0;

                        if (vk == VK.Control && extended == false)
                        {
                            // Pressing Alt-gr sends VK_CONTROL followed by VK_MENU
                            int time = Win32.GetMessageTime();

                            if (Win32.PeekMessage(out Win32.MSG msg, IntPtr.Zero, 0, 0, PM.NoRemove))
                            {
                                if (msg.message == WM.KEYDOWN || msg.message == WM.SYSKEYDOWN)
                                {
                                    bool isExtended = (msg.lParam.ToInt64() & (1 << 24)) != 0;
                                    if ((VK)msg.wParam.ToUInt64() == VK.Menu && isExtended && msg.time == time)
                                    {
                                        // This message is the VK_CONTROL message triggered from pressing Alt-Gr
                                        // So we should ignore this message and only handle the Alt-Gr message.
                                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                                    }
                                }
                            }
                        }

                        Scancode code = KeyboardComponent.ToScancode(scancode, vk, extended);
                        Key key = KeyboardComponent.ToKey(scancode, vk, extended);
                        Console.WriteLine($"{(sysKey ? "Sys " : "")}Key: {key}, Scancode: {code}, VK: {vk}, Win: 0x{scancode:X}, Extended: {extended}");

                        EventQueue.Raise(h, PlatformEventType.KeyDown, new KeyDownEventArgs(h, key, code, wasDown));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.KEYUP:
                case WM.SYSKEYUP:
                    {
                        HWND h = HWndDict[hWnd];

                        // FIXME: It seems there is a bug when both left and right GUI are
                        // pressed in short succession where only one WM_KEYUP message gets sent.

                        // FIXME: Holding down both shift keys results in only one WM_KEYUP message.

                        bool sysKey = uMsg == WM.SYSKEYUP;

                        ulong vk = wParam.ToUInt64();
                        long l = lParam.ToInt64();
                        int scancode = (int)(l & 0x0000FF0000) >> 16;
                        bool extended = (l & (1 << 24)) != 0;

                        // FIXME: Should we peek messages like in keydown?
                        if (uMsg == WM.SYSKEYUP && (VK)vk == VK.Control)
                        {
                            return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                        }

                        Scancode code = KeyboardComponent.ToScancode(scancode, (VK)vk, extended);
                        Key key = KeyboardComponent.ToKey(scancode, (VK)vk, extended);
                        Console.WriteLine($"{(sysKey ? "Sys " : "")}Key: {key}, Scancode: {code}, VK: {(VK)vk}, Win: 0x{scancode:X}, Extended: {extended}");

                        // Print screen only generates a WM_KEYUP event, so we need to send the KeyDown event here.
                        // - 2023-02-13 NogginBops
                        if (code == Scancode.PrintScreen)
                        {
                            EventQueue.Raise(h, PlatformEventType.KeyDown, new KeyDownEventArgs(h, key, code, false));
                        }

                        EventQueue.Raise(h, PlatformEventType.KeyUp, new KeyUpEventArgs(h, key, code));

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

                            switch (chars)
                            {
                                case 0x0A: // linefeed, SHIFT + ENTER
                                case 0x0D: // carriage return, ENTER
                                    str = "\r\n";
                                    break;
                                case 0x08: // backspace
                                case 0x09: // tab
                                case 0x1B: // escape
                                    // FIXME: For now we just send these to the user directly,
                                    // but maybe we want something better?
                                    // or we just formalize this?
                                default:
                                    {
                                        // FIXME: Do we even need to handle this??
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
                                        break;
                                    }
                            }

                            EventQueue.Raise(h, PlatformEventType.TextInput, new TextInputEventArgs(h, str));
                        }
                        else
                        {
                            // ANSI
                            EventQueue.Raise(h, PlatformEventType.TextInput, new TextInputEventArgs(h, new string((char)(wParam.ToUInt64()), 1)));
                        }

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.SETFOCUS:
                    {
                        HWND h = HWndDict[hWnd];

                        // Because windows removes our capture when we loose focus,
                        // we need to re-capture the mouse when we get focus again.
                        // - Noggin_bops 2023-01-16
                        if ((h.CaptureMode == CursorCaptureMode.Confined ||
                            h.CaptureMode == CursorCaptureMode.Locked))
                        {
                            RecaptureCursor(h, h.CaptureMode);
                        }

                        EventQueue.Raise(h, PlatformEventType.Focus, new FocusEventArgs(h, true));
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.KILLFOCUS:
                    {
                        // This message can be sent after WM_CLOSE which means that the specificed window might not exist any more.
                        if (HWndDict.TryGetValue(hWnd, out HWND? h))
                        {
                            if (h.CaptureMode == CursorCaptureMode.Confined ||
                                h.CaptureMode == CursorCaptureMode.Locked)
                            {
                                // Release the mouse when we lose focus, without changing h.CaptureMode
                                // so that we recapture the mouse when get get focus back.
                                RecaptureCursor(h, CursorCaptureMode.Normal);
                            }

                            EventQueue.Raise(h, PlatformEventType.Focus, new FocusEventArgs(h, false));
                        }

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.SETCURSOR:
                    {
                        int ht = ((int)lParam) & Win32.LoWordMask;
                        if (ht == Win32.HTCLIENT)
                        {
                            HWND h = HWndDict[hWnd];
                            // FIXME: Make the normal arrow cursor the default cursor, while keeping the ability of hiding the cursor.
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
                            if (Win32.TrackMouseEvent(ref tme))
                            {
                                h.TrackingMouse = true;
                            }
                            else
                            {
                                throw new Win32Exception();
                            }

                            EventQueue.Raise(h, PlatformEventType.MouseEnter, new MouseEnterEventArgs(h, true));
                        }

                        if (CursorCapturingWindow == h && h.CaptureMode == CursorCaptureMode.Locked)
                        {
                            // When recentering the cursor we set LastMousePosition equal to the new position.
                            // This will cause the delta calculation to return zero, which is how we
                            // ignore the WM_MOUSEMOVE event sent when recentering.
                            // - Noggin_bops 2023-01-16
                            Vector2 delta = (x, y) - h.LastMousePosition;

                            if (delta != (0, 0))
                            {
                                h.VirtualCursorPosition += delta;
                                EventQueue.Raise(h, PlatformEventType.MouseMove, new MouseMoveEventArgs(h, h.VirtualCursorPosition));
                            }
                        }
                        else
                        {
                            EventQueue.Raise(h, PlatformEventType.MouseMove, new MouseMoveEventArgs(h, new Vector2(x, y)));
                        }

                        h.LastMousePosition = (x, y);

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.MOUSELEAVE:
                    {
                        HWND h = HWndDict[hWnd];
                        h.TrackingMouse = false;

                        EventQueue.Raise(h, PlatformEventType.MouseEnter, new MouseEnterEventArgs(h, false));

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
                                        //Console.WriteLine($"Unknown xbutton: {(uint)hiWord}");
                                        Logger?.LogDebug($"Unknown xbutton: {(uint)hiWord}");
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
                            EventQueue.Raise(h, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(h, button.Value));
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
                                        //Console.WriteLine($"Unknown xbutton: {(uint)hiWord}");
                                        Logger?.LogDebug($"Unknown xbutton: {(uint)hiWord}");
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
                            EventQueue.Raise(h, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(h, button.Value));
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

                        EventQueue.Raise(h, PlatformEventType.Scroll, new ScrollEventArgs(h, new Vector2(0, delta), new Vector2(0, delta * lines)));

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

                        EventQueue.Raise(h, PlatformEventType.Scroll, new ScrollEventArgs(h, new Vector2(delta, 0), new Vector2(delta * chars, 0)));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.NCHITTEST:
                    {
                        int x = Win32.GET_X_LPARAM(lParam);
                        int y = Win32.GET_Y_LPARAM(lParam);

                        HWND h = HWndDict[hWnd];

                        ScreenToClient(h, x, y, out int clientX, out int clientY);

                        if (h.HitTest != null)
                        {
                            HitType type = h.HitTest(h, new Vector2(clientX, clientY));

                            switch (type)
                            {
                                case HitType.Default:
                                    IntPtr ret = Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                                    Console.WriteLine($"Hit: {(HT)(int)ret}");
                                    return ret;
                                case HitType.Normal:
                                    return (IntPtr)HT.Client;
                                case HitType.Draggable:
                                    return (IntPtr)HT.Caption;
                                case HitType.ResizeTopLeft:
                                    return (IntPtr)HT.TopLeft;
                                case HitType.ResizeTop:
                                    return (IntPtr)HT.Top;
                                case HitType.ResizeTopRight:
                                    return (IntPtr)HT.TopRight;
                                case HitType.ResizeRight:
                                    return (IntPtr)HT.Right;
                                case HitType.ResizeBottomRight:
                                    return (IntPtr)HT.BottomRight;
                                case HitType.ResizeBottom:
                                    return (IntPtr)HT.Bottom;
                                case HitType.ResizeBottomLeft:
                                    return (IntPtr)HT.BottomLeft;
                                case HitType.ResizeLeft:
                                    return (IntPtr)HT.Left;
                                default:
                                    throw new InvalidEnumArgumentException("hit test return", (int)type, typeof(HitType));
                            }
                        }
                        else
                        {
                            return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                        }
                    }
                case WM.SIZE:
                    {
                        SIZE size = (SIZE)wParam.ToUInt32();

                        HWND h = HWndDict[hWnd];

                        WindowState prevWindowState = h.WindowState;

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

                        // If the window is (going) fullscreen we don't want to set the a min or max size
                        if (h.FullscreenMonitor != null)
                        {
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
                case WM.DEVICECHANGE:
                    {
                        DBT dbt = (DBT)wParam;
                        switch (dbt)
                        {
                            case DBT.DeviceArrival:
                            case DBT.DeviceRemoveComplete:
                                // FIXME: Implement joystick events!
                                // JoystickComponent.UpdateJoysticks();
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine($"{uMsg} {(DBT)wParam} 0x{wParam.ToUInt64():X16}");
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.DISPLAYCHANGE:
                    {
                        // FIXME: We should not only look for changes in resolution and connectivity, we should also look for
                        // changes in position etc.
                        // Should we just expose an event that tells users that there might have been some changes to displays?
                        // - Noggin_bops 2023-09-05

                        Console.WriteLine($"{uMsg} Bit depth: {wParam.ToUInt64()}, ResX: {(lParam.ToInt64() & Win32.HiWordMask) >> 16}, ResY: {lParam.ToInt64() & Win32.LoWordMask}");

                        // FIXME: Some other way of notifying the DisplayComponent that things have changed.
                        DisplayComponent.UpdateMonitors();
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.DPICHANGED:
                    {
                        const int USER_DEFAULT_SCREEN_DPI = 96;

                        int dpiX = (int)(wParam.ToUInt32() & Win32.LoWordMask);
                        int dpiY = (int)((wParam.ToUInt32() & Win32.HiWordMask) >> 16);

                        float scaleX = dpiX / (float)USER_DEFAULT_SCREEN_DPI;
                        float scaleY = dpiY / (float)USER_DEFAULT_SCREEN_DPI;

                        Logger?.LogDebug($"DPI Changed! dpiY: {dpiY}, dpiX: {dpiX}");

                        HWND h = HWndDict[hWnd];

                        // FIXME: Should we send this message before or after resizing the application?
                        EventQueue.Raise(h, PlatformEventType.WindowDpiChange, new WindowDpiChangeEventArgs(h, dpiX, dpiY, scaleX, scaleY));

                        // FIXME: glfw limits this to windows 10 only??
                        // https://github.com/glfw/glfw/blob/dd8a678a66f1967372e5a5e3deac41ebf65ee127/src/win32_window.c#L1186

                        Win32.RECT suggested = Marshal.PtrToStructure<Win32.RECT>(lParam);

                        Win32.SetWindowPos(hWnd, IntPtr.Zero /* HWND_TOP */, suggested.left, suggested.top, suggested.Width, suggested.Height,
                            SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder);

                        return IntPtr.Zero;
                    }
                case WM.DROPFILES:
                    {
                        IntPtr /* HDROP */ hdrop = (IntPtr)wParam.ToUInt64();

                        uint count = Win32.DragQueryFile(hdrop, 0xFFFFFFFF, null, 0);

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

                        EventQueue.Raise(h, PlatformEventType.FileDrop, new FileDropEventArgs(h, paths, new Vector2i(point.X, point.Y)));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.SETTINGCHANGE:
                    {
                        ShellComponent.CheckPreferredThemeChange();

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.CLIPBOARDUPDATE:
                    {
                        ClipboardFormat newFormat = ClipboardComponent.GetClipboardFormatInternal(Logger);

                        EventQueue.Raise(null, PlatformEventType.ClipboardUpdate, new ClipboardUpdateEventArgs(newFormat));

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.THEMECHANGED:
                    {
                        ShellComponent.CheckPreferredThemeChange();

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.IME_COMPOSITION:
                    {
                        const long IMM_ERROR_NODATA = -1;
                        const long IMM_ERROR_GENERAL = -2;

                        HWND h = HWndDict[hWnd];

                        GCS gcs = (GCS)lParam;

                        IntPtr hmic = Win32.ImmGetContext(hWnd);

                        if (gcs.HasFlag(GCS.CompStr))
                        {
                            long length = Win32.ImmGetCompositionString(hmic, GCS.CompStr, (Span<byte>)null, 0);
                            if (length == IMM_ERROR_NODATA || length == IMM_ERROR_GENERAL)
                            {
                                throw new Win32Exception("IME error");
                            }
                            else
                            {
                                byte[] bytes = new byte[length];

                                long written = Win32.ImmGetCompositionString(hmic, GCS.CompStr, bytes, (uint)bytes.Length);
                                if (written == IMM_ERROR_NODATA || written == IMM_ERROR_GENERAL)
                                {
                                    throw new Win32Exception("IME error");
                                }

                                string composition = Encoding.Unicode.GetString(bytes, 0, (int)written);

                                int IMECursor = (int)Win32.ImmGetCompositionString(hmic, GCS.CursorPos, (Span<byte>)null, 0);
                                if (IMECursor == IMM_ERROR_NODATA || IMECursor == IMM_ERROR_GENERAL)
                                {
                                    throw new Win32Exception($"IME error: 0x{IMECursor:X}");
                                }

                                EventQueue.Raise(h, PlatformEventType.TextEditing, new TextEditingEventArgs(h, composition, IMECursor, 0));
                            }
                        }

                        if (gcs.HasFlag(GCS.ResultStr))
                        {
                            long length = Win32.ImmGetCompositionString(hmic, GCS.ResultStr, (Span<byte>)null, 0);
                            if (length == IMM_ERROR_NODATA || length == IMM_ERROR_GENERAL)
                            {
                                throw new Win32Exception($"IME error: 0x{length:X}");
                            }
                            else
                            {
                                byte[] bytes = new byte[length];

                                long written = Win32.ImmGetCompositionString(hmic, GCS.ResultStr, bytes, (uint)bytes.Length);
                                if (written == IMM_ERROR_NODATA || written == IMM_ERROR_GENERAL)
                                {
                                    throw new Win32Exception($"IME error: 0x{written:X}");
                                }

                                string composition = Encoding.Unicode.GetString(bytes, 0, (int)written);

                                int IMECursor = (int)Win32.ImmGetCompositionString(hmic, GCS.CursorPos, (Span<byte>)null, 0);
                                if (IMECursor == IMM_ERROR_NODATA || IMECursor == IMM_ERROR_GENERAL)
                                {
                                    throw new Win32Exception($"IME error: 0x{IMECursor:X}");
                                }

                                EventQueue.Raise(h, PlatformEventType.TextEditing, new TextInputEventArgs(h, composition));
                            }
                        }

                        Win32.ImmReleaseContext(hWnd, hmic);

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                case WM.INPUTLANGCHANGE:
                    {
                        // This might not always work
                        // See: http://archives.miloush.net/michkap/archive/2006/05/16/598980.html
                        // For now we don't do anything about this as we assume TSF is not going to
                        // be activated for our windows.
                        // - Noggin_bops 2023-03-09

                        HWND h = HWndDict[hWnd];

                        IntPtr hKL = lParam;

                        KeyboardComponent.KeyboardLayoutChange(h, hKL);

                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
                default:
                    {
                        //Console.WriteLine(uMsg);
                        return Win32.DefWindowProc(hWnd, uMsg, wParam, lParam);
                    }
            }
        }

        /// <inheritdoc/>
        public void ProcessEvents(bool waitForEvents = false)
        {
            while (Win32.PeekMessage(out Win32.MSG lpMsg, IntPtr.Zero, 0, 0, PM.Remove))
            {
                Win32.TranslateMessage(in lpMsg);
                Win32.DispatchMessage(in lpMsg);
            }

            if (CursorCapturingWindow != null && CursorCapturingWindow.CaptureMode == CursorCaptureMode.Locked)
            {
                GetClientSize(CursorCapturingWindow, out int width, out int height);
                if (CursorCapturingWindow.LastMousePosition != (width / 2, height / 2))
                {
                    Win32.POINT p = new Win32.POINT(width / 2, height / 2);
                    Win32.ClientToScreen(CursorCapturingWindow.HWnd, ref p);

                    bool success = Win32.SetCursorPos(p.X, p.Y);
                    if (success == false)
                    {
                        throw new Win32Exception();
                    }

                    // Set the last mouse position to the position we are moving to
                    // to avoid generating a mouse move event.
                    CursorCapturingWindow.LastMousePosition = (width / 2, height / 2);
                }
            }
        }

        /// <inheritdoc/>
        public WindowHandle Create(GraphicsApiHints hints)
        {
            IntPtr hWnd = Win32.CreateWindowEx(
                0,
                CLASS_NAME,
                "",
                WindowStyles.OverlappedWindow,
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
                throw new Win32Exception();
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

            if (CursorCapturingWindow == hwnd)
            {
                SetCursorCaptureMode(hwnd, CursorCaptureMode.Normal);
            }

            if (hwnd.FullscreenMonitor != null)
            {
                // The window is closing so we want to reset the video mode of the window.
                Win32.ChangeDisplaySettingsExW(hwnd.FullscreenMonitor.AdapterName, IntPtr.Zero, IntPtr.Zero, CDS.Fullscreen, IntPtr.Zero);
            }

            HWndDict.Remove(hwnd.HWnd);

            bool success = Win32.DestroyWindow(hwnd.HWnd);

            hwnd.Destroyed = true;

            // If we failed to destroy the window we want to know about it.
            // Atleast for now.
            // - 2023-06-28 Noggin_bops
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
        public bool IsWindowDestroyed(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            return hwnd.Destroyed;
        }

        /// <inheritdoc/>
        public string GetTitle(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            int textLength = Win32.GetWindowTextLength(hwnd.HWnd);

            int error = Marshal.GetLastWin32Error();
            if (textLength == 0 && error != 0)
            {
                throw new Win32Exception(error);
            }

            StringBuilder title = new StringBuilder(textLength + 1);

            int written = Win32.GetWindowText(hwnd.HWnd, title, title.Capacity);
            error = Marshal.GetLastWin32Error();
            if (written == 0 && error != 0)
            {
                throw new Win32Exception(error);
            }

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

            // FIXME: We should probably just return an icon if it's already been set.
            // And we want to make sure we return the same reference that was passed in SetIcon.

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

            // This assumes the window doesn't have a menu bar or scroll bars. For now our windows don't have those, but it's possible that could change.
            // A user could also modify the window manually so that it has a menubar or scrollbar.
            // If there is an easy way to detect this we could dynamically change the bool here, but for now we just assume that they aren't there.
            // - 2023-06-28 Noggin_bops
            bool success = Win32.AdjustWindowRect(ref rect, currentStyle, false);

            if (success == false)
            {
                throw new Win32Exception("AdjustWindowRect failed");
            }

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
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

            // This assumes the window doesn't have a menu bar or scroll bars. For now our windows don't have those, but it's possible that could change.
            // A user could also modify the window manually so that it has a menubar or scrollbar.
            // If there is an easy way to detect this we could dynamically change the bool here, but for now we just assume that they aren't there.
            // - 2023-06-28 Noggin_bops
            bool success = Win32.AdjustWindowRect(ref rect, currentStyle, false);

            if (success == false)
            {
                throw new Win32Exception("AdjustWindowRect failed");
            }

            // FIXME: What do we want to do here with SetWindowPosFlags.NoActivate??
            success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero, 0, 0, rect.Width, rect.Height, SetWindowPosFlags.NoMove | SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder);

            if (success == false)
            {
                throw new Win32Exception("SetWindowPos failed");
            }
        }

        /// <inheritdoc/>
        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            width = hwnd.MaxWidth;
            height = hwnd.MaxHeight;
        }

        /// <inheritdoc/>
        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            hwnd.MaxWidth = width;
            hwnd.MaxHeight = height;

            // Call MoveWindow to trigger a recalculation of the window size.
            // MoveWindow causes WM_WINDOWPOSCHANGING to be sent which causes
            // WM_GETMINMAXINFO to be sent, which handles min/max client size.
            Win32.GetWindowRect(hwnd.HWnd, out Win32.RECT rect);
            Win32.MoveWindow(hwnd.HWnd, rect.left, rect.top, rect.Width, rect.Height, true);
        }

        /// <inheritdoc/>
        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            width = hwnd.MinWidth;
            height = hwnd.MinHeight;
        }

        /// <inheritdoc/>
        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            HWND hwnd = handle.As<HWND>(this);

            hwnd.MinWidth = width;
            hwnd.MinHeight = height;

            // Call MoveWindow to trigger a recalculation of the window size.
            // MoveWindow causes WM_WINDOWPOSCHANGING to be sent which causes
            // WM_GETMINMAXINFO to be sent, which handles min/max client size.
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
                // Throwing an exception here feels a bit brittle? Maybe just return the primary handle?
                // - 2023-06-24 Noggin_Bops
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

            if (hwnd.FullscreenMonitor != null)
            {
                if (hwnd.ExclusiveFullscreen)
                {
                    return WindowMode.ExclusiveFullscreen;
                }
                else
                {
                    return WindowMode.WindowedFullscreen;
                }
            }

            if (style.HasFlag(WindowStyles.Visible) == false)
            {
                return WindowMode.Hidden;
            }
            else
            {
                if (style.HasFlag(WindowStyles.Minimize))
                {
                    return WindowMode.Minimized;
                }
                else if (style.HasFlag(WindowStyles.Maximize))
                {
                    return WindowMode.Maximized;
                }
                else
                {
                    return WindowMode.Normal;
                }
            }
        }

        private static readonly WindowMode[] _SupportedModes = new[]
        {
            WindowMode.Hidden,
            WindowMode.Minimized,
            WindowMode.Normal,
            WindowMode.Maximized,
            WindowMode.WindowedFullscreen,
        };

        /// <inheritdoc/>
        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            HWND hwnd = handle.As<HWND>(this);

            if (hwnd.FullscreenMonitor != null)
            {
                if (mode != WindowMode.WindowedFullscreen || mode != WindowMode.ExclusiveFullscreen)
                {
                    Win32.ChangeDisplaySettingsExW(hwnd.FullscreenMonitor.AdapterName, IntPtr.Zero, IntPtr.Zero, CDS.Fullscreen, IntPtr.Zero);

                    hwnd.FullscreenMonitor = null;
                    // FIXME: When going from maximized to fullscreen to maximized the max bounds will not be respected by SetWindowPlacement.
                    // - 2023-06-13 Noggin_bops
                    Win32.SetWindowPlacement(hwnd.HWnd, hwnd.PreviousPlacement);
                    hwnd.PreviousPlacement = default;

                    // FIXME: Maybe do this only when the window needs to get it's borders back.
                    SetBorderStyle(hwnd, hwnd.PreviousBorderStyle);
                }
            }

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
                    Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.Normal);
                    break;
                case WindowMode.Maximized:
                    Win32.ShowWindow(hwnd.HWnd, ShowWindowCommands.Maximize);
                    break;
                case WindowMode.WindowedFullscreen:
                    {
                        SetFullscreenDisplay(handle, null);
                        break;
                    }
                case WindowMode.ExclusiveFullscreen:
                    {
                        HMonitor monitor = (HMonitor)GetDisplay(handle);
                        SetFullscreenDisplay(handle, monitor, new VideoMode(monitor.Resolution.ResolutionX, monitor.Resolution.ResolutionY, monitor.RefreshRate, monitor.BitsPerPixel));
                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, mode.GetType());
            }
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle? display)
        {
            HWND hwnd = window.As<HWND>(this);

            Win32.MONITORINFO info = default;
            unsafe { info.cbSize = (uint)sizeof(Win32.MONITORINFO); }

            HMonitor monitor;
            if (display != null)
            {
                monitor = display.As<HMonitor>(this);
            }
            else
            {
                monitor = (HMonitor)GetDisplay(hwnd);
            }

            if (Win32.GetMonitorInfo(monitor.Monitor, ref info))
            {
                // Save the previous window placement so we can restore it later.
                Win32.WINDOWPLACEMENT placement = default;
                unsafe { placement.length = (uint)sizeof(Win32.WINDOWPLACEMENT); }
                Win32.GetWindowPlacement(hwnd.HWnd, ref placement);
                hwnd.PreviousPlacement = placement;
                hwnd.FullscreenMonitor = monitor;
                hwnd.ExclusiveFullscreen = false;
                hwnd.PreviousBorderStyle = GetBorderStyle(hwnd);

                // FIXME: Maybe we should do this with SetBorderStyle to be consistent with how we restore the style later?
                // FIXME: check if we need to remove the window decorations.
                WindowStyles style = (WindowStyles)(uint)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style);
                Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((int)(style & ~WindowStyles.OverlappedWindow)));

                bool success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero,
                        info.rcMonitor.left,
                        info.rcMonitor.top,
                        info.rcMonitor.right - info.rcMonitor.left,
                        info.rcMonitor.bottom - info.rcMonitor.top,
                        // FIXME: Only set FrameChanged if we've disabled decorations?
                        SetWindowPosFlags.NoOwnerZOrder | SetWindowPosFlags.FrameChanged);
                if (success == false) throw new Win32Exception();
            }
            else
            {
                // FIXME: Can this even happen?
                Logger?.LogError($"Could not get monitor info from monitor {monitor} ('{monitor.DeviceName}').");
            }
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle display, VideoMode videoMode)
        {
            HWND hwnd = window.As<HWND>(this);
            HMonitor hmonitor = display.As<HMonitor>(this);

            // Set the video mode!
            {
                Win32.DEVMODE devmode = default;
                devmode.dmSize = (ushort)Marshal.SizeOf<Win32.DEVMODE>();
                devmode.dmFields = DM.PelsWidth | DM.PelsHeight | DM.BitsPerPel | DM.DisplayFrequency;
                devmode.dmPelsWidth = (uint)videoMode.Width;
                devmode.dmPelsHeight = (uint)videoMode.Height;
                devmode.dmDisplayFrequency = (uint)videoMode.RefreshRate;
                devmode.dmBitsPerPel = (uint)videoMode.BitsPerPixel;

                DispChange result = Win32.ChangeDisplaySettingsExW(hmonitor.AdapterName, ref devmode, IntPtr.Zero, CDS.Fullscreen, IntPtr.Zero);
                if (result != DispChange.Successful)
                {
                    Logger?.LogError($"Could not set display mode: {result}");
                }
            }

            Win32.MONITORINFO info = default;
            unsafe { info.cbSize = (uint)sizeof(Win32.MONITORINFO); }

            if (Win32.GetMonitorInfo(hmonitor.Monitor, ref info))
            {
                // Save the previous window placement so we can restore it later.
                Win32.WINDOWPLACEMENT placement = default;
                unsafe { placement.length = (uint)sizeof(Win32.WINDOWPLACEMENT); }
                Win32.GetWindowPlacement(hwnd.HWnd, ref placement);
                hwnd.PreviousPlacement = placement;
                hwnd.FullscreenMonitor = hmonitor;
                hwnd.ExclusiveFullscreen = true;
                hwnd.PreviousBorderStyle = GetBorderStyle(hwnd);

                // FIXME: check if we need to remove the window decorations.
                WindowStyles style = (WindowStyles)(uint)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style);
                Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((int)(style & ~WindowStyles.OverlappedWindow)));

                bool success = Win32.SetWindowPos(hwnd.HWnd, IntPtr.Zero,
                        info.rcMonitor.left,
                        info.rcMonitor.top,
                        info.rcMonitor.right - info.rcMonitor.left,
                        info.rcMonitor.bottom - info.rcMonitor.top,
                        // FIXME: Only set FrameChanged if we've disabled decorations?
                        SetWindowPosFlags.NoOwnerZOrder | SetWindowPosFlags.FrameChanged);
                if (success == false) throw new Win32Exception();
            }
            else
            {
                // FIXME: Can this even happen?
                Logger?.LogError($"Could not get monitor info from monitor '{hmonitor.DeviceName}'.");
            }
        }

        /// <inheritdoc/>
        public bool GetFullscreenDisplay(WindowHandle window, [NotNullWhen(true)] out DisplayHandle? display)
        {
            HWND hwnd = window.As<HWND>(this);
            display = hwnd.FullscreenMonitor;
            return display != null;
        }

        /// <inheritdoc/>
        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            // If we are fullscreen, just return the previous border style.
            if (hwnd.FullscreenMonitor != null)
            {
                return hwnd.PreviousBorderStyle;
            }

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStyles style = (WindowStyles)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style).ToInt64();

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStylesEx styleEx = (WindowStylesEx)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.ExStyle).ToInt64();

            if (styleEx.HasFlag(WindowStylesEx.ToolWindow))
            {
                return WindowBorderStyle.ToolBox;
            }

            // FIXME: Better way of checking these!!
            if (style.HasFlag(WindowStyles.OverlappedWindow & ~WindowStyles.ThickFrame) &&
                style.HasFlag(WindowStyles.ThickFrame) == false)
            {
                return WindowBorderStyle.FixedBorder;
            }
            else if (style.HasFlag(WindowStyles.OverlappedWindow & ~(WindowStyles.Caption | WindowStyles.Border | WindowStyles.ThickFrame)) &&
                     style.HasFlag(WindowStyles.Caption) == false &&
                     style.HasFlag(WindowStyles.Border) == false &&
                     style.HasFlag(WindowStyles.ThickFrame) == false)
            {
                return WindowBorderStyle.Borderless;
            }
            else if (style.HasFlag(WindowStyles.OverlappedWindow))
            {
                return WindowBorderStyle.ResizableBorder;
            }
            else
            {
                throw new NotImplementedException($"Unknown window style combination! (or toolbox?) (Style: {style})");
            }
        }

        private static readonly WindowBorderStyle[] _SupportedStyles = new[]
        {
            WindowBorderStyle.Borderless,
            WindowBorderStyle.FixedBorder,
            WindowBorderStyle.ResizableBorder,
            WindowBorderStyle.ToolBox,
        };

        /// <inheritdoc/>
        public unsafe void SetBorderStyle(WindowHandle handle, WindowBorderStyle style)
        {
            HWND hwnd = handle.As<HWND>(this);

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStyles windowStyle = (WindowStyles)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.Style).ToInt64();

            // We need ToInt64 here as Style is a uint which means that 0x00000000_ffffffff could be returned,
            // and ToInt32 is going to throw in that case
            WindowStylesEx windowStyleEx = (WindowStylesEx)Win32.GetWindowLongPtr(hwnd.HWnd, GetGWLPIndex.ExStyle).ToInt64();

            // Reset the window style, we are going to set the flags for the specific mode later.
            windowStyle &= ~WindowStyles.OverlappedWindow;
            windowStyleEx &= ~WindowStylesEx.ToolWindow;

            switch (style)
            {
                case WindowBorderStyle.Borderless:
                    windowStyle |= WindowStyles.OverlappedWindow;
                    windowStyle &= ~WindowStyles.Caption;
                    windowStyle &= ~WindowStyles.Border;
                    windowStyle &= ~WindowStyles.ThickFrame;
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((uint)windowStyle));
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.ExStyle, new IntPtr((uint)windowStyleEx));
                    break;
                case WindowBorderStyle.FixedBorder:
                    windowStyle |= WindowStyles.OverlappedWindow;
                    windowStyle &= ~WindowStyles.ThickFrame;
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((uint)windowStyle));
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.ExStyle, new IntPtr((uint)windowStyleEx));
                    break;
                case WindowBorderStyle.ResizableBorder:
                    windowStyle |= WindowStyles.OverlappedWindow;
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((uint)windowStyle));
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.ExStyle, new IntPtr((uint)windowStyleEx));
                    break;
                case WindowBorderStyle.ToolBox:
                    windowStyle |= WindowStyles.OverlappedWindow;
                    windowStyleEx |= WindowStylesEx.ToolWindow;
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.Style, new IntPtr((uint)windowStyle));
                    Win32.SetWindowLongPtr(hwnd.HWnd, SetGWLPIndex.ExStyle, new IntPtr((uint)windowStyleEx));
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(style), (int)style, style.GetType());
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

            Logger?.LogDebug($"StyleEx: {windowStyleEx}");

            return (windowStyleEx & WindowStylesEx.TopMost) == WindowStylesEx.TopMost;
        }

        /// <inheritdoc/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            HWND hwnd = handle.As<HWND>(this);

            hwnd.HitTest = test;
        }

        /// <inheritdoc/>
        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            HWND hwnd = handle.As<HWND>(this);
            HCursor? hcursor = cursor?.As<HCursor>(this);

            hwnd.HCursor = hcursor;

            // A hCursor = null means a hidden cursor, as we want.
            Win32.SetCursor(hcursor?.Cursor ?? IntPtr.Zero);
        }

        /// <inheritdoc/>
        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            return hwnd.CaptureMode;
        }

        /// <inheritdoc/>
        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            HWND hwnd = handle.As<HWND>(this);

            hwnd.CaptureMode = mode;

            RecaptureCursor(hwnd, hwnd.CaptureMode);
        }

        /// <summary>
        /// Used to set and unset cursor capture without changing HWND.CaptureMode.
        /// We use this to release the mouse when we loose focus, and to recapture it again when we regain focus.
        /// </summary>
        internal void RecaptureCursor(HWND hwnd, CursorCaptureMode mode)
        {
            switch (mode)
            {
                case CursorCaptureMode.Normal:
                    {
                        if (CursorCapturingWindow == hwnd)
                        {
                            CursorCapturingWindow = null;

                            Win32.ClipCursor(ref Unsafe.NullRef<Win32.RECT>());
                        }
                        break;
                    }
                case CursorCaptureMode.Locked:
                    {
                        CursorCapturingWindow = hwnd;

                        hwnd.VirtualCursorPosition = hwnd.LastMousePosition;

                        // When locking the cursor we also confine to the window
                        // so that large mouse deltas can't escape the window.
                        goto case CursorCaptureMode.Confined;
                    }
                case CursorCaptureMode.Confined:
                    {
                        CursorCapturingWindow = hwnd;

                        bool success;
                        success = Win32.GetClientRect(hwnd.HWnd, out Win32.RECT lpRect);
                        if (success == false)
                        {
                            throw new Win32Exception();
                        }

                        ClientToScreen(hwnd, lpRect.left, lpRect.top, out lpRect.left, out lpRect.top);
                        ClientToScreen(hwnd, lpRect.right, lpRect.bottom, out lpRect.right, out lpRect.bottom);

                        success = Win32.ClipCursor(ref lpRect);
                        if (success == false)
                        {
                            throw new Win32Exception();
                        }

                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(CursorCaptureMode));
            }
        }

        /// <inheritdoc/>
        public void FocusWindow(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

            bool success;
            success = Win32.BringWindowToTop(hwnd.HWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }

            Win32.SetForegroundWindow(hwnd.HWnd);

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
    }
}
