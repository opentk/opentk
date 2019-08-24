using AdvancedDLSupport;

namespace OpenToolkit.Core.API
{
    /// <summary>
    /// Base class for OpenTK APIs.
    /// </summary>
    public class APIBase : NativeLibraryBase, IAPI
    {
        /// <inheritdoc cref="NativeLibraryBase" />
        public APIBase(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
