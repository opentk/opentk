using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLKernel : IEquatable<CLKernel>
	{
		public readonly IntPtr Handle;

		public CLKernel(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLKernel other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLKernel other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLKernel left, CLKernel right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLKernel left, CLKernel right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLKernel kernel) => kernel.Handle;

        public enum ExecInfo : uint
        {
            SvmPointers = 0x11B6,
            SvmFineGrainSystem = 0x11B7
        }

        public enum Info : uint
        {
            FunctionName = 0x1190,
            NumberOfArguments = 0x1191,
            ReferenceCount = 0x1192,
            Context = 0x1193,
            Program = 0x1194,
            Attributes = 0x1195,
            MaxNumberOfSubGroups = 0x11B9,
            CompileNumberOfSubGroups = 0x11BA
        }

        public enum ArgInfo : uint
        {
            AddressQualifier = 0x1196,
            AccessQualifier = 0x1197,
            TypeName = 0x1198,
            TypeQualifier = 0x1199,
            Name = 0x119A
        }

        public enum WorkGroupInfo : uint
        {
            WorkGroupSize = 0x11B0,
            CompileWorkGroupSize = 0x11B1,
            LocalMemorySize = 0x11B2,
            PreferredWorkGroupSizeMultiple = 0x11B3,
            PrivateMemorySize = 0x11B4,
            GlobalWorkSize = 0x11B5
        }

        public enum SubGroupInfo : uint
        {
            MaximumSubGroupSizeForNdRange = 0x2033,
            SubGroupCountForNdRange = 0x2034,
            LocalSizeForSubGroupCount = 0x11B8
        }
    }
}
