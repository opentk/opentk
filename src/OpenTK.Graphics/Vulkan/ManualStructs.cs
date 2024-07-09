using OpenTK.Graphics.Vulkan.VideoCodecH264.Encode;
using OpenTK.Graphics.Vulkan.VideoCodecH265.Decode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Graphics.Vulkan.VideoCodecH265.Encode.StdVideoEncodeH265WeightTable;

namespace OpenTK.Graphics.Vulkan
{
    public unsafe struct SECURITY_ATTRIBUTES
    {
        public uint nLength;
        public void* lpSecurityDescriptor;
        public int bInheritHandle;
    }

    // FIXME: Auto generate video stuff from
    // video.xml!!

    // FIXME: Mangle names!
    namespace VideoCodecH264
    {
        public static class Constants
        {
            public const int STD_VIDEO_H264_CPB_CNT_LIST_SIZE = 32;
            public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS = 6;
            public const int STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS = 16;
            public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_LISTS = 6;
            public const int STD_VIDEO_H264_SCALING_LIST_8X8_NUM_ELEMENTS = 64;
            public const int STD_VIDEO_H264_MAX_NUM_LIST_REF   = 32;
            public const int STD_VIDEO_H264_MAX_CHROMA_PLANES  = 2;
            public const int STD_VIDEO_H264_NO_REFERENCE_PICTURE = 0xFF;
        }

