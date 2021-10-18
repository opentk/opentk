using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct SvmBuffer : IEquatable<SvmBuffer>
	{
		public readonly IntPtr Handle;
        public static SvmBuffer Zero { get{ return new SvmBuffer(IntPtr.Zero); } }

		public SvmBuffer(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(SvmBuffer other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is SvmBuffer other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(SvmBuffer left, SvmBuffer right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(SvmBuffer left, SvmBuffer right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(SvmBuffer buffer) => buffer.Handle;
    }
}
