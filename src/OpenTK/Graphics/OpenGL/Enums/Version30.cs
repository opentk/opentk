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
    public enum Version30
    {
        /// <summary>
        /// Original was GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001
        /// </summary>
        ContextFlagForwardCompatibleBit = ((int)0x00000001),

        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        /// </summary>
        MapInvalidateRangeBit = 0x0004,

        /// <summary>
        /// Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        /// </summary>
        MapInvalidateBufferBit = 0x0008,

        /// <summary>
        /// Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        /// </summary>
        MapFlushExplicitBit = 0x0010,

        /// <summary>
        /// Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        /// </summary>
        MapUnsynchronizedBit = 0x0020,

        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = 0x0506,

        /// <summary>
        /// Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        /// </summary>
        MaxClipDistances = 0x0d32,

        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = 0x140b,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE0 = 0x3000
        /// </summary>
        ClipDistance0 = 0x3000,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE1 = 0x3001
        /// </summary>
        ClipDistance1 = 0x3001,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE2 = 0x3002
        /// </summary>
        ClipDistance2 = 0x3002,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE3 = 0x3003
        /// </summary>
        ClipDistance3 = 0x3003,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE4 = 0x3004
        /// </summary>
        ClipDistance4 = 0x3004,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE5 = 0x3005
        /// </summary>
        ClipDistance5 = 0x3005,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE6 = 0x3006
        /// </summary>
        ClipDistance6 = 0x3006,

        /// <summary>
        /// Original was GL_CLIP_DISTANCE7 = 0x3007
        /// </summary>
        ClipDistance7 = 0x3007,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncoding = 0x8210,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        /// </summary>
        FramebufferAttachmentComponentType = 0x8211,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        /// </summary>
        FramebufferAttachmentRedSize = 0x8212,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        /// </summary>
        FramebufferAttachmentGreenSize = 0x8213,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        /// </summary>
        FramebufferAttachmentBlueSize = 0x8214,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        /// </summary>
        FramebufferAttachmentAlphaSize = 0x8215,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        /// </summary>
        FramebufferAttachmentDepthSize = 0x8216,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        /// </summary>
        FramebufferAttachmentStencilSize = 0x8217,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_DEFAULT = 0x8218
        /// </summary>
        FramebufferDefault = 0x8218,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        /// </summary>
        FramebufferUndefined = 0x8219,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        /// </summary>
        DepthStencilAttachment = 0x821a,

        /// <summary>
        /// Original was GL_MAJOR_VERSION = 0x821B
        /// </summary>
        MajorVersion = 0x821b,

        /// <summary>
        /// Original was GL_MINOR_VERSION = 0x821C
        /// </summary>
        MinorVersion = 0x821c,

        /// <summary>
        /// Original was GL_NUM_EXTENSIONS = 0x821D
        /// </summary>
        NumExtensions = 0x821d,

        /// <summary>
        /// Original was GL_CONTEXT_FLAGS = 0x821E
        /// </summary>
        ContextFlags = 0x821e,

        /// <summary>
        /// Original was GL_INDEX = 0x8222
        /// </summary>
        Index = 0x8222,

        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = 0x8225,

        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = 0x8226,

        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = 0x8227,

        /// <summary>
        /// Original was GL_RG_INTEGER = 0x8228
        /// </summary>
        RgInteger = 0x8228,

        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = 0x8229,

        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = 0x822a,

        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = 0x822b,

        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = 0x822c,

        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = 0x822d,

        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = 0x822e,

        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = 0x822f,

        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = 0x8230,

        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = 0x8231,

        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = 0x8232,

        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = 0x8233,

        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = 0x8234,

        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = 0x8235,

        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = 0x8236,

        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = 0x8237,

        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = 0x8238,

        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = 0x8239,

        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = 0x823a,

        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = 0x823b,

        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = 0x823c,

        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE = 0x84E8
        /// </summary>
        MaxRenderbufferSize = 0x84e8,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = 0x84f9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8 = 0x84FA
        /// </summary>
        UnsignedInt248 = 0x84fa,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING = 0x85B5
        /// </summary>
        VertexArrayBinding = 0x85b5,

        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = 0x8814,

        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = 0x8815,

        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = 0x881a,

        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = 0x881b,

        /// <summary>
        /// Original was GL_COMPARE_REF_TO_TEXTURE = 0x884E
        /// </summary>
        CompareRefToTexture = 0x884e,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = 0x88f0,

        /// <summary>
        /// Original was GL_TEXTURE_STENCIL_SIZE = 0x88F1
        /// </summary>
        TextureStencilSize = 0x88f1,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        /// </summary>
        VertexAttribArrayInteger = 0x88fd,

        /// <summary>
        /// Original was GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF
        /// </summary>
        MaxArrayTextureLayers = 0x88ff,

        /// <summary>
        /// Original was GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904
        /// </summary>
        MinProgramTexelOffset = 0x8904,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905
        /// </summary>
        MaxProgramTexelOffset = 0x8905,

        /// <summary>
        /// Original was GL_CLAMP_VERTEX_COLOR = 0x891A
        /// </summary>
        ClampVertexColor = 0x891a,

        /// <summary>
        /// Original was GL_CLAMP_FRAGMENT_COLOR = 0x891B
        /// </summary>
        ClampFragmentColor = 0x891b,

        /// <summary>
        /// Original was GL_CLAMP_READ_COLOR = 0x891C
        /// </summary>
        ClampReadColor = 0x891c,

        /// <summary>
        /// Original was GL_FIXED_ONLY = 0x891D
        /// </summary>
        FixedOnly = 0x891d,

        /// <summary>
        /// Original was GL_MAX_VARYING_COMPONENTS = 0x8B4B
        /// </summary>
        MaxVaryingComponents = 0x8b4b,

        /// <summary>
        /// Original was GL_TEXTURE_RED_TYPE = 0x8C10
        /// </summary>
        TextureRedType = 0x8c10,

        /// <summary>
        /// Original was GL_TEXTURE_GREEN_TYPE = 0x8C11
        /// </summary>
        TextureGreenType = 0x8c11,

        /// <summary>
        /// Original was GL_TEXTURE_BLUE_TYPE = 0x8C12
        /// </summary>
        TextureBlueType = 0x8c12,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_TYPE = 0x8C13
        /// </summary>
        TextureAlphaType = 0x8c13,

        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_TYPE = 0x8C14
        /// </summary>
        TextureLuminanceType = 0x8c14,

        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_TYPE = 0x8C15
        /// </summary>
        TextureIntensityType = 0x8c15,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_TYPE = 0x8C16
        /// </summary>
        TextureDepthType = 0x8c16,

        /// <summary>
        /// Original was GL_UNSIGNED_NORMALIZED = 0x8C17
        /// </summary>
        UnsignedNormalized = 0x8c17,

        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = 0x8c18,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
        /// </summary>
        ProxyTexture1DArray = 0x8c19,

        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = 0x8c1a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
        /// </summary>
        ProxyTexture2DArray = 0x8c1b,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C
        /// </summary>
        TextureBinding1DArray = 0x8c1c,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        /// </summary>
        TextureBinding2DArray = 0x8c1d,

        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = 0x8c3a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = 0x8c3b,

        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = 0x8c3d,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
        /// </summary>
        UnsignedInt5999Rev = 0x8c3e,

        /// <summary>
        /// Original was GL_TEXTURE_SHARED_SIZE = 0x8C3F
        /// </summary>
        TextureSharedSize = 0x8c3f,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = 0x8c76,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = 0x8c7f,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
        /// </summary>
        MaxTransformFeedbackSeparateComponents = 0x8c80,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = 0x8c83,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = 0x8c84,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = 0x8c85,

        /// <summary>
        /// Original was GL_PRIMITIVES_GENERATED = 0x8C87
        /// </summary>
        PrimitivesGenerated = 0x8c87,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = 0x8c88,

        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD = 0x8C89
        /// </summary>
        RasterizerDiscard = 0x8c89,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A
        /// </summary>
        MaxTransformFeedbackInterleavedComponents = 0x8c8a,

        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B
        /// </summary>
        MaxTransformFeedbackSeparateAttribs = 0x8c8b,

        /// <summary>
        /// Original was GL_INTERLEAVED_ATTRIBS = 0x8C8C
        /// </summary>
        InterleavedAttribs = 0x8c8c,

        /// <summary>
        /// Original was GL_SEPARATE_ATTRIBS = 0x8C8D
        /// </summary>
        SeparateAttribs = 0x8c8d,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = 0x8c8f,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6
        /// </summary>
        DrawFramebufferBinding = 0x8ca6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING = 0x8CA6
        /// </summary>
        FramebufferBinding = 0x8ca6,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING = 0x8CA7
        /// </summary>
        RenderbufferBinding = 0x8ca7,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = 0x8ca8,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = 0x8ca9,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
        /// </summary>
        ReadFramebufferBinding = 0x8caa,

        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        /// </summary>
        RenderbufferSamples = 0x8cab,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = 0x8cac,

        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = 0x8cad,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectType = 0x8cd0,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = 0x8cd1,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = 0x8cd2,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = 0x8cd3,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = 0x8cd4,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = 0x8cd5,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = 0x8cd6,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = 0x8cd7,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBuffer = 0x8cdb,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBuffer = 0x8cdc,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = 0x8cdd,

        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = 0x8cdf,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = 0x8ce0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = 0x8ce1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = 0x8ce2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = 0x8ce3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = 0x8ce4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = 0x8ce5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = 0x8ce6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = 0x8ce7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = 0x8ce8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = 0x8ce9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = 0x8cea,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = 0x8ceb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = 0x8cec,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = 0x8ced,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = 0x8cee,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = 0x8cef,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = 0x8cf0,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = 0x8cf1,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = 0x8cf2,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = 0x8cf3,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = 0x8cf4,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = 0x8cf5,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = 0x8cf6,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = 0x8cf7,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = 0x8cf8,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = 0x8cf9,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = 0x8cfa,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = 0x8cfb,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = 0x8cfc,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = 0x8cfd,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = 0x8cfe,

        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = 0x8cff,

        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = 0x8d00,

        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT = 0x8D20
        /// </summary>
        StencilAttachment = 0x8d20,

        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = 0x8d40,

        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = 0x8d41,

        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = 0x8d42,

        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = 0x8d43,

        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = 0x8d44,

        /// <summary>
        /// Original was GL_STENCIL_INDEX1 = 0x8D46
        /// </summary>
        StencilIndex1 = 0x8d46,

        /// <summary>
        /// Original was GL_STENCIL_INDEX4 = 0x8D47
        /// </summary>
        StencilIndex4 = 0x8d47,

        /// <summary>
        /// Original was GL_STENCIL_INDEX8 = 0x8D48
        /// </summary>
        StencilIndex8 = 0x8d48,

        /// <summary>
        /// Original was GL_STENCIL_INDEX16 = 0x8D49
        /// </summary>
        StencilIndex16 = 0x8d49,

        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = 0x8d50,

        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = 0x8d51,

        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = 0x8d52,

        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = 0x8d53,

        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = 0x8d54,

        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = 0x8d55,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisample = 0x8d56,

        /// <summary>
        /// Original was GL_MAX_SAMPLES = 0x8D57
        /// </summary>
        MaxSamples = 0x8d57,

        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = 0x8d70,

        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = 0x8d71,

        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = 0x8d76,

        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = 0x8d77,

        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = 0x8d7c,

        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = 0x8d7d,

        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = 0x8d82,

        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = 0x8d83,

        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = 0x8d88,

        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = 0x8d89,

        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = 0x8d8e,

        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = 0x8d8f,

        /// <summary>
        /// Original was GL_RED_INTEGER = 0x8D94
        /// </summary>
        RedInteger = 0x8d94,

        /// <summary>
        /// Original was GL_GREEN_INTEGER = 0x8D95
        /// </summary>
        GreenInteger = 0x8d95,

        /// <summary>
        /// Original was GL_BLUE_INTEGER = 0x8D96
        /// </summary>
        BlueInteger = 0x8d96,

        /// <summary>
        /// Original was GL_ALPHA_INTEGER = 0x8D97
        /// </summary>
        AlphaInteger = 0x8d97,

        /// <summary>
        /// Original was GL_RGB_INTEGER = 0x8D98
        /// </summary>
        RgbInteger = 0x8d98,

        /// <summary>
        /// Original was GL_RGBA_INTEGER = 0x8D99
        /// </summary>
        RgbaInteger = 0x8d99,

        /// <summary>
        /// Original was GL_BGR_INTEGER = 0x8D9A
        /// </summary>
        BgrInteger = 0x8d9a,

        /// <summary>
        /// Original was GL_BGRA_INTEGER = 0x8D9B
        /// </summary>
        BgraInteger = 0x8d9b,

        /// <summary>
        /// Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        /// </summary>
        Float32UnsignedInt248Rev = 0x8dad,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_SRGB = 0x8DB9
        /// </summary>
        FramebufferSrgb = 0x8db9,

        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = 0x8dbb,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = 0x8dbc,

        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = 0x8dbd,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = 0x8dbe,

        /// <summary>
        /// Original was GL_SAMPLER_1D_ARRAY = 0x8DC0
        /// </summary>
        Sampler1DArray = 0x8dc0,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARRAY = 0x8DC1
        /// </summary>
        Sampler2DArray = 0x8dc1,

        /// <summary>
        /// Original was GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3
        /// </summary>
        Sampler1DArrayShadow = 0x8dc3,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4
        /// </summary>
        Sampler2DArrayShadow = 0x8dc4,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_SHADOW = 0x8DC5
        /// </summary>
        SamplerCubeShadow = 0x8dc5,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        /// </summary>
        UnsignedIntVec2 = 0x8dc6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        /// </summary>
        UnsignedIntVec3 = 0x8dc7,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        /// </summary>
        UnsignedIntVec4 = 0x8dc8,

        /// <summary>
        /// Original was GL_INT_SAMPLER_1D = 0x8DC9
        /// </summary>
        IntSampler1D = 0x8dc9,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D = 0x8DCA
        /// </summary>
        IntSampler2D = 0x8dca,

        /// <summary>
        /// Original was GL_INT_SAMPLER_3D = 0x8DCB
        /// </summary>
        IntSampler3D = 0x8dcb,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE = 0x8DCC
        /// </summary>
        IntSamplerCube = 0x8dcc,

        /// <summary>
        /// Original was GL_INT_SAMPLER_1D_ARRAY = 0x8DCE
        /// </summary>
        IntSampler1DArray = 0x8dce,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
        /// </summary>
        IntSampler2DArray = 0x8dcf,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1
        /// </summary>
        UnsignedIntSampler1D = 0x8dd1,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2
        /// </summary>
        UnsignedIntSampler2D = 0x8dd2,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3
        /// </summary>
        UnsignedIntSampler3D = 0x8dd3,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
        /// </summary>
        UnsignedIntSamplerCube = 0x8dd4,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6
        /// </summary>
        UnsignedIntSampler1DArray = 0x8dd6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
        /// </summary>
        UnsignedIntSampler2DArray = 0x8dd7,

        /// <summary>
        /// Original was GL_QUERY_WAIT = 0x8E13
        /// </summary>
        QueryWait = 0x8e13,

        /// <summary>
        /// Original was GL_QUERY_NO_WAIT = 0x8E14
        /// </summary>
        QueryNoWait = 0x8e14,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        /// </summary>
        QueryByRegionWait = 0x8e15,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        /// </summary>
        QueryByRegionNoWait = 0x8e16,

        /// <summary>
        /// Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        /// </summary>
        BufferAccessFlags = 0x911f,

        /// <summary>
        /// Original was GL_BUFFER_MAP_LENGTH = 0x9120
        /// </summary>
        BufferMapLength = 0x9120,

        /// <summary>
        /// Original was GL_BUFFER_MAP_OFFSET = 0x9121
        /// </summary>
        BufferMapOffset = 0x9121
    }
}
