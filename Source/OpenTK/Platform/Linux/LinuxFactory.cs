#region License
//
// LinuxFactory.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Platform.Egl;

namespace OpenTK.Platform.Linux
{
    using Egl = OpenTK.Platform.Egl.Egl;

    // Linux KMS platform
    class LinuxFactory : PlatformFactoryBase
    {
        int fd;
        IntPtr gbm_device;
        IntPtr display;

        IJoystickDriver2 JoystickDriver;
        IDisplayDeviceDriver DisplayDriver;

        public LinuxFactory()
        {
            SetupEgl();
        }

        #region Private Members

        void SetupEgl()
        {
            // Todo: support multi-GPU systems
            string gpu = "/dev/dri/card0";
            fd = Libc.open(gpu, OpenFlags.ReadWrite | OpenFlags.CloseOnExec);
            if (fd < 0)
            {
                throw new NotSupportedException("[KMS] No KMS-capable GPU available");
            }
            Debug.Print("[KMS] GPU '{0}' opened as fd:{1}", gpu, fd);

            gbm_device = Gbm.CreateDevice(fd);
            if (gbm_device == IntPtr.Zero)
            {
                throw new NotSupportedException("[KMS] Failed to create GBM device");
            }
            Debug.Print("[KMS] GBM {0:x} created successfully; ", gbm_device);

            display = Egl.GetDisplay(gbm_device);
            if (display == IntPtr.Zero)
            {
                throw new NotSupportedException("[KMS] Failed to create EGL display");
            }
            Debug.Print("[KMS] EGL display {0:x} created successfully", display);

            int major, minor;
            if (!Egl.Initialize(display, out major, out minor))
            {
                ErrorCode error = Egl.GetError();
                throw new NotSupportedException("[KMS] Failed to initialize EGL display. Error code: " + error);
            }
            Debug.Print("[KMS] EGL {0}.{1} initialized successfully on display {2:x}", major, minor, display);
        }

        #endregion

        #region IPlatformFactory Members

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice display_device)
        {
            return new LinuxNativeWindow(display, gbm_device, x, y, width, height, title, mode, options, display_device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            lock (this)
            {
                DisplayDriver = DisplayDriver ?? new LinuxDisplayDriver(fd);
                return DisplayDriver;
            }
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new EglUnixContext(mode, (EglWindowInfo)window, shareContext, major, minor, flags);
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
            lock (this)
            {
                JoystickDriver = JoystickDriver ?? new LinuxJoystick();
                return JoystickDriver;
            }
        }

        #endregion
    }
}

