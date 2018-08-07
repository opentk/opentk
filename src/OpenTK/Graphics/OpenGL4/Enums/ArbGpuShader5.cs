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
    public enum ArbGpuShader5
    {
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        /// </summary>
        GeometryShaderInvocations = 0x887F,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A
        /// </summary>
        MaxGeometryShaderInvocations = 0x8E5A,

        /// <summary>
        /// Original was GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B
        /// </summary>
        MinFragmentInterpolationOffset = 0x8E5B,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C
        /// </summary>
        MaxFragmentInterpolationOffset = 0x8E5C,

        /// <summary>
        /// Original was GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D
        /// </summary>
        FragmentInterpolationOffsetBits = 0x8E5D,

        /// <summary>
        /// Original was GL_MAX_VERTEX_STREAMS = 0x8E71
        /// </summary>
        MaxVertexStreams = 0x8E71
    }
}
