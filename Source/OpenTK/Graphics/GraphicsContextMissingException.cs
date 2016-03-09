// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Thrown when an operation that required GraphicsContext is performed, when no
    /// GraphicsContext is current in the calling thread.
    /// </summary>
    public class GraphicsContextMissingException : GraphicsContextException
    {
        /// <summary>
        /// Constructs a new GraphicsContextMissingException.
        /// </summary>
        public GraphicsContextMissingException()
            : base(String.Format(
                "No context is current in the calling thread (ThreadId: {0}).",
                System.Threading.Thread.CurrentThread.ManagedThreadId))
        { }
    }
}
