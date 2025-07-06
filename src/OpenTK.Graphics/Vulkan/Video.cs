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
        public enum StdVideoAV1Profile : uint
        {
            VideoAv1ProfileHigh = 1,
            VideoAv1ProfileInvalid = 2147483647,
            VideoAv1ProfileMain = 0,
            VideoAv1ProfileProfessional = 2,
        }
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
        public enum StdVideoAV1FrameType : uint
        {
            VideoAv1FrameTypeInter = 1,
            VideoAv1FrameTypeIntraOnly = 2,
            VideoAv1FrameTypeInvalid = 2147483647,
            VideoAv1FrameTypeKey = 0,
            VideoAv1FrameTypeSwitch = 3,
        }
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
        public enum StdVideoAV1InterpolationFilter : uint
        {
            VideoAv1InterpolationFilterBilinear = 3,
            VideoAv1InterpolationFilterEighttap = 0,
            VideoAv1InterpolationFilterEighttapSharp = 2,
            VideoAv1InterpolationFilterEighttapSmooth = 1,
            VideoAv1InterpolationFilterInvalid = 2147483647,
            VideoAv1InterpolationFilterSwitchable = 4,
        }
        public enum StdVideoAV1TxMode : uint
        {
            VideoAv1TxModeInvalid = 2147483647,
            VideoAv1TxModeLargest = 1,
            VideoAv1TxModeOnly4x4 = 0,
            VideoAv1TxModeSelect = 2,
        }
        public enum StdVideoAV1FrameRestorationType : uint
        {
            VideoAv1FrameRestorationTypeInvalid = 2147483647,
            VideoAv1FrameRestorationTypeNone = 0,
            VideoAv1FrameRestorationTypeSgrproj = 2,
            VideoAv1FrameRestorationTypeSwitchable = 3,
            VideoAv1FrameRestorationTypeWiener = 1,
        }
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
        public enum StdVideoAV1ChromaSamplePosition : uint
        {
            VideoAv1ChromaSamplePositionColocated = 2,
            VideoAv1ChromaSamplePositionInvalid = 2147483647,
            VideoAv1ChromaSamplePositionReserved = 3,
            VideoAv1ChromaSamplePositionUnknown = 0,
            VideoAv1ChromaSamplePositionVertical = 1,
        }
        public unsafe struct StdVideoAV1ColorConfigFlags
        {
            private uint _bitfield0;
            public uint mono_chrome
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint color_range
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint separate_uv_delta_q
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint color_description_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFFu << 4)) | ((((uint)value) & 0xFFFFFFFu) << 4);
            }
            public StdVideoAV1ColorConfigFlags() { }
        }
        public unsafe struct StdVideoAV1ColorConfig
        {
            public StdVideoAV1ColorConfigFlags flags;
            public byte BitDepth;
            public byte subsampling_x;
            public byte subsampling_y;
            public byte reserved1;
            public StdVideoAV1ColorPrimaries color_primaries;
            public StdVideoAV1TransferCharacteristics transfer_characteristics;
            public StdVideoAV1MatrixCoefficients matrix_coefficients;
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
        public unsafe struct StdVideoAV1TimingInfoFlags
        {
            private uint _bitfield0;
            public uint equal_picture_interval
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoAV1TimingInfoFlags() { }
        }
        public unsafe struct StdVideoAV1TimingInfo
        {
            public StdVideoAV1TimingInfoFlags flags;
            public uint num_units_in_display_tick;
            public uint time_scale;
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
        public unsafe struct StdVideoAV1LoopFilterFlags
        {
            private uint _bitfield0;
            public uint loop_filter_delta_enabled
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint loop_filter_delta_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoAV1LoopFilterFlags() { }
        }
        public unsafe struct StdVideoAV1LoopFilter
        {
            public StdVideoAV1LoopFilterFlags flags;
            public fixed byte loop_filter_level[4];
            public byte loop_filter_sharpness;
            public byte update_ref_delta;
            public fixed sbyte loop_filter_ref_deltas[8];
            public byte update_mode_delta;
            public fixed sbyte loop_filter_mode_deltas[2];
            public StdVideoAV1LoopFilter() { }
        }
        public unsafe struct StdVideoAV1QuantizationFlags
        {
            private uint _bitfield0;
            public uint using_qmatrix
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint diff_uv_delta
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoAV1QuantizationFlags() { }
        }
        public unsafe struct StdVideoAV1Quantization
        {
            public StdVideoAV1QuantizationFlags flags;
            public byte base_q_idx;
            public sbyte DeltaQYDc;
            public sbyte DeltaQUDc;
            public sbyte DeltaQUAc;
            public sbyte DeltaQVDc;
            public sbyte DeltaQVAc;
            public byte qm_y;
            public byte qm_u;
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
        public unsafe struct StdVideoAV1Segmentation
        {
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
        public unsafe struct StdVideoAV1TileInfoFlags
        {
            private uint _bitfield0;
            public uint uniform_tile_spacing_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoAV1TileInfoFlags() { }
        }
        public unsafe struct StdVideoAV1TileInfo
        {
            public StdVideoAV1TileInfoFlags flags;
            public byte TileCols;
            public byte TileRows;
            public ushort context_update_tile_id;
            public byte tile_size_bytes_minus_1;
            public fixed byte reserved1[7];
            public ushort* pMiColStarts;
            public ushort* pMiRowStarts;
            public ushort* pWidthInSbsMinus1;
            public ushort* pHeightInSbsMinus1;
            public StdVideoAV1TileInfo() { }
        }
        public unsafe struct StdVideoAV1CDEF
        {
            public byte cdef_damping_minus_3;
            public byte cdef_bits;
            public fixed byte cdef_y_pri_strength[8];
            public fixed byte cdef_y_sec_strength[8];
            public fixed byte cdef_uv_pri_strength[8];
            public fixed byte cdef_uv_sec_strength[8];
            public StdVideoAV1CDEF() { }
        }
        public unsafe struct StdVideoAV1LoopRestoration
        {
            [InlineArray(3)]
            public struct FrameRestorationTypeInlineArray1
            {
                public StdVideoAV1FrameRestorationType element;
            }
            public FrameRestorationTypeInlineArray1 FrameRestorationType;
            public fixed ushort LoopRestorationSize[3];
            public StdVideoAV1LoopRestoration() { }
        }
        public unsafe struct StdVideoAV1GlobalMotion
        {
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
        public unsafe struct StdVideoAV1FilmGrainFlags
        {
            private uint _bitfield0;
            public uint chroma_scaling_from_luma
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint overlap_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint clip_to_restricted_range
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint update_grain
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFFu << 4)) | ((((uint)value) & 0xFFFFFFFu) << 4);
            }
            public StdVideoAV1FilmGrainFlags() { }
        }
        public unsafe struct StdVideoAV1FilmGrain
        {
            public StdVideoAV1FilmGrainFlags flags;
            public byte grain_scaling_minus_8;
            public byte ar_coeff_lag;
            public byte ar_coeff_shift_minus_6;
            public byte grain_scale_shift;
            public ushort grain_seed;
            public byte film_grain_params_ref_idx;
            public byte num_y_points;
            public fixed byte point_y_value[14];
            public fixed byte point_y_scaling[14];
            public byte num_cb_points;
            public fixed byte point_cb_value[10];
            public fixed byte point_cb_scaling[10];
            public byte num_cr_points;
            public fixed byte point_cr_value[10];
            public fixed byte point_cr_scaling[10];
            public fixed sbyte ar_coeffs_y_plus_128[24];
            public fixed sbyte ar_coeffs_cb_plus_128[25];
            public fixed sbyte ar_coeffs_cr_plus_128[25];
            public byte cb_mult;
            public byte cb_luma_mult;
            public ushort cb_offset;
            public byte cr_mult;
            public byte cr_luma_mult;
            public ushort cr_offset;
            public StdVideoAV1FilmGrain() { }
        }
        public unsafe struct StdVideoAV1SequenceHeaderFlags
        {
            private uint _bitfield0;
            public uint still_picture
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint reduced_still_picture_header
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint use_128x128_superblock
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint enable_filter_intra
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint enable_intra_edge_filter
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint enable_interintra_compound
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint enable_masked_compound
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint enable_warped_motion
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint enable_dual_filter
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint enable_order_hint
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint enable_jnt_comp
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint enable_ref_frame_mvs
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint frame_id_numbers_present_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            public uint enable_superres
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            public uint enable_cdef
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            public uint enable_restoration
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public uint film_grain_params_present
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            public uint timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            public uint initial_display_delay_present_flag
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 19) & 0x1FFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x1FFFu << 19)) | ((((uint)value) & 0x1FFFu) << 19);
            }
            public StdVideoAV1SequenceHeaderFlags() { }
        }
        public unsafe struct StdVideoAV1SequenceHeader
        {
            public StdVideoAV1SequenceHeaderFlags flags;
            public StdVideoAV1Profile seq_profile;
            public byte frame_width_bits_minus_1;
            public byte frame_height_bits_minus_1;
            public ushort max_frame_width_minus_1;
            public ushort max_frame_height_minus_1;
            public byte delta_frame_id_length_minus_2;
            public byte additional_frame_id_length_minus_1;
            public byte order_hint_bits_minus_1;
            public byte seq_force_integer_mv;
            public byte seq_force_screen_content_tools;
            public fixed byte reserved1[5];
            public StdVideoAV1ColorConfig* pColorConfig;
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
        public unsafe struct StdVideoDecodeAV1PictureInfoFlags
        {
            private uint _bitfield0;
            public uint error_resilient_mode
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint disable_cdf_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint use_superres
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint render_and_frame_size_different
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint allow_screen_content_tools
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint is_filter_switchable
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint force_integer_mv
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint frame_size_override_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint buffer_removal_time_present_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint allow_intrabc
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint frame_refs_short_signaling
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint allow_high_precision_mv
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint is_motion_mode_switchable
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            public uint use_ref_frame_mvs
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            public uint allow_warped_motion
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public uint reduced_tx_set
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            public uint reference_select
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            public uint skip_mode_present
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            public uint delta_q_present
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            public uint delta_lf_present
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            public uint delta_lf_multi
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            public uint segmentation_update_map
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            public uint segmentation_temporal_update
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            public uint segmentation_update_data
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            public uint UsesLr
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            public uint usesChromaLr
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            public uint apply_grain
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 29) & 0x7u);
                set => _bitfield0 = (_bitfield0 & ~(0x7u << 29)) | ((((uint)value) & 0x7u) << 29);
            }
            public StdVideoDecodeAV1PictureInfoFlags() { }
        }
        public unsafe struct StdVideoDecodeAV1PictureInfo
        {
            public StdVideoDecodeAV1PictureInfoFlags flags;
            public StdVideoAV1FrameType frame_type;
            public uint current_frame_id;
            public byte OrderHint;
            public byte primary_ref_frame;
            public byte refresh_frame_flags;
            public byte reserved1;
            public StdVideoAV1InterpolationFilter interpolation_filter;
            public StdVideoAV1TxMode TxMode;
            public byte delta_q_res;
            public byte delta_lf_res;
            public fixed byte SkipModeFrame[2];
            public byte coded_denom;
            public fixed byte reserved2[3];
            public fixed byte OrderHints[8];
            public fixed uint expectedFrameId[8];
            public StdVideoAV1TileInfo* pTileInfo;
            public StdVideoAV1Quantization* pQuantization;
            public StdVideoAV1Segmentation* pSegmentation;
            public StdVideoAV1LoopFilter* pLoopFilter;
            public StdVideoAV1CDEF* pCDEF;
            public StdVideoAV1LoopRestoration* pLoopRestoration;
            public StdVideoAV1GlobalMotion* pGlobalMotion;
            public StdVideoAV1FilmGrain* pFilmGrain;
            public StdVideoDecodeAV1PictureInfo() { }
        }
        public unsafe struct StdVideoDecodeAV1ReferenceInfoFlags
        {
            private uint _bitfield0;
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoDecodeAV1ReferenceInfoFlags() { }
        }
        public unsafe struct StdVideoDecodeAV1ReferenceInfo
        {
            public StdVideoDecodeAV1ReferenceInfoFlags flags;
            public byte frame_type;
            public byte RefFrameSignBias;
            public byte OrderHint;
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
        public unsafe struct StdVideoEncodeAV1DecoderModelInfo
        {
            public byte buffer_delay_length_minus_1;
            public byte buffer_removal_time_length_minus_1;
            public byte frame_presentation_time_length_minus_1;
            public byte reserved1;
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
        public unsafe struct StdVideoEncodeAV1ExtensionHeader
        {
            public byte temporal_id;
            public byte spatial_id;
            public StdVideoEncodeAV1ExtensionHeader() { }
            public StdVideoEncodeAV1ExtensionHeader(byte temporal_id, byte spatial_id)
            {
                this.temporal_id = temporal_id;
                this.spatial_id = spatial_id;
            }
        }
        public unsafe struct StdVideoEncodeAV1OperatingPointInfoFlags
        {
            private uint _bitfield0;
            public uint decoder_model_present_for_this_op
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint low_delay_mode_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint initial_display_delay_present_for_this_op
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 3) & 0x1FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x1FFFFFFFu << 3)) | ((((uint)value) & 0x1FFFFFFFu) << 3);
            }
            public StdVideoEncodeAV1OperatingPointInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeAV1OperatingPointInfo
        {
            public StdVideoEncodeAV1OperatingPointInfoFlags flags;
            public ushort operating_point_idc;
            public byte seq_level_idx;
            public byte seq_tier;
            public uint decoder_buffer_delay;
            public uint encoder_buffer_delay;
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
        public unsafe struct StdVideoEncodeAV1PictureInfoFlags
        {
            private uint _bitfield0;
            public uint error_resilient_mode
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint disable_cdf_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint use_superres
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint render_and_frame_size_different
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint allow_screen_content_tools
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint is_filter_switchable
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint force_integer_mv
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint frame_size_override_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint buffer_removal_time_present_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint allow_intrabc
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint frame_refs_short_signaling
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint allow_high_precision_mv
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint is_motion_mode_switchable
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            public uint use_ref_frame_mvs
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            public uint allow_warped_motion
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public uint reduced_tx_set
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            public uint skip_mode_present
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            public uint delta_q_present
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            public uint delta_lf_present
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            public uint delta_lf_multi
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            public uint segmentation_update_map
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            public uint segmentation_temporal_update
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            public uint segmentation_update_data
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            public uint UsesLr
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            public uint usesChromaLr
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            public uint show_frame
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            public uint showable_frame
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 29) & 0x7u);
                set => _bitfield0 = (_bitfield0 & ~(0x7u << 29)) | ((((uint)value) & 0x7u) << 29);
            }
            public StdVideoEncodeAV1PictureInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeAV1PictureInfo
        {
            public StdVideoEncodeAV1PictureInfoFlags flags;
            public StdVideoAV1FrameType frame_type;
            public uint frame_presentation_time;
            public uint current_frame_id;
            public byte order_hint;
            public byte primary_ref_frame;
            public byte refresh_frame_flags;
            public byte coded_denom;
            public ushort render_width_minus_1;
            public ushort render_height_minus_1;
            public StdVideoAV1InterpolationFilter interpolation_filter;
            public StdVideoAV1TxMode TxMode;
            public byte delta_q_res;
            public byte delta_lf_res;
            public fixed byte ref_order_hint[8];
            public fixed sbyte ref_frame_idx[7];
            public fixed byte reserved1[3];
            public fixed uint delta_frame_id_minus_1[7];
            public StdVideoAV1TileInfo* pTileInfo;
            public StdVideoAV1Quantization* pQuantization;
            public StdVideoAV1Segmentation* pSegmentation;
            public StdVideoAV1LoopFilter* pLoopFilter;
            public StdVideoAV1CDEF* pCDEF;
            public StdVideoAV1LoopRestoration* pLoopRestoration;
            public StdVideoAV1GlobalMotion* pGlobalMotion;
            public StdVideoEncodeAV1ExtensionHeader* pExtensionHeader;
            public uint* pBufferRemovalTimes;
            public StdVideoEncodeAV1PictureInfo() { }
        }
        public unsafe struct StdVideoEncodeAV1ReferenceInfoFlags
        {
            private uint _bitfield0;
            public uint disable_frame_end_update_cdf
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeAV1ReferenceInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeAV1ReferenceInfo
        {
            public StdVideoEncodeAV1ReferenceInfoFlags flags;
            public uint RefFrameId;
            public StdVideoAV1FrameType frame_type;
            public byte OrderHint;
            public fixed byte reserved1[3];
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
        public enum StdVideoH264ChromaFormatIdc : uint
        {
            VideoH264ChromaFormatIdc420 = 1,
            VideoH264ChromaFormatIdc422 = 2,
            VideoH264ChromaFormatIdc444 = 3,
            VideoH264ChromaFormatIdcInvalid = 2147483647,
            VideoH264ChromaFormatIdcMonochrome = 0,
        }
        public enum StdVideoH264ProfileIdc : uint
        {
            /// <summary>Only constrained baseline is supported</summary>
            VideoH264ProfileIdcBaseline = 66,
            VideoH264ProfileIdcHigh = 100,
            VideoH264ProfileIdcHigh444Predictive = 244,
            VideoH264ProfileIdcInvalid = 2147483647,
            VideoH264ProfileIdcMain = 77,
        }
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
        public enum StdVideoH264PocType : uint
        {
            VideoH264PocType0 = 0,
            VideoH264PocType1 = 1,
            VideoH264PocType2 = 2,
            VideoH264PocTypeInvalid = 2147483647,
        }
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
        public enum StdVideoH264WeightedBipredIdc : uint
        {
            VideoH264WeightedBipredIdcDefault = 0,
            VideoH264WeightedBipredIdcExplicit = 1,
            VideoH264WeightedBipredIdcImplicit = 2,
            VideoH264WeightedBipredIdcInvalid = 2147483647,
        }
        public enum StdVideoH264ModificationOfPicNumsIdc : uint
        {
            VideoH264ModificationOfPicNumsIdcEnd = 3,
            VideoH264ModificationOfPicNumsIdcInvalid = 2147483647,
            VideoH264ModificationOfPicNumsIdcLongTerm = 2,
            VideoH264ModificationOfPicNumsIdcShortTermAdd = 1,
            VideoH264ModificationOfPicNumsIdcShortTermSubtract = 0,
        }
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
        public enum StdVideoH264CabacInitIdc : uint
        {
            VideoH264CabacInitIdc0 = 0,
            VideoH264CabacInitIdc1 = 1,
            VideoH264CabacInitIdc2 = 2,
            VideoH264CabacInitIdcInvalid = 2147483647,
        }
        public enum StdVideoH264DisableDeblockingFilterIdc : uint
        {
            VideoH264DisableDeblockingFilterIdcDisabled = 0,
            VideoH264DisableDeblockingFilterIdcEnabled = 1,
            VideoH264DisableDeblockingFilterIdcInvalid = 2147483647,
            VideoH264DisableDeblockingFilterIdcPartial = 2,
        }
        public enum StdVideoH264SliceType : uint
        {
            VideoH264SliceTypeB = 1,
            VideoH264SliceTypeI = 2,
            VideoH264SliceTypeInvalid = 2147483647,
            VideoH264SliceTypeP = 0,
        }
        public enum StdVideoH264PictureType : uint
        {
            VideoH264PictureTypeB = 1,
            VideoH264PictureTypeI = 2,
            VideoH264PictureTypeIdr = 5,
            VideoH264PictureTypeInvalid = 2147483647,
            VideoH264PictureTypeP = 0,
        }
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
        public unsafe struct StdVideoH264SpsVuiFlags
        {
            private uint _bitfield0;
            public uint aspect_ratio_info_present_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint overscan_info_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint overscan_appropriate_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint video_signal_type_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint video_full_range_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint color_description_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint chroma_loc_info_present_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint fixed_frame_rate_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint bitstream_restriction_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint nal_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint vcl_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public StdVideoH264SpsVuiFlags() { }
        }
        public unsafe struct StdVideoH264HrdParameters
        {
            public byte cpb_cnt_minus1;
            public byte bit_rate_scale;
            public byte cpb_size_scale;
            public byte reserved1;
            public fixed uint bit_rate_value_minus1[32];
            public fixed uint cpb_size_value_minus1[32];
            public fixed byte cbr_flag[32];
            public uint initial_cpb_removal_delay_length_minus1;
            public uint cpb_removal_delay_length_minus1;
            public uint dpb_output_delay_length_minus1;
            public uint time_offset_length;
            public StdVideoH264HrdParameters() { }
        }
        public unsafe struct StdVideoH264SequenceParameterSetVui
        {
            public StdVideoH264SpsVuiFlags flags;
            public StdVideoH264AspectRatioIdc aspect_ratio_idc;
            public ushort sar_width;
            public ushort sar_height;
            public byte video_format;
            public byte colour_primaries;
            public byte transfer_characteristics;
            public byte matrix_coefficients;
            public uint num_units_in_tick;
            public uint time_scale;
            public byte max_num_reorder_frames;
            public byte max_dec_frame_buffering;
            public byte chroma_sample_loc_type_top_field;
            public byte chroma_sample_loc_type_bottom_field;
            public uint reserved1;
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
        public unsafe struct StdVideoH264SpsFlags
        {
            private uint _bitfield0;
            public uint constraint_set0_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint constraint_set1_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint constraint_set2_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint constraint_set3_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint constraint_set4_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint constraint_set5_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint direct_8x8_inference_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint mb_adaptive_frame_field_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint frame_mbs_only_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint delta_pic_order_always_zero_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint separate_colour_plane_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint gaps_in_frame_num_value_allowed_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint qpprime_y_zero_transform_bypass_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            public uint frame_cropping_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            public uint seq_scaling_matrix_present_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            public uint vui_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public StdVideoH264SpsFlags() { }
        }
        public unsafe struct StdVideoH264ScalingLists
        {
            public ushort scaling_list_present_mask;
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
        public unsafe struct StdVideoH264SequenceParameterSet
        {
            public StdVideoH264SpsFlags flags;
            public StdVideoH264ProfileIdc profile_idc;
            public StdVideoH264LevelIdc level_idc;
            public StdVideoH264ChromaFormatIdc chroma_format_idc;
            public byte seq_parameter_set_id;
            public byte bit_depth_luma_minus8;
            public byte bit_depth_chroma_minus8;
            public byte log2_max_frame_num_minus4;
            public StdVideoH264PocType pic_order_cnt_type;
            public int offset_for_non_ref_pic;
            public int offset_for_top_to_bottom_field;
            public byte log2_max_pic_order_cnt_lsb_minus4;
            public byte num_ref_frames_in_pic_order_cnt_cycle;
            public byte max_num_ref_frames;
            public byte reserved1;
            public uint pic_width_in_mbs_minus1;
            public uint pic_height_in_map_units_minus1;
            public uint frame_crop_left_offset;
            public uint frame_crop_right_offset;
            public uint frame_crop_top_offset;
            public uint frame_crop_bottom_offset;
            public uint reserved2;
            public int* pOffsetForRefFrame;
            public StdVideoH264ScalingLists* pScalingLists;
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
        public unsafe struct StdVideoH264PpsFlags
        {
            private uint _bitfield0;
            public uint transform_8x8_mode_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint redundant_pic_cnt_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint constrained_intra_pred_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint deblocking_filter_control_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint weighted_pred_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint bottom_field_pic_order_in_frame_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint entropy_coding_mode_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint pic_scaling_matrix_present_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public StdVideoH264PpsFlags() { }
        }
        public unsafe struct StdVideoH264PictureParameterSet
        {
            public StdVideoH264PpsFlags flags;
            public byte seq_parameter_set_id;
            public byte pic_parameter_set_id;
            public byte num_ref_idx_l0_default_active_minus1;
            public byte num_ref_idx_l1_default_active_minus1;
            public StdVideoH264WeightedBipredIdc weighted_bipred_idc;
            public sbyte pic_init_qp_minus26;
            public sbyte pic_init_qs_minus26;
            public sbyte chroma_qp_index_offset;
            public sbyte second_chroma_qp_index_offset;
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
        public enum StdVideoDecodeH264FieldOrderCount : uint
        {
            VideoDecodeH264FieldOrderCountBottom = 1,
            VideoDecodeH264FieldOrderCountInvalid = 2147483647,
            VideoDecodeH264FieldOrderCountTop = 0,
        }
        public unsafe struct StdVideoDecodeH264PictureInfoFlags
        {
            private uint _bitfield0;
            public uint field_pic_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint is_intra
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint IdrPicFlag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint bottom_field_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint is_reference
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint complementary_field_pair
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public StdVideoDecodeH264PictureInfoFlags() { }
        }
        public unsafe struct StdVideoDecodeH264PictureInfo
        {
            public StdVideoDecodeH264PictureInfoFlags flags;
            public byte seq_parameter_set_id;
            public byte pic_parameter_set_id;
            public byte reserved1;
            public byte reserved2;
            public ushort frame_num;
            public ushort idr_pic_id;
            public fixed int PicOrderCnt[2];
            public StdVideoDecodeH264PictureInfo() { }
        }
        public unsafe struct StdVideoDecodeH264ReferenceInfoFlags
        {
            private uint _bitfield0;
            public uint top_field_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint bottom_field_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint is_non_existing
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public StdVideoDecodeH264ReferenceInfoFlags() { }
        }
        public unsafe struct StdVideoDecodeH264ReferenceInfo
        {
            public StdVideoDecodeH264ReferenceInfoFlags flags;
            public ushort FrameNum;
            public ushort reserved;
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
        public unsafe struct StdVideoEncodeH264WeightTableFlags
        {
            public uint luma_weight_l0_flag;
            public uint chroma_weight_l0_flag;
            public uint luma_weight_l1_flag;
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
        public unsafe struct StdVideoEncodeH264WeightTable
        {
            public StdVideoEncodeH264WeightTableFlags flags;
            public byte luma_log2_weight_denom;
            public byte chroma_log2_weight_denom;
            public fixed sbyte luma_weight_l0[32];
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
            public fixed sbyte luma_weight_l1[32];
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
        public unsafe struct StdVideoEncodeH264SliceHeaderFlags
        {
            private uint _bitfield0;
            public uint direct_spatial_mv_pred_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint num_ref_idx_active_override_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH264SliceHeaderFlags() { }
        }
        public unsafe struct StdVideoEncodeH264PictureInfoFlags
        {
            private uint _bitfield0;
            public uint IdrPicFlag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint is_reference
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint no_output_of_prior_pics_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint long_term_reference_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint adaptive_ref_pic_marking_mode_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 5) & 0x7FFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFu << 5)) | ((((uint)value) & 0x7FFFFFFu) << 5);
            }
            public StdVideoEncodeH264PictureInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeH264ReferenceInfoFlags
        {
            private uint _bitfield0;
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoEncodeH264ReferenceInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeH264ReferenceListsInfoFlags
        {
            private uint _bitfield0;
            public uint ref_pic_list_modification_flag_l0
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint ref_pic_list_modification_flag_l1
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH264ReferenceListsInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeH264RefListModEntry
        {
            public StdVideoH264ModificationOfPicNumsIdc modification_of_pic_nums_idc;
            public ushort abs_diff_pic_num_minus1;
            public ushort long_term_pic_num;
            public StdVideoEncodeH264RefListModEntry() { }
            public StdVideoEncodeH264RefListModEntry(StdVideoH264ModificationOfPicNumsIdc modification_of_pic_nums_idc, ushort abs_diff_pic_num_minus1, ushort long_term_pic_num)
            {
                this.modification_of_pic_nums_idc = modification_of_pic_nums_idc;
                this.abs_diff_pic_num_minus1 = abs_diff_pic_num_minus1;
                this.long_term_pic_num = long_term_pic_num;
            }
        }
        public unsafe struct StdVideoEncodeH264RefPicMarkingEntry
        {
            public StdVideoH264MemMgmtControlOp memory_management_control_operation;
            public ushort difference_of_pic_nums_minus1;
            public ushort long_term_pic_num;
            public ushort long_term_frame_idx;
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
        public unsafe struct StdVideoEncodeH264ReferenceListsInfo
        {
            public StdVideoEncodeH264ReferenceListsInfoFlags flags;
            public byte num_ref_idx_l0_active_minus1;
            public byte num_ref_idx_l1_active_minus1;
            public fixed byte RefPicList0[32];
            public fixed byte RefPicList1[32];
            public byte refList0ModOpCount;
            public byte refList1ModOpCount;
            public byte refPicMarkingOpCount;
            public fixed byte reserved1[7];
            public StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;
            public StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;
            public StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;
            public StdVideoEncodeH264ReferenceListsInfo() { }
        }
        public unsafe struct StdVideoEncodeH264PictureInfo
        {
            public StdVideoEncodeH264PictureInfoFlags flags;
            public byte seq_parameter_set_id;
            public byte pic_parameter_set_id;
            public ushort idr_pic_id;
            public StdVideoH264PictureType primary_pic_type;
            public uint frame_num;
            public int PicOrderCnt;
            public byte temporal_id;
            public fixed byte reserved1[3];
            public StdVideoEncodeH264ReferenceListsInfo* pRefLists;
            public StdVideoEncodeH264PictureInfo() { }
        }
        public unsafe struct StdVideoEncodeH264ReferenceInfo
        {
            public StdVideoEncodeH264ReferenceInfoFlags flags;
            public StdVideoH264PictureType primary_pic_type;
            public uint FrameNum;
            public int PicOrderCnt;
            public ushort long_term_pic_num;
            public ushort long_term_frame_idx;
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
        public unsafe struct StdVideoEncodeH264SliceHeader
        {
            public StdVideoEncodeH264SliceHeaderFlags flags;
            public uint first_mb_in_slice;
            public StdVideoH264SliceType slice_type;
            public sbyte slice_alpha_c0_offset_div2;
            public sbyte slice_beta_offset_div2;
            public sbyte slice_qp_delta;
            public byte reserved1;
            public StdVideoH264CabacInitIdc cabac_init_idc;
            public StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc;
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
        public enum StdVideoH265ChromaFormatIdc : uint
        {
            VideoH265ChromaFormatIdc420 = 1,
            VideoH265ChromaFormatIdc422 = 2,
            VideoH265ChromaFormatIdc444 = 3,
            VideoH265ChromaFormatIdcInvalid = 2147483647,
            VideoH265ChromaFormatIdcMonochrome = 0,
        }
        public enum StdVideoH265ProfileIdc : uint
        {
            VideoH265ProfileIdcFormatRangeExtensions = 4,
            VideoH265ProfileIdcInvalid = 2147483647,
            VideoH265ProfileIdcMain = 1,
            VideoH265ProfileIdcMain10 = 2,
            VideoH265ProfileIdcMainStillPicture = 3,
            VideoH265ProfileIdcSccExtensions = 9,
        }
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
        public enum StdVideoH265SliceType : uint
        {
            VideoH265SliceTypeB = 0,
            VideoH265SliceTypeI = 2,
            VideoH265SliceTypeInvalid = 2147483647,
            VideoH265SliceTypeP = 1,
        }
        public enum StdVideoH265PictureType : uint
        {
            VideoH265PictureTypeB = 1,
            VideoH265PictureTypeI = 2,
            VideoH265PictureTypeIdr = 3,
            VideoH265PictureTypeInvalid = 2147483647,
            VideoH265PictureTypeP = 0,
        }
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
        public unsafe struct StdVideoH265DecPicBufMgr
        {
            public fixed uint max_latency_increase_plus1[7];
            public fixed byte max_dec_pic_buffering_minus1[7];
            public fixed byte max_num_reorder_pics[7];
            public StdVideoH265DecPicBufMgr() { }
        }
        public unsafe struct StdVideoH265SubLayerHrdParameters
        {
            public fixed uint bit_rate_value_minus1[32];
            public fixed uint cpb_size_value_minus1[32];
            public fixed uint cpb_size_du_value_minus1[32];
            public fixed uint bit_rate_du_value_minus1[32];
            public uint cbr_flag;
            public StdVideoH265SubLayerHrdParameters() { }
        }
        public unsafe struct StdVideoH265HrdFlags
        {
            private uint _bitfield0;
            public uint nal_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint vcl_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint sub_pic_hrd_params_present_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint sub_pic_cpb_params_in_pic_timing_sei_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint fixed_pic_rate_general_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFu << 4)) | ((((uint)value) & 0xFFu) << 4);
            }
            public uint fixed_pic_rate_within_cvs_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0xFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFu << 12)) | ((((uint)value) & 0xFFu) << 12);
            }
            public uint low_delay_hrd_flag
            {
                get => (uint)((_bitfield0 >> 20) & 0xFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFu << 20)) | ((((uint)value) & 0xFFu) << 20);
            }
            public StdVideoH265HrdFlags() { }
        }
        public unsafe struct StdVideoH265HrdParameters
        {
            public StdVideoH265HrdFlags flags;
            public byte tick_divisor_minus2;
            public byte du_cpb_removal_delay_increment_length_minus1;
            public byte dpb_output_delay_du_length_minus1;
            public byte bit_rate_scale;
            public byte cpb_size_scale;
            public byte cpb_size_du_scale;
            public byte initial_cpb_removal_delay_length_minus1;
            public byte au_cpb_removal_delay_length_minus1;
            public byte dpb_output_delay_length_minus1;
            public fixed byte cpb_cnt_minus1[7];
            public fixed ushort elemental_duration_in_tc_minus1[7];
            public fixed ushort reserved[3];
            public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersNal;
            public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersVcl;
            public StdVideoH265HrdParameters() { }
        }
        public unsafe struct StdVideoH265VpsFlags
        {
            private uint _bitfield0;
            public uint vps_temporal_id_nesting_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint vps_sub_layer_ordering_info_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint vps_timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint vps_poc_proportional_to_timing_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public StdVideoH265VpsFlags() { }
        }
        public unsafe struct StdVideoH265ProfileTierLevelFlags
        {
            private uint _bitfield0;
            public uint general_tier_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint general_progressive_source_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint general_interlaced_source_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint general_non_packed_constraint_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint general_frame_only_constraint_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public StdVideoH265ProfileTierLevelFlags() { }
        }
        public unsafe struct StdVideoH265ProfileTierLevel
        {
            public StdVideoH265ProfileTierLevelFlags flags;
            public StdVideoH265ProfileIdc general_profile_idc;
            public StdVideoH265LevelIdc general_level_idc;
            public StdVideoH265ProfileTierLevel() { }
            public StdVideoH265ProfileTierLevel(StdVideoH265ProfileTierLevelFlags flags, StdVideoH265ProfileIdc general_profile_idc, StdVideoH265LevelIdc general_level_idc)
            {
                this.flags = flags;
                this.general_profile_idc = general_profile_idc;
                this.general_level_idc = general_level_idc;
            }
        }
        public unsafe struct StdVideoH265VideoParameterSet
        {
            public StdVideoH265VpsFlags flags;
            public byte vps_video_parameter_set_id;
            public byte vps_max_sub_layers_minus1;
            public byte reserved1;
            public byte reserved2;
            public uint vps_num_units_in_tick;
            public uint vps_time_scale;
            public uint vps_num_ticks_poc_diff_one_minus1;
            public uint reserved3;
            public StdVideoH265DecPicBufMgr* pDecPicBufMgr;
            public StdVideoH265HrdParameters* pHrdParameters;
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
            public fixed byte ScalingListDCCoef16x16[6];
            public fixed byte ScalingListDCCoef32x32[2];
            public StdVideoH265ScalingLists() { }
        }
        public unsafe struct StdVideoH265SpsVuiFlags
        {
            private uint _bitfield0;
            public uint aspect_ratio_info_present_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint overscan_info_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint overscan_appropriate_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint video_signal_type_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint video_full_range_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint colour_description_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint chroma_loc_info_present_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint neutral_chroma_indication_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint field_seq_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint frame_field_info_present_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint default_display_window_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint vui_timing_info_present_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint vui_poc_proportional_to_timing_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            public uint vui_hrd_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            public uint bitstream_restriction_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            public uint tiles_fixed_structure_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public uint motion_vectors_over_pic_boundaries_flag
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            public uint restricted_ref_pic_lists_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            public StdVideoH265SpsVuiFlags() { }
        }
        public unsafe struct StdVideoH265SequenceParameterSetVui
        {
            public StdVideoH265SpsVuiFlags flags;
            public StdVideoH265AspectRatioIdc aspect_ratio_idc;
            public ushort sar_width;
            public ushort sar_height;
            public byte video_format;
            public byte colour_primaries;
            public byte transfer_characteristics;
            public byte matrix_coeffs;
            public byte chroma_sample_loc_type_top_field;
            public byte chroma_sample_loc_type_bottom_field;
            public byte reserved1;
            public byte reserved2;
            public ushort def_disp_win_left_offset;
            public ushort def_disp_win_right_offset;
            public ushort def_disp_win_top_offset;
            public ushort def_disp_win_bottom_offset;
            public uint vui_num_units_in_tick;
            public uint vui_time_scale;
            public uint vui_num_ticks_poc_diff_one_minus1;
            public ushort min_spatial_segmentation_idc;
            public ushort reserved3;
            public byte max_bytes_per_pic_denom;
            public byte max_bits_per_min_cu_denom;
            public byte log2_max_mv_length_horizontal;
            public byte log2_max_mv_length_vertical;
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
        public unsafe struct StdVideoH265SpsFlags
        {
            private uint _bitfield0;
            public uint sps_temporal_id_nesting_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint separate_colour_plane_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint conformance_window_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint sps_sub_layer_ordering_info_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint scaling_list_enabled_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint sps_scaling_list_data_present_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint amp_enabled_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint sample_adaptive_offset_enabled_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint pcm_enabled_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint pcm_loop_filter_disabled_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint long_term_ref_pics_present_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint sps_temporal_mvp_enabled_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint strong_intra_smoothing_enabled_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            public uint vui_parameters_present_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            public uint sps_extension_present_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            public uint sps_range_extension_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public uint transform_skip_rotation_enabled_flag
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            public uint transform_skip_context_enabled_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            public uint implicit_rdpcm_enabled_flag
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            public uint explicit_rdpcm_enabled_flag
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            public uint extended_precision_processing_flag
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            public uint intra_smoothing_disabled_flag
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            public uint high_precision_offsets_enabled_flag
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            public uint persistent_rice_adaptation_enabled_flag
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            public uint cabac_bypass_alignment_enabled_flag
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            public uint sps_scc_extension_flag
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            public uint sps_curr_pic_ref_enabled_flag
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            public uint palette_mode_enabled_flag
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            public uint sps_palette_predictor_initializers_present_flag
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            public uint intra_boundary_filtering_disabled_flag
            {
                get => (uint)((_bitfield0 >> 29) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 29)) | ((((uint)value) & 0x1u) << 29);
            }
            public StdVideoH265SpsFlags() { }
        }
        public unsafe struct StdVideoH265ShortTermRefPicSetFlags
        {
            private uint _bitfield0;
            public uint inter_ref_pic_set_prediction_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint delta_rps_sign
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public StdVideoH265ShortTermRefPicSetFlags() { }
        }
        public unsafe struct StdVideoH265ShortTermRefPicSet
        {
            public StdVideoH265ShortTermRefPicSetFlags flags;
            public uint delta_idx_minus1;
            public ushort use_delta_flag;
            public ushort abs_delta_rps_minus1;
            public ushort used_by_curr_pic_flag;
            public ushort used_by_curr_pic_s0_flag;
            public ushort used_by_curr_pic_s1_flag;
            public ushort reserved1;
            public byte reserved2;
            public byte reserved3;
            public byte num_negative_pics;
            public byte num_positive_pics;
            public fixed ushort delta_poc_s0_minus1[16];
            public fixed ushort delta_poc_s1_minus1[16];
            public StdVideoH265ShortTermRefPicSet() { }
        }
        public unsafe struct StdVideoH265LongTermRefPicsSps
        {
            public uint used_by_curr_pic_lt_sps_flag;
            public fixed uint lt_ref_pic_poc_lsb_sps[32];
            public StdVideoH265LongTermRefPicsSps() { }
        }
        public unsafe struct StdVideoH265SequenceParameterSet
        {
            public StdVideoH265SpsFlags flags;
            public StdVideoH265ChromaFormatIdc chroma_format_idc;
            public uint pic_width_in_luma_samples;
            public uint pic_height_in_luma_samples;
            public byte sps_video_parameter_set_id;
            public byte sps_max_sub_layers_minus1;
            public byte sps_seq_parameter_set_id;
            public byte bit_depth_luma_minus8;
            public byte bit_depth_chroma_minus8;
            public byte log2_max_pic_order_cnt_lsb_minus4;
            public byte log2_min_luma_coding_block_size_minus3;
            public byte log2_diff_max_min_luma_coding_block_size;
            public byte log2_min_luma_transform_block_size_minus2;
            public byte log2_diff_max_min_luma_transform_block_size;
            public byte max_transform_hierarchy_depth_inter;
            public byte max_transform_hierarchy_depth_intra;
            public byte num_short_term_ref_pic_sets;
            public byte num_long_term_ref_pics_sps;
            public byte pcm_sample_bit_depth_luma_minus1;
            public byte pcm_sample_bit_depth_chroma_minus1;
            public byte log2_min_pcm_luma_coding_block_size_minus3;
            public byte log2_diff_max_min_pcm_luma_coding_block_size;
            public byte reserved1;
            public byte reserved2;
            public byte palette_max_size;
            public byte delta_palette_max_predictor_size;
            public byte motion_vector_resolution_control_idc;
            public byte sps_num_palette_predictor_initializers_minus1;
            public uint conf_win_left_offset;
            public uint conf_win_right_offset;
            public uint conf_win_top_offset;
            public uint conf_win_bottom_offset;
            public StdVideoH265ProfileTierLevel* pProfileTierLevel;
            public StdVideoH265DecPicBufMgr* pDecPicBufMgr;
            public StdVideoH265ScalingLists* pScalingLists;
            public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;
            public StdVideoH265LongTermRefPicsSps* pLongTermRefPicsSps;
            public StdVideoH265SequenceParameterSetVui* pSequenceParameterSetVui;
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
        public unsafe struct StdVideoH265PpsFlags
        {
            private uint _bitfield0;
            public uint dependent_slice_segments_enabled_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint output_flag_present_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint sign_data_hiding_enabled_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint cabac_init_present_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint constrained_intra_pred_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint transform_skip_enabled_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint cu_qp_delta_enabled_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint pps_slice_chroma_qp_offsets_present_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint weighted_pred_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint weighted_bipred_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint transquant_bypass_enabled_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint tiles_enabled_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint entropy_coding_sync_enabled_flag
            {
                get => (uint)((_bitfield0 >> 12) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 12)) | ((((uint)value) & 0x1u) << 12);
            }
            public uint uniform_spacing_flag
            {
                get => (uint)((_bitfield0 >> 13) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 13)) | ((((uint)value) & 0x1u) << 13);
            }
            public uint loop_filter_across_tiles_enabled_flag
            {
                get => (uint)((_bitfield0 >> 14) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 14)) | ((((uint)value) & 0x1u) << 14);
            }
            public uint pps_loop_filter_across_slices_enabled_flag
            {
                get => (uint)((_bitfield0 >> 15) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 15)) | ((((uint)value) & 0x1u) << 15);
            }
            public uint deblocking_filter_control_present_flag
            {
                get => (uint)((_bitfield0 >> 16) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 16)) | ((((uint)value) & 0x1u) << 16);
            }
            public uint deblocking_filter_override_enabled_flag
            {
                get => (uint)((_bitfield0 >> 17) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 17)) | ((((uint)value) & 0x1u) << 17);
            }
            public uint pps_deblocking_filter_disabled_flag
            {
                get => (uint)((_bitfield0 >> 18) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 18)) | ((((uint)value) & 0x1u) << 18);
            }
            public uint pps_scaling_list_data_present_flag
            {
                get => (uint)((_bitfield0 >> 19) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 19)) | ((((uint)value) & 0x1u) << 19);
            }
            public uint lists_modification_present_flag
            {
                get => (uint)((_bitfield0 >> 20) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 20)) | ((((uint)value) & 0x1u) << 20);
            }
            public uint slice_segment_header_extension_present_flag
            {
                get => (uint)((_bitfield0 >> 21) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 21)) | ((((uint)value) & 0x1u) << 21);
            }
            public uint pps_extension_present_flag
            {
                get => (uint)((_bitfield0 >> 22) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 22)) | ((((uint)value) & 0x1u) << 22);
            }
            public uint cross_component_prediction_enabled_flag
            {
                get => (uint)((_bitfield0 >> 23) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 23)) | ((((uint)value) & 0x1u) << 23);
            }
            public uint chroma_qp_offset_list_enabled_flag
            {
                get => (uint)((_bitfield0 >> 24) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 24)) | ((((uint)value) & 0x1u) << 24);
            }
            public uint pps_curr_pic_ref_enabled_flag
            {
                get => (uint)((_bitfield0 >> 25) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 25)) | ((((uint)value) & 0x1u) << 25);
            }
            public uint residual_adaptive_colour_transform_enabled_flag
            {
                get => (uint)((_bitfield0 >> 26) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 26)) | ((((uint)value) & 0x1u) << 26);
            }
            public uint pps_slice_act_qp_offsets_present_flag
            {
                get => (uint)((_bitfield0 >> 27) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 27)) | ((((uint)value) & 0x1u) << 27);
            }
            public uint pps_palette_predictor_initializers_present_flag
            {
                get => (uint)((_bitfield0 >> 28) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 28)) | ((((uint)value) & 0x1u) << 28);
            }
            public uint monochrome_palette_flag
            {
                get => (uint)((_bitfield0 >> 29) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 29)) | ((((uint)value) & 0x1u) << 29);
            }
            public uint pps_range_extension_flag
            {
                get => (uint)((_bitfield0 >> 30) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 30)) | ((((uint)value) & 0x1u) << 30);
            }
            public StdVideoH265PpsFlags() { }
        }
        public unsafe struct StdVideoH265PictureParameterSet
        {
            public StdVideoH265PpsFlags flags;
            public byte pps_pic_parameter_set_id;
            public byte pps_seq_parameter_set_id;
            public byte sps_video_parameter_set_id;
            public byte num_extra_slice_header_bits;
            public byte num_ref_idx_l0_default_active_minus1;
            public byte num_ref_idx_l1_default_active_minus1;
            public sbyte init_qp_minus26;
            public byte diff_cu_qp_delta_depth;
            public sbyte pps_cb_qp_offset;
            public sbyte pps_cr_qp_offset;
            public sbyte pps_beta_offset_div2;
            public sbyte pps_tc_offset_div2;
            public byte log2_parallel_merge_level_minus2;
            public byte log2_max_transform_skip_block_size_minus2;
            public byte diff_cu_chroma_qp_offset_depth;
            public byte chroma_qp_offset_list_len_minus1;
            public fixed sbyte cb_qp_offset_list[6];
            public fixed sbyte cr_qp_offset_list[6];
            public byte log2_sao_offset_scale_luma;
            public byte log2_sao_offset_scale_chroma;
            public sbyte pps_act_y_qp_offset_plus5;
            public sbyte pps_act_cb_qp_offset_plus5;
            public sbyte pps_act_cr_qp_offset_plus3;
            public byte pps_num_palette_predictor_initializers;
            public byte luma_bit_depth_entry_minus8;
            public byte chroma_bit_depth_entry_minus8;
            public byte num_tile_columns_minus1;
            public byte num_tile_rows_minus1;
            public byte reserved1;
            public byte reserved2;
            public fixed ushort column_width_minus1[19];
            public fixed ushort row_height_minus1[21];
            public uint reserved3;
            public StdVideoH265ScalingLists* pScalingLists;
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
        public unsafe struct StdVideoDecodeH265PictureInfoFlags
        {
            private uint _bitfield0;
            public uint IrapPicFlag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint IdrPicFlag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint IsReference
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint short_term_ref_pic_set_sps_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public StdVideoDecodeH265PictureInfoFlags() { }
        }
        public unsafe struct StdVideoDecodeH265PictureInfo
        {
            public StdVideoDecodeH265PictureInfoFlags flags;
            public byte sps_video_parameter_set_id;
            public byte pps_seq_parameter_set_id;
            public byte pps_pic_parameter_set_id;
            public byte NumDeltaPocsOfRefRpsIdx;
            public int PicOrderCntVal;
            public ushort NumBitsForSTRefPicSetInSlice;
            public ushort reserved;
            public fixed byte RefPicSetStCurrBefore[8];
            public fixed byte RefPicSetStCurrAfter[8];
            public fixed byte RefPicSetLtCurr[8];
            public StdVideoDecodeH265PictureInfo() { }
        }
        public unsafe struct StdVideoDecodeH265ReferenceInfoFlags
        {
            private uint _bitfield0;
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint unused_for_reference
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public StdVideoDecodeH265ReferenceInfoFlags() { }
        }
        public unsafe struct StdVideoDecodeH265ReferenceInfo
        {
            public StdVideoDecodeH265ReferenceInfoFlags flags;
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
        public unsafe struct StdVideoEncodeH265WeightTableFlags
        {
            public ushort luma_weight_l0_flag;
            public ushort chroma_weight_l0_flag;
            public ushort luma_weight_l1_flag;
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
        public unsafe struct StdVideoEncodeH265WeightTable
        {
            public StdVideoEncodeH265WeightTableFlags flags;
            public byte luma_log2_weight_denom;
            public sbyte delta_chroma_log2_weight_denom;
            public fixed sbyte delta_luma_weight_l0[15];
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
            public fixed sbyte delta_luma_weight_l1[15];
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
        public unsafe struct StdVideoEncodeH265SliceSegmentHeaderFlags
        {
            private uint _bitfield0;
            public uint first_slice_segment_in_pic_flag
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint dependent_slice_segment_flag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint slice_sao_luma_flag
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint slice_sao_chroma_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint num_ref_idx_active_override_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint mvd_l1_zero_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint cabac_init_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint cu_chroma_qp_offset_enabled_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint deblocking_filter_override_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint slice_deblocking_filter_disabled_flag
            {
                get => (uint)((_bitfield0 >> 9) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 9)) | ((((uint)value) & 0x1u) << 9);
            }
            public uint collocated_from_l0_flag
            {
                get => (uint)((_bitfield0 >> 10) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 10)) | ((((uint)value) & 0x1u) << 10);
            }
            public uint slice_loop_filter_across_slices_enabled_flag
            {
                get => (uint)((_bitfield0 >> 11) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 11)) | ((((uint)value) & 0x1u) << 11);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 12) & 0xFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFu << 12)) | ((((uint)value) & 0xFFFFFu) << 12);
            }
            public StdVideoEncodeH265SliceSegmentHeaderFlags() { }
        }
        public unsafe struct StdVideoEncodeH265SliceSegmentHeader
        {
            public StdVideoEncodeH265SliceSegmentHeaderFlags flags;
            public StdVideoH265SliceType slice_type;
            public uint slice_segment_address;
            public byte collocated_ref_idx;
            public byte MaxNumMergeCand;
            public sbyte slice_cb_qp_offset;
            public sbyte slice_cr_qp_offset;
            public sbyte slice_beta_offset_div2;
            public sbyte slice_tc_offset_div2;
            public sbyte slice_act_y_qp_offset;
            public sbyte slice_act_cb_qp_offset;
            public sbyte slice_act_cr_qp_offset;
            public sbyte slice_qp_delta;
            public ushort reserved1;
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
        public unsafe struct StdVideoEncodeH265ReferenceListsInfoFlags
        {
            private uint _bitfield0;
            public uint ref_pic_list_modification_flag_l0
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint ref_pic_list_modification_flag_l1
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH265ReferenceListsInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeH265ReferenceListsInfo
        {
            public StdVideoEncodeH265ReferenceListsInfoFlags flags;
            public byte num_ref_idx_l0_active_minus1;
            public byte num_ref_idx_l1_active_minus1;
            public fixed byte RefPicList0[15];
            public fixed byte RefPicList1[15];
            public fixed byte list_entry_l0[15];
            public fixed byte list_entry_l1[15];
            public StdVideoEncodeH265ReferenceListsInfo() { }
        }
        public unsafe struct StdVideoEncodeH265PictureInfoFlags
        {
            private uint _bitfield0;
            public uint is_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint IrapPicFlag
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint discardable_flag
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint cross_layer_bla_flag
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint pic_output_flag
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint no_output_of_prior_pics_flag
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint short_term_ref_pic_set_sps_flag
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint slice_temporal_mvp_enabled_flag
            {
                get => (uint)((_bitfield0 >> 8) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 8)) | ((((uint)value) & 0x1u) << 8);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 9) & 0x7FFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFu << 9)) | ((((uint)value) & 0x7FFFFFu) << 9);
            }
            public StdVideoEncodeH265PictureInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeH265LongTermRefPics
        {
            public byte num_long_term_sps;
            public byte num_long_term_pics;
            public fixed byte lt_idx_sps[32];
            public fixed byte poc_lsb_lt[16];
            public ushort used_by_curr_pic_lt_flag;
            public fixed byte delta_poc_msb_present_flag[48];
            public fixed byte delta_poc_msb_cycle_lt[48];
            public StdVideoEncodeH265LongTermRefPics() { }
        }
        public unsafe struct StdVideoEncodeH265PictureInfo
        {
            public StdVideoEncodeH265PictureInfoFlags flags;
            public StdVideoH265PictureType pic_type;
            public byte sps_video_parameter_set_id;
            public byte pps_seq_parameter_set_id;
            public byte pps_pic_parameter_set_id;
            public byte short_term_ref_pic_set_idx;
            public int PicOrderCntVal;
            public byte TemporalId;
            public fixed byte reserved1[7];
            public StdVideoEncodeH265ReferenceListsInfo* pRefLists;
            public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;
            public StdVideoEncodeH265LongTermRefPics* pLongTermRefPics;
            public StdVideoEncodeH265PictureInfo() { }
        }
        public unsafe struct StdVideoEncodeH265ReferenceInfoFlags
        {
            private uint _bitfield0;
            public uint used_for_long_term_reference
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint unused_for_reference
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoEncodeH265ReferenceInfoFlags() { }
        }
        public unsafe struct StdVideoEncodeH265ReferenceInfo
        {
            public StdVideoEncodeH265ReferenceInfoFlags flags;
            public StdVideoH265PictureType pic_type;
            public int PicOrderCntVal;
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
        public enum StdVideoVP9Profile : uint
        {
            VideoVp9Profile0 = 0,
            VideoVp9Profile1 = 1,
            VideoVp9Profile2 = 2,
            VideoVp9Profile3 = 3,
            VideoVp9ProfileInvalid = 2147483647,
        }
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
        public enum StdVideoVP9FrameType : uint
        {
            VideoVp9FrameTypeInvalid = 2147483647,
            VideoVp9FrameTypeKey = 0,
            VideoVp9FrameTypeNonKey = 1,
        }
        public enum StdVideoVP9ReferenceName : uint
        {
            VideoVp9ReferenceNameAltrefFrame = 3,
            VideoVp9ReferenceNameGoldenFrame = 2,
            VideoVp9ReferenceNameIntraFrame = 0,
            VideoVp9ReferenceNameInvalid = 2147483647,
            VideoVp9ReferenceNameLastFrame = 1,
        }
        public enum StdVideoVP9InterpolationFilter : uint
        {
            VideoVp9InterpolationFilterBilinear = 3,
            VideoVp9InterpolationFilterEighttap = 0,
            VideoVp9InterpolationFilterEighttapSharp = 2,
            VideoVp9InterpolationFilterEighttapSmooth = 1,
            VideoVp9InterpolationFilterInvalid = 2147483647,
            VideoVp9InterpolationFilterSwitchable = 4,
        }
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
        public unsafe struct StdVideoVP9ColorConfigFlags
        {
            private uint _bitfield0;
            public uint color_range
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 1) & 0x7FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x7FFFFFFFu << 1)) | ((((uint)value) & 0x7FFFFFFFu) << 1);
            }
            public StdVideoVP9ColorConfigFlags() { }
        }
        public unsafe struct StdVideoVP9ColorConfig
        {
            public StdVideoVP9ColorConfigFlags flags;
            public byte BitDepth;
            public byte subsampling_x;
            public byte subsampling_y;
            public byte reserved1;
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
        public unsafe struct StdVideoVP9LoopFilterFlags
        {
            private uint _bitfield0;
            public uint loop_filter_delta_enabled
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint loop_filter_delta_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 2) & 0x3FFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0x3FFFFFFFu << 2)) | ((((uint)value) & 0x3FFFFFFFu) << 2);
            }
            public StdVideoVP9LoopFilterFlags() { }
        }
        public unsafe struct StdVideoVP9LoopFilter
        {
            public StdVideoVP9LoopFilterFlags flags;
            public byte loop_filter_level;
            public byte loop_filter_sharpness;
            public byte update_ref_delta;
            public fixed sbyte loop_filter_ref_deltas[4];
            public byte update_mode_delta;
            public fixed sbyte loop_filter_mode_deltas[2];
            public StdVideoVP9LoopFilter() { }
        }
        public unsafe struct StdVideoVP9SegmentationFlags
        {
            private uint _bitfield0;
            public uint segmentation_update_map
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint segmentation_temporal_update
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint segmentation_update_data
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint segmentation_abs_or_delta_update
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 4) & 0xFFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFFu << 4)) | ((((uint)value) & 0xFFFFFFFu) << 4);
            }
            public StdVideoVP9SegmentationFlags() { }
        }
        public unsafe struct StdVideoVP9Segmentation
        {
            public StdVideoVP9SegmentationFlags flags;
            public fixed byte segmentation_tree_probs[7];
            public fixed byte segmentation_pred_prob[3];
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
        public unsafe struct StdVideoDecodeVP9PictureInfoFlags
        {
            private uint _bitfield0;
            public uint error_resilient_mode
            {
                get => (uint)((_bitfield0 >> 0) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 0)) | ((((uint)value) & 0x1u) << 0);
            }
            public uint intra_only
            {
                get => (uint)((_bitfield0 >> 1) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 1)) | ((((uint)value) & 0x1u) << 1);
            }
            public uint allow_high_precision_mv
            {
                get => (uint)((_bitfield0 >> 2) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 2)) | ((((uint)value) & 0x1u) << 2);
            }
            public uint refresh_frame_context
            {
                get => (uint)((_bitfield0 >> 3) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 3)) | ((((uint)value) & 0x1u) << 3);
            }
            public uint frame_parallel_decoding_mode
            {
                get => (uint)((_bitfield0 >> 4) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 4)) | ((((uint)value) & 0x1u) << 4);
            }
            public uint segmentation_enabled
            {
                get => (uint)((_bitfield0 >> 5) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 5)) | ((((uint)value) & 0x1u) << 5);
            }
            public uint show_frame
            {
                get => (uint)((_bitfield0 >> 6) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 6)) | ((((uint)value) & 0x1u) << 6);
            }
            public uint UsePrevFrameMvs
            {
                get => (uint)((_bitfield0 >> 7) & 0x1u);
                set => _bitfield0 = (_bitfield0 & ~(0x1u << 7)) | ((((uint)value) & 0x1u) << 7);
            }
            public uint reserved
            {
                get => (uint)((_bitfield0 >> 8) & 0xFFFFFFu);
                set => _bitfield0 = (_bitfield0 & ~(0xFFFFFFu << 8)) | ((((uint)value) & 0xFFFFFFu) << 8);
            }
            public StdVideoDecodeVP9PictureInfoFlags() { }
        }
        public unsafe struct StdVideoDecodeVP9PictureInfo
        {
            public StdVideoDecodeVP9PictureInfoFlags flags;
            public StdVideoVP9Profile profile;
            public StdVideoVP9FrameType frame_type;
            public byte frame_context_idx;
            public byte reset_frame_context;
            public byte refresh_frame_flags;
            public byte ref_frame_sign_bias_mask;
            public StdVideoVP9InterpolationFilter interpolation_filter;
            public byte base_q_idx;
            public sbyte delta_q_y_dc;
            public sbyte delta_q_uv_dc;
            public sbyte delta_q_uv_ac;
            public byte tile_cols_log2;
            public byte tile_rows_log2;
            public fixed ushort reserved1[3];
            public StdVideoVP9ColorConfig* pColorConfig;
            public StdVideoVP9LoopFilter* pLoopFilter;
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
