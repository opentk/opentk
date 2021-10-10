using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLPipe : IEquatable<CLPipe>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLPipe(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLPipe other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLPipe other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLPipe left, CLPipe right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLPipe left, CLPipe right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLPipe pipe) => pipe.Handle;
    }
}
