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
    /// Used in GL.Arb.MatrixIndexPointer
    /// </summary>
    public enum ArbMatrixPalette
    {
        /// <summary>
        /// Original was GL_MATRIX_PALETTE_ARB = 0x8840
        /// </summary>
        MatrixPaletteArb = 0x8840,

        /// <summary>
        /// Original was GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841
        /// </summary>
        MaxMatrixPaletteStackDepthArb = 0x8841,

        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_ARB = 0x8842
        /// </summary>
        MaxPaletteMatricesArb = 0x8842,

        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843
        /// </summary>
        CurrentPaletteMatrixArb = 0x8843,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_ARB = 0x8844
        /// </summary>
        MatrixIndexArrayArb = 0x8844,

        /// <summary>
        /// Original was GL_CURRENT_MATRIX_INDEX_ARB = 0x8845
        /// </summary>
        CurrentMatrixIndexArb = 0x8845,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846
        /// </summary>
        MatrixIndexArraySizeArb = 0x8846,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847
        /// </summary>
        MatrixIndexArrayTypeArb = 0x8847,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848
        /// </summary>
        MatrixIndexArrayStrideArb = 0x8848,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849
        /// </summary>
        MatrixIndexArrayPointerArb = 0x8849
    }
}
