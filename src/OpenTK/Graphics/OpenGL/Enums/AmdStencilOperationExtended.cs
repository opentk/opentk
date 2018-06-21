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
    /// Not used directly.
    /// </summary>
    public enum AmdStencilOperationExtended
    {
        /// <summary>
        /// Original was GL_SET_AMD = 0x874A
        /// </summary>
        SetAmd = 0x874a,

        /// <summary>
        /// Original was GL_REPLACE_VALUE_AMD = 0x874B
        /// </summary>
        ReplaceValueAmd = 0x874b,

        /// <summary>
        /// Original was GL_STENCIL_OP_VALUE_AMD = 0x874C
        /// </summary>
        StencilOpValueAmd = 0x874c,

        /// <summary>
        /// Original was GL_STENCIL_BACK_OP_VALUE_AMD = 0x874D
        /// </summary>
        StencilBackOpValueAmd = 0x874d
    }
}
