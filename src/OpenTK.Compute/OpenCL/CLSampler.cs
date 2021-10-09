using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLSampler : IEquatable<CLSampler>
	{
		public readonly IntPtr Handle;

		public CLSampler(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLSampler other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLSampler other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLSampler left, CLSampler right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLSampler left, CLSampler right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLSampler sampler) => sampler.Handle;

        public enum Property : uint
        {
            NormalizedCoords = 0x1152,
            AddressingMode = 0x1153,
            FilterMode = 0x1154,
            MipFilterModeKHR = 0X1155,
            LodMinKHR = 0X1156,
            LodMaxKHR = 0X1157
        }

        public enum Info : uint
        {
            ReferenceCount = 0X1150,
            Context = 0x1151,
            NormalizedCoords = 0x1152,
            AddressingMode = 0x1153,
            FilterMode = 0x1154,
            MipFilterModeKHR = 0X1155,
            LodMinKHR = 0X1156,
            LodMaxKHR = 0X1157,
            Properties = 0x1158
        }

        public enum FilterMode : uint
        {
            Nearest = 0x1140,
            Linear = 0x1141
        }

        public enum AddressingMode : uint
        {
            None = 0x1130,
            ClampToEdge = 0x1131,
            Clamp = 0x1132,
            Repeat = 0x1133,
            MirroredRepeat = 0x1134
        }
    }
}
