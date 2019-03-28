namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Context related client api attribute.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(ContextClientApiAttribute,ClientApi)"/>
    public enum ContextClientApiAttribute
    {
        /// <summary>
        /// Indicates the client API provided by the window's context;
        /// either <see cref="GraphicsLibraryFramework.ClientApi.OpenGlApi"/>,
        /// <see cref="GraphicsLibraryFramework.ClientApi.OpenGlEsApi"/> or
        /// <see cref="GraphicsLibraryFramework.ClientApi.NoApi"/>.
        /// </summary>
        ClientApi = 0x00022001,
    }
}
