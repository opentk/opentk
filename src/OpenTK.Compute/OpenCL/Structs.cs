using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace OpenTK.Compute.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public struct CLImageFormat
    {
        public ChannelOrder ChannelOrder;
        public ChannelType ChannelType;
    }

    public struct CLImageDescription
    {
        public MemoryObjectType ImageType;
        public UIntPtr Width;
        public UIntPtr Height;
        public UIntPtr Depth;
        public UIntPtr ArraySize;
        public UIntPtr RowPitch;
        public UIntPtr SlicePitch;
        public uint MipLevels;
        public uint Samples;
        public IntPtr MemoryObject;

        public static CLImageDescription Create2D(uint width, uint height)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image2D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)1,
            };
        }

        public static CLImageDescription Create2D(uint width, uint height, uint rowPitch)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image2D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)1,
                RowPitch = (UIntPtr)rowPitch
            };
        }

        public static CLImageDescription Create3D(uint width, uint height, uint depth)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image3D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)depth,
            };
        }

        public static CLImageDescription Create3D(uint width, uint height, uint depth, uint rowPitch, uint slicePitch)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image3D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)depth,
                RowPitch = (UIntPtr)rowPitch,
                SlicePitch = (UIntPtr)slicePitch
            };
        }
    }

    public struct CLVersion
    {
        public uint Version
        {
            get => Version;
            set => Version = value;
        }

        public int Major
        {
            get => (int)(Version >> (CL.CLVersionMinorBits + CL.CLVersionPatchBits));
        }

        public int Minor
        {
            get => (int)((Version >> CL.CLVersionPatchBits) & CL.CLVersionMinorMask);
        }

        public int Patch
        {
            get => (int)(Version & CL.CLVersionPatchMask);
        }

        public CLVersion(int major, int minor, int patch)
        {
            Version = (uint)(((major & CL.CLVersionMajorMask) << (CL.CLVersionMinorBits + CL.CLVersionPatchBits)) |
            ((minor & CL.CLVersionMinorMask) << CL.CLVersionPatchBits) |
            (patch & CL.CLVersionPatchMask));
        }

        public CLVersion(uint version) => Version = version;

        public override string ToString() => $"{Major}.{Minor}.{Patch}";

        public static implicit operator uint(CLVersion v) => v.Version;

        public static implicit operator CLVersion(uint v) => new CLVersion(v);

        public static explicit operator CLVersion(byte[] v) => new CLVersion(BitConverter.ToUInt32(v, 0));
    }

    public struct CLNameVersion
    {
        public Version Version;
        public string Name;
    }

    public struct CLBufferRegion
    {
        public UIntPtr Origin;
        public UIntPtr Size;
    }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
}
