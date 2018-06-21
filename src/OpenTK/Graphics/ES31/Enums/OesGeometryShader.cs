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
    /// Not used directly.
    /// </summary>
    public enum OesGeometryShader
    {
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_OES = 0x00000004
        /// </summary>
        GeometryShaderBitOes = ((int)0x00000004),

        /// <summary>
        /// Original was GL_LINES_ADJACENCY_OES = 0x000A
        /// </summary>
        LinesAdjacencyOes = 0x000a,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_OES = 0x000B
        /// </summary>
        LineStripAdjacencyOes = 0x000b,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_OES = 0x000C
        /// </summary>
        TrianglesAdjacencyOes = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_OES = 0x000D
        /// </summary>
        TriangleStripAdjacencyOes = 0x000d,

        /// <summary>
        /// Original was GL_LAYER_PROVOKING_VERTEX_OES = 0x825E
        /// </summary>
        LayerProvokingVertexOes = 0x825e,

        /// <summary>
        /// Original was GL_UNDEFINED_VERTEX_OES = 0x8260
        /// </summary>
        UndefinedVertexOes = 0x8260,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS_OES = 0x887F
        /// </summary>
        GeometryShaderInvocationsOes = 0x887f,

        /// <summary>
        /// Original was GL_GEOMETRY_LINKED_VERTICES_OUT_OES = 0x8916
        /// </summary>
        GeometryLinkedVerticesOutOes = 0x8916,

        /// <summary>
        /// Original was GL_GEOMETRY_LINKED_INPUT_TYPE_OES = 0x8917
        /// </summary>
        GeometryLinkedInputTypeOes = 0x8917,

        /// <summary>
        /// Original was GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES = 0x8918
        /// </summary>
        GeometryLinkedOutputTypeOes = 0x8918,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES = 0x8A2C
        /// </summary>
        MaxGeometryUniformBlocksOes = 0x8a2c,

        /// <summary>
        /// Original was GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8A32
        /// </summary>
        MaxCombinedGeometryUniformComponentsOes = 0x8a32,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES = 0x8C29
        /// </summary>
        MaxGeometryTextureImageUnitsOes = 0x8c29,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED_OES = 0x8C87
        /// </summary>
        PrimitivesGeneratedOes = 0x8c87,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayeredOes = 0x8da7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargetsOes = 0x8da8,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_OES = 0x8DD9
        /// </summary>
        GeometryShaderOes = 0x8dd9,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8DDF
        /// </summary>
        MaxGeometryUniformComponentsOes = 0x8ddf,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES = 0x8DE0
        /// </summary>
        MaxGeometryOutputVerticesOes = 0x8de0,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES = 0x8DE1
        /// </summary>
        MaxGeometryTotalOutputComponentsOes = 0x8de1,

        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION_OES = 0x8E4D
        /// </summary>
        FirstVertexConventionOes = 0x8e4d,

        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION_OES = 0x8E4E
        /// </summary>
        LastVertexConventionOes = 0x8e4e,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES = 0x8E5A
        /// </summary>
        MaxGeometryShaderInvocationsOes = 0x8e5a,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES = 0x90CD
        /// </summary>
        MaxGeometryImageUniformsOes = 0x90cd,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES = 0x90D7
        /// </summary>
        MaxGeometryShaderStorageBlocksOes = 0x90d7,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES = 0x9123
        /// </summary>
        MaxGeometryInputComponentsOes = 0x9123,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES = 0x9124
        /// </summary>
        MaxGeometryOutputComponentsOes = 0x9124,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES = 0x92CF
        /// </summary>
        MaxGeometryAtomicCounterBuffersOes = 0x92cf,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES = 0x92D5
        /// </summary>
        MaxGeometryAtomicCountersOes = 0x92d5,

        /// <summary>
        /// Original was GL_REFERENCED_BY_GEOMETRY_SHADER_OES = 0x9309
        /// </summary>
        ReferencedByGeometryShaderOes = 0x9309,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS_OES = 0x9312
        /// </summary>
        FramebufferDefaultLayersOes = 0x9312,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_LAYERS_OES = 0x9317
        /// </summary>
        MaxFramebufferLayersOes = 0x9317
    }
}
