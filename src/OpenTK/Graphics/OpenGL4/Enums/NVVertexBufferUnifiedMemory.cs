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
    /// Used in GL.NV.IndexFormat and GL.NV.NormalFormat, as well as 3 other functions.
    /// </summary>
    public enum NVVertexBufferUnifiedMemory
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E
        /// </summary>
        VertexAttribArrayUnifiedNV = 0x8f1e,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F
        /// </summary>
        ElementArrayUnifiedNV = 0x8f1f,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20
        /// </summary>
        VertexAttribArrayAddressNV = 0x8f20,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_ADDRESS_NV = 0x8F21
        /// </summary>
        VertexArrayAddressNV = 0x8f21,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_ADDRESS_NV = 0x8F22
        /// </summary>
        NormalArrayAddressNV = 0x8f22,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_ADDRESS_NV = 0x8F23
        /// </summary>
        ColorArrayAddressNV = 0x8f23,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_ADDRESS_NV = 0x8F24
        /// </summary>
        IndexArrayAddressNV = 0x8f24,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25
        /// </summary>
        TextureCoordArrayAddressNV = 0x8f25,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26
        /// </summary>
        EdgeFlagArrayAddressNV = 0x8f26,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27
        /// </summary>
        SecondaryColorArrayAddressNV = 0x8f27,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28
        /// </summary>
        FogCoordArrayAddressNV = 0x8f28,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_ADDRESS_NV = 0x8F29
        /// </summary>
        ElementArrayAddressNV = 0x8f29,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A
        /// </summary>
        VertexAttribArrayLengthNV = 0x8f2a,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_LENGTH_NV = 0x8F2B
        /// </summary>
        VertexArrayLengthNV = 0x8f2b,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_LENGTH_NV = 0x8F2C
        /// </summary>
        NormalArrayLengthNV = 0x8f2c,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_LENGTH_NV = 0x8F2D
        /// </summary>
        ColorArrayLengthNV = 0x8f2d,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_LENGTH_NV = 0x8F2E
        /// </summary>
        IndexArrayLengthNV = 0x8f2e,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F
        /// </summary>
        TextureCoordArrayLengthNV = 0x8f2f,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30
        /// </summary>
        EdgeFlagArrayLengthNV = 0x8f30,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31
        /// </summary>
        SecondaryColorArrayLengthNV = 0x8f31,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_LENGTH_NV = 0x8F32
        /// </summary>
        FogCoordArrayLengthNV = 0x8f32,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_LENGTH_NV = 0x8F33
        /// </summary>
        ElementArrayLengthNV = 0x8f33,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_UNIFIED_NV = 0x8F40
        /// </summary>
        DrawIndirectUnifiedNV = 0x8f40,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_ADDRESS_NV = 0x8F41
        /// </summary>
        DrawIndirectAddressNV = 0x8f41,

        /// <summary>
        /// Original was GL_DRAW_INDIRECT_LENGTH_NV = 0x8F42
        /// </summary>
        DrawIndirectLengthNV = 0x8f42
    }
}
