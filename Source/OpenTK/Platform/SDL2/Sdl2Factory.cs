// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Diagnostics;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2Factory : PlatformFactoryBase
    {
        readonly Sdl2InputDriver InputDriver = new Sdl2InputDriver();

        /// <summary>
        /// Gets or sets a value indicating whether to use SDL2 fullscreen-desktop mode
        /// for fullscreen windows. When true, then GameWindow instances will not change
        /// DisplayDevice resolutions when going fullscreen. When false, fullscreen GameWindows
        /// will change the device resolution to match their size.
        /// </summary>
        /// <remarks>>
        /// This is a workaround for the lack of ChangeResolution support in SDL2.
        /// When and if this changes upstream, we should remove this code.
        /// </remarks>
        public static bool UseFullscreenDesktop { get; set; }

        public Sdl2Factory()
        {
            UseFullscreenDesktop = true;
        }

        #region IPlatformFactory implementation

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new Sdl2NativeWindow(x, y, width, height, title, options, device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new Sdl2DisplayDeviceDriver();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new Sdl2GraphicsContext(mode, window, shareContext, major, minor, flags);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            throw new NotImplementedException();
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return Sdl2GraphicsContext.GetCurrentContext();
            };
        }

        public override IKeyboardDriver2 CreateKeyboardDriver()
        {
            return InputDriver.KeyboardDriver;
        }

        public override IMouseDriver2 CreateMouseDriver()
        {
            return InputDriver.MouseDriver;
        }

        public override IJoystickDriver2 CreateJoystickDriver()
        {
            return InputDriver.JoystickDriver;
        }

        #endregion

        #region IDisposable Members

        protected override void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    InputDriver.Dispose();
                }

                base.Dispose(manual);
            }
        }

        #endregion
    }
}

