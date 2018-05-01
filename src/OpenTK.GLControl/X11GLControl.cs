/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    internal class X11GLControl : IGLControl
    {
        private readonly IntPtr display;
        private readonly IntPtr rootWindow;

        // Use reflection to retrieve the necessary values from Mono's Windows.Forms implementation.
        private readonly Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

        private GraphicsMode mode;

        internal X11GLControl(GraphicsMode mode, Control control)
        {
            if (mode == null)
            {
                throw new ArgumentNullException(nameof(mode));
            }

            if (control == null)
            {
                throw new ArgumentNullException(nameof(control));
            }

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

            if (xplatui == null)
            {
                throw new PlatformNotSupportedException(
                    "System.Windows.Forms.XplatUIX11 missing. Unsupported platform or Mono runtime version, aborting.");
            }

            // get the required handles from the X11 API.
            display = (IntPtr)GetStaticFieldValue(xplatui, "DisplayHandle");
            rootWindow = (IntPtr)GetStaticFieldValue(xplatui, "RootWindow");
            var screen = (int)GetStaticFieldValue(xplatui, "ScreenNo");

            WindowInfo = Utilities.CreateX11WindowInfo(display, screen, control.Handle, rootWindow, IntPtr.Zero);
        }

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            var context = new GraphicsContext(mode, WindowInfo, major, minor, flags);
            mode = context.GraphicsMode;

            // get the XVisualInfo for this GraphicsMode
            var info = new XVisualInfo();
            info.VisualID = mode.Index.Value;
            int dummy;
            var infoPtr = XGetVisualInfo(display, 1 /* VisualInfoMask.ID */, ref info, out dummy);
            info = (XVisualInfo)Marshal.PtrToStructure(infoPtr, typeof(XVisualInfo));

            // set the X11 colormap.
            // Note: this only affects windows created in the future
            // (do we even need this here?)
            SetStaticFieldValue(xplatui, "CustomVisual", info.Visual);
            SetStaticFieldValue(xplatui, "CustomColormap", XCreateColormap(display, rootWindow, info.Visual, 0));

            return context;
        }

        public bool IsIdle => XPending(display) == 0;

        public IWindowInfo WindowInfo { get; }

        [DllImport("libX11")]
        private static extern IntPtr XCreateColormap(IntPtr display, IntPtr window, IntPtr visual, int alloc);

        [DllImport("libX11", EntryPoint = "XGetVisualInfo")]
        private static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr vinfo_mask, ref XVisualInfo template,
            out int nitems);

        private static IntPtr XGetVisualInfo(IntPtr display, int vinfo_mask, ref XVisualInfo template, out int nitems)
        {
            return XGetVisualInfoInternal(display, (IntPtr)vinfo_mask, ref template, out nitems);
        }

        [DllImport("libX11")]
        private static extern int XPending(IntPtr diplay);

        private static object GetStaticFieldValue(Type type, string fieldName)
        {
            return type.GetField(fieldName,
                BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
        }

        private static void SetStaticFieldValue(Type type, string fieldName, object value)
        {
            type.GetField(fieldName,
                BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, value);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct XVisualInfo
        {
            public readonly IntPtr Visual;
            public IntPtr VisualID;
            public readonly int Screen;
            public readonly int Depth;
            public readonly int Class;
            public readonly long RedMask;
            public readonly long GreenMask;
            public readonly long blueMask;
            public readonly int ColormapSize;
            public readonly int BitsPerRgb;

            public override string ToString()
            {
                return $"id ({VisualID}), screen ({Screen}), depth ({Depth}), class ({Class})";
            }
        }
    }
}