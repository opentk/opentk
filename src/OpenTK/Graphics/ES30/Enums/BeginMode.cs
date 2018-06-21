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
    /// Not used directly.
    /// </summary>
    public enum BeginMode
    {
        /// <summary>
        /// Original was GL_Points = 0X0000
        /// </summary>
        Points = 0X0000,

        /// <summary>
        /// Original was GL_Lines = 0X0001
        /// </summary>
        Lines = 0X0001,

        /// <summary>
        /// Original was GL_LineLoop = 0X0002
        /// </summary>
        LineLoop = 0X0002,

        /// <summary>
        /// Original was GL_LineStrip = 0X0003
        /// </summary>
        LineStrip = 0X0003,

        /// <summary>
        /// Original was GL_Triangles = 0X0004
        /// </summary>
        Triangles = 0X0004,

        /// <summary>
        /// Original was GL_TriangleStrip = 0X0005
        /// </summary>
        TriangleStrip = 0X0005,

        /// <summary>
        /// Original was GL_TriangleFan = 0X0006
        /// </summary>
        TriangleFan = 0X0006
    }
}
