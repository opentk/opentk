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
    /// Used in GL.Oes.MatrixIndexPointer, GL.Oes.WeightPointer
    /// </summary>
    public enum OesMatrixPalette
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = 0x86a4,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = 0x86a9,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = 0x86aa,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = 0x86ab,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = 0x86ac,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = 0x86ad,

        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = 0x8840,

        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = 0x8842,

        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = 0x8843,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = 0x8844,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = 0x8846,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = 0x8847,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = 0x8848,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = 0x8849,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = 0x889e,

        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = 0x8b9e
    }
}
