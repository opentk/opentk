#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;

namespace OpenTK.Compute.CL10
{
    #pragma warning disable 1591

    public enum AddressingMode
    {
        AddressNone = ((int)0X1130),
        AddressClampToEdge = ((int)0X1131),
        AddressClamp = ((int)0X1132),
        AddressRepeat = ((int)0X1133),
    }

    public enum All
    {
        DeviceTypeDefault = ((int)(1 << 0)),
        ExecKernel = ((int)(1 << 0)),
        FpDenorm = ((int)(1 << 0)),
        MapRead = ((int)(1 << 0)),
        MemReadWrite = ((int)(1 << 0)),
        QueueOutOfOrderExecModeEnable = ((int)(1 << 0)),
        DeviceTypeCpu = ((int)(1 << 1)),
        ExecNativeKernel = ((int)(1 << 1)),
        FpInfNan = ((int)(1 << 1)),
        MapWrite = ((int)(1 << 1)),
        MemWriteOnly = ((int)(1 << 1)),
        QueueProfilingEnable = ((int)(1 << 1)),
        DeviceTypeGpu = ((int)(1 << 2)),
        FpRoundToNearest = ((int)(1 << 2)),
        MemReadOnly = ((int)(1 << 2)),
        DeviceTypeAccelerator = ((int)(1 << 3)),
        FpRoundToZero = ((int)(1 << 3)),
        MemUseHostPtr = ((int)(1 << 3)),
        FpRoundToInf = ((int)(1 << 4)),
        MemAllocHostPtr = ((int)(1 << 4)),
        FpFma = ((int)(1 << 5)),
        MemCopyHostPtr = ((int)(1 << 5)),
        ScharMin = ((int)(-127-1)),
        IntMin = ((int)(-2147483647-1)),
        ShrtMin = ((int)(-32767-1)),
        BuildSuccess = ((int)0),
        False = ((int)0),
        Success = ((int)0),
        Complete = ((int)0X0),
        None = ((int)0X0),
        PlatformProfile = ((int)0X0900),
        PlatformVersion = ((int)0X0901),
        PlatformName = ((int)0X0902),
        PlatformVendor = ((int)0X0903),
        PlatformExtensions = ((int)0X0904),
        Local = ((int)0X1),
        ReadOnlyCache = ((int)0X1),
        Running = ((int)0X1),
        DeviceType = ((int)0X1000),
        DeviceVendorId = ((int)0X1001),
        DeviceMaxComputeUnits = ((int)0X1002),
        DeviceMaxWorkItemDimensions = ((int)0X1003),
        DeviceMaxWorkGroupSize = ((int)0X1004),
        DeviceMaxWorkItemSizes = ((int)0X1005),
        DevicePreferredVectorWidthChar = ((int)0X1006),
        DevicePreferredVectorWidthShort = ((int)0X1007),
        DevicePreferredVectorWidthInt = ((int)0X1008),
        DevicePreferredVectorWidthLong = ((int)0X1009),
        DevicePreferredVectorWidthFloat = ((int)0X100a),
        DevicePreferredVectorWidthDouble = ((int)0X100b),
        DeviceMaxClockFrequency = ((int)0X100c),
        DeviceAddressBits = ((int)0X100d),
        DeviceMaxReadImageArgs = ((int)0X100e),
        DeviceMaxWriteImageArgs = ((int)0X100f),
        DeviceMaxMemAllocSize = ((int)0X1010),
        DeviceImage2dMaxWidth = ((int)0X1011),
        DeviceImage2dMaxHeight = ((int)0X1012),
        DeviceImage3dMaxWidth = ((int)0X1013),
        DeviceImage3dMaxHeight = ((int)0X1014),
        DeviceImage3dMaxDepth = ((int)0X1015),
        DeviceImageSupport = ((int)0X1016),
        DeviceMaxParameterSize = ((int)0X1017),
        DeviceMaxSamplers = ((int)0X1018),
        DeviceMemBaseAddrAlign = ((int)0X1019),
        DeviceMinDataTypeAlignSize = ((int)0X101a),
        DeviceSingleFpConfig = ((int)0X101b),
        DeviceGlobalMemCacheType = ((int)0X101c),
        DeviceGlobalMemCachelineSize = ((int)0X101d),
        DeviceGlobalMemCacheSize = ((int)0X101e),
        DeviceGlobalMemSize = ((int)0X101f),
        DeviceMaxConstantBufferSize = ((int)0X1020),
        DeviceMaxConstantArgs = ((int)0X1021),
        DeviceLocalMemType = ((int)0X1022),
        DeviceLocalMemSize = ((int)0X1023),
        DeviceErrorCorrectionSupport = ((int)0X1024),
        DeviceProfilingTimerResolution = ((int)0X1025),
        DeviceEndianLittle = ((int)0X1026),
        DeviceAvailable = ((int)0X1027),
        DeviceCompilerAvailable = ((int)0X1028),
        DeviceExecutionCapabilities = ((int)0X1029),
        DeviceQueueProperties = ((int)0X102a),
        DeviceName = ((int)0X102b),
        DeviceVendor = ((int)0X102c),
        DriverVersion = ((int)0X102d),
        DeviceProfile = ((int)0X102e),
        DeviceVersion = ((int)0X102f),
        DeviceExtensions = ((int)0X1030),
        DevicePlatform = ((int)0X1031),
        ContextReferenceCount = ((int)0X1080),
        ContextDevices = ((int)0X1081),
        ContextProperties = ((int)0X1082),
        ContextPlatform = ((int)0X1084),
        QueueContext = ((int)0X1090),
        QueueDevice = ((int)0X1091),
        QueueReferenceCount = ((int)0X1092),
        QueueProperties = ((int)0X1093),
        R = ((int)0X10b0),
        A = ((int)0X10b1),
        Rg = ((int)0X10b2),
        Ra = ((int)0X10b3),
        Rgb = ((int)0X10b4),
        Rgba = ((int)0X10b5),
        Bgra = ((int)0X10b6),
        Argb = ((int)0X10b7),
        Intensity = ((int)0X10b8),
        Luminance = ((int)0X10b9),
        SnormInt8 = ((int)0X10d0),
        SnormInt16 = ((int)0X10d1),
        UnormInt8 = ((int)0X10d2),
        UnormInt16 = ((int)0X10d3),
        UnormShort565 = ((int)0X10d4),
        UnormShort555 = ((int)0X10d5),
        UnormInt101010 = ((int)0X10d6),
        SignedInt8 = ((int)0X10d7),
        SignedInt16 = ((int)0X10d8),
        SignedInt32 = ((int)0X10d9),
        UnsignedInt8 = ((int)0X10da),
        UnsignedInt16 = ((int)0X10db),
        UnsignedInt32 = ((int)0X10dc),
        HalfFloat = ((int)0X10dd),
        Float = ((int)0X10de),
        MemObjectBuffer = ((int)0X10f0),
        MemObjectImage2d = ((int)0X10f1),
        MemObjectImage3d = ((int)0X10f2),
        MemType = ((int)0X1100),
        MemFlags = ((int)0X1101),
        MemSize = ((int)0X1102),
        MemHostPtr = ((int)0X1103),
        MemMapCount = ((int)0X1104),
        MemReferenceCount = ((int)0X1105),
        MemContext = ((int)0X1106),
        ImageFormat = ((int)0X1110),
        ImageElementSize = ((int)0X1111),
        ImageRowPitch = ((int)0X1112),
        ImageSlicePitch = ((int)0X1113),
        ImageWidth = ((int)0X1114),
        ImageHeight = ((int)0X1115),
        ImageDepth = ((int)0X1116),
        AddressNone = ((int)0X1130),
        AddressClampToEdge = ((int)0X1131),
        AddressClamp = ((int)0X1132),
        AddressRepeat = ((int)0X1133),
        FilterNearest = ((int)0X1140),
        FilterLinear = ((int)0X1141),
        SamplerReferenceCount = ((int)0X1150),
        SamplerContext = ((int)0X1151),
        SamplerNormalizedCoords = ((int)0X1152),
        SamplerAddressingMode = ((int)0X1153),
        SamplerFilterMode = ((int)0X1154),
        ProgramReferenceCount = ((int)0X1160),
        ProgramContext = ((int)0X1161),
        ProgramNumDevices = ((int)0X1162),
        ProgramDevices = ((int)0X1163),
        ProgramSource = ((int)0X1164),
        ProgramBinarySizes = ((int)0X1165),
        ProgramBinaries = ((int)0X1166),
        ProgramBuildStatus = ((int)0X1181),
        ProgramBuildOptions = ((int)0X1182),
        ProgramBuildLog = ((int)0X1183),
        KernelFunctionName = ((int)0X1190),
        KernelNumArgs = ((int)0X1191),
        KernelReferenceCount = ((int)0X1192),
        KernelContext = ((int)0X1193),
        KernelProgram = ((int)0X1194),
        KernelWorkGroupSize = ((int)0X11b0),
        KernelCompileWorkGroupSize = ((int)0X11b1),
        KernelLocalMemSize = ((int)0X11b2),
        EventCommandQueue = ((int)0X11d0),
        EventCommandType = ((int)0X11d1),
        EventReferenceCount = ((int)0X11d2),
        EventCommandExecutionStatus = ((int)0X11d3),
        CommandNdrangeKernel = ((int)0X11f0),
        CommandTask = ((int)0X11f1),
        CommandNativeKernel = ((int)0X11f2),
        CommandReadBuffer = ((int)0X11f3),
        CommandWriteBuffer = ((int)0X11f4),
        CommandCopyBuffer = ((int)0X11f5),
        CommandReadImage = ((int)0X11f6),
        CommandWriteImage = ((int)0X11f7),
        CommandCopyImage = ((int)0X11f8),
        CommandCopyImageToBuffer = ((int)0X11f9),
        CommandCopyBufferToImage = ((int)0X11fa),
        CommandMapBuffer = ((int)0X11fb),
        CommandMapImage = ((int)0X11fc),
        CommandUnmapMemObject = ((int)0X11fd),
        CommandMarker = ((int)0X11fe),
        CommandAcquireGlObjects = ((int)0X11ff),
        CommandReleaseGlObjects = ((int)0X1200),
        ProfilingCommandQueued = ((int)0X1280),
        ProfilingCommandSubmit = ((int)0X1281),
        ProfilingCommandStart = ((int)0X1282),
        ProfilingCommandEnd = ((int)0X1283),
        Global = ((int)0X2),
        ReadWriteCache = ((int)0X2),
        Submitted = ((int)0X2),
        Queued = ((int)0X3),
        DeviceTypeAll = unchecked((int)0Xffffffff),
        UintMax = unchecked((int)0Xffffffff),
        True = ((int)1),
        Version10 = ((int)1),
        BuildNone = ((int)-1),
        DeviceNotFound = ((int)-1),
        ImageFormatNotSupported = ((int)-10),
        DblMinExp = ((int)-1021),
        BuildProgramFailure = ((int)-11),
        MapFailure = ((int)-12),
        FltMinExp = ((int)-125),
        ScharMax = ((int)127),
        DblDig = ((int)15),
        DblRadix = ((int)2),
        FltRadix = ((int)2),
        BuildError = ((int)-2),
        DeviceNotAvailable = ((int)-2),
        IntMax = unchecked((int)2147483647),
        FltMantDig = ((int)24),
        UcharMax = ((int)255),
        BuildInProgress = ((int)-3),
        CompilerNotAvailable = ((int)-3),
        InvalidValue = ((int)-30),
        DblMin10Exp = ((int)-307),
        InvalidDeviceType = ((int)-31),
        InvalidPlatform = ((int)-32),
        ShrtMax = ((int)32767),
        InvalidDevice = ((int)-33),
        InvalidContext = ((int)-34),
        InvalidQueueProperties = ((int)-35),
        InvalidCommandQueue = ((int)-36),
        FltMin10Exp = ((int)-37),
        InvalidHostPtr = ((int)-37),
        InvalidMemObject = ((int)-38),
        InvalidImageFormatDescriptor = ((int)-39),
        MemObjectAllocationFailure = ((int)-4),
        InvalidImageSize = ((int)-40),
        InvalidSampler = ((int)-41),
        InvalidBinary = ((int)-42),
        InvalidBuildOptions = ((int)-43),
        InvalidProgram = ((int)-44),
        InvalidProgramExecutable = ((int)-45),
        InvalidKernelName = ((int)-46),
        InvalidKernelDefinition = ((int)-47),
        InvalidKernel = ((int)-48),
        InvalidArgIndex = ((int)-49),
        OutOfResources = ((int)-5),
        InvalidArgValue = ((int)-50),
        InvalidArgSize = ((int)-51),
        InvalidKernelArgs = ((int)-52),
        DblMantDig = ((int)53),
        InvalidWorkDimension = ((int)-53),
        InvalidWorkGroupSize = ((int)-54),
        InvalidWorkItemSize = ((int)-55),
        InvalidGlobalOffset = ((int)-56),
        InvalidEventWaitList = ((int)-57),
        InvalidEvent = ((int)-58),
        InvalidOperation = ((int)-59),
        FltDig = ((int)6),
        OutOfHostMemory = ((int)-6),
        InvalidGlObject = ((int)-60),
        InvalidBufferSize = ((int)-61),
        InvalidMipLevel = ((int)-62),
        UshrtMax = ((int)65535),
        ProfilingInfoNotAvailable = ((int)-7),
        CharBit = ((int)8),
        MemCopyOverlap = ((int)-8),
        ImageFormatMismatch = ((int)-9),
    }

