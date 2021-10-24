using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLPlatform : IEquatable<CLPlatform>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLPlatform(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLPlatform other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLPlatform other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLPlatform left, CLPlatform right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLPlatform left, CLPlatform right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLPlatform platform) => platform.Handle;
    }
}
