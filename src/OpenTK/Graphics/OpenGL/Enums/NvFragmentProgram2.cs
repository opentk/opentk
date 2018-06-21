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
    public enum NvFragmentProgram2
    {
        /// <summary>
        /// Original was GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4
        /// </summary>
        MaxProgramExecInstructionsNv = 0x88f4,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5
        /// </summary>
        MaxProgramCallDepthNv = 0x88f5,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_IF_DEPTH_NV = 0x88F6
        /// </summary>
        MaxProgramIfDepthNv = 0x88f6,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7
        /// </summary>
        MaxProgramLoopDepthNv = 0x88f7,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8
        /// </summary>
        MaxProgramLoopCountNv = 0x88f8
    }
}
