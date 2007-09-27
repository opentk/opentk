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
    public sealed class WindowInfo : IMutableWindowInfo
    {
        private IntPtr handle, topLevelWindow;
        private IntPtr rootWindow, display;
        private int screen;
        private X11.WindowInfo parent;
        private XVisualInfo visinfo;
        private static Type xplatui;
        private EventMask eventMask;

        public WindowInfo()
        {
            //visinfo = new XVisualInfo();
        }

        public WindowInfo(IWindowInfo info)
        {
            this.CopyInfoFrom(info);
        }

        public WindowInfo(Control control)
        {
            if (control == null)
                throw new ArgumentException("Control cannot be null.");

            this.CopyInfoFromXPlatUI();
            this.Handle = control.Handle;
            this.Parent = control.Parent != null ? new WindowInfo(control.Parent) : this.Parent;
            this.TopLevelWindow = control.TopLevelControl != null ? control.TopLevelControl.Handle : IntPtr.Zero;
        }

        public WindowInfo(NativeWindow window)
        {
            if (window == null)
                throw new ArgumentException("NativeWindow cannot be null.");

            this.CopyInfoFromXPlatUI();
            this.Handle = window.Handle;
            this.Parent = null;
            this.TopLevelWindow = IntPtr.Zero;
        }

        public WindowInfo(GameWindow window)
        {
            if (window == null)
                throw new ArgumentException("GameWindow cannot be null.");

            this.CopyInfoFrom(window.WindowInfo);
        }

        #region --- IWindowInfo Members ---

        public IntPtr Handle { get { return handle; } internal set { handle = value; } }
        public IWindowInfo Parent { get { return parent; } internal set { parent = value as WindowInfo; } }

        public IWindowInfo GetInfoFrom(Control control)
        {
            if (control == null)
                throw new ArgumentException("Control cannot be null.");

            return new WindowInfo(control);
        }

        public IWindowInfo GetInfoFrom(NativeWindow window)
        {
            if (window == null)
                throw new ArgumentException("NativeWindow cannot be null.");

            return new WindowInfo(window);
        }

        public IWindowInfo GetInfoFrom(GameWindow window)
        {
            if (window == null)
                throw new ArgumentException("GameWindow cannot be null.");

            return this.GetInfoFrom(window.WindowInfo);
        }

        public IWindowInfo GetInfoFrom(IWindowInfo info)
        {
            if (info == null)
                throw new ArgumentException("WindowInfo cannot be null");

            return info;
        }

        #endregion

        #region --- IMutableWindowInfo Members ---

        public void CopyInfoFrom(IWindowInfo info)
        {
            if (info == null)
                throw new ArgumentException("IWindowInfo info cannot be null.");
            this.Handle = info.Handle;
            this.Parent = info.Parent;

            // Work around Mono 1.2.4 gmcs bug (resolved in 1.2.5)
            // X11.WindowInfo winfo = info as X11.WindowInfo ?? (X11.WindowInfo)(info as Platform.WindowInfo);
            X11.WindowInfo winfo = info as X11.WindowInfo;
            if (winfo == null)
                winfo = (X11.WindowInfo)(info as Platform.WindowInfo);

            this.RootWindow = winfo.RootWindow;
            this.TopLevelWindow = winfo.TopLevelWindow;
            this.Display = winfo.Display;
            this.Screen = winfo.Screen;
            this.VisualInfo = winfo.VisualInfo;
            this.EventMask = winfo.EventMask;
        }

        #endregion

        public IntPtr RootWindow { get { return rootWindow; } internal set { rootWindow = value; } }
        public IntPtr TopLevelWindow { get { return topLevelWindow; } internal set { topLevelWindow = value; } }
        public IntPtr ParentHandle { get { return parent.Handle; } internal set { parent.Handle = value; } }
        public IntPtr Display { get { return display; } internal set { display = value; } }
        public int Screen { get { return screen; } internal set { screen = value; } }
        public XVisualInfo VisualInfo { get { return visinfo; } internal set { visinfo = value; } }
        public EventMask EventMask { get { return eventMask; } internal set { eventMask = value; } }
        

        public override string ToString()
        {
            return String.Format("X11.WindowInfo: Display {0}, Screen {1}, Handle {2}, Parent: ({3})",
                this.Display, this.Screen, this.Handle, this.Parent != null ? this.Parent.ToString() : "null");
        }

        private void CopyInfoFromXPlatUI()
        {
            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            if (xplatui == null)
                throw new ApplicationException("Could not get System.Windows.Forms.XplatUIX11 through reflection. Unsupported platform or Mono runtime version, aborting.");

            this.Display = (IntPtr)xplatui.GetField("DisplayHandle",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
            this.RootWindow = (IntPtr)xplatui.GetField("RootWindow",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
            this.Screen = (int)xplatui.GetField("ScreenNo",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

        }
    }
}
