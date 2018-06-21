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
    /// Used in GL.Ext.GetPixelTransformParameter, GL.Ext.PixelTransformParameter
    /// </summary>
    public enum ExtPixelTransform
    {
        /// <summary>
        /// Original was GL_PIXEL_TRANSFORM_2D_EXT = 0x8330
        /// </summary>
        PixelTransform2DExt = 0x8330,

        /// <summary>
        /// Original was GL_PIXEL_MAG_FILTER_EXT = 0x8331
        /// </summary>
        PixelMagFilterExt = 0x8331,

        /// <summary>
        /// Original was GL_PIXEL_MIN_FILTER_EXT = 0x8332
        /// </summary>
        PixelMinFilterExt = 0x8332,

        /// <summary>
        /// Original was GL_PIXEL_CUBIC_WEIGHT_EXT = 0x8333
        /// </summary>
        PixelCubicWeightExt = 0x8333,

        /// <summary>
        /// Original was GL_CUBIC_EXT = 0x8334
        /// </summary>
        CubicExt = 0x8334,

        /// <summary>
        /// Original was GL_AVERAGE_EXT = 0x8335
        /// </summary>
        AverageExt = 0x8335,

        /// <summary>
        /// Original was GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336
        /// </summary>
        PixelTransform2DStackDepthExt = 0x8336,

        /// <summary>
        /// Original was GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337
        /// </summary>
        MaxPixelTransform2DStackDepthExt = 0x8337,

        /// <summary>
        /// Original was GL_PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338
        /// </summary>
        PixelTransform2DMatrixExt = 0x8338
    }
}
