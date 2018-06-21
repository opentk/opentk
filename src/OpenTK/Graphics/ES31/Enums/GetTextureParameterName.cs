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
    public enum GetTextureParameterName
    {
        /// <summary>
        /// Original was GL_GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        GlTextureWidth = 0x1000,

        /// <summary>
        /// Original was GL_GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        GlTextureHeight = 0x1001,

        /// <summary>
        /// Original was GL_GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        GlTextureInternalFormat = 0x1003,

        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        GlTextureRedSize = 0x805c,

        /// <summary>
        /// Original was GL_GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        GlTextureGreenSize = 0x805d,

        /// <summary>
        /// Original was GL_GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        GlTextureBlueSize = 0x805e,

        /// <summary>
        /// Original was GL_GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        GlTextureAlphaSize = 0x805f,

        /// <summary>
        /// Original was GL_GL_TEXTURE_DEPTH = 0x8071
        /// </summary>
        GlTextureDepth = 0x8071,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = 0x8072,

        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = 0x8072,

        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = 0x813a,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = 0x813b,

        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = 0x813c,

        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = 0x813d,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF
        /// </summary>
        TextureImmutableLevels = 0x82df,

        /// <summary>
        /// Original was GL_GL_TEXTURE_COMPRESSED = 0x86A1
        /// </summary>
        GlTextureCompressed = 0x86a1,

        /// <summary>
        /// Original was GL_GL_TEXTURE_DEPTH_SIZE = 0x884A
        /// </summary>
        GlTextureDepthSize = 0x884a,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = 0x884c,

        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = 0x884d,

        /// <summary>
        /// Original was GL_GL_TEXTURE_STENCIL_SIZE = 0x88F1
        /// </summary>
        GlTextureStencilSize = 0x88f1,

        /// <summary>
        /// Original was GL_GL_TEXTURE_RED_TYPE = 0x8C10
        /// </summary>
        GlTextureRedType = 0x8c10,

        /// <summary>
        /// Original was GL_GL_TEXTURE_GREEN_TYPE = 0x8C11
        /// </summary>
        GlTextureGreenType = 0x8c11,

        /// <summary>
        /// Original was GL_GL_TEXTURE_BLUE_TYPE = 0x8C12
        /// </summary>
        GlTextureBlueType = 0x8c12,

        /// <summary>
        /// Original was GL_GL_TEXTURE_ALPHA_TYPE = 0x8C13
        /// </summary>
        GlTextureAlphaType = 0x8c13,

        /// <summary>
        /// Original was GL_GL_TEXTURE_DEPTH_TYPE = 0x8C16
        /// </summary>
        GlTextureDepthType = 0x8c16,

        /// <summary>
        /// Original was GL_GL_TEXTURE_SHARED_SIZE = 0x8C3F
        /// </summary>
        GlTextureSharedSize = 0x8c3f,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = 0x8e42,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = 0x8e43,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = 0x8e44,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = 0x8e45,

        /// <summary>
        /// Original was GL_GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        /// </summary>
        GlImageFormatCompatibilityType = 0x90c7,

        /// <summary>
        /// Original was GL_GL_TEXTURE_SAMPLES = 0x9106
        /// </summary>
        GlTextureSamples = 0x9106,

        /// <summary>
        /// Original was GL_GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107
        /// </summary>
        GlTextureFixedSampleLocations = 0x9107,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
        /// </summary>
        TextureImmutableFormat = 0x912f,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F
        /// </summary>
        TextureImmutableFormatExt = 0x912f
    }
}
