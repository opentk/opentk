using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System;
using System.Linq;

namespace LocalTest
{
    class Window : GameWindow
    {
        static void Main(string[] args)
        {
            GameWindowSettings gwSettings = new GameWindowSettings()
            {
                UpdateFrequency = 250,
                //RenderFrequency = 10, Obsolete as of 4.8.1
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
                //Size = (800, 600), Obsolete as of 4.8.2
                StartFocused = true,
                StartVisible = true,
                Title = "Local OpenTK Test",
                WindowBorder = WindowBorder.Resizable,
                WindowState = WindowState.Normal,
            };

            using Window window = new Window(gwSettings, nwSettings);
            window.Run();
        }

        public Window(GameWindowSettings gwSettings, NativeWindowSettings nwSettings) : base(gwSettings, nwSettings)
        {
            Console.WriteLine("\nGameWindowSettings:");
            DumpProperties(gwSettings);
            Console.WriteLine("\nNativeWindowSettings:");
            DumpProperties(nwSettings);

            void DumpProperties(object o)
            {
                var properties = o.GetType().GetProperties().OrderBy(p => p.Name).ToList();
                foreach(var prop in properties)
                {
                    var attribs = prop.GetCustomAttributes(typeof(ObsoleteAttribute), true);
                    if(attribs.Length == 0) // ignore obsolete properties, including inherited ones
                        Console.WriteLine($"  {prop.Name} = {prop.GetValue(o)}");
                }
            }
        }

        protected override void OnLoad()
        {
            base.OnLoad();
        }

        protected override void OnUnload()
        {
            base.OnUnload();
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

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
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
