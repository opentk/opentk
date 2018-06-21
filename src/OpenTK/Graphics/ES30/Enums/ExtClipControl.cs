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
    /// Used in GL.Ext.ClipControl
    /// </summary>
    public enum ExtClipControl
    {
        /// <summary>
        /// Original was GL_LOWER_LEFT_EXT = 0x8CA1
        /// </summary>
        LowerLeftExt = 0x8ca1,

        /// <summary>
        /// Original was GL_UPPER_LEFT_EXT = 0x8CA2
        /// </summary>
        UpperLeftExt = 0x8ca2,

        /// <summary>
        /// Original was GL_CLIP_ORIGIN_EXT = 0x935C
        /// </summary>
        ClipOriginExt = 0x935c,

        /// <summary>
        /// Original was GL_CLIP_DEPTH_MODE_EXT = 0x935D
        /// </summary>
        ClipDepthModeExt = 0x935d,

        /// <summary>
        /// Original was GL_NEGATIVE_ONE_TO_ONE_EXT = 0x935E
        /// </summary>
        NegativeOneToOneExt = 0x935e,

        /// <summary>
        /// Original was GL_ZERO_TO_ONE_EXT = 0x935F
        /// </summary>
        ZeroToOneExt = 0x935f
    }
}
