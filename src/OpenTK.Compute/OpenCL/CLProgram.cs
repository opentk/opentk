using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLProgram : IEquatable<CLProgram>
	{
		public readonly IntPtr Handle;

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

        public enum Info : uint
        {
            ReferenceCount = 0x1160,
            Context = 0x1161,
            NumberOfDevices = 0x1162,
            Devices = 0x1163,
            Source = 0x1164,
            BinarySizes = 0x1165,
            Binaries = 0x1166,
            NumberOfKernels = 0x1167,
            KernelNames = 0x1168,
            Il = 0x1169
        }

        public enum BuildInfo : uint
        {
            Status = 0x1181,
            Options = 0x1182,
            Log = 0x1183,
            BinaryType = 0x1184,
            GlobalVariableTotalSize = 0x1185
        }
    }
}
