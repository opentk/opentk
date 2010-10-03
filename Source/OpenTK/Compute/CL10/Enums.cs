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

#if EXPERIMENTAL

using System;

namespace OpenTK.Compute.CL10
{
    #pragma warning disable 1591

    public enum AddressingMode : int
    {
        AddressNone = ((int)0x1130),
        AddressClampToEdge = ((int)0x1131),
        AddressClamp = ((int)0x1132),
        AddressRepeat = ((int)0x1133),
    }

    public enum All : int
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
        Complete = ((int)0x0),
        None = ((int)0x0),
        PlatformProfile = ((int)0x0900),
        PlatformVersion = ((int)0x0901),
        PlatformName = ((int)0x0902),
        PlatformVendor = ((int)0x0903),
        PlatformExtensions = ((int)0x0904),
        Local = ((int)0x1),
        ReadOnlyCache = ((int)0x1),
        Running = ((int)0x1),
        DeviceType = ((int)0x1000),
        DeviceVendorId = ((int)0x1001),
        DeviceMaxComputeUnits = ((int)0x1002),
        DeviceMaxWorkItemDimensions = ((int)0x1003),
        DeviceMaxWorkGroupSize = ((int)0x1004),
        DeviceMaxWorkItemSizes = ((int)0x1005),
        DevicePreferredVectorWidthChar = ((int)0x1006),
        DevicePreferredVectorWidthShort = ((int)0x1007),
        DevicePreferredVectorWidthInt = ((int)0x1008),
        DevicePreferredVectorWidthLong = ((int)0x1009),
        DevicePreferredVectorWidthFloat = ((int)0x100A),
        DevicePreferredVectorWidthDouble = ((int)0x100B),
        DeviceMaxClockFrequency = ((int)0x100C),
        DeviceAddressBits = ((int)0x100D),
        DeviceMaxReadImageArgs = ((int)0x100E),
        DeviceMaxWriteImageArgs = ((int)0x100F),
        DeviceMaxMemAllocSize = ((int)0x1010),
        DeviceImage2dMaxWidth = ((int)0x1011),
        DeviceImage2dMaxHeight = ((int)0x1012),
        DeviceImage3dMaxWidth = ((int)0x1013),
        DeviceImage3dMaxHeight = ((int)0x1014),
        DeviceImage3dMaxDepth = ((int)0x1015),
        DeviceImageSupport = ((int)0x1016),
        DeviceMaxParameterSize = ((int)0x1017),
        DeviceMaxSamplers = ((int)0x1018),
        DeviceMemBaseAddrAlign = ((int)0x1019),
        DeviceMinDataTypeAlignSize = ((int)0x101A),
        DeviceSingleFpConfig = ((int)0x101B),
        DeviceGlobalMemCacheType = ((int)0x101C),
        DeviceGlobalMemCachelineSize = ((int)0x101D),
        DeviceGlobalMemCacheSize = ((int)0x101E),
        DeviceGlobalMemSize = ((int)0x101F),
        DeviceMaxConstantBufferSize = ((int)0x1020),
        DeviceMaxConstantArgs = ((int)0x1021),
        DeviceLocalMemType = ((int)0x1022),
        DeviceLocalMemSize = ((int)0x1023),
        DeviceErrorCorrectionSupport = ((int)0x1024),
        DeviceProfilingTimerResolution = ((int)0x1025),
        DeviceEndianLittle = ((int)0x1026),
        DeviceAvailable = ((int)0x1027),
        DeviceCompilerAvailable = ((int)0x1028),
        DeviceExecutionCapabilities = ((int)0x1029),
        DeviceQueueProperties = ((int)0x102A),
        DeviceName = ((int)0x102B),
        DeviceVendor = ((int)0x102C),
        DriverVersion = ((int)0x102D),
        DeviceProfile = ((int)0x102E),
        DeviceVersion = ((int)0x102F),
        DeviceExtensions = ((int)0x1030),
        DevicePlatform = ((int)0x1031),
        ContextReferenceCount = ((int)0x1080),
        ContextDevices = ((int)0x1081),
        ContextProperties = ((int)0x1082),
        ContextPlatform = ((int)0x1084),
        QueueContext = ((int)0x1090),
        QueueDevice = ((int)0x1091),
        QueueReferenceCount = ((int)0x1092),
        QueueProperties = ((int)0x1093),
        R = ((int)0x10B0),
        A = ((int)0x10B1),
        Rg = ((int)0x10B2),
        Ra = ((int)0x10B3),
        Rgb = ((int)0x10B4),
        Rgba = ((int)0x10B5),
        Bgra = ((int)0x10B6),
        Argb = ((int)0x10B7),
        Intensity = ((int)0x10B8),
        Luminance = ((int)0x10B9),
        SnormInt8 = ((int)0x10D0),
        SnormInt16 = ((int)0x10D1),
        UnormInt8 = ((int)0x10D2),
        UnormInt16 = ((int)0x10D3),
        UnormShort565 = ((int)0x10D4),
        UnormShort555 = ((int)0x10D5),
        UnormInt101010 = ((int)0x10D6),
        SignedInt8 = ((int)0x10D7),
        SignedInt16 = ((int)0x10D8),
        SignedInt32 = ((int)0x10D9),
        UnsignedInt8 = ((int)0x10DA),
        UnsignedInt16 = ((int)0x10DB),
        UnsignedInt32 = ((int)0x10DC),
        HalfFloat = ((int)0x10DD),
        Float = ((int)0x10DE),
        MemObjectBuffer = ((int)0x10F0),
        MemObjectImage2d = ((int)0x10F1),
        MemObjectImage3d = ((int)0x10F2),
        MemType = ((int)0x1100),
        MemFlags = ((int)0x1101),
        MemSize = ((int)0x1102),
        MemHostPtr = ((int)0x1103),
        MemMapCount = ((int)0x1104),
        MemReferenceCount = ((int)0x1105),
        MemContext = ((int)0x1106),
        ImageFormat = ((int)0x1110),
        ImageElementSize = ((int)0x1111),
        ImageRowPitch = ((int)0x1112),
        ImageSlicePitch = ((int)0x1113),
        ImageWidth = ((int)0x1114),
        ImageHeight = ((int)0x1115),
        ImageDepth = ((int)0x1116),
        AddressNone = ((int)0x1130),
        AddressClampToEdge = ((int)0x1131),
        AddressClamp = ((int)0x1132),
        AddressRepeat = ((int)0x1133),
        FilterNearest = ((int)0x1140),
        FilterLinear = ((int)0x1141),
        SamplerReferenceCount = ((int)0x1150),
        SamplerContext = ((int)0x1151),
        SamplerNormalizedCoords = ((int)0x1152),
        SamplerAddressingMode = ((int)0x1153),
        SamplerFilterMode = ((int)0x1154),
        ProgramReferenceCount = ((int)0x1160),
        ProgramContext = ((int)0x1161),
        ProgramNumDevices = ((int)0x1162),
        ProgramDevices = ((int)0x1163),
        ProgramSource = ((int)0x1164),
        ProgramBinarySizes = ((int)0x1165),
        ProgramBinaries = ((int)0x1166),
        ProgramBuildStatus = ((int)0x1181),
        ProgramBuildOptions = ((int)0x1182),
        ProgramBuildLog = ((int)0x1183),
        KernelFunctionName = ((int)0x1190),
        KernelNumArgs = ((int)0x1191),
        KernelReferenceCount = ((int)0x1192),
        KernelContext = ((int)0x1193),
        KernelProgram = ((int)0x1194),
        KernelWorkGroupSize = ((int)0x11B0),
        KernelCompileWorkGroupSize = ((int)0x11B1),
        KernelLocalMemSize = ((int)0x11B2),
        EventCommandQueue = ((int)0x11D0),
        EventCommandType = ((int)0x11D1),
        EventReferenceCount = ((int)0x11D2),
        EventCommandExecutionStatus = ((int)0x11D3),
        CommandNdrangeKernel = ((int)0x11F0),
        CommandTask = ((int)0x11F1),
        CommandNativeKernel = ((int)0x11F2),
        CommandReadBuffer = ((int)0x11F3),
        CommandWriteBuffer = ((int)0x11F4),
        CommandCopyBuffer = ((int)0x11F5),
        CommandReadImage = ((int)0x11F6),
        CommandWriteImage = ((int)0x11F7),
        CommandCopyImage = ((int)0x11F8),
        CommandCopyImageToBuffer = ((int)0x11F9),
        CommandCopyBufferToImage = ((int)0x11FA),
        CommandMapBuffer = ((int)0x11FB),
        CommandMapImage = ((int)0x11FC),
        CommandUnmapMemObject = ((int)0x11FD),
        CommandMarker = ((int)0x11FE),
        CommandAcquireGlObjects = ((int)0x11FF),
        CommandReleaseGlObjects = ((int)0x1200),
        ProfilingCommandQueued = ((int)0x1280),
        ProfilingCommandSubmit = ((int)0x1281),
        ProfilingCommandStart = ((int)0x1282),
        ProfilingCommandEnd = ((int)0x1283),
        Global = ((int)0x2),
        ReadWriteCache = ((int)0x2),
        Submitted = ((int)0x2),
        Queued = ((int)0x3),
        UintMax = unchecked((int)0xffffffff),
        DeviceTypeAll = unchecked((int)0xFFFFFFFF),
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

