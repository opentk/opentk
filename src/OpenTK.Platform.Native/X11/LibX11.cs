using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Wrapper for the native library libX11.so.
    /// </summary>
    public static class LibX11
    {
        private const string X11 = "X11";

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XDisplayPtr XOpenDisplay([MarshalAs(UnmanagedType.LPStr)]string? name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDefaultScreen(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong XBlackPixel(XDisplayPtr display, int screenNumber);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong XWhitePixel(XDisplayPtr display, int screenNumber);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XWindow XCreateSimpleWindow(
            XDisplayPtr display,
            XWindow parent,
            int x,
            int y,
            uint width,
            uint height,
            ulong border,
            ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XWindow XCreateWindow(
            XDisplayPtr display,
            XWindow parent,
            int x,
            int y,
            uint width,
            uint height,
            uint border,
            int depth,
            uint @class,
            ref XVisual visual,
            ulong valueMask,
            ref XSetWindowAttributes attributes);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSelectInput(XDisplayPtr display, XWindow xWindow, XEventMask events);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XWindow XDefaultRootWindow(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetStandardProperties(
            XDisplayPtr display,
            XWindow window,
            [MarshalAs(UnmanagedType.LPStr)]string windowName,
            [MarshalAs(UnmanagedType.LPStr)]string iconName,
            XPixMap iconPixmap,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[]? argv,
            int argc,
            ref XSizeHints hints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XGC XCreateGC(XDisplayPtr display, XDrawable drawable, long valueMask,
            IntPtr values);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetBackground(XDisplayPtr display, XGC gc, ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetForeground(XDisplayPtr display, XGC gc, ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XClearWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XMapRaised(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeGC(XDisplayPtr display, XGC gc);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XDestroyWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XCloseDisplay(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XNextEvent(XDisplayPtr display, out XEvent @event);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFree(IntPtr pointer);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XColorMap XCreateColormap(XDisplayPtr display, XWindow window, ref XVisual visual,
            int alloc);
    }
}