    public enum Bool
    {
        False = ((int)0),
        True = ((int)1),
    }

    public enum BuildStatus
    {
        BuildSuccess = ((int)0),
        BuildNone = ((int)-1),
        BuildError = ((int)-2),
        BuildInProgress = ((int)-3),
    }

    public enum ChannelOrder
    {
        R = ((int)0X10b0),
        A = ((int)0X10b1),
        Rg = ((int)0X10b2),
        Ra = ((int)0X10b3),
        Rgb = ((int)0X10b4),
        Rgba = ((int)0X10b5),
        Bgra = ((int)0X10b6),
        Argb = ((int)0X10b7),
        Intensity = ((int)0X10b8),
        Luminance = ((int)0X10b9),
    }

    public enum ChannelType
    {
        SnormInt8 = ((int)0X10d0),
        SnormInt16 = ((int)0X10d1),
        UnormInt8 = ((int)0X10d2),
        UnormInt16 = ((int)0X10d3),
        UnormShort565 = ((int)0X10d4),
        UnormShort555 = ((int)0X10d5),
        UnormInt101010 = ((int)0X10d6),
        SignedInt8 = ((int)0X10d7),
        SignedInt16 = ((int)0X10d8),
        SignedInt32 = ((int)0X10d9),
        UnsignedInt8 = ((int)0X10da),
        UnsignedInt16 = ((int)0X10db),
        UnsignedInt32 = ((int)0X10dc),
        HalfFloat = ((int)0X10dd),
        Float = ((int)0X10de),
    }

