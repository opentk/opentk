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

using OpenTK.OpenGL;

#endregion

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Provides methods to create and control an opengl context on the Windows platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs. 
    /// </summary>
    internal sealed class WinGLContext : OpenTK.Platform.IGLContext, IDisposable
    {
        private IntPtr deviceContext;
        private IntPtr renderContext;
        static private IntPtr opengl32Handle;
        private const string opengl32Name = "OPENGL32.DLL";
        private WindowInfo windowInfo = new WindowInfo();

        private DisplayMode mode;

        private bool disposed;

        #region --- Contructors ---

        internal WinGLContext()
            : this(new DisplayMode(640, 480))
        {
        }

        internal WinGLContext(DisplayMode mode)
        {
            //Trace.WriteLine(String.Format("Creating opengl context (driver: {0})", this.ToString()));
            this.mode = mode;
        }

        public WinGLContext(DisplayMode mode, IWindowInfo info)
        {
            this.windowInfo = info as WindowInfo;
            this.mode = mode;
        }

        #endregion

        #region private void PrepareContext()

        private void PrepareContext()
        {
            if (this.windowInfo.Handle == IntPtr.Zero)
                throw new ApplicationException("No Window Handle specified for opengl context.");

            Debug.WriteLine(String.Format("OpenGL context is bound to handle: {0}", this.windowInfo.Handle));

            // Dynamically load the OpenGL32.dll in order to use the extension loading capabilities of Wgl.
            if (opengl32Handle == IntPtr.Zero)
            {
                opengl32Handle = API.LoadLibrary(opengl32Name);
                if (opengl32Handle == IntPtr.Zero)
                {
                    //System.Diagnostics.Debug.WriteLine("LoadLibrary({0}) set error code: {1}. Will not load extensions.", _dll_name, error_code);
                    throw new ApplicationException(
                        String.Format(
                            "LoadLibrary(\"{0}\") call failed with code {1}",
                            opengl32Name,
                            Marshal.GetLastWin32Error()
                        )
                    );
                }
                Debug.WriteLine(String.Format("Loaded opengl32.dll: {0}", opengl32Handle));
            }

            deviceContext = API.GetDC(this.windowInfo.Handle);
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
            int pixel = API.ChoosePixelFormat(deviceContext, ref pixelFormat);
            if (pixel == 0)
            {
                throw new ApplicationException("The requested pixel format is not supported by the hardware configuration.");
            }
            API.SetPixelFormat(deviceContext, pixel, ref pixelFormat);

            Debug.Print("done! (format: {0})", pixel);
        }

        #endregion
        
        #region --- IGLContext Members ---

        #region public IntPtr Context

        public IntPtr Context
        {
            get { return renderContext; }
            private set { renderContext = value; }
        }

        #endregion

        #region public IWindowInfo Info

        public IWindowInfo Info
        {
            get { return windowInfo; }
        }

        #endregion

        #region public DisplayMode Mode

        public DisplayMode Mode
        {
            get { return new DisplayMode(mode); }
        }

        #endregion

        #region public void CreateContext()

        public void CreateContext()
        {
            this.CreateContext(true, null);
        }

        #endregion

        #region public void CreateContext(bool direct)

        public void CreateContext(bool direct)
        {
            this.CreateContext(direct, null);
        }

        #endregion

        #region public void CreateContext(bool direct, IGLContext source)

        public void CreateContext(bool direct, IGLContext source)
        {
            this.PrepareContext();

            Debug.Write("Creating render context... ");
            // Do not rely on OpenTK.Platform.Windows.Wgl - the context is not ready yet,
            // and Wgl extensions will fail to load.
            renderContext = Wgl.Imports.CreateContext(deviceContext);
            if (renderContext != IntPtr.Zero)
            {
                Debug.WriteLine(String.Format("done! (id: {0})", renderContext));
            }
            else
            {
                throw new ApplicationException("Could not create OpenGL render context (Wgl.CreateContext() return 0).");
            }
            Wgl.Imports.MakeCurrent(deviceContext, renderContext);
            Wgl.LoadAll();

            if (source != null)
            {
                Debug.Print("Sharing state with context {0}", (source as WinGLContext).Context);
                Wgl.Imports.ShareLists(renderContext, (source as WinGLContext).Context);
            }
        }

        #endregion

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            API.SwapBuffers(deviceContext);
        }

        #endregion

        #region public IntPtr GetAddress(string function_string)

        public IntPtr GetAddress(string function_string)
        {
            return Wgl.Imports.GetProcAddress(function_string);
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

        #region public DisplayMode[] GetDisplayModes()

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            List<DisplayMode> modes = new List<DisplayMode>();
            bool done = false;
            int index = 0;

            while (!done)
            {
                DeviceMode currentMode = new DeviceMode();
                IntPtr handle = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(DeviceMode)));
                Marshal.StructureToPtr(currentMode, handle, true);

                done = (API.EnumDisplaySettings(null, index++, handle) != 0) ? false : true;
                int error = Marshal.GetLastWin32Error();

                Marshal.PtrToStructure(handle, currentMode);
                Marshal.FreeHGlobal(handle);

                if (error != 0)
                {
                    Console.WriteLine("Error: {0}", error);
                    continue;
                }
                if (done)
                    break;

                //DisplayMode mode = new DisplayMode(currentMode.PelsWidth, currentMode.PelsHeight);
                DisplayMode mode = new DisplayMode(
                    currentMode.PelsWidth,
                    currentMode.PelsHeight,
                    new ColorMode(currentMode.BitsPerPel),
                    0,
                    0,
                    0,
                    0,
                    false,
                    false,
                    false,
                    currentMode.DisplayFrequency
                );

                modes.Add(mode);
            }

            return modes.ToArray();
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            //Debug.Print("Manually disposing WinGLContext {0}.", this.renderContext);
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                // Clean unmanaged resources here
                // The following call uses the Debug and Wgl classes, making it unsafe?
                ReleaseResources();

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

        #region private void ReleaseResources()

        private void ReleaseResources()
        {
            if (renderContext != IntPtr.Zero)
            {
                Wgl.Imports.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                if (!Wgl.Imports.DeleteContext(renderContext))
                {
                    //throw new ApplicationException("Could not destroy the OpenGL render context. Error: " + Marshal.GetLastWin32Error());
                    //Debug.Print("Could not destroy the OpenGL render context. Error: {0}", Marshal.GetLastWin32Error());
                }
                renderContext = IntPtr.Zero;
            }

            if (deviceContext != IntPtr.Zero)
            {
                if (!API.ReleaseDC(this.windowInfo.Handle, deviceContext))
                {
                    //throw new ApplicationException("Could not release device context. Error: " + Marshal.GetLastWin32Error());
                    //Debug.Print("Could not destroy the device context. Error: {0}", Marshal.GetLastWin32Error());
                }
            }

            if (opengl32Handle != IntPtr.Zero)
            {
                if (!API.FreeLibrary(opengl32Handle))
                {
                    //throw new ApplicationException("FreeLibray call failed ('opengl32.dll'), Error: " + Marshal.GetLastWin32Error());
                    //Debug.Print("Could not release {0}. Error: {1}", opengl32Name, Marshal.GetLastWin32Error());
                }
                opengl32Handle = IntPtr.Zero;
            }
        }

        #endregion

        #endregion
    }
}
