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
    /// Used in GL.HP.GetImageTransformParameter, GL.HP.ImageTransformParameter
    /// </summary>
    public enum HpImageTransform
    {
        /// <summary>
        /// Original was GL_IMAGE_SCALE_X_HP = 0x8155
        /// </summary>
        ImageScaleXHp = 0x8155,

        /// <summary>
        /// Original was GL_IMAGE_SCALE_Y_HP = 0x8156
        /// </summary>
        ImageScaleYHp = 0x8156,

        /// <summary>
        /// Original was GL_IMAGE_TRANSLATE_X_HP = 0x8157
        /// </summary>
        ImageTranslateXHp = 0x8157,

        /// <summary>
        /// Original was GL_IMAGE_TRANSLATE_Y_HP = 0x8158
        /// </summary>
        ImageTranslateYHp = 0x8158,

        /// <summary>
        /// Original was GL_IMAGE_ROTATE_ANGLE_HP = 0x8159
        /// </summary>
        ImageRotateAngleHp = 0x8159,

        /// <summary>
        /// Original was GL_IMAGE_ROTATE_ORIGIN_X_HP = 0x815A
        /// </summary>
        ImageRotateOriginXHp = 0x815a,

        /// <summary>
        /// Original was GL_IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B
        /// </summary>
        ImageRotateOriginYHp = 0x815b,

        /// <summary>
        /// Original was GL_IMAGE_MAG_FILTER_HP = 0x815C
        /// </summary>
        ImageMagFilterHp = 0x815c,

        /// <summary>
        /// Original was GL_IMAGE_MIN_FILTER_HP = 0x815D
        /// </summary>
        ImageMinFilterHp = 0x815d,

        /// <summary>
        /// Original was GL_IMAGE_CUBIC_WEIGHT_HP = 0x815E
        /// </summary>
        ImageCubicWeightHp = 0x815e,

        /// <summary>
        /// Original was GL_CUBIC_HP = 0x815F
        /// </summary>
        CubicHp = 0x815f,

        /// <summary>
        /// Original was GL_AVERAGE_HP = 0x8160
        /// </summary>
        AverageHp = 0x8160,

        /// <summary>
        /// Original was GL_IMAGE_TRANSFORM_2D_HP = 0x8161
        /// </summary>
        ImageTransform2DHp = 0x8161,

        /// <summary>
        /// Original was GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162
        /// </summary>
        PostImageTransformColorTableHp = 0x8162,

        /// <summary>
        /// Original was GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163
        /// </summary>
        ProxyPostImageTransformColorTableHp = 0x8163
    }
}
