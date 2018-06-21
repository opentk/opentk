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
    /// Used in GL.Ext.SignalSemaphore, GL.Ext.WaitSemaphore
    /// </summary>
    public enum TextureLayout
    {
        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530
        /// </summary>
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531
        /// </summary>
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,

        /// <summary>
        /// Original was GL_LAYOUT_GENERAL_EXT = 0x958D
        /// </summary>
        LayoutGeneralExt = 0x958d,

        /// <summary>
        /// Original was GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E
        /// </summary>
        LayoutColorAttachmentExt = 0x958e,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F
        /// </summary>
        LayoutDepthStencilAttachmentExt = 0x958f,

        /// <summary>
        /// Original was GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590
        /// </summary>
        LayoutDepthStencilReadOnlyExt = 0x9590,

        /// <summary>
        /// Original was GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591
        /// </summary>
        LayoutShaderReadOnlyExt = 0x9591,

        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592
        /// </summary>
        LayoutTransferSrcExt = 0x9592,

        /// <summary>
        /// Original was GL_LAYOUT_TRANSFER_DST_EXT = 0x9593
        /// </summary>
        LayoutTransferDstExt = 0x9593
    }
}
