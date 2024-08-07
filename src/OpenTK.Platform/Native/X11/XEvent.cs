using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Platform.Native.X11.XRandR;

namespace OpenTK.Platform.Native.X11
{
#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
    internal struct XErrorEvent
    {
        public XEventType type;
        public XDisplayPtr display;       /* Display the event was read from */
        public XID resourceid;         /* resource id */
        public ulong serial;       /* serial number of failed request */
        public XError error_code;   /* error code of failed request */
        public XRequestCode request_code; /* Major op-code of failed request */
        public byte minor_code;   /* Minor op-code of failed request */
    }

    // Note: The real size of the structure is 192 bytes, but including
    // some more bytes in order to prevent potential segfaults down
    // the line. May be removed later.
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    [DebuggerDisplay("{Type} Display={Any.Display} Window={Any.Window}")]
    internal struct XEvent
    {
        [FieldOffset(0)]
        public XEventType Type;
        [FieldOffset(0)]
        public XAnyEvent Any;

        [FieldOffset(0)]
        public XConfigureRequestEvent ConfigureRequest;

        [FieldOffset(0)]
        public XConfigureEvent Configure;

        [FieldOffset(0)]
        public XClientMessageEvent ClientMessage;

        [FieldOffset(0)]
        public XButtonEvent ButtonPressed;

        [FieldOffset(0)]
        public XButtonEvent ButtonReleased;

        [FieldOffset(0)]
        public XKeyEvent KeyPressed;

        [FieldOffset(0)]
        public XKeyEvent KeyReleased;

        [FieldOffset(0)]
        public XMotionEvent Motion;

        [FieldOffset(0)]
        public XCrossingEvent Enter;

        [FieldOffset(0)]
        public XCrossingEvent Leave;

        [FieldOffset(0)]
        public XFocusChangeEvent FocusIn;

        [FieldOffset(0)]
        public XFocusChangeEvent FocusOut;

        [FieldOffset(0)]
        public XUnmapEvent Unmap;

        [FieldOffset(0)]
        public XReparentEvent Reparent;

        [FieldOffset(0)]
        public XPropertyEvent Property;

        [FieldOffset(0)]
        public XSelectionEvent Selection;

        #region XRandR

        [FieldOffset(0)]
        public XRRScreenChangeNotifyEvent RRScreenChangeNotify;

        [FieldOffset(0)]
        public XRRNotifyEvent RRNotify;

        [FieldOffset(0)]
        public XRROutputChangeNotifyEvent RROutputChangeNotify;

        [FieldOffset(0)]
        public XRRCrtcChangedNotifyEvent RRCrtcChanged;

        [FieldOffset(0)]
        public XRROutputPropertyNotifyEvent RROutputPropertyNotify;

        [FieldOffset(0)]
        public XRRProviderChangeNotifyEvent RRProviderChangeNotify;

        [FieldOffset(0)]
        public XRRProviderPropertyNotifyEvent RRProviderPropertyNotify;

        [FieldOffset(0)]
        public XRRResourceChangeNotifyEvent RRResourceChangeNotify;

        #endregion
    }

