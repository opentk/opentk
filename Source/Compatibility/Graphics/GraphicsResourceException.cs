// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Represents exceptions related to IGraphicsResources.
    /// </summary>
    public class GraphicsResourceException : Exception
    {
        /// <summary>Constructs a new GraphicsResourceException.</summary>
        public GraphicsResourceException() : base() { }
        /// <summary>Constructs a new string with the specified error message.</summary>
        public GraphicsResourceException(string message) : base(message) { }
    }
}
