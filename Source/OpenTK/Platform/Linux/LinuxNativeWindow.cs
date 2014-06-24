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
using System.Drawing;
using OpenTK.Graphics;
using OpenTK.Platform.Egl;

namespace OpenTK.Platform.Linux
{
    using Egl = OpenTK.Platform.Egl.Egl;

    class LinuxNativeWindow : NativeWindowBase
    {
        LinuxWindowInfo window_info;
        string title;
        Icon icon;
        bool exists;
        Rectangle bounds;
        Size client_size;

        public LinuxNativeWindow(IntPtr display, GbmDevice device,
            int width, int height, string title, GraphicsMode mode, GameWindowFlags options,
            DisplayDevice display_device)
        {
            Title = title;
            bounds = new Rectangle(0, 0, width, height);
            client_size = bounds.Size;

            //window_info = new LinuxWindowInfo(
                //    Egl.CreateWindowSurface(

            exists = true;
        }

        #region INativeWindow Members

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
            // Todo
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
                return window_info;
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

