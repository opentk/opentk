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
    /// Used in GL.BufferData and GL.NamedBufferData, as well as 1 other function.
    /// </summary>
    public enum BufferUsageHint
    {
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = 0x88e0,

        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = 0x88e1,

        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = 0x88e2,

        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = 0x88e4,

        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = 0x88e5,

        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = 0x88e6,

        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = 0x88e8,

        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = 0x88e9,

        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = 0x88ea
    }
}
