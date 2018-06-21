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
    /// Used in GL.NV.GetProgramSubroutineParameter, GL.NV.ProgramSubroutineParameters
    /// </summary>
    public enum NvGpuProgram5
    {
        /// <summary>
        /// Original was GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A
        /// </summary>
        MaxGeometryProgramInvocationsNv = 0x8e5a,

        /// <summary>
        /// Original was GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B
        /// </summary>
        MinFragmentInterpolationOffsetNv = 0x8e5b,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C
        /// </summary>
        MaxFragmentInterpolationOffsetNv = 0x8e5c,

        /// <summary>
        /// Original was GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D
        /// </summary>
        FragmentProgramInterpolationOffsetBitsNv = 0x8e5d,

        /// <summary>
        /// Original was GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E
        /// </summary>
        MinProgramTextureGatherOffsetNv = 0x8e5e,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F
        /// </summary>
        MaxProgramTextureGatherOffsetNv = 0x8e5f,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44
        /// </summary>
        MaxProgramSubroutineParametersNv = 0x8f44,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45
        /// </summary>
        MaxProgramSubroutineNumNv = 0x8f45
    }
}
