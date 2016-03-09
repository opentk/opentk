// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Identifies a specific OpenGL or OpenGL|ES error. Such exceptions are only thrown
    /// when OpenGL or OpenGL|ES automatic error checking is enabled -
    /// <see cref="GraphicsContext.ErrorChecking"/> property.
    /// Important: Do *not* catch this exception. Rather, fix the underlying issue that caused the error.
    /// </summary>
    public class GraphicsErrorException : GraphicsException
    {
        /// <summary>
        /// Constructs a new GraphicsErrorException instance with the specified error message.
        /// </summary>
        /// <param name="message"></param>
        public GraphicsErrorException(string message) : base(message) { }
    }
}
