using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLBuffer : IEquatable<CLBuffer>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get{ return new CLBuffer(IntPtr.Zero); } }

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
    }
}
