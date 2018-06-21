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
    /// Used in GL.Ext.VertexWeightPointer
    /// </summary>
    public enum ExtVertexWeighting
    {
        /// <summary>
        /// Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3
        /// </summary>
        Modelview0StackDepthExt = 0x0ba3,

        /// <summary>
        /// Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        /// </summary>
        Modelview0MatrixExt = 0x0ba6,

        /// <summary>
        /// Original was GL_MODELVIEW0_EXT = 0x1700
        /// </summary>
        Modelview0Ext = 0x1700,

        /// <summary>
        /// Original was GL_MODELVIEW1_STACK_DEPTH_EXT = 0x8502
        /// </summary>
        Modelview1StackDepthExt = 0x8502,

        /// <summary>
        /// Original was GL_MODELVIEW1_MATRIX_EXT = 0x8506
        /// </summary>
        Modelview1MatrixExt = 0x8506,

        /// <summary>
        /// Original was GL_VERTEX_WEIGHTING_EXT = 0x8509
        /// </summary>
        VertexWeightingExt = 0x8509,

        /// <summary>
        /// Original was GL_MODELVIEW1_EXT = 0x850A
        /// </summary>
        Modelview1Ext = 0x850a,

        /// <summary>
        /// Original was GL_CURRENT_VERTEX_WEIGHT_EXT = 0x850B
        /// </summary>
        CurrentVertexWeightExt = 0x850b,

        /// <summary>
        /// Original was GL_VERTEX_WEIGHT_ARRAY_EXT = 0x850C
        /// </summary>
        VertexWeightArrayExt = 0x850c,

        /// <summary>
        /// Original was GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D
        /// </summary>
        VertexWeightArraySizeExt = 0x850d,

        /// <summary>
        /// Original was GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E
        /// </summary>
        VertexWeightArrayTypeExt = 0x850e,

        /// <summary>
        /// Original was GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F
        /// </summary>
        VertexWeightArrayStrideExt = 0x850f,

        /// <summary>
        /// Original was GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510
        /// </summary>
        VertexWeightArrayPointerExt = 0x8510
    }
}
