// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.


using System;

namespace OpenTK.Input
{
    [Flags]
    internal enum GamePadAxes : byte
    {
        LeftX = 1 << 0,
        LeftY = 1 << 1,
        LeftTrigger = 1 << 2,
        RightX = 1 << 3,
        RightY = 1 << 4,
        RightTrigger = 1 << 5,
    }
}

