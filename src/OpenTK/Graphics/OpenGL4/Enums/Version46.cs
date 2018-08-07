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
    /// Used in GL.MultiDrawElementsIndirectCount.
    /// </summary>
    public enum Version46
    {
        /// <summary>
        /// Original was GL_NONE = 0x0
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x8
        /// </summary>
        ContextFlagNoErrorBit = 0x8,

        /// <summary>
        /// Original was GL_PARAMETER_BUFFER = 0x80EE
        /// </summary>
        ParameterBuffer = 0x80EE,

        /// <summary>
        /// Original was GL_PARAMETER_BUFFER_BINDING = 0x80EF
        /// </summary>
        ParameterBufferBinding = 0x80EF,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC
        /// </summary>
        TransformFeedbackOverflow = 0x82EC,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED
        /// </summary>
        TransformFeedbackStreamOverflow = 0x82ED,

        /// <summary>
        /// Original was GL_VERTICES_SUBMITTED = 0x82EE
        /// </summary>
        VerticesSubmitted = 0x82EE,

        /// <summary>
        /// Original was GL_PRIMITIVES_SUBMITTED = 0x82EF
        /// </summary>
        PrimitivesSubmitted = 0x82EF,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_INVOCATIONS = 0x82F0
        /// </summary>
        VertexShaderInvocations = 0x82F0,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1
        /// </summary>
        TessControlShaderPatches = 0x82F1,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2
        /// </summary>
        TessEvaluationShaderInvocations = 0x82F2,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3
        /// </summary>
        GeometryShaderPrimitivesEmitted = 0x82F3,

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4
        /// </summary>
        FragmentShaderInvocations = 0x82F4,

        /// <summary>
        /// Original was GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5
        /// </summary>
        ComputeShaderInvocations = 0x82F5,

        /// <summary>
        /// Original was GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6
        /// </summary>
        ClippingInputPrimitives = 0x82F6,

        /// <summary>
        /// Original was GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7
        /// </summary>
        ClippingOutputPrimitives = 0x82F7,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB
        /// </summary>
        ContextReleaseBehavior = 0x82FB,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC
        /// </summary>
        ContextReleaseBehaviorFlush = 0x82FC,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY = 0x84FE
        /// </summary>
        TextureMaxAnisotropy = 0x84FE,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropy = 0x84FF,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        /// </summary>
        GeometryShaderInvocations = 0x887F,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_CLAMP = 0x8E1B
        /// </summary>
        PolygonOffsetClamp = 0x8E1B,

        /// <summary>
        /// Original was GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551
        /// </summary>
        ShaderBinaryFormatSpirV = 0x9551,

        /// <summary>
        /// Original was GL_SPIR_V_BINARY = 0x9552
        /// </summary>
        SpirVBinary = 0x9552,

        /// <summary>
        /// Original was GL_SPIR_V_EXTENSIONS = 0x9553
        /// </summary>
        SpirVExtensions = 0x9553,

        /// <summary>
        /// Original was GL_NUM_SPIR_V_EXTENSIONS = 0x9554
        /// </summary>
        NumSpirVExtensions = 0x9554
    }
}
