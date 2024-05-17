using System;
using System.Diagnostics;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;

namespace OpenTK.Backends.Tests
{
    [TestApp]
    public class ColorWheel : ITestApp
    {
        public string Name => "Color Wheel";

        public WindowHandle Window;
        public OpenGLContextHandle Context;

        private Stopwatch watch = new Stopwatch();

        public void Initialize(WindowHandle window, OpenGLContextHandle context, bool useGLES)
        {
            this.Window = window;
            this.Context = context;
            watch.Start();
        }

        public void HandleEvent(EventArgs args)
        {
            // FIXME: Handle resize?
        }

        public bool Update(float deltaTime)
        {
            return false;
        }

        public void Render()
        {
            const float OMEGA = 0.002f * MathF.PI * 0.1f;
            const float PHI = MathF.PI / 3;
            long elapsed = watch.ElapsedMilliseconds;

            GL.ClearColor(
                0.5f * MathF.Cos(OMEGA * elapsed + 0 * PHI) + 0.5f,
                0.5f * MathF.Cos(OMEGA * elapsed + 1 * PHI) + 0.5f,
                0.5f * MathF.Cos(OMEGA * elapsed + 2 * PHI) + 0.5f,
                1.0f
            );
            GL.Clear(ClearBufferMask.ColorBufferBit);

            Program.OpenGLComp.SwapBuffers(Context);
        }

        public void Deinitialize()
        {
            watch.Stop();
        }
    }
}
