using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
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
}
