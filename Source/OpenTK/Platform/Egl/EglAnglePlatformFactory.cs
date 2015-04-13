#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 the Open Toolkit library.
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
using System.Configuration;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.Egl
{
    internal class EglAnglePlatformFactory : PlatformFactoryBase
    {
        #region Public Members

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode,
            GameWindowFlags options, DisplayDevice device)
        {
            throw new NotImplementedException();
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            throw new NotImplementedException();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            var angle_window = (AngleOffscreenWindowInfo) window;
            var egl_window = CreateWindowInfo(angle_window, major, flags);
            var egl_context = new EglWinContext(mode, egl_window, shareContext, major, minor, flags);
            angle_window.SetContext(egl_context);
            return egl_context;
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            var angle_window = (AngleOffscreenWindowInfo)window;
            var egl_window = CreateWindowInfo(angle_window, major, flags);
            var egl_context = new EglWinContext(handle, egl_window, shareContext, major, minor, flags);
            angle_window.SetContext(egl_context);
            return egl_context;
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Egl.GetCurrentContext());
            };
        }

        public override IKeyboardDriver2 CreateKeyboardDriver()
        {
            throw new NotImplementedException();
        }

        public override IMouseDriver2 CreateMouseDriver()
        {
            throw new NotImplementedException();
        }

        public override IJoystickDriver2 CreateJoystickDriver()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Members

        private static bool FlagEnabled(GraphicsContextFlags flags, GraphicsContextFlags flag)
        {
            return (flags & flag) != 0;
        }

        private EglWindowInfo CreateWindowInfo(AngleOffscreenWindowInfo window_info,
            int major, GraphicsContextFlags flags)
        {
            var dc = IntPtr.Zero;
            var egl_display = GetAngleDisplay(flags, major);
            var egl_window = new OpenTK.Platform.Egl.EglWindowInfo(window_info.Handle, egl_display);
            window_info.EglWindowInfo = egl_window;
            return egl_window;
        }

        private IntPtr GetAngleDisplay(GraphicsContextFlags flags, int major)
        {
            var dc = IntPtr.Zero;
            // default to D3D9 for ES2, but use D3D11 for ES3 as required by Angle.
            var platform_type = major == 2 
                ? Egl.PLATFORM_ANGLE_TYPE_D3D9 
                : Egl.PLATFORM_ANGLE_TYPE_D3D11;
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
            else
            {
                // make sure the correct flag is set.
                switch (platform_type)
                {
                    case Egl.PLATFORM_ANGLE_TYPE_D3D9:
                        flags |= GraphicsContextFlags.AngleD3D9;
                        break;
                    case Egl.PLATFORM_ANGLE_TYPE_D3D11:
                        flags |= GraphicsContextFlags.AngleD3D11;
                        break;
                    case Egl.PLATFORM_ANGLE_TYPE_OPENGL:
                        flags |= GraphicsContextFlags.AngleOpenGL;
                        break;
                }
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
                Egl.PLATFORM_ANGLE,
                dc,
                attribs
                );
        }


        #endregion
    }
}
