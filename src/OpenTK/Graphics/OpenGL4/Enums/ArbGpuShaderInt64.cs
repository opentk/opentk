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
    /// Not used directly.
    /// </summary>
    public enum ArbGpuShaderInt64
    {
        /// <summary>
        /// Original was GL_INT64_ARB = 0x140E
        /// </summary>
        Int64Arb = 0x140e,

        /// <summary>
        /// Original was GL_UNSIGNED_INT64_ARB = 0x140F
        /// </summary>
        UnsignedInt64Arb = 0x140f,

        /// <summary>
        /// Original was GL_INT64_VEC2_ARB = 0x8FE9
        /// </summary>
        Int64Vec2Arb = 0x8fe9,

        /// <summary>
        /// Original was GL_INT64_VEC3_ARB = 0x8FEA
        /// </summary>
        Int64Vec3Arb = 0x8fea,

        /// <summary>
        /// Original was GL_INT64_VEC4_ARB = 0x8FEB
        /// </summary>
        Int64Vec4Arb = 0x8feb,

        /// <summary>
        /// Original was GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5
        /// </summary>
        UnsignedInt64Vec2Arb = 0x8ff5,

        /// <summary>
        /// Original was GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6
        /// </summary>
        UnsignedInt64Vec3Arb = 0x8ff6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7
        /// </summary>
        UnsignedInt64Vec4Arb = 0x8ff7
    }
}
