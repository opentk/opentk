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
    public enum MesaTileRasterOrder
    {
        /// <summary>
        /// Original was GL_TILE_RASTER_ORDER_FIXED_MESA = 0x8BB8
        /// </summary>
        TileRasterOrderFixedMesa = 0x8bb8,

        /// <summary>
        /// Original was GL_TILE_RASTER_ORDER_INCREASING_X_MESA = 0x8BB9
        /// </summary>
        TileRasterOrderIncreasingXMesa = 0x8bb9,

        /// <summary>
        /// Original was GL_TILE_RASTER_ORDER_INCREASING_Y_MESA = 0x8BBA
        /// </summary>
        TileRasterOrderIncreasingYMesa = 0x8bba
    }
}
