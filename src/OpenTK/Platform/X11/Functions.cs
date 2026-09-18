/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */

using System;
#if !MINIMAL
using System.Drawing;
#endif
#if ANDROID || IPHONE || MINIMAL
using OpenTK.Minimal;
#else
using System.Drawing.Imaging;
#endif
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
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



    internal static partial class Functions
    {
        public static readonly object Lock = API.Lock;

        [DllImport("libX11", EntryPoint = "XOpenDisplay")]
        private extern static IntPtr sys_XOpenDisplay(IntPtr display);

        /// <summary>Opens an X11 display</summary>
        /// <param name="display">The display to open</param>
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

        /// <summary>Creates an unmapped sub-window for the specified parent window, and causes the XServer to generate a CreateNotify event</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="parent">The parent window</param>
        /// <param name="x">X co-ordinate of the top-left of the window, relative to the parent window</param>
        /// <param name="y">Y co-ordinate of the top-left of the window, relative to the parent window</param>
        /// <param name="width">Width of the window</param>
        /// <param name="height">Height of the window</param>
        /// <param name="border_width">Width of the window's border</param>
        /// <param name="depth">The window's depth</param>
        /// <param name="xclass">The window's class</param>
        /// <param name="visual">The visual type</param>
        /// <param name="valuemask">Specifies which window attributs are defined in the attributes argument</param>
        /// <param name="attributes">The window's attributes</param>
        [DllImport("libX11", EntryPoint = "XCreateWindow")]
        public unsafe extern static IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, int depth, int xclass, IntPtr visual, IntPtr valuemask, XSetWindowAttributes* attributes);

        [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]//, CLSCompliant(false)]
        public extern static IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, UIntPtr border, UIntPtr background);
        [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]
        public extern static IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, IntPtr border, IntPtr background);

        /// <summary>Maps the specified window and all sub-windows which have map requests</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to map</param>
        [DllImport("libX11", EntryPoint = "XMapWindow")]
        public extern static int XMapWindow(IntPtr display, IntPtr window);
        
        /// <summary>Unmaps the specified window, and causes the XServer to generate an UnmapNotify event</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to unmap</param>
        [DllImport("libX11", EntryPoint = "XUnmapWindow")]
        public extern static int XUnmapWindow(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XMapSubwindows")]
        public extern static int XMapSubindows(IntPtr display, IntPtr window);
        [DllImport("libX11", EntryPoint = "XUnmapSubwindows")]
        public extern static int XUnmapSubwindows(IntPtr display, IntPtr window);

        /// <summary>Returns the root window for the specified screen</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="screen_number">The screen number</param>
        [DllImport("libX11", EntryPoint = "XRootWindow")]
        public extern static IntPtr XRootWindow(IntPtr display, int screen_number);

        [DllImport("libX11", EntryPoint = "XNextEvent")]
        public extern static IntPtr XNextEvent(IntPtr display, ref XEvent xevent);
        [DllImport("libX11")]
        public extern static Bool XWindowEvent(Display display, Window w, EventMask event_mask, ref XEvent event_return);
        
        /// <summary>Searches the event queue for an event matching the specified window and event mask</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="w">The window to match</param>
        /// <param name="event_mask">The event mask</param>
        /// <param name="event_return">The returned event</param>
        /// <returns>TRUE if a matching event is found, FALSE otherwise</returns>
        [DllImport("libX11")]
        public extern static Bool XCheckWindowEvent(Display display, Window w, EventMask event_mask, ref XEvent event_return);
        
        /// <summary>Searches the event queue for an event matching the specified window and event name</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="w">The window to match</param>
        /// <param name="event_type">The event name</param>
        /// <param name="event_return">The returned event</param>
        /// <returns>TRUE if a matching event is found, FALSE otherwise</returns>
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

        /// <summary>Destroys the specified window and all sub-windows, and causes the XServer to generate a DestroyNotify event</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to destroy</param>
        [DllImport("libX11", EntryPoint = "XDestroyWindow")]
        public extern static int XDestroyWindow(IntPtr display, IntPtr window);

        [DllImport("libX11", EntryPoint = "XReparentWindow")]
        public extern static int XReparentWindow(IntPtr display, IntPtr window, IntPtr parent, int x, int y);

        /// <summary>Changes the size and location of the specified window without raising it</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to modify</param>
        /// <param name="x">The new X co-ordinate relative to the window's parent</param>
        /// <param name="y">The new Y co-ordinate relative to the window's parent</param>
        /// <param name="width">The new width</param>
        /// <param name="height">The new height</param>
        [DllImport("libX11", EntryPoint = "XMoveResizeWindow")]
        public extern static int XMoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height);

        /// <summary>Changes the location of the specified window without raising it</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to modify</param>
        /// <param name="x">The new X co-ordinate relative to the window's parent</param>
        /// <param name="y">The new Y co-ordinate relative to the window's parent</param>
        [DllImport("libX11", EntryPoint = "XMoveWindow")]
        public extern static int XMoveWindow(IntPtr display, IntPtr window, int x, int y);

        
        /// <summary>Changes the size of the specified window without raising it</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to modify</param>
        /// <param name="width">The new width</param>
        /// <param name="height">The new height</param>
        [DllImport("libX11", EntryPoint = "XResizeWindow")]
        public extern static int XResizeWindow(IntPtr display, IntPtr window, int width, int height);

        [DllImport("libX11", EntryPoint = "XGetWindowAttributes")]
        public extern static int XGetWindowAttributes(IntPtr display, IntPtr window, ref XWindowAttributes attributes);

        /// <summary>Flushes the output buffer</summary>
        /// <param name="display">The display connection to the XServer</param>
        [DllImport("libX11", EntryPoint = "XFlush")]
        public extern static int XFlush(IntPtr display);

        [DllImport("libX11", EntryPoint = "XSetWMName")]
        public extern static int XSetWMName(IntPtr display, IntPtr window, ref XTextProperty text_prop);

        /// <summary>Sets the window name for the specified window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window</param>
        /// <param name="window_name">The window name</param>
        ///<remarks>This function does not support Unicode window names</remarks>
        [DllImport("libX11", EntryPoint = "XStoreName")]
        public extern static int XStoreName(IntPtr display, IntPtr window, string window_name);

        /// <summary>Gets the window name for the specified window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window</param>
        /// <param name="window_name">The window name</param>
        ///<remarks>This function does not support Unicode window names</remarks>
        [DllImport("libX11", EntryPoint = "XFetchName")]
        public extern static int XFetchName(IntPtr display, IntPtr window, ref IntPtr window_name);

        /// <summary>Sends an XEvent to a window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to recieve the event</param>
        /// <param name="propagate">Whether the event should propagate to clients</param>
        /// <param name="event_mask">Event mask, used for propagation on clients</param>
        /// <param name="send_event">The event to be sent</param>
        [DllImport("libX11", EntryPoint = "XSendEvent")]
        public extern static int XSendEvent(IntPtr display, IntPtr window, bool propagate, IntPtr event_mask, ref XEvent send_event);

        /// <summary>Sends an XEvent to a window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to recieve the event</param>
        /// <param name="propagate">Whether the event should propagate to clients</param>
        /// <param name="event_mask">Event mask, used for propagation on clients</param>
        /// <param name="send_event">The event to be sent</param>
        public static int XSendEvent(IntPtr display, IntPtr window, bool propagate, EventMask event_mask, ref XEvent send_event)
        {
            return XSendEvent(display, window, propagate, new IntPtr((int)event_mask), ref send_event);
        }

        [DllImport("libX11", EntryPoint = "XQueryTree")]
        public extern static int XQueryTree(IntPtr display, IntPtr window, out IntPtr root_return, out IntPtr parent_return, out IntPtr children_return, out int nchildren_return);

        /// <summary>General purpose Xlib routine which frees the specified data</summary>
        /// <param name="data">The data to free</param>
        [DllImport("libX11", EntryPoint = "XFree")]
        public extern static int XFree(IntPtr data);

        /// <summary>Raises the specified window to the top of the stack</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to raise</param>
        [DllImport("libX11", EntryPoint = "XRaiseWindow")]
        public extern static int XRaiseWindow(IntPtr display, IntPtr window);

        /// <summary>Lowers the specified window to the bottom of the stack</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to lower</param>
        [DllImport("libX11", EntryPoint = "XLowerWindow")]
        public extern static uint XLowerWindow(IntPtr display, IntPtr window);

        /// <summary>Reconfigures the window's size, position and stacking order</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to configure</param>
        /// <param name="value_mask">Specifies which values are to be set</param>
        /// <param name="values">Contains the new window size, position and stacking order</param>
        ///<remarks>Any values not specified to be set by value_mask are taken from the existing geometry of the window</remarks>
        [DllImport("libX11", EntryPoint = "XConfigureWindow")]
        public extern static uint XConfigureWindow(IntPtr display, IntPtr window, ChangeWindowAttributes value_mask, ref XWindowChanges values);

        /// <summary>Gets an X atom</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="atom_name">The atom name</param>
        /// <param name="only_if_exists">If FALSE, the atom will be created if it does not exist</param>
        [DllImport("libX11", EntryPoint = "XInternAtom")]
        public extern static IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists);

        [DllImport("libX11", EntryPoint = "XInternAtoms")]
        public extern static int XInternAtoms(IntPtr display, string[] atom_names, int atom_count, bool only_if_exists, IntPtr[] atoms);

        /// <summary>Gets the name associated with the specified atom</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="atom">The atom</param>
        /// <returns>A pointer to the string containing the atom name</returns>
        [DllImport("libX11", EntryPoint = "XGetAtomName")]
        public extern static IntPtr XGetAtomName(IntPtr display, IntPtr atom);

        /// <summary>Replaces a window's WM_PROTOCOLS property with the list of specified atoms</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to modify</param>
        /// <param name="protocols">The new WM_PROTOCOLS atom list</param>
        /// <param name="count">The number of elements in the protocols array</param>
        /// <returns></returns>
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

        /// <summary>If TRUE, it takes the src_x and src_y coordinates relative to the source window's origin and returns these coordinates to dest_x_return and dest_y_return relative to the destination window's origin.
        /// If FALSE, src_w and dest_w are on different screens, and dest_x_return and dest_y_return are zero.
        /// If the coordinates are contained in a mapped child of dest_w, that child is returned to child_return.
        /// Otherwise, child_return is set to None.</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="src_w">The source window</param>
        /// <param name="dest_w">The destination window</param>
        /// <param name="src_x">X-coordinate within the source window</param>
        /// <param name="src_y">Y-coordinate within the source window</param>
        /// <param name="dest_x_return">X-coordinate within the destination window</param>
        /// <param name="dest_y_return">Y-coordinate within the destination window</param>
        /// <param name="child_return">The child window, if coordinates are within a mapped child of the destination window</param>
        [DllImport("libX11", EntryPoint = "XTranslateCoordinates")]
        public extern static bool XTranslateCoordinates(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, out int dest_x_return, out int dest_y_return, out IntPtr child_return);


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

        /// <summary>Alters an X11 property on the specified window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to change or create the property on</param>
        /// <param name="property">Property name</param>
        /// <param name="type">The property type</param>
        /// <param name="format">Specifies whether the data should be viewed as a 8, 16 or 32-bit value list</param>
        /// <param name="mode">The operation mode</param>
        /// <param name="data">Property data</param>
        /// <param name="nelements">The number of elements in the specified data format</param>
        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr[] data, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty")]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr atoms, int nelements);

        [DllImport("libX11", EntryPoint = "XChangeProperty", CharSet = CharSet.Ansi)]
        public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, byte[] text, int text_length);

        /// <summary>Deletes a specified XProperty from the window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window</param>
        /// <param name="property">The property to delete</param>
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

        /// <summary>If supported by the client Window Manager, the window will be iconified (minimized) if in normal state</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="window">The window to iconify (minimize)</param>
        /// <param name="screen_number">The screen number on the host XServer</param>
        [DllImport("libX11", EntryPoint = "XIconifyWindow")]
        public extern static int XIconifyWindow(IntPtr display, IntPtr window, int screen_number);

        [DllImport("libX11", EntryPoint = "XDefineCursor")]
        public extern static int XDefineCursor(IntPtr display, IntPtr window, IntPtr cursor);

        [DllImport("libX11", EntryPoint = "XUndefineCursor")]
        public extern static int XUndefineCursor(IntPtr display, IntPtr window);

        /// <summary>Deletes the specified cursor</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="cursor">Pointer to the cursor to delete</param>
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

        /// <summary>Gets the window manager hints for the specified window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="w">The window to retrieve the hints for</param>
        /// <returns>NULL if no hints are set, otherwise a pointer to the <see cref="XWMHints"/> structure</returns>
        [DllImport("libX11")]
        public static extern IntPtr XGetWMHints(Display display, Window w);

        /// <summary>Sets the window manager hints for the specified window</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="w">The window to set the hints on</param>
        /// <param name="wmhints">The <see cref="XWMHints"/> to set</param>
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
        private static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr vinfo_mask, ref XVisualInfo template, out int nitems);

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

        /// <summary>Flushes the output buffer, and then waits until all requests have been recieved and processed by the specified XServer</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="discard">Whether all events on the event queue are to be discarded</param>
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

        /// <summary>Allocates the memory needed for an XImage structure</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="visual">Pointer to the visual structure</param>
        /// <param name="depth">Depth of the image</param>
        /// <param name="format">Format of the image</param>
        /// <param name="offset">Number of pixels to ignore at the beginning of the scanline</param>
        /// <param name="data">The image data</param>
        /// <param name="width">Width of the image in pixels</param>
        /// <param name="height">Height of the image in pixels</param>
        /// <param name="bitmap_pad">Quantum of a scanline (8, 16 or 32)</param>
        /// <param name="bytes_per_line">Number of bytes in the client image between scanlines</param>
        /// <returns></returns>
        [DllImport("libX11")]
        public static extern IntPtr XCreateImage(Display display, IntPtr visual,
            uint depth, ImageFormat format, int offset, IntPtr data, uint width, uint height,
            int bitmap_pad, int bytes_per_line);

        /// <summary>Combines an image with a rectangle of the specified drawable</summary>
        /// <param name="display">The display connection to the XServer</param>
        /// <param name="drawable">Pointer to the drawable</param>
        /// <param name="gc">Pointer to the GC</param>
        /// <param name="image">Pointer to the image to be combined with the rectangle</param>
        /// <param name="src_x">The offset in X from the left edge of the image</param>
        /// <param name="src_y">The offset in Y from the top edge of the image</param>
        /// <param name="dest_x">The destination X coordinate relative to the origin of the drawable</param>
        /// <param name="dest_y">The destination Y coordinate relative to the origin of the drawable</param>
        /// <param name="width">The width of the sub-image</param>
        /// <param name="height">The height of the sub-image</param>
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

        private static readonly IntPtr CopyFromParent = IntPtr.Zero;

        /// <summary>Sends an X11 event to the specified window</summary>
        /// <param name="window">The window recieving the event</param>
        /// <param name="message_type">The X11 message type</param>
        /// <param name="l0"></param>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        public static void SendNetWMMessage(X11WindowInfo window, IntPtr message_type, IntPtr l0, IntPtr l1, IntPtr l2)
        {
            XEvent xev = new XEvent();
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

        /// <summary>Sends an X11 client message to the specified window</summary>
        /// <param name="window">The window recieving the event</param>
        /// <param name="message_type">The X11 message type</param>
        /// <param name="l0"></param>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
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

        /// <summary>Creates an X11 pixmap from a Bitmap</summary>
        /// <param name="display">The display the pixmap is to be associated with</param>
        /// <param name="image">The image to convert to a pixmap</param>
        /// <returns>The pointer to the created pixmap</returns>
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

        /// <summary>Creates an X11 pixmap mask from a Bitmap</summary>
        /// <param name="display">The display the pixmap mask is to be associated with</param>
        /// <param name="image">The image to convert to a pixmap mask</param>
        /// <returns>The pointer to the created pixmap mask</returns>
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
                    byte bit = (byte)(1 << (msbfirst ? (7 - (x & 7)) : (x & 7)));
                    int offset = y * stride + (x >> 3);

                    if (image.GetPixel(x, y).A >= 128)
                    {
                        mask[offset] |= bit;
                    }
                }
            }

            Pixmap pixmap = XCreatePixmapFromBitmapData(display, XDefaultRootWindow(display),
                mask, width, height, new IntPtr(1), IntPtr.Zero, 1);

            return pixmap;
        }
    }
}
