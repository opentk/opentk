using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Desktop
{
    public class GameWindowSettings : IGameWindowProperties
    {
        public static readonly GameWindowSettings Default = new GameWindowSettings();

        public bool IsSingleThreaded { get; set; } = false;

        public double RenderFrequency { get; set; } = 0.0;

        public double UpdateFrequency { get; set; } = 0.0;
    }
}