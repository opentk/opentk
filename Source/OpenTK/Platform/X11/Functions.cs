using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
    class Functions
    {
        [DllImport("libX11", EntryPoint = "XOpenDisplay")]
        internal extern static IntPtr XOpenDisplay(IntPtr display);
        [DllImport("libX11", EntryPoint = "XCloseDisplay")]
        internal extern static int XCloseDisplay(IntPtr display);
        [DllImport("libX11", EntryPoint = "XSynchronize")]
        internal extern static IntPtr XSynchronize(IntPtr display, bool onoff);

        [DllImport("libX11", EntryPoint = "XCreateWindow")]
        internal extern static IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, int depth, int xclass, IntPtr visual, UIntPtr valuemask, ref XSetWindowAttributes attributes);
        [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]
        internal extern static IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, UIntPtr border, UIntPtr background);
        [DllImport("libX11", EntryPoint = "XMapWindow")]
        internal extern static int XMapWindow(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XUnmapWindow")]
        internal extern static int XUnmapWindow(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XMapSubwindows")]
        internal extern static int XMapSubindows(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XUnmapSubwindows")]
        internal extern static int XUnmapSubwindows(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XRootWindow")]
        internal extern static IntPtr XRootWindow(IntPtr display, int screen_number);
        [DllImport("libX11", EntryPoint = "XNextEvent")]
        internal extern static IntPtr XNextEvent(IntPtr display, ref XEvent xevent);
        [DllImport("libX11")]
        internal extern static int XConnectionNumber(IntPtr diplay);
        [DllImport("libX11")]
        internal extern static int XPending(IntPtr diplay);
        [DllImport("libX11", EntryPoint = "XSelectInput")]
        internal extern static IntPtr XSelectInput(IntPtr display, IntPtr window, IntPtr mask);

        [DllImport("libX11", EntryPoint = "XDestroyWindow")]
        internal extern static int XDestroyWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XReparentWindow")]
        internal extern static int XReparentWindow(IntPtr display, IntPtr window, IntPtr parent, int x, int y);
        [DllImport("libX11", EntryPoint = "XMoveResizeWindow")]
        internal extern static int XMoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height);

        [DllImport("libX11", EntryPoint = "XResizeWindow")]
        internal extern static int XResizeWindow(IntPtr display, IntPtr window, int width, int height);

        [DllImport("libX11", EntryPoint = "XGetWindowAttributes")]
        internal extern static int XGetWindowAttributes(IntPtr display, IntPtr window, ref XWindowAttributes attributes);

        [DllImport("libX11", EntryPoint = "XFlush")]
        internal extern static int XFlush(IntPtr display);

        [DllImport("libX11", EntryPoint = "XSetWMName")]
        internal extern static int XSetWMName(IntPtr display, IntPtr window, ref XTextProperty text_prop);

        [DllImport("libX11", EntryPoint = "XStoreName")]
        internal extern static int XStoreName(IntPtr display, IntPtr window, string window_name);

        [DllImport("libX11", EntryPoint = "XFetchName")]
        internal extern static int XFetchName(IntPtr display, IntPtr window, ref IntPtr window_name);

        [DllImport("libX11", EntryPoint = "XSendEvent")]
        internal extern static int XSendEvent(IntPtr display, IntPtr window, bool propagate, IntPtr event_mask, ref XEvent send_event);

        [DllImport("libX11", EntryPoint = "XQueryTree")]
        internal extern static int XQueryTree(IntPtr display, IntPtr window, out IntPtr root_return, out IntPtr parent_return, out IntPtr children_return, out int nchildren_return);

        [DllImport("libX11", EntryPoint = "XFree")]
        internal extern static int XFree(IntPtr data);

        [DllImport("libX11", EntryPoint = "XRaiseWindow")]
        internal extern static int XRaiseWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XLowerWindow")]
        internal extern static uint XLowerWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XConfigureWindow")]
        internal extern static uint XConfigureWindow(IntPtr display, IntPtr window, ChangeWindowFlags value_mask, ref XWindowChanges values);

        [DllImport("libX11", EntryPoint = "XInternAtom")]
        internal extern static IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists);

        [DllImport("libX11", EntryPoint = "XInternAtoms")]
        internal extern static int XInternAtoms(IntPtr display, string[] atom_names, int atom_count, bool only_if_exists, IntPtr[] atoms);

        [DllImport("libX11", EntryPoint = "XSetWMProtocols")]
        internal extern static int XSetWMProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

        [DllImport("libX11", EntryPoint = "XGrabPointer")]
        internal extern static int XGrabPointer(IntPtr display, IntPtr window, bool owner_events, EventMask event_mask, GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr confine_to, IntPtr cursor, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XUngrabPointer")]
        internal extern static int XUngrabPointer(IntPtr display, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XQueryPointer")]
        internal extern static bool XQueryPointer(IntPtr display, IntPtr window, out IntPtr root, out IntPtr child, out int root_x, out int root_y, out int win_x, out int win_y, out int keys_buttons);

        [DllImport("libX11", EntryPoint = "XTranslateCoordinates")]
        internal extern static bool XTranslateCoordinates(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, out int intdest_x_return, out int dest_y_return, out IntPtr child_return);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        internal extern static bool XGetGeometry(IntPtr display, IntPtr window, out IntPtr root, out int x, out int y, out int width, out int height, out int border_width, out int depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        internal extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y, out int width, out int height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        internal extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y, IntPtr width, IntPtr height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        internal extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, IntPtr x, IntPtr y, out int width, out int height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XWarpPointer")]
        internal extern static uint XWarpPointer(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, uint src_width, uint src_height, int dest_x, int dest_y);

        [DllImport("libX11", EntryPoint = "XClearWindow")]
        internal extern static int XClearWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XClearArea")]
        internal extern static int XClearArea(IntPtr display, IntPtr window, int x, int y, int width, int height, bool exposures);

        // Colormaps
        [DllImport("libX11", EntryPoint = "XDefaultScreenOfDisplay")]
        internal extern static IntPtr XDefaultScreenOfDisplay(IntPtr display);

        [DllImport("libX11", EntryPoint = "XScreenNumberOfScreen")]
        internal extern static int XScreenNumberOfScreen(IntPtr display, IntPtr Screen);

        [DllImport("libX11", EntryPoint = "XDefaultVisual")]
        internal extern static IntPtr XDefaultVisual(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefaultDepth")]
        internal extern static uint XDefaultDepth(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefaultScreen")]
        internal extern static int XDefaultScreen(IntPtr display);

        [DllImport("libX11", EntryPoint = "XDefaultColormap")]
        internal extern static IntPtr XDefaultColormap(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XLookupColor")]
        internal extern static int XLookupColor(IntPtr display, IntPtr Colormap, string Coloranem, ref XColor exact_def_color, ref XColor screen_def_color);

        [DllImport("libX11", EntryPoint = "XAllocColor")]
        internal extern static int XAllocColor(IntPtr display, IntPtr Colormap, ref XColor colorcell_def);

        [DllImport("libX11", EntryPoint = "XSetTransientForHint")]
        internal extern static int XSetTransientForHint(IntPtr display, IntPtr window, IntPtr prop_window);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref MotifWmHints data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref uint value, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref IntPtr value, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, uint[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, int[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr atoms, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty", CharSet = CharSet.Ansi)]
        internal extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, string text, int text_length);

        [DllImport("libX11", EntryPoint = "XDeleteProperty")]
        internal extern static int XDeleteProperty(IntPtr display, IntPtr window, IntPtr property);

        // Drawing
        [DllImport("libX11", EntryPoint = "XCreateGC")]
        internal extern static IntPtr XCreateGC(IntPtr display, IntPtr window, IntPtr valuemask, ref XGCValues values);

        [DllImport("libX11", EntryPoint = "XFreeGC")]
        internal extern static int XFreeGC(IntPtr display, IntPtr gc);

        [DllImport("libX11", EntryPoint = "XSetFunction")]
        internal extern static int XSetFunction(IntPtr display, IntPtr gc, GXFunction function);

        [DllImport("libX11", EntryPoint = "XSetLineAttributes")]
        internal extern static int XSetLineAttributes(IntPtr display, IntPtr gc, int line_width, GCLineStyle line_style, GCCapStyle cap_style, GCJoinStyle join_style);

        [DllImport("libX11", EntryPoint = "XDrawLine")]
        internal extern static int XDrawLine(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int x2, int y2);

        [DllImport("libX11", EntryPoint = "XDrawRectangle")]
        internal extern static int XDrawRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height);

        [DllImport("libX11", EntryPoint = "XFillRectangle")]
        internal extern static int XFillRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height);

        [DllImport("libX11", EntryPoint = "XSetWindowBackground")]
        internal extern static int XSetWindowBackground(IntPtr display, IntPtr window, IntPtr background);

        [DllImport("libX11", EntryPoint = "XCopyArea")]
        internal extern static int XCopyArea(IntPtr display, IntPtr src, IntPtr dest, IntPtr gc, int src_x, int src_y, int width, int height, int dest_x, int dest_y);

        [DllImport("libX11", EntryPoint = "XGetWindowProperty")]
        internal extern static int XGetWindowProperty(IntPtr display, IntPtr window, IntPtr atom, IntPtr long_offset, IntPtr long_length, bool delete, IntPtr req_type, out IntPtr actual_type, out int actual_format, out IntPtr nitems, out IntPtr bytes_after, ref IntPtr prop);

        [DllImport("libX11", EntryPoint = "XSetInputFocus")]
        internal extern static int XSetInputFocus(IntPtr display, IntPtr window, RevertTo revert_to, IntPtr time);

        [DllImport("libX11", EntryPoint = "XIconifyWindow")]
        internal extern static int XIconifyWindow(IntPtr display, IntPtr window, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefineCursor")]
        internal extern static int XDefineCursor(IntPtr display, IntPtr window, IntPtr cursor);

        [DllImport("libX11", EntryPoint = "XUndefineCursor")]
        internal extern static int XUndefineCursor(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XFreeCursor")]
        internal extern static int XFreeCursor(IntPtr display, IntPtr cursor);

        [DllImport("libX11", EntryPoint = "XCreateFontCursor")]
        internal extern static IntPtr XCreateFontCursor(IntPtr display, CursorFontShape shape);

        [DllImport("libX11", EntryPoint = "XCreatePixmapCursor")]
        internal extern static IntPtr XCreatePixmapCursor(IntPtr display, IntPtr source, IntPtr mask, ref XColor foreground_color, ref XColor background_color, int x_hot, int y_hot);

        [DllImport("libX11", EntryPoint = "XCreatePixmapFromBitmapData")]
        internal extern static IntPtr XCreatePixmapFromBitmapData(IntPtr display, IntPtr drawable, byte[] data, int width, int height, IntPtr fg, IntPtr bg, int depth);

        [DllImport("libX11", EntryPoint = "XCreatePixmap")]
        internal extern static IntPtr XCreatePixmap(IntPtr display, IntPtr d, int width, int height, int depth);

        [DllImport("libX11", EntryPoint = "XFreePixmap")]
        internal extern static IntPtr XFreePixmap(IntPtr display, IntPtr pixmap);

        [DllImport("libX11", EntryPoint = "XQueryBestCursor")]
        internal extern static int XQueryBestCursor(IntPtr display, IntPtr drawable, int width, int height, out int best_width, out int best_height);

        [DllImport("libX11", EntryPoint = "XQueryExtension")]
        internal extern static int XQueryExtension(IntPtr display, string extension_name, ref int major, ref int first_event, ref int first_error);

        [DllImport("libX11", EntryPoint = "XWhitePixel")]
        internal extern static IntPtr XWhitePixel(IntPtr display, int screen_no);

        [DllImport("libX11", EntryPoint = "XBlackPixel")]
        internal extern static IntPtr XBlackPixel(IntPtr display, int screen_no);

        [DllImport("libX11", EntryPoint = "XGrabServer")]
        internal extern static void XGrabServer(IntPtr display);

        [DllImport("libX11", EntryPoint = "XUngrabServer")]
        internal extern static void XUngrabServer(IntPtr display);

        [DllImport("libX11", EntryPoint = "XGetWMNormalHints")]
        internal extern static void XGetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints, out IntPtr supplied_return);

        [DllImport("libX11", EntryPoint = "XSetWMNormalHints")]
        internal extern static void XSetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints);

        [DllImport("libX11", EntryPoint = "XSetZoomHints")]
        internal extern static void XSetZoomHints(IntPtr display, IntPtr window, ref XSizeHints hints);

        [DllImport("libX11", EntryPoint = "XSetWMHints")]
        internal extern static void XSetWMHints(IntPtr display, IntPtr window, ref XWMHints wmhints);

        [DllImport("libX11", EntryPoint = "XGetIconSizes")]
        internal extern static int XGetIconSizes(IntPtr display, IntPtr window, out IntPtr size_list, out int count);

        [DllImport("libX11", EntryPoint = "XSetErrorHandler")]
        internal extern static IntPtr XSetErrorHandler(XErrorHandler error_handler);

        [DllImport("libX11", EntryPoint = "XGetErrorText")]
        internal extern static IntPtr XGetErrorText(IntPtr display, byte code, StringBuilder buffer, int length);

        [DllImport("libX11", EntryPoint = "XInitThreads")]
        internal extern static int XInitThreads();

        [DllImport("libX11", EntryPoint = "XConvertSelection")]
        internal extern static int XConvertSelection(IntPtr display, IntPtr selection, IntPtr target, IntPtr property, IntPtr requestor, IntPtr time);

        [DllImport("libX11", EntryPoint = "XGetSelectionOwner")]
        internal extern static IntPtr XGetSelectionOwner(IntPtr display, IntPtr selection);

        [DllImport("libX11", EntryPoint = "XSetSelectionOwner")]
        internal extern static int XSetSelectionOwner(IntPtr display, IntPtr selection, IntPtr owner, IntPtr time);

        [DllImport("libX11", EntryPoint = "XSetPlaneMask")]
        internal extern static int XSetPlaneMask(IntPtr display, IntPtr gc, IntPtr mask);

        [DllImport("libX11", EntryPoint = "XSetForeground")]
        internal extern static int XSetForeground(IntPtr display, IntPtr gc, UIntPtr foreground);

        [DllImport("libX11", EntryPoint = "XSetBackground")]
        internal extern static int XSetBackground(IntPtr display, IntPtr gc, UIntPtr background);

        [DllImport("libX11", EntryPoint = "XBell")]
        internal extern static int XBell(IntPtr display, int percent);

        [DllImport("libX11", EntryPoint = "XChangeActivePointerGrab")]
        internal extern static int XChangeActivePointerGrab(IntPtr display, EventMask event_mask, IntPtr cursor, IntPtr time);

        [DllImport("libX11", EntryPoint = "XFilterEvent")]
        internal extern static bool XFilterEvent(ref XEvent xevent, IntPtr window);

        [DllImport("libX11")]
        internal extern static void XkbSetDetectableAutoRepeat(IntPtr display, bool detectable, IntPtr supported);

        [DllImport("libX11")]
        internal extern static void XPeekEvent(IntPtr display, ref XEvent xevent);
    }
}
