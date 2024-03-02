using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public struct CLMemoryObject : IEquatable<CLMemoryObject>
    {
        public readonly IntPtr Handle;

        public CLMemoryObject(IntPtr handle)
        {
            Handle = handle;
        }

        public bool Equals(CLMemoryObject other)
        {
            return Handle.Equals(other.Handle);
        }

        public override bool Equals(object obj)
        {
            return obj is CLMemoryObject other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(CLMemoryObject left, CLMemoryObject right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CLMemoryObject left, CLMemoryObject right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(CLMemoryObject memobj) => memobj.Handle;

        public static explicit operator CLPipe(CLMemoryObject pipe) => new CLPipe(pipe.Handle);

        public static explicit operator CLImage(CLMemoryObject pipe) => new CLImage(pipe.Handle);

        public static explicit operator CLBuffer(CLMemoryObject pipe) => new CLBuffer(pipe.Handle);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
