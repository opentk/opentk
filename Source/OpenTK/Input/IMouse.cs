#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    public interface IMouse : IInputDevice
    {
        int NumberOfButtons { get; }
        int NumberOfWheels { get; }
        IntPtr DeviceID { get; }
        int Wheel { get; }
        int X { get; }
        int Y { get; }
        int XDelta { get; }
        int YDelta { get; }

        //event MouseMoveEvent Move;
        event MouseButtonDownEvent ButtonDown;
        event MouseButtonUpEvent ButtonUp;
    }

    public delegate void MouseMoveEvent(IMouse sender, MouseMoveData key);
    public delegate void MouseButtonDownEvent(IMouse sender, MouseButton button);
    public delegate void MouseButtonUpEvent(IMouse sender, MouseButton button);
}
