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
    /// Used in GL.GetBoolean and GL.GetDouble, as well as 3 other functions.
    /// </summary>
    public enum GetPName
    {
        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0xB10
        /// </summary>
        PointSmooth = 0xB10,

        /// <summary>
        /// Original was GL_POINT_SIZE = 0xB11
        /// </summary>
        PointSize = 0xB11,

        /// <summary>
        /// Original was GL_POINT_SIZE_RANGE = 0xB12
        /// </summary>
        PointSizeRange = 0xB12,

        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_RANGE = 0xB12
        /// </summary>
        SmoothPointSizeRange = 0xB12,

        /// <summary>
        /// Original was GL_POINT_SIZE_GRANULARITY = 0xB13
        /// </summary>
        PointSizeGranularity = 0xB13,

        /// <summary>
        /// Original was GL_SMOOTH_POINT_SIZE_GRANULARITY = 0xB13
        /// </summary>
        SmoothPointSizeGranularity = 0xB13,

        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0xB20
        /// </summary>
        LineSmooth = 0xB20,

        /// <summary>
        /// Original was GL_LINE_WIDTH = 0xB21
        /// </summary>
        LineWidth = 0xB21,

        /// <summary>
        /// Original was GL_LINE_WIDTH_RANGE = 0xB22
        /// </summary>
        LineWidthRange = 0xB22,

        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0xB22
        /// </summary>
        SmoothLineWidthRange = 0xB22,

        /// <summary>
        /// Original was GL_LINE_WIDTH_GRANULARITY = 0xB23
        /// </summary>
        LineWidthGranularity = 0xB23,

        /// <summary>
        /// Original was GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0xB23
        /// </summary>
        SmoothLineWidthGranularity = 0xB23,

        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0xB24
        /// </summary>
        LineStipple = 0xB24,

        /// <summary>
        /// Original was GL_POLYGON_MODE = 0xB40
        /// </summary>
        PolygonMode = 0xB40,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0xB41
        /// </summary>
        PolygonSmooth = 0xB41,

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0xB42
        /// </summary>
        PolygonStipple = 0xB42,

        /// <summary>
        /// Original was GL_CULL_FACE = 0xB44
        /// </summary>
        CullFace = 0xB44,

        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0xB45
        /// </summary>
        CullFaceMode = 0xB45,

        /// <summary>
        /// Original was GL_FRONT_FACE = 0xB46
        /// </summary>
        FrontFace = 0xB46,

        /// <summary>
        /// Original was GL_LIGHTING = 0xB50
        /// </summary>
        Lighting = 0xB50,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0xB57
        /// </summary>
        ColorMaterial = 0xB57,

        /// <summary>
        /// Original was GL_FOG = 0xB60
        /// </summary>
        Fog = 0xB60,

        /// <summary>
        /// Original was GL_FOG_INDEX = 0xB61
        /// </summary>
        FogIndex = 0xB61,

        /// <summary>
        /// Original was GL_FOG_DENSITY = 0xB62
        /// </summary>
        FogDensity = 0xB62,

        /// <summary>
        /// Original was GL_FOG_START = 0xB63
        /// </summary>
        FogStart = 0xB63,

        /// <summary>
        /// Original was GL_FOG_END = 0xB64
        /// </summary>
        FogEnd = 0xB64,

        /// <summary>
        /// Original was GL_FOG_MODE = 0xB65
        /// </summary>
        FogMode = 0xB65,

        /// <summary>
        /// Original was GL_FOG_COLOR = 0xB66
        /// </summary>
        FogColor = 0xB66,

        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0xB70
        /// </summary>
        DepthRange = 0xB70,

        /// <summary>
        /// Original was GL_DEPTH_TEST = 0xB71
        /// </summary>
        DepthTest = 0xB71,

        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0xB72
        /// </summary>
        DepthWritemask = 0xB72,

        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0xB73
        /// </summary>
        DepthClearValue = 0xB73,

        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0xB74
        /// </summary>
        DepthFunc = 0xB74,

        /// <summary>
        /// Original was GL_STENCIL_TEST = 0xB90
        /// </summary>
        StencilTest = 0xB90,

        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0xB91
        /// </summary>
        StencilClearValue = 0xB91,

        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0xB92
        /// </summary>
        StencilFunc = 0xB92,

        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0xB93
        /// </summary>
        StencilValueMask = 0xB93,

        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0xB94
        /// </summary>
        StencilFail = 0xB94,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0xB95
        /// </summary>
        StencilPassDepthFail = 0xB95,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0xB96
        /// </summary>
        StencilPassDepthPass = 0xB96,

        /// <summary>
        /// Original was GL_STENCIL_REF = 0xB97
        /// </summary>
        StencilRef = 0xB97,

        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0xB98
        /// </summary>
        StencilWritemask = 0xB98,

        /// <summary>
        /// Original was GL_NORMALIZE = 0xBA1
        /// </summary>
        Normalize = 0xBA1,

        /// <summary>
        /// Original was GL_VIEWPORT = 0xBA2
        /// </summary>
        Viewport = 0xBA2,

        /// <summary>
        /// Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0xBA3
        /// </summary>
        Modelview0StackDepthExt = 0xBA3,

        /// <summary>
        /// Original was GL_MODELVIEW0_MATRIX_EXT = 0xBA6
        /// </summary>
        Modelview0MatrixExt = 0xBA6,

        /// <summary>
        /// Original was GL_ALPHA_TEST = 0xBC0
        /// </summary>
        AlphaTest = 0xBC0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_Q_COM = 0xBC0
        /// </summary>
        AlphaTestQCom = 0xBC0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC_Q_COM = 0xBC1
        /// </summary>
        AlphaTestFuncQCom = 0xBC1,

        /// <summary>
        /// Original was GL_ALPHA_TEST_REF_Q_COM = 0xBC2
        /// </summary>
        AlphaTestRefQCom = 0xBC2,

        /// <summary>
        /// Original was GL_DITHER = 0xBD0
        /// </summary>
        Dither = 0xBD0,

        /// <summary>
        /// Original was GL_BLEND_DST = 0xBE0
        /// </summary>
        BlendDst = 0xBE0,

        /// <summary>
        /// Original was GL_BLEND_SRC = 0xBE1
        /// </summary>
        BlendSrc = 0xBE1,

        /// <summary>
        /// Original was GL_BLEND = 0xBE2
        /// </summary>
        Blend = 0xBE2,

        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0xBF0
        /// </summary>
        LogicOpMode = 0xBF0,

        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0xBF1
        /// </summary>
        IndexLogicOp = 0xBF1,

        /// <summary>
        /// Original was GL_LOGIC_OP = 0xBF1
        /// </summary>
        LogicOp = 0xBF1,

        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0xBF2
        /// </summary>
        ColorLogicOp = 0xBF2,

        /// <summary>
        /// Original was GL_DRAW_BUFFER = 0xC01
        /// </summary>
        DrawBuffer = 0xC01,

        /// <summary>
        /// Original was GL_DRAW_BUFFER_EXT = 0xC01
        /// </summary>
        DrawBufferExt = 0xC01,

        /// <summary>
        /// Original was GL_READ_BUFFER = 0xC02
        /// </summary>
        ReadBuffer = 0xC02,

        /// <summary>
        /// Original was GL_READ_BUFFER_EXT = 0xC02
        /// </summary>
        ReadBufferExt = 0xC02,

        /// <summary>
        /// Original was GL_READ_BUFFER_NV = 0xC02
        /// </summary>
        ReadBufferNV = 0xC02,

        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0xC10
        /// </summary>
        ScissorBox = 0xC10,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0xC11
        /// </summary>
        ScissorTest = 0xC11,

        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0xC22
        /// </summary>
        ColorClearValue = 0xC22,

        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0xC23
        /// </summary>
        ColorWritemask = 0xC23,

        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0xC32
        /// </summary>
        Doublebuffer = 0xC32,

        /// <summary>
        /// Original was GL_STEREO = 0xC33
        /// </summary>
        Stereo = 0xC33,

        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0xC52
        /// </summary>
        LineSmoothHint = 0xC52,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0xC53
        /// </summary>
        PolygonSmoothHint = 0xC53,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0xC60
        /// </summary>
        TextureGenS = 0xC60,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0xC61
        /// </summary>
        TextureGenT = 0xC61,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0xC62
        /// </summary>
        TextureGenR = 0xC62,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0xC63
        /// </summary>
        TextureGenQ = 0xC63,

        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0xCF0
        /// </summary>
        UnpackSwapBytes = 0xCF0,

        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0xCF1
        /// </summary>
        UnpackLsbFirst = 0xCF1,

        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0xCF2
        /// </summary>
        UnpackRowLength = 0xCF2,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0xCF3
        /// </summary>
        UnpackSkipRows = 0xCF3,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0xCF4
        /// </summary>
        UnpackSkipPixels = 0xCF4,

        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0xCF5
        /// </summary>
        UnpackAlignment = 0xCF5,

        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0xD00
        /// </summary>
        PackSwapBytes = 0xD00,

        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0xD01
        /// </summary>
        PackLsbFirst = 0xD01,

        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0xD02
        /// </summary>
        PackRowLength = 0xD02,

        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0xD03
        /// </summary>
        PackSkipRows = 0xD03,

        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0xD04
        /// </summary>
        PackSkipPixels = 0xD04,

        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0xD05
        /// </summary>
        PackAlignment = 0xD05,

        /// <summary>
        /// Original was GL_MAX_CLIP_DISTANCES = 0xD32
        /// </summary>
        MaxClipDistances = 0xD32,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0xD33
        /// </summary>
        MaxTextureSize = 0xD33,

        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0xD3A
        /// </summary>
        MaxViewportDims = 0xD3A,

        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0xD50
        /// </summary>
        SubpixelBits = 0xD50,

        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0xD80
        /// </summary>
        AutoNormal = 0xD80,

        /// <summary>
        /// Original was GL_MAP1_COLOR4 = 0xD90
        /// </summary>
        Map1Color4 = 0xD90,

        /// <summary>
        /// Original was GL_MAP1_INDEX = 0xD91
        /// </summary>
        Map1Index = 0xD91,

        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0xD92
        /// </summary>
        Map1Normal = 0xD92,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD1 = 0xD93
        /// </summary>
        Map1TextureCoord1 = 0xD93,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD2 = 0xD94
        /// </summary>
        Map1TextureCoord2 = 0xD94,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD3 = 0xD95
        /// </summary>
        Map1TextureCoord3 = 0xD95,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD4 = 0xD96
        /// </summary>
        Map1TextureCoord4 = 0xD96,

        /// <summary>
        /// Original was GL_MAP1_VERTEX3 = 0xD97
        /// </summary>
        Map1Vertex3 = 0xD97,

        /// <summary>
        /// Original was GL_MAP1_VERTEX4 = 0xD98
        /// </summary>
        Map1Vertex4 = 0xD98,

        /// <summary>
        /// Original was GL_MAP2_COLOR4 = 0xDB0
        /// </summary>
        Map2Color4 = 0xDB0,

        /// <summary>
        /// Original was GL_MAP2_INDEX = 0xDB1
        /// </summary>
        Map2Index = 0xDB1,

        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0xDB2
        /// </summary>
        Map2Normal = 0xDB2,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD1 = 0xDB3
        /// </summary>
        Map2TextureCoord1 = 0xDB3,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD2 = 0xDB4
        /// </summary>
        Map2TextureCoord2 = 0xDB4,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD3 = 0xDB5
        /// </summary>
        Map2TextureCoord3 = 0xDB5,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD4 = 0xDB6
        /// </summary>
        Map2TextureCoord4 = 0xDB6,

        /// <summary>
        /// Original was GL_MAP2_VERTEX3 = 0xDB7
        /// </summary>
        Map2Vertex3 = 0xDB7,

        /// <summary>
        /// Original was GL_MAP2_VERTEX4 = 0xDB8
        /// </summary>
        Map2Vertex4 = 0xDB8,

        /// <summary>
        /// Original was GL_TEXTURE1_D = 0xDE0
        /// </summary>
        Texture1D = 0xDE0,

        /// <summary>
        /// Original was GL_TEXTURE2_D = 0xDE1
        /// </summary>
        Texture2D = 0xDE1,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = 0x2A00,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = 0x2A01,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = 0x2A02,

        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = 0x3005,

        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = 0x4000,

        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = 0x4001,

        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = 0x4002,

        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = 0x4003,

        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = 0x4004,

        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = 0x4005,

        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = 0x4006,

        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = 0x4007,

        /// <summary>
        /// Original was GL_BLEND_COLOR_EXT = 0x8005
        /// </summary>
        BlendColorExt = 0x8005,

        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = 0x8009,

        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = 0x800E,

        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = 0x800F,

        /// <summary>
        /// Original was GL_CONVOLUTION1_D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION2_D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = 0x8011,

        /// <summary>
        /// Original was GL_SEPARABLE2_D_EXT = 0x8012
        /// </summary>
        Separable2DExt = 0x8012,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = 0x801C,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = 0x801D,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = 0x801E,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = 0x801F,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = 0x8023,

        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = 0x8024,

        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = 0x802E,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = 0x8037,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = 0x8038,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
        /// </summary>
        PolygonOffsetBiasExt = 0x8039,

        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = 0x803A,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING1_D = 0x8068
        /// </summary>
        TextureBinding1D = 0x8068,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING2_D = 0x8069
        /// </summary>
        TextureBinding2D = 0x8069,

        /// <summary>
        /// Original was GL_TEXTURE3_D_BINDING_EXT = 0x806A
        /// </summary>
        Texture3DBindingExt = 0x806A,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING3_D = 0x806A
        /// </summary>
        TextureBinding3D = 0x806A,

        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = 0x806B,

        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = 0x806C,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = 0x806D,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = 0x806E,

        /// <summary>
        /// Original was GL_TEXTURE3_D_EXT = 0x806F
        /// </summary>
        Texture3DExt = 0x806F,

        /// <summary>
        /// Original was GL_MAX3_D_TEXTURE_SIZE_EXT = 0x8073
        /// </summary>
        Max3DTextureSizeExt = 0x8073,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = 0x8075,

        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = 0x8076,

        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = 0x8077,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = 0x8078,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = 0x8079,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        /// </summary>
        VertexArrayCountExt = 0x807D,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        /// </summary>
        NormalArrayCountExt = 0x8080,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        /// </summary>
        ColorArrayCountExt = 0x8084,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        /// </summary>
        IndexArrayCountExt = 0x8087,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        /// </summary>
        TextureCoordArrayCountExt = 0x808B,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        /// </summary>
        EdgeFlagArrayCountExt = 0x808D,

        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = 0x8094,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE2_D_BINDING_SGIS = 0x8096
        /// </summary>
        DetailTexture2DBindingSgis = 0x8096,

        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = 0x809D,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = 0x809E,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = 0x809F,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = 0x80A0,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        /// </summary>
        SampleBuffersSgis = 0x80A8,

        /// <summary>
        /// Original was GL_SAMPLES_SGIS = 0x80A9
        /// </summary>
        SamplesSgis = 0x80A9,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        /// </summary>
        SampleMaskValueSgis = 0x80AA,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        /// </summary>
        SampleMaskInvertSgis = 0x80AB,

        /// <summary>
        /// Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        /// </summary>
        SamplePatternSgis = 0x80AC,

        /// <summary>
        /// Original was GL_COLOR_MATRIX_SGI = 0x80B1
        /// </summary>
        ColorMatrixSgi = 0x80B1,

        /// <summary>
        /// Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        /// </summary>
        ColorMatrixStackDepthSgi = 0x80B2,

        /// <summary>
        /// Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        /// </summary>
        MaxColorMatrixStackDepthSgi = 0x80B3,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        /// </summary>
        PostColorMatrixRedScaleSgi = 0x80B4,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        /// </summary>
        PostColorMatrixGreenScaleSgi = 0x80B5,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        /// </summary>
        PostColorMatrixBlueScaleSgi = 0x80B6,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScaleSgi = 0x80B7,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        /// </summary>
        PostColorMatrixRedBiasSgi = 0x80B8,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        /// </summary>
        PostColorMatrixGreenBiasSgi = 0x80B9,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        /// </summary>
        PostColorMatrixBlueBiasSgi = 0x80BA,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBiasSgi = 0x80BB,

        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = 0x80BC,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = 0x80D0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = 0x80D1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = 0x80D2,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
        PointSizeMinSgis = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        /// </summary>
        PointSizeMaxSgis = 0x8127,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        /// </summary>
        PointFadeThresholdSizeSgis = 0x8128,

        /// <summary>
        /// Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        /// </summary>
        DistanceAttenuationSgis = 0x8129,

        /// <summary>
        /// Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        /// </summary>
        FogFuncPointsSgis = 0x812B,

        /// <summary>
        /// Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        /// </summary>
        MaxFogFuncPointsSgis = 0x812C,

        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = 0x8130,

        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = 0x8131,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = 0x8132,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = 0x8133,

        /// <summary>
        /// Original was GL_TEXTURE4_D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = 0x8134,

        /// <summary>
        /// Original was GL_MAX4_D_TEXTURE_SIZE_SGIS = 0x8138
        /// </summary>
        Max4DTextureSizeSgis = 0x8138,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = 0x8139,

        /// <summary>
        /// Original was GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
        /// </summary>
        PixelTileBestAlignmentSgix = 0x813E,

        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
        /// </summary>
        PixelTileCacheIncrementSgix = 0x813F,

        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = 0x8140,

        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = 0x8141,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = 0x8142,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = 0x8143,

        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = 0x8144,

        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = 0x8145,

        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = 0x8148,

        /// <summary>
        /// Original was GL_SPRITE_MODE_SGIX = 0x8149
        /// </summary>
        SpriteModeSgix = 0x8149,

        /// <summary>
        /// Original was GL_SPRITE_AXIS_SGIX = 0x814A
        /// </summary>
        SpriteAxisSgix = 0x814A,

        /// <summary>
        /// Original was GL_SPRITE_TRANSLATION_SGIX = 0x814B
        /// </summary>
        SpriteTranslationSgix = 0x814B,

        /// <summary>
        /// Original was GL_TEXTURE4_D_BINDING_SGIS = 0x814F
        /// </summary>
        Texture4DBindingSgis = 0x814F,

        /// <summary>
        /// Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        /// </summary>
        MaxClipmapDepthSgix = 0x8177,

        /// <summary>
        /// Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        /// </summary>
        MaxClipmapVirtualDepthSgix = 0x8178,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
        /// </summary>
        PostTextureFilterBiasRangeSgix = 0x817B,

        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
        /// </summary>
        PostTextureFilterScaleRangeSgix = 0x817C,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = 0x817D,

        /// <summary>
        /// Original was GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
        /// </summary>
        ReferencePlaneEquationSgix = 0x817E,

        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IRInstrument1Sgix = 0x817F,

        /// <summary>
        /// Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        /// </summary>
        InstrumentMeasurementsSgix = 0x8181,

        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = 0x8183,

        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = 0x818B,

        /// <summary>
        /// Original was GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
        /// </summary>
        FramezoomFactorSgix = 0x818C,

        /// <summary>
        /// Original was GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
        /// </summary>
        MaxFramezoomFactorSgix = 0x818D,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = 0x8192,

        /// <summary>
        /// Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        /// </summary>
        DeformationsMaskSgix = 0x8196,

        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = 0x8198,

        /// <summary>
        /// Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        /// </summary>
        FogOffsetValueSgix = 0x8199,

        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = 0x81FB,

        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = 0x8316,

        /// <summary>
        /// Original was GL_ASYNC_MARKER_SGIX = 0x8329
        /// </summary>
        AsyncMarkerSgix = 0x8329,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
        /// </summary>
        PixelTexGenModeSgix = 0x832B,

        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = 0x832C,

        /// <summary>
        /// Original was GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
        /// </summary>
        MaxAsyncHistogramSgix = 0x832D,

        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = 0x8353,

        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = 0x835C,

        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = 0x835D,

        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = 0x835E,

        /// <summary>
        /// Original was GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
        /// </summary>
        MaxAsyncTexImageSgix = 0x835F,

        /// <summary>
        /// Original was GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
        /// </summary>
        MaxAsyncDrawPixelsSgix = 0x8360,

        /// <summary>
        /// Original was GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
        /// </summary>
        MaxAsyncReadPixelsSgix = 0x8361,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = 0x83EE,

        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = 0x83EF,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = 0x8400,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = 0x8401,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
        /// </summary>
        FragmentColorMaterialFaceSgix = 0x8402,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
        /// </summary>
        FragmentColorMaterialParameterSgix = 0x8403,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
        /// </summary>
        MaxFragmentLightsSgix = 0x8404,

        /// <summary>
        /// Original was GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
        /// </summary>
        MaxActiveLightsSgix = 0x8405,

        /// <summary>
        /// Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        /// </summary>
        LightEnvModeSgix = 0x8407,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        /// </summary>
        FragmentLightModelLocalViewerSgix = 0x8408,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        /// </summary>
        FragmentLightModelTwoSideSgix = 0x8409,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        /// </summary>
        FragmentLightModelAmbientSgix = 0x840A,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        /// </summary>
        FragmentLightModelNormalInterpolationSgix = 0x840B,

        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = 0x840C,

        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = 0x842E,

        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = 0x842F,

        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = 0x846E,

        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = 0x85A0,

        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = 0x85A1,

        /// <summary>
        /// Original was GL_DEVICE_UUID_EXT = 0x9597
        /// </summary>
        DeviceUuidExt = 0x9597,

        /// <summary>
        /// Original was GL_DRIVER_UUID_EXT = 0x9598
        /// </summary>
        DriverUuidExt = 0x9598,

        /// <summary>
        /// Original was GL_DEVICE_LUID_EXT = 0x9599
        /// </summary>
        DeviceLuidExt = 0x9599,

        /// <summary>
        /// Original was GL_DEVICE_NODE_MASK_EXT = 0x959A
        /// </summary>
        DeviceNodeMaskExt = 0x959A
    }
}
