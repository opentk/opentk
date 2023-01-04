using System;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public readonly struct CLEvent : IEquatable<CLEvent>
    {
        public readonly IntPtr Handle;

        public CLEvent(IntPtr handle)
        {
            Handle = handle;
        }

        public bool Equals(CLEvent other)
        {
            return Handle.Equals(other.Handle);
        }

        public override bool Equals(object obj)
        {
            return obj is CLEvent other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(CLEvent left, CLEvent right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLEvent left, CLEvent right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(CLEvent @event) => @event.Handle;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
