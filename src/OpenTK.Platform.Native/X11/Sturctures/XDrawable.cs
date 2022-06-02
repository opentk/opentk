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
}
