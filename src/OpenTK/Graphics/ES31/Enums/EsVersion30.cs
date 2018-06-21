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

namespace OpenTK.Graphics.ES31
{
    /// <summary>
    /// Used in GL.DrawBuffers, GL.GetBufferParameter and 7 other functions
    /// </summary>
    public enum EsVersion30
    {
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        /// </summary>
        SyncFlushCommandsBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = 0x0008,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = 0x0010,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = 0x0020,

        /// <summary>
        /// Original was GL_READ_BUFFER = 0x0C02
        /// </summary>
        ReadBuffer = 0x0c02,

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
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = 0x140b,

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
        /// Original was GL_MIN = 0x8007
        /// </summary>
        Min = 0x8007,

        /// <summary>
        /// Original was GL_MAX = 0x8008
        /// </summary>
        Max = 0x8008,

        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = 0x8051,

        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = 0x8058,

        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = 0x8059,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D = 0x806A
        /// </summary>
        TextureBinding3D = 0x806a,

        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        /// </summary>
        UnpackSkipImages = 0x806d,

        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        /// </summary>
        UnpackImageHeight = 0x806e,

        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = 0x806f,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = 0x8072,

        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE = 0x8073
        /// </summary>
        Max3DTextureSize = 0x8073,

        /// <summary>
        /// Original was GL_MAX_ELEMENTS_VERTICES = 0x80E8
        /// </summary>
        MaxElementsVertices = 0x80e8,

        /// <summary>
        /// Original was GL_MAX_ELEMENTS_INDICES = 0x80E9
        /// </summary>
        MaxElementsIndices = 0x80e9,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = 0x813c,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = 0x813d,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81A6
        /// </summary>
        DepthComponent24 = 0x81a6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncoding = 0x8210,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        /// </summary>
        FramebufferAttachmentComponentType = 0x8211,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        /// </summary>
        FramebufferAttachmentRedSize = 0x8212,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        /// </summary>
        FramebufferAttachmentGreenSize = 0x8213,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        /// </summary>
        FramebufferAttachmentBlueSize = 0x8214,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        /// </summary>
        FramebufferAttachmentAlphaSize = 0x8215,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        /// </summary>
        FramebufferAttachmentDepthSize = 0x8216,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        /// </summary>
        FramebufferAttachmentStencilSize = 0x8217,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT = 0x8218
        /// </summary>
        FramebufferDefault = 0x8218,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        /// </summary>
        FramebufferUndefined = 0x8219,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        /// </summary>
        DepthStencilAttachment = 0x821a,

        /// <summary>
        /// Original was GL_MAJOR_VERSION = 0x821B
        /// </summary>
        MajorVersion = 0x821b,

        /// <summary>
        /// Original was GL_MINOR_VERSION = 0x821C
        /// </summary>
        MinorVersion = 0x821c,

        /// <summary>
        /// Original was GL_NUM_EXTENSIONS = 0x821D
        /// </summary>
        NumExtensions = 0x821d,

        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = 0x8227,

        /// <summary>
        /// Original was GL_RG_INTEGER = 0x8228
        /// </summary>
        RgInteger = 0x8228,

        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = 0x8229,

        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = 0x822b,

        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = 0x822d,

        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = 0x822e,

        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = 0x822f,

        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = 0x8230,

        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = 0x8231,

        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = 0x8232,

        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = 0x8233,

        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = 0x8234,

        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = 0x8235,

        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = 0x8236,

        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = 0x8237,

        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = 0x8238,

        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = 0x8239,

        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = 0x823a,

        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = 0x823b,

        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = 0x823c,

        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = 0x8257,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF
        /// </summary>
        TextureImmutableLevels = 0x82df,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = 0x8368,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = 0x84f9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8 = 0x84FA
        /// </summary>
        UnsignedInt248 = 0x84fa,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
        /// </summary>
        MaxTextureLodBias = 0x84fd,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING = 0x85B5
        /// </summary>
        VertexArrayBinding = 0x85b5,

        /// <summary>
        /// Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        /// </summary>
        ProgramBinaryLength = 0x8741,

