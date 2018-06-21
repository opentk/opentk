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
    public enum IntelParallelArrays
    {
        /// <summary>
        /// Original was GL_PARALLEL_ARRAYS_INTEL = 0x83F4
        /// </summary>
        ParallelArraysIntel = 0x83f4,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5
        /// </summary>
        VertexArrayParallelPointersIntel = 0x83f5,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6
        /// </summary>
        NormalArrayParallelPointersIntel = 0x83f6,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7
        /// </summary>
        ColorArrayParallelPointersIntel = 0x83f7,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8
        /// </summary>
        TextureCoordArrayParallelPointersIntel = 0x83f8
    }
}
