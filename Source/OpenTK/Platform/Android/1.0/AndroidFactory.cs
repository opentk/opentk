#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Diagnostics;
using OpenTK.Graphics;
using Javax.Microedition.Khronos.Egl;

namespace OpenTK.Platform.Android
{
    class AndroidFactory : IPlatformFactory
    {
        #region IPlatformFactory Members

        public virtual INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
			throw new NotImplementedException ();
        }

        public virtual IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
			return new AndroidDisplayDeviceDriver ();
        }

        public virtual IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
			return new Android.AndroidGraphicsContext(mode, window, shareContext, major, minor, flags);
        }

        public virtual IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
			throw new NotImplementedException ();
        }

        public virtual GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
				try {
					var egl = global::Android.Runtime.Extensions.JavaCast<IEGL10> (EGLContext.EGL);
					var ctx = egl.EglGetCurrentContext ();
					if (ctx != null && ctx != EGL10.EglNoContext)
						return new ContextHandle (ctx.Handle);
				} catch (Exception ex) {
					global::Android.Util.Log.Error ("AndroidFactory", "Could not get the current EGLContext. {0}", ex);
				}
                return new ContextHandle(IntPtr.Zero);
            };
        }

        public virtual IGraphicsMode CreateGraphicsMode()
        {
			return new AndroidGraphicsMode ();
        }

        public virtual OpenTK.Input.IKeyboardDriver2 CreateKeyboardDriver()
        {
            throw new NotImplementedException();
        }

        public virtual OpenTK.Input.IMouseDriver2 CreateMouseDriver()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
