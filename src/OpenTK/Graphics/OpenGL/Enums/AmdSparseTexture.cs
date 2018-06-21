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
    /// Used in GL.Amd.TextureStorageSparse
    /// </summary>
    public enum AmdSparseTexture
    {
        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001
        /// </summary>
        TextureStorageSparseBitAmd = ((int)0x00000001),

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_X_AMD = 0x9195
        /// </summary>
        VirtualPageSizeXAmd = 0x9195,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196
        /// </summary>
        VirtualPageSizeYAmd = 0x9196,

        /// <summary>
        /// Original was GL_VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197
        /// </summary>
        VirtualPageSizeZAmd = 0x9197,

        /// <summary>
        /// Original was GL_MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198
        /// </summary>
        MaxSparseTextureSizeAmd = 0x9198,

        /// <summary>
        /// Original was GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199
        /// </summary>
        MaxSparse3DTextureSizeAmd = 0x9199,

        /// <summary>
        /// Original was GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A
        /// </summary>
        MaxSparseArrayTextureLayers = 0x919a,

        /// <summary>
        /// Original was GL_MIN_SPARSE_LEVEL_AMD = 0x919B
        /// </summary>
        MinSparseLevelAmd = 0x919b,

        /// <summary>
        /// Original was GL_MIN_LOD_WARNING_AMD = 0x919C
        /// </summary>
        MinLodWarningAmd = 0x919c
    }
}
