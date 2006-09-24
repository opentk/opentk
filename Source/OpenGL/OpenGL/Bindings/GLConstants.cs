using System;

namespace OpenTK.OpenGL
{
    public static class Enums
    {
        #region Missing Constants

        const uint GL_FOG_COORDINATE_SOURCE = 0x8450;
        const uint GL_FOG_COORDINATE = 0x8451;
        const uint GL_CURRENT_FOG_COORDINATE = 0x8453;
        const uint GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;
        const uint GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
        const uint GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;
        const uint GL_FOG_COORDINATE_ARRAY = 0x8457;
        const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
        const uint GL_SOURCE0_RGB = 0x8580;
        const uint GL_SOURCE1_RGB = 0x8581;
        const uint GL_SOURCE2_RGB = 0x8582;
        const uint GL_SOURCE0_ALPHA = 0x8588;
        const uint GL_SOURCE1_ALPHA = 0x8589;
        const uint GL_SOURCE2_ALPHA = 0x858A;
        const uint GL_BLEND_EQUATION = 0x8009;
        const uint GL_MODELVIEW_MATRIX = 0x0BA6;
        const uint GL_MODELVIEW = 0x1700;
        const uint GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
        const uint GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1;
        const uint GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2;
        const uint GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3;

        #endregion

        #region OpenGL enums

        public enum PixelStoreParameter : uint
        {
            UNPACK_IMAGE_DEPTH_SGIS = SGIS_texture4D.UNPACK_IMAGE_DEPTH_SGIS,
            UNPACK_LSB_FIRST = GetPName.UNPACK_LSB_FIRST,
            UNPACK_RESAMPLE_SGIX = SGIX_resample.UNPACK_RESAMPLE_SGIX,
            PIXEL_TILE_CACHE_SIZE_SGIX = SGIX_pixel_tiles.PIXEL_TILE_CACHE_SIZE_SGIX,
            UNPACK_ROW_LENGTH = GetPName.UNPACK_ROW_LENGTH,
            UNPACK_ALIGNMENT = GetPName.UNPACK_ALIGNMENT,
            UNPACK_IMAGE_HEIGHT_EXT = EXT_texture3D.UNPACK_IMAGE_HEIGHT_EXT,
            PIXEL_TILE_GRID_DEPTH_SGIX = SGIX_pixel_tiles.PIXEL_TILE_GRID_DEPTH_SGIX,
            PIXEL_TILE_WIDTH_SGIX = SGIX_pixel_tiles.PIXEL_TILE_WIDTH_SGIX,
            PACK_SKIP_ROWS = GetPName.PACK_SKIP_ROWS,
            PACK_SKIP_VOLUMES_SGIS = SGIS_texture4D.PACK_SKIP_VOLUMES_SGIS,
            UNPACK_SKIP_ROWS = GetPName.UNPACK_SKIP_ROWS,
            UNPACK_SKIP_IMAGES_EXT = EXT_texture3D.UNPACK_SKIP_IMAGES_EXT,
            UNPACK_SUBSAMPLE_RATE_SGIX = SGIX_subsample.UNPACK_SUBSAMPLE_RATE_SGIX,
            PIXEL_TILE_GRID_HEIGHT_SGIX = SGIX_pixel_tiles.PIXEL_TILE_GRID_HEIGHT_SGIX,
            PIXEL_TILE_HEIGHT_SGIX = SGIX_pixel_tiles.PIXEL_TILE_HEIGHT_SGIX,
            PACK_RESAMPLE_SGIX = SGIX_resample.PACK_RESAMPLE_SGIX,
            PACK_SKIP_PIXELS = GetPName.PACK_SKIP_PIXELS,
            PACK_IMAGE_DEPTH_SGIS = SGIS_texture4D.PACK_IMAGE_DEPTH_SGIS,
            PIXEL_TILE_GRID_WIDTH_SGIX = SGIX_pixel_tiles.PIXEL_TILE_GRID_WIDTH_SGIX,
            PACK_SWAP_BYTES = GetPName.PACK_SWAP_BYTES,
            UNPACK_SWAP_BYTES = GetPName.UNPACK_SWAP_BYTES,
            PACK_SKIP_IMAGES_EXT = EXT_texture3D.PACK_SKIP_IMAGES_EXT,
            UNPACK_SKIP_VOLUMES_SGIS = SGIS_texture4D.UNPACK_SKIP_VOLUMES_SGIS,
            PACK_LSB_FIRST = GetPName.PACK_LSB_FIRST,
            PACK_ALIGNMENT = GetPName.PACK_ALIGNMENT,
            PACK_ROW_LENGTH = GetPName.PACK_ROW_LENGTH,
            UNPACK_SKIP_PIXELS = GetPName.UNPACK_SKIP_PIXELS,
            PACK_SUBSAMPLE_RATE_SGIX = SGIX_subsample.PACK_SUBSAMPLE_RATE_SGIX,
            PACK_IMAGE_HEIGHT_EXT = EXT_texture3D.PACK_IMAGE_HEIGHT_EXT,
        }

        public enum HintMode : uint
        {
            DONT_CARE = 0x1100,
            NICEST = 0x1102,
            FASTEST = 0x1101,
        }

        public enum ATI_pixel_format_float : uint
        {
            COLOR_CLEAR_UNCLAMPED_VALUE_ATI = 0x8835,
            TYPE_RGBA_FLOAT_ATI = 0x8820,
        }

        public enum INTEL_parallel_arrays : uint
        {
            VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5,
            NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6,
            COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7,
            PARALLEL_ARRAYS_INTEL = 0x83F4,
            TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8,
        }

        public enum HistogramTargetEXT : uint
        {
            HISTOGRAM_EXT = EXT_histogram.HISTOGRAM_EXT,
            PROXY_HISTOGRAM_EXT = EXT_histogram.PROXY_HISTOGRAM_EXT,
        }

        public enum ARB_pixel_buffer_object : uint
        {
            PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED,
            PIXEL_PACK_BUFFER_ARB = 0x88EB,
            PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF,
            PIXEL_UNPACK_BUFFER_ARB = 0x88EC,
        }

        public enum ColorTableTargetSGI : uint
        {
            TEXTURE_COLOR_TABLE_SGI = SGI_texture_color_table.TEXTURE_COLOR_TABLE_SGI,
            POST_COLOR_MATRIX_COLOR_TABLE_SGI = SGI_color_table.POST_COLOR_MATRIX_COLOR_TABLE_SGI,
            PROXY_TEXTURE_COLOR_TABLE_SGI = SGI_texture_color_table.PROXY_TEXTURE_COLOR_TABLE_SGI,
            COLOR_TABLE_SGI = SGI_color_table.COLOR_TABLE_SGI,
            PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = SGI_color_table.PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI,
            PROXY_COLOR_TABLE_SGI = SGI_color_table.PROXY_COLOR_TABLE_SGI,
            PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = SGI_color_table.PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI,
            POST_CONVOLUTION_COLOR_TABLE_SGI = SGI_color_table.POST_CONVOLUTION_COLOR_TABLE_SGI,
        }

        public enum NV_fragment_program2 : uint
        {
            MAX_PROGRAM_IF_DEPTH_NV = 0x88F6,
            MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7,
            MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5,
            MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4,
            MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8,
        }

        public enum SGI_texture_color_table : uint
        {
            TEXTURE_COLOR_TABLE_SGI = 0x80BC,
            PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD,
        }

        public enum OML_resample : uint
        {
            PACK_RESAMPLE_OML = 0x8984,
            RESAMPLE_AVERAGE_OML = 0x8988,
            RESAMPLE_REPLICATE_OML = 0x8986,
            RESAMPLE_DECIMATE_OML = 0x8989,
            UNPACK_RESAMPLE_OML = 0x8985,
            RESAMPLE_ZERO_FILL_OML = 0x8987,
        }

        public enum WIN_phong_shading : uint
        {
            PHONG_WIN = 0x80EA,
            PHONG_HINT_WIN = 0x80EB,
        }

        public enum SGIX_sprite : uint
        {
            SPRITE_SGIX = 0x8148,
            SPRITE_MODE_SGIX = 0x8149,
            SPRITE_TRANSLATION_SGIX = 0x814B,
            SPRITE_AXIS_SGIX = 0x814A,
            SPRITE_AXIAL_SGIX = 0x814C,
            SPRITE_OBJECT_ALIGNED_SGIX = 0x814D,
            SPRITE_EYE_ALIGNED_SGIX = 0x814E,
        }

        public enum EXT_pixel_transform_color_table : uint
        {
        }

        public enum SGIX_async_pixel : uint
        {
            ASYNC_TEX_IMAGE_SGIX = 0x835C,
            MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F,
            ASYNC_DRAW_PIXELS_SGIX = 0x835D,
            ASYNC_READ_PIXELS_SGIX = 0x835E,
            MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360,
            MAX_ASYNC_READ_PIXELS_SGIX = 0x8361,
        }

        public enum BeginMode : uint
        {
            QUAD_STRIP = 0x0008,
            POLYGON = 0x0009,
            LINES = 0x0001,
            TRIANGLES = 0x0004,
            TRIANGLE_STRIP = 0x0005,
            LINE_LOOP = 0x0002,
            LINE_STRIP = 0x0003,
            QUADS = 0x0007,
            TRIANGLE_FAN = 0x0006,
            POINTS = 0x0000,
        }

        public enum NV_fragment_program : uint
        {
            FRAGMENT_PROGRAM_NV = 0x8870,
            MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872,
            PROGRAM_ERROR_STRING_NV = 0x8874,
            MAX_TEXTURE_COORDS_NV = 0x8871,
            FRAGMENT_PROGRAM_BINDING_NV = 0x8873,
            MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868,
        }

        public enum ListMode : uint
        {
            COMPILE = 0x1300,
            COMPILE_AND_EXECUTE = 0x1301,
        }

        public enum GetMapQuery : uint
        {
            ORDER = 0x0A01,
            DOMAIN = 0x0A02,
            COEFF = 0x0A00,
        }

        public enum ARB_matrix_palette : uint
        {
            MAX_PALETTE_MATRICES_ARB = 0x8842,
            CURRENT_MATRIX_INDEX_ARB = 0x8845,
            MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849,
            MATRIX_INDEX_ARRAY_ARB = 0x8844,
            MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846,
            CURRENT_PALETTE_MATRIX_ARB = 0x8843,
            MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841,
            MATRIX_PALETTE_ARB = 0x8840,
            MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848,
            MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847,
        }

        public enum TextureParameterName : uint
        {
            TEXTURE_BORDER_COLOR = GetTextureParameter.TEXTURE_BORDER_COLOR,
            TEXTURE_LOD_BIAS_T_SGIX = SGIX_texture_lod_bias.TEXTURE_LOD_BIAS_T_SGIX,
            TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX,
            POST_TEXTURE_FILTER_BIAS_SGIX = SGIX_texture_scale_bias.POST_TEXTURE_FILTER_BIAS_SGIX,
            TEXTURE_LOD_BIAS_R_SGIX = SGIX_texture_lod_bias.TEXTURE_LOD_BIAS_R_SGIX,
            GENERATE_MIPMAP_SGIS = SGIS_generate_mipmap.GENERATE_MIPMAP_SGIS,
            TEXTURE_CLIPMAP_DEPTH_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_DEPTH_SGIX,
            TEXTURE_COMPARE_OPERATOR_SGIX = SGIX_shadow.TEXTURE_COMPARE_OPERATOR_SGIX,
            QUAD_TEXTURE_SELECT_SGIS = SGIS_texture_select.QUAD_TEXTURE_SELECT_SGIS,
            TEXTURE_CLIPMAP_CENTER_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_CENTER_SGIX,
            TEXTURE_MAX_CLAMP_T_SGIX = SGIX_texture_coordinate_clamp.TEXTURE_MAX_CLAMP_T_SGIX,
            TEXTURE_COMPARE_SGIX = SGIX_shadow.TEXTURE_COMPARE_SGIX,
            TEXTURE_MAX_CLAMP_S_SGIX = SGIX_texture_coordinate_clamp.TEXTURE_MAX_CLAMP_S_SGIX,
            TEXTURE_MAG_FILTER = 0x2800,
            SHADOW_AMBIENT_SGIX = SGIX_shadow_ambient.SHADOW_AMBIENT_SGIX,
            TEXTURE_WRAP_Q_SGIS = SGIS_texture4D.TEXTURE_WRAP_Q_SGIS,
            DETAIL_TEXTURE_MODE_SGIS = SGIS_detail_texture.DETAIL_TEXTURE_MODE_SGIS,
            TEXTURE_CLIPMAP_FRAME_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_FRAME_SGIX,
            DUAL_TEXTURE_SELECT_SGIS = SGIS_texture_select.DUAL_TEXTURE_SELECT_SGIS,
            TEXTURE_WRAP_S = 0x2802,
            TEXTURE_LOD_BIAS_S_SGIX = SGIX_texture_lod_bias.TEXTURE_LOD_BIAS_S_SGIX,
            POST_TEXTURE_FILTER_SCALE_SGIX = SGIX_texture_scale_bias.POST_TEXTURE_FILTER_SCALE_SGIX,
            DETAIL_TEXTURE_LEVEL_SGIS = SGIS_detail_texture.DETAIL_TEXTURE_LEVEL_SGIS,
            TEXTURE_WRAP_R_EXT = EXT_texture3D.TEXTURE_WRAP_R_EXT,
            TEXTURE_MIN_FILTER = 0x2801,
            TEXTURE_CLIPMAP_OFFSET_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_OFFSET_SGIX,
            TEXTURE_WRAP_T = 0x2803,
            TEXTURE_MAX_CLAMP_R_SGIX = SGIX_texture_coordinate_clamp.TEXTURE_MAX_CLAMP_R_SGIX,
            TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_LOD_OFFSET_SGIX,
            TEXTURE_PRIORITY = GetTextureParameter.TEXTURE_PRIORITY,
        }

        public enum IBM_vertex_array_lists : uint
        {
            INDEX_ARRAY_LIST_IBM = 103073,
            FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086,
            SECONDARY_COLOR_ARRAY_LIST_IBM = 103077,
            NORMAL_ARRAY_LIST_IBM = 103071,
            COLOR_ARRAY_LIST_STRIDE_IBM = 103082,
            TEXTURE_COORD_ARRAY_LIST_IBM = 103074,
            EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085,
            COLOR_ARRAY_LIST_IBM = 103072,
            INDEX_ARRAY_LIST_STRIDE_IBM = 103083,
            EDGE_FLAG_ARRAY_LIST_IBM = 103075,
            SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087,
            TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084,
            FOG_COORDINATE_ARRAY_LIST_IBM = 103076,
            VERTEX_ARRAY_LIST_IBM = 103070,
            VERTEX_ARRAY_LIST_STRIDE_IBM = 103080,
            NORMAL_ARRAY_LIST_STRIDE_IBM = 103081,
        }

        public enum FrontFaceDirection : uint
        {
            CCW = 0x0901,
            CW = 0x0900,
        }

        public enum NV_pixel_data_range : uint
        {
            READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B,
            WRITE_PIXEL_DATA_RANGE_NV = 0x8878,
            WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C,
            READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D,
            WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A,
            READ_PIXEL_DATA_RANGE_NV = 0x8879,
        }

        public enum OML_subsample : uint
        {
            FORMAT_SUBSAMPLE_24_24_OML = 0x8982,
            FORMAT_SUBSAMPLE_244_244_OML = 0x8983,
        }

        public enum VERSION_1_5 : uint
        {
            DYNAMIC_READ = 0x88E9,
            VERTEX_ARRAY_BUFFER_BINDING = 0x8896,
            STREAM_COPY = 0x88E2,
            FOG_COORD_ARRAY_STRIDE = GL_FOG_COORDINATE_ARRAY_STRIDE,
            FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D,
            READ_WRITE = 0x88BA,
            SRC1_ALPHA = GL_SOURCE1_ALPHA,
            TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A,
            BUFFER_MAP_POINTER = 0x88BD,
            QUERY_COUNTER_BITS = 0x8864,
            STATIC_COPY = 0x88E6,
            STATIC_DRAW = 0x88E4,
            SRC2_RGB = GL_SOURCE2_RGB,
            SRC2_ALPHA = GL_SOURCE2_ALPHA,
            FOG_COORD_ARRAY = GL_FOG_COORDINATE_ARRAY,
            FOG_COORD_SRC = GL_FOG_COORDINATE_SOURCE,
            DYNAMIC_COPY = 0x88EA,
            STATIC_READ = 0x88E5,
            FOG_COORD_ARRAY_BUFFER_BINDING = GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING,
            FOG_COORD_ARRAY_POINTER = GL_FOG_COORDINATE_ARRAY_POINTER,
            EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B,
            CURRENT_FOG_COORD = GL_CURRENT_FOG_COORDINATE,
            VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F,
            READ_ONLY = 0x88B8,
            SRC0_ALPHA = GL_SOURCE0_ALPHA,
            ELEMENT_ARRAY_BUFFER = 0x8893,
            CURRENT_QUERY = 0x8865,
            FOG_COORD = GL_FOG_COORDINATE,
            QUERY_RESULT = 0x8866,
            BUFFER_USAGE = 0x8765,
            BUFFER_ACCESS = 0x88BB,
            STREAM_DRAW = 0x88E0,
            SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C,
            SRC0_RGB = GL_SOURCE0_RGB,
            ARRAY_BUFFER_BINDING = 0x8894,
            QUERY_RESULT_AVAILABLE = 0x8867,
            WRITE_ONLY = 0x88B9,
            BUFFER_SIZE = 0x8764,
            WEIGHT_ARRAY_BUFFER_BINDING = 0x889E,
            SRC1_RGB = GL_SOURCE1_RGB,
            SAMPLES_PASSED = 0x8914,
            DYNAMIC_DRAW = 0x88E8,
            ARRAY_BUFFER = 0x8892,
            NORMAL_ARRAY_BUFFER_BINDING = 0x8897,
            COLOR_ARRAY_BUFFER_BINDING = 0x8898,
            INDEX_ARRAY_BUFFER_BINDING = 0x8899,
            BUFFER_MAPPED = 0x88BC,
            ELEMENT_ARRAY_BUFFER_BINDING = 0x8895,
            STREAM_READ = 0x88E1,
            FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE,
        }

        public enum NV_point_sprite : uint
        {
            COORD_REPLACE_NV = 0x8862,
            POINT_SPRITE_R_MODE_NV = 0x8863,
            POINT_SPRITE_NV = 0x8861,
        }

        public enum PolygonMode : uint
        {
            FILL = 0x1B02,
            LINE = 0x1B01,
            POINT = 0x1B00,
        }

        public enum NV_fog_distance : uint
        {
            EYE_PLANE = TextureGenParameter.EYE_PLANE,
            FOG_DISTANCE_MODE_NV = 0x855A,
            EYE_RADIAL_NV = 0x855B,
            EYE_PLANE_ABSOLUTE_NV = 0x855C,
        }

        public enum MaterialFace : uint
        {
            BACK = DrawBufferMode.BACK,
            FRONT_AND_BACK = DrawBufferMode.FRONT_AND_BACK,
            FRONT = DrawBufferMode.FRONT,
        }

        public enum BlendingFactorDest : uint
        {
            ZERO = 0,
            ONE_MINUS_SRC_ALPHA = 0x0303,
            ONE_MINUS_DST_ALPHA = 0x0305,
            CONSTANT_COLOR_EXT = EXT_blend_color.CONSTANT_COLOR_EXT,
            DST_ALPHA = 0x0304,
            CONSTANT_ALPHA_EXT = EXT_blend_color.CONSTANT_ALPHA_EXT,
            ONE_MINUS_CONSTANT_COLOR_EXT = EXT_blend_color.ONE_MINUS_CONSTANT_COLOR_EXT,
            ONE_MINUS_CONSTANT_ALPHA_EXT = EXT_blend_color.ONE_MINUS_CONSTANT_ALPHA_EXT,
            SRC_ALPHA = 0x0302,
            SRC_COLOR = 0x0300,
            ONE_MINUS_SRC_COLOR = 0x0301,
            ONE = 1,
        }

        public enum ARB_half_float_pixel : uint
        {
            HALF_FLOAT_ARB = 0x140B,
        }

        public enum MatrixMode : uint
        {
            PROJECTION = 0x1701,
            MODELVIEW = 0x1700,
            TEXTURE = 0x1702,
        }

        public enum TextureMagFilter : uint
        {
            LINEAR = 0x2601,
            PIXEL_TEX_GEN_Q_FLOOR_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_Q_FLOOR_SGIX,
            FILTER4_SGIS = SGIS_texture_filter4.FILTER4_SGIS,
            LINEAR_SHARPEN_SGIS = SGIS_sharpen_texture.LINEAR_SHARPEN_SGIS,
            PIXEL_TEX_GEN_Q_CEILING_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_Q_CEILING_SGIX,
            LINEAR_DETAIL_SGIS = SGIS_detail_texture.LINEAR_DETAIL_SGIS,
            PIXEL_TEX_GEN_Q_ROUND_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_Q_ROUND_SGIX,
            NEAREST = 0x2600,
            LINEAR_SHARPEN_COLOR_SGIS = SGIS_sharpen_texture.LINEAR_SHARPEN_COLOR_SGIS,
            LINEAR_SHARPEN_ALPHA_SGIS = SGIS_sharpen_texture.LINEAR_SHARPEN_ALPHA_SGIS,
            LINEAR_DETAIL_ALPHA_SGIS = SGIS_detail_texture.LINEAR_DETAIL_ALPHA_SGIS,
            LINEAR_DETAIL_COLOR_SGIS = SGIS_detail_texture.LINEAR_DETAIL_COLOR_SGIS,
        }

        public enum GetHistogramParameterPNameEXT : uint
        {
            HISTOGRAM_BLUE_SIZE_EXT = EXT_histogram.HISTOGRAM_BLUE_SIZE_EXT,
            HISTOGRAM_FORMAT_EXT = EXT_histogram.HISTOGRAM_FORMAT_EXT,
            HISTOGRAM_GREEN_SIZE_EXT = EXT_histogram.HISTOGRAM_GREEN_SIZE_EXT,
            HISTOGRAM_ALPHA_SIZE_EXT = EXT_histogram.HISTOGRAM_ALPHA_SIZE_EXT,
            HISTOGRAM_LUMINANCE_SIZE_EXT = EXT_histogram.HISTOGRAM_LUMINANCE_SIZE_EXT,
            HISTOGRAM_RED_SIZE_EXT = EXT_histogram.HISTOGRAM_RED_SIZE_EXT,
            HISTOGRAM_SINK_EXT = EXT_histogram.HISTOGRAM_SINK_EXT,
            HISTOGRAM_WIDTH_EXT = EXT_histogram.HISTOGRAM_WIDTH_EXT,
        }

        public enum CullFaceMode : uint
        {
            BACK = DrawBufferMode.BACK,
            FRONT_AND_BACK = DrawBufferMode.FRONT_AND_BACK,
            FRONT = DrawBufferMode.FRONT,
        }

        public enum ConvolutionBorderModeEXT : uint
        {
            REDUCE_EXT = EXT_convolution.REDUCE_EXT,
        }

        public enum SGIX_blend_alpha_minmax : uint
        {
            ALPHA_MAX_SGIX = 0x8321,
            ALPHA_MIN_SGIX = 0x8320,
        }

        public enum MinmaxTargetEXT : uint
        {
            MINMAX_EXT = EXT_histogram.MINMAX_EXT,
        }

        public enum FfdMaskSGIX : uint
        {
            GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002,
            TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001,
        }

        public enum TextureEnvParameter : uint
        {
            TEXTURE_ENV_COLOR = 0x2201,
            TEXTURE_ENV_MODE = 0x2200,
        }

        public enum _3DFX_multisample : uint
        {
            SAMPLE_BUFFERS_3DFX = 0x86B3,
            MULTISAMPLE_BIT_3DFX = 0x20000000,
            MULTISAMPLE_3DFX = 0x86B2,
            SAMPLES_3DFX = 0x86B4,
        }

        public enum DrawBufferMode : uint
        {
            FRONT_RIGHT = 0x0401,
            AUX3 = 0x040C,
            AUX1 = 0x040A,
            FRONT_AND_BACK = 0x0408,
            LEFT = 0x0406,
            NONE = 0,
            RIGHT = 0x0407,
            BACK_RIGHT = 0x0403,
            AUX2 = 0x040B,
            AUX0 = 0x0409,
            FRONT_LEFT = 0x0400,
            BACK = 0x0405,
            FRONT = 0x0404,
            BACK_LEFT = 0x0402,
        }

        public enum ShadingModel : uint
        {
            SMOOTH = 0x1D01,
            FLAT = 0x1D00,
        }

        public enum EXT_coordinate_frame : uint
        {
            BINORMAL_ARRAY_STRIDE_EXT = 0x8441,
            BINORMAL_ARRAY_TYPE_EXT = 0x8440,
            MAP1_TANGENT_EXT = 0x8444,
            TANGENT_ARRAY_POINTER_EXT = 0x8442,
            CURRENT_TANGENT_EXT = 0x843B,
            MAP1_BINORMAL_EXT = 0x8446,
            TANGENT_ARRAY_TYPE_EXT = 0x843E,
            CURRENT_BINORMAL_EXT = 0x843C,
            MAP2_TANGENT_EXT = 0x8445,
            MAP2_BINORMAL_EXT = 0x8447,
            BINORMAL_ARRAY_EXT = 0x843A,
            TANGENT_ARRAY_STRIDE_EXT = 0x843F,
            TANGENT_ARRAY_EXT = 0x8439,
            BINORMAL_ARRAY_POINTER_EXT = 0x8443,
        }

        public enum EXT_texture3D : uint
        {
            TEXTURE_WRAP_R = 0x8072,
            UNPACK_IMAGE_HEIGHT_EXT = 0x806E,
            PROXY_TEXTURE_3D = 0x8070,
            UNPACK_SKIP_IMAGES_EXT = 0x806D,
            MAX_3D_TEXTURE_SIZE = 0x8073,
            TEXTURE_3D_EXT = 0x806F,
            PACK_SKIP_IMAGES = 0x806B,
            PACK_IMAGE_HEIGHT = 0x806C,
            PROXY_TEXTURE_3D_EXT = 0x8070,
            MAX_3D_TEXTURE_SIZE_EXT = 0x8073,
            TEXTURE_DEPTH_EXT = 0x8071,
            TEXTURE_DEPTH = 0x8071,
            PACK_SKIP_IMAGES_EXT = 0x806B,
            TEXTURE_WRAP_R_EXT = 0x8072,
            UNPACK_SKIP_IMAGES = 0x806D,
            UNPACK_IMAGE_HEIGHT = 0x806E,
            TEXTURE_3D = 0x806F,
            PACK_IMAGE_HEIGHT_EXT = 0x806C,
        }

        public enum ColorMaterialParameter : uint
        {
            EMISSION = MaterialParameter.EMISSION,
            DIFFUSE = LightParameter.DIFFUSE,
            AMBIENT_AND_DIFFUSE = MaterialParameter.AMBIENT_AND_DIFFUSE,
            SPECULAR = LightParameter.SPECULAR,
            AMBIENT = LightParameter.AMBIENT,
        }

        public enum TextureWrapMode : uint
        {
            CLAMP_TO_BORDER_SGIS = SGIS_texture_border_clamp.CLAMP_TO_BORDER_SGIS,
            CLAMP = 0x2900,
            REPEAT = 0x2901,
            CLAMP_TO_EDGE_SGIS = SGIS_texture_edge_clamp.CLAMP_TO_EDGE_SGIS,
        }

        public enum SGIX_interlace : uint
        {
            INTERLACE_SGIX = 0x8094,
        }

        public enum EXT_vertex_array : uint
        {
            TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092,
            NORMAL_ARRAY_COUNT_EXT = 0x8080,
            INDEX_ARRAY_TYPE_EXT = 0x8085,
            VERTEX_ARRAY_TYPE_EXT = 0x807B,
            INDEX_ARRAY_COUNT_EXT = 0x8087,
            TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088,
            COLOR_ARRAY_POINTER_EXT = 0x8090,
            INDEX_ARRAY_POINTER_EXT = 0x8091,
            COLOR_ARRAY_TYPE_EXT = 0x8082,
            NORMAL_ARRAY_POINTER_EXT = 0x808F,
            TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B,
            VERTEX_ARRAY_SIZE_EXT = 0x807A,
            VERTEX_ARRAY_STRIDE_EXT = 0x807C,
            VERTEX_ARRAY_POINTER_EXT = 0x808E,
            INDEX_ARRAY_STRIDE_EXT = 0x8086,
            VERTEX_ARRAY_COUNT_EXT = 0x807D,
            EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093,
            TEXTURE_COORD_ARRAY_EXT = 0x8078,
            VERTEX_ARRAY_EXT = 0x8074,
            TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A,
            COLOR_ARRAY_EXT = 0x8076,
            COLOR_ARRAY_SIZE_EXT = 0x8081,
            TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089,
            NORMAL_ARRAY_TYPE_EXT = 0x807E,
            NORMAL_ARRAY_STRIDE_EXT = 0x807F,
            COLOR_ARRAY_COUNT_EXT = 0x8084,
            EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C,
            EDGE_FLAG_ARRAY_EXT = 0x8079,
            INDEX_ARRAY_EXT = 0x8077,
            NORMAL_ARRAY_EXT = 0x8075,
            EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D,
            COLOR_ARRAY_STRIDE_EXT = 0x8083,
        }

        public enum NV_texture_env_combine4 : uint
        {
            COMBINE4_NV = 0x8503,
            SOURCE3_RGB_NV = 0x8583,
            SOURCE3_ALPHA_NV = 0x858B,
            OPERAND3_RGB_NV = 0x8593,
            OPERAND3_ALPHA_NV = 0x859B,
        }

        public enum PixelCopyType : uint
        {
            DEPTH = 0x1801,
            COLOR = 0x1800,
            STENCIL = 0x1802,
        }

        public enum LightParameter : uint
        {
            POSITION = 0x1203,
            SPOT_DIRECTION = 0x1204,
            LINEAR_ATTENUATION = 0x1208,
            SPOT_CUTOFF = 0x1206,
            SPOT_EXPONENT = 0x1205,
            CONSTANT_ATTENUATION = 0x1207,
            QUADRATIC_ATTENUATION = 0x1209,
            SPECULAR = 0x1202,
            DIFFUSE = 0x1201,
            AMBIENT = 0x1200,
        }

        public enum GetMinmaxParameterPNameEXT : uint
        {
            MINMAX_SINK_EXT = EXT_histogram.MINMAX_SINK_EXT,
            MINMAX_FORMAT_EXT = EXT_histogram.MINMAX_FORMAT_EXT,
        }

