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
    /// Used in GL.NV.CoverFillPathInstanced and GL.NV.CoverStrokePathInstanced, as well as 4 other functions.
    /// </summary>
    public enum PathTransformType
    {
        /// <summary>
        /// Original was GL_NONE = 0x0
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Original was GL_TRANSLATE_XNV = 0x908E
        /// </summary>
        TranslateXNV = 0x908E,

        /// <summary>
        /// Original was GL_TRANSLATE_YNV = 0x908F
        /// </summary>
        TranslateYNV = 0x908F,

        /// <summary>
        /// Original was GL_TRANSLATE2_DNV = 0x9090
        /// </summary>
        Translate2DNV = 0x9090,

        /// <summary>
        /// Original was GL_TRANSLATE3_DNV = 0x9091
        /// </summary>
        Translate3DNV = 0x9091,

        /// <summary>
        /// Original was GL_AFFINE2_DNV = 0x9092
        /// </summary>
        Affine2DNV = 0x9092,

        /// <summary>
        /// Original was GL_AFFINE3_DNV = 0x9094
        /// </summary>
        Affine3DNV = 0x9094,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE2_DNV = 0x9096
        /// </summary>
        TransposeAffine2DNV = 0x9096,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE3_DNV = 0x9098
        /// </summary>
        TransposeAffine3DNV = 0x9098
    }
}
