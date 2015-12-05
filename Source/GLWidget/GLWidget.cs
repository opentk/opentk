#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.ComponentModel;

using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK;

using Gtk;

namespace OpenTK
{
    [ToolboxItem(true)]
    public class GLWidget: DrawingArea, IDisposable
    {

        #region Static attrs.

        static int _GraphicsContextCount;
        static bool _SharedContextInitialized = false;

        #endregion

        #region Attributes

        IGraphicsContext _GraphicsContext;
        IWindowInfo _WindowInfo;
        GraphicsContextFlags _GraphicsContextFlags;
        bool _Initialized = false;

        #endregion

        #region Properties

        /// <summary>Use a single buffer versus a double buffer.</summary>
        [Browsable(true)]
        public bool SingleBuffer { get; set; }

        /// <summary>Color Buffer Bits-Per-Pixel</summary>
        public int ColorBPP { get; set; }

        /// <summary>Accumulation Buffer Bits-Per-Pixel</summary>
        public int AccumulatorBPP { get; set; }

        /// <summary>Depth Buffer Bits-Per-Pixel</summary>
        public int DepthBPP { get; set; }

        /// <summary>Stencil Buffer Bits-Per-Pixel</summary>
        public int StencilBPP { get; set; }

        /// <summary>Number of samples</summary>
        public int Samples { get; set; }

        /// <summary>Indicates if steropic renderering is enabled</summary>
        public bool Stereo { get; set; }

        /// <summary>The major version of OpenGL to use.</summary>
        public int GlVersionMajor { get; set; }

        /// <summary>The minor version of OpenGL to use.</summary>
        public int GlVersionMinor { get; set; }

        public GraphicsContextFlags GraphicsContextFlags
        {
            get
            { 
                return _GraphicsContextFlags; 
            }
            set
            { 
                _GraphicsContextFlags = value; 
            }
        }

        #endregion

        #region Construction/Destruction

        /// <summary>Constructs a new GLWidget.</summary>
        public GLWidget()
            : this(GraphicsMode.Default)
        { 
        }

        /// <summary>Constructs a new GLWidget using a given GraphicsMode</summary>
        public GLWidget(GraphicsMode graphicsMode)
            : this(graphicsMode, 1, 0, GraphicsContextFlags.Default)
        { 
        }

        /// <summary>Constructs a new GLWidget</summary>
        public GLWidget(GraphicsMode graphicsMode, int glVersionMajor, int glVersionMinor, GraphicsContextFlags graphicsContextFlags)
        {
            this.DoubleBuffered = false;

            SingleBuffer = graphicsMode.Buffers == 1;
            ColorBPP = graphicsMode.ColorFormat.BitsPerPixel;
            AccumulatorBPP = graphicsMode.AccumulatorFormat.BitsPerPixel;
            DepthBPP = graphicsMode.Depth;
            StencilBPP = graphicsMode.Stencil;
            Samples = graphicsMode.Samples;
            Stereo = graphicsMode.Stereo;

            GlVersionMajor = glVersionMajor;
            GlVersionMinor = glVersionMinor;
            GraphicsContextFlags = graphicsContextFlags;
        }

        ~GLWidget()
        { 
            Dispose(false); 
        }

#if GTK3
        public override void Destroy() {
#else
        public override void Dispose()
        {
#endif
            GC.SuppressFinalize(this);
            Dispose(true);
#if GTK3
            base.Destroy();
#else
            base.Dispose();
#endif
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _GraphicsContext.MakeCurrent(_WindowInfo);
                OnShuttingDown();
                if (GraphicsContext.ShareContexts && (Interlocked.Decrement(ref _GraphicsContextCount) == 0))
                {
                    OnGraphicsContextShuttingDown();
                    _SharedContextInitialized = false;
                }
                _GraphicsContext.Dispose();
            }
        }

        #endregion

        #region New Events

        // Called when the first GraphicsContext is created in the case of GraphicsContext.ShareContexts == True;
        public static event EventHandler GraphicsContextInitialized;

        static void OnGraphicsContextInitialized()
        {
            if (GraphicsContextInitialized != null)
                GraphicsContextInitialized(null, EventArgs.Empty); 
        }

        // Called when the first GraphicsContext is being destroyed in the case of GraphicsContext.ShareContexts == True;
        public static event EventHandler GraphicsContextShuttingDown;