        public enum ARB_imaging : uint
        {
            CONVOLUTION_WIDTH = 0x8018,
            COLOR_MATRIX_STACK_DEPTH = 0x80B2,
            BLEND_EQUATION = 0x8009,
            COLOR_TABLE_BIAS = 0x80D7,
            CONSTANT_BORDER = 0x8151,
            HISTOGRAM = 0x8024,
            COLOR_TABLE_GREEN_SIZE = 0x80DB,
            HISTOGRAM_RED_SIZE = 0x8028,
            CONSTANT_ALPHA = 0x8003,
            TABLE_TOO_LARGE = 0x8031,
            POST_CONVOLUTION_GREEN_SCALE = 0x801D,
            MINMAX_SINK = 0x8030,
            PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5,
            COLOR_TABLE_SCALE = 0x80D6,
            COLOR_MATRIX = 0x80B1,
            CONVOLUTION_FILTER_SCALE = 0x8014,
            BLEND_COLOR = 0x8005,
            MIN = 0x8007,
            HISTOGRAM_SINK = 0x802D,
            POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5,
            SEPARABLE_2D = 0x8012,
            FUNC_REVERSE_SUBTRACT = 0x800B,
            CONVOLUTION_FORMAT = 0x8017,
            REPLICATE_BORDER = 0x8153,
            CONSTANT_COLOR = 0x8001,
            COLOR_TABLE = 0x80D0,
            POST_CONVOLUTION_BLUE_SCALE = 0x801E,
            FUNC_ADD = 0x8006,
            CONVOLUTION_2D = 0x8011,
            POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB,
            POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7,
            MINMAX = 0x802E,
            POST_CONVOLUTION_ALPHA_BIAS = 0x8023,
            POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6,
            POST_COLOR_MATRIX_RED_BIAS = 0x80B8,
            HISTOGRAM_BLUE_SIZE = 0x802A,
            POST_CONVOLUTION_BLUE_BIAS = 0x8022,
            COLOR_TABLE_FORMAT = 0x80D8,
            POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2,
            CONVOLUTION_HEIGHT = 0x8019,
            POST_CONVOLUTION_COLOR_TABLE = 0x80D1,
            MINMAX_FORMAT = 0x802F,
            COLOR_TABLE_ALPHA_SIZE = 0x80DD,
            POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA,
            PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4,
            PROXY_COLOR_TABLE = 0x80D3,
            HISTOGRAM_ALPHA_SIZE = 0x802B,
            MAX_CONVOLUTION_WIDTH = 0x801A,
            POST_COLOR_MATRIX_RED_SCALE = 0x80B4,
            POST_CONVOLUTION_ALPHA_SCALE = 0x801F,
            CONVOLUTION_BORDER_COLOR = 0x8154,
            COLOR_TABLE_BLUE_SIZE = 0x80DC,
            ONE_MINUS_CONSTANT_COLOR = 0x8002,
            COLOR_TABLE_LUMINANCE_SIZE = 0x80DE,
            POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9,
            ONE_MINUS_CONSTANT_ALPHA = 0x8004,
            FUNC_SUBTRACT = 0x800A,
            COLOR_TABLE_INTENSITY_SIZE = 0x80DF,
            REDUCE = 0x8016,
            COLOR_TABLE_RED_SIZE = 0x80DA,
            CONVOLUTION_BORDER_MODE = 0x8013,
            HISTOGRAM_GREEN_SIZE = 0x8029,
            POST_CONVOLUTION_GREEN_BIAS = 0x8021,
            HISTOGRAM_FORMAT = 0x8027,
            CONVOLUTION_1D = 0x8010,
            POST_CONVOLUTION_RED_BIAS = 0x8020,
            MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3,
            COLOR_TABLE_WIDTH = 0x80D9,
            POST_CONVOLUTION_RED_SCALE = 0x801C,
            MAX = 0x8008,
            PROXY_HISTOGRAM = 0x8025,
            MAX_CONVOLUTION_HEIGHT = 0x801B,
            CONVOLUTION_FILTER_BIAS = 0x8015,
            HISTOGRAM_WIDTH = 0x8026,
            HISTOGRAM_LUMINANCE_SIZE = 0x802C,
        }

        public enum ATI_texture_float : uint
        {
            ALPHA_FLOAT32_ATI = 0x8816,
            INTENSITY_FLOAT32_ATI = 0x8817,
            LUMINANCE_FLOAT32_ATI = 0x8818,
            LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F,
            ALPHA_FLOAT16_ATI = 0x881C,
            LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819,
            RGBA_FLOAT16_ATI = 0x881A,
            RGBA_FLOAT32_ATI = 0x8814,
            LUMINANCE_FLOAT16_ATI = 0x881E,
            RGB_FLOAT32_ATI = 0x8815,
            INTENSITY_FLOAT16_ATI = 0x881D,
            RGB_FLOAT16_ATI = 0x881B,
        }

        public enum NV_vertex_program2_option : uint
        {
            MAX_PROGRAM_CALL_DEPTH_NV = NV_fragment_program2.MAX_PROGRAM_CALL_DEPTH_NV,
            MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = NV_fragment_program2.MAX_PROGRAM_EXEC_INSTRUCTIONS_NV,
        }

        public enum EXT_blend_func_separate : uint
        {
            BLEND_SRC_ALPHA_EXT = 0x80CB,
            BLEND_DST_RGB_EXT = 0x80C8,
            BLEND_DST_ALPHA_EXT = 0x80CA,
            BLEND_SRC_RGB_EXT = 0x80C9,
        }

        public enum NV_vertex_program : uint
        {
            VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643,
            MAP1_VERTEX_ATTRIB12_4_NV = 0x866C,
            ATTRIB_ARRAY_SIZE_NV = 0x8623,
            MATRIX7_NV = 0x8637,
            MAP2_VERTEX_ATTRIB14_4_NV = 0x867E,
            VERTEX_ATTRIB_ARRAY2_NV = 0x8652,
            MAP2_VERTEX_ATTRIB15_4_NV = 0x867F,
            VERTEX_ATTRIB_ARRAY9_NV = 0x8659,
            MAP2_VERTEX_ATTRIB12_4_NV = 0x867C,
            MAP2_VERTEX_ATTRIB3_4_NV = 0x8673,
            VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642,
            MODELVIEW_PROJECTION_NV = 0x8629,
            MAP2_VERTEX_ATTRIB2_4_NV = 0x8672,
            MAP2_VERTEX_ATTRIB11_4_NV = 0x867B,
            VERTEX_ATTRIB_ARRAY8_NV = 0x8658,
            CURRENT_MATRIX_NV = 0x8641,
            VERTEX_PROGRAM_BINDING_NV = 0x864A,
            VERTEX_ATTRIB_ARRAY0_NV = 0x8650,
            MAP2_VERTEX_ATTRIB1_4_NV = 0x8671,
            VERTEX_ATTRIB_ARRAY7_NV = 0x8657,
            PROGRAM_PARAMETER_NV = 0x8644,
            VERTEX_PROGRAM_NV = 0x8620,
            ATTRIB_ARRAY_POINTER_NV = 0x8645,
            PROGRAM_STRING_NV = 0x8628,
            MAP2_VERTEX_ATTRIB0_4_NV = 0x8670,
            VERTEX_ATTRIB_ARRAY4_NV = 0x8654,
            MAP1_VERTEX_ATTRIB7_4_NV = 0x8667,
            PROGRAM_TARGET_NV = 0x8646,
            MAP1_VERTEX_ATTRIB11_4_NV = 0x866B,
            MAP2_VERTEX_ATTRIB7_4_NV = 0x8677,
            VERTEX_ATTRIB_ARRAY6_NV = 0x8656,
            MAP1_VERTEX_ATTRIB8_4_NV = 0x8668,
            VERTEX_ATTRIB_ARRAY5_NV = 0x8655,
            VERTEX_STATE_PROGRAM_NV = 0x8621,
            MAP1_VERTEX_ATTRIB9_4_NV = 0x8669,
            IDENTITY_NV = 0x862A,
            MAP2_VERTEX_ATTRIB6_4_NV = 0x8676,
            MATRIX4_NV = 0x8634,
            PROGRAM_RESIDENT_NV = 0x8647,
            MAP1_VERTEX_ATTRIB5_4_NV = 0x8665,
            MAP2_VERTEX_ATTRIB4_4_NV = 0x8674,
            MAP1_VERTEX_ATTRIB6_4_NV = 0x8666,
            MAP1_VERTEX_ATTRIB13_4_NV = 0x866D,
            MAP2_VERTEX_ATTRIB5_4_NV = 0x8675,
            MAP1_VERTEX_ATTRIB10_4_NV = 0x866A,
            MAP1_VERTEX_ATTRIB1_4_NV = 0x8661,
            MAP2_VERTEX_ATTRIB13_4_NV = 0x867D,
            VERTEX_ATTRIB_ARRAY3_NV = 0x8653,
            ATTRIB_ARRAY_TYPE_NV = 0x8625,
            MAP1_VERTEX_ATTRIB14_4_NV = 0x866E,
            MAP1_VERTEX_ATTRIB2_4_NV = 0x8662,
            TRACK_MATRIX_TRANSFORM_NV = 0x8649,
            MATRIX0_NV = 0x8630,
            MAP1_VERTEX_ATTRIB3_4_NV = 0x8663,
            MAP2_VERTEX_ATTRIB10_4_NV = 0x867A,
            INVERSE_NV = 0x862B,
            VERTEX_ATTRIB_ARRAY14_NV = 0x865E,
            VERTEX_ATTRIB_ARRAY15_NV = 0x865F,
            VERTEX_ATTRIB_ARRAY12_NV = 0x865C,
            MAX_TRACK_MATRICES_NV = 0x862F,
            MAP1_VERTEX_ATTRIB4_4_NV = 0x8664,
            VERTEX_ATTRIB_ARRAY11_NV = 0x865B,
            VERTEX_ATTRIB_ARRAY13_NV = 0x865D,
            VERTEX_ATTRIB_ARRAY10_NV = 0x865A,
            MATRIX6_NV = 0x8636,
            PROGRAM_LENGTH_NV = 0x8627,
            MAP1_VERTEX_ATTRIB0_4_NV = 0x8660,
            VERTEX_ATTRIB_ARRAY1_NV = 0x8651,
            MAP1_VERTEX_ATTRIB15_4_NV = 0x866F,
            MAP2_VERTEX_ATTRIB9_4_NV = 0x8679,
            INVERSE_TRANSPOSE_NV = 0x862D,
            PROGRAM_ERROR_POSITION_NV = 0x864B,
            TRACK_MATRIX_NV = 0x8648,
            MAP2_VERTEX_ATTRIB8_4_NV = 0x8678,
            CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640,
            MATRIX1_NV = 0x8631,
            ATTRIB_ARRAY_STRIDE_NV = 0x8624,
            MATRIX3_NV = 0x8633,
            MATRIX5_NV = 0x8635,
            TRANSPOSE_NV = 0x862C,
            MATRIX2_NV = 0x8632,
            CURRENT_ATTRIB_NV = 0x8626,
            MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E,
        }

        public enum ARB_shadow_ambient : uint
        {
            TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF,
        }

        public enum FragmentLightModelParameterSGIX : uint
        {
            FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX,
            FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX,
            FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX,
            FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX,
        }

        public enum StringName : uint
        {
            EXTENSIONS = 0x1F03,
            VERSION = 0x1F02,
            RENDERER = 0x1F01,
            VENDOR = 0x1F00,
        }

        public enum MESA_pack_invert : uint
        {
            PACK_INVERT_MESA = 0x8758,
        }

        public enum NV_texgen_reflection : uint
        {
            NORMAL_MAP_NV = 0x8511,
            REFLECTION_MAP_NV = 0x8512,
        }

        public enum FfdTargetSGIX : uint
        {
            GEOMETRY_DEFORMATION_SGIX = SGIX_polynomial_ffd.GEOMETRY_DEFORMATION_SGIX,
            TEXTURE_DEFORMATION_SGIX = SGIX_polynomial_ffd.TEXTURE_DEFORMATION_SGIX,
        }

        public enum EnableCap : uint
        {
            MAP1_VERTEX_3 = GetPName.MAP1_VERTEX_3,
            MAP2_NORMAL = GetPName.MAP2_NORMAL,
            FRAGMENT_LIGHT6_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT6_SGIX,
            CLIP_PLANE4 = GetPName.CLIP_PLANE4,
            ASYNC_HISTOGRAM_SGIX = SGIX_async_histogram.ASYNC_HISTOGRAM_SGIX,
            FRAGMENT_LIGHT3_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT3_SGIX,
            HISTOGRAM_EXT = EXT_histogram.HISTOGRAM_EXT,
            LIGHT3 = GetPName.LIGHT3,
            POST_COLOR_MATRIX_COLOR_TABLE_SGI = SGI_color_table.POST_COLOR_MATRIX_COLOR_TABLE_SGI,
            CLIP_PLANE3 = GetPName.CLIP_PLANE3,
            TEXTURE_COORD_ARRAY = GetPName.TEXTURE_COORD_ARRAY,
            FOG_OFFSET_SGIX = SGIX_fog_offset.FOG_OFFSET_SGIX,
            CONVOLUTION_1D_EXT = EXT_convolution.CONVOLUTION_1D_EXT,
            ASYNC_READ_PIXELS_SGIX = SGIX_async_pixel.ASYNC_READ_PIXELS_SGIX,
            LIGHT4 = GetPName.LIGHT4,
            MAP2_INDEX = GetPName.MAP2_INDEX,
            MAP1_TEXTURE_COORD_1 = GetPName.MAP1_TEXTURE_COORD_1,
            POLYGON_OFFSET_POINT = GetPName.POLYGON_OFFSET_POINT,
            ASYNC_DRAW_PIXELS_SGIX = SGIX_async_pixel.ASYNC_DRAW_PIXELS_SGIX,
            TEXTURE_1D = GetPName.TEXTURE_1D,
            CONVOLUTION_2D_EXT = EXT_convolution.CONVOLUTION_2D_EXT,
            TEXTURE_2D = GetPName.TEXTURE_2D,
            MAP1_COLOR_4 = GetPName.MAP1_COLOR_4,
            INDEX_LOGIC_OP = GetPName.INDEX_LOGIC_OP,
            RESCALE_NORMAL_EXT = EXT_rescale_normal.RESCALE_NORMAL_EXT,
            FRAGMENT_LIGHT4_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT4_SGIX,
            SAMPLE_MASK_SGIS = SGIS_multisample.SAMPLE_MASK_SGIS,
            LINE_STIPPLE = GetPName.LINE_STIPPLE,
            POLYGON_OFFSET_FILL = GetPName.POLYGON_OFFSET_FILL,
            LIGHT0 = GetPName.LIGHT0,
            FRAGMENT_LIGHT5_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT5_SGIX,
            CLIP_PLANE2 = GetPName.CLIP_PLANE2,
            LIGHT5 = GetPName.LIGHT5,
            FRAGMENT_LIGHT1_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT1_SGIX,
            REFERENCE_PLANE_SGIX = SGIX_reference_plane.REFERENCE_PLANE_SGIX,
            SAMPLE_ALPHA_TO_MASK_SGIS = SGIS_multisample.SAMPLE_ALPHA_TO_MASK_SGIS,
            CLIP_PLANE1 = GetPName.CLIP_PLANE1,
            COLOR_LOGIC_OP = GetPName.COLOR_LOGIC_OP,
            FRAGMENT_LIGHT7_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT7_SGIX,
            ASYNC_TEX_IMAGE_SGIX = SGIX_async_pixel.ASYNC_TEX_IMAGE_SGIX,
            MAP1_TEXTURE_COORD_4 = GetPName.MAP1_TEXTURE_COORD_4,
            MAP2_TEXTURE_COORD_2 = GetPName.MAP2_TEXTURE_COORD_2,
            NORMAL_ARRAY = GetPName.NORMAL_ARRAY,
            FOG = GetPName.FOG,
            CALLIGRAPHIC_FRAGMENT_SGIX = SGIX_calligraphic_fragment.CALLIGRAPHIC_FRAGMENT_SGIX,
            POINT_SMOOTH = GetPName.POINT_SMOOTH,
            SCISSOR_TEST = GetPName.SCISSOR_TEST,
            INDEX_ARRAY = GetPName.INDEX_ARRAY,
            TEXTURE_GEN_S = GetPName.TEXTURE_GEN_S,
            TEXTURE_GEN_R = GetPName.TEXTURE_GEN_R,
            TEXTURE_3D_EXT = EXT_texture3D.TEXTURE_3D_EXT,
            NORMALIZE = GetPName.NORMALIZE,
            CULL_FACE = GetPName.CULL_FACE,
            LIGHT1 = GetPName.LIGHT1,
            MAP1_NORMAL = GetPName.MAP1_NORMAL,
            DEPTH_TEST = GetPName.DEPTH_TEST,
            FRAGMENT_LIGHTING_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHTING_SGIX,
            MINMAX_EXT = EXT_histogram.MINMAX_EXT,
            POLYGON_OFFSET_LINE = GetPName.POLYGON_OFFSET_LINE,
            COLOR_TABLE_SGI = SGI_color_table.COLOR_TABLE_SGI,
            MAP1_INDEX = GetPName.MAP1_INDEX,
            AUTO_NORMAL = GetPName.AUTO_NORMAL,
            POLYGON_SMOOTH = GetPName.POLYGON_SMOOTH,
            POST_CONVOLUTION_COLOR_TABLE_SGI = SGI_color_table.POST_CONVOLUTION_COLOR_TABLE_SGI,
            PIXEL_TEX_GEN_SGIX = SGIX_pixel_texture.PIXEL_TEX_GEN_SGIX,
            CLIP_PLANE0 = GetPName.CLIP_PLANE0,
            SHARED_TEXTURE_PALETTE_EXT = EXT_shared_texture_palette.SHARED_TEXTURE_PALETTE_EXT,
            POLYGON_STIPPLE = GetPName.POLYGON_STIPPLE,
            SAMPLE_ALPHA_TO_ONE_SGIS = SGIS_multisample.SAMPLE_ALPHA_TO_ONE_SGIS,
            MAP1_TEXTURE_COORD_3 = GetPName.MAP1_TEXTURE_COORD_3,
            MAP2_TEXTURE_COORD_3 = GetPName.MAP2_TEXTURE_COORD_3,
            IR_INSTRUMENT1_SGIX = SGIX_ir_instrument1.IR_INSTRUMENT1_SGIX,
            TEXTURE_4D_SGIS = SGIS_texture4D.TEXTURE_4D_SGIS,
            FRAGMENT_LIGHT2_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT2_SGIX,
            PIXEL_TEXTURE_SGIS = SGIS_pixel_texture.PIXEL_TEXTURE_SGIS,
            LIGHT6 = GetPName.LIGHT6,
            ALPHA_TEST = GetPName.ALPHA_TEST,
            STENCIL_TEST = GetPName.STENCIL_TEST,
            BLEND = GetPName.BLEND,
            MAP2_COLOR_4 = GetPName.MAP2_COLOR_4,
            FRAMEZOOM_SGIX = SGIX_framezoom.FRAMEZOOM_SGIX,
            FRAGMENT_LIGHT0_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT0_SGIX,
            LIGHTING = GetPName.LIGHTING,
            TEXTURE_COLOR_TABLE_SGI = SGI_texture_color_table.TEXTURE_COLOR_TABLE_SGI,
            CLIP_PLANE5 = GetPName.CLIP_PLANE5,
            LINE_SMOOTH = GetPName.LINE_SMOOTH,
            SEPARABLE_2D_EXT = EXT_convolution.SEPARABLE_2D_EXT,
            DITHER = GetPName.DITHER,
            INTERLACE_SGIX = SGIX_interlace.INTERLACE_SGIX,
            LIGHT2 = GetPName.LIGHT2,
            TEXTURE_GEN_Q = GetPName.TEXTURE_GEN_Q,
            EDGE_FLAG_ARRAY = GetPName.EDGE_FLAG_ARRAY,
            COLOR_ARRAY = GetPName.COLOR_ARRAY,
            TEXTURE_GEN_T = GetPName.TEXTURE_GEN_T,
            MAP2_VERTEX_4 = GetPName.MAP2_VERTEX_4,
            MAP1_TEXTURE_COORD_2 = GetPName.MAP1_TEXTURE_COORD_2,
            MAP2_TEXTURE_COORD_4 = GetPName.MAP2_TEXTURE_COORD_4,
            LIGHT7 = GetPName.LIGHT7,
            SPRITE_SGIX = SGIX_sprite.SPRITE_SGIX,
            FRAGMENT_COLOR_MATERIAL_SGIX = SGIX_fragment_lighting.FRAGMENT_COLOR_MATERIAL_SGIX,
            MAP2_VERTEX_3 = GetPName.MAP2_VERTEX_3,
            MAP2_TEXTURE_COORD_1 = GetPName.MAP2_TEXTURE_COORD_1,
            MAP1_VERTEX_4 = GetPName.MAP1_VERTEX_4,
            MULTISAMPLE_SGIS = SGIS_multisample.MULTISAMPLE_SGIS,
            VERTEX_ARRAY = GetPName.VERTEX_ARRAY,
            COLOR_MATERIAL = GetPName.COLOR_MATERIAL,
        }

        public enum EXT_bgra : uint
        {
            BGRA = 0x80E1,
            BGR_EXT = 0x80E0,
            BGRA_EXT = 0x80E1,
            BGR = 0x80E0,
        }

        public enum SGIS_point_line_texgen : uint
        {
            EYE_DISTANCE_TO_LINE_SGIS = 0x81F2,
            EYE_LINE_SGIS = 0x81F6,
            OBJECT_LINE_SGIS = 0x81F7,
            OBJECT_POINT_SGIS = 0x81F5,
            OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1,
            EYE_POINT_SGIS = 0x81F4,
            OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3,
            EYE_DISTANCE_TO_POINT_SGIS = 0x81F0,
        }

        public enum ATI_vertex_streams : uint
        {
            VERTEX_STREAM6_ATI = 0x8772,
            VERTEX_STREAM1_ATI = 0x876D,
            VERTEX_STREAM3_ATI = 0x876F,
            MAX_VERTEX_STREAMS_ATI = 0x876B,
            VERTEX_STREAM4_ATI = 0x8770,
            VERTEX_STREAM0_ATI = 0x876C,
            VERTEX_STREAM2_ATI = 0x876E,
            VERTEX_SOURCE_ATI = 0x8774,
            VERTEX_STREAM7_ATI = 0x8773,
            VERTEX_STREAM5_ATI = 0x8771,
        }

        public enum EXT_texture_env_dot3 : uint
        {
            DOT3_RGB_EXT = 0x8740,
            DOT3_RGBA_EXT = 0x8741,
        }

        public enum _3DFX_texture_compression_FXT1 : uint
        {
            COMPRESSED_RGBA_FXT1_3DFX = 0x86B1,
            COMPRESSED_RGB_FXT1_3DFX = 0x86B0,
        }

        public enum REND_screen_coordinates : uint
        {
            SCREEN_COORDINATES_REND = 0x8490,
            INVERTED_SCREEN_W_REND = 0x8491,
        }

        public enum SUN_triangle_list : uint
        {
            R1UI_N3F_V3F_SUN = 0x85C7,
            REPLACE_MIDDLE_SUN = 0x0002,
            REPLACE_OLDEST_SUN = 0x0003,
            R1UI_V3F_SUN = 0x85C4,
            REPLACEMENT_CODE_SUN = 0x81D8,
            R1UI_T2F_N3F_V3F_SUN = 0x85CA,
            RESTART_SUN = 0x0001,
            REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2,
            R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB,
            R1UI_C4F_N3F_V3F_SUN = 0x85C8,
            R1UI_T2F_V3F_SUN = 0x85C9,
            TRIANGLE_LIST_SUN = 0x81D7,
            REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1,
            R1UI_C3F_V3F_SUN = 0x85C6,
            R1UI_C4UB_V3F_SUN = 0x85C5,
            REPLACEMENT_CODE_ARRAY_SUN = 0x85C0,
            REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3,
        }

        public enum WIN_specular_fog : uint
        {
            FOG_SPECULAR_TEXTURE_WIN = 0x80EC,
        }

        public enum ARB_shader_objects : uint
        {
            OBJECT_VALIDATE_STATUS_ARB = 0x8B83,
            BOOL_VEC3_ARB = 0x8B58,
            SAMPLER_2D_RECT_ARB = 0x8B63,
            OBJECT_COMPILE_STATUS_ARB = 0x8B81,
            OBJECT_DELETE_STATUS_ARB = 0x8B80,
            OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87,
            FLOAT_MAT2_ARB = 0x8B5A,
            BOOL_ARB = 0x8B56,
            FLOAT_MAT4_ARB = 0x8B5C,
            OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88,
            SAMPLER_3D_ARB = 0x8B5F,
            OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84,
            INT_VEC4_ARB = 0x8B55,
            FLOAT_MAT3_ARB = 0x8B5B,
            PROGRAM_OBJECT_ARB = 0x8B40,
            SAMPLER_1D_SHADOW_ARB = 0x8B61,
            OBJECT_TYPE_ARB = 0x8B4E,
            BOOL_VEC4_ARB = 0x8B59,
            BOOL_VEC2_ARB = 0x8B57,
            OBJECT_SUBTYPE_ARB = 0x8B4F,
            SAMPLER_1D_ARB = 0x8B5D,
            SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64,
            SHADER_OBJECT_ARB = 0x8B48,
            FLOAT_VEC2_ARB = 0x8B50,
            SAMPLER_2D_SHADOW_ARB = 0x8B62,
            OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85,
            FLOAT_VEC4_ARB = 0x8B52,
            OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86,
            SAMPLER_CUBE_ARB = 0x8B60,
            SAMPLER_2D_ARB = 0x8B5E,
            INT_VEC2_ARB = 0x8B53,
            OBJECT_LINK_STATUS_ARB = 0x8B82,
            INT_VEC3_ARB = 0x8B54,
            FLOAT_VEC3_ARB = 0x8B51,
        }

        public enum LogicOp : uint
        {
            SET = 0x150F,
            EQUIV = 0x1509,
            NAND = 0x150E,
            NOR = 0x1508,
            XOR = 0x1506,
            OR = 0x1507,
            COPY_INVERTED = 0x150C,
            AND_INVERTED = 0x1504,
            INVERT = 0x150A,
            AND_REVERSE = 0x1502,
            NOOP = 0x1505,
            CLEAR = 0x1500,
            OR_REVERSE = 0x150B,
            OR_INVERTED = 0x150D,
            AND = 0x1501,
            COPY = 0x1503,
        }

        public enum INGR_palette_buffer : uint
        {
        }

        public enum MESA_window_pos : uint
        {
        }

        public enum DepthFunction : uint
        {
            NEVER = AlphaFunction.NEVER,
            GEQUAL = AlphaFunction.GEQUAL,
            GREATER = AlphaFunction.GREATER,
            ALWAYS = AlphaFunction.ALWAYS,
            LEQUAL = AlphaFunction.LEQUAL,
            NOTEQUAL = AlphaFunction.NOTEQUAL,
            EQUAL = AlphaFunction.EQUAL,
            LESS = AlphaFunction.LESS,
        }

        public enum ARB_texture_non_power_of_two : uint
        {
        }

        public enum SGIX_resample : uint
        {
            UNPACK_RESAMPLE_SGIX = 0x842D,
            RESAMPLE_DECIMATE_SGIX = 0x8430,
            RESAMPLE_REPLICATE_SGIX = 0x842E,
            PACK_RESAMPLE_SGIX = 0x842C,
            RESAMPLE_ZERO_FILL_SGIX = 0x842F,
        }

        public enum TextureFilterFuncSGIS : uint
        {
            FILTER4_SGIS = SGIS_texture_filter4.FILTER4_SGIS,
        }

        public enum SGIX_ycrcba : uint
        {
            YCRCBA_SGIX = 0x8319,
            YCRCB_SGIX = 0x8318,
        }

        public enum EXT_convolution : uint
        {
            CONVOLUTION_WIDTH = 0x8018,
            CONVOLUTION_1D = 0x8010,
            CONVOLUTION_FILTER_SCALE_EXT = 0x8014,
            CONVOLUTION_2D = 0x8011,
            CONVOLUTION_WIDTH_EXT = 0x8018,
            POST_CONVOLUTION_ALPHA_BIAS = 0x8023,
            POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F,
            POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022,
            CONVOLUTION_FILTER_SCALE = 0x8014,
            POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D,
            SEPARABLE_2D = 0x8012,
            CONVOLUTION_FORMAT = 0x8017,
            POST_CONVOLUTION_BLUE_SCALE = 0x801E,
            CONVOLUTION_BORDER_MODE_EXT = 0x8013,
            POST_CONVOLUTION_GREEN_SCALE = 0x801D,
            POST_CONVOLUTION_RED_SCALE_EXT = 0x801C,
            REDUCE_EXT = 0x8016,
            CONVOLUTION_1D_EXT = 0x8010,
            MAX_CONVOLUTION_WIDTH_EXT = 0x801A,
            CONVOLUTION_FORMAT_EXT = 0x8017,
            POST_CONVOLUTION_BLUE_BIAS = 0x8022,
            CONVOLUTION_HEIGHT = 0x8019,
            SEPARABLE_2D_EXT = 0x8012,
            CONVOLUTION_2D_EXT = 0x8011,
            MAX_CONVOLUTION_WIDTH = 0x801A,
            POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023,
            POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021,
            POST_CONVOLUTION_RED_BIAS_EXT = 0x8020,
            REDUCE = 0x8016,
            MAX_CONVOLUTION_HEIGHT_EXT = 0x801B,
            CONVOLUTION_BORDER_MODE = 0x8013,
            POST_CONVOLUTION_ALPHA_SCALE = 0x801F,
            POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E,
            POST_CONVOLUTION_RED_BIAS = 0x8020,
            CONVOLUTION_FILTER_BIAS_EXT = 0x8015,
            POST_CONVOLUTION_RED_SCALE = 0x801C,
            CONVOLUTION_HEIGHT_EXT = 0x8019,
            MAX_CONVOLUTION_HEIGHT = 0x801B,
            CONVOLUTION_FILTER_BIAS = 0x8015,
            POST_CONVOLUTION_GREEN_BIAS = 0x8021,
        }

        public enum ATI_separate_stencil : uint
        {
            STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802,
            STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803,
            STENCIL_BACK_FAIL_ATI = 0x8801,
            STENCIL_BACK_FUNC_ATI = 0x8800,
        }

        public enum EXT_depth_bounds_test : uint
        {
            DEPTH_BOUNDS_EXT = 0x8891,
            DEPTH_BOUNDS_TEST_EXT = 0x8890,
        }

        public enum MaterialParameter : uint
        {
            EMISSION = 0x1600,
            DIFFUSE = LightParameter.DIFFUSE,
            AMBIENT_AND_DIFFUSE = 0x1602,
            SHININESS = 0x1601,
            SPECULAR = LightParameter.SPECULAR,
            AMBIENT = LightParameter.AMBIENT,
            COLOR_INDEXES = 0x1603,
        }

        public enum EXT_index_texture : uint
        {
        }

