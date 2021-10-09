using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLPipe : IEquatable<CLPipe>
	{
		public readonly IntPtr Handle;

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

        public enum Info : uint
        {
            PacketSize = 0x1120,
            MaximumNumberOfPackets = 0x1121,
            Properties = 0x1122
        }

        public enum Property : uint
        {

        }
    }
}
