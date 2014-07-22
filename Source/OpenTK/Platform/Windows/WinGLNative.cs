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
#if !MINIMAL
using System.Drawing;
#endif

namespace OpenTK.Platform.Windows
{
    /// \internal
    /// <summary>
    /// Drives GameWindow on Windows.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLNative : NativeWindowBase
    {
        #region Fields

        const ExtendedWindowStyle ParentStyleEx = ExtendedWindowStyle.WindowEdge | ExtendedWindowStyle.ApplicationWindow;
        const ExtendedWindowStyle ChildStyleEx = 0;

        readonly IntPtr Instance = Marshal.GetHINSTANCE(typeof(WinGLNative).Module);
        readonly IntPtr ClassName = Marshal.StringToHGlobalAuto(Guid.NewGuid().ToString());
        readonly WindowProcedure WindowProcedureDelegate;

        readonly uint ModalLoopTimerPeriod = 1;
        UIntPtr timer_handle;

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
        int mouse_last_timestamp = 0;
        bool invisible_since_creation; // Set by WindowsMessage.CREATE and consumed by Visible = true (calls BringWindowToFront).
        int suppress_resize; // Used in WindowBorder and WindowState in order to avoid rapid, consecutive resize events.
        bool is_in_modal_loop; // set to true whenever we enter the modal resize/move event loop 

        Rectangle
            bounds = new Rectangle(),
            client_rectangle = new Rectangle(),
            previous_bounds = new Rectangle(); // Used to restore previous size when leaving fullscreen mode.
        Icon icon;

        const ClassStyle DefaultClassStyle = ClassStyle.OwnDC;

        const long ExtendedBit = 1 << 24;           // Used to distinguish left and right control, alt and enter keys.
        
        public static readonly uint ShiftLeftScanCode = Functions.MapVirtualKey(VirtualKeys.LSHIFT, 0);
        public static readonly uint ShiftRightScanCode = Functions.MapVirtualKey(VirtualKeys.RSHIFT, 0);
        public static readonly uint ControlLeftScanCode = Functions.MapVirtualKey(VirtualKeys.LCONTROL, 0);
        public static readonly uint ControlRightScanCode = Functions.MapVirtualKey(VirtualKeys.RCONTROL, 0);
        public static readonly uint AltLeftScanCode = Functions.MapVirtualKey(VirtualKeys.LMENU, 0);
        public static readonly uint AltRightScanCode = Functions.MapVirtualKey(VirtualKeys.RMENU, 0);

        MouseCursor cursor = MouseCursor.Default;
        IntPtr cursor_handle = Functions.LoadCursor(CursorName.Arrow);
        int cursor_visible_count = 0;

        static readonly object SyncRoot = new object();

        #endregion

        #region Contructors

        public WinGLNative(int x, int y, int width, int height, string title, GameWindowFlags options, DisplayDevice device)
        {
            lock (SyncRoot)
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

                int scale_width = width;
                int scale_height = height;
                int scale_x = x;
                int scale_y = y;
                if (Toolkit.Options.EnableHighResolution)
                {
                    // CreateWindow takes values in pixels.
                    // According to the high-dpi guidelines,
                    // we need to scale these values by the
                    // current DPI.
                    // Search MSDN for "How to Ensure That
                    // Your Application Displays Properly on
                    // High-DPI Displays"
                    scale_width = ScaleX(width);
                    scale_height = ScaleY(height);
                    scale_x = ScaleX(x);
                    scale_y = ScaleY(y);
                }

                // To avoid issues with Ati drivers on Windows 6+ with compositing enabled, the context will not be
                // bound to the top-level window, but rather to a child window docked in the parent.
                window = new WinWindowInfo(
                    CreateWindow(
                        scale_x, scale_y, scale_width, scale_height,
                        title, options, device, IntPtr.Zero),
                    null);
                child_window = new WinWindowInfo(
                    CreateWindow(
                        0, 0, ClientSize.Width, ClientSize.Height,
                        title, options, device, window.Handle),
                    window);

                exists = true;
            }
        }

        #endregion

        #region Private Members

        #region Scale

        enum ScaleDirection { X, Y }

