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
        /// Original was GL_FALSE = 0x0
        /// </summary>
        False = 0x0,

        /// <summary>
        /// Original was GL_NO_ERROR = 0x0
        /// </summary>
        NoError = 0x0,

        /// <summary>
        /// Original was GL_NONE = 0x0
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Original was GL_POINTS = 0x0
        /// </summary>
        Points = 0x0,

        /// <summary>
        /// Original was GL_ZERO = 0x0
        /// </summary>
        Zero = 0x0,

        /// <summary>
        /// Original was GL_LINES = 0x1
        /// </summary>
        Lines = 0x1,

        /// <summary>
        /// Original was GL_ONE = 0x1
        /// </summary>
        One = 0x1,

        /// <summary>
        /// Original was GL_TRUE = 0x1
        /// </summary>
        True = 0x1,

        /// <summary>
        /// Original was GL_LINE_LOOP = 0x2
        /// </summary>
        LineLoop = 0x2,

        /// <summary>
        /// Original was GL_LINE_STRIP = 0x3
        /// </summary>
        LineStrip = 0x3,

        /// <summary>
        /// Original was GL_TRIANGLES = 0x4
        /// </summary>
        Triangles = 0x4,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x5
        /// </summary>
        TriangleStrip = 0x5,

        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x6
        /// </summary>
        TriangleFan = 0x6,

        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x100
        /// </summary>
        DepthBufferBit = 0x100,

        /// <summary>
        /// Original was GL_NEVER = 0x200
        /// </summary>
        Never = 0x200,

        /// <summary>
        /// Original was GL_LESS = 0x201
        /// </summary>
        Less = 0x201,

        /// <summary>
        /// Original was GL_EQUAL = 0x202
        /// </summary>
        Equal = 0x202,

        /// <summary>
        /// Original was GL_LEQUAL = 0x203
        /// </summary>
        Lequal = 0x203,

        /// <summary>
        /// Original was GL_GREATER = 0x204
        /// </summary>
        Greater = 0x204,

        /// <summary>
        /// Original was GL_NOTEQUAL = 0x205
        /// </summary>
        Notequal = 0x205,

        /// <summary>
        /// Original was GL_GEQUAL = 0x206
        /// </summary>
        Gequal = 0x206,

        /// <summary>
        /// Original was GL_ALWAYS = 0x207
        /// </summary>
        Always = 0x207,

        /// <summary>
        /// Original was GL_SRC_COLOR = 0x300
        /// </summary>
        SrcColor = 0x300,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x301
        /// </summary>
        OneMinusSrcColor = 0x301,

        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x302
        /// </summary>
        SrcAlpha = 0x302,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x303
        /// </summary>
        OneMinusSrcAlpha = 0x303,

        /// <summary>
        /// Original was GL_DST_ALPHA = 0x304
        /// </summary>
        DstAlpha = 0x304,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x305
        /// </summary>
        OneMinusDstAlpha = 0x305,

        /// <summary>
        /// Original was GL_DST_COLOR = 0x306
        /// </summary>
        DstColor = 0x306,

        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x307
        /// </summary>
        OneMinusDstColor = 0x307,

        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x308
        /// </summary>
        SrcAlphaSaturate = 0x308,

        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x400
        /// </summary>
        FrontLeft = 0x400,

        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x400
        /// </summary>
        StencilBufferBit = 0x400,

        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x401
        /// </summary>
        FrontRight = 0x401,

        /// <summary>
        /// Original was GL_BACK_LEFT = 0x402
        /// </summary>
        BackLeft = 0x402,

        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x403
        /// </summary>
        BackRight = 0x403,

        /// <summary>
        /// Original was GL_FRONT = 0x404
        /// </summary>
        Front = 0x404,

        /// <summary>
        /// Original was GL_BACK = 0x405
        /// </summary>
        Back = 0x405,

        /// <summary>
        /// Original was GL_LEFT = 0x406
        /// </summary>
        Left = 0x406,

        /// <summary>
        /// Original was GL_RIGHT = 0x407
        /// </summary>
        Right = 0x407,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x408
        /// </summary>
        FrontAndBack = 0x408,

        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x500
        /// </summary>
        InvalidEnum = 0x500,

        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x501
        /// </summary>
        InvalidValue = 0x501,

        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x502
        /// </summary>
        InvalidOperation = 0x502,

        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x505
        /// </summary>
        OutOfMemory = 0x505,

        /// <summary>
        /// Original was GL_CW = 0x900
        /// </summary>
        CW = 0x900,

        /// <summary>
        /// Original was GL_CCW = 0x901
        /// </summary>
        Ccw = 0x901,

        /// <summary>
        /// Original was GL_POINT_SIZE = 0xB11
        /// </summary>
        PointSize = 0xB11,

        /// <summary>
        /// Original was GL_POINT_SIZE_RANGE = 0xB12
        /// </summary>
        PointSizeRange = 0xB12,

        /// <summary>
        /// Original was GL_POINT_SIZE_GRANULARITY = 0xB13
        /// </summary>
        PointSizeGranularity = 0xB13,

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
        /// Original was GL_LINE_WIDTH_GRANULARITY = 0xB23
        /// </summary>
        LineWidthGranularity = 0xB23,

        /// <summary>
        /// Original was GL_POLYGON_MODE = 0xB40
        /// </summary>
        PolygonMode = 0xB40,

        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0xB41
        /// </summary>
        PolygonSmooth = 0xB41,

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
        /// Original was GL_VIEWPORT = 0xBA2
        /// </summary>
        Viewport = 0xBA2,

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
        /// Original was GL_DRAW_BUFFER = 0xC01
        /// </summary>
        DrawBuffer = 0xC01,

        /// <summary>
        /// Original was GL_READ_BUFFER = 0xC02
        /// </summary>
        ReadBuffer = 0xC02,

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
        /// Original was GL_TEXTURE1_D = 0xDE0
        /// </summary>
        Texture1D = 0xDE0,

        /// <summary>
        /// Original was GL_TEXTURE2_D = 0xDE1
        /// </summary>
        Texture2D = 0xDE1,

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
        Invert = 0x150A,

        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = 0x150B,

        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = 0x150C,

        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = 0x150D,

        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = 0x150E,

        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = 0x150F,

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
        Point = 0x1B00,

        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = 0x1B01,

        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = 0x1B02,

        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = 0x1E00,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1E01,

        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = 0x1E02,

        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = 0x1E03,

        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = 0x1F00,

        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = 0x1F01,

        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = 0x1F02,

        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = 0x1F03,

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
        /// Original was GL_COLOR_BUFFER_BIT = 0x4000
        /// </summary>
        ColorBufferBit = 0x4000
    }
}
