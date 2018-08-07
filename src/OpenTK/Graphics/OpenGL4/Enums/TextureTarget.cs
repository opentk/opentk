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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.EXT.GenerateMultiTexMipmap and GL.EXT.BindMultiTexture, as well as 96 other functions.
    /// </summary>
    public enum TextureTarget
    {
        /// <summary>
        /// Original was GL_TEXTURE1_D = 0xDE0
        /// </summary>
        Texture1D = 0xDE0,

        /// <summary>
        /// Original was GL_TEXTURE2_D = 0xDE1
        /// </summary>
        Texture2D = 0xDE1,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE1_D = 0x8063
        /// </summary>
        ProxyTexture1D = 0x8063,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE1_D_EXT = 0x8063
        /// </summary>
        ProxyTexture1DExt = 0x8063,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE2_D = 0x8064
        /// </summary>
        ProxyTexture2D = 0x8064,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE2_D_EXT = 0x8064
        /// </summary>
        ProxyTexture2DExt = 0x8064,

        /// <summary>
        /// Original was GL_TEXTURE3_D = 0x806F
        /// </summary>
        Texture3D = 0x806F,

        /// <summary>
        /// Original was GL_TEXTURE3_D_EXT = 0x806F
        /// </summary>
        Texture3DExt = 0x806F,

        /// <summary>
        /// Original was GL_TEXTURE3_D_OES = 0x806F
        /// </summary>
        Texture3DOes = 0x806F,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE3_D = 0x8070
        /// </summary>
        ProxyTexture3D = 0x8070,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE3_D_EXT = 0x8070
        /// </summary>
        ProxyTexture3DExt = 0x8070,

        /// <summary>
        /// Original was GL_DETAIL_TEXTURE2_D_SGIS = 0x8095
        /// </summary>
        DetailTexture2DSgis = 0x8095,

        /// <summary>
        /// Original was GL_TEXTURE4_D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = 0x8134,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE4_D_SGIS = 0x8135
        /// </summary>
        ProxyTexture4DSgis = 0x8135,

        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = 0x84F5,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
        /// </summary>
        ProxyTextureRectangle = 0x84F7,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
        /// </summary>
        ProxyTextureRectangleArb = 0x84F7,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
        /// </summary>
        ProxyTextureRectangleNV = 0x84F7,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = 0x851A,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        /// </summary>
        ProxyTextureCubeMap = 0x851B,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
        /// </summary>
        ProxyTextureCubeMapArb = 0x851B,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
        /// </summary>
        ProxyTextureCubeMapExt = 0x851B,

        /// <summary>
        /// Original was GL_TEXTURE1_D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = 0x8C18,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE1_D_ARRAY = 0x8C19
        /// </summary>
        ProxyTexture1DArray = 0x8C19,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE1_D_ARRAY_EXT = 0x8C19
        /// </summary>
        ProxyTexture1DArrayExt = 0x8C19,

        /// <summary>
        /// Original was GL_TEXTURE2_D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = 0x8C1A,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE2_D_ARRAY = 0x8C1B
        /// </summary>
        ProxyTexture2DArray = 0x8C1B,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE2_D_ARRAY_EXT = 0x8C1B
        /// </summary>
        ProxyTexture2DArrayExt = 0x8C1B,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        /// </summary>
        TextureCubeMapArrayArb = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        /// </summary>
        TextureCubeMapArrayExt = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        /// </summary>
        TextureCubeMapArrayOes = 0x9009,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        /// </summary>
        ProxyTextureCubeMapArray = 0x900B,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        /// </summary>
        ProxyTextureCubeMapArrayArb = 0x900B,

        /// <summary>
        /// Original was GL_TEXTURE2_D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = 0x9100,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE2_D_MULTISAMPLE = 0x9101
        /// </summary>
        ProxyTexture2DMultisample = 0x9101,

        /// <summary>
        /// Original was GL_TEXTURE2_D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = 0x9102,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE2_D_MULTISAMPLE_ARRAY = 0x9103
        /// </summary>
        ProxyTexture2DMultisampleArray = 0x9103
    }
}
