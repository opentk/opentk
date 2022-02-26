namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Handle to a window object.
    /// </summary>
    public abstract class WindowHandle
    {
        /// <summary>
        /// Tries to convert this WindowHandle into a platform specific handle,
        /// thowing a HandleMismatchException if the types don't match.
        /// </summary>
        /// <typeparam name="T">The platform specific handle type.</typeparam>
        /// <param name="component">The IPalComponent making this conversion.</param>
        /// <returns>The platform specific handle.</returns>
        /// <exception cref="HandleMismatchException{T}">If the handle wasn't of the platform specific handle type.</exception>
        internal T As<T>(IPalComponent component) where T : WindowHandle
        {
            if (this is T typedHandle)
            {
                return typedHandle;
            }
            else
            {
                throw new HandleMismatchException<T>(component, this);
            }
        }
    }
}
