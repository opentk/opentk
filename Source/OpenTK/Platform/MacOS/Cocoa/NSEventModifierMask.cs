// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;

namespace OpenTK.Platform.MacOS
{
    [Flags]
    enum NSEventModifierMask : uint
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
