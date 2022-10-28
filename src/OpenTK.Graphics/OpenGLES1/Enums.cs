// This file is auto generated, do not edit.
using System;

namespace OpenTK.Graphics.OpenGLES1
{
#pragma warning disable CA1069 // Enums values should not be duplicated
    public enum All : uint
    {
        VersionEsCl10 = 1,
        VersionEsCm11 = 1,
        VersionEsCl11 = 1,
        DepthBufferBit = 256,
        StencilBufferBit = 1024,
        ColorBufferBit = 16384,
        False = 0,
        True = 1,
        Points = 0,
        Lines = 1,
        LineLoop = 2,
        LineStrip = 3,
        Triangles = 4,
        TriangleStrip = 5,
        TriangleFan = 6,
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519,
        Zero = 0,
        One = 1,
        SrcColor = 768,
        OneMinusSrcColor = 769,
        SrcAlpha = 770,
        OneMinusSrcAlpha = 771,
        DstAlpha = 772,
        OneMinusDstAlpha = 773,
        DstColor = 774,
        OneMinusDstColor = 775,
        SrcAlphaSaturate = 776,
        ClipPlane0 = 12288,
        ClipPlane1 = 12289,
        ClipPlane2 = 12290,
        ClipPlane3 = 12291,
        ClipPlane4 = 12292,
        ClipPlane5 = 12293,
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032,
        Fog = 2912,
        Lighting = 2896,
        Texture2d = 3553,
        CullFace = 2884,
        AlphaTest = 3008,
        Blend = 3042,
        ColorLogicOp = 3058,
        Dither = 3024,
        StencilTest = 2960,
        DepthTest = 2929,
        PointSmooth = 2832,
        LineSmooth = 2848,
        ScissorTest = 3089,
        ColorMaterial = 2903,
        Normalize = 2977,
        RescaleNormal = 32826,
        VertexArray = 32884,
        NormalArray = 32885,
        ColorArray = 32886,
        TextureCoordArray = 32888,
        Multisample = 32925,
        SampleAlphaToCoverage = 32926,
        SampleAlphaToOne = 32927,
        SampleCoverage = 32928,
        NoError = 0,
        InvalidEnum = 1280,
        InvalidValue = 1281,
        InvalidOperation = 1282,
        StackOverflow = 1283,
        StackUnderflow = 1284,
        OutOfMemory = 1285,
        Exp = 2048,
        Exp2 = 2049,
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
        FogColor = 2918,
        Cw = 2304,
        Ccw = 2305,
        CurrentColor = 2816,
        CurrentNormal = 2818,
        CurrentTextureCoords = 2819,
        PointSize = 2833,
        PointSizeMin = 33062,
        PointSizeMax = 33063,
        PointFadeThresholdSize = 33064,
        PointDistanceAttenuation = 33065,
        SmoothPointSizeRange = 2834,
        LineWidth = 2849,
        SmoothLineWidthRange = 2850,
        AliasedPointSizeRange = 33901,
        AliasedLineWidthRange = 33902,
        CullFaceMode = 2885,
        FrontFace = 2886,
        ShadeModel = 2900,
        DepthRange = 2928,
        DepthWritemask = 2930,
        DepthClearValue = 2931,
        DepthFunc = 2932,
        StencilClearValue = 2961,
        StencilFunc = 2962,
        StencilValueMask = 2963,
        StencilFail = 2964,
        StencilPassDepthFail = 2965,
        StencilPassDepthPass = 2966,
        StencilRef = 2967,
        StencilWritemask = 2968,
        MatrixMode = 2976,
        Viewport = 2978,
        ModelviewStackDepth = 2979,
        ProjectionStackDepth = 2980,
        TextureStackDepth = 2981,
        ModelviewMatrix = 2982,
        ProjectionMatrix = 2983,
        TextureMatrix = 2984,
        AlphaTestFunc = 3009,
        AlphaTestRef = 3010,
        BlendDst = 3040,
        BlendSrc = 3041,
        LogicOpMode = 3056,
        ScissorBox = 3088,
        ColorClearValue = 3106,
        ColorWritemask = 3107,
        MaxLights = 3377,
        MaxClipPlanes = 3378,
        MaxTextureSize = 3379,
        MaxModelviewStackDepth = 3382,
        MaxProjectionStackDepth = 3384,
        MaxTextureStackDepth = 3385,
        MaxViewportDims = 3386,
        MaxTextureUnits = 34018,
        SubpixelBits = 3408,
        RedBits = 3410,
        GreenBits = 3411,
        BlueBits = 3412,
        AlphaBits = 3413,
        DepthBits = 3414,
        StencilBits = 3415,
        PolygonOffsetUnits = 10752,
        PolygonOffsetFill = 32823,
        PolygonOffsetFactor = 32824,
        TextureBinding2d = 32873,
        VertexArraySize = 32890,
        VertexArrayType = 32891,
        VertexArrayStride = 32892,
        NormalArrayType = 32894,
        NormalArrayStride = 32895,
        ColorArraySize = 32897,
        ColorArrayType = 32898,
        ColorArrayStride = 32899,
        TextureCoordArraySize = 32904,
        TextureCoordArrayType = 32905,
        TextureCoordArrayStride = 32906,
        VertexArrayPointer = 32910,
        NormalArrayPointer = 32911,
        ColorArrayPointer = 32912,
        TextureCoordArrayPointer = 32914,
        SampleBuffers = 32936,
        Samples = 32937,
        SampleCoverageValue = 32938,
        SampleCoverageInvert = 32939,
        NumCompressedTextureFormats = 34466,
        CompressedTextureFormats = 34467,
        DontCare = 4352,
        Fastest = 4353,
        Nicest = 4354,
        PerspectiveCorrectionHint = 3152,
        PointSmoothHint = 3153,
        LineSmoothHint = 3154,
        FogHint = 3156,
        GenerateMipmapHint = 33170,
        LightModelAmbient = 2899,
        LightModelTwoSide = 2898,
        Ambient = 4608,
        Diffuse = 4609,
        Specular = 4610,
        Position = 4611,
        SpotDirection = 4612,
        SpotExponent = 4613,
        SpotCutoff = 4614,
        ConstantAttenuation = 4615,
        LinearAttenuation = 4616,
        QuadraticAttenuation = 4617,
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Float = 5126,
        Fixed = 5132,
        Clear = 5376,
        And = 5377,
        AndReverse = 5378,
        Copy = 5379,
        AndInverted = 5380,
        Noop = 5381,
        Xor = 5382,
        Or = 5383,
        Nor = 5384,
        Equiv = 5385,
        Invert = 5386,
        OrReverse = 5387,
        CopyInverted = 5388,
        OrInverted = 5389,
        Nand = 5390,
        Set = 5391,
        Emission = 5632,
        Shininess = 5633,
        AmbientAndDiffuse = 5634,
        Modelview = 5888,
        Projection = 5889,
        Texture = 5890,
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410,
        UnpackAlignment = 3317,
        PackAlignment = 3333,
        UnsignedShort4444 = 32819,
        UnsignedShort5551 = 32820,
        UnsignedShort565 = 33635,
        Flat = 7424,
        Smooth = 7425,
        Keep = 7680,
        Replace = 7681,
        Incr = 7682,
        Decr = 7683,
        Vendor = 7936,
        Renderer = 7937,
        Version = 7938,
        Extensions = 7939,
        Modulate = 8448,
        Decal = 8449,
        Add = 260,
        TextureEnvMode = 8704,
        TextureEnvColor = 8705,
        TextureEnv = 8960,
        Nearest = 9728,
        Linear = 9729,
        NearestMipmapNearest = 9984,
        LinearMipmapNearest = 9985,
        NearestMipmapLinear = 9986,
        LinearMipmapLinear = 9987,
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        GenerateMipmap = 33169,
        Texture0 = 33984,
        Texture1 = 33985,
        Texture2 = 33986,
        Texture3 = 33987,
        Texture4 = 33988,
        Texture5 = 33989,
        Texture6 = 33990,
        Texture7 = 33991,
        Texture8 = 33992,
        Texture9 = 33993,
        Texture10 = 33994,
        Texture11 = 33995,
        Texture12 = 33996,
        Texture13 = 33997,
        Texture14 = 33998,
        Texture15 = 33999,
        Texture16 = 34000,
        Texture17 = 34001,
        Texture18 = 34002,
        Texture19 = 34003,
        Texture20 = 34004,
        Texture21 = 34005,
        Texture22 = 34006,
        Texture23 = 34007,
        Texture24 = 34008,
        Texture25 = 34009,
        Texture26 = 34010,
        Texture27 = 34011,
        Texture28 = 34012,
        Texture29 = 34013,
        Texture30 = 34014,
        Texture31 = 34015,
        ActiveTexture = 34016,
        ClientActiveTexture = 34017,
        Repeat = 10497,
        ClampToEdge = 33071,
        Light0 = 16384,
        Light1 = 16385,
        Light2 = 16386,
        Light3 = 16387,
        Light4 = 16388,
        Light5 = 16389,
        Light6 = 16390,
        Light7 = 16391,
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963,
        ArrayBufferBinding = 34964,
        ElementArrayBufferBinding = 34965,
        VertexArrayBufferBinding = 34966,
        NormalArrayBufferBinding = 34967,
        ColorArrayBufferBinding = 34968,
        TextureCoordArrayBufferBinding = 34970,
        StaticDraw = 35044,
        DynamicDraw = 35048,
        BufferSize = 34660,
        BufferUsage = 34661,
        Subtract = 34023,
        Combine = 34160,
        CombineRgb = 34161,
        CombineAlpha = 34162,
        RgbScale = 34163,
        AddSigned = 34164,
        Interpolate = 34165,
        Constant = 34166,
        PrimaryColor = 34167,
        Previous = 34168,
        Operand0Rgb = 34192,
        Operand1Rgb = 34193,
        Operand2Rgb = 34194,
        Operand0Alpha = 34200,
        Operand1Alpha = 34201,
        Operand2Alpha = 34202,
        AlphaScale = 3356,
        Src0Rgb = 34176,
        Src1Rgb = 34177,
        Src2Rgb = 34178,
        Src0Alpha = 34184,
        Src1Alpha = 34185,
        Src2Alpha = 34186,
        Dot3Rgb = 34478,
        Dot3Rgba = 34479,
        _3dcXAmd = 34809,
        _3dcXyAmd = 34810,
        AtcRgbAmd = 35986,
        AtcRgbaExplicitAlphaAmd = 35987,
        AtcRgbaInterpolatedAlphaAmd = 34798,
        RenderbufferSamplesApple = 36011,
        FramebufferIncompleteMultisampleApple = 36182,
        MaxSamplesApple = 36183,
        ReadFramebufferApple = 36008,
        DrawFramebufferApple = 36009,
        DrawFramebufferBindingApple = 36006,
        ReadFramebufferBindingApple = 36010,
        SyncObjectApple = 35411,
        MaxServerWaitTimeoutApple = 37137,
        ObjectTypeApple = 37138,
        SyncConditionApple = 37139,
        SyncStatusApple = 37140,
        SyncFlagsApple = 37141,
        SyncFenceApple = 37142,
        SyncGpuCommandsCompleteApple = 37143,
        UnsignaledApple = 37144,
        SignaledApple = 37145,
        AlreadySignaledApple = 37146,
        TimeoutExpiredApple = 37147,
        ConditionSatisfiedApple = 37148,
        WaitFailedApple = 37149,
        SyncFlushCommandsBitApple = 1,
        BgraExt = 32993,
        Bgra8Ext = 37793,
        TextureMaxLevelApple = 33085,
        MinExt = 32775,
        MaxExt = 32776,
        FuncAddExt = 32774,
        BlendEquationExt = 32777,
        ColorExt = 6144,
        DepthExt = 6145,
        StencilExt = 6146,
        MapReadBitExt = 1,
        MapWriteBitExt = 2,
        MapInvalidateRangeBitExt = 4,
        MapInvalidateBufferBitExt = 8,
        MapFlushExplicitBitExt = 16,
        MapUnsynchronizedBitExt = 32,
        FramebufferAttachmentTextureSamplesExt = 36204,
        RenderbufferSamplesExt = 36011,
        FramebufferIncompleteMultisampleExt = 36182,
        MaxSamplesExt = 36183,
        UnsignedShort4444RevExt = 33637,
        UnsignedShort1555RevExt = 33638,
        GuiltyContextResetExt = 33363,
        InnocentContextResetExt = 33364,
        UnknownContextResetExt = 33365,
        ContextRobustAccessExt = 37107,
        ResetNotificationStrategyExt = 33366,
        LoseContextOnResetExt = 33362,
        NoResetNotificationExt = 33377,
        SrgbExt = 35904,
        SrgbAlphaExt = 35906,
        Srgb8Alpha8Ext = 35907,
        FramebufferAttachmentColorEncodingExt = 33296,
        CompressedRgbS3tcDxt1Ext = 33776,
        CompressedRgbaS3tcDxt1Ext = 33777,
        TextureMaxAnisotropyExt = 34046,
        MaxTextureMaxAnisotropyExt = 34047,
        MaxTextureLodBiasExt = 34045,
        TextureFilterControlExt = 34048,
        TextureLodBiasExt = 34049,
        TextureImmutableFormatExt = 37167,
        Alpha8Ext = 32828,
        Luminance8Ext = 32832,
        Luminance8Alpha8Ext = 32837,
        Rgba32fExt = 34836,
        Rgb32fExt = 34837,
        Alpha32fExt = 34838,
        Luminance32fExt = 34840,
        LuminanceAlpha32fExt = 34841,
        Rgba16fExt = 34842,
        Rgb16fExt = 34843,
        Alpha16fExt = 34844,
        Luminance16fExt = 34846,
        LuminanceAlpha16fExt = 34847,
        Rgb10A2Ext = 32857,
        Rgb10Ext = 32850,
        R8Ext = 33321,
        Rg8Ext = 33323,
        R32fExt = 33326,
        Rg32fExt = 33328,
        R16fExt = 33325,
        Rg16fExt = 33327,
        RenderbufferSamplesImg = 37171,
        FramebufferIncompleteMultisampleImg = 37172,
        MaxSamplesImg = 37173,
        TextureSamplesImg = 37174,
        BgraImg = 32993,
        UnsignedShort4444RevImg = 33637,
        CompressedRgbPvrtc4bppv1Img = 35840,
        CompressedRgbPvrtc2bppv1Img = 35841,
        CompressedRgbaPvrtc4bppv1Img = 35842,
        CompressedRgbaPvrtc2bppv1Img = 35843,
        ModulateColorImg = 35844,
        RecipAddSignedAlphaImg = 35845,
        TextureAlphaModulateImg = 35846,
        FactorAlphaModulateImg = 35847,
        FragmentAlphaModulateImg = 35848,
        AddBlendImg = 35849,
        Dot3RgbaImg = 34479,
        ClipPlane0Img = 12288,
        ClipPlane1Img = 12289,
        ClipPlane2Img = 12290,
        ClipPlane3Img = 12291,
        ClipPlane4Img = 12292,
        ClipPlane5Img = 12293,
        MaxClipPlanesImg = 3378,
        DebugOutputSynchronous = 33346,
        DebugNextLoggedMessageLength = 33347,
        DebugCallbackFunction = 33348,
        DebugCallbackUserParam = 33349,
        DebugSourceApi = 33350,
        DebugSourceWindowSystem = 33351,
        DebugSourceShaderCompiler = 33352,
        DebugSourceThirdParty = 33353,
        DebugSourceApplication = 33354,
        DebugSourceOther = 33355,
        DebugTypeError = 33356,
        DebugTypeDeprecatedBehavior = 33357,
        DebugTypeUndefinedBehavior = 33358,
        DebugTypePortability = 33359,
        DebugTypePerformance = 33360,
        DebugTypeOther = 33361,
        DebugTypeMarker = 33384,
        DebugTypePushGroup = 33385,
        DebugTypePopGroup = 33386,
        DebugSeverityNotification = 33387,
        MaxDebugGroupStackDepth = 33388,
        DebugGroupStackDepth = 33389,
        Buffer = 33504,
        Shader = 33505,
        Program = 33506,
        Query = 33507,
        ProgramPipeline = 33508,
        Sampler = 33510,
        MaxLabelLength = 33512,
        MaxDebugMessageLength = 37187,
        MaxDebugLoggedMessages = 37188,
        DebugLoggedMessages = 37189,
        DebugSeverityHigh = 37190,
        DebugSeverityMedium = 37191,
        DebugSeverityLow = 37192,
        DebugOutput = 37600,
        ContextFlagDebugBit = 2,
        DebugOutputSynchronousKhr = 33346,
        DebugNextLoggedMessageLengthKhr = 33347,
        DebugCallbackFunctionKhr = 33348,
        DebugCallbackUserParamKhr = 33349,
        DebugSourceApiKhr = 33350,
        DebugSourceWindowSystemKhr = 33351,
        DebugSourceShaderCompilerKhr = 33352,
        DebugSourceThirdPartyKhr = 33353,
        DebugSourceApplicationKhr = 33354,
        DebugSourceOtherKhr = 33355,
        DebugTypeErrorKhr = 33356,
        DebugTypeDeprecatedBehaviorKhr = 33357,
        DebugTypeUndefinedBehaviorKhr = 33358,
        DebugTypePortabilityKhr = 33359,
        DebugTypePerformanceKhr = 33360,
        DebugTypeOtherKhr = 33361,
        DebugTypeMarkerKhr = 33384,
        DebugTypePushGroupKhr = 33385,
        DebugTypePopGroupKhr = 33386,
        DebugSeverityNotificationKhr = 33387,
        MaxDebugGroupStackDepthKhr = 33388,
        DebugGroupStackDepthKhr = 33389,
        BufferKhr = 33504,
        ShaderKhr = 33505,
        ProgramKhr = 33506,
        VertexArrayKhr = 32884,
        QueryKhr = 33507,
        ProgramPipelineKhr = 33508,
        SamplerKhr = 33510,
        MaxLabelLengthKhr = 33512,
        MaxDebugMessageLengthKhr = 37187,
        MaxDebugLoggedMessagesKhr = 37188,
        DebugLoggedMessagesKhr = 37189,
        DebugSeverityHighKhr = 37190,
        DebugSeverityMediumKhr = 37191,
        DebugSeverityLowKhr = 37192,
        DebugOutputKhr = 37600,
        ContextFlagDebugBitKhr = 2,
        StackOverflowKhr = 1283,
        StackUnderflowKhr = 1284,
        AllCompletedNv = 34034,
        FenceStatusNv = 34035,
        FenceConditionNv = 34036,
        TextureExternalOes = 36197,
        TextureBindingExternalOes = 36199,
        RequiredTextureImageUnitsOes = 36200,
        SamplerExternalOes = 36198,
        BlendEquationRgbOes = 32777,
        BlendEquationAlphaOes = 34877,
        BlendDstRgbOes = 32968,
        BlendSrcRgbOes = 32969,
        BlendDstAlphaOes = 32970,
        BlendSrcAlphaOes = 32971,
        BlendEquationOes = 32777,
        FuncAddOes = 32774,
        FuncSubtractOes = 32778,
        FuncReverseSubtractOes = 32779,
        Etc1Rgb8Oes = 36196,
        Palette4Rgb8Oes = 35728,
        Palette4Rgba8Oes = 35729,
        Palette4R5G6B5Oes = 35730,
        Palette4Rgba4Oes = 35731,
        Palette4Rgb5A1Oes = 35732,
        Palette8Rgb8Oes = 35733,
        Palette8Rgba8Oes = 35734,
        Palette8R5G6B5Oes = 35735,
        Palette8Rgba4Oes = 35736,
        Palette8Rgb5A1Oes = 35737,
        DepthComponent24Oes = 33190,
        DepthComponent32Oes = 33191,
        TextureCropRectOes = 35741,
        UnsignedInt = 5125,
        FixedOes = 5132,
        NoneOes = 0,
        FramebufferOes = 36160,
        RenderbufferOes = 36161,
        Rgba4Oes = 32854,
        Rgb5A1Oes = 32855,
        Rgb565Oes = 36194,
        DepthComponent16Oes = 33189,
        RenderbufferWidthOes = 36162,
        RenderbufferHeightOes = 36163,
        RenderbufferInternalFormatOes = 36164,
        RenderbufferRedSizeOes = 36176,
        RenderbufferGreenSizeOes = 36177,
        RenderbufferBlueSizeOes = 36178,
        RenderbufferAlphaSizeOes = 36179,
        RenderbufferDepthSizeOes = 36180,
        RenderbufferStencilSizeOes = 36181,
        FramebufferAttachmentObjectTypeOes = 36048,
        FramebufferAttachmentObjectNameOes = 36049,
        FramebufferAttachmentTextureLevelOes = 36050,
        FramebufferAttachmentTextureCubeMapFaceOes = 36051,
        ColorAttachment0Oes = 36064,
        DepthAttachmentOes = 36096,
        StencilAttachmentOes = 36128,
        FramebufferCompleteOes = 36053,
        FramebufferIncompleteAttachmentOes = 36054,
        FramebufferIncompleteMissingAttachmentOes = 36055,
        FramebufferIncompleteDimensionsOes = 36057,
        FramebufferIncompleteFormatsOes = 36058,
        FramebufferUnsupportedOes = 36061,
        FramebufferBindingOes = 36006,
        RenderbufferBindingOes = 36007,
        MaxRenderbufferSizeOes = 34024,
        InvalidFramebufferOperationOes = 1286,
        WriteOnlyOes = 35001,
        BufferAccessOes = 35003,
        BufferMappedOes = 35004,
        BufferMapPointerOes = 35005,
        ModelviewMatrixFloatAsIntBitsOes = 35213,
        ProjectionMatrixFloatAsIntBitsOes = 35214,
        TextureMatrixFloatAsIntBitsOes = 35215,
        MaxVertexUnitsOes = 34468,
        MaxPaletteMatricesOes = 34882,
        MatrixPaletteOes = 34880,
        MatrixIndexArrayOes = 34884,
        WeightArrayOes = 34477,
        CurrentPaletteMatrixOes = 34883,
        MatrixIndexArraySizeOes = 34886,
        MatrixIndexArrayTypeOes = 34887,
        MatrixIndexArrayStrideOes = 34888,
        MatrixIndexArrayPointerOes = 34889,
        MatrixIndexArrayBufferBindingOes = 35742,
        WeightArraySizeOes = 34475,
        WeightArrayTypeOes = 34473,
        WeightArrayStrideOes = 34474,
        WeightArrayPointerOes = 34476,
        WeightArrayBufferBindingOes = 34974,
        DepthStencilOes = 34041,
        UnsignedInt248Oes = 34042,
        Depth24Stencil8Oes = 35056,
        PointSizeArrayOes = 35740,
        PointSizeArrayTypeOes = 35210,
        PointSizeArrayStrideOes = 35211,
        PointSizeArrayPointerOes = 35212,
        PointSizeArrayBufferBindingOes = 35743,
        PointSpriteOes = 34913,
        CoordReplaceOes = 34914,
        ImplementationColorReadTypeOes = 35738,
        ImplementationColorReadFormatOes = 35739,
        Alpha8Oes = 32828,
        Luminance4Alpha4Oes = 32835,
        Luminance8Alpha8Oes = 32837,
        Luminance8Oes = 32832,
        Rgb8Oes = 32849,
        Rgba8Oes = 32856,
        StencilIndex1Oes = 36166,
        StencilIndex4Oes = 36167,
        StencilIndex8Oes = 36168,
        IncrWrapOes = 34055,
        DecrWrapOes = 34056,
        FramebufferUndefinedOes = 33305,
        NormalMapOes = 34065,
        ReflectionMapOes = 34066,
        TextureCubeMapOes = 34067,
        TextureBindingCubeMapOes = 34068,
        TextureCubeMapPositiveXOes = 34069,
        TextureCubeMapNegativeXOes = 34070,
        TextureCubeMapPositiveYOes = 34071,
        TextureCubeMapNegativeYOes = 34072,
        TextureCubeMapPositiveZOes = 34073,
        TextureCubeMapNegativeZOes = 34074,
        MaxCubeMapTextureSizeOes = 34076,
        TextureGenModeOes = 9472,
        TextureGenStrOes = 36192,
        MirroredRepeatOes = 33648,
        VertexArrayBindingOes = 34229,
        TextureWidthQcom = 35794,
        TextureHeightQcom = 35795,
        TextureDepthQcom = 35796,
        TextureInternalFormatQcom = 35797,
        TextureFormatQcom = 35798,
        TextureTypeQcom = 35799,
        TextureImageValidQcom = 35800,
        TextureNumLevelsQcom = 35801,
        TextureTargetQcom = 35802,
        TextureObjectValidQcom = 35803,
        StateRestore = 35804,
        PerfmonGlobalModeQcom = 36768,
        ColorBufferBit0Qcom = 1,
        ColorBufferBit1Qcom = 2,
        ColorBufferBit2Qcom = 4,
        ColorBufferBit3Qcom = 8,
        ColorBufferBit4Qcom = 16,
        ColorBufferBit5Qcom = 32,
        ColorBufferBit6Qcom = 64,
        ColorBufferBit7Qcom = 128,
        DepthBufferBit0Qcom = 256,
        DepthBufferBit1Qcom = 512,
        DepthBufferBit2Qcom = 1024,
        DepthBufferBit3Qcom = 2048,
        DepthBufferBit4Qcom = 4096,
        DepthBufferBit5Qcom = 8192,
        DepthBufferBit6Qcom = 16384,
        DepthBufferBit7Qcom = 32768,
        StencilBufferBit0Qcom = 65536,
        StencilBufferBit1Qcom = 131072,
        StencilBufferBit2Qcom = 262144,
        StencilBufferBit3Qcom = 524288,
        StencilBufferBit4Qcom = 1048576,
        StencilBufferBit5Qcom = 2097152,
        StencilBufferBit6Qcom = 4194304,
        StencilBufferBit7Qcom = 8388608,
        MultisampleBufferBit0Qcom = 16777216,
        MultisampleBufferBit1Qcom = 33554432,
        MultisampleBufferBit2Qcom = 67108864,
        MultisampleBufferBit3Qcom = 134217728,
        MultisampleBufferBit4Qcom = 268435456,
        MultisampleBufferBit5Qcom = 536870912,
        MultisampleBufferBit6Qcom = 1073741824,
        MultisampleBufferBit7Qcom = 2147483648,
        WriteonlyRenderingQcom = 34851,
    }
    [Flags]
    public enum AttribMask : uint
    {
        DepthBufferBit = 256,
        StencilBufferBit = 1024,
        ColorBufferBit = 16384,
    }
    ///<summary>Used in <see cref="GL.Clear" /></summary>
    [Flags]
    public enum ClearBufferMask : uint
    {
        DepthBufferBit = 256,
        StencilBufferBit = 1024,
        ColorBufferBit = 16384,
    }
    [Flags]
    public enum BufferStorageMask : uint
    {
        MapReadBitExt = 1,
        MapWriteBitExt = 2,
    }
    [Flags]
    public enum ContextFlagMask : uint
    {
        ContextFlagDebugBit = 2,
        ContextFlagDebugBitKhr = 2,
    }
    ///<summary>Used in <see cref="GL.MapBufferRangeEXT" /></summary>
    [Flags]
    public enum MapBufferAccessMask : uint
    {
        MapReadBitExt = 1,
        MapWriteBitExt = 2,
        MapInvalidateRangeBitExt = 4,
        MapInvalidateBufferBitExt = 8,
        MapFlushExplicitBitExt = 16,
        MapUnsynchronizedBitExt = 32,
    }
    ///<summary>Used in <see cref="GL.ClientWaitSyncAPPLE" /></summary>
    [Flags]
    public enum SyncObjectMask : uint
    {
        SyncFlushCommandsBitApple = 1,
    }
    ///<summary>Used in <see cref="GL.EndTilingQCOM" />, <see cref="GL.StartTilingQCOM" /></summary>
    [Flags]
    public enum BufferBitQCOM : uint
    {
        ColorBufferBit0Qcom = 1,
        ColorBufferBit1Qcom = 2,
        ColorBufferBit2Qcom = 4,
        ColorBufferBit3Qcom = 8,
        ColorBufferBit4Qcom = 16,
        ColorBufferBit5Qcom = 32,
        ColorBufferBit6Qcom = 64,
        ColorBufferBit7Qcom = 128,
        DepthBufferBit0Qcom = 256,
        DepthBufferBit1Qcom = 512,
        DepthBufferBit2Qcom = 1024,
        DepthBufferBit3Qcom = 2048,
        DepthBufferBit4Qcom = 4096,
        DepthBufferBit5Qcom = 8192,
        DepthBufferBit6Qcom = 16384,
        DepthBufferBit7Qcom = 32768,
        StencilBufferBit0Qcom = 65536,
        StencilBufferBit1Qcom = 131072,
        StencilBufferBit2Qcom = 262144,
        StencilBufferBit3Qcom = 524288,
        StencilBufferBit4Qcom = 1048576,
        StencilBufferBit5Qcom = 2097152,
        StencilBufferBit6Qcom = 4194304,
        StencilBufferBit7Qcom = 8388608,
        MultisampleBufferBit0Qcom = 16777216,
        MultisampleBufferBit1Qcom = 33554432,
        MultisampleBufferBit2Qcom = 67108864,
        MultisampleBufferBit3Qcom = 134217728,
        MultisampleBufferBit4Qcom = 268435456,
        MultisampleBufferBit5Qcom = 536870912,
        MultisampleBufferBit6Qcom = 1073741824,
        MultisampleBufferBit7Qcom = 2147483648,
    }
    ///<summary>Used in <see cref="GL.ColorMask" />, <see cref="GL.DebugMessageControl" />, <see cref="GL.DebugMessageControlKHR" />, ...</summary>
    public enum Boolean : uint
    {
        False = 0,
        True = 1,
    }
    public enum VertexShaderWriteMaskEXT : uint
    {
        False = 0,
        True = 1,
    }
    public enum ClampColorModeARB : uint
    {
        False = 0,
        True = 1,
    }
    ///<summary>Used in <see cref="GL.GetGraphicsResetStatusEXT" /></summary>
    public enum GraphicsResetStatus : uint
    {
        NoError = 0,
    }
    ///<summary>Used in <see cref="GL.GetError" /></summary>
    public enum ErrorCode : uint
    {
        NoError = 0,
        InvalidEnum = 1280,
        InvalidValue = 1281,
        InvalidOperation = 1282,
        StackOverflow = 1283,
        StackUnderflow = 1284,
        OutOfMemory = 1285,
        InvalidFramebufferOperationOes = 1286,
    }
    public enum TextureSwizzle : uint
    {
        Zero = 0,
        One = 1,
        Alpha = 6406,
    }
    ///<summary>Used in <see cref="GL.StencilOp" /></summary>
    public enum StencilOp : uint
    {
        Zero = 0,
        Invert = 5386,
        Keep = 7680,
        Replace = 7681,
        Incr = 7682,
        Decr = 7683,
    }
    ///<summary>Used in <see cref="GL.BlendFunc" />, <see cref="GL.BlendFuncSeparateOES" /></summary>
    public enum BlendingFactor : uint
    {
        Zero = 0,
        One = 1,
        SrcColor = 768,
        OneMinusSrcColor = 769,
        SrcAlpha = 770,
        OneMinusSrcAlpha = 771,
        DstAlpha = 772,
        OneMinusDstAlpha = 773,
        DstColor = 774,
        OneMinusDstColor = 775,
        SrcAlphaSaturate = 776,
        Src1Alpha = 34185,
    }
    public enum FragmentShaderGenericSourceATI : uint
    {
        Zero = 0,
        One = 1,
        PrimaryColor = 34167,
    }
    public enum FragmentShaderValueRepATI : uint
    {
        Alpha = 6406,
    }
    ///<summary>Used in <see cref="GL.FenceSyncAPPLE" />, <see cref="GL.WaitSyncAPPLE" /></summary>
    public enum SyncBehaviorFlags : uint
    {
    }
    public enum PathColorFormat : uint
    {
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410,
    }
    public enum DrawBufferMode : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032,
        NoneOes = 0,
    }
    public enum PixelTexGenModeSGIX : uint
    {
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
    }
    public enum ReadBufferMode : uint
    {
        Front = 1028,
        Back = 1029,
        NoneOes = 0,
    }
    public enum ColorBuffer : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032,
    }
    public enum PathGenMode : uint
    {
        Constant = 34166,
    }
    ///<summary>Used in <see cref="GL.DrawArrays" />, <see cref="GL.DrawElements" />, <see cref="GL.MultiDrawArraysEXT" />, ...</summary>
    public enum PrimitiveType : uint
    {
        Points = 0,
        Lines = 1,
        LineLoop = 2,
        LineStrip = 3,
        Triangles = 4,
        TriangleStrip = 5,
        TriangleFan = 6,
    }
    public enum AccumOp : uint
    {
        Add = 260,
    }
    public enum TextureEnvMode : uint
    {
        Blend = 3042,
        Modulate = 8448,
        Decal = 8449,
        Add = 260,
    }
    public enum LightEnvModeSGIX : uint
    {
        Replace = 7681,
        Modulate = 8448,
        Add = 260,
    }
    ///<summary>Used in <see cref="GL.StencilFunc" /></summary>
    public enum StencilFunction : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519,
    }
    public enum IndexFunctionEXT : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519,
    }
    ///<summary>Used in <see cref="GL.AlphaFunc" />, <see cref="GL.AlphaFuncx" />, <see cref="GL.AlphaFuncxOES" /></summary>
    public enum AlphaFunction : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519,
    }
    ///<summary>Used in <see cref="GL.DepthFunc" /></summary>
    public enum DepthFunction : uint
    {
        Never = 512,
        Less = 513,
        Equal = 514,
        Lequal = 515,
        Greater = 516,
        Notequal = 517,
        Gequal = 518,
        Always = 519,
    }
    ///<summary>Used in <see cref="GL.CullFace" />, <see cref="GL.GetMaterialfv" />, <see cref="GL.GetMaterialxOES" />, ...</summary>
    public enum TriangleFace : uint
    {
        Front = 1028,
        Back = 1029,
        FrontAndBack = 1032,
    }
    public enum FogMode : uint
    {
        Exp = 2048,
        Exp2 = 2049,
        Linear = 9729,
    }
    ///<summary>Used in <see cref="GL.FrontFace" /></summary>
    public enum FrontFaceDirection : uint
    {
        Cw = 2304,
        Ccw = 2305,
    }
    ///<summary>Used in <see cref="GL.GetMapxvOES" /></summary>
    public enum GetMapQuery : uint
    {
    }
    ///<summary>Used in <see cref="GL.GetBooleanv" />, <see cref="GL.GetFixedv" />, <see cref="GL.GetFixedvOES" />, ...</summary>
    public enum GetPName : uint
    {
        ClipPlane0 = 12288,
        ClipPlane1 = 12289,
        ClipPlane2 = 12290,
        ClipPlane3 = 12291,
        ClipPlane4 = 12292,
        ClipPlane5 = 12293,
        Fog = 2912,
        Lighting = 2896,
        Texture2d = 3553,
        CullFace = 2884,
        AlphaTest = 3008,
        Blend = 3042,
        ColorLogicOp = 3058,
        Dither = 3024,
        StencilTest = 2960,
        DepthTest = 2929,
        PointSmooth = 2832,
        LineSmooth = 2848,
        ScissorTest = 3089,
        ColorMaterial = 2903,
        Normalize = 2977,
        VertexArray = 32884,
        NormalArray = 32885,
        ColorArray = 32886,
        TextureCoordArray = 32888,
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
        FogColor = 2918,
        CurrentColor = 2816,
        CurrentNormal = 2818,
        CurrentTextureCoords = 2819,
        PointSize = 2833,
        PointSizeMin = 33062,
        PointSizeMax = 33063,
        PointFadeThresholdSize = 33064,
        PointDistanceAttenuation = 33065,
        SmoothPointSizeRange = 2834,
        LineWidth = 2849,
        SmoothLineWidthRange = 2850,
        AliasedPointSizeRange = 33901,
        AliasedLineWidthRange = 33902,
        CullFaceMode = 2885,
        FrontFace = 2886,
        ShadeModel = 2900,
        DepthRange = 2928,
        DepthWritemask = 2930,
        DepthClearValue = 2931,
        DepthFunc = 2932,
        StencilClearValue = 2961,
        StencilFunc = 2962,
        StencilValueMask = 2963,
        StencilFail = 2964,
        StencilPassDepthFail = 2965,
        StencilPassDepthPass = 2966,
        StencilRef = 2967,
        StencilWritemask = 2968,
        MatrixMode = 2976,
        Viewport = 2978,
        ModelviewStackDepth = 2979,
        ProjectionStackDepth = 2980,
        TextureStackDepth = 2981,
        ModelviewMatrix = 2982,
        ProjectionMatrix = 2983,
        TextureMatrix = 2984,
        AlphaTestFunc = 3009,
        AlphaTestRef = 3010,
        BlendDst = 3040,
        BlendSrc = 3041,
        LogicOpMode = 3056,
        ScissorBox = 3088,
        ColorClearValue = 3106,
        ColorWritemask = 3107,
        MaxLights = 3377,
        MaxClipPlanes = 3378,
        MaxTextureSize = 3379,
        MaxModelviewStackDepth = 3382,
        MaxProjectionStackDepth = 3384,
        MaxTextureStackDepth = 3385,
        MaxViewportDims = 3386,
        SubpixelBits = 3408,
        RedBits = 3410,
        GreenBits = 3411,
        BlueBits = 3412,
        AlphaBits = 3413,
        DepthBits = 3414,
        StencilBits = 3415,
        PolygonOffsetUnits = 10752,
        PolygonOffsetFill = 32823,
        PolygonOffsetFactor = 32824,
        TextureBinding2d = 32873,
        VertexArraySize = 32890,
        VertexArrayType = 32891,
        VertexArrayStride = 32892,
        NormalArrayType = 32894,
        NormalArrayStride = 32895,
        ColorArraySize = 32897,
        ColorArrayType = 32898,
        ColorArrayStride = 32899,
        TextureCoordArraySize = 32904,
        TextureCoordArrayType = 32905,
        TextureCoordArrayStride = 32906,
        SampleBuffers = 32936,
        Samples = 32937,
        SampleCoverageValue = 32938,
        SampleCoverageInvert = 32939,
        NumCompressedTextureFormats = 34466,
        CompressedTextureFormats = 34467,
        PerspectiveCorrectionHint = 3152,
        PointSmoothHint = 3153,
        LineSmoothHint = 3154,
        FogHint = 3156,
        LightModelAmbient = 2899,
        LightModelTwoSide = 2898,
        UnpackAlignment = 3317,
        PackAlignment = 3333,
        ActiveTexture = 34016,
        Light0 = 16384,
        Light1 = 16385,
        Light2 = 16386,
        Light3 = 16387,
        Light4 = 16388,
        Light5 = 16389,
        Light6 = 16390,
        Light7 = 16391,
        ArrayBufferBinding = 34964,
        ElementArrayBufferBinding = 34965,
        AlphaScale = 3356,
        BlendEquationExt = 32777,
        MaxDebugGroupStackDepth = 33388,
        DebugGroupStackDepth = 33389,
        MaxLabelLength = 33512,
        BlendEquationOes = 32777,
        TextureBindingCubeMapOes = 34068,
        MaxCubeMapTextureSizeOes = 34076,
        TextureGenStrOes = 36192,
    }
    public enum VertexShaderTextureUnitParameter : uint
    {
        CurrentTextureCoords = 2819,
        TextureMatrix = 2984,
    }
    ///<summary>Used in <see cref="GL.Disable" />, <see cref="GL.DisableClientState" />, <see cref="GL.Enable" />, ...</summary>
    public enum EnableCap : uint
    {
        ClipPlane0 = 12288,
        ClipPlane1 = 12289,
        ClipPlane2 = 12290,
        ClipPlane3 = 12291,
        ClipPlane4 = 12292,
        ClipPlane5 = 12293,
        Fog = 2912,
        Lighting = 2896,
        Texture2d = 3553,
        CullFace = 2884,
        AlphaTest = 3008,
        Blend = 3042,
        ColorLogicOp = 3058,
        Dither = 3024,
        StencilTest = 2960,
        DepthTest = 2929,
        PointSmooth = 2832,
        LineSmooth = 2848,
        ScissorTest = 3089,
        ColorMaterial = 2903,
        Normalize = 2977,
        VertexArray = 32884,
        NormalArray = 32885,
        ColorArray = 32886,
        TextureCoordArray = 32888,
        Multisample = 32925,
        SampleAlphaToCoverage = 32926,
        SampleAlphaToOne = 32927,
        SampleCoverage = 32928,
        PolygonOffsetFill = 32823,
        Light0 = 16384,
        Light1 = 16385,
        Light2 = 16386,
        Light3 = 16387,
        Light4 = 16388,
        Light5 = 16389,
        Light6 = 16390,
        Light7 = 16391,
        DebugOutputSynchronous = 33346,
        DebugOutput = 37600,
        TextureCubeMapOes = 34067,
        TextureGenStrOes = 36192,
    }
    ///<summary>Used in <see cref="GL.LightModelf" />, <see cref="GL.LightModelfv" />, <see cref="GL.LightModelx" />, ...</summary>
    public enum LightModelParameter : uint
    {
        LightModelAmbient = 2899,
        LightModelTwoSide = 2898,
    }
    ///<summary>Used in <see cref="GL.Fogx" />, <see cref="GL.FogxOES" />, <see cref="GL.Fogxv" />, ...</summary>
    public enum FogPName : uint
    {
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
    }
    ///<summary>Used in <see cref="GL.Fogf" />, <see cref="GL.Fogfv" /></summary>
    public enum FogParameter : uint
    {
        FogDensity = 2914,
        FogStart = 2915,
        FogEnd = 2916,
        FogMode = 2917,
        FogColor = 2918,
    }
    public enum GetFramebufferParameter : uint
    {
        SampleBuffers = 32936,
        Samples = 32937,
    }
    ///<summary>Used in <see cref="GL.Hint" /></summary>
    public enum HintTarget : uint
    {
        PerspectiveCorrectionHint = 3152,
        PointSmoothHint = 3153,
        LineSmoothHint = 3154,
        FogHint = 3156,
        GenerateMipmapHint = 33170,
    }
    ///<summary>Used in <see cref="GL.GetPixelMapxv" />, <see cref="GL.PixelMapx" /></summary>
    public enum PixelMap : uint
    {
    }
    ///<summary>Used in <see cref="GL.PixelStorei" />, <see cref="GL.PixelStorex" /></summary>
    public enum PixelStoreParameter : uint
    {
        UnpackAlignment = 3317,
        PackAlignment = 3333,
    }
    ///<summary>Used in <see cref="GL.PixelTransferxOES" /></summary>
    public enum PixelTransferParameter : uint
    {
        AlphaScale = 3356,
    }
    ///<summary>Used in <see cref="GL.GetMapxvOES" />, <see cref="GL.Map1xOES" />, <see cref="GL.Map2xOES" /></summary>
    public enum MapTarget : uint
    {
    }
    public enum CopyImageSubDataTarget : uint
    {
        Texture2d = 3553,
    }
    ///<summary>Used in <see cref="GL.BindTexture" />, <see cref="GL.CompressedTexImage2D" />, <see cref="GL.CompressedTexSubImage2D" />, ...</summary>
    public enum TextureTarget : uint
    {
        Texture2d = 3553,
        TextureCubeMapOes = 34067,
        TextureCubeMapPositiveXOes = 34069,
        TextureCubeMapNegativeXOes = 34070,
        TextureCubeMapPositiveYOes = 34071,
        TextureCubeMapNegativeYOes = 34072,
        TextureCubeMapPositiveZOes = 34073,
        TextureCubeMapNegativeZOes = 34074,
    }
    ///<summary>Used in <see cref="GL.GetPointerv" /></summary>
    public enum GetPointervPName : uint
    {
        VertexArrayPointer = 32910,
        NormalArrayPointer = 32911,
        ColorArrayPointer = 32912,
        TextureCoordArrayPointer = 32914,
        DebugCallbackFunction = 33348,
        DebugCallbackUserParam = 33349,
    }
    ///<summary>Used in <see cref="GL.TexParameterf" />, <see cref="GL.TexParameterfv" />, <see cref="GL.TexParameteri" />, ...</summary>
    public enum TextureParameterName : uint
    {
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        GenerateMipmap = 33169,
    }
    ///<summary>Used in <see cref="GL.GetTexLevelParameterxvOES" />, <see cref="GL.GetTexParameterfv" />, <see cref="GL.GetTexParameteriv" />, ...</summary>
    public enum GetTextureParameter : uint
    {
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
        NormalMapOes = 34065,
        ReflectionMapOes = 34066,
    }
    ///<summary>Used in <see cref="GL.DebugMessageControl" />, <see cref="GL.DebugMessageControlKHR" />, <see cref="GL.DebugMessageInsert" />, ...</summary>
    public enum DebugSeverity : uint
    {
        DontCare = 4352,
        DebugSeverityNotification = 33387,
        DebugSeverityHigh = 37190,
        DebugSeverityMedium = 37191,
        DebugSeverityLow = 37192,
    }
    ///<summary>Used in <see cref="GL.Hint" /></summary>
    public enum HintMode : uint
    {
        DontCare = 4352,
        Fastest = 4353,
        Nicest = 4354,
    }
    ///<summary>Used in <see cref="GL.DebugMessageControl" />, <see cref="GL.DebugMessageControlKHR" />, <see cref="GL.DebugMessageInsert" />, ...</summary>
    public enum DebugSource : uint
    {
        DontCare = 4352,
        DebugSourceApi = 33350,
        DebugSourceWindowSystem = 33351,
        DebugSourceShaderCompiler = 33352,
        DebugSourceThirdParty = 33353,
        DebugSourceApplication = 33354,
        DebugSourceOther = 33355,
    }
    ///<summary>Used in <see cref="GL.DebugMessageControl" />, <see cref="GL.DebugMessageControlKHR" />, <see cref="GL.DebugMessageInsert" />, ...</summary>
    public enum DebugType : uint
    {
        DontCare = 4352,
        DebugTypeError = 33356,
        DebugTypeDeprecatedBehavior = 33357,
        DebugTypeUndefinedBehavior = 33358,
        DebugTypePortability = 33359,
        DebugTypePerformance = 33360,
        DebugTypeOther = 33361,
        DebugTypeMarker = 33384,
        DebugTypePushGroup = 33385,
        DebugTypePopGroup = 33386,
    }
    ///<summary>Used in <see cref="GL.GetMaterialfv" />, <see cref="GL.GetMaterialxOES" />, <see cref="GL.GetMaterialxv" />, ...</summary>
    public enum MaterialParameter : uint
    {
        Ambient = 4608,
        Diffuse = 4609,
        Specular = 4610,
        Emission = 5632,
        Shininess = 5633,
        AmbientAndDiffuse = 5634,
    }
    public enum FragmentLightParameterSGIX : uint
    {
        Ambient = 4608,
        Diffuse = 4609,
        Specular = 4610,
        Position = 4611,
        SpotDirection = 4612,
        SpotExponent = 4613,
        SpotCutoff = 4614,
        ConstantAttenuation = 4615,
        LinearAttenuation = 4616,
        QuadraticAttenuation = 4617,
    }
    public enum ColorMaterialParameter : uint
    {
        Ambient = 4608,
        Diffuse = 4609,
        Specular = 4610,
        Emission = 5632,
        AmbientAndDiffuse = 5634,
    }
    ///<summary>Used in <see cref="GL.GetLightfv" />, <see cref="GL.GetLightxOES" />, <see cref="GL.GetLightxv" />, ...</summary>
    public enum LightParameter : uint
    {
        Position = 4611,
        SpotDirection = 4612,
        SpotExponent = 4613,
        SpotCutoff = 4614,
        ConstantAttenuation = 4615,
        LinearAttenuation = 4616,
        QuadraticAttenuation = 4617,
    }
    public enum VertexAttribIType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
    }
    public enum WeightPointerTypeARB : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Float = 5126,
        UnsignedInt = 5125,
    }
    public enum TangentPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
        Float = 5126,
    }
    public enum BinormalPointerTypeEXT : uint
    {
        Byte = 5120,
        Short = 5122,
        Float = 5126,
    }
    ///<summary>Used in <see cref="GL.ColorPointer" /></summary>
    public enum ColorPointerType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
    }
    public enum ListNameType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Float = 5126,
        UnsignedInt = 5125,
    }
    ///<summary>Used in <see cref="GL.NormalPointer" /></summary>
    public enum NormalPointerType : uint
    {
        Byte = 5120,
        Short = 5122,
        Float = 5126,
    }
    ///<summary>Used in <see cref="GL.ExtGetTexSubImageQCOM" />, <see cref="GL.ReadnPixelsEXT" />, <see cref="GL.ReadPixels" />, ...</summary>
    public enum PixelType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Float = 5126,
        UnsignedShort4444 = 32819,
        UnsignedShort5551 = 32820,
        UnsignedShort565 = 33635,
        UnsignedShort4444RevExt = 33637,
        UnsignedShort1555RevExt = 33638,
        UnsignedShort4444RevImg = 33637,
        UnsignedInt = 5125,
        UnsignedInt248Oes = 34042,
    }
    public enum VertexAttribType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Float = 5126,
        Fixed = 5132,
        UnsignedInt = 5125,
    }
    public enum VertexAttribPointerType : uint
    {
        Byte = 5120,
        UnsignedByte = 5121,
        Short = 5122,
        UnsignedShort = 5123,
        Float = 5126,
        Fixed = 5132,
        UnsignedInt = 5125,
    }
    public enum ScalarType : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
    }
    public enum ReplacementCodeTypeSUN : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
    }
    public enum ElementPointerTypeATI : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
    }
    ///<summary>Used in <see cref="GL.MatrixIndexPointerOES" /></summary>
    public enum MatrixIndexPointerTypeARB : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
    }
    ///<summary>Used in <see cref="GL.DrawElements" />, <see cref="GL.MultiDrawElementsEXT" /></summary>
    public enum DrawElementsType : uint
    {
        UnsignedByte = 5121,
        UnsignedShort = 5123,
        UnsignedInt = 5125,
    }
    public enum SecondaryColorPointerTypeIBM : uint
    {
        Short = 5122,
        Float = 5126,
    }
    public enum IndexPointerType : uint
    {
        Short = 5122,
        Float = 5126,
    }
    ///<summary>Used in <see cref="GL.TexCoordPointer" /></summary>
    public enum TexCoordPointerType : uint
    {
        Short = 5122,
        Float = 5126,
    }
    ///<summary>Used in <see cref="GL.VertexPointer" /></summary>
    public enum VertexPointerType : uint
    {
        Short = 5122,
        Float = 5126,
    }
    ///<summary>Used in <see cref="GL.ExtGetTexSubImageQCOM" />, <see cref="GL.ReadnPixelsEXT" />, <see cref="GL.ReadPixels" />, ...</summary>
    public enum PixelFormat : uint
    {
        UnsignedShort = 5123,
        Alpha = 6406,
        Rgb = 6407,
        Rgba = 6408,
        Luminance = 6409,
        LuminanceAlpha = 6410,
        BgraExt = 32993,
        BgraImg = 32993,
        UnsignedInt = 5125,
    }
    public enum AttributeType : uint
    {
        Float = 5126,
        UnsignedInt = 5125,
    }
    public enum UniformType : uint
    {
        Float = 5126,
        UnsignedInt = 5125,
    }
    public enum MapTypeNV : uint
    {
        Float = 5126,
    }
    public enum VertexWeightPointerTypeEXT : uint
    {
        Float = 5126,
    }
    public enum FogCoordinatePointerType : uint
    {
        Float = 5126,
    }
    public enum FogPointerTypeEXT : uint
    {
        Float = 5126,
    }
    public enum FogPointerTypeIBM : uint
    {
        Float = 5126,
    }
    ///<summary>Used in <see cref="GL.LogicOp" /></summary>
    public enum LogicOp : uint
    {
        Clear = 5376,
        And = 5377,
        AndReverse = 5378,
        Copy = 5379,
        AndInverted = 5380,
        Noop = 5381,
        Xor = 5382,
        Or = 5383,
        Nor = 5384,
        Equiv = 5385,
        Invert = 5386,
        OrReverse = 5387,
        CopyInverted = 5388,
        OrInverted = 5389,
        Nand = 5390,
        Set = 5391,
    }
    public enum PathFillMode : uint
    {
        Invert = 5386,
    }
    ///<summary>Used in <see cref="GL.MatrixMode" /></summary>
    public enum MatrixMode : uint
    {
        Modelview = 5888,
        Projection = 5889,
        Texture = 5890,
    }
    ///<summary>Used in <see cref="GL.GetObjectLabel" />, <see cref="GL.ObjectLabel" />, <see cref="GL.ObjectLabelKHR" /></summary>
    public enum ObjectIdentifier : uint
    {
        VertexArray = 32884,
        Texture = 5890,
        Buffer = 33504,
        Shader = 33505,
        Program = 33506,
        Query = 33507,
        ProgramPipeline = 33508,
        Sampler = 33510,
    }
    public enum PixelCopyType : uint
    {
        ColorExt = 6144,
        DepthExt = 6145,
        StencilExt = 6146,
    }
    ///<summary>Used in <see cref="GL.DiscardFramebufferEXT" /></summary>
    public enum InvalidateFramebufferAttachment : uint
    {
        ColorAttachment0Oes = 36064,
        DepthAttachmentOes = 36096,
        StencilAttachmentOes = 36128,
    }
    ///<summary>Used in <see cref="GL.CompressedTexImage2D" />, <see cref="GL.CompressedTexSubImage2D" />, <see cref="GL.CopyTexImage2D" />, ...</summary>
    public enum InternalFormat : uint
    {
        Rgb = 6407,
        Rgba = 6408,
        SrgbExt = 35904,
        SrgbAlphaExt = 35906,
        Srgb8Alpha8Ext = 35907,
        CompressedRgbS3tcDxt1Ext = 33776,
        CompressedRgbaS3tcDxt1Ext = 33777,
        Alpha8Ext = 32828,
        Luminance8Ext = 32832,
        Luminance8Alpha8Ext = 32837,
        Rgba32fExt = 34836,
        Rgb32fExt = 34837,
        Rgba16fExt = 34842,
        Rgb16fExt = 34843,
        Rgb10A2Ext = 32857,
        Rgb10Ext = 32850,
        R8Ext = 33321,
        Rg8Ext = 33323,
        R32fExt = 33326,
        Rg32fExt = 33328,
        R16fExt = 33325,
        Rg16fExt = 33327,
        Etc1Rgb8Oes = 36196,
        DepthComponent24Oes = 33190,
        DepthComponent32Oes = 33191,
        Rgba4Oes = 32854,
        Rgb5A1Oes = 32855,
        Rgb565Oes = 36194,
        DepthComponent16Oes = 33189,
        DepthStencilOes = 34041,
        Depth24Stencil8Oes = 35056,
        Alpha8Oes = 32828,
        Luminance4Alpha4Oes = 32835,
        Luminance8Alpha8Oes = 32837,
        Luminance8Oes = 32832,
        Rgb8Oes = 32849,
        Rgba8Oes = 32856,
        StencilIndex1Oes = 36166,
        StencilIndex4Oes = 36167,
        StencilIndex8Oes = 36168,
    }
    public enum CombinerComponentUsageNV : uint
    {
        Alpha = 6406,
        Rgb = 6407,
    }
    public enum CombinerPortionNV : uint
    {
        Alpha = 6406,
        Rgb = 6407,
    }
    ///<summary>Used in <see cref="GL.ShadeModel" /></summary>
    public enum ShadingModel : uint
    {
        Flat = 7424,
        Smooth = 7425,
    }
    ///<summary>Used in <see cref="GL.GetString" /></summary>
    public enum StringName : uint
    {
        Vendor = 7936,
        Renderer = 7937,
        Version = 7938,
        Extensions = 7939,
    }
    ///<summary>Used in <see cref="GL.GetTexGenfvOES" />, <see cref="GL.GetTexGenivOES" />, <see cref="GL.GetTexGenxvOES" />, ...</summary>
    public enum TextureCoordName : uint
    {
        TextureGenStrOes = 36192,
    }
    ///<summary>Used in <see cref="GL.GetTexEnvfv" />, <see cref="GL.GetTexEnviv" />, <see cref="GL.GetTexEnvxv" />, ...</summary>
    public enum TextureEnvParameter : uint
    {
        TextureEnvMode = 8704,
        TextureEnvColor = 8705,
        Combine = 34160,
        CombineRgb = 34161,
        CombineAlpha = 34162,
        RgbScale = 34163,
        AddSigned = 34164,
        Interpolate = 34165,
        Constant = 34166,
        PrimaryColor = 34167,
        Previous = 34168,
        Operand0Rgb = 34192,
        Operand1Rgb = 34193,
        Operand2Rgb = 34194,
        Operand0Alpha = 34200,
        Operand1Alpha = 34201,
        Operand2Alpha = 34202,
        Src0Rgb = 34176,
        Src1Rgb = 34177,
        Src2Rgb = 34178,
        Src0Alpha = 34184,
        Src1Alpha = 34185,
        Src2Alpha = 34186,
    }
    ///<summary>Used in <see cref="GL.GetTexEnvfv" />, <see cref="GL.GetTexEnviv" />, <see cref="GL.GetTexEnvxv" />, ...</summary>
    public enum TextureEnvTarget : uint
    {
        TextureEnv = 8960,
    }
    ///<summary>Used in <see cref="GL.GetTexGenfvOES" />, <see cref="GL.GetTexGenivOES" />, <see cref="GL.GetTexGenxvOES" />, ...</summary>
    public enum TextureGenParameter : uint
    {
        TextureGenModeOes = 9472,
    }
    public enum BlitFramebufferFilter : uint
    {
        Nearest = 9728,
        Linear = 9729,
    }
    public enum TextureMagFilter : uint
    {
        Nearest = 9728,
        Linear = 9729,
    }
    public enum TextureMinFilter : uint
    {
        Nearest = 9728,
        Linear = 9729,
        NearestMipmapNearest = 9984,
        LinearMipmapNearest = 9985,
        NearestMipmapLinear = 9986,
        LinearMipmapLinear = 9987,
    }
    public enum TextureWrapMode : uint
    {
        LinearMipmapLinear = 9987,
        Repeat = 10497,
        ClampToEdge = 33071,
    }
    public enum SamplerParameterI : uint
    {
        TextureMagFilter = 10240,
        TextureMinFilter = 10241,
        TextureWrapS = 10242,
        TextureWrapT = 10243,
    }
    ///<summary>Used in <see cref="GL.TexStorage1DEXT" />, <see cref="GL.TexStorage2DEXT" />, <see cref="GL.TexStorage3DEXT" />, ...</summary>
    public enum SizedInternalFormat : uint
    {
        Srgb8Alpha8Ext = 35907,
        CompressedRgbS3tcDxt1Ext = 33776,
        CompressedRgbaS3tcDxt1Ext = 33777,
        Alpha8Ext = 32828,
        Luminance8Ext = 32832,
        Luminance8Alpha8Ext = 32837,
        Rgba32fExt = 34836,
        Rgb32fExt = 34837,
        Rgba16fExt = 34842,
        Rgb16fExt = 34843,
        Rgb10A2Ext = 32857,
        Rgb10Ext = 32850,
        R8Ext = 33321,
        Rg8Ext = 33323,
        R32fExt = 33326,
        Rg32fExt = 33328,
        R16fExt = 33325,
        Rg16fExt = 33327,
        Etc1Rgb8Oes = 36196,
        DepthComponent24Oes = 33190,
        DepthComponent32Oes = 33191,
        Rgba4Oes = 32854,
        Rgb5A1Oes = 32855,
        Rgb565Oes = 36194,
        DepthComponent16Oes = 33189,
        Depth24Stencil8Oes = 35056,
        Alpha8Oes = 32828,
        Luminance4Alpha4Oes = 32835,
        Luminance8Alpha8Oes = 32837,
        Luminance8Oes = 32832,
        Rgb8Oes = 32849,
        Rgba8Oes = 32856,
        StencilIndex1Oes = 36166,
        StencilIndex4Oes = 36167,
        StencilIndex8Oes = 36168,
    }
    ///<summary>Used in <see cref="GL.ClipPlanef" />, <see cref="GL.ClipPlanefIMG" />, <see cref="GL.ClipPlanefOES" />, ...</summary>
    public enum ClipPlaneName : uint
    {
        ClipPlane0 = 12288,
        ClipPlane1 = 12289,
        ClipPlane2 = 12290,
        ClipPlane3 = 12291,
        ClipPlane4 = 12292,
        ClipPlane5 = 12293,
    }
    ///<summary>Used in <see cref="GL.GetLightfv" />, <see cref="GL.GetLightxOES" />, <see cref="GL.GetLightxv" />, ...</summary>
    public enum LightName : uint
    {
        Light0 = 16384,
        Light1 = 16385,
        Light2 = 16386,
        Light3 = 16387,
        Light4 = 16388,
        Light5 = 16389,
        Light6 = 16390,
        Light7 = 16391,
    }
    ///<summary>Used in <see cref="GL.BlendEquationEXT" />, <see cref="GL.BlendEquationOES" />, <see cref="GL.BlendEquationSeparateOES" /></summary>
    public enum BlendEquationModeEXT : uint
    {
        MinExt = 32775,
        MaxExt = 32776,
        FuncAddExt = 32774,
    }
    ///<summary>Used in <see cref="GL.ConvolutionParameterxOES" />, <see cref="GL.ConvolutionParameterxvOES" /></summary>
    public enum ConvolutionTargetEXT : uint
    {
    }
    ///<summary>Used in <see cref="GL.ConvolutionParameterxOES" />, <see cref="GL.ConvolutionParameterxvOES" /></summary>
    public enum ConvolutionParameter : uint
    {
    }
    ///<summary>Used in <see cref="GL.GetHistogramParameterxvOES" /></summary>
    public enum HistogramTargetEXT : uint
    {
    }
    ///<summary>Used in <see cref="GL.GetHistogramParameterxvOES" /></summary>
    public enum GetHistogramParameterPNameEXT : uint
    {
    }
    public enum InternalFormatPName : uint
    {
        Samples = 32937,
        GenerateMipmap = 33169,
    }
    ///<summary>Used in <see cref="GL.BindBuffer" />, <see cref="GL.BufferData" />, <see cref="GL.BufferSubData" />, ...</summary>
    public enum BufferTargetARB : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963,
    }
    ///<summary>Used in <see cref="GL.PointParameterf" />, <see cref="GL.PointParameterfv" />, <see cref="GL.PointParameterx" />, ...</summary>
    public enum PointParameterNameARB : uint
    {
        PointSizeMin = 33062,
        PointSizeMax = 33063,
        PointFadeThresholdSize = 33064,
        PointDistanceAttenuation = 33065,
    }
    ///<summary>Used in <see cref="GL.GetFramebufferAttachmentParameterivOES" /></summary>
    public enum FramebufferAttachmentParameterName : uint
    {
        FramebufferAttachmentTextureSamplesExt = 36204,
        FramebufferAttachmentColorEncodingExt = 33296,
        FramebufferAttachmentObjectTypeOes = 36048,
        FramebufferAttachmentObjectNameOes = 36049,
        FramebufferAttachmentTextureLevelOes = 36050,
        FramebufferAttachmentTextureCubeMapFaceOes = 36051,
    }
    ///<summary>Used in <see cref="GL.CheckFramebufferStatusOES" /></summary>
    public enum FramebufferStatus : uint
    {
    }
    ///<summary>Used in <see cref="GL.FramebufferRenderbufferOES" />, <see cref="GL.FramebufferTexture2DMultisampleEXT" />, <see cref="GL.FramebufferTexture2DMultisampleIMG" />, ...</summary>
    public enum FramebufferAttachment : uint
    {
    }
    ///<summary>Used in <see cref="GL.GetBufferParameteriv" /></summary>
    public enum BufferPNameARB : uint
    {
        BufferSize = 34660,
        BufferUsage = 34661,
    }
    ///<summary>Used in <see cref="GL.ActiveTexture" />, <see cref="GL.ClientActiveTexture" />, <see cref="GL.MultiTexCoord1bOES" />, ...</summary>
    public enum TextureUnit : uint
    {
        Texture0 = 33984,
        Texture1 = 33985,
        Texture2 = 33986,
        Texture3 = 33987,
        Texture4 = 33988,
        Texture5 = 33989,
        Texture6 = 33990,
        Texture7 = 33991,
        Texture8 = 33992,
        Texture9 = 33993,
        Texture10 = 33994,
        Texture11 = 33995,
        Texture12 = 33996,
        Texture13 = 33997,
        Texture14 = 33998,
        Texture15 = 33999,
        Texture16 = 34000,
        Texture17 = 34001,
        Texture18 = 34002,
        Texture19 = 34003,
        Texture20 = 34004,
        Texture21 = 34005,
        Texture22 = 34006,
        Texture23 = 34007,
        Texture24 = 34008,
        Texture25 = 34009,
        Texture26 = 34010,
        Texture27 = 34011,
        Texture28 = 34012,
        Texture29 = 34013,
        Texture30 = 34014,
        Texture31 = 34015,
    }
    public enum FragmentShaderTextureSourceATI : uint
    {
        Texture0 = 33984,
        Texture1 = 33985,
        Texture2 = 33986,
        Texture3 = 33987,
        Texture4 = 33988,
        Texture5 = 33989,
        Texture6 = 33990,
        Texture7 = 33991,
        Texture8 = 33992,
        Texture9 = 33993,
        Texture10 = 33994,
        Texture11 = 33995,
        Texture12 = 33996,
        Texture13 = 33997,
        Texture14 = 33998,
        Texture15 = 33999,
        Texture16 = 34000,
        Texture17 = 34001,
        Texture18 = 34002,
        Texture19 = 34003,
        Texture20 = 34004,
        Texture21 = 34005,
        Texture22 = 34006,
        Texture23 = 34007,
        Texture24 = 34008,
        Texture25 = 34009,
        Texture26 = 34010,
        Texture27 = 34011,
        Texture28 = 34012,
        Texture29 = 34013,
        Texture30 = 34014,
        Texture31 = 34015,
    }
    ///<summary>Used in <see cref="GL.SetFenceNV" /></summary>
    public enum FenceConditionNV : uint
    {
        AllCompletedNv = 34034,
    }
    ///<summary>Used in <see cref="GL.GetFenceivNV" /></summary>
    public enum FenceParameterNameNV : uint
    {
        FenceStatusNv = 34035,
        FenceConditionNv = 34036,
    }
    public enum PathColor : uint
    {
        PrimaryColor = 34167,
    }
    public enum CopyBufferSubDataTarget : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963,
    }
    public enum BufferStorageTarget : uint
    {
        ArrayBuffer = 34962,
        ElementArrayBuffer = 34963,
    }
    ///<summary>Used in <see cref="GL.MapBufferOES" /></summary>
    public enum BufferAccessARB : uint
    {
    }
    ///<summary>Used in <see cref="GL.GetBufferPointervOES" /></summary>
    public enum BufferPointerNameARB : uint
    {
    }
    public enum VertexBufferObjectUsage : uint
    {
        StaticDraw = 35044,
        DynamicDraw = 35048,
    }
    ///<summary>Used in <see cref="GL.BufferData" /></summary>
    public enum BufferUsageARB : uint
    {
        StaticDraw = 35044,
        DynamicDraw = 35048,
    }
    ///<summary>Used in <see cref="GL.ExtGetProgramBinarySourceQCOM" /></summary>
    public enum ShaderType : uint
    {
    }
    ///<summary>Used in <see cref="GL.BindFramebufferOES" />, <see cref="GL.CheckFramebufferStatusOES" />, <see cref="GL.DiscardFramebufferEXT" />, ...</summary>
    public enum FramebufferTarget : uint
    {
        FramebufferOes = 36160,
    }
    ///<summary>Used in <see cref="GL.GetRenderbufferParameterivOES" /></summary>
    public enum RenderbufferParameterName : uint
    {
        RenderbufferSamplesApple = 36011,
        RenderbufferSamplesExt = 36011,
        RenderbufferSamplesImg = 37171,
        RenderbufferWidthOes = 36162,
        RenderbufferHeightOes = 36163,
        RenderbufferInternalFormatOes = 36164,
        RenderbufferRedSizeOes = 36176,
        RenderbufferGreenSizeOes = 36177,
        RenderbufferBlueSizeOes = 36178,
        RenderbufferAlphaSizeOes = 36179,
        RenderbufferDepthSizeOes = 36180,
        RenderbufferStencilSizeOes = 36181,
    }
    ///<summary>Used in <see cref="GL.BindRenderbufferOES" />, <see cref="GL.FramebufferRenderbufferOES" />, <see cref="GL.GetRenderbufferParameterivOES" />, ...</summary>
    public enum RenderbufferTarget : uint
    {
        RenderbufferOes = 36161,
    }
    ///<summary>Used in <see cref="GL.GetSyncivAPPLE" /></summary>
    public enum SyncParameterName : uint
    {
    }
    ///<summary>Used in <see cref="GL.FenceSyncAPPLE" /></summary>
    public enum SyncCondition : uint
    {
    }
    ///<summary>Used in <see cref="GL.ClientWaitSyncAPPLE" /></summary>
    public enum SyncStatus : uint
    {
    }
#pragma warning restore CA1069 // Enums values should not be duplicated
}
