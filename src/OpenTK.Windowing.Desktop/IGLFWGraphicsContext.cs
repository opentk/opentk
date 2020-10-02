using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    ///  Defines the interface for GLFW OpenGL context management.
    /// </summary>
    public interface IGLFWGraphicsContext : IGraphicsContext
    {
        /// <summary>
        /// The GLFW Window that represents the context.
        /// </summary>
        unsafe IntPtr WindowPtr { get; }
    }
}
