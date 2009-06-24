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
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Compute
{
    public enum ErrorCode
    {
        Success = 0,
        DeviceNotFound = -1,
        DeviceNotAvailable = -2,
        DeviceCompilerNotAvailable = -3,
        MemObjectAllocationFailure = -4,
        OutOfResources = -5,
        OutOfHostMemory = -6,
        ProfilingInfoNotAvailable = -7,
        MemCopyOverlap = -8,
        ImageFormatMismatch = -9,
        ImageFormatNotSupported = -10,
        InvalidValue = -30,
        InvalidDeviceType = -31,
        InvalidDevice = -32,
        InvalidContext = -33,
        InvalidQueueProperties = -34,
        InvalidCommandQueue = -35,
        InvalidHostPtr = -36,
        InvalidMemObject = -37,
        InvalidImageFormatDescriptor = -38,
        InvalidImageSize = -39,
        InvalidSampler = -40,
        InvalidBinary = -41,
        InvalidBuildOptions = -42,
        InvalidProgram = -43,
        InvalidProgramExecutable = -44,
        InvalidKernelName = -45,
        InvalidKernel = -46,
        InvalidArgIndex = -47,
        InvalidArgValue = -48,
        InvalidArgSize = -49,
        InvalidKernelArgs = -50,
        InvalidWorkDimension = -51,
        InvalidWorkGroupSize = -52,
        InvalidWorkItemSize = -53,
        InvalidGlobalOffset = -54,
        InvalidEventWaitList = -55,
        InvalidEvent = -56,
        InvalidOperation = -57,
        InvalidGlObject = -58,
        InvalidBufferSize = -59,
    }

    public enum Version
    {
        Version10 = 1,
    }

    public enum Bool
    {
        False = 0,
        True = 1,
    }

    public enum PlatformInfo
    {
        PlatformProfile = 0x0900,
        PlatformVersion = 0x0901,
    }

    [Flags]
    public enum DeviceType
    {
        DeviceTypeDefault = (1 << 0),
        DeviceTypeCpu = (1 << 1),
        DeviceTypeGpu = (1 << 2),
        DeviceTypeAccelerator = (1 << 3),
        DeviceTypeAll = unchecked((int)0xFFFFFFFF),
    }

    public enum DeviceInfo
    {
        DeviceType = 0x1000,
        DeviceVendorId = 0x1001,
        DeviceMaxComputeUnits = 0x1002,
        DeviceMaxWorkItemDimensions = 0x1003,
        DeviceMaxWorkGroupSize = 0x1004,
        DeviceMaxWorkItemSizes = 0x1005,
        DevicePreferredVectorWidthChar = 0x1006,
        DevicePreferredVectorWidthShort = 0x1007,
        DevicePreferredVectorWidthInt = 0x1008,
        DevicePreferredVectorWidthLong = 0x1009,
        DevicePreferredVectorWidthFloat = 0x100A,
        DevicePreferredVectorWidthDouble = 0x100B,
        DeviceMaxClockFrequency = 0x100C,
        DeviceAddressBits = 0x100D,
        DeviceMaxReadImageArgs = 0x100E,
        DeviceMaxWriteImageArgs = 0x100F,
        DeviceMaxMemAllocSize = 0x1010,
        DeviceImage2dMaxWidth = 0x1011,
        DeviceImage2dMaxHeight = 0x1012,
        DeviceImage3dMaxWidth = 0x1013,
        DeviceImage3dMaxHeight = 0x1014,
        DeviceImage3dMaxDepth = 0x1015,
        DeviceImageSupport = 0x1016,
        DeviceMaxParameterSize = 0x1017,
        DeviceMaxSamplers = 0x1018,
        DeviceMemBaseAddrAlign = 0x1019,
        DeviceMaxDataTypeAlignSize = 0x101A,
        DeviceSingleFpConfig = 0x101B,
        DeviceGlobalMemCacheType = 0x101C,
        DeviceGlobalMemCachelineSize = 0x101D,
        DeviceGlobalMemCacheSize = 0x101E,
        DeviceGlobalMemSize = 0x101F,
        DeviceMaxConstantBufferSize = 0x1020,
        DeviceMaxConstantArgs = 0x1021,
        DeviceLocalMemType = 0x1022,
        DeviceLocalMemSize = 0x1023,
        DeviceErrorCorrectionSupport = 0x1024,
        DeviceProfilingTimerResolution = 0x1025,
        DeviceEndianLittle = 0x1026,
        DeviceAvailable = 0x1027,
        DeviceCompilerAvailable = 0x1028,
        DeviceExecutionCapabilities = 0x1029,
        DeviceQueueProperties = 0x102A,
        DeviceName = 0x102B,
        DeviceVendor = 0x102C,
        DriverVersion = 0x102D,
        DeviceProfile = 0x102E,
        DeviceVersion = 0x102F,
        DeviceExtensions = 0x1030,
    }

    [Flags]
    public enum DeviceAddressInfo
    {
        DeviceAddress32Bits = (1 << 0),
        DeviceAddress64Bits = (1 << 1),
    }

    [Flags]
    public enum DeviceFpConfig
    {
        FpDenorm = (1 << 0),
        FpInfNan = (1 << 1),
        FpRoundToNearest = (1 << 2),
        FpRoundToZero = (1 << 3),
        FpRoundToInf = (1 << 4),
        FpFma = (1 << 5),
    }

    public enum DeviceMemCacheType
    {
        None = 0x0,
        ReadOnlyCache = 0x1,
        ReadWriteCache = 0x2,
    }

    public enum DeviceLocalMemType
    {
        Local = 0x1,
        Global = 0x2,
    }

    [Flags]
    public enum DeviceExecCapabilities
    {
        ExecKernel = (1 << 0),
        ExecNativeFnAsKernel = (1 << 1),
    }

    [Flags]
    public enum CommandQueueProperties
    {
        QueueOutOfOrderExecModeEnable = (1 << 0),
        QueueProfilingEnable = (1 << 1),
    }

    public enum ContextInfo
    {
        ContextReferenceCount = 0x1080,
        ContextNumDevices = 0x1081,
        ContextDevices = 0x1082,
        ContextProperties = 0x1083,
    }

    public enum CommandQueueInfo
    {
        QueueContext = 0x1090,
        QueueDevice = 0x1091,
        QueueReferenceCount = 0x1092,
        QueueProperties = 0x1093,
    }

    [Flags]
    public enum MemFlags
    {
        MemReadWrite = (1 << 0),
        MemWriteOnly = (1 << 1),
        MemReadOnly = (1 << 2),
        MemUseHostPtr = (1 << 3),
        MemAllocHostPtr = (1 << 4),
        MemCopyHostPtr = (1 << 5),
    }

    public enum ChannelOrder
    {
        R = 0x10B0,
        A = 0x10B1,
        Rg = 0x10B2,
        Ra = 0x10B3,
        Rgb = 0x10B4,
        Rgba = 0x10B5,
        Bgra = 0x10B6,
        Argb = 0x10B7,
    }

    public enum ChannelType
    {
        SnormInt8 = 0x10D0,
        SnormInt16 = 0x10D1,
        UnormInt8 = 0x10D2,
        UnormInt16 = 0x10D3,
        UnormShort565 = 0x10D4,
        UnormShort555 = 0x10D5,
        UnormInt101010 = 0x10D6,
        SignedInt8 = 0x10D7,
        SignedInt16 = 0x10D8,
        SignedInt32 = 0x10D9,
        UnsignedInt8 = 0x10DA,
        UnsignedInt16 = 0x10DB,
        UnsignedInt32 = 0x10DC,
        HalfFloat = 0x10DD,
        Float = 0x10DE,
    }

    public enum MemObjectType
    {
        MemObjectBuffer = 0x10F0,
        MemObjectImage2d = 0x10F1,
        MemObjectImage3d = 0x10F2,
    }

    public enum MemInfo
    {
        MemType = 0x1100,
        MemFlags = 0x1101,
        MemSize = 0x1102,
        MemHostPtr = 0x1103,
        MemMapCount = 0x1104,
        MemReferenceCount = 0x1105,
        MemContext = 0x1106,
    }

    public enum ImageInfo
    {
        ImageFormat = 0x1110,
        ImageElementSize = 0x1111,
        ImageRowPitch = 0x1112,
        ImageSlicePitch = 0x1113,
        ImageWidth = 0x1114,
        ImageHeight = 0x1115,
        ImageDepth = 0x1116,
    }

    public enum AddressingMode
    {
        AddressNone = 0x1130,
        AddressClampToEdge = 0x1131,
        AddressClamp = 0x1132,
        AddressRepeat = 0x1133,
    }

    public enum FilterMode
    {
        FilterNearest = 0x1140,
        FilterLinear = 0x1141,
    }

    public enum SamplerInfo
    {
        SamplerReferenceCount = 0x1150,
        SamplerContext = 0x1151,
        SamplerNormalizedCoords = 0x1152,
        SamplerAddressingMode = 0x1153,
        SamplerFilterMode = 0x1154,
    }

    [Flags]
    public enum MapFlags
    {
        MapRead = (1 << 0),
        MapWrite = (1 << 1),
    }

    public enum ProgramInfo
    {
        ProgramReferenceCount = 0x1160,
        ProgramContext = 0x1161,
        ProgramNumDevices = 0x1162,
        ProgramDevices = 0x1163,
        ProgramSource = 0x1164,
        ProgramBinarySizes = 0x1165,
        ProgramBinaries = 0x1166,
    }

    public enum ProgramBuildInfo
    {
        ProgramBuildStatus = 0x1181,
        ProgramBuildOptions = 0x1182,
        ProgramBuildLog = 0x1183,
    }

    public enum BuildStatus
    {
        BuildSuccess = 0,
        BuildNone = -1,
        BuildError = -2,
        BuildInProgress = -3,
    }

    public enum KernelInfo
    {
        KernelFunctionName = 0x1190,
        KernelNumArgs = 0x1191,
        KernelReferenceCount = 0x1192,
        KernelContext = 0x1193,
        KernelProgram = 0x1194,
    }

    public enum KernelWorkGroupInfo
    {
        KernelWorkGroupSize = 0x11B0,
        KernelCompileWorkGroupSize = 0x11B1,
    }

    public enum EventInfo
    {
        EventCommandQueue = 0x11D0,
        EventCommandType = 0x11D1,
        EventReferenceCount = 0x11D2,
        EventCommandExecutionStatus = 0x11D3,
    }

    public enum CommandType
    {
        CommandNdrangeKernel = 0x11F0,
        CommandTask = 0x11F1,
        CommandNativeKernel = 0x11F2,
        CommandReadBuffer = 0x11F3,
        CommandWriteBuffer = 0x11F4,
        CommandCopyBuffer = 0x11F5,
        CommandReadImage = 0x11F6,
        CommandWriteImage = 0x11F7,
        CommandCopyImage = 0x11F8,
        CommandCopyImageToBuffer = 0x11F9,
        CommandCopyBufferToImage = 0x11FA,
        CommandMapBuffer = 0x11FB,
        CommandMapImage = 0x11FC,
        CommandUnmapMemObject = 0x11FD,
        CommandMarker = 0x11FE,
        CommandWaitForEvents = 0x11FF,
        CommandBarrier = 0x1200,
        CommandAcquireGlObjects = 0x1201,
        CommandReleaseGlObjects = 0x1202,
    }

    public enum CommandExecutionStatus
    {
        Complete = 0x0,
        Running = 0x1,
        Submitted = 0x2,
        Queued = 0x3,
    }

    public enum ProfilingInfo
    {
        ProfilingCommandQueued = 0x1280,
        ProfilingCommandSubmit = 0x1281,
        ProfilingCommandStart = 0x1282,
        ProfilingCommandEnd = 0x1283,
    }
}
