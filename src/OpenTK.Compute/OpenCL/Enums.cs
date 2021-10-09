using System;

namespace OpenTK.Compute.OpenCL
{

    [Flags]
    public enum MemoryFlags : ulong
    {
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

        CL_MEM_RESERVED0_ARM = 1 << 32,
        CL_MEM_RESERVED1_ARM = 1 << 33,
        CL_MEM_RESERVED2_ARM = 1 << 34,
        CL_MEM_RESERVED3_ARM = 1 << 35,
        CL_MEM_RESERVED4_ARM = 1 << 36,
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
        Read = 1 << 0,
        Write = 1 << 1,
        WriteInvalidateRegion = 1 << 2
    }

    [Flags]
    public enum MemoryMigrationFlags : ulong
    {
        Host = 1 << 0,
        ContentUndefined = 1 << 1
    }
}
