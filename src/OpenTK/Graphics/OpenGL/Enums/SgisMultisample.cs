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
    public enum SgisMultisample
    {
        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = 0x80a0,

        /// <summary>
        /// Original was GL_1PASS_SGIS = 0x80A1
        /// </summary>
        Gl1PassSgis = 0x80a1,

        /// <summary>
        /// Original was GL_2PASS_0_SGIS = 0x80A2
        /// </summary>
        Gl2Pass0Sgis = 0x80a2,

        /// <summary>
        /// Original was GL_2PASS_1_SGIS = 0x80A3
        /// </summary>
        Gl2Pass1Sgis = 0x80a3,

        /// <summary>
        /// Original was GL_4PASS_0_SGIS = 0x80A4
        /// </summary>
        Gl4Pass0Sgis = 0x80a4,

        /// <summary>
        /// Original was GL_4PASS_1_SGIS = 0x80A5
        /// </summary>
        Gl4Pass1Sgis = 0x80a5,

        /// <summary>
        /// Original was GL_4PASS_2_SGIS = 0x80A6
        /// </summary>
        Gl4Pass2Sgis = 0x80a6,

        /// <summary>
        /// Original was GL_4PASS_3_SGIS = 0x80A7
        /// </summary>
        Gl4Pass3Sgis = 0x80a7,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        /// </summary>
        SampleBuffersSgis = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLES_SGIS = 0x80A9
        /// </summary>
        SamplesSgis = 0x80a9,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        /// </summary>
        SampleMaskValueSgis = 0x80aa,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        /// </summary>
        SampleMaskInvertSgis = 0x80ab,

        /// <summary>
        /// Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        /// </summary>
        SamplePatternSgis = 0x80ac
    }
}
