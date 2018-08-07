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
    public enum ArbInternalformatQuery2
    {
        /// <summary>
        /// Original was GL_TEXTURE1_D = 0xDE0
        /// </summary>
        Texture1D = 0xDE0,

        /// <summary>
        /// Original was GL_TEXTURE2_D = 0xDE1
        /// </summary>
        Texture2D = 0xDE1,

        /// <summary>
        /// Original was GL_TEXTURE3_D = 0x806F
        /// </summary>
        Texture3D = 0x806F,

        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = 0x80A9,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        /// </summary>
        InternalformatSupported = 0x826F,

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
        InternalformatBlueType = 0x827A,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        /// </summary>
        InternalformatAlphaType = 0x827B,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        /// </summary>
        InternalformatDepthType = 0x827C,

        /// <summary>
        /// Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        /// </summary>
        InternalformatStencilType = 0x827D,

        /// <summary>
        /// Original was GL_MAX_WIDTH = 0x827E
        /// </summary>
        MaxWidth = 0x827E,

        /// <summary>
        /// Original was GL_MAX_HEIGHT = 0x827F
        /// </summary>
        MaxHeight = 0x827F,

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
        FramebufferRenderableLayered = 0x828A,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BLEND = 0x828B
        /// </summary>
        FramebufferBlend = 0x828B,

        /// <summary>
        /// Original was GL_READ_PIXELS = 0x828C
        /// </summary>
        ReadPixels = 0x828C,

        /// <summary>
        /// Original was GL_READ_PIXELS_FORMAT = 0x828D
        /// </summary>
        ReadPixelsFormat = 0x828D,

        /// <summary>
        /// Original was GL_READ_PIXELS_TYPE = 0x828E
        /// </summary>
        ReadPixelsType = 0x828E,

        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        /// </summary>
        TextureImageFormat = 0x828F,

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
        /// Original was GL_SRGB_DECODE_ARB = 0x8299
        /// </summary>
        SrgbDecodeArb = 0x8299,

        /// <summary>
        /// Original was GL_FILTER = 0x829A
        /// </summary>
        Filter = 0x829A,

        /// <summary>
        /// Original was GL_VERTEX_TEXTURE = 0x829B
        /// </summary>
        VertexTexture = 0x829B,

        /// <summary>
        /// Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        /// </summary>
        TessControlTexture = 0x829C,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        /// </summary>
        TessEvaluationTexture = 0x829D,

        /// <summary>
        /// Original was GL_GEOMETRY_TEXTURE = 0x829E
        /// </summary>
        GeometryTexture = 0x829E,

        /// <summary>
        /// Original was GL_FRAGMENT_TEXTURE = 0x829F
        /// </summary>
        FragmentTexture = 0x829F,

        /// <summary>
        /// Original was GL_COMPUTE_TEXTURE = 0x82A0
        /// </summary>
        ComputeTexture = 0x82A0,

        /// <summary>
        /// Original was GL_TEXTURE_SHADOW = 0x82A1
        /// </summary>
        TextureShadow = 0x82A1,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER = 0x82A2
        /// </summary>
        TextureGather = 0x82A2,

        /// <summary>
        /// Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        /// </summary>
        TextureGatherShadow = 0x82A3,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        /// </summary>
        ShaderImageLoad = 0x82A4,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_STORE = 0x82A5
        /// </summary>
        ShaderImageStore = 0x82A5,

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        /// </summary>
        ShaderImageAtomic = 0x82A6,

        /// <summary>
        /// Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        /// </summary>
        ImageTexelSize = 0x82A7,

        /// <summary>
        /// Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        /// </summary>
        ImageCompatibilityClass = 0x82A8,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        /// </summary>
        ImagePixelFormat = 0x82A9,

        /// <summary>
        /// Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        /// </summary>
        ImagePixelType = 0x82AA,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        /// </summary>
        SimultaneousTextureAndDepthTest = 0x82AC,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        /// </summary>
        SimultaneousTextureAndStencilTest = 0x82AD,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        /// </summary>
        SimultaneousTextureAndDepthWrite = 0x82AE,

        /// <summary>
        /// Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        /// </summary>
        SimultaneousTextureAndStencilWrite = 0x82AF,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        /// </summary>
        TextureCompressedBlockWidth = 0x82B1,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        /// </summary>
        TextureCompressedBlockHeight = 0x82B2,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        /// </summary>
        TextureCompressedBlockSize = 0x82B3,

        /// <summary>
        /// Original was GL_CLEAR_BUFFER = 0x82B4
        /// </summary>
        ClearBuffer = 0x82B4,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW = 0x82B5
        /// </summary>
        TextureView = 0x82B5,

        /// <summary>
        /// Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        /// </summary>
        ViewCompatibilityClass = 0x82B6,

        /// <summary>
        /// Original was GL_FULL_SUPPORT = 0x82B7
        /// </summary>
        FullSupport = 0x82B7,

        /// <summary>
        /// Original was GL_CAVEAT_SUPPORT = 0x82B8
        /// </summary>
        CaveatSupport = 0x82B8,

        /// <summary>
        /// Original was GL_IMAGE_CLASS4_X32 = 0x82B9
        /// </summary>
        ImageClass4X32 = 0x82B9,

        /// <summary>
        /// Original was GL_IMAGE_CLASS2_X32 = 0x82BA
        /// </summary>
        ImageClass2X32 = 0x82BA,

        /// <summary>
        /// Original was GL_IMAGE_CLASS1_X32 = 0x82BB
        /// </summary>
        ImageClass1X32 = 0x82BB,

        /// <summary>
        /// Original was GL_IMAGE_CLASS4_X16 = 0x82BC
        /// </summary>
        ImageClass4X16 = 0x82BC,

        /// <summary>
        /// Original was GL_IMAGE_CLASS2_X16 = 0x82BD
        /// </summary>
        ImageClass2X16 = 0x82BD,

        /// <summary>
        /// Original was GL_IMAGE_CLASS1_X16 = 0x82BE
        /// </summary>
        ImageClass1X16 = 0x82BE,

        /// <summary>
        /// Original was GL_IMAGE_CLASS4_X8 = 0x82BF
        /// </summary>
        ImageClass4X8 = 0x82BF,

        /// <summary>
        /// Original was GL_IMAGE_CLASS2_X8 = 0x82C0
        /// </summary>
        ImageClass2X8 = 0x82C0,

        /// <summary>
        /// Original was GL_IMAGE_CLASS1_X8 = 0x82C1
        /// </summary>
        ImageClass1X8 = 0x82C1,

        /// <summary>
        /// Original was GL_IMAGE_CLASS111110 = 0x82C2
        /// </summary>
        ImageClass111110 = 0x82C2,

        /// <summary>
        /// Original was GL_IMAGE_CLASS1010102 = 0x82C3
        /// </summary>
        ImageClass1010102 = 0x82C3,

        /// <summary>
        /// Original was GL_VIEW_CLASS128_BITS = 0x82C4
        /// </summary>
        ViewClass128Bits = 0x82C4,

        /// <summary>
        /// Original was GL_VIEW_CLASS96_BITS = 0x82C5
        /// </summary>
        ViewClass96Bits = 0x82C5,

        /// <summary>
        /// Original was GL_VIEW_CLASS64_BITS = 0x82C6
        /// </summary>
        ViewClass64Bits = 0x82C6,

        /// <summary>
        /// Original was GL_VIEW_CLASS48_BITS = 0x82C7
        /// </summary>
        ViewClass48Bits = 0x82C7,

        /// <summary>
        /// Original was GL_VIEW_CLASS32_BITS = 0x82C8
        /// </summary>
        ViewClass32Bits = 0x82C8,

        /// <summary>
        /// Original was GL_VIEW_CLASS24_BITS = 0x82C9
        /// </summary>
        ViewClass24Bits = 0x82C9,

        /// <summary>
        /// Original was GL_VIEW_CLASS16_BITS = 0x82CA
        /// </summary>
        ViewClass16Bits = 0x82CA,

        /// <summary>
        /// Original was GL_VIEW_CLASS8_BITS = 0x82CB
        /// </summary>
        ViewClass8Bits = 0x82CB,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3_TC_DXT1_RGB = 0x82CC
        /// </summary>
        ViewClassS3TCDxt1Rgb = 0x82CC,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3_TC_DXT1_RGBA = 0x82CD
        /// </summary>
        ViewClassS3TCDxt1Rgba = 0x82CD,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3_TC_DXT3_RGBA = 0x82CE
        /// </summary>
        ViewClassS3TCDxt3Rgba = 0x82CE,

        /// <summary>
        /// Original was GL_VIEW_CLASS_S3_TC_DXT5_RGBA = 0x82CF
        /// </summary>
        ViewClassS3TCDxt5Rgba = 0x82CF,

        /// <summary>
        /// Original was GL_VIEW_CLASS_RGTC1_RED = 0x82D0
        /// </summary>
        ViewClassRgtc1Red = 0x82D0,

        /// <summary>
        /// Original was GL_VIEW_CLASS_RGTC2_RG = 0x82D1
        /// </summary>
        ViewClassRgtc2RG = 0x82D1,

        /// <summary>
        /// Original was GL_VIEW_CLASS_BPTC_UNORM = 0x82D2
        /// </summary>
        ViewClassBptcUnorm = 0x82D2,

        /// <summary>
        /// Original was GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3
        /// </summary>
        ViewClassBptcFloat = 0x82D3,

        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = 0x84F5,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        TextureCompressed = 0x86A1,

        /// <summary>
        /// Original was GL_TEXTURE1_D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = 0x8C18,

        /// <summary>
        /// Original was GL_TEXTURE2_D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = 0x8C1A,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = 0x8C2A,

        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = 0x8D41,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = 0x9009,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        ImageFormatCompatibilityType = 0x90C7,

        /// <summary>
        /// Original was GL_TEXTURE2_D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = 0x9100,

        /// <summary>
        /// Original was GL_TEXTURE2_D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = 0x9102,

        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = 0x9380
    }
}
