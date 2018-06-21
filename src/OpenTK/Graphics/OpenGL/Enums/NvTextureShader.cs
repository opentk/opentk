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
    public enum NvTextureShader
    {
        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_RECTANGLE_NV = 0x864C
        /// </summary>
        OffsetTextureRectangleNv = 0x864c,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D
        /// </summary>
        OffsetTextureRectangleScaleNv = 0x864d,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E
        /// </summary>
        DotProductTextureRectangleNv = 0x864e,

        /// <summary>
        /// Original was GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9
        /// </summary>
        RgbaUnsignedDotProductMappingNv = 0x86d9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA
        /// </summary>
        UnsignedIntS8S888Nv = 0x86da,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB
        /// </summary>
        UnsignedInt88S8S8RevNv = 0x86db,

        /// <summary>
        /// Original was GL_DSDT_MAG_INTENSITY_NV = 0x86DC
        /// </summary>
        DsdtMagIntensityNv = 0x86dc,

        /// <summary>
        /// Original was GL_SHADER_CONSISTENT_NV = 0x86DD
        /// </summary>
        ShaderConsistentNv = 0x86dd,

        /// <summary>
        /// Original was GL_TEXTURE_SHADER_NV = 0x86DE
        /// </summary>
        TextureShaderNv = 0x86de,

        /// <summary>
        /// Original was GL_SHADER_OPERATION_NV = 0x86DF
        /// </summary>
        ShaderOperationNv = 0x86df,

        /// <summary>
        /// Original was GL_CULL_MODES_NV = 0x86E0
        /// </summary>
        CullModesNv = 0x86e0,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1
        /// </summary>
        OffsetTexture2DMatrixNv = 0x86e1,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1
        /// </summary>
        OffsetTextureMatrixNv = 0x86e1,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2
        /// </summary>
        OffsetTexture2DScaleNv = 0x86e2,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2
        /// </summary>
        OffsetTextureScaleNv = 0x86e2,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3
        /// </summary>
        OffsetTexture2DBiasNv = 0x86e3,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3
        /// </summary>
        OffsetTextureBiasNv = 0x86e3,

        /// <summary>
        /// Original was GL_PREVIOUS_TEXTURE_INPUT_NV = 0x86E4
        /// </summary>
        PreviousTextureInputNv = 0x86e4,

        /// <summary>
        /// Original was GL_CONST_EYE_NV = 0x86E5
        /// </summary>
        ConstEyeNv = 0x86e5,

        /// <summary>
        /// Original was GL_PASS_THROUGH_NV = 0x86E6
        /// </summary>
        PassThroughNv = 0x86e6,

        /// <summary>
        /// Original was GL_CULL_FRAGMENT_NV = 0x86E7
        /// </summary>
        CullFragmentNv = 0x86e7,

        /// <summary>
        /// Original was GL_OFFSET_TEXTURE_2D_NV = 0x86E8
        /// </summary>
        OffsetTexture2DNv = 0x86e8,

        /// <summary>
        /// Original was GL_DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9
        /// </summary>
        DependentArTexture2DNv = 0x86e9,

        /// <summary>
        /// Original was GL_DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA
        /// </summary>
        DependentGbTexture2DNv = 0x86ea,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_NV = 0x86EC
        /// </summary>
        DotProductNv = 0x86ec,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED
        /// </summary>
        DotProductDepthReplaceNv = 0x86ed,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE
        /// </summary>
        DotProductTexture2DNv = 0x86ee,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0
        /// </summary>
        DotProductTextureCubeMapNv = 0x86f0,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1
        /// </summary>
        DotProductDiffuseCubeMapNv = 0x86f1,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2
        /// </summary>
        DotProductReflectCubeMapNv = 0x86f2,

        /// <summary>
        /// Original was GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3
        /// </summary>
        DotProductConstEyeReflectCubeMapNv = 0x86f3,

        /// <summary>
        /// Original was GL_HILO_NV = 0x86F4
        /// </summary>
        HiloNv = 0x86f4,

        /// <summary>
        /// Original was GL_DSDT_NV = 0x86F5
        /// </summary>
        DsdtNv = 0x86f5,

        /// <summary>
        /// Original was GL_DSDT_MAG_NV = 0x86F6
        /// </summary>
        DsdtMagNv = 0x86f6,

        /// <summary>
        /// Original was GL_DSDT_MAG_VIB_NV = 0x86F7
        /// </summary>
        DsdtMagVibNv = 0x86f7,

        /// <summary>
        /// Original was GL_HILO16_NV = 0x86F8
        /// </summary>
        Hilo16Nv = 0x86f8,

        /// <summary>
        /// Original was GL_SIGNED_HILO_NV = 0x86F9
        /// </summary>
        SignedHiloNv = 0x86f9,

        /// <summary>
        /// Original was GL_SIGNED_HILO16_NV = 0x86FA
        /// </summary>
        SignedHilo16Nv = 0x86fa,

        /// <summary>
        /// Original was GL_SIGNED_RGBA_NV = 0x86FB
        /// </summary>
        SignedRgbaNv = 0x86fb,

        /// <summary>
        /// Original was GL_SIGNED_RGBA8_NV = 0x86FC
        /// </summary>
        SignedRgba8Nv = 0x86fc,

        /// <summary>
        /// Original was GL_SIGNED_RGB_NV = 0x86FE
        /// </summary>
        SignedRgbNv = 0x86fe,

        /// <summary>
        /// Original was GL_SIGNED_RGB8_NV = 0x86FF
        /// </summary>
        SignedRgb8Nv = 0x86ff,

        /// <summary>
        /// Original was GL_SIGNED_LUMINANCE_NV = 0x8701
        /// </summary>
        SignedLuminanceNv = 0x8701,

        /// <summary>
        /// Original was GL_SIGNED_LUMINANCE8_NV = 0x8702
        /// </summary>
        SignedLuminance8Nv = 0x8702,

        /// <summary>
        /// Original was GL_SIGNED_LUMINANCE_ALPHA_NV = 0x8703
        /// </summary>
        SignedLuminanceAlphaNv = 0x8703,

        /// <summary>
        /// Original was GL_SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704
        /// </summary>
        SignedLuminance8Alpha8Nv = 0x8704,

        /// <summary>
        /// Original was GL_SIGNED_ALPHA_NV = 0x8705
        /// </summary>
        SignedAlphaNv = 0x8705,

        /// <summary>
        /// Original was GL_SIGNED_ALPHA8_NV = 0x8706
        /// </summary>
        SignedAlpha8Nv = 0x8706,

        /// <summary>
        /// Original was GL_SIGNED_INTENSITY_NV = 0x8707
        /// </summary>
        SignedIntensityNv = 0x8707,

        /// <summary>
        /// Original was GL_SIGNED_INTENSITY8_NV = 0x8708
        /// </summary>
        SignedIntensity8Nv = 0x8708,

        /// <summary>
        /// Original was GL_DSDT8_NV = 0x8709
        /// </summary>
        Dsdt8Nv = 0x8709,

        /// <summary>
        /// Original was GL_DSDT8_MAG8_NV = 0x870A
        /// </summary>
        Dsdt8Mag8Nv = 0x870a,

        /// <summary>
        /// Original was GL_DSDT8_MAG8_INTENSITY8_NV = 0x870B
        /// </summary>
        Dsdt8Mag8Intensity8Nv = 0x870b,

        /// <summary>
        /// Original was GL_SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C
        /// </summary>
        SignedRgbUnsignedAlphaNv = 0x870c,

        /// <summary>
        /// Original was GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D
        /// </summary>
        SignedRgb8UnsignedAlpha8Nv = 0x870d,

        /// <summary>
        /// Original was GL_HI_SCALE_NV = 0x870E
        /// </summary>
        HiScaleNv = 0x870e,

        /// <summary>
        /// Original was GL_LO_SCALE_NV = 0x870F
        /// </summary>
        LoScaleNv = 0x870f,

        /// <summary>
        /// Original was GL_DS_SCALE_NV = 0x8710
        /// </summary>
        DsScaleNv = 0x8710,

        /// <summary>
        /// Original was GL_DT_SCALE_NV = 0x8711
        /// </summary>
        DtScaleNv = 0x8711,

        /// <summary>
        /// Original was GL_MAGNITUDE_SCALE_NV = 0x8712
        /// </summary>
        MagnitudeScaleNv = 0x8712,

        /// <summary>
        /// Original was GL_VIBRANCE_SCALE_NV = 0x8713
        /// </summary>
        VibranceScaleNv = 0x8713,

        /// <summary>
        /// Original was GL_HI_BIAS_NV = 0x8714
        /// </summary>
        HiBiasNv = 0x8714,

        /// <summary>
        /// Original was GL_LO_BIAS_NV = 0x8715
        /// </summary>
        LoBiasNv = 0x8715,

        /// <summary>
        /// Original was GL_DS_BIAS_NV = 0x8716
        /// </summary>
        DsBiasNv = 0x8716,

        /// <summary>
        /// Original was GL_DT_BIAS_NV = 0x8717
        /// </summary>
        DtBiasNv = 0x8717,

        /// <summary>
        /// Original was GL_MAGNITUDE_BIAS_NV = 0x8718
        /// </summary>
        MagnitudeBiasNv = 0x8718,

        /// <summary>
        /// Original was GL_VIBRANCE_BIAS_NV = 0x8719
        /// </summary>
        VibranceBiasNv = 0x8719,

        /// <summary>
        /// Original was GL_TEXTURE_BORDER_VALUES_NV = 0x871A
        /// </summary>
        TextureBorderValuesNv = 0x871a,

        /// <summary>
        /// Original was GL_TEXTURE_HI_SIZE_NV = 0x871B
        /// </summary>
        TextureHiSizeNv = 0x871b,

        /// <summary>
        /// Original was GL_TEXTURE_LO_SIZE_NV = 0x871C
        /// </summary>
        TextureLoSizeNv = 0x871c,

        /// <summary>
        /// Original was GL_TEXTURE_DS_SIZE_NV = 0x871D
        /// </summary>
        TextureDsSizeNv = 0x871d,

        /// <summary>
        /// Original was GL_TEXTURE_DT_SIZE_NV = 0x871E
        /// </summary>
        TextureDtSizeNv = 0x871e,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_SIZE_NV = 0x871F
        /// </summary>
        TextureMagSizeNv = 0x871f
    }
}
