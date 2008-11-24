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
        GraphicsContext Context { get; }

        /// <summary>
        /// Gets the Id of this IGraphicsResource.
        /// </summary>
        int Id { get; }
    }
}
