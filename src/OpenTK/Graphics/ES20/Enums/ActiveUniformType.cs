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
    /// Used in GL.GetActiveUniform
    /// </summary>
    public enum ActiveUniformType
    {
        /// <summary>
        /// Original was GL_Int = 0X1404
        /// </summary>
        Int = 0X1404,

        /// <summary>
        /// Original was GL_Float = 0X1406
        /// </summary>
        Float = 0X1406,

        /// <summary>
        /// Original was GL_FloatVec2 = 0X8b50
        /// </summary>
        FloatVec2 = 0X8b50,

        /// <summary>
        /// Original was GL_FloatVec3 = 0X8b51
        /// </summary>
        FloatVec3 = 0X8b51,

        /// <summary>
        /// Original was GL_FloatVec4 = 0X8b52
        /// </summary>
        FloatVec4 = 0X8b52,

        /// <summary>
        /// Original was GL_IntVec2 = 0X8b53
        /// </summary>
        IntVec2 = 0X8b53,

        /// <summary>
        /// Original was GL_IntVec3 = 0X8b54
        /// </summary>
        IntVec3 = 0X8b54,

        /// <summary>
        /// Original was GL_IntVec4 = 0X8b55
        /// </summary>
        IntVec4 = 0X8b55,

        /// <summary>
        /// Original was GL_Bool = 0X8b56
        /// </summary>
        Bool = 0X8b56,

        /// <summary>
        /// Original was GL_BoolVec2 = 0X8b57
        /// </summary>
        BoolVec2 = 0X8b57,

        /// <summary>
        /// Original was GL_BoolVec3 = 0X8b58
        /// </summary>
        BoolVec3 = 0X8b58,

        /// <summary>
        /// Original was GL_BoolVec4 = 0X8b59
        /// </summary>
        BoolVec4 = 0X8b59,

        /// <summary>
        /// Original was GL_FloatMat2 = 0X8b5a
        /// </summary>
        FloatMat2 = 0X8b5a,

        /// <summary>
        /// Original was GL_FloatMat3 = 0X8b5b
        /// </summary>
        FloatMat3 = 0X8b5b,

        /// <summary>
        /// Original was GL_FloatMat4 = 0X8b5c
        /// </summary>
        FloatMat4 = 0X8b5c,

        /// <summary>
        /// Original was GL_Sampler2D = 0X8b5e
        /// </summary>
        Sampler2D = 0X8b5e,

        /// <summary>
        /// Original was GL_SamplerCube = 0X8b60
        /// </summary>
        SamplerCube = 0X8b60
    }
}
