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

using System;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version10
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = 0,

        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = 0x0000,

        /// <summary>
        /// Original was GL_CURRENT_BIT = 0x00000001
        /// </summary>
        CurrentBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_POINT_BIT = 0x00000002
        /// </summary>
        PointBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_LINE_BIT = 0x00000004
        /// </summary>
        LineBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_POLYGON_BIT = 0x00000008
        /// </summary>
        PolygonBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE_BIT = 0x00000010
        /// </summary>
        PolygonStippleBit = ((int)0x00000010),

        /// <summary>
        /// Original was GL_PIXEL_MODE_BIT = 0x00000020
        /// </summary>
        PixelModeBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_LIGHTING_BIT = 0x00000040
        /// </summary>
        LightingBit = ((int)0x00000040),

        /// <summary>
        /// Original was GL_FOG_BIT = 0x00000080
        /// </summary>
        FogBit = ((int)0x00000080),

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        /// </summary>
        AccumBufferBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_VIEWPORT_BIT = 0x00000800
        /// </summary>
        ViewportBit = ((int)0x00000800),

        /// <summary>
        /// Original was GL_TRANSFORM_BIT = 0x00001000
        /// </summary>
        TransformBit = ((int)0x00001000),

        /// <summary>
        /// Original was GL_ENABLE_BIT = 0x00002000
        /// </summary>
        EnableBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_HINT_BIT = 0x00008000
        /// </summary>
        HintBit = ((int)0x00008000),

        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = 0x0001,

        /// <summary>
        /// Original was GL_EVAL_BIT = 0x00010000
        /// </summary>
        EvalBit = ((int)0x00010000),

        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = 0x0002,

        /// <summary>
        /// Original was GL_LIST_BIT = 0x00020000
        /// </summary>
        ListBit = ((int)0x00020000),

        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = 0x0003,

        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = 0x0004,

        /// <summary>
        /// Original was GL_TEXTURE_BIT = 0x00040000
        /// </summary>
        TextureBit = ((int)0x00040000),

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = 0x0005,

        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = 0x0006,

        /// <summary>
        /// Original was GL_QUADS = 0x0007
        /// </summary>
        Quads = 0x0007,

        /// <summary>
        /// Original was GL_QUAD_STRIP = 0x0008
        /// </summary>
        QuadStrip = 0x0008,

        /// <summary>
        /// Original was GL_SCISSOR_BIT = 0x00080000
        /// </summary>
        ScissorBit = ((int)0x00080000),

        /// <summary>
        /// Original was GL_POLYGON = 0x0009
        /// </summary>
        Polygon = 0x0009,

        /// <summary>
        /// Original was GL_ACCUM = 0x0100
        /// </summary>
        Accum = 0x0100,

        /// <summary>
        /// Original was GL_LOAD = 0x0101
        /// </summary>
        Load = 0x0101,

        /// <summary>
        /// Original was GL_RETURN = 0x0102
        /// </summary>
        Return = 0x0102,

        /// <summary>
        /// Original was GL_MULT = 0x0103
        /// </summary>
        Mult = 0x0103,

        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = 0x0104,

        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = 0x0200,

        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = 0x0201,

        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = 0x0202,

        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = 0x0203,

        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = 0x0204,

        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = 0x0205,

        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = 0x0206,

        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = 0x0207,

        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = 0x0300,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = 0x0301,

        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = 0x0302,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = 0x0303,

        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = 0x0304,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = 0x0305,

        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = 0x0306,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = 0x0307,

        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = 0x0308,

        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = 0x0400,

        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = 0x0401,

        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = 0x0402,

        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = 0x0403,

        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = 0x0404,

        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = 0x0405,

        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = 0x0406,

        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = 0x0407,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = 0x0408,

        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = 0x0409,

        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = 0x040a,

        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = 0x040b,

        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = 0x040c,

        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = 0x0500,

        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = 0x0501,

        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = 0x0502,

        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = 0x0503,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = 0x0504,

        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = 0x0505,

        /// <summary>
        /// Original was GL_2D = 0x0600
        /// </summary>
        Gl2D = 0x0600,

        /// <summary>
        /// Original was GL_3D = 0x0601
        /// </summary>
        Gl3D = 0x0601,

        /// <summary>
        /// Original was GL_3D_COLOR = 0x0602
        /// </summary>
        Gl3DColor = 0x0602,

        /// <summary>
        /// Original was GL_3D_COLOR_TEXTURE = 0x0603
        /// </summary>
        Gl3DColorTexture = 0x0603,

        /// <summary>
        /// Original was GL_4D_COLOR_TEXTURE = 0x0604
        /// </summary>
        Gl4DColorTexture = 0x0604,

        /// <summary>
        /// Original was GL_PASS_THROUGH_TOKEN = 0x0700
        /// </summary>
        PassThroughToken = 0x0700,

        /// <summary>
        /// Original was GL_POINT_TOKEN = 0x0701
        /// </summary>
        PointToken = 0x0701,

        /// <summary>
        /// Original was GL_LINE_TOKEN = 0x0702
        /// </summary>
        LineToken = 0x0702,

        /// <summary>
        /// Original was GL_POLYGON_TOKEN = 0x0703
        /// </summary>
        PolygonToken = 0x0703,

        /// <summary>
        /// Original was GL_BITMAP_TOKEN = 0x0704
        /// </summary>
        BitmapToken = 0x0704,

        /// <summary>
        /// Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        /// </summary>
        DrawPixelToken = 0x0705,

        /// <summary>
        /// Original was GL_COPY_PIXEL_TOKEN = 0x0706
        /// </summary>
        CopyPixelToken = 0x0706,

        /// <summary>
        /// Original was GL_LINE_RESET_TOKEN = 0x0707
        /// </summary>
        LineResetToken = 0x0707,

        /// <summary>
        /// Original was GL_EXP = 0x0800
        /// </summary>
        Exp = 0x0800,

        /// <summary>
        /// Original was GL_EXP2 = 0x0801
        /// </summary>
        Exp2 = 0x0801,

        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = 0x0900,

        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = 0x0901,

        /// <summary>
        /// Original was GL_COEFF = 0x0A00
        /// </summary>
        Coeff = 0x0a00,

        /// <summary>
        /// Original was GL_ORDER = 0x0A01
        /// </summary>
        Order = 0x0a01,

        /// <summary>
        /// Original was GL_DOMAIN = 0x0A02
        /// </summary>
        Domain = 0x0a02,

        /// <summary>
        /// Original was GL_CURRENT_COLOR = 0x0B00
        /// </summary>
        CurrentColor = 0x0b00,

        /// <summary>
        /// Original was GL_CURRENT_INDEX = 0x0B01
        /// </summary>
        CurrentIndex = 0x0b01,

        /// <summary>
        /// Original was GL_CURRENT_NORMAL = 0x0B02
        /// </summary>
        CurrentNormal = 0x0b02,

        /// <summary>
        /// Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        /// </summary>
        CurrentTextureCoords = 0x0b03,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_COLOR = 0x0B04
        /// </summary>
        CurrentRasterColor = 0x0b04,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_INDEX = 0x0B05
        /// </summary>
        CurrentRasterIndex = 0x0b05,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06
        /// </summary>
        CurrentRasterTextureCoords = 0x0b06,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION = 0x0B07
        /// </summary>
        CurrentRasterPosition = 0x0b07,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_POSITION_VALID = 0x0B08
        /// </summary>
        CurrentRasterPositionValid = 0x0b08,

        /// <summary>
        /// Original was GL_CURRENT_RASTER_DISTANCE = 0x0B09
        /// </summary>
        CurrentRasterDistance = 0x0b09,

        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = 0x0b10,

        /// <summary>
        /// Original was GL_POINT_SIZE = 0x0B11
        /// </summary>
        PointSize = 0x0b11,

        /// <summary>
        /// Original was GL_POINT_SIZE_RANGE = 0x0B12
        /// </summary>
        PointSizeRange = 0x0b12,

        /// <summary>
        /// Original was GL_POINT_SIZE_GRANULARITY = 0x0B13
        /// </summary>
        PointSizeGranularity = 0x0b13,

        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = 0x0b20,

        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = 0x0b21,

        /// <summary>
        /// Original was GL_LINE_WIDTH_RANGE = 0x0B22
        /// </summary>
        LineWidthRange = 0x0b22,

        /// <summary>
        /// Original was GL_LINE_WIDTH_GRANULARITY = 0x0B23
        /// </summary>
        LineWidthGranularity = 0x0b23,

        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = 0x0b24,

        /// <summary>
        /// Original was GL_LINE_STIPPLE_PATTERN = 0x0B25
        /// </summary>
        LineStipplePattern = 0x0b25,

        /// <summary>
        /// Original was GL_LINE_STIPPLE_REPEAT = 0x0B26
        /// </summary>
        LineStippleRepeat = 0x0b26,

        /// <summary>
        /// Original was GL_LIST_MODE = 0x0B30
        /// </summary>
        ListMode = 0x0b30,

        /// <summary>
        /// Original was GL_MAX_LIST_NESTING = 0x0B31
        /// </summary>
        MaxListNesting = 0x0b31,

        /// <summary>
        /// Original was GL_LIST_BASE = 0x0B32
        /// </summary>
        ListBase = 0x0b32,

        /// <summary>
        /// Original was GL_LIST_INDEX = 0x0B33
        /// </summary>
        ListIndex = 0x0b33,

        /// <summary>
        /// Original was GL_POLYGON_MODE = 0x0B40
        /// </summary>
        PolygonMode = 0x0b40,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = 0x0b41,

        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = 0x0b42,

        /// <summary>
        /// Original was GL_EDGE_FLAG = 0x0B43
        /// </summary>
        EdgeFlag = 0x0b43,

        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = 0x0b44,

        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = 0x0b45,

        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = 0x0b46,

        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = 0x0b50,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        /// </summary>
        LightModelLocalViewer = 0x0b51,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        /// </summary>
        LightModelTwoSide = 0x0b52,

        /// <summary>
        /// Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        /// </summary>
        LightModelAmbient = 0x0b53,

        /// <summary>
        /// Original was GL_SHADE_MODEL = 0x0B54
        /// </summary>
        ShadeModel = 0x0b54,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL_FACE = 0x0B55
        /// </summary>
        ColorMaterialFace = 0x0b55,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL_PARAMETER = 0x0B56
        /// </summary>
        ColorMaterialParameter = 0x0b56,

        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = 0x0b57,

        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = 0x0b60,

        /// <summary>
        /// Original was GL_FOG_INDEX = 0x0B61
        /// </summary>
        FogIndex = 0x0b61,

        /// <summary>
        /// Original was GL_FOG_DENSITY = 0x0B62
        /// </summary>
        FogDensity = 0x0b62,

        /// <summary>
        /// Original was GL_FOG_START = 0x0B63
        /// </summary>
        FogStart = 0x0b63,

        /// <summary>
        /// Original was GL_FOG_END = 0x0B64
        /// </summary>
        FogEnd = 0x0b64,

        /// <summary>
        /// Original was GL_FOG_MODE = 0x0B65
        /// </summary>
        FogMode = 0x0b65,

        /// <summary>
        /// Original was GL_FOG_COLOR = 0x0B66
        /// </summary>
        FogColor = 0x0b66,

        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = 0x0b70,

        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = 0x0b71,

        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = 0x0b72,

        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = 0x0b73,

        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = 0x0b74,

        /// <summary>
        /// Original was GL_ACCUM_CLEAR_VALUE = 0x0B80
        /// </summary>
        AccumClearValue = 0x0b80,

        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = 0x0b90,

        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = 0x0b91,

        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = 0x0b92,

        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = 0x0b93,

        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = 0x0b94,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = 0x0b95,

        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = 0x0b96,

        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = 0x0b97,

        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = 0x0b98,

        /// <summary>
        /// Original was GL_MATRIX_MODE = 0x0BA0
        /// </summary>
        MatrixMode = 0x0ba0,

        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = 0x0ba1,

        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = 0x0ba2,

        /// <summary>
        /// Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        /// </summary>
        ModelviewStackDepth = 0x0ba3,

        /// <summary>
        /// Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        /// </summary>
        ProjectionStackDepth = 0x0ba4,

        /// <summary>
        /// Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        /// </summary>
        TextureStackDepth = 0x0ba5,

        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX = 0x0BA6
        /// </summary>
        ModelviewMatrix = 0x0ba6,

        /// <summary>
        /// Original was GL_PROJECTION_MATRIX = 0x0BA7
        /// </summary>
        ProjectionMatrix = 0x0ba7,

        /// <summary>
        /// Original was GL_TEXTURE_MATRIX = 0x0BA8
        /// </summary>
        TextureMatrix = 0x0ba8,

        /// <summary>
        /// Original was GL_ATTRIB_STACK_DEPTH = 0x0BB0
        /// </summary>
        AttribStackDepth = 0x0bb0,

        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = 0x0bc0,

        /// <summary>
        /// Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        /// </summary>
        AlphaTestFunc = 0x0bc1,

        /// <summary>
        /// Original was GL_ALPHA_TEST_REF = 0x0BC2
        /// </summary>
        AlphaTestRef = 0x0bc2,

        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = 0x0bd0,

        /// <summary>
        /// Original was GL_BLEND_DST = 0x0BE0
        /// </summary>
        BlendDst = 0x0be0,

        /// <summary>
        /// Original was GL_BLEND_SRC = 0x0BE1
        /// </summary>
        BlendSrc = 0x0be1,

        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = 0x0be2,

        /// <summary>
        /// Original was GL_LOGIC_OP_MODE = 0x0BF0
        /// </summary>
        LogicOpMode = 0x0bf0,

        /// <summary>
        /// Original was GL_LOGIC_OP = 0x0BF1
        /// </summary>
        LogicOp = 0x0bf1,

        /// <summary>
        /// Original was GL_AUX_BUFFERS = 0x0C00
        /// </summary>
        AuxBuffers = 0x0c00,

        /// <summary>
        /// Original was GL_DRAW_BUFFER = 0x0C01
        /// </summary>
        DrawBuffer = 0x0c01,

        /// <summary>
        /// Original was GL_READ_BUFFER = 0x0C02
        /// </summary>
        ReadBuffer = 0x0c02,

        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = 0x0c10,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = 0x0c11,

        /// <summary>
        /// Original was GL_INDEX_CLEAR_VALUE = 0x0C20
        /// </summary>
        IndexClearValue = 0x0c20,

        /// <summary>
        /// Original was GL_INDEX_WRITEMASK = 0x0C21
        /// </summary>
        IndexWritemask = 0x0c21,

        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = 0x0c22,

        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = 0x0c23,

        /// <summary>
        /// Original was GL_INDEX_MODE = 0x0C30
        /// </summary>
        IndexMode = 0x0c30,

        /// <summary>
        /// Original was GL_RGBA_MODE = 0x0C31
        /// </summary>
        RgbaMode = 0x0c31,

        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = 0x0c32,

        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = 0x0c33,

        /// <summary>
        /// Original was GL_RENDER_MODE = 0x0C40
        /// </summary>
        RenderMode = 0x0c40,

        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = 0x0c50,

        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = 0x0c51,

        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = 0x0c52,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = 0x0c53,

        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = 0x0c54,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = 0x0c60,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = 0x0c61,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = 0x0c62,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = 0x0c63,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        /// </summary>
        PixelMapIToI = 0x0c70,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        /// </summary>
        PixelMapSToS = 0x0c71,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        /// </summary>
        PixelMapIToR = 0x0c72,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        /// </summary>
        PixelMapIToG = 0x0c73,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        /// </summary>
        PixelMapIToB = 0x0c74,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        /// </summary>
        PixelMapIToA = 0x0c75,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        /// </summary>
        PixelMapRToR = 0x0c76,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        /// </summary>
        PixelMapGToG = 0x0c77,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        /// </summary>
        PixelMapBToB = 0x0c78,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        /// </summary>
        PixelMapAToA = 0x0c79,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0
        /// </summary>
        PixelMapIToISize = 0x0cb0,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1
        /// </summary>
        PixelMapSToSSize = 0x0cb1,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2
        /// </summary>
        PixelMapIToRSize = 0x0cb2,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3
        /// </summary>
        PixelMapIToGSize = 0x0cb3,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4
        /// </summary>
        PixelMapIToBSize = 0x0cb4,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5
        /// </summary>
        PixelMapIToASize = 0x0cb5,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6
        /// </summary>
        PixelMapRToRSize = 0x0cb6,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7
        /// </summary>
        PixelMapGToGSize = 0x0cb7,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8
        /// </summary>
        PixelMapBToBSize = 0x0cb8,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9
        /// </summary>
        PixelMapAToASize = 0x0cb9,

        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = 0x0cf0,

        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = 0x0cf1,

        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = 0x0cf2,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = 0x0cf3,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = 0x0cf4,

        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = 0x0cf5,

        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = 0x0d00,

        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = 0x0d01,

        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = 0x0d02,

        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = 0x0d03,

        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = 0x0d04,

        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = 0x0d05,

        /// <summary>
        /// Original was GL_MAP_COLOR = 0x0D10
        /// </summary>
        MapColor = 0x0d10,

        /// <summary>
        /// Original was GL_MAP_STENCIL = 0x0D11
        /// </summary>
        MapStencil = 0x0d11,

        /// <summary>
        /// Original was GL_INDEX_SHIFT = 0x0D12
        /// </summary>
        IndexShift = 0x0d12,

        /// <summary>
        /// Original was GL_INDEX_OFFSET = 0x0D13
        /// </summary>
        IndexOffset = 0x0d13,

        /// <summary>
        /// Original was GL_RED_SCALE = 0x0D14
        /// </summary>
        RedScale = 0x0d14,

        /// <summary>
        /// Original was GL_RED_BIAS = 0x0D15
        /// </summary>
        RedBias = 0x0d15,

        /// <summary>
        /// Original was GL_ZOOM_X = 0x0D16
        /// </summary>
        ZoomX = 0x0d16,

        /// <summary>
        /// Original was GL_ZOOM_Y = 0x0D17
        /// </summary>
        ZoomY = 0x0d17,

        /// <summary>
        /// Original was GL_GREEN_SCALE = 0x0D18
        /// </summary>
        GreenScale = 0x0d18,

        /// <summary>
        /// Original was GL_GREEN_BIAS = 0x0D19
        /// </summary>
        GreenBias = 0x0d19,

        /// <summary>
        /// Original was GL_BLUE_SCALE = 0x0D1A
        /// </summary>
        BlueScale = 0x0d1a,

        /// <summary>
        /// Original was GL_BLUE_BIAS = 0x0D1B
        /// </summary>
        BlueBias = 0x0d1b,

        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = 0x0d1c,

        /// <summary>
        /// Original was GL_ALPHA_BIAS = 0x0D1D
        /// </summary>
        AlphaBias = 0x0d1d,

        /// <summary>
        /// Original was GL_DEPTH_SCALE = 0x0D1E
        /// </summary>
        DepthScale = 0x0d1e,

        /// <summary>
        /// Original was GL_DEPTH_BIAS = 0x0D1F
        /// </summary>
        DepthBias = 0x0d1f,

        /// <summary>
        /// Original was GL_MAX_EVAL_ORDER = 0x0D30
        /// </summary>
        MaxEvalOrder = 0x0d30,

        /// <summary>
        /// Original was GL_MAX_LIGHTS = 0x0D31
        /// </summary>
        MaxLights = 0x0d31,

        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES = 0x0D32
        /// </summary>
        MaxClipPlanes = 0x0d32,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = 0x0d33,

        /// <summary>
        /// Original was GL_MAX_PIXEL_MAP_TABLE = 0x0D34
        /// </summary>
        MaxPixelMapTable = 0x0d34,

        /// <summary>
        /// Original was GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35
        /// </summary>
        MaxAttribStackDepth = 0x0d35,

        /// <summary>
        /// Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        /// </summary>
        MaxModelviewStackDepth = 0x0d36,

        /// <summary>
        /// Original was GL_MAX_NAME_STACK_DEPTH = 0x0D37
        /// </summary>
        MaxNameStackDepth = 0x0d37,

        /// <summary>
        /// Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        /// </summary>
        MaxProjectionStackDepth = 0x0d38,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        /// </summary>
        MaxTextureStackDepth = 0x0d39,

        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = 0x0d3a,

        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = 0x0d50,

        /// <summary>
        /// Original was GL_INDEX_BITS = 0x0D51
        /// </summary>
        IndexBits = 0x0d51,

        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = 0x0d52,

        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = 0x0d53,

        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = 0x0d54,

        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = 0x0d55,

        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = 0x0d56,

        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = 0x0d57,

        /// <summary>
        /// Original was GL_ACCUM_RED_BITS = 0x0D58
        /// </summary>
        AccumRedBits = 0x0d58,

        /// <summary>
        /// Original was GL_ACCUM_GREEN_BITS = 0x0D59
        /// </summary>
        AccumGreenBits = 0x0d59,

        /// <summary>
        /// Original was GL_ACCUM_BLUE_BITS = 0x0D5A
        /// </summary>
        AccumBlueBits = 0x0d5a,

        /// <summary>
        /// Original was GL_ACCUM_ALPHA_BITS = 0x0D5B
        /// </summary>
        AccumAlphaBits = 0x0d5b,

        /// <summary>
        /// Original was GL_NAME_STACK_DEPTH = 0x0D70
        /// </summary>
        NameStackDepth = 0x0d70,

        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = 0x0d80,

        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = 0x0d90,

        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = 0x0d91,

        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = 0x0d92,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = 0x0d93,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = 0x0d94,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = 0x0d95,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = 0x0d96,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = 0x0d97,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = 0x0d98,

        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = 0x0db0,

        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = 0x0db1,

        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = 0x0db2,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = 0x0db3,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = 0x0db4,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = 0x0db5,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = 0x0db6,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = 0x0db7,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = 0x0db8,

        /// <summary>
        /// Original was GL_MAP1_GRID_DOMAIN = 0x0DD0
        /// </summary>
        Map1GridDomain = 0x0dd0,

        /// <summary>
        /// Original was GL_MAP1_GRID_SEGMENTS = 0x0DD1
        /// </summary>
        Map1GridSegments = 0x0dd1,

        /// <summary>
        /// Original was GL_MAP2_GRID_DOMAIN = 0x0DD2
        /// </summary>
        Map2GridDomain = 0x0dd2,

        /// <summary>
        /// Original was GL_MAP2_GRID_SEGMENTS = 0x0DD3
        /// </summary>
        Map2GridSegments = 0x0dd3,

        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = 0x0de0,

        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = 0x1000,

        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = 0x1001,

        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = 0x1004,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = 0x1005,

        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = 0x1100,

        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = 0x1101,

        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = 0x1102,

        /// <summary>
        /// Original was GL_AMBIENT = 0x1200
        /// </summary>
        Ambient = 0x1200,

        /// <summary>
        /// Original was GL_DIFFUSE = 0x1201
        /// </summary>
        Diffuse = 0x1201,

        /// <summary>
        /// Original was GL_SPECULAR = 0x1202
        /// </summary>
        Specular = 0x1202,

        /// <summary>
        /// Original was GL_POSITION = 0x1203
        /// </summary>
        Position = 0x1203,

        /// <summary>
        /// Original was GL_SPOT_DIRECTION = 0x1204
        /// </summary>
        SpotDirection = 0x1204,

        /// <summary>
        /// Original was GL_SPOT_EXPONENT = 0x1205
        /// </summary>
        SpotExponent = 0x1205,

        /// <summary>
        /// Original was GL_SPOT_CUTOFF = 0x1206
        /// </summary>
        SpotCutoff = 0x1206,

        /// <summary>
        /// Original was GL_CONSTANT_ATTENUATION = 0x1207
        /// </summary>
        ConstantAttenuation = 0x1207,

        /// <summary>
        /// Original was GL_LINEAR_ATTENUATION = 0x1208
        /// </summary>
        LinearAttenuation = 0x1208,

        /// <summary>
        /// Original was GL_QUADRATIC_ATTENUATION = 0x1209
        /// </summary>
        QuadraticAttenuation = 0x1209,

        /// <summary>
        /// Original was GL_COMPILE = 0x1300
        /// </summary>
        Compile = 0x1300,

        /// <summary>
        /// Original was GL_COMPILE_AND_EXECUTE = 0x1301
        /// </summary>
        CompileAndExecute = 0x1301,

        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_2_BYTES = 0x1407
        /// </summary>
        Gl2Bytes = 0x1407,

        /// <summary>
        /// Original was GL_3_BYTES = 0x1408
        /// </summary>
        Gl3Bytes = 0x1408,

        /// <summary>
        /// Original was GL_4_BYTES = 0x1409
        /// </summary>
        Gl4Bytes = 0x1409,

        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = 0x1500,

        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = 0x1501,

        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = 0x1502,

        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = 0x1503,

        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = 0x1504,

        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = 0x1505,

        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = 0x1506,

        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = 0x1507,

        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = 0x1508,

        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = 0x1509,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = 0x150b,

        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = 0x150c,

        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = 0x150d,

        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = 0x150e,

        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = 0x150f,

        /// <summary>
        /// Original was GL_EMISSION = 0x1600
        /// </summary>
        Emission = 0x1600,

        /// <summary>
        /// Original was GL_SHININESS = 0x1601
        /// </summary>
        Shininess = 0x1601,

        /// <summary>
        /// Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        /// </summary>
        AmbientAndDiffuse = 0x1602,

        /// <summary>
        /// Original was GL_COLOR_INDEXES = 0x1603
        /// </summary>
        ColorIndexes = 0x1603,

        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = 0x1700,

        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = 0x1701,

        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = 0x1702,

        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = 0x1800,

        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = 0x1801,

        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = 0x1802,

        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = 0x1900,

        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = 0x1901,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = 0x1902,

        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = 0x1903,

        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = 0x1904,

        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = 0x1905,

        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = 0x1906,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = 0x1909,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = 0x190a,

        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
        Bitmap = 0x1a00,

        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = 0x1b00,

        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = 0x1b01,

        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = 0x1b02,

        /// <summary>
        /// Original was GL_RENDER = 0x1C00
        /// </summary>
        Render = 0x1c00,

        /// <summary>
        /// Original was GL_FEEDBACK = 0x1C01
        /// </summary>
        Feedback = 0x1c01,

        /// <summary>
        /// Original was GL_SELECT = 0x1C02
        /// </summary>
        Select = 0x1c02,

        /// <summary>
        /// Original was GL_FLAT = 0x1D00
        /// </summary>
        Flat = 0x1d00,

        /// <summary>
        /// Original was GL_SMOOTH = 0x1D01
        /// </summary>
        Smooth = 0x1d01,

        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = 0x1e00,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1e01,

        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = 0x1e02,

        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = 0x1e03,

        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = 0x1f00,

        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = 0x1f01,

        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = 0x1f02,

        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = 0x1f03,

        /// <summary>
        /// Original was GL_S = 0x2000
        /// </summary>
        S = 0x2000,

        /// <summary>
        /// Original was GL_T = 0x2001
        /// </summary>
        T = 0x2001,

        /// <summary>
        /// Original was GL_R = 0x2002
        /// </summary>
        R = 0x2002,

        /// <summary>
        /// Original was GL_Q = 0x2003
        /// </summary>
        Q = 0x2003,

        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = 0x2100,

        /// <summary>
        /// Original was GL_DECAL = 0x2101
        /// </summary>
        Decal = 0x2101,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_MODE = 0x2200
        /// </summary>
        TextureEnvMode = 0x2200,

        /// <summary>
        /// Original was GL_TEXTURE_ENV_COLOR = 0x2201
        /// </summary>
        TextureEnvColor = 0x2201,

        /// <summary>
        /// Original was GL_TEXTURE_ENV = 0x2300
        /// </summary>
        TextureEnv = 0x2300,

        /// <summary>
        /// Original was GL_EYE_LINEAR = 0x2400
        /// </summary>
        EyeLinear = 0x2400,

        /// <summary>
        /// Original was GL_OBJECT_LINEAR = 0x2401
        /// </summary>
        ObjectLinear = 0x2401,

        /// <summary>
        /// Original was GL_SPHERE_MAP = 0x2402
        /// </summary>
        SphereMap = 0x2402,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE = 0x2500
        /// </summary>
        TextureGenMode = 0x2500,

        /// <summary>
        /// Original was GL_OBJECT_PLANE = 0x2501
        /// </summary>
        ObjectPlane = 0x2501,

        /// <summary>
        /// Original was GL_EYE_PLANE = 0x2502
        /// </summary>
        EyePlane = 0x2502,

        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = 0x2600,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = 0x2700,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = 0x2701,

        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = 0x2702,

        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = 0x2703,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_CLAMP = 0x2900
        /// </summary>
        Clamp = 0x2900,

        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = 0x2901,

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
        /// Original was GL_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        AllAttribBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = 1,

        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = 1
    }
}
