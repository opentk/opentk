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
    public enum ExtFogCoord
    {
        /// <summary>
        /// Original was GL_FOG_COORDINATE_SOURCE_EXT = 0x8450
        /// </summary>
        FogCoordinateSourceExt = 0x8450,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_EXT = 0x8451
        /// </summary>
        FogCoordinateExt = 0x8451,

        /// <summary>
        /// Original was GL_FRAGMENT_DEPTH_EXT = 0x8452
        /// </summary>
        FragmentDepthExt = 0x8452,

        /// <summary>
        /// Original was GL_CURRENT_FOG_COORDINATE_EXT = 0x8453
        /// </summary>
        CurrentFogCoordinateExt = 0x8453,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454
        /// </summary>
        FogCoordinateArrayTypeExt = 0x8454,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455
        /// </summary>
        FogCoordinateArrayStrideExt = 0x8455,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456
        /// </summary>
        FogCoordinateArrayPointerExt = 0x8456,

        /// <summary>
        /// Original was GL_FOG_COORDINATE_ARRAY_EXT = 0x8457
        /// </summary>
        FogCoordinateArrayExt = 0x8457
    }
}
