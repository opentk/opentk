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
    /// Not used directly.
    /// </summary>
    public enum NvPolygonMode
    {
        /// <summary>
        /// Original was GL_POLYGON_MODE_NV = 0x0B40
        /// </summary>
        PolygonModeNv = 0x0b40,

        /// <summary>
        /// Original was GL_POINT_NV = 0x1B00
        /// </summary>
        PointNv = 0x1b00,

        /// <summary>
        /// Original was GL_LINE_NV = 0x1B01
        /// </summary>
        LineNv = 0x1b01,

        /// <summary>
        /// Original was GL_FILL_NV = 0x1B02
        /// </summary>
        FillNv = 0x1b02,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT_NV = 0x2A01
        /// </summary>
        PolygonOffsetPointNv = 0x2a01,

        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE_NV = 0x2A02
        /// </summary>
        PolygonOffsetLineNv = 0x2a02
    }
}
