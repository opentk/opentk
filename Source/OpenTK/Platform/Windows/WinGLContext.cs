#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;

#endregion

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Provides methods to create and control an opengl context on the Windows platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLContext : IGraphicsContext, IGLContextInternal, IGLContextCreationHack
    {
        IntPtr deviceContext;
        ContextHandle renderContext;
        static IntPtr opengl32Handle;
        const string opengl32Name = "OPENGL32.DLL";
        WinWindowInfo windowInfo = new WinWindowInfo();

        GraphicsMode format;
        //DisplayMode mode = null;
        bool vsync_supported;

        bool disposed;

        #region --- Contructors ---

        static WinGLContext()
        {
            // Set the GetCurrentContext implementation.
            // TODO: Does this belong here?
            if (GraphicsContext.GetCurrentContext == null)
                GraphicsContext.GetCurrentContext = WinGLContext.GetCurrentContext;

            // Dynamically load the OpenGL32.dll in order to use the extension loading capabilities of Wgl.
            if (opengl32Handle == IntPtr.Zero)
            {
                opengl32Handle = Functions.LoadLibrary(opengl32Name);
                if (opengl32Handle == IntPtr.Zero)
                    throw new ApplicationException(String.Format("LoadLibrary(\"{0}\") call failed with code {1}",
                                                                 opengl32Name, Marshal.GetLastWin32Error()));
                Debug.WriteLine(String.Format("Loaded opengl32.dll: {0}", opengl32Handle));
            }
        }

        GraphicsMode SelectFormat(GraphicsMode format)
        {
            using (WinGLNative native = new WinGLNative(16, 16))
            //using (WinGLContext context = new WinGLContext(format, native.WindowInfo, null))
            {
                // Find the best multisampling mode.
                return format;
            }
        }

        public WinGLContext(GraphicsMode format, IWindowInfo window, IGraphicsContext sharedContext)
        {
            //format = this.SelectFormat(format);

            this.windowInfo = (WinWindowInfo)window;
            Debug.Print("OpenGL will be bound to handle: {0}", this.windowInfo.Handle);
            if (this.windowInfo.Handle == IntPtr.Zero)
                throw new ArgumentException("window", "Must be a valid window.");

            Debug.Print("Setting pixel format...");
            this.format = this.SetGraphicsModePFD(format);

            Debug.Write("Creating render context... ");
            // Do not rely on OpenTK.Platform.Windows.Wgl - the context is not ready yet,
            // and Wgl extensions will fail to load.
            renderContext = new ContextHandle(Wgl.Imports.CreateContext(deviceContext));
            if (renderContext == IntPtr.Zero)
                throw new GraphicsContextException(String.Format("Context creation failed. Wgl.CreateContext() error: {0}.",
                                                                 Marshal.GetLastWin32Error()));

            Debug.WriteLine(String.Format("done! (id: {0})", renderContext));

            Wgl.Imports.MakeCurrent(deviceContext, renderContext);
            Wgl.LoadAll();
            GL.LoadAll();
            Glu.LoadAll();

            vsync_supported = Wgl.Arb.SupportsExtension(this, "WGL_EXT_swap_control") &&
                Wgl.Load("wglGetSwapIntervalEXT") && Wgl.Load("wglSwapIntervalEXT");

            if (sharedContext != null)
            {
                Debug.Print("Sharing state with context {0}", sharedContext.ToString());
                Wgl.Imports.ShareLists(renderContext, (sharedContext as IGLContextInternal).Context);
            }
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region public void CreateContext()

        public void CreateContext()
        {
            throw new NotSupportedException();
            this.CreateContext(true, null);
        }

        #endregion

        #region public void CreateContext(bool direct)

        public void CreateContext(bool direct)
        {
            throw new NotSupportedException();
            this.CreateContext(direct, null);
        }

        #endregion

        #region public void CreateContext(bool direct, IGraphicsContext source)

        public void CreateContext(bool direct, IGraphicsContext source)
        {
            throw new NotSupportedException();
        }

        #endregion

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            Functions.SwapBuffers(deviceContext);
        }

        #endregion

        #region public void MakeCurrent()
        
        public void MakeCurrent()
        {
            if (!Wgl.Imports.MakeCurrent(deviceContext, renderContext))
            {
                Debug.Print("WinGLContext.MakeCurrent() call failed. Error: {0}", Marshal.GetLastWin32Error());
            }
        }

	    #endregion

        #region public bool IsCurrent

        public bool IsCurrent
        {
            get { return Wgl.GetCurrentContext() == this.renderContext; }
            set
            {
                if (value)
                    Wgl.MakeCurrent(this.deviceContext, this.renderContext);
                else
                    Wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            }

        }

        #endregion

        #region public bool VSync

        /// <summary>
        /// Gets or sets a System.Boolean indicating whether SwapBuffer calls are synced to the screen refresh rate.
        /// </summary>
        public bool VSync
        {
            get
            {
                return vsync_supported && Wgl.Ext.GetSwapInterval() != 0;
            }
            set
            {
                if (vsync_supported)
                    Wgl.Ext.SwapInterval(value ? 1 : 0);
            }
        }

        #endregion

        public event DestroyEvent<IGraphicsContext> Destroy;

        #endregion

        #region --- IGLContextInternal Members ---

        #region ContextHandle IGLContextInternal.Context

        ContextHandle IGLContextInternal.Context
        {
            get { return renderContext; }
        }

        #endregion

        #region IWindowInfo IGLContextInternal.Info

        IWindowInfo IGLContextInternal.Info
        {
            get { return (IWindowInfo)windowInfo; }
        }

        #endregion

        #region GraphicsMode IGLContextInternal.GraphicsMode

        GraphicsMode IGLContextInternal.GraphicsMode
        {
            get { return format; }
        }

        #endregion

        #region public IntPtr GetAddress(string function_string)

        public IntPtr GetAddress(string function_string)
        {
            return Wgl.Imports.GetProcAddress(function_string);
        }

        #endregion

        #region public DisplayMode[] GetDisplayModes()

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new NotSupportedException("See OpenTK.Graphics.DisplayDevice.AvailableModes instead.");
        }

        #endregion

        #region void IGLContextInternal.RegisterForDisposal(IDisposable resource)

        void IGLContextInternal.RegisterForDisposal(IDisposable resource)
        {
            throw new NotSupportedException("Use OpenTK.GraphicsContext instead.");
        }

        #endregion

        #region void IGLContextInternal.DisposeResources()

        void IGLContextInternal.DisposeResources()
        {
            throw new NotSupportedException("Use OpenTK.GraphicsContext instead.");
        }

        #endregion

        #endregion

        #region --- Private Methods ---

        #region GraphicsMode SetGraphicsModePFD(GraphicsMode format)

        GraphicsMode SetGraphicsModePFD(GraphicsMode format)
        {
            deviceContext = Functions.GetDC(this.windowInfo.Handle);
            Debug.WriteLine(String.Format("Device context: {0}", deviceContext));

            Debug.Write("Setting pixel format... ");
            PixelFormatDescriptor pixelFormat = new PixelFormatDescriptor();
            pixelFormat.Size = API.PixelFormatDescriptorSize;
            pixelFormat.Version = API.PixelFormatDescriptorVersion;
            pixelFormat.Flags =
                PixelFormatDescriptorFlags.SUPPORT_OPENGL |
                PixelFormatDescriptorFlags.DRAW_TO_WINDOW;
            pixelFormat.ColorBits = (byte)(format.ColorFormat.Red + format.ColorFormat.Green + format.ColorFormat.Blue);
            
            pixelFormat.PixelType = format.ColorFormat.IsIndexed ? PixelType.INDEXED : PixelType.RGBA;
            pixelFormat.PixelType = PixelType.RGBA;
            pixelFormat.RedBits = (byte)format.ColorFormat.Red;
            pixelFormat.GreenBits = (byte)format.ColorFormat.Green;
            pixelFormat.BlueBits = (byte)format.ColorFormat.Blue;
            pixelFormat.AlphaBits = (byte)format.ColorFormat.Alpha;

            if (format.AccumulatorFormat != null)
            {
                pixelFormat.AccumBits = (byte)(format.AccumulatorFormat.Red + format.AccumulatorFormat.Green + format.AccumulatorFormat.Blue);
                pixelFormat.AccumRedBits = (byte)format.AccumulatorFormat.Red;
                pixelFormat.AccumGreenBits = (byte)format.AccumulatorFormat.Green;
                pixelFormat.AccumBlueBits = (byte)format.AccumulatorFormat.Blue;
                pixelFormat.AccumAlphaBits = (byte)format.AccumulatorFormat.Alpha;
            }

            pixelFormat.DepthBits = (byte)format.Depth;
            pixelFormat.StencilBits = (byte)format.Stencil;

            if (format.Depth <= 0) pixelFormat.Flags |= PixelFormatDescriptorFlags.DEPTH_DONTCARE;
            if (format.Stereo) pixelFormat.Flags |= PixelFormatDescriptorFlags.STEREO;
            if (format.Buffers > 1) pixelFormat.Flags |= PixelFormatDescriptorFlags.DOUBLEBUFFER;

            int pixel = Functions.ChoosePixelFormat(deviceContext, ref pixelFormat);
            if (pixel == 0)
                throw new GraphicsModeException(String.Format("The requested format is not available: {0}.", format));

            // Find out what we really got as a format:
            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            pixelFormat.Size = API.PixelFormatDescriptorSize;
            pixelFormat.Version = API.PixelFormatDescriptorVersion;
            Functions.DescribePixelFormat(deviceContext, pixel, API.PixelFormatDescriptorSize, ref pfd);
            GraphicsMode fmt = new GraphicsMode(
                new ColorDepth(pfd.RedBits, pfd.GreenBits, pfd.BlueBits, pfd.AlphaBits),
                pfd.DepthBits,
                pfd.StencilBits,
                0,
                new ColorDepth(pfd.AccumBits),
                (pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) != 0 ? 2 : 1,
                (pfd.Flags & PixelFormatDescriptorFlags.STEREO) != 0);

            if (!Functions.SetPixelFormat(deviceContext, pixel, ref pixelFormat))
                throw new GraphicsContextException(String.Format("Requested GraphicsMode not available. SetPixelFormat error: {0}",
                                                                 Marshal.GetLastWin32Error()));
            Debug.Print("done! (format: {0})", pixel);

            return fmt;
        }

        #endregion

        #region GraphicsMode SetGraphicsModeARB(GraphicsMode format)

        GraphicsMode SetGraphicsModeARB(GraphicsMode format)
        {
            return null;
        }

        #endregion


        #endregion

        #region --- IGLContextCreationHack Members ---

        #region bool IGLContextCreationHack.SelectDisplayMode(DisplayMode mode, IWindowInfo info)

        /// <summary>
        /// HACK! This function will be removed in 0.3.15
        /// Checks if the specified OpenTK.Platform.DisplayMode is available, and selects it if it is.
        /// </summary>
        /// <param name="mode">The OpenTK.Platform.DisplayMode to select.</param>
        /// <param name="info">The OpenTK.Platform.IWindowInfo that describes the display to use. Note: a window handle is not necessary for this function!</param>
        /// <returns>True if the DisplayMode is available, false otherwise.</returns>
        bool IGLContextCreationHack.SelectDisplayMode(DisplayMode mode, IWindowInfo info)
        {
            // Dynamically load the OpenGL32.dll in order to use the extension loading capabilities of Wgl.
            if (opengl32Handle == IntPtr.Zero)
            {
                opengl32Handle = Functions.LoadLibrary(opengl32Name);
                if (opengl32Handle == IntPtr.Zero)
                {
                    //System.Diagnostics.Debug.WriteLine("LoadLibrary({0}) set error code: {1}. Will not load extensions.", _dll_name, error_code);
                    throw new ApplicationException(String.Format("LoadLibrary(\"{0}\") call failed with code {1}",
                                                                 opengl32Name, Marshal.GetLastWin32Error()));
                }
                Debug.WriteLine(String.Format("Loaded opengl32.dll: {0}", opengl32Handle));
            }
            deviceContext = Functions.GetDC(this.windowInfo.Handle);
            Debug.WriteLine(String.Format("Device context: {0}", deviceContext));

            Debug.Write("Setting pixel format... ");
            PixelFormatDescriptor pixelFormat = new PixelFormatDescriptor();
            pixelFormat.Size = API.PixelFormatDescriptorSize;
            pixelFormat.Version = API.PixelFormatDescriptorVersion;
            pixelFormat.Flags =
                PixelFormatDescriptorFlags.SUPPORT_OPENGL |
                PixelFormatDescriptorFlags.DRAW_TO_WINDOW;
            pixelFormat.ColorBits = (byte)(mode.Color.Red + mode.Color.Green + mode.Color.Blue);
            if (mode.Color.IsIndexed)
            {
                pixelFormat.PixelType = PixelType.INDEXED;
            }
            else
            {
                pixelFormat.PixelType = PixelType.RGBA;
                pixelFormat.RedBits = (byte)mode.Color.Red;
                pixelFormat.GreenBits = (byte)mode.Color.Green;
                pixelFormat.BlueBits = (byte)mode.Color.Blue;
                pixelFormat.AlphaBits = (byte)mode.Color.Alpha;
            }

            /*
            if (accum != null)
            {
                pixelFormat.AccumBits = (byte)(accum.Red + accum.Green + accum.Blue);
                pixelFormat.AccumRedBits = (byte)accum.Red;
                pixelFormat.AccumGreenBits = (byte)accum.Green;
                pixelFormat.AccumBlueBits = (byte)accum.Blue;
                pixelFormat.AccumAlphaBits = (byte)accum.Alpha;
            }
            */
            pixelFormat.DepthBits = (byte)mode.DepthBits;
            pixelFormat.StencilBits = (byte)mode.StencilBits;

            if (mode.DepthBits <= 0)
            {
                pixelFormat.Flags |= PixelFormatDescriptorFlags.DEPTH_DONTCARE;
            }

            if (mode.Stereo)
            {
                pixelFormat.Flags |= PixelFormatDescriptorFlags.STEREO;
            }

            if (mode.Buffers > 1)
            {
                pixelFormat.Flags |= PixelFormatDescriptorFlags.DOUBLEBUFFER;
            }

            // TODO: More elaborate mode setting, using DescribePixelFormat.
            /*
            unsafe
            {
                int pixel = Wgl.Imports.ChoosePixelFormat(deviceContext, &pixelFormat);

                if (pixel == 0)
                {
                    throw new ApplicationException("The requested pixel format is not supported by the hardware configuration.");
                }

                Wgl.Imports.SetPixelFormat(deviceContext, pixel, &pixelFormat);

                Debug.WriteLine(String.Format("done! (format: {0})", pixel));
            }
            */
            int pixel = Functions.ChoosePixelFormat(deviceContext, ref pixelFormat);
            if (pixel == 0)
            {
                Debug.Print("format not available...");
                return false;
            }
            Functions.SetPixelFormat(deviceContext, pixel, ref pixelFormat);

            Debug.Print("done! (format: {0})", pixel);

            return true;
        }

        #endregion

        void IGLContextCreationHack.SetWindowHandle(IntPtr handle)
        {
            this.windowInfo.Handle = handle;
        }

        #endregion

        #region --- Internal Methods ---

        #region internal IntPtr Device

        internal IntPtr Device { get { return deviceContext; } }

        #endregion

        #region static ContextHandle GetCurrentContext()

        static ContextHandle GetCurrentContext()
        {
            return Wgl.GetCurrentContext();
        }

        #endregion

        #endregion

        #region --- Overrides ---

        /// <summary>Returns a System.String describing this OpenGL context.</summary>
        /// <returns>A System.String describing this OpenGL context.</returns>
        public override string ToString()
        {
            return (this as IGLContextInternal).Context.ToString();
        }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                DestroyContext();

                if (calledManually)
                {
                    // Safe to clean managed resources
                }
                disposed = true;
            }
        }

        ~WinGLContext()
        {
            Dispose(false);
        }

        #region private void DestroyContext()

        private void DestroyContext()
        {
            if (Destroy != null)
                Destroy(this, EventArgs.Empty);

            if (renderContext != IntPtr.Zero)
            {
                Wgl.Imports.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                if (!Wgl.Imports.DeleteContext(renderContext))
                {
                    //throw new ApplicationException("Could not destroy the OpenGL render context. Error: " + Marshal.GetLastWin32Error());
                    //Debug.Print("Could not destroy the OpenGL render context. Error: {0}", Marshal.GetLastWin32Error());
                }
                renderContext = null;
            }

            if (deviceContext != IntPtr.Zero)
            {
                if (!Functions.ReleaseDC(this.windowInfo.Handle, deviceContext))
                {
                    //throw new ApplicationException("Could not release device context. Error: " + Marshal.GetLastWin32Error());
                    //Debug.Print("Could not destroy the device context. Error: {0}", Marshal.GetLastWin32Error());
                }
            }

            /*
            if (opengl32Handle != IntPtr.Zero)
            {
                if (!Functions.FreeLibrary(opengl32Handle))
                {
                    //throw new ApplicationException("FreeLibray call failed ('opengl32.dll'), Error: " + Marshal.GetLastWin32Error());
                    //Debug.Print("Could not release {0}. Error: {1}", opengl32Name, Marshal.GetLastWin32Error());
                }
                opengl32Handle = IntPtr.Zero;
            }
            */
        }

        #endregion

        #endregion
    }
}