        public enum SeparableTargetEXT : uint
        {
            SEPARABLE_2D_EXT = EXT_convolution.SEPARABLE_2D_EXT,
        }

        public enum HP_convolution_border_modes : uint
        {
            IGNORE_BORDER_HP = 0x8150,
            CONVOLUTION_BORDER_COLOR = 0x8154,
            CONVOLUTION_BORDER_COLOR_HP = 0x8154,
            REPLICATE_BORDER_HP = 0x8153,
            CONSTANT_BORDER = 0x8151,
            CONSTANT_BORDER_HP = 0x8151,
            REPLICATE_BORDER = 0x8153,
        }

        public enum ATI_vertex_array_object : uint
        {
            ARRAY_OBJECT_BUFFER_ATI = 0x8766,
            PRESERVE_ATI = 0x8762,
            DISCARD_ATI = 0x8763,
            STATIC_ATI = 0x8760,
            ARRAY_OBJECT_OFFSET_ATI = 0x8767,
            OBJECT_BUFFER_SIZE_ATI = 0x8764,
            OBJECT_BUFFER_USAGE_ATI = 0x8765,
            DYNAMIC_ATI = 0x8761,
        }

        public enum NV_blend_square : uint
        {
        }

        public enum PointParameterNameSGIS : uint
        {
            DISTANCE_ATTENUATION_SGIS = SGIS_point_parameters.DISTANCE_ATTENUATION_SGIS,
            POINT_SIZE_MAX_SGIS = SGIS_point_parameters.POINT_SIZE_MAX_SGIS,
            POINT_FADE_THRESHOLD_SIZE_SGIS = SGIS_point_parameters.POINT_FADE_THRESHOLD_SIZE_SGIS,
            POINT_SIZE_MIN_SGIS = SGIS_point_parameters.POINT_SIZE_MIN_SGIS,
        }

        public enum EXT_texture_mirror_clamp : uint
        {
            MIRROR_CLAMP_TO_BORDER_EXT = 0x8912,
            MIRROR_CLAMP_TO_EDGE_EXT = 0x8743,
            MIRROR_CLAMP_EXT = 0x8742,
        }

        public enum EXT_stencil_two_side : uint
        {
            ACTIVE_STENCIL_FACE_EXT = 0x8911,
            STENCIL_TEST_TWO_SIDE_EXT = 0x8910,
        }

        public enum PixelInternalFormat : uint
        {
            LUMINANCE12_ALPHA12 = 0x8047,
            DUAL_LUMINANCE16_SGIS = SGIS_texture_select.DUAL_LUMINANCE16_SGIS,
            QUAD_LUMINANCE8_SGIS = SGIS_texture_select.QUAD_LUMINANCE8_SGIS,
            RGBA16 = 0x805B,
            ALPHA_ICC_SGIX = SGIX_icc_texture.ALPHA_ICC_SGIX,
            LUMINANCE12 = 0x8041,
            DUAL_ALPHA4_SGIS = SGIS_texture_select.DUAL_ALPHA4_SGIS,
            INTENSITY4 = 0x804A,
            RGBA12 = 0x805A,
            INTENSITY8 = 0x804B,
            DUAL_ALPHA8_SGIS = SGIS_texture_select.DUAL_ALPHA8_SGIS,
            DEPTH_COMPONENT16_SGIX = SGIX_depth_texture.DEPTH_COMPONENT16_SGIX,
            ALPHA16_ICC_SGIX = SGIX_icc_texture.ALPHA16_ICC_SGIX,
            DUAL_INTENSITY12_SGIS = SGIS_texture_select.DUAL_INTENSITY12_SGIS,
            LUMINANCE16 = 0x8042,
            LUMINANCE_ICC_SGIX = SGIX_icc_texture.LUMINANCE_ICC_SGIX,
            DEPTH_COMPONENT24_SGIX = SGIX_depth_texture.DEPTH_COMPONENT24_SGIX,
            INTENSITY = 0x8049,
            QUAD_ALPHA4_SGIS = SGIS_texture_select.QUAD_ALPHA4_SGIS,
            ALPHA12 = 0x803D,
            INTENSITY_ICC_SGIX = SGIX_icc_texture.INTENSITY_ICC_SGIX,
            LUMINANCE4 = 0x803F,
            LUMINANCE_ALPHA_ICC_SGIX = SGIX_icc_texture.LUMINANCE_ALPHA_ICC_SGIX,
            RGB_ICC_SGIX = SGIX_icc_texture.RGB_ICC_SGIX,
            LUMINANCE4_ALPHA4 = 0x8043,
            INTENSITY16_ICC_SGIX = SGIX_icc_texture.INTENSITY16_ICC_SGIX,
            RGBA_ICC_SGIX = SGIX_icc_texture.RGBA_ICC_SGIX,
            DUAL_LUMINANCE12_SGIS = SGIS_texture_select.DUAL_LUMINANCE12_SGIS,
            ALPHA16 = 0x803E,
            DUAL_ALPHA16_SGIS = SGIS_texture_select.DUAL_ALPHA16_SGIS,
            DUAL_ALPHA12_SGIS = SGIS_texture_select.DUAL_ALPHA12_SGIS,
            RGB2_EXT = EXT_texture.RGB2_EXT,
            LUMINANCE8 = 0x8040,
            QUAD_INTENSITY8_SGIS = SGIS_texture_select.QUAD_INTENSITY8_SGIS,
            DUAL_LUMINANCE_ALPHA4_SGIS = SGIS_texture_select.DUAL_LUMINANCE_ALPHA4_SGIS,
            LUMINANCE12_ALPHA4 = 0x8046,
            QUAD_LUMINANCE4_SGIS = SGIS_texture_select.QUAD_LUMINANCE4_SGIS,
            RGB5 = 0x8050,
            DUAL_LUMINANCE_ALPHA8_SGIS = SGIS_texture_select.DUAL_LUMINANCE_ALPHA8_SGIS,
            LUMINANCE8_ALPHA8 = 0x8045,
            DUAL_INTENSITY8_SGIS = SGIS_texture_select.DUAL_INTENSITY8_SGIS,
            RGB8 = 0x8051,
            R5_G6_B5_A8_ICC_SGIX = SGIX_icc_texture.R5_G6_B5_A8_ICC_SGIX,
            QUAD_ALPHA8_SGIS = SGIS_texture_select.QUAD_ALPHA8_SGIS,
            DUAL_INTENSITY4_SGIS = SGIS_texture_select.DUAL_INTENSITY4_SGIS,
            RGB10_A2 = 0x8059,
            INTENSITY12 = 0x804C,
            RGBA4 = 0x8056,
            RGB5_A1 = 0x8057,
            R3_G3_B2 = 0x2A10,
            R5_G6_B5_ICC_SGIX = SGIX_icc_texture.R5_G6_B5_ICC_SGIX,
            RGBA2 = 0x8055,
            DUAL_INTENSITY16_SGIS = SGIS_texture_select.DUAL_INTENSITY16_SGIS,
            QUAD_INTENSITY4_SGIS = SGIS_texture_select.QUAD_INTENSITY4_SGIS,
            DUAL_LUMINANCE8_SGIS = SGIS_texture_select.DUAL_LUMINANCE8_SGIS,
            RGB16 = 0x8054,
            ALPHA4 = 0x803B,
            RGBA8 = 0x8058,
            INTENSITY16 = 0x804D,
            LUMINANCE16_ALPHA8_ICC_SGIX = SGIX_icc_texture.LUMINANCE16_ALPHA8_ICC_SGIX,
            LUMINANCE16_ALPHA16 = 0x8048,
            LUMINANCE16_ICC_SGIX = SGIX_icc_texture.LUMINANCE16_ICC_SGIX,
            ALPHA8 = 0x803C,
            RGB4 = 0x804F,
            DEPTH_COMPONENT32_SGIX = SGIX_depth_texture.DEPTH_COMPONENT32_SGIX,
            RGB10 = 0x8052,
            RGB12 = 0x8053,
            LUMINANCE6_ALPHA2 = 0x8044,
            DUAL_LUMINANCE4_SGIS = SGIS_texture_select.DUAL_LUMINANCE4_SGIS,
        }

        public enum ARB_vertex_blend : uint
        {
            MODELVIEW5_ARB = 0x8725,
            MODELVIEW0_ARB = 0x1700,
            ACTIVE_VERTEX_UNITS_ARB = 0x86A5,
            MODELVIEW6_ARB = 0x8726,
            MODELVIEW4_ARB = 0x8724,
            WEIGHT_ARRAY_ARB = 0x86AD,
            MODELVIEW15_ARB = 0x872F,
            MODELVIEW10_ARB = 0x872A,
            MODELVIEW16_ARB = 0x8730,
            MODELVIEW21_ARB = 0x8735,
            MODELVIEW22_ARB = 0x8736,
            WEIGHT_ARRAY_POINTER_ARB = 0x86AC,
            WEIGHT_SUM_UNITY_ARB = 0x86A6,
            MODELVIEW1_ARB = 0x850A,
            MODELVIEW29_ARB = 0x873D,
            MODELVIEW11_ARB = 0x872B,
            MODELVIEW12_ARB = 0x872C,
            MODELVIEW19_ARB = 0x8733,
            VERTEX_BLEND_ARB = 0x86A7,
            MODELVIEW26_ARB = 0x873A,
            MODELVIEW17_ARB = 0x8731,
            CURRENT_WEIGHT_ARB = 0x86A8,
            MODELVIEW27_ARB = 0x873B,
            MODELVIEW23_ARB = 0x8737,
            WEIGHT_ARRAY_SIZE_ARB = 0x86AB,
            MAX_VERTEX_UNITS_ARB = 0x86A4,
            MODELVIEW7_ARB = 0x8727,
            MODELVIEW13_ARB = 0x872D,
            MODELVIEW28_ARB = 0x873C,
            MODELVIEW25_ARB = 0x8739,
            WEIGHT_ARRAY_TYPE_ARB = 0x86A9,
            MODELVIEW8_ARB = 0x8728,
            WEIGHT_ARRAY_STRIDE_ARB = 0x86AA,
            MODELVIEW18_ARB = 0x8732,
            MODELVIEW9_ARB = 0x8729,
            MODELVIEW24_ARB = 0x8738,
            MODELVIEW14_ARB = 0x872E,
            MODELVIEW20_ARB = 0x8734,
            MODELVIEW31_ARB = 0x873F,
            MODELVIEW30_ARB = 0x873E,
            MODELVIEW2_ARB = 0x8722,
            MODELVIEW3_ARB = 0x8723,
        }

        public enum AttribMask : uint
        {
            POLYGON_BIT = 0x00000008,
            TRANSFORM_BIT = 0x00001000,
            COLOR_BUFFER_BIT = 0x00004000,
            LINE_BIT = 0x00000004,
            POINT_BIT = 0x00000002,
            EVAL_BIT = 0x00010000,
            LIST_BIT = 0x00020000,
            FOG_BIT = 0x00000080,
            HINT_BIT = 0x00008000,
            ENABLE_BIT = 0x00002000,
            STENCIL_BUFFER_BIT = 0x00000400,
            TEXTURE_BIT = 0x00040000,
            ACCUM_BUFFER_BIT = 0x00000200,
            LIGHTING_BIT = 0x00000040,
            CURRENT_BIT = 0x00000001,
            ALL_ATTRIB_BITS = 0xFFFFFFFF,
            DEPTH_BUFFER_BIT = 0x00000100,
            POLYGON_STIPPLE_BIT = 0x00000010,
            SCISSOR_BIT = 0x00080000,
            VIEWPORT_BIT = 0x00000800,
            PIXEL_MODE_BIT = 0x00000020,
        }

        public enum SGIX_pixel_texture : uint
        {
            PIXEL_TEX_GEN_SGIX = 0x8139,
            PIXEL_TEX_GEN_MODE_SGIX = 0x832B,
        }

        public enum SGIX_framezoom : uint
        {
            FRAMEZOOM_FACTOR_SGIX = 0x818C,
            MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D,
            FRAMEZOOM_SGIX = 0x818B,
        }

        public enum TextureGenParameter : uint
        {
            EYE_PLANE = 0x2502,
            OBJECT_LINE_SGIS = SGIS_point_line_texgen.OBJECT_LINE_SGIS,
            EYE_POINT_SGIS = SGIS_point_line_texgen.EYE_POINT_SGIS,
            TEXTURE_GEN_MODE = 0x2500,
            EYE_LINE_SGIS = SGIS_point_line_texgen.EYE_LINE_SGIS,
            OBJECT_POINT_SGIS = SGIS_point_line_texgen.OBJECT_POINT_SGIS,
            OBJECT_PLANE = 0x2501,
        }

        public enum ReadBufferMode : uint
        {
            FRONT_RIGHT = DrawBufferMode.FRONT_RIGHT,
            AUX3 = DrawBufferMode.AUX3,
            AUX1 = DrawBufferMode.AUX1,
            LEFT = DrawBufferMode.LEFT,
            RIGHT = DrawBufferMode.RIGHT,
            BACK_RIGHT = DrawBufferMode.BACK_RIGHT,
            AUX2 = DrawBufferMode.AUX2,
            AUX0 = DrawBufferMode.AUX0,
            FRONT_LEFT = DrawBufferMode.FRONT_LEFT,
            BACK = DrawBufferMode.BACK,
            FRONT = DrawBufferMode.FRONT,
            BACK_LEFT = DrawBufferMode.BACK_LEFT,
        }

        public enum FeedBackToken : uint
        {
            BITMAP_TOKEN = 0x0704,
            LINE_TOKEN = 0x0702,
            PASS_THROUGH_TOKEN = 0x0700,
            LINE_RESET_TOKEN = 0x0707,
            POINT_TOKEN = 0x0701,
            COPY_PIXEL_TOKEN = 0x0706,
            DRAW_PIXEL_TOKEN = 0x0705,
            POLYGON_TOKEN = 0x0703,
        }

        public enum TextureMinFilter : uint
        {
            LINEAR = TextureMagFilter.LINEAR,
            PIXEL_TEX_GEN_Q_FLOOR_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_Q_FLOOR_SGIX,
            FILTER4_SGIS = SGIS_texture_filter4.FILTER4_SGIS,
            PIXEL_TEX_GEN_Q_CEILING_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_Q_CEILING_SGIX,
            NEAREST_CLIPMAP_NEAREST_SGIX = SGIX_clipmap.NEAREST_CLIPMAP_NEAREST_SGIX,
            LINEAR_CLIPMAP_NEAREST_SGIX = SGIX_clipmap.LINEAR_CLIPMAP_NEAREST_SGIX,
            NEAREST_CLIPMAP_LINEAR_SGIX = SGIX_clipmap.NEAREST_CLIPMAP_LINEAR_SGIX,
            NEAREST_MIPMAP_LINEAR = 0x2702,
            NEAREST = TextureMagFilter.NEAREST,
            NEAREST_MIPMAP_NEAREST = 0x2700,
            LINEAR_MIPMAP_NEAREST = 0x2701,
            LINEAR_CLIPMAP_LINEAR_SGIX = SGIX_clipmap.LINEAR_CLIPMAP_LINEAR_SGIX,
            LINEAR_MIPMAP_LINEAR = 0x2703,
            PIXEL_TEX_GEN_Q_ROUND_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_Q_ROUND_SGIX,
        }

        public enum EXT_copy_texture : uint
        {
        }

        public enum ErrorCode : uint
        {
            OUT_OF_MEMORY = 0x0505,
            TEXTURE_TOO_LARGE_EXT = EXT_texture.TEXTURE_TOO_LARGE_EXT,
            STACK_OVERFLOW = 0x0503,
            INVALID_ENUM = 0x0500,
            INVALID_VALUE = 0x0501,
            TABLE_TOO_LARGE_EXT = EXT_histogram.TABLE_TOO_LARGE_EXT,
            INVALID_OPERATION = 0x0502,
            STACK_UNDERFLOW = 0x0504,
            NO_ERROR = 0,
        }

        public enum GetPointervPName : uint
        {
            FEEDBACK_BUFFER_POINTER = 0x0DF0,
            EDGE_FLAG_ARRAY_POINTER = 0x8093,
            TEXTURE_COORD_ARRAY_POINTER = 0x8092,
            INDEX_ARRAY_POINTER = 0x8091,
            INSTRUMENT_BUFFER_POINTER_SGIX = SGIX_instruments.INSTRUMENT_BUFFER_POINTER_SGIX,
            SELECTION_BUFFER_POINTER = 0x0DF3,
            NORMAL_ARRAY_POINTER = 0x808F,
            VERTEX_ARRAY_POINTER = 0x808E,
            COLOR_ARRAY_POINTER = 0x8090,
        }

        public enum BlendingFactorSrc : uint
        {
            ZERO = BlendingFactorDest.ZERO,
            ONE_MINUS_SRC_ALPHA = BlendingFactorDest.ONE_MINUS_SRC_ALPHA,
            ONE_MINUS_DST_COLOR = 0x0307,
            ONE_MINUS_CONSTANT_COLOR_EXT = EXT_blend_color.ONE_MINUS_CONSTANT_COLOR_EXT,
            CONSTANT_COLOR_EXT = EXT_blend_color.CONSTANT_COLOR_EXT,
            DST_ALPHA = BlendingFactorDest.DST_ALPHA,
            CONSTANT_ALPHA_EXT = EXT_blend_color.CONSTANT_ALPHA_EXT,
            SRC_ALPHA = BlendingFactorDest.SRC_ALPHA,
            SRC_ALPHA_SATURATE = 0x0308,
            ONE_MINUS_CONSTANT_ALPHA_EXT = EXT_blend_color.ONE_MINUS_CONSTANT_ALPHA_EXT,
            ONE_MINUS_DST_ALPHA = BlendingFactorDest.ONE_MINUS_DST_ALPHA,
            DST_COLOR = 0x0306,
            ONE = BlendingFactorDest.ONE,
        }

        public enum NV_fragment_program_option : uint
        {
        }

        public enum APPLE_vertex_array_object : uint
        {
            VERTEX_ARRAY_BINDING_APPLE = 0x85B5,
        }

        public enum ATI_fragment_shader : uint
        {
            REG_16_ATI = 0x8931,
            CON_12_ATI = 0x894D,
            REG_14_ATI = 0x892F,
            CON_14_ATI = 0x894F,
            HALF_BIT_ATI = 0x00000008,
            NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973,
            REG_25_ATI = 0x893A,
            REG_10_ATI = 0x892B,
            CON_6_ATI = 0x8947,
            REG_15_ATI = 0x8930,
            REG_2_ATI = 0x8923,
            NUM_FRAGMENT_CONSTANTS_ATI = 0x896F,
            QUARTER_BIT_ATI = 0x00000010,
            REG_19_ATI = 0x8934,
            CON_27_ATI = 0x895C,
            NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971,
            FRAGMENT_SHADER_ATI = 0x8920,
            NUM_PASSES_ATI = 0x8970,
            REG_28_ATI = 0x893D,
            CON_1_ATI = 0x8942,
            REG_3_ATI = 0x8924,
            CON_9_ATI = 0x894A,
            CON_4_ATI = 0x8945,
            CON_18_ATI = 0x8953,
            REG_27_ATI = 0x893C,
            REG_22_ATI = 0x8937,
            REG_21_ATI = 0x8936,
            SWIZZLE_STR_DR_ATI = 0x8978,
            REG_20_ATI = 0x8935,
            CON_21_ATI = 0x8956,
            MUL_ATI = 0x8964,
            SATURATE_BIT_ATI = 0x00000040,
            REG_0_ATI = 0x8921,
            MOV_ATI = 0x8961,
            SWIZZLE_STQ_DQ_ATI = 0x8979,
            SWIZZLE_STQ_ATI = 0x8977,
            SWIZZLE_STR_ATI = 0x8976,
            REG_8_ATI = 0x8929,
            CON_10_ATI = 0x894B,
            CON_7_ATI = 0x8948,
            DOT2_ADD_ATI = 0x896C,
            CON_16_ATI = 0x8951,
            CON_22_ATI = 0x8957,
            REG_31_ATI = 0x8940,
            MAD_ATI = 0x8968,
            COLOR_ALPHA_PAIRING_ATI = 0x8975,
            CON_24_ATI = 0x8959,
            REG_30_ATI = 0x893F,
            CON_13_ATI = 0x894E,
            REG_1_ATI = 0x8922,
            CON_15_ATI = 0x8950,
            REG_18_ATI = 0x8933,
            SECONDARY_INTERPOLATOR_ATI = 0x896D,
            REG_9_ATI = 0x892A,
            BLUE_BIT_ATI = 0x00000004,
            CON_2_ATI = 0x8943,
            LERP_ATI = 0x8969,
            REG_17_ATI = 0x8932,
            _4X_BIT_ATI = 0x00000002,
            REG_12_ATI = 0x892D,
            REG_11_ATI = 0x892C,
            CND0_ATI = 0x896B,
            REG_6_ATI = 0x8927,
            REG_23_ATI = 0x8938,
            CON_29_ATI = 0x895E,
            SWIZZLE_STRQ_DQ_ATI = 0x897B,
            NEGATE_BIT_ATI = 0x00000004,
            CON_31_ATI = 0x8960,
            CON_5_ATI = 0x8946,
            _8X_BIT_ATI = 0x00000004,
            CON_8_ATI = 0x8949,
            COMP_BIT_ATI = 0x00000002,
            REG_26_ATI = 0x893B,
            CON_26_ATI = 0x895B,
            REG_24_ATI = 0x8939,
            BIAS_BIT_ATI = 0x00000008,
            RED_BIT_ATI = 0x00000001,
            CON_28_ATI = 0x895D,
            CND_ATI = 0x896A,
            CON_17_ATI = 0x8952,
            REG_7_ATI = 0x8928,
            CON_19_ATI = 0x8954,
            EIGHTH_BIT_ATI = 0x00000020,
            CON_30_ATI = 0x895F,
            NUM_LOOPBACK_COMPONENTS_ATI = 0x8974,
            REG_4_ATI = 0x8925,
            CON_0_ATI = 0x8941,
            ADD_ATI = 0x8963,
            GREEN_BIT_ATI = 0x00000002,
            DOT3_ATI = 0x8966,
            CON_20_ATI = 0x8955,
            REG_29_ATI = 0x893E,
            CON_11_ATI = 0x894C,
            CON_3_ATI = 0x8944,
            NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972,
            SUB_ATI = 0x8965,
            _2X_BIT_ATI = 0x00000001,
            NUM_FRAGMENT_REGISTERS_ATI = 0x896E,
            REG_13_ATI = 0x892E,
            CON_23_ATI = 0x8958,
            DOT4_ATI = 0x8967,
            SWIZZLE_STRQ_ATI = 0x897A,
            REG_5_ATI = 0x8926,
            CON_25_ATI = 0x895A,
        }

        public enum SGIX_list_priority : uint
        {
            LIST_PRIORITY_SGIX = 0x8182,
        }

        public enum FeedbackType : uint
        {
            _3D_COLOR_TEXTURE = 0x0603,
            _4D_COLOR_TEXTURE = 0x0604,
            _3D_COLOR = 0x0602,
            _2D = 0x0600,
            _3D = 0x0601,
        }

        public enum ARB_point_sprite : uint
        {
            POINT_SPRITE_ARB = 0x8861,
            COORD_REPLACE_ARB = 0x8862,
        }

        public enum S3_s3tc : uint
        {
            RGB4_S3TC = 0x83A1,
            RGBA_S3TC = 0x83A2,
            RGB_S3TC = 0x83A0,
            RGBA4_S3TC = 0x83A3,
        }

        public enum PGI_misc_hints : uint
        {
            FULL_STIPPLE_HINT_PGI = 0x1A219,
            BACK_NORMALS_HINT_PGI = 0x1A223,
            ALLOW_DRAW_MEM_HINT_PGI = 0x1A211,
            ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F,
            ALWAYS_FAST_HINT_PGI = 0x1A20C,
            NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202,
            CONSERVE_MEMORY_HINT_PGI = 0x1A1FD,
            PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8,
            STRICT_LIGHTING_HINT_PGI = 0x1A217,
            CLIP_FAR_HINT_PGI = 0x1A221,
            CLIP_NEAR_HINT_PGI = 0x1A220,
            STRICT_SCISSOR_HINT_PGI = 0x1A218,
            ALLOW_DRAW_FRG_HINT_PGI = 0x1A210,
            ALWAYS_SOFT_HINT_PGI = 0x1A20D,
            NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203,
            ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E,
            NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204,
            RECLAIM_MEMORY_HINT_PGI = 0x1A1FE,
            STRICT_DEPTHFUNC_HINT_PGI = 0x1A216,
            WIDE_LINE_HINT_PGI = 0x1A222,
        }

        public enum SGIS_pixel_texture : uint
        {
            PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354,
            PIXEL_TEXTURE_SGIS = 0x8353,
            PIXEL_GROUP_COLOR_SGIS = 0x8356,
            PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355,
        }

        public enum APPLE_ycbcr_422 : uint
        {
            UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB,
            YCBCR_422_APPLE = 0x85B9,
            UNSIGNED_SHORT_8_8_APPLE = 0x85BA,
        }

        public enum ARB_vertex_shader : uint
        {
            MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D,
            VERTEX_SHADER_ARB = 0x8B31,
            OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89,
            MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C,
            MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A,
            MAX_VARYING_FLOATS_ARB = 0x8B4B,
            OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A,
        }

        public enum EXT_shadow_funcs : uint
        {
        }

        public enum ARB_texture_rectangle : uint
        {
            TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6,
            TEXTURE_RECTANGLE_ARB = 0x84F5,
            MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8,
            PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7,
        }

        public enum SGIS_texture_lod : uint
        {
            TEXTURE_MAX_LOD_SGIS = 0x813B,
            TEXTURE_MAX_LEVEL = 0x813D,
            TEXTURE_BASE_LEVEL_SGIS = 0x813C,
            TEXTURE_MIN_LOD_SGIS = 0x813A,
            TEXTURE_MIN_LOD = 0x813A,
            TEXTURE_MAX_LOD = 0x813B,
            TEXTURE_BASE_LEVEL = 0x813C,
            TEXTURE_MAX_LEVEL_SGIS = 0x813D,
        }

        public enum SGIX_depth_texture : uint
        {
            DEPTH_COMPONENT16_SGIX = 0x81A5,
            DEPTH_COMPONENT32_SGIX = 0x81A7,
            DEPTH_COMPONENT16 = 0x81A5,
            DEPTH_COMPONENT24 = 0x81A6,
            DEPTH_COMPONENT24_SGIX = 0x81A6,
            DEPTH_COMPONENT32 = 0x81A7,
        }

        public enum EXT_texture_perturb_normal : uint
        {
            TEXTURE_NORMAL_EXT = 0x85AF,
            PERTURB_EXT = 0x85AE,
        }

        public enum INGR_interlace_read : uint
        {
            INTERLACE_READ_INGR = 0x8568,
        }

        public enum Boolean : uint
        {
            TRUE = 1,
            FALSE = 0,
        }

        public enum SGIX_reference_plane : uint
        {
            REFERENCE_PLANE_EQUATION_SGIX = 0x817E,
            REFERENCE_PLANE_SGIX = 0x817D,
        }

        public enum StencilOp : uint
        {
            REPLACE = 0x1E01,
            DECR = 0x1E03,
            INVERT = LogicOp.INVERT,
            INCR = 0x1E02,
            KEEP = 0x1E00,
            ZERO = BlendingFactorDest.ZERO,
        }

        public enum ARB_occlusion_query : uint
        {
            QUERY_RESULT_ARB = 0x8866,
            CURRENT_QUERY_ARB = 0x8865,
            QUERY_RESULT_AVAILABLE_ARB = 0x8867,
            SAMPLES_PASSED_ARB = 0x8914,
            QUERY_COUNTER_BITS_ARB = 0x8864,
        }

        public enum EXT_multisample : uint
        {
            SAMPLE_MASK_EXT = 0x80A0,
            MULTISAMPLE_EXT = 0x809D,
            _4PASS_3_EXT = 0x80A7,
            _4PASS_2_EXT = 0x80A6,
            SAMPLE_PATTERN_EXT = 0x80AC,
            SAMPLE_ALPHA_TO_MASK_EXT = 0x809E,
            _2PASS_1_EXT = 0x80A3,
            SAMPLES_EXT = 0x80A9,
            SAMPLE_MASK_INVERT_EXT = 0x80AB,
            SAMPLE_BUFFERS_EXT = 0x80A8,
            MULTISAMPLE_BIT_EXT = 0x20000000,
            _4PASS_1_EXT = 0x80A5,
            SAMPLE_MASK_VALUE_EXT = 0x80AA,
            _2PASS_0_EXT = 0x80A2,
            _1PASS_EXT = 0x80A1,
            _4PASS_0_EXT = 0x80A4,
            SAMPLE_ALPHA_TO_ONE_EXT = 0x809F,
        }

        public enum HP_texture_lighting : uint
        {
            TEXTURE_LIGHTING_MODE_HP = 0x8167,
            TEXTURE_PRE_SPECULAR_HP = 0x8169,
            TEXTURE_POST_SPECULAR_HP = 0x8168,
        }

        public enum SGIS_texture4D : uint
        {
            TEXTURE_4D_BINDING_SGIS = 0x814F,
            PACK_IMAGE_DEPTH_SGIS = 0x8131,
            MAX_4D_TEXTURE_SIZE_SGIS = 0x8138,
            PACK_SKIP_VOLUMES_SGIS = 0x8130,
            TEXTURE_4D_SGIS = 0x8134,
            PROXY_TEXTURE_4D_SGIS = 0x8135,
            UNPACK_IMAGE_DEPTH_SGIS = 0x8133,
            UNPACK_SKIP_VOLUMES_SGIS = 0x8132,
            TEXTURE_4DSIZE_SGIS = 0x8136,
            TEXTURE_WRAP_Q_SGIS = 0x8137,
        }

        public enum ColorPointerType : uint
        {
            UNSIGNED_INT = DataType.UNSIGNED_INT,
            FLOAT = DataType.FLOAT,
            UNSIGNED_SHORT = DataType.UNSIGNED_SHORT,
            SHORT = DataType.SHORT,
            BYTE = DataType.BYTE,
            INT = DataType.INT,
            UNSIGNED_BYTE = DataType.UNSIGNED_BYTE,
            DOUBLE = DataType.DOUBLE,
        }

        public enum VertexPointerType : uint
        {
            DOUBLE = DataType.DOUBLE,
            INT = DataType.INT,
            SHORT = DataType.SHORT,
            FLOAT = DataType.FLOAT,
        }

        public enum EXT_shared_texture_palette : uint
        {
            SHARED_TEXTURE_PALETTE_EXT = 0x81FB,
        }

        public enum ARB_color_buffer_float : uint
        {
            CLAMP_READ_COLOR_ARB = 0x891C,
            CLAMP_FRAGMENT_COLOR_ARB = 0x891B,
            FIXED_ONLY_ARB = 0x891D,
            CLAMP_VERTEX_COLOR_ARB = 0x891A,
            RGBA_FLOAT_MODE_ARB = 0x8820,
        }

