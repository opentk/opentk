using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLImage : IEquatable<CLImage>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLImage(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLImage other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLImage other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLImage left, CLImage right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLImage left, CLImage right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLImage image) => image.Handle;
    }
}
