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
    /// Not used directly.
    /// </summary>
    public enum SamplerParameter
    {
        /// <summary>
        /// Original was GL_TextureBorderColor = 0x1004
        /// </summary>
        TextureBorderColor = 0x1004,

        /// <summary>
        /// Original was GL_TextureMagFilter = 0x2800
        /// </summary>
        TextureMagFilter = 0x2800,

        /// <summary>
        /// Original was GL_TextureMinFilter = 0x2801
        /// </summary>
        TextureMinFilter = 0x2801,

        /// <summary>
        /// Original was GL_TextureWrapS = 0x2802
        /// </summary>
        TextureWrapS = 0x2802,

        /// <summary>
        /// Original was GL_TextureWrapT = 0x2803
        /// </summary>
        TextureWrapT = 0x2803,

        /// <summary>
        /// Original was GL_TextureWrapR = 0x8072
        /// </summary>
        TextureWrapR = 0x8072,

        /// <summary>
        /// Original was GL_TextureMinLod = 0x813A
        /// </summary>
        TextureMinLod = 0x813a,

        /// <summary>
        /// Original was GL_TextureMaxLod = 0x813B
        /// </summary>
        TextureMaxLod = 0x813b,

        /// <summary>
        /// Original was GL_TextureMaxAnisotropyExt = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = 0x84fe,

        /// <summary>
        /// Original was GL_TextureLodBias = 0x8501
        /// </summary>
        TextureLodBias = 0x8501,

        /// <summary>
        /// Original was GL_TextureCompareMode = 0x884C
        /// </summary>
        TextureCompareMode = 0x884c,

        /// <summary>
        /// Original was GL_TextureCompareFunc = 0x884D
        /// </summary>
        TextureCompareFunc = 0x884d
    }
}