        public enum PixelTexGenParameterNameSGIS : uint
        {
            PIXEL_FRAGMENT_RGB_SOURCE_SGIS = SGIS_pixel_texture.PIXEL_FRAGMENT_RGB_SOURCE_SGIS,
            PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = SGIS_pixel_texture.PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS,
        }

        public enum EXT_blend_equation_separate : uint
        {
            BLEND_EQUATION_RGB_EXT = GL_BLEND_EQUATION,
            BLEND_EQUATION_ALPHA_EXT = 0x883D,
        }

        public enum PixelStoreResampleMode : uint
        {
            RESAMPLE_DECIMATE_SGIX = SGIX_resample.RESAMPLE_DECIMATE_SGIX,
            RESAMPLE_REPLICATE_SGIX = SGIX_resample.RESAMPLE_REPLICATE_SGIX,
            RESAMPLE_ZERO_FILL_SGIX = SGIX_resample.RESAMPLE_ZERO_FILL_SGIX,
        }

        public enum SGIX_fragment_lighting : uint
        {
            FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402,
            FRAGMENT_LIGHT1_SGIX = 0x840D,
            LIGHT_ENV_MODE_SGIX = 0x8407,
            FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408,
            CURRENT_RASTER_NORMAL_SGIX = 0x8406,
            FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403,
            FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B,
            MAX_FRAGMENT_LIGHTS_SGIX = 0x8404,
            FRAGMENT_LIGHT4_SGIX = 0x8410,
            FRAGMENT_LIGHT5_SGIX = 0x8411,
            FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A,
            FRAGMENT_LIGHTING_SGIX = 0x8400,
            FRAGMENT_LIGHT6_SGIX = 0x8412,
            MAX_ACTIVE_LIGHTS_SGIX = 0x8405,
            FRAGMENT_LIGHT2_SGIX = 0x840E,
            FRAGMENT_LIGHT0_SGIX = 0x840C,
            FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401,
            FRAGMENT_LIGHT3_SGIX = 0x840F,
            FRAGMENT_LIGHT7_SGIX = 0x8413,
            FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409,
        }

        public enum NV_depth_clamp : uint
        {
            DEPTH_CLAMP_NV = 0x864F,
        }

        public enum EXT_blend_subtract : uint
        {
            FUNC_SUBTRACT = 0x800A,
            FUNC_REVERSE_SUBTRACT = 0x800B,
            FUNC_REVERSE_SUBTRACT_EXT = 0x800B,
            FUNC_SUBTRACT_EXT = 0x800A,
        }

        public enum ARB_vertex_program : uint
        {
            VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A,
            MATRIX9_ARB = 0x88C9,
            MATRIX24_ARB = 0x88D8,
            MATRIX25_ARB = 0x88D9,
            TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7,
            MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB,
            MATRIX22_ARB = 0x88D6,
            MAX_PROGRAM_MATRICES_ARB = 0x862F,
            PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA,
            PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2,
            MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3,
            PROGRAM_FORMAT_ARB = 0x8876,
            MATRIX8_ARB = 0x88C8,
            MAX_PROGRAM_PARAMETERS_ARB = 0x88A9,
            MATRIX13_ARB = 0x88CD,
            MATRIX31_ARB = 0x88DF,
            MATRIX6_ARB = 0x88C6,
            MATRIX27_ARB = 0x88DB,
            MATRIX7_ARB = 0x88C7,
            PROGRAM_ERROR_STRING_ARB = 0x8874,
            PROGRAM_PARAMETERS_ARB = 0x88A8,
            PROGRAM_BINDING_ARB = 0x8677,
            VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642,
            PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6,
            CURRENT_VERTEX_ATTRIB_ARB = 0x8626,
            MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4,
            MATRIX12_ARB = 0x88CC,
            PROGRAM_STRING_ARB = 0x8628,
            PROGRAM_INSTRUCTIONS_ARB = 0x88A0,
            MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5,
            VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623,
            MATRIX26_ARB = 0x88DA,
            MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3,
            MATRIX4_ARB = 0x88C4,
            CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640,
            VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643,
            VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625,
            PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0,
            MATRIX2_ARB = 0x88C2,
            MATRIX5_ARB = 0x88C5,
            PROGRAM_ATTRIBS_ARB = 0x88AC,
            MATRIX14_ARB = 0x88CE,
            VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624,
            MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1,
            MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E,
            MATRIX3_ARB = 0x88C3,
            PROGRAM_TEMPORARIES_ARB = 0x88A4,
            MATRIX28_ARB = 0x88DC,
            MATRIX29_ARB = 0x88DD,
            MAX_VERTEX_ATTRIBS_ARB = 0x8869,
            MATRIX20_ARB = 0x88D4,
            MATRIX21_ARB = 0x88D5,
            MAX_PROGRAM_ATTRIBS_ARB = 0x88AD,
            PROGRAM_ERROR_POSITION_ARB = 0x864B,
            PROGRAM_FORMAT_ASCII_ARB = 0x8875,
            MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5,
            PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2,
            VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622,
            VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645,
            MATRIX30_ARB = 0x88DE,
            MATRIX15_ARB = 0x88CF,
            VERTEX_PROGRAM_ARB = 0x8620,
            MATRIX0_ARB = 0x88C0,
            MATRIX17_ARB = 0x88D1,
            PROGRAM_LENGTH_ARB = 0x8627,
            COLOR_SUM_ARB = 0x8458,
            MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF,
            MATRIX1_ARB = 0x88C1,
            PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6,
            MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1,
            MATRIX23_ARB = 0x88D7,
            MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7,
            PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE,
            CURRENT_MATRIX_ARB = 0x8641,
            MATRIX18_ARB = 0x88D2,
            MATRIX19_ARB = 0x88D3,
            MATRIX10_ARB = 0x88CA,
            MATRIX11_ARB = 0x88CB,
            MATRIX16_ARB = 0x88D0,
        }

        public enum SUN_vertex : uint
        {
        }

        public enum SGIX_scalebias_hint : uint
        {
            SCALEBIAS_HINT_SGIX = 0x8322,
        }

        public enum ListNameType : uint
        {
            UNSIGNED_INT = DataType.UNSIGNED_INT,
            _4_BYTES = DataType._4_BYTES,
            FLOAT = DataType.FLOAT,
            UNSIGNED_SHORT = DataType.UNSIGNED_SHORT,
            SHORT = DataType.SHORT,
            BYTE = DataType.BYTE,
            _3_BYTES = DataType._3_BYTES,
            INT = DataType.INT,
            UNSIGNED_BYTE = DataType.UNSIGNED_BYTE,
            _2_BYTES = DataType._2_BYTES,
        }

        public enum RenderingMode : uint
        {
            SELECT = 0x1C02,
            FEEDBACK = 0x1C01,
            RENDER = 0x1C00,
        }

        public enum EXT_texture_lod_bias : uint
        {
            MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD,
            TEXTURE_FILTER_CONTROL_EXT = 0x8500,
            TEXTURE_LOD_BIAS_EXT = 0x8501,
        }

        public enum EXT_paletted_texture : uint
        {
            COLOR_INDEX1_EXT = 0x80E2,
            TEXTURE_INDEX_SIZE_EXT = 0x80ED,
            COLOR_INDEX8_EXT = 0x80E5,
            COLOR_INDEX4_EXT = 0x80E4,
            COLOR_INDEX12_EXT = 0x80E6,
            COLOR_INDEX2_EXT = 0x80E3,
            COLOR_INDEX16_EXT = 0x80E7,
        }

        public enum ARB_depth_texture : uint
        {
            DEPTH_TEXTURE_MODE_ARB = 0x884B,
            DEPTH_COMPONENT16_ARB = 0x81A5,
            DEPTH_COMPONENT24_ARB = 0x81A6,
            DEPTH_COMPONENT32_ARB = 0x81A7,
            TEXTURE_DEPTH_SIZE_ARB = 0x884A,
        }

        public enum ARB_multisample : uint
        {
            SAMPLE_COVERAGE_VALUE_ARB = 0x80AA,
            SAMPLES_ARB = 0x80A9,
            SAMPLE_BUFFERS = 0x80A8,
            SAMPLE_COVERAGE = 0x80A0,
            MULTISAMPLE_ARB = 0x809D,
            SAMPLE_ALPHA_TO_COVERAGE = 0x809E,
            SAMPLE_BUFFERS_ARB = 0x80A8,
            SAMPLE_COVERAGE_ARB = 0x80A0,
            SAMPLE_COVERAGE_INVERT_ARB = 0x80AB,
            SAMPLE_COVERAGE_INVERT = 0x80AB,
            MULTISAMPLE = 0x809D,
            SAMPLE_ALPHA_TO_ONE_ARB = 0x809F,
            SAMPLE_ALPHA_TO_ONE = 0x809F,
            SAMPLES = 0x80A9,
            SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E,
            MULTISAMPLE_BIT_ARB = 0x20000000,
            SAMPLE_COVERAGE_VALUE = 0x80AA,
        }

        public enum ConvolutionTargetEXT : uint
        {
            CONVOLUTION_1D_EXT = EXT_convolution.CONVOLUTION_1D_EXT,
            CONVOLUTION_2D_EXT = EXT_convolution.CONVOLUTION_2D_EXT,
        }

        public enum EXT_stencil_wrap : uint
        {
            DECR_WRAP_EXT = 0x8508,
            INCR_WRAP_EXT = 0x8507,
        }

        public enum SGIS_fog_function : uint
        {
            FOG_FUNC_POINTS_SGIS = 0x812B,
            MAX_FOG_FUNC_POINTS_SGIS = 0x812C,
            FOG_FUNC_SGIS = 0x812A,
        }

        public enum SGIX_convolution_accuracy : uint
        {
            CONVOLUTION_HINT_SGIX = 0x8316,
        }

        public enum TextureGenMode : uint
        {
            EYE_DISTANCE_TO_LINE_SGIS = SGIS_point_line_texgen.EYE_DISTANCE_TO_LINE_SGIS,
            EYE_DISTANCE_TO_POINT_SGIS = SGIS_point_line_texgen.EYE_DISTANCE_TO_POINT_SGIS,
            OBJECT_LINEAR = 0x2401,
            OBJECT_DISTANCE_TO_LINE_SGIS = SGIS_point_line_texgen.OBJECT_DISTANCE_TO_LINE_SGIS,
            OBJECT_DISTANCE_TO_POINT_SGIS = SGIS_point_line_texgen.OBJECT_DISTANCE_TO_POINT_SGIS,
            EYE_LINEAR = 0x2400,
            SPHERE_MAP = 0x2402,
        }

        public enum APPLE_client_storage : uint
        {
            UNPACK_CLIENT_STORAGE_APPLE = 0x85B2,
        }

        public enum SUN_slice_accum : uint
        {
            SLICE_ACCUM_SUN = 0x85CC,
        }

        public enum SGIX_polynomial_ffd : uint
        {
            MAX_DEFORMATION_ORDER_SGIX = 0x8197,
            GEOMETRY_DEFORMATION_SGIX = 0x8194,
            TEXTURE_DEFORMATION_SGIX = 0x8195,
            DEFORMATIONS_MASK_SGIX = 0x8196,
        }

        public enum ARB_point_parameters : uint
        {
            POINT_DISTANCE_ATTENUATION_ARB = 0x8129,
            POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128,
            POINT_SIZE_MIN_ARB = 0x8126,
            POINT_SIZE_MAX_ARB = 0x8127,
        }

        public enum ATI_map_object_buffer : uint
        {
        }

        public enum OES_read_format : uint
        {
            IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A,
            IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B,
        }

        public enum GetPName : uint
        {
            FRAGMENT_COLOR_MATERIAL_FACE_SGIX = SGIX_fragment_lighting.FRAGMENT_COLOR_MATERIAL_FACE_SGIX,
            POLYGON_MODE = 0x0B40,
            STENCIL_FUNC = 0x0B92,
            FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX,
            HISTOGRAM_EXT = EXT_histogram.HISTOGRAM_EXT,
            CULL_FACE_MODE = 0x0B45,
            PACK_RESAMPLE_SGIX = SGIX_resample.PACK_RESAMPLE_SGIX,
            POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = SGIX_texture_scale_bias.POST_TEXTURE_FILTER_BIAS_RANGE_SGIX,
            CURRENT_RASTER_DISTANCE = 0x0B09,
            PIXEL_TILE_BEST_ALIGNMENT_SGIX = SGIX_pixel_tiles.PIXEL_TILE_BEST_ALIGNMENT_SGIX,
            POINT_SIZE = 0x0B11,
            MODELVIEW_STACK_DEPTH = 0x0BA3,
            TEXTURE_COLOR_TABLE_SGI = SGI_texture_color_table.TEXTURE_COLOR_TABLE_SGI,
            SAMPLE_ALPHA_TO_ONE_SGIS = SGIS_multisample.SAMPLE_ALPHA_TO_ONE_SGIS,
            PIXEL_MAP_I_TO_R_SIZE = 0x0CB2,
            ALPHA_BIAS = 0x0D1D,
            MAP1_GRID_DOMAIN = 0x0DD0,
            PACK_CMYK_HINT_EXT = EXT_cmyka.PACK_CMYK_HINT_EXT,
            MAP2_VERTEX_4 = 0x0DB8,
            POST_CONVOLUTION_ALPHA_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_ALPHA_SCALE_EXT,
            MAP2_VERTEX_3 = 0x0DB7,
            DEPTH_RANGE = 0x0B70,
            POST_COLOR_MATRIX_BLUE_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_BLUE_SCALE_SGI,
            MAX_ASYNC_DRAW_PIXELS_SGIX = SGIX_async_pixel.MAX_ASYNC_DRAW_PIXELS_SGIX,
            PIXEL_MAP_I_TO_I_SIZE = 0x0CB0,
            UNPACK_SUBSAMPLE_RATE_SGIX = SGIX_subsample.UNPACK_SUBSAMPLE_RATE_SGIX,
            CURRENT_RASTER_INDEX = 0x0B05,
            LIGHT3 = LightName.LIGHT3,
            UNPACK_IMAGE_HEIGHT_EXT = EXT_texture3D.UNPACK_IMAGE_HEIGHT_EXT,
            INDEX_ARRAY_COUNT_EXT = EXT_vertex_array.INDEX_ARRAY_COUNT_EXT,
            LIST_INDEX = 0x0B33,
            FOG_OFFSET_VALUE_SGIX = SGIX_fog_offset.FOG_OFFSET_VALUE_SGIX,
            DEPTH_CLEAR_VALUE = 0x0B73,
            CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1,
            DETAIL_TEXTURE_2D_BINDING_SGIS = SGIS_detail_texture.DETAIL_TEXTURE_2D_BINDING_SGIS,
            STENCIL_VALUE_MASK = 0x0B93,
            GREEN_BITS = 0x0D53,
            COLOR_MATRIX_STACK_DEPTH_SGI = SGI_color_matrix.COLOR_MATRIX_STACK_DEPTH_SGI,
            POST_CONVOLUTION_GREEN_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_GREEN_BIAS_EXT,
            FOG_END = 0x0B64,
            CLIP_PLANE0 = ClipPlaneName.CLIP_PLANE0,
            MAX_MODELVIEW_STACK_DEPTH = 0x0D36,
            LINE_SMOOTH_HINT = 0x0C52,
            POLYGON_OFFSET_FACTOR = 0x8038,
            MULTISAMPLE_SGIS = SGIS_multisample.MULTISAMPLE_SGIS,
            FOG_MODE = 0x0B65,
            POST_CONVOLUTION_RED_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_RED_SCALE_EXT,
            PACK_IMAGE_DEPTH_SGIS = SGIS_texture4D.PACK_IMAGE_DEPTH_SGIS,
            LIST_BASE = 0x0B32,
            TEXTURE_STACK_DEPTH = 0x0BA5,
            SCISSOR_TEST = 0x0C11,
            CURRENT_NORMAL = 0x0B02,
            CALLIGRAPHIC_FRAGMENT_SGIX = SGIX_calligraphic_fragment.CALLIGRAPHIC_FRAGMENT_SGIX,
            PIXEL_MAP_B_TO_B_SIZE = 0x0CB8,
            INTERLACE_SGIX = SGIX_interlace.INTERLACE_SGIX,
            EDGE_FLAG_ARRAY = 0x8079,
            MAP1_COLOR_4 = 0x0D90,
            TEXTURE_MATRIX = 0x0BA8,
            LIGHT4 = LightName.LIGHT4,
            MAX_3D_TEXTURE_SIZE_EXT = EXT_texture3D.MAX_3D_TEXTURE_SIZE_EXT,
            PIXEL_MAP_G_TO_G_SIZE = 0x0CB7,
            SELECTION_BUFFER_SIZE = 0x0DF4,
            MAP2_TEXTURE_COORD_3 = 0x0DB5,
            SPRITE_SGIX = SGIX_sprite.SPRITE_SGIX,
            ASYNC_READ_PIXELS_SGIX = SGIX_async_pixel.ASYNC_READ_PIXELS_SGIX,
            MAX_FRAGMENT_LIGHTS_SGIX = SGIX_fragment_lighting.MAX_FRAGMENT_LIGHTS_SGIX,
            PIXEL_TILE_GRID_WIDTH_SGIX = SGIX_pixel_tiles.PIXEL_TILE_GRID_WIDTH_SGIX,
            LIGHT_MODEL_AMBIENT = 0x0B53,
            PIXEL_TEX_GEN_SGIX = SGIX_pixel_texture.PIXEL_TEX_GEN_SGIX,
            ZOOM_X = 0x0D16,
            PACK_SKIP_VOLUMES_SGIS = SGIS_texture4D.PACK_SKIP_VOLUMES_SGIS,
            CLIP_PLANE3 = ClipPlaneName.CLIP_PLANE3,
            COLOR_MATERIAL_FACE = 0x0B55,
            SHARED_TEXTURE_PALETTE_EXT = EXT_shared_texture_palette.SHARED_TEXTURE_PALETTE_EXT,
            SMOOTH_POINT_SIZE_RANGE = VERSION_1_2.SMOOTH_POINT_SIZE_RANGE,
            ATTRIB_STACK_DEPTH = 0x0BB0,
            MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B,
            MAP1_GRID_SEGMENTS = 0x0DD1,
            FRAGMENT_LIGHT0_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT0_SGIX,
            BLUE_SCALE = 0x0D1A,
            POINT_SMOOTH = 0x0B10,
            MAX_PROJECTION_STACK_DEPTH = 0x0D38,
            INDEX_WRITEMASK = 0x0C21,
            TEXTURE_BINDING_3D = 0x806A,
            MAP1_TEXTURE_COORD_4 = 0x0D96,
            TEXTURE_BINDING_1D = 0x8068,
            UNPACK_SKIP_IMAGES_EXT = EXT_texture3D.UNPACK_SKIP_IMAGES_EXT,
            GENERATE_MIPMAP_HINT_SGIS = SGIS_generate_mipmap.GENERATE_MIPMAP_HINT_SGIS,
            POST_COLOR_MATRIX_RED_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_RED_BIAS_SGI,
            NORMAL_ARRAY_STRIDE = 0x807F,
            FOG = 0x0B60,
            CURRENT_RASTER_POSITION_VALID = 0x0B08,
            COLOR_ARRAY_TYPE = 0x8082,
            POST_COLOR_MATRIX_GREEN_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_GREEN_BIAS_SGI,
            CLIP_PLANE5 = ClipPlaneName.CLIP_PLANE5,
            PACK_SKIP_PIXELS = 0x0D04,
            ALPHA_SCALE = 0x0D1C,
            SAMPLE_MASK_SGIS = SGIS_multisample.SAMPLE_MASK_SGIS,
            STEREO = 0x0C33,
            READ_BUFFER = 0x0C02,
            MAX_4D_TEXTURE_SIZE_SGIS = SGIS_texture4D.MAX_4D_TEXTURE_SIZE_SGIS,
            RENDER_MODE = 0x0C40,
            POINT_SIZE_RANGE = 0x0B12,
            LIST_MODE = 0x0B30,
            FOG_OFFSET_SGIX = SGIX_fog_offset.FOG_OFFSET_SGIX,
            LIGHTING = 0x0B50,
            ACCUM_CLEAR_VALUE = 0x0B80,
            UNPACK_RESAMPLE_SGIX = SGIX_resample.UNPACK_RESAMPLE_SGIX,
            TEXTURE_GEN_Q = 0x0C63,
            MAP2_TEXTURE_COORD_2 = 0x0DB4,
            TEXTURE_GEN_T = 0x0C61,
            ALIASED_LINE_WIDTH_RANGE = VERSION_1_2.ALIASED_LINE_WIDTH_RANGE,
            RED_BITS = 0x0D52,
            COLOR_TABLE_SGI = SGI_color_table.COLOR_TABLE_SGI,
            SCISSOR_BOX = 0x0C10,
            PIXEL_TILE_GRID_DEPTH_SGIX = SGIX_pixel_tiles.PIXEL_TILE_GRID_DEPTH_SGIX,
            INDEX_ARRAY_TYPE = 0x8085,
            LIGHT6 = LightName.LIGHT6,
            MAX_COLOR_MATRIX_STACK_DEPTH_SGI = SGI_color_matrix.MAX_COLOR_MATRIX_STACK_DEPTH_SGI,
            SAMPLES_SGIS = SGIS_multisample.SAMPLES_SGIS,
            BLEND = 0x0BE2,
            STENCIL_CLEAR_VALUE = 0x0B91,
            FEEDBACK_BUFFER_SIZE = 0x0DF1,
            SEPARABLE_2D_EXT = EXT_convolution.SEPARABLE_2D_EXT,
            LINE_STIPPLE_REPEAT = 0x0B26,
            INDEX_MODE = 0x0C30,
            TEXTURE_COORD_ARRAY_STRIDE = 0x808A,
            SMOOTH_LINE_WIDTH_RANGE = VERSION_1_2.SMOOTH_LINE_WIDTH_RANGE,
            STENCIL_REF = 0x0B97,
            SMOOTH_POINT_SIZE_GRANULARITY = VERSION_1_2.SMOOTH_POINT_SIZE_GRANULARITY,
            BLUE_BITS = 0x0D54,
            FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = SGIX_fragment_lighting.FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX,
            COLOR_LOGIC_OP = 0x0BF2,
            POST_CONVOLUTION_COLOR_TABLE_SGI = SGI_color_table.POST_CONVOLUTION_COLOR_TABLE_SGI,
            BLEND_COLOR_EXT = EXT_blend_color.BLEND_COLOR_EXT,
            PIXEL_TEXTURE_SGIS = SGIS_pixel_texture.PIXEL_TEXTURE_SGIS,
            MAX_FRAMEZOOM_FACTOR_SGIX = SGIX_framezoom.MAX_FRAMEZOOM_FACTOR_SGIX,
            MATRIX_MODE = 0x0BA0,
            DEPTH_FUNC = 0x0B74,
            POST_COLOR_MATRIX_RED_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_RED_SCALE_SGI,
            PACK_SUBSAMPLE_RATE_SGIX = SGIX_subsample.PACK_SUBSAMPLE_RATE_SGIX,
            FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX,
            ACCUM_RED_BITS = 0x0D58,
            POLYGON_OFFSET_UNITS = 0x2A00,
            TEXTURE_2D = 0x0DE1,
            EDGE_FLAG_ARRAY_COUNT_EXT = EXT_vertex_array.EDGE_FLAG_ARRAY_COUNT_EXT,
            TEXTURE_COORD_ARRAY_TYPE = 0x8089,
            CURRENT_INDEX = 0x0B01,
            PACK_SWAP_BYTES = 0x0D00,
            INDEX_ARRAY = 0x8077,
            GREEN_BIAS = 0x0D19,
            SAMPLE_MASK_INVERT_SGIS = SGIS_multisample.SAMPLE_MASK_INVERT_SGIS,
            AUTO_NORMAL = 0x0D80,
            POINT_SIZE_GRANULARITY = 0x0B13,
            POLYGON_SMOOTH = 0x0B41,
            FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX,
            ALPHA_BITS = 0x0D55,
            UNPACK_ALIGNMENT = 0x0CF5,
            SAMPLE_PATTERN_SGIS = SGIS_multisample.SAMPLE_PATTERN_SGIS,
            INDEX_ARRAY_STRIDE = 0x8086,
            POLYGON_OFFSET_BIAS_EXT = EXT_polygon_offset.POLYGON_OFFSET_BIAS_EXT,
            RED_SCALE = 0x0D14,
            UNPACK_SKIP_ROWS = 0x0CF3,
            INDEX_LOGIC_OP = 0x0BF1,
            MAP2_COLOR_4 = 0x0DB0,
            VERTEX_ARRAY_COUNT_EXT = EXT_vertex_array.VERTEX_ARRAY_COUNT_EXT,
            MAP1_NORMAL = 0x0D92,
            MAP1_TEXTURE_COORD_2 = 0x0D94,
            PIXEL_MAP_I_TO_G_SIZE = 0x0CB3,
            ACCUM_BLUE_BITS = 0x0D5A,
            ASYNC_DRAW_PIXELS_SGIX = SGIX_async_pixel.ASYNC_DRAW_PIXELS_SGIX,
            COLOR_WRITEMASK = 0x0C23,
            NAME_STACK_DEPTH = 0x0D70,
            POST_CONVOLUTION_BLUE_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_BLUE_BIAS_EXT,
            MAX_NAME_STACK_DEPTH = 0x0D37,
            CLIP_PLANE4 = ClipPlaneName.CLIP_PLANE4,
            FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX,
            PIXEL_MAP_I_TO_A_SIZE = 0x0CB5,
            PACK_SKIP_IMAGES_EXT = EXT_texture3D.PACK_SKIP_IMAGES_EXT,
            LIGHT0 = LightName.LIGHT0,
            PIXEL_MAP_R_TO_R_SIZE = 0x0CB6,
            FOG_HINT = 0x0C54,
            PROJECTION_STACK_DEPTH = 0x0BA4,
            PIXEL_TILE_CACHE_SIZE_SGIX = SGIX_pixel_tiles.PIXEL_TILE_CACHE_SIZE_SGIX,
            RESCALE_NORMAL_EXT = EXT_rescale_normal.RESCALE_NORMAL_EXT,
            MAP2_GRID_DOMAIN = 0x0DD2,
            ALPHA_TEST_FUNC = 0x0BC1,
            MAX_CLIPMAP_DEPTH_SGIX = SGIX_clipmap.MAX_CLIPMAP_DEPTH_SGIX,
            UNPACK_SKIP_PIXELS = 0x0CF4,
            NORMAL_ARRAY_TYPE = 0x807E,
            FOG_FUNC_POINTS_SGIS = SGIS_fog_function.FOG_FUNC_POINTS_SGIS,
            GREEN_SCALE = 0x0D18,
            PACK_ROW_LENGTH = 0x0D02,
            CURRENT_COLOR = 0x0B00,
            MAX_FOG_FUNC_POINTS_SGIS = SGIS_fog_function.MAX_FOG_FUNC_POINTS_SGIS,
            POST_CONVOLUTION_BLUE_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_BLUE_SCALE_EXT,
            COLOR_ARRAY_SIZE = 0x8081,
            MAP2_TEXTURE_COORD_4 = 0x0DB6,
            COLOR_MATERIAL_PARAMETER = 0x0B56,
            FOG_DENSITY = 0x0B62,
            FOG_START = 0x0B63,
            FRONT_FACE = 0x0B46,
            POST_COLOR_MATRIX_ALPHA_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_ALPHA_SCALE_SGI,
            SPRITE_AXIS_SGIX = SGIX_sprite.SPRITE_AXIS_SGIX,
            UNPACK_SKIP_VOLUMES_SGIS = SGIS_texture4D.UNPACK_SKIP_VOLUMES_SGIS,
            MAP1_VERTEX_4 = 0x0D98,
            ASYNC_TEX_IMAGE_SGIX = SGIX_async_pixel.ASYNC_TEX_IMAGE_SGIX,
            LIGHT5 = LightName.LIGHT5,
            MAP1_VERTEX_3 = 0x0D97,
            AUX_BUFFERS = 0x0C00,
            UNPACK_LSB_FIRST = 0x0CF1,
            VERTEX_ARRAY_SIZE = 0x807A,
            COLOR_MATERIAL = 0x0B57,
            MAP1_TEXTURE_COORD_3 = 0x0D95,
            LINE_STIPPLE_PATTERN = 0x0B25,
            PERSPECTIVE_CORRECTION_HINT = 0x0C50,
            MAX_ASYNC_TEX_IMAGE_SGIX = SGIX_async_pixel.MAX_ASYNC_TEX_IMAGE_SGIX,
            PIXEL_MAP_A_TO_A_SIZE = 0x0CB9,
            UNPACK_CMYK_HINT_EXT = EXT_cmyka.UNPACK_CMYK_HINT_EXT,
            SPRITE_TRANSLATION_SGIX = SGIX_sprite.SPRITE_TRANSLATION_SGIX,
            PIXEL_TILE_CACHE_INCREMENT_SGIX = SGIX_pixel_tiles.PIXEL_TILE_CACHE_INCREMENT_SGIX,
            SAMPLE_MASK_VALUE_SGIS = SGIS_multisample.SAMPLE_MASK_VALUE_SGIS,
            LOGIC_OP = 0x0BF1,
            PACK_LSB_FIRST = 0x0D01,
            LIGHT_ENV_MODE_SGIX = SGIX_fragment_lighting.LIGHT_ENV_MODE_SGIX,
            MAP2_INDEX = 0x0DB1,
            UNPACK_IMAGE_DEPTH_SGIS = SGIS_texture4D.UNPACK_IMAGE_DEPTH_SGIS,
            FRAMEZOOM_SGIX = SGIX_framezoom.FRAMEZOOM_SGIX,
            COLOR_CLEAR_VALUE = 0x0C22,
            MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = SGIX_clipmap.MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX,
            PROJECTION_MATRIX = 0x0BA7,
            POST_CONVOLUTION_GREEN_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_GREEN_SCALE_EXT,
            ACCUM_ALPHA_BITS = 0x0D5B,
            DEPTH_TEST = 0x0B71,
            LINE_STIPPLE = 0x0B24,
            MAX_TEXTURE_STACK_DEPTH = 0x0D39,
            LINE_WIDTH = 0x0B21,
            MAX_LIGHTS = 0x0D31,
            STENCIL_PASS_DEPTH_PASS = 0x0B96,
            VERTEX_ARRAY_STRIDE = 0x807C,
            PIXEL_TILE_GRID_HEIGHT_SGIX = SGIX_pixel_tiles.PIXEL_TILE_GRID_HEIGHT_SGIX,
            PACK_IMAGE_HEIGHT_EXT = EXT_texture3D.PACK_IMAGE_HEIGHT_EXT,
            EDGE_FLAG = 0x0B43,
            POST_CONVOLUTION_ALPHA_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_ALPHA_BIAS_EXT,
            TEXTURE_1D = 0x0DE0,
            POINT_SMOOTH_HINT = 0x0C51,
            TEXTURE_GEN_S = 0x0C60,
            TEXTURE_GEN_R = 0x0C62,
            POINT_FADE_THRESHOLD_SIZE_SGIS = SGIS_point_parameters.POINT_FADE_THRESHOLD_SIZE_SGIS,
            PACK_ALIGNMENT = 0x0D05,
            DOUBLEBUFFER = 0x0C32,
            REFERENCE_PLANE_SGIX = SGIX_reference_plane.REFERENCE_PLANE_SGIX,
            COLOR_ARRAY_COUNT_EXT = EXT_vertex_array.COLOR_ARRAY_COUNT_EXT,
            PIXEL_TILE_HEIGHT_SGIX = SGIX_pixel_tiles.PIXEL_TILE_HEIGHT_SGIX,
            MAX_ACTIVE_LIGHTS_SGIX = SGIX_fragment_lighting.MAX_ACTIVE_LIGHTS_SGIX,
            BLEND_SRC = 0x0BE1,
            DISTANCE_ATTENUATION_SGIS = SGIS_point_parameters.DISTANCE_ATTENUATION_SGIS,
            PACK_SKIP_ROWS = 0x0D03,
            FOG_COLOR = 0x0B66,
            LINE_SMOOTH = 0x0B20,
            MAX_VIEWPORT_DIMS = 0x0D3A,
            POST_COLOR_MATRIX_COLOR_TABLE_SGI = SGI_color_table.POST_COLOR_MATRIX_COLOR_TABLE_SGI,
            COLOR_ARRAY = 0x8076,
            MAX_TEXTURE_SIZE = 0x0D33,
            FRAGMENT_COLOR_MATERIAL_SGIX = SGIX_fragment_lighting.FRAGMENT_COLOR_MATERIAL_SGIX,
            LIGHT_MODEL_COLOR_CONTROL = VERSION_1_2.LIGHT_MODEL_COLOR_CONTROL,
            CLIP_PLANE1 = ClipPlaneName.CLIP_PLANE1,
            PIXEL_TEX_GEN_MODE_SGIX = SGIX_pixel_texture.PIXEL_TEX_GEN_MODE_SGIX,
            VERTEX_PRECLIP_HINT_SGIX = SGIX_vertex_preclip.VERTEX_PRECLIP_HINT_SGIX,
            LIGHT7 = LightName.LIGHT7,
            COLOR_MATRIX_SGI = SGI_color_matrix.COLOR_MATRIX_SGI,
            FEEDBACK_BUFFER_TYPE = 0x0DF2,
            RED_BIAS = 0x0D15,
            FRAMEZOOM_FACTOR_SGIX = SGIX_framezoom.FRAMEZOOM_FACTOR_SGIX,
            LINE_WIDTH_GRANULARITY = 0x0B23,
            MODELVIEW_MATRIX = 0x0BA6,
            MAX_ASYNC_HISTOGRAM_SGIX = SGIX_async_histogram.MAX_ASYNC_HISTOGRAM_SGIX,
            CULL_FACE = 0x0B44,
            DITHER = 0x0BD0,
            SMOOTH_LINE_WIDTH_GRANULARITY = VERSION_1_2.SMOOTH_LINE_WIDTH_GRANULARITY,
            CURRENT_RASTER_TEXTURE_COORDS = 0x0B06,
            POST_COLOR_MATRIX_GREEN_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_GREEN_SCALE_SGI,
            STENCIL_WRITEMASK = 0x0B98,
            SAMPLE_ALPHA_TO_MASK_SGIS = SGIS_multisample.SAMPLE_ALPHA_TO_MASK_SGIS,
            STENCIL_FAIL = 0x0B94,
            PIXEL_MAP_S_TO_S_SIZE = 0x0CB1,
            BLUE_BIAS = 0x0D1B,
            SHADE_MODEL = 0x0B54,
            ASYNC_MARKER_SGIX = SGIX_async.ASYNC_MARKER_SGIX,
            INDEX_BITS = 0x0D51,
            ACCUM_GREEN_BITS = 0x0D59,
            FRAGMENT_LIGHTING_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHTING_SGIX,
            SPRITE_MODE_SGIX = SGIX_sprite.SPRITE_MODE_SGIX,
            PIXEL_TILE_WIDTH_SGIX = SGIX_pixel_tiles.PIXEL_TILE_WIDTH_SGIX,
            UNPACK_ROW_LENGTH = 0x0CF2,
            CURRENT_RASTER_COLOR = 0x0B04,
            TEXTURE_COORD_ARRAY_COUNT_EXT = EXT_vertex_array.TEXTURE_COORD_ARRAY_COUNT_EXT,
            LOGIC_OP_MODE = 0x0BF0,
            DEFORMATIONS_MASK_SGIX = SGIX_polynomial_ffd.DEFORMATIONS_MASK_SGIX,
            POINT_SIZE_MIN_SGIS = SGIS_point_parameters.POINT_SIZE_MIN_SGIS,
            CONVOLUTION_HINT_SGIX = SGIX_convolution_accuracy.CONVOLUTION_HINT_SGIX,
            CURRENT_RASTER_POSITION = 0x0B07,
            SAMPLE_BUFFERS_SGIS = SGIS_multisample.SAMPLE_BUFFERS_SGIS,
            DEPTH_WRITEMASK = 0x0B72,
            DRAW_BUFFER = 0x0C01,
            COLOR_ARRAY_STRIDE = 0x8083,
            DEPTH_SCALE = 0x0D1E,
            ALPHA_TEST = 0x0BC0,
            NORMALIZE = 0x0BA1,
            IR_INSTRUMENT1_SGIX = SGIX_ir_instrument1.IR_INSTRUMENT1_SGIX,
            MINMAX_EXT = EXT_histogram.MINMAX_EXT,
            TEXTURE_BINDING_2D = 0x8069,
            MAX_ATTRIB_STACK_DEPTH = 0x0D35,
            LIGHT2 = LightName.LIGHT2,
            TEXTURE_3D_EXT = EXT_texture3D.TEXTURE_3D_EXT,
            CONVOLUTION_1D_EXT = EXT_convolution.CONVOLUTION_1D_EXT,
            MAP1_TEXTURE_COORD_1 = 0x0D93,
            VIEWPORT = 0x0BA2,
            INSTRUMENT_MEASUREMENTS_SGIX = SGIX_instruments.INSTRUMENT_MEASUREMENTS_SGIX,
            POLYGON_SMOOTH_HINT = 0x0C53,
            LIGHT_MODEL_TWO_SIDE = 0x0B52,
            INDEX_OFFSET = 0x0D13,
            MAP_COLOR = 0x0D10,
            FOG_INDEX = 0x0B61,
            ZOOM_Y = 0x0D17,
            CLIP_PLANE2 = ClipPlaneName.CLIP_PLANE2,
            STENCIL_TEST = 0x0B90,
            ASYNC_HISTOGRAM_SGIX = SGIX_async_histogram.ASYNC_HISTOGRAM_SGIX,
            MAX_EVAL_ORDER = 0x0D30,
            MAP2_NORMAL = 0x0DB2,
            STENCIL_PASS_DEPTH_FAIL = 0x0B95,
            VERTEX_ARRAY = 0x8074,
            ALIASED_POINT_SIZE_RANGE = VERSION_1_2.ALIASED_POINT_SIZE_RANGE,
            REFERENCE_PLANE_EQUATION_SGIX = SGIX_reference_plane.REFERENCE_PLANE_EQUATION_SGIX,
            NORMAL_ARRAY = 0x8075,
            UNPACK_SWAP_BYTES = 0x0CF0,
            INDEX_CLEAR_VALUE = 0x0C20,
            TEXTURE_4D_SGIS = SGIS_texture4D.TEXTURE_4D_SGIS,
            LIGHT1 = LightName.LIGHT1,
            CURRENT_TEXTURE_COORDS = 0x0B03,
            MAP2_TEXTURE_COORD_1 = 0x0DB3,
            TEXTURE_COORD_ARRAY = 0x8078,
            BLEND_EQUATION_EXT = EXT_blend_minmax.BLEND_EQUATION_EXT,
            POLYGON_STIPPLE = 0x0B42,
            VERTEX_ARRAY_TYPE = 0x807B,
            MAP1_INDEX = 0x0D91,
            NORMAL_ARRAY_COUNT_EXT = EXT_vertex_array.NORMAL_ARRAY_COUNT_EXT,
            CONVOLUTION_2D_EXT = EXT_convolution.CONVOLUTION_2D_EXT,
            MAX_LIST_NESTING = 0x0B31,
            STENCIL_BITS = 0x0D57,
            SUBPIXEL_BITS = 0x0D50,
            POLYGON_OFFSET_FILL = 0x8037,
            LINE_WIDTH_RANGE = 0x0B22,
            POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = SGIX_texture_scale_bias.POST_TEXTURE_FILTER_SCALE_RANGE_SGIX,
            VERTEX_PRECLIP_SGIX = SGIX_vertex_preclip.VERTEX_PRECLIP_SGIX,
            POLYGON_OFFSET_POINT = 0x2A01,
            ALPHA_TEST_REF = 0x0BC2,
            RGBA_MODE = 0x0C31,
            EDGE_FLAG_ARRAY_STRIDE = 0x808C,
            LIGHT_MODEL_LOCAL_VIEWER = 0x0B51,
            INDEX_SHIFT = 0x0D12,
            MAP_STENCIL = 0x0D11,
            TEXTURE_COORD_ARRAY_SIZE = 0x8088,
            POST_COLOR_MATRIX_BLUE_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_BLUE_BIAS_SGI,
            TEXTURE_3D_BINDING_EXT = EXT_texture_object.TEXTURE_3D_BINDING_EXT,
            PIXEL_MAP_I_TO_B_SIZE = 0x0CB4,
            POLYGON_OFFSET_LINE = 0x2A02,
            MAX_PIXEL_MAP_TABLE = 0x0D34,
            POST_COLOR_MATRIX_ALPHA_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_ALPHA_BIAS_SGI,
            BLEND_DST = 0x0BE0,
            TEXTURE_4D_BINDING_SGIS = SGIS_texture4D.TEXTURE_4D_BINDING_SGIS,
            DEPTH_BIAS = 0x0D1F,
            POST_CONVOLUTION_RED_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_RED_BIAS_EXT,
            MAP2_GRID_SEGMENTS = 0x0DD3,
            MAX_CLIP_PLANES = 0x0D32,
            MAX_ASYNC_READ_PIXELS_SGIX = SGIX_async_pixel.MAX_ASYNC_READ_PIXELS_SGIX,
            DEPTH_BITS = 0x0D56,
            POINT_SIZE_MAX_SGIS = SGIS_point_parameters.POINT_SIZE_MAX_SGIS,
        }

