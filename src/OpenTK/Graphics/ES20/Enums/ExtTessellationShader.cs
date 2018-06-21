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
    /// Not used directly.
    /// </summary>
    public enum ExtTessellationShader
    {
        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_EXT = 0x00000008
        /// </summary>
        TessControlShaderBitExt = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010
        /// </summary>
        TessEvaluationShaderBitExt = ((int)0x00000010),

        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = 0x0004,

        /// <summary>
        /// Original was GL_QUADS_EXT = 0x0007
        /// </summary>
        QuadsExt = 0x0007,

        /// <summary>
        /// Original was GL_PATCHES_EXT = 0x000E
        /// </summary>
        PatchesExt = 0x000e,

        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = 0x0202,

        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = 0x0900,

        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = 0x0901,

        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221
        /// </summary>
        PrimitiveRestartForPatchesSupported = 0x8221,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT = 0x886C
        /// </summary>
        MaxTessControlInputComponentsExt = 0x886c,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT = 0x886D
        /// </summary>
        MaxTessEvaluationInputComponentsExt = 0x886d,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E1E
        /// </summary>
        MaxCombinedTessControlUniformComponentsExt = 0x8e1e,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E1F
        /// </summary>
        MaxCombinedTessEvaluationUniformComponentsExt = 0x8e1f,

        /// <summary>
        /// Original was GL_PATCH_VERTICES_EXT = 0x8E72
        /// </summary>
        PatchVerticesExt = 0x8e72,

        /// <summary>
        /// Original was GL_TESS_CONTROL_OUTPUT_VERTICES_EXT = 0x8E75
        /// </summary>
        TessControlOutputVerticesExt = 0x8e75,

        /// <summary>
        /// Original was GL_TESS_GEN_MODE_EXT = 0x8E76
        /// </summary>
        TessGenModeExt = 0x8e76,

        /// <summary>
        /// Original was GL_TESS_GEN_SPACING_EXT = 0x8E77
        /// </summary>
        TessGenSpacingExt = 0x8e77,

        /// <summary>
        /// Original was GL_TESS_GEN_VERTEX_ORDER_EXT = 0x8E78
        /// </summary>
        TessGenVertexOrderExt = 0x8e78,

        /// <summary>
        /// Original was GL_TESS_GEN_POINT_MODE_EXT = 0x8E79
        /// </summary>
        TessGenPointModeExt = 0x8e79,

        /// <summary>
        /// Original was GL_ISOLINES_EXT = 0x8E7A
        /// </summary>
        IsolinesExt = 0x8e7a,

        /// <summary>
        /// Original was GL_FRACTIONAL_ODD_EXT = 0x8E7B
        /// </summary>
        FractionalOddExt = 0x8e7b,

        /// <summary>
        /// Original was GL_FRACTIONAL_EVEN_EXT = 0x8E7C
        /// </summary>
        FractionalEvenExt = 0x8e7c,

        /// <summary>
        /// Original was GL_MAX_PATCH_VERTICES_EXT = 0x8E7D
        /// </summary>
        MaxPatchVerticesExt = 0x8e7d,

        /// <summary>
        /// Original was GL_MAX_TESS_GEN_LEVEL_EXT = 0x8E7E
        /// </summary>
        MaxTessGenLevelExt = 0x8e7e,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E7F
        /// </summary>
        MaxTessControlUniformComponentsExt = 0x8e7f,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E80
        /// </summary>
        MaxTessEvaluationUniformComponentsExt = 0x8e80,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT = 0x8E81
        /// </summary>
        MaxTessControlTextureImageUnitsExt = 0x8e81,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT = 0x8E82
        /// </summary>
        MaxTessEvaluationTextureImageUnitsExt = 0x8e82,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT = 0x8E83
        /// </summary>
        MaxTessControlOutputComponentsExt = 0x8e83,

        /// <summary>
        /// Original was GL_MAX_TESS_PATCH_COMPONENTS_EXT = 0x8E84
        /// </summary>
        MaxTessPatchComponentsExt = 0x8e84,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8E85
        /// </summary>
        MaxTessControlTotalOutputComponentsExt = 0x8e85,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT = 0x8E86
        /// </summary>
        MaxTessEvaluationOutputComponentsExt = 0x8e86,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_EXT = 0x8E87
        /// </summary>
        TessEvaluationShaderExt = 0x8e87,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_EXT = 0x8E88
        /// </summary>
        TessControlShaderExt = 0x8e88,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT = 0x8E89
        /// </summary>
        MaxTessControlUniformBlocksExt = 0x8e89,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT = 0x8E8A
        /// </summary>
        MaxTessEvaluationUniformBlocksExt = 0x8e8a,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT = 0x90CB
        /// </summary>
        MaxTessControlImageUniformsExt = 0x90cb,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT = 0x90CC
        /// </summary>
        MaxTessEvaluationImageUniformsExt = 0x90cc,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT = 0x90D8
        /// </summary>
        MaxTessControlShaderStorageBlocksExt = 0x90d8,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT = 0x90D9
        /// </summary>
        MaxTessEvaluationShaderStorageBlocksExt = 0x90d9,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CD
        /// </summary>
        MaxTessControlAtomicCounterBuffersExt = 0x92cd,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CE
        /// </summary>
        MaxTessEvaluationAtomicCounterBuffersExt = 0x92ce,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT = 0x92D3
        /// </summary>
        MaxTessControlAtomicCountersExt = 0x92d3,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT = 0x92D4
        /// </summary>
        MaxTessEvaluationAtomicCountersExt = 0x92d4,

        /// <summary>
        /// Original was GL_IS_PER_PATCH_EXT = 0x92E7
        /// </summary>
        IsPerPatchExt = 0x92e7,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT = 0x9307
        /// </summary>
        ReferencedByTessControlShaderExt = 0x9307,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT = 0x9308
        /// </summary>
        ReferencedByTessEvaluationShaderExt = 0x9308
    }
}
