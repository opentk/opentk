using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    /// <summary>Describes an X11 window.</summary>
    public sealed class X11WindowInfo : IWindowInfo
    {
        IntPtr handle, rootWindow, display;
        X11WindowInfo parent;
        int screen;
        XVisualInfo visualInfo;
        EventMask eventMask;

        #region --- Constructors ---

        #region X11WindowInfo()

        /// <summary>Constructs a new X11WindowInfo class.</summary>
        public X11WindowInfo() { }

        #endregion

        #region X11WindowInfo(IntPtr handle, X11WindowInfo parent)

        /// <summary>
        /// Constructs a new X11WindowInfo class from the specified window handle and parent.
        /// </summary>
        /// <param name="handle">The handle of the window.</param>
        /// <param name="parent">The parent of the window.</param>
        public X11WindowInfo(IntPtr handle, X11WindowInfo parent)
        {
            this.handle = handle;
            this.parent = parent;
            if (parent != null)
            {
                this.rootWindow = parent.rootWindow;
                this.display = parent.display;
                this.screen = parent.screen;
                this.visualInfo = parent.visualInfo;
            }
        }

        #endregion

        #endregion

        #region --- Public Methods ---

        /// <summary>Gets or sets the handle of the window.</summary>
        public IntPtr WindowHandle { get { return handle; } set { handle = value; } }
        /// <summary>Gets or sets the parent of the window.</summary>
        public X11WindowInfo Parent { get { return parent; } set { parent = value; } }
        /// <summary>Gets or sets the X11 root window.</summary>
        public IntPtr RootWindow { get { return rootWindow; } set { rootWindow = value; } }
        /// <summary>Gets or sets the connection to the X11 display.</summary>
        public IntPtr Display { get { return display; } set { display = value; } }
        /// <summary>Gets or sets the X11 screen.</summary>
        public int Screen { get { return screen; } set { screen = value; } }
                        //{ get { return Functions.XRRRootToScreen(display, rootWindow); } set { } }
        //public int Screen { get { return screen; } set { screen = value; } }
        /// <summary>Gets or sets the X11 VisualInfo.</summary>
        public XVisualInfo VisualInfo { get { return visualInfo; } set { visualInfo = value; } }
        /// <summary>Gets or sets the X11 EventMask.</summary>
        public EventMask EventMask { get { return eventMask; } set { eventMask = value; } }
        //public IntPtr TopLevelWindow { get { return topLevelWindow; } set { topLevelWindow = value; } }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
        }

        #endregion

        #region --- Overrides ---

        #region public override string ToString()

        /// <summary>Returns a System.String that represents the current window.</summary>
        /// <returns>A System.String that represents the current window.</returns>
        public override string ToString()
        {
            return String.Format("X11.WindowInfo: Display {0}, Screen {1}, Handle {2}, Parent: ({3})",
                this.Display, this.Screen, this.WindowHandle, this.Parent != null ? this.Parent.ToString() : "null");
        }

        #endregion

        /// <summary>Checks if <c>this</c> and <c>obj</c> reference the same win32 window.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>True if <c>this</c> and <c>obj</c> reference the same win32 window; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            X11WindowInfo info = (X11WindowInfo)obj;

            if (info == null) return false;
            // TODO: Assumes windows will have unique handles per X11 display.
            return object.Equals(display, info.display) &&
                   handle.Equals(info.handle);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A hash code for the current <c>X11WindowInfo</c>.</returns>
        public override int GetHashCode()
        {
            return handle.GetHashCode() ^ display.GetHashCode();
        }

        #endregion

    }
}
