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
    public enum ExtTextureArray
    {
        /// <summary>
        /// Original was GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E
        /// </summary>
        CompareRefDepthToTextureExt = 0x884e,

        /// <summary>
        /// Original was GL_MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF
        /// </summary>
        MaxArrayTextureLayersExt = 0x88ff,

        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY_EXT = 0x8C18
        /// </summary>
        Texture1DArrayExt = 0x8c18,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
        /// </summary>
        ProxyTexture1DArrayExt = 0x8c19,

        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY_EXT = 0x8C1A
        /// </summary>
        Texture2DArrayExt = 0x8c1a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
        /// </summary>
        ProxyTexture2DArrayExt = 0x8c1b,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C
        /// </summary>
        TextureBinding1DArrayExt = 0x8c1c,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D
        /// </summary>
        TextureBinding2DArrayExt = 0x8c1d,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayerExt = 0x8cd4
    }
}
