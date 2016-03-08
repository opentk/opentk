// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics;
using OpenTK.Platform.Windows;

namespace OpenTK.Platform.Egl
{
    // EGL factory for the Windows platform.
    class EglWinPlatformFactory : WinFactory
    {
        #region Public Members

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            WinWindowInfo win_win = (WinWindowInfo)window;
            IntPtr egl_display = GetDisplay(win_win.DeviceContext);
            EglWindowInfo egl_win = new OpenTK.Platform.Egl.EglWindowInfo(win_win.Handle, egl_display);
            return new EglWinContext(mode, egl_win, shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            WinWindowInfo win_win = (WinWindowInfo)window;
            IntPtr egl_display = GetDisplay(win_win.DeviceContext);
            EglWindowInfo egl_win = new OpenTK.Platform.Egl.EglWindowInfo(win_win.Handle, egl_display);
            return new EglWinContext(handle, egl_win, shareContext, major, minor, flags);
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Egl.GetCurrentContext());
            };
        }

        #endregion

        #region Private Members

        IntPtr GetDisplay(IntPtr dc)
        {
            IntPtr display = Egl.GetDisplay(dc);
            if (display == IntPtr.Zero)
                display = Egl.GetDisplay(IntPtr.Zero);

            return display;
        }

        #endregion
    }
}
