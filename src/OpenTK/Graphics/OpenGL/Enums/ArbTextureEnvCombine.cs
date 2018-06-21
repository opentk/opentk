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
    public enum ArbTextureEnvCombine
    {
        /// <summary>
        /// Original was GL_SUBTRACT_ARB = 0x84E7
        /// </summary>
        SubtractArb = 0x84e7,

        /// <summary>
        /// Original was GL_COMBINE_ARB = 0x8570
        /// </summary>
        CombineArb = 0x8570,

        /// <summary>
        /// Original was GL_COMBINE_RGB_ARB = 0x8571
        /// </summary>
        CombineRgbArb = 0x8571,

        /// <summary>
        /// Original was GL_COMBINE_ALPHA_ARB = 0x8572
        /// </summary>
        CombineAlphaArb = 0x8572,

        /// <summary>
        /// Original was GL_RGB_SCALE_ARB = 0x8573
        /// </summary>
        RgbScaleArb = 0x8573,

        /// <summary>
        /// Original was GL_ADD_SIGNED_ARB = 0x8574
        /// </summary>
        AddSignedArb = 0x8574,

        /// <summary>
        /// Original was GL_INTERPOLATE_ARB = 0x8575
        /// </summary>
        InterpolateArb = 0x8575,

        /// <summary>
        /// Original was GL_CONSTANT_ARB = 0x8576
        /// </summary>
        ConstantArb = 0x8576,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR_ARB = 0x8577
        /// </summary>
        PrimaryColorArb = 0x8577,

        /// <summary>
        /// Original was GL_PREVIOUS_ARB = 0x8578
        /// </summary>
        PreviousArb = 0x8578,

        /// <summary>
        /// Original was GL_SOURCE0_RGB_ARB = 0x8580
        /// </summary>
        Source0RgbArb = 0x8580,

        /// <summary>
        /// Original was GL_SOURCE1_RGB_ARB = 0x8581
        /// </summary>
        Source1RgbArb = 0x8581,

        /// <summary>
        /// Original was GL_SOURCE2_RGB_ARB = 0x8582
        /// </summary>
        Source2RgbArb = 0x8582,

        /// <summary>
        /// Original was GL_SOURCE0_ALPHA_ARB = 0x8588
        /// </summary>
        Source0AlphaArb = 0x8588,

        /// <summary>
        /// Original was GL_SOURCE1_ALPHA_ARB = 0x8589
        /// </summary>
        Source1AlphaArb = 0x8589,

        /// <summary>
        /// Original was GL_SOURCE2_ALPHA_ARB = 0x858A
        /// </summary>
        Source2AlphaArb = 0x858a,

        /// <summary>
        /// Original was GL_OPERAND0_RGB_ARB = 0x8590
        /// </summary>
        Operand0RgbArb = 0x8590,

        /// <summary>
        /// Original was GL_OPERAND1_RGB_ARB = 0x8591
        /// </summary>
        Operand1RgbArb = 0x8591,

        /// <summary>
        /// Original was GL_OPERAND2_RGB_ARB = 0x8592
        /// </summary>
        Operand2RgbArb = 0x8592,

        /// <summary>
        /// Original was GL_OPERAND0_ALPHA_ARB = 0x8598
        /// </summary>
        Operand0AlphaArb = 0x8598,

        /// <summary>
        /// Original was GL_OPERAND1_ALPHA_ARB = 0x8599
        /// </summary>
        Operand1AlphaArb = 0x8599,

        /// <summary>
        /// Original was GL_OPERAND2_ALPHA_ARB = 0x859A
        /// </summary>
        Operand2AlphaArb = 0x859a
    }
}
