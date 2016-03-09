// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    interface IMouseDriver2
    {
        MouseState GetState();
        MouseState GetState(int index);
        void SetPosition(double x, double y);
        MouseState GetCursorState();
    }
}
