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
    /// Used in GL.Arb.BeginQuery
    /// </summary>
    public enum ArbOcclusionQuery
    {
        /// <summary>
        /// Original was GL_QUERY_COUNTER_BITS_ARB = 0x8864
        /// </summary>
        QueryCounterBitsArb = 0x8864,

        /// <summary>
        /// Original was GL_CURRENT_QUERY_ARB = 0x8865
        /// </summary>
        CurrentQueryArb = 0x8865,

        /// <summary>
        /// Original was GL_QUERY_RESULT_ARB = 0x8866
        /// </summary>
        QueryResultArb = 0x8866,

        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867
        /// </summary>
        QueryResultAvailableArb = 0x8867,

        /// <summary>
        /// Original was GL_SAMPLES_PASSED_ARB = 0x8914
        /// </summary>
        SamplesPassedArb = 0x8914
    }
}
