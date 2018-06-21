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
    public enum ExtGeometryShader
    {
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_BIT_EXT = 0x00000004
        /// </summary>
        GeometryShaderBitExt = ((int)0x00000004),

        /// <summary>
        /// Original was GL_LINES_ADJACENCY_EXT = 0x000A
        /// </summary>
        LinesAdjacencyExt = 0x000a,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
        /// </summary>
        LineStripAdjacencyExt = 0x000b,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
        /// </summary>
        TrianglesAdjacencyExt = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        /// </summary>
        TriangleStripAdjacencyExt = 0x000d,

        /// <summary>
        /// Original was GL_LAYER_PROVOKING_VERTEX_EXT = 0x825E
        /// </summary>
        LayerProvokingVertexExt = 0x825e,

        /// <summary>
        /// Original was GL_UNDEFINED_VERTEX_EXT = 0x8260
        /// </summary>
        UndefinedVertexExt = 0x8260,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x887F
        /// </summary>
        GeometryShaderInvocationsExt = 0x887f,

        /// <summary>
        /// Original was GL_GEOMETRY_LINKED_VERTICES_OUT_EXT = 0x8916
        /// </summary>
        GeometryLinkedVerticesOutExt = 0x8916,

        /// <summary>
        /// Original was GL_GEOMETRY_LINKED_INPUT_TYPE_EXT = 0x8917
        /// </summary>
        GeometryLinkedInputTypeExt = 0x8917,

        /// <summary>
        /// Original was GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT = 0x8918
        /// </summary>
        GeometryLinkedOutputTypeExt = 0x8918,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT = 0x8A2C
        /// </summary>
        MaxGeometryUniformBlocksExt = 0x8a2c,

        /// <summary>
        /// Original was GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8A32
        /// </summary>
        MaxCombinedGeometryUniformComponentsExt = 0x8a32,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29
        /// </summary>
        MaxGeometryTextureImageUnitsExt = 0x8c29,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED_EXT = 0x8C87
        /// </summary>
        PrimitivesGeneratedExt = 0x8c87,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayeredExt = 0x8da7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargetsExt = 0x8da8,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_EXT = 0x8DD9
        /// </summary>
        GeometryShaderExt = 0x8dd9,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF
        /// </summary>
        MaxGeometryUniformComponentsExt = 0x8ddf,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0
        /// </summary>
        MaxGeometryOutputVerticesExt = 0x8de0,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1
        /// </summary>
        MaxGeometryTotalOutputComponentsExt = 0x8de1,

        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION_EXT = 0x8E4D
        /// </summary>
        FirstVertexConventionExt = 0x8e4d,

        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION_EXT = 0x8E4E
        /// </summary>
        LastVertexConventionExt = 0x8e4e,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x8E5A
        /// </summary>
        MaxGeometryShaderInvocationsExt = 0x8e5a,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT = 0x90CD
        /// </summary>
        MaxGeometryImageUniformsExt = 0x90cd,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT = 0x90D7
        /// </summary>
        MaxGeometryShaderStorageBlocksExt = 0x90d7,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT = 0x9123
        /// </summary>
        MaxGeometryInputComponentsExt = 0x9123,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT = 0x9124
        /// </summary>
        MaxGeometryOutputComponentsExt = 0x9124,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CF
        /// </summary>
        MaxGeometryAtomicCounterBuffersExt = 0x92cf,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT = 0x92D5
        /// </summary>
        MaxGeometryAtomicCountersExt = 0x92d5,

        /// <summary>
        /// Original was GL_REFERENCED_BY_GEOMETRY_SHADER_EXT = 0x9309
        /// </summary>
        ReferencedByGeometryShaderExt = 0x9309,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT = 0x9312
        /// </summary>
        FramebufferDefaultLayersExt = 0x9312,

        /// <summary>
        /// Original was GL_MAX_FRAMEBUFFER_LAYERS_EXT = 0x9317
        /// </summary>
        MaxFramebufferLayersExt = 0x9317
    }
}