        public enum StdVideoH264ProfileIdc
        {
            STD_VIDEO_H264_PROFILE_IDC_BASELINE = 66,
            STD_VIDEO_H264_PROFILE_IDC_MAIN = 77,
            STD_VIDEO_H264_PROFILE_IDC_HIGH = 100,
            STD_VIDEO_H264_PROFILE_IDC_HIGH_444_PREDICTIVE = 244,
            STD_VIDEO_H264_PROFILE_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_PROFILE_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH264LevelIdc
        {
            STD_VIDEO_H264_LEVEL_IDC_1_0 = 0,
            STD_VIDEO_H264_LEVEL_IDC_1_1 = 1,
            STD_VIDEO_H264_LEVEL_IDC_1_2 = 2,
            STD_VIDEO_H264_LEVEL_IDC_1_3 = 3,
            STD_VIDEO_H264_LEVEL_IDC_2_0 = 4,
            STD_VIDEO_H264_LEVEL_IDC_2_1 = 5,
            STD_VIDEO_H264_LEVEL_IDC_2_2 = 6,
            STD_VIDEO_H264_LEVEL_IDC_3_0 = 7,
            STD_VIDEO_H264_LEVEL_IDC_3_1 = 8,
            STD_VIDEO_H264_LEVEL_IDC_3_2 = 9,
            STD_VIDEO_H264_LEVEL_IDC_4_0 = 10,
            STD_VIDEO_H264_LEVEL_IDC_4_1 = 11,
            STD_VIDEO_H264_LEVEL_IDC_4_2 = 12,
            STD_VIDEO_H264_LEVEL_IDC_5_0 = 13,
            STD_VIDEO_H264_LEVEL_IDC_5_1 = 14,
            STD_VIDEO_H264_LEVEL_IDC_5_2 = 15,
            STD_VIDEO_H264_LEVEL_IDC_6_0 = 16,
            STD_VIDEO_H264_LEVEL_IDC_6_1 = 17,
            STD_VIDEO_H264_LEVEL_IDC_6_2 = 18,
            STD_VIDEO_H264_LEVEL_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_LEVEL_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH264ChromaFormatIdc
        {
            STD_VIDEO_H264_CHROMA_FORMAT_IDC_MONOCHROME = 0,
            STD_VIDEO_H264_CHROMA_FORMAT_IDC_420 = 1,
            STD_VIDEO_H264_CHROMA_FORMAT_IDC_422 = 2,
            STD_VIDEO_H264_CHROMA_FORMAT_IDC_444 = 3,
            STD_VIDEO_H264_CHROMA_FORMAT_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_CHROMA_FORMAT_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH264PocType
        {
            STD_VIDEO_H264_POC_TYPE_0 = 0,
            STD_VIDEO_H264_POC_TYPE_1 = 1,
            STD_VIDEO_H264_POC_TYPE_2 = 2,
            STD_VIDEO_H264_POC_TYPE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_POC_TYPE_MAX_ENUM = 0x7FFFFFFF
        }

        // FIXME!! This is defined using bitfields in C
        // This makes it hard to recreate in C# as we don't know
        // the layout of the bitfield as it changes between compilers....
        [Flags]
        public enum StdVideoH264SpsFlags : uint
        {
            constraint_set0_flag = 1 << 0,
            constraint_set1_flag = 1 << 1,
            constraint_set2_flag = 1 << 2,
            constraint_set3_flag = 1 << 3,
            constraint_set4_flag = 1 << 4,
            constraint_set5_flag = 1 << 5,
            direct_8x8_inference_flag = 1 << 6,
            mb_adaptive_frame_field_flag = 1 << 7,
            frame_mbs_only_flag = 1 << 8,
            delta_pic_order_always_zero_flag = 1 << 9,
            separate_colour_plane_flag = 1 << 10,
            gaps_in_frame_num_value_allowed_flag = 1 << 11,
            qpprime_y_zero_transform_bypass_flag = 1 << 12,
            frame_cropping_flag = 1 << 13,
            seq_scaling_matrix_present_flag = 1 << 14,
            vui_parameters_present_flag = 1 << 15,
        }

        public struct StdVideoH264ScalingLists
        {
            public ushort scaling_list_present_mask;
            public ushort use_default_scaling_matrix_mask;
            [InlineArray(Constants.STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS)]
            public struct ScalingList4x4InlineArray2
            {
                [InlineArray(Constants.STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS)]
                public struct ScalingList4x4InlineArray1
                {
                    public byte element;
                }
                public ScalingList4x4InlineArray1 element;
            }
            public ScalingList4x4InlineArray2 ScalingList4x4;
            [InlineArray(Constants.STD_VIDEO_H264_SCALING_LIST_4X4_NUM_LISTS)]
            public struct ScalingList8x8InlineArray2
            {
                [InlineArray(Constants.STD_VIDEO_H264_SCALING_LIST_4X4_NUM_ELEMENTS)]
                public struct ScalingList8x8InlineArray1
                {
                    public byte element;
                }
                public ScalingList8x8InlineArray1 element;
            }
            public ScalingList8x8InlineArray2 ScalingList8x8;
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
        }

        public enum StdVideoH264AspectRatioIdc
        {
            STD_VIDEO_H264_ASPECT_RATIO_IDC_UNSPECIFIED = 0,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_SQUARE = 1,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_12_11 = 2,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_10_11 = 3,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_16_11 = 4,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_40_33 = 5,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_24_11 = 6,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_20_11 = 7,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_32_11 = 8,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_80_33 = 9,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_18_11 = 10,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_15_11 = 11,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_64_33 = 12,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_160_99 = 13,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_4_3 = 14,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_3_2 = 15,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_2_1 = 16,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_EXTENDED_SAR = 255,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_ASPECT_RATIO_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        public unsafe struct StdVideoH264HrdParameters
        {
            public byte cpb_cnt_minus1;
            public byte bit_rate_scale;
            public byte cpb_size_scale;
            public byte reserved1;
            public fixed uint bit_rate_value_minus1[Constants.STD_VIDEO_H264_CPB_CNT_LIST_SIZE];
            public fixed uint cpb_size_value_minus1[Constants.STD_VIDEO_H264_CPB_CNT_LIST_SIZE];
            public fixed byte cbr_flag[Constants.STD_VIDEO_H264_CPB_CNT_LIST_SIZE];
            public uint initial_cpb_removal_delay_length_minus1;
            public uint cpb_removal_delay_length_minus1;
            public uint dpb_output_delay_length_minus1;
            public uint time_offset_length;
        }

        // FIXME!! This is defined using bitfields in C
        // This makes it hard to recreate in C# as we don't know
        // the layout of the bitfield as it changes between compilers....
        [Flags]
        public enum StdVideoH264SpsVuiFlags : uint
        {
            aspect_ratio_info_present_flag = 1 << 0,
            overscan_info_present_flag = 1 << 1,
            overscan_appropriate_flag = 1 << 2,
            video_signal_type_present_flag = 1 << 3,
            video_full_range_flag = 1 << 4,
            color_description_present_flag = 1 << 5,
            chroma_loc_info_present_flag = 1 << 6,
            timing_info_present_flag = 1 << 7,
            fixed_frame_rate_flag = 1 << 8,
            bitstream_restriction_flag = 1 << 9,
            nal_hrd_parameters_present_flag = 1 << 10,
            vcl_hrd_parameters_present_flag = 1 << 11,
        }

        public enum StdVideoH264WeightedBipredIdc
        {
            STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_DEFAULT = 0,
            STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT = 1,
            STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_IMPLICIT = 2,
            STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        // FIXME!! This is defined using bitfields in C
        // This makes it hard to recreate in C# as we don't know
        // the layout of the bitfield as it changes between compilers....
        [Flags]
        public enum StdVideoH264PpsFlags : uint
        {
            transform_8x8_mode_flag = 1 << 0,
            redundant_pic_cnt_present_flag = 1 << 1,
            constrained_intra_pred_flag = 1 << 2,
            deblocking_filter_control_present_flag = 1 << 3,
            weighted_pred_flag = 1 << 4,
            bottom_field_pic_order_in_frame_present_flag = 1 << 5,
            entropy_coding_mode_flag = 1 << 6,
            pic_scaling_matrix_present_flag = 1 << 7,
        }

        public enum StdVideoH264SliceType
        {
            STD_VIDEO_H264_SLICE_TYPE_P = 0,
            STD_VIDEO_H264_SLICE_TYPE_B = 1,
            STD_VIDEO_H264_SLICE_TYPE_I = 2,
            STD_VIDEO_H264_SLICE_TYPE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_SLICE_TYPE_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH264CabacInitIdc
        {
            STD_VIDEO_H264_CABAC_INIT_IDC_0 = 0,
            STD_VIDEO_H264_CABAC_INIT_IDC_1 = 1,
            STD_VIDEO_H264_CABAC_INIT_IDC_2 = 2,
            STD_VIDEO_H264_CABAC_INIT_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_CABAC_INIT_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH264DisableDeblockingFilterIdc
        {
            STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED = 0,
            STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED = 1,
            STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL = 2,
            STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        [Flags]
        public enum StdVideoH264PictureType
        {
            STD_VIDEO_H264_PICTURE_TYPE_P = 0,
            STD_VIDEO_H264_PICTURE_TYPE_B = 1,
            STD_VIDEO_H264_PICTURE_TYPE_I = 2,
            STD_VIDEO_H264_PICTURE_TYPE_IDR = 5,
            STD_VIDEO_H264_PICTURE_TYPE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_PICTURE_TYPE_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH264ModificationOfPicNumsIdc
        {
            STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_SUBTRACT = 0,
            STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_ADD = 1,
            STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_LONG_TERM = 2,
            STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_END = 3,
            STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH264MemMgmtControlOp
        {
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END = 0,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM = 1,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM = 2,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM = 3,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX = 4,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL = 5,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM = 6,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MAX_ENUM = 0x7FFFFFFF
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
        }

        public unsafe struct StdVideoH264PictureParameterSet
        {
            public StdVideoH264PpsFlags flags;
            public byte seq_parameter_set_id;
            public byte pic_parameter_set_id;
            public byte num_ref_idx_l0_default_active_minus1;
            public byte num_ref_idx_l1_default_active_minus1;
            public StdVideoH264WeightedBipredIdc weighted_bipred_idc;
            public byte pic_init_qp_minus26;
            public byte pic_init_qs_minus26;
            public byte chroma_qp_index_offset;
            public byte second_chroma_qp_index_offset;
            public StdVideoH264ScalingLists* pScalingLists;
        }
    }

    namespace VideoCodecH264.Decode
    {
        public static class Constants
        {
            public const int STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE = 2;
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
            public fixed int PicOrderCnt[Constants.STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE];
        }

        public unsafe struct StdVideoDecodeH264ReferenceInfo
        {
            public StdVideoDecodeH264ReferenceInfoFlags flags;
            public ushort FrameNum;
            public ushort reserved;
            public fixed int PicOrderCnt[Constants.STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_LIST_SIZE];
        }

        // FIXME!! This is defined using bitfields in C
        // This makes it hard to recreate in C# as we don't know
        // the layout of the bitfield as it changes between compilers....
        public enum StdVideoDecodeH264PictureInfoFlags : uint
        {
            field_pic_flag = 1 << 0,
            is_intra = 1 << 1,
            IdrPicFlag = 1 << 2,
            bottom_field_flag = 1 << 3,
            is_reference = 1 << 4,
            complementary_field_pair = 1 << 5,
        }

        // FIXME!! This is defined using bitfields in C
        // This makes it hard to recreate in C# as we don't know
        // the layout of the bitfield as it changes between compilers....
        public enum StdVideoDecodeH264ReferenceInfoFlags : uint
        {
            top_field_flag = 1 << 0,
            bottom_field_flag = 1 << 1,
            used_for_long_term_reference = 1 << 2,
            is_non_existing = 1 << 3,
        }
    }

    namespace VideoCodecH264.Encode
    {
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
        }

        public struct StdVideoEncodeH264WeightTableFlags
        {
            public uint luma_weight_l0_flag;
            public uint chroma_weight_l0_flag;
            public uint luma_weight_l1_flag;
            public uint chroma_weight_l1_flag;
        }

        public unsafe struct StdVideoEncodeH264WeightTable
        {
            public StdVideoEncodeH264WeightTableFlags flags;
            public byte luma_log2_weight_denom;
            public byte chroma_log2_weight_denom;
            public fixed byte luma_weight_l0[Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF];
            public fixed byte luma_offset_l0[Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF];
            [InlineArray(Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF)]
            public struct chroma_weight_l0InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H264_MAX_CHROMA_PLANES)]
                public struct chroma_weight_l0InlineArray2
                {
                    public byte element;
                }

                public chroma_weight_l0InlineArray2 element;
            }
            public chroma_weight_l0InlineArray1 chroma_weight_l0;
            [InlineArray(Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF)]
            public struct chroma_offset_l0InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H264_MAX_CHROMA_PLANES)]
                public struct chroma_offset_l0InlineArray2
                {
                    public byte element;
                }

                public chroma_offset_l0InlineArray2 element;
            }
            public chroma_offset_l0InlineArray1 chroma_offset_l0;
            public fixed byte luma_weight_l1[Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF];
            public fixed byte luma_offset_l1[Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF];
            [InlineArray(Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF)]
            public struct chroma_weight_l1InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H264_MAX_CHROMA_PLANES)]
                public struct chroma_weight_l1InlineArray2
                {
                    public byte element;
                }

                public chroma_weight_l1InlineArray2 element;
            }
            public chroma_weight_l1InlineArray1 chroma_weight_l1;
            [InlineArray(Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF)]
            public struct chroma_offset_l1InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H264_MAX_CHROMA_PLANES)]
                public struct chroma_offset_l1InlineArray2
                {
                    public byte element;
                }

