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
    public enum ArbComputeShader
    {
        /// <summary>
        /// Original was GL_COMPUTE_SHADER_BIT = 0x00000020
        /// </summary>
        ComputeShaderBit = 0x00000020,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262
        /// </summary>
        MaxComputeSharedMemorySize = 0x8262,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263
        /// </summary>
        MaxComputeUniformComponents = 0x8263,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264
        /// </summary>
        MaxComputeAtomicCounterBuffers = 0x8264,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265
        /// </summary>
        MaxComputeAtomicCounters = 0x8265,

        /// <summary>
        /// Original was GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266
        /// </summary>
        MaxCombinedComputeUniformComponents = 0x8266,

        /// <summary>
        /// Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        /// </summary>
        ComputeWorkGroupSize = 0x8267,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB
        /// </summary>
        MaxComputeWorkGroupInvocations = 0x90eb,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        /// </summary>
        UniformBlockReferencedByComputeShader = 0x90ec,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        /// </summary>
        AtomicCounterBufferReferencedByComputeShader = 0x90ed,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = 0x90ee,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF
        /// </summary>
        DispatchIndirectBufferBinding = 0x90ef,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = 0x91b9,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB
        /// </summary>
        MaxComputeUniformBlocks = 0x91bb,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC
        /// </summary>
        MaxComputeTextureImageUnits = 0x91bc,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD
        /// </summary>
        MaxComputeImageUniforms = 0x91bd,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE
        /// </summary>
        MaxComputeWorkGroupCount = 0x91be,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
        /// </summary>
        MaxComputeWorkGroupSize = 0x91bf
    }
}
