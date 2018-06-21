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
    public enum S3S3tc
    {
        /// <summary>
        /// Original was GL_RGB_S3TC = 0x83A0
        /// </summary>
        RgbS3tc = 0x83a0,

        /// <summary>
        /// Original was GL_RGB4_S3TC = 0x83A1
        /// </summary>
        Rgb4S3tc = 0x83a1,

        /// <summary>
        /// Original was GL_RGBA_S3TC = 0x83A2
        /// </summary>
        RgbaS3tc = 0x83a2,

        /// <summary>
        /// Original was GL_RGBA4_S3TC = 0x83A3
        /// </summary>
        Rgba4S3tc = 0x83a3,

        /// <summary>
        /// Original was GL_RGBA_DXT5_S3TC = 0x83A4
        /// </summary>
        RgbaDxt5S3tc = 0x83a4,

        /// <summary>
        /// Original was GL_RGBA4_DXT5_S3TC = 0x83A5
        /// </summary>
        Rgba4Dxt5S3tc = 0x83a5
    }
}
