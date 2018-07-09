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
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = 0x00000100,

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = 0x00000400,

        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = 0x00004000,

        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = 0x0001,

        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = 0x0002,

        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = 0x0003,

        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = 0x0004,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = 0x0005,

        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = 0x0006,

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
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = 0x0505,

        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = 0x0900,

        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = 0x0901,

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
        /// Original was GL_POLYGON_MODE = 0x0B40
        /// </summary>
        PolygonMode = 0x0b40,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = 0x0b41,

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
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = 0x0ba2,

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
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = 0x0c22,

        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = 0x0c23,

        /// <summary>
        /// Original was GL_DOUBLEBUFFER = 0x0C32
        /// </summary>
        Doublebuffer = 0x0c32,

        /// <summary>
        /// Original was GL_STEREO = 0x0C33
        /// </summary>
        Stereo = 0x0c33,

        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = 0x0c52,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = 0x0c53,

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
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = 0x0d33,

        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = 0x0d3a,

        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = 0x0d50,

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
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = 0x1004,

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
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = 0x2901,

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
