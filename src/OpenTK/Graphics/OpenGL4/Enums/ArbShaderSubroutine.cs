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
    public enum ArbShaderSubroutine
    {
        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = 0x8a38,

        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = 0x8a39,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        /// </summary>
        ActiveSubroutines = 0x8de5,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        /// </summary>
        ActiveSubroutineUniforms = 0x8de6,

        /// <summary>
        /// Original was GL_MAX_SUBROUTINES = 0x8DE7
        /// </summary>
        MaxSubroutines = 0x8de7,

        /// <summary>
        /// Original was GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8
        /// </summary>
        MaxSubroutineUniformLocations = 0x8de8,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        /// </summary>
        ActiveSubroutineUniformLocations = 0x8e47,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        /// </summary>
        ActiveSubroutineMaxLength = 0x8e48,

        /// <summary>
        /// Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        /// </summary>
        ActiveSubroutineUniformMaxLength = 0x8e49,

        /// <summary>
        /// Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        /// </summary>
        NumCompatibleSubroutines = 0x8e4a,

        /// <summary>
        /// Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        /// </summary>
        CompatibleSubroutines = 0x8e4b
    }
}