        public enum NV_packed_depth_stencil : uint
        {
            DEPTH_STENCIL_NV = 0x84F9,
            UNSIGNED_INT_24_8_NV = 0x84FA,
        }

        public enum ATI_text_fragment_shader : uint
        {
            TEXT_FRAGMENT_SHADER_ATI = 0x8200,
        }

        public enum SGIS_texture_color_mask : uint
        {
            TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF,
        }

        public enum SGIX_ycrcb_subsample : uint
        {
            PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3,
            PACK_SUBSAMPLE_RATE_SGIX = 0x85A0,
            PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2,
            PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4,
            UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1,
        }

        public enum SGIX_texture_lod_bias : uint
        {
            TEXTURE_LOD_BIAS_R_SGIX = 0x8190,
            TEXTURE_LOD_BIAS_S_SGIX = 0x818E,
            TEXTURE_LOD_BIAS_T_SGIX = 0x818F,
        }

        public enum TextureEnvMode : uint
        {
            REPLACE_EXT = EXT_texture.REPLACE_EXT,
            MODULATE = 0x2100,
            ADD = AccumOp.ADD,
            DECAL = 0x2101,
            BLEND = GetPName.BLEND,
            TEXTURE_ENV_BIAS_SGIX = SGIX_texture_add_env.TEXTURE_ENV_BIAS_SGIX,
        }

        public enum EXT_texture_cube_map : uint
        {
            TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516,
            TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518,
            TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517,
            TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A,
            TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514,
            REFLECTION_MAP_EXT = 0x8512,
            TEXTURE_CUBE_MAP_EXT = 0x8513,
            MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C,
            TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519,
            PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B,
            TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515,
            NORMAL_MAP_EXT = 0x8511,
        }

        public enum NV_multisample_filter_hint : uint
        {
            MULTISAMPLE_FILTER_HINT_NV = 0x8534,
        }

        public enum IndexPointerType : uint
        {
            DOUBLE = DataType.DOUBLE,
            INT = DataType.INT,
            SHORT = DataType.SHORT,
            FLOAT = DataType.FLOAT,
        }

        public enum FogParameter : uint
        {
            FOG_END = GetPName.FOG_END,
            FOG_COLOR = GetPName.FOG_COLOR,
            FOG_DENSITY = GetPName.FOG_DENSITY,
            FOG_START = GetPName.FOG_START,
            FOG_OFFSET_VALUE_SGIX = SGIX_fog_offset.FOG_OFFSET_VALUE_SGIX,
            FOG_INDEX = GetPName.FOG_INDEX,
            FOG_MODE = GetPName.FOG_MODE,
        }

        public enum SGIS_sharpen_texture : uint
        {
            LINEAR_SHARPEN_SGIS = 0x80AD,
            LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE,
            LINEAR_SHARPEN_COLOR_SGIS = 0x80AF,
            SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0,
        }

        public enum AlphaFunction : uint
        {
            NEVER = 0x0200,
            GEQUAL = 0x0206,
            GREATER = 0x0204,
            ALWAYS = 0x0207,
            LEQUAL = 0x0203,
            NOTEQUAL = 0x0205,
            EQUAL = 0x0202,
            LESS = 0x0201,
        }

        public enum NV_register_combiners2 : uint
        {
            PER_STAGE_CONSTANTS_NV = 0x8535,
        }

        public enum ARB_texture_env_crossbar : uint
        {
        }

        public enum EXT_vertex_weighting : uint
        {
            CURRENT_VERTEX_WEIGHT_EXT = 0x850B,
            MODELVIEW0_MATRIX_EXT = GL_MODELVIEW_MATRIX,
            VERTEX_WEIGHT_ARRAY_EXT = 0x850C,
            MODELVIEW1_MATRIX_EXT = 0x8506,
            VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E,
            VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F,
            MODELVIEW1_EXT = 0x850A,
            VERTEX_WEIGHTING_EXT = 0x8509,
            MODELVIEW0_EXT = GL_MODELVIEW,
            MODELVIEW1_STACK_DEPTH_EXT = 0x8502,
            VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510,
            VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D,
            MODELVIEW0_STACK_DEPTH_EXT = GL_MODELVIEW_STACK_DEPTH,
        }

        public enum ATI_texture_env_combine3 : uint
        {
            MODULATE_ADD_ATI = 0x8744,
            MODULATE_SIGNED_ADD_ATI = 0x8745,
            MODULATE_SUBTRACT_ATI = 0x8746,
        }

        public enum EXT_misc_attribute : uint
        {
        }

        public enum IBM_multimode_draw_arrays : uint
        {
        }

        public enum SGI_color_matrix : uint
        {
            POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8,
            POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA,
            COLOR_MATRIX_SGI = 0x80B1,
            POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6,
            POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9,
            POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6,
            POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB,
            COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2,
            POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9,
            POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7,
            POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5,
            POST_COLOR_MATRIX_RED_BIAS = 0x80B8,
            MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3,
            POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7,
            COLOR_MATRIX_STACK_DEPTH = 0x80B2,
            POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA,
            COLOR_MATRIX = 0x80B1,
            POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5,
            POST_COLOR_MATRIX_RED_SCALE = 0x80B4,
            MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3,
            POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB,
            POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4,
        }

        public enum SamplePatternSGIS : uint
        {
            _4PASS_0_SGIS = SGIS_multisample._4PASS_0_SGIS,
            _4PASS_1_SGIS = SGIS_multisample._4PASS_1_SGIS,
            _1PASS_SGIS = SGIS_multisample._1PASS_SGIS,
            _2PASS_0_SGIS = SGIS_multisample._2PASS_0_SGIS,
            _4PASS_2_SGIS = SGIS_multisample._4PASS_2_SGIS,
            _2PASS_1_SGIS = SGIS_multisample._2PASS_1_SGIS,
            _4PASS_3_SGIS = SGIS_multisample._4PASS_3_SGIS,
        }

        public enum SGIS_texture_filter4 : uint
        {
            TEXTURE_FILTER4_SIZE_SGIS = 0x8147,
            FILTER4_SGIS = 0x8146,
        }

        public enum NV_fence : uint
        {
            ALL_COMPLETED_NV = 0x84F2,
            FENCE_CONDITION_NV = 0x84F4,
            FENCE_STATUS_NV = 0x84F3,
        }

        public enum SGIX_async_histogram : uint
        {
            MAX_ASYNC_HISTOGRAM_SGIX = 0x832D,
            ASYNC_HISTOGRAM_SGIX = 0x832C,
        }

        public enum ARB_shadow : uint
        {
            TEXTURE_COMPARE_MODE_ARB = 0x884C,
            TEXTURE_COMPARE_FUNC_ARB = 0x884D,
            COMPARE_R_TO_TEXTURE_ARB = 0x884E,
        }

        public enum EXT_clip_volume_hint : uint
        {
            CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0,
        }

        public enum EXT_multi_draw_arrays : uint
        {
        }

        public enum SUN_mesh_array : uint
        {
            TRIANGLE_MESH_SUN = 0x8615,
            QUAD_MESH_SUN = 0x8614,
        }

        public enum LightModelColorControl : uint
        {
            SEPARATE_SPECULAR_COLOR = VERSION_1_2.SEPARATE_SPECULAR_COLOR,
            SINGLE_COLOR = VERSION_1_2.SINGLE_COLOR,
        }

        public enum ATI_element_array : uint
        {
            ELEMENT_ARRAY_POINTER_ATI = 0x876A,
            ELEMENT_ARRAY_ATI = 0x8768,
            ELEMENT_ARRAY_TYPE_ATI = 0x8769,
        }

        public enum SGI_depth_pass_instrument : uint
        {
            DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX = 0x8311,
            DEPTH_PASS_INSTRUMENT_SGIX = 0x8310,
            DEPTH_PASS_INSTRUMENT_MAX_SGIX = 0x8312,
        }

        public enum EXT_subtexture : uint
        {
        }

        public enum EXT_draw_range_elements : uint
        {
            MAX_ELEMENTS_INDICES_EXT = 0x80E9,
            MAX_ELEMENTS_VERTICES_EXT = 0x80E8,
        }

        public enum TextureEnvTarget : uint
        {
            TEXTURE_ENV = 0x2300,
        }

        public enum AccumOp : uint
        {
            RETURN = 0x0102,
            ADD = 0x0104,
            LOAD = 0x0101,
            ACCUM = 0x0100,
            MULT = 0x0103,
        }

        public enum EXT_fog_coord : uint
        {
            FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456,
            FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455,
            FOG_COORDINATE_SOURCE_EXT = 0x8450,
            FOG_COORDINATE_EXT = 0x8451,
            FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454,
            FOG_COORDINATE_ARRAY_EXT = 0x8457,
            CURRENT_FOG_COORDINATE_EXT = 0x8453,
            FRAGMENT_DEPTH_EXT = 0x8452,
        }

        public enum ARB_texture_mirrored_repeat : uint
        {
            MIRRORED_REPEAT_ARB = 0x8370,
        }

        public enum NV_evaluators : uint
        {
            EVAL_VERTEX_ATTRIB4_NV = 0x86CA,
            EVAL_VERTEX_ATTRIB5_NV = 0x86CB,
            EVAL_VERTEX_ATTRIB15_NV = 0x86D5,
            MAX_MAP_TESSELLATION_NV = 0x86D6,
            EVAL_VERTEX_ATTRIB3_NV = 0x86C9,
            EVAL_VERTEX_ATTRIB12_NV = 0x86D2,
            EVAL_VERTEX_ATTRIB14_NV = 0x86D4,
            EVAL_VERTEX_ATTRIB13_NV = 0x86D3,
            MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7,
            MAP_TESSELLATION_NV = 0x86C2,
            MAP_ATTRIB_U_ORDER_NV = 0x86C3,
            EVAL_VERTEX_ATTRIB8_NV = 0x86CE,
            EVAL_VERTEX_ATTRIB11_NV = 0x86D1,
            EVAL_VERTEX_ATTRIB9_NV = 0x86CF,
            EVAL_VERTEX_ATTRIB7_NV = 0x86CD,
            EVAL_VERTEX_ATTRIB10_NV = 0x86D0,
            EVAL_VERTEX_ATTRIB2_NV = 0x86C8,
            EVAL_VERTEX_ATTRIB0_NV = 0x86C6,
            EVAL_2D_NV = 0x86C0,
            EVAL_VERTEX_ATTRIB1_NV = 0x86C7,
            MAP_ATTRIB_V_ORDER_NV = 0x86C4,
            EVAL_TRIANGULAR_2D_NV = 0x86C1,
            EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5,
            EVAL_VERTEX_ATTRIB6_NV = 0x86CC,
        }

        public enum EXT_abgr : uint
        {
            ABGR_EXT = 0x8000,
        }

        public enum NV_copy_depth_to_color : uint
        {
            DEPTH_STENCIL_TO_BGRA_NV = 0x886F,
            DEPTH_STENCIL_TO_RGBA_NV = 0x886E,
        }

        public enum NV_vertex_array_range : uint
        {
            MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520,
            VERTEX_ARRAY_RANGE_VALID_NV = 0x851F,
            VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E,
            VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521,
            VERTEX_ARRAY_RANGE_NV = 0x851D,
        }

        public enum GetColorTableParameterPNameSGI : uint
        {
            COLOR_TABLE_BLUE_SIZE_SGI = SGI_color_table.COLOR_TABLE_BLUE_SIZE_SGI,
            COLOR_TABLE_FORMAT_SGI = SGI_color_table.COLOR_TABLE_FORMAT_SGI,
            COLOR_TABLE_ALPHA_SIZE_SGI = SGI_color_table.COLOR_TABLE_ALPHA_SIZE_SGI,
            COLOR_TABLE_INTENSITY_SIZE_SGI = SGI_color_table.COLOR_TABLE_INTENSITY_SIZE_SGI,
            COLOR_TABLE_GREEN_SIZE_SGI = SGI_color_table.COLOR_TABLE_GREEN_SIZE_SGI,
            COLOR_TABLE_LUMINANCE_SIZE_SGI = SGI_color_table.COLOR_TABLE_LUMINANCE_SIZE_SGI,
            COLOR_TABLE_WIDTH_SGI = SGI_color_table.COLOR_TABLE_WIDTH_SGI,
            COLOR_TABLE_BIAS_SGI = SGI_color_table.COLOR_TABLE_BIAS_SGI,
            COLOR_TABLE_RED_SIZE_SGI = SGI_color_table.COLOR_TABLE_RED_SIZE_SGI,
            COLOR_TABLE_SCALE_SGI = SGI_color_table.COLOR_TABLE_SCALE_SGI,
        }

        public enum SGIX_texture_add_env : uint
        {
            TEXTURE_ENV_BIAS_SGIX = 0x80BE,
        }

        public enum PixelMap : uint
        {
            PIXEL_MAP_B_TO_B = GetPixelMap.PIXEL_MAP_B_TO_B,
            PIXEL_MAP_S_TO_S = GetPixelMap.PIXEL_MAP_S_TO_S,
            PIXEL_MAP_R_TO_R = GetPixelMap.PIXEL_MAP_R_TO_R,
            PIXEL_MAP_I_TO_B = GetPixelMap.PIXEL_MAP_I_TO_B,
            PIXEL_MAP_I_TO_G = GetPixelMap.PIXEL_MAP_I_TO_G,
            PIXEL_MAP_I_TO_A = GetPixelMap.PIXEL_MAP_I_TO_A,
            PIXEL_MAP_A_TO_A = GetPixelMap.PIXEL_MAP_A_TO_A,
            PIXEL_MAP_G_TO_G = GetPixelMap.PIXEL_MAP_G_TO_G,
            PIXEL_MAP_I_TO_I = GetPixelMap.PIXEL_MAP_I_TO_I,
            PIXEL_MAP_I_TO_R = GetPixelMap.PIXEL_MAP_I_TO_R,
        }

        public enum ARB_texture_cube_map : uint
        {
            TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517,
            TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516,
            TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518,
            TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515,
            TEXTURE_CUBE_MAP_ARB = 0x8513,
            TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A,
            MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C,
            REFLECTION_MAP_ARB = 0x8512,
            TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514,
            NORMAL_MAP_ARB = 0x8511,
            PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B,
            TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519,
        }

        public enum NV_vertex_program3 : uint
        {
            MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = ARB_vertex_shader.MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB,
        }

        public enum NV_float_buffer : uint
        {
            FLOAT_R16_NV = 0x8884,
            FLOAT_RG_NV = 0x8881,
            FLOAT_RGB_NV = 0x8882,
            FLOAT_R32_NV = 0x8885,
            FLOAT_RG16_NV = 0x8886,
            FLOAT_R_NV = 0x8880,
            FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D,
            FLOAT_RGB32_NV = 0x8889,
            FLOAT_RGBA_MODE_NV = 0x888E,
            TEXTURE_FLOAT_COMPONENTS_NV = 0x888C,
            FLOAT_RGBA_NV = 0x8883,
            FLOAT_RGBA16_NV = 0x888A,
            FLOAT_RGBA32_NV = 0x888B,
            FLOAT_RGB16_NV = 0x8888,
            FLOAT_RG32_NV = 0x8887,
        }

        public enum ATI_vertex_attrib_array_object : uint
        {
        }

        public enum IBM_cull_vertex : uint
        {
            CULL_VERTEX_IBM = 103050,
        }

        public enum NV_texture_rectangle : uint
        {
            TEXTURE_BINDING_RECTANGLE_NV = 0x84F6,
            PROXY_TEXTURE_RECTANGLE_NV = 0x84F7,
            MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8,
            TEXTURE_RECTANGLE_NV = 0x84F5,
        }

        public enum LightEnvModeSGIX : uint
        {
            REPLACE = StencilOp.REPLACE,
            MODULATE = TextureEnvMode.MODULATE,
            ADD = AccumOp.ADD,
        }

        public enum ARB_window_pos : uint
        {
        }

        public enum SGIX_subsample : uint
        {
            PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3,
            PACK_SUBSAMPLE_RATE_SGIX = 0x85A0,
            PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2,
            PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4,
            UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1,
        }

        public enum SGIX_ir_instrument1 : uint
        {
            IR_INSTRUMENT1_SGIX = 0x817F,
        }

        public enum ARB_transpose_matrix : uint
        {
            TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5,
            TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4,
            TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6,
            TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3,
        }

        public enum PixelType : uint
        {
            UNSIGNED_INT = DataType.UNSIGNED_INT,
            UNSIGNED_SHORT_5_5_5_1_EXT = EXT_packed_pixels.UNSIGNED_SHORT_5_5_5_1_EXT,
            FLOAT = DataType.FLOAT,
            UNSIGNED_SHORT = DataType.UNSIGNED_SHORT,
            SHORT = DataType.SHORT,
            BYTE = DataType.BYTE,
            UNSIGNED_INT_8_8_8_8_EXT = EXT_packed_pixels.UNSIGNED_INT_8_8_8_8_EXT,
            UNSIGNED_BYTE_3_3_2_EXT = EXT_packed_pixels.UNSIGNED_BYTE_3_3_2_EXT,
            INT = DataType.INT,
            BITMAP = 0x1A00,
            UNSIGNED_BYTE = DataType.UNSIGNED_BYTE,
            UNSIGNED_INT_10_10_10_2_EXT = EXT_packed_pixels.UNSIGNED_INT_10_10_10_2_EXT,
            UNSIGNED_SHORT_4_4_4_4_EXT = EXT_packed_pixels.UNSIGNED_SHORT_4_4_4_4_EXT,
        }

        public enum EXT_texture_env_combine : uint
        {
            SOURCE0_RGB_EXT = 0x8580,
            COMBINE_RGB_EXT = 0x8571,
            SOURCE1_RGB_EXT = 0x8581,
            CONSTANT_EXT = 0x8576,
            SOURCE1_ALPHA_EXT = 0x8589,
            SOURCE2_ALPHA_EXT = 0x858A,
            SOURCE2_RGB_EXT = 0x8582,
            OPERAND0_RGB_EXT = 0x8590,
            OPERAND0_ALPHA_EXT = 0x8598,
            RGB_SCALE_EXT = 0x8573,
            OPERAND1_RGB_EXT = 0x8591,
            SOURCE0_ALPHA_EXT = 0x8588,
            OPERAND2_ALPHA_EXT = 0x859A,
            INTERPOLATE_EXT = 0x8575,
            COMBINE_EXT = 0x8570,
            OPERAND1_ALPHA_EXT = 0x8599,
            OPERAND2_RGB_EXT = 0x8592,
            PREVIOUS_EXT = 0x8578,
            ADD_SIGNED_EXT = 0x8574,
            PRIMARY_COLOR_EXT = 0x8577,
            COMBINE_ALPHA_EXT = 0x8572,
        }

        public enum NV_texture_shader2 : uint
        {
            DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF,
        }

        public enum EXT_point_parameters : uint
        {
            DISTANCE_ATTENUATION_EXT = 0x8129,
            POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128,
            POINT_SIZE_MAX_EXT = 0x8127,
            POINT_SIZE_MIN_EXT = 0x8126,
        }

        public enum SGIX_fog_scale : uint
        {
            FOG_SCALE_SGIX = 0x81FC,
            FOG_SCALE_VALUE_SGIX = 0x81FD,
        }

        public enum OML_interlace : uint
        {
            INTERLACE_READ_OML = 0x8981,
            INTERLACE_OML = 0x8980,
        }

        public enum SGIS_texture_select : uint
        {
            DUAL_ALPHA16_SGIS = 0x8113,
            QUAD_ALPHA8_SGIS = 0x811F,
            DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C,
            DUAL_LUMINANCE12_SGIS = 0x8116,
            DUAL_ALPHA4_SGIS = 0x8110,
            QUAD_TEXTURE_SELECT_SGIS = 0x8125,
            DUAL_ALPHA12_SGIS = 0x8112,
            QUAD_INTENSITY4_SGIS = 0x8122,
            DUAL_INTENSITY16_SGIS = 0x811B,
            DUAL_INTENSITY4_SGIS = 0x8118,
            DUAL_LUMINANCE4_SGIS = 0x8114,
            QUAD_INTENSITY8_SGIS = 0x8123,
            DUAL_LUMINANCE16_SGIS = 0x8117,
            DUAL_LUMINANCE8_SGIS = 0x8115,
            QUAD_LUMINANCE8_SGIS = 0x8121,
            DUAL_TEXTURE_SELECT_SGIS = 0x8124,
            DUAL_ALPHA8_SGIS = 0x8111,
            DUAL_INTENSITY12_SGIS = 0x811A,
            DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D,
            QUAD_LUMINANCE4_SGIS = 0x8120,
            DUAL_INTENSITY8_SGIS = 0x8119,
            QUAD_ALPHA4_SGIS = 0x811E,
        }

