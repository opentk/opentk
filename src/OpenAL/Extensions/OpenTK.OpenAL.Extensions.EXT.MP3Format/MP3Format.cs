using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.EXT.MP3Format
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MP3")]
    public abstract class MP3Format : FormatExtensionBase<MP3BufferFormat>, IMP3Format
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MP3Format(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
