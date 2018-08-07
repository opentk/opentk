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
    /// Used in GL.ProgramParameter.
    /// </summary>
    public enum AssemblyProgramParameterArb
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = 0x8257,

        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = 0x8258,

        /// <summary>
        /// Original was GL_PROGRAM_LENGTH = 0x8627
        /// </summary>
        ProgramLength = 0x8627,

        /// <summary>
        /// Original was GL_PROGRAM_BINDING = 0x8677
        /// </summary>
        ProgramBinding = 0x8677,

        /// <summary>
        /// Original was GL_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805
        /// </summary>
        ProgramAluInstructionsArb = 0x8805,

        /// <summary>
        /// Original was GL_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806
        /// </summary>
        ProgramTexInstructionsArb = 0x8806,

        /// <summary>
        /// Original was GL_PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807
        /// </summary>
        ProgramTexIndirectionsArb = 0x8807,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808
        /// </summary>
        ProgramNativeAluInstructionsArb = 0x8808,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809
        /// </summary>
        ProgramNativeTexInstructionsArb = 0x8809,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A
        /// </summary>
        ProgramNativeTexIndirectionsArb = 0x880A,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B
        /// </summary>
        MaxProgramAluInstructionsArb = 0x880B,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C
        /// </summary>
        MaxProgramTexInstructionsArb = 0x880C,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D
        /// </summary>
        MaxProgramTexIndirectionsArb = 0x880D,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E
        /// </summary>
        MaxProgramNativeAluInstructionsArb = 0x880E,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F
        /// </summary>
        MaxProgramNativeTexInstructionsArb = 0x880F,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810
        /// </summary>
        MaxProgramNativeTexIndirectionsArb = 0x8810,

        /// <summary>
        /// Original was GL_PROGRAM_FORMAT = 0x8876
        /// </summary>
        ProgramFormat = 0x8876,

        /// <summary>
        /// Original was GL_PROGRAM_INSTRUCTION = 0x88A0
        /// </summary>
        ProgramInstruction = 0x88A0,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_INSTRUCTIONS = 0x88A1
        /// </summary>
        MaxProgramInstructions = 0x88A1,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_INSTRUCTIONS = 0x88A2
        /// </summary>
        ProgramNativeInstructions = 0x88A2,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS = 0x88A3
        /// </summary>
        MaxProgramNativeInstructions = 0x88A3,

        /// <summary>
        /// Original was GL_PROGRAM_TEMPORARIES = 0x88A4
        /// </summary>
        ProgramTemporaries = 0x88A4,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEMPORARIES = 0x88A5
        /// </summary>
        MaxProgramTemporaries = 0x88A5,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_TEMPORARIES = 0x88A6
        /// </summary>
        ProgramNativeTemporaries = 0x88A6,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_TEMPORARIES = 0x88A7
        /// </summary>
        MaxProgramNativeTemporaries = 0x88A7,

        /// <summary>
        /// Original was GL_PROGRAM_PARAMETERS = 0x88A8
        /// </summary>
        ProgramParameters = 0x88A8,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_PARAMETERS = 0x88A9
        /// </summary>
        MaxProgramParameters = 0x88A9,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_PARAMETERS = 0x88AA
        /// </summary>
        ProgramNativeParameters = 0x88AA,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_PARAMETERS = 0x88AB
        /// </summary>
        MaxProgramNativeParameters = 0x88AB,

        /// <summary>
        /// Original was GL_PROGRAM_ATTRIBS = 0x88AC
        /// </summary>
        ProgramAttribs = 0x88AC,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ATTRIBS = 0x88AD
        /// </summary>
        MaxProgramAttribs = 0x88AD,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_ATTRIBS = 0x88AE
        /// </summary>
        ProgramNativeAttribs = 0x88AE,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_ATTRIBS = 0x88AF
        /// </summary>
        MaxProgramNativeAttribs = 0x88AF,

        /// <summary>
        /// Original was GL_PROGRAM_ADDRESS_REGISTERS = 0x88B0
        /// </summary>
        ProgramAddressRegisters = 0x88B0,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ADDRESS_REGISTERS = 0x88B1
        /// </summary>
        MaxProgramAddressRegisters = 0x88B1,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_ADDRESS_REGISTERS = 0x88B2
        /// </summary>
        ProgramNativeAddressRegisters = 0x88B2,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS = 0x88B3
        /// </summary>
        MaxProgramNativeAddressRegisters = 0x88B3,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_LOCAL_PARAMETERS = 0x88B4
        /// </summary>
        MaxProgramLocalParameters = 0x88B4,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ENV_PARAMETERS = 0x88B5
        /// </summary>
        MaxProgramEnvParameters = 0x88B5,

        /// <summary>
        /// Original was GL_PROGRAM_UNDER_NATIVE_LIMITS = 0x88B6
        /// </summary>
        ProgramUnderNativeLimits = 0x88B6,

        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        /// </summary>
        GeometryVerticesOut = 0x8916,

        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        /// </summary>
        GeometryInputType = 0x8917,

        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        /// </summary>
        GeometryOutputType = 0x8918
    }
}
