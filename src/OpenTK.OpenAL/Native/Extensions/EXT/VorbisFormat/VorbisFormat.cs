using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Extensions.EXT.VorbisFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    public abstract class VorbisFormat : FormatExtensionBase<VorbisBufferFormat>, IVorbisFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected VorbisFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
