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
    public enum ArbShaderStorageBufferObject
    {
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        /// </summary>
        ShaderStorageBarrierBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39
        /// </summary>
        MaxCombinedImageUnitsAndFragmentOutputs = 0x8f39,

        /// <summary>
        /// Original was GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39
        /// </summary>
        MaxCombinedShaderOutputResources = 0x8f39,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = 0x90d2,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3
        /// </summary>
        ShaderStorageBufferBinding = 0x90d3,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_START = 0x90D4
        /// </summary>
        ShaderStorageBufferStart = 0x90d4,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5
        /// </summary>
        ShaderStorageBufferSize = 0x90d5,

        /// <summary>
        /// Original was GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6
        /// </summary>
        MaxVertexShaderStorageBlocks = 0x90d6,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7
        /// </summary>
        MaxGeometryShaderStorageBlocks = 0x90d7,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8
        /// </summary>
        MaxTessControlShaderStorageBlocks = 0x90d8,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9
        /// </summary>
        MaxTessEvaluationShaderStorageBlocks = 0x90d9,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA
        /// </summary>
        MaxFragmentShaderStorageBlocks = 0x90da,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB
        /// </summary>
        MaxComputeShaderStorageBlocks = 0x90db,

        /// <summary>
        /// Original was GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC
        /// </summary>
        MaxCombinedShaderStorageBlocks = 0x90dc,

        /// <summary>
        /// Original was GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD
        /// </summary>
        MaxShaderStorageBufferBindings = 0x90dd,

        /// <summary>
        /// Original was GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE
        /// </summary>
        MaxShaderStorageBlockSize = 0x90de,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF
        /// </summary>
        ShaderStorageBufferOffsetAlignment = 0x90df
    }
}
