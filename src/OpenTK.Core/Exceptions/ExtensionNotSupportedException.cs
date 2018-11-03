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

using System;

namespace OpenTK.Core.Exceptions
{
    /// <summary>
    /// Represents exceptions related to API extensions.
    /// </summary>
    public class ExtensionNotSupportedException : Exception
    {
        /// <summary>
        /// Gets the name of the extension.
        /// </summary>
        public string Extension { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionNotSupportedException"/> class.
        /// </summary>
        /// <param name="extension">The name of the extension.</param>
        public ExtensionNotSupportedException(string extension)
        {
            Extension = extension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionNotSupportedException"/> class.
        /// </summary>
        /// <param name="message">The error message of the ExtensionNotSupportedException.</param>
        /// <param name="extension">The name of the extension.</param>
        public ExtensionNotSupportedException(string message, string extension)
            : base(message)
        {
            Extension = extension;
        }
    }
}
