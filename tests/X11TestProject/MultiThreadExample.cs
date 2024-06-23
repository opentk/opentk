using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.Windows;

namespace X11TestProject
{
    public class MultiThreadExample
    {
        private static WindowThread? A;
        private static WindowThread? B;
        public static readonly ConcurrentQueue<Task> XTasks = new ConcurrentQueue<Task>();

        // MAIN THREAD:
        public static void MultiThreadMain()
        {
            IWindowComponent windowComp = PlatformComponents.CreateWindowComponent();
            IOpenGLComponent glComp = PlatformComponents.CreateOpenGLComponent();
            IDisplayComponent dispComp = PlatformComponents.CreateDisplayComponent();
            IShellComponent shellComp = PlatformComponents.CreateShellComponent();

            ToolkitOptions options = new ToolkitOptions() { Logger = new ConsoleLogger() };
            windowComp.Initialize(options);
            glComp.Initialize(options);
            dispComp.Initialize(options);
            shellComp.Initialize(options);

            var memInfo = shellComp.GetSystemMemoryInformation();
            Console.WriteLine($"Total RAM: {memInfo.TotalPhysicalMemory}");
            Console.WriteLine($"Available RAM: {memInfo.AvailablePhysicalMemory}");

            A = new WindowThread(windowComp, glComp, 0);
            B = new WindowThread(windowComp, glComp, MathF.PI);

            A.Start();
            B.Start();

            EventQueue.EventRaised += (handle, type, args) =>
            {
                if (args is CloseEventArgs close)
                {
                    windowComp.Destroy(close.Window);
                }
            };

            while(!A.Done || !B.Done)
            {
                windowComp.ProcessEvents();

                if (XTasks.TryDequeue(out Task? task))
                {
                    task.RunSynchronously();
                }
            }
        }

        public static Task Invoke(Task task)
        {
            XTasks.Enqueue(task);
            return task;
        }
    }

    public class WindowThread
    {
        private IWindowComponent WindowComponent;
        private IOpenGLComponent OpenGLComponent;

        private readonly Stopwatch _watch = new Stopwatch();
        private readonly float _phase;

        public Thread? Thread { get; private set; }

        public bool Done { get; private set; }

        public WindowThread(IWindowComponent windowComponent, IOpenGLComponent openGLComponent, float phase)
        {
            WindowComponent = windowComponent;
            OpenGLComponent = openGLComponent;
            _phase = phase;
        }

        public void Start()
        {
            Thread = new Thread(StartFunction);
            Thread.Start();
        }

        private Color4<Rgba> GetColor()
        {
            Color4<Rgba> retval;
            retval.X = 0.5f * MathF.Cos( (float)_watch.ElapsedMilliseconds / 1000 + _phase) + 0.5f;
            retval.Y = 0.5f * MathF.Cos((float)_watch.ElapsedMilliseconds / 1000 + _phase + MathF.PI/3) + 0.5f;
            retval.Z = 0.5f * MathF.Cos((float)_watch.ElapsedMilliseconds / 1000 + _phase + 2*MathF.PI/3) + 0.5f;
            retval.W = 1;
            return retval;
        }

        private async void StartFunction()
        {
            WindowHandle? window = null;
            OpenGLContextHandle? context = null;
            EventQueue queue = EventQueue.Subscribe();
            queue.EventDispatched += (handle, type, args) => Console.WriteLine("{0} {1} {2}", handle, type, args);

            Task invokeX11Actions = new Task(() =>
            {
                window = WindowComponent.Create(new OpenGLGraphicsApiHints());
                context = OpenGLComponent.CreateFromWindow(window);

                WindowComponent.SetSize(window, 800, 600);
                WindowComponent.SetMode(window, WindowMode.Normal);
            });

            MultiThreadExample.XTasks.Enqueue(invokeX11Actions);
            await invokeX11Actions;

            OpenGLComponent.SetCurrentContext(context);
            GLLoader.LoadBindings(OpenGLComponent.GetBindingsContext(context!));

            _watch.Start();
            while (WindowComponent.IsWindowDestroyed(window) == false)
            {
                OpenGLComponent.SetCurrentContext(context);
                Color4<Rgba> color = GetColor();
                GL.ClearColor(color);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                await MultiThreadExample.Invoke(
                    new Task(() => { if (WindowComponent.IsWindowDestroyed(window) == false) OpenGLComponent.SwapBuffers(context); })
                    );
            }

            Done = true;
        }
    }
}
