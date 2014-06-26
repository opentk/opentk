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
using System.IO;
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

        const string gpu_path = "/dev/dri"; // card0, card1, ...

        public LinuxFactory()
        {
            // Query all GPUs until we find one that has a connected display.
            // This is necessary in multi-gpu systems, where only one GPU
            // can output a signal.
            // Todo: allow OpenTK to drive multiple GPUs
            // Todo: allow OpenTK to run on an offscreen GPU
            // Todo: allow the user to pick a GPU
            var files = Directory.GetFiles(gpu_path);
            foreach (var gpu in files)
            {
                if (Path.GetFileName(gpu).StartsWith("card"))
                {
                    int test_fd = SetupDisplay(gpu);
                    if (test_fd >= 0)
                    {
                        try
                        {
                            DisplayDriver = new LinuxDisplayDriver(test_fd);
                            if (DisplayDriver.GetDisplay(DisplayIndex.Primary) != null)
                            {
                                fd = test_fd;
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.ToString());
                        }

                        Debug.Print("[KMS] GPU '{0}' is not connected, skipping.", gpu);
                        Libc.close(test_fd);
                    }
                }
            }

            if (fd == 0)
            {
                Debug.Print("[Error] No valid GPU found, bailing out.");
                throw new PlatformNotSupportedException();
            }
        }

        #region Private Members

        int SetupDisplay(string gpu)
        {
            Debug.Print("[KMS] Attempting to use gpu '{0}'.", gpu);
            
            int fd = Libc.open(gpu, OpenFlags.ReadWrite | OpenFlags.CloseOnExec);
            if (fd < 0)
            {
                Debug.Print("[KMS] Failed to open gpu");
                return fd;
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

            return fd;
        }

        #endregion

        #region IPlatformFactory Members

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice display_device)
        {
            return new LinuxNativeWindow(display, gbm_device, fd, x, y, width, height, title, mode, options, display_device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return DisplayDriver;
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new LinuxGraphicsContext(mode, (LinuxWindowInfo)window, shareContext, major, minor, flags);
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

