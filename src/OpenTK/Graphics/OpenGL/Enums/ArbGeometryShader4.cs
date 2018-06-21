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
    public enum ArbGeometryShader4
    {
        /// <summary>
        /// Original was GL_LINES_ADJACENCY_ARB = 0x000A
        /// </summary>
        LinesAdjacencyArb = 0x000a,

        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
        /// </summary>
        LineStripAdjacencyArb = 0x000b,

        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
        /// </summary>
        TrianglesAdjacencyArb = 0x000c,

        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
        /// </summary>
        TriangleStripAdjacencyArb = 0x000d,

        /// <summary>
        /// Original was GL_PROGRAM_POINT_SIZE_ARB = 0x8642
        /// </summary>
        ProgramPointSizeArb = 0x8642,

        /// <summary>
        /// Original was GL_MAX_VARYING_COMPONENTS = 0x8B4B
        /// </summary>
        MaxVaryingComponents = 0x8b4b,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29
        /// </summary>
        MaxGeometryTextureImageUnitsArb = 0x8c29,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = 0x8cd4,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayeredArb = 0x8da7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargetsArb = 0x8da8,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9
        /// </summary>
        FramebufferIncompleteLayerCountArb = 0x8da9,

        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_ARB = 0x8DD9
        /// </summary>
        GeometryShaderArb = 0x8dd9,

        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA
        /// </summary>
        GeometryVerticesOutArb = 0x8dda,

        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB
        /// </summary>
        GeometryInputTypeArb = 0x8ddb,

        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC
        /// </summary>
        GeometryOutputTypeArb = 0x8ddc,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD
        /// </summary>
        MaxGeometryVaryingComponentsArb = 0x8ddd,

        /// <summary>
        /// Original was GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE
        /// </summary>
        MaxVertexVaryingComponentsArb = 0x8dde,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF
        /// </summary>
        MaxGeometryUniformComponentsArb = 0x8ddf,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0
        /// </summary>
        MaxGeometryOutputVerticesArb = 0x8de0,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1
        /// </summary>
        MaxGeometryTotalOutputComponentsArb = 0x8de1
    }
}
