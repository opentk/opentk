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
    /// Used in GL.NV.GetActiveVarying, GL.NV.TransformFeedbackAttrib and 2 other functions
    /// </summary>
    public enum NvTransformFeedback
    {
        /// <summary>
        /// Original was GL_NEXT_BUFFER_NV = -2
        /// </summary>
        NextBufferNv = -2,

        /// <summary>
        /// Original was GL_SKIP_COMPONENTS4_NV = -3
        /// </summary>
        SkipComponents4Nv = -3,

        /// <summary>
        /// Original was GL_SKIP_COMPONENTS3_NV = -4
        /// </summary>
        SkipComponents3Nv = -4,

        /// <summary>
        /// Original was GL_SKIP_COMPONENTS2_NV = -5
        /// </summary>
        SkipComponents2Nv = -5,

        /// <summary>
        /// Original was GL_SKIP_COMPONENTS1_NV = -6
        /// </summary>
        SkipComponents1Nv = -6,

        /// <summary>
        /// Original was GL_BACK_PRIMARY_COLOR_NV = 0x8C77
        /// </summary>
        BackPrimaryColorNv = 0x8c77,

        /// <summary>
        /// Original was GL_BACK_SECONDARY_COLOR_NV = 0x8C78
        /// </summary>
        BackSecondaryColorNv = 0x8c78,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_NV = 0x8C79
        /// </summary>
        TextureCoordNv = 0x8c79,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE_NV = 0x8C7A
        /// </summary>
        ClipDistanceNv = 0x8c7a,

        /// <summary>
        /// Original was GL_VERTEX_ID_NV = 0x8C7B
        /// </summary>
        VertexIdNv = 0x8c7b,

        /// <summary>
        /// Original was GL_PRIMITIVE_ID_NV = 0x8C7C
        /// </summary>
        PrimitiveIdNv = 0x8c7c,

        /// <summary>
        /// Original was GL_GENERIC_ATTRIB_NV = 0x8C7D
        /// </summary>
        GenericAttribNv = 0x8c7d,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E
        /// </summary>
        TransformFeedbackAttribsNv = 0x8c7e,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F
        /// </summary>
        TransformFeedbackBufferModeNv = 0x8c7f,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80
        /// </summary>
        MaxTransformFeedbackSeparateComponentsNv = 0x8c80,

        /// <summary>
        /// Original was GL_ACTIVE_VARYINGS_NV = 0x8C81
        /// </summary>
        ActiveVaryingsNv = 0x8c81,

        /// <summary>
        /// Original was GL_ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82
        /// </summary>
        ActiveVaryingMaxLengthNv = 0x8c82,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83
        /// </summary>
        TransformFeedbackVaryingsNv = 0x8c83,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84
        /// </summary>
        TransformFeedbackBufferStartNv = 0x8c84,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85
        /// </summary>
        TransformFeedbackBufferSizeNv = 0x8c85,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86
        /// </summary>
        TransformFeedbackRecordNv = 0x8c86,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED_NV = 0x8C87
        /// </summary>
        PrimitivesGeneratedNv = 0x8c87,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWrittenNv = 0x8c88,

        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD_NV = 0x8C89
        /// </summary>
        RasterizerDiscardNv = 0x8c89,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV = 0x8C8A
        /// </summary>
        MaxTransformFeedbackInterleavedComponentsNv = 0x8c8a,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B
        /// </summary>
        MaxTransformFeedbackSeparateAttribsNv = 0x8c8b,

        /// <summary>
        /// Original was GL_INTERLEAVED_ATTRIBS_NV = 0x8C8C
        /// </summary>
        InterleavedAttribsNv = 0x8c8c,

        /// <summary>
        /// Original was GL_SEPARATE_ATTRIBS_NV = 0x8C8D
        /// </summary>
        SeparateAttribsNv = 0x8c8d,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E
        /// </summary>
        TransformFeedbackBufferNv = 0x8c8e,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBindingNv = 0x8c8f,

        /// <summary>
        /// Original was GL_LAYER_NV = 0x8DAA
        /// </summary>
        LayerNv = 0x8daa
    }
}
