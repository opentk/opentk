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

namespace OpenTK.Graphics.ES31
{
    /// <summary>
    /// Used in GL.GetMultisample, GL.GetProgramResource and 2 other functions
    /// </summary>
    public enum EsVersion31
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001
        /// </summary>
        VertexAttribArrayBarrierBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VERTEX_SHADER_BIT = 0x00000001
        /// </summary>
        VertexShaderBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002
        /// </summary>
        ElementArrayBarrierBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_BIT = 0x00000002
        /// </summary>
        FragmentShaderBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        /// </summary>
        UniformBarrierBit = ((int)0x00000004),

        /// <summary>
        /// Original was GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008
        /// </summary>
        TextureFetchBarrierBit = ((int)0x00000008),

        /// <summary>
        /// Original was GL_COMPUTE_SHADER_BIT = 0x00000020
        /// </summary>
        ComputeShaderBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        /// </summary>
        ShaderImageAccessBarrierBit = ((int)0x00000020),

        /// <summary>
        /// Original was GL_COMMAND_BARRIER_BIT = 0x00000040
        /// </summary>
        CommandBarrierBit = ((int)0x00000040),

        /// <summary>
        /// Original was GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080
        /// </summary>
        PixelBufferBarrierBit = ((int)0x00000080),

        /// <summary>
        /// Original was GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100
        /// </summary>
        TextureUpdateBarrierBit = ((int)0x00000100),

        /// <summary>
        /// Original was GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200
        /// </summary>
        BufferUpdateBarrierBit = ((int)0x00000200),

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400
        /// </summary>
        FramebufferBarrierBit = ((int)0x00000400),

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800
        /// </summary>
        TransformFeedbackBarrierBit = ((int)0x00000800),

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000
        /// </summary>
        AtomicCounterBarrierBit = ((int)0x00001000),

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        /// </summary>
        ShaderStorageBarrierBit = ((int)0x00002000),

        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = 0x1000,

        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = 0x1001,

        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = 0x1003,

        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = 0x1901,

        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = 0x805c,

        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = 0x805d,

        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = 0x805e,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = 0x805f,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH = 0x8071
        /// </summary>
        TextureDepth = 0x8071,

        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = 0x8258,

        /// <summary>
        /// Original was GL_ACTIVE_PROGRAM = 0x8259
        /// </summary>
        ActiveProgram = 0x8259,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE_BINDING = 0x825A
        /// </summary>
        ProgramPipelineBinding = 0x825a,

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
        /// Original was GL_MAX_UNIFORM_LOCATIONS = 0x826E
        /// </summary>
        MaxUniformLocations = 0x826e,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_BINDING = 0x82D4
        /// </summary>
        VertexAttribBinding = 0x82d4,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        /// </summary>
        VertexAttribRelativeOffset = 0x82d5,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_DIVISOR = 0x82D6
        /// </summary>
        VertexBindingDivisor = 0x82d6,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_OFFSET = 0x82D7
        /// </summary>
        VertexBindingOffset = 0x82d7,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_STRIDE = 0x82D8
        /// </summary>
        VertexBindingStride = 0x82d8,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9
        /// </summary>
        MaxVertexAttribRelativeOffset = 0x82d9,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA
        /// </summary>
        MaxVertexAttribBindings = 0x82da,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5
        /// </summary>
        MaxVertexAttribStride = 0x82e5,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        TextureCompressed = 0x86a1,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_SIZE = 0x884A
        /// </summary>
        TextureDepthSize = 0x884a,

        /// <summary>
        /// Original was GL_READ_ONLY = 0x88B8
        /// </summary>
        ReadOnly = 0x88b8,

        /// <summary>
        /// Original was GL_WRITE_ONLY = 0x88B9
        /// </summary>
        WriteOnly = 0x88b9,

        /// <summary>
        /// Original was GL_READ_WRITE = 0x88BA
        /// </summary>
        ReadWrite = 0x88ba,

        /// <summary>
        /// Original was GL_TEXTURE_STENCIL_SIZE = 0x88F1
        /// </summary>
        TextureStencilSize = 0x88f1,

