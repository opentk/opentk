using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Common.Input;
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

            var res = Vector3.Elerp((1e-45f, 1, 1), (1, 1, 4), 0.3f);

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

            string ver = GLFW.GetVersionString();
            Console.WriteLine($"GLFW version: {ver}");
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

            Color4 color = Color4.FromHsv(new Vector4(time / CycleTime, 1, 1, 1));

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
