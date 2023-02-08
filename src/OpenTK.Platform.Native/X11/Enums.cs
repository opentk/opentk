using System;

namespace OpenTK.Platform.Native.X11 {

    [Flags]
    public enum XWMHintsMask : long {
        InputHint = (1L << 0),
        StateHint = (1L << 1),
        IconPixmapHint = (1L << 2),
        IconWindowHint = (1L << 3),
        IconPositionHint = (1L << 4),
        IconMaskHint = (1L << 5),
        WindowGroupHint = (1L << 6),
        UrgencyHint = (1L << 8),
        AllHints = (InputHint|StateHint|IconPixmapHint|IconWindowHint|IconPositionHint|IconMaskHint|WindowGroupHint),
    }
}