using System;

namespace OpenTK.Compute.OpenCL
{

    [Flags]
    public enum MemoryFlags : ulong
    {
        None = 0,
        ReadWrite = 1 << 0,
        WriteOnly = 1 << 1,
        ReadOnly = 1 << 2,
        UseHostPtr = 1 << 3,
        AllocHostPtr = 1 << 4,
        CopyHostPtr = 1 << 5,

        //Reserved = 1 << 6,
        HostWriteOnly = 1 << 7,
        HostReadOnly = 1 << 8,
        HostNoAccess = 1 << 9,
        SvmFineGrainBuffer = 1 << 10,
        SvmAtomics = 1 << 11,
        KernelReadAndWrite = 1 << 12,


        NoAccessIntel = 1 << 24,
        AccessFlagsUnrestrictedIntel = 1 << 25,
        UseUncachedCpuMemoryImg = 1 << 26,
        UseCachedCpuMemoryImg = 1 << 27,
        UseGrallocPtrImg = 1 << 28,
        ExtHostPtrQcom = 1 << 29,

        //Unused
        //	BusAddressableAmd = 1 << 30,
        //Unused
        //	ExternalMemoryAmd = 1 << 31,

        Reserved0ARM = 1 << 32,
        Reserved1ARM = 1 << 33,
        Reserved2ARM = 1 << 34,
        Reserved3ARM = 1 << 35,
        Reserved4ARM = 1 << 36,
    }

    public enum MemoryObjectType : uint
    {
        Buffer = 0x10F0,
        Image2D = 0x10F1,
        Image3D = 0x10F2,
        Image2DArray = 0x10F3,
        Image1D = 0x10F4,
        Image1DArray = 0x10F5,
        Image1DBuffer = 0x10F6,
        Pipe = 0x10F7
    }

    public enum ChannelOrder : uint
    {
        R = 0x10B0,
        A = 0x10B1,
        Rg = 0x10B2,
        Ra = 0x10B3,
        Rgb = 0x10B4,
        Rgba = 0x10B5,
        Bgra = 0x10B6,
        Argb = 0x10B7,
        Intensity = 0x10B8,
        Luminance = 0x10B9,
        Rx = 0x10BA,
        Rgx = 0x10BB,
        Rgbx = 0x10BC,
        Depth = 0x10BD,
        DepthStencil = 0x10BE,
        Srgb = 0x10BF,
        Srgbx = 0x10C0,
        Srgba = 0x10C1,
        Sbgra = 0x10C2,
        Abgr = 0x10C3
    }

    public enum ChannelType : uint
    {
        NormalizedSignedInteger8 = 0x10D0,
        NormalizedSignedInteger16 = 0x10D1,
        NormalizedUnsignedInteger8 = 0x10D2,
        NormalizedUnsignedInteger16 = 0x10D3,
        NormalizedUnsignedShortFloat565 = 0x10D4,
        NormalizedUnsignedShortFloat555 = 0x10D5,
        NormalizedUnsignedInteger101010 = 0x10D6,
        SignedInteger8 = 0x10D7,
        SignedInteger16 = 0x10D8,
        SignedInteger32 = 0x10D9,
        UnsignedInteger8 = 0x10DA,
        UnsignedInteger16 = 0x10DB,
        UnsignedInteger32 = 0x10DC,
        HalfFloat = 0x10DD,
        Float = 0x10DE,
        NormalizedUnsignedInteger24 = 0x10DF,
        NormalizedUnsignedInteger101010Version2 = 0x10E0
    }

    public enum MemoryObjectInfo : uint
    {
        Type = 0x1100,
        Flags = 0x1101,
        Size = 0x1102,
        HostPointer = 0x1103,
        MapCount = 0x1104,
        ReferenceCount = 0x1105,
        Context = 0x1106,
        AssociatedMemoryObject = 0x1107,
        Offset = 0x1108,
        UsesSvmPointer = 0x1109,
        Properties = 0x110A
    }

    [Flags]
    public enum SvmMemoryFlags : ulong
    {
        None = 0,
        ReadWrite = 1 << 0,
        WriteOnly = 1 << 1,
        ReadOnly = 1 << 2,
        UseHostPointer = 1 << 3,
        AllocateHostPointer = 1 << 4,
        CopyHostPointer = 1 << 5,
        HostWriteOnly = 1 << 7,
        HostReadOnly = 1 << 8,
        HostNoAccess = 1 << 9,
        SvmFineGrainBuffer = 1 << 10,
        SvmAtomics = 1 << 11,
        KernelReadAndWrite = 1 << 12
    }

    public enum CommandExecutionStatus : int
    {
        Error = -0x1,
        Complete = 0x0,
        Running = 0x1,
        Submitted = 0x2,
        Queued = 0x3
    }

    public enum ProfilingInfo : uint
    {
        CommandQueued = 0x1280,
        CommandSubmit = 0x1281,
        CommandStart = 0x1282,
        CommandEnd = 0x1283,
        CommandComplete = 0x1284
    }

    [Flags]
    public enum MapFlags : ulong
    {
        None = 0,
        Read = 1 << 0,
        Write = 1 << 1,
        WriteInvalidateRegion = 1 << 2
    }

    [Flags]
    public enum MemoryMigrationFlags : ulong
    {
        None = 0,
        Host = 1 << 0,
        ContentUndefined = 1 << 1
    }

    #region Platform

    public enum PlatformInfo : uint
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

    #endregion

