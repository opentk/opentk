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
    /// Used in GL.ARB.GetnMap and GL.GetnMap.
    /// </summary>
    public enum MapTarget
    {
        /// <summary>
        /// Original was GL_MAP1_COLOR4 = 0xD90
        /// </summary>
        Map1Color4 = 0xD90,

        /// <summary>
        /// Original was GL_MAP1_INDEX = 0xD91
        /// </summary>
        Map1Index = 0xD91,

        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0xD92
        /// </summary>
        Map1Normal = 0xD92,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD1 = 0xD93
        /// </summary>
        Map1TextureCoord1 = 0xD93,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD2 = 0xD94
        /// </summary>
        Map1TextureCoord2 = 0xD94,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD3 = 0xD95
        /// </summary>
        Map1TextureCoord3 = 0xD95,

        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD4 = 0xD96
        /// </summary>
        Map1TextureCoord4 = 0xD96,

        /// <summary>
        /// Original was GL_MAP1_VERTEX3 = 0xD97
        /// </summary>
        Map1Vertex3 = 0xD97,

        /// <summary>
        /// Original was GL_MAP1_VERTEX4 = 0xD98
        /// </summary>
        Map1Vertex4 = 0xD98,

        /// <summary>
        /// Original was GL_MAP2_COLOR4 = 0xDB0
        /// </summary>
        Map2Color4 = 0xDB0,

        /// <summary>
        /// Original was GL_MAP2_INDEX = 0xDB1
        /// </summary>
        Map2Index = 0xDB1,

        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0xDB2
        /// </summary>
        Map2Normal = 0xDB2,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD1 = 0xDB3
        /// </summary>
        Map2TextureCoord1 = 0xDB3,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD2 = 0xDB4
        /// </summary>
        Map2TextureCoord2 = 0xDB4,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD3 = 0xDB5
        /// </summary>
        Map2TextureCoord3 = 0xDB5,

        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD4 = 0xDB6
        /// </summary>
        Map2TextureCoord4 = 0xDB6,

        /// <summary>
        /// Original was GL_MAP2_VERTEX3 = 0xDB7
        /// </summary>
        Map2Vertex3 = 0xDB7,

        /// <summary>
        /// Original was GL_MAP2_VERTEX4 = 0xDB8
        /// </summary>
        Map2Vertex4 = 0xDB8,

        /// <summary>
        /// Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        /// </summary>
        GeometryDeformationSgix = 0x8194,

        /// <summary>
        /// Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        /// </summary>
        TextureDeformationSgix = 0x8195
    }
}
