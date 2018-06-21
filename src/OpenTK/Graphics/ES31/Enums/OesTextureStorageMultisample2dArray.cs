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
    public enum OesTextureStorageMultisample2dArray
    {
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES = 0x9102
        /// </summary>
        Texture2DMultisampleArrayOes = 0x9102,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES = 0x9105
        /// </summary>
        TextureBinding2DMultisampleArrayOes = 0x9105,

        /// <summary>
        /// Original was GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910B
        /// </summary>
        Sampler2DMultisampleArrayOes = 0x910b,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910C
        /// </summary>
        IntSampler2DMultisampleArrayOes = 0x910c,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910D
        /// </summary>
        UnsignedIntSampler2DMultisampleArrayOes = 0x910d
    }
}
