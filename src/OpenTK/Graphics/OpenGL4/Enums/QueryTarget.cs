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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.BeginQuery, GL.BeginQueryIndexed and 5 other functions
    /// </summary>
    public enum QueryTarget
    {
        /// <summary>
        /// Original was GL_TIME_ELAPSED = 0x88BF
        /// </summary>
        TimeElapsed = 0x88bf,

        /// <summary>
        /// Original was GL_SAMPLES_PASSED = 0x8914
        /// </summary>
        SamplesPassed = 0x8914,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        /// </summary>
        AnySamplesPassed = 0x8c2f,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED = 0x8C87
        /// </summary>
        PrimitivesGenerated = 0x8c87,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = 0x8c88,

        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        /// </summary>
        AnySamplesPassedConservative = 0x8d6a,

        /// <summary>
        /// Original was GL_TIMESTAMP = 0x8E28
        /// </summary>
        Timestamp = 0x8e28
    }
}
