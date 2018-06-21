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
    /// Used in GL.StencilFunc, GL.StencilFuncSeparate and 1 other function
    /// </summary>
    public enum StencilFunction
    {
        /// <summary>
        /// Original was GL_Never = 0X0200
        /// </summary>
        Never = 0X0200,

        /// <summary>
        /// Original was GL_Less = 0X0201
        /// </summary>
        Less = 0X0201,

        /// <summary>
        /// Original was GL_Equal = 0X0202
        /// </summary>
        Equal = 0X0202,

        /// <summary>
        /// Original was GL_Lequal = 0X0203
        /// </summary>
        Lequal = 0X0203,

        /// <summary>
        /// Original was GL_Greater = 0X0204
        /// </summary>
        Greater = 0X0204,

        /// <summary>
        /// Original was GL_Notequal = 0X0205
        /// </summary>
        Notequal = 0X0205,

        /// <summary>
        /// Original was GL_Gequal = 0X0206
        /// </summary>
        Gequal = 0X0206,

        /// <summary>
        /// Original was GL_Always = 0X0207
        /// </summary>
        Always = 0X0207
    }
}
