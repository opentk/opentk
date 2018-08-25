using AdvancedDLSupport;

namespace OpenTK.OpenAL.Extensions.EXT.MP3Format
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    public abstract class MP3Format : FormatExtensionBase<MP3BufferFormat>, IMP3Format
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MP3Format(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
