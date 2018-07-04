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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.NV.ViewportSwizzle
    /// </summary>
    public enum NvViewportSwizzle
    {
        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350
        /// </summary>
        ViewportSwizzlePositiveXNv = 0x9350,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351
        /// </summary>
        ViewportSwizzleNegativeXNv = 0x9351,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352
        /// </summary>
        ViewportSwizzlePositiveYNv = 0x9352,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353
        /// </summary>
        ViewportSwizzleNegativeYNv = 0x9353,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354
        /// </summary>
        ViewportSwizzlePositiveZNv = 0x9354,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355
        /// </summary>
        ViewportSwizzleNegativeZNv = 0x9355,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356
        /// </summary>
        ViewportSwizzlePositiveWNv = 0x9356,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357
        /// </summary>
        ViewportSwizzleNegativeWNv = 0x9357,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_X_NV = 0x9358
        /// </summary>
        ViewportSwizzleXNv = 0x9358,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_Y_NV = 0x9359
        /// </summary>
        ViewportSwizzleYNv = 0x9359,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_Z_NV = 0x935A
        /// </summary>
        ViewportSwizzleZNv = 0x935a,

        /// <summary>
        /// Original was GL_VIEWPORT_SWIZZLE_W_NV = 0x935B
        /// </summary>
        ViewportSwizzleWNv = 0x935b
    }
}
