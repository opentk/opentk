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

		public static ImageDescription Create2D(uint width, uint height)
		{
			return new ImageDescription()
			{
				ImageType = MemoryObjectType.Image2D,
				Width = (UIntPtr)width,
				Height = (UIntPtr)height,
				Depth = (UIntPtr)1,
			};
		}

		public static ImageDescription Create2D(uint width, uint height, uint rowPitch)
		{
			return new ImageDescription()
			{
				ImageType = MemoryObjectType.Image2D,
				Width = (UIntPtr)width,
				Height = (UIntPtr)height,
				Depth = (UIntPtr)1,
				RowPitch = (UIntPtr)rowPitch
			};
		}

		public static ImageDescription Create3D(uint width, uint height, uint depth)
		{
			return new ImageDescription()
			{
				ImageType = MemoryObjectType.Image3D,
				Width = (UIntPtr)width,
				Height = (UIntPtr)height,
				Depth = (UIntPtr)depth,
			};
		}

		public static ImageDescription Create3D(uint width, uint height, uint depth, uint rowPitch, uint slicePitch)
		{
			return new ImageDescription()
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
}
