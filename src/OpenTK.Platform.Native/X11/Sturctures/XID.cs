using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
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

    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XPixMap
    {
        public ulong Id { get; }

        public static readonly XPixMap None = new XPixMap(0);

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
