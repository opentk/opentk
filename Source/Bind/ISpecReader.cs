#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System.Collections.Generic;
using System.IO;
using Bind.Structures;

namespace Bind
{
    interface ISpecReader
    {
        DelegateCollection ReadDelegates(StreamReader specFile);
        EnumCollection ReadEnums(StreamReader specFile);
        Dictionary<string, string> ReadTypeMap(StreamReader specFile);
        Dictionary<string, string> ReadCSTypeMap(StreamReader specFile);
    }
}
