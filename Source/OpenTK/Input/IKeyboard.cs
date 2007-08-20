#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

namespace OpenTK.Input
{
    public interface IKeyboard : IInputDevice
    {
        bool this[Key k] { get; }
        int NumberOfKeys { get; }
        int NumberOfFunctionKeys { get; }
        int NumberOfLeds { get; }
        long DeviceID { get; }

        event KeyDownEvent KeyDown;
        event KeyUpEvent KeyUp;
    }

    public delegate void KeyDownEvent(object sender, Key key);
    public delegate void KeyUpEvent(object sender, Key key);

    //public class KeyEventArgs : System.EventArgs
    //{
    //    private Key key;
    //    public Key Key { get { return key; } }
    //}
}