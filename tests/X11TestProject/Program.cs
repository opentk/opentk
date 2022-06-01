using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Platform.Native.X11;
using static OpenTK.Platform.Native.X11.LibX11;

namespace X11TestProject
{
    public class Program
    {
        public static void Main()
        {
            X11AbstractionLayer layer = new X11AbstractionLayer();
            layer.Initialize(PalComponents.Window);
            IWindowComponent windowComponent = layer;
            XWindowHandle window = (XWindowHandle)layer.Create();

            XSelectInput(layer.Display, window.Window, (1 << 15) | (1 << 2) | (1 << 0));

            XGC gc = XCreateGC(layer.Display, window.Window, 0, IntPtr.Zero);
            XSetBackground(layer.Display, gc, XWhitePixel(layer.Display, XDefaultScreen(layer.Display)));
            XSetForeground(layer.Display, gc, XBlackPixel(layer.Display, XDefaultScreen(layer.Display)));

            XClearWindow(layer.Display, window.Window);
            XMapRaised(layer.Display, window.Window);


            IntPtr arr = Marshal.AllocHGlobal(1024);
            for (;;)
            {
                XNextEvent(layer.Display, arr);
                XClearWindow(layer.Display, window.Window);
            }

            layer.Destroy(window);
        }
    }
}
