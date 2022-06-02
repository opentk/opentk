using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
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
