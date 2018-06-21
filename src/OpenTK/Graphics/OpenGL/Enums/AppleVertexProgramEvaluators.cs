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
    /// Used in GL.Apple.DisableVertexAttrib, GL.Apple.EnableVertexAttrib and 1 other function
    /// </summary>
    public enum AppleVertexProgramEvaluators
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP1_APPLE = 0x8A00
        /// </summary>
        VertexAttribMap1Apple = 0x8a00,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP2_APPLE = 0x8A01
        /// </summary>
        VertexAttribMap2Apple = 0x8a01,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02
        /// </summary>
        VertexAttribMap1SizeApple = 0x8a02,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03
        /// </summary>
        VertexAttribMap1CoeffApple = 0x8a03,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04
        /// </summary>
        VertexAttribMap1OrderApple = 0x8a04,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05
        /// </summary>
        VertexAttribMap1DomainApple = 0x8a05,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06
        /// </summary>
        VertexAttribMap2SizeApple = 0x8a06,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07
        /// </summary>
        VertexAttribMap2CoeffApple = 0x8a07,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08
        /// </summary>
        VertexAttribMap2OrderApple = 0x8a08,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09
        /// </summary>
        VertexAttribMap2DomainApple = 0x8a09
    }
}
