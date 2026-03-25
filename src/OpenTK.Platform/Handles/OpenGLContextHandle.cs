namespace OpenTK.Platform
{
    /// <summary>
    /// Handle to an OpenGL context.
    /// </summary>
    public abstract class OpenGLContextHandle : PalHandle
    {
        internal WindowHandle? WindowHandle { get; set; }
    }
}
