using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.EXT.DoubleFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_double")]
    public abstract class DoubleFormat : FormatExtensionBase<DoubleBufferFormat>, IDoubleFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected DoubleFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
