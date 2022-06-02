using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
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
}