        // Scales a value according according
        // to the DPI of the specified direction
        static int Scale(int v, ScaleDirection direction)
        {
            IntPtr dc = Functions.GetDC(IntPtr.Zero);
            if (dc != IntPtr.Zero)
            {
                int dpi = Functions.GetDeviceCaps(dc,
                    direction == ScaleDirection.X ? DeviceCaps.LogPixelsX : DeviceCaps.LogPixelsY);
                if (dpi > 0)
                {
                    float scale = dpi / 96.0f;
                    v = (int)Math.Round(v * scale);
                }
                Functions.ReleaseDC(IntPtr.Zero, dc);
            }
            return v;
        }

        static int ScaleX(int x)
        {
            return Scale(x, ScaleDirection.X);
        }
        
        static int ScaleY(int y)
        {
            return Scale(y, ScaleDirection.Y);
        }

        static int Unscale(int v, ScaleDirection direction)
        {
            IntPtr dc = Functions.GetDC(IntPtr.Zero);
            if (dc != IntPtr.Zero)
            {
                int dpi = Functions.GetDeviceCaps(dc,
                    direction == ScaleDirection.X ? DeviceCaps.LogPixelsX : DeviceCaps.LogPixelsY);
                if (dpi > 0)
                {
                    float scale = dpi / 96.0f;
                    v = (int)Math.Round(v / scale);
                }
                Functions.ReleaseDC(IntPtr.Zero, dc);
            }
            return v;
        }

        static int UnscaleX(int x)
        {
            return Unscale(x, ScaleDirection.X);
        }

        static int UnscaleY(int y)
        {
            return Unscale(y, ScaleDirection.Y);
        }

        #endregion

        #region Message Handlers

        void HandleActivate(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // See http://msdn.microsoft.com/en-us/library/ms646274(VS.85).aspx (WM_ACTIVATE notification):
            // wParam: The low-order word specifies whether the window is being activated or deactivated.
            bool new_focused_state = Focused;
            if (IntPtr.Size == 4)
                focused = (wParam.ToInt32() & 0xFFFF) != 0;
            else
                focused = (wParam.ToInt64() & 0xFFFF) != 0;

            if (new_focused_state != Focused)
                OnFocusedChanged(EventArgs.Empty);
        }

        void HandleEnterModalLoop(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // Entering the modal size/move loop: we don't want rendering to
            // stop during this time, so we register a timer callback to continue
            // processing from time to time.
            is_in_modal_loop = true;
            StartTimer(handle);

            if (!CursorVisible)
                UngrabCursor();
        }

        void HandleExitModalLoop(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // Exiting from Modal size/move loop: the timer callback is no longer
            // necessary.
            is_in_modal_loop = false;
            StopTimer(handle);

            // Ensure cursor remains grabbed
            if (!CursorVisible)
                GrabCursor();
        }

        void HandleWindowPositionChanged(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            unsafe
            {
                WindowPosition* pos = (WindowPosition*)lParam;
                if (window != null && pos->hwnd == window.Handle)
                {
                    Point new_location = new Point(pos->x, pos->y);
                    if (Location != new_location)
                    {
                        bounds.Location = new_location;
                        OnMove(EventArgs.Empty);
                    }

                    Size new_size = new Size(pos->cx, pos->cy);
                    if (Size != new_size)
                    {
                        bounds.Width = pos->cx;
                        bounds.Height = pos->cy;

                        Win32Rectangle rect;
                        Functions.GetClientRect(handle, out rect);
                        client_rectangle = rect.ToRectangle();

                        Functions.SetWindowPos(child_window.Handle, IntPtr.Zero, 0, 0, ClientRectangle.Width, ClientRectangle.Height,
                            SetWindowPosFlags.NOZORDER | SetWindowPosFlags.NOOWNERZORDER |
                            SetWindowPosFlags.NOACTIVATE | SetWindowPosFlags.NOSENDCHANGING);

                        if (suppress_resize <= 0)
                            OnResize(EventArgs.Empty);
                    }

                    if (!is_in_modal_loop)
                    {
                        // If we are in a modal resize/move loop, cursor grabbing is
                        // handled inside [ENTER|EXIT]SIZEMOVE case above.
                        // If not, then we have to handle cursor grabbing here.
                        if (!CursorVisible)
                            GrabCursor();
                    }
                }
            }
        }

