using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLEventObject : IEquatable<CLEventObject>
	{
		public readonly IntPtr Handle;

		public CLEventObject(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLEventObject other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLEventObject other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLEventObject left, CLEventObject right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLEventObject left, CLEventObject right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLEventObject eventObject) => eventObject.Handle;
	}
}
