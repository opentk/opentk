using System;
using System.Runtime.InteropServices;

namespace OpenTK.Compute.OpenCL
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CLBufferRegion
    {
        public readonly ulong Origin;
        public readonly ulong Size;

        public CLBufferRegion(ulong origin, ulong size)
        {
            this.Origin = origin;
            this.Size = size;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CLImageFormat
	{
		public ChannelOrder ChannelOrder;
		public ChannelType ChannelType;

        public CLImageFormat(ChannelOrder channelOrder, ChannelType channelType)
        {
            ChannelOrder = channelOrder;
            ChannelType = channelType;
        }
	}

    [StructLayout(LayoutKind.Sequential)]
    public struct CLImageDescription
	{
		public MemoryObjectType ImageType;
		public ulong Width;
		public ulong Height;
		public ulong Depth;
		public ulong ArraySize;
		public ulong RowPitch;
		public ulong SlicePitch;
		public uint MipLevels;
		public uint Samples;
		public CLBuffer Buffer;

        public static CLImageDescription Create1D(ulong width, ulong rowPitch = 0)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image1D,
                Width = width,
                Height = 1,
                Depth = 1,
                RowPitch = rowPitch
            };
        }

        public static CLImageDescription Create1DBuffer(ulong width, ulong rowPitch = 0)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image1DBuffer,
                Width = width,
                Height = 1,
                Depth = 1,
                RowPitch = rowPitch
            };
        }

        public static CLImageDescription Create1DArray(ulong width, ulong arraySize, ulong rowPitch = 0)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image1DArray,
                Width = width,
                Height = 1,
                Depth = 1,
                ArraySize = arraySize,
                RowPitch = rowPitch
            };
        }

        public static CLImageDescription Create2D(ulong width, ulong height, ulong rowPitch = 0, ulong slicePitch = 0)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image2D,
                Width = width,
                Height = height,
                Depth = 1,
                RowPitch = rowPitch,
                SlicePitch = slicePitch
            };
        }

        public static CLImageDescription Create2DArray(ulong width, ulong height, ulong arraySize, ulong rowPitch = 0, ulong slicePitch = 0)
        {
            return new CLImageDescription()
            {
                ImageType = MemoryObjectType.Image2DArray,
                Width = width,
                Height = height,
                Depth = 1,
                ArraySize = arraySize,
                RowPitch = rowPitch,
                SlicePitch = slicePitch
            };
        }

        public static CLImageDescription Create3D(ulong width, ulong height, ulong depth, ulong rowPitch = 0, ulong slicePitch = 0)
		{
			return new CLImageDescription()
			{
				ImageType = MemoryObjectType.Image3D,
				Width = width,
				Height = height,
				Depth = depth,
				RowPitch = rowPitch,
				SlicePitch = slicePitch
			};
		}
	}
}
