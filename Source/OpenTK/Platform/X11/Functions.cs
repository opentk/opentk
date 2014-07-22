#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
#if ANDROID || IPHONE || MINIMAL
using OpenTK.Minimal;
#else
using System.Drawing.Imaging;
#endif
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
    #region Types

    // using XID = System.Int32;
    using Window = System.IntPtr;
    using Drawable = System.IntPtr;
    using Font = System.IntPtr;
    using Pixmap = System.IntPtr;
    using Cursor = System.IntPtr;
    using Colormap = System.IntPtr;
    using GContext = System.IntPtr;
    using KeySym = System.IntPtr;
    using Mask = System.IntPtr;
    using Atom = System.IntPtr;
    using VisualID = System.IntPtr;
    using Time = System.IntPtr;
    using KeyCode = System.Byte;    // Or maybe ushort?

    using Display = System.IntPtr;
    using XPointer = System.IntPtr;

    // Randr and Xrandr
    using Bool = System.Boolean;
    using XRRScreenConfiguration = System.IntPtr; // opaque datatype
    using Rotation = System.UInt16;
    using Status = System.Int32;
    using SizeID = System.UInt16;

    #endregion
    
    #region Structs
   
    #endregion

    internal static partial class Functions
    {
        public static readonly object Lock = API.Lock;

        [DllImport("libX11", EntryPoint = "XOpenDisplay")]
        extern static IntPtr sys_XOpenDisplay(IntPtr display);
        public static IntPtr XOpenDisplay(IntPtr display)
        {
            lock (Lock)
            {
                return sys_XOpenDisplay(display);
            }
        }

        [DllImport("libX11", EntryPoint = "XCloseDisplay")]
        public extern static int XCloseDisplay(IntPtr display);
        [DllImport("libX11", EntryPoint = "XSynchronize")]
        public extern static IntPtr XSynchronize(IntPtr display, bool onoff);

        [DllImport("libX11", EntryPoint = "XCreateWindow")]
        public unsafe extern static IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, int depth, int xclass, IntPtr visual, IntPtr valuemask, XSetWindowAttributes* attributes);

        [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]//, CLSCompliant(false)]
        public extern static IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, UIntPtr border, UIntPtr background);
        [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]
        public extern static IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, IntPtr border, IntPtr background);

        [DllImport("libX11", EntryPoint = "XMapWindow")]
        public extern static int XMapWindow(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XUnmapWindow")]
        public extern static int XUnmapWindow(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XMapSubwindows")]
        public extern static int XMapSubindows(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XUnmapSubwindows")]
        public extern static int XUnmapSubwindows(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XRootWindow")]
        public extern static IntPtr XRootWindow(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XNextEvent")]
        public extern static IntPtr XNextEvent(IntPtr display, ref XEvent xevent);
        [DllImport("libX11")]
        public extern static Bool XWindowEvent(Display display, Window w, EventMask event_mask, ref XEvent event_return);
        [DllImport("libX11")]
        public extern static Bool XCheckWindowEvent(Display display, Window w, EventMask event_mask, ref XEvent event_return);
        [DllImport("libX11")]
        public extern static Bool XCheckTypedWindowEvent(Display display, Window w, XEventName event_type, ref XEvent event_return);
        [DllImport("libX11")]
        public extern static Bool XCheckTypedEvent(Display display, XEventName event_type, out XEvent event_return);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate Bool EventPredicate(IntPtr display, ref XEvent e, IntPtr arg);
        [DllImport("libX11")]
        public extern static Bool XIfEvent(Display display, ref XEvent e, IntPtr predicate, IntPtr arg );
        [DllImport("libX11")]
        public extern static Bool XCheckIfEvent(Display display, ref XEvent e, IntPtr predicate, IntPtr arg );

        [DllImport("libX11")]
        public extern static int XConnectionNumber(IntPtr diplay);
        [DllImport("libX11")]
        public extern static int XPending(IntPtr diplay);

        [DllImport("libX11", EntryPoint = "XSelectInput")]
        public extern static int XSelectInput(IntPtr display, IntPtr window, IntPtr mask);

        [DllImport("libX11", EntryPoint = "XDestroyWindow")]
        public extern static int XDestroyWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XReparentWindow")]
        public extern static int XReparentWindow(IntPtr display, IntPtr window, IntPtr parent, int x, int y);

        [DllImport("libX11", EntryPoint = "XMoveResizeWindow")]
        public extern static int XMoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height);

        [DllImport("libX11", EntryPoint = "XMoveWindow")]
        public extern static int XMoveWindow(IntPtr display, IntPtr w, int x, int y);
        
        [DllImport("libX11", EntryPoint = "XResizeWindow")]
        public extern static int XResizeWindow(IntPtr display, IntPtr window, int width, int height);

        [DllImport("libX11", EntryPoint = "XGetWindowAttributes")]
        public extern static int XGetWindowAttributes(IntPtr display, IntPtr window, ref XWindowAttributes attributes);

        [DllImport("libX11", EntryPoint = "XFlush")]
        public extern static int XFlush(IntPtr display);

        [DllImport("libX11", EntryPoint = "XSetWMName")]
        public extern static int XSetWMName(IntPtr display, IntPtr window, ref XTextProperty text_prop);

        [DllImport("libX11", EntryPoint = "XStoreName")]
        public extern static int XStoreName(IntPtr display, IntPtr window, string window_name);

        [DllImport("libX11", EntryPoint = "XFetchName")]
        public extern static int XFetchName(IntPtr display, IntPtr window, ref IntPtr window_name);

        [DllImport("libX11", EntryPoint = "XSendEvent")]
        public extern static int XSendEvent(IntPtr display, IntPtr window, bool propagate, IntPtr event_mask, ref XEvent send_event);

        public static int XSendEvent(IntPtr display, IntPtr window, bool propagate, EventMask event_mask, ref XEvent send_event)
        {
            return XSendEvent(display, window, propagate, new IntPtr((int)event_mask), ref send_event);
        }

        [DllImport("libX11", EntryPoint = "XQueryTree")]
        public extern static int XQueryTree(IntPtr display, IntPtr window, out IntPtr root_return, out IntPtr parent_return, out IntPtr children_return, out int nchildren_return);

        [DllImport("libX11", EntryPoint = "XFree")]
        public extern static int XFree(IntPtr data);

        [DllImport("libX11", EntryPoint = "XRaiseWindow")]
        public extern static int XRaiseWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XLowerWindow")]//, CLSCompliant(false)]
        public extern static uint XLowerWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XConfigureWindow")]//, CLSCompliant(false)]
        public extern static uint XConfigureWindow(IntPtr display, IntPtr window, ChangeWindowAttributes value_mask, ref XWindowChanges values);

        [DllImport("libX11", EntryPoint = "XInternAtom")]
        public extern static IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists);

        [DllImport("libX11", EntryPoint = "XInternAtoms")]
        public extern static int XInternAtoms(IntPtr display, string[] atom_names, int atom_count, bool only_if_exists, IntPtr[] atoms);

        [DllImport("libX11", EntryPoint = "XSetWMProtocols")]
        public extern static int XSetWMProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

        [DllImport("libX11", EntryPoint = "XGrabPointer")]
        public extern static int XGrabPointer(IntPtr display, IntPtr window, bool owner_events, EventMask event_mask, GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr confine_to, IntPtr cursor, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XUngrabPointer")]
        public extern static int XUngrabPointer(IntPtr display, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XGrabButton")]
        public extern static int XGrabButton(IntPtr display,
            int button, uint modifiers, Window grab_window,
            Bool owner_events, EventMask event_mask,
            GrabMode pointer_mode, GrabMode keyboard_mode,
            Window confine_to, Cursor cursor);

        [DllImport("libX11", EntryPoint = "XUngrabButton")]
        public extern static int XUngrabButton(IntPtr display, uint button, uint
              modifiers, Window grab_window);

        [DllImport("libX11", EntryPoint = "XQueryPointer")]
        public extern static bool XQueryPointer(IntPtr display, IntPtr window, out IntPtr root, out IntPtr child, out int root_x, out int root_y, out int win_x, out int win_y, out int keys_buttons);

        [DllImport("libX11", EntryPoint = "XTranslateCoordinates")]
        public extern static bool XTranslateCoordinates(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, out int intdest_x_return, out int dest_y_return, out IntPtr child_return);


        [DllImport("libX11")]
        public extern static int XGrabKey(IntPtr display, int keycode, uint modifiers,
            Window grab_window, bool owner_events, GrabMode pointer_mode, GrabMode keyboard_mode);

        [DllImport("libX11")]
        public extern static int XUngrabKey(IntPtr display, int keycode, uint modifiers, Window grab_window);

        [DllImport("libX11", EntryPoint = "XGrabKeyboard")]
        public extern static int XGrabKeyboard(IntPtr display, IntPtr window, bool owner_events,
            GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr timestamp);

        [DllImport("libX11", EntryPoint = "XUngrabKeyboard")]
        public extern static int XUngrabKeyboard(IntPtr display, IntPtr timestamp);

        [DllImport("libX11")]
        public extern static int XAllowEvents(IntPtr display, EventMode event_mode, Time time);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public extern static bool XGetGeometry(IntPtr display, IntPtr window, out IntPtr root, out int x, out int y, out int width, out int height, out int border_width, out int depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y, out int width, out int height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y, IntPtr width, IntPtr height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XGetGeometry")]
        public extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, IntPtr x, IntPtr y, out int width, out int height, IntPtr border_width, IntPtr depth);

        [DllImport("libX11", EntryPoint = "XWarpPointer")]//, CLSCompliant(false)]
        public extern static uint XWarpPointer(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, uint src_width, uint src_height, int dest_x, int dest_y);

        [DllImport("libX11", EntryPoint = "XClearWindow")]
        public extern static int XClearWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XClearArea")]
        public extern static int XClearArea(IntPtr display, IntPtr window, int x, int y, int width, int height, bool exposures);

        // Colormaps
        [DllImport("libX11", EntryPoint = "XDefaultScreenOfDisplay")]
        public extern static IntPtr XDefaultScreenOfDisplay(IntPtr display);

        [DllImport("libX11", EntryPoint = "XScreenNumberOfScreen")]
        public extern static int XScreenNumberOfScreen(IntPtr display, IntPtr Screen);

        [DllImport("libX11", EntryPoint = "XDefaultVisual")]
        public extern static IntPtr XDefaultVisual(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefaultDepth")]//, CLSCompliant(false)]
        public extern static uint XDefaultDepth(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefaultScreen")]
        public extern static int XDefaultScreen(IntPtr display);

        [DllImport("libX11", EntryPoint = "XDefaultColormap")]
        public extern static IntPtr XDefaultColormap(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XLookupColor")]//, CLSCompliant(false)]
        public extern static int XLookupColor(IntPtr display, IntPtr Colormap, string Coloranem, ref XColor exact_def_color, ref XColor screen_def_color);

        [DllImport("libX11", EntryPoint = "XAllocColor")]//, CLSCompliant(false)]
        public extern static int XAllocColor(IntPtr display, IntPtr Colormap, ref XColor colorcell_def);

        [DllImport("libX11", EntryPoint = "XSetTransientForHint")]
        public extern static int XSetTransientForHint(IntPtr display, IntPtr window, IntPtr prop_window);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref MotifWmHints data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]//, CLSCompliant(false)]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref uint value, int nelements);
        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref int value, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]//, CLSCompliant(false)]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref IntPtr value, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]//, CLSCompliant(false)]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, uint[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, int[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr atoms, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty", CharSet = CharSet.Ansi)]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, string text, int text_length);

        [DllImport("libX11", EntryPoint = "XDeleteProperty")]
        public extern static int XDeleteProperty(IntPtr display, IntPtr window, IntPtr property);

        // Drawing
        [DllImport("libX11", EntryPoint = "XCreateGC")]
        public extern static IntPtr XCreateGC(IntPtr display, IntPtr window, IntPtr valuemask, XGCValues[] values);

        [DllImport("libX11", EntryPoint = "XFreeGC")]
        public extern static int XFreeGC(IntPtr display, IntPtr gc);

        [DllImport("libX11", EntryPoint = "XSetFunction")]
        public extern static int XSetFunction(IntPtr display, IntPtr gc, GXFunction function);

        [DllImport("libX11", EntryPoint = "XSetLineAttributes")]
        public extern static int XSetLineAttributes(IntPtr display, IntPtr gc, int line_width, GCLineStyle line_style, GCCapStyle cap_style, GCJoinStyle join_style);

        [DllImport("libX11", EntryPoint = "XDrawLine")]
        public extern static int XDrawLine(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int x2, int y2);

        [DllImport("libX11", EntryPoint = "XDrawRectangle")]
        public extern static int XDrawRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height);

        [DllImport("libX11", EntryPoint = "XFillRectangle")]
        public extern static int XFillRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height);

        [DllImport("libX11", EntryPoint = "XSetWindowBackground")]
        public extern static int XSetWindowBackground(IntPtr display, IntPtr window, IntPtr background);

        [DllImport("libX11", EntryPoint = "XCopyArea")]
        public extern static int XCopyArea(IntPtr display, IntPtr src, IntPtr dest, IntPtr gc, int src_x, int src_y, int width, int height, int dest_x, int dest_y);

        [DllImport("libX11", EntryPoint = "XGetWindowProperty")]
        public extern static int XGetWindowProperty(IntPtr display, IntPtr window, IntPtr atom, IntPtr long_offset, IntPtr long_length, bool delete, IntPtr req_type, out IntPtr actual_type, out int actual_format, out IntPtr nitems, out IntPtr bytes_after, ref IntPtr prop);

        [DllImport("libX11", EntryPoint = "XSetInputFocus")]
        public extern static int XSetInputFocus(IntPtr display, IntPtr window, RevertTo revert_to, IntPtr time);

        [DllImport("libX11", EntryPoint = "XIconifyWindow")]
        public extern static int XIconifyWindow(IntPtr display, IntPtr window, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefineCursor")]
        public extern static int XDefineCursor(IntPtr display, IntPtr window, IntPtr cursor);

        [DllImport("libX11", EntryPoint = "XUndefineCursor")]
        public extern static int XUndefineCursor(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XFreeCursor")]
        public extern static int XFreeCursor(IntPtr display, IntPtr cursor);

        [DllImport("libX11", EntryPoint = "XCreateFontCursor")]
        public extern static IntPtr XCreateFontCursor(IntPtr display, CursorFontShape shape);

        [DllImport("libX11", EntryPoint = "XCreatePixmapCursor")]//, CLSCompliant(false)]
        public extern static IntPtr XCreatePixmapCursor(IntPtr display, IntPtr source, IntPtr mask, ref XColor foreground_color, ref XColor background_color, int x_hot, int y_hot);

        [DllImport("libX11", EntryPoint = "XCreatePixmapFromBitmapData")]
        public extern static IntPtr XCreatePixmapFromBitmapData(IntPtr display, IntPtr drawable, byte[] data, int width, int height, IntPtr fg, IntPtr bg, int depth);

        [DllImport("libX11", EntryPoint = "XCreatePixmap")]
        public extern static IntPtr XCreatePixmap(IntPtr display, IntPtr d, int width, int height, int depth);

        [DllImport("libX11", EntryPoint = "XFreePixmap")]
        public extern static IntPtr XFreePixmap(IntPtr display, IntPtr pixmap);

        [DllImport("libX11", EntryPoint = "XQueryBestCursor")]
        public extern static int XQueryBestCursor(IntPtr display, IntPtr drawable, int width, int height, out int best_width, out int best_height);

        [DllImport("libX11", EntryPoint = "XQueryExtension")]
        public extern static int XQueryExtension(IntPtr display, string extension_name, out int major, out int first_event, out int first_error);

        [DllImport("libX11", EntryPoint = "XWhitePixel")]
        public extern static IntPtr XWhitePixel(IntPtr display, int screen_no);

        [DllImport("libX11", EntryPoint = "XBlackPixel")]
        public extern static IntPtr XBlackPixel(IntPtr display, int screen_no);

        [DllImport("libX11", EntryPoint = "XGrabServer")]
        public extern static void XGrabServer(IntPtr display);

        [DllImport("libX11", EntryPoint = "XUngrabServer")]
        public extern static void XUngrabServer(IntPtr display);

        [DllImport("libX11", EntryPoint = "XGetWMNormalHints")]
        public extern static int XGetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints, out IntPtr supplied_return);

        [DllImport("libX11", EntryPoint = "XSetWMNormalHints")]
        public extern static void XSetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints);

        [DllImport("libX11", EntryPoint = "XSetZoomHints")]
        public extern static void XSetZoomHints(IntPtr display, IntPtr window, ref XSizeHints hints);

        [DllImport("libX11")]
        public static extern IntPtr XGetWMHints(Display display, Window w); // returns XWMHints*

        [DllImport("libX11")]
        public static extern void XSetWMHints(Display display, Window w, ref XWMHints wmhints);

        [DllImport("libX11")]
        public static extern IntPtr XAllocWMHints();
        
        [DllImport("libX11", EntryPoint = "XGetIconSizes")]
        public extern static int XGetIconSizes(IntPtr display, IntPtr window, out IntPtr size_list, out int count);

        [DllImport("libX11", EntryPoint = "XSetErrorHandler")]
        public extern static IntPtr XSetErrorHandler(XErrorHandler error_handler);

        [DllImport("libX11", EntryPoint = "XGetErrorText")]
        public extern static IntPtr XGetErrorText(IntPtr display, byte code, StringBuilder buffer, int length);

        [DllImport("libX11", EntryPoint = "XInitThreads")]
        public extern static int XInitThreads();

        [DllImport("libX11", EntryPoint = "XConvertSelection")]
        public extern static int XConvertSelection(IntPtr display, IntPtr selection, IntPtr target, IntPtr property, IntPtr requestor, IntPtr time);

        [DllImport("libX11", EntryPoint = "XGetSelectionOwner")]
        public extern static IntPtr XGetSelectionOwner(IntPtr display, IntPtr selection);

        [DllImport("libX11", EntryPoint = "XSetSelectionOwner")]
        public extern static int XSetSelectionOwner(IntPtr display, IntPtr selection, IntPtr owner, IntPtr time);

        [DllImport("libX11", EntryPoint = "XSetPlaneMask")]
        public extern static int XSetPlaneMask(IntPtr display, IntPtr gc, IntPtr mask);

        [DllImport("libX11", EntryPoint = "XSetForeground")]//, CLSCompliant(false)]
        public extern static int XSetForeground(IntPtr display, IntPtr gc, UIntPtr foreground);
        [DllImport("libX11", EntryPoint = "XSetForeground")]
        public extern static int XSetForeground(IntPtr display, IntPtr gc, IntPtr foreground);

        [DllImport("libX11", EntryPoint = "XSetBackground")]//, CLSCompliant(false)]
        public extern static int XSetBackground(IntPtr display, IntPtr gc, UIntPtr background);
        [DllImport("libX11", EntryPoint = "XSetBackground")]
        public extern static int XSetBackground(IntPtr display, IntPtr gc, IntPtr background);

        [DllImport("libX11", EntryPoint = "XBell")]
        public extern static int XBell(IntPtr display, int percent);

        [DllImport("libX11", EntryPoint = "XChangeActivePointerGrab")]
        public extern static int XChangeActivePointerGrab(IntPtr display, EventMask event_mask, IntPtr cursor, IntPtr time);

        [DllImport("libX11", EntryPoint = "XFilterEvent")]
        public extern static bool XFilterEvent(ref XEvent xevent, IntPtr window);

        [DllImport("libX11")]
        public extern static void XPeekEvent(IntPtr display, ref XEvent xevent);

        [DllImport("libX11", EntryPoint = "XGetVisualInfo")]
        static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr vinfo_mask, ref XVisualInfo template, out int nitems);
                                                    
        public static IntPtr XGetVisualInfo(IntPtr display, XVisualInfoMask vinfo_mask, ref XVisualInfo template, out int nitems)
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
        public static extern Status XGetTransientForHint(Display display, Window w, out Window prop_window_return);

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
        public static extern KeyCode XKeysymToKeycode(IntPtr display, KeySym keysym);

        [DllImport("libX11")]
        public static extern KeySym XKeycodeToKeysym(IntPtr display, KeyCode keycode, int index);

        [DllImport("libX11")]
        public static extern int XRefreshKeyboardMapping(ref XMappingEvent event_map);

        [DllImport("libX11")]
        public static extern int XGetEventData(IntPtr display, ref XGenericEventCookie cookie);

        [DllImport("libX11")]
        public static extern void XFreeEventData(IntPtr display, ref XGenericEventCookie cookie);

        [DllImport("libX11")]
        public static extern void XSetClassHint(IntPtr display, IntPtr window, ref XClassHint hint);

        static readonly IntPtr CopyFromParent = IntPtr.Zero;

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

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct  Pixel
        {
            public byte A, R, G, B;
            public Pixel(byte a, byte r, byte g, byte b)
            {
                A= a;
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
        public static IntPtr CreatePixmapFromImage(Display display, Bitmap image) 
        { 
            int width = image.Width;
            int height = image.Height;

            BitmapData data = image.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);
            
            IntPtr ximage = XCreateImage(display, CopyFromParent, 24, ImageFormat.ZPixmap, 
                0, data.Scan0, (uint)width, (uint)height, 32, 0); 
            IntPtr pixmap = XCreatePixmap(display, XDefaultRootWindow(display), 
                width, height, 24); 
            IntPtr gc = XCreateGC(display, pixmap, IntPtr.Zero, null);
            
            XPutImage(display, pixmap, gc, ximage, 0, 0, 0, 0, (uint)width, (uint)height);
            
            XFreeGC(display, gc);
            image.UnlockBits(data);

            return pixmap; 
        } 
        
        public static IntPtr CreateMaskFromImage(Display display, Bitmap image) 
        { 
            int width = image.Width; 
            int height = image.Height; 
            int stride = (width + 7) >> 3; 
            byte[] mask = new byte[stride * height];
            bool msbfirst = (XBitmapBitOrder(display) == 1); // 1 = MSBFirst
        
            for (int y = 0; y < height; ++y) 
            { 
                for (int x = 0; x < width; ++x) 
                { 
                    byte bit = (byte) (1 << (msbfirst ? (7 - (x & 7)) : (x & 7))); 
                    int offset = y * stride + (x >> 3); 
        
                    if (image.GetPixel(x, y).A >= 128) 
                        mask[offset] |= bit; 
                } 
            } 
        
            Pixmap pixmap = XCreatePixmapFromBitmapData(display, XDefaultRootWindow(display), 
                mask, width, height, new IntPtr(1), IntPtr.Zero, 1); 
        
            return pixmap; 
        }
    }
}
