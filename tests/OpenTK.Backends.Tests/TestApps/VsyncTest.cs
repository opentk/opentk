using OpenTK.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System;

namespace OpenTK.Backends.Tests
{
    [TestApp]
    public class VsyncTest : ITestApp
    {
        public string Name => "Vsync test";

        private WindowHandle Window;
        private OpenGLContextHandle Context;

        private bool UseOpenGLES;

        private bool UseDwmFlush = false;

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            Window = window;
            Context = context;
            UseOpenGLES = useGLES;
        }

        public void HandleEvent(EventArgs args)
        {
            if (args is WindowResizeEventArgs resize)
            {
                var prevContext = Toolkit.OpenGL.GetCurrentContext();
                Toolkit.OpenGL.SetCurrentContext(Context);

                GL.Viewport(0, 0, resize.NewSize.X, resize.NewSize.Y);

                // Re-render the window to make resize live.
                Render();

                Toolkit.OpenGL.SetCurrentContext(prevContext);
            }
            else if (args is KeyDownEventArgs keyDown)
            {
                if (OperatingSystem.IsWindows())
                {
                    if (keyDown.Key == Key.V)
                    {
                        UseDwmFlush = !UseDwmFlush;
                        (Toolkit.OpenGL as OpenTK.Platform.Native.Windows.OpenGLComponent)?.UseDwmFlushIfApplicable(Context, UseDwmFlush);
                        Console.WriteLine($"DwmFlush: {UseDwmFlush}");
                    }
                }
            }
        }

        public bool Update(float deltaTime)
        {
            return false;
        }

        static readonly Color4<Rgba> Red = new Color4<Rgba>(1.0f, 0.0f, 0.0f, 1.0f);
        static readonly Color4<Rgba> Cyan = new Color4<Rgba>(0.0f, 1.0f, 1.0f, 1.0f);

        bool FlipFlop = false;

        public void Render()
        {
            if (FlipFlop)
            {
                FlipFlop = false;
                GL.ClearColor(Red);
            }
            else
            {
                FlipFlop = true;
                GL.ClearColor(Cyan);
            }

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

            Toolkit.OpenGL.SwapBuffers(Context);
        }

        public void Deinitialize()
        {
        }
    }
}
