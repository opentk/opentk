using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    using Graphics;

    class MacOSFactory : IPlatformFactory 
    {
        #region IPlatformFactory Members

        public INativeGLWindow CreateGLNative()
        {
            return new CarbonGLNative();
        }

        public IGLControl CreateGLControl(GraphicsMode mode, GLControl owner)
        {
            return new CarbonGLControl(mode, owner);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new QuartzDisplayDeviceDriver();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool DirectRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new AglContext(mode, window, shareContext);
        }

        public GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Agl.aglGetCurrentContext());
            };
        }

        public IGraphicsMode CreateGraphicsMode()
        {
            return new MacOSGraphicsMode();
        }

        #endregion
    }
}
