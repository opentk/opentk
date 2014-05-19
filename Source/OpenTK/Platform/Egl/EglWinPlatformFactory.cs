#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

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
