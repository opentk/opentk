//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.Disable and GL.Enable, as well as 3 other functions.
    /// </summary>
    public enum EnableCap
    {
        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = 0x0b20,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = 0x0b41,

        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = 0x0b44,

        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = 0x0b71,

        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = 0x0b90,

        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = 0x0bd0,

        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = 0x0be2,

        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = 0x0bf2,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = 0x0c11,

        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = 0x0de0,

        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = 0x2a01,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = 0x2a02,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE0 = 0x3000
        /// </summary>
        ClipDistance0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE1 = 0x3001
        /// </summary>
        ClipDistance1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE2 = 0x3002
        /// </summary>
        ClipDistance2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE3 = 0x3003
        /// </summary>
        ClipDistance3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE4 = 0x3004
        /// </summary>
        ClipDistance4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE5 = 0x3005
        /// </summary>
        ClipDistance5 = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE6 = 0x3006
        /// </summary>
        ClipDistance6 = 0x3006,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE7 = 0x3007
        /// </summary>
        ClipDistance7 = 0x3007,

        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = 0x8011,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = 0x8011,

        /// <summary>
        /// Original was GL_SEPARABLE_2D = 0x8012
        /// </summary>
        Separable2D = 0x8012,

        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = 0x8012,

        /// <summary>
        /// Original was GL_HISTOGRAM = 0x8024
        /// </summary>
        Histogram = 0x8024,

        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = 0x8024,

        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = 0x802e,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = 0x8037,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL = 0x803A
        /// </summary>
        RescaleNormal = 0x803a,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = 0x803a,

        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = 0x806f,

        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = 0x8094,

        /// <summary>
        /// Original was GL_MULTISAMPLE = 0x809D
        /// </summary>
        Multisample = 0x809d,

        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        /// </summary>
        SampleAlphaToOne = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = 0x80a0,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = 0x80a0,

        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = 0x80bc,

        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = 0x80d0,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = 0x80d0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = 0x80d1,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = 0x80d1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = 0x80d2,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = 0x80d2,

        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = 0x8134,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = 0x8139,

        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = 0x8148,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = 0x817d,

        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = 0x817f,

        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = 0x8183,

        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = 0x818b,

        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = 0x8198,

        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = 0x81fb,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = 0x8242,

        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = 0x832c,

        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = 0x8353,

        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = 0x835c,

        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = 0x835d,

        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = 0x835e,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = 0x8400,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = 0x8401,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = 0x840c,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = 0x840d,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = 0x840e,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = 0x840f,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = 0x8410,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = 0x8411,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = 0x8412,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = 0x8413,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY = 0x8457
        /// </summary>
        FogCoordArray = 0x8457,

        /// <summary>
        /// Original was GL_COLOR_SUM = 0x8458
        /// </summary>
        ColorSum = 0x8458,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY = 0x845E
        /// </summary>
        SecondaryColorArray = 0x845e,

        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = 0x84f5,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = 0x8513,

        /// <summary>
        /// Original was GL_PROGRAM_POINT_SIZE = 0x8642
        /// </summary>
        ProgramPointSize = 0x8642,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642
        /// </summary>
        VertexProgramPointSize = 0x8642,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643
        /// </summary>
        VertexProgramTwoSide = 0x8643,

        /// <summary>
        /// Original was GL_DEPTH_CLAMP = 0x864F
        /// </summary>
        DepthClamp = 0x864f,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F
        /// </summary>
        TextureCubeMapSeamless = 0x884f,

        /// <summary>
        /// Original was GL_POINT_SPRITE = 0x8861
        /// </summary>
        PointSprite = 0x8861,

        /// <summary>
        /// Original was GL_SAMPLE_SHADING = 0x8C36
        /// </summary>
        SampleShading = 0x8c36,

        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD = 0x8C89
        /// </summary>
        RasterizerDiscard = 0x8c89,

        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        /// </summary>
        PrimitiveRestartFixedIndex = 0x8d69,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_SRGB = 0x8DB9
        /// </summary>
        FramebufferSrgb = 0x8db9,

        /// <summary>
        /// Original was GL_SAMPLE_MASK = 0x8E51
        /// </summary>
        SampleMask = 0x8e51,

        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART = 0x8F9D
        /// </summary>
        PrimitiveRestart = 0x8f9d,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = 0x92e0
    }
}
