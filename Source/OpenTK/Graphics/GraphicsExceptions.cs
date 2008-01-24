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
        public GraphicsModeException() : base() { }
        public GraphicsModeException(string message) : base(message) { }
    }

    /// <summary>Represents errors related to a GraphicsContext.</summary>
    public class GraphicsContextException : Exception
    {
        public GraphicsContextException() : base() { }
        public GraphicsContextException(string message) : base(message) { }
    }
}
