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
