using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Wrapper for the native library libX11.so.
    /// </summary>
    public static class LibX11
    {
        private const string X11 = "X11";

        static LibX11()
        {
            DllResolver.InitLoader();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int XErrorHandler(XDisplayPtr display, XErrorEvent* error_event);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSetErrorHandler(XErrorHandler handler);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XGetErrorText(XDisplayPtr display, int code, [Out, MarshalAs(UnmanagedType.LPUTF8Str)] StringBuilder buffer_return, int length);

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
            XWindowAttributeValueMask valueMask,
            ref XSetWindowAttributes attributes);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XConfigureWindow(XDisplayPtr display, XWindow w, XWindowChangesMask value_mask, ref XWindowChanges values);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XMoveWindow(XDisplayPtr display, XWindow w, int x, int y);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XResizeWindow(XDisplayPtr display, XWindow w, int width, int height);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void XSetWMNormalHints(XDisplayPtr display, XWindow w, XSizeHints* hints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern int /* Status */ XGetWMNormalHints(XDisplayPtr display, XWindow w, XSizeHints* hints_return, XSizeHintFlags* supplied_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern XSizeHints* XAllocSizeHints();

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
        public static unsafe extern int XFree(void* pointer);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XColorMap XCreateColormap(
            XDisplayPtr display,
            XWindow window,
            ref XVisual visual,
            int alloc);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XColorMap XDefaultColormap(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFreeColormap(XDisplayPtr display, XColorMap colormap);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XStoreName(XDisplayPtr display, XWindow window, [MarshalAs(UnmanagedType.LPStr)]string name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWindowAttributes(
            XDisplayPtr display,
            XWindow window,
            out XWindowAttributes attributes);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XTranslateCoordinates(
            XDisplayPtr display,
            XWindow source,
            XWindow destination,
            int sourceX,
            int sourceY,
            out int destinationX,
            out int destinationY,
            out XWindow child);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XSendEvent(
            XDisplayPtr display,
            XWindow window,
            int propagate,
            XEventMask eventMask,
            in XEvent ea);


        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XEventsQueued(XDisplayPtr display, XEventsQueuedMode mode);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XFetchName(XDisplayPtr display, XWindow window, out IntPtr name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern XAtom XInternAtom(XDisplayPtr display, string atomName, bool onlyIfExists);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XInternAtoms(
            XDisplayPtr display,
            ref IntPtr names,
            int count,
            bool onlyIfExists,
            ref XAtom atoms);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr XGetAtomName(XDisplayPtr display, XAtom atom);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XGetWindowProperty(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            long offset,
            long length,
            bool delete,
            XAtom requestType,
            out XAtom actualType,
            out int actualFormat,
            out long numberOfItems,
            out long remainingBytes,
            out IntPtr contents
        );

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int XChangeProperty(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            XAtom propertyType,
            int format,
            XPropertyMode mode,
            IntPtr data,
            int elements
        );

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XSetInputFocus(XDisplayPtr display, XWindow focus, RevertTo revert_to, XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XRaiseWindow(XDisplayPtr display, XWindow w);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern void XFlush(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        public static extern int /* Status */ XSetWMProtocols(XDisplayPtr display, XWindow w, [In] XAtom[] protocols, int count);
    }
}
