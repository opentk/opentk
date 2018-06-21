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
    /// Used in GL.NV.GetVideo, GL.NV.PresentFrameDualFill and 1 other function
    /// </summary>
    public enum NvPresentVideo
    {
        /// <summary>
        /// Original was GL_FRAME_NV = 0x8E26
        /// </summary>
        FrameNv = 0x8e26,

        /// <summary>
        /// Original was GL_FIELDS_NV = 0x8E27
        /// </summary>
        FieldsNv = 0x8e27,

        /// <summary>
        /// Original was GL_CURRENT_TIME_NV = 0x8E28
        /// </summary>
        CurrentTimeNv = 0x8e28,

        /// <summary>
        /// Original was GL_NUM_FILL_STREAMS_NV = 0x8E29
        /// </summary>
        NumFillStreamsNv = 0x8e29,

        /// <summary>
        /// Original was GL_PRESENT_TIME_NV = 0x8E2A
        /// </summary>
        PresentTimeNv = 0x8e2a,

        /// <summary>
        /// Original was GL_PRESENT_DURATION_NV = 0x8E2B
        /// </summary>
        PresentDurationNv = 0x8e2b
    }
}
