using System;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Bejeweled
{
    unsafe struct DDS_FILE
    {
        public fixed byte Magic[4];
        public DDS_HEADER Header;
    }

    unsafe struct DDS_HEADER
    {
        public uint dwSize;
        public DDSD dwFlags;
        public uint dwHeight;
        public uint dwWidth;
        public uint dwPitchOrLinearSize;
        public uint dwDepth;
        public uint dwMipMapCount;
        public fixed uint dwReserved1[11];
        public DDS_PIXELFORMAT ddspf;
        public DDSCAPS dwCaps;
        public DDSCAPS2 dwCaps2;
        public uint dwCaps3;
        public uint dwCaps4;
        public uint dwReserved2;
    }

    unsafe struct DDS_PIXELFORMAT
    {
        public uint dwSize;
        public DDPF dwFlags;
        public fixed byte dwFourCC[4];
        public uint dwRGBBitCount;
        public uint dwRBitMask;
        public uint dwGBitMask;
        public uint dwBBitMask;
        public uint dwABitMask;
    }

    struct DDS_HEADER_DXT10
    {
        public DXGI_FORMAT dxgiFormat;
        public D3D10_RESOURCE_DIMENSION resourceDimension;
        public uint miscFlag;
        public uint arraySize;
        public uint miscFlags2;
    }

    struct DDSImage
    {
        public int Width;
        public int Height;
        public int MipmapCount;

        public DDSImageFormat Format;
        public DDSImageType Type;
        public DDSCubemapFaces Faces;

        public byte[] AllData;
    }

    ref struct DDSImageRef
    {
        public int Width;
        public int Height;
        public int MipmapCount;

        public DDSImageFormat Format;
        public DDSImageType Type;
        public DDSCubemapFaces Faces;

        public Span<byte> AllData;
    }

    enum DDSImageFormat
    {
        BC5_UNORM,
        BC7_UNORM,
        BC7_UNORM_SRGB,
        BC6H_UF,
        RGBA16F,
        RGBA32F,
    }

    enum DDSImageType
    {
        Texture2D,
        CubeMap,
    }

    [Flags]
    enum DDSCubemapFaces : int
    {
        None = 0,
        PosX = 1 << 0,
        NegX = 1 << 1,
        PosY = 1 << 2,
        NegY = 1 << 3,
        PosZ = 1 << 4,
        NegZ = 1 << 5,
    }

    internal class DDSReader
    {
        public static unsafe DDSImageRef LoadImage(Span<byte> fileContents)
        {
            fixed (byte* filePtr = fileContents)
            {
                DDS_FILE* dds = (DDS_FILE*)filePtr;

                if (new Span<byte>(dds->Magic, 4).SequenceEqual("DDS "u8) == false)
                {
                    throw new FormatException("Invalid magic.");
                }

                DDS_HEADER* header = &dds->Header;
                DDS_PIXELFORMAT* format = &header->ddspf;

                if (header->dwFlags.HasFlag(DDSD.WIDTH) == false)
                {
                    throw new FormatException("Header does not contain a width.");
                }

                if (header->dwFlags.HasFlag(DDSD.HEIGHT) == false)
                {
                    throw new FormatException("Header does not contain a height.");
                }

                if (format->dwFlags.HasFlag(DDPF.FOURCC) == false)
                {
                    throw new FormatException("We only support loading FourCC dds textures atm.");
                }

                bool isCubemap = false;
                DDSCubemapFaces faces = DDSCubemapFaces.None;
                if (header->dwCaps2.HasFlag(DDSCAPS2.CUBEMAP))
                {
                    isCubemap = true;

                    if (header->dwCaps2.HasFlag(DDSCAPS2.CUBEMAP_POSITIVEX))
                        faces |= DDSCubemapFaces.PosX;

                    if (header->dwCaps2.HasFlag(DDSCAPS2.CUBEMAP_NEGATIVEX))
                        faces |= DDSCubemapFaces.NegX;

                    if (header->dwCaps2.HasFlag(DDSCAPS2.CUBEMAP_POSITIVEY))
                        faces |= DDSCubemapFaces.PosY;

                    if (header->dwCaps2.HasFlag(DDSCAPS2.CUBEMAP_NEGATIVEY))
                        faces |= DDSCubemapFaces.NegY;

                    if (header->dwCaps2.HasFlag(DDSCAPS2.CUBEMAP_POSITIVEZ))
                        faces |= DDSCubemapFaces.PosZ;

                    if (header->dwCaps2.HasFlag(DDSCAPS2.CUBEMAP_NEGATIVEZ))
                        faces |= DDSCubemapFaces.NegZ;
                }

                int mipmapCount = 1;
                if (header->dwFlags.HasFlag(DDSD.MIPMAPCOUNT))
                {
                    mipmapCount = (int)header->dwMipMapCount;
                }

                ReadOnlySpan<byte> fourCC = new ReadOnlySpan<byte>(header->ddspf.dwFourCC, 4);
                if (fourCC.SequenceEqual("DX10"u8))
                {
                    DDS_HEADER_DXT10* dx10 = (DDS_HEADER_DXT10*)(header + 1);

                    DDSImageFormat imageFormat;
                    int dataSize;
                    switch (dx10->dxgiFormat)
                    {
                        case DXGI_FORMAT.BC7_UNORM:
                            {
                                imageFormat = DDSImageFormat.BC7_UNORM;
                                int blockSize = 16;
                                dataSize = CalculateSizeBlockCompressed((int)header->dwWidth, (int)header->dwHeight, mipmapCount, blockSize);
                                break;
                            }
                        case DXGI_FORMAT.BC7_UNORM_SRGB:
                            {
                                imageFormat = DDSImageFormat.BC7_UNORM_SRGB;
                                int blockSize = 16;
                                dataSize = CalculateSizeBlockCompressed((int)header->dwWidth, (int)header->dwHeight, mipmapCount, blockSize);
                                break;
                            }
                        case DXGI_FORMAT.BC6H_UF16:
                            {
                                imageFormat = DDSImageFormat.BC6H_UF;
                                int blockSize = 16;
                                dataSize = CalculateSizeBlockCompressed((int)header->dwWidth, (int)header->dwHeight, mipmapCount, blockSize);
                                break;
                            }
                        case DXGI_FORMAT.R16G16B16A16_FLOAT:
                            {
                                imageFormat = DDSImageFormat.RGBA16F;
                                int bytesPerPixel = 8;
                                dataSize = CalculateSize((int)header->dwWidth, (int)header->dwHeight, mipmapCount, bytesPerPixel);
                                break;
                            }
                        case DXGI_FORMAT.R32G32B32A32_FLOAT:
                            {
                                imageFormat = DDSImageFormat.RGBA32F;
                                int bytesPerPixel = 16;
                                dataSize = CalculateSize((int)header->dwWidth, (int)header->dwHeight, mipmapCount, bytesPerPixel);
                                break;
                            }
                        default:
                            throw new FormatException($"We don't support '{dx10->dxgiFormat}' formatted DDS images yet.");
                    }

                    if (isCubemap)
                    {
                        int noFaces = BitOperations.PopCount((uint)faces);
                        dataSize *= noFaces;
                    }

                    Span<byte> data = new Span<byte>((byte*)(dx10 + 1), dataSize);

                    DDSImageRef image;
                    image.Width = (int)header->dwWidth;
                    image.Height = (int)header->dwHeight;
                    image.MipmapCount = mipmapCount;
                    image.Format = imageFormat;
                    image.Type = isCubemap ? DDSImageType.CubeMap : DDSImageType.Texture2D;
                    image.Faces = faces;

                    // FIXME: Maybe upload the data directly to the GPU?
                    image.AllData = data;

                    return image;
                }
                else if (fourCC.SequenceEqual("ATI2"u8))
                {
                    // This is Bc5 with another name...
                    int blockSize = 16;
                    int dataSize = CalculateSizeBlockCompressed((int)header->dwWidth, (int)header->dwHeight, mipmapCount, blockSize);
                    if (isCubemap)
                    {
                        int noFaces = BitOperations.PopCount((uint)faces);
                        dataSize *= noFaces;
                    }
                    Span<byte> data = new Span<byte>((byte*)(header + 1), dataSize);

                    DDSImageRef image;
                    image.Width = (int)header->dwWidth;
                    image.Height = (int)header->dwHeight;
                    image.MipmapCount = mipmapCount;
                    image.Format = DDSImageFormat.BC5_UNORM;
                    image.Type = isCubemap ? DDSImageType.CubeMap : DDSImageType.Texture2D;
                    image.Faces = faces;

                    image.AllData = data;

                    return image;
                }
                // From: https://learn.microsoft.com/en-us/windows/win32/direct3ddds/dx-graphics-dds-pguide#dds-variants
                else if (MemoryMarshal.Cast<byte, int>(fourCC)[0] == 116) // R32G32B32A32_FLOAT
                {
                    int dataSize = CalculateSize((int)header->dwWidth, (int)header->dwHeight, (int)header->dwMipMapCount, 16);
                    if (isCubemap)
                    {
                        int noFaces = BitOperations.PopCount((uint)faces);
                        dataSize *= noFaces;
                    }
                    Span<byte> data = new Span<byte>((byte*)(header + 1), dataSize);

                    DDSImageRef image;
                    image.Width = (int)header->dwWidth;
                    image.Height = (int)header->dwHeight;
                    image.MipmapCount = mipmapCount;
                    image.Format = DDSImageFormat.RGBA32F;
                    image.Type = isCubemap ? DDSImageType.CubeMap : DDSImageType.Texture2D;
                    image.Faces = faces;

                    image.AllData = data;

                    return image;
                }
                else
                {
                    throw new Exception($"We don't support this format yet. '{Encoding.UTF8.GetString(fourCC)}'");
                }
            }

            static int CalculateSizeBlockCompressed(int width, int height, int mipmapCount, int blockSize)
            {
                int dataSize = 0;
                int mipWidth = width;
                int mipHeight = height;
                for (int i = 0; i < mipmapCount; i++)
                {
                    // A block is at minium blockSize bytes.
                    dataSize += Math.Max(mipWidth * mipHeight, blockSize);

                    mipWidth = Math.Max(1, mipWidth / 2);
                    mipHeight = Math.Max(1, mipHeight / 2);
                }

                return dataSize;
            }

            
        }

        public static int CalculateSize(int width, int height, int mipmapCount, int bytesPerPixel)
        {
            int dataSize = 0;
            int mipWidth = width;
            int mipHeight = height;
            for (int i = 0; i < mipmapCount; i++)
            {
                // A block is at minium 16 bytes.
                dataSize += mipWidth * mipHeight * bytesPerPixel;

                mipWidth = Math.Max(1, mipWidth / 2);
                mipHeight = Math.Max(1, mipHeight / 2);
            }

            return dataSize;
        }

        public static unsafe DDSImage LoadImage(string path)
        {
            byte[] fileContents = File.ReadAllBytes(path);
            DDSImageRef imageRef = LoadImage(fileContents);
            DDSImage image;
            image.Width = imageRef.Width;
            image.Height = imageRef.Height;
            image.MipmapCount = imageRef.MipmapCount;
            image.Format = imageRef.Format;
            image.Type = imageRef.Type;
            image.Faces = imageRef.Faces;
            image.AllData = imageRef.AllData.ToArray();
            return image;
        }
    }

    [Flags]
    enum DDSD : uint
    {
        /// <summary>
        /// Required in every .dds file.
        /// </summary>
        CAPS = 0x1,
        /// <summary>
        /// Required in every .dds file.
        /// </summary>
        HEIGHT = 0x2,
        /// <summary>
        /// Required in every .dds file.
        /// </summary>
        WIDTH = 0x4,
        /// <summary>
        /// Required when pitch is provided for an uncompressed texture.
        /// </summary>
        PITCH = 0x8,
        /// <summary>
        /// Required in every .dds file.
        /// </summary>
        PIXELFORMAT = 0x1000,
        /// <summary>
        /// Required in a mipmapped texture.
        /// </summary>
        MIPMAPCOUNT = 0x20000,
        /// <summary>
        /// Required when pitch is provided for a compressed texture.
        /// </summary>
        LINEARSIZE = 0x80000,
        /// <summary>
        /// Required in a depth texture.
        /// </summary>
        DEPTH = 0x800000,
    }

    [Flags]
    enum DDPF : uint
    {
        /// <summary>
        /// Texture contains alpha data; dwRGBAlphaBitMask contains valid data.
        /// </summary>
        ALPHAPIXELS = 0x1,
        /// <summary>
        /// Used in some older DDS files for alpha channel only uncompressed data (dwRGBBitCount contains the alpha channel bitcount; dwABitMask contains valid data)
        /// </summary>
        ALPHA = 0x2,
        /// <summary>
        /// Texture contains compressed RGB data; dwFourCC contains valid data.
        /// </summary>
        FOURCC = 0x4,
        /// <summary>
        /// Texture contains uncompressed RGB data; dwRGBBitCount and the RGB masks (dwRBitMask, dwGBitMask, dwBBitMask) contain valid data.
        /// </summary>
        RGB = 0x40,
        /// <summary>
        /// Used in some older DDS files for YUV uncompressed data (dwRGBBitCount contains the YUV bit count; dwRBitMask contains the Y mask, dwGBitMask contains the U mask, dwBBitMask contains the V mask)
        /// </summary>
        YUV = 0x200,
        /// <summary>
        /// Used in some older DDS files for single channel color uncompressed data (dwRGBBitCount contains the luminance channel bit count; dwRBitMask contains the channel mask). Can be combined with DDPF_ALPHAPIXELS for a two channel DDS file.	
        /// </summary>
        LUMINANCE = 0x20000,
    }

    [Flags]
    enum DDSCAPS : uint
    {
        /// <summary>
        /// Optional; must be used on any file that contains more than one surface (a mipmap, a cubic environment map, or mipmapped volume texture).
        /// </summary>
        COMPLEX = 0x8,
        /// <summary>
        /// Optional; should be used for a mipmap.
        /// </summary>
        MIPMAP = 0x400000,
        /// <summary>
        /// Required.
        /// </summary>
        TEXTURE = 0x1000,
    }

    [Flags]
    enum DDSCAPS2 : uint
    {
        /// <summary>
        /// Required for a cube map.
        /// </summary>
        CUBEMAP = 0x200,
        /// <summary>
        /// Required when these surfaces are stored in a cube map.
        /// </summary>
        CUBEMAP_POSITIVEX = 0x400,
        /// <summary>
        /// Required when these surfaces are stored in a cube map.
        /// </summary>
        CUBEMAP_NEGATIVEX = 0x800,
        /// <summary>
        /// Required when these surfaces are stored in a cube map.
        /// </summary>
        CUBEMAP_POSITIVEY = 0x1000,
        /// <summary>
        /// Required when these surfaces are stored in a cube map.
        /// </summary>
        CUBEMAP_NEGATIVEY = 0x2000,
        /// <summary>
        /// Required when these surfaces are stored in a cube map.
        /// </summary>
        CUBEMAP_POSITIVEZ = 0x4000,
        /// <summary>
        /// Required when these surfaces are stored in a cube map.
        /// </summary>
        CUBEMAP_NEGATIVEZ = 0x8000,
        /// <summary>
        ///  Required for a volume texture.
        /// </summary>
        VOLUME = 0x200000,
    }

    enum DXGI_FORMAT : uint
    {
        UNKNOWN = 0,
        R32G32B32A32_TYPELESS = 1,
        R32G32B32A32_FLOAT = 2,
        R32G32B32A32_UINT = 3,
        R32G32B32A32_SINT = 4,
        R32G32B32_TYPELESS = 5,
        R32G32B32_FLOAT = 6,
        R32G32B32_UINT = 7,
        R32G32B32_SINT = 8,
        R16G16B16A16_TYPELESS = 9,
        R16G16B16A16_FLOAT = 10,
        R16G16B16A16_UNORM = 11,
        R16G16B16A16_UINT = 12,
        R16G16B16A16_SNORM = 13,
        R16G16B16A16_SINT = 14,
        R32G32_TYPELESS = 15,
        R32G32_FLOAT = 16,
        R32G32_UINT = 17,
        R32G32_SINT = 18,
        R32G8X24_TYPELESS = 19,
        D32_FLOAT_S8X24_UINT = 20,
        R32_FLOAT_X8X24_TYPELESS = 21,
        X32_TYPELESS_G8X24_UINT = 22,
        R10G10B10A2_TYPELESS = 23,
        R10G10B10A2_UNORM = 24,
        R10G10B10A2_UINT = 25,
        R11G11B10_FLOAT = 26,
        R8G8B8A8_TYPELESS = 27,
        R8G8B8A8_UNORM = 28,
        R8G8B8A8_UNORM_SRGB = 29,
        R8G8B8A8_UINT = 30,
        R8G8B8A8_SNORM = 31,
        R8G8B8A8_SINT = 32,
        R16G16_TYPELESS = 33,
        R16G16_FLOAT = 34,
        R16G16_UNORM = 35,
        R16G16_UINT = 36,
        R16G16_SNORM = 37,
        R16G16_SINT = 38,
        R32_TYPELESS = 39,
        D32_FLOAT = 40,
        R32_FLOAT = 41,
        R32_UINT = 42,
        R32_SINT = 43,
        R24G8_TYPELESS = 44,
        D24_UNORM_S8_UINT = 45,
        R24_UNORM_X8_TYPELESS = 46,
        X24_TYPELESS_G8_UINT = 47,
        R8G8_TYPELESS = 48,
        R8G8_UNORM = 49,
        R8G8_UINT = 50,
        R8G8_SNORM = 51,
        R8G8_SINT = 52,
        R16_TYPELESS = 53,
        R16_FLOAT = 54,
        D16_UNORM = 55,
        R16_UNORM = 56,
        R16_UINT = 57,
        R16_SNORM = 58,
        R16_SINT = 59,
        R8_TYPELESS = 60,
        R8_UNORM = 61,
        R8_UINT = 62,
        R8_SNORM = 63,
        R8_SINT = 64,
        A8_UNORM = 65,
        R1_UNORM = 66,
        R9G9B9E5_SHAREDEXP = 67,
        R8G8_B8G8_UNORM = 68,
        G8R8_G8B8_UNORM = 69,
        BC1_TYPELESS = 70,
        BC1_UNORM = 71,
        BC1_UNORM_SRGB = 72,
        BC2_TYPELESS = 73,
        BC2_UNORM = 74,
        BC2_UNORM_SRGB = 75,
        BC3_TYPELESS = 76,
        BC3_UNORM = 77,
        BC3_UNORM_SRGB = 78,
        BC4_TYPELESS = 79,
        BC4_UNORM = 80,
        BC4_SNORM = 81,
        BC5_TYPELESS = 82,
        BC5_UNORM = 83,
        BC5_SNORM = 84,
        B5G6R5_UNORM = 85,
        B5G5R5A1_UNORM = 86,
        B8G8R8A8_UNORM = 87,
        B8G8R8X8_UNORM = 88,
        R10G10B10_XR_BIAS_A2_UNORM = 89,
        B8G8R8A8_TYPELESS = 90,
        B8G8R8A8_UNORM_SRGB = 91,
        B8G8R8X8_TYPELESS = 92,
        B8G8R8X8_UNORM_SRGB = 93,
        BC6H_TYPELESS = 94,
        BC6H_UF16 = 95,
        BC6H_SF16 = 96,
        BC7_TYPELESS = 97,
        BC7_UNORM = 98,
        BC7_UNORM_SRGB = 99,
        AYUV = 100,
        Y410 = 101,
        Y416 = 102,
        NV12 = 103,
        P010 = 104,
        P016 = 105,
        _420_OPAQUE = 106,
        YUY2 = 107,
        Y210 = 108,
        Y216 = 109,
        NV11 = 110,
        AI44 = 111,
        IA44 = 112,
        P8 = 113,
        A8P8 = 114,
        B4G4R4A4_UNORM = 115,
        P208 = 130,
        V208 = 131,
        V408 = 132,
        SAMPLER_FEEDBACK_MIN_MIP_OPAQUE,
        SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE,
        FORCE_UINT = 0xffffffff,
    }

    enum D3D10_RESOURCE_DIMENSION
    {
        UNKNOWN = 0,
        BUFFER = 1,
        TEXTURE1D = 2,
        TEXTURE2D = 3,
        TEXTURE3D = 4,
    }
}
