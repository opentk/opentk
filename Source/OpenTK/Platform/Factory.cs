#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenTK.Platform
{
    using Graphics;
    using Input;

    sealed class Factory : IPlatformFactory
    {
        #region Fields

        bool disposed;
        static IPlatformFactory default_implementation, embedded_implementation;

        #endregion

        #region Constructors

        static Factory()
        {
            // Ensure we are correctly initialized.
            Toolkit.Init();

            // Create regular platform backend
            #if SDL2
            Default = Configuration.RunningOnSdl2 ? new SDL2.Sdl2Factory() : null;
            #endif
            #if WIN32
            Default = Default ?? (Configuration.RunningOnWindows ? new Windows.WinFactory() : null);
            #endif
            #if CARBON
            Default = Default ?? (Configuration.RunningOnMacOS ? new MacOS.MacOSFactory() : null);
            #endif
            #if X11
            Default = Default ?? (Configuration.RunningOnX11 ? new X11.X11Factory() : null);
            #endif
            #if ANDROID
            Default = Default ?? (Configuration.RunningOnAndroid ? new Android.AndroidFactory() : null);
            Embedded = Default;
            #endif
            #if IPHONE
            Default = Default ?? (Configuration.RunningOniOS ? new iPhoneOS.iPhoneOSFactory() : null);
            Embedded = Default;
            #endif
            Default = Default ?? new UnsupportedPlatform();

            #if CARBON || COCOA || SDL2 || WIN32 || X11
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
            else if (Egl.Egl.IsSupported)
            {
                #if WIN32
                Embedded = Configuration.RunningOnWindows ? new Egl.EglWinPlatformFactory() : null;
                #endif
                #if CARBON || COCOA
                Embedded = Embedded ?? (Configuration.RunningOnMacOS ? new Egl.EglMacPlatformFactory() : null);
                #endif
                #if X11
                Embedded = Embedded ?? (Configuration.RunningOnX11 ? new Egl.EglX11PlatformFactory() : null);
                #endif
                Embedded = Embedded ?? new UnsupportedPlatform();
            }
            else
            {
                Embedded = new UnsupportedPlatform();
            }
            #endif

            if (Default is UnsupportedPlatform && !(Embedded is UnsupportedPlatform))
                Default = Embedded;
        }

        #endregion

        #region Public Members

        public static IPlatformFactory Default
        {
            get { return default_implementation; }
            private set { default_implementation = value; }
        }

        public static IPlatformFactory Embedded
        {
            get { return embedded_implementation; }
            private set { embedded_implementation = value; }
        }

        #endregion

        #region IPlatformFactory Members

        public INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options, DisplayDevice device, int major, int minor, GraphicsContextFlags flags)
        {
            return default_implementation.CreateNativeWindow(x, y, width, height, title, mode, options, device, major, minor, flags);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return default_implementation.CreateDisplayDeviceDriver();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return default_implementation.CreateGLContext(mode, window, shareContext, directRendering, major, minor, flags);
        }

        public IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return default_implementation.CreateGLContext(handle, window, shareContext, directRendering, major, minor, flags);
        }

        public GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return default_implementation.CreateGetCurrentGraphicsContext();
        }

        public IKeyboardDriver2 CreateKeyboardDriver()
        {
            return default_implementation.CreateKeyboardDriver();
        }

        public IMouseDriver2 CreateMouseDriver()
        {
            return default_implementation.CreateMouseDriver();
        }

        public IGamePadDriver CreateGamePadDriver()
        {
            return default_implementation.CreateGamePadDriver();
        }

        public IJoystickDriver2 CreateJoystickDriver()
        {
            return default_implementation.CreateJoystickDriver();
        }

        public IJoystickDriver CreateLegacyJoystickDriver()
        {
            return default_implementation.CreateLegacyJoystickDriver();
        }

        class UnsupportedPlatform : PlatformFactoryBase
        {
            #region Fields

            static readonly string error_string = "Please, refer to http://www.opentk.com for more information.";
            
            #endregion
            
            #region IPlatformFactory Members

            public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device, int major, int minor, GraphicsContextFlags flags)
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

            #endregion
        }

        #endregion

        #region IDisposable Members

        void Dispose(bool manual)
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

        #endregion
    }
}
