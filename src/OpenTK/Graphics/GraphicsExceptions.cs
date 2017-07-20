/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK team.
 * This notice may not be removed.
 * See license.txt for licensing detailed licensing details.
 */

using System;

namespace OpenTK
{
    /// <summary>Represents errors related to Graphics operations.</summary>
    public class GraphicsException : Exception
    {
        /// <summary>Constructs a new GraphicsException.</summary>
        public GraphicsException() : base() { }
        /// <summary>Constructs a new GraphicsException with the specified excpetion message.</summary>
        /// <param name="message"></param>
        public GraphicsException(string message) : base(message) { }
    }
}
