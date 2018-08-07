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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbImaging
    {
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = 0x8001,

        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = 0x8002,

        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = 0x8003,

        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = 0x8004,

        /// <summary>
        /// Original was GL_BLEND_COLOR = 0x8005
        /// </summary>
        BlendColor = 0x8005,

        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = 0x8006,

        /// <summary>
        /// Original was GL_MIN = 0x8007
        /// </summary>
        Min = 0x8007,

        /// <summary>
        /// Original was GL_MAX = 0x8008
        /// </summary>
        Max = 0x8008,

        /// <summary>
        /// Original was GL_BLEND_EQUATION = 0x8009
        /// </summary>
        BlendEquation = 0x8009,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = 0x800A,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = 0x800B,

        /// <summary>
        /// Original was GL_CONVOLUTION1_D = 0x8010
        /// </summary>
        Convolution1D = 0x8010,

        /// <summary>
        /// Original was GL_CONVOLUTION2_D = 0x8011
        /// </summary>
        Convolution2D = 0x8011,

        /// <summary>
        /// Original was GL_SEPARABLE2_D = 0x8012
        /// </summary>
        Separable2D = 0x8012,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        /// </summary>
        ConvolutionBorderMode = 0x8013,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        /// </summary>
        ConvolutionFilterScale = 0x8014,

        /// <summary>
        /// Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        /// </summary>
        ConvolutionFilterBias = 0x8015,

        /// <summary>
        /// Original was GL_REDUCE = 0x8016
        /// </summary>
        Reduce = 0x8016,

        /// <summary>
        /// Original was GL_CONVOLUTION_FORMAT = 0x8017
        /// </summary>
        ConvolutionFormat = 0x8017,

        /// <summary>
        /// Original was GL_CONVOLUTION_WIDTH = 0x8018
        /// </summary>
        ConvolutionWidth = 0x8018,

        /// <summary>
        /// Original was GL_CONVOLUTION_HEIGHT = 0x8019
        /// </summary>
        ConvolutionHeight = 0x8019,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_WIDTH = 0x801A
        /// </summary>
        MaxConvolutionWidth = 0x801A,

        /// <summary>
        /// Original was GL_MAX_CONVOLUTION_HEIGHT = 0x801B
        /// </summary>
        MaxConvolutionHeight = 0x801B,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_SCALE = 0x801C
        /// </summary>
        PostConvolutionRedScale = 0x801C,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D
        /// </summary>
        PostConvolutionGreenScale = 0x801D,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E
        /// </summary>
        PostConvolutionBlueScale = 0x801E,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F
        /// </summary>
        PostConvolutionAlphaScale = 0x801F,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_RED_BIAS = 0x8020
        /// </summary>
        PostConvolutionRedBias = 0x8020,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021
        /// </summary>
        PostConvolutionGreenBias = 0x8021,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022
        /// </summary>
        PostConvolutionBlueBias = 0x8022,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023
        /// </summary>
        PostConvolutionAlphaBias = 0x8023,

        /// <summary>
        /// Original was GL_HISTOGRAM = 0x8024
        /// </summary>
        Histogram = 0x8024,

        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM = 0x8025
        /// </summary>
        ProxyHistogram = 0x8025,

        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH = 0x8026
        /// </summary>
        HistogramWidth = 0x8026,

        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT = 0x8027
        /// </summary>
        HistogramFormat = 0x8027,

        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        /// </summary>
        HistogramRedSize = 0x8028,

        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        /// </summary>
        HistogramGreenSize = 0x8029,

        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        /// </summary>
        HistogramBlueSize = 0x802A,

        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        /// </summary>
        HistogramAlphaSize = 0x802B,

        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        /// </summary>
        HistogramLuminanceSize = 0x802C,

        /// <summary>
        /// Original was GL_HISTOGRAM_SINK = 0x802D
        /// </summary>
        HistogramSink = 0x802D,

        /// <summary>
        /// Original was GL_MINMAX = 0x802E
        /// </summary>
        Minmax = 0x802E,

        /// <summary>
        /// Original was GL_MINMAX_FORMAT = 0x802F
        /// </summary>
        MinmaxFormat = 0x802F,

        /// <summary>
        /// Original was GL_MINMAX_SINK = 0x8030
        /// </summary>
        MinmaxSink = 0x8030,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE = 0x8031
        /// </summary>
        TableTooLarge = 0x8031,

        /// <summary>
        /// Original was GL_COLOR_MATRIX = 0x80B1
        /// </summary>
        ColorMatrix = 0x80B1,

        /// <summary>
        /// Original was GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2
        /// </summary>
        ColorMatrixStackDepth = 0x80B2,

        /// <summary>
        /// Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3
        /// </summary>
        MaxColorMatrixStackDepth = 0x80B3,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4
        /// </summary>
        PostColorMatrixRedScale = 0x80B4,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5
        /// </summary>
        PostColorMatrixGreenScale = 0x80B5,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6
        /// </summary>
        PostColorMatrixBlueScale = 0x80B6,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7
        /// </summary>
        PostColorMatrixAlphaScale = 0x80B7,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8
        /// </summary>
        PostColorMatrixRedBias = 0x80B8,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9
        /// </summary>
        PostColorMatrixGreenBias = 0x80B9,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA
        /// </summary>
        PostColorMatrixBlueBias = 0x80BA,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB
        /// </summary>
        PostColorMatrixAlphaBias = 0x80BB,

        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = 0x80D0,

        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = 0x80D1,

        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = 0x80D2,

        /// <summary>
        /// Original was GL_PROXY_COLOR_TABLE = 0x80D3
        /// </summary>
        ProxyColorTable = 0x80D3,

        /// <summary>
        /// Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
        /// </summary>
        ProxyPostConvolutionColorTable = 0x80D4,

        /// <summary>
        /// Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
        /// </summary>
        ProxyPostColorMatrixColorTable = 0x80D5,

        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = 0x80D6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = 0x80D7,

        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        /// </summary>
        ColorTableFormat = 0x80D8,

        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        /// </summary>
        ColorTableWidth = 0x80D9,

        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        /// </summary>
        ColorTableRedSize = 0x80DA,

        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        /// </summary>
        ColorTableGreenSize = 0x80DB,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        /// </summary>
        ColorTableBlueSize = 0x80DC,

        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        /// </summary>
        ColorTableAlphaSize = 0x80DD,

        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        /// </summary>
        ColorTableLuminanceSize = 0x80DE,

        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        /// </summary>
        ColorTableIntensitySize = 0x80DF,

        /// <summary>
        /// Original was GL_CONSTANT_BORDER = 0x8151
        /// </summary>
        ConstantBorder = 0x8151,

        /// <summary>
        /// Original was GL_REPLICATE_BORDER = 0x8153
        /// </summary>
        ReplicateBorder = 0x8153,

        /// <summary>
        /// Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        /// </summary>
        ConvolutionBorderColor = 0x8154
    }
}
