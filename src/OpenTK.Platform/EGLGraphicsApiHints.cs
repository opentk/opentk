namespace OpenTK.Platform
{
    /// <summary>
    /// Graphics API hints for OpenGL family of APIs with EGL-specific options.
    /// </summary>
    public class EGLGraphicsApiHints : OpenGLGraphicsApiHints
    {
        /// <summary>
        /// Whether to use ANGLE.
        /// </summary>
        public bool IsAngle { get; set; }
    }
}
