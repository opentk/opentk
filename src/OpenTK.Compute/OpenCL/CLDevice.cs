using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLDevice : IEquatable<CLDevice>
	{
		public readonly IntPtr Handle;

		public CLDevice(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLDevice other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLDevice other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLDevice left, CLDevice right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLDevice left, CLDevice right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLDevice device) => device.Handle;

        public enum Info : ulong
        {
            Type = 0x1000,
            VendorId = 0x1001,
            MaximumComputeUnits = 0x1002,
            MaximumWorkItemDimensions = 0x1003,
            MaximumWorkGroupSize = 0x1004,
            MaximumWorkItemSizes = 0x1005,
            PreferredVectorWidthChar = 0x1006,
            PreferredVectorWidthShort = 0x1007,
            PreferredVectorWidthInt = 0x1008,
            PreferredVectorWidthLong = 0x1009,
            PreferredVectorWidthFloat = 0x100A,
            PreferredVectorWidthDouble = 0x100B,
            MaximumClockFrequency = 0x100C,
            AddressBits = 0x100D,
            MaximumReadImageArguments = 0x100E,
            MaximumWriteImageArguments = 0x100F,
            MaximumMemoryAllocationSize = 0x1010,
            Image2DMaximumWidth = 0x1011,
            Image2DMaximumHeight = 0x1012,
            Image3DMaximumWidth = 0x1013,
            Image3DMaximumHeight = 0x1014,
            Image3DMaximumDepth = 0x1015,
            ImageSupport = 0x1016,
            MaximumParameterSize = 0x1017,
            MaximumSamplers = 0x1018,
            MemoryBaseAddressAlignment = 0x1019,

            [Obsolete("MinimumDataTypeAlignmentSize is a deprecated OpenCL 1.1 property.")]
            MinimumDataTypeAlignmentSize = 0x101A,
            SingleFloatingPointConfiguration = 0x101B,
            GlobalMemoryCacheType = 0x101C,
            GlobalMemoryCachelineSize = 0x101D,
            GlobalMemoryCacheSize = 0x101E,
            GlobalMemorySize = 0x101F,
            MaximumConstantBufferSize = 0x1020,
            MaximumConstantArguments = 0x1021,
            LocalMemoryType = 0x1022,
            LocalMemorySize = 0x1023,
            ErrorCorrectionSupport = 0x1024,
            ProfilingTimerResolution = 0x1025,
            EndianLittle = 0x1026,
            Available = 0x1027,
            CompilerAvailable = 0x1028,
            ExecutionCapabilities = 0x1029,

            [Obsolete("QueueProperties is a deprecated OpenCL 1.2 property, please use QueueOnHostProperties.")]
            QueueProperties = 0x102A,
            QueueOnHostProperties = 0x102A,

            Name = 0x102B,
            Vendor = 0x102C,
            DriverVersion = 0x102D,
            Profile = 0x102E,
            Version = 0x102F,
            Extensions = 0x1030,
            Platform = 0x1031,
            DoubleFloatingPointConfiguration = 0x1032,
            HalfFloatingPointConfiguration = 0x1033,
            PreferredVectorWidthHalf = 0x1034,

            [Obsolete("HostUnifiedMemory is a deprecated OpenCL 1.2 property.")]
            HostUnifiedMemory = 0x1035,
            NativeVectorWidthChar = 0x1036,
            NativeVectorWidthShort = 0x1037,
            NativeVectorWidthInt = 0x1038,
            NativeVectorWidthLong = 0x1039,
            NativeVectorWidthFloat = 0x103A,
            NativeVectorWidthDouble = 0x103B,
            NativeVectorWidthHalf = 0x103C,
            OpenClCVersion = 0x103D,
            LinkerAvailable = 0x103E,
            BuiltInKernels = 0x103F,
            ImageMaximumBufferSize = 0x1040,
            ImageMaximumArraySize = 0x1041,
            ParentDevice = 0x1042,
            PartitionMaximumSubDevices = 0x1043,
            PartitionProperties = 0x1044,
            PartitionAffinityDomain = 0x1045,
            PartitionType = 0x1046,
            ReferenceCount = 0x1047,
            PreferredInteropUserSync = 0x1048,
            PrintfBufferSize = 0x1049,
            ImagePitchAlignment = 0x104A,
            ImageBaseAddressAlignment = 0x104B,
            MaximumReadWriteImageArguments = 0x104C,
            MaximumGlobalVariableSize = 0x104D,
            QueueOnDeviceProperties = 0x104E,
            QueueOnDevicePreferredSize = 0x104F,
            QueueOnDeviceMaximumSize = 0x1050,
            MaximumOnDeviceQueues = 0x1051,
            MaximumOnDeviceEvents = 0x1052,
            SvmCapabilities = 0x1053,
            GlobalVariablePreferredTotalSize = 0x1054,
            MaximumPipeArguments = 0x1055,
            PipeMaximumActiveReservations = 0x1056,
            PipeMaximumPacketSize = 0x1057,
            PreferredPlatformAtomicAlignment = 0x1058,
            PreferredGlobalAtomicAlignment = 0x1059,
            PreferredLocalAtomicAlignment = 0x105A,
            IntermediateLanguageVersion = 0x105B,
            MaximumNumberOfSubGroups = 0x105C,
            SubGroupIndependentForwardProgress = 0x105D,

            DeviceNumericVersion = 0x105E,
            DeviceExtensionsWithVersion = 0x1060,
            DeviceIlsWithVersion = 0x1061,
            DeviceBuiltInKernelsWithVersion = 0x1062,
            DeviceAtomicMemoryCapabilities = 0x1063,
            DeviceAtomicFenceCapabilities = 0x1064,
            DeviceNonUniformWorkGroupSupport = 0x1065,
            DeviceOpenCLCAllVersions = 0x1066,
            DevicePreferredWorkGroupSizeMultiple = 0x1067,
            DeviceWorkGroupCollectiveFunctionsSupport = 0x1068,
            DeviceGenericAddressSpaceSupport = 0x1069,
            DeviceOpenCLCFeatures = 0x106f,
            DeviceDeviceEnqueueCapabilities = 0x1070,
            DevicePipeSupport = 0x1071,
            DeviceLatestConformanceVersionPassed = 0x1072,

            SpirVersion = 0x40e0
        }

        [Flags]
        public enum Type : ulong
        {
            Default = 1 << 0,
            Cpu = 1 << 1,
            Gpu = 1 << 2,
            Accelerator = 1 << 3,
            Custom = 1 << 4,
            All = 0xFFFFFFFF
        }

        public enum PartitionProperty : uint
        {
            ByCountsListEnd = 0,
            Equally = 0X1086,
            ByCounts = 0X1087,
            ByAffinityDomain = 0x1088
        }

        [Flags]
        public enum AffinityDomain : ulong
        {
            Numa = 1 << 0,
            L4Cache = 1 << 1,
            L3Cache = 1 << 2,
            L2Cache = 1 << 3,
            L1Cache = 1 << 4,
            NextPartitionable= 1 << 5,
        }
    }
}
