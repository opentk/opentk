#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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
#endregion

using System;

namespace OpenTK.Graphics.ES20
{
    #pragma warning disable 1591

    public enum All
    {
        False = ((int)0),
        NoError = ((int)0),
        None = ((int)0),
        Zero = ((int)0),
        Points = ((int)0X0000),
        DepthBufferBit = ((int)0X00000100),
        StencilBufferBit = ((int)0X00000400),
        ColorBufferBit = ((int)0X00004000),
        Lines = ((int)0X0001),
        LineLoop = ((int)0X0002),
        LineStrip = ((int)0X0003),
        Triangles = ((int)0X0004),
        TriangleStrip = ((int)0X0005),
        TriangleFan = ((int)0X0006),
        Never = ((int)0X0200),
        Less = ((int)0X0201),
        Equal = ((int)0X0202),
        Lequal = ((int)0X0203),
        Greater = ((int)0X0204),
        Notequal = ((int)0X0205),
        Gequal = ((int)0X0206),
        Always = ((int)0X0207),
        SrcColor = ((int)0X0300),
        OneMinusSrcColor = ((int)0X0301),
        SrcAlpha = ((int)0X0302),
        OneMinusSrcAlpha = ((int)0X0303),
        DstAlpha = ((int)0X0304),
        OneMinusDstAlpha = ((int)0X0305),
        DstColor = ((int)0X0306),
        OneMinusDstColor = ((int)0X0307),
        SrcAlphaSaturate = ((int)0X0308),
        Front = ((int)0X0404),
        Back = ((int)0X0405),
        FrontAndBack = ((int)0X0408),
        InvalidEnum = ((int)0X0500),
        InvalidValue = ((int)0X0501),
        InvalidOperation = ((int)0X0502),
        OutOfMemory = ((int)0X0505),
        InvalidFramebufferOperation = ((int)0X0506),
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
        LineWidth = ((int)0X0b21),
        CullFace = ((int)0X0b44),
        CullFaceMode = ((int)0X0b45),
        FrontFace = ((int)0X0b46),
        DepthRange = ((int)0X0b70),
        DepthTest = ((int)0X0b71),
        DepthWritemask = ((int)0X0b72),
        DepthClearValue = ((int)0X0b73),
        DepthFunc = ((int)0X0b74),
        StencilTest = ((int)0X0b90),
        StencilClearValue = ((int)0X0b91),
        StencilFunc = ((int)0X0b92),
        StencilValueMask = ((int)0X0b93),
        StencilFail = ((int)0X0b94),
        StencilPassDepthFail = ((int)0X0b95),
        StencilPassDepthPass = ((int)0X0b96),
        StencilRef = ((int)0X0b97),
        StencilWritemask = ((int)0X0b98),
        Viewport = ((int)0X0ba2),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        ScissorBox = ((int)0X0c10),
        ScissorTest = ((int)0X0c11),
        ColorClearValue = ((int)0X0c22),
        ColorWritemask = ((int)0X0c23),
        UnpackAlignment = ((int)0X0cf5),
        PackAlignment = ((int)0X0d05),
        MaxTextureSize = ((int)0X0d33),
        MaxViewportDims = ((int)0X0d3a),
        SubpixelBits = ((int)0X0d50),
        RedBits = ((int)0X0d52),
        GreenBits = ((int)0X0d53),
        BlueBits = ((int)0X0d54),
        AlphaBits = ((int)0X0d55),
        DepthBits = ((int)0X0d56),
        StencilBits = ((int)0X0d57),
        Texture2D = ((int)0X0de1),
        DontCare = ((int)0X1100),
        Fastest = ((int)0X1101),
        Nicest = ((int)0X1102),
        Byte = ((int)0X1400),
        UnsignedByte = ((int)0X1401),
        Short = ((int)0X1402),
        UnsignedShort = ((int)0X1403),
        Int = ((int)0X1404),
        UnsignedInt = ((int)0X1405),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
        Invert = ((int)0X150a),
        Texture = ((int)0X1702),
        StencilIndex = ((int)0X1901),
        DepthComponent = ((int)0X1902),
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        LuminanceAlpha = ((int)0X190a),
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
        Nearest = ((int)0X2600),
        Linear = ((int)0X2601),
        NearestMipmapNearest = ((int)0X2700),
        LinearMipmapNearest = ((int)0X2701),
        NearestMipmapLinear = ((int)0X2702),
        LinearMipmapLinear = ((int)0X2703),
        TextureMagFilter = ((int)0X2800),
        TextureMinFilter = ((int)0X2801),
        TextureWrapS = ((int)0X2802),
        TextureWrapT = ((int)0X2803),
        Repeat = ((int)0X2901),
        PolygonOffsetUnits = ((int)0X2a00),
        ConstantColor = ((int)0X8001),
        OneMinusConstantColor = ((int)0X8002),
        ConstantAlpha = ((int)0X8003),
        OneMinusConstantAlpha = ((int)0X8004),
        BlendColor = ((int)0X8005),
        FuncAdd = ((int)0X8006),
        BlendEquation = ((int)0X8009),
        FuncSubtract = ((int)0X800a),
        FuncReverseSubtract = ((int)0X800b),
        UnsignedShort4444 = ((int)0X8033),
        UnsignedShort5551 = ((int)0X8034),
        PolygonOffsetFill = ((int)0X8037),
        PolygonOffsetFactor = ((int)0X8038),
        Rgb8Oes = ((int)0X8051),
        Rgba4 = ((int)0X8056),
        Rgb5A1 = ((int)0X8057),
        Rgba8Oes = ((int)0X8058),
        TextureBinding2D = ((int)0X8069),
        TextureBinding3DOes = ((int)0X806a),
        Texture3DOes = ((int)0X806f),
        TextureWrapROes = ((int)0X8072),
        Max3DTextureSizeOes = ((int)0X8073),
        SampleAlphaToCoverage = ((int)0X809e),
        SampleCoverage = ((int)0X80a0),
        SampleBuffers = ((int)0X80a8),
        Samples = ((int)0X80a9),
        SampleCoverageValue = ((int)0X80aa),
        SampleCoverageInvert = ((int)0X80ab),
        BlendDstRgb = ((int)0X80c8),
        BlendSrcRgb = ((int)0X80c9),
        BlendDstAlpha = ((int)0X80ca),
        BlendSrcAlpha = ((int)0X80cb),
        Bgra = ((int)0X80e1),
        ClampToEdge = ((int)0X812f),
        GenerateMipmapHint = ((int)0X8192),
        DepthComponent16 = ((int)0X81a5),
        DepthComponent24Oes = ((int)0X81a6),
        DepthComponent32Oes = ((int)0X81a7),
        UnsignedShort565 = ((int)0X8363),
        UnsignedShort4444Rev = ((int)0X8365),
        UnsignedShort1555Rev = ((int)0X8366),
        UnsignedInt2101010RevExt = ((int)0X8368),
        MirroredRepeat = ((int)0X8370),
        AliasedPointSizeRange = ((int)0X846d),
        AliasedLineWidthRange = ((int)0X846e),
        Texture0 = ((int)0X84c0),
        Texture1 = ((int)0X84c1),
        Texture2 = ((int)0X84c2),
        Texture3 = ((int)0X84c3),
        Texture4 = ((int)0X84c4),
        Texture5 = ((int)0X84c5),
        Texture6 = ((int)0X84c6),
        Texture7 = ((int)0X84c7),
        Texture8 = ((int)0X84c8),
        Texture9 = ((int)0X84c9),
        Texture10 = ((int)0X84ca),
        Texture11 = ((int)0X84cb),
        Texture12 = ((int)0X84cc),
        Texture13 = ((int)0X84cd),
        Texture14 = ((int)0X84ce),
        Texture15 = ((int)0X84cf),
        Texture16 = ((int)0X84d0),
        Texture17 = ((int)0X84d1),
        Texture18 = ((int)0X84d2),
        Texture19 = ((int)0X84d3),
        Texture20 = ((int)0X84d4),
        Texture21 = ((int)0X84d5),
        Texture22 = ((int)0X84d6),
        Texture23 = ((int)0X84d7),
        Texture24 = ((int)0X84d8),
        Texture25 = ((int)0X84d9),
        Texture26 = ((int)0X84da),
        Texture27 = ((int)0X84db),
        Texture28 = ((int)0X84dc),
        Texture29 = ((int)0X84dd),
        Texture30 = ((int)0X84de),
        Texture31 = ((int)0X84df),
        ActiveTexture = ((int)0X84e0),
        MaxRenderbufferSize = ((int)0X84e8),
        AllCompletedNv = ((int)0X84f2),
        FenceStatusNv = ((int)0X84f3),
        FenceConditionNv = ((int)0X84f4),
        DepthStencilOes = ((int)0X84f9),
        UnsignedInt248Oes = ((int)0X84fa),
        TextureMaxAnisotropyExt = ((int)0X84fe),
        MaxTextureMaxAnisotropyExt = ((int)0X84ff),
        IncrWrap = ((int)0X8507),
        DecrWrap = ((int)0X8508),
        TextureCubeMap = ((int)0X8513),
        TextureBindingCubeMap = ((int)0X8514),
        TextureCubeMapPositiveX = ((int)0X8515),
        TextureCubeMapNegativeX = ((int)0X8516),
        TextureCubeMapPositiveY = ((int)0X8517),
        TextureCubeMapNegativeY = ((int)0X8518),
        TextureCubeMapPositiveZ = ((int)0X8519),
        TextureCubeMapNegativeZ = ((int)0X851a),
        MaxCubeMapTextureSize = ((int)0X851c),
        VertexAttribArrayEnabled = ((int)0X8622),
        VertexAttribArraySize = ((int)0X8623),
        VertexAttribArrayStride = ((int)0X8624),
        VertexAttribArrayType = ((int)0X8625),
        CurrentVertexAttrib = ((int)0X8626),
        VertexAttribArrayPointer = ((int)0X8645),
        NumCompressedTextureFormats = ((int)0X86a2),
        CompressedTextureFormats = ((int)0X86a3),
        Z400BinaryAmd = ((int)0X8740),
        ProgramBinaryLengthOes = ((int)0X8741),
        BufferSize = ((int)0X8764),
        BufferUsage = ((int)0X8765),
        AtcRgbaInterpolatedAlphaAmd = ((int)0X87ee),
        GL_3DcXAmd = ((int)0X87f9),
        GL_3DcXyAmd = ((int)0X87fa),
        NumProgramBinaryFormatsOes = ((int)0X87fe),
        ProgramBinaryFormatsOes = ((int)0X87ff),
        StencilBackFunc = ((int)0X8800),
        StencilBackFail = ((int)0X8801),
        StencilBackPassDepthFail = ((int)0X8802),
        StencilBackPassDepthPass = ((int)0X8803),
        BlendEquationAlpha = ((int)0X883d),
        MaxVertexAttribs = ((int)0X8869),
        VertexAttribArrayNormalized = ((int)0X886a),
        MaxTextureImageUnits = ((int)0X8872),
        ArrayBuffer = ((int)0X8892),
        ElementArrayBuffer = ((int)0X8893),
        ArrayBufferBinding = ((int)0X8894),
        ElementArrayBufferBinding = ((int)0X8895),
        VertexAttribArrayBufferBinding = ((int)0X889f),
        WriteOnlyOes = ((int)0X88b9),
        BufferAccessOes = ((int)0X88bb),
        BufferMappedOes = ((int)0X88bc),
        BufferMapPointerOes = ((int)0X88bd),
        StreamDraw = ((int)0X88e0),
        StaticDraw = ((int)0X88e4),
        DynamicDraw = ((int)0X88e8),
        Depth24Stencil8Oes = ((int)0X88f0),
        FragmentShader = ((int)0X8b30),
        VertexShader = ((int)0X8b31),
        MaxVertexTextureImageUnits = ((int)0X8b4c),
        MaxCombinedTextureImageUnits = ((int)0X8b4d),
        ShaderType = ((int)0X8b4f),
        FloatVec2 = ((int)0X8b50),
        FloatVec3 = ((int)0X8b51),
        FloatVec4 = ((int)0X8b52),
        IntVec2 = ((int)0X8b53),
        IntVec3 = ((int)0X8b54),
        IntVec4 = ((int)0X8b55),
        Bool = ((int)0X8b56),
        BoolVec2 = ((int)0X8b57),
        BoolVec3 = ((int)0X8b58),
        BoolVec4 = ((int)0X8b59),
        FloatMat2 = ((int)0X8b5a),
        FloatMat3 = ((int)0X8b5b),
        FloatMat4 = ((int)0X8b5c),
        Sampler2D = ((int)0X8b5e),
        Sampler3DOes = ((int)0X8b5f),
        SamplerCube = ((int)0X8b60),
        DeleteStatus = ((int)0X8b80),
        CompileStatus = ((int)0X8b81),
        LinkStatus = ((int)0X8b82),
        ValidateStatus = ((int)0X8b83),
        InfoLogLength = ((int)0X8b84),
        AttachedShaders = ((int)0X8b85),
        ActiveUniforms = ((int)0X8b86),
        ActiveUniformMaxLength = ((int)0X8b87),
        ShaderSourceLength = ((int)0X8b88),
        ActiveAttributes = ((int)0X8b89),
        ActiveAttributeMaxLength = ((int)0X8b8a),
        FragmentShaderDerivativeHintOes = ((int)0X8b8b),
        ShadingLanguageVersion = ((int)0X8b8c),
        CurrentProgram = ((int)0X8b8d),
        Palette4Rgb8Oes = ((int)0X8b90),
        Palette4Rgba8Oes = ((int)0X8b91),
        Palette4R5G6B5Oes = ((int)0X8b92),
        Palette4Rgba4Oes = ((int)0X8b93),
        Palette4Rgb5A1Oes = ((int)0X8b94),
        Palette8Rgb8Oes = ((int)0X8b95),
        Palette8Rgba8Oes = ((int)0X8b96),
        Palette8R5G6B5Oes = ((int)0X8b97),
        Palette8Rgba4Oes = ((int)0X8b98),
        Palette8Rgb5A1Oes = ((int)0X8b99),
        ImplementationColorReadType = ((int)0X8b9a),
        ImplementationColorReadFormat = ((int)0X8b9b),
        CounterTypeAmd = ((int)0X8bc0),
        CounterRangeAmd = ((int)0X8bc1),
        UnsignedInt64Amd = ((int)0X8bc2),
        PercentageAmd = ((int)0X8bc3),
        PerfmonResultAvailableAmd = ((int)0X8bc4),
        PerfmonResultSizeAmd = ((int)0X8bc5),
        PerfmonResultAmd = ((int)0X8bc6),
        CompressedRgbPvrtc4Bppv1Img = ((int)0X8c00),
        CompressedRgbPvrtc2Bppv1Img = ((int)0X8c01),
        CompressedRgbaPvrtc4Bppv1Img = ((int)0X8c02),
        CompressedRgbaPvrtc2Bppv1Img = ((int)0X8c03),
        AtcRgbAmd = ((int)0X8c92),
        AtcRgbaExplicitAlphaAmd = ((int)0X8c93),
        StencilBackRef = ((int)0X8ca3),
        StencilBackValueMask = ((int)0X8ca4),
        StencilBackWritemask = ((int)0X8ca5),
        FramebufferBinding = ((int)0X8ca6),
        RenderbufferBinding = ((int)0X8ca7),
        FramebufferAttachmentObjectType = ((int)0X8cd0),
        FramebufferAttachmentObjectName = ((int)0X8cd1),
        FramebufferAttachmentTextureLevel = ((int)0X8cd2),
        FramebufferAttachmentTextureCubeMapFace = ((int)0X8cd3),
        FramebufferAttachmentTexture3DZoffsetOes = ((int)0X8cd4),
        FramebufferComplete = ((int)0X8cd5),
        FramebufferIncompleteAttachment = ((int)0X8cd6),
        FramebufferIncompleteMissingAttachment = ((int)0X8cd7),
        FramebufferIncompleteDimensions = ((int)0X8cd9),
        FramebufferUnsupported = ((int)0X8cdd),
        ColorAttachment0 = ((int)0X8ce0),
        DepthAttachment = ((int)0X8d00),
        StencilAttachment = ((int)0X8d20),
        Framebuffer = ((int)0X8d40),
        Renderbuffer = ((int)0X8d41),
        RenderbufferWidth = ((int)0X8d42),
        RenderbufferHeight = ((int)0X8d43),
        RenderbufferInternalFormat = ((int)0X8d44),
        StencilIndex1Oes = ((int)0X8d46),
        StencilIndex4Oes = ((int)0X8d47),
        StencilIndex8 = ((int)0X8d48),
        RenderbufferRedSize = ((int)0X8d50),
        RenderbufferGreenSize = ((int)0X8d51),
        RenderbufferBlueSize = ((int)0X8d52),
        RenderbufferAlphaSize = ((int)0X8d53),
        RenderbufferDepthSize = ((int)0X8d54),
        RenderbufferStencilSize = ((int)0X8d55),
        HalfFloatOes = ((int)0X8d61),
        Rgb565 = ((int)0X8d62),
        Etc1Rgb8Oes = ((int)0X8d64),
        LowFloat = ((int)0X8df0),
        MediumFloat = ((int)0X8df1),
        HighFloat = ((int)0X8df2),
        LowInt = ((int)0X8df3),
        MediumInt = ((int)0X8df4),
        HighInt = ((int)0X8df5),
        UnsignedInt1010102Oes = ((int)0X8df6),
        Int1010102Oes = ((int)0X8df7),
        ShaderBinaryFormats = ((int)0X8df8),
        NumShaderBinaryFormats = ((int)0X8df9),
        ShaderCompiler = ((int)0X8dfa),
        MaxVertexUniformVectors = ((int)0X8dfb),
        MaxVaryingVectors = ((int)0X8dfc),
        MaxFragmentUniformVectors = ((int)0X8dfd),
        PerfmonGlobalModeQcom = ((int)0X8fa0),
        AmdCompressed3DcTexture = ((int)1),
        AmdCompressedAtcTexture = ((int)1),
        AmdPerformanceMonitor = ((int)1),
        AmdProgramBinaryZ400 = ((int)1),
        EsVersion20 = ((int)1),
        ExtTextureFilterAnisotropic = ((int)1),
        ExtTextureFormatBgra8888 = ((int)1),
        ExtTextureType2101010Rev = ((int)1),
        ImgReadFormat = ((int)1),
        ImgTextureCompressionPvrtc = ((int)1),
        NvFence = ((int)1),
        OesCompressedEtc1Rgb8Texture = ((int)1),
        OesCompressedPalettedTexture = ((int)1),
        OesDepth24 = ((int)1),
        OesDepth32 = ((int)1),
        OesDepthTexture = ((int)1),
        OesEglImage = ((int)1),
        OesElementIndexUint = ((int)1),
        OesFboRenderMipmap = ((int)1),
        OesFragmentPrecisionHigh = ((int)1),
        OesGetProgramBinary = ((int)1),
        OesMapbuffer = ((int)1),
        OesPackedDepthStencil = ((int)1),
        OesRgb8Rgba8 = ((int)1),
        OesStandardDerivatives = ((int)1),
        OesStencil1 = ((int)1),
        OesStencil4 = ((int)1),
        OesTexture3D = ((int)1),
        OesTextureFloat = ((int)1),
        OesTextureFloatLinear = ((int)1),
        OesTextureHalfFloat = ((int)1),
        OesTextureHalfFloatLinear = ((int)1),
        OesTextureNpot = ((int)1),
        OesVertexHalfFloat = ((int)1),
        OesVertexType1010102 = ((int)1),
        One = ((int)1),
        QcomDriverControl = ((int)1),
        QcomPerfmonGlobalMode = ((int)1),
        True = ((int)1),
    }