        /// <summary>
        /// Original was GL_TEXTURE_RED_TYPE = 0x8C10
        /// </summary>
        TextureRedType = 0x8c10,

        /// <summary>
        /// Original was GL_TEXTURE_GREEN_TYPE = 0x8C11
        /// </summary>
        TextureGreenType = 0x8c11,

        /// <summary>
        /// Original was GL_TEXTURE_BLUE_TYPE = 0x8C12
        /// </summary>
        TextureBlueType = 0x8c12,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_TYPE = 0x8C13
        /// </summary>
        TextureAlphaType = 0x8c13,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_TYPE = 0x8C16
        /// </summary>
        TextureDepthType = 0x8c16,

        /// <summary>
        /// Original was GL_TEXTURE_SHARED_SIZE = 0x8C3F
        /// </summary>
        TextureSharedSize = 0x8c3f,

        /// <summary>
        /// Original was GL_SAMPLE_POSITION = 0x8E50
        /// </summary>
        SamplePosition = 0x8e50,

        /// <summary>
        /// Original was GL_SAMPLE_MASK = 0x8E51
        /// </summary>
        SampleMask = 0x8e51,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE = 0x8E52
        /// </summary>
        SampleMaskValue = 0x8e52,

        /// <summary>
        /// Original was GL_MAX_SAMPLE_MASK_WORDS = 0x8E59
        /// </summary>
        MaxSampleMaskWords = 0x8e59,

        /// <summary>
        /// Original was GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E
        /// </summary>
        MinProgramTextureGatherOffset = 0x8e5e,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F
        /// </summary>
        MaxProgramTextureGatherOffset = 0x8e5f,

        /// <summary>
        /// Original was GL_MAX_IMAGE_UNITS = 0x8F38
        /// </summary>
        MaxImageUnits = 0x8f38,

        /// <summary>
        /// Original was GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39
        /// </summary>
        MaxCombinedShaderOutputResources = 0x8f39,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_NAME = 0x8F3A
        /// </summary>
        ImageBindingName = 0x8f3a,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LEVEL = 0x8F3B
        /// </summary>
        ImageBindingLevel = 0x8f3b,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LAYERED = 0x8F3C
        /// </summary>
        ImageBindingLayered = 0x8f3c,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_LAYER = 0x8F3D
        /// </summary>
        ImageBindingLayer = 0x8f3d,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_ACCESS = 0x8F3E
        /// </summary>
        ImageBindingAccess = 0x8f3e,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = 0x8f3f,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43
        /// </summary>
        DrawIndirectBufferBinding = 0x8f43,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_BUFFER = 0x8F4F
        /// </summary>
        VertexBindingBuffer = 0x8f4f,

        /// <summary>
        /// Original was GL_IMAGE_2D = 0x904D
        /// </summary>
        Image2D = 0x904d,

        /// <summary>
        /// Original was GL_IMAGE_3D = 0x904E
        /// </summary>
        Image3D = 0x904e,

        /// <summary>
        /// Original was GL_IMAGE_CUBE = 0x9050
        /// </summary>
        ImageCube = 0x9050,

        /// <summary>
        /// Original was GL_IMAGE_2D_ARRAY = 0x9053
        /// </summary>
        Image2DArray = 0x9053,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D = 0x9058
        /// </summary>
        IntImage2D = 0x9058,

        /// <summary>
        /// Original was GL_INT_IMAGE_3D = 0x9059
        /// </summary>
        IntImage3D = 0x9059,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE = 0x905B
        /// </summary>
        IntImageCube = 0x905b,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_ARRAY = 0x905E
        /// </summary>
        IntImage2DArray = 0x905e,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D = 0x9063
        /// </summary>
        UnsignedIntImage2D = 0x9063,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_3D = 0x9064
        /// </summary>
        UnsignedIntImage3D = 0x9064,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066
        /// </summary>
        UnsignedIntImageCube = 0x9066,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069
        /// </summary>
        UnsignedIntImage2DArray = 0x9069,

