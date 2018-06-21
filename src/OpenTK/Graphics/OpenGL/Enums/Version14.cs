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
    public enum Version14
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
        FuncSubtract = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = 0x800b,

        /// <summary>
        /// Original was GL_BLEND_DST_RGB = 0x80C8
        /// </summary>
        BlendDstRgb = 0x80c8,

        /// <summary>
        /// Original was GL_BLEND_SRC_RGB = 0x80C9
        /// </summary>
        BlendSrcRgb = 0x80c9,

        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA = 0x80CA
        /// </summary>
        BlendDstAlpha = 0x80ca,

        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA = 0x80CB
        /// </summary>
        BlendSrcAlpha = 0x80cb,

        /// <summary>
        /// Original was GL_POINT_SIZE_MIN = 0x8126
        /// </summary>
        PointSizeMin = 0x8126,

        /// <summary>
        /// Original was GL_POINT_SIZE_MAX = 0x8127
        /// </summary>
        PointSizeMax = 0x8127,

        /// <summary>
        /// Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        /// </summary>
        PointFadeThresholdSize = 0x8128,

        /// <summary>
        /// Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        /// </summary>
        PointDistanceAttenuation = 0x8129,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = 0x8191,

        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = 0x8192,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81A6
        /// </summary>
        DepthComponent24 = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32 = 0x81A7
        /// </summary>
        DepthComponent32 = 0x81a7,

        /// <summary>
        /// Original was GL_MIRRORED_REPEAT = 0x8370
        /// </summary>
        MirroredRepeat = 0x8370,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_SOURCE = 0x8450
        /// </summary>
        FogCoordinateSource = 0x8450,

        /// <summary>
        /// Original was GL_FOG_COORDINATE = 0x8451
        /// </summary>
        FogCoordinate = 0x8451,

        /// <summary>
        /// Original was GL_FRAGMENT_DEPTH = 0x8452
        /// </summary>
        FragmentDepth = 0x8452,

        /// <summary>
        /// Original was GL_CURRENT_FOG_COORDINATE = 0x8453
        /// </summary>
        CurrentFogCoordinate = 0x8453,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454
        /// </summary>
        FogCoordinateArrayType = 0x8454,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455
        /// </summary>
        FogCoordinateArrayStride = 0x8455,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456
        /// </summary>
        FogCoordinateArrayPointer = 0x8456,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY = 0x8457
        /// </summary>
        FogCoordinateArray = 0x8457,

        /// <summary>
        /// Original was GL_COLOR_SUM = 0x8458
        /// </summary>
        ColorSum = 0x8458,

        /// <summary>
        /// Original was GL_CURRENT_SECONDARY_COLOR = 0x8459
        /// </summary>
        CurrentSecondaryColor = 0x8459,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A
        /// </summary>
        SecondaryColorArraySize = 0x845a,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B
        /// </summary>
        SecondaryColorArrayType = 0x845b,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C
        /// </summary>
        SecondaryColorArrayStride = 0x845c,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D
        /// </summary>
        SecondaryColorArrayPointer = 0x845d,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY = 0x845E
        /// </summary>
        SecondaryColorArray = 0x845e,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
        /// </summary>
        MaxTextureLodBias = 0x84fd,

        /// <summary>
        /// Original was GL_TEXTURE_FILTER_CONTROL = 0x8500
        /// </summary>
        TextureFilterControl = 0x8500,

        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS = 0x8501
        /// </summary>
        TextureLodBias = 0x8501,

        /// <summary>
        /// Original was GL_INCR_WRAP = 0x8507
        /// </summary>
        IncrWrap = 0x8507,

        /// <summary>
        /// Original was GL_DECR_WRAP = 0x8508
        /// </summary>
        DecrWrap = 0x8508,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_SIZE = 0x884A
        /// </summary>
        TextureDepthSize = 0x884a,

        /// <summary>
        /// Original was GL_DEPTH_TEXTURE_MODE = 0x884B
        /// </summary>
        DepthTextureMode = 0x884b,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = 0x884c,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = 0x884d,

        /// <summary>
        /// Original was GL_COMPARE_R_TO_TEXTURE = 0x884E
        /// </summary>
        CompareRToTexture = 0x884e
    }
}
