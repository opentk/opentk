namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Initialization hints are set before <see cref="GLFW.Init"/> and affect how the library behaves until termination.
    /// Hints are set with <see cref="GLFW.InitHint(InitHintInt, int)"/>.
    /// </summary>
    /// <remarks>
    /// While this enum has no members,
    /// it can still be useful because it allows you to access the direct <c>glfwInitHint(int, int)</c> API.
    /// In case a future version of GLFW adds an int-taking int hint and we don't handle it.
    /// </remarks>
    public enum InitHintInt
    {
        /// <summary>
        /// Specifies whether to use libdecor for window decorations where available.
        /// Possible values are <see cref="WaylandLibDecor.PreferLibDecor"/> and <see cref="WaylandLibDecor.DisableLibDecor"/>. This is ignored on other platforms.
        /// </summary>
        WaylandLibDecor = 0x00053001,
    }
}
