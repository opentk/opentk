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
    public enum AmdGpuShaderHalfFloat
    {
        /// <summary>
        /// Original was GL_FLOAT16_NV = 0x8FF8
        /// </summary>
        Float16Nv = 0x8ff8,

        /// <summary>
        /// Original was GL_FLOAT16_VEC2_NV = 0x8FF9
        /// </summary>
        Float16Vec2Nv = 0x8ff9,

        /// <summary>
        /// Original was GL_FLOAT16_VEC3_NV = 0x8FFA
        /// </summary>
        Float16Vec3Nv = 0x8ffa,

        /// <summary>
        /// Original was GL_FLOAT16_VEC4_NV = 0x8FFB
        /// </summary>
        Float16Vec4Nv = 0x8ffb,

        /// <summary>
        /// Original was GL_FLOAT16_MAT2_AMD = 0x91C5
        /// </summary>
        Float16Mat2Amd = 0x91c5,

        /// <summary>
        /// Original was GL_FLOAT16_MAT3_AMD = 0x91C6
        /// </summary>
        Float16Mat3Amd = 0x91c6,

        /// <summary>
        /// Original was GL_FLOAT16_MAT4_AMD = 0x91C7
        /// </summary>
        Float16Mat4Amd = 0x91c7,

        /// <summary>
        /// Original was GL_FLOAT16_MAT2x3_AMD = 0x91C8
        /// </summary>
        Float16Mat2x3Amd = 0x91c8,

        /// <summary>
        /// Original was GL_FLOAT16_MAT2x4_AMD = 0x91C9
        /// </summary>
        Float16Mat2x4Amd = 0x91c9,

        /// <summary>
        /// Original was GL_FLOAT16_MAT3x2_AMD = 0x91CA
        /// </summary>
        Float16Mat3x2Amd = 0x91ca,

        /// <summary>
        /// Original was GL_FLOAT16_MAT3x4_AMD = 0x91CB
        /// </summary>
        Float16Mat3x4Amd = 0x91cb,

        /// <summary>
        /// Original was GL_FLOAT16_MAT4x2_AMD = 0x91CC
        /// </summary>
        Float16Mat4x2Amd = 0x91cc,

        /// <summary>
        /// Original was GL_FLOAT16_MAT4x3_AMD = 0x91CD
        /// </summary>
        Float16Mat4x3Amd = 0x91cd
    }
}
