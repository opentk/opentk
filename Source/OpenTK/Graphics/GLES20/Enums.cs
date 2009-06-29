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

#if GLES20

namespace OpekTN.Graphics.ES20
{
    public enum Version
    {
        EsVersion20 = 1,
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

    public enum BlendEquationSeparate
    {
        FuncAdd = 0x8006,
        BlendEquation = 0x8009,
        BlendEquationRgb = 0x8009    /* same as BLEND_EQUATION */,
        BlendEquationAlpha = 0x883D,
    }

    public enum BlendSubtract
    {
        FuncSubtract = 0x800A,
        FuncReverseSubtract = 0x800B,
    }

    public enum BlendFunctionSeparate
    {
        BlendDstRgb = 0x80C8,
        BlendSrcRgb = 0x80C9,
        BlendDstAlpha = 0x80CA,
        BlendSrcAlpha = 0x80CB,
        ConstantColor = 0x8001,
        OneMinusConstantColor = 0x8002,
        ConstantAlpha = 0x8003,
        OneMinusConstantAlpha = 0x8004,
        BlendColor = 0x8005,
    }

    public enum BufferObjects
    {
        ArrayBuffer = 0x8892,
        ElementArrayBuffer = 0x8893,
        ArrayBufferBinding = 0x8894,
        ElementArrayBufferBinding = 0x8895,

        StreamDraw = 0x88E0,
        StaticDraw = 0x88E4,
        DynamicDraw = 0x88E8,

        BufferSize = 0x8764,
        BufferUsage = 0x8765,

        CurrentVertexAttrib = 0x8626,
    }

    public enum CullFaceMode
    {
        Front = 0x0404,
        Back = 0x0405,
        FrontAndBack = 0x0408,
    }

    public enum EnableCap
    {
        Texture2d = 0x0DE1,
        CullFace = 0x0B44,
        Blend = 0x0BE2,
        Dither = 0x0BD0,
        StencilTest = 0x0B90,
        DepthTest = 0x0B71,
        ScissorTest = 0x0C11,
        PolygonOffsetFill = 0x8037,
        SampleAlphaToCoverage = 0x809E,
        SampleCoverage = 0x80A0,
    }

    public enum ErrorCode
    {
        NoError = 0,
        InvalidEnum = 0x0500,
        InvalidValue = 0x0501,
        InvalidOperation = 0x0502,
        OutOfMemory = 0x0505,
    }

    public enum FrontFaceDirection
    {
        Cw = 0x0900,
        Ccw = 0x0901,
    }

    public enum GetPName
    {
        LineWidth = 0x0B21,
        AliasedPointSizeRange = 0x846D,
        AliasedLineWidthRange = 0x846E,
        CullFaceMode = 0x0B45,
        FrontFace = 0x0B46,
        DepthRange = 0x0B70,
        DepthWritemask = 0x0B72,
        DepthClearValue = 0x0B73,
        DepthFunc = 0x0B74,
        StencilClearValue = 0x0B91,
        StencilFunc = 0x0B92,
        StencilFail = 0x0B94,
        StencilPassDepthFail = 0x0B95,
        StencilPassDepthPass = 0x0B96,
        StencilRef = 0x0B97,
        StencilValueMask = 0x0B93,
        StencilWritemask = 0x0B98,
        StencilBackFunc = 0x8800,
        StencilBackFail = 0x8801,
        StencilBackPassDepthFail = 0x8802,
        StencilBackPassDepthPass = 0x8803,
        StencilBackRef = 0x8CA3,
        StencilBackValueMask = 0x8CA4,
        StencilBackWritemask = 0x8CA5,
        Viewport = 0x0BA2,
        ScissorBox = 0x0C10,
        ColorClearValue = 0x0C22,
        ColorWritemask = 0x0C23,
        UnpackAlignment = 0x0CF5,
        PackAlignment = 0x0D05,
        MaxTextureSize = 0x0D33,
        MaxViewportDims = 0x0D3A,
        SubpixelBits = 0x0D50,
        RedBits = 0x0D52,
        GreenBits = 0x0D53,
        BlueBits = 0x0D54,
        AlphaBits = 0x0D55,
        DepthBits = 0x0D56,
        StencilBits = 0x0D57,
        PolygonOffsetUnits = 0x2A00,
        PolygonOffsetFactor = 0x8038,
        TextureBinding2d = 0x8069,
        SampleBuffers = 0x80A8,
        Samples = 0x80A9,
        SampleCoverageValue = 0x80AA,
        SampleCoverageInvert = 0x80AB,
    }

    public enum GetTextureParameter
    {
        NumCompressedTextureFormats = 0x86A2,
        CompressedTextureFormats = 0x86A3,
    }

    public enum HintMode
    {
        DontCare = 0x1100,
        Fastest = 0x1101,
        Nicest = 0x1102,
    }

    public enum HintTarget
    {
        GenerateMipmapHint = 0x8192,
    }

    public enum DataType
    {
        Byte = 0x1400,
        UnsignedByte = 0x1401,
        Short = 0x1402,
        UnsignedShort = 0x1403,
        Int = 0x1404,
        UnsignedInt = 0x1405,
        Float = 0x1406,
        Fixed = 0x140C,
    }

    public enum PixelFormat
    {
        DepthComponent = 0x1902,
        Alpha = 0x1906,
        Rgb = 0x1907,
        Rgba = 0x1908,
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
    }

    public enum PixelType
    {
        UnsignedShort4444 = 0x8033,
        UnsignedShort5551 = 0x8034,
        UnsignedShort565 = 0x8363,
    }

