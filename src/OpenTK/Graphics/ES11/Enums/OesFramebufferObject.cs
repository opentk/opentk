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
    public enum OesFramebufferObject
    {
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = 0,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = 0x0506,

        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = 0x8057,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = 0x81a5,

        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = 0x84e8,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = 0x8ca6,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = 0x8ca7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = 0x8cd0,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = 0x8cd9,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = 0x8cda,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = 0x8cdd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = 0x8ce0,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = 0x8d00,

        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = 0x8d20,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = 0x8d41,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = 0x8d44,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = 0x8d55,

        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = 0x8d62
    }
}
