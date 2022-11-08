using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using OpenTK;
using OpenTK.Core.Platform;
using OpenTK.Graphics;
using OpenTK.Platform.Native.X11;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.XRandR;
using OpenTK.Graphics.OpenGL;

namespace X11TestProject
{
    public class Program
    {
        public static void Main()
        {
            X11AbstractionLayer layer = new X11AbstractionLayer();
            layer.Initialize(PalComponents.Window | PalComponents.OpenGL | PalComponents.Display);
            IWindowComponent windowComponent = layer;
            XWindowHandle window = (XWindowHandle)layer.Create(new OpenGLGraphicsApiHints());
            XOpenGLContextHandle context = (XOpenGLContextHandle)layer.CreateFromWindow(window);
            layer.SetCurrentContext(context);

            XSelectInput(
                layer.Display, window.Window,
                    XEventMask.StructureNotify |
                    XEventMask.SubstructureNotify |
                    XEventMask.VisibilityChanged
                    );

            // XGC gc = XCreateGC(layer.Display, window.Window, 0, IntPtr.Zero);
            // XSetBackground(layer.Display, gc, XWhitePixel(layer.Display, XDefaultScreen(layer.Display)));
            // XSetForeground(layer.Display, gc, XBlackPixel(layer.Display, XDefaultScreen(layer.Display)));
            //
            // XClearWindow(layer.Display, window.Window);
            XMapRaised(layer.Display, window.Window);

            GLLoader.LoadBindings(new TestBindingsContext(layer, context));

            // DisplayHandle handle = layer.CreatePrimary();
            XAtomDictionary dict = new XAtomDictionary(layer.Display);

            XEvent ea = new XEvent();
            int frames = 0;
            for (;;)
            {
                while (XEventsQueued(layer.Display, XEventsQueuedMode.QueuedAfterFlush) > 0)
                {
                    XNextEvent(layer.Display, out ea);
                    // Console.WriteLine(ea.Type);
                }

                layer.GetClientSize(window, out int width, out int height);

                GL.Viewport(0, 0, width, height);
                GL.ClearColor(1, 0, 1, 1);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                GLX.glXSwapBuffers(window.Display, window.Window);

                layer.GetSize(window, out int w, out int h);
                layer.SetTitle(window, $"私はまだ日本語を話すことができません [{width},{height};{w},{h};frame={++frames}]");
                // layer.GetClientPosition(window, out int x, out int y);
                // Console.WriteLine("({0}, {1}) @ ({2}, {3})", width, height, x, y);
            }

            layer.Destroy(window);
        }

        public class TestBindingsContext : IBindingsContext
        {
            private IPalComponent pal;
            private OpenGLContextHandle context;

            public TestBindingsContext(IPalComponent pal, OpenGLContextHandle context)
            {
                this.pal = pal;
                this.context = context;
            }

            public IntPtr GetProcAddress(string procName)
            {
                IntPtr retval = (pal as IOpenGLComponent).GetProcedureAddress(context, procName);
                Debug.WriteLine("GetProcAddr {0} = {1}", procName, retval);
                return retval;
            }
        }
    }
}
