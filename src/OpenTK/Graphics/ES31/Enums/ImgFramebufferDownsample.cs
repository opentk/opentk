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

namespace OpenTK.Graphics.ES31
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgFramebufferDownsample
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG = 0x913C
        /// </summary>
        FramebufferIncompleteMultisampleAndDownsampleImg = 0x913c,

        /// <summary>
        /// Original was GL_NUM_DOWNSAMPLE_SCALES_IMG = 0x913D
        /// </summary>
        NumDownsampleScalesImg = 0x913d,

        /// <summary>
        /// Original was GL_DOWNSAMPLE_SCALES_IMG = 0x913E
        /// </summary>
        DownsampleScalesImg = 0x913e,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG = 0x913F
        /// </summary>
        FramebufferAttachmentTextureScaleImg = 0x913f
    }
}
