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
using OpenTK.Platform;

namespace OpenTK
{
    class X11GLControl : IGLControl
    {
        #region P/Invokes

        [DllImport("libX11")]
        static extern IntPtr XCreateColormap(IntPtr display, IntPtr window, IntPtr visual, int alloc);

        [DllImport("libX11", EntryPoint = "XGetVisualInfo")]
        static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr vinfo_mask, ref XVisualInfo template, out int nitems);

        static IntPtr XGetVisualInfo(IntPtr display, int vinfo_mask, ref XVisualInfo template, out int nitems)
        {
            return XGetVisualInfoInternal(display, (IntPtr)vinfo_mask, ref template, out nitems);
        }

        [DllImport("libX11")]
        extern static int XPending(IntPtr diplay);

        [StructLayout(LayoutKind.Sequential)]
        struct XVisualInfo
        {
            public IntPtr Visual;
            public IntPtr VisualID;
            public int Screen;
            public int Depth;
            public int Class;
            public long RedMask;
            public long GreenMask;
            public long blueMask;
            public int ColormapSize;
            public int BitsPerRgb;

            public override string ToString()
            {
                return String.Format("id ({0}), screen ({1}), depth ({2}), class ({3})",
                    VisualID, Screen, Depth, Class);
            }
        }

        #endregion

        #region Fields

        GraphicsMode mode;
        IWindowInfo window_info;
        IntPtr display;
        IntPtr rootWindow;

        // Use reflection to retrieve the necessary values from Mono's Windows.Forms implementation.
        Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

        #endregion

        internal X11GLControl(GraphicsMode mode, Control control)
        {
            if (mode == null)
                throw new ArgumentNullException("mode");
            if (control == null)
                throw new ArgumentNullException("control");

            // Note: the X11 window is created with a default XVisualInfo,
            // that is not necessarily compatible with the desired GraphicsMode.
            // This manifests in Nvidia binary drivers that fail in Glx.MakeCurrent()
            // when GraphicsMode has a 32bpp color format.
            // To work around this issue, we implicitly select a 24bpp color format when 32bpp is
            // requested - this appears to work correctly in all cases.
            // (The loss of the alpha channel does not matter, since WinForms do not support
            // translucent windows on X11 in the first place.)
            this.mode = new GraphicsMode(
                new ColorFormat(mode.ColorFormat.Red, mode.ColorFormat.Green, mode.ColorFormat.Blue, 0),
                mode.Depth,
                mode.Stencil,
                mode.Samples,
                mode.AccumulatorFormat,
                mode.Buffers,
                mode.Stereo);

            if (xplatui == null) throw new PlatformNotSupportedException(
                    "System.Windows.Forms.XplatUIX11 missing. Unsupported platform or Mono runtime version, aborting.");

            // get the required handles from the X11 API.
            display = (IntPtr)GetStaticFieldValue(xplatui, "DisplayHandle");
            rootWindow = (IntPtr)GetStaticFieldValue(xplatui, "RootWindow");
            int screen = (int)GetStaticFieldValue(xplatui, "ScreenNo");

            window_info = Utilities.CreateX11WindowInfo(display, screen, control.Handle, rootWindow, IntPtr.Zero);
        }

        #region IGLControl Members

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            GraphicsContext context =  new GraphicsContext(mode, this.WindowInfo, major, minor, flags);
            mode = context.GraphicsMode;

            // get the XVisualInfo for this GraphicsMode
            XVisualInfo info = new XVisualInfo();
            info.VisualID = mode.Index.Value;
            int dummy;
            IntPtr infoPtr = XGetVisualInfo(display, 1 /* VisualInfoMask.ID */, ref info, out dummy);
            info = (XVisualInfo)Marshal.PtrToStructure(infoPtr, typeof(XVisualInfo));

            // set the X11 colormap.
            // Note: this only affects windows created in the future
            // (do we even need this here?)
            SetStaticFieldValue(xplatui, "CustomVisual", info.Visual);
            SetStaticFieldValue(xplatui, "CustomColormap", XCreateColormap(display, rootWindow, info.Visual, 0));

            return context;
        }

        public bool IsIdle
        {
            get { return XPending(display) == 0; }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                return window_info;
            }
        }

        #endregion

        #region Private Members

        static object GetStaticFieldValue(Type type, string fieldName)
        {
            return type.GetField(fieldName,
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
        }
        
        static void SetStaticFieldValue(Type type, string fieldName, object value)
        {
            type.GetField(fieldName,
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).SetValue(null, value);
        }

        #endregion
    }
}
