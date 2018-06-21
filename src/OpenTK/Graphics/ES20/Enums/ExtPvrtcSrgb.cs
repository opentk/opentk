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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPvrtcSrgb
    {
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT = 0x8A54
        /// </summary>
        CompressedSrgbPvrtc2Bppv1Ext = 0x8a54,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT = 0x8A55
        /// </summary>
        CompressedSrgbPvrtc4Bppv1Ext = 0x8a55,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT = 0x8A56
        /// </summary>
        CompressedSrgbAlphaPvrtc2Bppv1Ext = 0x8a56,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT = 0x8A57
        /// </summary>
        CompressedSrgbAlphaPvrtc4Bppv1Ext = 0x8a57,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG = 0x93F0
        /// </summary>
        CompressedSrgbAlphaPvrtc2Bppv2Img = 0x93f0,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG = 0x93F1
        /// </summary>
        CompressedSrgbAlphaPvrtc4Bppv2Img = 0x93f1
    }
}
