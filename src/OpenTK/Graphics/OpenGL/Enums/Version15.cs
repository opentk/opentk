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
    public enum Version15
    {
        /// <summary>
        /// Original was GL_FOG_COORD_SRC = 0x8450
        /// </summary>
        FogCoordSrc = 0x8450,

        /// <summary>
        /// Original was GL_FOG_COORD = 0x8451
        /// </summary>
        FogCoord = 0x8451,

        /// <summary>
        /// Original was GL_CURRENT_FOG_COORD = 0x8453
        /// </summary>
        CurrentFogCoord = 0x8453,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_TYPE = 0x8454
        /// </summary>
        FogCoordArrayType = 0x8454,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_STRIDE = 0x8455
        /// </summary>
        FogCoordArrayStride = 0x8455,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_POINTER = 0x8456
        /// </summary>
        FogCoordArrayPointer = 0x8456,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY = 0x8457
        /// </summary>
        FogCoordArray = 0x8457,

        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = 0x8580,

        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = 0x8581,

        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = 0x8582,

        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = 0x8588,

        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = 0x8589,

        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = 0x858a,

        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = 0x8764,

        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = 0x8765,

        /// <summary>
        /// Original was GL_QUERY_COUNTER_BITS = 0x8864
        /// </summary>
        QueryCounterBits = 0x8864,

        /// <summary>
        /// Original was GL_CURRENT_QUERY = 0x8865
        /// </summary>
        CurrentQuery = 0x8865,

        /// <summary>
        /// Original was GL_QUERY_RESULT = 0x8866
        /// </summary>
        QueryResult = 0x8866,

        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        /// </summary>
        QueryResultAvailable = 0x8867,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = 0x8892,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = 0x8893,

        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = 0x8894,

        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = 0x8895,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = 0x8896,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = 0x8897,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = 0x8898,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899
        /// </summary>
        IndexArrayBufferBinding = 0x8899,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = 0x889a,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B
        /// </summary>
        EdgeFlagArrayBufferBinding = 0x889b,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C
        /// </summary>
        SecondaryColorArrayBufferBinding = 0x889c,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D
        /// </summary>
        FogCoordArrayBufferBinding = 0x889d,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D
        /// </summary>
        FogCoordinateArrayBufferBinding = 0x889d,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E
        /// </summary>
        WeightArrayBufferBinding = 0x889e,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        /// </summary>
        VertexAttribArrayBufferBinding = 0x889f,

        /// <summary>
        /// Original was GL_READ_ONLY = 0x88B8
        /// </summary>
        ReadOnly = 0x88b8,

        /// <summary>
        /// Original was GL_WRITE_ONLY = 0x88B9
        /// </summary>
        WriteOnly = 0x88b9,

        /// <summary>
        /// Original was GL_READ_WRITE = 0x88BA
        /// </summary>
        ReadWrite = 0x88ba,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS = 0x88BB
        /// </summary>
        BufferAccess = 0x88bb,

        /// <summary>
        /// Original was GL_BUFFER_MAPPED = 0x88BC
        /// </summary>
        BufferMapped = 0x88bc,

        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER = 0x88BD
        /// </summary>
        BufferMapPointer = 0x88bd,

        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = 0x88e0,

        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = 0x88e1,

        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = 0x88e2,

        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = 0x88e4,

        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = 0x88e5,

        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = 0x88e6,

        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = 0x88e8,

        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = 0x88e9,

        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = 0x88ea,

        /// <summary>
        /// Original was GL_SAMPLES_PASSED = 0x8914
        /// </summary>
        SamplesPassed = 0x8914
    }
}