    public enum Amdcompressed3Dctexture
    {
        GL_3DcXAmd = ((int)0X87f9),
        GL_3DcXyAmd = ((int)0X87fa),
        AmdCompressed3DcTexture = ((int)1),
    }

    public enum AmdcompressedAtctexture
    {
        AtcRgbaInterpolatedAlphaAmd = ((int)0X87ee),
        AtcRgbAmd = ((int)0X8c92),
        AtcRgbaExplicitAlphaAmd = ((int)0X8c93),
        AmdCompressedAtcTexture = ((int)1),
    }

    public enum AmdperformanceMonitor
    {
        CounterTypeAmd = ((int)0X8bc0),
        CounterRangeAmd = ((int)0X8bc1),
        UnsignedInt64Amd = ((int)0X8bc2),
        PercentageAmd = ((int)0X8bc3),
        PerfmonResultAvailableAmd = ((int)0X8bc4),
        PerfmonResultSizeAmd = ((int)0X8bc5),
        PerfmonResultAmd = ((int)0X8bc6),
        AmdPerformanceMonitor = ((int)1),
    }

    public enum AmdprogramBinaryZ400
    {
        Z400BinaryAmd = ((int)0X8740),
        AmdProgramBinaryZ400 = ((int)1),
    }

    public enum BeginMode
    {
        Points = ((int)0X0000),
        Lines = ((int)0X0001),
        LineLoop = ((int)0X0002),
        LineStrip = ((int)0X0003),
        Triangles = ((int)0X0004),
        TriangleStrip = ((int)0X0005),
        TriangleFan = ((int)0X0006),
    }

