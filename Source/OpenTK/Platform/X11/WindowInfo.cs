#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Describes a Windows.Form.Control, Windows.Forms.NativeWindow or OpenTK.GameWindow on the X11 platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WindowInfo : IWindowInfo
    {
        private IntPtr rootWindow, handle, topLevelWindow, display;
        private int screen;
        private WindowInfo parent;
        private XVisualInfo visinfo;

        public WindowInfo()
        {
            visinfo = new XVisualInfo();
        }

        public WindowInfo(Control control)
        {
            throw new NotImplementedException();
        }

        public WindowInfo(NativeWindow window)
        {
            throw new NotImplementedException();
        }

        public WindowInfo(GameWindow window)
        {
            throw new NotImplementedException();
        }

        public WindowInfo(WindowInfo info)
        {
            this.GetInfoFrom(info);
        }

        #region --- IWindowInfo Members ---

        public void GetInfoFrom(Control control)
        {
            if (control == null)
                throw new ArgumentException("GameWindow cannot be null.");
            
            throw new NotImplementedException();
        }

        public void GetInfoFrom(NativeWindow window)
        {
            if (window == null)
                throw new ArgumentException("GameWindow cannot be null.");

            throw new NotImplementedException();
        }

        public void GetInfoFrom(GameWindow window)
        {
            if (window == null)
                throw new ArgumentException("GameWindow cannot be null.");

            this.GetInfoFrom(window.WindowInfo as X11.WindowInfo);
        }

        public void GetInfoFrom(IWindowInfo info)
        {
            if (info == null)
                throw new ArgumentException("WindowInfo cannot be null");

            WindowInfo winfo = info as WindowInfo;

            this.Handle = info.Handle;
            this.Parent = info.Parent;

            this.RootWindow = winfo.RootWindow;
            this.TopLevelWindow = winfo.TopLevelWindow;
            this.Display = winfo.Display;
            this.Screen = winfo.Screen;
            this.VisualInfo = winfo.VisualInfo;
        }

        public IntPtr Handle { get { return handle; } internal set { handle = value; } }
        public IWindowInfo Parent { get { return parent; } internal set { parent = value as WindowInfo; } }

        #endregion

        public IntPtr RootWindow { get { return rootWindow; } internal set { rootWindow = value; } }
        public IntPtr TopLevelWindow { get { return topLevelWindow; } internal set { topLevelWindow = value; } }
        public IntPtr Display { get { return display; } internal set { display = value; } }
        public int Screen { get { return screen; } internal set { screen = value; } }
        public XVisualInfo VisualInfo { get { return visinfo; } internal set { visinfo = value; } }

        public override string ToString()
        {
            return String.Format("X11.WindowInfo: Display {0}, Screen {1}, Handle {2}, Parent: ({3})",
                this.Display, this.Screen, this.Handle, this.Parent != null ? this.Parent.ToString() : "null");
        }
    }
}
