using System;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public readonly struct CLImage : IEquatable<CLImage>, ICLMemoryObject
    {
        private readonly IntPtr _handle;

        public IntPtr Handle
        {
            get => _handle;
        }

        public CLImage(IntPtr handle)
        {
            _handle = handle;
        }

        public bool Equals(CLImage other)
        {
            return Handle.Equals(other.Handle);
        }

        public override bool Equals(object obj)
        {
            return obj is CLImage other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(CLImage left, CLImage right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLImage left, CLImage right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(CLImage image) => image.Handle;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