        static void OnGraphicsContextShuttingDown()
        { 
            if (GraphicsContextShuttingDown != null)
                GraphicsContextShuttingDown(null, EventArgs.Empty); 
        }

        // Called when this GLWidget has a valid GraphicsContext
        public event EventHandler Initialized;

        protected virtual void OnInitialized()
        { 
            if (Initialized != null)
                Initialized(this, EventArgs.Empty); 
        }

        // Called when this GLWidget needs to render a frame
        public event EventHandler RenderFrame;

        protected virtual void OnRenderFrame()
        { 
            if (RenderFrame != null)
                RenderFrame(this, EventArgs.Empty); 
        }

        // Called when this GLWidget is being Disposed
        public event EventHandler ShuttingDown;

        protected virtual void OnShuttingDown()
        { 
            if (ShuttingDown != null)
                ShuttingDown(this, EventArgs.Empty); 
        }

        #endregion

        // Called when a widget is realized. (window handles and such are valid)
        // protected override void OnRealized() { base.OnRealized(); }

        // Called when the widget needs to be (fully or partially) redrawn.
#if GTK3
        protected override bool OnDrawn(Cairo.Context cr)
#else
        protected override bool OnExposeEvent(Gdk.EventExpose evnt)
#endif
        {
            if (!_Initialized)
                Initialize();
            else
                _GraphicsContext.MakeCurrent(_WindowInfo);

#if GTK3
            var result = base.OnDrawn(cr);
#else
            bool result = base.OnExposeEvent(evnt);
#endif

            OnRenderFrame();

#if !GTK3
            evnt.Window.Display.Sync(); // Add Sync call to fix resize rendering problem (Jay L. T. Cornwall) - How does this affect VSync?
#endif

            _GraphicsContext.SwapBuffers();

            return result;
        }

        // Called on Resize
        protected override bool OnConfigureEvent(Gdk.EventConfigure evnt)
        {
            bool result = base.OnConfigureEvent(evnt);

            if (_GraphicsContext != null)
                _GraphicsContext.Update(_WindowInfo);

            return result;
        }

        void Initialize()
        {
            _Initialized = true;

            // If this looks uninitialized...  initialize.
            if (ColorBPP == 0)
            {
                ColorBPP = 32;

                if (DepthBPP == 0)
                    DepthBPP = 16;
            }

            ColorFormat colorBufferColorFormat = new ColorFormat(ColorBPP);

            ColorFormat accumulationColorFormat = new ColorFormat(AccumulatorBPP);

            int buffers = 2;
            if (SingleBuffer)
                buffers--;

            GraphicsMode graphicsMode = new GraphicsMode(colorBufferColorFormat, DepthBPP, StencilBPP, Samples, accumulationColorFormat, buffers, Stereo);

            if (Configuration.RunningOnWindows)
                Console.WriteLine("OpenTK running on windows");
            else if (Configuration.RunningOnMacOS)
                Console.WriteLine("OpenTK running on OSX");
            else 
                Console.WriteLine("OpenTK running on X11");

            // IWindowInfo
            if (Configuration.RunningOnWindows)
                _WindowInfo = InitializeWindows();
            else if (Configuration.RunningOnMacOS)
                _WindowInfo = InitializeOSX();
            else
                _WindowInfo = InitializeX(graphicsMode);

            // GraphicsContext
            _GraphicsContext = new GraphicsContext(graphicsMode, _WindowInfo, GlVersionMajor, GlVersionMinor, _GraphicsContextFlags);
            _GraphicsContext.MakeCurrent(_WindowInfo);

            if (GraphicsContext.ShareContexts)
            {
                Interlocked.Increment(ref _GraphicsContextCount);

                if (!_SharedContextInitialized)
                {
                    _SharedContextInitialized = true;
                    ((IGraphicsContextInternal)_GraphicsContext).LoadAll();
                    OnGraphicsContextInitialized();
                }
            }
            else
            {
                ((IGraphicsContextInternal)_GraphicsContext).LoadAll();
                OnGraphicsContextInitialized();
            }

            OnInitialized();
        }

        #region Windows Specific initalization

        IWindowInfo InitializeWindows()
        {
            IntPtr windowHandle = gdk_win32_drawable_get_handle(GdkWindow.Handle);
            return Utilities.CreateWindowsWindowInfo(windowHandle);
        }

