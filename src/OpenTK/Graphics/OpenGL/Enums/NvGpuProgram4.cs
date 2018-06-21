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
    /// Used in GL.NV.GetProgramEnvParameterI, GL.NV.GetProgramLocalParameterI and 4 other functions
    /// </summary>
    public enum NvGpuProgram4
    {
        /// <summary>
        /// Original was GL_MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904
        /// </summary>
        MinProgramTexelOffsetNv = 0x8904,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905
        /// </summary>
        MaxProgramTexelOffsetNv = 0x8905,

        /// <summary>
        /// Original was GL_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906
        /// </summary>
        ProgramAttribComponentsNv = 0x8906,

        /// <summary>
        /// Original was GL_PROGRAM_RESULT_COMPONENTS_NV = 0x8907
        /// </summary>
        ProgramResultComponentsNv = 0x8907,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908
        /// </summary>
        MaxProgramAttribComponentsNv = 0x8908,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909
        /// </summary>
        MaxProgramResultComponentsNv = 0x8909,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5
        /// </summary>
        MaxProgramGenericAttribsNv = 0x8da5,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6
        /// </summary>
        MaxProgramGenericResultsNv = 0x8da6
    }
}
