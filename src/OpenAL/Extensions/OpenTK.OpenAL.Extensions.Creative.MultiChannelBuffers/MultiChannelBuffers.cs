using AdvancedDLSupport;
using OpenTK.OpenAL.Native.Extensions;

namespace OpenTK.OpenAL.Extensions.Creative.MultiChannelBuffers
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    public abstract class MultiChannelBuffers : FormatExtensionBase<MultiChannelBufferFormat>, IMultiChannelBuffers
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MultiChannelBuffers(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
