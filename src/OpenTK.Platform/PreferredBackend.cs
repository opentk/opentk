using OpenTK.Platform.Native;

namespace OpenTK.Platform
{
    /// <summary>
    /// This enum lists all backends that can be chosen in <see cref="PlatformComponents.PreferredBackend" />
    /// </summary>
    public enum PreferredBackend
    {
        EGL,
        SDL2,
        None
    }
}
