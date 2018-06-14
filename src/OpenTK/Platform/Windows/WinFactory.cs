//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Core;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.NT.Native;

namespace OpenTK.Platform.Windows
{
    internal class WinFactory : PlatformFactoryBase
    {
        private const string OpenGLName = "OPENGL32.DLL";
        private readonly object SyncRoot = new object();

        // The input drivers must be constructed lazily, *after* the
        // WinFactory constructor has finished running. The reason is
        // that they call WinFactory methods internally.
        private WinRawInput rawinput_driver; // For keyboard and mouse input

        public WinFactory()
        {
            if (Environment.OSVersion.Version.Major <= 4)
            {
                throw new PlatformNotSupportedException("OpenTK requires Windows XP or higher");
            }

            // Dynamically load opengl32.dll in order to use the extension loading capabilities of Wgl.
            // Note: opengl32.dll must be loaded before gdi32.dll, otherwise strange failures may occur
            // (such as "error: 2000" when calling wglSetPixelFormat or slowness/lag on specific GPUs).
            LoadOpenGL();

            if (Environment.OSVersion.Version.Major >= 6)
            {
                if (Toolkit.Options.EnableHighResolution)
                {
                    // Enable high-dpi support
                    // Only available on Windows Vista and higher
                    var result = User32.Window.SetProcessDPIAware();
                    Debug.Print("SetProcessDPIAware() returned {0}", result);
                }
            }
        }

        internal static IntPtr OpenGLHandle { get; private set; }

        private WinRawInput RawInputDriver
        {
            get
            {
                lock (SyncRoot)
                {
                    if (rawinput_driver == null)
                        rawinput_driver = new WinRawInput();

                    return rawinput_driver;
                }
            }
        }

        private static void LoadOpenGL()
        {
            OpenGLHandle = Kernel32.LoadLibrary(OpenGLName);
            if (OpenGLHandle == IntPtr.Zero)
            {
                throw new ApplicationException(
                    $"LoadLibrary(\"{OpenGLName}\") call failed with code {Marshal.GetLastWin32Error()}");
            }

            Debug.WriteLine($"Loaded opengl32.dll: {OpenGLHandle}");
        }

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new WinGLNative(x, y, width, height, title, options, device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new WinDisplayDeviceDriver();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new WinGLContext(mode, (WinWindowInfo)window, shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new WinGLContext(handle, (WinWindowInfo)window, shareContext, major, minor, flags);
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return delegate { return new ContextHandle(Wgl.GetCurrentContext()); };
        }

        public override IKeyboardDriver2 CreateKeyboardDriver()
        {
            return RawInputDriver.KeyboardDriver;
        }

        public override IMouseDriver2 CreateMouseDriver()
        {
            return RawInputDriver.MouseDriver;
        }

        public override IGamePadDriver CreateGamePadDriver()
        {
            return new MappedGamePadDriver();
        }

        public override IJoystickDriver2 CreateJoystickDriver()
        {
            return RawInputDriver.JoystickDriver;
        }

        protected override void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    var raw = rawinput_driver;
                    if (raw != null)
                    {
                        raw.Dispose();
                        rawinput_driver = null;
                    }
                }

                base.Dispose(manual);
            }
        }
    }
}