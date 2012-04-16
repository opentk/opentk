#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Platform.Android;

namespace OpenTK.Platform.Egl
{
    class EglAndroidPlatformFactory : AndroidFactory
    {
        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
			throw new NotImplementedException ();
//            EglWindowInfo egl_win = new OpenTK.Platform.Egl.EglWindowInfo(window.WindowHandle, Egl.GetDisplay(x11_win.Display));
//            return new EglContext(mode, egl_win, shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
			throw new NotImplementedException ();
//            EglWindowInfo egl_win = new OpenTK.Platform.Egl.EglWindowInfo(x11_win.WindowHandle, Egl.GetDisplay(x11_win.Display));
//            return new EglContext(handle, egl_win, shareContext, major, minor, flags);
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
