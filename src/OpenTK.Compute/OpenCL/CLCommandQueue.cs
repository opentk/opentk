using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLCommandQueue : IEquatable<CLCommandQueue>
	{
		public readonly IntPtr Handle;

		public CLCommandQueue(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLCommandQueue other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLCommandQueue other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLCommandQueue left, CLCommandQueue right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLCommandQueue left, CLCommandQueue right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLCommandQueue queue) => queue.Handle;

        public enum Info : uint
        {
            Context = 0x1090,
            Device = 0x1091,
            ReferenceCount = 0x1092,
            Properties = 0x1093,
            Size = 0x1094,
            DeviceDefault = 0x1095,
            PropertiesArray = 0x1098
        }

        [Flags]
        public enum Properties : ulong
        {
            None = 0,
            OutOfOrderExecModeEnable = 1 << 0,
            ProfilingEnable = 1 << 1,
            OnDevice = 1 << 2,
            OnDeviceDefault = 1 << 3,
        }

        public enum Property
        {
            Properties = 0x1093,
            Size = 0x1094,
            KernelBatchingARM = 0X41e7,
            DeferredFlushARM = 0X41ec,
            FamilyIntel = 0X418c,
            IndexIntel = 0X418d,
        }
    }
}
