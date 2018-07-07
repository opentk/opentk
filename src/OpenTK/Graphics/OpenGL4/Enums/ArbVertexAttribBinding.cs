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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexAttribBinding
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_BINDING = 0x82D4
        /// </summary>
        VertexAttribBinding = 0x82d4,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        /// </summary>
        VertexAttribRelativeOffset = 0x82d5,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_DIVISOR = 0x82D6
        /// </summary>
        VertexBindingDivisor = 0x82d6,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_OFFSET = 0x82D7
        /// </summary>
        VertexBindingOffset = 0x82d7,

        /// <summary>
        /// Original was GL_VERTEX_BINDING_STRIDE = 0x82D8
        /// </summary>
        VertexBindingStride = 0x82d8,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9
        /// </summary>
        MaxVertexAttribRelativeOffset = 0x82d9,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA
        /// </summary>
        MaxVertexAttribBindings = 0x82da
    }
}
