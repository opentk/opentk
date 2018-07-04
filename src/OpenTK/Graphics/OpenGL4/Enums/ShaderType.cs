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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.CreateShader, GL.CreateShaderProgram and 11 other functions
    /// </summary>
    public enum ShaderType
    {
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = 0x8b30,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        /// </summary>
        FragmentShaderArb = 0x8b30,

        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = 0x8b31,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_ARB = 0x8B31
        /// </summary>
        VertexShaderArb = 0x8b31,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = 0x8dd9,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = 0x8e87,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = 0x8e88,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = 0x91b9
    }
}
