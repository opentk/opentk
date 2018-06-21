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
    /// Used in GL.Arb.ClampColor
    /// </summary>
    public enum ArbColorBufferFloat
    {
        /// <summary>
        /// Original was GL_RGBA_FLOAT_MODE_ARB = 0x8820
        /// </summary>
        RgbaFloatModeArb = 0x8820,

        /// <summary>
        /// Original was GL_CLAMP_VERTEX_COLOR_ARB = 0x891A
        /// </summary>
        ClampVertexColorArb = 0x891a,

        /// <summary>
        /// Original was GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B
        /// </summary>
        ClampFragmentColorArb = 0x891b,

        /// <summary>
        /// Original was GL_CLAMP_READ_COLOR_ARB = 0x891C
        /// </summary>
        ClampReadColorArb = 0x891c,

        /// <summary>
        /// Original was GL_FIXED_ONLY_ARB = 0x891D
        /// </summary>
        FixedOnlyArb = 0x891d
    }
}
