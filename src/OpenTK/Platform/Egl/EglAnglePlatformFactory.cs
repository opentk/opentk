
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

using System;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.Egl
{
    internal class EglAnglePlatformFactory : PlatformFactoryBase
    {
        private readonly IPlatformFactory _platform_factory;
        public EglAnglePlatformFactory(IPlatformFactory platform_factory)
        {
            _platform_factory = platform_factory;
        }

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode,
            GameWindowFlags options, DisplayDevice device)
        {
            return _platform_factory.CreateNativeWindow(x, y, width, height, title,
                mode, options, device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return _platform_factory.CreateDisplayDeviceDriver();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            var angle_window = (IAngleWindowInfoInternal)window;
            var egl_window = CreateWindowInfo(angle_window, major, flags);
            var egl_context = new EglWinContext(mode, egl_window, shareContext, major, minor, flags);
            angle_window.EglContext = egl_context;
            return egl_context;
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window,
            IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            var angle_window = (IAngleWindowInfoInternal)window;
            var egl_window = CreateWindowInfo(angle_window, major, flags);
            var egl_context = new EglWinContext(handle, egl_window, shareContext, major, minor, flags);
            angle_window.EglContext = egl_context;
            return egl_context;
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(Platform.Egl.Egl.GetCurrentContext());
            };
        }

        public override IKeyboardDriver2 CreateKeyboardDriver()
        {
            return _platform_factory.CreateKeyboardDriver();
        }

        public override IMouseDriver2 CreateMouseDriver()
        {
            return _platform_factory.CreateMouseDriver();
        }

        public override IJoystickDriver2 CreateJoystickDriver()
        {
            return _platform_factory.CreateJoystickDriver();
        }

        private static bool FlagEnabled(GraphicsContextFlags flags, GraphicsContextFlags flag)
        {
            return (flags & flag) != 0;
        }

        private EglWindowInfo CreateWindowInfo(IAngleWindowInfoInternal window_info,
            int major, GraphicsContextFlags flags)
        {
            var egl_display = GetAngleDisplay(window_info.DeviceContext, flags, major);
            var egl_window = new EglWindowInfo(window_info.Handle, egl_display);
            window_info.EglWindowInfo = egl_window;
            return egl_window;
        }

        private IntPtr GetAngleDisplay(IntPtr dc, GraphicsContextFlags flags, int major)
        {
            // default to D3D9 for ES2, but use D3D11 for ES3 as required by Angle.
            var platform_type = major == 2
                ? Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_D3D9_ANGLE
                : Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_D3D11_ANGLE;
            if (FlagEnabled(flags, GraphicsContextFlags.AngleD3D11))
            {
                platform_type = Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_D3D11_ANGLE;
            }
            else if (FlagEnabled(flags, GraphicsContextFlags.AngleD3D9))
            {
                platform_type = Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_D3D9_ANGLE;
            }
            else if (FlagEnabled(flags, GraphicsContextFlags.AngleOpenGL))
            {
                platform_type = Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_OPENGL_ANGLE;
            }
            else
            {
                // make sure the correct flag is set.
                switch (platform_type)
                {
                    case Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_D3D9_ANGLE:
                        flags |= GraphicsContextFlags.AngleD3D9;
                        break;
                    case Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_D3D11_ANGLE:
                        flags |= GraphicsContextFlags.AngleD3D11;
                        break;
                    case Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_OPENGL_ANGLE:
                        flags |= GraphicsContextFlags.AngleOpenGL;
                        break;
                }
            }

            var attribs = new[]
            {
                Platform.Egl.Egl.PLATFORM_ANGLE_TYPE_ANGLE, platform_type,
                Platform.Egl.Egl.PLATFORM_ANGLE_MAX_VERSION_MAJOR_ANGLE, Platform.Egl.Egl.DONT_CARE,
                Platform.Egl.Egl.PLATFORM_ANGLE_MAX_VERSION_MINOR_ANGLE, Platform.Egl.Egl.DONT_CARE,
                Platform.Egl.Egl.PLATFORM_ANGLE_DEVICE_TYPE_ANGLE, Platform.Egl.Egl.PLATFORM_ANGLE_DEVICE_TYPE_HARDWARE_ANGLE,
                Platform.Egl.Egl.NONE
            };

            return Platform.Egl.Egl.GetPlatformDisplay(
                Platform.Egl.Egl.PLATFORM_ANGLE_ANGLE,
                dc,
                attribs
                );
        }
    }
}