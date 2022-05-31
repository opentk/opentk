using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Platform.Native.X11;
using static OpenTK.Platform.Native.X11.LibX11;

namespace X11TestProject
{
    public class Program
    {
        public static void Main()
        {
            int screen = XDefaultScreen(DefaultDisplay);
            ulong black = XBlackPixel(DefaultDisplay, screen);
            ulong white = XWhitePixel(DefaultDisplay, screen);
            XWindow window = XCreateSimpleWindow(
                DefaultDisplay,
                XDefaultRootWindow(DefaultDisplay),
                0, 0,
                300, 200,
                5,
                black);
            XSetStandardProperties(
                DefaultDisplay,
                window,
                "X11 Test Window",
                "ICO",
                XPixMap.None,
                IntPtr.Zero,
                0,
                ref Unsafe.NullRef<XSizeHints>());
            XSelectInput(DefaultDisplay, window, (1 << 15) | (1 << 2) | (1 << 0));

            XGC gc = XCreateGC(DefaultDisplay, new XDrawable(window.Id), 0, IntPtr.Zero);
            XSetBackground(DefaultDisplay, gc, white);
            XSetForeground(DefaultDisplay, gc, black);

            XClearWindow(DefaultDisplay, window);
            XMapRaised(DefaultDisplay, window);


            IntPtr arr = Marshal.AllocHGlobal(1024);
            for (;;)
            {
                XNextEvent(DefaultDisplay, arr);
                XClearWindow(DefaultDisplay, window);
            }

            XFreeGC(DefaultDisplay, gc);
            XDestroyWindow(DefaultDisplay, window);
            XCloseDisplay(DefaultDisplay);
        }
    }
}
