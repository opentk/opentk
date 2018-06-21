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
    public enum PgiVertexHints
    {
        /// <summary>
        /// Original was GL_VERTEX23_BIT_PGI = 0x00000004
        /// </summary>
        Vertex23BitPgi = ((int)0x00000004),

        /// <summary>
        /// Original was GL_VERTEX4_BIT_PGI = 0x00000008
        /// </summary>
        Vertex4BitPgi = ((int)0x00000008),

        /// <summary>
        /// Original was GL_COLOR3_BIT_PGI = 0x00010000
        /// </summary>
        Color3BitPgi = ((int)0x00010000),

        /// <summary>
        /// Original was GL_COLOR4_BIT_PGI = 0x00020000
        /// </summary>
        Color4BitPgi = ((int)0x00020000),

        /// <summary>
        /// Original was GL_EDGEFLAG_BIT_PGI = 0x00040000
        /// </summary>
        EdgeflagBitPgi = ((int)0x00040000),

        /// <summary>
        /// Original was GL_INDEX_BIT_PGI = 0x00080000
        /// </summary>
        IndexBitPgi = ((int)0x00080000),

        /// <summary>
        /// Original was GL_MAT_AMBIENT_BIT_PGI = 0x00100000
        /// </summary>
        MatAmbientBitPgi = ((int)0x00100000),

        /// <summary>
        /// Original was GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000
        /// </summary>
        MatAmbientAndDiffuseBitPgi = ((int)0x00200000),

        /// <summary>
        /// Original was GL_MAT_DIFFUSE_BIT_PGI = 0x00400000
        /// </summary>
        MatDiffuseBitPgi = ((int)0x00400000),

        /// <summary>
        /// Original was GL_MAT_EMISSION_BIT_PGI = 0x00800000
        /// </summary>
        MatEmissionBitPgi = ((int)0x00800000),

        /// <summary>
        /// Original was GL_MAT_COLOR_INDEXES_BIT_PGI = 0x01000000
        /// </summary>
        MatColorIndexesBitPgi = ((int)0x01000000),

        /// <summary>
        /// Original was GL_MAT_SHININESS_BIT_PGI = 0x02000000
        /// </summary>
        MatShininessBitPgi = ((int)0x02000000),

        /// <summary>
        /// Original was GL_MAT_SPECULAR_BIT_PGI = 0x04000000
        /// </summary>
        MatSpecularBitPgi = ((int)0x04000000),

        /// <summary>
        /// Original was GL_NORMAL_BIT_PGI = 0x08000000
        /// </summary>
        NormalBitPgi = ((int)0x08000000),

        /// <summary>
        /// Original was GL_TEXCOORD1_BIT_PGI = 0x10000000
        /// </summary>
        Texcoord1BitPgi = ((int)0x10000000),

        /// <summary>
        /// Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        /// </summary>
        VertexDataHintPgi = 0x1a22a,

        /// <summary>
        /// Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        /// </summary>
        VertexConsistentHintPgi = 0x1a22b,

        /// <summary>
        /// Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        /// </summary>
        MaterialSideHintPgi = 0x1a22c,

        /// <summary>
        /// Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        /// </summary>
        MaxVertexHintPgi = 0x1a22d,

        /// <summary>
        /// Original was GL_TEXCOORD2_BIT_PGI = 0x20000000
        /// </summary>
        Texcoord2BitPgi = ((int)0x20000000),

        /// <summary>
        /// Original was GL_TEXCOORD3_BIT_PGI = 0x40000000
        /// </summary>
        Texcoord3BitPgi = ((int)0x40000000),

        /// <summary>
        /// Original was GL_TEXCOORD4_BIT_PGI = 0x80000000
        /// </summary>
        Texcoord4BitPgi = unchecked((int)0x80000000)
    }
}