        void HandleStyleChanged(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            WindowBorder old_border = windowBorder;
            WindowBorder new_border = old_border;

            unsafe
            {
                GWL get_window_style = (GWL)unchecked(wParam.ToInt32());
                if ((get_window_style & (GWL.STYLE | GWL.EXSTYLE)) != 0)
                {
                    WindowStyle style = ((StyleStruct*)lParam)->New;
                    if ((style & WindowStyle.Popup) != 0)
                        new_border = WindowBorder.Hidden;
                    else if ((style & WindowStyle.ThickFrame) != 0)
                        new_border = WindowBorder.Resizable;
                    else if ((style & ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox)) != 0)
                        new_border = WindowBorder.Fixed;
                }
            }

            if (new_border != windowBorder)
            {
                // Ensure cursor remains grabbed
                if (!CursorVisible)
                    GrabCursor();

                windowBorder = new_border;
                OnWindowBorderChanged(EventArgs.Empty);
            }
        }

        void HandleSize(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            SizeMessage state = (SizeMessage)wParam.ToInt64();
            WindowState new_state = windowState;
            switch (state)
            {
                case SizeMessage.RESTORED:
                    new_state = borderless_maximized_window_state ?
                       WindowState.Maximized : WindowState.Normal;
                    break;

                case SizeMessage.MINIMIZED:
                    new_state = WindowState.Minimized;
                    break;

                case SizeMessage.MAXIMIZED:
                    new_state = WindowBorder == WindowBorder.Hidden ?
                        WindowState.Fullscreen : WindowState.Maximized;
                    break;
            }

            if (new_state != windowState)
            {
                windowState = new_state;
                OnWindowStateChanged(EventArgs.Empty);

                // Ensure cursor remains grabbed
                if (!CursorVisible)
                    GrabCursor();
            }
        }

        private IntPtr? HandleSetCursor(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            if (cursor != MouseCursor.Default)
            {
                // Only set the mouse cursor inside the client rectangle
                // See MSDN "Setting the Cursor Image"
                const int ht_client = 1;
                if ((lParam.ToInt64() & 0xffff) == ht_client)
                {
                    Functions.SetCursor(cursor_handle);
                    return new IntPtr(1);
                }
            }

            return null;
        }

        void HandleChar(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            char c;
            if (IntPtr.Size == 4)
                c = (char)wParam.ToInt32();
            else
                c = (char)wParam.ToInt64();

            if (!Char.IsControl(c))
            {
                OnKeyPress(c);
            }
        }

        void HandleMouseMove(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            unsafe
            {
                Point point = new Point(
                    (short)((uint)lParam.ToInt32() & 0x0000FFFF),
                    (short)(((uint)lParam.ToInt32() & 0xFFFF0000) >> 16));

                // GetMouseMovePointsEx works with screen coordinates
                Point screenPoint = point;
                Functions.ClientToScreen(handle, ref screenPoint);
                int timestamp = Functions.GetMessageTime();

                // & 0xFFFF to handle multiple monitors http://support.microsoft.com/kb/269743 
                MouseMovePoint movePoint = new MouseMovePoint()
                {
                    X = screenPoint.X & 0xFFFF,
                    Y = screenPoint.Y & 0xFFFF,
                    Time = timestamp,
                };

                // Max points GetMouseMovePointsEx can return is 64.
                const int numPoints = 64;
                MouseMovePoint* movePoints = stackalloc MouseMovePoint[numPoints];

                // GetMouseMovePointsEx fills in movePoints so that the most 
                // recent events are at low indices in the array.
                int points = Functions.GetMouseMovePointsEx(
                    (uint)MouseMovePoint.SizeInBytes,
                    &movePoint, movePoints, numPoints,
                    Constants.GMMP_USE_DISPLAY_POINTS);

                int lastError = Marshal.GetLastWin32Error();

                // No points returned or search point not found
                if (points == 0 || (points == -1 && lastError == Constants.ERROR_POINT_NOT_FOUND))
                {
                    // Just use the mouse move position
                    OnMouseMove(point.X, point.Y);
                }
                else if (points == -1)
                {
                    throw new System.ComponentModel.Win32Exception(lastError);
                }
                else
                {
                    // Exclude the current position. 
                    Point currentScreenPosition = new Point(MouseState.X, MouseState.Y);
                    Functions.ClientToScreen(handle, ref currentScreenPosition);

                    // Find the first move point we've already seen.
                    int i = 0;
                    for (i = 0; i < points; ++i)
                    {
                        if (movePoints[i].Time < mouse_last_timestamp)
                            break;
                        if (movePoints[i].Time == mouse_last_timestamp &&
                            movePoints[i].X == currentScreenPosition.X &&
                            movePoints[i].Y == currentScreenPosition.Y)
                            break;
                    }

                    // Now move the mouse to each point before the one just found.
                    while (--i >= 0)
                    {
                        Point position = new Point(movePoints[i].X, movePoints[i].Y);
                        // Handle multiple monitors http://support.microsoft.com/kb/269743 
                        if (position.X > 32767)
                        {
                            position.X -= 65536;
                        }
                        if (position.Y > 32767)
                        {
                            position.Y -= 65536;
                        }
                        Functions.ScreenToClient(handle, ref position);
                        OnMouseMove(position.X, position.Y);
                    }
                }
                mouse_last_timestamp = timestamp;
            }

            if (mouse_outside_window)
            {
                // Once we receive a mouse move event, it means that the mouse has
                // re-entered the window.
                mouse_outside_window = false;
                EnableMouseTracking();

                OnMouseEnter(EventArgs.Empty);
            }
        }

        void HandleMouseLeave(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            mouse_outside_window = true;
            // Mouse tracking is disabled automatically by the OS

            OnMouseLeave(EventArgs.Empty);
        }

        void HandleMouseWheel(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // This is due to inconsistent behavior of the WParam value on 64bit arch, whese
            // wparam = 0xffffffffff880000 or wparam = 0x00000000ff100000
            OnMouseWheel(0, ((long)wParam << 32 >> 48) / 120.0f);
        }

        void HandleMouseHWheel(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // This is due to inconsistent behavior of the WParam value on 64bit arch, whese
            // wparam = 0xffffffffff880000 or wparam = 0x00000000ff100000
            OnMouseWheel(((long)wParam << 32 >> 48) / 120.0f, 0);
        }

        void HandleLButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.SetCapture(window.Handle);
            OnMouseDown(MouseButton.Left);
        }

        void HandleMButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.SetCapture(window.Handle);
            OnMouseDown(MouseButton.Middle);
        }

        void HandleRButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.SetCapture(window.Handle);
            OnMouseDown(MouseButton.Right);
        }

        void HandleXButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.SetCapture(window.Handle);
            MouseButton button =
                ((wParam.ToInt32() & 0xFFFF0000) >> 16) == 1 ?
                MouseButton.Button1 : MouseButton.Button2;
            OnMouseDown(button);
        }

        void HandleLButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.ReleaseCapture();
            OnMouseUp(MouseButton.Left);
        }

        void HandleMButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.ReleaseCapture();
            OnMouseUp(MouseButton.Middle);
        }

        void HandleRButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.ReleaseCapture();
            OnMouseUp(MouseButton.Right);
        }

        void HandleXButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            Functions.ReleaseCapture();
            MouseButton button =
                ((wParam.ToInt32() & 0xFFFF0000) >> 16) == 1 ?
                MouseButton.Button1 : MouseButton.Button2;
            OnMouseUp(button);
        }

        void HandleKeyboard(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
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
            short scancode = (short)((lParam.ToInt64() >> 16) & 0xff);
            //ushort repeat_count = unchecked((ushort)((ulong)lParam.ToInt64() & 0xffffu));
            VirtualKeys vkey = (VirtualKeys)wParam;
            bool is_valid;
            Key key = WinKeyMap.TranslateKey(scancode, vkey, extended, false, out is_valid);

            if (is_valid)
            {
                if (pressed)
                {
                    //OnKeyDown(key, repeat_count > 0);
                    OnKeyDown(key, KeyboardState[key]);
                }
                else
                {
                    OnKeyUp(key);
                }
            }
        }

        void HandleKillFocus(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
        }

        void HandleCreate(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
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
        }

        void HandleClose(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            System.ComponentModel.CancelEventArgs e = new System.ComponentModel.CancelEventArgs();

            OnClosing(e);

            if (!e.Cancel)
            {
                DestroyWindow();
            }
        }

        void HandleDestroy(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            exists = false;

            if (handle == window.Handle)
            {
                Functions.UnregisterClass(ClassName, Instance);
            }
            window.Dispose();
            child_window.Dispose();

            OnClosed(EventArgs.Empty);
        }

        #endregion

        #region WindowProcedure

        IntPtr WindowProcedure(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            IntPtr? result = null;

            switch (message)
            {
                #region Size / Move / Style events

                case WindowMessage.ACTIVATE:
                    HandleActivate(handle, message, wParam, lParam);
                    break;

                case WindowMessage.ENTERMENULOOP:
                case WindowMessage.ENTERSIZEMOVE:
                    HandleEnterModalLoop(handle, message, wParam, lParam);
                    break;

                case WindowMessage.EXITMENULOOP:
                case WindowMessage.EXITSIZEMOVE:
                    HandleExitModalLoop(handle, message, wParam, lParam);
                    break;

                case WindowMessage.ERASEBKGND:
                    return new IntPtr(1);

                case WindowMessage.WINDOWPOSCHANGED:
                    HandleWindowPositionChanged(handle, message, wParam, lParam);
                    break;

                case WindowMessage.STYLECHANGED:
                    HandleStyleChanged(handle, message, wParam, lParam);
                    break;

                case WindowMessage.SIZE:
                    HandleSize(handle, message, wParam, lParam);
                    break;

                case WindowMessage.SETCURSOR:
                    result = HandleSetCursor(handle, message, wParam, lParam);
                    break;

                #endregion

                #region Input events

                case WindowMessage.CHAR:
                    HandleChar(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MOUSEMOVE:
                    HandleMouseMove(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MOUSELEAVE:
                    HandleMouseLeave(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MOUSEWHEEL:
                    HandleMouseWheel(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MOUSEHWHEEL:
                    HandleMouseHWheel(handle, message, wParam, lParam);
                    break;

                case WindowMessage.LBUTTONDOWN:
                    HandleLButtonDown(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MBUTTONDOWN:
                    HandleMButtonDown(handle, message, wParam, lParam);
                    break;

                case WindowMessage.RBUTTONDOWN:
                    HandleRButtonDown(handle, message, wParam, lParam);
                    break;

                case WindowMessage.XBUTTONDOWN:
                    HandleXButtonDown(handle, message, wParam, lParam);
                    break;

                case WindowMessage.LBUTTONUP:
                    HandleLButtonUp(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MBUTTONUP:
                    HandleMButtonUp(handle, message, wParam, lParam);
                    break;

                case WindowMessage.RBUTTONUP:
                    HandleRButtonUp(handle, message, wParam, lParam);
                    break;

                case WindowMessage.XBUTTONUP:
                    HandleXButtonUp(handle, message, wParam, lParam);
                    break;

                // Keyboard events:
                case WindowMessage.KEYDOWN:
                case WindowMessage.KEYUP:
                case WindowMessage.SYSKEYDOWN:
                case WindowMessage.SYSKEYUP:
                    HandleKeyboard(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.SYSCHAR:
                    return IntPtr.Zero;

                case WindowMessage.KILLFOCUS:
                    HandleKillFocus(handle, message, wParam, lParam);
                    break;

                #endregion

                #region Creation / Destruction events

                case WindowMessage.CREATE:
                    HandleCreate(handle, message, wParam, lParam);
                    break;

                case WindowMessage.CLOSE:
                    HandleClose(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.DESTROY:
                    HandleDestroy(handle, message, wParam, lParam);
                    break;

                #endregion
            }

            if (result.HasValue)
            {
                return result.Value;
            }
            else
            {
                return Functions.DefWindowProc(handle, message, wParam, lParam);
            }
        }

        private void EnableMouseTracking()
        {
            TrackMouseEventStructure me = new TrackMouseEventStructure();
            me.Size = TrackMouseEventStructure.SizeInBytes;
            me.TrackWindowHandle = child_window.Handle;
            me.Flags = TrackMouseEventFlags.LEAVE;

            if (!Functions.TrackMouseEvent(ref me))
                Debug.Print("[Warning] Failed to enable mouse tracking, error: {0}.",
                    Marshal.GetLastWin32Error());
        }

        private void StartTimer(IntPtr handle)
        {
            if (timer_handle == UIntPtr.Zero)
            {
                timer_handle = Functions.SetTimer(handle, new UIntPtr(1), ModalLoopTimerPeriod, null);
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
                // Todo: the following line appears to resize one of the 'large' icons, rather than using a small icon directly (multi-icon files). Investigate!
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
                Functions.DestroyWindow(window.Handle);
                exists = false;
            }
        }

        #endregion

        void HideBorder()
        {
            suppress_resize++;
            WindowBorder = WindowBorder.Hidden;
            suppress_resize--;
        }

        void RestoreBorder()
        {
            suppress_resize++;
            WindowBorder =
                deferred_window_border.HasValue ? deferred_window_border.Value :
                previous_window_border.HasValue ? previous_window_border.Value :
                WindowBorder;
            suppress_resize--;
            deferred_window_border = previous_window_border = null;
        }

        void ResetWindowState()
        {
            suppress_resize++;
            WindowState = WindowState.Normal;
            suppress_resize--;
        }

        void GrabCursor()
        {
            Point pos = PointToScreen(new Point(ClientRectangle.X, ClientRectangle.Y));
            Win32Rectangle rect = new Win32Rectangle();
            rect.left = pos.X;
            rect.right = pos.X + ClientRectangle.Width;
            rect.top = pos.Y;
            rect.bottom = pos.Y + ClientRectangle.Height;
            if (!Functions.ClipCursor(ref rect))
                Debug.WriteLine(String.Format("Failed to grab cursor. Error: {0}",
                    Marshal.GetLastWin32Error()));
        }

        void UngrabCursor()
        {
            if (!Functions.ClipCursor(IntPtr.Zero))
                Debug.WriteLine(String.Format("Failed to ungrab cursor. Error: {0}",
                    Marshal.GetLastWin32Error()));
        }

        #endregion

        #region INativeWindow Members

        #region Bounds

        public override Rectangle Bounds
        {
            get { return bounds; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(window.Handle, IntPtr.Zero, value.X, value.Y, value.Width, value.Height, 0);
            }
        }

        #endregion

        #region Location

        public override Point Location
        {
            get { return Bounds.Location; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(window.Handle, IntPtr.Zero, value.X, value.Y, 0, 0, SetWindowPosFlags.NOSIZE);
            }
        }

        #endregion

        #region Size

        public override Size Size
        {
            get { return Bounds.Size; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(window.Handle, IntPtr.Zero, 0, 0, value.Width, value.Height, SetWindowPosFlags.NOMOVE);
            }
        }

        #endregion

        #region ClientSize

        public override Size ClientSize
        {
            get
            {
                return client_rectangle.Size;
            }
            set
            {
                WindowStyle style = (WindowStyle)Functions.GetWindowLong(window.Handle, GetWindowLongOffsets.STYLE);
                Win32Rectangle rect = Win32Rectangle.From(value);
                Functions.AdjustWindowRect(ref rect, style, false);
                Size = new Size(rect.Width, rect.Height);
            }
        }

        #endregion

        #region Icon

        public override Icon Icon
        {
            get
            {
                return icon;
            }
            set
            {
                if (value != icon)
                {
                    icon = value;
                    if (window.Handle != IntPtr.Zero)
                    {
                        Functions.SendMessage(window.Handle, WindowMessage.SETICON, (IntPtr)0, icon == null ? IntPtr.Zero : value.Handle);
                        Functions.SendMessage(window.Handle, WindowMessage.SETICON, (IntPtr)1, icon == null ? IntPtr.Zero : value.Handle);
                    }
                    OnIconChanged(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Focused

        public override bool Focused
        {
            get { return focused; }
        }

        #endregion

        #region Title

        StringBuilder sb_title = new StringBuilder(256);
        public override string Title
        {
            get
            {
                sb_title.Remove(0, sb_title.Length);
                if (Functions.GetWindowText(window.Handle, sb_title, sb_title.Capacity) == 0)
                    Debug.Print("Failed to retrieve window title (window:{0}, reason:{1}).", window.Handle, Marshal.GetLastWin32Error());
                return sb_title.ToString();
            }
            set
            {
                if (Title != value)
                {
                    if (!Functions.SetWindowText(window.Handle, value))
                        Debug.Print("Failed to change window title (window:{0}, new title:{1}, reason:{2}).", window.Handle, value, Marshal.GetLastWin32Error());
                    OnTitleChanged(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Visible

        public override bool Visible
        {
            get
            {
                return Functions.IsWindowVisible(window.Handle);
            }
            set
            {
                if (value != Visible)
                {
                    if (value)
                    {
                        Functions.ShowWindow(window.Handle, ShowWindowCommand.SHOW);
                        if (invisible_since_creation)
                        {
                            Functions.BringWindowToTop(window.Handle);
                            Functions.SetForegroundWindow(window.Handle);
                        }
                    }
                    else if (!value)
                    {
                        Functions.ShowWindow(window.Handle, ShowWindowCommand.HIDE);
                    }

                    OnVisibleChanged(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Exists

        public override  bool Exists { get { return exists; } }

        #endregion

        #region Cursor

        public override MouseCursor Cursor
        {
            get
            {
                return cursor;
            }
            set
            {
                if (value != cursor)
                {
                    bool destoryOld = cursor != MouseCursor.Default;
                    IntPtr oldCursor = IntPtr.Zero;

                    if (value == MouseCursor.Default)
                    {
                        cursor_handle = Functions.LoadCursor(CursorName.Arrow);
                        oldCursor = Functions.SetCursor(cursor_handle);
                        cursor = value;
                    }
                    else
                    {
                        var stride = value.Width *
                            (Bitmap.GetPixelFormatSize(System.Drawing.Imaging.PixelFormat.Format32bppArgb) / 8);

                        Bitmap bmp;
                        unsafe
                        {
                            fixed (byte* pixels = value.Data)
                            {
                                bmp = new Bitmap(value.Width, value.Height, stride,
                                    System.Drawing.Imaging.PixelFormat.Format32bppArgb,
                                    new IntPtr(pixels));
                            }
                        }
                        using (bmp)
                        {
                            var iconInfo = new IconInfo();
                            var bmpIcon = bmp.GetHicon();
                            var success = Functions.GetIconInfo(bmpIcon, out iconInfo);

                            if (success)
                            {
                                iconInfo.xHotspot = value.X;
                                iconInfo.yHotspot = value.Y;
                                iconInfo.fIcon = false;

                                var icon = Functions.CreateIconIndirect(ref iconInfo);

                                if (icon != IntPtr.Zero)
                                {
                                    // Currently using a custom cursor so destroy it 
                                    // once replaced
                                    cursor = value;
                                    cursor_handle = icon;
                                    oldCursor = Functions.SetCursor(icon);
                                }
                            }
                        }
                    }

                    if (destoryOld && oldCursor != IntPtr.Zero)
                    {
                        Functions.DestroyIcon(oldCursor);
                    }
                }
            }
        }

        #endregion

        #region CursorVisible

        public override bool CursorVisible
        {
            get { return cursor_visible_count >= 0; } // Not used
            set
            {
                if (value && cursor_visible_count < 0)
                {
                    do
                    {
                        cursor_visible_count = Functions.ShowCursor(true);
                    }
                    while (cursor_visible_count < 0);

                    UngrabCursor();
                }
                else if (!value && cursor_visible_count >= 0)
                {
                    do
                    {
                        cursor_visible_count = Functions.ShowCursor(false);
                    }
                    while (cursor_visible_count >= 0);

                    GrabCursor();
                }
            }
        }
        
        #endregion

        #region Close

        public override void Close()
        {
            Functions.PostMessage(window.Handle, WindowMessage.CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        #endregion

        #region public WindowState WindowState

        public override WindowState WindowState
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

                switch (value)
                {
                    case WindowState.Normal:
                        command = ShowWindowCommand.RESTORE;
                        borderless_maximized_window_state = false;

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
                            IntPtr current_monitor = Functions.MonitorFromWindow(window.Handle, MonitorFrom.Nearest);
                            MonitorInfo info = new MonitorInfo();
                            info.Size = MonitorInfo.SizeInBytes;
                            Functions.GetMonitorInfo(current_monitor, ref info);

                            previous_bounds = Bounds;
                            borderless_maximized_window_state = true;
                            Bounds = info.Work.ToRectangle();
                        }
                        else
                        {
                            borderless_maximized_window_state = false;
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

                        Functions.SetForegroundWindow(window.Handle);

                        break;
                }

                if (command != 0)
                    Functions.ShowWindow(window.Handle, command);

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

        public override WindowBorder WindowBorder
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

                WindowStyle old_style = WindowStyle.ClipChildren | WindowStyle.ClipSiblings;
                WindowStyle new_style = old_style;

                switch (value)
                {
                    case WindowBorder.Resizable:
                        new_style |= WindowStyle.OverlappedWindow;
                        break;

                    case WindowBorder.Fixed:
                        new_style |= WindowStyle.OverlappedWindow &
                            ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox | WindowStyle.SizeBox);
                        break;

                    case WindowBorder.Hidden:
                        new_style |= WindowStyle.Popup;
                        break;
                }

                // Make sure client size doesn't change when changing the border style.
                Size client_size = ClientSize;
                Win32Rectangle rect = Win32Rectangle.From(client_size);
                Functions.AdjustWindowRectEx(ref rect, new_style, false, ParentStyleEx);

                // This avoids leaving garbage on the background window.
                if (was_visible)
                    Visible = false;

                Functions.SetWindowLong(window.Handle, GetWindowLongOffsets.STYLE, (IntPtr)(int)new_style);
                Functions.SetWindowPos(window.Handle, IntPtr.Zero, 0, 0, rect.Width, rect.Height,
                    SetWindowPosFlags.NOMOVE | SetWindowPosFlags.NOZORDER |
                    SetWindowPosFlags.FRAMECHANGED);

                // Force window to redraw update its borders, but only if it's
                // already visible (invisible windows will change borders when
                // they become visible, so no need to make them visiable prematurely).
                if (was_visible)
                    Visible = true;

                WindowState = state;

                // Workaround for github issues #33 and #34,
                // where WindowMessage.STYLECHANGED is not
                // delivered when running on Mono/Windows.
                if (Configuration.RunningOnMono)
                {
                    StyleStruct style = new StyleStruct();
                    style.New = new_style;
                    style.Old = old_style;
                    unsafe
                    {
                        HandleStyleChanged(
                            window.Handle,
                            WindowMessage.STYLECHANGED,
                            new IntPtr((int)(GWL.STYLE | GWL.EXSTYLE)),
                            new IntPtr(&style));
                    }
                }
            }
        }

        #endregion

        #region PointToClient

        public override Point PointToClient(Point point)
        {
            if (!Functions.ScreenToClient(window.Handle, ref point))
                throw new InvalidOperationException(String.Format(
                    "Could not convert point {0} from screen to client coordinates. Windows error: {1}",
                    point.ToString(), Marshal.GetLastWin32Error()));

            return point;
        }

        #endregion

        #region PointToScreen

        public override Point PointToScreen(Point point)
        {
            if (!Functions.ClientToScreen(window.Handle, ref point))
                throw new InvalidOperationException(String.Format(
                    "Could not convert point {0} from screen to client coordinates. Windows error: {1}",
                    point.ToString(), Marshal.GetLastWin32Error()));

            return point;
        }

        #endregion

        #endregion

        #region INativeGLWindow Members

        #region public void ProcessEvents()

        MSG msg;
        public override void ProcessEvents()
        {
            base.ProcessEvents();
            while (Functions.PeekMessage(ref msg, IntPtr.Zero, 0, 0, PeekMessageFlags.Remove))
            {
                Functions.TranslateMessage(ref msg);
                Functions.DispatchMessage(ref msg);
            }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public override IWindowInfo WindowInfo
        {
            get { return child_window; }
        }

        #endregion

        #endregion

        #region IDisposable Members

        protected override void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                if (calledManually)
                {
                    if (Cursor != MouseCursor.Default && cursor_handle != IntPtr.Zero)
                    {
                        Functions.DestroyIcon(cursor_handle);
                        cursor_handle = IntPtr.Zero;
                    }

                    // Safe to clean managed resources
                    DestroyWindow();
                    if (Icon != null)
                        Icon.Dispose();
                }
                else
                {
                    Debug.Print("[Warning] INativeWindow leaked ({0}). Did you forget to call INativeWindow.Dispose()?", this);
                }

                OnDisposed(EventArgs.Empty);
                disposed = true;
            }
        }

        #endregion
    }
}
