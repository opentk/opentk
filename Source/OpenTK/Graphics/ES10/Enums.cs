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

    public enum All
    {
        False = ((int)0),
        NoError = ((int)0),
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
        Add = ((int)0X0104),
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
        StackOverflow = ((int)0X0503),
        StackUnderflow = ((int)0X0504),
        OutOfMemory = ((int)0X0505),
        Exp = ((int)0X0800),
        Exp2 = ((int)0X0801),
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
        PointSmooth = ((int)0X0b10),
        SmoothPointSizeRange = ((int)0X0b12),
        LineSmooth = ((int)0X0b20),
        SmoothLineWidthRange = ((int)0X0b22),
        CullFace = ((int)0X0b44),
        Lighting = ((int)0X0b50),
        LightModelTwoSide = ((int)0X0b52),
        LightModelAmbient = ((int)0X0b53),
        ColorMaterial = ((int)0X0b57),
        Fog = ((int)0X0b60),
        FogDensity = ((int)0X0b62),
        FogStart = ((int)0X0b63),
        FogEnd = ((int)0X0b64),
        FogMode = ((int)0X0b65),
        FogColor = ((int)0X0b66),
        DepthTest = ((int)0X0b71),
        StencilTest = ((int)0X0b90),
        Normalize = ((int)0X0ba1),
        AlphaTest = ((int)0X0bc0),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        ColorLogicOp = ((int)0X0bf2),
        ScissorTest = ((int)0X0c11),
        PerspectiveCorrectionHint = ((int)0X0c50),
        PointSmoothHint = ((int)0X0c51),
        LineSmoothHint = ((int)0X0c52),
        PolygonSmoothHint = ((int)0X0c53),
        FogHint = ((int)0X0c54),
        UnpackAlignment = ((int)0X0cf5),
        PackAlignment = ((int)0X0d05),
        MaxLights = ((int)0X0d31),
        MaxTextureSize = ((int)0X0d33),
        MaxModelviewStackDepth = ((int)0X0d36),
        MaxProjectionStackDepth = ((int)0X0d38),
        MaxTextureStackDepth = ((int)0X0d39),
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
        Ambient = ((int)0X1200),
        Diffuse = ((int)0X1201),
        Specular = ((int)0X1202),
        Position = ((int)0X1203),
        SpotDirection = ((int)0X1204),
        SpotExponent = ((int)0X1205),
        SpotCutoff = ((int)0X1206),
        ConstantAttenuation = ((int)0X1207),
        LinearAttenuation = ((int)0X1208),
        QuadraticAttenuation = ((int)0X1209),
        Byte = ((int)0X1400),
        UnsignedByte = ((int)0X1401),
        Short = ((int)0X1402),
        UnsignedShort = ((int)0X1403),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
        Clear = ((int)0X1500),
        And = ((int)0X1501),
        AndReverse = ((int)0X1502),
        Copy = ((int)0X1503),
        AndInverted = ((int)0X1504),
        Noop = ((int)0X1505),
        Xor = ((int)0X1506),
        Or = ((int)0X1507),
        Nor = ((int)0X1508),
        Equiv = ((int)0X1509),
        Invert = ((int)0X150a),
        OrReverse = ((int)0X150b),
        CopyInverted = ((int)0X150c),
        OrInverted = ((int)0X150d),
        Nand = ((int)0X150e),
        Set = ((int)0X150f),
        Emission = ((int)0X1600),
        Shininess = ((int)0X1601),
        AmbientAndDiffuse = ((int)0X1602),
        Modelview = ((int)0X1700),
        Projection = ((int)0X1701),
        Texture = ((int)0X1702),
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        LuminanceAlpha = ((int)0X190a),
        Flat = ((int)0X1d00),
        Smooth = ((int)0X1d01),
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
        Modulate = ((int)0X2100),
        Decal = ((int)0X2101),
        TextureEnvMode = ((int)0X2200),
        TextureEnvColor = ((int)0X2201),
        TextureEnv = ((int)0X2300),
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
        Light0 = ((int)0X4000),
        Light1 = ((int)0X4001),
        Light2 = ((int)0X4002),
        Light3 = ((int)0X4003),
        Light4 = ((int)0X4004),
        Light5 = ((int)0X4005),
        Light6 = ((int)0X4006),
        Light7 = ((int)0X4007),
        UnsignedShort4444 = ((int)0X8033),
        UnsignedShort5551 = ((int)0X8034),
        PolygonOffsetFill = ((int)0X8037),
        RescaleNormal = ((int)0X803a),
        VertexArray = ((int)0X8074),
        NormalArray = ((int)0X8075),
        ColorArray = ((int)0X8076),
        TextureCoordArray = ((int)0X8078),
        Multisample = ((int)0X809d),
        SampleAlphaToCoverage = ((int)0X809e),
        SampleAlphaToOne = ((int)0X809f),
        SampleCoverage = ((int)0X80a0),
        MaxElementsVertices = ((int)0X80e8),
        MaxElementsIndices = ((int)0X80e9),
        ClampToEdge = ((int)0X812f),
        UnsignedShort565 = ((int)0X8363),
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
        MaxTextureUnits = ((int)0X84e2),
        NumCompressedTextureFormats = ((int)0X86a2),
        CompressedTextureFormats = ((int)0X86a3),
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
        ImplementationColorReadTypeOes = ((int)0X8b9a),
        ImplementationColorReadFormatOes = ((int)0X8b9b),
        OesCompressedPalettedTexture = ((int)1),
        OesReadFormat = ((int)1),
        OesVersion10 = ((int)1),
        One = ((int)1),
        True = ((int)1),
    }

    public enum AlphaFunction
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

    public enum Boolean
    {
        False = ((int)0),
        True = ((int)1),
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
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
    }

    public enum EnableCap
    {
        PointSmooth = ((int)0X0b10),
        LineSmooth = ((int)0X0b20),
        CullFace = ((int)0X0b44),
        Lighting = ((int)0X0b50),
        ColorMaterial = ((int)0X0b57),
        Fog = ((int)0X0b60),
        DepthTest = ((int)0X0b71),
        StencilTest = ((int)0X0b90),
        Normalize = ((int)0X0ba1),
        AlphaTest = ((int)0X0bc0),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        ColorLogicOp = ((int)0X0bf2),
        ScissorTest = ((int)0X0c11),
        Texture2D = ((int)0X0de1),
        PolygonOffsetFill = ((int)0X8037),
        RescaleNormal = ((int)0X803a),
        VertexArray = ((int)0X8074),
        NormalArray = ((int)0X8075),
        ColorArray = ((int)0X8076),
        TextureCoordArray = ((int)0X8078),
        Multisample = ((int)0X809d),
        SampleAlphaToCoverage = ((int)0X809e),
        SampleAlphaToOne = ((int)0X809f),
        SampleCoverage = ((int)0X80a0),
    }

    public enum ErrorCode
    {
        NoError = ((int)0),
        InvalidEnum = ((int)0X0500),
        InvalidValue = ((int)0X0501),
        InvalidOperation = ((int)0X0502),
        StackOverflow = ((int)0X0503),
        StackUnderflow = ((int)0X0504),
        OutOfMemory = ((int)0X0505),
    }

    public enum Extensions
    {
        OesCompressedPalettedTexture = ((int)1),
        OesReadFormat = ((int)1),
        OesVersion10 = ((int)1),
    }

    public enum FogMode
    {
        Exp = ((int)0X0800),
        Exp2 = ((int)0X0801),
    }

    public enum FogParameter
    {
        FogDensity = ((int)0X0b62),
        FogStart = ((int)0X0b63),
        FogEnd = ((int)0X0b64),
        FogMode = ((int)0X0b65),
        FogColor = ((int)0X0b66),
    }

    public enum FrontFaceDirection
    {
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
    }

    public enum GetPName
    {
        SmoothPointSizeRange = ((int)0X0b12),
        SmoothLineWidthRange = ((int)0X0b22),
        MaxLights = ((int)0X0d31),
        MaxTextureSize = ((int)0X0d33),
        MaxModelviewStackDepth = ((int)0X0d36),
        MaxProjectionStackDepth = ((int)0X0d38),
        MaxTextureStackDepth = ((int)0X0d39),
        MaxViewportDims = ((int)0X0d3a),
        SubpixelBits = ((int)0X0d50),
        RedBits = ((int)0X0d52),
        GreenBits = ((int)0X0d53),
        BlueBits = ((int)0X0d54),
        AlphaBits = ((int)0X0d55),
        DepthBits = ((int)0X0d56),
        StencilBits = ((int)0X0d57),
        MaxElementsVertices = ((int)0X80e8),
        MaxElementsIndices = ((int)0X80e9),
        AliasedPointSizeRange = ((int)0X846d),
        AliasedLineWidthRange = ((int)0X846e),
        MaxTextureUnits = ((int)0X84e2),
        NumCompressedTextureFormats = ((int)0X86a2),
        CompressedTextureFormats = ((int)0X86a3),
        ImplementationColorReadTypeOes = ((int)0X8b9a),
        ImplementationColorReadFormatOes = ((int)0X8b9b),
    }

    public enum HintMode
    {
        DontCare = ((int)0X1100),
        Fastest = ((int)0X1101),
        Nicest = ((int)0X1102),
    }

    public enum HintTarget
    {
        PerspectiveCorrectionHint = ((int)0X0c50),
        PointSmoothHint = ((int)0X0c51),
        LineSmoothHint = ((int)0X0c52),
        PolygonSmoothHint = ((int)0X0c53),
        FogHint = ((int)0X0c54),
    }

    public enum LightModelParameter
    {
        LightModelTwoSide = ((int)0X0b52),
        LightModelAmbient = ((int)0X0b53),
    }

    public enum LightName
    {
        Light0 = ((int)0X4000),
        Light1 = ((int)0X4001),
        Light2 = ((int)0X4002),
        Light3 = ((int)0X4003),
        Light4 = ((int)0X4004),
        Light5 = ((int)0X4005),
        Light6 = ((int)0X4006),
        Light7 = ((int)0X4007),
    }

    public enum LightParameter
    {
        Ambient = ((int)0X1200),
        Diffuse = ((int)0X1201),
        Specular = ((int)0X1202),
        Position = ((int)0X1203),
        SpotDirection = ((int)0X1204),
        SpotExponent = ((int)0X1205),
        SpotCutoff = ((int)0X1206),
        ConstantAttenuation = ((int)0X1207),
        LinearAttenuation = ((int)0X1208),
        QuadraticAttenuation = ((int)0X1209),
    }

    public enum LogicOp
    {
        Clear = ((int)0X1500),
        And = ((int)0X1501),
        AndReverse = ((int)0X1502),
        Copy = ((int)0X1503),
        AndInverted = ((int)0X1504),
        Noop = ((int)0X1505),
        Xor = ((int)0X1506),
        Or = ((int)0X1507),
        Nor = ((int)0X1508),
        Equiv = ((int)0X1509),
        Invert = ((int)0X150a),
        OrReverse = ((int)0X150b),
        CopyInverted = ((int)0X150c),
        OrInverted = ((int)0X150d),
        Nand = ((int)0X150e),
        Set = ((int)0X150f),
    }

    public enum MaterialParameter
    {
        Emission = ((int)0X1600),
        Shininess = ((int)0X1601),
        AmbientAndDiffuse = ((int)0X1602),
    }

    public enum MatrixMode
    {
        Modelview = ((int)0X1700),
        Projection = ((int)0X1701),
        Texture = ((int)0X1702),
    }

    public enum PixelFormat
    {
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        LuminanceAlpha = ((int)0X190a),
    }

    public enum PixelInternalFormat
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
    }

    public enum PixelStoreParameter
    {
        UnpackAlignment = ((int)0X0cf5),
        PackAlignment = ((int)0X0d05),
    }

    public enum PixelType
    {
        UnsignedShort4444 = ((int)0X8033),
        UnsignedShort5551 = ((int)0X8034),
        UnsignedShort565 = ((int)0X8363),
    }

    public enum ShadingModel
    {
        Flat = ((int)0X1d00),
        Smooth = ((int)0X1d01),
    }

    public enum StencilOp
    {
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
    }

    public enum StringName
    {
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
    }

    public enum TextureEnvMode
    {
        Add = ((int)0X0104),
        Modulate = ((int)0X2100),
        Decal = ((int)0X2101),
    }

    public enum TextureEnvParameter
    {
        TextureEnvMode = ((int)0X2200),
        TextureEnvColor = ((int)0X2201),
    }

    public enum TextureEnvTarget
    {
        TextureEnv = ((int)0X2300),
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
    }

    public enum TextureWrapMode
    {
        Repeat = ((int)0X2901),
        ClampToEdge = ((int)0X812f),
    }

}
