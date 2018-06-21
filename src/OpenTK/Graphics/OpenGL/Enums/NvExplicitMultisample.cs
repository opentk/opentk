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
    /// Used in GL.NV.GetMultisample
    /// </summary>
    public enum NvExplicitMultisample
    {
        /// <summary>
        /// Original was GL_SAMPLE_POSITION_NV = 0x8E50
        /// </summary>
        SamplePositionNv = 0x8e50,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_NV = 0x8E51
        /// </summary>
        SampleMaskNv = 0x8e51,

        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_NV = 0x8E52
        /// </summary>
        SampleMaskValueNv = 0x8e52,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53
        /// </summary>
        TextureBindingRenderbufferNv = 0x8e53,

        /// <summary>
        /// Original was GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54
        /// </summary>
        TextureRenderbufferDataStoreBindingNv = 0x8e54,

        /// <summary>
        /// Original was GL_TEXTURE_RENDERBUFFER_NV = 0x8E55
        /// </summary>
        TextureRenderbufferNv = 0x8e55,

        /// <summary>
        /// Original was GL_SAMPLER_RENDERBUFFER_NV = 0x8E56
        /// </summary>
        SamplerRenderbufferNv = 0x8e56,

        /// <summary>
        /// Original was GL_INT_SAMPLER_RENDERBUFFER_NV = 0x8E57
        /// </summary>
        IntSamplerRenderbufferNv = 0x8e57,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58
        /// </summary>
        UnsignedIntSamplerRenderbufferNv = 0x8e58,

        /// <summary>
        /// Original was GL_MAX_SAMPLE_MASK_WORDS_NV = 0x8E59
        /// </summary>
        MaxSampleMaskWordsNv = 0x8e59
    }
}
