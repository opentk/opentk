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

namespace OpenTK.Graphics.ES30
{
    /// <summary>
    /// Used in GL.Ext.TexPageCommitment
    /// </summary>
    public enum ExtSparseTexture
    {
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = 0x0de1,

        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = 0x806f,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = 0x8513,

        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = 0x8c1a,

        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        /// </summary>
        TextureCubeMapArrayOes = 0x9009,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_X_EXT = 0x9195
        /// </summary>
        VirtualPageSizeXExt = 0x9195,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196
        /// </summary>
        VirtualPageSizeYExt = 0x9196,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197
        /// </summary>
        VirtualPageSizeZExt = 0x9197,

        /// <summary>
        /// Original was GL_MAX_SPARSE_TEXTURE_SIZE_EXT = 0x9198
        /// </summary>
        MaxSparseTextureSizeExt = 0x9198,

        /// <summary>
        /// Original was GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT = 0x9199
        /// </summary>
        MaxSparse3DTextureSizeExt = 0x9199,

        /// <summary>
        /// Original was GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT = 0x919A
        /// </summary>
        MaxSparseArrayTextureLayersExt = 0x919a,

        /// <summary>
        /// Original was GL_TEXTURE_SPARSE_EXT = 0x91A6
        /// </summary>
        TextureSparseExt = 0x91a6,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_INDEX_EXT = 0x91A7
        /// </summary>
        VirtualPageSizeIndexExt = 0x91a7,

        /// <summary>
        /// Original was GL_NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8
        /// </summary>
        NumVirtualPageSizesExt = 0x91a8,

        /// <summary>
        /// Original was GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT = 0x91A9
        /// </summary>
        SparseTextureFullArrayCubeMipmapsExt = 0x91a9,

        /// <summary>
        /// Original was GL_NUM_SPARSE_LEVELS_EXT = 0x91AA
        /// </summary>
        NumSparseLevelsExt = 0x91aa
    }
}