        /// <summary>
        /// Original was GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE
        /// </summary>
        NumProgramBinaryFormats = 0x87fe,

        /// <summary>
        /// Original was GL_PROGRAM_BINARY_FORMATS = 0x87FF
        /// </summary>
        ProgramBinaryFormats = 0x87ff,

        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = 0x8814,

        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = 0x8815,

        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = 0x881a,

        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = 0x881b,

        /// <summary>
        /// Original was GL_MAX_DRAW_BUFFERS = 0x8824
        /// </summary>
        MaxDrawBuffers = 0x8824,

        /// <summary>
        /// Original was GL_DRAW_BUFFER0 = 0x8825
        /// </summary>
        DrawBuffer0 = 0x8825,

        /// <summary>
        /// Original was GL_DRAW_BUFFER1 = 0x8826
        /// </summary>
        DrawBuffer1 = 0x8826,

        /// <summary>
        /// Original was GL_DRAW_BUFFER2 = 0x8827
        /// </summary>
        DrawBuffer2 = 0x8827,

        /// <summary>
        /// Original was GL_DRAW_BUFFER3 = 0x8828
        /// </summary>
        DrawBuffer3 = 0x8828,

        /// <summary>
        /// Original was GL_DRAW_BUFFER4 = 0x8829
        /// </summary>
        DrawBuffer4 = 0x8829,

        /// <summary>
        /// Original was GL_DRAW_BUFFER5 = 0x882A
        /// </summary>
        DrawBuffer5 = 0x882a,

        /// <summary>
        /// Original was GL_DRAW_BUFFER6 = 0x882B
        /// </summary>
        DrawBuffer6 = 0x882b,

        /// <summary>
        /// Original was GL_DRAW_BUFFER7 = 0x882C
        /// </summary>
        DrawBuffer7 = 0x882c,

        /// <summary>
        /// Original was GL_DRAW_BUFFER8 = 0x882D
        /// </summary>
        DrawBuffer8 = 0x882d,

        /// <summary>
        /// Original was GL_DRAW_BUFFER9 = 0x882E
        /// </summary>
        DrawBuffer9 = 0x882e,

        /// <summary>
        /// Original was GL_DRAW_BUFFER10 = 0x882F
        /// </summary>
        DrawBuffer10 = 0x882f,

        /// <summary>
        /// Original was GL_DRAW_BUFFER11 = 0x8830
        /// </summary>
        DrawBuffer11 = 0x8830,

        /// <summary>
        /// Original was GL_DRAW_BUFFER12 = 0x8831
        /// </summary>
        DrawBuffer12 = 0x8831,

        /// <summary>
        /// Original was GL_DRAW_BUFFER13 = 0x8832
        /// </summary>
        DrawBuffer13 = 0x8832,

        /// <summary>
        /// Original was GL_DRAW_BUFFER14 = 0x8833
        /// </summary>
        DrawBuffer14 = 0x8833,

        /// <summary>
        /// Original was GL_DRAW_BUFFER15 = 0x8834
        /// </summary>
        DrawBuffer15 = 0x8834,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = 0x884c,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = 0x884d,

        /// <summary>
        /// Original was GL_COMPARE_REF_TO_TEXTURE = 0x884E
        /// </summary>
        CompareRefToTexture = 0x884e,

        /// <summary>
        /// Original was GL_CURRENT_QUERY = 0x8865
        /// </summary>
        CurrentQuery = 0x8865,

        /// <summary>
        /// Original was GL_QUERY_RESULT = 0x8866
        /// </summary>
        QueryResult = 0x8866,

        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        /// </summary>
        QueryResultAvailable = 0x8867,

        /// <summary>
        /// Original was GL_BUFFER_MAPPED = 0x88BC
        /// </summary>
        BufferMapped = 0x88bc,

        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER = 0x88BD
        /// </summary>
        BufferMapPointer = 0x88bd,

        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = 0x88e1,

        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = 0x88e2,

        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = 0x88e5,

        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = 0x88e6,

        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = 0x88e9,

        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = 0x88ea,

        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = 0x88eb,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = 0x88ec,

        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED
        /// </summary>
        PixelPackBufferBinding = 0x88ed,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF
        /// </summary>
        PixelUnpackBufferBinding = 0x88ef,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = 0x88f0,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = 0x88fd,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        VertexAttribArrayDivisor = 0x88fe,

