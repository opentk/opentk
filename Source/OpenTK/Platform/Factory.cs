using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    using Graphics;

    static class Factory
    {
        static IPlatformFactory implementation;

        static Factory()
        {
            if (Configuration.RunningOnWindows) implementation = new Windows.WinFactory();
            else if (Configuration.RunningOnX11) implementation = new X11.X11Factory();
            else if (Configuration.RunningOnMacOS) implementation = new MacOS.MacOSFactory();
            else implementation = new UnsupportedPlatform();
        }

        internal static INativeGLWindow CreateNativeGLWindow()
        {
            return implementation.CreateGLNative();
        }

        internal static IGLControl CreateGLControl(GraphicsMode mode, GLControl owner)
        {
            return implementation.CreateGLControl(mode, owner);
        }

        internal static IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return implementation.CreateDisplayDeviceDriver();
        }

        internal static IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return implementation.CreateGLContext(mode, window, shareContext, directRendering, major, minor, flags);
        }

        internal static IGraphicsMode CreateGraphicsMode()
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

            public IGraphicsMode CreateGraphicsMode()
            {
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");
            }

            #endregion
        }
    }
}
