// This file is auto generated, do not edit.
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecVp9std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecVp9stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecsCommon;
using System;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    namespace VulkanVideoCodecAv1std
    {
        public static class Constants
        {
            public const uint VideoAv1NumRefFrames = 8;
            public const uint VideoAv1RefsPerFrame = 7;
            public const uint VideoAv1TotalRefsPerFrame = 8;
            public const uint VideoAv1MaxTileCols = 64;
            public const uint VideoAv1MaxTileRows = 64;
            public const uint VideoAv1MaxSegments = 8;
            public const uint VideoAv1SegLvlMax = 8;
            public const uint VideoAv1PrimaryRefNone = 7;
            public const uint VideoAv1SelectIntegerMv = 2;
            public const uint VideoAv1SelectScreenContentTools = 2;
            public const uint VideoAv1SkipModeFrames = 2;
            public const uint VideoAv1MaxLoopFilterStrengths = 4;
            public const uint VideoAv1LoopFilterAdjustments = 2;
            public const uint VideoAv1MaxCdefFilterStrengths = 8;
            public const uint VideoAv1MaxNumPlanes = 3;
            public const uint VideoAv1GlobalMotionParams = 6;
            public const uint VideoAv1MaxNumYPoints = 14;
            public const uint VideoAv1MaxNumCbPoints = 10;
            public const uint VideoAv1MaxNumCrPoints = 10;
            public const uint VideoAv1MaxNumPosLuma = 24;
            public const uint VideoAv1MaxNumPosChroma = 25;
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1Profile : uint
        {
            VideoAv1ProfileHigh = 1,
            VideoAv1ProfileInvalid = 2147483647,
            VideoAv1ProfileMain = 0,
            VideoAv1ProfileProfessional = 2,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1Level : uint
        {
            VideoAv1Level20 = 0,
            VideoAv1Level21 = 1,
            VideoAv1Level22 = 2,
            VideoAv1Level23 = 3,
            VideoAv1Level30 = 4,
            VideoAv1Level31 = 5,
            VideoAv1Level32 = 6,
            VideoAv1Level33 = 7,
            VideoAv1Level40 = 8,
            VideoAv1Level41 = 9,
            VideoAv1Level42 = 10,
            VideoAv1Level43 = 11,
            VideoAv1Level50 = 12,
            VideoAv1Level51 = 13,
            VideoAv1Level52 = 14,
            VideoAv1Level53 = 15,
            VideoAv1Level60 = 16,
            VideoAv1Level61 = 17,
            VideoAv1Level62 = 18,
            VideoAv1Level63 = 19,
            VideoAv1Level70 = 20,
            VideoAv1Level71 = 21,
            VideoAv1Level72 = 22,
            VideoAv1Level73 = 23,
            VideoAv1LevelInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1FrameType : uint
        {
            VideoAv1FrameTypeInter = 1,
            VideoAv1FrameTypeIntraOnly = 2,
            VideoAv1FrameTypeInvalid = 2147483647,
            VideoAv1FrameTypeKey = 0,
            VideoAv1FrameTypeSwitch = 3,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1ReferenceName : uint
        {
            VideoAv1ReferenceNameAltrefFrame = 7,
            VideoAv1ReferenceNameAltref2Frame = 6,
            VideoAv1ReferenceNameBwdrefFrame = 5,
            VideoAv1ReferenceNameGoldenFrame = 4,
            VideoAv1ReferenceNameIntraFrame = 0,
            VideoAv1ReferenceNameInvalid = 2147483647,
            VideoAv1ReferenceNameLastFrame = 1,
            VideoAv1ReferenceNameLast2Frame = 2,
            VideoAv1ReferenceNameLast3Frame = 3,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1InterpolationFilter : uint
        {
            VideoAv1InterpolationFilterBilinear = 3,
            VideoAv1InterpolationFilterEighttap = 0,
            VideoAv1InterpolationFilterEighttapSharp = 2,
            VideoAv1InterpolationFilterEighttapSmooth = 1,
            VideoAv1InterpolationFilterInvalid = 2147483647,
            VideoAv1InterpolationFilterSwitchable = 4,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1TxMode : uint
        {
            VideoAv1TxModeInvalid = 2147483647,
            VideoAv1TxModeLargest = 1,
            VideoAv1TxModeOnly4x4 = 0,
            VideoAv1TxModeSelect = 2,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1FrameRestorationType : uint
        {
            VideoAv1FrameRestorationTypeInvalid = 2147483647,
            VideoAv1FrameRestorationTypeNone = 0,
            VideoAv1FrameRestorationTypeSgrproj = 2,
            VideoAv1FrameRestorationTypeSwitchable = 3,
            VideoAv1FrameRestorationTypeWiener = 1,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1ColorPrimaries : uint
        {
            VideoAv1ColorPrimariesBt2020 = 9,
            VideoAv1ColorPrimariesBt470BG = 5,
            VideoAv1ColorPrimariesBt470M = 4,
            VideoAv1ColorPrimariesBt601 = 6,
            VideoAv1ColorPrimariesBt709 = 1,
            VideoAv1ColorPrimariesBtUnspecified = 2,
            VideoAv1ColorPrimariesEbu3213 = 22,
            VideoAv1ColorPrimariesGenericFilm = 8,
            VideoAv1ColorPrimariesInvalid = 2147483647,
            VideoAv1ColorPrimariesSmpte240 = 7,
            VideoAv1ColorPrimariesSmpte431 = 11,
            VideoAv1ColorPrimariesSmpte432 = 12,
            VideoAv1ColorPrimariesUnspecified = 2,
            VideoAv1ColorPrimariesXyz = 10,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1TransferCharacteristics : uint
        {
            VideoAv1TransferCharacteristicsBt1361 = 12,
            VideoAv1TransferCharacteristicsBt202010Bit = 14,
            VideoAv1TransferCharacteristicsBt202012Bit = 15,
            VideoAv1TransferCharacteristicsBt470BG = 5,
            VideoAv1TransferCharacteristicsBt470M = 4,
            VideoAv1TransferCharacteristicsBt601 = 6,
            VideoAv1TransferCharacteristicsBt709 = 1,
            VideoAv1TransferCharacteristicsHlg = 18,
            VideoAv1TransferCharacteristicsIec61966 = 11,
            VideoAv1TransferCharacteristicsInvalid = 2147483647,
            VideoAv1TransferCharacteristicsLinear = 8,
            VideoAv1TransferCharacteristicsLog100 = 9,
            VideoAv1TransferCharacteristicsLog100Sqrt10 = 10,
            VideoAv1TransferCharacteristicsReserved0 = 0,
            VideoAv1TransferCharacteristicsReserved3 = 3,
            VideoAv1TransferCharacteristicsSmpte2084 = 16,
            VideoAv1TransferCharacteristicsSmpte240 = 7,
            VideoAv1TransferCharacteristicsSmpte428 = 17,
            VideoAv1TransferCharacteristicsSrgb = 13,
            VideoAv1TransferCharacteristicsUnspecified = 2,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1MatrixCoefficients : uint
        {
            VideoAv1MatrixCoefficientsBt2020Cl = 10,
            VideoAv1MatrixCoefficientsBt2020Ncl = 9,
            VideoAv1MatrixCoefficientsBt470BG = 5,
            VideoAv1MatrixCoefficientsBt601 = 6,
            VideoAv1MatrixCoefficientsBt709 = 1,
            VideoAv1MatrixCoefficientsChromatCl = 13,
            VideoAv1MatrixCoefficientsChromatNcl = 12,
            VideoAv1MatrixCoefficientsFcc = 4,
            VideoAv1MatrixCoefficientsIctcp = 14,
            VideoAv1MatrixCoefficientsIdentity = 0,
            VideoAv1MatrixCoefficientsInvalid = 2147483647,
            VideoAv1MatrixCoefficientsReserved3 = 3,
            VideoAv1MatrixCoefficientsSmpte2085 = 11,
            VideoAv1MatrixCoefficientsSmpte240 = 7,
            VideoAv1MatrixCoefficientsSmpteYcgco = 8,
            VideoAv1MatrixCoefficientsUnspecified = 2,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public enum StdVideoAV1ChromaSamplePosition : uint
        {
            VideoAv1ChromaSamplePositionColocated = 2,
            VideoAv1ChromaSamplePositionInvalid = 2147483647,
            VideoAv1ChromaSamplePositionReserved = 3,
            VideoAv1ChromaSamplePositionUnknown = 0,
            VideoAv1ChromaSamplePositionVertical = 1,
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1ColorConfigFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint mono_chrome
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint color_range
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint separate_uv_delta_q
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint color_description_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFFu << 4)) | ((((uint)value) & 0xFFFFFFFu) << 4);
            }
            public StdVideoAV1ColorConfigFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1ColorConfig
        {
            /// <summary></summary>
            public StdVideoAV1ColorConfigFlags flags;
            /// <summary></summary>
            public byte BitDepth;
            /// <summary></summary>
            public byte subsampling_x;
            /// <summary></summary>
            public byte subsampling_y;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary></summary>
            public StdVideoAV1ColorPrimaries color_primaries;
            /// <summary></summary>
            public StdVideoAV1TransferCharacteristics transfer_characteristics;
            /// <summary></summary>
            public StdVideoAV1MatrixCoefficients matrix_coefficients;
            /// <summary></summary>
            public StdVideoAV1ChromaSamplePosition chroma_sample_position;
            public StdVideoAV1ColorConfig() { }
            public StdVideoAV1ColorConfig(StdVideoAV1ColorConfigFlags flags, byte BitDepth, byte subsampling_x, byte subsampling_y, byte reserved1, StdVideoAV1ColorPrimaries color_primaries, StdVideoAV1TransferCharacteristics transfer_characteristics, StdVideoAV1MatrixCoefficients matrix_coefficients, StdVideoAV1ChromaSamplePosition chroma_sample_position)
            {
                this.flags = flags;
                this.BitDepth = BitDepth;
                this.subsampling_x = subsampling_x;
                this.subsampling_y = subsampling_y;
                this.reserved1 = reserved1;
                this.color_primaries = color_primaries;
                this.transfer_characteristics = transfer_characteristics;
                this.matrix_coefficients = matrix_coefficients;
                this.chroma_sample_position = chroma_sample_position;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1TimingInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint equal_picture_interval
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoAV1TimingInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1TimingInfo
        {
            /// <summary></summary>
            public StdVideoAV1TimingInfoFlags flags;
            /// <summary></summary>
            public uint num_units_in_display_tick;
            /// <summary></summary>
            public uint time_scale;
            /// <summary></summary>
            public uint num_ticks_per_picture_minus_1;
            public StdVideoAV1TimingInfo() { }
            public StdVideoAV1TimingInfo(StdVideoAV1TimingInfoFlags flags, uint num_units_in_display_tick, uint time_scale, uint num_ticks_per_picture_minus_1)
            {
                this.flags = flags;
                this.num_units_in_display_tick = num_units_in_display_tick;
                this.time_scale = time_scale;
                this.num_ticks_per_picture_minus_1 = num_ticks_per_picture_minus_1;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1LoopFilterFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint loop_filter_delta_enabled
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint loop_filter_delta_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoAV1LoopFilterFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1LoopFilter
        {
            /// <summary></summary>
            public StdVideoAV1LoopFilterFlags flags;
            /// <summary></summary>
            public fixed byte loop_filter_level[4];
            /// <summary></summary>
            public byte loop_filter_sharpness;
            /// <summary></summary>
            public byte update_ref_delta;
            /// <summary></summary>
            public fixed sbyte loop_filter_ref_deltas[8];
            /// <summary></summary>
            public byte update_mode_delta;
            /// <summary></summary>
            public fixed sbyte loop_filter_mode_deltas[2];
            public StdVideoAV1LoopFilter() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1QuantizationFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint using_qmatrix
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint diff_uv_delta
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoAV1QuantizationFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1Quantization
        {
            /// <summary></summary>
            public StdVideoAV1QuantizationFlags flags;
            /// <summary></summary>
            public byte base_q_idx;
            /// <summary></summary>
            public sbyte DeltaQYDc;
            /// <summary></summary>
            public sbyte DeltaQUDc;
            /// <summary></summary>
            public sbyte DeltaQUAc;
            /// <summary></summary>
            public sbyte DeltaQVDc;
            /// <summary></summary>
            public sbyte DeltaQVAc;
            /// <summary></summary>
            public byte qm_y;
            /// <summary></summary>
            public byte qm_u;
            /// <summary></summary>
            public byte qm_v;
            public StdVideoAV1Quantization() { }
            public StdVideoAV1Quantization(StdVideoAV1QuantizationFlags flags, byte base_q_idx, sbyte DeltaQYDc, sbyte DeltaQUDc, sbyte DeltaQUAc, sbyte DeltaQVDc, sbyte DeltaQVAc, byte qm_y, byte qm_u, byte qm_v)
            {
                this.flags = flags;
                this.base_q_idx = base_q_idx;
                this.DeltaQYDc = DeltaQYDc;
                this.DeltaQUDc = DeltaQUDc;
                this.DeltaQUAc = DeltaQUAc;
                this.DeltaQVDc = DeltaQVDc;
                this.DeltaQVAc = DeltaQVAc;
                this.qm_y = qm_y;
                this.qm_u = qm_u;
                this.qm_v = qm_v;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1Segmentation
        {
            /// <summary>Each element contains 8 (SEG_LVL_MAX) bits, one bit for each feature within the segment</summary>
            public fixed byte FeatureEnabled[8];
            [InlineArray(8)]
            public struct FeatureDataInlineArray1
            {
                [InlineArray(8)]
                public struct FeatureDataInlineArray2
                {
                    public short element;
                }
                public FeatureDataInlineArray2 FeatureData;
            }
            public FeatureDataInlineArray1 FeatureData;
            public StdVideoAV1Segmentation() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1TileInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint uniform_tile_spacing_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoAV1TileInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1TileInfo
        {
            /// <summary></summary>
            public StdVideoAV1TileInfoFlags flags;
            /// <summary></summary>
            public byte TileCols;
            /// <summary></summary>
            public byte TileRows;
            /// <summary></summary>
            public ushort context_update_tile_id;
            /// <summary></summary>
            public byte tile_size_bytes_minus_1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved1[7];
            /// <summary>TileCols number of elements</summary>
            public ushort* pMiColStarts;
            /// <summary>TileRows number of elements</summary>
            public ushort* pMiRowStarts;
            /// <summary>TileCols number of elements</summary>
            public ushort* pWidthInSbsMinus1;
            /// <summary>TileRows number of elements</summary>
            public ushort* pHeightInSbsMinus1;
            public StdVideoAV1TileInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1CDEF
        {
            /// <summary></summary>
            public byte cdef_damping_minus_3;
            /// <summary></summary>
            public byte cdef_bits;
            /// <summary></summary>
            public fixed byte cdef_y_pri_strength[8];
            /// <summary></summary>
            public fixed byte cdef_y_sec_strength[8];
            /// <summary></summary>
            public fixed byte cdef_uv_pri_strength[8];
            /// <summary></summary>
            public fixed byte cdef_uv_sec_strength[8];
            public StdVideoAV1CDEF() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1LoopRestoration
        {
            [InlineArray(3)]
            public struct FrameRestorationTypeInlineArray1
            {
                public StdVideoAV1FrameRestorationType element;
            }
            /// <summary></summary>
            public FrameRestorationTypeInlineArray1 FrameRestorationType;
            /// <summary></summary>
            public fixed ushort LoopRestorationSize[3];
            public StdVideoAV1LoopRestoration() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1GlobalMotion
        {
            /// <summary></summary>
            public fixed byte GmType[8];
            [InlineArray(6)]
            public struct gm_paramsInlineArray1
            {
                [InlineArray(8)]
                public struct gm_paramsInlineArray2
                {
                    public int element;
                }
                public gm_paramsInlineArray2 gm_params;
            }
            public gm_paramsInlineArray1 gm_params;
            public StdVideoAV1GlobalMotion() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1FilmGrainFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint chroma_scaling_from_luma
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint overlap_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint clip_to_restricted_range
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint update_grain
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFFu << 4)) | ((((uint)value) & 0xFFFFFFFu) << 4);
            }
            public StdVideoAV1FilmGrainFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1FilmGrain
        {
            /// <summary></summary>
            public StdVideoAV1FilmGrainFlags flags;
            /// <summary></summary>
            public byte grain_scaling_minus_8;
            /// <summary></summary>
            public byte ar_coeff_lag;
            /// <summary></summary>
            public byte ar_coeff_shift_minus_6;
            /// <summary></summary>
            public byte grain_scale_shift;
            /// <summary></summary>
            public ushort grain_seed;
            /// <summary></summary>
            public byte film_grain_params_ref_idx;
            /// <summary></summary>
            public byte num_y_points;
            /// <summary></summary>
            public fixed byte point_y_value[14];
            /// <summary></summary>
            public fixed byte point_y_scaling[14];
            /// <summary></summary>
            public byte num_cb_points;
            /// <summary></summary>
            public fixed byte point_cb_value[10];
            /// <summary></summary>
            public fixed byte point_cb_scaling[10];
            /// <summary></summary>
            public byte num_cr_points;
            /// <summary></summary>
            public fixed byte point_cr_value[10];
            /// <summary></summary>
            public fixed byte point_cr_scaling[10];
            /// <summary></summary>
            public fixed sbyte ar_coeffs_y_plus_128[24];
            /// <summary></summary>
            public fixed sbyte ar_coeffs_cb_plus_128[25];
            /// <summary></summary>
            public fixed sbyte ar_coeffs_cr_plus_128[25];
            /// <summary></summary>
            public byte cb_mult;
            /// <summary></summary>
            public byte cb_luma_mult;
            /// <summary></summary>
            public ushort cb_offset;
            /// <summary></summary>
            public byte cr_mult;
            /// <summary></summary>
            public byte cr_luma_mult;
            /// <summary></summary>
            public ushort cr_offset;
            public StdVideoAV1FilmGrain() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1SequenceHeaderFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint still_picture
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint reduced_still_picture_header
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint use_128x128_superblock
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint enable_filter_intra
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint enable_intra_edge_filter
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint enable_interintra_compound
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint enable_masked_compound
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint enable_warped_motion
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint enable_dual_filter
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint enable_order_hint
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint enable_jnt_comp
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint enable_ref_frame_mvs
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint frame_id_numbers_present_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            /// <summary></summary>
            public uint enable_superres
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            /// <summary></summary>
            public uint enable_cdef
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            /// <summary></summary>
            public uint enable_restoration
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            /// <summary></summary>
            public uint film_grain_params_present
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            /// <summary></summary>
            public uint timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            /// <summary></summary>
            public uint initial_display_delay_present_flag
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 19) & 0x1FFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x1FFFu << 19)) | ((((uint)value) & 0x1FFFu) << 19);
            }
            public StdVideoAV1SequenceHeaderFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std]</b> </summary>
        public unsafe struct StdVideoAV1SequenceHeader
        {
            /// <summary></summary>
            public StdVideoAV1SequenceHeaderFlags flags;
            /// <summary></summary>
            public StdVideoAV1Profile seq_profile;
            /// <summary></summary>
            public byte frame_width_bits_minus_1;
            /// <summary></summary>
            public byte frame_height_bits_minus_1;
            /// <summary></summary>
            public ushort max_frame_width_minus_1;
            /// <summary></summary>
            public ushort max_frame_height_minus_1;
            /// <summary></summary>
            public byte delta_frame_id_length_minus_2;
            /// <summary></summary>
            public byte additional_frame_id_length_minus_1;
            /// <summary></summary>
            public byte order_hint_bits_minus_1;
            /// <summary>The final value of of seq_force_integer_mv per the value of seq_choose_integer_mv.</summary>
            public byte seq_force_integer_mv;
            /// <summary>The final value of of seq_force_screen_content_tools per the value of seq_choose_screen_content_tools.</summary>
            public byte seq_force_screen_content_tools;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved1[5];
            /// <summary></summary>
            public StdVideoAV1ColorConfig* pColorConfig;
            /// <summary></summary>
            public StdVideoAV1TimingInfo* pTimingInfo;
            public StdVideoAV1SequenceHeader() { }
        }
    }
    namespace VulkanVideoCodecAv1stdDecode
    {
        public static class Constants
        {
            /// <summary>&quot;VK_STD_vulkan_video_codec_av1_decode&quot;</summary>
            public static ReadOnlySpan<byte> StdVulkanVideoCodecAv1DecodeExtensionName => "VK_STD_vulkan_video_codec_av1_decode"u8;
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeAV1PictureInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint error_resilient_mode
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint disable_cdf_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint use_superres
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint render_and_frame_size_different
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint allow_screen_content_tools
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint is_filter_switchable
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint force_integer_mv
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint frame_size_override_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint buffer_removal_time_present_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint allow_intrabc
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint frame_refs_short_signaling
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint allow_high_precision_mv
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint is_motion_mode_switchable
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            /// <summary></summary>
            public uint use_ref_frame_mvs
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            /// <summary></summary>
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            /// <summary></summary>
            public uint allow_warped_motion
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            /// <summary></summary>
            public uint reduced_tx_set
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            /// <summary></summary>
            public uint reference_select
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            /// <summary></summary>
            public uint skip_mode_present
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            /// <summary></summary>
            public uint delta_q_present
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            /// <summary></summary>
            public uint delta_lf_present
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            /// <summary></summary>
            public uint delta_lf_multi
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            /// <summary></summary>
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            /// <summary></summary>
            public uint segmentation_update_map
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            /// <summary></summary>
            public uint segmentation_temporal_update
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            /// <summary></summary>
            public uint segmentation_update_data
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            /// <summary></summary>
            public uint UsesLr
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            /// <summary></summary>
            public uint usesChromaLr
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            /// <summary></summary>
            public uint apply_grain
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 29) & 0x7u);
                set => _bitfield0 = (_bitfield0 & ~(0x7u << 29)) | ((((uint)value) & 0x7u) << 29);
            }
            public StdVideoDecodeAV1PictureInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeAV1PictureInfo
        {
            /// <summary></summary>
            public StdVideoDecodeAV1PictureInfoFlags flags;
            /// <summary></summary>
            public StdVideoAV1FrameType frame_type;
            /// <summary></summary>
            public uint current_frame_id;
            /// <summary></summary>
            public byte OrderHint;
            /// <summary></summary>
            public byte primary_ref_frame;
            /// <summary></summary>
            public byte refresh_frame_flags;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary></summary>
            public StdVideoAV1InterpolationFilter interpolation_filter;
            /// <summary></summary>
            public StdVideoAV1TxMode TxMode;
            /// <summary></summary>
            public byte delta_q_res;
            /// <summary></summary>
            public byte delta_lf_res;
            /// <summary></summary>
            public fixed byte SkipModeFrame[2];
            /// <summary></summary>
            public byte coded_denom;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved2[3];
            /// <summary></summary>
            public fixed byte OrderHints[8];
            /// <summary></summary>
            public fixed uint expectedFrameId[8];
            /// <summary></summary>
            public StdVideoAV1TileInfo* pTileInfo;
            /// <summary></summary>
            public StdVideoAV1Quantization* pQuantization;
            /// <summary></summary>
            public StdVideoAV1Segmentation* pSegmentation;
            /// <summary></summary>
            public StdVideoAV1LoopFilter* pLoopFilter;
            /// <summary></summary>
            public StdVideoAV1CDEF* pCDEF;
            /// <summary></summary>
            public StdVideoAV1LoopRestoration* pLoopRestoration;
            /// <summary></summary>
            public StdVideoAV1GlobalMotion* pGlobalMotion;
            /// <summary></summary>
            public StdVideoAV1FilmGrain* pFilmGrain;
            public StdVideoDecodeAV1PictureInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeAV1ReferenceInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoDecodeAV1ReferenceInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeAV1ReferenceInfo
        {
            /// <summary></summary>
            public StdVideoDecodeAV1ReferenceInfoFlags flags;
            /// <summary></summary>
            public byte frame_type;
            /// <summary></summary>
            public byte RefFrameSignBias;
            /// <summary></summary>
            public byte OrderHint;
            /// <summary></summary>
            public fixed byte SavedOrderHints[8];
            public StdVideoDecodeAV1ReferenceInfo() { }
        }
    }
    namespace VulkanVideoCodecAv1stdEncode
    {
        public static class Constants
        {
            /// <summary>&quot;VK_STD_vulkan_video_codec_av1_encode&quot;</summary>
            public static ReadOnlySpan<byte> StdVulkanVideoCodecAv1EncodeExtensionName => "VK_STD_vulkan_video_codec_av1_encode"u8;
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1DecoderModelInfo
        {
            /// <summary></summary>
            public byte buffer_delay_length_minus_1;
            /// <summary></summary>
            public byte buffer_removal_time_length_minus_1;
            /// <summary></summary>
            public byte frame_presentation_time_length_minus_1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary></summary>
            public uint num_units_in_decoding_tick;
            public StdVideoEncodeAV1DecoderModelInfo() { }
            public StdVideoEncodeAV1DecoderModelInfo(byte buffer_delay_length_minus_1, byte buffer_removal_time_length_minus_1, byte frame_presentation_time_length_minus_1, byte reserved1, uint num_units_in_decoding_tick)
            {
                this.buffer_delay_length_minus_1 = buffer_delay_length_minus_1;
                this.buffer_removal_time_length_minus_1 = buffer_removal_time_length_minus_1;
                this.frame_presentation_time_length_minus_1 = frame_presentation_time_length_minus_1;
                this.reserved1 = reserved1;
                this.num_units_in_decoding_tick = num_units_in_decoding_tick;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1ExtensionHeader
        {
            /// <summary></summary>
            public byte temporal_id;
            /// <summary></summary>
            public byte spatial_id;
            public StdVideoEncodeAV1ExtensionHeader() { }
            public StdVideoEncodeAV1ExtensionHeader(byte temporal_id, byte spatial_id)
            {
                this.temporal_id = temporal_id;
                this.spatial_id = spatial_id;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1OperatingPointInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint decoder_model_present_for_this_op
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint low_delay_mode_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint initial_display_delay_present_for_this_op
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 3) & 0x1FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x1FFFFFFFu << 3)) | ((((uint)value) & 0x1FFFFFFFu) << 3);
            }
            public StdVideoEncodeAV1OperatingPointInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1OperatingPointInfo
        {
            /// <summary></summary>
            public StdVideoEncodeAV1OperatingPointInfoFlags flags;
            /// <summary></summary>
            public ushort operating_point_idc;
            /// <summary></summary>
            public byte seq_level_idx;
            /// <summary></summary>
            public byte seq_tier;
            /// <summary></summary>
            public uint decoder_buffer_delay;
            /// <summary></summary>
            public uint encoder_buffer_delay;
            /// <summary></summary>
            public byte initial_display_delay_minus_1;
            public StdVideoEncodeAV1OperatingPointInfo() { }
            public StdVideoEncodeAV1OperatingPointInfo(StdVideoEncodeAV1OperatingPointInfoFlags flags, ushort operating_point_idc, byte seq_level_idx, byte seq_tier, uint decoder_buffer_delay, uint encoder_buffer_delay, byte initial_display_delay_minus_1)
            {
                this.flags = flags;
                this.operating_point_idc = operating_point_idc;
                this.seq_level_idx = seq_level_idx;
                this.seq_tier = seq_tier;
                this.decoder_buffer_delay = decoder_buffer_delay;
                this.encoder_buffer_delay = encoder_buffer_delay;
                this.initial_display_delay_minus_1 = initial_display_delay_minus_1;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1PictureInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint error_resilient_mode
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint disable_cdf_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint use_superres
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint render_and_frame_size_different
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint allow_screen_content_tools
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint is_filter_switchable
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint force_integer_mv
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint frame_size_override_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint buffer_removal_time_present_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint allow_intrabc
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint frame_refs_short_signaling
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint allow_high_precision_mv
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint is_motion_mode_switchable
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            /// <summary></summary>
            public uint use_ref_frame_mvs
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            /// <summary></summary>
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            /// <summary></summary>
            public uint allow_warped_motion
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            /// <summary></summary>
            public uint reduced_tx_set
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            /// <summary></summary>
            public uint skip_mode_present
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            /// <summary></summary>
            public uint delta_q_present
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            /// <summary></summary>
            public uint delta_lf_present
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            /// <summary></summary>
            public uint delta_lf_multi
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            /// <summary></summary>
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            /// <summary></summary>
            public uint segmentation_update_map
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            /// <summary></summary>
            public uint segmentation_temporal_update
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            /// <summary></summary>
            public uint segmentation_update_data
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            /// <summary></summary>
            public uint UsesLr
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            /// <summary></summary>
            public uint usesChromaLr
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            /// <summary></summary>
            public uint show_frame
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            /// <summary></summary>
            public uint showable_frame
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 29) & 0x7u);
                set => _bitfield0 = (_bitfield0 & ~(0x7u << 29)) | ((((uint)value) & 0x7u) << 29);
            }
            public StdVideoEncodeAV1PictureInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1PictureInfo
        {
            /// <summary></summary>
            public StdVideoEncodeAV1PictureInfoFlags flags;
            /// <summary></summary>
            public StdVideoAV1FrameType frame_type;
            /// <summary></summary>
            public uint frame_presentation_time;
            /// <summary></summary>
            public uint current_frame_id;
            /// <summary></summary>
            public byte order_hint;
            /// <summary></summary>
            public byte primary_ref_frame;
            /// <summary></summary>
            public byte refresh_frame_flags;
            /// <summary></summary>
            public byte coded_denom;
            /// <summary></summary>
            public ushort render_width_minus_1;
            /// <summary></summary>
            public ushort render_height_minus_1;
            /// <summary></summary>
            public StdVideoAV1InterpolationFilter interpolation_filter;
            /// <summary></summary>
            public StdVideoAV1TxMode TxMode;
            /// <summary></summary>
            public byte delta_q_res;
            /// <summary></summary>
            public byte delta_lf_res;
            /// <summary></summary>
            public fixed byte ref_order_hint[8];
            /// <summary></summary>
            public fixed sbyte ref_frame_idx[7];
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved1[3];
            /// <summary></summary>
            public fixed uint delta_frame_id_minus_1[7];
            /// <summary></summary>
            public StdVideoAV1TileInfo* pTileInfo;
            /// <summary></summary>
            public StdVideoAV1Quantization* pQuantization;
            /// <summary></summary>
            public StdVideoAV1Segmentation* pSegmentation;
            /// <summary></summary>
            public StdVideoAV1LoopFilter* pLoopFilter;
            /// <summary></summary>
            public StdVideoAV1CDEF* pCDEF;
            /// <summary></summary>
            public StdVideoAV1LoopRestoration* pLoopRestoration;
            /// <summary></summary>
            public StdVideoAV1GlobalMotion* pGlobalMotion;
            /// <summary></summary>
            public StdVideoEncodeAV1ExtensionHeader* pExtensionHeader;
            /// <summary></summary>
            public uint* pBufferRemovalTimes;
            public StdVideoEncodeAV1PictureInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1ReferenceInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeAV1ReferenceInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeAV1ReferenceInfo
        {
            /// <summary></summary>
            public StdVideoEncodeAV1ReferenceInfoFlags flags;
            /// <summary></summary>
            public uint RefFrameId;
            /// <summary></summary>
            public StdVideoAV1FrameType frame_type;
            /// <summary></summary>
            public byte OrderHint;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved1[3];
            /// <summary></summary>
            public StdVideoEncodeAV1ExtensionHeader* pExtensionHeader;
            public StdVideoEncodeAV1ReferenceInfo() { }
        }
    }
    namespace VulkanVideoCodecH264std
    {
        public static class Constants
        {
            public const uint VideoH264CpbCntListSize = 32;
            public const uint VideoH264ScalingList4x4NumLists = 6;
            public const uint VideoH264ScalingList4x4NumElements = 16;
            public const uint VideoH264ScalingList8x8NumLists = 6;
            public const uint VideoH264ScalingList8x8NumElements = 64;
            public const uint VideoH264MaxNumListRef = 32;
            public const uint VideoH264MaxChromaPlanes = 2;
            public const uint VideoH264NoReferencePicture = 255;
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264ChromaFormatIdc : uint
        {
            VideoH264ChromaFormatIdc420 = 1,
            VideoH264ChromaFormatIdc422 = 2,
            VideoH264ChromaFormatIdc444 = 3,
            VideoH264ChromaFormatIdcInvalid = 2147483647,
            VideoH264ChromaFormatIdcMonochrome = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264ProfileIdc : uint
        {
            /// <summary>Only constrained baseline is supported</summary>
            VideoH264ProfileIdcBaseline = 66,
            VideoH264ProfileIdcHigh = 100,
            VideoH264ProfileIdcHigh444Predictive = 244,
            VideoH264ProfileIdcInvalid = 2147483647,
            VideoH264ProfileIdcMain = 77,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264LevelIdc : uint
        {
            VideoH264LevelIdc10 = 0,
            VideoH264LevelIdc11 = 1,
            VideoH264LevelIdc12 = 2,
            VideoH264LevelIdc13 = 3,
            VideoH264LevelIdc20 = 4,
            VideoH264LevelIdc21 = 5,
            VideoH264LevelIdc22 = 6,
            VideoH264LevelIdc30 = 7,
            VideoH264LevelIdc31 = 8,
            VideoH264LevelIdc32 = 9,
            VideoH264LevelIdc40 = 10,
            VideoH264LevelIdc41 = 11,
            VideoH264LevelIdc42 = 12,
            VideoH264LevelIdc50 = 13,
            VideoH264LevelIdc51 = 14,
            VideoH264LevelIdc52 = 15,
            VideoH264LevelIdc60 = 16,
            VideoH264LevelIdc61 = 17,
            VideoH264LevelIdc62 = 18,
            VideoH264LevelIdcInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264PocType : uint
        {
            VideoH264PocType0 = 0,
            VideoH264PocType1 = 1,
            VideoH264PocType2 = 2,
            VideoH264PocTypeInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264AspectRatioIdc : uint
        {
            VideoH264AspectRatioIdc1011 = 3,
            VideoH264AspectRatioIdc1211 = 2,
            VideoH264AspectRatioIdc1511 = 11,
            VideoH264AspectRatioIdc1611 = 4,
            VideoH264AspectRatioIdc16099 = 13,
            VideoH264AspectRatioIdc1811 = 10,
            VideoH264AspectRatioIdc21 = 16,
            VideoH264AspectRatioIdc2011 = 7,
            VideoH264AspectRatioIdc2411 = 6,
            VideoH264AspectRatioIdc32 = 15,
            VideoH264AspectRatioIdc3211 = 8,
            VideoH264AspectRatioIdc43 = 14,
            VideoH264AspectRatioIdc4033 = 5,
            VideoH264AspectRatioIdc6433 = 12,
            VideoH264AspectRatioIdc8033 = 9,
            VideoH264AspectRatioIdcExtendedSar = 255,
            VideoH264AspectRatioIdcInvalid = 2147483647,
            VideoH264AspectRatioIdcSquare = 1,
            VideoH264AspectRatioIdcUnspecified = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264WeightedBipredIdc : uint
        {
            VideoH264WeightedBipredIdcDefault = 0,
            VideoH264WeightedBipredIdcExplicit = 1,
            VideoH264WeightedBipredIdcImplicit = 2,
            VideoH264WeightedBipredIdcInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264ModificationOfPicNumsIdc : uint
        {
            VideoH264ModificationOfPicNumsIdcEnd = 3,
            VideoH264ModificationOfPicNumsIdcInvalid = 2147483647,
            VideoH264ModificationOfPicNumsIdcLongTerm = 2,
            VideoH264ModificationOfPicNumsIdcShortTermAdd = 1,
            VideoH264ModificationOfPicNumsIdcShortTermSubtract = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264MemMgmtControlOp : uint
        {
            VideoH264MemMgmtControlOpEnd = 0,
            VideoH264MemMgmtControlOpInvalid = 2147483647,
            VideoH264MemMgmtControlOpMarkCurrentAsLongTerm = 6,
            VideoH264MemMgmtControlOpMarkLongTerm = 3,
            VideoH264MemMgmtControlOpSetMaxLongTermIndex = 4,
            VideoH264MemMgmtControlOpUnmarkAll = 5,
            VideoH264MemMgmtControlOpUnmarkLongTerm = 2,
            VideoH264MemMgmtControlOpUnmarkShortTerm = 1,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264CabacInitIdc : uint
        {
            VideoH264CabacInitIdc0 = 0,
            VideoH264CabacInitIdc1 = 1,
            VideoH264CabacInitIdc2 = 2,
            VideoH264CabacInitIdcInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264DisableDeblockingFilterIdc : uint
        {
            VideoH264DisableDeblockingFilterIdcDisabled = 0,
            VideoH264DisableDeblockingFilterIdcEnabled = 1,
            VideoH264DisableDeblockingFilterIdcInvalid = 2147483647,
            VideoH264DisableDeblockingFilterIdcPartial = 2,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264SliceType : uint
        {
            VideoH264SliceTypeB = 1,
            VideoH264SliceTypeI = 2,
            VideoH264SliceTypeInvalid = 2147483647,
            VideoH264SliceTypeP = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264PictureType : uint
        {
            VideoH264PictureTypeB = 1,
            VideoH264PictureTypeI = 2,
            VideoH264PictureTypeIdr = 5,
            VideoH264PictureTypeInvalid = 2147483647,
            VideoH264PictureTypeP = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public enum StdVideoH264NonVclNaluType : uint
        {
            VideoH264NonVclNaluTypeAud = 2,
            VideoH264NonVclNaluTypeEndOfSequence = 4,
            VideoH264NonVclNaluTypeEndOfStream = 5,
            VideoH264NonVclNaluTypeInvalid = 2147483647,
            VideoH264NonVclNaluTypePps = 1,
            VideoH264NonVclNaluTypePrecoded = 6,
            VideoH264NonVclNaluTypePrefix = 3,
            VideoH264NonVclNaluTypeSps = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264SpsVuiFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint aspect_ratio_info_present_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint overscan_info_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint overscan_appropriate_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint video_signal_type_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint video_full_range_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint color_description_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint chroma_loc_info_present_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint fixed_frame_rate_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint bitstream_restriction_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint nal_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint vcl_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public StdVideoH264SpsVuiFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264HrdParameters
        {
            /// <summary></summary>
            public byte cpb_cnt_minus1;
            /// <summary></summary>
            public byte bit_rate_scale;
            /// <summary></summary>
            public byte cpb_size_scale;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary>cpb_cnt_minus1 number of valid elements</summary>
            public fixed uint bit_rate_value_minus1[32];
            /// <summary>cpb_cnt_minus1 number of valid elements</summary>
            public fixed uint cpb_size_value_minus1[32];
            /// <summary>cpb_cnt_minus1 number of valid elements</summary>
            public fixed byte cbr_flag[32];
            /// <summary></summary>
            public uint initial_cpb_removal_delay_length_minus1;
            /// <summary></summary>
            public uint cpb_removal_delay_length_minus1;
            /// <summary></summary>
            public uint dpb_output_delay_length_minus1;
            /// <summary></summary>
            public uint time_offset_length;
            public StdVideoH264HrdParameters() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264SequenceParameterSetVui
        {
            /// <summary></summary>
            public StdVideoH264SpsVuiFlags flags;
            /// <summary></summary>
            public StdVideoH264AspectRatioIdc aspect_ratio_idc;
            /// <summary></summary>
            public ushort sar_width;
            /// <summary></summary>
            public ushort sar_height;
            /// <summary></summary>
            public byte video_format;
            /// <summary></summary>
            public byte colour_primaries;
            /// <summary></summary>
            public byte transfer_characteristics;
            /// <summary></summary>
            public byte matrix_coefficients;
            /// <summary></summary>
            public uint num_units_in_tick;
            /// <summary></summary>
            public uint time_scale;
            /// <summary></summary>
            public byte max_num_reorder_frames;
            /// <summary></summary>
            public byte max_dec_frame_buffering;
            /// <summary></summary>
            public byte chroma_sample_loc_type_top_field;
            /// <summary></summary>
            public byte chroma_sample_loc_type_bottom_field;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public uint reserved1;
            /// <summary>must be a valid ptr to hrd_parameters, if nal_hrd_parameters_present_flag or vcl_hrd_parameters_present_flag are set</summary>
            public StdVideoH264HrdParameters* pHrdParameters;
            public StdVideoH264SequenceParameterSetVui() { }
            public StdVideoH264SequenceParameterSetVui(StdVideoH264SpsVuiFlags flags, StdVideoH264AspectRatioIdc aspect_ratio_idc, ushort sar_width, ushort sar_height, byte video_format, byte colour_primaries, byte transfer_characteristics, byte matrix_coefficients, uint num_units_in_tick, uint time_scale, byte max_num_reorder_frames, byte max_dec_frame_buffering, byte chroma_sample_loc_type_top_field, byte chroma_sample_loc_type_bottom_field, uint reserved1, StdVideoH264HrdParameters* pHrdParameters)
            {
                this.flags = flags;
                this.aspect_ratio_idc = aspect_ratio_idc;
                this.sar_width = sar_width;
                this.sar_height = sar_height;
                this.video_format = video_format;
                this.colour_primaries = colour_primaries;
                this.transfer_characteristics = transfer_characteristics;
                this.matrix_coefficients = matrix_coefficients;
                this.num_units_in_tick = num_units_in_tick;
                this.time_scale = time_scale;
                this.max_num_reorder_frames = max_num_reorder_frames;
                this.max_dec_frame_buffering = max_dec_frame_buffering;
                this.chroma_sample_loc_type_top_field = chroma_sample_loc_type_top_field;
                this.chroma_sample_loc_type_bottom_field = chroma_sample_loc_type_bottom_field;
                this.reserved1 = reserved1;
                this.pHrdParameters = pHrdParameters;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264SpsFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint constraint_set0_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint constraint_set1_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint constraint_set2_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint constraint_set3_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint constraint_set4_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint constraint_set5_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint direct_8x8_inference_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint mb_adaptive_frame_field_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint frame_mbs_only_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint delta_pic_order_always_zero_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint separate_colour_plane_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint gaps_in_frame_num_value_allowed_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint qpprime_y_zero_transform_bypass_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            /// <summary></summary>
            public uint frame_cropping_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            /// <summary></summary>
            public uint seq_scaling_matrix_present_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            /// <summary></summary>
            public uint vui_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public StdVideoH264SpsFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264ScalingLists
        {
            /// <summary></summary>
            public ushort scaling_list_present_mask;
            /// <summary></summary>
            public ushort use_default_scaling_matrix_mask;
            [InlineArray(16)]
            public struct ScalingList4x4InlineArray1
            {
                [InlineArray(6)]
                public struct ScalingList4x4InlineArray2
                {
                    public byte element;
                }
                public ScalingList4x4InlineArray2 ScalingList4x4;
            }
            public ScalingList4x4InlineArray1 ScalingList4x4;
            [InlineArray(64)]
            public struct ScalingList8x8InlineArray1
            {
                [InlineArray(6)]
                public struct ScalingList8x8InlineArray2
                {
                    public byte element;
                }
                public ScalingList8x8InlineArray2 ScalingList8x8;
            }
            public ScalingList8x8InlineArray1 ScalingList8x8;
            public StdVideoH264ScalingLists() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264SequenceParameterSet
        {
            /// <summary></summary>
            public StdVideoH264SpsFlags flags;
            /// <summary></summary>
            public StdVideoH264ProfileIdc profile_idc;
            /// <summary></summary>
            public StdVideoH264LevelIdc level_idc;
            /// <summary></summary>
            public StdVideoH264ChromaFormatIdc chroma_format_idc;
            /// <summary></summary>
            public byte seq_parameter_set_id;
            /// <summary></summary>
            public byte bit_depth_luma_minus8;
            /// <summary></summary>
            public byte bit_depth_chroma_minus8;
            /// <summary></summary>
            public byte log2_max_frame_num_minus4;
            /// <summary></summary>
            public StdVideoH264PocType pic_order_cnt_type;
            /// <summary></summary>
            public int offset_for_non_ref_pic;
            /// <summary></summary>
            public int offset_for_top_to_bottom_field;
            /// <summary></summary>
            public byte log2_max_pic_order_cnt_lsb_minus4;
            /// <summary></summary>
            public byte num_ref_frames_in_pic_order_cnt_cycle;
            /// <summary></summary>
            public byte max_num_ref_frames;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary></summary>
            public uint pic_width_in_mbs_minus1;
            /// <summary></summary>
            public uint pic_height_in_map_units_minus1;
            /// <summary></summary>
            public uint frame_crop_left_offset;
            /// <summary></summary>
            public uint frame_crop_right_offset;
            /// <summary></summary>
            public uint frame_crop_top_offset;
            /// <summary></summary>
            public uint frame_crop_bottom_offset;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public uint reserved2;
            /// <summary></summary>
            public int* pOffsetForRefFrame;
            /// <summary>Must be a valid pointer if seq_scaling_matrix_present_flag is set</summary>
            public StdVideoH264ScalingLists* pScalingLists;
            /// <summary>Must be a valid pointer if StdVideoH264SpsFlags:vui_parameters_present_flag is set</summary>
            public StdVideoH264SequenceParameterSetVui* pSequenceParameterSetVui;
            public StdVideoH264SequenceParameterSet() { }
            public StdVideoH264SequenceParameterSet(StdVideoH264SpsFlags flags, StdVideoH264ProfileIdc profile_idc, StdVideoH264LevelIdc level_idc, StdVideoH264ChromaFormatIdc chroma_format_idc, byte seq_parameter_set_id, byte bit_depth_luma_minus8, byte bit_depth_chroma_minus8, byte log2_max_frame_num_minus4, StdVideoH264PocType pic_order_cnt_type, int offset_for_non_ref_pic, int offset_for_top_to_bottom_field, byte log2_max_pic_order_cnt_lsb_minus4, byte num_ref_frames_in_pic_order_cnt_cycle, byte max_num_ref_frames, byte reserved1, uint pic_width_in_mbs_minus1, uint pic_height_in_map_units_minus1, uint frame_crop_left_offset, uint frame_crop_right_offset, uint frame_crop_top_offset, uint frame_crop_bottom_offset, uint reserved2, int* pOffsetForRefFrame, StdVideoH264ScalingLists* pScalingLists, StdVideoH264SequenceParameterSetVui* pSequenceParameterSetVui)
            {
                this.flags = flags;
                this.profile_idc = profile_idc;
                this.level_idc = level_idc;
                this.chroma_format_idc = chroma_format_idc;
                this.seq_parameter_set_id = seq_parameter_set_id;
                this.bit_depth_luma_minus8 = bit_depth_luma_minus8;
                this.bit_depth_chroma_minus8 = bit_depth_chroma_minus8;
                this.log2_max_frame_num_minus4 = log2_max_frame_num_minus4;
                this.pic_order_cnt_type = pic_order_cnt_type;
                this.offset_for_non_ref_pic = offset_for_non_ref_pic;
                this.offset_for_top_to_bottom_field = offset_for_top_to_bottom_field;
                this.log2_max_pic_order_cnt_lsb_minus4 = log2_max_pic_order_cnt_lsb_minus4;
                this.num_ref_frames_in_pic_order_cnt_cycle = num_ref_frames_in_pic_order_cnt_cycle;
                this.max_num_ref_frames = max_num_ref_frames;
                this.reserved1 = reserved1;
                this.pic_width_in_mbs_minus1 = pic_width_in_mbs_minus1;
                this.pic_height_in_map_units_minus1 = pic_height_in_map_units_minus1;
                this.frame_crop_left_offset = frame_crop_left_offset;
                this.frame_crop_right_offset = frame_crop_right_offset;
                this.frame_crop_top_offset = frame_crop_top_offset;
                this.frame_crop_bottom_offset = frame_crop_bottom_offset;
                this.reserved2 = reserved2;
                this.pOffsetForRefFrame = pOffsetForRefFrame;
                this.pScalingLists = pScalingLists;
                this.pSequenceParameterSetVui = pSequenceParameterSetVui;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264PpsFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint transform_8x8_mode_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint redundant_pic_cnt_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint constrained_intra_pred_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint deblocking_filter_control_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint weighted_pred_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint bottom_field_pic_order_in_frame_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint entropy_coding_mode_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint pic_scaling_matrix_present_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public StdVideoH264PpsFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std]</b> </summary>
        public unsafe struct StdVideoH264PictureParameterSet
        {
            /// <summary></summary>
            public StdVideoH264PpsFlags flags;
            /// <summary></summary>
            public byte seq_parameter_set_id;
            /// <summary></summary>
            public byte pic_parameter_set_id;
            /// <summary></summary>
            public byte num_ref_idx_l0_default_active_minus1;
            /// <summary></summary>
            public byte num_ref_idx_l1_default_active_minus1;
            /// <summary></summary>
            public StdVideoH264WeightedBipredIdc weighted_bipred_idc;
            /// <summary></summary>
            public sbyte pic_init_qp_minus26;
            /// <summary></summary>
            public sbyte pic_init_qs_minus26;
            /// <summary></summary>
            public sbyte chroma_qp_index_offset;
            /// <summary></summary>
            public sbyte second_chroma_qp_index_offset;
            /// <summary>Must be a valid pointer if StdVideoH264PpsFlags::pic_scaling_matrix_present_flag is set.</summary>
            public StdVideoH264ScalingLists* pScalingLists;
            public StdVideoH264PictureParameterSet() { }
            public StdVideoH264PictureParameterSet(StdVideoH264PpsFlags flags, byte seq_parameter_set_id, byte pic_parameter_set_id, byte num_ref_idx_l0_default_active_minus1, byte num_ref_idx_l1_default_active_minus1, StdVideoH264WeightedBipredIdc weighted_bipred_idc, sbyte pic_init_qp_minus26, sbyte pic_init_qs_minus26, sbyte chroma_qp_index_offset, sbyte second_chroma_qp_index_offset, StdVideoH264ScalingLists* pScalingLists)
            {
                this.flags = flags;
                this.seq_parameter_set_id = seq_parameter_set_id;
                this.pic_parameter_set_id = pic_parameter_set_id;
                this.num_ref_idx_l0_default_active_minus1 = num_ref_idx_l0_default_active_minus1;
                this.num_ref_idx_l1_default_active_minus1 = num_ref_idx_l1_default_active_minus1;
                this.weighted_bipred_idc = weighted_bipred_idc;
                this.pic_init_qp_minus26 = pic_init_qp_minus26;
                this.pic_init_qs_minus26 = pic_init_qs_minus26;
                this.chroma_qp_index_offset = chroma_qp_index_offset;
                this.second_chroma_qp_index_offset = second_chroma_qp_index_offset;
                this.pScalingLists = pScalingLists;
            }
        }
    }
    namespace VulkanVideoCodecH264stdDecode
    {
        public static class Constants
        {
            /// <summary>&quot;VK_STD_vulkan_video_codec_h264_decode&quot;</summary>
            public static ReadOnlySpan<byte> StdVulkanVideoCodecH264DecodeExtensionName => "VK_STD_vulkan_video_codec_h264_decode"u8;
            public const uint VideoDecodeH264FieldOrderCountListSize = 2;
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_decode]</b> </summary>
        public enum StdVideoDecodeH264FieldOrderCount : uint
        {
            VideoDecodeH264FieldOrderCountBottom = 1,
            VideoDecodeH264FieldOrderCountInvalid = 2147483647,
            VideoDecodeH264FieldOrderCountTop = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH264PictureInfoFlags
        {
            private uint _bitfield0;
            /// <summary>Is field picture</summary>
            public uint field_pic_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary>Is intra picture</summary>
            public uint is_intra
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary>instantaneous decoding refresh (IDR) picture</summary>
            public uint IdrPicFlag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary>bottom (true) or top (false) field if field_pic_flag is set.</summary>
            public uint bottom_field_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary>This only applies to picture info, and not to the DPB lists.</summary>
            public uint is_reference
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary>complementary field pair, complementary non-reference field pair, complementary reference field pair</summary>
            public uint complementary_field_pair
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public StdVideoDecodeH264PictureInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH264PictureInfo
        {
            /// <summary></summary>
            public StdVideoDecodeH264PictureInfoFlags flags;
            /// <summary>Selecting SPS id from the Sequence Parameters Set</summary>
            public byte seq_parameter_set_id;
            /// <summary>Selecting PPS id from the Picture Parameters Set</summary>
            public byte pic_parameter_set_id;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved2;
            /// <summary>7.4.3 Slice header semantics</summary>
            public ushort frame_num;
            /// <summary>7.4.3 Slice header semantics</summary>
            public ushort idr_pic_id;
            /// <summary>TopFieldOrderCnt and BottomFieldOrderCnt fields.</summary>
            public fixed int PicOrderCnt[2];
            public StdVideoDecodeH264PictureInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH264ReferenceInfoFlags
        {
            private uint _bitfield0;
            /// <summary>Reference is used for top field reference.</summary>
            public uint top_field_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary>Reference is used for bottom field reference.</summary>
            public uint bottom_field_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary>A picture that is marked as "used for long-term reference", derived binary value from clause 8.2.5.1 Sequence of operations for decoded reference picture marking process</summary>
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary>Must be handled in accordance with 8.2.5.2: Decoding process for gaps in frame_num</summary>
            public uint is_non_existing
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public StdVideoDecodeH264ReferenceInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH264ReferenceInfo
        {
            /// <summary></summary>
            public StdVideoDecodeH264ReferenceInfoFlags flags;
            /// <summary>7.4.3.3 Decoded reference picture marking semantics</summary>
            public ushort FrameNum;
            /// <summary>for structure members 32-bit packing/alignment</summary>
            public ushort reserved;
            /// <summary>TopFieldOrderCnt and BottomFieldOrderCnt fields.</summary>
            public fixed int PicOrderCnt[2];
            public StdVideoDecodeH264ReferenceInfo() { }
        }
    }
    namespace VulkanVideoCodecH264stdEncode
    {
        public static class Constants
        {
            /// <summary>&quot;VK_STD_vulkan_video_codec_h264_encode&quot;</summary>
            public static ReadOnlySpan<byte> StdVulkanVideoCodecH264EncodeExtensionName => "VK_STD_vulkan_video_codec_h264_encode"u8;
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264WeightTableFlags
        {
            /// <summary>each bit n represents the nth entry in reference list l0, n <= num_ref_idx_l0_active_minus1</summary>
            public uint luma_weight_l0_flag;
            /// <summary>each bit n represents the nth entry in reference list l0, n <= num_ref_idx_l0_active_minus1</summary>
            public uint chroma_weight_l0_flag;
            /// <summary>each bit n represents the nth entry in reference list l1, n <= num_ref_idx_l1_active_minus1</summary>
            public uint luma_weight_l1_flag;
            /// <summary>each bit n represents the nth entry in reference list l1, n <= num_ref_idx_l1_active_minus1</summary>
            public uint chroma_weight_l1_flag;
            public StdVideoEncodeH264WeightTableFlags() { }
            public StdVideoEncodeH264WeightTableFlags(uint luma_weight_l0_flag, uint chroma_weight_l0_flag, uint luma_weight_l1_flag, uint chroma_weight_l1_flag)
            {
                this.luma_weight_l0_flag = luma_weight_l0_flag;
                this.chroma_weight_l0_flag = chroma_weight_l0_flag;
                this.luma_weight_l1_flag = luma_weight_l1_flag;
                this.chroma_weight_l1_flag = chroma_weight_l1_flag;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264WeightTable
        {
            /// <summary></summary>
            public StdVideoEncodeH264WeightTableFlags flags;
            /// <summary></summary>
            public byte luma_log2_weight_denom;
            /// <summary></summary>
            public byte chroma_log2_weight_denom;
            /// <summary>valid entry range is [0, num_ref_idx_l0_active_minus1]</summary>
            public fixed sbyte luma_weight_l0[32];
            /// <summary>valid entry range is [0, num_ref_idx_l0_active_minus1]</summary>
            public fixed sbyte luma_offset_l0[32];
            [InlineArray(2)]
            public struct chroma_weight_l0InlineArray1
            {
                [InlineArray(32)]
                public struct chroma_weight_l0InlineArray2
                {
                    public sbyte element;
                }
                public chroma_weight_l0InlineArray2 chroma_weight_l0;
            }
            public chroma_weight_l0InlineArray1 chroma_weight_l0;
            [InlineArray(2)]
            public struct chroma_offset_l0InlineArray1
            {
                [InlineArray(32)]
                public struct chroma_offset_l0InlineArray2
                {
                    public sbyte element;
                }
                public chroma_offset_l0InlineArray2 chroma_offset_l0;
            }
            public chroma_offset_l0InlineArray1 chroma_offset_l0;
            /// <summary>valid entry range is [0, num_ref_idx_l1_active_minus1]</summary>
            public fixed sbyte luma_weight_l1[32];
            /// <summary>valid entry range is [0, num_ref_idx_l1_active_minus1]</summary>
            public fixed sbyte luma_offset_l1[32];
            [InlineArray(2)]
            public struct chroma_weight_l1InlineArray1
            {
                [InlineArray(32)]
                public struct chroma_weight_l1InlineArray2
                {
                    public sbyte element;
                }
                public chroma_weight_l1InlineArray2 chroma_weight_l1;
            }
            public chroma_weight_l1InlineArray1 chroma_weight_l1;
            [InlineArray(2)]
            public struct chroma_offset_l1InlineArray1
            {
                [InlineArray(32)]
                public struct chroma_offset_l1InlineArray2
                {
                    public sbyte element;
                }
                public chroma_offset_l1InlineArray2 chroma_offset_l1;
            }
            public chroma_offset_l1InlineArray1 chroma_offset_l1;
            public StdVideoEncodeH264WeightTable() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264SliceHeaderFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint direct_spatial_mv_pred_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint num_ref_idx_active_override_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH264SliceHeaderFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264PictureInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint IdrPicFlag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary>A reference picture, i.e. a picture with nal_ref_idc not equal to 0, as defined in clause 3.136</summary>
            public uint is_reference
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint no_output_of_prior_pics_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint long_term_reference_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint adaptive_ref_pic_marking_mode_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 5) & 0x7FFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFu << 5)) | ((((uint)value) & 0x7FFFFFFu) << 5);
            }
            public StdVideoEncodeH264PictureInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264ReferenceInfoFlags
        {
            private uint _bitfield0;
            /// <summary>A picture that is marked as "used for long-term reference", derived binary value from clause 8.2.5.1 Sequence of operations for decoded reference picture marking process</summary>
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoEncodeH264ReferenceInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264ReferenceListsInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint ref_pic_list_modification_flag_l0
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint ref_pic_list_modification_flag_l1
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH264ReferenceListsInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264RefListModEntry
        {
            /// <summary></summary>
            public StdVideoH264ModificationOfPicNumsIdc modification_of_pic_nums_idc;
            /// <summary></summary>
            public ushort abs_diff_pic_num_minus1;
            /// <summary></summary>
            public ushort long_term_pic_num;
            public StdVideoEncodeH264RefListModEntry() { }
            public StdVideoEncodeH264RefListModEntry(StdVideoH264ModificationOfPicNumsIdc modification_of_pic_nums_idc, ushort abs_diff_pic_num_minus1, ushort long_term_pic_num)
            {
                this.modification_of_pic_nums_idc = modification_of_pic_nums_idc;
                this.abs_diff_pic_num_minus1 = abs_diff_pic_num_minus1;
                this.long_term_pic_num = long_term_pic_num;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264RefPicMarkingEntry
        {
            /// <summary></summary>
            public StdVideoH264MemMgmtControlOp memory_management_control_operation;
            /// <summary></summary>
            public ushort difference_of_pic_nums_minus1;
            /// <summary></summary>
            public ushort long_term_pic_num;
            /// <summary></summary>
            public ushort long_term_frame_idx;
            /// <summary></summary>
            public ushort max_long_term_frame_idx_plus1;
            public StdVideoEncodeH264RefPicMarkingEntry() { }
            public StdVideoEncodeH264RefPicMarkingEntry(StdVideoH264MemMgmtControlOp memory_management_control_operation, ushort difference_of_pic_nums_minus1, ushort long_term_pic_num, ushort long_term_frame_idx, ushort max_long_term_frame_idx_plus1)
            {
                this.memory_management_control_operation = memory_management_control_operation;
                this.difference_of_pic_nums_minus1 = difference_of_pic_nums_minus1;
                this.long_term_pic_num = long_term_pic_num;
                this.long_term_frame_idx = long_term_frame_idx;
                this.max_long_term_frame_idx_plus1 = max_long_term_frame_idx_plus1;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264ReferenceListsInfo
        {
            /// <summary></summary>
            public StdVideoEncodeH264ReferenceListsInfoFlags flags;
            /// <summary></summary>
            public byte num_ref_idx_l0_active_minus1;
            /// <summary></summary>
            public byte num_ref_idx_l1_active_minus1;
            /// <summary>slotIndex as used in VkVideoReferenceSlotInfoKHR structures or STD_VIDEO_H264_NO_REFERENCE_PICTURE</summary>
            public fixed byte RefPicList0[32];
            /// <summary>slotIndex as used in VkVideoReferenceSlotInfoKHR structures or STD_VIDEO_H264_NO_REFERENCE_PICTURE</summary>
            public fixed byte RefPicList1[32];
            /// <summary></summary>
            public byte refList0ModOpCount;
            /// <summary></summary>
            public byte refList1ModOpCount;
            /// <summary></summary>
            public byte refPicMarkingOpCount;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved1[7];
            /// <summary>Must be a valid pointer to an array with size refList0ModOpCount if ref_pic_list_modification_flag_l0 is set and contains the RefList0 modification parameters as defined in section 7.4.3.1</summary>
            public StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;
            /// <summary>Must be a valid pointer to an array with size refList1ModOpCount if ref_pic_list_modification_flag_l1 is set and contains the RefList1 modification parameters as defined in section 7.4.3.1</summary>
            public StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;
            /// <summary>Must be a valid pointer to an array with size refPicMarkingOpCount and contains the reference picture markings as defined in section 7.4.3.3</summary>
            public StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;
            public StdVideoEncodeH264ReferenceListsInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264PictureInfo
        {
            /// <summary></summary>
            public StdVideoEncodeH264PictureInfoFlags flags;
            /// <summary>Selecting SPS id from the Sequence Parameters Set</summary>
            public byte seq_parameter_set_id;
            /// <summary>Selecting PPS from the Picture Parameters for all StdVideoEncodeH264SliceHeader(s)</summary>
            public byte pic_parameter_set_id;
            /// <summary></summary>
            public ushort idr_pic_id;
            /// <summary></summary>
            public StdVideoH264PictureType primary_pic_type;
            /// <summary></summary>
            public uint frame_num;
            /// <summary>Picture order count, as defined in 8.2</summary>
            public int PicOrderCnt;
            /// <summary>Temporal identifier of the picture, as defined in G.7.3.1.1 / G.7.4.1.1</summary>
            public byte temporal_id;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved1[3];
            /// <summary></summary>
            public StdVideoEncodeH264ReferenceListsInfo* pRefLists;
            public StdVideoEncodeH264PictureInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264ReferenceInfo
        {
            /// <summary></summary>
            public StdVideoEncodeH264ReferenceInfoFlags flags;
            /// <summary></summary>
            public StdVideoH264PictureType primary_pic_type;
            /// <summary>Frame number, as defined in 8.2</summary>
            public uint FrameNum;
            /// <summary>Picture order count, as defined in 8.2</summary>
            public int PicOrderCnt;
            /// <summary></summary>
            public ushort long_term_pic_num;
            /// <summary></summary>
            public ushort long_term_frame_idx;
            /// <summary>Temporal identifier of the picture, as defined in G.7.3.1.1 / G.7.4.1.1</summary>
            public byte temporal_id;
            public StdVideoEncodeH264ReferenceInfo() { }
            public StdVideoEncodeH264ReferenceInfo(StdVideoEncodeH264ReferenceInfoFlags flags, StdVideoH264PictureType primary_pic_type, uint FrameNum, int PicOrderCnt, ushort long_term_pic_num, ushort long_term_frame_idx, byte temporal_id)
            {
                this.flags = flags;
                this.primary_pic_type = primary_pic_type;
                this.FrameNum = FrameNum;
                this.PicOrderCnt = PicOrderCnt;
                this.long_term_pic_num = long_term_pic_num;
                this.long_term_frame_idx = long_term_frame_idx;
                this.temporal_id = temporal_id;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH264SliceHeader
        {
            /// <summary></summary>
            public StdVideoEncodeH264SliceHeaderFlags flags;
            /// <summary></summary>
            public uint first_mb_in_slice;
            /// <summary></summary>
            public StdVideoH264SliceType slice_type;
            /// <summary></summary>
            public sbyte slice_alpha_c0_offset_div2;
            /// <summary></summary>
            public sbyte slice_beta_offset_div2;
            /// <summary></summary>
            public sbyte slice_qp_delta;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary></summary>
            public StdVideoH264CabacInitIdc cabac_init_idc;
            /// <summary></summary>
            public StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc;
            /// <summary></summary>
            public StdVideoEncodeH264WeightTable* pWeightTable;
            public StdVideoEncodeH264SliceHeader() { }
            public StdVideoEncodeH264SliceHeader(StdVideoEncodeH264SliceHeaderFlags flags, uint first_mb_in_slice, StdVideoH264SliceType slice_type, sbyte slice_alpha_c0_offset_div2, sbyte slice_beta_offset_div2, sbyte slice_qp_delta, byte reserved1, StdVideoH264CabacInitIdc cabac_init_idc, StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc, StdVideoEncodeH264WeightTable* pWeightTable)
            {
                this.flags = flags;
                this.first_mb_in_slice = first_mb_in_slice;
                this.slice_type = slice_type;
                this.slice_alpha_c0_offset_div2 = slice_alpha_c0_offset_div2;
                this.slice_beta_offset_div2 = slice_beta_offset_div2;
                this.slice_qp_delta = slice_qp_delta;
                this.reserved1 = reserved1;
                this.cabac_init_idc = cabac_init_idc;
                this.disable_deblocking_filter_idc = disable_deblocking_filter_idc;
                this.pWeightTable = pWeightTable;
            }
        }
    }
    namespace VulkanVideoCodecH265std
    {
        public static class Constants
        {
            public const uint VideoH265CpbCntListSize = 32;
            public const uint VideoH265SublayersListSize = 7;
            public const uint VideoH265ScalingList4x4NumLists = 6;
            public const uint VideoH265ScalingList4x4NumElements = 16;
            public const uint VideoH265ScalingList8x8NumLists = 6;
            public const uint VideoH265ScalingList8x8NumElements = 64;
            public const uint VideoH265ScalingList16x16NumLists = 6;
            public const uint VideoH265ScalingList16x16NumElements = 64;
            public const uint VideoH265ScalingList32x32NumLists = 2;
            public const uint VideoH265ScalingList32x32NumElements = 64;
            public const uint VideoH265ChromaQpOffsetListSize = 6;
            public const uint VideoH265ChromaQpOffsetTileColsListSize = 19;
            public const uint VideoH265ChromaQpOffsetTileRowsListSize = 21;
            public const uint VideoH265PredictorPaletteComponentsListSize = 3;
            public const uint VideoH265PredictorPaletteCompEntriesListSize = 128;
            public const uint VideoH265MaxNumListRef = 15;
            public const uint VideoH265MaxChromaPlanes = 2;
            public const uint VideoH265MaxShortTermRefPicSets = 64;
            public const uint VideoH265MaxDpbSize = 16;
            public const uint VideoH265MaxLongTermRefPicsSps = 32;
            public const uint VideoH265MaxLongTermPics = 16;
            public const uint VideoH265MaxDeltaPoc = 48;
            public const uint VideoH265NoReferencePicture = 255;
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public enum StdVideoH265ChromaFormatIdc : uint
        {
            VideoH265ChromaFormatIdc420 = 1,
            VideoH265ChromaFormatIdc422 = 2,
            VideoH265ChromaFormatIdc444 = 3,
            VideoH265ChromaFormatIdcInvalid = 2147483647,
            VideoH265ChromaFormatIdcMonochrome = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public enum StdVideoH265ProfileIdc : uint
        {
            VideoH265ProfileIdcFormatRangeExtensions = 4,
            VideoH265ProfileIdcInvalid = 2147483647,
            VideoH265ProfileIdcMain = 1,
            VideoH265ProfileIdcMain10 = 2,
            VideoH265ProfileIdcMainStillPicture = 3,
            VideoH265ProfileIdcSccExtensions = 9,
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public enum StdVideoH265LevelIdc : uint
        {
            VideoH265LevelIdc10 = 0,
            VideoH265LevelIdc20 = 1,
            VideoH265LevelIdc21 = 2,
            VideoH265LevelIdc30 = 3,
            VideoH265LevelIdc31 = 4,
            VideoH265LevelIdc40 = 5,
            VideoH265LevelIdc41 = 6,
            VideoH265LevelIdc50 = 7,
            VideoH265LevelIdc51 = 8,
            VideoH265LevelIdc52 = 9,
            VideoH265LevelIdc60 = 10,
            VideoH265LevelIdc61 = 11,
            VideoH265LevelIdc62 = 12,
            VideoH265LevelIdcInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public enum StdVideoH265SliceType : uint
        {
            VideoH265SliceTypeB = 0,
            VideoH265SliceTypeI = 2,
            VideoH265SliceTypeInvalid = 2147483647,
            VideoH265SliceTypeP = 1,
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public enum StdVideoH265PictureType : uint
        {
            VideoH265PictureTypeB = 1,
            VideoH265PictureTypeI = 2,
            VideoH265PictureTypeIdr = 3,
            VideoH265PictureTypeInvalid = 2147483647,
            VideoH265PictureTypeP = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public enum StdVideoH265AspectRatioIdc : uint
        {
            VideoH265AspectRatioIdc1011 = 3,
            VideoH265AspectRatioIdc1211 = 2,
            VideoH265AspectRatioIdc1511 = 11,
            VideoH265AspectRatioIdc1611 = 4,
            VideoH265AspectRatioIdc16099 = 13,
            VideoH265AspectRatioIdc1811 = 10,
            VideoH265AspectRatioIdc21 = 16,
            VideoH265AspectRatioIdc2011 = 7,
            VideoH265AspectRatioIdc2411 = 6,
            VideoH265AspectRatioIdc32 = 15,
            VideoH265AspectRatioIdc3211 = 8,
            VideoH265AspectRatioIdc43 = 14,
            VideoH265AspectRatioIdc4033 = 5,
            VideoH265AspectRatioIdc6433 = 12,
            VideoH265AspectRatioIdc8033 = 9,
            VideoH265AspectRatioIdcExtendedSar = 255,
            VideoH265AspectRatioIdcInvalid = 2147483647,
            VideoH265AspectRatioIdcSquare = 1,
            VideoH265AspectRatioIdcUnspecified = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265DecPicBufMgr
        {
            /// <summary>represents sps_max_latency_increase_plus1 or vps_max_latency_increase_plus1</summary>
            public fixed uint max_latency_increase_plus1[7];
            /// <summary>represents sps_max_dec_pic_buffering_minus1 or vps_max_dec_pic_buffering_minus1</summary>
            public fixed byte max_dec_pic_buffering_minus1[7];
            /// <summary>represents sps_max_num_reorder_pics or vps_max_num_reorder_pics</summary>
            public fixed byte max_num_reorder_pics[7];
            public StdVideoH265DecPicBufMgr() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265SubLayerHrdParameters
        {
            /// <summary></summary>
            public fixed uint bit_rate_value_minus1[32];
            /// <summary></summary>
            public fixed uint cpb_size_value_minus1[32];
            /// <summary></summary>
            public fixed uint cpb_size_du_value_minus1[32];
            /// <summary></summary>
            public fixed uint bit_rate_du_value_minus1[32];
            /// <summary>each bit represents a range of CpbCounts (bit 0 - cpb_cnt_minus1) per sub-layer</summary>
            public uint cbr_flag;
            public StdVideoH265SubLayerHrdParameters() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265HrdFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint nal_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint vcl_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint sub_pic_hrd_params_present_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint sub_pic_cpb_params_in_pic_timing_sei_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary>each bit represents a sublayer, bit 0 - vps_max_sub_layers_minus1</summary>
            public uint fixed_pic_rate_general_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFu << 4)) | ((((uint)value) & 0xFFu) << 4);
            }
            /// <summary>each bit represents a sublayer, bit 0 - vps_max_sub_layers_minus1</summary>
            public uint fixed_pic_rate_within_cvs_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0xFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFu << 12)) | ((((uint)value) & 0xFFu) << 12);
            }
            /// <summary>each bit represents a sublayer, bit 0 - vps_max_sub_layers_minus1</summary>
            public uint low_delay_hrd_flag
            {
                get => (uint)((_bitfield0 >> 20) & 0xFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFu << 20)) | ((((uint)value) & 0xFFu) << 20);
            }
            public StdVideoH265HrdFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265HrdParameters
        {
            /// <summary></summary>
            public StdVideoH265HrdFlags flags;
            /// <summary></summary>
            public byte tick_divisor_minus2;
            /// <summary></summary>
            public byte du_cpb_removal_delay_increment_length_minus1;
            /// <summary></summary>
            public byte dpb_output_delay_du_length_minus1;
            /// <summary></summary>
            public byte bit_rate_scale;
            /// <summary></summary>
            public byte cpb_size_scale;
            /// <summary></summary>
            public byte cpb_size_du_scale;
            /// <summary></summary>
            public byte initial_cpb_removal_delay_length_minus1;
            /// <summary></summary>
            public byte au_cpb_removal_delay_length_minus1;
            /// <summary></summary>
            public byte dpb_output_delay_length_minus1;
            /// <summary></summary>
            public fixed byte cpb_cnt_minus1[7];
            /// <summary></summary>
            public fixed ushort elemental_duration_in_tc_minus1[7];
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed ushort reserved[3];
            /// <summary>if flags.nal_hrd_parameters_present_flag is set, then this must be a ptr to an array of StdVideoH265SubLayerHrdParameters with a size specified by sps_max_sub_layers_minus1 + 1 or vps_max_sub_layers_minus1 + 1, depending on whether the HRD parameters are part of the SPS or VPS, respectively.</summary>
            public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersNal;
            /// <summary>if flags.vcl_hrd_parameters_present_flag is set, then this must be a ptr to an array of StdVideoH265SubLayerHrdParameters with a size specified by sps_max_sub_layers_minus1 + 1 or vps_max_sub_layers_minus1 + 1, depending on whether the HRD parameters are part of the SPS or VPS, respectively.</summary>
            public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersVcl;
            public StdVideoH265HrdParameters() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265VpsFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint vps_temporal_id_nesting_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint vps_sub_layer_ordering_info_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint vps_timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint vps_poc_proportional_to_timing_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public StdVideoH265VpsFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265ProfileTierLevelFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint general_tier_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint general_progressive_source_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint general_interlaced_source_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint general_non_packed_constraint_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint general_frame_only_constraint_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public StdVideoH265ProfileTierLevelFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265ProfileTierLevel
        {
            /// <summary></summary>
            public StdVideoH265ProfileTierLevelFlags flags;
            /// <summary></summary>
            public StdVideoH265ProfileIdc general_profile_idc;
            /// <summary></summary>
            public StdVideoH265LevelIdc general_level_idc;
            public StdVideoH265ProfileTierLevel() { }
            public StdVideoH265ProfileTierLevel(StdVideoH265ProfileTierLevelFlags flags, StdVideoH265ProfileIdc general_profile_idc, StdVideoH265LevelIdc general_level_idc)
            {
                this.flags = flags;
                this.general_profile_idc = general_profile_idc;
                this.general_level_idc = general_level_idc;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265VideoParameterSet
        {
            /// <summary></summary>
            public StdVideoH265VpsFlags flags;
            /// <summary></summary>
            public byte vps_video_parameter_set_id;
            /// <summary></summary>
            public byte vps_max_sub_layers_minus1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved2;
            /// <summary></summary>
            public uint vps_num_units_in_tick;
            /// <summary></summary>
            public uint vps_time_scale;
            /// <summary></summary>
            public uint vps_num_ticks_poc_diff_one_minus1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public uint reserved3;
            /// <summary></summary>
            public StdVideoH265DecPicBufMgr* pDecPicBufMgr;
            /// <summary></summary>
            public StdVideoH265HrdParameters* pHrdParameters;
            /// <summary></summary>
            public StdVideoH265ProfileTierLevel* pProfileTierLevel;
            public StdVideoH265VideoParameterSet() { }
            public StdVideoH265VideoParameterSet(StdVideoH265VpsFlags flags, byte vps_video_parameter_set_id, byte vps_max_sub_layers_minus1, byte reserved1, byte reserved2, uint vps_num_units_in_tick, uint vps_time_scale, uint vps_num_ticks_poc_diff_one_minus1, uint reserved3, StdVideoH265DecPicBufMgr* pDecPicBufMgr, StdVideoH265HrdParameters* pHrdParameters, StdVideoH265ProfileTierLevel* pProfileTierLevel)
            {
                this.flags = flags;
                this.vps_video_parameter_set_id = vps_video_parameter_set_id;
                this.vps_max_sub_layers_minus1 = vps_max_sub_layers_minus1;
                this.reserved1 = reserved1;
                this.reserved2 = reserved2;
                this.vps_num_units_in_tick = vps_num_units_in_tick;
                this.vps_time_scale = vps_time_scale;
                this.vps_num_ticks_poc_diff_one_minus1 = vps_num_ticks_poc_diff_one_minus1;
                this.reserved3 = reserved3;
                this.pDecPicBufMgr = pDecPicBufMgr;
                this.pHrdParameters = pHrdParameters;
                this.pProfileTierLevel = pProfileTierLevel;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265ScalingLists
        {
            [InlineArray(16)]
            public struct ScalingList4x4InlineArray1
            {
                [InlineArray(6)]
                public struct ScalingList4x4InlineArray2
                {
                    public byte element;
                }
                public ScalingList4x4InlineArray2 ScalingList4x4;
            }
            public ScalingList4x4InlineArray1 ScalingList4x4;
            [InlineArray(64)]
            public struct ScalingList8x8InlineArray1
            {
                [InlineArray(6)]
                public struct ScalingList8x8InlineArray2
                {
                    public byte element;
                }
                public ScalingList8x8InlineArray2 ScalingList8x8;
            }
            public ScalingList8x8InlineArray1 ScalingList8x8;
            [InlineArray(64)]
            public struct ScalingList16x16InlineArray1
            {
                [InlineArray(6)]
                public struct ScalingList16x16InlineArray2
                {
                    public byte element;
                }
                public ScalingList16x16InlineArray2 ScalingList16x16;
            }
            public ScalingList16x16InlineArray1 ScalingList16x16;
            [InlineArray(64)]
            public struct ScalingList32x32InlineArray1
            {
                [InlineArray(2)]
                public struct ScalingList32x32InlineArray2
                {
                    public byte element;
                }
                public ScalingList32x32InlineArray2 ScalingList32x32;
            }
            public ScalingList32x32InlineArray1 ScalingList32x32;
            /// <summary>scaling_list_dc_coef_minus8[ sizeID - 2 ][ matrixID ] + 8, sizeID = 2</summary>
            public fixed byte ScalingListDCCoef16x16[6];
            /// <summary>scaling_list_dc_coef_minus8[ sizeID - 2 ][ matrixID ] + 8. sizeID = 3</summary>
            public fixed byte ScalingListDCCoef32x32[2];
            public StdVideoH265ScalingLists() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265SpsVuiFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint aspect_ratio_info_present_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint overscan_info_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint overscan_appropriate_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint video_signal_type_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint video_full_range_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint colour_description_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint chroma_loc_info_present_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint neutral_chroma_indication_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint field_seq_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint frame_field_info_present_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint default_display_window_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint vui_timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint vui_poc_proportional_to_timing_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            /// <summary></summary>
            public uint vui_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            /// <summary></summary>
            public uint bitstream_restriction_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            /// <summary></summary>
            public uint tiles_fixed_structure_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            /// <summary></summary>
            public uint motion_vectors_over_pic_boundaries_flag
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            /// <summary></summary>
            public uint restricted_ref_pic_lists_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            public StdVideoH265SpsVuiFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265SequenceParameterSetVui
        {
            /// <summary></summary>
            public StdVideoH265SpsVuiFlags flags;
            /// <summary></summary>
            public StdVideoH265AspectRatioIdc aspect_ratio_idc;
            /// <summary></summary>
            public ushort sar_width;
            /// <summary></summary>
            public ushort sar_height;
            /// <summary></summary>
            public byte video_format;
            /// <summary></summary>
            public byte colour_primaries;
            /// <summary></summary>
            public byte transfer_characteristics;
            /// <summary></summary>
            public byte matrix_coeffs;
            /// <summary></summary>
            public byte chroma_sample_loc_type_top_field;
            /// <summary></summary>
            public byte chroma_sample_loc_type_bottom_field;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved2;
            /// <summary></summary>
            public ushort def_disp_win_left_offset;
            /// <summary></summary>
            public ushort def_disp_win_right_offset;
            /// <summary></summary>
            public ushort def_disp_win_top_offset;
            /// <summary></summary>
            public ushort def_disp_win_bottom_offset;
            /// <summary></summary>
            public uint vui_num_units_in_tick;
            /// <summary></summary>
            public uint vui_time_scale;
            /// <summary></summary>
            public uint vui_num_ticks_poc_diff_one_minus1;
            /// <summary></summary>
            public ushort min_spatial_segmentation_idc;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public ushort reserved3;
            /// <summary></summary>
            public byte max_bytes_per_pic_denom;
            /// <summary></summary>
            public byte max_bits_per_min_cu_denom;
            /// <summary></summary>
            public byte log2_max_mv_length_horizontal;
            /// <summary></summary>
            public byte log2_max_mv_length_vertical;
            /// <summary></summary>
            public StdVideoH265HrdParameters* pHrdParameters;
            public StdVideoH265SequenceParameterSetVui() { }
            public StdVideoH265SequenceParameterSetVui(StdVideoH265SpsVuiFlags flags, StdVideoH265AspectRatioIdc aspect_ratio_idc, ushort sar_width, ushort sar_height, byte video_format, byte colour_primaries, byte transfer_characteristics, byte matrix_coeffs, byte chroma_sample_loc_type_top_field, byte chroma_sample_loc_type_bottom_field, byte reserved1, byte reserved2, ushort def_disp_win_left_offset, ushort def_disp_win_right_offset, ushort def_disp_win_top_offset, ushort def_disp_win_bottom_offset, uint vui_num_units_in_tick, uint vui_time_scale, uint vui_num_ticks_poc_diff_one_minus1, ushort min_spatial_segmentation_idc, ushort reserved3, byte max_bytes_per_pic_denom, byte max_bits_per_min_cu_denom, byte log2_max_mv_length_horizontal, byte log2_max_mv_length_vertical, StdVideoH265HrdParameters* pHrdParameters)
            {
                this.flags = flags;
                this.aspect_ratio_idc = aspect_ratio_idc;
                this.sar_width = sar_width;
                this.sar_height = sar_height;
                this.video_format = video_format;
                this.colour_primaries = colour_primaries;
                this.transfer_characteristics = transfer_characteristics;
                this.matrix_coeffs = matrix_coeffs;
                this.chroma_sample_loc_type_top_field = chroma_sample_loc_type_top_field;
                this.chroma_sample_loc_type_bottom_field = chroma_sample_loc_type_bottom_field;
                this.reserved1 = reserved1;
                this.reserved2 = reserved2;
                this.def_disp_win_left_offset = def_disp_win_left_offset;
                this.def_disp_win_right_offset = def_disp_win_right_offset;
                this.def_disp_win_top_offset = def_disp_win_top_offset;
                this.def_disp_win_bottom_offset = def_disp_win_bottom_offset;
                this.vui_num_units_in_tick = vui_num_units_in_tick;
                this.vui_time_scale = vui_time_scale;
                this.vui_num_ticks_poc_diff_one_minus1 = vui_num_ticks_poc_diff_one_minus1;
                this.min_spatial_segmentation_idc = min_spatial_segmentation_idc;
                this.reserved3 = reserved3;
                this.max_bytes_per_pic_denom = max_bytes_per_pic_denom;
                this.max_bits_per_min_cu_denom = max_bits_per_min_cu_denom;
                this.log2_max_mv_length_horizontal = log2_max_mv_length_horizontal;
                this.log2_max_mv_length_vertical = log2_max_mv_length_vertical;
                this.pHrdParameters = pHrdParameters;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265PredictorPaletteEntries
        {
            [InlineArray(128)]
            public struct PredictorPaletteEntriesInlineArray1
            {
                [InlineArray(3)]
                public struct PredictorPaletteEntriesInlineArray2
                {
                    public ushort element;
                }
                public PredictorPaletteEntriesInlineArray2 PredictorPaletteEntries;
            }
            public PredictorPaletteEntriesInlineArray1 PredictorPaletteEntries;
            public StdVideoH265PredictorPaletteEntries() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265SpsFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint sps_temporal_id_nesting_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint separate_colour_plane_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint conformance_window_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint sps_sub_layer_ordering_info_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint scaling_list_enabled_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint sps_scaling_list_data_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint amp_enabled_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint sample_adaptive_offset_enabled_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint pcm_enabled_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint pcm_loop_filter_disabled_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint long_term_ref_pics_present_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint sps_temporal_mvp_enabled_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint strong_intra_smoothing_enabled_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            /// <summary></summary>
            public uint vui_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            /// <summary></summary>
            public uint sps_extension_present_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            /// <summary></summary>
            public uint sps_range_extension_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            /// <summary></summary>
            public uint transform_skip_rotation_enabled_flag
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            /// <summary></summary>
            public uint transform_skip_context_enabled_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            /// <summary></summary>
            public uint implicit_rdpcm_enabled_flag
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            /// <summary></summary>
            public uint explicit_rdpcm_enabled_flag
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            /// <summary></summary>
            public uint extended_precision_processing_flag
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            /// <summary></summary>
            public uint intra_smoothing_disabled_flag
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            /// <summary></summary>
            public uint high_precision_offsets_enabled_flag
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            /// <summary></summary>
            public uint persistent_rice_adaptation_enabled_flag
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            /// <summary></summary>
            public uint cabac_bypass_alignment_enabled_flag
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            /// <summary></summary>
            public uint sps_scc_extension_flag
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            /// <summary></summary>
            public uint sps_curr_pic_ref_enabled_flag
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            /// <summary></summary>
            public uint palette_mode_enabled_flag
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            /// <summary></summary>
            public uint sps_palette_predictor_initializers_present_flag
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            /// <summary></summary>
            public uint intra_boundary_filtering_disabled_flag
            {
                get => (uint)((_bitfield0 >> 29) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 29)) | ((((uint)value) & 0x1u) << 29);
            }
            public StdVideoH265SpsFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265ShortTermRefPicSetFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint inter_ref_pic_set_prediction_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint delta_rps_sign
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public StdVideoH265ShortTermRefPicSetFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265ShortTermRefPicSet
        {
            /// <summary></summary>
            public StdVideoH265ShortTermRefPicSetFlags flags;
            /// <summary></summary>
            public uint delta_idx_minus1;
            /// <summary>each bit represents a use_delta_flag[j] syntax</summary>
            public ushort use_delta_flag;
            /// <summary></summary>
            public ushort abs_delta_rps_minus1;
            /// <summary>each bit represents a used_by_curr_pic_flag[j] syntax</summary>
            public ushort used_by_curr_pic_flag;
            /// <summary>each bit represents a used_by_curr_pic_s0_flag[i] syntax</summary>
            public ushort used_by_curr_pic_s0_flag;
            /// <summary>each bit represents a used_by_curr_pic_s1_flag[i] syntax</summary>
            public ushort used_by_curr_pic_s1_flag;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public ushort reserved1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved2;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved3;
            /// <summary></summary>
            public byte num_negative_pics;
            /// <summary></summary>
            public byte num_positive_pics;
            /// <summary></summary>
            public fixed ushort delta_poc_s0_minus1[16];
            /// <summary></summary>
            public fixed ushort delta_poc_s1_minus1[16];
            public StdVideoH265ShortTermRefPicSet() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265LongTermRefPicsSps
        {
            /// <summary>each bit represents a used_by_curr_pic_lt_sps_flag[i] syntax</summary>
            public uint used_by_curr_pic_lt_sps_flag;
            /// <summary></summary>
            public fixed uint lt_ref_pic_poc_lsb_sps[32];
            public StdVideoH265LongTermRefPicsSps() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265SequenceParameterSet
        {
            /// <summary></summary>
            public StdVideoH265SpsFlags flags;
            /// <summary></summary>
            public StdVideoH265ChromaFormatIdc chroma_format_idc;
            /// <summary></summary>
            public uint pic_width_in_luma_samples;
            /// <summary></summary>
            public uint pic_height_in_luma_samples;
            /// <summary></summary>
            public byte sps_video_parameter_set_id;
            /// <summary></summary>
            public byte sps_max_sub_layers_minus1;
            /// <summary></summary>
            public byte sps_seq_parameter_set_id;
            /// <summary></summary>
            public byte bit_depth_luma_minus8;
            /// <summary></summary>
            public byte bit_depth_chroma_minus8;
            /// <summary></summary>
            public byte log2_max_pic_order_cnt_lsb_minus4;
            /// <summary></summary>
            public byte log2_min_luma_coding_block_size_minus3;
            /// <summary></summary>
            public byte log2_diff_max_min_luma_coding_block_size;
            /// <summary></summary>
            public byte log2_min_luma_transform_block_size_minus2;
            /// <summary></summary>
            public byte log2_diff_max_min_luma_transform_block_size;
            /// <summary></summary>
            public byte max_transform_hierarchy_depth_inter;
            /// <summary></summary>
            public byte max_transform_hierarchy_depth_intra;
            /// <summary></summary>
            public byte num_short_term_ref_pic_sets;
            /// <summary></summary>
            public byte num_long_term_ref_pics_sps;
            /// <summary></summary>
            public byte pcm_sample_bit_depth_luma_minus1;
            /// <summary></summary>
            public byte pcm_sample_bit_depth_chroma_minus1;
            /// <summary></summary>
            public byte log2_min_pcm_luma_coding_block_size_minus3;
            /// <summary></summary>
            public byte log2_diff_max_min_pcm_luma_coding_block_size;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved2;
            /// <summary></summary>
            public byte palette_max_size;
            /// <summary></summary>
            public byte delta_palette_max_predictor_size;
            /// <summary></summary>
            public byte motion_vector_resolution_control_idc;
            /// <summary></summary>
            public byte sps_num_palette_predictor_initializers_minus1;
            /// <summary></summary>
            public uint conf_win_left_offset;
            /// <summary></summary>
            public uint conf_win_right_offset;
            /// <summary></summary>
            public uint conf_win_top_offset;
            /// <summary></summary>
            public uint conf_win_bottom_offset;
            /// <summary></summary>
            public StdVideoH265ProfileTierLevel* pProfileTierLevel;
            /// <summary></summary>
            public StdVideoH265DecPicBufMgr* pDecPicBufMgr;
            /// <summary>Must be a valid pointer if sps_scaling_list_data_present_flag is set</summary>
            public StdVideoH265ScalingLists* pScalingLists;
            /// <summary>Must be a valid pointer to an array with size num_short_term_ref_pic_sets if num_short_term_ref_pic_sets is not 0.</summary>
            public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;
            /// <summary>Must be a valid pointer if long_term_ref_pics_present_flag is set</summary>
            public StdVideoH265LongTermRefPicsSps* pLongTermRefPicsSps;
            /// <summary>Must be a valid pointer if StdVideoH265SpsFlags:vui_parameters_present_flag is set palette_max_size</summary>
            public StdVideoH265SequenceParameterSetVui* pSequenceParameterSetVui;
            /// <summary>Must be a valid pointer if sps_palette_predictor_initializer_present_flag is set</summary>
            public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
            public StdVideoH265SequenceParameterSet() { }
            public StdVideoH265SequenceParameterSet(StdVideoH265SpsFlags flags, StdVideoH265ChromaFormatIdc chroma_format_idc, uint pic_width_in_luma_samples, uint pic_height_in_luma_samples, byte sps_video_parameter_set_id, byte sps_max_sub_layers_minus1, byte sps_seq_parameter_set_id, byte bit_depth_luma_minus8, byte bit_depth_chroma_minus8, byte log2_max_pic_order_cnt_lsb_minus4, byte log2_min_luma_coding_block_size_minus3, byte log2_diff_max_min_luma_coding_block_size, byte log2_min_luma_transform_block_size_minus2, byte log2_diff_max_min_luma_transform_block_size, byte max_transform_hierarchy_depth_inter, byte max_transform_hierarchy_depth_intra, byte num_short_term_ref_pic_sets, byte num_long_term_ref_pics_sps, byte pcm_sample_bit_depth_luma_minus1, byte pcm_sample_bit_depth_chroma_minus1, byte log2_min_pcm_luma_coding_block_size_minus3, byte log2_diff_max_min_pcm_luma_coding_block_size, byte reserved1, byte reserved2, byte palette_max_size, byte delta_palette_max_predictor_size, byte motion_vector_resolution_control_idc, byte sps_num_palette_predictor_initializers_minus1, uint conf_win_left_offset, uint conf_win_right_offset, uint conf_win_top_offset, uint conf_win_bottom_offset, StdVideoH265ProfileTierLevel* pProfileTierLevel, StdVideoH265DecPicBufMgr* pDecPicBufMgr, StdVideoH265ScalingLists* pScalingLists, StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet, StdVideoH265LongTermRefPicsSps* pLongTermRefPicsSps, StdVideoH265SequenceParameterSetVui* pSequenceParameterSetVui, StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries)
            {
                this.flags = flags;
                this.chroma_format_idc = chroma_format_idc;
                this.pic_width_in_luma_samples = pic_width_in_luma_samples;
                this.pic_height_in_luma_samples = pic_height_in_luma_samples;
                this.sps_video_parameter_set_id = sps_video_parameter_set_id;
                this.sps_max_sub_layers_minus1 = sps_max_sub_layers_minus1;
                this.sps_seq_parameter_set_id = sps_seq_parameter_set_id;
                this.bit_depth_luma_minus8 = bit_depth_luma_minus8;
                this.bit_depth_chroma_minus8 = bit_depth_chroma_minus8;
                this.log2_max_pic_order_cnt_lsb_minus4 = log2_max_pic_order_cnt_lsb_minus4;
                this.log2_min_luma_coding_block_size_minus3 = log2_min_luma_coding_block_size_minus3;
                this.log2_diff_max_min_luma_coding_block_size = log2_diff_max_min_luma_coding_block_size;
                this.log2_min_luma_transform_block_size_minus2 = log2_min_luma_transform_block_size_minus2;
                this.log2_diff_max_min_luma_transform_block_size = log2_diff_max_min_luma_transform_block_size;
                this.max_transform_hierarchy_depth_inter = max_transform_hierarchy_depth_inter;
                this.max_transform_hierarchy_depth_intra = max_transform_hierarchy_depth_intra;
                this.num_short_term_ref_pic_sets = num_short_term_ref_pic_sets;
                this.num_long_term_ref_pics_sps = num_long_term_ref_pics_sps;
                this.pcm_sample_bit_depth_luma_minus1 = pcm_sample_bit_depth_luma_minus1;
                this.pcm_sample_bit_depth_chroma_minus1 = pcm_sample_bit_depth_chroma_minus1;
                this.log2_min_pcm_luma_coding_block_size_minus3 = log2_min_pcm_luma_coding_block_size_minus3;
                this.log2_diff_max_min_pcm_luma_coding_block_size = log2_diff_max_min_pcm_luma_coding_block_size;
                this.reserved1 = reserved1;
                this.reserved2 = reserved2;
                this.palette_max_size = palette_max_size;
                this.delta_palette_max_predictor_size = delta_palette_max_predictor_size;
                this.motion_vector_resolution_control_idc = motion_vector_resolution_control_idc;
                this.sps_num_palette_predictor_initializers_minus1 = sps_num_palette_predictor_initializers_minus1;
                this.conf_win_left_offset = conf_win_left_offset;
                this.conf_win_right_offset = conf_win_right_offset;
                this.conf_win_top_offset = conf_win_top_offset;
                this.conf_win_bottom_offset = conf_win_bottom_offset;
                this.pProfileTierLevel = pProfileTierLevel;
                this.pDecPicBufMgr = pDecPicBufMgr;
                this.pScalingLists = pScalingLists;
                this.pShortTermRefPicSet = pShortTermRefPicSet;
                this.pLongTermRefPicsSps = pLongTermRefPicsSps;
                this.pSequenceParameterSetVui = pSequenceParameterSetVui;
                this.pPredictorPaletteEntries = pPredictorPaletteEntries;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265PpsFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint dependent_slice_segments_enabled_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint output_flag_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint sign_data_hiding_enabled_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint cabac_init_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint constrained_intra_pred_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint transform_skip_enabled_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint cu_qp_delta_enabled_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint pps_slice_chroma_qp_offsets_present_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint weighted_pred_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint weighted_bipred_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint transquant_bypass_enabled_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint tiles_enabled_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint entropy_coding_sync_enabled_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            /// <summary></summary>
            public uint uniform_spacing_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            /// <summary></summary>
            public uint loop_filter_across_tiles_enabled_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            /// <summary></summary>
            public uint pps_loop_filter_across_slices_enabled_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            /// <summary></summary>
            public uint deblocking_filter_control_present_flag
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            /// <summary></summary>
            public uint deblocking_filter_override_enabled_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            /// <summary></summary>
            public uint pps_deblocking_filter_disabled_flag
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            /// <summary></summary>
            public uint pps_scaling_list_data_present_flag
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            /// <summary></summary>
            public uint lists_modification_present_flag
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            /// <summary></summary>
            public uint slice_segment_header_extension_present_flag
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            /// <summary></summary>
            public uint pps_extension_present_flag
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            /// <summary></summary>
            public uint cross_component_prediction_enabled_flag
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            /// <summary></summary>
            public uint chroma_qp_offset_list_enabled_flag
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            /// <summary></summary>
            public uint pps_curr_pic_ref_enabled_flag
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            /// <summary></summary>
            public uint residual_adaptive_colour_transform_enabled_flag
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            /// <summary></summary>
            public uint pps_slice_act_qp_offsets_present_flag
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            /// <summary></summary>
            public uint pps_palette_predictor_initializers_present_flag
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            /// <summary></summary>
            public uint monochrome_palette_flag
            {
                get => (uint)((_bitfield0 >> 29) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 29)) | ((((uint)value) & 0x1u) << 29);
            }
            /// <summary></summary>
            public uint pps_range_extension_flag
            {
                get => (uint)((_bitfield0 >> 30) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 30)) | ((((uint)value) & 0x1u) << 30);
            }
            public StdVideoH265PpsFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std]</b> </summary>
        public unsafe struct StdVideoH265PictureParameterSet
        {
            /// <summary></summary>
            public StdVideoH265PpsFlags flags;
            /// <summary></summary>
            public byte pps_pic_parameter_set_id;
            /// <summary></summary>
            public byte pps_seq_parameter_set_id;
            /// <summary></summary>
            public byte sps_video_parameter_set_id;
            /// <summary></summary>
            public byte num_extra_slice_header_bits;
            /// <summary></summary>
            public byte num_ref_idx_l0_default_active_minus1;
            /// <summary></summary>
            public byte num_ref_idx_l1_default_active_minus1;
            /// <summary></summary>
            public sbyte init_qp_minus26;
            /// <summary></summary>
            public byte diff_cu_qp_delta_depth;
            /// <summary></summary>
            public sbyte pps_cb_qp_offset;
            /// <summary></summary>
            public sbyte pps_cr_qp_offset;
            /// <summary></summary>
            public sbyte pps_beta_offset_div2;
            /// <summary></summary>
            public sbyte pps_tc_offset_div2;
            /// <summary></summary>
            public byte log2_parallel_merge_level_minus2;
            /// <summary></summary>
            public byte log2_max_transform_skip_block_size_minus2;
            /// <summary></summary>
            public byte diff_cu_chroma_qp_offset_depth;
            /// <summary></summary>
            public byte chroma_qp_offset_list_len_minus1;
            /// <summary></summary>
            public fixed sbyte cb_qp_offset_list[6];
            /// <summary></summary>
            public fixed sbyte cr_qp_offset_list[6];
            /// <summary></summary>
            public byte log2_sao_offset_scale_luma;
            /// <summary></summary>
            public byte log2_sao_offset_scale_chroma;
            /// <summary></summary>
            public sbyte pps_act_y_qp_offset_plus5;
            /// <summary></summary>
            public sbyte pps_act_cb_qp_offset_plus5;
            /// <summary></summary>
            public sbyte pps_act_cr_qp_offset_plus3;
            /// <summary></summary>
            public byte pps_num_palette_predictor_initializers;
            /// <summary></summary>
            public byte luma_bit_depth_entry_minus8;
            /// <summary></summary>
            public byte chroma_bit_depth_entry_minus8;
            /// <summary></summary>
            public byte num_tile_columns_minus1;
            /// <summary></summary>
            public byte num_tile_rows_minus1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved2;
            /// <summary></summary>
            public fixed ushort column_width_minus1[19];
            /// <summary></summary>
            public fixed ushort row_height_minus1[21];
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public uint reserved3;
            /// <summary>Must be a valid pointer if pps_scaling_list_data_present_flag is set</summary>
            public StdVideoH265ScalingLists* pScalingLists;
            /// <summary>Must be a valid pointer if pps_palette_predictor_initializer_present_flag is set</summary>
            public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
            public StdVideoH265PictureParameterSet() { }
        }
    }
    namespace VulkanVideoCodecH265stdDecode
    {
        public static class Constants
        {
            /// <summary>&quot;VK_STD_vulkan_video_codec_h265_decode&quot;</summary>
            public static ReadOnlySpan<byte> StdVulkanVideoCodecH265DecodeExtensionName => "VK_STD_vulkan_video_codec_h265_decode"u8;
            public const uint VideoDecodeH265RefPicSetListSize = 8;
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH265PictureInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint IrapPicFlag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint IdrPicFlag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint IsReference
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint short_term_ref_pic_set_sps_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public StdVideoDecodeH265PictureInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH265PictureInfo
        {
            /// <summary></summary>
            public StdVideoDecodeH265PictureInfoFlags flags;
            /// <summary>Selecting VPS id from the Video Parameters Set</summary>
            public byte sps_video_parameter_set_id;
            /// <summary>Selecting SPS id from the Sequence Parameters Set</summary>
            public byte pps_seq_parameter_set_id;
            /// <summary>Selecting PPS id from the Picture Parameters Set</summary>
            public byte pps_pic_parameter_set_id;
            /// <summary>NumDeltaPocs[ RefRpsIdx ] when short_term_ref_pic_set_sps_flag = 1, otherwise 0</summary>
            public byte NumDeltaPocsOfRefRpsIdx;
            /// <summary></summary>
            public int PicOrderCntVal;
            /// <summary>number of bits used in st_ref_pic_set() when short_term_ref_pic_set_sps_flag is 0otherwise set to 0.</summary>
            public ushort NumBitsForSTRefPicSetInSlice;
            /// <summary></summary>
            public ushort reserved;
            /// <summary>slotIndex as used in VkVideoReferenceSlotInfoKHR structures representing pReferenceSlots in VkVideoDecodeInfoKHR or STD_VIDEO_H265_NO_REFERENCE_PICTURE</summary>
            public fixed byte RefPicSetStCurrBefore[8];
            /// <summary>slotIndex as used in VkVideoReferenceSlotInfoKHR structures representing pReferenceSlots in VkVideoDecodeInfoKHR or STD_VIDEO_H265_NO_REFERENCE_PICTURE</summary>
            public fixed byte RefPicSetStCurrAfter[8];
            /// <summary>slotIndex as used in VkVideoReferenceSlotInfoKHR structures representing pReferenceSlots in VkVideoDecodeInfoKHR or STD_VIDEO_H265_NO_REFERENCE_PICTURE</summary>
            public fixed byte RefPicSetLtCurr[8];
            public StdVideoDecodeH265PictureInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH265ReferenceInfoFlags
        {
            private uint _bitfield0;
            /// <summary>A picture that is marked as "used for long-term reference", derived binary value from clause 8.3.2 Decoding process for reference picture set</summary>
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary>A picture that is marked as "unused for reference", derived binary value from clause 8.3.2 Decoding process for reference picture set</summary>
            public uint unused_for_reference
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public StdVideoDecodeH265ReferenceInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeH265ReferenceInfo
        {
            /// <summary></summary>
            public StdVideoDecodeH265ReferenceInfoFlags flags;
            /// <summary></summary>
            public int PicOrderCntVal;
            public StdVideoDecodeH265ReferenceInfo() { }
            public StdVideoDecodeH265ReferenceInfo(StdVideoDecodeH265ReferenceInfoFlags flags, int PicOrderCntVal)
            {
                this.flags = flags;
                this.PicOrderCntVal = PicOrderCntVal;
            }
        }
    }
    namespace VulkanVideoCodecH265stdEncode
    {
        public static class Constants
        {
            /// <summary>&quot;VK_STD_vulkan_video_codec_h265_encode&quot;</summary>
            public static ReadOnlySpan<byte> StdVulkanVideoCodecH265EncodeExtensionName => "VK_STD_vulkan_video_codec_h265_encode"u8;
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265WeightTableFlags
        {
            /// <summary>each bit n represents the nth entry in reference list l0, n <= num_ref_idx_l0_active_minus1</summary>
            public ushort luma_weight_l0_flag;
            /// <summary>each bit n represents the nth entry in reference list l0, n <= num_ref_idx_l0_active_minus1</summary>
            public ushort chroma_weight_l0_flag;
            /// <summary>each bit n represents the nth entry in reference list l1, n <= num_ref_idx_l1_active_minus1</summary>
            public ushort luma_weight_l1_flag;
            /// <summary>each bit n represents the nth entry in reference list l1, n <= num_ref_idx_l1_active_minus1</summary>
            public ushort chroma_weight_l1_flag;
            public StdVideoEncodeH265WeightTableFlags() { }
            public StdVideoEncodeH265WeightTableFlags(ushort luma_weight_l0_flag, ushort chroma_weight_l0_flag, ushort luma_weight_l1_flag, ushort chroma_weight_l1_flag)
            {
                this.luma_weight_l0_flag = luma_weight_l0_flag;
                this.chroma_weight_l0_flag = chroma_weight_l0_flag;
                this.luma_weight_l1_flag = luma_weight_l1_flag;
                this.chroma_weight_l1_flag = chroma_weight_l1_flag;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265WeightTable
        {
            /// <summary></summary>
            public StdVideoEncodeH265WeightTableFlags flags;
            /// <summary>[0, 7]</summary>
            public byte luma_log2_weight_denom;
            /// <summary></summary>
            public sbyte delta_chroma_log2_weight_denom;
            /// <summary>comment</summary>
            public fixed sbyte delta_luma_weight_l0[15];
            /// <summary>comment</summary>
            public fixed sbyte luma_offset_l0[15];
            [InlineArray(2)]
            public struct delta_chroma_weight_l0InlineArray1
            {
                [InlineArray(15)]
                public struct delta_chroma_weight_l0InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_weight_l0InlineArray2 delta_chroma_weight_l0;
            }
            public delta_chroma_weight_l0InlineArray1 delta_chroma_weight_l0;
            [InlineArray(2)]
            public struct delta_chroma_offset_l0InlineArray1
            {
                [InlineArray(15)]
                public struct delta_chroma_offset_l0InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_offset_l0InlineArray2 delta_chroma_offset_l0;
            }
            public delta_chroma_offset_l0InlineArray1 delta_chroma_offset_l0;
            /// <summary></summary>
            public fixed sbyte delta_luma_weight_l1[15];
            /// <summary></summary>
            public fixed sbyte luma_offset_l1[15];
            [InlineArray(2)]
            public struct delta_chroma_weight_l1InlineArray1
            {
                [InlineArray(15)]
                public struct delta_chroma_weight_l1InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_weight_l1InlineArray2 delta_chroma_weight_l1;
            }
            public delta_chroma_weight_l1InlineArray1 delta_chroma_weight_l1;
            [InlineArray(2)]
            public struct delta_chroma_offset_l1InlineArray1
            {
                [InlineArray(15)]
                public struct delta_chroma_offset_l1InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_offset_l1InlineArray2 delta_chroma_offset_l1;
            }
            public delta_chroma_offset_l1InlineArray1 delta_chroma_offset_l1;
            public StdVideoEncodeH265WeightTable() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265SliceSegmentHeaderFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint first_slice_segment_in_pic_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint dependent_slice_segment_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint slice_sao_luma_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint slice_sao_chroma_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint num_ref_idx_active_override_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint mvd_l1_zero_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint cabac_init_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint cu_chroma_qp_offset_enabled_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint deblocking_filter_override_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint slice_deblocking_filter_disabled_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            /// <summary></summary>
            public uint collocated_from_l0_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            /// <summary></summary>
            public uint slice_loop_filter_across_slices_enabled_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 12) & 0xFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFu << 12)) | ((((uint)value) & 0xFFFFFu) << 12);
            }
            public StdVideoEncodeH265SliceSegmentHeaderFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265SliceSegmentHeader
        {
            /// <summary></summary>
            public StdVideoEncodeH265SliceSegmentHeaderFlags flags;
            /// <summary></summary>
            public StdVideoH265SliceType slice_type;
            /// <summary></summary>
            public uint slice_segment_address;
            /// <summary></summary>
            public byte collocated_ref_idx;
            /// <summary></summary>
            public byte MaxNumMergeCand;
            /// <summary>[-12, 12]</summary>
            public sbyte slice_cb_qp_offset;
            /// <summary>[-12, 12]</summary>
            public sbyte slice_cr_qp_offset;
            /// <summary>[-6, 6]</summary>
            public sbyte slice_beta_offset_div2;
            /// <summary>[-6, 6]</summary>
            public sbyte slice_tc_offset_div2;
            /// <summary></summary>
            public sbyte slice_act_y_qp_offset;
            /// <summary></summary>
            public sbyte slice_act_cb_qp_offset;
            /// <summary></summary>
            public sbyte slice_act_cr_qp_offset;
            /// <summary></summary>
            public sbyte slice_qp_delta;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public ushort reserved1;
            /// <summary></summary>
            public StdVideoEncodeH265WeightTable* pWeightTable;
            public StdVideoEncodeH265SliceSegmentHeader() { }
            public StdVideoEncodeH265SliceSegmentHeader(StdVideoEncodeH265SliceSegmentHeaderFlags flags, StdVideoH265SliceType slice_type, uint slice_segment_address, byte collocated_ref_idx, byte MaxNumMergeCand, sbyte slice_cb_qp_offset, sbyte slice_cr_qp_offset, sbyte slice_beta_offset_div2, sbyte slice_tc_offset_div2, sbyte slice_act_y_qp_offset, sbyte slice_act_cb_qp_offset, sbyte slice_act_cr_qp_offset, sbyte slice_qp_delta, ushort reserved1, StdVideoEncodeH265WeightTable* pWeightTable)
            {
                this.flags = flags;
                this.slice_type = slice_type;
                this.slice_segment_address = slice_segment_address;
                this.collocated_ref_idx = collocated_ref_idx;
                this.MaxNumMergeCand = MaxNumMergeCand;
                this.slice_cb_qp_offset = slice_cb_qp_offset;
                this.slice_cr_qp_offset = slice_cr_qp_offset;
                this.slice_beta_offset_div2 = slice_beta_offset_div2;
                this.slice_tc_offset_div2 = slice_tc_offset_div2;
                this.slice_act_y_qp_offset = slice_act_y_qp_offset;
                this.slice_act_cb_qp_offset = slice_act_cb_qp_offset;
                this.slice_act_cr_qp_offset = slice_act_cr_qp_offset;
                this.slice_qp_delta = slice_qp_delta;
                this.reserved1 = reserved1;
                this.pWeightTable = pWeightTable;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265ReferenceListsInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint ref_pic_list_modification_flag_l0
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint ref_pic_list_modification_flag_l1
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH265ReferenceListsInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265ReferenceListsInfo
        {
            /// <summary></summary>
            public StdVideoEncodeH265ReferenceListsInfoFlags flags;
            /// <summary></summary>
            public byte num_ref_idx_l0_active_minus1;
            /// <summary></summary>
            public byte num_ref_idx_l1_active_minus1;
            /// <summary>slotIndex as used in VkVideoReferenceSlotInfoKHR structures or STD_VIDEO_H265_NO_REFERENCE_PICTURE</summary>
            public fixed byte RefPicList0[15];
            /// <summary>slotIndex as used in VkVideoReferenceSlotInfoKHR structures or STD_VIDEO_H265_NO_REFERENCE_PICTURE</summary>
            public fixed byte RefPicList1[15];
            /// <summary></summary>
            public fixed byte list_entry_l0[15];
            /// <summary></summary>
            public fixed byte list_entry_l1[15];
            public StdVideoEncodeH265ReferenceListsInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265PictureInfoFlags
        {
            private uint _bitfield0;
            /// <summary>A reference picture, as defined in clause 3.132</summary>
            public uint is_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary>A reference picture, as defined in clause 3.73</summary>
            public uint IrapPicFlag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary>A picture that is marked as "used for long-term reference", derived binary value from clause 8.3.2 Decoding process for reference picture set</summary>
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint discardable_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint cross_layer_bla_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint pic_output_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint no_output_of_prior_pics_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint short_term_ref_pic_set_sps_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint slice_temporal_mvp_enabled_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 9) & 0x7FFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFu << 9)) | ((((uint)value) & 0x7FFFFFu) << 9);
            }
            public StdVideoEncodeH265PictureInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265LongTermRefPics
        {
            /// <summary></summary>
            public byte num_long_term_sps;
            /// <summary></summary>
            public byte num_long_term_pics;
            /// <summary></summary>
            public fixed byte lt_idx_sps[32];
            /// <summary></summary>
            public fixed byte poc_lsb_lt[16];
            /// <summary>each bit represents a used_by_curr_pic_lt_flag[i] syntax</summary>
            public ushort used_by_curr_pic_lt_flag;
            /// <summary></summary>
            public fixed byte delta_poc_msb_present_flag[48];
            /// <summary></summary>
            public fixed byte delta_poc_msb_cycle_lt[48];
            public StdVideoEncodeH265LongTermRefPics() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265PictureInfo
        {
            /// <summary></summary>
            public StdVideoEncodeH265PictureInfoFlags flags;
            /// <summary></summary>
            public StdVideoH265PictureType pic_type;
            /// <summary>Selecting VPS id from the Video Parameters Set</summary>
            public byte sps_video_parameter_set_id;
            /// <summary>Selecting SPS id from the Sequence Parameters Set</summary>
            public byte pps_seq_parameter_set_id;
            /// <summary>Selecting PPS id from the Picture Parameters Set</summary>
            public byte pps_pic_parameter_set_id;
            /// <summary></summary>
            public byte short_term_ref_pic_set_idx;
            /// <summary>Picture order count derived as specified in 8.3.1</summary>
            public int PicOrderCntVal;
            /// <summary>Temporal ID, as defined in 7.4.2.2</summary>
            public byte TemporalId;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed byte reserved1[7];
            /// <summary></summary>
            public StdVideoEncodeH265ReferenceListsInfo* pRefLists;
            /// <summary>Must be a valid pointer if short_term_ref_pic_set_sps_flag is not set</summary>
            public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;
            /// <summary>Must be a valid pointer if long_term_ref_pics_present_flag is set</summary>
            public StdVideoEncodeH265LongTermRefPics* pLongTermRefPics;
            public StdVideoEncodeH265PictureInfo() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265ReferenceInfoFlags
        {
            private uint _bitfield0;
            /// <summary>A picture that is marked as "used for long-term reference", derived binary value from clause 8.3.2 Decoding process for reference picture set</summary>
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary>A picture that is marked as "unused for reference", derived binary value from clause 8.3.2 Decoding process for reference picture set</summary>
            public uint unused_for_reference
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH265ReferenceInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        public unsafe struct StdVideoEncodeH265ReferenceInfo
        {
            /// <summary></summary>
            public StdVideoEncodeH265ReferenceInfoFlags flags;
            /// <summary></summary>
            public StdVideoH265PictureType pic_type;
            /// <summary>Picture order count derived as specified in 8.3.1</summary>
            public int PicOrderCntVal;
            /// <summary>Temporal ID, as defined in 7.4.2.2</summary>
            public byte TemporalId;
            public StdVideoEncodeH265ReferenceInfo() { }
            public StdVideoEncodeH265ReferenceInfo(StdVideoEncodeH265ReferenceInfoFlags flags, StdVideoH265PictureType pic_type, int PicOrderCntVal, byte TemporalId)
            {
                this.flags = flags;
                this.pic_type = pic_type;
                this.PicOrderCntVal = PicOrderCntVal;
                this.TemporalId = TemporalId;
            }
        }
    }
    namespace VulkanVideoCodecVp9std
    {
        public static class Constants
        {
            public const uint VideoVp9NumRefFrames = 8;
            public const uint VideoVp9RefsPerFrame = 3;
            public const uint VideoVp9MaxRefFrames = 4;
            public const uint VideoVp9LoopFilterAdjustments = 2;
            public const uint VideoVp9MaxSegments = 8;
            public const uint VideoVp9SegLvlMax = 4;
            public const uint VideoVp9MaxSegmentationTreeProbs = 7;
            public const uint VideoVp9MaxSegmentationPredProb = 3;
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public enum StdVideoVP9Profile : uint
        {
            VideoVp9Profile0 = 0,
            VideoVp9Profile1 = 1,
            VideoVp9Profile2 = 2,
            VideoVp9Profile3 = 3,
            VideoVp9ProfileInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public enum StdVideoVP9Level : uint
        {
            VideoVp9Level10 = 0,
            VideoVp9Level11 = 1,
            VideoVp9Level20 = 2,
            VideoVp9Level21 = 3,
            VideoVp9Level30 = 4,
            VideoVp9Level31 = 5,
            VideoVp9Level40 = 6,
            VideoVp9Level41 = 7,
            VideoVp9Level50 = 8,
            VideoVp9Level51 = 9,
            VideoVp9Level52 = 10,
            VideoVp9Level60 = 11,
            VideoVp9Level61 = 12,
            VideoVp9Level62 = 13,
            VideoVp9LevelInvalid = 2147483647,
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public enum StdVideoVP9FrameType : uint
        {
            VideoVp9FrameTypeInvalid = 2147483647,
            VideoVp9FrameTypeKey = 0,
            VideoVp9FrameTypeNonKey = 1,
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public enum StdVideoVP9ReferenceName : uint
        {
            VideoVp9ReferenceNameAltrefFrame = 3,
            VideoVp9ReferenceNameGoldenFrame = 2,
            VideoVp9ReferenceNameIntraFrame = 0,
            VideoVp9ReferenceNameInvalid = 2147483647,
            VideoVp9ReferenceNameLastFrame = 1,
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public enum StdVideoVP9InterpolationFilter : uint
        {
            VideoVp9InterpolationFilterBilinear = 3,
            VideoVp9InterpolationFilterEighttap = 0,
            VideoVp9InterpolationFilterEighttapSharp = 2,
            VideoVp9InterpolationFilterEighttapSmooth = 1,
            VideoVp9InterpolationFilterInvalid = 2147483647,
            VideoVp9InterpolationFilterSwitchable = 4,
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public enum StdVideoVP9ColorSpace : uint
        {
            VideoVp9ColorSpaceBt2020 = 5,
            VideoVp9ColorSpaceBt601 = 1,
            VideoVp9ColorSpaceBt709 = 2,
            VideoVp9ColorSpaceInvalid = 2147483647,
            VideoVp9ColorSpaceReserved = 6,
            VideoVp9ColorSpaceRgb = 7,
            VideoVp9ColorSpaceSmpte170 = 3,
            VideoVp9ColorSpaceSmpte240 = 4,
            VideoVp9ColorSpaceUnknown = 0,
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public unsafe struct StdVideoVP9ColorConfigFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint color_range
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoVP9ColorConfigFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public unsafe struct StdVideoVP9ColorConfig
        {
            /// <summary></summary>
            public StdVideoVP9ColorConfigFlags flags;
            /// <summary></summary>
            public byte BitDepth;
            /// <summary></summary>
            public byte subsampling_x;
            /// <summary></summary>
            public byte subsampling_y;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public byte reserved1;
            /// <summary></summary>
            public StdVideoVP9ColorSpace color_space;
            public StdVideoVP9ColorConfig() { }
            public StdVideoVP9ColorConfig(StdVideoVP9ColorConfigFlags flags, byte BitDepth, byte subsampling_x, byte subsampling_y, byte reserved1, StdVideoVP9ColorSpace color_space)
            {
                this.flags = flags;
                this.BitDepth = BitDepth;
                this.subsampling_x = subsampling_x;
                this.subsampling_y = subsampling_y;
                this.reserved1 = reserved1;
                this.color_space = color_space;
            }
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public unsafe struct StdVideoVP9LoopFilterFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint loop_filter_delta_enabled
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint loop_filter_delta_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoVP9LoopFilterFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public unsafe struct StdVideoVP9LoopFilter
        {
            /// <summary></summary>
            public StdVideoVP9LoopFilterFlags flags;
            /// <summary></summary>
            public byte loop_filter_level;
            /// <summary></summary>
            public byte loop_filter_sharpness;
            /// <summary></summary>
            public byte update_ref_delta;
            /// <summary></summary>
            public fixed sbyte loop_filter_ref_deltas[4];
            /// <summary></summary>
            public byte update_mode_delta;
            /// <summary></summary>
            public fixed sbyte loop_filter_mode_deltas[2];
            public StdVideoVP9LoopFilter() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public unsafe struct StdVideoVP9SegmentationFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint segmentation_update_map
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint segmentation_temporal_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint segmentation_update_data
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint segmentation_abs_or_delta_update
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFFu << 4)) | ((((uint)value) & 0xFFFFFFFu) << 4);
            }
            public StdVideoVP9SegmentationFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std]</b> </summary>
        public unsafe struct StdVideoVP9Segmentation
        {
            /// <summary></summary>
            public StdVideoVP9SegmentationFlags flags;
            /// <summary></summary>
            public fixed byte segmentation_tree_probs[7];
            /// <summary></summary>
            public fixed byte segmentation_pred_prob[3];
            /// <summary></summary>
            public fixed byte FeatureEnabled[8];
            [InlineArray(4)]
            public struct FeatureDataInlineArray1
            {
                [InlineArray(8)]
                public struct FeatureDataInlineArray2
                {
                    public short element;
                }
                public FeatureDataInlineArray2 FeatureData;
            }
            public FeatureDataInlineArray1 FeatureData;
            public StdVideoVP9Segmentation() { }
        }
    }
    namespace VulkanVideoCodecVp9stdDecode
    {
        public static class Constants
        {
            /// <summary>&quot;VK_STD_vulkan_video_codec_vp9_decode&quot;</summary>
            public static ReadOnlySpan<byte> StdVulkanVideoCodecVp9DecodeExtensionName => "VK_STD_vulkan_video_codec_vp9_decode"u8;
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeVP9PictureInfoFlags
        {
            private uint _bitfield0;
            /// <summary></summary>
            public uint error_resilient_mode
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            /// <summary></summary>
            public uint intra_only
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            /// <summary></summary>
            public uint allow_high_precision_mv
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            /// <summary></summary>
            public uint refresh_frame_context
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            /// <summary></summary>
            public uint frame_parallel_decoding_mode
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            /// <summary></summary>
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            /// <summary></summary>
            public uint show_frame
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            /// <summary></summary>
            public uint UsePrevFrameMvs
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            /// <summary></summary>
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 8) & 0xFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFu << 8)) | ((((uint)value) & 0xFFFFFFu) << 8);
            }
            public StdVideoDecodeVP9PictureInfoFlags() { }
        }
        /// <summary><b>[requires: vulkan_video_codec_vp9std_decode]</b> </summary>
        public unsafe struct StdVideoDecodeVP9PictureInfo
        {
            /// <summary></summary>
            public StdVideoDecodeVP9PictureInfoFlags flags;
            /// <summary></summary>
            public StdVideoVP9Profile profile;
            /// <summary></summary>
            public StdVideoVP9FrameType frame_type;
            /// <summary></summary>
            public byte frame_context_idx;
            /// <summary></summary>
            public byte reset_frame_context;
            /// <summary></summary>
            public byte refresh_frame_flags;
            /// <summary></summary>
            public byte ref_frame_sign_bias_mask;
            /// <summary></summary>
            public StdVideoVP9InterpolationFilter interpolation_filter;
            /// <summary></summary>
            public byte base_q_idx;
            /// <summary></summary>
            public sbyte delta_q_y_dc;
            /// <summary></summary>
            public sbyte delta_q_uv_dc;
            /// <summary></summary>
            public sbyte delta_q_uv_ac;
            /// <summary></summary>
            public byte tile_cols_log2;
            /// <summary></summary>
            public byte tile_rows_log2;
            /// <summary>Reserved for future use and must be initialized with 0.</summary>
            public fixed ushort reserved1[3];
            /// <summary></summary>
            public StdVideoVP9ColorConfig* pColorConfig;
            /// <summary></summary>
            public StdVideoVP9LoopFilter* pLoopFilter;
            /// <summary></summary>
            public StdVideoVP9Segmentation* pSegmentation;
            public StdVideoDecodeVP9PictureInfo() { }
        }
    }
    namespace VulkanVideoCodecsCommon
    {
        public static class Constants
        {
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
