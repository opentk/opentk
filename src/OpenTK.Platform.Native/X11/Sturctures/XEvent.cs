using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    // Note: The real size of the structure is 192 bytes, but including
    // some more bytes in order to prevent potential segfaults down
    // the line. May be removed later.
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    [DebuggerDisplay("{Type} Display={Any.Display} Window={Any.Window}")]
    public struct XEvent
    {
        [FieldOffset(0)]
        public XEventType Type;
        [FieldOffset(0)]
        public XAnyEvent Any;

        [FieldOffset(0)]
        public XConfigureRequestEvent ConfigureRequest;

        [FieldOffset(0)]
        public XClientMessageEvent ClientMessage;

        [FieldOffset(0)]
        public XButtonEvent ButtonPressed;

        [FieldOffset(0)]
        public XButtonEvent ButtonReleased;

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

    public struct XAnyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
    }

    public struct XConfigureRequestEvent
    {
        public XEventType Type;       /* ConfigureRequest */
        public ulong Serial;   /* # of last request processed by server */
        public byte SendEvent;    /* true if this came from a SendEvent request */
        public XDisplayPtr Display;   /* Display the event was read from */
        public XWindow Parent;
        public XWindow Window;
        public int X, Y;
        public int Width, Height;
        public int BorderWidth;
        public XWindow Above;
        public int Detail;     /* Above, Below, TopIf, BottomIf, Opposite */
        public ulong ValueMask;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct XClientMessageEvent
    {
        [FieldOffset(0) ] public XEventType Type;           /* ClientMessage */
        [FieldOffset(8) ] public ulong Serial;       /* # of last request processed by server */
        [FieldOffset(16)] public byte SendEvent;        /* true if this came from a SendEvent request */
        [FieldOffset(24)] public XDisplayPtr Display;       /* Display the event was read from */
        [FieldOffset(32)] public XWindow Window;
        [FieldOffset(40)] public XAtom MessageType;
        [FieldOffset(48)] public int Format;
        [FieldOffset(56)] public fixed byte b[20];
        [FieldOffset(56)] public fixed short s[10];
        [FieldOffset(56)] public fixed long l[5];
    }

    public struct XButtonEvent {

        public XEventType type;       /* ButtonPress or ButtonRelease */
        public ulong serial;   /* # of last request processed by server */
        public byte send_event;    /* true if this came from a SendEvent request */
        public XDisplayPtr display;   /* Display the event was read from */
        public XWindow window;      /* ``event'' window it is reported relative to */
        public XWindow root;        /* root window that the event occurred on */
        public XWindow subwindow;   /* child window */
        public XTime time;      /* milliseconds */
        public int x, y;       /* pointer x, y coordinates in event window */
        public int x_root, y_root; /* coordinates relative to root */
        public uint state; /* key or button mask */
        public uint button;    /* detail */
        public byte same_screen;	/* same screen flag */
    }
}
