#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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

#if GLES10

namespace OpenTK.Graphics.GLES10
{
    public enum Extensions
    {
        OesVersion10 = 1,
        OesReadFormat = 1,
        OesCompressedPalettedTexture = 1,
    }

    public enum ClearBufferMask
    {
        DepthBufferBit = 0x00000100,
        StencilBufferBit = 0x00000400,
        ColorBufferBit = 0x00004000,
    }

    public enum Boolean
    {
        False = 0,
        True = 1,
    }

    public enum BeginMode
    {
        Points = 0x0000,
        Lines = 0x0001,
        LineLoop = 0x0002,
        LineStrip = 0x0003,
        Triangles = 0x0004,
        TriangleStrip = 0x0005,
        TriangleFan = 0x0006,
    }

    public enum AlphaFunction
    {
        Never = 0x0200,
        Less = 0x0201,
        Equal = 0x0202,
        Lequal = 0x0203,
        Greater = 0x0204,
        Notequal = 0x0205,
        Gequal = 0x0206,
        Always = 0x0207,
    }

    public enum BlendingFactorDest
    {
        Zero = 0,
        One = 1,
        SrcColor = 0x0300,
        OneMinusSrcColor = 0x0301,
        SrcAlpha = 0x0302,
        OneMinusSrcAlpha = 0x0303,
        DstAlpha = 0x0304,
        OneMinusDstAlpha = 0x0305,
    }

    public enum BlendingFactorSrc
    {
        DstColor = 0x0306,
        OneMinusDstColor = 0x0307,
        SrcAlphaSaturate = 0x0308,
    }

    public enum CullFaceMode
    {
        Front = 0x0404,
        Back = 0x0405,
        FrontAndBack = 0x0408,
    }

    public enum EnableCap
    {
        Fog = 0x0B60,
        Lighting = 0x0B50,
        Texture2d = 0x0DE1,
        CullFace = 0x0B44,
        AlphaTest = 0x0BC0,
        Blend = 0x0BE2,
        ColorLogicOp = 0x0BF2,
        Dither = 0x0BD0,
        StencilTest = 0x0B90,
        DepthTest = 0x0B71,
        PointSmooth = 0x0B10,
        LineSmooth = 0x0B20,
        ScissorTest = 0x0C11,
        ColorMaterial = 0x0B57,
        Normalize = 0x0BA1,
        RescaleNormal = 0x803A,
        PolygonOffsetFill = 0x8037,
        VertexArray = 0x8074,
        NormalArray = 0x8075,
        ColorArray = 0x8076,
        TextureCoordArray = 0x8078,
        Multisample = 0x809D,
        SampleAlphaToCoverage = 0x809E,
        SampleAlphaToOne = 0x809F,
        SampleCoverage = 0x80A0,
    }

    public enum ErrorCode
    {
        NoError = 0,
        InvalidEnum = 0x0500,
        InvalidValue = 0x0501,
        InvalidOperation = 0x0502,
        StackOverflow = 0x0503,
        StackUnderflow = 0x0504,
        OutOfMemory = 0x0505,
    }

    public enum FogMode
    {
        Exp = 0x0800,
        Exp2 = 0x0801,
    }

    public enum FogParameter
    {
        FogDensity = 0x0B62,
        FogStart = 0x0B63,
        FogEnd = 0x0B64,
        FogMode = 0x0B65,
        FogColor = 0x0B66,
    }

    public enum FrontFaceDirection
    {
        Cw = 0x0900,
        Ccw = 0x0901,
    }

    public enum GetPName
    {
        SmoothPointSizeRange = 0x0B12,
        SmoothLineWidthRange = 0x0B22,
        AliasedPointSizeRange = 0x846D,
        AliasedLineWidthRange = 0x846E,
        ImplementationColorReadTypeOes = 0x8B9A,
        ImplementationColorReadFormatOes = 0x8B9B,
        MaxLights = 0x0D31,
        MaxTextureSize = 0x0D33,
        MaxModelviewStackDepth = 0x0D36,
        MaxProjectionStackDepth = 0x0D38,
        MaxTextureStackDepth = 0x0D39,
        MaxViewportDims = 0x0D3A,
        MaxElementsVertices = 0x80E8,
        MaxElementsIndices = 0x80E9,
        MaxTextureUnits = 0x84E2,
        NumCompressedTextureFormats = 0x86A2,
        CompressedTextureFormats = 0x86A3,
        SubpixelBits = 0x0D50,
        RedBits = 0x0D52,
        GreenBits = 0x0D53,
        BlueBits = 0x0D54,
        AlphaBits = 0x0D55,
        DepthBits = 0x0D56,
        StencilBits = 0x0D57,
    }

    public enum HintMode
    {
        DontCare = 0x1100,
        Fastest = 0x1101,
        Nicest = 0x1102,
    }

    public enum HintTarget
    {
        PerspectiveCorrectionHint = 0x0C50,
        PointSmoothHint = 0x0C51,
        LineSmoothHint = 0x0C52,
        PolygonSmoothHint = 0x0C53,
        FogHint = 0x0C54,
    }

    public enum LightModelParameter
    {
        LightModelAmbient = 0x0B53,
        LightModelTwoSide = 0x0B52,
    }

