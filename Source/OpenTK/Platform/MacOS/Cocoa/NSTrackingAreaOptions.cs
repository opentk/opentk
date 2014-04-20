using System;

namespace OpenTK.Platform.MacOS
{
    [Flags]
    public enum NSTrackingAreaOptions
    {
        MouseEnteredAndExited = 1,
        MouseMoved = 2,
        CursorUpdate = 4,
        ActiveWhenFirstResponder = 16,
        ActiveInKeyWindow = 32,
        ActiveInActiveApp = 64,
        ActiveAlways = 128,
        AssumeInside = 256,
        InVisibleRect = 512,
        EnabledDuringMouseDrag = 1024,
    }
}
