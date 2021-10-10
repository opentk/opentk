using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLCommandQueue : IEquatable<CLCommandQueue>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLCommandQueue(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLCommandQueue other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLCommandQueue other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLCommandQueue left, CLCommandQueue right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLCommandQueue left, CLCommandQueue right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLCommandQueue queue) => queue.Handle;
    }
}
