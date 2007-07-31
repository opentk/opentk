#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

namespace OpenTK.Input
{
    public interface IKeyboard
    {
        bool this[Keys k] { get; }
        //void Poll();
    }
}
