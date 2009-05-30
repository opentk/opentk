using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    using Graphics;

    class X11Factory : IPlatformFactory 
    {
        #region IPlatformFactory Members

        public INativeGLWindow CreateGLNative()
        {
            return new X11GLNative();
        }

        public IGLControl CreateGLControl(GraphicsMode mode, GLControl owner)
        {
            return new X11GLControl(mode, owner);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new X11XrandrDisplayDevice();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool DirectRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new X11GLContext(mode, window, shareContext, DirectRendering, major, minor, flags);
        }

        public OpenTK.Graphics.GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Glx.GetCurrentContext());
            };
        }

        public IGraphicsMode CreateGraphicsMode()
        {
            return new X11GraphicsMode();
        }

        #endregion
    }
}
