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
    public enum QcomTextureFoveated
    {
        /// <summary>
        /// Original was GL_FOVEATION_ENABLE_BIT_QCOM = 0x00000001
        /// </summary>
        FoveationEnableBitQcom = ((int)0x00000001),

        /// <summary>
        /// Original was GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002
        /// </summary>
        FoveationScaledBinMethodBitQcom = ((int)0x00000002),

        /// <summary>
        /// Original was GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM = 0x8BFB
        /// </summary>
        TextureFoveatedFeatureBitsQcom = 0x8bfb,

        /// <summary>
        /// Original was GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM = 0x8BFC
        /// </summary>
        TextureFoveatedMinPixelDensityQcom = 0x8bfc,

        /// <summary>
        /// Original was GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM = 0x8BFD
        /// </summary>
        TextureFoveatedFeatureQueryQcom = 0x8bfd,

        /// <summary>
        /// Original was GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM = 0x8BFE
        /// </summary>
        TextureFoveatedNumFocalPointsQueryQcom = 0x8bfe,

        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM = 0x8BFF
        /// </summary>
        FramebufferIncompleteFoveationQcom = 0x8bff
    }
}
