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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTessellationShader
    {
        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = 0x0004,

        /// <summary>
        /// Original was GL_PATCHES = 0x000E
        /// </summary>
        Patches = 0x000e,

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
        /// Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E
        /// </summary>
        MaxCombinedTessControlUniformComponents = 0x8e1e,

        /// <summary>
        /// Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F
        /// </summary>
        MaxCombinedTessEvaluationUniformComponents = 0x8e1f,

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
        MaxTessEvaluationUniformBlocks = 0x8e8a
    }
}
