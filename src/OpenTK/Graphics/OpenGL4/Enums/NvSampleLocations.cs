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
    public enum NvSampleLocations
    {
        /// <summary>
        /// Original was GL_SAMPLE_LOCATION_NV = 0x8E50
        /// </summary>
        SampleLocationNv = 0x8e50,

        /// <summary>
        /// Original was GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D
        /// </summary>
        SampleLocationSubpixelBitsNv = 0x933d,

        /// <summary>
        /// Original was GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E
        /// </summary>
        SampleLocationPixelGridWidthNv = 0x933e,

        /// <summary>
        /// Original was GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F
        /// </summary>
        SampleLocationPixelGridHeightNv = 0x933f,

        /// <summary>
        /// Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340
        /// </summary>
        ProgrammableSampleLocationTableSizeNv = 0x9340,

        /// <summary>
        /// Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341
        /// </summary>
        ProgrammableSampleLocationNv = 0x9341,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342
        /// </summary>
        FramebufferProgrammableSampleLocationsNv = 0x9342,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343
        /// </summary>
        FramebufferSampleLocationPixelGridNv = 0x9343
    }
}
