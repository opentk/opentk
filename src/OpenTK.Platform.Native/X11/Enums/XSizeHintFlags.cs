using System;

namespace OpenTK.Platform.Native.X11
{
    [Flags]
    public enum XSizeHintFlags : long
    {
        UserPosition = (1 << 0),
        UserSize = (1 << 1),
        ProgramPosition = (1 << 2),
        ProgramSize = (1 << 3),
        MinSize = (1 << 4),
        MaxSize = (1 << 5),
        ResizeIncrements = (1 << 6),
        Aspect = (1 << 7),
        BaseSize = (1 << 8),
        WindowGravity = (1 << 9),
        AllProgramHints = ProgramPosition | ProgramSize | MinSize | MaxSize | ResizeIncrements | Aspect
    }
}