        [SuppressUnmanagedCodeSecurity, DllImport("libgdk-win32-2.0-0.dll")]
        public static extern IntPtr gdk_win32_drawable_get_handle(IntPtr d);

        #endregion

        #region OSX Specific Initialization

        IWindowInfo InitializeOSX()
        {
            IntPtr windowHandle = gdk_quartz_window_get_nswindow(this.GdkWindow.Handle);
            IntPtr viewHandle = gdk_quartz_window_get_nsview(this.GdkWindow.Handle);
            return Utilities.CreateMacOSWindowInfo(windowHandle, viewHandle);
        }

        [SuppressUnmanagedCodeSecurity, DllImport("libgdk-quartz-2.0.0.dylib")]
        static extern IntPtr gdk_quartz_window_get_nswindow(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("libgdk-quartz-2.0.0.dylib")]
        static extern IntPtr gdk_quartz_window_get_nsview(IntPtr handle);

        #endregion

        #region X Specific Initialization

#if GTK3
        const string UnixLibGdkName = "libgdk-3.so.0";
#else
        const string UnixLibGdkName = "libgdk-x11-2.0.so.0";
#endif
        const string UnixLibX11Name = "libX11.so.6";
        const string UnixLibGLName = "libGL.so.1";

        const int GLX_NONE = 0;
        const int GLX_USE_GL = 1;
        const int GLX_BUFFER_SIZE = 2;
        const int GLX_LEVEL = 3;
        const int GLX_RGBA = 4;
        const int GLX_DOUBLEBUFFER = 5;
        const int GLX_STEREO = 6;
        const int GLX_AUX_BUFFERS = 7;
        const int GLX_RED_SIZE = 8;
        const int GLX_GREEN_SIZE = 9;
        const int GLX_BLUE_SIZE = 10;
        const int GLX_ALPHA_SIZE = 11;
        const int GLX_DEPTH_SIZE = 12;
        const int GLX_STENCIL_SIZE = 13;
        const int GLX_ACCUM_RED_SIZE = 14;
        const int GLX_ACCUM_GREEN_SIZE = 15;
        const int GLX_ACCUM_BLUE_SIZE = 16;
        const int GLX_ACCUM_ALPHA_SIZE = 17;

        public enum XVisualClass
        {
            StaticGray = 0,
            GrayScale = 1,
            StaticColor = 2,
            PseudoColor = 3,
            TrueColor = 4,
            DirectColor = 5,
        }

        [StructLayout(LayoutKind.Sequential)]
        struct XVisualInfo
        {
            public IntPtr Visual;
            public IntPtr VisualID;
            public int Screen;
            public int Depth;
            public XVisualClass Class;
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

        [Flags]
        internal enum XVisualInfoMask
        {
            No = 0x0,
            ID = 0x1,
            Screen = 0x2,
            Depth = 0x4,
            Class = 0x8,
            Red = 0x10,
            Green = 0x20,
            Blue = 0x40,
            ColormapSize = 0x80,
            BitsPerRGB = 0x100,
            All = 0x1FF,
        }

        IWindowInfo InitializeX(GraphicsMode mode)
        {
            IntPtr display = gdk_x11_display_get_xdisplay(Display.Handle);
            int screen = Screen.Number;
#if GTK3
            IntPtr windowHandle = gdk_x11_window_get_xid(GdkWindow.Handle);
            IntPtr rootWindow = gdk_x11_window_get_xid(RootWindow.Handle);
#else
            IntPtr windowHandle = gdk_x11_drawable_get_xid(GdkWindow.Handle);
            IntPtr rootWindow = gdk_x11_drawable_get_xid(RootWindow.Handle);
#endif
            IWindowInfo retval;

            IntPtr visualInfo;
            if (mode.Index.HasValue)
            {
                XVisualInfo info = new XVisualInfo();
                info.VisualID = mode.Index.Value;
                int dummy;
                visualInfo = XGetVisualInfo(display, XVisualInfoMask.ID, ref info, out dummy);
            }
            else
                visualInfo = GetVisualInfo(display);

            retval = Utilities.CreateX11WindowInfo(display, screen, windowHandle, rootWindow, visualInfo);
            XFree(visualInfo);

            return retval;
        }

