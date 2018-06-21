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
    /// Used in GL.Amd.DeleteNames, GL.Amd.GenNames and 1 other function
    /// </summary>
    public enum AmdNameGenDelete
    {
        /// <summary>
        /// Original was GL_DATA_BUFFER_AMD = 0x9151
        /// </summary>
        DataBufferAmd = 0x9151,

        /// <summary>
        /// Original was GL_PERFORMANCE_MONITOR_AMD = 0x9152
        /// </summary>
        PerformanceMonitorAmd = 0x9152,

        /// <summary>
        /// Original was GL_QUERY_OBJECT_AMD = 0x9153
        /// </summary>
        QueryObjectAmd = 0x9153,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_OBJECT_AMD = 0x9154
        /// </summary>
        VertexArrayObjectAmd = 0x9154,

        /// <summary>
        /// Original was GL_SAMPLER_OBJECT_AMD = 0x9155
        /// </summary>
        SamplerObjectAmd = 0x9155
    }
}