    public enum CommandExecutionStatus
    {
        Complete = ((int)0X0),
        Running = ((int)0X1),
        Submitted = ((int)0X2),
        Queued = ((int)0X3),
    }

    public enum CommandQueueFlags
    {
        QueueOutOfOrderExecModeEnable = ((int)(1 << 0)),
        QueueProfilingEnable = ((int)(1 << 1)),
    }

    public enum CommandQueueInfo
    {
        QueueContext = ((int)0X1090),
        QueueDevice = ((int)0X1091),
        QueueReferenceCount = ((int)0X1092),
        QueueProperties = ((int)0X1093),
    }

    public enum CommandType
    {
        CommandNdrangeKernel = ((int)0X11f0),
        CommandTask = ((int)0X11f1),
        CommandNativeKernel = ((int)0X11f2),
        CommandReadBuffer = ((int)0X11f3),
        CommandWriteBuffer = ((int)0X11f4),
        CommandCopyBuffer = ((int)0X11f5),
        CommandReadImage = ((int)0X11f6),
        CommandWriteImage = ((int)0X11f7),
        CommandCopyImage = ((int)0X11f8),
        CommandCopyImageToBuffer = ((int)0X11f9),
        CommandCopyBufferToImage = ((int)0X11fa),
        CommandMapBuffer = ((int)0X11fb),
        CommandMapImage = ((int)0X11fc),
        CommandUnmapMemObject = ((int)0X11fd),
        CommandMarker = ((int)0X11fe),
        CommandAcquireGlObjects = ((int)0X11ff),
        CommandReleaseGlObjects = ((int)0X1200),
    }

