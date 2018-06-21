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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbComputeVariableGroupSize
    {
        /// <summary>
        /// Original was GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB
        /// </summary>
        MaxComputeFixedGroupInvocationsArb = 0x90eb,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF
        /// </summary>
        MaxComputeFixedGroupSizeArb = 0x91bf,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344
        /// </summary>
        MaxComputeVariableGroupInvocationsArb = 0x9344,

        /// <summary>
        /// Original was GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345
        /// </summary>
        MaxComputeVariableGroupSizeArb = 0x9345
    }
}
