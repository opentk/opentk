using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLKernel : IEquatable<CLKernel>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLKernel(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLKernel other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLKernel other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLKernel left, CLKernel right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLKernel left, CLKernel right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLKernel kernel) => kernel.Handle;
    }
}
