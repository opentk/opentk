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
    /// Used in GL.NV.AlphaToCoverageDitherControl
    /// </summary>
    public enum NvAlphaToCoverageDitherControl
    {
        /// <summary>
        /// Original was GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF
        /// </summary>
        AlphaToCoverageDitherModeNv = 0x92bf,

        /// <summary>
        /// Original was GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D
        /// </summary>
        AlphaToCoverageDitherDefaultNv = 0x934d,

        /// <summary>
        /// Original was GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E
        /// </summary>
        AlphaToCoverageDitherEnableNv = 0x934e,

        /// <summary>
        /// Original was GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F
        /// </summary>
        AlphaToCoverageDitherDisableNv = 0x934f
    }
}