    public enum Bool : int
    {
        False = ((int)0),
        True = ((int)1),
    }

    public enum BuildStatus : int
    {
        BuildSuccess = ((int)0),
        BuildNone = ((int)-1),
        BuildError = ((int)-2),
        BuildInProgress = ((int)-3),
    }

    public enum ChannelOrder : int
    {
        R = ((int)0x10B0),
        A = ((int)0x10B1),
        Rg = ((int)0x10B2),
        Ra = ((int)0x10B3),
        Rgb = ((int)0x10B4),
        Rgba = ((int)0x10B5),
        Bgra = ((int)0x10B6),
        Argb = ((int)0x10B7),
        Intensity = ((int)0x10B8),
        Luminance = ((int)0x10B9),
    }

    public enum ChannelType : int
    {
        SnormInt8 = ((int)0x10D0),
        SnormInt16 = ((int)0x10D1),
        UnormInt8 = ((int)0x10D2),
        UnormInt16 = ((int)0x10D3),
        UnormShort565 = ((int)0x10D4),
        UnormShort555 = ((int)0x10D5),
        UnormInt101010 = ((int)0x10D6),
        SignedInt8 = ((int)0x10D7),
        SignedInt16 = ((int)0x10D8),
        SignedInt32 = ((int)0x10D9),
        UnsignedInt8 = ((int)0x10DA),
        UnsignedInt16 = ((int)0x10DB),
        UnsignedInt32 = ((int)0x10DC),
        HalfFloat = ((int)0x10DD),
        Float = ((int)0x10DE),
    }

