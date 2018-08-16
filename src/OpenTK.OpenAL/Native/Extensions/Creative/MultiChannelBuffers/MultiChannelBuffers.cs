using System.Runtime.CompilerServices;
using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Extensions.Creative.MultiChannelBuffers
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    public abstract class MultiChannelBuffers : ExtensionBase, IMultiChannelBuffers
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MultiChannelBuffers(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc/>
        public abstract unsafe void BufferData(uint buffer, MultiChannelBufferFormat format, void* data, int size, int frequency);

        /// <summary>
        /// Fills a buffer with audio data.
        /// </summary>
        /// <typeparam name="TElement">The type of the data.</typeparam>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="format">The format of the data.</param>
        /// <param name="data">The data.</param>
        /// <param name="frequency">The frequency of the data.</param>
        public void BufferData<TElement>(uint buffer, MultiChannelBufferFormat format, TElement[] data, int frequency)
            where TElement : unmanaged
        {
            unsafe
            {
                var size = sizeof(TElement) * data.Length;
                fixed (void* ptr = &data[0])
                {
                    BufferData(buffer, format, ptr, size, frequency);
                }
            }
        }
    }
}