    public enum BlendEquationSeparate
    {
        FuncAdd = ((int)0X8006),
        BlendEquation = ((int)0X8009),
        BlendEquationAlpha = ((int)0X883d),
    }

    public enum BlendingFactorDest
    {
        Zero = ((int)0),
        SrcColor = ((int)0X0300),
        OneMinusSrcColor = ((int)0X0301),
        SrcAlpha = ((int)0X0302),
        OneMinusSrcAlpha = ((int)0X0303),
        DstAlpha = ((int)0X0304),
        OneMinusDstAlpha = ((int)0X0305),
        One = ((int)1),
    }

    public enum BlendingFactorSrc
    {
        DstColor = ((int)0X0306),
        OneMinusDstColor = ((int)0X0307),
        SrcAlphaSaturate = ((int)0X0308),
    }

    public enum BlendSubtract
    {
        FuncSubtract = ((int)0X800a),
        FuncReverseSubtract = ((int)0X800b),
    }

    public enum Boolean
    {
        False = ((int)0),
        True = ((int)1),
    }

    public enum BufferObjects
    {
        CurrentVertexAttrib = ((int)0X8626),
        BufferSize = ((int)0X8764),
        BufferUsage = ((int)0X8765),
        ArrayBuffer = ((int)0X8892),
        ElementArrayBuffer = ((int)0X8893),
        ArrayBufferBinding = ((int)0X8894),
        ElementArrayBufferBinding = ((int)0X8895),
        StreamDraw = ((int)0X88e0),
        StaticDraw = ((int)0X88e4),
        DynamicDraw = ((int)0X88e8),
    }

