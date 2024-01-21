using System;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public readonly struct CLDevice : IEquatable<CLDevice>
    {
        public readonly IntPtr Handle;

        public CLDevice(IntPtr handle)
        {
            Handle = handle;
        }

        public bool Equals(CLDevice other)
        {
            return Handle.Equals(other.Handle);
        }

        public override bool Equals(object obj)
        {
            return obj is CLDevice other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(CLDevice left, CLDevice right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLDevice left, CLDevice right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(CLDevice device) => device.Handle;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
