using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLDevice : IEquatable<CLDevice>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

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
}
