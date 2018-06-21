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
    public enum ArbPipelineStatisticsQuery
    {
        /// <summary>
        /// Original was GL_VERTICES_SUBMITTED_ARB = 0x82EE
        /// </summary>
        VerticesSubmittedArb = 0x82ee,

        /// <summary>
        /// Original was GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF
        /// </summary>
        PrimitivesSubmittedArb = 0x82ef,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0
        /// </summary>
        VertexShaderInvocationsArb = 0x82f0,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1
        /// </summary>
        TessControlShaderPatchesArb = 0x82f1,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2
        /// </summary>
        TessEvaluationShaderInvocationsArb = 0x82f2,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3
        /// </summary>
        GeometryShaderPrimitivesEmittedArb = 0x82f3,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4
        /// </summary>
        FragmentShaderInvocationsArb = 0x82f4,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5
        /// </summary>
        ComputeShaderInvocationsArb = 0x82f5,

        /// <summary>
        /// Original was GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6
        /// </summary>
        ClippingInputPrimitivesArb = 0x82f6,

        /// <summary>
        /// Original was GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7
        /// </summary>
        ClippingOutputPrimitivesArb = 0x82f7,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        /// </summary>
        GeometryShaderInvocations = 0x887f
    }
}
