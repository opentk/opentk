using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.EXT.IMA4Format
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_IMA4")]
    public abstract class IMA4Format : FormatExtensionBase<IMA4BufferFormat>, IIMA4Format
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected IMA4Format(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
