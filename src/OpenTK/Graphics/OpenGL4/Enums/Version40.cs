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
    public enum Version40
    {
        /// <summary>
        /// Original was GL_QUADS = 0x0007
        /// </summary>
        Quads = 0x0007,

        /// <summary>
        /// Original was GL_PATCHES = 0x000E
        /// </summary>
        Patches = 0x000e,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        /// </summary>
        UniformBlockReferencedByTessControlShader = 0x84f0,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        /// </summary>
        UniformBlockReferencedByTessEvaluationShader = 0x84f1,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C
        /// </summary>
        MaxTessControlInputComponents = 0x886c,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D
        /// </summary>
        MaxTessEvaluationInputComponents = 0x886d,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        /// </summary>
        GeometryShaderInvocations = 0x887f,

        /// <summary>
        /// Original was GL_SAMPLE_SHADING = 0x8C36
        /// </summary>
        SampleShading = 0x8c36,

        /// <summary>
        /// Original was GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37
        /// </summary>
        MinSampleShadingValue = 0x8c37,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        /// </summary>
        ActiveSubroutines = 0x8de5,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        /// </summary>
        ActiveSubroutineUniforms = 0x8de6,

        /// <summary>
        /// Original was GL_MAX_SUBROUTINES = 0x8DE7
        /// </summary>
        MaxSubroutines = 0x8de7,

        /// <summary>
        /// Original was GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8
        /// </summary>
        MaxSubroutineUniformLocations = 0x8de8,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E
        /// </summary>
        MaxCombinedTessControlUniformComponents = 0x8e1e,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F
        /// </summary>
        MaxCombinedTessEvaluationUniformComponents = 0x8e1f,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = 0x8e22,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackBufferPaused = 0x8e23,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackBufferActive = 0x8e24,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25
        /// </summary>
        TransformFeedbackBinding = 0x8e25,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        /// </summary>
        ActiveSubroutineUniformLocations = 0x8e47,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        /// </summary>
        ActiveSubroutineMaxLength = 0x8e48,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        /// </summary>
        ActiveSubroutineUniformMaxLength = 0x8e49,

        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = 0x8e4a,

        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = 0x8e4b,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A
        /// </summary>
        MaxGeometryShaderInvocations = 0x8e5a,

        /// <summary>
        /// Original was GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B
        /// </summary>
        MinFragmentInterpolationOffset = 0x8e5b,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C
        /// </summary>
        MaxFragmentInterpolationOffset = 0x8e5c,

        /// <summary>
        /// Original was GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D
        /// </summary>
        FragmentInterpolationOffsetBits = 0x8e5d,

        /// <summary>
        /// Original was GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E
        /// </summary>
        MinProgramTextureGatherOffset = 0x8e5e,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F
        /// </summary>
        MaxProgramTextureGatherOffset = 0x8e5f,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70
        /// </summary>
        MaxTransformFeedbackBuffers = 0x8e70,

        /// <summary>
        /// Original was GL_MAX_VERTEX_STREAMS = 0x8E71
        /// </summary>
        MaxVertexStreams = 0x8e71,

        /// <summary>
        /// Original was GL_PATCH_VERTICES = 0x8E72
        /// </summary>
        PatchVertices = 0x8e72,

        /// <summary>
        /// Original was GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
        /// </summary>
        PatchDefaultInnerLevel = 0x8e73,

        /// <summary>
        /// Original was GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
        /// </summary>
        PatchDefaultOuterLevel = 0x8e74,

        /// <summary>
        /// Original was GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75
        /// </summary>
        TessControlOutputVertices = 0x8e75,

        /// <summary>
        /// Original was GL_TESS_GEN_MODE = 0x8E76
        /// </summary>
        TessGenMode = 0x8e76,

        /// <summary>
        /// Original was GL_TESS_GEN_SPACING = 0x8E77
        /// </summary>
        TessGenSpacing = 0x8e77,

        /// <summary>
        /// Original was GL_TESS_GEN_VERTEX_ORDER = 0x8E78
        /// </summary>
        TessGenVertexOrder = 0x8e78,

        /// <summary>
        /// Original was GL_TESS_GEN_POINT_MODE = 0x8E79
        /// </summary>
        TessGenPointMode = 0x8e79,

        /// <summary>
        /// Original was GL_ISOLINES = 0x8E7A
        /// </summary>
        Isolines = 0x8e7a,

        /// <summary>
        /// Original was GL_FRACTIONAL_ODD = 0x8E7B
        /// </summary>
        FractionalOdd = 0x8e7b,

        /// <summary>
        /// Original was GL_FRACTIONAL_EVEN = 0x8E7C
        /// </summary>
        FractionalEven = 0x8e7c,

        /// <summary>
        /// Original was GL_MAX_PATCH_VERTICES = 0x8E7D
        /// </summary>
        MaxPatchVertices = 0x8e7d,

        /// <summary>
        /// Original was GL_MAX_TESS_GEN_LEVEL = 0x8E7E
        /// </summary>
        MaxTessGenLevel = 0x8e7e,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F
        /// </summary>
        MaxTessControlUniformComponents = 0x8e7f,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80
        /// </summary>
        MaxTessEvaluationUniformComponents = 0x8e80,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81
        /// </summary>
        MaxTessControlTextureImageUnits = 0x8e81,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82
        /// </summary>
        MaxTessEvaluationTextureImageUnits = 0x8e82,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83
        /// </summary>
        MaxTessControlOutputComponents = 0x8e83,

        /// <summary>
        /// Original was GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84
        /// </summary>
        MaxTessPatchComponents = 0x8e84,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85
        /// </summary>
        MaxTessControlTotalOutputComponents = 0x8e85,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86
        /// </summary>
        MaxTessEvaluationOutputComponents = 0x8e86,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = 0x8e87,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = 0x8e88,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89
        /// </summary>
        MaxTessControlUniformBlocks = 0x8e89,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A
        /// </summary>
        MaxTessEvaluationUniformBlocks = 0x8e8a,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = 0x8f3f,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43
        /// </summary>
        DrawIndirectBufferBinding = 0x8f43,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2 = 0x8F46
        /// </summary>
        DoubleMat2 = 0x8f46,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3 = 0x8F47
        /// </summary>
        DoubleMat3 = 0x8f47,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4 = 0x8F48
        /// </summary>
        DoubleMat4 = 0x8f48,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2x3 = 0x8F49
        /// </summary>
        DoubleMat2x3 = 0x8f49,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2x4 = 0x8F4A
        /// </summary>
        DoubleMat2x4 = 0x8f4a,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3x2 = 0x8F4B
        /// </summary>
        DoubleMat3x2 = 0x8f4b,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3x4 = 0x8F4C
        /// </summary>
        DoubleMat3x4 = 0x8f4c,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4x2 = 0x8F4D
        /// </summary>
        DoubleMat4x2 = 0x8f4d,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4x3 = 0x8F4E
        /// </summary>
        DoubleMat4x3 = 0x8f4e,

        /// <summary>
        /// Original was GL_DOUBLE_VEC2 = 0x8FFC
        /// </summary>
        DoubleVec2 = 0x8ffc,

        /// <summary>
        /// Original was GL_DOUBLE_VEC3 = 0x8FFD
        /// </summary>
        DoubleVec3 = 0x8ffd,

        /// <summary>
        /// Original was GL_DOUBLE_VEC4 = 0x8FFE
        /// </summary>
        DoubleVec4 = 0x8ffe,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A
        /// </summary>
        TextureBindingCubeMapArray = 0x900a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        /// </summary>
        ProxyTextureCubeMapArray = 0x900b,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C
        /// </summary>
        SamplerCubeMapArray = 0x900c,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D
        /// </summary>
        SamplerCubeMapArrayShadow = 0x900d,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E
        /// </summary>
        IntSamplerCubeMapArray = 0x900e,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F
        /// </summary>
        UnsignedIntSamplerCubeMapArray = 0x900f
    }
}
