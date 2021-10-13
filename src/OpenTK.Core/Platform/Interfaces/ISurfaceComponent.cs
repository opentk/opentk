namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for drivers which provide the surface component of the platform abstraction layer.
    /// </summary>
    public interface ISurfaceComponent : IPalComponent
    {
        /// <summary>
        /// Create a surface object.
        /// </summary>
        /// <returns>A surface object.</returns>
        SurfaceHandle Create();

        /// <summary>
        /// Destroy a surface object.
        /// </summary>
        /// <param name="handle">Handle to a surface.</param>
        void Destroy(SurfaceHandle handle);

        /// <summary>
        /// Get the display the surface is in.
        /// </summary>
        /// <param name="handle">Handle to a surface.</param>
        /// <returns>Handle to the display the surface is in.</returns>
        DisplayHandle GetDisplay(SurfaceHandle handle);

        /// <summary>
        /// Set the display the surface is in.
        /// </summary>
        /// <param name="handle">Handle to a surface.</param>
        /// <param name="display">Handle to the display to set the surface to.</param>
        void SetDisplay(SurfaceHandle handle, DisplayHandle display);
    }
}
