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
    /// Used in GL.NV.ConservativeRasterParameter.
    /// </summary>
    public enum NvConservativeRasterDilate
    {
        /// <summary>
        /// Original was GL_CONSERVATIVE_RASTER_DILATE_NV = 0x9379
        /// </summary>
        ConservativeRasterDilateNv = 0x9379,

        /// <summary>
        /// Original was GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A
        /// </summary>
        ConservativeRasterDilateRangeNv = 0x937a,

        /// <summary>
        /// Original was GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B
        /// </summary>
        ConservativeRasterDilateGranularityNv = 0x937b
    }
}
