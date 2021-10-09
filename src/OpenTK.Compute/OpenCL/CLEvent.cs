using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLEvent : IEquatable<CLEvent>
	{
		public readonly IntPtr Handle;

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

        public enum Info : uint
        {
            CommandQueue = 0x11D0,
            CommandType = 0x11D1,
            ReferenceCount = 0x11D2,
            CommandExecutionStatus = 0x11D3,
            Context = 0x11D4
        }
    }
}
