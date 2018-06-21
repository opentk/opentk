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
    public enum Version43
    {
        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        /// </summary>
        ContextFlagDebugBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_COMPUTE_SHADER_BIT = 0x00000020
        /// </summary>
        ComputeShaderBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        /// </summary>
        ShaderStorageBarrierBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = 0x0503,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = 0x0504,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        /// </summary>
        DebugNextLoggedMessageLength = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = 0x824b,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = 0x8251,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262
        /// </summary>
        MaxComputeSharedMemorySize = 0x8262,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263
        /// </summary>
        MaxComputeUniformComponents = 0x8263,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264
        /// </summary>
        MaxComputeAtomicCounterBuffers = 0x8264,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265
        /// </summary>
        MaxComputeAtomicCounters = 0x8265,

        /// <summary>
        /// Original was GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266
        /// </summary>
        MaxCombinedComputeUniformComponents = 0x8266,

        /// <summary>
        /// Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        /// </summary>
        ComputeWorkGroupSize = 0x8267,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = 0x826a,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        /// </summary>
        DebugSeverityNotification = 0x826b,

        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        /// </summary>
        MaxDebugGroupStackDepth = 0x826c,

        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        /// </summary>
        DebugGroupStackDepth = 0x826d,

        /// <summary>
        /// Original was GL_MAX_UNIFORM_LOCATIONS = 0x826E
        /// </summary>
        MaxUniformLocations = 0x826e,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        /// </summary>
        InternalformatSupported = 0x826f,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_PREFERRED = 0x8270
        /// </summary>
        InternalformatPreferred = 0x8270,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_SIZE = 0x8271
        /// </summary>
        InternalformatRedSize = 0x8271,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
        /// </summary>
        InternalformatGreenSize = 0x8272,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
        /// </summary>
        InternalformatBlueSize = 0x8273,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
        /// </summary>
        InternalformatAlphaSize = 0x8274,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
        /// </summary>
        InternalformatDepthSize = 0x8275,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
        /// </summary>
        InternalformatStencilSize = 0x8276,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
        /// </summary>
        InternalformatSharedSize = 0x8277,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_RED_TYPE = 0x8278
        /// </summary>
        InternalformatRedType = 0x8278,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
        /// </summary>
        InternalformatGreenType = 0x8279,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
        /// </summary>
        InternalformatBlueType = 0x827a,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        /// </summary>
        InternalformatAlphaType = 0x827b,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        /// </summary>
        InternalformatDepthType = 0x827c,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        /// </summary>
        InternalformatStencilType = 0x827d,

        /// <summary>
        /// Original was GL_MAX_WIDTH = 0x827E
        /// </summary>
        MaxWidth = 0x827e,

        /// <summary>
        /// Original was GL_MAX_HEIGHT = 0x827F
        /// </summary>
        MaxHeight = 0x827f,

        /// <summary>
        /// Original was GL_MAX_DEPTH = 0x8280
        /// </summary>
        MaxDepth = 0x8280,

        /// <summary>
        /// Original was GL_MAX_LAYERS = 0x8281
        /// </summary>
        MaxLayers = 0x8281,

        /// <summary>
        /// Original was GL_MAX_COMBINED_DIMENSIONS = 0x8282
        /// </summary>
        MaxCombinedDimensions = 0x8282,

        /// <summary>
        /// Original was GL_COLOR_COMPONENTS = 0x8283
        /// </summary>
        ColorComponents = 0x8283,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENTS = 0x8284
        /// </summary>
        DepthComponents = 0x8284,

        /// <summary>
        /// Original was GL_STENCIL_COMPONENTS = 0x8285
        /// </summary>
        StencilComponents = 0x8285,

        /// <summary>
        /// Original was GL_COLOR_RENDERABLE = 0x8286
        /// </summary>
        ColorRenderable = 0x8286,

        /// <summary>
        /// Original was GL_DEPTH_RENDERABLE = 0x8287
        /// </summary>
        DepthRenderable = 0x8287,

        /// <summary>
        /// Original was GL_STENCIL_RENDERABLE = 0x8288
        /// </summary>
        StencilRenderable = 0x8288,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE = 0x8289
        /// </summary>
        FramebufferRenderable = 0x8289,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
        /// </summary>
        FramebufferRenderableLayered = 0x828a,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BLEND = 0x828B
        /// </summary>
        FramebufferBlend = 0x828b,

        /// <summary>
        /// Original was GL_READ_PIXELS = 0x828C
        /// </summary>
        ReadPixels = 0x828c,

        /// <summary>
        /// Original was GL_READ_PIXELS_FORMAT = 0x828D
        /// </summary>
        ReadPixelsFormat = 0x828d,

        /// <summary>
        /// Original was GL_READ_PIXELS_TYPE = 0x828E
        /// </summary>
        ReadPixelsType = 0x828e,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        /// </summary>
        TextureImageFormat = 0x828f,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_TYPE = 0x8290
        /// </summary>
        TextureImageType = 0x8290,

        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
        /// </summary>
        GetTextureImageFormat = 0x8291,

        /// <summary>
        /// Original was GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
        /// </summary>
        GetTextureImageType = 0x8292,

        /// <summary>
        /// Original was GL_MIPMAP = 0x8293
        /// </summary>
        Mipmap = 0x8293,

        /// <summary>
        /// Original was GL_MANUAL_GENERATE_MIPMAP = 0x8294
        /// </summary>
        ManualGenerateMipmap = 0x8294,

        /// <summary>
        /// Original was GL_AUTO_GENERATE_MIPMAP = 0x8295
        /// </summary>
        AutoGenerateMipmap = 0x8295,

        /// <summary>
        /// Original was GL_COLOR_ENCODING = 0x8296
        /// </summary>
        ColorEncoding = 0x8296,

        /// <summary>
        /// Original was GL_SRGB_READ = 0x8297
        /// </summary>
        SrgbRead = 0x8297,

        /// <summary>
        /// Original was GL_SRGB_WRITE = 0x8298
        /// </summary>
        SrgbWrite = 0x8298,

        /// <summary>
        /// Original was GL_FILTER = 0x829A
        /// </summary>
        Filter = 0x829a,

        /// <summary>
        /// Original was GL_VERTEX_TEXTURE = 0x829B
        /// </summary>
        VertexTexture = 0x829b,

        /// <summary>
        /// Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        /// </summary>
        TessControlTexture = 0x829c,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        /// </summary>
        TessEvaluationTexture = 0x829d,

        /// <summary>
        /// Original was GL_GEOMETRY_TEXTURE = 0x829E
        /// </summary>
        GeometryTexture = 0x829e,

        /// <summary>
        /// Original was GL_FRAGMENT_TEXTURE = 0x829F
        /// </summary>
        FragmentTexture = 0x829f,

        /// <summary>
        /// Original was GL_COMPUTE_TEXTURE = 0x82A0
        /// </summary>
        ComputeTexture = 0x82a0,

        /// <summary>
        /// Original was GL_TEXTURE_SHADOW = 0x82A1
        /// </summary>
        TextureShadow = 0x82a1,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER = 0x82A2
        /// </summary>
        TextureGather = 0x82a2,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        /// </summary>
        TextureGatherShadow = 0x82a3,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        /// </summary>
        ShaderImageLoad = 0x82a4,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_STORE = 0x82A5
        /// </summary>
        ShaderImageStore = 0x82a5,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        /// </summary>
        ShaderImageAtomic = 0x82a6,

        /// <summary>
        /// Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        /// </summary>
        ImageTexelSize = 0x82a7,

        /// <summary>
        /// Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        /// </summary>
        ImageCompatibilityClass = 0x82a8,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        /// </summary>
        ImagePixelFormat = 0x82a9,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        /// </summary>
        ImagePixelType = 0x82aa,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        /// </summary>
        SimultaneousTextureAndDepthTest = 0x82ac,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        /// </summary>
        SimultaneousTextureAndStencilTest = 0x82ad,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        /// </summary>
        SimultaneousTextureAndDepthWrite = 0x82ae,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        /// </summary>
        SimultaneousTextureAndStencilWrite = 0x82af,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        /// </summary>
        TextureCompressedBlockWidth = 0x82b1,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        /// </summary>
        TextureCompressedBlockHeight = 0x82b2,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        /// </summary>
        TextureCompressedBlockSize = 0x82b3,

        /// <summary>
        /// Original was GL_CLEAR_BUFFER = 0x82B4
        /// </summary>
        ClearBuffer = 0x82b4,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW = 0x82B5
        /// </summary>
        TextureView = 0x82b5,

        /// <summary>
        /// Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        /// </summary>
        ViewCompatibilityClass = 0x82b6,

        /// <summary>
        /// Original was GL_FULL_SUPPORT = 0x82B7
        /// </summary>
        FullSupport = 0x82b7,

        /// <summary>
        /// Original was GL_CAVEAT_SUPPORT = 0x82B8
        /// </summary>
        CaveatSupport = 0x82b8,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_4_X_32 = 0x82B9
        /// </summary>
        ImageClass4X32 = 0x82b9,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_2_X_32 = 0x82BA
        /// </summary>
        ImageClass2X32 = 0x82ba,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_1_X_32 = 0x82BB
        /// </summary>
        ImageClass1X32 = 0x82bb,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_4_X_16 = 0x82BC
        /// </summary>
        ImageClass4X16 = 0x82bc,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_2_X_16 = 0x82BD
        /// </summary>
        ImageClass2X16 = 0x82bd,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_1_X_16 = 0x82BE
        /// </summary>
        ImageClass1X16 = 0x82be,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_4_X_8 = 0x82BF
        /// </summary>
        ImageClass4X8 = 0x82bf,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_2_X_8 = 0x82C0
        /// </summary>
        ImageClass2X8 = 0x82c0,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_1_X_8 = 0x82C1
        /// </summary>
        ImageClass1X8 = 0x82c1,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_11_11_10 = 0x82C2
        /// </summary>
        ImageClass111110 = 0x82c2,

        /// <summary>
        /// Original was GL_IMAGE_CLASS_10_10_10_2 = 0x82C3
        /// </summary>
        ImageClass1010102 = 0x82c3,

        /// <summary>
        /// Original was GL_VIEW_CLASS_128_BITS = 0x82C4
        /// </summary>
        ViewClass128Bits = 0x82c4,

        /// <summary>
        /// Original was GL_VIEW_CLASS_96_BITS = 0x82C5
        /// </summary>
        ViewClass96Bits = 0x82c5,

        /// <summary>
        /// Original was GL_VIEW_CLASS_64_BITS = 0x82C6
        /// </summary>
        ViewClass64Bits = 0x82c6,

        /// <summary>
        /// Original was GL_VIEW_CLASS_48_BITS = 0x82C7
        /// </summary>
        ViewClass48Bits = 0x82c7,

        /// <summary>
        /// Original was GL_VIEW_CLASS_32_BITS = 0x82C8
        /// </summary>
        ViewClass32Bits = 0x82c8,

        /// <summary>
        /// Original was GL_VIEW_CLASS_24_BITS = 0x82C9
        /// </summary>
        ViewClass24Bits = 0x82c9,

        /// <summary>
        /// Original was GL_VIEW_CLASS_16_BITS = 0x82CA
        /// </summary>
        ViewClass16Bits = 0x82ca,

        /// <summary>
        /// Original was GL_VIEW_CLASS_8_BITS = 0x82CB
        /// </summary>
        ViewClass8Bits = 0x82cb,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC
        /// </summary>
        ViewClassS3tcDxt1Rgb = 0x82cc,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD
        /// </summary>
        ViewClassS3tcDxt1Rgba = 0x82cd,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE
        /// </summary>
        ViewClassS3tcDxt3Rgba = 0x82ce,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF
        /// </summary>
        ViewClassS3tcDxt5Rgba = 0x82cf,

        /// <summary>
        /// Original was GL_VIEW_CLASS_RGTC1_RED = 0x82D0
        /// </summary>
        ViewClassRgtc1Red = 0x82d0,

        /// <summary>
        /// Original was GL_VIEW_CLASS_RGTC2_RG = 0x82D1
        /// </summary>
        ViewClassRgtc2Rg = 0x82d1,

        /// <summary>
        /// Original was GL_VIEW_CLASS_BPTC_UNORM = 0x82D2
        /// </summary>
        ViewClassBptcUnorm = 0x82d2,

        /// <summary>
        /// Original was GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3
        /// </summary>
        ViewClassBptcFloat = 0x82d3,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_BINDING = 0x82D4
        /// </summary>
        VertexAttribBinding = 0x82d4,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        /// </summary>
        VertexAttribRelativeOffset = 0x82d5,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_DIVISOR = 0x82D6
        /// </summary>
        VertexBindingDivisor = 0x82d6,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_OFFSET = 0x82D7
        /// </summary>
        VertexBindingOffset = 0x82d7,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_STRIDE = 0x82D8
        /// </summary>
        VertexBindingStride = 0x82d8,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9
        /// </summary>
        MaxVertexAttribRelativeOffset = 0x82d9,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA
        /// </summary>
        MaxVertexAttribBindings = 0x82da,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB
        /// </summary>
        TextureViewMinLevel = 0x82db,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC
        /// </summary>
        TextureViewNumLevels = 0x82dc,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD
        /// </summary>
        TextureViewMinLayer = 0x82dd,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE
        /// </summary>
        TextureViewNumLayers = 0x82de,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF
        /// </summary>
        TextureImmutableLevels = 0x82df,

        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = 0x82e0,

        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = 0x82e1,

        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = 0x82e2,

        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = 0x82e3,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = 0x82e4,

        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = 0x82e6,

        /// <summary>
        /// Original was GL_DISPLAY_LIST = 0x82E7
        /// </summary>
        DisplayList = 0x82e7,

        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH = 0x82E8
        /// </summary>
        MaxLabelLength = 0x82e8,

        /// <summary>
        /// Original was GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9
        /// </summary>
        NumShadingLanguageVersions = 0x82e9,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        /// </summary>
        VertexAttribArrayLong = 0x874e,

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
        /// Original was GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39
        /// </summary>
        MaxCombinedShaderOutputResources = 0x8f39,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_BUFFER = 0x8F4F
        /// </summary>
        VertexBindingBuffer = 0x8f4f,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = 0x90d2,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3
        /// </summary>
        ShaderStorageBufferBinding = 0x90d3,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_START = 0x90D4
        /// </summary>
        ShaderStorageBufferStart = 0x90d4,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5
        /// </summary>
        ShaderStorageBufferSize = 0x90d5,

        /// <summary>
        /// Original was GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6
        /// </summary>
        MaxVertexShaderStorageBlocks = 0x90d6,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7
        /// </summary>
        MaxGeometryShaderStorageBlocks = 0x90d7,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8
        /// </summary>
        MaxTessControlShaderStorageBlocks = 0x90d8,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9
        /// </summary>
        MaxTessEvaluationShaderStorageBlocks = 0x90d9,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA
        /// </summary>
        MaxFragmentShaderStorageBlocks = 0x90da,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB
        /// </summary>
        MaxComputeShaderStorageBlocks = 0x90db,

        /// <summary>
        /// Original was GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC
        /// </summary>
        MaxCombinedShaderStorageBlocks = 0x90dc,

        /// <summary>
        /// Original was GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD
        /// </summary>
        MaxShaderStorageBufferBindings = 0x90dd,

        /// <summary>
        /// Original was GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE
        /// </summary>
        MaxShaderStorageBlockSize = 0x90de,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF
        /// </summary>
        ShaderStorageBufferOffsetAlignment = 0x90df,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        /// </summary>
        DepthStencilTextureMode = 0x90ea,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB
        /// </summary>
        MaxComputeWorkGroupInvocations = 0x90eb,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        /// </summary>
        UniformBlockReferencedByComputeShader = 0x90ec,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        /// </summary>
        AtomicCounterBufferReferencedByComputeShader = 0x90ed,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = 0x90ee,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF
        /// </summary>
        DispatchIndirectBufferBinding = 0x90ef,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        /// </summary>
        MaxDebugMessageLength = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        /// </summary>
        MaxDebugLoggedMessages = 0x9144,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        /// </summary>
        DebugLoggedMessages = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = 0x9148,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER_OFFSET = 0x919D
        /// </summary>
        TextureBufferOffset = 0x919d,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER_SIZE = 0x919E
        /// </summary>
        TextureBufferSize = 0x919e,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F
        /// </summary>
        TextureBufferOffsetAlignment = 0x919f,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = 0x91b9,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB
        /// </summary>
        MaxComputeUniformBlocks = 0x91bb,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC
        /// </summary>
        MaxComputeTextureImageUnits = 0x91bc,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD
        /// </summary>
        MaxComputeImageUniforms = 0x91bd,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE
        /// </summary>
        MaxComputeWorkGroupCount = 0x91be,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
        /// </summary>
        MaxComputeWorkGroupSize = 0x91bf,

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
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = 0x92e0,

        /// <summary>
        /// Original was GL_UNIFORM = 0x92E1
        /// </summary>
        Uniform = 0x92e1,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK = 0x92E2
        /// </summary>
        UniformBlock = 0x92e2,

        /// <summary>
        /// Original was GL_PROGRAM_INPUT = 0x92E3
        /// </summary>
        ProgramInput = 0x92e3,

        /// <summary>
        /// Original was GL_PROGRAM_OUTPUT = 0x92E4
        /// </summary>
        ProgramOutput = 0x92e4,

        /// <summary>
        /// Original was GL_BUFFER_VARIABLE = 0x92E5
        /// </summary>
        BufferVariable = 0x92e5,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        /// </summary>
        ShaderStorageBlock = 0x92e6,

        /// <summary>
        /// Original was GL_IS_PER_PATCH = 0x92E7
        /// </summary>
        IsPerPatch = 0x92e7,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE = 0x92E8
        /// </summary>
        VertexSubroutine = 0x92e8,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        /// </summary>
        TessControlSubroutine = 0x92e9,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        /// </summary>
        TessEvaluationSubroutine = 0x92ea,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        /// </summary>
        GeometrySubroutine = 0x92eb,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        /// </summary>
        FragmentSubroutine = 0x92ec,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        /// </summary>
        ComputeSubroutine = 0x92ed,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        /// </summary>
        VertexSubroutineUniform = 0x92ee,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        /// </summary>
        TessControlSubroutineUniform = 0x92ef,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        /// </summary>
        TessEvaluationSubroutineUniform = 0x92f0,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        /// </summary>
        GeometrySubroutineUniform = 0x92f1,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        /// </summary>
        FragmentSubroutineUniform = 0x92f2,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        /// </summary>
        ComputeSubroutineUniform = 0x92f3,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        /// </summary>
        TransformFeedbackVarying = 0x92f4,

        /// <summary>
        /// Original was GL_ACTIVE_RESOURCES = 0x92F5
        /// </summary>
        ActiveResources = 0x92f5,

        /// <summary>
        /// Original was GL_MAX_NAME_LENGTH = 0x92F6
        /// </summary>
        MaxNameLength = 0x92f6,

        /// <summary>
        /// Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        /// </summary>
        MaxNumActiveVariables = 0x92f7,

        /// <summary>
        /// Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        /// </summary>
        MaxNumCompatibleSubroutines = 0x92f8,

        /// <summary>
        /// Original was GL_NAME_LENGTH = 0x92F9
        /// </summary>
        NameLength = 0x92f9,

        /// <summary>
        /// Original was GL_TYPE = 0x92FA
        /// </summary>
        Type = 0x92fa,

        /// <summary>
        /// Original was GL_ARRAY_SIZE = 0x92FB
        /// </summary>
        ArraySize = 0x92fb,

        /// <summary>
        /// Original was GL_OFFSET = 0x92FC
        /// </summary>
        Offset = 0x92fc,

        /// <summary>
        /// Original was GL_BLOCK_INDEX = 0x92FD
        /// </summary>
        BlockIndex = 0x92fd,

        /// <summary>
        /// Original was GL_ARRAY_STRIDE = 0x92FE
        /// </summary>
        ArrayStride = 0x92fe,

        /// <summary>
        /// Original was GL_MATRIX_STRIDE = 0x92FF
        /// </summary>
        MatrixStride = 0x92ff,

        /// <summary>
        /// Original was GL_IS_ROW_MAJOR = 0x9300
        /// </summary>
        IsRowMajor = 0x9300,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301
        /// </summary>
        AtomicCounterBufferIndex = 0x9301,

        /// <summary>
        /// Original was GL_BUFFER_BINDING = 0x9302
        /// </summary>
        BufferBinding = 0x9302,

        /// <summary>
        /// Original was GL_BUFFER_DATA_SIZE = 0x9303
        /// </summary>
        BufferDataSize = 0x9303,

        /// <summary>
        /// Original was GL_NUM_ACTIVE_VARIABLES = 0x9304
        /// </summary>
        NumActiveVariables = 0x9304,

        /// <summary>
        /// Original was GL_ACTIVE_VARIABLES = 0x9305
        /// </summary>
        ActiveVariables = 0x9305,

        /// <summary>
        /// Original was GL_REFERENCED_BY_VERTEX_SHADER = 0x9306
        /// </summary>
        ReferencedByVertexShader = 0x9306,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307
        /// </summary>
        ReferencedByTessControlShader = 0x9307,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308
        /// </summary>
        ReferencedByTessEvaluationShader = 0x9308,

        /// <summary>
        /// Original was GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309
        /// </summary>
        ReferencedByGeometryShader = 0x9309,

        /// <summary>
        /// Original was GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A
        /// </summary>
        ReferencedByFragmentShader = 0x930a,

        /// <summary>
        /// Original was GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B
        /// </summary>
        ReferencedByComputeShader = 0x930b,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_SIZE = 0x930C
        /// </summary>
        TopLevelArraySize = 0x930c,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D
        /// </summary>
        TopLevelArrayStride = 0x930d,

        /// <summary>
        /// Original was GL_LOCATION = 0x930E
        /// </summary>
        Location = 0x930e,

        /// <summary>
        /// Original was GL_LOCATION_INDEX = 0x930F
        /// </summary>
        LocationIndex = 0x930f,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = 0x9310,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = 0x9311,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        /// </summary>
        FramebufferDefaultLayers = 0x9312,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = 0x9313,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = 0x9314,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_WIDTH = 0x9315
        /// </summary>
        MaxFramebufferWidth = 0x9315,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316
        /// </summary>
        MaxFramebufferHeight = 0x9316,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_LAYERS = 0x9317
        /// </summary>
        MaxFramebufferLayers = 0x9317,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318
        /// </summary>
        MaxFramebufferSamples = 0x9318
    }
}
