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
using System.Diagnostics;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    class X11Factory : PlatformFactoryBase
    {
        IInputDriver2 input_driver;
        IInputDriver2 InputDriver
        {
            get
            {
                if (input_driver == null)
                {
                    if (XI2MouseKeyboard.IsSupported(IntPtr.Zero))
                    {
                        input_driver = new XI2Input();
                    }
                    else
                    {
                        input_driver = new X11Input();
                    }
                }
                return input_driver;
            }
        }

        #region Constructors

        public X11Factory()
        {
            int result = Functions.XInitThreads();
            Debug.Print("Initializing threaded X: {0}.", result != 0 ? "success" : "failed");
        }

        #endregion

        #region IPlatformFactory Members

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new X11GLNative(x, y, width, height, title, mode, options, device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new X11DisplayDevice();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new X11GLContext(mode, window, shareContext, directRendering, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new X11GLContext(handle, window, shareContext, directRendering, major, minor, flags);
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Glx.GetCurrentContext());
            };
        }

        public override IKeyboardDriver2 CreateKeyboardDriver()
        {
            return InputDriver.KeyboardDriver;
        }

        public override IMouseDriver2 CreateMouseDriver()
        {
            return InputDriver.MouseDriver;
        }

        public override IJoystickDriver2 CreateJoystickDriver()
        {
            return InputDriver.JoystickDriver;
        }

        #endregion

        protected override void Dispose(bool manual)
        {
            base.Dispose(manual);
            if (manual)
            {
                if (input_driver is IDisposable)
                {
                    (input_driver as IDisposable).Dispose();
                    input_driver = null;
                }
            }
        }
    }
}
