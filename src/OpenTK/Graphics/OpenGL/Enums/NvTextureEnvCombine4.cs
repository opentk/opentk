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
    public enum NvTextureEnvCombine4
    {
        /// <summary>
        /// Original was GL_COMBINE4_NV = 0x8503
        /// </summary>
        Combine4Nv = 0x8503,

        /// <summary>
        /// Original was GL_SOURCE3_RGB_NV = 0x8583
        /// </summary>
        Source3RgbNv = 0x8583,

        /// <summary>
        /// Original was GL_SOURCE3_ALPHA_NV = 0x858B
        /// </summary>
        Source3AlphaNv = 0x858b,

        /// <summary>
        /// Original was GL_OPERAND3_RGB_NV = 0x8593
        /// </summary>
        Operand3RgbNv = 0x8593,

        /// <summary>
        /// Original was GL_OPERAND3_ALPHA_NV = 0x859B
        /// </summary>
        Operand3AlphaNv = 0x859b
    }
}
