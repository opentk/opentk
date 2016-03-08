// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{

    class WinFactory : PlatformFactoryBase
    {
        readonly object SyncRoot = new object();

        // The input drivers must be constructed lazily, *after* the
        // WinFactory constructor has finished running. The reason is
        // that they call WinFactory methods internally.
        WinRawInput rawinput_driver; // For keyboard and mouse input

        internal static IntPtr OpenGLHandle { get; private set; }
        const string OpenGLName = "OPENGL32.DLL";

        public WinFactory()
        {
            if (System.Environment.OSVersion.Version.Major <= 4)
            {
                throw new PlatformNotSupportedException("OpenTK requires Windows XP or higher");
            }

            // Dynamically load opengl32.dll in order to use the extension loading capabilities of Wgl.
            // Note: opengl32.dll must be loaded before gdi32.dll, otherwise strange failures may occur
            // (such as "error: 2000" when calling wglSetPixelFormat or slowness/lag on specific GPUs).
            LoadOpenGL();

            if (System.Environment.OSVersion.Version.Major >= 6)
            {
                if (Toolkit.Options.EnableHighResolution)
                {
                    // Enable high-dpi support
                    // Only available on Windows Vista and higher
                    bool result = Functions.SetProcessDPIAware();
                    Debug.Print("SetProcessDPIAware() returned {0}", result);
                }
            }
        }

        static void LoadOpenGL()
        {
            OpenGLHandle = Functions.LoadLibrary(OpenGLName);
            if (OpenGLHandle == IntPtr.Zero)
            {
                throw new ApplicationException(String.Format("LoadLibrary(\"{0}\") call failed with code {1}",
                    OpenGLName, Marshal.GetLastWin32Error()));
            }
            Debug.WriteLine(String.Format("Loaded opengl32.dll: {0}", OpenGLHandle));
        }

        #region IPlatformFactory Members

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new WinGLNative(x, y, width, height, title, options, device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new WinDisplayDeviceDriver();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new WinGLContext(mode, (WinWindowInfo)window, shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new WinGLContext(handle, (WinWindowInfo)window, shareContext, major, minor, flags);
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Wgl.GetCurrentContext());
            };
        }

        public override OpenTK.Input.IKeyboardDriver2 CreateKeyboardDriver()
        {
            return RawInputDriver.KeyboardDriver;
        }

        public override OpenTK.Input.IMouseDriver2 CreateMouseDriver()
        {
            return RawInputDriver.MouseDriver;
        }

        public override OpenTK.Input.IGamePadDriver CreateGamePadDriver()
        {
            return new MappedGamePadDriver();
        }

        public override IJoystickDriver2 CreateJoystickDriver()
        {
            return RawInputDriver.JoystickDriver;
        }

        #endregion

        #region Private Members

        WinRawInput RawInputDriver
        {
            get
            {
                lock (SyncRoot)
                {
                    if (rawinput_driver == null)
                    {
                        rawinput_driver = new WinRawInput();
                    }
                    return rawinput_driver;
                }
            }
        }

        #endregion

        #region IDisposable Members

        protected override void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    WinRawInput raw = rawinput_driver;
                    if (raw != null)
                    {
                        raw.Dispose();
                        rawinput_driver = null;
                    }
                }

                base.Dispose(manual);
            }
        }

        #endregion
    }
}
