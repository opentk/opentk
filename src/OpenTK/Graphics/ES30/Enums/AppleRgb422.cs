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
    public enum AppleRgb422
    {
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA
        /// </summary>
        UnsignedShort88Apple = 0x85ba,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB
        /// </summary>
        UnsignedShort88RevApple = 0x85bb,

        /// <summary>
        /// Original was GL_RGB_422_APPLE = 0x8A1F
        /// </summary>
        Rgb422Apple = 0x8a1f,

        /// <summary>
        /// Original was GL_RGB_RAW_422_APPLE = 0x8A51
        /// </summary>
        RgbRaw422Apple = 0x8a51
    }
}
