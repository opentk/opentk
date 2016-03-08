// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform.MacOS
{
    using Graphics;

    class MacOSFactory : PlatformFactoryBase
    {
        // Todo: we can query the exact amount via
        // CGEventSourceGetPixelsPerLine. This is
        // approximately 0.1f
        internal const float ScrollFactor = 0.1f;
        internal static bool ExclusiveFullscreen = false;

        readonly IInputDriver2 InputDriver;

        public MacOSFactory()
        {
            NSApplication.Initialize();
            InputDriver = new HIDInput();
        }

        #region IPlatformFactory Members

        public override INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new CocoaNativeWindow(x, y, width, height, title, mode, options, device);
        }

        public override IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new QuartzDisplayDeviceDriver();
        }

        public override IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new CocoaContext(mode, window, shareContext, major, minor);
        }

        public override IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new CocoaContext(handle, window, shareContext, major, minor);
        }

        public override GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                return new ContextHandle(CocoaContext.CurrentContext);
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

        public override OpenTK.Input.IGamePadDriver CreateGamePadDriver()
        {
            return new MappedGamePadDriver();
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
