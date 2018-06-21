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
    public enum OesTessellationShader
    {
        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT_OES = 0x00000008
        /// </summary>
        TessControlShaderBitOes = ((int)0x00000008),

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_BIT_OES = 0x00000010
        /// </summary>
        TessEvaluationShaderBitOes = ((int)0x00000010),

        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = 0x0004,

        /// <summary>
        /// Original was GL_QUADS_OES = 0x0007
        /// </summary>
        QuadsOes = 0x0007,

        /// <summary>
        /// Original was GL_PATCHES_OES = 0x000E
        /// </summary>
        PatchesOes = 0x000e,

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
        /// Original was GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES = 0x8221
        /// </summary>
        PrimitiveRestartForPatchesSupportedOes = 0x8221,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES = 0x886C
        /// </summary>
        MaxTessControlInputComponentsOes = 0x886c,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES = 0x886D
        /// </summary>
        MaxTessEvaluationInputComponentsOes = 0x886d,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E1E
        /// </summary>
        MaxCombinedTessControlUniformComponentsOes = 0x8e1e,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E1F
        /// </summary>
        MaxCombinedTessEvaluationUniformComponentsOes = 0x8e1f,

        /// <summary>
        /// Original was GL_PATCH_VERTICES_OES = 0x8E72
        /// </summary>
        PatchVerticesOes = 0x8e72,

        /// <summary>
        /// Original was GL_TESS_CONTROL_OUTPUT_VERTICES_OES = 0x8E75
        /// </summary>
        TessControlOutputVerticesOes = 0x8e75,

        /// <summary>
        /// Original was GL_TESS_GEN_MODE_OES = 0x8E76
        /// </summary>
        TessGenModeOes = 0x8e76,

        /// <summary>
        /// Original was GL_TESS_GEN_SPACING_OES = 0x8E77
        /// </summary>
        TessGenSpacingOes = 0x8e77,

        /// <summary>
        /// Original was GL_TESS_GEN_VERTEX_ORDER_OES = 0x8E78
        /// </summary>
        TessGenVertexOrderOes = 0x8e78,

        /// <summary>
        /// Original was GL_TESS_GEN_POINT_MODE_OES = 0x8E79
        /// </summary>
        TessGenPointModeOes = 0x8e79,

        /// <summary>
        /// Original was GL_ISOLINES_OES = 0x8E7A
        /// </summary>
        IsolinesOes = 0x8e7a,

        /// <summary>
        /// Original was GL_FRACTIONAL_ODD_OES = 0x8E7B
        /// </summary>
        FractionalOddOes = 0x8e7b,

        /// <summary>
        /// Original was GL_FRACTIONAL_EVEN_OES = 0x8E7C
        /// </summary>
        FractionalEvenOes = 0x8e7c,

        /// <summary>
        /// Original was GL_MAX_PATCH_VERTICES_OES = 0x8E7D
        /// </summary>
        MaxPatchVerticesOes = 0x8e7d,

        /// <summary>
        /// Original was GL_MAX_TESS_GEN_LEVEL_OES = 0x8E7E
        /// </summary>
        MaxTessGenLevelOes = 0x8e7e,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E7F
        /// </summary>
        MaxTessControlUniformComponentsOes = 0x8e7f,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E80
        /// </summary>
        MaxTessEvaluationUniformComponentsOes = 0x8e80,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES = 0x8E81
        /// </summary>
        MaxTessControlTextureImageUnitsOes = 0x8e81,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES = 0x8E82
        /// </summary>
        MaxTessEvaluationTextureImageUnitsOes = 0x8e82,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES = 0x8E83
        /// </summary>
        MaxTessControlOutputComponentsOes = 0x8e83,

        /// <summary>
        /// Original was GL_MAX_TESS_PATCH_COMPONENTS_OES = 0x8E84
        /// </summary>
        MaxTessPatchComponentsOes = 0x8e84,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES = 0x8E85
        /// </summary>
        MaxTessControlTotalOutputComponentsOes = 0x8e85,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES = 0x8E86
        /// </summary>
        MaxTessEvaluationOutputComponentsOes = 0x8e86,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_OES = 0x8E87
        /// </summary>
        TessEvaluationShaderOes = 0x8e87,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_OES = 0x8E88
        /// </summary>
        TessControlShaderOes = 0x8e88,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES = 0x8E89
        /// </summary>
        MaxTessControlUniformBlocksOes = 0x8e89,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES = 0x8E8A
        /// </summary>
        MaxTessEvaluationUniformBlocksOes = 0x8e8a,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES = 0x90CB
        /// </summary>
        MaxTessControlImageUniformsOes = 0x90cb,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES = 0x90CC
        /// </summary>
        MaxTessEvaluationImageUniformsOes = 0x90cc,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES = 0x90D8
        /// </summary>
        MaxTessControlShaderStorageBlocksOes = 0x90d8,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES = 0x90D9
        /// </summary>
        MaxTessEvaluationShaderStorageBlocksOes = 0x90d9,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES = 0x92CD
        /// </summary>
        MaxTessControlAtomicCounterBuffersOes = 0x92cd,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES = 0x92CE
        /// </summary>
        MaxTessEvaluationAtomicCounterBuffersOes = 0x92ce,

        /// <summary>
        /// Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES = 0x92D3
        /// </summary>
        MaxTessControlAtomicCountersOes = 0x92d3,

        /// <summary>
        /// Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES = 0x92D4
        /// </summary>
        MaxTessEvaluationAtomicCountersOes = 0x92d4,

        /// <summary>
        /// Original was GL_IS_PER_PATCH_OES = 0x92E7
        /// </summary>
        IsPerPatchOes = 0x92e7,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES = 0x9307
        /// </summary>
        ReferencedByTessControlShaderOes = 0x9307,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES = 0x9308
        /// </summary>
        ReferencedByTessEvaluationShaderOes = 0x9308
    }
}
