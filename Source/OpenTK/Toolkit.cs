#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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

namespace OpenTK
{
    /// <summary>
    /// Provides static methods to manage an OpenTK application.
    /// </summary>
    public sealed class Toolkit
    {
        #region Constructors

        Toolkit() { }

        #endregion

        #region Public Members

        /// <summary>
        /// Initializes OpenTK. This method is necessary only if you are using OpenTK
        /// alongside a different windowing toolkit (e.g. GTK#) and should be the very
        /// first method called by your application (i.e. calling this method should be
        /// the very first statement executed by the "Main" method).
        /// </summary>
        /// <remarks>
        /// Some windowing toolkits do not configure the underlying platform
        /// correctly or configure it in a way that is incompatible with OpenTK.
        /// Calling this method first ensures that OpenTK is given the chance to
        /// initialize itself and configure the platform correctly.
        /// </remarks>
        public static void Init()
        {
            // The actual initialization takes place in the platform-specific factory
            // constructors.
            new Platform.Factory();
        }

        #endregion
    }
}