    public enum ContextInfo
    {
        ContextReferenceCount = ((int)0X1080),
        ContextDevices = ((int)0X1081),
        ContextProperties = ((int)0X1082),
    }

    public enum ContextProperties
    {
        ContextPlatform = ((int)0X1084),
    }

    public enum DeviceExecCapabilitiesFlags
    {
        ExecKernel = ((int)(1 << 0)),
        ExecNativeKernel = ((int)(1 << 1)),
    }

    public enum DeviceFpConfigFlags
    {
        FpDenorm = ((int)(1 << 0)),
        FpInfNan = ((int)(1 << 1)),
        FpRoundToNearest = ((int)(1 << 2)),
        FpRoundToZero = ((int)(1 << 3)),
        FpRoundToInf = ((int)(1 << 4)),
        FpFma = ((int)(1 << 5)),
    }

    public enum DeviceInfo
    {
        DeviceType = ((int)0X1000),
        DeviceVendorId = ((int)0X1001),
        DeviceMaxComputeUnits = ((int)0X1002),
        DeviceMaxWorkItemDimensions = ((int)0X1003),
        DeviceMaxWorkGroupSize = ((int)0X1004),
        DeviceMaxWorkItemSizes = ((int)0X1005),
        DevicePreferredVectorWidthChar = ((int)0X1006),
        DevicePreferredVectorWidthShort = ((int)0X1007),
        DevicePreferredVectorWidthInt = ((int)0X1008),
        DevicePreferredVectorWidthLong = ((int)0X1009),
        DevicePreferredVectorWidthFloat = ((int)0X100a),
        DevicePreferredVectorWidthDouble = ((int)0X100b),
        DeviceMaxClockFrequency = ((int)0X100c),
        DeviceAddressBits = ((int)0X100d),
        DeviceMaxReadImageArgs = ((int)0X100e),
        DeviceMaxWriteImageArgs = ((int)0X100f),
        DeviceMaxMemAllocSize = ((int)0X1010),
        DeviceImage2dMaxWidth = ((int)0X1011),
        DeviceImage2dMaxHeight = ((int)0X1012),
        DeviceImage3dMaxWidth = ((int)0X1013),
        DeviceImage3dMaxHeight = ((int)0X1014),
        DeviceImage3dMaxDepth = ((int)0X1015),
        DeviceImageSupport = ((int)0X1016),
        DeviceMaxParameterSize = ((int)0X1017),
        DeviceMaxSamplers = ((int)0X1018),
        DeviceMemBaseAddrAlign = ((int)0X1019),
        DeviceMinDataTypeAlignSize = ((int)0X101a),
        DeviceSingleFpConfig = ((int)0X101b),
        DeviceGlobalMemCacheType = ((int)0X101c),
        DeviceGlobalMemCachelineSize = ((int)0X101d),
        DeviceGlobalMemCacheSize = ((int)0X101e),
        DeviceGlobalMemSize = ((int)0X101f),
        DeviceMaxConstantBufferSize = ((int)0X1020),
        DeviceMaxConstantArgs = ((int)0X1021),
        DeviceLocalMemType = ((int)0X1022),
        DeviceLocalMemSize = ((int)0X1023),
        DeviceErrorCorrectionSupport = ((int)0X1024),
        DeviceProfilingTimerResolution = ((int)0X1025),
        DeviceEndianLittle = ((int)0X1026),
        DeviceAvailable = ((int)0X1027),
        DeviceCompilerAvailable = ((int)0X1028),
        DeviceExecutionCapabilities = ((int)0X1029),
        DeviceQueueProperties = ((int)0X102a),
        DeviceName = ((int)0X102b),
        DeviceVendor = ((int)0X102c),
        DriverVersion = ((int)0X102d),
        DeviceProfile = ((int)0X102e),
        DeviceVersion = ((int)0X102f),
        DeviceExtensions = ((int)0X1030),
        DevicePlatform = ((int)0X1031),
    }

