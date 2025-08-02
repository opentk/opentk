using System;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public readonly struct CLBuffer : IEquatable<CLBuffer>
    {
        public readonly IntPtr Handle;

        public CLBuffer(IntPtr handle)
        {
            Handle = handle;
        }

        public bool Equals(CLBuffer other)
        {
            return Handle.Equals(other.Handle);
        }

        public override bool Equals(object obj)
        {
            return obj is CLBuffer other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(CLBuffer left, CLBuffer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLBuffer left, CLBuffer right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(CLBuffer buffer) => buffer.Handle;

        public static explicit operator CLMemoryObject(CLBuffer buffer) => new CLMemoryObject(buffer.Handle);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
