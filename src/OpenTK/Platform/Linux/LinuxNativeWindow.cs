//
// LinuxNativeWindow.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Diagnostics;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Mathematics;
using OpenTK.Platform.Egl;
#if !MINIMAL
using System.Drawing;

#endif

namespace OpenTK.Platform.Linux
{
    internal class LinuxNativeWindow : NativeWindowBase
    {
        private readonly Rectangle bounds;
        private readonly Size client_size;
        private readonly BufferObject cursor_default;
        private readonly BufferObject cursor_empty;
        private readonly LinuxWindowInfo window;

        private MouseCursor cursor_current;
        private BufferObject cursor_custom;
        private bool exists;
        private Icon icon;
        private bool is_cursor_visible = true;
        private bool is_focused;

        private KeyboardState previous_keyboard;
        private MouseState previous_mouse;
        private string title;

        public LinuxNativeWindow(IntPtr display, IntPtr gbm, int fd,
            int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options,
            DisplayDevice display_device)
        {
            Debug.Print("[KMS] Creating window on display {0:x}", display);

            Title = title;

            display_device = display_device ?? DisplayDevice.Default;
            if (display_device == null)
            {
                throw new NotSupportedException("[KMS] Driver does not currently support headless systems");
            }

            window = new LinuxWindowInfo(display, fd, gbm, display_device.Id as LinuxDisplay);

            // Note: we only support fullscreen windows on KMS.
            // We implicitly override the requested width and height
            // by the width and height of the DisplayDevice, if any.
            width = display_device.Width;
            height = display_device.Height;
            bounds = new Rectangle(0, 0, width, height);
            client_size = bounds.Size;

            if (!mode.Index.HasValue)
            {
                mode = new EglGraphicsMode().SelectGraphicsMode(window, mode, 0);
            }

            Debug.Print("[KMS] Selected EGL mode {0}", mode);

            var format = GetSurfaceFormat(display, mode);
            var usage = SurfaceFlags.Rendering | SurfaceFlags.Scanout;
            if (!Gbm.IsFormatSupported(gbm, format, usage))
            {
                Debug.Print("[KMS] Failed to find suitable surface format, using XRGB8888");
                format = SurfaceFormat.XRGB8888;
            }

            Debug.Print("[KMS] Creating GBM surface on {0:x} with {1}x{2} {3} [{4}]",
                gbm, width, height, format, usage);
            var gbm_surface = Gbm.CreateSurface(gbm,
                width, height, format, usage);
            if (gbm_surface == IntPtr.Zero)
            {
                throw new NotSupportedException("[KMS] Failed to create GBM surface for rendering");
            }

            window.Handle = gbm_surface;
            Debug.Print("[KMS] Created GBM surface {0:x}", window.Handle);

            window.CreateWindowSurface(mode.Index.Value);
            Debug.Print("[KMS] Created EGL surface {0:x}", window.Surface);

            cursor_default = CreateCursor(gbm, Cursors.Default);
            cursor_empty = CreateCursor(gbm, Cursors.Empty);
            Cursor = MouseCursor.Default;
            exists = true;
        }

        public override Icon Icon
        {
            get => icon;
            set
            {
                if (icon != value)
                {
                    icon = value;
                    OnIconChanged(EventArgs.Empty);
                }
            }
        }

