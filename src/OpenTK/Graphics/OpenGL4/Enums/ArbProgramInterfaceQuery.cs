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
    public enum ArbProgramInterfaceQuery
    {
        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = 0x8E4A,

        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = 0x8E4B,

        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = 0x92C0,

        /// <summary>
        /// Original was GL_UNIFORM = 0x92E1
        /// </summary>
        Uniform = 0x92E1,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK = 0x92E2
        /// </summary>
        UniformBlock = 0x92E2,

        /// <summary>
        /// Original was GL_PROGRAM_INPUT = 0x92E3
        /// </summary>
        ProgramInput = 0x92E3,

        /// <summary>
        /// Original was GL_PROGRAM_OUTPUT = 0x92E4
        /// </summary>
        ProgramOutput = 0x92E4,

        /// <summary>
        /// Original was GL_BUFFER_VARIABLE = 0x92E5
        /// </summary>
        BufferVariable = 0x92E5,

        /// <summary>
        /// Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        /// </summary>
        ShaderStorageBlock = 0x92E6,

        /// <summary>
        /// Original was GL_IS_PER_PATCH = 0x92E7
        /// </summary>
        IsPerPatch = 0x92E7,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE = 0x92E8
        /// </summary>
        VertexSubroutine = 0x92E8,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        /// </summary>
        TessControlSubroutine = 0x92E9,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        /// </summary>
        TessEvaluationSubroutine = 0x92EA,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        /// </summary>
        GeometrySubroutine = 0x92EB,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        /// </summary>
        FragmentSubroutine = 0x92EC,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        /// </summary>
        ComputeSubroutine = 0x92ED,

        /// <summary>
        /// Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        /// </summary>
        VertexSubroutineUniform = 0x92EE,

        /// <summary>
        /// Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        /// </summary>
        TessControlSubroutineUniform = 0x92EF,

        /// <summary>
        /// Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        /// </summary>
        TessEvaluationSubroutineUniform = 0x92F0,

        /// <summary>
        /// Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        /// </summary>
        GeometrySubroutineUniform = 0x92F1,

        /// <summary>
        /// Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        /// </summary>
        FragmentSubroutineUniform = 0x92F2,

        /// <summary>
        /// Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        /// </summary>
        ComputeSubroutineUniform = 0x92F3,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        /// </summary>
        TransformFeedbackVarying = 0x92F4,

        /// <summary>
        /// Original was GL_ACTIVE_RESOURCES = 0x92F5
        /// </summary>
        ActiveResources = 0x92F5,

        /// <summary>
        /// Original was GL_MAX_NAME_LENGTH = 0x92F6
        /// </summary>
        MaxNameLength = 0x92F6,

        /// <summary>
        /// Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        /// </summary>
        MaxNumActiveVariables = 0x92F7,

        /// <summary>
        /// Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        /// </summary>
        MaxNumCompatibleSubroutines = 0x92F8,

        /// <summary>
        /// Original was GL_NAME_LENGTH = 0x92F9
        /// </summary>
        NameLength = 0x92F9,

        /// <summary>
        /// Original was GL_TYPE = 0x92FA
        /// </summary>
        Type = 0x92FA,

        /// <summary>
        /// Original was GL_ARRAY_SIZE = 0x92FB
        /// </summary>
        ArraySize = 0x92FB,

        /// <summary>
        /// Original was GL_OFFSET = 0x92FC
        /// </summary>
        Offset = 0x92FC,

        /// <summary>
        /// Original was GL_BLOCK_INDEX = 0x92FD
        /// </summary>
        BlockIndex = 0x92FD,

        /// <summary>
        /// Original was GL_ARRAY_STRIDE = 0x92FE
        /// </summary>
        ArrayStride = 0x92FE,

        /// <summary>
        /// Original was GL_MATRIX_STRIDE = 0x92FF
        /// </summary>
        MatrixStride = 0x92FF,

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
        ReferencedByFragmentShader = 0x930A,

        /// <summary>
        /// Original was GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B
        /// </summary>
        ReferencedByComputeShader = 0x930B,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_SIZE = 0x930C
        /// </summary>
        TopLevelArraySize = 0x930C,

        /// <summary>
        /// Original was GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D
        /// </summary>
        TopLevelArrayStride = 0x930D,

        /// <summary>
        /// Original was GL_LOCATION = 0x930E
        /// </summary>
        Location = 0x930E,

        /// <summary>
        /// Original was GL_LOCATION_INDEX = 0x930F
        /// </summary>
        LocationIndex = 0x930F
    }
}