    public enum DeviceLocalMemType
    {
        Local = ((int)0X1),
        Global = ((int)0X2),
    }

    public enum DeviceMemCacheType
    {
        None = ((int)0X0),
        ReadOnlyCache = ((int)0X1),
        ReadWriteCache = ((int)0X2),
    }

    public enum DeviceTypeFlags
    {
        DeviceTypeDefault = ((int)(1 << 0)),
        DeviceTypeCpu = ((int)(1 << 1)),
        DeviceTypeGpu = ((int)(1 << 2)),
        DeviceTypeAccelerator = ((int)(1 << 3)),
        DeviceTypeAll = unchecked((int)0Xffffffff),
    }

    public enum ErrorCode
    {
        Success = ((int)0),
        DeviceNotFound = ((int)-1),
        ImageFormatNotSupported = ((int)-10),
        BuildProgramFailure = ((int)-11),
        MapFailure = ((int)-12),
        DeviceNotAvailable = ((int)-2),
        CompilerNotAvailable = ((int)-3),
        InvalidValue = ((int)-30),
        InvalidDeviceType = ((int)-31),
        InvalidPlatform = ((int)-32),
        InvalidDevice = ((int)-33),
        InvalidContext = ((int)-34),
        InvalidQueueProperties = ((int)-35),
        InvalidCommandQueue = ((int)-36),
        InvalidHostPtr = ((int)-37),
        InvalidMemObject = ((int)-38),
        InvalidImageFormatDescriptor = ((int)-39),
        MemObjectAllocationFailure = ((int)-4),
        InvalidImageSize = ((int)-40),
        InvalidSampler = ((int)-41),
        InvalidBinary = ((int)-42),
        InvalidBuildOptions = ((int)-43),
        InvalidProgram = ((int)-44),
        InvalidProgramExecutable = ((int)-45),
        InvalidKernelName = ((int)-46),
        InvalidKernelDefinition = ((int)-47),
        InvalidKernel = ((int)-48),
        InvalidArgIndex = ((int)-49),
        OutOfResources = ((int)-5),
        InvalidArgValue = ((int)-50),
        InvalidArgSize = ((int)-51),
        InvalidKernelArgs = ((int)-52),
        InvalidWorkDimension = ((int)-53),
        InvalidWorkGroupSize = ((int)-54),
        InvalidWorkItemSize = ((int)-55),
        InvalidGlobalOffset = ((int)-56),
        InvalidEventWaitList = ((int)-57),
        InvalidEvent = ((int)-58),
        InvalidOperation = ((int)-59),
        OutOfHostMemory = ((int)-6),
        InvalidGlObject = ((int)-60),
        InvalidBufferSize = ((int)-61),
        InvalidMipLevel = ((int)-62),
        ProfilingInfoNotAvailable = ((int)-7),
        MemCopyOverlap = ((int)-8),
        ImageFormatMismatch = ((int)-9),
    }