        public override string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    OnTitleChanged(EventArgs.Empty);
                }
            }
        }

        public override bool Focused => is_focused;

        public override bool Visible
        {
            get => true;
            set { }
        }

        public override bool Exists => exists;

        public override IWindowInfo WindowInfo => window;

        public override WindowState WindowState
        {
            get => WindowState.Fullscreen;
            set { }
        }

        public override WindowBorder WindowBorder
        {
            get => WindowBorder.Hidden;
            set { }
        }

        public override Rectangle Bounds
        {
            get => bounds;
            set { }
        }

        public override Size ClientSize
        {
            get => client_size;
            set { }
        }

        public override bool CursorVisible
        {
            get => is_cursor_visible;
            set
            {
                if (value && !is_cursor_visible)
                {
                    SetCursor(cursor_current);
                }
                else if (!value && is_cursor_visible)
                {
                    SetCursor(MouseCursor.Empty);
                }

                is_cursor_visible = value;
            }
        }

        public override MouseCursor Cursor
        {
            get => cursor_current;
            set
            {
                if (cursor_current != value)
                {
                    if (cursor_custom != BufferObject.Zero)
                    {
                        cursor_custom.Dispose();
                    }

                    if (CursorVisible)
                    {
                        SetCursor(value);
                    }

                    cursor_current = value;
                }
            }
        }

        private static BufferObject CreateCursor(IntPtr gbm, MouseCursor cursor)
        {
            if (cursor.Width > 64 || cursor.Height > 64)
            {
                Debug.Print("[KMS] Cursor size {0}x{1} unsupported. Maximum is 64x64.",
                    cursor.Width, cursor.Height);
                return default(BufferObject);
            }

            var width = 64;
            var height = 64;
            var format = SurfaceFormat.ARGB8888;
            var usage = SurfaceFlags.Cursor64x64 | SurfaceFlags.Write;

            Debug.Print("[KMS] Gbm.CreateBuffer({0:X}, {1}, {2}, {3}, {4}).",
                gbm, width, height, format, usage);

            var bo = Gbm.CreateBuffer(
                gbm, width, height, format, usage);

            if (bo == BufferObject.Zero)
            {
                Debug.Print("[KMS] Failed to create buffer.");
                return bo;
            }

            // Copy cursor.Data into a new buffer of the correct size
            var cursor_data = new byte[width * height * 4];
            for (var y = 0; y < cursor.Height; y++)
            {
                var dst_offset = y * width * 4;
                var src_offset = y * cursor.Width * 4;
                var src_length = cursor.Width * 4;
                Array.Copy(
                    cursor.Data, src_offset,
                    cursor_data, dst_offset,
                    src_length);
            }

            bo.Write(cursor_data);

            return bo;
        }

        private void SetCursor(MouseCursor cursor)
        {
            var bo = default(BufferObject);
            if (cursor == MouseCursor.Default)
            {
                bo = cursor_default;
            }
            else if (cursor == MouseCursor.Empty)
            {
                bo = cursor_empty;
            }
            else
            {
                if (cursor_custom != BufferObject.Zero)
                {
                    cursor_custom.Dispose();
                }

                cursor_custom = CreateCursor(window.BufferManager, cursor);
                bo = cursor_custom;
            }

            // If we failed to create a proper cursor, try falling back
            // to the empty cursor. We do not want to crash here!
            if (bo == BufferObject.Zero)
            {
                bo = cursor_empty;
            }

            if (bo != BufferObject.Zero)
            {
                Drm.SetCursor(window.FD, window.DisplayDevice.Id,
                    bo.Handle, bo.Width, bo.Height, cursor.X, cursor.Y);
            }
        }

        private static SurfaceFormat GetSurfaceFormat(IntPtr display, GraphicsMode mode)
        {
            // Use EGL 1.4 EGL_NATIVE_VISUAL_ID to retrieve
            // the corresponding surface format. If that fails
            // fall back to a manual algorithm.
            int format;
            Egl.Egl.GetConfigAttrib(display, mode.Index.Value,
                Egl.Egl.NATIVE_VISUAL_ID, out format);
            if ((SurfaceFormat)format != 0)
            {
                return (SurfaceFormat)format;
            }

            Debug.Print("[KMS] Failed to retrieve EGL visual from GBM surface. Error: {0}",
                Egl.Egl.GetError());
            Debug.Print("[KMS] Falling back to hardcoded formats.");

            var r = mode.ColorFormat.Red;
            var g = mode.ColorFormat.Green;
            var b = mode.ColorFormat.Blue;
            var a = mode.ColorFormat.Alpha;

            if (mode.ColorFormat.IsIndexed)
            {
                return SurfaceFormat.C8;
            }

            if (r == 3 && g == 3 && b == 2 && a == 0)
            {
                return SurfaceFormat.RGB332;
            }

            if (r == 5 && g == 6 && b == 5 && a == 0)
            {
                return SurfaceFormat.RGB565;
            }

            if (r == 5 && g == 6 && b == 5 && a == 0)
            {
                return SurfaceFormat.RGB565;
            }

            if (r == 8 && g == 8 && b == 8 && a == 0)
            {
                return SurfaceFormat.RGB888;
            }

            if (r == 5 && g == 5 && b == 5 && a == 1)
            {
                return SurfaceFormat.RGBA5551;
            }

            if (r == 10 && g == 10 && b == 10 && a == 2)
            {
                return SurfaceFormat.RGBA1010102;
            }

            if (r == 4 && g == 4 && b == 4 && a == 4)
            {
                return SurfaceFormat.RGBA4444;
            }

            if (r == 8 && g == 8 && b == 8 && a == 8)
            {
                return SurfaceFormat.RGBA8888;
            }

            return SurfaceFormat.RGBA8888;
        }

        private KeyboardState ProcessKeyboard(KeyboardState keyboard)
        {
            for (Key i = 0; i < Key.LastKey; i++)
            {
                if (keyboard[i])
                {
                    OnKeyDown(i, previous_keyboard[i]);
                    // Todo: implement libxkb-common binding for text input
                }

                if (!keyboard[i] && previous_keyboard[i])
                {
                    OnKeyUp(i);
                }
            }

            return keyboard;
        }

        private MouseState ProcessMouse(MouseState mouse)
        {
            // Handle mouse buttons
            for (MouseButton i = 0; i < MouseButton.LastButton; i++)
            {
                if (mouse[i] && !previous_mouse[i])
                {
                    OnMouseDown(i);
                }

                if (!mouse[i] && previous_mouse[i])
                {
                    OnMouseUp(i);
                }
            }

            // Handle mouse movement
            {
                var x = mouse.X;
                var y = mouse.Y;

                // Make sure the mouse cannot leave the GameWindow when captured
                if (!CursorVisible)
                {
                    x = MathHelper.Clamp(mouse.X, Bounds.Left, Bounds.Right - 1);
                    y = MathHelper.Clamp(mouse.Y, Bounds.Top, Bounds.Bottom - 1);
                    if (x != mouse.X || y != mouse.Y)
                    {
                        Mouse.SetPosition(x, y);
                    }
                }

                if (x != previous_mouse.X || y != previous_mouse.Y)
                {
                    OnMouseMove(x, y);
                }
            }

            // Handle mouse scroll
            if (mouse.Scroll != previous_mouse.Scroll)
            {
                var dx = mouse.Scroll.X - previous_mouse.Scroll.X;
                var dy = mouse.Scroll.Y - previous_mouse.Scroll.Y;
                OnMouseWheel(dx, dy);
            }

            // Handle mouse focus
            // Note: focus follows mouse. Literally.
            var cursor_in = Bounds.Contains(new Point(mouse.X, mouse.Y));
            if (!cursor_in && Focused)
            {
                OnMouseLeave(EventArgs.Empty);
                SetFocus(false);
            }
            else if (cursor_in && !Focused)
            {
                OnMouseEnter(EventArgs.Empty);
                SetFocus(true);
            }

            return mouse;
        }

        private void SetFocus(bool focus)
        {
            if (is_focused != focus)
            {
                is_focused = focus;
                OnFocusedChanged(EventArgs.Empty);
            }
        }

        public override void ProcessEvents()
        {
            // Note: there is no event-based keyboard/mouse input available.
            // We will fake that by polling OpenTK.Input.
            previous_keyboard = ProcessKeyboard(Keyboard.GetState());
            previous_mouse = ProcessMouse(Mouse.GetCursorState());

            base.ProcessEvents();
        }

        public override void Close()
        {
            exists = false;
        }

        public override Point PointToClient(Point point)
        {
            var client = Location;
            return new Point(point.X - client.X, point.Y - client.Y);
        }

        public override Point PointToScreen(Point point)
        {
            var client = Location;
            return new Point(point.X + client.X, point.Y + client.Y);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Debug.Print("[KMS] Destroying window {0}.", window.Handle);
                Drm.SetCursor(window.FD, window.DisplayDevice.Id, 0, 0, 0, 0, 0);
                window.Dispose();
                Gbm.DestroySurface(window.Handle);
            }
            else
            {
                Debug.Print("[KMS] {0} leaked. Did you forget to call Dispose()?", GetType().FullName);
            }
        }
    }
}