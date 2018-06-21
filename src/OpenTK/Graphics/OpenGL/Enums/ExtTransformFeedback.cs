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
    /// Used in GL.Ext.GetTransformFeedbackVarying, GL.Ext.TransformFeedbackVaryings
    /// </summary>
    public enum ExtTransformFeedback
    {
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLengthExt = 0x8c76,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F
        /// </summary>
        TransformFeedbackBufferModeExt = 0x8c7f,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80
        /// </summary>
        MaxTransformFeedbackSeparateComponentsExt = 0x8c80,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83
        /// </summary>
        TransformFeedbackVaryingsExt = 0x8c83,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84
        /// </summary>
        TransformFeedbackBufferStartExt = 0x8c84,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85
        /// </summary>
        TransformFeedbackBufferSizeExt = 0x8c85,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED_EXT = 0x8C87
        /// </summary>
        PrimitivesGeneratedExt = 0x8c87,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWrittenExt = 0x8c88,

        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD_EXT = 0x8C89
        /// </summary>
        RasterizerDiscardExt = 0x8c89,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A
        /// </summary>
        MaxTransformFeedbackInterleavedComponentsExt = 0x8c8a,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B
        /// </summary>
        MaxTransformFeedbackSeparateAttribsExt = 0x8c8b,

        /// <summary>
        /// Original was GL_INTERLEAVED_ATTRIBS_EXT = 0x8C8C
        /// </summary>
        InterleavedAttribsExt = 0x8c8c,

        /// <summary>
        /// Original was GL_SEPARATE_ATTRIBS_EXT = 0x8C8D
        /// </summary>
        SeparateAttribsExt = 0x8c8d,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E
        /// </summary>
        TransformFeedbackBufferExt = 0x8c8e,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBindingExt = 0x8c8f
    }
}
