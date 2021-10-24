using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLContext : IEquatable<CLContext>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLContext(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLContext other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLContext other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLContext left, CLContext right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLContext left, CLContext right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLContext context) => context.Handle;

    }
}
