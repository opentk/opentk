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
    /// Used in GL.GetActiveUniformBlock
    /// </summary>
    public enum ActiveUniformBlockParameter
    {
        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        /// </summary>
        UniformBlockReferencedByTessControlShader = 0x84f0,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        /// </summary>
        UniformBlockReferencedByTessEvaluationShader = 0x84f1,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        /// </summary>
        UniformBlockBinding = 0x8a3f,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        /// </summary>
        UniformBlockDataSize = 0x8a40,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        /// </summary>
        UniformBlockNameLength = 0x8a41,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        /// </summary>
        UniformBlockActiveUniforms = 0x8a42,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        /// </summary>
        UniformBlockActiveUniformIndices = 0x8a43,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        /// </summary>
        UniformBlockReferencedByVertexShader = 0x8a44,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
        /// </summary>
        UniformBlockReferencedByGeometryShader = 0x8a45,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        /// </summary>
        UniformBlockReferencedByFragmentShader = 0x8a46,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        /// </summary>
        UniformBlockReferencedByComputeShader = 0x90ec
    }
}
