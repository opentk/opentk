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

namespace OpenTK.Graphics.ES10
{
    #pragma warning disable 1591

    public enum All : int
    {
        False = ((int)0),
        NoError = ((int)0),
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
        Exp = ((int)0x0800),
        Exp2 = ((int)0x0801),
        Cw = ((int)0x0900),
        Ccw = ((int)0x0901),
        PointSmooth = ((int)0x0B10),
        SmoothPointSizeRange = ((int)0x0B12),
        LineSmooth = ((int)0x0B20),
        SmoothLineWidthRange = ((int)0x0B22),
        CullFace = ((int)0x0B44),
        Lighting = ((int)0x0B50),
        LightModelTwoSide = ((int)0x0B52),
        LightModelAmbient = ((int)0x0B53),
        ColorMaterial = ((int)0x0B57),
        Fog = ((int)0x0B60),
        FogDensity = ((int)0x0B62),
        FogStart = ((int)0x0B63),
        FogEnd = ((int)0x0B64),
        FogMode = ((int)0x0B65),
        FogColor = ((int)0x0B66),
        DepthTest = ((int)0x0B71),
        StencilTest = ((int)0x0B90),
        Normalize = ((int)0x0BA1),
        AlphaTest = ((int)0x0BC0),
        Dither = ((int)0x0BD0),
        Blend = ((int)0x0BE2),
        ColorLogicOp = ((int)0x0BF2),
        ScissorTest = ((int)0x0C11),
        PerspectiveCorrectionHint = ((int)0x0C50),
        PointSmoothHint = ((int)0x0C51),
        LineSmoothHint = ((int)0x0C52),
        PolygonSmoothHint = ((int)0x0C53),
        FogHint = ((int)0x0C54),
        UnpackAlignment = ((int)0x0CF5),
        PackAlignment = ((int)0x0D05),
        MaxLights = ((int)0x0D31),
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
        Light0 = ((int)0x4000),
        Light1 = ((int)0x4001),
        Light2 = ((int)0x4002),
        Light3 = ((int)0x4003),
        Light4 = ((int)0x4004),
        Light5 = ((int)0x4005),
        Light6 = ((int)0x4006),
        Light7 = ((int)0x4007),
        UnsignedShort4444 = ((int)0x8033),
        UnsignedShort5551 = ((int)0x8034),
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
        MaxElementsVertices = ((int)0x80E8),
        MaxElementsIndices = ((int)0x80E9),
        ClampToEdge = ((int)0x812F),
        UnsignedShort565 = ((int)0x8363),
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
        MaxTextureUnits = ((int)0x84E2),
        NumCompressedTextureFormats = ((int)0x86A2),
        CompressedTextureFormats = ((int)0x86A3),
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
        OesCompressedPalettedTexture = ((int)1),
        OesReadFormat = ((int)1),
        OesVersion10 = ((int)1),
        One = ((int)1),
        True = ((int)1),
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

    public enum Extensions : int
    {
        OesCompressedPalettedTexture = ((int)1),
        OesReadFormat = ((int)1),
        OesVersion10 = ((int)1),
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
        SmoothPointSizeRange = ((int)0x0B12),
        SmoothLineWidthRange = ((int)0x0B22),
        MaxLights = ((int)0x0D31),
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
        MaxElementsVertices = ((int)0x80E8),
        MaxElementsIndices = ((int)0x80E9),
        AliasedPointSizeRange = ((int)0x846D),
        AliasedLineWidthRange = ((int)0x846E),
        MaxTextureUnits = ((int)0x84E2),
        NumCompressedTextureFormats = ((int)0x86A2),
        CompressedTextureFormats = ((int)0x86A3),
        ImplementationColorReadTypeOes = ((int)0x8B9A),
        ImplementationColorReadFormatOes = ((int)0x8B9B),
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
        PolygonSmoothHint = ((int)0x0C53),
        FogHint = ((int)0x0C54),
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

    public enum PixelFormat : int
    {
        Alpha = ((int)0x1906),
        Rgb = ((int)0x1907),
        Rgba = ((int)0x1908),
        Luminance = ((int)0x1909),
        LuminanceAlpha = ((int)0x190A),
    }

    public enum PixelInternalFormat : int
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
    }

    public enum TextureWrapMode : int
    {
        Repeat = ((int)0x2901),
        ClampToEdge = ((int)0x812F),
    }

}
