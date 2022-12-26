using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XAtom : IEquatable<XAtom>
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
    public struct XDrawable
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
    public struct XColorMap
    {
        public ulong Id { get; }

        public static readonly XColorMap None = new XColorMap(0);

        public XColorMap(ulong id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// Generic XID type.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XID
    {
        public ulong Id { get; }

        public static readonly XID None = new XID(0);

        public XID(ulong id)
        {
            Id = id;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XPixMap
    {
        public ulong Id { get; }

        public static readonly XPixMap None = new XPixMap(0);

        public static readonly XPixMap ParentRelative = new XPixMap(1);

        public XPixMap(ulong id)
        {
            Id = id;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XCursor
    {
        public ulong Id { get; }

        public static readonly XCursor None = new XCursor(0);

        public XCursor(ulong id)
        {
            Id = id;
        }
    }

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XVisualId
    {
        public ulong Id { get; }

        public static readonly XVisualId None = new XVisualId(0);

        public XVisualId(ulong id)
        {
            Id = id;
        }
    }
}
