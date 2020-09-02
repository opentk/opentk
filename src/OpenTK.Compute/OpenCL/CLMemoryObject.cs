using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLMemoryObject : IEquatable<CLMemoryObject>
	{
		public readonly IntPtr Handle;

		public CLMemoryObject(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLMemoryObject other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLMemoryObject other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLMemoryObject left, CLMemoryObject right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLMemoryObject left, CLMemoryObject right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLMemoryObject mem) => mem.Handle;
	}
}
