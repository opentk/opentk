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

namespace OpenTK.Graphics.ES11
{
    #pragma warning disable 1591

    public enum All : int
    {
        False = ((int)0),
        NoError = ((int)0),
        NoneOes = ((int)0),
        Zero = ((int)0),
        Points = ((int)0x0000),
        DepthBufferBit = ((int)0x00000100),
        StencilBufferBit = ((int)0x00000400),
        ColorBufferBit = ((int)0x00004000),
        Lines = ((int)0x0001),
        LineLoop = ((int)0x0002),
        LineStrip = ((int)0x0003),
        Triangles = ((int)0x0004),
        TriangleStrip = ((int)0x0005),
        TriangleFan = ((int)0x0006),
        Add = ((int)0x0104),
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
        StackOverflow = ((int)0x0503),
        StackUnderflow = ((int)0x0504),
        OutOfMemory = ((int)0x0505),
        InvalidFramebufferOperationOes = ((int)0x0506),
        Exp = ((int)0x0800),
        Exp2 = ((int)0x0801),
        Cw = ((int)0x0900),
        Ccw = ((int)0x0901),
        CurrentColor = ((int)0x0B00),
        CurrentNormal = ((int)0x0B02),
        CurrentTextureCoords = ((int)0x0B03),
        PointSmooth = ((int)0x0B10),
        PointSize = ((int)0x0B11),
        SmoothPointSizeRange = ((int)0x0B12),
        LineSmooth = ((int)0x0B20),
        LineWidth = ((int)0x0B21),
        SmoothLineWidthRange = ((int)0x0B22),
        CullFace = ((int)0x0B44),
        CullFaceMode = ((int)0x0B45),
        FrontFace = ((int)0x0B46),
        Lighting = ((int)0x0B50),
        LightModelTwoSide = ((int)0x0B52),
        LightModelAmbient = ((int)0x0B53),
        ShadeModel = ((int)0x0B54),
        ColorMaterial = ((int)0x0B57),
        Fog = ((int)0x0B60),
        FogDensity = ((int)0x0B62),
        FogStart = ((int)0x0B63),
        FogEnd = ((int)0x0B64),
        FogMode = ((int)0x0B65),
        FogColor = ((int)0x0B66),
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
        MatrixMode = ((int)0x0BA0),
        Normalize = ((int)0x0BA1),
        Viewport = ((int)0x0BA2),
        ModelviewStackDepth = ((int)0x0BA3),
        ProjectionStackDepth = ((int)0x0BA4),
        TextureStackDepth = ((int)0x0BA5),
        ModelviewMatrix = ((int)0x0BA6),
        ProjectionMatrix = ((int)0x0BA7),
        TextureMatrix = ((int)0x0BA8),
        AlphaTest = ((int)0x0BC0),
        AlphaTestFunc = ((int)0x0BC1),
        AlphaTestRef = ((int)0x0BC2),
        Dither = ((int)0x0BD0),
        BlendDst = ((int)0x0BE0),
        BlendSrc = ((int)0x0BE1),
        Blend = ((int)0x0BE2),
        LogicOpMode = ((int)0x0BF0),
        ColorLogicOp = ((int)0x0BF2),
        ScissorBox = ((int)0x0C10),
        ScissorTest = ((int)0x0C11),
        ColorClearValue = ((int)0x0C22),
        ColorWritemask = ((int)0x0C23),
        PerspectiveCorrectionHint = ((int)0x0C50),
        PointSmoothHint = ((int)0x0C51),
        LineSmoothHint = ((int)0x0C52),
        FogHint = ((int)0x0C54),
        UnpackAlignment = ((int)0x0CF5),
        PackAlignment = ((int)0x0D05),
        AlphaScale = ((int)0x0D1C),
        MaxLights = ((int)0x0D31),
        MaxClipPlanes = ((int)0x0D32),
        MaxClipPlanesImg = ((int)0x0D32),
        MaxTextureSize = ((int)0x0D33),
        MaxModelviewStackDepth = ((int)0x0D36),
        MaxProjectionStackDepth = ((int)0x0D38),
        MaxTextureStackDepth = ((int)0x0D39),
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
        Ambient = ((int)0x1200),
        Diffuse = ((int)0x1201),
        Specular = ((int)0x1202),
        Position = ((int)0x1203),
        SpotDirection = ((int)0x1204),
        SpotExponent = ((int)0x1205),
        SpotCutoff = ((int)0x1206),
        ConstantAttenuation = ((int)0x1207),
        LinearAttenuation = ((int)0x1208),
        QuadraticAttenuation = ((int)0x1209),
        Byte = ((int)0x1400),
        UnsignedByte = ((int)0x1401),
        Short = ((int)0x1402),
        UnsignedShort = ((int)0x1403),
        Float = ((int)0x1406),
        Fixed = ((int)0x140C),
        FixedOes = ((int)0x140C),
        Clear = ((int)0x1500),
        And = ((int)0x1501),
        AndReverse = ((int)0x1502),
        Copy = ((int)0x1503),
        AndInverted = ((int)0x1504),
        Noop = ((int)0x1505),
        Xor = ((int)0x1506),
        Or = ((int)0x1507),
        Nor = ((int)0x1508),
        Equiv = ((int)0x1509),
        Invert = ((int)0x150A),
        OrReverse = ((int)0x150B),
        CopyInverted = ((int)0x150C),
        OrInverted = ((int)0x150D),
        Nand = ((int)0x150E),
        Set = ((int)0x150F),
        Emission = ((int)0x1600),
        Shininess = ((int)0x1601),
        AmbientAndDiffuse = ((int)0x1602),
        Modelview = ((int)0x1700),
        Projection = ((int)0x1701),
        Texture = ((int)0x1702),
        Alpha = ((int)0x1906),
        Rgb = ((int)0x1907),
        Rgba = ((int)0x1908),
        Luminance = ((int)0x1909),
        LuminanceAlpha = ((int)0x190A),
        Flat = ((int)0x1D00),
        Smooth = ((int)0x1D01),
        Keep = ((int)0x1E00),
        Replace = ((int)0x1E01),
        Incr = ((int)0x1E02),
        Decr = ((int)0x1E03),
        Vendor = ((int)0x1F00),
        Renderer = ((int)0x1F01),
        Version = ((int)0x1F02),
        Extensions = ((int)0x1F03),
        Modulate = ((int)0x2100),
        Decal = ((int)0x2101),
        TextureEnvMode = ((int)0x2200),
        TextureEnvColor = ((int)0x2201),
        TextureEnv = ((int)0x2300),
        TextureGenModeOes = ((int)0x2500),
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
        ClipPlane0 = ((int)0x3000),
        ClipPlane0Img = ((int)0x3000),
        ClipPlane1 = ((int)0x3001),
        ClipPlane1Img = ((int)0x3001),
        ClipPlane2 = ((int)0x3002),
        ClipPlane2Img = ((int)0x3002),
        ClipPlane3 = ((int)0x3003),
        ClipPlane3Img = ((int)0x3003),
        ClipPlane4 = ((int)0x3004),
        ClipPlane4Img = ((int)0x3004),
        ClipPlane5 = ((int)0x3005),
        ClipPlane5Img = ((int)0x3005),
        Light0 = ((int)0x4000),
        Light1 = ((int)0x4001),
        Light2 = ((int)0x4002),
        Light3 = ((int)0x4003),
        Light4 = ((int)0x4004),
        Light5 = ((int)0x4005),
        Light6 = ((int)0x4006),
        Light7 = ((int)0x4007),
        FuncAddOes = ((int)0x8006),
        BlendEquationOes = ((int)0x8009),
        BlendEquationRgbOes = ((int)0x8009),
        FuncSubtractOes = ((int)0x800A),
        FuncReverseSubtractOes = ((int)0x800B),
        UnsignedShort4444 = ((int)0x8033),
        UnsignedShort5551 = ((int)0x8034),
        PolygonOffsetFill = ((int)0x8037),
        PolygonOffsetFactor = ((int)0x8038),
        RescaleNormal = ((int)0x803A),
        Rgb8Oes = ((int)0x8051),
        Rgba4Oes = ((int)0x8056),
        Rgb5A1Oes = ((int)0x8057),
        Rgba8Oes = ((int)0x8058),
        TextureBinding2D = ((int)0x8069),
        VertexArray = ((int)0x8074),
        NormalArray = ((int)0x8075),
        ColorArray = ((int)0x8076),
        TextureCoordArray = ((int)0x8078),
        VertexArraySize = ((int)0x807A),
        VertexArrayType = ((int)0x807B),
        VertexArrayStride = ((int)0x807C),
        NormalArrayType = ((int)0x807E),
        NormalArrayStride = ((int)0x807F),
        ColorArraySize = ((int)0x8081),
        ColorArrayType = ((int)0x8082),
        ColorArrayStride = ((int)0x8083),
        TextureCoordArraySize = ((int)0x8088),
        TextureCoordArrayType = ((int)0x8089),
        TextureCoordArrayStride = ((int)0x808A),
        VertexArrayPointer = ((int)0x808E),
        NormalArrayPointer = ((int)0x808F),
        ColorArrayPointer = ((int)0x8090),
        TextureCoordArrayPointer = ((int)0x8092),
        Multisample = ((int)0x809D),
        SampleAlphaToCoverage = ((int)0x809E),
        SampleAlphaToOne = ((int)0x809F),
        SampleCoverage = ((int)0x80A0),
        SampleBuffers = ((int)0x80A8),
        Samples = ((int)0x80A9),
        SampleCoverageValue = ((int)0x80AA),
        SampleCoverageInvert = ((int)0x80AB),
        BlendDstRgbOes = ((int)0x80C8),
        BlendSrcRgbOes = ((int)0x80C9),
        BlendDstAlphaOes = ((int)0x80CA),
        BlendSrcAlphaOes = ((int)0x80CB),
        Bgra = ((int)0x80E1),
        PointSizeMin = ((int)0x8126),
        PointSizeMax = ((int)0x8127),
        PointFadeThresholdSize = ((int)0x8128),
        PointDistanceAttenuation = ((int)0x8129),
        ClampToEdge = ((int)0x812F),
        GenerateMipmap = ((int)0x8191),
        GenerateMipmapHint = ((int)0x8192),
        DepthComponent16Oes = ((int)0x81A5),
        DepthComponent24Oes = ((int)0x81A6),
        DepthComponent32Oes = ((int)0x81A7),
        UnsignedShort565 = ((int)0x8363),
        UnsignedShort4444Rev = ((int)0x8365),
        UnsignedShort1555Rev = ((int)0x8366),
        MirroredRepeatOes = ((int)0x8370),
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
        ClientActiveTexture = ((int)0x84E1),
        MaxTextureUnits = ((int)0x84E2),
        Subtract = ((int)0x84E7),
        MaxRenderbufferSizeOes = ((int)0x84E8),
        AllCompletedNv = ((int)0x84F2),
        FenceStatusNv = ((int)0x84F3),
        FenceConditionNv = ((int)0x84F4),
        DepthStencilOes = ((int)0x84F9),
        UnsignedInt248Oes = ((int)0x84FA),
        TextureMaxAnisotropyExt = ((int)0x84FE),
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
        IncrWrapOes = ((int)0x8507),
        DecrWrapOes = ((int)0x8508),
        NormalMapOes = ((int)0x8511),
        ReflectionMapOes = ((int)0x8512),
        TextureCubeMapOes = ((int)0x8513),
        TextureBindingCubeMapOes = ((int)0x8514),
        TextureCubeMapPositiveXOes = ((int)0x8515),
        TextureCubeMapNegativeXOes = ((int)0x8516),
        TextureCubeMapPositiveYOes = ((int)0x8517),
        TextureCubeMapNegativeYOes = ((int)0x8518),
        TextureCubeMapPositiveZOes = ((int)0x8519),
        TextureCubeMapNegativeZOes = ((int)0x851A),
        MaxCubeMapTextureSizeOes = ((int)0x851C),
        Combine = ((int)0x8570),
        CombineRgb = ((int)0x8571),
        CombineAlpha = ((int)0x8572),
        RgbScale = ((int)0x8573),
        AddSigned = ((int)0x8574),
        Interpolate = ((int)0x8575),
        Constant = ((int)0x8576),
        PrimaryColor = ((int)0x8577),
        Previous = ((int)0x8578),
        Src0Rgb = ((int)0x8580),
        Src1Rgb = ((int)0x8581),
        Src2Rgb = ((int)0x8582),
        Src0Alpha = ((int)0x8588),
        Src1Alpha = ((int)0x8589),
        Src2Alpha = ((int)0x858A),
        Operand0Rgb = ((int)0x8590),
        Operand1Rgb = ((int)0x8591),
        Operand2Rgb = ((int)0x8592),
        Operand0Alpha = ((int)0x8598),
        Operand1Alpha = ((int)0x8599),
        Operand2Alpha = ((int)0x859A),
        NumCompressedTextureFormats = ((int)0x86A2),
        CompressedTextureFormats = ((int)0x86A3),
        MaxVertexUnitsOes = ((int)0x86A4),
        WeightArrayTypeOes = ((int)0x86A9),
        WeightArrayStrideOes = ((int)0x86AA),
        WeightArraySizeOes = ((int)0x86AB),
        WeightArrayPointerOes = ((int)0x86AC),
        WeightArrayOes = ((int)0x86AD),
        Dot3Rgb = ((int)0x86AE),
        Dot3Rgba = ((int)0x86AF),
        Dot3RgbaImg = ((int)0x86AF),
        BufferSize = ((int)0x8764),
        BufferUsage = ((int)0x8765),
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
        Gl3DcXAmd = ((int)0x87F9),
        Gl3DcXyAmd = ((int)0x87FA),
        BlendEquationAlphaOes = ((int)0x883D),
        MatrixPaletteOes = ((int)0x8840),
        MaxPaletteMatricesOes = ((int)0x8842),
        CurrentPaletteMatrixOes = ((int)0x8843),
        MatrixIndexArrayOes = ((int)0x8844),
        MatrixIndexArraySizeOes = ((int)0x8846),
        MatrixIndexArrayTypeOes = ((int)0x8847),
        MatrixIndexArrayStrideOes = ((int)0x8848),
        MatrixIndexArrayPointerOes = ((int)0x8849),
        PointSpriteOes = ((int)0x8861),
        CoordReplaceOes = ((int)0x8862),
        ArrayBuffer = ((int)0x8892),
        ElementArrayBuffer = ((int)0x8893),
        ArrayBufferBinding = ((int)0x8894),
        ElementArrayBufferBinding = ((int)0x8895),
        VertexArrayBufferBinding = ((int)0x8896),
        NormalArrayBufferBinding = ((int)0x8897),
        ColorArrayBufferBinding = ((int)0x8898),
        TextureCoordArrayBufferBinding = ((int)0x889A),
        WeightArrayBufferBindingOes = ((int)0x889E),
        WriteOnlyOes = ((int)0x88B9),
        BufferAccessOes = ((int)0x88BB),
        BufferMappedOes = ((int)0x88BC),
        BufferMapPointerOes = ((int)0x88BD),
        StaticDraw = ((int)0x88E4),
        DynamicDraw = ((int)0x88E8),
        Depth24Stencil8Oes = ((int)0x88F0),
        PointSizeArrayTypeOes = ((int)0x898A),
        PointSizeArrayStrideOes = ((int)0x898B),
        PointSizeArrayPointerOes = ((int)0x898C),
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D),
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E),
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F),
        Palette4Rgb8Oes = ((int)0x8B90),
        Palette4Rgba8Oes = ((int)0x8B91),
        Palette4R5G6B5Oes = ((int)0x8B92),
        Palette4Rgba4Oes = ((int)0x8B93),
        Palette4Rgb5A1Oes = ((int)0x8B94),
        Palette8Rgb8Oes = ((int)0x8B95),
        Palette8Rgba8Oes = ((int)0x8B96),
        Palette8R5G6B5Oes = ((int)0x8B97),
        Palette8Rgba4Oes = ((int)0x8B98),
        Palette8Rgb5A1Oes = ((int)0x8B99),
        ImplementationColorReadTypeOes = ((int)0x8B9A),
        ImplementationColorReadFormatOes = ((int)0x8B9B),
        PointSizeArrayOes = ((int)0x8B9C),
        TextureCropRectOes = ((int)0x8B9D),
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E),
        PointSizeArrayBufferBindingOes = ((int)0x8B9F),
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
        ModulateColorImg = ((int)0x8C04),
        RecipAddSignedAlphaImg = ((int)0x8C05),
        TextureAlphaModulateImg = ((int)0x8C06),
        FactorAlphaModulateImg = ((int)0x8C07),
        FragmentAlphaModulateImg = ((int)0x8C08),
        AddBlendImg = ((int)0x8C09),
        AtcRgbAmd = ((int)0x8C92),
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
        FramebufferBindingOes = ((int)0x8CA6),
        RenderbufferBindingOes = ((int)0x8CA7),
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0),
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1),
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2),
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3),
        FramebufferCompleteOes = ((int)0x8CD5),
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6),
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7),
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9),
        FramebufferIncompleteFormatsOes = ((int)0x8CDA),
        FramebufferUnsupportedOes = ((int)0x8CDD),
        ColorAttachment0Oes = ((int)0x8CE0),
        DepthAttachmentOes = ((int)0x8D00),
        StencilAttachmentOes = ((int)0x8D20),
        FramebufferOes = ((int)0x8D40),
        RenderbufferOes = ((int)0x8D41),
        RenderbufferWidthOes = ((int)0x8D42),
        RenderbufferHeightOes = ((int)0x8D43),
        RenderbufferInternalFormatOes = ((int)0x8D44),
        StencilIndex1Oes = ((int)0x8D46),
        StencilIndex4Oes = ((int)0x8D47),
        StencilIndex8Oes = ((int)0x8D48),
        RenderbufferRedSizeOes = ((int)0x8D50),
        RenderbufferGreenSizeOes = ((int)0x8D51),
        RenderbufferBlueSizeOes = ((int)0x8D52),
        RenderbufferAlphaSizeOes = ((int)0x8D53),
        RenderbufferDepthSizeOes = ((int)0x8D54),
        RenderbufferStencilSizeOes = ((int)0x8D55),
        TextureGenStrOes = ((int)0x8D60),
        Rgb565Oes = ((int)0x8D62),
        Etc1Rgb8Oes = ((int)0x8D64),
        PerfmonGlobalModeQcom = ((int)0x8FA0),
        AmdCompressed3DcTexture = ((int)1),
        AmdCompressedAtcTexture = ((int)1),
        ExtTextureFilterAnisotropic = ((int)1),
        ExtTextureFormatBgra8888 = ((int)1),
        ImgReadFormat = ((int)1),
        ImgTextureCompressionPvrtc = ((int)1),
        ImgTextureEnvEnhancedFixedFunction = ((int)1),
        ImgUserClipPlane = ((int)1),
        NvFence = ((int)1),
        OesBlendEquationSeparate = ((int)1),
        OesBlendFuncSeparate = ((int)1),
        OesBlendSubtract = ((int)1),
        OesByteCoordinates = ((int)1),
        OesCompressedEtc1Rgb8Texture = ((int)1),
        OesCompressedPalettedTexture = ((int)1),
        OesDepth24 = ((int)1),
        OesDepth32 = ((int)1),
        OesDrawTexture = ((int)1),
        OesEglImage = ((int)1),
        OesElementIndexUint = ((int)1),
        OesExtendedMatrixPalette = ((int)1),
        OesFboRenderMipmap = ((int)1),
        OesFixedPoint = ((int)1),
        OesFramebufferObject = ((int)1),
        OesMapbuffer = ((int)1),
        OesMatrixGet = ((int)1),
        OesMatrixPalette = ((int)1),
        OesPackedDepthStencil = ((int)1),
        OesPointSizeArray = ((int)1),
        OesPointSprite = ((int)1),
        OesQueryMatrix = ((int)1),
        OesReadFormat = ((int)1),
        OesRgb8Rgba8 = ((int)1),
        OesSinglePrecision = ((int)1),
        OesStencil1 = ((int)1),
        OesStencil4 = ((int)1),
        OesStencil8 = ((int)1),
        OesStencilWrap = ((int)1),
        OesTextureCubeMap = ((int)1),
        OesTextureEnvCrossbar = ((int)1),
        OesTextureMirroredRepeat = ((int)1),
        One = ((int)1),
        QcomDriverControl = ((int)1),
        QcomPerfmonGlobalMode = ((int)1),
        True = ((int)1),
        VersionEsCl10 = ((int)1),
        VersionEsCl11 = ((int)1),
        VersionEsCm10 = ((int)1),
        VersionEsCm11 = ((int)1),
    }

    public enum AlphaFunction : int
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

    public enum AmdCompressed3Dctexture : int
    {
        Gl3DcXAmd = ((int)0x87F9),
        Gl3DcXyAmd = ((int)0x87FA),
        AmdCompressed3DcTexture = ((int)1),
    }

    public enum AmdCompressedAtctexture : int
    {
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
        AtcRgbAmd = ((int)0x8C92),
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
        AmdCompressedAtcTexture = ((int)1),
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

    public enum BlendingFactorDest : int
    {
        Zero = ((int)0),
        SrcColor = ((int)0x0300),
        OneMinusSrcColor = ((int)0x0301),
        SrcAlpha = ((int)0x0302),
        OneMinusSrcAlpha = ((int)0x0303),
        DstAlpha = ((int)0x0304),
        OneMinusDstAlpha = ((int)0x0305),
        One = ((int)1),
    }

    public enum BlendingFactorSrc : int
    {
        DstColor = ((int)0x0306),
        OneMinusDstColor = ((int)0x0307),
        SrcAlphaSaturate = ((int)0x0308),
    }

    public enum Boolean : int
    {
        False = ((int)0),
        True = ((int)1),
    }

    public enum BufferObjects : int
    {
        BufferSize = ((int)0x8764),
        BufferUsage = ((int)0x8765),
        ArrayBuffer = ((int)0x8892),
        ElementArrayBuffer = ((int)0x8893),
        ArrayBufferBinding = ((int)0x8894),
        ElementArrayBufferBinding = ((int)0x8895),
        VertexArrayBufferBinding = ((int)0x8896),
        NormalArrayBufferBinding = ((int)0x8897),
        ColorArrayBufferBinding = ((int)0x8898),
        TextureCoordArrayBufferBinding = ((int)0x889A),
        StaticDraw = ((int)0x88E4),
        DynamicDraw = ((int)0x88E8),
    }

    [Flags]
    public enum ClearBufferMask : int
    {
        DepthBufferBit = ((int)0x00000100),
        StencilBufferBit = ((int)0x00000400),
        ColorBufferBit = ((int)0x00004000),
    }

    public enum ClipPlaneName : int
    {
        ClipPlane0 = ((int)0x3000),
        ClipPlane1 = ((int)0x3001),
        ClipPlane2 = ((int)0x3002),
        ClipPlane3 = ((int)0x3003),
        ClipPlane4 = ((int)0x3004),
        ClipPlane5 = ((int)0x3005),
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
        Float = ((int)0x1406),
        Fixed = ((int)0x140C),
    }

    public enum EnableCap : int
    {
        PointSmooth = ((int)0x0B10),
        LineSmooth = ((int)0x0B20),
        CullFace = ((int)0x0B44),
        Lighting = ((int)0x0B50),
        ColorMaterial = ((int)0x0B57),
        Fog = ((int)0x0B60),
        DepthTest = ((int)0x0B71),
        StencilTest = ((int)0x0B90),
        Normalize = ((int)0x0BA1),
        AlphaTest = ((int)0x0BC0),
        Dither = ((int)0x0BD0),
        Blend = ((int)0x0BE2),
        ColorLogicOp = ((int)0x0BF2),
        ScissorTest = ((int)0x0C11),
        Texture2D = ((int)0x0DE1),
        PolygonOffsetFill = ((int)0x8037),
        RescaleNormal = ((int)0x803A),
        VertexArray = ((int)0x8074),
        NormalArray = ((int)0x8075),
        ColorArray = ((int)0x8076),
        TextureCoordArray = ((int)0x8078),
        Multisample = ((int)0x809D),
        SampleAlphaToCoverage = ((int)0x809E),
        SampleAlphaToOne = ((int)0x809F),
        SampleCoverage = ((int)0x80A0),
    }

    public enum ErrorCode : int
    {
        NoError = ((int)0),
        InvalidEnum = ((int)0x0500),
        InvalidValue = ((int)0x0501),
        InvalidOperation = ((int)0x0502),
        StackOverflow = ((int)0x0503),
        StackUnderflow = ((int)0x0504),
        OutOfMemory = ((int)0x0505),
    }

    public enum ExtTextureFilterAnisotropic : int
    {
        TextureMaxAnisotropyExt = ((int)0x84FE),
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
        ExtTextureFilterAnisotropic = ((int)1),
    }

    public enum ExtTextureFormatBgra8888 : int
    {
        Bgra = ((int)0x80E1),
        ExtTextureFormatBgra8888 = ((int)1),
    }

    public enum FogMode : int
    {
        Exp = ((int)0x0800),
        Exp2 = ((int)0x0801),
    }

    public enum FogParameter : int
    {
        FogDensity = ((int)0x0B62),
        FogStart = ((int)0x0B63),
        FogEnd = ((int)0x0B64),
        FogMode = ((int)0x0B65),
        FogColor = ((int)0x0B66),
    }

    public enum FrontFaceDirection : int
    {
        Cw = ((int)0x0900),
        Ccw = ((int)0x0901),
    }

    public enum GetPName : int
    {
        CurrentColor = ((int)0x0B00),
        CurrentNormal = ((int)0x0B02),
        CurrentTextureCoords = ((int)0x0B03),
        PointSize = ((int)0x0B11),
        SmoothPointSizeRange = ((int)0x0B12),
        LineWidth = ((int)0x0B21),
        SmoothLineWidthRange = ((int)0x0B22),
        CullFaceMode = ((int)0x0B45),
        FrontFace = ((int)0x0B46),
        ShadeModel = ((int)0x0B54),
        DepthRange = ((int)0x0B70),
        DepthWritemask = ((int)0x0B72),
        DepthClearValue = ((int)0x0B73),
        DepthFunc = ((int)0x0B74),
        StencilClearValue = ((int)0x0B91),
        StencilFunc = ((int)0x0B92),
        StencilValueMask = ((int)0x0B93),
        StencilFail = ((int)0x0B94),
        StencilPassDepthFail = ((int)0x0B95),
        StencilPassDepthPass = ((int)0x0B96),
        StencilRef = ((int)0x0B97),
        StencilWritemask = ((int)0x0B98),
        MatrixMode = ((int)0x0BA0),
        Viewport = ((int)0x0BA2),
        ModelviewStackDepth = ((int)0x0BA3),
        ProjectionStackDepth = ((int)0x0BA4),
        TextureStackDepth = ((int)0x0BA5),
        ModelviewMatrix = ((int)0x0BA6),
        ProjectionMatrix = ((int)0x0BA7),
        TextureMatrix = ((int)0x0BA8),
        AlphaTestFunc = ((int)0x0BC1),
        AlphaTestRef = ((int)0x0BC2),
        BlendDst = ((int)0x0BE0),
        BlendSrc = ((int)0x0BE1),
        LogicOpMode = ((int)0x0BF0),
        ScissorBox = ((int)0x0C10),
        ScissorTest = ((int)0x0C11),
        ColorClearValue = ((int)0x0C22),
        ColorWritemask = ((int)0x0C23),
        UnpackAlignment = ((int)0x0CF5),
        PackAlignment = ((int)0x0D05),
        MaxLights = ((int)0x0D31),
        MaxClipPlanes = ((int)0x0D32),
        MaxTextureSize = ((int)0x0D33),
        MaxModelviewStackDepth = ((int)0x0D36),
        MaxProjectionStackDepth = ((int)0x0D38),
        MaxTextureStackDepth = ((int)0x0D39),
        MaxViewportDims = ((int)0x0D3A),
        SubpixelBits = ((int)0x0D50),
        RedBits = ((int)0x0D52),
        GreenBits = ((int)0x0D53),
        BlueBits = ((int)0x0D54),
        AlphaBits = ((int)0x0D55),
        DepthBits = ((int)0x0D56),
        StencilBits = ((int)0x0D57),
        PolygonOffsetUnits = ((int)0x2A00),
        PolygonOffsetFill = ((int)0x8037),
        PolygonOffsetFactor = ((int)0x8038),
        TextureBinding2D = ((int)0x8069),
        VertexArraySize = ((int)0x807A),
        VertexArrayType = ((int)0x807B),
        VertexArrayStride = ((int)0x807C),
        NormalArrayType = ((int)0x807E),
        NormalArrayStride = ((int)0x807F),
        ColorArraySize = ((int)0x8081),
        ColorArrayType = ((int)0x8082),
        ColorArrayStride = ((int)0x8083),
        TextureCoordArraySize = ((int)0x8088),
        TextureCoordArrayType = ((int)0x8089),
        TextureCoordArrayStride = ((int)0x808A),
        VertexArrayPointer = ((int)0x808E),
        NormalArrayPointer = ((int)0x808F),
        ColorArrayPointer = ((int)0x8090),
        TextureCoordArrayPointer = ((int)0x8092),
        SampleBuffers = ((int)0x80A8),
        Samples = ((int)0x80A9),
        SampleCoverageValue = ((int)0x80AA),
        SampleCoverageInvert = ((int)0x80AB),
        PointSizeMin = ((int)0x8126),
        PointSizeMax = ((int)0x8127),
        PointFadeThresholdSize = ((int)0x8128),
        PointDistanceAttenuation = ((int)0x8129),
        AliasedPointSizeRange = ((int)0x846D),
        AliasedLineWidthRange = ((int)0x846E),
        MaxTextureUnits = ((int)0x84E2),
    }

    public enum GetTextureParameter : int
    {
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
        PerspectiveCorrectionHint = ((int)0x0C50),
        PointSmoothHint = ((int)0x0C51),
        LineSmoothHint = ((int)0x0C52),
        FogHint = ((int)0x0C54),
        GenerateMipmapHint = ((int)0x8192),
    }

    public enum ImgreadFormat : int
    {
        Bgra = ((int)0x80E1),
        UnsignedShort4444Rev = ((int)0x8365),
        UnsignedShort1555Rev = ((int)0x8366),
        ImgReadFormat = ((int)1),
    }

    public enum ImgtextureCompressionPvrtc : int
    {
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
        ImgTextureCompressionPvrtc = ((int)1),
    }

    public enum ImgtextureEnvEnhancedFixedFunction : int
    {
        Dot3RgbaImg = ((int)0x86AF),
        ModulateColorImg = ((int)0x8C04),
        RecipAddSignedAlphaImg = ((int)0x8C05),
        TextureAlphaModulateImg = ((int)0x8C06),
        FactorAlphaModulateImg = ((int)0x8C07),
        FragmentAlphaModulateImg = ((int)0x8C08),
        AddBlendImg = ((int)0x8C09),
        ImgTextureEnvEnhancedFixedFunction = ((int)1),
    }

    public enum ImguserClipPlane : int
    {
        MaxClipPlanesImg = ((int)0x0D32),
        ClipPlane0Img = ((int)0x3000),
        ClipPlane1Img = ((int)0x3001),
        ClipPlane2Img = ((int)0x3002),
        ClipPlane3Img = ((int)0x3003),
        ClipPlane4Img = ((int)0x3004),
        ClipPlane5Img = ((int)0x3005),
        ImgUserClipPlane = ((int)1),
    }

    public enum LightModelParameter : int
    {
        LightModelTwoSide = ((int)0x0B52),
        LightModelAmbient = ((int)0x0B53),
    }

    public enum LightName : int
    {
        Light0 = ((int)0x4000),
        Light1 = ((int)0x4001),
        Light2 = ((int)0x4002),
        Light3 = ((int)0x4003),
        Light4 = ((int)0x4004),
        Light5 = ((int)0x4005),
        Light6 = ((int)0x4006),
        Light7 = ((int)0x4007),
    }

    public enum LightParameter : int
    {
        Ambient = ((int)0x1200),
        Diffuse = ((int)0x1201),
        Specular = ((int)0x1202),
        Position = ((int)0x1203),
        SpotDirection = ((int)0x1204),
        SpotExponent = ((int)0x1205),
        SpotCutoff = ((int)0x1206),
        ConstantAttenuation = ((int)0x1207),
        LinearAttenuation = ((int)0x1208),
        QuadraticAttenuation = ((int)0x1209),
    }

    public enum LogicOp : int
    {
        Clear = ((int)0x1500),
        And = ((int)0x1501),
        AndReverse = ((int)0x1502),
        Copy = ((int)0x1503),
        AndInverted = ((int)0x1504),
        Noop = ((int)0x1505),
        Xor = ((int)0x1506),
        Or = ((int)0x1507),
        Nor = ((int)0x1508),
        Equiv = ((int)0x1509),
        Invert = ((int)0x150A),
        OrReverse = ((int)0x150B),
        CopyInverted = ((int)0x150C),
        OrInverted = ((int)0x150D),
        Nand = ((int)0x150E),
        Set = ((int)0x150F),
    }

    public enum MaterialParameter : int
    {
        Emission = ((int)0x1600),
        Shininess = ((int)0x1601),
        AmbientAndDiffuse = ((int)0x1602),
    }

    public enum MatrixMode : int
    {
        Modelview = ((int)0x1700),
        Projection = ((int)0x1701),
        Texture = ((int)0x1702),
    }

    public enum Nvfence : int
    {
        AllCompletedNv = ((int)0x84F2),
        FenceStatusNv = ((int)0x84F3),
        FenceConditionNv = ((int)0x84F4),
        NvFence = ((int)1),
    }

    public enum OesBlendEquationSeparate : int
    {
        BlendEquationRgbOes = ((int)0x8009),
        BlendEquationAlphaOes = ((int)0x883D),
        OesBlendEquationSeparate = ((int)1),
    }

    public enum OesBlendFuncSeparate : int
    {
        BlendDstRgbOes = ((int)0x80C8),
        BlendSrcRgbOes = ((int)0x80C9),
        BlendDstAlphaOes = ((int)0x80CA),
        BlendSrcAlphaOes = ((int)0x80CB),
        OesBlendFuncSeparate = ((int)1),
    }

    public enum OesBlendSubtract : int
    {
        FuncAddOes = ((int)0x8006),
        BlendEquationOes = ((int)0x8009),
        FuncSubtractOes = ((int)0x800A),
        FuncReverseSubtractOes = ((int)0x800B),
        OesBlendSubtract = ((int)1),
    }

    public enum OesByteCoordinates : int
    {
        OesByteCoordinates = ((int)1),
    }

    public enum OesCompressedEtc1Rgb8Texture : int
    {
        Etc1Rgb8Oes = ((int)0x8D64),
        OesCompressedEtc1Rgb8Texture = ((int)1),
    }

    public enum OesCompressedPalettedTexture : int
    {
        Palette4Rgb8Oes = ((int)0x8B90),
        Palette4Rgba8Oes = ((int)0x8B91),
        Palette4R5G6B5Oes = ((int)0x8B92),
        Palette4Rgba4Oes = ((int)0x8B93),
        Palette4Rgb5A1Oes = ((int)0x8B94),
        Palette8Rgb8Oes = ((int)0x8B95),
        Palette8Rgba8Oes = ((int)0x8B96),
        Palette8R5G6B5Oes = ((int)0x8B97),
        Palette8Rgba4Oes = ((int)0x8B98),
        Palette8Rgb5A1Oes = ((int)0x8B99),
        OesCompressedPalettedTexture = ((int)1),
    }

    public enum OesDepth24 : int
    {
        DepthComponent24Oes = ((int)0x81A6),
        OesDepth24 = ((int)1),
    }

    public enum OesDepth32 : int
    {
        DepthComponent32Oes = ((int)0x81A7),
        OesDepth32 = ((int)1),
    }

    public enum OesDrawTexture : int
    {
        TextureCropRectOes = ((int)0x8B9D),
        OesDrawTexture = ((int)1),
    }

    public enum OesEglimage : int
    {
        OesEglImage = ((int)1),
    }

    public enum OesElementIndexUint : int
    {
        OesElementIndexUint = ((int)1),
    }

    public enum OesExtendedMatrixPalette : int
    {
        OesExtendedMatrixPalette = ((int)1),
    }

    public enum OesFboRenderMipmap : int
    {
        OesFboRenderMipmap = ((int)1),
    }

    public enum OesFixedPoint : int
    {
        FixedOes = ((int)0x140C),
        OesFixedPoint = ((int)1),
    }

    public enum OesFramebufferObject : int
    {
        NoneOes = ((int)0),
        InvalidFramebufferOperationOes = ((int)0x0506),
        Rgba4Oes = ((int)0x8056),
        Rgb5A1Oes = ((int)0x8057),
        DepthComponent16Oes = ((int)0x81A5),
        MaxRenderbufferSizeOes = ((int)0x84E8),
        FramebufferBindingOes = ((int)0x8CA6),
        RenderbufferBindingOes = ((int)0x8CA7),
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0),
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1),
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2),
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3),
        FramebufferCompleteOes = ((int)0x8CD5),
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6),
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7),
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9),
        FramebufferIncompleteFormatsOes = ((int)0x8CDA),
        FramebufferUnsupportedOes = ((int)0x8CDD),
        ColorAttachment0Oes = ((int)0x8CE0),
        DepthAttachmentOes = ((int)0x8D00),
        StencilAttachmentOes = ((int)0x8D20),
        FramebufferOes = ((int)0x8D40),
        RenderbufferOes = ((int)0x8D41),
        RenderbufferWidthOes = ((int)0x8D42),
        RenderbufferHeightOes = ((int)0x8D43),
        RenderbufferInternalFormatOes = ((int)0x8D44),
        RenderbufferRedSizeOes = ((int)0x8D50),
        RenderbufferGreenSizeOes = ((int)0x8D51),
        RenderbufferBlueSizeOes = ((int)0x8D52),
        RenderbufferAlphaSizeOes = ((int)0x8D53),
        RenderbufferDepthSizeOes = ((int)0x8D54),
        RenderbufferStencilSizeOes = ((int)0x8D55),
        Rgb565Oes = ((int)0x8D62),
        OesFramebufferObject = ((int)1),
    }

    public enum OesMapbuffer : int
    {
        WriteOnlyOes = ((int)0x88B9),
        BufferAccessOes = ((int)0x88BB),
        BufferMappedOes = ((int)0x88BC),
        BufferMapPointerOes = ((int)0x88BD),
        OesMapbuffer = ((int)1),
    }

    public enum OesMatrixGet : int
    {
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D),
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E),
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F),
        OesMatrixGet = ((int)1),
    }

    public enum OesMatrixPalette : int
    {
        MaxVertexUnitsOes = ((int)0x86A4),
        WeightArrayTypeOes = ((int)0x86A9),
        WeightArrayStrideOes = ((int)0x86AA),
        WeightArraySizeOes = ((int)0x86AB),
        WeightArrayPointerOes = ((int)0x86AC),
        WeightArrayOes = ((int)0x86AD),
        MatrixPaletteOes = ((int)0x8840),
        MaxPaletteMatricesOes = ((int)0x8842),
        CurrentPaletteMatrixOes = ((int)0x8843),
        MatrixIndexArrayOes = ((int)0x8844),
        MatrixIndexArraySizeOes = ((int)0x8846),
        MatrixIndexArrayTypeOes = ((int)0x8847),
        MatrixIndexArrayStrideOes = ((int)0x8848),
        MatrixIndexArrayPointerOes = ((int)0x8849),
        WeightArrayBufferBindingOes = ((int)0x889E),
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E),
        OesMatrixPalette = ((int)1),
    }

    public enum OesPackedDepthStencil : int
    {
        DepthStencilOes = ((int)0x84F9),
        UnsignedInt248Oes = ((int)0x84FA),
        Depth24Stencil8Oes = ((int)0x88F0),
        OesPackedDepthStencil = ((int)1),
    }

    public enum OesPointSizeArray : int
    {
        PointSizeArrayTypeOes = ((int)0x898A),
        PointSizeArrayStrideOes = ((int)0x898B),
        PointSizeArrayPointerOes = ((int)0x898C),
        PointSizeArrayOes = ((int)0x8B9C),
        PointSizeArrayBufferBindingOes = ((int)0x8B9F),
        OesPointSizeArray = ((int)1),
    }

    public enum OesPointSprite : int
    {
        PointSpriteOes = ((int)0x8861),
        CoordReplaceOes = ((int)0x8862),
        OesPointSprite = ((int)1),
    }

    public enum OesQueryMatrix : int
    {
        OesQueryMatrix = ((int)1),
    }

    public enum OesReadFormat : int
    {
        ImplementationColorReadTypeOes = ((int)0x8B9A),
        ImplementationColorReadFormatOes = ((int)0x8B9B),
        OesReadFormat = ((int)1),
    }

    public enum OesRgb8Rgba8 : int
    {
        Rgb8Oes = ((int)0x8051),
        Rgba8Oes = ((int)0x8058),
        OesRgb8Rgba8 = ((int)1),
    }

    public enum OesSinglePrecision : int
    {
        OesSinglePrecision = ((int)1),
    }

    public enum OesStencil1 : int
    {
        StencilIndex1Oes = ((int)0x8D46),
        OesStencil1 = ((int)1),
    }

    public enum OesStencil4 : int
    {
        StencilIndex4Oes = ((int)0x8D47),
        OesStencil4 = ((int)1),
    }

    public enum OesStencil8 : int
    {
        StencilIndex8Oes = ((int)0x8D48),
        OesStencil8 = ((int)1),
    }

    public enum OesStencilWrap : int
    {
        IncrWrapOes = ((int)0x8507),
        DecrWrapOes = ((int)0x8508),
        OesStencilWrap = ((int)1),
    }

    public enum OesTextureCubeMap : int
    {
        TextureGenModeOes = ((int)0x2500),
        NormalMapOes = ((int)0x8511),
        ReflectionMapOes = ((int)0x8512),
        TextureCubeMapOes = ((int)0x8513),
        TextureBindingCubeMapOes = ((int)0x8514),
        TextureCubeMapPositiveXOes = ((int)0x8515),
        TextureCubeMapNegativeXOes = ((int)0x8516),
        TextureCubeMapPositiveYOes = ((int)0x8517),
        TextureCubeMapNegativeYOes = ((int)0x8518),
        TextureCubeMapPositiveZOes = ((int)0x8519),
        TextureCubeMapNegativeZOes = ((int)0x851A),
        MaxCubeMapTextureSizeOes = ((int)0x851C),
        TextureGenStrOes = ((int)0x8D60),
        OesTextureCubeMap = ((int)1),
    }

    public enum OesTextureEnvCrossbar : int
    {
        OesTextureEnvCrossbar = ((int)1),
    }

    public enum OesTextureMirroredRepeat : int
    {
        MirroredRepeatOes = ((int)0x8370),
        OesTextureMirroredRepeat = ((int)1),
    }

    public enum OpenGlescoreVersions : int
    {
        VersionEsCl10 = ((int)1),
        VersionEsCl11 = ((int)1),
        VersionEsCm10 = ((int)1),
        VersionEsCm11 = ((int)1),
    }

    public enum PixelFormat : int
    {
        Alpha = ((int)0x1906),
        Rgb = ((int)0x1907),
        Rgba = ((int)0x1908),
        Luminance = ((int)0x1909),
        LuminanceAlpha = ((int)0x190A),
    }

    public enum PixelStoreParameter : int
    {
        UnpackAlignment = ((int)0x0CF5),
        PackAlignment = ((int)0x0D05),
    }

    public enum PixelType : int
    {
        UnsignedShort4444 = ((int)0x8033),
        UnsignedShort5551 = ((int)0x8034),
        UnsignedShort565 = ((int)0x8363),
    }

    public enum QcomDriverControl : int
    {
        QcomDriverControl = ((int)1),
    }

    public enum QcomPerfmonGlobalMode : int
    {
        PerfmonGlobalModeQcom = ((int)0x8FA0),
        QcomPerfmonGlobalMode = ((int)1),
    }

    public enum ShadingModel : int
    {
        Flat = ((int)0x1D00),
        Smooth = ((int)0x1D01),
    }

    public enum StencilOp : int
    {
        Keep = ((int)0x1E00),
        Replace = ((int)0x1E01),
        Incr = ((int)0x1E02),
        Decr = ((int)0x1E03),
    }

    public enum StringName : int
    {
        Vendor = ((int)0x1F00),
        Renderer = ((int)0x1F01),
        Version = ((int)0x1F02),
        Extensions = ((int)0x1F03),
    }

    public enum TextureCombineDot3 : int
    {
        AlphaScale = ((int)0x0D1C),
        Subtract = ((int)0x84E7),
        Combine = ((int)0x8570),
        CombineRgb = ((int)0x8571),
        CombineAlpha = ((int)0x8572),
        RgbScale = ((int)0x8573),
        AddSigned = ((int)0x8574),
        Interpolate = ((int)0x8575),
        Constant = ((int)0x8576),
        PrimaryColor = ((int)0x8577),
        Previous = ((int)0x8578),
        Src0Rgb = ((int)0x8580),
        Src1Rgb = ((int)0x8581),
        Src2Rgb = ((int)0x8582),
        Src0Alpha = ((int)0x8588),
        Src1Alpha = ((int)0x8589),
        Src2Alpha = ((int)0x858A),
        Operand0Rgb = ((int)0x8590),
        Operand1Rgb = ((int)0x8591),
        Operand2Rgb = ((int)0x8592),
        Operand0Alpha = ((int)0x8598),
        Operand1Alpha = ((int)0x8599),
        Operand2Alpha = ((int)0x859A),
        Dot3Rgb = ((int)0x86AE),
        Dot3Rgba = ((int)0x86AF),
    }

    public enum TextureEnvMode : int
    {
        Add = ((int)0x0104),
        Modulate = ((int)0x2100),
        Decal = ((int)0x2101),
    }

    public enum TextureEnvParameter : int
    {
        TextureEnvMode = ((int)0x2200),
        TextureEnvColor = ((int)0x2201),
    }

    public enum TextureEnvTarget : int
    {
        TextureEnv = ((int)0x2300),
    }

    public enum TextureMagFilter : int
    {
        Nearest = ((int)0x2600),
        Linear = ((int)0x2601),
    }

    public enum TextureMinFilter : int
    {
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
        GenerateMipmap = ((int)0x8191),
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
        ClientActiveTexture = ((int)0x84E1),
    }

    public enum TextureWrapMode : int
    {
        Repeat = ((int)0x2901),
        ClampToEdge = ((int)0x812F),
    }

}
