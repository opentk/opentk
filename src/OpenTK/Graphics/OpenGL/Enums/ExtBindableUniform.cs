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
    public enum ExtBindableUniform
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2
        /// </summary>
        MaxVertexBindableUniformsExt = 0x8de2,

        /// <summary>
        /// Original was GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3
        /// </summary>
        MaxFragmentBindableUniformsExt = 0x8de3,

        /// <summary>
        /// Original was GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4
        /// </summary>
        MaxGeometryBindableUniformsExt = 0x8de4,

        /// <summary>
        /// Original was GL_MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED
        /// </summary>
        MaxBindableUniformSizeExt = 0x8ded,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_EXT = 0x8DEE
        /// </summary>
        UniformBufferExt = 0x8dee,

        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_BINDING_EXT = 0x8DEF
        /// </summary>
        UniformBufferBindingExt = 0x8def
    }
}
