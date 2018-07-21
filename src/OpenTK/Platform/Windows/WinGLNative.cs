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

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Input;
using OpenTK.NT.Native;
#if !MINIMAL
using System.Drawing;
using System.Drawing.Imaging;

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
        private const ExtendedWindowStyles ParentStyleEx = ExtendedWindowStyles.WindowEdge | ExtendedWindowStyles.AppWindow;
        private const ExtendedWindowStyles ChildStyleEx = 0;
        private const WindowClassStyles DefaultClassStyle = WindowClassStyles.OwnDeviceContext;

        private const long ExtendedBit = 1 << 24; // Used to distinguish left and right control, alt and enter keys.

        public static readonly uint ShiftLeftScanCode = User32.Keyboard.MapVirtualKey(VirtualKey.LShift, 0);
        public static readonly uint ShiftRightScanCode = User32.Keyboard.MapVirtualKey(VirtualKey.RShift, 0);
        public static readonly uint ControlLeftScanCode = User32.Keyboard.MapVirtualKey(VirtualKey.LControl, 0);
        public static readonly uint ControlRightScanCode = User32.Keyboard.MapVirtualKey(VirtualKey.RControl, 0);
        public static readonly uint AltLeftScanCode = User32.Keyboard.MapVirtualKey(VirtualKey.LMenu, 0);
        public static readonly uint AltRightScanCode = User32.Keyboard.MapVirtualKey(VirtualKey.RMenu, 0);

        private static readonly object SyncRoot = new object();

        private readonly string ClassName = Guid.NewGuid().ToString();
        private readonly IntPtr Instance = Marshal.GetHINSTANCE(typeof(WinGLNative).Module);

        private const uint ModalLoopTimerPeriod = 1;

        private readonly WinWindowInfo window;
        private readonly WindowProc WindowProcedureDelegate;

        // Hack to get maximized mode with hidden border (not normally possible).
        private bool borderless_maximized_window_state;

        // Used to restore previous size when leaving fullscreen mode.
        private Rectangle bounds, client_rectangle, previous_bounds; 

        private bool class_registered;

        private MouseCursor cursor = MouseCursor.Default;
        private IntPtr cursor_handle = User32.Cursor.LoadCursor(CursorName.Arrow);
        private int cursor_visible_count;

        // Set to avoid changing borders during fullscreen state.
        private WindowBorder? deferred_window_border; 
        private bool disposed;
        private bool exists;
        private bool focused;

        private Icon icon;

        // Set by WindowsMessage.CREATE and consumed by Visible = true (calls BringWindowToFront).
        private bool invisible_since_creation;

        // set to true whenever we enter the modal resize/move event loop
        private bool is_in_modal_loop;
        private int mouse_capture_count;
        private int mouse_last_timestamp;
        private bool mouse_outside_window = true;

        // Set when changing to fullscreen state.
        private WindowBorder? previous_window_border;

        // Used in WindowBorder and WindowState in order to avoid rapid, consecutive resize events.
        private int suppress_resize;

        private UIntPtr timer_handle;
        private WindowBorder windowBorder = WindowBorder.Resizable;
        private WindowState windowState = WindowState.Normal;

        public WinGLNative(
            int x, 
            int y,
            int width,
            int height,
            string title,
            GameWindowFlags options,
            DisplayDevice device
        )
        {
            lock (SyncRoot)
            {
                // This is the main window procedure callback. We need the callback in order to create the window, so
                // don't move it below the CreateWindow calls.
                WindowProcedureDelegate = WindowProcedure;

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

                var hWnd = CreateWindow(
                    scale_x,
                    scale_y,
                    scale_width,
                    scale_height,
                    title,
                    options,
                    device,
                    IntPtr.Zero
                );

                window = new WinWindowInfo(hWnd, null);
                Shell32.DragAcceptFiles(window.Handle, true);

                exists = true;
            }
        }

        public override Rectangle Bounds
        {
            get => bounds;
            set => User32.Window.SetWindowPos(window.Handle, IntPtr.Zero, value.X, value.Y, value.Width, value.Height, 0);
        }

        public override System.Drawing.Point Location
        {
            get => Bounds.Location;
            set => User32.Window.SetWindowPos(window.Handle, IntPtr.Zero, value.X, value.Y, 0, 0, SetWindowPosFlags.NoSize);
        }

        public override Size Size
        {
            get => Bounds.Size;
            set => User32.Window.SetWindowPos(window.Handle, IntPtr.Zero, 0, 0, value.Width, value.Height, SetWindowPosFlags.NoMove);
        }

        public override Size ClientSize
        {
            get => client_rectangle.Size;
            set
            {
                var style = (WindowStyles)User32.Window.GetWindowLong(window.Handle, GetWindowLongIndex.Style);
                Rect rect = Rect.FromSize(value);
                User32.Window.AdjustWindowRect(ref rect, style, false);
                Size = new Size(rect.Width, rect.Height);
            }
        }

        public override Icon Icon
        {
            get => icon;
            set
            {
                if (value == Icon)
                    return;

                icon = value;
                if (window.Handle != IntPtr.Zero)
                {
                    var lParam = icon?.Handle ?? IntPtr.Zero;
                    User32.Message.SendMessage(window.Handle, WindowMessage.SetIcon, new IntPtr(0), lParam);
                    User32.Message.SendMessage(window.Handle, WindowMessage.SetIcon, new IntPtr(1), lParam);
                }

                OnIconChanged(EventArgs.Empty);
            }
        }

        public override bool Focused => focused;

        public override string Title
        {
            get
            {
                var titleBuilder = new StringBuilder(256); // max window title length

                if (User32.Window.GetWindowText(window.Handle, titleBuilder, titleBuilder.Capacity) == 0)
                    Debug.Print($"Failed to retrieve window title (window: {window.Handle}, reason: {Marshal.GetLastWin32Error()}).");

                return titleBuilder.ToString();
            }
            set
            {
                if (Title != value)
                {
                    if (!User32.Window.SetWindowText(window.Handle, value))
                        Debug.Print($"Failed to change window title (window: {window.Handle}, new title: {value}, reason: {Marshal.GetLastWin32Error()}).");

                    OnTitleChanged(EventArgs.Empty);
                }
            }
        }

        public override bool Visible
        {
            get => User32.Window.IsWindowVisible(window.Handle);
            set
            {
                if (value == Visible)
                    return;

                if (value)
                {
                    User32.Window.ShowWindow(window.Handle, ShowWindowCommand.Show);
                    if (invisible_since_creation)
                    {
                        User32.Window.BringWindowToTop(window.Handle);
                        User32.Window.SetForegroundWindow(window.Handle);
                    }
                }
                else
                {
                    User32.Window.ShowWindow(window.Handle, ShowWindowCommand.Hide);
                }

                OnVisibleChanged(EventArgs.Empty);
            }
        }

        public override bool Exists => exists;

        public override MouseCursor Cursor
        {
            get => cursor;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                if (value == Cursor)
                    return;

                var oldCursor = cursor;
                var oldCursorHandle = cursor_handle;

                if (value == MouseCursor.Default)
                {
                    cursor = value;
                    cursor_handle = User32.Cursor.LoadCursor(CursorName.Arrow);
                    User32.Cursor.SetCursor(cursor_handle);
                }
                else
                {
                    var stride = value.Width * (Image.GetPixelFormatSize(PixelFormat.Format32bppArgb) / 8);

                    Bitmap bmp;
                    unsafe
                    {
                        fixed (byte* pixels = value.Data)
                        {
                            bmp = new Bitmap(
                                value.Width,
                                value.Height,
                                stride,
                                PixelFormat.Format32bppArgb,
                                new IntPtr(pixels)
                            );
                        }
                    }

                    using (bmp)
                    {
                        var iconInfo = new IconInfo();
                        var bmpIcon = bmp.GetHicon();
                        var success = User32.Icon.GetIconInfo(bmpIcon, out iconInfo);

                        try
                        {
                            if (!success)
                                throw new Win32Exception();

                            iconInfo.XHotspot = (uint)value.X;
                            iconInfo.YHotspot = (uint)value.Y;
                            iconInfo.Icon = false;

                            var icon = User32.Icon.CreateIconIndirect(ref iconInfo);
                            if (icon == IntPtr.Zero)
                                throw new Win32Exception();

                            // Need to destroy this icon when/if it's replaced by another cursor.
                            cursor = value;
                            cursor_handle = icon;
                            User32.Cursor.SetCursor(icon);
                        }
                        finally
                        {
                            if (success)
                            {
                                // GetIconInfo creates bitmaps for the hbmMask and hbmColor members of ICONINFO.
                                // The calling application must manage these bitmaps and delete them when they are no longer necessary.
                                Gdi32.DeleteObject(iconInfo.BitmapColor);
                                Gdi32.DeleteObject(iconInfo.BitmapMask);
                            }

                            User32.Icon.DestroyIcon(bmpIcon);
                        }
                    }
                }

                Debug.Assert(oldCursorHandle != IntPtr.Zero);
                Debug.Assert(oldCursorHandle != cursor_handle);
                Debug.Assert(oldCursor != cursor);

                // If we've replaced a custom (non-default) cursor we need to free the handle.
                if (oldCursor != MouseCursor.Default)
                    User32.Icon.DestroyIcon(oldCursorHandle);
            }
        }

        public override bool CursorVisible
        {
            get => cursor_visible_count >= 0;
            set
            {
                if (value == CursorVisible)
                    return;

                if (value)
                {
                    do
                    {
                        cursor_visible_count = User32.Cursor.ShowCursor(true);
                    }
                    while (cursor_visible_count < 0);

                    UngrabCursor();
                }
                else
                {
                    do
                    {
                        cursor_visible_count = User32.Cursor.ShowCursor(false);
                    }
                    while (cursor_visible_count >= 0);

                    GrabCursor();
                }
            }
        }

        public override WindowState WindowState
        {
            get => windowState;
            set
            {
                if (WindowState == value)
                    return;

                ShowWindowCommand command = 0;
                bool exiting_fullscreen = false;

                switch (value)
                {
                    case WindowState.Normal:
                        command = ShowWindowCommand.Restore;
                        borderless_maximized_window_state = false;

                        // If we are leaving fullscreen mode we need to restore the border.
                        if (WindowState == WindowState.Fullscreen)
                        {
                            exiting_fullscreen = true;
                        }

                        break;

                    case WindowState.Maximized:
                        // Note: if we use the MAXIMIZE command and the window border is Hidden (i.e. WS_POPUP),
                        // we will enter fullscreen mode - we don't want that! As a workaround, we'll resize the window
                        // manually to cover the whole working area of the current monitor.

                        // Reset state to avoid strange interactions with fullscreen/minimized windows.
                        ResetWindowState();

                        if (WindowBorder == WindowBorder.Hidden)
                        {
                            var current_monitor = User32.Monitor.MonitorFromWindow(window.Handle, MonitorFromDefaultValue.DefaultToNearest);
                            var info = new MonitorInfo { Size = MonitorInfo.SizeInBytes };
                            User32.Monitor.GetMonitorInfo(current_monitor, out info);

                            previous_bounds = Bounds;
                            borderless_maximized_window_state = true;
                            Bounds = info.Work;
                        }
                        else
                        {
                            borderless_maximized_window_state = false;
                            command = ShowWindowCommand.Maximize;
                        }

                        break;

                    case WindowState.Minimized:
                        command = ShowWindowCommand.Minimize;
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
                        command = ShowWindowCommand.Maximize;

                        User32.Window.SetForegroundWindow(window.Handle);

                        break;
                }

                if (command != 0)
                    User32.Window.ShowWindow(window.Handle, command);

                // Restore previous window border or apply pending border change when leaving fullscreen mode.
                if (exiting_fullscreen)
                    RestoreBorder();

                // Restore previous window size/location if necessary
                if (command == ShowWindowCommand.Restore && previous_bounds != Rectangle.Empty)
                {
                    Bounds = previous_bounds;
                    previous_bounds = Rectangle.Empty;
                }
            }
        }

        public override WindowBorder WindowBorder
        {
            get => windowBorder;
            set
            {
                // Do not allow border changes during fullscreen mode.
                // Defer them for when we leave fullscreen.
                if (WindowState == WindowState.Fullscreen)
                {
                    deferred_window_border = value;
                    return;
                }

                if (value == WindowBorder)
                    return;

                // We wish to avoid making an invisible window visible just to change the border.
                // However, it's a good idea to make a visible window invisible temporarily, to
                // avoid garbage caused by the border change.
                bool was_visible = Visible;

                // To ensure maximized/minimized windows work correctly, reset state to normal,
                // change the border, then go back to maximized/minimized.
                var state = WindowState;
                ResetWindowState();

                var old_style = WindowStyles.ClipChildren | WindowStyles.ClipSiblings;
                var new_style = old_style;

                switch (value)
                {
                    case WindowBorder.Resizable:
                        new_style |= WindowStyles.OverlappedWindow;
                        break;

                    case WindowBorder.Fixed:
                        new_style |= WindowStyles.OverlappedWindow &
                            ~(WindowStyles.ThickFrame | WindowStyles.MaximizeBox | WindowStyles.SizeBox);
                        break;

                    case WindowBorder.Hidden:
                        new_style |= WindowStyles.Popup;
                        break;
                }

                // Make sure client size doesn't change when changing the border style.
                var client_size = ClientSize;
                Rect rect = bounds;
                User32.Window.AdjustWindowRectEx(ref rect, new_style, false, ParentStyleEx);

                // This avoids leaving garbage on the background window.
                if (was_visible)
                    Visible = false;

                User32.Window.SetWindowLong(window.Handle, GetWindowLongIndex.Style, new IntPtr((int)new_style));
                User32.Window.SetWindowPos(
                    window.Handle,
                    IntPtr.Zero,
                    0,
                    0,
                    rect.Width,
                    rect.Height,
                    SetWindowPosFlags.NoMove | SetWindowPosFlags.NoZOrder | SetWindowPosFlags.FrameChanged
                );

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
                    var style = new StyleStruct
                    {
                        StyleNew = (uint)new_style,
                        StyleOld = (uint)old_style
                    };

                    var ptr = IntPtr.Zero;
                    Marshal.StructureToPtr(style, ptr, true);

                    HandleStyleChanged(
                        window.Handle,
                        WindowMessage.StyleChanged,
                        new IntPtr((int)(GetWindowLongIndex.Style | GetWindowLongIndex.ExStyle)),
                        ptr
                    );
                }
            }
        }

        public override IWindowInfo WindowInfo => window;

        // Scales a value according according
        // to the DPI of the specified direction
        private static int Scale(int v, ScaleDirection direction)
        {
            var dc = User32.DeviceContext.GetDC(IntPtr.Zero);

            if (dc != IntPtr.Zero)
            {
                int dpi = Gdi32.GetDeviceCaps(
                    dc,
                    direction == ScaleDirection.X ? GetDeviceCapsIndex.LogicalPixelsX : GetDeviceCapsIndex.LogicalPixelsY
                );

                if (dpi > 0)
                {
                    float scale = dpi / 96.0f;
                    v = (int)Math.Round(v * scale);
                }

                User32.DeviceContext.ReleaseDC(IntPtr.Zero, dc);
            }

            return v;
        }

        private static int ScaleX(int x) => Scale(x, ScaleDirection.X);

        private static int ScaleY(int y) => Scale(y, ScaleDirection.Y);

        private static int Unscale(int v, ScaleDirection direction)
        {
            var dc = User32.DeviceContext.GetDC(IntPtr.Zero);

            if (dc != IntPtr.Zero)
            {
                int dpi = Gdi32.GetDeviceCaps(
                    dc,
                    direction == ScaleDirection.X ? GetDeviceCapsIndex.LogicalPixelsX : GetDeviceCapsIndex.LogicalPixelsY
                );

                if (dpi > 0)
                {
                    float scale = dpi / 96.0f;
                    v = (int)Math.Round(v / scale);
                }

                User32.DeviceContext.ReleaseDC(IntPtr.Zero, dc);
            }

            return v;
        }

        private static int UnscaleX(int x) => Unscale(x, ScaleDirection.X);

        private static int UnscaleY(int y) => Unscale(y, ScaleDirection.Y);

        private void HandleActivate(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // See http://msdn.microsoft.com/en-us/library/ms646274(VS.85).aspx (WM_ACTIVATE notification):
            // wParam: The low-order word specifies whether the window is being activated or deactivated.
            bool new_focused_state = Focused;

            focused = IntPtr.Size == 4 ?
                (wParam.ToInt32() & 0xFFFF) != 0 :
                (wParam.ToInt64() & 0xFFFF) != 0;

            if (new_focused_state != Focused)
                OnFocusedChanged(EventArgs.Empty);
        }

        private void HandleEnterModalLoop(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // Entering the modal size/move loop: we don't want rendering to
            // stop during this time, so we register a timer callback to continue
            // processing from time to time.
            is_in_modal_loop = true;
            StartTimer(handle);

            if (!CursorVisible)
                UngrabCursor();
        }

        private void HandleExitModalLoop(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // Exiting from Modal size/move loop: the timer callback is no longer
            // necessary.
            is_in_modal_loop = false;
            StopTimer(handle);

            // Ensure cursor remains grabbed
            if (!CursorVisible)
                GrabCursor();
        }

        private void HandleWindowPositionChanged(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var pos = Marshal.PtrToStructure<WindowPosition>(lParam);
            if (window != null && pos.HWnd == window.Handle)
            {
                var new_location = new System.Drawing.Point(pos.X, pos.Y);
                if (Location != new_location)
                {
                    bounds.Location = new_location;
                    OnMove(EventArgs.Empty);
                }

                var new_size = new Size(pos.Width, pos.Height);
                if (Size != new_size)
                {
                    bounds.Width = pos.Width;
                    bounds.Height = pos.Height;

                    User32.Window.GetClientRect(handle, out Rect rect);
                    client_rectangle = rect;

                    User32.Window.SetWindowPos
                    (
                        window.Handle, 
                        IntPtr.Zero, 
                        bounds.X, 
                        bounds.Y, 
                        bounds.Width,
                        bounds.Height,
                        SetWindowPosFlags.NoZOrder | SetWindowPosFlags.NoOwnerZOrder |
                        SetWindowPosFlags.NoActivate | SetWindowPosFlags.NoSendChanging
                    );

                    if (suppress_resize <= 0)
                        OnResize(EventArgs.Empty);
                }

                if (!is_in_modal_loop && !CursorVisible)
                {
                    // If we are in a modal resize/move loop, cursor grabbing is
                    // handled inside [ENTER|EXIT]SIZEMOVE case above.
                    // If not, then we have to handle cursor grabbing here.
                    GrabCursor();
                }
            }
        }

        private void HandleStyleChanged(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var old_border = windowBorder;
            var new_border = old_border;

            var get_window_style = (GetWindowLongIndex)wParam.ToInt32();
            if ((get_window_style & (GetWindowLongIndex.Style | GetWindowLongIndex.ExStyle)) != 0)
            {
                var style = (WindowStyles)Marshal.PtrToStructure<StyleStruct>(lParam).StyleNew;

                if ((style & WindowStyles.Popup) != 0)
                    new_border = WindowBorder.Hidden;
                else if ((style & WindowStyles.ThickFrame) != 0)
                    new_border = WindowBorder.Resizable;
                else if ((style & ~(WindowStyles.ThickFrame | WindowStyles.MaximizeBox)) != 0)
                    new_border = WindowBorder.Fixed;
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

        private void HandleSize(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var state = (WindowMessageSizeType)wParam.ToInt64();
            var new_state = windowState;
            switch (state)
            {
                case WindowMessageSizeType.Restored:
                    new_state = borderless_maximized_window_state ? WindowState.Maximized : WindowState.Normal;
                    break;

                case WindowMessageSizeType.Minimized:
                    new_state = WindowState.Minimized;
                    break;

                case WindowMessageSizeType.Maximized:
                    new_state = WindowBorder == WindowBorder.Hidden ? WindowState.Fullscreen : WindowState.Maximized;
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

        private IntPtr HandleSetCursor(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            if (cursor != MouseCursor.Default)
            {
                // Only set the mouse cursor inside the client rectangle
                // See MSDN "Setting the Cursor Image"
                const int ht_client = 1;
                if ((lParam.ToInt64() & 0xFFFF) == ht_client)
                {
                    User32.Cursor.SetCursor(cursor_handle);
                    return new IntPtr(1);
                }
            }

            return IntPtr.Zero;
        }

        private void HandleCaptureChanged(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            if (lParam != window.Handle)
                mouse_capture_count = 0;
        }

        private void HandleChar(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            char c = IntPtr.Size == 4 ?
                (char)wParam.ToInt32() :
                (char)wParam.ToInt64();

            if (!char.IsControl(c))
                OnKeyPress(c);
        }

        private void HandleMouseMove(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var point = new System.Drawing.Point(
                (short)((uint)lParam.ToInt32() & 0x0000FFFF),
                (short)(((uint)lParam.ToInt32() & 0xFFFF0000) >> 16));

            if (mouse_capture_count > 0)
            {
                bool mouse_was_outside_window = mouse_outside_window;
                mouse_outside_window = !ClientRectangle.Contains(point);

                if (mouse_outside_window && !mouse_was_outside_window)
                {
                    // Mouse leaving
                    // If we have mouse capture we ignore WM_MOUSELEAVE events, so
                    // have to manually call OnMouseLeave here.
                    // Mouse tracking is disabled automatically by the OS
                    OnMouseLeave(EventArgs.Empty);
                }
                else if (!mouse_outside_window && mouse_was_outside_window)
                {
                    // Mouse entring
                    OnMouseEnter(EventArgs.Empty);
                }
            }
            else if ( /* !mouse_is_captured && */ mouse_outside_window)
            {
                // Once we receive a mouse move event, it means that the mouse has
                // re-entered the window.
                mouse_outside_window = false;
                EnableMouseTracking();
                OnMouseEnter(EventArgs.Empty);
            }

            unsafe
            {
                // GetMouseMovePointsEx works with screen coordinates
                NT.Native.Point screenPoint = point;
                User32.Window.ClientToScreen(handle, ref screenPoint);
                int timestamp = User32.Message.GetMessageTime();

                // & 0xFFFF to handle multiple monitors
                var movePoint = new MouseMovePoint
                {
                    X = screenPoint.X & 0xFFFF,
                    Y = screenPoint.Y & 0xFFFF,
                    Time = (uint)timestamp
                };

                // Max points GetMouseMovePointsEx can return is 64.
                const int numPoints = 64;
                MouseMovePoint* movePoints = stackalloc MouseMovePoint[numPoints];

                // GetMouseMovePointsEx fills in movePoints so that the most
                // recent events are at low indices in the array.
                int points = User32.Mouse.GetMouseMovePointsEx(
                    MouseMovePoint.SizeInBytes,
                    ref movePoint,
                    movePoints,
                    numPoints,
                    GetMouseMovePointsResolution.UseDisplayPoints
                );

                int lastError = Marshal.GetLastWin32Error();

                // No points returned or search point not found
                if (points == 0 || points == -1 && lastError == 1171) // 'The point passed to GetMouseMovePoints is not in the buffer.'
                {
                    // Just use the mouse move position
                    OnMouseMove(point.X, point.Y);
                }
                else if (points == -1)
                {
                    throw new Win32Exception(lastError);
                }
                else
                {
                    // Exclude the current position.
                    var currentScreenPosition = new NT.Native.Point(MouseState.X, MouseState.Y);
                    User32.Window.ClientToScreen(handle, ref currentScreenPosition);

                    // Find the first move point we've already seen.
                    int i = 0;
                    for (i = 0; i < points; ++i)
                    {
                        if (movePoints[i].Time < mouse_last_timestamp)
                            break;

                        if (movePoints[i].Time == mouse_last_timestamp &&
                            movePoints[i].X == currentScreenPosition.X &&
                            movePoints[i].Y == currentScreenPosition.Y)
                        {
                            break;
                        }
                    }

                    // Now move the mouse to each point before the one just found.
                    while (--i >= 0)
                    {
                        var position = new NT.Native.Point(movePoints[i].X, movePoints[i].Y);
                        // Handle multiple monitors http://support.microsoft.com/kb/269743
                        if (position.X > 32767)
                            position.X -= 65536;

                        if (position.Y > 32767)
                            position.Y -= 65536;

                        User32.Window.ScreenToClient(handle, ref position);
                        OnMouseMove(position.X, position.Y);
                    }
                }

                mouse_last_timestamp = timestamp;
            }
        }

        private void HandleMouseLeave(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // If the mouse is captured we get spurious MOUSELEAVE events.
            // So ignore WM_MOUSELEAVE if capture count != 0.
            if (mouse_capture_count == 0)
            {
                mouse_outside_window = true;
                // Mouse tracking is disabled automatically by the OS
                OnMouseLeave(EventArgs.Empty);
            }
        }

        private void HandleMouseWheel(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // This is due to inconsistent behavior of the WParam value on 64bit arch, whese
            // wparam = 0xffffffffff880000 or wparam = 0x00000000ff100000
            OnMouseWheel(0, (((long)wParam << 32) >> 48) / 120.0f);
        }

        private void HandleMouseHWheel(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            // This is due to inconsistent behavior of the WParam value on 64bit arch, whese
            // wparam = 0xffffffffff880000 or wparam = 0x00000000ff100000
            OnMouseWheel((((long)wParam << 32) >> 48) / 120.0f, 0);
        }

        private void HandleLButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            SetCapture();
            OnMouseDown(MouseButton.Left);
        }

        private void HandleMButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            SetCapture();
            OnMouseDown(MouseButton.Middle);
        }

        private void HandleRButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            SetCapture();
            OnMouseDown(MouseButton.Right);
        }

        private void HandleXButtonDown(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            SetCapture();
            var button =
                (wParam.ToInt32() & 0xFFFF0000) >> 16 == 1 ? MouseButton.Button1 : MouseButton.Button2;
            OnMouseDown(button);
        }

        private void HandleLButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            ReleaseCapture();
            OnMouseUp(MouseButton.Left);
        }

        private void HandleMButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            ReleaseCapture();
            OnMouseUp(MouseButton.Middle);
        }

        private void HandleRButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            ReleaseCapture();
            OnMouseUp(MouseButton.Right);
        }

        private void HandleXButtonUp(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            ReleaseCapture();
            var button =
                (wParam.ToInt32() & 0xFFFF0000) >> 16 == 1 ? MouseButton.Button1 : MouseButton.Button2;
            OnMouseUp(button);
        }

        private void HandleKeyboard(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            bool pressed =
                message == WindowMessage.KeyDown ||
                message == WindowMessage.SystemKeyDown;

            // Shift/Control/Alt behave strangely when e.g. ShiftRight is held down and ShiftLeft is pressed
            // and released. It looks like neither key is released in this case, or that the wrong key is
            // released in the case of Control and Alt.
            // To combat this, we are going to release both keys when either is released. Hacky, but should work.
            // Win95 does not distinguish left/right key constants (GetAsyncKeyState returns 0).
            // In this case, both keys will be reported as pressed.

            bool extended = (lParam.ToInt64() & ExtendedBit) != 0;
            short scancode = (short)((lParam.ToInt64() >> 16) & 0xFF);
            //ushort repeat_count = unchecked((ushort)((ulong)lParam.ToInt64() & 0xffffu));
            var vkey = (VirtualKey)wParam;
            var key = WinKeyMap.TranslateKey(scancode, vkey, extended, false, out bool is_valid);

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

        private void HandleKillFocus(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
        }

        private void HandleCreate(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var cs = Marshal.PtrToStructure<CreateStruct>(lParam);
            if (cs.Parent == IntPtr.Zero)
            {
                bounds.X = cs.X;
                bounds.Y = cs.Y;
                bounds.Width = cs.Width;
                bounds.Height = cs.Height;

                User32.Window.GetClientRect(handle, out Rect rect);
                client_rectangle = rect;

                invisible_since_creation = true;
            }
        }

        private void HandleClose(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var e = new CancelEventArgs();

            OnClosing(e);

            if (!e.Cancel)
                DestroyWindow();
        }

        private void HandleDestroy(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            exists = false;

            if (handle == window.Handle)
                User32.WindowClass.UnregisterClass(ClassName, Instance);

            window.Dispose();

            OnClosed(EventArgs.Empty);
        }

        private void HandleDropFiles(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var hDrop = wParam;
            uint filesCounter = Shell32.DragQueryFile(hDrop, 0xFFFFFFFF, null, 0);
            for (uint i = 0; i < filesCounter; ++i)
            {
                // Don't forget about \0 at the end
                uint filenameChars = Shell32.DragQueryFile(hDrop, i, null, 0) + 1;
                var builder = new StringBuilder((int)filenameChars);

                Shell32.DragQueryFile(hDrop, i, builder, filenameChars);

                OnFileDrop(builder.ToString());
            }

            Shell32.DragFinish(hDrop);
        }

        private IntPtr WindowProcedure(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            var result = IntPtr.Zero;

            switch (message)
            {
                case WindowMessage.Activate:
                    HandleActivate(handle, message, wParam, lParam);
                    break;

                case WindowMessage.EnterMenuLoop:
                case WindowMessage.EnterSizeMove:
                    HandleEnterModalLoop(handle, message, wParam, lParam);
                    break;

                case WindowMessage.ExitMenuLoop:
                case WindowMessage.ExitSizeMove:
                    HandleExitModalLoop(handle, message, wParam, lParam);
                    break;

                case WindowMessage.EraseBackground:
                    // This is triggered only when the client area changes.
                    // As such it does not affect steady-state performance.
                    break;

                case WindowMessage.WindowPosChanged:
                    HandleWindowPositionChanged(handle, message, wParam, lParam);
                    break;

                case WindowMessage.StyleChanged:
                    HandleStyleChanged(handle, message, wParam, lParam);
                    break;

                case WindowMessage.Size:
                    HandleSize(handle, message, wParam, lParam);
                    break;

                case WindowMessage.SetCursor:
                    result = HandleSetCursor(handle, message, wParam, lParam);
                    break;

                case WindowMessage.CaptureChanged:
                    HandleCaptureChanged(handle, message, wParam, lParam);
                    break;

                case WindowMessage.Char:
                    HandleChar(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MouseMove:
                    HandleMouseMove(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MouseLeave:
                    HandleMouseLeave(handle, message, wParam, lParam);
                    break;

                case WindowMessage.MouseWheel:
                    HandleMouseWheel(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.MouseHWheel:
                    HandleMouseHWheel(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.LButtonDown:
                    HandleLButtonDown(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.MButtonDown:
                    HandleMButtonDown(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.RButtonDown:
                    HandleRButtonDown(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.XButtonDown:
                    HandleXButtonDown(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.LButtonUp:
                    HandleLButtonUp(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.MButtonUp:
                    HandleMButtonUp(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.RButtonUp:
                    HandleRButtonUp(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.XButtonUp:
                    HandleXButtonUp(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                // Keyboard events:
                case WindowMessage.KeyDown:
                case WindowMessage.KeyUp:
                case WindowMessage.SystemKeyDown:
                case WindowMessage.SystemKeyUp:
                    HandleKeyboard(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.SystemChar:
                    return IntPtr.Zero;

                case WindowMessage.KillFocus:
                    HandleKillFocus(handle, message, wParam, lParam);
                    break;

                case WindowMessage.DropFiles:
                    HandleDropFiles(handle, message, wParam, lParam);
                    break;

                case WindowMessage.Create:
                    HandleCreate(handle, message, wParam, lParam);
                    break;

                case WindowMessage.Close:
                    HandleClose(handle, message, wParam, lParam);
                    return IntPtr.Zero;

                case WindowMessage.Destroy:
                    HandleDestroy(handle, message, wParam, lParam);
                    break;
            }

            if (result != IntPtr.Zero)
                return result;

            return User32.Window.DefWindowProc(handle, message, wParam, lParam);
        }

        private void SetCapture()
        {
            if (mouse_capture_count == 0)
            {
                User32.Mouse.SetCapture(window.Handle);
            }

            mouse_capture_count++;
        }

        private void ReleaseCapture()
        {
            mouse_capture_count--;
            if (mouse_capture_count == 0)
            {
                User32.Mouse.ReleaseCapture();
                // Renable mouse tracking
                EnableMouseTracking();
            }
        }

        private void EnableMouseTracking()
        {
            var me = new TrackMouseEvent
            {
                Size = TrackMouseEvent.SizeInBytes,
                TrackWindowHandle = window.Handle,
                Flags = TrackMouseEvents.Leave
            };
            

            if (!User32.Mouse.TrackMouseEvent(ref me))
            {
                Debug.Print("[Warning] Failed to enable mouse tracking, error: {0}.",
                    Marshal.GetLastWin32Error());
            }
        }

        private void StartTimer(IntPtr handle)
        {
            if (timer_handle == UIntPtr.Zero)
            {
                timer_handle = User32.Timer.SetTimer(handle, new UIntPtr(1), ModalLoopTimerPeriod, null);
                if (timer_handle == UIntPtr.Zero)
                {
                    Debug.Print("[Warning] Failed to set modal loop timer callback ({0}:{1}->{2}).",
                        GetType().Name, handle, Marshal.GetLastWin32Error());
                }
            }
        }

        private void StopTimer(IntPtr handle)
        {
            if (timer_handle != UIntPtr.Zero)
            {
                if (!User32.Timer.KillTimer(handle, timer_handle))
                {
                    Debug.Print("[Warning] Failed to kill modal loop timer callback ({0}:{1}->{2}).",
                        GetType().Name, handle, Marshal.GetLastWin32Error());
                }

                timer_handle = UIntPtr.Zero;
            }
        }

        private IntPtr CreateWindow(
            int x,
            int y,
            int width,
            int height,
            string title,
            GameWindowFlags options,
            DisplayDevice device,
            IntPtr parentHandle
        )
        {
            // Use win32 to create the native window.
            // Keep in mind that some construction code runs in the WM_CREATE message handler.

            // The style of a parent window is different than that of a child window.
            // Note: the child window should always be visible, even if the parent isn't.
            WindowStyles style = 0;
            ExtendedWindowStyles ex_style = 0;
            if (parentHandle == IntPtr.Zero)
            {
                style |= WindowStyles.OverlappedWindow | WindowStyles.ClipChildren;
                ex_style = ParentStyleEx;
            }
            else
            {
                style |= WindowStyles.Visible | WindowStyles.Child | WindowStyles.ClipSiblings;
                ex_style = ChildStyleEx;
            }

            // Find out the final window rectangle, after the WM has added its chrome (titlebar, sidebars etc).
            var rect = new Rect
            {
                Left = x,
                Top = y,
                Right = x + width,
                Bottom = y + height
            };
            
            User32.Window.AdjustWindowRectEx(ref rect, style, false, ex_style);

            // Create the window class that we will use for this window.
            // The current approach is to register a new class for each top-level WinGLWindow we create.
            if (!class_registered)
            {
                var wc = new ExtendedWindowClass
                {
                    Size = ExtendedWindowClass.SizeInBytes,
                    // Setting the background here ensures the window doesn't flash gray/white until the first frame is rendered.
                    Background = Gdi32.GetStockObject(GetStockObjectType.BlackBrush),
                    Style = DefaultClassStyle,
                    Instance = Instance,
                    WindowProc = WindowProcedureDelegate,
                    ClassName = ClassName,
                    Icon = Icon?.Handle ?? IntPtr.Zero,
                    // Todo: the following line appears to resize one of the 'large' icons, rather than using a small icon directly (multi-icon files). Investigate!
                    IconSmall = Icon != null ? new Icon(Icon, 16, 16).Handle : IntPtr.Zero,
                    Cursor = User32.Cursor.LoadCursor(CursorName.Arrow),
                };
                
                ushort atom = User32.WindowClass.RegisterClassEx(ref wc);

                if (atom == 0)
                    throw new Win32Exception("Failed to register window class.");

                class_registered = true;
            }

            var handle = User32.Window.CreateWindowEx(
                ex_style,
                ClassName,
                title,
                style,
                rect.Left,
                rect.Top,
                rect.Width,
                rect.Height,
                parentHandle,
                IntPtr.Zero,
                Instance, 
                IntPtr.Zero
            );

            if (handle == IntPtr.Zero)
                throw new Win32Exception("Failed to create window.");

            return handle;
        }

        /// <summary>
        /// Starts the teardown sequence for the current window.
        /// </summary>
        private void DestroyWindow()
        {
            if (!Exists)
                return;

            Debug.Print("Destroying window: {0}", window);
            User32.Window.DestroyWindow(window.Handle);
            exists = false;
        }

        private void HideBorder()
        {
            suppress_resize++;
            WindowBorder = WindowBorder.Hidden;
            suppress_resize--;
        }

        private void RestoreBorder()
        {
            suppress_resize++;
            WindowBorder = deferred_window_border ?? previous_window_border ?? WindowBorder;
            suppress_resize--;
            deferred_window_border = previous_window_border = null;
        }

        private void ResetWindowState()
        {
            suppress_resize++;
            WindowState = WindowState.Normal;
            suppress_resize--;
        }

        private void GrabCursor()
        {
            var pos = PointToScreen(new System.Drawing.Point(ClientRectangle.X, ClientRectangle.Y));
            var rect = new Rect
            {
                Left = pos.X,
                Right = pos.X + ClientRectangle.Width,
                Top = pos.Y,
                Bottom = pos.Y + ClientRectangle.Height,
            };
            
            if (!User32.Cursor.ClipCursor(ref rect))
                Debug.WriteLine($"Failed to grab cursor. Error: {Marshal.GetLastWin32Error()}");
        }

        private void UngrabCursor()
        {
            if (!User32.Cursor.ClipCursor(IntPtr.Zero))
                Debug.WriteLine($"Failed to ungrab cursor. Error: {Marshal.GetLastWin32Error()}");
        }


        public override void Close()
        {
            User32.Message.PostMessage(window.Handle, WindowMessage.Close, IntPtr.Zero, IntPtr.Zero);
        }

        public override System.Drawing.Point PointToClient(System.Drawing.Point point)
        {
            NT.Native.Point p = point;
            if (!User32.Window.ScreenToClient(window.Handle, ref p))
                throw new InvalidOperationException($"Could not convert point {p} from screen to client coordinates. Windows error: {Marshal.GetLastWin32Error()}");

            return p;
        }

        public override System.Drawing.Point PointToScreen(System.Drawing.Point point)
        {
            NT.Native.Point p = point;
            if (!User32.Window.ClientToScreen(window.Handle, ref p))
                throw new InvalidOperationException($"Could not convert point {p} from screen to client coordinates. Windows error: {Marshal.GetLastWin32Error()}");

            return p;
        }

        public override void ProcessEvents()
        {
            base.ProcessEvents();
            while (User32.Message.PeekMessage(out Msg msg, IntPtr.Zero, 0, 0, PeekMessageActions.Remove))
            {
                User32.Message.TranslateMessage(ref msg);
                User32.Message.DispatchMessage(ref msg);
            }
        }

        protected override void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                if (calledManually)
                {
                    if (Cursor != MouseCursor.Default && cursor_handle != IntPtr.Zero)
                    {
                        User32.Icon.DestroyIcon(cursor_handle);
                        cursor_handle = IntPtr.Zero;
                    }

                    // Safe to clean managed resources
                    DestroyWindow();
                    Icon?.Dispose();
                }
                else
                {
                    Debug.Print($"[Warning] INativeWindow leaked ({this}). Did you forget to call INativeWindow.Dispose()?");
                }

                OnDisposed(EventArgs.Empty);
                disposed = true;
            }
        }

        private enum ScaleDirection
        {
            X,
            Y
        }
    }
}
