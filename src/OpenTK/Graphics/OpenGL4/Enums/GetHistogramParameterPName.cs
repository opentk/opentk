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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetHistogramParameterPName
    {
        /// <summary>
        /// Original was GL_HISTOGRAM_WIDTH = 0x8026
        /// </summary>
        HistogramWidth = 0x8026,

        /// <summary>
        /// Original was GL_HISTOGRAM_FORMAT = 0x8027
        /// </summary>
        HistogramFormat = 0x8027,

        /// <summary>
        /// Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        /// </summary>
        HistogramRedSize = 0x8028,

        /// <summary>
        /// Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        /// </summary>
        HistogramGreenSize = 0x8029,

        /// <summary>
        /// Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        /// </summary>
        HistogramBlueSize = 0x802a,

        /// <summary>
        /// Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        /// </summary>
        HistogramAlphaSize = 0x802b,

        /// <summary>
        /// Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        /// </summary>
        HistogramLuminanceSize = 0x802c,

        /// <summary>
        /// Original was GL_HISTOGRAM_SINK = 0x802D
        /// </summary>
        HistogramSink = 0x802d
    }
}
