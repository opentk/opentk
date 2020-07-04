using System;

namespace OpenToolkit.Windowing.Common
{
    public interface IGraphicsContext
    {
        /// <summary>
        /// Gets a value indicating whether the context is the current active on of the current thread.
        /// </summary>
        bool IsCurrent { get; }

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
