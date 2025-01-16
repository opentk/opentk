using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Bejeweled
{
    internal static class BC6H
    {
        /*
        decompress_bc6h(x, y, block)
        {
            mode = extract_mode(block);
            endpoints;
            index;
    
            if(mode.type == ONE)
            {
                endpoints = extract_compressed_endpoints(mode, block);
                index = extract_index_ONE(x, y, block);
            }
            else //mode.type == TWO
            {
                partition = extract_partition(block);
                region = get_region(partition, x, y);
                endpoints = extract_compressed_endpoints(mode, region, block);
                index = extract_index_TWO(x, y, partition, block);
            }
    
            unquantize(endpoints);
            color = interpolate(index, endpoints);
            finish_unquantize(color);
        }
        */

        [InlineArray(16)]
        public unsafe struct Block
        {
            public byte B;

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly uint GetBits([ConstantExpected(Min = 0, Max = 127)] int start, [ConstantExpected(Min = 1, Max = 32)] int bits)
            {
                Debug.Assert(start + bits <= 128);
                Debug.Assert(bits <= 32);

                uint value = 0;

                int bitsRead = 0;

                int si = start / 8;
                int sf = start % 8;
                int sb = Math.Min(8 - sf, bits);
                uint smask = ((0b1u << sb) - 1) << sf;

                value |= (this[si] & smask) >>> sf;
                bitsRead = sb;

                while (bitsRead != bits)
                {
                    si += 1;
                    sf = 0;
                    sb = Math.Min(8, bits - bitsRead);
                    smask = (0b1u << sb) - 1;
                    value |= (this[si] & smask) << bitsRead;
                    bitsRead += sb;
                }

                return value;
            }

            public override string ToString()
            {
                ReadOnlySpan<byte> bytes = this;
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append($"{b:B8}");
                    sb.Append(",");
                }
                sb.Length -= 1;
                return $"{{{sb}}}";
            }
        }

        public struct Half3
        {
            public Half R, G, B;

            public override readonly string ToString()
            {
                return $"({R}, {G}, {B})";
            }
        }

        public struct Uint3
        {
            public uint R, G, B;

            public static Uint3 operator +(Uint3 a, Uint3 b)
            {
                Uint3 res;
                res.R = a.R + b.R;
                res.G = a.G + b.G;
                res.B = a.B + b.B;
                return res;
            }

            public static Uint3 operator &(Uint3 a, uint b)
            {
                Uint3 res;
                res.R = a.R & b;
                res.G = a.G & b;
                res.B = a.B & b;
                return res;
            }

            public override readonly string ToString()
            {
                return $"({R}, {G}, {B})";
            }
        }

        public struct Ushort3
        {
            public ushort R, G, B;

            public override readonly string ToString()
            {
                return $"({R}, {G}, {B})";
            }
        }

        public struct Ushort4
        {
            public ushort R, G, B, A;

            public override readonly string ToString()
            {
                return $"({R}, {G}, {B}, {A})";
            }
        }


        public struct AB
        {
            public Uint3 A;
            public Uint3 B;
        }

        [InlineArray(2)]
        public struct IntEndpts
        {
            public AB AB;
        }

        [InlineArray(8)]
        public struct Palette8
        {
            public Ushort3 Color;

            public override readonly string ToString()
            {
                return $"{{{string.Join(',', (MemoryMarshal.Cast<Ushort3, Half3>((ReadOnlySpan<Ushort3>)this)).ToArray())}}}";
            }
        }

        [InlineArray(16)]
        public struct Palette16
        {
            public Ushort3 Color;

            public override readonly string ToString()
            {
                return $"{{{string.Join(',', (MemoryMarshal.Cast<Ushort3, Half3>((ReadOnlySpan<Ushort3>)this)).ToArray())}}}";
            }
        }

        [InlineArray(16)]
        public struct Indices16
        {
            public byte Index;

            public override readonly string ToString()
            {
                return $"{{{string.Join(',', ((ReadOnlySpan<byte>)this).ToArray())}}}";
            }
        }

        public struct DecompressionData
        {
            public int Mode;
            public bool Has2Regions;

            public uint Shape;

            public Uint3 A0, A1;
            public Uint3 B0, B1;
            public int WBits;
            public Uint3 CBits;
            public IntEndpts Endpts;

            public Palette8 Palette8Region0;
            public Palette8 Palette8Region1;

            public Palette16 Palette16;

            public Indices16 Indices16;
        }

        public static unsafe void DecompressBC6H(Span<byte> imageData, int width, int height, Span<Half> resultData)
        {
            Span<Block> blocks = MemoryMarshal.Cast<byte, Block>(imageData);
            Debug.Assert(blocks.Length * 16 * 4 == resultData.Length);

            Span<Ushort4> blockData = stackalloc Ushort4[4 * 4];
            for (int i = 0; i < blocks.Length; i++)
            {
                // FIXME: Convert Ushort3 to Ushort4.
                DecompressBC6HBlock(blocks[i], blockData);

                int blockX = i % (width / 4);
                int blockY = i / (width / 4);

                Span<Half> blockDataHalf = MemoryMarshal.Cast<Ushort4, Half>(blockData);
                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        int blockIndex = (y * 4 + x) * 4;
                        int imageIndex = ((blockY * 4 + y) * width + (blockX * 4 + x)) * 4;
                        resultData[imageIndex + 0] = blockDataHalf[blockIndex + 0];
                        resultData[imageIndex + 1] = blockDataHalf[blockIndex + 1];
                        resultData[imageIndex + 2] = blockDataHalf[blockIndex + 2];
                        resultData[imageIndex + 3] = blockDataHalf[blockIndex + 3];
                    }
                }
            }
        }

        public static void DecompressBC6HBlock(Block block, Span<Ushort4> outputData)
        {
            Debug.Assert(outputData.Length == 4 * 4);

            DecompressionData data = new DecompressionData();
            int modeBits = ExtractMode(block);

            ExtractCompressedEndpoints(ref data, modeBits, block);
            data.Has2Regions = (data.Mode <= 10);

            uint partition = 0;
            if (data.Has2Regions)
            {
                data.Shape = ExtractShape(block);

                ExtractIndices(ref data, data.Shape, block);

                data.Palette8Region0 = GeneratePalette8(data.Endpts[0].A, data.Endpts[0].B, data.WBits);
                data.Palette8Region1 = GeneratePalette8(data.Endpts[1].A, data.Endpts[1].B, data.WBits);

                partition = ShapeTable[data.Shape];
            }
            else
            {
                ExtractIndices(ref data, uint.MaxValue, block);

                data.Palette16 = GeneratePalette16(data.Endpts[0].A, data.Endpts[0].B, data.WBits);
            }

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int i = x + y * 4;

                    int paleteIndex = data.Indices16[i];

                    Ushort3 color;
                    if (data.Has2Regions)
                    {
                        int partitionMask = 1 << i;
                        bool region1 = (partition & partitionMask) == partitionMask ? true : false;

                        if (region1)
                        {
                            color = data.Palette8Region1[paleteIndex];
                        }
                        else
                        {
                            color = data.Palette8Region0[paleteIndex];
                        }
                    }
                    else
                    {
                        color = data.Palette16[paleteIndex];
                    }

                    // FIXME: It's unclear to me why we don't need to shift down one
                    // to accomodate the sign bit when converting to HALF_FLOAT...
                    // - Noggin_bops 2024-06-15
                    outputData[i].R = color.R;
                    outputData[i].G = color.G;
                    outputData[i].B = color.B;
                    // 1.0 as half.
                    outputData[i].A = 0x3C00;
                }
            }
        }

        static int ExtractMode(in Block block)
        {
            int mode = block[0] & 0b11111;
            if ((mode & 0b11) == 0b00 ||
                (mode & 0b11) == 0b01)
            {
                return mode & 0b00011;
            }
            else
            {
                return mode;
            }
        }

        static readonly uint[] ShapeTable = new uint[32]
        {
            0b1100_1100_1100_1100,
            0b1000_1000_1000_1000,
            0b1110_1110_1110_1110,
            0b1110_1100_1100_1000,

            0b1100_1000_1000_0000,
            0b1111_1110_1110_1100,
            0b1111_1110_1100_1000,
            0b1110_1100_1000_0000,

            0b1100_1000_0000_0000,
            0b1111_1111_1110_1100,
            0b1111_1110_1000_0000,
            0b1110_1000_0000_0000,

            0b1111_1111_1110_1000,
            0b1111_1111_0000_0000,
            0b1111_1111_1111_0000,
            0b1111_0000_0000_0000,

            0b1111_0111_0001_0000,
            0b0000_0000_1000_1110,
            0b0111_0001_0000_0000,
            0b0000_1000_1100_1110,

            0b0000_0000_1000_1100,
            0b0111_0011_0001_0000,
            0b0011_0001_0000_0000,
            0b1000_1100_1100_1110,

            0b0000_1000_1000_1100,
            0b0011_0001_0001_0000,
            0b0110_0110_0110_0110,
            0b0011_0110_0110_1100,

            0b0001_0111_1110_1000,
            0b0000_1111_1111_0000,
            0b0111_0001_1000_1110,
            0b0011_1001_1001_1100,
        };
        static uint ExtractShape(in Block block)
        {
            uint d = block.GetBits(77, 5);
            return d;
        }

        // FIXME: Make this return the endpoints instead of taking DecompressionData as ref.
        // Also split getting the A0,B0,A1,B1 bits from getting the endpoints.
        static void ExtractCompressedEndpoints(ref DecompressionData data, int modeBits, in Block block)
        {
            switch (modeBits)
            {
                case 0b00000:
                    data.Mode = 1;
                    {
                        uint rw = block.GetBits(5, 10);
                        uint rx = block.GetBits(35, 5);
                        uint ry = block.GetBits(65, 5);
                        uint rz = block.GetBits(71, 5);

                        uint gw = block.GetBits(15, 10);
                        uint gx = block.GetBits(45, 5);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(2, 1) << 4);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(40, 1) << 4);

                        uint bw = block.GetBits(25, 10);
                        uint bx = block.GetBits(55, 5);
                        uint by = block.GetBits(61, 4) | (block.GetBits(3, 1) << 4);
                        uint bz = block.GetBits(50, 1) | (block.GetBits(60, 1) << 1) | (block.GetBits(70, 1) << 2) | (block.GetBits(76, 1) << 3) | (block.GetBits(4, 1) << 4);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 10;
                        data.CBits.R = 5;
                        data.CBits.G = 5;
                        data.CBits.B = 5;
                    }
                    break;
                case 0b00001:
                    data.Mode = 2;
                    {
                        uint rw = block.GetBits(5, 7);
                        uint rx = block.GetBits(35, 6);
                        uint ry = block.GetBits(65, 6);
                        uint rz = block.GetBits(71, 6);

                        uint gw = block.GetBits(15, 7);
                        uint gx = block.GetBits(45, 6);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(24, 1) << 4) | (block.GetBits(2, 1) << 5);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(3, 1) << 4) | (block.GetBits(4, 1) << 5);

                        uint bw = block.GetBits(25, 7);
                        uint bx = block.GetBits(55, 6);
                        uint by = block.GetBits(61, 4) | (block.GetBits(14, 1) << 4) | (block.GetBits(22, 1) << 5);
                        uint bz = block.GetBits(12, 1) | (block.GetBits(13, 1) << 1) | (block.GetBits(23, 1) << 2) | (block.GetBits(32, 1) << 3) | (block.GetBits(34, 1) << 4) | (block.GetBits(33, 1) << 5);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 7;
                        data.CBits.R = 6;
                        data.CBits.G = 6;
                        data.CBits.B = 6;
                    }
                    break;
                case 0b00010:
                    data.Mode = 3;
                    {
                        uint rw = block.GetBits(5, 10) | (block.GetBits(40, 1) << 10);
                        uint rx = block.GetBits(35, 5);
                        uint ry = block.GetBits(65, 5);
                        uint rz = block.GetBits(71, 5);

                        uint gw = block.GetBits(15, 10) | (block.GetBits(49, 1) << 10);
                        uint gx = block.GetBits(45, 4);
                        uint gy = block.GetBits(41, 4);
                        uint gz = block.GetBits(51, 4);

                        uint bw = block.GetBits(25, 10) | (block.GetBits(59, 1) << 10);
                        uint bx = block.GetBits(55, 4);
                        uint by = block.GetBits(61, 4);
                        uint bz = block.GetBits(50, 1) | (block.GetBits(60, 1) << 1) | (block.GetBits(70, 1) << 2) | (block.GetBits(76, 1) << 3);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 11;
                        data.CBits.R = 5;
                        data.CBits.G = 4;
                        data.CBits.B = 4;
                    }
                    break;
                case 0b00110:
                    data.Mode = 4;
                    {
                        uint rw = block.GetBits(5, 10) | (block.GetBits(39, 1) << 10);
                        uint rx = block.GetBits(35, 4);
                        uint ry = block.GetBits(65, 4);
                        uint rz = block.GetBits(71, 4);

                        uint gw = block.GetBits(15, 10) | (block.GetBits(50, 1) << 10);
                        uint gx = block.GetBits(45, 5);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(75, 1) << 4);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(40, 1) << 4);

                        uint bw = block.GetBits(25, 10) | (block.GetBits(59, 1) << 10);
                        uint bx = block.GetBits(55, 4);
                        uint by = block.GetBits(61, 4);
                        uint bz = block.GetBits(69, 1) | (block.GetBits(60, 1) << 1) | (block.GetBits(70, 1) << 2) | (block.GetBits(76, 1) << 3);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 11;
                        data.CBits.R = 4;
                        data.CBits.G = 5;
                        data.CBits.B = 4;
                    }
                    break;
                case 0b01010:
                    data.Mode = 5;
                    {
                        {
                            uint rw = block.GetBits(5, 10) | (block.GetBits(39, 1) << 10);
                            uint rx = block.GetBits(35, 4);
                            uint ry = block.GetBits(65, 4);
                            uint rz = block.GetBits(71, 4);

                            uint gw = block.GetBits(15, 10) | (block.GetBits(49, 1) << 10);
                            uint gx = block.GetBits(45, 4);
                            uint gy = block.GetBits(41, 4);
                            uint gz = block.GetBits(51, 4);

                            uint bw = block.GetBits(25, 10) | (block.GetBits(60, 1) << 10);
                            uint bx = block.GetBits(55, 5);
                            uint by = block.GetBits(61, 4) | (block.GetBits(40, 1) << 4);
                            uint bz = block.GetBits(50, 1) | (block.GetBits(69, 1) << 1) | (block.GetBits(70, 1) << 2) | (block.GetBits(76, 1) << 3) | (block.GetBits(75, 1) << 4);

                            data.A0.R = rw;
                            data.B0.R = rx;
                            data.A1.R = ry;
                            data.B1.R = rz;

                            data.A0.G = gw;
                            data.B0.G = gx;
                            data.A1.G = gy;
                            data.B1.G = gz;

                            data.A0.B = bw;
                            data.B0.B = bx;
                            data.A1.B = by;
                            data.B1.B = bz;

                            data.WBits = 11;
                            data.CBits.R = 4;
                            data.CBits.G = 4;
                            data.CBits.B = 5;
                        }
                    }
                    break;
                case 0b01110:
                    data.Mode = 6;
                    {
                        uint rw = block.GetBits(5, 9);
                        uint gw = block.GetBits(15, 9);
                        uint bw = block.GetBits(25, 9);

                        uint rx = block.GetBits(35, 5);
                        uint gx = block.GetBits(45, 5);
                        uint bx = block.GetBits(55, 5);

                        uint ry = block.GetBits(65, 5);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(24, 1) << 4);
                        uint by = block.GetBits(61, 4) | (block.GetBits(14, 1) << 4);

                        uint rz = block.GetBits(71, 5);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(40, 1) << 4);
                        uint bz = block.GetBits(50, 1) | (block.GetBits(60, 1) >> 1) | (block.GetBits(70, 1) << 2) | (block.GetBits(76, 1) << 3) | (block.GetBits(34, 1) << 4);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 9;
                        data.CBits.R = 5;
                        data.CBits.G = 5;
                        data.CBits.B = 5;
                    }
                    break;
                case 0b10010:
                    data.Mode = 7;
                    {
                        uint rw = block.GetBits(5, 8);
                        uint gw = block.GetBits(15, 8);
                        uint bw = block.GetBits(25, 8);

                        uint rx = block.GetBits(35, 6);
                        uint gx = block.GetBits(45, 5);
                        uint bx = block.GetBits(55, 5);

                        uint ry = block.GetBits(65, 6);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(24, 1) << 4);
                        uint by = block.GetBits(61, 4) | (block.GetBits(14, 1) << 4);

                        uint rz = block.GetBits(71, 6);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(13, 1) << 4);
                        uint bz = block.GetBits(50, 1) | (block.GetBits(60, 1) >> 1) | (block.GetBits(23, 1) << 2) | (block.GetBits(33, 1) << 3) | (block.GetBits(34, 1) << 4);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 8;
                        data.CBits.R = 6;
                        data.CBits.G = 5;
                        data.CBits.B = 5;
                    }
                    break;
                case 0b10110:
                    data.Mode = 8;
                    {
                        uint rw = block.GetBits(5, 8);
                        uint gw = block.GetBits(15, 8);
                        uint bw = block.GetBits(25, 8);

                        uint rx = block.GetBits(35, 5);
                        uint gx = block.GetBits(45, 6);
                        uint bx = block.GetBits(55, 5);

                        uint ry = block.GetBits(65, 5);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(24, 1) << 4) | (block.GetBits(23, 1) << 5);
                        uint by = block.GetBits(61, 4) | (block.GetBits(14, 1) << 4);

                        uint rz = block.GetBits(71, 5);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(40, 1) << 4) | (block.GetBits(33, 1) << 5);
                        uint bz = block.GetBits(13, 1) | (block.GetBits(60, 1) >> 1) | (block.GetBits(70, 1) << 2) | (block.GetBits(76, 1) << 3) | (block.GetBits(34, 1) << 4);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 8;
                        data.CBits.R = 5;
                        data.CBits.G = 6;
                        data.CBits.B = 5;
                    }
                    break;
                case 0b11010:
                    data.Mode = 9;
                    {
                        uint rw = block.GetBits(5, 8);
                        uint gw = block.GetBits(15, 8);
                        uint bw = block.GetBits(25, 8);

                        uint rx = block.GetBits(35, 5);
                        uint gx = block.GetBits(45, 5);
                        uint bx = block.GetBits(55, 6);

                        uint ry = block.GetBits(65, 5);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(24, 1) << 4);
                        uint by = block.GetBits(61, 4) | (block.GetBits(14, 1) << 4) | (block.GetBits(23, 1) << 5);

                        uint rz = block.GetBits(71, 5);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(40, 1) << 4);
                        uint bz = block.GetBits(13, 1) | (block.GetBits(60, 1) >> 1) | (block.GetBits(70, 1) << 2) | (block.GetBits(76, 1) << 3) | (block.GetBits(34, 1) << 4) | (block.GetBits(33, 1) << 5);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 8;
                        data.CBits.R = 5;
                        data.CBits.G = 5;
                        data.CBits.B = 6;
                    }
                    break;
                case 0b11110:
                    data.Mode = 10;
                    {
                        uint rw = block.GetBits(5, 6);
                        uint gw = block.GetBits(15, 6);
                        uint bw = block.GetBits(25, 6);

                        uint rx = block.GetBits(35, 6);
                        uint gx = block.GetBits(45, 6);
                        uint bx = block.GetBits(55, 6);

                        uint ry = block.GetBits(65, 6);
                        uint gy = block.GetBits(41, 4) | (block.GetBits(24, 1) << 4) | (block.GetBits(21, 1) << 5);
                        uint by = block.GetBits(61, 4) | (block.GetBits(14, 1) << 4) | (block.GetBits(22, 1) << 5);

                        uint rz = block.GetBits(71, 6);
                        uint gz = block.GetBits(51, 4) | (block.GetBits(11, 1) << 4) | (block.GetBits(31, 1) << 5);
                        uint bz = block.GetBits(12, 1) | (block.GetBits(13, 1) << 1) | (block.GetBits(23, 1) << 2) | (block.GetBits(32, 1) << 3) | (block.GetBits(34, 1) << 4) | (block.GetBits(33, 1) << 5);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = ry;
                        data.B1.R = rz;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = gy;
                        data.B1.G = gz;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = by;
                        data.B1.B = bz;

                        data.WBits = 6;
                        data.CBits.R = 6;
                        data.CBits.G = 6;
                        data.CBits.B = 6;
                    }
                    break;
                case 0b00011:
                    data.Mode = 11;
                    {
                        uint rw = block.GetBits(5, 10);
                        uint gw = block.GetBits(15, 10);
                        uint bw = block.GetBits(25, 10);

                        uint rx = block.GetBits(35, 10);
                        uint gx = block.GetBits(45, 10);
                        uint bx = block.GetBits(55, 10);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = 0;
                        data.B1.R = 0;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = 0;
                        data.B1.G = 0;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = 0;
                        data.B1.B = 0;

                        data.WBits = 10;
                        data.CBits.R = 10;
                        data.CBits.G = 10;
                        data.CBits.B = 10;
                    }
                    break;
                case 0b00111:
                    data.Mode = 12;
                    {
                        uint rw = block.GetBits(5, 10) | (block.GetBits(44, 1) << 10);
                        uint gw = block.GetBits(15, 10) | (block.GetBits(54, 1) << 10);
                        uint bw = block.GetBits(25, 10) | (block.GetBits(64, 1) << 10);

                        uint rx = block.GetBits(35, 9);
                        uint gx = block.GetBits(45, 9);
                        uint bx = block.GetBits(55, 9);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = 0;
                        data.B1.R = 0;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = 0;
                        data.B1.G = 0;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = 0;
                        data.B1.B = 0;

                        data.WBits = 11;
                        data.CBits.R = 9;
                        data.CBits.G = 9;
                        data.CBits.B = 9;
                    }
                    break;
                case 0b01011:
                    data.Mode = 13;
                    {
                        uint rw = block.GetBits(5, 10) | (block.GetBits(44, 1) << 10) | (block.GetBits(43, 1) << 11);
                        uint gw = block.GetBits(15, 10) | (block.GetBits(54, 1) << 10) | (block.GetBits(53, 1) << 11);
                        uint bw = block.GetBits(25, 10) | (block.GetBits(64, 1) << 10) | (block.GetBits(63, 1) << 11);

                        uint rx = block.GetBits(35, 8);
                        uint gx = block.GetBits(45, 8);
                        uint bx = block.GetBits(55, 8);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = 0;
                        data.B1.R = 0;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = 0;
                        data.B1.G = 0;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = 0;
                        data.B1.B = 0;

                        data.WBits = 12;
                        data.CBits.R = 8;
                        data.CBits.G = 8;
                        data.CBits.B = 8;
                    }
                    break;
                case 0b01111:
                    data.Mode = 14;
                    {
                        uint rw = block.GetBits(5, 10) |
                            (block.GetBits(44, 1) << 10) |
                            (block.GetBits(43, 1) << 11) |
                            (block.GetBits(42, 1) << 12) |
                            (block.GetBits(41, 1) << 13) |
                            (block.GetBits(40, 1) << 14) |
                            (block.GetBits(39, 1) << 15);
                        uint gw = block.GetBits(15, 10) |
                            (block.GetBits(54, 1) << 10) |
                            (block.GetBits(53, 1) << 11) |
                            (block.GetBits(52, 1) << 12) |
                            (block.GetBits(51, 1) << 13) |
                            (block.GetBits(50, 1) << 14) |
                            (block.GetBits(49, 1) << 15);
                        uint bw = block.GetBits(25, 10) |
                            (block.GetBits(64, 1) << 10) |
                            (block.GetBits(63, 1) << 11) |
                            (block.GetBits(62, 1) << 12) |
                            (block.GetBits(61, 1) << 13) |
                            (block.GetBits(60, 1) << 14) |
                            (block.GetBits(59, 1) << 15);

                        uint rx = block.GetBits(35, 4);
                        uint gx = block.GetBits(45, 4);
                        uint bx = block.GetBits(55, 4);

                        data.A0.R = rw;
                        data.B0.R = rx;
                        data.A1.R = 0;
                        data.B1.R = 0;

                        data.A0.G = gw;
                        data.B0.G = gx;
                        data.A1.G = 0;
                        data.B1.G = 0;

                        data.A0.B = bw;
                        data.B0.B = bx;
                        data.A1.B = 0;
                        data.B1.B = 0;

                        data.WBits = 16;
                        data.CBits.R = 4;
                        data.CBits.G = 4;
                        data.CBits.B = 4;
                    }
                    break;
                default:
                    throw new Exception();
            }

            // Mode 10 and 11 are not delta compressed.
            bool isDeltaCompressed = data.Mode != 10 && data.Mode != 11;

            // Sign extend and do delta work.
            if (isDeltaCompressed)
            {
                data.Endpts[0].A = data.A0;
                data.Endpts[0].B = (SignExtend(data.B0, data.CBits) + data.A0) & ((1u << data.WBits) - 1);
                data.Endpts[1].A = (SignExtend(data.A1, data.CBits) + data.A0) & ((1u << data.WBits) - 1);
                data.Endpts[1].B = (SignExtend(data.B1, data.CBits) + data.A0) & ((1u << data.WBits) - 1);
            }
            else
            {
                data.Endpts[0].A = data.A0;
                data.Endpts[0].B = data.B0;
                data.Endpts[1].A = data.A1;
                data.Endpts[1].B = data.B1;
            }
        }

        static readonly int[] IndexFixups = new int[32]
        {
            15, 15, 15, 15,
            15, 15, 15, 15,
            15, 15, 15, 15,
            15, 15, 15, 15,
            15,  2,  8,  2,
             2,  8,  8, 15,
             2,  8,  2,  2,
             8,  8,  2,  2,
        };
        static void ExtractIndices(ref DecompressionData data, uint shape, in Block block)
        {
            if (data.Has2Regions)
            {
                int index = 82;
                for (int i = 0; i < 16; i++)
                {
                    int bits = (i == 0 || IndexFixups[shape] == i) ? 2 : 3;
                    data.Indices16[i] = (byte)block.GetBits(index, bits);
                    index += bits;
                }
            }
            else
            {
                int index = 65;
                for (int i = 0; i < 16; i++)
                {
                    int bits = i == 0 ? 3 : 4;
                    data.Indices16[i] = (byte)block.GetBits(index, bits);
                    index += bits;
                }
            }
        }

        static readonly uint[] Weights8 = new uint[8] { 0, 9, 18, 27, 37, 46, 55, 64 };
        static Palette8 GeneratePalette8(Uint3 c1, Uint3 c2, int bits)
        {
            Palette8 palette = new Palette8();

            Uint3 a = Unquantize(c1, bits);
            Uint3 b = Unquantize(c2, bits);

            for (int i = 0; i < Weights8.Length; i++)
            {
                Debug.Assert(((a.R * (64 - Weights8[i]) + b.R * Weights8[i] + 32) >> 6) == (((int)a.R * (64 - (int)Weights8[i]) + (int)b.R * (int)Weights8[i] + 32) >> 6));
                Debug.Assert(((a.G * (64 - Weights8[i]) + b.G * Weights8[i] + 32) >> 6) == (((int)a.G * (64 - (int)Weights8[i]) + (int)b.G * (int)Weights8[i] + 32) >> 6));
                Debug.Assert(((a.B * (64 - Weights8[i]) + b.B * Weights8[i] + 32) >> 6) == (((int)a.B * (64 - (int)Weights8[i]) + (int)b.B * (int)Weights8[i] + 32) >> 6));

                palette[i].R = FinishUnquantize((a.R * (64 - Weights8[i]) + b.R * Weights8[i] + 32) >> 6);
                palette[i].G = FinishUnquantize((a.G * (64 - Weights8[i]) + b.G * Weights8[i] + 32) >> 6);
                palette[i].B = FinishUnquantize((a.B * (64 - Weights8[i]) + b.B * Weights8[i] + 32) >> 6);
            }

            return palette;
        }

        static readonly uint[] Weights16 = new uint[16] { 0, 4, 9, 13, 17, 21, 26, 30, 34, 38, 43, 47, 51, 55, 60, 64 };
        static Palette16 GeneratePalette16(Uint3 c1, Uint3 c2, int bits)
        {
            Palette16 palette = new Palette16();

            Uint3 a = Unquantize(c1, bits);
            Uint3 b = Unquantize(c2, bits);

            for (int i = 0; i < Weights16.Length; i++)
            {
                palette[i].R = FinishUnquantize((a.R * (64 - Weights16[i]) + b.R * Weights16[i] + 32) >> 6);
                palette[i].G = FinishUnquantize((a.G * (64 - Weights16[i]) + b.G * Weights16[i] + 32) >> 6);
                palette[i].B = FinishUnquantize((a.B * (64 - Weights16[i]) + b.B * Weights16[i] + 32) >> 6);
            }

            return palette;
        }

        static Uint3 Unquantize(Uint3 comp, int bits)
        {
            Uint3 unq;
            unq.R = Unquantize(comp.R, bits);
            unq.G = Unquantize(comp.G, bits);
            unq.B = Unquantize(comp.B, bits);
            return unq;

            static uint Unquantize(uint comp, int bits)
            {
                // We are assuming UF
                uint unq;
                if (bits >= 15)
                    unq = comp;
                else if (comp == 0)
                    unq = 0;
                else if (comp == ((1 << bits) - 1))
                    unq = 0xFFFF;
                else
                    unq = (uint)((((int)comp << 16) + 0x8000) >> bits);

                return unq;
            }
        }

        static ushort FinishUnquantize(uint comp)
        {
            // We assume UF
            Debug.Assert(((comp * 31) >> 6) == (((int)comp * 31) >> 6));
            comp = (comp * 31) >> 6;
            return (ushort)comp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static Uint3 SignExtend(Uint3 value, Uint3 bits)
        {
            Uint3 sxvalue;
            sxvalue.R = SignExtend(value.R, bits.R);
            sxvalue.G = SignExtend(value.G, bits.G);
            sxvalue.B = SignExtend(value.B, bits.B);
            return sxvalue;

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            static uint SignExtend(uint value, uint bits)
            {
                int shift = 32 - (int)bits;
                int svalue = (int)value;
                int sxvalue = ((svalue) << shift) >> shift;
                return (uint)sxvalue;
            }
        }
    }
}
