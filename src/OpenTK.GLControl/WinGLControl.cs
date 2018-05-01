//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library, except where noted.
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
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    internal class WinGLControl : IGLControl
    {
        private readonly GraphicsMode mode;

        private MSG msg;

        public WinGLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;

            WindowInfo = Utilities.CreateWindowsWindowInfo(control.Handle);
        }

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            return new GraphicsContext(mode, WindowInfo, major, minor, flags);
        }

        public bool IsIdle => !PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0);

        public IWindowInfo WindowInfo { get; }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll")]
        private static extern bool PeekMessage(ref MSG msg, IntPtr hWnd, int messageFilterMin, int messageFilterMax,
            int flags);

        private struct MSG
        {
            public IntPtr HWnd;
            public uint Message;
            public IntPtr WParam;
            public IntPtr LParam;
            public uint Time;

            public POINT Point;
            //internal object RefObject;

            public override string ToString()
            {
                return
                    $"msg=0x{(int)Message:x} ({Message.ToString()}) hwnd=0x{HWnd.ToInt32():x} wparam=0x{WParam.ToInt32():x} lparam=0x{LParam.ToInt32():x} pt=0x{Point:x}";
            }
        }

        private struct POINT
        {
            public readonly int X;
            public readonly int Y;

            public POINT(int x, int y)
            {
                X = x;
                Y = y;
            }

            public Point ToPoint()
            {
                return new Point(X, Y);
            }

            public override string ToString()
            {
                return "Point {" + X + ", " + Y + ")";
            }
        }
    }
}
