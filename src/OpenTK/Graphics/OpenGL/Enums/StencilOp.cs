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
    /// Used in GL.Ati.StencilOpSeparate, GL.StencilOp and 1 other function
    /// </summary>
    public enum StencilOp
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = 0x1e00,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1e01,

        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = 0x1e02,

        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = 0x1e03,

        /// <summary>
        /// Original was GL_INCR_WRAP = 0x8507
        /// </summary>
        IncrWrap = 0x8507,

        /// <summary>
        /// Original was GL_DECR_WRAP = 0x8508
        /// </summary>
        DecrWrap = 0x8508
    }
}
