using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLImage : IEquatable<CLImage>
	{
		public readonly IntPtr Handle;

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

        public enum Info : uint
        {
            Format = 0x1110,
            ElementSize = 0x1111,
            RowPitch = 0x1112,
            SlicePitch = 0x1113,
            Width = 0x1114,
            Height = 0x1115,
            Depth = 0x1116,
            ArraySize = 0x1117,
            Buffer = 0x1118,
            NumberOfMipLevels = 0x1119,
            NumberOfSamples = 0x111A
        }

        public enum Property : uint
        {
            
        }
    }
}
