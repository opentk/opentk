using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XWindow
    {
        public ulong Id { get; }

        public static readonly XWindow None = new XWindow(0);

        public XWindow(ulong id)
        {
            Id = id;
        }
    }
}
