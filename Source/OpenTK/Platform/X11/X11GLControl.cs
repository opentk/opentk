#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using OpenTK.Graphics;

namespace OpenTK.Platform.X11
{
    class X11GLControl : IGLControl
    {
        GraphicsMode mode;
        Control control;
        IntPtr display;

        internal X11GLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;
            this.control = control;

            X11WindowInfo window = (X11WindowInfo)this.WindowInfo;

            XVisualInfo info = new XVisualInfo();
            info.visualid = mode.Index;
            int dummy;
            window.VisualInfo = (XVisualInfo)Marshal.PtrToStructure(
                Functions.XGetVisualInfo(window.Display, XVisualInfoMask.ID, ref info, out dummy), typeof(XVisualInfo));

            Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                .SetValue(null, window.VisualInfo.visual);
            xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                .SetValue(null, Functions.XCreateColormap(window.Display, window.RootWindow, window.VisualInfo.visual, 0));
        }

        #region --- IGLControl Members ---

        public GraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            return new GraphicsContext(mode, this.WindowInfo, major, minor, flags);
        }

        public bool IsIdle
        {
            get { return Functions.XPending(display) == 0; }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
                if (xplatui == null) throw new PlatformNotSupportedException(
                        "System.Windows.Forms.XplatUIX11 missing. Unsupported platform or Mono runtime version, aborting.");

                X11WindowInfo window = new X11WindowInfo();

                if (control.IsHandleCreated)
                    window.WindowHandle = control.Handle;
                
                display =
                window.Display = (IntPtr)xplatui.GetField("DisplayHandle",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                window.RootWindow = (IntPtr)xplatui.GetField("RootWindow",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                window.Screen = (int)xplatui.GetField("ScreenNo",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

                if (control.IsHandleCreated)
                    window.WindowHandle = control.Handle;

                return window;
            }
        }

        #endregion
    }
}
