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
    public enum ArbMultisample
    {
        /// <summary>
        /// Original was GL_MULTISAMPLE_BIT_ARB = 0x20000000
        /// </summary>
        MultisampleBitArb = ((int)0x20000000),

        /// <summary>
        /// Original was GL_MULTISAMPLE_ARB = 0x809D
        /// </summary>
        MultisampleArb = 0x809d,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E
        /// </summary>
        SampleAlphaToCoverageArb = 0x809e,

        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F
        /// </summary>
        SampleAlphaToOneArb = 0x809f,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_ARB = 0x80A0
        /// </summary>
        SampleCoverageArb = 0x80a0,

        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS_ARB = 0x80A8
        /// </summary>
        SampleBuffersArb = 0x80a8,

        /// <summary>
        /// Original was GL_SAMPLES_ARB = 0x80A9
        /// </summary>
        SamplesArb = 0x80a9,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA
        /// </summary>
        SampleCoverageValueArb = 0x80aa,

        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB
        /// </summary>
        SampleCoverageInvertArb = 0x80ab
    }
}