        /// <summary>
        /// Original was GL_IMAGE_BINDING_FORMAT = 0x906E
        /// </summary>
        ImageBindingFormat = 0x906e,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        ImageFormatCompatibilityType = 0x90c7,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8
        /// </summary>
        ImageFormatCompatibilityBySize = 0x90c8,

        /// <summary>
        /// Original was GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9
        /// </summary>
        ImageFormatCompatibilityByClass = 0x90c9,

        /// <summary>
        /// Original was GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA
        /// </summary>
        MaxVertexImageUniforms = 0x90ca,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE
        /// </summary>
        MaxFragmentImageUniforms = 0x90ce,

        /// <summary>
        /// Original was GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF
        /// </summary>
        MaxCombinedImageUniforms = 0x90cf,

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
        ShaderStorageBufferOffsetAlignment = 0x90df,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        /// </summary>
        DepthStencilTextureMode = 0x90ea,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB
        /// </summary>
        MaxComputeWorkGroupInvocations = 0x90eb,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = 0x90ee,

        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF
        /// </summary>
        DispatchIndirectBufferBinding = 0x90ef,

        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = 0x9100,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104
        /// </summary>
        TextureBinding2DMultisample = 0x9104,

        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES = 0x9106
        /// </summary>
        TextureSamples = 0x9106,

        /// <summary>
        /// Original was GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107
        /// </summary>
        TextureFixedSampleLocations = 0x9107,

        /// <summary>
        /// Original was GL_SAMPLER_2D_MULTISAMPLE = 0x9108
        /// </summary>
        Sampler2DMultisample = 0x9108,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109
        /// </summary>
        IntSampler2DMultisample = 0x9109,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A
        /// </summary>
        UnsignedIntSampler2DMultisample = 0x910a,

        /// <summary>
        /// Original was GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E
        /// </summary>
        MaxColorTextureSamples = 0x910e,

        /// <summary>
        /// Original was GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F
        /// </summary>
        MaxDepthTextureSamples = 0x910f,

        /// <summary>
        /// Original was GL_MAX_INTEGER_SAMPLES = 0x9110
        /// </summary>
        MaxIntegerSamples = 0x9110,

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
        MaxComputeWorkGroupSize = 0x91bf,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92c0,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        /// </summary>
        AtomicCounterBufferBinding = 0x92c1,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2
        /// </summary>
        AtomicCounterBufferStart = 0x92c2,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3
        /// </summary>
        AtomicCounterBufferSize = 0x92c3,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC
        /// </summary>
        MaxVertexAtomicCounterBuffers = 0x92cc,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0
        /// </summary>
        MaxFragmentAtomicCounterBuffers = 0x92d0,

        /// <summary>
        /// Original was GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1
        /// </summary>
        MaxCombinedAtomicCounterBuffers = 0x92d1,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2
        /// </summary>
        MaxVertexAtomicCounters = 0x92d2,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6
        /// </summary>
        MaxFragmentAtomicCounters = 0x92d6,

        /// <summary>
        /// Original was GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7
        /// </summary>
        MaxCombinedAtomicCounters = 0x92d7,

        /// <summary>
        /// Original was GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8
        /// </summary>
        MaxAtomicCounterBufferSize = 0x92d8,

        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = 0x92d9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        /// </summary>
        UnsignedIntAtomicCounter = 0x92db,

        /// <summary>
        /// Original was GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC
        /// </summary>
        MaxAtomicCounterBufferBindings = 0x92dc,

        /// <summary>
        /// Original was GL_UNIFORM = 0x92E1
        /// </summary>
        Uniform = 0x92e1,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK = 0x92E2
        /// </summary>
        UniformBlock = 0x92e2,

        /// <summary>
        /// Original was GL_PROGRAM_INPUT = 0x92E3
        /// </summary>
        ProgramInput = 0x92e3,

        /// <summary>
        /// Original was GL_PROGRAM_OUTPUT = 0x92E4
        /// </summary>
        ProgramOutput = 0x92e4,

