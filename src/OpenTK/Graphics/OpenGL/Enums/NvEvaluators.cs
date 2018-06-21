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
    /// Used in GL.NV.EvalMap, GL.NV.GetMapAttribParameter and 4 other functions
    /// </summary>
    public enum NvEvaluators
    {
        /// <summary>
        /// Original was GL_EVAL_2D_NV = 0x86C0
        /// </summary>
        Eval2DNv = 0x86c0,

        /// <summary>
        /// Original was GL_EVAL_TRIANGULAR_2D_NV = 0x86C1
        /// </summary>
        EvalTriangular2DNv = 0x86c1,

        /// <summary>
        /// Original was GL_MAP_TESSELLATION_NV = 0x86C2
        /// </summary>
        MapTessellationNv = 0x86c2,

        /// <summary>
        /// Original was GL_MAP_ATTRIB_U_ORDER_NV = 0x86C3
        /// </summary>
        MapAttribUOrderNv = 0x86c3,

        /// <summary>
        /// Original was GL_MAP_ATTRIB_V_ORDER_NV = 0x86C4
        /// </summary>
        MapAttribVOrderNv = 0x86c4,

        /// <summary>
        /// Original was GL_EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5
        /// </summary>
        EvalFractionalTessellationNv = 0x86c5,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB0_NV = 0x86C6
        /// </summary>
        EvalVertexAttrib0Nv = 0x86c6,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB1_NV = 0x86C7
        /// </summary>
        EvalVertexAttrib1Nv = 0x86c7,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB2_NV = 0x86C8
        /// </summary>
        EvalVertexAttrib2Nv = 0x86c8,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB3_NV = 0x86C9
        /// </summary>
        EvalVertexAttrib3Nv = 0x86c9,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB4_NV = 0x86CA
        /// </summary>
        EvalVertexAttrib4Nv = 0x86ca,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB5_NV = 0x86CB
        /// </summary>
        EvalVertexAttrib5Nv = 0x86cb,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB6_NV = 0x86CC
        /// </summary>
        EvalVertexAttrib6Nv = 0x86cc,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB7_NV = 0x86CD
        /// </summary>
        EvalVertexAttrib7Nv = 0x86cd,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB8_NV = 0x86CE
        /// </summary>
        EvalVertexAttrib8Nv = 0x86ce,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB9_NV = 0x86CF
        /// </summary>
        EvalVertexAttrib9Nv = 0x86cf,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB10_NV = 0x86D0
        /// </summary>
        EvalVertexAttrib10Nv = 0x86d0,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB11_NV = 0x86D1
        /// </summary>
        EvalVertexAttrib11Nv = 0x86d1,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB12_NV = 0x86D2
        /// </summary>
        EvalVertexAttrib12Nv = 0x86d2,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB13_NV = 0x86D3
        /// </summary>
        EvalVertexAttrib13Nv = 0x86d3,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB14_NV = 0x86D4
        /// </summary>
        EvalVertexAttrib14Nv = 0x86d4,

        /// <summary>
        /// Original was GL_EVAL_VERTEX_ATTRIB15_NV = 0x86D5
        /// </summary>
        EvalVertexAttrib15Nv = 0x86d5,

        /// <summary>
        /// Original was GL_MAX_MAP_TESSELLATION_NV = 0x86D6
        /// </summary>
        MaxMapTessellationNv = 0x86d6,

        /// <summary>
        /// Original was GL_MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7
        /// </summary>
        MaxRationalEvalOrderNv = 0x86d7
    }
}
