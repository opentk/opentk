namespace Bind
{
    /// <summary>
    /// Holds target APIs that the binder can generate.
    /// </summary>
    public enum TargetAPI
    {
        /// <summary>
        /// All APIs should be generated.
        /// </summary>
        All,

        /// <summary>
        /// Generate API bindings for OpenGL 2.
        /// </summary>
        GL2,

        /// <summary>
        /// Generate API bindings for OpenGL 3.
        /// </summary>
        GL3,

        /// <summary>
        /// Generate API bindings for OpenGL 4.
        /// </summary>
        GL4,

        /// <summary>
        /// Generate API bindings for OpenGL ES 2.0.
        /// </summary>
        ES20,

        /// <summary>
        /// Generate API bindings for OpenGL ES 3.0.
        /// </summary>
        ES30,

        /// <summary>
        /// Generate API bindings for OpenGL ES 3.1.
        /// </summary>
        ES31
    }
}
