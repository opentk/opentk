using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.Windows
{
    using Graphics;

    class WinFactory : IPlatformFactory 
    {
        #region IPlatformFactory Members

        public INativeGLWindow CreateGLNative()
        {
            return new WinGLNative();
        }

        public IGLControl CreateGLControl(GraphicsMode mode, GLControl owner)
        {
            return new WinGLControl(mode, owner);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new WinDisplayDeviceDriver();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool DirectRendering)
        {
            return new WinGLContext(mode, window, shareContext);
        }

        public IGraphicsMode CreateGraphicsMode()
        {
            return new WinGraphicsMode();
        }

        #endregion
    }
}
