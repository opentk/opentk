using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
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
}
