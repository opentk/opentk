//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
// Copyright 2013 Xamarin Inc
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

namespace OpenTK.Graphics.ES20
{
    public enum ActiveAttribType : int
    {
        Float = ((int)0X1406),
        FloatVec2 = ((int)0X8b50),
        FloatVec3 = ((int)0X8b51),
        FloatVec4 = ((int)0X8b52),
        FloatMat2 = ((int)0X8b5a),
        FloatMat3 = ((int)0X8b5b),
        FloatMat4 = ((int)0X8b5c),
    }

    public enum ActiveUniformType : int
    {
        Int = ((int)0X1404),
        Float = ((int)0X1406),
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

    public enum All : int
    {
        False = ((int)0),
        NoError = ((int)0),
        None = ((int)0),
        Zero = ((int)0),
        Points = ((int)0x0000),
        SyncFlushCommandsBitApple = ((int)0x00000001),
        VertexShaderBitExt = ((int)0x00000001),
        FragmentShaderBitExt = ((int)0x00000002),
        DepthBufferBit = ((int)0x00000100),
        StencilBufferBit = ((int)0x00000400),
        ColorBufferBit = ((int)0x00004000),
        Lines = ((int)0x0001),
        MapReadBitExt = ((int)0x0001),
        ImgTextureFormatBgra8888 = ((int)0X0001),
        LineLoop = ((int)0x0002),
        MapWriteBitExt = ((int)0x0002),
        LineStrip = ((int)0x0003),
        MapInvalidateRangeBitExt = ((int)0x0004),
        Triangles = ((int)0x0004),
        TriangleStrip = ((int)0x0005),
        TriangleFan = ((int)0x0006),
        MapInvalidateBufferBitExt = ((int)0x0008),
        MapFlushExplicitBitExt = ((int)0x0010),
        MapUnsynchronizedBitExt = ((int)0x0020),
        Never = ((int)0x0200),
        Less = ((int)0x0201),
        Equal = ((int)0x0202),
        Lequal = ((int)0x0203),
        Greater = ((int)0x0204),
        Notequal = ((int)0x0205),
        Gequal = ((int)0x0206),
        Always = ((int)0x0207),
        SrcColor = ((int)0x0300),
        OneMinusSrcColor = ((int)0x0301),
        SrcAlpha = ((int)0x0302),
        OneMinusSrcAlpha = ((int)0x0303),
        DstAlpha = ((int)0x0304),
        OneMinusDstAlpha = ((int)0x0305),
        DstColor = ((int)0x0306),
        OneMinusDstColor = ((int)0x0307),
        SrcAlphaSaturate = ((int)0x0308),
        Front = ((int)0x0404),
        Back = ((int)0x0405),
        FrontAndBack = ((int)0x0408),
        InvalidEnum = ((int)0x0500),
        InvalidValue = ((int)0x0501),
        InvalidOperation = ((int)0x0502),
        OutOfMemory = ((int)0x0505),
        InvalidFramebufferOperation = ((int)0x0506),
        Cw = ((int)0x0900),
        Ccw = ((int)0x0901),
        LineWidth = ((int)0x0B21),
        CullFace = ((int)0x0B44),
        CullFaceMode = ((int)0x0B45),
        FrontFace = ((int)0x0B46),
        DepthRange = ((int)0x0B70),
        DepthTest = ((int)0x0B71),
        DepthWritemask = ((int)0x0B72),
        DepthClearValue = ((int)0x0B73),
        DepthFunc = ((int)0x0B74),
        StencilTest = ((int)0x0B90),
        StencilClearValue = ((int)0x0B91),
        StencilFunc = ((int)0x0B92),
        StencilValueMask = ((int)0x0B93),
        StencilFail = ((int)0x0B94),
        StencilPassDepthFail = ((int)0x0B95),
        StencilPassDepthPass = ((int)0x0B96),
        StencilRef = ((int)0x0B97),
        StencilWritemask = ((int)0x0B98),
        Viewport = ((int)0x0BA2),
        Dither = ((int)0x0BD0),
        Blend = ((int)0x0BE2),
        ScissorBox = ((int)0x0C10),
        ScissorTest = ((int)0x0C11),
        ColorClearValue = ((int)0x0C22),
        ColorWritemask = ((int)0x0C23),
        UnpackAlignment = ((int)0x0CF5),
        PackAlignment = ((int)0x0D05),
        MaxTextureSize = ((int)0x0D33),
        MaxViewportDims = ((int)0x0D3A),
        SubpixelBits = ((int)0x0D50),
        RedBits = ((int)0x0D52),
        GreenBits = ((int)0x0D53),
        BlueBits = ((int)0x0D54),
        AlphaBits = ((int)0x0D55),
        DepthBits = ((int)0x0D56),
        StencilBits = ((int)0x0D57),
        Texture2D = ((int)0x0DE1),
        DontCare = ((int)0x1100),
        Fastest = ((int)0x1101),
        Nicest = ((int)0x1102),
        Byte = ((int)0x1400),
        UnsignedByte = ((int)0x1401),
        Short = ((int)0x1402),
        UnsignedShort = ((int)0x1403),
        Int = ((int)0x1404),
        UnsignedInt = ((int)0x1405),
        Float = ((int)0x1406),
        Fixed = ((int)0x140C),
        Invert = ((int)0x150A),
        Texture = ((int)0x1702),
        ColorExt = ((int)0x1800),
        DepthExt = ((int)0x1801),
        StencilExt = ((int)0x1802),
        StencilIndex = ((int)0x1901),
        DepthComponent = ((int)0x1902),
        RedExt = ((int)0x1903),
        Alpha = ((int)0x1906),
        Rgb = ((int)0x1907),
        Rgba = ((int)0x1908),
        Luminance = ((int)0x1909),
        LuminanceAlpha = ((int)0x190A),
        Keep = ((int)0x1E00),
        Replace = ((int)0x1E01),
        Incr = ((int)0x1E02),
        Decr = ((int)0x1E03),
        Vendor = ((int)0x1F00),
        Renderer = ((int)0x1F01),
        Version = ((int)0x1F02),
        Extensions = ((int)0x1F03),
        Nearest = ((int)0x2600),
        Linear = ((int)0x2601),
        NearestMipmapNearest = ((int)0x2700),
        LinearMipmapNearest = ((int)0x2701),
        NearestMipmapLinear = ((int)0x2702),
        LinearMipmapLinear = ((int)0x2703),
        TextureMagFilter = ((int)0x2800),
        TextureMinFilter = ((int)0x2801),
        TextureWrapS = ((int)0x2802),
        TextureWrapT = ((int)0x2803),
        Repeat = ((int)0x2901),
        PolygonOffsetUnits = ((int)0x2A00),
        ConstantColor = ((int)0x8001),
        OneMinusConstantColor = ((int)0x8002),
        ConstantAlpha = ((int)0x8003),
        OneMinusConstantAlpha = ((int)0x8004),
        BlendColor = ((int)0x8005),
        FuncAdd = ((int)0x8006),
        MinExt = ((int)0x8007),
        MaxExt = ((int)0x8008),
        BlendEquation = ((int)0x8009),
        BlendEquationRgb = ((int)0X8009),
        FuncSubtract = ((int)0x800A),
        FuncReverseSubtract = ((int)0x800B),
        UnsignedShort4444 = ((int)0x8033),
        UnsignedShort5551 = ((int)0x8034),
        PolygonOffsetFill = ((int)0x8037),
        PolygonOffsetFactor = ((int)0x8038),
        Alpha8Ext = ((int)0x803C),
        Luminance8Ext = ((int)0x8040),
        Luminance8Alpha8Ext = ((int)0x8045),
        Rgb8Oes = ((int)0x8051),
        Rgba4 = ((int)0x8056),
        Rgb5A1 = ((int)0x8057),
        Rgba8Oes = ((int)0x8058),
        TextureBinding2D = ((int)0x8069),
        SampleAlphaToCoverage = ((int)0x809E),
        SampleCoverage = ((int)0x80A0),
        SampleBuffers = ((int)0x80A8),
        Samples = ((int)0x80A9),
        SampleCoverageValue = ((int)0x80AA),
        SampleCoverageInvert = ((int)0x80AB),
        BlendDstRgb = ((int)0x80C8),
        BlendSrcRgb = ((int)0x80C9),
        BlendDstAlpha = ((int)0x80CA),
        BlendSrcAlpha = ((int)0x80CB),
        Bgra = ((int)0x80E1),
        BgraExt = ((int)0x80E1),
        BgraImg = ((int)0x80E1),
        ClampToEdge = ((int)0x812F),
        TextureMaxLevelApple = ((int)0x813D),
        GenerateMipmapHint = ((int)0x8192),
        DepthComponent16 = ((int)0x81A5),
        DepthComponent24Oes = ((int)0x81A6),
        DepthComponent32Oes = ((int)0x81A7),
        FramebufferAttachmentColorEncodingExt = ((int)0x8210),
        FramebufferAttachmentComponentTypeExt = ((int)0x8211),
        RgExt = ((int)0x8227),
        R8Ext = ((int)0x8229),
        Rg8Ext = ((int)0x822B),
        R16fExt = ((int)0x822D),
        R32fExt = ((int)0x822E),
        Rg16fExt = ((int)0x822F),
        Rg32fExt = ((int)0x8230),
        ProgramSeparableExt = ((int)0x8258),
        ActiveProgramExt = ((int)0x8259),
        ProgramPipelineBindingExt = ((int)0x825A),
        UnsignedShort565 = ((int)0x8363),
        UnsignedShort4444Rev = ((int)0x8365),
        UnsignedShort4444RevExt = ((int)0x8365),
        UnsignedShort4444RevImg = ((int)0x8365),
        UnsignedShort1555Rev = ((int)0x8366),
        UnsignedShort1555RevExt = ((int)0x8366),
        MirroredRepeat = ((int)0x8370),
        AliasedPointSizeRange = ((int)0x846D),
        AliasedLineWidthRange = ((int)0x846E),
        Texture0 = ((int)0x84C0),
        Texture1 = ((int)0x84C1),
        Texture2 = ((int)0x84C2),
        Texture3 = ((int)0x84C3),
        Texture4 = ((int)0x84C4),
        Texture5 = ((int)0x84C5),
        Texture6 = ((int)0x84C6),
        Texture7 = ((int)0x84C7),
        Texture8 = ((int)0x84C8),
        Texture9 = ((int)0x84C9),
        Texture10 = ((int)0x84CA),
        Texture11 = ((int)0x84CB),
        Texture12 = ((int)0x84CC),
        Texture13 = ((int)0x84CD),
        Texture14 = ((int)0x84CE),
        Texture15 = ((int)0x84CF),
        Texture16 = ((int)0x84D0),
        Texture17 = ((int)0x84D1),
        Texture18 = ((int)0x84D2),
        Texture19 = ((int)0x84D3),
        Texture20 = ((int)0x84D4),
        Texture21 = ((int)0x84D5),
        Texture22 = ((int)0x84D6),
        Texture23 = ((int)0x84D7),
        Texture24 = ((int)0x84D8),
        Texture25 = ((int)0x84D9),
        Texture26 = ((int)0x84DA),
        Texture27 = ((int)0x84DB),
        Texture28 = ((int)0x84DC),
        Texture29 = ((int)0x84DD),
        Texture30 = ((int)0x84DE),
        Texture31 = ((int)0x84DF),
        ActiveTexture = ((int)0x84E0),
        MaxRenderbufferSize = ((int)0x84E8),
        DepthStencilOes = ((int)0x84F9),
        UnsignedInt248Oes = ((int)0x84FA),
        TextureMaxAnisotropyExt = ((int)0x84FE),
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
        IncrWrap = ((int)0x8507),
        DecrWrap = ((int)0x8508),
        TextureCubeMap = ((int)0x8513),
        TextureBindingCubeMap = ((int)0x8514),
        TextureCubeMapPositiveX = ((int)0x8515),
        TextureCubeMapNegativeX = ((int)0x8516),
        TextureCubeMapPositiveY = ((int)0x8517),
        TextureCubeMapNegativeY = ((int)0x8518),
        TextureCubeMapPositiveZ = ((int)0x8519),
        TextureCubeMapNegativeZ = ((int)0x851A),
        MaxCubeMapTextureSize = ((int)0x851C),
        VertexArrayBindingOes = ((int)0x85B5),
        UnsignedShort88Apple = ((int)0x85BA),
        UnsignedShort88RevApple = ((int)0x85BB),
        VertexAttribArrayEnabled = ((int)0x8622),
        VertexAttribArraySize = ((int)0x8623),
        VertexAttribArrayStride = ((int)0x8624),
        VertexAttribArrayType = ((int)0x8625),
        CurrentVertexAttrib = ((int)0x8626),
        VertexAttribArrayPointer = ((int)0x8645),
        NumCompressedTextureFormats = ((int)0x86A2),
        CompressedTextureFormats = ((int)0x86A3),
        BufferSize = ((int)0x8764),
        BufferUsage = ((int)0x8765),
        StencilBackFunc = ((int)0x8800),
        StencilBackFail = ((int)0x8801),
        StencilBackPassDepthFail = ((int)0x8802),
        StencilBackPassDepthPass = ((int)0x8803),
        Rgba32fExt = ((int)0x8814),
        Rgb32fExt = ((int)0x8815),
        Alpha32fExt = ((int)0x8816),
        Luminance32fExt = ((int)0x8818),
        LuminanceAlpha32fExt = ((int)0x8819),
        Rgba16fExt = ((int)0x881A),
        Rgb16fExt = ((int)0x881B),
        Alpha16fExt = ((int)0x881C),
        Luminance16fExt = ((int)0x881E),
        LuminanceAlpha16fExt = ((int)0x881F),
        BlendEquationAlpha = ((int)0x883D),
        TextureCompareModeExt = ((int)0x884C),
        TextureCompareFuncExt = ((int)0x884D),
        CompareRefToTextureExt = ((int)0x884E),
        CurrentQueryExt = ((int)0x8865),
        QueryResultExt = ((int)0x8866),
        QueryResultAvailableExt = ((int)0x8867),
        MaxVertexAttribs = ((int)0x8869),
        VertexAttribArrayNormalized = ((int)0x886A),
        MaxTextureImageUnits = ((int)0x8872),
        ArrayBuffer = ((int)0x8892),
        ElementArrayBuffer = ((int)0x8893),
        ArrayBufferBinding = ((int)0x8894),
        ElementArrayBufferBinding = ((int)0x8895),
        VertexAttribArrayBufferBinding = ((int)0x889F),
        WriteOnlyOes = ((int)0x88B9),
        BufferAccessOes = ((int)0x88BB),
        BufferMappedOes = ((int)0x88BC),
        BufferMapPointerOes = ((int)0x88BD),
        StreamDraw = ((int)0x88E0),
        StaticDraw = ((int)0x88E4),
        DynamicDraw = ((int)0x88E8),
        Depth24Stencil8Oes = ((int)0x88F0),
        VertexAttribArrayDivisorExt = ((int)0x88FE),
        Rgb422Apple = ((int)0x8A1F),
        ProgramPipelineObjectExt = ((int)0x8A4F),
        RgbRaw422Apple = ((int)0x8A51),
        FragmentShaderDiscardsSamplesExt = ((int)0x8A52),
        SyncObjectApple = ((int)0x8A53),
        CompressedSrgbPvrtc2Bppv1Ext = ((int)0x8A54),
        CompressedSrgbPvrtc4Bppv1Ext = ((int)0x8A55),
        CompressedSrgbAlphaPvrtc2Bppv1Ext = ((int)0x8A56),
        CompressedSrgbAlphaPvrtc4Bppv1Ext = ((int)0x8A57),
        FragmentShader = ((int)0x8B30),
        VertexShader = ((int)0x8B31),
        ProgramObjectExt = ((int)0x8B40),
        ShaderObjectExt = ((int)0x8B48),
        MaxVertexTextureImageUnits = ((int)0x8B4C),
        MaxCombinedTextureImageUnits = ((int)0x8B4D),
        ShaderType = ((int)0x8B4F),
        FloatVec2 = ((int)0x8B50),
        FloatVec3 = ((int)0x8B51),
        FloatVec4 = ((int)0x8B52),
        IntVec2 = ((int)0x8B53),
        IntVec3 = ((int)0x8B54),
        IntVec4 = ((int)0x8B55),
        Bool = ((int)0x8B56),
        BoolVec2 = ((int)0x8B57),
        BoolVec3 = ((int)0x8B58),
        BoolVec4 = ((int)0x8B59),
        FloatMat2 = ((int)0x8B5A),
        FloatMat3 = ((int)0x8B5B),
        FloatMat4 = ((int)0x8B5C),
        Sampler2D = ((int)0x8B5E),
        SamplerCube = ((int)0x8B60),
        Sampler2DShadowExt = ((int)0x8B62),
        DeleteStatus = ((int)0x8B80),
        CompileStatus = ((int)0x8B81),
        LinkStatus = ((int)0x8B82),
        ValidateStatus = ((int)0x8B83),
        InfoLogLength = ((int)0x8B84),
        AttachedShaders = ((int)0x8B85),
        ActiveUniforms = ((int)0x8B86),
        ActiveUniformMaxLength = ((int)0x8B87),
        ShaderSourceLength = ((int)0x8B88),
        ActiveAttributes = ((int)0x8B89),
        ActiveAttributeMaxLength = ((int)0x8B8A),
        FragmentShaderDerivativeHintOes = ((int)0x8B8B),
        ShadingLanguageVersion = ((int)0x8B8C),
        CurrentProgram = ((int)0x8B8D),
        ImplementationColorReadType = ((int)0x8B9A),
        ImplementationColorReadFormat = ((int)0x8B9B),
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
        UnsignedNormalizedExt = ((int)0x8C17),
        AnySamplesPassedExt = ((int)0x8C2F),
        SrgbExt = ((int)0x8C40),
        SrgbAlphaExt = ((int)0x8C42),
        Srgb8Alpha8Ext = ((int)0x8C43),
        StencilBackRef = ((int)0x8CA3),
        StencilBackValueMask = ((int)0x8CA4),
        StencilBackWritemask = ((int)0x8CA5),
        DrawFramebufferBindingApple = ((int)0x8CA6),
        FramebufferBinding = ((int)0x8CA6),
        RenderbufferBinding = ((int)0x8CA7),
        ReadFramebufferApple = ((int)0x8CA8),
        DrawFramebufferApple = ((int)0x8CA9),
        ReadFramebufferBindingApple = ((int)0x8CAA),
        RenderbufferSamplesApple = ((int)0x8CAB),
        FramebufferAttachmentObjectType = ((int)0x8CD0),
        FramebufferAttachmentObjectName = ((int)0x8CD1),
        FramebufferAttachmentTextureLevel = ((int)0x8CD2),
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3),
        FramebufferComplete = ((int)0x8CD5),
        FramebufferIncompleteAttachment = ((int)0x8CD6),
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7),
        FramebufferIncompleteDimensions = ((int)0x8CD9),
        FramebufferUnsupported = ((int)0x8CDD),
        ColorAttachment0 = ((int)0x8CE0),
        DepthAttachment = ((int)0x8D00),
        StencilAttachment = ((int)0x8D20),
        Framebuffer = ((int)0x8D40),
        Renderbuffer = ((int)0x8D41),
        RenderbufferWidth = ((int)0x8D42),
        RenderbufferHeight = ((int)0x8D43),
        RenderbufferInternalFormat = ((int)0x8D44),
        StencilIndex8 = ((int)0x8D48),
        RenderbufferRedSize = ((int)0x8D50),
        RenderbufferGreenSize = ((int)0x8D51),
        RenderbufferBlueSize = ((int)0x8D52),
        RenderbufferAlphaSize = ((int)0x8D53),
        RenderbufferDepthSize = ((int)0x8D54),
        RenderbufferStencilSize = ((int)0x8D55),
        FramebufferIncompleteMultisampleApple = ((int)0x8D56),
        MaxSamplesApple = ((int)0x8D57),
        HalfFloatOes = ((int)0x8D61),
        Rgb565 = ((int)0x8D62),
        AnySamplesPassedConservativeExt = ((int)0x8D6A),
        LowFloat = ((int)0x8DF0),
        MediumFloat = ((int)0x8DF1),
        HighFloat = ((int)0x8DF2),
        LowInt = ((int)0x8DF3),
        MediumInt = ((int)0x8DF4),
        HighInt = ((int)0x8DF5),
        ShaderBinaryFormats = ((int)0x8DF8),
        NumShaderBinaryFormats = ((int)0x8DF9),
        ShaderCompiler = ((int)0x8DFA),
        MaxVertexUniformVectors = ((int)0x8DFB),
        MaxVaryingVectors = ((int)0x8DFC),
        MaxFragmentUniformVectors = ((int)0x8DFD),
        MaxServerWaitTimeoutApple = ((int)0x9111),
        ObjectTypeApple = ((int)0x9112),
        SyncConditionApple = ((int)0x9113),
        SyncStatusApple = ((int)0x9114),
        SyncFlagsApple = ((int)0x9115),
        SyncFenceApple = ((int)0x9116),
        SyncGpuCommandsCompleteApple = ((int)0x9117),
        UnsignaledApple = ((int)0x9118),
        SignaledApple = ((int)0x9119),
        AlreadySignaledApple = ((int)0x911A),
        TimeoutExpiredApple = ((int)0x911B),
        ConditionSatisfiedApple = ((int)0x911C),
        WaitFailedApple = ((int)0x911D),
        TextureImmutableFormatExt = ((int)0x912F),
        BufferObjectExt = ((int)0x9151),
        QueryObjectExt = ((int)0x9153),
        VertexArrayObjectExt = ((int)0x9154),
        Bgra8Ext = ((int)0x93A1),
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
        AppleCopyTextureLevels = ((int)1),
        AppleFramebufferMultisample = ((int)1),
        AppleRgb422 = ((int)1),
        AppleSync = ((int)1),
        AppleTextureFormatBgra8888 = ((int)1),
        AppleTextureMaxLevel = ((int)1),
        EsVersion20 = ((int)1),
        ExtBlendMinmax = ((int)1),
        ExtColorBufferHalfFloat = ((int)1),
        ExtDebugLabel = ((int)1),
        ExtDebugMarker = ((int)1),
        ExtDiscardFramebuffer = ((int)1),
        ExtDrawInstanced = ((int)1),
        ExtInstancedArrays = ((int)1),
        ExtMapBufferRange = ((int)1),
        ExtOcclusionQueryBoolean = ((int)1),
        ExtPvrtcSrgb = ((int)1),
        ExtReadFormatBgra = ((int)1),
        ExtSeparateShaderObjects = ((int)1),
        ExtShaderFramebufferFetch = ((int)1),
        ExtShaderTextureLod = ((int)1),
        ExtShadowSamplers = ((int)1),
        ExtSrgb = ((int)1),
        ExtTextureFilterAnisotropic = ((int)1),
        ExtTextureRg = ((int)1),
        ExtTextureStorage = ((int)1),
        ImgReadFormat = ((int)1),
        ImgTextureCompressionPvrtc = ((int)1),
        OesDepth24 = ((int)1),
        OesDepthTexture = ((int)1),
        OesElementIndexUint = ((int)1),
        OesFboRenderMipmap = ((int)1),
        OesMapbuffer = ((int)1),
        OesPackedDepthStencil = ((int)1),
        OesRgb8Rgba8 = ((int)1),
        OesStandardDerivatives = ((int)1),
        OesTextureFloat = ((int)1),
        OesTextureHalfFloat = ((int)1),
        OesTextureHalfFloatLinear = ((int)1),
        OesVertexArrayObject = ((int)1),
        One = ((int)1),
        True = ((int)1),
    }

    public enum BeginMode : int
    {
        Points = ((int)0x0000),
        Lines = ((int)0x0001),
        LineLoop = ((int)0x0002),
        LineStrip = ((int)0x0003),
        Triangles = ((int)0x0004),
        TriangleStrip = ((int)0x0005),
        TriangleFan = ((int)0x0006),
    }

    public enum BlendEquationMode : int
    {
        FuncAdd = ((int)0X8006),
        FuncSubtract = ((int)0X800a),
        FuncReverseSubtract = ((int)0X800b),
    }

    public enum BlendEquationSeparate : int
    {
        FuncAdd = ((int)0x8006),
        BlendEquation = ((int)0x8009),
        BlendEquationAlpha = ((int)0x883D),
    }

    public enum BlendingFactorDest : int
    {
        Zero = ((int)0),
        SrcColor = ((int)0x0300),
        OneMinusSrcColor = ((int)0x0301),
        SrcAlpha = ((int)0x0302),
        OneMinusSrcAlpha = ((int)0x0303),
        DstAlpha = ((int)0x0304),
        OneMinusDstAlpha = ((int)0x0305),
        DstColor = ((int)0X0306),
        OneMinusDstColor = ((int)0X0307),
        SrcAlphaSaturate = ((int)0X0308),
        ConstantColor = ((int)0X8001),
        OneMinusConstantColor = ((int)0X8002),
        ConstantAlpha = ((int)0X8003),
        OneMinusConstantAlpha = ((int)0X8004),
        One = ((int)1),
    }

    public enum BlendingFactorSrc : int
    {
        Zero = ((int)0),
        SrcColor = ((int)0X0300),
        OneMinusSrcColor = ((int)0X0301),
        SrcAlpha = ((int)0X0302),
        OneMinusSrcAlpha = ((int)0X0303),
        DstAlpha = ((int)0X0304),
        OneMinusDstAlpha = ((int)0X0305),
        DstColor = ((int)0x0306),
        OneMinusDstColor = ((int)0x0307),
        SrcAlphaSaturate = ((int)0x0308),
        ConstantColor = ((int)0X8001),
        OneMinusConstantColor = ((int)0X8002),
        ConstantAlpha = ((int)0X8003),
        OneMinusConstantAlpha = ((int)0X8004),
        One = ((int)1),
    }

    public enum BlendSubtract : int
    {
        FuncSubtract = ((int)0x800A),
        FuncReverseSubtract = ((int)0x800B),
    }

    public enum Boolean : int
    {
        False = ((int)0),
        True = ((int)1),
    }

    public enum BufferObjects : int
    {
        CurrentVertexAttrib = ((int)0x8626),
        BufferSize = ((int)0x8764),
        BufferUsage = ((int)0x8765),
        ArrayBuffer = ((int)0x8892),
        ElementArrayBuffer = ((int)0x8893),
        ArrayBufferBinding = ((int)0x8894),
        ElementArrayBufferBinding = ((int)0x8895),
        StreamDraw = ((int)0x88E0),
        StaticDraw = ((int)0x88E4),
        DynamicDraw = ((int)0x88E8),
    }

    public enum BufferParameterName : int
    {
        BufferSize = ((int)0X8764),
        BufferUsage = ((int)0X8765),
    }

    public enum BufferTarget : int
    {
        ArrayBuffer = ((int)0X8892),
        ElementArrayBuffer = ((int)0X8893),
    }

    public enum BufferUsage : int
    {
        StreamDraw = ((int)0X88e0),
        StaticDraw = ((int)0X88e4),
        DynamicDraw = ((int)0X88e8),
    }

    [Flags]
    public enum ClearBufferMask : int
    {
        DepthBufferBit = ((int)0x00000100),
        StencilBufferBit = ((int)0x00000400),
        ColorBufferBit = ((int)0x00004000),
    }

    public enum CullFaceMode : int
    {
        Front = ((int)0x0404),
        Back = ((int)0x0405),
        FrontAndBack = ((int)0x0408),
    }

    public enum DataType : int
    {
        Byte = ((int)0x1400),
        UnsignedByte = ((int)0x1401),
        Short = ((int)0x1402),
        UnsignedShort = ((int)0x1403),
        Int = ((int)0x1404),
        UnsignedInt = ((int)0x1405),
        Float = ((int)0x1406),
        Fixed = ((int)0x140C),
    }

    public enum DepthFunction : int
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

    public enum DrawElementsType : int
    {
        UnsignedByte = ((int)0X1401),
        UnsignedShort = ((int)0X1403),
        UnsignedInt = ((int)0X1405),
    }

    public enum EnableCap : int
    {
        CullFace = ((int)0x0B44),
        DepthTest = ((int)0x0B71),
        StencilTest = ((int)0x0B90),
        Dither = ((int)0x0BD0),
        Blend = ((int)0x0BE2),
        ScissorTest = ((int)0x0C11),
        Texture2D = ((int)0x0DE1),
        PolygonOffsetFill = ((int)0x8037),
        SampleAlphaToCoverage = ((int)0x809E),
        SampleCoverage = ((int)0x80A0),
    }

    public enum ErrorCode : int
    {
        NoError = ((int)0),
        InvalidEnum = ((int)0x0500),
        InvalidValue = ((int)0x0501),
        InvalidOperation = ((int)0x0502),
        OutOfMemory = ((int)0x0505),
        InvalidFramebufferOperation = ((int)0X0506),
    }

    public enum FramebufferErrorCode : int
    {
        FramebufferComplete = ((int)0X8cd5),
        FramebufferIncompleteAttachment = ((int)0X8cd6),
        FramebufferIncompleteMissingAttachment = ((int)0X8cd7),
        FramebufferIncompleteDimensions = ((int)0X8cd9),
        FramebufferUnsupported = ((int)0X8cdd),
    }

    public enum FramebufferObject : int
    {
        None = ((int)0),
        InvalidFramebufferOperation = ((int)0x0506),
        StencilIndex = ((int)0x1901),
        Rgba4 = ((int)0x8056),
        Rgb5A1 = ((int)0x8057),
        DepthComponent16 = ((int)0x81A5),
        MaxRenderbufferSize = ((int)0x84E8),
        FramebufferBinding = ((int)0x8CA6),
        RenderbufferBinding = ((int)0x8CA7),
        FramebufferAttachmentObjectType = ((int)0x8CD0),
        FramebufferAttachmentObjectName = ((int)0x8CD1),
        FramebufferAttachmentTextureLevel = ((int)0x8CD2),
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3),
        FramebufferComplete = ((int)0x8CD5),
        FramebufferIncompleteAttachment = ((int)0x8CD6),
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7),
        FramebufferIncompleteDimensions = ((int)0x8CD9),
        FramebufferUnsupported = ((int)0x8CDD),
        ColorAttachment0 = ((int)0x8CE0),
        DepthAttachment = ((int)0x8D00),
        StencilAttachment = ((int)0x8D20),
        Framebuffer = ((int)0x8D40),
        Renderbuffer = ((int)0x8D41),
        RenderbufferWidth = ((int)0x8D42),
        RenderbufferHeight = ((int)0x8D43),
        RenderbufferInternalFormat = ((int)0x8D44),
        StencilIndex8 = ((int)0x8D48),
        RenderbufferRedSize = ((int)0x8D50),
        RenderbufferGreenSize = ((int)0x8D51),
        RenderbufferBlueSize = ((int)0x8D52),
        RenderbufferAlphaSize = ((int)0x8D53),
        RenderbufferDepthSize = ((int)0x8D54),
        RenderbufferStencilSize = ((int)0x8D55),
        Rgb565 = ((int)0x8D62),
    }

    public enum FramebufferParameterName : int
    {
        FramebufferAttachmentObjectType = ((int)0X8cd0),
        FramebufferAttachmentObjectName = ((int)0X8cd1),
        FramebufferAttachmentTextureLevel = ((int)0X8cd2),
        FramebufferAttachmentTextureCubeMapFace = ((int)0X8cd3),
    }

    public enum FramebufferSlot : int
    {
        ColorAttachment0 = ((int)0X8ce0),
        DepthAttachment = ((int)0X8d00),
        StencilAttachment = ((int)0X8d20),
    }

    public enum FramebufferTarget : int
    {
        Framebuffer = ((int)0X8d40),
    }

    public enum FrontFaceDirection : int
    {
        Cw = ((int)0x0900),
        Ccw = ((int)0x0901),
    }

    public enum GetPName : int
    {
        LineWidth = ((int)0x0B21),
        CullFace = ((int)0X0b44),
        CullFaceMode = ((int)0x0B45),
        FrontFace = ((int)0x0B46),
        DepthRange = ((int)0x0B70),
        DepthTest = ((int)0X0b71),
        DepthWritemask = ((int)0x0B72),
        DepthClearValue = ((int)0x0B73),
        DepthFunc = ((int)0x0B74),
        StencilTest = ((int)0X0b90),
        StencilClearValue = ((int)0x0B91),
        StencilFunc = ((int)0x0B92),
        StencilValueMask = ((int)0x0B93),
        StencilFail = ((int)0x0B94),
        StencilPassDepthFail = ((int)0x0B95),
        StencilPassDepthPass = ((int)0x0B96),
        StencilRef = ((int)0x0B97),
        StencilWritemask = ((int)0x0B98),
        Viewport = ((int)0x0BA2),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        ScissorBox = ((int)0x0C10),
        ScissorTest = ((int)0X0c11),
        ColorClearValue = ((int)0x0C22),
        ColorWritemask = ((int)0x0C23),
        UnpackAlignment = ((int)0x0CF5),
        PackAlignment = ((int)0x0D05),
        MaxTextureSize = ((int)0x0D33),
        MaxViewportDims = ((int)0x0D3A),
        SubpixelBits = ((int)0x0D50),
        RedBits = ((int)0x0D52),
        GreenBits = ((int)0x0D53),
        BlueBits = ((int)0x0D54),
        AlphaBits = ((int)0x0D55),
        DepthBits = ((int)0x0D56),
        StencilBits = ((int)0x0D57),
        Texture2D = ((int)0X0de1),
        PolygonOffsetUnits = ((int)0x2A00),
        BlendColor = ((int)0X8005),
        BlendEquation = ((int)0X8009),
        BlendEquationRgb = ((int)0X8009),
        PolygonOffsetFill = ((int)0X8037),
        PolygonOffsetFactor = ((int)0x8038),
        TextureBinding2D = ((int)0x8069),
        SampleAlphaToCoverage = ((int)0X809e),
        SampleCoverage = ((int)0X80a0),
        SampleBuffers = ((int)0x80A8),
        Samples = ((int)0x80A9),
        SampleCoverageValue = ((int)0x80AA),
        SampleCoverageInvert = ((int)0x80AB),
        BlendDstRgb = ((int)0X80c8),
        BlendSrcRgb = ((int)0X80c9),
        BlendDstAlpha = ((int)0X80ca),
        BlendSrcAlpha = ((int)0X80cb),
        GenerateMipmapHint = ((int)0X8192),
        AliasedPointSizeRange = ((int)0x846D),
        AliasedLineWidthRange = ((int)0x846E),
        ActiveTexture = ((int)0X84e0),
        MaxRenderbufferSize = ((int)0X84e8),
        TextureBindingCubeMap = ((int)0X8514),
        MaxCubeMapTextureSize = ((int)0X851c),
        NumCompressedTextureFormats = ((int)0X86a2),
        CompressedTextureFormats = ((int)0X86a3),
        StencilBackFunc = ((int)0x8800),
        StencilBackFail = ((int)0x8801),
        StencilBackPassDepthFail = ((int)0x8802),
        StencilBackPassDepthPass = ((int)0x8803),
        BlendEquationAlpha = ((int)0X883d),
        MaxVertexAttribs = ((int)0X8869),
        MaxTextureImageUnits = ((int)0X8872),
        ArrayBufferBinding = ((int)0X8894),
        ElementArrayBufferBinding = ((int)0X8895),
        MaxVertexTextureImageUnits = ((int)0X8b4c),
        MaxCombinedTextureImageUnits = ((int)0X8b4d),
        CurrentProgram = ((int)0X8b8d),
        ImplementationColorReadType = ((int)0X8b9a),
        ImplementationColorReadFormat = ((int)0X8b9b),
        StencilBackRef = ((int)0x8CA3),
        StencilBackValueMask = ((int)0x8CA4),
        StencilBackWritemask = ((int)0x8CA5),
        FramebufferBinding = ((int)0X8ca6),
        RenderbufferBinding = ((int)0X8ca7),
        ShaderBinaryFormats = ((int)0X8df8),
        NumShaderBinaryFormats = ((int)0X8df9),
        ShaderCompiler = ((int)0X8dfa),
        MaxVertexUniformVectors = ((int)0X8dfb),
        MaxVaryingVectors = ((int)0X8dfc),
        MaxFragmentUniformVectors = ((int)0X8dfd),
    }

    public enum GetTextureParameter : int
    {
        TextureMagFilter = ((int)0X2800),
        TextureMinFilter = ((int)0X2801),
        TextureWrapS = ((int)0X2802),
        TextureWrapT = ((int)0X2803),
        NumCompressedTextureFormats = ((int)0x86A2),
        CompressedTextureFormats = ((int)0x86A3),
    }

    public enum HintMode : int
    {
        DontCare = ((int)0x1100),
        Fastest = ((int)0x1101),
        Nicest = ((int)0x1102),
    }

    public enum HintTarget : int
    {
        GenerateMipmapHint = ((int)0x8192),
    }

    public enum OpenGlEsCoreVersions : int
    {
        EsVersion20 = ((int)1),
    }

    public enum PixelFormat : int
    {
        DepthComponent = ((int)0x1902),
        Alpha = ((int)0x1906),
        Rgb = ((int)0x1907),
        Rgba = ((int)0x1908),
        Luminance = ((int)0x1909),
        LuminanceAlpha = ((int)0x190A),
    }

    public enum PixelInternalFormat : int
    {
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        LuminanceAlpha = ((int)0X190a),
    }

    public enum PixelStoreParameter : int
    {
        UnpackAlignment = ((int)0X0cf5),
        PackAlignment = ((int)0X0d05),
    }

    public enum PixelType : int
    {
        UnsignedByte = ((int)0X1401),
        UnsignedShort4444 = ((int)0x8033),
        UnsignedShort5551 = ((int)0x8034),
        UnsignedShort565 = ((int)0x8363),
    }

    public enum ProgramParameter : int
    {
        DeleteStatus = ((int)0X8b80),
        LinkStatus = ((int)0X8b82),
        ValidateStatus = ((int)0X8b83),
        InfoLogLength = ((int)0X8b84),
        AttachedShaders = ((int)0X8b85),
        ActiveUniforms = ((int)0X8b86),
        ActiveUniformMaxLength = ((int)0X8b87),
        ActiveAttributes = ((int)0X8b89),
        ActiveAttributeMaxLength = ((int)0X8b8a),
    }

    public enum ReadFormat : int
    {
        ImplementationColorReadType = ((int)0x8B9A),
        ImplementationColorReadFormat = ((int)0x8B9B),
    }

    public enum RenderbufferInternalFormat : int
    {
        Rgba4 = ((int)0X8056),
        Rgb5A1 = ((int)0X8057),
        DepthComponent16 = ((int)0X81a5),
        StencilIndex8 = ((int)0X8d48),
        Rgb565 = ((int)0X8d62),
    }

    public enum RenderbufferParameterName : int
    {
        RenderbufferWidth = ((int)0X8d42),
        RenderbufferHeight = ((int)0X8d43),
        RenderbufferInternalFormat = ((int)0X8d44),
        RenderbufferRedSize = ((int)0X8d50),
        RenderbufferGreenSize = ((int)0X8d51),
        RenderbufferBlueSize = ((int)0X8d52),
        RenderbufferAlphaSize = ((int)0X8d53),
        RenderbufferDepthSize = ((int)0X8d54),
        RenderbufferStencilSize = ((int)0X8d55),
    }

    public enum RenderbufferTarget : int
    {
        Renderbuffer = ((int)0X8d41),
    }

    public enum SeparateBlendFunctions : int
    {
        ConstantColor = ((int)0x8001),
        OneMinusConstantColor = ((int)0x8002),
        ConstantAlpha = ((int)0x8003),
        OneMinusConstantAlpha = ((int)0x8004),
        BlendColor = ((int)0x8005),
        BlendDstRgb = ((int)0x80C8),
        BlendSrcRgb = ((int)0x80C9),
        BlendDstAlpha = ((int)0x80CA),
        BlendSrcAlpha = ((int)0x80CB),
    }

    public enum ShaderBinary : int
    {
        ShaderBinaryFormats = ((int)0x8DF8),
        NumShaderBinaryFormats = ((int)0x8DF9),
    }

    public enum ShaderBinaryFormat : int
    {
    }

    public enum ShaderParameter : int
    {
        ShaderType = ((int)0X8b4f),
        DeleteStatus = ((int)0X8b80),
        CompileStatus = ((int)0X8b81),
        InfoLogLength = ((int)0X8b84),
        ShaderSourceLength = ((int)0X8b88),
    }

    public enum ShaderPrecision : int
    {
        LowFloat = ((int)0X8df0),
        MediumFloat = ((int)0X8df1),
        HighFloat = ((int)0X8df2),
        LowInt = ((int)0X8df3),
        MediumInt = ((int)0X8df4),
        HighInt = ((int)0X8df5),
    }

    public enum ShaderPrecisionSpecifiedTypes : int
    {
        LowFloat = ((int)0x8DF0),
        MediumFloat = ((int)0x8DF1),
        HighFloat = ((int)0x8DF2),
        LowInt = ((int)0x8DF3),
        MediumInt = ((int)0x8DF4),
        HighInt = ((int)0x8DF5),
    }

    public enum Shaders : int
    {
        MaxVertexAttribs = ((int)0x8869),
        MaxTextureImageUnits = ((int)0x8872),
        FragmentShader = ((int)0x8B30),
        VertexShader = ((int)0x8B31),
        MaxVertexTextureImageUnits = ((int)0x8B4C),
        MaxCombinedTextureImageUnits = ((int)0x8B4D),
        ShaderType = ((int)0x8B4F),
        DeleteStatus = ((int)0x8B80),
        LinkStatus = ((int)0x8B82),
        ValidateStatus = ((int)0x8B83),
        AttachedShaders = ((int)0x8B85),
        ActiveUniforms = ((int)0x8B86),
        ActiveUniformMaxLength = ((int)0x8B87),
        ActiveAttributes = ((int)0x8B89),
        ActiveAttributeMaxLength = ((int)0x8B8A),
        ShadingLanguageVersion = ((int)0x8B8C),
        CurrentProgram = ((int)0x8B8D),
        MaxVertexUniformVectors = ((int)0x8DFB),
        MaxVaryingVectors = ((int)0x8DFC),
        MaxFragmentUniformVectors = ((int)0x8DFD),
    }

    public enum ShaderSource : int
    {
        CompileStatus = ((int)0x8B81),
        InfoLogLength = ((int)0x8B84),
        ShaderSourceLength = ((int)0x8B88),
        ShaderCompiler = ((int)0x8DFA),
    }

    public enum ShaderType : int
    {
        FragmentShader = ((int)0X8b30),
        VertexShader = ((int)0X8b31),
    }

    public enum StencilFunction : int
    {
        Never = ((int)0x0200),
        Less = ((int)0x0201),
        Equal = ((int)0x0202),
        Lequal = ((int)0x0203),
        Greater = ((int)0x0204),
        Notequal = ((int)0x0205),
        Gequal = ((int)0x0206),
        Always = ((int)0x0207),
    }

    public enum StencilOp : int
    {
        Zero = ((int)0X0000),
        Invert = ((int)0x150A),
        Keep = ((int)0x1E00),
        Replace = ((int)0x1E01),
        Incr = ((int)0x1E02),
        Decr = ((int)0x1E03),
        IncrWrap = ((int)0x8507),
        DecrWrap = ((int)0x8508),
    }

    public enum StringName : int
    {
        Vendor = ((int)0x1F00),
        Renderer = ((int)0x1F01),
        Version = ((int)0x1F02),
        Extensions = ((int)0x1F03),
        ShadingLanguageVersion = ((int)0X8b8c),
    }

    public enum TextureMagFilter : int
    {
        Nearest = ((int)0x2600),
        Linear = ((int)0x2601),
    }

    public enum TextureMinFilter : int
    {
        Nearest = ((int)0X2600),
        Linear = ((int)0X2601),
        NearestMipmapNearest = ((int)0x2700),
        LinearMipmapNearest = ((int)0x2701),
        NearestMipmapLinear = ((int)0x2702),
        LinearMipmapLinear = ((int)0x2703),
    }

    public enum TextureParameterName : int
    {
        TextureMagFilter = ((int)0x2800),
        TextureMinFilter = ((int)0x2801),
        TextureWrapS = ((int)0x2802),
        TextureWrapT = ((int)0x2803),
    }

    public enum TextureTarget : int
    {
        Texture2D = ((int)0X0de1),
        Texture = ((int)0x1702),
        TextureCubeMap = ((int)0x8513),
        TextureBindingCubeMap = ((int)0x8514),
        TextureCubeMapPositiveX = ((int)0x8515),
        TextureCubeMapNegativeX = ((int)0x8516),
        TextureCubeMapPositiveY = ((int)0x8517),
        TextureCubeMapNegativeY = ((int)0x8518),
        TextureCubeMapPositiveZ = ((int)0x8519),
        TextureCubeMapNegativeZ = ((int)0x851A),
        MaxCubeMapTextureSize = ((int)0x851C),
    }

    public enum TextureUnit : int
    {
        Texture0 = ((int)0x84C0),
        Texture1 = ((int)0x84C1),
        Texture2 = ((int)0x84C2),
        Texture3 = ((int)0x84C3),
        Texture4 = ((int)0x84C4),
        Texture5 = ((int)0x84C5),
        Texture6 = ((int)0x84C6),
        Texture7 = ((int)0x84C7),
        Texture8 = ((int)0x84C8),
        Texture9 = ((int)0x84C9),
        Texture10 = ((int)0x84CA),
        Texture11 = ((int)0x84CB),
        Texture12 = ((int)0x84CC),
        Texture13 = ((int)0x84CD),
        Texture14 = ((int)0x84CE),
        Texture15 = ((int)0x84CF),
        Texture16 = ((int)0x84D0),
        Texture17 = ((int)0x84D1),
        Texture18 = ((int)0x84D2),
        Texture19 = ((int)0x84D3),
        Texture20 = ((int)0x84D4),
        Texture21 = ((int)0x84D5),
        Texture22 = ((int)0x84D6),
        Texture23 = ((int)0x84D7),
        Texture24 = ((int)0x84D8),
        Texture25 = ((int)0x84D9),
        Texture26 = ((int)0x84DA),
        Texture27 = ((int)0x84DB),
        Texture28 = ((int)0x84DC),
        Texture29 = ((int)0x84DD),
        Texture30 = ((int)0x84DE),
        Texture31 = ((int)0x84DF),
        ActiveTexture = ((int)0x84E0),
    }

    public enum TextureWrapMode : int
    {
        Repeat = ((int)0x2901),
        ClampToEdge = ((int)0x812F),
        MirroredRepeat = ((int)0x8370),
    }

    public enum UniformTypes : int
    {
        FloatVec2 = ((int)0x8B50),
        FloatVec3 = ((int)0x8B51),
        FloatVec4 = ((int)0x8B52),
        IntVec2 = ((int)0x8B53),
        IntVec3 = ((int)0x8B54),
        IntVec4 = ((int)0x8B55),
        Bool = ((int)0x8B56),
        BoolVec2 = ((int)0x8B57),
        BoolVec3 = ((int)0x8B58),
        BoolVec4 = ((int)0x8B59),
        FloatMat2 = ((int)0x8B5A),
        FloatMat3 = ((int)0x8B5B),
        FloatMat4 = ((int)0x8B5C),
        Sampler2D = ((int)0x8B5E),
        SamplerCube = ((int)0x8B60),
    }

    public enum Unknown : int
    {
        SyncFlushCommandsBitApple = ((int)0x00000001),
        VertexShaderBitExt = ((int)0x00000001),
        FragmentShaderBitExt = ((int)0x00000002),
        MapReadBitExt = ((int)0x0001),
        ImgTextureFormatBgra8888 = ((int)0X0001),
        MapWriteBitExt = ((int)0x0002),
        MapInvalidateRangeBitExt = ((int)0x0004),
        MapInvalidateBufferBitExt = ((int)0x0008),
        MapFlushExplicitBitExt = ((int)0x0010),
        MapUnsynchronizedBitExt = ((int)0x0020),
        ColorExt = ((int)0x1800),
        DepthExt = ((int)0x1801),
        StencilExt = ((int)0x1802),
        RedExt = ((int)0x1903),
        MinExt = ((int)0x8007),
        MaxExt = ((int)0x8008),
        Alpha8Ext = ((int)0x803C),
        Luminance8Ext = ((int)0x8040),
        Luminance8Alpha8Ext = ((int)0x8045),
        Rgb8Oes = ((int)0x8051),
        Rgba8Oes = ((int)0x8058),
        Bgra = ((int)0x80E1),
        BgraExt = ((int)0x80E1),
        BgraImg = ((int)0x80E1),
        TextureMaxLevelApple = ((int)0x813D),
        DepthComponent24Oes = ((int)0x81A6),
        DepthComponent32Oes = ((int)0x81A7),
        FramebufferAttachmentColorEncodingExt = ((int)0x8210),
        FramebufferAttachmentComponentTypeExt = ((int)0x8211),
        RgExt = ((int)0x8227),
        R8Ext = ((int)0x8229),
        Rg8Ext = ((int)0x822B),
        R16fExt = ((int)0x822D),
        R32fExt = ((int)0x822E),
        Rg16fExt = ((int)0x822F),
        Rg32fExt = ((int)0x8230),
        ProgramSeparableExt = ((int)0x8258),
        ActiveProgramExt = ((int)0x8259),
        ProgramPipelineBindingExt = ((int)0x825A),
        UnsignedShort4444Rev = ((int)0x8365),
        UnsignedShort4444RevExt = ((int)0x8365),
        UnsignedShort4444RevImg = ((int)0x8365),
        UnsignedShort1555Rev = ((int)0x8366),
        UnsignedShort1555RevExt = ((int)0x8366),
        DepthStencilOes = ((int)0x84F9),
        UnsignedInt248Oes = ((int)0x84FA),
        TextureMaxAnisotropyExt = ((int)0x84FE),
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
        VertexArrayBindingOes = ((int)0x85B5),
        UnsignedShort88Apple = ((int)0x85BA),
        UnsignedShort88RevApple = ((int)0x85BB),
        Rgba32fExt = ((int)0x8814),
        Rgb32fExt = ((int)0x8815),
        Alpha32fExt = ((int)0x8816),
        Luminance32fExt = ((int)0x8818),
        LuminanceAlpha32fExt = ((int)0x8819),
        Rgba16fExt = ((int)0x881A),
        Rgb16fExt = ((int)0x881B),
        Alpha16fExt = ((int)0x881C),
        Luminance16fExt = ((int)0x881E),
        LuminanceAlpha16fExt = ((int)0x881F),
        TextureCompareModeExt = ((int)0x884C),
        TextureCompareFuncExt = ((int)0x884D),
        CompareRefToTextureExt = ((int)0x884E),
        CurrentQueryExt = ((int)0x8865),
        QueryResultExt = ((int)0x8866),
        QueryResultAvailableExt = ((int)0x8867),
        WriteOnlyOes = ((int)0x88B9),
        BufferAccessOes = ((int)0x88BB),
        BufferMappedOes = ((int)0x88BC),
        BufferMapPointerOes = ((int)0x88BD),
        Depth24Stencil8Oes = ((int)0x88F0),
        VertexAttribArrayDivisorExt = ((int)0x88FE),
        Rgb422Apple = ((int)0x8A1F),
        ProgramPipelineObjectExt = ((int)0x8A4F),
        RgbRaw422Apple = ((int)0x8A51),
        FragmentShaderDiscardsSamplesExt = ((int)0x8A52),
        SyncObjectApple = ((int)0x8A53),
        CompressedSrgbPvrtc2Bppv1Ext = ((int)0x8A54),
        CompressedSrgbPvrtc4Bppv1Ext = ((int)0x8A55),
        CompressedSrgbAlphaPvrtc2Bppv1Ext = ((int)0x8A56),
        CompressedSrgbAlphaPvrtc4Bppv1Ext = ((int)0x8A57),
        ProgramObjectExt = ((int)0x8B40),
        ShaderObjectExt = ((int)0x8B48),
        Sampler2DShadowExt = ((int)0x8B62),
        FragmentShaderDerivativeHintOes = ((int)0x8B8B),
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
        UnsignedNormalizedExt = ((int)0x8C17),
        AnySamplesPassedExt = ((int)0x8C2F),
        SrgbExt = ((int)0x8C40),
        SrgbAlphaExt = ((int)0x8C42),
        Srgb8Alpha8Ext = ((int)0x8C43),
        DrawFramebufferBindingApple = ((int)0x8CA6),
        ReadFramebufferApple = ((int)0x8CA8),
        DrawFramebufferApple = ((int)0x8CA9),
        ReadFramebufferBindingApple = ((int)0x8CAA),
        RenderbufferSamplesApple = ((int)0x8CAB),
        FramebufferIncompleteMultisampleApple = ((int)0x8D56),
        MaxSamplesApple = ((int)0x8D57),
        HalfFloatOes = ((int)0x8D61),
        AnySamplesPassedConservativeExt = ((int)0x8D6A),
        MaxServerWaitTimeoutApple = ((int)0x9111),
        ObjectTypeApple = ((int)0x9112),
        SyncConditionApple = ((int)0x9113),
        SyncStatusApple = ((int)0x9114),
        SyncFlagsApple = ((int)0x9115),
        SyncFenceApple = ((int)0x9116),
        SyncGpuCommandsCompleteApple = ((int)0x9117),
        UnsignaledApple = ((int)0x9118),
        SignaledApple = ((int)0x9119),
        AlreadySignaledApple = ((int)0x911A),
        TimeoutExpiredApple = ((int)0x911B),
        ConditionSatisfiedApple = ((int)0x911C),
        WaitFailedApple = ((int)0x911D),
        TextureImmutableFormatExt = ((int)0x912F),
        BufferObjectExt = ((int)0x9151),
        QueryObjectExt = ((int)0x9153),
        VertexArrayObjectExt = ((int)0x9154),
        Bgra8Ext = ((int)0x93A1),
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
        AppleCopyTextureLevels = ((int)1),
        AppleFramebufferMultisample = ((int)1),
        AppleRgb422 = ((int)1),
        AppleSync = ((int)1),
        AppleTextureFormatBgra8888 = ((int)1),
        AppleTextureMaxLevel = ((int)1),
        ExtBlendMinmax = ((int)1),
        ExtColorBufferHalfFloat = ((int)1),
        ExtDebugLabel = ((int)1),
        ExtDebugMarker = ((int)1),
        ExtDiscardFramebuffer = ((int)1),
        ExtDrawInstanced = ((int)1),
        ExtInstancedArrays = ((int)1),
        ExtMapBufferRange = ((int)1),
        ExtOcclusionQueryBoolean = ((int)1),
        ExtPvrtcSrgb = ((int)1),
        ExtReadFormatBgra = ((int)1),
        ExtSeparateShaderObjects = ((int)1),
        ExtShaderFramebufferFetch = ((int)1),
        ExtShaderTextureLod = ((int)1),
        ExtShadowSamplers = ((int)1),
        ExtSrgb = ((int)1),
        ExtTextureFilterAnisotropic = ((int)1),
        ExtTextureRg = ((int)1),
        ExtTextureStorage = ((int)1),
        ImgReadFormat = ((int)1),
        ImgTextureCompressionPvrtc = ((int)1),
        OesDepth24 = ((int)1),
        OesDepthTexture = ((int)1),
        OesElementIndexUint = ((int)1),
        OesFboRenderMipmap = ((int)1),
        OesMapbuffer = ((int)1),
        OesPackedDepthStencil = ((int)1),
        OesRgb8Rgba8 = ((int)1),
        OesStandardDerivatives = ((int)1),
        OesTextureFloat = ((int)1),
        OesTextureHalfFloat = ((int)1),
        OesTextureHalfFloatLinear = ((int)1),
        OesVertexArrayObject = ((int)1),
    }

    public enum VertexArrays : int
    {
        VertexAttribArrayEnabled = ((int)0x8622),
        VertexAttribArraySize = ((int)0x8623),
        VertexAttribArrayStride = ((int)0x8624),
        VertexAttribArrayType = ((int)0x8625),
        VertexAttribArrayPointer = ((int)0x8645),
        VertexAttribArrayNormalized = ((int)0x886A),
        VertexAttribArrayBufferBinding = ((int)0x889F),
    }

    public enum VertexAttribParameter : int
    {
        VertexAttribArrayEnabled = ((int)0X8622),
        VertexAttribArraySize = ((int)0X8623),
        VertexAttribArrayStride = ((int)0X8624),
        VertexAttribArrayType = ((int)0X8625),
        CurrentVertexAttrib = ((int)0X8626),
        VertexAttribArrayNormalized = ((int)0X886a),
        VertexAttribArrayBufferBinding = ((int)0X889f),
    }

    public enum VertexAttribPointerParameter : int
    {
        VertexAttribArrayPointer = ((int)0X8645),
    }

    public enum VertexAttribPointerType : int
    {
        Byte = ((int)0X1400),
        UnsignedByte = ((int)0X1401),
        Short = ((int)0X1402),
        UnsignedShort = ((int)0X1403),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
    }

}
