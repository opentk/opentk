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
    public enum OesTextureCubeMap
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = 0x2500,

        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = 0x8511,

        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = 0x8512,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = 0x8514,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = 0x8515,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = 0x8516,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = 0x8517,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = 0x8518,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = 0x8519,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = 0x851a,

        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = 0x851c,

        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = 0x8d60
    }
}
