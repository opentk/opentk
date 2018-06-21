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

namespace OpenTK.Graphics.ES31
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvConditionalRender
    {
        /// <summary>
        /// Original was GL_QUERY_WAIT_NV = 0x8E13
        /// </summary>
        QueryWaitNv = 0x8e13,

        /// <summary>
        /// Original was GL_QUERY_NO_WAIT_NV = 0x8E14
        /// </summary>
        QueryNoWaitNv = 0x8e14,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_WAIT_NV = 0x8E15
        /// </summary>
        QueryByRegionWaitNv = 0x8e15,

        /// <summary>
        /// Original was GL_QUERY_BY_REGION_NO_WAIT_NV = 0x8E16
        /// </summary>
        QueryByRegionNoWaitNv = 0x8e16
    }
}
