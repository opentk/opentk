// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines a common interface to all OpenGL resources.
    /// </summary>
    interface IGraphicsResource : IDisposable
    {
        /// <summary>
        /// Gets the GraphicsContext that owns this resource.
        /// </summary>
        IGraphicsContext Context { get; }

        /// <summary>
        /// Gets the Id of this IGraphicsResource.
        /// </summary>
        int Id { get; }
    }
}