    #region Context
    public enum ContextProperty : int
    {
        ContextPlatform = 0x1084, //cl_platform_id
        ContextInteropUserSync = 0x1085,
        GlContextKHR = 0x2008,
        EglDisplayKHR = 0x2009,
        GlxDisplayKHR = 0x200A,
        WglHDCKHR = 0x200B,
        CglShareGroupKHR = 0x200C,
        ContextD3D10DeviceKHR = 0x4014,
        ContextD3D11DeviceKHR = 0x401D,
        ContextAdapterD3D9KHR = 0x2025,
        ContextAdapterD3D9ExKHR = 0x2026,
        ContextAdapterDXVAKHR = 0x2027,
        ContextMemoryInitializeKHR = 0x2030,
        ContextTerminateKHR = -1121,
    }

    public enum ContextInfo : uint
    {
        ReferenceCount = 0x1080,
        Devices = 0x1081,
        Properties = 0x1082,
        NumberOfDevices = 0x1083
    }

    [Flags]
    public enum ContextMemoryInitializeKHR : ulong
    {
        Local = 1 << 0,
        Private = 1 << 1,
    }

    #endregion

    #region Device

    public enum DeviceInfo : ulong
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
    public enum DeviceType : ulong
    {
        Default = 1 << 0,
        Cpu = 1 << 1,
        Gpu = 1 << 2,
        Accelerator = 1 << 3,
        Custom = 1 << 4,
        All = 0xFFFFFFFF
    }

    public enum DevicePartitionProperty : uint
    {
        ByCountsListEnd = 0,
        Equally = 0X1086,
        ByCounts = 0X1087,
        ByAffinityDomain = 0x1088
    }

    [Flags]
    public enum DeviceAffinityDomain : ulong
    {
        Numa = 1 << 0,
        L4Cache = 1 << 1,
        L3Cache = 1 << 2,
        L2Cache = 1 << 3,
        L1Cache = 1 << 4,
        NextPartitionable = 1 << 5,
    }

    #endregion

    #region Buffer
    public enum BufferInfo : uint
    {
        Properties = 0x110A
    }

    public enum BufferProperty : uint
    {

    }

    public enum BufferCreateType : uint
    {
        Region = 0x1220
    }

    #endregion

    #region Image

    public enum ImageInfo : uint
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

    public enum ImageProperty : uint
    {

    }

    #endregion

    #region Pipe

    public enum PipeInfo : uint
    {
        PacketSize = 0x1120,
        MaximumNumberOfPackets = 0x1121,
        Properties = 0x1122
    }

    public enum PipeProperty : uint
    {

    }

    #endregion

    #region CommandQueue

    public enum CommandQueueInfo : uint
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
    public enum CommandQueueProperties : ulong
    {
        None = 0,
        OutOfOrderExecModeEnable = 1 << 0,
        ProfilingEnable = 1 << 1,
        OnDevice = 1 << 2,
        OnDeviceDefault = 1 << 3,
    }

    public enum CommandQueueProperty
    {
        Properties = 0x1093,
        Size = 0x1094,
        KernelBatchingARM = 0X41e7,
        DeferredFlushARM = 0X41ec,
        FamilyIntel = 0X418c,
        IndexIntel = 0X418d,
    }
    #endregion

    #region Program

    public enum ProgramInfo : uint
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

    public enum ProgramBuildInfo : uint
    {
        Status = 0x1181,
        Options = 0x1182,
        Log = 0x1183,
        BinaryType = 0x1184,
        GlobalVariableTotalSize = 0x1185
    }

    #endregion

    #region Kernel

    public enum KernelExecInfo : uint
    {
        SvmPointers = 0x11B6,
        SvmFineGrainSystem = 0x11B7
    }

    public enum KernelInfo : uint
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

    public enum KernelArgInfo : uint
    {
        AddressQualifier = 0x1196,
        AccessQualifier = 0x1197,
        TypeName = 0x1198,
        TypeQualifier = 0x1199,
        Name = 0x119A
    }

    public enum KernelWorkGroupInfo : uint
    {
        WorkGroupSize = 0x11B0,
        CompileWorkGroupSize = 0x11B1,
        LocalMemorySize = 0x11B2,
        PreferredWorkGroupSizeMultiple = 0x11B3,
        PrivateMemorySize = 0x11B4,
        GlobalWorkSize = 0x11B5
    }

    public enum KernelSubGroupInfo : uint
    {
        MaximumSubGroupSizeForNdRange = 0x2033,
        SubGroupCountForNdRange = 0x2034,
        LocalSizeForSubGroupCount = 0x11B8
    }

    #endregion

    #region Sampler

    public enum SamplerProperty : uint
    {
        NormalizedCoords = 0x1152,
        AddressingMode = 0x1153,
        FilterMode = 0x1154,
        MipFilterModeKHR = 0X1155,
        LodMinKHR = 0X1156,
        LodMaxKHR = 0X1157
    }

    public enum SamplerInfo : uint
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

    public enum SamplerFilterMode : uint
    {
        Nearest = 0x1140,
        Linear = 0x1141
    }

    public enum SamplerAddressingMode : uint
    {
        None = 0x1130,
        ClampToEdge = 0x1131,
        Clamp = 0x1132,
        Repeat = 0x1133,
        MirroredRepeat = 0x1134
    }

    #endregion

    #region Event

    public enum EventInfo : uint
    {
        CommandQueue = 0x11D0,
        CommandType = 0x11D1,
        ReferenceCount = 0x11D2,
        CommandExecutionStatus = 0x11D3,
        Context = 0x11D4
    }

    #endregion
}