    public enum Shaders
    {
        FragmentShader = 0x8B30,
        VertexShader = 0x8B31,
        MaxVertexAttribs = 0x8869,
        MaxVertexUniformVectors = 0x8DFB,
        MaxVaryingVectors = 0x8DFC,
        MaxCombinedTextureImageUnits = 0x8B4D,
        MaxVertexTextureImageUnits = 0x8B4C,
        MaxTextureImageUnits = 0x8872,
        MaxFragmentUniformVectors = 0x8DFD,
        ShaderType = 0x8B4F,
        DeleteStatus = 0x8B80,
        LinkStatus = 0x8B82,
        ValidateStatus = 0x8B83,
        AttachedShaders = 0x8B85,
        ActiveUniforms = 0x8B86,
        ActiveUniformMaxLength = 0x8B87,
        ActiveAttributes = 0x8B89,
        ActiveAttributeMaxLength = 0x8B8A,
        ShadingLanguageVersion = 0x8B8C,
        CurrentProgram = 0x8B8D,
    }

    public enum StencilFunction
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

    public enum StencilOp
    {
        Keep = 0x1E00,
        Replace = 0x1E01,
        Incr = 0x1E02,
        Decr = 0x1E03,
        Invert = 0x150A,
        IncrWrap = 0x8507,
        DecrWrap = 0x8508,
    }

    public enum StringName
    {
        Vendor = 0x1F00,
        Renderer = 0x1F01,
        Version = 0x1F02,
        Extensions = 0x1F03,
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

    public enum TextureTarget
    {
        Texture = 0x1702,
        TextureCubeMap = 0x8513,
        TextureBindingCubeMap = 0x8514,
        TextureCubeMapPositiveX = 0x8515,
        TextureCubeMapNegativeX = 0x8516,
        TextureCubeMapPositiveY = 0x8517,
        TextureCubeMapNegativeY = 0x8518,
        TextureCubeMapPositiveZ = 0x8519,
        TextureCubeMapNegativeZ = 0x851A,
        MaxCubeMapTextureSize = 0x851C,
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
        ActiveTexture = 0x84E0,
    }

    public enum TextureWrapMode
    {
        Repeat = 0x2901,
        ClampToEdge = 0x812F,
        MirroredRepeat = 0x8370,
    }

    public enum UniformTypes
    {
        FloatVec2 = 0x8B50,
        FloatVec3 = 0x8B51,
        FloatVec4 = 0x8B52,
        IntVec2 = 0x8B53,
        IntVec3 = 0x8B54,
        IntVec4 = 0x8B55,
        Bool = 0x8B56,
        BoolVec2 = 0x8B57,
        BoolVec3 = 0x8B58,
        BoolVec4 = 0x8B59,
        FloatMat2 = 0x8B5A,
        FloatMat3 = 0x8B5B,
        FloatMat4 = 0x8B5C,
        Sampler2d = 0x8B5E,
        SamplerCube = 0x8B60,
    }

    public enum VertexArrays
    {
        VertexAttribArrayEnabled = 0x8622,
        VertexAttribArraySize = 0x8623,
        VertexAttribArrayStride = 0x8624,
        VertexAttribArrayType = 0x8625,
        VertexAttribArrayNormalized = 0x886A,
        VertexAttribArrayPointer = 0x8645,
        VertexAttribArrayBufferBinding = 0x889F,
    }

    public enum ReadFormat
    {
        ImplementationColorReadType = 0x8B9A,
        ImplementationColorReadFormat = 0x8B9B,
    }

    public enum ShaderSource
    {
        CompileStatus = 0x8B81,
        InfoLogLength = 0x8B84,
        ShaderSourceLength = 0x8B88,
        ShaderCompiler = 0x8DFA,
    }

    public enum ShaderBinary
    {
        ShaderBinaryFormats = 0x8DF8,
        NumShaderBinaryFormats = 0x8DF9,
    }

    public enum ShaderPrecision
    {
        LowFloat = 0x8DF0,
        MediumFloat = 0x8DF1,
        HighFloat = 0x8DF2,
        LowInt = 0x8DF3,
        MediumInt = 0x8DF4,
        HighInt = 0x8DF5,
    }

    public enum FramebufferObject
    {
        Framebuffer = 0x8D40,
        Renderbuffer = 0x8D41,

        Rgba4 = 0x8056,
        Rgb5A1 = 0x8057,
        Rgb565 = 0x8D62,
        DepthComponent16 = 0x81A5,
        StencilIndex = 0x1901,
        StencilIndex8 = 0x8D48,

        RenderbufferWidth = 0x8D42,
        RenderbufferHeight = 0x8D43,
        RenderbufferInternalFormat = 0x8D44,
        RenderbufferRedSize = 0x8D50,
        RenderbufferGreenSize = 0x8D51,
        RenderbufferBlueSize = 0x8D52,
        RenderbufferAlphaSize = 0x8D53,
        RenderbufferDepthSize = 0x8D54,
        RenderbufferStencilSize = 0x8D55,

        FramebufferAttachmentObjectType = 0x8CD0,
        FramebufferAttachmentObjectName = 0x8CD1,
        FramebufferAttachmentTextureLevel = 0x8CD2,
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,

        ColorAttachment0 = 0x8CE0,
        DepthAttachment = 0x8D00,
        StencilAttachment = 0x8D20,

        None = 0,

        FramebufferComplete = 0x8CD5,
        FramebufferIncompleteAttachment = 0x8CD6,
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        FramebufferIncompleteDimensions = 0x8CD9,
        FramebufferUnsupported = 0x8CDD,

        FramebufferBinding = 0x8CA6,
        RenderbufferBinding = 0x8CA7,
        MaxRenderbufferSize = 0x84E8,

        InvalidFramebufferOperation = 0x0506,
    }
}

#endif