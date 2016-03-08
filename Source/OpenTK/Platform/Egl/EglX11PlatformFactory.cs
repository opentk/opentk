// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Platform.X11;

namespace OpenTK.Platform.Egl
{
    class EglX11PlatformFactory : X11Factory
    {
        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            X11WindowInfo x11_win = (X11WindowInfo)window;
            EglWindowInfo egl_win = new OpenTK.Platform.Egl.EglWindowInfo(x11_win.Handle, Egl.GetDisplay(x11_win.Display));
            return new EglUnixContext(mode, egl_win, shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            X11WindowInfo x11_win = (X11WindowInfo)window;
            EglWindowInfo egl_win = new OpenTK.Platform.Egl.EglWindowInfo(x11_win.Handle, Egl.GetDisplay(x11_win.Display));
            return new EglUnixContext(handle, egl_win, shareContext, major, minor, flags);
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Egl.GetCurrentContext());
            };
        }
    }
}
