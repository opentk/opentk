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

namespace OpenTK.Graphics.ES30
{
    /// <summary>
    /// Used in GL.GetInteger64, GL.GetInteger and 1 other function
    /// </summary>
    public enum GetIndexedPName
    {
        /// <summary>
        /// Original was GL_DRAW_BUFFER_EXT = 0x0C01
        /// </summary>
        DrawBufferExt = 0x0c01,

        /// <summary>
        /// Original was GL_READ_BUFFER_EXT = 0x0C02
        /// </summary>
        ReadBufferExt = 0x0c02,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_BINDING = 0x8A28
        /// </summary>
        UniformBufferBinding = 0x8a28,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_START = 0x8A29
        /// </summary>
        UniformBufferStart = 0x8a29,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_SIZE = 0x8A2A
        /// </summary>
        UniformBufferSize = 0x8a2a,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = 0x8c84,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = 0x8c85,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = 0x8c8f
    }
}
