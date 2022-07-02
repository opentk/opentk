using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using OpenTK.Core.Platform;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native.X11;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.GLX;

namespace X11TestProject
{
    public class MultiThreadExample
    {
        private static WindowThread? A;
        private static WindowThread? B;
        public static readonly ConcurrentQueue<Task> XTasks = new ConcurrentQueue<Task>();

        // MAIN THREAD:
        public static void Main()
        {
            X11AbstractionLayer layer = new X11AbstractionLayer();
            layer.Initialize(PalComponents.Window | PalComponents.OpenGL);

            A = new WindowThread(layer, 0);
            B = new WindowThread(layer, MathF.PI);

            A.Start();
            B.Start();
            for (;;)
            {
                while (XEventsQueued(layer.Display, XEventsQueuedMode.QueuedAfterFlush) > 0)
                {
                    XNextEvent(layer.Display, out XEvent ea);
                    EventQueue.Raise(null, (PlatformEventType)ea.Type, EventArgs.Empty);
                }

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
        private readonly IPalComponent _layer;
        private IWindowComponent WindowComponent => (IWindowComponent)_layer;
        private IOpenGLComponent OpenGLComponent => (IOpenGLComponent)_layer;

        private readonly Stopwatch _watch = new Stopwatch();
        private readonly float _phase;

        public Thread? Thread { get; private set; }

        public WindowThread(IPalComponent layer, float phase)
        {
            _layer = layer;
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
                X11AbstractionLayer layer = (X11AbstractionLayer)_layer;
                XWindowHandle wnd = (XWindowHandle)window;

                XSelectInput(layer.Display, wnd.Window, XEventMask.All);
                XMapRaised(layer.Display, wnd.Window);
            });

            MultiThreadExample.XTasks.Enqueue(invokeX11Actions);
            await invokeX11Actions;

            OpenGLComponent.SetCurrentContext(context);
            GLLoader.LoadBindings(new Program.TestBindingsContext(_layer, context));

            _watch.Start();
            for (;;)
            {
                queue.DispatchEvents();

                OpenGLComponent.SetCurrentContext(context);
                Color4<Rgba> color = GetColor();
                GL.ClearColor(color);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                await MultiThreadExample.Invoke(
                    new Task(() => glXSwapBuffers((_layer as X11AbstractionLayer).Display, (window as XWindowHandle).Window))
                    );
            }
        }
    }
}
