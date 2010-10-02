#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Input;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace OpenTK.Platform.Windows
{
    /// \internal
    /// <summary>
    /// Drives GameWindow on Windows.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLNative : INativeWindow, IInputDriver
    {
        #region Fields

        const ExtendedWindowStyle ParentStyleEx = ExtendedWindowStyle.WindowEdge | ExtendedWindowStyle.ApplicationWindow;
        const ExtendedWindowStyle ChildStyleEx = 0;

        readonly IntPtr Instance = Marshal.GetHINSTANCE(typeof(WinGLNative).Module);
        readonly IntPtr ClassName = Marshal.StringToHGlobalAuto(Guid.NewGuid().ToString());
        readonly WindowProcedure WindowProcedureDelegate;
        readonly uint ModalLoopTimerPeriod = 1;
        UIntPtr timer_handle;
        readonly Functions.TimerProc ModalLoopCallback;

        bool class_registered;
        bool disposed;
        bool exists;
        WinWindowInfo window, child_window;
        WindowBorder windowBorder = WindowBorder.Resizable;
        Nullable<WindowBorder> previous_window_border; // Set when changing to fullscreen state.
        Nullable<WindowBorder> deferred_window_border; // Set to avoid changing borders during fullscreen state.
        WindowState windowState = WindowState.Normal;
        bool borderless_maximized_window_state = false; // Hack to get maximized mode with hidden border (not normally possible).
        bool focused;
        bool mouse_outside_window = true;
        bool invisible_since_creation; // Set by WindowsMessage.CREATE and consumed by Visible = true (calls BringWindowToFront).
        int suppress_resize; // Used in WindowBorder and WindowState in order to avoid rapid, consecutive resize events.

        Rectangle
            bounds = new Rectangle(),
            client_rectangle = new Rectangle(),
            previous_bounds = new Rectangle(); // Used to restore previous size when leaving fullscreen mode.
        Icon icon;

        const ClassStyle DefaultClassStyle = ClassStyle.OwnDC;

        readonly IntPtr DefaultWindowProcedure =
            Marshal.GetFunctionPointerForDelegate(new WindowProcedure(Functions.DefWindowProc));

        // Used for IInputDriver implementation
        WinMMJoystick joystick_driver = new WinMMJoystick();
        KeyboardDevice keyboard = new KeyboardDevice();
        MouseDevice mouse = new MouseDevice();
        IList<KeyboardDevice> keyboards = new List<KeyboardDevice>(1);
        IList<MouseDevice> mice = new List<MouseDevice>(1);
        internal static readonly WinKeyMap KeyMap = new WinKeyMap();
        const long ExtendedBit = 1 << 24;           // Used to distinguish left and right control, alt and enter keys.
        static readonly uint ShiftRightScanCode = Functions.MapVirtualKey(VirtualKeys.RSHIFT, 0);         // Used to distinguish left and right shift keys.

        KeyPressEventArgs key_press = new KeyPressEventArgs((char)0);

        #endregion

        #region Contructors

        public WinGLNative(int x, int y, int width, int height, string title, GameWindowFlags options, DisplayDevice device)
        {
            // This is the main window procedure callback. We need the callback in order to create the window, so
            // don't move it below the CreateWindow calls.
            WindowProcedureDelegate = WindowProcedure;

            //// This timer callback is called periodically when the window enters a sizing / moving modal loop.
            //ModalLoopCallback = delegate(IntPtr handle, WindowMessage msg, UIntPtr eventId, int time)
            //{
            //    // Todo: find a way to notify the frontend that it should process queued up UpdateFrame/RenderFrame events.
            //    if (Move != null)
            //        Move(this, EventArgs.Empty);
            //};

            // To avoid issues with Ati drivers on Windows 6+ with compositing enabled, the context will not be
            // bound to the top-level window, but rather to a child window docked in the parent.
            window = new WinWindowInfo(
                CreateWindow(x, y, width, height, title, options, device, IntPtr.Zero), null);
            child_window = new WinWindowInfo(
                CreateWindow(0, 0, ClientSize.Width, ClientSize.Height, title, options, device, window.WindowHandle), window);

            exists = true;

            keyboard.Description = "Standard Windows keyboard";
            keyboard.NumberOfFunctionKeys = 12;
            keyboard.NumberOfKeys = 101;
            keyboard.NumberOfLeds = 3;

            mouse.Description = "Standard Windows mouse";
            mouse.NumberOfButtons = 3;
            mouse.NumberOfWheels = 1;

            keyboards.Add(keyboard);
            mice.Add(mouse);
        }

        #endregion

        #region Private Members

        #region WindowProcedure

        IntPtr WindowProcedure(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            switch (message)
            {
                #region Size / Move / Style events

                case WindowMessage.ACTIVATE:
                    // See http://msdn.microsoft.com/en-us/library/ms646274(VS.85).aspx (WM_ACTIVATE notification):
                    // wParam: The low-order word specifies whether the window is being activated or deactivated.
                    bool new_focused_state = Focused;
                    if (IntPtr.Size == 4)
                        focused = (wParam.ToInt32() & 0xFFFF) != 0;
                    else
                        focused = (wParam.ToInt64() & 0xFFFF) != 0;

                    if (new_focused_state != Focused && FocusedChanged != null)
                        FocusedChanged(this, EventArgs.Empty);
                    break;

                case WindowMessage.ENTERMENULOOP:
                case WindowMessage.ENTERSIZEMOVE:
                    // Entering the modal size/move loop: we don't want rendering to
                    // stop during this time, so we register a timer callback to continue
                    // processing from time to time.
                    StartTimer(handle);
                    break;

                case WindowMessage.EXITMENULOOP:
                case WindowMessage.EXITSIZEMOVE:
                    // ExitingmModal size/move loop: the timer callback is no longer
                    // necessary.
                    StopTimer(handle);
                    break;

                case WindowMessage.ERASEBKGND:
                    return new IntPtr(1);

                case WindowMessage.WINDOWPOSCHANGED:
                    unsafe
                    {
                        WindowPosition* pos = (WindowPosition*)lParam;
                        if (window != null && pos->hwnd == window.WindowHandle)
                        {
                            Point new_location = new Point(pos->x, pos->y);
                            if (Location != new_location)
                            {
                                bounds.Location = new_location;
                                if (Move != null)
                                    Move(this, EventArgs.Empty);
                            }

                            Size new_size = new Size(pos->cx, pos->cy);
                            if (Size != new_size)
                            {
                                bounds.Width = pos->cx;
                                bounds.Height = pos->cy;

                                Win32Rectangle rect;
                                Functions.GetClientRect(handle, out rect);
                                client_rectangle = rect.ToRectangle();

                                Functions.SetWindowPos(child_window.WindowHandle, IntPtr.Zero, 0, 0, ClientRectangle.Width, ClientRectangle.Height,
                                    SetWindowPosFlags.NOZORDER | SetWindowPosFlags.NOOWNERZORDER |
                                    SetWindowPosFlags.NOACTIVATE | SetWindowPosFlags.NOSENDCHANGING);

                                if (suppress_resize <= 0 && Resize != null)
                                    Resize(this, EventArgs.Empty);
                            }
                        }
                    }
                    break;

                case WindowMessage.STYLECHANGED:
                    unsafe
                    {
                        if (wParam.ToInt64() == (long)GWL.STYLE)
                        {
                            WindowStyle style = ((StyleStruct*)lParam)->New;
                            if ((style & WindowStyle.Popup) != 0)
                                windowBorder = WindowBorder.Hidden;
                            else if ((style & WindowStyle.ThickFrame) != 0)
                                windowBorder = WindowBorder.Resizable;
                            else if ((style & ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox)) != 0)
                                windowBorder = WindowBorder.Fixed;
                        }
                    }

                    break;

                case WindowMessage.SIZE:
                    SizeMessage state = (SizeMessage)wParam.ToInt64();
                    WindowState new_state = windowState;
                    switch (state)
                    {
                        case SizeMessage.RESTORED: new_state = borderless_maximized_window_state ?
                            WindowState.Maximized : WindowState.Normal; break;
                        case SizeMessage.MINIMIZED: new_state = WindowState.Minimized; break;
                        case SizeMessage.MAXIMIZED: new_state = WindowBorder == WindowBorder.Hidden ?
                            WindowState.Fullscreen : WindowState.Maximized;
                            break;
                    }

                    if (new_state != windowState)
                    {
                        windowState = new_state;
                        if (WindowStateChanged != null)
                            WindowStateChanged(this, EventArgs.Empty);
                    }

                    break;

                #endregion

                #region Input events

                case WindowMessage.CHAR:
                    if (IntPtr.Size == 4)
                        key_press.KeyChar = (char)wParam.ToInt32();
                    else
                        key_press.KeyChar = (char)wParam.ToInt64();

                    if (KeyPress != null)
                        KeyPress(this, key_press);
                    break;

                case WindowMessage.MOUSEMOVE:
                    Point point = new Point(
                        (short)((uint)lParam.ToInt32() & 0x0000FFFF),
                        (short)(((uint)lParam.ToInt32() & 0xFFFF0000) >> 16));
                    mouse.Position = point;

                    if (mouse_outside_window)
                    {
                        // Once we receive a mouse move event, it means that the mouse has
                        // re-entered the window.
                        mouse_outside_window = false;
                        EnableMouseTracking();

                        if (MouseEnter != null)
                            MouseEnter(this, EventArgs.Empty);
                    }
                    break;

                case WindowMessage.MOUSELEAVE:
                    mouse_outside_window = true;
                    // Mouse tracking is disabled automatically by the OS

                    if (MouseLeave != null)
                        MouseLeave(this, EventArgs.Empty);
                    break;

                case WindowMessage.MOUSEWHEEL:
                    // This is due to inconsistent behavior of the WParam value on 64bit arch, whese
                    // wparam = 0xffffffffff880000 or wparam = 0x00000000ff100000
                    mouse.WheelPrecise += ((long)wParam << 32 >> 48) / 120.0f;
                    break;

                case WindowMessage.LBUTTONDOWN:
                    mouse[MouseButton.Left] = true;
                    break;

                case WindowMessage.MBUTTONDOWN:
                    mouse[MouseButton.Middle] = true;
                    break;

                case WindowMessage.RBUTTONDOWN:
                    mouse[MouseButton.Right] = true;
                    break;

                case WindowMessage.XBUTTONDOWN:
                    mouse[((wParam.ToInt32() & 0xFFFF0000) >> 16) != (int)MouseKeys.XButton1 ? MouseButton.Button1 : MouseButton.Button2] = true;
                    break;

                case WindowMessage.LBUTTONUP:
                    mouse[MouseButton.Left] = false;
                    break;

                case WindowMessage.MBUTTONUP:
                    mouse[MouseButton.Middle] = false;
                    break;

                case WindowMessage.RBUTTONUP:
                    mouse[MouseButton.Right] = false;
                    break;

                case WindowMessage.XBUTTONUP:
                    // TODO: Is this correct?
                    mouse[((wParam.ToInt32() & 0xFFFF0000) >> 16) != (int)MouseKeys.XButton1 ? MouseButton.Button1 : MouseButton.Button2] = false;
                    break;

                // Keyboard events:
                case WindowMessage.KEYDOWN:
                case WindowMessage.KEYUP:
                case WindowMessage.SYSKEYDOWN:
                case WindowMessage.SYSKEYUP:
                    bool pressed =
                        message == WindowMessage.KEYDOWN ||
                        message == WindowMessage.SYSKEYDOWN;

                    // Shift/Control/Alt behave strangely when e.g. ShiftRight is held down and ShiftLeft is pressed
                    // and released. It looks like neither key is released in this case, or that the wrong key is
                    // released in the case of Control and Alt.
                    // To combat this, we are going to release both keys when either is released. Hacky, but should work.
                    // Win95 does not distinguish left/right key constants (GetAsyncKeyState returns 0).
                    // In this case, both keys will be reported as pressed.

                    bool extended = (lParam.ToInt64() & ExtendedBit) != 0;
                    switch ((VirtualKeys)wParam)
                    {
                        case VirtualKeys.SHIFT:
                            // The behavior of this key is very strange. Unlike Control and Alt, there is no extended bit
                            // to distinguish between left and right keys. Moreover, pressing both keys and releasing one
                            // may result in both keys being held down (but not always).
                            // The only reliably way to solve this was reported by BlueMonkMN at the forums: we should
                            // check the scancodes. It looks like GLFW does the same thing, so it should be reliable.

                            // TODO: Not 100% reliable, when both keys are pressed at once.
                            if (ShiftRightScanCode != 0)
                            {
                                unchecked
                                {
                                    if (((lParam.ToInt64() >> 16) & 0xFF) == ShiftRightScanCode)
                                        keyboard[Input.Key.ShiftRight] = pressed;
                                    else
                                        keyboard[Input.Key.ShiftLeft] = pressed;
                                }
                            }
                            else
                            {
                                // Should only fall here on Windows 9x and NT4.0-
                                keyboard[Input.Key.ShiftLeft] = pressed;
                            }
                            return IntPtr.Zero;

                        case VirtualKeys.CONTROL:
                            if (extended)
                                keyboard[Input.Key.ControlRight] = pressed;
                            else
                                keyboard[Input.Key.ControlLeft] = pressed;
                            return IntPtr.Zero;

                        case VirtualKeys.MENU:
                            if (extended)
                                keyboard[Input.Key.AltRight] = pressed;
                            else
                                keyboard[Input.Key.AltLeft] = pressed;
                            return IntPtr.Zero;

                        case VirtualKeys.RETURN:
                            if (extended)
                                keyboard[Key.KeypadEnter] = pressed;
                            else
                                keyboard[Key.Enter] = pressed;
                            return IntPtr.Zero;

                        default:
                            if (!WMInput.KeyMap.ContainsKey((VirtualKeys)wParam))
                            {
                                Debug.Print("Virtual key {0} ({1}) not mapped.", (VirtualKeys)wParam, (int)lParam);
                                break;
                            }
                            else
                            {
                                keyboard[WMInput.KeyMap[(VirtualKeys)wParam]] = pressed;
                            }
                            return IntPtr.Zero;
                    }
                    break;

                case WindowMessage.SYSCHAR:
                    return IntPtr.Zero;

                case WindowMessage.KILLFOCUS:
                    keyboard.ClearKeys();
                    break;

                #endregion

                #region Creation / Destruction events

                case WindowMessage.CREATE:
                    CreateStruct cs = (CreateStruct)Marshal.PtrToStructure(lParam, typeof(CreateStruct));
                    if (cs.hwndParent == IntPtr.Zero)
                    {
                        bounds.X = cs.x;
                        bounds.Y = cs.y;
                        bounds.Width = cs.cx;
                        bounds.Height = cs.cy;

                        Win32Rectangle rect;
                        Functions.GetClientRect(handle, out rect);
                        client_rectangle = rect.ToRectangle();

                        invisible_since_creation = true;
                    }
                    break;

                case WindowMessage.CLOSE:
                    System.ComponentModel.CancelEventArgs e = new System.ComponentModel.CancelEventArgs();

                    if (Closing != null)
                        Closing(this, e);

                    if (!e.Cancel)
                    {
                        if (Unload != null)
                            Unload(this, EventArgs.Empty);

                        DestroyWindow();
                        break;
                    }

                    return IntPtr.Zero;

                case WindowMessage.DESTROY:
                    exists = false;

                    Functions.UnregisterClass(ClassName, Instance);
                    window.Dispose();
                    child_window.Dispose();

                    if (Closed != null)
                        Closed(this, EventArgs.Empty);

                    break;

                #endregion
            }

            return Functions.DefWindowProc(handle, message, wParam, lParam);
        }

        private void EnableMouseTracking()
        {
            TrackMouseEventStructure me = new TrackMouseEventStructure();
            me.Size = TrackMouseEventStructure.SizeInBytes;
            me.TrackWindowHandle = child_window.WindowHandle;
            me.Flags = TrackMouseEventFlags.LEAVE;

            if (!Functions.TrackMouseEvent(ref me))
                Debug.Print("[Warning] Failed to enable mouse tracking, error: {0}.",
                    Marshal.GetLastWin32Error());
        }

        private void StartTimer(IntPtr handle)
        {
            if (timer_handle == UIntPtr.Zero)
            {
                timer_handle = Functions.SetTimer(handle, new UIntPtr(1), ModalLoopTimerPeriod, ModalLoopCallback);
                if (timer_handle == UIntPtr.Zero)
                    Debug.Print("[Warning] Failed to set modal loop timer callback ({0}:{1}->{2}).",
                        GetType().Name, handle, Marshal.GetLastWin32Error());
            }
        }

        private void StopTimer(IntPtr handle)
        {
            if (timer_handle != UIntPtr.Zero)
            {
                if (!Functions.KillTimer(handle, timer_handle))
                    Debug.Print("[Warning] Failed to kill modal loop timer callback ({0}:{1}->{2}).",
                        GetType().Name, handle, Marshal.GetLastWin32Error());
                timer_handle = UIntPtr.Zero;
            }
        }

        #endregion

        #region IsIdle

        bool IsIdle
        {
            get
            {
                MSG message = new MSG();
                return !Functions.PeekMessage(ref message, window.WindowHandle, 0, 0, 0);
            }
        }

        #endregion

        #region CreateWindow

        IntPtr CreateWindow(int x, int y, int width, int height, string title, GameWindowFlags options, DisplayDevice device, IntPtr parentHandle)
        {
            // Use win32 to create the native window.
            // Keep in mind that some construction code runs in the WM_CREATE message handler.

            // The style of a parent window is different than that of a child window.
            // Note: the child window should always be visible, even if the parent isn't.
            WindowStyle style = 0;
            ExtendedWindowStyle ex_style = 0;
            if (parentHandle == IntPtr.Zero)
            {
                style |= WindowStyle.OverlappedWindow | WindowStyle.ClipChildren;
                ex_style = ParentStyleEx;
            }
            else
            {
                style |= WindowStyle.Visible | WindowStyle.Child | WindowStyle.ClipSiblings;
                ex_style = ChildStyleEx;
            }

            // Find out the final window rectangle, after the WM has added its chrome (titlebar, sidebars etc).
            Win32Rectangle rect = new Win32Rectangle();
            rect.left = x; rect.top = y; rect.right = x + width; rect.bottom = y + height;
            Functions.AdjustWindowRectEx(ref rect, style, false, ex_style);

            // Create the window class that we will use for this window.
            // The current approach is to register a new class for each top-level WinGLWindow we create.
            if (!class_registered)
            {
                ExtendedWindowClass wc = new ExtendedWindowClass();
                wc.Size = ExtendedWindowClass.SizeInBytes;
                wc.Style = DefaultClassStyle;
                wc.Instance = Instance;
                wc.WndProc = WindowProcedureDelegate;
                wc.ClassName = ClassName;
                wc.Icon = Icon != null ? Icon.Handle : IntPtr.Zero;
#warning "This seems to resize one of the 'large' icons, rather than using a small icon directly (multi-icon files). Investigate!"
                wc.IconSm = Icon != null ? new Icon(Icon, 16, 16).Handle : IntPtr.Zero;
                wc.Cursor = Functions.LoadCursor(CursorName.Arrow);
                ushort atom = Functions.RegisterClassEx(ref wc);

                if (atom == 0)
                    throw new PlatformException(String.Format("Failed to register window class. Error: {0}", Marshal.GetLastWin32Error()));

                class_registered = true;
            }

            IntPtr window_name = Marshal.StringToHGlobalAuto(title);
            IntPtr handle = Functions.CreateWindowEx(
                ex_style, ClassName, window_name, style,
                rect.left, rect.top, rect.Width, rect.Height,
                parentHandle, IntPtr.Zero, Instance, IntPtr.Zero);

            if (handle == IntPtr.Zero)
                throw new PlatformException(String.Format("Failed to create window. Error: {0}", Marshal.GetLastWin32Error()));

            return handle;
        }

        #endregion

        #region DestroyWindow

        /// <summary>
        /// Starts the teardown sequence for the current window.
        /// </summary>
        void DestroyWindow()
        {
            if (Exists)
            {
                Debug.Print("Destroying window: {0}", window.ToString());
                Functions.DestroyWindow(window.WindowHandle);
                exists = false;
            }
        }

        #endregion

        void HideBorder()
        {
            suppress_resize++;
            WindowBorder = WindowBorder.Hidden;
            ProcessEvents();
            suppress_resize--;
        }

        void RestoreBorder()
        {
            suppress_resize++;
            WindowBorder =
                deferred_window_border.HasValue ? deferred_window_border.Value :
                previous_window_border.HasValue ? previous_window_border.Value :
                WindowBorder;
            ProcessEvents();
            suppress_resize--;
            deferred_window_border = previous_window_border = null;
        }

        void ResetWindowState()
        {
            suppress_resize++;
            WindowState = WindowState.Normal;
            ProcessEvents();
            suppress_resize--;
        }

        #endregion

        #region INativeWindow Members

        #region Bounds

        public Rectangle Bounds
        {
            get { return bounds; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, value.X, value.Y, value.Width, value.Height, 0);
            }
        }

        #endregion

        #region Location

        public Point Location
        {
            get { return Bounds.Location; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, value.X, value.Y, 0, 0, SetWindowPosFlags.NOSIZE);
            }
        }

        #endregion

        #region Size

        public Size Size
        {
            get { return Bounds.Size; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, 0, 0, value.Width, value.Height, SetWindowPosFlags.NOMOVE);
            }
        }

        #endregion

        #region ClientRectangle

        public Rectangle ClientRectangle
        {
            get
            {
                if (client_rectangle.Width == 0)
                    client_rectangle.Width = 1;
                if (client_rectangle.Height == 0)
                    client_rectangle.Height = 1;
                return client_rectangle;
            }
            set
            {
                ClientSize = value.Size;
            }
        }

        #endregion

        #region ClientSize

        public Size ClientSize
        {
            get
            {
                return ClientRectangle.Size;
            }
            set
            {
                WindowStyle style = (WindowStyle)Functions.GetWindowLong(window.WindowHandle, GetWindowLongOffsets.STYLE);
                Win32Rectangle rect = Win32Rectangle.From(value);
                Functions.AdjustWindowRect(ref rect, style, false);
                Size = new Size(rect.Width, rect.Height);
            }
        }

        #endregion

        #region Width

        public int Width
        {
            get { return ClientRectangle.Width; }
            set { ClientRectangle = new Rectangle(0, 0, value, Height); }
        }

        #endregion

        #region Height

        public int Height
        {
            get { return ClientRectangle.Height; }
            set { ClientRectangle = new Rectangle(0, 0, Width, value); }
        }

        #endregion

        #region X

        public int X
        {
            get { return Location.X; }
            set { Location = new Point(value, Y); }
        }

        #endregion

        #region Y

        public int Y
        {
            get { return Location.Y; }
            set { Location = new Point(X, value); }
        }

        #endregion

        #region Icon

        public Icon Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                if (window.WindowHandle != IntPtr.Zero)
                {
                    Functions.SendMessage(window.WindowHandle, WindowMessage.SETICON, (IntPtr)0, icon == null ? IntPtr.Zero : value.Handle);
                    Functions.SendMessage(window.WindowHandle, WindowMessage.SETICON, (IntPtr)1, icon == null ? IntPtr.Zero : value.Handle);
                }
            }
        }

        #endregion

        #region Focused

        public bool Focused
        {
            get { return focused; }
        }

        #endregion

        #region Title

        StringBuilder sb_title = new StringBuilder(256);
        public string Title
        {
            get
            {
                sb_title.Remove(0, sb_title.Length);
                if (Functions.GetWindowText(window.WindowHandle, sb_title, sb_title.MaxCapacity) == 0)
                    Debug.Print("Failed to retrieve window title (window:{0}, reason:{2}).", window.WindowHandle, Marshal.GetLastWin32Error());
                return sb_title.ToString();
            }
            set
            {
                if (!Functions.SetWindowText(window.WindowHandle, value))
                    Debug.Print("Failed to change window title (window:{0}, new title:{1}, reason:{2}).", window.WindowHandle, value, Marshal.GetLastWin32Error());
            }
        }

        #endregion

        #region Visible

        public bool Visible
        {
            get
            {
                return Functions.IsWindowVisible(window.WindowHandle);
            }
            set
            {
                if (value)
                {
                    Functions.ShowWindow(window.WindowHandle, ShowWindowCommand.SHOW);
                    if (invisible_since_creation)
                    {
                        Functions.BringWindowToTop(window.WindowHandle);
                        Functions.SetForegroundWindow(window.WindowHandle);
                    }
                }
                else if (!value)
                {
                    Functions.ShowWindow(window.WindowHandle, ShowWindowCommand.HIDE);
                }
            }
        }

        #endregion

        #region Exists

        public bool Exists { get { return exists; } }

        #endregion

        #region Close

        public void Close()
        {
            Functions.PostMessage(window.WindowHandle, WindowMessage.CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        #endregion

        #region public WindowState WindowState

        public WindowState WindowState
        {
            get
            {
                return windowState;
            }
            set
            {
                if (WindowState == value)
                    return;

                ShowWindowCommand command = 0;
                bool exiting_fullscreen = false;
                borderless_maximized_window_state = false;

                switch (value)
                {
                    case WindowState.Normal:
                        command = ShowWindowCommand.RESTORE;

                        // If we are leaving fullscreen mode we need to restore the border.
                        if (WindowState == WindowState.Fullscreen)
                            exiting_fullscreen = true;
                        break;

                    case WindowState.Maximized:
                        // Note: if we use the MAXIMIZE command and the window border is Hidden (i.e. WS_POPUP),
                        // we will enter fullscreen mode - we don't want that! As a workaround, we'll resize the window
                        // manually to cover the whole working area of the current monitor.

                        // Reset state to avoid strange interactions with fullscreen/minimized windows.
                        ResetWindowState();

                        if (WindowBorder == WindowBorder.Hidden)
                        {
                            IntPtr current_monitor = Functions.MonitorFromWindow(window.WindowHandle, MonitorFrom.Nearest);
                            MonitorInfo info = new MonitorInfo();
                            info.Size = MonitorInfo.SizeInBytes;
                            Functions.GetMonitorInfo(current_monitor, ref info);

                            previous_bounds = Bounds;
                            borderless_maximized_window_state = true;
                            Bounds = info.Work.ToRectangle();
                        }
                        else
                        {
                            command = ShowWindowCommand.MAXIMIZE;
                        }
                        break;

                    case WindowState.Minimized:
                        command = ShowWindowCommand.MINIMIZE;
                        break;

                    case WindowState.Fullscreen:
                        // We achieve fullscreen by hiding the window border and sending the MAXIMIZE command.
                        // We cannot use the WindowState.Maximized directly, as that will not send the MAXIMIZE
                        // command for windows with hidden borders.

                        // Reset state to avoid strange side-effects from maximized/minimized windows.
                        ResetWindowState();

                        previous_bounds = Bounds;
                        previous_window_border = WindowBorder;
                        HideBorder();
                        command = ShowWindowCommand.MAXIMIZE;

                        Functions.SetForegroundWindow(window.WindowHandle);

                        break;
                }

                if (command != 0)
                    Functions.ShowWindow(window.WindowHandle, command);

                // Restore previous window border or apply pending border change when leaving fullscreen mode.
                if (exiting_fullscreen)
                {
                    RestoreBorder();
                }

                // Restore previous window size/location if necessary
                if (command == ShowWindowCommand.RESTORE && previous_bounds != Rectangle.Empty)
                {
                    Bounds = previous_bounds;
                    previous_bounds = Rectangle.Empty;
                }
            }
        }

        #endregion

        #region public WindowBorder WindowBorder

        public WindowBorder WindowBorder
        {
            get
            {
                return windowBorder;
            }
            set
            {
                // Do not allow border changes during fullscreen mode.
                // Defer them for when we leave fullscreen.
                if (WindowState == WindowState.Fullscreen)
                {
                    deferred_window_border = value;
                    return;
                }

                if (windowBorder == value)
                    return;

                // We wish to avoid making an invisible window visible just to change the border.
                // However, it's a good idea to make a visible window invisible temporarily, to
                // avoid garbage caused by the border change.
                bool was_visible = Visible;

                // To ensure maximized/minimized windows work correctly, reset state to normal,
                // change the border, then go back to maximized/minimized.
                WindowState state = WindowState;
                ResetWindowState();

                WindowStyle style = WindowStyle.ClipChildren | WindowStyle.ClipSiblings;

                switch (value)
                {
                    case WindowBorder.Resizable:
                        style |= WindowStyle.OverlappedWindow;
                        break;

                    case WindowBorder.Fixed:
                        style |= WindowStyle.OverlappedWindow &
                            ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox | WindowStyle.SizeBox);
                        break;

                    case WindowBorder.Hidden:
                        style |= WindowStyle.Popup;
                        break;
                }

                // Make sure client size doesn't change when changing the border style.
                Size client_size = ClientSize;
                Win32Rectangle rect = Win32Rectangle.From(client_size);
                Functions.AdjustWindowRectEx(ref rect, style, false, ParentStyleEx);

                // This avoids leaving garbage on the background window.
                if (was_visible)
                    Visible = false;

                Functions.SetWindowLong(window.WindowHandle, GetWindowLongOffsets.STYLE, (IntPtr)(int)style);
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, 0, 0, rect.Width, rect.Height,
                    SetWindowPosFlags.NOMOVE | SetWindowPosFlags.NOZORDER |
                    SetWindowPosFlags.FRAMECHANGED);

                // Force window to redraw update its borders, but only if it's
                // already visible (invisible windows will change borders when
                // they become visible, so no need to make them visiable prematurely).
                if (was_visible)
                    Visible = true;

                WindowState = state;

                if (WindowBorderChanged != null)
                    WindowBorderChanged(this, EventArgs.Empty);
            }
        }

        #endregion

        #region PointToClient

        public Point PointToClient(Point point)
        {
            if (!Functions.ScreenToClient(window.WindowHandle, ref point))
                throw new InvalidOperationException(String.Format(
                    "Could not convert point {0} from client to screen coordinates. Windows error: {1}",
                    point.ToString(), Marshal.GetLastWin32Error()));

            return point;
        }

        #endregion

        #region PointToScreen

        public Point PointToScreen(Point p)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Events

        public event EventHandler<EventArgs> Idle;

        public event EventHandler<EventArgs> Load;

        public event EventHandler<EventArgs> Unload;

        public event EventHandler<EventArgs> Move;

        public event EventHandler<EventArgs> Resize;

        public event EventHandler<System.ComponentModel.CancelEventArgs> Closing;

        public event EventHandler<EventArgs> Closed;

        public event EventHandler<EventArgs> Disposed;

        public event EventHandler<EventArgs> IconChanged;

        public event EventHandler<EventArgs> TitleChanged;

        public event EventHandler<EventArgs> ClientSizeChanged;

        public event EventHandler<EventArgs> VisibleChanged;

        public event EventHandler<EventArgs> WindowInfoChanged;

        public event EventHandler<EventArgs> FocusedChanged;

        public event EventHandler<EventArgs> WindowBorderChanged;

        public event EventHandler<EventArgs> WindowStateChanged;

        public event EventHandler<KeyPressEventArgs> KeyPress;

        public event EventHandler<EventArgs> MouseEnter;

        public event EventHandler<EventArgs> MouseLeave;

        #endregion

        #endregion

        #region INativeGLWindow Members

        #region public void ProcessEvents()

        private int ret;
        MSG msg;
        public void ProcessEvents()
        {
            while (!IsIdle)
            {
                ret = Functions.GetMessage(ref msg, window.WindowHandle, 0, 0);
                if (ret == -1)
                {
                    throw new PlatformException(String.Format(
                        "An error happened while processing the message queue. Windows error: {0}",
                        Marshal.GetLastWin32Error()));
                }

                Functions.TranslateMessage(ref msg);
                Functions.DispatchMessage(ref msg);
            }
        }

        #endregion

        #region public IInputDriver InputDriver

        public IInputDriver InputDriver
        {
            get { return this; }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return child_window; }
        }

        #endregion

        #endregion

        #region IInputDriver Members

        public void Poll()
        {
            joystick_driver.Poll();
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboards; }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get { return mice; }
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get { return joystick_driver.Joysticks; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                if (calledManually)
                {
                    // Safe to clean managed resources
                    DestroyWindow();
                    if (Icon != null)
                        Icon.Dispose();
                }
                else
                {
                    Debug.Print("[Warning] INativeWindow leaked ({0}). Did you forget to call INativeWindow.Dispose()?", this);
                }

                disposed = true;
            }
        }

        ~WinGLNative()
        {
            Dispose(false);
        }

        #endregion
    }
}
