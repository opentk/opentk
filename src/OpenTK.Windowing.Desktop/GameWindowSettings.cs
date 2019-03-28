using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    /// Implementation of <see cref="IGameWindowProperties"/>.
    /// <see cref="GameWindow"/> related settings.
    /// </summary>
    public class GameWindowSettings : IGameWindowProperties
    {
        /// <summary>
        /// The default <see cref="GameWindowSettings"/>.
        /// </summary>
        public static readonly GameWindowSettings Default = new GameWindowSettings();

        /// <inheritdoc/>
        public bool IsSingleThreaded { get; set; } = false;

        /// <inheritdoc/>
        public double RenderFrequency { get; set; } = 0.0;

        /// <inheritdoc/>
        public double UpdateFrequency { get; set; } = 0.0;
    }
}
