using System;
using System.Diagnostics;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;

namespace OpenTK.Backends.Tests
{
    [TestApp("Color Wheel")]
    public class ColorWheel : ITestApp
    {
        public string Name => "Color Wheel";
        private Stopwatch watch = new Stopwatch();
        private WindowHandle window;
        private OpenGLContextHandle context;

        public void Deinitialize(bool cleanExit)
        {
            watch.Stop();
        }

        public void Initialize(WindowHandle window, OpenGLContextHandle context)
        {
            this.window = window;
            this.context = context;
            watch.Start();
        }

        public void Render()
        {
            const float OMEGA = 0.002f * MathF.PI * 0.1f;
            const float PHI   = MathF.PI/3;
            long elapsed = watch.ElapsedMilliseconds;

            GL.ClearColor(
                0.5f * MathF.Cos(OMEGA * elapsed + 0 * PHI) + 0.5f,
                0.5f * MathF.Cos(OMEGA * elapsed + 1 * PHI) + 0.5f,
                0.5f * MathF.Cos(OMEGA * elapsed + 2 * PHI) + 0.5f,
                1.0f
            );
            GL.Clear(ClearBufferMask.ColorBufferBit);

            Program.WindowComp.SwapBuffers(window);
        }
    }
}