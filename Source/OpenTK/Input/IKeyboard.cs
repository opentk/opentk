#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;

namespace OpenTK.Input
{
    public interface IKeyboard : IInputDevice
    {
        bool this[Key k] { get; }
        int NumberOfKeys { get; }
        int NumberOfFunctionKeys { get; }
        int NumberOfLeds { get; }
        IntPtr DeviceID { get; }
        bool KeyRepeat { get; set; }

        event KeyDownEvent KeyDown;
        event KeyUpEvent KeyUp;
    }

    public delegate void KeyDownEvent(IKeyboard sender, Key key);
    public delegate void KeyUpEvent(IKeyboard sender, Key key);
}