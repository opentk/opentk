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
    /// Not used directly.
    /// </summary>
    public enum FragmentOpATI
    {
        /// <summary>
        /// Original was GL_MOV_ATI = 0x8961
        /// </summary>
        MovAti = 0x8961,

        /// <summary>
        /// Original was GL_ADD_ATI = 0x8963
        /// </summary>
        AddAti = 0x8963,

        /// <summary>
        /// Original was GL_MUL_ATI = 0x8964
        /// </summary>
        MulAti = 0x8964,

        /// <summary>
        /// Original was GL_SUB_ATI = 0x8965
        /// </summary>
        SubAti = 0x8965,

        /// <summary>
        /// Original was GL_DOT3_ATI = 0x8966
        /// </summary>
        Dot3Ati = 0x8966,

        /// <summary>
        /// Original was GL_DOT4_ATI = 0x8967
        /// </summary>
        Dot4Ati = 0x8967,

        /// <summary>
        /// Original was GL_MAD_ATI = 0x8968
        /// </summary>
        MadAti = 0x8968,

        /// <summary>
        /// Original was GL_LERP_ATI = 0x8969
        /// </summary>
        LerpAti = 0x8969,

        /// <summary>
        /// Original was GL_CND_ATI = 0x896A
        /// </summary>
        CndAti = 0x896a,

        /// <summary>
        /// Original was GL_CND0_ATI = 0x896B
        /// </summary>
        Cnd0Ati = 0x896b,

        /// <summary>
        /// Original was GL_DOT2_ADD_ATI = 0x896C
        /// </summary>
        Dot2AddAti = 0x896c
    }
}