    public enum LightParameter
    {
        Ambient = 0x1200,
        Diffuse = 0x1201,
        Specular = 0x1202,
        Position = 0x1203,
        SpotDirection = 0x1204,
        SpotExponent = 0x1205,
        SpotCutoff = 0x1206,
        ConstantAttenuation = 0x1207,
        LinearAttenuation = 0x1208,
        QuadraticAttenuation = 0x1209,
    }

    public enum DataType
    {
        Byte = 0x1400,
        UnsignedByte = 0x1401,
        Short = 0x1402,
        UnsignedShort = 0x1403,
        Float = 0x1406,
        Fixed = 0x140C,
    }

    public enum LogicOp
    {
        Clear = 0x1500,
        And = 0x1501,
        AndReverse = 0x1502,
        Copy = 0x1503,
        AndInverted = 0x1504,
        Noop = 0x1505,
        Xor = 0x1506,
        Or = 0x1507,
        Nor = 0x1508,
        Equiv = 0x1509,
        Invert = 0x150A,
        OrReverse = 0x150B,
        CopyInverted = 0x150C,
        OrInverted = 0x150D,
        Nand = 0x150E,
        Set = 0x150F,
    }

    public enum MaterialParameter
    {
        Emission = 0x1600,
        Shininess = 0x1601,
        AmbientAndDiffuse = 0x1602,
    }

    public enum MatrixMode
    {
        Modelview = 0x1700,
        Projection = 0x1701,
        Texture = 0x1702,
    }

    public enum PixelFormat
    {
        Alpha = 0x1906,
        Rgb = 0x1907,
        Rgba = 0x1908,
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
    }

    public enum PixelStoreParameter
    {
        UnpackAlignment = 0x0CF5,
        PackAlignment = 0x0D05,
    }

    public enum PixelType
    {
        UnsignedShort4444 = 0x8033,
        UnsignedShort5551 = 0x8034,
        UnsignedShort565 = 0x8363,
    }

    public enum ShadingModel
    {
        Flat = 0x1D00,
        Smooth = 0x1D01,
    }

    public enum StencilOp
    {
        Keep = 0x1E00,
        Replace = 0x1E01,
        Incr = 0x1E02,
        Decr = 0x1E03,
    }

    public enum StringName
    {
        Vendor = 0x1F00,
        Renderer = 0x1F01,
        Version = 0x1F02,
        Extensions = 0x1F03,
    }

    public enum TextureEnvMode
    {
        Modulate = 0x2100,
        Decal = 0x2101,
        Add = 0x0104,
    }

    public enum TextureEnvParameter
    {
        TextureEnvMode = 0x2200,
        TextureEnvColor = 0x2201,
    }

    public enum TextureEnvTarget
    {
        TextureEnv = 0x2300,
    }

    public enum TextureMagFilter
    {
        Nearest = 0x2600,
        Linear = 0x2601,
    }

    public enum TextureMinFilter
    {
        NearestMipmapNearest = 0x2700,
        LinearMipmapNearest = 0x2701,
        NearestMipmapLinear = 0x2702,
        LinearMipmapLinear = 0x2703,
    }

    public enum TextureParameterName
    {
        TextureMagFilter = 0x2800,
        TextureMinFilter = 0x2801,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
    }

    public enum TextureUnit
    {
        Texture0 = 0x84C0,
        Texture1 = 0x84C1,
        Texture2 = 0x84C2,
        Texture3 = 0x84C3,
        Texture4 = 0x84C4,
        Texture5 = 0x84C5,
        Texture6 = 0x84C6,
        Texture7 = 0x84C7,
        Texture8 = 0x84C8,
        Texture9 = 0x84C9,
        Texture10 = 0x84CA,
        Texture11 = 0x84CB,
        Texture12 = 0x84CC,
        Texture13 = 0x84CD,
        Texture14 = 0x84CE,
        Texture15 = 0x84CF,
        Texture16 = 0x84D0,
        Texture17 = 0x84D1,
        Texture18 = 0x84D2,
        Texture19 = 0x84D3,
        Texture20 = 0x84D4,
        Texture21 = 0x84D5,
        Texture22 = 0x84D6,
        Texture23 = 0x84D7,
        Texture24 = 0x84D8,
        Texture25 = 0x84D9,
        Texture26 = 0x84DA,
        Texture27 = 0x84DB,
        Texture28 = 0x84DC,
        Texture29 = 0x84DD,
        Texture30 = 0x84DE,
        Texture31 = 0x84DF,
    }

    public enum TextureWrapMode
    {
        Repeat = 0x2901,
        ClampToEdge = 0x812F,
    }

    public enum PixelInternalFormat
    {
        Palette4Rgb8Oes = 0x8B90,
        Palette4Rgba8Oes = 0x8B91,
        Palette4R5G6B5Oes = 0x8B92,
        Palette4Rgba4Oes = 0x8B93,
        Palette4Rgb5A1Oes = 0x8B94,
        Palette8Rgb8Oes = 0x8B95,
        Palette8Rgba8Oes = 0x8B96,
        Palette8R5G6B5Oes = 0x8B97,
        Palette8Rgba4Oes = 0x8B98,
        Palette8Rgb5A1Oes = 0x8B99,
    }

    public enum LightName
    {
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
    }
}

#endif