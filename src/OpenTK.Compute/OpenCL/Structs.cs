using System;

namespace OpenTK.Compute.OpenCL
{
    public struct ImageFormat
    {
        public ChannelOrder ChannelOrder;
        public ChannelType ChannelType;
    }

    public struct ImageDescription
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
        public IntPtr Buffer;
    }
}
