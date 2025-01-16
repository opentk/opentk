using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Wrapper for the native library libX11.so.
    /// </summary>
    internal static class LibX11
    {
        private const string X11 = "X11";

        static LibX11()
        {
            DllResolver.InitLoader();
        }

        public const int Success = 0;

        public const int False = 0;
        public const int True = 1;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal unsafe delegate int XErrorHandler(XDisplayPtr display, XErrorEvent* error_event);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSetErrorHandler(XErrorHandler handler);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XGetErrorText(XDisplayPtr display, int code, [Out, MarshalAs(UnmanagedType.LPUTF8Str)] StringBuilder buffer_return, int length);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XDisplayPtr XOpenDisplay([MarshalAs(UnmanagedType.LPStr)] string? name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDefaultScreen(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XVisual* XDefaultVisual(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XVisualId XVisualIDFromVisual(XVisual* visual);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XScreenCount(XDisplayPtr dispay);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong XBlackPixel(XDisplayPtr display, int screenNumber);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong XWhitePixel(XDisplayPtr display, int screenNumber);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XCreateSimpleWindow(
            XDisplayPtr display,
            XWindow parent,
            int x,
            int y,
            uint width,
            uint height,
            ulong border,
            ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XCreateWindow(
            XDisplayPtr display,
            XWindow parent,
            int x,
            int y,
            uint width,
            uint height,
            uint border,
            int depth,
            WindowClass @class,
            ref XVisual visual,
            XWindowAttributeValueMask valueMask,
            ref XSetWindowAttributes attributes);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XConfigureWindow(XDisplayPtr display, XWindow w, XWindowChangesMask value_mask, ref XWindowChanges values);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XMoveWindow(XDisplayPtr display, XWindow w, int x, int y);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XResizeWindow(XDisplayPtr display, XWindow w, int width, int height);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XMoveResizeWindow(XDisplayPtr display, XWindow w, int x, int y, uint width, uint height);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDisplayWidth(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDisplayHeight(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XSetWMNormalHints(XDisplayPtr display, XWindow w, XSizeHints* hints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int /* Status */ XGetWMNormalHints(XDisplayPtr display, XWindow w, XSizeHints* hints_return, XSizeHintFlags* supplied_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XWMHints* XAllocWMHints();

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XWMHints* XGetWMHints(XDisplayPtr display, XWindow w);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XSetWMHints(XDisplayPtr display, XWindow w, XWMHints* wmhints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XSizeHints* XAllocSizeHints();

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XClassHint* XAllocClassHint();

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XSetClassHint(XDisplayPtr display, XWindow w, XClassHint* class_hints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSelectInput(XDisplayPtr display, XWindow xWindow, XEventMask events);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XDefaultRootWindow(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XWindow XRootWindow(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XSetStandardProperties(
            XDisplayPtr display,
            XWindow window,
            [MarshalAs(UnmanagedType.LPStr)] string windowName,
            [MarshalAs(UnmanagedType.LPStr)] string iconName,
            XPixmap iconPixmap,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[]? argv,
            int argc,
            ref XSizeHints hints);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XGC XCreateGC(XDisplayPtr display, XDrawable drawable, long valueMask,
            IntPtr values);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSetBackground(XDisplayPtr display, XGC gc, ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSetForeground(XDisplayPtr display, XGC gc, ulong background);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XClearWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XMapRaised(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XMapWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XUnmapWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XWithdrawWindow(XDisplayPtr display, XWindow w, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFreeGC(XDisplayPtr display, XGC gc);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDestroyWindow(XDisplayPtr display, XWindow window);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XCloseDisplay(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XNextEvent(XDisplayPtr display, out XEvent @event);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XPutBackEvent(XDisplayPtr display, in XEvent @event);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFree(IntPtr pointer);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int XFree(void* pointer);

        internal static unsafe int XFree<T>(Span<T> span)
        {
            return XFree(Unsafe.AsPointer(ref MemoryMarshal.GetReference(span)));
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XColorMap XCreateColormap(
            XDisplayPtr display,
            XWindow window,
            ref XVisual visual,
            int alloc);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XColorMap XDefaultColormap(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XDefaultDepth(XDisplayPtr display, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFreeColormap(XDisplayPtr display, XColorMap colormap);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XGetWindowAttributes(
            XDisplayPtr display,
            XWindow window,
            out XWindowAttributes attributes);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XTranslateCoordinates(
            XDisplayPtr display,
            XWindow source,
            XWindow destination,
            int sourceX,
            int sourceY,
            out int destinationX,
            out int destinationY,
            out XWindow child);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSendEvent(
            XDisplayPtr display,
            XWindow window,
            int propagate,
            XEventMask eventMask,
            in XEvent ea);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XEventsQueued(XDisplayPtr display, XEventsQueuedMode mode);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XFetchName(XDisplayPtr display, XWindow window, out IntPtr name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XStoreName(XDisplayPtr display, XWindow window, [MarshalAs(UnmanagedType.LPStr)] string name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XStatus XGetIconName(XDisplayPtr display, XWindow w, out IntPtr icon_name_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void XSetIconName(XDisplayPtr display, XWindow w, [MarshalAs(UnmanagedType.LPStr)] string name);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XAtom XInternAtom(XDisplayPtr display, string atomName, bool onlyIfExists);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XInternAtoms(
            XDisplayPtr display,
            ref IntPtr names,
            int count,
            bool onlyIfExists,
            ref XAtom atoms);


        internal static unsafe string XGetAtomName(XDisplayPtr display, XAtom atom)
        {

            byte* namePtr = XGetAtomName(display, atom);
            string name = Marshal.PtrToStringUTF8((IntPtr)namePtr) ?? "";
            if (namePtr != null)
            {
                XFree(namePtr);
            }
            return name;

            // FIXME: Make a managed copy and free the native string?
            [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
            static extern byte* XGetAtomName(XDisplayPtr display, XAtom atom);
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XGetWindowProperty(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            long offset,
            long length,
            [MarshalAs(UnmanagedType.I1)] bool delete,
            XAtom requestType,
            out XAtom actualType,
            out int actualFormat,
            out long numberOfItems,
            out long remainingBytes,
            out IntPtr contents
        );

        internal static unsafe int XChangeProperty<T>(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            XAtom propertyType,
            int format,
            XPropertyMode mode,
            ReadOnlySpan<T> data,
            int elements) where T : unmanaged
        {
            fixed (T* dataPtr = data)
            {
                return XChangeProperty(display, window, property, propertyType, format, mode, (IntPtr)dataPtr, elements);
            }
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XChangeProperty(
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
        internal static extern int XChangeProperty(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            XAtom propertyType,
            int format,
            XPropertyMode mode,
            long[] data,
            int elements
        );

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XChangeProperty(
            XDisplayPtr display,
            XWindow window,
            XAtom property,
            XAtom propertyType,
            int format,
            XPropertyMode mode,
            byte[] data,
            int elements
        );

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XDeleteProperty(XDisplayPtr display, XWindow w, XAtom property);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XGetInputFocus(XDisplayPtr display, out XWindow focus_return, out RevertTo revert_to_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XSetInputFocus(XDisplayPtr display, XWindow focus, RevertTo revert_to, XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XRaiseWindow(XDisplayPtr display, XWindow w);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFlush(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XSetWMProtocols(XDisplayPtr display, XWindow w, [In] XAtom[] protocols, int count);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XCursor XCreateFontCursor(XDisplayPtr display, XCursorShape shape);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XDefineCursor(XDisplayPtr display, XWindow w, XCursor cursor);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XUndefineCursor(XDisplayPtr display, XWindow w);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFreeCursor(XDisplayPtr display, XCursor cursor);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte XQueryPointer(
            XDisplayPtr display,
            XWindow w,
            out XWindow root_return,
            out XWindow child_return,
            out int root_x_return,
            out int root_y_return,
            out int win_x_return,
            out int win_y_return,
            out uint mask_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XWarpPointer(
            XDisplayPtr display,
            XWindow src_w,
            XWindow dest_w,
            int src_x,
            int src_y,
            uint src_width,
            uint src_height,
            int dest_x,
            int dest_y);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XPixmap XCreatePixmap(XDisplayPtr display, XDrawable d, int width, int height, int depth);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XFreePixmap(XDisplayPtr display, XPixmap pixmap);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XPixmap XCreateBitmapFromData(XDisplayPtr display, XDrawable d, byte* data, int width, int height);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XCursor XCreatePixmapCursor(XDisplayPtr display, XPixmap source, XPixmap mask, XColorPtr foreground_color, XColorPtr background_color, int x, int y);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal unsafe delegate bool XPredicate(XDisplayPtr display, ref XEvent @event, IntPtr arg);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal static extern bool XCheckIfEvent(XDisplayPtr display, out XEvent event_return, XPredicate predicate, IntPtr arg);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XIfEvent(XDisplayPtr display, out XEvent event_return, XPredicate predicate, IntPtr arg);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XIconifyWindow(XDisplayPtr display, XWindow w, int screen_number);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GrabResult XGrabPointer(
            XDisplayPtr display,
            XWindow grab_window,
            [MarshalAs(UnmanagedType.I1)] bool owner_events,
            XEventMask event_mask,
            GrabMode pointer_mode,
            GrabMode keyboard_mode,
            XWindow confine_to,
            XCursor cursor,
            XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XUngrabPointer(XDisplayPtr display, XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XQueryExtension(XDisplayPtr display, string name, out int major_opcode_return, out int first_event_return, out int first_error_return);

        internal static unsafe string[] XListExtensions(XDisplayPtr display, out int nextensions_return)
        {
            byte** ptr = XListExtensions(display, out nextensions_return);

            string[] strings = new string[nextensions_return];
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Marshal.PtrToStringUTF8((IntPtr)ptr[i]) ?? throw new NullReferenceException("XListExtensions() returned null string.");
            }

            return strings;

            [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
            static unsafe extern byte** XListExtensions(XDisplayPtr display, out int nextensions_return);
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XSync(XDisplayPtr display, int discard);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XConvertSelection(XDisplayPtr display, XAtom selection, XAtom target, XAtom property, XWindow requestor, XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XSetSelectionOwner(XDisplayPtr display, XAtom selection, XWindow window, XTime time);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool XCheckTypedWindowEvent(XDisplayPtr display, XWindow w, XEventType event_type, out XEvent event_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XPending(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int XConnectionNumber(XDisplayPtr display);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int XLookupString(XKeyEvent* event_struct, byte* buffer_return, int bytes_buffer, XKeySym* keysym_return, XComposeStatus* status_in_out);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XIM XOpenIM(XDisplayPtr display, XrmDatabase db, string res_name, string res_class);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int /* Status */ XCloseIM(XIM im);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl, EntryPoint = "XSetIMValues")]
        private static unsafe extern byte* XSetIMValues_(XIM im, __arglist);

        internal static unsafe string? XSetIMValues<T>(XIM im, string key, T value) where T : unmanaged
        {
            byte* str = (byte*)Marshal.StringToCoTaskMemUTF8(key);
            byte* ret = XSetIMValues_(im, __arglist(str, value, null));
            Marshal.FreeCoTaskMem((IntPtr)str);
            return Marshal.PtrToStringUTF8((IntPtr)ret);
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int Xutf8LookupString(XIC ic, XKeyEvent* @event, byte* buffer_return, int bytes_buffer, XKeySym* keysym_return, int* /*Status*/ status_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void XDisplayKeycodes(XDisplayPtr display, out int min_keycodes_return, out int max_keycodes_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern XKeySym* XGetKeyboardMapping(XDisplayPtr display, byte /* KeyCode */ first_keycode, int keycode_count, out int keysyms_per_keycode_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XKeySym XKeycodeToKeysym(XDisplayPtr display, byte /* KeyCode */ keycode, int index);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte /* KeyCode */ XKeysymToKeycode(XDisplayPtr display, XKeySym keysym);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl, EntryPoint = "XKeysymToString")]
        private static unsafe extern byte* XKeysymToString_(XKeySym keysym);

        internal static unsafe string? XKeysymToString(XKeySym keysym)
        {
            byte* ptr = XKeysymToString_(keysym);
            string? str = Marshal.PtrToStringUTF8((nint)ptr);
            return str;
        }

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int /* Status */ XQueryTree(XDisplayPtr display, XWindow w, out XWindow root_return, out XWindow parent_return, out XWindow* children_return, out uint nchildren_return);

        [DllImport(X11, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern int XSetTransientForHint(XDisplayPtr display, XWindow w, XWindow prop_window);
    }
}
