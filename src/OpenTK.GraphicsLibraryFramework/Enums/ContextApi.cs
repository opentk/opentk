namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// The context API used to create the window context.
    /// </summary>
    public enum ContextApi
    {
        /// <summary>
        /// Uses the native context api to create the window context.
        /// </summary>
        NativeContextApi = 0x00036001,

        /// <summary>
        /// Uses Egl to create the window context.
        /// </summary>
        EglContextApi = 0x00036002
    }
}
