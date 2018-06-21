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
    /// Used in GL.NV.FlushPixelDataRange, GL.NV.PixelDataRange
    /// </summary>
    public enum NvPixelDataRange
    {
        /// <summary>
        /// Original was GL_WRITE_PIXEL_DATA_RANGE_NV = 0x8878
        /// </summary>
        WritePixelDataRangeNv = 0x8878,

        /// <summary>
        /// Original was GL_READ_PIXEL_DATA_RANGE_NV = 0x8879
        /// </summary>
        ReadPixelDataRangeNv = 0x8879,

        /// <summary>
        /// Original was GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A
        /// </summary>
        WritePixelDataRangeLengthNv = 0x887a,

        /// <summary>
        /// Original was GL_READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B
        /// </summary>
        ReadPixelDataRangeLengthNv = 0x887b,

        /// <summary>
        /// Original was GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C
        /// </summary>
        WritePixelDataRangePointerNv = 0x887c,

        /// <summary>
        /// Original was GL_READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D
        /// </summary>
        ReadPixelDataRangePointerNv = 0x887d
    }
}