    internal struct XAnyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
    }

    internal struct XConfigureRequestEvent
    {
        public XEventType Type;     /* ConfigureRequest */
        public ulong Serial;        /* # of last request processed by server */
        public int SendEvent;      /* true if this came from a SendEvent request */
        public XDisplayPtr Display; /* Display the event was read from */
        public XWindow Parent;
        public XWindow Window;
        public int X, Y;
        public int Width, Height;
        public int BorderWidth;
        public XWindow Above;
        public int Detail;          /* Above, Below, TopIf, BottomIf, Opposite */
        public ulong ValueMask;
    }

    internal struct XConfigureEvent {
        public XEventType type;	        /* ConfigureNotify */
        public ulong serial;	/* # of last request processed by server */
        public int send_event;	/* true if this came from a SendEvent request */
        public XDisplayPtr display;	/* Display the event was read from */
        public XWindow @event;
        public XWindow window;
        public int x, y;
        public int width, height;
        public int border_width;
        public XWindow above;
        public byte override_redirect;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct XClientMessageEvent
    {
        [FieldOffset(0) ] public XEventType Type;     /* ClientMessage */
        [FieldOffset(8) ] public ulong Serial;        /* # of last request processed by server */
        [FieldOffset(16)] public int SendEvent;      /* true if this came from a SendEvent request */
        [FieldOffset(24)] public XDisplayPtr Display; /* Display the event was read from */
        [FieldOffset(32)] public XWindow Window;
        [FieldOffset(40)] public XAtom MessageType;
        [FieldOffset(48)] public int Format;
        [FieldOffset(56)] public fixed byte b[20];
        [FieldOffset(56)] public fixed short s[10];
        [FieldOffset(56)] public fixed long l[5];
    }

    internal struct XButtonEvent
    {
        public XEventType type;     /* ButtonPress or ButtonRelease */
        public ulong serial;        /* # of last request processed by server */
        public int send_event;      /* true if this came from a SendEvent request */
        public XDisplayPtr display; /* Display the event was read from */
        public XWindow window;      /* ``event'' window it is reported relative to */
        public XWindow root;        /* root window that the event occurred on */
        public XWindow subwindow;   /* child window */
        public XTime time;          /* milliseconds */
        public int x, y;            /* pointer x, y coordinates in event window */
        public int x_root, y_root;  /* coordinates relative to root */
        public uint state;          /* key or button mask */
        public uint button;         /* detail */
        public byte same_screen;    /* same screen flag */
    }

    internal struct XKeyEvent {
        public XEventType type;     /* KeyPress or KeyRelease */
        public ulong serial;        /* # of last request processed by server */
        public int send_event;      /* true if this came from a SendEvent request */
        public XDisplayPtr display; /* Display the event was read from */
        public XWindow window;      /* ``event'' window it is reported relative to */
        public XWindow root;        /* root window that the event occurred on */
        public XWindow subwindow;   /* child window */
        public XTime time;          /* milliseconds */
        public int x, y;            /* pointer x, y coordinates in event window */
        public int x_root, y_root;  /* coordinates relative to root */
        public uint state;          /* key or button mask */
        public uint keycode;        /* detail */
        public byte same_screen;    /* same screen flag */
    }

    internal struct XMotionEvent
    {
        public XEventType type;     /* MotionNotify */
        public ulong serial;        /* # of last request processed by server */
        public int send_event;      /* true if this came from a SendEvent request */
        public XDisplayPtr display; /* Display the event was read from */
        public XWindow window;      /* ``event'' window reported relative to */
        public XWindow root;        /* root window that the event occurred on */
        public XWindow subwindow;   /* child window */
        public XTime time;          /* milliseconds */
        public int x, y;            /* pointer x, y coordinates in event window */
        public int x_root, y_root;  /* coordinates relative to root */
        public uint state;          /* key or button mask */
        public byte is_hint;        /* detail */
        public byte same_screen;    /* same screen flag */
    }

    internal struct XCrossingEvent
    {
        public XEventType type;            /* EnterNotify or LeaveNotify */
        public ulong serial;        /* # of last request processed by server */
        public int send_event;      /* true if this came from a SendEvent request */
        public XDisplayPtr display; /* Display the event was read from */
        public XWindow window;      /* ``event'' window reported relative to */
        public XWindow root;        /* root window that the event occurred on */
        public XWindow subwindow;   /* child window */
        public XTime time;          /* milliseconds */
        public int x, y;            /* pointer x, y coordinates in event window */
        public int x_root, y_root;  /* coordinates relative to root */
        public int mode;            /* NotifyNormal, NotifyGrab, NotifyUngrab */
        public int detail;
        /*
        * NotifyAncestor, NotifyVirtual, NotifyInferior, 
        * NotifyNonlinear,NotifyNonlinearVirtual
        */
        public byte same_screen;    /* same screen flag */
        public byte focus;          /* boolean focus */
        public uint state;	        /* key or button mask */
    }

    internal struct XFocusChangeEvent
    {
        public XEventType type;      /* FocusIn or FocusOut */
        public ulong serial;         /* # of last request processed by server */
        public int send_event;       /* true if this came from a SendEvent request */
        public XDisplayPtr display;  /* Display the event was read from */
        public XWindow window;       /* window of event */
        public FocusChangeMode mode; /* NotifyNormal, NotifyGrab, NotifyUngrab */
        public FocusChangeDetail detail;
        /*
        * NotifyAncestor, NotifyVirtual, NotifyInferior, 
        * NotifyNonlinear,NotifyNonlinearVirtual, NotifyPointer,
        * NotifyPointerRoot, NotifyDetailNone 
        */
    }

    internal struct XUnmapEvent
    {
        public XEventType type;     /* UnmapNotify */
        public ulong serial;        /* # of last request processed by server */
        public int send_event;      /* true if this came from a SendEvent request */
        public XDisplayPtr display; /* Display the event was read from */
        public XWindow @event;
        public XWindow window;
        public byte from_configure;
    }

    internal struct XReparentEvent
    {
        public XEventType type;     /* ReparentNotify */
        public ulong serial;        /* # of last request processed by server */
        public int send_event;      /* true if this came from a SendEvent request */
        public XDisplayPtr display; /* Display the event was read from */
        public XWindow @event;
        public XWindow window;
        public XWindow parent;
	    public int x, y;
        public byte override_redirect;
    }

    internal struct XPropertyEvent
    {
        public XEventType type;     /* PropertyNotify */
        public ulong serial;        /* # of last request processed by server */
        public int send_event;      /* true if this came from a SendEvent request */
        public XDisplayPtr display; /* Display the event was read from */
        public XWindow window;
        public XAtom atom;
        public XTime time;
        public PropertyState state; /* PropertyNewValue or PropertyDelete */
    }

    internal struct XSelectionEvent {
        public XEventType type;		/* SelectionNotify */
        public ulong serial;	    /* # of last request processed by server */
        public int send_event;	    /* true if this came from a SendEvent request */
        public XDisplayPtr display;	/* Display the event was read from */
        public XWindow requestor;
        public XAtom selection;
        public XAtom target;
        public XAtom property;		/* atom or None */
        public XTime time;
    }
#pragma warning restore CS0649 // Field '' is never assigned to, and will always have its default value 0
}