    [Flags]
    public enum ClearBufferMask
    {
        DepthBufferBit = ((int)0X00000100),
        StencilBufferBit = ((int)0X00000400),
        ColorBufferBit = ((int)0X00004000),
    }

    public enum CullFaceMode
    {
        Front = ((int)0X0404),
        Back = ((int)0X0405),
        FrontAndBack = ((int)0X0408),
    }

    public enum DataType
    {
        Byte = ((int)0X1400),
        UnsignedByte = ((int)0X1401),
        Short = ((int)0X1402),
        UnsignedShort = ((int)0X1403),
        Int = ((int)0X1404),
        UnsignedInt = ((int)0X1405),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
    }

    public enum EnableCap
    {
        CullFace = ((int)0X0b44),
        DepthTest = ((int)0X0b71),
        StencilTest = ((int)0X0b90),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        ScissorTest = ((int)0X0c11),
        Texture2D = ((int)0X0de1),
        PolygonOffsetFill = ((int)0X8037),
        SampleAlphaToCoverage = ((int)0X809e),
        SampleCoverage = ((int)0X80a0),
    }

    public enum ErrorCode
    {
        NoError = ((int)0),
        InvalidEnum = ((int)0X0500),
        InvalidValue = ((int)0X0501),
        InvalidOperation = ((int)0X0502),
        OutOfMemory = ((int)0X0505),
    }

