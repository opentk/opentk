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

namespace OpenTK.Platform
{
    using Graphics;
    using Input;

    internal sealed class Factory : IPlatformFactory
    {
        private bool disposed;

        static Factory()
        {
            Toolkit.Init();
        }

        public Factory()
        {
            // Ensure we are correctly initialized.
            Toolkit.Init();

            // Create regular platform backend
#if SDL2
            if (Configuration.RunningOnSdl2)
            {
                Default = new SDL2.Sdl2Factory();
            }
#endif
#if WIN32
            else if (Configuration.RunningOnWindows)
            {
                Default = new Windows.WinFactory();
            }
#endif
#if CARBON
            else if (Configuration.RunningOnMacOS)
            {
                Default = new MacOS.MacOSFactory();
            }
#endif
#if X11
            else if (Configuration.RunningOnX11)
            {
                Default = new X11.X11Factory();
            }
            else if (Configuration.RunningOnLinux)
            {
                Default = new Linux.LinuxFactory();
            }
#endif
            if (Default == null)
            {
                Default = new UnsupportedPlatform();
            }

            // Create embedded platform backend for EGL / OpenGL ES.
            // Todo: we could probably delay this until the embedded
            // factory is actually accessed. This might improve startup
            // times slightly.
            if (Configuration.RunningOnSdl2)
            {
                // SDL supports both EGL and desktop backends
                // using the same API.
                Embedded = Default;
            }
#if IPHONE
            else if (Configuration.RunningOnIOS)
            {
                Embedded = new iPhoneOS.iPhoneFactory();
            }
#else
            else if (Egl.Egl.IsSupported)
            {
                if (Configuration.RunningOnLinux)
                {
                    Embedded = Default;
                }
#if X11
                else if (Configuration.RunningOnX11)
                {
                    Embedded = new Egl.EglX11PlatformFactory();
                }
#endif
#if WIN32
                else if (Configuration.RunningOnWindows)
                {
                    Embedded = new Egl.EglWinPlatformFactory();
                }
#endif
#if CARBON
                else if (Configuration.RunningOnMacOS)
                {
                    Embedded = new Egl.EglMacPlatformFactory();
                }
#endif
#if ANDROID
                else if (Configuration.RunningOnAndroid) Embedded = new Android.AndroidFactory();
#endif
                else
                {
                    Embedded = new UnsupportedPlatform();
                }

#if ANDROID
                Angle = new UnsupportedPlatform();
#else
                Angle = new Egl.EglAnglePlatformFactory(Embedded);
#endif
            }
#endif
            else
            {
                Embedded = new UnsupportedPlatform();
                Angle = Embedded;
            }

            if (Default is UnsupportedPlatform && !(Embedded is UnsupportedPlatform))
            {
                Default = Embedded;
            }
        }

        public static IPlatformFactory Default { get; private set; }

        public static IPlatformFactory Embedded { get; private set; }

        public static IPlatformFactory Angle { get; private set; }

        public INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return Default.CreateNativeWindow(x, y, width, height, title, mode, options, device);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return Default.CreateDisplayDeviceDriver();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return Default.CreateGLContext(mode, window, shareContext, directRendering, major, minor, flags);
        }

        public IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return Default.CreateGLContext(handle, window, shareContext, directRendering, major, minor, flags);
        }

        public GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return Default.CreateGetCurrentGraphicsContext();
        }

        public IKeyboardDriver2 CreateKeyboardDriver()
        {
            return Default.CreateKeyboardDriver();
        }

        public IMouseDriver2 CreateMouseDriver()
        {
            return Default.CreateMouseDriver();
        }

        public IGamePadDriver CreateGamePadDriver()
        {
            return Default.CreateGamePadDriver();
        }

        public IJoystickDriver2 CreateJoystickDriver()
        {
            return Default.CreateJoystickDriver();
        }

        public void RegisterResource(IDisposable resource)
        {
            Default.RegisterResource(resource);
        }

        private class UnsupportedPlatform : PlatformFactoryBase
        {
            private static readonly string error_string = "Please, refer to http://www.opentk.net for more information.";

            public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
            {
                throw new PlatformNotSupportedException(error_string);
            }

            public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
            {
                throw new PlatformNotSupportedException(error_string);
            }

            public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
            {
                throw new PlatformNotSupportedException(error_string);
            }

            public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
            {
                throw new PlatformNotSupportedException(error_string);
            }

            public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
            {
                throw new PlatformNotSupportedException(error_string);
            }

            public override IKeyboardDriver2 CreateKeyboardDriver()
            {
                throw new PlatformNotSupportedException(error_string);
            }

            public override IMouseDriver2 CreateMouseDriver()
            {
                throw new PlatformNotSupportedException(error_string);
            }

            public override IJoystickDriver2 CreateJoystickDriver()
            {
                throw new PlatformNotSupportedException(error_string);
            }
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    Default.Dispose();
                    if (Embedded != Default)
                    {
                        Embedded.Dispose();
                    }
                }
                else
                {
                    Debug.Print("{0} leaked, did you forget to call Dispose()?", GetType());
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Factory()
        {
            Dispose(false);
        }
    }
}
