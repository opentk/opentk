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
    /// Used in GL.NV.BufferAddressRange, GL.NV.GetIntegerui64 and 5 other functions
    /// </summary>
    public enum NvVertexBufferUnifiedMemory
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E
        /// </summary>
        VertexAttribArrayUnifiedNv = 0x8f1e,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F
        /// </summary>
        ElementArrayUnifiedNv = 0x8f1f,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20
        /// </summary>
        VertexAttribArrayAddressNv = 0x8f20,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_ADDRESS_NV = 0x8F21
        /// </summary>
        VertexArrayAddressNv = 0x8f21,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_ADDRESS_NV = 0x8F22
        /// </summary>
        NormalArrayAddressNv = 0x8f22,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_ADDRESS_NV = 0x8F23
        /// </summary>
        ColorArrayAddressNv = 0x8f23,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_ADDRESS_NV = 0x8F24
        /// </summary>
        IndexArrayAddressNv = 0x8f24,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25
        /// </summary>
        TextureCoordArrayAddressNv = 0x8f25,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26
        /// </summary>
        EdgeFlagArrayAddressNv = 0x8f26,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27
        /// </summary>
        SecondaryColorArrayAddressNv = 0x8f27,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28
        /// </summary>
        FogCoordArrayAddressNv = 0x8f28,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_ADDRESS_NV = 0x8F29
        /// </summary>
        ElementArrayAddressNv = 0x8f29,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A
        /// </summary>
        VertexAttribArrayLengthNv = 0x8f2a,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_LENGTH_NV = 0x8F2B
        /// </summary>
        VertexArrayLengthNv = 0x8f2b,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_LENGTH_NV = 0x8F2C
        /// </summary>
        NormalArrayLengthNv = 0x8f2c,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_LENGTH_NV = 0x8F2D
        /// </summary>
        ColorArrayLengthNv = 0x8f2d,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_LENGTH_NV = 0x8F2E
        /// </summary>
        IndexArrayLengthNv = 0x8f2e,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F
        /// </summary>
        TextureCoordArrayLengthNv = 0x8f2f,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30
        /// </summary>
        EdgeFlagArrayLengthNv = 0x8f30,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31
        /// </summary>
        SecondaryColorArrayLengthNv = 0x8f31,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_LENGTH_NV = 0x8F32
        /// </summary>
        FogCoordArrayLengthNv = 0x8f32,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_LENGTH_NV = 0x8F33
        /// </summary>
        ElementArrayLengthNv = 0x8f33,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_UNIFIED_NV = 0x8F40
        /// </summary>
        DrawIndirectUnifiedNv = 0x8f40,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_ADDRESS_NV = 0x8F41
        /// </summary>
        DrawIndirectAddressNv = 0x8f41,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_LENGTH_NV = 0x8F42
        /// </summary>
        DrawIndirectLengthNv = 0x8f42
    }
}
