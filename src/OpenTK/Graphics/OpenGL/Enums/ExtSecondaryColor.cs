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
    public enum ExtSecondaryColor
    {
        /// <summary>
        /// Original was GL_COLOR_SUM_EXT = 0x8458
        /// </summary>
        ColorSumExt = 0x8458,

        /// <summary>
        /// Original was GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459
        /// </summary>
        CurrentSecondaryColorExt = 0x8459,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A
        /// </summary>
        SecondaryColorArraySizeExt = 0x845a,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B
        /// </summary>
        SecondaryColorArrayTypeExt = 0x845b,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C
        /// </summary>
        SecondaryColorArrayStrideExt = 0x845c,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D
        /// </summary>
        SecondaryColorArrayPointerExt = 0x845d,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E
        /// </summary>
        SecondaryColorArrayExt = 0x845e
    }
}
