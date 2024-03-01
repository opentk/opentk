using System;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public readonly struct CLPipe : IEquatable<CLPipe>, ICLMemoryObject
    {
        private readonly IntPtr _handle;

        public IntPtr Handle
        {
            get => _handle;
        }

        public CLPipe(IntPtr handle)
        {
            _handle = handle;
        }

        public bool Equals(CLPipe other)
        {
            return Handle.Equals(other.Handle);
        }

        public override bool Equals(object obj)
        {
            return obj is CLPipe other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(CLPipe left, CLPipe right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLPipe left, CLPipe right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(CLPipe pipe) => pipe.Handle;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