        /// <summary>
        /// Original was GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF
        /// </summary>
        MaxArrayTextureLayers = 0x88ff,

        /// <summary>
        /// Original was GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904
        /// </summary>
        MinProgramTexelOffset = 0x8904,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905
        /// </summary>
        MaxProgramTexelOffset = 0x8905,

        /// <summary>
        /// Original was GL_SAMPLER_BINDING = 0x8919
        /// </summary>
        SamplerBinding = 0x8919,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = 0x8a11,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_BINDING = 0x8A28
        /// </summary>
        UniformBufferBinding = 0x8a28,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_START = 0x8A29
        /// </summary>
        UniformBufferStart = 0x8a29,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_SIZE = 0x8A2A
        /// </summary>
        UniformBufferSize = 0x8a2a,

        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B
        /// </summary>
        MaxVertexUniformBlocks = 0x8a2b,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D
        /// </summary>
        MaxFragmentUniformBlocks = 0x8a2d,

        /// <summary>
        /// Original was GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E
        /// </summary>
        MaxCombinedUniformBlocks = 0x8a2e,

        /// <summary>
        /// Original was GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F
        /// </summary>
        MaxUniformBufferBindings = 0x8a2f,

        /// <summary>
        /// Original was GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30
        /// </summary>
        MaxUniformBlockSize = 0x8a30,

        /// <summary>
        /// Original was GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31
        /// </summary>
        MaxCombinedVertexUniformComponents = 0x8a31,

        /// <summary>
        /// Original was GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33
        /// </summary>
        MaxCombinedFragmentUniformComponents = 0x8a33,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34
        /// </summary>
        UniformBufferOffsetAlignment = 0x8a34,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = 0x8a35,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = 0x8a36,

        /// <summary>
        /// Original was GL_UNIFORM_TYPE = 0x8A37
        /// </summary>
        UniformType = 0x8a37,

        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = 0x8a38,

        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = 0x8a39,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        /// </summary>
        UniformBlockIndex = 0x8a3a,

        /// <summary>
        /// Original was GL_UNIFORM_OFFSET = 0x8A3B
        /// </summary>
        UniformOffset = 0x8a3b,

        /// <summary>
        /// Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        /// </summary>
        UniformArrayStride = 0x8a3c,

        /// <summary>
        /// Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        /// </summary>
        UniformMatrixStride = 0x8a3d,

        /// <summary>
        /// Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        /// </summary>
        UniformIsRowMajor = 0x8a3e,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        /// </summary>
        UniformBlockBinding = 0x8a3f,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        /// </summary>
        UniformBlockDataSize = 0x8a40,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        /// </summary>
        UniformBlockNameLength = 0x8a41,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        /// </summary>
        UniformBlockActiveUniforms = 0x8a42,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        /// </summary>
        UniformBlockActiveUniformIndices = 0x8a43,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        /// </summary>
        UniformBlockReferencedByVertexShader = 0x8a44,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        /// </summary>
        UniformBlockReferencedByFragmentShader = 0x8a46,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49
        /// </summary>
        MaxFragmentUniformComponents = 0x8b49,

        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A
        /// </summary>
        MaxVertexUniformComponents = 0x8b4a,

        /// <summary>
        /// Original was GL_MAX_VARYING_COMPONENTS = 0x8B4B
        /// </summary>
        MaxVaryingComponents = 0x8b4b,

        /// <summary>
        /// Original was GL_SAMPLER_3D = 0x8B5F
        /// </summary>
        Sampler3D = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8b62,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8b65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8b66,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x2 = 0x8B67
        /// </summary>
        FloatMat3x2 = 0x8b67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x4 = 0x8B68
        /// </summary>
        FloatMat3x4 = 0x8b68,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x2 = 0x8B69
        /// </summary>
        FloatMat4x2 = 0x8b69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = 0x8b6a,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHint = 0x8b8b,

