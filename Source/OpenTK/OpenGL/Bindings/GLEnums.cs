namespace OpenTK.OpenGL
{
    namespace Enums
    {
        public enum AttribMask
        {
            ListBit = ((int)0x00020000),
            LightingBit = ((int)0x00000040),
            PointBit = ((int)0x00000002),
            AccumBufferBit = ((int)0x00000200),
            TransformBit = ((int)0x00001000),
            TextureBit = ((int)0x00040000),
            PixelModeBit = ((int)0x00000020),
            MultisampleBit = ((int)0x20000000),
            FogBit = ((int)0x00000080),
            EnableBit = ((int)0x00002000),
            LineBit = ((int)0x00000004),
            AllAttribBits = unchecked((int)0xffffffff),
            ViewportBit = ((int)0x00000800),
            HintBit = ((int)0x00008000),
            StencilBufferBit = ((int)0x00000400),
            CurrentBit = ((int)0x00000001),
            ScissorBit = ((int)0x00080000),
            PolygonBit = ((int)0x00000008),
            PolygonStippleBit = ((int)0x00000010),
            ColorBufferBit = ((int)0x00004000),
            EvalBit = ((int)0x00010000),
            DepthBufferBit = ((int)0x00000100),
        }

        public enum ClearBufferMask
        {
            StencilBufferBit = ((int)0x00000400),
            AccumBufferBit = ((int)0x00000200),
            ColorBufferBit = ((int)0x00004000),
            DepthBufferBit = ((int)0x00000100),
        }

        public enum ClientAttribMask
        {
            ClientPixelStoreBit = ((int)0x00000001),
            ClientAllAttribBits = unchecked((int)0xffffffff),
            ClientVertexArrayBit = ((int)0x00000002),
        }

        public enum Boolean
        {
            True = ((int)1),
            False = ((int)0),
        }

        public enum BeginMode
        {
            Quads = ((int)0x0007),
            QuadStrip = ((int)0x0008),
            Polygon = ((int)0x0009),
            Triangles = ((int)0x0004),
            Points = ((int)0x0000),
            LineLoop = ((int)0x0002),
            LineStrip = ((int)0x0003),
            TriangleFan = ((int)0x0006),
            TriangleStrip = ((int)0x0005),
            Lines = ((int)0x0001),
        }

        public enum AccumOp
        {
            Load = ((int)0x0101),
            Mult = ((int)0x0103),
            Return = ((int)0x0102),
            Accum = ((int)0x0100),
            Add = ((int)0x0104),
        }

        public enum AlphaFunction
        {
            Never = ((int)0x0200),
            Equal = ((int)0x0202),
            Always = ((int)0x0207),
            Less = ((int)0x0201),
            Gequal = ((int)0x0206),
            Lequal = ((int)0x0203),
            Notequal = ((int)0x0205),
            Greater = ((int)0x0204),
        }

        public enum BlendingFactorDest
        {
            ConstantColorExt = ((int)0x8001),
            OneMinusSrcAlpha = ((int)0x0303),
            One = ((int)1),
            OneMinusDstAlpha = ((int)0x0305),
            OneMinusConstantColorExt = ((int)0x8002),
            SrcColor = ((int)0x0300),
            OneMinusSrcColor = ((int)0x0301),
            ConstantAlphaExt = ((int)0x8003),
            SrcAlpha = ((int)0x0302),
            DstAlpha = ((int)0x0304),
            Zero = ((int)0),
            OneMinusConstantAlphaExt = ((int)0x8004),
        }

        public enum BlendingFactorSrc
        {
            ConstantColorExt = ((int)0x8001),
            OneMinusSrcAlpha = ((int)0x0303),
            One = ((int)1),
            SrcAlphaSaturate = ((int)0x0308),
            OneMinusConstantColorExt = ((int)0x8002),
            OneMinusDstAlpha = ((int)0x0305),
            OneMinusDstColor = ((int)0x0307),
            ConstantAlphaExt = ((int)0x8003),
            SrcAlpha = ((int)0x0302),
            DstColor = ((int)0x0306),
            Zero = ((int)0),
            DstAlpha = ((int)0x0304),
            OneMinusConstantAlphaExt = ((int)0x8004),
        }

        public enum BlendEquationModeExt
        {
            FuncSubtractExt = ((int)0x800a),
            FuncAddExt = ((int)0x8006),
            MaxExt = ((int)0x8008),
            AlphaMinSgix = ((int)0x8320),
            FuncReverseSubtractExt = ((int)0x800b),
            AlphaMaxSgix = ((int)0x8321),
            MinExt = ((int)0x8007),
            LogicOp = ((int)0x0bf1),
        }

        public enum ColorMaterialFace
        {
            Front = ((int)0x0404),
            FrontAndBack = ((int)0x0408),
            Back = ((int)0x0405),
        }

        public enum ColorMaterialParameter
        {
            Emission = ((int)0x1600),
            Specular = ((int)0x1202),
            AmbientAndDiffuse = ((int)0x1602),
            Diffuse = ((int)0x1201),
            Ambient = ((int)0x1200),
        }

        public enum ColorPointerType
        {
            UnsignedByte = ((int)0x1401),
            Byte = ((int)0x1400),
            UnsignedInt = ((int)0x1405),
            Short = ((int)0x1402),
            Int = ((int)0x1404),
            Float = ((int)0x1406),
            Double = ((int)0x140a),
            UnsignedShort = ((int)0x1403),
        }

        public enum ColorTableParameterPNameSgi
        {
            ColorTableScaleSgi = ((int)0x80d6),
            ColorTableBiasSgi = ((int)0x80d7),
        }

        public enum ColorTableTargetSgi
        {
            ProxyTextureColorTableSgi = ((int)0x80bd),
            PostColorMatrixColorTableSgi = ((int)0x80d2),
            ProxyPostConvolutionColorTableSgi = ((int)0x80d4),
            TextureColorTableSgi = ((int)0x80bc),
            PostConvolutionColorTableSgi = ((int)0x80d1),
            ProxyPostColorMatrixColorTableSgi = ((int)0x80d5),
            ProxyColorTableSgi = ((int)0x80d3),
            ColorTableSgi = ((int)0x80d0),
        }

        public enum ConvolutionBorderModeExt
        {
            ReduceExt = ((int)0x8016),
        }

        public enum ConvolutionParameterExt
        {
            ConvolutionFilterBiasExt = ((int)0x8015),
            ConvolutionFilterScaleExt = ((int)0x8014),
            ConvolutionBorderModeExt = ((int)0x8013),
        }

        public enum ConvolutionTargetExt
        {
            Convolution2dExt = ((int)0x8011),
            Convolution1dExt = ((int)0x8010),
        }

        public enum CullFaceMode
        {
            Front = ((int)0x0404),
            FrontAndBack = ((int)0x0408),
            Back = ((int)0x0405),
        }

        public enum DepthFunction
        {
            Never = ((int)0x0200),
            Equal = ((int)0x0202),
            Always = ((int)0x0207),
            Less = ((int)0x0201),
            Gequal = ((int)0x0206),
            Lequal = ((int)0x0203),
            Notequal = ((int)0x0205),
            Greater = ((int)0x0204),
        }

        public enum DrawBufferMode
        {
            FrontRight = ((int)0x0401),
            Right = ((int)0x0407),
            BackLeft = ((int)0x0402),
            BackRight = ((int)0x0403),
            Left = ((int)0x0406),
            Aux0 = ((int)0x0409),
            FrontAndBack = ((int)0x0408),
            Back = ((int)0x0405),
            Aux3 = ((int)0x040c),
            Aux1 = ((int)0x040a),
            FrontLeft = ((int)0x0400),
            None = ((int)0),
            Aux2 = ((int)0x040b),
            Front = ((int)0x0404),
        }

        public enum EnableCap
        {
            Light1 = ((int)0x4001),
                FragmentLight5Sgix = ((int)0x8411),
            FragmentLight6Sgix = ((int)0x8412),
            ColorMaterial = ((int)0x0b57),
            VertexProgramPointSize = ((int)0x8642),
            PolygonOffsetFill = ((int)0x8037),
            FragmentLight7Sgix = ((int)0x8413),
            Lighting = ((int)0x0b50),
            FragmentLight3Sgix = ((int)0x840f),
            FragmentLightingSgix = ((int)0x8400),
            PolygonStipple = ((int)0x0b42),
            CullFace = ((int)0x0b44),
            PostConvolutionColorTableSgi = ((int)0x80d1),
            Map1Normal = ((int)0x0d92),
            Multisample = ((int)0x809d),
                FragmentLight0Sgix = ((int)0x840c),
            FogOffsetSgix = ((int)0x8198),
            SampleAlphaToCoverage = ((int)0x809e),
            FogCoordArray = ((int)0x8457),
            Map2Normal = ((int)0x0db2),
            Fog = ((int)0x0b60),
            PolygonOffsetPoint = ((int)0x2a01),
            IndexLogicOp = ((int)0x0bf1),
            NormalArray = ((int)0x8075),
            ClipPlane3 = ((int)0x3003),
            AsyncHistogramSgix = ((int)0x832c),
            Light5 = ((int)0x4005),
            Light0 = ((int)0x4000),
            StencilTest = ((int)0x0b90),
            Texture3dExt = ((int)0x806f),
            ClipPlane0 = ((int)0x3000),
            SampleAlphaToOne = ((int)0x809f),
                Map1TextureCoord4 = ((int)0x0d96),
            TextureGenR = ((int)0x0c62),
            Map1TextureCoord2 = ((int)0x0d94),
            Map1TextureCoord3 = ((int)0x0d95),
            Map1TextureCoord1 = ((int)0x0d93),
            Map2TextureCoord4 = ((int)0x0db6),
            Map2TextureCoord2 = ((int)0x0db4),
            Map2TextureCoord3 = ((int)0x0db5),
            ScissorTest = ((int)0x0c11),
            Map2TextureCoord1 = ((int)0x0db3),
                ColorTableSgi = ((int)0x80d0),
            FragmentColorMaterialSgix = ((int)0x8401),
            Convolution2dExt = ((int)0x8011),
            Map2Vertex4 = ((int)0x0db8),
            HistogramExt = ((int)0x8024),
            Map2Vertex3 = ((int)0x0db7),
            TextureCoordArray = ((int)0x8078),
            DepthTest = ((int)0x0b71),
            VertexProgramTwoSide = ((int)0x8643),
            IndexArray = ((int)0x8077),
            ReferencePlaneSgix = ((int)0x817d),
            PixelTexGenSgix = ((int)0x8139),
            PixelTextureSgis = ((int)0x8353),
            IrInstrument1Sgix = ((int)0x817f),
            Map1Vertex4 = ((int)0x0d98),
            PointSprite = ((int)0x8861),
            Map1Vertex3 = ((int)0x0d97),
            AutoNormal = ((int)0x0d80),
            Dither = ((int)0x0bd0),
            SpriteSgix = ((int)0x8148),
            Light3 = ((int)0x4003),
            AsyncReadPixelsSgix = ((int)0x835e),
            ClipPlane1 = ((int)0x3001),
            ColorSum = ((int)0x8458),
            TextureCubeMap = ((int)0x8513),
            EdgeFlagArray = ((int)0x8079),
            SharedTexturePaletteExt = ((int)0x81fb),
            LineStipple = ((int)0x0b24),
            PolygonSmooth = ((int)0x0b41),
            Map2Color4 = ((int)0x0db0),
            ColorLogicOp = ((int)0x0bf2),
            Map2Index = ((int)0x0db1),
            TextureGenT = ((int)0x0c61),
            LineSmooth = ((int)0x0b20),
            FragmentLight4Sgix = ((int)0x8410),
            AsyncDrawPixelsSgix = ((int)0x835d),
            Texture4dSgis = ((int)0x8134),
            PointSmooth = ((int)0x0b10),
            VertexArray = ((int)0x8074),
            Light4 = ((int)0x4004),
            Separable2dExt = ((int)0x8012),
            TextureGenQ = ((int)0x0c63),
            Texture2d = ((int)0x0de1),
            Map1Index = ((int)0x0d91),
            Light7 = ((int)0x4007),
            Convolution1dExt = ((int)0x8010),
            Texture1d = ((int)0x0de0),
            Light2 = ((int)0x4002),
            ClipPlane2 = ((int)0x3002),
            TextureColorTableSgi = ((int)0x80bc),
            ClipPlane5 = ((int)0x3005),
            ClipPlane4 = ((int)0x3004),
            FragmentLight2Sgix = ((int)0x840e),
            Map1Color4 = ((int)0x0d90),
            RescaleNormal = ((int)0x803a),
            InterlaceSgix = ((int)0x8094),
            SampleCoverage = ((int)0x80a0),
            Normalize = ((int)0x0ba1),
            AlphaTest = ((int)0x0bc0),
            MinmaxExt = ((int)0x802e),
            Blend = ((int)0x0be2),
            ColorArray = ((int)0x8076),
            TextureGenS = ((int)0x0c60),
            FragmentLight1Sgix = ((int)0x840d),
            PostColorMatrixColorTableSgi = ((int)0x80d2),
            CalligraphicFragmentSgix = ((int)0x8183),
            Light6 = ((int)0x4006),
            SecondaryColorArray = ((int)0x845e),
            PolygonOffsetLine = ((int)0x2a02),
            AsyncTexImageSgix = ((int)0x835c),
            FramezoomSgix = ((int)0x818b),
        }

        public enum ErrorCode
        {
            InvalidEnum = ((int)0x0500),
            NoError = ((int)0),
            InvalidOperation = ((int)0x0502),
            TableTooLargeExt = ((int)0x8031),
            StackOverflow = ((int)0x0503),
            OutOfMemory = ((int)0x0505),
            StackUnderflow = ((int)0x0504),
            TextureTooLargeExt = ((int)0x8065),
            InvalidValue = ((int)0x0501),
        }

        public enum FeedbackType
        {
            Gl4dColorTexture = ((int)0x0604),
            Gl3dColor = ((int)0x0602),
            Gl3d = ((int)0x0601),
            Gl2d = ((int)0x0600),
            Gl3dColorTexture = ((int)0x0603),
        }

        public enum FeedBackToken
        {
            DrawPixelToken = ((int)0x0705),
            BitmapToken = ((int)0x0704),
            CopyPixelToken = ((int)0x0706),
            PointToken = ((int)0x0701),
            LineToken = ((int)0x0702),
            LineResetToken = ((int)0x0707),
            PolygonToken = ((int)0x0703),
            PassThroughToken = ((int)0x0700),
        }

        public enum FfdMaskSgix
        {
            GeometryDeformationBitSgix = ((int)0x00000002),
            TextureDeformationBitSgix = ((int)0x00000001),
        }

        public enum FfdTargetSgix
        {
            TextureDeformationSgix = ((int)0x8195),
            GeometryDeformationSgix = ((int)0x8194),
        }

        public enum FogMode
        {
            Exp2 = ((int)0x0801),
            FogFuncSgis = ((int)0x812a),
            Exp = ((int)0x0800),
            FogCoord = ((int)0x8451),
            FragmentDepth = ((int)0x8452),
            Linear = ((int)0x2601),
        }

        public enum FogParameter
        {
            FogColor = ((int)0x0b66),
            FogEnd = ((int)0x0b64),
            FogStart = ((int)0x0b63),
            FogDensity = ((int)0x0b62),
            FogIndex = ((int)0x0b61),
            FogOffsetValueSgix = ((int)0x8199),
            FogMode = ((int)0x0b65),
            FogCoordSrc = ((int)0x8450),
        }

        public enum FragmentLightModelParameterSgix
        {
            FragmentLightModelAmbientSgix = ((int)0x840a),
            FragmentLightModelLocalViewerSgix = ((int)0x8408),
            FragmentLightModelTwoSideSgix = ((int)0x8409),
            FragmentLightModelNormalInterpolationSgix = ((int)0x840b),
        }

        public enum FrontFaceDirection
        {
            Ccw = ((int)0x0901),
            Cw = ((int)0x0900),
        }

        public enum GetColorTableParameterPNameSgi
        {
            ColorTableBiasSgi = ((int)0x80d7),
            ColorTableIntensitySizeSgi = ((int)0x80df),
            ColorTableLuminanceSizeSgi = ((int)0x80de),
            ColorTableAlphaSizeSgi = ((int)0x80dd),
            ColorTableBlueSizeSgi = ((int)0x80dc),
            ColorTableScaleSgi = ((int)0x80d6),
            ColorTableWidthSgi = ((int)0x80d9),
            ColorTableFormatSgi = ((int)0x80d8),
            ColorTableRedSizeSgi = ((int)0x80da),
            ColorTableGreenSizeSgi = ((int)0x80db),
        }

        public enum GetConvolutionParameter
        {
            MaxConvolutionWidthExt = ((int)0x801a),
            ConvolutionHeightExt = ((int)0x8019),
            ConvolutionFormatExt = ((int)0x8017),
            MaxConvolutionHeightExt = ((int)0x801b),
            ConvolutionBorderModeExt = ((int)0x8013),
            ConvolutionWidthExt = ((int)0x8018),
            ConvolutionFilterScaleExt = ((int)0x8014),
            ConvolutionFilterBiasExt = ((int)0x8015),
        }

        public enum GetHistogramParameterPNameExt
        {
            HistogramAlphaSizeExt = ((int)0x802b),
            HistogramLuminanceSizeExt = ((int)0x802c),
            HistogramFormatExt = ((int)0x8027),
            HistogramGreenSizeExt = ((int)0x8029),
            HistogramSinkExt = ((int)0x802d),
            HistogramWidthExt = ((int)0x8026),
            HistogramBlueSizeExt = ((int)0x802a),
            HistogramRedSizeExt = ((int)0x8028),
        }

        public enum GetMapQuery
        {
            Coeff = ((int)0x0a00),
            Domain = ((int)0x0a02),
            Order = ((int)0x0a01),
        }

        public enum GetMinmaxParameterPNameExt
        {
            MinmaxSinkExt = ((int)0x8030),
            MinmaxFormatExt = ((int)0x802f),
        }

        public enum GetPixelMap
        {
            PixelMapIToI = ((int)0x0c70),
            PixelMapIToA = ((int)0x0c75),
            PixelMapIToB = ((int)0x0c74),
            PixelMapIToR = ((int)0x0c72),
            PixelMapBToB = ((int)0x0c78),
            PixelMapRToR = ((int)0x0c76),
            PixelMapIToG = ((int)0x0c73),
            PixelMapGToG = ((int)0x0c77),
            PixelMapAToA = ((int)0x0c79),
            PixelMapSToS = ((int)0x0c71),
        }

        public enum GetPointervPName
        {
            SecondaryColorArrayPointer = ((int)0x845d),
            EdgeFlagArrayPointer = ((int)0x8093),
            InstrumentBufferPointerSgix = ((int)0x8180),
            FogCoordArrayPointer = ((int)0x8456),
            FeedbackBufferPointer = ((int)0x0df0),
            VertexArrayPointer = ((int)0x808e),
            SelectionBufferPointer = ((int)0x0df3),
            ColorArrayPointer = ((int)0x8090),
            NormalArrayPointer = ((int)0x808f),
            TextureCoordArrayPointer = ((int)0x8092),
            IndexArrayPointer = ((int)0x8091),
        }

        public enum GetPName
        {
            AliasedLineWidthRange = ((int)0x846e),
            Map1TextureCoord4 = ((int)0x0d96),
            StencilBackPassDepthFail = ((int)0x8802),
            PolygonSmoothHint = ((int)0x0c53),
            DepthWritemask = ((int)0x0b72),
            PostConvolutionBlueScaleExt = ((int)0x801e),
            MaxFragmentUniformComponents = ((int)0x8b49),
            PixelMapSToSSize = ((int)0x0cb1),
            ColorArray = ((int)0x8076),
            MaxLights = ((int)0x0d31),
            StencilValueMask = ((int)0x0b93),
            LightModelLocalViewer = ((int)0x0b51),
            IndexArrayType = ((int)0x8085),
            ClipPlane3 = ((int)0x3003),
            PixelTileGridHeightSgix = ((int)0x8143),
            MaxDrawBuffers = ((int)0x8824),
            PerspectiveCorrectionHint = ((int)0x0c50),
            SampleAlphaToCoverage = ((int)0x809e),
            PixelPackBufferBinding = ((int)0x88ed),
            Map2GridSegments = ((int)0x0dd3),
            ColorMaterialParameter = ((int)0x0b56),
            Light4 = ((int)0x4004),
            Map2Normal = ((int)0x0db2),
            UnpackImageDepthSgis = ((int)0x8133),
            AsyncReadPixelsSgix = ((int)0x835e),
            PackResampleSgix = ((int)0x842c),
            DrawBuffer13 = ((int)0x8832),
            PackSkipRows = ((int)0x0d03),
            MaxTextureStackDepth = ((int)0x0d39),
                InstrumentMeasurementsSgix = ((int)0x8181),
            PointSizeMin = ((int)0x8126),
            PixelTextureSgis = ((int)0x8353),
            PointSmooth = ((int)0x0b10),
            TextureStackDepth = ((int)0x0ba5),
            MaxVaryingFloats = ((int)0x8b4b),
            ModelviewStackDepth = ((int)0x0ba3),
            IndexArrayStride = ((int)0x8086),
            PostConvolutionGreenScaleExt = ((int)0x801d),
                MaxAsyncTexImageSgix = ((int)0x835f),
            UnpackSwapBytes = ((int)0x0cf0),
            Texture4dSgis = ((int)0x8134),
            PixelMapAToASize = ((int)0x0cb9),
            PostColorMatrixRedBiasSgi = ((int)0x80b8),
            MaxTextureLodBias = ((int)0x84fd),
            PackSkipVolumesSgis = ((int)0x8130),
            LineSmooth = ((int)0x0b20),
            AsyncHistogramSgix = ((int)0x832c),
            DepthBits = ((int)0x0d56),
            FragmentLightModelNormalInterpolationSgix = ((int)0x840b),
            LineSmoothHint = ((int)0x0c52),
            ShadeModel = ((int)0x0b54),
            PixelTileBestAlignmentSgix = ((int)0x813e),
            MaxClipmapVirtualDepthSgix = ((int)0x8178),
            PixelTileHeightSgix = ((int)0x8141),
            CurrentSecondaryColor = ((int)0x8459),
            MaxAsyncReadPixelsSgix = ((int)0x8361),
            ColorClearValue = ((int)0x0c22),
            MaxProjectionStackDepth = ((int)0x0d38),
            AlphaTestRef = ((int)0x0bc2),
            ListIndex = ((int)0x0b33),
            Light1 = ((int)0x4001),
            PackSkipImagesExt = ((int)0x806b),
            PostConvolutionColorTableSgi = ((int)0x80d1),
            DepthBias = ((int)0x0d1f),
            VertexAttribArrayBufferBinding = ((int)0x889f),
            PackSkipPixels = ((int)0x0d04),
            MaxModelviewStackDepth = ((int)0x0d36),
            PostColorMatrixBlueScaleSgi = ((int)0x80b6),
            PixelMapIToISize = ((int)0x0cb0),
            NormalArrayStride = ((int)0x807f),
            MaxElementsVertices = ((int)0x80e8),
            FragmentLightModelTwoSideSgix = ((int)0x8409),
            EdgeFlagArrayCountExt = ((int)0x808d),
            CullFace = ((int)0x0b44),
            Texture1d = ((int)0x0de0),
            LightModelTwoSide = ((int)0x0b52),
            UnpackImageHeightExt = ((int)0x806e),
            SampleBuffers = ((int)0x80a8),
            FogIndex = ((int)0x0b61),
            FragmentColorMaterialParameterSgix = ((int)0x8403),
            ZoomY = ((int)0x0d17),
            Samples = ((int)0x80a9),
            DepthTest = ((int)0x0b71),
            LogicOpMode = ((int)0x0bf0),
            AsyncTexImageSgix = ((int)0x835c),
            Convolution2dExt = ((int)0x8011),
            Lighting = ((int)0x0b50),
            RedScale = ((int)0x0d14),
            StencilBits = ((int)0x0d57),
            UnpackCmykHintExt = ((int)0x800f),
            SampleCoverageValue = ((int)0x80aa),
            DrawBuffer8 = ((int)0x882d),
            ElementArrayBufferBinding = ((int)0x8895),
            DrawBuffer5 = ((int)0x882a),
            PostConvolutionRedBiasExt = ((int)0x8020),
            DrawBuffer1 = ((int)0x8826),
            BlueScale = ((int)0x0d1a),
            MaxVertexUniformComponents = ((int)0x8b4a),
            BlueBias = ((int)0x0d1b),
                Texture3dExt = ((int)0x806f),
            MaxPixelMapTable = ((int)0x0d34),
            SpriteSgix = ((int)0x8148),
            SmoothLineWidthGranularity = ((int)0x0b23),
            UnpackSkipVolumesSgis = ((int)0x8132),
            MaxTextureCoords = ((int)0x8871),
            AccumAlphaBits = ((int)0x0d5b),
            DrawBuffer9 = ((int)0x882e),
            DrawBuffer6 = ((int)0x882b),
            DrawBuffer7 = ((int)0x882c),
            DrawBuffer4 = ((int)0x8829),
            ClientAttribStackDepth = ((int)0x0bb1),
            DrawBuffer2 = ((int)0x8827),
            DrawBuffer3 = ((int)0x8828),
            DrawBuffer0 = ((int)0x8825),
            PixelMapIToASize = ((int)0x0cb5),
            UnpackResampleSgix = ((int)0x842d),
            IndexWritemask = ((int)0x0c21),
            Blend = ((int)0x0be2),
            ListBase = ((int)0x0b32),
            MaxAttribStackDepth = ((int)0x0d35),
            ColorArrayStride = ((int)0x8083),
            DepthScale = ((int)0x0d1e),
            PointSprite = ((int)0x8861),
            PixelTileCacheIncrementSgix = ((int)0x813f),
            ConvolutionHintSgix = ((int)0x8316),
            DepthClearValue = ((int)0x0b73),
            NormalArrayBufferBinding = ((int)0x8897),
            AccumRedBits = ((int)0x0d58),
            PostColorMatrixRedScaleSgi = ((int)0x80b4),
            ClipPlane1 = ((int)0x3001),
            PolygonOffsetBiasExt = ((int)0x8039),
            ArrayBufferBinding = ((int)0x8894),
            DetailTexture2dBindingSgis = ((int)0x8096),
            PackCmykHintExt = ((int)0x800e),
            TextureMatrix = ((int)0x0ba8),
            ActiveTexture = ((int)0x84e0),
            UnpackAlignment = ((int)0x0cf5),
            ColorMaterial = ((int)0x0b57),
            PointSizeMax = ((int)0x8127),
            AsyncDrawPixelsSgix = ((int)0x835d),
            UnpackLsbFirst = ((int)0x0cf1),
            MaxClipPlanes = ((int)0x0d32),
            Light6 = ((int)0x4006),
                Map1GridDomain = ((int)0x0dd0),
            ProjectionStackDepth = ((int)0x0ba4),
            PixelMapGToGSize = ((int)0x0cb7),
            CurrentRasterTextureCoords = ((int)0x0b06),
            TextureCoordArray = ((int)0x8078),
            Texture2d = ((int)0x0de1),
            TextureColorTableSgi = ((int)0x80bc),
            IndexBits = ((int)0x0d51),
            Convolution1dExt = ((int)0x8010),
            BlendColorExt = ((int)0x8005),
            SpriteAxisSgix = ((int)0x814a),
            RgbaMode = ((int)0x0c31),
            FogDensity = ((int)0x0b62),
            Separable2dExt = ((int)0x8012),
            PostConvolutionRedScaleExt = ((int)0x801c),
            StencilBackFunc = ((int)0x8800),
            Map2Vertex4 = ((int)0x0db8),
            ColorWritemask = ((int)0x0c23),
            Map2Vertex3 = ((int)0x0db7),
                PostConvolutionAlphaScaleExt = ((int)0x801f),
            TextureBinding1d = ((int)0x8068),
            MatrixMode = ((int)0x0ba0),
            SmoothPointSizeRange = ((int)0x0b12),
            BlendSrcRgb = ((int)0x80c9),
            SharedTexturePaletteExt = ((int)0x81fb),
            IndexLogicOp = ((int)0x0bf1),
            PackAlignment = ((int)0x0d05),
            LineStippleRepeat = ((int)0x0b26),
            MaxVertexTextureImageUnits = ((int)0x8b4c),
            ClipPlane4 = ((int)0x3004),
            PolygonSmooth = ((int)0x0b41),
            IndexShift = ((int)0x0d12),
            FogColor = ((int)0x0b66),
            FragmentLight0Sgix = ((int)0x840c),
            PostConvolutionAlphaBiasExt = ((int)0x8023),
            LineWidth = ((int)0x0b21),
            DrawBuffer12 = ((int)0x8831),
            ReferencePlaneSgix = ((int)0x817d),
            SpriteTranslationSgix = ((int)0x814b),
                MaxElementsIndices = ((int)0x80e9),
            LineStipple = ((int)0x0b24),
            CalligraphicFragmentSgix = ((int)0x8183),
            PackRowLength = ((int)0x0d02),
            Light3 = ((int)0x4003),
            SpriteModeSgix = ((int)0x8149),
            PixelTileGridWidthSgix = ((int)0x8142),
            PolygonOffsetFactor = ((int)0x8038),
            PixelTileGridDepthSgix = ((int)0x8144),
            PixelTexGenModeSgix = ((int)0x832b),
            Texture4dBindingSgis = ((int)0x814f),
            BlueBits = ((int)0x0d54),
            DrawBuffer14 = ((int)0x8833),
            BlendDstRgb = ((int)0x80c8),
            SelectionBufferSize = ((int)0x0df4),
            TextureCoordArrayBufferBinding = ((int)0x889a),
            Map2GridDomain = ((int)0x0dd2),
                CurrentRasterSecondaryColor = ((int)0x845f),
            MapStencil = ((int)0x0d11),
            PostColorMatrixBlueBiasSgi = ((int)0x80ba),
            LightEnvModeSgix = ((int)0x8407),
            PixelMapIToBSize = ((int)0x0cb4),
            Map1Color4 = ((int)0x0d90),
            DrawBuffer10 = ((int)0x882f),
                ProjectionMatrix = ((int)0x0ba7),
            IrInstrument1Sgix = ((int)0x817f),
            VertexArray = ((int)0x8074),
            StencilClearValue = ((int)0x0b91),
            IndexArrayBufferBinding = ((int)0x8899),
            MaxAsyncDrawPixelsSgix = ((int)0x8360),
            CurrentIndex = ((int)0x0b01),
                RedBits = ((int)0x0d52),
            SecondaryColorArrayType = ((int)0x845b),
            SamplePatternSgis = ((int)0x80ac),
            StencilTest = ((int)0x0b90),
            StencilBackWritemask = ((int)0x8ca5),
            PointSizeRange = ((int)0x0b12),
            AccumBlueBits = ((int)0x0d5a),
            Stereo = ((int)0x0c33),
            UnpackSubsampleRateSgix = ((int)0x85a1),
            TextureCompressionHint = ((int)0x84ef),
            PointSize = ((int)0x0b11),
            ColorArrayType = ((int)0x8082),
            MapColor = ((int)0x0d10),
            Map1Index = ((int)0x0d91),
            UnpackSkipImagesExt = ((int)0x806d),
            AlphaTest = ((int)0x0bc0),
            PointFadeThresholdSize = ((int)0x8128),
            AlphaBias = ((int)0x0d1d),
            CurrentRasterPosition = ((int)0x0b07),
                VertexPreclipHintSgix = ((int)0x83ef),
            AlphaScale = ((int)0x0d1c),
            VertexArrayStride = ((int)0x807c),
                PackLsbFirst = ((int)0x0d01),
            SampleCoverageInvert = ((int)0x80ab),
            FragmentColorMaterialFaceSgix = ((int)0x8402),
            BlendEquationRgb = ((int)0x8009),
            Map1GridSegments = ((int)0x0dd1),
            MaxFragmentLightsSgix = ((int)0x8404),
            FogOffsetSgix = ((int)0x8198),
            Map2Index = ((int)0x0db1),
            MaxAsyncHistogramSgix = ((int)0x832d),
            Light5 = ((int)0x4005),
            PolygonOffsetPoint = ((int)0x2a01),
            Light0 = ((int)0x4000),
            CompressedTextureFormats = ((int)0x86a3),
            AttribStackDepth = ((int)0x0bb0),
            AlphaBits = ((int)0x0d55),
            BlendEquationAlpha = ((int)0x883d),
            BlendDstAlpha = ((int)0x80ca),
            FramezoomSgix = ((int)0x818b),
            MaxFogFuncPointsSgis = ((int)0x812c),
            MaxTextureImageUnits = ((int)0x8872),
            MaxColorMatrixStackDepthSgi = ((int)0x80b3),
            PointSizeGranularity = ((int)0x0b13),
            PostConvolutionGreenBiasExt = ((int)0x8021),
            StencilBackRef = ((int)0x8ca3),
            FogFuncPointsSgis = ((int)0x812b),
            MaxViewportDims = ((int)0x0d3a),
            StencilBackPassDepthPass = ((int)0x8803),
            FogCoordArrayStride = ((int)0x8455),
                BlendDst = ((int)0x0be0),
            FragmentLightModelLocalViewerSgix = ((int)0x8408),
            PackSubsampleRateSgix = ((int)0x85a0),
            ModelviewMatrix = ((int)0x0ba6),
            MaxCombinedTextureImageUnits = ((int)0x8b4d),
            PackImageDepthSgis = ((int)0x8131),
            FogMode = ((int)0x0b65),
            IndexMode = ((int)0x0c30),
            AccumClearValue = ((int)0x0b80),
            TextureBinding3d = ((int)0x806a),
            TextureBinding2d = ((int)0x8069),
            PixelTileCacheSizeSgix = ((int)0x8145),
            DrawBuffer = ((int)0x0c01),
            Map1Normal = ((int)0x0d92),
            PointDistanceAttenuation = ((int)0x8129),
            FogHint = ((int)0x0c54),
            RescaleNormalExt = ((int)0x803a),
            LightModelColorControl = ((int)0x81f8),
            SubpixelBits = ((int)0x0d50),
            NormalArray = ((int)0x8075),
            PostTextureFilterBiasRangeSgix = ((int)0x817b),
            MaxEvalOrder = ((int)0x0d30),
            PixelTexGenSgix = ((int)0x8139),
            MaxClientAttribStackDepth = ((int)0x0d3b),
            BlendSrc = ((int)0x0be1),
            CullFaceMode = ((int)0x0b45),
            FragmentColorMaterialSgix = ((int)0x8401),
            Map1Vertex4 = ((int)0x0d98),
            FragmentShaderDerivativeHint = ((int)0x8b8b),
            Map1Vertex3 = ((int)0x0d97),
            CurrentRasterDistance = ((int)0x0b09),
            GenerateMipmapHint = ((int)0x8192),
            ClipPlane2 = ((int)0x3002),
            LogicOp = ((int)0x0bf1),
            Max3dTextureSize = ((int)0x8073),
            MaxCubeMapTextureSize = ((int)0x851c),
            SecondaryColorArrayBufferBinding = ((int)0x889c),
            RedBias = ((int)0x0d15),
            WeightArrayBufferBinding = ((int)0x889e),
                FeedbackBufferType = ((int)0x0df2),
            ColorArrayCountExt = ((int)0x8084),
            ScissorTest = ((int)0x0c11),
                StencilPassDepthPass = ((int)0x0b96),
            BlendSrcAlpha = ((int)0x80cb),
            Viewport = ((int)0x0ba2),
            AsyncMarkerSgix = ((int)0x8329),
            TextureCoordArrayStride = ((int)0x808a),
            StencilFunc = ((int)0x0b92),
            PixelMapIToGSize = ((int)0x0cb3),
            CurrentColor = ((int)0x0b00),
            StencilBackValueMask = ((int)0x8ca4),
            UnpackSkipPixels = ((int)0x0cf4),
            ColorMatrixStackDepthSgi = ((int)0x80b2),
            NormalArrayType = ((int)0x807e),
            AlphaTestFunc = ((int)0x0bc1),
            UnpackRowLength = ((int)0x0cf2),
            MaxClipmapDepthSgix = ((int)0x8177),
            VertexArraySize = ((int)0x807a),
            ColorSum = ((int)0x8458),
            EdgeFlag = ((int)0x0b43),
            EdgeFlagArray = ((int)0x8079),
            LineWidthRange = ((int)0x0b22),
            PackSwapBytes = ((int)0x0d00),
            ColorLogicOp = ((int)0x0bf2),
            SmoothLineWidthRange = ((int)0x0b22),
            TransposeModelviewMatrix = ((int)0x84e3),
            EdgeFlagArrayStride = ((int)0x808c),
            ZoomX = ((int)0x0d16),
            VertexPreclipSgix = ((int)0x83ee),
            PolygonOffsetFill = ((int)0x8037),
            DrawBuffer15 = ((int)0x8834),
            PixelMapBToBSize = ((int)0x0cb8),
            StencilWritemask = ((int)0x0b98),
            TransposeTextureMatrix = ((int)0x84e5),
            PostColorMatrixAlphaBiasSgi = ((int)0x80bb),
            CurrentNormal = ((int)0x0b02),
            LightModelAmbient = ((int)0x0b53),
            MaxNameStackDepth = ((int)0x0d37),
            SmoothPointSizeGranularity = ((int)0x0b13),
                AliasedPointSizeRange = ((int)0x846d),
            ListMode = ((int)0x0b30),
            ColorTableSgi = ((int)0x80d0),
            ColorArrayBufferBinding = ((int)0x8898),
            ClipPlane5 = ((int)0x3005),
            IndexArrayCountExt = ((int)0x8087),
            FrontFace = ((int)0x0b46),
            PackImageHeightExt = ((int)0x806c),
            TextureCoordArraySize = ((int)0x8088),
            FogStart = ((int)0x0b63),
            FragmentLightingSgix = ((int)0x8400),
            NameStackDepth = ((int)0x0d70),
            Light2 = ((int)0x4002),
            FogCoordArrayType = ((int)0x8454),
            PixelTileWidthSgix = ((int)0x8140),
            FogOffsetValueSgix = ((int)0x8199),
            InterlaceSgix = ((int)0x8094),
            GreenScale = ((int)0x0d18),
            IndexOffset = ((int)0x0d13),
            PixelUnpackBufferBinding = ((int)0x88ef),
            AccumGreenBits = ((int)0x0d59),
            HistogramExt = ((int)0x8024),
            PixelMapIToRSize = ((int)0x0cb2),
            CurrentTextureCoords = ((int)0x0b03),
            ReadBuffer = ((int)0x0c02),
            MaxListNesting = ((int)0x0b31),
            TextureCoordArrayType = ((int)0x8089),
            DrawBuffer11 = ((int)0x8830),
            MaxVertexAttribs = ((int)0x8869),
            ColorMaterialFace = ((int)0x0b55),
            PostColorMatrixColorTableSgi = ((int)0x80d2),
            SampleCoverage = ((int)0x80a0),
            AutoNormal = ((int)0x0d80),
            CurrentRasterIndex = ((int)0x0b05),
            Multisample = ((int)0x809d),
            AuxBuffers = ((int)0x0c00),
            StencilRef = ((int)0x0b97),
            FramezoomFactorSgix = ((int)0x818c),
            DepthRange = ((int)0x0b70),
            DeformationsMaskSgix = ((int)0x8196),
            PostConvolutionBlueBiasExt = ((int)0x8022),
            MaxFramezoomFactorSgix = ((int)0x818d),
            Map2Color4 = ((int)0x0db0),
            CurrentProgram = ((int)0x8b8d),
            MinmaxExt = ((int)0x802e),
            ColorMatrixSgi = ((int)0x80b1),
            CurrentFogCoord = ((int)0x8453),
            EdgeFlagArrayBufferBinding = ((int)0x889b),
            TextureBindingCubeMap = ((int)0x8514),
            TextureCubeMap = ((int)0x8513),
            LineWidthGranularity = ((int)0x0b23),
            LineStipplePattern = ((int)0x0b25),
            FogCoordArrayBufferBinding = ((int)0x889d),
            FeedbackBufferSize = ((int)0x0df1),
            FogEnd = ((int)0x0b64),
            TransposeColorMatrix = ((int)0x84e6),
            CurrentRasterPositionValid = ((int)0x0b08),
            Fog = ((int)0x0b60),
            UnpackSkipRows = ((int)0x0cf3),
            DepthFunc = ((int)0x0b74),
            IndexClearValue = ((int)0x0c20),
            Doublebuffer = ((int)0x0c32),
            CurrentRasterColor = ((int)0x0b04),
            NormalArrayCountExt = ((int)0x8080),
            TextureGenS = ((int)0x0c60),
            TextureGenR = ((int)0x0c62),
            TextureGenQ = ((int)0x0c63),
            ColorArraySize = ((int)0x8081),
            GreenBits = ((int)0x0d53),
            TextureGenT = ((int)0x0c61),
            SecondaryColorArraySize = ((int)0x845a),
            NumCompressedTextureFormats = ((int)0x86a2),
            Light7 = ((int)0x4007),
            VertexArrayCountExt = ((int)0x807d),
            Map2TextureCoord1 = ((int)0x0db3),
            MaxActiveLightsSgix = ((int)0x8405),
            VertexArrayType = ((int)0x807b),
            MaxTextureSize = ((int)0x0d33),
            Dither = ((int)0x0bd0),
            FragmentLightModelAmbientSgix = ((int)0x840a),
            Map1TextureCoord2 = ((int)0x0d94),
            Map1TextureCoord3 = ((int)0x0d95),
            SampleAlphaToOne = ((int)0x809f),
            Map1TextureCoord1 = ((int)0x0d93),
            PostColorMatrixAlphaScaleSgi = ((int)0x80b7),
            IndexArray = ((int)0x8077),
            PostColorMatrixGreenScaleSgi = ((int)0x80b5),
            ClipPlane0 = ((int)0x3000),
            PixelMapRToRSize = ((int)0x0cb6),
            ClientActiveTexture = ((int)0x84e1),
            Map2TextureCoord4 = ((int)0x0db6),
            TransposeProjectionMatrix = ((int)0x84e4),
            PolygonOffsetLine = ((int)0x2a02),
            Normalize = ((int)0x0ba1),
            PointSmoothHint = ((int)0x0c51),
            PostTextureFilterScaleRangeSgix = ((int)0x817c),
            ScissorBox = ((int)0x0c10),
            Max4dTextureSizeSgis = ((int)0x8138),
            RenderMode = ((int)0x0c40),
            StencilBackFail = ((int)0x8801),
            PolygonStipple = ((int)0x0b42),
            PostColorMatrixGreenBiasSgi = ((int)0x80b9),
            GreenBias = ((int)0x0d19),
            TextureCoordArrayCountExt = ((int)0x808b),
                Map2TextureCoord2 = ((int)0x0db4),
            Map2TextureCoord3 = ((int)0x0db5),
            PolygonMode = ((int)0x0b40),
            MaxTextureUnits = ((int)0x84e2),
            SecondaryColorArrayStride = ((int)0x845c),
            PolygonOffsetUnits = ((int)0x2a00),
            StencilFail = ((int)0x0b94),
            VertexArrayBufferBinding = ((int)0x8896),
            ReferencePlaneEquationSgix = ((int)0x817e),
            StencilPassDepthFail = ((int)0x0b95),
        }

        public enum GetTextureParameter
        {
            TextureCompareMode = ((int)0x884c),
            TextureHeight = ((int)0x1001),
            QuadTextureSelectSgis = ((int)0x8125),
            DetailTextureLevelSgis = ((int)0x809a),
            TextureGreenSize = ((int)0x805d),
            TextureCompressedImageSize = ((int)0x86a0),
            TextureCompressed = ((int)0x86a1),
            TextureMaxClampRSgix = ((int)0x836b),
            TexturePriority = ((int)0x8066),
            TextureLequalRSgix = ((int)0x819c),
            TextureMinLod = ((int)0x813a),
            TextureLodBiasTSgix = ((int)0x818f),
            Texture4dsizeSgis = ((int)0x8136),
                TextureClipmapCenterSgix = ((int)0x8171),
            TextureComponents = ((int)0x1003),
            TextureDepthSize = ((int)0x884a),
            TextureMaxClampTSgix = ((int)0x836a),
                TextureLodBiasRSgix = ((int)0x8190),
            TextureBaseLevel = ((int)0x813c),
            TextureLodBiasSSgix = ((int)0x818e),
            TextureLuminanceSize = ((int)0x8060),
            DepthTextureMode = ((int)0x884b),
            TextureClipmapOffsetSgix = ((int)0x8173),
            TextureWrapQSgis = ((int)0x8137),
                TextureClipmapFrameSgix = ((int)0x8172),
            TextureGequalRSgix = ((int)0x819d),
            SharpenTextureFuncPointsSgis = ((int)0x80b0),
            TextureWrapS = ((int)0x2802),
            TextureMinFilter = ((int)0x2801),
            TextureClipmapDepthSgix = ((int)0x8176),
            TextureFilter4SizeSgis = ((int)0x8147),
                TextureWrapR = ((int)0x8072),
            TextureCompareSgix = ((int)0x819a),
            TextureMaxClampSSgix = ((int)0x8369),
            DetailTextureModeSgis = ((int)0x809b),
            DetailTextureFuncPointsSgis = ((int)0x809c),
            DualTextureSelectSgis = ((int)0x8124),
            TextureClipmapLodOffsetSgix = ((int)0x8175),
                TextureRedSize = ((int)0x805c),
            TextureInternalFormat = ((int)0x1003),
            PostTextureFilterBiasSgix = ((int)0x8179),
            TextureIntensitySize = ((int)0x8061),
            TextureCompareOperatorSgix = ((int)0x819b),
                TextureMaxLod = ((int)0x813b),
            TextureBlueSize = ((int)0x805e),
                TextureDepth = ((int)0x8071),
            TextureWidth = ((int)0x1000),
            GenerateMipmap = ((int)0x8191),
            TextureAlphaSize = ((int)0x805f),
            ShadowAmbientSgix = ((int)0x80bf),
            PostTextureFilterScaleSgix = ((int)0x817a),
            TextureBorderColor = ((int)0x1004),
            TextureResident = ((int)0x8067),
            TextureCompareFunc = ((int)0x884d),
            TextureBorder = ((int)0x1005),
            TextureClipmapVirtualDepthSgix = ((int)0x8174),
            TextureMagFilter = ((int)0x2800),
            TextureWrapT = ((int)0x2803),
            TextureMaxLevel = ((int)0x813d),
        }

        public enum HintMode
        {
            Nicest = ((int)0x1102),
            Fastest = ((int)0x1101),
            DontCare = ((int)0x1100),
        }

        public enum HintTarget
        {
            PerspectiveCorrectionHint = ((int)0x0c50),
            VertexPreclipHintSgix = ((int)0x83ef),
            LineSmoothHint = ((int)0x0c52),
            UnpackCmykHintExt = ((int)0x800f),
            PolygonSmoothHint = ((int)0x0c53),
            ConvolutionHintSgix = ((int)0x8316),
            PackCmykHintExt = ((int)0x800e),
            TextureCompressionHint = ((int)0x84ef),
            PointSmoothHint = ((int)0x0c51),
            GenerateMipmapHint = ((int)0x8192),
            FogHint = ((int)0x0c54),
                TextureMultiBufferHintSgix = ((int)0x812e),
        }

        public enum HistogramTargetExt
        {
            ProxyHistogramExt = ((int)0x8025),
            HistogramExt = ((int)0x8024),
        }

        public enum IndexPointerType
        {
            Short = ((int)0x1402),
            Float = ((int)0x1406),
            Double = ((int)0x140a),
            Int = ((int)0x1404),
        }

        public enum LightEnvModeSgix
        {
            Replace = ((int)0x1e01),
            Add = ((int)0x0104),
            Modulate = ((int)0x2100),
        }

        public enum LightEnvParameterSgix
        {
            LightEnvModeSgix = ((int)0x8407),
        }

        public enum LightModelColorControl
        {
            SingleColor = ((int)0x81f9),
            SeparateSpecularColor = ((int)0x81fa),
        }

        public enum LightModelParameter
        {
            LightModelColorControl = ((int)0x81f8),
            LightModelTwoSide = ((int)0x0b52),
            LightModelAmbient = ((int)0x0b53),
            LightModelLocalViewer = ((int)0x0b51),
        }

        public enum LightParameter
        {
            Specular = ((int)0x1202),
            ConstantAttenuation = ((int)0x1207),
            SpotExponent = ((int)0x1205),
            LinearAttenuation = ((int)0x1208),
            Position = ((int)0x1203),
            Ambient = ((int)0x1200),
            Diffuse = ((int)0x1201),
            SpotCutoff = ((int)0x1206),
            SpotDirection = ((int)0x1204),
            QuadraticAttenuation = ((int)0x1209),
        }

        public enum ListMode
        {
            CompileAndExecute = ((int)0x1301),
            Compile = ((int)0x1300),
        }

        public enum DataType
        {
            UnsignedByte = ((int)0x1401),
            Byte = ((int)0x1400),
            Double = ((int)0x140a),
            UnsignedInt = ((int)0x1405),
                Short = ((int)0x1402),
            Int = ((int)0x1404),
            Float = ((int)0x1406),
            Gl4Bytes = ((int)0x1409),
            Gl3Bytes = ((int)0x1408),
            Gl2Bytes = ((int)0x1407),
            UnsignedShort = ((int)0x1403),
        }

        public enum ListNameType
        {
            UnsignedByte = ((int)0x1401),
            Byte = ((int)0x1400),
            UnsignedInt = ((int)0x1405),
            Short = ((int)0x1402),
            Int = ((int)0x1404),
            Float = ((int)0x1406),
            Gl4Bytes = ((int)0x1409),
            Gl3Bytes = ((int)0x1408),
            Gl2Bytes = ((int)0x1407),
            UnsignedShort = ((int)0x1403),
        }

        public enum ListParameterName
        {
            ListPrioritySgix = ((int)0x8182),
        }

        public enum LogicOp
        {
            Nor = ((int)0x1508),
            AndInverted = ((int)0x1504),
            CopyInverted = ((int)0x150c),
            Noop = ((int)0x1505),
            OrReverse = ((int)0x150b),
            AndReverse = ((int)0x1502),
            Nand = ((int)0x150e),
            Set = ((int)0x150f),
            Equiv = ((int)0x1509),
            Copy = ((int)0x1503),
            Or = ((int)0x1507),
            And = ((int)0x1501),
            Xor = ((int)0x1506),
            Clear = ((int)0x1500),
            OrInverted = ((int)0x150d),
            Invert = ((int)0x150a),
        }

        public enum MapTarget
        {
            GeometryDeformationSgix = ((int)0x8194),
            Map1Color4 = ((int)0x0d90),
            Map1Index = ((int)0x0d91),
            Map2Index = ((int)0x0db1),
            Map1Vertex4 = ((int)0x0d98),
            TextureDeformationSgix = ((int)0x8195),
            Map1Vertex3 = ((int)0x0d97),
            Map1Normal = ((int)0x0d92),
            Map2Vertex4 = ((int)0x0db8),
            Map2Color4 = ((int)0x0db0),
            Map2Vertex3 = ((int)0x0db7),
            Map2Normal = ((int)0x0db2),
            Map1TextureCoord4 = ((int)0x0d96),
            Map1TextureCoord2 = ((int)0x0d94),
            Map1TextureCoord3 = ((int)0x0d95),
            Map2TextureCoord2 = ((int)0x0db4),
            Map2TextureCoord3 = ((int)0x0db5),
            Map2TextureCoord1 = ((int)0x0db3),
            Map1TextureCoord1 = ((int)0x0d93),
            Map2TextureCoord4 = ((int)0x0db6),
        }

        public enum MaterialFace
        {
            Front = ((int)0x0404),
            FrontAndBack = ((int)0x0408),
            Back = ((int)0x0405),
        }

        public enum MaterialParameter
        {
            Emission = ((int)0x1600),
            ColorIndexes = ((int)0x1603),
            AmbientAndDiffuse = ((int)0x1602),
            Diffuse = ((int)0x1201),
            Ambient = ((int)0x1200),
            Specular = ((int)0x1202),
            Shininess = ((int)0x1601),
        }

        public enum MatrixMode
        {
            Color = ((int)0x1800),
            Modelview = ((int)0x1700),
            Projection = ((int)0x1701),
            Texture = ((int)0x1702),
        }

        public enum MeshMode1
        {
            Line = ((int)0x1b01),
            Point = ((int)0x1b00),
        }

        public enum MeshMode2
        {
            Line = ((int)0x1b01),
            Point = ((int)0x1b00),
            Fill = ((int)0x1b02),
        }

        public enum MinmaxTargetExt
        {
            MinmaxExt = ((int)0x802e),
        }

        public enum NormalPointerType
        {
            Short = ((int)0x1402),
            Float = ((int)0x1406),
            Double = ((int)0x140a),
            Byte = ((int)0x1400),
            Int = ((int)0x1404),
        }

        public enum PixelCopyType
        {
            Color = ((int)0x1800),
            Stencil = ((int)0x1802),
            Depth = ((int)0x1801),
        }

        public enum PixelFormat
        {
            CmykExt = ((int)0x800c),
            Rgb = ((int)0x1907),
            R5G6B5IccSgix = ((int)0x8466),
            R5G6B5A8IccSgix = ((int)0x8467),
            Green = ((int)0x1904),
            Blue = ((int)0x1905),
            Alpha16IccSgix = ((int)0x8468),
            Ycrcb444Sgix = ((int)0x81bc),
            Ycrcb422Sgix = ((int)0x81bb),
            Luminance = ((int)0x1909),
            Rgba = ((int)0x1908),
            StencilIndex = ((int)0x1901),
            Red = ((int)0x1903),
            DepthComponent = ((int)0x1902),
            Luminance16IccSgix = ((int)0x8469),
            Luminance16Alpha8IccSgix = ((int)0x846b),
            Bgra = ((int)0x80e1),
            Alpha = ((int)0x1906),
            ColorIndex = ((int)0x1900),
            CmykaExt = ((int)0x800d),
            Bgr = ((int)0x80e0),
            LuminanceAlpha = ((int)0x190a),
            AbgrExt = ((int)0x8000),
        }

        public enum PixelMap
        {
            PixelMapIToI = ((int)0x0c70),
            PixelMapIToA = ((int)0x0c75),
            PixelMapIToB = ((int)0x0c74),
            PixelMapIToR = ((int)0x0c72),
            PixelMapBToB = ((int)0x0c78),
            PixelMapRToR = ((int)0x0c76),
            PixelMapIToG = ((int)0x0c73),
            PixelMapGToG = ((int)0x0c77),
            PixelMapAToA = ((int)0x0c79),
            PixelMapSToS = ((int)0x0c71),
        }

        public enum PixelStoreParameter
        {
                PackImageHeight = ((int)0x806c),
            PackSkipImages = ((int)0x806b),
            PackSkipVolumesSgis = ((int)0x8130),
            PixelTileGridHeightSgix = ((int)0x8143),
            PackSkipPixels = ((int)0x0d04),
            UnpackImageHeight = ((int)0x806e),
            UnpackSkipVolumesSgis = ((int)0x8132),
            PackImageDepthSgis = ((int)0x8131),
                        PixelTileCacheSizeSgix = ((int)0x8145),
            PixelTileGridDepthSgix = ((int)0x8144),
            PackSwapBytes = ((int)0x0d00),
            UnpackSkipPixels = ((int)0x0cf4),
            UnpackLsbFirst = ((int)0x0cf1),
            PixelTileHeightSgix = ((int)0x8141),
            PixelTileGridWidthSgix = ((int)0x8142),
            PackAlignment = ((int)0x0d05),
            UnpackResampleSgix = ((int)0x842d),
            UnpackAlignment = ((int)0x0cf5),
            UnpackRowLength = ((int)0x0cf2),
            UnpackSwapBytes = ((int)0x0cf0),
            PackSubsampleRateSgix = ((int)0x85a0),
            PackResampleSgix = ((int)0x842c),
            UnpackSkipRows = ((int)0x0cf3),
            UnpackImageDepthSgis = ((int)0x8133),
            PackLsbFirst = ((int)0x0d01),
            UnpackSubsampleRateSgix = ((int)0x85a1),
            UnpackSkipImages = ((int)0x806d),
            PackRowLength = ((int)0x0d02),
            PackSkipRows = ((int)0x0d03),
            PixelTileWidthSgix = ((int)0x8140),
        }

        public enum PixelStoreResampleMode
        {
            ResampleZeroFillSgix = ((int)0x842f),
            ResampleDecimateSgix = ((int)0x8430),
            ResampleReplicateSgix = ((int)0x842e),
        }

        public enum PixelStoreSubsampleRate
        {
            PixelSubsample2424Sgix = ((int)0x85a3),
            PixelSubsample4444Sgix = ((int)0x85a2),
            PixelSubsample4242Sgix = ((int)0x85a4),
        }

        public enum PixelTexGenMode
        {
            LuminanceAlpha = ((int)0x190a),
            PixelTexGenAlphaMsSgix = ((int)0x818a),
            Rgba = ((int)0x1908),
            PixelTexGenAlphaReplaceSgix = ((int)0x8187),
            PixelTexGenAlphaNoReplaceSgix = ((int)0x8188),
            PixelTexGenAlphaLsSgix = ((int)0x8189),
            None = ((int)0),
            Luminance = ((int)0x1909),
            Rgb = ((int)0x1907),
        }

        public enum PixelTexGenParameterNameSgis
        {
            PixelFragmentRgbSourceSgis = ((int)0x8354),
            PixelFragmentAlphaSourceSgis = ((int)0x8355),
        }

        public enum PixelTransferParameter
        {
            PostConvolutionAlphaBiasExt = ((int)0x8023),
            PostColorMatrixGreenBiasSgi = ((int)0x80b9),
            PostColorMatrixAlphaScaleSgi = ((int)0x80b7),
            PostColorMatrixBlueBiasSgi = ((int)0x80ba),
            PostConvolutionGreenScaleExt = ((int)0x801d),
            PostConvolutionGreenBiasExt = ((int)0x8021),
            BlueBias = ((int)0x0d1b),
            BlueScale = ((int)0x0d1a),
            PostColorMatrixRedScaleSgi = ((int)0x80b4),
            PostConvolutionRedBiasExt = ((int)0x8020),
            AlphaBias = ((int)0x0d1d),
            AlphaScale = ((int)0x0d1c),
            GreenScale = ((int)0x0d18),
            RedBias = ((int)0x0d15),
            PostColorMatrixRedBiasSgi = ((int)0x80b8),
            IndexShift = ((int)0x0d12),
            RedScale = ((int)0x0d14),
            PostColorMatrixAlphaBiasSgi = ((int)0x80bb),
            MapColor = ((int)0x0d10),
            PostConvolutionBlueBiasExt = ((int)0x8022),
            PostConvolutionBlueScaleExt = ((int)0x801e),
            PostConvolutionRedScaleExt = ((int)0x801c),
            PostColorMatrixGreenScaleSgi = ((int)0x80b5),
            MapStencil = ((int)0x0d11),
            DepthBias = ((int)0x0d1f),
            IndexOffset = ((int)0x0d13),
            PostConvolutionAlphaScaleExt = ((int)0x801f),
            PostColorMatrixBlueScaleSgi = ((int)0x80b6),
            DepthScale = ((int)0x0d1e),
            GreenBias = ((int)0x0d19),
        }

        public enum PixelType
        {
            Bitmap = ((int)0x1a00),
                UnsignedShort4444 = ((int)0x8033),
            UnsignedInt8888 = ((int)0x8035),
            Short = ((int)0x1402),
            UnsignedInt2101010Reversed = ((int)0x8368),
                HalfFloat = ((int)0x140b),
            UnsignedShort5551 = ((int)0x8034),
            UnsignedInt8888Reversed = ((int)0x8367),
                UnsignedInt1010102 = ((int)0x8036),
            UnsignedShort565 = ((int)0x8363),
            Byte = ((int)0x1400),
            UnsignedShort565Reversed = ((int)0x8364),
            UnsignedInt = ((int)0x1405),
            UnsignedByte = ((int)0x1401),
            UnsignedByte233Reversed = ((int)0x8362),
            Int = ((int)0x1404),
                UnsignedByte332 = ((int)0x8032),
            UnsignedShort1555Reversed = ((int)0x8366),
            Float = ((int)0x1406),
            UnsignedShort4444Reversed = ((int)0x8365),
                UnsignedShort = ((int)0x1403),
        }

        public enum PointParameterNameSgis
        {
            DistanceAttenuationSgis = ((int)0x8129),
            PointSizeMaxSgis = ((int)0x8127),
            PointSizeMinSgis = ((int)0x8126),
            PointFadeThresholdSizeSgis = ((int)0x8128),
        }

        public enum PolygonMode
        {
            Line = ((int)0x1b01),
            Point = ((int)0x1b00),
            Fill = ((int)0x1b02),
        }

        public enum ReadBufferMode
        {
            FrontRight = ((int)0x0401),
            Right = ((int)0x0407),
            BackLeft = ((int)0x0402),
            BackRight = ((int)0x0403),
            Left = ((int)0x0406),
            Aux0 = ((int)0x0409),
            Back = ((int)0x0405),
            Aux3 = ((int)0x040c),
            Aux1 = ((int)0x040a),
            FrontLeft = ((int)0x0400),
            Aux2 = ((int)0x040b),
            Front = ((int)0x0404),
        }

        public enum RenderingMode
        {
            Render = ((int)0x1c00),
            Feedback = ((int)0x1c01),
            Select = ((int)0x1c02),
        }

        public enum SamplePatternSgis
        {
            Gl4pass2Sgis = ((int)0x80a6),
            Gl4pass0Sgis = ((int)0x80a4),
            Gl2pass1Sgis = ((int)0x80a3),
            Gl1passSgis = ((int)0x80a1),
            Gl4pass3Sgis = ((int)0x80a7),
            Gl4pass1Sgis = ((int)0x80a5),
            Gl2pass0Sgis = ((int)0x80a2),
        }

        public enum SeparableTargetExt
        {
            Separable2dExt = ((int)0x8012),
        }

        public enum ShadingModel
        {
            Flat = ((int)0x1d00),
            Smooth = ((int)0x1d01),
        }

        public enum StencilFunction
        {
            Never = ((int)0x0200),
            Equal = ((int)0x0202),
            Always = ((int)0x0207),
            Less = ((int)0x0201),
            Gequal = ((int)0x0206),
            Lequal = ((int)0x0203),
            Notequal = ((int)0x0205),
            Greater = ((int)0x0204),
        }

        public enum StencilOp
        {
            DecrWrap = ((int)0x8508),
            Replace = ((int)0x1e01),
            IncrWrap = ((int)0x8507),
            Incr = ((int)0x1e02),
            Zero = ((int)0),
            Decr = ((int)0x1e03),
            Keep = ((int)0x1e00),
            Invert = ((int)0x150a),
        }

        public enum StringName
        {
            ShadingLanguageVersion = ((int)0x8b8c),
            Renderer = ((int)0x1f01),
            Extensions = ((int)0x1f03),
            Version = ((int)0x1f02),
            Vendor = ((int)0x1f00),
        }

        public enum TexCoordPointerType
        {
            Short = ((int)0x1402),
            Float = ((int)0x1406),
            Double = ((int)0x140a),
            Int = ((int)0x1404),
        }

        public enum TextureCoordName
        {
            R = ((int)0x2002),
            S = ((int)0x2000),
            Q = ((int)0x2003),
            T = ((int)0x2001),
        }

        public enum TextureEnvMode
        {
            Combine = ((int)0x8570),
            Decal = ((int)0x2101),
            Add = ((int)0x0104),
            Blend = ((int)0x0be2),
            ReplaceExt = ((int)0x8062),
            TextureEnvBiasSgix = ((int)0x80be),
            Modulate = ((int)0x2100),
        }

        public enum TextureEnvParameter
        {
            Operand0Alpha = ((int)0x8598),
            TextureEnvMode = ((int)0x2200),
            Src0Alpha = ((int)0x8588),
            Src1Alpha = ((int)0x8589),
            Operand2Rgb = ((int)0x8592),
            Operand2Alpha = ((int)0x859a),
            Operand0Rgb = ((int)0x8590),
            AlphaScale = ((int)0x0d1c),
            Operand1Alpha = ((int)0x8599),
            RgbScale = ((int)0x8573),
            Src1Rgb = ((int)0x8581),
            Src2Rgb = ((int)0x8582),
            TextureEnvColor = ((int)0x2201),
            Src2Alpha = ((int)0x858a),
            Source0Rgb = ((int)0x8580),
            CombineAlpha = ((int)0x8572),
            Operand1Rgb = ((int)0x8591),
            CoordReplace = ((int)0x8862),
            CombineRgb = ((int)0x8571),
            TextureLodBias = ((int)0x8501),
        }

        public enum TextureEnvTarget
        {
            PointSprite = ((int)0x8861),
            TextureFilterControl = ((int)0x8500),
            TextureEnv = ((int)0x2300),
        }

        public enum TextureFilterFuncSgis
        {
            Filter4Sgis = ((int)0x8146),
        }

        public enum TextureGenMode
        {
            NormalMap = ((int)0x8511),
            SphereMap = ((int)0x2402),
            ObjectLinear = ((int)0x2401),
            EyeDistanceToLineSgis = ((int)0x81f2),
            EyeDistanceToPointSgis = ((int)0x81f0),
            ObjectDistanceToLineSgis = ((int)0x81f3),
            ReflectionMap = ((int)0x8512),
            EyeLinear = ((int)0x2400),
            ObjectDistanceToPointSgis = ((int)0x81f1),
        }

        public enum TextureGenParameter
        {
            ObjectPlane = ((int)0x2501),
            EyePlane = ((int)0x2502),
            EyePointSgis = ((int)0x81f4),
            ObjectPointSgis = ((int)0x81f5),
            TextureGenMode = ((int)0x2500),
            ObjectLineSgis = ((int)0x81f7),
            EyeLineSgis = ((int)0x81f6),
        }

        public enum TextureMagFilter
        {
            PixelTexGenQCeilingSgix = ((int)0x8184),
            Filter4Sgis = ((int)0x8146),
            LinearDetailSgis = ((int)0x8097),
            LinearSharpenSgis = ((int)0x80ad),
            Linear = ((int)0x2601),
            LinearSharpenColorSgis = ((int)0x80af),
            PixelTexGenQRoundSgix = ((int)0x8185),
            Nearest = ((int)0x2600),
            LinearSharpenAlphaSgis = ((int)0x80ae),
            LinearDetailColorSgis = ((int)0x8099),
            PixelTexGenQFloorSgix = ((int)0x8186),
            LinearDetailAlphaSgis = ((int)0x8098),
        }

        public enum TextureMinFilter
        {
            LinearClipmapNearestSgix = ((int)0x844f),
            Filter4Sgis = ((int)0x8146),
            LinearClipmapLinearSgix = ((int)0x8170),
            NearestMipmapLinear = ((int)0x2702),
            NearestClipmapNearestSgix = ((int)0x844d),
            Linear = ((int)0x2601),
            LinearMipmapNearest = ((int)0x2701),
            Nearest = ((int)0x2600),
            PixelTexGenQCeilingSgix = ((int)0x8184),
            PixelTexGenQRoundSgix = ((int)0x8185),
            PixelTexGenQFloorSgix = ((int)0x8186),
            NearestMipmapNearest = ((int)0x2700),
            NearestClipmapLinearSgix = ((int)0x844e),
            LinearMipmapLinear = ((int)0x2703),
        }

        public enum TextureParameterName
        {
                QuadTextureSelectSgis = ((int)0x8125),
            DetailTextureLevelSgis = ((int)0x809a),
            TextureMaxClampTSgix = ((int)0x836a),
            TextureCompareFailValue = ((int)0x80bf),
            TexturePriority = ((int)0x8066),
            TextureLodBiasTSgix = ((int)0x818f),
            TextureClipmapCenterSgix = ((int)0x8171),
            TextureLodBiasRSgix = ((int)0x8190),
            TextureClipmapFrameSgix = ((int)0x8172),
            TextureLodBiasSSgix = ((int)0x818e),
            TextureClipmapDepthSgix = ((int)0x8176),
            TextureCompareMode = ((int)0x884c),
            TextureClipmapOffsetSgix = ((int)0x8173),
            TextureWrapQSgis = ((int)0x8137),
            ClampToBorder = ((int)0x812d),
            TextureWrapS = ((int)0x2802),
            TextureMinFilter = ((int)0x2801),
            TextureWrapRExt = ((int)0x8072),
            TextureCompareSgix = ((int)0x819a),
            TextureMaxClampSSgix = ((int)0x8369),
            DetailTextureModeSgis = ((int)0x809b),
            DualTextureSelectSgis = ((int)0x8124),
            TextureClipmapLodOffsetSgix = ((int)0x8175),
            DepthTextureMode = ((int)0x884b),
            PostTextureFilterBiasSgix = ((int)0x8179),
            TextureCompareOperatorSgix = ((int)0x819b),
            TextureMaxClampRSgix = ((int)0x836b),
            ClampToEdge = ((int)0x812f),
            TextureCompareFunc = ((int)0x884d),
                GenerateMipmap = ((int)0x8191),
            PostTextureFilterScaleSgix = ((int)0x817a),
            TextureBorderColor = ((int)0x1004),
            TextureClipmapVirtualDepthSgix = ((int)0x8174),
            TextureMagFilter = ((int)0x2800),
            TextureWrapT = ((int)0x2803),
        }

        public enum TextureTarget
        {
                TextureBaseLevelSgis = ((int)0x813c),
            TextureCubeMapNegativeZ = ((int)0x851a),
            ProxyTexture4dSgis = ((int)0x8135),
            TextureMaxLevelSgis = ((int)0x813d),
            Texture2d = ((int)0x0de1),
            Texture4dSgis = ((int)0x8134),
            TextureBindingCubeMap = ((int)0x8514),
            Texture3d = ((int)0x806f),
            TextureRectangleArb = ((int)0x84f5),
                Texture1d = ((int)0x0de0),
            ProxyTextureCubeMap = ((int)0x851b),
            TextureCubeMap = ((int)0x8513),
            TextureMinLodSgis = ((int)0x813a),
            ProxyTexture3d = ((int)0x8070),
            DetailTexture2dSgis = ((int)0x8095),
            ProxyTexture2d = ((int)0x8064),
            ProxyTexture1d = ((int)0x8063),
            TextureCubeMapNegativeX = ((int)0x8516),
                TextureMaxLodSgis = ((int)0x813b),
            TextureCubeMapNegativeY = ((int)0x8518),
            TextureCubeMapPositiveZ = ((int)0x8519),
            TextureCubeMapPositiveX = ((int)0x8515),
            TextureCubeMapPositiveY = ((int)0x8517),
        }

        public enum TextureWrapMode
        {
            Clamp = ((int)0x2900),
            Repeat = ((int)0x2901),
            MirroredRepeat = ((int)0x8370),
        }

        public enum PixelInternalFormat
        {
            LuminanceAlphaIccSgix = ((int)0x8465),
            Rgb4 = ((int)0x804f),
            Intensity16IccSgix = ((int)0x846a),
            DepthComponent = ((int)0x1902),
            Alpha8 = ((int)0x803c),
            LuminanceAlpha = ((int)0x190a),
            DualIntensity4Sgis = ((int)0x8118),
            QuadLuminance4Sgis = ((int)0x8120),
            Rgb2Ext = ((int)0x804e),
            RgbaIccSgix = ((int)0x8461),
            Alpha16IccSgix = ((int)0x8468),
            CompressedAlpha = ((int)0x84e9),
            Luminance12Alpha12 = ((int)0x8047),
            Luminance6Alpha2 = ((int)0x8044),
            Alpha12 = ((int)0x803d),
            QuadLuminance8Sgis = ((int)0x8121),
            CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8c4f),
            Alpha16 = ((int)0x803e),
            Rgba2 = ((int)0x8055),
            Srgb = ((int)0x8c40),
            CompressedLuminance = ((int)0x84ea),
            Luminance8Alpha8 = ((int)0x8045),
            Sluminance8 = ((int)0x8c47),
            R5G6B5IccSgix = ((int)0x8466),
            Sluminance8Alpha8 = ((int)0x8c45),
            R3G3B2 = ((int)0x2a10),
            R5G6B5A8IccSgix = ((int)0x8467),
            Luminance4Alpha4 = ((int)0x8043),
            Alpha4 = ((int)0x803b),
                Luminance16Alpha8IccSgix = ((int)0x846b),
            DualIntensity8Sgis = ((int)0x8119),
            Rgba8 = ((int)0x8058),
            Alpha = ((int)0x1906),
            Rgb12 = ((int)0x8053),
            CompressedLuminanceAlpha = ((int)0x84eb),
            Rgba4 = ((int)0x8056),
            Luminance4 = ((int)0x803f),
            Sluminance = ((int)0x8c46),
            Two = ((int)2),
            Intensity8 = ((int)0x804b),
            Luminance16 = ((int)0x8042),
                DualAlpha16Sgis = ((int)0x8113),
            Luminance12 = ((int)0x8041),
            Luminance16Alpha16 = ((int)0x8048),
            SluminanceAlpha = ((int)0x8c44),
            Intensity4 = ((int)0x804a),
            LuminanceIccSgix = ((int)0x8463),
            CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8c4e),
            DualLuminance4Sgis = ((int)0x8114),
            CompressedSrgbAlpha = ((int)0x8c49),
            CompressedIntensity = ((int)0x84ec),
            Srgb8 = ((int)0x8c41),
            DualLuminanceAlpha8Sgis = ((int)0x811d),
            DualAlpha12Sgis = ((int)0x8112),
            Four = ((int)4),
            QuadIntensity4Sgis = ((int)0x8122),
            CompressedSluminanceAlpha = ((int)0x8c4b),
            Rgb5A1 = ((int)0x8057),
            DepthComponent24 = ((int)0x81a6),
            Luminance16IccSgix = ((int)0x8469),
            DualLuminance8Sgis = ((int)0x8115),
            SrgbAlpha = ((int)0x8c42),
            CompressedSluminance = ((int)0x8c4a),
            Rgba16 = ((int)0x805b),
            RgbIccSgix = ((int)0x8460),
            Srgb8Alpha8 = ((int)0x8c43),
            DepthComponent32 = ((int)0x81a7),
            CompressedRgba = ((int)0x84ee),
            Intensity = ((int)0x8049),
            CompressedSrgb = ((int)0x8c48),
            CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8c4d),
            DepthComponent16 = ((int)0x81a5),
            DualLuminance12Sgis = ((int)0x8116),
            Rgb10A2 = ((int)0x8059),
            DualAlpha4Sgis = ((int)0x8110),
            Rgb5 = ((int)0x8050),
            Luminance = ((int)0x1909),
            CompressedRgb = ((int)0x84ed),
            One = ((int)1),
            AlphaIccSgix = ((int)0x8462),
            Rgb8 = ((int)0x8051),
            Rgb10 = ((int)0x8052),
            Three = ((int)3),
            Rgb16 = ((int)0x8054),
            Rgba12 = ((int)0x805a),
            DualLuminanceAlpha4Sgis = ((int)0x811c),
            IntensityIccSgix = ((int)0x8464),
            DualAlpha8Sgis = ((int)0x8111),
            QuadIntensity8Sgis = ((int)0x8123),
            DualLuminance16Sgis = ((int)0x8117),
            CompressedSrgbS3tcDxt1Ext = ((int)0x8c4c),
            Luminance12Alpha4 = ((int)0x8046),
            QuadAlpha8Sgis = ((int)0x811f),
                DualIntensity12Sgis = ((int)0x811a),
            Rgb = ((int)0x1907),
            Luminance8 = ((int)0x8040),
            DualIntensity16Sgis = ((int)0x811b),
            Intensity12 = ((int)0x804c),
            QuadAlpha4Sgis = ((int)0x811e),
            Intensity16 = ((int)0x804d),
            Rgba = ((int)0x1908),
        }

        public enum InterleavedArrayFormat
        {
            V2f = ((int)0x2a20),
            T2fC3fV3f = ((int)0x2a2a),
            C4ubV3f = ((int)0x2a23),
            C4ubV2f = ((int)0x2a22),
            T4fV4f = ((int)0x2a28),
            C4fN3fV3f = ((int)0x2a26),
            T2fC4fN3fV3f = ((int)0x2a2c),
            N3fV3f = ((int)0x2a25),
            C3fV3f = ((int)0x2a24),
            T2fV3f = ((int)0x2a27),
            T2fN3fV3f = ((int)0x2a2b),
            T2fC4ubV3f = ((int)0x2a29),
            T4fC4fN3fV4f = ((int)0x2a2d),
            V3f = ((int)0x2a21),
        }

        public enum VertexPointerType
        {
            Short = ((int)0x1402),
            Float = ((int)0x1406),
            Double = ((int)0x140a),
            Int = ((int)0x1404),
        }

        public enum ClipPlaneName
        {
            ClipPlane4 = ((int)0x3004),
            ClipPlane1 = ((int)0x3001),
            ClipPlane5 = ((int)0x3005),
            ClipPlane2 = ((int)0x3002),
            ClipPlane3 = ((int)0x3003),
            ClipPlane0 = ((int)0x3000),
        }

        public enum LightName
        {
            FragmentLight3Sgix = ((int)0x840f),
            FragmentLight0Sgix = ((int)0x840c),
            Light2 = ((int)0x4002),
            FragmentLight7Sgix = ((int)0x8413),
            Light3 = ((int)0x4003),
            FragmentLight6Sgix = ((int)0x8412),
            FragmentLight4Sgix = ((int)0x8410),
            FragmentLight5Sgix = ((int)0x8411),
            FragmentLight1Sgix = ((int)0x840d),
            Light0 = ((int)0x4000),
            FragmentLight2Sgix = ((int)0x840e),
            Light4 = ((int)0x4004),
            Light5 = ((int)0x4005),
            Light6 = ((int)0x4006),
            Light7 = ((int)0x4007),
            Light1 = ((int)0x4001),
        }

        public enum ExtAbgr
        {
            AbgrExt = ((int)0x8000),
        }

        public enum ExtBlendColor
        {
                    BlendColor = ((int)0x8005),
            OneMinusConstantAlpha = ((int)0x8004),
                ConstantColor = ((int)0x8001),
                OneMinusConstantColor = ((int)0x8002),
            ConstantAlpha = ((int)0x8003),
            }

        public enum ExtBlendMinmax
        {
            FuncAdd = ((int)0x8006),
            Min = ((int)0x8007),
            Max = ((int)0x8008),
                        BlendEquation = ((int)0x8009),
            }

        public enum ExtBlendSubtract
        {
            FuncReverseSubtract = ((int)0x800b),
                    FuncSubtract = ((int)0x800a),
        }

        public enum ExtCmyka
        {
            CmykExt = ((int)0x800c),
            CmykaExt = ((int)0x800d),
            UnpackCmykHintExt = ((int)0x800f),
            PackCmykHintExt = ((int)0x800e),
        }

        public enum ExtConvolution
        {
                PostConvolutionAlphaScale = ((int)0x801f),
                    ConvolutionBorderMode = ((int)0x8013),
                        PostConvolutionGreenScale = ((int)0x801d),
                PostConvolutionBlueScale = ((int)0x801e),
            ConvolutionHeight = ((int)0x8019),
                    Reduce = ((int)0x8016),
            PostConvolutionGreenBias = ((int)0x8021),
                        MaxConvolutionWidth = ((int)0x801a),
                        Convolution2d = ((int)0x8011),
            ConvolutionWidth = ((int)0x8018),
            PostConvolutionRedScale = ((int)0x801c),
                Convolution1d = ((int)0x8010),
                ConvolutionFilterScale = ((int)0x8014),
                Separable2d = ((int)0x8012),
            PostConvolutionBlueBias = ((int)0x8022),
            MaxConvolutionHeight = ((int)0x801b),
                    PostConvolutionRedBias = ((int)0x8020),
            PostConvolutionAlphaBias = ((int)0x8023),
            ConvolutionFormat = ((int)0x8017),
            ConvolutionFilterBias = ((int)0x8015),
        }

        public enum ExtHistogram
        {
            HistogramSink = ((int)0x802d),
            TableTooLarge = ((int)0x8031),
                Histogram = ((int)0x8024),
            HistogramBlueSize = ((int)0x802a),
            MinmaxFormat = ((int)0x802f),
                    HistogramFormat = ((int)0x8027),
                HistogramWidth = ((int)0x8026),
                            HistogramGreenSize = ((int)0x8029),
            MinmaxSink = ((int)0x8030),
                    Minmax = ((int)0x802e),
            HistogramAlphaSize = ((int)0x802b),
            HistogramRedSize = ((int)0x8028),
                            HistogramLuminanceSize = ((int)0x802c),
            ProxyHistogram = ((int)0x8025),
        }

        public enum ExtPackedPixels
        {
                    UnsignedInt1010102 = ((int)0x8036),
            UnsignedInt8888 = ((int)0x8035),
                UnsignedShort5551 = ((int)0x8034),
                    UnsignedShort565Rev = ((int)0x8364),
                UnsignedShort565 = ((int)0x8363),
            UnsignedShort4444Rev = ((int)0x8365),
                UnsignedInt8888Rev = ((int)0x8367),
                        UnsignedInt2101010Rev = ((int)0x8368),
            UnsignedByte233Rev = ((int)0x8362),
            UnsignedByte332 = ((int)0x8032),
            UnsignedShort4444 = ((int)0x8033),
                UnsignedShort1555Rev = ((int)0x8366),
            }

        public enum ExtPolygonOffset
        {
            PolygonOffsetExt = ((int)0x8037),
            PolygonOffsetBiasExt = ((int)0x8039),
            PolygonOffsetFactorExt = ((int)0x8038),
        }

        public enum ExtRescaleNormal
        {
            RescaleNormal = ((int)0x803a),
            }

        public enum ExtTexture
        {
            Luminance4Alpha4Ext = ((int)0x8043),
            Luminance12Alpha4Ext = ((int)0x8046),
            Rgb10A2Ext = ((int)0x8059),
            Alpha8Ext = ((int)0x803c),
            Luminance12Ext = ((int)0x8041),
            Luminance8Alpha8Ext = ((int)0x8045),
            TextureIntensitySizeExt = ((int)0x8061),
            Rgba8Ext = ((int)0x8058),
            Luminance6Alpha2Ext = ((int)0x8044),
            Rgb4Ext = ((int)0x804f),
            Alpha12Ext = ((int)0x803d),
            Luminance8Ext = ((int)0x8040),
            Rgb12Ext = ((int)0x8053),
            Rgba12Ext = ((int)0x805a),
            TextureLuminanceSizeExt = ((int)0x8060),
            Intensity12Ext = ((int)0x804c),
            TextureBlueSizeExt = ((int)0x805e),
            Alpha4Ext = ((int)0x803b),
            Alpha16Ext = ((int)0x803e),
            IntensityExt = ((int)0x8049),
            Intensity8Ext = ((int)0x804b),
            Luminance12Alpha12Ext = ((int)0x8047),
            Rgb16Ext = ((int)0x8054),
            Luminance16Alpha16Ext = ((int)0x8048),
            ReplaceExt = ((int)0x8062),
            Intensity16Ext = ((int)0x804d),
            TextureRedSizeExt = ((int)0x805c),
            Rgba4Ext = ((int)0x8056),
            ProxyTexture1dExt = ((int)0x8063),
            TextureAlphaSizeExt = ((int)0x805f),
            Rgb10Ext = ((int)0x8052),
            Rgb2Ext = ((int)0x804e),
            ProxyTexture2dExt = ((int)0x8064),
            Rgb5Ext = ((int)0x8050),
            Luminance16Ext = ((int)0x8042),
            TextureTooLargeExt = ((int)0x8065),
            Rgba16Ext = ((int)0x805b),
            Rgba2Ext = ((int)0x8055),
            Rgb5A1Ext = ((int)0x8057),
            TextureGreenSizeExt = ((int)0x805d),
            Luminance4Ext = ((int)0x803f),
            Intensity4Ext = ((int)0x804a),
            Rgb8Ext = ((int)0x8051),
        }

        public enum ExtTextureObject
        {
            Texture1dBindingExt = ((int)0x8068),
            TextureResidentExt = ((int)0x8067),
            TexturePriorityExt = ((int)0x8066),
            Texture3dBindingExt = ((int)0x806a),
            Texture2dBindingExt = ((int)0x8069),
        }

        public enum ExtTexture3D
        {
                TextureDepth = ((int)0x8071),
            UnpackImageHeight = ((int)0x806e),
            PackImageHeight = ((int)0x806c),
            TextureWrapR = ((int)0x8072),
            Texture3d = ((int)0x806f),
                                PackSkipImages = ((int)0x806b),
                Max3dTextureSize = ((int)0x8073),
                ProxyTexture3d = ((int)0x8070),
            UnpackSkipImages = ((int)0x806d),
            }

        public enum ExtVertexArray
        {
            NormalArrayStrideExt = ((int)0x807f),
            ColorArrayExt = ((int)0x8076),
            TextureCoordArrayPointerExt = ((int)0x8092),
            IndexArrayStrideExt = ((int)0x8086),
            VertexArrayTypeExt = ((int)0x807b),
            IndexArrayPointerExt = ((int)0x8091),
            TextureCoordArrayStrideExt = ((int)0x808a),
            VertexArrayStrideExt = ((int)0x807c),
            TextureCoordArrayCountExt = ((int)0x808b),
            NormalArrayExt = ((int)0x8075),
            TextureCoordArraySizeExt = ((int)0x8088),
            NormalArrayTypeExt = ((int)0x807e),
            ColorArraySizeExt = ((int)0x8081),
            TextureCoordArrayExt = ((int)0x8078),
            ColorArrayTypeExt = ((int)0x8082),
            ColorArrayStrideExt = ((int)0x8083),
            ColorArrayCountExt = ((int)0x8084),
            EdgeFlagArrayPointerExt = ((int)0x8093),
            ColorArrayPointerExt = ((int)0x8090),
            IndexArrayCountExt = ((int)0x8087),
            NormalArrayCountExt = ((int)0x8080),
            EdgeFlagArrayCountExt = ((int)0x808d),
            VertexArrayPointerExt = ((int)0x808e),
            EdgeFlagArrayExt = ((int)0x8079),
            VertexArrayExt = ((int)0x8074),
            VertexArraySizeExt = ((int)0x807a),
            NormalArrayPointerExt = ((int)0x808f),
            IndexArrayExt = ((int)0x8077),
            VertexArrayCountExt = ((int)0x807d),
            IndexArrayTypeExt = ((int)0x8085),
            TextureCoordArrayTypeExt = ((int)0x8089),
            EdgeFlagArrayStrideExt = ((int)0x808c),
        }

        public enum SgixInterlace
        {
            InterlaceSgix = ((int)0x8094),
        }

        public enum SgisDetailTexture
        {
            LinearDetailSgis = ((int)0x8097),
            DetailTexture2dSgis = ((int)0x8095),
            DetailTexture2dBindingSgis = ((int)0x8096),
            DetailTextureFuncPointsSgis = ((int)0x809c),
            DetailTextureLevelSgis = ((int)0x809a),
            LinearDetailColorSgis = ((int)0x8099),
            DetailTextureModeSgis = ((int)0x809b),
            LinearDetailAlphaSgis = ((int)0x8098),
        }

        public enum ArbMultisample
        {
            Samples = ((int)0x80a9),
            MultisampleBitArb = ((int)0x20000000),
                SampleCoverage = ((int)0x80a0),
            SampleCoverageInvert = ((int)0x80ab),
            SampleAlphaToOne = ((int)0x809f),
                SampleCoverageValue = ((int)0x80aa),
            SampleAlphaToCoverage = ((int)0x809e),
                                Multisample = ((int)0x809d),
            SampleBuffers = ((int)0x80a8),
            }

        public enum SgisMultisample
        {
            Gl2pass1Sgis = ((int)0x80a3),
            SampleAlphaToOneSgis = ((int)0x809f),
            SampleMaskInvertSgis = ((int)0x80ab),
            Gl4pass2Sgis = ((int)0x80a6),
            SampleAlphaToMaskSgis = ((int)0x809e),
            Gl4pass0Sgis = ((int)0x80a4),
            SamplePatternSgis = ((int)0x80ac),
            SampleMaskValueSgis = ((int)0x80aa),
            SamplesSgis = ((int)0x80a9),
            Gl2pass0Sgis = ((int)0x80a2),
            MultisampleSgis = ((int)0x809d),
            Gl4pass3Sgis = ((int)0x80a7),
            SampleBuffersSgis = ((int)0x80a8),
            Gl4pass1Sgis = ((int)0x80a5),
            Gl1passSgis = ((int)0x80a1),
            SampleMaskSgis = ((int)0x80a0),
        }

        public enum SgisSharpenTexture
        {
            LinearSharpenSgis = ((int)0x80ad),
            SharpenTextureFuncPointsSgis = ((int)0x80b0),
            LinearSharpenColorSgis = ((int)0x80af),
            LinearSharpenAlphaSgis = ((int)0x80ae),
        }

        public enum SgiColorMatrix
        {
            MaxColorMatrixStackDepth = ((int)0x80b3),
            PostColorMatrixRedScale = ((int)0x80b4),
                        PostColorMatrixAlphaScale = ((int)0x80b7),
                PostColorMatrixRedBias = ((int)0x80b8),
                ColorMatrix = ((int)0x80b1),
            PostColorMatrixGreenScale = ((int)0x80b5),
            PostColorMatrixBlueBias = ((int)0x80ba),
                    PostColorMatrixBlueScale = ((int)0x80b6),
            ColorMatrixStackDepth = ((int)0x80b2),
                PostColorMatrixGreenBias = ((int)0x80b9),
                PostColorMatrixAlphaBias = ((int)0x80bb),
                }

        public enum SgiTextureColorTable
        {
            TextureColorTableSgi = ((int)0x80bc),
            ProxyTextureColorTableSgi = ((int)0x80bd),
        }

        public enum SgixTextureAddEnv
        {
            TextureEnvBiasSgix = ((int)0x80be),
        }

        public enum SgixShadowAmbient
        {
            ShadowAmbientSgix = ((int)0x80bf),
        }

        public enum SgiColorTable
        {
                ProxyColorTable = ((int)0x80d3),
                ColorTableBlueSize = ((int)0x80dc),
                    ColorTableRedSize = ((int)0x80da),
                ColorTableWidth = ((int)0x80d9),
                        ColorTable = ((int)0x80d0),
            ProxyPostConvolutionColorTable = ((int)0x80d4),
                PostColorMatrixColorTable = ((int)0x80d2),
            PostConvolutionColorTable = ((int)0x80d1),
            ColorTableLuminanceSize = ((int)0x80de),
            ColorTableGreenSize = ((int)0x80db),
                ColorTableIntensitySize = ((int)0x80df),
                                    ProxyPostColorMatrixColorTable = ((int)0x80d5),
            ColorTableFormat = ((int)0x80d8),
            ColorTableScale = ((int)0x80d6),
            ColorTableAlphaSize = ((int)0x80dd),
            ColorTableBias = ((int)0x80d7),
        }

        public enum ExtBgra
        {
                Bgra = ((int)0x80e1),
            Bgr = ((int)0x80e0),
            }

        public enum Version12
        {
            MaxElementsVertices = ((int)0x80e8),
            MaxElementsIndices = ((int)0x80e9),
        }

        public enum SgisTextureSelect
        {
            DualIntensity4Sgis = ((int)0x8118),
            QuadAlpha4Sgis = ((int)0x811e),
            DualAlpha8Sgis = ((int)0x8111),
            QuadTextureSelectSgis = ((int)0x8125),
            DualLuminance12Sgis = ((int)0x8116),
            QuadLuminance4Sgis = ((int)0x8120),
            DualLuminance16Sgis = ((int)0x8117),
            DualIntensity16Sgis = ((int)0x811b),
            QuadLuminance8Sgis = ((int)0x8121),
            DualIntensity12Sgis = ((int)0x811a),
            DualIntensity8Sgis = ((int)0x8119),
            QuadAlpha8Sgis = ((int)0x811f),
            DualAlpha16Sgis = ((int)0x8113),
            DualLuminanceAlpha4Sgis = ((int)0x811c),
            DualAlpha12Sgis = ((int)0x8112),
            DualAlpha4Sgis = ((int)0x8110),
            DualTextureSelectSgis = ((int)0x8124),
            QuadIntensity8Sgis = ((int)0x8123),
            QuadIntensity4Sgis = ((int)0x8122),
            DualLuminance8Sgis = ((int)0x8115),
            DualLuminance4Sgis = ((int)0x8114),
            DualLuminanceAlpha8Sgis = ((int)0x811d),
        }

        public enum SgisPointParameters
        {
                                            PointDistanceAttenuation = ((int)0x8129),
                PointSizeMax = ((int)0x8127),
                        PointFadeThresholdSize = ((int)0x8128),
            PointSizeMin = ((int)0x8126),
        }

        public enum SgisFogFunction
        {
            MaxFogFuncPointsSgis = ((int)0x812c),
            FogFuncSgis = ((int)0x812a),
            FogFuncPointsSgis = ((int)0x812b),
        }

        public enum SgisTextureBorderClamp
        {
            ClampToBorder = ((int)0x812d),
                }

        public enum SgixTextureMultiBuffer
        {
            TextureMultiBufferHintSgix = ((int)0x812e),
        }

        public enum SgisTextureEdgeClamp
        {
                ClampToEdge = ((int)0x812f),
        }

        public enum SgisTexture4D
        {
            Texture4dBindingSgis = ((int)0x814f),
            Texture4dsizeSgis = ((int)0x8136),
            Texture4dSgis = ((int)0x8134),
            PackImageDepthSgis = ((int)0x8131),
            PackSkipVolumesSgis = ((int)0x8130),
            Max4dTextureSizeSgis = ((int)0x8138),
            UnpackImageDepthSgis = ((int)0x8133),
            ProxyTexture4dSgis = ((int)0x8135),
            UnpackSkipVolumesSgis = ((int)0x8132),
            TextureWrapQSgis = ((int)0x8137),
        }

        public enum SgixPixelTexture
        {
            PixelTexGenModeSgix = ((int)0x832b),
            PixelTexGenSgix = ((int)0x8139),
        }

        public enum SgisTextureLod
        {
                TextureBaseLevel = ((int)0x813c),
                TextureMaxLod = ((int)0x813b),
            TextureMinLod = ((int)0x813a),
                    TextureMaxLevel = ((int)0x813d),
        }

        public enum SgixPixelTiles
        {
            PixelTileWidthSgix = ((int)0x8140),
            PixelTileGridWidthSgix = ((int)0x8142),
            PixelTileCacheIncrementSgix = ((int)0x813f),
            PixelTileCacheSizeSgix = ((int)0x8145),
            PixelTileHeightSgix = ((int)0x8141),
            PixelTileGridDepthSgix = ((int)0x8144),
            PixelTileBestAlignmentSgix = ((int)0x813e),
            PixelTileGridHeightSgix = ((int)0x8143),
        }

        public enum SgisTextureFilter4
        {
            Filter4Sgis = ((int)0x8146),
            TextureFilter4SizeSgis = ((int)0x8147),
        }

        public enum SgixSprite
        {
            SpriteAxialSgix = ((int)0x814c),
            SpriteObjectAlignedSgix = ((int)0x814d),
            SpriteModeSgix = ((int)0x8149),
            SpriteSgix = ((int)0x8148),
            SpriteEyeAlignedSgix = ((int)0x814e),
            SpriteAxisSgix = ((int)0x814a),
            SpriteTranslationSgix = ((int)0x814b),
        }

        public enum HpConvolutionBorderModes
        {
            IgnoreBorderHp = ((int)0x8150),
                    ConvolutionBorderColor = ((int)0x8154),
            ConstantBorder = ((int)0x8151),
                ReplicateBorder = ((int)0x8153),
        }

        public enum SgixClipmap
        {
            TextureClipmapVirtualDepthSgix = ((int)0x8174),
            TextureClipmapCenterSgix = ((int)0x8171),
            TextureClipmapFrameSgix = ((int)0x8172),
            NearestClipmapNearestSgix = ((int)0x844d),
            LinearClipmapNearestSgix = ((int)0x844f),
            TextureClipmapOffsetSgix = ((int)0x8173),
            TextureClipmapDepthSgix = ((int)0x8176),
            MaxClipmapDepthSgix = ((int)0x8177),
            TextureClipmapLodOffsetSgix = ((int)0x8175),
            NearestClipmapLinearSgix = ((int)0x844e),
            MaxClipmapVirtualDepthSgix = ((int)0x8178),
            LinearClipmapLinearSgix = ((int)0x8170),
        }

        public enum SgixTextureScaleBias
        {
            PostTextureFilterBiasSgix = ((int)0x8179),
            PostTextureFilterScaleRangeSgix = ((int)0x817c),
            PostTextureFilterScaleSgix = ((int)0x817a),
            PostTextureFilterBiasRangeSgix = ((int)0x817b),
        }

        public enum SgixReferencePlane
        {
            ReferencePlaneSgix = ((int)0x817d),
            ReferencePlaneEquationSgix = ((int)0x817e),
        }

        public enum SgixIrInstrument1
        {
            IrInstrument1Sgix = ((int)0x817f),
        }

        public enum SgixInstruments
        {
            InstrumentBufferPointerSgix = ((int)0x8180),
            InstrumentMeasurementsSgix = ((int)0x8181),
        }

        public enum SgixListPriority
        {
            ListPrioritySgix = ((int)0x8182),
        }

        public enum SgixCalligraphicFragment
        {
            CalligraphicFragmentSgix = ((int)0x8183),
        }

        public enum SgixImpactPixelTexture
        {
            PixelTexGenAlphaLsSgix = ((int)0x8189),
            PixelTexGenAlphaMsSgix = ((int)0x818a),
            PixelTexGenQFloorSgix = ((int)0x8186),
            PixelTexGenAlphaNoReplaceSgix = ((int)0x8188),
            PixelTexGenQRoundSgix = ((int)0x8185),
            PixelTexGenAlphaReplaceSgix = ((int)0x8187),
            PixelTexGenQCeilingSgix = ((int)0x8184),
        }

        public enum SgixFramezoom
        {
            MaxFramezoomFactorSgix = ((int)0x818d),
            FramezoomFactorSgix = ((int)0x818c),
            FramezoomSgix = ((int)0x818b),
        }

        public enum SgixTextureLodBias
        {
            TextureLodBiasSSgix = ((int)0x818e),
            TextureLodBiasRSgix = ((int)0x8190),
            TextureLodBiasTSgix = ((int)0x818f),
        }

        public enum SgisGenerateMipmap
        {
                GenerateMipmap = ((int)0x8191),
            MaxDeformationOrderSgix = ((int)0x8197),
            GeometryDeformationSgix = ((int)0x8194),
            DeformationsMaskSgix = ((int)0x8196),
            GenerateMipmapHint = ((int)0x8192),
            TextureDeformationSgix = ((int)0x8195),
            }

        public enum SgixFogOffset
        {
            FogOffsetValueSgix = ((int)0x8199),
            FogOffsetSgix = ((int)0x8198),
        }

        public enum SgixShadow
        {
            TextureLequalRSgix = ((int)0x819c),
            TextureCompareOperatorSgix = ((int)0x819b),
            TextureCompareSgix = ((int)0x819a),
            TextureGequalRSgix = ((int)0x819d),
        }

        public enum SgixDepthTexture
        {
            DepthComponent32 = ((int)0x81a7),
                    DepthComponent24 = ((int)0x81a6),
            DepthComponent16 = ((int)0x81a5),
            }

        public enum SgixYcrcb
        {
            Ycrcb422Sgix = ((int)0x81bb),
            Ycrcb444Sgix = ((int)0x81bc),
        }

        public enum SgisTextureColorMask
        {
            TextureColorWritemaskSgis = ((int)0x81ef),
        }

        public enum SgisPointLineTexgen
        {
            EyeDistanceToPointSgis = ((int)0x81f0),
            EyeLineSgis = ((int)0x81f6),
            EyeDistanceToLineSgis = ((int)0x81f2),
            ObjectDistanceToLineSgis = ((int)0x81f3),
            EyePointSgis = ((int)0x81f4),
            ObjectPointSgis = ((int)0x81f5),
            ObjectLineSgis = ((int)0x81f7),
            ObjectDistanceToPointSgis = ((int)0x81f1),
        }

        public enum ExtSeparateSpecularColor
        {
            LightModelColorControl = ((int)0x81f8),
                        SingleColor = ((int)0x81f9),
            SeparateSpecularColor = ((int)0x81fa),
        }

        public enum ExtSharedTexturePalette
        {
            SharedTexturePaletteExt = ((int)0x81fb),
        }

        public enum SgixConvolutionAccuracy
        {
            ConvolutionHintSgix = ((int)0x8316),
        }

        public enum SgixBlendAlphaMinmax
        {
            AlphaMaxSgix = ((int)0x8321),
            AsyncMarkerSgix = ((int)0x8329),
            AlphaMinSgix = ((int)0x8320),
        }

        public enum SgixAsyncHistogram
        {
            AsyncHistogramSgix = ((int)0x832c),
            MaxAsyncHistogramSgix = ((int)0x832d),
        }

        public enum ExtPixelTransform
        {
            PixelTransform2dStackDepthExt = ((int)0x8336),
            PixelCubicWeightExt = ((int)0x8333),
            PixelTransform2dMatrixExt = ((int)0x8338),
            CubicExt = ((int)0x8334),
            PixelTransform2dExt = ((int)0x8330),
            PixelMagFilterExt = ((int)0x8331),
            MaxPixelTransform2dStackDepthExt = ((int)0x8337),
            AverageExt = ((int)0x8335),
            PixelMinFilterExt = ((int)0x8332),
        }

        public enum SgisPixelTexture
        {
            PixelGroupColorSgis = ((int)0x8356),
            PixelTextureSgis = ((int)0x8353),
            PixelFragmentAlphaSourceSgis = ((int)0x8355),
            PixelFragmentRgbSourceSgis = ((int)0x8354),
        }

        public enum SgixAsyncPixel
        {
            MaxAsyncReadPixelsSgix = ((int)0x8361),
            AsyncDrawPixelsSgix = ((int)0x835d),
            MaxAsyncTexImageSgix = ((int)0x835f),
            AsyncTexImageSgix = ((int)0x835c),
            AsyncReadPixelsSgix = ((int)0x835e),
            MaxAsyncDrawPixelsSgix = ((int)0x8360),
        }

        public enum SgixTextureCoordinateClamp
        {
            TextureMaxClampRSgix = ((int)0x836b),
            TextureMaxClampTSgix = ((int)0x836a),
            TextureMaxClampSSgix = ((int)0x8369),
            FogFactorToAlphaSgix = ((int)0x836f),
        }

        public enum SgixVertexPreclip
        {
            VertexPreclipHintSgix = ((int)0x83ef),
            VertexPreclipSgix = ((int)0x83ee),
        }

        public enum ExtTextureCompressionS3tc
        {
            CompressedRgbS3tcDxt1Ext = ((int)0x83f0),
            CompressedRgbaS3tcDxt5Ext = ((int)0x83f3),
            CompressedRgbaS3tcDxt3Ext = ((int)0x83f2),
            CompressedRgbaS3tcDxt1Ext = ((int)0x83f1),
        }

        public enum IntelParallelArrays
        {
            VertexArrayParallelPointersIntel = ((int)0x83f5),
            TextureCoordArrayParallelPointersIntel = ((int)0x83f8),
            ColorArrayParallelPointersIntel = ((int)0x83f7),
            ParallelArraysIntel = ((int)0x83f4),
            NormalArrayParallelPointersIntel = ((int)0x83f6),
        }

        public enum SgixFragmentLighting
        {
            FragmentLightModelAmbientSgix = ((int)0x840a),
            FragmentLight5Sgix = ((int)0x8411),
            FragmentLight6Sgix = ((int)0x8412),
            MaxActiveLightsSgix = ((int)0x8405),
            FragmentLightingSgix = ((int)0x8400),
            FragmentLight2Sgix = ((int)0x840e),
            MaxFragmentLightsSgix = ((int)0x8404),
            FragmentLight4Sgix = ((int)0x8410),
            LightEnvModeSgix = ((int)0x8407),
            FragmentLightModelNormalInterpolationSgix = ((int)0x840b),
            FragmentColorMaterialFaceSgix = ((int)0x8402),
            FragmentLightModelTwoSideSgix = ((int)0x8409),
            FragmentLight1Sgix = ((int)0x840d),
            FragmentLightModelLocalViewerSgix = ((int)0x8408),
            CurrentRasterNormalSgix = ((int)0x8406),
            FragmentLight3Sgix = ((int)0x840f),
            FragmentLight7Sgix = ((int)0x8413),
            FragmentLight0Sgix = ((int)0x840c),
            FragmentColorMaterialParameterSgix = ((int)0x8403),
            FragmentColorMaterialSgix = ((int)0x8401),
        }

        public enum SgixResample
        {
            PackResampleSgix = ((int)0x842c),
            ResampleZeroFillSgix = ((int)0x842f),
            ResampleDecimateSgix = ((int)0x8430),
            UnpackResampleSgix = ((int)0x842d),
            ResampleReplicateSgix = ((int)0x842e),
        }

        public enum SgixIccTexture
        {
            R5G6B5IccSgix = ((int)0x8466),
            RgbIccSgix = ((int)0x8460),
            LuminanceIccSgix = ((int)0x8463),
            IntensityIccSgix = ((int)0x8464),
            RgbaIccSgix = ((int)0x8461),
            Luminance16IccSgix = ((int)0x8469),
            LuminanceAlphaIccSgix = ((int)0x8465),
            AlphaIccSgix = ((int)0x8462),
            Luminance16Alpha8IccSgix = ((int)0x846b),
            Alpha16IccSgix = ((int)0x8468),
            Intensity16IccSgix = ((int)0x846a),
            R5G6B5A8IccSgix = ((int)0x8467),
        }

        public enum SgixSubsample
        {
            PixelSubsample2424Sgix = ((int)0x85a3),
            UnpackSubsampleRateSgix = ((int)0x85a1),
            PackSubsampleRateSgix = ((int)0x85a0),
            PixelSubsample4242Sgix = ((int)0x85a4),
            PixelSubsample4444Sgix = ((int)0x85a2),
        }

        public enum All
        {
            Sampler2dRectArb = ((int)0x8b63),
            VertexStream2Ati = ((int)0x876e),
            Ccw = ((int)0x0901),
            ArrayElementLockFirstExt = ((int)0x81a8),
            MaxPixelTransform2dStackDepthExt = ((int)0x8337),
            ShadowAmbientSgix = ((int)0x80bf),
            TextureRedSizeExt = ((int)0x805c),
            VertexArrayListStrideIbm = ((int)103080),
            ColorLogicOp = ((int)0x0bf2),
            TextureCompareFailValue = ((int)0x80bf),
            TextureWidth = ((int)0x1000),
            MapAttribUOrderNv = ((int)0x86c3),
            Combiner0Nv = ((int)0x8550),
            MaxGeometryBindableUniformsExt = ((int)0x8de4),
                CurrentSecondaryColor = ((int)0x8459),
            CompressedSluminanceExt = ((int)0x8c4a),
            ShaderConsistentNv = ((int)0x86dd),
            Texture13Arb = ((int)0x84cd),
            RgbScaleArb = ((int)0x8573),
            Gl4pass2Sgis = ((int)0x80a6),
            Stencil = ((int)0x1802),
            Intensity = ((int)0x8049),
            DotProductTexture1dNv = ((int)0x885c),
            C4ubV2f = ((int)0x2a22),
            UnsignedByte233Reversed = ((int)0x8362),
            TextureCoordArraySizeExt = ((int)0x8088),
            BumpRotMatrixSizeAti = ((int)0x8776),
            DrawBuffer11Arb = ((int)0x8830),
            MaxProgramNativeParameters = ((int)0x88ab),
            Aux3 = ((int)0x040c),
            StencilPassDepthFail = ((int)0x0b95),
            Intensity32uiExt = ((int)0x8d73),
            LocalConstantValueExt = ((int)0x87ec),
            LocalConstantExt = ((int)0x87c3),
            Map2TangentExt = ((int)0x8445),
            Luminance16Alpha8IccSgix = ((int)0x846b),
            WideLineHintPgi = ((int)0x1a222),
            Modelview15Arb = ((int)0x872f),
            MaxCubeMapTextureSize = ((int)0x851c),
            DepthStencilToRgbaNv = ((int)0x886e),
            Source2AlphaExt = ((int)0x858a),
            CurrentVertexExt = ((int)0x87e2),
            PixelMapAToASize = ((int)0x0cb9),
            PostColorMatrixBlueScale = ((int)0x80b6),
            PostColorMatrixGreenScale = ((int)0x80b5),
            Light6 = ((int)0x4006),
            Combiner6Nv = ((int)0x8556),
            MaxFragmentUniformComponents = ((int)0x8b49),
            VertexWeightArrayPointerExt = ((int)0x8510),
                Modelview12Arb = ((int)0x872c),
            MaxRectangleTextureSizeNv = ((int)0x84f8),
            Bgra = ((int)0x80e1),
            OpDot4Ext = ((int)0x8785),
            Map2VertexAttrib104Nv = ((int)0x867a),
            Operand1Alpha = ((int)0x8599),
            Rgb10Ext = ((int)0x8052),
            IndexArrayCountExt = ((int)0x8087),
            R1uiC4fN3fV3fSun = ((int)0x85c8),
            Map2VertexAttrib154Nv = ((int)0x867f),
            PointBit = ((int)0x00000002),
            FragmentLight6Sgix = ((int)0x8412),
            IntensityFloat16Ati = ((int)0x881d),
            MaxNameStackDepth = ((int)0x0d37),
            FragmentLightModelAmbientSgix = ((int)0x840a),
            LineSmoothHint = ((int)0x0c52),
            Modelview13Arb = ((int)0x872d),
            UnpackSkipImages = ((int)0x806d),
            Modelview2Arb = ((int)0x8722),
                Rgba2Ext = ((int)0x8055),
            PixelUnpackBufferArb = ((int)0x88ec),
            Con8Ati = ((int)0x8949),
            TextureCubeMapPositiveYArb = ((int)0x8517),
            Alpha = ((int)0x1906),
            WeightArrayBufferBindingArb = ((int)0x889e),
            OutputTextureCoord13Ext = ((int)0x87aa),
            MaxProgramNativeAttribs = ((int)0x88af),
            IntSampler1dExt = ((int)0x8dc9),
            Combiner4Nv = ((int)0x8554),
            Src2Rgb = ((int)0x8582),
            OpPowerExt = ((int)0x8793),
            ColorArrayCountExt = ((int)0x8084),
            TextureIntensitySizeExt = ((int)0x8061),
            SpriteModeSgix = ((int)0x8149),
            SignedLuminance8Alpha8Nv = ((int)0x8704),
            RgbaFloat16Ati = ((int)0x881a),
            Rgb12Ext = ((int)0x8053),
            MaxColorAttachmentsExt = ((int)0x8cdf),
            VertexShaderLocalsExt = ((int)0x87d3),
            IndexMaterialParameterExt = ((int)0x81b9),
            Filter4Sgis = ((int)0x8146),
            MaxDrawBuffersArb = ((int)0x8824),
            EvalVertexAttrib9Nv = ((int)0x86cf),
            TextureIntensityTypeArb = ((int)0x8c15),
            CombinerMappingNv = ((int)0x8543),
            IndexArrayType = ((int)0x8085),
            DotProductTexture3dNv = ((int)0x86ef),
            StencilBackValueMask = ((int)0x8ca4),
                VariableBNv = ((int)0x8524),
            Combiner3Nv = ((int)0x8553),
            FragmentProgramNv = ((int)0x8870),
            Triangles = ((int)0x0004),
            WeightArrayTypeArb = ((int)0x86a9),
            OffsetTexture2dNv = ((int)0x86e8),
            DrawBuffer8 = ((int)0x882d),
            DrawBuffer9 = ((int)0x882e),
            AccumRedBits = ((int)0x0d58),
            DrawBuffer7 = ((int)0x882c),
            DrawBuffer4 = ((int)0x8829),
            DrawBuffer5 = ((int)0x882a),
            DrawBuffer2 = ((int)0x8827),
            DrawBuffer3 = ((int)0x8828),
            SampleBuffersSgis = ((int)0x80a8),
            DrawBuffer1 = ((int)0x8826),
            DynamicRead = ((int)0x88e9),
            TextureCubeMapArb = ((int)0x8513),
            InterlaceReadOml = ((int)0x8981),
            RedBitAti = ((int)0x00000001),
            PixelMapSToS = ((int)0x0c71),
            AlphaScale = ((int)0x0d1c),
            ClientActiveTexture = ((int)0x84e1),
            TextureCoordArraySize = ((int)0x8088),
            MagnitudeBiasNv = ((int)0x8718),
            Modelview16Arb = ((int)0x8730),
            Texture6 = ((int)0x84c6),
            LineStrip = ((int)0x0003),
            StreamDraw = ((int)0x88e0),
            InterpolateArb = ((int)0x8575),
            TextureCompareFunc = ((int)0x884d),
            VertexConsistentHintPgi = ((int)0x1a22b),
            AlphaMaxClampIngr = ((int)0x8567),
            Texture9Arb = ((int)0x84c9),
            ConvolutionBorderColor = ((int)0x8154),
                Reg19Ati = ((int)0x8934),
            LineStripAdjacencyExt = ((int)0x000b),
            Gl2pass0Sgis = ((int)0x80a2),
            C4ubV3f = ((int)0x2a23),
            VariableDNv = ((int)0x8526),
            MaxLights = ((int)0x0d31),
            NormalArrayListIbm = ((int)103071),
            Aux2 = ((int)0x040b),
            NormalArrayStrideExt = ((int)0x807f),
            ForceBlueToOneNv = ((int)0x8860),
            Alpha16fArb = ((int)0x881c),
            PixelMapIToB = ((int)0x0c74),
                CurrentAttribNv = ((int)0x8626),
            ColorIndex16Ext = ((int)0x80e7),
            PnTrianglesPointModeAti = ((int)0x87f2),
            Projection = ((int)0x1701),
            DstColor = ((int)0x0306),
                Constant = ((int)0x8576),
            CompressedRgbaS3tcDxt5Ext = ((int)0x83f3),
            WriteOnly = ((int)0x88b9),
            CompressedIntensityArb = ((int)0x84ec),
            CompressedRgbaArb = ((int)0x84ee),
            ArrayType = ((int)0x8625),
                    FogEnd = ((int)0x0b64),
            UnsignedShort1555Reversed = ((int)0x8366),
            Gl2pass1Sgis = ((int)0x80a3),
            DepthBoundsExt = ((int)0x8891),
            StencilBackFunc = ((int)0x8800),
            TextureApplicationModeExt = ((int)0x834f),
            Texture1d = ((int)0x0de0),
            Rgb16Ext = ((int)0x8054),
            VertexAttribArray8Nv = ((int)0x8658),
            InstrumentBufferPointerSgix = ((int)0x8180),
                CurrentWeightArb = ((int)0x86a8),
            Reg28Ati = ((int)0x893d),
            ScalebiasHintSgix = ((int)0x8322),
            LuminanceIccSgix = ((int)0x8463),
            OutputColor1Ext = ((int)0x879c),
            ProjectionMatrix = ((int)0x0ba7),
            EdgeFlagArrayStrideExt = ((int)0x808c),
            PackSkipImages = ((int)0x806b),
            VariableFNv = ((int)0x8528),
            Blue = ((int)0x1905),
            MaxProgramNativeTexIndirectionsArb = ((int)0x8810),
            TextureMaxAnisotropyExt = ((int)0x84fe),
            Rgb12 = ((int)0x8053),
            Rgb10 = ((int)0x8052),
            Rgb16 = ((int)0x8054),
            MaxProgramEnvParameters = ((int)0x88b5),
            InvariantValueExt = ((int)0x87ea),
            MatrixIndexArrayPointerArb = ((int)0x8849),
            T2fIuiV3fExt = ((int)0x81b2),
            SpriteAxisSgix = ((int)0x814a),
            Dot3RgbExt = ((int)0x8740),
            BackNormalsHintPgi = ((int)0x1a223),
            UnsignedIntSampler2dExt = ((int)0x8dd2),
            MaxVertexArrayRangeElementNv = ((int)0x8520),
            PhongHintWin = ((int)0x80eb),
            LineWidth = ((int)0x0b21),
            DrawBuffer12 = ((int)0x8831),
            IrInstrument1Sgix = ((int)0x817f),
            TextureMultiBufferHintSgix = ((int)0x812e),
            Reg14Ati = ((int)0x892f),
            VariableGNv = ((int)0x8529),
            IncrWrapExt = ((int)0x8507),
            UnsignedInt10f11f11fRevExt = ((int)0x8c3b),
            FenceStatusNv = ((int)0x84f3),
            ColorMaterial = ((int)0x0b57),
            MaxConvolutionHeight = ((int)0x801b),
            TextureConstantDataSunx = ((int)0x81d6),
            Viewport = ((int)0x0ba2),
            ListBit = ((int)0x00020000),
            TextureBindingCubeMap = ((int)0x8514),
            UnsignedInt248Ext = ((int)0x84fa),
                Four = ((int)4),
            UnpackSubsampleRateSgix = ((int)0x85a1),
            Texture15 = ((int)0x84cf),
            Texture12 = ((int)0x84cc),
            Texture13 = ((int)0x84cd),
            Reg15Ati = ((int)0x8930),
            Texture11 = ((int)0x84cb),
            EyeDistanceToPointSgis = ((int)0x81f0),
            TextureCompareOperatorSgix = ((int)0x819b),
            UnpackAlignment = ((int)0x0cf5),
            BoolVec4 = ((int)0x8b59),
                Texture18 = ((int)0x84d2),
            DualIntensity12Sgis = ((int)0x811a),
            Texture20 = ((int)0x84d4),
            Reg3Ati = ((int)0x8924),
            ColorMaterialParameter = ((int)0x0b56),
            Operand2Alpha = ((int)0x859a),
            MaxVertexTextureImageUnitsArb = ((int)0x8b4c),
            MadAti = ((int)0x8968),
            Map1TangentExt = ((int)0x8444),
            R1uiT2fC4fN3fV3fSun = ((int)0x85cb),
            AmbientAndDiffuse = ((int)0x1602),
            ElementArrayTypeAti = ((int)0x8769),
                ProxyHistogram = ((int)0x8025),
            Operand1RgbArb = ((int)0x8591),
            Reg16Ati = ((int)0x8931),
            CopyPixelToken = ((int)0x0706),
            ColorAttachment0Ext = ((int)0x8ce0),
            TransposeTextureMatrixArb = ((int)0x84e5),
            EdgeFlagArrayStride = ((int)0x808c),
            AttribArrayPointerNv = ((int)0x8645),
            MaxProjectionStackDepth = ((int)0x0d38),
            Modelview18Arb = ((int)0x8732),
            FloatMat4 = ((int)0x8b5c),
            DepthTest = ((int)0x0b71),
            BackSecondaryColorNv = ((int)0x8c78),
            ColorAttachment13Ext = ((int)0x8ced),
            Map2BinormalExt = ((int)0x8447),
            BoolArb = ((int)0x8b56),
            CompressedTextureFormats = ((int)0x86a3),
            Source2AlphaArb = ((int)0x858a),
            CompressedAlphaArb = ((int)0x84e9),
                SignedLuminance8Nv = ((int)0x8702),
            Light4 = ((int)0x4004),
            Aux1 = ((int)0x040a),
            StencilClearTagValueExt = ((int)0x88f3),
            OutputTextureCoord31Ext = ((int)0x87bc),
                TextureLequalRSgix = ((int)0x819c),
            PixelMapIToA = ((int)0x0c75),
            ColorAttachment8Ext = ((int)0x8ce8),
            FramebufferCompleteExt = ((int)0x8cd5),
                FloatMat4x3 = ((int)0x8b6a),
            PnTrianglesPointModeLinearAti = ((int)0x87f5),
            Operand2Rgb = ((int)0x8592),
            R5G6B5IccSgix = ((int)0x8466),
            Notequal = ((int)0x0205),
            Polygon = ((int)0x0009),
            PixelPackBuffer = ((int)0x88eb),
            Reg10Ati = ((int)0x892b),
            Texture4dBindingSgis = ((int)0x814f),
            TexturePriorityExt = ((int)0x8066),
            PixelTexGenSgix = ((int)0x8139),
            ColorMatrixStackDepth = ((int)0x80b2),
            TextureCubeMapNegativeZArb = ((int)0x851a),
            HalfBitAti = ((int)0x00000008),
            Texture2dStackBindingMesax = ((int)0x875e),
            Sluminance8Alpha8Ext = ((int)0x8c45),
            OutputTextureCoord19Ext = ((int)0x87b0),
            ProgramNativeAluInstructionsArb = ((int)0x8808),
            StaticRead = ((int)0x88e5),
            PackImageHeight = ((int)0x806c),
                SampleMaskInvertExt = ((int)0x80ab),
            Gequal = ((int)0x0206),
            ElementArrayBuffer = ((int)0x8893),
            Nearest = ((int)0x2600),
            ProgramLengthNv = ((int)0x8627),
            FramebufferIncompleteDrawBufferExt = ((int)0x8cdb),
            Hilo16Nv = ((int)0x86f8),
                MatSpecularBitPgi = ((int)0x04000000),
            BlendEquationRgbExt = ((int)0x8009),
            IndexBits = ((int)0x0d51),
            TextureCubeMapNegativeYArb = ((int)0x8518),
                    MaxProgramCallDepthNv = ((int)0x88f5),
            MatDiffuseBitPgi = ((int)0x00400000),
            DualTextureSelectSgis = ((int)0x8124),
            TextureCoordArrayStride = ((int)0x808a),
            FloatMat2x4 = ((int)0x8b66),
            MatAmbientAndDiffuseBitPgi = ((int)0x00200000),
            OutputFogExt = ((int)0x87bd),
            LineStipplePattern = ((int)0x0b25),
            DiscardNv = ((int)0x8530),
            FloatMat2x3 = ((int)0x8b65),
            IndexMaterialFaceExt = ((int)0x81ba),
            Source0AlphaExt = ((int)0x8588),
            Luminance12Alpha4Ext = ((int)0x8046),
            Modelview5Arb = ((int)0x8725),
            PixelMapBToB = ((int)0x0c78),
            False = ((int)0),
            Texture2Arb = ((int)0x84c2),
            DrawBuffer13 = ((int)0x8832),
            TextureCubeMapNegativeXArb = ((int)0x8516),
            BlendSrcRgb = ((int)0x80c9),
            MaxVertexTextureImageUnits = ((int)0x8b4c),
            Gl1passSgis = ((int)0x80a1),
            RgbaMode = ((int)0x0c31),
            ReadOnlyArb = ((int)0x88b8),
            Rgb32fArb = ((int)0x8815),
            ProxyTexture1dExt = ((int)0x8063),
            ArrayPointer = ((int)0x8645),
            FloatR32Nv = ((int)0x8885),
            BinormalArrayExt = ((int)0x843a),
            AttribArrayStrideNv = ((int)0x8624),
            Reg13Ati = ((int)0x892e),
            DrawBuffer9Ati = ((int)0x882e),
            LerpAti = ((int)0x8969),
            MaxProgramExecInstructionsNv = ((int)0x88f4),
            PointSpriteRModeNv = ((int)0x8863),
            FragmentLightModelTwoSideSgix = ((int)0x8409),
            StencilTestTwoSideExt = ((int)0x8910),
            MaxColorMatrixStackDepth = ((int)0x80b3),
            TextureWrapS = ((int)0x2802),
            VertexShaderInvariantsExt = ((int)0x87d1),
            StreamDrawArb = ((int)0x88e0),
            SpriteTranslationSgix = ((int)0x814b),
            PostConvolutionBlueBias = ((int)0x8022),
            OpAddExt = ((int)0x8787),
                SecondaryColorArraySizeExt = ((int)0x845a),
            TextureRedTypeArb = ((int)0x8c10),
            DrawBuffer15 = ((int)0x8834),
            LightModelTwoSide = ((int)0x0b52),
            BlueBits = ((int)0x0d54),
            Depth24Stencil8Ext = ((int)0x88f0),
            Reg4Ati = ((int)0x8925),
            UnsignedByte = ((int)0x1401),
            OutputTextureCoord24Ext = ((int)0x87b5),
            DrawBuffer8Ati = ((int)0x882d),
            Operand2RgbExt = ((int)0x8592),
            Exp2 = ((int)0x0801),
            FragmentDepthExt = ((int)0x8452),
            ImageTranslateXHp = ((int)0x8157),
            FogCoordinateArrayStrideExt = ((int)0x8455),
            Or = ((int)0x1507),
            VertexArrayStride = ((int)0x807c),
            StrictScissorHintPgi = ((int)0x1a218),
            SecondaryColorArrayStrideExt = ((int)0x845c),
            Texture8Arb = ((int)0x84c8),
            PreviousExt = ((int)0x8578),
            CompressedSrgb = ((int)0x8c48),
            FloatMat3x4 = ((int)0x8b68),
            StencilBufferBit = ((int)0x00000400),
            ColorAttachment11Ext = ((int)0x8ceb),
            MaxDrawBuffers = ((int)0x8824),
            OutOfMemory = ((int)0x0505),
            FloatMat3x2 = ((int)0x8b67),
            Gl8xBitAti = ((int)0x00000004),
            Luminance12Alpha12 = ((int)0x8047),
            ImageTranslateYHp = ((int)0x8158),
            EvalVertexAttrib13Nv = ((int)0x86d3),
            VertexProgramPointSizeArb = ((int)0x8642),
            Reg22Ati = ((int)0x8937),
            ArrayEnabled = ((int)0x8622),
            TransformBit = ((int)0x00001000),
            OpSetLtExt = ((int)0x878d),
            NoError = ((int)0),
            FramebufferSrgbExt = ((int)0x8db9),
            InfoLogLength = ((int)0x8b84),
            LuminanceFloat32Ati = ((int)0x8818),
                StencilBackPassDepthFail = ((int)0x8802),
            VertexShaderLocalConstantsExt = ((int)0x87d2),
            ColorAttachment12Ext = ((int)0x8cec),
            SpotCutoff = ((int)0x1206),
            WeightSumUnityArb = ((int)0x86a6),
            MaxTextureUnits = ((int)0x84e2),
            StaticCopy = ((int)0x88e6),
            VertexArrayListIbm = ((int)103070),
            DrawBuffer2Ati = ((int)0x8827),
            EdgeFlagArray = ((int)0x8079),
            BufferFlushingUnmapApple = ((int)0x8a13),
            StencilIndex8Ext = ((int)0x8d48),
            ShaderType = ((int)0x8b4f),
            InvalidValue = ((int)0x0501),
            VertexAttribArray9Nv = ((int)0x8659),
            Con2Ati = ((int)0x8943),
            TextureFilter4SizeSgis = ((int)0x8147),
            LuminanceFloat16Ati = ((int)0x881e),
                BlendDstAlpha = ((int)0x80ca),
            PointSpriteNv = ((int)0x8861),
            DualLuminance4Sgis = ((int)0x8114),
            DualLuminanceAlpha4Sgis = ((int)0x811c),
            Texture3d = ((int)0x806f),
            TextureIndexSizeExt = ((int)0x80ed),
            DotProductDiffuseCubeMapNv = ((int)0x86f1),
            Intensity8Ext = ((int)0x804b),
            BufferSerializedModifyApple = ((int)0x8a12),
            SecondaryColorArrayStride = ((int)0x845c),
                Luminance12Alpha12Ext = ((int)0x8047),
            SignedHiloNv = ((int)0x86f9),
            PrimitiveRestartNv = ((int)0x8558),
            AllowDrawMemHintPgi = ((int)0x1a211),
            NegateBitAti = ((int)0x00000004),
            SignedHilo16Nv = ((int)0x86fa),
                IntVec4Arb = ((int)0x8b55),
            SamplesPassed = ((int)0x8914),
            ColorAttachment14Ext = ((int)0x8cee),
            UnsignedShort88RevApple = ((int)0x85bb),
            TextureGequalRSgix = ((int)0x819d),
            PixelTileHeightSgix = ((int)0x8141),
            FogDensity = ((int)0x0b62),
            NumInstructionsTotalAti = ((int)0x8972),
            SecondaryColorArrayBufferBindingArb = ((int)0x889c),
            DrawBuffer10 = ((int)0x882f),
            Modelview1Ext = ((int)0x850a),
            FloatRgbaModeNv = ((int)0x888e),
            StreamRead = ((int)0x88e1),
            SrgbExt = ((int)0x8c40),
            Ycrcb444Sgix = ((int)0x81bc),
            Nand = ((int)0x150e),
            Dsdt8Mag8Intensity8Nv = ((int)0x870b),
            EyeDistanceToLineSgis = ((int)0x81f2),
            MatrixIndexArrayTypeArb = ((int)0x8847),
            MatAmbientBitPgi = ((int)0x00100000),
            ClientAllAttribBits = unchecked((int)0xffffffff),
            ColorAttachment15Ext = ((int)0x8cef),
            MaxVertexStreamsAti = ((int)0x876b),
            MaxFragmentProgramLocalParametersNv = ((int)0x8868),
            FogIndex = ((int)0x0b61),
            ConstantAttenuation = ((int)0x1207),
            ZoomY = ((int)0x0d17),
            ZoomX = ((int)0x0d16),
            ReadWriteArb = ((int)0x88ba),
            SampleCoverage = ((int)0x80a0),
            Equiv = ((int)0x1509),
            DrawBuffer7Ati = ((int)0x882c),
            TextureEnv = ((int)0x2300),
            ListPrioritySgix = ((int)0x8182),
            Texture30 = ((int)0x84de),
            Texture31 = ((int)0x84df),
            ProgramAttribs = ((int)0x88ac),
            RenderbufferWidthExt = ((int)0x8d42),
            UnsignedIntSampler1dArrayExt = ((int)0x8dd6),
            Matrix8 = ((int)0x88c8),
            Matrix9 = ((int)0x88c9),
            CurrentVertexAttrib = ((int)0x8626),
            PixelTransform2dMatrixExt = ((int)0x8338),
            Map2VertexAttrib34Nv = ((int)0x8673),
            TextureBufferDataStoreBindingExt = ((int)0x8c2d),
            GlobalAlphaSun = ((int)0x81d9),
            CompressedSignedRedRgtc1Ext = ((int)0x8dbc),
            TextureResidentExt = ((int)0x8067),
            OutputTextureCoord29Ext = ((int)0x87ba),
            EmbossConstantNv = ((int)0x855e),
            ConvolutionFilterScale = ((int)0x8014),
                Srgb8Alpha8 = ((int)0x8c43),
                CombinerMuxSumNv = ((int)0x8547),
            FramebufferAttachmentObjectNameExt = ((int)0x8cd1),
            OpLogBase2Ext = ((int)0x8792),
            TextureEnvColor = ((int)0x2201),
            TextureDsSizeNv = ((int)0x871d),
            ModulateSubtractAti = ((int)0x8746),
            TextureBaseLevel = ((int)0x813c),
            ConstantExt = ((int)0x8576),
            ImageMagFilterHp = ((int)0x815c),
            LocalExt = ((int)0x87c4),
            Source0RgbArb = ((int)0x8580),
            FragmentLight3Sgix = ((int)0x840f),
            AddSigned = ((int)0x8574),
            MaxTextureUnitsArb = ((int)0x84e2),
            Con4Ati = ((int)0x8945),
            SignedRgba8Nv = ((int)0x86fc),
            DualLuminance12Sgis = ((int)0x8116),
            Modelview31Arb = ((int)0x873f),
            DrawBuffer1Ati = ((int)0x8826),
            Intensity16uiExt = ((int)0x8d79),
            BufferSizeArb = ((int)0x8764),
            Fastest = ((int)0x1101),
            OutputTextureCoord21Ext = ((int)0x87b2),
            NameStackDepth = ((int)0x0d70),
                VertexWeightArraySizeExt = ((int)0x850d),
            ClampReadColorArb = ((int)0x891c),
            BackLeft = ((int)0x0402),
            OpRecipExt = ((int)0x8794),
            RedMinClampIngr = ((int)0x8560),
            IntSampler2dRectExt = ((int)0x8dcd),
            OpMaxExt = ((int)0x878a),
            TextureMaxClampRSgix = ((int)0x836b),
            DrawBuffer0Ati = ((int)0x8825),
            FenceApple = ((int)0x8a0b),
            TextureFloatComponentsNv = ((int)0x888c),
            OutputTextureCoord16Ext = ((int)0x87ad),
            Alpha8 = ((int)0x803c),
            TriangleMeshSun = ((int)0x8615),
            Matrix29 = ((int)0x88dd),
            Gl4pass1Ext = ((int)0x80a5),
                    EdgeFlagArrayListStrideIbm = ((int)103085),
            ObjectActiveUniformsArb = ((int)0x8b86),
            TextureBindingRectangleArb = ((int)0x84f6),
            Max3dTextureSize = ((int)0x8073),
            TextureDepthTypeArb = ((int)0x8c16),
            LoScaleNv = ((int)0x870f),
            DrawBuffer9Arb = ((int)0x882e),
            TextureCubeMapPositiveZExt = ((int)0x8519),
            StencilIndex1Ext = ((int)0x8d46),
            VertexWeightingExt = ((int)0x8509),
            ColorIndex = ((int)0x1900),
            DeformationsMaskSgix = ((int)0x8196),
            Version = ((int)0x1f02),
            AllowDrawWinHintPgi = ((int)0x1a20f),
            Source0AlphaArb = ((int)0x8588),
            Alpha4 = ((int)0x803b),
            Dot3Rgb = ((int)0x86ae),
            CullModesNv = ((int)0x86e0),
            MaterialSideHintPgi = ((int)0x1a22c),
            MirroredRepeatIbm = ((int)0x8370),
            StencilFunc = ((int)0x0b92),
            DepthBufferBit = ((int)0x00000100),
            CombineRgbExt = ((int)0x8571),
            Map2VertexAttrib74Nv = ((int)0x8677),
            TextureLodBiasRSgix = ((int)0x8190),
            StencilPassDepthPass = ((int)0x0b96),
            Gl2pass1Ext = ((int)0x80a3),
            DynamicCopyArb = ((int)0x88ea),
            VertexProgramPointSize = ((int)0x8642),
            OutputTextureCoord11Ext = ((int)0x87a8),
            VariantArrayTypeExt = ((int)0x87e7),
            DualLuminanceAlpha8Sgis = ((int)0x811d),
            SwizzleStrAti = ((int)0x8976),
            ColorIndexes = ((int)0x1603),
            SignedIntensity8Nv = ((int)0x8708),
            AlphaBias = ((int)0x0d1d),
            VertexAttribArray4Nv = ((int)0x8654),
            UnpackLsbFirst = ((int)0x0cf1),
            CurrentOcclusionQueryIdNv = ((int)0x8865),
            DepthComponent32Arb = ((int)0x81a7),
            GeometryDeformationBitSgix = ((int)0x00000002),
            ProgramObjectArb = ((int)0x8b40),
            DecrWrap = ((int)0x8508),
            Texture6Arb = ((int)0x84c6),
            Texture3 = ((int)0x84c3),
            Points = ((int)0x0000),
            UniformBufferBindingExt = ((int)0x8def),
            ProgramErrorPositionArb = ((int)0x864b),
            DependentGbTexture2dNv = ((int)0x86ea),
            Convolution1d = ((int)0x8010),
            Operand3AlphaNv = ((int)0x859b),
            RedScale = ((int)0x0d14),
            UnsignedInt8888Reversed = ((int)0x8367),
            ObjectSubtypeArb = ((int)0x8b4f),
            Texture12Arb = ((int)0x84cc),
            ETimesFNv = ((int)0x8531),
            VertexArrayTypeExt = ((int)0x807b),
            BufferAccessArb = ((int)0x88bb),
            Rgb4 = ((int)0x804f),
            ColorArraySizeExt = ((int)0x8081),
            ActiveVaryingsNv = ((int)0x8c81),
            UnpackImageDepthSgis = ((int)0x8133),
            VertexProgramTwoSideNv = ((int)0x8643),
            UnsignedInt8888Rev = ((int)0x8367),
            Dot3RgbaArb = ((int)0x86af),
            EyePlaneAbsoluteNv = ((int)0x855c),
            PolygonOffsetFill = ((int)0x8037),
            IndexTestExt = ((int)0x81b5),
            BoolVec2Arb = ((int)0x8b57),
            YExt = ((int)0x87d6),
            Always = ((int)0x0207),
            CurrentRasterPositionValid = ((int)0x0b08),
            Operand1RgbExt = ((int)0x8591),
                NormalArrayBufferBinding = ((int)0x8897),
            FragmentLight4Sgix = ((int)0x8410),
                PointFadeThresholdSize = ((int)0x8128),
            MaxOptimizedVertexShaderVariantsExt = ((int)0x87cb),
            VertexArrayRangeApple = ((int)0x851d),
            SluminanceAlpha = ((int)0x8c44),
            SpotDirection = ((int)0x1204),
            ArrayNormalized = ((int)0x886a),
            DecrWrapExt = ((int)0x8508),
            Alpha12 = ((int)0x803d),
            CombinerCdOutputNv = ((int)0x854b),
            RgbIccSgix = ((int)0x8460),
            TextureCompressionHint = ((int)0x84ef),
            ResampleReplicateOml = ((int)0x8986),
                ScaleByOneHalfNv = ((int)0x8540),
            PixelMapSToSSize = ((int)0x0cb1),
            ArrayBufferBinding = ((int)0x8894),
            Map1VertexAttrib24Nv = ((int)0x8662),
            Map2VertexAttrib144Nv = ((int)0x867e),
            OcclusionTestHp = ((int)0x8165),
            StencilIndex4Ext = ((int)0x8d47),
            C4fN3fV3f = ((int)0x2a26),
            InvalidEnum = ((int)0x0500),
            DepthBits = ((int)0x0d56),
            CompressedSrgbAlphaExt = ((int)0x8c49),
            DrawBuffer4Arb = ((int)0x8829),
            TextureCubeMapPositiveYExt = ((int)0x8517),
            ProgramParameters = ((int)0x88a8),
            Gl2Bytes = ((int)0x1407),
            Modelview30Arb = ((int)0x873e),
            CopyInverted = ((int)0x150c),
            ImageRotateOriginYHp = ((int)0x815b),
            Matrix28 = ((int)0x88dc),
            FogOffsetValueSgix = ((int)0x8199),
                TextureBlueTypeArb = ((int)0x8c12),
            Map2TextureCoord1 = ((int)0x0db3),
            Exp = ((int)0x0800),
            PostColorMatrixRedScale = ((int)0x80b4),
            Gl3dColorTexture = ((int)0x0603),
            MaxGeometryTextureImageUnitsExt = ((int)0x8c29),
            SignedRgb8Nv = ((int)0x86ff),
            EmbossLightNv = ((int)0x855d),
            LuminanceAlphaFloat32Ati = ((int)0x8819),
            LuminanceAlpha16fArb = ((int)0x881f),
            Map1BinormalExt = ((int)0x8446),
            Operand0RgbArb = ((int)0x8590),
            DrawBuffer7Arb = ((int)0x882c),
            FramebufferIncompleteFormatsExt = ((int)0x8cda),
            Operand2AlphaExt = ((int)0x859a),
            ModelviewStackDepth = ((int)0x0ba3),
            Intensity8 = ((int)0x804b),
            FormatSubsample2424Oml = ((int)0x8982),
            VertexIdNv = ((int)0x8c7b),
            Modelview9Arb = ((int)0x8729),
            ShadowAttenuationExt = ((int)0x834e),
            SampleMaskSgis = ((int)0x80a0),
            ColorSumExt = ((int)0x8458),
            ClampToEdge = ((int)0x812f),
            NormalArrayListStrideIbm = ((int)103081),
            ColorArrayPointerExt = ((int)0x8090),
            TextureGreenSize = ((int)0x805d),
            BlendDstRgb = ((int)0x80c8),
            TextureCompressedImageSizeArb = ((int)0x86a0),
            CurrentRasterSecondaryColor = ((int)0x845f),
            TransposeColorMatrix = ((int)0x84e6),
            CubicExt = ((int)0x8334),
            TextureCompareMode = ((int)0x884c),
            ArrayBuffer = ((int)0x8892),
            ParallelArraysIntel = ((int)0x83f4),
            ProxyTexture1dStackMesax = ((int)0x875b),
            ListIndex = ((int)0x0b33),
            OneMinusSrcAlpha = ((int)0x0303),
            SamplesExt = ((int)0x80a9),
            DotProductDepthReplaceNv = ((int)0x86ed),
            Convolution2d = ((int)0x8011),
            DualIntensity16Sgis = ((int)0x811b),
            QueryCounterBitsArb = ((int)0x8864),
            OutputTextureCoord10Ext = ((int)0x87a7),
            Texture5Arb = ((int)0x84c5),
            MaxSpotExponentNv = ((int)0x8505),
            ObjectPointSgis = ((int)0x81f5),
                OffsetHiloProjectiveTexture2dNv = ((int)0x8856),
            CompressedLuminanceAlpha = ((int)0x84eb),
            FragmentShaderDerivativeHint = ((int)0x8b8b),
            SelectionBufferSize = ((int)0x0df4),
            DepthWritemask = ((int)0x0b72),
            FuncSubtract = ((int)0x800a),
            ColorArrayBufferBinding = ((int)0x8898),
            AddSignedExt = ((int)0x8574),
            RenderbufferHeightExt = ((int)0x8d43),
            WExt = ((int)0x87d8),
            Modelview0Ext = ((int)0x1700),
            CurrentQuery = ((int)0x8865),
            TextureMaxClampTSgix = ((int)0x836a),
            EvalVertexAttrib2Nv = ((int)0x86c8),
            VertexArrayCountExt = ((int)0x807d),
            Rgb8Ext = ((int)0x8051),
            Rgb5A1Ext = ((int)0x8057),
            DrawBuffer0Arb = ((int)0x8825),
            TextureBindingCubeMapExt = ((int)0x8514),
                ColorBufferBit = ((int)0x00004000),
            MaxGeometryOutputVerticesExt = ((int)0x8de0),
            Map1VertexAttrib114Nv = ((int)0x866b),
            InvertedScreenWRend = ((int)0x8491),
            Reg12Ati = ((int)0x892d),
            VertexArrayRangePointerApple = ((int)0x8521),
            MirroredRepeat = ((int)0x8370),
            CoordReplaceNv = ((int)0x8862),
            OpMaddExt = ((int)0x8788),
            Left = ((int)0x0406),
            Intensity4 = ((int)0x804a),
            Color4BitPgi = ((int)0x00020000),
            CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8c4f),
            EvalVertexAttrib3Nv = ((int)0x86c9),
            FuncAdd = ((int)0x8006),
            SwizzleStqAti = ((int)0x8977),
            ProgramNativeInstructions = ((int)0x88a2),
            MaxTextureSize = ((int)0x0d33),
            TexturePriority = ((int)0x8066),
                DrawBuffer3Arb = ((int)0x8828),
            ClipPlane5 = ((int)0x3005),
                OpMulExt = ((int)0x8786),
            DualAlpha12Sgis = ((int)0x8112),
            CombineAlpha = ((int)0x8572),
            MaxVertexUniformComponentsArb = ((int)0x8b4a),
            OutputTextureCoord17Ext = ((int)0x87ae),
            CombineArb = ((int)0x8570),
            VertexProgramBindingNv = ((int)0x864a),
            CoordReplaceArb = ((int)0x8862),
            Dot3RgbaExt = ((int)0x8741),
            Gl4pass0Ext = ((int)0x80a4),
            NormalArray = ((int)0x8075),
            MaxVaryingFloatsArb = ((int)0x8b4b),
            ModelviewMatrix = ((int)0x0ba6),
            Luminance32uiExt = ((int)0x8d74),
            EdgeFlagArrayPointer = ((int)0x8093),
            TextureBlueSizeExt = ((int)0x805e),
            RescaleNormal = ((int)0x803a),
            Map2VertexAttrib94Nv = ((int)0x8679),
            VertexBlendArb = ((int)0x86a7),
            NormalMapArb = ((int)0x8511),
            Alpha8uiExt = ((int)0x8d7e),
            PostTextureFilterBiasSgix = ((int)0x8179),
            IuiN3fV2fExt = ((int)0x81af),
            MaxTextureLodBiasExt = ((int)0x84fd),
            FragmentColorExt = ((int)0x834c),
                MaxFogFuncPointsSgis = ((int)0x812c),
            Matrix0Nv = ((int)0x8630),
            CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8c4e),
            Luminance8Alpha8Ext = ((int)0x8045),
            Float = ((int)0x1406),
            ClampFragmentColorArb = ((int)0x891b),
            NumLoopbackComponentsAti = ((int)0x8974),
            Texture26 = ((int)0x84da),
            Texture27 = ((int)0x84db),
            Rgba8uiExt = ((int)0x8d7c),
            TextureMinFilter = ((int)0x2801),
            Rgb32iExt = ((int)0x8d83),
            FragmentShaderAti = ((int)0x8920),
            FogCoordArrayStride = ((int)0x8455),
            Texture2 = ((int)0x84c2),
                StencilAttachmentExt = ((int)0x8d20),
            MaxProgramParameterBufferSizeNv = ((int)0x8da1),
            Doublebuffer = ((int)0x0c32),
            EvalVertexAttrib6Nv = ((int)0x86cc),
            SampleAlphaToMaskExt = ((int)0x809e),
            MaxShininessNv = ((int)0x8504),
            UnsignedIntSampler1dExt = ((int)0x8dd1),
            ObjectDistanceToLineSgis = ((int)0x81f3),
            Texture1dStackBindingMesax = ((int)0x875d),
            Matrix3Nv = ((int)0x8633),
            FramebufferIncompleteLayerCountExt = ((int)0x8da9),
            MaxProgramInstructions = ((int)0x88a1),
            OneMinusConstantAlpha = ((int)0x8004),
            CullFaceMode = ((int)0x0b45),
            PixelMapIToGSize = ((int)0x0cb3),
            AndReverse = ((int)0x1502),
            FogCoordinateArrayListIbm = ((int)103076),
            ProgramNativeAttribs = ((int)0x88ae),
            UnsignedInt2101010Rev = ((int)0x8368),
            BiasByNegativeOneHalfNv = ((int)0x8541),
            InterlaceReadIngr = ((int)0x8568),
            ColorTableBias = ((int)0x80d7),
            FloatRgb16Nv = ((int)0x8888),
            Map1VertexAttrib74Nv = ((int)0x8667),
            GenericAttribNv = ((int)0x8c7d),
            Map2Vertex4 = ((int)0x0db8),
            Matrix24 = ((int)0x88d8),
            StencilBackPassDepthFailAti = ((int)0x8802),
            Map2Vertex3 = ((int)0x0db7),
            TextureCoordNv = ((int)0x8c79),
            AndInverted = ((int)0x1504),
            Map2VertexAttrib84Nv = ((int)0x8678),
            AsyncReadPixelsSgix = ((int)0x835e),
            ColorIndex12Ext = ((int)0x80e6),
                SampleMaskValueSgis = ((int)0x80aa),
            PostColorMatrixColorTable = ((int)0x80d2),
            Gl4pass0Sgis = ((int)0x80a4),
            IndexArrayStride = ((int)0x8086),
            Bitmap = ((int)0x1a00),
            T2fIuiN3fV2fExt = ((int)0x81b3),
                MinmaxFormat = ((int)0x802f),
            EvalVertexAttrib0Nv = ((int)0x86c6),
            OrReverse = ((int)0x150b),
            Srgb = ((int)0x8c40),
            ArraySize = ((int)0x8623),
            AverageExt = ((int)0x8335),
            TextureLuminanceSize = ((int)0x8060),
            LinearSharpenColorSgis = ((int)0x80af),
            FramebufferAttachmentLayeredExt = ((int)0x8da7),
            Rgb9E5Ext = ((int)0x8c3d),
            AlphaBits = ((int)0x0d55),
            Texture2dStackMesax = ((int)0x875a),
            Sluminance8 = ((int)0x8c47),
            Con7Ati = ((int)0x8948),
            Luminance12Alpha4 = ((int)0x8046),
            TextureGenS = ((int)0x0c60),
            Less = ((int)0x0201),
            TextureGenQ = ((int)0x0c63),
            UnsignedShort88Mesa = ((int)0x85ba),
            FloatVec3Arb = ((int)0x8b51),
            TextureGenT = ((int)0x0c61),
            CmykExt = ((int)0x800c),
            EvalVertexAttrib1Nv = ((int)0x86c7),
            PostConvolutionRedBias = ((int)0x8020),
            OpFracExt = ((int)0x8789),
            TextureBit = ((int)0x00040000),
            Map2VertexAttrib24Nv = ((int)0x8672),
            Rgb = ((int)0x1907),
            MaxTransformFeedbackInterleavedAttribsNv = ((int)0x8c8a),
            SampleAlphaToOneExt = ((int)0x809f),
            MultisampleExt = ((int)0x809d),
            DrawBuffer0 = ((int)0x8825),
            TextureCoordArrayPointer = ((int)0x8092),
            Samples3dfx = ((int)0x86b4),
            Rgba32fArb = ((int)0x8814),
            SeparateSpecularColor = ((int)0x81fa),
            Aux0 = ((int)0x0409),
            StackUnderflow = ((int)0x0504),
            ConstantArb = ((int)0x8576),
            MaxFragmentUniformComponentsArb = ((int)0x8b49),
            FloatVec2Arb = ((int)0x8b50),
            OffsetHiloProjectiveTextureRectangleNv = ((int)0x8857),
            Intensity16iExt = ((int)0x8d8b),
            DetailTexture2dSgis = ((int)0x8095),
            PackRowLength = ((int)0x0d02),
            RenderbufferBindingExt = ((int)0x8ca7),
            SmoothPointSizeRange = ((int)0x0b12),
            Con16Ati = ((int)0x8951),
            AddAti = ((int)0x8963),
            Matrix12 = ((int)0x88cc),
            VertexArrayType = ((int)0x807b),
            VertexAttribArrayBufferBinding = ((int)0x889f),
            CurrentMatrixIndexArb = ((int)0x8845),
            RgbaIccSgix = ((int)0x8461),
                    OutputTextureCoord14Ext = ((int)0x87ab),
            MaxTextureImageUnitsNv = ((int)0x8872),
            Gl3d = ((int)0x0601),
            IndexWritemask = ((int)0x0c21),
            Position = ((int)0x1203),
            ProgramNativeParameters = ((int)0x88aa),
            VertexAttribArray3Nv = ((int)0x8653),
            Con17Ati = ((int)0x8952),
            DynamicDrawArb = ((int)0x88e8),
            BumpRotMatrixAti = ((int)0x8775),
            OffsetTexture2dBiasNv = ((int)0x86e3),
            RenderbufferAlphaSizeExt = ((int)0x8d53),
            Combiner5Nv = ((int)0x8555),
            Gl422RevAverageExt = ((int)0x80cf),
            WrapBorderSun = ((int)0x81d4),
            OutputVertexExt = ((int)0x879a),
            ElementArrayTypeApple = ((int)0x8769),
            HistogramBlueSize = ((int)0x802a),
            Combine4Nv = ((int)0x8503),
            FloatVec4Arb = ((int)0x8b52),
            ReplacementCodeArrayTypeSun = ((int)0x85c1),
                ProgramNativeTexInstructionsArb = ((int)0x8809),
                ProxyTextureColorTableSgi = ((int)0x80bd),
            Map2VertexAttrib14Nv = ((int)0x8671),
            MaxViewportDims = ((int)0x0d3a),
                AlphaMaxSgix = ((int)0x8321),
            PixelCubicWeightExt = ((int)0x8333),
                DrawFramebufferBindingExt = ((int)0x8caa),
            EvalVertexAttrib5Nv = ((int)0x86cb),
            TextureComponents = ((int)0x1003),
            Map2TextureCoord4 = ((int)0x0db6),
            Map2TextureCoord2 = ((int)0x0db4),
            Map2TextureCoord3 = ((int)0x0db5),
            RenderbufferColorSamplesNv = ((int)0x8e10),
            MaxRenderbufferSizeExt = ((int)0x84e8),
            Matrix18 = ((int)0x88d2),
            Mult = ((int)0x0103),
            ImageScaleYHp = ((int)0x8156),
            ColorIndex8Ext = ((int)0x80e5),
            StencilBackPassDepthPassAti = ((int)0x8803),
            Modelview0Arb = ((int)0x1700),
            SamplerCubeArb = ((int)0x8b60),
            BlendColor = ((int)0x8005),
            C3fV3f = ((int)0x2a24),
                DetailTexture2dBindingSgis = ((int)0x8096),
            FloatRgbNv = ((int)0x8882),
            ReplacementCodeArrayPointerSun = ((int)0x85c3),
            DrawPixelToken = ((int)0x0705),
            PointSizeGranularity = ((int)0x0b13),
            RgbScaleExt = ((int)0x8573),
            Max = ((int)0x8008),
            TriangleFan = ((int)0x0006),
            Con12Ati = ((int)0x894d),
            QuadIntensity8Sgis = ((int)0x8123),
            UnpackSkipPixels = ((int)0x0cf4),
            LineLoop = ((int)0x0002),
            BlendDstAlphaExt = ((int)0x80ca),
            DualIntensity8Sgis = ((int)0x8119),
            Map1VertexAttrib154Nv = ((int)0x866f),
            Alpha12Ext = ((int)0x803d),
            MaxVertexShaderLocalConstantsExt = ((int)0x87c8),
            SpriteSgix = ((int)0x8148),
            AllowDrawFrgHintPgi = ((int)0x1a210),
            TextureCompressedArb = ((int)0x86a1),
            VertexArrayRangeLengthNv = ((int)0x851e),
            QuadAlpha8Sgis = ((int)0x811f),
            VertexAttribArrayBufferBindingArb = ((int)0x889f),
            Source0RgbExt = ((int)0x8580),
            V2f = ((int)0x2a20),
            FloatRgbaNv = ((int)0x8883),
            IdentityNv = ((int)0x862a),
            InvalidOperation = ((int)0x0502),
            Con13Ati = ((int)0x894e),
            AllowDrawObjHintPgi = ((int)0x1a20e),
            Map2VertexAttrib04Nv = ((int)0x8670),
            LinearDetailColorSgis = ((int)0x8099),
            SampleAlphaToOne = ((int)0x809f),
            VertexProgramTwoSide = ((int)0x8643),
            ActiveAttributes = ((int)0x8b89),
            TangentArrayStrideExt = ((int)0x843f),
            Luminance8Alpha8 = ((int)0x8045),
            DrawPixelsApple = ((int)0x8a0a),
            ValidateStatus = ((int)0x8b83),
            Texture31Arb = ((int)0x84df),
            ClampToBorder = ((int)0x812d),
            DepthClampNv = ((int)0x864f),
            R11fG11fB10fExt = ((int)0x8c3a),
            PointSizeMin = ((int)0x8126),
            AccumBufferBit = ((int)0x00000200),
            Texture15Arb = ((int)0x84cf),
            VertexProgramNv = ((int)0x8620),
            PreserveAti = ((int)0x8762),
            UnsignedIntSamplerBufferExt = ((int)0x8dd8),
            MaxElementsIndices = ((int)0x80e9),
            DotProductConstEyeReflectCubeMapNv = ((int)0x86f3),
            VertexProgramTwoSideArb = ((int)0x8643),
            QuadIntensity4Sgis = ((int)0x8122),
                SampleMaskValueExt = ((int)0x80aa),
            ImageMinFilterHp = ((int)0x815d),
            Con14Ati = ((int)0x894f),
            Texcoord2BitPgi = ((int)0x20000000),
            LuminanceAlphaIntegerExt = ((int)0x8d9d),
            PixelTileCacheSizeSgix = ((int)0x8145),
            CurrentVertexWeightExt = ((int)0x850b),
            Sampler1dArrayExt = ((int)0x8dc0),
            Rgba16uiExt = ((int)0x8d76),
            BlueMaxClampIngr = ((int)0x8566),
            AutoNormal = ((int)0x0d80),
            Gl422Ext = ((int)0x80cc),
            OffsetHiloTextureRectangleNv = ((int)0x8855),
            CompressedLuminanceAlphaArb = ((int)0x84eb),
            ColorTable = ((int)0x80d0),
            Texture2d = ((int)0x0de1),
            TextFragmentShaderAti = ((int)0x8200),
            ElementArrayBufferBinding = ((int)0x8895),
            CompressedRgbArb = ((int)0x84ed),
            RedMaxClampIngr = ((int)0x8564),
            Modulate = ((int)0x2100),
            Texcoord4BitPgi = unchecked((int)0x80000000),
            QueryResultAvailableArb = ((int)0x8867),
            ScalarExt = ((int)0x87be),
            TextureCoordArrayType = ((int)0x8089),
            DsdtMagVibNv = ((int)0x86f7),
            BlendSrcRgbExt = ((int)0x80c9),
            Right = ((int)0x0407),
            MaxAsyncDrawPixelsSgix = ((int)0x8360),
            Con1Ati = ((int)0x8942),
            OffsetTextureBiasNv = ((int)0x86e3),
            ObjectLineSgis = ((int)0x81f7),
            ActiveTextureArb = ((int)0x84e0),
            SampleAlphaToOneSgis = ((int)0x809f),
            Separable2d = ((int)0x8012),
            DrawBuffer15Ati = ((int)0x8834),
            MaxCubeMapTextureSizeArb = ((int)0x851c),
            UnsignedInt1010102 = ((int)0x8036),
            UnpackConstantDataSunx = ((int)0x81d5),
            Rgba4Ext = ((int)0x8056),
            UnpackClientStorageApple = ((int)0x85b2),
            FloatMat2Arb = ((int)0x8b5a),
            Alpha16Ext = ((int)0x803e),
            DrawBuffer11 = ((int)0x8830),
            CurrentIndex = ((int)0x0b01),
            Texture2dArrayExt = ((int)0x8c1a),
            TransposeModelviewMatrix = ((int)0x84e3),
            StencilClearValue = ((int)0x0b91),
            Map2VertexAttrib44Nv = ((int)0x8674),
            TransformFeedbackRecordNv = ((int)0x8c86),
            BlueBias = ((int)0x0d1b),
            MirroredRepeatArb = ((int)0x8370),
            ColorArray = ((int)0x8076),
            AlphaTest = ((int)0x0bc0),
            Multisample3dfx = ((int)0x86b2),
            ActiveVertexUnitsArb = ((int)0x86a5),
            AliasedPointSizeRange = ((int)0x846d),
            DrawBuffer13Ati = ((int)0x8832),
            Double = ((int)0x140a),
            FogColor = ((int)0x0b66),
            FramezoomFactorSgix = ((int)0x818c),
            Texture24 = ((int)0x84d8),
            Texture25 = ((int)0x84d9),
            Texture22 = ((int)0x84d6),
                ProgramAluInstructionsArb = ((int)0x8805),
            Texture21 = ((int)0x84d5),
            RgbFloat16Ati = ((int)0x881b),
            MaxProgramParameters = ((int)0x88a9),
            T2fIuiN3fV3fExt = ((int)0x81b4),
            T2fC4fN3fV3f = ((int)0x2a2c),
            R1uiT2fN3fV3fSun = ((int)0x85ca),
            Texture28 = ((int)0x84dc),
            Texture29 = ((int)0x84dd),
            SignedIntensityNv = ((int)0x8707),
                Con10Ati = ((int)0x894b),
            Specular = ((int)0x1202),
            Map1Color4 = ((int)0x0d90),
            Src0Alpha = ((int)0x8588),
            IndexLogicOp = ((int)0x0bf1),
            BinormalArrayStrideExt = ((int)0x8441),
            NormalArrayPointer = ((int)0x808f),
            CompressedSluminance = ((int)0x8c4a),
            MagnitudeScaleNv = ((int)0x8712),
            AddSignedArb = ((int)0x8574),
            BufferUsageArb = ((int)0x8765),
                Sampler2d = ((int)0x8b5e),
            TextureTooLargeExt = ((int)0x8065),
            VertexAttribArray5Nv = ((int)0x8655),
            SignedLuminanceAlphaNv = ((int)0x8703),
            MaxOptimizedVertexShaderInvariantsExt = ((int)0x87cd),
            CurrentQueryArb = ((int)0x8865),
            TransformFeedbackAttribsNv = ((int)0x8c7e),
            PixelMapRToRSize = ((int)0x0cb6),
                MaxProgramIfDepthNv = ((int)0x88f6),
            UnsignedShort565 = ((int)0x8363),
            MultisampleBit = ((int)0x20000000),
            LogicOpMode = ((int)0x0bf0),
            Extensions = ((int)0x1f03),
            CompressedSrgbExt = ((int)0x8c48),
            StencilBackFuncAti = ((int)0x8800),
            AliasedLineWidthRange = ((int)0x846e),
            DudvAti = ((int)0x8779),
            DepthComponent32 = ((int)0x81a7),
            MaxProgramMatrixStackDepthArb = ((int)0x862e),
            Operand1AlphaExt = ((int)0x8599),
            PixelTexGenAlphaLsSgix = ((int)0x8189),
            PixelCountNv = ((int)0x8866),
            EvalVertexAttrib10Nv = ((int)0x86d0),
            StencilWritemask = ((int)0x0b98),
            RasterPositionUnclippedIbm = ((int)0x19262),
            HiBiasNv = ((int)0x8714),
            Dot3Ati = ((int)0x8966),
            TextureMaxClampSSgix = ((int)0x8369),
            CompressedSignedLuminanceAlphaLatc2Ext = ((int)0x8c73),
            Invert = ((int)0x150a),
            Luminance4Alpha4 = ((int)0x8043),
            Map1VertexAttrib144Nv = ((int)0x866e),
            MatShininessBitPgi = ((int)0x02000000),
            AttachedShaders = ((int)0x8b85),
            T2fIuiV2fExt = ((int)0x81b1),
            Spare0Nv = ((int)0x852e),
            PixelUnpackBufferExt = ((int)0x88ec),
            VertexAttribArray6Nv = ((int)0x8656),
            Map2GridSegments = ((int)0x0dd3),
            Matrix4 = ((int)0x88c4),
            CurrentMatrixNv = ((int)0x8641),
            DepthTextureModeArb = ((int)0x884b),
            Rgba16fArb = ((int)0x881a),
            FogCoordArrayType = ((int)0x8454),
            Decal = ((int)0x2101),
            FramebufferSrgbCapableExt = ((int)0x8dba),
            MirrorClampToEdgeExt = ((int)0x8743),
            WritePixelDataRangeLengthNv = ((int)0x887a),
            IntensityExt = ((int)0x8049),
            HistogramGreenSize = ((int)0x8029),
            DepthBias = ((int)0x0d1f),
            PixelMapIToRSize = ((int)0x0cb2),
            MaxVaryingFloats = ((int)0x8b4b),
            HintBit = ((int)0x00008000),
            TextureLuminanceSizeExt = ((int)0x8060),
            PixelModeBit = ((int)0x00000020),
            CombinerSumOutputNv = ((int)0x854c),
                TextureFilterControlExt = ((int)0x8500),
            PolygonMode = ((int)0x0b40),
            LinearAttenuation = ((int)0x1208),
            FloatMat4x2 = ((int)0x8b69),
            CompressedSrgbAlpha = ((int)0x8c49),
            ColorClearValue = ((int)0x0c22),
            MvpMatrixExt = ((int)0x87e3),
            MaxProgramGenericAttribsNv = ((int)0x8da5),
            OpSubExt = ((int)0x8796),
            Alpha32iExt = ((int)0x8d84),
            FragmentLightingSgix = ((int)0x8400),
            ProgramParameterNv = ((int)0x8644),
                MinProgramTexelOffsetNv = ((int)0x8904),
            MaxTransformFeedbackSeparateComponentsNv = ((int)0x8c80),
            TextureCubeMapPositiveXExt = ((int)0x8515),
            LineStipple = ((int)0x0b24),
            VertexWeightArrayStrideExt = ((int)0x850f),
            PolygonStipple = ((int)0x0b42),
            ImplementationColorReadFormatOes = ((int)0x8b9b),
            Bgr = ((int)0x80e0),
            Modelview25Arb = ((int)0x8739),
            CombinerInputNv = ((int)0x8542),
            Modelview21Arb = ((int)0x8735),
            InverseNv = ((int)0x862b),
            OutputTextureCoord25Ext = ((int)0x87b6),
            TextureCoordArrayListStrideIbm = ((int)103084),
            PixelTileWidthSgix = ((int)0x8140),
            Reg24Ati = ((int)0x8939),
            NumPassesAti = ((int)0x8970),
            FogCoordinateSourceExt = ((int)0x8450),
            InterpolateExt = ((int)0x8575),
            OutputTextureCoord7Ext = ((int)0x87a4),
            Reg5Ati = ((int)0x8926),
            FogCoordArrayPointer = ((int)0x8456),
            FogCoordinateArrayPointerExt = ((int)0x8456),
            ColorTableAlphaSize = ((int)0x80dd),
            OffsetTextureRectangleNv = ((int)0x864c),
            QueryResult = ((int)0x8866),
                EvalVertexAttrib12Nv = ((int)0x86d2),
            ClientPixelStoreBit = ((int)0x00000001),
            YcrcbaSgix = ((int)0x8319),
            PixelGroupColorSgis = ((int)0x8356),
            Diffuse = ((int)0x1201),
            LineResetToken = ((int)0x0707),
            MaxProgramTexIndirectionsArb = ((int)0x880d),
                Reg25Ati = ((int)0x893a),
            Dot2AddAti = ((int)0x896c),
            ListMode = ((int)0x0b30),
            ColorClearUnclampedValueAti = ((int)0x8835),
            UnsignedByte233Rev = ((int)0x8362),
            ProgramFormatAsciiArb = ((int)0x8875),
            AsyncHistogramSgix = ((int)0x832c),
            TextureUnsignedRemapModeNv = ((int)0x888f),
            Sampler3d = ((int)0x8b5f),
            Copy = ((int)0x1503),
            ReplacementCodeArraySun = ((int)0x85c0),
            Modelview23Arb = ((int)0x8737),
            IndexArray = ((int)0x8077),
            DsScaleNv = ((int)0x8710),
            FloatRgba32Nv = ((int)0x888b),
            ElementArrayPointerApple = ((int)0x876a),
            SphereMap = ((int)0x2402),
            Map2Index = ((int)0x0db1),
                DualAlpha16Sgis = ((int)0x8113),
            Rgb10A2Ext = ((int)0x8059),
            InterlaceOml = ((int)0x8980),
            EdgeFlag = ((int)0x0b43),
            MaxModelviewStackDepth = ((int)0x0d36),
            FogScaleSgix = ((int)0x81fc),
            DualAlpha8Sgis = ((int)0x8111),
                Rgba = ((int)0x1908),
            PerturbExt = ((int)0x85ae),
            FrontAndBack = ((int)0x0408),
            Modelview20Arb = ((int)0x8734),
            LineWidthGranularity = ((int)0x0b23),
            SamplesSgis = ((int)0x80a9),
            Con18Ati = ((int)0x8953),
            TextureBinding1dArrayExt = ((int)0x8c1c),
                StencilFail = ((int)0x0b94),
            CurrentMatrixArb = ((int)0x8641),
            Reg27Ati = ((int)0x893c),
            ObjectBufferSizeAti = ((int)0x8764),
            OpSetGeExt = ((int)0x878c),
            FragmentLight7Sgix = ((int)0x8413),
            PrimaryColorArb = ((int)0x8577),
            ReadBuffer = ((int)0x0c02),
            MaxProgramTemporaries = ((int)0x88a5),
            ActiveUniforms = ((int)0x8b86),
            Dsdt8Mag8Nv = ((int)0x870a),
            Reduce = ((int)0x8016),
            AlphaMinSgix = ((int)0x8320),
            SampleBuffersExt = ((int)0x80a8),
            TextureCubeMapNegativeYExt = ((int)0x8518),
            Modelview29Arb = ((int)0x873d),
            Map1VertexAttrib94Nv = ((int)0x8669),
            Reg20Ati = ((int)0x8935),
            Color = ((int)0x1800),
            ColorArrayTypeExt = ((int)0x8082),
            PixelTexGenQCeilingSgix = ((int)0x8184),
            Con0Ati = ((int)0x8941),
            DualAlpha4Sgis = ((int)0x8110),
            TextureRectangleArb = ((int)0x84f5),
            Luminance16IccSgix = ((int)0x8469),
            IncrWrap = ((int)0x8507),
            TextureStackDepth = ((int)0x0ba5),
            LuminanceAlpha16iExt = ((int)0x8d8d),
            ObjectActiveAttributeMaxLengthArb = ((int)0x8b8a),
            MirrorClampToEdgeAti = ((int)0x8743),
            DepthStencilExt = ((int)0x84f9),
            AlphaIccSgix = ((int)0x8462),
            Alpha32fArb = ((int)0x8816),
            DstAlpha = ((int)0x0304),
            Lines = ((int)0x0001),
            LogicOp = ((int)0x0bf1),
            Reg21Ati = ((int)0x8936),
            OffsetTexture2dScaleNv = ((int)0x86e2),
            ConvolutionBorderMode = ((int)0x8013),
            IntVec3Arb = ((int)0x8b54),
            CullFragmentNv = ((int)0x86e7),
            RegisterCombinersNv = ((int)0x8522),
            Texture1 = ((int)0x84c1),
            VertexAttribArray1Nv = ((int)0x8651),
            Matrix14 = ((int)0x88ce),
                FullRangeExt = ((int)0x87e1),
            Modelview27Arb = ((int)0x873b),
            ColorAttachment7Ext = ((int)0x8ce7),
            UnsignedInt8888 = ((int)0x8035),
            DotProductTextureRectangleNv = ((int)0x864e),
            Shininess = ((int)0x1601),
            PixelMapGToGSize = ((int)0x0cb7),
            RenderbufferInternalFormatExt = ((int)0x8d44),
            MaxVertexUniformComponents = ((int)0x8b4a),
            ColorTableFormat = ((int)0x80d8),
            ProgramString = ((int)0x8628),
            ObjectTypeArb = ((int)0x8b4e),
            FramebufferAttachmentTexture3dZoffsetExt = ((int)0x8cd4),
            EdgeFlagArrayExt = ((int)0x8079),
            PointSizeMax = ((int)0x8127),
            PostConvolutionBlueScale = ((int)0x801e),
            ElementArrayPointerAti = ((int)0x876a),
            PixelMapIToI = ((int)0x0c70),
            R1uiV3fSun = ((int)0x85c4),
            ColorIndex4Ext = ((int)0x80e4),
            CompressedRedRgtc1Ext = ((int)0x8dbb),
            SampleMaskInvertSgis = ((int)0x80ab),
                CompressedSrgbS3tcDxt1Ext = ((int)0x8c4c),
            CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8c4d),
            Modelview24Arb = ((int)0x8738),
            RgbIntegerExt = ((int)0x8d98),
            Map1VertexAttrib84Nv = ((int)0x8668),
            Reg23Ati = ((int)0x8938),
            PixelSubsample2424Sgix = ((int)0x85a3),
                Operand1Rgb = ((int)0x8591),
            NormalBitPgi = ((int)0x08000000),
            BlendEquationAlphaExt = ((int)0x883d),
            EnableBit = ((int)0x00002000),
            StrictDepthfuncHintPgi = ((int)0x1a216),
            UnpackResampleSgix = ((int)0x842d),
            MaxFragmentBindableUniformsExt = ((int)0x8de3),
            ConserveMemoryHintPgi = ((int)0x1a1fd),
            ReflectionMapExt = ((int)0x8512),
            FogDistanceModeNv = ((int)0x855a),
            TextureSharedSizeExt = ((int)0x8c3f),
            VertexAttribArrayIntegerNv = ((int)0x88fd),
            StorageSharedApple = ((int)0x85bf),
            PixelMapIToASize = ((int)0x0cb5),
            TextureLoSizeNv = ((int)0x871c),
            ReferencePlaneSgix = ((int)0x817d),
            ProxyTextureRectangleArb = ((int)0x84f7),
            PixelMinFilterExt = ((int)0x8332),
            CompareRefDepthToTextureExt = ((int)0x884e),
            CubicHp = ((int)0x815f),
            Intensity16fArb = ((int)0x881d),
            SrcColor = ((int)0x0300),
            TextureCoordArray = ((int)0x8078),
            TextureCoordArrayCountExt = ((int)0x808b),
            GreenBias = ((int)0x0d19),
            OutputTextureCoord27Ext = ((int)0x87b8),
                Luminance16uiExt = ((int)0x8d7a),
            Rgb16uiExt = ((int)0x8d77),
            CurrentRasterColor = ((int)0x0b04),
            IntensityFloat32Ati = ((int)0x8817),
            MatEmissionBitPgi = ((int)0x00800000),
            DrawBuffer6 = ((int)0x882b),
            ImageCubicWeightHp = ((int)0x815e),
            MaxMultisampleCoverageModesNv = ((int)0x8e11),
            LineStippleRepeat = ((int)0x0b26),
            Texture2dBindingExt = ((int)0x8069),
            RedBits = ((int)0x0d52),
            VertexWeightArrayTypeExt = ((int)0x850e),
            UnpackSkipRows = ((int)0x0cf3),
            SeparateAttribsNv = ((int)0x8c8d),
            BlueScale = ((int)0x0d1a),
            ImageRotateAngleHp = ((int)0x8159),
            MaxDrawBuffersAti = ((int)0x8824),
            ObjectDistanceToPointSgis = ((int)0x81f1),
            IuiV2fExt = ((int)0x81ad),
            TransformFeedbackPrimitivesWrittenNv = ((int)0x8c88),
            Src1Rgb = ((int)0x8581),
            SamplesPassedArb = ((int)0x8914),
            Alpha16 = ((int)0x803e),
            PolygonOffsetBiasExt = ((int)0x8039),
            OffsetTextureMatrixNv = ((int)0x86e1),
            IndexArrayBufferBinding = ((int)0x8899),
            EyeLineSgis = ((int)0x81f6),
            IndexMode = ((int)0x0c30),
            Gl3Bytes = ((int)0x1408),
            RenderbufferRedSizeExt = ((int)0x8d50),
            OpNegateExt = ((int)0x8783),
            SecondaryColorArrayPointer = ((int)0x845d),
            Reg30Ati = ((int)0x893f),
            TextureCoordArrayPointerExt = ((int)0x8092),
            FloatRgba16Nv = ((int)0x888a),
            UnsignedInt88S8S8RevNv = ((int)0x86db),
            BlendSrcAlphaExt = ((int)0x80cb),
            UnsignedByte332 = ((int)0x8032),
            CullVertexExt = ((int)0x81aa),
            ProgramAddressRegisters = ((int)0x88b0),
            VertexArrayRangeLengthApple = ((int)0x851e),
            IndexClearValue = ((int)0x0c20),
            ProxyTextureCubeMapExt = ((int)0x851b),
            Accum = ((int)0x0100),
            TextureMaterialParameterExt = ((int)0x8352),
            CurrentPaletteMatrixArb = ((int)0x8843),
            GeometryProgramParameterBufferNv = ((int)0x8da3),
            WeightArraySizeArb = ((int)0x86ab),
            Matrix22 = ((int)0x88d6),
            PostColorMatrixAlphaScale = ((int)0x80b7),
            LinearSharpenSgis = ((int)0x80ad),
            Source1RgbExt = ((int)0x8581),
            Texture0 = ((int)0x84c0),
            BufferUsage = ((int)0x8765),
            SubAti = ((int)0x8965),
            Interpolate = ((int)0x8575),
            Rgb8uiExt = ((int)0x8d7d),
            EighthBitAti = ((int)0x00000020),
            EvalBit = ((int)0x00010000),
            TextureCompareFailValueArb = ((int)0x80bf),
            ShaderObjectArb = ((int)0x8b48),
            ColorAlphaPairingAti = ((int)0x8975),
            MultisampleBit3dfx = ((int)0x20000000),
            CombineRgb = ((int)0x8571),
            TransformFeedbackVaryingsNv = ((int)0x8c83),
            Light3 = ((int)0x4003),
            TextureHeight = ((int)0x1001),
            Operand0Rgb = ((int)0x8590),
            ColorAttachment3Ext = ((int)0x8ce3),
            ElementArrayAti = ((int)0x8768),
            ProgramTargetNv = ((int)0x8646),
            FramebufferIncompleteLayerTargetsExt = ((int)0x8da8),
            ImageScaleXHp = ((int)0x8155),
            TextureAlphaTypeArb = ((int)0x8c13),
            Feedback = ((int)0x1c01),
            PolygonOffsetLine = ((int)0x2a02),
            R = ((int)0x2002),
            S = ((int)0x2000),
            Intensity16 = ((int)0x804d),
            Q = ((int)0x2003),
            TextureAlphaSize = ((int)0x805f),
            T = ((int)0x2001),
            PixelTileGridHeightSgix = ((int)0x8143),
            CurrentSecondaryColorExt = ((int)0x8459),
            NearestClipmapLinearSgix = ((int)0x844e),
            TextureCoordArrayParallelPointersIntel = ((int)0x83f8),
            FragmentProgram = ((int)0x8804),
            SecondaryColorArrayTypeExt = ((int)0x845b),
            PixelPackBufferExt = ((int)0x88eb),
            DotProductTexture2dNv = ((int)0x86ee),
            Gl3dColor = ((int)0x0602),
            DrawBuffer10Ati = ((int)0x882f),
            Map1VertexAttrib34Nv = ((int)0x8663),
            ColorTableScale = ((int)0x80d6),
            Cw = ((int)0x0900),
                LinearClipmapNearestSgix = ((int)0x844f),
            FrontLeft = ((int)0x0400),
            NumFragmentConstantsAti = ((int)0x896f),
            FragmentLightModelLocalViewerSgix = ((int)0x8408),
            DtScaleNv = ((int)0x8711),
            DotProductReflectCubeMapNv = ((int)0x86f2),
            Ycbcr422Apple = ((int)0x85b9),
            EdgeFlagArrayBufferBindingArb = ((int)0x889b),
            FloatMat3Arb = ((int)0x8b5b),
            ProgramErrorPositionNv = ((int)0x864b),
            ColorTableWidth = ((int)0x80d9),
            ProxyTexture1dArrayExt = ((int)0x8c19),
            Luminance8iExt = ((int)0x8d92),
            MaxAttribStackDepth = ((int)0x0d35),
            MaxProgramGenericResultsNv = ((int)0x8da6),
            Texture27Arb = ((int)0x84db),
            ReadFramebufferBindingExt = ((int)0x8ca6),
            Zero = ((int)0),
            TextureRectangleNv = ((int)0x84f5),
            Rgb16fArb = ((int)0x881b),
            TangentArrayTypeExt = ((int)0x843e),
            BlendEquationAlpha = ((int)0x883d),
            OutputColor0Ext = ((int)0x879b),
            MaxTrackMatricesNv = ((int)0x862f),
            HistogramAlphaSize = ((int)0x802b),
            LuminanceAlpha = ((int)0x190a),
            ColorArrayExt = ((int)0x8076),
            Cnd0Ati = ((int)0x896b),
            Map1VertexAttrib54Nv = ((int)0x8665),
            TrackMatrixNv = ((int)0x8648),
            Texture8 = ((int)0x84c8),
            MaxTextureCoordsArb = ((int)0x8871),
            AlphaFloat32Ati = ((int)0x8816),
            CombinerAbOutputNv = ((int)0x854a),
            Multisample = ((int)0x809d),
            ColorAttachment6Ext = ((int)0x8ce6),
            ClipFarHintPgi = ((int)0x1a221),
            Texture1dBindingExt = ((int)0x8068),
            InverseTransposeNv = ((int)0x862d),
            TextureRedSize = ((int)0x805c),
            PixelTexGenQFloorSgix = ((int)0x8186),
            OutputTextureCoord12Ext = ((int)0x87a9),
            Reg17Ati = ((int)0x8932),
            SecondaryColorArraySize = ((int)0x845a),
            Modelview1MatrixExt = ((int)0x8506),
            YcrcbSgix = ((int)0x8318),
            WeightArrayStrideArb = ((int)0x86aa),
            DrawBuffer14Arb = ((int)0x8833),
                    VertexArrayBufferBinding = ((int)0x8896),
            ColorIndex2Ext = ((int)0x80e3),
            MaxFramezoomFactorSgix = ((int)0x818d),
            AccumGreenBits = ((int)0x0d59),
            MaxClipmapDepthSgix = ((int)0x8177),
            VibranceScaleNv = ((int)0x8713),
            Map1TextureCoord4 = ((int)0x0d96),
            Map1TextureCoord2 = ((int)0x0d94),
            Map1TextureCoord3 = ((int)0x0d95),
            EdgeflagBitPgi = ((int)0x00040000),
            ConvolutionWidth = ((int)0x8018),
            PixelTransform2dExt = ((int)0x8330),
            Modelview17Arb = ((int)0x8731),
            MaxVaryingComponentsExt = ((int)0x8b4b),
            Intensity8iExt = ((int)0x8d91),
            CompileStatus = ((int)0x8b81),
            CullFace = ((int)0x0b44),
            MaxClipmapVirtualDepthSgix = ((int)0x8178),
                LightingBit = ((int)0x00000040),
            ColorIndex1Ext = ((int)0x80e2),
            ProgramFormat = ((int)0x8876),
            ClipPlane0 = ((int)0x3000),
            InvalidFramebufferOperationExt = ((int)0x0506),
            Texture20Arb = ((int)0x84d4),
                MaxPnTrianglesTesselationLevelAti = ((int)0x87f1),
            Reg29Ati = ((int)0x893e),
            PostConvolutionAlphaScale = ((int)0x801f),
            Modelview22Arb = ((int)0x8736),
            MaxClientAttribStackDepth = ((int)0x0d3b),
            ElementArrayApple = ((int)0x8768),
            BlendEquation = ((int)0x8009),
            ProgramUnderNativeLimits = ((int)0x88b6),
            MaxVertexShaderInstructionsExt = ((int)0x87c5),
            SignedLuminanceNv = ((int)0x8701),
            Reg6Ati = ((int)0x8927),
            Light2 = ((int)0x4002),
            AsyncDrawPixelsSgix = ((int)0x835d),
            MirrorClampAti = ((int)0x8742),
                ClipDistanceNv = ((int)0x8c7a),
            CompressedRgbaFxt13dfx = ((int)0x86b1),
            GenerateMipmap = ((int)0x8191),
            MaxProgramMatricesArb = ((int)0x862f),
            OffsetTextureRectangleScaleNv = ((int)0x864d),
            Reg9Ati = ((int)0x892a),
            Vendor = ((int)0x1f00),
            FrontRight = ((int)0x0401),
                ArrayObjectOffsetAti = ((int)0x8767),
            TextureMagSizeNv = ((int)0x871f),
            HalfBiasNormalNv = ((int)0x853a),
            ReplicateBorder = ((int)0x8153),
            PostTextureFilterScaleRangeSgix = ((int)0x817c),
            EvalVertexAttrib15Nv = ((int)0x86d5),
            Alpha16IccSgix = ((int)0x8468),
            MaxProgramLoopCountNv = ((int)0x88f8),
            ConstEyeNv = ((int)0x86e5),
            Matrix21 = ((int)0x88d5),
            StaticReadArb = ((int)0x88e5),
            Texture14Arb = ((int)0x84ce),
            Matrix11 = ((int)0x88cb),
            Luminance32fArb = ((int)0x8818),
            Vertex4BitPgi = ((int)0x00000008),
            AllCompletedNv = ((int)0x84f2),
            Three = ((int)3),
            MaxSamplesExt = ((int)0x8d57),
            FenceConditionNv = ((int)0x84f4),
            Texture22Arb = ((int)0x84d6),
            ColorArrayStrideExt = ((int)0x8083),
            Texture1dArrayExt = ((int)0x8c18),
            DrawBuffer4Ati = ((int)0x8829),
            MaxTextureBufferSizeExt = ((int)0x8c2b),
                StencilBackFail = ((int)0x8801),
            ColorSumClampNv = ((int)0x854f),
            Blend = ((int)0x0be2),
            PerStageConstantsNv = ((int)0x8535),
            Set = ((int)0x150f),
            IndexArrayExt = ((int)0x8077),
            DrawBuffer = ((int)0x0c01),
            ColorArrayBufferBindingArb = ((int)0x8898),
            Texture17Arb = ((int)0x84d1),
            Hilo8Nv = ((int)0x885e),
            PixelTransform2dStackDepthExt = ((int)0x8336),
                Red = ((int)0x1903),
            LinearDetailAlphaSgis = ((int)0x8098),
            ConstantColor = ((int)0x8001),
            DepthStencilToBgraNv = ((int)0x886f),
            FogCoordArray = ((int)0x8457),
            Clamp = ((int)0x2900),
                DotProductTextureCubeMapNv = ((int)0x86f0),
            MultisampleCoverageModesNv = ((int)0x8e12),
            ConstantColor1Nv = ((int)0x852b),
            CompressedRgbaS3tcDxt3Ext = ((int)0x83f2),
            Intensity12Ext = ((int)0x804c),
            Sluminance8Ext = ((int)0x8c47),
            Reg2Ati = ((int)0x8923),
            Texture16Arb = ((int)0x84d0),
            VertexArraySize = ((int)0x807a),
            PointSpriteCoordOrigin = ((int)0x8ca0),
            Rgba16 = ((int)0x805b),
            DepthBoundsTestExt = ((int)0x8890),
                FogFactorToAlphaSgix = ((int)0x836f),
            CompressedSignedRedGreenRgtc2Ext = ((int)0x8dbe),
                CombinerBiasNv = ((int)0x8549),
            InvariantExt = ((int)0x87c2),
            ReadPixelDataRangeLengthNv = ((int)0x887b),
            FramebufferUnsupportedExt = ((int)0x8cdd),
            Modelview4Arb = ((int)0x8724),
            IntSamplerBufferExt = ((int)0x8dd0),
            Texture11Arb = ((int)0x84cb),
            Decr = ((int)0x1e03),
            Texture21Arb = ((int)0x84d5),
            ListBase = ((int)0x0b32),
            MaxListNesting = ((int)0x0b31),
            RgbaUnsignedDotProductMappingNv = ((int)0x86d9),
            Linear = ((int)0x2601),
            ConstantAlpha = ((int)0x8003),
            Source1RgbArb = ((int)0x8581),
            ReclaimMemoryHintPgi = ((int)0x1a1fe),
            SecondaryColorArrayBufferBinding = ((int)0x889c),
            ProgramErrorStringNv = ((int)0x8874),
            ProxyColorTable = ((int)0x80d3),
            R1uiT2fV3fSun = ((int)0x85c9),
            TextureWrapR = ((int)0x8072),
                RgbaIntegerExt = ((int)0x8d99),
            RenderbufferDepthSizeExt = ((int)0x8d54),
            Texture10Arb = ((int)0x84ca),
            WritePixelDataRangePointerNv = ((int)0x887c),
            Keep = ((int)0x1e00),
            DotProductNv = ((int)0x86ec),
            AttribStackDepth = ((int)0x0bb0),
            FogCoordinateArrayExt = ((int)0x8457),
            Reg7Ati = ((int)0x8928),
            Combiner2Nv = ((int)0x8552),
            MaxProgramResultComponentsNv = ((int)0x8909),
            ReadPixelDataRangeNv = ((int)0x8879),
            CombineAlphaArb = ((int)0x8572),
            ReplaceOldestSun = ((int)0x0003),
                LineWidthRange = ((int)0x0b22),
            BufferMapPointerArb = ((int)0x88bd),
            TextureCompareSgix = ((int)0x819a),
            LoBiasNv = ((int)0x8715),
            AsyncMarkerSgix = ((int)0x8329),
            OffsetProjectiveTexture2dNv = ((int)0x8850),
            FramezoomSgix = ((int)0x818b),
            PnTrianglesNormalModeLinearAti = ((int)0x87f7),
            MaxElementsIndicesExt = ((int)0x80e9),
            FramebufferAttachmentTextureCubeMapFaceExt = ((int)0x8cd3),
            FixedOnlyArb = ((int)0x891d),
            Light1 = ((int)0x4001),
            Fill = ((int)0x1b02),
            Subtract = ((int)0x84e7),
            LineSmooth = ((int)0x0b20),
            Rgb32uiExt = ((int)0x8d71),
            Modelview28Arb = ((int)0x873c),
            DrawBuffer3Ati = ((int)0x8828),
            SamplePatternSgis = ((int)0x80ac),
            Texture29Arb = ((int)0x84dd),
            TransposeColorMatrixArb = ((int)0x84e6),
            WeightArrayPointerArb = ((int)0x86ac),
            VertexShaderArb = ((int)0x8b31),
            FogSpecularTextureWin = ((int)0x80ec),
            OffsetProjectiveTextureRectangleScaleNv = ((int)0x8853),
            UnsignedShort5551 = ((int)0x8034),
            Intensity16Ext = ((int)0x804d),
            Quads = ((int)0x0007),
            WritePixelDataRangeNv = ((int)0x8878),
            ObjectShaderSourceLengthArb = ((int)0x8b88),
            ColorAttachment2Ext = ((int)0x8ce2),
            IndexArrayPointerExt = ((int)0x8091),
            VariantValueExt = ((int)0x87e4),
            Matrix10 = ((int)0x88ca),
            OpClampExt = ((int)0x878e),
            TriangleStrip = ((int)0x0005),
                LinearMipmapLinear = ((int)0x2703),
            IndexArrayBufferBindingArb = ((int)0x8899),
            CompressedSignedLuminanceLatc1Ext = ((int)0x8c71),
            ArrayBufferBindingArb = ((int)0x8894),
            LuminanceAlphaFloat16Ati = ((int)0x881f),
            Texture28Arb = ((int)0x84dc),
            BlendDstRgbExt = ((int)0x80c8),
            MaxOptimizedVertexShaderInstructionsExt = ((int)0x87ca),
            HalfFloat = ((int)0x140b),
            DepthRange = ((int)0x0b70),
            NumFragmentRegistersAti = ((int)0x896e),
            Order = ((int)0x0a01),
            TimeElapsedExt = ((int)0x88bf),
            ReflectionMapArb = ((int)0x8512),
            UnpackImageHeight = ((int)0x806e),
            SignedRgbNv = ((int)0x86fe),
            Matrix2Nv = ((int)0x8632),
            GeometryOutputTypeExt = ((int)0x8ddc),
            FeedbackBufferPointer = ((int)0x0df0),
            CompressedSluminanceAlphaExt = ((int)0x8c4b),
            Xor = ((int)0x1506),
            MaxBindableUniformSizeExt = ((int)0x8ded),
            AlphaMinClampIngr = ((int)0x8563),
                TextureDtSizeNv = ((int)0x871e),
            TextureBinding2dArrayExt = ((int)0x8c1d),
            ReadPixelDataRangePointerNv = ((int)0x887d),
            Modelview26Arb = ((int)0x873a),
            ClipPlane1 = ((int)0x3001),
            PixelMapAToA = ((int)0x0c79),
            Texture0Arb = ((int)0x84c0),
            SecondaryColorArrayExt = ((int)0x845e),
            BlueBitAti = ((int)0x00000004),
            TextureLodBiasTSgix = ((int)0x818f),
            TextureDepthSize = ((int)0x884a),
            ColorAttachment5Ext = ((int)0x8ce5),
            NormalArrayCountExt = ((int)0x8080),
            HistogramRedSize = ((int)0x8028),
            TextureCubeMapExt = ((int)0x8513),
            PackImageDepthSgis = ((int)0x8131),
            AttenuationExt = ((int)0x834d),
            NormalMap = ((int)0x8511),
            VertexShaderVariantsExt = ((int)0x87d0),
            RestartSun = ((int)0x0001),
            VertexArrayPointerExt = ((int)0x808e),
            ColorTableRedSize = ((int)0x80da),
            TransformFeedbackBufferBindingNv = ((int)0x8c8f),
            Luminance16Ext = ((int)0x8042),
            PixelTexGenAlphaMsSgix = ((int)0x818a),
            FragmentShaderArb = ((int)0x8b30),
            DepthComponent = ((int)0x1902),
            IndexArrayTypeExt = ((int)0x8085),
            VertexArraySizeExt = ((int)0x807a),
            ModelviewProjectionNv = ((int)0x8629),
            GlobalAlphaFactorSun = ((int)0x81da),
            Matrix16 = ((int)0x88d0),
            VertexWeightArrayExt = ((int)0x850c),
            Sampler2dRectShadowArb = ((int)0x8b64),
            TextureLodBiasExt = ((int)0x8501),
            Flat = ((int)0x1d00),
            SrcAlpha = ((int)0x0302),
            ProgramPointSizeExt = ((int)0x8642),
            R1uiC3fV3fSun = ((int)0x85c6),
            Never = ((int)0x0200),
            True = ((int)1),
            UnsignedShort4444Reversed = ((int)0x8365),
            Reg18Ati = ((int)0x8933),
            VertexArrayRangeValidNv = ((int)0x851f),
            Return = ((int)0x0102),
                MaxProgramLoopDepthNv = ((int)0x88f7),
            FogMode = ((int)0x0b65),
            PolygonBit = ((int)0x00000008),
            Incr = ((int)0x1e02),
            ClipNearHintPgi = ((int)0x1a220),
            PassThroughToken = ((int)0x0700),
            Sampler2dArb = ((int)0x8b5e),
            AbgrExt = ((int)0x8000),
            EvalFractionalTessellationNv = ((int)0x86c5),
            TextureGreenSizeExt = ((int)0x805d),
            MaxProgramAttribComponentsNv = ((int)0x8908),
            MaxVertexShaderVariantsExt = ((int)0x87c6),
            CompressedLuminance = ((int)0x84ea),
            PackSubsampleRateSgix = ((int)0x85a0),
            SecondaryColorArrayType = ((int)0x845b),
            Map2VertexAttrib114Nv = ((int)0x867b),
            Bool = ((int)0x8b56),
            TextureCompressionHintArb = ((int)0x84ef),
            Dot4Ati = ((int)0x8967),
            DualIntensity4Sgis = ((int)0x8118),
            ConvolutionHeight = ((int)0x8019),
            LowerLeft = ((int)0x8ca1),
            FramebufferAttachmentObjectTypeExt = ((int)0x8cd0),
            PolygonSmooth = ((int)0x0b41),
            Alpha4Ext = ((int)0x803b),
            VariantArrayStrideExt = ((int)0x87e6),
            VariantArrayExt = ((int)0x87e8),
            Reg8Ati = ((int)0x8929),
            TransposeTextureMatrix = ((int)0x84e5),
            MaxProgramTexInstructionsArb = ((int)0x880c),
            PointToken = ((int)0x0701),
            Texture19Arb = ((int)0x84d3),
            CompressedTextureFormatsArb = ((int)0x86a3),
            UnsignedInvertNv = ((int)0x8537),
            Sampler1dShadow = ((int)0x8b61),
            Texture = ((int)0x1702),
            IntSampler3dExt = ((int)0x8dcb),
            VariantDatatypeExt = ((int)0x87e5),
            Intensity32fArb = ((int)0x8817),
            ProgramTexIndirectionsArb = ((int)0x8807),
            ProjectionStackDepth = ((int)0x0ba4),
            SignedNegateNv = ((int)0x853d),
            FloatMat4Arb = ((int)0x8b5c),
            PointDistanceAttenuation = ((int)0x8129),
            ColorMaterialFace = ((int)0x0b55),
            FragmentLight2Sgix = ((int)0x840e),
            Matrix1Nv = ((int)0x8631),
            FloatRg16Nv = ((int)0x8886),
            PixelUnpackBufferBindingArb = ((int)0x88ef),
                Matrix23 = ((int)0x88d7),
            Texture18Arb = ((int)0x84d2),
            Matrix13 = ((int)0x88cd),
            Luminance32iExt = ((int)0x8d86),
            RasterizerDiscardNv = ((int)0x8c89),
            CombineExt = ((int)0x8570),
            Alpha16uiExt = ((int)0x8d78),
            TextureBinding1d = ((int)0x8068),
            TextureBinding3d = ((int)0x806a),
            TextureBinding2d = ((int)0x8069),
            Modelview8Arb = ((int)0x8728),
            Luminance12Ext = ((int)0x8041),
            Greater = ((int)0x0204),
            QueryCounterBits = ((int)0x8864),
            BlendSrc = ((int)0x0be1),
            Texcoord3BitPgi = ((int)0x40000000),
            LocalConstantDatatypeExt = ((int)0x87ed),
            SignedAlpha8Nv = ((int)0x8706),
            ReplacementCodeArrayStrideSun = ((int)0x85c2),
            MaxTextureMaxAnisotropyExt = ((int)0x84ff),
            MaxMapTessellationNv = ((int)0x86d6),
            Dot3Rgba = ((int)0x86af),
            Compile = ((int)0x1300),
            Vertex23BitPgi = ((int)0x00000004),
                DetailTextureLevelSgis = ((int)0x809a),
            ColorArrayListStrideIbm = ((int)103082),
                MaxVertexAttribsArb = ((int)0x8869),
            VertexArrayRangeNv = ((int)0x851d),
            Rgb5Ext = ((int)0x8050),
                VertexPreclipSgix = ((int)0x83ee),
            Luminance16 = ((int)0x8042),
            ClipPlane2 = ((int)0x3002),
            MaxMatrixPaletteStackDepthArb = ((int)0x8841),
            Luminance12 = ((int)0x8041),
            BumpTexUnitsAti = ((int)0x8778),
                    MaxPixelMapTable = ((int)0x0d34),
            FragmentColorMaterialSgix = ((int)0x8401),
            OutputTextureCoord18Ext = ((int)0x87af),
            FloatVec4 = ((int)0x8b52),
            DrawBuffer13Arb = ((int)0x8832),
            CalligraphicFragmentSgix = ((int)0x8183),
            StencilIndex = ((int)0x1901),
            FogFuncSgis = ((int)0x812a),
            TextureDepth = ((int)0x8071),
            StaticDraw = ((int)0x88e4),
            SignedIdentityNv = ((int)0x853c),
            Matrix31 = ((int)0x88df),
            IndexArrayPointer = ((int)0x8091),
            LuminanceAlpha32fArb = ((int)0x8819),
            StencilIndex16Ext = ((int)0x8d49),
            FeedbackBufferSize = ((int)0x0df1),
            Luminance6Alpha2 = ((int)0x8044),
            UnsignedIntSampler2dRectExt = ((int)0x8dd5),
                Rgb5 = ((int)0x8050),
            ResampleZeroFillOml = ((int)0x8987),
            MaxDeformationOrderSgix = ((int)0x8197),
            VertexDataHintPgi = ((int)0x1a22a),
            LineToken = ((int)0x0702),
            EyePlane = ((int)0x2502),
            TriangleStripAdjacencyExt = ((int)0x000d),
            UnpackSwapBytes = ((int)0x0cf0),
            VertexShaderOptimizedExt = ((int)0x87d4),
            OffsetProjectiveTexture2dScaleNv = ((int)0x8851),
            DrawBuffer12Arb = ((int)0x8831),
            UnsignedShort1555Rev = ((int)0x8366),
            TextureNormalExt = ((int)0x85af),
            CndAti = ((int)0x896a),
                QueryResultArb = ((int)0x8866),
            HalfFloatArb = ((int)0x140b),
            VariantArrayPointerExt = ((int)0x87e9),
            Combine = ((int)0x8570),
            OcclusionTestResultHp = ((int)0x8166),
            InstrumentMeasurementsSgix = ((int)0x8181),
            OutputTextureCoord5Ext = ((int)0x87a2),
            MapStencil = ((int)0x0d11),
            MaxRectangleTextureSizeArb = ((int)0x84f8),
            VertexArrayPointer = ((int)0x808e),
            Rgb2Ext = ((int)0x804e),
            UnpackResampleOml = ((int)0x8985),
            FullStippleHintPgi = ((int)0x1a219),
            StaticDrawArb = ((int)0x88e4),
            PixelUnpackBufferBindingExt = ((int)0x88ef),
            ObjectLinear = ((int)0x2401),
            Add = ((int)0x0104),
            BufferAccess = ((int)0x88bb),
            HiloNv = ((int)0x86f4),
            Emission = ((int)0x1600),
            TextureMaterialFaceExt = ((int)0x8351),
            Matrix4Nv = ((int)0x8634),
            DependentHiloTexture2dNv = ((int)0x8858),
            Intensity16IccSgix = ((int)0x846a),
                SwizzleStrqDqAti = ((int)0x897b),
            VectorExt = ((int)0x87bf),
            Texture30Arb = ((int)0x84de),
            BoolVec3Arb = ((int)0x8b58),
            ProgramResultComponentsNv = ((int)0x8907),
            PostTextureFilterBiasRangeSgix = ((int)0x817b),
            GeometryVerticesOutExt = ((int)0x8dda),
            TextureLuminanceTypeArb = ((int)0x8c14),
            Line = ((int)0x1b01),
            LightModelLocalViewer = ((int)0x0b51),
            RenderbufferBlueSizeExt = ((int)0x8d52),
            MaxTextureCoords = ((int)0x8871),
            Con15Ati = ((int)0x8950),
            PixelUnpackBufferBinding = ((int)0x88ef),
            VertexArrayRangePointerNv = ((int)0x8521),
            RenderbufferCoverageSamplesNv = ((int)0x8cab),
            ProxyPostImageTransformColorTableHp = ((int)0x8163),
            Matrix7Nv = ((int)0x8637),
            CullVertexEyePositionExt = ((int)0x81ab),
            ZeroExt = ((int)0x87dd),
            VertexShaderExt = ((int)0x8780),
            Rgba8iExt = ((int)0x8d8e),
            OutputTextureCoord3Ext = ((int)0x87a0),
            SmoothLineWidthGranularity = ((int)0x0b23),
            Stereo = ((int)0x0c33),
            TextureClipmapDepthSgix = ((int)0x8176),
            SignedRgb8UnsignedAlpha8Nv = ((int)0x870d),
            AlphaTestRef = ((int)0x0bc2),
            OneMinusSrcColor = ((int)0x0301),
            PackInvertMesa = ((int)0x8758),
            FogCoordinateArrayTypeExt = ((int)0x8454),
                Sampler1d = ((int)0x8b5d),
            TexturePostSpecularHp = ((int)0x8168),
            CompressedLuminanceLatc1Ext = ((int)0x8c70),
            QuadraticAttenuation = ((int)0x1209),
            NormalMapNv = ((int)0x8511),
            TextureCubeMapNegativeZExt = ((int)0x851a),
            ActiveAttributeMaxLength = ((int)0x8b8a),
            R3G3B2 = ((int)0x2a10),
            Spare1Nv = ((int)0x852f),
            CombineRgbArb = ((int)0x8571),
            TextureDepthSizeArb = ((int)0x884a),
            ColorAttachment9Ext = ((int)0x8ce9),
            Texture1Arb = ((int)0x84c1),
            PnTrianglesTesselationLevelAti = ((int)0x87f4),
            PreviousTextureInputNv = ((int)0x86e4),
            TextureInternalFormat = ((int)0x1003),
                CullVertexIbm = ((int)103050),
            MaxCombinedTextureImageUnitsArb = ((int)0x8b4d),
            ReadFramebufferExt = ((int)0x8ca8),
            Gl422RevExt = ((int)0x80cd),
            ArrayElementLockCountExt = ((int)0x81a9),
            Reg11Ati = ((int)0x892c),
            PointSpriteArb = ((int)0x8861),
            CompressedRgbS3tcDxt1Ext = ((int)0x83f0),
            FloatRNv = ((int)0x8880),
            NormalArrayExt = ((int)0x8075),
            MirrorClampToBorderExt = ((int)0x8912),
            NegativeYExt = ((int)0x87da),
            Matrix25 = ((int)0x88d9),
            R1uiC4ubV3fSun = ((int)0x85c5),
            MaxTextureStackDepth = ((int)0x0d39),
            ActiveVaryingMaxLengthNv = ((int)0x8c82),
            SampleAlphaToCoverage = ((int)0x809e),
            NativeGraphicsHandlePgi = ((int)0x1a202),
            TextureAlphaSizeExt = ((int)0x805f),
            HiScaleNv = ((int)0x870e),
            Histogram = ((int)0x8024),
            Srgb8Alpha8Ext = ((int)0x8c43),
            MaxVertexBindableUniformsExt = ((int)0x8de2),
            NearestMipmapNearest = ((int)0x2700),
            ResampleDecimateOml = ((int)0x8989),
            FramebufferIncompleteDimensionsExt = ((int)0x8cd9),
            TextureCubeMapPositiveZ = ((int)0x8519),
            PnTrianglesNormalModeQuadraticAti = ((int)0x87f8),
            TextureCubeMapPositiveX = ((int)0x8515),
            TextureCubeMapPositiveY = ((int)0x8517),
            SwizzleStrDrAti = ((int)0x8978),
            AttribArrayTypeNv = ((int)0x8625),
            Con26Ati = ((int)0x895b),
            DrawFramebufferExt = ((int)0x8ca9),
            PixelTexGenAlphaNoReplaceSgix = ((int)0x8188),
            VertexArrayBufferBindingArb = ((int)0x8896),
            ObjectActiveUniformMaxLengthArb = ((int)0x8b87),
            TextureCoordArrayListIbm = ((int)103074),
            T4fV4f = ((int)0x2a28),
            AlphaTestFunc = ((int)0x0bc1),
            SwizzleStrqAti = ((int)0x897a),
            PixelTextureSgis = ((int)0x8353),
            RgbaSignedComponentsExt = ((int)0x8c3c),
            Con11Ati = ((int)0x894c),
            PixelMapGToG = ((int)0x0c77),
            CurrentRasterTextureCoords = ((int)0x0b06),
            Operand2AlphaArb = ((int)0x859a),
            ColorArrayType = ((int)0x8082),
            PnTrianglesAti = ((int)0x87f0),
            One = ((int)1),
            IuiV3fExt = ((int)0x81ae),
            NormalizedRangeExt = ((int)0x87e0),
            CompressedAlpha = ((int)0x84e9),
            ArrayObjectBufferAti = ((int)0x8766),
            NormalArrayParallelPointersIntel = ((int)0x83f6),
            ObjectPlane = ((int)0x2501),
            TextureIntensitySize = ((int)0x8061),
            DtBiasNv = ((int)0x8717),
            TriangleListSun = ((int)0x81d7),
            MaxProgramTotalOutputComponentsNv = ((int)0x8c28),
                PassThroughNv = ((int)0x86e6),
            FloatRgb32Nv = ((int)0x8889),
            Src1Alpha = ((int)0x8589),
            PixelSubsample4444Sgix = ((int)0x85a2),
            Render = ((int)0x1c00),
            TextureGreenTypeArb = ((int)0x8c11),
            AccumClearValue = ((int)0x0b80),
            EdgeFlagArrayPointerExt = ((int)0x8093),
            FogCoordSrc = ((int)0x8450),
            Operand0AlphaArb = ((int)0x8598),
            ColorSum = ((int)0x8458),
            T2fC3fV3f = ((int)0x2a2a),
            NormalArrayTypeExt = ((int)0x807e),
            OpRoundExt = ((int)0x8790),
            Luminance8 = ((int)0x8040),
            UniformBufferExt = ((int)0x8dee),
            UnsignedShort4444 = ((int)0x8033),
            DeleteStatus = ((int)0x8b80),
            RgbaFloat32Ati = ((int)0x8814),
            ScissorBit = ((int)0x00080000),
            T4fC4fN3fV4f = ((int)0x2a2d),
            SwizzleStqDqAti = ((int)0x8979),
            Int = ((int)0x1404),
            TextureBorderValuesNv = ((int)0x871a),
            PixelMapIToG = ((int)0x0c73),
            FloatR16Nv = ((int)0x8884),
            GreenMinClampIngr = ((int)0x8561),
            BackPrimaryColorNv = ((int)0x8c77),
            UnsignedIdentityNv = ((int)0x8536),
            VertexShader = ((int)0x8b31),
                LightModelAmbient = ((int)0x0b53),
            BoolVec3 = ((int)0x8b58),
            InterlaceSgix = ((int)0x8094),
            DrawBuffer14Ati = ((int)0x8833),
            StencilTagBitsExt = ((int)0x88f2),
            WeightArrayBufferBinding = ((int)0x889e),
            MatrixExt = ((int)0x87c0),
            MaxGeometryTotalOutputComponentsExt = ((int)0x8de1),
            PolygonSmoothHint = ((int)0x0c53),
            MaxRationalEvalOrderNv = ((int)0x86d7),
            SrcAlphaSaturate = ((int)0x0308),
            UnsignedIntSampler3dExt = ((int)0x8dd3),
            TableTooLarge = ((int)0x8031),
            ElementArrayBufferBindingArb = ((int)0x8895),
            FramebufferIncompleteAttachmentExt = ((int)0x8cd6),
            Srgb8 = ((int)0x8c41),
            IndexTestRefExt = ((int)0x81b7),
            Float32UnsignedInt248RevNv = ((int)0x8dad),
            Con22Ati = ((int)0x8957),
            HistogramFormat = ((int)0x8027),
            FragmentColorMaterialParameterSgix = ((int)0x8403),
            Texture3dBindingExt = ((int)0x806a),
            MaxArrayTextureLayersExt = ((int)0x88ff),
            NegativeZExt = ((int)0x87db),
            TextureBufferExt = ((int)0x8c2a),
            IntVec2 = ((int)0x8b53),
            IntVec3 = ((int)0x8b54),
            Rgb4Ext = ((int)0x804f),
            SecondaryColorArrayListIbm = ((int)103077),
            DrawBuffer1Arb = ((int)0x8826),
            IntVec4 = ((int)0x8b55),
            ProxyTextureCubeMapArb = ((int)0x851b),
            Point = ((int)0x1b00),
            ClipPlane3 = ((int)0x3003),
            DepthComponent16 = ((int)0x81a5),
            LightModelSpecularVectorApple = ((int)0x85b0),
            PixelMapRToR = ((int)0x0c76),
            Luminance6Alpha2Ext = ((int)0x8044),
            Gl4pass3Ext = ((int)0x80a7),
            Matrix19 = ((int)0x88d3),
            IndexBitPgi = ((int)0x00080000),
            Map2GridDomain = ((int)0x0dd2),
            ResampleReplicateSgix = ((int)0x842e),
            Con3Ati = ((int)0x8944),
            PrimaryColorNv = ((int)0x852c),
            UnsignedIntS8S888Nv = ((int)0x86da),
            MaxProgramOutputVerticesNv = ((int)0x8c27),
            TextureCubeMap = ((int)0x8513),
            RenderbufferSamplesExt = ((int)0x8cab),
            Rgb8iExt = ((int)0x8d8f),
            DepthClearValue = ((int)0x0b73),
            SecondaryInterpolatorAti = ((int)0x896d),
            ColorAttachment1Ext = ((int)0x8ce1),
            TextureLightingModeHp = ((int)0x8167),
            Texture4dsizeSgis = ((int)0x8136),
            BumpEnvmapAti = ((int)0x877b),
            UnsignedShort565Reversed = ((int)0x8364),
            NormalArrayBufferBindingArb = ((int)0x8897),
            TangentArrayPointerExt = ((int)0x8442),
            Operand0Alpha = ((int)0x8598),
            TextureCompressed = ((int)0x86a1),
            Luminance4 = ((int)0x803f),
            Con24Ati = ((int)0x8959),
            Luminance16iExt = ((int)0x8d8c),
            PostConvolutionColorTable = ((int)0x80d1),
            GenerateMipmapHint = ((int)0x8192),
            PhongWin = ((int)0x80ea),
            TextureDeformationBitSgix = ((int)0x00000001),
            LuminanceAlpha32uiExt = ((int)0x8d75),
            PackLsbFirst = ((int)0x0d01),
            OpRecipSqrtExt = ((int)0x8795),
            ProxyPostConvolutionColorTable = ((int)0x80d4),
            MaxVertexShaderInvariantsExt = ((int)0x87c7),
            ConvolutionFormat = ((int)0x8017),
            Rgba32uiExt = ((int)0x8d70),
            ModulateAddAti = ((int)0x8744),
            TextureEnvMode = ((int)0x2200),
            Select = ((int)0x1c02),
            TextureClipmapLodOffsetSgix = ((int)0x8175),
            DepthStencilNv = ((int)0x84f9),
            Rgba16iExt = ((int)0x8d88),
                MapColor = ((int)0x0d10),
            VertexArrayParallelPointersIntel = ((int)0x83f5),
            OutputTextureCoord9Ext = ((int)0x87a6),
            ReplaceMiddleSun = ((int)0x0002),
            MaxProgramNativeAddressRegisters = ((int)0x88b3),
            CompressedSluminanceAlpha = ((int)0x8c4b),
            OutputTextureCoord28Ext = ((int)0x87b9),
            EvalVertexAttrib8Nv = ((int)0x86ce),
            PostColorMatrixAlphaBias = ((int)0x80bb),
            None = ((int)0),
            FogCoord = ((int)0x8451),
                UnsignedIntSamplerCubeExt = ((int)0x8dd4),
            AlwaysSoftHintPgi = ((int)0x1a20d),
            Nor = ((int)0x1508),
            BiasBitAti = ((int)0x00000008),
            StencilBackWritemask = ((int)0x8ca5),
            MatrixIndexArrayStrideArb = ((int)0x8848),
            NegativeWExt = ((int)0x87dc),
            TrackMatrixTransformNv = ((int)0x8649),
                LineBit = ((int)0x00000004),
            PixelMagFilterExt = ((int)0x8331),
                Src2Alpha = ((int)0x858a),
            Modelview7Arb = ((int)0x8727),
            RgbScale = ((int)0x8573),
            PrimitiveRestartIndexNv = ((int)0x8559),
            FramebufferIncompleteReadBufferExt = ((int)0x8cdc),
            Con6Ati = ((int)0x8947),
            ProgramResidentNv = ((int)0x8647),
            MaxGeometryUniformComponentsExt = ((int)0x8ddf),
            ReflectionMapNv = ((int)0x8512),
            Rgb4S3tc = ((int)0x83a1),
            CompressedIntensity = ((int)0x84ec),
            FragmentShader = ((int)0x8b30),
            StencilBackPassDepthPass = ((int)0x8803),
            Con19Ati = ((int)0x8954),
            StencilBits = ((int)0x0d57),
            Dsdt8Nv = ((int)0x8709),
            TextureWrapQSgis = ((int)0x8137),
            Gl4pass1Sgis = ((int)0x80a5),
            TextureCoordArrayBufferBindingArb = ((int)0x889a),
            Map1Normal = ((int)0x0d92),
                Map1VertexAttrib14Nv = ((int)0x8661),
            Con31Ati = ((int)0x8960),
            IndexMaterialExt = ((int)0x81b8),
            PolygonOffsetPoint = ((int)0x2a01),
            Alpha8iExt = ((int)0x8d90),
            TextureBorderColor = ((int)0x1004),
            TextureBindingCubeMapArb = ((int)0x8514),
            FramebufferAttachmentTextureLayerExt = ((int)0x8cd4),
            TextureClipmapVirtualDepthSgix = ((int)0x8174),
            IntVec2Arb = ((int)0x8b53),
            OffsetTextureScaleNv = ((int)0x86e2),
            DrawBuffer8Arb = ((int)0x882d),
            MatrixIndexArraySizeArb = ((int)0x8846),
            Con20Ati = ((int)0x8955),
            TransformFeedbackBufferStartNv = ((int)0x8c84),
            Modelview0MatrixExt = ((int)0x0ba6),
            TextureGenMode = ((int)0x2500),
            VertexSourceAti = ((int)0x8774),
            PolygonToken = ((int)0x0703),
            PostConvolutionAlphaBias = ((int)0x8023),
            AccumBlueBits = ((int)0x0d5a),
            DrawBuffer10Arb = ((int)0x882f),
            SubpixelBits = ((int)0x0d50),
            XExt = ((int)0x87d5),
            Map1VertexAttrib64Nv = ((int)0x8666),
            MaxAsyncHistogramSgix = ((int)0x832d),
            BinormalArrayPointerExt = ((int)0x8443),
            ColorArrayParallelPointersIntel = ((int)0x83f7),
            SamplerCube = ((int)0x8b60),
            OutputTextureCoord4Ext = ((int)0x87a1),
            Source2RgbExt = ((int)0x8582),
            CurrentFogCoord = ((int)0x8453),
            DynamicReadArb = ((int)0x88e9),
            CompressedLuminanceAlphaLatc2Ext = ((int)0x8c72),
            MaxFragmentLightsSgix = ((int)0x8404),
            DepthPassInstrumentSgix = ((int)0x8310),
            FragmentLight1Sgix = ((int)0x840d),
            OutputTextureCoord15Ext = ((int)0x87ac),
            IntSampler1dArrayExt = ((int)0x8dce),
            Con29Ati = ((int)0x895e),
            OffsetTexture2dMatrixNv = ((int)0x86e1),
            ColorArrayStride = ((int)0x8083),
            Map1Index = ((int)0x0d91),
            NumGeneralCombinersNv = ((int)0x854e),
            Luminance4Ext = ((int)0x803f),
            CurrentProgram = ((int)0x8b8d),
            And = ((int)0x1501),
            Texture4dSgis = ((int)0x8134),
            Max4dTextureSizeSgis = ((int)0x8138),
            CurrentRasterDistance = ((int)0x0b09),
            Con25Ati = ((int)0x895a),
            Gl4Bytes = ((int)0x1409),
            Load = ((int)0x0101),
            DualLuminance16Sgis = ((int)0x8117),
            Min = ((int)0x8007),
            Sluminance = ((int)0x8c46),
            NativeGraphicsEndHintPgi = ((int)0x1a204),
            MaxTextureImageUnitsArb = ((int)0x8872),
            FrontFace = ((int)0x0b46),
            DrawBuffer2Arb = ((int)0x8827),
            ResampleDecimateSgix = ((int)0x8430),
            PostColorMatrixRedBias = ((int)0x80b8),
            ColorTableLuminanceSize = ((int)0x80de),
            Map1VertexAttrib04Nv = ((int)0x8660),
            CompBitAti = ((int)0x00000002),
            PixelMapIToR = ((int)0x0c72),
            NormalArrayPointerExt = ((int)0x808f),
                LuminanceAlpha8iExt = ((int)0x8d93),
            ColorSumArb = ((int)0x8458),
            CurrentBinormalExt = ((int)0x843c),
            Modelview0StackDepthExt = ((int)0x0ba3),
            NegativeXExt = ((int)0x87d9),
            TextureCompressedImageSize = ((int)0x86a0),
            InterleavedAttribsNv = ((int)0x8c8c),
            Gl4xBitAti = ((int)0x00000002),
            ShaderOperationNv = ((int)0x86df),
            ProgramTexInstructionsArb = ((int)0x8806),
                SpriteObjectAlignedSgix = ((int)0x814d),
            FogStart = ((int)0x0b63),
            TextureStencilSizeExt = ((int)0x88f1),
            MaxAsyncTexImageSgix = ((int)0x835f),
            ColorTableBlueSize = ((int)0x80dc),
            RenderbufferStencilSizeExt = ((int)0x8d55),
            OneMinusConstantColor = ((int)0x8002),
            Texture7Arb = ((int)0x84c7),
            ProgramStringNv = ((int)0x8628),
            ColorTableGreenSize = ((int)0x80db),
            TextureGenR = ((int)0x0c62),
            CompressedRgba = ((int)0x84ee),
            SignedHilo8Nv = ((int)0x885f),
            ColorWritemask = ((int)0x0c23),
            BumpTargetAti = ((int)0x877c),
                ResampleZeroFillSgix = ((int)0x842f),
            TransformFeedbackBufferSizeNv = ((int)0x8c85),
            ColorArrayListIbm = ((int)103072),
            FragmentLightModelNormalInterpolationSgix = ((int)0x840b),
            MaxVertexUnitsArb = ((int)0x86a4),
            PointSmoothHint = ((int)0x0c51),
            OutputTextureCoord22Ext = ((int)0x87b3),
            MaxVertexHintPgi = ((int)0x1a22d),
            MultisampleBitExt = ((int)0x20000000),
            StencilValueMask = ((int)0x0b93),
            CurrentRasterPosition = ((int)0x0b07),
            MatColorIndexesBitPgi = ((int)0x01000000),
            CullVertexObjectPositionExt = ((int)0x81ac),
            LuminanceIntegerExt = ((int)0x8d9c),
            AlwaysFastHintPgi = ((int)0x1a20c),
            FloatVec2 = ((int)0x8b50),
            FloatVec3 = ((int)0x8b51),
            TextureShaderNv = ((int)0x86de),
            OutputTextureCoord0Ext = ((int)0x879d),
            SampleBuffers3dfx = ((int)0x86b3),
                VertexProgramPointSizeNv = ((int)0x8642),
            Light0 = ((int)0x4000),
            OpDot3Ext = ((int)0x8784),
            GreenMaxClampIngr = ((int)0x8565),
            Map1VertexAttrib124Nv = ((int)0x866c),
            MaxProgramLocalParameters = ((int)0x88b4),
            ClipPlane4 = ((int)0x3004),
            R1uiN3fV3fSun = ((int)0x85c7),
            PrimitivesGeneratedNv = ((int)0x8c87),
            VertexAttribArray0Nv = ((int)0x8650),
            SluminanceExt = ((int)0x8c46),
            TextureColorWritemaskSgis = ((int)0x81ef),
            StencilBackFailAti = ((int)0x8801),
            Ambient = ((int)0x1200),
            TexturePreSpecularHp = ((int)0x8169),
            Con21Ati = ((int)0x8956),
            OutputTextureCoord1Ext = ((int)0x879e),
            EmbossMapNv = ((int)0x855f),
            ConstantBorder = ((int)0x8151),
            NearestMipmapLinear = ((int)0x2702),
            Con5Ati = ((int)0x8946),
            ActiveTexture = ((int)0x84e0),
            EdgeFlagArrayCountExt = ((int)0x808d),
            PostTextureFilterScaleSgix = ((int)0x817a),
            FogCoordArrayBufferBinding = ((int)0x889d),
            ProgramNativeTexIndirectionsArb = ((int)0x880a),
            Replace = ((int)0x1e01),
            PointSprite = ((int)0x8861),
            UnsignedShort = ((int)0x1403),
                PerspectiveCorrectionHint = ((int)0x0c50),
            Normalize = ((int)0x0ba1),
            PostImageTransformColorTableHp = ((int)0x8162),
            QuarterBitAti = ((int)0x00000010),
            Map1VertexAttrib44Nv = ((int)0x8664),
            LuminanceAlpha8uiExt = ((int)0x8d81),
            Fog = ((int)0x0b60),
            GeometryProgramNv = ((int)0x8c26),
            Eval2dNv = ((int)0x86c0),
            OutputTextureCoord6Ext = ((int)0x87a3),
            VertexArrayStorageHintApple = ((int)0x851f),
            RgbaS3tc = ((int)0x83a2),
            ProxyTexture2dArrayExt = ((int)0x8c1b),
            IndexArrayStrideExt = ((int)0x8086),
                VertexProgram = ((int)0x8620),
            CompressedLuminanceArb = ((int)0x84ea),
            NumCompressedTextureFormatsArb = ((int)0x86a2),
            GreenIntegerExt = ((int)0x8d95),
            ClipVolumeClippingHintExt = ((int)0x80f0),
            DrawBuffer15Arb = ((int)0x8834),
            UnsignedInt248Nv = ((int)0x84fa),
            DepthPassInstrumentCountersSgix = ((int)0x8311),
            Noop = ((int)0x1505),
            Domain = ((int)0x0a02),
            Con23Ati = ((int)0x8958),
            ProgramInstruction = ((int)0x88a0),
            PixelPackBufferArb = ((int)0x88eb),
            TextureFilterControl = ((int)0x8500),
            ImageTransform2dHp = ((int)0x8161),
            LuminanceAlpha16uiExt = ((int)0x8d7b),
            PreviousArb = ((int)0x8578),
            ExpandNegateNv = ((int)0x8539),
            VibranceBiasNv = ((int)0x8719),
            VertexArrayBindingApple = ((int)0x85b5),
            DependentArTexture2dNv = ((int)0x86e9),
            ColorMatrix = ((int)0x80b1),
            T2fV3f = ((int)0x2a27),
            Luminance16fArb = ((int)0x881e),
            PrimaryColor = ((int)0x8577),
            TextureBufferFormatExt = ((int)0x8c2e),
            MaxProgramParameterBufferBindingsNv = ((int)0x8da0),
            Sampler1dArrayShadowExt = ((int)0x8dc3),
            TransposeProjectionMatrixArb = ((int)0x84e4),
            MaxPaletteMatricesArb = ((int)0x8842),
            ObjectLinkStatusArb = ((int)0x8b82),
            Lighting = ((int)0x0b50),
            MaxOptimizedVertexShaderLocalConstantsExt = ((int)0x87cc),
            SampleCoverageInvert = ((int)0x80ab),
            OrInverted = ((int)0x150d),
            MaxVertexVaryingComponentsExt = ((int)0x8dde),
            Sampler1dShadowArb = ((int)0x8b61),
            IndexArrayListStrideIbm = ((int)103083),
            ColorTableIntensitySize = ((int)0x80df),
            Map1VertexAttrib104Nv = ((int)0x866a),
                StreamReadArb = ((int)0x88e1),
            AlphaFloat16Ati = ((int)0x881c),
            Reg26Ati = ((int)0x893b),
            VertexAttribArray2Nv = ((int)0x8652),
                PolygonStippleBit = ((int)0x00000010),
            VertexArray = ((int)0x8074),
            HistogramLuminanceSize = ((int)0x802c),
            Texture1dStackMesax = ((int)0x8759),
            PnTrianglesNormalModeAti = ((int)0x87f3),
            Two = ((int)2),
            ReplaceExt = ((int)0x8062),
            TrianglesAdjacencyExt = ((int)0x000c),
            ReadWrite = ((int)0x88ba),
            Texture5 = ((int)0x84c5),
            DetailTextureModeSgis = ((int)0x809b),
            PixelTexGenModeSgix = ((int)0x832b),
            EvalVertexAttrib14Nv = ((int)0x86d4),
            DepthPassInstrumentMaxSgix = ((int)0x8312),
            NormalArrayType = ((int)0x807e),
            Texture4 = ((int)0x84c4),
            StorageCachedApple = ((int)0x85be),
            FramebufferBindingExt = ((int)0x8ca6),
            CurrentTangentExt = ((int)0x843b),
            DepthAttachmentExt = ((int)0x8d00),
            OpMultiplyMatrixExt = ((int)0x8798),
            TextureEnvBiasSgix = ((int)0x80be),
            PixelTileCacheIncrementSgix = ((int)0x813f),
            TransposeNv = ((int)0x862c),
            MaxClipPlanes = ((int)0x0d32),
            OutputTextureCoord2Ext = ((int)0x879f),
            SignedRgbUnsignedAlphaNv = ((int)0x870c),
            FramebufferIncompleteMultisampleExt = ((int)0x8d56),
            ArrayBufferArb = ((int)0x8892),
            CurrentNormal = ((int)0x0b02),
            Reg0Ati = ((int)0x8921),
                Light7 = ((int)0x4007),
            Intensity8uiExt = ((int)0x8d7f),
            VertexShaderBindingExt = ((int)0x8781),
            TextureCompareFuncArb = ((int)0x884d),
            SingleColor = ((int)0x81f9),
            OpFloorExt = ((int)0x878f),
            Renderer = ((int)0x1f01),
            Texture4Arb = ((int)0x84c4),
            MaxProgramTexelOffsetNv = ((int)0x8905),
            ExpandNormalNv = ((int)0x8538),
            FragmentLight0Sgix = ((int)0x840c),
            OpIndexExt = ((int)0x8782),
            Alpha32uiExt = ((int)0x8d72),
            DualLuminance8Sgis = ((int)0x8115),
            UnsignedShort565Rev = ((int)0x8364),
            StreamCopyArb = ((int)0x88e2),
            Smooth = ((int)0x1d01),
            ScreenCoordinatesRend = ((int)0x8490),
            FogScaleValueSgix = ((int)0x81fd),
            Modelview6Arb = ((int)0x8726),
            DsdtNv = ((int)0x86f5),
            FloatRg32Nv = ((int)0x8887),
            Source2RgbArb = ((int)0x8582),
            UnpackRowLength = ((int)0x0cf2),
            AllAttribBits = unchecked((int)0xffffffff),
            StrictLightingHintPgi = ((int)0x1a217),
            DetailTextureFuncPointsSgis = ((int)0x809c),
            OutputTextureCoord8Ext = ((int)0x87a5),
            CurrentMatrixStackDepthArb = ((int)0x8640),
            Reg1Ati = ((int)0x8922),
            RenderMode = ((int)0x0c40),
            MirrorClampExt = ((int)0x8742),
            Matrix6Nv = ((int)0x8636),
            ScaleByFourNv = ((int)0x853f),
                OutputTextureCoord30Ext = ((int)0x87bb),
            VertexStateProgramNv = ((int)0x8621),
            MaxProgramAddressRegisters = ((int)0x88b1),
            StackOverflow = ((int)0x0503),
            Map2VertexAttrib124Nv = ((int)0x867c),
            MaxTransformFeedbackSeparateAttribsNv = ((int)0x8c8b),
            OneMinusDstAlpha = ((int)0x0305),
            FuncReverseSubtract = ((int)0x800b),
            Srgb8Ext = ((int)0x8c41),
            FragmentLight5Sgix = ((int)0x8411),
            SignedRgbaNv = ((int)0x86fb),
            TextureBlueSize = ((int)0x805e),
            DependentRgbTexture3dNv = ((int)0x8859),
            Matrix3 = ((int)0x88c3),
            ReflectionMap = ((int)0x8512),
            MultisampleSgis = ((int)0x809d),
            QuadAlpha4Sgis = ((int)0x811e),
            Rgb10A2 = ((int)0x8059),
            PixelTileGridWidthSgix = ((int)0x8142),
            Map1Vertex4 = ((int)0x0d98),
            TextureClipmapCenterSgix = ((int)0x8171),
            Map1Vertex3 = ((int)0x0d97),
            StaticAti = ((int)0x8760),
            VariantExt = ((int)0x87c1),
            OpMovExt = ((int)0x8799),
            ScissorBox = ((int)0x0c10),
            SubtractArb = ((int)0x84e7),
            DepthScale = ((int)0x0d1e),
            TextureMaxLod = ((int)0x813b),
            PostConvolutionGreenScale = ((int)0x801d),
            MultisampleBitArb = ((int)0x20000000),
            ActiveUniformMaxLength = ((int)0x8b87),
            ObjectValidateStatusArb = ((int)0x8b83),
            Du8dv8Ati = ((int)0x877a),
            ReplacementCodeSun = ((int)0x81d8),
            CompressedRgbaS3tcDxt1Ext = ((int)0x83f1),
                ObjectDeleteStatusArb = ((int)0x8b80),
            GeometryInputTypeExt = ((int)0x8ddb),
            ProgramAttribComponentsNv = ((int)0x8906),
            UnsignedInt5999RevExt = ((int)0x8c3e),
            IndexOffset = ((int)0x0d13),
            PnTrianglesPointModeCubicAti = ((int)0x87f6),
            HalfBiasNegateNv = ((int)0x853b),
            Dither = ((int)0x0bd0),
            Short = ((int)0x1402),
            CompileAndExecute = ((int)0x1301),
            ArrayStride = ((int)0x8624),
            ProgramNativeAddressRegisters = ((int)0x88b2),
            Texture7 = ((int)0x84c7),
            DepthTextureMode = ((int)0x884b),
            NumInputInterpolatorComponentsAti = ((int)0x8973),
                SrgbAlpha = ((int)0x8c42),
                PixelPackBufferBindingExt = ((int)0x88ed),
            OutputTextureCoord26Ext = ((int)0x87b7),
            YcbcrMesa = ((int)0x8757),
            QuadLuminance4Sgis = ((int)0x8120),
            NumInstructionsPerPassAti = ((int)0x8971),
            Texcoord1BitPgi = ((int)0x10000000),
            Rgba16Ext = ((int)0x805b),
            SaturateBitAti = ((int)0x00000040),
            Alpha8Ext = ((int)0x803c),
            UnsignedInt = ((int)0x1405),
            Alpha16iExt = ((int)0x8d8a),
            MaxVertexAttribs = ((int)0x8869),
            MaxTextureCoordsNv = ((int)0x8871),
            RgbaFloatModeArb = ((int)0x8820),
            ImplementationColorReadTypeOes = ((int)0x8b9a),
            FormatSubsample244244Oml = ((int)0x8983),
            VertexAttribArray15Nv = ((int)0x865f),
            TextureLightExt = ((int)0x8350),
                Con27Ati = ((int)0x895c),
            AlphaIntegerExt = ((int)0x8d97),
            Texture25Arb = ((int)0x84d9),
            Modelview1StackDepthExt = ((int)0x8502),
            DepthComponent16Arb = ((int)0x81a5),
            MovAti = ((int)0x8961),
            SamplePatternExt = ((int)0x80ac),
            ModulateSignedAddAti = ((int)0x8745),
            StaticCopyArb = ((int)0x88e6),
            Source3RgbNv = ((int)0x8583),
            TextureBindingBufferExt = ((int)0x8c2c),
            IuiN3fV3fExt = ((int)0x81b0),
            ProgramNativeTemporaries = ((int)0x88a6),
            Map2VertexAttrib54Nv = ((int)0x8675),
            Sampler2dArrayExt = ((int)0x8dc1),
            Texture16 = ((int)0x84d0),
            Texture17 = ((int)0x84d1),
            Texture14 = ((int)0x84ce),
            SpriteEyeAlignedSgix = ((int)0x814e),
            Source1AlphaExt = ((int)0x8589),
            OpExpBase2Ext = ((int)0x8791),
            Source3AlphaNv = ((int)0x858b),
            Texture10 = ((int)0x84ca),
            ProxyTextureRectangleNv = ((int)0x84f7),
            Rgba32iExt = ((int)0x8d82),
            InvariantDatatypeExt = ((int)0x87eb),
            Texture24Arb = ((int)0x84d8),
            Texture19 = ((int)0x84d3),
            ActiveStencilFaceExt = ((int)0x8911),
            ImageRotateOriginXHp = ((int)0x815a),
            DynamicCopy = ((int)0x88ea),
            CurrentFogCoordinateExt = ((int)0x8453),
            TextureCoordArrayBufferBinding = ((int)0x889a),
            Matrix5Nv = ((int)0x8635),
            FogFuncPointsSgis = ((int)0x812b),
            Sampler1dArb = ((int)0x8b5d),
            VertexAttribArray13Nv = ((int)0x865d),
            SmoothPointSizeGranularity = ((int)0x0b13),
            NegativeOneExt = ((int)0x87df),
            TextureColorTableSgi = ((int)0x80bc),
            GreenScale = ((int)0x0d18),
            TextureMatrix = ((int)0x0ba8),
            VertexAttribArray14Nv = ((int)0x865e),
            PrimitiveIdNv = ((int)0x8c7c),
            Modelview = ((int)0x1700),
            VertexArrayExt = ((int)0x8074),
            SampleCoverageValue = ((int)0x80aa),
            ShadingLanguageVersionArb = ((int)0x8b8c),
            MaxCubeMapTextureSizeExt = ((int)0x851c),
            BinormalArrayTypeExt = ((int)0x8440),
            MulAti = ((int)0x8964),
            UnsignedIntSampler2dArrayExt = ((int)0x8dd7),
            DotProductPassThroughNv = ((int)0x885b),
            ColorAttachment4Ext = ((int)0x8ce4),
            CurrentRasterNormalSgix = ((int)0x8406),
            IntSampler2dExt = ((int)0x8dca),
            UnsignedInt2101010Reversed = ((int)0x8368),
            ColorArrayPointer = ((int)0x8090),
            DiscardAti = ((int)0x8763),
            FloatClearColorValueNv = ((int)0x888d),
            ColorArraySize = ((int)0x8081),
            Spare0PlusSecondaryColorNv = ((int)0x8532),
            Gl4dColorTexture = ((int)0x0604),
            PixelCountAvailableNv = ((int)0x8867),
            RedIntegerExt = ((int)0x8d94),
            Color3BitPgi = ((int)0x00010000),
            Map1VertexAttrib134Nv = ((int)0x866d),
            TextureMagFilter = ((int)0x2800),
                Texture26Arb = ((int)0x84da),
            FeedbackBufferType = ((int)0x0df2),
            ConvolutionFilterBias = ((int)0x8015),
                Rgba4S3tc = ((int)0x83a3),
            Rgb5A1 = ((int)0x8057),
            MaxProgramNativeTemporaries = ((int)0x88a7),
            BufferSize = ((int)0x8764),
            RgbS3tc = ((int)0x83a0),
            Luminance = ((int)0x1909),
            VertexAttribArray11Nv = ((int)0x865b),
            GreenBits = ((int)0x0d53),
            Map1TextureCoord1 = ((int)0x0d93),
                PackCmykHintExt = ((int)0x800e),
                PixelMapIToBSize = ((int)0x0cb4),
            PointSmooth = ((int)0x0b10),
            RgbaIntegerModeExt = ((int)0x8d9e),
            VertexAttribArray7Nv = ((int)0x8657),
            Rgba12 = ((int)0x805a),
            DrawBuffer6Ati = ((int)0x882b),
            TransformFeedbackBufferNv = ((int)0x8c8e),
            TextureMinLod = ((int)0x813a),
            NearestClipmapNearestSgix = ((int)0x844d),
            DontCare = ((int)0x1100),
            ObjectActiveAttributesArb = ((int)0x8b89),
            UnsignedIntVec3Ext = ((int)0x8dc7),
            MaxProgramNativeAluInstructionsArb = ((int)0x880e),
            LightEnvModeSgix = ((int)0x8407),
            Luminance8Ext = ((int)0x8040),
            FragmentShaderDerivativeHintArb = ((int)0x8b8b),
            ResampleAverageOml = ((int)0x8988),
            CompareRToTexture = ((int)0x884e),
            SluminanceAlphaExt = ((int)0x8c44),
            NormalMapExt = ((int)0x8511),
            Rgb8 = ((int)0x8051),
            MaxOptimizedVertexShaderLocalsExt = ((int)0x87ce),
            AttribArraySizeNv = ((int)0x8623),
            MatrixPaletteArb = ((int)0x8840),
            ProxyTexture2dExt = ((int)0x8064),
            PrimaryColorExt = ((int)0x8577),
            ScissorTest = ((int)0x0c11),
            PackSkipVolumesSgis = ((int)0x8130),
            RgbFloat32Ati = ((int)0x8815),
            OneExt = ((int)0x87de),
            Sluminance8Alpha8 = ((int)0x8c45),
            UnsignedIntVec2Ext = ((int)0x8dc6),
            TypeRgbaFloatAti = ((int)0x8820),
            PixelTileGridDepthSgix = ((int)0x8144),
            Con30Ati = ((int)0x895f),
            Coeff = ((int)0x0a00),
            Nicest = ((int)0x1102),
            FogCoordinateExt = ((int)0x8451),
            SampleAlphaToMaskSgis = ((int)0x809e),
            IntSampler2dArrayExt = ((int)0x8dcf),
                TextureMaxLevel = ((int)0x813d),
            Gl422AverageExt = ((int)0x80ce),
            Rgb16iExt = ((int)0x8d89),
            Modelview1Arb = ((int)0x850a),
            Operand2RgbArb = ((int)0x8592),
            SecondaryColorArrayListStrideIbm = ((int)103087),
            LinearSharpenAlphaSgis = ((int)0x80ae),
            UnsignedNormalizedArb = ((int)0x8c17),
            Map2Normal = ((int)0x0db2),
            Texture23Arb = ((int)0x84d7),
            EvalTriangular2dNv = ((int)0x86c1),
            SecondaryColorArrayPointerExt = ((int)0x845d),
            Samples = ((int)0x80a9),
            DepthComponent24Arb = ((int)0x81a6),
            ProxyTexture4dSgis = ((int)0x8135),
            FogHint = ((int)0x0c54),
            MaxTrackMatrixStackDepthNv = ((int)0x862e),
            ZExt = ((int)0x87d7),
            Light5 = ((int)0x4005),
            Gl1passExt = ((int)0x80a1),
            ViewportBit = ((int)0x00000800),
            CurrentMatrixStackDepthNv = ((int)0x8640),
            EyePointSgis = ((int)0x81f4),
            RenderbufferGreenSizeExt = ((int)0x8d51),
            Ycrcb422Sgix = ((int)0x81bb),
            HistogramWidth = ((int)0x8026),
            UnsignedShort88Apple = ((int)0x85ba),
            UnsignedIntVec4Ext = ((int)0x8dc8),
            Texture23 = ((int)0x84d7),
            ShaderSourceLength = ((int)0x8b88),
            LightModelColorControl = ((int)0x81f8),
            TransposeModelviewMatrixArb = ((int)0x84e3),
            IndexTestFuncExt = ((int)0x81b6),
            DsdtMagNv = ((int)0x86f6),
            MinmaxSink = ((int)0x8030),
            StreamCopy = ((int)0x88e2),
            UpperLeft = ((int)0x8ca2),
            DrawBuffer14 = ((int)0x8833),
            PackAlignment = ((int)0x0d05),
            PixelFragmentAlphaSourceSgis = ((int)0x8355),
            OffsetProjectiveTextureRectangleNv = ((int)0x8852),
            OutputTextureCoord23Ext = ((int)0x87b4),
            Reg31Ati = ((int)0x8940),
            ObjectAttachedObjectsArb = ((int)0x8b85),
            Gl2d = ((int)0x0600),
            Green = ((int)0x1904),
            NumCompressedTextureFormats = ((int)0x86a2),
            Matrix27 = ((int)0x88db),
            CombinerComponentUsageNv = ((int)0x8544),
            SelectionBufferPointer = ((int)0x0df3),
                IntSamplerCubeExt = ((int)0x8dcc),
            OutputTextureCoord20Ext = ((int)0x87b1),
            PixelPackBufferBinding = ((int)0x88ed),
            CombinerScaleNv = ((int)0x8548),
            FragmentDepth = ((int)0x8452),
            ProgramErrorStringArb = ((int)0x8874),
            FramebufferIncompleteMissingAttachmentExt = ((int)0x8cd7),
            BumpNumTexUnitsAti = ((int)0x8777),
            SliceAccumSun = ((int)0x85cc),
            Luminance16Alpha16Ext = ((int)0x8048),
            ObjectInfoLogLengthArb = ((int)0x8b84),
            Matrix15 = ((int)0x88cf),
            EyeLinear = ((int)0x2400),
            PostConvolutionRedScale = ((int)0x801c),
            N3fV3f = ((int)0x2a25),
            MatrixMode = ((int)0x0ba0),
            PackSwapBytes = ((int)0x0d00),
            RenderbufferExt = ((int)0x8d41),
            MaxTextureLodBias = ((int)0x84fd),
            CmykaExt = ((int)0x800d),
            CompressedRgb = ((int)0x84ed),
            DrawBuffer5Ati = ((int)0x882a),
            TextureCubeMapNegativeXExt = ((int)0x8516),
            SamplerBufferExt = ((int)0x8dc2),
            MaxProgramAttribs = ((int)0x88ad),
            Intensity32iExt = ((int)0x8d85),
            SecondaryColorArray = ((int)0x845e),
            SmoothLineWidthRange = ((int)0x0b22),
                TangentArrayExt = ((int)0x8439),
            T2fC4ubV3f = ((int)0x2a29),
            FloatMat2 = ((int)0x8b5a),
            FloatMat3 = ((int)0x8b5b),
            Repeat = ((int)0x2901),
            Lequal = ((int)0x0203),
            GeometryDeformationSgix = ((int)0x8194),
            LuminanceAlpha32iExt = ((int)0x8d87),
            Rgba12Ext = ((int)0x805a),
            AccumAlphaBits = ((int)0x0d5b),
            TextureClipmapFrameSgix = ((int)0x8172),
            SignedAlphaNv = ((int)0x8705),
            QuadMeshSun = ((int)0x8614),
            PolygonOffsetFactorExt = ((int)0x8038),
            TextureLodBias = ((int)0x8501),
            CombineAlphaExt = ((int)0x8572),
            TransposeCurrentMatrixArb = ((int)0x88b7),
            BlendSrcAlpha = ((int)0x80cb),
            UnpackCmykHintExt = ((int)0x800f),
            StencilTest = ((int)0x0b90),
            CurrentTextureCoords = ((int)0x0b03),
            TextureCompareModeArb = ((int)0x884c),
            OpMinExt = ((int)0x878b),
            Gl2xBitAti = ((int)0x00000001),
            NativeGraphicsBeginHintPgi = ((int)0x1a203),
                TextureWrapT = ((int)0x2803),
            CurrentRasterIndex = ((int)0x0b05),
            Matrix20 = ((int)0x88d4),
            Matrix30 = ((int)0x88de),
                VertexShaderInstructionsExt = ((int)0x87cf),
            Luminance16Alpha16 = ((int)0x8048),
            TransposeProjectionMatrix = ((int)0x84e4),
            StencilBackRef = ((int)0x8ca3),
            Texture9 = ((int)0x84c9),
                GeometryShaderExt = ((int)0x8dd9),
            Back = ((int)0x0405),
            LinkStatus = ((int)0x8b82),
            FramebufferExt = ((int)0x8d40),
            Intensity12 = ((int)0x804c),
            FragmentMaterialExt = ((int)0x8349),
            T2fN3fV3f = ((int)0x2a2b),
            PixelSubsample4242Sgix = ((int)0x85a4),
            TextureCoordArrayExt = ((int)0x8078),
            Combiner7Nv = ((int)0x8557),
            VertexStream1Ati = ((int)0x876d),
            Modelview3Arb = ((int)0x8723),
            Source1AlphaArb = ((int)0x8589),
            BoolVec4Arb = ((int)0x8b59),
            PointSize = ((int)0x0b11),
            IndexShift = ((int)0x0d12),
            LinearClipmapLinearSgix = ((int)0x8170),
            ProxyTexture2dStackMesax = ((int)0x875c),
            CombinerCdDotProductNv = ((int)0x8546),
            BackRight = ((int)0x0403),
            ClientVertexArrayBit = ((int)0x00000002),
            Operand1AlphaArb = ((int)0x8599),
            TextureHiSizeNv = ((int)0x871b),
            MaxEvalOrder = ((int)0x0d30),
            PackSkipPixels = ((int)0x0d04),
            Intensity4Ext = ((int)0x804a),
                MaxAsyncReadPixelsSgix = ((int)0x8361),
            NormalArrayStride = ((int)0x807f),
            PixelMapBToBSize = ((int)0x0cb8),
            MaxProgramAluInstructionsArb = ((int)0x880b),
            MaxElementsVerticesExt = ((int)0x80e8),
            FloatRgNv = ((int)0x8881),
            ProgramLength = ((int)0x8627),
            MapTessellationNv = ((int)0x86c2),
            PostColorMatrixBlueBias = ((int)0x80ba),
                SrgbAlphaExt = ((int)0x8c42),
            EyeRadialNv = ((int)0x855b),
            BgraIntegerExt = ((int)0x8d9b),
            PixelTexGenQRoundSgix = ((int)0x8185),
            SharpenTextureFuncPointsSgis = ((int)0x80b0),
            QueryResultAvailable = ((int)0x8867),
            QuadLuminance8Sgis = ((int)0x8121),
            ShadingLanguageVersion = ((int)0x8b8c),
            MaxCombinedTextureImageUnits = ((int)0x8b4d),
            CompareRToTextureArb = ((int)0x884e),
            RedBias = ((int)0x0d15),
            CurrentBit = ((int)0x00000001),
            SecondaryColorNv = ((int)0x852d),
            Byte = ((int)0x1400),
            ConvolutionHintSgix = ((int)0x8316),
            CoordReplace = ((int)0x8862),
            Matrix17 = ((int)0x88d1),
            BgrIntegerExt = ((int)0x8d9a),
            BoolVec2 = ((int)0x8b57),
            Texture3Arb = ((int)0x84c3),
            VertexPreclipHintSgix = ((int)0x83ef),
            ReferencePlaneEquationSgix = ((int)0x817e),
            CurrentColor = ((int)0x0b00),
            Operand0RgbExt = ((int)0x8590),
            Luminance4Alpha4Ext = ((int)0x8043),
            OneMinusDstColor = ((int)0x0307),
            ProxyTextureCubeMap = ((int)0x851b),
            HalfFloatNv = ((int)0x140b),
            Map1GridSegments = ((int)0x0dd1),
            VertexStream4Ati = ((int)0x8770),
            ScaleByTwoNv = ((int)0x853e),
            TextureBorder = ((int)0x1005),
            SampleBuffers = ((int)0x80a8),
            Matrix2 = ((int)0x88c2),
            VariableANv = ((int)0x8523),
            Matrix0 = ((int)0x88c0),
            Matrix1 = ((int)0x88c1),
            Matrix6 = ((int)0x88c6),
            Matrix7 = ((int)0x88c7),
            BlueIntegerExt = ((int)0x8d96),
            Matrix5 = ((int)0x88c5),
            UnsignedShort88RevMesa = ((int)0x85bb),
            MaxProgramNativeInstructions = ((int)0x88a3),
            QuadStrip = ((int)0x0008),
            DepthComponent24 = ((int)0x81a6),
            ClientActiveTextureArb = ((int)0x84e1),
            Gl2pass0Ext = ((int)0x80a2),
            SharedTexturePaletteExt = ((int)0x81fb),
            DependentRgbTextureCubeMapNv = ((int)0x885a),
            WriteOnlyArb = ((int)0x88b9),
            FramebufferAttachmentTextureLevelExt = ((int)0x8cd2),
            DepthFunc = ((int)0x0b74),
            Front = ((int)0x0404),
            CompressedRgbFxt13dfx = ((int)0x86b0),
            V3f = ((int)0x2a21),
            UnsignedShort4444Rev = ((int)0x8365),
            Map2VertexAttrib134Nv = ((int)0x867d),
            Dot3RgbArb = ((int)0x86ae),
            PolygonOffsetExt = ((int)0x8037),
            Operand3RgbNv = ((int)0x8593),
            ObjectBufferUsageAti = ((int)0x8765),
            DrawBuffer6Arb = ((int)0x882b),
            AuxBuffers = ((int)0x0c00),
                CompressedRedGreenRgtc2Ext = ((int)0x8dbd),
            GreenBitAti = ((int)0x00000002),
            FragmentProgramBindingNv = ((int)0x8873),
                PackResampleSgix = ((int)0x842c),
            Source0Rgb = ((int)0x8580),
            Map2Color4 = ((int)0x0db0),
            SpriteAxialSgix = ((int)0x814c),
            BufferMapPointer = ((int)0x88bd),
            VertexStream6Ati = ((int)0x8772),
            ClientAttribStackDepth = ((int)0x0bb1),
            ObjectCompileStatusArb = ((int)0x8b81),
            TextureBindingRectangleNv = ((int)0x84f6),
            MaxActiveLightsSgix = ((int)0x8405),
            DsBiasNv = ((int)0x8716),
            VertexProgramParameterBufferNv = ((int)0x8da2),
            VariableCNv = ((int)0x8525),
            SampleMaskExt = ((int)0x80a0),
                MaxVertexShaderLocalsExt = ((int)0x87c9),
            Modelview10Arb = ((int)0x872a),
            MultisampleFilterHintNv = ((int)0x8534),
            TransformHintApple = ((int)0x85b1),
            Depth32fStencil8Nv = ((int)0x8dac),
            PostColorMatrixGreenBias = ((int)0x80b9),
            PackSkipRows = ((int)0x0d03),
            DepthBufferFloatModeNv = ((int)0x8daf),
            PackResampleOml = ((int)0x8984),
            PixelMapIToISize = ((int)0x0cb0),
            FogCoordinateArrayBufferBindingArb = ((int)0x889d),
            LinearMipmapNearest = ((int)0x2701),
            FogBit = ((int)0x00000080),
            TextureCoordArrayTypeExt = ((int)0x8089),
            R5G6B5A8IccSgix = ((int)0x8467),
            Con28Ati = ((int)0x895d),
            MaxTextureImageUnits = ((int)0x8872),
            ProgramBinding = ((int)0x8677),
            DepthComponent32fNv = ((int)0x8dab),
            Rgba8Ext = ((int)0x8058),
            FogCoordinateArrayListStrideIbm = ((int)103086),
            Minmax = ((int)0x802e),
            EdgeFlagArrayBufferBinding = ((int)0x889b),
            Con9Ati = ((int)0x894a),
            DynamicDraw = ((int)0x88e8),
            EvalVertexAttrib7Nv = ((int)0x86cd),
            AsyncTexImageSgix = ((int)0x835c),
            Modelview19Arb = ((int)0x8733),
            Gl4pass3Sgis = ((int)0x80a7),
            OffsetHiloTexture2dNv = ((int)0x8854),
            SamplerCubeShadowExt = ((int)0x8dc5),
            Previous = ((int)0x8578),
                Equal = ((int)0x0202),
            VertexAttribArray12Nv = ((int)0x865c),
            VariableENv = ((int)0x8527),
            SpotExponent = ((int)0x1205),
            Operand0AlphaExt = ((int)0x8598),
            IndexArrayListIbm = ((int)103073),
            MaxGeneralCombinersNv = ((int)0x854d),
            DynamicAti = ((int)0x8761),
            Gl4pass2Ext = ((int)0x80a6),
            Sampler2dShadowArb = ((int)0x8b62),
            VertexArrayRangeWithoutFlushNv = ((int)0x8533),
            MaxConvolutionWidth = ((int)0x801a),
            PixelTileBestAlignmentSgix = ((int)0x813e),
            BufferMapped = ((int)0x88bc),
            VertexStream3Ati = ((int)0x876f),
            BitmapToken = ((int)0x0704),
            TextureClipmapOffsetSgix = ((int)0x8173),
            HistogramSink = ((int)0x802d),
            ProxyPostColorMatrixColorTable = ((int)0x80d5),
            BufferMappedArb = ((int)0x88bc),
                PixelFragmentRgbSourceSgis = ((int)0x8354),
            EvalVertexAttrib11Nv = ((int)0x86d1),
            ShadeModel = ((int)0x0b54),
            FogOffsetSgix = ((int)0x8198),
            Sampler3dArb = ((int)0x8b5f),
            PointSizeRange = ((int)0x0b12),
            DrawBuffer12Ati = ((int)0x8831),
            DotProductAffineDepthReplaceNv = ((int)0x885d),
            ElementArrayBufferArb = ((int)0x8893),
            Matrix26 = ((int)0x88da),
            LinesAdjacencyExt = ((int)0x000a),
            Map1GridDomain = ((int)0x0dd0),
            ConstantColor0Nv = ((int)0x852a),
            MaxProgramNativeTexInstructionsArb = ((int)0x880f),
            PixelCounterBitsNv = ((int)0x8864),
            OpCrossProductExt = ((int)0x8797),
            FragmentNormalExt = ((int)0x834a),
            TransformFeedbackBufferModeNv = ((int)0x8c7f),
            FragmentProgramParameterBufferNv = ((int)0x8da4),
            Sampler2dShadow = ((int)0x8b62),
            VertexArrayStrideExt = ((int)0x807c),
            ProgramTemporaries = ((int)0x88a4),
            MapAttribVOrderNv = ((int)0x86c4),
            TextureCubeMapPositiveXArb = ((int)0x8515),
            DrawBuffer5Arb = ((int)0x882a),
            VertexAttribArray10Nv = ((int)0x865a),
            Clear = ((int)0x1500),
            UnpackSkipVolumesSgis = ((int)0x8132),
            MaxElementsVertices = ((int)0x80e8),
            PixelTexGenAlphaReplaceSgix = ((int)0x8187),
            VertexStream5Ati = ((int)0x8771),
            QuadTextureSelectSgis = ((int)0x8125),
            PreferDoublebufferHintPgi = ((int)0x1a1f8),
            TextureDeformationSgix = ((int)0x8195),
                Modelview14Arb = ((int)0x872e),
            ClampVertexColorArb = ((int)0x891a),
            Modelview11Arb = ((int)0x872b),
            IntensityIccSgix = ((int)0x8464),
            EdgeFlagArrayListIbm = ((int)103075),
            AverageHp = ((int)0x8160),
            PixelPackBufferBindingArb = ((int)0x88ed),
            Depth = ((int)0x1801),
            VertexStream0Ati = ((int)0x876c),
            Sampler2dArrayShadowExt = ((int)0x8dc4),
                Map2VertexAttrib64Nv = ((int)0x8676),
            MatrixIndexArrayArb = ((int)0x8844),
            TextureCoordArrayStrideExt = ((int)0x808a),
            MaxGeometryVaryingComponentsExt = ((int)0x8ddd),
            BlendEquationRgb = ((int)0x8009),
            LinearDetailSgis = ((int)0x8097),
            LuminanceAlphaIccSgix = ((int)0x8465),
            TextureLodBiasSSgix = ((int)0x818e),
            TextureCubeMapNegativeX = ((int)0x8516),
            TextureCubeMapNegativeY = ((int)0x8518),
            TextureCubeMapNegativeZ = ((int)0x851a),
            BlendDst = ((int)0x0be0),
            FragmentColorMaterialFaceSgix = ((int)0x8402),
            ReadOnly = ((int)0x88b8),
                DrawBuffer11Ati = ((int)0x8830),
            IgnoreBorderHp = ((int)0x8150),
            CombinerAbDotProductNv = ((int)0x8545),
            PolygonOffsetUnits = ((int)0x2a00),
            ColorAttachment10Ext = ((int)0x8cea),
            TextureCubeMapPositiveZArb = ((int)0x8519),
            BlueMinClampIngr = ((int)0x8562),
            TextureResident = ((int)0x8067),
            WeightArrayArb = ((int)0x86ad),
            Rgba8 = ((int)0x8058),
                PixelUnpackBuffer = ((int)0x88ec),
            VertexStream7Ati = ((int)0x8773),
            Rgba2 = ((int)0x8055),
            Luminance8uiExt = ((int)0x8d80),
            StencilRef = ((int)0x0b97),
            EvalVertexAttrib4Nv = ((int)0x86ca),
            DsdtMagIntensityNv = ((int)0x86dc),
            Combiner1Nv = ((int)0x8551),
            Rgba4 = ((int)0x8056),
            ProxyTexture3d = ((int)0x8070),
            ProxyTexture2d = ((int)0x8064),
            ProxyTexture1d = ((int)0x8063),
            PostConvolutionGreenBias = ((int)0x8021),
            PolygonOffsetFactor = ((int)0x8038),
        }

        public enum ArbImaging
        {
            PostConvolutionAlphaScale = ((int)0x801f),
            ProxyPostColorMatrixColorTable = ((int)0x80d5),
            ConvolutionBorderMode = ((int)0x8013),
            PostColorMatrixAlphaBias = ((int)0x80bb),
            FuncAdd = ((int)0x8006),
            ColorTableFormat = ((int)0x80d8),
            HistogramRedSize = ((int)0x8028),
            ProxyColorTable = ((int)0x80d3),
            PostColorMatrixGreenBias = ((int)0x80b9),
            ConstantColor = ((int)0x8001),
            PostConvolutionBlueScale = ((int)0x801e),
            ConvolutionHeight = ((int)0x8019),
            MaxConvolutionWidth = ((int)0x801a),
            ReplicateBorder = ((int)0x8153),
            TableTooLarge = ((int)0x8031),
            ColorMatrixStackDepth = ((int)0x80b2),
            PostConvolutionColorTable = ((int)0x80d1),
            PostColorMatrixBlueBias = ((int)0x80ba),
            PostColorMatrixColorTable = ((int)0x80d2),
            Convolution1d = ((int)0x8010),
            HistogramFormat = ((int)0x8027),
            ConstantBorder = ((int)0x8151),
            Reduce = ((int)0x8016),
            PostConvolutionGreenBias = ((int)0x8021),
            MinmaxFormat = ((int)0x802f),
            HistogramGreenSize = ((int)0x8029),
            HistogramLuminanceSize = ((int)0x802c),
            FuncSubtract = ((int)0x800a),
            HistogramAlphaSize = ((int)0x802b),
            BlendEquation = ((int)0x8009),
            ColorTableWidth = ((int)0x80d9),
            Min = ((int)0x8007),
            HistogramSink = ((int)0x802d),
            ColorMatrix = ((int)0x80b1),
            ColorTableAlphaSize = ((int)0x80dd),
            OneMinusConstantColor = ((int)0x8002),
            ConvolutionWidth = ((int)0x8018),
            ColorTable = ((int)0x80d0),
            PostColorMatrixRedBias = ((int)0x80b8),
            ColorTableLuminanceSize = ((int)0x80de),
            FuncReverseSubtract = ((int)0x800b),
            Histogram = ((int)0x8024),
            PostConvolutionRedScale = ((int)0x801c),
            OneMinusConstantAlpha = ((int)0x8004),
            MaxColorMatrixStackDepth = ((int)0x80b3),
            Minmax = ((int)0x802e),
            HistogramWidth = ((int)0x8026),
            ColorTableScale = ((int)0x80d6),
            PostConvolutionAlphaBias = ((int)0x8023),
            Max = ((int)0x8008),
            PostColorMatrixGreenScale = ((int)0x80b5),
            PostConvolutionRedBias = ((int)0x8020),
            ConvolutionFilterScale = ((int)0x8014),
            ProxyPostConvolutionColorTable = ((int)0x80d4),
            Separable2d = ((int)0x8012),
            PostConvolutionBlueBias = ((int)0x8022),
            MaxConvolutionHeight = ((int)0x801b),
            PostColorMatrixBlueScale = ((int)0x80b6),
            ColorTableRedSize = ((int)0x80da),
            ColorTableBias = ((int)0x80d7),
            ProxyHistogram = ((int)0x8025),
            PostColorMatrixRedScale = ((int)0x80b4),
            Convolution2d = ((int)0x8011),
            BlendColor = ((int)0x8005),
            MinmaxSink = ((int)0x8030),
            ConstantAlpha = ((int)0x8003),
            ColorTableIntensitySize = ((int)0x80df),
            ColorTableGreenSize = ((int)0x80db),
            ColorTableBlueSize = ((int)0x80dc),
            ConvolutionFormat = ((int)0x8017),
            ConvolutionFilterBias = ((int)0x8015),
            PostConvolutionGreenScale = ((int)0x801d),
            PostColorMatrixAlphaScale = ((int)0x80b7),
            ConvolutionBorderColor = ((int)0x8154),
            HistogramBlueSize = ((int)0x802a),
        }

        public enum TextureEnvModeCombine
        {
            Dot3Rgba = ((int)0x86af),
            Dot3Rgb = ((int)0x86ae),
            Add = ((int)0x0104),
            Modulate = ((int)0x2100),
            Replace = ((int)0x1e01),
            Subtract = ((int)0x84e7),
            AddSigned = ((int)0x8574),
            Interpolate = ((int)0x8575),
        }

        public enum TextureEnvModeSource
        {
            Texture5 = ((int)0x84c5),
            Texture3 = ((int)0x84c3),
            Texture30 = ((int)0x84de),
            Texture = ((int)0x1702),
            Texture12 = ((int)0x84cc),
            Texture13 = ((int)0x84cd),
            Texture6 = ((int)0x84c6),
            Previous = ((int)0x8578),
            Texture16 = ((int)0x84d0),
            Texture17 = ((int)0x84d1),
            Texture14 = ((int)0x84ce),
            Texture15 = ((int)0x84cf),
            PrimaryColor = ((int)0x8577),
            Texture28 = ((int)0x84dc),
            Texture10 = ((int)0x84ca),
            Texture11 = ((int)0x84cb),
            Texture8 = ((int)0x84c8),
            Texture18 = ((int)0x84d2),
            Texture19 = ((int)0x84d3),
            Texture2 = ((int)0x84c2),
            Texture31 = ((int)0x84df),
            Texture26 = ((int)0x84da),
            Texture27 = ((int)0x84db),
            Texture24 = ((int)0x84d8),
            Texture25 = ((int)0x84d9),
            Texture22 = ((int)0x84d6),
            Texture23 = ((int)0x84d7),
            Texture20 = ((int)0x84d4),
            Texture21 = ((int)0x84d5),
            Texture0 = ((int)0x84c0),
            Texture29 = ((int)0x84dd),
            Texture7 = ((int)0x84c7),
            Constant = ((int)0x8576),
            Texture1 = ((int)0x84c1),
            Texture4 = ((int)0x84c4),
            Texture9 = ((int)0x84c9),
        }

        public enum TextureEnvModeOperandRgb
        {
            OneMinusSrcColor = ((int)0x0301),
            SrcColor = ((int)0x0300),
            OneMinusSrcAlpha = ((int)0x0303),
            SrcAlpha = ((int)0x0302),
        }

        public enum TextureEnvModeOperandAlpha
        {
            OneMinusSrcAlpha = ((int)0x0303),
            SrcAlpha = ((int)0x0302),
        }

        public enum TextureEnvModeScale
        {
            Two = ((int)2),
            One = ((int)1),
            Four = ((int)4),
        }

        public enum TextureUnit
        {
            Texture17 = ((int)0x84d1),
            Texture8 = ((int)0x84c8),
            Texture10 = ((int)0x84ca),
            Texture12 = ((int)0x84cc),
            Texture13 = ((int)0x84cd),
            Texture9 = ((int)0x84c9),
            Texture11 = ((int)0x84cb),
            Texture29 = ((int)0x84dd),
            Texture1 = ((int)0x84c1),
            Texture26 = ((int)0x84da),
            Texture18 = ((int)0x84d2),
            Texture19 = ((int)0x84d3),
            Texture22 = ((int)0x84d6),
            Texture23 = ((int)0x84d7),
            Texture6 = ((int)0x84c6),
            Texture21 = ((int)0x84d5),
            Texture7 = ((int)0x84c7),
            Texture5 = ((int)0x84c5),
            Texture28 = ((int)0x84dc),
            Texture2 = ((int)0x84c2),
            Texture3 = ((int)0x84c3),
            Texture25 = ((int)0x84d9),
            Texture30 = ((int)0x84de),
            Texture31 = ((int)0x84df),
            Texture0 = ((int)0x84c0),
            Texture27 = ((int)0x84db),
            Texture24 = ((int)0x84d8),
            Texture16 = ((int)0x84d0),
            Texture15 = ((int)0x84cf),
            Texture14 = ((int)0x84ce),
            Texture20 = ((int)0x84d4),
            Texture4 = ((int)0x84c4),
        }

        public enum TextureCompareMode
        {
            CompareRToTexture = ((int)0x884e),
        }

        public enum FogPointerType
        {
            Float = ((int)0x1406),
            Double = ((int)0x140a),
        }

        public enum PointParameterName
        {
            PointFadeThresholdSize = ((int)0x8128),
            PointSizeMax = ((int)0x8127),
            PointDistanceAttenuation = ((int)0x8129),
            PointSizeMin = ((int)0x8126),
            PointSpriteCoordOrigin = ((int)0x8ca0),
        }

        public enum QueryTarget
        {
            SamplesPassed = ((int)0x8914),
        }

        public enum GetQueryParam
        {
            QueryCounterBits = ((int)0x8864),
            CurrentQuery = ((int)0x8865),
        }

        public enum GetQueryObjectParam
        {
            QueryResultAvailable = ((int)0x8867),
            QueryResult = ((int)0x8866),
        }

        public enum BufferTarget
        {
            ArrayBuffer = ((int)0x8892),
            ElementArrayBuffer = ((int)0x8893),
            PixelUnpackBuffer = ((int)0x88ec),
            PixelPackBuffer = ((int)0x88eb),
        }

        public enum BufferUsageHint
        {
            StreamDraw = ((int)0x88e0),
            DynamicCopy = ((int)0x88ea),
            StaticDraw = ((int)0x88e4),
            StaticCopy = ((int)0x88e6),
            StaticRead = ((int)0x88e5),
            StreamCopy = ((int)0x88e2),
            DynamicDraw = ((int)0x88e8),
            DynamicRead = ((int)0x88e9),
            StreamRead = ((int)0x88e1),
        }

        public enum BufferAccess
        {
            WriteOnly = ((int)0x88b9),
            ReadWrite = ((int)0x88ba),
            ReadOnly = ((int)0x88b8),
        }

        public enum BufferParameterName
        {
            BufferUsage = ((int)0x8765),
            BufferSize = ((int)0x8764),
            BufferAccess = ((int)0x88bb),
            BufferMapped = ((int)0x88bc),
        }

        public enum BufferPointer
        {
            BufferMapPointer = ((int)0x88bd),
        }

        public enum ShaderType
        {
            GeometryShaderExt = ((int)0x8dd9),
            FragmentShader = ((int)0x8b30),
            VertexShader = ((int)0x8b31),
        }

        public enum ActiveUniformType
        {
            FloatMat4x2 = ((int)0x8b69),
            FloatMat4x3 = ((int)0x8b6a),
            Bool = ((int)0x8b56),
            IntVec4 = ((int)0x8b55),
            Sampler1d = ((int)0x8b5d),
            SamplerCube = ((int)0x8b60),
            FloatMat3x4 = ((int)0x8b68),
            FloatMat2x3 = ((int)0x8b65),
            Sampler2d = ((int)0x8b5e),
            FloatMat2x4 = ((int)0x8b66),
            Sampler1dShadow = ((int)0x8b61),
            BoolVec2 = ((int)0x8b57),
            FloatMat4 = ((int)0x8b5c),
            FloatMat2 = ((int)0x8b5a),
            FloatMat3 = ((int)0x8b5b),
            FloatMat3x2 = ((int)0x8b67),
            Sampler2dShadow = ((int)0x8b62),
            FloatVec2 = ((int)0x8b50),
            FloatVec3 = ((int)0x8b51),
            Int = ((int)0x1404),
            BoolVec4 = ((int)0x8b59),
            Sampler3d = ((int)0x8b5f),
            FloatVec4 = ((int)0x8b52),
            Float = ((int)0x1406),
            BoolVec3 = ((int)0x8b58),
            IntVec2 = ((int)0x8b53),
            IntVec3 = ((int)0x8b54),
        }

        public enum ActiveAttribType
        {
            FloatMat2 = ((int)0x8b5a),
            Float = ((int)0x1406),
            FloatVec2 = ((int)0x8b50),
            FloatVec3 = ((int)0x8b51),
            FloatMat3 = ((int)0x8b5b),
            FloatVec4 = ((int)0x8b52),
            FloatMat4 = ((int)0x8b5c),
        }

        public enum VertexAttribPointerType
        {
            UnsignedByte = ((int)0x1401),
            Byte = ((int)0x1400),
            UnsignedInt = ((int)0x1405),
            Short = ((int)0x1402),
            Int = ((int)0x1404),
            Float = ((int)0x1406),
            Double = ((int)0x140a),
            UnsignedShort = ((int)0x1403),
        }

        public enum ShaderParameter
        {
            DeleteStatus = ((int)0x8b80),
            InfoLogLength = ((int)0x8b84),
            CompileStatus = ((int)0x8b81),
            ShaderSourceLength = ((int)0x8b88),
            ShaderType = ((int)0x8b4f),
        }

        public enum ProgramParameter
        {
            ActiveAttributeMaxLength = ((int)0x8b8a),
            DeleteStatus = ((int)0x8b80),
            ActiveUniformMaxLength = ((int)0x8b87),
            AttachedShaders = ((int)0x8b85),
            ActiveUniforms = ((int)0x8b86),
            InfoLogLength = ((int)0x8b84),
            ValidateStatus = ((int)0x8b83),
            ActiveAttributes = ((int)0x8b89),
            LinkStatus = ((int)0x8b82),
        }

        public enum VertexAttribParameter
        {
            ArrayEnabled = ((int)0x8622),
            ArrayNormalized = ((int)0x886a),
            ArraySize = ((int)0x8623),
            CurrentVertexAttrib = ((int)0x8626),
            ArrayStride = ((int)0x8624),
            ArrayType = ((int)0x8625),
        }

        public enum VertexAttribPointerParameter
        {
            ArrayPointer = ((int)0x8645),
        }

        public enum DrawBuffersEnum
        {
            FrontRight = ((int)0x0401),
            BackLeft = ((int)0x0402),
            BackRight = ((int)0x0403),
            Aux1 = ((int)0x040a),
            Aux0 = ((int)0x0409),
            Aux3 = ((int)0x040c),
            Aux2 = ((int)0x040b),
            FrontLeft = ((int)0x0400),
            None = ((int)0),
        }

        public enum PointSpriteCoordOriginParameter
        {
            UpperLeft = ((int)0x8ca2),
            LowerLeft = ((int)0x8ca1),
        }

        public enum TextureEnvModePointSprite
        {
            True = ((int)1),
            False = ((int)0),
        }

        public enum ArbMultitexture
        {
            Texture17Arb = ((int)0x84d1),
            MaxTextureUnitsArb = ((int)0x84e2),
            Texture29Arb = ((int)0x84dd),
            Texture1Arb = ((int)0x84c1),
            Texture2Arb = ((int)0x84c2),
            Texture26Arb = ((int)0x84da),
            Texture19Arb = ((int)0x84d3),
            Texture6Arb = ((int)0x84c6),
            ActiveTextureArb = ((int)0x84e0),
            Texture23Arb = ((int)0x84d7),
            Texture7Arb = ((int)0x84c7),
            Texture13Arb = ((int)0x84cd),
            Texture16Arb = ((int)0x84d0),
            Texture30Arb = ((int)0x84de),
            Texture28Arb = ((int)0x84dc),
            Texture25Arb = ((int)0x84d9),
            Texture4Arb = ((int)0x84c4),
            Texture15Arb = ((int)0x84cf),
            Texture18Arb = ((int)0x84d2),
            Texture3Arb = ((int)0x84c3),
            Texture22Arb = ((int)0x84d6),
            Texture0Arb = ((int)0x84c0),
            Texture12Arb = ((int)0x84cc),
            Texture21Arb = ((int)0x84d5),
            Texture24Arb = ((int)0x84d8),
            Texture11Arb = ((int)0x84cb),
            Texture14Arb = ((int)0x84ce),
            Texture8Arb = ((int)0x84c8),
            Texture20Arb = ((int)0x84d4),
            Texture31Arb = ((int)0x84df),
            ClientActiveTextureArb = ((int)0x84e1),
            Texture9Arb = ((int)0x84c9),
            Texture5Arb = ((int)0x84c5),
            Texture10Arb = ((int)0x84ca),
            Texture27Arb = ((int)0x84db),
        }

        public enum ArbTransposeMatrix
        {
            TransposeProjectionMatrixArb = ((int)0x84e4),
            TransposeTextureMatrixArb = ((int)0x84e5),
            TransposeModelviewMatrixArb = ((int)0x84e3),
            TransposeColorMatrixArb = ((int)0x84e6),
        }

        public enum ArbTextureEnvAdd
        {
        }

        public enum ArbTextureCubeMap
        {
            TextureCubeMapPositiveYArb = ((int)0x8517),
            ProxyTextureCubeMapArb = ((int)0x851b),
            TextureCubeMapPositiveZArb = ((int)0x8519),
            TextureCubeMapPositiveXArb = ((int)0x8515),
            TextureCubeMapNegativeYArb = ((int)0x8518),
            TextureBindingCubeMapArb = ((int)0x8514),
            TextureCubeMapArb = ((int)0x8513),
            MaxCubeMapTextureSizeArb = ((int)0x851c),
            TextureCubeMapNegativeZArb = ((int)0x851a),
            TextureCubeMapNegativeXArb = ((int)0x8516),
            ReflectionMapArb = ((int)0x8512),
            NormalMapArb = ((int)0x8511),
        }

        public enum ArbTextureCompression
        {
            CompressedRgbArb = ((int)0x84ed),
            TextureCompressedArb = ((int)0x86a1),
            CompressedIntensityArb = ((int)0x84ec),
            CompressedTextureFormatsArb = ((int)0x86a3),
            NumCompressedTextureFormatsArb = ((int)0x86a2),
            CompressedAlphaArb = ((int)0x84e9),
            TextureCompressionHintArb = ((int)0x84ef),
            CompressedLuminanceAlphaArb = ((int)0x84eb),
            TextureCompressedImageSizeArb = ((int)0x86a0),
            CompressedRgbaArb = ((int)0x84ee),
            CompressedLuminanceArb = ((int)0x84ea),
        }

        public enum ArbTextureBorderClamp
        {
            ClampToBorderArb = ((int)0x812d),
        }

        public enum ArbPointParameters
        {
            PointSizeMinArb = ((int)0x8126),
            PointDistanceAttenuationArb = ((int)0x8129),
            PointSizeMaxArb = ((int)0x8127),
            PointFadeThresholdSizeArb = ((int)0x8128),
        }

        public enum ArbVertexBlend
        {
            Modelview26Arb = ((int)0x873a),
            WeightArrayTypeArb = ((int)0x86a9),
            Modelview23Arb = ((int)0x8737),
            Modelview1Arb = ((int)0x850a),
            WeightArrayStrideArb = ((int)0x86aa),
            WeightArrayArb = ((int)0x86ad),
            Modelview2Arb = ((int)0x8722),
            Modelview14Arb = ((int)0x872e),
            Modelview15Arb = ((int)0x872f),
            Modelview3Arb = ((int)0x8723),
            Modelview21Arb = ((int)0x8735),
            Modelview27Arb = ((int)0x873b),
            ActiveVertexUnitsArb = ((int)0x86a5),
            Modelview7Arb = ((int)0x8727),
            Modelview9Arb = ((int)0x8729),
            Modelview12Arb = ((int)0x872c),
            Modelview20Arb = ((int)0x8734),
            Modelview18Arb = ((int)0x8732),
            MaxVertexUnitsArb = ((int)0x86a4),
            Modelview19Arb = ((int)0x8733),
            Modelview25Arb = ((int)0x8739),
            Modelview31Arb = ((int)0x873f),
            Modelview4Arb = ((int)0x8724),
            WeightArraySizeArb = ((int)0x86ab),
            Modelview24Arb = ((int)0x8738),
            VertexBlendArb = ((int)0x86a7),
            Modelview30Arb = ((int)0x873e),
            Modelview6Arb = ((int)0x8726),
            Modelview13Arb = ((int)0x872d),
            WeightArrayPointerArb = ((int)0x86ac),
            Modelview29Arb = ((int)0x873d),
            Modelview0Arb = ((int)0x1700),
            Modelview22Arb = ((int)0x8736),
            Modelview8Arb = ((int)0x8728),
            CurrentWeightArb = ((int)0x86a8),
            Modelview28Arb = ((int)0x873c),
            WeightSumUnityArb = ((int)0x86a6),
            Modelview11Arb = ((int)0x872b),
            Modelview17Arb = ((int)0x8731),
            Modelview16Arb = ((int)0x8730),
            Modelview5Arb = ((int)0x8725),
            Modelview10Arb = ((int)0x872a),
        }

        public enum ArbMatrixPalette
        {
            MatrixIndexArrayArb = ((int)0x8844),
            MatrixIndexArraySizeArb = ((int)0x8846),
            MaxMatrixPaletteStackDepthArb = ((int)0x8841),
            MaxPaletteMatricesArb = ((int)0x8842),
            MatrixIndexArrayTypeArb = ((int)0x8847),
            MatrixIndexArrayStrideArb = ((int)0x8848),
            MatrixIndexArrayPointerArb = ((int)0x8849),
            MatrixPaletteArb = ((int)0x8840),
            CurrentPaletteMatrixArb = ((int)0x8843),
            CurrentMatrixIndexArb = ((int)0x8845),
        }

        public enum ArbTextureEnvCombine
        {
            CombineRgbArb = ((int)0x8571),
            Source2AlphaArb = ((int)0x858a),
            Operand2AlphaArb = ((int)0x859a),
            Source0AlphaArb = ((int)0x8588),
            Operand0RgbArb = ((int)0x8590),
            SubtractArb = ((int)0x84e7),
            AddSignedArb = ((int)0x8574),
            Source2RgbArb = ((int)0x8582),
            Operand1AlphaArb = ((int)0x8599),
            RgbScaleArb = ((int)0x8573),
            Operand0AlphaArb = ((int)0x8598),
            Source0RgbArb = ((int)0x8580),
            CombineArb = ((int)0x8570),
            PreviousArb = ((int)0x8578),
            InterpolateArb = ((int)0x8575),
            ConstantArb = ((int)0x8576),
            Operand1RgbArb = ((int)0x8591),
            Operand2RgbArb = ((int)0x8592),
            PrimaryColorArb = ((int)0x8577),
            CombineAlphaArb = ((int)0x8572),
            Source1RgbArb = ((int)0x8581),
            Source1AlphaArb = ((int)0x8589),
        }

        public enum ArbTextureEnvCrossbar
        {
        }

        public enum ArbTextureEnvDot3
        {
            Dot3RgbArb = ((int)0x86ae),
            Dot3RgbaArb = ((int)0x86af),
        }

        public enum ArbTextureMirroredRepeat
        {
            MirroredRepeatArb = ((int)0x8370),
        }

        public enum ArbDepthTexture
        {
            DepthComponent24Arb = ((int)0x81a6),
            TextureDepthSizeArb = ((int)0x884a),
            DepthTextureModeArb = ((int)0x884b),
            DepthComponent16Arb = ((int)0x81a5),
            DepthComponent32Arb = ((int)0x81a7),
        }

        public enum ArbShadow
        {
            TextureCompareModeArb = ((int)0x884c),
            TextureCompareFuncArb = ((int)0x884d),
            CompareRToTextureArb = ((int)0x884e),
        }

        public enum ArbShadowAmbient
        {
            TextureCompareFailValueArb = ((int)0x80bf),
        }

        public enum ArbWindowPos
        {
        }

        public enum ArbVertexProgram
        {
            TransposeCurrentMatrixArb = ((int)0x88b7),
            VertexProgramTwoSideArb = ((int)0x8643),
            CurrentMatrixStackDepthArb = ((int)0x8640),
            ProgramErrorPositionArb = ((int)0x864b),
            MaxVertexAttribsArb = ((int)0x8869),
            ProgramErrorStringArb = ((int)0x8874),
            MaxProgramMatrixStackDepthArb = ((int)0x862e),
            MaxProgramMatricesArb = ((int)0x862f),
            ColorSumArb = ((int)0x8458),
            CurrentMatrixArb = ((int)0x8641),
            VertexProgramPointSizeArb = ((int)0x8642),
            ProgramFormatAsciiArb = ((int)0x8875),
        }

        public enum AssemblyProgramTargetArb
        {
            VertexProgram = ((int)0x8620),
            GeometryProgramNv = ((int)0x8c26),
            FragmentProgram = ((int)0x8804),
        }

        public enum AssemblyProgramFormatArb
        {
            ProgramFormatAsciiArb = ((int)0x8875),
        }

        public enum AssemblyProgramParameterArb
        {
            MaxProgramAttribs = ((int)0x88ad),
            MaxProgramLocalParameters = ((int)0x88b4),
            ProgramAluInstructionsArb = ((int)0x8805),
            ProgramAttribs = ((int)0x88ac),
            ProgramTemporaries = ((int)0x88a4),
            MaxProgramNativeAddressRegisters = ((int)0x88b3),
            ProgramNativeAluInstructionsArb = ((int)0x8808),
            MaxProgramNativeTexInstructionsArb = ((int)0x880f),
            MaxProgramTexIndirectionsArb = ((int)0x880d),
            ProgramParameters = ((int)0x88a8),
            ProgramNativeTemporaries = ((int)0x88a6),
            MaxProgramNativeTexIndirectionsArb = ((int)0x8810),
            ProgramNativeAttribs = ((int)0x88ae),
            ProgramAddressRegisters = ((int)0x88b0),
            ProgramUnderNativeLimits = ((int)0x88b6),
            ProgramNativeInstructions = ((int)0x88a2),
            MaxProgramParameters = ((int)0x88a9),
            MaxProgramEnvParameters = ((int)0x88b5),
            ProgramFormat = ((int)0x8876),
            MaxProgramTexInstructionsArb = ((int)0x880c),
            MaxProgramInstructions = ((int)0x88a1),
            ProgramTexIndirectionsArb = ((int)0x8807),
            ProgramTexInstructionsArb = ((int)0x8806),
            ProgramNativeParameters = ((int)0x88aa),
            ProgramBinding = ((int)0x8677),
            MaxProgramNativeTemporaries = ((int)0x88a7),
            MaxProgramNativeAttribs = ((int)0x88af),
            MaxProgramAddressRegisters = ((int)0x88b1),
            MaxProgramNativeParameters = ((int)0x88ab),
            ProgramNativeTexInstructionsArb = ((int)0x8809),
            ProgramNativeAddressRegisters = ((int)0x88b2),
            MaxProgramTemporaries = ((int)0x88a5),
            ProgramLength = ((int)0x8627),
            MaxProgramAluInstructionsArb = ((int)0x880b),
            MaxProgramNativeAluInstructionsArb = ((int)0x880e),
            MaxProgramNativeInstructions = ((int)0x88a3),
            ProgramNativeTexIndirectionsArb = ((int)0x880a),
            ProgramInstruction = ((int)0x88a0),
        }

        public enum AssemblyProgramStringParameterArb
        {
            ProgramString = ((int)0x8628),
        }

        public enum MatrixModeArb
        {
            Matrix23 = ((int)0x88d7),
            Matrix26 = ((int)0x88da),
            Matrix16 = ((int)0x88d0),
            Texture = ((int)0x1702),
            Matrix20 = ((int)0x88d4),
            Matrix30 = ((int)0x88de),
            Matrix10 = ((int)0x88ca),
            Matrix25 = ((int)0x88d9),
            Matrix15 = ((int)0x88cf),
            Matrix21 = ((int)0x88d5),
            Matrix31 = ((int)0x88df),
            Matrix11 = ((int)0x88cb),
            Matrix14 = ((int)0x88ce),
            Matrix8 = ((int)0x88c8),
            Matrix9 = ((int)0x88c9),
            Projection = ((int)0x1701),
            Matrix2 = ((int)0x88c2),
            Matrix3 = ((int)0x88c3),
            Matrix0 = ((int)0x88c0),
            Matrix28 = ((int)0x88dc),
            Matrix6 = ((int)0x88c6),
            Matrix7 = ((int)0x88c7),
            Matrix4 = ((int)0x88c4),
            Matrix5 = ((int)0x88c5),
            Color = ((int)0x1800),
            Matrix27 = ((int)0x88db),
            Matrix17 = ((int)0x88d1),
            Matrix29 = ((int)0x88dd),
            Matrix19 = ((int)0x88d3),
            Matrix18 = ((int)0x88d2),
            Matrix13 = ((int)0x88cd),
            Matrix1 = ((int)0x88c1),
            Modelview = ((int)0x1700),
            Matrix24 = ((int)0x88d8),
            Matrix22 = ((int)0x88d6),
            Matrix12 = ((int)0x88cc),
        }

        public enum VertexAttribParameterArb
        {
            ArrayEnabled = ((int)0x8622),
            ArrayNormalized = ((int)0x886a),
            ArraySize = ((int)0x8623),
            CurrentVertexAttrib = ((int)0x8626),
            ArrayStride = ((int)0x8624),
            ArrayType = ((int)0x8625),
        }

        public enum VertexAttribPointerParameterArb
        {
            ArrayPointer = ((int)0x8645),
        }

        public enum VertexAttribPointerTypeArb
        {
            UnsignedByte = ((int)0x1401),
            Byte = ((int)0x1400),
            UnsignedInt = ((int)0x1405),
            Short = ((int)0x1402),
            Int = ((int)0x1404),
            Float = ((int)0x1406),
            Double = ((int)0x140a),
            UnsignedShort = ((int)0x1403),
        }

        public enum ArbFragmentProgram
        {
            MaxTextureImageUnitsArb = ((int)0x8872),
            MaxTextureCoordsArb = ((int)0x8871),
        }

        public enum BufferTargetArb
        {
            ArrayBuffer = ((int)0x8892),
            ElementArrayBuffer = ((int)0x8893),
        }

        public enum BufferUsageArb
        {
            StreamDraw = ((int)0x88e0),
            DynamicCopy = ((int)0x88ea),
            StaticDraw = ((int)0x88e4),
            StaticCopy = ((int)0x88e6),
            StaticRead = ((int)0x88e5),
            StreamCopy = ((int)0x88e2),
            DynamicDraw = ((int)0x88e8),
            DynamicRead = ((int)0x88e9),
            StreamRead = ((int)0x88e1),
        }

        public enum BufferAccessArb
        {
            WriteOnly = ((int)0x88b9),
            ReadWrite = ((int)0x88ba),
            ReadOnly = ((int)0x88b8),
        }

        public enum BufferParameterNameArb
        {
            BufferUsage = ((int)0x8765),
            BufferSize = ((int)0x8764),
            BufferAccess = ((int)0x88bb),
            BufferMapped = ((int)0x88bc),
        }

        public enum BufferPointerNameArb
        {
            BufferMapPointer = ((int)0x88bd),
        }

        public enum ArbVertexBufferObject
        {
            ElementArrayBufferBindingArb = ((int)0x8895),
            ArrayBufferBindingArb = ((int)0x8894),
            VertexArrayBufferBindingArb = ((int)0x8896),
            TextureCoordArrayBufferBindingArb = ((int)0x889a),
            ReadOnlyArb = ((int)0x88b8),
            DynamicDrawArb = ((int)0x88e8),
            BufferSizeArb = ((int)0x8764),
            SecondaryColorArrayBufferBindingArb = ((int)0x889c),
            BufferUsageArb = ((int)0x8765),
            BufferAccessArb = ((int)0x88bb),
            StreamDrawArb = ((int)0x88e0),
            DynamicCopyArb = ((int)0x88ea),
            WeightArrayBufferBindingArb = ((int)0x889e),
            EdgeFlagArrayBufferBindingArb = ((int)0x889b),
            VertexAttribArrayBufferBindingArb = ((int)0x889f),
            NormalArrayBufferBindingArb = ((int)0x8897),
            WriteOnlyArb = ((int)0x88b9),
            ColorArrayBufferBindingArb = ((int)0x8898),
            ArrayBufferArb = ((int)0x8892),
            BufferMapPointerArb = ((int)0x88bd),
            StaticDrawArb = ((int)0x88e4),
            ReadWriteArb = ((int)0x88ba),
            BufferMappedArb = ((int)0x88bc),
            StreamCopyArb = ((int)0x88e2),
            StaticReadArb = ((int)0x88e5),
            ElementArrayBufferArb = ((int)0x8893),
            StaticCopyArb = ((int)0x88e6),
            StreamReadArb = ((int)0x88e1),
            DynamicReadArb = ((int)0x88e9),
            IndexArrayBufferBindingArb = ((int)0x8899),
            FogCoordinateArrayBufferBindingArb = ((int)0x889d),
        }

        public enum ArbOcclusionQuery
        {
            SamplesPassedArb = ((int)0x8914),
            QueryResultArb = ((int)0x8866),
            QueryCounterBitsArb = ((int)0x8864),
            QueryResultAvailableArb = ((int)0x8867),
            CurrentQueryArb = ((int)0x8865),
        }

        public enum ArbShaderObjects
        {
            IntVec2Arb = ((int)0x8b53),
            IntVec4Arb = ((int)0x8b55),
            Sampler2dShadowArb = ((int)0x8b62),
            IntVec3Arb = ((int)0x8b54),
            ObjectInfoLogLengthArb = ((int)0x8b84),
            SamplerCubeArb = ((int)0x8b60),
            Sampler1dShadowArb = ((int)0x8b61),
            ObjectTypeArb = ((int)0x8b4e),
            ProgramObjectArb = ((int)0x8b40),
            ObjectActiveUniformMaxLengthArb = ((int)0x8b87),
            FloatVec2Arb = ((int)0x8b50),
            Sampler2dRectArb = ((int)0x8b63),
            Sampler3dArb = ((int)0x8b5f),
            ObjectLinkStatusArb = ((int)0x8b82),
            Sampler2dRectShadowArb = ((int)0x8b64),
            BoolVec4Arb = ((int)0x8b59),
            ObjectDeleteStatusArb = ((int)0x8b80),
            FloatVec4Arb = ((int)0x8b52),
            ObjectShaderSourceLengthArb = ((int)0x8b88),
            BoolVec3Arb = ((int)0x8b58),
            ObjectAttachedObjectsArb = ((int)0x8b85),
            Sampler2dArb = ((int)0x8b5e),
            FloatVec3Arb = ((int)0x8b51),
            BoolVec2Arb = ((int)0x8b57),
            FloatMat2Arb = ((int)0x8b5a),
            ObjectValidateStatusArb = ((int)0x8b83),
            Sampler1dArb = ((int)0x8b5d),
            FloatMat4Arb = ((int)0x8b5c),
            ShaderObjectArb = ((int)0x8b48),
            ObjectActiveUniformsArb = ((int)0x8b86),
            FloatMat3Arb = ((int)0x8b5b),
            BoolArb = ((int)0x8b56),
            ObjectSubtypeArb = ((int)0x8b4f),
            ObjectCompileStatusArb = ((int)0x8b81),
        }

        public enum ArbVertexShader
        {
            MaxVertexUniformComponentsArb = ((int)0x8b4a),
            ObjectActiveAttributesArb = ((int)0x8b89),
            MaxVertexTextureImageUnitsArb = ((int)0x8b4c),
            MaxVaryingFloatsArb = ((int)0x8b4b),
            MaxCombinedTextureImageUnitsArb = ((int)0x8b4d),
            ObjectActiveAttributeMaxLengthArb = ((int)0x8b8a),
            VertexShaderArb = ((int)0x8b31),
        }

        public enum ArbFragmentShader
        {
            MaxFragmentUniformComponentsArb = ((int)0x8b49),
            FragmentShaderArb = ((int)0x8b30),
            FragmentShaderDerivativeHintArb = ((int)0x8b8b),
        }

        public enum ArbShadingLanguage100
        {
            ShadingLanguageVersionArb = ((int)0x8b8c),
        }

        public enum ArbTextureNonPowerOfTwo
        {
        }

        public enum ArbPointSprite
        {
            CoordReplaceArb = ((int)0x8862),
            PointSpriteArb = ((int)0x8861),
        }

        public enum ArbFragmentProgramShadow
        {
        }

        public enum ArbDrawBuffers
        {
            DrawBuffer9Arb = ((int)0x882e),
            DrawBuffer12Arb = ((int)0x8831),
            DrawBuffer3Arb = ((int)0x8828),
            MaxDrawBuffersArb = ((int)0x8824),
            DrawBuffer7Arb = ((int)0x882c),
            DrawBuffer2Arb = ((int)0x8827),
            DrawBuffer0Arb = ((int)0x8825),
            DrawBuffer14Arb = ((int)0x8833),
            DrawBuffer6Arb = ((int)0x882b),
            DrawBuffer4Arb = ((int)0x8829),
            DrawBuffer8Arb = ((int)0x882d),
            DrawBuffer13Arb = ((int)0x8832),
            DrawBuffer1Arb = ((int)0x8826),
            DrawBuffer11Arb = ((int)0x8830),
            DrawBuffer10Arb = ((int)0x882f),
            DrawBuffer15Arb = ((int)0x8834),
            DrawBuffer5Arb = ((int)0x882a),
        }

        public enum ArbTextureRectangle
        {
            TextureBindingRectangleArb = ((int)0x84f6),
            MaxRectangleTextureSizeArb = ((int)0x84f8),
            ProxyTextureRectangleArb = ((int)0x84f7),
            TextureRectangleArb = ((int)0x84f5),
        }

        public enum ArbColorBufferFloat
        {
            ClampReadColorArb = ((int)0x891c),
            FixedOnlyArb = ((int)0x891d),
            RgbaFloatModeArb = ((int)0x8820),
            ClampFragmentColorArb = ((int)0x891b),
            ClampVertexColorArb = ((int)0x891a),
        }

        public enum ArbHalfFloatPixel
        {
            HalfFloatArb = ((int)0x140b),
        }

        public enum ArbTextureFloat
        {
            UnsignedNormalizedArb = ((int)0x8c17),
            Intensity16fArb = ((int)0x881d),
            LuminanceAlpha32fArb = ((int)0x8819),
            TextureAlphaTypeArb = ((int)0x8c13),
            LuminanceAlpha16fArb = ((int)0x881f),
            TextureDepthTypeArb = ((int)0x8c16),
            TextureGreenTypeArb = ((int)0x8c11),
            Rgb16fArb = ((int)0x881b),
            TextureBlueTypeArb = ((int)0x8c12),
            Rgba16fArb = ((int)0x881a),
            Rgba32fArb = ((int)0x8814),
            Intensity32fArb = ((int)0x8817),
            Luminance16fArb = ((int)0x881e),
            Alpha16fArb = ((int)0x881c),
            Luminance32fArb = ((int)0x8818),
            TextureRedTypeArb = ((int)0x8c10),
            Alpha32fArb = ((int)0x8816),
            Rgb32fArb = ((int)0x8815),
            TextureLuminanceTypeArb = ((int)0x8c14),
            TextureIntensityTypeArb = ((int)0x8c15),
        }

        public enum ArbPixelBufferObject
        {
            PixelUnpackBufferBindingArb = ((int)0x88ef),
            PixelPackBufferArb = ((int)0x88eb),
            PixelUnpackBufferArb = ((int)0x88ec),
            PixelPackBufferBindingArb = ((int)0x88ed),
        }

        public enum ExtSubtexture
        {
        }

        public enum ExtCopyTexture
        {
        }

        public enum ExtMiscAttribute
        {
        }

        public enum ExtBlendLogicOp
        {
        }

        public enum ExtPointParameters
        {
            PointFadeThresholdSizeExt = ((int)0x8128),
            DistanceAttenuationExt = ((int)0x8129),
            PointSizeMaxExt = ((int)0x8127),
            PointSizeMinExt = ((int)0x8126),
        }

        public enum SgixTagSampleBuffer
        {
        }

        public enum SgixPolynomialFfd
        {
            DeformationsMaskSgix = ((int)0x8196),
            TextureDeformationSgix = ((int)0x8195),
            MaxDeformationOrderSgix = ((int)0x8197),
            GeometryDeformationSgix = ((int)0x8194),
        }

        public enum SgixFlushRaster
        {
        }

        public enum HpImageTransform
        {
            ImageTranslateXHp = ((int)0x8157),
            ImageRotateAngleHp = ((int)0x8159),
            ImageTransform2dHp = ((int)0x8161),
            CubicHp = ((int)0x815f),
            ImageRotateOriginYHp = ((int)0x815b),
            ImageTranslateYHp = ((int)0x8158),
            ImageScaleYHp = ((int)0x8156),
            ImageCubicWeightHp = ((int)0x815e),
            PostImageTransformColorTableHp = ((int)0x8162),
            ImageMinFilterHp = ((int)0x815d),
            AverageHp = ((int)0x8160),
            ImageMagFilterHp = ((int)0x815c),
            ProxyPostImageTransformColorTableHp = ((int)0x8163),
            ImageScaleXHp = ((int)0x8155),
            ImageRotateOriginXHp = ((int)0x815a),
        }

        public enum IngrPaletteBuffer
        {
        }

        public enum ExtColorSubtable
        {
        }

        public enum PgiVertexHints
        {
            MaxVertexHintPgi = ((int)0x1a22d),
            VertexDataHintPgi = ((int)0x1a22a),
            Texcoord2BitPgi = ((int)0x20000000),
            Color4BitPgi = ((int)0x00020000),
            Vertex23BitPgi = ((int)0x00000004),
            EdgeflagBitPgi = ((int)0x00040000),
            MatShininessBitPgi = ((int)0x02000000),
            Color3BitPgi = ((int)0x00010000),
            IndexBitPgi = ((int)0x00080000),
            Texcoord3BitPgi = ((int)0x40000000),
            MaterialSideHintPgi = ((int)0x1a22c),
            MatAmbientAndDiffuseBitPgi = ((int)0x00200000),
            Texcoord1BitPgi = ((int)0x10000000),
            MatEmissionBitPgi = ((int)0x00800000),
            MatDiffuseBitPgi = ((int)0x00400000),
            VertexConsistentHintPgi = ((int)0x1a22b),
            MatColorIndexesBitPgi = ((int)0x01000000),
            NormalBitPgi = ((int)0x08000000),
            Vertex4BitPgi = ((int)0x00000008),
            Texcoord4BitPgi = unchecked((int)0x80000000),
            MatAmbientBitPgi = ((int)0x00100000),
            MatSpecularBitPgi = ((int)0x04000000),
        }

        public enum PgiMiscHints
        {
            ClipNearHintPgi = ((int)0x1a220),
            AllowDrawWinHintPgi = ((int)0x1a20f),
            BackNormalsHintPgi = ((int)0x1a223),
            StrictDepthfuncHintPgi = ((int)0x1a216),
            NativeGraphicsHandlePgi = ((int)0x1a202),
            StrictLightingHintPgi = ((int)0x1a217),
            StrictScissorHintPgi = ((int)0x1a218),
            AlwaysFastHintPgi = ((int)0x1a20c),
            ConserveMemoryHintPgi = ((int)0x1a1fd),
            PreferDoublebufferHintPgi = ((int)0x1a1f8),
            WideLineHintPgi = ((int)0x1a222),
            ClipFarHintPgi = ((int)0x1a221),
            AllowDrawFrgHintPgi = ((int)0x1a210),
            AlwaysSoftHintPgi = ((int)0x1a20d),
            AllowDrawObjHintPgi = ((int)0x1a20e),
            AllowDrawMemHintPgi = ((int)0x1a211),
            FullStippleHintPgi = ((int)0x1a219),
            NativeGraphicsBeginHintPgi = ((int)0x1a203),
            ReclaimMemoryHintPgi = ((int)0x1a1fe),
            NativeGraphicsEndHintPgi = ((int)0x1a204),
        }

        public enum ExtPalettedTexture
        {
            ColorIndex1Ext = ((int)0x80e2),
            ColorIndex8Ext = ((int)0x80e5),
            ColorIndex2Ext = ((int)0x80e3),
            ColorIndex16Ext = ((int)0x80e7),
            ColorIndex4Ext = ((int)0x80e4),
            TextureIndexSizeExt = ((int)0x80ed),
            ColorIndex12Ext = ((int)0x80e6),
        }

        public enum ExtClipVolumeHint
        {
            ClipVolumeClippingHintExt = ((int)0x80f0),
        }

        public enum ExtIndexTexture
        {
        }

        public enum ExtIndexMaterial
        {
            IndexMaterialExt = ((int)0x81b8),
            IndexMaterialFaceExt = ((int)0x81ba),
            IndexMaterialParameterExt = ((int)0x81b9),
        }

        public enum ExtIndexFunc
        {
            IndexTestRefExt = ((int)0x81b7),
            IndexTestFuncExt = ((int)0x81b6),
            IndexTestExt = ((int)0x81b5),
        }

        public enum ExtIndexArrayFormats
        {
            T2fIuiN3fV2fExt = ((int)0x81b3),
            T2fIuiN3fV3fExt = ((int)0x81b4),
            T2fIuiV2fExt = ((int)0x81b1),
            T2fIuiV3fExt = ((int)0x81b2),
            IuiV3fExt = ((int)0x81ae),
            IuiN3fV3fExt = ((int)0x81b0),
            IuiN3fV2fExt = ((int)0x81af),
            IuiV2fExt = ((int)0x81ad),
        }

        public enum ExtCompiledVertexArray
        {
            ArrayElementLockCountExt = ((int)0x81a9),
            ArrayElementLockFirstExt = ((int)0x81a8),
        }

        public enum ExtCullVertex
        {
            CullVertexObjectPositionExt = ((int)0x81ac),
            CullVertexExt = ((int)0x81aa),
            CullVertexEyePositionExt = ((int)0x81ab),
        }

        public enum IbmRasterposClip
        {
            RasterPositionUnclippedIbm = ((int)0x19262),
        }

        public enum HpTextureLighting
        {
            TextureLightingModeHp = ((int)0x8167),
            TexturePreSpecularHp = ((int)0x8169),
            TexturePostSpecularHp = ((int)0x8168),
        }

        public enum ExtDrawRangeElements
        {
            MaxElementsVerticesExt = ((int)0x80e8),
            MaxElementsIndicesExt = ((int)0x80e9),
        }

        public enum WinPhongShading
        {
            PhongHintWin = ((int)0x80eb),
            PhongWin = ((int)0x80ea),
        }

        public enum WinSpecularFog
        {
            FogSpecularTextureWin = ((int)0x80ec),
        }

        public enum ExtLightTexture
        {
            ShadowAttenuationExt = ((int)0x834e),
            FragmentDepthExt = ((int)0x8452),
            TextureLightExt = ((int)0x8350),
            AttenuationExt = ((int)0x834d),
            TextureMaterialParameterExt = ((int)0x8352),
            FragmentMaterialExt = ((int)0x8349),
            FragmentNormalExt = ((int)0x834a),
            TextureMaterialFaceExt = ((int)0x8351),
            TextureApplicationModeExt = ((int)0x834f),
            FragmentColorExt = ((int)0x834c),
        }

        public enum SgixAsync
        {
            AsyncMarkerSgix = ((int)0x8329),
        }

        public enum IntelTextureScissor
        {
        }

        public enum HpOcclusionTest
        {
            OcclusionTestResultHp = ((int)0x8166),
            OcclusionTestHp = ((int)0x8165),
        }

        public enum ExtPixelTransformColorTable
        {
        }

        public enum ExtSecondaryColor
        {
            SecondaryColorArrayPointerExt = ((int)0x845d),
            ColorSumExt = ((int)0x8458),
            SecondaryColorArraySizeExt = ((int)0x845a),
            CurrentSecondaryColorExt = ((int)0x8459),
            SecondaryColorArrayTypeExt = ((int)0x845b),
            SecondaryColorArrayExt = ((int)0x845e),
            SecondaryColorArrayStrideExt = ((int)0x845c),
        }

        public enum ExtTexturePerturbNormal
        {
            PerturbExt = ((int)0x85ae),
            TextureNormalExt = ((int)0x85af),
        }

        public enum ExtMultiDrawArrays
        {
        }

        public enum ExtFogCoord
        {
            FragmentDepthExt = ((int)0x8452),
            CurrentFogCoordinateExt = ((int)0x8453),
            FogCoordinateArrayStrideExt = ((int)0x8455),
            FogCoordinateArrayPointerExt = ((int)0x8456),
            FogCoordinateArrayExt = ((int)0x8457),
            FogCoordinateExt = ((int)0x8451),
            FogCoordinateArrayTypeExt = ((int)0x8454),
            FogCoordinateSourceExt = ((int)0x8450),
        }

        public enum RendScreenCoordinates
        {
            InvertedScreenWRend = ((int)0x8491),
            ScreenCoordinatesRend = ((int)0x8490),
        }

        public enum ExtCoordinateFrame
        {
            TangentArrayTypeExt = ((int)0x843e),
            BinormalArrayTypeExt = ((int)0x8440),
            Map1TangentExt = ((int)0x8444),
            CurrentTangentExt = ((int)0x843b),
            Map2BinormalExt = ((int)0x8447),
            CurrentBinormalExt = ((int)0x843c),
            TangentArrayPointerExt = ((int)0x8442),
            Map1BinormalExt = ((int)0x8446),
            BinormalArrayPointerExt = ((int)0x8443),
            BinormalArrayExt = ((int)0x843a),
            Map2TangentExt = ((int)0x8445),
            TangentArrayExt = ((int)0x8439),
            BinormalArrayStrideExt = ((int)0x8441),
            TangentArrayStrideExt = ((int)0x843f),
        }

        public enum ExtTextureEnvCombine
        {
            Operand2AlphaExt = ((int)0x859a),
            CombineRgbExt = ((int)0x8571),
            Source1AlphaExt = ((int)0x8589),
            Operand1RgbExt = ((int)0x8591),
            PreviousExt = ((int)0x8578),
            Operand1AlphaExt = ((int)0x8599),
            AddSignedExt = ((int)0x8574),
            ConstantExt = ((int)0x8576),
            RgbScaleExt = ((int)0x8573),
            Source0AlphaExt = ((int)0x8588),
            InterpolateExt = ((int)0x8575),
            Source2RgbExt = ((int)0x8582),
            PrimaryColorExt = ((int)0x8577),
            CombineExt = ((int)0x8570),
            Source0RgbExt = ((int)0x8580),
            Source1RgbExt = ((int)0x8581),
            Operand0AlphaExt = ((int)0x8598),
            Operand2RgbExt = ((int)0x8592),
            CombineAlphaExt = ((int)0x8572),
            Source2AlphaExt = ((int)0x858a),
            Operand0RgbExt = ((int)0x8590),
        }

        public enum AppleSpecularVector
        {
            LightModelSpecularVectorApple = ((int)0x85b0),
        }

        public enum AppleTransformHint
        {
            TransformHintApple = ((int)0x85b1),
        }

        public enum SgixFogScale
        {
            FogScaleSgix = ((int)0x81fc),
            FogScaleValueSgix = ((int)0x81fd),
        }

        public enum SunxConstantData
        {
            UnpackConstantDataSunx = ((int)0x81d5),
            TextureConstantDataSunx = ((int)0x81d6),
        }

        public enum SunGlobalAlpha
        {
            GlobalAlphaFactorSun = ((int)0x81da),
            GlobalAlphaSun = ((int)0x81d9),
        }

        public enum SunTriangleList
        {
            R1uiC4ubV3fSun = ((int)0x85c5),
            ReplaceMiddleSun = ((int)0x0002),
            ReplacementCodeArrayStrideSun = ((int)0x85c2),
            RestartSun = ((int)0x0001),
            ReplaceOldestSun = ((int)0x0003),
            ReplacementCodeArrayTypeSun = ((int)0x85c1),
            R1uiN3fV3fSun = ((int)0x85c7),
            R1uiT2fV3fSun = ((int)0x85c9),
            R1uiT2fN3fV3fSun = ((int)0x85ca),
            R1uiV3fSun = ((int)0x85c4),
            ReplacementCodeSun = ((int)0x81d8),
            TriangleListSun = ((int)0x81d7),
            R1uiT2fC4fN3fV3fSun = ((int)0x85cb),
            ReplacementCodeArraySun = ((int)0x85c0),
            R1uiC3fV3fSun = ((int)0x85c6),
            R1uiC4fN3fV3fSun = ((int)0x85c8),
            ReplacementCodeArrayPointerSun = ((int)0x85c3),
        }

        public enum SunVertex
        {
        }

        public enum ExtBlendFuncSeparate
        {
            BlendSrcRgbExt = ((int)0x80c9),
            BlendDstAlphaExt = ((int)0x80ca),
            BlendSrcAlphaExt = ((int)0x80cb),
            BlendDstRgbExt = ((int)0x80c8),
        }

        public enum IngrColorClamp
        {
            BlueMaxClampIngr = ((int)0x8566),
            RedMinClampIngr = ((int)0x8560),
            AlphaMinClampIngr = ((int)0x8563),
            AlphaMaxClampIngr = ((int)0x8567),
            GreenMaxClampIngr = ((int)0x8565),
            BlueMinClampIngr = ((int)0x8562),
            GreenMinClampIngr = ((int)0x8561),
            RedMaxClampIngr = ((int)0x8564),
        }

        public enum IngrInterlaceRead
        {
            InterlaceReadIngr = ((int)0x8568),
        }

        public enum ExtStencilWrap
        {
            DecrWrapExt = ((int)0x8508),
            IncrWrapExt = ((int)0x8507),
        }

        public enum Ext422Pixels
        {
            Gl422RevAverageExt = ((int)0x80cf),
            Gl422RevExt = ((int)0x80cd),
            Gl422AverageExt = ((int)0x80ce),
            Gl422Ext = ((int)0x80cc),
        }

        public enum NvTexgenReflection
        {
            ReflectionMapNv = ((int)0x8512),
            NormalMapNv = ((int)0x8511),
        }

        public enum ExtTextureCubeMap
        {
            TextureCubeMapExt = ((int)0x8513),
            ProxyTextureCubeMapExt = ((int)0x851b),
            TextureCubeMapNegativeZExt = ((int)0x851a),
            TextureCubeMapPositiveZExt = ((int)0x8519),
            TextureCubeMapPositiveYExt = ((int)0x8517),
            TextureBindingCubeMapExt = ((int)0x8514),
            NormalMapExt = ((int)0x8511),
            MaxCubeMapTextureSizeExt = ((int)0x851c),
            TextureCubeMapPositiveXExt = ((int)0x8515),
            ReflectionMapExt = ((int)0x8512),
            TextureCubeMapNegativeXExt = ((int)0x8516),
            TextureCubeMapNegativeYExt = ((int)0x8518),
        }

        public enum SunConvolutionBorderModes
        {
            WrapBorderSun = ((int)0x81d4),
        }

        public enum ExtTextureEnvAdd
        {
        }

        public enum ExtTextureLodBias
        {
            TextureLodBiasExt = ((int)0x8501),
            MaxTextureLodBiasExt = ((int)0x84fd),
            TextureFilterControlExt = ((int)0x8500),
        }

        public enum ExtTextureFilterAnisotropic
        {
            TextureMaxAnisotropyExt = ((int)0x84fe),
            MaxTextureMaxAnisotropyExt = ((int)0x84ff),
        }

        public enum ExtVertexWeighting
        {
            Modelview1StackDepthExt = ((int)0x8502),
            VertexWeightArraySizeExt = ((int)0x850d),
            Modelview0MatrixExt = ((int)0x0ba6),
            VertexWeightingExt = ((int)0x8509),
            VertexWeightArrayPointerExt = ((int)0x8510),
            Modelview1MatrixExt = ((int)0x8506),
            VertexWeightArrayTypeExt = ((int)0x850e),
            Modelview0StackDepthExt = ((int)0x0ba3),
            VertexWeightArrayStrideExt = ((int)0x850f),
            Modelview0Ext = ((int)0x1700),
            Modelview1Ext = ((int)0x850a),
            CurrentVertexWeightExt = ((int)0x850b),
            VertexWeightArrayExt = ((int)0x850c),
        }

        public enum NvLightMaxExponent
        {
            MaxSpotExponentNv = ((int)0x8505),
            MaxShininessNv = ((int)0x8504),
        }

        public enum NvVertexArrayRange
        {
            VertexArrayRangeNv = ((int)0x851d),
            VertexArrayRangeValidNv = ((int)0x851f),
            VertexArrayRangeLengthNv = ((int)0x851e),
            MaxVertexArrayRangeElementNv = ((int)0x8520),
            VertexArrayRangePointerNv = ((int)0x8521),
        }

        public enum NvRegisterCombiners
        {
            VariableDNv = ((int)0x8526),
            ETimesFNv = ((int)0x8531),
            CombinerMappingNv = ((int)0x8543),
            CombinerCdOutputNv = ((int)0x854b),
            Combiner7Nv = ((int)0x8557),
            Combiner4Nv = ((int)0x8554),
            Texture1Arb = ((int)0x84c1),
            HalfBiasNegateNv = ((int)0x853b),
            VariableANv = ((int)0x8523),
            CombinerComponentUsageNv = ((int)0x8544),
            CombinerSumOutputNv = ((int)0x854c),
            ScaleByFourNv = ((int)0x853f),
            ScaleByTwoNv = ((int)0x853e),
            CombinerBiasNv = ((int)0x8549),
            SignedNegateNv = ((int)0x853d),
            VariableENv = ((int)0x8527),
            BiasByNegativeOneHalfNv = ((int)0x8541),
            CombinerInputNv = ((int)0x8542),
            UnsignedInvertNv = ((int)0x8537),
            SignedIdentityNv = ((int)0x853c),
            SecondaryColorNv = ((int)0x852d),
            Combiner3Nv = ((int)0x8553),
            Spare0Nv = ((int)0x852e),
            CombinerAbDotProductNv = ((int)0x8545),
            None = ((int)0),
            VariableBNv = ((int)0x8524),
            CombinerAbOutputNv = ((int)0x854a),
            Spare1Nv = ((int)0x852f),
            Combiner2Nv = ((int)0x8552),
            ConstantColor0Nv = ((int)0x852a),
            Texture0Arb = ((int)0x84c0),
            Combiner6Nv = ((int)0x8556),
            DiscardNv = ((int)0x8530),
            VariableFNv = ((int)0x8528),
            ExpandNegateNv = ((int)0x8539),
            Combiner1Nv = ((int)0x8551),
            MaxGeneralCombinersNv = ((int)0x854d),
            ColorSumClampNv = ((int)0x854f),
            ScaleByOneHalfNv = ((int)0x8540),
            CombinerMuxSumNv = ((int)0x8547),
            CombinerScaleNv = ((int)0x8548),
            VariableCNv = ((int)0x8525),
            NumGeneralCombinersNv = ((int)0x854e),
            Fog = ((int)0x0b60),
            Combiner5Nv = ((int)0x8555),
            RegisterCombinersNv = ((int)0x8522),
            ConstantColor1Nv = ((int)0x852b),
            HalfBiasNormalNv = ((int)0x853a),
            Zero = ((int)0),
            UnsignedIdentityNv = ((int)0x8536),
            Spare0PlusSecondaryColorNv = ((int)0x8532),
            VariableGNv = ((int)0x8529),
            PrimaryColorNv = ((int)0x852c),
            Combiner0Nv = ((int)0x8550),
            CombinerCdDotProductNv = ((int)0x8546),
            ExpandNormalNv = ((int)0x8538),
        }

        public enum NvFogDistance
        {
            EyeRadialNv = ((int)0x855b),
            EyePlane = ((int)0x2502),
            EyePlaneAbsoluteNv = ((int)0x855c),
            FogDistanceModeNv = ((int)0x855a),
        }

        public enum NvTexgenEmboss
        {
            EmbossConstantNv = ((int)0x855e),
            EmbossMapNv = ((int)0x855f),
            EmbossLightNv = ((int)0x855d),
        }

        public enum NvBlendSquare
        {
        }

        public enum NvTextureEnvCombine4
        {
            Operand3RgbNv = ((int)0x8593),
            Combine4Nv = ((int)0x8503),
            Source3AlphaNv = ((int)0x858b),
            Source3RgbNv = ((int)0x8583),
            Operand3AlphaNv = ((int)0x859b),
        }

        public enum MesaResizeBuffers
        {
        }

        public enum MesaWindowPos
        {
        }

        public enum IbmCullVertex
        {
            CullVertexIbm = ((int)103050),
        }

        public enum IbmMultimodeDrawArrays
        {
        }

        public enum IbmVertexArrayLists
        {
            TextureCoordArrayListStrideIbm = ((int)103084),
            NormalArrayListStrideIbm = ((int)103081),
            ColorArrayListStrideIbm = ((int)103082),
            SecondaryColorArrayListStrideIbm = ((int)103087),
            VertexArrayListIbm = ((int)103070),
            IndexArrayListIbm = ((int)103073),
            NormalArrayListIbm = ((int)103071),
            SecondaryColorArrayListIbm = ((int)103077),
            FogCoordinateArrayListStrideIbm = ((int)103086),
            VertexArrayListStrideIbm = ((int)103080),
            TextureCoordArrayListIbm = ((int)103074),
            ColorArrayListIbm = ((int)103072),
            EdgeFlagArrayListStrideIbm = ((int)103085),
            FogCoordinateArrayListIbm = ((int)103076),
            IndexArrayListStrideIbm = ((int)103083),
            EdgeFlagArrayListIbm = ((int)103075),
        }

        public enum SgixYcrcbSubsample
        {
            PixelSubsample2424Sgix = ((int)0x85a3),
            UnpackSubsampleRateSgix = ((int)0x85a1),
            PackSubsampleRateSgix = ((int)0x85a0),
            PixelSubsample4242Sgix = ((int)0x85a4),
            PixelSubsample4444Sgix = ((int)0x85a2),
        }

        public enum SgixYcrcba
        {
            YcrcbaSgix = ((int)0x8319),
            YcrcbSgix = ((int)0x8318),
        }

        public enum SgiDepthPassInstrument
        {
            DepthPassInstrumentCountersSgix = ((int)0x8311),
            DepthPassInstrumentSgix = ((int)0x8310),
            DepthPassInstrumentMaxSgix = ((int)0x8312),
        }

        public enum Gl3DfxTextureCompressionFxt1
        {
            CompressedRgbFxt13dfx = ((int)0x86b0),
            CompressedRgbaFxt13dfx = ((int)0x86b1),
        }

        public enum Gl3DfxMultisample
        {
            SampleBuffers3dfx = ((int)0x86b3),
            Multisample3dfx = ((int)0x86b2),
            MultisampleBit3dfx = ((int)0x20000000),
            Samples3dfx = ((int)0x86b4),
        }

        public enum Gl3DfxTbuffer
        {
        }

        public enum ExtMultisample
        {
            SamplesExt = ((int)0x80a9),
            MultisampleExt = ((int)0x809d),
            Gl4pass0Ext = ((int)0x80a4),
            MultisampleBitExt = ((int)0x20000000),
            SampleMaskInvertExt = ((int)0x80ab),
            Gl2pass0Ext = ((int)0x80a2),
            SamplePatternExt = ((int)0x80ac),
            SampleMaskValueExt = ((int)0x80aa),
            Gl4pass2Ext = ((int)0x80a6),
            Gl1passExt = ((int)0x80a1),
            Gl4pass1Ext = ((int)0x80a5),
            Gl4pass3Ext = ((int)0x80a7),
            SampleAlphaToMaskExt = ((int)0x809e),
            SampleMaskExt = ((int)0x80a0),
            Gl2pass1Ext = ((int)0x80a3),
            SampleBuffersExt = ((int)0x80a8),
            SampleAlphaToOneExt = ((int)0x809f),
        }

        public enum ExtTextureEnvDot3
        {
            Dot3RgbExt = ((int)0x8740),
            Dot3RgbaExt = ((int)0x8741),
        }

        public enum AtiTextureMirrorOnce
        {
            MirrorClampToEdgeAti = ((int)0x8743),
            MirrorClampAti = ((int)0x8742),
        }

        public enum NvFence
        {
            FenceStatusNv = ((int)0x84f3),
            AllCompletedNv = ((int)0x84f2),
            FenceConditionNv = ((int)0x84f4),
        }

        public enum IbmTextureMirroredRepeat
        {
            MirroredRepeatIbm = ((int)0x8370),
        }

        public enum NvEvaluators
        {
            EvalFractionalTessellationNv = ((int)0x86c5),
            EvalVertexAttrib14Nv = ((int)0x86d4),
            MaxMapTessellationNv = ((int)0x86d6),
            EvalVertexAttrib2Nv = ((int)0x86c8),
            MaxRationalEvalOrderNv = ((int)0x86d7),
            EvalVertexAttrib0Nv = ((int)0x86c6),
            EvalVertexAttrib11Nv = ((int)0x86d1),
            EvalVertexAttrib15Nv = ((int)0x86d5),
            MapAttribVOrderNv = ((int)0x86c4),
            EvalVertexAttrib3Nv = ((int)0x86c9),
            EvalVertexAttrib10Nv = ((int)0x86d0),
            EvalVertexAttrib7Nv = ((int)0x86cd),
            EvalVertexAttrib9Nv = ((int)0x86cf),
            EvalVertexAttrib5Nv = ((int)0x86cb),
            EvalVertexAttrib4Nv = ((int)0x86ca),
            MapTessellationNv = ((int)0x86c2),
            EvalVertexAttrib6Nv = ((int)0x86cc),
            EvalVertexAttrib8Nv = ((int)0x86ce),
            Eval2dNv = ((int)0x86c0),
            EvalVertexAttrib1Nv = ((int)0x86c7),
            EvalTriangular2dNv = ((int)0x86c1),
            MapAttribUOrderNv = ((int)0x86c3),
            EvalVertexAttrib12Nv = ((int)0x86d2),
            EvalVertexAttrib13Nv = ((int)0x86d3),
        }

        public enum NvPackedDepthStencil
        {
            DepthStencilNv = ((int)0x84f9),
            UnsignedInt248Nv = ((int)0x84fa),
        }

        public enum NvRegisterCombiners2
        {
            PerStageConstantsNv = ((int)0x8535),
        }

        public enum NvTextureCompressionVtc
        {
        }

        public enum NvTextureRectangle
        {
            ProxyTextureRectangleNv = ((int)0x84f7),
            TextureRectangleNv = ((int)0x84f5),
            MaxRectangleTextureSizeNv = ((int)0x84f8),
            TextureBindingRectangleNv = ((int)0x84f6),
        }

        public enum NvTextureShader
        {
            HiloNv = ((int)0x86f4),
            LoScaleNv = ((int)0x870f),
            DotProductTexture2dNv = ((int)0x86ee),
            OffsetTextureScaleNv = ((int)0x86e2),
            DotProductDiffuseCubeMapNv = ((int)0x86f1),
            SignedAlpha8Nv = ((int)0x8706),
            PassThroughNv = ((int)0x86e6),
            SignedIntensity8Nv = ((int)0x8708),
            OffsetTextureRectangleScaleNv = ((int)0x864d),
            TextureShaderNv = ((int)0x86de),
            TextureHiSizeNv = ((int)0x871b),
            OffsetTexture2dBiasNv = ((int)0x86e3),
            RgbaUnsignedDotProductMappingNv = ((int)0x86d9),
            SignedAlphaNv = ((int)0x8705),
            VibranceBiasNv = ((int)0x8719),
            ConstEyeNv = ((int)0x86e5),
            UnsignedIntS8S888Nv = ((int)0x86da),
            LoBiasNv = ((int)0x8715),
            DependentGbTexture2dNv = ((int)0x86ea),
            ShaderOperationNv = ((int)0x86df),
            DtScaleNv = ((int)0x8711),
            SignedLuminanceAlphaNv = ((int)0x8703),
            Dsdt8Nv = ((int)0x8709),
            SignedIntensityNv = ((int)0x8707),
            DtBiasNv = ((int)0x8717),
            DependentArTexture2dNv = ((int)0x86e9),
            TextureBorderValuesNv = ((int)0x871a),
            SignedHilo16Nv = ((int)0x86fa),
            DsScaleNv = ((int)0x8710),
            SignedRgb8Nv = ((int)0x86ff),
            DotProductDepthReplaceNv = ((int)0x86ed),
            PreviousTextureInputNv = ((int)0x86e4),
            OffsetTextureRectangleNv = ((int)0x864c),
            HiScaleNv = ((int)0x870e),
            CullFragmentNv = ((int)0x86e7),
            SignedRgbUnsignedAlphaNv = ((int)0x870c),
            OffsetTextureMatrixNv = ((int)0x86e1),
            TextureDtSizeNv = ((int)0x871e),
            VibranceScaleNv = ((int)0x8713),
            SignedRgbNv = ((int)0x86fe),
            HiBiasNv = ((int)0x8714),
            Dsdt8Mag8Intensity8Nv = ((int)0x870b),
            CullModesNv = ((int)0x86e0),
            DotProductReflectCubeMapNv = ((int)0x86f2),
            OffsetTexture2dMatrixNv = ((int)0x86e1),
            SignedRgbaNv = ((int)0x86fb),
            TextureLoSizeNv = ((int)0x871c),
            DsdtMagNv = ((int)0x86f6),
            Hilo16Nv = ((int)0x86f8),
            DotProductConstEyeReflectCubeMapNv = ((int)0x86f3),
            DsdtMagVibNv = ((int)0x86f7),
            SignedHiloNv = ((int)0x86f9),
            DotProductTextureCubeMapNv = ((int)0x86f0),
            Dsdt8Mag8Nv = ((int)0x870a),
            DotProductTextureRectangleNv = ((int)0x864e),
            SignedRgb8UnsignedAlpha8Nv = ((int)0x870d),
            ShaderConsistentNv = ((int)0x86dd),
            MagnitudeScaleNv = ((int)0x8712),
            MagnitudeBiasNv = ((int)0x8718),
            TextureMagSizeNv = ((int)0x871f),
            OffsetTextureBiasNv = ((int)0x86e3),
            SignedLuminance8Nv = ((int)0x8702),
            OffsetTexture2dScaleNv = ((int)0x86e2),
            SignedLuminanceNv = ((int)0x8701),
            DsdtNv = ((int)0x86f5),
            OffsetTexture2dNv = ((int)0x86e8),
            DotProductNv = ((int)0x86ec),
            DsdtMagIntensityNv = ((int)0x86dc),
            TextureDsSizeNv = ((int)0x871d),
            SignedRgba8Nv = ((int)0x86fc),
            SignedLuminance8Alpha8Nv = ((int)0x8704),
            UnsignedInt88S8S8RevNv = ((int)0x86db),
            DsBiasNv = ((int)0x8716),
        }

        public enum NvTextureShader2
        {
            DotProductTexture3dNv = ((int)0x86ef),
        }

        public enum NvVertexArrayRange2
        {
            VertexArrayRangeWithoutFlushNv = ((int)0x8533),
        }

        public enum NvVertexProgram
        {
            VertexProgramTwoSideNv = ((int)0x8643),
            AttribArraySizeNv = ((int)0x8623),
            VertexAttribArray8Nv = ((int)0x8658),
            VertexAttribArray10Nv = ((int)0x865a),
            Map2VertexAttrib54Nv = ((int)0x8675),
            Map1VertexAttrib54Nv = ((int)0x8665),
            VertexAttribArray13Nv = ((int)0x865d),
            Map2VertexAttrib64Nv = ((int)0x8676),
            TrackMatrixTransformNv = ((int)0x8649),
            ProgramResidentNv = ((int)0x8647),
            Map1VertexAttrib144Nv = ((int)0x866e),
            Matrix5Nv = ((int)0x8635),
            Map1VertexAttrib24Nv = ((int)0x8662),
            VertexAttribArray14Nv = ((int)0x865e),
            VertexAttribArray11Nv = ((int)0x865b),
            ProgramLengthNv = ((int)0x8627),
            VertexAttribArray7Nv = ((int)0x8657),
            Map2VertexAttrib34Nv = ((int)0x8673),
            VertexProgramPointSizeNv = ((int)0x8642),
            Matrix4Nv = ((int)0x8634),
            VertexAttribArray1Nv = ((int)0x8651),
            Map2VertexAttrib124Nv = ((int)0x867c),
            Map2VertexAttrib84Nv = ((int)0x8678),
            AttribArrayStrideNv = ((int)0x8624),
            VertexAttribArray5Nv = ((int)0x8655),
            ProgramParameterNv = ((int)0x8644),
            Map2VertexAttrib134Nv = ((int)0x867d),
            Matrix7Nv = ((int)0x8637),
            TransposeNv = ((int)0x862c),
            VertexProgramBindingNv = ((int)0x864a),
            ProgramErrorPositionNv = ((int)0x864b),
            CurrentMatrixStackDepthNv = ((int)0x8640),
            Map1VertexAttrib44Nv = ((int)0x8664),
            Matrix6Nv = ((int)0x8636),
            VertexAttribArray2Nv = ((int)0x8652),
            Map2VertexAttrib04Nv = ((int)0x8670),
            Map1VertexAttrib94Nv = ((int)0x8669),
            AttribArrayPointerNv = ((int)0x8645),
            Map1VertexAttrib14Nv = ((int)0x8661),
            Map2VertexAttrib114Nv = ((int)0x867b),
            Map2VertexAttrib144Nv = ((int)0x867e),
            Map2VertexAttrib24Nv = ((int)0x8672),
            VertexProgramNv = ((int)0x8620),
            Matrix1Nv = ((int)0x8631),
            VertexStateProgramNv = ((int)0x8621),
            Map2VertexAttrib154Nv = ((int)0x867f),
            InverseTransposeNv = ((int)0x862d),
            VertexAttribArray0Nv = ((int)0x8650),
            VertexAttribArray15Nv = ((int)0x865f),
            Map1VertexAttrib64Nv = ((int)0x8666),
            TrackMatrixNv = ((int)0x8648),
            VertexAttribArray9Nv = ((int)0x8659),
            CurrentMatrixNv = ((int)0x8641),
            ProgramTargetNv = ((int)0x8646),
            MaxTrackMatrixStackDepthNv = ((int)0x862e),
            CurrentAttribNv = ((int)0x8626),
            VertexAttribArray4Nv = ((int)0x8654),
            Matrix0Nv = ((int)0x8630),
            Map2VertexAttrib74Nv = ((int)0x8677),
            InverseNv = ((int)0x862b),
            VertexAttribArray12Nv = ((int)0x865c),
            IdentityNv = ((int)0x862a),
            Map2VertexAttrib104Nv = ((int)0x867a),
            VertexAttribArray6Nv = ((int)0x8656),
            Map1VertexAttrib104Nv = ((int)0x866a),
            Map1VertexAttrib34Nv = ((int)0x8663),
            Map1VertexAttrib114Nv = ((int)0x866b),
            VertexAttribArray3Nv = ((int)0x8653),
            Map2VertexAttrib44Nv = ((int)0x8674),
            ProgramStringNv = ((int)0x8628),
            Matrix3Nv = ((int)0x8633),
            Map1VertexAttrib84Nv = ((int)0x8668),
            Map1VertexAttrib74Nv = ((int)0x8667),
            Map2VertexAttrib94Nv = ((int)0x8679),
            Map1VertexAttrib154Nv = ((int)0x866f),
            Map1VertexAttrib04Nv = ((int)0x8660),
            MaxTrackMatricesNv = ((int)0x862f),
            ModelviewProjectionNv = ((int)0x8629),
            Map2VertexAttrib14Nv = ((int)0x8671),
            Map1VertexAttrib124Nv = ((int)0x866c),
            AttribArrayTypeNv = ((int)0x8625),
            Matrix2Nv = ((int)0x8632),
            Map1VertexAttrib134Nv = ((int)0x866d),
        }

        public enum SgixScalebiasHint
        {
            ScalebiasHintSgix = ((int)0x8322),
        }

        public enum OmlInterlace
        {
            InterlaceOml = ((int)0x8980),
            InterlaceReadOml = ((int)0x8981),
        }

        public enum OmlSubsample
        {
            FormatSubsample2424Oml = ((int)0x8982),
            FormatSubsample244244Oml = ((int)0x8983),
        }

        public enum OmlResample
        {
            ResampleReplicateOml = ((int)0x8986),
            PackResampleOml = ((int)0x8984),
            ResampleZeroFillOml = ((int)0x8987),
            ResampleDecimateOml = ((int)0x8989),
            UnpackResampleOml = ((int)0x8985),
            ResampleAverageOml = ((int)0x8988),
        }

        public enum NvCopyDepthToColor
        {
            DepthStencilToRgbaNv = ((int)0x886e),
            DepthStencilToBgraNv = ((int)0x886f),
        }

        public enum AtiEnvmapBumpmap
        {
            DudvAti = ((int)0x8779),
            BumpEnvmapAti = ((int)0x877b),
            BumpTexUnitsAti = ((int)0x8778),
            BumpTargetAti = ((int)0x877c),
            BumpRotMatrixAti = ((int)0x8775),
            Du8dv8Ati = ((int)0x877a),
            BumpNumTexUnitsAti = ((int)0x8777),
            BumpRotMatrixSizeAti = ((int)0x8776),
        }

        public enum AtiFragmentShader
        {
            Con2Ati = ((int)0x8943),
            Gl2xBitAti = ((int)0x00000001),
            Dot4Ati = ((int)0x8967),
            FragmentShaderAti = ((int)0x8920),
            Con4Ati = ((int)0x8945),
            Con17Ati = ((int)0x8952),
            Reg25Ati = ((int)0x893a),
            Reg30Ati = ((int)0x893f),
            Con20Ati = ((int)0x8955),
            Reg19Ati = ((int)0x8934),
            LerpAti = ((int)0x8969),
            Con21Ati = ((int)0x8956),
            Reg8Ati = ((int)0x8929),
            Reg12Ati = ((int)0x892d),
            Con12Ati = ((int)0x894d),
            Con28Ati = ((int)0x895d),
            Reg11Ati = ((int)0x892c),
            Reg26Ati = ((int)0x893b),
            Reg31Ati = ((int)0x8940),
            Dot2AddAti = ((int)0x896c),
            NumInputInterpolatorComponentsAti = ((int)0x8973),
            Reg5Ati = ((int)0x8926),
            Con29Ati = ((int)0x895e),
            NumInstructionsPerPassAti = ((int)0x8971),
            Con10Ati = ((int)0x894b),
            Con22Ati = ((int)0x8957),
            SwizzleStrqAti = ((int)0x897a),
            SwizzleStqAti = ((int)0x8977),
            AddAti = ((int)0x8963),
            Gl8xBitAti = ((int)0x00000004),
            Con6Ati = ((int)0x8947),
            Con1Ati = ((int)0x8942),
            Con11Ati = ((int)0x894c),
            Reg27Ati = ((int)0x893c),
            Dot3Ati = ((int)0x8966),
            Reg28Ati = ((int)0x893d),
            Con3Ati = ((int)0x8944),
            Con18Ati = ((int)0x8953),
            SwizzleStrqDqAti = ((int)0x897b),
            CompBitAti = ((int)0x00000002),
            Con23Ati = ((int)0x8958),
            Con5Ati = ((int)0x8946),
            Con19Ati = ((int)0x8954),
            SecondaryInterpolatorAti = ((int)0x896d),
            Reg13Ati = ((int)0x892e),
            Reg20Ati = ((int)0x8935),
            Con8Ati = ((int)0x8949),
            NumPassesAti = ((int)0x8970),
            Reg29Ati = ((int)0x893e),
            NegateBitAti = ((int)0x00000004),
            Gl4xBitAti = ((int)0x00000002),
            Reg2Ati = ((int)0x8923),
            Reg7Ati = ((int)0x8928),
            Reg9Ati = ((int)0x892a),
            GreenBitAti = ((int)0x00000002),
            Reg14Ati = ((int)0x892f),
            Reg0Ati = ((int)0x8921),
            Cnd0Ati = ((int)0x896b),
            SwizzleStrDrAti = ((int)0x8978),
            Reg15Ati = ((int)0x8930),
            Con13Ati = ((int)0x894e),
            Reg21Ati = ((int)0x8936),
            Reg6Ati = ((int)0x8927),
            SubAti = ((int)0x8965),
            Con24Ati = ((int)0x8959),
            Con25Ati = ((int)0x895a),
            MadAti = ((int)0x8968),
            SaturateBitAti = ((int)0x00000040),
            MulAti = ((int)0x8964),
            Con7Ati = ((int)0x8948),
            ColorAlphaPairingAti = ((int)0x8975),
            NumFragmentConstantsAti = ((int)0x896f),
            BlueBitAti = ((int)0x00000004),
            Con30Ati = ((int)0x895f),
            EighthBitAti = ((int)0x00000020),
            Reg16Ati = ((int)0x8931),
            MovAti = ((int)0x8961),
            Reg22Ati = ((int)0x8937),
            BiasBitAti = ((int)0x00000008),
            Con9Ati = ((int)0x894a),
            Con14Ati = ((int)0x894f),
            Con26Ati = ((int)0x895b),
            Con31Ati = ((int)0x8960),
            QuarterBitAti = ((int)0x00000010),
            NumFragmentRegistersAti = ((int)0x896e),
            SwizzleStqDqAti = ((int)0x8979),
            Con15Ati = ((int)0x8950),
            CndAti = ((int)0x896a),
            Reg18Ati = ((int)0x8933),
            Reg17Ati = ((int)0x8932),
            Reg23Ati = ((int)0x8938),
            NumLoopbackComponentsAti = ((int)0x8974),
            Reg4Ati = ((int)0x8925),
            Reg3Ati = ((int)0x8924),
            Con27Ati = ((int)0x895c),
            NumInstructionsTotalAti = ((int)0x8972),
            HalfBitAti = ((int)0x00000008),
            Reg1Ati = ((int)0x8922),
            SwizzleStrAti = ((int)0x8976),
            Con16Ati = ((int)0x8951),
            Reg24Ati = ((int)0x8939),
            Con0Ati = ((int)0x8941),
            Reg10Ati = ((int)0x892b),
            RedBitAti = ((int)0x00000001),
        }

        public enum AtiPnTriangles
        {
            MaxPnTrianglesTesselationLevelAti = ((int)0x87f1),
            PnTrianglesTesselationLevelAti = ((int)0x87f4),
            PnTrianglesNormalModeQuadraticAti = ((int)0x87f8),
            PnTrianglesAti = ((int)0x87f0),
            PnTrianglesPointModeCubicAti = ((int)0x87f6),
            PnTrianglesNormalModeLinearAti = ((int)0x87f7),
            PnTrianglesPointModeLinearAti = ((int)0x87f5),
            PnTrianglesNormalModeAti = ((int)0x87f3),
            PnTrianglesPointModeAti = ((int)0x87f2),
        }

        public enum AtiVertexArrayObject
        {
            DiscardAti = ((int)0x8763),
            DynamicAti = ((int)0x8761),
            ArrayObjectBufferAti = ((int)0x8766),
            PreserveAti = ((int)0x8762),
            StaticAti = ((int)0x8760),
            ObjectBufferUsageAti = ((int)0x8765),
            ObjectBufferSizeAti = ((int)0x8764),
            ArrayObjectOffsetAti = ((int)0x8767),
        }

        public enum ExtVertexShader
        {
            LocalConstantValueExt = ((int)0x87ec),
            OutputTextureCoord1Ext = ((int)0x879e),
            VertexShaderVariantsExt = ((int)0x87d0),
            OutputColor0Ext = ((int)0x879b),
            OpMaxExt = ((int)0x878a),
            OutputTextureCoord9Ext = ((int)0x87a6),
            VertexShaderBindingExt = ((int)0x8781),
            LocalExt = ((int)0x87c4),
            YExt = ((int)0x87d6),
            VertexShaderLocalsExt = ((int)0x87d3),
            MaxOptimizedVertexShaderInstructionsExt = ((int)0x87ca),
            MvpMatrixExt = ((int)0x87e3),
            OutputTextureCoord6Ext = ((int)0x87a3),
            OpCrossProductExt = ((int)0x8797),
            OpRoundExt = ((int)0x8790),
            OpMulExt = ((int)0x8786),
            LocalConstantExt = ((int)0x87c3),
            VariantDatatypeExt = ((int)0x87e5),
            OpMultiplyMatrixExt = ((int)0x8798),
            OutputTextureCoord7Ext = ((int)0x87a4),
            NegativeWExt = ((int)0x87dc),
            MaxVertexShaderLocalConstantsExt = ((int)0x87c8),
            OpClampExt = ((int)0x878e),
            NegativeOneExt = ((int)0x87df),
            OpLogBase2Ext = ((int)0x8792),
            OutputTextureCoord16Ext = ((int)0x87ad),
            ZeroExt = ((int)0x87dd),
            ZExt = ((int)0x87d7),
            OutputTextureCoord20Ext = ((int)0x87b1),
            OpSetLtExt = ((int)0x878d),
            OutputTextureCoord29Ext = ((int)0x87ba),
            OutputTextureCoord11Ext = ((int)0x87a8),
            FullRangeExt = ((int)0x87e1),
            OutputTextureCoord4Ext = ((int)0x87a1),
            MaxVertexShaderInstructionsExt = ((int)0x87c5),
            OutputTextureCoord30Ext = ((int)0x87bb),
            MatrixExt = ((int)0x87c0),
            InvariantDatatypeExt = ((int)0x87eb),
            OutputVertexExt = ((int)0x879a),
            OpFracExt = ((int)0x8789),
            OutputTextureCoord24Ext = ((int)0x87b5),
            VariantValueExt = ((int)0x87e4),
            OpMinExt = ((int)0x878b),
            OpFloorExt = ((int)0x878f),
            OpSubExt = ((int)0x8796),
            VertexShaderExt = ((int)0x8780),
            OutputTextureCoord5Ext = ((int)0x87a2),
            VertexShaderInvariantsExt = ((int)0x87d1),
            OutputTextureCoord18Ext = ((int)0x87af),
            OutputColor1Ext = ((int)0x879c),
            MaxVertexShaderInvariantsExt = ((int)0x87c7),
            VertexShaderInstructionsExt = ((int)0x87cf),
            VertexShaderLocalConstantsExt = ((int)0x87d2),
            OpIndexExt = ((int)0x8782),
            MaxOptimizedVertexShaderLocalConstantsExt = ((int)0x87cc),
            OutputTextureCoord13Ext = ((int)0x87aa),
            MaxOptimizedVertexShaderInvariantsExt = ((int)0x87cd),
            MaxOptimizedVertexShaderLocalsExt = ((int)0x87ce),
            VertexShaderOptimizedExt = ((int)0x87d4),
            OutputTextureCoord15Ext = ((int)0x87ac),
            MaxVertexShaderVariantsExt = ((int)0x87c6),
            InvariantExt = ((int)0x87c2),
            OutputTextureCoord26Ext = ((int)0x87b7),
            OutputTextureCoord10Ext = ((int)0x87a7),
            OutputTextureCoord25Ext = ((int)0x87b6),
            OutputFogExt = ((int)0x87bd),
            MaxVertexShaderLocalsExt = ((int)0x87c9),
            OutputTextureCoord21Ext = ((int)0x87b2),
            OneExt = ((int)0x87de),
            OpDot3Ext = ((int)0x8784),
            VariantArrayPointerExt = ((int)0x87e9),
            NormalizedRangeExt = ((int)0x87e0),
            VariantArrayTypeExt = ((int)0x87e7),
            OpExpBase2Ext = ((int)0x8791),
            OutputTextureCoord3Ext = ((int)0x87a0),
            OutputTextureCoord2Ext = ((int)0x879f),
            OpDot4Ext = ((int)0x8785),
            OutputTextureCoord31Ext = ((int)0x87bc),
            OpMovExt = ((int)0x8799),
            WExt = ((int)0x87d8),
            OutputTextureCoord22Ext = ((int)0x87b3),
            OpMaddExt = ((int)0x8788),
            NegativeXExt = ((int)0x87d9),
            VariantArrayExt = ((int)0x87e8),
            InvariantValueExt = ((int)0x87ea),
            OpAddExt = ((int)0x8787),
            OpRecipSqrtExt = ((int)0x8795),
            LocalConstantDatatypeExt = ((int)0x87ed),
            OpNegateExt = ((int)0x8783),
            NegativeYExt = ((int)0x87da),
            OutputTextureCoord0Ext = ((int)0x879d),
            OutputTextureCoord27Ext = ((int)0x87b8),
            MaxOptimizedVertexShaderVariantsExt = ((int)0x87cb),
            OutputTextureCoord28Ext = ((int)0x87b9),
            OutputTextureCoord17Ext = ((int)0x87ae),
            OpPowerExt = ((int)0x8793),
            OutputTextureCoord19Ext = ((int)0x87b0),
            OutputTextureCoord8Ext = ((int)0x87a5),
            VariantExt = ((int)0x87c1),
            CurrentVertexExt = ((int)0x87e2),
            VariantArrayStrideExt = ((int)0x87e6),
            NegativeZExt = ((int)0x87db),
            OutputTextureCoord12Ext = ((int)0x87a9),
            XExt = ((int)0x87d5),
            OpRecipExt = ((int)0x8794),
            OpSetGeExt = ((int)0x878c),
            ScalarExt = ((int)0x87be),
            OutputTextureCoord23Ext = ((int)0x87b4),
            OutputTextureCoord14Ext = ((int)0x87ab),
            VectorExt = ((int)0x87bf),
        }

        public enum AtiVertexStreams
        {
            VertexStream2Ati = ((int)0x876e),
            VertexStream5Ati = ((int)0x8771),
            VertexSourceAti = ((int)0x8774),
            VertexStream0Ati = ((int)0x876c),
            VertexStream3Ati = ((int)0x876f),
            VertexStream6Ati = ((int)0x8772),
            MaxVertexStreamsAti = ((int)0x876b),
            VertexStream1Ati = ((int)0x876d),
            VertexStream4Ati = ((int)0x8770),
            VertexStream7Ati = ((int)0x8773),
        }

        public enum AtiElementArray
        {
            ElementArrayTypeAti = ((int)0x8769),
            ElementArrayAti = ((int)0x8768),
            ElementArrayPointerAti = ((int)0x876a),
        }

        public enum SunMeshArray
        {
            QuadMeshSun = ((int)0x8614),
            TriangleMeshSun = ((int)0x8615),
        }

        public enum SunSliceAccum
        {
            SliceAccumSun = ((int)0x85cc),
        }

        public enum NvMultisampleFilterHint
        {
            MultisampleFilterHintNv = ((int)0x8534),
        }

        public enum NvDepthClamp
        {
            DepthClampNv = ((int)0x864f),
        }

        public enum NvOcclusionQuery
        {
            PixelCounterBitsNv = ((int)0x8864),
            PixelCountNv = ((int)0x8866),
            CurrentOcclusionQueryIdNv = ((int)0x8865),
            PixelCountAvailableNv = ((int)0x8867),
        }

        public enum NvPointSprite
        {
            CoordReplaceNv = ((int)0x8862),
            PointSpriteRModeNv = ((int)0x8863),
            PointSpriteNv = ((int)0x8861),
        }

        public enum NvTextureShader3
        {
            DependentRgbTextureCubeMapNv = ((int)0x885a),
            DependentRgbTexture3dNv = ((int)0x8859),
            OffsetHiloTextureRectangleNv = ((int)0x8855),
            DotProductTexture1dNv = ((int)0x885c),
            SignedHilo8Nv = ((int)0x885f),
            DotProductAffineDepthReplaceNv = ((int)0x885d),
            OffsetProjectiveTexture2dNv = ((int)0x8850),
            DependentHiloTexture2dNv = ((int)0x8858),
            OffsetProjectiveTextureRectangleScaleNv = ((int)0x8853),
            OffsetHiloProjectiveTexture2dNv = ((int)0x8856),
            OffsetProjectiveTextureRectangleNv = ((int)0x8852),
            DotProductPassThroughNv = ((int)0x885b),
            Hilo8Nv = ((int)0x885e),
            OffsetHiloTexture2dNv = ((int)0x8854),
            OffsetHiloProjectiveTextureRectangleNv = ((int)0x8857),
            OffsetProjectiveTexture2dScaleNv = ((int)0x8851),
            ForceBlueToOneNv = ((int)0x8860),
        }

        public enum NvVertexProgram11
        {
        }

        public enum ExtShadowFuncs
        {
        }

        public enum ExtStencilTwoSide
        {
            StencilTestTwoSideExt = ((int)0x8910),
            ActiveStencilFaceExt = ((int)0x8911),
        }

        public enum AtiTextFragmentShader
        {
            TextFragmentShaderAti = ((int)0x8200),
        }

        public enum AppleClientStorage
        {
            UnpackClientStorageApple = ((int)0x85b2),
        }

        public enum AppleElementArray
        {
            ElementArrayPointerApple = ((int)0x876a),
            ElementArrayTypeApple = ((int)0x8769),
            ElementArrayApple = ((int)0x8768),
        }

        public enum AppleFence
        {
            FenceApple = ((int)0x8a0b),
            DrawPixelsApple = ((int)0x8a0a),
        }

        public enum AppleVertexArrayObject
        {
            VertexArrayBindingApple = ((int)0x85b5),
        }

        public enum AppleVertexArrayRange
        {
            VertexArrayRangePointerApple = ((int)0x8521),
            VertexArrayRangeLengthApple = ((int)0x851e),
            VertexArrayRangeApple = ((int)0x851d),
            StorageCachedApple = ((int)0x85be),
            StorageSharedApple = ((int)0x85bf),
            VertexArrayStorageHintApple = ((int)0x851f),
        }

        public enum AppleYcbcr422
        {
            UnsignedShort88Apple = ((int)0x85ba),
            UnsignedShort88RevApple = ((int)0x85bb),
            Ycbcr422Apple = ((int)0x85b9),
        }

        public enum S3S3tc
        {
            Rgba4S3tc = ((int)0x83a3),
            RgbS3tc = ((int)0x83a0),
            Rgb4S3tc = ((int)0x83a1),
            RgbaS3tc = ((int)0x83a2),
        }

        public enum AtiDrawBuffers
        {
            DrawBuffer2Ati = ((int)0x8827),
            DrawBuffer0Ati = ((int)0x8825),
            DrawBuffer7Ati = ((int)0x882c),
            DrawBuffer12Ati = ((int)0x8831),
            DrawBuffer6Ati = ((int)0x882b),
            DrawBuffer9Ati = ((int)0x882e),
            MaxDrawBuffersAti = ((int)0x8824),
            DrawBuffer1Ati = ((int)0x8826),
            DrawBuffer4Ati = ((int)0x8829),
            DrawBuffer8Ati = ((int)0x882d),
            DrawBuffer14Ati = ((int)0x8833),
            DrawBuffer15Ati = ((int)0x8834),
            DrawBuffer11Ati = ((int)0x8830),
            DrawBuffer10Ati = ((int)0x882f),
            DrawBuffer3Ati = ((int)0x8828),
            DrawBuffer5Ati = ((int)0x882a),
            DrawBuffer13Ati = ((int)0x8832),
        }

        public enum AtiPixelFormatFloat
        {
            TypeRgbaFloatAti = ((int)0x8820),
            ColorClearUnclampedValueAti = ((int)0x8835),
        }

        public enum AtiTextureEnvCombine3
        {
            ModulateSignedAddAti = ((int)0x8745),
            ModulateSubtractAti = ((int)0x8746),
            ModulateAddAti = ((int)0x8744),
        }

        public enum AtiTextureFloat
        {
            IntensityFloat32Ati = ((int)0x8817),
            LuminanceFloat32Ati = ((int)0x8818),
            RgbaFloat32Ati = ((int)0x8814),
            LuminanceFloat16Ati = ((int)0x881e),
            RgbFloat32Ati = ((int)0x8815),
            LuminanceAlphaFloat32Ati = ((int)0x8819),
            AlphaFloat32Ati = ((int)0x8816),
            RgbaFloat16Ati = ((int)0x881a),
            AlphaFloat16Ati = ((int)0x881c),
            LuminanceAlphaFloat16Ati = ((int)0x881f),
            IntensityFloat16Ati = ((int)0x881d),
            RgbFloat16Ati = ((int)0x881b),
        }

        public enum NvFloatBuffer
        {
            FloatRgNv = ((int)0x8881),
            FloatR16Nv = ((int)0x8884),
            TextureFloatComponentsNv = ((int)0x888c),
            FloatRNv = ((int)0x8880),
            FloatRgbaNv = ((int)0x8883),
            FloatClearColorValueNv = ((int)0x888d),
            FloatR32Nv = ((int)0x8885),
            FloatRgbaModeNv = ((int)0x888e),
            FloatRgba16Nv = ((int)0x888a),
            FloatRgb32Nv = ((int)0x8889),
            FloatRgb16Nv = ((int)0x8888),
            FloatRg16Nv = ((int)0x8886),
            FloatRgba32Nv = ((int)0x888b),
            FloatRgbNv = ((int)0x8882),
            FloatRg32Nv = ((int)0x8887),
        }

        public enum NvFragmentProgram
        {
            ProgramErrorStringNv = ((int)0x8874),
            FragmentProgramNv = ((int)0x8870),
            MaxFragmentProgramLocalParametersNv = ((int)0x8868),
            FragmentProgramBindingNv = ((int)0x8873),
            MaxTextureImageUnitsNv = ((int)0x8872),
            MaxTextureCoordsNv = ((int)0x8871),
        }

        public enum NvHalfFloat
        {
            HalfFloatNv = ((int)0x140b),
        }

        public enum NvPixelDataRange
        {
            ReadPixelDataRangeLengthNv = ((int)0x887b),
            ReadPixelDataRangeNv = ((int)0x8879),
            WritePixelDataRangeLengthNv = ((int)0x887a),
            ReadPixelDataRangePointerNv = ((int)0x887d),
            WritePixelDataRangePointerNv = ((int)0x887c),
            WritePixelDataRangeNv = ((int)0x8878),
        }

        public enum NvPrimitiveRestart
        {
            PrimitiveRestartIndexNv = ((int)0x8559),
            PrimitiveRestartNv = ((int)0x8558),
        }

        public enum NvTextureExpandNormal
        {
            TextureUnsignedRemapModeNv = ((int)0x888f),
        }

        public enum NvVertexProgram2
        {
        }

        public enum AtiMapObjectBuffer
        {
        }

        public enum AtiSeparateStencil
        {
            StencilBackPassDepthPassAti = ((int)0x8803),
            StencilBackFailAti = ((int)0x8801),
            StencilBackPassDepthFailAti = ((int)0x8802),
            StencilBackFuncAti = ((int)0x8800),
        }

        public enum AtiVertexAttribArrayObject
        {
        }

        public enum OesReadFormat
        {
            ImplementationColorReadFormatOes = ((int)0x8b9b),
            ImplementationColorReadTypeOes = ((int)0x8b9a),
        }

        public enum ExtDepthBoundsTest
        {
            DepthBoundsTestExt = ((int)0x8890),
            DepthBoundsExt = ((int)0x8891),
        }

        public enum ExtTextureMirrorClamp
        {
            MirrorClampExt = ((int)0x8742),
            MirrorClampToBorderExt = ((int)0x8912),
            MirrorClampToEdgeExt = ((int)0x8743),
        }

        public enum ExtBlendEquationSeparate
        {
            BlendEquationAlphaExt = ((int)0x883d),
            BlendEquationRgbExt = ((int)0x8009),
        }

        public enum MesaPackInvert
        {
            PackInvertMesa = ((int)0x8758),
        }

        public enum MesaYcbcrTexture
        {
            YcbcrMesa = ((int)0x8757),
            UnsignedShort88Mesa = ((int)0x85ba),
            UnsignedShort88RevMesa = ((int)0x85bb),
        }

        public enum ExtPixelBufferObject
        {
            PixelPackBufferBindingExt = ((int)0x88ed),
            PixelPackBufferExt = ((int)0x88eb),
            PixelUnpackBufferExt = ((int)0x88ec),
            PixelUnpackBufferBindingExt = ((int)0x88ef),
        }

        public enum NvFragmentProgramOption
        {
        }

        public enum NvFragmentProgram2
        {
            MaxProgramCallDepthNv = ((int)0x88f5),
            MaxProgramLoopCountNv = ((int)0x88f8),
            MaxProgramExecInstructionsNv = ((int)0x88f4),
            MaxProgramIfDepthNv = ((int)0x88f6),
            MaxProgramLoopDepthNv = ((int)0x88f7),
        }

        public enum NvVertexProgram2Option
        {
            MaxProgramCallDepthNv = ((int)0x88f5),
            MaxProgramExecInstructionsNv = ((int)0x88f4),
        }

        public enum NvVertexProgram3
        {
            MaxVertexTextureImageUnitsArb = ((int)0x8b4c),
        }

        public enum ExtFramebufferObject
        {
            FramebufferIncompleteMissingAttachmentExt = ((int)0x8cd7),
            ColorAttachment12Ext = ((int)0x8cec),
            ColorAttachment5Ext = ((int)0x8ce5),
            RenderbufferGreenSizeExt = ((int)0x8d51),
            MaxColorAttachmentsExt = ((int)0x8cdf),
            FramebufferIncompleteFormatsExt = ((int)0x8cda),
            RenderbufferStencilSizeExt = ((int)0x8d55),
            FramebufferUnsupportedExt = ((int)0x8cdd),
            ColorAttachment4Ext = ((int)0x8ce4),
            ColorAttachment1Ext = ((int)0x8ce1),
            FramebufferIncompleteDrawBufferExt = ((int)0x8cdb),
            ColorAttachment0Ext = ((int)0x8ce0),
            FramebufferBindingExt = ((int)0x8ca6),
            MaxRenderbufferSizeExt = ((int)0x84e8),
            FramebufferExt = ((int)0x8d40),
            RenderbufferDepthSizeExt = ((int)0x8d54),
            RenderbufferRedSizeExt = ((int)0x8d50),
            FramebufferCompleteExt = ((int)0x8cd5),
            ColorAttachment8Ext = ((int)0x8ce8),
            StencilIndex4Ext = ((int)0x8d47),
            RenderbufferBlueSizeExt = ((int)0x8d52),
            ColorAttachment10Ext = ((int)0x8cea),
            RenderbufferAlphaSizeExt = ((int)0x8d53),
            RenderbufferExt = ((int)0x8d41),
            FramebufferIncompleteDimensionsExt = ((int)0x8cd9),
            RenderbufferWidthExt = ((int)0x8d42),
            RenderbufferBindingExt = ((int)0x8ca7),
            RenderbufferHeightExt = ((int)0x8d43),
            DepthAttachmentExt = ((int)0x8d00),
            StencilIndex16Ext = ((int)0x8d49),
            ColorAttachment6Ext = ((int)0x8ce6),
            ColorAttachment3Ext = ((int)0x8ce3),
            InvalidFramebufferOperationExt = ((int)0x0506),
            FramebufferIncompleteReadBufferExt = ((int)0x8cdc),
            StencilAttachmentExt = ((int)0x8d20),
            FramebufferAttachmentTextureLevelExt = ((int)0x8cd2),
            ColorAttachment11Ext = ((int)0x8ceb),
            ColorAttachment14Ext = ((int)0x8cee),
            FramebufferAttachmentTextureCubeMapFaceExt = ((int)0x8cd3),
            StencilIndex8Ext = ((int)0x8d48),
            ColorAttachment9Ext = ((int)0x8ce9),
            FramebufferAttachmentTexture3dZoffsetExt = ((int)0x8cd4),
            FramebufferAttachmentObjectNameExt = ((int)0x8cd1),
            StencilIndex1Ext = ((int)0x8d46),
            FramebufferIncompleteAttachmentExt = ((int)0x8cd6),
            FramebufferAttachmentObjectTypeExt = ((int)0x8cd0),
            ColorAttachment13Ext = ((int)0x8ced),
            ColorAttachment7Ext = ((int)0x8ce7),
            ColorAttachment15Ext = ((int)0x8cef),
            RenderbufferInternalFormatExt = ((int)0x8d44),
            ColorAttachment2Ext = ((int)0x8ce2),
        }

        public enum GremedyStringMarker
        {
        }

        public enum ExtPackedDepthStencil
        {
            TextureStencilSizeExt = ((int)0x88f1),
            Depth24Stencil8Ext = ((int)0x88f0),
            DepthStencilExt = ((int)0x84f9),
            UnsignedInt248Ext = ((int)0x84fa),
        }

        public enum ExtStencilClearTag
        {
            StencilClearTagValueExt = ((int)0x88f3),
            StencilTagBitsExt = ((int)0x88f2),
        }

        public enum ExtTextureSrgb
        {
            Srgb8Alpha8Ext = ((int)0x8c43),
            Sluminance8Ext = ((int)0x8c47),
            Sluminance8Alpha8Ext = ((int)0x8c45),
            SluminanceExt = ((int)0x8c46),
            CompressedSluminanceAlphaExt = ((int)0x8c4b),
            CompressedSrgbAlphaExt = ((int)0x8c49),
            CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8c4f),
            Srgb8Ext = ((int)0x8c41),
            SrgbAlphaExt = ((int)0x8c42),
            CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8c4e),
            SluminanceAlphaExt = ((int)0x8c44),
            CompressedSluminanceExt = ((int)0x8c4a),
            SrgbExt = ((int)0x8c40),
            CompressedSrgbS3tcDxt1Ext = ((int)0x8c4c),
            CompressedSrgbExt = ((int)0x8c48),
            CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8c4d),
        }

        public enum ExtFramebufferBlit
        {
            DrawFramebufferBindingExt = ((int)0x8caa),
            ReadFramebufferExt = ((int)0x8ca8),
            ReadFramebufferBindingExt = ((int)0x8ca6),
            DrawFramebufferExt = ((int)0x8ca9),
        }

        public enum ExtFramebufferMultisample
        {
            FramebufferIncompleteMultisampleExt = ((int)0x8d56),
            RenderbufferSamplesExt = ((int)0x8cab),
            MaxSamplesExt = ((int)0x8d57),
        }

        public enum MesaxTextureStack
        {
            ProxyTexture1dStackMesax = ((int)0x875b),
            Texture2dStackBindingMesax = ((int)0x875e),
            Texture1dStackMesax = ((int)0x8759),
            Texture1dStackBindingMesax = ((int)0x875d),
            ProxyTexture2dStackMesax = ((int)0x875c),
            Texture2dStackMesax = ((int)0x875a),
        }

        public enum ExtTimerQuery
        {
            TimeElapsedExt = ((int)0x88bf),
        }

        public enum ExtGpuProgramParameters
        {
        }

        public enum AppleFlushBufferRange
        {
            BufferSerializedModifyApple = ((int)0x8a12),
            BufferFlushingUnmapApple = ((int)0x8a13),
        }

        public enum NvGpuProgram4
        {
            MaxProgramTexelOffsetNv = ((int)0x8905),
            MaxProgramAttribComponentsNv = ((int)0x8908),
            ProgramAttribComponentsNv = ((int)0x8906),
            MaxProgramGenericAttribsNv = ((int)0x8da5),
            ProgramResultComponentsNv = ((int)0x8907),
            MinProgramTexelOffsetNv = ((int)0x8904),
            MaxProgramResultComponentsNv = ((int)0x8909),
            MaxProgramGenericResultsNv = ((int)0x8da6),
        }

        public enum NvGeometryProgram4
        {
            FramebufferAttachmentTextureLayerExt = ((int)0x8cd4),
            LineStripAdjacencyExt = ((int)0x000b),
            FramebufferIncompleteLayerTargetsExt = ((int)0x8da8),
            FramebufferIncompleteLayerCountExt = ((int)0x8da9),
            GeometryProgramNv = ((int)0x8c26),
            GeometryVerticesOutExt = ((int)0x8dda),
            GeometryOutputTypeExt = ((int)0x8ddc),
            FramebufferAttachmentLayeredExt = ((int)0x8da7),
            LinesAdjacencyExt = ((int)0x000a),
            GeometryInputTypeExt = ((int)0x8ddb),
            MaxProgramOutputVerticesNv = ((int)0x8c27),
            MaxGeometryTextureImageUnitsExt = ((int)0x8c29),
            TrianglesAdjacencyExt = ((int)0x000c),
            ProgramPointSizeExt = ((int)0x8642),
            TriangleStripAdjacencyExt = ((int)0x000d),
            MaxProgramTotalOutputComponentsNv = ((int)0x8c28),
        }

        public enum ExtGeometryShader4
        {
            TriangleStripAdjacencyExt = ((int)0x000d),
            MaxGeometryUniformComponentsExt = ((int)0x8ddf),
            MaxGeometryTotalOutputComponentsExt = ((int)0x8de1),
            FramebufferAttachmentTextureLayerExt = ((int)0x8cd4),
            GeometryOutputTypeExt = ((int)0x8ddc),
            FramebufferAttachmentLayeredExt = ((int)0x8da7),
            TrianglesAdjacencyExt = ((int)0x000c),
            GeometryInputTypeExt = ((int)0x8ddb),
            MaxGeometryOutputVerticesExt = ((int)0x8de0),
            GeometryShaderExt = ((int)0x8dd9),
            LineStripAdjacencyExt = ((int)0x000b),
            MaxVaryingComponentsExt = ((int)0x8b4b),
            FramebufferIncompleteLayerTargetsExt = ((int)0x8da8),
            MaxVertexVaryingComponentsExt = ((int)0x8dde),
            MaxGeometryTextureImageUnitsExt = ((int)0x8c29),
            MaxGeometryVaryingComponentsExt = ((int)0x8ddd),
            ProgramPointSizeExt = ((int)0x8642),
            FramebufferIncompleteLayerCountExt = ((int)0x8da9),
            LinesAdjacencyExt = ((int)0x000a),
            GeometryVerticesOutExt = ((int)0x8dda),
        }

        public enum NvVertexProgram4
        {
            VertexAttribArrayIntegerNv = ((int)0x88fd),
        }

        public enum ExtGpuShader4
        {
            SamplerCubeShadowExt = ((int)0x8dc5),
            UnsignedIntVec2Ext = ((int)0x8dc6),
            UnsignedIntSamplerBufferExt = ((int)0x8dd8),
            UnsignedIntSampler1dExt = ((int)0x8dd1),
            Sampler2dArrayExt = ((int)0x8dc1),
            IntSampler2dArrayExt = ((int)0x8dcf),
            Sampler2dArrayShadowExt = ((int)0x8dc4),
            UnsignedIntSamplerCubeExt = ((int)0x8dd4),
            IntSampler2dExt = ((int)0x8dca),
            Sampler1dArrayShadowExt = ((int)0x8dc3),
            UnsignedIntVec4Ext = ((int)0x8dc8),
            UnsignedIntVec3Ext = ((int)0x8dc7),
            Sampler1dArrayExt = ((int)0x8dc0),
            SamplerBufferExt = ((int)0x8dc2),
            UnsignedIntSampler2dArrayExt = ((int)0x8dd7),
            UnsignedIntSampler2dRectExt = ((int)0x8dd5),
            IntSampler3dExt = ((int)0x8dcb),
            IntSampler1dArrayExt = ((int)0x8dce),
            UnsignedIntSampler3dExt = ((int)0x8dd3),
            UnsignedIntSampler1dArrayExt = ((int)0x8dd6),
            UnsignedIntSampler2dExt = ((int)0x8dd2),
            IntSampler1dExt = ((int)0x8dc9),
            IntSamplerBufferExt = ((int)0x8dd0),
            IntSamplerCubeExt = ((int)0x8dcc),
            IntSampler2dRectExt = ((int)0x8dcd),
        }

        public enum ExtDrawInstanced
        {
        }

        public enum ExtPackedFloat
        {
            RgbaSignedComponentsExt = ((int)0x8c3c),
            UnsignedInt10f11f11fRevExt = ((int)0x8c3b),
            R11fG11fB10fExt = ((int)0x8c3a),
        }

        public enum ExtTextureArray
        {
            FramebufferAttachmentTextureLayerExt = ((int)0x8cd4),
            Texture1dArrayExt = ((int)0x8c18),
            TextureBinding2dArrayExt = ((int)0x8c1d),
            CompareRefDepthToTextureExt = ((int)0x884e),
            ProxyTexture1dArrayExt = ((int)0x8c19),
            MaxArrayTextureLayersExt = ((int)0x88ff),
            TextureBinding1dArrayExt = ((int)0x8c1c),
            ProxyTexture2dArrayExt = ((int)0x8c1b),
            Texture2dArrayExt = ((int)0x8c1a),
        }

        public enum ExtTextureBufferObject
        {
            TextureBufferExt = ((int)0x8c2a),
            TextureBufferDataStoreBindingExt = ((int)0x8c2d),
            TextureBindingBufferExt = ((int)0x8c2c),
            TextureBufferFormatExt = ((int)0x8c2e),
            MaxTextureBufferSizeExt = ((int)0x8c2b),
        }

        public enum ExtTextureCompressionLatc
        {
            CompressedLuminanceLatc1Ext = ((int)0x8c70),
            CompressedSignedLuminanceLatc1Ext = ((int)0x8c71),
            CompressedSignedLuminanceAlphaLatc2Ext = ((int)0x8c73),
            CompressedLuminanceAlphaLatc2Ext = ((int)0x8c72),
        }

        public enum ExtTextureCompressionRgtc
        {
            CompressedSignedRedGreenRgtc2Ext = ((int)0x8dbe),
            CompressedRedRgtc1Ext = ((int)0x8dbb),
            CompressedRedGreenRgtc2Ext = ((int)0x8dbd),
            CompressedSignedRedRgtc1Ext = ((int)0x8dbc),
        }

        public enum ExtTextureSharedExponent
        {
            Rgb9E5Ext = ((int)0x8c3d),
            TextureSharedSizeExt = ((int)0x8c3f),
            UnsignedInt5999RevExt = ((int)0x8c3e),
        }

        public enum NvDepthBufferFloat
        {
            DepthComponent32fNv = ((int)0x8dab),
            DepthBufferFloatModeNv = ((int)0x8daf),
            Float32UnsignedInt248RevNv = ((int)0x8dad),
            Depth32fStencil8Nv = ((int)0x8dac),
        }

        public enum NvFragmentProgram4
        {
        }

        public enum NvFramebufferMultisampleCoverage
        {
            RenderbufferColorSamplesNv = ((int)0x8e10),
            MultisampleCoverageModesNv = ((int)0x8e12),
            MaxMultisampleCoverageModesNv = ((int)0x8e11),
            RenderbufferCoverageSamplesNv = ((int)0x8cab),
        }

        public enum ExtFramebufferSrgb
        {
            FramebufferSrgbExt = ((int)0x8db9),
            FramebufferSrgbCapableExt = ((int)0x8dba),
        }

        public enum NvGeometryShader4
        {
        }

        public enum NvParameterBufferObject
        {
            VertexProgramParameterBufferNv = ((int)0x8da2),
            FragmentProgramParameterBufferNv = ((int)0x8da4),
            MaxProgramParameterBufferSizeNv = ((int)0x8da1),
            GeometryProgramParameterBufferNv = ((int)0x8da3),
            MaxProgramParameterBufferBindingsNv = ((int)0x8da0),
        }

        public enum ExtDrawBuffers2
        {
        }

        public enum NvTransformFeedback
        {
            MaxTransformFeedbackSeparateAttribsNv = ((int)0x8c8b),
            ActiveVaryingMaxLengthNv = ((int)0x8c82),
            VertexIdNv = ((int)0x8c7b),
            SeparateAttribsNv = ((int)0x8c8d),
            MaxTransformFeedbackSeparateComponentsNv = ((int)0x8c80),
            TransformFeedbackBufferModeNv = ((int)0x8c7f),
            TransformFeedbackBufferNv = ((int)0x8c8e),
            BackSecondaryColorNv = ((int)0x8c78),
            TransformFeedbackBufferBindingNv = ((int)0x8c8f),
            TransformFeedbackVaryingsNv = ((int)0x8c83),
            RasterizerDiscardNv = ((int)0x8c89),
            TransformFeedbackBufferStartNv = ((int)0x8c84),
            InterleavedAttribsNv = ((int)0x8c8c),
            TransformFeedbackBufferSizeNv = ((int)0x8c85),
            TransformFeedbackRecordNv = ((int)0x8c86),
            PrimitiveIdNv = ((int)0x8c7c),
            PrimitivesGeneratedNv = ((int)0x8c87),
            TransformFeedbackAttribsNv = ((int)0x8c7e),
            ActiveVaryingsNv = ((int)0x8c81),
            TextureCoordNv = ((int)0x8c79),
            MaxTransformFeedbackInterleavedAttribsNv = ((int)0x8c8a),
            BackPrimaryColorNv = ((int)0x8c77),
            TransformFeedbackPrimitivesWrittenNv = ((int)0x8c88),
            GenericAttribNv = ((int)0x8c7d),
            ClipDistanceNv = ((int)0x8c7a),
        }

        public enum ExtBindableUniform
        {
            MaxGeometryBindableUniformsExt = ((int)0x8de4),
            UniformBufferExt = ((int)0x8dee),
            MaxFragmentBindableUniformsExt = ((int)0x8de3),
            MaxVertexBindableUniformsExt = ((int)0x8de2),
            UniformBufferBindingExt = ((int)0x8def),
            MaxBindableUniformSizeExt = ((int)0x8ded),
        }

        public enum ExtTextureInteger
        {
            Rgb8uiExt = ((int)0x8d7d),
            Rgba32iExt = ((int)0x8d82),
            Luminance16uiExt = ((int)0x8d7a),
            LuminanceAlpha32iExt = ((int)0x8d87),
            Intensity8iExt = ((int)0x8d91),
            Alpha32iExt = ((int)0x8d84),
            Intensity16uiExt = ((int)0x8d79),
            Rgba16uiExt = ((int)0x8d76),
            BgrIntegerExt = ((int)0x8d9a),
            BlueIntegerExt = ((int)0x8d96),
            Alpha32uiExt = ((int)0x8d72),
            Rgb32uiExt = ((int)0x8d71),
            BgraIntegerExt = ((int)0x8d9b),
            Rgba8iExt = ((int)0x8d8e),
            Rgb8iExt = ((int)0x8d8f),
            LuminanceAlpha8iExt = ((int)0x8d93),
            Luminance32iExt = ((int)0x8d86),
            RgbaIntegerExt = ((int)0x8d99),
            LuminanceAlpha32uiExt = ((int)0x8d75),
            Luminance8uiExt = ((int)0x8d80),
            Rgb16iExt = ((int)0x8d89),
            AlphaIntegerExt = ((int)0x8d97),
            Alpha8iExt = ((int)0x8d90),
            Luminance32uiExt = ((int)0x8d74),
            Luminance16iExt = ((int)0x8d8c),
            Alpha16uiExt = ((int)0x8d78),
            Rgba16iExt = ((int)0x8d88),
            Intensity32uiExt = ((int)0x8d73),
            LuminanceAlpha16iExt = ((int)0x8d8d),
            LuminanceAlpha16uiExt = ((int)0x8d7b),
            Rgb32iExt = ((int)0x8d83),
            RgbIntegerExt = ((int)0x8d98),
            Rgba8uiExt = ((int)0x8d7c),
            LuminanceAlphaIntegerExt = ((int)0x8d9d),
            GreenIntegerExt = ((int)0x8d95),
            Intensity8uiExt = ((int)0x8d7f),
            Intensity32iExt = ((int)0x8d85),
            LuminanceIntegerExt = ((int)0x8d9c),
            Luminance8iExt = ((int)0x8d92),
            Alpha8uiExt = ((int)0x8d7e),
            Rgba32uiExt = ((int)0x8d70),
            RedIntegerExt = ((int)0x8d94),
            RgbaIntegerModeExt = ((int)0x8d9e),
            LuminanceAlpha8uiExt = ((int)0x8d81),
            Alpha16iExt = ((int)0x8d8a),
            Intensity16iExt = ((int)0x8d8b),
            Rgb16uiExt = ((int)0x8d77),
        }

    }
}