                public chroma_offset_l1InlineArray2 element;
            }
            public chroma_offset_l1InlineArray1 chroma_offset_l1;
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
        }

        public struct StdVideoEncodeH264ReferenceInfo
        {
            public StdVideoEncodeH264ReferenceInfoFlags flags;
            public StdVideoH264PictureType primary_pic_type;
            public uint FrameNum;
            public int PicOrderCnt;
            public ushort long_term_pic_num;
            public ushort long_term_frame_idx;
            public byte temporal_id;
        }

        // FIXME!! This is defined using bitfields in C
        // This makes it hard to recreate in C# as we don't know
        // the layout of the bitfield as it changes between compilers....
        [Flags]
        public enum StdVideoEncodeH264SliceHeaderFlags : uint
        {
            direct_spatial_mv_pred_flag = 1 << 0,
            num_ref_idx_active_override_flag = 1 << 1,
            // reserved : 30;
        }

        public unsafe struct StdVideoEncodeH264ReferenceListsInfo
        {
            public StdVideoEncodeH264ReferenceListsInfoFlags flags;
            public byte num_ref_idx_l0_active_minus1;
            public byte num_ref_idx_l1_active_minus1;
            public fixed byte RefPicList0[Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF];
            public fixed byte RefPicList1[Constants.STD_VIDEO_H264_MAX_NUM_LIST_REF];
            public byte refList0ModOpCount;
            public byte refList1ModOpCount;
            public byte refPicMarkingOpCount;
            public fixed byte reserved1[7];
            public StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;
            public StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;
            public StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;
        }

        [Flags]
        public enum StdVideoEncodeH264ReferenceListsInfoFlags : uint
        {
            ref_pic_list_modification_flag_l0 = 1 << 0,
            ref_pic_list_modification_flag_l1 = 1 << 0,
            // reserved : 30;
        }

        [Flags]
        public enum StdVideoEncodeH264PictureInfoFlags : uint
        {
            IdrPicFlag = 1 << 0,
            is_reference = 1 << 1,
            no_output_of_prior_pics_flag = 1 << 2,
            long_term_reference_flag = 1 << 3,
            adaptive_ref_pic_marking_mode_flag = 1 << 4,
            // reserved : 27;
        }

        // FIXME!! This is defined using bitfields in C
        // This makes it hard to recreate in C# as we don't know
        // the layout of the bitfield as it changes between compilers....
        [Flags]
        public enum StdVideoEncodeH264ReferenceInfoFlags : uint
        {
            used_for_long_term_reference = 1 << 0,
            // reserved : 31;
        }

        public struct StdVideoEncodeH264RefListModEntry
        {
            public StdVideoH264ModificationOfPicNumsIdc modification_of_pic_nums_idc;
            public ushort abs_diff_pic_num_minus1;
            public ushort long_term_pic_num;
        }

        public struct StdVideoEncodeH264RefPicMarkingEntry
        {
            public StdVideoH264MemMgmtControlOp memory_management_control_operation;
            public ushort difference_of_pic_nums_minus1;
            public ushort long_term_pic_num;
            public ushort long_term_frame_idx;
            public ushort max_long_term_frame_idx_plus1;
        }
    }

    namespace VideoCodecH265
    {
        public static class Constants
        {
            public const int STD_VIDEO_H265_CPB_CNT_LIST_SIZE = 32;
            public const int STD_VIDEO_H265_SUBLAYERS_LIST_SIZE = 7;
            public const int STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS = 6;
            public const int STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS = 16;
            public const int STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS = 6;
            public const int STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS = 64;
            public const int STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS = 6;
            public const int STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS = 64;
            public const int STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS = 2;
            public const int STD_VIDEO_H265_SCALING_LIST_32X32_NUM_ELEMENTS = 64;
            public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE = 6;
            public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE = 19;
            public const int STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE = 21;
            public const int STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE = 3;
            public const int STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE = 128;
            public const int STD_VIDEO_H265_MAX_NUM_LIST_REF   = 15;
            public const int STD_VIDEO_H265_MAX_CHROMA_PLANES  = 2;
            public const int STD_VIDEO_H265_MAX_SHORT_TERM_REF_PIC_SETS = 64;
            public const int STD_VIDEO_H265_MAX_DPB_SIZE       = 16;
            public const int STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS = 32;
            public const int STD_VIDEO_H265_MAX_LONG_TERM_PICS = 16;
            public const int STD_VIDEO_H265_MAX_DELTA_POC      = 48;
            public const int STD_VIDEO_H265_NO_REFERENCE_PICTURE = 0xFF;
        }

        public enum StdVideoH265ProfileIdc
        {
            STD_VIDEO_H265_PROFILE_IDC_MAIN = 1,
            STD_VIDEO_H265_PROFILE_IDC_MAIN_10 = 2,
            STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE = 3,
            STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS = 4,
            STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS = 9,
            STD_VIDEO_H265_PROFILE_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H265_PROFILE_IDC_MAX_ENUM = 0x7FFFFFFF
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
        }

        [Flags]
        public enum StdVideoH265ProfileTierLevelFlags : uint
        {
            general_tier_flag = 1 << 0,
            general_progressive_source_flag = 1 << 1,
            general_interlaced_source_flag = 1 << 2,
            general_non_packed_constraint_flag = 1 << 3,
            general_frame_only_constraint_flag = 1 << 4,
        }

        public struct StdVideoH265ProfileTierLevel
        {
            public StdVideoH265ProfileTierLevelFlags flags;
            public StdVideoH265ProfileIdc general_profile_idc;
            public StdVideoH265LevelIdc general_level_idc;
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
        }

        [Flags]
        public enum StdVideoH265ShortTermRefPicSetFlags : uint
        {
            inter_ref_pic_set_prediction_flag = 1 << 0,
            delta_rps_sign = 1 << 1,
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
            public fixed ushort delta_poc_s0_minus1[Constants.STD_VIDEO_H265_MAX_DPB_SIZE];
            public fixed ushort delta_poc_s1_minus1[Constants.STD_VIDEO_H265_MAX_DPB_SIZE];
        }

        public unsafe struct StdVideoH265LongTermRefPicsSps
        {
            public uint used_by_curr_pic_lt_sps_flag;
            public fixed uint lt_ref_pic_poc_lsb_sps[Constants.STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS];
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
            public fixed sbyte cb_qp_offset_list[Constants.STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE];
            public fixed sbyte cr_qp_offset_list[Constants.STD_VIDEO_H265_CHROMA_QP_OFFSET_LIST_SIZE];
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
            public fixed ushort column_width_minus1[Constants.STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_COLS_LIST_SIZE];
            public fixed ushort row_height_minus1[Constants.STD_VIDEO_H265_CHROMA_QP_OFFSET_TILE_ROWS_LIST_SIZE];
            public uint reserved3;
            public StdVideoH265ScalingLists* pScalingLists;
            public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
        }

        public unsafe struct StdVideoH265DecPicBufMgr
        {
            public fixed uint max_latency_increase_plus1[Constants.STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];
            public fixed byte max_dec_pic_buffering_minus1[Constants.STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];
            public fixed byte max_num_reorder_pics[Constants.STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];
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
            public fixed byte cpb_cnt_minus1[Constants.STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];
            public fixed ushort elemental_duration_in_tc_minus1[Constants.STD_VIDEO_H265_SUBLAYERS_LIST_SIZE];
            public fixed ushort reserved[3];
            public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersNal;
            public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersVcl;
        }

        [Flags]
        public enum StdVideoH265VpsFlags : uint
        {
            vps_temporal_id_nesting_flag = 1 << 0,
            vps_sub_layer_ordering_info_present_flag = 1 << 1,
            vps_timing_info_present_flag = 1 << 2,
            vps_poc_proportional_to_timing_flag = 1 << 3,
        }

        public enum StdVideoH265LevelIdc
        {
            STD_VIDEO_H265_LEVEL_IDC_1_0 = 0,
            STD_VIDEO_H265_LEVEL_IDC_2_0 = 1,
            STD_VIDEO_H265_LEVEL_IDC_2_1 = 2,
            STD_VIDEO_H265_LEVEL_IDC_3_0 = 3,
            STD_VIDEO_H265_LEVEL_IDC_3_1 = 4,
            STD_VIDEO_H265_LEVEL_IDC_4_0 = 5,
            STD_VIDEO_H265_LEVEL_IDC_4_1 = 6,
            STD_VIDEO_H265_LEVEL_IDC_5_0 = 7,
            STD_VIDEO_H265_LEVEL_IDC_5_1 = 8,
            STD_VIDEO_H265_LEVEL_IDC_5_2 = 9,
            STD_VIDEO_H265_LEVEL_IDC_6_0 = 10,
            STD_VIDEO_H265_LEVEL_IDC_6_1 = 11,
            STD_VIDEO_H265_LEVEL_IDC_6_2 = 12,
            STD_VIDEO_H265_LEVEL_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H265_LEVEL_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        [Flags]
        public enum StdVideoH265SpsFlags : uint
        {
            sps_temporal_id_nesting_flag  = 1 << 0,
            separate_colour_plane_flag  = 1 << 1,
            conformance_window_flag  = 1 << 2,
            sps_sub_layer_ordering_info_present_flag  = 1 << 3,
            scaling_list_enabled_flag  = 1 << 4,
            sps_scaling_list_data_present_flag  = 1 << 5,
            amp_enabled_flag  = 1 << 6,
            sample_adaptive_offset_enabled_flag  = 1 << 7,
            pcm_enabled_flag  = 1 << 8,
            pcm_loop_filter_disabled_flag  = 1 << 9,
            long_term_ref_pics_present_flag  = 1 << 10,
            sps_temporal_mvp_enabled_flag  = 1 << 11,
            strong_intra_smoothing_enabled_flag  = 1 << 12,
            vui_parameters_present_flag  = 1 << 13,
            sps_extension_present_flag  = 1 << 14,
            sps_range_extension_flag  = 1 << 15,
            transform_skip_rotation_enabled_flag  = 1 << 16,
            transform_skip_context_enabled_flag  = 1 << 17,
            implicit_rdpcm_enabled_flag  = 1 << 18,
            explicit_rdpcm_enabled_flag  = 1 << 19,
            extended_precision_processing_flag  = 1 << 20,
            intra_smoothing_disabled_flag  = 1 << 21,
            high_precision_offsets_enabled_flag  = 1 << 22,
            persistent_rice_adaptation_enabled_flag  = 1 << 23,
            cabac_bypass_alignment_enabled_flag  = 1 << 24,
            sps_scc_extension_flag  = 1 << 25,
            sps_curr_pic_ref_enabled_flag  = 1 << 26,
            palette_mode_enabled_flag  = 1 << 27,
            sps_palette_predictor_initializers_present_flag  = 1 << 28,
            intra_boundary_filtering_disabled_flag  = 1 << 29,
        }

        public unsafe struct StdVideoH265ScalingLists
        {
            [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_4X4_NUM_LISTS)]
            public struct ScalingList4x4InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_4X4_NUM_ELEMENTS)]
                public struct ScalingList4x4InlineArray2
                {
                    public byte element;
                }
                public ScalingList4x4InlineArray2 element;
            }
            ScalingList4x4InlineArray1 ScalingList4x4;
            [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_8X8_NUM_LISTS)]
            public struct ScalingList8x8InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_8X8_NUM_ELEMENTS)]
                public struct ScalingList8x8InlineArray2
                {
                    public byte element;
                }
                public ScalingList8x8InlineArray2 element;
            }
            ScalingList8x8InlineArray1 ScalingList8x8;
            [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS)]
            public struct ScalingList16x16InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS)]
                public struct ScalingList16x16InlineArray2
                {
                    public byte element;
                }
                public ScalingList16x16InlineArray2 element;
            }
            ScalingList16x16InlineArray1 ScalingList16x16;
            [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS)]
            public struct ScalingList32x32InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_SCALING_LIST_16X16_NUM_ELEMENTS)]
                public struct ScalingList32x32InlineArray2
                {
                    public byte element;
                }
                public ScalingList32x32InlineArray2 element;
            }
            ScalingList32x32InlineArray1 ScalingList32x32;
            public fixed byte ScalingListDCCoef16x16[Constants.STD_VIDEO_H265_SCALING_LIST_16X16_NUM_LISTS];
            public fixed byte ScalingListDCCoef32x32[Constants.STD_VIDEO_H265_SCALING_LIST_32X32_NUM_LISTS];
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
        }

        public struct StdVideoH265PredictorPaletteEntries
        {
            [InlineArray(Constants.STD_VIDEO_H265_PREDICTOR_PALETTE_COMPONENTS_LIST_SIZE)]
            public struct PredictorPaletteEntriesInlineArray2
            {
                [InlineArray(Constants.STD_VIDEO_H265_PREDICTOR_PALETTE_COMP_ENTRIES_LIST_SIZE)]
                public struct PredictorPaletteEntriesInlineArray1
                {
                    public ushort element;
                }
                public PredictorPaletteEntriesInlineArray1 element;
            }
            public PredictorPaletteEntriesInlineArray2 PredictorPaletteEntries;
        }

        [Flags]
        public enum StdVideoH265PpsFlags : uint
        {
            dependent_slice_segments_enabled_flag  = 1 << 0,
            output_flag_present_flag  = 1 << 1,
            sign_data_hiding_enabled_flag  = 1 << 2,
            cabac_init_present_flag  = 1 << 3,
            constrained_intra_pred_flag  = 1 << 4,
            transform_skip_enabled_flag  = 1 << 5,
            cu_qp_delta_enabled_flag  = 1 << 6,
            pps_slice_chroma_qp_offsets_present_flag  = 1 << 7,
            weighted_pred_flag  = 1 << 8,
            weighted_bipred_flag  = 1 << 9,
            transquant_bypass_enabled_flag  = 1 << 10,
            tiles_enabled_flag  = 1 << 11,
            entropy_coding_sync_enabled_flag  = 1 << 12,
            uniform_spacing_flag  = 1 << 13,
            loop_filter_across_tiles_enabled_flag  = 1 << 14,
            pps_loop_filter_across_slices_enabled_flag  = 1 << 15,
            deblocking_filter_control_present_flag  = 1 << 16,
            deblocking_filter_override_enabled_flag  = 1 << 17,
            pps_deblocking_filter_disabled_flag  = 1 << 18,
            pps_scaling_list_data_present_flag  = 1 << 19,
            lists_modification_present_flag  = 1 << 20,
            slice_segment_header_extension_present_flag  = 1 << 21,
            pps_extension_present_flag  = 1 << 22,
            cross_component_prediction_enabled_flag  = 1 << 23,
            chroma_qp_offset_list_enabled_flag  = 1 << 24,
            pps_curr_pic_ref_enabled_flag  = 1 << 25,
            residual_adaptive_colour_transform_enabled_flag  = 1 << 26,
            pps_slice_act_qp_offsets_present_flag  = 1 << 27,
            pps_palette_predictor_initializers_present_flag  = 1 << 28,
            monochrome_palette_flag  = 1 << 29,
            pps_range_extension_flag  = 1 << 30,
        }

        public unsafe struct StdVideoH265SubLayerHrdParameters
        {
            public fixed uint bit_rate_value_minus1[Constants.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
            public fixed uint cpb_size_value_minus1[Constants.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
            public fixed uint cpb_size_du_value_minus1[Constants.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
            public fixed uint bit_rate_du_value_minus1[Constants.STD_VIDEO_H265_CPB_CNT_LIST_SIZE];
            public uint cbr_flag;
        }

        [Flags]
        public enum StdVideoH265HrdFlags : uint
        {
            nal_hrd_parameters_present_flag = 1 << 0,
            vcl_hrd_parameters_present_flag = 1 << 1,
            sub_pic_hrd_params_present_flag = 1 << 2,
            sub_pic_cpb_params_in_pic_timing_sei_flag = 1 << 3,
            // FIXME: These are 8 bit bitfields that we'd ideally make as bytes.
            // We can do this when we do the generator for video.xml
            fixed_pic_rate_general_flag = 0xff << 4,
            fixed_pic_rate_within_cvs_flag = 0xff << 12,
            low_delay_hrd_flag = 0xff << 20,
        }

        [Flags]
        public enum StdVideoH265SpsVuiFlags : uint
        {
            aspect_ratio_info_present_flag = 1 << 0,
            overscan_info_present_flag = 1 << 1,
            overscan_appropriate_flag = 1 << 2,
            video_signal_type_present_flag = 1 << 3,
            video_full_range_flag = 1 << 4,
            colour_description_present_flag = 1 << 5,
            chroma_loc_info_present_flag = 1 << 6,
            neutral_chroma_indication_flag = 1 << 7,
            field_seq_flag = 1 << 8,
            frame_field_info_present_flag = 1 << 9,
            default_display_window_flag = 1 << 10,
            vui_timing_info_present_flag = 1 << 11,
            vui_poc_proportional_to_timing_flag = 1 << 12,
            vui_hrd_parameters_present_flag = 1 << 13,
            bitstream_restriction_flag = 1 << 14,
            tiles_fixed_structure_flag = 1 << 15,
            motion_vectors_over_pic_boundaries_flag = 1 << 16,
            restricted_ref_pic_lists_flag = 1 << 17,
        }

        public enum StdVideoH265SliceType
        {
            STD_VIDEO_H265_SLICE_TYPE_B = 0,
            STD_VIDEO_H265_SLICE_TYPE_P = 1,
            STD_VIDEO_H265_SLICE_TYPE_I = 2,
            STD_VIDEO_H265_SLICE_TYPE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H265_SLICE_TYPE_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH265PictureType
        {
            STD_VIDEO_H265_PICTURE_TYPE_P = 0,
            STD_VIDEO_H265_PICTURE_TYPE_B = 1,
            STD_VIDEO_H265_PICTURE_TYPE_I = 2,
            STD_VIDEO_H265_PICTURE_TYPE_IDR = 3,
            STD_VIDEO_H265_PICTURE_TYPE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H265_PICTURE_TYPE_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH265AspectRatioIdc
        {
            STD_VIDEO_H265_ASPECT_RATIO_IDC_UNSPECIFIED = 0,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_SQUARE = 1,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_12_11 = 2,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_10_11 = 3,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_16_11 = 4,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_40_33 = 5,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_24_11 = 6,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_20_11 = 7,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_32_11 = 8,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_80_33 = 9,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_18_11 = 10,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_15_11 = 11,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_64_33 = 12,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_160_99 = 13,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_4_3 = 14,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_3_2 = 15,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_2_1 = 16,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_EXTENDED_SAR = 255,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H265_ASPECT_RATIO_IDC_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoH265ChromaFormatIdc
        {
            STD_VIDEO_H265_CHROMA_FORMAT_IDC_MONOCHROME = 0,
            STD_VIDEO_H265_CHROMA_FORMAT_IDC_420 = 1,
            STD_VIDEO_H265_CHROMA_FORMAT_IDC_422 = 2,
            STD_VIDEO_H265_CHROMA_FORMAT_IDC_444 = 3,
            STD_VIDEO_H265_CHROMA_FORMAT_IDC_INVALID = 0x7FFFFFFF,
            STD_VIDEO_H265_CHROMA_FORMAT_IDC_MAX_ENUM = 0x7FFFFFFF
        }
    }

    namespace VideoCodecH265.Decode
    {
        public static class Constants
        {
            public const int STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE = 8;
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
            public fixed byte RefPicSetStCurrBefore[Constants.STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];
            public fixed byte RefPicSetStCurrAfter[Constants.STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];
            public fixed byte RefPicSetLtCurr[Constants.STD_VIDEO_DECODE_H265_REF_PIC_SET_LIST_SIZE];
        }

        public struct StdVideoDecodeH265ReferenceInfo
        {
            public StdVideoDecodeH265ReferenceInfoFlags flags;
            public int PicOrderCntVal;
        }

        public enum StdVideoDecodeH265PictureInfoFlags : uint
        {
            IrapPicFlag = 1 << 0,
            IdrPicFlag  = 1 << 0,
            IsReference = 1 << 0,
            short_term_ref_pic_set_sps_flag = 1 << 0,
        }

        public enum StdVideoDecodeH265ReferenceInfoFlags : uint
        {
            used_for_long_term_reference  = 1 << 0,
            unused_for_reference  = 1 << 0,
        }
    }

    namespace VideoCodecH265.Encode
    {
        public enum StdVideoEncodeH265PictureInfoFlags : uint
        {
            is_reference = 1 << 0,
            IrapPicFlag = 1 << 1,
            used_for_long_term_reference = 1 << 2,
            discardable_flag = 1 << 3,
            cross_layer_bla_flag = 1 << 4,
            pic_output_flag = 1 << 5,
            no_output_of_prior_pics_flag = 1 << 6,
            short_term_ref_pic_set_sps_flag = 1 << 7,
            slice_temporal_mvp_enabled_flag = 1 << 8,
            // reserved : 23;
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
        }

        public unsafe struct StdVideoEncodeH265LongTermRefPics
        {
            public byte num_long_term_sps;
            public byte num_long_term_pics;
            public fixed byte lt_idx_sps[Constants.STD_VIDEO_H265_MAX_LONG_TERM_REF_PICS_SPS];
            public fixed byte poc_lsb_lt[Constants.STD_VIDEO_H265_MAX_LONG_TERM_PICS];
            public ushort used_by_curr_pic_lt_flag;
            public fixed byte delta_poc_msb_present_flag[Constants.STD_VIDEO_H265_MAX_DELTA_POC];
            public fixed byte delta_poc_msb_cycle_lt[Constants.STD_VIDEO_H265_MAX_DELTA_POC];
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
        }

        public struct StdVideoEncodeH265WeightTableFlags
        {
            public ushort luma_weight_l0_flag;
            public ushort chroma_weight_l0_flag;
            public ushort luma_weight_l1_flag;
            public ushort chroma_weight_l1_flag;
        }

        public unsafe struct StdVideoEncodeH265WeightTable
        {
            public StdVideoEncodeH265WeightTableFlags flags;
            public byte luma_log2_weight_denom;
            public sbyte delta_chroma_log2_weight_denom;
            public fixed sbyte delta_luma_weight_l0[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
            public fixed sbyte luma_offset_l0[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
            [InlineArray(Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF)]
            public struct delta_chroma_weight_l0InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_MAX_CHROMA_PLANES)]
                public struct delta_chroma_weight_l0InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_weight_l0InlineArray2 element;
            }
            public delta_chroma_weight_l0InlineArray1 delta_chroma_weight_l0;
            [InlineArray(Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF)]
            public struct delta_chroma_offset_l0InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_MAX_CHROMA_PLANES)]
                public struct delta_chroma_offset_l0InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_offset_l0InlineArray2 element;
            }
            public delta_chroma_offset_l0InlineArray1 delta_chroma_offset_l0;
            public fixed sbyte delta_luma_weight_l1[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
            public fixed sbyte luma_offset_l1[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
            [InlineArray(Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF)]
            public struct delta_chroma_weight_l1InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_MAX_CHROMA_PLANES)]
                public struct delta_chroma_weight_l1InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_weight_l1InlineArray2 element;
            }
            public delta_chroma_weight_l1InlineArray1 delta_chroma_weight_l1;
            [InlineArray(Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF)]
            public struct delta_chroma_offset_l1InlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_H265_MAX_CHROMA_PLANES)]
                public struct delta_chroma_offset_l1InlineArray2
                {
                    public sbyte element;
                }
                public delta_chroma_offset_l1InlineArray2 element;
            }
            public delta_chroma_offset_l1InlineArray1 delta_chroma_offset_l1;
        }

        public struct StdVideoEncodeH265ReferenceInfo
        {
            public StdVideoEncodeH265ReferenceInfoFlags flags;
            public StdVideoH265PictureType pic_type;
            public int PicOrderCntVal;
            public byte TemporalId;
        }

        [Flags]
        public enum StdVideoEncodeH265ReferenceListsInfoFlags
        {
            ref_pic_list_modification_flag_l0 = 1 << 0,
            ref_pic_list_modification_flag_l1 = 1 << 1,
            // reserved : 30;
        }

        public unsafe struct StdVideoEncodeH265ReferenceListsInfo
        {
            public StdVideoEncodeH265ReferenceListsInfoFlags flags;
            public byte num_ref_idx_l0_active_minus1;
            public byte num_ref_idx_l1_active_minus1;
            public fixed byte RefPicList0[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
            public fixed byte RefPicList1[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
            public fixed byte list_entry_l0[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
            public fixed byte list_entry_l1[Constants.STD_VIDEO_H265_MAX_NUM_LIST_REF];
        }

        public enum StdVideoEncodeH265SliceSegmentHeaderFlags : uint
        {
            first_slice_segment_in_pic_flag  = 1 << 0,
            dependent_slice_segment_flag  = 1 << 1,
            slice_sao_luma_flag  = 1 << 2,
            slice_sao_chroma_flag  = 1 << 3,
            num_ref_idx_active_override_flag  = 1 << 4,
            mvd_l1_zero_flag  = 1 << 5,
            cabac_init_flag  = 1 << 6,
            cu_chroma_qp_offset_enabled_flag  = 1 << 7,
            deblocking_filter_override_flag  = 1 << 8,
            slice_deblocking_filter_disabled_flag  = 1 << 9,
            collocated_from_l0_flag  = 1 << 10,
            slice_loop_filter_across_slices_enabled_flag  = 1 << 11,
            // reserved : 20;
        }

        public enum StdVideoEncodeH265ReferenceInfoFlags : uint
        {
            used_for_long_term_reference = 1 << 0,
            unused_for_reference = 1 << 1,
            // reserved : 30;
        }
    }

    namespace VideoCodecAV1
    {
        public static class Constants
        {
            public const int STD_VIDEO_AV1_NUM_REF_FRAMES       = 8;
            public const int STD_VIDEO_AV1_REFS_PER_FRAME       = 7;
            public const int STD_VIDEO_AV1_TOTAL_REFS_PER_FRAME = 8;
            public const int STD_VIDEO_AV1_MAX_TILE_COLS        = 64;
            public const int STD_VIDEO_AV1_MAX_TILE_ROWS        = 64;
            public const int STD_VIDEO_AV1_MAX_SEGMENTS         = 8;
            public const int STD_VIDEO_AV1_SEG_LVL_MAX          = 8;
            public const int STD_VIDEO_AV1_PRIMARY_REF_NONE     = 7;
            public const int STD_VIDEO_AV1_SELECT_INTEGER_MV    = 2;
            public const int STD_VIDEO_AV1_SELECT_SCREEN_CONTENT_TOOLS  = 2;
            public const int STD_VIDEO_AV1_SKIP_MODE_FRAMES     = 2;
            public const int STD_VIDEO_AV1_MAX_LOOP_FILTER_STRENGTHS  = 4;
            public const int STD_VIDEO_AV1_LOOP_FILTER_ADJUSTMENTS  = 2;
            public const int STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS  = 8;
            public const int STD_VIDEO_AV1_MAX_NUM_PLANES       = 3;
            public const int STD_VIDEO_AV1_GLOBAL_MOTION_PARAMS = 6;
            public const int STD_VIDEO_AV1_MAX_NUM_Y_POINTS     = 14;
            public const int STD_VIDEO_AV1_MAX_NUM_CB_POINTS    = 10;
            public const int STD_VIDEO_AV1_MAX_NUM_CR_POINTS    = 10;
            public const int STD_VIDEO_AV1_MAX_NUM_POS_LUMA     = 24;
            public const int STD_VIDEO_AV1_MAX_NUM_POS_CHROMA   = 25;
        }

        public enum StdVideoAV1Profile
        {
            STD_VIDEO_AV1_PROFILE_MAIN = 0,
            STD_VIDEO_AV1_PROFILE_HIGH = 1,
            STD_VIDEO_AV1_PROFILE_PROFESSIONAL = 2,
            STD_VIDEO_AV1_PROFILE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_PROFILE_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoAV1Level
        {
            STD_VIDEO_AV1_LEVEL_2_0 = 0,
            STD_VIDEO_AV1_LEVEL_2_1 = 1,
            STD_VIDEO_AV1_LEVEL_2_2 = 2,
            STD_VIDEO_AV1_LEVEL_2_3 = 3,
            STD_VIDEO_AV1_LEVEL_3_0 = 4,
            STD_VIDEO_AV1_LEVEL_3_1 = 5,
            STD_VIDEO_AV1_LEVEL_3_2 = 6,
            STD_VIDEO_AV1_LEVEL_3_3 = 7,
            STD_VIDEO_AV1_LEVEL_4_0 = 8,
            STD_VIDEO_AV1_LEVEL_4_1 = 9,
            STD_VIDEO_AV1_LEVEL_4_2 = 10,
            STD_VIDEO_AV1_LEVEL_4_3 = 11,
            STD_VIDEO_AV1_LEVEL_5_0 = 12,
            STD_VIDEO_AV1_LEVEL_5_1 = 13,
            STD_VIDEO_AV1_LEVEL_5_2 = 14,
            STD_VIDEO_AV1_LEVEL_5_3 = 15,
            STD_VIDEO_AV1_LEVEL_6_0 = 16,
            STD_VIDEO_AV1_LEVEL_6_1 = 17,
            STD_VIDEO_AV1_LEVEL_6_2 = 18,
            STD_VIDEO_AV1_LEVEL_6_3 = 19,
            STD_VIDEO_AV1_LEVEL_7_0 = 20,
            STD_VIDEO_AV1_LEVEL_7_1 = 21,
            STD_VIDEO_AV1_LEVEL_7_2 = 22,
            STD_VIDEO_AV1_LEVEL_7_3 = 23,
            STD_VIDEO_AV1_LEVEL_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_LEVEL_MAX_ENUM = 0x7FFFFFFF
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
        }

        public enum StdVideoAV1TimingInfoFlags : uint
        {
            equal_picture_interval = 1 << 0,
            //reserved : 31;
        }

        public struct StdVideoAV1TimingInfo
        {
            public StdVideoAV1TimingInfoFlags flags;
            public uint num_units_in_display_tick;
            public uint time_scale;
            public uint num_ticks_per_picture_minus_1;
        }

        [Flags]
        public enum StdVideoAV1SequenceHeaderFlags : uint
        {
            still_picture = 1 << 0,
            reduced_still_picture_header = 1 << 1,
            use_128x128_superblock = 1 << 2,
            enable_filter_intra = 1 << 3,
            enable_intra_edge_filter = 1 << 4,
            enable_interintra_compound = 1 << 5,
            enable_masked_compound = 1 << 6,
            enable_warped_motion = 1 << 7,
            enable_dual_filter = 1 << 8,
            enable_order_hint = 1 << 9,
            enable_jnt_comp = 1 << 10,
            enable_ref_frame_mvs = 1 << 11,
            frame_id_numbers_present_flag = 1 << 12,
            enable_superres = 1 << 13,
            enable_cdef = 1 << 14,
            enable_restoration = 1 << 15,
            film_grain_params_present = 1 << 16,
            timing_info_present_flag = 1 << 17,
            initial_display_delay_present_flag = 1 << 18,
            // reserved : 13;
        }

        [Flags]
        public enum StdVideoAV1ColorConfigFlags : uint
        {
            mono_chrome = 1 << 0,
            color_range = 1 << 1,
            separate_uv_delta_q = 1 << 2,
            color_description_present_flag = 1 << 3,
            // reserved : 28;
        }

        public struct StdVideoAV1ColorConfig
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
        }

        public enum StdVideoAV1ColorPrimaries
        {
            STD_VIDEO_AV1_COLOR_PRIMARIES_BT_709 = 1,
            STD_VIDEO_AV1_COLOR_PRIMARIES_BT_UNSPECIFIED = 2,
            STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_M = 4,
            STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_B_G = 5,
            STD_VIDEO_AV1_COLOR_PRIMARIES_BT_601 = 6,
            STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_240 = 7,
            STD_VIDEO_AV1_COLOR_PRIMARIES_GENERIC_FILM = 8,
            STD_VIDEO_AV1_COLOR_PRIMARIES_BT_2020 = 9,
            STD_VIDEO_AV1_COLOR_PRIMARIES_XYZ = 10,
            STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_431 = 11,
            STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_432 = 12,
            STD_VIDEO_AV1_COLOR_PRIMARIES_EBU_3213 = 22,
            STD_VIDEO_AV1_COLOR_PRIMARIES_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_COLOR_PRIMARIES_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoAV1TransferCharacteristics
        {
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_0 = 0,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_709 = 1,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_UNSPECIFIED = 2,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_3 = 3,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_M = 4,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_B_G = 5,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_601 = 6,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_240 = 7,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LINEAR = 8,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100 = 9,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100_SQRT10 = 10,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_IEC_61966 = 11,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_1361 = 12,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SRGB = 13,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_10_BIT = 14,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_12_BIT = 15,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_2084 = 16,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_428 = 17,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_HLG = 18,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoAV1MatrixCoefficients
        {
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_IDENTITY = 0,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_709 = 1,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_UNSPECIFIED = 2,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_RESERVED_3 = 3,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_FCC = 4,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_470_B_G = 5,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_601 = 6,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_240 = 7,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_YCGCO = 8,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_NCL = 9,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_CL = 10,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_2085 = 11,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_NCL = 12,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_CL = 13,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_ICTCP = 14,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_MATRIX_COEFFICIENTS_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoAV1ChromaSamplePosition
        {
            STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_UNKNOWN = 0,
            STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_VERTICAL = 1,
            STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_COLOCATED = 2,
            STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_RESERVED = 3,
            STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoAV1FrameType
        {
            STD_VIDEO_AV1_FRAME_TYPE_KEY = 0,
            STD_VIDEO_AV1_FRAME_TYPE_INTER = 1,
            STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY = 2,
            STD_VIDEO_AV1_FRAME_TYPE_SWITCH = 3,
            STD_VIDEO_AV1_FRAME_TYPE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_FRAME_TYPE_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoAV1InterpolationFilter
        {
            STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP = 0,
            STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH = 1,
            STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SHARP = 2,
            STD_VIDEO_AV1_INTERPOLATION_FILTER_BILINEAR = 3,
            STD_VIDEO_AV1_INTERPOLATION_FILTER_SWITCHABLE = 4,
            STD_VIDEO_AV1_INTERPOLATION_FILTER_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_INTERPOLATION_FILTER_MAX_ENUM = 0x7FFFFFFF
        }

        public enum StdVideoAV1TxMode
        {
            STD_VIDEO_AV1_TX_MODE_ONLY_4X4 = 0,
            STD_VIDEO_AV1_TX_MODE_LARGEST = 1,
            STD_VIDEO_AV1_TX_MODE_SELECT = 2,
            STD_VIDEO_AV1_TX_MODE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_TX_MODE_MAX_ENUM = 0x7FFFFFFF
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
        }

        [Flags]
        public enum StdVideoAV1TileInfoFlags : uint
        {
            uniform_tile_spacing_flag = 1 << 0,
            // reserved : 31;
        }

        [Flags]
        public enum StdVideoAV1QuantizationFlags : uint
        {
            using_qmatrix = 1 << 0,
            diff_uv_delta = 1 << 1,
            // reserved : 30;
        }

        public struct StdVideoAV1Quantization
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
        }

        public unsafe struct StdVideoAV1Segmentation
        {
            public fixed byte FeatureEnabled[Constants.STD_VIDEO_AV1_MAX_SEGMENTS];
            [InlineArray(Constants.STD_VIDEO_AV1_MAX_SEGMENTS)]
            public struct FeatureDataInlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_AV1_SEG_LVL_MAX)]
                public struct FeatureDataInlineArray2
                {
                    public short element;
                }
                public FeatureDataInlineArray2 element;
            }
            public FeatureDataInlineArray1 FeatureData;
        }

        public enum StdVideoAV1LoopFilterFlags : uint
        {
            loop_filter_delta_enabled = 1 << 0,
            loop_filter_delta_update = 1 << 1,
            // reserved : 30;
        }

        public unsafe struct StdVideoAV1LoopFilter
        {
            public StdVideoAV1LoopFilterFlags flags;
            public fixed byte loop_filter_level[Constants.STD_VIDEO_AV1_MAX_LOOP_FILTER_STRENGTHS];
            public byte loop_filter_sharpness;
            public byte update_ref_delta;
            public fixed sbyte loop_filter_ref_deltas[Constants.STD_VIDEO_AV1_TOTAL_REFS_PER_FRAME];
            public byte update_mode_delta;
            public fixed sbyte loop_filter_mode_deltas[Constants.STD_VIDEO_AV1_LOOP_FILTER_ADJUSTMENTS];
        }

        public unsafe struct StdVideoAV1CDEF
        {
            public byte cdef_damping_minus_3;
            public byte cdef_bits;
            public fixed byte cdef_y_pri_strength[Constants.STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];
            public fixed byte cdef_y_sec_strength[Constants.STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];
            public fixed byte cdef_uv_pri_strength[Constants.STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];
            public fixed byte cdef_uv_sec_strength[Constants.STD_VIDEO_AV1_MAX_CDEF_FILTER_STRENGTHS];
        }

        public enum StdVideoAV1FrameRestorationType
        {
            STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_NONE = 0,
            STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_WIENER = 1,
            STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SGRPROJ = 2,
            STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SWITCHABLE = 3,
            STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_INVALID = 0x7FFFFFFF,
            STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_MAX_ENUM = 0x7FFFFFFF
        }

        public unsafe struct StdVideoAV1LoopRestoration
        {
            [InlineArray(Constants.STD_VIDEO_AV1_MAX_NUM_PLANES)]
            public struct FrameRestorationTypeInlineArray
            {
                public StdVideoAV1FrameRestorationType element;
            }
            public FrameRestorationTypeInlineArray FrameRestorationType;
            public fixed ushort LoopRestorationSize[Constants.STD_VIDEO_AV1_MAX_NUM_PLANES];
        }

        public unsafe struct StdVideoAV1GlobalMotion
        {
            public fixed byte GmType[Constants.STD_VIDEO_AV1_NUM_REF_FRAMES];
            [InlineArray(Constants.STD_VIDEO_AV1_NUM_REF_FRAMES)]
            public struct gm_paramsInlineArray1
            {
                [InlineArray(Constants.STD_VIDEO_AV1_GLOBAL_MOTION_PARAMS)]
                public struct gm_paramsInlineArray2
                {
                    public int element;
                }
                public gm_paramsInlineArray2 element;
            }
            public gm_paramsInlineArray1 gm_params;
        }

        [Flags]
        public enum StdVideoAV1FilmGrainFlags : uint
        {
            chroma_scaling_from_luma = 1 << 0,
            overlap_flag = 1 << 1,
            clip_to_restricted_range = 1 << 2,
            update_grain = 1 << 3,
            // reserved : 28;
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
            public fixed byte point_y_value[Constants.STD_VIDEO_AV1_MAX_NUM_Y_POINTS];
            public fixed byte point_y_scaling[Constants.STD_VIDEO_AV1_MAX_NUM_Y_POINTS];
            public byte num_cb_points;
            public fixed byte point_cb_value[Constants.STD_VIDEO_AV1_MAX_NUM_CB_POINTS];
            public fixed byte point_cb_scaling[Constants.STD_VIDEO_AV1_MAX_NUM_CB_POINTS];
            public byte num_cr_points;
            public fixed byte point_cr_value[Constants.STD_VIDEO_AV1_MAX_NUM_CR_POINTS];
            public fixed byte point_cr_scaling[Constants.STD_VIDEO_AV1_MAX_NUM_CR_POINTS];
            public fixed sbyte ar_coeffs_y_plus_128[Constants.STD_VIDEO_AV1_MAX_NUM_POS_LUMA];
            public fixed sbyte ar_coeffs_cb_plus_128[Constants.STD_VIDEO_AV1_MAX_NUM_POS_CHROMA];
            public fixed sbyte ar_coeffs_cr_plus_128[Constants.STD_VIDEO_AV1_MAX_NUM_POS_CHROMA];
            public byte cb_mult;
            public byte cb_luma_mult;
            public ushort cb_offset;
            public byte cr_mult;
            public byte cr_luma_mult;
            public ushort cr_offset;
        }
    }

    namespace VideoCodecAV1.Decode
    {
        public enum StdVideoDecodeAV1PictureInfoFlags : uint
        {
            error_resilient_mode = 1 << 0,
            disable_cdf_update = 1 << 1,
            use_superres = 1 << 2,
            render_and_frame_size_different = 1 << 3,
            allow_screen_content_tools = 1 << 4,
            is_filter_switchable = 1 << 5,
            force_integer_mv = 1 << 6,
            frame_size_override_flag = 1 << 7,
            buffer_removal_time_present_flag = 1 << 8,
            allow_intrabc = 1 << 9,
            frame_refs_short_signaling = 1 << 10,
            allow_high_precision_mv = 1 << 11,
            is_motion_mode_switchable = 1 << 12,
            use_ref_frame_mvs = 1 << 13,
            disable_frame_end_update_cdf = 1 << 14,
            allow_warped_motion = 1 << 15,
            reduced_tx_set = 1 << 16,
            reference_select = 1 << 17,
            skip_mode_present = 1 << 18,
            delta_q_present = 1 << 19,
            delta_lf_present = 1 << 20,
            delta_lf_multi = 1 << 21,
            segmentation_enabled = 1 << 22,
            segmentation_update_map = 1 << 23,
            segmentation_temporal_update = 1 << 24,
            segmentation_update_data = 1 << 25,
            UsesLr = 1 << 26,
            usesChromaLr = 1 << 27,
            apply_grain = 1 << 28,
            // reserved : 3;
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
            public fixed byte SkipModeFrame[Constants.STD_VIDEO_AV1_SKIP_MODE_FRAMES];
            public byte coded_denom;
            public fixed byte reserved2[3];
            public fixed byte OrderHints[Constants.STD_VIDEO_AV1_NUM_REF_FRAMES];
            public fixed uint expectedFrameId[Constants.STD_VIDEO_AV1_NUM_REF_FRAMES];
            public StdVideoAV1TileInfo* pTileInfo;
            public StdVideoAV1Quantization* pQuantization;
            public StdVideoAV1Segmentation* pSegmentation;
            public StdVideoAV1LoopFilter* pLoopFilter;
            public StdVideoAV1CDEF* pCDEF;
            public StdVideoAV1LoopRestoration* pLoopRestoration;
            public StdVideoAV1GlobalMotion* pGlobalMotion;
            public StdVideoAV1FilmGrain* pFilmGrain;
        }

        [Flags]
        public enum StdVideoDecodeAV1ReferenceInfoFlags : uint
        {
            disable_frame_end_update_cdf = 1 << 0,
            segmentation_enabled = 1 << 1,
            // reserved : 30;
        }

        public unsafe struct StdVideoDecodeAV1ReferenceInfo
        {
            public StdVideoDecodeAV1ReferenceInfoFlags flags;
            public byte frame_type;
            public byte RefFrameSignBias;
            public byte OrderHint;
            public fixed byte SavedOrderHints[Constants.STD_VIDEO_AV1_NUM_REF_FRAMES];
        }
    }
}
