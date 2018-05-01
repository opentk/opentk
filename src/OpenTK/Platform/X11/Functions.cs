/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */

using System;
using System.Runtime.InteropServices;
using System.Text;
#if !MINIMAL
using System.Drawing;
#endif
#if ANDROID || IPHONE || MINIMAL
using OpenTK.Minimal;
#else
using System.Drawing.Imaging;

#endif

namespace OpenTK.Platform.X11
{
    // using XID = System.Int32;
    using Window = IntPtr;
    using Drawable = IntPtr;
    using Font = IntPtr;
    using Pixmap = IntPtr;
    using Cursor = IntPtr;
    using Colormap = IntPtr;
    using GContext = IntPtr;
    using KeySym = IntPtr;
    using Mask = IntPtr;
    using Atom = IntPtr;
    using VisualID = IntPtr;
    using Time = IntPtr;
    using KeyCode = Byte; // Or maybe ushort?
    using Display = IntPtr;
    using XPointer = IntPtr;

    // Randr and Xrandr
    using Bool = Boolean;
    using XRRScreenConfiguration = IntPtr; // opaque datatype
    using Rotation = UInt16;
    using Status = Int32;
    using SizeID = UInt16;


    internal static partial class Functions
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate bool EventPredicate(IntPtr display, ref XEvent e, IntPtr arg);

        public static readonly object Lock = API.Lock;

        private static readonly IntPtr CopyFromParent = IntPtr.Zero;

        [DllImport("libX11", EntryPoint = "XOpenDisplay")]
        private static extern IntPtr sys_XOpenDisplay(IntPtr display);

        public static IntPtr XOpenDisplay(IntPtr display)
        {
            lock (Lock)
            {
                return sys_XOpenDisplay(display);
            }
        }

        [DllImport("libX11", EntryPoint = "XCloseDisplay")]
        public static extern int XCloseDisplay(IntPtr display);

        [DllImport("libX11", EntryPoint = "XSynchronize")]
        public static extern IntPtr XSynchronize(IntPtr display, bool onoff);

