#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Describes an X11 window.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    public class WindowInfo : IWindowInfo
    {
        public WindowInfo()
        {
            visinfo = new VisualInfo();
        }

        public WindowInfo(WindowInfo parent)
        {
            this.Handle = parent.Handle;
            this.TopLevelWindow = parent.TopLevelWindow;
            this.Screen = parent.Screen;
            this.Display = parent.Display;
            this.RootWindow = parent.RootWindow;
            this.VisualInfo = parent.VisualInfo;
            this.Parent = parent;
        }

        private IntPtr rootWindow, handle, topLevelWindow, display;
        private int screen;
        private WindowInfo parent;
        private VisualInfo visinfo;

        public IntPtr RootWindow { get { return rootWindow; } set { rootWindow = value; } }
        public IntPtr TopLevelWindow { get { return topLevelWindow; } set { topLevelWindow = value; } }
        public IntPtr Display { get { return display; } set { display = value; } }
        public int Screen { get { return screen; } set { screen = value; } }
        public VisualInfo VisualInfo { get { return visinfo; } set { visinfo = value; } }

        public IntPtr Handle { get { return handle; } set { handle = value; } }
        public IWindowInfo Parent { get { return parent; } set { parent = value as WindowInfo; } }

        public override string ToString()
        {
            return String.Format("X11.WindowInfo: Display {0}, Screen {1}, Handle {2}, Parent: ({3})",
                this.Display, this.Screen, this.Handle, this.Parent != null ? this.Parent.ToString() : "null");
        }
    }
}
