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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbUniformBufferObject
    {
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = 0x8a11,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_BINDING = 0x8A28
        /// </summary>
        UniformBufferBinding = 0x8a28,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_START = 0x8A29
        /// </summary>
        UniformBufferStart = 0x8a29,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_SIZE = 0x8A2A
        /// </summary>
        UniformBufferSize = 0x8a2a,

        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B
        /// </summary>
        MaxVertexUniformBlocks = 0x8a2b,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C
        /// </summary>
        MaxGeometryUniformBlocks = 0x8a2c,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D
        /// </summary>
        MaxFragmentUniformBlocks = 0x8a2d,

        /// <summary>
        /// Original was GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E
        /// </summary>
        MaxCombinedUniformBlocks = 0x8a2e,

        /// <summary>
        /// Original was GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F
        /// </summary>
        MaxUniformBufferBindings = 0x8a2f,

        /// <summary>
        /// Original was GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30
        /// </summary>
        MaxUniformBlockSize = 0x8a30,

        /// <summary>
        /// Original was GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31
        /// </summary>
        MaxCombinedVertexUniformComponents = 0x8a31,

        /// <summary>
        /// Original was GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32
        /// </summary>
        MaxCombinedGeometryUniformComponents = 0x8a32,

        /// <summary>
        /// Original was GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33
        /// </summary>
        MaxCombinedFragmentUniformComponents = 0x8a33,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34
        /// </summary>
        UniformBufferOffsetAlignment = 0x8a34,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = 0x8a35,

        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = 0x8a36,

        /// <summary>
        /// Original was GL_UNIFORM_TYPE = 0x8A37
        /// </summary>
        UniformType = 0x8a37,

        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = 0x8a38,

        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = 0x8a39,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        /// </summary>
        UniformBlockIndex = 0x8a3a,

        /// <summary>
        /// Original was GL_UNIFORM_OFFSET = 0x8A3B
        /// </summary>
        UniformOffset = 0x8a3b,

        /// <summary>
        /// Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        /// </summary>
        UniformArrayStride = 0x8a3c,

        /// <summary>
        /// Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        /// </summary>
        UniformMatrixStride = 0x8a3d,

        /// <summary>
        /// Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        /// </summary>
        UniformIsRowMajor = 0x8a3e,

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
        /// Original was GL_INVALID_INDEX = 0xFFFFFFFF
        /// </summary>
        InvalidIndex = unchecked((int)0xffffffff)
    }
}
