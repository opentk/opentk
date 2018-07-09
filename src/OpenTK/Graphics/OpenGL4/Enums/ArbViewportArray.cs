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
    /// Not used directly.
    /// </summary>
    public enum ArbViewportArray
    {
        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = 0x0b70,

        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = 0x0ba2,

        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = 0x0c10,

        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = 0x0c11,

        /// <summary>
        /// Original was GL_MAX_VIEWPORTS = 0x825B
        /// </summary>
        MaxViewports = 0x825b,

        /// <summary>
        /// Original was GL_VIEWPORT_SUBPIXEL_BITS = 0x825C
        /// </summary>
        ViewportSubpixelBits = 0x825c,

        /// <summary>
        /// Original was GL_VIEWPORT_BOUNDS_RANGE = 0x825D
        /// </summary>
        ViewportBoundsRange = 0x825d,

        /// <summary>
        /// Original was GL_LAYER_PROVOKING_VERTEX = 0x825E
        /// </summary>
        LayerProvokingVertex = 0x825e,

        /// <summary>
        /// Original was GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F
        /// </summary>
        ViewportIndexProvokingVertex = 0x825f,

        /// <summary>
        /// Original was GL_UNDEFINED_VERTEX = 0x8260
        /// </summary>
        UndefinedVertex = 0x8260,

        /// <summary>
        /// Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        /// </summary>
        FirstVertexConvention = 0x8e4d,

        /// <summary>
        /// Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        /// </summary>
        LastVertexConvention = 0x8e4e,

        /// <summary>
        /// Original was GL_PROVOKING_VERTEX = 0x8E4F
        /// </summary>
        ProvokingVertex = 0x8e4f
    }
}
