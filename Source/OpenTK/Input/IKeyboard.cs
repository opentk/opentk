#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

namespace OpenTK.Input
{
    public interface IKeyboard : IInputDevice
    {
        bool this[Keys k] { get; }
    }
}