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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Used in GL.NV.CoverageOperation
    /// </summary>
    public enum NvCoverageSample
    {
        /// <summary>
        /// Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
        /// </summary>
        CoverageBufferBitNv = ((int)0x00008000),

        /// <summary>
        /// Original was GL_COVERAGE_COMPONENT_NV = 0x8ED0
        /// </summary>
        CoverageComponentNv = 0x8ed0,

        /// <summary>
        /// Original was GL_COVERAGE_COMPONENT4_NV = 0x8ED1
        /// </summary>
        CoverageComponent4Nv = 0x8ed1,

        /// <summary>
        /// Original was GL_COVERAGE_ATTACHMENT_NV = 0x8ED2
        /// </summary>
        CoverageAttachmentNv = 0x8ed2,

        /// <summary>
        /// Original was GL_COVERAGE_BUFFERS_NV = 0x8ED3
        /// </summary>
        CoverageBuffersNv = 0x8ed3,

        /// <summary>
        /// Original was GL_COVERAGE_SAMPLES_NV = 0x8ED4
        /// </summary>
        CoverageSamplesNv = 0x8ed4,

        /// <summary>
        /// Original was GL_COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5
        /// </summary>
        CoverageAllFragmentsNv = 0x8ed5,

        /// <summary>
        /// Original was GL_COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6
        /// </summary>
        CoverageEdgeFragmentsNv = 0x8ed6,

        /// <summary>
        /// Original was GL_COVERAGE_AUTOMATIC_NV = 0x8ED7
        /// </summary>
        CoverageAutomaticNv = 0x8ed7
    }
}
