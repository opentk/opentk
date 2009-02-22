#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bind
{
    interface ISpecReader
    {
        Bind.Structures.DelegateCollection ReadDelegates(StreamReader specFile);
        Bind.Structures.EnumCollection ReadEnums(StreamReader specFile);
        Dictionary<string, string> ReadTypeMap(StreamReader specFile);
        Dictionary<string, string> ReadCSTypeMap(StreamReader specFile);
    }
}
