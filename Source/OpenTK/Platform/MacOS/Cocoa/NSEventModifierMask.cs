using System;

namespace OpenTK.Platform.MacOS
{
    [Flags]
    public enum NSEventModifierMask : uint
    {
        AlphaShiftKeyMask = 65536U,
        ShiftKeyMask = 131072U,
        ControlKeyMask = 262144U,
        AlternateKeyMask = 524288U,
        CommandKeyMask = 1048576U,
        NumericPadKeyMask = 2097152U,
        HelpKeyMask = 4194304U,
        FunctionKeyMask = 8388608U,
        DeviceIndependentModifierFlagsMask = 4294901760U,
    }
}
