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

namespace OpenTK.Graphics.ES30
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtRasterMultisample
    {
        /// <summary>
        /// Original was GL_RASTER_MULTISAMPLE_EXT = 0x9327
        /// </summary>
        RasterMultisampleExt = 0x9327,

        /// <summary>
        /// Original was GL_RASTER_SAMPLES_EXT = 0x9328
        /// </summary>
        RasterSamplesExt = 0x9328,

        /// <summary>
        /// Original was GL_MAX_RASTER_SAMPLES_EXT = 0x9329
        /// </summary>
        MaxRasterSamplesExt = 0x9329,

        /// <summary>
        /// Original was GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A
        /// </summary>
        RasterFixedSampleLocationsExt = 0x932a,

        /// <summary>
        /// Original was GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B
        /// </summary>
        MultisampleRasterizationAllowedExt = 0x932b,

        /// <summary>
        /// Original was GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C
        /// </summary>
        EffectiveRasterSamplesExt = 0x932c
    }
}
