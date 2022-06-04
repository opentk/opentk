using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Core.Platform;
using OpenTK.Graphics;
using OpenTK.Platform.Native.X11;
using static OpenTK.Platform.Native.X11.LibX11;
using OpenTK.Graphics.OpenGL;

namespace X11TestProject
{
    public class Program
    {
        public static void Main()
        {
            X11AbstractionLayer layer = new X11AbstractionLayer();
            layer.Initialize(PalComponents.Window | PalComponents.OpenGL);
            IWindowComponent windowComponent = layer;
            XWindowHandle window = (XWindowHandle)layer.Create(new OpenGLGraphicsApiHints());
            XOpenGLContextHandle context = (XOpenGLContextHandle)layer.CreateFromWindow(window);
            layer.SetCurrentContext(context);

            XSelectInput(layer.Display, window.Window, XEventMask.All);

            // XGC gc = XCreateGC(layer.Display, window.Window, 0, IntPtr.Zero);
            // XSetBackground(layer.Display, gc, XWhitePixel(layer.Display, XDefaultScreen(layer.Display)));
            // XSetForeground(layer.Display, gc, XBlackPixel(layer.Display, XDefaultScreen(layer.Display)));
            //
            // XClearWindow(layer.Display, window.Window);
            XMapRaised(layer.Display, window.Window);

            GLLoader.LoadBindings(new TestBindingsContext(layer, context));

            XEvent ea;
            for (;;)
            {
                XNextEvent(layer.Display, out ea);
                // XClearWindow(layer.Display, window.Window);

                GL.ClearColor(1, 0, 1, 1);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                GLX.glXSwapBuffers(window.Display, window.Window);

                Console.WriteLine(ea.Type);
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
                return (pal as IOpenGLComponent).GetProcedureAddress(context, procName);
            }
        }
    }
}
