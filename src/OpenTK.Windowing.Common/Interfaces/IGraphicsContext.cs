using System;

namespace OpenTK.Windowing.Common
{
    /// <summary>
    /// Defines the interface for OpenGL context management.
    /// </summary>
    public interface IGraphicsContext
    {
        /// <summary>
        /// Gets a value indicating whether the context is the current active on of the current thread.
        /// </summary>
        bool IsCurrent { get; }

        /// <summary>
        /// Gets or sets the swap interval (the number of screen updates to wait between swapping front and back buffers. See <see cref="SwapBuffers"/>).
        /// </summary>
        /// <value>
        /// The swap interval.
        /// </value>
        int SwapInterval { get; set; }

        /// <summary>
        /// Swaps the front and back buffers of the current GraphicsContext, presenting the rendered scene to the user.
        /// </summary>
        void SwapBuffers();

        /// <summary>
        /// Makes the GraphicsContext current on the calling thread.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Makes no GraphicsContext current one on the calling thread.
        /// </summary>
        void MakeNoneCurrent();
    }
}
