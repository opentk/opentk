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
    /// Used in GL.ARB.GetnPixelMap and GL.GetnPixelMap.
    /// </summary>
    public enum PixelMap
    {
        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_I = 0xC70
        /// </summary>
        PixelMapIToI = 0xC70,

        /// <summary>
        /// Original was GL_PIXEL_MAP_S_TO_S = 0xC71
        /// </summary>
        PixelMapSToS = 0xC71,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_R = 0xC72
        /// </summary>
        PixelMapIToR = 0xC72,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_G = 0xC73
        /// </summary>
        PixelMapIToG = 0xC73,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_B = 0xC74
        /// </summary>
        PixelMapIToB = 0xC74,

        /// <summary>
        /// Original was GL_PIXEL_MAP_I_TO_A = 0xC75
        /// </summary>
        PixelMapIToA = 0xC75,

        /// <summary>
        /// Original was GL_PIXEL_MAP_R_TO_R = 0xC76
        /// </summary>
        PixelMapRToR = 0xC76,

        /// <summary>
        /// Original was GL_PIXEL_MAP_G_TO_G = 0xC77
        /// </summary>
        PixelMapGToG = 0xC77,

        /// <summary>
        /// Original was GL_PIXEL_MAP_B_TO_B = 0xC78
        /// </summary>
        PixelMapBToB = 0xC78,

        /// <summary>
        /// Original was GL_PIXEL_MAP_A_TO_A = 0xC79
        /// </summary>
        PixelMapAToA = 0xC79
    }
}
