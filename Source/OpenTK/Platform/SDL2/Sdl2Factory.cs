using System;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2Factory : IPlatformFactory
    {
        public Sdl2Factory()
        {
        }

        #region IPlatformFactory implementation

        public INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new Sdl2NativeWindow(x, y, width, height, title, options, device);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new Sdl2DisplayDeviceDriver();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new Sdl2GraphicsContext(mode, (Sdl2WindowInfo)window, shareContext, major, minor, flags);
        }

        public IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            throw new NotImplementedException();
        }

        public GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext()
        {
            // Unfortunately, SDL does not provide a GetContext function
            // so we need to implement our own.
            return (GraphicsContext.GetCurrentContextDelegate)delegate
            {
                IntPtr current;
                if (Configuration.RunningOnWindows)
                    current = OpenTK.Platform.Windows.Wgl.GetCurrentContext();
                else if (Configuration.RunningOnX11)
                    current = OpenTK.Platform.X11.Glx.GetCurrentContext();
                else if (Configuration.RunningOnMacOS)
                    current = OpenTK.Platform.MacOS.Cgl.GetCurrentContext();
                else
                    throw new NotSupportedException("Unknown platform, please report to http://www.opentk.com");

                return new ContextHandle(current);
            };
        }

        public IGraphicsMode CreateGraphicsMode()
        {
            return new Sdl2GraphicsMode();
        }

        public IKeyboardDriver2 CreateKeyboardDriver()
        {
            return new Sdl2Keyboard();
        }

        public IMouseDriver2 CreateMouseDriver()
        {
            return new Sdl2Mouse();
        }

        public IGamePadDriver CreateGamePadDriver()
        {
            return new Sdl2Joystick();
        }

        #endregion
    }
}

