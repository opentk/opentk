using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLEvent : IEquatable<CLEvent>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLEvent(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLEvent other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLEvent other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLEvent left, CLEvent right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLEvent left, CLEvent right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLEvent @event) => @event.Handle;
    }
}