    public enum EventInfo
    {
        EventCommandQueue = ((int)0X11d0),
        EventCommandType = ((int)0X11d1),
        EventReferenceCount = ((int)0X11d2),
        EventCommandExecutionStatus = ((int)0X11d3),
    }

    public enum FilterMode
    {
        FilterNearest = ((int)0X1140),
        FilterLinear = ((int)0X1141),
    }

    public enum ImageInfo
    {
        ImageFormat = ((int)0X1110),
        ImageElementSize = ((int)0X1111),
        ImageRowPitch = ((int)0X1112),
        ImageSlicePitch = ((int)0X1113),
        ImageWidth = ((int)0X1114),
        ImageHeight = ((int)0X1115),
        ImageDepth = ((int)0X1116),
    }

    public enum KernelInfo
    {
        KernelFunctionName = ((int)0X1190),
        KernelNumArgs = ((int)0X1191),
        KernelReferenceCount = ((int)0X1192),
        KernelContext = ((int)0X1193),
        KernelProgram = ((int)0X1194),
    }

    public enum KernelWorkGroupInfo
    {
        KernelWorkGroupSize = ((int)0X11b0),
        KernelCompileWorkGroupSize = ((int)0X11b1),
        KernelLocalMemSize = ((int)0X11b2),
    }

