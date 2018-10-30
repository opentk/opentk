using AdvancedDLSupport;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL.Extensions.Creative.MultiChannelBuffers
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_EFX")]
    public abstract class MultiChannelBuffers : FormatExtensionBase<MultiChannelBufferFormat>, IMultiChannelBuffers
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MultiChannelBuffers(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