    public enum ExttextureFilterAnisotropic
    {
        TextureMaxAnisotropyExt = ((int)0X84fe),
        MaxTextureMaxAnisotropyExt = ((int)0X84ff),
        ExtTextureFilterAnisotropic = ((int)1),
    }

    public enum ExttextureFormatBgra8888
    {
        Bgra = ((int)0X80e1),
        ExtTextureFormatBgra8888 = ((int)1),
    }

    public enum ExttextureType2101010Rev
    {
        UnsignedInt2101010RevExt = ((int)0X8368),
        ExtTextureType2101010Rev = ((int)1),
    }

    public enum FramebufferObject
    {
        None = ((int)0),
        InvalidFramebufferOperation = ((int)0X0506),
        StencilIndex = ((int)0X1901),
        Rgba4 = ((int)0X8056),
        Rgb5A1 = ((int)0X8057),
        DepthComponent16 = ((int)0X81a5),
        MaxRenderbufferSize = ((int)0X84e8),
        FramebufferBinding = ((int)0X8ca6),
        RenderbufferBinding = ((int)0X8ca7),
        FramebufferAttachmentObjectType = ((int)0X8cd0),
        FramebufferAttachmentObjectName = ((int)0X8cd1),
        FramebufferAttachmentTextureLevel = ((int)0X8cd2),
        FramebufferAttachmentTextureCubeMapFace = ((int)0X8cd3),
        FramebufferComplete = ((int)0X8cd5),
        FramebufferIncompleteAttachment = ((int)0X8cd6),
        FramebufferIncompleteMissingAttachment = ((int)0X8cd7),
        FramebufferIncompleteDimensions = ((int)0X8cd9),
        FramebufferUnsupported = ((int)0X8cdd),
        ColorAttachment0 = ((int)0X8ce0),
        DepthAttachment = ((int)0X8d00),
        StencilAttachment = ((int)0X8d20),
        Framebuffer = ((int)0X8d40),
        Renderbuffer = ((int)0X8d41),
        RenderbufferWidth = ((int)0X8d42),
        RenderbufferHeight = ((int)0X8d43),
        RenderbufferInternalFormat = ((int)0X8d44),
        StencilIndex8 = ((int)0X8d48),
        RenderbufferRedSize = ((int)0X8d50),
        RenderbufferGreenSize = ((int)0X8d51),
        RenderbufferBlueSize = ((int)0X8d52),
        RenderbufferAlphaSize = ((int)0X8d53),
        RenderbufferDepthSize = ((int)0X8d54),
        RenderbufferStencilSize = ((int)0X8d55),
        Rgb565 = ((int)0X8d62),
    }

    public enum FrontFaceDirection
    {
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
    }