        /// <summary>
        /// Original was GL_UNSIGNED_NORMALIZED = 0x8C17
        /// </summary>
        UnsignedNormalized = 0x8c17,

        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = 0x8c1a,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        /// </summary>
        TextureBinding2DArray = 0x8c1d,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        /// </summary>
        AnySamplesPassed = 0x8c2f,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = 0x8c3a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = 0x8c3b,

        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = 0x8c3d,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
        /// </summary>
        UnsignedInt5999Rev = 0x8c3e,

        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = 0x8c43,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = 0x8c76,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = 0x8c7f,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
        /// </summary>
        MaxTransformFeedbackSeparateComponents = 0x8c80,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = 0x8c83,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = 0x8c84,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = 0x8c85,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = 0x8c88,

        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD = 0x8C89
        /// </summary>
        RasterizerDiscard = 0x8c89,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A
        /// </summary>
        MaxTransformFeedbackInterleavedComponents = 0x8c8a,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B
        /// </summary>
        MaxTransformFeedbackSeparateAttribs = 0x8c8b,

        /// <summary>
        /// Original was GL_INTERLEAVED_ATTRIBS = 0x8C8C
        /// </summary>
        InterleavedAttribs = 0x8c8c,

        /// <summary>
        /// Original was GL_SEPARATE_ATTRIBS = 0x8C8D
        /// </summary>
        SeparateAttribs = 0x8c8d,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = 0x8c8f,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6
        /// </summary>
        DrawFramebufferBinding = 0x8ca6,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = 0x8ca8,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = 0x8ca9,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
        /// </summary>
        ReadFramebufferBinding = 0x8caa,

        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        /// </summary>
        RenderbufferSamples = 0x8cab,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = 0x8cac,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = 0x8cad,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = 0x8cd4,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = 0x8cdf,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = 0x8cf0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = 0x8cf1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = 0x8cf2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = 0x8cf3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = 0x8cf4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = 0x8cf5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = 0x8cf6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = 0x8cf7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = 0x8cf8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = 0x8cf9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = 0x8cfa,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = 0x8cfb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = 0x8cfc,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = 0x8cfd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = 0x8cfe,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = 0x8cff,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisample = 0x8d56,

        /// <summary>
        /// Original was GL_MAX_SAMPLES = 0x8D57
        /// </summary>
        MaxSamples = 0x8d57,

        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        /// </summary>
        PrimitiveRestartFixedIndex = 0x8d69,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        /// </summary>
        AnySamplesPassedConservative = 0x8d6a,

        /// <summary>
        /// Original was GL_MAX_ELEMENT_INDEX = 0x8D6B
        /// </summary>
        MaxElementIndex = 0x8d6b,

        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = 0x8d70,

        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = 0x8d71,

        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = 0x8d76,

        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = 0x8d77,

        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = 0x8d7c,

        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = 0x8d7d,

        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = 0x8d82,

        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = 0x8d83,

        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = 0x8d88,

        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = 0x8d89,

        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = 0x8d8e,

        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = 0x8d8f,

        /// <summary>
        /// Original was GL_RED_INTEGER = 0x8D94
        /// </summary>
        RedInteger = 0x8d94,

        /// <summary>
        /// Original was GL_RGB_INTEGER = 0x8D98
        /// </summary>
        RgbInteger = 0x8d98,

        /// <summary>
        /// Original was GL_RGBA_INTEGER = 0x8D99
        /// </summary>
        RgbaInteger = 0x8d99,

        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = 0x8d9f,

        /// <summary>
        /// Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        /// </summary>
        Float32UnsignedInt248Rev = 0x8dad,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARRAY = 0x8DC1
        /// </summary>
        Sampler2DArray = 0x8dc1,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4
        /// </summary>
        Sampler2DArrayShadow = 0x8dc4,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_SHADOW = 0x8DC5
        /// </summary>
        SamplerCubeShadow = 0x8dc5,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        /// </summary>
        UnsignedIntVec2 = 0x8dc6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        /// </summary>
        UnsignedIntVec3 = 0x8dc7,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        /// </summary>
        UnsignedIntVec4 = 0x8dc8,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D = 0x8DCA
        /// </summary>
        IntSampler2D = 0x8dca,