    public enum CommandExecutionStatus : int
    {
        Complete = ((int)0x0),
        Running = ((int)0x1),
        Submitted = ((int)0x2),
        Queued = ((int)0x3),
    }

    public enum CommandQueueFlags : long
    {
        QueueOutOfOrderExecModeEnable = ((int)(1 << 0)),
        QueueProfilingEnable = ((int)(1 << 1)),
    }

    public enum CommandQueueInfo : int
    {
        QueueContext = ((int)0x1090),
        QueueDevice = ((int)0x1091),
        QueueReferenceCount = ((int)0x1092),
        QueueProperties = ((int)0x1093),
    }

    public enum CommandType : int
    {
        CommandNdrangeKernel = ((int)0x11F0),
        CommandTask = ((int)0x11F1),
        CommandNativeKernel = ((int)0x11F2),
        CommandReadBuffer = ((int)0x11F3),
        CommandWriteBuffer = ((int)0x11F4),
        CommandCopyBuffer = ((int)0x11F5),
        CommandReadImage = ((int)0x11F6),
        CommandWriteImage = ((int)0x11F7),
        CommandCopyImage = ((int)0x11F8),
        CommandCopyImageToBuffer = ((int)0x11F9),
        CommandCopyBufferToImage = ((int)0x11FA),
        CommandMapBuffer = ((int)0x11FB),
        CommandMapImage = ((int)0x11FC),
        CommandUnmapMemObject = ((int)0x11FD),
        CommandMarker = ((int)0x11FE),
        CommandAcquireGlObjects = ((int)0x11FF),
        CommandReleaseGlObjects = ((int)0x1200),
    }

    public enum ContextInfo : int
    {
        ContextReferenceCount = ((int)0x1080),
        ContextDevices = ((int)0x1081),
        ContextProperties = ((int)0x1082),
    }

    public enum ContextProperties : int
    {
        ContextPlatform = ((int)0x1084),
    }

