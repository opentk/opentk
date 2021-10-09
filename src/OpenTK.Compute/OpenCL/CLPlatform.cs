using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLPlatform : IEquatable<CLPlatform>
	{
		public readonly IntPtr Handle;

		public CLPlatform(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLPlatform other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLPlatform other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLPlatform left, CLPlatform right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLPlatform left, CLPlatform right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLPlatform platform) => platform.Handle;

        public enum Info : uint
        {
            Profile = 0x0900,
            Version = 0x0901,
            Name = 0x0902,
            Vendor = 0x0903,
            Extensions = 0x0904,
            HostTimerResolution = 0x0905,
            NumericVersion = 0x0906,
            ExtensionsWithVersion = 0x0907,
            PlatformIcdSuffix = 0x0920
        }
    }
}