        /// <summary>
        /// Original was GL_INT_SAMPLER_3D = 0x8DCB
        /// </summary>
        IntSampler3D = 0x8dcb,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE = 0x8DCC
        /// </summary>
        IntSamplerCube = 0x8dcc,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
        /// </summary>
        IntSampler2DArray = 0x8dcf,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2
        /// </summary>
        UnsignedIntSampler2D = 0x8dd2,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3
        /// </summary>
        UnsignedIntSampler3D = 0x8dd3,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
        /// </summary>
        UnsignedIntSamplerCube = 0x8dd4,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
        /// </summary>
        UnsignedIntSampler2DArray = 0x8dd7,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = 0x8e22,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackPaused = 0x8e23,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackActive = 0x8e24,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25
        /// </summary>
        TransformFeedbackBinding = 0x8e25,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = 0x8e42,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = 0x8e43,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = 0x8e44,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = 0x8e45,

        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = 0x8f36,

        /// <summary>
        /// Original was GL_COPY_READ_BUFFER_BINDING = 0x8F36
        /// </summary>
        CopyReadBufferBinding = 0x8f36,

        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = 0x8f37,

        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER_BINDING = 0x8F37
        /// </summary>
        CopyWriteBufferBinding = 0x8f37,

        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = 0x8f94,

        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = 0x8f95,

        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = 0x8f96,

        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = 0x8f97,

        /// <summary>
        /// Original was GL_SIGNED_NORMALIZED = 0x8F9C
        /// </summary>
        SignedNormalized = 0x8f9c,

        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = 0x906f,

        /// <summary>
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111
        /// </summary>
        MaxServerWaitTimeout = 0x9111,

        /// <summary>
        /// Original was GL_OBJECT_TYPE = 0x9112
        /// </summary>
        ObjectType = 0x9112,

        /// <summary>
        /// Original was GL_SYNC_CONDITION = 0x9113
        /// </summary>
        SyncCondition = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_STATUS = 0x9114
        /// </summary>
        SyncStatus = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_FLAGS = 0x9115
        /// </summary>
        SyncFlags = 0x9115,

        /// <summary>
        /// Original was GL_SYNC_FENCE = 0x9116
        /// </summary>
        SyncFence = 0x9116,

        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        /// </summary>
        SyncGpuCommandsComplete = 0x9117,

        /// <summary>
        /// Original was GL_UNSIGNALED = 0x9118
        /// </summary>
        Unsignaled = 0x9118,

        /// <summary>
        /// Original was GL_SIGNALED = 0x9119
        /// </summary>
        Signaled = 0x9119,

        /// <summary>
        /// Original was GL_ALREADY_SIGNALED = 0x911A
        /// </summary>
        AlreadySignaled = 0x911a,

        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED = 0x911B
        /// </summary>
        TimeoutExpired = 0x911b,

        /// <summary>
        /// Original was GL_CONDITION_SATISFIED = 0x911C
        /// </summary>
        ConditionSatisfied = 0x911c,

        /// <summary>
        /// Original was GL_WAIT_FAILED = 0x911D
        /// </summary>
        WaitFailed = 0x911d,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        /// </summary>
        BufferAccessFlags = 0x911f,

        /// <summary>
        /// Original was GL_BUFFER_MAP_LENGTH = 0x9120
        /// </summary>
        BufferMapLength = 0x9120,

        /// <summary>
        /// Original was GL_BUFFER_MAP_OFFSET = 0x9121
        /// </summary>
        BufferMapOffset = 0x9121,

        /// <summary>
        /// Original was GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122
        /// </summary>
        MaxVertexOutputComponents = 0x9122,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125
        /// </summary>
        MaxFragmentInputComponents = 0x9125,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
        /// </summary>
        TextureImmutableFormat = 0x912f,

        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = 0x9270,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = 0x9271,

        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = 0x9272,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = 0x9273,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = 0x9274,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = 0x9275,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = 0x9278,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,

        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = 0x9380,

        /// <summary>
        /// Original was GL_INVALID_INDEX = 0xFFFFFFFF
        /// </summary>
        InvalidIndex = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnored = unchecked((int)0xffffffffffffffff)
    }
}
