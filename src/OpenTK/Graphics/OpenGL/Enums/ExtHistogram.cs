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
    public enum ExtHistogram
    {
        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = 0x8024,

        /// <summary>
        /// Original was GL_PROXY_HISTOGRAM_EXT = 0x8025
        /// </summary>
        ProxyHistogramExt = 0x8025,

        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH_EXT = 0x8026
        /// </summary>
        HistogramWidthExt = 0x8026,

        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT_EXT = 0x8027
        /// </summary>
        HistogramFormatExt = 0x8027,

        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
        /// </summary>
        HistogramRedSizeExt = 0x8028,

        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
        /// </summary>
        HistogramGreenSizeExt = 0x8029,

        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
        /// </summary>
        HistogramBlueSizeExt = 0x802a,

        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
        /// </summary>
        HistogramAlphaSizeExt = 0x802b,

        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
        /// </summary>
        HistogramLuminanceSizeExt = 0x802c,

        /// <summary>
        /// Original was GL_HISTOGRAM_SINK_EXT = 0x802D
        /// </summary>
        HistogramSinkExt = 0x802d,

        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = 0x802e,

        /// <summary>
        /// Original was GL_MINMAX_FORMAT_EXT = 0x802F
        /// </summary>
        MinmaxFormatExt = 0x802f,

        /// <summary>
        /// Original was GL_MINMAX_SINK_EXT = 0x8030
        /// </summary>
        MinmaxSinkExt = 0x8030,

        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        /// </summary>
        TableTooLargeExt = 0x8031
    }
}
