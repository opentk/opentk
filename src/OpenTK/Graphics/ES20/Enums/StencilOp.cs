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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Used in GL.StencilOp, GL.StencilOpSeparate
    /// </summary>
    public enum StencilOp
    {
        /// <summary>
        /// Original was GL_Zero = 0X0000
        /// </summary>
        Zero = 0X0000,

        /// <summary>
        /// Original was GL_Invert = 0X150a
        /// </summary>
        Invert = 0X150a,

        /// <summary>
        /// Original was GL_Keep = 0X1e00
        /// </summary>
        Keep = 0X1e00,

        /// <summary>
        /// Original was GL_Replace = 0X1e01
        /// </summary>
        Replace = 0X1e01,

        /// <summary>
        /// Original was GL_Incr = 0X1e02
        /// </summary>
        Incr = 0X1e02,

        /// <summary>
        /// Original was GL_Decr = 0X1e03
        /// </summary>
        Decr = 0X1e03,

        /// <summary>
        /// Original was GL_IncrWrap = 0X8507
        /// </summary>
        IncrWrap = 0X8507,

        /// <summary>
        /// Original was GL_DecrWrap = 0X8508
        /// </summary>
        DecrWrap = 0X8508
    }
}
