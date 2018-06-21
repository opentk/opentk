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
    /// Used in GL.Amd.GetNamedFramebufferParameter
    /// </summary>
    public enum AmdFramebufferSamplePositions
    {
        /// <summary>
        /// Original was GL_SUBSAMPLE_DISTANCE_AMD = 0x883F
        /// </summary>
        SubsampleDistanceAmd = 0x883f,

        /// <summary>
        /// Original was GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD = 0x91AE
        /// </summary>
        PixelsPerSamplePatternXAmd = 0x91ae,

        /// <summary>
        /// Original was GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD = 0x91AF
        /// </summary>
        PixelsPerSamplePatternYAmd = 0x91af,

        /// <summary>
        /// Original was GL_ALL_PIXELS_AMD = 0xFFFFFFFF
        /// </summary>
        AllPixelsAmd = unchecked((int)0xffffffff)
    }
}
