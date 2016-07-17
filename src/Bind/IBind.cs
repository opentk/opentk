#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using Bind.Structures;
using System.Collections.Generic;

namespace Bind
{
    interface IBind
    {
        DelegateCollection Delegates { get; }
        EnumCollection Enums { get; }
        FunctionCollection Wrappers { get; }
        Settings Settings { get; }

        IDictionary<string, string> GLTypes { get; }
        IDictionary<string, string> CSTypes { get; }

        void Process();
    }
}