    public enum GetPName
    {
        LineWidth = ((int)0X0b21),
        CullFaceMode = ((int)0X0b45),
        FrontFace = ((int)0X0b46),
        DepthRange = ((int)0X0b70),
        DepthWritemask = ((int)0X0b72),
        DepthClearValue = ((int)0X0b73),
        DepthFunc = ((int)0X0b74),
        StencilClearValue = ((int)0X0b91),
        StencilFunc = ((int)0X0b92),
        StencilValueMask = ((int)0X0b93),
        StencilFail = ((int)0X0b94),
        StencilPassDepthFail = ((int)0X0b95),
        StencilPassDepthPass = ((int)0X0b96),
        StencilRef = ((int)0X0b97),
        StencilWritemask = ((int)0X0b98),
        Viewport = ((int)0X0ba2),
        ScissorBox = ((int)0X0c10),
        ColorClearValue = ((int)0X0c22),
        ColorWritemask = ((int)0X0c23),
        UnpackAlignment = ((int)0X0cf5),
        PackAlignment = ((int)0X0d05),
        MaxTextureSize = ((int)0X0d33),
        MaxViewportDims = ((int)0X0d3a),
        SubpixelBits = ((int)0X0d50),
        RedBits = ((int)0X0d52),
        GreenBits = ((int)0X0d53),
        BlueBits = ((int)0X0d54),
        AlphaBits = ((int)0X0d55),
        DepthBits = ((int)0X0d56),
        StencilBits = ((int)0X0d57),
        PolygonOffsetUnits = ((int)0X2a00),
        PolygonOffsetFactor = ((int)0X8038),
        TextureBinding2D = ((int)0X8069),
        SampleBuffers = ((int)0X80a8),
        Samples = ((int)0X80a9),
        SampleCoverageValue = ((int)0X80aa),
        SampleCoverageInvert = ((int)0X80ab),
        AliasedPointSizeRange = ((int)0X846d),
        AliasedLineWidthRange = ((int)0X846e),
        StencilBackFunc = ((int)0X8800),
        StencilBackFail = ((int)0X8801),
        StencilBackPassDepthFail = ((int)0X8802),
        StencilBackPassDepthPass = ((int)0X8803),
        StencilBackRef = ((int)0X8ca3),
        StencilBackValueMask = ((int)0X8ca4),
        StencilBackWritemask = ((int)0X8ca5),
    }

    public enum GetTextureParameter
    {
        NumCompressedTextureFormats = ((int)0X86a2),
        CompressedTextureFormats = ((int)0X86a3),
    }

    public enum HintMode
    {
        DontCare = ((int)0X1100),
        Fastest = ((int)0X1101),
        Nicest = ((int)0X1102),
    }

    public enum HintTarget
    {
        GenerateMipmapHint = ((int)0X8192),
    }

    public enum ImgreadFormat
    {
        Bgra = ((int)0X80e1),
        UnsignedShort4444Rev = ((int)0X8365),
        UnsignedShort1555Rev = ((int)0X8366),
        ImgReadFormat = ((int)1),
    }

    public enum ImgtextureCompressionPvrtc
    {
        CompressedRgbPvrtc4Bppv1Img = ((int)0X8c00),
        CompressedRgbPvrtc2Bppv1Img = ((int)0X8c01),
        CompressedRgbaPvrtc4Bppv1Img = ((int)0X8c02),
        CompressedRgbaPvrtc2Bppv1Img = ((int)0X8c03),
        ImgTextureCompressionPvrtc = ((int)1),
    }

    public enum Nvfence
    {
        AllCompletedNv = ((int)0X84f2),
        FenceStatusNv = ((int)0X84f3),
        FenceConditionNv = ((int)0X84f4),
        NvFence = ((int)1),
    }

    public enum OescompressedEtc1Rgb8Texture
    {
        Etc1Rgb8Oes = ((int)0X8d64),
        OesCompressedEtc1Rgb8Texture = ((int)1),
    }

    public enum OescompressedPalettedTexture
    {
        Palette4Rgb8Oes = ((int)0X8b90),
        Palette4Rgba8Oes = ((int)0X8b91),
        Palette4R5G6B5Oes = ((int)0X8b92),
        Palette4Rgba4Oes = ((int)0X8b93),
        Palette4Rgb5A1Oes = ((int)0X8b94),
        Palette8Rgb8Oes = ((int)0X8b95),
        Palette8Rgba8Oes = ((int)0X8b96),
        Palette8R5G6B5Oes = ((int)0X8b97),
        Palette8Rgba4Oes = ((int)0X8b98),
        Palette8Rgb5A1Oes = ((int)0X8b99),
        OesCompressedPalettedTexture = ((int)1),
    }

    public enum Oesdepth24
    {
        DepthComponent24Oes = ((int)0X81a6),
        OesDepth24 = ((int)1),
    }

    public enum Oesdepth32
    {
        DepthComponent32Oes = ((int)0X81a7),
        OesDepth32 = ((int)1),
    }

    public enum OesdepthTexture
    {
        OesDepthTexture = ((int)1),
    }

    public enum Oeseglimage
    {
        OesEglImage = ((int)1),
    }

    public enum OeselementIndexUint
    {
        OesElementIndexUint = ((int)1),
    }

    public enum OesfboRenderMipmap
    {
        OesFboRenderMipmap = ((int)1),
    }

    public enum OesfragmentPrecisionHigh
    {
        OesFragmentPrecisionHigh = ((int)1),
    }

