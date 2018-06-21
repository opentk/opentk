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
    /// Used in GL.NV.ProgramBufferParameters, GL.NV.ProgramBufferParametersI
    /// </summary>
    public enum NvParameterBufferObject
    {
        /// <summary>
        /// Original was GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0
        /// </summary>
        MaxProgramParameterBufferBindingsNv = 0x8da0,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1
        /// </summary>
        MaxProgramParameterBufferSizeNv = 0x8da1,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2
        /// </summary>
        VertexProgramParameterBufferNv = 0x8da2,

        /// <summary>
        /// Original was GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3
        /// </summary>
        GeometryProgramParameterBufferNv = 0x8da3,

        /// <summary>
        /// Original was GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4
        /// </summary>
        FragmentProgramParameterBufferNv = 0x8da4
    }
}
