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
using static OpenTK.Platform.Native.X11.XRandR.XRandR;
using OpenTK.Graphics.OpenGL;

namespace X11TestProject
{
    public class Program
    {
        public static void Main()
        {
            X11WindowComponent windowComp = new X11WindowComponent();
            X11OpenGLComponent glComp = new X11OpenGLComponent();
            X11DisplayComponent dispComp = new X11DisplayComponent();

            windowComp.Initialize(PalComponents.Window);
            glComp.Initialize(PalComponents.OpenGL);
            dispComp.Initialize(PalComponents.Display);

            XWindowHandle window = (XWindowHandle)windowComp.Create(new OpenGLGraphicsApiHints());
            XOpenGLContextHandle context = (XOpenGLContextHandle)glComp.CreateFromWindow(window);
            glComp.SetCurrentContext(context);

            XSelectInput(
                    X11.Display, window.Window,
                    XEventMask.StructureNotify |
                    XEventMask.SubstructureNotify |
                    XEventMask.VisibilityChanged
                    );

            // XGC gc = XCreateGC(layer.Display, window.Window, 0, IntPtr.Zero);
            // XSetBackground(layer.Display, gc, XWhitePixel(layer.Display, XDefaultScreen(layer.Display)));
            // XSetForeground(layer.Display, gc, XBlackPixel(layer.Display, XDefaultScreen(layer.Display)));
            //
            // XClearWindow(layer.Display, window.Window);
            XMapRaised(X11.Display, window.Window);

            GLLoader.LoadBindings(glComp.GetBindingsContext(context));

            // DisplayHandle handle = layer.CreatePrimary();
            XAtomDictionary dict = new XAtomDictionary(X11.Display);

            XEvent ea = new XEvent();
            int frames = 0;
            for (;;)
            {
                while (XEventsQueued(X11.Display, XEventsQueuedMode.QueuedAfterFlush) > 0)
                {
                    XNextEvent(X11.Display, out ea);
                    // Console.WriteLine(ea.Type);
                }

                windowComp.GetClientSize(window, out int width, out int height);

                GL.Viewport(0, 0, width, height);
                GL.ClearColor(1, 0, 1, 1);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                windowComp.SwapBuffers(window);

                windowComp.GetSize(window, out int w, out int h);
                windowComp.SetTitle(window, $"私はまだ日本語を話すことができません [{width},{height};{w},{h};frame={++frames}]");
                // layer.GetClientPosition(window, out int x, out int y);
                // Console.WriteLine("({0}, {1}) @ ({2}, {3})", width, height, x, y);
            }

            windowComp.Destroy(window);
        }
    }
}