        public enum EXT_texture_compression_s3tc : uint
        {
            COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0,
            COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1,
            COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3,
            COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2,
        }

        public enum ARB_draw_buffers : uint
        {
            DRAW_BUFFER13_ARB = 0x8832,
            DRAW_BUFFER4_ARB = 0x8829,
            DRAW_BUFFER1_ARB = 0x8826,
            MAX_DRAW_BUFFERS_ARB = 0x8824,
            DRAW_BUFFER2_ARB = 0x8827,
            DRAW_BUFFER0_ARB = 0x8825,
            DRAW_BUFFER8_ARB = 0x882D,
            DRAW_BUFFER7_ARB = 0x882C,
            DRAW_BUFFER10_ARB = 0x882F,
            DRAW_BUFFER5_ARB = 0x882A,
            DRAW_BUFFER15_ARB = 0x8834,
            DRAW_BUFFER14_ARB = 0x8833,
            DRAW_BUFFER3_ARB = 0x8828,
            DRAW_BUFFER6_ARB = 0x882B,
            DRAW_BUFFER12_ARB = 0x8831,
            DRAW_BUFFER11_ARB = 0x8830,
            DRAW_BUFFER9_ARB = 0x882E,
        }

        public enum EXT_index_material : uint
        {
            INDEX_MATERIAL_FACE_EXT = 0x81BA,
            INDEX_MATERIAL_EXT = 0x81B8,
            INDEX_MATERIAL_PARAMETER_EXT = 0x81B9,
        }

        public enum EXT_framebuffer_object : uint
        {
            FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC,
            COLOR_ATTACHMENT3_EXT = 0x8CE3,
            COLOR_ATTACHMENT1_EXT = 0x8CE1,
            FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0,
            FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4,
            RENDERBUFFER_EXT = 0x8D41,
            COLOR_ATTACHMENT15_EXT = 0x8CEF,
            COLOR_ATTACHMENT13_EXT = 0x8CED,
            RENDERBUFFER_HEIGHT_EXT = 0x8D43,
            COLOR_ATTACHMENT14_EXT = 0x8CEE,
            FRAMEBUFFER_COMPLETE_EXT = 0x8CD5,
            RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44,
            FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9,
            FRAMEBUFFER_STATUS_ERROR_EXT = 0x8CDE,
            STENCIL_INDEX4_EXT = 0x8D47,
            FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2,
            COLOR_ATTACHMENT6_EXT = 0x8CE6,
            STENCIL_INDEX_EXT = 0x8D45,
            FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7,
            FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA,
            FRAMEBUFFER_BINDING_EXT = 0x8CA6,
            COLOR_ATTACHMENT8_EXT = 0x8CE8,
            COLOR_ATTACHMENT2_EXT = 0x8CE2,
            COLOR_ATTACHMENT9_EXT = 0x8CE9,
            FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3,
            FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB,
            COLOR_ATTACHMENT12_EXT = 0x8CEC,
            MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF,
            STENCIL_INDEX8_EXT = 0x8D48,
            COLOR_ATTACHMENT7_EXT = 0x8CE7,
            MAX_RENDERBUFFER_SIZE_EXT = 0x84E8,
            STENCIL_INDEX1_EXT = 0x8D46,
            DEPTH_ATTACHMENT_EXT = 0x8D00,
            COLOR_ATTACHMENT0_EXT = 0x8CE0,
            INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506,
            FRAMEBUFFER_EXT = 0x8D40,
            RENDERBUFFER_WIDTH_EXT = 0x8D42,
            FRAMEBUFFER_INCOMPLETE_DUPLICATE_ATTACHMENT_EXT = 0x8CD8,
            FRAMEBUFFER_INCOMPLETE_ATTACHMENTS_EXT = 0x8CD6,
            COLOR_ATTACHMENT5_EXT = 0x8CE5,
            FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD,
            COLOR_ATTACHMENT11_EXT = 0x8CEB,
            STENCIL_INDEX16_EXT = 0x8D49,
            COLOR_ATTACHMENT4_EXT = 0x8CE4,
            COLOR_ATTACHMENT10_EXT = 0x8CEA,
            RENDERBUFFER_BINDING_EXT = 0x8CA7,
            FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1,
            STENCIL_ATTACHMENT_EXT = 0x8D20,
        }

        public enum SGIX_async : uint
        {
            ASYNC_MARKER_SGIX = 0x8329,
        }

        public enum EXT_texture_env_add : uint
        {
        }

        public enum PixelTransferParameter : uint
        {
            POST_CONVOLUTION_RED_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_RED_BIAS_EXT,
            DEPTH_BIAS = GetPName.DEPTH_BIAS,
            POST_COLOR_MATRIX_BLUE_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_BLUE_BIAS_SGI,
            POST_CONVOLUTION_BLUE_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_BLUE_BIAS_EXT,
            BLUE_SCALE = GetPName.BLUE_SCALE,
            POST_COLOR_MATRIX_BLUE_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_BLUE_SCALE_SGI,
            BLUE_BIAS = GetPName.BLUE_BIAS,
            POST_COLOR_MATRIX_ALPHA_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_ALPHA_BIAS_SGI,
            INDEX_OFFSET = GetPName.INDEX_OFFSET,
            POST_CONVOLUTION_ALPHA_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_ALPHA_BIAS_EXT,
            POST_COLOR_MATRIX_RED_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_RED_BIAS_SGI,
            MAP_COLOR = GetPName.MAP_COLOR,
            POST_COLOR_MATRIX_ALPHA_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_ALPHA_SCALE_SGI,
            MAP_STENCIL = GetPName.MAP_STENCIL,
            POST_CONVOLUTION_GREEN_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_GREEN_SCALE_EXT,
            INDEX_SHIFT = GetPName.INDEX_SHIFT,
            POST_COLOR_MATRIX_GREEN_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_GREEN_SCALE_SGI,
            POST_CONVOLUTION_BLUE_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_BLUE_SCALE_EXT,
            POST_CONVOLUTION_RED_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_RED_SCALE_EXT,
            POST_COLOR_MATRIX_GREEN_BIAS_SGI = SGI_color_matrix.POST_COLOR_MATRIX_GREEN_BIAS_SGI,
            POST_COLOR_MATRIX_RED_SCALE_SGI = SGI_color_matrix.POST_COLOR_MATRIX_RED_SCALE_SGI,
            RED_SCALE = GetPName.RED_SCALE,
            GREEN_BIAS = GetPName.GREEN_BIAS,
            RED_BIAS = GetPName.RED_BIAS,
            POST_CONVOLUTION_GREEN_BIAS_EXT = EXT_convolution.POST_CONVOLUTION_GREEN_BIAS_EXT,
            GREEN_SCALE = GetPName.GREEN_SCALE,
            ALPHA_SCALE = GetPName.ALPHA_SCALE,
            ALPHA_BIAS = GetPName.ALPHA_BIAS,
            DEPTH_SCALE = GetPName.DEPTH_SCALE,
            POST_CONVOLUTION_ALPHA_SCALE_EXT = EXT_convolution.POST_CONVOLUTION_ALPHA_SCALE_EXT,
        }

        public enum VERSION_1_3 : uint
        {
            TEXTURE14 = 0x84CE,
            TEXTURE17 = 0x84D1,
            TEXTURE16 = 0x84D0,
            TEXTURE11 = 0x84CB,
            TEXTURE10 = 0x84CA,
            TEXTURE13 = 0x84CD,
            TEXTURE12 = 0x84CC,
            SAMPLE_ALPHA_TO_ONE = 0x809F,
            TEXTURE_BINDING_CUBE_MAP = 0x8514,
            TEXTURE19 = 0x84D3,
            TEXTURE18 = 0x84D2,
            PRIMARY_COLOR = 0x8577,
            MULTISAMPLE = 0x809D,
            TRANSPOSE_COLOR_MATRIX = 0x84E6,
            TRANSPOSE_PROJECTION_MATRIX = 0x84E4,
            CONSTANT = 0x8576,
            COMBINE = 0x8570,
            MULTISAMPLE_BIT = 0x20000000,
            SOURCE2_ALPHA = 0x858A,
            SAMPLES = 0x80A9,
            COMPRESSED_ALPHA = 0x84E9,
            TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517,
            SAMPLE_COVERAGE = 0x80A0,
            TRANSPOSE_MODELVIEW_MATRIX = 0x84E3,
            SAMPLE_ALPHA_TO_COVERAGE = 0x809E,
            SUBTRACT = 0x84E7,
            SAMPLE_BUFFERS = 0x80A8,
            DOT3_RGBA = 0x86AF,
            DOT3_RGB = 0x86AE,
            SOURCE1_ALPHA = 0x8589,
            TEXTURE6 = 0x84C6,
            TEXTURE2 = 0x84C2,
            COMPRESSED_RGB = 0x84ED,
            COMPRESSED_RGBA = 0x84EE,
            TEXTURE9 = 0x84C9,
            TEXTURE31 = 0x84DF,
            TEXTURE30 = 0x84DE,
            OPERAND1_ALPHA = 0x8599,
            CLIENT_ACTIVE_TEXTURE = 0x84E1,
            INTERPOLATE = 0x8575,
            OPERAND1_RGB = 0x8591,
            SOURCE2_RGB = 0x8582,
            MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C,
            TEXTURE_COMPRESSED = 0x86A1,
            TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A,
            RGB_SCALE = 0x8573,
            SAMPLE_COVERAGE_INVERT = 0x80AB,
            TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519,
            NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2,
            COMPRESSED_TEXTURE_FORMATS = 0x86A3,
            TEXTURE5 = 0x84C5,
            TEXTURE1 = 0x84C1,
            COMBINE_RGB = 0x8571,
            TEXTURE25 = 0x84D9,
            TEXTURE8 = 0x84C8,
            TEXTURE27 = 0x84DB,
            TEXTURE26 = 0x84DA,
            TEXTURE21 = 0x84D5,
            TEXTURE20 = 0x84D4,
            TEXTURE23 = 0x84D7,
            TEXTURE22 = 0x84D6,
            SAMPLE_COVERAGE_VALUE = 0x80AA,
            TEXTURE29 = 0x84DD,
            TEXTURE28 = 0x84DC,
            TEXTURE_CUBE_MAP = 0x8513,
            SOURCE0_ALPHA = 0x8588,
            TEXTURE24 = 0x84D8,
            SOURCE0_RGB = 0x8580,
            ADD_SIGNED = 0x8574,
            OPERAND0_ALPHA = 0x8598,
            REFLECTION_MAP = 0x8512,
            ACTIVE_TEXTURE = 0x84E0,
            TRANSPOSE_TEXTURE_MATRIX = 0x84E5,
            SOURCE1_RGB = 0x8581,
            TEXTURE15 = 0x84CF,
            COMPRESSED_LUMINANCE = 0x84EA,
            CLAMP_TO_BORDER = 0x812D,
            TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516,
            OPERAND2_ALPHA = 0x859A,
            COMPRESSED_INTENSITY = 0x84EC,
            TEXTURE0 = 0x84C0,
            NORMAL_MAP = 0x8511,
            COMPRESSED_LUMINANCE_ALPHA = 0x84EB,
            PROXY_TEXTURE_CUBE_MAP = 0x851B,
            TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0,
            OPERAND2_RGB = 0x8592,
            TEXTURE4 = 0x84C4,
            OPERAND0_RGB = 0x8590,
            MAX_TEXTURE_UNITS = 0x84E2,
            TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515,
            TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518,
            TEXTURE_COMPRESSION_HINT = 0x84EF,
            COMBINE_ALPHA = 0x8572,
            PREVIOUS = 0x8578,
            TEXTURE7 = 0x84C7,
            TEXTURE3 = 0x84C3,
        }

        public enum NV_vertex_program2 : uint
        {
        }

        public enum EXT_polygon_offset : uint
        {
            POLYGON_OFFSET_BIAS_EXT = 0x8039,
            POLYGON_OFFSET_EXT = 0x8037,
            POLYGON_OFFSET_FACTOR_EXT = 0x8038,
        }

        public enum SGIX_texture_coordinate_clamp : uint
        {
            FOG_FACTOR_TO_ALPHA_SGIX = 0x836F,
            TEXTURE_MAX_CLAMP_S_SGIX = 0x8369,
            TEXTURE_MAX_CLAMP_R_SGIX = 0x836B,
            TEXTURE_MAX_CLAMP_T_SGIX = 0x836A,
        }

        public enum SGIX_instruments : uint
        {
            INSTRUMENT_MEASUREMENTS_SGIX = 0x8181,
            INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180,
        }

        public enum VERSION_2_0 : uint
        {
            MAX_VARYING_FLOATS = 0x8B4B,
            VERTEX_ATTRIB_ARRAY_POINTER = 0x8645,
            VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622,
            DRAW_BUFFER13 = 0x8832,
            VERTEX_PROGRAM_POINT_SIZE = 0x8642,
            MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C,
            MAX_TEXTURE_COORDS = 0x8871,
            FLOAT_MAT4 = 0x8B5C,
            SAMPLER_3D = 0x8B5F,
            SAMPLER_1D_SHADOW = 0x8B61,
            SAMPLER_1D = 0x8B5D,
            ATTACHED_SHADERS = 0x8B85,
            ACTIVE_ATTRIBUTES = 0x8B89,
            LINK_STATUS = 0x8B82,
            FLOAT_VEC4 = 0x8B52,
            DRAW_BUFFER4 = 0x8829,
            DRAW_BUFFER8 = 0x882D,
            MAX_DRAW_BUFFERS = 0x8824,
            INT_VEC2 = 0x8B53,
            POINT_SPRITE_COORD_ORIGIN = 0x8CA0,
            MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49,
            SAMPLER_CUBE = 0x8B60,
            DRAW_BUFFER12 = 0x8831,
            DRAW_BUFFER11 = 0x8830,
            DRAW_BUFFER10 = 0x882F,
            FRAGMENT_SHADER = 0x8B30,
            STENCIL_BACK_REF = 0x8CA3,
            DRAW_BUFFER15 = 0x8834,
            DRAW_BUFFER14 = 0x8833,
            BOOL = 0x8B56,
            CURRENT_VERTEX_ATTRIB = 0x8626,
            ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A,
            FLOAT_MAT2 = 0x8B5A,
            ACTIVE_UNIFORMS = 0x8B86,
            SAMPLER_2D = 0x8B5E,
            INFO_LOG_LENGTH = 0x8B84,
            MAX_VERTEX_ATTRIBS = 0x8869,
            DRAW_BUFFER0 = 0x8825,
            CURRENT_PROGRAM = 0x8B8D,
            SHADING_LANGUAGE_VERSION = 0x8B8C,
            FLOAT_VEC3 = 0x8B51,
            DRAW_BUFFER5 = 0x882A,
            DRAW_BUFFER9 = 0x882E,
            STENCIL_BACK_FUNC = 0x8800,
            COMPILE_STATUS = 0x8B81,
            INT_VEC3 = 0x8B54,
            STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802,
            VERTEX_ATTRIB_ARRAY_SIZE = 0x8623,
            BLEND_EQUATION_ALPHA = 0x883D,
            STENCIL_BACK_PASS_DEPTH_PASS = 0x8803,
            UPPER_LEFT = 0x8CA2,
            VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624,
            FLOAT_MAT3 = 0x8B5B,
            SAMPLER_2D_SHADOW = 0x8B62,
            VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A,
            FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B,
            BLEND_EQUATION_RGB = GL_BLEND_EQUATION,
            DRAW_BUFFER2 = 0x8827,
            SHADER_SOURCE_LENGTH = 0x8B88,
            DRAW_BUFFER7 = 0x882C,
            SHADER_TYPE = 0x8B4F,
            DRAW_BUFFER1 = 0x8826,
            MAX_TEXTURE_IMAGE_UNITS = 0x8872,
            POINT_SPRITE = 0x8861,
            DRAW_BUFFER6 = 0x882B,
            STENCIL_BACK_WRITEMASK = 0x8CA5,
            STENCIL_BACK_VALUE_MASK = 0x8CA4,
            COORD_REPLACE = 0x8862,
            VERTEX_ATTRIB_ARRAY_TYPE = 0x8625,
            LOWER_LEFT = 0x8CA1,
            INT_VEC4 = 0x8B55,
            FLOAT_VEC2 = 0x8B50,
            MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A,
            VALIDATE_STATUS = 0x8B83,
            VERTEX_SHADER = 0x8B31,
            MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D,
            VERTEX_PROGRAM_TWO_SIDE = 0x8643,
            DELETE_STATUS = 0x8B80,
            STENCIL_BACK_FAIL = 0x8801,
            ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87,
            DRAW_BUFFER3 = 0x8828,
            BOOL_VEC4 = 0x8B59,
            BOOL_VEC3 = 0x8B58,
            BOOL_VEC2 = 0x8B57,
        }

        public enum ARB_multitexture : uint
        {
            TEXTURE13_ARB = 0x84CD,
            TEXTURE7_ARB = 0x84C7,
            TEXTURE21_ARB = 0x84D5,
            TEXTURE24_ARB = 0x84D8,
            TEXTURE19_ARB = 0x84D3,
            TEXTURE5_ARB = 0x84C5,
            TEXTURE16_ARB = 0x84D0,
            TEXTURE27_ARB = 0x84DB,
            TEXTURE17_ARB = 0x84D1,
            MAX_TEXTURE_UNITS_ARB = 0x84E2,
            TEXTURE2_ARB = 0x84C2,
            TEXTURE20_ARB = 0x84D4,
            TEXTURE31_ARB = 0x84DF,
            TEXTURE12_ARB = 0x84CC,
            TEXTURE18_ARB = 0x84D2,
            TEXTURE15_ARB = 0x84CF,
            TEXTURE10_ARB = 0x84CA,
            ACTIVE_TEXTURE_ARB = 0x84E0,
            TEXTURE23_ARB = 0x84D7,
            TEXTURE0_ARB = 0x84C0,
            TEXTURE29_ARB = 0x84DD,
            TEXTURE26_ARB = 0x84DA,
            TEXTURE8_ARB = 0x84C8,
            TEXTURE3_ARB = 0x84C3,
            TEXTURE30_ARB = 0x84DE,
            TEXTURE11_ARB = 0x84CB,
            TEXTURE9_ARB = 0x84C9,
            CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1,
            TEXTURE14_ARB = 0x84CE,
            TEXTURE6_ARB = 0x84C6,
            TEXTURE22_ARB = 0x84D6,
            TEXTURE28_ARB = 0x84DC,
            TEXTURE25_ARB = 0x84D9,
            TEXTURE1_ARB = 0x84C1,
            TEXTURE4_ARB = 0x84C4,
        }

        public enum EXT_histogram : uint
        {
            HISTOGRAM_WIDTH = 0x8026,
            PROXY_HISTOGRAM = 0x8025,
            MINMAX_EXT = 0x802E,
            MINMAX_SINK_EXT = 0x8030,
            MINMAX_FORMAT_EXT = 0x802F,
            HISTOGRAM_BLUE_SIZE = 0x802A,
            HISTOGRAM_SINK_EXT = 0x802D,
            HISTOGRAM_LUMINANCE_SIZE = 0x802C,
            HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C,
            HISTOGRAM_EXT = 0x8024,
            HISTOGRAM_ALPHA_SIZE = 0x802B,
            HISTOGRAM_FORMAT_EXT = 0x8027,
            HISTOGRAM_RED_SIZE_EXT = 0x8028,
            MINMAX = 0x802E,
            MINMAX_SINK = 0x8030,
            PROXY_HISTOGRAM_EXT = 0x8025,
            HISTOGRAM_RED_SIZE = 0x8028,
            HISTOGRAM_ALPHA_SIZE_EXT = 0x802B,
            HISTOGRAM_BLUE_SIZE_EXT = 0x802A,
            MINMAX_FORMAT = 0x802F,
            HISTOGRAM_WIDTH_EXT = 0x8026,
            HISTOGRAM_FORMAT = 0x8027,
            TABLE_TOO_LARGE = 0x8031,
            HISTOGRAM_SINK = 0x802D,
            HISTOGRAM_GREEN_SIZE_EXT = 0x8029,
            TABLE_TOO_LARGE_EXT = 0x8031,
            HISTOGRAM = 0x8024,
            HISTOGRAM_GREEN_SIZE = 0x8029,
        }

        public enum PixelFormat : uint
        {
            CMYK_EXT = EXT_cmyka.CMYK_EXT,
            YCRCB_444_SGIX = SGIX_ycrcb.YCRCB_444_SGIX,
            R5_G6_B5_ICC_SGIX = SGIX_icc_texture.R5_G6_B5_ICC_SGIX,
            ALPHA = 0x1906,
            RGBA = 0x1908,
            GREEN = 0x1904,
            R5_G6_B5_A8_ICC_SGIX = SGIX_icc_texture.R5_G6_B5_A8_ICC_SGIX,
            LUMINANCE_ALPHA = 0x190A,
            STENCIL_INDEX = 0x1901,
            RED = 0x1903,
            BLUE = 0x1905,
            CMYKA_EXT = EXT_cmyka.CMYKA_EXT,
            ALPHA16_ICC_SGIX = SGIX_icc_texture.ALPHA16_ICC_SGIX,
            LUMINANCE = 0x1909,
            LUMINANCE16_ALPHA8_ICC_SGIX = SGIX_icc_texture.LUMINANCE16_ALPHA8_ICC_SGIX,
            YCRCB_422_SGIX = SGIX_ycrcb.YCRCB_422_SGIX,
            ABGR_EXT = EXT_abgr.ABGR_EXT,
            COLOR_INDEX = 0x1900,
            RGB = 0x1907,
            LUMINANCE16_ICC_SGIX = SGIX_icc_texture.LUMINANCE16_ICC_SGIX,
            DEPTH_COMPONENT = 0x1902,
        }

        public enum NV_occlusion_query : uint
        {
            CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865,
            PIXEL_COUNT_NV = 0x8866,
            PIXEL_COUNTER_BITS_NV = 0x8864,
            PIXEL_COUNT_AVAILABLE_NV = 0x8867,
        }

        public enum MapTarget : uint
        {
            MAP2_COLOR_4 = GetPName.MAP2_COLOR_4,
            MAP1_TEXTURE_COORD_4 = GetPName.MAP1_TEXTURE_COORD_4,
            MAP2_VERTEX_3 = GetPName.MAP2_VERTEX_3,
            GEOMETRY_DEFORMATION_SGIX = SGIX_polynomial_ffd.GEOMETRY_DEFORMATION_SGIX,
            MAP2_INDEX = GetPName.MAP2_INDEX,
            MAP1_TEXTURE_COORD_1 = GetPName.MAP1_TEXTURE_COORD_1,
            TEXTURE_DEFORMATION_SGIX = SGIX_polynomial_ffd.TEXTURE_DEFORMATION_SGIX,
            MAP2_TEXTURE_COORD_1 = GetPName.MAP2_TEXTURE_COORD_1,
            MAP2_TEXTURE_COORD_4 = GetPName.MAP2_TEXTURE_COORD_4,
            MAP1_TEXTURE_COORD_3 = GetPName.MAP1_TEXTURE_COORD_3,
            MAP1_INDEX = GetPName.MAP1_INDEX,
            MAP1_VERTEX_4 = GetPName.MAP1_VERTEX_4,
            MAP1_TEXTURE_COORD_2 = GetPName.MAP1_TEXTURE_COORD_2,
            MAP2_TEXTURE_COORD_2 = GetPName.MAP2_TEXTURE_COORD_2,
            MAP1_VERTEX_3 = GetPName.MAP1_VERTEX_3,
            MAP1_COLOR_4 = GetPName.MAP1_COLOR_4,
            MAP2_NORMAL = GetPName.MAP2_NORMAL,
            MAP2_VERTEX_4 = GetPName.MAP2_VERTEX_4,
            MAP2_TEXTURE_COORD_3 = GetPName.MAP2_TEXTURE_COORD_3,
            MAP1_NORMAL = GetPName.MAP1_NORMAL,
        }

        public enum ListParameterName : uint
        {
            LIST_PRIORITY_SGIX = SGIX_list_priority.LIST_PRIORITY_SGIX,
        }

        public enum SGIX_vertex_preclip : uint
        {
            VERTEX_PRECLIP_HINT_SGIX = 0x83EF,
            VERTEX_PRECLIP_SGIX = 0x83EE,
        }

        public enum PixelStoreSubsampleRate : uint
        {
            PIXEL_SUBSAMPLE_2424_SGIX = SGIX_subsample.PIXEL_SUBSAMPLE_2424_SGIX,
            PIXEL_SUBSAMPLE_4444_SGIX = SGIX_subsample.PIXEL_SUBSAMPLE_4444_SGIX,
            PIXEL_SUBSAMPLE_4242_SGIX = SGIX_subsample.PIXEL_SUBSAMPLE_4242_SGIX,
        }

        public enum SUN_convolution_border_modes : uint
        {
            WRAP_BORDER_SUN = 0x81D4,
        }

        public enum SGIS_generate_mipmap : uint
        {
            GENERATE_MIPMAP_HINT = 0x8192,
            TEXTURE_DEFORMATION_SGIX = 0x8195,
            GENERATE_MIPMAP = 0x8191,
            GEOMETRY_DEFORMATION_SGIX = 0x8194,
            GENERATE_MIPMAP_HINT_SGIS = 0x8192,
            GENERATE_MIPMAP_SGIS = 0x8191,
            DEFORMATIONS_MASK_SGIX = 0x8196,
            MAX_DEFORMATION_ORDER_SGIX = 0x8197,
        }

        public enum EXT_index_array_formats : uint
        {
            IUI_N3F_V2F_EXT = 0x81AF,
            T2F_IUI_V3F_EXT = 0x81B2,
            T2F_IUI_V2F_EXT = 0x81B1,
            IUI_N3F_V3F_EXT = 0x81B0,
            T2F_IUI_N3F_V3F_EXT = 0x81B4,
            T2F_IUI_N3F_V2F_EXT = 0x81B3,
            IUI_V3F_EXT = 0x81AE,
            IUI_V2F_EXT = 0x81AD,
        }

        public enum BlendEquationModeEXT : uint
        {
            MAX_EXT = EXT_blend_minmax.MAX_EXT,
            LOGIC_OP = GetPName.LOGIC_OP,
            FUNC_ADD_EXT = EXT_blend_minmax.FUNC_ADD_EXT,
            FUNC_SUBTRACT_EXT = EXT_blend_subtract.FUNC_SUBTRACT_EXT,
            ALPHA_MAX_SGIX = SGIX_blend_alpha_minmax.ALPHA_MAX_SGIX,
            FUNC_REVERSE_SUBTRACT_EXT = EXT_blend_subtract.FUNC_REVERSE_SUBTRACT_EXT,
            ALPHA_MIN_SGIX = SGIX_blend_alpha_minmax.ALPHA_MIN_SGIX,
            MIN_EXT = EXT_blend_minmax.MIN_EXT,
        }

        public enum ARB_texture_env_combine : uint
        {
            SOURCE2_RGB_ARB = 0x8582,
            OPERAND0_ALPHA_ARB = 0x8598,
            COMBINE_ARB = 0x8570,
            SOURCE1_RGB_ARB = 0x8581,
            ADD_SIGNED_ARB = 0x8574,
            SUBTRACT_ARB = 0x84E7,
            PRIMARY_COLOR_ARB = 0x8577,
            SOURCE2_ALPHA_ARB = 0x858A,
            OPERAND1_RGB_ARB = 0x8591,
            OPERAND0_RGB_ARB = 0x8590,
            OPERAND2_ALPHA_ARB = 0x859A,
            CONSTANT_ARB = 0x8576,
            SOURCE0_ALPHA_ARB = 0x8588,
            INTERPOLATE_ARB = 0x8575,
            PREVIOUS_ARB = 0x8578,
            OPERAND2_RGB_ARB = 0x8592,
            COMBINE_RGB_ARB = 0x8571,
            SOURCE1_ALPHA_ARB = 0x8589,
            SOURCE0_RGB_ARB = 0x8580,
            COMBINE_ALPHA_ARB = 0x8572,
            OPERAND1_ALPHA_ARB = 0x8599,
            RGB_SCALE_ARB = 0x8573,
        }

        public enum EXT_index_func : uint
        {
            INDEX_TEST_FUNC_EXT = 0x81B6,
            INDEX_TEST_EXT = 0x81B5,
            INDEX_TEST_REF_EXT = 0x81B7,
        }

        public enum ATI_pn_triangles : uint
        {
            PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4,
            PN_TRIANGLES_POINT_MODE_ATI = 0x87F2,
            PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8,
            PN_TRIANGLES_ATI = 0x87F0,
            PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7,
            PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6,
            PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3,
            MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1,
            PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5,
        }

        public enum HP_image_transform : uint
        {
            IMAGE_TRANSFORM_2D_HP = 0x8161,
            IMAGE_MIN_FILTER_HP = 0x815D,
            IMAGE_TRANSLATE_Y_HP = 0x8158,
            IMAGE_TRANSLATE_X_HP = 0x8157,
            AVERAGE_HP = 0x8160,
            POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162,
            IMAGE_SCALE_Y_HP = 0x8156,
            IMAGE_SCALE_X_HP = 0x8155,
            CUBIC_HP = 0x815F,
            IMAGE_MAG_FILTER_HP = 0x815C,
            IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B,
            IMAGE_ROTATE_ORIGIN_X_HP = 0x815A,
            PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163,
            IMAGE_CUBIC_WEIGHT_HP = 0x815E,
            IMAGE_ROTATE_ANGLE_HP = 0x8159,
        }

        public enum NV_half_float : uint
        {
            HALF_FLOAT_NV = 0x140B,
        }

        public enum APPLE_vertex_array_range : uint
        {
            STORAGE_SHARED_APPLE = 0x85BF,
            VERTEX_ARRAY_RANGE_APPLE = 0x851D,
            VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F,
            VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E,
            VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521,
            STORAGE_CACHED_APPLE = 0x85BE,
        }

        public enum EXT_secondary_color : uint
        {
            SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A,
            SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D,
            SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C,
            SECONDARY_COLOR_ARRAY_EXT = 0x845E,
            COLOR_SUM_EXT = 0x8458,
            SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B,
            CURRENT_SECONDARY_COLOR_EXT = 0x8459,
        }

        public enum NV_texture_expand_normal : uint
        {
            TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F,
        }

        public enum EXT_422_pixels : uint
        {
            _422_REV_EXT = 0x80CD,
            _422_EXT = 0x80CC,
            _422_REV_AVERAGE_EXT = 0x80CF,
            _422_AVERAGE_EXT = 0x80CE,
        }

        public enum ARB_fragment_shader : uint
        {
            MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49,
            FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B,
            FRAGMENT_SHADER_ARB = 0x8B30,
        }

