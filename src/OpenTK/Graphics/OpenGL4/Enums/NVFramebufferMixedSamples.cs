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
    public enum NVFramebufferMixedSamples
    {
        /// <summary>
        /// Original was GL_COLOR_SAMPLES_NV = 0x8E20
        /// </summary>
        ColorSamplesNV = 0x8e20,

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
        EffectiveRasterSamplesExt = 0x932c,

        /// <summary>
        /// Original was GL_DEPTH_SAMPLES_NV = 0x932D
        /// </summary>
        DepthSamplesNV = 0x932d,

        /// <summary>
        /// Original was GL_STENCIL_SAMPLES_NV = 0x932E
        /// </summary>
        StencilSamplesNV = 0x932e,

        /// <summary>
        /// Original was GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F
        /// </summary>
        MixedDepthSamplesSupportedNV = 0x932f,

        /// <summary>
        /// Original was GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330
        /// </summary>
        MixedStencilSamplesSupportedNV = 0x9330,

        /// <summary>
        /// Original was GL_COVERAGE_MODULATION_TABLE_NV = 0x9331
        /// </summary>
        CoverageModulationTableNV = 0x9331,

        /// <summary>
        /// Original was GL_COVERAGE_MODULATION_NV = 0x9332
        /// </summary>
        CoverageModulationNV = 0x9332,

        /// <summary>
        /// Original was GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333
        /// </summary>
        CoverageModulationTableSizeNV = 0x9333
    }
}
