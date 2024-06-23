using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
    // FIXME: XID is an "unsigned long int". This will be 4 bytes on a 32-bit machine and 8 bytes on a 64-bit machine.
    // - Noggin_bops 2023-08-26

    [DebuggerDisplay("{Value}")]
    internal readonly struct XDisplayPtr
    {
        public readonly IntPtr Value { get; }

        public XDisplayPtr(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("{Value}")]
    internal readonly struct XGC
    {
        public readonly IntPtr Value { get; }

        public XGC(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("{Value}")]
    internal readonly struct XIC
    {
        public readonly IntPtr Value { get; }

        public XIC(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("{Value}")]
    internal readonly struct XIM
    {
        public readonly IntPtr Value { get; }

        public XIM(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("{Value}")]
    internal readonly struct XrmDatabase
    {
        public readonly IntPtr Value { get; }

        public XrmDatabase(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XAtom : IEquatable<XAtom>
    {
        public readonly ulong Id { get; }

        public readonly bool IsNone => Id == 0;

        public static readonly XAtom None = new XAtom(0);

        public XAtom(ulong id)
        {
            Id = id;
        }

        public bool Equals(XAtom other)
        {
            return other.Id == this.Id;
        }

        public static bool operator ==(XAtom a, XAtom b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(XAtom a, XAtom b)
        {
            return a.Id != b.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return
                obj != null ?
                    this.Id == 0 :
                    (obj is XAtom atom) && this == atom;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XDrawable
    {
        public readonly ulong Id { get; }

        public static readonly XDrawable None = new XDrawable(0);

        public XDrawable(ulong id)
        {
            Id = id;
        }

        public static explicit operator XDrawable(XWindow window)
        {
            return new XDrawable(window.Id);
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XColorMap
    {
        public readonly ulong Id { get; }

        public static readonly XColorMap None = new XColorMap(0);

        public XColorMap(ulong id)
        {
            Id = id;
        }
    }

    internal struct XColor
    {
        public ulong pixel;             /* pixel value */
        public ushort red, green, blue; /* rgb values */
        public XColorFlags flags;              /* DoRed, DoGreen, DoBlue */
        public byte pad;
    }

    internal unsafe struct XColorPtr
    {
        public XColor* Color { get; }

        public XColorPtr(IntPtr ptr)
        {
            Color = (XColor*)ptr;
        }

        public XColorPtr(XColor* color)
        {
            Color = color;
        }

        public static unsafe implicit operator XColorPtr(XColor* color) => new XColorPtr(color);
    }

    /// <summary>
    /// Generic XID type.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XID
    {
        public readonly ulong Id { get; }

        public static readonly XID None = new XID(0);

        public XID(ulong id)
        {
            Id = id;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XPixmap
    {
        public readonly ulong Id { get; }

        public static readonly XPixmap None = new XPixmap(0);

        public static readonly XPixmap ParentRelative = new XPixmap(1);

        public XPixmap(ulong id)
        {
            Id = id;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XCursor : IEquatable<XCursor>
    {
        public readonly ulong Id { get; }

        public static readonly XCursor None = new XCursor(0);

        public XCursor(ulong id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is XCursor cursor && Equals(cursor);
        }

        public bool Equals(XCursor other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(XCursor left, XCursor right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(XCursor left, XCursor right)
        {
            return !(left == right);
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XVisualId
    {
        public readonly ulong Id { get; }

        public static readonly XVisualId None = new XVisualId(0);

        public XVisualId(ulong id)
        {
            Id = id;
        }
    }

    internal struct XSetWindowAttributes
    {
        public XPixmap BackgroundPixmap;
        public ulong BackgroundPixel;
        public XPixmap BorderPixmap;
        public ulong BorderPixel;
        public int BitGravity;
        public int WindowGravity;
        public int BackingStore;
        public ulong BackingPlanes;
        public ulong BackingPixel;
        public int SaveUnder;
        public XEventMask EventMask;
        public XEventMask DoNotPropagateMask;
        public int OverrideRedirect;
        public XColorMap ColorMap;
        public XCursor Cursor;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    internal struct XSizeHints
    {
        public XSizeHintFlags Flags;
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int MinWidth;
        public int MinHeight;
        public int MaxWidth;
        public int MaxHeight;
        public int WidthIncrement;
        public int HeightIncrement;
        public int MinAspectNumerator;
        public int MinAspectDenominator;
        public int MaxAspectNumerator;
        public int MaxAspectDenominator;
        public int BaseWidth;
        public int BaseHeight;
        public int WindowGravity;
    }

    internal unsafe struct XClassHint
    {
        public byte *res_name;
        public byte *res_class;
    }

    internal unsafe struct XTextProperty
    {
        public byte* value;     /* property data */
        public XAtom encoding;  /* type of property */
        public int format;      /* 8, 16, or 32 */
        public ulong nitems;    /* number of items in value */
    }

    /// <summary>
    /// X11 Time Structure.
    /// </summary>
    internal readonly struct XTime
    {
        /// <summary>
        /// Represents the current server time.
        /// </summary>
        public static readonly XTime CurrentTime = new XTime(0);

        /// <summary>
        /// Time value.
        /// </summary>
        public readonly ulong Value { get; }

        public XTime(ulong value)
        {
            Value = value;
        }
    }

    internal struct XVisual
    {
        public IntPtr ExtensionData;
        public XVisualId VisualID;
        public int CClass;
        public ulong RedMask;
        public ulong GreenMask;
        public ulong BlueMask;
        public int BitsPerRgb;
        public int MapEntries;
    }

    internal struct XVisualInfo
    {
        public unsafe XVisual* VisualPtr;
        public XVisualId VisualId;
        public int Screen;
        public int Depth;
        public int CClass;
        public ulong RedMask;
        public ulong GreenMask;
        public ulong BlueMask;
        public int ColorMapSize;
        public int BitsPerRGB;
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XWindow : IEquatable<XWindow>
    {
        public readonly ulong Id { get; }

        public static readonly XWindow None = new XWindow(0);

        public XWindow(ulong id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is XWindow window && Equals(window);
        }

        public bool Equals(XWindow other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(XWindow left, XWindow right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(XWindow left, XWindow right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"0x{Id:X8}";
        }
    }

    internal struct XWindowAttributes
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int BorderWidth;
        public int Depth;
        public unsafe XVisual* Visual;
        public XWindow Root;
        public int CClass;
        public int BitGravity;
        public int WindowGravity;
        public int BackingStore;
        public ulong BackingPlanes;
        public ulong BackingPixel;
        public int SaveUnder;
        public XColorMap Colormap;
        public int MapInstalled;
        public MapState MapState;
        public XEventMask AllEventMasks;
        public XEventMask YourEventMasks;
        public XEventMask DoNotPropagateMask;
        public int OverrideRedirect;
        public IntPtr Screen; // TODO: replace with screen structure.
    }

    internal struct XWindowChanges
    {
        public int X, Y;
        public int Width, Height;
        public int BorderWidth;
        public XWindow Sibling;
        public int StackMode; // FIXME: Enum
    }

    internal struct XWMHints
    {
        internal XWMHintsMask flags;  /* marks which fields in this structure are defined */
        internal byte input;          /* does this application rely on the window manager to get keyboard input? */
        internal int initial_state; /* see below */
        internal XPixmap icon_pixmap; /* pixmap to be used as icon */
        internal XWindow icon_window; /* window to be used as icon */
        internal int icon_x, icon_y;  /* initial position of icon */
        internal XPixmap icon_mask;   /* pixmap to be used as mask for icon_pixmap */
        internal XID window_group;    /* id of related window group */
        /* this structure may be extended in the future */
    }

    internal struct MotifWmHints {
        public long flags;
        public long functions;
        public long decorations;
        public long input_mode;
        public long status;
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XKeySym : IEquatable<XKeySym>
    {
        public readonly ulong Id { get; }

        public static readonly XKeySym None = new XKeySym(0);

        public XKeySym(ulong id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is XKeySym cursor && Equals(cursor);
        }

        public bool Equals(XKeySym other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(XKeySym left, XKeySym right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(XKeySym left, XKeySym right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"{Id}";
        }
    }

    internal unsafe struct XComposeStatus {
        public char* compose_ptr;
        public int chars_matched;
    }

    /// <summary>
    /// Part of XFixes 5.0+.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct XPointerBarrier {
        public readonly ulong Id { get; }

        public static readonly XPointerBarrier None = new XPointerBarrier(0);

        public XPointerBarrier(ulong id)
        {
            Id = id;
        }
    }

#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
}
