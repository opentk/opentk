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
    /// Used in GL.Ati.ClientActiveVertexStream, GL.Ati.NormalStream3 and 5 other functions
    /// </summary>
    public enum AtiVertexStreams
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_STREAMS_ATI = 0x876B
        /// </summary>
        MaxVertexStreamsAti = 0x876b,

        /// <summary>
        /// Original was GL_VERTEX_STREAM0_ATI = 0x876C
        /// </summary>
        VertexStream0Ati = 0x876c,

        /// <summary>
        /// Original was GL_VERTEX_STREAM1_ATI = 0x876D
        /// </summary>
        VertexStream1Ati = 0x876d,

        /// <summary>
        /// Original was GL_VERTEX_STREAM2_ATI = 0x876E
        /// </summary>
        VertexStream2Ati = 0x876e,

        /// <summary>
        /// Original was GL_VERTEX_STREAM3_ATI = 0x876F
        /// </summary>
        VertexStream3Ati = 0x876f,

        /// <summary>
        /// Original was GL_VERTEX_STREAM4_ATI = 0x8770
        /// </summary>
        VertexStream4Ati = 0x8770,

        /// <summary>
        /// Original was GL_VERTEX_STREAM5_ATI = 0x8771
        /// </summary>
        VertexStream5Ati = 0x8771,

        /// <summary>
        /// Original was GL_VERTEX_STREAM6_ATI = 0x8772
        /// </summary>
        VertexStream6Ati = 0x8772,

        /// <summary>
        /// Original was GL_VERTEX_STREAM7_ATI = 0x8773
        /// </summary>
        VertexStream7Ati = 0x8773,

        /// <summary>
        /// Original was GL_VERTEX_SOURCE_ATI = 0x8774
        /// </summary>
        VertexSourceAti = 0x8774
    }
}
