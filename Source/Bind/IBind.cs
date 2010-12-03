#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using Bind.Structures;
namespace Bind
{
    interface IBind
    {
        DelegateCollection Delegates { get; }
        EnumCollection Enums { get; }
        FunctionCollection Wrappers { get; }
        void Process();
    }
}
