using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("{Value}")]
    internal struct XDisplayPtr
    {
        public IntPtr Value { get; }

        public XDisplayPtr(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("{Value}")]
    internal struct XGC
    {
        public IntPtr Value { get; }

        public XGC(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct XAtom : IEquatable<XAtom>
    {
        public ulong Id { get; }

        public bool IsNone => Id == 0;

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
    internal struct XDrawable
    {
        public ulong Id { get; }

        public static readonly XDrawable None = new XDrawable(0);

        public XDrawable(ulong id)
        {
            Id = id;
        }

        public static implicit operator XDrawable(XWindow window)
        {
            return new XDrawable(window.Id);
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct XColorMap
    {
        public ulong Id { get; }

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
    internal struct XID
    {
        public ulong Id { get; }

        public static readonly XID None = new XID(0);

        public XID(ulong id)
        {
            Id = id;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct XPixmap
    {
        public ulong Id { get; }

        public static readonly XPixmap None = new XPixmap(0);

        public static readonly XPixmap ParentRelative = new XPixmap(1);

        public XPixmap(ulong id)
        {
            Id = id;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct XCursor : IEquatable<XCursor>
    {
        public ulong Id { get; }

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
    internal struct XVisualId
    {
        public ulong Id { get; }

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

    /// <summary>
    /// X11 Time Structure.
    /// </summary>
    internal struct XTime
    {
        /// <summary>
        /// Represents the current server time.
        /// </summary>
        public static readonly XTime CurrentTime = new XTime(0);

        /// <summary>
        /// Time value.
        /// </summary>
        public ulong Value { get; }

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
    internal struct XWindow : IEquatable<XWindow>
    {
        public ulong Id { get; }

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
}
