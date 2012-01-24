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
			throw new NotImplementedException ();
        }

        public virtual IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
			throw new NotImplementedException ();
        }

        public virtual GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(IntPtr.Zero);
            };
        }

        public virtual IGraphicsMode CreateGraphicsMode()
        {
			return new AndroidGraphicsMode ();
        }

        public virtual OpenTK.Input.IKeyboardDriver CreateKeyboardDriver()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
