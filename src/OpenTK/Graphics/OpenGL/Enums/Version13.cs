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

using System;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version13
    {
        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT = 0x20000000
        /// </summary>
        MultisampleBit = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE = 0x809D
        /// </summary>
        Multisample = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        /// </summary>
        SampleAlphaToOne = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = 0x80a0,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = 0x80a9,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = 0x80aa,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = 0x80ab,

        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER = 0x812D
        /// </summary>
        ClampToBorder = 0x812d,

        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = 0x84c0,

        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = 0x84c1,

        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = 0x84c2,

        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = 0x84c3,

        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = 0x84c4,

        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = 0x84c5,

        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = 0x84c6,

        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = 0x84c7,

        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = 0x84c8,

        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = 0x84c9,

        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = 0x84ca,

        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = 0x84cb,

        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = 0x84cc,

        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = 0x84cd,

        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = 0x84ce,

        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = 0x84cf,

        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = 0x84d0,

        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = 0x84d1,

        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = 0x84d2,

        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = 0x84d3,

        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = 0x84d4,

        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = 0x84d5,

        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = 0x84d6,

        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = 0x84d7,

        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = 0x84d8,

        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = 0x84d9,

        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = 0x84da,

        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = 0x84db,

        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = 0x84dc,

        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = 0x84dd,

        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = 0x84de,

        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = 0x84df,

        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = 0x84e0,

        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = 0x84e1,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_UNITS = 0x84E2
        /// </summary>
        MaxTextureUnits = 0x84e2,

        /// <summary>
        /// Original was GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3
        /// </summary>
        TransposeModelviewMatrix = 0x84e3,

        /// <summary>
        /// Original was GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4
        /// </summary>
        TransposeProjectionMatrix = 0x84e4,

        /// <summary>
        /// Original was GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5
        /// </summary>
        TransposeTextureMatrix = 0x84e5,

        /// <summary>
        /// Original was GL_TRANSPOSE_COLOR_MATRIX = 0x84E6
        /// </summary>
        TransposeColorMatrix = 0x84e6,

        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = 0x84e7,

        /// <summary>
        /// Original was GL_COMPRESSED_ALPHA = 0x84E9
        /// </summary>
        CompressedAlpha = 0x84e9,

        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE = 0x84EA
        /// </summary>
        CompressedLuminance = 0x84ea,

        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB
        /// </summary>
        CompressedLuminanceAlpha = 0x84eb,

        /// <summary>
        /// Original was GL_COMPRESSED_INTENSITY = 0x84EC
        /// </summary>
        CompressedIntensity = 0x84ec,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = 0x84ed,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = 0x84ee,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        /// </summary>
        TextureCompressionHint = 0x84ef,

        /// <summary>
        /// Original was GL_NORMAL_MAP = 0x8511
        /// </summary>
        NormalMap = 0x8511,

        /// <summary>
        /// Original was GL_REFLECTION_MAP = 0x8512
        /// </summary>
        ReflectionMap = 0x8512,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        /// </summary>
        TextureBindingCubeMap = 0x8514,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = 0x851a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        /// </summary>
        ProxyTextureCubeMap = 0x851b,

        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
        /// </summary>
        MaxCubeMapTextureSize = 0x851c,

        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = 0x8570,

        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = 0x8571,

        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = 0x8572,

        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = 0x8573,

        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = 0x8574,

        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = 0x8575,

        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = 0x8576,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = 0x8577,

        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = 0x8578,

        /// <summary>
        /// Original was GL_SOURCE0_RGB = 0x8580
        /// </summary>
        Source0Rgb = 0x8580,

        /// <summary>
        /// Original was GL_SOURCE1_RGB = 0x8581
        /// </summary>
        Source1Rgb = 0x8581,

        /// <summary>
        /// Original was GL_SOURCE2_RGB = 0x8582
        /// </summary>
        Source2Rgb = 0x8582,

        /// <summary>
        /// Original was GL_SOURCE0_ALPHA = 0x8588
        /// </summary>
        Source0Alpha = 0x8588,

        /// <summary>
        /// Original was GL_SOURCE1_ALPHA = 0x8589
        /// </summary>
        Source1Alpha = 0x8589,

        /// <summary>
        /// Original was GL_SOURCE2_ALPHA = 0x858A
        /// </summary>
        Source2Alpha = 0x858a,

        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = 0x8590,

        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = 0x8591,

        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = 0x8592,

        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = 0x8598,

        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = 0x8599,

        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = 0x859a,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0
        /// </summary>
        TextureCompressedImageSize = 0x86a0,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        TextureCompressed = 0x86a1,

        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = 0x86a2,

        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = 0x86a3,

        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = 0x86ae,

        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = 0x86af
    }
}
