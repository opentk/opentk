using OpenTK.Core.Native;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.Vulkan;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Common.Input;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace LocalTest
{
    class Window : GameWindow
    {
        static void Main(string[] args)
        {
            Vector2 a = (1E-45f, -5.9167414f);
            Vector2 b = (1E-45f, 13.882292f);
            Vector2 c = Vector2.Slerp(a, b, 0);
            Vector2 d = Vector2.Slerp(a, b, 1);

            var res = Vector3.Elerp((1e-45f, 1, 1), (1, 1, 4), 0.3f);
            
            GameWindowSettings gwSettings = new GameWindowSettings()
            {
                UpdateFrequency = 250,
            };

            NativeWindowSettings nwSettings = new NativeWindowSettings()
            {
                API = ContextAPI.NoAPI,
                //APIVersion = new Version(3, 3),
                AutoLoadBindings = true,
                Flags = 0,
                IsEventDriven = false,
                Profile = 0,
                ClientSize = (800, 600),
                StartFocused = true,
                StartVisible = true,
                Title = "OpenTK Vulkan Bindings Test",
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

        protected unsafe override void OnLoad()
        {
            base.OnLoad();

            string ver = GLFW.GetVersionString();
            Console.WriteLine($"GLFW version: {ver}");
        }

        protected unsafe override void OnUnload()
        {
            base.OnUnload();
        }

        protected unsafe override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }

        const float CycleTime = 8.0f;
        float Time = 0;

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);

            Time += (float)args.Time;
            if (Time > CycleTime) Time = 0;

            Color4<Rgba> color = new Color4<Hsva>(Time / CycleTime, 1, 1, 1).ToRgba();

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
