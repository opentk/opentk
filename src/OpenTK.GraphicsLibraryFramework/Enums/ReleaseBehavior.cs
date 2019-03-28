namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// The context release behaviors.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(ContextReleaseBehaviorAttribute,ReleaseBehavior)"/>
    public enum ReleaseBehavior
    {
        /// <summary>
        /// Use the default release behavior of the platform.
        /// </summary>
        Any = 0,

        /// <summary>
        /// The pipeline will be flushed whenever the context is released from being the current one.
        /// </summary>
        Flush = 0x00035001,

        /// <summary>
        /// The pipeline will not be flushed on release.
        /// </summary>
        None = 0x00035002
    }
}