        /// <summary>
        /// Original was GL_BUFFER_VARIABLE = 0x92E5
        /// </summary>
        BufferVariable = 0x92e5,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        /// </summary>
        ShaderStorageBlock = 0x92e6,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        /// </summary>
        TransformFeedbackVarying = 0x92f4,

        /// <summary>
        /// Original was GL_ACTIVE_RESOURCES = 0x92F5
        /// </summary>
        ActiveResources = 0x92f5,

        /// <summary>
        /// Original was GL_MAX_NAME_LENGTH = 0x92F6
        /// </summary>
        MaxNameLength = 0x92f6,

        /// <summary>
        /// Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        /// </summary>
        MaxNumActiveVariables = 0x92f7,

        /// <summary>
        /// Original was GL_NAME_LENGTH = 0x92F9
        /// </summary>
        NameLength = 0x92f9,

        /// <summary>
        /// Original was GL_TYPE = 0x92FA
        /// </summary>
        Type = 0x92fa,

        /// <summary>
        /// Original was GL_ARRAY_SIZE = 0x92FB
        /// </summary>
        ArraySize = 0x92fb,

        /// <summary>
        /// Original was GL_OFFSET = 0x92FC
        /// </summary>
        Offset = 0x92fc,

        /// <summary>
        /// Original was GL_BLOCK_INDEX = 0x92FD
        /// </summary>
        BlockIndex = 0x92fd,

        /// <summary>
        /// Original was GL_ARRAY_STRIDE = 0x92FE
        /// </summary>
        ArrayStride = 0x92fe,

        /// <summary>
        /// Original was GL_MATRIX_STRIDE = 0x92FF
        /// </summary>
        MatrixStride = 0x92ff,

        /// <summary>
        /// Original was GL_IS_ROW_MAJOR = 0x9300
        /// </summary>
        IsRowMajor = 0x9300,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301
        /// </summary>
        AtomicCounterBufferIndex = 0x9301,

        /// <summary>
        /// Original was GL_BUFFER_BINDING = 0x9302
        /// </summary>
        BufferBinding = 0x9302,

        /// <summary>
        /// Original was GL_BUFFER_DATA_SIZE = 0x9303
        /// </summary>
        BufferDataSize = 0x9303,

        /// <summary>
        /// Original was GL_NUM_ACTIVE_VARIABLES = 0x9304
        /// </summary>
        NumActiveVariables = 0x9304,

        /// <summary>
        /// Original was GL_ACTIVE_VARIABLES = 0x9305
        /// </summary>
        ActiveVariables = 0x9305,

        /// <summary>
        /// Original was GL_REFERENCED_BY_VERTEX_SHADER = 0x9306
        /// </summary>
        ReferencedByVertexShader = 0x9306,

        /// <summary>
        /// Original was GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A
        /// </summary>
        ReferencedByFragmentShader = 0x930a,

        /// <summary>
        /// Original was GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B
        /// </summary>
        ReferencedByComputeShader = 0x930b,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_SIZE = 0x930C
        /// </summary>
        TopLevelArraySize = 0x930c,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D
        /// </summary>
        TopLevelArrayStride = 0x930d,

        /// <summary>
        /// Original was GL_LOCATION = 0x930E
        /// </summary>
        Location = 0x930e,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        /// </summary>
        FramebufferDefaultWidth = 0x9310,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        /// </summary>
        FramebufferDefaultHeight = 0x9311,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        /// </summary>
        FramebufferDefaultSamples = 0x9313,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        /// </summary>
        FramebufferDefaultFixedSampleLocations = 0x9314,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_WIDTH = 0x9315
        /// </summary>
        MaxFramebufferWidth = 0x9315,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316
        /// </summary>
        MaxFramebufferHeight = 0x9316,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318
        /// </summary>
        MaxFramebufferSamples = 0x9318,

        /// <summary>
        /// Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        /// </summary>
        AllBarrierBits = unchecked((int)0xffffffff),

        /// <summary>
        /// Original was GL_ALL_SHADER_BITS = 0xFFFFFFFF
        /// </summary>
        AllShaderBits = unchecked((int)0xffffffff)
    }
}
