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
using OpenTK.Graphics;
using OpenTK.Platform.Windows;

namespace OpenTK.Platform.Egl
{
    // EGL factory for the Windows platform.
    internal class EglWinPlatformFactory : WinFactory
    {
        #region Public Members

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            WinWindowInfo win_win = (WinWindowInfo)window;
            IntPtr egl_display = GetDisplay(win_win.DeviceContext, flags, major);
            EglWindowInfo egl_win = new OpenTK.Platform.Egl.EglWindowInfo(win_win.Handle, egl_display);
            return new EglWinContext(mode, egl_win, shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            WinWindowInfo win_win = (WinWindowInfo)window;
            IntPtr egl_display = GetDisplay(win_win.DeviceContext, flags, major);
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

        private IntPtr GetDisplay(IntPtr dc, GraphicsContextFlags flags, int major)
        {
            var display = NeedsAngleDisplay(flags)
                ? GetAngleDisplay(dc, flags, major)
                : Egl.GetDisplay(dc);

            if (display == IntPtr.Zero)
                display = Egl.GetDisplay(IntPtr.Zero);

            return display;
        }

        private bool NeedsAngleDisplay(GraphicsContextFlags flags)
        {
            return FlagEnabled(flags,
                GraphicsContextFlags.Angle
                | GraphicsContextFlags.AngleD3D9
                | GraphicsContextFlags.AngleD3D11
                | GraphicsContextFlags.AngleOpenGL);
        }

        private bool FlagEnabled(GraphicsContextFlags flags, GraphicsContextFlags flag)
        {
            return (flags & flag) != 0;
        }

        private IntPtr GetAngleDisplay(IntPtr dc, GraphicsContextFlags flags, int major)
        {
            // default to D3D9 for ES2, but use D3D11 for ES3 as required by Angle.
            var platform_type = major == 2 ? Egl.PLATFORM_ANGLE_TYPE_D3D9 : Egl.PLATFORM_ANGLE_TYPE_D3D11;
            if (FlagEnabled(flags, GraphicsContextFlags.AngleD3D11))
            {
                platform_type = Egl.PLATFORM_ANGLE_TYPE_D3D11;
            }
            else if (FlagEnabled(flags, GraphicsContextFlags.AngleD3D9))
            {
                platform_type = Egl.PLATFORM_ANGLE_TYPE_D3D9;
            }
            else if (FlagEnabled(flags, GraphicsContextFlags.AngleOpenGL))
            {
                platform_type = Egl.PLATFORM_ANGLE_TYPE_OPENGL;
            }

            var attribs = new[]
            {
                Egl.PLATFORM_ANGLE_TYPE, platform_type,
                Egl.PLATFORM_ANGLE_MAX_VERSION_MAJOR, Egl.DONT_CARE,
                Egl.PLATFORM_ANGLE_MAX_VERSION_MINOR, Egl.DONT_CARE,
                Egl.PLATFORM_ANGLE_DEVICE_TYPE, Egl.PLATFORM_ANGLE_DEVICE_TYPE_HARDWARE,
                Egl.NONE
            };

            return Egl.GetPlatformDisplay(
                new IntPtr(Egl.PLATFORM_ANGLE),
                dc,
                attribs
                );
        }

        #endregion
    }
}