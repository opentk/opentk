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

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesBlendFuncSeparate
    {
        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = 0x80c8,

        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = 0x80c9,

        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = 0x80ca,

        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = 0x80cb
    }
}
