using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Describes an X11 window.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal class WindowInfo : IWindowInfo
    {
        internal WindowInfo() { }
        internal WindowInfo(WindowInfo parent)
        {
            this.TopLevelWindow = parent.TopLevelWindow;
            this.Screen = parent.Screen;
            this.Display = parent.Display;
            this.RootWindow = parent.RootWindow;
            this.Handle = parent.Handle;
        }

        private IntPtr rootWindow, handle, topLevelWindow, display;
        private int screen;
        private WindowInfo parent;

        internal IntPtr RootWindow { get { return rootWindow; } set { rootWindow = value; } }
        internal IntPtr TopLevelWindow { get { return topLevelWindow; } set { topLevelWindow = value; } }
        internal IntPtr Display { get { return display; } set { display = value; } }
        internal int Screen { get { return screen; } set { screen = value; } }

        public IntPtr Handle { get { return handle; } internal set { handle = value; } }
        public IWindowInfo Parent { get { return parent; } internal set { parent = value as WindowInfo; } }

        public override string ToString()
        {
            return String.Format("X11.WindowInfo: Display {0}, Screen {1}, Handle {2}, Parent {3}",
                this.Display, this.Screen, this.Handle, this.Parent != null ? this.Parent.ToString() : "null");
        }
    }
}
