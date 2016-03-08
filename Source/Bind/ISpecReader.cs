// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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
