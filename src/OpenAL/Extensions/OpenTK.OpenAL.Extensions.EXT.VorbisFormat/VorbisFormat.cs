using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.EXT.VorbisFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_vorbis")]
    public abstract class VorbisFormat : FormatExtensionBase<VorbisBufferFormat>, IVorbisFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected VorbisFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
