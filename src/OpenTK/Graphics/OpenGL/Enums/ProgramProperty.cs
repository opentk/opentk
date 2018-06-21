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
    /// Used in GL.GetProgramResource
    /// </summary>
    public enum ProgramProperty
    {
        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = 0x8e4a,

        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = 0x8e4b,

        /// <summary>
        /// Original was GL_IS_PER_PATCH = 0x92E7
        /// </summary>
        IsPerPatch = 0x92e7,

        /// <summary>
        /// Original was GL_NAME_LENGTH = 0x92F9
        /// </summary>
        NameLength = 0x92f9,

        /// <summary>
        /// Original was GL_TYPE = 0x92FA
        /// </summary>
        Type = 0x92fa,

        /// <summary>
        /// Original was GL_ARRAY_SIZE = 0x92FB
        /// </summary>
        ArraySize = 0x92fb,

        /// <summary>
        /// Original was GL_OFFSET = 0x92FC
        /// </summary>
        Offset = 0x92fc,

        /// <summary>
        /// Original was GL_BLOCK_INDEX = 0x92FD
        /// </summary>
        BlockIndex = 0x92fd,

        /// <summary>
        /// Original was GL_ARRAY_STRIDE = 0x92FE
        /// </summary>
        ArrayStride = 0x92fe,

        /// <summary>
        /// Original was GL_MATRIX_STRIDE = 0x92FF
        /// </summary>
        MatrixStride = 0x92ff,

        /// <summary>
        /// Original was GL_IS_ROW_MAJOR = 0x9300
        /// </summary>
        IsRowMajor = 0x9300,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301
        /// </summary>
        AtomicCounterBufferIndex = 0x9301,

        /// <summary>
        /// Original was GL_BUFFER_BINDING = 0x9302
        /// </summary>
        BufferBinding = 0x9302,

        /// <summary>
        /// Original was GL_BUFFER_DATA_SIZE = 0x9303
        /// </summary>
        BufferDataSize = 0x9303,

        /// <summary>
        /// Original was GL_NUM_ACTIVE_VARIABLES = 0x9304
        /// </summary>
        NumActiveVariables = 0x9304,

        /// <summary>
        /// Original was GL_ACTIVE_VARIABLES = 0x9305
        /// </summary>
        ActiveVariables = 0x9305,

        /// <summary>
        /// Original was GL_REFERENCED_BY_VERTEX_SHADER = 0x9306
        /// </summary>
        ReferencedByVertexShader = 0x9306,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307
        /// </summary>
        ReferencedByTessControlShader = 0x9307,

        /// <summary>
        /// Original was GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308
        /// </summary>
        ReferencedByTessEvaluationShader = 0x9308,

        /// <summary>
        /// Original was GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309
        /// </summary>
        ReferencedByGeometryShader = 0x9309,

        /// <summary>
        /// Original was GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A
        /// </summary>
        ReferencedByFragmentShader = 0x930a,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_SIZE = 0x930C
        /// </summary>
        TopLevelArraySize = 0x930c,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D
        /// </summary>
        TopLevelArrayStride = 0x930d,

        /// <summary>
        /// Original was GL_LOCATION = 0x930E
        /// </summary>
        Location = 0x930e,

        /// <summary>
        /// Original was GL_LOCATION_INDEX = 0x930F
        /// </summary>
        LocationIndex = 0x930f,

        /// <summary>
        /// Original was GL_LOCATION_COMPONENT = 0x934A
        /// </summary>
        LocationComponent = 0x934a,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B
        /// </summary>
        TransformFeedbackBufferIndex = 0x934b,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C
        /// </summary>
        TransformFeedbackBufferStride = 0x934c
    }
}
