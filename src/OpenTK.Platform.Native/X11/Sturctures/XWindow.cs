using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    public struct XWindow : IEquatable<XWindow>
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
}
