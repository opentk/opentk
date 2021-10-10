using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLProgram : IEquatable<CLProgram>
	{
		public readonly IntPtr Handle;
        public static CLBuffer Zero { get { return new CLBuffer(IntPtr.Zero); } }

        public CLProgram(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLProgram other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLProgram other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLProgram left, CLProgram right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLProgram left, CLProgram right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLProgram program) => program.Handle;
    }
}