    public enum OesgetProgramBinary
    {
        ProgramBinaryLengthOes = ((int)0X8741),
        NumProgramBinaryFormatsOes = ((int)0X87fe),
        ProgramBinaryFormatsOes = ((int)0X87ff),
        OesGetProgramBinary = ((int)1),
    }

    public enum Oesmapbuffer
    {
        WriteOnlyOes = ((int)0X88b9),
        BufferAccessOes = ((int)0X88bb),
        BufferMappedOes = ((int)0X88bc),
        BufferMapPointerOes = ((int)0X88bd),
        OesMapbuffer = ((int)1),
    }

    public enum OespackedDepthStencil
    {
        DepthStencilOes = ((int)0X84f9),
        UnsignedInt248Oes = ((int)0X84fa),
        Depth24Stencil8Oes = ((int)0X88f0),
        OesPackedDepthStencil = ((int)1),
    }

    public enum Oesrgb8Rgba8
    {
        Rgb8Oes = ((int)0X8051),
        Rgba8Oes = ((int)0X8058),
        OesRgb8Rgba8 = ((int)1),
    }

    public enum OesstandardDerivatives
    {
        FragmentShaderDerivativeHintOes = ((int)0X8b8b),
        OesStandardDerivatives = ((int)1),
    }

    public enum Oesstencil1
    {
        StencilIndex1Oes = ((int)0X8d46),
        OesStencil1 = ((int)1),
    }

    public enum Oesstencil4
    {
        StencilIndex4Oes = ((int)0X8d47),
        OesStencil4 = ((int)1),
    }

    public enum Oestexture3D
    {
        TextureBinding3DOes = ((int)0X806a),
        Texture3DOes = ((int)0X806f),
        TextureWrapROes = ((int)0X8072),
        Max3DTextureSizeOes = ((int)0X8073),
        Sampler3DOes = ((int)0X8b5f),
        FramebufferAttachmentTexture3DZoffsetOes = ((int)0X8cd4),
        OesTexture3D = ((int)1),
    }

    public enum OestextureFloat
    {
        OesTextureFloat = ((int)1),
    }

    public enum OestextureFloatLinear
    {
        OesTextureFloatLinear = ((int)1),
    }

    public enum OestextureHalfFloat
    {
        HalfFloatOes = ((int)0X8d61),
        OesTextureHalfFloat = ((int)1),
    }

    public enum OestextureHalfFloatLinear
    {
        OesTextureHalfFloatLinear = ((int)1),
    }

    public enum OestextureNpot
    {
        OesTextureNpot = ((int)1),
    }

    public enum OesvertexHalfFloat
    {
        OesVertexHalfFloat = ((int)1),
    }

    public enum OesvertexType1010102
    {
        UnsignedInt1010102Oes = ((int)0X8df6),
        Int1010102Oes = ((int)0X8df7),
        OesVertexType1010102 = ((int)1),
    }

    public enum OpenGlescoreVersions
    {
        EsVersion20 = ((int)1),
    }

    public enum PixelFormat
    {
        DepthComponent = ((int)0X1902),
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        LuminanceAlpha = ((int)0X190a),
    }

    public enum PixelType
    {
        UnsignedShort4444 = ((int)0X8033),
        UnsignedShort5551 = ((int)0X8034),
        UnsignedShort565 = ((int)0X8363),
    }

    public enum QcomdriverControl
    {
        QcomDriverControl = ((int)1),
    }

    public enum QcomperfmonGlobalMode
    {
        PerfmonGlobalModeQcom = ((int)0X8fa0),
        QcomPerfmonGlobalMode = ((int)1),
    }

    public enum ReadFormat
    {
        ImplementationColorReadType = ((int)0X8b9a),
        ImplementationColorReadFormat = ((int)0X8b9b),
    }

    public enum SeparateBlendFunctions
    {
        ConstantColor = ((int)0X8001),
        OneMinusConstantColor = ((int)0X8002),
        ConstantAlpha = ((int)0X8003),
        OneMinusConstantAlpha = ((int)0X8004),
        BlendColor = ((int)0X8005),
        BlendDstRgb = ((int)0X80c8),
        BlendSrcRgb = ((int)0X80c9),
        BlendDstAlpha = ((int)0X80ca),
        BlendSrcAlpha = ((int)0X80cb),
    }

    public enum ShaderBinary
    {
        ShaderBinaryFormats = ((int)0X8df8),
        NumShaderBinaryFormats = ((int)0X8df9),
    }

    public enum ShaderPrecisionSpecifiedTypes
    {
        LowFloat = ((int)0X8df0),
        MediumFloat = ((int)0X8df1),
        HighFloat = ((int)0X8df2),
        LowInt = ((int)0X8df3),
        MediumInt = ((int)0X8df4),
        HighInt = ((int)0X8df5),
    }

    public enum Shaders
    {
        MaxVertexAttribs = ((int)0X8869),
        MaxTextureImageUnits = ((int)0X8872),
        FragmentShader = ((int)0X8b30),
        VertexShader = ((int)0X8b31),
        MaxVertexTextureImageUnits = ((int)0X8b4c),
        MaxCombinedTextureImageUnits = ((int)0X8b4d),
        ShaderType = ((int)0X8b4f),
        DeleteStatus = ((int)0X8b80),
        LinkStatus = ((int)0X8b82),
        ValidateStatus = ((int)0X8b83),
        AttachedShaders = ((int)0X8b85),
        ActiveUniforms = ((int)0X8b86),
        ActiveUniformMaxLength = ((int)0X8b87),
        ActiveAttributes = ((int)0X8b89),
        ActiveAttributeMaxLength = ((int)0X8b8a),
        ShadingLanguageVersion = ((int)0X8b8c),
        CurrentProgram = ((int)0X8b8d),
        MaxVertexUniformVectors = ((int)0X8dfb),
        MaxVaryingVectors = ((int)0X8dfc),
        MaxFragmentUniformVectors = ((int)0X8dfd),
    }

