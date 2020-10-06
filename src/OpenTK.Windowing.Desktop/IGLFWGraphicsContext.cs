using System;
using OpenTK.Windowing.Common;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    ///     Defines the interface for GLFW OpenGL context management.
    /// </summary>
    public interface IGLFWGraphicsContext : IGraphicsContext
    {
        /// <summary>
        /// The GLFW Window that represents the context.
        /// </summary>
        unsafe IntPtr WindowPtr { get; }
    }
}