        public enum TexCoordPointerType : uint
        {
            DOUBLE = DataType.DOUBLE,
            INT = DataType.INT,
            SHORT = DataType.SHORT,
            FLOAT = DataType.FLOAT,
        }

        public enum ClearBufferMask : uint
        {
            STENCIL_BUFFER_BIT = AttribMask.STENCIL_BUFFER_BIT,
            ACCUM_BUFFER_BIT = AttribMask.ACCUM_BUFFER_BIT,
            COLOR_BUFFER_BIT = AttribMask.COLOR_BUFFER_BIT,
            DEPTH_BUFFER_BIT = AttribMask.DEPTH_BUFFER_BIT,
        }

        public enum SGIX_ycrcb : uint
        {
            YCRCB_422_SGIX = 0x81BB,
            YCRCB_444_SGIX = 0x81BC,
        }

        public enum EXT_rescale_normal : uint
        {
            RESCALE_NORMAL_EXT = 0x803A,
            RESCALE_NORMAL = 0x803A,
        }

        public enum ARB_fragment_program : uint
        {
            MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E,
            PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805,
            MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C,
            MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810,
            MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B,
            MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872,
            MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F,
            MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D,
            PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809,
            PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806,
            PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807,
            PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A,
            FRAGMENT_PROGRAM_ARB = 0x8804,
            PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808,
            MAX_TEXTURE_COORDS_ARB = 0x8871,
        }

        public enum SGIX_shadow_ambient : uint
        {
            SHADOW_AMBIENT_SGIX = 0x80BF,
        }

        public enum SUN_global_alpha : uint
        {
            GLOBAL_ALPHA_SUN = 0x81D9,
            GLOBAL_ALPHA_FACTOR_SUN = 0x81DA,
        }

        public enum EXT_blend_minmax : uint
        {
            MAX_EXT = 0x8008,
            BLEND_EQUATION_EXT = 0x8009,
            MIN = 0x8007,
            FUNC_ADD_EXT = 0x8006,
            FUNC_ADD = 0x8006,
            MAX = 0x8008,
            MIN_EXT = 0x8007,
            BLEND_EQUATION = 0x8009,
        }

        public enum EXT_packed_pixels : uint
        {
            UNSIGNED_BYTE_3_3_2 = 0x8032,
            UNSIGNED_INT_2_10_10_10_REV = 0x8368,
            UNSIGNED_INT_10_10_10_2 = 0x8036,
            UNSIGNED_SHORT_4_4_4_4_REV = 0x8365,
            UNSIGNED_SHORT_5_6_5_REV_EXT = 0x8364,
            UNSIGNED_INT_8_8_8_8 = 0x8035,
            UNSIGNED_SHORT_5_6_5 = 0x8363,
            UNSIGNED_INT_8_8_8_8_REV = 0x8367,
            UNSIGNED_SHORT_1_5_5_5_REV = 0x8366,
            UNSIGNED_INT_8_8_8_8_EXT = 0x8035,
            UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366,
            UNSIGNED_SHORT_5_6_5_REV = 0x8364,
            UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365,
            UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368,
            UNSIGNED_BYTE_2_3_3_REV = 0x8362,
            UNSIGNED_BYTE_2_3_3_REV_EXT = 0x8362,
            UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033,
            UNSIGNED_INT_10_10_10_2_EXT = 0x8036,
            UNSIGNED_SHORT_5_6_5_EXT = 0x8363,
            UNSIGNED_SHORT_5_5_5_1 = 0x8034,
            UNSIGNED_INT_8_8_8_8_REV_EXT = 0x8367,
            UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034,
            UNSIGNED_BYTE_3_3_2_EXT = 0x8032,
            UNSIGNED_SHORT_4_4_4_4 = 0x8033,
        }

        public enum LightEnvParameterSGIX : uint
        {
            LIGHT_ENV_MODE_SGIX = SGIX_fragment_lighting.LIGHT_ENV_MODE_SGIX,
        }

        public enum NV_primitive_restart : uint
        {
            PRIMITIVE_RESTART_NV = 0x8558,
            PRIMITIVE_RESTART_INDEX_NV = 0x8559,
        }

        public enum EXT_blend_color : uint
        {
            CONSTANT_COLOR_EXT = 0x8001,
            CONSTANT_ALPHA = 0x8003,
            BLEND_COLOR_EXT = 0x8005,
            CONSTANT_ALPHA_EXT = 0x8003,
            ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002,
            ONE_MINUS_CONSTANT_COLOR = 0x8002,
            ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004,
            CONSTANT_COLOR = 0x8001,
            BLEND_COLOR = 0x8005,
            ONE_MINUS_CONSTANT_ALPHA = 0x8004,
        }

        public enum INTEL_texture_scissor : uint
        {
        }

        public enum PixelTexGenMode : uint
        {
            RGB = PixelFormat.RGB,
            NONE = DrawBufferMode.NONE,
            LUMINANCE = PixelFormat.LUMINANCE,
            PIXEL_TEX_GEN_ALPHA_MS_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_ALPHA_MS_SGIX,
            PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX,
            PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX,
            LUMINANCE_ALPHA = PixelFormat.LUMINANCE_ALPHA,
            PIXEL_TEX_GEN_ALPHA_LS_SGIX = SGIX_impact_pixel_texture.PIXEL_TEX_GEN_ALPHA_LS_SGIX,
            RGBA = PixelFormat.RGBA,
        }

        public enum NV_light_max_exponent : uint
        {
            MAX_SPOT_EXPONENT_NV = 0x8505,
            MAX_SHININESS_NV = 0x8504,
        }

        public enum SGIX_icc_texture : uint
        {
            RGBA_ICC_SGIX = 0x8461,
            INTENSITY_ICC_SGIX = 0x8464,
            ALPHA_ICC_SGIX = 0x8462,
            LUMINANCE_ICC_SGIX = 0x8463,
            LUMINANCE16_ICC_SGIX = 0x8469,
            R5_G6_B5_ICC_SGIX = 0x8466,
            ALPHA16_ICC_SGIX = 0x8468,
            INTENSITY16_ICC_SGIX = 0x846A,
            RGB_ICC_SGIX = 0x8460,
            LUMINANCE_ALPHA_ICC_SGIX = 0x8465,
            R5_G6_B5_A8_ICC_SGIX = 0x8467,
            LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B,
        }

        public enum ARB_texture_float : uint
        {
            TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14,
            TEXTURE_BLUE_TYPE_ARB = 0x8C12,
            LUMINANCE_ALPHA32F_ARB = 0x8819,
            TEXTURE_DEPTH_TYPE_ARB = 0x8C16,
            RGB32F_ARB = 0x8815,
            LUMINANCE16F_ARB = 0x881E,
            TEXTURE_RED_TYPE_ARB = 0x8C10,
            TEXTURE_GREEN_TYPE_ARB = 0x8C11,
            ALPHA16F_ARB = 0x881C,
            TEXTURE_INTENSITY_TYPE_ARB = 0x8C15,
            INTENSITY32F_ARB = 0x8817,
            TEXTURE_ALPHA_TYPE_ARB = 0x8C13,
            INTENSITY16F_ARB = 0x881D,
            LUMINANCE32F_ARB = 0x8818,
            LUMINANCE_ALPHA16F_ARB = 0x881F,
            RGBA16F_ARB = 0x881A,
            RGB16F_ARB = 0x881B,
            ALPHA32F_ARB = 0x8816,
            UNSIGNED_NORMALIZED_ARB = 0x8C17,
            RGBA32F_ARB = 0x8814,
        }

        public enum FogMode : uint
        {
            EXP2 = 0x0801,
            EXP = 0x0800,
            LINEAR = TextureMagFilter.LINEAR,
            FOG_FUNC_SGIS = SGIS_fog_function.FOG_FUNC_SGIS,
        }

        public enum ColorTableParameterPNameSGI : uint
        {
            COLOR_TABLE_SCALE_SGI = SGI_color_table.COLOR_TABLE_SCALE_SGI,
            COLOR_TABLE_BIAS_SGI = SGI_color_table.COLOR_TABLE_BIAS_SGI,
        }

        public enum SGIX_calligraphic_fragment : uint
        {
            CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183,
        }

        public enum SGIS_texture_border_clamp : uint
        {
            CLAMP_TO_BORDER_SGIS = 0x812D,
            CLAMP_TO_BORDER_ARB = 0x812D,
            CLAMP_TO_BORDER = 0x812D,
        }

        public enum ARB_texture_env_dot3 : uint
        {
            DOT3_RGB_ARB = 0x86AE,
            DOT3_RGBA_ARB = 0x86AF,
        }

        public enum HintTarget : uint
        {
            GENERATE_MIPMAP_HINT_SGIS = SGIS_generate_mipmap.GENERATE_MIPMAP_HINT_SGIS,
            POLYGON_SMOOTH_HINT = GetPName.POLYGON_SMOOTH_HINT,
            VERTEX_PRECLIP_HINT_SGIX = SGIX_vertex_preclip.VERTEX_PRECLIP_HINT_SGIX,
            LINE_SMOOTH_HINT = GetPName.LINE_SMOOTH_HINT,
            POINT_SMOOTH_HINT = GetPName.POINT_SMOOTH_HINT,
            PERSPECTIVE_CORRECTION_HINT = GetPName.PERSPECTIVE_CORRECTION_HINT,
            UNPACK_CMYK_HINT_EXT = EXT_cmyka.UNPACK_CMYK_HINT_EXT,
            FOG_HINT = GetPName.FOG_HINT,
            CONVOLUTION_HINT_SGIX = SGIX_convolution_accuracy.CONVOLUTION_HINT_SGIX,
            TEXTURE_MULTI_BUFFER_HINT_SGIX = SGIX_texture_multi_buffer.TEXTURE_MULTI_BUFFER_HINT_SGIX,
            PACK_CMYK_HINT_EXT = EXT_cmyka.PACK_CMYK_HINT_EXT,
        }

        public enum MESA_resize_buffers : uint
        {
        }

        public enum VERSION_1_4 : uint
        {
            DECR_WRAP = 0x8508,
            GENERATE_MIPMAP = 0x8191,
            FRAGMENT_DEPTH = 0x8452,
            MAX_TEXTURE_LOD_BIAS = 0x84FD,
            FOG_COORDINATE_ARRAY = 0x8457,
            BLEND_DST_RGB = 0x80C8,
            GENERATE_MIPMAP_HINT = 0x8192,
            BLEND_SRC_ALPHA = 0x80CB,
            TEXTURE_COMPARE_MODE = 0x884C,
            FOG_COORDINATE_ARRAY_STRIDE = 0x8455,
            TEXTURE_FILTER_CONTROL = 0x8500,
            DEPTH_COMPONENT24 = 0x81A6,
            FOG_COORDINATE_SOURCE = 0x8450,
            POINT_SIZE_MAX = 0x8127,
            POINT_DISTANCE_ATTENUATION = 0x8129,
            SECONDARY_COLOR_ARRAY_SIZE = 0x845A,
            DEPTH_TEXTURE_MODE = 0x884B,
            DEPTH_COMPONENT16 = 0x81A5,
            FOG_COORDINATE_ARRAY_TYPE = 0x8454,
            MIRRORED_REPEAT = 0x8370,
            CURRENT_SECONDARY_COLOR = 0x8459,
            SECONDARY_COLOR_ARRAY_POINTER = 0x845D,
            SECONDARY_COLOR_ARRAY_STRIDE = 0x845C,
            DEPTH_COMPONENT32 = 0x81A7,
            TEXTURE_COMPARE_FUNC = 0x884D,
            TEXTURE_DEPTH_SIZE = 0x884A,
            BLEND_DST_ALPHA = 0x80CA,
            CURRENT_FOG_COORDINATE = 0x8453,
            POINT_FADE_THRESHOLD_SIZE = 0x8128,
            COMPARE_R_TO_TEXTURE = 0x884E,
            TEXTURE_LOD_BIAS = 0x8501,
            FOG_COORDINATE_ARRAY_POINTER = 0x8456,
            BLEND_SRC_RGB = 0x80C9,
            COLOR_SUM = 0x8458,
            FOG_COORDINATE = 0x8451,
            SECONDARY_COLOR_ARRAY_TYPE = 0x845B,
            POINT_SIZE_MIN = 0x8126,
            INCR_WRAP = 0x8507,
            SECONDARY_COLOR_ARRAY = 0x845E,
        }

        public enum LightName : uint
        {
            FRAGMENT_LIGHT4_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT4_SGIX,
            FRAGMENT_LIGHT5_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT5_SGIX,
            LIGHT4 = 0x4004,
            LIGHT3 = 0x4003,
            FRAGMENT_LIGHT7_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT7_SGIX,
            LIGHT6 = 0x4006,
            FRAGMENT_LIGHT1_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT1_SGIX,
            LIGHT5 = 0x4005,
            LIGHT0 = 0x4000,
            FRAGMENT_LIGHT3_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT3_SGIX,
            FRAGMENT_LIGHT2_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT2_SGIX,
            LIGHT7 = 0x4007,
            LIGHT2 = 0x4002,
            FRAGMENT_LIGHT0_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT0_SGIX,
            LIGHT1 = 0x4001,
            FRAGMENT_LIGHT6_SGIX = SGIX_fragment_lighting.FRAGMENT_LIGHT6_SGIX,
        }

        public enum SGIS_point_parameters : uint
        {
            POINT_SIZE_MIN_SGIS = 0x8126,
            POINT_SIZE_MAX_SGIS = 0x8127,
            POINT_DISTANCE_ATTENUATION = 0x8129,
            DISTANCE_ATTENUATION_EXT = 0x8129,
            POINT_FADE_THRESHOLD_SIZE = 0x8128,
            POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128,
            POINT_SIZE_MIN_EXT = 0x8126,
            POINT_SIZE_MAX = 0x8127,
            POINT_DISTANCE_ATTENUATION_ARB = 0x8129,
            POINT_SIZE_MIN = 0x8126,
            POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128,
            DISTANCE_ATTENUATION_SGIS = 0x8129,
            POINT_SIZE_MAX_EXT = 0x8127,
            POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128,
            POINT_SIZE_MAX_ARB = 0x8127,
            POINT_SIZE_MIN_ARB = 0x8126,
        }

        public enum ARB_texture_env_add : uint
        {
        }

        public enum EXT_color_subtable : uint
        {
        }

        public enum MESA_ycbcr_texture : uint
        {
            UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB,
            YCBCR_MESA = 0x8757,
            UNSIGNED_SHORT_8_8_MESA = 0x85BA,
        }

        public enum SGIX_shadow : uint
        {
            TEXTURE_LEQUAL_R_SGIX = 0x819C,
            TEXTURE_COMPARE_SGIX = 0x819A,
            TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B,
            TEXTURE_GEQUAL_R_SGIX = 0x819D,
        }

        public enum EXT_pixel_buffer_object : uint
        {
            PIXEL_UNPACK_BUFFER_EXT = 0x88EC,
            PIXEL_PACK_BUFFER_EXT = 0x88EB,
            PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF,
            PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED,
        }

        public enum EXT_texture_object : uint
        {
            TEXTURE_2D_BINDING_EXT = 0x8069,
            TEXTURE_1D_BINDING_EXT = 0x8068,
            TEXTURE_PRIORITY_EXT = 0x8066,
            TEXTURE_3D_BINDING_EXT = 0x806A,
            TEXTURE_RESIDENT_EXT = 0x8067,
        }

        public enum EXT_texture_filter_anisotropic : uint
        {
            TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE,
            MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF,
        }

        public enum SGIS_multisample : uint
        {
            SAMPLE_PATTERN_SGIS = 0x80AC,
            _1PASS_SGIS = 0x80A1,
            _2PASS_1_SGIS = 0x80A3,
            _2PASS_0_SGIS = 0x80A2,
            _4PASS_3_SGIS = 0x80A7,
            _4PASS_0_SGIS = 0x80A4,
            SAMPLE_MASK_SGIS = 0x80A0,
            _4PASS_1_SGIS = 0x80A5,
            SAMPLES_SGIS = 0x80A9,
            MULTISAMPLE_SGIS = 0x809D,
            SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E,
            _4PASS_2_SGIS = 0x80A6,
            SAMPLE_MASK_INVERT_SGIS = 0x80AB,
            SAMPLE_BUFFERS_SGIS = 0x80A8,
            SAMPLE_MASK_VALUE_SGIS = 0x80AA,
            SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F,
        }

        public enum GetPixelMap : uint
        {
            PIXEL_MAP_B_TO_B = 0x0C78,
            PIXEL_MAP_S_TO_S = 0x0C71,
            PIXEL_MAP_R_TO_R = 0x0C76,
            PIXEL_MAP_I_TO_B = 0x0C74,
            PIXEL_MAP_I_TO_G = 0x0C73,
            PIXEL_MAP_I_TO_A = 0x0C75,
            PIXEL_MAP_A_TO_A = 0x0C79,
            PIXEL_MAP_G_TO_G = 0x0C77,
            PIXEL_MAP_I_TO_I = 0x0C70,
            PIXEL_MAP_I_TO_R = 0x0C72,
        }

        public enum EXT_pixel_transform : uint
        {
            PIXEL_MIN_FILTER_EXT = 0x8332,
            PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336,
            PIXEL_TRANSFORM_2D_EXT = 0x8330,
            MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337,
            CUBIC_EXT = 0x8334,
            PIXEL_CUBIC_WEIGHT_EXT = 0x8333,
            AVERAGE_EXT = 0x8335,
            PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338,
            PIXEL_MAG_FILTER_EXT = 0x8331,
        }

        public enum PGI_vertex_hints : uint
        {
            MAT_SPECULAR_BIT_PGI = 0x04000000,
            TEXCOORD2_BIT_PGI = 0x20000000,
            VERTEX_CONSISTENT_HINT_PGI = 0x1A22B,
            MAT_SHININESS_BIT_PGI = 0x02000000,
            MAT_AMBIENT_BIT_PGI = 0x00100000,
            MATERIAL_SIDE_HINT_PGI = 0x1A22C,
            TEXCOORD3_BIT_PGI = 0x40000000,
            TEXCOORD4_BIT_PGI = 0x80000000,
            MAT_COLOR_INDEXES_BIT_PGI = 0x01000000,
            MAX_VERTEX_HINT_PGI = 0x1A22D,
            VERTEX23_BIT_PGI = 0x00000004,
            TEXCOORD1_BIT_PGI = 0x10000000,
            INDEX_BIT_PGI = 0x00080000,
            EDGEFLAG_BIT_PGI = 0x00040000,
            COLOR3_BIT_PGI = 0x00010000,
            VERTEX_DATA_HINT_PGI = 0x1A22A,
            MAT_DIFFUSE_BIT_PGI = 0x00400000,
            NORMAL_BIT_PGI = 0x08000000,
            MAT_EMISSION_BIT_PGI = 0x00800000,
            COLOR4_BIT_PGI = 0x00020000,
            VERTEX4_BIT_PGI = 0x00000008,
            MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000,
        }

        public enum LightModelParameter : uint
        {
            LIGHT_MODEL_LOCAL_VIEWER = GetPName.LIGHT_MODEL_LOCAL_VIEWER,
            LIGHT_MODEL_COLOR_CONTROL = VERSION_1_2.LIGHT_MODEL_COLOR_CONTROL,
            LIGHT_MODEL_AMBIENT = GetPName.LIGHT_MODEL_AMBIENT,
            LIGHT_MODEL_TWO_SIDE = GetPName.LIGHT_MODEL_TWO_SIDE,
        }

        public enum NV_texgen_emboss : uint
        {
            EMBOSS_CONSTANT_NV = 0x855E,
            EMBOSS_LIGHT_NV = 0x855D,
            EMBOSS_MAP_NV = 0x855F,
        }

        public enum NV_register_combiners : uint
        {
            COMBINER_MAPPING_NV = 0x8543,
            SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532,
            COMBINER_CD_OUTPUT_NV = 0x854B,
            ZERO = BlendingFactorDest.ZERO,
            COMBINER_INPUT_NV = 0x8542,
            COMBINER5_NV = 0x8555,
            SIGNED_NEGATE_NV = 0x853D,
            COMBINER_SUM_OUTPUT_NV = 0x854C,
            SCALE_BY_TWO_NV = 0x853E,
            REGISTER_COMBINERS_NV = 0x8522,
            COMBINER6_NV = 0x8556,
            SCALE_BY_FOUR_NV = 0x853F,
            E_TIMES_F_NV = 0x8531,
            PRIMARY_COLOR_NV = 0x852C,
            COMBINER2_NV = 0x8552,
            COMBINER3_NV = 0x8553,
            COMBINER0_NV = 0x8550,
            COMBINER1_NV = 0x8551,
            VARIABLE_F_NV = 0x8528,
            FOG = GetPName.FOG,
            SIGNED_IDENTITY_NV = 0x853C,
            SECONDARY_COLOR_NV = 0x852D,
            SCALE_BY_ONE_HALF_NV = 0x8540,
            COMBINER_AB_OUTPUT_NV = 0x854A,
            NONE = DrawBufferMode.NONE,
            CONSTANT_COLOR0_NV = 0x852A,
            COMBINER_CD_DOT_PRODUCT_NV = 0x8546,
            TEXTURE0_ARB = ARB_multitexture.TEXTURE0_ARB,
            UNSIGNED_INVERT_NV = 0x8537,
            NUM_GENERAL_COMBINERS_NV = 0x854E,
            COMBINER_BIAS_NV = 0x8549,
            VARIABLE_B_NV = 0x8524,
            EXPAND_NORMAL_NV = 0x8538,
            VARIABLE_C_NV = 0x8525,
            HALF_BIAS_NORMAL_NV = 0x853A,
            COMBINER_COMPONENT_USAGE_NV = 0x8544,
            COMBINER_SCALE_NV = 0x8548,
            VARIABLE_A_NV = 0x8523,
            HALF_BIAS_NEGATE_NV = 0x853B,
            DISCARD_NV = 0x8530,
            COMBINER_AB_DOT_PRODUCT_NV = 0x8545,
            UNSIGNED_IDENTITY_NV = 0x8536,
            EXPAND_NEGATE_NV = 0x8539,
            VARIABLE_D_NV = 0x8526,
            BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541,
            VARIABLE_E_NV = 0x8527,
            COMBINER_MUX_SUM_NV = 0x8547,
            MAX_GENERAL_COMBINERS_NV = 0x854D,
            COMBINER7_NV = 0x8557,
            COMBINER4_NV = 0x8554,
            COLOR_SUM_CLAMP_NV = 0x854F,
            TEXTURE1_ARB = ARB_multitexture.TEXTURE1_ARB,
            SPARE1_NV = 0x852F,
            CONSTANT_COLOR1_NV = 0x852B,
            SPARE0_NV = 0x852E,
            VARIABLE_G_NV = 0x8529,
        }

        public enum ARB_fragment_program_shadow : uint
        {
        }

        public enum NV_vertex_array_range2 : uint
        {
            VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533,
        }

        public enum ARB_texture_compression : uint
        {
            COMPRESSED_LUMINANCE_ARB = 0x84EA,
            COMPRESSED_INTENSITY_ARB = 0x84EC,
            TEXTURE_COMPRESSION_HINT_ARB = 0x84EF,
            TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0,
            COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3,
            COMPRESSED_RGB_ARB = 0x84ED,
            NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2,
            COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB,
            TEXTURE_COMPRESSED_ARB = 0x86A1,
            COMPRESSED_ALPHA_ARB = 0x84E9,
            COMPRESSED_RGBA_ARB = 0x84EE,
        }

        public enum EXT_separate_specular_color : uint
        {
            SINGLE_COLOR_EXT = 0x81F9,
            LIGHT_MODEL_COLOR_CONTROL = 0x81F8,
            SEPARATE_SPECULAR_COLOR_EXT = 0x81FA,
            LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8,
            SEPARATE_SPECULAR_COLOR = 0x81FA,
            SINGLE_COLOR = 0x81F9,
        }

        public enum ATI_envmap_bumpmap : uint
        {
            BUMP_TARGET_ATI = 0x877C,
            BUMP_ROT_MATRIX_ATI = 0x8775,
            DU8DV8_ATI = 0x877A,
            BUMP_NUM_TEX_UNITS_ATI = 0x8777,
            BUMP_ROT_MATRIX_SIZE_ATI = 0x8776,
            BUMP_ENVMAP_ATI = 0x877B,
            BUMP_TEX_UNITS_ATI = 0x8778,
            DUDV_ATI = 0x8779,
        }

        public enum EXT_blend_logic_op : uint
        {
        }

        public enum ColorMaterialFace : uint
        {
            BACK = DrawBufferMode.BACK,
            FRONT_AND_BACK = DrawBufferMode.FRONT_AND_BACK,
            FRONT = DrawBufferMode.FRONT,
        }

        public enum GetTextureParameter : uint
        {
            TEXTURE_CLIPMAP_FRAME_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_FRAME_SGIX,
            TEXTURE_WRAP_R_EXT = EXT_texture3D.TEXTURE_WRAP_R_EXT,
            TEXTURE_BORDER = 0x1005,
            TEXTURE_HEIGHT = 0x1001,
            TEXTURE_INTENSITY_SIZE = 0x8061,
            TEXTURE_CLIPMAP_CENTER_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_CENTER_SGIX,
            TEXTURE_WRAP_Q_SGIS = SGIS_texture4D.TEXTURE_WRAP_Q_SGIS,
            TEXTURE_FILTER4_SIZE_SGIS = SGIS_texture_filter4.TEXTURE_FILTER4_SIZE_SGIS,
            TEXTURE_MAX_CLAMP_R_SGIX = SGIX_texture_coordinate_clamp.TEXTURE_MAX_CLAMP_R_SGIX,
            TEXTURE_MAX_CLAMP_S_SGIX = SGIX_texture_coordinate_clamp.TEXTURE_MAX_CLAMP_S_SGIX,
            TEXTURE_PRIORITY = 0x8066,
            TEXTURE_RED_SIZE = 0x805C,
            TEXTURE_MIN_FILTER = TextureParameterName.TEXTURE_MIN_FILTER,
            TEXTURE_4DSIZE_SGIS = SGIS_texture4D.TEXTURE_4DSIZE_SGIS,
            TEXTURE_MIN_LOD_SGIS = SGIS_texture_lod.TEXTURE_MIN_LOD_SGIS,
            TEXTURE_WIDTH = 0x1000,
            TEXTURE_BLUE_SIZE = 0x805E,
            TEXTURE_WRAP_T = TextureParameterName.TEXTURE_WRAP_T,
            TEXTURE_MAX_LOD_SGIS = SGIS_texture_lod.TEXTURE_MAX_LOD_SGIS,
            POST_TEXTURE_FILTER_SCALE_SGIX = SGIX_texture_scale_bias.POST_TEXTURE_FILTER_SCALE_SGIX,
            TEXTURE_LOD_BIAS_R_SGIX = SGIX_texture_lod_bias.TEXTURE_LOD_BIAS_R_SGIX,
            TEXTURE_LOD_BIAS_S_SGIX = SGIX_texture_lod_bias.TEXTURE_LOD_BIAS_S_SGIX,
            TEXTURE_INTERNAL_FORMAT = 0x1003,
            TEXTURE_LUMINANCE_SIZE = 0x8060,
            TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX,
            DUAL_TEXTURE_SELECT_SGIS = SGIS_texture_select.DUAL_TEXTURE_SELECT_SGIS,
            TEXTURE_CLIPMAP_OFFSET_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_OFFSET_SGIX,
            TEXTURE_COMPONENTS = 0x1003,
            TEXTURE_COMPARE_OPERATOR_SGIX = SGIX_shadow.TEXTURE_COMPARE_OPERATOR_SGIX,
            TEXTURE_LEQUAL_R_SGIX = SGIX_shadow.TEXTURE_LEQUAL_R_SGIX,
            TEXTURE_GEQUAL_R_SGIX = SGIX_shadow.TEXTURE_GEQUAL_R_SGIX,
            TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_LOD_OFFSET_SGIX,
            DETAIL_TEXTURE_FUNC_POINTS_SGIS = SGIS_detail_texture.DETAIL_TEXTURE_FUNC_POINTS_SGIS,
            DETAIL_TEXTURE_MODE_SGIS = SGIS_detail_texture.DETAIL_TEXTURE_MODE_SGIS,
            TEXTURE_BORDER_COLOR = 0x1004,
            SHADOW_AMBIENT_SGIX = SGIX_shadow_ambient.SHADOW_AMBIENT_SGIX,
            TEXTURE_MAG_FILTER = TextureParameterName.TEXTURE_MAG_FILTER,
            TEXTURE_BASE_LEVEL_SGIS = SGIS_texture_lod.TEXTURE_BASE_LEVEL_SGIS,
            TEXTURE_GREEN_SIZE = 0x805D,
            TEXTURE_MAX_LEVEL_SGIS = SGIS_texture_lod.TEXTURE_MAX_LEVEL_SGIS,
            TEXTURE_WRAP_S = TextureParameterName.TEXTURE_WRAP_S,
            TEXTURE_RESIDENT = 0x8067,
            TEXTURE_LOD_BIAS_T_SGIX = SGIX_texture_lod_bias.TEXTURE_LOD_BIAS_T_SGIX,
            POST_TEXTURE_FILTER_BIAS_SGIX = SGIX_texture_scale_bias.POST_TEXTURE_FILTER_BIAS_SGIX,
            DETAIL_TEXTURE_LEVEL_SGIS = SGIS_detail_texture.DETAIL_TEXTURE_LEVEL_SGIS,
            TEXTURE_DEPTH_EXT = EXT_texture3D.TEXTURE_DEPTH_EXT,
            TEXTURE_MAX_CLAMP_T_SGIX = SGIX_texture_coordinate_clamp.TEXTURE_MAX_CLAMP_T_SGIX,
            TEXTURE_ALPHA_SIZE = 0x805F,
            TEXTURE_COMPARE_SGIX = SGIX_shadow.TEXTURE_COMPARE_SGIX,
            QUAD_TEXTURE_SELECT_SGIS = SGIS_texture_select.QUAD_TEXTURE_SELECT_SGIS,
            GENERATE_MIPMAP_SGIS = SGIS_generate_mipmap.GENERATE_MIPMAP_SGIS,
            SHARPEN_TEXTURE_FUNC_POINTS_SGIS = SGIS_sharpen_texture.SHARPEN_TEXTURE_FUNC_POINTS_SGIS,
            TEXTURE_CLIPMAP_DEPTH_SGIX = SGIX_clipmap.TEXTURE_CLIPMAP_DEPTH_SGIX,
        }

        public enum APPLE_transform_hint : uint
        {
            TRANSFORM_HINT_APPLE = 0x85B1,
        }

