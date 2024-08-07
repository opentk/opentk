namespace OpenTK.Platform
{
    /// <summary>
    /// Hints provided for an abstraction layer about the graphics context being created.
    /// </summary>
    public abstract class GraphicsApiHints
    {
        /// <summary>
        /// Which graphics API the hints are for.
        /// </summary>
        public abstract GraphicsApi Api { get; }
    }
}