    public enum ShaderSource
    {
        CompileStatus = ((int)0X8b81),
        InfoLogLength = ((int)0X8b84),
        ShaderSourceLength = ((int)0X8b88),
        ShaderCompiler = ((int)0X8dfa),
    }

    public enum StencilFunction
    {
        Never = ((int)0X0200),
        Less = ((int)0X0201),
        Equal = ((int)0X0202),
        Lequal = ((int)0X0203),
        Greater = ((int)0X0204),
        Notequal = ((int)0X0205),
        Gequal = ((int)0X0206),
        Always = ((int)0X0207),
    }

    public enum StencilOp
    {
        Invert = ((int)0X150a),
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
        IncrWrap = ((int)0X8507),
        DecrWrap = ((int)0X8508),
    }

    public enum StringName
    {
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
    }

    public enum TextureMagFilter
    {
        Nearest = ((int)0X2600),
        Linear = ((int)0X2601),
    }

    public enum TextureMinFilter
    {
        NearestMipmapNearest = ((int)0X2700),
        LinearMipmapNearest = ((int)0X2701),
        NearestMipmapLinear = ((int)0X2702),
        LinearMipmapLinear = ((int)0X2703),
    }

    public enum TextureParameterName
    {
        TextureMagFilter = ((int)0X2800),
        TextureMinFilter = ((int)0X2801),
        TextureWrapS = ((int)0X2802),
        TextureWrapT = ((int)0X2803),
    }

    public enum TextureTarget
    {
        Texture = ((int)0X1702),
        TextureCubeMap = ((int)0X8513),
        TextureBindingCubeMap = ((int)0X8514),
        TextureCubeMapPositiveX = ((int)0X8515),
        TextureCubeMapNegativeX = ((int)0X8516),
        TextureCubeMapPositiveY = ((int)0X8517),
        TextureCubeMapNegativeY = ((int)0X8518),
        TextureCubeMapPositiveZ = ((int)0X8519),
        TextureCubeMapNegativeZ = ((int)0X851a),
        MaxCubeMapTextureSize = ((int)0X851c),
    }

    public enum TextureUnit
    {
        Texture0 = ((int)0X84c0),
        Texture1 = ((int)0X84c1),
        Texture2 = ((int)0X84c2),
        Texture3 = ((int)0X84c3),
        Texture4 = ((int)0X84c4),
        Texture5 = ((int)0X84c5),
        Texture6 = ((int)0X84c6),
        Texture7 = ((int)0X84c7),
        Texture8 = ((int)0X84c8),
        Texture9 = ((int)0X84c9),
        Texture10 = ((int)0X84ca),
        Texture11 = ((int)0X84cb),
        Texture12 = ((int)0X84cc),
        Texture13 = ((int)0X84cd),
        Texture14 = ((int)0X84ce),
        Texture15 = ((int)0X84cf),
        Texture16 = ((int)0X84d0),
        Texture17 = ((int)0X84d1),
        Texture18 = ((int)0X84d2),
        Texture19 = ((int)0X84d3),
        Texture20 = ((int)0X84d4),
        Texture21 = ((int)0X84d5),
        Texture22 = ((int)0X84d6),
        Texture23 = ((int)0X84d7),
        Texture24 = ((int)0X84d8),
        Texture25 = ((int)0X84d9),
        Texture26 = ((int)0X84da),
        Texture27 = ((int)0X84db),
        Texture28 = ((int)0X84dc),
        Texture29 = ((int)0X84dd),
        Texture30 = ((int)0X84de),
        Texture31 = ((int)0X84df),
        ActiveTexture = ((int)0X84e0),
    }

    public enum TextureWrapMode
    {
        Repeat = ((int)0X2901),
        ClampToEdge = ((int)0X812f),
        MirroredRepeat = ((int)0X8370),
    }

    public enum UniformTypes
    {
        FloatVec2 = ((int)0X8b50),
        FloatVec3 = ((int)0X8b51),
        FloatVec4 = ((int)0X8b52),
        IntVec2 = ((int)0X8b53),
        IntVec3 = ((int)0X8b54),
        IntVec4 = ((int)0X8b55),
        Bool = ((int)0X8b56),
        BoolVec2 = ((int)0X8b57),
        BoolVec3 = ((int)0X8b58),
        BoolVec4 = ((int)0X8b59),
        FloatMat2 = ((int)0X8b5a),
        FloatMat3 = ((int)0X8b5b),
        FloatMat4 = ((int)0X8b5c),
        Sampler2D = ((int)0X8b5e),
        SamplerCube = ((int)0X8b60),
    }

    public enum VertexArrays
    {
        VertexAttribArrayEnabled = ((int)0X8622),
        VertexAttribArraySize = ((int)0X8623),
        VertexAttribArrayStride = ((int)0X8624),
        VertexAttribArrayType = ((int)0X8625),
        VertexAttribArrayPointer = ((int)0X8645),
        VertexAttribArrayNormalized = ((int)0X886a),
        VertexAttribArrayBufferBinding = ((int)0X889f),
    }

}