        public enum NV_texture_shader : uint
        {
            DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA,
            DS_SCALE_NV = 0x8710,
            DSDT_MAG_INTENSITY_NV = 0x86DC,
            SIGNED_HILO_NV = 0x86F9,
            DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9,
            OFFSET_TEXTURE_SCALE_NV = 0x86E2,
            MAGNITUDE_SCALE_NV = 0x8712,
            CULL_FRAGMENT_NV = 0x86E7,
            OFFSET_TEXTURE_2D_SCALE_NV = GL_OFFSET_TEXTURE_SCALE_NV,
            TEXTURE_DT_SIZE_NV = 0x871E,
            OFFSET_TEXTURE_2D_NV = 0x86E8,
            UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA,
            VIBRANCE_SCALE_NV = 0x8713,
            PREVIOUS_TEXTURE_INPUT_NV = 0x86E4,
            SIGNED_LUMINANCE_NV = 0x8701,
            DS_BIAS_NV = 0x8716,
            SIGNED_RGB8_NV = 0x86FF,
            DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1,
            DSDT8_MAG8_INTENSITY8_NV = 0x870B,
            VIBRANCE_BIAS_NV = 0x8719,
            SIGNED_ALPHA8_NV = 0x8706,
            LO_BIAS_NV = 0x8715,
            UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB,
            DOT_PRODUCT_NV = 0x86EC,
            DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE,
            SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D,
            DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E,
            DT_BIAS_NV = 0x8717,
            SIGNED_LUMINANCE_ALPHA_NV = 0x8703,
            OFFSET_TEXTURE_BIAS_NV = 0x86E3,
            OFFSET_TEXTURE_2D_MATRIX_NV = GL_OFFSET_TEXTURE_MATRIX_NV,
            HILO16_NV = 0x86F8,
            TEXTURE_BORDER_VALUES_NV = 0x871A,
            SIGNED_ALPHA_NV = 0x8705,
            OFFSET_TEXTURE_MATRIX_NV = 0x86E1,
            TEXTURE_SHADER_NV = 0x86DE,
            OFFSET_TEXTURE_RECTANGLE_NV = 0x864C,
            HI_BIAS_NV = 0x8714,
            DSDT8_NV = 0x8709,
            SHADER_CONSISTENT_NV = 0x86DD,
            DSDT_MAG_NV = 0x86F6,
            TEXTURE_LO_SIZE_NV = 0x871C,
            DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2,
            DSDT8_MAG8_NV = 0x870A,
            SIGNED_RGBA8_NV = 0x86FC,
            DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0,
            CULL_MODES_NV = 0x86E0,
            SIGNED_RGB_NV = 0x86FE,
            OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D,
            DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED,
            CONST_EYE_NV = 0x86E5,
            SIGNED_RGBA_NV = 0x86FB,
            RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9,
            SIGNED_INTENSITY8_NV = 0x8708,
            SHADER_OPERATION_NV = 0x86DF,
            PASS_THROUGH_NV = 0x86E6,
            DSDT_NV = 0x86F5,
            SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C,
            OFFSET_TEXTURE_2D_BIAS_NV = GL_OFFSET_TEXTURE_BIAS_NV,
            TEXTURE_MAG_SIZE_NV = 0x871F,
            SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704,
            SIGNED_HILO16_NV = 0x86FA,
            SIGNED_INTENSITY_NV = 0x8707,
            HILO_NV = 0x86F4,
            DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3,
            LO_SCALE_NV = 0x870F,
            MAGNITUDE_BIAS_NV = 0x8718,
            HI_SCALE_NV = 0x870E,
            TEXTURE_DS_SIZE_NV = 0x871D,
            DT_SCALE_NV = 0x8711,
            SIGNED_LUMINANCE8_NV = 0x8702,
            DSDT_MAG_VIB_NV = 0x86F7,
            TEXTURE_HI_SIZE_NV = 0x871B,
        }

        public enum EXT_cull_vertex : uint
        {
            CULL_VERTEX_EXT = 0x81AA,
            CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC,
            CULL_VERTEX_EYE_POSITION_EXT = 0x81AB,
        }

        public enum ARB_texture_border_clamp : uint
        {
            CLAMP_TO_BORDER_ARB = 0x812D,
        }

        public enum SGIX_clipmap : uint
        {
            TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175,
            NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E,
            LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170,
            TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172,
            NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D,
            TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174,
            MAX_CLIPMAP_DEPTH_SGIX = 0x8177,
            TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173,
            TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176,
            TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171,
            LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F,
            MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178,
        }

        public enum ConvolutionParameterEXT : uint
        {
            CONVOLUTION_FILTER_BIAS_EXT = EXT_convolution.CONVOLUTION_FILTER_BIAS_EXT,
            CONVOLUTION_BORDER_MODE_EXT = EXT_convolution.CONVOLUTION_BORDER_MODE_EXT,
            CONVOLUTION_FILTER_SCALE_EXT = EXT_convolution.CONVOLUTION_FILTER_SCALE_EXT,
        }

        public enum GetConvolutionParameter : uint
        {
            MAX_CONVOLUTION_WIDTH_EXT = EXT_convolution.MAX_CONVOLUTION_WIDTH_EXT,
            CONVOLUTION_FILTER_SCALE_EXT = EXT_convolution.CONVOLUTION_FILTER_SCALE_EXT,
            CONVOLUTION_BORDER_MODE_EXT = EXT_convolution.CONVOLUTION_BORDER_MODE_EXT,
            CONVOLUTION_HEIGHT_EXT = EXT_convolution.CONVOLUTION_HEIGHT_EXT,
            CONVOLUTION_WIDTH_EXT = EXT_convolution.CONVOLUTION_WIDTH_EXT,
            MAX_CONVOLUTION_HEIGHT_EXT = EXT_convolution.MAX_CONVOLUTION_HEIGHT_EXT,
            CONVOLUTION_FILTER_BIAS_EXT = EXT_convolution.CONVOLUTION_FILTER_BIAS_EXT,
            CONVOLUTION_FORMAT_EXT = EXT_convolution.CONVOLUTION_FORMAT_EXT,
        }

        public enum SGIX_tag_sample_buffer : uint
        {
        }

        public enum ClientAttribMask : uint
        {
            CLIENT_PIXEL_STORE_BIT = 0x00000001,
            CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF,
            CLIENT_VERTEX_ARRAY_BIT = 0x00000002,
        }

        public enum APPLE_specular_vector : uint
        {
            LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0,
        }

        public enum IBM_texture_mirrored_repeat : uint
        {
            MIRRORED_REPEAT_IBM = 0x8370,
        }

        public enum TextureCoordName : uint
        {
            Q = 0x2003,
            R = 0x2002,
            S = 0x2000,
            T = 0x2001,
        }

        public enum InterleavedArrayFormat : uint
        {
            T2F_C4UB_V3F = 0x2A29,
            T2F_N3F_V3F = 0x2A2B,
            T4F_V4F = 0x2A28,
            T2F_V3F = 0x2A27,
            V2F = 0x2A20,
            T2F_C4F_N3F_V3F = 0x2A2C,
            T4F_C4F_N3F_V4F = 0x2A2D,
            T2F_C3F_V3F = 0x2A2A,
            C3F_V3F = 0x2A24,
            C4F_N3F_V3F = 0x2A26,
            V3F = 0x2A21,
            N3F_V3F = 0x2A25,
            C4UB_V2F = 0x2A22,
            C4UB_V3F = 0x2A23,
        }

        public enum NV_texture_shader3 : uint
        {
            DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859,
            DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D,
            SIGNED_HILO8_NV = 0x885F,
            FORCE_BLUE_TO_ONE_NV = 0x8860,
            OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857,
            OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853,
            DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858,
            HILO8_NV = 0x885E,
            OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850,
            DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A,
            OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856,
            OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851,
            OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855,
            OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852,
            OFFSET_HILO_TEXTURE_2D_NV = 0x8854,
            DOT_PRODUCT_PASS_THROUGH_NV = 0x885B,
            DOT_PRODUCT_TEXTURE_1D_NV = 0x885C,
        }

        public enum ARB_vertex_buffer_object : uint
        {
            NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897,
            READ_ONLY_ARB = 0x88B8,
            STATIC_DRAW_ARB = 0x88E4,
            STATIC_COPY_ARB = 0x88E6,
            BUFFER_MAP_POINTER_ARB = 0x88BD,
            STREAM_COPY_ARB = 0x88E2,
            STATIC_READ_ARB = 0x88E5,
            READ_WRITE_ARB = 0x88BA,
            TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A,
            ARRAY_BUFFER_ARB = 0x8892,
            BUFFER_SIZE_ARB = 0x8764,
            BUFFER_ACCESS_ARB = 0x88BB,
            DYNAMIC_DRAW_ARB = 0x88E8,
            WRITE_ONLY_ARB = 0x88B9,
            VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896,
            FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D,
            DYNAMIC_READ_ARB = 0x88E9,
            DYNAMIC_COPY_ARB = 0x88EA,
            STREAM_DRAW_ARB = 0x88E0,
            WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E,
            STREAM_READ_ARB = 0x88E1,
            COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898,
            BUFFER_MAPPED_ARB = 0x88BC,
            INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899,
            ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895,
            EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B,
            VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F,
            ARRAY_BUFFER_BINDING_ARB = 0x8894,
            SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C,
            BUFFER_USAGE_ARB = 0x8765,
            ELEMENT_ARRAY_BUFFER_ARB = 0x8893,
        }

        public enum SGIX_pixel_tiles : uint
        {
            PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F,
            PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142,
            PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143,
            PIXEL_TILE_HEIGHT_SGIX = 0x8141,
            PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145,
            PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E,
            PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144,
            PIXEL_TILE_WIDTH_SGIX = 0x8140,
        }

        public enum SUNX_constant_data : uint
        {
            TEXTURE_CONSTANT_DATA_SUNX = 0x81D6,
            UNPACK_CONSTANT_DATA_SUNX = 0x81D5,
        }

        public enum ARB_shading_language_100 : uint
        {
            SHADING_LANGUAGE_VERSION_ARB = 0x8B8C,
        }

        public enum INGR_color_clamp : uint
        {
            BLUE_MIN_CLAMP_INGR = 0x8562,
            RED_MAX_CLAMP_INGR = 0x8564,
            ALPHA_MAX_CLAMP_INGR = 0x8567,
            ALPHA_MIN_CLAMP_INGR = 0x8563,
            GREEN_MAX_CLAMP_INGR = 0x8565,
            BLUE_MAX_CLAMP_INGR = 0x8566,
            GREEN_MIN_CLAMP_INGR = 0x8561,
            RED_MIN_CLAMP_INGR = 0x8560,
        }

        public enum SGIX_texture_scale_bias : uint
        {
            POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B,
            POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179,
            POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A,
            POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C,
        }

        public enum SGIX_fog_offset : uint
        {
            FOG_OFFSET_VALUE_SGIX = 0x8199,
            FOG_OFFSET_SGIX = 0x8198,
        }

        public enum EXT_texture : uint
        {
            LUMINANCE8_ALPHA8_EXT = 0x8045,
            RGBA12_EXT = 0x805A,
            INTENSITY12_EXT = 0x804C,
            RGB16_EXT = 0x8054,
            REPLACE_EXT = 0x8062,
            RGB5_A1_EXT = 0x8057,
            RGB5_EXT = 0x8050,
            TEXTURE_INTENSITY_SIZE_EXT = 0x8061,
            ALPHA12_EXT = 0x803D,
            RGB4_EXT = 0x804F,
            TEXTURE_LUMINANCE_SIZE_EXT = 0x8060,
            RGBA16_EXT = 0x805B,
            RGB8_EXT = 0x8051,
            RGBA8_EXT = 0x8058,
            RGB12_EXT = 0x8053,
            LUMINANCE12_ALPHA12_EXT = 0x8047,
            INTENSITY4_EXT = 0x804A,
            INTENSITY8_EXT = 0x804B,
            RGB10_A2_EXT = 0x8059,
            RGB10_EXT = 0x8052,
            LUMINANCE8_EXT = 0x8040,
            TEXTURE_RED_SIZE_EXT = 0x805C,
            LUMINANCE12_EXT = 0x8041,
            PROXY_TEXTURE_2D_EXT = 0x8064,
            LUMINANCE4_EXT = 0x803F,
            INTENSITY16_EXT = 0x804D,
            TEXTURE_GREEN_SIZE_EXT = 0x805D,
            LUMINANCE16_ALPHA16_EXT = 0x8048,
            TEXTURE_ALPHA_SIZE_EXT = 0x805F,
            LUMINANCE16_EXT = 0x8042,
            PROXY_TEXTURE_1D_EXT = 0x8063,
            RGBA4_EXT = 0x8056,
            INTENSITY_EXT = 0x8049,
            RGBA2_EXT = 0x8055,
            ALPHA16_EXT = 0x803E,
            TEXTURE_TOO_LARGE_EXT = 0x8065,
            ALPHA8_EXT = 0x803C,
            ALPHA4_EXT = 0x803B,
            LUMINANCE4_ALPHA4_EXT = 0x8043,
            LUMINANCE6_ALPHA2_EXT = 0x8044,
            TEXTURE_BLUE_SIZE_EXT = 0x805E,
            RGB2_EXT = 0x804E,
            LUMINANCE12_ALPHA4_EXT = 0x8046,
        }

        public enum NV_texture_compression_vtc : uint
        {
        }

        public enum IBM_rasterpos_clip : uint
        {
            RASTER_POSITION_UNCLIPPED_IBM = 0x19262,
        }

        public enum SGIS_texture_edge_clamp : uint
        {
            CLAMP_TO_EDGE_SGIS = 0x812F,
            CLAMP_TO_EDGE = 0x812F,
        }

        public enum DataType : uint
        {
            DOUBLE = 0x140A,
            DOUBLE_EXT = 0x140A,
            UNSIGNED_INT = 0x1405,
            _4_BYTES = 0x1409,
            FLOAT = 0x1406,
            UNSIGNED_SHORT = 0x1403,
            SHORT = 0x1402,
            BYTE = 0x1400,
            _3_BYTES = 0x1408,
            INT = 0x1404,
            UNSIGNED_BYTE = 0x1401,
            _2_BYTES = 0x1407,
        }

        public enum APPLE_fence : uint
        {
            DRAW_PIXELS_APPLE = 0x8A0A,
            FENCE_APPLE = 0x8A0B,
        }

        public enum ATI_draw_buffers : uint
        {
            DRAW_BUFFER9_ATI = 0x882E,
            DRAW_BUFFER10_ATI = 0x882F,
            DRAW_BUFFER6_ATI = 0x882B,
            DRAW_BUFFER4_ATI = 0x8829,
            DRAW_BUFFER14_ATI = 0x8833,
            DRAW_BUFFER3_ATI = 0x8828,
            DRAW_BUFFER5_ATI = 0x882A,
            DRAW_BUFFER0_ATI = 0x8825,
            DRAW_BUFFER12_ATI = 0x8831,
            DRAW_BUFFER11_ATI = 0x8830,
            DRAW_BUFFER8_ATI = 0x882D,
            DRAW_BUFFER15_ATI = 0x8834,
            DRAW_BUFFER7_ATI = 0x882C,
            DRAW_BUFFER13_ATI = 0x8832,
            DRAW_BUFFER2_ATI = 0x8827,
            DRAW_BUFFER1_ATI = 0x8826,
            MAX_DRAW_BUFFERS_ATI = 0x8824,
        }

        public enum MeshMode1 : uint
        {
            LINE = PolygonMode.LINE,
            POINT = PolygonMode.POINT,
        }

        public enum TextureTarget : uint
        {
            TEXTURE_1D = GetPName.TEXTURE_1D,
            TEXTURE_MAX_LOD_SGIS = SGIS_texture_lod.TEXTURE_MAX_LOD_SGIS,
            TEXTURE_2D = GetPName.TEXTURE_2D,
            TEXTURE_BASE_LEVEL_SGIS = SGIS_texture_lod.TEXTURE_BASE_LEVEL_SGIS,
            PROXY_TEXTURE_4D_SGIS = SGIS_texture4D.PROXY_TEXTURE_4D_SGIS,
            PROXY_TEXTURE_2D = 0x8064,
            TEXTURE_4D_SGIS = SGIS_texture4D.TEXTURE_4D_SGIS,
            DETAIL_TEXTURE_2D_SGIS = SGIS_detail_texture.DETAIL_TEXTURE_2D_SGIS,
            PROXY_TEXTURE_1D = 0x8063,
            TEXTURE_MIN_LOD_SGIS = SGIS_texture_lod.TEXTURE_MIN_LOD_SGIS,
            TEXTURE_MAX_LEVEL_SGIS = SGIS_texture_lod.TEXTURE_MAX_LEVEL_SGIS,
            TEXTURE_3D_EXT = EXT_texture3D.TEXTURE_3D_EXT,
            PROXY_TEXTURE_3D_EXT = EXT_texture3D.PROXY_TEXTURE_3D_EXT,
        }

        public enum MeshMode2 : uint
        {
            FILL = PolygonMode.FILL,
            LINE = PolygonMode.LINE,
            POINT = PolygonMode.POINT,
        }

        public enum EXT_light_texture : uint
        {
            ATTENUATION_EXT = 0x834D,
            FRAGMENT_DEPTH_EXT = EXT_fog_coord.FRAGMENT_DEPTH_EXT,
            TEXTURE_LIGHT_EXT = 0x8350,
            FRAGMENT_NORMAL_EXT = 0x834A,
            FRAGMENT_MATERIAL_EXT = 0x8349,
            TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352,
            TEXTURE_MATERIAL_FACE_EXT = 0x8351,
            SHADOW_ATTENUATION_EXT = 0x834E,
            FRAGMENT_COLOR_EXT = 0x834C,
            TEXTURE_APPLICATION_MODE_EXT = 0x834F,
        }

        public enum ATI_texture_mirror_once : uint
        {
            MIRROR_CLAMP_ATI = 0x8742,
            MIRROR_CLAMP_TO_EDGE_ATI = 0x8743,
        }

        public enum SGI_color_table : uint
        {
            COLOR_TABLE_SGI = 0x80D0,
            COLOR_TABLE_FORMAT_SGI = 0x80D8,
            COLOR_TABLE_SCALE = 0x80D6,
            COLOR_TABLE_SCALE_SGI = 0x80D6,
            PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5,
            COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF,
            COLOR_TABLE_WIDTH_SGI = 0x80D9,
            COLOR_TABLE_BIAS = 0x80D7,
            COLOR_TABLE_BLUE_SIZE = 0x80DC,
            POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2,
            COLOR_TABLE_FORMAT = 0x80D8,
            PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5,
            PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4,
            PROXY_COLOR_TABLE_SGI = 0x80D3,
            COLOR_TABLE_GREEN_SIZE = 0x80DB,
            PROXY_COLOR_TABLE = 0x80D3,
            COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE,
            COLOR_TABLE_ALPHA_SIZE = 0x80DD,
            POST_CONVOLUTION_COLOR_TABLE = 0x80D1,
            COLOR_TABLE_BIAS_SGI = 0x80D7,
            COLOR_TABLE_WIDTH = 0x80D9,
            POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2,
            COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC,
            COLOR_TABLE = 0x80D0,
            PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4,
            COLOR_TABLE_RED_SIZE_SGI = 0x80DA,
            COLOR_TABLE_LUMINANCE_SIZE = 0x80DE,
            POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1,
            COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB,
            COLOR_TABLE_RED_SIZE = 0x80DA,
            COLOR_TABLE_INTENSITY_SIZE = 0x80DF,
            COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD,
        }

        public enum SGIS_detail_texture : uint
        {
            DETAIL_TEXTURE_MODE_SGIS = 0x809B,
            DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096,
            DETAIL_TEXTURE_LEVEL_SGIS = 0x809A,
            DETAIL_TEXTURE_2D_SGIS = 0x8095,
            LINEAR_DETAIL_SGIS = 0x8097,
            DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C,
            LINEAR_DETAIL_ALPHA_SGIS = 0x8098,
            LINEAR_DETAIL_COLOR_SGIS = 0x8099,
        }

        public enum HP_occlusion_test : uint
        {
            OCCLUSION_TEST_HP = 0x8165,
            OCCLUSION_TEST_RESULT_HP = 0x8166,
        }

        public enum APPLE_element_array : uint
        {
            ELEMENT_ARRAY_POINTER_APPLE = 0x876A,
            ELEMENT_ARRAY_APPLE = 0x8768,
            ELEMENT_ARRAY_TYPE_APPLE = 0x8769,
        }

        public enum SGIX_texture_multi_buffer : uint
        {
            TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E,
        }

        public enum _3DFX_tbuffer : uint
        {
        }

        public enum EXT_vertex_shader : uint
        {
            OP_INDEX_EXT = 0x8782,
            OP_MOV_EXT = 0x8799,
            OP_MULTIPLY_MATRIX_EXT = 0x8798,
            VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF,
            VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4,
            OUTPUT_FOG_EXT = 0x87BD,
            Y_EXT = 0x87D6,
            OP_ROUND_EXT = 0x8790,
            OUTPUT_TEXTURE_COORD28_EXT = 0x87B9,
            INVARIANT_EXT = 0x87C2,
            MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6,
            OP_POWER_EXT = 0x8793,
            CURRENT_VERTEX_EXT = 0x87E2,
            OUTPUT_TEXTURE_COORD1_EXT = 0x879E,
            OUTPUT_TEXTURE_COORD29_EXT = 0x87BA,
            LOCAL_EXT = 0x87C4,
            OUTPUT_TEXTURE_COORD4_EXT = 0x87A1,
            OUTPUT_TEXTURE_COORD20_EXT = 0x87B1,
            VARIANT_ARRAY_POINTER_EXT = 0x87E9,
            Z_EXT = 0x87D7,
            VARIANT_ARRAY_STRIDE_EXT = 0x87E6,
            VARIANT_VALUE_EXT = 0x87E4,
            MVP_MATRIX_EXT = 0x87E3,
            VERTEX_SHADER_BINDING_EXT = 0x8781,
            OUTPUT_TEXTURE_COORD19_EXT = 0x87B0,
            INVARIANT_VALUE_EXT = 0x87EA,
            OUTPUT_TEXTURE_COORD21_EXT = 0x87B2,
            MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8,
            OUTPUT_TEXTURE_COORD3_EXT = 0x87A0,
            OUTPUT_TEXTURE_COORD10_EXT = 0x87A7,
            OP_MUL_EXT = 0x8786,
            NEGATIVE_ONE_EXT = 0x87DF,
            OP_CROSS_PRODUCT_EXT = 0x8797,
            VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2,
            OUTPUT_TEXTURE_COORD18_EXT = 0x87AF,
            OP_NEGATE_EXT = 0x8783,
            OUTPUT_TEXTURE_COORD6_EXT = 0x87A3,
            VERTEX_SHADER_INVARIANTS_EXT = 0x87D1,
            OUTPUT_TEXTURE_COORD11_EXT = 0x87A8,
            W_EXT = 0x87D8,
            OP_SET_LT_EXT = 0x878D,
            ONE_EXT = 0x87DE,
            VARIANT_ARRAY_EXT = 0x87E8,
            OUTPUT_COLOR1_EXT = 0x879C,
            OUTPUT_TEXTURE_COORD13_EXT = 0x87AA,
            OUTPUT_TEXTURE_COORD24_EXT = 0x87B5,
            X_EXT = 0x87D5,
            ZERO_EXT = 0x87DD,
            LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED,
            SCALAR_EXT = 0x87BE,
            OUTPUT_TEXTURE_COORD30_EXT = 0x87BB,
            VARIANT_ARRAY_TYPE_EXT = 0x87E7,
            VERTEX_SHADER_VARIANTS_EXT = 0x87D0,
            OUTPUT_TEXTURE_COORD5_EXT = 0x87A2,
            NEGATIVE_W_EXT = 0x87DC,
            OUTPUT_TEXTURE_COORD25_EXT = 0x87B6,
            MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD,
            OP_FLOOR_EXT = 0x878F,
            NEGATIVE_Y_EXT = 0x87DA,
            MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7,
            OUTPUT_TEXTURE_COORD8_EXT = 0x87A5,
            OP_RECIP_EXT = 0x8794,
            OUTPUT_TEXTURE_COORD31_EXT = 0x87BC,
            OUTPUT_TEXTURE_COORD14_EXT = 0x87AB,
            NEGATIVE_X_EXT = 0x87D9,
            MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5,
            VARIANT_DATATYPE_EXT = 0x87E5,
            OUTPUT_VERTEX_EXT = 0x879A,
            OP_ADD_EXT = 0x8787,
            OUTPUT_TEXTURE_COORD0_EXT = 0x879D,
            OUTPUT_TEXTURE_COORD15_EXT = 0x87AC,
            OP_MADD_EXT = 0x8788,
            OP_DOT3_EXT = 0x8784,
            MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE,
            OUTPUT_TEXTURE_COORD7_EXT = 0x87A4,
            LOCAL_CONSTANT_EXT = 0x87C3,
            VECTOR_EXT = 0x87BF,
            VERTEX_SHADER_EXT = 0x8780,
            NORMALIZED_RANGE_EXT = 0x87E0,
            VARIANT_EXT = 0x87C1,
            OUTPUT_TEXTURE_COORD26_EXT = 0x87B7,
            OP_MAX_EXT = 0x878A,
            OP_CLAMP_EXT = 0x878E,
            INVARIANT_DATATYPE_EXT = 0x87EB,
            MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9,
            OUTPUT_TEXTURE_COORD22_EXT = 0x87B3,
            OP_SET_GE_EXT = 0x878C,
            OP_FRAC_EXT = 0x8789,
            VERTEX_SHADER_LOCALS_EXT = 0x87D3,
            MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA,
            LOCAL_CONSTANT_VALUE_EXT = 0x87EC,
            OUTPUT_TEXTURE_COORD27_EXT = 0x87B8,
            NEGATIVE_Z_EXT = 0x87DB,
            OP_RECIP_SQRT_EXT = 0x8795,
            MATRIX_EXT = 0x87C0,
            OP_EXP_BASE_2_EXT = 0x8791,
            OUTPUT_TEXTURE_COORD16_EXT = 0x87AD,
            OUTPUT_TEXTURE_COORD23_EXT = 0x87B4,
            OUTPUT_COLOR0_EXT = 0x879B,
            OP_MIN_EXT = 0x878B,
            OP_DOT4_EXT = 0x8785,
            OUTPUT_TEXTURE_COORD12_EXT = 0x87A9,
            OP_SUB_EXT = 0x8796,
            MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB,
            MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC,
            OUTPUT_TEXTURE_COORD2_EXT = 0x879F,
            OUTPUT_TEXTURE_COORD17_EXT = 0x87AE,
            OP_LOG_BASE_2_EXT = 0x8792,
            OUTPUT_TEXTURE_COORD9_EXT = 0x87A6,
            FULL_RANGE_EXT = 0x87E1,
        }

        public enum ClipPlaneName : uint
        {
            CLIP_PLANE3 = 0x3003,
            CLIP_PLANE2 = 0x3002,
            CLIP_PLANE5 = 0x3005,
            CLIP_PLANE1 = 0x3001,
            CLIP_PLANE0 = 0x3000,
            CLIP_PLANE4 = 0x3004,
        }

        public enum NormalPointerType : uint
        {
            DOUBLE = DataType.DOUBLE,
            BYTE = DataType.BYTE,
            SHORT = DataType.SHORT,
            INT = DataType.INT,
            FLOAT = DataType.FLOAT,
        }

        public enum SGIX_impact_pixel_texture : uint
        {
            PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188,
            PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185,
            PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184,
            PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186,
            PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A,
            PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187,
            PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189,
        }

        public enum EXT_cmyka : uint
        {
            UNPACK_CMYK_HINT_EXT = 0x800F,
            PACK_CMYK_HINT_EXT = 0x800E,
            CMYKA_EXT = 0x800D,
            CMYK_EXT = 0x800C,
        }

        public enum StencilFunction : uint
        {
            NEVER = AlphaFunction.NEVER,
            GEQUAL = AlphaFunction.GEQUAL,
            GREATER = AlphaFunction.GREATER,
            ALWAYS = AlphaFunction.ALWAYS,
            LEQUAL = AlphaFunction.LEQUAL,
            NOTEQUAL = AlphaFunction.NOTEQUAL,
            EQUAL = AlphaFunction.EQUAL,
            LESS = AlphaFunction.LESS,
        }

        public enum VERSION_1_2 : uint
        {
            TEXTURE_BASE_LEVEL = 0x813C,
            UNSIGNED_SHORT_5_6_5_REV = 0x8364,
            PACK_IMAGE_HEIGHT = 0x806C,
            MAX_ELEMENTS_INDICES = 0x80E9,
            UNPACK_SKIP_IMAGES = 0x806D,
            LIGHT_MODEL_COLOR_CONTROL = 0x81F8,
            UNSIGNED_INT_8_8_8_8_REV = 0x8367,
            SMOOTH_LINE_WIDTH_RANGE = 0x0B22,
            TEXTURE_WRAP_R = 0x8072,
            PACK_SKIP_IMAGES = 0x806B,
            UNSIGNED_BYTE_2_3_3_REV = 0x8362,
            UNSIGNED_SHORT_5_6_5 = 0x8363,
            UNSIGNED_INT_8_8_8_8 = 0x8035,
            PROXY_TEXTURE_3D = 0x8070,
            SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13,
            UNSIGNED_SHORT_5_5_5_1 = 0x8034,
            TEXTURE_MAX_LOD = 0x813B,
            UNSIGNED_BYTE_3_3_2 = 0x8032,
            TEXTURE_MAX_LEVEL = 0x813D,
            BGRA = 0x80E1,
            SEPARATE_SPECULAR_COLOR = 0x81FA,
            ALIASED_POINT_SIZE_RANGE = 0x846D,
            SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23,
            SINGLE_COLOR = 0x81F9,
            RESCALE_NORMAL = 0x803A,
            UNSIGNED_INT_10_10_10_2 = 0x8036,
            ALIASED_LINE_WIDTH_RANGE = 0x846E,
            UNPACK_IMAGE_HEIGHT = 0x806E,
            UNSIGNED_SHORT_1_5_5_5_REV = 0x8366,
            TEXTURE_MIN_LOD = 0x813A,
            MAX_3D_TEXTURE_SIZE = 0x8073,
            TEXTURE_3D = 0x806F,
            SMOOTH_POINT_SIZE_RANGE = 0x0B12,
            MAX_ELEMENTS_VERTICES = 0x80E8,
            TEXTURE_DEPTH = 0x8071,
            UNSIGNED_INT_2_10_10_10_REV = 0x8368,
            TEXTURE_BINDING_3D = 0x806A,
            UNSIGNED_SHORT_4_4_4_4 = 0x8033,
            UNSIGNED_SHORT_4_4_4_4_REV = 0x8365,
            BGR = 0x80E0,
            CLAMP_TO_EDGE = 0x812F,
        }

        public enum NV_vertex_program1_1 : uint
        {
        }

        public enum EXT_compiled_vertex_array : uint
        {
            ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9,
            ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8,
        }

        public enum SGIX_flush_raster : uint
        {
        }


        #endregion
    }
}

