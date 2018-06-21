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
    /// Used in GL.NV.ProgramVertexLimit
    /// </summary>
    public enum NvGeometryProgram4
    {
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
        /// Original was GL_PROGRAM_POINT_SIZE_EXT = 0x8642
        /// </summary>
        ProgramPointSizeExt = 0x8642,

        /// <summary>
        /// Original was GL_GEOMETRY_PROGRAM_NV = 0x8C26
        /// </summary>
        GeometryProgramNv = 0x8c26,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27
        /// </summary>
        MaxProgramOutputVerticesNv = 0x8c27,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28
        /// </summary>
        MaxProgramTotalOutputComponentsNv = 0x8c28,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29
        /// </summary>
        MaxGeometryTextureImageUnitsExt = 0x8c29,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayerExt = 0x8cd4,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7
        /// </summary>
        FramebufferAttachmentLayeredExt = 0x8da7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargetsExt = 0x8da8,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9
        /// </summary>
        FramebufferIncompleteLayerCountExt = 0x8da9,

        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT_EXT = 0x8DDA
        /// </summary>
        GeometryVerticesOutExt = 0x8dda,

        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE_EXT = 0x8DDB
        /// </summary>
        GeometryInputTypeExt = 0x8ddb,

        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC
        /// </summary>
        GeometryOutputTypeExt = 0x8ddc
    }
}
