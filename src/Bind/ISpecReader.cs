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
        void ReadDelegates(string file, DelegateCollection delegates, string apiname, string apiversion);
        void ReadEnums(string file, EnumCollection enums, string apiname, string apiversion);
        Dictionary<string, string> ReadTypeMap(string file);
        Dictionary<string, string> ReadCSTypeMap(string file);
    }
}
