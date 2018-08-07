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
    /// Not used directly.
    /// </summary>
    public enum BeginMode
    {
        /// <summary>
        /// Original was GL_POINTS = 0x0
        /// </summary>
        Points = 0x0,

        /// <summary>
        /// Original was GL_LINES = 0x1
        /// </summary>
        Lines = 0x1,

        /// <summary>
        /// Original was GL_LINE_LOOP = 0x2
        /// </summary>
        LineLoop = 0x2,

        /// <summary>
        /// Original was GL_LINE_STRIP = 0x3
        /// </summary>
        LineStrip = 0x3,

        /// <summary>
        /// Original was GL_TRIANGLES = 0x4
        /// </summary>
        Triangles = 0x4,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x5
        /// </summary>
        TriangleStrip = 0x5,

        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x6
        /// </summary>
        TriangleFan = 0x6,

        /// <summary>
        /// Original was GL_LINES_ADJACENCY = 0xA
        /// </summary>
        LinesAdjacency = 0xA,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY = 0xB
        /// </summary>
        LineStripAdjacency = 0xB,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY = 0xC
        /// </summary>
        TrianglesAdjacency = 0xC,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY = 0xD
        /// </summary>
        TriangleStripAdjacency = 0xD,

        /// <summary>
        /// Original was GL_PATCHES = 0xE
        /// </summary>
        Patches = 0xE
    }
}
