#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2011 Xamarin, Inc.
 * Copyright 2013 Xamarin Inc
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using OpenTK.Graphics;

namespace OpenTK.Platform.Android
{
    sealed class AndroidFactory : PlatformFactoryBase
    {
        #region IPlatformFactory Members

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            AndroidWindow android_win = (AndroidWindow)window;
            return new Android.AndroidGraphicsContext(mode, android_win.CreateEglWindowInfo(), shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            AndroidWindow android_win = (AndroidWindow)window;
            return new Android.AndroidGraphicsContext(handle, android_win.CreateEglWindowInfo(), shareContext, major, minor, flags);
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Egl.Egl.GetCurrentContext());
            };
        }

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            throw new NotImplementedException();
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new AndroidDisplayDeviceDriver();
        }

        public override OpenTK.Input.IKeyboardDriver2 CreateKeyboardDriver()
        {
            throw new NotImplementedException();
        }

        public override OpenTK.Input.IMouseDriver2 CreateMouseDriver()
        {
            throw new NotImplementedException();
        }

        public override OpenTK.Input.IJoystickDriver2 CreateJoystickDriver()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
