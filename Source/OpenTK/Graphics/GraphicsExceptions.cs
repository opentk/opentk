// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
censing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

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
