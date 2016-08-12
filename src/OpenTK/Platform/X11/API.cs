#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

#pragma warning disable 3019    // CLS-compliance checking
#pragma warning disable 0649    // struct members not explicitly initialized
#pragma warning disable 0169    // field / method is never used.
#pragma warning disable 0414    // field assigned but never used.

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

    using XcursorBool = System.Int32;
    using XcursorUInt = System.UInt32;
    using XcursorDim = System.UInt32;
    using XcursorPixel = System.UInt32;

    // Randr and Xrandr
    using Bool = System.Boolean;
    using XRRScreenConfiguration = System.IntPtr; // opaque datatype
    using Rotation = System.UInt16;
    using Status = System.Int32;
    using SizeID = System.UInt16;

    #endregion

    #region internal static class API

    internal static class API
    {
        #region --- Fields ---

        private const string _dll_name = "libX11";
        private const string _dll_name_vid = "libXxf86vm";

        static Display defaultDisplay;
        static int defaultScreen;
        static Window rootWindow;
        static int screenCount;

        internal static Display DefaultDisplay { get { return defaultDisplay; } }
        static int DefaultScreen { get { return defaultScreen; } }
        //internal static Window RootWindow { get { return rootWindow; } }
        internal static int ScreenCount { get { return screenCount; } }
        
        internal static object Lock = new object();

        #endregion

        static API()
        {
            int has_threaded_x = Functions.XInitThreads();
            Debug.Print("Initializing threaded X11: {0}.", has_threaded_x.ToString());
        
            defaultDisplay = Functions.XOpenDisplay(IntPtr.Zero);
                
            if (defaultDisplay == IntPtr.Zero)
                throw new PlatformException("Could not establish connection to the X-Server.");

            using (new XLock(defaultDisplay))
            {
                screenCount = Functions.XScreenCount(DefaultDisplay);
            }
            Debug.Print("Display connection: {0}, Screen count: {1}", DefaultDisplay, ScreenCount);

            //AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
        }

        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            if (defaultDisplay != IntPtr.Zero)
            {
                Functions.XCloseDisplay(defaultDisplay);
                defaultDisplay = IntPtr.Zero;
                defaultScreen = 0;
                rootWindow = IntPtr.Zero;
            }
        }

        // Display management
        //[DllImport(_dll_name, EntryPoint = "XOpenDisplay")]
        //extern public static IntPtr OpenDisplay([MarshalAs(UnmanagedType.LPTStr)] string display_name);

        //[DllImport(_dll_name, EntryPoint = "XCloseDisplay")]
        //extern public static void CloseDisplay(Display display);

        //[DllImport(_dll_name, EntryPoint = "XCreateColormap")]
        //extern public static IntPtr CreateColormap(Display display, Window window, IntPtr visual, int alloc);

        #region Window handling

        [DllImport(_dll_name, EntryPoint = "XCreateSimpleWindow")]
        public extern static Window CreateSimpleWindow(
            Display display,
            Window parent,
            int x, int y,
            int width, int height,
            int border_width,
            long border,
            long background
        );

        [DllImport(_dll_name, EntryPoint = "XResizeWindow")]
        public extern static int XResizeWindow(Display display, Window window, int width, int height);

        [DllImport(_dll_name, EntryPoint = "XDestroyWindow")]
        public extern static void DestroyWindow(Display display, Window window);

        [DllImport(_dll_name, EntryPoint = "XMapWindow")]
        extern public static void MapWindow(Display display, Window window);

        [DllImport(_dll_name, EntryPoint = "XMapRaised")]
        extern public static void MapRaised(Display display, Window window);

        #endregion

        [DllImport(_dll_name, EntryPoint = "XDefaultVisual")]
        extern public static IntPtr DefaultVisual(Display display, int screen_number);

        #region XFree

        /// <summary>
        /// Frees the memory used by an X structure. Only use on unmanaged structures!
        /// </summary>
        /// <param name="buffer">A pointer to the structure that will be freed.</param>
        [DllImport(_dll_name, EntryPoint = "XFree")]
        extern public static void Free(IntPtr buffer);

        #endregion

        #region Event queue management

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(_dll_name, EntryPoint = "XEventsQueued")]
        extern public static int EventsQueued(Display display, int mode);

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(_dll_name, EntryPoint = "XPending")]
        extern public static int Pending(Display display);

        //[System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(_dll_name, EntryPoint = "XNextEvent")]
        extern public static void NextEvent(
            Display display,
            [MarshalAs(UnmanagedType.AsAny)][In, Out]object e);

        [DllImport(_dll_name, EntryPoint = "XNextEvent")]
        extern public static void NextEvent(Display display, [In, Out] IntPtr e);

        [DllImport(_dll_name, EntryPoint = "XPeekEvent")]
        extern public static void PeekEvent(
            Display display,
            [MarshalAs(UnmanagedType.AsAny)][In, Out]object event_return
        );

        [DllImport(_dll_name, EntryPoint = "XPeekEvent")]
        extern public static void PeekEvent(Display display, [In, Out]XEvent event_return);

        [DllImport(_dll_name, EntryPoint = "XSendEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        extern public static bool SendEvent(Display display, Window window, bool propagate,
            [MarshalAs(UnmanagedType.SysInt)]EventMask event_mask, ref XEvent event_send);

        /// <summary>
        /// The XSelectInput() function requests that the X server report the events associated
        /// with the specified event mask.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="w">Specifies the window whose events you are interested in.</param>
        /// <param name="event_mask">Specifies the event mask.</param>
        /// <remarks>
        /// Initially, X will not report any of these events.
        /// Events are reported relative to a window.
        /// If a window is not interested in a device event,
        /// it usually propagates to the closest ancestor that is interested,
        /// unless the do_not_propagate mask prohibits it.
        /// Setting the event-mask attribute of a window overrides any previous call for the same window but not for other clients. Multiple clients can select for the same events on the same window with the following restrictions: 
        /// <para>Multiple clients can select events on the same window because their event masks are disjoint. When the X server generates an event, it reports it to all interested clients. </para>
        /// <para>Only one client at a time can select CirculateRequest, ConfigureRequest, or MapRequest events, which are associated with the event mask SubstructureRedirectMask. </para>
        /// <para>Only one client at a time can select a ResizeRequest event, which is associated with the event mask ResizeRedirectMask. </para>
        /// <para>Only one client at a time can select a ButtonPress event, which is associated with the event mask ButtonPressMask. </para>
        /// <para>The server reports the event to all interested clients. </para>
        /// <para>XSelectInput() can generate a BadWindow error.</para>
        /// </remarks>
        [DllImport(_dll_name, EntryPoint = "XSelectInput")]
        public static extern void SelectInput(Display display, Window w, EventMask event_mask);

        /// <summary>
        /// When the predicate procedure finds a match, XCheckIfEvent() copies the matched event into the client-supplied XEvent structure and returns True. (This event is removed from the queue.) If the predicate procedure finds no match, XCheckIfEvent() returns False, and the output buffer will have been flushed. All earlier events stored in the queue are not discarded.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="event_return">Returns a copy of the matched event's associated structure.</param>
        /// <param name="predicate">Specifies the procedure that is to be called to determine if the next event in the queue matches what you want</param>
        /// <param name="arg">Specifies the user-supplied argument that will be passed to the predicate procedure.</param>
        /// <returns>true if the predicate returns true for some event, false otherwise</returns>
        [DllImport(_dll_name, EntryPoint = "XCheckIfEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckIfEvent(Display display, ref XEvent event_return,
            /*[MarshalAs(UnmanagedType.FunctionPtr)] */ CheckEventPredicate predicate, /*XPointer*/ IntPtr arg);

        [DllImport(_dll_name, EntryPoint = "XIfEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IfEvent(Display display, ref XEvent event_return,
            /*[MarshalAs(UnmanagedType.FunctionPtr)] */ CheckEventPredicate predicate, /*XPointer*/ IntPtr arg);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool CheckEventPredicate(Display display, ref XEvent @event, IntPtr arg);

        [DllImport(_dll_name, EntryPoint = "XCheckMaskEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckMaskEvent(Display display, EventMask event_mask, ref XEvent event_return);

        #endregion

        #region Pointer and Keyboard functions

        [DllImport(_dll_name, EntryPoint = "XGrabPointer")]
        extern public static ErrorCodes GrabPointer(Display display, IntPtr grab_window,
            bool owner_events, int event_mask, GrabMode pointer_mode, GrabMode keyboard_mode,
            IntPtr confine_to, IntPtr cursor, int time);

        [DllImport(_dll_name, EntryPoint = "XUngrabPointer")]
        extern public static ErrorCodes UngrabPointer(Display display, int time);

        [DllImport(_dll_name, EntryPoint = "XGrabKeyboard")]
        extern public static ErrorCodes GrabKeyboard(Display display, IntPtr grab_window,
            bool owner_events, GrabMode pointer_mode, GrabMode keyboard_mode, int time);

        [DllImport(_dll_name, EntryPoint = "XUngrabKeyboard")]
        extern public static void UngrabKeyboard(Display display, int time);

        /// <summary>
        /// The XGetKeyboardMapping() function returns the symbols for the specified number of KeyCodes starting with first_keycode.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="first_keycode">Specifies the first KeyCode that is to be returned.</param>
        /// <param name="keycode_count">Specifies the number of KeyCodes that are to be returned</param>
        /// <param name="keysyms_per_keycode_return">Returns the number of KeySyms per KeyCode.</param>
        /// <returns></returns>
        /// <remarks>
        /// <para>The value specified in first_keycode must be greater than or equal to min_keycode as returned by XDisplayKeycodes(), or a BadValue error results. In addition, the following expression must be less than or equal to max_keycode as returned by XDisplayKeycodes(): </para>
        /// <para>first_keycode + keycode_count - 1 </para>
        /// <para>If this is not the case, a BadValue error results. The number of elements in the KeySyms list is: </para>
        /// <para>keycode_count * keysyms_per_keycode_return </para>
        /// <para>KeySym number N, counting from zero, for KeyCode K has the following index in the list, counting from zero: </para>
        /// <para> (K - first_code) * keysyms_per_code_return + N </para>
        /// <para>The X server arbitrarily chooses the keysyms_per_keycode_return value to be large enough to report all requested symbols. A special KeySym value of NoSymbol is used to fill in unused elements for individual KeyCodes. To free the storage returned by XGetKeyboardMapping(), use XFree(). </para>
        /// <para>XGetKeyboardMapping() can generate a BadValue error.</para>
        /// <para>Diagnostics:</para>
        /// <para>BadValue:    Some numeric value falls outside the range of values accepted by the request. Unless a specific range is specified for an argument, the full range defined by the argument's type is accepted. Any argument defined as a set of alternatives can generate this error.</para>
        /// </remarks>
        [DllImport(_dll_name, EntryPoint = "XGetKeyboardMapping")]
        public static extern KeySym GetKeyboardMapping(Display display, KeyCode first_keycode, int keycode_count,
            ref int keysyms_per_keycode_return);

        /// <summary>
        /// The XDisplayKeycodes() function returns the min-keycodes and max-keycodes supported by the specified display.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="min_keycodes_return">Returns the minimum number of KeyCodes</param>
        /// <param name="max_keycodes_return">Returns the maximum number of KeyCodes.</param>
        /// <remarks> The minimum number of KeyCodes returned is never less than 8, and the maximum number of KeyCodes returned is never greater than 255. Not all KeyCodes in this range are required to have corresponding keys.</remarks>
        [DllImport(_dll_name, EntryPoint = "XDisplayKeycodes")]
        public static extern void DisplayKeycodes(Display display, ref int min_keycodes_return, ref int max_keycodes_return);

        #endregion

        #region Xf86VidMode internal structures

        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeModeLine
        {
            public short hdisplay;   /* Number of display pixels horizontally */
            public short hsyncstart; /* Horizontal sync start */
            public short hsyncend;   /* Horizontal sync end */
            public short htotal;     /* Total horizontal pixels */
            public short vdisplay;   /* Number of display pixels vertically */
            public short vsyncstart; /* Vertical sync start */
            public short vsyncend;   /* Vertical sync start */
            public short vtotal;     /* Total vertical pixels */
            public int flags;      /* Mode flags */
            public int privsize;   /* Size of private */
            public IntPtr _private;   /* Server privates */
        }

        /// <summary>
        /// Specifies an XF86 display mode.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeModeInfo
        {
            /// <summary>
            /// Pixel clock.
            /// </summary>
            public int dotclock;

            /// <summary>
            /// Number of display pixels horizontally
            /// </summary>
            public short hdisplay;

            /// <summary>
            /// Horizontal sync start
            /// </summary>
            public short hsyncstart;

            /// <summary>
            /// Horizontal sync end
            /// </summary>
            public short hsyncend;

            /// <summary>
            /// Total horizontal pixel
            /// </summary>
            public short htotal;

            /// <summary>
            /// 
            /// </summary>
            public short hskew;

            /// <summary>
            /// Number of display pixels vertically
            /// </summary>
            public short vdisplay;

            /// <summary>
            /// Vertical sync start
            /// </summary>
            public short vsyncstart;

            /// <summary>
            /// Vertical sync end
            /// </summary>
            public short vsyncend;

            /// <summary>
            /// Total vertical pixels
            /// </summary>
            public short vtotal;

            /// <summary>
            /// 
            /// </summary>
            public short vskew;

            /// <summary>
            /// Mode flags
            /// </summary>
            public int flags;

            int privsize;   /* Size of private */
            IntPtr _private;   /* Server privates */
        }

        //Monitor information:
        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeMonitor
        {
            [MarshalAs(UnmanagedType.LPStr)]
            string vendor;     /* Name of manufacturer */
            [MarshalAs(UnmanagedType.LPStr)]
            string model;      /* Model name */
            float EMPTY;      /* unused, for backward compatibility */
            byte nhsync;     /* Number of horiz sync ranges */
            /*XF86VidModeSyncRange* */
            IntPtr hsync;/* Horizontal sync ranges */
            byte nvsync;     /* Number of vert sync ranges */
            /*XF86VidModeSyncRange* */
            IntPtr vsync;/* Vertical sync ranges */
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeSyncRange
        {
            float hi;         /* Top of range */
            float lo;         /* Bottom of range */
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeNotifyEvent
        {
            int type;                      /* of event */
            ulong serial;          /* # of last request processed by server */
            bool send_event;               /* true if this came from a SendEvent req */
            Display display;              /* Display the event was read from */
            IntPtr root;                   /* root window of event screen */
            int state;                     /* What happened */
            int kind;                      /* What happened */
            bool forced;                   /* extents of new region */
            /* Time */
            IntPtr time;                     /* event timestamp */
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeGamma
        {
            float red;                     /* Red Gamma value */
            float green;                   /* Green Gamma value */
            float blue;                    /* Blue Gamma value */
        }
        #endregion

        #region libXxf86vm Functions

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeQueryExtension(
            Display display,
            out int event_base_return,
            out int error_base_return);
        /*
        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeSwitchMode(
            Display display,
            int screen,
            int zoom);
        */

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeSwitchToMode(
            Display display,
            int screen,
            IntPtr
            /*XF86VidModeModeInfo* */ modeline);


        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeQueryVersion(
            Display display,
            out int major_version_return,
            out int minor_version_return);

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeGetModeLine(
            Display display,
            int screen,
            out int dotclock_return,
            out XF86VidModeModeLine modeline);

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeGetAllModeLines(
            Display display,
            int screen,
            out int modecount_return,
            /*XF86VidModeModeInfo***  <-- yes, that's three *'s. */
            out IntPtr modesinfo);

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeGetViewPort(
            Display display,
            int screen,
            out int x_return,
            out int y_return);

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeSetViewPort(
            Display display,
            int screen,
            int x,
            int y);

        /*
Bool XF86VidModeSetClientVersion(
    Display *display);

Bool XF86VidModeDeleteModeLine(
    Display *display,
    int screen,
    XF86VidModeModeInfo *modeline);

Bool XF86VidModeModModeLine(
    Display *display,
    int screen,
    XF86VidModeModeLine *modeline);

Status XF86VidModeValidateModeLine(
    Display *display,
    int screen,
    XF86VidModeModeLine *modeline);

Bool XF86VidModeLockModeSwitch(
    Display *display,
    int screen,
    int lock);

Bool XF86VidModeGetMonitor(
    Display *display,
    int screen,
    XF86VidModeMonitor *monitor);

XF86VidModeGetDotClocks(
    Display *display,
    int screen,
    int *flags return,
    int *number of clocks return,
    int *max dot clock return,
    int **clocks return);

XF86VidModeGetGamma(
    Display *display,
    int screen,
    XF86VidModeGamma *Gamma);

XF86VidModeSetGamma(
    Display *display,
    int screen,
    XF86VidModeGamma *Gamma);

XF86VidModeGetGammaRamp(
    Display *display,
    int screen,
    int size,
    unsigned short *red array,
    unsigned short *green array,
    unsigned short *blue array);

XF86VidModeSetGammaRamp(
    Display *display,
    int screen,
    int size,
    unsigned short *red array,
    unsigned short *green array,
    unsigned short *blue array);

XF86VidModeGetGammaRampSize(
    Display *display,
    int screen,
    int *size);
         * */

        #endregion

        [DllImport(_dll_name, EntryPoint = "XLookupKeysym")]
        public static extern KeySym LookupKeysym(ref XKeyEvent key_event, int index);

    }
    #endregion

    #region X11 Structures

    #region Xcursor

    [StructLayout(LayoutKind.Sequential)]
    unsafe struct XcursorImage
    {
        public XcursorUInt version;
        public XcursorDim size;
        public XcursorDim width;
        public XcursorDim height;
        public XcursorDim xhot;
        public XcursorDim yhot;
        public XcursorUInt delay;
        public XcursorPixel* pixels;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    unsafe struct XcursorImages 
    {
        public int nimage;
        public XcursorImage **images;
        public char *name;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    unsafe struct XcursorCursors 
    {
        public Display dpy;
        public int refcount;
        public int ncursor;
        public Cursor *cursors;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    unsafe struct XcursorAnimate 
    {
        public XcursorCursors *cursors;
        public int sequence;
    }

    #endregion

    #region internal class XVisualInfo

    [StructLayout(LayoutKind.Sequential)]
    struct XVisualInfo
    {
        public IntPtr Visual;
        public VisualID VisualID;
        public int Screen;
        public int Depth;
        public XVisualClass Class;
        public long RedMask;
        public long GreenMask;
        public long blueMask;
        public int ColormapSize;
        public int BitsPerRgb;

        public override string ToString()
        {
            return String.Format("id ({0}), screen ({1}), depth ({2}), class ({3})",
                VisualID, Screen, Depth, Class);
        }
    }

    #endregion

    #region internal class SetWindowAttributes

    [StructLayout(LayoutKind.Sequential), Obsolete("Use XSetWindowAttributes instead")]
    internal class SetWindowAttributes
    {
        /// <summary>
        /// background, None, or ParentRelative
        /// </summary>
        public Pixmap background_pixmap;
        /// <summary>
        /// background pixel
        /// </summary>
        public long background_pixel;
        /// <summary>
        /// border of the window or CopyFromParent
        /// </summary>
        public Pixmap border_pixmap;
        /// <summary>
        /// border pixel value
        /// </summary>
        public long border_pixel;
        /// <summary>
        /// one of bit gravity values
        /// </summary>
        public int bit_gravity;
        /// <summary>
        /// one of the window gravity values
        /// </summary>
        public int win_gravity;
        /// <summary>
        /// NotUseful, WhenMapped, Always
        /// </summary>
        public int backing_store;
        /// <summary>
        /// planes to be preserved if possible
        /// </summary>
        public long backing_planes;
        /// <summary>
        /// value to use in restoring planes
        /// </summary>
        public long backing_pixel;
        /// <summary>
        /// should bits under be saved? (popups)
        /// </summary>
        public bool save_under;
        /// <summary>
        /// set of events that should be saved
        /// </summary>
        public EventMask event_mask;
        /// <summary>
        /// set of events that should not propagate
        /// </summary>
        public long do_not_propagate_mask;
        /// <summary>
        /// boolean value for override_redirect
        /// </summary>
        public bool override_redirect;
        /// <summary>
        /// color map to be associated with window
        /// </summary>
        public Colormap colormap;
        /// <summary>
        /// cursor to be displayed (or None)
        /// </summary>
        public Cursor cursor;
    }

    #endregion

    #region internal struct SizeHints

    [StructLayout(LayoutKind.Sequential)]
    internal struct SizeHints
    {
        public long flags;         /* marks which fields in this structure are defined */
        public int x, y;           /* Obsolete */
        public int width, height;  /* Obsolete */
        public int min_width, min_height;
        public int max_width, max_height;
        public int width_inc, height_inc;
        public Rectangle min_aspect, max_aspect;
        public int base_width, base_height;
        public int win_gravity;
        internal struct Rectangle
        {
            public int x;       /* numerator */
            public int y;       /* denominator */
            private void stop_the_compiler_warnings() { x = y = 0; }
        }
        /* this structure may be extended in the future */
    }

    #endregion

    #region internal struct XRRScreenSize

    internal struct XRRScreenSize
    {
        internal int Width, Height;
        internal int MWidth, MHeight;
    };

    #endregion

    #region unsafe internal struct Screen

    unsafe internal struct Screen
    {
        XExtData ext_data;    /* hook for extension to hang buffer */
        IntPtr display;     /* back pointer to display structure */ /* _XDisplay */
        Window root;        /* Root window id. */
        int width, height;    /* width and height of screen */
        int mwidth, mheight;    /* width and height of  in millimeters */
        int ndepths;        /* number of depths possible */
        //Depth *depths;        /* list of allowable depths on the screen */
        int root_depth;        /* bits per pixel */
        //Visual* root_visual;    /* root visual */
        IntPtr default_gc;        /* GC for the root root visual */   // GC
        Colormap cmap;        /* default color map */
        UIntPtr white_pixel;    // unsigned long
        UIntPtr black_pixel;    /* White and Black pixel values */  // unsigned long
        int max_maps, min_maps;    /* max and min color maps */
        int backing_store;    /* Never, WhenMapped, Always */
        Bool save_unders;    
        long root_input_mask;    /* initial root input mask */
    }

    #endregion

    #region unsafe internal class XExtData

    unsafe internal class XExtData
    {
        int number;        /* number returned by XRegisterExtension */
        XExtData next;    /* next item on list of buffer for structure */
        delegate int FreePrivateDelegate(XExtData extension);
        FreePrivateDelegate FreePrivate;    /* called to free private storage */
        XPointer private_data;    /* buffer private to this extension. */
    };

    #endregion
    
    #region Motif
    
    [StructLayout(LayoutKind.Sequential)]
    internal struct MotifWmHints
    {
        internal IntPtr flags;
        internal IntPtr functions;
        internal IntPtr decorations;
        internal IntPtr input_mode;
        internal IntPtr status;

        public override string ToString ()
        {
            return string.Format("MotifWmHints <flags={0}, functions={1}, decorations={2}, input_mode={3}, status={4}", (MotifFlags) flags.ToInt32 (), (MotifFunctions) functions.ToInt32 (), (MotifDecorations) decorations.ToInt32 (), (MotifInputMode) input_mode.ToInt32 (), status.ToInt32 ());
        }
    }
    
    [Flags]
    internal enum MotifFlags
    {
        Functions    = 1,
        Decorations  = 2,
        InputMode    = 4,
        Status       = 8
    }

    [Flags]
    internal enum MotifFunctions
    {
        All         = 0x01,
        Resize      = 0x02,
        Move        = 0x04,
        Minimize    = 0x08,
        Maximize    = 0x10,
        Close       = 0x20
    }

    [Flags]
    internal enum MotifDecorations
    {
        All         = 0x01,
        Border      = 0x02,
        ResizeH     = 0x04,
        Title       = 0x08,
        Menu        = 0x10,
        Minimize    = 0x20,
        Maximize    = 0x40,
        
    }

    [Flags]
    internal enum MotifInputMode
    {
        Modeless                = 0,
        ApplicationModal        = 1,
        SystemModal             = 2,
        FullApplicationModal    = 3
    }
    
    #endregion

    #endregion

    #region X11 Constants and Enums

    internal struct Constants
    {
        public const int QueuedAlready = 0;
        public const int QueuedAfterReading = 1;
        public const int QueuedAfterFlush = 2;

        public const int CopyFromParent = 0;
        public const int CWX = 1;
        public const int InputOutput = 1;
        public const int InputOnly = 2;

        /* The hints we recognize */
        public const string XA_WIN_PROTOCOLS           = "_WIN_PROTOCOLS";
        public const string XA_WIN_ICONS               = "_WIN_ICONS";
        public const string XA_WIN_WORKSPACE           = "_WIN_WORKSPACE";
        public const string XA_WIN_WORKSPACE_COUNT     = "_WIN_WORKSPACE_COUNT";
        public const string XA_WIN_WORKSPACE_NAMES     = "_WIN_WORKSPACE_NAMES";
        public const string XA_WIN_LAYER               = "_WIN_LAYER";
        public const string XA_WIN_STATE               = "_WIN_STATE";
        public const string XA_WIN_HINTS               = "_WIN_HINTS";
        public const string XA_WIN_WORKAREA            = "_WIN_WORKAREA";
        public const string XA_WIN_CLIENT_LIST         = "_WIN_CLIENT_LIST";
        public const string XA_WIN_APP_STATE           = "_WIN_APP_STATE";
        public const string XA_WIN_EXPANDED_SIZE       = "_WIN_EXPANDED_SIZE";
        public const string XA_WIN_CLIENT_MOVING       = "_WIN_CLIENT_MOVING";
        public const string XA_WIN_SUPPORTING_WM_CHECK = "_WIN_SUPPORTING_WM_CHECK";
    }

    internal enum WindowLayer
    {
        Desktop    = 0,
        Below      = 2,
        Normal     = 4,
        OnTop      = 6,
        Dock       = 8,
        AboveDock  = 10,
        Menu       = 12,
    }

    internal enum WindowState
    {
        Sticky           = (1<<0), /* everyone knows sticky */
        Minimized        = (1<<1), /* ??? */
        MaximizedVertically = (1<<2), /* window in maximized V state */
        MaximizedHorizontally = (1<<3), /* window in maximized H state */
        Hidden           = (1<<4), /* not on taskbar but window visible */
        Shaded           = (1<<5), /* shaded (NeXT style), */
        HID_WORKSPACE    = (1<<6), /* not on current desktop */
        HID_TRANSIENT    = (1<<7), /* owner of transient is hidden */
        FixedPosition    = (1<<8), /* window is fixed in position even */
        ArrangeIgnore    = (1<<9),  /* ignore for auto arranging */
    }

    internal enum WindowHints
    {
        SkipFocus = (1<<0), /* "alt-tab" skips this win */
        SkipWinlist = (1<<1), /* not in win list */
        SkipTaskbar = (1<<2), /* not on taskbar */
        GroupTransient = (1<<3), /* ??????? */
        FocusOnClick = (1<<4), /* app only accepts focus when clicked */
        DoNotCover = (1<<5),  /* attempt to not cover this window */
    }

    internal enum ErrorCodes : int
    {
        Success = 0,
        BadRequest = 1,
        BadValue = 2,
        BadWindow = 3,
        BadPixmap = 4,
        BadAtom = 5,
        BadCursor = 6,
        BadFont = 7,
        BadMatch = 8,
        BadDrawable = 9,
        BadAccess = 10,
        BadAlloc = 11,
        BadColor = 12,
        BadGC = 13,
        BadIDChoice = 14,
        BadName = 15,
        BadLength = 16,
        BadImplementation = 17,
    }

    [Flags]
    internal enum CreateWindowMask : long//: ulong
    {
        CWBackPixmap    = (1L<<0),
        CWBackPixel     = (1L<<1),
        CWSaveUnder        = (1L<<10),
        CWEventMask        = (1L<<11),
        CWDontPropagate    = (1L<<12),
        CWColormap      = (1L<<13),
        CWCursor        = (1L<<14),
        CWBorderPixmap    = (1L<<2),
        CWBorderPixel    = (1L<<3),
        CWBitGravity    = (1L<<4),
        CWWinGravity    = (1L<<5),
        CWBackingStore    = (1L<<6),
        CWBackingPlanes    = (1L<<7),
        CWBackingPixel     = (1L<<8),
        CWOverrideRedirect    = (1L<<9),

        //CWY    = (1<<1),
        //CWWidth    = (1<<2),
        //CWHeight    = (1<<3),
        //CWBorderWidth    = (1<<4),
        //CWSibling    = (1<<5),
        //CWStackMode    = (1<<6),
    }

    #region XKey

    /// <summary>
    /// Defines LATIN-1 and miscellaneous keys.
    /// </summary>
    [CLSCompliant(false)]
    internal enum XKey
    {
        /*
         * TTY function keys, cleverly chosen to map to ASCII, for convenience of
         * programming, but could have been arbitrary (at the cost of lookup
         * tables in client code).
         */

        BackSpace                   = 0xff08,  /* Back space, back char */
        Tab                         = 0xff09,
        Linefeed                    = 0xff0a,  /* Linefeed, LF */
        Clear                       = 0xff0b,
        Return                      = 0xff0d,  /* Return, enter */
        Pause                       = 0xff13,  /* Pause, hold */
        Scroll_Lock                 = 0xff14,
        Sys_Req                     = 0xff15,
        Escape                      = 0xff1b,
        Delete                      = 0xffff,  /* Delete, rubout */



        /* International & multi-key character composition */

        Multi_key                   = 0xff20,  /* Multi-key character compose */
        Codeinput                   = 0xff37,
        SingleCandidate             = 0xff3c,
        MultipleCandidate           = 0xff3d,
        PreviousCandidate           = 0xff3e,
                
        /* Japanese keyboard support */

        Kanji                       = 0xff21,  /* Kanji, Kanji convert */
        Muhenkan                    = 0xff22,  /* Cancel Conversion */
        Henkan_Mode                 = 0xff23,  /* Start/Stop Conversion */
        Henkan                      = 0xff23,  /* Alias for Henkan_Mode */
        Romaji                      = 0xff24,  /* to Romaji */
        Hiragana                    = 0xff25,  /* to Hiragana */
        Katakana                    = 0xff26,  /* to Katakana */
        Hiragana_Katakana           = 0xff27,  /* Hiragana/Katakana toggle */
        Zenkaku                     = 0xff28,  /* to Zenkaku */
        Hankaku                     = 0xff29,  /* to Hankaku */
        Zenkaku_Hankaku             = 0xff2a,  /* Zenkaku/Hankaku toggle */
        Touroku                     = 0xff2b,  /* Add to Dictionary */
        Massyo                      = 0xff2c,  /* Delete from Dictionary */
        Kana_Lock                   = 0xff2d,  /* Kana Lock */
        Kana_Shift                  = 0xff2e,  /* Kana Shift */
        Eisu_Shift                  = 0xff2f,  /* Alphanumeric Shift */
        Eisu_toggle                 = 0xff30,  /* Alphanumeric toggle */
        Kanji_Bangou                = 0xff37,  /* Codeinput */
        Zen_Koho                    = 0xff3d,  /* Multiple/All Candidate(s) */
        Mae_Koho                    = 0xff3e,  /* Previous Candidate */

        /* 0xff31 thru 0xff3f are under XK_KOREAN */

        /* Cursor control & motion */

        Home                        = 0xff50,
        Left                        = 0xff51,  /* Move left, left arrow */
        Up                          = 0xff52,  /* Move up, up arrow */
        Right                       = 0xff53,  /* Move right, right arrow */
        Down                        = 0xff54,  /* Move down, down arrow */
        Prior                       = 0xff55,  /* Prior, previous */
        Page_Up                     = 0xff55,
        Next                        = 0xff56,  /* Next */
        Page_Down                   = 0xff56,
        End                         = 0xff57,  /* EOL */
        Begin                       = 0xff58,  /* BOL */


        /* Misc functions */

        Select                      = 0xff60,  /* Select, mark */
        Print                       = 0xff61,
        Execute                     = 0xff62,  /* Execute, run, do */
        Insert                      = 0xff63,  /* Insert, insert here */
        Undo                        = 0xff65,
        Redo                        = 0xff66,  /* Redo, again */
        Menu                        = 0xff67,
        Find                        = 0xff68,  /* Find, search */
        Cancel                      = 0xff69,  /* Cancel, stop, abort, exit */
        Help                        = 0xff6a,  /* Help */
        Break                       = 0xff6b,
        Mode_switch                 = 0xff7e,  /* Character set switch */
        script_switch               = 0xff7e,  /* Alias for mode_switch */
        Num_Lock                    = 0xff7f,

        /* Keypad functions, keypad numbers cleverly chosen to map to ASCII */

        KP_Space                    = 0xff80,  /* Space */
        KP_Tab                      = 0xff89,
        KP_Enter                    = 0xff8d,  /* Enter */
        KP_F1                       = 0xff91,  /* PF1, KP_A, ... */
        KP_F2                       = 0xff92,
        KP_F3                       = 0xff93,
        KP_F4                       = 0xff94,
        KP_Home                     = 0xff95,
        KP_Left                     = 0xff96,
        KP_Up                       = 0xff97,
        KP_Right                    = 0xff98,
        KP_Down                     = 0xff99,
        KP_Prior                    = 0xff9a,
        KP_Page_Up                  = 0xff9a,
        KP_Next                     = 0xff9b,
        KP_Page_Down                = 0xff9b,
        KP_End                      = 0xff9c,
        KP_Begin                    = 0xff9d,
        KP_Insert                   = 0xff9e,
        KP_Delete                   = 0xff9f,
        KP_Equal                    = 0xffbd,  /* Equals */
        KP_Multiply                 = 0xffaa,
        KP_Add                      = 0xffab,
        KP_Separator                = 0xffac,  /* Separator, often comma */
        KP_Subtract                 = 0xffad,
        KP_Decimal                  = 0xffae,
        KP_Divide                   = 0xffaf,

        KP_0                        = 0xffb0,
        KP_1                        = 0xffb1,
        KP_2                        = 0xffb2,
        KP_3                        = 0xffb3,
        KP_4                        = 0xffb4,
        KP_5                        = 0xffb5,
        KP_6                        = 0xffb6,
        KP_7                        = 0xffb7,
        KP_8                        = 0xffb8,
        KP_9                        = 0xffb9,

        /*
         * Auxiliary functions; note the duplicate definitions for left and right
         * function keys;  Sun keyboards and a few other manufacturers have such
         * function key groups on the left and/or right sides of the keyboard.
         * We've not found a keyboard with more than 35 function keys total.
         */

        F1                          = 0xffbe,
        F2                          = 0xffbf,
        F3                          = 0xffc0,
        F4                          = 0xffc1,
        F5                          = 0xffc2,
        F6                          = 0xffc3,
        F7                          = 0xffc4,
        F8                          = 0xffc5,
        F9                          = 0xffc6,
        F10                         = 0xffc7,
        F11                         = 0xffc8,
        L1                          = 0xffc8,
        F12                         = 0xffc9,
        L2                          = 0xffc9,
        F13                         = 0xffca,
        L3                          = 0xffca,
        F14                         = 0xffcb,
        L4                          = 0xffcb,
        F15                         = 0xffcc,
        L5                          = 0xffcc,
        F16                         = 0xffcd,
        L6                          = 0xffcd,
        F17                         = 0xffce,
        L7                          = 0xffce,
        F18                         = 0xffcf,
        L8                          = 0xffcf,
        F19                         = 0xffd0,
        L9                          = 0xffd0,
        F20                         = 0xffd1,
        L10                         = 0xffd1,
        F21                         = 0xffd2,
        R1                          = 0xffd2,
        F22                         = 0xffd3,
        R2                          = 0xffd3,
        F23                         = 0xffd4,
        R3                          = 0xffd4,
        F24                         = 0xffd5,
        R4                          = 0xffd5,
        F25                         = 0xffd6,
        R5                          = 0xffd6,
        F26                         = 0xffd7,
        R6                          = 0xffd7,
        F27                         = 0xffd8,
        R7                          = 0xffd8,
        F28                         = 0xffd9,
        R8                          = 0xffd9,
        F29                         = 0xffda,
        R9                          = 0xffda,
        F30                         = 0xffdb,
        R10                         = 0xffdb,
        F31                         = 0xffdc,
        R11                         = 0xffdc,
        F32                         = 0xffdd,
        R12                         = 0xffdd,
        F33                         = 0xffde,
        R13                         = 0xffde,
        F34                         = 0xffdf,
        R14                         = 0xffdf,
        F35                         = 0xffe0,
        R15                         = 0xffe0,

        /* Modifiers */

        Shift_L                     = 0xffe1,  /* Left shift */
        Shift_R                     = 0xffe2,  /* Right shift */
        Control_L                   = 0xffe3,  /* Left control */
        Control_R                   = 0xffe4,  /* Right control */
        Caps_Lock                   = 0xffe5,  /* Caps lock */
        Shift_Lock                  = 0xffe6,  /* Shift lock */

        Meta_L                      = 0xffe7,  /* Left meta */
        Meta_R                      = 0xffe8,  /* Right meta */
        Alt_L                       = 0xffe9,  /* Left alt */
        Alt_R                       = 0xffea,  /* Right alt */
        Super_L                     = 0xffeb,  /* Left super */
        Super_R                     = 0xffec,  /* Right super */
        Hyper_L                     = 0xffed,  /* Left hyper */
        Hyper_R                     = 0xffee,  /* Right hyper */

        ISO_Level3_Shift = 0xfe03,

        /*
         * Latin 1
         * (ISO/IEC 8859-1 = Unicode U+0020..U+00FF)
         * Byte 3 = 0
         */

        space                       = 0x0020,  /* U+0020 SPACE */
        exclam                      = 0x0021,  /* U+0021 EXCLAMATION MARK */
        quotedbl                    = 0x0022,  /* U+0022 QUOTATION MARK */
        numbersign                  = 0x0023,  /* U+0023 NUMBER SIGN */
        dollar                      = 0x0024,  /* U+0024 DOLLAR SIGN */
        percent                     = 0x0025,  /* U+0025 PERCENT SIGN */
        ampersand                   = 0x0026,  /* U+0026 AMPERSAND */
        apostrophe                  = 0x0027,  /* U+0027 APOSTROPHE */
        quoteright                  = 0x0027,  /* deprecated */
        parenleft                   = 0x0028,  /* U+0028 LEFT PARENTHESIS */
        parenright                  = 0x0029,  /* U+0029 RIGHT PARENTHESIS */
        asterisk                    = 0x002a,  /* U+002A ASTERISK */
        plus                        = 0x002b,  /* U+002B PLUS SIGN */
        comma                       = 0x002c,  /* U+002C COMMA */
        minus                       = 0x002d,  /* U+002D HYPHEN-MINUS */
        period                      = 0x002e,  /* U+002E FULL STOP */
        slash                       = 0x002f,  /* U+002F SOLIDUS */
        Number0                           = 0x0030,  /* U+0030 DIGIT ZERO */
        Number1                           = 0x0031,  /* U+0031 DIGIT ONE */
        Number2                           = 0x0032,  /* U+0032 DIGIT TWO */
        Number3                           = 0x0033,  /* U+0033 DIGIT THREE */
        Number4                           = 0x0034,  /* U+0034 DIGIT FOUR */
        Number5                           = 0x0035,  /* U+0035 DIGIT FIVE */
        Number6                           = 0x0036,  /* U+0036 DIGIT SIX */
        Number7                           = 0x0037,  /* U+0037 DIGIT SEVEN */
        Number8                           = 0x0038,  /* U+0038 DIGIT EIGHT */
        Number9                     = 0x0039,  /* U+0039 DIGIT NINE */
        colon                       = 0x003a,  /* U+003A COLON */
        semicolon                   = 0x003b,  /* U+003B SEMICOLON */
        less                        = 0x003c,  /* U+003C LESS-THAN SIGN */
        equal                       = 0x003d,  /* U+003D EQUALS SIGN */
        greater                     = 0x003e,  /* U+003E GREATER-THAN SIGN */
        question                    = 0x003f,  /* U+003F QUESTION MARK */
        at                          = 0x0040,  /* U+0040 COMMERCIAL AT */
        A                           = 0x0041,  /* U+0041 LATIN CAPITAL LETTER A */
        B                           = 0x0042,  /* U+0042 LATIN CAPITAL LETTER B */
        C                           = 0x0043,  /* U+0043 LATIN CAPITAL LETTER C */
        D                           = 0x0044,  /* U+0044 LATIN CAPITAL LETTER D */
        E                           = 0x0045,  /* U+0045 LATIN CAPITAL LETTER E */
        F                           = 0x0046,  /* U+0046 LATIN CAPITAL LETTER F */
        G                           = 0x0047,  /* U+0047 LATIN CAPITAL LETTER G */
        H                           = 0x0048,  /* U+0048 LATIN CAPITAL LETTER H */
        I                           = 0x0049,  /* U+0049 LATIN CAPITAL LETTER I */
        J                           = 0x004a,  /* U+004A LATIN CAPITAL LETTER J */
        K                           = 0x004b,  /* U+004B LATIN CAPITAL LETTER K */
        L                           = 0x004c,  /* U+004C LATIN CAPITAL LETTER L */
        M                           = 0x004d,  /* U+004D LATIN CAPITAL LETTER M */
        N                           = 0x004e,  /* U+004E LATIN CAPITAL LETTER N */
        O                           = 0x004f,  /* U+004F LATIN CAPITAL LETTER O */
        P                           = 0x0050,  /* U+0050 LATIN CAPITAL LETTER P */
        Q                           = 0x0051,  /* U+0051 LATIN CAPITAL LETTER Q */
        R                           = 0x0052,  /* U+0052 LATIN CAPITAL LETTER R */
        S                           = 0x0053,  /* U+0053 LATIN CAPITAL LETTER S */
        T                           = 0x0054,  /* U+0054 LATIN CAPITAL LETTER T */
        U                           = 0x0055,  /* U+0055 LATIN CAPITAL LETTER U */
        V                           = 0x0056,  /* U+0056 LATIN CAPITAL LETTER V */
        W                           = 0x0057,  /* U+0057 LATIN CAPITAL LETTER W */
        X                           = 0x0058,  /* U+0058 LATIN CAPITAL LETTER X */
        Y                           = 0x0059,  /* U+0059 LATIN CAPITAL LETTER Y */
        Z                           = 0x005a,  /* U+005A LATIN CAPITAL LETTER Z */
        bracketleft                 = 0x005b,  /* U+005B LEFT SQUARE BRACKET */
        backslash                   = 0x005c,  /* U+005C REVERSE SOLIDUS */
        bracketright                = 0x005d,  /* U+005D RIGHT SQUARE BRACKET */
        asciicircum                 = 0x005e,  /* U+005E CIRCUMFLEX ACCENT */
        underscore                  = 0x005f,  /* U+005F LOW LINE */
        grave                       = 0x0060,  /* U+0060 GRAVE ACCENT */
        quoteleft                   = 0x0060,  /* deprecated */
        a                           = 0x0061,  /* U+0061 LATIN SMALL LETTER A */
        b                           = 0x0062,  /* U+0062 LATIN SMALL LETTER B */
        c                           = 0x0063,  /* U+0063 LATIN SMALL LETTER C */
        d                           = 0x0064,  /* U+0064 LATIN SMALL LETTER D */
        e                           = 0x0065,  /* U+0065 LATIN SMALL LETTER E */
        f                           = 0x0066,  /* U+0066 LATIN SMALL LETTER F */
        g                           = 0x0067,  /* U+0067 LATIN SMALL LETTER G */
        h                           = 0x0068,  /* U+0068 LATIN SMALL LETTER H */
        i                           = 0x0069,  /* U+0069 LATIN SMALL LETTER I */
        j                           = 0x006a,  /* U+006A LATIN SMALL LETTER J */
        k                           = 0x006b,  /* U+006B LATIN SMALL LETTER K */
        l                           = 0x006c,  /* U+006C LATIN SMALL LETTER L */
        m                           = 0x006d,  /* U+006D LATIN SMALL LETTER M */
        n                           = 0x006e,  /* U+006E LATIN SMALL LETTER N */
        o                           = 0x006f,  /* U+006F LATIN SMALL LETTER O */
        p                           = 0x0070,  /* U+0070 LATIN SMALL LETTER P */
        q                           = 0x0071,  /* U+0071 LATIN SMALL LETTER Q */
        r                           = 0x0072,  /* U+0072 LATIN SMALL LETTER R */
        s                           = 0x0073,  /* U+0073 LATIN SMALL LETTER S */
        t                           = 0x0074,  /* U+0074 LATIN SMALL LETTER T */
        u                           = 0x0075,  /* U+0075 LATIN SMALL LETTER U */
        v                           = 0x0076,  /* U+0076 LATIN SMALL LETTER V */
        w                           = 0x0077,  /* U+0077 LATIN SMALL LETTER W */
        x                           = 0x0078,  /* U+0078 LATIN SMALL LETTER X */
        y                           = 0x0079,  /* U+0079 LATIN SMALL LETTER Y */
        z                           = 0x007a,  /* U+007A LATIN SMALL LETTER Z */
        braceleft                   = 0x007b,  /* U+007B LEFT CURLY BRACKET */
        bar                         = 0x007c,  /* U+007C VERTICAL LINE */
        braceright                  = 0x007d,  /* U+007D RIGHT CURLY BRACKET */
        asciitilde                  = 0x007e,  /* U+007E TILDE */

        // Extra keys

        XF86AudioMute = 0x1008ff12,
        XF86AudioLowerVolume = 0x1008ff11,
        XF86AudioRaiseVolume = 0x1008ff13,
        XF86PowerOff = 0x1008ff2a,
        XF86Suspend = 0x1008ffa7,
        XF86Copy = 0x1008ff57,
        XF86Paste = 0x1008ff6d,
        XF86Cut = 0x1008ff58,
        XF86MenuKB = 0x1008ff65,
        XF86Calculator = 0x1008ff1d,
        XF86Sleep = 0x1008ff2f,
        XF86WakeUp = 0x1008ff2b ,
        XF86Explorer = 0x1008ff5d,
        XF86Send = 0x1008ff7b,
        XF86Xfer = 0x1008ff8a,
        XF86Launch1 = 0x1008ff41,
        XF86Launch2 =     0x1008ff42,
        XF86Launch3 = 0x1008ff43,
        XF86Launch4 =     0x1008ff44,
        XF86Launch5 = 0x1008ff45,
        XF86LaunchA = 0x1008ff4a,
        XF86LaunchB = 0x1008ff4b,
        XF86WWW = 0x1008ff2e,
        XF86DOS = 0x1008ff5a,
        XF86ScreenSaver = 0x1008ff2d,
        XF86RotateWindows = 0x1008ff74,
        XF86Mail = 0x1008ff19,
        XF86Favorites = 0x1008ff30,
        XF86MyComputer = 0x1008ff33,
        XF86Back = 0x1008ff26,
        XF86Forward = 0x1008ff27 ,
        XF86Eject = 0x1008ff2c,
        XF86AudioPlay = 0x1008ff14,
        XF86AudioStop = 0x1008ff15,
        XF86AudioPrev = 0x1008ff16,
        XF86AudioNext = 0x1008ff17,
        XF86AudioRecord = 0x1008ff1c,
        XF86AudioPause =0x1008ff31,
        XF86AudioRewind = 0x1008ff3e,
        XF86AudioForward = 0x1008ff97,
        XF86Phone = 0x1008ff6e,
        XF86Tools = 0x1008ff81,
        XF86HomePage = 0x1008ff18,
        XF86Close = 0x1008ff56,
        XF86Reload = 0x1008ff73,
        XF86ScrollUp = 0x1008ff78,
        XF86ScrollDown = 0x1008ff79,
        XF86New = 0x1008ff68,
        XF86TouchpadToggle = 0x1008ffa9,
        XF86WebCam = 0x1008ff8f,
        XF86Search = 0x1008ff1b,
        XF86Finance = 0x1008ff3c,
        XF86Shop = 0x1008ff36,
        XF86MonBrightnessDown = 0x1008ff03,
        XF86MonBrightnessUp = 0x1008ff02,
        XF86AudioMedia = 0x1008ff32,
        XF86Display = 0x1008ff59,
        XF86KbdLightOnOff = 0x1008ff04,
        XF86KbdBrightnessDown = 0x1008ff06,
        XF86KbdBrightnessUp = 0x1008ff05,
        XF86Reply = 0x1008ff72,
        XF86MailForward = 0x1008ff90,
        XF86Save = 0x1008ff77,
        XF86Documents = 0x1008ff5b,
        XF86Battery = 0x1008ff93,
        XF86Bluetooth = 0x1008ff94,
        XF86WLAN = 0x1008ff95,

         SunProps = 0x1005ff70,
         SunOpen = 0x1005ff73,
    }

    #endregion

#pragma warning disable 1591

    public enum XVisualClass : int
    {
        StaticGray = 0,
        GrayScale = 1,
        StaticColor = 2,
        PseudoColor = 3,
        TrueColor = 4,
        DirectColor = 5,
    }

#pragma warning restore 1591

    [Flags]
    internal enum XVisualInfoMask
    {
        No = 0x0,
        ID = 0x1,
        Screen = 0x2,
        Depth = 0x4,
        Class = 0x8,
        Red = 0x10,
        Green = 0x20,
        Blue = 0x40,
        ColormapSize = 0x80,
        BitsPerRGB = 0x100,
        All = 0x1FF,
    }

    #region internal enum MouseMask

    internal enum MouseMask
    {
        Button1MotionMask = (1 << 8),
        Button2MotionMask = (1 << 9),
        Button3MotionMask = (1 << 10),
        Button4MotionMask = (1 << 11),
        Button5MotionMask = (1 << 12),
        Button1Mask = (1 << 8),
        Button2Mask = (1 << 9),
        Button3Mask = (1 << 10),
        Button4Mask = (1 << 11),
        Button5Mask = (1 << 12),
        Button6Mask = (1 << 13),
        Button7Mask = (1 << 14),
        Button8Mask = (1 << 15),
        ShiftMask = (1 << 0),
        LockMask = (1 << 1),
        ControlMask = (1 << 2),
        Mod1Mask = (1 << 3),
        Mod2Mask = (1 << 4),
        Mod3Mask = (1 << 5),
        Mod4Mask = (1 << 6),
        Mod5Mask = (1 << 7),
    }

    #endregion

    #endregion

    internal static partial class Functions
    {
        internal const string X11Library = "libX11";
        internal const string XcursorLibrary = "libXcursor.so.1";

        #region XCreateWindow

        /// <summary>
        /// The XCreateWindow function creates an unmapped subwindow for a specified parent window, returns the window ID of the created window, and causes the X server to generate a CreateNotify event. The created window is placed on top in the stacking order with respect to siblings.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="parent">Specifies the parent window.</param>
        /// <param name="x">Specify the x coordinates, which are the top-left outside corner of the window's borders and are relative to the inside of the parent window's borders.</param>
        /// <param name="y">Specify the y coordinates, which are the top-left outside corner of the window's borders and are relative to the inside of the parent window's borders.</param>
        /// <param name="width">Specify the width, which is the created window's inside dimensions and do not include the created window's borders.</param>
        /// <param name="height">Specify the height, which is the created window's inside dimensions and do not include the created window's borders.</param>
        /// <param name="border_width">Specifies the width of the created window's border in pixels.</param>
        /// <param name="depth">Specifies the window's depth. A depth of CopyFromParent means the depth is taken from the parent.</param>
        /// <param name="class">Specifies the created window's class. You can pass InputOutput, InputOnly, or CopyFromParent. A class of CopyFromParent means the class is taken from the parent.</param>
        /// <param name="visual">Specifies the visual type. A visual of CopyFromParent means the visual type is taken from the parent.</param>
        /// <param name="valuemask">Specifies which window attributes are defined in the attributes argument. This mask is the bitwise inclusive OR of the valid attribute mask bits. If valuemask is zero, the attributes are ignored and are not referenced.</param>
        /// <param name="attributes">Specifies the structure from which the values (as specified by the value mask) are to be taken. The value mask should have the appropriate bits set to indicate which attributes have been set in the structure.</param>
        /// <returns>The window ID of the created window.</returns>
        /// <remarks>
        /// The coordinate system has the X axis horizontal and the Y axis vertical with the origin [0, 0] at the upper-left corner. Coordinates are integral, in terms of pixels, and coincide with pixel centers. Each window and pixmap has its own coordinate system. For a window, the origin is inside the border at the inside, upper-left corner. 
        /// <para>The border_width for an InputOnly window must be zero, or a BadMatch error results. For class InputOutput, the visual type and depth must be a combination supported for the screen, or a BadMatch error results. The depth need not be the same as the parent, but the parent must not be a window of class InputOnly, or a BadMatch error results. For an InputOnly window, the depth must be zero, and the visual must be one supported by the screen. If either condition is not met, a BadMatch error results. The parent window, however, may have any depth and class. If you specify any invalid window attribute for a window, a BadMatch error results. </para>
        /// <para>The created window is not yet displayed (mapped) on the user's display. To display the window, call XMapWindow(). The new window initially uses the same cursor as its parent. A new cursor can be defined for the new window by calling XDefineCursor(). The window will not be visible on the screen unless it and all of its ancestors are mapped and it is not obscured by any of its ancestors. </para>
        /// <para>XCreateWindow can generate BadAlloc BadColor, BadCursor, BadMatch, BadPixmap, BadValue, and BadWindow errors. </para>
        /// <para>The XCreateSimpleWindow function creates an unmapped InputOutput subwindow for a specified parent window, returns the window ID of the created window, and causes the X server to generate a CreateNotify event. The created window is placed on top in the stacking order with respect to siblings. Any part of the window that extends outside its parent window is clipped. The border_width for an InputOnly window must be zero, or a BadMatch error results. XCreateSimpleWindow inherits its depth, class, and visual from its parent. All other window attributes, except background and border, have their default values. </para>
        /// <para>XCreateSimpleWindow can generate BadAlloc, BadMatch, BadValue, and BadWindow errors.</para>
        /// </remarks>
        public static Window XCreateWindow(Display display, Window parent,
            int x, int y, int width, int height, int border_width, int depth,
            CreateWindowArgs @class, IntPtr visual, SetWindowValuemask valuemask,
            XSetWindowAttributes? attributes)
        {
            unsafe
            {
                if (attributes.HasValue)
                {
                    XSetWindowAttributes attr = attributes.Value;
                    return XCreateWindow(display, parent, x, y, width, height, border_width, depth,
                        (int)@class, visual, (IntPtr)valuemask, &attr);
                }
                else
                {
                    return XCreateWindow(display, parent, x, y, width, height, border_width, depth,
                        (int)@class, visual, (IntPtr)valuemask, null);
                }
            }
        }

        #endregion

        #region XChangeWindowAttributes

        [DllImport(X11Library)]
        internal static extern void XChangeWindowAttributes(Display display, Window w, UIntPtr valuemask, ref XSetWindowAttributes attributes);

        internal static void XChangeWindowAttributes(Display display, Window w, SetWindowValuemask valuemask, ref XSetWindowAttributes attributes)
        {
            XChangeWindowAttributes(display, w, (UIntPtr)valuemask, ref attributes);
        }

        #endregion

        #region Xcursor

        [DllImport(XcursorLibrary)]
        internal static unsafe extern XcursorImage* XcursorImageCreate(int width, int height);

        [DllImport(XcursorLibrary)]
        internal static unsafe extern void XcursorImageDestroy(XcursorImage* image);

        [DllImport(XcursorLibrary)]
        internal static unsafe extern Cursor XcursorImageLoadCursor(Display dpy, XcursorImage* image); 

        #endregion

        #region XQueryKeymap

        /*
        /// <summary>
        /// The XQueryKeymap() function returns a bit vector for the logical state of the keyboard, where each bit set to 1 indicates that the corresponding key is currently pressed down. The vector is represented as 32 bytes. Byte N (from 0) contains the bits for keys 8N to 8N + 7 with the least-significant bit in the byte representing key 8N.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="keys">Returns an array of bytes that identifies which keys are pressed down. Each bit represents one key of the keyboard.</param>
        /// <remarks>Note that the logical state of a device (as seen by client applications) may lag the physical state if device event processing is frozen.</remarks>
        [DllImport(_dll_name, EntryPoint = "XQueryKeymap")]
        extern public static void XQueryKeymap(IntPtr display, [MarshalAs(UnmanagedType.LPArray, SizeConst = 32), In, Out] Keymap keys);
        */

        /// <summary>
        /// The XQueryKeymap() function returns a bit vector for the logical state of the keyboard, where each bit set to 1 indicates that the corresponding key is currently pressed down. The vector is represented as 32 bytes. Byte N (from 0) contains the bits for keys 8N to 8N + 7 with the least-significant bit in the byte representing key 8N.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="keys">Returns an array of bytes that identifies which keys are pressed down. Each bit represents one key of the keyboard.</param>
        /// <remarks>Note that the logical state of a device (as seen by client applications) may lag the physical state if device event processing is frozen.</remarks>
        [DllImport(X11Library, EntryPoint = "XQueryKeymap")]
        extern public static void XQueryKeymap(IntPtr display, byte[] keys);

        #endregion

        #region XMaskEvent

        /// <summary>
        /// The XMaskEvent() function searches the event queue for the events associated with the specified mask. When it finds a match, XMaskEvent() removes that event and copies it into the specified XEvent structure. The other events stored in the queue are not discarded. If the event you requested is not in the queue, XMaskEvent() flushes the output buffer and blocks until one is received.
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="event_mask">Specifies the event mask.</param>
        /// <param name="e">Returns the matched event's associated structure.</param>
        [DllImport(X11Library, EntryPoint = "XMaskEvent")]
        extern public static void XMaskEvent(IntPtr display, EventMask event_mask, ref XEvent e);

        #endregion

        #region XPutBackEvent

        /// <summary>
        /// The XPutBackEvent() function pushes an event back onto the head of the display's event queue by copying the event into the queue. This can be useful if you read an event and then decide that you would rather deal with it later. There is no limit to the number of times in succession that you can call XPutBackEvent().
        /// </summary>
        /// <param name="display">Specifies the connection to the X server.</param>
        /// <param name="event">Specifies the event.</param>
        [DllImport(X11Library, EntryPoint = "XPutBackEvent")]
        public static extern void XPutBackEvent(IntPtr display, ref XEvent @event);
        
        #endregion

        #region Xrandr

        const string XrandrLibrary = "libXrandr.so.2";

        [DllImport(XrandrLibrary)]
        public static extern Bool XRRQueryExtension(Display dpy, ref int event_basep, ref int error_basep);

        [DllImport(XrandrLibrary)]
        public static extern Status XRRQueryVersion(Display dpy, ref int major_versionp, ref int minor_versionp);

        [DllImport(XrandrLibrary)]
        public static extern XRRScreenConfiguration XRRGetScreenInfo(Display dpy, Drawable draw);

        [DllImport(XrandrLibrary)]
        public static extern void XRRFreeScreenConfigInfo(XRRScreenConfiguration config);

        [DllImport(XrandrLibrary)]
        public static extern Status XRRSetScreenConfig(Display dpy, XRRScreenConfiguration config,
            Drawable draw, int size_index, Rotation rotation, Time timestamp);

        [DllImport(XrandrLibrary)]
        public static extern Status XRRSetScreenConfigAndRate(Display dpy, XRRScreenConfiguration config,
            Drawable draw, int size_index, Rotation rotation, short rate, Time timestamp);

        [DllImport(XrandrLibrary)]
        public static extern Rotation XRRConfigRotations(XRRScreenConfiguration config, ref Rotation current_rotation);

        [DllImport(XrandrLibrary)]
        public static extern Time XRRConfigTimes(XRRScreenConfiguration config, ref Time config_timestamp);

        [DllImport(XrandrLibrary)]
        [return: MarshalAs(UnmanagedType.LPStruct)]
        public static extern XRRScreenSize XRRConfigSizes(XRRScreenConfiguration config, int[] nsizes);

        [DllImport(XrandrLibrary)]
        unsafe public static extern short* XRRConfigRates(XRRScreenConfiguration config, int size_index, int[] nrates);

        [DllImport(XrandrLibrary)]
        public static extern SizeID XRRConfigCurrentConfiguration(XRRScreenConfiguration config, out Rotation rotation);

        [DllImport(XrandrLibrary)]
        public static extern short XRRConfigCurrentRate(XRRScreenConfiguration config);

        [DllImport(XrandrLibrary)]
        public static extern int XRRRootToScreen(Display dpy, Window root);

        [DllImport(XrandrLibrary)]
        public static extern XRRScreenConfiguration XRRScreenConfig(Display dpy, int screen);

        [DllImport(XrandrLibrary)]
        public static extern XRRScreenConfiguration XRRConfig(ref Screen screen);

        [DllImport(XrandrLibrary)]
        public static extern void XRRSelectInput(Display dpy, Window window, int mask);

        /*
         * intended to take RRScreenChangeNotify,  or
         * ConfigureNotify (on the root window)
         * returns 1 if it is an event type it understands, 0 if not
         */
        [DllImport(XrandrLibrary)]
        public static extern int XRRUpdateConfiguration(ref XEvent @event);

        /*
         * the following are always safe to call, even if RandR is
         * not implemented on a screen
         */
        [DllImport(XrandrLibrary)]
        public static extern Rotation XRRRotations(Display dpy, int screen, ref Rotation current_rotation);

        [DllImport(XrandrLibrary)]
        unsafe static extern IntPtr XRRSizes(Display dpy, int screen, int* nsizes);

        public static XRRScreenSize[] XRRSizes(Display dpy, int screen)
        {
            XRRScreenSize[] sizes;
            //IntPtr ptr;
            int count;
            unsafe
            {
                //ptr = XRRSizes(dpy, screen, &nsizes);

                byte* data = (byte*)XRRSizes(dpy, screen, &count);//(byte*)ptr;
                if (count == 0)
                    return null;
                sizes = new XRRScreenSize[count];
                for (int i = 0; i < count; i++)
                {
                    sizes[i] = new XRRScreenSize();
                    sizes[i] = (XRRScreenSize)Marshal.PtrToStructure((IntPtr)data, typeof(XRRScreenSize));
                    data += Marshal.SizeOf(typeof(XRRScreenSize));
                }
                //XFree(ptr);   // Looks like we must not free this.
                return sizes;
            }
        }

        [DllImport(XrandrLibrary)]
        unsafe static extern short* XRRRates(Display dpy, int screen, int size_index, int* nrates);

        public static short[] XRRRates(Display dpy, int screen, int size_index)
        {
            short[] rates;
            int count;
            unsafe
            {
                short* data = (short*)XRRRates(dpy, screen, size_index, &count);
                if (count == 0)
                    return null;
                rates = new short[count];
                for (int i = 0; i < count; i++)
                    rates[i] = *(data + i);
            }
            return rates;
        }

        [DllImport(XrandrLibrary)]
        public static extern Time XRRTimes(Display dpy, int screen, out Time config_timestamp);

        #endregion

        #region Display, Screen and Window functions

        #region XScreenCount

        [DllImport(X11Library)]
        public static extern int XScreenCount(Display display);

        #endregion

        #region XListDepths

        [DllImport(X11Library)]
        unsafe static extern int *XListDepths(Display display, int screen_number, int* count_return);

        public static int[] XListDepths(Display display, int screen_number)
        {
            unsafe
            {
                int count;
                int* data = XListDepths(display, screen_number, &count);
                if (count == 0)
                    return null;
                int[] depths = new int[count];
                for (int i = 0; i < count; i++)
                    depths[i] = *(data + i);

                return depths;
            }
        }

        #endregion

        #endregion

        public static Pixmap XCreateBitmapFromData(Display display, Window d, byte[,] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            unsafe
            {
                fixed (byte* pdata = data)
                {
                    return XCreateBitmapFromData(display, d, pdata, data.GetLength(0), data.GetLength(1));
                }
            }
        }

        [DllImport(X11Library)]
        unsafe public static extern Pixmap XCreateBitmapFromData(Display display, Window d, byte* data, int width, int height);

        [DllImport("libX11", EntryPoint = "XAllocColor")]
        public static extern Status XAllocNamedColor(Display display, Colormap colormap, string color_name, out XColor screen_def_return, out XColor exact_def_return);
    }
    /*
    [StructLayout(LayoutKind.Sequential)]
    internal struct Keymap
    {
        unsafe fixed byte bits[32];

        public bool this[KeyCode key]
        {
            get
            {
                unsafe
                {
                    fixed (Keymap* ptr = &this)
                    {
                        return ((ptr->bits[key / 8] >> (key % 8)) & 0x01) != 0;
                    }
                }
            }
        }
    }
    */

    // Helper structure for calling XLock/UnlockDisplay
    struct XLock : IDisposable
    {
        IntPtr _display;

        public IntPtr Display
        {
            get
            {
                if (_display == IntPtr.Zero)
                    throw new InvalidOperationException("Internal error (XLockDisplay with IntPtr.Zero). Please report this at http://www.opentk.com/node/add/project-issue/opentk");
                return _display;
            }
            set
            {
                if (value == IntPtr.Zero)
                    throw new ArgumentException();
                _display = value;
            }
        }

        public XLock(IntPtr display)
            : this()
        {
            Display = display;
            Functions.XLockDisplay(Display);
        }

        public void Dispose()
        {
            Functions.XUnlockDisplay(Display);
        }
    }

    // XAllowEvent modes
    enum EventMode
    {
        AsyncPointer = 0,
        SyncPointer,
        ReplayPointer,
        AsyncKeyboard,
        SyncKeyboard,
        ReplayKeyboard,
        AsyncBoth,
        SyncBoth
    }
}

#pragma warning restore 3019
#pragma warning restore 0649
#pragma warning restore 0169
#pragma warning restore 0414