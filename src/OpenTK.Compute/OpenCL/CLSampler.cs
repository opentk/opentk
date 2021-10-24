using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLSampler : IEquatable<CLSampler>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLSampler(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLSampler other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLSampler other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLSampler left, CLSampler right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLSampler left, CLSampler right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLSampler sampler) => sampler.Handle;
    }
}
