using System;
using System.Runtime.InteropServices;

namespace OpenTK.OpenGL
{
    #region Types
    using GLsizeiptrARB = System.IntPtr;
    using GLintptrARB = System.IntPtr;
    using GLhandleARB = System.Int32;
    using GLhalfARB = System.Int16;
    using GLhalfNV = System.Int16;
    using GLcharARB = System.Char;
    using GLsizei = System.Int32;
    using GLsizeiptr = System.IntPtr;
    using GLintptr = System.IntPtr;
    using GLenum = System.Int32;
    using GLboolean = System.Boolean;
    using GLbitfield = System.Int32;
    using GLchar = System.Char;
    using GLbyte = System.Byte;
    using GLubyte = System.Byte;
    using GLshort = System.Int16;
    using GLushort = System.Int16;
    using GLint = System.Int32;
    using GLuint = System.Int32;
    using GLfloat = System.Single;
    using GLclampf = System.Single;
    using GLdouble = System.Double;
    using GLclampd = System.Double;
    using GLstring = System.String;
    #endregion

    #region Enums
    public struct Enums
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

        public enum SGI_depth_pass_instrument : uint
        {
            DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX = 0x8311,
            DEPTH_PASS_INSTRUMENT_SGIX = 0x8310,
            DEPTH_PASS_INSTRUMENT_MAX_SGIX = 0x8312,
         }

        public enum FrontFaceDirection : uint
        {
            CCW = 0x0901,
            CW = 0x0900,
         }

        public enum NV_point_sprite : uint
        {
            COORD_REPLACE_NV = 0x8862,
            POINT_SPRITE_R_MODE_NV = 0x8863,
            POINT_SPRITE_NV = 0x8861,
         }

        public enum INGR_palette_buffer : uint
        {
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

        public enum ARB_color_buffer_float : uint
        {
            CLAMP_READ_COLOR_ARB = 0x891C,
            CLAMP_FRAGMENT_COLOR_ARB = 0x891B,
            FIXED_ONLY_ARB = 0x891D,
            CLAMP_VERTEX_COLOR_ARB = 0x891A,
            RGBA_FLOAT_MODE_ARB = 0x8820,
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

        public enum ARB_shading_language_100 : uint
        {
            SHADING_LANGUAGE_VERSION_ARB = 0x8B8C,
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

        public enum IBM_multimode_draw_arrays : uint
        {
         }

        public enum NV_vertex_program2_option : uint
        {
            MAX_PROGRAM_CALL_DEPTH_NV = NV_fragment_program2.MAX_PROGRAM_CALL_DEPTH_NV,
            MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = NV_fragment_program2.MAX_PROGRAM_EXEC_INSTRUCTIONS_NV,
         }

        public enum NV_primitive_restart : uint
        {
            PRIMITIVE_RESTART_NV = 0x8558,
            PRIMITIVE_RESTART_INDEX_NV = 0x8559,
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

        public enum EXT_index_func : uint
        {
            INDEX_TEST_FUNC_EXT = 0x81B6,
            INDEX_TEST_EXT = 0x81B5,
            INDEX_TEST_REF_EXT = 0x81B7,
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

        public enum APPLE_vertex_array_range : uint
        {
            STORAGE_SHARED_APPLE = 0x85BF,
            VERTEX_ARRAY_RANGE_APPLE = 0x851D,
            VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F,
            VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E,
            VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521,
            STORAGE_CACHED_APPLE = 0x85BE,
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

        public enum NV_pixel_data_range : uint
        {
            READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B,
            WRITE_PIXEL_DATA_RANGE_NV = 0x8878,
            WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C,
            READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D,
            WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A,
            READ_PIXEL_DATA_RANGE_NV = 0x8879,
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

        public enum APPLE_element_array : uint
        {
            ELEMENT_ARRAY_POINTER_APPLE = 0x876A,
            ELEMENT_ARRAY_APPLE = 0x8768,
            ELEMENT_ARRAY_TYPE_APPLE = 0x8769,
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

        public enum SUNX_constant_data : uint
        {
            TEXTURE_CONSTANT_DATA_SUNX = 0x81D6,
            UNPACK_CONSTANT_DATA_SUNX = 0x81D5,
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

        public enum EXT_blend_func_separate : uint
        {
            BLEND_SRC_ALPHA_EXT = 0x80CB,
            BLEND_DST_RGB_EXT = 0x80C8,
            BLEND_DST_ALPHA_EXT = 0x80CA,
            BLEND_SRC_RGB_EXT = 0x80C9,
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

        public enum Boolean : uint
        {
            TRUE = 1,
            FALSE = 0,
         }

        public enum ARB_texture_rectangle : uint
        {
            TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6,
            TEXTURE_RECTANGLE_ARB = 0x84F5,
            MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8,
            PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7,
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

        public enum ARB_window_pos : uint
        {
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

        public enum NV_texture_shader2 : uint
        {
            DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF,
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

        public enum NV_fragment_program : uint
        {
            FRAGMENT_PROGRAM_NV = 0x8870,
            MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872,
            PROGRAM_ERROR_STRING_NV = 0x8874,
            MAX_TEXTURE_COORDS_NV = 0x8871,
            FRAGMENT_PROGRAM_BINDING_NV = 0x8873,
            MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868,
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

        public enum ATI_separate_stencil : uint
        {
            STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802,
            STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803,
            STENCIL_BACK_FAIL_ATI = 0x8801,
            STENCIL_BACK_FUNC_ATI = 0x8800,
         }

        public enum OML_subsample : uint
        {
            FORMAT_SUBSAMPLE_24_24_OML = 0x8982,
            FORMAT_SUBSAMPLE_244_244_OML = 0x8983,
         }

        public enum APPLE_specular_vector : uint
        {
            LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0,
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

        public enum ARB_occlusion_query : uint
        {
            QUERY_RESULT_ARB = 0x8866,
            CURRENT_QUERY_ARB = 0x8865,
            QUERY_RESULT_AVAILABLE_ARB = 0x8867,
            SAMPLES_PASSED_ARB = 0x8914,
            QUERY_COUNTER_BITS_ARB = 0x8864,
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

        public enum ARB_fragment_program_shadow : uint
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

        public enum EXT_stencil_two_side : uint
        {
            ACTIVE_STENCIL_FACE_EXT = 0x8911,
            STENCIL_TEST_TWO_SIDE_EXT = 0x8910,
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

        public enum APPLE_transform_hint : uint
        {
            TRANSFORM_HINT_APPLE = 0x85B1,
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

        public enum IBM_texture_mirrored_repeat : uint
        {
            MIRRORED_REPEAT_IBM = 0x8370,
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

        public enum NV_multisample_filter_hint : uint
        {
            MULTISAMPLE_FILTER_HINT_NV = 0x8534,
         }

        public enum NV_texgen_emboss : uint
        {
            EMBOSS_CONSTANT_NV = 0x855E,
            EMBOSS_LIGHT_NV = 0x855D,
            EMBOSS_MAP_NV = 0x855F,
         }

        public enum NV_fragment_program_option : uint
        {
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

        public enum NV_texture_compression_vtc : uint
        {
         }

        public enum NV_texture_expand_normal : uint
        {
            TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F,
         }

        public enum S3_s3tc : uint
        {
            RGB4_S3TC = 0x83A1,
            RGBA_S3TC = 0x83A2,
            RGB_S3TC = 0x83A0,
            RGBA4_S3TC = 0x83A3,
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

        public enum SGIX_shadow_ambient : uint
        {
            SHADOW_AMBIENT_SGIX = 0x80BF,
         }

        public enum NV_vertex_program3 : uint
        {
            MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = ARB_vertex_shader.MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB,
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

        public enum EXT_copy_texture : uint
        {
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

        public enum EXT_422_pixels : uint
        {
            _422_REV_EXT = 0x80CD,
            _422_EXT = 0x80CC,
            _422_REV_AVERAGE_EXT = 0x80CF,
            _422_AVERAGE_EXT = 0x80CE,
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

        public enum ARB_texture_mirrored_repeat : uint
        {
            MIRRORED_REPEAT_ARB = 0x8370,
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

        public enum ATI_vertex_attrib_array_object : uint
        {
         }

        public enum NV_vertex_array_range2 : uint
        {
            VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533,
         }

        public enum ARB_half_float_pixel : uint
        {
            HALF_FLOAT_ARB = 0x140B,
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

        public enum EXT_blend_logic_op : uint
        {
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

        public enum SUN_global_alpha : uint
        {
            GLOBAL_ALPHA_SUN = 0x81D9,
            GLOBAL_ALPHA_FACTOR_SUN = 0x81DA,
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

        public enum INGR_interlace_read : uint
        {
            INTERLACE_READ_INGR = 0x8568,
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

        public enum NV_fragment_program2 : uint
        {
            MAX_PROGRAM_IF_DEPTH_NV = 0x88F6,
            MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7,
            MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5,
            MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4,
            MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8,
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

        public enum EXT_pixel_buffer_object : uint
        {
            PIXEL_UNPACK_BUFFER_EXT = 0x88EC,
            PIXEL_PACK_BUFFER_EXT = 0x88EB,
            PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF,
            PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED,
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

    }
    #endregion

    public static partial class GL
    {
        #region Function signatures

        public static class Delegates
        {
            public delegate void NewList(GLuint list, Enums.ListMode mode);
            public delegate void EndList();
            public delegate void CallList(GLuint list);
            public delegate void CallLists_(GLsizei n, Enums.ListNameType type, IntPtr lists);
            public delegate void DeleteLists(GLuint list, GLsizei range);
            public delegate GLuint GenLists(GLsizei range);
            public delegate void ListBase(GLuint @base);
            public delegate void Begin(Enums.BeginMode mode);
            public delegate void Bitmap_(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, IntPtr bitmap);
            public delegate void Color3b(GLbyte red, GLbyte green, GLbyte blue);
            public delegate void Color3bv_(IntPtr v);
            public delegate void Color3d(GLdouble red, GLdouble green, GLdouble blue);
            public delegate void Color3dv_(IntPtr v);
            public delegate void Color3f(GLfloat red, GLfloat green, GLfloat blue);
            public delegate void Color3fv_(IntPtr v);
            public delegate void Color3i(GLint red, GLint green, GLint blue);
            public delegate void Color3iv_(IntPtr v);
            public delegate void Color3s(GLshort red, GLshort green, GLshort blue);
            public delegate void Color3sv_(IntPtr v);
            public delegate void Color3ub(GLubyte red, GLubyte green, GLubyte blue);
            public delegate void Color3ubv_(IntPtr v);
            public delegate void Color3ui(GLuint red, GLuint green, GLuint blue);
            public delegate void Color3uiv_(IntPtr v);
            public delegate void Color3us(GLushort red, GLushort green, GLushort blue);
            public delegate void Color3usv_(IntPtr v);
            public delegate void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
            public delegate void Color4bv_(IntPtr v);
            public delegate void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
            public delegate void Color4dv_(IntPtr v);
            public delegate void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
            public delegate void Color4fv_(IntPtr v);
            public delegate void Color4i(GLint red, GLint green, GLint blue, GLint alpha);
            public delegate void Color4iv_(IntPtr v);
            public delegate void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha);
            public delegate void Color4sv_(IntPtr v);
            public delegate void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
            public delegate void Color4ubv_(IntPtr v);
            public delegate void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha);
            public delegate void Color4uiv_(IntPtr v);
            public delegate void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha);
            public delegate void Color4usv_(IntPtr v);
            public delegate void EdgeFlag(Enums.Boolean flag);
            public delegate void EdgeFlagv(Enums.Boolean[] flag);
            public delegate void End();
            public delegate void Indexd(GLdouble c);
            public delegate void Indexdv_(IntPtr c);
            public delegate void Indexf(GLfloat c);
            public delegate void Indexfv_(IntPtr c);
            public delegate void Indexi(GLint c);
            public delegate void Indexiv_(IntPtr c);
            public delegate void Indexs(GLshort c);
            public delegate void Indexsv_(IntPtr c);
            public delegate void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz);
            public delegate void Normal3bv_(IntPtr v);
            public delegate void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz);
            public delegate void Normal3dv_(IntPtr v);
            public delegate void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz);
            public delegate void Normal3fv_(IntPtr v);
            public delegate void Normal3i(GLint nx, GLint ny, GLint nz);
            public delegate void Normal3iv_(IntPtr v);
            public delegate void Normal3s(GLshort nx, GLshort ny, GLshort nz);
            public delegate void Normal3sv_(IntPtr v);
            public delegate void RasterPos2d(GLdouble x, GLdouble y);
            public delegate void RasterPos2dv_(IntPtr v);
            public delegate void RasterPos2f(GLfloat x, GLfloat y);
            public delegate void RasterPos2fv_(IntPtr v);
            public delegate void RasterPos2i(GLint x, GLint y);
            public delegate void RasterPos2iv_(IntPtr v);
            public delegate void RasterPos2s(GLshort x, GLshort y);
            public delegate void RasterPos2sv_(IntPtr v);
            public delegate void RasterPos3d(GLdouble x, GLdouble y, GLdouble z);
            public delegate void RasterPos3dv_(IntPtr v);
            public delegate void RasterPos3f(GLfloat x, GLfloat y, GLfloat z);
            public delegate void RasterPos3fv_(IntPtr v);
            public delegate void RasterPos3i(GLint x, GLint y, GLint z);
            public delegate void RasterPos3iv_(IntPtr v);
            public delegate void RasterPos3s(GLshort x, GLshort y, GLshort z);
            public delegate void RasterPos3sv_(IntPtr v);
            public delegate void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void RasterPos4dv_(IntPtr v);
            public delegate void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void RasterPos4fv_(IntPtr v);
            public delegate void RasterPos4i(GLint x, GLint y, GLint z, GLint w);
            public delegate void RasterPos4iv_(IntPtr v);
            public delegate void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w);
            public delegate void RasterPos4sv_(IntPtr v);
            public delegate void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);
            public delegate void Rectdv_(IntPtr v1, IntPtr v2);
            public delegate void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);
            public delegate void Rectfv_(IntPtr v1, IntPtr v2);
            public delegate void Recti(GLint x1, GLint y1, GLint x2, GLint y2);
            public delegate void Rectiv_(IntPtr v1, IntPtr v2);
            public delegate void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2);
            public delegate void Rectsv_(IntPtr v1, IntPtr v2);
            public delegate void TexCoord1d(GLdouble s);
            public delegate void TexCoord1dv_(IntPtr v);
            public delegate void TexCoord1f(GLfloat s);
            public delegate void TexCoord1fv_(IntPtr v);
            public delegate void TexCoord1i(GLint s);
            public delegate void TexCoord1iv_(IntPtr v);
            public delegate void TexCoord1s(GLshort s);
            public delegate void TexCoord1sv_(IntPtr v);
            public delegate void TexCoord2d(GLdouble s, GLdouble t);
            public delegate void TexCoord2dv_(IntPtr v);
            public delegate void TexCoord2f(GLfloat s, GLfloat t);
            public delegate void TexCoord2fv_(IntPtr v);
            public delegate void TexCoord2i(GLint s, GLint t);
            public delegate void TexCoord2iv_(IntPtr v);
            public delegate void TexCoord2s(GLshort s, GLshort t);
            public delegate void TexCoord2sv_(IntPtr v);
            public delegate void TexCoord3d(GLdouble s, GLdouble t, GLdouble r);
            public delegate void TexCoord3dv_(IntPtr v);
            public delegate void TexCoord3f(GLfloat s, GLfloat t, GLfloat r);
            public delegate void TexCoord3fv_(IntPtr v);
            public delegate void TexCoord3i(GLint s, GLint t, GLint r);
            public delegate void TexCoord3iv_(IntPtr v);
            public delegate void TexCoord3s(GLshort s, GLshort t, GLshort r);
            public delegate void TexCoord3sv_(IntPtr v);
            public delegate void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q);
            public delegate void TexCoord4dv_(IntPtr v);
            public delegate void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q);
            public delegate void TexCoord4fv_(IntPtr v);
            public delegate void TexCoord4i(GLint s, GLint t, GLint r, GLint q);
            public delegate void TexCoord4iv_(IntPtr v);
            public delegate void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q);
            public delegate void TexCoord4sv_(IntPtr v);
            public delegate void Vertex2d(GLdouble x, GLdouble y);
            public delegate void Vertex2dv_(IntPtr v);
            public delegate void Vertex2f(GLfloat x, GLfloat y);
            public delegate void Vertex2fv_(IntPtr v);
            public delegate void Vertex2i(GLint x, GLint y);
            public delegate void Vertex2iv_(IntPtr v);
            public delegate void Vertex2s(GLshort x, GLshort y);
            public delegate void Vertex2sv_(IntPtr v);
            public delegate void Vertex3d(GLdouble x, GLdouble y, GLdouble z);
            public delegate void Vertex3dv_(IntPtr v);
            public delegate void Vertex3f(GLfloat x, GLfloat y, GLfloat z);
            public delegate void Vertex3fv_(IntPtr v);
            public delegate void Vertex3i(GLint x, GLint y, GLint z);
            public delegate void Vertex3iv_(IntPtr v);
            public delegate void Vertex3s(GLshort x, GLshort y, GLshort z);
            public delegate void Vertex3sv_(IntPtr v);
            public delegate void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void Vertex4dv_(IntPtr v);
            public delegate void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void Vertex4fv_(IntPtr v);
            public delegate void Vertex4i(GLint x, GLint y, GLint z, GLint w);
            public delegate void Vertex4iv_(IntPtr v);
            public delegate void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w);
            public delegate void Vertex4sv_(IntPtr v);
            public delegate void ClipPlane_(Enums.ClipPlaneName plane, IntPtr equation);
            public delegate void ColorMaterial(Enums.MaterialFace face, Enums.ColorMaterialParameter mode);
            public delegate void CullFace(Enums.CullFaceMode mode);
            public delegate void Fogf(Enums.FogParameter pname, GLfloat param);
            public delegate void Fogfv_(Enums.FogParameter pname, IntPtr parameters);
            public delegate void Fogi(Enums.FogParameter pname, GLint param);
            public delegate void Fogiv_(Enums.FogParameter pname, IntPtr parameters);
            public delegate void FrontFace(Enums.FrontFaceDirection mode);
            public delegate void Hint(Enums.HintTarget target, Enums.HintMode mode);
            public delegate void Lightf(Enums.LightName light, Enums.LightParameter pname, GLfloat param);
            public delegate void Lightfv_(Enums.LightName light, Enums.LightParameter pname, IntPtr parameters);
            public delegate void Lighti(Enums.LightName light, Enums.LightParameter pname, GLint param);
            public delegate void Lightiv_(Enums.LightName light, Enums.LightParameter pname, IntPtr parameters);
            public delegate void LightModelf(Enums.LightModelParameter pname, GLfloat param);
            public delegate void LightModelfv_(Enums.LightModelParameter pname, IntPtr parameters);
            public delegate void LightModeli(Enums.LightModelParameter pname, GLint param);
            public delegate void LightModeliv_(Enums.LightModelParameter pname, IntPtr parameters);
            public delegate void LineStipple(GLint factor, GLushort pattern);
            public delegate void LineWidth(GLfloat width);
            public delegate void Materialf(Enums.MaterialFace face, Enums.MaterialParameter pname, GLfloat param);
            public delegate void Materialfv_(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters);
            public delegate void Materiali(Enums.MaterialFace face, Enums.MaterialParameter pname, GLint param);
            public delegate void Materialiv_(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters);
            public delegate void PointSize(GLfloat size);
            public delegate void PolygonMode(Enums.MaterialFace face, Enums.PolygonMode mode);
            public delegate void PolygonStipple_(IntPtr mask);
            public delegate void Scissor(GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void ShadeModel(Enums.ShadingModel mode);
            public delegate void TexParameterf(Enums.TextureTarget target, Enums.TextureParameterName pname, GLfloat param);
            public delegate void TexParameterfv_(Enums.TextureTarget target, Enums.TextureParameterName pname, IntPtr parameters);
            public delegate void TexParameteri(Enums.TextureTarget target, Enums.TextureParameterName pname, GLint param);
            public delegate void TexParameteriv_(Enums.TextureTarget target, Enums.TextureParameterName pname, IntPtr parameters);
            public delegate void TexImage1D(Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void TexImage2D(Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void TexEnvf(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, GLfloat param);
            public delegate void TexEnvfv_(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, IntPtr parameters);
            public delegate void TexEnvi(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, GLint param);
            public delegate void TexEnviv_(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, IntPtr parameters);
            public delegate void TexGend(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLdouble param);
            public delegate void TexGendv_(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters);
            public delegate void TexGenf(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLfloat param);
            public delegate void TexGenfv_(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters);
            public delegate void TexGeni(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLint param);
            public delegate void TexGeniv_(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters);
            public delegate void FeedbackBuffer(GLsizei size, Enums.FeedbackType type, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] buffer);
            public delegate void SelectBuffer(GLsizei size, [MarshalAs(UnmanagedType.LPArray)] GLuint[] buffer);
            public delegate GLint RenderMode(Enums.RenderingMode mode);
            public delegate void InitNames();
            public delegate void LoadName(GLuint name);
            public delegate void PassThrough(GLfloat token);
            public delegate void PopName();
            public delegate void PushName(GLuint name);
            public delegate void DrawBuffer(Enums.DrawBufferMode mode);
            public delegate void Clear(Enums.ClearBufferMask mask);
            public delegate void ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
            public delegate void ClearIndex(GLfloat c);
            public delegate void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
            public delegate void ClearStencil(GLint s);
            public delegate void ClearDepth(GLclampd depth);
            public delegate void StencilMask(GLuint mask);
            public delegate void ColorMask(Enums.Boolean red, Enums.Boolean green, Enums.Boolean blue, Enums.Boolean alpha);
            public delegate void DepthMask(Enums.Boolean flag);
            public delegate void IndexMask(GLuint mask);
            public delegate void Accum(Enums.AccumOp op, GLfloat value);
            public delegate void Disable(Enums.EnableCap cap);
            public delegate void Enable(Enums.EnableCap cap);
            public delegate void Finish();
            public delegate void Flush();
            public delegate void PopAttrib();
            public delegate void PushAttrib(Enums.AttribMask mask);
            public delegate void Map1d_(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, IntPtr points);
            public delegate void Map1f_(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, IntPtr points);
            public delegate void Map2d_(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, IntPtr points);
            public delegate void Map2f_(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, IntPtr points);
            public delegate void MapGrid1d(GLint un, GLdouble u1, GLdouble u2);
            public delegate void MapGrid1f(GLint un, GLfloat u1, GLfloat u2);
            public delegate void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
            public delegate void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
            public delegate void EvalCoord1d(GLdouble u);
            public delegate void EvalCoord1dv_(IntPtr u);
            public delegate void EvalCoord1f(GLfloat u);
            public delegate void EvalCoord1fv_(IntPtr u);
            public delegate void EvalCoord2d(GLdouble u, GLdouble v);
            public delegate void EvalCoord2dv_(IntPtr u);
            public delegate void EvalCoord2f(GLfloat u, GLfloat v);
            public delegate void EvalCoord2fv_(IntPtr u);
            public delegate void EvalMesh1(Enums.MeshMode1 mode, GLint i1, GLint i2);
            public delegate void EvalPoint1(GLint i);
            public delegate void EvalMesh2(Enums.MeshMode2 mode, GLint i1, GLint i2, GLint j1, GLint j2);
            public delegate void EvalPoint2(GLint i, GLint j);
            public delegate void AlphaFunc(Enums.AlphaFunction func, GLclampf reference);
            public delegate void BlendFunc(Enums.BlendingFactorSrc sfactor, Enums.BlendingFactorDest dfactor);
            public delegate void LogicOp(Enums.LogicOp opcode);
            public delegate void StencilFunc(Enums.StencilFunction func, GLint reference, GLuint mask);
            public delegate void StencilOp(Enums.StencilOp fail, Enums.StencilOp zfail, Enums.StencilOp zpass);
            public delegate void DepthFunc(Enums.DepthFunction func);
            public delegate void PixelZoom(GLfloat xfactor, GLfloat yfactor);
            public delegate void PixelTransferf(Enums.PixelTransferParameter pname, GLfloat param);
            public delegate void PixelTransferi(Enums.PixelTransferParameter pname, GLint param);
            public delegate void PixelStoref(Enums.PixelStoreParameter pname, GLfloat param);
            public delegate void PixelStorei(Enums.PixelStoreParameter pname, GLint param);
            public delegate void PixelMapfv_(Enums.PixelMap map, GLint mapsize, IntPtr values);
            public delegate void PixelMapuiv_(Enums.PixelMap map, GLint mapsize, IntPtr values);
            public delegate void PixelMapusv_(Enums.PixelMap map, GLint mapsize, IntPtr values);
            public delegate void ReadBuffer(Enums.ReadBufferMode mode);
            public delegate void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, Enums.PixelCopyType type);
            public delegate void ReadPixels_(GLint x, GLint y, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void DrawPixels_(GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void GetBooleanv(Enums.GetPName pname, Enums.Boolean[] parameters);
            public delegate void GetClipPlane(Enums.ClipPlaneName plane, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] equation);
            public delegate void GetDoublev(Enums.GetPName pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate GLenum GetError();
            public delegate void GetFloatv(Enums.GetPName pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetIntegerv(Enums.GetPName pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetLightfv(Enums.LightName light, Enums.LightParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetLightiv(Enums.LightName light, Enums.LightParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetMapdv(Enums.MapTarget target, Enums.GetMapQuery query, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] v);
            public delegate void GetMapfv(Enums.MapTarget target, Enums.GetMapQuery query, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] v);
            public delegate void GetMapiv(Enums.MapTarget target, Enums.GetMapQuery query, [MarshalAs(UnmanagedType.LPArray)] GLint[] v);
            public delegate void GetMaterialfv(Enums.MaterialFace face, Enums.MaterialParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetMaterialiv(Enums.MaterialFace face, Enums.MaterialParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetPixelMapfv(Enums.PixelMap map, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] values);
            public delegate void GetPixelMapuiv(Enums.PixelMap map, [MarshalAs(UnmanagedType.LPArray)] GLuint[] values);
            public delegate void GetPixelMapusv(Enums.PixelMap map, [MarshalAs(UnmanagedType.LPArray)] GLushort[] values);
            public delegate void GetPolygonStipple([MarshalAs(UnmanagedType.LPArray)] GLubyte[] mask);
            public delegate IntPtr GetString_(Enums.StringName name);
            public delegate void GetTexEnvfv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetTexEnviv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetTexGendv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void GetTexGenfv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetTexGeniv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetTexImage(Enums.TextureTarget target, GLint level, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void GetTexParameterfv(Enums.TextureTarget target, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetTexParameteriv(Enums.TextureTarget target, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetTexLevelParameterfv(Enums.TextureTarget target, GLint level, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetTexLevelParameteriv(Enums.TextureTarget target, GLint level, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate GLboolean IsEnabled(Enums.EnableCap cap);
            public delegate GLboolean IsList(GLuint list);
            public delegate void DepthRange(GLclampd near, GLclampd far);
            public delegate void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
            public delegate void LoadIdentity();
            public delegate void LoadMatrixf_(IntPtr m);
            public delegate void LoadMatrixd_(IntPtr m);
            public delegate void MatrixMode(Enums.MatrixMode mode);
            public delegate void MultMatrixf_(IntPtr m);
            public delegate void MultMatrixd_(IntPtr m);
            public delegate void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
            public delegate void PopMatrix();
            public delegate void PushMatrix();
            public delegate void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
            public delegate void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
            public delegate void Scaled(GLdouble x, GLdouble y, GLdouble z);
            public delegate void Scalef(GLfloat x, GLfloat y, GLfloat z);
            public delegate void Translated(GLdouble x, GLdouble y, GLdouble z);
            public delegate void Translatef(GLfloat x, GLfloat y, GLfloat z);
            public delegate void Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void ArrayElement(GLint i);
            public delegate void ColorPointer_(GLint size, Enums.ColorPointerType type, GLsizei stride, IntPtr pointer);
            public delegate void DisableClientState(Enums.EnableCap array);
            public delegate void DrawArrays(Enums.BeginMode mode, GLint first, GLsizei count);
            public delegate void DrawElements_(Enums.BeginMode mode, GLsizei count, GLenum type, IntPtr indices);
            public delegate void EdgeFlagPointer_(GLsizei stride, IntPtr pointer);
            public delegate void EnableClientState(Enums.EnableCap array);
            public delegate void GetPointerv(Enums.GetPointervPName pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] parameters);
            public delegate void IndexPointer_(Enums.IndexPointerType type, GLsizei stride, IntPtr pointer);
            public delegate void InterleavedArrays_(Enums.InterleavedArrayFormat format, GLsizei stride, IntPtr pointer);
            public delegate void NormalPointer_(Enums.NormalPointerType type, GLsizei stride, IntPtr pointer);
            public delegate void TexCoordPointer_(GLint size, Enums.TexCoordPointerType type, GLsizei stride, IntPtr pointer);
            public delegate void VertexPointer_(GLint size, Enums.VertexPointerType type, GLsizei stride, IntPtr pointer);
            public delegate void PolygonOffset(GLfloat factor, GLfloat units);
            public delegate void CopyTexImage1D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border);
            public delegate void CopyTexImage2D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
            public delegate void CopyTexSubImage1D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
            public delegate void CopyTexSubImage2D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void TexSubImage1D(Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void TexSubImage2D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate GLboolean AreTexturesResident_(GLsizei n, IntPtr textures, Enums.Boolean[] residences);
            public delegate void BindTexture(Enums.TextureTarget target, GLuint texture);
            public delegate void DeleteTextures_(GLsizei n, IntPtr textures);
            public delegate void GenTextures(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] textures);
            public delegate GLboolean IsTexture(GLuint texture);
            public delegate void PrioritizeTextures_(GLsizei n, IntPtr textures, IntPtr priorities);
            public delegate void Indexub(GLubyte c);
            public delegate void Indexubv_(IntPtr c);
            public delegate void PopClientAttrib();
            public delegate void PushClientAttrib(Enums.ClientAttribMask mask);
            public delegate void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
            public delegate void BlendEquation(GLenum mode);
            public delegate void DrawRangeElements_(Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GLenum type, IntPtr indices);
            public delegate void ColorTable_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr table);
            public delegate void ColorTableParameterfv_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void ColorTableParameteriv_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void CopyColorTable(GLenum target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
            public delegate void GetColorTable_(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr table);
            public delegate void GetColorTableParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetColorTableParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void ColorSubTable_(GLenum target, GLsizei start, GLsizei count, Enums.PixelFormat format, Enums.PixelType type, IntPtr data);
            public delegate void CopyColorSubTable(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
            public delegate void ConvolutionFilter1D_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            public delegate void ConvolutionFilter2D_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            public delegate void ConvolutionParameterf(GLenum target, GLenum pname, GLfloat parameters);
            public delegate void ConvolutionParameterfv_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void ConvolutionParameteri(GLenum target, GLenum pname, GLint parameters);
            public delegate void ConvolutionParameteriv_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void CopyConvolutionFilter1D(GLenum target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
            public delegate void CopyConvolutionFilter2D(GLenum target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void GetConvolutionFilter_(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            public delegate void GetConvolutionParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetConvolutionParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetSeparableFilter_(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column, IntPtr span);
            public delegate void SeparableFilter2D_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column);
            public delegate void GetHistogram_(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values);
            public delegate void GetHistogramParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetHistogramParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetMinmax_(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values);
            public delegate void GetMinmaxParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetMinmaxParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void Histogram(GLenum target, GLsizei width, Enums.PixelInternalFormat internalformat, Enums.Boolean sink);
            public delegate void Minmax(GLenum target, Enums.PixelInternalFormat internalformat, Enums.Boolean sink);
            public delegate void ResetHistogram(GLenum target);
            public delegate void ResetMinmax(GLenum target);
            public delegate void TexImage3D(Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void TexSubImage3D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void CopyTexSubImage3D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void ActiveTexture(GLenum texture);
            public delegate void ClientActiveTexture(GLenum texture);
            public delegate void MultiTexCoord1d(GLenum target, GLdouble s);
            public delegate void MultiTexCoord1dv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord1f(GLenum target, GLfloat s);
            public delegate void MultiTexCoord1fv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord1i(GLenum target, GLint s);
            public delegate void MultiTexCoord1iv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord1s(GLenum target, GLshort s);
            public delegate void MultiTexCoord1sv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2d(GLenum target, GLdouble s, GLdouble t);
            public delegate void MultiTexCoord2dv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2f(GLenum target, GLfloat s, GLfloat t);
            public delegate void MultiTexCoord2fv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2i(GLenum target, GLint s, GLint t);
            public delegate void MultiTexCoord2iv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2s(GLenum target, GLshort s, GLshort t);
            public delegate void MultiTexCoord2sv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3d(GLenum target, GLdouble s, GLdouble t, GLdouble r);
            public delegate void MultiTexCoord3dv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3f(GLenum target, GLfloat s, GLfloat t, GLfloat r);
            public delegate void MultiTexCoord3fv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3i(GLenum target, GLint s, GLint t, GLint r);
            public delegate void MultiTexCoord3iv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3s(GLenum target, GLshort s, GLshort t, GLshort r);
            public delegate void MultiTexCoord3sv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
            public delegate void MultiTexCoord4dv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
            public delegate void MultiTexCoord4fv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4i(GLenum target, GLint s, GLint t, GLint r, GLint q);
            public delegate void MultiTexCoord4iv_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
            public delegate void MultiTexCoord4sv_(GLenum target, IntPtr v);
            public delegate void LoadTransposeMatrixf_(IntPtr m);
            public delegate void LoadTransposeMatrixd_(IntPtr m);
            public delegate void MultTransposeMatrixf_(IntPtr m);
            public delegate void MultTransposeMatrixd_(IntPtr m);
            public delegate void SampleCoverage(GLclampf value, Enums.Boolean invert);
            public delegate void CompressedTexImage3D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexImage2D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexImage1D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexSubImage3D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexSubImage2D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexSubImage1D(Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            public delegate void GetCompressedTexImage(Enums.TextureTarget target, GLint level, IntPtr img);
            public delegate void BlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
            public delegate void FogCoordf(GLfloat coord);
            public delegate void FogCoordfv_(IntPtr coord);
            public delegate void FogCoordd(GLdouble coord);
            public delegate void FogCoorddv_(IntPtr coord);
            public delegate void FogCoordPointer_(GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void MultiDrawArrays(Enums.BeginMode mode, [MarshalAs(UnmanagedType.LPArray)] GLint[] first, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] count, GLsizei primcount);
            public delegate void MultiDrawElements_(Enums.BeginMode mode, IntPtr count, GLenum type, IntPtr indices, GLsizei primcount);
            public delegate void PointParameterf(GLenum pname, GLfloat param);
            public delegate void PointParameterfv_(GLenum pname, IntPtr parameters);
            public delegate void PointParameteri(GLenum pname, GLint param);
            public delegate void PointParameteriv_(GLenum pname, IntPtr parameters);
            public delegate void SecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue);
            public delegate void SecondaryColor3bv_(IntPtr v);
            public delegate void SecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue);
            public delegate void SecondaryColor3dv_(IntPtr v);
            public delegate void SecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue);
            public delegate void SecondaryColor3fv_(IntPtr v);
            public delegate void SecondaryColor3i(GLint red, GLint green, GLint blue);
            public delegate void SecondaryColor3iv_(IntPtr v);
            public delegate void SecondaryColor3s(GLshort red, GLshort green, GLshort blue);
            public delegate void SecondaryColor3sv_(IntPtr v);
            public delegate void SecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue);
            public delegate void SecondaryColor3ubv_(IntPtr v);
            public delegate void SecondaryColor3ui(GLuint red, GLuint green, GLuint blue);
            public delegate void SecondaryColor3uiv_(IntPtr v);
            public delegate void SecondaryColor3us(GLushort red, GLushort green, GLushort blue);
            public delegate void SecondaryColor3usv_(IntPtr v);
            public delegate void SecondaryColorPointer_(GLint size, Enums.ColorPointerType type, GLsizei stride, IntPtr pointer);
            public delegate void WindowPos2d(GLdouble x, GLdouble y);
            public delegate void WindowPos2dv_(IntPtr v);
            public delegate void WindowPos2f(GLfloat x, GLfloat y);
            public delegate void WindowPos2fv_(IntPtr v);
            public delegate void WindowPos2i(GLint x, GLint y);
            public delegate void WindowPos2iv_(IntPtr v);
            public delegate void WindowPos2s(GLshort x, GLshort y);
            public delegate void WindowPos2sv_(IntPtr v);
            public delegate void WindowPos3d(GLdouble x, GLdouble y, GLdouble z);
            public delegate void WindowPos3dv_(IntPtr v);
            public delegate void WindowPos3f(GLfloat x, GLfloat y, GLfloat z);
            public delegate void WindowPos3fv_(IntPtr v);
            public delegate void WindowPos3i(GLint x, GLint y, GLint z);
            public delegate void WindowPos3iv_(IntPtr v);
            public delegate void WindowPos3s(GLshort x, GLshort y, GLshort z);
            public delegate void WindowPos3sv_(IntPtr v);
            public delegate void GenQueries(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] ids);
            public delegate void DeleteQueries_(GLsizei n, IntPtr ids);
            public delegate GLboolean IsQuery(GLuint id);
            public delegate void BeginQuery(Enums.VERSION_1_5 target, GLuint id);
            public delegate void EndQuery(Enums.VERSION_1_5 target);
            public delegate void GetQueryiv(Enums.VERSION_1_5 target, Enums.VERSION_1_5 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetQueryObjectiv(GLuint id, Enums.VERSION_1_5 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetQueryObjectuiv(GLuint id, Enums.VERSION_1_5 pname, [MarshalAs(UnmanagedType.LPArray)] GLuint[] parameters);
            public delegate void BindBuffer(GLenum target, GLuint buffer);
            public delegate void DeleteBuffers_(GLsizei n, IntPtr buffers);
            public delegate void GenBuffers(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] buffers);
            public delegate GLboolean IsBuffer(GLuint buffer);
            public delegate void BufferData_(GLenum target, GLsizeiptr size, IntPtr data, GLenum usage);
            public delegate void BufferSubData_(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data);
            public delegate void GetBufferSubData_(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data);
            public delegate IntPtr MapBuffer(GLenum target, GLenum access);
            public delegate GLboolean UnmapBuffer(GLenum target);
            public delegate void GetBufferParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetBufferPointerv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] parameters);
            public delegate void BlendEquationSeparate(Enums.BlendEquationModeEXT modeRGB, Enums.BlendEquationModeEXT modeAlpha);
            public delegate void DrawBuffers_(GLsizei n, IntPtr bufs);
            public delegate void StencilOpSeparate(GLenum face, Enums.StencilOp sfail, Enums.StencilOp dpfail, Enums.StencilOp dppass);
            public delegate void StencilFuncSeparate(Enums.StencilFunction frontfunc, Enums.StencilFunction backfunc, GLint reference, GLuint mask);
            public delegate void StencilMaskSeparate(GLenum face, GLuint mask);
            public delegate void AttachShader(GLuint program, GLuint shader);
            public delegate void BindAttribLocation_(GLuint program, GLuint index, IntPtr name);
            public delegate void CompileShader(GLuint shader);
            public delegate GLuint CreateProgram();
            public delegate GLuint CreateShader(Enums.VERSION_2_0 type);
            public delegate void DeleteProgram(GLuint program);
            public delegate void DeleteShader(GLuint shader);
            public delegate void DetachShader(GLuint program, GLuint shader);
            public delegate void DisableVertexAttribArray(GLuint index);
            public delegate void EnableVertexAttribArray(GLuint index);
            public delegate void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLint[] size, [MarshalAs(UnmanagedType.LPArray)] Enums.VERSION_2_0[] type, [MarshalAs(UnmanagedType.LPArray)] GLchar[] name);
            public delegate void GetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLint[] size, [MarshalAs(UnmanagedType.LPArray)] Enums.VERSION_2_0[] type, [MarshalAs(UnmanagedType.LPArray)] GLchar[] name);
            public delegate void GetAttachedShaders(GLuint program, GLsizei maxCount, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] count, [MarshalAs(UnmanagedType.LPArray)] GLuint[] obj);
            public delegate GLint GetAttribLocation_(GLuint program, IntPtr name);
            public delegate void GetProgramiv(GLuint program, Enums.VERSION_2_0 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetProgramInfoLog(GLuint program, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLchar[] infoLog);
            public delegate void GetShaderiv(GLuint shader, Enums.VERSION_2_0 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetShaderInfoLog(GLuint shader, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLchar[] infoLog);
            public delegate void GetShaderSource(GLuint shader, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLchar[] source);
            public delegate GLint GetUniformLocation_(GLuint program, IntPtr name);
            public delegate void GetUniformfv(GLuint program, GLint location, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetUniformiv(GLuint program, GLint location, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetVertexAttribdv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void GetVertexAttribfv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetVertexAttribiv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetVertexAttribPointerv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] pointer);
            public delegate GLboolean IsProgram(GLuint program);
            public delegate GLboolean IsShader(GLuint shader);
            public delegate void LinkProgram(GLuint program);
            public delegate void ShaderSource_(GLuint shader, GLsizei count, string[] @string, IntPtr length);
            public delegate void UseProgram(GLuint program);
            public delegate void Uniform1f(GLint location, GLfloat v0);
            public delegate void Uniform2f(GLint location, GLfloat v0, GLfloat v1);
            public delegate void Uniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
            public delegate void Uniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
            public delegate void Uniform1i(GLint location, GLint v0);
            public delegate void Uniform2i(GLint location, GLint v0, GLint v1);
            public delegate void Uniform3i(GLint location, GLint v0, GLint v1, GLint v2);
            public delegate void Uniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
            public delegate void Uniform1fv_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform2fv_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform3fv_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform4fv_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform1iv_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform2iv_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform3iv_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform4iv_(GLint location, GLsizei count, IntPtr value);
            public delegate void UniformMatrix2fv_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            public delegate void UniformMatrix3fv_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            public delegate void UniformMatrix4fv_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            public delegate void ValidateProgram(GLuint program);
            public delegate void VertexAttrib1d(GLuint index, GLdouble x);
            public delegate void VertexAttrib1dv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib1f(GLuint index, GLfloat x);
            public delegate void VertexAttrib1fv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib1s(GLuint index, GLshort x);
            public delegate void VertexAttrib1sv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2d(GLuint index, GLdouble x, GLdouble y);
            public delegate void VertexAttrib2dv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2f(GLuint index, GLfloat x, GLfloat y);
            public delegate void VertexAttrib2fv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2s(GLuint index, GLshort x, GLshort y);
            public delegate void VertexAttrib2sv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);
            public delegate void VertexAttrib3dv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);
            public delegate void VertexAttrib3fv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z);
            public delegate void VertexAttrib3sv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4Nbv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4Niv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4Nsv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
            public delegate void VertexAttrib4Nubv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4Nuiv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4Nusv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4bv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void VertexAttrib4dv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void VertexAttrib4fv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4iv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
            public delegate void VertexAttrib4sv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4ubv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4uiv_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4usv_(GLuint index, IntPtr v);
            public delegate void VertexAttribPointer_(GLuint index, GLint size, GLenum type, Enums.Boolean normalized, GLsizei stride, IntPtr pointer);
            public delegate void ActiveTextureARB(GLenum texture);
            public delegate void ClientActiveTextureARB(GLenum texture);
            public delegate void MultiTexCoord1dARB(GLenum target, GLdouble s);
            public delegate void MultiTexCoord1dvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord1fARB(GLenum target, GLfloat s);
            public delegate void MultiTexCoord1fvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord1iARB(GLenum target, GLint s);
            public delegate void MultiTexCoord1ivARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord1sARB(GLenum target, GLshort s);
            public delegate void MultiTexCoord1svARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2dARB(GLenum target, GLdouble s, GLdouble t);
            public delegate void MultiTexCoord2dvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2fARB(GLenum target, GLfloat s, GLfloat t);
            public delegate void MultiTexCoord2fvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2iARB(GLenum target, GLint s, GLint t);
            public delegate void MultiTexCoord2ivARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2sARB(GLenum target, GLshort s, GLshort t);
            public delegate void MultiTexCoord2svARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r);
            public delegate void MultiTexCoord3dvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r);
            public delegate void MultiTexCoord3fvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3iARB(GLenum target, GLint s, GLint t, GLint r);
            public delegate void MultiTexCoord3ivARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3sARB(GLenum target, GLshort s, GLshort t, GLshort r);
            public delegate void MultiTexCoord3svARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
            public delegate void MultiTexCoord4dvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
            public delegate void MultiTexCoord4fvARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4iARB(GLenum target, GLint s, GLint t, GLint r, GLint q);
            public delegate void MultiTexCoord4ivARB_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4sARB(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
            public delegate void MultiTexCoord4svARB_(GLenum target, IntPtr v);
            public delegate void LoadTransposeMatrixfARB_(IntPtr m);
            public delegate void LoadTransposeMatrixdARB_(IntPtr m);
            public delegate void MultTransposeMatrixfARB_(IntPtr m);
            public delegate void MultTransposeMatrixdARB_(IntPtr m);
            public delegate void SampleCoverageARB(GLclampf value, Enums.Boolean invert);
            public delegate void CompressedTexImage3DARB(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexImage2DARB(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexImage1DARB(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexSubImage3DARB(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexSubImage2DARB(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            public delegate void CompressedTexSubImage1DARB(Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            public delegate void GetCompressedTexImageARB(Enums.TextureTarget target, GLint level, IntPtr img);
            public delegate void PointParameterfARB(GLenum pname, GLfloat param);
            public delegate void PointParameterfvARB_(GLenum pname, IntPtr parameters);
            public delegate void WeightbvARB_(GLint size, IntPtr weights);
            public delegate void WeightsvARB_(GLint size, IntPtr weights);
            public delegate void WeightivARB_(GLint size, IntPtr weights);
            public delegate void WeightfvARB_(GLint size, IntPtr weights);
            public delegate void WeightdvARB_(GLint size, IntPtr weights);
            public delegate void WeightubvARB_(GLint size, IntPtr weights);
            public delegate void WeightusvARB_(GLint size, IntPtr weights);
            public delegate void WeightuivARB_(GLint size, IntPtr weights);
            public delegate void WeightPointerARB_(GLint size, GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void VertexBlendARB(GLint count);
            public delegate void CurrentPaletteMatrixARB(GLint index);
            public delegate void MatrixIndexubvARB_(GLint size, IntPtr indices);
            public delegate void MatrixIndexusvARB_(GLint size, IntPtr indices);
            public delegate void MatrixIndexuivARB_(GLint size, IntPtr indices);
            public delegate void MatrixIndexPointerARB_(GLint size, GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void WindowPos2dARB(GLdouble x, GLdouble y);
            public delegate void WindowPos2dvARB_(IntPtr v);
            public delegate void WindowPos2fARB(GLfloat x, GLfloat y);
            public delegate void WindowPos2fvARB_(IntPtr v);
            public delegate void WindowPos2iARB(GLint x, GLint y);
            public delegate void WindowPos2ivARB_(IntPtr v);
            public delegate void WindowPos2sARB(GLshort x, GLshort y);
            public delegate void WindowPos2svARB_(IntPtr v);
            public delegate void WindowPos3dARB(GLdouble x, GLdouble y, GLdouble z);
            public delegate void WindowPos3dvARB_(IntPtr v);
            public delegate void WindowPos3fARB(GLfloat x, GLfloat y, GLfloat z);
            public delegate void WindowPos3fvARB_(IntPtr v);
            public delegate void WindowPos3iARB(GLint x, GLint y, GLint z);
            public delegate void WindowPos3ivARB_(IntPtr v);
            public delegate void WindowPos3sARB(GLshort x, GLshort y, GLshort z);
            public delegate void WindowPos3svARB_(IntPtr v);
            public delegate void VertexAttrib1dARB(GLuint index, GLdouble x);
            public delegate void VertexAttrib1dvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib1fARB(GLuint index, GLfloat x);
            public delegate void VertexAttrib1fvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib1sARB(GLuint index, GLshort x);
            public delegate void VertexAttrib1svARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y);
            public delegate void VertexAttrib2dvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y);
            public delegate void VertexAttrib2fvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2sARB(GLuint index, GLshort x, GLshort y);
            public delegate void VertexAttrib2svARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z);
            public delegate void VertexAttrib3dvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z);
            public delegate void VertexAttrib3fvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z);
            public delegate void VertexAttrib3svARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4NbvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4NivARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4NsvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
            public delegate void VertexAttrib4NubvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4NuivARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4NusvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4bvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void VertexAttrib4dvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void VertexAttrib4fvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4ivARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
            public delegate void VertexAttrib4svARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4ubvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4uivARB_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4usvARB_(GLuint index, IntPtr v);
            public delegate void VertexAttribPointerARB_(GLuint index, GLint size, GLenum type, Enums.Boolean normalized, GLsizei stride, IntPtr pointer);
            public delegate void EnableVertexAttribArrayARB(GLuint index);
            public delegate void DisableVertexAttribArrayARB(GLuint index);
            public delegate void ProgramStringARB_(GLenum target, GLenum format, GLsizei len, IntPtr @string);
            public delegate void BindProgramARB(GLenum target, GLuint program);
            public delegate void DeleteProgramsARB_(GLsizei n, IntPtr programs);
            public delegate void GenProgramsARB(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] programs);
            public delegate void ProgramEnvParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void ProgramEnvParameter4dvARB_(GLenum target, GLuint index, IntPtr parameters);
            public delegate void ProgramEnvParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void ProgramEnvParameter4fvARB_(GLenum target, GLuint index, IntPtr parameters);
            public delegate void ProgramLocalParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void ProgramLocalParameter4dvARB_(GLenum target, GLuint index, IntPtr parameters);
            public delegate void ProgramLocalParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void ProgramLocalParameter4fvARB_(GLenum target, GLuint index, IntPtr parameters);
            public delegate void GetProgramEnvParameterdvARB(GLenum target, GLuint index, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void GetProgramEnvParameterfvARB(GLenum target, GLuint index, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetProgramLocalParameterdvARB(GLenum target, GLuint index, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void GetProgramLocalParameterfvARB(GLenum target, GLuint index, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetProgramivARB(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetProgramStringARB_(GLenum target, GLenum pname, IntPtr @string);
            public delegate void GetVertexAttribdvARB(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void GetVertexAttribfvARB(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetVertexAttribivARB(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetVertexAttribPointervARB(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] pointer);
            public delegate GLboolean IsProgramARB(GLuint program);
            public delegate void BindBufferARB(GLenum target, GLuint buffer);
            public delegate void DeleteBuffersARB_(GLsizei n, IntPtr buffers);
            public delegate void GenBuffersARB(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] buffers);
            public delegate GLboolean IsBufferARB(GLuint buffer);
            public delegate void BufferDataARB_(GLenum target, GLsizeiptrARB size, IntPtr data, GLenum usage);
            public delegate void BufferSubDataARB_(GLenum target, GLintptrARB offset, GLsizeiptrARB size, IntPtr data);
            public delegate void GetBufferSubDataARB_(GLenum target, GLintptrARB offset, GLsizeiptrARB size, IntPtr data);
            public delegate IntPtr MapBufferARB(GLenum target, GLenum access);
            public delegate GLboolean UnmapBufferARB(GLenum target);
            public delegate void GetBufferParameterivARB(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetBufferPointervARB(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] parameters);
            public delegate void GenQueriesARB(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] ids);
            public delegate void DeleteQueriesARB_(GLsizei n, IntPtr ids);
            public delegate GLboolean IsQueryARB(GLuint id);
            public delegate void BeginQueryARB(Enums.ARB_occlusion_query target, GLuint id);
            public delegate void EndQueryARB(Enums.ARB_occlusion_query target);
            public delegate void GetQueryivARB(Enums.ARB_occlusion_query target, Enums.ARB_occlusion_query pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetQueryObjectivARB(GLuint id, Enums.ARB_occlusion_query pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetQueryObjectuivARB(GLuint id, Enums.ARB_occlusion_query pname, [MarshalAs(UnmanagedType.LPArray)] GLuint[] parameters);
            public delegate void DeleteObjectARB(GLhandleARB obj);
            public delegate GLhandleARB GetHandleARB(Enums.ARB_shader_objects pname);
            public delegate void DetachObjectARB(GLhandleARB containerObj, GLhandleARB attachedObj);
            public delegate GLhandleARB CreateShaderObjectARB(Enums.ARB_shader_objects shaderType);
            public delegate void ShaderSourceARB_(GLhandleARB shaderObj, GLsizei count, IntPtr @string, IntPtr length);
            public delegate void CompileShaderARB(GLhandleARB shaderObj);
            public delegate GLhandleARB CreateProgramObjectARB();
            public delegate void AttachObjectARB(GLhandleARB containerObj, GLhandleARB obj);
            public delegate void LinkProgramARB(GLhandleARB programObj);
            public delegate void UseProgramObjectARB(GLhandleARB programObj);
            public delegate void ValidateProgramARB(GLhandleARB programObj);
            public delegate void Uniform1fARB(GLint location, GLfloat v0);
            public delegate void Uniform2fARB(GLint location, GLfloat v0, GLfloat v1);
            public delegate void Uniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
            public delegate void Uniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
            public delegate void Uniform1iARB(GLint location, GLint v0);
            public delegate void Uniform2iARB(GLint location, GLint v0, GLint v1);
            public delegate void Uniform3iARB(GLint location, GLint v0, GLint v1, GLint v2);
            public delegate void Uniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
            public delegate void Uniform1fvARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform2fvARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform3fvARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform4fvARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform1ivARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform2ivARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform3ivARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void Uniform4ivARB_(GLint location, GLsizei count, IntPtr value);
            public delegate void UniformMatrix2fvARB_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            public delegate void UniformMatrix3fvARB_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            public delegate void UniformMatrix4fvARB_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            public delegate void GetObjectParameterfvARB(GLhandleARB obj, Enums.ARB_shader_objects pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetObjectParameterivARB(GLhandleARB obj, Enums.ARB_shader_objects pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetInfoLogARB(GLhandleARB obj, GLsizei maxLength, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLcharARB[] infoLog);
            public delegate void GetAttachedObjectsARB(GLhandleARB containerObj, GLsizei maxCount, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] count, [MarshalAs(UnmanagedType.LPArray)] GLhandleARB[] obj);
            public delegate GLint GetUniformLocationARB_(GLhandleARB programObj, IntPtr name);
            public delegate void GetActiveUniformARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLint[] size, [MarshalAs(UnmanagedType.LPArray)] Enums.ARB_shader_objects[] type, [MarshalAs(UnmanagedType.LPArray)] GLcharARB[] name);
            public delegate void GetUniformfvARB(GLhandleARB programObj, GLint location, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetUniformivARB(GLhandleARB programObj, GLint location, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetShaderSourceARB(GLhandleARB obj, GLsizei maxLength, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLcharARB[] source);
            public delegate void BindAttribLocationARB_(GLhandleARB programObj, GLuint index, IntPtr name);
            public delegate void GetActiveAttribARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLint[] size, [MarshalAs(UnmanagedType.LPArray)] Enums.ARB_vertex_shader[] type, [MarshalAs(UnmanagedType.LPArray)] GLcharARB[] name);
            public delegate GLint GetAttribLocationARB_(GLhandleARB programObj, IntPtr name);
            public delegate void DrawBuffersARB_(GLsizei n, IntPtr bufs);
            public delegate void ClampColorARB(GLenum target, GLenum clamp);
            public delegate void BlendColorEXT(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
            public delegate void PolygonOffsetEXT(GLfloat factor, GLfloat bias);
            public delegate void TexImage3DEXT(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void TexSubImage3DEXT(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void GetTexFilterFuncSGIS(Enums.TextureTarget target, GLenum filter, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] weights);
            public delegate void TexFilterFuncSGIS_(Enums.TextureTarget target, GLenum filter, GLsizei n, IntPtr weights);
            public delegate void TexSubImage1DEXT(Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void TexSubImage2DEXT(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void CopyTexImage1DEXT(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border);
            public delegate void CopyTexImage2DEXT(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
            public delegate void CopyTexSubImage1DEXT(Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
            public delegate void CopyTexSubImage2DEXT(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void CopyTexSubImage3DEXT(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void GetHistogramEXT_(Enums.HistogramTargetEXT target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values);
            public delegate void GetHistogramParameterfvEXT(Enums.HistogramTargetEXT target, Enums.GetHistogramParameterPNameEXT pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetHistogramParameterivEXT(Enums.HistogramTargetEXT target, Enums.GetHistogramParameterPNameEXT pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetMinmaxEXT_(Enums.MinmaxTargetEXT target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values);
            public delegate void GetMinmaxParameterfvEXT(Enums.MinmaxTargetEXT target, Enums.GetMinmaxParameterPNameEXT pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetMinmaxParameterivEXT(Enums.MinmaxTargetEXT target, Enums.GetMinmaxParameterPNameEXT pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void HistogramEXT(Enums.HistogramTargetEXT target, GLsizei width, Enums.PixelInternalFormat internalformat, Enums.Boolean sink);
            public delegate void MinmaxEXT(Enums.MinmaxTargetEXT target, Enums.PixelInternalFormat internalformat, Enums.Boolean sink);
            public delegate void ResetHistogramEXT(Enums.HistogramTargetEXT target);
            public delegate void ResetMinmaxEXT(Enums.MinmaxTargetEXT target);
            public delegate void ConvolutionFilter1DEXT_(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            public delegate void ConvolutionFilter2DEXT_(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            public delegate void ConvolutionParameterfEXT(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, GLfloat parameters);
            public delegate void ConvolutionParameterfvEXT_(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, IntPtr parameters);
            public delegate void ConvolutionParameteriEXT(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, GLint parameters);
            public delegate void ConvolutionParameterivEXT_(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, IntPtr parameters);
            public delegate void CopyConvolutionFilter1DEXT(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
            public delegate void CopyConvolutionFilter2DEXT(Enums.ConvolutionTargetEXT target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
            public delegate void GetConvolutionFilterEXT_(Enums.ConvolutionTargetEXT target, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            public delegate void GetConvolutionParameterfvEXT(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetConvolutionParameterivEXT(Enums.ConvolutionTargetEXT target, Enums.ConvolutionParameterEXT pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetSeparableFilterEXT_(Enums.SeparableTargetEXT target, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column, IntPtr span);
            public delegate void SeparableFilter2DEXT_(Enums.SeparableTargetEXT target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column);
            public delegate void ColorTableSGI_(Enums.ColorTableTargetSGI target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr table);
            public delegate void ColorTableParameterfvSGI_(Enums.ColorTableTargetSGI target, Enums.ColorTableParameterPNameSGI pname, IntPtr parameters);
            public delegate void ColorTableParameterivSGI_(Enums.ColorTableTargetSGI target, Enums.ColorTableParameterPNameSGI pname, IntPtr parameters);
            public delegate void CopyColorTableSGI(Enums.ColorTableTargetSGI target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
            public delegate void GetColorTableSGI_(Enums.ColorTableTargetSGI target, Enums.PixelFormat format, Enums.PixelType type, IntPtr table);
            public delegate void GetColorTableParameterfvSGI(Enums.ColorTableTargetSGI target, Enums.GetColorTableParameterPNameSGI pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetColorTableParameterivSGI(Enums.ColorTableTargetSGI target, Enums.GetColorTableParameterPNameSGI pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void PixelTexGenSGIX(GLenum mode);
            public delegate void PixelTexGenParameteriSGIS(Enums.PixelTexGenParameterNameSGIS pname, GLint param);
            public delegate void PixelTexGenParameterivSGIS_(Enums.PixelTexGenParameterNameSGIS pname, IntPtr parameters);
            public delegate void PixelTexGenParameterfSGIS(Enums.PixelTexGenParameterNameSGIS pname, GLfloat param);
            public delegate void PixelTexGenParameterfvSGIS_(Enums.PixelTexGenParameterNameSGIS pname, IntPtr parameters);
            public delegate void GetPixelTexGenParameterivSGIS(Enums.PixelTexGenParameterNameSGIS pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetPixelTexGenParameterfvSGIS(Enums.PixelTexGenParameterNameSGIS pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void TexImage4DSGIS(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate void TexSubImage4DSGIS(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            public delegate GLboolean AreTexturesResidentEXT_(GLsizei n, IntPtr textures, Enums.Boolean[] residences);
            public delegate void BindTextureEXT(Enums.TextureTarget target, GLuint texture);
            public delegate void DeleteTexturesEXT_(GLsizei n, IntPtr textures);
            public delegate void GenTexturesEXT(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] textures);
            public delegate GLboolean IsTextureEXT(GLuint texture);
            public delegate void PrioritizeTexturesEXT_(GLsizei n, IntPtr textures, IntPtr priorities);
            public delegate void DetailTexFuncSGIS_(Enums.TextureTarget target, GLsizei n, IntPtr points);
            public delegate void GetDetailTexFuncSGIS(Enums.TextureTarget target, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] points);
            public delegate void SharpenTexFuncSGIS_(Enums.TextureTarget target, GLsizei n, IntPtr points);
            public delegate void GetSharpenTexFuncSGIS(Enums.TextureTarget target, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] points);
            public delegate void SampleMaskSGIS(GLclampf value, Enums.Boolean invert);
            public delegate void SamplePatternSGIS(Enums.SamplePatternSGIS pattern);
            public delegate void ArrayElementEXT(GLint i);
            public delegate void ColorPointerEXT_(GLint size, Enums.ColorPointerType type, GLsizei stride, GLsizei count, IntPtr pointer);
            public delegate void DrawArraysEXT(Enums.BeginMode mode, GLint first, GLsizei count);
            public delegate void EdgeFlagPointerEXT(GLsizei stride, GLsizei count, Enums.Boolean[] pointer);
            public delegate void GetPointervEXT(Enums.GetPointervPName pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] parameters);
            public delegate void IndexPointerEXT_(Enums.IndexPointerType type, GLsizei stride, GLsizei count, IntPtr pointer);
            public delegate void NormalPointerEXT_(Enums.NormalPointerType type, GLsizei stride, GLsizei count, IntPtr pointer);
            public delegate void TexCoordPointerEXT_(GLint size, Enums.TexCoordPointerType type, GLsizei stride, GLsizei count, IntPtr pointer);
            public delegate void VertexPointerEXT_(GLint size, Enums.VertexPointerType type, GLsizei stride, GLsizei count, IntPtr pointer);
            public delegate void BlendEquationEXT(Enums.BlendEquationModeEXT mode);
            public delegate void SpriteParameterfSGIX(GLenum pname, GLfloat param);
            public delegate void SpriteParameterfvSGIX_(GLenum pname, IntPtr parameters);
            public delegate void SpriteParameteriSGIX(GLenum pname, GLint param);
            public delegate void SpriteParameterivSGIX_(GLenum pname, IntPtr parameters);
            public delegate void PointParameterfEXT(GLenum pname, GLfloat param);
            public delegate void PointParameterfvEXT_(GLenum pname, IntPtr parameters);
            public delegate void PointParameterfSGIS(GLenum pname, GLfloat param);
            public delegate void PointParameterfvSGIS_(GLenum pname, IntPtr parameters);
            public delegate GLint GetInstrumentsSGIX();
            public delegate void InstrumentsBufferSGIX(GLsizei size, [MarshalAs(UnmanagedType.LPArray)] GLint[] buffer);
            public delegate GLint PollInstrumentsSGIX([MarshalAs(UnmanagedType.LPArray)] GLint[] marker_p);
            public delegate void ReadInstrumentsSGIX(GLint marker);
            public delegate void StartInstrumentsSGIX();
            public delegate void StopInstrumentsSGIX(GLint marker);
            public delegate void FrameZoomSGIX(GLint factor);
            public delegate void TagSampleBufferSGIX();
            public delegate void DeformationMap3dSGIX_(Enums.FfdTargetSGIX target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, IntPtr points);
            public delegate void DeformationMap3fSGIX_(Enums.FfdTargetSGIX target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, IntPtr points);
            public delegate void DeformSGIX(Enums.FfdMaskSGIX mask);
            public delegate void LoadIdentityDeformationMapSGIX(Enums.FfdMaskSGIX mask);
            public delegate void ReferencePlaneSGIX_(IntPtr equation);
            public delegate void FlushRasterSGIX();
            public delegate void FogFuncSGIS_(GLsizei n, IntPtr points);
            public delegate void GetFogFuncSGIS([MarshalAs(UnmanagedType.LPArray)] GLfloat[] points);
            public delegate void ImageTransformParameteriHP(GLenum target, GLenum pname, GLint param);
            public delegate void ImageTransformParameterfHP(GLenum target, GLenum pname, GLfloat param);
            public delegate void ImageTransformParameterivHP_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void ImageTransformParameterfvHP_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void GetImageTransformParameterivHP(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetImageTransformParameterfvHP(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void ColorSubTableEXT_(GLenum target, GLsizei start, GLsizei count, Enums.PixelFormat format, Enums.PixelType type, IntPtr data);
            public delegate void CopyColorSubTableEXT(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
            public delegate void HintPGI(GLenum target, GLint mode);
            public delegate void ColorTableEXT_(GLenum target, Enums.PixelInternalFormat internalFormat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr table);
            public delegate void GetColorTableEXT_(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr data);
            public delegate void GetColorTableParameterivEXT(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetColorTableParameterfvEXT(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetListParameterfvSGIX(GLuint list, Enums.ListParameterName pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetListParameterivSGIX(GLuint list, Enums.ListParameterName pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void ListParameterfSGIX(GLuint list, Enums.ListParameterName pname, GLfloat param);
            public delegate void ListParameterfvSGIX_(GLuint list, Enums.ListParameterName pname, IntPtr parameters);
            public delegate void ListParameteriSGIX(GLuint list, Enums.ListParameterName pname, GLint param);
            public delegate void ListParameterivSGIX_(GLuint list, Enums.ListParameterName pname, IntPtr parameters);
            public delegate void IndexMaterialEXT(Enums.MaterialFace face, GLenum mode);
            public delegate void IndexFuncEXT(GLenum func, GLclampf reference);
            public delegate void LockArraysEXT(GLint first, GLsizei count);
            public delegate void UnlockArraysEXT();
            public delegate void CullParameterdvEXT(GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void CullParameterfvEXT(GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void FragmentColorMaterialSGIX(Enums.MaterialFace face, Enums.MaterialParameter mode);
            public delegate void FragmentLightfSGIX(GLenum light, GLenum pname, GLfloat param);
            public delegate void FragmentLightfvSGIX_(GLenum light, GLenum pname, IntPtr parameters);
            public delegate void FragmentLightiSGIX(GLenum light, GLenum pname, GLint param);
            public delegate void FragmentLightivSGIX_(GLenum light, GLenum pname, IntPtr parameters);
            public delegate void FragmentLightModelfSGIX(Enums.FragmentLightModelParameterSGIX pname, GLfloat param);
            public delegate void FragmentLightModelfvSGIX_(Enums.FragmentLightModelParameterSGIX pname, IntPtr parameters);
            public delegate void FragmentLightModeliSGIX(Enums.FragmentLightModelParameterSGIX pname, GLint param);
            public delegate void FragmentLightModelivSGIX_(Enums.FragmentLightModelParameterSGIX pname, IntPtr parameters);
            public delegate void FragmentMaterialfSGIX(Enums.MaterialFace face, Enums.MaterialParameter pname, GLfloat param);
            public delegate void FragmentMaterialfvSGIX_(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters);
            public delegate void FragmentMaterialiSGIX(Enums.MaterialFace face, Enums.MaterialParameter pname, GLint param);
            public delegate void FragmentMaterialivSGIX_(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters);
            public delegate void GetFragmentLightfvSGIX(GLenum light, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetFragmentLightivSGIX(GLenum light, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetFragmentMaterialfvSGIX(Enums.MaterialFace face, Enums.MaterialParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetFragmentMaterialivSGIX(Enums.MaterialFace face, Enums.MaterialParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void LightEnviSGIX(Enums.LightEnvParameterSGIX pname, GLint param);
            public delegate void DrawRangeElementsEXT_(Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GLenum type, IntPtr indices);
            public delegate void ApplyTextureEXT(GLenum mode);
            public delegate void TextureLightEXT(GLenum pname);
            public delegate void TextureMaterialEXT(Enums.MaterialFace face, Enums.MaterialParameter mode);
            public delegate void AsyncMarkerSGIX(GLuint marker);
            public delegate GLint FinishAsyncSGIX([MarshalAs(UnmanagedType.LPArray)] GLuint[] markerp);
            public delegate GLint PollAsyncSGIX([MarshalAs(UnmanagedType.LPArray)] GLuint[] markerp);
            public delegate GLuint GenAsyncMarkersSGIX(GLsizei range);
            public delegate void DeleteAsyncMarkersSGIX(GLuint marker, GLsizei range);
            public delegate GLboolean IsAsyncMarkerSGIX(GLuint marker);
            public delegate void VertexPointervINTEL_(GLint size, Enums.VertexPointerType type, IntPtr pointer);
            public delegate void NormalPointervINTEL_(Enums.NormalPointerType type, IntPtr pointer);
            public delegate void ColorPointervINTEL_(GLint size, Enums.VertexPointerType type, IntPtr pointer);
            public delegate void TexCoordPointervINTEL_(GLint size, Enums.VertexPointerType type, IntPtr pointer);
            public delegate void PixelTransformParameteriEXT(GLenum target, GLenum pname, GLint param);
            public delegate void PixelTransformParameterfEXT(GLenum target, GLenum pname, GLfloat param);
            public delegate void PixelTransformParameterivEXT_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void PixelTransformParameterfvEXT_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void SecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue);
            public delegate void SecondaryColor3bvEXT_(IntPtr v);
            public delegate void SecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue);
            public delegate void SecondaryColor3dvEXT_(IntPtr v);
            public delegate void SecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue);
            public delegate void SecondaryColor3fvEXT_(IntPtr v);
            public delegate void SecondaryColor3iEXT(GLint red, GLint green, GLint blue);
            public delegate void SecondaryColor3ivEXT_(IntPtr v);
            public delegate void SecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue);
            public delegate void SecondaryColor3svEXT_(IntPtr v);
            public delegate void SecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue);
            public delegate void SecondaryColor3ubvEXT_(IntPtr v);
            public delegate void SecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue);
            public delegate void SecondaryColor3uivEXT_(IntPtr v);
            public delegate void SecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue);
            public delegate void SecondaryColor3usvEXT_(IntPtr v);
            public delegate void SecondaryColorPointerEXT_(GLint size, Enums.ColorPointerType type, GLsizei stride, IntPtr pointer);
            public delegate void TextureNormalEXT(GLenum mode);
            public delegate void MultiDrawArraysEXT(Enums.BeginMode mode, [MarshalAs(UnmanagedType.LPArray)] GLint[] first, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] count, GLsizei primcount);
            public delegate void MultiDrawElementsEXT_(Enums.BeginMode mode, IntPtr count, GLenum type, IntPtr indices, GLsizei primcount);
            public delegate void FogCoordfEXT(GLfloat coord);
            public delegate void FogCoordfvEXT_(IntPtr coord);
            public delegate void FogCoorddEXT(GLdouble coord);
            public delegate void FogCoorddvEXT_(IntPtr coord);
            public delegate void FogCoordPointerEXT_(GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void Tangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz);
            public delegate void Tangent3bvEXT_(IntPtr v);
            public delegate void Tangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz);
            public delegate void Tangent3dvEXT_(IntPtr v);
            public delegate void Tangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz);
            public delegate void Tangent3fvEXT_(IntPtr v);
            public delegate void Tangent3iEXT(GLint tx, GLint ty, GLint tz);
            public delegate void Tangent3ivEXT_(IntPtr v);
            public delegate void Tangent3sEXT(GLshort tx, GLshort ty, GLshort tz);
            public delegate void Tangent3svEXT_(IntPtr v);
            public delegate void Binormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz);
            public delegate void Binormal3bvEXT_(IntPtr v);
            public delegate void Binormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz);
            public delegate void Binormal3dvEXT_(IntPtr v);
            public delegate void Binormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz);
            public delegate void Binormal3fvEXT_(IntPtr v);
            public delegate void Binormal3iEXT(GLint bx, GLint by, GLint bz);
            public delegate void Binormal3ivEXT_(IntPtr v);
            public delegate void Binormal3sEXT(GLshort bx, GLshort by, GLshort bz);
            public delegate void Binormal3svEXT_(IntPtr v);
            public delegate void TangentPointerEXT_(GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void BinormalPointerEXT_(GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void FinishTextureSUNX();
            public delegate void GlobalAlphaFactorbSUN(GLbyte factor);
            public delegate void GlobalAlphaFactorsSUN(GLshort factor);
            public delegate void GlobalAlphaFactoriSUN(GLint factor);
            public delegate void GlobalAlphaFactorfSUN(GLfloat factor);
            public delegate void GlobalAlphaFactordSUN(GLdouble factor);
            public delegate void GlobalAlphaFactorubSUN(GLubyte factor);
            public delegate void GlobalAlphaFactorusSUN(GLushort factor);
            public delegate void GlobalAlphaFactoruiSUN(GLuint factor);
            public delegate void ReplacementCodeuiSUN(GLuint code);
            public delegate void ReplacementCodeusSUN(GLushort code);
            public delegate void ReplacementCodeubSUN(GLubyte code);
            public delegate void ReplacementCodeuivSUN_(IntPtr code);
            public delegate void ReplacementCodeusvSUN_(IntPtr code);
            public delegate void ReplacementCodeubvSUN_(IntPtr code);
            public delegate void ReplacementCodePointerSUN_(GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void Color4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y);
            public delegate void Color4ubVertex2fvSUN_(IntPtr c, IntPtr v);
            public delegate void Color4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
            public delegate void Color4ubVertex3fvSUN_(IntPtr c, IntPtr v);
            public delegate void Color3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
            public delegate void Color3fVertex3fvSUN_(IntPtr c, IntPtr v);
            public delegate void Normal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void Normal3fVertex3fvSUN_(IntPtr n, IntPtr v);
            public delegate void Color4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void Color4fNormal3fVertex3fvSUN_(IntPtr c, IntPtr n, IntPtr v);
            public delegate void TexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
            public delegate void TexCoord2fVertex3fvSUN_(IntPtr tc, IntPtr v);
            public delegate void TexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void TexCoord4fVertex4fvSUN_(IntPtr tc, IntPtr v);
            public delegate void TexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
            public delegate void TexCoord2fColor4ubVertex3fvSUN_(IntPtr tc, IntPtr c, IntPtr v);
            public delegate void TexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
            public delegate void TexCoord2fColor3fVertex3fvSUN_(IntPtr tc, IntPtr c, IntPtr v);
            public delegate void TexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void TexCoord2fNormal3fVertex3fvSUN_(IntPtr tc, IntPtr n, IntPtr v);
            public delegate void TexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void TexCoord2fColor4fNormal3fVertex3fvSUN_(IntPtr tc, IntPtr c, IntPtr n, IntPtr v);
            public delegate void TexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void TexCoord4fColor4fNormal3fVertex4fvSUN_(IntPtr tc, IntPtr c, IntPtr n, IntPtr v);
            public delegate void ReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiVertex3fvSUN_(IntPtr rc, IntPtr v);
            public delegate void ReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiColor4ubVertex3fvSUN_(IntPtr rc, IntPtr c, IntPtr v);
            public delegate void ReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiColor3fVertex3fvSUN_(IntPtr rc, IntPtr c, IntPtr v);
            public delegate void ReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiNormal3fVertex3fvSUN_(IntPtr rc, IntPtr n, IntPtr v);
            public delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN_(IntPtr rc, IntPtr c, IntPtr n, IntPtr v);
            public delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN_(IntPtr rc, IntPtr tc, IntPtr v);
            public delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN_(IntPtr rc, IntPtr tc, IntPtr n, IntPtr v);
            public delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
            public delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN_(IntPtr rc, IntPtr tc, IntPtr c, IntPtr n, IntPtr v);
            public delegate void BlendFuncSeparateEXT(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
            public delegate void BlendFuncSeparateINGR(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
            public delegate void VertexWeightfEXT(GLfloat weight);
            public delegate void VertexWeightfvEXT_(IntPtr weight);
            public delegate void VertexWeightPointerEXT_(GLsizei size, GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void FlushVertexArrayRangeNV();
            public delegate void VertexArrayRangeNV_(GLsizei length, IntPtr pointer);
            public delegate void CombinerParameterfvNV_(GLenum pname, IntPtr parameters);
            public delegate void CombinerParameterfNV(GLenum pname, GLfloat param);
            public delegate void CombinerParameterivNV_(GLenum pname, IntPtr parameters);
            public delegate void CombinerParameteriNV(GLenum pname, GLint param);
            public delegate void CombinerInputNV(GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
            public delegate void CombinerOutputNV(GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, Enums.Boolean abDotProduct, Enums.Boolean cdDotProduct, Enums.Boolean muxSum);
            public delegate void FinalCombinerInputNV(GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
            public delegate void GetCombinerInputParameterfvNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetCombinerInputParameterivNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetCombinerOutputParameterfvNV(GLenum stage, GLenum portion, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetCombinerOutputParameterivNV(GLenum stage, GLenum portion, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetFinalCombinerInputParameterfvNV(GLenum variable, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetFinalCombinerInputParameterivNV(GLenum variable, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void ResizeBuffersMESA();
            public delegate void WindowPos2dMESA(GLdouble x, GLdouble y);
            public delegate void WindowPos2dvMESA_(IntPtr v);
            public delegate void WindowPos2fMESA(GLfloat x, GLfloat y);
            public delegate void WindowPos2fvMESA_(IntPtr v);
            public delegate void WindowPos2iMESA(GLint x, GLint y);
            public delegate void WindowPos2ivMESA_(IntPtr v);
            public delegate void WindowPos2sMESA(GLshort x, GLshort y);
            public delegate void WindowPos2svMESA_(IntPtr v);
            public delegate void WindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z);
            public delegate void WindowPos3dvMESA_(IntPtr v);
            public delegate void WindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z);
            public delegate void WindowPos3fvMESA_(IntPtr v);
            public delegate void WindowPos3iMESA(GLint x, GLint y, GLint z);
            public delegate void WindowPos3ivMESA_(IntPtr v);
            public delegate void WindowPos3sMESA(GLshort x, GLshort y, GLshort z);
            public delegate void WindowPos3svMESA_(IntPtr v);
            public delegate void WindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void WindowPos4dvMESA_(IntPtr v);
            public delegate void WindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void WindowPos4fvMESA_(IntPtr v);
            public delegate void WindowPos4iMESA(GLint x, GLint y, GLint z, GLint w);
            public delegate void WindowPos4ivMESA_(IntPtr v);
            public delegate void WindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w);
            public delegate void WindowPos4svMESA_(IntPtr v);
            public delegate void MultiModeDrawArraysIBM_(Enums.BeginMode[] mode, IntPtr first, IntPtr count, GLsizei primcount, GLint modestride);
            public delegate void MultiModeDrawElementsIBM_(Enums.BeginMode[] mode, IntPtr count, GLenum type, IntPtr indices, GLsizei primcount, GLint modestride);
            public delegate void ColorPointerListIBM_(GLint size, Enums.ColorPointerType type, GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void SecondaryColorPointerListIBM_(GLint size, GLenum type, GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void EdgeFlagPointerListIBM_(GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void FogCoordPointerListIBM_(GLenum type, GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void IndexPointerListIBM_(Enums.IndexPointerType type, GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void NormalPointerListIBM_(Enums.NormalPointerType type, GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void TexCoordPointerListIBM_(GLint size, Enums.TexCoordPointerType type, GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void VertexPointerListIBM_(GLint size, Enums.VertexPointerType type, GLint stride, IntPtr pointer, GLint ptrstride);
            public delegate void TbufferMask3DFX(GLuint mask);
            public delegate void SampleMaskEXT(GLclampf value, Enums.Boolean invert);
            public delegate void SamplePatternEXT(GLenum pattern);
            public delegate void TextureColorMaskSGIS(Enums.Boolean red, Enums.Boolean green, Enums.Boolean blue, Enums.Boolean alpha);
            public delegate void IglooInterfaceSGIX_(GLenum pname, IntPtr parameters);
            public delegate void DeleteFencesNV_(GLsizei n, IntPtr fences);
            public delegate void GenFencesNV(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] fences);
            public delegate GLboolean IsFenceNV(GLuint fence);
            public delegate GLboolean TestFenceNV(GLuint fence);
            public delegate void GetFenceivNV(GLuint fence, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void FinishFenceNV(GLuint fence);
            public delegate void SetFenceNV(GLuint fence, GLenum condition);
            public delegate void MapControlPointsNV_(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, Enums.Boolean packed, IntPtr points);
            public delegate void MapParameterivNV_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void MapParameterfvNV_(GLenum target, GLenum pname, IntPtr parameters);
            public delegate void GetMapControlPointsNV_(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, Enums.Boolean packed, IntPtr points);
            public delegate void GetMapParameterivNV(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetMapParameterfvNV(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetMapAttribParameterivNV(GLenum target, GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetMapAttribParameterfvNV(GLenum target, GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void EvalMapsNV(GLenum target, GLenum mode);
            public delegate void CombinerStageParameterfvNV_(GLenum stage, GLenum pname, IntPtr parameters);
            public delegate void GetCombinerStageParameterfvNV(GLenum stage, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate GLboolean AreProgramsResidentNV_(GLsizei n, IntPtr programs, Enums.Boolean[] residences);
            public delegate void BindProgramNV(GLenum target, GLuint id);
            public delegate void DeleteProgramsNV_(GLsizei n, IntPtr programs);
            public delegate void ExecuteProgramNV_(GLenum target, GLuint id, IntPtr parameters);
            public delegate void GenProgramsNV(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] programs);
            public delegate void GetProgramParameterdvNV(GLenum target, GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void GetProgramParameterfvNV(GLenum target, GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetProgramivNV(GLuint id, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetProgramStringNV(GLuint id, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLubyte[] program);
            public delegate void GetTrackMatrixivNV(GLenum target, GLuint address, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetVertexAttribdvNV(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void GetVertexAttribfvNV(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetVertexAttribivNV(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetVertexAttribPointervNV(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] pointer);
            public delegate GLboolean IsProgramNV(GLuint id);
            public delegate void LoadProgramNV_(GLenum target, GLuint id, GLsizei len, IntPtr program);
            public delegate void ProgramParameter4dNV(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void ProgramParameter4dvNV_(GLenum target, GLuint index, IntPtr v);
            public delegate void ProgramParameter4fNV(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void ProgramParameter4fvNV_(GLenum target, GLuint index, IntPtr v);
            public delegate void ProgramParameters4dvNV_(GLenum target, GLuint index, GLuint count, IntPtr v);
            public delegate void ProgramParameters4fvNV_(GLenum target, GLuint index, GLuint count, IntPtr v);
            public delegate void RequestResidentProgramsNV_(GLsizei n, IntPtr programs);
            public delegate void TrackMatrixNV(GLenum target, GLuint address, GLenum matrix, GLenum transform);
            public delegate void VertexAttribPointerNV_(GLuint index, GLint fsize, GLenum type, GLsizei stride, IntPtr pointer);
            public delegate void VertexAttrib1dNV(GLuint index, GLdouble x);
            public delegate void VertexAttrib1dvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib1fNV(GLuint index, GLfloat x);
            public delegate void VertexAttrib1fvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib1sNV(GLuint index, GLshort x);
            public delegate void VertexAttrib1svNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y);
            public delegate void VertexAttrib2dvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y);
            public delegate void VertexAttrib2fvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2sNV(GLuint index, GLshort x, GLshort y);
            public delegate void VertexAttrib2svNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z);
            public delegate void VertexAttrib3dvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z);
            public delegate void VertexAttrib3fvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z);
            public delegate void VertexAttrib3svNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void VertexAttrib4dvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void VertexAttrib4fvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
            public delegate void VertexAttrib4svNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
            public delegate void VertexAttrib4ubvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttribs1dvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs1fvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs1svNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs2dvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs2fvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs2svNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs3dvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs3fvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs3svNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs4dvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs4fvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs4svNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void VertexAttribs4ubvNV_(GLuint index, GLsizei count, IntPtr v);
            public delegate void TexBumpParameterivATI_(GLenum pname, IntPtr param);
            public delegate void TexBumpParameterfvATI_(GLenum pname, IntPtr param);
            public delegate void GetTexBumpParameterivATI(GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] param);
            public delegate void GetTexBumpParameterfvATI(GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] param);
            public delegate GLuint GenFragmentShadersATI(GLuint range);
            public delegate void BindFragmentShaderATI(GLuint id);
            public delegate void DeleteFragmentShaderATI(GLuint id);
            public delegate void BeginFragmentShaderATI();
            public delegate void EndFragmentShaderATI();
            public delegate void PassTexCoordATI(GLuint dst, GLuint coord, GLenum swizzle);
            public delegate void SampleMapATI(GLuint dst, GLuint interp, GLenum swizzle);
            public delegate void ColorFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
            public delegate void ColorFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
            public delegate void ColorFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
            public delegate void AlphaFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
            public delegate void AlphaFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
            public delegate void AlphaFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
            public delegate void SetFragmentShaderConstantATI_(GLuint dst, IntPtr value);
            public delegate void PNTrianglesiATI(GLenum pname, GLint param);
            public delegate void PNTrianglesfATI(GLenum pname, GLfloat param);
            public delegate GLuint NewObjectBufferATI_(GLsizei size, IntPtr pointer, GLenum usage);
            public delegate GLboolean IsObjectBufferATI(GLuint buffer);
            public delegate void UpdateObjectBufferATI_(GLuint buffer, GLuint offset, GLsizei size, IntPtr pointer, GLenum preserve);
            public delegate void GetObjectBufferfvATI(GLuint buffer, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetObjectBufferivATI(GLuint buffer, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void FreeObjectBufferATI(GLuint buffer);
            public delegate void ArrayObjectATI(Enums.EnableCap array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
            public delegate void GetArrayObjectfvATI(Enums.EnableCap array, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetArrayObjectivATI(Enums.EnableCap array, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void VariantArrayObjectATI(GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
            public delegate void GetVariantArrayObjectfvATI(GLuint id, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetVariantArrayObjectivATI(GLuint id, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void BeginVertexShaderEXT();
            public delegate void EndVertexShaderEXT();
            public delegate void BindVertexShaderEXT(GLuint id);
            public delegate GLuint GenVertexShadersEXT(GLuint range);
            public delegate void DeleteVertexShaderEXT(GLuint id);
            public delegate void ShaderOp1EXT(GLenum op, GLuint res, GLuint arg1);
            public delegate void ShaderOp2EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2);
            public delegate void ShaderOp3EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
            public delegate void SwizzleEXT(GLuint res, GLuint @in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
            public delegate void WriteMaskEXT(GLuint res, GLuint @in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
            public delegate void InsertComponentEXT(GLuint res, GLuint src, GLuint num);
            public delegate void ExtractComponentEXT(GLuint res, GLuint src, GLuint num);
            public delegate GLuint GenSymbolsEXT(GLenum datatype, GLenum storagetype, GLenum range, GLuint components);
            public delegate void SetInvariantEXT_(GLuint id, GLenum type, IntPtr addr);
            public delegate void SetLocalConstantEXT_(GLuint id, GLenum type, IntPtr addr);
            public delegate void VariantbvEXT_(GLuint id, IntPtr addr);
            public delegate void VariantsvEXT_(GLuint id, IntPtr addr);
            public delegate void VariantivEXT_(GLuint id, IntPtr addr);
            public delegate void VariantfvEXT_(GLuint id, IntPtr addr);
            public delegate void VariantdvEXT_(GLuint id, IntPtr addr);
            public delegate void VariantubvEXT_(GLuint id, IntPtr addr);
            public delegate void VariantusvEXT_(GLuint id, IntPtr addr);
            public delegate void VariantuivEXT_(GLuint id, IntPtr addr);
            public delegate void VariantPointerEXT_(GLuint id, GLenum type, GLuint stride, IntPtr addr);
            public delegate void EnableVariantClientStateEXT(GLuint id);
            public delegate void DisableVariantClientStateEXT(GLuint id);
            public delegate GLuint BindLightParameterEXT(Enums.LightName light, Enums.LightParameter value);
            public delegate GLuint BindMaterialParameterEXT(Enums.MaterialFace face, Enums.MaterialParameter value);
            public delegate GLuint BindTexGenParameterEXT(GLenum unit, Enums.TextureCoordName coord, Enums.TextureGenParameter value);
            public delegate GLuint BindTextureUnitParameterEXT(GLenum unit, GLenum value);
            public delegate GLuint BindParameterEXT(GLenum value);
            public delegate GLboolean IsVariantEnabledEXT(GLuint id, GLenum cap);
            public delegate void GetVariantBooleanvEXT(GLuint id, GLenum value, Enums.Boolean[] data);
            public delegate void GetVariantIntegervEXT(GLuint id, GLenum value, [MarshalAs(UnmanagedType.LPArray)] GLint[] data);
            public delegate void GetVariantFloatvEXT(GLuint id, GLenum value, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] data);
            public delegate void GetVariantPointervEXT(GLuint id, GLenum value, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] data);
            public delegate void GetInvariantBooleanvEXT(GLuint id, GLenum value, Enums.Boolean[] data);
            public delegate void GetInvariantIntegervEXT(GLuint id, GLenum value, [MarshalAs(UnmanagedType.LPArray)] GLint[] data);
            public delegate void GetInvariantFloatvEXT(GLuint id, GLenum value, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] data);
            public delegate void GetLocalConstantBooleanvEXT(GLuint id, GLenum value, Enums.Boolean[] data);
            public delegate void GetLocalConstantIntegervEXT(GLuint id, GLenum value, [MarshalAs(UnmanagedType.LPArray)] GLint[] data);
            public delegate void GetLocalConstantFloatvEXT(GLuint id, GLenum value, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] data);
            public delegate void VertexStream1sATI(GLenum stream, GLshort x);
            public delegate void VertexStream1svATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream1iATI(GLenum stream, GLint x);
            public delegate void VertexStream1ivATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream1fATI(GLenum stream, GLfloat x);
            public delegate void VertexStream1fvATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream1dATI(GLenum stream, GLdouble x);
            public delegate void VertexStream1dvATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream2sATI(GLenum stream, GLshort x, GLshort y);
            public delegate void VertexStream2svATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream2iATI(GLenum stream, GLint x, GLint y);
            public delegate void VertexStream2ivATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream2fATI(GLenum stream, GLfloat x, GLfloat y);
            public delegate void VertexStream2fvATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream2dATI(GLenum stream, GLdouble x, GLdouble y);
            public delegate void VertexStream2dvATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream3sATI(GLenum stream, GLshort x, GLshort y, GLshort z);
            public delegate void VertexStream3svATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream3iATI(GLenum stream, GLint x, GLint y, GLint z);
            public delegate void VertexStream3ivATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream3fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z);
            public delegate void VertexStream3fvATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream3dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z);
            public delegate void VertexStream3dvATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream4sATI(GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w);
            public delegate void VertexStream4svATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream4iATI(GLenum stream, GLint x, GLint y, GLint z, GLint w);
            public delegate void VertexStream4ivATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream4fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void VertexStream4fvATI_(GLenum stream, IntPtr coords);
            public delegate void VertexStream4dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void VertexStream4dvATI_(GLenum stream, IntPtr coords);
            public delegate void NormalStream3bATI(GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz);
            public delegate void NormalStream3bvATI_(GLenum stream, IntPtr coords);
            public delegate void NormalStream3sATI(GLenum stream, GLshort nx, GLshort ny, GLshort nz);
            public delegate void NormalStream3svATI_(GLenum stream, IntPtr coords);
            public delegate void NormalStream3iATI(GLenum stream, GLint nx, GLint ny, GLint nz);
            public delegate void NormalStream3ivATI_(GLenum stream, IntPtr coords);
            public delegate void NormalStream3fATI(GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz);
            public delegate void NormalStream3fvATI_(GLenum stream, IntPtr coords);
            public delegate void NormalStream3dATI(GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz);
            public delegate void NormalStream3dvATI_(GLenum stream, IntPtr coords);
            public delegate void ClientActiveVertexStreamATI(GLenum stream);
            public delegate void VertexBlendEnviATI(GLenum pname, GLint param);
            public delegate void VertexBlendEnvfATI(GLenum pname, GLfloat param);
            public delegate void ElementPointerATI_(GLenum type, IntPtr pointer);
            public delegate void DrawElementArrayATI(Enums.BeginMode mode, GLsizei count);
            public delegate void DrawRangeElementArrayATI(Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count);
            public delegate void DrawMeshArraysSUN(Enums.BeginMode mode, GLint first, GLsizei count, GLsizei width);
            public delegate void GenOcclusionQueriesNV(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] ids);
            public delegate void DeleteOcclusionQueriesNV_(GLsizei n, IntPtr ids);
            public delegate GLboolean IsOcclusionQueryNV(GLuint id);
            public delegate void BeginOcclusionQueryNV(GLuint id);
            public delegate void EndOcclusionQueryNV();
            public delegate void GetOcclusionQueryivNV(GLuint id, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GetOcclusionQueryuivNV(GLuint id, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLuint[] parameters);
            public delegate void PointParameteriNV(GLenum pname, GLint param);
            public delegate void PointParameterivNV_(GLenum pname, IntPtr parameters);
            public delegate void ActiveStencilFaceEXT(GLenum face);
            public delegate void ElementPointerAPPLE_(GLenum type, IntPtr pointer);
            public delegate void DrawElementArrayAPPLE(Enums.BeginMode mode, GLint first, GLsizei count);
            public delegate void DrawRangeElementArrayAPPLE(Enums.BeginMode mode, GLuint start, GLuint end, GLint first, GLsizei count);
            public delegate void MultiDrawElementArrayAPPLE_(Enums.BeginMode mode, IntPtr first, IntPtr count, GLsizei primcount);
            public delegate void MultiDrawRangeElementArrayAPPLE_(Enums.BeginMode mode, GLuint start, GLuint end, IntPtr first, IntPtr count, GLsizei primcount);
            public delegate void GenFencesAPPLE(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] fences);
            public delegate void DeleteFencesAPPLE_(GLsizei n, IntPtr fences);
            public delegate void SetFenceAPPLE(GLuint fence);
            public delegate GLboolean IsFenceAPPLE(GLuint fence);
            public delegate GLboolean TestFenceAPPLE(GLuint fence);
            public delegate void FinishFenceAPPLE(GLuint fence);
            public delegate GLboolean TestObjectAPPLE(GLenum @object, GLuint name);
            public delegate void FinishObjectAPPLE(GLenum @object, GLint name);
            public delegate void BindVertexArrayAPPLE(GLuint array);
            public delegate void DeleteVertexArraysAPPLE_(GLsizei n, IntPtr arrays);
            public delegate void GenVertexArraysAPPLE_(GLsizei n, IntPtr arrays);
            public delegate GLboolean IsVertexArrayAPPLE(GLuint array);
            public delegate void VertexArrayRangeAPPLE_(GLsizei length, IntPtr pointer);
            public delegate void FlushVertexArrayRangeAPPLE_(GLsizei length, IntPtr pointer);
            public delegate void VertexArrayParameteriAPPLE(GLenum pname, GLint param);
            public delegate void DrawBuffersATI_(GLsizei n, IntPtr bufs);
            public delegate void ProgramNamedParameter4fNV_(GLuint id, GLsizei len, IntPtr name, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            public delegate void ProgramNamedParameter4dNV_(GLuint id, GLsizei len, IntPtr name, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            public delegate void ProgramNamedParameter4fvNV_(GLuint id, GLsizei len, IntPtr name, IntPtr v);
            public delegate void ProgramNamedParameter4dvNV_(GLuint id, GLsizei len, IntPtr name, IntPtr v);
            public delegate void GetProgramNamedParameterfvNV_(GLuint id, GLsizei len, IntPtr name, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetProgramNamedParameterdvNV_(GLuint id, GLsizei len, IntPtr name, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            public delegate void Vertex2hNV(GLhalfNV x, GLhalfNV y);
            public delegate void Vertex2hvNV_(IntPtr v);
            public delegate void Vertex3hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z);
            public delegate void Vertex3hvNV_(IntPtr v);
            public delegate void Vertex4hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
            public delegate void Vertex4hvNV_(IntPtr v);
            public delegate void Normal3hNV(GLhalfNV nx, GLhalfNV ny, GLhalfNV nz);
            public delegate void Normal3hvNV_(IntPtr v);
            public delegate void Color3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);
            public delegate void Color3hvNV_(IntPtr v);
            public delegate void Color4hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha);
            public delegate void Color4hvNV_(IntPtr v);
            public delegate void TexCoord1hNV(GLhalfNV s);
            public delegate void TexCoord1hvNV_(IntPtr v);
            public delegate void TexCoord2hNV(GLhalfNV s, GLhalfNV t);
            public delegate void TexCoord2hvNV_(IntPtr v);
            public delegate void TexCoord3hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r);
            public delegate void TexCoord3hvNV_(IntPtr v);
            public delegate void TexCoord4hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
            public delegate void TexCoord4hvNV_(IntPtr v);
            public delegate void MultiTexCoord1hNV(GLenum target, GLhalfNV s);
            public delegate void MultiTexCoord1hvNV_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord2hNV(GLenum target, GLhalfNV s, GLhalfNV t);
            public delegate void MultiTexCoord2hvNV_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord3hNV(GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r);
            public delegate void MultiTexCoord3hvNV_(GLenum target, IntPtr v);
            public delegate void MultiTexCoord4hNV(GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
            public delegate void MultiTexCoord4hvNV_(GLenum target, IntPtr v);
            public delegate void FogCoordhNV(GLhalfNV fog);
            public delegate void FogCoordhvNV_(IntPtr fog);
            public delegate void SecondaryColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);
            public delegate void SecondaryColor3hvNV_(IntPtr v);
            public delegate void VertexWeighthNV(GLhalfNV weight);
            public delegate void VertexWeighthvNV_(IntPtr weight);
            public delegate void VertexAttrib1hNV(GLuint index, GLhalfNV x);
            public delegate void VertexAttrib1hvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib2hNV(GLuint index, GLhalfNV x, GLhalfNV y);
            public delegate void VertexAttrib2hvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib3hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z);
            public delegate void VertexAttrib3hvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttrib4hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
            public delegate void VertexAttrib4hvNV_(GLuint index, IntPtr v);
            public delegate void VertexAttribs1hvNV_(GLuint index, GLsizei n, IntPtr v);
            public delegate void VertexAttribs2hvNV_(GLuint index, GLsizei n, IntPtr v);
            public delegate void VertexAttribs3hvNV_(GLuint index, GLsizei n, IntPtr v);
            public delegate void VertexAttribs4hvNV_(GLuint index, GLsizei n, IntPtr v);
            public delegate void PixelDataRangeNV_(GLenum target, GLsizei length, IntPtr pointer);
            public delegate void FlushPixelDataRangeNV(GLenum target);
            public delegate void PrimitiveRestartNV();
            public delegate void PrimitiveRestartIndexNV(GLuint index);
            public delegate IntPtr MapObjectBufferATI(GLuint buffer);
            public delegate void UnmapObjectBufferATI(GLuint buffer);
            public delegate void StencilOpSeparateATI(GLenum face, Enums.StencilOp sfail, Enums.StencilOp dpfail, Enums.StencilOp dppass);
            public delegate void StencilFuncSeparateATI(Enums.StencilFunction frontfunc, Enums.StencilFunction backfunc, GLint reference, GLuint mask);
            public delegate void VertexAttribArrayObjectATI(GLuint index, GLint size, GLenum type, Enums.Boolean normalized, GLsizei stride, GLuint buffer, GLuint offset);
            public delegate void GetVertexAttribArrayObjectfvATI(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            public delegate void GetVertexAttribArrayObjectivATI(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void DepthBoundsEXT(GLclampd zmin, GLclampd zmax);
            public delegate void BlendEquationSeparateEXT(Enums.BlendEquationModeEXT modeRGB, Enums.BlendEquationModeEXT modeAlpha);
            public delegate GLboolean IsRenderbufferEXT(GLuint renderbuffer);
            public delegate void BindRenderbufferEXT(Enums.EXT_framebuffer_object target, GLuint renderbuffer);
            public delegate void DeleteRenderbuffersEXT_(GLsizei n, IntPtr renderbuffers);
            public delegate void GenRenderbuffersEXT(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] renderbuffers);
            public delegate void RenderbufferStorageEXT(Enums.EXT_framebuffer_object target, Enums.EXT_framebuffer_object internalformat, GLsizei width, GLsizei height);
            public delegate void GetRenderbufferParameterivEXT(Enums.EXT_framebuffer_object target, Enums.EXT_framebuffer_object pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate GLboolean IsFramebufferEXT(GLuint framebuffer);
            public delegate void BindFramebufferEXT(Enums.EXT_framebuffer_object target, GLuint framebuffer);
            public delegate void DeleteFramebuffersEXT_(GLsizei n, IntPtr framebuffers);
            public delegate void GenFramebuffersEXT(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] framebuffers);
            public delegate GLenum CheckFramebufferStatusEXT(Enums.EXT_framebuffer_object target);
            public delegate void FramebufferTexture1DEXT(Enums.EXT_framebuffer_object target, Enums.EXT_framebuffer_object attachment, Enums.EXT_framebuffer_object textarget, GLuint texture, GLint level);
            public delegate void FramebufferTexture2DEXT(Enums.EXT_framebuffer_object target, Enums.EXT_framebuffer_object attachment, Enums.EXT_framebuffer_object textarget, GLuint texture, GLint level);
            public delegate void FramebufferTexture3DEXT(Enums.EXT_framebuffer_object target, Enums.EXT_framebuffer_object attachment, Enums.EXT_framebuffer_object textarget, GLuint texture, GLint level, GLint zoffset);
            public delegate void FramebufferRenderbufferEXT(Enums.EXT_framebuffer_object target, Enums.EXT_framebuffer_object attachment, Enums.EXT_framebuffer_object renderbuffertarget, GLuint renderbuffer);
            public delegate void GetFramebufferAttachmentParameterivEXT(Enums.EXT_framebuffer_object target, Enums.EXT_framebuffer_object attachment, Enums.EXT_framebuffer_object pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            public delegate void GenerateMipmapEXT(Enums.EXT_framebuffer_object target);
            public delegate void StringMarkerGREMEDY_(GLsizei len, IntPtr @string);
        }
        #endregion

        #region Imports

        internal class Imports
        {
            [DllImport("opengl32", EntryPoint = "glNewList")]
            public static extern void NewList(GLuint list, Enums.ListMode mode);
            [DllImport("opengl32", EntryPoint = "glEndList")]
            public static extern void EndList();
            [DllImport("opengl32", EntryPoint = "glCallList")]
            public static extern void CallList(GLuint list);
            [DllImport("opengl32", EntryPoint = "glCallLists")]
            public static extern void CallLists_(GLsizei n, Enums.ListNameType type, IntPtr lists);
            [DllImport("opengl32", EntryPoint = "glDeleteLists")]
            public static extern void DeleteLists(GLuint list, GLsizei range);
            [DllImport("opengl32", EntryPoint = "glGenLists")]
            public static extern GLuint GenLists(GLsizei range);
            [DllImport("opengl32", EntryPoint = "glListBase")]
            public static extern void ListBase(GLuint @base);
            [DllImport("opengl32", EntryPoint = "glBegin")]
            public static extern void Begin(Enums.BeginMode mode);
            [DllImport("opengl32", EntryPoint = "glBitmap")]
            public static extern void Bitmap_(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, IntPtr bitmap);
            [DllImport("opengl32", EntryPoint = "glColor3b")]
            public static extern void Color3b(GLbyte red, GLbyte green, GLbyte blue);
            [DllImport("opengl32", EntryPoint = "glColor3bv")]
            public static extern void Color3bv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor3d")]
            public static extern void Color3d(GLdouble red, GLdouble green, GLdouble blue);
            [DllImport("opengl32", EntryPoint = "glColor3dv")]
            public static extern void Color3dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor3f")]
            public static extern void Color3f(GLfloat red, GLfloat green, GLfloat blue);
            [DllImport("opengl32", EntryPoint = "glColor3fv")]
            public static extern void Color3fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor3i")]
            public static extern void Color3i(GLint red, GLint green, GLint blue);
            [DllImport("opengl32", EntryPoint = "glColor3iv")]
            public static extern void Color3iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor3s")]
            public static extern void Color3s(GLshort red, GLshort green, GLshort blue);
            [DllImport("opengl32", EntryPoint = "glColor3sv")]
            public static extern void Color3sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor3ub")]
            public static extern void Color3ub(GLubyte red, GLubyte green, GLubyte blue);
            [DllImport("opengl32", EntryPoint = "glColor3ubv")]
            public static extern void Color3ubv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor3ui")]
            public static extern void Color3ui(GLuint red, GLuint green, GLuint blue);
            [DllImport("opengl32", EntryPoint = "glColor3uiv")]
            public static extern void Color3uiv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor3us")]
            public static extern void Color3us(GLushort red, GLushort green, GLushort blue);
            [DllImport("opengl32", EntryPoint = "glColor3usv")]
            public static extern void Color3usv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4b")]
            public static extern void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
            [DllImport("opengl32", EntryPoint = "glColor4bv")]
            public static extern void Color4bv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4d")]
            public static extern void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
            [DllImport("opengl32", EntryPoint = "glColor4dv")]
            public static extern void Color4dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4f")]
            public static extern void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
            [DllImport("opengl32", EntryPoint = "glColor4fv")]
            public static extern void Color4fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4i")]
            public static extern void Color4i(GLint red, GLint green, GLint blue, GLint alpha);
            [DllImport("opengl32", EntryPoint = "glColor4iv")]
            public static extern void Color4iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4s")]
            public static extern void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha);
            [DllImport("opengl32", EntryPoint = "glColor4sv")]
            public static extern void Color4sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4ub")]
            public static extern void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
            [DllImport("opengl32", EntryPoint = "glColor4ubv")]
            public static extern void Color4ubv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4ui")]
            public static extern void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha);
            [DllImport("opengl32", EntryPoint = "glColor4uiv")]
            public static extern void Color4uiv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glColor4us")]
            public static extern void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha);
            [DllImport("opengl32", EntryPoint = "glColor4usv")]
            public static extern void Color4usv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glEdgeFlag")]
            public static extern void EdgeFlag(Enums.Boolean flag);
            [DllImport("opengl32", EntryPoint = "glEdgeFlagv")]
            public static extern void EdgeFlagv(Enums.Boolean[] flag);
            [DllImport("opengl32", EntryPoint = "glEnd")]
            public static extern void End();
            [DllImport("opengl32", EntryPoint = "glIndexd")]
            public static extern void Indexd(GLdouble c);
            [DllImport("opengl32", EntryPoint = "glIndexdv")]
            public static extern void Indexdv_(IntPtr c);
            [DllImport("opengl32", EntryPoint = "glIndexf")]
            public static extern void Indexf(GLfloat c);
            [DllImport("opengl32", EntryPoint = "glIndexfv")]
            public static extern void Indexfv_(IntPtr c);
            [DllImport("opengl32", EntryPoint = "glIndexi")]
            public static extern void Indexi(GLint c);
            [DllImport("opengl32", EntryPoint = "glIndexiv")]
            public static extern void Indexiv_(IntPtr c);
            [DllImport("opengl32", EntryPoint = "glIndexs")]
            public static extern void Indexs(GLshort c);
            [DllImport("opengl32", EntryPoint = "glIndexsv")]
            public static extern void Indexsv_(IntPtr c);
            [DllImport("opengl32", EntryPoint = "glNormal3b")]
            public static extern void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz);
            [DllImport("opengl32", EntryPoint = "glNormal3bv")]
            public static extern void Normal3bv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glNormal3d")]
            public static extern void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz);
            [DllImport("opengl32", EntryPoint = "glNormal3dv")]
            public static extern void Normal3dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glNormal3f")]
            public static extern void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz);
            [DllImport("opengl32", EntryPoint = "glNormal3fv")]
            public static extern void Normal3fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glNormal3i")]
            public static extern void Normal3i(GLint nx, GLint ny, GLint nz);
            [DllImport("opengl32", EntryPoint = "glNormal3iv")]
            public static extern void Normal3iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glNormal3s")]
            public static extern void Normal3s(GLshort nx, GLshort ny, GLshort nz);
            [DllImport("opengl32", EntryPoint = "glNormal3sv")]
            public static extern void Normal3sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos2d")]
            public static extern void RasterPos2d(GLdouble x, GLdouble y);
            [DllImport("opengl32", EntryPoint = "glRasterPos2dv")]
            public static extern void RasterPos2dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos2f")]
            public static extern void RasterPos2f(GLfloat x, GLfloat y);
            [DllImport("opengl32", EntryPoint = "glRasterPos2fv")]
            public static extern void RasterPos2fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos2i")]
            public static extern void RasterPos2i(GLint x, GLint y);
            [DllImport("opengl32", EntryPoint = "glRasterPos2iv")]
            public static extern void RasterPos2iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos2s")]
            public static extern void RasterPos2s(GLshort x, GLshort y);
            [DllImport("opengl32", EntryPoint = "glRasterPos2sv")]
            public static extern void RasterPos2sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos3d")]
            public static extern void RasterPos3d(GLdouble x, GLdouble y, GLdouble z);
            [DllImport("opengl32", EntryPoint = "glRasterPos3dv")]
            public static extern void RasterPos3dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos3f")]
            public static extern void RasterPos3f(GLfloat x, GLfloat y, GLfloat z);
            [DllImport("opengl32", EntryPoint = "glRasterPos3fv")]
            public static extern void RasterPos3fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos3i")]
            public static extern void RasterPos3i(GLint x, GLint y, GLint z);
            [DllImport("opengl32", EntryPoint = "glRasterPos3iv")]
            public static extern void RasterPos3iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos3s")]
            public static extern void RasterPos3s(GLshort x, GLshort y, GLshort z);
            [DllImport("opengl32", EntryPoint = "glRasterPos3sv")]
            public static extern void RasterPos3sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos4d")]
            public static extern void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            [DllImport("opengl32", EntryPoint = "glRasterPos4dv")]
            public static extern void RasterPos4dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos4f")]
            public static extern void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            [DllImport("opengl32", EntryPoint = "glRasterPos4fv")]
            public static extern void RasterPos4fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos4i")]
            public static extern void RasterPos4i(GLint x, GLint y, GLint z, GLint w);
            [DllImport("opengl32", EntryPoint = "glRasterPos4iv")]
            public static extern void RasterPos4iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRasterPos4s")]
            public static extern void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w);
            [DllImport("opengl32", EntryPoint = "glRasterPos4sv")]
            public static extern void RasterPos4sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glRectd")]
            public static extern void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);
            [DllImport("opengl32", EntryPoint = "glRectdv")]
            public static extern void Rectdv_(IntPtr v1, IntPtr v2);
            [DllImport("opengl32", EntryPoint = "glRectf")]
            public static extern void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);
            [DllImport("opengl32", EntryPoint = "glRectfv")]
            public static extern void Rectfv_(IntPtr v1, IntPtr v2);
            [DllImport("opengl32", EntryPoint = "glRecti")]
            public static extern void Recti(GLint x1, GLint y1, GLint x2, GLint y2);
            [DllImport("opengl32", EntryPoint = "glRectiv")]
            public static extern void Rectiv_(IntPtr v1, IntPtr v2);
            [DllImport("opengl32", EntryPoint = "glRects")]
            public static extern void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2);
            [DllImport("opengl32", EntryPoint = "glRectsv")]
            public static extern void Rectsv_(IntPtr v1, IntPtr v2);
            [DllImport("opengl32", EntryPoint = "glTexCoord1d")]
            public static extern void TexCoord1d(GLdouble s);
            [DllImport("opengl32", EntryPoint = "glTexCoord1dv")]
            public static extern void TexCoord1dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord1f")]
            public static extern void TexCoord1f(GLfloat s);
            [DllImport("opengl32", EntryPoint = "glTexCoord1fv")]
            public static extern void TexCoord1fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord1i")]
            public static extern void TexCoord1i(GLint s);
            [DllImport("opengl32", EntryPoint = "glTexCoord1iv")]
            public static extern void TexCoord1iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord1s")]
            public static extern void TexCoord1s(GLshort s);
            [DllImport("opengl32", EntryPoint = "glTexCoord1sv")]
            public static extern void TexCoord1sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord2d")]
            public static extern void TexCoord2d(GLdouble s, GLdouble t);
            [DllImport("opengl32", EntryPoint = "glTexCoord2dv")]
            public static extern void TexCoord2dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord2f")]
            public static extern void TexCoord2f(GLfloat s, GLfloat t);
            [DllImport("opengl32", EntryPoint = "glTexCoord2fv")]
            public static extern void TexCoord2fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord2i")]
            public static extern void TexCoord2i(GLint s, GLint t);
            [DllImport("opengl32", EntryPoint = "glTexCoord2iv")]
            public static extern void TexCoord2iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord2s")]
            public static extern void TexCoord2s(GLshort s, GLshort t);
            [DllImport("opengl32", EntryPoint = "glTexCoord2sv")]
            public static extern void TexCoord2sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord3d")]
            public static extern void TexCoord3d(GLdouble s, GLdouble t, GLdouble r);
            [DllImport("opengl32", EntryPoint = "glTexCoord3dv")]
            public static extern void TexCoord3dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord3f")]
            public static extern void TexCoord3f(GLfloat s, GLfloat t, GLfloat r);
            [DllImport("opengl32", EntryPoint = "glTexCoord3fv")]
            public static extern void TexCoord3fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord3i")]
            public static extern void TexCoord3i(GLint s, GLint t, GLint r);
            [DllImport("opengl32", EntryPoint = "glTexCoord3iv")]
            public static extern void TexCoord3iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord3s")]
            public static extern void TexCoord3s(GLshort s, GLshort t, GLshort r);
            [DllImport("opengl32", EntryPoint = "glTexCoord3sv")]
            public static extern void TexCoord3sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord4d")]
            public static extern void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q);
            [DllImport("opengl32", EntryPoint = "glTexCoord4dv")]
            public static extern void TexCoord4dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord4f")]
            public static extern void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q);
            [DllImport("opengl32", EntryPoint = "glTexCoord4fv")]
            public static extern void TexCoord4fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord4i")]
            public static extern void TexCoord4i(GLint s, GLint t, GLint r, GLint q);
            [DllImport("opengl32", EntryPoint = "glTexCoord4iv")]
            public static extern void TexCoord4iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glTexCoord4s")]
            public static extern void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q);
            [DllImport("opengl32", EntryPoint = "glTexCoord4sv")]
            public static extern void TexCoord4sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex2d")]
            public static extern void Vertex2d(GLdouble x, GLdouble y);
            [DllImport("opengl32", EntryPoint = "glVertex2dv")]
            public static extern void Vertex2dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex2f")]
            public static extern void Vertex2f(GLfloat x, GLfloat y);
            [DllImport("opengl32", EntryPoint = "glVertex2fv")]
            public static extern void Vertex2fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex2i")]
            public static extern void Vertex2i(GLint x, GLint y);
            [DllImport("opengl32", EntryPoint = "glVertex2iv")]
            public static extern void Vertex2iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex2s")]
            public static extern void Vertex2s(GLshort x, GLshort y);
            [DllImport("opengl32", EntryPoint = "glVertex2sv")]
            public static extern void Vertex2sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex3d")]
            public static extern void Vertex3d(GLdouble x, GLdouble y, GLdouble z);
            [DllImport("opengl32", EntryPoint = "glVertex3dv")]
            public static extern void Vertex3dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex3f")]
            public static extern void Vertex3f(GLfloat x, GLfloat y, GLfloat z);
            [DllImport("opengl32", EntryPoint = "glVertex3fv")]
            public static extern void Vertex3fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex3i")]
            public static extern void Vertex3i(GLint x, GLint y, GLint z);
            [DllImport("opengl32", EntryPoint = "glVertex3iv")]
            public static extern void Vertex3iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex3s")]
            public static extern void Vertex3s(GLshort x, GLshort y, GLshort z);
            [DllImport("opengl32", EntryPoint = "glVertex3sv")]
            public static extern void Vertex3sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex4d")]
            public static extern void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            [DllImport("opengl32", EntryPoint = "glVertex4dv")]
            public static extern void Vertex4dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex4f")]
            public static extern void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            [DllImport("opengl32", EntryPoint = "glVertex4fv")]
            public static extern void Vertex4fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex4i")]
            public static extern void Vertex4i(GLint x, GLint y, GLint z, GLint w);
            [DllImport("opengl32", EntryPoint = "glVertex4iv")]
            public static extern void Vertex4iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertex4s")]
            public static extern void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w);
            [DllImport("opengl32", EntryPoint = "glVertex4sv")]
            public static extern void Vertex4sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glClipPlane")]
            public static extern void ClipPlane_(Enums.ClipPlaneName plane, IntPtr equation);
            [DllImport("opengl32", EntryPoint = "glColorMaterial")]
            public static extern void ColorMaterial(Enums.MaterialFace face, Enums.ColorMaterialParameter mode);
            [DllImport("opengl32", EntryPoint = "glCullFace")]
            public static extern void CullFace(Enums.CullFaceMode mode);
            [DllImport("opengl32", EntryPoint = "glFogf")]
            public static extern void Fogf(Enums.FogParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glFogfv")]
            public static extern void Fogfv_(Enums.FogParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glFogi")]
            public static extern void Fogi(Enums.FogParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glFogiv")]
            public static extern void Fogiv_(Enums.FogParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glFrontFace")]
            public static extern void FrontFace(Enums.FrontFaceDirection mode);
            [DllImport("opengl32", EntryPoint = "glHint")]
            public static extern void Hint(Enums.HintTarget target, Enums.HintMode mode);
            [DllImport("opengl32", EntryPoint = "glLightf")]
            public static extern void Lightf(Enums.LightName light, Enums.LightParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glLightfv")]
            public static extern void Lightfv_(Enums.LightName light, Enums.LightParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glLighti")]
            public static extern void Lighti(Enums.LightName light, Enums.LightParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glLightiv")]
            public static extern void Lightiv_(Enums.LightName light, Enums.LightParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glLightModelf")]
            public static extern void LightModelf(Enums.LightModelParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glLightModelfv")]
            public static extern void LightModelfv_(Enums.LightModelParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glLightModeli")]
            public static extern void LightModeli(Enums.LightModelParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glLightModeliv")]
            public static extern void LightModeliv_(Enums.LightModelParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glLineStipple")]
            public static extern void LineStipple(GLint factor, GLushort pattern);
            [DllImport("opengl32", EntryPoint = "glLineWidth")]
            public static extern void LineWidth(GLfloat width);
            [DllImport("opengl32", EntryPoint = "glMaterialf")]
            public static extern void Materialf(Enums.MaterialFace face, Enums.MaterialParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glMaterialfv")]
            public static extern void Materialfv_(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glMateriali")]
            public static extern void Materiali(Enums.MaterialFace face, Enums.MaterialParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glMaterialiv")]
            public static extern void Materialiv_(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glPointSize")]
            public static extern void PointSize(GLfloat size);
            [DllImport("opengl32", EntryPoint = "glPolygonMode")]
            public static extern void PolygonMode(Enums.MaterialFace face, Enums.PolygonMode mode);
            [DllImport("opengl32", EntryPoint = "glPolygonStipple")]
            public static extern void PolygonStipple_(IntPtr mask);
            [DllImport("opengl32", EntryPoint = "glScissor")]
            public static extern void Scissor(GLint x, GLint y, GLsizei width, GLsizei height);
            [DllImport("opengl32", EntryPoint = "glShadeModel")]
            public static extern void ShadeModel(Enums.ShadingModel mode);
            [DllImport("opengl32", EntryPoint = "glTexParameterf")]
            public static extern void TexParameterf(Enums.TextureTarget target, Enums.TextureParameterName pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glTexParameterfv")]
            public static extern void TexParameterfv_(Enums.TextureTarget target, Enums.TextureParameterName pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glTexParameteri")]
            public static extern void TexParameteri(Enums.TextureTarget target, Enums.TextureParameterName pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glTexParameteriv")]
            public static extern void TexParameteriv_(Enums.TextureTarget target, Enums.TextureParameterName pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glTexImage1D")]
            public static extern void TexImage1D(Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glTexImage2D")]
            public static extern void TexImage2D(Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glTexEnvf")]
            public static extern void TexEnvf(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glTexEnvfv")]
            public static extern void TexEnvfv_(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glTexEnvi")]
            public static extern void TexEnvi(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glTexEnviv")]
            public static extern void TexEnviv_(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glTexGend")]
            public static extern void TexGend(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLdouble param);
            [DllImport("opengl32", EntryPoint = "glTexGendv")]
            public static extern void TexGendv_(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glTexGenf")]
            public static extern void TexGenf(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glTexGenfv")]
            public static extern void TexGenfv_(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glTexGeni")]
            public static extern void TexGeni(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glTexGeniv")]
            public static extern void TexGeniv_(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glFeedbackBuffer")]
            public static extern void FeedbackBuffer(GLsizei size, Enums.FeedbackType type, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] buffer);
            [DllImport("opengl32", EntryPoint = "glSelectBuffer")]
            public static extern void SelectBuffer(GLsizei size, [MarshalAs(UnmanagedType.LPArray)] GLuint[] buffer);
            [DllImport("opengl32", EntryPoint = "glRenderMode")]
            public static extern GLint RenderMode(Enums.RenderingMode mode);
            [DllImport("opengl32", EntryPoint = "glInitNames")]
            public static extern void InitNames();
            [DllImport("opengl32", EntryPoint = "glLoadName")]
            public static extern void LoadName(GLuint name);
            [DllImport("opengl32", EntryPoint = "glPassThrough")]
            public static extern void PassThrough(GLfloat token);
            [DllImport("opengl32", EntryPoint = "glPopName")]
            public static extern void PopName();
            [DllImport("opengl32", EntryPoint = "glPushName")]
            public static extern void PushName(GLuint name);
            [DllImport("opengl32", EntryPoint = "glDrawBuffer")]
            public static extern void DrawBuffer(Enums.DrawBufferMode mode);
            [DllImport("opengl32", EntryPoint = "glClear")]
            public static extern void Clear(Enums.ClearBufferMask mask);
            [DllImport("opengl32", EntryPoint = "glClearAccum")]
            public static extern void ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
            [DllImport("opengl32", EntryPoint = "glClearIndex")]
            public static extern void ClearIndex(GLfloat c);
            [DllImport("opengl32", EntryPoint = "glClearColor")]
            public static extern void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
            [DllImport("opengl32", EntryPoint = "glClearStencil")]
            public static extern void ClearStencil(GLint s);
            [DllImport("opengl32", EntryPoint = "glClearDepth")]
            public static extern void ClearDepth(GLclampd depth);
            [DllImport("opengl32", EntryPoint = "glStencilMask")]
            public static extern void StencilMask(GLuint mask);
            [DllImport("opengl32", EntryPoint = "glColorMask")]
            public static extern void ColorMask(Enums.Boolean red, Enums.Boolean green, Enums.Boolean blue, Enums.Boolean alpha);
            [DllImport("opengl32", EntryPoint = "glDepthMask")]
            public static extern void DepthMask(Enums.Boolean flag);
            [DllImport("opengl32", EntryPoint = "glIndexMask")]
            public static extern void IndexMask(GLuint mask);
            [DllImport("opengl32", EntryPoint = "glAccum")]
            public static extern void Accum(Enums.AccumOp op, GLfloat value);
            [DllImport("opengl32", EntryPoint = "glDisable")]
            public static extern void Disable(Enums.EnableCap cap);
            [DllImport("opengl32", EntryPoint = "glEnable")]
            public static extern void Enable(Enums.EnableCap cap);
            [DllImport("opengl32", EntryPoint = "glFinish")]
            public static extern void Finish();
            [DllImport("opengl32", EntryPoint = "glFlush")]
            public static extern void Flush();
            [DllImport("opengl32", EntryPoint = "glPopAttrib")]
            public static extern void PopAttrib();
            [DllImport("opengl32", EntryPoint = "glPushAttrib")]
            public static extern void PushAttrib(Enums.AttribMask mask);
            [DllImport("opengl32", EntryPoint = "glMap1d")]
            public static extern void Map1d_(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, IntPtr points);
            [DllImport("opengl32", EntryPoint = "glMap1f")]
            public static extern void Map1f_(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, IntPtr points);
            [DllImport("opengl32", EntryPoint = "glMap2d")]
            public static extern void Map2d_(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, IntPtr points);
            [DllImport("opengl32", EntryPoint = "glMap2f")]
            public static extern void Map2f_(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, IntPtr points);
            [DllImport("opengl32", EntryPoint = "glMapGrid1d")]
            public static extern void MapGrid1d(GLint un, GLdouble u1, GLdouble u2);
            [DllImport("opengl32", EntryPoint = "glMapGrid1f")]
            public static extern void MapGrid1f(GLint un, GLfloat u1, GLfloat u2);
            [DllImport("opengl32", EntryPoint = "glMapGrid2d")]
            public static extern void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
            [DllImport("opengl32", EntryPoint = "glMapGrid2f")]
            public static extern void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
            [DllImport("opengl32", EntryPoint = "glEvalCoord1d")]
            public static extern void EvalCoord1d(GLdouble u);
            [DllImport("opengl32", EntryPoint = "glEvalCoord1dv")]
            public static extern void EvalCoord1dv_(IntPtr u);
            [DllImport("opengl32", EntryPoint = "glEvalCoord1f")]
            public static extern void EvalCoord1f(GLfloat u);
            [DllImport("opengl32", EntryPoint = "glEvalCoord1fv")]
            public static extern void EvalCoord1fv_(IntPtr u);
            [DllImport("opengl32", EntryPoint = "glEvalCoord2d")]
            public static extern void EvalCoord2d(GLdouble u, GLdouble v);
            [DllImport("opengl32", EntryPoint = "glEvalCoord2dv")]
            public static extern void EvalCoord2dv_(IntPtr u);
            [DllImport("opengl32", EntryPoint = "glEvalCoord2f")]
            public static extern void EvalCoord2f(GLfloat u, GLfloat v);
            [DllImport("opengl32", EntryPoint = "glEvalCoord2fv")]
            public static extern void EvalCoord2fv_(IntPtr u);
            [DllImport("opengl32", EntryPoint = "glEvalMesh1")]
            public static extern void EvalMesh1(Enums.MeshMode1 mode, GLint i1, GLint i2);
            [DllImport("opengl32", EntryPoint = "glEvalPoint1")]
            public static extern void EvalPoint1(GLint i);
            [DllImport("opengl32", EntryPoint = "glEvalMesh2")]
            public static extern void EvalMesh2(Enums.MeshMode2 mode, GLint i1, GLint i2, GLint j1, GLint j2);
            [DllImport("opengl32", EntryPoint = "glEvalPoint2")]
            public static extern void EvalPoint2(GLint i, GLint j);
            [DllImport("opengl32", EntryPoint = "glAlphaFunc")]
            public static extern void AlphaFunc(Enums.AlphaFunction func, GLclampf reference);
            [DllImport("opengl32", EntryPoint = "glBlendFunc")]
            public static extern void BlendFunc(Enums.BlendingFactorSrc sfactor, Enums.BlendingFactorDest dfactor);
            [DllImport("opengl32", EntryPoint = "glLogicOp")]
            public static extern void LogicOp(Enums.LogicOp opcode);
            [DllImport("opengl32", EntryPoint = "glStencilFunc")]
            public static extern void StencilFunc(Enums.StencilFunction func, GLint reference, GLuint mask);
            [DllImport("opengl32", EntryPoint = "glStencilOp")]
            public static extern void StencilOp(Enums.StencilOp fail, Enums.StencilOp zfail, Enums.StencilOp zpass);
            [DllImport("opengl32", EntryPoint = "glDepthFunc")]
            public static extern void DepthFunc(Enums.DepthFunction func);
            [DllImport("opengl32", EntryPoint = "glPixelZoom")]
            public static extern void PixelZoom(GLfloat xfactor, GLfloat yfactor);
            [DllImport("opengl32", EntryPoint = "glPixelTransferf")]
            public static extern void PixelTransferf(Enums.PixelTransferParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glPixelTransferi")]
            public static extern void PixelTransferi(Enums.PixelTransferParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glPixelStoref")]
            public static extern void PixelStoref(Enums.PixelStoreParameter pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glPixelStorei")]
            public static extern void PixelStorei(Enums.PixelStoreParameter pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glPixelMapfv")]
            public static extern void PixelMapfv_(Enums.PixelMap map, GLint mapsize, IntPtr values);
            [DllImport("opengl32", EntryPoint = "glPixelMapuiv")]
            public static extern void PixelMapuiv_(Enums.PixelMap map, GLint mapsize, IntPtr values);
            [DllImport("opengl32", EntryPoint = "glPixelMapusv")]
            public static extern void PixelMapusv_(Enums.PixelMap map, GLint mapsize, IntPtr values);
            [DllImport("opengl32", EntryPoint = "glReadBuffer")]
            public static extern void ReadBuffer(Enums.ReadBufferMode mode);
            [DllImport("opengl32", EntryPoint = "glCopyPixels")]
            public static extern void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, Enums.PixelCopyType type);
            [DllImport("opengl32", EntryPoint = "glReadPixels")]
            public static extern void ReadPixels_(GLint x, GLint y, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glDrawPixels")]
            public static extern void DrawPixels_(GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glGetBooleanv")]
            public static extern void GetBooleanv(Enums.GetPName pname, Enums.Boolean[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetClipPlane")]
            public static extern void GetClipPlane(Enums.ClipPlaneName plane, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] equation);
            [DllImport("opengl32", EntryPoint = "glGetDoublev")]
            public static extern void GetDoublev(Enums.GetPName pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetError")]
            public static extern GLenum GetError();
            [DllImport("opengl32", EntryPoint = "glGetFloatv")]
            public static extern void GetFloatv(Enums.GetPName pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetIntegerv")]
            public static extern void GetIntegerv(Enums.GetPName pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetLightfv")]
            public static extern void GetLightfv(Enums.LightName light, Enums.LightParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetLightiv")]
            public static extern void GetLightiv(Enums.LightName light, Enums.LightParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetMapdv")]
            public static extern void GetMapdv(Enums.MapTarget target, Enums.GetMapQuery query, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] v);
            [DllImport("opengl32", EntryPoint = "glGetMapfv")]
            public static extern void GetMapfv(Enums.MapTarget target, Enums.GetMapQuery query, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] v);
            [DllImport("opengl32", EntryPoint = "glGetMapiv")]
            public static extern void GetMapiv(Enums.MapTarget target, Enums.GetMapQuery query, [MarshalAs(UnmanagedType.LPArray)] GLint[] v);
            [DllImport("opengl32", EntryPoint = "glGetMaterialfv")]
            public static extern void GetMaterialfv(Enums.MaterialFace face, Enums.MaterialParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetMaterialiv")]
            public static extern void GetMaterialiv(Enums.MaterialFace face, Enums.MaterialParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetPixelMapfv")]
            public static extern void GetPixelMapfv(Enums.PixelMap map, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] values);
            [DllImport("opengl32", EntryPoint = "glGetPixelMapuiv")]
            public static extern void GetPixelMapuiv(Enums.PixelMap map, [MarshalAs(UnmanagedType.LPArray)] GLuint[] values);
            [DllImport("opengl32", EntryPoint = "glGetPixelMapusv")]
            public static extern void GetPixelMapusv(Enums.PixelMap map, [MarshalAs(UnmanagedType.LPArray)] GLushort[] values);
            [DllImport("opengl32", EntryPoint = "glGetPolygonStipple")]
            public static extern void GetPolygonStipple([MarshalAs(UnmanagedType.LPArray)] GLubyte[] mask);
            [DllImport("opengl32", EntryPoint = "glGetString")]
            public static extern IntPtr GetString_(Enums.StringName name);
            [DllImport("opengl32", EntryPoint = "glGetTexEnvfv")]
            public static extern void GetTexEnvfv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexEnviv")]
            public static extern void GetTexEnviv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexGendv")]
            public static extern void GetTexGendv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexGenfv")]
            public static extern void GetTexGenfv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexGeniv")]
            public static extern void GetTexGeniv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexImage")]
            public static extern void GetTexImage(Enums.TextureTarget target, GLint level, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glGetTexParameterfv")]
            public static extern void GetTexParameterfv(Enums.TextureTarget target, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexParameteriv")]
            public static extern void GetTexParameteriv(Enums.TextureTarget target, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexLevelParameterfv")]
            public static extern void GetTexLevelParameterfv(Enums.TextureTarget target, GLint level, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetTexLevelParameteriv")]
            public static extern void GetTexLevelParameteriv(Enums.TextureTarget target, GLint level, Enums.GetTextureParameter pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glIsEnabled")]
            public static extern GLboolean IsEnabled(Enums.EnableCap cap);
            [DllImport("opengl32", EntryPoint = "glIsList")]
            public static extern GLboolean IsList(GLuint list);
            [DllImport("opengl32", EntryPoint = "glDepthRange")]
            public static extern void DepthRange(GLclampd near, GLclampd far);
            [DllImport("opengl32", EntryPoint = "glFrustum")]
            public static extern void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
            [DllImport("opengl32", EntryPoint = "glLoadIdentity")]
            public static extern void LoadIdentity();
            [DllImport("opengl32", EntryPoint = "glLoadMatrixf")]
            public static extern void LoadMatrixf_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glLoadMatrixd")]
            public static extern void LoadMatrixd_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glMatrixMode")]
            public static extern void MatrixMode(Enums.MatrixMode mode);
            [DllImport("opengl32", EntryPoint = "glMultMatrixf")]
            public static extern void MultMatrixf_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glMultMatrixd")]
            public static extern void MultMatrixd_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glOrtho")]
            public static extern void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
            [DllImport("opengl32", EntryPoint = "glPopMatrix")]
            public static extern void PopMatrix();
            [DllImport("opengl32", EntryPoint = "glPushMatrix")]
            public static extern void PushMatrix();
            [DllImport("opengl32", EntryPoint = "glRotated")]
            public static extern void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
            [DllImport("opengl32", EntryPoint = "glRotatef")]
            public static extern void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
            [DllImport("opengl32", EntryPoint = "glScaled")]
            public static extern void Scaled(GLdouble x, GLdouble y, GLdouble z);
            [DllImport("opengl32", EntryPoint = "glScalef")]
            public static extern void Scalef(GLfloat x, GLfloat y, GLfloat z);
            [DllImport("opengl32", EntryPoint = "glTranslated")]
            public static extern void Translated(GLdouble x, GLdouble y, GLdouble z);
            [DllImport("opengl32", EntryPoint = "glTranslatef")]
            public static extern void Translatef(GLfloat x, GLfloat y, GLfloat z);
            [DllImport("opengl32", EntryPoint = "glViewport")]
            public static extern void Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
            [DllImport("opengl32", EntryPoint = "glArrayElement")]
            public static extern void ArrayElement(GLint i);
            [DllImport("opengl32", EntryPoint = "glColorPointer")]
            public static extern void ColorPointer_(GLint size, Enums.ColorPointerType type, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glDisableClientState")]
            public static extern void DisableClientState(Enums.EnableCap array);
            [DllImport("opengl32", EntryPoint = "glDrawArrays")]
            public static extern void DrawArrays(Enums.BeginMode mode, GLint first, GLsizei count);
            [DllImport("opengl32", EntryPoint = "glDrawElements")]
            public static extern void DrawElements_(Enums.BeginMode mode, GLsizei count, GLenum type, IntPtr indices);
            [DllImport("opengl32", EntryPoint = "glEdgeFlagPointer")]
            public static extern void EdgeFlagPointer_(GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glEnableClientState")]
            public static extern void EnableClientState(Enums.EnableCap array);
            [DllImport("opengl32", EntryPoint = "glGetPointerv")]
            public static extern void GetPointerv(Enums.GetPointervPName pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] parameters);
            [DllImport("opengl32", EntryPoint = "glIndexPointer")]
            public static extern void IndexPointer_(Enums.IndexPointerType type, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glInterleavedArrays")]
            public static extern void InterleavedArrays_(Enums.InterleavedArrayFormat format, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glNormalPointer")]
            public static extern void NormalPointer_(Enums.NormalPointerType type, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glTexCoordPointer")]
            public static extern void TexCoordPointer_(GLint size, Enums.TexCoordPointerType type, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glVertexPointer")]
            public static extern void VertexPointer_(GLint size, Enums.VertexPointerType type, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glPolygonOffset")]
            public static extern void PolygonOffset(GLfloat factor, GLfloat units);
            [DllImport("opengl32", EntryPoint = "glCopyTexImage1D")]
            public static extern void CopyTexImage1D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border);
            [DllImport("opengl32", EntryPoint = "glCopyTexImage2D")]
            public static extern void CopyTexImage2D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
            [DllImport("opengl32", EntryPoint = "glCopyTexSubImage1D")]
            public static extern void CopyTexSubImage1D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
            [DllImport("opengl32", EntryPoint = "glCopyTexSubImage2D")]
            public static extern void CopyTexSubImage2D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
            [DllImport("opengl32", EntryPoint = "glTexSubImage1D")]
            public static extern void TexSubImage1D(Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glTexSubImage2D")]
            public static extern void TexSubImage2D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glAreTexturesResident")]
            public static extern GLboolean AreTexturesResident_(GLsizei n, IntPtr textures, Enums.Boolean[] residences);
            [DllImport("opengl32", EntryPoint = "glBindTexture")]
            public static extern void BindTexture(Enums.TextureTarget target, GLuint texture);
            [DllImport("opengl32", EntryPoint = "glDeleteTextures")]
            public static extern void DeleteTextures_(GLsizei n, IntPtr textures);
            [DllImport("opengl32", EntryPoint = "glGenTextures")]
            public static extern void GenTextures(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] textures);
            [DllImport("opengl32", EntryPoint = "glIsTexture")]
            public static extern GLboolean IsTexture(GLuint texture);
            [DllImport("opengl32", EntryPoint = "glPrioritizeTextures")]
            public static extern void PrioritizeTextures_(GLsizei n, IntPtr textures, IntPtr priorities);
            [DllImport("opengl32", EntryPoint = "glIndexub")]
            public static extern void Indexub(GLubyte c);
            [DllImport("opengl32", EntryPoint = "glIndexubv")]
            public static extern void Indexubv_(IntPtr c);
            [DllImport("opengl32", EntryPoint = "glPopClientAttrib")]
            public static extern void PopClientAttrib();
            [DllImport("opengl32", EntryPoint = "glPushClientAttrib")]
            public static extern void PushClientAttrib(Enums.ClientAttribMask mask);
            [DllImport("opengl32", EntryPoint = "glBlendColor")]
            public static extern void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
            [DllImport("opengl32", EntryPoint = "glBlendEquation")]
            public static extern void BlendEquation(GLenum mode);
            [DllImport("opengl32", EntryPoint = "glDrawRangeElements")]
            public static extern void DrawRangeElements_(Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GLenum type, IntPtr indices);
            [DllImport("opengl32", EntryPoint = "glColorTable")]
            public static extern void ColorTable_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr table);
            [DllImport("opengl32", EntryPoint = "glColorTableParameterfv")]
            public static extern void ColorTableParameterfv_(GLenum target, GLenum pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glColorTableParameteriv")]
            public static extern void ColorTableParameteriv_(GLenum target, GLenum pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glCopyColorTable")]
            public static extern void CopyColorTable(GLenum target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
            [DllImport("opengl32", EntryPoint = "glGetColorTable")]
            public static extern void GetColorTable_(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr table);
            [DllImport("opengl32", EntryPoint = "glGetColorTableParameterfv")]
            public static extern void GetColorTableParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetColorTableParameteriv")]
            public static extern void GetColorTableParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glColorSubTable")]
            public static extern void ColorSubTable_(GLenum target, GLsizei start, GLsizei count, Enums.PixelFormat format, Enums.PixelType type, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glCopyColorSubTable")]
            public static extern void CopyColorSubTable(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
            [DllImport("opengl32", EntryPoint = "glConvolutionFilter1D")]
            public static extern void ConvolutionFilter1D_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            [DllImport("opengl32", EntryPoint = "glConvolutionFilter2D")]
            public static extern void ConvolutionFilter2D_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            [DllImport("opengl32", EntryPoint = "glConvolutionParameterf")]
            public static extern void ConvolutionParameterf(GLenum target, GLenum pname, GLfloat parameters);
            [DllImport("opengl32", EntryPoint = "glConvolutionParameterfv")]
            public static extern void ConvolutionParameterfv_(GLenum target, GLenum pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glConvolutionParameteri")]
            public static extern void ConvolutionParameteri(GLenum target, GLenum pname, GLint parameters);
            [DllImport("opengl32", EntryPoint = "glConvolutionParameteriv")]
            public static extern void ConvolutionParameteriv_(GLenum target, GLenum pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glCopyConvolutionFilter1D")]
            public static extern void CopyConvolutionFilter1D(GLenum target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
            [DllImport("opengl32", EntryPoint = "glCopyConvolutionFilter2D")]
            public static extern void CopyConvolutionFilter2D(GLenum target, Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
            [DllImport("opengl32", EntryPoint = "glGetConvolutionFilter")]
            public static extern void GetConvolutionFilter_(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr image);
            [DllImport("opengl32", EntryPoint = "glGetConvolutionParameterfv")]
            public static extern void GetConvolutionParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetConvolutionParameteriv")]
            public static extern void GetConvolutionParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetSeparableFilter")]
            public static extern void GetSeparableFilter_(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column, IntPtr span);
            [DllImport("opengl32", EntryPoint = "glSeparableFilter2D")]
            public static extern void SeparableFilter2D_(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column);
            [DllImport("opengl32", EntryPoint = "glGetHistogram")]
            public static extern void GetHistogram_(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values);
            [DllImport("opengl32", EntryPoint = "glGetHistogramParameterfv")]
            public static extern void GetHistogramParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetHistogramParameteriv")]
            public static extern void GetHistogramParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetMinmax")]
            public static extern void GetMinmax_(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values);
            [DllImport("opengl32", EntryPoint = "glGetMinmaxParameterfv")]
            public static extern void GetMinmaxParameterfv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetMinmaxParameteriv")]
            public static extern void GetMinmaxParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glHistogram")]
            public static extern void Histogram(GLenum target, GLsizei width, Enums.PixelInternalFormat internalformat, Enums.Boolean sink);
            [DllImport("opengl32", EntryPoint = "glMinmax")]
            public static extern void Minmax(GLenum target, Enums.PixelInternalFormat internalformat, Enums.Boolean sink);
            [DllImport("opengl32", EntryPoint = "glResetHistogram")]
            public static extern void ResetHistogram(GLenum target);
            [DllImport("opengl32", EntryPoint = "glResetMinmax")]
            public static extern void ResetMinmax(GLenum target);
            [DllImport("opengl32", EntryPoint = "glTexImage3D")]
            public static extern void TexImage3D(Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glTexSubImage3D")]
            public static extern void TexSubImage3D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels);
            [DllImport("opengl32", EntryPoint = "glCopyTexSubImage3D")]
            public static extern void CopyTexSubImage3D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
            [DllImport("opengl32", EntryPoint = "glActiveTexture")]
            public static extern void ActiveTexture(GLenum texture);
            [DllImport("opengl32", EntryPoint = "glClientActiveTexture")]
            public static extern void ClientActiveTexture(GLenum texture);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1d")]
            public static extern void MultiTexCoord1d(GLenum target, GLdouble s);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1dv")]
            public static extern void MultiTexCoord1dv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1f")]
            public static extern void MultiTexCoord1f(GLenum target, GLfloat s);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1fv")]
            public static extern void MultiTexCoord1fv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1i")]
            public static extern void MultiTexCoord1i(GLenum target, GLint s);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1iv")]
            public static extern void MultiTexCoord1iv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1s")]
            public static extern void MultiTexCoord1s(GLenum target, GLshort s);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord1sv")]
            public static extern void MultiTexCoord1sv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2d")]
            public static extern void MultiTexCoord2d(GLenum target, GLdouble s, GLdouble t);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2dv")]
            public static extern void MultiTexCoord2dv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2f")]
            public static extern void MultiTexCoord2f(GLenum target, GLfloat s, GLfloat t);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2fv")]
            public static extern void MultiTexCoord2fv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2i")]
            public static extern void MultiTexCoord2i(GLenum target, GLint s, GLint t);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2iv")]
            public static extern void MultiTexCoord2iv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2s")]
            public static extern void MultiTexCoord2s(GLenum target, GLshort s, GLshort t);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord2sv")]
            public static extern void MultiTexCoord2sv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3d")]
            public static extern void MultiTexCoord3d(GLenum target, GLdouble s, GLdouble t, GLdouble r);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3dv")]
            public static extern void MultiTexCoord3dv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3f")]
            public static extern void MultiTexCoord3f(GLenum target, GLfloat s, GLfloat t, GLfloat r);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3fv")]
            public static extern void MultiTexCoord3fv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3i")]
            public static extern void MultiTexCoord3i(GLenum target, GLint s, GLint t, GLint r);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3iv")]
            public static extern void MultiTexCoord3iv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3s")]
            public static extern void MultiTexCoord3s(GLenum target, GLshort s, GLshort t, GLshort r);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord3sv")]
            public static extern void MultiTexCoord3sv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4d")]
            public static extern void MultiTexCoord4d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4dv")]
            public static extern void MultiTexCoord4dv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4f")]
            public static extern void MultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4fv")]
            public static extern void MultiTexCoord4fv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4i")]
            public static extern void MultiTexCoord4i(GLenum target, GLint s, GLint t, GLint r, GLint q);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4iv")]
            public static extern void MultiTexCoord4iv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4s")]
            public static extern void MultiTexCoord4s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
            [DllImport("opengl32", EntryPoint = "glMultiTexCoord4sv")]
            public static extern void MultiTexCoord4sv_(GLenum target, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glLoadTransposeMatrixf")]
            public static extern void LoadTransposeMatrixf_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glLoadTransposeMatrixd")]
            public static extern void LoadTransposeMatrixd_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glMultTransposeMatrixf")]
            public static extern void MultTransposeMatrixf_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glMultTransposeMatrixd")]
            public static extern void MultTransposeMatrixd_(IntPtr m);
            [DllImport("opengl32", EntryPoint = "glSampleCoverage")]
            public static extern void SampleCoverage(GLclampf value, Enums.Boolean invert);
            [DllImport("opengl32", EntryPoint = "glCompressedTexImage3D")]
            public static extern void CompressedTexImage3D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glCompressedTexImage2D")]
            public static extern void CompressedTexImage2D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glCompressedTexImage1D")]
            public static extern void CompressedTexImage1D(Enums.TextureTarget target, GLint level, Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glCompressedTexSubImage3D")]
            public static extern void CompressedTexSubImage3D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glCompressedTexSubImage2D")]
            public static extern void CompressedTexSubImage2D(Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glCompressedTexSubImage1D")]
            public static extern void CompressedTexSubImage1D(Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, Enums.PixelFormat format, GLsizei imageSize, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glGetCompressedTexImage")]
            public static extern void GetCompressedTexImage(Enums.TextureTarget target, GLint level, IntPtr img);
            [DllImport("opengl32", EntryPoint = "glBlendFuncSeparate")]
            public static extern void BlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
            [DllImport("opengl32", EntryPoint = "glFogCoordf")]
            public static extern void FogCoordf(GLfloat coord);
            [DllImport("opengl32", EntryPoint = "glFogCoordfv")]
            public static extern void FogCoordfv_(IntPtr coord);
            [DllImport("opengl32", EntryPoint = "glFogCoordd")]
            public static extern void FogCoordd(GLdouble coord);
            [DllImport("opengl32", EntryPoint = "glFogCoorddv")]
            public static extern void FogCoorddv_(IntPtr coord);
            [DllImport("opengl32", EntryPoint = "glFogCoordPointer")]
            public static extern void FogCoordPointer_(GLenum type, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glMultiDrawArrays")]
            public static extern void MultiDrawArrays(Enums.BeginMode mode, [MarshalAs(UnmanagedType.LPArray)] GLint[] first, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] count, GLsizei primcount);
            [DllImport("opengl32", EntryPoint = "glMultiDrawElements")]
            public static extern void MultiDrawElements_(Enums.BeginMode mode, IntPtr count, GLenum type, IntPtr indices, GLsizei primcount);
            [DllImport("opengl32", EntryPoint = "glPointParameterf")]
            public static extern void PointParameterf(GLenum pname, GLfloat param);
            [DllImport("opengl32", EntryPoint = "glPointParameterfv")]
            public static extern void PointParameterfv_(GLenum pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glPointParameteri")]
            public static extern void PointParameteri(GLenum pname, GLint param);
            [DllImport("opengl32", EntryPoint = "glPointParameteriv")]
            public static extern void PointParameteriv_(GLenum pname, IntPtr parameters);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3b")]
            public static extern void SecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3bv")]
            public static extern void SecondaryColor3bv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3d")]
            public static extern void SecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3dv")]
            public static extern void SecondaryColor3dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3f")]
            public static extern void SecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3fv")]
            public static extern void SecondaryColor3fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3i")]
            public static extern void SecondaryColor3i(GLint red, GLint green, GLint blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3iv")]
            public static extern void SecondaryColor3iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3s")]
            public static extern void SecondaryColor3s(GLshort red, GLshort green, GLshort blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3sv")]
            public static extern void SecondaryColor3sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3ub")]
            public static extern void SecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3ubv")]
            public static extern void SecondaryColor3ubv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3ui")]
            public static extern void SecondaryColor3ui(GLuint red, GLuint green, GLuint blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3uiv")]
            public static extern void SecondaryColor3uiv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3us")]
            public static extern void SecondaryColor3us(GLushort red, GLushort green, GLushort blue);
            [DllImport("opengl32", EntryPoint = "glSecondaryColor3usv")]
            public static extern void SecondaryColor3usv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glSecondaryColorPointer")]
            public static extern void SecondaryColorPointer_(GLint size, Enums.ColorPointerType type, GLsizei stride, IntPtr pointer);
            [DllImport("opengl32", EntryPoint = "glWindowPos2d")]
            public static extern void WindowPos2d(GLdouble x, GLdouble y);
            [DllImport("opengl32", EntryPoint = "glWindowPos2dv")]
            public static extern void WindowPos2dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glWindowPos2f")]
            public static extern void WindowPos2f(GLfloat x, GLfloat y);
            [DllImport("opengl32", EntryPoint = "glWindowPos2fv")]
            public static extern void WindowPos2fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glWindowPos2i")]
            public static extern void WindowPos2i(GLint x, GLint y);
            [DllImport("opengl32", EntryPoint = "glWindowPos2iv")]
            public static extern void WindowPos2iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glWindowPos2s")]
            public static extern void WindowPos2s(GLshort x, GLshort y);
            [DllImport("opengl32", EntryPoint = "glWindowPos2sv")]
            public static extern void WindowPos2sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glWindowPos3d")]
            public static extern void WindowPos3d(GLdouble x, GLdouble y, GLdouble z);
            [DllImport("opengl32", EntryPoint = "glWindowPos3dv")]
            public static extern void WindowPos3dv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glWindowPos3f")]
            public static extern void WindowPos3f(GLfloat x, GLfloat y, GLfloat z);
            [DllImport("opengl32", EntryPoint = "glWindowPos3fv")]
            public static extern void WindowPos3fv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glWindowPos3i")]
            public static extern void WindowPos3i(GLint x, GLint y, GLint z);
            [DllImport("opengl32", EntryPoint = "glWindowPos3iv")]
            public static extern void WindowPos3iv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glWindowPos3s")]
            public static extern void WindowPos3s(GLshort x, GLshort y, GLshort z);
            [DllImport("opengl32", EntryPoint = "glWindowPos3sv")]
            public static extern void WindowPos3sv_(IntPtr v);
            [DllImport("opengl32", EntryPoint = "glGenQueries")]
            public static extern void GenQueries(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] ids);
            [DllImport("opengl32", EntryPoint = "glDeleteQueries")]
            public static extern void DeleteQueries_(GLsizei n, IntPtr ids);
            [DllImport("opengl32", EntryPoint = "glIsQuery")]
            public static extern GLboolean IsQuery(GLuint id);
            [DllImport("opengl32", EntryPoint = "glBeginQuery")]
            public static extern void BeginQuery(Enums.VERSION_1_5 target, GLuint id);
            [DllImport("opengl32", EntryPoint = "glEndQuery")]
            public static extern void EndQuery(Enums.VERSION_1_5 target);
            [DllImport("opengl32", EntryPoint = "glGetQueryiv")]
            public static extern void GetQueryiv(Enums.VERSION_1_5 target, Enums.VERSION_1_5 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetQueryObjectiv")]
            public static extern void GetQueryObjectiv(GLuint id, Enums.VERSION_1_5 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetQueryObjectuiv")]
            public static extern void GetQueryObjectuiv(GLuint id, Enums.VERSION_1_5 pname, [MarshalAs(UnmanagedType.LPArray)] GLuint[] parameters);
            [DllImport("opengl32", EntryPoint = "glBindBuffer")]
            public static extern void BindBuffer(GLenum target, GLuint buffer);
            [DllImport("opengl32", EntryPoint = "glDeleteBuffers")]
            public static extern void DeleteBuffers_(GLsizei n, IntPtr buffers);
            [DllImport("opengl32", EntryPoint = "glGenBuffers")]
            public static extern void GenBuffers(GLsizei n, [MarshalAs(UnmanagedType.LPArray)] GLuint[] buffers);
            [DllImport("opengl32", EntryPoint = "glIsBuffer")]
            public static extern GLboolean IsBuffer(GLuint buffer);
            [DllImport("opengl32", EntryPoint = "glBufferData")]
            public static extern void BufferData_(GLenum target, GLsizeiptr size, IntPtr data, GLenum usage);
            [DllImport("opengl32", EntryPoint = "glBufferSubData")]
            public static extern void BufferSubData_(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glGetBufferSubData")]
            public static extern void GetBufferSubData_(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data);
            [DllImport("opengl32", EntryPoint = "glMapBuffer")]
            public static extern IntPtr MapBuffer(GLenum target, GLenum access);
            [DllImport("opengl32", EntryPoint = "glUnmapBuffer")]
            public static extern GLboolean UnmapBuffer(GLenum target);
            [DllImport("opengl32", EntryPoint = "glGetBufferParameteriv")]
            public static extern void GetBufferParameteriv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetBufferPointerv")]
            public static extern void GetBufferPointerv(GLenum target, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] parameters);
            [DllImport("opengl32", EntryPoint = "glBlendEquationSeparate")]
            public static extern void BlendEquationSeparate(Enums.BlendEquationModeEXT modeRGB, Enums.BlendEquationModeEXT modeAlpha);
            [DllImport("opengl32", EntryPoint = "glDrawBuffers")]
            public static extern void DrawBuffers_(GLsizei n, IntPtr bufs);
            [DllImport("opengl32", EntryPoint = "glStencilOpSeparate")]
            public static extern void StencilOpSeparate(GLenum face, Enums.StencilOp sfail, Enums.StencilOp dpfail, Enums.StencilOp dppass);
            [DllImport("opengl32", EntryPoint = "glStencilFuncSeparate")]
            public static extern void StencilFuncSeparate(Enums.StencilFunction frontfunc, Enums.StencilFunction backfunc, GLint reference, GLuint mask);
            [DllImport("opengl32", EntryPoint = "glStencilMaskSeparate")]
            public static extern void StencilMaskSeparate(GLenum face, GLuint mask);
            [DllImport("opengl32", EntryPoint = "glAttachShader")]
            public static extern void AttachShader(GLuint program, GLuint shader);
            [DllImport("opengl32", EntryPoint = "glBindAttribLocation")]
            public static extern void BindAttribLocation_(GLuint program, GLuint index, IntPtr name);
            [DllImport("opengl32", EntryPoint = "glCompileShader")]
            public static extern void CompileShader(GLuint shader);
            [DllImport("opengl32", EntryPoint = "glCreateProgram")]
            public static extern GLuint CreateProgram();
            [DllImport("opengl32", EntryPoint = "glCreateShader")]
            public static extern GLuint CreateShader(Enums.VERSION_2_0 type);
            [DllImport("opengl32", EntryPoint = "glDeleteProgram")]
            public static extern void DeleteProgram(GLuint program);
            [DllImport("opengl32", EntryPoint = "glDeleteShader")]
            public static extern void DeleteShader(GLuint shader);
            [DllImport("opengl32", EntryPoint = "glDetachShader")]
            public static extern void DetachShader(GLuint program, GLuint shader);
            [DllImport("opengl32", EntryPoint = "glDisableVertexAttribArray")]
            public static extern void DisableVertexAttribArray(GLuint index);
            [DllImport("opengl32", EntryPoint = "glEnableVertexAttribArray")]
            public static extern void EnableVertexAttribArray(GLuint index);
            [DllImport("opengl32", EntryPoint = "glGetActiveAttrib")]
            public static extern void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLint[] size, [MarshalAs(UnmanagedType.LPArray)] Enums.VERSION_2_0[] type, [MarshalAs(UnmanagedType.LPArray)] GLchar[] name);
            [DllImport("opengl32", EntryPoint = "glGetActiveUniform")]
            public static extern void GetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLint[] size, [MarshalAs(UnmanagedType.LPArray)] Enums.VERSION_2_0[] type, [MarshalAs(UnmanagedType.LPArray)] GLchar[] name);
            [DllImport("opengl32", EntryPoint = "glGetAttachedShaders")]
            public static extern void GetAttachedShaders(GLuint program, GLsizei maxCount, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] count, [MarshalAs(UnmanagedType.LPArray)] GLuint[] obj);
            [DllImport("opengl32", EntryPoint = "glGetAttribLocation")]
            public static extern GLint GetAttribLocation_(GLuint program, IntPtr name);
            [DllImport("opengl32", EntryPoint = "glGetProgramiv")]
            public static extern void GetProgramiv(GLuint program, Enums.VERSION_2_0 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetProgramInfoLog")]
            public static extern void GetProgramInfoLog(GLuint program, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLchar[] infoLog);
            [DllImport("opengl32", EntryPoint = "glGetShaderiv")]
            public static extern void GetShaderiv(GLuint shader, Enums.VERSION_2_0 pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetShaderInfoLog")]
            public static extern void GetShaderInfoLog(GLuint shader, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLchar[] infoLog);
            [DllImport("opengl32", EntryPoint = "glGetShaderSource")]
            public static extern void GetShaderSource(GLuint shader, GLsizei bufSize, [MarshalAs(UnmanagedType.LPArray)] GLsizei[] length, [MarshalAs(UnmanagedType.LPArray)] GLchar[] source);
            [DllImport("opengl32", EntryPoint = "glGetUniformLocation")]
            public static extern GLint GetUniformLocation_(GLuint program, IntPtr name);
            [DllImport("opengl32", EntryPoint = "glGetUniformfv")]
            public static extern void GetUniformfv(GLuint program, GLint location, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetUniformiv")]
            public static extern void GetUniformiv(GLuint program, GLint location, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetVertexAttribdv")]
            public static extern void GetVertexAttribdv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLdouble[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetVertexAttribfv")]
            public static extern void GetVertexAttribfv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLfloat[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetVertexAttribiv")]
            public static extern void GetVertexAttribiv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] GLint[] parameters);
            [DllImport("opengl32", EntryPoint = "glGetVertexAttribPointerv")]
            public static extern void GetVertexAttribPointerv(GLuint index, GLenum pname, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] pointer);
            [DllImport("opengl32", EntryPoint = "glIsProgram")]
            public static extern GLboolean IsProgram(GLuint program);
            [DllImport("opengl32", EntryPoint = "glIsShader")]
            public static extern GLboolean IsShader(GLuint shader);
            [DllImport("opengl32", EntryPoint = "glLinkProgram")]
            public static extern void LinkProgram(GLuint program);
            [DllImport("opengl32", EntryPoint = "glShaderSource")]
            public static extern void ShaderSource_(GLuint shader, GLsizei count, string[] @string, IntPtr length);
            [DllImport("opengl32", EntryPoint = "glUseProgram")]
            public static extern void UseProgram(GLuint program);
            [DllImport("opengl32", EntryPoint = "glUniform1f")]
            public static extern void Uniform1f(GLint location, GLfloat v0);
            [DllImport("opengl32", EntryPoint = "glUniform2f")]
            public static extern void Uniform2f(GLint location, GLfloat v0, GLfloat v1);
            [DllImport("opengl32", EntryPoint = "glUniform3f")]
            public static extern void Uniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
            [DllImport("opengl32", EntryPoint = "glUniform4f")]
            public static extern void Uniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
            [DllImport("opengl32", EntryPoint = "glUniform1i")]
            public static extern void Uniform1i(GLint location, GLint v0);
            [DllImport("opengl32", EntryPoint = "glUniform2i")]
            public static extern void Uniform2i(GLint location, GLint v0, GLint v1);
            [DllImport("opengl32", EntryPoint = "glUniform3i")]
            public static extern void Uniform3i(GLint location, GLint v0, GLint v1, GLint v2);
            [DllImport("opengl32", EntryPoint = "glUniform4i")]
            public static extern void Uniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
            [DllImport("opengl32", EntryPoint = "glUniform1fv")]
            public static extern void Uniform1fv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniform2fv")]
            public static extern void Uniform2fv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniform3fv")]
            public static extern void Uniform3fv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniform4fv")]
            public static extern void Uniform4fv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniform1iv")]
            public static extern void Uniform1iv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniform2iv")]
            public static extern void Uniform2iv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniform3iv")]
            public static extern void Uniform3iv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniform4iv")]
            public static extern void Uniform4iv_(GLint location, GLsizei count, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniformMatrix2fv")]
            public static extern void UniformMatrix2fv_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniformMatrix3fv")]
            public static extern void UniformMatrix3fv_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glUniformMatrix4fv")]
            public static extern void UniformMatrix4fv_(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value);
            [DllImport("opengl32", EntryPoint = "glValidateProgram")]
            public static extern void ValidateProgram(GLuint program);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib1d")]
            public static extern void VertexAttrib1d(GLuint index, GLdouble x);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib1dv")]
            public static extern void VertexAttrib1dv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib1f")]
            public static extern void VertexAttrib1f(GLuint index, GLfloat x);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib1fv")]
            public static extern void VertexAttrib1fv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib1s")]
            public static extern void VertexAttrib1s(GLuint index, GLshort x);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib1sv")]
            public static extern void VertexAttrib1sv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib2d")]
            public static extern void VertexAttrib2d(GLuint index, GLdouble x, GLdouble y);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib2dv")]
            public static extern void VertexAttrib2dv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib2f")]
            public static extern void VertexAttrib2f(GLuint index, GLfloat x, GLfloat y);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib2fv")]
            public static extern void VertexAttrib2fv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib2s")]
            public static extern void VertexAttrib2s(GLuint index, GLshort x, GLshort y);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib2sv")]
            public static extern void VertexAttrib2sv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib3d")]
            public static extern void VertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib3dv")]
            public static extern void VertexAttrib3dv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib3f")]
            public static extern void VertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib3fv")]
            public static extern void VertexAttrib3fv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib3s")]
            public static extern void VertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib3sv")]
            public static extern void VertexAttrib3sv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4Nbv")]
            public static extern void VertexAttrib4Nbv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4Niv")]
            public static extern void VertexAttrib4Niv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4Nsv")]
            public static extern void VertexAttrib4Nsv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4Nub")]
            public static extern void VertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4Nubv")]
            public static extern void VertexAttrib4Nubv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4Nuiv")]
            public static extern void VertexAttrib4Nuiv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4Nusv")]
            public static extern void VertexAttrib4Nusv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4bv")]
            public static extern void VertexAttrib4bv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4d")]
            public static extern void VertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4dv")]
            public static extern void VertexAttrib4dv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4f")]
            public static extern void VertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4fv")]
            public static extern void VertexAttrib4fv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4iv")]
            public static extern void VertexAttrib4iv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4s")]
            public static extern void VertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4sv")]
            public static extern void VertexAttrib4sv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4ubv")]
            public static extern void VertexAttrib4ubv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4uiv")]
            public static extern void VertexAttrib4uiv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttrib4usv")]
            public static extern void VertexAttrib4usv_(GLuint index, IntPtr v);
            [DllImport("opengl32", EntryPoint = "glVertexAttribPointer")]
            public static extern void VertexAttribPointer_(GLuint index, GLint size, GLenum type, Enums.Boolean normalized, GLsizei stride, IntPtr pointer);
        }
        #endregion

        #region Function initialisation

        public static Delegates.NewList NewList;
        public static Delegates.EndList EndList;
        public static Delegates.CallList CallList;
        public static Delegates.CallLists_ CallLists_;
        public static Delegates.DeleteLists DeleteLists;
        public static Delegates.GenLists GenLists;
        public static Delegates.ListBase ListBase;
        public static Delegates.Begin Begin;
        public static Delegates.Bitmap_ Bitmap_;
        public static Delegates.Color3b Color3b;
        public static Delegates.Color3bv_ Color3bv_;
        public static Delegates.Color3d Color3d;
        public static Delegates.Color3dv_ Color3dv_;
        public static Delegates.Color3f Color3f;
        public static Delegates.Color3fv_ Color3fv_;
        public static Delegates.Color3i Color3i;
        public static Delegates.Color3iv_ Color3iv_;
        public static Delegates.Color3s Color3s;
        public static Delegates.Color3sv_ Color3sv_;
        public static Delegates.Color3ub Color3ub;
        public static Delegates.Color3ubv_ Color3ubv_;
        public static Delegates.Color3ui Color3ui;
        public static Delegates.Color3uiv_ Color3uiv_;
        public static Delegates.Color3us Color3us;
        public static Delegates.Color3usv_ Color3usv_;
        public static Delegates.Color4b Color4b;
        public static Delegates.Color4bv_ Color4bv_;
        public static Delegates.Color4d Color4d;
        public static Delegates.Color4dv_ Color4dv_;
        public static Delegates.Color4f Color4f;
        public static Delegates.Color4fv_ Color4fv_;
        public static Delegates.Color4i Color4i;
        public static Delegates.Color4iv_ Color4iv_;
        public static Delegates.Color4s Color4s;
        public static Delegates.Color4sv_ Color4sv_;
        public static Delegates.Color4ub Color4ub;
        public static Delegates.Color4ubv_ Color4ubv_;
        public static Delegates.Color4ui Color4ui;
        public static Delegates.Color4uiv_ Color4uiv_;
        public static Delegates.Color4us Color4us;
        public static Delegates.Color4usv_ Color4usv_;
        public static Delegates.EdgeFlag EdgeFlag;
        public static Delegates.EdgeFlagv EdgeFlagv;
        public static Delegates.End End;
        public static Delegates.Indexd Indexd;
        public static Delegates.Indexdv_ Indexdv_;
        public static Delegates.Indexf Indexf;
        public static Delegates.Indexfv_ Indexfv_;
        public static Delegates.Indexi Indexi;
        public static Delegates.Indexiv_ Indexiv_;
        public static Delegates.Indexs Indexs;
        public static Delegates.Indexsv_ Indexsv_;
        public static Delegates.Normal3b Normal3b;
        public static Delegates.Normal3bv_ Normal3bv_;
        public static Delegates.Normal3d Normal3d;
        public static Delegates.Normal3dv_ Normal3dv_;
        public static Delegates.Normal3f Normal3f;
        public static Delegates.Normal3fv_ Normal3fv_;
        public static Delegates.Normal3i Normal3i;
        public static Delegates.Normal3iv_ Normal3iv_;
        public static Delegates.Normal3s Normal3s;
        public static Delegates.Normal3sv_ Normal3sv_;
        public static Delegates.RasterPos2d RasterPos2d;
        public static Delegates.RasterPos2dv_ RasterPos2dv_;
        public static Delegates.RasterPos2f RasterPos2f;
        public static Delegates.RasterPos2fv_ RasterPos2fv_;
        public static Delegates.RasterPos2i RasterPos2i;
        public static Delegates.RasterPos2iv_ RasterPos2iv_;
        public static Delegates.RasterPos2s RasterPos2s;
        public static Delegates.RasterPos2sv_ RasterPos2sv_;
        public static Delegates.RasterPos3d RasterPos3d;
        public static Delegates.RasterPos3dv_ RasterPos3dv_;
        public static Delegates.RasterPos3f RasterPos3f;
        public static Delegates.RasterPos3fv_ RasterPos3fv_;
        public static Delegates.RasterPos3i RasterPos3i;
        public static Delegates.RasterPos3iv_ RasterPos3iv_;
        public static Delegates.RasterPos3s RasterPos3s;
        public static Delegates.RasterPos3sv_ RasterPos3sv_;
        public static Delegates.RasterPos4d RasterPos4d;
        public static Delegates.RasterPos4dv_ RasterPos4dv_;
        public static Delegates.RasterPos4f RasterPos4f;
        public static Delegates.RasterPos4fv_ RasterPos4fv_;
        public static Delegates.RasterPos4i RasterPos4i;
        public static Delegates.RasterPos4iv_ RasterPos4iv_;
        public static Delegates.RasterPos4s RasterPos4s;
        public static Delegates.RasterPos4sv_ RasterPos4sv_;
        public static Delegates.Rectd Rectd;
        public static Delegates.Rectdv_ Rectdv_;
        public static Delegates.Rectf Rectf;
        public static Delegates.Rectfv_ Rectfv_;
        public static Delegates.Recti Recti;
        public static Delegates.Rectiv_ Rectiv_;
        public static Delegates.Rects Rects;
        public static Delegates.Rectsv_ Rectsv_;
        public static Delegates.TexCoord1d TexCoord1d;
        public static Delegates.TexCoord1dv_ TexCoord1dv_;
        public static Delegates.TexCoord1f TexCoord1f;
        public static Delegates.TexCoord1fv_ TexCoord1fv_;
        public static Delegates.TexCoord1i TexCoord1i;
        public static Delegates.TexCoord1iv_ TexCoord1iv_;
        public static Delegates.TexCoord1s TexCoord1s;
        public static Delegates.TexCoord1sv_ TexCoord1sv_;
        public static Delegates.TexCoord2d TexCoord2d;
        public static Delegates.TexCoord2dv_ TexCoord2dv_;
        public static Delegates.TexCoord2f TexCoord2f;
        public static Delegates.TexCoord2fv_ TexCoord2fv_;
        public static Delegates.TexCoord2i TexCoord2i;
        public static Delegates.TexCoord2iv_ TexCoord2iv_;
        public static Delegates.TexCoord2s TexCoord2s;
        public static Delegates.TexCoord2sv_ TexCoord2sv_;
        public static Delegates.TexCoord3d TexCoord3d;
        public static Delegates.TexCoord3dv_ TexCoord3dv_;
        public static Delegates.TexCoord3f TexCoord3f;
        public static Delegates.TexCoord3fv_ TexCoord3fv_;
        public static Delegates.TexCoord3i TexCoord3i;
        public static Delegates.TexCoord3iv_ TexCoord3iv_;
        public static Delegates.TexCoord3s TexCoord3s;
        public static Delegates.TexCoord3sv_ TexCoord3sv_;
        public static Delegates.TexCoord4d TexCoord4d;
        public static Delegates.TexCoord4dv_ TexCoord4dv_;
        public static Delegates.TexCoord4f TexCoord4f;
        public static Delegates.TexCoord4fv_ TexCoord4fv_;
        public static Delegates.TexCoord4i TexCoord4i;
        public static Delegates.TexCoord4iv_ TexCoord4iv_;
        public static Delegates.TexCoord4s TexCoord4s;
        public static Delegates.TexCoord4sv_ TexCoord4sv_;
        public static Delegates.Vertex2d Vertex2d;
        public static Delegates.Vertex2dv_ Vertex2dv_;
        public static Delegates.Vertex2f Vertex2f;
        public static Delegates.Vertex2fv_ Vertex2fv_;
        public static Delegates.Vertex2i Vertex2i;
        public static Delegates.Vertex2iv_ Vertex2iv_;
        public static Delegates.Vertex2s Vertex2s;
        public static Delegates.Vertex2sv_ Vertex2sv_;
        public static Delegates.Vertex3d Vertex3d;
        public static Delegates.Vertex3dv_ Vertex3dv_;
        public static Delegates.Vertex3f Vertex3f;
        public static Delegates.Vertex3fv_ Vertex3fv_;
        public static Delegates.Vertex3i Vertex3i;
        public static Delegates.Vertex3iv_ Vertex3iv_;
        public static Delegates.Vertex3s Vertex3s;
        public static Delegates.Vertex3sv_ Vertex3sv_;
        public static Delegates.Vertex4d Vertex4d;
        public static Delegates.Vertex4dv_ Vertex4dv_;
        public static Delegates.Vertex4f Vertex4f;
        public static Delegates.Vertex4fv_ Vertex4fv_;
        public static Delegates.Vertex4i Vertex4i;
        public static Delegates.Vertex4iv_ Vertex4iv_;
        public static Delegates.Vertex4s Vertex4s;
        public static Delegates.Vertex4sv_ Vertex4sv_;
        public static Delegates.ClipPlane_ ClipPlane_;
        public static Delegates.ColorMaterial ColorMaterial;
        public static Delegates.CullFace CullFace;
        public static Delegates.Fogf Fogf;
        public static Delegates.Fogfv_ Fogfv_;
        public static Delegates.Fogi Fogi;
        public static Delegates.Fogiv_ Fogiv_;
        public static Delegates.FrontFace FrontFace;
        public static Delegates.Hint Hint;
        public static Delegates.Lightf Lightf;
        public static Delegates.Lightfv_ Lightfv_;
        public static Delegates.Lighti Lighti;
        public static Delegates.Lightiv_ Lightiv_;
        public static Delegates.LightModelf LightModelf;
        public static Delegates.LightModelfv_ LightModelfv_;
        public static Delegates.LightModeli LightModeli;
        public static Delegates.LightModeliv_ LightModeliv_;
        public static Delegates.LineStipple LineStipple;
        public static Delegates.LineWidth LineWidth;
        public static Delegates.Materialf Materialf;
        public static Delegates.Materialfv_ Materialfv_;
        public static Delegates.Materiali Materiali;
        public static Delegates.Materialiv_ Materialiv_;
        public static Delegates.PointSize PointSize;
        public static Delegates.PolygonMode PolygonMode;
        public static Delegates.PolygonStipple_ PolygonStipple_;
        public static Delegates.Scissor Scissor;
        public static Delegates.ShadeModel ShadeModel;
        public static Delegates.TexParameterf TexParameterf;
        public static Delegates.TexParameterfv_ TexParameterfv_;
        public static Delegates.TexParameteri TexParameteri;
        public static Delegates.TexParameteriv_ TexParameteriv_;
        public static Delegates.TexImage1D TexImage1D;
        public static Delegates.TexImage2D TexImage2D;
        public static Delegates.TexEnvf TexEnvf;
        public static Delegates.TexEnvfv_ TexEnvfv_;
        public static Delegates.TexEnvi TexEnvi;
        public static Delegates.TexEnviv_ TexEnviv_;
        public static Delegates.TexGend TexGend;
        public static Delegates.TexGendv_ TexGendv_;
        public static Delegates.TexGenf TexGenf;
        public static Delegates.TexGenfv_ TexGenfv_;
        public static Delegates.TexGeni TexGeni;
        public static Delegates.TexGeniv_ TexGeniv_;
        public static Delegates.FeedbackBuffer FeedbackBuffer;
        public static Delegates.SelectBuffer SelectBuffer;
        public static Delegates.RenderMode RenderMode;
        public static Delegates.InitNames InitNames;
        public static Delegates.LoadName LoadName;
        public static Delegates.PassThrough PassThrough;
        public static Delegates.PopName PopName;
        public static Delegates.PushName PushName;
        public static Delegates.DrawBuffer DrawBuffer;
        public static Delegates.Clear Clear;
        public static Delegates.ClearAccum ClearAccum;
        public static Delegates.ClearIndex ClearIndex;
        public static Delegates.ClearColor ClearColor;
        public static Delegates.ClearStencil ClearStencil;
        public static Delegates.ClearDepth ClearDepth;
        public static Delegates.StencilMask StencilMask;
        public static Delegates.ColorMask ColorMask;
        public static Delegates.DepthMask DepthMask;
        public static Delegates.IndexMask IndexMask;
        public static Delegates.Accum Accum;
        public static Delegates.Disable Disable;
        public static Delegates.Enable Enable;
        public static Delegates.Finish Finish;
        public static Delegates.Flush Flush;
        public static Delegates.PopAttrib PopAttrib;
        public static Delegates.PushAttrib PushAttrib;
        public static Delegates.Map1d_ Map1d_;
        public static Delegates.Map1f_ Map1f_;
        public static Delegates.Map2d_ Map2d_;
        public static Delegates.Map2f_ Map2f_;
        public static Delegates.MapGrid1d MapGrid1d;
        public static Delegates.MapGrid1f MapGrid1f;
        public static Delegates.MapGrid2d MapGrid2d;
        public static Delegates.MapGrid2f MapGrid2f;
        public static Delegates.EvalCoord1d EvalCoord1d;
        public static Delegates.EvalCoord1dv_ EvalCoord1dv_;
        public static Delegates.EvalCoord1f EvalCoord1f;
        public static Delegates.EvalCoord1fv_ EvalCoord1fv_;
        public static Delegates.EvalCoord2d EvalCoord2d;
        public static Delegates.EvalCoord2dv_ EvalCoord2dv_;
        public static Delegates.EvalCoord2f EvalCoord2f;
        public static Delegates.EvalCoord2fv_ EvalCoord2fv_;
        public static Delegates.EvalMesh1 EvalMesh1;
        public static Delegates.EvalPoint1 EvalPoint1;
        public static Delegates.EvalMesh2 EvalMesh2;
        public static Delegates.EvalPoint2 EvalPoint2;
        public static Delegates.AlphaFunc AlphaFunc;
        public static Delegates.BlendFunc BlendFunc;
        public static Delegates.LogicOp LogicOp;
        public static Delegates.StencilFunc StencilFunc;
        public static Delegates.StencilOp StencilOp;
        public static Delegates.DepthFunc DepthFunc;
        public static Delegates.PixelZoom PixelZoom;
        public static Delegates.PixelTransferf PixelTransferf;
        public static Delegates.PixelTransferi PixelTransferi;
        public static Delegates.PixelStoref PixelStoref;
        public static Delegates.PixelStorei PixelStorei;
        public static Delegates.PixelMapfv_ PixelMapfv_;
        public static Delegates.PixelMapuiv_ PixelMapuiv_;
        public static Delegates.PixelMapusv_ PixelMapusv_;
        public static Delegates.ReadBuffer ReadBuffer;
        public static Delegates.CopyPixels CopyPixels;
        public static Delegates.ReadPixels_ ReadPixels_;
        public static Delegates.DrawPixels_ DrawPixels_;
        public static Delegates.GetBooleanv GetBooleanv;
        public static Delegates.GetClipPlane GetClipPlane;
        public static Delegates.GetDoublev GetDoublev;
        public static Delegates.GetError GetError;
        public static Delegates.GetFloatv GetFloatv;
        public static Delegates.GetIntegerv GetIntegerv;
        public static Delegates.GetLightfv GetLightfv;
        public static Delegates.GetLightiv GetLightiv;
        public static Delegates.GetMapdv GetMapdv;
        public static Delegates.GetMapfv GetMapfv;
        public static Delegates.GetMapiv GetMapiv;
        public static Delegates.GetMaterialfv GetMaterialfv;
        public static Delegates.GetMaterialiv GetMaterialiv;
        public static Delegates.GetPixelMapfv GetPixelMapfv;
        public static Delegates.GetPixelMapuiv GetPixelMapuiv;
        public static Delegates.GetPixelMapusv GetPixelMapusv;
        public static Delegates.GetPolygonStipple GetPolygonStipple;
        public static Delegates.GetString_ GetString_;
        public static Delegates.GetTexEnvfv GetTexEnvfv;
        public static Delegates.GetTexEnviv GetTexEnviv;
        public static Delegates.GetTexGendv GetTexGendv;
        public static Delegates.GetTexGenfv GetTexGenfv;
        public static Delegates.GetTexGeniv GetTexGeniv;
        public static Delegates.GetTexImage GetTexImage;
        public static Delegates.GetTexParameterfv GetTexParameterfv;
        public static Delegates.GetTexParameteriv GetTexParameteriv;
        public static Delegates.GetTexLevelParameterfv GetTexLevelParameterfv;
        public static Delegates.GetTexLevelParameteriv GetTexLevelParameteriv;
        public static Delegates.IsEnabled IsEnabled;
        public static Delegates.IsList IsList;
        public static Delegates.DepthRange DepthRange;
        public static Delegates.Frustum Frustum;
        public static Delegates.LoadIdentity LoadIdentity;
        public static Delegates.LoadMatrixf_ LoadMatrixf_;
        public static Delegates.LoadMatrixd_ LoadMatrixd_;
        public static Delegates.MatrixMode MatrixMode;
        public static Delegates.MultMatrixf_ MultMatrixf_;
        public static Delegates.MultMatrixd_ MultMatrixd_;
        public static Delegates.Ortho Ortho;
        public static Delegates.PopMatrix PopMatrix;
        public static Delegates.PushMatrix PushMatrix;
        public static Delegates.Rotated Rotated;
        public static Delegates.Rotatef Rotatef;
        public static Delegates.Scaled Scaled;
        public static Delegates.Scalef Scalef;
        public static Delegates.Translated Translated;
        public static Delegates.Translatef Translatef;
        public static Delegates.Viewport Viewport;
        public static Delegates.ArrayElement ArrayElement;
        public static Delegates.ColorPointer_ ColorPointer_;
        public static Delegates.DisableClientState DisableClientState;
        public static Delegates.DrawArrays DrawArrays;
        public static Delegates.DrawElements_ DrawElements_;
        public static Delegates.EdgeFlagPointer_ EdgeFlagPointer_;
        public static Delegates.EnableClientState EnableClientState;
        public static Delegates.GetPointerv GetPointerv;
        public static Delegates.IndexPointer_ IndexPointer_;
        public static Delegates.InterleavedArrays_ InterleavedArrays_;
        public static Delegates.NormalPointer_ NormalPointer_;
        public static Delegates.TexCoordPointer_ TexCoordPointer_;
        public static Delegates.VertexPointer_ VertexPointer_;
        public static Delegates.PolygonOffset PolygonOffset;
        public static Delegates.CopyTexImage1D CopyTexImage1D;
        public static Delegates.CopyTexImage2D CopyTexImage2D;
        public static Delegates.CopyTexSubImage1D CopyTexSubImage1D;
        public static Delegates.CopyTexSubImage2D CopyTexSubImage2D;
        public static Delegates.TexSubImage1D TexSubImage1D;
        public static Delegates.TexSubImage2D TexSubImage2D;
        public static Delegates.AreTexturesResident_ AreTexturesResident_;
        public static Delegates.BindTexture BindTexture;
        public static Delegates.DeleteTextures_ DeleteTextures_;
        public static Delegates.GenTextures GenTextures;
        public static Delegates.IsTexture IsTexture;
        public static Delegates.PrioritizeTextures_ PrioritizeTextures_;
        public static Delegates.Indexub Indexub;
        public static Delegates.Indexubv_ Indexubv_;
        public static Delegates.PopClientAttrib PopClientAttrib;
        public static Delegates.PushClientAttrib PushClientAttrib;
        public static Delegates.BlendColor BlendColor;
        public static Delegates.BlendEquation BlendEquation;
        public static Delegates.DrawRangeElements_ DrawRangeElements_;
        public static Delegates.ColorTable_ ColorTable_;
        public static Delegates.ColorTableParameterfv_ ColorTableParameterfv_;
        public static Delegates.ColorTableParameteriv_ ColorTableParameteriv_;
        public static Delegates.CopyColorTable CopyColorTable;
        public static Delegates.GetColorTable_ GetColorTable_;
        public static Delegates.GetColorTableParameterfv GetColorTableParameterfv;
        public static Delegates.GetColorTableParameteriv GetColorTableParameteriv;
        public static Delegates.ColorSubTable_ ColorSubTable_;
        public static Delegates.CopyColorSubTable CopyColorSubTable;
        public static Delegates.ConvolutionFilter1D_ ConvolutionFilter1D_;
        public static Delegates.ConvolutionFilter2D_ ConvolutionFilter2D_;
        public static Delegates.ConvolutionParameterf ConvolutionParameterf;
        public static Delegates.ConvolutionParameterfv_ ConvolutionParameterfv_;
        public static Delegates.ConvolutionParameteri ConvolutionParameteri;
        public static Delegates.ConvolutionParameteriv_ ConvolutionParameteriv_;
        public static Delegates.CopyConvolutionFilter1D CopyConvolutionFilter1D;
        public static Delegates.CopyConvolutionFilter2D CopyConvolutionFilter2D;
        public static Delegates.GetConvolutionFilter_ GetConvolutionFilter_;
        public static Delegates.GetConvolutionParameterfv GetConvolutionParameterfv;
        public static Delegates.GetConvolutionParameteriv GetConvolutionParameteriv;
        public static Delegates.GetSeparableFilter_ GetSeparableFilter_;
        public static Delegates.SeparableFilter2D_ SeparableFilter2D_;
        public static Delegates.GetHistogram_ GetHistogram_;
        public static Delegates.GetHistogramParameterfv GetHistogramParameterfv;
        public static Delegates.GetHistogramParameteriv GetHistogramParameteriv;
        public static Delegates.GetMinmax_ GetMinmax_;
        public static Delegates.GetMinmaxParameterfv GetMinmaxParameterfv;
        public static Delegates.GetMinmaxParameteriv GetMinmaxParameteriv;
        public static Delegates.Histogram Histogram;
        public static Delegates.Minmax Minmax;
        public static Delegates.ResetHistogram ResetHistogram;
        public static Delegates.ResetMinmax ResetMinmax;
        public static Delegates.TexImage3D TexImage3D;
        public static Delegates.TexSubImage3D TexSubImage3D;
        public static Delegates.CopyTexSubImage3D CopyTexSubImage3D;
        public static Delegates.ActiveTexture ActiveTexture;
        public static Delegates.ClientActiveTexture ClientActiveTexture;
        public static Delegates.MultiTexCoord1d MultiTexCoord1d;
        public static Delegates.MultiTexCoord1dv_ MultiTexCoord1dv_;
        public static Delegates.MultiTexCoord1f MultiTexCoord1f;
        public static Delegates.MultiTexCoord1fv_ MultiTexCoord1fv_;
        public static Delegates.MultiTexCoord1i MultiTexCoord1i;
        public static Delegates.MultiTexCoord1iv_ MultiTexCoord1iv_;
        public static Delegates.MultiTexCoord1s MultiTexCoord1s;
        public static Delegates.MultiTexCoord1sv_ MultiTexCoord1sv_;
        public static Delegates.MultiTexCoord2d MultiTexCoord2d;
        public static Delegates.MultiTexCoord2dv_ MultiTexCoord2dv_;
        public static Delegates.MultiTexCoord2f MultiTexCoord2f;
        public static Delegates.MultiTexCoord2fv_ MultiTexCoord2fv_;
        public static Delegates.MultiTexCoord2i MultiTexCoord2i;
        public static Delegates.MultiTexCoord2iv_ MultiTexCoord2iv_;
        public static Delegates.MultiTexCoord2s MultiTexCoord2s;
        public static Delegates.MultiTexCoord2sv_ MultiTexCoord2sv_;
        public static Delegates.MultiTexCoord3d MultiTexCoord3d;
        public static Delegates.MultiTexCoord3dv_ MultiTexCoord3dv_;
        public static Delegates.MultiTexCoord3f MultiTexCoord3f;
        public static Delegates.MultiTexCoord3fv_ MultiTexCoord3fv_;
        public static Delegates.MultiTexCoord3i MultiTexCoord3i;
        public static Delegates.MultiTexCoord3iv_ MultiTexCoord3iv_;
        public static Delegates.MultiTexCoord3s MultiTexCoord3s;
        public static Delegates.MultiTexCoord3sv_ MultiTexCoord3sv_;
        public static Delegates.MultiTexCoord4d MultiTexCoord4d;
        public static Delegates.MultiTexCoord4dv_ MultiTexCoord4dv_;
        public static Delegates.MultiTexCoord4f MultiTexCoord4f;
        public static Delegates.MultiTexCoord4fv_ MultiTexCoord4fv_;
        public static Delegates.MultiTexCoord4i MultiTexCoord4i;
        public static Delegates.MultiTexCoord4iv_ MultiTexCoord4iv_;
        public static Delegates.MultiTexCoord4s MultiTexCoord4s;
        public static Delegates.MultiTexCoord4sv_ MultiTexCoord4sv_;
        public static Delegates.LoadTransposeMatrixf_ LoadTransposeMatrixf_;
        public static Delegates.LoadTransposeMatrixd_ LoadTransposeMatrixd_;
        public static Delegates.MultTransposeMatrixf_ MultTransposeMatrixf_;
        public static Delegates.MultTransposeMatrixd_ MultTransposeMatrixd_;
        public static Delegates.SampleCoverage SampleCoverage;
        public static Delegates.CompressedTexImage3D CompressedTexImage3D;
        public static Delegates.CompressedTexImage2D CompressedTexImage2D;
        public static Delegates.CompressedTexImage1D CompressedTexImage1D;
        public static Delegates.CompressedTexSubImage3D CompressedTexSubImage3D;
        public static Delegates.CompressedTexSubImage2D CompressedTexSubImage2D;
        public static Delegates.CompressedTexSubImage1D CompressedTexSubImage1D;
        public static Delegates.GetCompressedTexImage GetCompressedTexImage;
        public static Delegates.BlendFuncSeparate BlendFuncSeparate;
        public static Delegates.FogCoordf FogCoordf;
        public static Delegates.FogCoordfv_ FogCoordfv_;
        public static Delegates.FogCoordd FogCoordd;
        public static Delegates.FogCoorddv_ FogCoorddv_;
        public static Delegates.FogCoordPointer_ FogCoordPointer_;
        public static Delegates.MultiDrawArrays MultiDrawArrays;
        public static Delegates.MultiDrawElements_ MultiDrawElements_;
        public static Delegates.PointParameterf PointParameterf;
        public static Delegates.PointParameterfv_ PointParameterfv_;
        public static Delegates.PointParameteri PointParameteri;
        public static Delegates.PointParameteriv_ PointParameteriv_;
        public static Delegates.SecondaryColor3b SecondaryColor3b;
        public static Delegates.SecondaryColor3bv_ SecondaryColor3bv_;
        public static Delegates.SecondaryColor3d SecondaryColor3d;
        public static Delegates.SecondaryColor3dv_ SecondaryColor3dv_;
        public static Delegates.SecondaryColor3f SecondaryColor3f;
        public static Delegates.SecondaryColor3fv_ SecondaryColor3fv_;
        public static Delegates.SecondaryColor3i SecondaryColor3i;
        public static Delegates.SecondaryColor3iv_ SecondaryColor3iv_;
        public static Delegates.SecondaryColor3s SecondaryColor3s;
        public static Delegates.SecondaryColor3sv_ SecondaryColor3sv_;
        public static Delegates.SecondaryColor3ub SecondaryColor3ub;
        public static Delegates.SecondaryColor3ubv_ SecondaryColor3ubv_;
        public static Delegates.SecondaryColor3ui SecondaryColor3ui;
        public static Delegates.SecondaryColor3uiv_ SecondaryColor3uiv_;
        public static Delegates.SecondaryColor3us SecondaryColor3us;
        public static Delegates.SecondaryColor3usv_ SecondaryColor3usv_;
        public static Delegates.SecondaryColorPointer_ SecondaryColorPointer_;
        public static Delegates.WindowPos2d WindowPos2d;
        public static Delegates.WindowPos2dv_ WindowPos2dv_;
        public static Delegates.WindowPos2f WindowPos2f;
        public static Delegates.WindowPos2fv_ WindowPos2fv_;
        public static Delegates.WindowPos2i WindowPos2i;
        public static Delegates.WindowPos2iv_ WindowPos2iv_;
        public static Delegates.WindowPos2s WindowPos2s;
        public static Delegates.WindowPos2sv_ WindowPos2sv_;
        public static Delegates.WindowPos3d WindowPos3d;
        public static Delegates.WindowPos3dv_ WindowPos3dv_;
        public static Delegates.WindowPos3f WindowPos3f;
        public static Delegates.WindowPos3fv_ WindowPos3fv_;
        public static Delegates.WindowPos3i WindowPos3i;
        public static Delegates.WindowPos3iv_ WindowPos3iv_;
        public static Delegates.WindowPos3s WindowPos3s;
        public static Delegates.WindowPos3sv_ WindowPos3sv_;
        public static Delegates.GenQueries GenQueries;
        public static Delegates.DeleteQueries_ DeleteQueries_;
        public static Delegates.IsQuery IsQuery;
        public static Delegates.BeginQuery BeginQuery;
        public static Delegates.EndQuery EndQuery;
        public static Delegates.GetQueryiv GetQueryiv;
        public static Delegates.GetQueryObjectiv GetQueryObjectiv;
        public static Delegates.GetQueryObjectuiv GetQueryObjectuiv;
        public static Delegates.BindBuffer BindBuffer;
        public static Delegates.DeleteBuffers_ DeleteBuffers_;
        public static Delegates.GenBuffers GenBuffers;
        public static Delegates.IsBuffer IsBuffer;
        public static Delegates.BufferData_ BufferData_;
        public static Delegates.BufferSubData_ BufferSubData_;
        public static Delegates.GetBufferSubData_ GetBufferSubData_;
        public static Delegates.MapBuffer MapBuffer;
        public static Delegates.UnmapBuffer UnmapBuffer;
        public static Delegates.GetBufferParameteriv GetBufferParameteriv;
        public static Delegates.GetBufferPointerv GetBufferPointerv;
        public static Delegates.BlendEquationSeparate BlendEquationSeparate;
        public static Delegates.DrawBuffers_ DrawBuffers_;
        public static Delegates.StencilOpSeparate StencilOpSeparate;
        public static Delegates.StencilFuncSeparate StencilFuncSeparate;
        public static Delegates.StencilMaskSeparate StencilMaskSeparate;
        public static Delegates.AttachShader AttachShader;
        public static Delegates.BindAttribLocation_ BindAttribLocation_;
        public static Delegates.CompileShader CompileShader;
        public static Delegates.CreateProgram CreateProgram;
        public static Delegates.CreateShader CreateShader;
        public static Delegates.DeleteProgram DeleteProgram;
        public static Delegates.DeleteShader DeleteShader;
        public static Delegates.DetachShader DetachShader;
        public static Delegates.DisableVertexAttribArray DisableVertexAttribArray;
        public static Delegates.EnableVertexAttribArray EnableVertexAttribArray;
        public static Delegates.GetActiveAttrib GetActiveAttrib;
        public static Delegates.GetActiveUniform GetActiveUniform;
        public static Delegates.GetAttachedShaders GetAttachedShaders;
        public static Delegates.GetAttribLocation_ GetAttribLocation_;
        public static Delegates.GetProgramiv GetProgramiv;
        public static Delegates.GetProgramInfoLog GetProgramInfoLog;
        public static Delegates.GetShaderiv GetShaderiv;
        public static Delegates.GetShaderInfoLog GetShaderInfoLog;
        public static Delegates.GetShaderSource GetShaderSource;
        public static Delegates.GetUniformLocation_ GetUniformLocation_;
        public static Delegates.GetUniformfv GetUniformfv;
        public static Delegates.GetUniformiv GetUniformiv;
        public static Delegates.GetVertexAttribdv GetVertexAttribdv;
        public static Delegates.GetVertexAttribfv GetVertexAttribfv;
        public static Delegates.GetVertexAttribiv GetVertexAttribiv;
        public static Delegates.GetVertexAttribPointerv GetVertexAttribPointerv;
        public static Delegates.IsProgram IsProgram;
        public static Delegates.IsShader IsShader;
        public static Delegates.LinkProgram LinkProgram;
        public static Delegates.ShaderSource_ ShaderSource_;
        public static Delegates.UseProgram UseProgram;
        public static Delegates.Uniform1f Uniform1f;
        public static Delegates.Uniform2f Uniform2f;
        public static Delegates.Uniform3f Uniform3f;
        public static Delegates.Uniform4f Uniform4f;
        public static Delegates.Uniform1i Uniform1i;
        public static Delegates.Uniform2i Uniform2i;
        public static Delegates.Uniform3i Uniform3i;
        public static Delegates.Uniform4i Uniform4i;
        public static Delegates.Uniform1fv_ Uniform1fv_;
        public static Delegates.Uniform2fv_ Uniform2fv_;
        public static Delegates.Uniform3fv_ Uniform3fv_;
        public static Delegates.Uniform4fv_ Uniform4fv_;
        public static Delegates.Uniform1iv_ Uniform1iv_;
        public static Delegates.Uniform2iv_ Uniform2iv_;
        public static Delegates.Uniform3iv_ Uniform3iv_;
        public static Delegates.Uniform4iv_ Uniform4iv_;
        public static Delegates.UniformMatrix2fv_ UniformMatrix2fv_;
        public static Delegates.UniformMatrix3fv_ UniformMatrix3fv_;
        public static Delegates.UniformMatrix4fv_ UniformMatrix4fv_;
        public static Delegates.ValidateProgram ValidateProgram;
        public static Delegates.VertexAttrib1d VertexAttrib1d;
        public static Delegates.VertexAttrib1dv_ VertexAttrib1dv_;
        public static Delegates.VertexAttrib1f VertexAttrib1f;
        public static Delegates.VertexAttrib1fv_ VertexAttrib1fv_;
        public static Delegates.VertexAttrib1s VertexAttrib1s;
        public static Delegates.VertexAttrib1sv_ VertexAttrib1sv_;
        public static Delegates.VertexAttrib2d VertexAttrib2d;
        public static Delegates.VertexAttrib2dv_ VertexAttrib2dv_;
        public static Delegates.VertexAttrib2f VertexAttrib2f;
        public static Delegates.VertexAttrib2fv_ VertexAttrib2fv_;
        public static Delegates.VertexAttrib2s VertexAttrib2s;
        public static Delegates.VertexAttrib2sv_ VertexAttrib2sv_;
        public static Delegates.VertexAttrib3d VertexAttrib3d;
        public static Delegates.VertexAttrib3dv_ VertexAttrib3dv_;
        public static Delegates.VertexAttrib3f VertexAttrib3f;
        public static Delegates.VertexAttrib3fv_ VertexAttrib3fv_;
        public static Delegates.VertexAttrib3s VertexAttrib3s;
        public static Delegates.VertexAttrib3sv_ VertexAttrib3sv_;
        public static Delegates.VertexAttrib4Nbv_ VertexAttrib4Nbv_;
        public static Delegates.VertexAttrib4Niv_ VertexAttrib4Niv_;
        public static Delegates.VertexAttrib4Nsv_ VertexAttrib4Nsv_;
        public static Delegates.VertexAttrib4Nub VertexAttrib4Nub;
        public static Delegates.VertexAttrib4Nubv_ VertexAttrib4Nubv_;
        public static Delegates.VertexAttrib4Nuiv_ VertexAttrib4Nuiv_;
        public static Delegates.VertexAttrib4Nusv_ VertexAttrib4Nusv_;
        public static Delegates.VertexAttrib4bv_ VertexAttrib4bv_;
        public static Delegates.VertexAttrib4d VertexAttrib4d;
        public static Delegates.VertexAttrib4dv_ VertexAttrib4dv_;
        public static Delegates.VertexAttrib4f VertexAttrib4f;
        public static Delegates.VertexAttrib4fv_ VertexAttrib4fv_;
        public static Delegates.VertexAttrib4iv_ VertexAttrib4iv_;
        public static Delegates.VertexAttrib4s VertexAttrib4s;
        public static Delegates.VertexAttrib4sv_ VertexAttrib4sv_;
        public static Delegates.VertexAttrib4ubv_ VertexAttrib4ubv_;
        public static Delegates.VertexAttrib4uiv_ VertexAttrib4uiv_;
        public static Delegates.VertexAttrib4usv_ VertexAttrib4usv_;
        public static Delegates.VertexAttribPointer_ VertexAttribPointer_;
        public static Delegates.ActiveTextureARB ActiveTextureARB;
        public static Delegates.ClientActiveTextureARB ClientActiveTextureARB;
        public static Delegates.MultiTexCoord1dARB MultiTexCoord1dARB;
        public static Delegates.MultiTexCoord1dvARB_ MultiTexCoord1dvARB_;
        public static Delegates.MultiTexCoord1fARB MultiTexCoord1fARB;
        public static Delegates.MultiTexCoord1fvARB_ MultiTexCoord1fvARB_;
        public static Delegates.MultiTexCoord1iARB MultiTexCoord1iARB;
        public static Delegates.MultiTexCoord1ivARB_ MultiTexCoord1ivARB_;
        public static Delegates.MultiTexCoord1sARB MultiTexCoord1sARB;
        public static Delegates.MultiTexCoord1svARB_ MultiTexCoord1svARB_;
        public static Delegates.MultiTexCoord2dARB MultiTexCoord2dARB;
        public static Delegates.MultiTexCoord2dvARB_ MultiTexCoord2dvARB_;
        public static Delegates.MultiTexCoord2fARB MultiTexCoord2fARB;
        public static Delegates.MultiTexCoord2fvARB_ MultiTexCoord2fvARB_;
        public static Delegates.MultiTexCoord2iARB MultiTexCoord2iARB;
        public static Delegates.MultiTexCoord2ivARB_ MultiTexCoord2ivARB_;
        public static Delegates.MultiTexCoord2sARB MultiTexCoord2sARB;
        public static Delegates.MultiTexCoord2svARB_ MultiTexCoord2svARB_;
        public static Delegates.MultiTexCoord3dARB MultiTexCoord3dARB;
        public static Delegates.MultiTexCoord3dvARB_ MultiTexCoord3dvARB_;
        public static Delegates.MultiTexCoord3fARB MultiTexCoord3fARB;
        public static Delegates.MultiTexCoord3fvARB_ MultiTexCoord3fvARB_;
        public static Delegates.MultiTexCoord3iARB MultiTexCoord3iARB;
        public static Delegates.MultiTexCoord3ivARB_ MultiTexCoord3ivARB_;
        public static Delegates.MultiTexCoord3sARB MultiTexCoord3sARB;
        public static Delegates.MultiTexCoord3svARB_ MultiTexCoord3svARB_;
        public static Delegates.MultiTexCoord4dARB MultiTexCoord4dARB;
        public static Delegates.MultiTexCoord4dvARB_ MultiTexCoord4dvARB_;
        public static Delegates.MultiTexCoord4fARB MultiTexCoord4fARB;
        public static Delegates.MultiTexCoord4fvARB_ MultiTexCoord4fvARB_;
        public static Delegates.MultiTexCoord4iARB MultiTexCoord4iARB;
        public static Delegates.MultiTexCoord4ivARB_ MultiTexCoord4ivARB_;
        public static Delegates.MultiTexCoord4sARB MultiTexCoord4sARB;
        public static Delegates.MultiTexCoord4svARB_ MultiTexCoord4svARB_;
        public static Delegates.LoadTransposeMatrixfARB_ LoadTransposeMatrixfARB_;
        public static Delegates.LoadTransposeMatrixdARB_ LoadTransposeMatrixdARB_;
        public static Delegates.MultTransposeMatrixfARB_ MultTransposeMatrixfARB_;
        public static Delegates.MultTransposeMatrixdARB_ MultTransposeMatrixdARB_;
        public static Delegates.SampleCoverageARB SampleCoverageARB;
        public static Delegates.CompressedTexImage3DARB CompressedTexImage3DARB;
        public static Delegates.CompressedTexImage2DARB CompressedTexImage2DARB;
        public static Delegates.CompressedTexImage1DARB CompressedTexImage1DARB;
        public static Delegates.CompressedTexSubImage3DARB CompressedTexSubImage3DARB;
        public static Delegates.CompressedTexSubImage2DARB CompressedTexSubImage2DARB;
        public static Delegates.CompressedTexSubImage1DARB CompressedTexSubImage1DARB;
        public static Delegates.GetCompressedTexImageARB GetCompressedTexImageARB;
        public static Delegates.PointParameterfARB PointParameterfARB;
        public static Delegates.PointParameterfvARB_ PointParameterfvARB_;
        public static Delegates.WeightbvARB_ WeightbvARB_;
        public static Delegates.WeightsvARB_ WeightsvARB_;
        public static Delegates.WeightivARB_ WeightivARB_;
        public static Delegates.WeightfvARB_ WeightfvARB_;
        public static Delegates.WeightdvARB_ WeightdvARB_;
        public static Delegates.WeightubvARB_ WeightubvARB_;
        public static Delegates.WeightusvARB_ WeightusvARB_;
        public static Delegates.WeightuivARB_ WeightuivARB_;
        public static Delegates.WeightPointerARB_ WeightPointerARB_;
        public static Delegates.VertexBlendARB VertexBlendARB;
        public static Delegates.CurrentPaletteMatrixARB CurrentPaletteMatrixARB;
        public static Delegates.MatrixIndexubvARB_ MatrixIndexubvARB_;
        public static Delegates.MatrixIndexusvARB_ MatrixIndexusvARB_;
        public static Delegates.MatrixIndexuivARB_ MatrixIndexuivARB_;
        public static Delegates.MatrixIndexPointerARB_ MatrixIndexPointerARB_;
        public static Delegates.WindowPos2dARB WindowPos2dARB;
        public static Delegates.WindowPos2dvARB_ WindowPos2dvARB_;
        public static Delegates.WindowPos2fARB WindowPos2fARB;
        public static Delegates.WindowPos2fvARB_ WindowPos2fvARB_;
        public static Delegates.WindowPos2iARB WindowPos2iARB;
        public static Delegates.WindowPos2ivARB_ WindowPos2ivARB_;
        public static Delegates.WindowPos2sARB WindowPos2sARB;
        public static Delegates.WindowPos2svARB_ WindowPos2svARB_;
        public static Delegates.WindowPos3dARB WindowPos3dARB;
        public static Delegates.WindowPos3dvARB_ WindowPos3dvARB_;
        public static Delegates.WindowPos3fARB WindowPos3fARB;
        public static Delegates.WindowPos3fvARB_ WindowPos3fvARB_;
        public static Delegates.WindowPos3iARB WindowPos3iARB;
        public static Delegates.WindowPos3ivARB_ WindowPos3ivARB_;
        public static Delegates.WindowPos3sARB WindowPos3sARB;
        public static Delegates.WindowPos3svARB_ WindowPos3svARB_;
        public static Delegates.VertexAttrib1dARB VertexAttrib1dARB;
        public static Delegates.VertexAttrib1dvARB_ VertexAttrib1dvARB_;
        public static Delegates.VertexAttrib1fARB VertexAttrib1fARB;
        public static Delegates.VertexAttrib1fvARB_ VertexAttrib1fvARB_;
        public static Delegates.VertexAttrib1sARB VertexAttrib1sARB;
        public static Delegates.VertexAttrib1svARB_ VertexAttrib1svARB_;
        public static Delegates.VertexAttrib2dARB VertexAttrib2dARB;
        public static Delegates.VertexAttrib2dvARB_ VertexAttrib2dvARB_;
        public static Delegates.VertexAttrib2fARB VertexAttrib2fARB;
        public static Delegates.VertexAttrib2fvARB_ VertexAttrib2fvARB_;
        public static Delegates.VertexAttrib2sARB VertexAttrib2sARB;
        public static Delegates.VertexAttrib2svARB_ VertexAttrib2svARB_;
        public static Delegates.VertexAttrib3dARB VertexAttrib3dARB;
        public static Delegates.VertexAttrib3dvARB_ VertexAttrib3dvARB_;
        public static Delegates.VertexAttrib3fARB VertexAttrib3fARB;
        public static Delegates.VertexAttrib3fvARB_ VertexAttrib3fvARB_;
        public static Delegates.VertexAttrib3sARB VertexAttrib3sARB;
        public static Delegates.VertexAttrib3svARB_ VertexAttrib3svARB_;
        public static Delegates.VertexAttrib4NbvARB_ VertexAttrib4NbvARB_;
        public static Delegates.VertexAttrib4NivARB_ VertexAttrib4NivARB_;
        public static Delegates.VertexAttrib4NsvARB_ VertexAttrib4NsvARB_;
        public static Delegates.VertexAttrib4NubARB VertexAttrib4NubARB;
        public static Delegates.VertexAttrib4NubvARB_ VertexAttrib4NubvARB_;
        public static Delegates.VertexAttrib4NuivARB_ VertexAttrib4NuivARB_;
        public static Delegates.VertexAttrib4NusvARB_ VertexAttrib4NusvARB_;
        public static Delegates.VertexAttrib4bvARB_ VertexAttrib4bvARB_;
        public static Delegates.VertexAttrib4dARB VertexAttrib4dARB;
        public static Delegates.VertexAttrib4dvARB_ VertexAttrib4dvARB_;
        public static Delegates.VertexAttrib4fARB VertexAttrib4fARB;
        public static Delegates.VertexAttrib4fvARB_ VertexAttrib4fvARB_;
        public static Delegates.VertexAttrib4ivARB_ VertexAttrib4ivARB_;
        public static Delegates.VertexAttrib4sARB VertexAttrib4sARB;
        public static Delegates.VertexAttrib4svARB_ VertexAttrib4svARB_;
        public static Delegates.VertexAttrib4ubvARB_ VertexAttrib4ubvARB_;
        public static Delegates.VertexAttrib4uivARB_ VertexAttrib4uivARB_;
        public static Delegates.VertexAttrib4usvARB_ VertexAttrib4usvARB_;
        public static Delegates.VertexAttribPointerARB_ VertexAttribPointerARB_;
        public static Delegates.EnableVertexAttribArrayARB EnableVertexAttribArrayARB;
        public static Delegates.DisableVertexAttribArrayARB DisableVertexAttribArrayARB;
        public static Delegates.ProgramStringARB_ ProgramStringARB_;
        public static Delegates.BindProgramARB BindProgramARB;
        public static Delegates.DeleteProgramsARB_ DeleteProgramsARB_;
        public static Delegates.GenProgramsARB GenProgramsARB;
        public static Delegates.ProgramEnvParameter4dARB ProgramEnvParameter4dARB;
        public static Delegates.ProgramEnvParameter4dvARB_ ProgramEnvParameter4dvARB_;
        public static Delegates.ProgramEnvParameter4fARB ProgramEnvParameter4fARB;
        public static Delegates.ProgramEnvParameter4fvARB_ ProgramEnvParameter4fvARB_;
        public static Delegates.ProgramLocalParameter4dARB ProgramLocalParameter4dARB;
        public static Delegates.ProgramLocalParameter4dvARB_ ProgramLocalParameter4dvARB_;
        public static Delegates.ProgramLocalParameter4fARB ProgramLocalParameter4fARB;
        public static Delegates.ProgramLocalParameter4fvARB_ ProgramLocalParameter4fvARB_;
        public static Delegates.GetProgramEnvParameterdvARB GetProgramEnvParameterdvARB;
        public static Delegates.GetProgramEnvParameterfvARB GetProgramEnvParameterfvARB;
        public static Delegates.GetProgramLocalParameterdvARB GetProgramLocalParameterdvARB;
        public static Delegates.GetProgramLocalParameterfvARB GetProgramLocalParameterfvARB;
        public static Delegates.GetProgramivARB GetProgramivARB;
        public static Delegates.GetProgramStringARB_ GetProgramStringARB_;
        public static Delegates.GetVertexAttribdvARB GetVertexAttribdvARB;
        public static Delegates.GetVertexAttribfvARB GetVertexAttribfvARB;
        public static Delegates.GetVertexAttribivARB GetVertexAttribivARB;
        public static Delegates.GetVertexAttribPointervARB GetVertexAttribPointervARB;
        public static Delegates.IsProgramARB IsProgramARB;
        public static Delegates.BindBufferARB BindBufferARB;
        public static Delegates.DeleteBuffersARB_ DeleteBuffersARB_;
        public static Delegates.GenBuffersARB GenBuffersARB;
        public static Delegates.IsBufferARB IsBufferARB;
        public static Delegates.BufferDataARB_ BufferDataARB_;
        public static Delegates.BufferSubDataARB_ BufferSubDataARB_;
        public static Delegates.GetBufferSubDataARB_ GetBufferSubDataARB_;
        public static Delegates.MapBufferARB MapBufferARB;
        public static Delegates.UnmapBufferARB UnmapBufferARB;
        public static Delegates.GetBufferParameterivARB GetBufferParameterivARB;
        public static Delegates.GetBufferPointervARB GetBufferPointervARB;
        public static Delegates.GenQueriesARB GenQueriesARB;
        public static Delegates.DeleteQueriesARB_ DeleteQueriesARB_;
        public static Delegates.IsQueryARB IsQueryARB;
        public static Delegates.BeginQueryARB BeginQueryARB;
        public static Delegates.EndQueryARB EndQueryARB;
        public static Delegates.GetQueryivARB GetQueryivARB;
        public static Delegates.GetQueryObjectivARB GetQueryObjectivARB;
        public static Delegates.GetQueryObjectuivARB GetQueryObjectuivARB;
        public static Delegates.DeleteObjectARB DeleteObjectARB;
        public static Delegates.GetHandleARB GetHandleARB;
        public static Delegates.DetachObjectARB DetachObjectARB;
        public static Delegates.CreateShaderObjectARB CreateShaderObjectARB;
        public static Delegates.ShaderSourceARB_ ShaderSourceARB_;
        public static Delegates.CompileShaderARB CompileShaderARB;
        public static Delegates.CreateProgramObjectARB CreateProgramObjectARB;
        public static Delegates.AttachObjectARB AttachObjectARB;
        public static Delegates.LinkProgramARB LinkProgramARB;
        public static Delegates.UseProgramObjectARB UseProgramObjectARB;
        public static Delegates.ValidateProgramARB ValidateProgramARB;
        public static Delegates.Uniform1fARB Uniform1fARB;
        public static Delegates.Uniform2fARB Uniform2fARB;
        public static Delegates.Uniform3fARB Uniform3fARB;
        public static Delegates.Uniform4fARB Uniform4fARB;
        public static Delegates.Uniform1iARB Uniform1iARB;
        public static Delegates.Uniform2iARB Uniform2iARB;
        public static Delegates.Uniform3iARB Uniform3iARB;
        public static Delegates.Uniform4iARB Uniform4iARB;
        public static Delegates.Uniform1fvARB_ Uniform1fvARB_;
        public static Delegates.Uniform2fvARB_ Uniform2fvARB_;
        public static Delegates.Uniform3fvARB_ Uniform3fvARB_;
        public static Delegates.Uniform4fvARB_ Uniform4fvARB_;
        public static Delegates.Uniform1ivARB_ Uniform1ivARB_;
        public static Delegates.Uniform2ivARB_ Uniform2ivARB_;
        public static Delegates.Uniform3ivARB_ Uniform3ivARB_;
        public static Delegates.Uniform4ivARB_ Uniform4ivARB_;
        public static Delegates.UniformMatrix2fvARB_ UniformMatrix2fvARB_;
        public static Delegates.UniformMatrix3fvARB_ UniformMatrix3fvARB_;
        public static Delegates.UniformMatrix4fvARB_ UniformMatrix4fvARB_;
        public static Delegates.GetObjectParameterfvARB GetObjectParameterfvARB;
        public static Delegates.GetObjectParameterivARB GetObjectParameterivARB;
        public static Delegates.GetInfoLogARB GetInfoLogARB;
        public static Delegates.GetAttachedObjectsARB GetAttachedObjectsARB;
        public static Delegates.GetUniformLocationARB_ GetUniformLocationARB_;
        public static Delegates.GetActiveUniformARB GetActiveUniformARB;
        public static Delegates.GetUniformfvARB GetUniformfvARB;
        public static Delegates.GetUniformivARB GetUniformivARB;
        public static Delegates.GetShaderSourceARB GetShaderSourceARB;
        public static Delegates.BindAttribLocationARB_ BindAttribLocationARB_;
        public static Delegates.GetActiveAttribARB GetActiveAttribARB;
        public static Delegates.GetAttribLocationARB_ GetAttribLocationARB_;
        public static Delegates.DrawBuffersARB_ DrawBuffersARB_;
        public static Delegates.ClampColorARB ClampColorARB;
        public static Delegates.BlendColorEXT BlendColorEXT;
        public static Delegates.PolygonOffsetEXT PolygonOffsetEXT;
        public static Delegates.TexImage3DEXT TexImage3DEXT;
        public static Delegates.TexSubImage3DEXT TexSubImage3DEXT;
        public static Delegates.GetTexFilterFuncSGIS GetTexFilterFuncSGIS;
        public static Delegates.TexFilterFuncSGIS_ TexFilterFuncSGIS_;
        public static Delegates.TexSubImage1DEXT TexSubImage1DEXT;
        public static Delegates.TexSubImage2DEXT TexSubImage2DEXT;
        public static Delegates.CopyTexImage1DEXT CopyTexImage1DEXT;
        public static Delegates.CopyTexImage2DEXT CopyTexImage2DEXT;
        public static Delegates.CopyTexSubImage1DEXT CopyTexSubImage1DEXT;
        public static Delegates.CopyTexSubImage2DEXT CopyTexSubImage2DEXT;
        public static Delegates.CopyTexSubImage3DEXT CopyTexSubImage3DEXT;
        public static Delegates.GetHistogramEXT_ GetHistogramEXT_;
        public static Delegates.GetHistogramParameterfvEXT GetHistogramParameterfvEXT;
        public static Delegates.GetHistogramParameterivEXT GetHistogramParameterivEXT;
        public static Delegates.GetMinmaxEXT_ GetMinmaxEXT_;
        public static Delegates.GetMinmaxParameterfvEXT GetMinmaxParameterfvEXT;
        public static Delegates.GetMinmaxParameterivEXT GetMinmaxParameterivEXT;
        public static Delegates.HistogramEXT HistogramEXT;
        public static Delegates.MinmaxEXT MinmaxEXT;
        public static Delegates.ResetHistogramEXT ResetHistogramEXT;
        public static Delegates.ResetMinmaxEXT ResetMinmaxEXT;
        public static Delegates.ConvolutionFilter1DEXT_ ConvolutionFilter1DEXT_;
        public static Delegates.ConvolutionFilter2DEXT_ ConvolutionFilter2DEXT_;
        public static Delegates.ConvolutionParameterfEXT ConvolutionParameterfEXT;
        public static Delegates.ConvolutionParameterfvEXT_ ConvolutionParameterfvEXT_;
        public static Delegates.ConvolutionParameteriEXT ConvolutionParameteriEXT;
        public static Delegates.ConvolutionParameterivEXT_ ConvolutionParameterivEXT_;
        public static Delegates.CopyConvolutionFilter1DEXT CopyConvolutionFilter1DEXT;
        public static Delegates.CopyConvolutionFilter2DEXT CopyConvolutionFilter2DEXT;
        public static Delegates.GetConvolutionFilterEXT_ GetConvolutionFilterEXT_;
        public static Delegates.GetConvolutionParameterfvEXT GetConvolutionParameterfvEXT;
        public static Delegates.GetConvolutionParameterivEXT GetConvolutionParameterivEXT;
        public static Delegates.GetSeparableFilterEXT_ GetSeparableFilterEXT_;
        public static Delegates.SeparableFilter2DEXT_ SeparableFilter2DEXT_;
        public static Delegates.ColorTableSGI_ ColorTableSGI_;
        public static Delegates.ColorTableParameterfvSGI_ ColorTableParameterfvSGI_;
        public static Delegates.ColorTableParameterivSGI_ ColorTableParameterivSGI_;
        public static Delegates.CopyColorTableSGI CopyColorTableSGI;
        public static Delegates.GetColorTableSGI_ GetColorTableSGI_;
        public static Delegates.GetColorTableParameterfvSGI GetColorTableParameterfvSGI;
        public static Delegates.GetColorTableParameterivSGI GetColorTableParameterivSGI;
        public static Delegates.PixelTexGenSGIX PixelTexGenSGIX;
        public static Delegates.PixelTexGenParameteriSGIS PixelTexGenParameteriSGIS;
        public static Delegates.PixelTexGenParameterivSGIS_ PixelTexGenParameterivSGIS_;
        public static Delegates.PixelTexGenParameterfSGIS PixelTexGenParameterfSGIS;
        public static Delegates.PixelTexGenParameterfvSGIS_ PixelTexGenParameterfvSGIS_;
        public static Delegates.GetPixelTexGenParameterivSGIS GetPixelTexGenParameterivSGIS;
        public static Delegates.GetPixelTexGenParameterfvSGIS GetPixelTexGenParameterfvSGIS;
        public static Delegates.TexImage4DSGIS TexImage4DSGIS;
        public static Delegates.TexSubImage4DSGIS TexSubImage4DSGIS;
        public static Delegates.AreTexturesResidentEXT_ AreTexturesResidentEXT_;
        public static Delegates.BindTextureEXT BindTextureEXT;
        public static Delegates.DeleteTexturesEXT_ DeleteTexturesEXT_;
        public static Delegates.GenTexturesEXT GenTexturesEXT;
        public static Delegates.IsTextureEXT IsTextureEXT;
        public static Delegates.PrioritizeTexturesEXT_ PrioritizeTexturesEXT_;
        public static Delegates.DetailTexFuncSGIS_ DetailTexFuncSGIS_;
        public static Delegates.GetDetailTexFuncSGIS GetDetailTexFuncSGIS;
        public static Delegates.SharpenTexFuncSGIS_ SharpenTexFuncSGIS_;
        public static Delegates.GetSharpenTexFuncSGIS GetSharpenTexFuncSGIS;
        public static Delegates.SampleMaskSGIS SampleMaskSGIS;
        public static Delegates.SamplePatternSGIS SamplePatternSGIS;
        public static Delegates.ArrayElementEXT ArrayElementEXT;
        public static Delegates.ColorPointerEXT_ ColorPointerEXT_;
        public static Delegates.DrawArraysEXT DrawArraysEXT;
        public static Delegates.EdgeFlagPointerEXT EdgeFlagPointerEXT;
        public static Delegates.GetPointervEXT GetPointervEXT;
        public static Delegates.IndexPointerEXT_ IndexPointerEXT_;
        public static Delegates.NormalPointerEXT_ NormalPointerEXT_;
        public static Delegates.TexCoordPointerEXT_ TexCoordPointerEXT_;
        public static Delegates.VertexPointerEXT_ VertexPointerEXT_;
        public static Delegates.BlendEquationEXT BlendEquationEXT;
        public static Delegates.SpriteParameterfSGIX SpriteParameterfSGIX;
        public static Delegates.SpriteParameterfvSGIX_ SpriteParameterfvSGIX_;
        public static Delegates.SpriteParameteriSGIX SpriteParameteriSGIX;
        public static Delegates.SpriteParameterivSGIX_ SpriteParameterivSGIX_;
        public static Delegates.PointParameterfEXT PointParameterfEXT;
        public static Delegates.PointParameterfvEXT_ PointParameterfvEXT_;
        public static Delegates.PointParameterfSGIS PointParameterfSGIS;
        public static Delegates.PointParameterfvSGIS_ PointParameterfvSGIS_;
        public static Delegates.GetInstrumentsSGIX GetInstrumentsSGIX;
        public static Delegates.InstrumentsBufferSGIX InstrumentsBufferSGIX;
        public static Delegates.PollInstrumentsSGIX PollInstrumentsSGIX;
        public static Delegates.ReadInstrumentsSGIX ReadInstrumentsSGIX;
        public static Delegates.StartInstrumentsSGIX StartInstrumentsSGIX;
        public static Delegates.StopInstrumentsSGIX StopInstrumentsSGIX;
        public static Delegates.FrameZoomSGIX FrameZoomSGIX;
        public static Delegates.TagSampleBufferSGIX TagSampleBufferSGIX;
        public static Delegates.DeformationMap3dSGIX_ DeformationMap3dSGIX_;
        public static Delegates.DeformationMap3fSGIX_ DeformationMap3fSGIX_;
        public static Delegates.DeformSGIX DeformSGIX;
        public static Delegates.LoadIdentityDeformationMapSGIX LoadIdentityDeformationMapSGIX;
        public static Delegates.ReferencePlaneSGIX_ ReferencePlaneSGIX_;
        public static Delegates.FlushRasterSGIX FlushRasterSGIX;
        public static Delegates.FogFuncSGIS_ FogFuncSGIS_;
        public static Delegates.GetFogFuncSGIS GetFogFuncSGIS;
        public static Delegates.ImageTransformParameteriHP ImageTransformParameteriHP;
        public static Delegates.ImageTransformParameterfHP ImageTransformParameterfHP;
        public static Delegates.ImageTransformParameterivHP_ ImageTransformParameterivHP_;
        public static Delegates.ImageTransformParameterfvHP_ ImageTransformParameterfvHP_;
        public static Delegates.GetImageTransformParameterivHP GetImageTransformParameterivHP;
        public static Delegates.GetImageTransformParameterfvHP GetImageTransformParameterfvHP;
        public static Delegates.ColorSubTableEXT_ ColorSubTableEXT_;
        public static Delegates.CopyColorSubTableEXT CopyColorSubTableEXT;
        public static Delegates.HintPGI HintPGI;
        public static Delegates.ColorTableEXT_ ColorTableEXT_;
        public static Delegates.GetColorTableEXT_ GetColorTableEXT_;
        public static Delegates.GetColorTableParameterivEXT GetColorTableParameterivEXT;
        public static Delegates.GetColorTableParameterfvEXT GetColorTableParameterfvEXT;
        public static Delegates.GetListParameterfvSGIX GetListParameterfvSGIX;
        public static Delegates.GetListParameterivSGIX GetListParameterivSGIX;
        public static Delegates.ListParameterfSGIX ListParameterfSGIX;
        public static Delegates.ListParameterfvSGIX_ ListParameterfvSGIX_;
        public static Delegates.ListParameteriSGIX ListParameteriSGIX;
        public static Delegates.ListParameterivSGIX_ ListParameterivSGIX_;
        public static Delegates.IndexMaterialEXT IndexMaterialEXT;
        public static Delegates.IndexFuncEXT IndexFuncEXT;
        public static Delegates.LockArraysEXT LockArraysEXT;
        public static Delegates.UnlockArraysEXT UnlockArraysEXT;
        public static Delegates.CullParameterdvEXT CullParameterdvEXT;
        public static Delegates.CullParameterfvEXT CullParameterfvEXT;
        public static Delegates.FragmentColorMaterialSGIX FragmentColorMaterialSGIX;
        public static Delegates.FragmentLightfSGIX FragmentLightfSGIX;
        public static Delegates.FragmentLightfvSGIX_ FragmentLightfvSGIX_;
        public static Delegates.FragmentLightiSGIX FragmentLightiSGIX;
        public static Delegates.FragmentLightivSGIX_ FragmentLightivSGIX_;
        public static Delegates.FragmentLightModelfSGIX FragmentLightModelfSGIX;
        public static Delegates.FragmentLightModelfvSGIX_ FragmentLightModelfvSGIX_;
        public static Delegates.FragmentLightModeliSGIX FragmentLightModeliSGIX;
        public static Delegates.FragmentLightModelivSGIX_ FragmentLightModelivSGIX_;
        public static Delegates.FragmentMaterialfSGIX FragmentMaterialfSGIX;
        public static Delegates.FragmentMaterialfvSGIX_ FragmentMaterialfvSGIX_;
        public static Delegates.FragmentMaterialiSGIX FragmentMaterialiSGIX;
        public static Delegates.FragmentMaterialivSGIX_ FragmentMaterialivSGIX_;
        public static Delegates.GetFragmentLightfvSGIX GetFragmentLightfvSGIX;
        public static Delegates.GetFragmentLightivSGIX GetFragmentLightivSGIX;
        public static Delegates.GetFragmentMaterialfvSGIX GetFragmentMaterialfvSGIX;
        public static Delegates.GetFragmentMaterialivSGIX GetFragmentMaterialivSGIX;
        public static Delegates.LightEnviSGIX LightEnviSGIX;
        public static Delegates.DrawRangeElementsEXT_ DrawRangeElementsEXT_;
        public static Delegates.ApplyTextureEXT ApplyTextureEXT;
        public static Delegates.TextureLightEXT TextureLightEXT;
        public static Delegates.TextureMaterialEXT TextureMaterialEXT;
        public static Delegates.AsyncMarkerSGIX AsyncMarkerSGIX;
        public static Delegates.FinishAsyncSGIX FinishAsyncSGIX;
        public static Delegates.PollAsyncSGIX PollAsyncSGIX;
        public static Delegates.GenAsyncMarkersSGIX GenAsyncMarkersSGIX;
        public static Delegates.DeleteAsyncMarkersSGIX DeleteAsyncMarkersSGIX;
        public static Delegates.IsAsyncMarkerSGIX IsAsyncMarkerSGIX;
        public static Delegates.VertexPointervINTEL_ VertexPointervINTEL_;
        public static Delegates.NormalPointervINTEL_ NormalPointervINTEL_;
        public static Delegates.ColorPointervINTEL_ ColorPointervINTEL_;
        public static Delegates.TexCoordPointervINTEL_ TexCoordPointervINTEL_;
        public static Delegates.PixelTransformParameteriEXT PixelTransformParameteriEXT;
        public static Delegates.PixelTransformParameterfEXT PixelTransformParameterfEXT;
        public static Delegates.PixelTransformParameterivEXT_ PixelTransformParameterivEXT_;
        public static Delegates.PixelTransformParameterfvEXT_ PixelTransformParameterfvEXT_;
        public static Delegates.SecondaryColor3bEXT SecondaryColor3bEXT;
        public static Delegates.SecondaryColor3bvEXT_ SecondaryColor3bvEXT_;
        public static Delegates.SecondaryColor3dEXT SecondaryColor3dEXT;
        public static Delegates.SecondaryColor3dvEXT_ SecondaryColor3dvEXT_;
        public static Delegates.SecondaryColor3fEXT SecondaryColor3fEXT;
        public static Delegates.SecondaryColor3fvEXT_ SecondaryColor3fvEXT_;
        public static Delegates.SecondaryColor3iEXT SecondaryColor3iEXT;
        public static Delegates.SecondaryColor3ivEXT_ SecondaryColor3ivEXT_;
        public static Delegates.SecondaryColor3sEXT SecondaryColor3sEXT;
        public static Delegates.SecondaryColor3svEXT_ SecondaryColor3svEXT_;
        public static Delegates.SecondaryColor3ubEXT SecondaryColor3ubEXT;
        public static Delegates.SecondaryColor3ubvEXT_ SecondaryColor3ubvEXT_;
        public static Delegates.SecondaryColor3uiEXT SecondaryColor3uiEXT;
        public static Delegates.SecondaryColor3uivEXT_ SecondaryColor3uivEXT_;
        public static Delegates.SecondaryColor3usEXT SecondaryColor3usEXT;
        public static Delegates.SecondaryColor3usvEXT_ SecondaryColor3usvEXT_;
        public static Delegates.SecondaryColorPointerEXT_ SecondaryColorPointerEXT_;
        public static Delegates.TextureNormalEXT TextureNormalEXT;
        public static Delegates.MultiDrawArraysEXT MultiDrawArraysEXT;
        public static Delegates.MultiDrawElementsEXT_ MultiDrawElementsEXT_;
        public static Delegates.FogCoordfEXT FogCoordfEXT;
        public static Delegates.FogCoordfvEXT_ FogCoordfvEXT_;
        public static Delegates.FogCoorddEXT FogCoorddEXT;
        public static Delegates.FogCoorddvEXT_ FogCoorddvEXT_;
        public static Delegates.FogCoordPointerEXT_ FogCoordPointerEXT_;
        public static Delegates.Tangent3bEXT Tangent3bEXT;
        public static Delegates.Tangent3bvEXT_ Tangent3bvEXT_;
        public static Delegates.Tangent3dEXT Tangent3dEXT;
        public static Delegates.Tangent3dvEXT_ Tangent3dvEXT_;
        public static Delegates.Tangent3fEXT Tangent3fEXT;
        public static Delegates.Tangent3fvEXT_ Tangent3fvEXT_;
        public static Delegates.Tangent3iEXT Tangent3iEXT;
        public static Delegates.Tangent3ivEXT_ Tangent3ivEXT_;
        public static Delegates.Tangent3sEXT Tangent3sEXT;
        public static Delegates.Tangent3svEXT_ Tangent3svEXT_;
        public static Delegates.Binormal3bEXT Binormal3bEXT;
        public static Delegates.Binormal3bvEXT_ Binormal3bvEXT_;
        public static Delegates.Binormal3dEXT Binormal3dEXT;
        public static Delegates.Binormal3dvEXT_ Binormal3dvEXT_;
        public static Delegates.Binormal3fEXT Binormal3fEXT;
        public static Delegates.Binormal3fvEXT_ Binormal3fvEXT_;
        public static Delegates.Binormal3iEXT Binormal3iEXT;
        public static Delegates.Binormal3ivEXT_ Binormal3ivEXT_;
        public static Delegates.Binormal3sEXT Binormal3sEXT;
        public static Delegates.Binormal3svEXT_ Binormal3svEXT_;
        public static Delegates.TangentPointerEXT_ TangentPointerEXT_;
        public static Delegates.BinormalPointerEXT_ BinormalPointerEXT_;
        public static Delegates.FinishTextureSUNX FinishTextureSUNX;
        public static Delegates.GlobalAlphaFactorbSUN GlobalAlphaFactorbSUN;
        public static Delegates.GlobalAlphaFactorsSUN GlobalAlphaFactorsSUN;
        public static Delegates.GlobalAlphaFactoriSUN GlobalAlphaFactoriSUN;
        public static Delegates.GlobalAlphaFactorfSUN GlobalAlphaFactorfSUN;
        public static Delegates.GlobalAlphaFactordSUN GlobalAlphaFactordSUN;
        public static Delegates.GlobalAlphaFactorubSUN GlobalAlphaFactorubSUN;
        public static Delegates.GlobalAlphaFactorusSUN GlobalAlphaFactorusSUN;
        public static Delegates.GlobalAlphaFactoruiSUN GlobalAlphaFactoruiSUN;
        public static Delegates.ReplacementCodeuiSUN ReplacementCodeuiSUN;
        public static Delegates.ReplacementCodeusSUN ReplacementCodeusSUN;
        public static Delegates.ReplacementCodeubSUN ReplacementCodeubSUN;
        public static Delegates.ReplacementCodeuivSUN_ ReplacementCodeuivSUN_;
        public static Delegates.ReplacementCodeusvSUN_ ReplacementCodeusvSUN_;
        public static Delegates.ReplacementCodeubvSUN_ ReplacementCodeubvSUN_;
        public static Delegates.ReplacementCodePointerSUN_ ReplacementCodePointerSUN_;
        public static Delegates.Color4ubVertex2fSUN Color4ubVertex2fSUN;
        public static Delegates.Color4ubVertex2fvSUN_ Color4ubVertex2fvSUN_;
        public static Delegates.Color4ubVertex3fSUN Color4ubVertex3fSUN;
        public static Delegates.Color4ubVertex3fvSUN_ Color4ubVertex3fvSUN_;
        public static Delegates.Color3fVertex3fSUN Color3fVertex3fSUN;
        public static Delegates.Color3fVertex3fvSUN_ Color3fVertex3fvSUN_;
        public static Delegates.Normal3fVertex3fSUN Normal3fVertex3fSUN;
        public static Delegates.Normal3fVertex3fvSUN_ Normal3fVertex3fvSUN_;
        public static Delegates.Color4fNormal3fVertex3fSUN Color4fNormal3fVertex3fSUN;
        public static Delegates.Color4fNormal3fVertex3fvSUN_ Color4fNormal3fVertex3fvSUN_;
        public static Delegates.TexCoord2fVertex3fSUN TexCoord2fVertex3fSUN;
        public static Delegates.TexCoord2fVertex3fvSUN_ TexCoord2fVertex3fvSUN_;
        public static Delegates.TexCoord4fVertex4fSUN TexCoord4fVertex4fSUN;
        public static Delegates.TexCoord4fVertex4fvSUN_ TexCoord4fVertex4fvSUN_;
        public static Delegates.TexCoord2fColor4ubVertex3fSUN TexCoord2fColor4ubVertex3fSUN;
        public static Delegates.TexCoord2fColor4ubVertex3fvSUN_ TexCoord2fColor4ubVertex3fvSUN_;
        public static Delegates.TexCoord2fColor3fVertex3fSUN TexCoord2fColor3fVertex3fSUN;
        public static Delegates.TexCoord2fColor3fVertex3fvSUN_ TexCoord2fColor3fVertex3fvSUN_;
        public static Delegates.TexCoord2fNormal3fVertex3fSUN TexCoord2fNormal3fVertex3fSUN;
        public static Delegates.TexCoord2fNormal3fVertex3fvSUN_ TexCoord2fNormal3fVertex3fvSUN_;
        public static Delegates.TexCoord2fColor4fNormal3fVertex3fSUN TexCoord2fColor4fNormal3fVertex3fSUN;
        public static Delegates.TexCoord2fColor4fNormal3fVertex3fvSUN_ TexCoord2fColor4fNormal3fVertex3fvSUN_;
        public static Delegates.TexCoord4fColor4fNormal3fVertex4fSUN TexCoord4fColor4fNormal3fVertex4fSUN;
        public static Delegates.TexCoord4fColor4fNormal3fVertex4fvSUN_ TexCoord4fColor4fNormal3fVertex4fvSUN_;
        public static Delegates.ReplacementCodeuiVertex3fSUN ReplacementCodeuiVertex3fSUN;
        public static Delegates.ReplacementCodeuiVertex3fvSUN_ ReplacementCodeuiVertex3fvSUN_;
        public static Delegates.ReplacementCodeuiColor4ubVertex3fSUN ReplacementCodeuiColor4ubVertex3fSUN;
        public static Delegates.ReplacementCodeuiColor4ubVertex3fvSUN_ ReplacementCodeuiColor4ubVertex3fvSUN_;
        public static Delegates.ReplacementCodeuiColor3fVertex3fSUN ReplacementCodeuiColor3fVertex3fSUN;
        public static Delegates.ReplacementCodeuiColor3fVertex3fvSUN_ ReplacementCodeuiColor3fVertex3fvSUN_;
        public static Delegates.ReplacementCodeuiNormal3fVertex3fSUN ReplacementCodeuiNormal3fVertex3fSUN;
        public static Delegates.ReplacementCodeuiNormal3fVertex3fvSUN_ ReplacementCodeuiNormal3fVertex3fvSUN_;
        public static Delegates.ReplacementCodeuiColor4fNormal3fVertex3fSUN ReplacementCodeuiColor4fNormal3fVertex3fSUN;
        public static Delegates.ReplacementCodeuiColor4fNormal3fVertex3fvSUN_ ReplacementCodeuiColor4fNormal3fVertex3fvSUN_;
        public static Delegates.ReplacementCodeuiTexCoord2fVertex3fSUN ReplacementCodeuiTexCoord2fVertex3fSUN;
        public static Delegates.ReplacementCodeuiTexCoord2fVertex3fvSUN_ ReplacementCodeuiTexCoord2fVertex3fvSUN_;
        public static Delegates.ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;
        public static Delegates.ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN_ ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN_;
        public static Delegates.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;
        public static Delegates.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN_ ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN_;
        public static Delegates.BlendFuncSeparateEXT BlendFuncSeparateEXT;
        public static Delegates.BlendFuncSeparateINGR BlendFuncSeparateINGR;
        public static Delegates.VertexWeightfEXT VertexWeightfEXT;
        public static Delegates.VertexWeightfvEXT_ VertexWeightfvEXT_;
        public static Delegates.VertexWeightPointerEXT_ VertexWeightPointerEXT_;
        public static Delegates.FlushVertexArrayRangeNV FlushVertexArrayRangeNV;
        public static Delegates.VertexArrayRangeNV_ VertexArrayRangeNV_;
        public static Delegates.CombinerParameterfvNV_ CombinerParameterfvNV_;
        public static Delegates.CombinerParameterfNV CombinerParameterfNV;
        public static Delegates.CombinerParameterivNV_ CombinerParameterivNV_;
        public static Delegates.CombinerParameteriNV CombinerParameteriNV;
        public static Delegates.CombinerInputNV CombinerInputNV;
        public static Delegates.CombinerOutputNV CombinerOutputNV;
        public static Delegates.FinalCombinerInputNV FinalCombinerInputNV;
        public static Delegates.GetCombinerInputParameterfvNV GetCombinerInputParameterfvNV;
        public static Delegates.GetCombinerInputParameterivNV GetCombinerInputParameterivNV;
        public static Delegates.GetCombinerOutputParameterfvNV GetCombinerOutputParameterfvNV;
        public static Delegates.GetCombinerOutputParameterivNV GetCombinerOutputParameterivNV;
        public static Delegates.GetFinalCombinerInputParameterfvNV GetFinalCombinerInputParameterfvNV;
        public static Delegates.GetFinalCombinerInputParameterivNV GetFinalCombinerInputParameterivNV;
        public static Delegates.ResizeBuffersMESA ResizeBuffersMESA;
        public static Delegates.WindowPos2dMESA WindowPos2dMESA;
        public static Delegates.WindowPos2dvMESA_ WindowPos2dvMESA_;
        public static Delegates.WindowPos2fMESA WindowPos2fMESA;
        public static Delegates.WindowPos2fvMESA_ WindowPos2fvMESA_;
        public static Delegates.WindowPos2iMESA WindowPos2iMESA;
        public static Delegates.WindowPos2ivMESA_ WindowPos2ivMESA_;
        public static Delegates.WindowPos2sMESA WindowPos2sMESA;
        public static Delegates.WindowPos2svMESA_ WindowPos2svMESA_;
        public static Delegates.WindowPos3dMESA WindowPos3dMESA;
        public static Delegates.WindowPos3dvMESA_ WindowPos3dvMESA_;
        public static Delegates.WindowPos3fMESA WindowPos3fMESA;
        public static Delegates.WindowPos3fvMESA_ WindowPos3fvMESA_;
        public static Delegates.WindowPos3iMESA WindowPos3iMESA;
        public static Delegates.WindowPos3ivMESA_ WindowPos3ivMESA_;
        public static Delegates.WindowPos3sMESA WindowPos3sMESA;
        public static Delegates.WindowPos3svMESA_ WindowPos3svMESA_;
        public static Delegates.WindowPos4dMESA WindowPos4dMESA;
        public static Delegates.WindowPos4dvMESA_ WindowPos4dvMESA_;
        public static Delegates.WindowPos4fMESA WindowPos4fMESA;
        public static Delegates.WindowPos4fvMESA_ WindowPos4fvMESA_;
        public static Delegates.WindowPos4iMESA WindowPos4iMESA;
        public static Delegates.WindowPos4ivMESA_ WindowPos4ivMESA_;
        public static Delegates.WindowPos4sMESA WindowPos4sMESA;
        public static Delegates.WindowPos4svMESA_ WindowPos4svMESA_;
        public static Delegates.MultiModeDrawArraysIBM_ MultiModeDrawArraysIBM_;
        public static Delegates.MultiModeDrawElementsIBM_ MultiModeDrawElementsIBM_;
        public static Delegates.ColorPointerListIBM_ ColorPointerListIBM_;
        public static Delegates.SecondaryColorPointerListIBM_ SecondaryColorPointerListIBM_;
        public static Delegates.EdgeFlagPointerListIBM_ EdgeFlagPointerListIBM_;
        public static Delegates.FogCoordPointerListIBM_ FogCoordPointerListIBM_;
        public static Delegates.IndexPointerListIBM_ IndexPointerListIBM_;
        public static Delegates.NormalPointerListIBM_ NormalPointerListIBM_;
        public static Delegates.TexCoordPointerListIBM_ TexCoordPointerListIBM_;
        public static Delegates.VertexPointerListIBM_ VertexPointerListIBM_;
        public static Delegates.TbufferMask3DFX TbufferMask3DFX;
        public static Delegates.SampleMaskEXT SampleMaskEXT;
        public static Delegates.SamplePatternEXT SamplePatternEXT;
        public static Delegates.TextureColorMaskSGIS TextureColorMaskSGIS;
        public static Delegates.IglooInterfaceSGIX_ IglooInterfaceSGIX_;
        public static Delegates.DeleteFencesNV_ DeleteFencesNV_;
        public static Delegates.GenFencesNV GenFencesNV;
        public static Delegates.IsFenceNV IsFenceNV;
        public static Delegates.TestFenceNV TestFenceNV;
        public static Delegates.GetFenceivNV GetFenceivNV;
        public static Delegates.FinishFenceNV FinishFenceNV;
        public static Delegates.SetFenceNV SetFenceNV;
        public static Delegates.MapControlPointsNV_ MapControlPointsNV_;
        public static Delegates.MapParameterivNV_ MapParameterivNV_;
        public static Delegates.MapParameterfvNV_ MapParameterfvNV_;
        public static Delegates.GetMapControlPointsNV_ GetMapControlPointsNV_;
        public static Delegates.GetMapParameterivNV GetMapParameterivNV;
        public static Delegates.GetMapParameterfvNV GetMapParameterfvNV;
        public static Delegates.GetMapAttribParameterivNV GetMapAttribParameterivNV;
        public static Delegates.GetMapAttribParameterfvNV GetMapAttribParameterfvNV;
        public static Delegates.EvalMapsNV EvalMapsNV;
        public static Delegates.CombinerStageParameterfvNV_ CombinerStageParameterfvNV_;
        public static Delegates.GetCombinerStageParameterfvNV GetCombinerStageParameterfvNV;
        public static Delegates.AreProgramsResidentNV_ AreProgramsResidentNV_;
        public static Delegates.BindProgramNV BindProgramNV;
        public static Delegates.DeleteProgramsNV_ DeleteProgramsNV_;
        public static Delegates.ExecuteProgramNV_ ExecuteProgramNV_;
        public static Delegates.GenProgramsNV GenProgramsNV;
        public static Delegates.GetProgramParameterdvNV GetProgramParameterdvNV;
        public static Delegates.GetProgramParameterfvNV GetProgramParameterfvNV;
        public static Delegates.GetProgramivNV GetProgramivNV;
        public static Delegates.GetProgramStringNV GetProgramStringNV;
        public static Delegates.GetTrackMatrixivNV GetTrackMatrixivNV;
        public static Delegates.GetVertexAttribdvNV GetVertexAttribdvNV;
        public static Delegates.GetVertexAttribfvNV GetVertexAttribfvNV;
        public static Delegates.GetVertexAttribivNV GetVertexAttribivNV;
        public static Delegates.GetVertexAttribPointervNV GetVertexAttribPointervNV;
        public static Delegates.IsProgramNV IsProgramNV;
        public static Delegates.LoadProgramNV_ LoadProgramNV_;
        public static Delegates.ProgramParameter4dNV ProgramParameter4dNV;
        public static Delegates.ProgramParameter4dvNV_ ProgramParameter4dvNV_;
        public static Delegates.ProgramParameter4fNV ProgramParameter4fNV;
        public static Delegates.ProgramParameter4fvNV_ ProgramParameter4fvNV_;
        public static Delegates.ProgramParameters4dvNV_ ProgramParameters4dvNV_;
        public static Delegates.ProgramParameters4fvNV_ ProgramParameters4fvNV_;
        public static Delegates.RequestResidentProgramsNV_ RequestResidentProgramsNV_;
        public static Delegates.TrackMatrixNV TrackMatrixNV;
        public static Delegates.VertexAttribPointerNV_ VertexAttribPointerNV_;
        public static Delegates.VertexAttrib1dNV VertexAttrib1dNV;
        public static Delegates.VertexAttrib1dvNV_ VertexAttrib1dvNV_;
        public static Delegates.VertexAttrib1fNV VertexAttrib1fNV;
        public static Delegates.VertexAttrib1fvNV_ VertexAttrib1fvNV_;
        public static Delegates.VertexAttrib1sNV VertexAttrib1sNV;
        public static Delegates.VertexAttrib1svNV_ VertexAttrib1svNV_;
        public static Delegates.VertexAttrib2dNV VertexAttrib2dNV;
        public static Delegates.VertexAttrib2dvNV_ VertexAttrib2dvNV_;
        public static Delegates.VertexAttrib2fNV VertexAttrib2fNV;
        public static Delegates.VertexAttrib2fvNV_ VertexAttrib2fvNV_;
        public static Delegates.VertexAttrib2sNV VertexAttrib2sNV;
        public static Delegates.VertexAttrib2svNV_ VertexAttrib2svNV_;
        public static Delegates.VertexAttrib3dNV VertexAttrib3dNV;
        public static Delegates.VertexAttrib3dvNV_ VertexAttrib3dvNV_;
        public static Delegates.VertexAttrib3fNV VertexAttrib3fNV;
        public static Delegates.VertexAttrib3fvNV_ VertexAttrib3fvNV_;
        public static Delegates.VertexAttrib3sNV VertexAttrib3sNV;
        public static Delegates.VertexAttrib3svNV_ VertexAttrib3svNV_;
        public static Delegates.VertexAttrib4dNV VertexAttrib4dNV;
        public static Delegates.VertexAttrib4dvNV_ VertexAttrib4dvNV_;
        public static Delegates.VertexAttrib4fNV VertexAttrib4fNV;
        public static Delegates.VertexAttrib4fvNV_ VertexAttrib4fvNV_;
        public static Delegates.VertexAttrib4sNV VertexAttrib4sNV;
        public static Delegates.VertexAttrib4svNV_ VertexAttrib4svNV_;
        public static Delegates.VertexAttrib4ubNV VertexAttrib4ubNV;
        public static Delegates.VertexAttrib4ubvNV_ VertexAttrib4ubvNV_;
        public static Delegates.VertexAttribs1dvNV_ VertexAttribs1dvNV_;
        public static Delegates.VertexAttribs1fvNV_ VertexAttribs1fvNV_;
        public static Delegates.VertexAttribs1svNV_ VertexAttribs1svNV_;
        public static Delegates.VertexAttribs2dvNV_ VertexAttribs2dvNV_;
        public static Delegates.VertexAttribs2fvNV_ VertexAttribs2fvNV_;
        public static Delegates.VertexAttribs2svNV_ VertexAttribs2svNV_;
        public static Delegates.VertexAttribs3dvNV_ VertexAttribs3dvNV_;
        public static Delegates.VertexAttribs3fvNV_ VertexAttribs3fvNV_;
        public static Delegates.VertexAttribs3svNV_ VertexAttribs3svNV_;
        public static Delegates.VertexAttribs4dvNV_ VertexAttribs4dvNV_;
        public static Delegates.VertexAttribs4fvNV_ VertexAttribs4fvNV_;
        public static Delegates.VertexAttribs4svNV_ VertexAttribs4svNV_;
        public static Delegates.VertexAttribs4ubvNV_ VertexAttribs4ubvNV_;
        public static Delegates.TexBumpParameterivATI_ TexBumpParameterivATI_;
        public static Delegates.TexBumpParameterfvATI_ TexBumpParameterfvATI_;
        public static Delegates.GetTexBumpParameterivATI GetTexBumpParameterivATI;
        public static Delegates.GetTexBumpParameterfvATI GetTexBumpParameterfvATI;
        public static Delegates.GenFragmentShadersATI GenFragmentShadersATI;
        public static Delegates.BindFragmentShaderATI BindFragmentShaderATI;
        public static Delegates.DeleteFragmentShaderATI DeleteFragmentShaderATI;
        public static Delegates.BeginFragmentShaderATI BeginFragmentShaderATI;
        public static Delegates.EndFragmentShaderATI EndFragmentShaderATI;
        public static Delegates.PassTexCoordATI PassTexCoordATI;
        public static Delegates.SampleMapATI SampleMapATI;
        public static Delegates.ColorFragmentOp1ATI ColorFragmentOp1ATI;
        public static Delegates.ColorFragmentOp2ATI ColorFragmentOp2ATI;
        public static Delegates.ColorFragmentOp3ATI ColorFragmentOp3ATI;
        public static Delegates.AlphaFragmentOp1ATI AlphaFragmentOp1ATI;
        public static Delegates.AlphaFragmentOp2ATI AlphaFragmentOp2ATI;
        public static Delegates.AlphaFragmentOp3ATI AlphaFragmentOp3ATI;
        public static Delegates.SetFragmentShaderConstantATI_ SetFragmentShaderConstantATI_;
        public static Delegates.PNTrianglesiATI PNTrianglesiATI;
        public static Delegates.PNTrianglesfATI PNTrianglesfATI;
        public static Delegates.NewObjectBufferATI_ NewObjectBufferATI_;
        public static Delegates.IsObjectBufferATI IsObjectBufferATI;
        public static Delegates.UpdateObjectBufferATI_ UpdateObjectBufferATI_;
        public static Delegates.GetObjectBufferfvATI GetObjectBufferfvATI;
        public static Delegates.GetObjectBufferivATI GetObjectBufferivATI;
        public static Delegates.FreeObjectBufferATI FreeObjectBufferATI;
        public static Delegates.ArrayObjectATI ArrayObjectATI;
        public static Delegates.GetArrayObjectfvATI GetArrayObjectfvATI;
        public static Delegates.GetArrayObjectivATI GetArrayObjectivATI;
        public static Delegates.VariantArrayObjectATI VariantArrayObjectATI;
        public static Delegates.GetVariantArrayObjectfvATI GetVariantArrayObjectfvATI;
        public static Delegates.GetVariantArrayObjectivATI GetVariantArrayObjectivATI;
        public static Delegates.BeginVertexShaderEXT BeginVertexShaderEXT;
        public static Delegates.EndVertexShaderEXT EndVertexShaderEXT;
        public static Delegates.BindVertexShaderEXT BindVertexShaderEXT;
        public static Delegates.GenVertexShadersEXT GenVertexShadersEXT;
        public static Delegates.DeleteVertexShaderEXT DeleteVertexShaderEXT;
        public static Delegates.ShaderOp1EXT ShaderOp1EXT;
        public static Delegates.ShaderOp2EXT ShaderOp2EXT;
        public static Delegates.ShaderOp3EXT ShaderOp3EXT;
        public static Delegates.SwizzleEXT SwizzleEXT;
        public static Delegates.WriteMaskEXT WriteMaskEXT;
        public static Delegates.InsertComponentEXT InsertComponentEXT;
        public static Delegates.ExtractComponentEXT ExtractComponentEXT;
        public static Delegates.GenSymbolsEXT GenSymbolsEXT;
        public static Delegates.SetInvariantEXT_ SetInvariantEXT_;
        public static Delegates.SetLocalConstantEXT_ SetLocalConstantEXT_;
        public static Delegates.VariantbvEXT_ VariantbvEXT_;
        public static Delegates.VariantsvEXT_ VariantsvEXT_;
        public static Delegates.VariantivEXT_ VariantivEXT_;
        public static Delegates.VariantfvEXT_ VariantfvEXT_;
        public static Delegates.VariantdvEXT_ VariantdvEXT_;
        public static Delegates.VariantubvEXT_ VariantubvEXT_;
        public static Delegates.VariantusvEXT_ VariantusvEXT_;
        public static Delegates.VariantuivEXT_ VariantuivEXT_;
        public static Delegates.VariantPointerEXT_ VariantPointerEXT_;
        public static Delegates.EnableVariantClientStateEXT EnableVariantClientStateEXT;
        public static Delegates.DisableVariantClientStateEXT DisableVariantClientStateEXT;
        public static Delegates.BindLightParameterEXT BindLightParameterEXT;
        public static Delegates.BindMaterialParameterEXT BindMaterialParameterEXT;
        public static Delegates.BindTexGenParameterEXT BindTexGenParameterEXT;
        public static Delegates.BindTextureUnitParameterEXT BindTextureUnitParameterEXT;
        public static Delegates.BindParameterEXT BindParameterEXT;
        public static Delegates.IsVariantEnabledEXT IsVariantEnabledEXT;
        public static Delegates.GetVariantBooleanvEXT GetVariantBooleanvEXT;
        public static Delegates.GetVariantIntegervEXT GetVariantIntegervEXT;
        public static Delegates.GetVariantFloatvEXT GetVariantFloatvEXT;
        public static Delegates.GetVariantPointervEXT GetVariantPointervEXT;
        public static Delegates.GetInvariantBooleanvEXT GetInvariantBooleanvEXT;
        public static Delegates.GetInvariantIntegervEXT GetInvariantIntegervEXT;
        public static Delegates.GetInvariantFloatvEXT GetInvariantFloatvEXT;
        public static Delegates.GetLocalConstantBooleanvEXT GetLocalConstantBooleanvEXT;
        public static Delegates.GetLocalConstantIntegervEXT GetLocalConstantIntegervEXT;
        public static Delegates.GetLocalConstantFloatvEXT GetLocalConstantFloatvEXT;
        public static Delegates.VertexStream1sATI VertexStream1sATI;
        public static Delegates.VertexStream1svATI_ VertexStream1svATI_;
        public static Delegates.VertexStream1iATI VertexStream1iATI;
        public static Delegates.VertexStream1ivATI_ VertexStream1ivATI_;
        public static Delegates.VertexStream1fATI VertexStream1fATI;
        public static Delegates.VertexStream1fvATI_ VertexStream1fvATI_;
        public static Delegates.VertexStream1dATI VertexStream1dATI;
        public static Delegates.VertexStream1dvATI_ VertexStream1dvATI_;
        public static Delegates.VertexStream2sATI VertexStream2sATI;
        public static Delegates.VertexStream2svATI_ VertexStream2svATI_;
        public static Delegates.VertexStream2iATI VertexStream2iATI;
        public static Delegates.VertexStream2ivATI_ VertexStream2ivATI_;
        public static Delegates.VertexStream2fATI VertexStream2fATI;
        public static Delegates.VertexStream2fvATI_ VertexStream2fvATI_;
        public static Delegates.VertexStream2dATI VertexStream2dATI;
        public static Delegates.VertexStream2dvATI_ VertexStream2dvATI_;
        public static Delegates.VertexStream3sATI VertexStream3sATI;
        public static Delegates.VertexStream3svATI_ VertexStream3svATI_;
        public static Delegates.VertexStream3iATI VertexStream3iATI;
        public static Delegates.VertexStream3ivATI_ VertexStream3ivATI_;
        public static Delegates.VertexStream3fATI VertexStream3fATI;
        public static Delegates.VertexStream3fvATI_ VertexStream3fvATI_;
        public static Delegates.VertexStream3dATI VertexStream3dATI;
        public static Delegates.VertexStream3dvATI_ VertexStream3dvATI_;
        public static Delegates.VertexStream4sATI VertexStream4sATI;
        public static Delegates.VertexStream4svATI_ VertexStream4svATI_;
        public static Delegates.VertexStream4iATI VertexStream4iATI;
        public static Delegates.VertexStream4ivATI_ VertexStream4ivATI_;
        public static Delegates.VertexStream4fATI VertexStream4fATI;
        public static Delegates.VertexStream4fvATI_ VertexStream4fvATI_;
        public static Delegates.VertexStream4dATI VertexStream4dATI;
        public static Delegates.VertexStream4dvATI_ VertexStream4dvATI_;
        public static Delegates.NormalStream3bATI NormalStream3bATI;
        public static Delegates.NormalStream3bvATI_ NormalStream3bvATI_;
        public static Delegates.NormalStream3sATI NormalStream3sATI;
        public static Delegates.NormalStream3svATI_ NormalStream3svATI_;
        public static Delegates.NormalStream3iATI NormalStream3iATI;
        public static Delegates.NormalStream3ivATI_ NormalStream3ivATI_;
        public static Delegates.NormalStream3fATI NormalStream3fATI;
        public static Delegates.NormalStream3fvATI_ NormalStream3fvATI_;
        public static Delegates.NormalStream3dATI NormalStream3dATI;
        public static Delegates.NormalStream3dvATI_ NormalStream3dvATI_;
        public static Delegates.ClientActiveVertexStreamATI ClientActiveVertexStreamATI;
        public static Delegates.VertexBlendEnviATI VertexBlendEnviATI;
        public static Delegates.VertexBlendEnvfATI VertexBlendEnvfATI;
        public static Delegates.ElementPointerATI_ ElementPointerATI_;
        public static Delegates.DrawElementArrayATI DrawElementArrayATI;
        public static Delegates.DrawRangeElementArrayATI DrawRangeElementArrayATI;
        public static Delegates.DrawMeshArraysSUN DrawMeshArraysSUN;
        public static Delegates.GenOcclusionQueriesNV GenOcclusionQueriesNV;
        public static Delegates.DeleteOcclusionQueriesNV_ DeleteOcclusionQueriesNV_;
        public static Delegates.IsOcclusionQueryNV IsOcclusionQueryNV;
        public static Delegates.BeginOcclusionQueryNV BeginOcclusionQueryNV;
        public static Delegates.EndOcclusionQueryNV EndOcclusionQueryNV;
        public static Delegates.GetOcclusionQueryivNV GetOcclusionQueryivNV;
        public static Delegates.GetOcclusionQueryuivNV GetOcclusionQueryuivNV;
        public static Delegates.PointParameteriNV PointParameteriNV;
        public static Delegates.PointParameterivNV_ PointParameterivNV_;
        public static Delegates.ActiveStencilFaceEXT ActiveStencilFaceEXT;
        public static Delegates.ElementPointerAPPLE_ ElementPointerAPPLE_;
        public static Delegates.DrawElementArrayAPPLE DrawElementArrayAPPLE;
        public static Delegates.DrawRangeElementArrayAPPLE DrawRangeElementArrayAPPLE;
        public static Delegates.MultiDrawElementArrayAPPLE_ MultiDrawElementArrayAPPLE_;
        public static Delegates.MultiDrawRangeElementArrayAPPLE_ MultiDrawRangeElementArrayAPPLE_;
        public static Delegates.GenFencesAPPLE GenFencesAPPLE;
        public static Delegates.DeleteFencesAPPLE_ DeleteFencesAPPLE_;
        public static Delegates.SetFenceAPPLE SetFenceAPPLE;
        public static Delegates.IsFenceAPPLE IsFenceAPPLE;
        public static Delegates.TestFenceAPPLE TestFenceAPPLE;
        public static Delegates.FinishFenceAPPLE FinishFenceAPPLE;
        public static Delegates.TestObjectAPPLE TestObjectAPPLE;
        public static Delegates.FinishObjectAPPLE FinishObjectAPPLE;
        public static Delegates.BindVertexArrayAPPLE BindVertexArrayAPPLE;
        public static Delegates.DeleteVertexArraysAPPLE_ DeleteVertexArraysAPPLE_;
        public static Delegates.GenVertexArraysAPPLE_ GenVertexArraysAPPLE_;
        public static Delegates.IsVertexArrayAPPLE IsVertexArrayAPPLE;
        public static Delegates.VertexArrayRangeAPPLE_ VertexArrayRangeAPPLE_;
        public static Delegates.FlushVertexArrayRangeAPPLE_ FlushVertexArrayRangeAPPLE_;
        public static Delegates.VertexArrayParameteriAPPLE VertexArrayParameteriAPPLE;
        public static Delegates.DrawBuffersATI_ DrawBuffersATI_;
        public static Delegates.ProgramNamedParameter4fNV_ ProgramNamedParameter4fNV_;
        public static Delegates.ProgramNamedParameter4dNV_ ProgramNamedParameter4dNV_;
        public static Delegates.ProgramNamedParameter4fvNV_ ProgramNamedParameter4fvNV_;
        public static Delegates.ProgramNamedParameter4dvNV_ ProgramNamedParameter4dvNV_;
        public static Delegates.GetProgramNamedParameterfvNV_ GetProgramNamedParameterfvNV_;
        public static Delegates.GetProgramNamedParameterdvNV_ GetProgramNamedParameterdvNV_;
        public static Delegates.Vertex2hNV Vertex2hNV;
        public static Delegates.Vertex2hvNV_ Vertex2hvNV_;
        public static Delegates.Vertex3hNV Vertex3hNV;
        public static Delegates.Vertex3hvNV_ Vertex3hvNV_;
        public static Delegates.Vertex4hNV Vertex4hNV;
        public static Delegates.Vertex4hvNV_ Vertex4hvNV_;
        public static Delegates.Normal3hNV Normal3hNV;
        public static Delegates.Normal3hvNV_ Normal3hvNV_;
        public static Delegates.Color3hNV Color3hNV;
        public static Delegates.Color3hvNV_ Color3hvNV_;
        public static Delegates.Color4hNV Color4hNV;
        public static Delegates.Color4hvNV_ Color4hvNV_;
        public static Delegates.TexCoord1hNV TexCoord1hNV;
        public static Delegates.TexCoord1hvNV_ TexCoord1hvNV_;
        public static Delegates.TexCoord2hNV TexCoord2hNV;
        public static Delegates.TexCoord2hvNV_ TexCoord2hvNV_;
        public static Delegates.TexCoord3hNV TexCoord3hNV;
        public static Delegates.TexCoord3hvNV_ TexCoord3hvNV_;
        public static Delegates.TexCoord4hNV TexCoord4hNV;
        public static Delegates.TexCoord4hvNV_ TexCoord4hvNV_;
        public static Delegates.MultiTexCoord1hNV MultiTexCoord1hNV;
        public static Delegates.MultiTexCoord1hvNV_ MultiTexCoord1hvNV_;
        public static Delegates.MultiTexCoord2hNV MultiTexCoord2hNV;
        public static Delegates.MultiTexCoord2hvNV_ MultiTexCoord2hvNV_;
        public static Delegates.MultiTexCoord3hNV MultiTexCoord3hNV;
        public static Delegates.MultiTexCoord3hvNV_ MultiTexCoord3hvNV_;
        public static Delegates.MultiTexCoord4hNV MultiTexCoord4hNV;
        public static Delegates.MultiTexCoord4hvNV_ MultiTexCoord4hvNV_;
        public static Delegates.FogCoordhNV FogCoordhNV;
        public static Delegates.FogCoordhvNV_ FogCoordhvNV_;
        public static Delegates.SecondaryColor3hNV SecondaryColor3hNV;
        public static Delegates.SecondaryColor3hvNV_ SecondaryColor3hvNV_;
        public static Delegates.VertexWeighthNV VertexWeighthNV;
        public static Delegates.VertexWeighthvNV_ VertexWeighthvNV_;
        public static Delegates.VertexAttrib1hNV VertexAttrib1hNV;
        public static Delegates.VertexAttrib1hvNV_ VertexAttrib1hvNV_;
        public static Delegates.VertexAttrib2hNV VertexAttrib2hNV;
        public static Delegates.VertexAttrib2hvNV_ VertexAttrib2hvNV_;
        public static Delegates.VertexAttrib3hNV VertexAttrib3hNV;
        public static Delegates.VertexAttrib3hvNV_ VertexAttrib3hvNV_;
        public static Delegates.VertexAttrib4hNV VertexAttrib4hNV;
        public static Delegates.VertexAttrib4hvNV_ VertexAttrib4hvNV_;
        public static Delegates.VertexAttribs1hvNV_ VertexAttribs1hvNV_;
        public static Delegates.VertexAttribs2hvNV_ VertexAttribs2hvNV_;
        public static Delegates.VertexAttribs3hvNV_ VertexAttribs3hvNV_;
        public static Delegates.VertexAttribs4hvNV_ VertexAttribs4hvNV_;
        public static Delegates.PixelDataRangeNV_ PixelDataRangeNV_;
        public static Delegates.FlushPixelDataRangeNV FlushPixelDataRangeNV;
        public static Delegates.PrimitiveRestartNV PrimitiveRestartNV;
        public static Delegates.PrimitiveRestartIndexNV PrimitiveRestartIndexNV;
        public static Delegates.MapObjectBufferATI MapObjectBufferATI;
        public static Delegates.UnmapObjectBufferATI UnmapObjectBufferATI;
        public static Delegates.StencilOpSeparateATI StencilOpSeparateATI;
        public static Delegates.StencilFuncSeparateATI StencilFuncSeparateATI;
        public static Delegates.VertexAttribArrayObjectATI VertexAttribArrayObjectATI;
        public static Delegates.GetVertexAttribArrayObjectfvATI GetVertexAttribArrayObjectfvATI;
        public static Delegates.GetVertexAttribArrayObjectivATI GetVertexAttribArrayObjectivATI;
        public static Delegates.DepthBoundsEXT DepthBoundsEXT;
        public static Delegates.BlendEquationSeparateEXT BlendEquationSeparateEXT;
        public static Delegates.IsRenderbufferEXT IsRenderbufferEXT;
        public static Delegates.BindRenderbufferEXT BindRenderbufferEXT;
        public static Delegates.DeleteRenderbuffersEXT_ DeleteRenderbuffersEXT_;
        public static Delegates.GenRenderbuffersEXT GenRenderbuffersEXT;
        public static Delegates.RenderbufferStorageEXT RenderbufferStorageEXT;
        public static Delegates.GetRenderbufferParameterivEXT GetRenderbufferParameterivEXT;
        public static Delegates.IsFramebufferEXT IsFramebufferEXT;
        public static Delegates.BindFramebufferEXT BindFramebufferEXT;
        public static Delegates.DeleteFramebuffersEXT_ DeleteFramebuffersEXT_;
        public static Delegates.GenFramebuffersEXT GenFramebuffersEXT;
        public static Delegates.CheckFramebufferStatusEXT CheckFramebufferStatusEXT;
        public static Delegates.FramebufferTexture1DEXT FramebufferTexture1DEXT;
        public static Delegates.FramebufferTexture2DEXT FramebufferTexture2DEXT;
        public static Delegates.FramebufferTexture3DEXT FramebufferTexture3DEXT;
        public static Delegates.FramebufferRenderbufferEXT FramebufferRenderbufferEXT;
        public static Delegates.GetFramebufferAttachmentParameterivEXT GetFramebufferAttachmentParameterivEXT;
        public static Delegates.GenerateMipmapEXT GenerateMipmapEXT;
        public static Delegates.StringMarkerGREMEDY_ StringMarkerGREMEDY_;
        #endregion

        #region Wrappers

        #region CallLists
        public static void CallLists(GLsizei n, Enums.ListNameType type, object lists)
        {
            GCHandle h0 = GCHandle.Alloc(lists, GCHandleType.Pinned);
            try
            {
                CallLists_(n, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void CallLists(GLsizei n, Enums.ListNameType type, IntPtr lists)
        {
            CallLists_(n, type, lists);
        }
        #endregion

        #region Bitmap
        public static void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, object bitmap)
        {
            GCHandle h0 = GCHandle.Alloc(bitmap, GCHandleType.Pinned);
            try
            {
                Bitmap_(width, height, xorig, yorig, xmove, ymove, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, IntPtr bitmap)
        {
            Bitmap_(width, height, xorig, yorig, xmove, ymove, bitmap);
        }
        public static void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte[] bitmap)
        {
            GCHandle h0 = GCHandle.Alloc(bitmap, GCHandleType.Pinned);
            try
            {
                Bitmap_(width, height, xorig, yorig, xmove, ymove, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3bv
        public static void Color3bv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3bv(IntPtr v)
        {
            Color3bv_(v);
        }
        public static void Color3bv(GLbyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3dv
        public static void Color3dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3dv(IntPtr v)
        {
            Color3dv_(v);
        }
        public static void Color3dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3fv
        public static void Color3fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3fv(IntPtr v)
        {
            Color3fv_(v);
        }
        public static void Color3fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3iv
        public static void Color3iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3iv(IntPtr v)
        {
            Color3iv_(v);
        }
        public static void Color3iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3sv
        public static void Color3sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3sv(IntPtr v)
        {
            Color3sv_(v);
        }
        public static void Color3sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3ubv
        public static void Color3ubv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3ubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3ubv(IntPtr v)
        {
            Color3ubv_(v);
        }
        public static void Color3ubv(GLubyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3ubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3uiv
        public static void Color3uiv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3uiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3uiv(IntPtr v)
        {
            Color3uiv_(v);
        }
        public static void Color3uiv(GLuint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3uiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color3usv
        public static void Color3usv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3usv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color3usv(IntPtr v)
        {
            Color3usv_(v);
        }
        public static void Color3usv(GLushort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color3usv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4bv
        public static void Color4bv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4bv(IntPtr v)
        {
            Color4bv_(v);
        }
        public static void Color4bv(GLbyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4dv
        public static void Color4dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4dv(IntPtr v)
        {
            Color4dv_(v);
        }
        public static void Color4dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4fv
        public static void Color4fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4fv(IntPtr v)
        {
            Color4fv_(v);
        }
        public static void Color4fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4iv
        public static void Color4iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4iv(IntPtr v)
        {
            Color4iv_(v);
        }
        public static void Color4iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4sv
        public static void Color4sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4sv(IntPtr v)
        {
            Color4sv_(v);
        }
        public static void Color4sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4ubv
        public static void Color4ubv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4ubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4ubv(IntPtr v)
        {
            Color4ubv_(v);
        }
        public static void Color4ubv(GLubyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4ubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4uiv
        public static void Color4uiv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4uiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4uiv(IntPtr v)
        {
            Color4uiv_(v);
        }
        public static void Color4uiv(GLuint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4uiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Color4usv
        public static void Color4usv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4usv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Color4usv(IntPtr v)
        {
            Color4usv_(v);
        }
        public static void Color4usv(GLushort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Color4usv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Indexdv
        public static void Indexdv(object c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexdv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Indexdv(IntPtr c)
        {
            Indexdv_(c);
        }
        public static void Indexdv(GLdouble[] c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexdv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Indexfv
        public static void Indexfv(object c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexfv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Indexfv(IntPtr c)
        {
            Indexfv_(c);
        }
        public static void Indexfv(GLfloat[] c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexfv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Indexiv
        public static void Indexiv(object c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Indexiv(IntPtr c)
        {
            Indexiv_(c);
        }
        public static void Indexiv(GLint[] c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Indexsv
        public static void Indexsv(object c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexsv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Indexsv(IntPtr c)
        {
            Indexsv_(c);
        }
        public static void Indexsv(GLshort[] c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexsv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Normal3bv
        public static void Normal3bv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Normal3bv(IntPtr v)
        {
            Normal3bv_(v);
        }
        public static void Normal3bv(GLbyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Normal3dv
        public static void Normal3dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Normal3dv(IntPtr v)
        {
            Normal3dv_(v);
        }
        public static void Normal3dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Normal3fv
        public static void Normal3fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Normal3fv(IntPtr v)
        {
            Normal3fv_(v);
        }
        public static void Normal3fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Normal3iv
        public static void Normal3iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Normal3iv(IntPtr v)
        {
            Normal3iv_(v);
        }
        public static void Normal3iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Normal3sv
        public static void Normal3sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Normal3sv(IntPtr v)
        {
            Normal3sv_(v);
        }
        public static void Normal3sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Normal3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos2dv
        public static void RasterPos2dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos2dv(IntPtr v)
        {
            RasterPos2dv_(v);
        }
        public static void RasterPos2dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos2fv
        public static void RasterPos2fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos2fv(IntPtr v)
        {
            RasterPos2fv_(v);
        }
        public static void RasterPos2fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos2iv
        public static void RasterPos2iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos2iv(IntPtr v)
        {
            RasterPos2iv_(v);
        }
        public static void RasterPos2iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos2sv
        public static void RasterPos2sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos2sv(IntPtr v)
        {
            RasterPos2sv_(v);
        }
        public static void RasterPos2sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos3dv
        public static void RasterPos3dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos3dv(IntPtr v)
        {
            RasterPos3dv_(v);
        }
        public static void RasterPos3dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos3fv
        public static void RasterPos3fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos3fv(IntPtr v)
        {
            RasterPos3fv_(v);
        }
        public static void RasterPos3fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos3iv
        public static void RasterPos3iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos3iv(IntPtr v)
        {
            RasterPos3iv_(v);
        }
        public static void RasterPos3iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos3sv
        public static void RasterPos3sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos3sv(IntPtr v)
        {
            RasterPos3sv_(v);
        }
        public static void RasterPos3sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos4dv
        public static void RasterPos4dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos4dv(IntPtr v)
        {
            RasterPos4dv_(v);
        }
        public static void RasterPos4dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos4fv
        public static void RasterPos4fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos4fv(IntPtr v)
        {
            RasterPos4fv_(v);
        }
        public static void RasterPos4fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos4iv
        public static void RasterPos4iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos4iv(IntPtr v)
        {
            RasterPos4iv_(v);
        }
        public static void RasterPos4iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region RasterPos4sv
        public static void RasterPos4sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void RasterPos4sv(IntPtr v)
        {
            RasterPos4sv_(v);
        }
        public static void RasterPos4sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                RasterPos4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Rectdv
        public static void Rectdv(object v1, object v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectdv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        public static void Rectdv(IntPtr v1, IntPtr v2)
        {
            Rectdv_(v1, v2);
        }
        public static void Rectdv(GLdouble[] v1, GLdouble[] v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectdv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        #endregion

        #region Rectfv
        public static void Rectfv(object v1, object v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectfv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        public static void Rectfv(IntPtr v1, IntPtr v2)
        {
            Rectfv_(v1, v2);
        }
        public static void Rectfv(GLfloat[] v1, GLfloat[] v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectfv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        #endregion

        #region Rectiv
        public static void Rectiv(object v1, object v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectiv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        public static void Rectiv(IntPtr v1, IntPtr v2)
        {
            Rectiv_(v1, v2);
        }
        public static void Rectiv(GLint[] v1, GLint[] v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectiv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        #endregion

        #region Rectsv
        public static void Rectsv(object v1, object v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectsv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        public static void Rectsv(IntPtr v1, IntPtr v2)
        {
            Rectsv_(v1, v2);
        }
        public static void Rectsv(GLshort[] v1, GLshort[] v2)
        {
            GCHandle h0 = GCHandle.Alloc(v1, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(v2, GCHandleType.Pinned);
            try
            {
                Rectsv_(h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        #endregion

        #region TexCoord1dv
        public static void TexCoord1dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord1dv(IntPtr v)
        {
            TexCoord1dv_(v);
        }
        public static void TexCoord1dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord1fv
        public static void TexCoord1fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord1fv(IntPtr v)
        {
            TexCoord1fv_(v);
        }
        public static void TexCoord1fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord1iv
        public static void TexCoord1iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord1iv(IntPtr v)
        {
            TexCoord1iv_(v);
        }
        public static void TexCoord1iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord1sv
        public static void TexCoord1sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord1sv(IntPtr v)
        {
            TexCoord1sv_(v);
        }
        public static void TexCoord1sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord1sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord2dv
        public static void TexCoord2dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord2dv(IntPtr v)
        {
            TexCoord2dv_(v);
        }
        public static void TexCoord2dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord2fv
        public static void TexCoord2fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord2fv(IntPtr v)
        {
            TexCoord2fv_(v);
        }
        public static void TexCoord2fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord2iv
        public static void TexCoord2iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord2iv(IntPtr v)
        {
            TexCoord2iv_(v);
        }
        public static void TexCoord2iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord2sv
        public static void TexCoord2sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord2sv(IntPtr v)
        {
            TexCoord2sv_(v);
        }
        public static void TexCoord2sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord3dv
        public static void TexCoord3dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord3dv(IntPtr v)
        {
            TexCoord3dv_(v);
        }
        public static void TexCoord3dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord3fv
        public static void TexCoord3fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord3fv(IntPtr v)
        {
            TexCoord3fv_(v);
        }
        public static void TexCoord3fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord3iv
        public static void TexCoord3iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord3iv(IntPtr v)
        {
            TexCoord3iv_(v);
        }
        public static void TexCoord3iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord3sv
        public static void TexCoord3sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord3sv(IntPtr v)
        {
            TexCoord3sv_(v);
        }
        public static void TexCoord3sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord4dv
        public static void TexCoord4dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord4dv(IntPtr v)
        {
            TexCoord4dv_(v);
        }
        public static void TexCoord4dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord4fv
        public static void TexCoord4fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord4fv(IntPtr v)
        {
            TexCoord4fv_(v);
        }
        public static void TexCoord4fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord4iv
        public static void TexCoord4iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord4iv(IntPtr v)
        {
            TexCoord4iv_(v);
        }
        public static void TexCoord4iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexCoord4sv
        public static void TexCoord4sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoord4sv(IntPtr v)
        {
            TexCoord4sv_(v);
        }
        public static void TexCoord4sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                TexCoord4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex2dv
        public static void Vertex2dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex2dv(IntPtr v)
        {
            Vertex2dv_(v);
        }
        public static void Vertex2dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex2fv
        public static void Vertex2fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex2fv(IntPtr v)
        {
            Vertex2fv_(v);
        }
        public static void Vertex2fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex2iv
        public static void Vertex2iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex2iv(IntPtr v)
        {
            Vertex2iv_(v);
        }
        public static void Vertex2iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex2sv
        public static void Vertex2sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex2sv(IntPtr v)
        {
            Vertex2sv_(v);
        }
        public static void Vertex2sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex3dv
        public static void Vertex3dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex3dv(IntPtr v)
        {
            Vertex3dv_(v);
        }
        public static void Vertex3dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex3fv
        public static void Vertex3fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex3fv(IntPtr v)
        {
            Vertex3fv_(v);
        }
        public static void Vertex3fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex3iv
        public static void Vertex3iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex3iv(IntPtr v)
        {
            Vertex3iv_(v);
        }
        public static void Vertex3iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex3sv
        public static void Vertex3sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex3sv(IntPtr v)
        {
            Vertex3sv_(v);
        }
        public static void Vertex3sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex4dv
        public static void Vertex4dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex4dv(IntPtr v)
        {
            Vertex4dv_(v);
        }
        public static void Vertex4dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex4fv
        public static void Vertex4fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex4fv(IntPtr v)
        {
            Vertex4fv_(v);
        }
        public static void Vertex4fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex4iv
        public static void Vertex4iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex4iv(IntPtr v)
        {
            Vertex4iv_(v);
        }
        public static void Vertex4iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Vertex4sv
        public static void Vertex4sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Vertex4sv(IntPtr v)
        {
            Vertex4sv_(v);
        }
        public static void Vertex4sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                Vertex4sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region ClipPlane
        public static void ClipPlane(Enums.ClipPlaneName plane, object equation)
        {
            GCHandle h0 = GCHandle.Alloc(equation, GCHandleType.Pinned);
            try
            {
                ClipPlane_(plane, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ClipPlane(Enums.ClipPlaneName plane, IntPtr equation)
        {
            ClipPlane_(plane, equation);
        }
        public static void ClipPlane(Enums.ClipPlaneName plane, GLdouble[] equation)
        {
            GCHandle h0 = GCHandle.Alloc(equation, GCHandleType.Pinned);
            try
            {
                ClipPlane_(plane, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Fogfv
        public static void Fogfv(Enums.FogParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Fogfv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Fogfv(Enums.FogParameter pname, IntPtr parameters)
        {
            Fogfv_(pname, parameters);
        }
        public static void Fogfv(Enums.FogParameter pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Fogfv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Fogiv
        public static void Fogiv(Enums.FogParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Fogiv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Fogiv(Enums.FogParameter pname, IntPtr parameters)
        {
            Fogiv_(pname, parameters);
        }
        public static void Fogiv(Enums.FogParameter pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Fogiv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Lightfv
        public static void Lightfv(Enums.LightName light, Enums.LightParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Lightfv_(light, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Lightfv(Enums.LightName light, Enums.LightParameter pname, IntPtr parameters)
        {
            Lightfv_(light, pname, parameters);
        }
        public static void Lightfv(Enums.LightName light, Enums.LightParameter pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Lightfv_(light, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Lightiv
        public static void Lightiv(Enums.LightName light, Enums.LightParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Lightiv_(light, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Lightiv(Enums.LightName light, Enums.LightParameter pname, IntPtr parameters)
        {
            Lightiv_(light, pname, parameters);
        }
        public static void Lightiv(Enums.LightName light, Enums.LightParameter pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Lightiv_(light, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region LightModelfv
        public static void LightModelfv(Enums.LightModelParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                LightModelfv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void LightModelfv(Enums.LightModelParameter pname, IntPtr parameters)
        {
            LightModelfv_(pname, parameters);
        }
        public static void LightModelfv(Enums.LightModelParameter pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                LightModelfv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region LightModeliv
        public static void LightModeliv(Enums.LightModelParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                LightModeliv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void LightModeliv(Enums.LightModelParameter pname, IntPtr parameters)
        {
            LightModeliv_(pname, parameters);
        }
        public static void LightModeliv(Enums.LightModelParameter pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                LightModeliv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Materialfv
        public static void Materialfv(Enums.MaterialFace face, Enums.MaterialParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Materialfv_(face, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Materialfv(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters)
        {
            Materialfv_(face, pname, parameters);
        }
        public static void Materialfv(Enums.MaterialFace face, Enums.MaterialParameter pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Materialfv_(face, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Materialiv
        public static void Materialiv(Enums.MaterialFace face, Enums.MaterialParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Materialiv_(face, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Materialiv(Enums.MaterialFace face, Enums.MaterialParameter pname, IntPtr parameters)
        {
            Materialiv_(face, pname, parameters);
        }
        public static void Materialiv(Enums.MaterialFace face, Enums.MaterialParameter pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                Materialiv_(face, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region PolygonStipple
        public static void PolygonStipple(object mask)
        {
            GCHandle h0 = GCHandle.Alloc(mask, GCHandleType.Pinned);
            try
            {
                PolygonStipple_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void PolygonStipple(IntPtr mask)
        {
            PolygonStipple_(mask);
        }
        public static void PolygonStipple(GLubyte[] mask)
        {
            GCHandle h0 = GCHandle.Alloc(mask, GCHandleType.Pinned);
            try
            {
                PolygonStipple_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexParameterfv
        public static void TexParameterfv(Enums.TextureTarget target, Enums.TextureParameterName pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexParameterfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexParameterfv(Enums.TextureTarget target, Enums.TextureParameterName pname, IntPtr parameters)
        {
            TexParameterfv_(target, pname, parameters);
        }
        public static void TexParameterfv(Enums.TextureTarget target, Enums.TextureParameterName pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexParameterfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexParameteriv
        public static void TexParameteriv(Enums.TextureTarget target, Enums.TextureParameterName pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexParameteriv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexParameteriv(Enums.TextureTarget target, Enums.TextureParameterName pname, IntPtr parameters)
        {
            TexParameteriv_(target, pname, parameters);
        }
        public static void TexParameteriv(Enums.TextureTarget target, Enums.TextureParameterName pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexParameteriv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexEnvfv
        public static void TexEnvfv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexEnvfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexEnvfv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, IntPtr parameters)
        {
            TexEnvfv_(target, pname, parameters);
        }
        public static void TexEnvfv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexEnvfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexEnviv
        public static void TexEnviv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexEnviv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexEnviv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, IntPtr parameters)
        {
            TexEnviv_(target, pname, parameters);
        }
        public static void TexEnviv(Enums.TextureEnvTarget target, Enums.TextureEnvParameter pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexEnviv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexGendv
        public static void TexGendv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexGendv_(coord, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexGendv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters)
        {
            TexGendv_(coord, pname, parameters);
        }
        public static void TexGendv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLdouble[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexGendv_(coord, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexGenfv
        public static void TexGenfv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexGenfv_(coord, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexGenfv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters)
        {
            TexGenfv_(coord, pname, parameters);
        }
        public static void TexGenfv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexGenfv_(coord, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region TexGeniv
        public static void TexGeniv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexGeniv_(coord, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexGeniv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, IntPtr parameters)
        {
            TexGeniv_(coord, pname, parameters);
        }
        public static void TexGeniv(Enums.TextureCoordName coord, Enums.TextureGenParameter pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                TexGeniv_(coord, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Map1d
        public static void Map1d(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, object points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map1d_(target, u1, u2, stride, order, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Map1d(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, IntPtr points)
        {
            Map1d_(target, u1, u2, stride, order, points);
        }
        public static void Map1d(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble[] points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map1d_(target, u1, u2, stride, order, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Map1f
        public static void Map1f(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, object points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map1f_(target, u1, u2, stride, order, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Map1f(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, IntPtr points)
        {
            Map1f_(target, u1, u2, stride, order, points);
        }
        public static void Map1f(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat[] points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map1f_(target, u1, u2, stride, order, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Map2d
        public static void Map2d(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, object points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map2d_(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Map2d(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, IntPtr points)
        {
            Map2d_(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }
        public static void Map2d(Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble[] points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map2d_(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Map2f
        public static void Map2f(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, object points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map2f_(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Map2f(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, IntPtr points)
        {
            Map2f_(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }
        public static void Map2f(Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat[] points)
        {
            GCHandle h0 = GCHandle.Alloc(points, GCHandleType.Pinned);
            try
            {
                Map2f_(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region EvalCoord1dv
        public static void EvalCoord1dv(object u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord1dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void EvalCoord1dv(IntPtr u)
        {
            EvalCoord1dv_(u);
        }
        public static void EvalCoord1dv(GLdouble[] u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord1dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region EvalCoord1fv
        public static void EvalCoord1fv(object u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord1fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void EvalCoord1fv(IntPtr u)
        {
            EvalCoord1fv_(u);
        }
        public static void EvalCoord1fv(GLfloat[] u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord1fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region EvalCoord2dv
        public static void EvalCoord2dv(object u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void EvalCoord2dv(IntPtr u)
        {
            EvalCoord2dv_(u);
        }
        public static void EvalCoord2dv(GLdouble[] u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region EvalCoord2fv
        public static void EvalCoord2fv(object u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void EvalCoord2fv(IntPtr u)
        {
            EvalCoord2fv_(u);
        }
        public static void EvalCoord2fv(GLfloat[] u)
        {
            GCHandle h0 = GCHandle.Alloc(u, GCHandleType.Pinned);
            try
            {
                EvalCoord2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region PixelMapfv
        public static void PixelMapfv(Enums.PixelMap map, GLint mapsize, object values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                PixelMapfv_(map, mapsize, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void PixelMapfv(Enums.PixelMap map, GLint mapsize, IntPtr values)
        {
            PixelMapfv_(map, mapsize, values);
        }
        public static void PixelMapfv(Enums.PixelMap map, GLint mapsize, GLfloat[] values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                PixelMapfv_(map, mapsize, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region PixelMapuiv
        public static void PixelMapuiv(Enums.PixelMap map, GLint mapsize, object values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                PixelMapuiv_(map, mapsize, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void PixelMapuiv(Enums.PixelMap map, GLint mapsize, IntPtr values)
        {
            PixelMapuiv_(map, mapsize, values);
        }
        public static void PixelMapuiv(Enums.PixelMap map, GLint mapsize, GLuint[] values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                PixelMapuiv_(map, mapsize, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region PixelMapusv
        public static void PixelMapusv(Enums.PixelMap map, GLint mapsize, object values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                PixelMapusv_(map, mapsize, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void PixelMapusv(Enums.PixelMap map, GLint mapsize, IntPtr values)
        {
            PixelMapusv_(map, mapsize, values);
        }
        public static void PixelMapusv(Enums.PixelMap map, GLint mapsize, GLushort[] values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                PixelMapusv_(map, mapsize, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region ReadPixels
        public static void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, object pixels)
        {
            GCHandle h0 = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                ReadPixels_(x, y, width, height, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels)
        {
            ReadPixels_(x, y, width, height, format, type, pixels);
        }
        #endregion

        #region DrawPixels
        public static void DrawPixels(GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, object pixels)
        {
            GCHandle h0 = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                DrawPixels_(width, height, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void DrawPixels(GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr pixels)
        {
            DrawPixels_(width, height, format, type, pixels);
        }
        #endregion

        #region GetString
        public static string GetString(Enums.StringName name)
        {
             return Marshal.PtrToStringAnsi(GetString_(name));
        }
        #endregion

        #region LoadMatrixf
        public static void LoadMatrixf(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void LoadMatrixf(IntPtr m)
        {
            LoadMatrixf_(m);
        }
        public static void LoadMatrixf(GLfloat[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region LoadMatrixd
        public static void LoadMatrixd(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void LoadMatrixd(IntPtr m)
        {
            LoadMatrixd_(m);
        }
        public static void LoadMatrixd(GLdouble[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultMatrixf
        public static void MultMatrixf(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultMatrixf(IntPtr m)
        {
            MultMatrixf_(m);
        }
        public static void MultMatrixf(GLfloat[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultMatrixd
        public static void MultMatrixd(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultMatrixd(IntPtr m)
        {
            MultMatrixd_(m);
        }
        public static void MultMatrixd(GLdouble[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region ColorPointer
        public static void ColorPointer(GLint size, Enums.ColorPointerType type, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                ColorPointer_(size, type, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ColorPointer(GLint size, Enums.ColorPointerType type, GLsizei stride, IntPtr pointer)
        {
            ColorPointer_(size, type, stride, pointer);
        }
        #endregion

        #region DrawElements
        public static void DrawElements(Enums.BeginMode mode, GLsizei count, GLenum type, object indices)
        {
            GCHandle h0 = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                DrawElements_(mode, count, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void DrawElements(Enums.BeginMode mode, GLsizei count, GLenum type, IntPtr indices)
        {
            DrawElements_(mode, count, type, indices);
        }
        #endregion

        #region EdgeFlagPointer
        public static void EdgeFlagPointer(GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                EdgeFlagPointer_(stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void EdgeFlagPointer(GLsizei stride, IntPtr pointer)
        {
            EdgeFlagPointer_(stride, pointer);
        }
        #endregion

        #region IndexPointer
        public static void IndexPointer(Enums.IndexPointerType type, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                IndexPointer_(type, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void IndexPointer(Enums.IndexPointerType type, GLsizei stride, IntPtr pointer)
        {
            IndexPointer_(type, stride, pointer);
        }
        #endregion

        #region InterleavedArrays
        public static void InterleavedArrays(Enums.InterleavedArrayFormat format, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                InterleavedArrays_(format, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void InterleavedArrays(Enums.InterleavedArrayFormat format, GLsizei stride, IntPtr pointer)
        {
            InterleavedArrays_(format, stride, pointer);
        }
        #endregion

        #region NormalPointer
        public static void NormalPointer(Enums.NormalPointerType type, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                NormalPointer_(type, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void NormalPointer(Enums.NormalPointerType type, GLsizei stride, IntPtr pointer)
        {
            NormalPointer_(type, stride, pointer);
        }
        #endregion

        #region TexCoordPointer
        public static void TexCoordPointer(GLint size, Enums.TexCoordPointerType type, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                TexCoordPointer_(size, type, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void TexCoordPointer(GLint size, Enums.TexCoordPointerType type, GLsizei stride, IntPtr pointer)
        {
            TexCoordPointer_(size, type, stride, pointer);
        }
        #endregion

        #region VertexPointer
        public static void VertexPointer(GLint size, Enums.VertexPointerType type, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                VertexPointer_(size, type, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexPointer(GLint size, Enums.VertexPointerType type, GLsizei stride, IntPtr pointer)
        {
            VertexPointer_(size, type, stride, pointer);
        }
        #endregion

        #region AreTexturesResident
        public static GLboolean AreTexturesResident(GLsizei n, object textures, Enums.Boolean[] residences)
        {
            GCHandle h0 = GCHandle.Alloc(textures, GCHandleType.Pinned);
            try
            {
                return AreTexturesResident_(n, h0.AddrOfPinnedObject(), residences);
            }
            finally
            {
                h0.Free();
            }
        }
        public static GLboolean AreTexturesResident(GLsizei n, IntPtr textures, Enums.Boolean[] residences)
        {
            return AreTexturesResident_(n, textures, residences);
        }
        public static GLboolean AreTexturesResident(GLsizei n, GLuint[] textures, Enums.Boolean[] residences)
        {
            GCHandle h0 = GCHandle.Alloc(textures, GCHandleType.Pinned);
            try
            {
                return AreTexturesResident_(n, h0.AddrOfPinnedObject(), residences);
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region DeleteTextures
        public static void DeleteTextures(GLsizei n, object textures)
        {
            GCHandle h0 = GCHandle.Alloc(textures, GCHandleType.Pinned);
            try
            {
                DeleteTextures_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void DeleteTextures(GLsizei n, IntPtr textures)
        {
            DeleteTextures_(n, textures);
        }
        public static void DeleteTextures(GLsizei n, GLuint[] textures)
        {
            GCHandle h0 = GCHandle.Alloc(textures, GCHandleType.Pinned);
            try
            {
                DeleteTextures_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region PrioritizeTextures
        public static void PrioritizeTextures(GLsizei n, object textures, object priorities)
        {
            GCHandle h0 = GCHandle.Alloc(textures, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(priorities, GCHandleType.Pinned);
            try
            {
                PrioritizeTextures_(n, h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        public static void PrioritizeTextures(GLsizei n, IntPtr textures, IntPtr priorities)
        {
            PrioritizeTextures_(n, textures, priorities);
        }
        public static void PrioritizeTextures(GLsizei n, GLuint[] textures, GLclampf[] priorities)
        {
            GCHandle h0 = GCHandle.Alloc(textures, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(priorities, GCHandleType.Pinned);
            try
            {
                PrioritizeTextures_(n, h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        #endregion

        #region Indexubv
        public static void Indexubv(object c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Indexubv(IntPtr c)
        {
            Indexubv_(c);
        }
        public static void Indexubv(GLubyte[] c)
        {
            GCHandle h0 = GCHandle.Alloc(c, GCHandleType.Pinned);
            try
            {
                Indexubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region DrawRangeElements
        public static void DrawRangeElements(Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GLenum type, object indices)
        {
            GCHandle h0 = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                DrawRangeElements_(mode, start, end, count, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void DrawRangeElements(Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GLenum type, IntPtr indices)
        {
            DrawRangeElements_(mode, start, end, count, type, indices);
        }
        #endregion

        #region ColorTable
        public static void ColorTable(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, object table)
        {
            GCHandle h0 = GCHandle.Alloc(table, GCHandleType.Pinned);
            try
            {
                ColorTable_(target, internalformat, width, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ColorTable(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr table)
        {
            ColorTable_(target, internalformat, width, format, type, table);
        }
        #endregion

        #region ColorTableParameterfv
        public static void ColorTableParameterfv(GLenum target, GLenum pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ColorTableParameterfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ColorTableParameterfv(GLenum target, GLenum pname, IntPtr parameters)
        {
            ColorTableParameterfv_(target, pname, parameters);
        }
        public static void ColorTableParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ColorTableParameterfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region ColorTableParameteriv
        public static void ColorTableParameteriv(GLenum target, GLenum pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ColorTableParameteriv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ColorTableParameteriv(GLenum target, GLenum pname, IntPtr parameters)
        {
            ColorTableParameteriv_(target, pname, parameters);
        }
        public static void ColorTableParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ColorTableParameteriv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region GetColorTable
        public static void GetColorTable(GLenum target, Enums.PixelFormat format, Enums.PixelType type, object table)
        {
            GCHandle h0 = GCHandle.Alloc(table, GCHandleType.Pinned);
            try
            {
                GetColorTable_(target, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void GetColorTable(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr table)
        {
            GetColorTable_(target, format, type, table);
        }
        #endregion

        #region ColorSubTable
        public static void ColorSubTable(GLenum target, GLsizei start, GLsizei count, Enums.PixelFormat format, Enums.PixelType type, object data)
        {
            GCHandle h0 = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                ColorSubTable_(target, start, count, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ColorSubTable(GLenum target, GLsizei start, GLsizei count, Enums.PixelFormat format, Enums.PixelType type, IntPtr data)
        {
            ColorSubTable_(target, start, count, format, type, data);
        }
        #endregion

        #region ConvolutionFilter1D
        public static void ConvolutionFilter1D(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, object image)
        {
            GCHandle h0 = GCHandle.Alloc(image, GCHandleType.Pinned);
            try
            {
                ConvolutionFilter1D_(target, internalformat, width, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ConvolutionFilter1D(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, Enums.PixelFormat format, Enums.PixelType type, IntPtr image)
        {
            ConvolutionFilter1D_(target, internalformat, width, format, type, image);
        }
        #endregion

        #region ConvolutionFilter2D
        public static void ConvolutionFilter2D(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, object image)
        {
            GCHandle h0 = GCHandle.Alloc(image, GCHandleType.Pinned);
            try
            {
                ConvolutionFilter2D_(target, internalformat, width, height, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ConvolutionFilter2D(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr image)
        {
            ConvolutionFilter2D_(target, internalformat, width, height, format, type, image);
        }
        #endregion

        #region ConvolutionParameterfv
        public static void ConvolutionParameterfv(GLenum target, GLenum pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ConvolutionParameterfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ConvolutionParameterfv(GLenum target, GLenum pname, IntPtr parameters)
        {
            ConvolutionParameterfv_(target, pname, parameters);
        }
        public static void ConvolutionParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ConvolutionParameterfv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region ConvolutionParameteriv
        public static void ConvolutionParameteriv(GLenum target, GLenum pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ConvolutionParameteriv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ConvolutionParameteriv(GLenum target, GLenum pname, IntPtr parameters)
        {
            ConvolutionParameteriv_(target, pname, parameters);
        }
        public static void ConvolutionParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                ConvolutionParameteriv_(target, pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region GetConvolutionFilter
        public static void GetConvolutionFilter(GLenum target, Enums.PixelFormat format, Enums.PixelType type, object image)
        {
            GCHandle h0 = GCHandle.Alloc(image, GCHandleType.Pinned);
            try
            {
                GetConvolutionFilter_(target, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void GetConvolutionFilter(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr image)
        {
            GetConvolutionFilter_(target, format, type, image);
        }
        #endregion

        #region GetSeparableFilter
        public static void GetSeparableFilter(GLenum target, Enums.PixelFormat format, Enums.PixelType type, object row, object column, object span)
        {
            GCHandle h0 = GCHandle.Alloc(row, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(column, GCHandleType.Pinned);
            GCHandle h2 = GCHandle.Alloc(span, GCHandleType.Pinned);
            try
            {
                GetSeparableFilter_(target, format, type, h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject(), h2.AddrOfPinnedObject());
            }
            finally
            {
                h2.Free();
                h1.Free();
                h0.Free();
            }
        }
        public static void GetSeparableFilter(GLenum target, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column, IntPtr span)
        {
            GetSeparableFilter_(target, format, type, row, column, span);
        }
        #endregion

        #region SeparableFilter2D
        public static void SeparableFilter2D(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, object row, object column)
        {
            GCHandle h0 = GCHandle.Alloc(row, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(column, GCHandleType.Pinned);
            try
            {
                SeparableFilter2D_(target, internalformat, width, height, format, type, h0.AddrOfPinnedObject(), h1.AddrOfPinnedObject());
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        public static void SeparableFilter2D(GLenum target, Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, Enums.PixelFormat format, Enums.PixelType type, IntPtr row, IntPtr column)
        {
            SeparableFilter2D_(target, internalformat, width, height, format, type, row, column);
        }
        #endregion

        #region GetHistogram
        public static void GetHistogram(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, object values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                GetHistogram_(target, reset, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void GetHistogram(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values)
        {
            GetHistogram_(target, reset, format, type, values);
        }
        #endregion

        #region GetMinmax
        public static void GetMinmax(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, object values)
        {
            GCHandle h0 = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                GetMinmax_(target, reset, format, type, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void GetMinmax(GLenum target, Enums.Boolean reset, Enums.PixelFormat format, Enums.PixelType type, IntPtr values)
        {
            GetMinmax_(target, reset, format, type, values);
        }
        #endregion

        #region MultiTexCoord1dv
        public static void MultiTexCoord1dv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord1dv(GLenum target, IntPtr v)
        {
            MultiTexCoord1dv_(target, v);
        }
        public static void MultiTexCoord1dv(GLenum target, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord1fv
        public static void MultiTexCoord1fv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord1fv(GLenum target, IntPtr v)
        {
            MultiTexCoord1fv_(target, v);
        }
        public static void MultiTexCoord1fv(GLenum target, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord1iv
        public static void MultiTexCoord1iv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord1iv(GLenum target, IntPtr v)
        {
            MultiTexCoord1iv_(target, v);
        }
        public static void MultiTexCoord1iv(GLenum target, GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord1sv
        public static void MultiTexCoord1sv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord1sv(GLenum target, IntPtr v)
        {
            MultiTexCoord1sv_(target, v);
        }
        public static void MultiTexCoord1sv(GLenum target, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord1sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord2dv
        public static void MultiTexCoord2dv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord2dv(GLenum target, IntPtr v)
        {
            MultiTexCoord2dv_(target, v);
        }
        public static void MultiTexCoord2dv(GLenum target, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord2fv
        public static void MultiTexCoord2fv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord2fv(GLenum target, IntPtr v)
        {
            MultiTexCoord2fv_(target, v);
        }
        public static void MultiTexCoord2fv(GLenum target, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord2iv
        public static void MultiTexCoord2iv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord2iv(GLenum target, IntPtr v)
        {
            MultiTexCoord2iv_(target, v);
        }
        public static void MultiTexCoord2iv(GLenum target, GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord2sv
        public static void MultiTexCoord2sv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord2sv(GLenum target, IntPtr v)
        {
            MultiTexCoord2sv_(target, v);
        }
        public static void MultiTexCoord2sv(GLenum target, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord2sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord3dv
        public static void MultiTexCoord3dv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord3dv(GLenum target, IntPtr v)
        {
            MultiTexCoord3dv_(target, v);
        }
        public static void MultiTexCoord3dv(GLenum target, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord3fv
        public static void MultiTexCoord3fv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord3fv(GLenum target, IntPtr v)
        {
            MultiTexCoord3fv_(target, v);
        }
        public static void MultiTexCoord3fv(GLenum target, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord3iv
        public static void MultiTexCoord3iv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord3iv(GLenum target, IntPtr v)
        {
            MultiTexCoord3iv_(target, v);
        }
        public static void MultiTexCoord3iv(GLenum target, GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord3sv
        public static void MultiTexCoord3sv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord3sv(GLenum target, IntPtr v)
        {
            MultiTexCoord3sv_(target, v);
        }
        public static void MultiTexCoord3sv(GLenum target, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord3sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord4dv
        public static void MultiTexCoord4dv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord4dv(GLenum target, IntPtr v)
        {
            MultiTexCoord4dv_(target, v);
        }
        public static void MultiTexCoord4dv(GLenum target, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4dv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord4fv
        public static void MultiTexCoord4fv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord4fv(GLenum target, IntPtr v)
        {
            MultiTexCoord4fv_(target, v);
        }
        public static void MultiTexCoord4fv(GLenum target, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4fv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord4iv
        public static void MultiTexCoord4iv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord4iv(GLenum target, IntPtr v)
        {
            MultiTexCoord4iv_(target, v);
        }
        public static void MultiTexCoord4iv(GLenum target, GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4iv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultiTexCoord4sv
        public static void MultiTexCoord4sv(GLenum target, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultiTexCoord4sv(GLenum target, IntPtr v)
        {
            MultiTexCoord4sv_(target, v);
        }
        public static void MultiTexCoord4sv(GLenum target, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                MultiTexCoord4sv_(target, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region LoadTransposeMatrixf
        public static void LoadTransposeMatrixf(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadTransposeMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void LoadTransposeMatrixf(IntPtr m)
        {
            LoadTransposeMatrixf_(m);
        }
        public static void LoadTransposeMatrixf(GLfloat[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadTransposeMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region LoadTransposeMatrixd
        public static void LoadTransposeMatrixd(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadTransposeMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void LoadTransposeMatrixd(IntPtr m)
        {
            LoadTransposeMatrixd_(m);
        }
        public static void LoadTransposeMatrixd(GLdouble[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                LoadTransposeMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultTransposeMatrixf
        public static void MultTransposeMatrixf(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultTransposeMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultTransposeMatrixf(IntPtr m)
        {
            MultTransposeMatrixf_(m);
        }
        public static void MultTransposeMatrixf(GLfloat[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultTransposeMatrixf_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region MultTransposeMatrixd
        public static void MultTransposeMatrixd(object m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultTransposeMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void MultTransposeMatrixd(IntPtr m)
        {
            MultTransposeMatrixd_(m);
        }
        public static void MultTransposeMatrixd(GLdouble[] m)
        {
            GCHandle h0 = GCHandle.Alloc(m, GCHandleType.Pinned);
            try
            {
                MultTransposeMatrixd_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region FogCoordfv
        public static void FogCoordfv(object coord)
        {
            GCHandle h0 = GCHandle.Alloc(coord, GCHandleType.Pinned);
            try
            {
                FogCoordfv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void FogCoordfv(IntPtr coord)
        {
            FogCoordfv_(coord);
        }
        public static void FogCoordfv(GLfloat[] coord)
        {
            GCHandle h0 = GCHandle.Alloc(coord, GCHandleType.Pinned);
            try
            {
                FogCoordfv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region FogCoorddv
        public static void FogCoorddv(object coord)
        {
            GCHandle h0 = GCHandle.Alloc(coord, GCHandleType.Pinned);
            try
            {
                FogCoorddv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void FogCoorddv(IntPtr coord)
        {
            FogCoorddv_(coord);
        }
        public static void FogCoorddv(GLdouble[] coord)
        {
            GCHandle h0 = GCHandle.Alloc(coord, GCHandleType.Pinned);
            try
            {
                FogCoorddv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region FogCoordPointer
        public static void FogCoordPointer(GLenum type, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                FogCoordPointer_(type, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void FogCoordPointer(GLenum type, GLsizei stride, IntPtr pointer)
        {
            FogCoordPointer_(type, stride, pointer);
        }
        #endregion

        #region MultiDrawElements
        public static void MultiDrawElements(Enums.BeginMode mode, object count, GLenum type, object indices, GLsizei primcount)
        {
            GCHandle h0 = GCHandle.Alloc(count, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                MultiDrawElements_(mode, h0.AddrOfPinnedObject(), type, h1.AddrOfPinnedObject(), primcount);
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        public static void MultiDrawElements(Enums.BeginMode mode, IntPtr count, GLenum type, IntPtr indices, GLsizei primcount)
        {
            MultiDrawElements_(mode, count, type, indices, primcount);
        }
        public static void MultiDrawElements(Enums.BeginMode mode, GLsizei[] count, GLenum type, IntPtr[] indices, GLsizei primcount)
        {
            GCHandle h0 = GCHandle.Alloc(count, GCHandleType.Pinned);
            GCHandle h1 = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                MultiDrawElements_(mode, h0.AddrOfPinnedObject(), type, h1.AddrOfPinnedObject(), primcount);
            }
            finally
            {
                h1.Free();
                h0.Free();
            }
        }
        #endregion

        #region PointParameterfv
        public static void PointParameterfv(GLenum pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                PointParameterfv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void PointParameterfv(GLenum pname, IntPtr parameters)
        {
            PointParameterfv_(pname, parameters);
        }
        public static void PointParameterfv(GLenum pname, GLfloat[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                PointParameterfv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region PointParameteriv
        public static void PointParameteriv(GLenum pname, object parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                PointParameteriv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void PointParameteriv(GLenum pname, IntPtr parameters)
        {
            PointParameteriv_(pname, parameters);
        }
        public static void PointParameteriv(GLenum pname, GLint[] parameters)
        {
            GCHandle h0 = GCHandle.Alloc(parameters, GCHandleType.Pinned);
            try
            {
                PointParameteriv_(pname, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3bv
        public static void SecondaryColor3bv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3bv(IntPtr v)
        {
            SecondaryColor3bv_(v);
        }
        public static void SecondaryColor3bv(GLbyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3bv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3dv
        public static void SecondaryColor3dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3dv(IntPtr v)
        {
            SecondaryColor3dv_(v);
        }
        public static void SecondaryColor3dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3fv
        public static void SecondaryColor3fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3fv(IntPtr v)
        {
            SecondaryColor3fv_(v);
        }
        public static void SecondaryColor3fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3iv
        public static void SecondaryColor3iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3iv(IntPtr v)
        {
            SecondaryColor3iv_(v);
        }
        public static void SecondaryColor3iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3sv
        public static void SecondaryColor3sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3sv(IntPtr v)
        {
            SecondaryColor3sv_(v);
        }
        public static void SecondaryColor3sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3ubv
        public static void SecondaryColor3ubv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3ubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3ubv(IntPtr v)
        {
            SecondaryColor3ubv_(v);
        }
        public static void SecondaryColor3ubv(GLubyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3ubv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3uiv
        public static void SecondaryColor3uiv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3uiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3uiv(IntPtr v)
        {
            SecondaryColor3uiv_(v);
        }
        public static void SecondaryColor3uiv(GLuint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3uiv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColor3usv
        public static void SecondaryColor3usv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3usv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColor3usv(IntPtr v)
        {
            SecondaryColor3usv_(v);
        }
        public static void SecondaryColor3usv(GLushort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                SecondaryColor3usv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region SecondaryColorPointer
        public static void SecondaryColorPointer(GLint size, Enums.ColorPointerType type, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                SecondaryColorPointer_(size, type, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void SecondaryColorPointer(GLint size, Enums.ColorPointerType type, GLsizei stride, IntPtr pointer)
        {
            SecondaryColorPointer_(size, type, stride, pointer);
        }
        #endregion

        #region WindowPos2dv
        public static void WindowPos2dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos2dv(IntPtr v)
        {
            WindowPos2dv_(v);
        }
        public static void WindowPos2dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region WindowPos2fv
        public static void WindowPos2fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos2fv(IntPtr v)
        {
            WindowPos2fv_(v);
        }
        public static void WindowPos2fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region WindowPos2iv
        public static void WindowPos2iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos2iv(IntPtr v)
        {
            WindowPos2iv_(v);
        }
        public static void WindowPos2iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region WindowPos2sv
        public static void WindowPos2sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos2sv(IntPtr v)
        {
            WindowPos2sv_(v);
        }
        public static void WindowPos2sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos2sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region WindowPos3dv
        public static void WindowPos3dv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos3dv(IntPtr v)
        {
            WindowPos3dv_(v);
        }
        public static void WindowPos3dv(GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3dv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region WindowPos3fv
        public static void WindowPos3fv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos3fv(IntPtr v)
        {
            WindowPos3fv_(v);
        }
        public static void WindowPos3fv(GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3fv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region WindowPos3iv
        public static void WindowPos3iv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos3iv(IntPtr v)
        {
            WindowPos3iv_(v);
        }
        public static void WindowPos3iv(GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3iv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region WindowPos3sv
        public static void WindowPos3sv(object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void WindowPos3sv(IntPtr v)
        {
            WindowPos3sv_(v);
        }
        public static void WindowPos3sv(GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                WindowPos3sv_(h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region DeleteQueries
        public static void DeleteQueries(GLsizei n, object ids)
        {
            GCHandle h0 = GCHandle.Alloc(ids, GCHandleType.Pinned);
            try
            {
                DeleteQueries_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void DeleteQueries(GLsizei n, IntPtr ids)
        {
            DeleteQueries_(n, ids);
        }
        public static void DeleteQueries(GLsizei n, GLuint[] ids)
        {
            GCHandle h0 = GCHandle.Alloc(ids, GCHandleType.Pinned);
            try
            {
                DeleteQueries_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region DeleteBuffers
        public static void DeleteBuffers(GLsizei n, object buffers)
        {
            GCHandle h0 = GCHandle.Alloc(buffers, GCHandleType.Pinned);
            try
            {
                DeleteBuffers_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void DeleteBuffers(GLsizei n, IntPtr buffers)
        {
            DeleteBuffers_(n, buffers);
        }
        public static void DeleteBuffers(GLsizei n, GLuint[] buffers)
        {
            GCHandle h0 = GCHandle.Alloc(buffers, GCHandleType.Pinned);
            try
            {
                DeleteBuffers_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region BufferData
        public static void BufferData(GLenum target, GLsizeiptr size, object data, GLenum usage)
        {
            GCHandle h0 = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                BufferData_(target, size, h0.AddrOfPinnedObject(), usage);
            }
            finally
            {
                h0.Free();
            }
        }
        public static void BufferData(GLenum target, GLsizeiptr size, IntPtr data, GLenum usage)
        {
            BufferData_(target, size, data, usage);
        }
        #endregion

        #region BufferSubData
        public static void BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, object data)
        {
            GCHandle h0 = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                BufferSubData_(target, offset, size, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            BufferSubData_(target, offset, size, data);
        }
        #endregion

        #region GetBufferSubData
        public static void GetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, object data)
        {
            GCHandle h0 = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                GetBufferSubData_(target, offset, size, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void GetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            GetBufferSubData_(target, offset, size, data);
        }
        #endregion

        #region DrawBuffers
        public static void DrawBuffers(GLsizei n, object bufs)
        {
            GCHandle h0 = GCHandle.Alloc(bufs, GCHandleType.Pinned);
            try
            {
                DrawBuffers_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void DrawBuffers(GLsizei n, IntPtr bufs)
        {
            DrawBuffers_(n, bufs);
        }
        public static void DrawBuffers(GLsizei n, GLenum[] bufs)
        {
            GCHandle h0 = GCHandle.Alloc(bufs, GCHandleType.Pinned);
            try
            {
                DrawBuffers_(n, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region BindAttribLocation
        public static void BindAttribLocation(GLuint program, GLuint index, object name)
        {
            GCHandle h0 = GCHandle.Alloc(name, GCHandleType.Pinned);
            try
            {
                BindAttribLocation_(program, index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void BindAttribLocation(GLuint program, GLuint index, IntPtr name)
        {
            BindAttribLocation_(program, index, name);
        }
        public static void BindAttribLocation(GLuint program, GLuint index, GLchar[] name)
        {
            GCHandle h0 = GCHandle.Alloc(name, GCHandleType.Pinned);
            try
            {
                BindAttribLocation_(program, index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region GetAttribLocation
        public static GLint GetAttribLocation(GLuint program, object name)
        {
            GCHandle h0 = GCHandle.Alloc(name, GCHandleType.Pinned);
            try
            {
                return GetAttribLocation_(program, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static GLint GetAttribLocation(GLuint program, IntPtr name)
        {
            return GetAttribLocation_(program, name);
        }
        public static GLint GetAttribLocation(GLuint program, GLchar[] name)
        {
            GCHandle h0 = GCHandle.Alloc(name, GCHandleType.Pinned);
            try
            {
                return GetAttribLocation_(program, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region GetUniformLocation
        public static GLint GetUniformLocation(GLuint program, object name)
        {
            GCHandle h0 = GCHandle.Alloc(name, GCHandleType.Pinned);
            try
            {
                return GetUniformLocation_(program, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static GLint GetUniformLocation(GLuint program, IntPtr name)
        {
            return GetUniformLocation_(program, name);
        }
        public static GLint GetUniformLocation(GLuint program, GLchar[] name)
        {
            GCHandle h0 = GCHandle.Alloc(name, GCHandleType.Pinned);
            try
            {
                return GetUniformLocation_(program, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region ShaderSource
        public static void ShaderSource(GLuint shader, GLsizei count, string[] @string, object length)
        {
            GCHandle h0 = GCHandle.Alloc(length, GCHandleType.Pinned);
            try
            {
                ShaderSource_(shader, count, @string, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void ShaderSource(GLuint shader, GLsizei count, string[] @string, IntPtr length)
        {
            ShaderSource_(shader, count, @string, length);
        }
        public static void ShaderSource(GLuint shader, GLsizei count, string[] @string, GLint[] length)
        {
            GCHandle h0 = GCHandle.Alloc(length, GCHandleType.Pinned);
            try
            {
                ShaderSource_(shader, count, @string, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform1fv
        public static void Uniform1fv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform1fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform1fv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform1fv_(location, count, value);
        }
        public static void Uniform1fv(GLint location, GLsizei count, GLfloat[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform1fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform2fv
        public static void Uniform2fv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform2fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform2fv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform2fv_(location, count, value);
        }
        public static void Uniform2fv(GLint location, GLsizei count, GLfloat[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform2fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform3fv
        public static void Uniform3fv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform3fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform3fv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform3fv_(location, count, value);
        }
        public static void Uniform3fv(GLint location, GLsizei count, GLfloat[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform3fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform4fv
        public static void Uniform4fv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform4fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform4fv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform4fv_(location, count, value);
        }
        public static void Uniform4fv(GLint location, GLsizei count, GLfloat[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform4fv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform1iv
        public static void Uniform1iv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform1iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform1iv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform1iv_(location, count, value);
        }
        public static void Uniform1iv(GLint location, GLsizei count, GLint[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform1iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform2iv
        public static void Uniform2iv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform2iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform2iv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform2iv_(location, count, value);
        }
        public static void Uniform2iv(GLint location, GLsizei count, GLint[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform2iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform3iv
        public static void Uniform3iv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform3iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform3iv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform3iv_(location, count, value);
        }
        public static void Uniform3iv(GLint location, GLsizei count, GLint[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform3iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region Uniform4iv
        public static void Uniform4iv(GLint location, GLsizei count, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform4iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void Uniform4iv(GLint location, GLsizei count, IntPtr value)
        {
            Uniform4iv_(location, count, value);
        }
        public static void Uniform4iv(GLint location, GLsizei count, GLint[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                Uniform4iv_(location, count, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region UniformMatrix2fv
        public static void UniformMatrix2fv(GLint location, GLsizei count, Enums.Boolean transpose, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                UniformMatrix2fv_(location, count, transpose, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void UniformMatrix2fv(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value)
        {
            UniformMatrix2fv_(location, count, transpose, value);
        }
        public static void UniformMatrix2fv(GLint location, GLsizei count, Enums.Boolean transpose, GLfloat[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                UniformMatrix2fv_(location, count, transpose, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region UniformMatrix3fv
        public static void UniformMatrix3fv(GLint location, GLsizei count, Enums.Boolean transpose, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                UniformMatrix3fv_(location, count, transpose, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void UniformMatrix3fv(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value)
        {
            UniformMatrix3fv_(location, count, transpose, value);
        }
        public static void UniformMatrix3fv(GLint location, GLsizei count, Enums.Boolean transpose, GLfloat[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                UniformMatrix3fv_(location, count, transpose, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region UniformMatrix4fv
        public static void UniformMatrix4fv(GLint location, GLsizei count, Enums.Boolean transpose, object value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                UniformMatrix4fv_(location, count, transpose, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void UniformMatrix4fv(GLint location, GLsizei count, Enums.Boolean transpose, IntPtr value)
        {
            UniformMatrix4fv_(location, count, transpose, value);
        }
        public static void UniformMatrix4fv(GLint location, GLsizei count, Enums.Boolean transpose, GLfloat[] value)
        {
            GCHandle h0 = GCHandle.Alloc(value, GCHandleType.Pinned);
            try
            {
                UniformMatrix4fv_(location, count, transpose, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib1dv
        public static void VertexAttrib1dv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib1dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib1dv(GLuint index, IntPtr v)
        {
            VertexAttrib1dv_(index, v);
        }
        public static void VertexAttrib1dv(GLuint index, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib1dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib1fv
        public static void VertexAttrib1fv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib1fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib1fv(GLuint index, IntPtr v)
        {
            VertexAttrib1fv_(index, v);
        }
        public static void VertexAttrib1fv(GLuint index, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib1fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib1sv
        public static void VertexAttrib1sv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib1sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib1sv(GLuint index, IntPtr v)
        {
            VertexAttrib1sv_(index, v);
        }
        public static void VertexAttrib1sv(GLuint index, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib1sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib2dv
        public static void VertexAttrib2dv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib2dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib2dv(GLuint index, IntPtr v)
        {
            VertexAttrib2dv_(index, v);
        }
        public static void VertexAttrib2dv(GLuint index, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib2dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib2fv
        public static void VertexAttrib2fv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib2fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib2fv(GLuint index, IntPtr v)
        {
            VertexAttrib2fv_(index, v);
        }
        public static void VertexAttrib2fv(GLuint index, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib2fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib2sv
        public static void VertexAttrib2sv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib2sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib2sv(GLuint index, IntPtr v)
        {
            VertexAttrib2sv_(index, v);
        }
        public static void VertexAttrib2sv(GLuint index, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib2sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib3dv
        public static void VertexAttrib3dv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib3dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib3dv(GLuint index, IntPtr v)
        {
            VertexAttrib3dv_(index, v);
        }
        public static void VertexAttrib3dv(GLuint index, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib3dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib3fv
        public static void VertexAttrib3fv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib3fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib3fv(GLuint index, IntPtr v)
        {
            VertexAttrib3fv_(index, v);
        }
        public static void VertexAttrib3fv(GLuint index, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib3fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib3sv
        public static void VertexAttrib3sv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib3sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib3sv(GLuint index, IntPtr v)
        {
            VertexAttrib3sv_(index, v);
        }
        public static void VertexAttrib3sv(GLuint index, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib3sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4Nbv
        public static void VertexAttrib4Nbv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nbv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4Nbv(GLuint index, IntPtr v)
        {
            VertexAttrib4Nbv_(index, v);
        }
        public static void VertexAttrib4Nbv(GLuint index, GLbyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nbv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4Niv
        public static void VertexAttrib4Niv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Niv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4Niv(GLuint index, IntPtr v)
        {
            VertexAttrib4Niv_(index, v);
        }
        public static void VertexAttrib4Niv(GLuint index, GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Niv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4Nsv
        public static void VertexAttrib4Nsv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nsv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4Nsv(GLuint index, IntPtr v)
        {
            VertexAttrib4Nsv_(index, v);
        }
        public static void VertexAttrib4Nsv(GLuint index, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nsv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4Nubv
        public static void VertexAttrib4Nubv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nubv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4Nubv(GLuint index, IntPtr v)
        {
            VertexAttrib4Nubv_(index, v);
        }
        public static void VertexAttrib4Nubv(GLuint index, GLubyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nubv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4Nuiv
        public static void VertexAttrib4Nuiv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nuiv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4Nuiv(GLuint index, IntPtr v)
        {
            VertexAttrib4Nuiv_(index, v);
        }
        public static void VertexAttrib4Nuiv(GLuint index, GLuint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nuiv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4Nusv
        public static void VertexAttrib4Nusv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nusv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4Nusv(GLuint index, IntPtr v)
        {
            VertexAttrib4Nusv_(index, v);
        }
        public static void VertexAttrib4Nusv(GLuint index, GLushort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4Nusv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4bv
        public static void VertexAttrib4bv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4bv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4bv(GLuint index, IntPtr v)
        {
            VertexAttrib4bv_(index, v);
        }
        public static void VertexAttrib4bv(GLuint index, GLbyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4bv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4dv
        public static void VertexAttrib4dv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4dv(GLuint index, IntPtr v)
        {
            VertexAttrib4dv_(index, v);
        }
        public static void VertexAttrib4dv(GLuint index, GLdouble[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4dv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4fv
        public static void VertexAttrib4fv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4fv(GLuint index, IntPtr v)
        {
            VertexAttrib4fv_(index, v);
        }
        public static void VertexAttrib4fv(GLuint index, GLfloat[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4fv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4iv
        public static void VertexAttrib4iv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4iv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4iv(GLuint index, IntPtr v)
        {
            VertexAttrib4iv_(index, v);
        }
        public static void VertexAttrib4iv(GLuint index, GLint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4iv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4sv
        public static void VertexAttrib4sv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4sv(GLuint index, IntPtr v)
        {
            VertexAttrib4sv_(index, v);
        }
        public static void VertexAttrib4sv(GLuint index, GLshort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4sv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4ubv
        public static void VertexAttrib4ubv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4ubv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4ubv(GLuint index, IntPtr v)
        {
            VertexAttrib4ubv_(index, v);
        }
        public static void VertexAttrib4ubv(GLuint index, GLubyte[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4ubv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4uiv
        public static void VertexAttrib4uiv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4uiv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4uiv(GLuint index, IntPtr v)
        {
            VertexAttrib4uiv_(index, v);
        }
        public static void VertexAttrib4uiv(GLuint index, GLuint[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4uiv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttrib4usv
        public static void VertexAttrib4usv(GLuint index, object v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4usv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttrib4usv(GLuint index, IntPtr v)
        {
            VertexAttrib4usv_(index, v);
        }
        public static void VertexAttrib4usv(GLuint index, GLushort[] v)
        {
            GCHandle h0 = GCHandle.Alloc(v, GCHandleType.Pinned);
            try
            {
                VertexAttrib4usv_(index, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        #endregion

        #region VertexAttribPointer
        public static void VertexAttribPointer(GLuint index, GLint size, GLenum type, Enums.Boolean normalized, GLsizei stride, object pointer)
        {
            GCHandle h0 = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                VertexAttribPointer_(index, size, type, normalized, stride, h0.AddrOfPinnedObject());
            }
            finally
            {
                h0.Free();
            }
        }
        public static void VertexAttribPointer(GLuint index, GLint size, GLenum type, Enums.Boolean normalized, GLsizei stride, IntPtr pointer)
        {
            VertexAttribPointer_(index, size, type, normalized, stride, pointer);
        }
        #endregion

    #endregion

    }
}

