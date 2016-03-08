// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    class WinGLControl : IGLControl
    {
        #region P/Invoke declarations

        #region Message

        struct MSG
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
                return String.Format("msg=0x{0:x} ({1}) hwnd=0x{2:x} wparam=0x{3:x} lparam=0x{4:x} pt=0x{5:x}", (int)Message, Message.ToString(), HWnd.ToInt32(), WParam.ToInt32(), LParam.ToInt32(), Point);
            }
        }

        #endregion

        #region Point

        struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public System.Drawing.Point ToPoint()
            {
                return new System.Drawing.Point(X, Y);
            }

            public override string ToString()
            {
                return "Point {" + X.ToString() + ", " + Y.ToString() + ")";
            }
        }

        #endregion

        #region PeekMessage

        [System.Security.SuppressUnmanagedCodeSecurity]
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        static extern bool PeekMessage(ref MSG msg, IntPtr hWnd, int messageFilterMin, int messageFilterMax, int flags);

        #endregion

        #region

        #endregion

        #endregion

        #region Fields

        MSG msg = new MSG();
        IWindowInfo window_info;
        GraphicsMode mode;

        #endregion

        #region Constructors

        public WinGLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;

            window_info = Utilities.CreateWindowsWindowInfo(control.Handle);
        }

        #endregion

        #region IGLControl Members

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            return new GraphicsContext(mode, window_info, major, minor, flags);
        }

        public bool IsIdle
        {
            get { return !PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0); }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                // This method forces the creation of the control. Beware of this side-effect!
                return window_info;
            }
        }

        #endregion
    }
}