    public enum DeviceExecCapabilitiesFlags : long
    {
        ExecKernel = ((int)(1 << 0)),
        ExecNativeKernel = ((int)(1 << 1)),
    }

    public enum DeviceFpConfigFlags : long
    {
        FpDenorm = ((int)(1 << 0)),
        FpInfNan = ((int)(1 << 1)),
        FpRoundToNearest = ((int)(1 << 2)),
        FpRoundToZero = ((int)(1 << 3)),
        FpRoundToInf = ((int)(1 << 4)),
        FpFma = ((int)(1 << 5)),
    }

    public enum DeviceInfo : int
    {
        DeviceType = ((int)0x1000),
        DeviceVendorId = ((int)0x1001),
        DeviceMaxComputeUnits = ((int)0x1002),
        DeviceMaxWorkItemDimensions = ((int)0x1003),
        DeviceMaxWorkGroupSize = ((int)0x1004),
        DeviceMaxWorkItemSizes = ((int)0x1005),
        DevicePreferredVectorWidthChar = ((int)0x1006),
        DevicePreferredVectorWidthShort = ((int)0x1007),
        DevicePreferredVectorWidthInt = ((int)0x1008),
        DevicePreferredVectorWidthLong = ((int)0x1009),
        DevicePreferredVectorWidthFloat = ((int)0x100A),
        DevicePreferredVectorWidthDouble = ((int)0x100B),
        DeviceMaxClockFrequency = ((int)0x100C),
        DeviceAddressBits = ((int)0x100D),
        DeviceMaxReadImageArgs = ((int)0x100E),
        DeviceMaxWriteImageArgs = ((int)0x100F),
        DeviceMaxMemAllocSize = ((int)0x1010),
        DeviceImage2dMaxWidth = ((int)0x1011),
        DeviceImage2dMaxHeight = ((int)0x1012),
        DeviceImage3dMaxWidth = ((int)0x1013),
        DeviceImage3dMaxHeight = ((int)0x1014),
        DeviceImage3dMaxDepth = ((int)0x1015),
        DeviceImageSupport = ((int)0x1016),
        DeviceMaxParameterSize = ((int)0x1017),
        DeviceMaxSamplers = ((int)0x1018),
        DeviceMemBaseAddrAlign = ((int)0x1019),
        DeviceMinDataTypeAlignSize = ((int)0x101A),
        DeviceSingleFpConfig = ((int)0x101B),
        DeviceGlobalMemCacheType = ((int)0x101C),
        DeviceGlobalMemCachelineSize = ((int)0x101D),
        DeviceGlobalMemCacheSize = ((int)0x101E),
        DeviceGlobalMemSize = ((int)0x101F),
        DeviceMaxConstantBufferSize = ((int)0x1020),
        DeviceMaxConstantArgs = ((int)0x1021),
        DeviceLocalMemType = ((int)0x1022),
        DeviceLocalMemSize = ((int)0x1023),
        DeviceErrorCorrectionSupport = ((int)0x1024),
        DeviceProfilingTimerResolution = ((int)0x1025),
        DeviceEndianLittle = ((int)0x1026),
        DeviceAvailable = ((int)0x1027),
        DeviceCompilerAvailable = ((int)0x1028),
        DeviceExecutionCapabilities = ((int)0x1029),
        DeviceQueueProperties = ((int)0x102A),
        DeviceName = ((int)0x102B),
        DeviceVendor = ((int)0x102C),
        DriverVersion = ((int)0x102D),
        DeviceProfile = ((int)0x102E),
        DeviceVersion = ((int)0x102F),
        DeviceExtensions = ((int)0x1030),
        DevicePlatform = ((int)0x1031),
    }

    public enum DeviceLocalMemType : int
    {
        Local = ((int)0x1),
        Global = ((int)0x2),
    }

    public enum DeviceMemCacheType : int
    {
        None = ((int)0x0),
        ReadOnlyCache = ((int)0x1),
        ReadWriteCache = ((int)0x2),
    }

    public enum DeviceTypeFlags : long
    {
        DeviceTypeDefault = ((int)(1 << 0)),
        DeviceTypeCpu = ((int)(1 << 1)),
        DeviceTypeGpu = ((int)(1 << 2)),
        DeviceTypeAccelerator = ((int)(1 << 3)),
        DeviceTypeAll = unchecked((int)0xFFFFFFFF),
    }

