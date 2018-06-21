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
    public enum ExtConvolution
    {
        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = 0x8011,

        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = 0x8012,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        /// </summary>
        ConvolutionBorderModeExt = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        /// </summary>
        ConvolutionFilterScaleExt = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        /// </summary>
        ConvolutionFilterBiasExt = 0x8015,

        /// <summary>
        /// Original was GL_REDUCE_EXT = 0x8016
        /// </summary>
        ReduceExt = 0x8016,

        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT_EXT = 0x8017
        /// </summary>
        ConvolutionFormatExt = 0x8017,

        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH_EXT = 0x8018
        /// </summary>
        ConvolutionWidthExt = 0x8018,

        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT_EXT = 0x8019
        /// </summary>
        ConvolutionHeightExt = 0x8019,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
        /// </summary>
        MaxConvolutionWidthExt = 0x801a,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
        /// </summary>
        MaxConvolutionHeightExt = 0x801b,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        /// </summary>
        PostConvolutionRedScaleExt = 0x801c,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        /// </summary>
        PostConvolutionGreenScaleExt = 0x801d,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        /// </summary>
        PostConvolutionBlueScaleExt = 0x801e,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        /// </summary>
        PostConvolutionAlphaScaleExt = 0x801f,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        /// </summary>
        PostConvolutionRedBiasExt = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        /// </summary>
        PostConvolutionGreenBiasExt = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        /// </summary>
        PostConvolutionBlueBiasExt = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        /// </summary>
        PostConvolutionAlphaBiasExt = 0x8023
    }
}
