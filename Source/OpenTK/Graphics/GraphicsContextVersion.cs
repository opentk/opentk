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
    /// Defines the version information of a GraphicsContext.
    /// </summary>
    public sealed class GraphicsContextVersion
    {
        #region Fields

        int minor, major;
        string vendor = String.Empty, renderer = String.Empty;

        #endregion

        #region Constructors

        internal GraphicsContextVersion(int minor, int major, string vendor, string renderer)
        {
            Minor = minor;
            Major = major;
            Vendor = vendor;
            Renderer = renderer;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a System.Int32 indicating the minor version of a GraphicsContext instance.
        /// </summary>
        public int Minor { get { return minor; } private set { minor = value; } }

        /// <summary>
        /// Gets a System.Int32 indicating the major version of a GraphicsContext instance.
        /// </summary>
        public int Major { get { return major; } private set { major = value; } }

        /// <summary>
        /// Gets a System.String indicating the vendor of a GraphicsContext instance.
        /// </summary>
        public string Vendor { get { return vendor; } private set { vendor = value; } }

        /// <summary>
        /// Gets a System.String indicating the renderer of a GraphicsContext instance.
        /// </summary>
        public string Renderer { get { return renderer; } private set { renderer = value; } }

        #endregion
    }
}
