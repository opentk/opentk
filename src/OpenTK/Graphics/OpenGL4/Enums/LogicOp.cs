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
    /// Used in GL.LogicOp.
    /// </summary>
    public enum LogicOp
    {
        /// <summary>
        /// Original was GL_CLEAR = 0x1500
        /// </summary>
        Clear = 0x1500,

        /// <summary>
        /// Original was GL_AND = 0x1501
        /// </summary>
        And = 0x1501,

        /// <summary>
        /// Original was GL_AND_REVERSE = 0x1502
        /// </summary>
        AndReverse = 0x1502,

        /// <summary>
        /// Original was GL_COPY = 0x1503
        /// </summary>
        Copy = 0x1503,

        /// <summary>
        /// Original was GL_AND_INVERTED = 0x1504
        /// </summary>
        AndInverted = 0x1504,

        /// <summary>
        /// Original was GL_NOOP = 0x1505
        /// </summary>
        Noop = 0x1505,

        /// <summary>
        /// Original was GL_XOR = 0x1506
        /// </summary>
        Xor = 0x1506,

        /// <summary>
        /// Original was GL_OR = 0x1507
        /// </summary>
        Or = 0x1507,

        /// <summary>
        /// Original was GL_NOR = 0x1508
        /// </summary>
        Nor = 0x1508,

        /// <summary>
        /// Original was GL_EQUIV = 0x1509
        /// </summary>
        Equiv = 0x1509,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_OR_REVERSE = 0x150B
        /// </summary>
        OrReverse = 0x150b,

        /// <summary>
        /// Original was GL_COPY_INVERTED = 0x150C
        /// </summary>
        CopyInverted = 0x150c,

        /// <summary>
        /// Original was GL_OR_INVERTED = 0x150D
        /// </summary>
        OrInverted = 0x150d,

        /// <summary>
        /// Original was GL_NAND = 0x150E
        /// </summary>
        Nand = 0x150e,

        /// <summary>
        /// Original was GL_SET = 0x150F
        /// </summary>
        Set = 0x150f
    }
}
