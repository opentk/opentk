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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.Arb.TexBuffer, GL.ColorTable and 32 other functions
    /// </summary>
    public enum InternalFormat
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = 0x1902,

        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = 0x1903,

        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = 0x1903,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = 0x2a10,

        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = 0x804e,

        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = 0x804f,

        /// <summary>
        /// Original was GL_RGB4_EXT = 0x804F
        /// </summary>
        Rgb4Ext = 0x804f,

        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = 0x8050,

        /// <summary>
        /// Original was GL_RGB5_EXT = 0x8050
        /// </summary>
        Rgb5Ext = 0x8050,

        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = 0x8051,

        /// <summary>
        /// Original was GL_RGB8_EXT = 0x8051
        /// </summary>
        Rgb8Ext = 0x8051,

        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = 0x8051,

        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = 0x8052,

        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = 0x8052,

        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = 0x8053,

        /// <summary>
        /// Original was GL_RGB12_EXT = 0x8053
        /// </summary>
        Rgb12Ext = 0x8053,

        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = 0x8054,

        /// <summary>
        /// Original was GL_RGB16_EXT = 0x8054
        /// </summary>
        Rgb16Ext = 0x8054,

        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = 0x8056,

        /// <summary>
        /// Original was GL_RGBA4_EXT = 0x8056
        /// </summary>
        Rgba4Ext = 0x8056,

        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = 0x8057,

        /// <summary>
        /// Original was GL_RGB5_A1_EXT = 0x8057
        /// </summary>
        Rgb5A1Ext = 0x8057,

        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = 0x8057,

        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = 0x8058,

        /// <summary>
        /// Original was GL_RGBA8_EXT = 0x8058
        /// </summary>
        Rgba8Ext = 0x8058,

        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = 0x8058,

        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = 0x8059,

        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = 0x8059,

        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = 0x805a,

        /// <summary>
        /// Original was GL_RGBA12_EXT = 0x805A
        /// </summary>
        Rgba12Ext = 0x805a,

        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = 0x805b,

        /// <summary>
        /// Original was GL_RGBA16_EXT = 0x805B
        /// </summary>
        Rgba16Ext = 0x805b,

        /// <summary>
        /// Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        /// </summary>
        DualAlpha4Sgis = 0x8110,

        /// <summary>
        /// Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        /// </summary>
        DualAlpha8Sgis = 0x8111,

        /// <summary>
        /// Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        /// </summary>
        DualAlpha12Sgis = 0x8112,

        /// <summary>
        /// Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        /// </summary>
        DualAlpha16Sgis = 0x8113,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        /// </summary>
        DualLuminance4Sgis = 0x8114,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        /// </summary>
        DualLuminance8Sgis = 0x8115,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        /// </summary>
        DualLuminance12Sgis = 0x8116,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        /// </summary>
        DualLuminance16Sgis = 0x8117,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        /// </summary>
        DualIntensity4Sgis = 0x8118,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        /// </summary>
        DualIntensity8Sgis = 0x8119,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        /// </summary>
        DualIntensity12Sgis = 0x811a,

        /// <summary>
        /// Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        /// </summary>
        DualIntensity16Sgis = 0x811b,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        /// </summary>
        DualLuminanceAlpha4Sgis = 0x811c,

        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        /// </summary>
        DualLuminanceAlpha8Sgis = 0x811d,

        /// <summary>
        /// Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        /// </summary>
        QuadAlpha4Sgis = 0x811e,

        /// <summary>
        /// Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        /// </summary>
        QuadAlpha8Sgis = 0x811f,

        /// <summary>
        /// Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        /// </summary>
        QuadLuminance4Sgis = 0x8120,

        /// <summary>
        /// Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        /// </summary>
        QuadLuminance8Sgis = 0x8121,

        /// <summary>
        /// Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        /// </summary>
        QuadIntensity4Sgis = 0x8122,

        /// <summary>
        /// Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        /// </summary>
        QuadIntensity8Sgis = 0x8123,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        /// </summary>
        DepthComponent16Arb = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        /// </summary>
        DepthComponent16Sgix = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        /// </summary>
        DepthComponent24Arb = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        /// </summary>
        DepthComponent24Sgix = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        /// </summary>
        DepthComponent32Arb = 0x81a7,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = 0x81a7,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        /// </summary>
        DepthComponent32Sgix = 0x81a7,

        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = 0x8225,

        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = 0x8226,

        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = 0x8227,

        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = 0x8229,

        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = 0x8229,

        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = 0x822a,

        /// <summary>
        /// Original was GL_R16_EXT = 0x822A
        /// </summary>
        R16Ext = 0x822a,

        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = 0x822b,

        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = 0x822b,

        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = 0x822c,

        /// <summary>
        /// Original was GL_RG16_EXT = 0x822C
        /// </summary>
        Rg16Ext = 0x822c,

        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = 0x822d,

        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = 0x822d,

        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = 0x822e,

        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = 0x822e,

        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = 0x822f,

        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = 0x822f,

        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = 0x8230,

        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = 0x8230,

        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = 0x8231,

        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = 0x8232,

        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = 0x8233,

        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = 0x8234,

        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = 0x8235,

        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = 0x8236,

        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = 0x8237,

        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = 0x8238,

        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = 0x8239,

        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = 0x823a,

        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = 0x823b,

        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = 0x823c,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = 0x83f0,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = 0x83f1,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        /// </summary>
        CompressedRgbaS3tcDxt3Ext = 0x83f2,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        /// </summary>
        CompressedRgbaS3tcDxt5Ext = 0x83f3,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = 0x84ed,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = 0x84ee,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        /// </summary>
        DepthStencilExt = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_NV = 0x84F9
        /// </summary>
        DepthStencilNv = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = 0x84f9,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_MESA = 0x8750
        /// </summary>
        DepthStencilMesa = 0x8750,

        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = 0x8814,

        /// <summary>
        /// Original was GL_RGBA32F_ARB = 0x8814
        /// </summary>
        Rgba32fArb = 0x8814,

        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = 0x8814,

        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = 0x881a,

        /// <summary>
        /// Original was GL_RGBA16F_ARB = 0x881A
        /// </summary>
        Rgba16fArb = 0x881a,

        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = 0x881a,

        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = 0x881b,

        /// <summary>
        /// Original was GL_RGB16F_ARB = 0x881B
        /// </summary>
        Rgb16fArb = 0x881b,

        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = 0x881b,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = 0x88f0,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        /// </summary>
        Depth24Stencil8Ext = 0x88f0,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = 0x88f0,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = 0x8c3a,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F_APPLE = 0x8C3A
        /// </summary>
        R11fG11fB10fApple = 0x8c3a,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        /// </summary>
        R11fG11fB10fExt = 0x8c3a,

        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = 0x8c3d,

        /// <summary>
        /// Original was GL_RGB9_E5_APPLE = 0x8C3D
        /// </summary>
        Rgb9E5Apple = 0x8c3d,

        /// <summary>
        /// Original was GL_RGB9_E5_EXT = 0x8C3D
        /// </summary>
        Rgb9E5Ext = 0x8c3d,

        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB8_EXT = 0x8C41
        /// </summary>
        Srgb8Ext = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB8_NV = 0x8C41
        /// </summary>
        Srgb8Nv = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB_ALPHA = 0x8C42
        /// </summary>
        SrgbAlpha = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = 0x8c43,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = 0x8c43,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB = 0x8C48
        /// </summary>
        CompressedSrgb = 0x8c48,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        /// </summary>
        CompressedSrgbAlpha = 0x8c49,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = 0x8c4c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = 0x8c4d,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = 0x8c4e,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = 0x8c4f,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = 0x8cac,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = 0x8cad,

        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = 0x8d70,

        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = 0x8d71,

        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = 0x8d76,

        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = 0x8d77,

        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = 0x8d7c,

        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = 0x8d7d,

        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = 0x8d82,

        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = 0x8d83,

        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = 0x8d88,

        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = 0x8d89,

        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = 0x8d8e,

        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = 0x8d8f,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        /// </summary>
        DepthComponent32fNv = 0x8dab,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        /// </summary>
        Depth32fStencil8Nv = 0x8dac,

        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = 0x8dbb,

        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
        /// </summary>
        CompressedRedRgtc1Ext = 0x8dbb,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = 0x8dbc,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1Ext = 0x8dbc,

        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = 0x8dbd,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = 0x8dbe,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = 0x8e8c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = 0x8e8d,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = 0x8e8e,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = 0x8e8f,

        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = 0x8f94,

        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = 0x8f95,

        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = 0x8f96,

        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = 0x8f97,

        /// <summary>
        /// Original was GL_R16_SNORM = 0x8F98
        /// </summary>
        R16Snorm = 0x8f98,

        /// <summary>
        /// Original was GL_R16_SNORM_EXT = 0x8F98
        /// </summary>
        R16SnormExt = 0x8f98,

        /// <summary>
        /// Original was GL_RG16_SNORM = 0x8F99
        /// </summary>
        Rg16Snorm = 0x8f99,

        /// <summary>
        /// Original was GL_RG16_SNORM_EXT = 0x8F99
        /// </summary>
        Rg16SnormExt = 0x8f99,

        /// <summary>
        /// Original was GL_RGB16_SNORM = 0x8F9A
        /// </summary>
        Rgb16Snorm = 0x8f9a,

        /// <summary>
        /// Original was GL_RGB16_SNORM_EXT = 0x8F9A
        /// </summary>
        Rgb16SnormExt = 0x8f9a,

        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = 0x906f,

        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = 0x9270,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = 0x9271,

        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = 0x9272,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = 0x9273,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = 0x9274,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = 0x9275,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = 0x9278,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = 0x9279
    }
}
