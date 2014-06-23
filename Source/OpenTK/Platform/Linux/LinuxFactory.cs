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

namespace OpenTK.Platform.Linux
{
    // Linux KMS platform
    class LinuxFactory : PlatformFactoryBase
    {
        int fd;
        GbmDevice device;
        IntPtr display;

        public LinuxFactory()
        {
            // Todo: support multi-GPU systems
            string gpu = "/dev/dri/card0";
            fd = Linux.Open(gpu, OpenFlags.ReadOnly | OpenFlags.CloseOnExec);
            if (fd < 0)
            {
                throw new NotSupportedException("No KMS-capable GPU available");
            }
            Debug.Print("GPU {0} opened as fd:{1}", gpu, fd);

            IntPtr dev = Gbm.CreateDevice(fd);
            if (dev == IntPtr.Zero)
            {
                throw new NotSupportedException("Failed to create GBM device");
            }
            device = (GbmDevice)Marshal.PtrToStructure(dev, typeof(GbmDevice));
            Debug.Print("GBM {0:x} '{1}' created successfully",
                dev, Marshal.PtrToStringAnsi(device.name));

            display = Egl.Egl.GetDisplay(dev);
            if (display == IntPtr.Zero)
            {
                throw new NotSupportedException("Failed to create EGL display");
            }
            Debug.Print("EGL display {0:x} created successfully", display);

            int major, minor;
            if (!Egl.Egl.Initialize(display, out major, out minor))
            {
                int error = Egl.Egl.GetError();
                throw new NotSupportedException("Failed to initialize EGL display. Error code: " + error);
            }
            Debug.Print("EGL {0}.{1} initialized successfully on display {2:x}", major, minor, display);
        }

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new LinuxNativeWindow(x, y, width, height, title, mode, options, device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            throw new NotImplementedException();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            throw new NotImplementedException();
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            throw new NotImplementedException();
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
    }
}

