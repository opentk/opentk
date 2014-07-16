#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
// Copyright 2013 Xamarin Inc
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
using System.Text;

#if XAMCORE_2_0
using OpenGLES;
#else
using MonoTouch.OpenGLES;
#endif

using OpenTK.Graphics;

namespace OpenTK.Platform.iPhoneOS
{
    sealed class iPhoneOSFactory : IPlatformFactory
    {
        internal iPhoneOSFactory()
        {
        }

        #region IPlatformFactory Members

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new iPhoneOS.iPhoneOSGraphicsContext(mode, window, shareContext, major, minor, flags);
        }

        public IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new iPhoneOS.iPhoneOSGraphicsContext(handle, window, shareContext, major, minor, flags);
        }

        public IGraphicsMode CreateGraphicsMode()
        {
            return new iPhoneOS.iPhoneOSGraphicsMode();
        }

        public GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return () => {
                EAGLContext c = EAGLContext.CurrentContext;
                IntPtr h = IntPtr.Zero;
                if (c != null)
                    h = c.Handle;
                return new ContextHandle(h);
            };
        }

        public INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device, int major, int minor, GraphicsContextFlags flags)
        {
            throw new NotImplementedException();
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            throw new NotImplementedException();
        }

        public OpenTK.Input.IKeyboardDriver2 CreateKeyboardDriver()
        {
            throw new NotImplementedException();
        }

        public OpenTK.Input.IMouseDriver2 CreateMouseDriver()
        {
            throw new NotImplementedException();
        }

        public OpenTK.Input.IGamePadDriver CreateGamePadDriver()
        {
            throw new NotImplementedException();
        }

        public OpenTK.Input.IJoystickDriver2 CreateJoystickDriver()
        {
            throw new NotImplementedException();
        }

        public OpenTK.Input.IJoystickDriver CreateLegacyJoystickDriver()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