        [DllImport("libX11", EntryPoint = "XCreateWindow")]
        public static extern unsafe IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width,
            int height, int border_width, int depth, int xclass, IntPtr visual, IntPtr valuemask,
            XSetWindowAttributes* attributes);

        [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")] //, CLSCompliant(false)]
        public static extern IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width,
            int height, int border_width, UIntPtr border, UIntPtr background);

        [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]
        public static extern IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width,
            int height, int border_width, IntPtr border, IntPtr background);

        [DllImport("libX11", EntryPoint = "XMapWindow")]
        public static extern int XMapWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XUnmapWindow")]
        public static extern int XUnmapWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XMapSubwindows")]
        public static extern int XMapSubindows(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XUnmapSubwindows")]
        public static extern int XUnmapSubwindows(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XRootWindow")]
        public static extern IntPtr XRootWindow(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XNextEvent")]
        public static extern IntPtr XNextEvent(IntPtr display, ref XEvent xevent);

        [DllImport("libX11")]
        public static extern bool XWindowEvent(Display display, Window w, EventMask event_mask,
            ref XEvent event_return);

        [DllImport("libX11")]
        public static extern bool XCheckWindowEvent(Display display, Window w, EventMask event_mask,
            ref XEvent event_return);

        [DllImport("libX11")]
        public static extern bool XCheckTypedWindowEvent(Display display, Window w, XEventName event_type,
            ref XEvent event_return);

        [DllImport("libX11")]
        public static extern bool XCheckTypedEvent(Display display, XEventName event_type, out XEvent event_return);

        [DllImport("libX11")]
        public static extern bool XIfEvent(Display display, ref XEvent e, IntPtr predicate, IntPtr arg);

        [DllImport("libX11")]
        public static extern bool XCheckIfEvent(Display display, ref XEvent e, IntPtr predicate, IntPtr arg);

        [DllImport("libX11")]
        public static extern int XConnectionNumber(IntPtr diplay);

        [DllImport("libX11")]
        public static extern int XPending(IntPtr diplay);

        [DllImport("libX11", EntryPoint = "XSelectInput")]
        public static extern int XSelectInput(IntPtr display, IntPtr window, IntPtr mask);

        [DllImport("libX11", EntryPoint = "XDestroyWindow")]
        public static extern int XDestroyWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XReparentWindow")]
        public static extern int XReparentWindow(IntPtr display, IntPtr window, IntPtr parent, int x, int y);

        [DllImport("libX11", EntryPoint = "XMoveResizeWindow")]
        public static extern int XMoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height);

        [DllImport("libX11", EntryPoint = "XMoveWindow")]
        public static extern int XMoveWindow(IntPtr display, IntPtr w, int x, int y);

        [DllImport("libX11", EntryPoint = "XResizeWindow")]
        public static extern int XResizeWindow(IntPtr display, IntPtr window, int width, int height);

        [DllImport("libX11", EntryPoint = "XGetWindowAttributes")]
        public static extern int XGetWindowAttributes(IntPtr display, IntPtr window, ref XWindowAttributes attributes);

        [DllImport("libX11", EntryPoint = "XFlush")]
        public static extern int XFlush(IntPtr display);

        [DllImport("libX11", EntryPoint = "XSetWMName")]
        public static extern int XSetWMName(IntPtr display, IntPtr window, ref XTextProperty text_prop);

        [DllImport("libX11", EntryPoint = "XStoreName")]
        public static extern int XStoreName(IntPtr display, IntPtr window, string window_name);

        [DllImport("libX11", EntryPoint = "XFetchName")]
        public static extern int XFetchName(IntPtr display, IntPtr window, ref IntPtr window_name);

        [DllImport("libX11", EntryPoint = "XSendEvent")]
        public static extern int XSendEvent(IntPtr display, IntPtr window, bool propagate, IntPtr event_mask,
            ref XEvent send_event);

        public static int XSendEvent(IntPtr display, IntPtr window, bool propagate, EventMask event_mask,
            ref XEvent send_event)
        {
            return XSendEvent(display, window, propagate, new IntPtr((int)event_mask), ref send_event);
        }

        [DllImport("libX11", EntryPoint = "XQueryTree")]
        public static extern int XQueryTree(IntPtr display, IntPtr window, out IntPtr root_return,
            out IntPtr parent_return, out IntPtr children_return, out int nchildren_return);

        [DllImport("libX11", EntryPoint = "XFree")]
        public static extern int XFree(IntPtr data);

        [DllImport("libX11", EntryPoint = "XRaiseWindow")]
        public static extern int XRaiseWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XLowerWindow")] //, CLSCompliant(false)]
        public static extern uint XLowerWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XConfigureWindow")] //, CLSCompliant(false)]
        public static extern uint XConfigureWindow(IntPtr display, IntPtr window, ChangeWindowAttributes value_mask,
            ref XWindowChanges values);

        [DllImport("libX11", EntryPoint = "XInternAtom")]
        public static extern IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists);

        [DllImport("libX11", EntryPoint = "XInternAtoms")]
        public static extern int XInternAtoms(IntPtr display, string[] atom_names, int atom_count, bool only_if_exists,
            IntPtr[] atoms);

        [DllImport("libX11", EntryPoint = "XGetAtomName")]
        public static extern IntPtr XGetAtomName(IntPtr display, IntPtr atom);

        [DllImport("libX11", EntryPoint = "XSetWMProtocols")]
        public static extern int XSetWMProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

        [DllImport("libX11", EntryPoint = "XGrabPointer")]
        public static extern int XGrabPointer(IntPtr display, IntPtr window, bool owner_events, EventMask event_mask,
            GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr confine_to, IntPtr cursor, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XUngrabPointer")]
        public static extern int XUngrabPointer(IntPtr display, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XGrabButton")]
        public static extern int XGrabButton(IntPtr display,
            int button, uint modifiers, Window grab_window,
            bool owner_events, EventMask event_mask,
            GrabMode pointer_mode, GrabMode keyboard_mode,
            Window confine_to, Cursor cursor);

        [DllImport("libX11", EntryPoint = "XUngrabButton")]
        public static extern int XUngrabButton(IntPtr display, uint button, uint
            modifiers, Window grab_window);

        [DllImport("libX11", EntryPoint = "XQueryPointer")]
        public static extern bool XQueryPointer(IntPtr display, IntPtr window, out IntPtr root, out IntPtr child,
            out int root_x, out int root_y, out int win_x, out int win_y, out int keys_buttons);

        [DllImport("libX11", EntryPoint = "XTranslateCoordinates")]
        public static extern bool XTranslateCoordinates(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x,
            int src_y, out int intdest_x_return, out int dest_y_return, out IntPtr child_return);


        [DllImport("libX11")]
        public static extern int XGrabKey(IntPtr display, int keycode, uint modifiers,
            Window grab_window, bool owner_events, GrabMode pointer_mode, GrabMode keyboard_mode);

        [DllImport("libX11")]
        public static extern int XUngrabKey(IntPtr display, int keycode, uint modifiers, Window grab_window);

        [DllImport("libX11", EntryPoint = "XGrabKeyboard")]
        public static extern int XGrabKeyboard(IntPtr display, IntPtr window, bool owner_events,
            GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XUngrabKeyboard")]
        public static extern int XUngrabKeyboard(IntPtr display, IntPtr timestamp);

        [DllImport("libX11")]
        public static extern int XAllowEvents(IntPtr display, EventMode event_mode, Time time);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public static extern bool XGetGeometry(IntPtr display, IntPtr window, out IntPtr root, out int x, out int y,
            out int width, out int height, out int border_width, out int depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public static extern bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y,
            out int width, out int height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public static extern bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y,
            IntPtr width, IntPtr height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public static extern bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, IntPtr x, IntPtr y,
            out int width, out int height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XWarpPointer")] //, CLSCompliant(false)]
        public static extern uint XWarpPointer(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y,
            uint src_width, uint src_height, int dest_x, int dest_y);

        [DllImport("libX11", EntryPoint = "XClearWindow")]
        public static extern int XClearWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XClearArea")]
        public static extern int XClearArea(IntPtr display, IntPtr window, int x, int y, int width, int height,
            bool exposures);

        // Colormaps
        [DllImport("libX11", EntryPoint = "XDefaultScreenOfDisplay")]
        public static extern IntPtr XDefaultScreenOfDisplay(IntPtr display);

        [DllImport("libX11", EntryPoint = "XScreenNumberOfScreen")]
        public static extern int XScreenNumberOfScreen(IntPtr display, IntPtr Screen);

        [DllImport("libX11", EntryPoint = "XDefaultVisual")]
        public static extern IntPtr XDefaultVisual(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefaultDepth")] //, CLSCompliant(false)]
        public static extern uint XDefaultDepth(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefaultScreen")]
        public static extern int XDefaultScreen(IntPtr display);

        [DllImport("libX11", EntryPoint = "XDefaultColormap")]
        public static extern IntPtr XDefaultColormap(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XLookupColor")] //, CLSCompliant(false)]
        public static extern int XLookupColor(IntPtr display, IntPtr Colormap, string Coloranem,
            ref XColor exact_def_color, ref XColor screen_def_color);

        [DllImport("libX11", EntryPoint = "XAllocColor")] //, CLSCompliant(false)]
        public static extern int XAllocColor(IntPtr display, IntPtr Colormap, ref XColor colorcell_def);

        [DllImport("libX11", EntryPoint = "XSetTransientForHint")]
        public static extern int XSetTransientForHint(IntPtr display, IntPtr window, IntPtr prop_window);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, ref MotifWmHints data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")] //, CLSCompliant(false)]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, ref uint value, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, ref int value, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")] //, CLSCompliant(false)]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, ref IntPtr value, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")] //, CLSCompliant(false)]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, uint[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, int[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, IntPtr[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, IntPtr atoms, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty", CharSet = CharSet.Ansi)]
        public static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
            int format, PropertyMode mode, string text, int text_length);

        [DllImport("libX11", EntryPoint = "XDeleteProperty")]
        public static extern int XDeleteProperty(IntPtr display, IntPtr window, IntPtr property);

        // Drawing
        [DllImport("libX11", EntryPoint = "XCreateGC")]
        public static extern IntPtr XCreateGC(IntPtr display, IntPtr window, IntPtr valuemask, XGCValues[] values);

        [DllImport("libX11", EntryPoint = "XFreeGC")]
        public static extern int XFreeGC(IntPtr display, IntPtr gc);

        [DllImport("libX11", EntryPoint = "XSetFunction")]
        public static extern int XSetFunction(IntPtr display, IntPtr gc, GXFunction function);

        [DllImport("libX11", EntryPoint = "XSetLineAttributes")]
        public static extern int XSetLineAttributes(IntPtr display, IntPtr gc, int line_width, GCLineStyle line_style,
            GCCapStyle cap_style, GCJoinStyle join_style);

        [DllImport("libX11", EntryPoint = "XDrawLine")]
        public static extern int XDrawLine(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int x2, int y2);

        [DllImport("libX11", EntryPoint = "XDrawRectangle")]
        public static extern int XDrawRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width,
            int height);

        [DllImport("libX11", EntryPoint = "XFillRectangle")]
        public static extern int XFillRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width,
            int height);

        [DllImport("libX11", EntryPoint = "XSetWindowBackground")]
        public static extern int XSetWindowBackground(IntPtr display, IntPtr window, IntPtr background);

        [DllImport("libX11", EntryPoint = "XCopyArea")]
        public static extern int XCopyArea(IntPtr display, IntPtr src, IntPtr dest, IntPtr gc, int src_x, int src_y,
            int width, int height, int dest_x, int dest_y);

        [DllImport("libX11", EntryPoint = "XGetWindowProperty")]
        public static extern int XGetWindowProperty(IntPtr display, IntPtr window, IntPtr atom, IntPtr long_offset,
            IntPtr long_length, bool delete, IntPtr req_type, out IntPtr actual_type, out int actual_format,
            out IntPtr nitems, out IntPtr bytes_after, ref IntPtr prop);

        [DllImport("libX11", EntryPoint = "XSetInputFocus")]
        public static extern int XSetInputFocus(IntPtr display, IntPtr window, RevertTo revert_to, IntPtr time);

        [DllImport("libX11", EntryPoint = "XIconifyWindow")]
        public static extern int XIconifyWindow(IntPtr display, IntPtr window, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefineCursor")]
        public static extern int XDefineCursor(IntPtr display, IntPtr window, IntPtr cursor);

        [DllImport("libX11", EntryPoint = "XUndefineCursor")]
        public static extern int XUndefineCursor(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XFreeCursor")]
        public static extern int XFreeCursor(IntPtr display, IntPtr cursor);

        [DllImport("libX11", EntryPoint = "XCreateFontCursor")]
        public static extern IntPtr XCreateFontCursor(IntPtr display, CursorFontShape shape);

        [DllImport("libX11", EntryPoint = "XCreatePixmapCursor")] //, CLSCompliant(false)]
        public static extern IntPtr XCreatePixmapCursor(IntPtr display, IntPtr source, IntPtr mask,
            ref XColor foreground_color, ref XColor background_color, int x_hot, int y_hot);

        [DllImport("libX11", EntryPoint = "XCreatePixmapFromBitmapData")]
        public static extern IntPtr XCreatePixmapFromBitmapData(IntPtr display, IntPtr drawable, byte[] data, int width,
            int height, IntPtr fg, IntPtr bg, int depth);

        [DllImport("libX11", EntryPoint = "XCreatePixmap")]
        public static extern IntPtr XCreatePixmap(IntPtr display, IntPtr d, int width, int height, int depth);

        [DllImport("libX11", EntryPoint = "XFreePixmap")]
        public static extern IntPtr XFreePixmap(IntPtr display, IntPtr pixmap);

        [DllImport("libX11", EntryPoint = "XQueryBestCursor")]
        public static extern int XQueryBestCursor(IntPtr display, IntPtr drawable, int width, int height,
            out int best_width, out int best_height);

        [DllImport("libX11", EntryPoint = "XQueryExtension")]
        public static extern int XQueryExtension(IntPtr display, string extension_name, out int major,
            out int first_event, out int first_error);

        [DllImport("libX11", EntryPoint = "XWhitePixel")]
        public static extern IntPtr XWhitePixel(IntPtr display, int screen_no);

        [DllImport("libX11", EntryPoint = "XBlackPixel")]
        public static extern IntPtr XBlackPixel(IntPtr display, int screen_no);

        [DllImport("libX11", EntryPoint = "XGrabServer")]
        public static extern void XGrabServer(IntPtr display);

        [DllImport("libX11", EntryPoint = "XUngrabServer")]
        public static extern void XUngrabServer(IntPtr display);

        [DllImport("libX11", EntryPoint = "XGetWMNormalHints")]
        public static extern int XGetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints,
            out IntPtr supplied_return);

        [DllImport("libX11", EntryPoint = "XSetWMNormalHints")]
        public static extern void XSetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints);

        [DllImport("libX11", EntryPoint = "XSetZoomHints")]
        public static extern void XSetZoomHints(IntPtr display, IntPtr window, ref XSizeHints hints);

        [DllImport("libX11")]
        public static extern IntPtr XGetWMHints(Display display, Window w); // returns XWMHints*

        [DllImport("libX11")]
        public static extern void XSetWMHints(Display display, Window w, ref XWMHints wmhints);

        [DllImport("libX11")]
        public static extern IntPtr XAllocWMHints();

        [DllImport("libX11", EntryPoint = "XGetIconSizes")]
        public static extern int XGetIconSizes(IntPtr display, IntPtr window, out IntPtr size_list, out int count);

        [DllImport("libX11", EntryPoint = "XSetErrorHandler")]
        public static extern IntPtr XSetErrorHandler(XErrorHandler error_handler);

        [DllImport("libX11", EntryPoint = "XGetErrorText")]
        public static extern IntPtr XGetErrorText(IntPtr display, byte code, StringBuilder buffer, int length);

        [DllImport("libX11", EntryPoint = "XInitThreads")]
        public static extern int XInitThreads();

        [DllImport("libX11", EntryPoint = "XConvertSelection")]
        public static extern int XConvertSelection(IntPtr display, IntPtr selection, IntPtr target, IntPtr property,
            IntPtr requestor, IntPtr time);

        [DllImport("libX11", EntryPoint = "XGetSelectionOwner")]
        public static extern IntPtr XGetSelectionOwner(IntPtr display, IntPtr selection);

        [DllImport("libX11", EntryPoint = "XSetSelectionOwner")]
        public static extern int XSetSelectionOwner(IntPtr display, IntPtr selection, IntPtr owner, IntPtr time);

        [DllImport("libX11", EntryPoint = "XSetPlaneMask")]
        public static extern int XSetPlaneMask(IntPtr display, IntPtr gc, IntPtr mask);

        [DllImport("libX11", EntryPoint = "XSetForeground")] //, CLSCompliant(false)]
        public static extern int XSetForeground(IntPtr display, IntPtr gc, UIntPtr foreground);

        [DllImport("libX11", EntryPoint = "XSetForeground")]
        public static extern int XSetForeground(IntPtr display, IntPtr gc, IntPtr foreground);

        [DllImport("libX11", EntryPoint = "XSetBackground")] //, CLSCompliant(false)]
        public static extern int XSetBackground(IntPtr display, IntPtr gc, UIntPtr background);

        [DllImport("libX11", EntryPoint = "XSetBackground")]
        public static extern int XSetBackground(IntPtr display, IntPtr gc, IntPtr background);

        [DllImport("libX11", EntryPoint = "XBell")]
        public static extern int XBell(IntPtr display, int percent);

        [DllImport("libX11", EntryPoint = "XChangeActivePointerGrab")]
        public static extern int XChangeActivePointerGrab(IntPtr display, EventMask event_mask, IntPtr cursor,
            IntPtr time);

        [DllImport("libX11", EntryPoint = "XFilterEvent")]
        public static extern bool XFilterEvent(ref XEvent xevent, IntPtr window);

        [DllImport("libX11")]
        public static extern void XPeekEvent(IntPtr display, ref XEvent xevent);

        [DllImport("libX11", EntryPoint = "XGetVisualInfo")]
        private static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr vinfo_mask, ref XVisualInfo template,
            out int nitems);

        public static IntPtr XGetVisualInfo(IntPtr display, XVisualInfoMask vinfo_mask, ref XVisualInfo template,
            out int nitems)
        {
            return XGetVisualInfoInternal(display, (IntPtr)(int)vinfo_mask, ref template, out nitems);
        }

        [DllImport("libX11")]
        public static extern IntPtr XCreateColormap(Display display, Window window, IntPtr visual, int alloc);

        [DllImport("libX11")]
        public static extern void XLockDisplay(Display display);

        [DllImport("libX11")]
        public static extern void XUnlockDisplay(Display display);

        [DllImport("libX11")]
        public static extern int XGetTransientForHint(Display display, Window w, out Window prop_window_return);

        [DllImport("libX11")]
        public static extern void XSync(Display display, bool discard);

        [DllImport("libX11")]
        public static extern void XAutoRepeatOff(IntPtr display);

        [DllImport("libX11")]
        public static extern void XAutoRepeatOn(IntPtr display);

        [DllImport("libX11")]
        public static extern IntPtr XDefaultRootWindow(IntPtr display);

        [DllImport("libX11")]
        public static extern int XBitmapBitOrder(Display display);

        [DllImport("libX11")]
        public static extern IntPtr XCreateImage(Display display, IntPtr visual,
            uint depth, ImageFormat format, int offset, byte[] data, uint width, uint height,
            int bitmap_pad, int bytes_per_line);

        [DllImport("libX11")]
        public static extern IntPtr XCreateImage(Display display, IntPtr visual,
            uint depth, ImageFormat format, int offset, IntPtr data, uint width, uint height,
            int bitmap_pad, int bytes_per_line);

        [DllImport("libX11")]
        public static extern void XPutImage(Display display, IntPtr drawable,
            IntPtr gc, IntPtr image, int src_x, int src_y, int dest_x, int dest_y, uint width, uint height);

        [DllImport("libX11")]
        public static extern int XLookupString(ref XKeyEvent event_struct, [Out] byte[] buffer_return,
            int bytes_buffer, [Out] KeySym[] keysym_return, IntPtr status_in_out);

        [DllImport("libX11")]
        public static extern byte XKeysymToKeycode(IntPtr display, KeySym keysym);

        [DllImport("libX11")]
        public static extern KeySym XKeycodeToKeysym(IntPtr display, byte keycode, int index);

        [DllImport("libX11")]
        public static extern int XRefreshKeyboardMapping(ref XMappingEvent event_map);

        [DllImport("libX11")]
        public static extern int XGetEventData(IntPtr display, ref XGenericEventCookie cookie);

        [DllImport("libX11")]
        public static extern void XFreeEventData(IntPtr display, ref XGenericEventCookie cookie);

        [DllImport("libX11")]
        public static extern void XSetClassHint(IntPtr display, IntPtr window, ref XClassHint hint);

        public static void SendNetWMMessage(X11WindowInfo window, IntPtr message_type, IntPtr l0, IntPtr l1, IntPtr l2)
        {
            XEvent xev;

            xev = new XEvent();
            xev.ClientMessageEvent.type = XEventName.ClientMessage;
            xev.ClientMessageEvent.send_event = true;
            xev.ClientMessageEvent.window = window.Handle;
            xev.ClientMessageEvent.message_type = message_type;
            xev.ClientMessageEvent.format = 32;
            xev.ClientMessageEvent.ptr1 = l0;
            xev.ClientMessageEvent.ptr2 = l1;
            xev.ClientMessageEvent.ptr3 = l2;

            XSendEvent(window.Display, window.RootWindow, false,
                new IntPtr((int)(EventMask.SubstructureRedirectMask | EventMask.SubstructureNotifyMask)),
                ref xev);
        }

        public static void SendNetClientMessage(X11WindowInfo window, IntPtr message_type,
            IntPtr l0, IntPtr l1, IntPtr l2)
        {
            XEvent xev;

            xev = new XEvent();
            xev.ClientMessageEvent.type = XEventName.ClientMessage;
            xev.ClientMessageEvent.send_event = true;
            xev.ClientMessageEvent.window = window.Handle;
            xev.ClientMessageEvent.message_type = message_type;
            xev.ClientMessageEvent.format = 32;
            xev.ClientMessageEvent.ptr1 = l0;
            xev.ClientMessageEvent.ptr2 = l1;
            xev.ClientMessageEvent.ptr3 = l2;

            XSendEvent(window.Display, window.Handle, false, new IntPtr((int)EventMask.NoEventMask), ref xev);
        }

        public static IntPtr CreatePixmapFromImage(Display display, Bitmap image)
        {
            var width = image.Width;
            var height = image.Height;

            var data = image.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            var ximage = XCreateImage(display, CopyFromParent, 24, ImageFormat.ZPixmap,
                0, data.Scan0, (uint)width, (uint)height, 32, 0);
            var pixmap = XCreatePixmap(display, XDefaultRootWindow(display),
                width, height, 24);
            var gc = XCreateGC(display, pixmap, IntPtr.Zero, null);

            XPutImage(display, pixmap, gc, ximage, 0, 0, 0, 0, (uint)width, (uint)height);

            XFreeGC(display, gc);
            image.UnlockBits(data);

            return pixmap;
        }

        public static IntPtr CreateMaskFromImage(Display display, Bitmap image)
        {
            var width = image.Width;
            var height = image.Height;
            var stride = (width + 7) >> 3;
            var mask = new byte[stride * height];
            var msbfirst = XBitmapBitOrder(display) == 1; // 1 = MSBFirst

            for (var y = 0; y < height; ++y)
            {
                for (var x = 0; x < width; ++x)
                {
                    var bit = (byte)(1 << (msbfirst ? 7 - (x & 7) : x & 7));
                    var offset = y * stride + (x >> 3);

                    if (image.GetPixel(x, y).A >= 128)
                    {
                        mask[offset] |= bit;
                    }
                }
            }

            var pixmap = XCreatePixmapFromBitmapData(display, XDefaultRootWindow(display),
                mask, width, height, new IntPtr(1), IntPtr.Zero, 1);

            return pixmap;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct Pixel
        {
            public readonly byte A;
            public readonly byte R;
            public readonly byte G;
            public readonly byte B;

            public Pixel(byte a, byte r, byte g, byte b)
            {
                A = a;
                R = r;
                G = g;
                B = b;
            }

            public static implicit operator Pixel(int argb)
            {
                return new Pixel(
                    (byte)((argb >> 24) & 0xFF),
                    (byte)((argb >> 16) & 0xFF),
                    (byte)((argb >> 8) & 0xFF),
                    (byte)(argb & 0xFF));
            }
        }
    }
}