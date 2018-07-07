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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureCubeMapArray
    {
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        /// </summary>
        TextureCubeMapArrayArb = 0x9009,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A
        /// </summary>
        TextureBindingCubeMapArrayArb = 0x900a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        /// </summary>
        ProxyTextureCubeMapArrayArb = 0x900b,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C
        /// </summary>
        SamplerCubeMapArrayArb = 0x900c,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D
        /// </summary>
        SamplerCubeMapArrayShadowArb = 0x900d,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E
        /// </summary>
        IntSamplerCubeMapArrayArb = 0x900e,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F
        /// </summary>
        UnsignedIntSamplerCubeMapArrayArb = 0x900f
    }
}
