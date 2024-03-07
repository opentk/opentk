using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace LocalTest
{
    class Window : GameWindow
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            while (true)
            {
                Color4<Hsla> hsla1 = NextColor();
                Color4<Hsva> hsva = hsla1.ToHsva();
                Color4<Hsla> hsla2 = hsva.ToHsla();

                if (!MathHelper.ApproximatelyEquivalent(hsla1.X, hsla2.X, 1e-3) ||
                    !MathHelper.ApproximatelyEquivalent(hsla1.Y, hsla2.Y, 1e-3) ||
                    !MathHelper.ApproximatelyEquivalent(hsla1.Z, hsla2.Z, 1e-3) ||
                    !MathHelper.ApproximatelyEquivalent(hsla1.W, hsla2.W, 1e-3))
                {
                    ;
                }
            }
            return;


            Color4<Hsla> NextColor()
            {
                return new Color4<Hsla>(rand.NextSingle(), rand.NextSingle(), rand.NextSingle(), 1);
            }

            GameWindowSettings gwSettings = new GameWindowSettings()
            {
                UpdateFrequency = 250,
            };

            NativeWindowSettings nwSettings = new NativeWindowSettings()
            {
                API = ContextAPI.OpenGL,
                APIVersion = new Version(3, 3),
                AutoLoadBindings = true,
                Flags = ContextFlags.Debug | ContextFlags.ForwardCompatible,
                IsEventDriven = false,
                Profile = ContextProfile.Core,
                ClientSize = (800, 600),
                StartFocused = true,
                StartVisible = true,
                Title = "Local OpenTK Test",
                WindowBorder = WindowBorder.Resizable,
                WindowState = WindowState.Normal,
            };

            using (Window window = new Window(gwSettings, nwSettings))
            {
                window.Run();
            }
        }

        public Window(GameWindowSettings gwSettings, NativeWindowSettings nwSettings) : base(gwSettings, nwSettings)
        {
        }

        protected override void OnLoad()
        {
            base.OnLoad();
        }

        protected override void OnUnload()
        {
            base.OnUnload();
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }

        float time = 0;

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);

            const float CycleTime = 8.0f;

            time += (float)args.Time;
            if (time > CycleTime) time = 0;

            Color4<Rgba> color = new Color4<Hsva>(time / CycleTime, 1, 1, 1).ToRgba();

            GL.ClearColor(color);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SwapBuffers();
        }

        protected override void OnFramebufferResize(FramebufferResizeEventArgs e)
        {
            base.OnFramebufferResize(e);

            GL.Viewport(0, 0, e.Width, e.Height);
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnMove(WindowPositionEventArgs e)
        {
            base.OnMove(e);
        }
    }
}
