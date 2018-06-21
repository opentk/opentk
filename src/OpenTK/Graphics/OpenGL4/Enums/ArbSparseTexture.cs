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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.Arb.TexPageCommitment
    /// </summary>
    public enum ArbSparseTexture
    {
        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195
        /// </summary>
        VirtualPageSizeXArb = 0x9195,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196
        /// </summary>
        VirtualPageSizeYArb = 0x9196,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197
        /// </summary>
        VirtualPageSizeZArb = 0x9197,

        /// <summary>
        /// Original was GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198
        /// </summary>
        MaxSparseTextureSizeArb = 0x9198,

        /// <summary>
        /// Original was GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199
        /// </summary>
        MaxSparse3DTextureSizeArb = 0x9199,

        /// <summary>
        /// Original was GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A
        /// </summary>
        MaxSparseArrayTextureLayersArb = 0x919a,

        /// <summary>
        /// Original was GL_TEXTURE_SPARSE_ARB = 0x91A6
        /// </summary>
        TextureSparseArb = 0x91a6,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7
        /// </summary>
        VirtualPageSizeIndexArb = 0x91a7,

        /// <summary>
        /// Original was GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8
        /// </summary>
        NumVirtualPageSizesArb = 0x91a8,

        /// <summary>
        /// Original was GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9
        /// </summary>
        SparseTextureFullArrayCubeMipmapsArb = 0x91a9,

        /// <summary>
        /// Original was GL_NUM_SPARSE_LEVELS_ARB = 0x91AA
        /// </summary>
        NumSparseLevelsArb = 0x91aa
    }
}
