namespace OpenTK.OpenAL.Native.Extensions.EAX.XRam
{
    /// <summary>
    /// This enum is used to abstract the need of using AL.GetEnumValue() with the Extension. The values do NOT
    /// correspond to AL_STORAGE_* tokens!
    /// </summary>
    public enum BufferStorageMode
    {
        /// <summary>
        /// Put an Open AL Buffer into X-RAM if memory is available, otherwise use host RAM.  This is the default mode.
        /// </summary>
        Automatic,

        /// <summary>
        /// Force an Open AL Buffer into X-RAM, good for non-streaming buffers.
        /// </summary>
        Hardware,

        /// <summary>
        /// Force an Open AL Buffer into 'accessible' (currently host) RAM, good for streaming buffers.
        /// </summary>
        Accessible
    }
}
