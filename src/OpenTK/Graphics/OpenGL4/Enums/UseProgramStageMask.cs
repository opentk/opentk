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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.EXT.UseProgramStages.
    /// </summary>
    [Flags]
    public enum UseProgramStageMask
    {
        /// <summary>
        /// Original was GL_VERTEX_SHADER_BIT = 0x1
        /// </summary>
        VertexShaderBit = 0x1,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_BIT_EXT = 0x1
        /// </summary>
        VertexShaderBitExt = 0x1,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_BIT = 0x2
        /// </summary>
        FragmentShaderBit = 0x2,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_BIT_EXT = 0x2
        /// </summary>
        FragmentShaderBitExt = 0x2,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT = 0x4
        /// </summary>
        GeometryShaderBit = 0x4,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_EXT = 0x4
        /// </summary>
        GeometryShaderBitExt = 0x4,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_OES = 0x4
        /// </summary>
        GeometryShaderBitOes = 0x4,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT = 0x8
        /// </summary>
        TessControlShaderBit = 0x8,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_EXT = 0x8
        /// </summary>
        TessControlShaderBitExt = 0x8,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_OES = 0x8
        /// </summary>
        TessControlShaderBitOes = 0x8,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT = 0x10
        /// </summary>
        TessEvaluationShaderBit = 0x10,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_EXT = 0x10
        /// </summary>
        TessEvaluationShaderBitExt = 0x10,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_OES = 0x10
        /// </summary>
        TessEvaluationShaderBitOes = 0x10,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER_BIT = 0x20
        /// </summary>
        ComputeShaderBit = 0x20,

        /// <summary>
        /// Original was GL_ALL_SHADER_BITS = 0xFFFFFFFF
        /// </summary>
        AllShaderBits = unchecked((int)0xFFFFFFFF),

        /// <summary>
        /// Original was GL_ALL_SHADER_BITS_EXT = 0xFFFFFFFF
        /// </summary>
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF)
    }
}
