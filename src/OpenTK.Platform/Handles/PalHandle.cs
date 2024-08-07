#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Base class for all PAL handle objects.
    /// </summary>
    public abstract class PalHandle
    {
        /// <summary>
        /// General purpose object for your use.
        /// </summary>
        public object? UserData { get; set; }

        /// <summary>
        /// Tries to convert this PalHandle into a platform specific handle,
        /// throwing a HandleMismatchException if the types don't match.
        /// </summary>
        /// <typeparam name="T">The platform specific handle type.</typeparam>
        /// <param name="component">The IPalComponent making this conversion.</param>
        /// <returns>The platform specific handle.</returns>
        /// <exception cref="HandleMismatchException{T}">If the handle wasn't of the platform specific handle type.</exception>
        // FIXME: Should we move the throwing of the exception so that this function becomes inlined more?
        public T As<T>(IPalComponent component) where T : PalHandle
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