    public enum MapFlags
    {
        MapRead = ((int)(1 << 0)),
        MapWrite = ((int)(1 << 1)),
    }

    public enum MemFlags
    {
        MemReadWrite = ((int)(1 << 0)),
        MemWriteOnly = ((int)(1 << 1)),
        MemReadOnly = ((int)(1 << 2)),
        MemUseHostPtr = ((int)(1 << 3)),
        MemAllocHostPtr = ((int)(1 << 4)),
        MemCopyHostPtr = ((int)(1 << 5)),
    }

    public enum MemInfo
    {
        MemType = ((int)0X1100),
        MemFlags = ((int)0X1101),
        MemSize = ((int)0X1102),
        MemHostPtr = ((int)0X1103),
        MemMapCount = ((int)0X1104),
        MemReferenceCount = ((int)0X1105),
        MemContext = ((int)0X1106),
    }

    public enum MemObjectType
    {
        MemObjectBuffer = ((int)0X10f0),
        MemObjectImage2d = ((int)0X10f1),
        MemObjectImage3d = ((int)0X10f2),
    }

    public enum PlatformInfo
    {
        PlatformProfile = ((int)0X0900),
        PlatformVersion = ((int)0X0901),
        PlatformName = ((int)0X0902),
        PlatformVendor = ((int)0X0903),
        PlatformExtensions = ((int)0X0904),
    }

    public enum ProfilingInfo
    {
        ProfilingCommandQueued = ((int)0X1280),
        ProfilingCommandSubmit = ((int)0X1281),
        ProfilingCommandStart = ((int)0X1282),
        ProfilingCommandEnd = ((int)0X1283),
    }

    public enum ProgramBuildInfo
    {
        ProgramBuildStatus = ((int)0X1181),
        ProgramBuildOptions = ((int)0X1182),
        ProgramBuildLog = ((int)0X1183),
    }

    public enum ProgramInfo
    {
        ProgramReferenceCount = ((int)0X1160),
        ProgramContext = ((int)0X1161),
        ProgramNumDevices = ((int)0X1162),
        ProgramDevices = ((int)0X1163),
        ProgramSource = ((int)0X1164),
        ProgramBinarySizes = ((int)0X1165),
        ProgramBinaries = ((int)0X1166),
    }

    public enum SamplerInfo
    {
        SamplerReferenceCount = ((int)0X1150),
        SamplerContext = ((int)0X1151),
        SamplerNormalizedCoords = ((int)0X1152),
        SamplerAddressingMode = ((int)0X1153),
        SamplerFilterMode = ((int)0X1154),
    }

    public enum Unknown
    {
        ScharMin = ((int)(-127-1)),
        IntMin = ((int)(-2147483647-1)),
        ShrtMin = ((int)(-32767-1)),
        UintMax = unchecked((int)0Xffffffff),
        DblMinExp = ((int)-1021),
        FltMinExp = ((int)-125),
        ScharMax = ((int)127),
        DblDig = ((int)15),
        DblRadix = ((int)2),
        FltRadix = ((int)2),
        IntMax = unchecked((int)2147483647),
        FltMantDig = ((int)24),
        UcharMax = ((int)255),
        DblMin10Exp = ((int)-307),
        ShrtMax = ((int)32767),
        FltMin10Exp = ((int)-37),
        DblMantDig = ((int)53),
        FltDig = ((int)6),
        UshrtMax = ((int)65535),
        CharBit = ((int)8),
    }

    public enum Version
    {
        Version10 = ((int)1),
    }

}
