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
    /// Not used directly.
    /// </summary>
    public enum ExtCoordinateFrame
    {
        /// <summary>
        /// Original was GL_TANGENT_ARRAY_EXT = 0x8439
        /// </summary>
        TangentArrayExt = 0x8439,

        /// <summary>
        /// Original was GL_BINORMAL_ARRAY_EXT = 0x843A
        /// </summary>
        BinormalArrayExt = 0x843a,

        /// <summary>
        /// Original was GL_CURRENT_TANGENT_EXT = 0x843B
        /// </summary>
        CurrentTangentExt = 0x843b,

        /// <summary>
        /// Original was GL_CURRENT_BINORMAL_EXT = 0x843C
        /// </summary>
        CurrentBinormalExt = 0x843c,

        /// <summary>
        /// Original was GL_TANGENT_ARRAY_TYPE_EXT = 0x843E
        /// </summary>
        TangentArrayTypeExt = 0x843e,

        /// <summary>
        /// Original was GL_TANGENT_ARRAY_STRIDE_EXT = 0x843F
        /// </summary>
        TangentArrayStrideExt = 0x843f,

        /// <summary>
        /// Original was GL_BINORMAL_ARRAY_TYPE_EXT = 0x8440
        /// </summary>
        BinormalArrayTypeExt = 0x8440,

        /// <summary>
        /// Original was GL_BINORMAL_ARRAY_STRIDE_EXT = 0x8441
        /// </summary>
        BinormalArrayStrideExt = 0x8441,

        /// <summary>
        /// Original was GL_TANGENT_ARRAY_POINTER_EXT = 0x8442
        /// </summary>
        TangentArrayPointerExt = 0x8442,

        /// <summary>
        /// Original was GL_BINORMAL_ARRAY_POINTER_EXT = 0x8443
        /// </summary>
        BinormalArrayPointerExt = 0x8443,

        /// <summary>
        /// Original was GL_MAP1_TANGENT_EXT = 0x8444
        /// </summary>
        Map1TangentExt = 0x8444,

        /// <summary>
        /// Original was GL_MAP2_TANGENT_EXT = 0x8445
        /// </summary>
        Map2TangentExt = 0x8445,

        /// <summary>
        /// Original was GL_MAP1_BINORMAL_EXT = 0x8446
        /// </summary>
        Map1BinormalExt = 0x8446,

        /// <summary>
        /// Original was GL_MAP2_BINORMAL_EXT = 0x8447
        /// </summary>
        Map2BinormalExt = 0x8447
    }
}
