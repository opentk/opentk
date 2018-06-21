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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.GetObjectLabel, GL.ObjectLabel
    /// </summary>
    public enum ObjectLabelIdentifier
    {
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = 0x1702,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = 0x82e0,

        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = 0x82e1,

        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = 0x82e2,

        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = 0x82e3,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = 0x82e4,

        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = 0x82e6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = 0x8d41,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = 0x8e22
    }
}