    public enum ErrorCode : int
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

    public enum EventInfo : int
    {
        EventCommandQueue = ((int)0x11D0),
        EventCommandType = ((int)0x11D1),
        EventReferenceCount = ((int)0x11D2),
        EventCommandExecutionStatus = ((int)0x11D3),
    }

    public enum FilterMode : int
    {
        FilterNearest = ((int)0x1140),
        FilterLinear = ((int)0x1141),
    }

    public enum ImageInfo : int
    {
        ImageFormat = ((int)0x1110),
        ImageElementSize = ((int)0x1111),
        ImageRowPitch = ((int)0x1112),
        ImageSlicePitch = ((int)0x1113),
        ImageWidth = ((int)0x1114),
        ImageHeight = ((int)0x1115),
        ImageDepth = ((int)0x1116),
    }

    public enum KernelInfo : int
    {
        KernelFunctionName = ((int)0x1190),
        KernelNumArgs = ((int)0x1191),
        KernelReferenceCount = ((int)0x1192),
        KernelContext = ((int)0x1193),
        KernelProgram = ((int)0x1194),
    }

    public enum KernelWorkGroupInfo : int
    {
        KernelWorkGroupSize = ((int)0x11B0),
        KernelCompileWorkGroupSize = ((int)0x11B1),
        KernelLocalMemSize = ((int)0x11B2),
    }

    public enum MapFlags : long
    {
        MapRead = ((int)(1 << 0)),
        MapWrite = ((int)(1 << 1)),
    }

    public enum MemFlags : long
    {
        MemReadWrite = ((int)(1 << 0)),
        MemWriteOnly = ((int)(1 << 1)),
        MemReadOnly = ((int)(1 << 2)),
        MemUseHostPtr = ((int)(1 << 3)),
        MemAllocHostPtr = ((int)(1 << 4)),
        MemCopyHostPtr = ((int)(1 << 5)),
    }

    public enum MemInfo : int
    {
        MemType = ((int)0x1100),
        MemFlags = ((int)0x1101),
        MemSize = ((int)0x1102),
        MemHostPtr = ((int)0x1103),
        MemMapCount = ((int)0x1104),
        MemReferenceCount = ((int)0x1105),
        MemContext = ((int)0x1106),
    }

    public enum MemObjectType : int
    {
        MemObjectBuffer = ((int)0x10F0),
        MemObjectImage2d = ((int)0x10F1),
        MemObjectImage3d = ((int)0x10F2),
    }

    public enum PlatformInfo : int
    {
        PlatformProfile = ((int)0x0900),
        PlatformVersion = ((int)0x0901),
        PlatformName = ((int)0x0902),
        PlatformVendor = ((int)0x0903),
        PlatformExtensions = ((int)0x0904),
    }

    public enum ProfilingInfo : int
    {
        ProfilingCommandQueued = ((int)0x1280),
        ProfilingCommandSubmit = ((int)0x1281),
        ProfilingCommandStart = ((int)0x1282),
        ProfilingCommandEnd = ((int)0x1283),
    }

    public enum ProgramBuildInfo : int
    {
        ProgramBuildStatus = ((int)0x1181),
        ProgramBuildOptions = ((int)0x1182),
        ProgramBuildLog = ((int)0x1183),
    }

    public enum ProgramInfo : int
    {
        ProgramReferenceCount = ((int)0x1160),
        ProgramContext = ((int)0x1161),
        ProgramNumDevices = ((int)0x1162),
        ProgramDevices = ((int)0x1163),
        ProgramSource = ((int)0x1164),
        ProgramBinarySizes = ((int)0x1165),
        ProgramBinaries = ((int)0x1166),
    }

    public enum SamplerInfo : int
    {
        SamplerReferenceCount = ((int)0x1150),
        SamplerContext = ((int)0x1151),
        SamplerNormalizedCoords = ((int)0x1152),
        SamplerAddressingMode = ((int)0x1153),
        SamplerFilterMode = ((int)0x1154),
    }

    public enum Unknown : int
    {
        ScharMin = ((int)(-127-1)),
        IntMin = ((int)(-2147483647-1)),
        ShrtMin = ((int)(-32767-1)),
        UintMax = unchecked((int)0xffffffff),
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

    public enum Version : int
    {
        Version10 = ((int)1),
    }

}

#endif