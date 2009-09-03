#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Enumerates various flags that affect the creation of new GraphicsContexts.
    /// </summary>
    [Flags]
    public enum GraphicsContextFlags
    {
        /// <summary>
        /// The default value of the GraphicsContextFlags enumeration.
        /// </summary>
        Default = 0x0000,
        /// <summary>
        /// Indicates that this is a debug GraphicsContext. Debug contexts may provide
        /// additional debugging information at the cost of performance.
        /// </summary>
        /// <remarks></remarks>
        Debug = 0x0001,
        /// <summary>
        /// Indicates that this is a forward compatible GraphicsContext. Forward-compatible contexts
        /// do not support functionality marked as deprecated in the current GraphicsContextVersion.
        /// </summary>
        /// <remarks>Forward-compatible contexts are defined only for OpenGL versions 3.0 and later.</remarks>
        ForwardCompatible = 0x0002,
        /// <summary>
        /// Indicates that this GraphicsContext is targeting OpenGL|ES.
        /// </summary>
        Embedded = 0x0004
    }
}
