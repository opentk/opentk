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
    public enum NvInternalformatSampleQuery
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = 0x8d41,

        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = 0x9100,

        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = 0x9102,

        /// <summary>
        /// Original was GL_MULTISAMPLES_NV = 0x9371
        /// </summary>
        MultisamplesNv = 0x9371,

        /// <summary>
        /// Original was GL_SUPERSAMPLE_SCALE_X_NV = 0x9372
        /// </summary>
        SupersampleScaleXNv = 0x9372,

        /// <summary>
        /// Original was GL_SUPERSAMPLE_SCALE_Y_NV = 0x9373
        /// </summary>
        SupersampleScaleYNv = 0x9373,

        /// <summary>
        /// Original was GL_CONFORMANT_NV = 0x9374
        /// </summary>
        ConformantNv = 0x9374
    }
}
