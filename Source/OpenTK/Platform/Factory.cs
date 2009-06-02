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
using System.Text;

namespace OpenTK.Platform
{
    using Graphics;

    class Factory : IPlatformFactory
    {
        #region Fields

        static IPlatformFactory implementation;

        #endregion

        #region Constructors

        static Factory()
        {
            if (Configuration.RunningOnWindows) implementation = new Windows.WinFactory();
            else if (Configuration.RunningOnX11) implementation = new X11.X11Factory();
            else if (Configuration.RunningOnMacOS) implementation = new MacOS.MacOSFactory();
            else implementation = new UnsupportedPlatform();
        }

        #endregion

        #region Public Members

        public static IPlatformFactory Default
        {
            get { return implementation; }
        }

        #endregion

        #region IPlatformFactory Members

        public INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title,
            GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return implementation.CreateNativeWindow(x, y, width, height, title, mode, options, device);
        }

        public IGLControl CreateGLControl(GraphicsMode mode, GLControl owner)
        {
            return implementation.CreateGLControl(mode, owner);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return implementation.CreateDisplayDeviceDriver();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return implementation.CreateGLContext(mode, window, shareContext, directRendering, major, minor, flags);
        }

        public GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return implementation.CreateGetCurrentGraphicsContext();
        }

        public IGraphicsMode CreateGraphicsMode()
        {
            return implementation.CreateGraphicsMode();
        }

        class UnsupportedPlatform : IPlatformFactory
        {
            #region IPlatformFactory Members

            public INativeGLWindow CreateGLNative()
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }

            public INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }

            public IGLControl CreateGLControl(GraphicsMode mode, GLControl owner)
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }

            public IDisplayDeviceDriver CreateDisplayDeviceDriver()
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }

            public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool DirectRendering, int major, int minor, GraphicsContextFlags flags)
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }

            public GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }


            public IGraphicsMode CreateGraphicsMode()
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }

            #endregion
        }

        #endregion
    }
}
