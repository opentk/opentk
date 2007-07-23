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
    using Time = System.UInt32;
    using KeyCode = System.IntPtr;  /* In order to use IME, the Macintosh needs
                                   * to pack 3 bytes into the keyCode field in
                                   * the XEvent.  In the real X.h, a KeyCode is
                                   * defined as a short, which wouldn't be big
                                   * enough. */
    using Display = System.IntPtr;

    #endregion

    #region internal static class API

    internal static class API
    {
        // Prevent BeforeFieldInit optimization.
        static API() { }

        private const string _dll_name = "libX11";
        private const string _dll_name_vid = "libXxf86vm";

        // Display management
        [DllImport(_dll_name, EntryPoint = "XOpenDisplay")]
        extern internal static IntPtr OpenDisplay([MarshalAs(UnmanagedType.LPTStr)] string display_name);

        [DllImport(_dll_name, EntryPoint = "XCloseDisplay")]
        extern internal static void CloseDisplay(Display display);

        [DllImport(_dll_name, EntryPoint = "XCreateColormap")]
        extern internal static IntPtr CreateColormap(Display display, Window window, IntPtr visual, int alloc);

        #region Window handling

        [DllImport(_dll_name, EntryPoint = "XRootWindow")]
        internal static extern Window RootWindow(Display display, int screen);

        [DllImport(_dll_name, EntryPoint = "XCreateWindow")]
        internal extern static Window CreateWindow(
            Display display,
            Window parent,
            int x, int y,
            uint width, uint height,
            uint border_width,
            int depth,
            uint @class,
            IntPtr visual,
            [MarshalAs(UnmanagedType.SysUInt)] CreateWindowMask valuemask,
            SetWindowAttributes attributes
        );

        [DllImport(_dll_name, EntryPoint = "XCreateSimpleWindow")]
        internal extern static Window CreateSimpleWindow(
            Display display,
            Window parent,
            int x, int y,
            int width, int height,
            int border_width,
            long border,
            long background
        );

        [DllImport(_dll_name, EntryPoint = "XResizeWindow")]
        internal extern static int XResizeWindow(Display display, Window window, int width, int height);

        [DllImport(_dll_name, EntryPoint = "XDestroyWindow")]
        internal extern static void DestroyWindow(Display display, Window window);

        [DllImport(_dll_name, EntryPoint = "XMapWindow")]
        extern internal static void MapWindow(Display display, Window window);

        [DllImport(_dll_name, EntryPoint = "XMapRaised")]
        extern internal static void MapRaised(Display display, Window window);

        #endregion

        [DllImport(_dll_name, EntryPoint = "XDefaultScreen")]
        extern internal static int DefaultScreen(Display display);

        [DllImport(_dll_name, EntryPoint = "XDefaultVisual")]
        extern internal static IntPtr DefaultVisual(Display display, int screen_number);

        #region XFree

        /// <summary>
        /// Frees the memory used by an X structure. Only use on unmanaged structures!
        /// </summary>
        /// <param name="data">A pointer to the structure that will be freed.</param>
        [DllImport(_dll_name, EntryPoint = "XFree")]
        extern internal static void Free(IntPtr data);

        #endregion

        #region Event queue management

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(_dll_name, EntryPoint = "XEventsQueued")]
        extern internal static int EventsQueued(Display display, int mode);

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(_dll_name, EntryPoint = "XPending")]
        extern internal static int Pending(Display display);

        //[System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(_dll_name, EntryPoint = "XNextEvent")]
        extern internal static void NextEvent(
            Display display,
            [MarshalAs(UnmanagedType.AsAny)][In, Out]object e);
        
        [DllImport(_dll_name, EntryPoint = "XNextEvent")]
        extern internal static void NextEvent(Display display, [In, Out] IntPtr e);
        
        [DllImport(_dll_name, EntryPoint = "XPeekEvent")]
        extern internal static void PeekEvent(
            Display display,
            [MarshalAs(UnmanagedType.AsAny)][In, Out]object event_return
        );
        
        [DllImport(_dll_name, EntryPoint = "XPeekEvent")]
        extern internal static void PeekEvent(
            Display display,
            [In, Out]Event event_return
        );

        [DllImport(_dll_name, EntryPoint = "XSendEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        extern internal static bool SendEvent(
            Display display,
            Window window,
            bool propagate,
            [MarshalAs(UnmanagedType.SysInt)]
            EventMask event_mask,
            ref Event event_send
        );

        #endregion

        #region Thing grabbin'

        [DllImport(_dll_name, EntryPoint = "XGrabPointer")]
        extern internal static ErrorCodes XGrabPointer(
            Display display,
            IntPtr grab_window,
            bool owner_events, int event_mask,
            GrabMode pointer_mode,
            GrabMode keyboard_mode,
            IntPtr confine_to,
            IntPtr cursor,
            int time
        );

        [DllImport(_dll_name, EntryPoint = "XUngrabPointer")]
        extern internal static ErrorCodes XUngrabPointer(Display display, int time);

        [DllImport(_dll_name, EntryPoint = "XGrabKeyboard")]
        extern internal static ErrorCodes XGrabKeyboard(Display display, IntPtr grab_window,
            bool owner_events, GrabMode pointer_mode, GrabMode keyboard_mode, int time);

        [DllImport(_dll_name, EntryPoint = "XUngrabKeyboard")]
        extern internal static void XUngrabKeyboard(Display display, int time);

        #endregion

        #region Xf86VidMode internal structures

        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeModeLine
        {
            short hdisplay;   /* Number of display pixels horizontally */
            short hsyncstart; /* Horizontal sync start */
            short hsyncend;   /* Horizontal sync end */
            short htotal;     /* Total horizontal pixels */
            short vdisplay;   /* Number of display pixels vertically */
            short vsyncstart; /* Vertical sync start */
            short vsyncend;   /* Vertical sync start */
            short vtotal;     /* Total vertical pixels */
            int flags;      /* Mode flags */
            int privsize;   /* Size of private */
            IntPtr _private;   /* Server privates */
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
            internal int dotclock;

            /// <summary>
            /// Number of display pixels horizontally
            /// </summary>
            internal short hdisplay;

            /// <summary>
            /// Horizontal sync start
            /// </summary>
            internal short hsyncstart;

            /// <summary>
            /// Horizontal sync end
            /// </summary>
            internal short hsyncend;

            /// <summary>
            /// Total horizontal pixel
            /// </summary>
            internal short htotal;

            /// <summary>
            /// 
            /// </summary>
            internal short hskew;

            /// <summary>
            /// Number of display pixels vertically
            /// </summary>
            internal short vdisplay;

            /// <summary>
            /// Vertical sync start
            /// </summary>
            internal short vsyncstart;

            /// <summary>
            /// Vertical sync end
            /// </summary>
            internal short vsyncend;

            /// <summary>
            /// Total vertical pixels
            /// </summary>
            internal short vtotal;

            /// <summary>
            /// 
            /// </summary>
            internal short vskew;

            /// <summary>
            /// Mode flags
            /// </summary>
            internal int flags;

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
        extern internal static bool XF86VidModeQueryExtension(
            Display display,
            out int event_base_return,
            out int error_base_return);
        /*
        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeSwitchMode(
            Display display,
            int screen,
            int zoom);
        */

        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeSwitchToMode(
            Display display,
            int screen,
            IntPtr
            /*XF86VidModeModeInfo* */ modeline);


        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeQueryVersion(
            Display display,
            out int major_version_return,
            out int minor_version_return);

        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeGetAllModeLines(
            Display display,
            int screen,
            out int modecount_return,
            /*XF86VidModeModeInfo***  <-- yes, that's three *'s. */
            out IntPtr modesinfo);

        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeSetViewPort(
            Display display,
            int screen,
            int x,
            int y);

        /*
Bool XF86VidModeSetClientVersion(
    Display *display);

Bool XF86VidModeGetModeLine(
    Display *display,
    int screen,
    int *dotclock_return,
    XF86VidModeModeLine *modeline);

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

Bool XF86VidModeGetViewPort(
    Display *display,
    int screen,
    int *x_return,
    int *y_return);


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
    }

    #endregion

    #region X11 Structures

    #region internal class VisualInfo

    [StructLayout(LayoutKind.Sequential)]
    public class VisualInfo
    {
        internal IntPtr visual;
        internal int visualid;
        internal int screen;
        internal int depth;
        internal int @class;
        internal long redMask;
        internal long greenMask;
        internal long blueMask;
        internal int colormap_size;
        internal int bits_per_rgb;

        public override string ToString()
        {
 	         return base.ToString();
        }
    }

    #endregion

    #region internal class SetWindowAttributes

    [StructLayout(LayoutKind.Sequential)]
    internal class SetWindowAttributes
    {
        /// <summary>
        /// background, None, or ParentRelative
        /// </summary>
        internal Pixmap background_pixmap;
        /// <summary>
        /// background pixel
        /// </summary>
        internal long background_pixel;
        /// <summary>
        /// border of the window or CopyFromParent
        /// </summary>
        internal Pixmap border_pixmap;
        /// <summary>
        /// border pixel value
        /// </summary>
        internal long border_pixel;
        /// <summary>
        /// one of bit gravity values
        /// </summary>
        internal int bit_gravity;
        /// <summary>
        /// one of the window gravity values
        /// </summary>
        internal int win_gravity;
        /// <summary>
        /// NotUseful, WhenMapped, Always
        /// </summary>
        internal int backing_store;
        /// <summary>
        /// planes to be preserved if possible
        /// </summary>
        internal long backing_planes;
        /// <summary>
        /// value to use in restoring planes
        /// </summary>
        internal long backing_pixel;
        /// <summary>
        /// should bits under be saved? (popups)
        /// </summary>
        internal bool save_under;
        /// <summary>
        /// set of events that should be saved
        /// </summary>
        internal EventMask event_mask;
        /// <summary>
        /// set of events that should not propagate
        /// </summary>
        internal long do_not_propagate_mask;
        /// <summary>
        /// boolean value for override_redirect
        /// </summary>
        internal bool override_redirect;
        /// <summary>
        /// color map to be associated with window
        /// </summary>
        internal Colormap colormap;
        /// <summary>
        /// cursor to be displayed (or None)
        /// </summary>
        internal Cursor cursor;
    }

    #endregion

    #region internal struct SizeHints

    [StructLayout(LayoutKind.Sequential)]
    internal struct SizeHints
    {
        internal long flags;         /* marks which fields in this structure are defined */
        internal int x, y;           /* Obsolete */
        internal int width, height;  /* Obsolete */
        internal int min_width, min_height;
        internal int max_width, max_height;
        internal int width_inc, height_inc;
        internal struct min_aspect
        {
            internal int x;       /* numerator */
            internal int y;       /* denominator */
        }
        internal struct max_aspect
        {
            internal int x;       /* numerator */
            internal int y;       /* denominator */
        }
        internal int base_width, base_height;
        internal int win_gravity;
        /* this structure may be extended in the future */
    }

    #endregion

    #region Event structures

    #region XEvent

    [StructLayout(LayoutKind.Sequential)]
    //[StructLayout(LayoutKind.Explicit)]
    internal class Event
    {
        internal EventType Type;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];
        /*[FieldOffset(0)]internal EventType Type;*/
        /*[FieldOffset(0)]
        IntPtr
            pad1 , pad2 , pad3 , pad4 , pad5 , pad6 ,
            pad7 , pad8 , pad9 , pad10, pad11, pad12,
            pad13, pad14, pad15, pad16, pad17, pad18,
            pad19, pad20, pad21, pad22, pad23, pad24;*/
            
        /*private ConfigureNotifyEvent cne = new ConfigureNotifyEvent();
        internal ConfigureNotifyEvent ConfigureEvent
        {
            get
            {
                cne.type = this.Type;
                cne.serial = this.pad1;
            }
        }*/
       
        //[FieldOffset(0)]internal AnyEvent Any;
        //[FieldOffset(0)]internal KeyEvent Key;
        //[FieldOffset(0)]internal DestroyWindowEvent DestroyWindow;
        //[FieldOffset(0)]internal CreateWindowEvent CreateWindow;
        //[FieldOffset(0)]internal ResizeRequestEvent ResizeRequest;
        //[FieldOffset(0)]internal ConfigureNotifyEvent ConfigureNotify;
        //[FieldOffset(0)]internal ReparentNotifyEvent ReparentNotify;
        //[FieldOffset(0)]internal ExposeEvent Expose;
    }

    #endregion

    #region XAnyEvent

    [StructLayout(LayoutKind.Sequential)]
    internal class AnyEvent
    {
        internal EventType type;
	    //[MarshalAs(UnmanagedType.SysUInt)]
        internal IntPtr serial;	/* # of last request processed by server */
	    [MarshalAs(UnmanagedType.Bool)]
        internal bool send_event;	/* true if this came from a SendEvent request */
	    internal Display display;	/* Display the event was read from */
	    internal Window window;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];

    }

    #endregion

    #region XKeyEvent

    [StructLayout(LayoutKind.Sequential)]
    internal class KeyEvent
    {
        internal EventType type;		/* KeyPress or KeyRelease */
        [MarshalAs(UnmanagedType.SysUInt)]
	    internal ulong serial;	/* # of last request processed by server */
        [MarshalAs(UnmanagedType.Bool)]
	    internal bool send_event;	/* true if this came from a SendEvent request */
	    internal Display display;	/* Display the event was read from */
	    internal Window window;		/* ``event'' window it is reported relative to */
	    internal Window root;		/* root window that the event occurred on */
	    internal Window subwindow;	/* child window */
	    [MarshalAs(UnmanagedType.SysUInt)]
        internal Time time;		    /* milliseconds */
	    internal int x, y;		/* pointer x, y coordinates in event window */
	    internal int x_root, y_root;	/* coordinates relative to root */
	    internal uint state;	/* key or button mask */
	    internal uint keycode;	/* detail */
        [MarshalAs(UnmanagedType.Bool)]
	    internal bool same_screen;	/* same screen flag */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];
    }

    #endregion

    #region XDestroyWindowEvent

    [StructLayout(LayoutKind.Sequential)]
    internal class DestroyWindowEvent
    {
        internal EventType type;		    /* DestroyNotify */
        internal ulong serial;	    /* # of last request processed by server */
	    [MarshalAs(UnmanagedType.Bool)]
        internal bool send_event;	/* true if this came from a SendEvent request */
        internal Display display;	/* Display the event was read from */
        internal Window @event;
        internal Window window;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];
    }

    #endregion

    #region XCreateWindowEvent

    [StructLayout(LayoutKind.Sequential)]
    internal class CreateWindowEvent
    {
        internal EventType type;		/* CreateNotify */
        internal ulong serial;	/* # of last request processed by server */
        [MarshalAs(UnmanagedType.Bool)]
        internal bool send_event;	/* true if this came from a SendEvent request */
        internal Display display;	/* Display the event was read from */
        internal Window parent;		/* parent of the window */
        internal Window window;		/* window id of window created */
        internal int x, y;		/* window location */
        internal int width, height;	/* size of window */
        internal int border_width;	/* border width */
        [MarshalAs(UnmanagedType.Bool)]
        internal bool override_redirect;	/* creation should be overridden */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];
    }

    #endregion

    #region XResizeRequestEvent

    [StructLayout(LayoutKind.Sequential)]
    internal class ResizeRequestEvent
    {
        internal EventType type;	/* ResizeRequest */
	    internal ulong serial;	    /* # of last request processed by server */
        [MarshalAs(UnmanagedType.Bool)]
	    internal bool send_event;	/* true if this came from a SendEvent request */
	    internal Display display;	/* Display the event was read from */
	    internal Window window;
	    internal int width, height;
    }

    #endregion

    #region XConfigureNotifyEvent

    [StructLayout(LayoutKind.Sequential)]
    internal class ConfigureNotifyEvent
    {
        internal EventType type;	        /* ConfigureNotify */
        internal ulong serial;	/* # of last request processed by server */
        [MarshalAs(UnmanagedType.Bool)]
	    internal bool send_event;	/* true if this came from a SendEvent request */
        internal Display display;	/* Display the event was read from */
        internal Window @event;
        internal Window window;
        internal int x, y;
        internal int width, height;
        internal int border_width;
        internal Window above;
        [MarshalAs(UnmanagedType.Bool)]
        internal bool override_redirect;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];
    }

    #endregion
    
    #region XReparentNotifyEvent
    
    [StructLayout(LayoutKind.Sequential)]
    internal class ReparentNotifyEvent
    {
    	internal EventType type;               /* ReparentNotify */
        //[MarshalAs(UnmanagedType.SysUInt)]
    	internal IntPtr serial;	/* # of last request processed by server */
    	//[MarshalAs(UnmanagedType.Bool)]
    	internal bool send_event;	/* true if this came from a SendEvent request */
    	internal Display display;	/* Display the event was read from */
    	internal Window @event;
    	internal Window window;
    	internal Window parent;
    	internal int x, y;
    	//[MarshalAs(UnmanagedType.Bool)]
    	internal bool override_redirect;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];
    }
    
    #endregion
    
    #region XExposeEvent
    
    [StructLayout(LayoutKind.Sequential)]
    internal class ExposeEvent
    {
    	internal EventType type;		/* Expose */
    	internal ulong serial;	/* # of last request processed by server */
    	[MarshalAs(UnmanagedType.Bool)]
    	internal bool send_event;	/* true if this came from a SendEvent request */
    	internal Display display;	/* Display the event was read from */
    	internal Window window;
    	internal int x, y;
    	internal int width, height;
    	internal int count;		/* if nonzero, at least this many more */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=192)]
        byte[] pad = new byte[192];
    }

    #endregion

    #endregion

    #endregion

    #region X11 Constants and Enums

    internal struct Constants
    {
        internal const int QueuedAlready = 0;
        internal const int QueuedAfterReading = 1;
        internal const int QueuedAfterFlush = 2;

        internal const int CopyFromParent	= 0;
        internal const int CWX = 1;
        internal const int InputOutput = 1;
        internal const int InputOnly = 2;
    }

    internal enum EventType : int
    {
        NoEventMask	= 0,
        FocusOut	= 10,
        KeymapNotify = 11,
        Expose	= 12,
        GraphicsExpose	= 13,
        NoExpose	= 14,
        VisibilityNotify	= 15,
        CreateNotify	= 16,
        DestroyNotify	= 17,
        UnmapNotify	= 18,
        MapNotify	= 19,
        KeyPress	= 2,
        MapRequest	= 20,
        ReparentNotify	= 21,
        ConfigureNotify	= 22,
        ConfigureRequest	= 23,
        GravityNotify	= 24,
        ResizeRequest	= 25,
        CirculateNotify	= 26,
        CirculateRequest	= 27,
        PropertyNotify	= 28,
        SelectionClear	= 29,
        KeyRelease	= 3,
        SelectionRequest	= 30,
        SelectionNotify	= 31,
        ColormapNotify	= 32,
        ClientMessage	= 33,
        MappingNotify	= 34,
        LASTEvent	= 35,
        ButtonPress	= 4,
        ButtonRelease	= 5,
        MotionNotify	= 6,
        EnterNotify	= 7,
        LeaveNotify	= 8,
        FocusIn = 9,
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

    internal enum GrabMode : int
    {
        Sync = 0,
        Async = 1,
    }

    [Flags]
    internal enum EventMask : ulong
    {
        NoEventMask	= 0,
        KeyPressMask	= (1L<<0),
        KeyReeaseMask	= (1L<<1),
        Button3MotionMask	= (1L<<10),
        Button4MotionMask	= (1L<<11),
        Button5MotionMask	= (1L<<12),
        ButtonMotionMask	= (1L<<13),
        KeymapStateMask	= (1L<<14),
        ExposureMask	= (1L<<15),
        VisibiityChangeMask	= (1L<<16),
        StructureNotifyMask	= (1L<<17),
        ResizeRedirectMask	= (1L<<18),
        SubstructureNotifyMask	= (1L<<19),
        ButtonPressMask	= (1L<<2),
        SubstructureRedirectMask	= (1L<<20),
        FocusChangeMask	= (1L<<21),
        PropertyChangeMask	= (1L<<22),
        CoormapChangeMask	= (1L<<23),
        ButtonReeaseMask	= (1L<<3),
        EnterWindowMask	= (1L<<4),
        eaveWindowMask	= (1L<<5),
        PointerMotionMask	= (1L<<6),
        PointerMotionHintMask	= (1L<<7),
        Button1MotionMask	= (1L<<8),
        Button2MotionMask	= (1L<<9),
    }

    [Flags]
    internal enum CreateWindowMask : ulong
    {
        CWBackPixmap	= (1L<<0),
        CWBackPixel     = (1L<<1),
        CWSaveUnder	    = (1L<<10),
        CWEventMask	    = (1L<<11),
        CWDontPropagate	= (1L<<12),
        CWColormap  	= (1L<<13),
        CWCursor	    = (1L<<14),
        CWBorderPixmap	= (1L<<2),
        CWBorderPixel	= (1L<<3),
        CWBitGravity	= (1L<<4),
        CWWinGravity	= (1L<<5),
        CWBackingStore	= (1L<<6),
        CWBackingPlanes	= (1L<<7),
        CWBackingPixel 	= (1L<<8),
        CWOverrideRedirect	= (1L<<9),

        /*
        CWY	= (1<<1),
        CWWidth	= (1<<2),
        CWHeight	= (1<<3),
        CWBorderWidth	= (1<<4),
        CWSibling	= (1<<5),
        CWStackMode	= (1<<6),
        */
    }

    #endregion
}
