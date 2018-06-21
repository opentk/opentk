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
    public enum ImgTextureEnvEnhancedFixedFunction
    {
        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = 0x86af,

        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = 0x8c04,

        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = 0x8c05,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = 0x8c06,

        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = 0x8c07,

        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = 0x8c08,

        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = 0x8c09
    }
}