        static IntPtr XGetVisualInfo(IntPtr display, XVisualInfoMask vinfo_mask, ref XVisualInfo template, out int nitems)
        {
            return XGetVisualInfoInternal(display, (IntPtr)(int)vinfo_mask, ref template, out nitems);
        }

        IntPtr GetVisualInfo(IntPtr display)
        {
            try
            {
                int[] attributes = AttributeList.ToArray();
                return glXChooseVisual(display, Screen.Number, attributes);
            }
            catch (DllNotFoundException e)
            {
                throw new DllNotFoundException("OpenGL dll not found!", e);
            }
            catch (EntryPointNotFoundException enf)
            {
                throw new EntryPointNotFoundException("Glx entry point not found!", enf);
            }
        }

        List<int> AttributeList
        {
            get
            {
                List<int> attributeList = new List<int>(24);

                attributeList.Add(GLX_RGBA);

                if (!SingleBuffer)
                    attributeList.Add(GLX_DOUBLEBUFFER);

                if (Stereo)
                    attributeList.Add(GLX_STEREO);

                attributeList.Add(GLX_RED_SIZE);
                attributeList.Add(ColorBPP / 4); // TODO support 16-bit

                attributeList.Add(GLX_GREEN_SIZE);
                attributeList.Add(ColorBPP / 4); // TODO support 16-bit

                attributeList.Add(GLX_BLUE_SIZE);
                attributeList.Add(ColorBPP / 4); // TODO support 16-bit

                attributeList.Add(GLX_ALPHA_SIZE);
                attributeList.Add(ColorBPP / 4); // TODO support 16-bit

                attributeList.Add(GLX_DEPTH_SIZE);
                attributeList.Add(DepthBPP);

                attributeList.Add(GLX_STENCIL_SIZE);
                attributeList.Add(StencilBPP);

                //attributeList.Add(GLX_AUX_BUFFERS);
                //attributeList.Add(Buffers);

                attributeList.Add(GLX_ACCUM_RED_SIZE);
                attributeList.Add(AccumulatorBPP / 4);// TODO support 16-bit

                attributeList.Add(GLX_ACCUM_GREEN_SIZE);
                attributeList.Add(AccumulatorBPP / 4);// TODO support 16-bit

                attributeList.Add(GLX_ACCUM_BLUE_SIZE);
                attributeList.Add(AccumulatorBPP / 4);// TODO support 16-bit

                attributeList.Add(GLX_ACCUM_ALPHA_SIZE);
                attributeList.Add(AccumulatorBPP / 4);// TODO support 16-bit

                attributeList.Add(GLX_NONE);

                return attributeList;
            }
        }

        [DllImport(UnixLibX11Name, EntryPoint = "XGetVisualInfo")]
        static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr vinfo_mask, ref XVisualInfo template, out int nitems);

        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibX11Name)]
        static extern void XFree(IntPtr handle);

        /// <summary> Returns the X resource (window or pixmap) belonging to a GdkDrawable. </summary>
        /// <remarks> XID gdk_x11_drawable_get_xid(GdkDrawable *drawable); </remarks>
        /// <param name="gdkDisplay"> The GdkDrawable. </param>
        /// <returns> The ID of drawable's X resource. </returns>
        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
        static extern IntPtr gdk_x11_drawable_get_xid(IntPtr gdkDisplay);

        /// <summary> Returns the X resource (window or pixmap) belonging to a GdkDrawable. </summary>
        /// <remarks> XID gdk_x11_drawable_get_xid(GdkDrawable *drawable); </remarks>
        /// <param name="gdkDisplay"> The GdkDrawable. </param>
        /// <returns> The ID of drawable's X resource. </returns>
        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
        static extern IntPtr gdk_x11_window_get_xid(IntPtr gdkDisplay);

        /// <summary> Returns the X display of a GdkDisplay. </summary>
        /// <remarks> Display* gdk_x11_display_get_xdisplay(GdkDisplay *display); </remarks>
        /// <param name="gdkDisplay"> The GdkDrawable. </param>
        /// <returns> The X Display of the GdkDisplay. </returns>
        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGdkName)]
        static extern IntPtr gdk_x11_display_get_xdisplay(IntPtr gdkDisplay);

        [SuppressUnmanagedCodeSecurity, DllImport(UnixLibGLName)]
        static extern IntPtr glXChooseVisual(IntPtr display, int screen, int[] attr);

        #endregion

    }

}
