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
    public enum ExtFramebufferObject
    {
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        /// </summary>
        InvalidFramebufferOperationExt = 0x0506,

        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_EXT = 0x84E8
        /// </summary>
        MaxRenderbufferSizeExt = 0x84e8,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_EXT = 0x8CA6
        /// </summary>
        FramebufferBindingExt = 0x8ca6,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_EXT = 0x8CA7
        /// </summary>
        RenderbufferBindingExt = 0x8ca7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeExt = 0x8cd0,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameExt = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelExt = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceExt = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4
        /// </summary>
        FramebufferAttachmentTexture3DZoffsetExt = 0x8cd4,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_EXT = 0x8CD5
        /// </summary>
        FramebufferCompleteExt = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentExt = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentExt = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsExt = 0x8cd9,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsExt = 0x8cda,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBufferExt = 0x8cdb,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBufferExt = 0x8cdc,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD
        /// </summary>
        FramebufferUnsupportedExt = 0x8cdd,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        /// </summary>
        MaxColorAttachmentsExt = 0x8cdf,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        /// </summary>
        ColorAttachment0Ext = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        /// </summary>
        ColorAttachment1Ext = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        /// </summary>
        ColorAttachment2Ext = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        /// </summary>
        ColorAttachment3Ext = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        /// </summary>
        ColorAttachment4Ext = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        /// </summary>
        ColorAttachment5Ext = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        /// </summary>
        ColorAttachment6Ext = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        /// </summary>
        ColorAttachment7Ext = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        /// </summary>
        ColorAttachment8Ext = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        /// </summary>
        ColorAttachment9Ext = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        /// </summary>
        ColorAttachment10Ext = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        /// </summary>
        ColorAttachment11Ext = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        /// </summary>
        ColorAttachment12Ext = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        /// </summary>
        ColorAttachment13Ext = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        /// </summary>
        ColorAttachment14Ext = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        /// </summary>
        ColorAttachment15Ext = 0x8cef,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        /// </summary>
        DepthAttachmentExt = 0x8d00,

        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_EXT = 0x8D20
        /// </summary>
        StencilAttachmentExt = 0x8d20,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_EXT = 0x8D40
        /// </summary>
        FramebufferExt = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER_EXT = 0x8D41
        /// </summary>
        RenderbufferExt = 0x8d41,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_EXT = 0x8D42
        /// </summary>
        RenderbufferWidthExt = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_EXT = 0x8D43
        /// </summary>
        RenderbufferHeightExt = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44
        /// </summary>
        RenderbufferInternalFormatExt = 0x8d44,

        /// <summary>
        /// Original was GL_STENCIL_INDEX1_EXT = 0x8D46
        /// </summary>
        StencilIndex1Ext = 0x8d46,

        /// <summary>
        /// Original was GL_STENCIL_INDEX4_EXT = 0x8D47
        /// </summary>
        StencilIndex4Ext = 0x8d47,

        /// <summary>
        /// Original was GL_STENCIL_INDEX8_EXT = 0x8D48
        /// </summary>
        StencilIndex8Ext = 0x8d48,

        /// <summary>
        /// Original was GL_STENCIL_INDEX16_EXT = 0x8D49
        /// </summary>
        StencilIndex16Ext = 0x8d49,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_EXT = 0x8D50
        /// </summary>
        RenderbufferRedSizeExt = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51
        /// </summary>
        RenderbufferGreenSizeExt = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52
        /// </summary>
        RenderbufferBlueSizeExt = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeExt = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54
        /// </summary>
        RenderbufferDepthSizeExt = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55
        /// </summary>
        RenderbufferStencilSizeExt = 0x8d55
    }
}
