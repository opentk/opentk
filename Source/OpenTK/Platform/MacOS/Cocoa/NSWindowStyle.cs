using System;

namespace OpenTK.Platform.MacOS
{
    [Flags]
    enum NSWindowStyle
    {
        Borderless = 0,
        Titled = 1,
        Closable = 2,
        Miniaturizable = 4,
        Resizable = 8,
        Utility = 16,
        DocModal = 64,
        NonactivatingPanel = 128,
        TexturedBackground = 256,
        Unscaled = 2048,
        UnifiedTitleAndToolbar = 4096,
        Hud = 8192,
        FullScreenWindow = 16384,
    }
}
