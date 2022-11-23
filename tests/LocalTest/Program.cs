using OpenTK.Core;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.Diagnostics;
using System.Threading;

namespace LocalTest
{
    class Window : GameWindow
    {
        static void Main(string[] args)
        {
            GameWindowSettings gwSettings = new GameWindowSettings()
            {
                UpdateFrequency = 100,
            };

            NativeWindowSettings nwSettings = new NativeWindowSettings()
            {
                API = ContextAPI.OpenGL,
                APIVersion = new Version(3, 3),
                AutoLoadBindings = true,
                Flags = ContextFlags.Debug | ContextFlags.ForwardCompatible,
                IsEventDriven = false,
                Profile = ContextProfile.Core,
                Size = (800, 600),
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

            VSync = VSyncMode.Off;

            watch.Start();
        }

        double timer, timer2;
        int frames;

        Utils.SleepTimings timings = new Utils.SleepTimings(2);

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);

            GL.ClearColor(Color4.Coral);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SwapBuffers();
        }

        Stopwatch watch = new Stopwatch();
        Stopwatch watch2 = new Stopwatch();
        bool sync = true;
        double initialDiff = 0;

        int n = 0;
        double sum = 0;
        double sumOfSquares = 0;
        double mean = 0;
        double variance = 0;

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);

            if (sync)
            {
                double time = watch.ElapsedTicks / (double)Stopwatch.Frequency;
                initialDiff = time - args.Time;

                sync = false;

                watch2.Start();
            }

            frames++;

            n++;
            sum += args.Time * 1000;
            sumOfSquares += args.Time * args.Time * 1000_000;

            mean = sum / n;

            variance = (sumOfSquares / n) - (mean * mean);

            timer += watch2.Elapsed.TotalSeconds;
            watch2.Restart();
            timer2 += args.Time;
            if (timer >= 1.0)
            {
                Console.WriteLine($"fps {frames}");
                frames = 0;
                timer = 0;

                var diff = timer2 - watch.Elapsed.TotalSeconds;

                //Console.WriteLine($"opentk {timer2:0.00000} | stopwatch {watch.Elapsed.TotalSeconds:0.00000} | diff {diff:0.00000} | drift {initialDiff - diff:0.00000}");

                //Console.WriteLine($"Time {sum/1000d}s, Mean frame time: {mean}ms, Frame time variance: {variance}");
            }
        }
    }
}
