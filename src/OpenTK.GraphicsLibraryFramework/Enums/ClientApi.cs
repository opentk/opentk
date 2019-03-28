namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// The context client apis.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(ContextClientApiAttribute,ClientApi)"/>
    public enum ClientApi
    {
        /// <summary>
        /// No context API is created.
        /// </summary>
        NoApi = 0,

        /// <summary>
        /// OpenGL context is created.
        /// </summary>
        OpenGlApi = 0x00030001,

        /// <summary>
        /// OpenGL ES context is created.
        /// </summary>
        OpenGlEsApi = 0x00030002
    }
}
