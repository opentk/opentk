#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>Represents errors related to unavailable graphics parameters..</summary>
    public class GraphicsModeException : Exception
    {
        /// <summary>Constructs a new GraphicsModeException.</summary>
        public GraphicsModeException() : base() { }
        /// <summary>Constructs a new GraphicsModeException with the given error message.</summary>
        public GraphicsModeException(string message) : base(message) { }
    }

    /// <summary>Represents errors related to a GraphicsContext.</summary>
    public class GraphicsContextException : Exception
    {
        /// <summary>Constructs a new GraphicsContextException.</summary>
        public GraphicsContextException() : base() { }
        /// <summary>Constructs a new GraphicsContextException with the given error message..</summary>
        public GraphicsContextException(string message) : base(message) { }
    }

    /// <summary>
    /// Thrown when an operation that required GraphicsContext is performed, when no
    /// GraphicsContext is current in the calling thread.
    /// </summary>
    public class GraphicsContextMissingException : GraphicsContextException
    {
        /// <summary>Constructs a new GraphicsContextMissingException.</summary>
        public GraphicsContextMissingException()
            : base(String.Format(
                "No context is current in the calling thread (ThreadId: {0}).",
                System.Threading.Thread.CurrentThread.ManagedThreadId))
        { }
    }
}
