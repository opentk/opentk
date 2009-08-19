using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    using Graphics;

    class X11Factory : IPlatformFactory 
    {
        #region IPlatformFactory Members

        public virtual INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new X11GLNative(x, y, width, height, title, mode, options, device);
        }

        public virtual IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new X11XrandrDisplayDevice();
        }

        public virtual IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new X11GLContext(mode, window, shareContext, directRendering, major, minor, flags);
        }

        public virtual GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Glx.GetCurrentContext());
            };
        }

        public virtual IGraphicsMode CreateGraphicsMode()
        {
            return new X11GraphicsMode();
        }

        public virtual OpenTK.Input.IKeyboardDriver CreateKeyboardDriver()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
