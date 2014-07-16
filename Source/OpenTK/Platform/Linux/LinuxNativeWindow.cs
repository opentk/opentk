#region License
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
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using OpenTK.Graphics;
using OpenTK.Platform.Egl;

namespace OpenTK.Platform.Linux
{
    using Egl = OpenTK.Platform.Egl.Egl;

    class LinuxNativeWindow : NativeWindowBase
    {
        LinuxWindowInfo window;
        string title;
        Icon icon;
        bool exists;
        Rectangle bounds;
        Size client_size;

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

            window = new LinuxWindowInfo(display, fd, display_device.Id as LinuxDisplay);

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

            SurfaceFormat format = GetSurfaceFormat(display, mode);
            SurfaceFlags usage = SurfaceFlags.Rendering | SurfaceFlags.Scanout;
            if (!Gbm.IsFormatSupported(gbm, format, usage))
            {
                Debug.Print("[KMS] Failed to find suitable surface format, using XRGB8888");
                format = SurfaceFormat.XRGB8888;
            }

            Debug.Print("[KMS] Creating GBM surface on {0:x} with {1}x{2} {3} [{4}]",
                gbm, width, height, format, usage);
            IntPtr gbm_surface =  Gbm.CreateSurface(gbm,
                    width, height, format, usage);
            if (gbm_surface == IntPtr.Zero)
            {
                throw new NotSupportedException("[KMS] Failed to create GBM surface for rendering");
            }

            window.Handle = gbm_surface;
                Debug.Print("[KMS] Created GBM surface {0:x}", window.Handle);

            window.CreateWindowSurface(mode.Index.Value);
            Debug.Print("[KMS] Created EGL surface {0:x}", window.Surface);

            // Todo: create mouse cursor
            exists = true;
        }

        SurfaceFormat GetSurfaceFormat(IntPtr display, GraphicsMode mode)
        {
            // Use EGL 1.4 EGL_NATIVE_VISUAL_ID to retrieve
            // the corresponding surface format. If that fails
            // fall back to a manual algorithm.
            int format;
            Egl.GetConfigAttrib(display, mode.Index.Value,
                Egl.NATIVE_VISUAL_ID, out format);
            if ((SurfaceFormat)format != 0)
                return (SurfaceFormat)format;

            Debug.Print("[KMS] Failed to retrieve EGL visual from GBM surface. Error: {0}",
                Egl.GetError());
            Debug.Print("[KMS] Falling back to hardcoded formats.");

            int r = mode.ColorFormat.Red;
            int g = mode.ColorFormat.Green;
            int b = mode.ColorFormat.Blue;
            int a = mode.ColorFormat.Alpha;

            if (mode.ColorFormat.IsIndexed)
                return SurfaceFormat.C8;
            if (r == 3 && g == 3 && b == 2 && a == 0)
                return SurfaceFormat.RGB332;
            if (r == 5 && g == 6 && b == 5 && a == 0)
                return SurfaceFormat.RGB565;
            if (r == 5 && g == 6 && b == 5 && a == 0)
                return SurfaceFormat.RGB565;
            if (r == 8 && g == 8 && b == 8 && a == 0)
                return SurfaceFormat.RGB888;
            if (r == 5 && g == 5 && b == 5 && a == 1)
                return SurfaceFormat.RGBA5551;
            if (r == 10 && g == 10 && b == 10 && a == 2)
                return SurfaceFormat.RGBA1010102;
            if (r == 4 && g == 4 && b == 4 && a == 4)
                return SurfaceFormat.RGBA4444;
            if (r == 8 && g == 8 && b == 8 && a == 8)
                return SurfaceFormat.RGBA8888;

            return SurfaceFormat.RGBA8888;
        }

        #region INativeWindow Members

        public override void ProcessEvents()
        {
            base.ProcessEvents();
        }

        public override void Close()
        {
            exists = false;
        }

        public override Point PointToClient(Point point)
        {
            // Todo
            return point;
        }

        public override Point PointToScreen(Point point)
        {
            // Todo
            return point;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                window.Dispose();
                Gbm.DestroySurface(window.Handle);
            }
        }

        public override Icon Icon
        {
            get
            {
                return icon;
            }
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
            get
            {
                return title;
            }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnTitleChanged(EventArgs.Empty);
                }
            }
        }

        public override bool Focused
        {
            get
            {
                return true;
            }
        }

        public override bool Visible
        {
            get
            {
                return true;
            }
            set
            {
            }
        }

        public override bool Exists
        {
            get
            {
                return exists;
            }
        }

        public override IWindowInfo WindowInfo
        {
            get
            {
                return window;
            }
        }

        public override WindowState WindowState
        {
            get
            {
                return WindowState.Fullscreen;
            }
            set
            {
            }
        }

        public override WindowBorder WindowBorder
        {
            get
            {
                return WindowBorder.Hidden;
            }
            set
            {
            }
        }

        public override Rectangle Bounds
        {
            get
            {
                return bounds;
            }
            set
            {
            }
        }

        public override Size ClientSize
        {
            get
            {
                return client_size;
            }
            set
            {
            }
        }

        public override bool CursorVisible
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        public override MouseCursor Cursor
        {
            get
            {
                return MouseCursor.Empty;
            }
            set
            {
            }
        }

        #endregion
    }
}

