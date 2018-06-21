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
    /// Not used directly.
    /// </summary>
    public enum ExtTextureCubeMapArray
    {
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        /// </summary>
        TextureCubeMapArrayExt = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A
        /// </summary>
        TextureBindingCubeMapArrayExt = 0x900a,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C
        /// </summary>
        SamplerCubeMapArrayExt = 0x900c,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D
        /// </summary>
        SamplerCubeMapArrayShadowExt = 0x900d,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E
        /// </summary>
        IntSamplerCubeMapArrayExt = 0x900e,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F
        /// </summary>
        UnsignedIntSamplerCubeMapArrayExt = 0x900f,

        /// <summary>
        /// Original was GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054
        /// </summary>
        ImageCubeMapArrayExt = 0x9054,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F
        /// </summary>
        IntImageCubeMapArrayExt = 0x905f,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A
        /// </summary>
        UnsignedIntImageCubeMapArrayExt = 0x906a
    }
}
